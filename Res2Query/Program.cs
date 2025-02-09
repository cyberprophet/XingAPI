﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Res2Query
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentFolder = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string resFolder;

            if (args.Length >= 1)
            {
                resFolder = args[0];
            }
            else
            {
                resFolder = Path.Combine(currentFolder, "..", "..", "..", "Lib", "Res");
            }

            Dictionary<string, TypeInfo> typeList = new Dictionary<string, TypeInfo>();

            foreach (string file in Directory.EnumerateFiles(resFolder, "*.res"))
            {
                StringBuilder sb = new StringBuilder();

                string[] usingList = new string[]
                {
                    "System",
                    "System.IO",
                    "System.Collections.Generic",
                    "System.Linq",
                    "System.Runtime.InteropServices",
                    "System.Text",
                    "XingAPINet",
                };

                foreach (string usingName in usingList)
                {
                    sb.AppendLine($"using {usingName};");
                }

                sb.AppendLine();
                sb.AppendLine("namespace XingAPINet");
                sb.AppendLine("{");

                {

                    string text = ResToCSharpCode(file, typeList);
                    if (string.IsNullOrEmpty(text) == true)
                    {
                        continue;
                    }

                    sb.AppendLine(text);
                }

                sb.AppendLine("}");

                string csFileName = Path.GetFileNameWithoutExtension(file);
                File.WriteAllText($"{csFileName}.cs", sb.ToString(), Encoding.UTF8);
            }

            {
                File.WriteAllText($"EbestHelper.cs", TypeNameListToResourceCode(typeList), Encoding.UTF8);
            }
        }

        private static string TypeNameListToResourceCode(Dictionary<string, TypeInfo> typeList)
        {
            string tab = "\t";

            StringBuilder sbTypes = new StringBuilder();
            sbTypes.AppendLine("using System;");
            sbTypes.AppendLine("using XingAPINet;");
            sbTypes.AppendLine();

            sbTypes.AppendLine($"public static class XingTypeList");
            sbTypes.AppendLine($"{{");

            StringBuilder sbName = new StringBuilder();

            int numberOfList = 0;
            foreach (string typeName in typeList.Keys)
            {
                if (string.IsNullOrEmpty(typeName) == false)
                {
                    AddXmlHelp(sbTypes, $"{tab}", typeList[typeName].TypeDesc);
                    sbTypes.AppendLine($"{tab}public const string {typeName} = \"{typeName}\";");

                    sbName.AppendLine($"{tab}\ttypeof({typeList[typeName].TypeFullName}), // {typeList[typeName].TypeDesc}");

                    numberOfList++;
                }
            }

            sbTypes.AppendLine();

            sbTypes.AppendLine($"{tab}public static Type [] All = new Type []");
            sbTypes.AppendLine($"{tab}{{");
            sbTypes.AppendLine(sbName.ToString());
            sbTypes.AppendLine($"{tab}}};");

            sbTypes.AppendLine($"{tab}public const int Count = {numberOfList};");
            sbTypes.AppendLine($"}}");

            return sbTypes.ToString();
        }

        private static string ResToCSharpCode(string file, Dictionary<string, TypeInfo> typeList)
        {
            string tab = "\t";
            string typeName = null;
            string typeDesc = null;
            string classPerTypeName = null;

            bool dataMapStarted = false;

            StringBuilder sbClass = new StringBuilder();

            List<string> blockText = new List<string>();
            Dictionary<string, BlockInfo> blockFieldSetList = new Dictionary<string, BlockInfo>();
            bool blockStarted = false;
            bool isRealType = false;

            foreach (string line2 in File.ReadAllLines(file, Encoding.GetEncoding("ks_c_5601-1987")))
            {
                string item = line2.Trim();

                if (item.StartsWith(".Func,") == true)
                {
                    classPerTypeName = ToQueryTypeName(item, tab, out typeName, out typeDesc);

                    if (typeList.ContainsKey(typeName) == true)
                    {
                        return "";
                    }

                    typeList.Add(typeName, new TypeInfo(typeName, $"XQ{typeName}", typeDesc, false));
                    continue;
                }

                if (item.StartsWith(".Feed,") == true)
                {
                    classPerTypeName = ToRealTypeName(item, tab, out typeName, out typeDesc);

                    if (typeList.ContainsKey(typeName) == true)
                    {
                        return "";
                    }

                    isRealType = true;
                    typeList.Add(typeName, new TypeInfo(typeName, $"XR{typeName}", typeDesc, true));
                    continue;
                }

                if (item.StartsWith("BEGIN_DATA_MAP") == true)
                {
                    dataMapStarted = true;
                    continue;
                }

                if (dataMapStarted == false)
                {
                    continue;
                }

                if (item == "begin")
                {
                    blockStarted = true;
                    continue;
                }

                if (blockStarted == true && item == "end")
                {
                    string block = BlockToText(tab, isRealType, typeName, blockText, blockFieldSetList);
                    sbClass.AppendLine(block);
                    blockText.Clear();
                    blockStarted = false;
                    continue;
                }

                blockText.Add(item);
            }

            string classPrefix = (isRealType == true) ? "XR" : "XQ";

            AddXmlHelp(sbClass, $"{tab}", typeDesc);
            sbClass.AppendLine($"{tab}public partial class {classPrefix}{typeName} : " + ((isRealType == true) ? "XingReal" : "XingQuery"));
            sbClass.AppendLine($"{tab}{{");

            sbClass.AppendLine(classPerTypeName);

            sbClass.AppendLine();

            if (blockFieldSetList.Count >= 2 && isRealType == false)
            {
                sbClass.AppendLine(WriteSimpleGetMethod(blockFieldSetList, tab, classPrefix, typeName));
                sbClass.AppendLine(WriteReadFromDBMethod(blockFieldSetList, tab, classPrefix, typeName));
            }

            StringBuilder sbBlock = new StringBuilder();
            StringBuilder sbOutBlockList = new StringBuilder();

            foreach (string blockTypeName in blockFieldSetList.Keys)
            {
                if (blockFieldSetList[blockTypeName].BlockType == BlockType.input)
                {
                    sbBlock.AppendLine($"{tab}\tpublic bool SetBlock({classPrefix}{blockTypeName} block)");
                    sbBlock.AppendLine($"{tab}\t{{");
                    {
                        sbBlock.AppendLine($"{tab}\t\tif (block.VerifyData() == false)");
                        sbBlock.AppendLine($"{tab}\t\t{{");
                        sbBlock.AppendLine($"{tab}\t\t\treturn false; // throw new ApplicationException(\"Failed to verify: \" + block.BlockName);");
                        sbBlock.AppendLine($"{tab}\t\t}}");
                        sbBlock.AppendLine();

                        sbBlock.AppendLine(blockFieldSetList[blockTypeName].SetFieldData);

                    }
                    sbBlock.AppendLine($"{tab}\t\treturn true;");
                    sbBlock.AppendLine($"{tab}\t}}");
                    sbBlock.AppendLine();
                }
                else if (blockFieldSetList[blockTypeName].BlockType == BlockType.output)
                {
                    string arrayPostfix = (blockFieldSetList[blockTypeName].HasOccurs == true) ? "[]" : "";
                    string fromQuery = (blockFieldSetList[blockTypeName].HasOccurs == true) ? "ListFromQuery" : "FromQuery";
                    sbBlock.AppendLine($"{tab}\tpublic {classPrefix}{blockTypeName}{arrayPostfix} Get{GetBlockIndex(typeName, blockTypeName, blockFieldSetList[blockTypeName].HasOccurs)}()");
                    sbBlock.AppendLine($"{tab}\t{{");
                    {
                        sbBlock.AppendLine($"{tab}\t\t{classPrefix}{blockTypeName}{arrayPostfix} instance = {classPrefix}{blockTypeName}.{fromQuery}(this);");
                        sbBlock.AppendLine($"{tab}\t\treturn instance;");
                        sbBlock.AppendLine();
                    }
                    sbBlock.AppendLine($"{tab}\t}}");
                    sbBlock.AppendLine();

                    sbOutBlockList.AppendLine($"{tab}\t\ttypeof({classPrefix}{blockTypeName}),");
                }
            }

            sbBlock.AppendLine($"{tab}\tpublic static Type [] OutBlockTypes = new Type []");
            sbBlock.AppendLine($"{tab}\t{{");
            sbBlock.AppendLine(sbOutBlockList.ToString());
            sbBlock.AppendLine($"{tab}\t}};");

            sbClass.AppendLine(sbBlock.ToString());
            sbClass.AppendLine($"{tab}}}");

            return sbClass.ToString();
        }

        private static string WriteReadFromDBMethod(Dictionary<string, BlockInfo> blockFieldSetList, string tab, string classPrefix, string typeName)
        {
            if (blockFieldSetList.Count == 2)
            {
                var inBlock = blockFieldSetList.First();
                var outBlock = blockFieldSetList.Skip(1).First();

                if (inBlock.Value.BlockType == BlockType.input && outBlock.Value.BlockType == BlockType.output)
                {
                    return OutblockReadFromDB(inBlock, outBlock, tab, classPrefix, typeName);
                }
            }
            else if (blockFieldSetList.Count == 3)
            {
                var inBlock = blockFieldSetList.First();
                var outBlock = blockFieldSetList.Skip(1).First();
                var outBlocks = blockFieldSetList.Skip(2).First();

                if (inBlock.Value.BlockType == BlockType.input &&
                    (outBlock.Value.BlockType == BlockType.output && outBlock.Value.HasOccurs == false) &&
                    (outBlocks.Value.BlockType == BlockType.output && outBlocks.Value.HasOccurs == true))
                {
                    return OutblocksReadFromDB(inBlock, outBlock, outBlocks, tab, classPrefix, typeName);
                }
            }

            return "";
        }

        private static string OutblockReadFromDB(KeyValuePair<string, BlockInfo> inBlock, KeyValuePair<string, BlockInfo> outBlock, string tab, string classPrefix, string typeName)
        {
            StringBuilder sbGet = new StringBuilder();

            string arrayPostfix = (outBlock.Value.HasOccurs == true) ? "[]" : "";

            sbGet.AppendLine($"{tab}\tpublic static {classPrefix}{outBlock.Key}{arrayPostfix} ReadFromDB(string tableNamePostfix = null /*, {inBlock.Value.GetParams} */)");
            sbGet.AppendLine($"{tab}\t{{");

            sbGet.AppendLine($"{tab}\t\tusing ({classPrefix}{typeName} instance = new {classPrefix}{typeName}())");
            sbGet.AppendLine($"{tab}\t\t{{");
            sbGet.AppendLine();
            
            sbGet.AppendLine($"{tab}\t\t\tstring tableName = (tableNamePostfix == null) ? \"{classPrefix}{outBlock.Key}\" : $\"{classPrefix}{outBlock.Key}_{{tableNamePostfix}}\";");

            sbGet.AppendLine($"{tab}\t\t\tQueryOption qo = new QueryOption(tableName);");
            sbGet.AppendLine($"{inBlock.Value.QueryOptionList}");
            sbGet.AppendLine();

            string many = (outBlock.Value.HasOccurs == true) ? "Many" : "";

            sbGet.AppendLine($"{tab}\t\t\tvar outBlock = instance.Select{many}<{classPrefix}{outBlock.Key}>(qo);");
            sbGet.AppendLine($"{tab}\t\t\treturn outBlock;");

            sbGet.AppendLine($"{tab}\t\t}}");
            sbGet.AppendLine($"{tab}\t}}");

            return sbGet.ToString();
        }


        private static string OutblocksReadFromDB(KeyValuePair<string, BlockInfo> inBlock,
            KeyValuePair<string, BlockInfo> outBlock,
            KeyValuePair<string, BlockInfo> outBlocks, string tab, string classPrefix, string typeName)
        {
            StringBuilder sbGet = new StringBuilder();
            string multipleOutblockTypeName = $"{classPrefix}AllOutBlocks";

            sbGet.AppendLine($"{tab}\tpublic static {multipleOutblockTypeName} ReadFromDB(string tableNamePostfix = null /*, {inBlock.Value.GetParams} */)");
            sbGet.AppendLine($"{tab}\t{{");

            sbGet.AppendLine($"{tab}\t\tusing ({classPrefix}{typeName} instance = new {classPrefix}{typeName}())");
            sbGet.AppendLine($"{tab}\t\t{{");
            sbGet.AppendLine();

            sbGet.AppendLine($"{tab}\t\t\t{multipleOutblockTypeName} results = new {multipleOutblockTypeName}();");
            sbGet.AppendLine();

            sbGet.AppendLine($"{tab}\t\t\tstring tableName = (tableNamePostfix == null) ? \"{classPrefix}{outBlock.Key}\" : $\"{classPrefix}{outBlock.Key}_{{tableNamePostfix}}\";");

            sbGet.AppendLine($"{tab}\t\t\tQueryOption qo = new QueryOption(tableName);");

            sbGet.AppendLine($"{tab}\t\t\tresults.{RemoveBlockClode(outBlock.Key)} = instance.Select<{classPrefix}{outBlock.Key}>(qo);");
            sbGet.AppendLine();

            sbGet.AppendLine($"{tab}\t\t\ttableName = (tableNamePostfix == null) ? \"{classPrefix}{outBlocks.Key}\" : $\"{classPrefix}{outBlocks.Key}_{{tableNamePostfix}}\";");

            sbGet.AppendLine($"{tab}\t\t\tqo = new QueryOption(tableName);");
            sbGet.AppendLine($"{tab}\t\t\tresults.{RemoveBlockClode(outBlocks.Key)} = instance.SelectMany<{classPrefix}{outBlocks.Key}>(qo);");
            sbGet.AppendLine($"{tab}\t\t\treturn results;");

            sbGet.AppendLine($"{tab}\t\t}}");
            sbGet.AppendLine($"{tab}\t}}");

            return sbGet.ToString();

            string RemoveBlockClode(string blockName)
            {
                int pos = blockName.IndexOf("Out");
                if (pos == -1)
                {
                    return blockName;
                }

                return blockName.Substring(pos);
            }
        }

        private static string WriteSimpleGetMethod(Dictionary<string, BlockInfo> blockFieldSetList, string tab, string classPrefix, string typeName)
        {
            if (blockFieldSetList.Count == 2)
            {
                var inBlock = blockFieldSetList.First();
                var outBlock = blockFieldSetList.Skip(1).First();

                if (inBlock.Value.BlockType == BlockType.input && outBlock.Value.BlockType == BlockType.output)
                {
                    return WriteInblockAndOutblock(inBlock, outBlock, tab, classPrefix, typeName);
                }
            }
            else if (blockFieldSetList.Count == 3)
            {
                var inBlock = blockFieldSetList.First();
                var outBlock = blockFieldSetList.Skip(1).First();
                var outBlocks = blockFieldSetList.Skip(2).First();

                if (inBlock.Value.BlockType == BlockType.input &&
                    (outBlock.Value.BlockType == BlockType.output && outBlock.Value.HasOccurs == false) &&
                    (outBlocks.Value.BlockType == BlockType.output && outBlocks.Value.HasOccurs == true))
                {
                    return WriteInblockAndMultipleOutblock(inBlock, outBlock, outBlocks, tab, classPrefix, typeName);
                }
            }

            return "";
        }



        private static string WriteInblockAndOutblock(KeyValuePair<string, BlockInfo> inBlock, KeyValuePair<string, BlockInfo> outBlock, string tab, string classPrefix, string typeName)
        {
            StringBuilder sbGet = new StringBuilder();

            string arrayPostfix = (outBlock.Value.HasOccurs == true) ? "[]" : "";

            sbGet.AppendLine($"{tab}\tpublic static {classPrefix}{outBlock.Key}{arrayPostfix} Get({inBlock.Value.GetParams})");
            sbGet.AppendLine($"{tab}\t{{");

            sbGet.AppendLine($"{tab}\t\tusing ({classPrefix}{typeName} instance = new {classPrefix}{typeName}())");
            sbGet.AppendLine($"{tab}\t\t{{");
            sbGet.AppendLine($"{inBlock.Value.GetParamsSetFieldData}");
            sbGet.AppendLine($"{tab}\t\t\tif (instance.Request() < 0)");
            sbGet.AppendLine($"{tab}\t\t\t{{");
            sbGet.AppendLine($"{tab}\t\t\t\treturn null;");
            sbGet.AppendLine($"{tab}\t\t\t}}");
            sbGet.AppendLine();

            sbGet.AppendLine($"{tab}\t\t\tvar outBlock = instance.Get{GetBlockIndex(typeName, outBlock.Key, outBlock.Value.HasOccurs)}();");

            if (outBlock.Value.HasOccurs == true)
            {
                sbGet.AppendLine($"{tab}\t\t\treturn outBlock;");
            }
            else
            {
                sbGet.AppendLine($"{tab}\t\t\tif (outBlock.IsValidData == false)");
                sbGet.AppendLine($"{tab}\t\t\t{{");
                sbGet.AppendLine($"{tab}\t\t\t\treturn null;");
                sbGet.AppendLine($"{tab}\t\t\t}}");
                sbGet.AppendLine($"{tab}\t\t\treturn outBlock;");
            }

            sbGet.AppendLine($"{tab}\t\t}}");
            sbGet.AppendLine($"{tab}\t}}");

            return sbGet.ToString();
        }

        private static string WriteInblockAndMultipleOutblock(KeyValuePair<string, BlockInfo> inBlock,
            KeyValuePair<string, BlockInfo> outBlock,
            KeyValuePair<string, BlockInfo> outBlocks, string tab, string classPrefix, string typeName)
        {
            StringBuilder sbGet = new StringBuilder();
            string multipleOutblockTypeName = $"{classPrefix}AllOutBlocks";

            string arrayPostfix = (outBlocks.Value.HasOccurs == true) ? "[]" : "";

            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{tab}\tpublic class {multipleOutblockTypeName}");
                sb.AppendLine($"{tab}\t{{");

                sb.AppendLine($"{tab}\t\tpublic {classPrefix}{outBlock.Key} {RemoveBlockClode(outBlock.Key)} {{ get; internal set; }}");
                sb.AppendLine($"{tab}\t\tpublic {classPrefix}{outBlocks.Key}{arrayPostfix} {RemoveBlockClode(outBlocks.Key)} {{ get; internal set; }}");

                sb.AppendLine($"{tab}\t}}");

                sbGet.AppendLine(sb.ToString());
            }

            sbGet.AppendLine($"{tab}\tpublic static {multipleOutblockTypeName} Get({inBlock.Value.GetParams})");
            sbGet.AppendLine($"{tab}\t{{");

            sbGet.AppendLine($"{tab}\t\tusing ({classPrefix}{typeName} instance = new {classPrefix}{typeName}())");
            sbGet.AppendLine($"{tab}\t\t{{");
            sbGet.AppendLine($"{inBlock.Value.GetParamsSetFieldData}");
            sbGet.AppendLine($"{tab}\t\t\tif (instance.Request() < 0)");
            sbGet.AppendLine($"{tab}\t\t\t{{");
            sbGet.AppendLine($"{tab}\t\t\t\treturn null;");
            sbGet.AppendLine($"{tab}\t\t\t}}");
            sbGet.AppendLine();

            sbGet.AppendLine($"{tab}\t\t\t{multipleOutblockTypeName} results = new {multipleOutblockTypeName}();");

            sbGet.AppendLine($"{tab}\t\t\tresults.{RemoveBlockClode(outBlock.Key)} = instance.Get{GetBlockIndex(typeName, outBlock.Key, outBlock.Value.HasOccurs)}();");
            sbGet.AppendLine($"{tab}\t\t\tif (results.{RemoveBlockClode(outBlock.Key)}.IsValidData == false)");
            sbGet.AppendLine($"{tab}\t\t\t{{");
            sbGet.AppendLine($"{tab}\t\t\t\treturn null;");
            sbGet.AppendLine($"{tab}\t\t\t}}");

            sbGet.AppendLine();

            sbGet.AppendLine($"{tab}\t\t\tresults.{RemoveBlockClode(outBlocks.Key)} = instance.Get{GetBlockIndex(typeName, outBlocks.Key, outBlocks.Value.HasOccurs)}();");
            sbGet.AppendLine($"{tab}\t\t\treturn results;");

            sbGet.AppendLine($"{tab}\t\t}}");
            sbGet.AppendLine($"{tab}\t}}");

            return sbGet.ToString();

            string RemoveBlockClode(string blockName)
            {
                int pos = blockName.IndexOf("Out");
                if (pos == -1)
                {
                    return blockName;
                }

                return blockName.Substring(pos);
            }
        }

        public static string GetBlockIndex(string typeName, string blockTypeName, bool hasOccurs)
        {
            return blockTypeName.Substring(typeName.Length + "Out".Length) + ((hasOccurs == true) ? "s" : "");
        }

        private static string BlockToText(string tab, bool isRealType, string queryTypeName, List<string> blockText,
            Dictionary<string, BlockInfo> blockFieldSetList)
        {
            StringBuilder sb = new StringBuilder();
            string typeName;
            string typeCode;
            bool hasOccurs = false;

            string classPrefix = (isRealType == true) ? "XR" : "XQ";

            {
                string[] items = blockText[0].Trim(' ', ';').Split(',');

                typeName = (isRealType == true) ? queryTypeName + items[0] : items[0];
                string typeDesc = items[1];
                typeCode = items[2];
                if (items.Length >= 4)
                {
                    if (items[3] == "occurs")
                    {
                        hasOccurs = true;
                    }
                }

                sb.AppendLine($"{tab}public partial class {classPrefix}{typeName} : XingBlock");
                sb.AppendLine($"{tab}{{");

                {
                    AddField(sb, tab + "\t", "string", "_blockName", items[0]);
                    AddField(sb, tab + "\t", "string", "_blockDesc", typeDesc);
                    AddField(sb, tab + "\t", "string", "_blockType", typeCode);
                    AddField(sb, tab + "\t", "bool", "_hasOccurs", hasOccurs);

                    AddGetProperty(sb, tab + "\t", "override string", "GetBlockName()", "_blockName", items[0]);
                    AddGetProperty(sb, tab + "\t", "static string", "BlockName", "_blockName", items[0]);
                    AddGetProperty(sb, tab + "\t", "string", "BlockDesc", "_blockDesc", typeDesc);
                    AddGetProperty(sb, tab + "\t", "string", "BlockType", "_blockType", typeCode);
                    AddGetProperty(sb, tab + "\t", "bool", "HasOccurs", "_hasOccurs", hasOccurs);
                }

                if (blockFieldSetList.ContainsKey(typeName) == true)
                {
                    throw new ApplicationException("Duplicated: " + typeName);
                }
            }

            sb.AppendLine();

            StringBuilder setFields = new StringBuilder();
            StringBuilder getFields = new StringBuilder();
            StringBuilder setByFieldNames = new StringBuilder();

            string baseClassInstance = (isRealType == true) ? "_xaReal" : "_xaQuery";

            StringBuilder fieldList = new StringBuilder();
            StringBuilder AllFields = new StringBuilder();
            StringBuilder getParams = new StringBuilder();
            StringBuilder getParamsSetFieldData = new StringBuilder();
            StringBuilder queryOptionList = new StringBuilder();

            fieldList.AppendLine();
            fieldList.AppendLine($"{tab}\tpublic static class F");
            fieldList.AppendLine($"{tab}\t{{");

            AllFields.AppendLine($"{tab}\tpublic static string[] AllFields = new string[]");
            AllFields.AppendLine($"{tab}\t{{");

            Dictionary<string, int> uniqueId = new Dictionary<string, int>();

            foreach (string item in blockText.Skip(1))
            {
                if (string.IsNullOrEmpty(item) == true)
                {
                    continue;
                }

                string[] items = item.Split(',', ';');

                string fieldDesc = items[0].Trim();
                // string name1 = items[1].Trim();
                string name2 = items[2].Trim();

                if (items.Length >= 4)
                {
                    if (items[3] == "occurs")
                    {
                        hasOccurs = true;
                    }
                }

                //if (name1 != name2)
                //{
                //    t1102OutBlock - 외국계매도평단가,ftradmdvag,ftradmdavg,long,8;
                //    throw new ApplicationException($"NOT EXPECTED: {name1} != {name2}");
                //}

                string fieldType = items[3].Trim();
                decimal formatOrLen = decimal.Parse(items[4].Trim());

                {
                    AddXmlHelp(sb, tab + "\t", fieldDesc);
                    sb.AppendLine($"{tab}\t[XAQueryFieldAttribute(\"{GetUniqueName(uniqueId, name2)}\", \"{fieldDesc}\", \"{fieldType}\", \"{formatOrLen}\")]");
                    sb.AppendLine($"{tab}\tpublic {GetFieldType(fieldType, formatOrLen)} {name2};");
                }

                string addTab = (hasOccurs == true) ? "\t" : "";
                string useIndex = (hasOccurs == true) ? "i" : "0";

                if (isRealType == true)
                {
                    setFields.AppendLine($"{tab}{addTab}\t\t{baseClassInstance}.SetFieldData(block.GetBlockName(), \"{name2}\", block.{name2}{SetFieldToStringExp(fieldType, formatOrLen)}); // {fieldType} {formatOrLen}");
                    getFields.AppendLine($"{tab}{addTab}\t\t\tblock.{name2} = query.GetFieldData(block.GetBlockName(), \"{name2}\"){GetFieldToStringExp(fieldType, name2, formatOrLen)}; // {fieldType} {formatOrLen}");
                }
                else
                {
                    setFields.AppendLine($"{tab}{addTab}\t\t{baseClassInstance}.SetFieldData(block.GetBlockName(), \"{name2}\", 0, block.{name2}{SetFieldToStringExp(fieldType, formatOrLen)}); // {fieldType} {formatOrLen}");
                    getFields.AppendLine($"{tab}{addTab}\t\t\tblock.{name2} = query.GetFieldData(block.GetBlockName(), \"{name2}\", {useIndex}){GetFieldToStringExp(fieldType, name2, formatOrLen)}; // {fieldType} {formatOrLen}");
                }

                AddXmlHelp(fieldList, $"{tab}\t\t", fieldDesc);
                fieldList.AppendLine($"{tab}\t\tpublic const string {name2} = \"{name2}\";");
                AllFields.AppendLine($"{tab}\t\tF.{name2},");

                setByFieldNames.AppendLine($"{tab}\t\t\tcase \"{name2}\":");
                setByFieldNames.AppendLine($"{tab}\t\t\t\tthis.{name2} = fieldInfo.FieldValue{GetFieldToStringExp(fieldType, name2, formatOrLen)};");
                setByFieldNames.AppendLine($"{tab}\t\t\tbreak;");
                setByFieldNames.AppendLine();

                getParams.Append($"{GetFieldType(fieldType, formatOrLen)} {name2} = default,");
                getParamsSetFieldData.AppendLine($"{tab}\t\t\tinstance.SetFieldData({classPrefix}{typeName}.BlockName, {classPrefix}{typeName}.F.{name2}, 0, {name2}{SetFieldToStringExp(fieldType, formatOrLen)}); // {fieldType} {formatOrLen}");
                queryOptionList.AppendLine($"{tab}\t\t\t// if ({name2} != default) qo.Add(\"{name2}\", {name2});");
            }

            fieldList.AppendLine($"{tab}\t}}");
            AllFields.AppendLine($"{tab}\t}};");

            sb.AppendLine(fieldList.ToString());
            sb.AppendLine(AllFields.ToString());

            blockFieldSetList[typeName] = new BlockInfo(typeCode, setFields.ToString(), getParams.ToString().Trim(','), getParamsSetFieldData.ToString(), queryOptionList.ToString(), hasOccurs);

            // public Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
            {
                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()");
                sb.AppendLine($"{tab}\t{{");
                sb.AppendLine($"{tab}\t\tDictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();");
                foreach (string item in blockText.Skip(1))
                {
                    if (string.IsNullOrEmpty(item) == true)
                    {
                        continue;
                    }

                    string[] items = item.Split(',', ';');

                    string fieldDesc = items[0].Trim();
                    string name2 = items[2].Trim();
                    string fieldType = items[3].Trim();
                    decimal formatOrLen = decimal.Parse(items[4].Trim());

                    sb.AppendLine($"{tab}\t\tdict[\"{name2}\"] = new XAQueryFieldInfo(\"{fieldType}\", {name2}, {name2}{SetFieldToStringExp(fieldType, formatOrLen)}, \"{fieldDesc}\", (decimal){formatOrLen});");
                }

                sb.AppendLine();
                sb.AppendLine($"{tab}\t\treturn dict;");
                sb.AppendLine($"{tab}\t}}");
            }

            sb.AppendLine();

            string switchCasesFields = setByFieldNames.ToString();
            sb.AppendLine($"{tab}\tpublic override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)");
            sb.AppendLine($"{tab}\t{{");
            if (switchCasesFields.Length != 0)
            {
                sb.AppendLine($"{tab}\t\tswitch (fieldName)");
                sb.AppendLine($"{tab}\t\t{{");
                sb.AppendLine($"{switchCasesFields}");
                sb.AppendLine($"{tab}\t\t}}");
            }
            sb.AppendLine($"{tab}\t}}");

            // public bool FromQuery
            if (blockFieldSetList[typeName].BlockType == BlockType.output)
            {
                sb.AppendLine();

                string arrayPostfix = (blockFieldSetList[typeName].HasOccurs == true) ? "[]" : "";
                string fromQuery = (blockFieldSetList[typeName].HasOccurs == true) ? "ListFromQuery" : "FromQuery";

                sb.AppendLine($"{tab}\tpublic static {classPrefix}{typeName}{arrayPostfix} {fromQuery}({classPrefix}{queryTypeName} query)");
                sb.AppendLine($"{tab}\t{{");

                if (blockFieldSetList[typeName].HasOccurs == false)
                {
                    sb.AppendLine($"{tab}\t\t{classPrefix}{typeName} block = new {classPrefix}{typeName}();");
                    sb.AppendLine($"{tab}\t\tblock.IsValidData = true;");
                    sb.AppendLine($"{tab}\t\tblock.InvalidReason = \"\";");

                    if (isRealType == false)
                    {
                        sb.AppendLine($"{tab}\t\tif (query.QueryResult != null && query.QueryResult.IsSystemError == true)");
                        sb.AppendLine($"{tab}\t\t{{");
                        sb.AppendLine($"{tab}\t\t\tblock.IsValidData = false;");
                        sb.AppendLine($"{tab}\t\t\tblock.InvalidReason = query.ReceiveMessage;");
                        sb.AppendLine($"{tab}\t\t\treturn block;");
                        sb.AppendLine($"{tab}\t\t}}");
                    }

                    sb.AppendLine($"{tab}\t\ttry");
                    sb.AppendLine($"{tab}\t\t{{");

                    sb.AppendLine(getFields.ToString());

                    sb.AppendLine($"{tab}\t\t}} catch (InvalidDataFormatException e) {{");
                    sb.AppendLine($"{tab}\t\t\tblock.IsValidData = false;");

                    sb.AppendLine($"{tab}\t\t\tblock.InvalidReason = $\"FieldName == {{e.DataFieldName}}, FieldData == \\\"{{e.DataValue}}\\\"\";");

                    sb.AppendLine($"{tab}\t\t}}");
                    sb.AppendLine($"{tab}\t\treturn block;");
                    sb.AppendLine();
                    sb.AppendLine($"{tab}\t}}");
                }
                else
                {
                    sb.AppendLine($"{tab}\t\tint count = query.GetBlockCount({classPrefix}{typeName}.BlockName);");
                    sb.AppendLine($"{tab}\t\tList<{classPrefix}{typeName}> list = new List<{classPrefix}{typeName}>();");

                    if (isRealType == false)
                    {
                        sb.AppendLine($"{tab}\t\tif (query.QueryResult != null && query.QueryResult.IsSystemError == true)");
                        sb.AppendLine($"{tab}\t\t{{");
                        sb.AppendLine($"{tab}\t\t\treturn list.ToArray();");
                        sb.AppendLine($"{tab}\t\t}}");
                    }

                    sb.AppendLine($"{tab}\t\tfor (int i = 0; i < count; i ++)");
                    sb.AppendLine($"{tab}\t\t{{");
                    {
                        sb.AppendLine($"{tab}\t\t\t{classPrefix}{typeName} block = new {classPrefix}{typeName}();");
                        sb.AppendLine($"{tab}\t\t\tblock.IsValidData = true;");
                        sb.AppendLine($"{tab}\t\t\tblock.InvalidReason = \"\";");


                        sb.AppendLine($"{tab}\t\t\ttry");
                        sb.AppendLine($"{tab}\t\t\t{{");

                        sb.AppendLine(getFields.ToString());

                        sb.AppendLine($"{tab}\t\t\t}} catch (InvalidDataFormatException e) {{");
                        sb.AppendLine($"{tab}\t\t\t\tblock.IsValidData = false;");

                        sb.AppendLine($"{tab}\t\t\t\tblock.InvalidReason = $\"FieldName == {{e.DataFieldName}}, FieldData == \\\"{{e.DataValue}}\\\"\";");

                        sb.AppendLine($"{tab}\t\t\t}}");
                        sb.AppendLine($"{tab}\t\t\tlist.Add(block);");
                        sb.AppendLine($"{tab}\t\t}}");
                    }

                    sb.AppendLine($"{tab}\t\treturn list.ToArray();");
                    sb.AppendLine();
                    sb.AppendLine($"{tab}\t}}");
                }
            }

            // public bool VerifyData
            {
                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic bool VerifyData()");
                sb.AppendLine($"{tab}\t{{");
                foreach (string item in blockText.Skip(1))
                {
                    if (string.IsNullOrEmpty(item) == true)
                    {
                        continue;
                    }

                    string[] items = item.Split(',', ';');

                    string name2 = items[2].Trim();
                    string fieldType = items[3].Trim();
                    decimal formatOrLen = decimal.Parse(items[4].Trim());

                    switch (GetFieldType(fieldType, formatOrLen))
                    {
                        case "long":
                            sb.AppendLine($"{tab}\t\tif ({name2}.ToString().Length > {formatOrLen}) return false; // {fieldType} {formatOrLen}");
                            break;

                        case "string":
                            sb.AppendLine($"{tab}\t\tif ({name2}?.Length > {formatOrLen}) return false; // {fieldType} {formatOrLen}");
                            break;

                        default:
                            sb.AppendLine($"{tab}\t\t// {name2} {fieldType} {formatOrLen}");
                            break;
                    }
                }

                sb.AppendLine();
                sb.AppendLine($"{tab}\t\treturn true;");
                sb.AppendLine($"{tab}\t}}");
            }


            // public void CopyTo(...);
            {
                sb.AppendLine();

                sb.AppendLine($"{tab}\tpublic void CopyTo({classPrefix}{typeName} block)");
                sb.AppendLine($"{tab}\t{{");
                foreach (string item in blockText.Skip(1))
                {
                    if (string.IsNullOrEmpty(item) == true)
                    {
                        continue;
                    }

                    string[] items = item.Split(',', ';');
                    string name2 = items[2].Trim();
                    sb.AppendLine($"{tab}\t\tblock.{name2} = this.{name2};");
                }

                sb.AppendLine();
                sb.AppendLine($"{tab}\t}}");
            }

            sb.AppendLine($"{tab}}}");

            return sb.ToString();
        }

        private static string EncodeXml(string fieldDesc)
        {
            fieldDesc = fieldDesc.Replace("&", "&amp;");
            fieldDesc = fieldDesc.Replace(">", "&gt;");
            return fieldDesc.Replace("<", "&lt;");
        }

        public static string GetUniqueName(Dictionary<string, int> dict, string name)
        {
            string key = name.ToLower();

            if (dict.ContainsKey(key) == false)
            {
                dict[key] = 1;
                return name;
            }

            dict[key]++;

            return $"{name}_{dict[key]}";
        }

        public static string GetFieldToStringExp(string typeName, string fieldName, decimal length)
        {
            switch (typeName)
            {
                case "char":
                    if (length == 1)
                    {
                        return $".FirstOrDefault()";
                    }
                    break;

                case "int":
                    return $".ParseInt(\"{fieldName}\")";

                case "long":
                    return $".ParseLong(\"{fieldName}\")";

                case "float":
                    return $".ParseFloat(\"{fieldName}\")";

                case "double":
                    return $".ParseDouble(\"{fieldName}\")";
            }

            return ".TrimEnd('?')";
        }

        public static string SetFieldToStringExp(string typeName, decimal length)
        {
            switch (typeName)
            {
                case "char":
                    if (length == 1)
                    {
                        return ".ToString()";
                    }

                    return "";

                case "long":
                    return $".ToString(\"d{length}\")";

                case "int":
                    return $".ToString(\"d{length}\")";

                case "float":
                case "double":
                    return $".ToString(\"{ToDoubleFormatSpecifier(length.ToString())}\")";
            }

            return "";
        }

        private static string ToDoubleFormatSpecifier(string text)
        {
            string[] digits = text.Split('.');
            if (digits.Length > 2)
            {
                throw new ApplicationException("Invalid float/double format specifier");
            }

            int integral = Int32.Parse(digits[0]);

            if (digits.Length == 1)
            {
                return new string('0', integral);
            }
            else
            {
                int fraction = Int32.Parse(digits[1]);
                return new string('0', integral) + "." + new string('0', fraction);
            }
        }

        public static string GetFieldType(string typeName, decimal length)
        {
            switch (typeName)
            {
                case "char":
                    if (length == 1)
                    {
                        return typeName;
                    }

                    return "string";

                case "date":
                    return "string";
            }

            return typeName;
        }

        static string ToRealTypeName(string line, string tab, out string typeName, out string typeDesc)
        {
            string[] items = line.Trim(' ', ';').Split(',');

            typeDesc = items[1].Trim();
            typeName = items[2].Trim();
            int key = 0;
            int group = 0;
            bool hasAttr = false;

            foreach (string item in items)
            {
                string[] keyValue = item.Split('=');
                switch (keyValue[0])
                {
                    case "attr":
                        hasAttr = true;
                        break;

                    case "key":
                        key = int.Parse(keyValue[1]);
                        break;

                    case "group":
                        group = int.Parse(keyValue[1]);
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();

            {
                AddField(sb, tab + "\t", "string", "_typeName", typeName);
                AddField(sb, tab + "\t", "string", "_typeDesc", typeDesc);
                AddField(sb, tab + "\t", "bool", "_attr", hasAttr);
                AddField(sb, tab + "\t", "int", "_key", key);
                AddField(sb, tab + "\t", "int", "_group", group);

                sb.AppendLine();

                AddGetProperty(sb, tab + "\t", "string", "TypeName", "_typeName", typeName);
                AddGetProperty(sb, tab + "\t", "string", "TypeDesc", "_typeDesc", typeDesc);
                AddGetProperty(sb, tab + "\t", "bool", "Attr", "_attr", hasAttr);
                AddGetProperty(sb, tab + "\t", "int", "Key", "_key", key);
                AddGetProperty(sb, tab + "\t", "int", "Group", "_group", group);

                sb.AppendLine();

                AddXmlHelp(sb, $"{tab}\t", typeDesc);
                sb.AppendLine($"{tab}\tpublic XR{typeName}() : base(\"{typeName}\") {{ }}");

            }

            return sb.ToString();
        }

        private static string ToQueryTypeName(string line, string tab, out string typeName, out string typeDesc)
        {
            string[] items = line.Trim(' ', ';').Split(',');

            typeDesc = items[1].Trim();
            typeName = items[2].Trim();
            bool hasAttr = false;
            bool hasBlock = false;
            bool hasEncrypt = false;
            bool hasSignature = false;
            string typeService = "";
            string headType = "";
            string creator = "";
            string credate = "";

            foreach (string item in items)
            {
                string[] keyValue = item.Split('=');
                switch (keyValue[0])
                {
                    case "attr":
                        hasAttr = true;
                        break;

                    case "block":
                        hasBlock = true;
                        break;

                    case "ENCRYPT":
                        hasEncrypt = true;
                        break;

                    case "SIGNATURE":
                        hasSignature = true;
                        break;

                    case "SERVICE":
                        typeService = keyValue[1].Trim();
                        break;

                    case "headtype":
                        headType = keyValue[1].Trim();
                        break;

                    case "CREATOR":
                        creator = keyValue[1].Trim();
                        break;

                    case "CREDATE":
                        credate = keyValue[1].Trim();
                        break;
                }
            }

            StringBuilder sb = new StringBuilder();

            {
                AddField(sb, tab + "\t", "string", "_typeName", typeName);
                AddField(sb, tab + "\t", "string", "_typeDesc", typeDesc);
                AddField(sb, tab + "\t", "string", "_service", typeService);
                AddField(sb, tab + "\t", "string", "_headType", headType);
                AddField(sb, tab + "\t", "string", "_creator", creator);
                AddField(sb, tab + "\t", "string", "_createdDate", credate);
                AddField(sb, tab + "\t", "bool", "_attr", hasAttr);
                AddField(sb, tab + "\t", "bool", "_block", hasBlock);
                AddField(sb, tab + "\t", "bool", "_encrypt", hasEncrypt);
                AddField(sb, tab + "\t", "bool", "_signature", hasSignature);

                sb.AppendLine();

                AddGetProperty(sb, tab + "\t", "string", "TypeName", "_typeName", typeName);
                AddGetProperty(sb, tab + "\t", "string", "TypeDesc", "_typeDesc", typeDesc);
                AddGetProperty(sb, tab + "\t", "string", "Service", "_service", typeService);
                AddGetProperty(sb, tab + "\t", "string", "HeadType", "_headType", headType);
                AddGetProperty(sb, tab + "\t", "string", "Creator", "_creator", creator);
                AddGetProperty(sb, tab + "\t", "string", "CreatedDate", "_createdDate", credate);

                AddGetProperty(sb, tab + "\t", "bool", "Attr", "_attr", hasAttr);
                AddGetProperty(sb, tab + "\t", "bool", "Block", "_block", hasBlock);
                AddGetProperty(sb, tab + "\t", "bool", "Encrypt", "_encrypt", hasEncrypt);
                AddGetProperty(sb, tab + "\t", "bool", "Signature", "_signature", hasSignature);

                sb.AppendLine();

                AddXmlHelp(sb, $"{tab}\t", typeDesc);
                sb.AppendLine($"{tab}\tpublic XQ{typeName}() : base(\"{typeName}\") {{ }}");
            }

            return sb.ToString();
        }

        private static void AddField(StringBuilder sb, string tab, string fieldType, string fieldName, int value)
        {
            AddField(sb, tab, fieldType, fieldName, value.ToString());
        }

        private static void AddField(StringBuilder sb, string tab, string fieldType, string fieldName, bool value)
        {
            AddField(sb, tab, fieldType, fieldName, value.ToString().ToLower());
        }

        private static void AddField(StringBuilder sb, string tab, string fieldType, string fieldName, string value)
        {
            AddXmlHelp(sb, tab, value);

            string valueText = value;
            switch (fieldType)
            {
                case "string":
                    valueText = $"\"{value}\"";
                    break;
            }

            sb.AppendLine($"{tab}public const {fieldType} {fieldName} = {valueText};");
        }

        private static void AddGetProperty(StringBuilder sb, string tab, string propType, string propName, string fieldName, int fieldValue)
        {
            AddGetProperty(sb, tab, propType, propName, fieldName, fieldValue.ToString());
        }

        private static void AddGetProperty(StringBuilder sb, string tab, string propType, string propName, string fieldName, bool fieldValue)
        {
            AddGetProperty(sb, tab, propType, propName, fieldName, fieldValue.ToString().ToLower());
        }

        private static void AddGetProperty(StringBuilder sb, string tab, string propType, string propName, string fieldName, string fieldValue)
        {
            AddXmlHelp(sb, tab, fieldValue);
            sb.AppendLine($"{tab}public {propType} {propName} => {fieldName};");
        }

        public static void AddXmlHelp(StringBuilder sb, string tab, bool value)
        {
            AddXmlHelp(sb, tab, value.ToString().ToLower());
        }

        public static void AddXmlHelp(StringBuilder sb, string tab, string value)
        {
            sb.AppendLine($"{tab}/// <summary>");
            sb.AppendLine($"{tab}/// {EncodeXml(value)}");
            sb.AppendLine($"{tab}/// </summary>");
        }
    }
}
