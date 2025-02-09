﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt0434InBlock : XingBlock
	{
		/// <summary>
		/// t0434InBlock
		/// </summary>
		public const string _blockName = "t0434InBlock";
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
		/// t0434InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0434InBlock
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
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("accno", "계좌번호", "char", "11")]
		public string accno;
		/// <summary>
		/// 비밀번호
		/// </summary>
		[XAQueryFieldAttribute("passwd", "비밀번호", "char", "8")]
		public string passwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("expcode", "종목번호", "char", "8")]
		public string expcode;
		/// <summary>
		/// 체결구분
		/// </summary>
		[XAQueryFieldAttribute("chegb", "체결구분", "char", "1")]
		public char chegb;
		/// <summary>
		/// 정렬순서
		/// </summary>
		[XAQueryFieldAttribute("sortgb", "정렬순서", "char", "1")]
		public char sortgb;
		/// <summary>
		/// CTS_주문번호
		/// </summary>
		[XAQueryFieldAttribute("cts_ordno", "CTS_주문번호", "char", "7")]
		public string cts_ordno;

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string accno = "accno";
			/// <summary>
			/// 비밀번호
			/// </summary>
			public const string passwd = "passwd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 체결구분
			/// </summary>
			public const string chegb = "chegb";
			/// <summary>
			/// 정렬순서
			/// </summary>
			public const string sortgb = "sortgb";
			/// <summary>
			/// CTS_주문번호
			/// </summary>
			public const string cts_ordno = "cts_ordno";
		}

		public static string[] AllFields = new string[]
		{
			F.accno,
			F.passwd,
			F.expcode,
			F.chegb,
			F.sortgb,
			F.cts_ordno,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["accno"] = new XAQueryFieldInfo("char", accno, accno, "계좌번호", (decimal)11);
			dict["passwd"] = new XAQueryFieldInfo("char", passwd, passwd, "비밀번호", (decimal)8);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)8);
			dict["chegb"] = new XAQueryFieldInfo("char", chegb, chegb.ToString(), "체결구분", (decimal)1);
			dict["sortgb"] = new XAQueryFieldInfo("char", sortgb, sortgb.ToString(), "정렬순서", (decimal)1);
			dict["cts_ordno"] = new XAQueryFieldInfo("char", cts_ordno, cts_ordno, "CTS_주문번호", (decimal)7);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "accno":
					this.accno = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "passwd":
					this.passwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "chegb":
					this.chegb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "sortgb":
					this.sortgb = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "cts_ordno":
					this.cts_ordno = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (accno?.Length > 11) return false; // char 11
			if (passwd?.Length > 8) return false; // char 8
			if (expcode?.Length > 8) return false; // char 8
			// chegb char 1
			// sortgb char 1
			if (cts_ordno?.Length > 7) return false; // char 7

			return true;
		}

		public void CopyTo(XQt0434InBlock block)
		{
			block.accno = this.accno;
			block.passwd = this.passwd;
			block.expcode = this.expcode;
			block.chegb = this.chegb;
			block.sortgb = this.sortgb;
			block.cts_ordno = this.cts_ordno;

		}
	}

	public partial class XQt0434OutBlock : XingBlock
	{
		/// <summary>
		/// t0434OutBlock
		/// </summary>
		public const string _blockName = "t0434OutBlock";
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
		/// t0434OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0434OutBlock
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
		/// CTS_주문번호
		/// </summary>
		[XAQueryFieldAttribute("cts_ordno", "CTS_주문번호", "char", "7")]
		public string cts_ordno;

		public static class F
		{
			/// <summary>
			/// CTS_주문번호
			/// </summary>
			public const string cts_ordno = "cts_ordno";
		}

		public static string[] AllFields = new string[]
		{
			F.cts_ordno,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["cts_ordno"] = new XAQueryFieldInfo("char", cts_ordno, cts_ordno, "CTS_주문번호", (decimal)7);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "cts_ordno":
					this.cts_ordno = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt0434OutBlock FromQuery(XQt0434 query)
		{
			XQt0434OutBlock block = new XQt0434OutBlock();
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
				block.cts_ordno = query.GetFieldData(block.GetBlockName(), "cts_ordno", 0).TrimEnd('?'); // char 7

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (cts_ordno?.Length > 7) return false; // char 7

			return true;
		}

		public void CopyTo(XQt0434OutBlock block)
		{
			block.cts_ordno = this.cts_ordno;

		}
	}

	public partial class XQt0434OutBlock1 : XingBlock
	{
		/// <summary>
		/// t0434OutBlock1
		/// </summary>
		public const string _blockName = "t0434OutBlock1";
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
		/// t0434OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t0434OutBlock1
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
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("ordno", "주문번호", "long", "7")]
		public long ordno;
		/// <summary>
		/// 원주문번호
		/// </summary>
		[XAQueryFieldAttribute("orgordno", "원주문번호", "long", "7")]
		public long orgordno;
		/// <summary>
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("medosu", "구분", "char", "10")]
		public string medosu;
		/// <summary>
		/// 유형
		/// </summary>
		[XAQueryFieldAttribute("ordgb", "유형", "char", "20")]
		public string ordgb;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("qty", "주문수량", "long", "9")]
		public long qty;
		/// <summary>
		/// 주문가격
		/// </summary>
		[XAQueryFieldAttribute("price", "주문가격", "float", "9.2")]
		public float price;
		/// <summary>
		/// 체결수량
		/// </summary>
		[XAQueryFieldAttribute("cheqty", "체결수량", "long", "9")]
		public long cheqty;
		/// <summary>
		/// 체결가격
		/// </summary>
		[XAQueryFieldAttribute("cheprice", "체결가격", "float", "9.2")]
		public float cheprice;
		/// <summary>
		/// 미체결잔량
		/// </summary>
		[XAQueryFieldAttribute("ordrem", "미체결잔량", "long", "9")]
		public long ordrem;
		/// <summary>
		/// 상태
		/// </summary>
		[XAQueryFieldAttribute("status", "상태", "char", "10")]
		public string status;
		/// <summary>
		/// 주문시간
		/// </summary>
		[XAQueryFieldAttribute("ordtime", "주문시간", "char", "8")]
		public string ordtime;
		/// <summary>
		/// 주문매체
		/// </summary>
		[XAQueryFieldAttribute("ordermtd", "주문매체", "char", "10")]
		public string ordermtd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("expcode", "종목번호", "char", "8")]
		public string expcode;
		/// <summary>
		/// 사유코드
		/// </summary>
		[XAQueryFieldAttribute("rtcode", "사유코드", "char", "3")]
		public string rtcode;
		/// <summary>
		/// 처리순번
		/// </summary>
		[XAQueryFieldAttribute("sysprocseq", "처리순번", "long", "10")]
		public long sysprocseq;
		/// <summary>
		/// 호가타입
		/// </summary>
		[XAQueryFieldAttribute("hogatype", "호가타입", "char", "1")]
		public char hogatype;

		public static class F
		{
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string ordno = "ordno";
			/// <summary>
			/// 원주문번호
			/// </summary>
			public const string orgordno = "orgordno";
			/// <summary>
			/// 구분
			/// </summary>
			public const string medosu = "medosu";
			/// <summary>
			/// 유형
			/// </summary>
			public const string ordgb = "ordgb";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string qty = "qty";
			/// <summary>
			/// 주문가격
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 체결수량
			/// </summary>
			public const string cheqty = "cheqty";
			/// <summary>
			/// 체결가격
			/// </summary>
			public const string cheprice = "cheprice";
			/// <summary>
			/// 미체결잔량
			/// </summary>
			public const string ordrem = "ordrem";
			/// <summary>
			/// 상태
			/// </summary>
			public const string status = "status";
			/// <summary>
			/// 주문시간
			/// </summary>
			public const string ordtime = "ordtime";
			/// <summary>
			/// 주문매체
			/// </summary>
			public const string ordermtd = "ordermtd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 사유코드
			/// </summary>
			public const string rtcode = "rtcode";
			/// <summary>
			/// 처리순번
			/// </summary>
			public const string sysprocseq = "sysprocseq";
			/// <summary>
			/// 호가타입
			/// </summary>
			public const string hogatype = "hogatype";
		}

		public static string[] AllFields = new string[]
		{
			F.ordno,
			F.orgordno,
			F.medosu,
			F.ordgb,
			F.qty,
			F.price,
			F.cheqty,
			F.cheprice,
			F.ordrem,
			F.status,
			F.ordtime,
			F.ordermtd,
			F.expcode,
			F.rtcode,
			F.sysprocseq,
			F.hogatype,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ordno"] = new XAQueryFieldInfo("long", ordno, ordno.ToString("d7"), "주문번호", (decimal)7);
			dict["orgordno"] = new XAQueryFieldInfo("long", orgordno, orgordno.ToString("d7"), "원주문번호", (decimal)7);
			dict["medosu"] = new XAQueryFieldInfo("char", medosu, medosu, "구분", (decimal)10);
			dict["ordgb"] = new XAQueryFieldInfo("char", ordgb, ordgb, "유형", (decimal)20);
			dict["qty"] = new XAQueryFieldInfo("long", qty, qty.ToString("d9"), "주문수량", (decimal)9);
			dict["price"] = new XAQueryFieldInfo("float", price, price.ToString("000000000.00"), "주문가격", (decimal)9.2);
			dict["cheqty"] = new XAQueryFieldInfo("long", cheqty, cheqty.ToString("d9"), "체결수량", (decimal)9);
			dict["cheprice"] = new XAQueryFieldInfo("float", cheprice, cheprice.ToString("000000000.00"), "체결가격", (decimal)9.2);
			dict["ordrem"] = new XAQueryFieldInfo("long", ordrem, ordrem.ToString("d9"), "미체결잔량", (decimal)9);
			dict["status"] = new XAQueryFieldInfo("char", status, status, "상태", (decimal)10);
			dict["ordtime"] = new XAQueryFieldInfo("char", ordtime, ordtime, "주문시간", (decimal)8);
			dict["ordermtd"] = new XAQueryFieldInfo("char", ordermtd, ordermtd, "주문매체", (decimal)10);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "종목번호", (decimal)8);
			dict["rtcode"] = new XAQueryFieldInfo("char", rtcode, rtcode, "사유코드", (decimal)3);
			dict["sysprocseq"] = new XAQueryFieldInfo("long", sysprocseq, sysprocseq.ToString("d10"), "처리순번", (decimal)10);
			dict["hogatype"] = new XAQueryFieldInfo("char", hogatype, hogatype.ToString(), "호가타입", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "ordno":
					this.ordno = fieldInfo.FieldValue.ParseLong("ordno");
				break;

				case "orgordno":
					this.orgordno = fieldInfo.FieldValue.ParseLong("orgordno");
				break;

				case "medosu":
					this.medosu = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordgb":
					this.ordgb = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "qty":
					this.qty = fieldInfo.FieldValue.ParseLong("qty");
				break;

				case "price":
					this.price = fieldInfo.FieldValue.ParseFloat("price");
				break;

				case "cheqty":
					this.cheqty = fieldInfo.FieldValue.ParseLong("cheqty");
				break;

				case "cheprice":
					this.cheprice = fieldInfo.FieldValue.ParseFloat("cheprice");
				break;

				case "ordrem":
					this.ordrem = fieldInfo.FieldValue.ParseLong("ordrem");
				break;

				case "status":
					this.status = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordtime":
					this.ordtime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ordermtd":
					this.ordermtd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rtcode":
					this.rtcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sysprocseq":
					this.sysprocseq = fieldInfo.FieldValue.ParseLong("sysprocseq");
				break;

				case "hogatype":
					this.hogatype = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt0434OutBlock1[] ListFromQuery(XQt0434 query)
		{
			int count = query.GetBlockCount(XQt0434OutBlock1.BlockName);
			List<XQt0434OutBlock1> list = new List<XQt0434OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt0434OutBlock1 block = new XQt0434OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.ordno = query.GetFieldData(block.GetBlockName(), "ordno", i).ParseLong("ordno"); // long 7
					block.orgordno = query.GetFieldData(block.GetBlockName(), "orgordno", i).ParseLong("orgordno"); // long 7
					block.medosu = query.GetFieldData(block.GetBlockName(), "medosu", i).TrimEnd('?'); // char 10
					block.ordgb = query.GetFieldData(block.GetBlockName(), "ordgb", i).TrimEnd('?'); // char 20
					block.qty = query.GetFieldData(block.GetBlockName(), "qty", i).ParseLong("qty"); // long 9
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseFloat("price"); // float 9.2
					block.cheqty = query.GetFieldData(block.GetBlockName(), "cheqty", i).ParseLong("cheqty"); // long 9
					block.cheprice = query.GetFieldData(block.GetBlockName(), "cheprice", i).ParseFloat("cheprice"); // float 9.2
					block.ordrem = query.GetFieldData(block.GetBlockName(), "ordrem", i).ParseLong("ordrem"); // long 9
					block.status = query.GetFieldData(block.GetBlockName(), "status", i).TrimEnd('?'); // char 10
					block.ordtime = query.GetFieldData(block.GetBlockName(), "ordtime", i).TrimEnd('?'); // char 8
					block.ordermtd = query.GetFieldData(block.GetBlockName(), "ordermtd", i).TrimEnd('?'); // char 10
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 8
					block.rtcode = query.GetFieldData(block.GetBlockName(), "rtcode", i).TrimEnd('?'); // char 3
					block.sysprocseq = query.GetFieldData(block.GetBlockName(), "sysprocseq", i).ParseLong("sysprocseq"); // long 10
					block.hogatype = query.GetFieldData(block.GetBlockName(), "hogatype", i).FirstOrDefault(); // char 1

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
			if (ordno.ToString().Length > 7) return false; // long 7
			if (orgordno.ToString().Length > 7) return false; // long 7
			if (medosu?.Length > 10) return false; // char 10
			if (ordgb?.Length > 20) return false; // char 20
			if (qty.ToString().Length > 9) return false; // long 9
			// price float 9.2
			if (cheqty.ToString().Length > 9) return false; // long 9
			// cheprice float 9.2
			if (ordrem.ToString().Length > 9) return false; // long 9
			if (status?.Length > 10) return false; // char 10
			if (ordtime?.Length > 8) return false; // char 8
			if (ordermtd?.Length > 10) return false; // char 10
			if (expcode?.Length > 8) return false; // char 8
			if (rtcode?.Length > 3) return false; // char 3
			if (sysprocseq.ToString().Length > 10) return false; // long 10
			// hogatype char 1

			return true;
		}

		public void CopyTo(XQt0434OutBlock1 block)
		{
			block.ordno = this.ordno;
			block.orgordno = this.orgordno;
			block.medosu = this.medosu;
			block.ordgb = this.ordgb;
			block.qty = this.qty;
			block.price = this.price;
			block.cheqty = this.cheqty;
			block.cheprice = this.cheprice;
			block.ordrem = this.ordrem;
			block.status = this.status;
			block.ordtime = this.ordtime;
			block.ordermtd = this.ordermtd;
			block.expcode = this.expcode;
			block.rtcode = this.rtcode;
			block.sysprocseq = this.sysprocseq;
			block.hogatype = this.hogatype;

		}
	}

	/// <summary>
	/// 선물/옵션체결/미체결(t0434)
	/// </summary>
	public partial class XQt0434 : XingQuery
	{
		/// <summary>
		/// t0434
		/// </summary>
		public const string _typeName = "t0434";
		/// <summary>
		/// 선물/옵션체결/미체결(t0434)
		/// </summary>
		public const string _typeDesc = "선물/옵션체결/미체결(t0434)";
		/// <summary>
		/// 
		/// </summary>
		public const string _service = "";
		/// <summary>
		/// D
		/// </summary>
		public const string _headType = "D";
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
		/// false
		/// </summary>
		public const bool _block = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		public const bool _signature = false;

		/// <summary>
		/// t0434
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 선물/옵션체결/미체결(t0434)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// D
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
		/// false
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
		/// 선물/옵션체결/미체결(t0434)
		/// </summary>
		public XQt0434() : base("t0434") { }


		public class XQAllOutBlocks
		{
			public XQt0434OutBlock OutBlock { get; internal set; }
			public XQt0434OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string accno = default,string passwd = default,string expcode = default,char chegb = default,char sortgb = default,string cts_ordno = default)
		{
			using (XQt0434 instance = new XQt0434())
			{
				instance.SetFieldData(XQt0434InBlock.BlockName, XQt0434InBlock.F.accno, 0, accno); // char 11
				instance.SetFieldData(XQt0434InBlock.BlockName, XQt0434InBlock.F.passwd, 0, passwd); // char 8
				instance.SetFieldData(XQt0434InBlock.BlockName, XQt0434InBlock.F.expcode, 0, expcode); // char 8
				instance.SetFieldData(XQt0434InBlock.BlockName, XQt0434InBlock.F.chegb, 0, chegb.ToString()); // char 1
				instance.SetFieldData(XQt0434InBlock.BlockName, XQt0434InBlock.F.sortgb, 0, sortgb.ToString()); // char 1
				instance.SetFieldData(XQt0434InBlock.BlockName, XQt0434InBlock.F.cts_ordno, 0, cts_ordno); // char 7

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string accno = default,string passwd = default,string expcode = default,char chegb = default,char sortgb = default,string cts_ordno = default */)
		{
			using (XQt0434 instance = new XQt0434())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt0434OutBlock" : $"XQt0434OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt0434OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt0434OutBlock1" : $"XQt0434OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt0434OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt0434InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "accno", 0, block.accno); // char 11
			_xaQuery.SetFieldData(block.GetBlockName(), "passwd", 0, block.passwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "expcode", 0, block.expcode); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "chegb", 0, block.chegb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "sortgb", 0, block.sortgb.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_ordno", 0, block.cts_ordno); // char 7

			return true;
		}

		public XQt0434OutBlock GetBlock()
		{
			XQt0434OutBlock instance = XQt0434OutBlock.FromQuery(this);
			return instance;

		}

		public XQt0434OutBlock1[] GetBlock1s()
		{
			XQt0434OutBlock1[] instance = XQt0434OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt0434OutBlock),
			typeof(XQt0434OutBlock1),

		};

	}

}
