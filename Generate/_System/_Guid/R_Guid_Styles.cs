
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{public partial class RGuid
{
	
	/// <summary>
	/// System.Guid+GuidStyles
	/// </summary>
    public partial class RGuidStyles : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FNone;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles AllowParenthesis
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FAllowParenthesis;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFAllowParenthesis
		{
			get
			{
				if(r_FAllowParenthesis == null)
				{
					r_FAllowParenthesis = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "AllowParenthesis");
				}
				return r_FAllowParenthesis;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles AllowBraces
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FAllowBraces;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFAllowBraces
		{
			get
			{
				if(r_FAllowBraces == null)
				{
					r_FAllowBraces = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "AllowBraces");
				}
				return r_FAllowBraces;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles AllowDashes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FAllowDashes;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFAllowDashes
		{
			get
			{
				if(r_FAllowDashes == null)
				{
					r_FAllowDashes = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "AllowDashes");
				}
				return r_FAllowDashes;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles AllowHexPrefix
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FAllowHexPrefix;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFAllowHexPrefix
		{
			get
			{
				if(r_FAllowHexPrefix == null)
				{
					r_FAllowHexPrefix = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "AllowHexPrefix");
				}
				return r_FAllowHexPrefix;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles RequireParenthesis
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FRequireParenthesis;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFRequireParenthesis
		{
			get
			{
				if(r_FRequireParenthesis == null)
				{
					r_FRequireParenthesis = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "RequireParenthesis");
				}
				return r_FRequireParenthesis;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles RequireBraces
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FRequireBraces;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFRequireBraces
		{
			get
			{
				if(r_FRequireBraces == null)
				{
					r_FRequireBraces = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "RequireBraces");
				}
				return r_FRequireBraces;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles RequireDashes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FRequireDashes;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFRequireDashes
		{
			get
			{
				if(r_FRequireDashes == null)
				{
					r_FRequireDashes = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "RequireDashes");
				}
				return r_FRequireDashes;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles RequireHexPrefix
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FRequireHexPrefix;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFRequireHexPrefix
		{
			get
			{
				if(r_FRequireHexPrefix == null)
				{
					r_FRequireHexPrefix = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "RequireHexPrefix");
				}
				return r_FRequireHexPrefix;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles HexFormat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FHexFormat;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFHexFormat
		{
			get
			{
				if(r_FHexFormat == null)
				{
					r_FHexFormat = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "HexFormat");
				}
				return r_FHexFormat;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles NumberFormat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FNumberFormat;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFNumberFormat
		{
			get
			{
				if(r_FNumberFormat == null)
				{
					r_FNumberFormat = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "NumberFormat");
				}
				return r_FNumberFormat;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles DigitFormat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FDigitFormat;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFDigitFormat
		{
			get
			{
				if(r_FDigitFormat == null)
				{
					r_FDigitFormat = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "DigitFormat");
				}
				return r_FDigitFormat;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles BraceFormat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FBraceFormat;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFBraceFormat
		{
			get
			{
				if(r_FBraceFormat == null)
				{
					r_FBraceFormat = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "BraceFormat");
				}
				return r_FBraceFormat;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles ParenthesisFormat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FParenthesisFormat;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFParenthesisFormat
		{
			get
			{
				if(r_FParenthesisFormat == null)
				{
					r_FParenthesisFormat = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "ParenthesisFormat");
				}
				return r_FParenthesisFormat;
			}
		}

		/// <summary>
		/// System.Guid+GuidStyles Any
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles r_FAny;
		public static Hvak.Editor.Refleaction.RSystem.RGuid.RGuidStyles RFAny
		{
			get
			{
				if(r_FAny == null)
				{
					r_FAny = new( ReflectionUtils.GetType("System.Guid+GuidStyles"), "Any");
				}
				return r_FAny;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public RGuidStyles() : base("System.Guid+GuidStyles")
        {
        }

        public RGuidStyles(System.Object instance) : base("System.Guid+GuidStyles")
		{
            SetInstance(instance);
		}

        public RGuidStyles(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGuidStyles(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}