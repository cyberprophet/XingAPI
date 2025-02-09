﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRSHCInBlock : XingBlock
	{
		/// <summary>
		/// InBlock
		/// </summary>
		public const string _blockName = "InBlock";
		/// <summary>
		/// 입력
		/// </summary>
		public const string _blockDesc = "입력";
		/// <summary>
		/// input
		/// </summary>
		public const string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		public const bool _hasOccurs = false;
		/// <summary>
		/// InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 입력
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
		/// 상/하한구분
		/// </summary>
		[XAQueryFieldAttribute("updnlmtgubun", "상/하한구분", "char", "1")]
		public char updnlmtgubun;

		public static class F
		{
			/// <summary>
			/// 상/하한구분
			/// </summary>
			public const string updnlmtgubun = "updnlmtgubun";
		}

		public static string[] AllFields = new string[]
		{
			F.updnlmtgubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["updnlmtgubun"] = new XAQueryFieldInfo("char", updnlmtgubun, updnlmtgubun.ToString(), "상/하한구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "updnlmtgubun":
					this.updnlmtgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// updnlmtgubun char 1

			return true;
		}

		public void CopyTo(XRSHCInBlock block)
		{
			block.updnlmtgubun = this.updnlmtgubun;

		}
	}

	public partial class XRSHCOutBlock : XingBlock
	{
		/// <summary>
		/// OutBlock
		/// </summary>
		public const string _blockName = "OutBlock";
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
		/// OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// OutBlock
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
		/// 거래소/코스닥구분
		/// </summary>
		[XAQueryFieldAttribute("sijanggubun", "거래소/코스닥구분", "char", "1")]
		public char sijanggubun;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("hname", "종목명", "char", "20")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "long", "8")]
		public long price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "long", "8")]
		public long change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("drate", "등락율", "float", "6.2")]
		public float drate;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 거래증가율
		/// </summary>
		[XAQueryFieldAttribute("volincrate", "거래증가율", "float", "12.2")]
		public float volincrate;
		/// <summary>
		/// 상/하한가
		/// </summary>
		[XAQueryFieldAttribute("updnlmtprice", "상/하한가", "long", "8")]
		public long updnlmtprice;
		/// <summary>
		/// 상/하한가대비율
		/// </summary>
		[XAQueryFieldAttribute("updnlmtdrate", "상/하한가대비율", "float", "6.2")]
		public float updnlmtdrate;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "long", "12")]
		public long jnilvolume;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// 관리구분
		/// </summary>
		[XAQueryFieldAttribute("gwangubun", "관리구분", "char", "1")]
		public char gwangubun;
		/// <summary>
		/// 이상급등구분
		/// </summary>
		[XAQueryFieldAttribute("undergubun", "이상급등구분", "char", "1")]
		public char undergubun;
		/// <summary>
		/// 투자유의구분
		/// </summary>
		[XAQueryFieldAttribute("tgubun", "투자유의구분", "char", "1")]
		public char tgubun;
		/// <summary>
		/// 우선주구분
		/// </summary>
		[XAQueryFieldAttribute("wgubun", "우선주구분", "char", "1")]
		public char wgubun;
		/// <summary>
		/// 불성실구분
		/// </summary>
		[XAQueryFieldAttribute("dishonest", "불성실구분", "char", "1")]
		public char dishonest;
		/// <summary>
		/// 증거금률
		/// </summary>
		[XAQueryFieldAttribute("jkrate", "증거금률", "char", "1")]
		public char jkrate;
		/// <summary>
		/// 상한가/하한가연속일수
		/// </summary>
		[XAQueryFieldAttribute("updnlmtdaycnt", "상한가/하한가연속일수", "long", "3")]
		public long updnlmtdaycnt;

		public static class F
		{
			/// <summary>
			/// 거래소/코스닥구분
			/// </summary>
			public const string sijanggubun = "sijanggubun";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
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
			/// 등락율
			/// </summary>
			public const string drate = "drate";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래증가율
			/// </summary>
			public const string volincrate = "volincrate";
			/// <summary>
			/// 상/하한가
			/// </summary>
			public const string updnlmtprice = "updnlmtprice";
			/// <summary>
			/// 상/하한가대비율
			/// </summary>
			public const string updnlmtdrate = "updnlmtdrate";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 관리구분
			/// </summary>
			public const string gwangubun = "gwangubun";
			/// <summary>
			/// 이상급등구분
			/// </summary>
			public const string undergubun = "undergubun";
			/// <summary>
			/// 투자유의구분
			/// </summary>
			public const string tgubun = "tgubun";
			/// <summary>
			/// 우선주구분
			/// </summary>
			public const string wgubun = "wgubun";
			/// <summary>
			/// 불성실구분
			/// </summary>
			public const string dishonest = "dishonest";
			/// <summary>
			/// 증거금률
			/// </summary>
			public const string jkrate = "jkrate";
			/// <summary>
			/// 상한가/하한가연속일수
			/// </summary>
			public const string updnlmtdaycnt = "updnlmtdaycnt";
		}

		public static string[] AllFields = new string[]
		{
			F.sijanggubun,
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.drate,
			F.volume,
			F.volincrate,
			F.updnlmtprice,
			F.updnlmtdrate,
			F.jnilvolume,
			F.shcode,
			F.gwangubun,
			F.undergubun,
			F.tgubun,
			F.wgubun,
			F.dishonest,
			F.jkrate,
			F.updnlmtdaycnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["sijanggubun"] = new XAQueryFieldInfo("char", sijanggubun, sijanggubun.ToString(), "거래소/코스닥구분", (decimal)1);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["drate"] = new XAQueryFieldInfo("float", drate, drate.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["volincrate"] = new XAQueryFieldInfo("float", volincrate, volincrate.ToString("000000000000.00"), "거래증가율", (decimal)12.2);
			dict["updnlmtprice"] = new XAQueryFieldInfo("long", updnlmtprice, updnlmtprice.ToString("d8"), "상/하한가", (decimal)8);
			dict["updnlmtdrate"] = new XAQueryFieldInfo("float", updnlmtdrate, updnlmtdrate.ToString("000000.00"), "상/하한가대비율", (decimal)6.2);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["gwangubun"] = new XAQueryFieldInfo("char", gwangubun, gwangubun.ToString(), "관리구분", (decimal)1);
			dict["undergubun"] = new XAQueryFieldInfo("char", undergubun, undergubun.ToString(), "이상급등구분", (decimal)1);
			dict["tgubun"] = new XAQueryFieldInfo("char", tgubun, tgubun.ToString(), "투자유의구분", (decimal)1);
			dict["wgubun"] = new XAQueryFieldInfo("char", wgubun, wgubun.ToString(), "우선주구분", (decimal)1);
			dict["dishonest"] = new XAQueryFieldInfo("char", dishonest, dishonest.ToString(), "불성실구분", (decimal)1);
			dict["jkrate"] = new XAQueryFieldInfo("char", jkrate, jkrate.ToString(), "증거금률", (decimal)1);
			dict["updnlmtdaycnt"] = new XAQueryFieldInfo("long", updnlmtdaycnt, updnlmtdaycnt.ToString("d3"), "상한가/하한가연속일수", (decimal)3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "sijanggubun":
					this.sijanggubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
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

				case "drate":
					this.drate = fieldInfo.FieldValue.ParseFloat("drate");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "volincrate":
					this.volincrate = fieldInfo.FieldValue.ParseFloat("volincrate");
				break;

				case "updnlmtprice":
					this.updnlmtprice = fieldInfo.FieldValue.ParseLong("updnlmtprice");
				break;

				case "updnlmtdrate":
					this.updnlmtdrate = fieldInfo.FieldValue.ParseFloat("updnlmtdrate");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gwangubun":
					this.gwangubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "undergubun":
					this.undergubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "tgubun":
					this.tgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "wgubun":
					this.wgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dishonest":
					this.dishonest = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jkrate":
					this.jkrate = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "updnlmtdaycnt":
					this.updnlmtdaycnt = fieldInfo.FieldValue.ParseLong("updnlmtdaycnt");
				break;


			}
		}

		public static XRSHCOutBlock FromQuery(XRSHC query)
		{
			XRSHCOutBlock block = new XRSHCOutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.sijanggubun = query.GetFieldData(block.GetBlockName(), "sijanggubun").FirstOrDefault(); // char 1
				block.hname = query.GetFieldData(block.GetBlockName(), "hname").TrimEnd('?'); // char 20
				block.price = query.GetFieldData(block.GetBlockName(), "price").ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign").FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change").ParseLong("change"); // long 8
				block.drate = query.GetFieldData(block.GetBlockName(), "drate").ParseFloat("drate"); // float 6.2
				block.volume = query.GetFieldData(block.GetBlockName(), "volume").ParseLong("volume"); // long 12
				block.volincrate = query.GetFieldData(block.GetBlockName(), "volincrate").ParseFloat("volincrate"); // float 12.2
				block.updnlmtprice = query.GetFieldData(block.GetBlockName(), "updnlmtprice").ParseLong("updnlmtprice"); // long 8
				block.updnlmtdrate = query.GetFieldData(block.GetBlockName(), "updnlmtdrate").ParseFloat("updnlmtdrate"); // float 6.2
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume").ParseLong("jnilvolume"); // long 12
				block.shcode = query.GetFieldData(block.GetBlockName(), "shcode").TrimEnd('?'); // char 6
				block.gwangubun = query.GetFieldData(block.GetBlockName(), "gwangubun").FirstOrDefault(); // char 1
				block.undergubun = query.GetFieldData(block.GetBlockName(), "undergubun").FirstOrDefault(); // char 1
				block.tgubun = query.GetFieldData(block.GetBlockName(), "tgubun").FirstOrDefault(); // char 1
				block.wgubun = query.GetFieldData(block.GetBlockName(), "wgubun").FirstOrDefault(); // char 1
				block.dishonest = query.GetFieldData(block.GetBlockName(), "dishonest").FirstOrDefault(); // char 1
				block.jkrate = query.GetFieldData(block.GetBlockName(), "jkrate").FirstOrDefault(); // char 1
				block.updnlmtdaycnt = query.GetFieldData(block.GetBlockName(), "updnlmtdaycnt").ParseLong("updnlmtdaycnt"); // long 3

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// sijanggubun char 1
			if (hname?.Length > 20) return false; // char 20
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// drate float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// volincrate float 12.2
			if (updnlmtprice.ToString().Length > 8) return false; // long 8
			// updnlmtdrate float 6.2
			if (jnilvolume.ToString().Length > 12) return false; // long 12
			if (shcode?.Length > 6) return false; // char 6
			// gwangubun char 1
			// undergubun char 1
			// tgubun char 1
			// wgubun char 1
			// dishonest char 1
			// jkrate char 1
			if (updnlmtdaycnt.ToString().Length > 3) return false; // long 3

			return true;
		}

		public void CopyTo(XRSHCOutBlock block)
		{
			block.sijanggubun = this.sijanggubun;
			block.hname = this.hname;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.drate = this.drate;
			block.volume = this.volume;
			block.volincrate = this.volincrate;
			block.updnlmtprice = this.updnlmtprice;
			block.updnlmtdrate = this.updnlmtdrate;
			block.jnilvolume = this.jnilvolume;
			block.shcode = this.shcode;
			block.gwangubun = this.gwangubun;
			block.undergubun = this.undergubun;
			block.tgubun = this.tgubun;
			block.wgubun = this.wgubun;
			block.dishonest = this.dishonest;
			block.jkrate = this.jkrate;
			block.updnlmtdaycnt = this.updnlmtdaycnt;

		}
	}

	/// <summary>
	/// 상/하한가근접진입(SHC)
	/// </summary>
	public partial class XRSHC : XingReal
	{
		/// <summary>
		/// SHC
		/// </summary>
		public const string _typeName = "SHC";
		/// <summary>
		/// 상/하한가근접진입(SHC)
		/// </summary>
		public const string _typeDesc = "상/하한가근접진입(SHC)";
		/// <summary>
		/// false
		/// </summary>
		public const bool _attr = false;
		/// <summary>
		/// 0
		/// </summary>
		public const int _key = 0;
		/// <summary>
		/// 0
		/// </summary>
		public const int _group = 0;

		/// <summary>
		/// SHC
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 상/하한가근접진입(SHC)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// 0
		/// </summary>
		public int Key => _key;
		/// <summary>
		/// 0
		/// </summary>
		public int Group => _group;

		/// <summary>
		/// 상/하한가근접진입(SHC)
		/// </summary>
		public XRSHC() : base("SHC") { }


		public bool SetBlock(XRSHCInBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "updnlmtgubun", block.updnlmtgubun.ToString()); // char 1

			return true;
		}

		public XRSHCOutBlock GetBlock()
		{
			XRSHCOutBlock instance = XRSHCOutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRSHCOutBlock),

		};

	}

}
