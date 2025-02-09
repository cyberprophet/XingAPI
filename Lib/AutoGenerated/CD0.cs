﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XRCD0InBlock : XingBlock
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("futcode", "단축코드", "char", "8")]
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XRCD0InBlock block)
		{
			block.futcode = this.futcode;

		}
	}

	public partial class XRCD0OutBlock : XingBlock
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
		/// 접속매매여부
		/// </summary>
		[XAQueryFieldAttribute("gubun", "접속매매여부", "char", "1")]
		public char gubun;
		/// <summary>
		/// 실시간가격제한여부
		/// </summary>
		[XAQueryFieldAttribute("dy_gubun", "실시간가격제한여부", "char", "1")]
		public char dy_gubun;
		/// <summary>
		/// 실시간상한가
		/// </summary>
		[XAQueryFieldAttribute("dy_uplmtprice", "실시간상한가", "float", "8.2")]
		public float dy_uplmtprice;
		/// <summary>
		/// 실시간하한가
		/// </summary>
		[XAQueryFieldAttribute("dy_dnlmtprice", "실시간하한가", "float", "8.2")]
		public float dy_dnlmtprice;
		/// <summary>
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("futcode", "단축코드", "char", "8")]
		public string futcode;

		public static class F
		{
			/// <summary>
			/// 접속매매여부
			/// </summary>
			public const string gubun = "gubun";
			/// <summary>
			/// 실시간가격제한여부
			/// </summary>
			public const string dy_gubun = "dy_gubun";
			/// <summary>
			/// 실시간상한가
			/// </summary>
			public const string dy_uplmtprice = "dy_uplmtprice";
			/// <summary>
			/// 실시간하한가
			/// </summary>
			public const string dy_dnlmtprice = "dy_dnlmtprice";
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string futcode = "futcode";
		}

		public static string[] AllFields = new string[]
		{
			F.gubun,
			F.dy_gubun,
			F.dy_uplmtprice,
			F.dy_dnlmtprice,
			F.futcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["gubun"] = new XAQueryFieldInfo("char", gubun, gubun.ToString(), "접속매매여부", (decimal)1);
			dict["dy_gubun"] = new XAQueryFieldInfo("char", dy_gubun, dy_gubun.ToString(), "실시간가격제한여부", (decimal)1);
			dict["dy_uplmtprice"] = new XAQueryFieldInfo("float", dy_uplmtprice, dy_uplmtprice.ToString("00000000.00"), "실시간상한가", (decimal)8.2);
			dict["dy_dnlmtprice"] = new XAQueryFieldInfo("float", dy_dnlmtprice, dy_dnlmtprice.ToString("00000000.00"), "실시간하한가", (decimal)8.2);
			dict["futcode"] = new XAQueryFieldInfo("char", futcode, futcode, "단축코드", (decimal)8);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "gubun":
					this.gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dy_gubun":
					this.dy_gubun = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "dy_uplmtprice":
					this.dy_uplmtprice = fieldInfo.FieldValue.ParseFloat("dy_uplmtprice");
				break;

				case "dy_dnlmtprice":
					this.dy_dnlmtprice = fieldInfo.FieldValue.ParseFloat("dy_dnlmtprice");
				break;

				case "futcode":
					this.futcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XRCD0OutBlock FromQuery(XRCD0 query)
		{
			XRCD0OutBlock block = new XRCD0OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			try
			{
				block.gubun = query.GetFieldData(block.GetBlockName(), "gubun").FirstOrDefault(); // char 1
				block.dy_gubun = query.GetFieldData(block.GetBlockName(), "dy_gubun").FirstOrDefault(); // char 1
				block.dy_uplmtprice = query.GetFieldData(block.GetBlockName(), "dy_uplmtprice").ParseFloat("dy_uplmtprice"); // float 8.2
				block.dy_dnlmtprice = query.GetFieldData(block.GetBlockName(), "dy_dnlmtprice").ParseFloat("dy_dnlmtprice"); // float 8.2
				block.futcode = query.GetFieldData(block.GetBlockName(), "futcode").TrimEnd('?'); // char 8

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			// gubun char 1
			// dy_gubun char 1
			// dy_uplmtprice float 8.2
			// dy_dnlmtprice float 8.2
			if (futcode?.Length > 8) return false; // char 8

			return true;
		}

		public void CopyTo(XRCD0OutBlock block)
		{
			block.gubun = this.gubun;
			block.dy_gubun = this.dy_gubun;
			block.dy_uplmtprice = this.dy_uplmtprice;
			block.dy_dnlmtprice = this.dy_dnlmtprice;
			block.futcode = this.futcode;

		}
	}

	/// <summary>
	/// 상품선물실시간상하한가(D0)
	/// </summary>
	public partial class XRCD0 : XingReal
	{
		/// <summary>
		/// CD0
		/// </summary>
		public const string _typeName = "CD0";
		/// <summary>
		/// 상품선물실시간상하한가(D0)
		/// </summary>
		public const string _typeDesc = "상품선물실시간상하한가(D0)";
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
		/// CD0
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 상품선물실시간상하한가(D0)
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
		/// 상품선물실시간상하한가(D0)
		/// </summary>
		public XRCD0() : base("CD0") { }


		public bool SetBlock(XRCD0InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaReal.SetFieldData(block.GetBlockName(), "futcode", block.futcode); // char 8

			return true;
		}

		public XRCD0OutBlock GetBlock()
		{
			XRCD0OutBlock instance = XRCD0OutBlock.FromQuery(this);
			return instance;

		}

		public static Type [] OutBlockTypes = new Type []
		{
			typeof(XRCD0OutBlock),

		};

	}

}
