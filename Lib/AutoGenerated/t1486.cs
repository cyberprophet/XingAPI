﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1486InBlock : XingBlock
	{
		/// <summary>
		/// t1486InBlock
		/// </summary>
		public const string _blockName = "t1486InBlock";
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
		/// t1486InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1486InBlock
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
		/// <summary>
		/// 시간CTS
		/// </summary>
		[XAQueryFieldAttribute("cts_time", "시간CTS", "char", "10")]
		public string cts_time;
		/// <summary>
		/// 조회건수
		/// </summary>
		[XAQueryFieldAttribute("cnt", "조회건수", "int", "4")]
		public int cnt;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 시간CTS
			/// </summary>
			public const string cts_time = "cts_time";
			/// <summary>
			/// 조회건수
			/// </summary>
			public const string cnt = "cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.cts_time,
			F.cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["cts_time"] = new XAQueryFieldInfo("char", cts_time, cts_time, "시간CTS", (decimal)10);
			dict["cnt"] = new XAQueryFieldInfo("int", cnt, cnt.ToString("d4"), "조회건수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cts_time":
					this.cts_time = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "cnt":
					this.cnt = fieldInfo.FieldValue.ParseInt("cnt");
				break;


			}
		}

		public bool VerifyData()
		{
			if (shcode?.Length > 6) return false; // char 6
			if (cts_time?.Length > 10) return false; // char 10
			// cnt int 4

			return true;
		}

		public void CopyTo(XQt1486InBlock block)
		{
			block.shcode = this.shcode;
			block.cts_time = this.cts_time;
			block.cnt = this.cnt;

		}
	}

	public partial class XQt1486OutBlock : XingBlock
	{
		/// <summary>
		/// t1486OutBlock
		/// </summary>
		public const string _blockName = "t1486OutBlock";
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
		/// t1486OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1486OutBlock
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
		[XAQueryFieldAttribute("cts_time", "시간CTS", "char", "10")]
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

		public static XQt1486OutBlock FromQuery(XQt1486 query)
		{
			XQt1486OutBlock block = new XQt1486OutBlock();
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

		public void CopyTo(XQt1486OutBlock block)
		{
			block.cts_time = this.cts_time;

		}
	}

	public partial class XQt1486OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1486OutBlock1
		/// </summary>
		public const string _blockName = "t1486OutBlock1";
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
		/// t1486OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1486OutBlock1
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
		[XAQueryFieldAttribute("chetime", "시간", "char", "8")]
		public string chetime;
		/// <summary>
		/// 예상체결가
		/// </summary>
		[XAQueryFieldAttribute("price", "예상체결가", "long", "8")]
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
		/// 예상체결량
		/// </summary>
		[XAQueryFieldAttribute("cvolume", "예상체결량", "long", "12")]
		public long cvolume;
		/// <summary>
		/// 매도호가
		/// </summary>
		[XAQueryFieldAttribute("offerho1", "매도호가", "long", "8")]
		public long offerho1;
		/// <summary>
		/// 매수호가
		/// </summary>
		[XAQueryFieldAttribute("bidho1", "매수호가", "long", "8")]
		public long bidho1;
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

		public static class F
		{
			/// <summary>
			/// 시간
			/// </summary>
			public const string chetime = "chetime";
			/// <summary>
			/// 예상체결가
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
			/// 예상체결량
			/// </summary>
			public const string cvolume = "cvolume";
			/// <summary>
			/// 매도호가
			/// </summary>
			public const string offerho1 = "offerho1";
			/// <summary>
			/// 매수호가
			/// </summary>
			public const string bidho1 = "bidho1";
			/// <summary>
			/// 매도잔량
			/// </summary>
			public const string offerrem1 = "offerrem1";
			/// <summary>
			/// 매수잔량
			/// </summary>
			public const string bidrem1 = "bidrem1";
		}

		public static string[] AllFields = new string[]
		{
			F.chetime,
			F.price,
			F.sign,
			F.change,
			F.diff,
			F.cvolume,
			F.offerho1,
			F.bidho1,
			F.offerrem1,
			F.bidrem1,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["chetime"] = new XAQueryFieldInfo("char", chetime, chetime, "시간", (decimal)8);
			dict["price"] = new XAQueryFieldInfo("long", price, price.ToString("d8"), "예상체결가", (decimal)8);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "전일대비구분", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("long", change, change.ToString("d8"), "전일대비", (decimal)8);
			dict["diff"] = new XAQueryFieldInfo("float", diff, diff.ToString("000000.00"), "등락율", (decimal)6.2);
			dict["cvolume"] = new XAQueryFieldInfo("long", cvolume, cvolume.ToString("d12"), "예상체결량", (decimal)12);
			dict["offerho1"] = new XAQueryFieldInfo("long", offerho1, offerho1.ToString("d8"), "매도호가", (decimal)8);
			dict["bidho1"] = new XAQueryFieldInfo("long", bidho1, bidho1.ToString("d8"), "매수호가", (decimal)8);
			dict["offerrem1"] = new XAQueryFieldInfo("long", offerrem1, offerrem1.ToString("d12"), "매도잔량", (decimal)12);
			dict["bidrem1"] = new XAQueryFieldInfo("long", bidrem1, bidrem1.ToString("d12"), "매수잔량", (decimal)12);

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

				case "offerho1":
					this.offerho1 = fieldInfo.FieldValue.ParseLong("offerho1");
				break;

				case "bidho1":
					this.bidho1 = fieldInfo.FieldValue.ParseLong("bidho1");
				break;

				case "offerrem1":
					this.offerrem1 = fieldInfo.FieldValue.ParseLong("offerrem1");
				break;

				case "bidrem1":
					this.bidrem1 = fieldInfo.FieldValue.ParseLong("bidrem1");
				break;


			}
		}

		public static XQt1486OutBlock1[] ListFromQuery(XQt1486 query)
		{
			int count = query.GetBlockCount(XQt1486OutBlock1.BlockName);
			List<XQt1486OutBlock1> list = new List<XQt1486OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1486OutBlock1 block = new XQt1486OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.chetime = query.GetFieldData(block.GetBlockName(), "chetime", i).TrimEnd('?'); // char 8
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).ParseLong("price"); // long 8
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).ParseLong("change"); // long 8
					block.diff = query.GetFieldData(block.GetBlockName(), "diff", i).ParseFloat("diff"); // float 6.2
					block.cvolume = query.GetFieldData(block.GetBlockName(), "cvolume", i).ParseLong("cvolume"); // long 12
					block.offerho1 = query.GetFieldData(block.GetBlockName(), "offerho1", i).ParseLong("offerho1"); // long 8
					block.bidho1 = query.GetFieldData(block.GetBlockName(), "bidho1", i).ParseLong("bidho1"); // long 8
					block.offerrem1 = query.GetFieldData(block.GetBlockName(), "offerrem1", i).ParseLong("offerrem1"); // long 12
					block.bidrem1 = query.GetFieldData(block.GetBlockName(), "bidrem1", i).ParseLong("bidrem1"); // long 12

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
			if (chetime?.Length > 8) return false; // char 8
			if (price.ToString().Length > 8) return false; // long 8
			// sign char 1
			if (change.ToString().Length > 8) return false; // long 8
			// diff float 6.2
			if (cvolume.ToString().Length > 12) return false; // long 12
			if (offerho1.ToString().Length > 8) return false; // long 8
			if (bidho1.ToString().Length > 8) return false; // long 8
			if (offerrem1.ToString().Length > 12) return false; // long 12
			if (bidrem1.ToString().Length > 12) return false; // long 12

			return true;
		}

		public void CopyTo(XQt1486OutBlock1 block)
		{
			block.chetime = this.chetime;
			block.price = this.price;
			block.sign = this.sign;
			block.change = this.change;
			block.diff = this.diff;
			block.cvolume = this.cvolume;
			block.offerho1 = this.offerho1;
			block.bidho1 = this.bidho1;
			block.offerrem1 = this.offerrem1;
			block.bidrem1 = this.bidrem1;

		}
	}

	/// <summary>
	/// 시간별예상체결가(t1486)
	/// </summary>
	public partial class XQt1486 : XingQuery
	{
		/// <summary>
		/// t1486
		/// </summary>
		public const string _typeName = "t1486";
		/// <summary>
		/// 시간별예상체결가(t1486)
		/// </summary>
		public const string _typeDesc = "시간별예상체결가(t1486)";
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
		/// t1486
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 시간별예상체결가(t1486)
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
		/// 시간별예상체결가(t1486)
		/// </summary>
		public XQt1486() : base("t1486") { }


		public class XQAllOutBlocks
		{
			public XQt1486OutBlock OutBlock { get; internal set; }
			public XQt1486OutBlock1[] OutBlock1 { get; internal set; }
		}

		public static XQAllOutBlocks Get(string shcode = default,string cts_time = default,int cnt = default)
		{
			using (XQt1486 instance = new XQt1486())
			{
				instance.SetFieldData(XQt1486InBlock.BlockName, XQt1486InBlock.F.shcode, 0, shcode); // char 6
				instance.SetFieldData(XQt1486InBlock.BlockName, XQt1486InBlock.F.cts_time, 0, cts_time); // char 10
				instance.SetFieldData(XQt1486InBlock.BlockName, XQt1486InBlock.F.cnt, 0, cnt.ToString("d4")); // int 4

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

		public static XQAllOutBlocks ReadFromDB(string tableNamePostfix = null /*, string shcode = default,string cts_time = default,int cnt = default */)
		{
			using (XQt1486 instance = new XQt1486())
			{

				XQAllOutBlocks results = new XQAllOutBlocks();

				string tableName = (tableNamePostfix == null) ? "XQt1486OutBlock" : $"XQt1486OutBlock_{tableNamePostfix}";
				QueryOption qo = new QueryOption(tableName);
				results.OutBlock = instance.Select<XQt1486OutBlock>(qo);

				tableName = (tableNamePostfix == null) ? "XQt1486OutBlock1" : $"XQt1486OutBlock1_{tableNamePostfix}";
				qo = new QueryOption(tableName);
				results.OutBlock1 = instance.SelectMany<XQt1486OutBlock1>(qo);
				return results;
			}
		}

		public bool SetBlock(XQt1486InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "shcode", 0, block.shcode); // char 6
			_xaQuery.SetFieldData(block.GetBlockName(), "cts_time", 0, block.cts_time); // char 10
			_xaQuery.SetFieldData(block.GetBlockName(), "cnt", 0, block.cnt.ToString("d4")); // int 4

			return true;
		}

		public XQt1486OutBlock GetBlock()
		{
			XQt1486OutBlock instance = XQt1486OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1486OutBlock1[] GetBlock1s()
		{
			XQt1486OutBlock1[] instance = XQt1486OutBlock1.ListFromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XQt1486OutBlock),
			typeof(XQt1486OutBlock1),

		};

	}

}
