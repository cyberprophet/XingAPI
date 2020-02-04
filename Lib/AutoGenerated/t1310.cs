﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1310InBlock : XingBlock
	{
		/// <summary>
		/// t1310InBlock
		/// </summary>
		public const string _blockName = "t1310InBlock";
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
		/// t1310InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1310InBlock
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
		/// 당일전일구분
		/// </summary>
		[XAQueryFieldAttribute("당일전일구분")]
		public char daygb;
		/// <summary>
		/// 분틱구분
		/// </summary>
		[XAQueryFieldAttribute("분틱구분")]
		public char timegb;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 종료시간
		/// </summary>
		[XAQueryFieldAttribute("종료시간")]
		public string endtime;
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("시간CTS")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 당일전일구분
			/// </summary>
			public const string daygb = "daygb";
			/// <summary>
			/// 분틱구분
			/// </summary>
			public const string timegb = "timegb";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 종료시간
			/// </summary>
			public const string endtime = "endtime";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.daygb,
			F.timegb,
			F.shcode,
			F.endtime,
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["daygb"] = new XAQueryFieldInfo("char", daygb, daygb.ToString(), "당일전일구분", (decimal)1);
			dict["timegb"] = new XAQueryFieldInfo("char", timegb, timegb.ToString(), "분틱구분", (decimal)1);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["endtime"] = new XAQueryFieldInfo("char", endtime, endtime, "종료시간", (decimal)4);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "daygb":
					this.daygb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "timegb":
					this.timegb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "endtime":
					this.endtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			// daygb char 1
			// timegb char 1
			if (shcode?.Length > 6) return false; // char 6
			if (endtime?.Length > 4) return false; // char 4
			if (cts_time?.Length > 10) return false; // char 10

			return true;
		}
	}

	public partial class XQt1310OutBlock : XingBlock
	{
		/// <summary>
		/// t1310OutBlock
		/// </summary>
		public const string _blockName = "t1310OutBlock";
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
		/// t1310OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1310OutBlock
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
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("시간CTS")]
		public string cts_time;

		public static class F
		{
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_time,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)10);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1310OutBlock FromQuery(XQt1310 query)
		{
			XQt1310OutBlock block = new XQt1310OutBlock();
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
				block.cts_time = query.GetFieldData(block.GetBlockName(), "cts_time", 0).TrimEnd('?'); // char 10

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_time?.Length > 10) return false; // char 10

			return true;
		}
	}

	public partial class XQt1310OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1310OutBlock1
		/// </summary>
		public const string _blockName = "t1310OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		public const string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t1310OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1310OutBlock1
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
		public string chetime;
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
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float diff;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("체결수량")]
		public long cvolume;
		/// <summary>
		/// 체결강도
		/// </summary>
		[XAQueryFieldAttribute("체결강도")]
		public float chdegree;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("거래량")]
		public long volume;
		/// <summary>
		/// 매도체결수량
		/// </summary>
		[XAQueryFieldAttribute("매도체결수량")]
		public long mdvolume;
		/// <summary>
		/// 매도체결건수
		/// </summary>
		[XAQueryFieldAttribute("매도체결건수")]
		public long mdchecnt;
		/// <summary>
		/// 매수체결수량
		/// </summary>
		[XAQueryFieldAttribute("매수체결수량")]
		public long msvolume;
		/// <summary>
		/// 매수체결건수
		/// </summary>
		[XAQueryFieldAttribute("매수체결건수")]
		public long mschecnt;
		/// <summary>
		/// 순체결량
		/// </summary>
		[XAQueryFieldAttribute("순체결량")]
		public long revolume;
		/// <summary>
		/// 순체결건수
		/// </summary>
		[XAQueryFieldAttribute("순체결건수")]
		public long rechecnt;

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
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
			public const string diff = "diff";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 체결강도
			/// </summary>
			public const string chdegree = "chdegree";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 매도체결수량
			/// </summary>
			public const string mdvolume = "mdvolume";
			/// <summary>
			/// 매도체결건수
			/// </summary>
			public const string mdchecnt = "mdchecnt";
			/// <summary>
			/// 매수체결수량
			/// </summary>
			public const string msvolume = "msvolume";
			/// <summary>
			/// 매수체결건수
			/// </summary>
			public const string mschecnt = "mschecnt";
			/// <summary>
			/// 순체결량
			/// </summary>
			public const string revolume = "revolume";
			/// <summary>
			/// 순체결건수
			/// </summary>
			public const string rechecnt = "rechecnt";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.cvolume,
			F.chdegree,
			F.volume,
			F.mdvolume,
			F.mdchecnt,
			F.msvolume,
			F.mschecnt,
			F.revolume,
			F.rechecnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결수량", (decimal)12);
			dict["chdegree"] = new XAQueryFieldInfo("float", chdegree, chdegree.ToString("00000000.00"), "체결강도", (decimal)8.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["mdvolume"] = new XAQueryFieldInfo("long", mdvolume, mdvolume.ToString("d12"), "매도체결수량", (decimal)12);
			dict["mdchecnt"] = new XAQueryFieldInfo("long", mdchecnt, mdchecnt.ToString("d8"), "매도체결건수", (decimal)8);
			dict["msvolume"] = new XAQueryFieldInfo("long", msvolume, msvolume.ToString("d12"), "매수체결수량", (decimal)12);
			dict["mschecnt"] = new XAQueryFieldInfo("long", mschecnt, mschecnt.ToString("d8"), "매수체결건수", (decimal)8);
			dict["revolume"] = new XAQueryFieldInfo("long", revolume, revolume.ToString("d12"), "순체결량", (decimal)12);
			dict["rechecnt"] = new XAQueryFieldInfo("long", rechecnt, rechecnt.ToString("d8"), "순체결건수", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "chetime":
					this.chetime = fieldInfo.FieldValue.TrimEnd('?');
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

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "chdegree":
					this.chdegree = fieldInfo.FieldValue.ParseFloat("chdegree");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "mdvolume":
					this.mdvolume = fieldInfo.FieldValue.ParseLong("mdvolume");
				break;

				case "mdchecnt":
					this.mdchecnt = fieldInfo.FieldValue.ParseLong("mdchecnt");
				break;

				case "msvolume":
					this.msvolume = fieldInfo.FieldValue.ParseLong("msvolume");
				break;

				case "mschecnt":
					this.mschecnt = fieldInfo.FieldValue.ParseLong("mschecnt");
				break;

				case "revolume":
					this.revolume = fieldInfo.FieldValue.ParseLong("revolume");
				break;

				case "rechecnt":
					this.rechecnt = fieldInfo.FieldValue.ParseLong("rechecnt");
				break;


			}
		}

		public static XQt1310OutBlock1[] ListFromQuery(XQt1310 query)
		{
			int count = query.GetBlockCount(XQt1310OutBlock1.BlockName);
			List<XQt1310OutBlock1> list = new List<XQt1310OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1310OutBlock1 block = new XQt1310OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 10
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.chdegree = query.GetFieldData(block.GetBlockName(), "chdegree", i).ParseFloat("chdegree"); // float 8.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.mdvolume = query.GetFieldData(block.GetBlockName(), "mdvolume", i).ParseLong("mdvolume"); // long 12
					block.mdchecnt = query.GetFieldData(block.GetBlockName(), "mdchecnt", i).ParseLong("mdchecnt"); // long 8
					block.msvolume = query.GetFieldData(block.GetBlockName(), "msvolume", i).ParseLong("msvolume"); // long 12
					block.mschecnt = query.GetFieldData(block.GetBlockName(), "mschecnt", i).ParseLong("mschecnt"); // long 8
					block.revolume = query.GetFieldData(block.GetBlockName(), "revolume", i).ParseLong("revolume"); // long 12
					block.rechecnt = query.GetFieldData(block.GetBlockName(), "rechecnt", i).ParseLong("rechecnt"); // long 8

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
			if (chetime?.Length > 10) return false; // char 10
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			// chdegree float 8.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (mdvolume.ToString().Length > 12) return false; // long 12
			if (mdchecnt.ToString().Length > 8) return false; // long 8
			if (msvolume.ToString().Length > 12) return false; // long 12
			if (mschecnt.ToString().Length > 8) return false; // long 8
			if (revolume.ToString().Length > 12) return false; // long 12
			if (rechecnt.ToString().Length > 8) return false; // long 8

			return true;
		}
	}

	public partial class XQt1310 : XingQuery
	{
		/// <summary>
		/// t1310
		/// </summary>
		public const string _typeName = "t1310";
		/// <summary>
		/// 주식당일전일분틱조회(t1310)
		/// </summary>
		public const string _typeDesc = "주식당일전일분틱조회(t1310)";
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
		/// t1310
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 주식당일전일분틱조회(t1310)
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

		public XQt1310() : base("t1310") { }


		public bool SetFields(XQt1310InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "daygb", 0, block.daygb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "timegb", 0, block.timegb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "endtime", 0, block.endtime); // char 4
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 10

			return true;
		}

		public XQt1310OutBlock GetBlock()
		{
			XQt1310OutBlock instance = XQt1310OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1310OutBlock1[] GetBlock1s()
		{
			XQt1310OutBlock1[] instance = XQt1310OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
