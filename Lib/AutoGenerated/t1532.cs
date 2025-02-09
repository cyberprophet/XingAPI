﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1532InBlock : XingBlock
	{
		/// <summary>
		/// t1532InBlock
		/// </summary>
		public const string _blockName = "t1532InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		public const string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t1532InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1532InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6

			return true;
		}

		public void CopyTo(XQt1532InBlock block)
		{
			block.shcode = this.shcode;

		}
	}

	public partial class XQt1532OutBlock : XingBlock
	{
		/// <summary>
		/// t1532OutBlock
		/// </summary>
		public const string _blockName = "t1532OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1532OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1532OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 테마명
		/// </summary>
		[XAQueryFieldAttribute("tmname", "테마명", "char", "36")]
		public string tmname;
		/// <summary>
		/// 평균등락율
		/// </summary>
		[XAQueryFieldAttribute("avgdiff", "평균등락율", "float", "6.2")]
		public float avgdiff;
		/// <summary>
		/// 테마코드
		/// </summary>
		[XAQueryFieldAttribute("tmcode", "테마코드", "char", "4")]
		public string tmcode;

		public static class F
		{
			/// <summary>
			/// 테마명
			/// </summary>
			public const string tmname = "tmname";
			/// <summary>
			/// 평균등락율
			/// </summary>
			public const string avgdiff = "avgdiff";
			/// <summary>
			/// 테마코드
			/// </summary>
			public const string tmcode = "tmcode";
		}

		public static string[] AllFields = new string[]
		{
			F.tmname,
			F.avgdiff,
			F.tmcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tmname"] = new XAQueryFieldInfo("char", tmname, tmname, "테마명", (decimal)36);
			dict["avgdiff"] = new XAQueryFieldInfo("float", avgdiff, avgdiff.ToString("000000.00"), "평균등락율", (decimal)6.2);
			dict["tmcode"] = new XAQueryFieldInfo("char", tmcode, tmcode, "테마코드", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tmname":
					this.tmname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "avgdiff":
					this.avgdiff = fieldInfo.FieldValue.ParseFloat("avgdiff");
				break;

				case "tmcode":
					this.tmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1532OutBlock[] ListFromQuery(XQt1532 query)
		{
			int count = query.GetBlockCount(XQt1532OutBlock.BlockName);
			List<XQt1532OutBlock> list = new List<XQt1532OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1532OutBlock block = new XQt1532OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.tmname = query.GetFieldData(block.GetBlockName(), "tmname", i).TrimEnd('?'); // char 36
					block.avgdiff = query.GetFieldData(block.GetBlockName(), "avgdiff", i).ParseFloat("avgdiff"); // float 6.2
					block.tmcode = query.GetFieldData(block.GetBlockName(), "tmcode", i).TrimEnd('?'); // char 4

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (tmname?.Length > 36) return false; // char 36
			// avgdiff float 6.2
			if (tmcode?.Length > 4) return false; // char 4

			return true;
		}

		public void CopyTo(XQt1532OutBlock block)
		{
			block.tmname = this.tmname;
			block.avgdiff = this.avgdiff;
			block.tmcode = this.tmcode;

		}
	}

	/// <summary>
	/// 종목별테마(t1532)
	/// </summary>
	public partial class XQt1532 : XingQuery
	{
		/// <summary>
		/// t1532
		/// </summary>
		public const string _typeName = "t1532";
		/// <summary>
		/// 종목별테마(t1532)
		/// </summary>
		public const string _typeDesc = "종목별테마(t1532)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// A
		/// </summary>
		public const string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		public const string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		public const string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		public const bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		public const bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// t1532
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 종목별테마(t1532)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// A
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// true
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// true
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// false
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		/// <summary>
		/// 종목별테마(t1532)
		/// </summary>
		public XQt1532() : base("t1532") { }


		public static XQt1532OutBlock[] Get(string shcode = default)
		{
			using (XQt1532 instance = new XQt1532())
			{
				instance.SetFieldData(XQt1532InBlock.BlockName, XQt1532InBlock.F.shcode, 0, shcode); // char 6

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public static XQt1532OutBlock[] ReadFromDB(string tableNamePostfix = null /*, string shcode = default */)
		{
			using (XQt1532 instance = new XQt1532())
			{

				string tableName = (tableNamePostfix == null) ? "XQt1532OutBlock" : $"XQt1532OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (shcode != default) qo.Add("shcode", shcode);


				var outBlock = instance.SelectMany<XQt1532OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt1532InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1532OutBlock[] GetBlocks()
		{
			XQt1532OutBlock[] instance = XQt1532OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1532OutBlock),

		};

	}

}
