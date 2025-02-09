﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt2301InBlock : XingBlock
	{
		/// <summary>
		/// t2301InBlock
		/// </summary>
		public const string _blockName = "t2301InBlock";
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
		/// t2301InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2301InBlock
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
		/// 월물
		/// </summary>
		[XAQueryFieldAttribute("yyyymm", "월물", "char", "6")]
		public string yyyymm;
		/// <summary>
		/// 미니구분(M:미니G:정규)
		/// </summary>
		[XAQueryFieldAttribute("gubun", "미니구분(M:미니G:정규)", "char", "1")]
		public char gubun;

		public static class F
		{
			/// <summary>
			/// 월물
			/// </summary>
			public const string yyyymm = "yyyymm";
			/// <summary>
			/// 미니구분(M:미니G:정규)
			/// </summary>
			public const string gubun = "gubun";
		}

		public static string[] AllFields = new string[]
		{
			F.yyyymm,
			F.gubun,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["yyyymm"] = new XAQueryFieldInfo("char", yyyymm, yyyymm, "월물", (decimal)6);
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "미니구분(M:미니G:정규)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "yyyymm":
					this.yyyymm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (yyyymm?.Length > 6) return false; // char 6
			// gubun char 1

			return true;
		}

		public void CopyTo(XQt2301InBlock block)
		{
			block.yyyymm = this.yyyymm;
			block.gubun = this.gubun;

		}
	}

	public partial class XQt2301OutBlock : XingBlock
	{
		/// <summary>
		/// t2301OutBlock
		/// </summary>
		public const string _blockName = "t2301OutBlock";
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
		/// t2301OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2301OutBlock
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
		/// 역사적변동성
		/// </summary>
		[XAQueryFieldAttribute("histimpv", "역사적변동성", "long", "4")]
		public long histimpv;
		/// <summary>
		/// 옵션잔존일
		/// </summary>
		[XAQueryFieldAttribute("jandatecnt", "옵션잔존일", "long", "4")]
		public long jandatecnt;
		/// <summary>
		/// 콜옵션대표IV
		/// </summary>
		[XAQueryFieldAttribute("cimpv", "콜옵션대표IV", "float", "6.3")]
		public float cimpv;
		/// <summary>
		/// 풋옵션대표IV
		/// </summary>
		[XAQueryFieldAttribute("pimpv", "풋옵션대표IV", "float", "6.3")]
		public float pimpv;
		/// <summary>
		/// 근월물현재가
		/// </summary>
		[XAQueryFieldAttribute("gmprice", "근월물현재가", "float", "6.2")]
		public float gmprice;
		/// <summary>
		/// 근월물전일대비구분
		/// </summary>
		[XAQueryFieldAttribute("gmsign", "근월물전일대비구분", "char", "1")]
		public char gmsign;
		/// <summary>
		/// 근월물전일대비
		/// </summary>
		[XAQueryFieldAttribute("gmchange", "근월물전일대비", "float", "6.2")]
		public float gmchange;
		/// <summary>
		/// 근월물등락율
		/// </summary>
		[XAQueryFieldAttribute("gmdiff", "근월물등락율", "float", "6.2")]
		public float gmdiff;
		/// <summary>
		/// 근월물거래량
		/// </summary>
		[XAQueryFieldAttribute("gmvolume", "근월물거래량", "long", "12")]
		public long gmvolume;
		/// <summary>
		/// 근월물선물코드
		/// </summary>
		[XAQueryFieldAttribute("gmshcode", "근월물선물코드", "char", "8")]
		public string gmshcode;

		public static class F
		{
			/// <summary>
			/// 역사적변동성
			/// </summary>
			public const string histimpv = "histimpv";
			/// <summary>
			/// 옵션잔존일
			/// </summary>
			public const string jandatecnt = "jandatecnt";
			/// <summary>
			/// 콜옵션대표IV
			/// </summary>
			public const string cimpv = "cimpv";
			/// <summary>
			/// 풋옵션대표IV
			/// </summary>
			public const string pimpv = "pimpv";
			/// <summary>
			/// 근월물현재가
			/// </summary>
			public const string gmprice = "gmprice";
			/// <summary>
			/// 근월물전일대비구분
			/// </summary>
			public const string gmsign = "gmsign";
			/// <summary>
			/// 근월물전일대비
			/// </summary>
			public const string gmchange = "gmchange";
			/// <summary>
			/// 근월물등락율
			/// </summary>
			public const string gmdiff = "gmdiff";
			/// <summary>
			/// 근월물거래량
			/// </summary>
			public const string gmvolume = "gmvolume";
			/// <summary>
			/// 근월물선물코드
			/// </summary>
			public const string gmshcode = "gmshcode";
		}

		public static string[] AllFields = new string[]
		{
			F.histimpv,
			F.jandatecnt,
			F.cimpv,
			F.pimpv,
			F.gmprice,
			F.gmsign,
			F.gmchange,
			F.gmdiff,
			F.gmvolume,
			F.gmshcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["histimpv"] = new XAQueryFieldInfo("long", histimpv, histimpv.ToString("d4"), "역사적변동성", (decimal)4);
			dict["jandatecnt"] = new XAQueryFieldInfo("long", jandatecnt, jandatecnt.ToString("d4"), "옵션잔존일", (decimal)4);
			dict["cimpv"] = new XAQueryFieldInfo("float", cimpv, cimpv.ToString("000000.000"), "콜옵션대표IV", (decimal)6.3);
			dict["pimpv"] = new XAQueryFieldInfo("float", pimpv, pimpv.ToString("000000.000"), "풋옵션대표IV", (decimal)6.3);
			dict["gmprice"] = new XAQueryFieldInfo("float", gmprice, gmprice.ToString("000000.00"), "근월물현재가", (decimal)6.2);
			dict["gmsign"] = new XAQueryFieldInfo("char", gmsign, gmsign.ToString(), "근월물전일대비구분", (decimal)1);
			dict["gmchange"] = new XAQueryFieldInfo("float", gmchange, gmchange.ToString("000000.00"), "근월물전일대비", (decimal)6.2);
			dict["gmdiff"] = new XAQueryFieldInfo("float", gmdiff, gmdiff.ToString("000000.00"), "근월물등락율", (decimal)6.2);
			dict["gmvolume"] = new XAQueryFieldInfo("long", gmvolume, gmvolume.ToString("d12"), "근월물거래량", (decimal)12);
			dict["gmshcode"] = new XAQueryFieldInfo("char", gmshcode, gmshcode, "근월물선물코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "histimpv":
					this.histimpv = fieldInfo.FieldValue.ParseLong("histimpv");
				break;

				case "jandatecnt":
					this.jandatecnt = fieldInfo.FieldValue.ParseLong("jandatecnt");
				break;

				case "cimpv":
					this.cimpv = fieldInfo.FieldValue.ParseFloat("cimpv");
				break;

				case "pimpv":
					this.pimpv = fieldInfo.FieldValue.ParseFloat("pimpv");
				break;

				case "gmprice":
					this.gmprice = fieldInfo.FieldValue.ParseFloat("gmprice");
				break;

				case "gmsign":
					this.gmsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "gmchange":
					this.gmchange = fieldInfo.FieldValue.ParseFloat("gmchange");
				break;

				case "gmdiff":
					this.gmdiff = fieldInfo.FieldValue.ParseFloat("gmdiff");
				break;

				case "gmvolume":
					this.gmvolume = fieldInfo.FieldValue.ParseLong("gmvolume");
				break;

				case "gmshcode":
					this.gmshcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt2301OutBlock FromQuery(XQt2301 query)
		{
			XQt2301OutBlock block = new XQt2301OutBlock();
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
				block.histimpv = query.GetFieldData(block.GetBlockName(), "histimpv", 0).ParseLong("histimpv"); // long 4
				block.jandatecnt = query.GetFieldData(block.GetBlockName(), "jandatecnt", 0).ParseLong("jandatecnt"); // long 4
				block.cimpv = query.GetFieldData(block.GetBlockName(), "cimpv", 0).ParseFloat("cimpv"); // float 6.3
				block.pimpv = query.GetFieldData(block.GetBlockName(), "pimpv", 0).ParseFloat("pimpv"); // float 6.3
				block.gmprice = query.GetFieldData(block.GetBlockName(), "gmprice", 0).ParseFloat("gmprice"); // float 6.2
				block.gmsign = query.GetFieldData(block.GetBlockName(), "gmsign", 0).FirstOrDefault(); // char 1
				block.gmchange = query.GetFieldData(block.GetBlockName(), "gmchange", 0).ParseFloat("gmchange"); // float 6.2
				block.gmdiff = query.GetFieldData(block.GetBlockName(), "gmdiff", 0).ParseFloat("gmdiff"); // float 6.2
				block.gmvolume = query.GetFieldData(block.GetBlockName(), "gmvolume", 0).ParseLong("gmvolume"); // long 12
				block.gmshcode = query.GetFieldData(block.GetBlockName(), "gmshcode", 0).TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (histimpv.ToString().Length > 4) return false; // long 4
			if (jandatecnt.ToString().Length > 4) return false; // long 4
			// cimpv float 6.3
			// pimpv float 6.3
			// gmprice float 6.2
			// gmsign char 1
			// gmchange float 6.2
			// gmdiff float 6.2
			if (gmvolume.ToString().Length > 12) return false; // long 12
			if (gmshcode?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XQt2301OutBlock block)
		{
			block.histimpv = this.histimpv;
			block.jandatecnt = this.jandatecnt;
			block.cimpv = this.cimpv;
			block.pimpv = this.pimpv;
			block.gmprice = this.gmprice;
			block.gmsign = this.gmsign;
			block.gmchange = this.gmchange;
			block.gmdiff = this.gmdiff;
			block.gmvolume = this.gmvolume;
			block.gmshcode = this.gmshcode;

		}
	}

	public partial class XQt2301OutBlock1 : XingBlock
	{
		/// <summary>
		/// t2301OutBlock1
		/// </summary>
		public const string _blockName = "t2301OutBlock1";
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
		/// t2301OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2301OutBlock1
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
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("actprice", "행사가", "float", "6.2")]
		public float actprice;
		/// <summary>
		/// 콜옵션코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "콜옵션코드", "char", "8")]
		public string optcode;
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// IV
		/// </summary>
		[XAQueryFieldAttribute("iv", "IV", "float", "6.2")]
		public float iv;
		/// <summary>
		/// 미결제약정
		/// </summary>
		[XAQueryFieldAttribute("mgjv", "미결제약정", "long", "12")]
		public long mgjv;
		/// <summary>
		/// 미결제약정증감
		/// </summary>
		[XAQueryFieldAttribute("mgjvupdn", "미결제약정증감", "long", "12")]
		public long mgjvupdn;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가", "float", "6.2")]
		public float offerho1;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가", "float", "6.2")]
		public float bidho1;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "12")]
		public long cvolume;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("delt", "델타", "float", "6.4")]
		public float delt;
		/// <summary>
		/// 감마
		/// </summary>
		[XAQueryFieldAttribute("gama", "감마", "float", "6.4")]
		public float gama;
		/// <summary>
		/// 베가
		/// </summary>
		[XAQueryFieldAttribute("vega", "베가", "float", "6.4")]
		public float vega;
		/// <summary>
		/// 쎄타
		/// </summary>
		[XAQueryFieldAttribute("ceta", "쎄타", "float", "6.4")]
		public float ceta;
		/// <summary>
		/// 로우
		/// </summary>
		[XAQueryFieldAttribute("rhox", "로우", "float", "6.4")]
		public float rhox;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("theoryprice", "이론가", "float", "6.2")]
		public float theoryprice;
		/// <summary>
		/// 내재가치
		/// </summary>
		[XAQueryFieldAttribute("impv", "내재가치", "float", "6.2")]
		public float impv;
		/// <summary>
		/// 시간가치
		/// </summary>
		[XAQueryFieldAttribute("timevl", "시간가치", "float", "6.2")]
		public float timevl;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("jvolume", "잔고수량", "long", "12")]
		public long jvolume;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("parpl", "평가손익", "long", "12")]
		public long parpl;
		/// <summary>
		/// 청산가능수량
		/// </summary>
		[XAQueryFieldAttribute("jngo", "청산가능수량", "long", "6")]
		public long jngo;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도잔량", "long", "12")]
		public long offerrem1;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수잔량", "long", "12")]
		public long bidrem1;
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
		/// ATM구분
		/// </summary>
		[XAQueryFieldAttribute("atmgubun", "ATM구분", "char", "1")]
		public char atmgubun;
		/// <summary>
		/// 지수환산
		/// </summary>
		[XAQueryFieldAttribute("jisuconv", "지수환산", "float", "6.2")]
		public float jisuconv;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "float", "12")]
		public float value;

		public static class F
		{
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 콜옵션코드
			/// </summary>
			public const string optcode = "optcode";
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
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// IV
			/// </summary>
			public const string iv = "iv";
			/// <summary>
			/// 미결제약정
			/// </summary>
			public const string mgjv = "mgjv";
			/// <summary>
			/// 미결제약정증감
			/// </summary>
			public const string mgjvupdn = "mgjvupdn";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 델타
			/// </summary>
			public const string delt = "delt";
			/// <summary>
			/// 감마
			/// </summary>
			public const string gama = "gama";
			/// <summary>
			/// 베가
			/// </summary>
			public const string vega = "vega";
			/// <summary>
			/// 쎄타
			/// </summary>
			public const string ceta = "ceta";
			/// <summary>
			/// 로우
			/// </summary>
			public const string rhox = "rhox";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 내재가치
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 시간가치
			/// </summary>
			public const string timevl = "timevl";
			/// <summary>
			/// 잔고수량
			/// </summary>
			public const string jvolume = "jvolume";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string parpl = "parpl";
			/// <summary>
			/// 청산가능수량
			/// </summary>
			public const string jngo = "jngo";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
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
			/// ATM구분
			/// </summary>
			public const string atmgubun = "atmgubun";
			/// <summary>
			/// 지수환산
			/// </summary>
			public const string jisuconv = "jisuconv";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
		}

		public static string[] AllFields = new string[]
		{
			F.actprice,
			F.optcode,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.iv,
			F.mgjv,
			F.mgjvupdn,
			F.offerho1,
			F.bidho1,
			F.cvolume,
			F.delt,
			F.gama,
			F.vega,
			F.ceta,
			F.rhox,
			F.theoryprice,
			F.impv,
			F.timevl,
			F.jvolume,
			F.parpl,
			F.jngo,
			F.offerrem1,
			F.bidrem1,
			F.open,
			F.high,
			F.low,
			F.atmgubun,
			F.jisuconv,
			F.value,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "콜옵션코드", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["iv"] = new XAQueryFieldInfo("float", iv, iv.ToString("000000.00"), "IV", (decimal)6.2);
			dict["mgjv"] = new XAQueryFieldInfo("long", mgjv, mgjv.ToString("d12"), "미결제약정", (decimal)12);
			dict["mgjvupdn"] = new XAQueryFieldInfo("long", mgjvupdn, mgjvupdn.ToString("d12"), "미결제약정증감", (decimal)12);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도호가", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수호가", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결량", (decimal)12);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("000000.0000"), "델타", (decimal)6.4);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("000000.0000"), "감마", (decimal)6.4);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("000000.0000"), "베가", (decimal)6.4);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("000000.0000"), "쎄타", (decimal)6.4);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("000000.0000"), "로우", (decimal)6.4);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재가치", (decimal)6.2);
			dict["timevl"] = new XAQueryFieldInfo("float", timevl, timevl.ToString("000000.00"), "시간가치", (decimal)6.2);
			dict["jvolume"] = new XAQueryFieldInfo("long", jvolume, jvolume.ToString("d12"), "잔고수량", (decimal)12);
			dict["parpl"] = new XAQueryFieldInfo("long", parpl, parpl.ToString("d12"), "평가손익", (decimal)12);
			dict["jngo"] = new XAQueryFieldInfo("long", jngo, jngo.ToString("d6"), "청산가능수량", (decimal)6);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도잔량", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수잔량", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["atmgubun"] = new XAQueryFieldInfo("char", atmgubun, atmgubun.ToString(), "ATM구분", (decimal)1);
			dict["jisuconv"] = new XAQueryFieldInfo("float", jisuconv, jisuconv.ToString("000000.00"), "지수환산", (decimal)6.2);
			dict["value"] = new XAQueryFieldInfo("float", value, value.ToString("000000000000"), "거래대금", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

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

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "iv":
					this.iv = fieldInfo.FieldValue.ParseFloat("iv");
				break;

				case "mgjv":
					this.mgjv = fieldInfo.FieldValue.ParseLong("mgjv");
				break;

				case "mgjvupdn":
					this.mgjvupdn = fieldInfo.FieldValue.ParseLong("mgjvupdn");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "delt":
					this.delt = fieldInfo.FieldValue.ParseFloat("delt");
				break;

				case "gama":
					this.gama = fieldInfo.FieldValue.ParseFloat("gama");
				break;

				case "vega":
					this.vega = fieldInfo.FieldValue.ParseFloat("vega");
				break;

				case "ceta":
					this.ceta = fieldInfo.FieldValue.ParseFloat("ceta");
				break;

				case "rhox":
					this.rhox = fieldInfo.FieldValue.ParseFloat("rhox");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "timevl":
					this.timevl = fieldInfo.FieldValue.ParseFloat("timevl");
				break;

				case "jvolume":
					this.jvolume = fieldInfo.FieldValue.ParseLong("jvolume");
				break;

				case "parpl":
					this.parpl = fieldInfo.FieldValue.ParseLong("parpl");
				break;

				case "jngo":
					this.jngo = fieldInfo.FieldValue.ParseLong("jngo");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
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

				case "atmgubun":
					this.atmgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jisuconv":
					this.jisuconv = fieldInfo.FieldValue.ParseFloat("jisuconv");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseFloat("value");
				break;


			}
		}

		public static XQt2301OutBlock1[] ListFromQuery(XQt2301 query)
		{
			int count = query.GetBlockCount(XQt2301OutBlock1.BlockName);
			List<XQt2301OutBlock1> list = new List<XQt2301OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2301OutBlock1 block = new XQt2301OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", i).ParseFloat("actprice"); // float 6.2
					block.optcode = query.GetFieldData(block.GetBlockName(), "optcode", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.iv = query.GetFieldData(block.GetBlockName(), "iv", i).ParseFloat("iv"); // float 6.2
					block.mgjv = query.GetFieldData(block.GetBlockName(), "mgjv", i).ParseLong("mgjv"); // long 12
					block.mgjvupdn = query.GetFieldData(block.GetBlockName(), "mgjvupdn", i).ParseLong("mgjvupdn"); // long 12
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseFloat("offerho1"); // float 6.2
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseFloat("bidho1"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.delt = query.GetFieldData(block.GetBlockName(), "delt", i).ParseFloat("delt"); // float 6.4
					block.gama = query.GetFieldData(block.GetBlockName(), "gama", i).ParseFloat("gama"); // float 6.4
					block.vega = query.GetFieldData(block.GetBlockName(), "vega", i).ParseFloat("vega"); // float 6.4
					block.ceta = query.GetFieldData(block.GetBlockName(), "ceta", i).ParseFloat("ceta"); // float 6.4
					block.rhox = query.GetFieldData(block.GetBlockName(), "rhox", i).ParseFloat("rhox"); // float 6.4
					block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", i).ParseFloat("theoryprice"); // float 6.2
					block.impv = query.GetFieldData(block.GetBlockName(), "impv", i).ParseFloat("impv"); // float 6.2
					block.timevl = query.GetFieldData(block.GetBlockName(), "timevl", i).ParseFloat("timevl"); // float 6.2
					block.jvolume = query.GetFieldData(block.GetBlockName(), "jvolume", i).ParseLong("jvolume"); // long 12
					block.parpl = query.GetFieldData(block.GetBlockName(), "parpl", i).ParseLong("parpl"); // long 12
					block.jngo = query.GetFieldData(block.GetBlockName(), "jngo", i).ParseLong("jngo"); // long 6
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.atmgubun = query.GetFieldData(block.GetBlockName(), "atmgubun", i).FirstOrDefault(); // char 1
					block.jisuconv = query.GetFieldData(block.GetBlockName(), "jisuconv", i).ParseFloat("jisuconv"); // float 6.2
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseFloat("value"); // float 12

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
			// actprice float 6.2
			if (optcode?.Length > 8) return false; // char 8
			// price float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// iv float 6.2
			if (mgjv.ToString().Length > 12) return false; // long 12
			if (mgjvupdn.ToString().Length > 12) return false; // long 12
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			// delt float 6.4
			// gama float 6.4
			// vega float 6.4
			// ceta float 6.4
			// rhox float 6.4
			// theoryprice float 6.2
			// impv float 6.2
			// timevl float 6.2
			if (jvolume.ToString().Length > 12) return false; // long 12
			if (parpl.ToString().Length > 12) return false; // long 12
			if (jngo.ToString().Length > 6) return false; // long 6
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// atmgubun char 1
			// jisuconv float 6.2
			// value float 12

			return true;
		}

		public void CopyTo(XQt2301OutBlock1 block)
		{
			block.actprice = this.actprice;
			block.optcode = this.optcode;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.volume = this.volume;
			block.iv = this.iv;
			block.mgjv = this.mgjv;
			block.mgjvupdn = this.mgjvupdn;
			block.offerho1 = this.offerho1;
			block.bidho1 = this.bidho1;
			block.cvolume = this.cvolume;
			block.delt = this.delt;
			block.gama = this.gama;
			block.vega = this.vega;
			block.ceta = this.ceta;
			block.rhox = this.rhox;
			block.theoryprice = this.theoryprice;
			block.impv = this.impv;
			block.timevl = this.timevl;
			block.jvolume = this.jvolume;
			block.parpl = this.parpl;
			block.jngo = this.jngo;
			block.offerrem1 = this.offerrem1;
			block.bidrem1 = this.bidrem1;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.atmgubun = this.atmgubun;
			block.jisuconv = this.jisuconv;
			block.value = this.value;

		}
	}

	public partial class XQt2301OutBlock2 : XingBlock
	{
		/// <summary>
		/// t2301OutBlock2
		/// </summary>
		public const string _blockName = "t2301OutBlock2";
		/// <summary>
		/// 출력2
		/// </summary>
		public const string _blockDesc = "출력2";
		/// <summary>
		/// output
		/// </summary>
		public const string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		public const bool _hasOccurs = true;
		/// <summary>
		/// t2301OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t2301OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력2
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
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("actprice", "행사가", "float", "6.2")]
		public float actprice;
		/// <summary>
		/// 풋옵션코드
		/// </summary>
		[XAQueryFieldAttribute("optcode", "풋옵션코드", "char", "8")]
		public string optcode;
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
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// IV
		/// </summary>
		[XAQueryFieldAttribute("iv", "IV", "float", "6.2")]
		public float iv;
		/// <summary>
		/// 미결제약정
		/// </summary>
		[XAQueryFieldAttribute("mgjv", "미결제약정", "long", "12")]
		public long mgjv;
		/// <summary>
		/// 미결제약정증감
		/// </summary>
		[XAQueryFieldAttribute("mgjvupdn", "미결제약정증감", "long", "12")]
		public long mgjvupdn;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가", "float", "6.2")]
		public float offerho1;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가", "float", "6.2")]
		public float bidho1;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "12")]
		public long cvolume;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("delt", "델타", "float", "6.4")]
		public float delt;
		/// <summary>
		/// 감마
		/// </summary>
		[XAQueryFieldAttribute("gama", "감마", "float", "6.4")]
		public float gama;
		/// <summary>
		/// 베가
		/// </summary>
		[XAQueryFieldAttribute("vega", "베가", "float", "6.4")]
		public float vega;
		/// <summary>
		/// 쎄타
		/// </summary>
		[XAQueryFieldAttribute("ceta", "쎄타", "float", "6.4")]
		public float ceta;
		/// <summary>
		/// 로우
		/// </summary>
		[XAQueryFieldAttribute("rhox", "로우", "float", "6.4")]
		public float rhox;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("theoryprice", "이론가", "float", "6.2")]
		public float theoryprice;
		/// <summary>
		/// 내재가치
		/// </summary>
		[XAQueryFieldAttribute("impv", "내재가치", "float", "6.2")]
		public float impv;
		/// <summary>
		/// 시간가치
		/// </summary>
		[XAQueryFieldAttribute("timevl", "시간가치", "float", "6.2")]
		public float timevl;
		/// <summary>
		/// 잔고수량
		/// </summary>
		[XAQueryFieldAttribute("jvolume", "잔고수량", "long", "12")]
		public long jvolume;
		/// <summary>
		/// 평가손익
		/// </summary>
		[XAQueryFieldAttribute("parpl", "평가손익", "long", "12")]
		public long parpl;
		/// <summary>
		/// 청산가능수량
		/// </summary>
		[XAQueryFieldAttribute("jngo", "청산가능수량", "long", "6")]
		public long jngo;
		/// <summary>
		/// 매도잔량
		/// </summary>
		[XAQueryFieldAttribute("offerrem1", "매도잔량", "long", "12")]
		public long offerrem1;
		/// <summary>
		/// 매수잔량
		/// </summary>
		[XAQueryFieldAttribute("bidrem1", "매수잔량", "long", "12")]
		public long bidrem1;
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
		/// ATM구분
		/// </summary>
		[XAQueryFieldAttribute("atmgubun", "ATM구분", "char", "1")]
		public char atmgubun;
		/// <summary>
		/// 지수환산
		/// </summary>
		[XAQueryFieldAttribute("jisuconv", "지수환산", "float", "6.2")]
		public float jisuconv;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "float", "12")]
		public float value;

		public static class F
		{
			/// <summary>
			/// 행사가
			/// </summary>
			public const string actprice = "actprice";
			/// <summary>
			/// 풋옵션코드
			/// </summary>
			public const string optcode = "optcode";
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
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// IV
			/// </summary>
			public const string iv = "iv";
			/// <summary>
			/// 미결제약정
			/// </summary>
			public const string mgjv = "mgjv";
			/// <summary>
			/// 미결제약정증감
			/// </summary>
			public const string mgjvupdn = "mgjvupdn";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 델타
			/// </summary>
			public const string delt = "delt";
			/// <summary>
			/// 감마
			/// </summary>
			public const string gama = "gama";
			/// <summary>
			/// 베가
			/// </summary>
			public const string vega = "vega";
			/// <summary>
			/// 쎄타
			/// </summary>
			public const string ceta = "ceta";
			/// <summary>
			/// 로우
			/// </summary>
			public const string rhox = "rhox";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 내재가치
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 시간가치
			/// </summary>
			public const string timevl = "timevl";
			/// <summary>
			/// 잔고수량
			/// </summary>
			public const string jvolume = "jvolume";
			/// <summary>
			/// 평가손익
			/// </summary>
			public const string parpl = "parpl";
			/// <summary>
			/// 청산가능수량
			/// </summary>
			public const string jngo = "jngo";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
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
			/// ATM구분
			/// </summary>
			public const string atmgubun = "atmgubun";
			/// <summary>
			/// 지수환산
			/// </summary>
			public const string jisuconv = "jisuconv";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
		}

		public static string[] AllFields = new string[]
		{
			F.actprice,
			F.optcode,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.iv,
			F.mgjv,
			F.mgjvupdn,
			F.offerho1,
			F.bidho1,
			F.cvolume,
			F.delt,
			F.gama,
			F.vega,
			F.ceta,
			F.rhox,
			F.theoryprice,
			F.impv,
			F.timevl,
			F.jvolume,
			F.parpl,
			F.jngo,
			F.offerrem1,
			F.bidrem1,
			F.open,
			F.high,
			F.low,
			F.atmgubun,
			F.jisuconv,
			F.value,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["actprice"] = new XAQueryFieldInfo("float", actprice, actprice.ToString("000000.00"), "행사가", (decimal)6.2);
			dict["optcode"] = new XAQueryFieldInfo("char", optcode, optcode, "풋옵션코드", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000.00"), "현재가", (decimal)6.2);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("float", change, change.ToString("000000.00"), "전일대비", (decimal)6.2);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["iv"] = new XAQueryFieldInfo("float", iv, iv.ToString("000000.00"), "IV", (decimal)6.2);
			dict["mgjv"] = new XAQueryFieldInfo("long", mgjv, mgjv.ToString("d12"), "미결제약정", (decimal)12);
			dict["mgjvupdn"] = new XAQueryFieldInfo("long", mgjvupdn, mgjvupdn.ToString("d12"), "미결제약정증감", (decimal)12);
			dict["offerho1"] = new XAQueryFieldInfo("float", offerho1, offerho1.ToString("000000.00"), "매도호가", (decimal)6.2);
			dict["bidho1"] = new XAQueryFieldInfo("float", bidho1, bidho1.ToString("000000.00"), "매수호가", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "체결량", (decimal)12);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("000000.0000"), "델타", (decimal)6.4);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("000000.0000"), "감마", (decimal)6.4);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("000000.0000"), "베가", (decimal)6.4);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("000000.0000"), "쎄타", (decimal)6.4);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("000000.0000"), "로우", (decimal)6.4);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("000000.00"), "이론가", (decimal)6.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재가치", (decimal)6.2);
			dict["timevl"] = new XAQueryFieldInfo("float", timevl, timevl.ToString("000000.00"), "시간가치", (decimal)6.2);
			dict["jvolume"] = new XAQueryFieldInfo("long", jvolume, jvolume.ToString("d12"), "잔고수량", (decimal)12);
			dict["parpl"] = new XAQueryFieldInfo("long", parpl, parpl.ToString("d12"), "평가손익", (decimal)12);
			dict["jngo"] = new XAQueryFieldInfo("long", jngo, jngo.ToString("d6"), "청산가능수량", (decimal)6);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도잔량", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수잔량", (decimal)12);
			dict["open"] = new XAQueryFieldInfo("float", open, open.ToString("000000.00"), "시가", (decimal)6.2);
			dict["high"] = new XAQueryFieldInfo("float", high, high.ToString("000000.00"), "고가", (decimal)6.2);
			dict["low"] = new XAQueryFieldInfo("float", low, low.ToString("000000.00"), "저가", (decimal)6.2);
			dict["atmgubun"] = new XAQueryFieldInfo("char", atmgubun, atmgubun.ToString(), "ATM구분", (decimal)1);
			dict["jisuconv"] = new XAQueryFieldInfo("float", jisuconv, jisuconv.ToString("000000.00"), "지수환산", (decimal)6.2);
			dict["value"] = new XAQueryFieldInfo("float", value, value.ToString("000000000000"), "거래대금", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "actprice":
					this.actprice = fieldInfo.FieldValue.ParseFloat("actprice");
				break;

				case "optcode":
					this.optcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

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

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "iv":
					this.iv = fieldInfo.FieldValue.ParseFloat("iv");
				break;

				case "mgjv":
					this.mgjv = fieldInfo.FieldValue.ParseLong("mgjv");
				break;

				case "mgjvupdn":
					this.mgjvupdn = fieldInfo.FieldValue.ParseLong("mgjvupdn");
				break;

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseFloat("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseFloat("bidho1");
				break;

				case "cvolume":
					this.cvolume = fieldInfo.FieldValue.ParseLong("cvolume");
				break;

				case "delt":
					this.delt = fieldInfo.FieldValue.ParseFloat("delt");
				break;

				case "gama":
					this.gama = fieldInfo.FieldValue.ParseFloat("gama");
				break;

				case "vega":
					this.vega = fieldInfo.FieldValue.ParseFloat("vega");
				break;

				case "ceta":
					this.ceta = fieldInfo.FieldValue.ParseFloat("ceta");
				break;

				case "rhox":
					this.rhox = fieldInfo.FieldValue.ParseFloat("rhox");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "timevl":
					this.timevl = fieldInfo.FieldValue.ParseFloat("timevl");
				break;

				case "jvolume":
					this.jvolume = fieldInfo.FieldValue.ParseLong("jvolume");
				break;

				case "parpl":
					this.parpl = fieldInfo.FieldValue.ParseLong("parpl");
				break;

				case "jngo":
					this.jngo = fieldInfo.FieldValue.ParseLong("jngo");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
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

				case "atmgubun":
					this.atmgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jisuconv":
					this.jisuconv = fieldInfo.FieldValue.ParseFloat("jisuconv");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseFloat("value");
				break;


			}
		}

		public static XQt2301OutBlock2[] ListFromQuery(XQt2301 query)
		{
			int count = query.GetBlockCount(XQt2301OutBlock2.BlockName);
			List<XQt2301OutBlock2> list = new List<XQt2301OutBlock2>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt2301OutBlock2 block = new XQt2301OutBlock2();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.actprice = query.GetFieldData(block.GetBlockName(), "actprice", i).ParseFloat("actprice"); // float 6.2
					block.optcode = query.GetFieldData(block.GetBlockName(), "optcode", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 6.2
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseFloat("change"); // float 6.2
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.iv = query.GetFieldData(block.GetBlockName(), "iv", i).ParseFloat("iv"); // float 6.2
					block.mgjv = query.GetFieldData(block.GetBlockName(), "mgjv", i).ParseLong("mgjv"); // long 12
					block.mgjvupdn = query.GetFieldData(block.GetBlockName(), "mgjvupdn", i).ParseLong("mgjvupdn"); // long 12
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseFloat("offerho1"); // float 6.2
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseFloat("bidho1"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.delt = query.GetFieldData(block.GetBlockName(), "delt", i).ParseFloat("delt"); // float 6.4
					block.gama = query.GetFieldData(block.GetBlockName(), "gama", i).ParseFloat("gama"); // float 6.4
					block.vega = query.GetFieldData(block.GetBlockName(), "vega", i).ParseFloat("vega"); // float 6.4
					block.ceta = query.GetFieldData(block.GetBlockName(), "ceta", i).ParseFloat("ceta"); // float 6.4
					block.rhox = query.GetFieldData(block.GetBlockName(), "rhox", i).ParseFloat("rhox"); // float 6.4
					block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", i).ParseFloat("theoryprice"); // float 6.2
					block.impv = query.GetFieldData(block.GetBlockName(), "impv", i).ParseFloat("impv"); // float 6.2
					block.timevl = query.GetFieldData(block.GetBlockName(), "timevl", i).ParseFloat("timevl"); // float 6.2
					block.jvolume = query.GetFieldData(block.GetBlockName(), "jvolume", i).ParseLong("jvolume"); // long 12
					block.parpl = query.GetFieldData(block.GetBlockName(), "parpl", i).ParseLong("parpl"); // long 12
					block.jngo = query.GetFieldData(block.GetBlockName(), "jngo", i).ParseLong("jngo"); // long 6
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12
					block.open = query.GetFieldData(block.GetBlockName(), "open", i).ParseFloat("open"); // float 6.2
					block.high = query.GetFieldData(block.GetBlockName(), "high", i).ParseFloat("high"); // float 6.2
					block.low = query.GetFieldData(block.GetBlockName(), "low", i).ParseFloat("low"); // float 6.2
					block.atmgubun = query.GetFieldData(block.GetBlockName(), "atmgubun", i).FirstOrDefault(); // char 1
					block.jisuconv = query.GetFieldData(block.GetBlockName(), "jisuconv", i).ParseFloat("jisuconv"); // float 6.2
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseFloat("value"); // float 12

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
			// actprice float 6.2
			if (optcode?.Length > 8) return false; // char 8
			// price float 6.2
			// sign char 1
			// change float 6.2
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			// iv float 6.2
			if (mgjv.ToString().Length > 12) return false; // long 12
			if (mgjvupdn.ToString().Length > 12) return false; // long 12
			// offerho1 float 6.2
			// bidho1 float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			// delt float 6.4
			// gama float 6.4
			// vega float 6.4
			// ceta float 6.4
			// rhox float 6.4
			// theoryprice float 6.2
			// impv float 6.2
			// timevl float 6.2
			if (jvolume.ToString().Length > 12) return false; // long 12
			if (parpl.ToString().Length > 12) return false; // long 12
			if (jngo.ToString().Length > 6) return false; // long 6
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12
			// open float 6.2
			// high float 6.2
			// low float 6.2
			// atmgubun char 1
			// jisuconv float 6.2
			// value float 12

			return true;
		}

		public void CopyTo(XQt2301OutBlock2 block)
		{
			block.actprice = this.actprice;
			block.optcode = this.optcode;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.volume = this.volume;
			block.iv = this.iv;
			block.mgjv = this.mgjv;
			block.mgjvupdn = this.mgjvupdn;
			block.offerho1 = this.offerho1;
			block.bidho1 = this.bidho1;
			block.cvolume = this.cvolume;
			block.delt = this.delt;
			block.gama = this.gama;
			block.vega = this.vega;
			block.ceta = this.ceta;
			block.rhox = this.rhox;
			block.theoryprice = this.theoryprice;
			block.impv = this.impv;
			block.timevl = this.timevl;
			block.jvolume = this.jvolume;
			block.parpl = this.parpl;
			block.jngo = this.jngo;
			block.offerrem1 = this.offerrem1;
			block.bidrem1 = this.bidrem1;
			block.open = this.open;
			block.high = this.high;
			block.low = this.low;
			block.atmgubun = this.atmgubun;
			block.jisuconv = this.jisuconv;
			block.value = this.value;

		}
	}

	/// <summary>
	/// 옵션전광판(t2301)
	/// </summary>
	public partial class XQt2301 : XingQuery
	{
		/// <summary>
		/// t2301
		/// </summary>
		public const string _typeName = "t2301";
		/// <summary>
		/// 옵션전광판(t2301)
		/// </summary>
		public const string _typeDesc = "옵션전광판(t2301)";
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
		/// t2301
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 옵션전광판(t2301)
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
		/// 옵션전광판(t2301)
		/// </summary>
		public XQt2301() : base("t2301") { }




		public bool SetBlock(XQt2301InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "yyyymm", 0, block.yyyymm); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1

			return true;
		}

		public XQt2301OutBlock GetBlock()
		{
			XQt2301OutBlock instance = XQt2301OutBlock.FromQuery(this);
			return instance;

		}

		public XQt2301OutBlock1[] GetBlock1s()
		{
			XQt2301OutBlock1[] instance = XQt2301OutBlock1.ListFromQuery(this);
			return instance;

		}

		public XQt2301OutBlock2[] GetBlock2s()
		{
			XQt2301OutBlock2[] instance = XQt2301OutBlock2.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt2301OutBlock),
			typeof(XQt2301OutBlock1),
			typeof(XQt2301OutBlock2),

		};

	}

}
