﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1956InBlock : XingBlock
	{
		/// <summary>
		/// t1956InBlock
		/// </summary>
		public const string _blockName = "t1956InBlock";
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
		/// t1956InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1956InBlock
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
		[XAQueryFieldAttribute("shcode", "단축코드", "char", "6")]
		public string shcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
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
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);

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

		public void CopyTo(XQt1956InBlock block)
		{
			block.shcode = this.shcode;

		}
	}

	public partial class XQt1956OutBlock : XingBlock
	{
		/// <summary>
		/// t1956OutBlock
		/// </summary>
		public const string _blockName = "t1956OutBlock";
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
		/// t1956OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1956OutBlock
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
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("hname", "한글명", "char", "40")]
		public string hname;
		/// <summary>
		/// 체결시간
		/// </summary>
		[XAQueryFieldAttribute("chetime", "체결시간", "char", "10")]
		public string chetime;
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
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "체결량", "long", "10")]
		public long cvolume;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "float", "12")]
		public float volume;
		/// <summary>
		/// 기준가
		/// </summary>
		[XAQueryFieldAttribute("recprice", "기준가", "long", "8")]
		public long recprice;
		/// <summary>
		/// 가중평균
		/// </summary>
		[XAQueryFieldAttribute("avg", "가중평균", "long", "8")]
		public long avg;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "float", "12")]
		public float jnilvolume;
		/// <summary>
		/// 전일동시간거래량
		/// </summary>
		[XAQueryFieldAttribute("jvolume", "전일동시간거래량", "float", "12")]
		public float jvolume;
		/// <summary>
		/// 전일종가
		/// </summary>
		[XAQueryFieldAttribute("jnilclose", "전일종가", "long", "8")]
		public long jnilclose;
		/// <summary>
		/// 거래량차
		/// </summary>
		[XAQueryFieldAttribute("volumechg", "거래량차", "float", "12")]
		public float volumechg;
		/// <summary>
		/// 거래량차등락율
		/// </summary>
		[XAQueryFieldAttribute("volumediff", "거래량차등락율", "float", "6.2")]
		public float volumediff;
		/// <summary>
		/// 시가
		/// </summary>
		[XAQueryFieldAttribute("open", "시가", "long", "8")]
		public long open;
		/// <summary>
		/// 시가등락율
		/// </summary>
		[XAQueryFieldAttribute("odiff", "시가등락율", "float", "6.2")]
		public float odiff;
		/// <summary>
		/// 시가시간
		/// </summary>
		[XAQueryFieldAttribute("opentime", "시가시간", "char", "6")]
		public string opentime;
		/// <summary>
		/// 고가
		/// </summary>
		[XAQueryFieldAttribute("high", "고가", "long", "8")]
		public long high;
		/// <summary>
		/// 고가등락율
		/// </summary>
		[XAQueryFieldAttribute("hdiff", "고가등락율", "float", "6.2")]
		public float hdiff;
		/// <summary>
		/// 고가시간
		/// </summary>
		[XAQueryFieldAttribute("hightime", "고가시간", "char", "6")]
		public string hightime;
		/// <summary>
		/// 저가
		/// </summary>
		[XAQueryFieldAttribute("low", "저가", "long", "8")]
		public long low;
		/// <summary>
		/// 저가등락율
		/// </summary>
		[XAQueryFieldAttribute("ldiff", "저가등락율", "float", "6.2")]
		public float ldiff;
		/// <summary>
		/// 저가시간
		/// </summary>
		[XAQueryFieldAttribute("lowtime", "저가시간", "char", "6")]
		public string lowtime;
		/// <summary>
		/// 52최고가
		/// </summary>
		[XAQueryFieldAttribute("high52w", "52최고가", "long", "8")]
		public long high52w;
		/// <summary>
		/// 52최고가등락율
		/// </summary>
		[XAQueryFieldAttribute("high52wdiff", "52최고가등락율", "float", "6.2")]
		public float high52wdiff;
		/// <summary>
		/// 52최고가일
		/// </summary>
		[XAQueryFieldAttribute("high52wdate", "52최고가일", "char", "8")]
		public string high52wdate;
		/// <summary>
		/// 52최저가
		/// </summary>
		[XAQueryFieldAttribute("low52w", "52최저가", "long", "8")]
		public long low52w;
		/// <summary>
		/// 52최저가등락율
		/// </summary>
		[XAQueryFieldAttribute("low52wdiff", "52최저가등락율", "float", "6.2")]
		public float low52wdiff;
		/// <summary>
		/// 52최저가일
		/// </summary>
		[XAQueryFieldAttribute("low52wdate", "52최저가일", "char", "8")]
		public string low52wdate;
		/// <summary>
		/// 소진율
		/// </summary>
		[XAQueryFieldAttribute("exhratio", "소진율", "float", "6.2")]
		public float exhratio;
		/// <summary>
		/// 상장주식수(천)
		/// </summary>
		[XAQueryFieldAttribute("listing", "상장주식수(천)", "float", "12")]
		public float listing;
		/// <summary>
		/// 수량단위
		/// </summary>
		[XAQueryFieldAttribute("memedan", "수량단위", "char", "5")]
		public string memedan;
		/// <summary>
		/// 회전율
		/// </summary>
		[XAQueryFieldAttribute("vol", "회전율", "float", "6.2")]
		public float vol;
		/// <summary>
		/// 패리티
		/// </summary>
		[XAQueryFieldAttribute("parity", "패리티", "float", "8.2")]
		public float parity;
		/// <summary>
		/// 손익분기
		/// </summary>
		[XAQueryFieldAttribute("berate", "손익분기", "float", "8.2")]
		public float berate;
		/// <summary>
		/// 기어링
		/// </summary>
		[XAQueryFieldAttribute("gearing", "기어링", "float", "8.2")]
		public float gearing;
		/// <summary>
		/// 행사가
		/// </summary>
		[XAQueryFieldAttribute("elwexec", "행사가", "float", "8.2")]
		public float elwexec;
		/// <summary>
		/// 발행가
		/// </summary>
		[XAQueryFieldAttribute("issueprice", "발행가", "long", "8")]
		public long issueprice;
		/// <summary>
		/// 전환비율
		/// </summary>
		[XAQueryFieldAttribute("convrate", "전환비율", "float", "12.4")]
		public float convrate;
		/// <summary>
		/// 최종거래일
		/// </summary>
		[XAQueryFieldAttribute("lastdate", "최종거래일", "char", "8")]
		public string lastdate;
		/// <summary>
		/// 자본지지
		/// </summary>
		[XAQueryFieldAttribute("capt", "자본지지", "float", "8.2")]
		public float capt;
		/// <summary>
		/// e.기어링
		/// </summary>
		[XAQueryFieldAttribute("egearing", "e.기어링", "float", "8.2")]
		public float egearing;
		/// <summary>
		/// 프리미엄
		/// </summary>
		[XAQueryFieldAttribute("premium", "프리미엄", "float", "8.2")]
		public float premium;
		/// <summary>
		/// 스프레드
		/// </summary>
		[XAQueryFieldAttribute("spread", "스프레드", "float", "6.2")]
		public float spread;
		/// <summary>
		/// 최대스프레드
		/// </summary>
		[XAQueryFieldAttribute("espread", "최대스프레드", "float", "6.2")]
		public float espread;
		/// <summary>
		/// 이론가
		/// </summary>
		[XAQueryFieldAttribute("theoryprice", "이론가", "float", "10.2")]
		public float theoryprice;
		/// <summary>
		/// 내재변동성
		/// </summary>
		[XAQueryFieldAttribute("impv", "내재변동성", "float", "6.2")]
		public float impv;
		/// <summary>
		/// 상태
		/// </summary>
		[XAQueryFieldAttribute("moneyness", "상태", "char", "1")]
		public char moneyness;
		/// <summary>
		/// 델타
		/// </summary>
		[XAQueryFieldAttribute("delt", "델타", "float", "8.6")]
		public float delt;
		/// <summary>
		/// 감마
		/// </summary>
		[XAQueryFieldAttribute("gama", "감마", "float", "8.6")]
		public float gama;
		/// <summary>
		/// 베가
		/// </summary>
		[XAQueryFieldAttribute("vega", "베가", "float", "13.6")]
		public float vega;
		/// <summary>
		/// 쎄타
		/// </summary>
		[XAQueryFieldAttribute("ceta", "쎄타", "float", "13.6")]
		public float ceta;
		/// <summary>
		/// 로
		/// </summary>
		[XAQueryFieldAttribute("rhox", "로", "float", "13.6")]
		public float rhox;
		/// <summary>
		/// 잔존일수
		/// </summary>
		[XAQueryFieldAttribute("bjandatecnt", "잔존일수", "long", "4")]
		public long bjandatecnt;
		/// <summary>
		/// 행사개시일
		/// </summary>
		[XAQueryFieldAttribute("mmsdate", "행사개시일", "char", "8")]
		public string mmsdate;
		/// <summary>
		/// 행사종료일
		/// </summary>
		[XAQueryFieldAttribute("mmedate", "행사종료일", "char", "8")]
		public string mmedate;
		/// <summary>
		/// 지급일
		/// </summary>
		[XAQueryFieldAttribute("payday", "지급일", "char", "8")]
		public string payday;
		/// <summary>
		/// 발행일
		/// </summary>
		[XAQueryFieldAttribute("listdate", "발행일", "char", "8")]
		public string listdate;
		/// <summary>
		/// LP회원사
		/// </summary>
		[XAQueryFieldAttribute("lpmem", "LP회원사", "char", "20")]
		public string lpmem;
		/// <summary>
		/// LP보유수량
		/// </summary>
		[XAQueryFieldAttribute("lp_holdvol", "LP보유수량", "float", "12")]
		public float lp_holdvol;
		/// <summary>
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("bcode", "기초자산코드", "char", "6")]
		public string bcode;
		/// <summary>
		/// 기초자산구분
		/// </summary>
		[XAQueryFieldAttribute("bgubun", "기초자산구분", "char", "1")]
		public char bgubun;
		/// <summary>
		/// 기초자산현재가
		/// </summary>
		[XAQueryFieldAttribute("bprice", "기초자산현재가", "long", "8")]
		public long bprice;
		/// <summary>
		/// 기초자산전일비구분
		/// </summary>
		[XAQueryFieldAttribute("bsign", "기초자산전일비구분", "char", "1")]
		public char bsign;
		/// <summary>
		/// 기초자산전일비
		/// </summary>
		[XAQueryFieldAttribute("bchange", "기초자산전일비", "long", "8")]
		public long bchange;
		/// <summary>
		/// 기초자산등락율
		/// </summary>
		[XAQueryFieldAttribute("bdiff", "기초자산등락율", "float", "6.2")]
		public float bdiff;
		/// <summary>
		/// 기초자산거래량
		/// </summary>
		[XAQueryFieldAttribute("bvolume", "기초자산거래량", "float", "12")]
		public float bvolume;
		/// <summary>
		/// 락구분
		/// </summary>
		[XAQueryFieldAttribute("info1", "락구분", "char", "10")]
		public string info1;
		/// <summary>
		/// 관리/급등구분
		/// </summary>
		[XAQueryFieldAttribute("info2", "관리/급등구분", "char", "10")]
		public string info2;
		/// <summary>
		/// 정지/연장구분
		/// </summary>
		[XAQueryFieldAttribute("info3", "정지/연장구분", "char", "10")]
		public string info3;
		/// <summary>
		/// 투자/불성실구분
		/// </summary>
		[XAQueryFieldAttribute("info4", "투자/불성실구분", "char", "12")]
		public string info4;
		/// <summary>
		/// 장구분
		/// </summary>
		[XAQueryFieldAttribute("janginfo", "장구분", "char", "10")]
		public string janginfo;
		/// <summary>
		/// 바스켓구분
		/// </summary>
		[XAQueryFieldAttribute("basketgb", "바스켓구분", "char", "1")]
		public char basketgb;
		/// <summary>
		/// 바스켓갯수
		/// </summary>
		[XAQueryFieldAttribute("basketcnt", "바스켓갯수", "long", "3")]
		public long basketcnt;
		/// <summary>
		/// ELW권리행사방식
		/// </summary>
		[XAQueryFieldAttribute("elwtype", "ELW권리행사방식", "char", "2")]
		public string elwtype;
		/// <summary>
		/// ELW결제방법
		/// </summary>
		[XAQueryFieldAttribute("settletype", "ELW결제방법", "char", "2")]
		public string settletype;
		/// <summary>
		/// LP사주문가능여부
		/// </summary>
		[XAQueryFieldAttribute("lpord", "LP사주문가능여부", "char", "2")]
		public string lpord;
		/// <summary>
		/// 권리내용
		/// </summary>
		[XAQueryFieldAttribute("elwdetail", "권리내용", "char", "100")]
		public string elwdetail;
		/// <summary>
		/// 만기평가가격방식
		/// </summary>
		[XAQueryFieldAttribute("valuation", "만기평가가격방식", "char", "100")]
		public string valuation;
		/// <summary>
		/// 확정지급액
		/// </summary>
		[XAQueryFieldAttribute("givemoney", "확정지급액", "float", "8.3")]
		public float givemoney;

		public static class F
		{
			/// <summary>
			/// 한글명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 체결시간
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
			/// 체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 기준가
			/// </summary>
			public const string recprice = "recprice";
			/// <summary>
			/// 가중평균
			/// </summary>
			public const string avg = "avg";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
			/// <summary>
			/// 전일동시간거래량
			/// </summary>
			public const string jvolume = "jvolume";
			/// <summary>
			/// 전일종가
			/// </summary>
			public const string jnilclose = "jnilclose";
			/// <summary>
			/// 거래량차
			/// </summary>
			public const string volumechg = "volumechg";
			/// <summary>
			/// 거래량차등락율
			/// </summary>
			public const string volumediff = "volumediff";
			/// <summary>
			/// 시가
			/// </summary>
			public const string open = "open";
			/// <summary>
			/// 시가등락율
			/// </summary>
			public const string odiff = "odiff";
			/// <summary>
			/// 시가시간
			/// </summary>
			public const string opentime = "opentime";
			/// <summary>
			/// 고가
			/// </summary>
			public const string high = "high";
			/// <summary>
			/// 고가등락율
			/// </summary>
			public const string hdiff = "hdiff";
			/// <summary>
			/// 고가시간
			/// </summary>
			public const string hightime = "hightime";
			/// <summary>
			/// 저가
			/// </summary>
			public const string low = "low";
			/// <summary>
			/// 저가등락율
			/// </summary>
			public const string ldiff = "ldiff";
			/// <summary>
			/// 저가시간
			/// </summary>
			public const string lowtime = "lowtime";
			/// <summary>
			/// 52최고가
			/// </summary>
			public const string high52w = "high52w";
			/// <summary>
			/// 52최고가등락율
			/// </summary>
			public const string high52wdiff = "high52wdiff";
			/// <summary>
			/// 52최고가일
			/// </summary>
			public const string high52wdate = "high52wdate";
			/// <summary>
			/// 52최저가
			/// </summary>
			public const string low52w = "low52w";
			/// <summary>
			/// 52최저가등락율
			/// </summary>
			public const string low52wdiff = "low52wdiff";
			/// <summary>
			/// 52최저가일
			/// </summary>
			public const string low52wdate = "low52wdate";
			/// <summary>
			/// 소진율
			/// </summary>
			public const string exhratio = "exhratio";
			/// <summary>
			/// 상장주식수(천)
			/// </summary>
			public const string listing = "listing";
			/// <summary>
			/// 수량단위
			/// </summary>
			public const string memedan = "memedan";
			/// <summary>
			/// 회전율
			/// </summary>
			public const string vol = "vol";
			/// <summary>
			/// 패리티
			/// </summary>
			public const string parity = "parity";
			/// <summary>
			/// 손익분기
			/// </summary>
			public const string berate = "berate";
			/// <summary>
			/// 기어링
			/// </summary>
			public const string gearing = "gearing";
			/// <summary>
			/// 행사가
			/// </summary>
			public const string elwexec = "elwexec";
			/// <summary>
			/// 발행가
			/// </summary>
			public const string issueprice = "issueprice";
			/// <summary>
			/// 전환비율
			/// </summary>
			public const string convrate = "convrate";
			/// <summary>
			/// 최종거래일
			/// </summary>
			public const string lastdate = "lastdate";
			/// <summary>
			/// 자본지지
			/// </summary>
			public const string capt = "capt";
			/// <summary>
			/// e.기어링
			/// </summary>
			public const string egearing = "egearing";
			/// <summary>
			/// 프리미엄
			/// </summary>
			public const string premium = "premium";
			/// <summary>
			/// 스프레드
			/// </summary>
			public const string spread = "spread";
			/// <summary>
			/// 최대스프레드
			/// </summary>
			public const string espread = "espread";
			/// <summary>
			/// 이론가
			/// </summary>
			public const string theoryprice = "theoryprice";
			/// <summary>
			/// 내재변동성
			/// </summary>
			public const string impv = "impv";
			/// <summary>
			/// 상태
			/// </summary>
			public const string moneyness = "moneyness";
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
			/// 로
			/// </summary>
			public const string rhox = "rhox";
			/// <summary>
			/// 잔존일수
			/// </summary>
			public const string bjandatecnt = "bjandatecnt";
			/// <summary>
			/// 행사개시일
			/// </summary>
			public const string mmsdate = "mmsdate";
			/// <summary>
			/// 행사종료일
			/// </summary>
			public const string mmedate = "mmedate";
			/// <summary>
			/// 지급일
			/// </summary>
			public const string payday = "payday";
			/// <summary>
			/// 발행일
			/// </summary>
			public const string listdate = "listdate";
			/// <summary>
			/// LP회원사
			/// </summary>
			public const string lpmem = "lpmem";
			/// <summary>
			/// LP보유수량
			/// </summary>
			public const string lp_holdvol = "lp_holdvol";
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string bcode = "bcode";
			/// <summary>
			/// 기초자산구분
			/// </summary>
			public const string bgubun = "bgubun";
			/// <summary>
			/// 기초자산현재가
			/// </summary>
			public const string bprice = "bprice";
			/// <summary>
			/// 기초자산전일비구분
			/// </summary>
			public const string bsign = "bsign";
			/// <summary>
			/// 기초자산전일비
			/// </summary>
			public const string bchange = "bchange";
			/// <summary>
			/// 기초자산등락율
			/// </summary>
			public const string bdiff = "bdiff";
			/// <summary>
			/// 기초자산거래량
			/// </summary>
			public const string bvolume = "bvolume";
			/// <summary>
			/// 락구분
			/// </summary>
			public const string info1 = "info1";
			/// <summary>
			/// 관리/급등구분
			/// </summary>
			public const string info2 = "info2";
			/// <summary>
			/// 정지/연장구분
			/// </summary>
			public const string info3 = "info3";
			/// <summary>
			/// 투자/불성실구분
			/// </summary>
			public const string info4 = "info4";
			/// <summary>
			/// 장구분
			/// </summary>
			public const string janginfo = "janginfo";
			/// <summary>
			/// 바스켓구분
			/// </summary>
			public const string basketgb = "basketgb";
			/// <summary>
			/// 바스켓갯수
			/// </summary>
			public const string basketcnt = "basketcnt";
			/// <summary>
			/// ELW권리행사방식
			/// </summary>
			public const string elwtype = "elwtype";
			/// <summary>
			/// ELW결제방법
			/// </summary>
			public const string settletype = "settletype";
			/// <summary>
			/// LP사주문가능여부
			/// </summary>
			public const string lpord = "lpord";
			/// <summary>
			/// 권리내용
			/// </summary>
			public const string elwdetail = "elwdetail";
			/// <summary>
			/// 만기평가가격방식
			/// </summary>
			public const string valuation = "valuation";
			/// <summary>
			/// 확정지급액
			/// </summary>
			public const string givemoney = "givemoney";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.chetime,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.cvolume,
			F.volume,
			F.recprice,
			F.avg,
			F.jnilvolume,
			F.jvolume,
			F.jnilclose,
			F.volumechg,
			F.volumediff,
			F.open,
			F.odiff,
			F.opentime,
			F.high,
			F.hdiff,
			F.hightime,
			F.low,
			F.ldiff,
			F.lowtime,
			F.high52w,
			F.high52wdiff,
			F.high52wdate,
			F.low52w,
			F.low52wdiff,
			F.low52wdate,
			F.exhratio,
			F.listing,
			F.memedan,
			F.vol,
			F.parity,
			F.berate,
			F.gearing,
			F.elwexec,
			F.issueprice,
			F.convrate,
			F.lastdate,
			F.capt,
			F.egearing,
			F.premium,
			F.spread,
			F.espread,
			F.theoryprice,
			F.impv,
			F.moneyness,
			F.delt,
			F.gama,
			F.vega,
			F.ceta,
			F.rhox,
			F.bjandatecnt,
			F.mmsdate,
			F.mmedate,
			F.payday,
			F.listdate,
			F.lpmem,
			F.lp_holdvol,
			F.bcode,
			F.bgubun,
			F.bprice,
			F.bsign,
			F.bchange,
			F.bdiff,
			F.bvolume,
			F.info1,
			F.info2,
			F.info3,
			F.info4,
			F.janginfo,
			F.basketgb,
			F.basketcnt,
			F.elwtype,
			F.settletype,
			F.lpord,
			F.elwdetail,
			F.valuation,
			F.givemoney,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)40);
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "체결시간", (decimal)10);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d10"), "체결량", (decimal)10);
			dict["volume"] = new XAQueryFieldInfo("float", volume, volume.ToString("000000000000"), "누적거래량", (decimal)12);
			dict["recprice"] = new XAQueryFieldInfo("long", recprice, recprice.ToString("d8"), "기준가", (decimal)8);
			dict["avg"] = new XAQueryFieldInfo("long", avg, avg.ToString("d8"), "가중평균", (decimal)8);
			dict["jnilvolume"] = new XAQueryFieldInfo("float", jnilvolume, jnilvolume.ToString("000000000000"), "전일거래량", (decimal)12);
			dict["jvolume"] = new XAQueryFieldInfo("float", jvolume, jvolume.ToString("000000000000"), "전일동시간거래량", (decimal)12);
			dict["jnilclose"] = new XAQueryFieldInfo("long", jnilclose, jnilclose.ToString("d8"), "전일종가", (decimal)8);
			dict["volumechg"] = new XAQueryFieldInfo("float", volumechg, volumechg.ToString("000000000000"), "거래량차", (decimal)12);
			dict["volumediff"] = new XAQueryFieldInfo("float", volumediff, volumediff.ToString("000000.00"), "거래량차등락율", (decimal)6.2);
			dict["open"] = new XAQueryFieldInfo("long", open, open.ToString("d8"), "시가", (decimal)8);
			dict["odiff"] = new XAQueryFieldInfo("float", odiff, odiff.ToString("000000.00"), "시가등락율", (decimal)6.2);
			dict["opentime"] = new XAQueryFieldInfo("char", opentime, opentime, "시가시간", (decimal)6);
			dict["high"] = new XAQueryFieldInfo("long", high, high.ToString("d8"), "고가", (decimal)8);
			dict["hdiff"] = new XAQueryFieldInfo("float", hdiff, hdiff.ToString("000000.00"), "고가등락율", (decimal)6.2);
			dict["hightime"] = new XAQueryFieldInfo("char", hightime, hightime, "고가시간", (decimal)6);
			dict["low"] = new XAQueryFieldInfo("long", low, low.ToString("d8"), "저가", (decimal)8);
			dict["ldiff"] = new XAQueryFieldInfo("float", ldiff, ldiff.ToString("000000.00"), "저가등락율", (decimal)6.2);
			dict["lowtime"] = new XAQueryFieldInfo("char", lowtime, lowtime, "저가시간", (decimal)6);
			dict["high52w"] = new XAQueryFieldInfo("long", high52w, high52w.ToString("d8"), "52최고가", (decimal)8);
			dict["high52wdiff"] = new XAQueryFieldInfo("float", high52wdiff, high52wdiff.ToString("000000.00"), "52최고가등락율", (decimal)6.2);
			dict["high52wdate"] = new XAQueryFieldInfo("char", high52wdate, high52wdate, "52최고가일", (decimal)8);
			dict["low52w"] = new XAQueryFieldInfo("long", low52w, low52w.ToString("d8"), "52최저가", (decimal)8);
			dict["low52wdiff"] = new XAQueryFieldInfo("float", low52wdiff, low52wdiff.ToString("000000.00"), "52최저가등락율", (decimal)6.2);
			dict["low52wdate"] = new XAQueryFieldInfo("char", low52wdate, low52wdate, "52최저가일", (decimal)8);
			dict["exhratio"] = new XAQueryFieldInfo("float", exhratio, exhratio.ToString("000000.00"), "소진율", (decimal)6.2);
			dict["listing"] = new XAQueryFieldInfo("float", listing, listing.ToString("000000000000"), "상장주식수(천)", (decimal)12);
			dict["memedan"] = new XAQueryFieldInfo("char", memedan, memedan, "수량단위", (decimal)5);
			dict["vol"] = new XAQueryFieldInfo("float", vol, vol.ToString("000000.00"), "회전율", (decimal)6.2);
			dict["parity"] = new XAQueryFieldInfo("float", parity, parity.ToString("00000000.00"), "패리티", (decimal)8.2);
			dict["berate"] = new XAQueryFieldInfo("float", berate, berate.ToString("00000000.00"), "손익분기", (decimal)8.2);
			dict["gearing"] = new XAQueryFieldInfo("float", gearing, gearing.ToString("00000000.00"), "기어링", (decimal)8.2);
			dict["elwexec"] = new XAQueryFieldInfo("float", elwexec, elwexec.ToString("00000000.00"), "행사가", (decimal)8.2);
			dict["issueprice"] = new XAQueryFieldInfo("long", issueprice, issueprice.ToString("d8"), "발행가", (decimal)8);
			dict["convrate"] = new XAQueryFieldInfo("float", convrate, convrate.ToString("000000000000.0000"), "전환비율", (decimal)12.4);
			dict["lastdate"] = new XAQueryFieldInfo("char", lastdate, lastdate, "최종거래일", (decimal)8);
			dict["capt"] = new XAQueryFieldInfo("float", capt, capt.ToString("00000000.00"), "자본지지", (decimal)8.2);
			dict["egearing"] = new XAQueryFieldInfo("float", egearing, egearing.ToString("00000000.00"), "e.기어링", (decimal)8.2);
			dict["premium"] = new XAQueryFieldInfo("float", premium, premium.ToString("00000000.00"), "프리미엄", (decimal)8.2);
			dict["spread"] = new XAQueryFieldInfo("float", spread, spread.ToString("000000.00"), "스프레드", (decimal)6.2);
			dict["espread"] = new XAQueryFieldInfo("float", espread, espread.ToString("000000.00"), "최대스프레드", (decimal)6.2);
			dict["theoryprice"] = new XAQueryFieldInfo("float", theoryprice, theoryprice.ToString("0000000000.00"), "이론가", (decimal)10.2);
			dict["impv"] = new XAQueryFieldInfo("float", impv, impv.ToString("000000.00"), "내재변동성", (decimal)6.2);
			dict["moneyness"] = new XAQueryFieldInfo("char", moneyness, moneyness.ToString(), "상태", (decimal)1);
			dict["delt"] = new XAQueryFieldInfo("float", delt, delt.ToString("00000000.000000"), "델타", (decimal)8.6);
			dict["gama"] = new XAQueryFieldInfo("float", gama, gama.ToString("00000000.000000"), "감마", (decimal)8.6);
			dict["vega"] = new XAQueryFieldInfo("float", vega, vega.ToString("0000000000000.000000"), "베가", (decimal)13.6);
			dict["ceta"] = new XAQueryFieldInfo("float", ceta, ceta.ToString("0000000000000.000000"), "쎄타", (decimal)13.6);
			dict["rhox"] = new XAQueryFieldInfo("float", rhox, rhox.ToString("0000000000000.000000"), "로", (decimal)13.6);
			dict["bjandatecnt"] = new XAQueryFieldInfo("long", bjandatecnt, bjandatecnt.ToString("d4"), "잔존일수", (decimal)4);
			dict["mmsdate"] = new XAQueryFieldInfo("char", mmsdate, mmsdate, "행사개시일", (decimal)8);
			dict["mmedate"] = new XAQueryFieldInfo("char", mmedate, mmedate, "행사종료일", (decimal)8);
			dict["payday"] = new XAQueryFieldInfo("char", payday, payday, "지급일", (decimal)8);
			dict["listdate"] = new XAQueryFieldInfo("char", listdate, listdate, "발행일", (decimal)8);
			dict["lpmem"] = new XAQueryFieldInfo("char", lpmem, lpmem, "LP회원사", (decimal)20);
			dict["lp_holdvol"] = new XAQueryFieldInfo("float", lp_holdvol, lp_holdvol.ToString("000000000000"), "LP보유수량", (decimal)12);
			dict["bcode"] = new XAQueryFieldInfo("char", bcode, bcode, "기초자산코드", (decimal)6);
			dict["bgubun"] = new XAQueryFieldInfo("char", bgubun, bgubun.ToString(), "기초자산구분", (decimal)1);
			dict["bprice"] = new XAQueryFieldInfo("long", bprice, bprice.ToString("d8"), "기초자산현재가", (decimal)8);
			dict["bsign"] = new XAQueryFieldInfo("char", bsign, bsign.ToString(), "기초자산전일비구분", (decimal)1);
			dict["bchange"] = new XAQueryFieldInfo("long", bchange, bchange.ToString("d8"), "기초자산전일비", (decimal)8);
			dict["bdiff"] = new XAQueryFieldInfo("float", bdiff, bdiff.ToString("000000.00"), "기초자산등락율", (decimal)6.2);
			dict["bvolume"] = new XAQueryFieldInfo("float", bvolume, bvolume.ToString("000000000000"), "기초자산거래량", (decimal)12);
			dict["info1"] = new XAQueryFieldInfo("char", info1, info1, "락구분", (decimal)10);
			dict["info2"] = new XAQueryFieldInfo("char", info2, info2, "관리/급등구분", (decimal)10);
			dict["info3"] = new XAQueryFieldInfo("char", info3, info3, "정지/연장구분", (decimal)10);
			dict["info4"] = new XAQueryFieldInfo("char", info4, info4, "투자/불성실구분", (decimal)12);
			dict["janginfo"] = new XAQueryFieldInfo("char", janginfo, janginfo, "장구분", (decimal)10);
			dict["basketgb"] = new XAQueryFieldInfo("char", basketgb, basketgb.ToString(), "바스켓구분", (decimal)1);
			dict["basketcnt"] = new XAQueryFieldInfo("long", basketcnt, basketcnt.ToString("d3"), "바스켓갯수", (decimal)3);
			dict["elwtype"] = new XAQueryFieldInfo("char", elwtype, elwtype, "ELW권리행사방식", (decimal)2);
			dict["settletype"] = new XAQueryFieldInfo("char", settletype, settletype, "ELW결제방법", (decimal)2);
			dict["lpord"] = new XAQueryFieldInfo("char", lpord, lpord, "LP사주문가능여부", (decimal)2);
			dict["elwdetail"] = new XAQueryFieldInfo("char", elwdetail, elwdetail, "권리내용", (decimal)100);
			dict["valuation"] = new XAQueryFieldInfo("char", valuation, valuation, "만기평가가격방식", (decimal)100);
			dict["givemoney"] = new XAQueryFieldInfo("float", givemoney, givemoney.ToString("00000000.000"), "확정지급액", (decimal)8.3);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

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

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseFloat("volume");
				break;

				case "recprice":
					this.recprice = fieldInfo.FieldValue.ParseLong("recprice");
				break;

				case "avg":
					this.avg = fieldInfo.FieldValue.ParseLong("avg");
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseFloat("jnilvolume");
				break;

				case "jvolume":
					this.jvolume = fieldInfo.FieldValue.ParseFloat("jvolume");
				break;

				case "jnilclose":
					this.jnilclose = fieldInfo.FieldValue.ParseLong("jnilclose");
				break;

				case "volumechg":
					this.volumechg = fieldInfo.FieldValue.ParseFloat("volumechg");
				break;

				case "volumediff":
					this.volumediff = fieldInfo.FieldValue.ParseFloat("volumediff");
				break;

				case "open":
					this.open = fieldInfo.FieldValue.ParseLong("open");
				break;

				case "odiff":
					this.odiff = fieldInfo.FieldValue.ParseFloat("odiff");
				break;

				case "opentime":
					this.opentime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "high":
					this.high = fieldInfo.FieldValue.ParseLong("high");
				break;

				case "hdiff":
					this.hdiff = fieldInfo.FieldValue.ParseFloat("hdiff");
				break;

				case "hightime":
					this.hightime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "low":
					this.low = fieldInfo.FieldValue.ParseLong("low");
				break;

				case "ldiff":
					this.ldiff = fieldInfo.FieldValue.ParseFloat("ldiff");
				break;

				case "lowtime":
					this.lowtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "high52w":
					this.high52w = fieldInfo.FieldValue.ParseLong("high52w");
				break;

				case "high52wdiff":
					this.high52wdiff = fieldInfo.FieldValue.ParseFloat("high52wdiff");
				break;

				case "high52wdate":
					this.high52wdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "low52w":
					this.low52w = fieldInfo.FieldValue.ParseLong("low52w");
				break;

				case "low52wdiff":
					this.low52wdiff = fieldInfo.FieldValue.ParseFloat("low52wdiff");
				break;

				case "low52wdate":
					this.low52wdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "exhratio":
					this.exhratio = fieldInfo.FieldValue.ParseFloat("exhratio");
				break;

				case "listing":
					this.listing = fieldInfo.FieldValue.ParseFloat("listing");
				break;

				case "memedan":
					this.memedan = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "vol":
					this.vol = fieldInfo.FieldValue.ParseFloat("vol");
				break;

				case "parity":
					this.parity = fieldInfo.FieldValue.ParseFloat("parity");
				break;

				case "berate":
					this.berate = fieldInfo.FieldValue.ParseFloat("berate");
				break;

				case "gearing":
					this.gearing = fieldInfo.FieldValue.ParseFloat("gearing");
				break;

				case "elwexec":
					this.elwexec = fieldInfo.FieldValue.ParseFloat("elwexec");
				break;

				case "issueprice":
					this.issueprice = fieldInfo.FieldValue.ParseLong("issueprice");
				break;

				case "convrate":
					this.convrate = fieldInfo.FieldValue.ParseFloat("convrate");
				break;

				case "lastdate":
					this.lastdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "capt":
					this.capt = fieldInfo.FieldValue.ParseFloat("capt");
				break;

				case "egearing":
					this.egearing = fieldInfo.FieldValue.ParseFloat("egearing");
				break;

				case "premium":
					this.premium = fieldInfo.FieldValue.ParseFloat("premium");
				break;

				case "spread":
					this.spread = fieldInfo.FieldValue.ParseFloat("spread");
				break;

				case "espread":
					this.espread = fieldInfo.FieldValue.ParseFloat("espread");
				break;

				case "theoryprice":
					this.theoryprice = fieldInfo.FieldValue.ParseFloat("theoryprice");
				break;

				case "impv":
					this.impv = fieldInfo.FieldValue.ParseFloat("impv");
				break;

				case "moneyness":
					this.moneyness = fieldInfo.FieldValue.FirstOrDefault();
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

				case "bjandatecnt":
					this.bjandatecnt = fieldInfo.FieldValue.ParseLong("bjandatecnt");
				break;

				case "mmsdate":
					this.mmsdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mmedate":
					this.mmedate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "payday":
					this.payday = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "listdate":
					this.listdate = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lpmem":
					this.lpmem = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lp_holdvol":
					this.lp_holdvol = fieldInfo.FieldValue.ParseFloat("lp_holdvol");
				break;

				case "bcode":
					this.bcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bgubun":
					this.bgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bprice":
					this.bprice = fieldInfo.FieldValue.ParseLong("bprice");
				break;

				case "bsign":
					this.bsign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bchange":
					this.bchange = fieldInfo.FieldValue.ParseLong("bchange");
				break;

				case "bdiff":
					this.bdiff = fieldInfo.FieldValue.ParseFloat("bdiff");
				break;

				case "bvolume":
					this.bvolume = fieldInfo.FieldValue.ParseFloat("bvolume");
				break;

				case "info1":
					this.info1 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "info2":
					this.info2 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "info3":
					this.info3 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "info4":
					this.info4 = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "janginfo":
					this.janginfo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "basketgb":
					this.basketgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "basketcnt":
					this.basketcnt = fieldInfo.FieldValue.ParseLong("basketcnt");
				break;

				case "elwtype":
					this.elwtype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "settletype":
					this.settletype = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "lpord":
					this.lpord = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "elwdetail":
					this.elwdetail = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "valuation":
					this.valuation = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "givemoney":
					this.givemoney = fieldInfo.FieldValue.ParseFloat("givemoney");
				break;


			}
		}

		public static XQt1956OutBlock FromQuery(XQt1956 query)
		{
			XQt1956OutBlock block = new XQt1956OutBlock();
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
				block.hname = query.GetFieldData(block.GetBlockName(), "hname", 0).TrimEnd('?'); // char 40
				block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", 0).TrimEnd('?'); // char 10
				block.price = query.GetFieldData(block.GetBlockName(), "price", 0).ParseLong("price"); // long 8
				block.sign = query.GetFieldData(block.GetBlockName(), "sign", 0).FirstOrDefault(); // char 1
				block.change = query.GetFieldData(block.GetBlockName(), "change", 0).ParseLong("change"); // long 8
				block.diff = query.GetFieldData(block.GetBlockName(), "diff", 0).ParseFloat("diff"); // float 6.2
				block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", 0).ParseLong("cvolume"); // long 10
				block.volume = query.GetFieldData(block.GetBlockName(), "volume", 0).ParseFloat("volume"); // float 12
				block.recprice = query.GetFieldData(block.GetBlockName(), "recprice", 0).ParseLong("recprice"); // long 8
				block.avg = query.GetFieldData(block.GetBlockName(), "avg", 0).ParseLong("avg"); // long 8
				block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", 0).ParseFloat("jnilvolume"); // float 12
				block.jvolume = query.GetFieldData(block.GetBlockName(), "jvolume", 0).ParseFloat("jvolume"); // float 12
				block.jnilclose = query.GetFieldData(block.GetBlockName(), "jnilclose", 0).ParseLong("jnilclose"); // long 8
				block.volumechg = query.GetFieldData(block.GetBlockName(), "volumechg", 0).ParseFloat("volumechg"); // float 12
				block.volumediff = query.GetFieldData(block.GetBlockName(), "volumediff", 0).ParseFloat("volumediff"); // float 6.2
				block.open = query.GetFieldData(block.GetBlockName(), "open", 0).ParseLong("open"); // long 8
				block.odiff = query.GetFieldData(block.GetBlockName(), "odiff", 0).ParseFloat("odiff"); // float 6.2
				block.opentime = query.GetFieldData(block.GetBlockName(), "opentime", 0).TrimEnd('?'); // char 6
				block.high = query.GetFieldData(block.GetBlockName(), "high", 0).ParseLong("high"); // long 8
				block.hdiff = query.GetFieldData(block.GetBlockName(), "hdiff", 0).ParseFloat("hdiff"); // float 6.2
				block.hightime = query.GetFieldData(block.GetBlockName(), "hightime", 0).TrimEnd('?'); // char 6
				block.low = query.GetFieldData(block.GetBlockName(), "low", 0).ParseLong("low"); // long 8
				block.ldiff = query.GetFieldData(block.GetBlockName(), "ldiff", 0).ParseFloat("ldiff"); // float 6.2
				block.lowtime = query.GetFieldData(block.GetBlockName(), "lowtime", 0).TrimEnd('?'); // char 6
				block.high52w = query.GetFieldData(block.GetBlockName(), "high52w", 0).ParseLong("high52w"); // long 8
				block.high52wdiff = query.GetFieldData(block.GetBlockName(), "high52wdiff", 0).ParseFloat("high52wdiff"); // float 6.2
				block.high52wdate = query.GetFieldData(block.GetBlockName(), "high52wdate", 0).TrimEnd('?'); // char 8
				block.low52w = query.GetFieldData(block.GetBlockName(), "low52w", 0).ParseLong("low52w"); // long 8
				block.low52wdiff = query.GetFieldData(block.GetBlockName(), "low52wdiff", 0).ParseFloat("low52wdiff"); // float 6.2
				block.low52wdate = query.GetFieldData(block.GetBlockName(), "low52wdate", 0).TrimEnd('?'); // char 8
				block.exhratio = query.GetFieldData(block.GetBlockName(), "exhratio", 0).ParseFloat("exhratio"); // float 6.2
				block.listing = query.GetFieldData(block.GetBlockName(), "listing", 0).ParseFloat("listing"); // float 12
				block.memedan = query.GetFieldData(block.GetBlockName(), "memedan", 0).TrimEnd('?'); // char 5
				block.vol = query.GetFieldData(block.GetBlockName(), "vol", 0).ParseFloat("vol"); // float 6.2
				block.parity = query.GetFieldData(block.GetBlockName(), "parity", 0).ParseFloat("parity"); // float 8.2
				block.berate = query.GetFieldData(block.GetBlockName(), "berate", 0).ParseFloat("berate"); // float 8.2
				block.gearing = query.GetFieldData(block.GetBlockName(), "gearing", 0).ParseFloat("gearing"); // float 8.2
				block.elwexec = query.GetFieldData(block.GetBlockName(), "elwexec", 0).ParseFloat("elwexec"); // float 8.2
				block.issueprice = query.GetFieldData(block.GetBlockName(), "issueprice", 0).ParseLong("issueprice"); // long 8
				block.convrate = query.GetFieldData(block.GetBlockName(), "convrate", 0).ParseFloat("convrate"); // float 12.4
				block.lastdate = query.GetFieldData(block.GetBlockName(), "lastdate", 0).TrimEnd('?'); // char 8
				block.capt = query.GetFieldData(block.GetBlockName(), "capt", 0).ParseFloat("capt"); // float 8.2
				block.egearing = query.GetFieldData(block.GetBlockName(), "egearing", 0).ParseFloat("egearing"); // float 8.2
				block.premium = query.GetFieldData(block.GetBlockName(), "premium", 0).ParseFloat("premium"); // float 8.2
				block.spread = query.GetFieldData(block.GetBlockName(), "spread", 0).ParseFloat("spread"); // float 6.2
				block.espread = query.GetFieldData(block.GetBlockName(), "espread", 0).ParseFloat("espread"); // float 6.2
				block.theoryprice = query.GetFieldData(block.GetBlockName(), "theoryprice", 0).ParseFloat("theoryprice"); // float 10.2
				block.impv = query.GetFieldData(block.GetBlockName(), "impv", 0).ParseFloat("impv"); // float 6.2
				block.moneyness = query.GetFieldData(block.GetBlockName(), "moneyness", 0).FirstOrDefault(); // char 1
				block.delt = query.GetFieldData(block.GetBlockName(), "delt", 0).ParseFloat("delt"); // float 8.6
				block.gama = query.GetFieldData(block.GetBlockName(), "gama", 0).ParseFloat("gama"); // float 8.6
				block.vega = query.GetFieldData(block.GetBlockName(), "vega", 0).ParseFloat("vega"); // float 13.6
				block.ceta = query.GetFieldData(block.GetBlockName(), "ceta", 0).ParseFloat("ceta"); // float 13.6
				block.rhox = query.GetFieldData(block.GetBlockName(), "rhox", 0).ParseFloat("rhox"); // float 13.6
				block.bjandatecnt = query.GetFieldData(block.GetBlockName(), "bjandatecnt", 0).ParseLong("bjandatecnt"); // long 4
				block.mmsdate = query.GetFieldData(block.GetBlockName(), "mmsdate", 0).TrimEnd('?'); // char 8
				block.mmedate = query.GetFieldData(block.GetBlockName(), "mmedate", 0).TrimEnd('?'); // char 8
				block.payday = query.GetFieldData(block.GetBlockName(), "payday", 0).TrimEnd('?'); // char 8
				block.listdate = query.GetFieldData(block.GetBlockName(), "listdate", 0).TrimEnd('?'); // char 8
				block.lpmem = query.GetFieldData(block.GetBlockName(), "lpmem", 0).TrimEnd('?'); // char 20
				block.lp_holdvol = query.GetFieldData(block.GetBlockName(), "lp_holdvol", 0).ParseFloat("lp_holdvol"); // float 12
				block.bcode = query.GetFieldData(block.GetBlockName(), "bcode", 0).TrimEnd('?'); // char 6
				block.bgubun = query.GetFieldData(block.GetBlockName(), "bgubun", 0).FirstOrDefault(); // char 1
				block.bprice = query.GetFieldData(block.GetBlockName(), "bprice", 0).ParseLong("bprice"); // long 8
				block.bsign = query.GetFieldData(block.GetBlockName(), "bsign", 0).FirstOrDefault(); // char 1
				block.bchange = query.GetFieldData(block.GetBlockName(), "bchange", 0).ParseLong("bchange"); // long 8
				block.bdiff = query.GetFieldData(block.GetBlockName(), "bdiff", 0).ParseFloat("bdiff"); // float 6.2
				block.bvolume = query.GetFieldData(block.GetBlockName(), "bvolume", 0).ParseFloat("bvolume"); // float 12
				block.info1 = query.GetFieldData(block.GetBlockName(), "info1", 0).TrimEnd('?'); // char 10
				block.info2 = query.GetFieldData(block.GetBlockName(), "info2", 0).TrimEnd('?'); // char 10
				block.info3 = query.GetFieldData(block.GetBlockName(), "info3", 0).TrimEnd('?'); // char 10
				block.info4 = query.GetFieldData(block.GetBlockName(), "info4", 0).TrimEnd('?'); // char 12
				block.janginfo = query.GetFieldData(block.GetBlockName(), "janginfo", 0).TrimEnd('?'); // char 10
				block.basketgb = query.GetFieldData(block.GetBlockName(), "basketgb", 0).FirstOrDefault(); // char 1
				block.basketcnt = query.GetFieldData(block.GetBlockName(), "basketcnt", 0).ParseLong("basketcnt"); // long 3
				block.elwtype = query.GetFieldData(block.GetBlockName(), "elwtype", 0).TrimEnd('?'); // char 2
				block.settletype = query.GetFieldData(block.GetBlockName(), "settletype", 0).TrimEnd('?'); // char 2
				block.lpord = query.GetFieldData(block.GetBlockName(), "lpord", 0).TrimEnd('?'); // char 2
				block.elwdetail = query.GetFieldData(block.GetBlockName(), "elwdetail", 0).TrimEnd('?'); // char 100
				block.valuation = query.GetFieldData(block.GetBlockName(), "valuation", 0).TrimEnd('?'); // char 100
				block.givemoney = query.GetFieldData(block.GetBlockName(), "givemoney", 0).ParseFloat("givemoney"); // float 8.3

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (hname?.Length > 40) return false; // char 40
			if (chetime?.Length > 10) return false; // char 10
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (cvolume.ToString().Length > 10) return false; // long 10
			// volume float 12
			if (recprice.ToString().Length > 8) return false; // long 8
			if (avg.ToString().Length > 8) return false; // long 8
			// jnilvolume float 12
			// jvolume float 12
			if (jnilclose.ToString().Length > 8) return false; // long 8
			// volumechg float 12
			// volumediff float 6.2
			if (open.ToString().Length > 8) return false; // long 8
			// odiff float 6.2
			if (opentime?.Length > 6) return false; // char 6
			if (high.ToString().Length > 8) return false; // long 8
			// hdiff float 6.2
			if (hightime?.Length > 6) return false; // char 6
			if (low.ToString().Length > 8) return false; // long 8
			// ldiff float 6.2
			if (lowtime?.Length > 6) return false; // char 6
			if (high52w.ToString().Length > 8) return false; // long 8
			// high52wdiff float 6.2
			if (high52wdate?.Length > 8) return false; // char 8
			if (low52w.ToString().Length > 8) return false; // long 8
			// low52wdiff float 6.2
			if (low52wdate?.Length > 8) return false; // char 8
			// exhratio float 6.2
			// listing float 12
			if (memedan?.Length > 5) return false; // char 5
			// vol float 6.2
			// parity float 8.2
			// berate float 8.2
			// gearing float 8.2
			// elwexec float 8.2
			if (issueprice.ToString().Length > 8) return false; // long 8
			// convrate float 12.4
			if (lastdate?.Length > 8) return false; // char 8
			// capt float 8.2
			// egearing float 8.2
			// premium float 8.2
			// spread float 6.2
			// espread float 6.2
			// theoryprice float 10.2
			// impv float 6.2
			// moneyness char 1
			// delt float 8.6
			// gama float 8.6
			// vega float 13.6
			// ceta float 13.6
			// rhox float 13.6
			if (bjandatecnt.ToString().Length > 4) return false; // long 4
			if (mmsdate?.Length > 8) return false; // char 8
			if (mmedate?.Length > 8) return false; // char 8
			if (payday?.Length > 8) return false; // char 8
			if (listdate?.Length > 8) return false; // char 8
			if (lpmem?.Length > 20) return false; // char 20
			// lp_holdvol float 12
			if (bcode?.Length > 6) return false; // char 6
			// bgubun char 1
			if (bprice.ToString().Length > 8) return false; // long 8
			// bsign char 1
			if (bchange.ToString().Length > 8) return false; // long 8
			// bdiff float 6.2
			// bvolume float 12
			if (info1?.Length > 10) return false; // char 10
			if (info2?.Length > 10) return false; // char 10
			if (info3?.Length > 10) return false; // char 10
			if (info4?.Length > 12) return false; // char 12
			if (janginfo?.Length > 10) return false; // char 10
			// basketgb char 1
			if (basketcnt.ToString().Length > 3) return false; // long 3
			if (elwtype?.Length > 2) return false; // char 2
			if (settletype?.Length > 2) return false; // char 2
			if (lpord?.Length > 2) return false; // char 2
			if (elwdetail?.Length > 100) return false; // char 100
			if (valuation?.Length > 100) return false; // char 100
			// givemoney float 8.3

			return true;
		}

		public void CopyTo(XQt1956OutBlock block)
		{
			block.hname = this.hname;
			block.chetime = this.chetime;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.cvolume = this.cvolume;
			block.volume = this.volume;
			block.recprice = this.recprice;
			block.avg = this.avg;
			block.jnilvolume = this.jnilvolume;
			block.jvolume = this.jvolume;
			block.jnilclose = this.jnilclose;
			block.volumechg = this.volumechg;
			block.volumediff = this.volumediff;
			block.open = this.open;
			block.odiff = this.odiff;
			block.opentime = this.opentime;
			block.high = this.high;
			block.hdiff = this.hdiff;
			block.hightime = this.hightime;
			block.low = this.low;
			block.ldiff = this.ldiff;
			block.lowtime = this.lowtime;
			block.high52w = this.high52w;
			block.high52wdiff = this.high52wdiff;
			block.high52wdate = this.high52wdate;
			block.low52w = this.low52w;
			block.low52wdiff = this.low52wdiff;
			block.low52wdate = this.low52wdate;
			block.exhratio = this.exhratio;
			block.listing = this.listing;
			block.memedan = this.memedan;
			block.vol = this.vol;
			block.parity = this.parity;
			block.berate = this.berate;
			block.gearing = this.gearing;
			block.elwexec = this.elwexec;
			block.issueprice = this.issueprice;
			block.convrate = this.convrate;
			block.lastdate = this.lastdate;
			block.capt = this.capt;
			block.egearing = this.egearing;
			block.premium = this.premium;
			block.spread = this.spread;
			block.espread = this.espread;
			block.theoryprice = this.theoryprice;
			block.impv = this.impv;
			block.moneyness = this.moneyness;
			block.delt = this.delt;
			block.gama = this.gama;
			block.vega = this.vega;
			block.ceta = this.ceta;
			block.rhox = this.rhox;
			block.bjandatecnt = this.bjandatecnt;
			block.mmsdate = this.mmsdate;
			block.mmedate = this.mmedate;
			block.payday = this.payday;
			block.listdate = this.listdate;
			block.lpmem = this.lpmem;
			block.lp_holdvol = this.lp_holdvol;
			block.bcode = this.bcode;
			block.bgubun = this.bgubun;
			block.bprice = this.bprice;
			block.bsign = this.bsign;
			block.bchange = this.bchange;
			block.bdiff = this.bdiff;
			block.bvolume = this.bvolume;
			block.info1 = this.info1;
			block.info2 = this.info2;
			block.info3 = this.info3;
			block.info4 = this.info4;
			block.janginfo = this.janginfo;
			block.basketgb = this.basketgb;
			block.basketcnt = this.basketcnt;
			block.elwtype = this.elwtype;
			block.settletype = this.settletype;
			block.lpord = this.lpord;
			block.elwdetail = this.elwdetail;
			block.valuation = this.valuation;
			block.givemoney = this.givemoney;

		}
	}

	public partial class XQt1956OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1956OutBlock1
		/// </summary>
		public const string _blockName = "t1956OutBlock1";
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
		/// t1956OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1956OutBlock1
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
		/// 기초자산코드
		/// </summary>
		[XAQueryFieldAttribute("bskcode", "기초자산코드", "char", "6")]
		public string bskcode;
		/// <summary>
		/// 기초자산비율
		/// </summary>
		[XAQueryFieldAttribute("bskbno", "기초자산비율", "long", "3")]
		public long bskbno;
		/// <summary>
		/// 기초자산현재가
		/// </summary>
		[XAQueryFieldAttribute("bskprice", "기초자산현재가", "long", "8")]
		public long bskprice;
		/// <summary>
		/// 기초자산전일비구분
		/// </summary>
		[XAQueryFieldAttribute("bsksign", "기초자산전일비구분", "char", "1")]
		public char bsksign;
		/// <summary>
		/// 기초자산전일비
		/// </summary>
		[XAQueryFieldAttribute("bskchange", "기초자산전일비", "long", "8")]
		public long bskchange;
		/// <summary>
		/// 기초자산등락율
		/// </summary>
		[XAQueryFieldAttribute("bskdiff", "기초자산등락율", "float", "6.2")]
		public float bskdiff;
		/// <summary>
		/// 기초자산거래량
		/// </summary>
		[XAQueryFieldAttribute("bskvolume", "기초자산거래량", "float", "12")]
		public float bskvolume;
		/// <summary>
		/// 기초자산전일종가
		/// </summary>
		[XAQueryFieldAttribute("bskjnilclose", "기초자산전일종가", "long", "8")]
		public long bskjnilclose;

		public static class F
		{
			/// <summary>
			/// 기초자산코드
			/// </summary>
			public const string bskcode = "bskcode";
			/// <summary>
			/// 기초자산비율
			/// </summary>
			public const string bskbno = "bskbno";
			/// <summary>
			/// 기초자산현재가
			/// </summary>
			public const string bskprice = "bskprice";
			/// <summary>
			/// 기초자산전일비구분
			/// </summary>
			public const string bsksign = "bsksign";
			/// <summary>
			/// 기초자산전일비
			/// </summary>
			public const string bskchange = "bskchange";
			/// <summary>
			/// 기초자산등락율
			/// </summary>
			public const string bskdiff = "bskdiff";
			/// <summary>
			/// 기초자산거래량
			/// </summary>
			public const string bskvolume = "bskvolume";
			/// <summary>
			/// 기초자산전일종가
			/// </summary>
			public const string bskjnilclose = "bskjnilclose";
		}

		public static string[] AllFields = new string[]
		{
			F.bskcode,
			F.bskbno,
			F.bskprice,
			F.bsksign,
			F.bskchange,
			F.bskdiff,
			F.bskvolume,
			F.bskjnilclose,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["bskcode"] = new XAQueryFieldInfo("char", bskcode, bskcode, "기초자산코드", (decimal)6);
			dict["bskbno"] = new XAQueryFieldInfo("long", bskbno, bskbno.ToString("d3"), "기초자산비율", (decimal)3);
			dict["bskprice"] = new XAQueryFieldInfo("long", bskprice, bskprice.ToString("d8"), "기초자산현재가", (decimal)8);
			dict["bsksign"] = new XAQueryFieldInfo("char", bsksign, bsksign.ToString(), "기초자산전일비구분", (decimal)1);
			dict["bskchange"] = new XAQueryFieldInfo("long", bskchange, bskchange.ToString("d8"), "기초자산전일비", (decimal)8);
			dict["bskdiff"] = new XAQueryFieldInfo("float", bskdiff, bskdiff.ToString("000000.00"), "기초자산등락율", (decimal)6.2);
			dict["bskvolume"] = new XAQueryFieldInfo("float", bskvolume, bskvolume.ToString("000000000000"), "기초자산거래량", (decimal)12);
			dict["bskjnilclose"] = new XAQueryFieldInfo("long", bskjnilclose, bskjnilclose.ToString("d8"), "기초자산전일종가", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "bskcode":
					this.bskcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "bskbno":
					this.bskbno = fieldInfo.FieldValue.ParseLong("bskbno");
				break;

				case "bskprice":
					this.bskprice = fieldInfo.FieldValue.ParseLong("bskprice");
				break;

				case "bsksign":
					this.bsksign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "bskchange":
					this.bskchange = fieldInfo.FieldValue.ParseLong("bskchange");
				break;

				case "bskdiff":
					this.bskdiff = fieldInfo.FieldValue.ParseFloat("bskdiff");
				break;

				case "bskvolume":
					this.bskvolume = fieldInfo.FieldValue.ParseFloat("bskvolume");
				break;

				case "bskjnilclose":
					this.bskjnilclose = fieldInfo.FieldValue.ParseLong("bskjnilclose");
				break;


			}
		}

		public static XQt1956OutBlock1[] ListFromQuery(XQt1956 query)
		{
			int count = query.GetBlockCount(XQt1956OutBlock1.BlockName);
			List<XQt1956OutBlock1> list = new List<XQt1956OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1956OutBlock1 block = new XQt1956OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.bskcode = query.GetFieldData(block.GetBlockName(), "bskcode", i).TrimEnd('?'); // char 6
					block.bskbno = query.GetFieldData(block.GetBlockName(), "bskbno", i).ParseLong("bskbno"); // long 3
					block.bskprice = query.GetFieldData(block.GetBlockName(), "bskprice", i).ParseLong("bskprice"); // long 8
					block.bsksign = query.GetFieldData(block.GetBlockName(), "bsksign", i).FirstOrDefault(); // char 1
					block.bskchange = query.GetFieldData(block.GetBlockName(), "bskchange", i).ParseLong("bskchange"); // long 8
					block.bskdiff = query.GetFieldData(block.GetBlockName(), "bskdiff", i).ParseFloat("bskdiff"); // float 6.2
					block.bskvolume = query.GetFieldData(block.GetBlockName(), "bskvolume", i).ParseFloat("bskvolume"); // float 12
					block.bskjnilclose = query.GetFieldData(block.GetBlockName(), "bskjnilclose", i).ParseLong("bskjnilclose"); // long 8

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
			if (bskcode?.Length > 6) return false; // char 6
			if (bskbno.ToString().Length > 3) return false; // long 3
			if (bskprice.ToString().Length > 8) return false; // long 8
			// bsksign char 1
			if (bskchange.ToString().Length > 8) return false; // long 8
			// bskdiff float 6.2
			// bskvolume float 12
			if (bskjnilclose.ToString().Length > 8) return false; // long 8

			return true;
		}

		public void CopyTo(XQt1956OutBlock1 block)
		{
			block.bskcode = this.bskcode;
			block.bskbno = this.bskbno;
			block.bskprice = this.bskprice;
			block.bsksign = this.bsksign;
			block.bskchange = this.bskchange;
			block.bskdiff = this.bskdiff;
			block.bskvolume = this.bskvolume;
			block.bskjnilclose = this.bskjnilclose;

		}
	}

	/// <summary>
	/// ELW현재가(확정지급액)조회(t1956)
	/// </summary>
	public partial class XQt1956 : XingQuery
	{
		/// <summary>
		/// t1956
		/// </summary>
		public const string _typeName = "t1956";
		/// <summary>
		/// ELW현재가(확정지급액)조회(t1956)
		/// </summary>
		public const string _typeDesc = "ELW현재가(확정지급액)조회(t1956)";
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
		/// t1956
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// ELW현재가(확정지급액)조회(t1956)
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
		/// ELW현재가(확정지급액)조회(t1956)
		/// </summary>
		public XQt1956() : base("t1956") { }


		public class XQAllOutBlocks
		{
			public XQt1956OutBlock OutBlock { get; internal set; }
			public XQt1956OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default)
		{
			using (XQt1956 instance = new XQt1956())
			{
				instance.SetFieldData(XQt1956InBlock.BlockName, XQt1956InBlock.F.shcode, 0, shcode); // char 6

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string shcode = default */)
		{
			using (XQt1956 instance = new XQt1956())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1956OutBlock" : $"XQt1956OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1956OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1956OutBlock1" : $"XQt1956OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1956OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1956InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6

			return true;
		}

		public XQt1956OutBlock GetBlock()
		{
			XQt1956OutBlock instance = XQt1956OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1956OutBlock1[] GetBlock1s()
		{
			XQt1956OutBlock1[] instance = XQt1956OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1956OutBlock),
			typeof(XQt1956OutBlock1),

		};

	}

}
