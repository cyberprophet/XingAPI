﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt3521InBlock : XingBlock
	{
		/// <summary>
		/// t3521InBlock
		/// </summary>
		public const string _blockName = "t3521InBlock";
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
		/// t3521InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3521InBlock
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
		/// 종목종류
		/// </summary>
		[XAQueryFieldAttribute("kind", "종목종류", "char", "1")]
		public char kind;
		/// <summary>
		/// SYMBOL
		/// </summary>
		[XAQueryFieldAttribute("symbol", "SYMBOL", "char", "16")]
		public string symbol;

		public static class F
		{
			/// <summary>
			/// 종목종류
			/// </summary>
			public const string kind = "kind";
			/// <summary>
			/// SYMBOL
			/// </summary>
			public const string symbol = "symbol";
		}

		public static string[] AllFields = new string[]
		{
			F.kind,
			F.symbol,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["kind"] = new XAQueryFieldInfo("char", kind, kind.ToString(), "종목종류", (decimal)1);
			dict["symbol"] = new XAQueryFieldInfo("char", symbol, symbol, "SYMBOL", (decimal)16);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "kind":
					this.kind = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "symbol":
					this.symbol = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// kind char 1
			if (symbol?.Length > 16) return false; // char 16

			return true;
		}

		public void CopyTo(XQt3521InBlock block)
		{
			block.kind = this.kind;
			block.symbol = this.symbol;

		}
	}

	public partial class XQt3521OutBlock : XingBlock
	{
		/// <summary>
		/// t3521OutBlock
		/// </summary>
		public const string _blockName = "t3521OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		public const string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// t3521OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t3521OutBlock
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
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 심벌
		/// </summary>
		[XAQueryFieldAttribute("symbol", "심벌", "char", "16")]
		public string symbol;
		/// <summary>
		/// 지수명
		/// </summary>
		[XAQueryFieldAttribute("hname", "지수명", "char", "20")]
		public string hname;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("close", "지수", "float", "12.2")]
		public float close;
		/// <summary>
		/// 대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("change", "대비", "float", "6.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 일자
		/// </summary>
		[XAQueryFieldAttribute("date", "일자", "char", "8")]
		public string date;

		public static class F
		{
			/// <summary>
			/// 심벌
			/// </summary>
			public const string symbol = "symbol";
			/// <summary>
			/// 지수명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 지수
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string diff = "diff";
			/// <summary>
			/// 일자
			/// </summary>
			public const string date = "date";
		}

		public static string[] AllFields = new string[]
		{
			F.symbol,
			F.hname,
			F.close,
			F.sign,
			F.change,
			F.diff,
			F.date,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["symbol"] = new XAQueryFieldInfo("char", symbol, symbol, "심벌", (decimal)16);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "지수명", (decimal)20);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("000000000000.00"), "지수", (decimal)12.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["date"] = new XAQueryFieldInfo("char", date, date, "일자", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "symbol":
					this.symbol = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseFloat("close");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseFloat("change");
				break;

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "date":
					this.date = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt3521OutBlock FromQuery(XQt3521 query)
		{
			XQt3521OutBlock block = new XQt3521OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.symbol = query.GetFieldData(block.GetBlockName(), "symbol", 0).TrimEnd('?'); // char 16
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 20
				block.close = query.GetFieldData(block.GetBlockName(), "close", 0).ParseFloat("close"); // float 12.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 6.2
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.date = query.GetFieldData(block.GetBlockName(), "date", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (symbol?.Length > 16) return false; // char 16
			if (hname?.Length > 20) return false; // char 20
			// close float 12.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (date?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XQt3521OutBlock block)
		{
			block.symbol = this.symbol;
			block.hname = this.hname;
			block.close = this.close;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.date = this.date;

		}
	}

	/// <summary>
	/// 해외지수조회(API용)(t3521)
	/// </summary>
	public partial class XQt3521 : XingQuery
	{
		/// <summary>
		/// t3521
		/// </summary>
		public const string _typeName = "t3521";
		/// <summary>
		/// 해외지수조회(API용)(t3521)
		/// </summary>
		public const string _typeDesc = "해외지수조회(API용)(t3521)";
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
		/// t3521
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 해외지수조회(API용)(t3521)
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
		/// 해외지수조회(API용)(t3521)
		/// </summary>
		public XQt3521() : base("t3521") { }


		public static XQt3521OutBlock Get(char kind = default,string symbol = default)
		{
			using (XQt3521 instance = new XQt3521())
			{
				instance.SetFieldData(XQt3521InBlock.BlockName, XQt3521InBlock.F.kind, 0, kind.ToString()); // char 1
				instance.SetFieldData(XQt3521InBlock.BlockName, XQt3521InBlock.F.symbol, 0, symbol); // char 16

				if (instance.Request() < 0)
				{
					return null;
				}

				var outBlock = instance.GetBlock();
				if (outBlock.IsValidData == false)
				{
					return null;
				}
				return outBlock;
			}
		}

		public static XQt3521OutBlock ReadFromDB(string tableNamePostfix = null /*, char kind = default,string symbol = default */)
		{
			using (XQt3521 instance = new XQt3521())
			{

				string tableName = (tableNamePostfix == null) ? "XQt3521OutBlock" : $"XQt3521OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				// if (kind != default) qo.Add("kind", kind);
				// if (symbol != default) qo.Add("symbol", symbol);


				var outBlock = instance.Select<XQt3521OutBlock>(qo);
				return outBlock;
			}
		}

		public bool SetBlock(XQt3521InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "kind", 0, block.kind.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "symbol", 0, block.symbol); // char 16

			return true;
		}

		public XQt3521OutBlock GetBlock()
		{
			XQt3521OutBlock instance = XQt3521OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt3521OutBlock),

		};

	}

}
