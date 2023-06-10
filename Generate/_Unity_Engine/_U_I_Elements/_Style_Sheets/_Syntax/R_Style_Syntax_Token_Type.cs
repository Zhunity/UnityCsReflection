
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType
	/// </summary>
    public partial class RStyleSyntaxTokenType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType");
            }
        }

        public RStyleSyntaxTokenType() : base("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType")
        {
        }

        public RStyleSyntaxTokenType(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType")
		{
            SetInstance(instance);
		}

        public RStyleSyntaxTokenType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleSyntaxTokenType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FUnknown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFUnknown
		{
			get
			{
				if(r_FUnknown == null)
				{
					r_FUnknown = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "Unknown");
				}
				return r_FUnknown;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType String
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FString;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFString
		{
			get
			{
				if(r_FString == null)
				{
					r_FString = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "String");
				}
				return r_FString;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Number
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FNumber;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFNumber
		{
			get
			{
				if(r_FNumber == null)
				{
					r_FNumber = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "Number");
				}
				return r_FNumber;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Space
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FSpace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFSpace
		{
			get
			{
				if(r_FSpace == null)
				{
					r_FSpace = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "Space");
				}
				return r_FSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType SingleBar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FSingleBar;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFSingleBar
		{
			get
			{
				if(r_FSingleBar == null)
				{
					r_FSingleBar = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "SingleBar");
				}
				return r_FSingleBar;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType DoubleBar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FDoubleBar;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFDoubleBar
		{
			get
			{
				if(r_FDoubleBar == null)
				{
					r_FDoubleBar = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "DoubleBar");
				}
				return r_FDoubleBar;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType DoubleAmpersand
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FDoubleAmpersand;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFDoubleAmpersand
		{
			get
			{
				if(r_FDoubleAmpersand == null)
				{
					r_FDoubleAmpersand = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "DoubleAmpersand");
				}
				return r_FDoubleAmpersand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Comma
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FComma;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFComma
		{
			get
			{
				if(r_FComma == null)
				{
					r_FComma = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "Comma");
				}
				return r_FComma;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType SingleQuote
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FSingleQuote;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFSingleQuote
		{
			get
			{
				if(r_FSingleQuote == null)
				{
					r_FSingleQuote = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "SingleQuote");
				}
				return r_FSingleQuote;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Asterisk
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FAsterisk;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFAsterisk
		{
			get
			{
				if(r_FAsterisk == null)
				{
					r_FAsterisk = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "Asterisk");
				}
				return r_FAsterisk;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Plus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FPlus;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFPlus
		{
			get
			{
				if(r_FPlus == null)
				{
					r_FPlus = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "Plus");
				}
				return r_FPlus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType QuestionMark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FQuestionMark;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFQuestionMark
		{
			get
			{
				if(r_FQuestionMark == null)
				{
					r_FQuestionMark = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "QuestionMark");
				}
				return r_FQuestionMark;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType HashMark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FHashMark;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFHashMark
		{
			get
			{
				if(r_FHashMark == null)
				{
					r_FHashMark = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "HashMark");
				}
				return r_FHashMark;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType ExclamationPoint
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FExclamationPoint;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFExclamationPoint
		{
			get
			{
				if(r_FExclamationPoint == null)
				{
					r_FExclamationPoint = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "ExclamationPoint");
				}
				return r_FExclamationPoint;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType OpenBracket
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FOpenBracket;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFOpenBracket
		{
			get
			{
				if(r_FOpenBracket == null)
				{
					r_FOpenBracket = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "OpenBracket");
				}
				return r_FOpenBracket;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType CloseBracket
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FCloseBracket;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFCloseBracket
		{
			get
			{
				if(r_FCloseBracket == null)
				{
					r_FCloseBracket = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "CloseBracket");
				}
				return r_FCloseBracket;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType OpenBrace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FOpenBrace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFOpenBrace
		{
			get
			{
				if(r_FOpenBrace == null)
				{
					r_FOpenBrace = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "OpenBrace");
				}
				return r_FOpenBrace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType CloseBrace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FCloseBrace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFCloseBrace
		{
			get
			{
				if(r_FCloseBrace == null)
				{
					r_FCloseBrace = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "CloseBrace");
				}
				return r_FCloseBrace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType LessThan
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FLessThan;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFLessThan
		{
			get
			{
				if(r_FLessThan == null)
				{
					r_FLessThan = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "LessThan");
				}
				return r_FLessThan;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType GreaterThan
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FGreaterThan;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFGreaterThan
		{
			get
			{
				if(r_FGreaterThan == null)
				{
					r_FGreaterThan = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "GreaterThan");
				}
				return r_FGreaterThan;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType End
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType r_FEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenType RFEnd
		{
			get
			{
				if(r_FEnd == null)
				{
					r_FEnd = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType"), "End");
				}
				return r_FEnd;
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
