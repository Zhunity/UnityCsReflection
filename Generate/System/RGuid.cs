using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Guid
	/// </summary>
    public partial class RGuid : RMember //
    {

		/// <summary>
		/// System.Guid Empty
		/// </summary>
		protected static RSystem.RGuid r_Empty;
		public static RSystem.RGuid REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.Guid), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// System.Int32 _a
		/// </summary>
		protected RField r__a;
		public virtual RField R_a
		{
			get
			{
				if(r__a == null)
				{
					r__a = new(this, "_a");
					r__a.SetBelong(this.instance);
				}
				return r__a;
			}
		}

		/// <summary>
		/// System.Int16 _b
		/// </summary>
		protected RField r__b;
		public virtual RField R_b
		{
			get
			{
				if(r__b == null)
				{
					r__b = new(this, "_b");
					r__b.SetBelong(this.instance);
				}
				return r__b;
			}
		}

		/// <summary>
		/// System.Int16 _c
		/// </summary>
		protected RField r__c;
		public virtual RField R_c
		{
			get
			{
				if(r__c == null)
				{
					r__c = new(this, "_c");
					r__c.SetBelong(this.instance);
				}
				return r__c;
			}
		}

		/// <summary>
		/// System.Byte _d
		/// </summary>
		protected RField r__d;
		public virtual RField R_d
		{
			get
			{
				if(r__d == null)
				{
					r__d = new(this, "_d");
					r__d.SetBelong(this.instance);
				}
				return r__d;
			}
		}

		/// <summary>
		/// System.Byte _e
		/// </summary>
		protected RField r__e;
		public virtual RField R_e
		{
			get
			{
				if(r__e == null)
				{
					r__e = new(this, "_e");
					r__e.SetBelong(this.instance);
				}
				return r__e;
			}
		}

		/// <summary>
		/// System.Byte _f
		/// </summary>
		protected RField r__f;
		public virtual RField R_f
		{
			get
			{
				if(r__f == null)
				{
					r__f = new(this, "_f");
					r__f.SetBelong(this.instance);
				}
				return r__f;
			}
		}

		/// <summary>
		/// System.Byte _g
		/// </summary>
		protected RField r__g;
		public virtual RField R_g
		{
			get
			{
				if(r__g == null)
				{
					r__g = new(this, "_g");
					r__g.SetBelong(this.instance);
				}
				return r__g;
			}
		}

		/// <summary>
		/// System.Byte _h
		/// </summary>
		protected RField r__h;
		public virtual RField R_h
		{
			get
			{
				if(r__h == null)
				{
					r__h = new(this, "_h");
					r__h.SetBelong(this.instance);
				}
				return r__h;
			}
		}

		/// <summary>
		/// System.Byte _i
		/// </summary>
		protected RField r__i;
		public virtual RField R_i
		{
			get
			{
				if(r__i == null)
				{
					r__i = new(this, "_i");
					r__i.SetBelong(this.instance);
				}
				return r__i;
			}
		}

		/// <summary>
		/// System.Byte _j
		/// </summary>
		protected RField r__j;
		public virtual RField R_j
		{
			get
			{
				if(r__j == null)
				{
					r__j = new(this, "_j");
					r__j.SetBelong(this.instance);
				}
				return r__j;
			}
		}

		/// <summary>
		/// System.Byte _k
		/// </summary>
		protected RField r__k;
		public virtual RField R_k
		{
			get
			{
				if(r__k == null)
				{
					r__k = new(this, "_k");
					r__k.SetBelong(this.instance);
				}
				return r__k;
			}
		}

		/// <summary>
		/// System.Guid NewGuid()
		/// </summary>
		protected static RMethod r_NewGuid;
		public static RMethod RNewGuid
		{
			get
			{
				if(r_NewGuid == null)
				{
					r_NewGuid = new(typeof(System.Guid), "NewGuid", 0);
					r_NewGuid.SetBelong(null);
				}
				return r_NewGuid;
			}
		}

		/// <summary>
		/// System.Guid Parse(System.String)
		/// </summary>
		protected static RMethod r_Parse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(typeof(System.Guid), "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(null);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// System.Guid Parse(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_Parse_ReadOnlySpan_d_Char_p_;
		public static RMethod RParse_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_Parse_ReadOnlySpan_d_Char_p_ == null)
				{
					r_Parse_ReadOnlySpan_d_Char_p_ = new(typeof(System.Guid), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_Parse_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_Parse_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Guid ByRef)
		/// </summary>
		protected static RMethod r_TryParse_String_Out_Guid;
		public static RMethod RTryParse_String_Out_Guid
		{
			get
			{
				if(r_TryParse_String_Out_Guid == null)
				{
					r_TryParse_String_Out_Guid = new(typeof(System.Guid), "TryParse", 0, typeof(System.String), typeof(System.Guid).MakeByRefType());
					r_TryParse_String_Out_Guid.SetBelong(null);
				}
				return r_TryParse_String_Out_Guid;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Guid ByRef)
		/// </summary>
		protected static RMethod r_TryParse_ReadOnlySpan_d_Char_p__Out_Guid;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_Guid
		{
			get
			{
				if(r_TryParse_ReadOnlySpan_d_Char_p__Out_Guid == null)
				{
					r_TryParse_ReadOnlySpan_d_Char_p__Out_Guid = new(typeof(System.Guid), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Guid).MakeByRefType());
					r_TryParse_ReadOnlySpan_d_Char_p__Out_Guid.SetBelong(null);
				}
				return r_TryParse_ReadOnlySpan_d_Char_p__Out_Guid;
			}
		}

		/// <summary>
		/// System.Guid ParseExact(System.String, System.String)
		/// </summary>
		protected static RMethod r_ParseExact_String_String;
		public static RMethod RParseExact_String_String
		{
			get
			{
				if(r_ParseExact_String_String == null)
				{
					r_ParseExact_String_String = new(typeof(System.Guid), "ParseExact", 0, typeof(System.String), typeof(System.String));
					r_ParseExact_String_String.SetBelong(null);
				}
				return r_ParseExact_String_String;
			}
		}

		/// <summary>
		/// System.Guid ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(typeof(System.Guid), "ParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_ParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.Guid ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_String_String_Out_Guid;
		public static RMethod RTryParseExact_String_String_Out_Guid
		{
			get
			{
				if(r_TryParseExact_String_String_Out_Guid == null)
				{
					r_TryParseExact_String_String_Out_Guid = new(typeof(System.Guid), "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.Guid).MakeByRefType());
					r_TryParseExact_String_String_Out_Guid.SetBelong(null);
				}
				return r_TryParseExact_String_String_Out_Guid;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Guid ByRef)
		/// </summary>
		protected static RMethod r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid;
		public static RMethod RTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid
		{
			get
			{
				if(r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid == null)
				{
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid = new(typeof(System.Guid), "TryParseExact", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Guid).MakeByRefType());
					r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid.SetBelong(null);
				}
				return r_TryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid;
			}
		}

		/// <summary>
		/// Boolean TryParseGuid(System.ReadOnlySpan`1[System.Char], GuidStyles, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_TryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult;
		public static RMethod RTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult
		{
			get
			{
				if(r_TryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult == null)
				{
					r_TryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult = new(typeof(System.Guid), "TryParseGuid", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)),  ReleactionUtils.GetType("System.Guid+GuidStyles"),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_TryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult.SetBelong(null);
				}
				return r_TryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean TryParseGuidWithHexPrefix(System.ReadOnlySpan`1[System.Char], GuidResult ByRef)
		/// </summary>
		protected static RMethod r_TryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult;
		public static RMethod RTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult
		{
			get
			{
				if(r_TryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult == null)
				{
					r_TryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult = new(typeof(System.Guid), "TryParseGuidWithHexPrefix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_TryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult.SetBelong(null);
				}
				return r_TryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean TryParseGuidWithNoStyle(System.ReadOnlySpan`1[System.Char], GuidResult ByRef)
		/// </summary>
		protected static RMethod r_TryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult;
		public static RMethod RTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult
		{
			get
			{
				if(r_TryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult == null)
				{
					r_TryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult = new(typeof(System.Guid), "TryParseGuidWithNoStyle", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_TryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult.SetBelong(null);
				}
				return r_TryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean TryParseGuidWithDashes(System.ReadOnlySpan`1[System.Char], GuidResult ByRef)
		/// </summary>
		protected static RMethod r_TryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult;
		public static RMethod RTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult
		{
			get
			{
				if(r_TryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult == null)
				{
					r_TryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult = new(typeof(System.Guid), "TryParseGuidWithDashes", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_TryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult.SetBelong(null);
				}
				return r_TryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToShort(System.ReadOnlySpan`1[System.Char], Int32, Int32, Int16 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_StringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult;
		public static RMethod RStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult
		{
			get
			{
				if(r_StringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult == null)
				{
					r_StringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult = new(typeof(System.Guid), "StringToShort", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int16).MakeByRefType(),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_StringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult.SetBelong(null);
				}
				return r_StringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToShort(System.ReadOnlySpan`1[System.Char], Int32 ByRef, Int32, Int32, Int16 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_StringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult;
		public static RMethod RStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult
		{
			get
			{
				if(r_StringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult == null)
				{
					r_StringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult = new(typeof(System.Guid), "StringToShort", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int16).MakeByRefType(),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_StringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult.SetBelong(null);
				}
				return r_StringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToInt(System.ReadOnlySpan`1[System.Char], Int32, Int32, Int32 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_StringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult;
		public static RMethod RStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult
		{
			get
			{
				if(r_StringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult == null)
				{
					r_StringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult = new(typeof(System.Guid), "StringToInt", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType(),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_StringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult.SetBelong(null);
				}
				return r_StringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToInt(System.ReadOnlySpan`1[System.Char], Int32 ByRef, Int32, Int32, Int32 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_StringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult;
		public static RMethod RStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult
		{
			get
			{
				if(r_StringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult == null)
				{
					r_StringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult = new(typeof(System.Guid), "StringToInt", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType(),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_StringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult.SetBelong(null);
				}
				return r_StringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToLong(System.ReadOnlySpan`1[System.Char], Int32 ByRef, Int32, Int64 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_StringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult;
		public static RMethod RStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult
		{
			get
			{
				if(r_StringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult == null)
				{
					r_StringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult = new(typeof(System.Guid), "StringToLong", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.Int64).MakeByRefType(),  ReleactionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
					r_StringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult.SetBelong(null);
				}
				return r_StringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] EatAllWhitespace(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_EatAllWhitespace_ReadOnlySpan_d_Char_p_;
		public static RMethod REatAllWhitespace_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_EatAllWhitespace_ReadOnlySpan_d_Char_p_ == null)
				{
					r_EatAllWhitespace_ReadOnlySpan_d_Char_p_ = new(typeof(System.Guid), "EatAllWhitespace", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_EatAllWhitespace_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_EatAllWhitespace_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean IsHexPrefix(System.ReadOnlySpan`1[System.Char], Int32)
		/// </summary>
		protected static RMethod r_IsHexPrefix_ReadOnlySpan_d_Char_p__Int32;
		public static RMethod RIsHexPrefix_ReadOnlySpan_d_Char_p__Int32
		{
			get
			{
				if(r_IsHexPrefix_ReadOnlySpan_d_Char_p__Int32 == null)
				{
					r_IsHexPrefix_ReadOnlySpan_d_Char_p__Int32 = new(typeof(System.Guid), "IsHexPrefix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32));
					r_IsHexPrefix_ReadOnlySpan_d_Char_p__Int32.SetBelong(null);
				}
				return r_IsHexPrefix_ReadOnlySpan_d_Char_p__Int32;
			}
		}

		/// <summary>
		/// Void WriteByteHelper(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_WriteByteHelper_Span_d_Byte_p_;
		public virtual RMethod RWriteByteHelper_Span_d_Byte_p_
		{
			get
			{
				if(r_WriteByteHelper_Span_d_Byte_p_ == null)
				{
					r_WriteByteHelper_Span_d_Byte_p_ = new(this, "WriteByteHelper", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_WriteByteHelper_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_WriteByteHelper_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Byte[] ToByteArray()
		/// </summary>
		protected RMethod r_ToByteArray;
		public virtual RMethod RToByteArray
		{
			get
			{
				if(r_ToByteArray == null)
				{
					r_ToByteArray = new(this, "ToByteArray", 0);
					r_ToByteArray.SetBelong(this.instance);
				}
				return r_ToByteArray;
			}
		}

		/// <summary>
		/// Boolean TryWriteBytes(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_TryWriteBytes_Span_d_Byte_p_;
		public virtual RMethod RTryWriteBytes_Span_d_Byte_p_
		{
			get
			{
				if(r_TryWriteBytes_Span_d_Byte_p_ == null)
				{
					r_TryWriteBytes_Span_d_Byte_p_ = new(this, "TryWriteBytes", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_TryWriteBytes_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_TryWriteBytes_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Guid)
		/// </summary>
		protected RMethod r_Equals_Guid;
		public virtual RMethod REquals_Guid
		{
			get
			{
				if(r_Equals_Guid == null)
				{
					r_Equals_Guid = new(this, "Equals", 0, typeof(System.Guid));
					r_Equals_Guid.SetBelong(this.instance);
				}
				return r_Equals_Guid;
			}
		}

		/// <summary>
		/// Int32 GetResult(UInt32, UInt32)
		/// </summary>
		protected RMethod r_GetResult_UInt32_UInt32;
		public virtual RMethod RGetResult_UInt32_UInt32
		{
			get
			{
				if(r_GetResult_UInt32_UInt32 == null)
				{
					r_GetResult_UInt32_UInt32 = new(this, "GetResult", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_GetResult_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_GetResult_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_CompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_CompareTo_Object == null)
				{
					r_CompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_CompareTo_Object.SetBelong(this.instance);
				}
				return r_CompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Guid)
		/// </summary>
		protected RMethod r_CompareTo_Guid;
		public virtual RMethod RCompareTo_Guid
		{
			get
			{
				if(r_CompareTo_Guid == null)
				{
					r_CompareTo_Guid = new(this, "CompareTo", 0, typeof(System.Guid));
					r_CompareTo_Guid.SetBelong(this.instance);
				}
				return r_CompareTo_Guid;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Guid, System.Guid)
		/// </summary>
		protected static RMethod r_op_Equality_Guid_Guid;
		public static RMethod Rop_Equality_Guid_Guid
		{
			get
			{
				if(r_op_Equality_Guid_Guid == null)
				{
					r_op_Equality_Guid_Guid = new(typeof(System.Guid), "op_Equality", 0, typeof(System.Guid), typeof(System.Guid));
					r_op_Equality_Guid_Guid.SetBelong(null);
				}
				return r_op_Equality_Guid_Guid;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Guid, System.Guid)
		/// </summary>
		protected static RMethod r_op_Inequality_Guid_Guid;
		public static RMethod Rop_Inequality_Guid_Guid
		{
			get
			{
				if(r_op_Inequality_Guid_Guid == null)
				{
					r_op_Inequality_Guid_Guid = new(typeof(System.Guid), "op_Inequality", 0, typeof(System.Guid), typeof(System.Guid));
					r_op_Inequality_Guid_Guid.SetBelong(null);
				}
				return r_op_Inequality_Guid_Guid;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_ToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_ToString_String == null)
				{
					r_ToString_String = new(this, "ToString", 0, typeof(System.String));
					r_ToString_String.SetBelong(this.instance);
				}
				return r_ToString_String;
			}
		}

		/// <summary>
		/// Char HexToChar(Int32)
		/// </summary>
		protected static RMethod r_HexToChar_Int32;
		public static RMethod RHexToChar_Int32
		{
			get
			{
				if(r_HexToChar_Int32 == null)
				{
					r_HexToChar_Int32 = new(typeof(System.Guid), "HexToChar", 0, typeof(System.Int32));
					r_HexToChar_Int32.SetBelong(null);
				}
				return r_HexToChar_Int32;
			}
		}

		/// <summary>
		/// Int32 HexsToChars(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_HexsToChars_CharPointer_Int32_Int32;
		public static RMethod RHexsToChars_CharPointer_Int32_Int32
		{
			get
			{
				if(r_HexsToChars_CharPointer_Int32_Int32 == null)
				{
					r_HexsToChars_CharPointer_Int32_Int32 = new(typeof(System.Guid), "HexsToChars", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_HexsToChars_CharPointer_Int32_Int32.SetBelong(null);
				}
				return r_HexsToChars_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 HexsToCharsHexOutput(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_HexsToCharsHexOutput_CharPointer_Int32_Int32;
		public static RMethod RHexsToCharsHexOutput_CharPointer_Int32_Int32
		{
			get
			{
				if(r_HexsToCharsHexOutput_CharPointer_Int32_Int32 == null)
				{
					r_HexsToCharsHexOutput_CharPointer_Int32_Int32 = new(typeof(System.Guid), "HexsToCharsHexOutput", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_HexsToCharsHexOutput_CharPointer_Int32_Int32.SetBelong(null);
				}
				return r_HexsToCharsHexOutput_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_ToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_ToString_String_IFormatProvider == null)
				{
					r_ToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_ToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_ToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_ == null)
				{
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_ = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean System.ISpanFormattable.TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_System__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_System__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_System__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "System.ISpanFormattable.TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
					r_System__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.SetBelong(this.instance);
				}
				return r_System__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// Byte[] FastNewGuidArray()
		/// </summary>
		protected static RMethod r_FastNewGuidArray;
		public static RMethod RFastNewGuidArray
		{
			get
			{
				if(r_FastNewGuidArray == null)
				{
					r_FastNewGuidArray = new(typeof(System.Guid), "FastNewGuidArray", 0);
					r_FastNewGuidArray.SetBelong(null);
				}
				return r_FastNewGuidArray;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RGuid() : base("System.Guid")
        {
        }

        public RGuid(System.Object instance) : base("System.Guid")
		{
            SetInstance(instance);
		}

        public RGuid(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGuid(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Guid NewGuid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNewGuid.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public static System.Guid Parse(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }



        public static System.Boolean TryParse(System.String  @input, out System.Guid  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RTryParse_String_Out_Guid.Invoke(___genericsType, ___parameters);
			result = (System.Guid)___parameters[1];

            return (System.Boolean)___result;
        }



        public static System.Guid ParseExact(System.String  @input, System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format};
            var ___result = RParseExact_String_String.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }



        public static System.Boolean TryParseExact(System.String  @input, System.String  @format, out System.Guid  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @result};
            var ___result = RTryParseExact_String_String_Out_Guid.Invoke(___genericsType, ___parameters);
			result = (System.Guid)___parameters[2];

            return (System.Boolean)___result;
        }















        public virtual System.Byte[] ToByteArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToByteArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }



        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Guid  @g)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@g};
            var ___result = REquals_Guid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetResult(System.UInt32  @me, System.UInt32  @them)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@me, @them};
            var ___result = RGetResult_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareTo(System.Guid  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCompareTo_Guid.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Guid  @a, System.Guid  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Guid  @a, System.Guid  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Char HexToChar(System.Int32  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RHexToChar_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }




        public virtual System.String ToString(System.String  @format, System.IFormatProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }




        public static System.Byte[] FastNewGuidArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFastNewGuidArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
