﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1463InBlock : XingBlock
	{
		/// <summary>
		/// t1463InBlock
		/// </summary>
		public const string _blockName = "t1463InBlock";
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
		/// t1463InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1463InBlock
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
		/// 구분
		/// </summary>
		[XAQueryFieldAttribute("gubun", "구분", "char", "1")]
		public char gubun;
		/// <summary>
		/// 전일구분
		/// </summary>
		[XAQueryFieldAttribute("jnilgubun", "전일구분", "char", "1")]
		public char jnilgubun;
		/// <summary>
		/// 대상제외
		/// </summary>
		[XAQueryFieldAttribute("jc_num", "대상제외", "long", "12")]
		public long jc_num;
		/// <summary>
		/// 시작가격
		/// </summary>
		[XAQueryFieldAttribute("sprice", "시작가격", "long", "8")]
		public long sprice;
		/// <summary>
		/// 종료가격
		/// </summary>
		[XAQueryFieldAttribute("eprice", "종료가격", "long", "8")]
		public long eprice;
		/// <summary>
		/// 거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;
		/// <summary>
		/// 대상제외2
		/// </summary>
		[XAQueryFieldAttribute("jc_num2", "대상제외2", "long", "12")]
		public long jc_num2;

		public static class F
		{
			/// <summary>
			/// 구분
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 전일구분
			/// </summary>
			public const string jnilgubun = "jnilgubun";
			/// <summary>
			/// 대상제외
			/// </summary>
			public const string jc_num = "jc_num";
			/// <summary>
			/// 시작가격
			/// </summary>
			public const string sprice = "sprice";
			/// <summary>
			/// 종료가격
			/// </summary>
			public const string eprice = "eprice";
			/// <summary>
			/// 거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
			/// <summary>
			/// 대상제외2
			/// </summary>
			public const string jc_num2 = "jc_num2";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.jnilgubun,
			F.jc_num,
			F.sprice,
			F.eprice,
			F.volume,
			F.idx,
			F.jc_num2,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "구분", (decimal)1);
			dict["jnilgubun"] = new XAQueryFieldInfo("char", jnilgubun, jnilgubun.ToString(), "전일구분", (decimal)1);
			dict["jc_num"] = new XAQueryFieldInfo("long", jc_num, jc_num.ToString("d12"), "대상제외", (decimal)12);
			dict["sprice"] = new XAQueryFieldInfo("long", sprice, sprice.ToString("d8"), "시작가격", (decimal)8);
			dict["eprice"] = new XAQueryFieldInfo("long", eprice, eprice.ToString("d8"), "종료가격", (decimal)8);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "거래량", (decimal)12);
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);
			dict["jc_num2"] = new XAQueryFieldInfo("long", jc_num2, jc_num2.ToString("d12"), "대상제외2", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilgubun":
					this.jnilgubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jc_num":
					this.jc_num = fieldInfo.FieldValue.ParseLong("jc_num");
				break;

				case "sprice":
					this.sprice = fieldInfo.FieldValue.ParseLong("sprice");
				break;

				case "eprice":
					this.eprice = fieldInfo.FieldValue.ParseLong("eprice");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;

				case "jc_num2":
					this.jc_num2 = fieldInfo.FieldValue.ParseLong("jc_num2");
				break;


			}
		}

		public bool VerifyData()
		{
			// gubun char 1
			// jnilgubun char 1
			if (jc_num.ToString().Length > 12) return false; // long 12
			if (sprice.ToString().Length > 8) return false; // long 8
			if (eprice.ToString().Length > 8) return false; // long 8
			if (volume.ToString().Length > 12) return false; // long 12
			if (idx.ToString().Length > 4) return false; // long 4
			if (jc_num2.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt1463InBlock block)
		{
			block.gubun = this.gubun;
			block.jnilgubun = this.jnilgubun;
			block.jc_num = this.jc_num;
			block.sprice = this.sprice;
			block.eprice = this.eprice;
			block.volume = this.volume;
			block.idx = this.idx;
			block.jc_num2 = this.jc_num2;

		}
	}

	public partial class XQt1463OutBlock : XingBlock
	{
		/// <summary>
		/// t1463OutBlock
		/// </summary>
		public const string _blockName = "t1463OutBlock";
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
		/// t1463OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1463OutBlock
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
		/// IDX
		/// </summary>
		[XAQueryFieldAttribute("idx", "IDX", "long", "4")]
		public long idx;

		public static class F
		{
			/// <summary>
			/// IDX
			/// </summary>
			public const string idx = "idx";
		}

		public static string[] AllFields = new string[]
		{
			F.idx,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["idx"] = new XAQueryFieldInfo("long", idx, idx.ToString("d4"), "IDX", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "idx":
					this.idx = fieldInfo.FieldValue.ParseLong("idx");
				break;


			}
		}

		public static XQt1463OutBlock FromQuery(XQt1463 query)
		{
			XQt1463OutBlock block = new XQt1463OutBlock();
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
				block.idx = query.GetFieldData(block.GetBlockName(), "idx", 0).ParseLong("idx"); // long 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (idx.ToString().Length > 4) return false; // long 4

			return true;
		}

		public void CopyTo(XQt1463OutBlock block)
		{
			block.idx = this.idx;

		}
	}

	public partial class XQt1463OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1463OutBlock1
		/// </summary>
		public const string _blockName = "t1463OutBlock1";
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
		/// t1463OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1463OutBlock1
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
		/// 한글명
		/// </summary>
		[XAQueryFieldAttribute("hname", "한글명", "char", "20")]
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
		[XAQueryFieldAttribute("diff", "등락율", "float", "6.2")]
		public float diff;
		/// <summary>
		/// 누적거래량
		/// </summary>
		[XAQueryFieldAttribute("volume", "누적거래량", "long", "12")]
		public long volume;
		/// <summary>
		/// 거래대금
		/// </summary>
		[XAQueryFieldAttribute("value", "거래대금", "long", "12")]
		public long value;
		/// <summary>
		/// 전일거래대금
		/// </summary>
		[XAQueryFieldAttribute("jnilvalue", "전일거래대금", "long", "12")]
		public long jnilvalue;
		/// <summary>
		/// 전일비
		/// </summary>
		[XAQueryFieldAttribute("bef_diff", "전일비", "float", "10.2")]
		public float bef_diff;
		/// <summary>
		/// 종목코드
		/// </summary>
		[XAQueryFieldAttribute("shcode", "종목코드", "char", "6")]
		public string shcode;
		/// <summary>
		/// filler
		/// </summary>
		[XAQueryFieldAttribute("filler", "filler", "char", "1")]
		public char filler;
		/// <summary>
		/// 전일거래량
		/// </summary>
		[XAQueryFieldAttribute("jnilvolume", "전일거래량", "long", "12")]
		public long jnilvolume;

		public static class F
		{
			/// <summary>
			/// 한글명
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
			public const string diff = "diff";
			/// <summary>
			/// 누적거래량
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 거래대금
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 전일거래대금
			/// </summary>
			public const string jnilvalue = "jnilvalue";
			/// <summary>
			/// 전일비
			/// </summary>
			public const string bef_diff = "bef_diff";
			/// <summary>
			/// 종목코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// filler
			/// </summary>
			public const string filler = "filler";
			/// <summary>
			/// 전일거래량
			/// </summary>
			public const string jnilvolume = "jnilvolume";
		}

		public static string[] AllFields = new string[]
		{
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.volume,
			F.value,
			F.jnilvalue,
			F.bef_diff,
			F.shcode,
			F.filler,
			F.jnilvolume,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "한글명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "현재가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["volume"] = new XAQueryFieldInfo("long", volume, volume.ToString("d12"), "누적거래량", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("long", value, value.ToString("d12"), "거래대금", (decimal)12);
			dict["jnilvalue"] = new XAQueryFieldInfo("long", jnilvalue, jnilvalue.ToString("d12"), "전일거래대금", (decimal)12);
			dict["bef_diff"] = new XAQueryFieldInfo("float", bef_diff, bef_diff.ToString("0000000000.00"), "전일비", (decimal)10.2);
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "종목코드", (decimal)6);
			dict["filler"] = new XAQueryFieldInfo("char", filler, filler.ToString(), "filler", (decimal)1);
			dict["jnilvolume"] = new XAQueryFieldInfo("long", jnilvolume, jnilvolume.ToString("d12"), "전일거래량", (decimal)12);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
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

				case "diff":
					this.diff = fieldInfo.FieldValue.ParseFloat("diff");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.ParseLong("volume");
				break;

				case "value":
					this.value = fieldInfo.FieldValue.ParseLong("value");
				break;

				case "jnilvalue":
					this.jnilvalue = fieldInfo.FieldValue.ParseLong("jnilvalue");
				break;

				case "bef_diff":
					this.bef_diff = fieldInfo.FieldValue.ParseFloat("bef_diff");
				break;

				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "filler":
					this.filler = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "jnilvolume":
					this.jnilvolume = fieldInfo.FieldValue.ParseLong("jnilvolume");
				break;


			}
		}

		public static XQt1463OutBlock1[] ListFromQuery(XQt1463 query)
		{
			int count = query.GetBlockCount(XQt1463OutBlock1.BlockName);
			List<XQt1463OutBlock1> list = new List<XQt1463OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1463OutBlock1 block = new XQt1463OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).ParseLong("volume"); // long 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).ParseLong("value"); // long 12
					block.jnilvalue = query.GetFieldData(block.GetBlockName(), "jnilvalue", i).ParseLong("jnilvalue"); // long 12
					block.bef_diff = query.GetFieldData(block.GetBlockName(), "bef_diff", i).ParseFloat("bef_diff"); // float 10.2
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.filler = query.GetFieldData(block.GetBlockName(), "filler", i).FirstOrDefault(); // char 1
					block.jnilvolume = query.GetFieldData(block.GetBlockName(), "jnilvolume", i).ParseLong("jnilvolume"); // long 12

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
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (volume.ToString().Length > 12) return false; // long 12
			if (value.ToString().Length > 12) return false; // long 12
			if (jnilvalue.ToString().Length > 12) return false; // long 12
			// bef_diff float 10.2
			if (shcode?.Length > 6) return false; // char 6
			// filler char 1
			if (jnilvolume.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt1463OutBlock1 block)
		{
			block.hname = this.hname;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.volume = this.volume;
			block.value = this.value;
			block.jnilvalue = this.jnilvalue;
			block.bef_diff = this.bef_diff;
			block.shcode = this.shcode;
			block.filler = this.filler;
			block.jnilvolume = this.jnilvolume;

		}
	}

	/// <summary>
	/// 거래대금상위(t1463)
	/// </summary>
	public partial class XQt1463 : XingQuery
	{
		/// <summary>
		/// t1463
		/// </summary>
		public const string _typeName = "t1463";
		/// <summary>
		/// 거래대금상위(t1463)
		/// </summary>
		public const string _typeDesc = "거래대금상위(t1463)";
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
		/// t1463
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 거래대금상위(t1463)
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
		/// 거래대금상위(t1463)
		/// </summary>
		public XQt1463() : base("t1463") { }


		public class XQAllOutBlocks
		{
			public XQt1463OutBlock OutBlock { get; internal set; }
			public XQt1463OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(char gubun = default,char jnilgubun = default,long jc_num = default,long sprice = default,long eprice = default,long volume = default,long idx = default,long jc_num2 = default)
		{
			using (XQt1463 instance = new XQt1463())
			{
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.gubun, 0, gubun.ToString()); // char 1
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.jnilgubun, 0, jnilgubun.ToString()); // char 1
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.jc_num, 0, jc_num.ToString("d12")); // long 12
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.sprice, 0, sprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.eprice, 0, eprice.ToString("d8")); // long 8
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.volume, 0, volume.ToString("d12")); // long 12
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.idx, 0, idx.ToString("d4")); // long 4
				instance.SetFieldData(XQt1463InBlock.BlockName, XQt1463InBlock.F.jc_num2, 0, jc_num2.ToString("d12")); // long 12

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, char gubun = default,char jnilgubun = default,long jc_num = default,long sprice = default,long eprice = default,long volume = default,long idx = default,long jc_num2 = default */)
		{
			using (XQt1463 instance = new XQt1463())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1463OutBlock" : $"XQt1463OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1463OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1463OutBlock1" : $"XQt1463OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1463OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1463InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "gubun", 0, block.gubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jnilgubun", 0, block.jnilgubun.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "jc_num", 0, block.jc_num.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "sprice", 0, block.sprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "eprice", 0, block.eprice.ToString("d8")); // long 8
			_xaQuery.SetFieldData(block.GetBlockName(), "volume", 0, block.volume.ToString("d12")); // long 12
			_xaQuery.SetFieldData(block.GetBlockName(), "idx", 0, block.idx.ToString("d4")); // long 4
			_xaQuery.SetFieldData(block.GetBlockName(), "jc_num2", 0, block.jc_num2.ToString("d12")); // long 12

			return true;
		}

		public XQt1463OutBlock GetBlock()
		{
			XQt1463OutBlock instance = XQt1463OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1463OutBlock1[] GetBlock1s()
		{
			XQt1463OutBlock1[] instance = XQt1463OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1463OutBlock),
			typeof(XQt1463OutBlock1),

		};

	}

}
