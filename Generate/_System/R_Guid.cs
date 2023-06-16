
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Guid
	/// </summary>
    public partial class RGuid : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Guid);
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


		/// <summary>
		/// System.Guid Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid r_FEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RGuid RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(Type, "Empty");
				}
				return r_FEmpty;
			}
		}

		/// <summary>
		/// System.Int32 _a
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_a;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_a
		{
			get
			{
				if(r_F_a == null)
				{
					r_F_a = new(this, "_a");
				}
				return r_F_a;
			}
		}

		/// <summary>
		/// System.Int16 _b
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt16 r_F_b;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt16 RF_b
		{
			get
			{
				if(r_F_b == null)
				{
					r_F_b = new(this, "_b");
				}
				return r_F_b;
			}
		}

		/// <summary>
		/// System.Int16 _c
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt16 r_F_c;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt16 RF_c
		{
			get
			{
				if(r_F_c == null)
				{
					r_F_c = new(this, "_c");
				}
				return r_F_c;
			}
		}

		/// <summary>
		/// System.Byte _d
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_d;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_d
		{
			get
			{
				if(r_F_d == null)
				{
					r_F_d = new(this, "_d");
				}
				return r_F_d;
			}
		}

		/// <summary>
		/// System.Byte _e
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_e;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_e
		{
			get
			{
				if(r_F_e == null)
				{
					r_F_e = new(this, "_e");
				}
				return r_F_e;
			}
		}

		/// <summary>
		/// System.Byte _f
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_f;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_f
		{
			get
			{
				if(r_F_f == null)
				{
					r_F_f = new(this, "_f");
				}
				return r_F_f;
			}
		}

		/// <summary>
		/// System.Byte _g
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_g;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_g
		{
			get
			{
				if(r_F_g == null)
				{
					r_F_g = new(this, "_g");
				}
				return r_F_g;
			}
		}

		/// <summary>
		/// System.Byte _h
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_h;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_h
		{
			get
			{
				if(r_F_h == null)
				{
					r_F_h = new(this, "_h");
				}
				return r_F_h;
			}
		}

		/// <summary>
		/// System.Byte _i
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_i;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_i
		{
			get
			{
				if(r_F_i == null)
				{
					r_F_i = new(this, "_i");
				}
				return r_F_i;
			}
		}

		/// <summary>
		/// System.Byte _j
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_j;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_j
		{
			get
			{
				if(r_F_j == null)
				{
					r_F_j = new(this, "_j");
				}
				return r_F_j;
			}
		}

		/// <summary>
		/// System.Byte _k
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_F_k;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RF_k
		{
			get
			{
				if(r_F_k == null)
				{
					r_F_k = new(this, "_k");
				}
				return r_F_k;
			}
		}

		/// <summary>
		/// System.Guid NewGuid()
		/// </summary>
		protected static RMethod r_MNewGuid;
		public static RMethod RMNewGuid
		{
			get
			{
				if(r_MNewGuid == null)
				{
					r_MNewGuid = new(Type, "NewGuid", 0);
				}
				return r_MNewGuid;
			}
		}

		/// <summary>
		/// System.Guid Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(Type, "Parse", 0, typeof(System.String));
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// System.Guid Parse(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p_;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p_ = new(Type, "Parse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)));
				}
				return r_MParse_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Guid ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Guid;
		public static RMethod RMTryParse_String_Out_Guid
		{
			get
			{
				if(r_MTryParse_String_Out_Guid == null)
				{
					r_MTryParse_String_Out_Guid = new(Type, "TryParse", 0, typeof(System.String), typeof(System.Guid).MakeByRefType());
				}
				return r_MTryParse_String_Out_Guid;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Guid ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_Guid;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_Guid
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_Guid == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Guid = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Guid).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_Guid;
			}
		}

		/// <summary>
		/// System.Guid ParseExact(System.String, System.String)
		/// </summary>
		protected static RMethod r_MParseExact_String_String;
		public static RMethod RMParseExact_String_String
		{
			get
			{
				if(r_MParseExact_String_String == null)
				{
					r_MParseExact_String_String = new(Type, "ParseExact", 0, typeof(System.String), typeof(System.String));
				}
				return r_MParseExact_String_String;
			}
		}

		/// <summary>
		/// System.Guid ParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RMParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(Type, "ParseExact", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)));
				}
				return r_MParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.String, System.String, System.Guid ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_String_String_Out_Guid;
		public static RMethod RMTryParseExact_String_String_Out_Guid
		{
			get
			{
				if(r_MTryParseExact_String_String_Out_Guid == null)
				{
					r_MTryParseExact_String_String_Out_Guid = new(Type, "TryParseExact", 0, typeof(System.String), typeof(System.String), typeof(System.Guid).MakeByRefType());
				}
				return r_MTryParseExact_String_String_Out_Guid;
			}
		}

		/// <summary>
		/// Boolean TryParseExact(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Guid ByRef)
		/// </summary>
		protected static RMethod r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid;
		public static RMethod RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid
		{
			get
			{
				if(r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid == null)
				{
					r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid = new(Type, "TryParseExact", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Guid).MakeByRefType());
				}
				return r_MTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid;
			}
		}

		/// <summary>
		/// Boolean TryParseGuid(System.ReadOnlySpan`1[System.Char], GuidStyles, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult;
		public static RMethod RMTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult
		{
			get
			{
				if(r_MTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult == null)
				{
					r_MTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult = new(Type, "TryParseGuid", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.Guid+GuidStyles"),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean TryParseGuidWithHexPrefix(System.ReadOnlySpan`1[System.Char], GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult;
		public static RMethod RMTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult
		{
			get
			{
				if(r_MTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult == null)
				{
					r_MTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult = new(Type, "TryParseGuidWithHexPrefix", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean TryParseGuidWithNoStyle(System.ReadOnlySpan`1[System.Char], GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult;
		public static RMethod RMTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult
		{
			get
			{
				if(r_MTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult == null)
				{
					r_MTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult = new(Type, "TryParseGuidWithNoStyle", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean TryParseGuidWithDashes(System.ReadOnlySpan`1[System.Char], GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult;
		public static RMethod RMTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult
		{
			get
			{
				if(r_MTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult == null)
				{
					r_MTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult = new(Type, "TryParseGuidWithDashes", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToShort(System.ReadOnlySpan`1[System.Char], Int32, Int32, Int16 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult;
		public static RMethod RMStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult
		{
			get
			{
				if(r_MStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult == null)
				{
					r_MStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult = new(Type, "StringToShort", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int16).MakeByRefType(),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToShort(System.ReadOnlySpan`1[System.Char], Int32 ByRef, Int32, Int32, Int16 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult;
		public static RMethod RMStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult
		{
			get
			{
				if(r_MStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult == null)
				{
					r_MStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult = new(Type, "StringToShort", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int16).MakeByRefType(),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToInt(System.ReadOnlySpan`1[System.Char], Int32, Int32, Int32 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult;
		public static RMethod RMStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult
		{
			get
			{
				if(r_MStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult == null)
				{
					r_MStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult = new(Type, "StringToInt", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToInt(System.ReadOnlySpan`1[System.Char], Int32 ByRef, Int32, Int32, Int32 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult;
		public static RMethod RMStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult
		{
			get
			{
				if(r_MStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult == null)
				{
					r_MStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult = new(Type, "StringToInt", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult;
			}
		}

		/// <summary>
		/// Boolean StringToLong(System.ReadOnlySpan`1[System.Char], Int32 ByRef, Int32, Int64 ByRef, GuidResult ByRef)
		/// </summary>
		protected static RMethod r_MStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult;
		public static RMethod RMStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult
		{
			get
			{
				if(r_MStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult == null)
				{
					r_MStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult = new(Type, "StringToLong", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(), typeof(System.Int32), typeof(System.Int64).MakeByRefType(),  ReflectionUtils.GetType("System.Guid+GuidResult").MakeByRefType());
				}
				return r_MStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] EatAllWhitespace(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MEatAllWhitespace_ReadOnlySpan_d_Char_p_;
		public static RMethod RMEatAllWhitespace_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MEatAllWhitespace_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MEatAllWhitespace_ReadOnlySpan_d_Char_p_ = new(Type, "EatAllWhitespace", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)));
				}
				return r_MEatAllWhitespace_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean IsHexPrefix(System.ReadOnlySpan`1[System.Char], Int32)
		/// </summary>
		protected static RMethod r_MIsHexPrefix_ReadOnlySpan_d_Char_p__Int32;
		public static RMethod RMIsHexPrefix_ReadOnlySpan_d_Char_p__Int32
		{
			get
			{
				if(r_MIsHexPrefix_ReadOnlySpan_d_Char_p__Int32 == null)
				{
					r_MIsHexPrefix_ReadOnlySpan_d_Char_p__Int32 = new(Type, "IsHexPrefix", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32));
				}
				return r_MIsHexPrefix_ReadOnlySpan_d_Char_p__Int32;
			}
		}

		/// <summary>
		/// Void WriteByteHelper(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_MWriteByteHelper_Span_d_Byte_p_;
		public virtual RMethod RMWriteByteHelper_Span_d_Byte_p_
		{
			get
			{
				if(r_MWriteByteHelper_Span_d_Byte_p_ == null)
				{
					r_MWriteByteHelper_Span_d_Byte_p_ = new(this, "WriteByteHelper", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Byte)));
				}
				return r_MWriteByteHelper_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Byte[] ToByteArray()
		/// </summary>
		protected RMethod r_MToByteArray;
		public virtual RMethod RMToByteArray
		{
			get
			{
				if(r_MToByteArray == null)
				{
					r_MToByteArray = new(this, "ToByteArray", 0);
				}
				return r_MToByteArray;
			}
		}

		/// <summary>
		/// Boolean TryWriteBytes(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_MTryWriteBytes_Span_d_Byte_p_;
		public virtual RMethod RMTryWriteBytes_Span_d_Byte_p_
		{
			get
			{
				if(r_MTryWriteBytes_Span_d_Byte_p_ == null)
				{
					r_MTryWriteBytes_Span_d_Byte_p_ = new(this, "TryWriteBytes", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Byte)));
				}
				return r_MTryWriteBytes_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Guid)
		/// </summary>
		protected RMethod r_MEquals_Guid;
		public virtual RMethod RMEquals_Guid
		{
			get
			{
				if(r_MEquals_Guid == null)
				{
					r_MEquals_Guid = new(this, "Equals", 0, typeof(System.Guid));
				}
				return r_MEquals_Guid;
			}
		}

		/// <summary>
		/// Int32 GetResult(UInt32, UInt32)
		/// </summary>
		protected RMethod r_MGetResult_UInt32_UInt32;
		public virtual RMethod RMGetResult_UInt32_UInt32
		{
			get
			{
				if(r_MGetResult_UInt32_UInt32 == null)
				{
					r_MGetResult_UInt32_UInt32 = new(this, "GetResult", 0, typeof(System.UInt32), typeof(System.UInt32));
				}
				return r_MGetResult_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Guid)
		/// </summary>
		protected RMethod r_MCompareTo_Guid;
		public virtual RMethod RMCompareTo_Guid
		{
			get
			{
				if(r_MCompareTo_Guid == null)
				{
					r_MCompareTo_Guid = new(this, "CompareTo", 0, typeof(System.Guid));
				}
				return r_MCompareTo_Guid;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Guid, System.Guid)
		/// </summary>
		protected static RMethod r_Mop_Equality_Guid_Guid;
		public static RMethod RMop_Equality_Guid_Guid
		{
			get
			{
				if(r_Mop_Equality_Guid_Guid == null)
				{
					r_Mop_Equality_Guid_Guid = new(Type, "op_Equality", 0, typeof(System.Guid), typeof(System.Guid));
				}
				return r_Mop_Equality_Guid_Guid;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Guid, System.Guid)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Guid_Guid;
		public static RMethod RMop_Inequality_Guid_Guid
		{
			get
			{
				if(r_Mop_Inequality_Guid_Guid == null)
				{
					r_Mop_Inequality_Guid_Guid = new(Type, "op_Inequality", 0, typeof(System.Guid), typeof(System.Guid));
				}
				return r_Mop_Inequality_Guid_Guid;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// Char HexToChar(Int32)
		/// </summary>
		protected static RMethod r_MHexToChar_Int32;
		public static RMethod RMHexToChar_Int32
		{
			get
			{
				if(r_MHexToChar_Int32 == null)
				{
					r_MHexToChar_Int32 = new(Type, "HexToChar", 0, typeof(System.Int32));
				}
				return r_MHexToChar_Int32;
			}
		}

		/// <summary>
		/// Int32 HexsToChars(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_MHexsToChars_CharPointer_Int32_Int32;
		public static RMethod RMHexsToChars_CharPointer_Int32_Int32
		{
			get
			{
				if(r_MHexsToChars_CharPointer_Int32_Int32 == null)
				{
					r_MHexsToChars_CharPointer_Int32_Int32 = new(Type, "HexsToChars", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MHexsToChars_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 HexsToCharsHexOutput(Char*, Int32, Int32)
		/// </summary>
		protected static RMethod r_MHexsToCharsHexOutput_CharPointer_Int32_Int32;
		public static RMethod RMHexsToCharsHexOutput_CharPointer_Int32_Int32
		{
			get
			{
				if(r_MHexsToCharsHexOutput_CharPointer_Int32_Int32 == null)
				{
					r_MHexsToCharsHexOutput_CharPointer_Int32_Int32 = new(Type, "HexsToCharsHexOutput", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MHexsToCharsHexOutput_CharPointer_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_ = new(this, "TryFormat", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)));
				}
				return r_MTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean System.ISpanFormattable.TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RMSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "System.ISpanFormattable.TryFormat", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
				}
				return r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// Byte[] FastNewGuidArray()
		/// </summary>
		protected static RMethod r_MFastNewGuidArray;
		public static RMethod RMFastNewGuidArray
		{
			get
			{
				if(r_MFastNewGuidArray == null)
				{
					r_MFastNewGuidArray = new(Type, "FastNewGuidArray", 0);
				}
				return r_MFastNewGuidArray;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
				}
				return r_MMemberwiseClone;
			}
		}


        public static System.Guid NewGuid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNewGuid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public static System.Guid Parse(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public static System.Guid Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value};
            var ___result = RMParse_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public static System.Boolean TryParse(System.String @input, out System.Guid @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RMTryParse_String_Out_Guid.Invoke(___genericsType, ___parameters);
			@result = (System.Guid)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, out System.Guid @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_Guid.Invoke(___genericsType, ___parameters);
			@result = (System.Guid)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Guid ParseExact(System.String @input, System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format};
            var ___result = RMParseExact_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public static System.Guid ParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value};
            var ___result = RMParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public static System.Boolean TryParseExact(System.String @input, System.String @format, out System.Guid @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @format, @result};
            var ___result = RMTryParseExact_String_String_Out_Guid.Invoke(___genericsType, ___parameters);
			@result = (System.Guid)___parameters[2];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParseExact(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, out System.Guid @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @format.Value, @result};
            var ___result = RMTryParseExact_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Out_Guid.Invoke(___genericsType, ___parameters);
			@result = (System.Guid)___parameters[2];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParseGuid(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @guidString, Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles @flags, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@guidString.Value, @flags.Value, @result.Value};
            var ___result = RMTryParseGuid_ReadOnlySpan_d_Char_p__GuidStyles_Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParseGuidWithHexPrefix(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @guidString, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@guidString.Value, @result.Value};
            var ___result = RMTryParseGuidWithHexPrefix_ReadOnlySpan_d_Char_p__Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParseGuidWithNoStyle(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @guidString, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@guidString.Value, @result.Value};
            var ___result = RMTryParseGuidWithNoStyle_ReadOnlySpan_d_Char_p__Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParseGuidWithDashes(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @guidString, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@guidString.Value, @result.Value};
            var ___result = RMTryParseGuidWithDashes_ReadOnlySpan_d_Char_p__Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StringToShort(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str, System.Int32 @requiredLength, System.Int32 @flags, out System.Int16 @result, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @parseResult)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @requiredLength, @flags, @result, @parseResult.Value};
            var ___result = RMStringToShort_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int16_Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@result = (System.Int16)___parameters[3];
			@parseResult = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[4]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StringToShort(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str, ref System.Int32 @parsePos, System.Int32 @requiredLength, System.Int32 @flags, out System.Int16 @result, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @parseResult)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @parsePos, @requiredLength, @flags, @result, @parseResult.Value};
            var ___result = RMStringToShort_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int16_Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@parsePos = (System.Int32)___parameters[1];
			@result = (System.Int16)___parameters[4];
			@parseResult = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[5]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StringToInt(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str, System.Int32 @requiredLength, System.Int32 @flags, out System.Int32 @result, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @parseResult)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @requiredLength, @flags, @result, @parseResult.Value};
            var ___result = RMStringToInt_ReadOnlySpan_d_Char_p__Int32_Int32_Out_Int32_Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@result = (System.Int32)___parameters[3];
			@parseResult = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[4]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StringToInt(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str, ref System.Int32 @parsePos, System.Int32 @requiredLength, System.Int32 @flags, out System.Int32 @result, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @parseResult)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @parsePos, @requiredLength, @flags, @result, @parseResult.Value};
            var ___result = RMStringToInt_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Int32_Out_Int32_Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@parsePos = (System.Int32)___parameters[1];
			@result = (System.Int32)___parameters[4];
			@parseResult = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[5]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StringToLong(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str, ref System.Int32 @parsePos, System.Int32 @flags, out System.Int64 @result, ref Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult @parseResult)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @parsePos, @flags, @result, @parseResult.Value};
            var ___result = RMStringToLong_ReadOnlySpan_d_Char_p__Ref_Int32_Int32_Out_Int64_Ref_GuidResult.Invoke(___genericsType, ___parameters);
			@parsePos = (System.Int32)___parameters[1];
			@result = (System.Int64)___parameters[3];
			@parseResult = new Hvak.Editor.Refleaction.RSystem.RGuid.RGuidResult(___parameters[4]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> EatAllWhitespace(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value};
            var ___result = RMEatAllWhitespace_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>>(___result);
        }


        public static System.Boolean IsHexPrefix(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @str, System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str.Value, @i};
            var ___result = RMIsHexPrefix_ReadOnlySpan_d_Char_p__Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void WriteByteHelper(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value};
            var ___result = RMWriteByteHelper_Span_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] ToByteArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Boolean TryWriteBytes(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RByte> @destination)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value};
            var ___result = RMTryWriteBytes_Span_d_Byte_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Guid @g)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@g};
            var ___result = RMEquals_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetResult(System.UInt32 @me, System.UInt32 @them)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@me, @them};
            var ___result = RMGetResult_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(System.Guid @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.Guid @a, System.Guid @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_Guid_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Guid @a, System.Guid @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_Guid_Guid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Char HexToChar(System.Int32 @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMHexToChar_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Char>(___result);
        }


        public unsafe static System.Int32 HexsToChars(System.Char* @guidChars, System.Int32 @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@guidChars, typeof(System.Char)), @a, @b};
            var ___result = RMHexsToChars_CharPointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public unsafe static System.Int32 HexsToCharsHexOutput(System.Char* @guidChars, System.Int32 @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@guidChars, typeof(System.Char)), @a, @b};
            var ___result = RMHexsToCharsHexOutput_CharPointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean System__2__ISpanFormattable__2__TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RMSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = (System.Int32)___parameters[1];

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Byte[] FastNewGuidArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFastNewGuidArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
