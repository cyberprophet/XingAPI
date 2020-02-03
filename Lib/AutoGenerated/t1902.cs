﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1902InBlock : XingBlock
	{
		/// <summary>
		/// t1902InBlock
		/// </summary>
		static readonly string _blockName = "t1902InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1902InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1902InBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode.Length > 6) return false; // char 6
			if (time.Length > 6) return false; // char 6

			return true;
		}
	}

	public partial class XQt1902OutBlock : XingBlock
	{
		/// <summary>
		/// t1902OutBlock
		/// </summary>
		static readonly string _blockName = "t1902OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1902OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1902OutBlock
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
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 업종지수명
		/// </summary>
		[XAQueryFieldAttribute("업종지수명")]
		public string upname;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 업종지수명
			/// </summary>
			public const string upname = "upname";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.hname,
			F.upname,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)6);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["upname"] = new XAQueryFieldInfo("char", upname, upname, "업종지수명", (decimal)20);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "upname":
					this.upname = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1902OutBlock FromQuery(XQt1902 query)
		{
			XQt1902OutBlock block = new XQt1902OutBlock();
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
				block.time = query.GetFieldData(block.GetBlockName(), "time", 0).TrimEnd('?'); // char 6
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 20
				block.upname = query.GetFieldData(block.GetBlockName(), "upname", 0).TrimEnd('?'); // char 20

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (time.Length > 6) return false; // char 6
			if (hname.Length > 20) return false; // char 20
			if (upname.Length > 20) return false; // char 20

			return true;
		}
	}

	public partial class XQt1902OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1902OutBlock1
		/// </summary>
		static readonly string _blockName = "t1902OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1902OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1902OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
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
		/// 시간
		/// </summary>
		[XAQueryFieldAttribute("시간")]
		public string time;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("전일대비구분")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public long change;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("누적거래량")]
		public float volume;
		/// <summary>
		/// NAV대비
		/// </summary>
		[XAQueryFieldAttribute("NAV대비")]
		public float navdiff;
		/// <summary>
		/// NAV
		/// </summary>
		[XAQueryFieldAttribute("NAV")]
		public float nav;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float navchange;
		/// <summary>
		/// 추적오차
		/// </summary>
		[XAQueryFieldAttribute("추적오차")]
		public float crate;
		/// <summary>
		/// 괴리
		/// </summary>
		[XAQueryFieldAttribute("괴리")]
		public float grate;
		/// <summary>
		/// 지수
		/// </summary>
		[XAQueryFieldAttribute("지수")]
		public float jisu;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("전일대비")]
		public float jichange;
		/// <summary>
		/// 전일대비율
		/// </summary>
		[XAQueryFieldAttribute("전일대비율")]
		public float jirate;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string time = "time";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 전일대비구분
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// NAV대비
			/// </summary>
			public const string navdiff = "navdiff";
			/// <summary>
			/// NAV
			/// </summary>
			public const string nav = "nav";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string navchange = "navchange";
			/// <summary>
			/// 추적오차
			/// </summary>
			public const string crate = "crate";
			/// <summary>
			/// 괴리
			/// </summary>
			public const string grate = "grate";
			/// <summary>
			/// 지수
			/// </summary>
			public const string jisu = "jisu";
			/// <summary>
			/// 전일대비
			/// </summary>
			public const string jichange = "jichange";
			/// <summary>
			/// 전일대비율
			/// </summary>
			public const string jirate = "jirate";
		}

		public static string[] AllFields = new string[]
		{
			F.time,
			F.price,
			F.sign,
			F.change,
			F.volume,
			F.navdiff,
			F.nav,
			F.navchange,
			F.crate,
			F.grate,
			F.jisu,
			F.jichange,
			F.jirate,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["time"] = new XAQueryFieldInfo("char", time, time, "시간", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "누적거래량", (decimal)12);
			dict["navdiff"] = new XAQueryFieldInfo("float", navdiff, navdiff.ToString("000000000.00"), "NAV대비", (decimal)9.2);
			dict["nav"] = new XAQueryFieldInfo("float", nav, nav.ToString("000000000.00"), "NAV", (decimal)9.2);
			dict["navchange"] = new XAQueryFieldInfo("float", navchange, navchange.ToString("000000000.00"), "전일대비", (decimal)9.2);
			dict["crate"] = new XAQueryFieldInfo("float", crate, crate.ToString("000000000.00"), "추적오차", (decimal)9.2);
			dict["grate"] = new XAQueryFieldInfo("float", grate, grate.ToString("000000000.00"), "괴리", (decimal)9.2);
			dict["jisu"] = new XAQueryFieldInfo("float", jisu, jisu.ToString("00000000.00"), "지수", (decimal)8.2);
			dict["jichange"] = new XAQueryFieldInfo("float", jichange, jichange.ToString("00000000.00"), "전일대비", (decimal)8.2);
			dict["jirate"] = new XAQueryFieldInfo("float", jirate, jirate.ToString("00000000.00"), "전일대비율", (decimal)8.2);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "time":
					this.time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseLong("price");
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.ParseLong("change");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "navdiff":
					this.navdiff = fieldInfo.FieldValue.ParseFloat("navdiff");
				break;

				case "nav":
					this.nav = fieldInfo.FieldValue.ParseFloat("nav");
				break;

				case "navchange":
					this.navchange = fieldInfo.FieldValue.ParseFloat("navchange");
				break;

				case "crate":
					this.crate = fieldInfo.FieldValue.ParseFloat("crate");
				break;

				case "grate":
					this.grate = fieldInfo.FieldValue.ParseFloat("grate");
				break;

				case "jisu":
					this.jisu = fieldInfo.FieldValue.ParseFloat("jisu");
				break;

				case "jichange":
					this.jichange = fieldInfo.FieldValue.ParseFloat("jichange");
				break;

				case "jirate":
					this.jirate = fieldInfo.FieldValue.ParseFloat("jirate");
				break;


			}
		}

		public static XQt1902OutBlock1[] ListFromQuery(XQt1902 query)
		{
			int count = query.GetBlockCount(XQt1902OutBlock1.BlockName);
			List<XQt1902OutBlock1> list = new List<XQt1902OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1902OutBlock1 block = new XQt1902OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.time = query.GetFieldData(block.GetBlockName(), "time", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseFloat("volume"); // float 12
					block.navdiff = query.GetFieldData(block.GetBlockName(), "navdiff", i).ParseFloat("navdiff"); // float 9.2
					block.nav = query.GetFieldData(block.GetBlockName(), "nav", i).ParseFloat("nav"); // float 9.2
					block.navchange = query.GetFieldData(block.GetBlockName(), "navchange", i).ParseFloat("navchange"); // float 9.2
					block.crate = query.GetFieldData(block.GetBlockName(), "crate", i).ParseFloat("crate"); // float 9.2
					block.grate = query.GetFieldData(block.GetBlockName(), "grate", i).ParseFloat("grate"); // float 9.2
					block.jisu = query.GetFieldData(block.GetBlockName(), "jisu", i).ParseFloat("jisu"); // float 8.2
					block.jichange = query.GetFieldData(block.GetBlockName(), "jichange", i).ParseFloat("jichange"); // float 8.2
					block.jirate = query.GetFieldData(block.GetBlockName(), "jirate", i).ParseFloat("jirate"); // float 8.2

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
			if (time.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// volume float 12
			// navdiff float 9.2
			// nav float 9.2
			// navchange float 9.2
			// crate float 9.2
			// grate float 9.2
			// jisu float 8.2
			// jichange float 8.2
			// jirate float 8.2

			return true;
		}
	}

	public partial class XQt1902 : XingQuery
	{
		/// <summary>
		/// t1902
		/// </summary>
		static readonly string _typeName = "t1902";
		/// <summary>
		/// ETF시간별추이(t1902)
		/// </summary>
		static readonly string _typeDesc = "ETF시간별추이(t1902)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t1902
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ETF시간별추이(t1902)
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

		public XQt1902() : base("t1902") { }


		public bool SetFields(XQt1902InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "time", 0, block.time); // char 6

			return true;
		}

		public XQt1902OutBlock GetBlock()
		{
			XQt1902OutBlock instance = XQt1902OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1902OutBlock1[] GetBlock1s()
		{
			XQt1902OutBlock1[] instance = XQt1902OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}