﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt8409InBlock : XingBlock
	{
		/// <summary>
		/// t8409InBlock
		/// </summary>
		public const string _blockName = "t8409InBlock";
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
		/// t8409InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8409InBlock
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
		[XAQueryFieldAttribute("focode", "종목코드", "char", "8")]
		public string focode;
		/// <summary>
		/// 분일구분
		/// </summary>
		[XAQueryFieldAttribute("bdgubun", "분일구분", "char", "1")]
		public char bdgubun;
		/// <summary>
		/// N분
		/// </summary>
		[XAQueryFieldAttribute("nmin", "N분", "int", "3")]
		public int nmin;
		/// <summary>
		/// 당일연결구분
		/// </summary>
		[XAQueryFieldAttribute("tcgubun", "당일연결구분", "char", "1")]
		public char tcgubun;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회건수", "int", "4")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string focode = "focode";
			/// <summary>
			/// 분일구분
			/// </summary>
			public const string bdgubun = "bdgubun";
			/// <summary>
			/// N분
			/// </summary>
			public const string nmin = "nmin";
			/// <summary>
			/// 당일연결구분
			/// </summary>
			public const string tcgubun = "tcgubun";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.focode,
			F.bdgubun,
			F.nmin,
			F.tcgubun,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["focode"] = new XAQueryFieldInfo("char", focode, focode, "종목코드", (decimal)8);
			dict["bdgubun"] = new XAQueryFieldInfo("char", bdgubun, bdgubun.ToString(), "분일구분", (decimal)1);
			dict["nmin"] = new XAQueryFieldInfo("int", nmin, nmin.ToString("d3"), "N분", (decimal)3);
			dict["tcgubun"] = new XAQueryFieldInfo("char", tcgubun, tcgubun.ToString(), "당일연결구분", (decimal)1);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d4"), "조회건수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "focode":
					this.focode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bdgubun":
					this.bdgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "nmin":
					this.nmin = fieldInfo.FieldValue.ParseInt("nmin");
				break;

				case "tcgubun":
					this.tcgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (focode?.Length > 8) return false; // char 8
			// bdgubun char 1
			// nmin int 3
			// tcgubun char 1
			// cnt int 4

			return true;
		}

		public void CopyTo(XQt8409InBlock block)
		{
			block.focode = this.focode;
			block.bdgubun = this.bdgubun;
			block.nmin = this.nmin;
			block.tcgubun = this.tcgubun;
			block.cnt = this.cnt;

		}
	}

	public partial class XQt8409OutBlock : XingBlock
	{
		/// <summary>
		/// t8409OutBlock
		/// </summary>
		public const string _blockName = "t8409OutBlock";
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
		/// t8409OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8409OutBlock
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
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("price", "현재가", "float", "6.2")]
		public float price;
		/// <summary>
		/// 전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("sign", "전일대비구분", "char", "1")]
		public char sign;
		/// <summary>
		/// 전일대비
		/// </summary>
		[XAQueryFieldAttribute("change", "전일대비", "float", "6.2")]
		public float change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결수량", "long", "8")]
		public long cvolume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "double", "15.0")]
		public double volume;
		/// <summary>
		/// 미결제수량
		/// </summary>
		[XAQueryFieldAttribute("openyak", "미결제수량", "long", "8")]
		public long openyak;

		public static class F
		{
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
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 미결제수량
			/// </summary>
			public const string openyak = "openyak";
		}

		public static string[] AllFields = new string[]
		{
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.cvolume,
			F.volume,
			F.openyak,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d8"), "체결수량", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("double", volume, volume.ToString("000000000000000."), "누적거래량", (decimal)15.0);
			dict["openyak"] = new XAQueryFieldInfo("long", openyak, openyak.ToString("d8"), "미결제수량", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
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

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseDouble("volume");
				break;

				case "openyak":
					this.openyak = fieldInfo.FieldValue.ParseLong("openyak");
				break;


			}
		}

		public static XQt8409OutBlock FromQuery(XQt8409 query)
		{
			XQt8409OutBlock block = new XQt8409OutBlock();
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
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseFloat("price"); // float 6.2
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseFloat("change"); // float 6.2
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", 0).ParseLong("cvolume"); // long 8
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseDouble("volume"); // double 15.0
				block.openyak = query.GetFieldData(block.GetBlockName(), "openyak", 0).ParseLong("openyak"); // long 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// price float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (cvolume.ToString().Length > 8) return false; // long 8
			// volume double 15.0
			if (openyak.ToString().Length > 8) return false; // long 8

			return true;
		}

		public void CopyTo(XQt8409OutBlock block)
		{
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.cvolume = this.cvolume;
			block.volume = this.volume;
			block.openyak = this.openyak;

		}
	}

	public partial class XQt8409OutBlock1 : XingBlock
	{
		/// <summary>
		/// t8409OutBlock1
		/// </summary>
		public const string _blockName = "t8409OutBlock1";
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
		/// t8409OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t8409OutBlock1
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
		/// 일자시간
		/// </summary>
		[XAQueryFieldAttribute("dt", "일자시간", "char", "14")]
		public string dt;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "float", "6.2")]
		public float open;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "float", "6.2")]
		public float high;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "float", "6.2")]
		public float low;
		/// <summary>
		/// 종가
		/// </summary>
		[XAQueryFieldAttribute("close", "종가", "float", "6.2")]
		public float close;
		/// <summary>
		/// 미결제시량
		/// </summary>
		[XAQueryFieldAttribute("openopenyak", "미결제시량", "long", "8")]
		public long openopenyak;
		/// <summary>
		/// 미결제고량
		/// </summary>
		[XAQueryFieldAttribute("highopenyak", "미결제고량", "long", "8")]
		public long highopenyak;
		/// <summary>
		/// 미결제저량
		/// </summary>
		[XAQueryFieldAttribute("lowopenyak", "미결제저량", "long", "8")]
		public long lowopenyak;
		/// <summary>
		/// 미결제종량
		/// </summary>
		[XAQueryFieldAttribute("closeopenyak", "미결제종량", "long", "8")]
		public long closeopenyak;
		/// <summary>
		/// 미결증감
		/// </summary>
		[XAQueryFieldAttribute("openupdn", "미결증감", "long", "8")]
		public long openupdn;

		public static class F
		{
			/// <summary>
			/// 일자시간
			/// </summary>
			public const string dt = "dt";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 종가
			/// </summary>
			public const string close = "close";
			/// <summary>
			/// 미결제시량
			/// </summary>
			public const string openopenyak = "openopenyak";
			/// <summary>
			/// 미결제고량
			/// </summary>
			public const string highopenyak = "highopenyak";
			/// <summary>
			/// 미결제저량
			/// </summary>
			public const string lowopenyak = "lowopenyak";
			/// <summary>
			/// 미결제종량
			/// </summary>
			public const string closeopenyak = "closeopenyak";
			/// <summary>
			/// 미결증감
			/// </summary>
			public const string openupdn = "openupdn";
		}

		public static string[] AllFields = new string[]
		{
			F.dt,
			F.open,
			F.high,
			F.low,
			F.close,
			F.openopenyak,
			F.highopenyak,
			F.lowopenyak,
			F.closeopenyak,
			F.openupdn,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["dt"] = new XAQueryFieldInfo("char", dt, dt, "일자시간", (decimal)14);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["close"] = new XAQueryFieldInfo("float", close, close.ToString("000000.00"), "종가", (decimal)6.2);
			dict["openopenyak"] = new XAQueryFieldInfo("long", openopenyak, openopenyak.ToString("d8"), "미결제시량", (decimal)8);
			dict["highopenyak"] = new XAQueryFieldInfo("long", highopenyak, highopenyak.ToString("d8"), "미결제고량", (decimal)8);
			dict["lowopenyak"] = new XAQueryFieldInfo("long", lowopenyak, lowopenyak.ToString("d8"), "미결제저량", (decimal)8);
			dict["closeopenyak"] = new XAQueryFieldInfo("long", closeopenyak, closeopenyak.ToString("d8"), "미결제종량", (decimal)8);
			dict["openupdn"] = new XAQueryFieldInfo("long", openupdn, openupdn.ToString("d8"), "미결증감", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "dt":
					this.dt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseFloat("open");
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseFloat("high");
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseFloat("low");
				break;

				case "close":
					this.close = fieldInfo.FieldValue.ParseFloat("close");
				break;

				case "openopenyak":
					this.openopenyak = fieldInfo.FieldValue.ParseLong("openopenyak");
				break;

				case "highopenyak":
					this.highopenyak = fieldInfo.FieldValue.ParseLong("highopenyak");
				break;

				case "lowopenyak":
					this.lowopenyak = fieldInfo.FieldValue.ParseLong("lowopenyak");
				break;

				case "closeopenyak":
					this.closeopenyak = fieldInfo.FieldValue.ParseLong("closeopenyak");
				break;

				case "openupdn":
					this.openupdn = fieldInfo.FieldValue.ParseLong("openupdn");
				break;


			}
		}

		public static XQt8409OutBlock1[] ListFromQuery(XQt8409 query)
		{
			int count = query.GetBlockCount(XQt8409OutBlock1.BlockName);
			List<XQt8409OutBlock1> list = new List<XQt8409OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt8409OutBlock1 block = new XQt8409OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.dt = query.GetFieldData(block.GetBlockName(), "dt", i).TrimEnd('?'); // char 14
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.close = query.GetFieldData(block.GetBlockName(), "close", i).ParseFloat("close"); // float 6.2
					block.openopenyak = query.GetFieldData(block.GetBlockName(), "openopenyak", i).ParseLong("openopenyak"); // long 8
					block.highopenyak = query.GetFieldData(block.GetBlockName(), "highopenyak", i).ParseLong("highopenyak"); // long 8
					block.lowopenyak = query.GetFieldData(block.GetBlockName(), "lowopenyak", i).ParseLong("lowopenyak"); // long 8
					block.closeopenyak = query.GetFieldData(block.GetBlockName(), "closeopenyak", i).ParseLong("closeopenyak"); // long 8
					block.openupdn = query.GetFieldData(block.GetBlockName(), "openupdn", i).ParseLong("openupdn"); // long 8

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
			if (dt?.Length > 14) return false; // char 14
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// close float 6.2
			if (openopenyak.ToString().Length > 8) return false; // long 8
			if (highopenyak.ToString().Length > 8) return false; // long 8
			if (lowopenyak.ToString().Length > 8) return false; // long 8
			if (closeopenyak.ToString().Length > 8) return false; // long 8
			if (openupdn.ToString().Length > 8) return false; // long 8

			return true;
		}

		public void CopyTo(XQt8409OutBlock1 block)
		{
			block.dt = this.dt;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.close = this.close;
			block.openopenyak = this.openopenyak;
			block.highopenyak = this.highopenyak;
			block.lowopenyak = this.lowopenyak;
			block.closeopenyak = this.closeopenyak;
			block.openupdn = this.openupdn;

		}
	}

	/// <summary>
	/// CME야간선물미결제약정추이(API용)(t8409)
	/// </summary>
	public partial class XQt8409 : XingQuery
	{
		/// <summary>
		/// t8409
		/// </summary>
		public const string _typeName = "t8409";
		/// <summary>
		/// CME야간선물미결제약정추이(API용)(t8409)
		/// </summary>
		public const string _typeDesc = "CME야간선물미결제약정추이(API용)(t8409)";
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
		/// t8409
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// CME야간선물미결제약정추이(API용)(t8409)
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
		/// CME야간선물미결제약정추이(API용)(t8409)
		/// </summary>
		public XQt8409() : base("t8409") { }


		public class XQAllOutBlocks
		{
			public XQt8409OutBlock OutBlock { get; internal set; }
			public XQt8409OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string focode = default,char bdgubun = default,int nmin = default,char tcgubun = default,int cnt = default)
		{
			using (XQt8409 instance = new XQt8409())
			{
				instance.SetFieldData(XQt8409InBlock.BlockName, XQt8409InBlock.F.focode, 0, focode); // char 8
				instance.SetFieldData(XQt8409InBlock.BlockName, XQt8409InBlock.F.bdgubun, 0, bdgubun.ToString()); // char 1
				instance.SetFieldData(XQt8409InBlock.BlockName, XQt8409InBlock.F.nmin, 0, nmin.ToString("d3")); // int 3
				instance.SetFieldData(XQt8409InBlock.BlockName, XQt8409InBlock.F.tcgubun, 0, tcgubun.ToString()); // char 1
				instance.SetFieldData(XQt8409InBlock.BlockName, XQt8409InBlock.F.cnt, 0, cnt.ToString("d4")); // int 4

				if (instance.Request() < 0)
				{
					return null;
				}

				XQAllOutBlocks results = new XQAllOutBlocks();
				results.OutBlock = instance.GetBlock();
				if (results.OutBlock.IsValidData == false)
				{
					return null;
				}

				results.OutBlock1 = instance.GetBlock1s();
				return results;
			}
		}

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string focode = default,char bdgubun = default,int nmin = default,char tcgubun = default,int cnt = default */)
		{
			using (XQt8409 instance = new XQt8409())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt8409OutBlock" : $"XQt8409OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt8409OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt8409OutBlock1" : $"XQt8409OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt8409OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt8409InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "focode", 0, block.focode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "bdgubun", 0, block.bdgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "nmin", 0, block.nmin.ToString("d3")); // int 3
			_xaQuery.SetFieldData(block.GetBlockName(), "tcgubun", 0, block.tcgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d4")); // int 4

			return true;
		}

		public XQt8409OutBlock GetBlock()
		{
			XQt8409OutBlock instance = XQt8409OutBlock.FromQuery(this);
			return instance;

		}

		public XQt8409OutBlock1[] GetBlock1s()
		{
			XQt8409OutBlock1[] instance = XQt8409OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt8409OutBlock),
			typeof(XQt8409OutBlock1),

		};

	}

}
