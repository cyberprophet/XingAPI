﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt9944InBlock : XingBlock
	{
		/// <summary>
		/// t9944InBlock
		/// </summary>
		public const string _blockName = "t9944InBlock";
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
		/// t9944InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t9944InBlock
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
		/// Dummy
		/// </summary>
		[XAQueryFieldAttribute("dummy", "Dummy", "char", "1")]
		public char dummy;

		public static class F
		{
			/// <summary>
			/// Dummy
			/// </summary>
			public const string dummy = "dummy";
		}

		public static string[] AllFields = new string[]
		{
			F.dummy,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dummy"] = new XAQueryFieldInfo("char", dummy, dummy.ToString(), "Dummy", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dummy":
					this.dummy = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// dummy char 1

			return true;
		}

		public void CopyTo(XQt9944InBlock block)
		{
			block.dummy = this.dummy;

		}
	}

	public partial class XQt9944OutBlock : XingBlock
	{
		/// <summary>
		/// t9944OutBlock
		/// </summary>
		public const string _blockName = "t9944OutBlock";
		/// <summary>
		/// 주식종목마스터
		/// </summary>
		public const string _blockDesc = "주식종목마스터";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t9944OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t9944OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 주식종목마스터
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
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
		public string hname;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "8")]
		public string shcode;
		/// <summary>
		/// 확장코드
		/// </summary>
		[XAQueryFieldAttribute("expcode", "확장코드", "char", "12")]
		public string expcode;

		public static class F
		{
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 확장코드
			/// </summary>
			public const string expcode = "expcode";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.shcode,
			F.expcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "확장코드", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt9944OutBlock[] ListFromQuery(XQt9944 query)
		{
			int count = query.GetBlockCount(XQt9944OutBlock.BlockName);
			List<XQt9944OutBlock> list = new List<XQt9944OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt9944OutBlock block = new XQt9944OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 8
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12

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
			if (hname?.Length > 20) return false; // char 20
			if (shcode?.Length > 8) return false; // char 8
			if (expcode?.Length > 12) return false; // char 12

			return true;
		}

		public void CopyTo(XQt9944OutBlock block)
		{
			block.hname = this.hname;
			block.shcode = this.shcode;
			block.expcode = this.expcode;

		}
	}

	/// <summary>
	/// 지수옵션마스터조회API용(t9944)
	/// </summary>
	public partial class XQt9944 : XingQuery
	{
		/// <summary>
		/// t9944
		/// </summary>
		public const string _typeName = "t9944";
		/// <summary>
		/// 지수옵션마스터조회API용(t9944)
		/// </summary>
		public const string _typeDesc = "지수옵션마스터조회API용(t9944)";
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
		/// false
		/// </summary>
		public const bool _attr = false;
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
		/// t9944
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 지수옵션마스터조회API용(t9944)
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
		/// false
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
		/// 지수옵션마스터조회API용(t9944)
		/// </summary>
		public XQt9944() : base("t9944") { }


		public static XQt9944OutBlock[] Get(char dummy = default)
		{
			using (XQt9944 instance = new XQt9944())
			{
				instance.SetFieldData(XQt9944InBlock.BlockName, XQt9944InBlock.F.dummy, 0, dummy.ToString()); // char 1

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlocks();
				return outBlock;
			}
		}

		public static XQt9944OutBlock[] ReadFromDB(string tableNamePostfix = null /*, char dummy = default */)
		{
			using (XQt9944 instance = new XQt9944())
			{

				string tableName = (tableNamePostfix == null) ? "XQt9944OutBlock" : $"XQt9944OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (dummy != default) qo.Add("dummy", dummy);


				var outBlock = instance.SelectMany<XQt9944OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt9944InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "dummy", 0, block.dummy.ToString()); // char 1

			return true;
		}

		public XQt9944OutBlock[] GetBlocks()
		{
			XQt9944OutBlock[] instance = XQt9944OutBlock.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt9944OutBlock),

		};

	}

}
