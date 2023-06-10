
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.FontStyles
	/// </summary>
    public partial class RFontStyles : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.FontStyles);
            }
        }

        public RFontStyles() : base("UnityEngine.TextCore.Text.FontStyles")
        {
        }

        public RFontStyles(System.Object instance) : base("UnityEngine.TextCore.Text.FontStyles")
		{
            SetInstance(instance);
		}

        public RFontStyles(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFontStyles(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.TextCore.Text.FontStyles Normal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FNormal;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFNormal
		{
			get
			{
				if(r_FNormal == null)
				{
					r_FNormal = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Normal");
				}
				return r_FNormal;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Bold
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FBold;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFBold
		{
			get
			{
				if(r_FBold == null)
				{
					r_FBold = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Bold");
				}
				return r_FBold;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Italic
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FItalic;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFItalic
		{
			get
			{
				if(r_FItalic == null)
				{
					r_FItalic = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Italic");
				}
				return r_FItalic;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Underline
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FUnderline;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFUnderline
		{
			get
			{
				if(r_FUnderline == null)
				{
					r_FUnderline = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Underline");
				}
				return r_FUnderline;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles LowerCase
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FLowerCase;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFLowerCase
		{
			get
			{
				if(r_FLowerCase == null)
				{
					r_FLowerCase = new(typeof(UnityEngine.TextCore.Text.FontStyles), "LowerCase");
				}
				return r_FLowerCase;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles UpperCase
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FUpperCase;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFUpperCase
		{
			get
			{
				if(r_FUpperCase == null)
				{
					r_FUpperCase = new(typeof(UnityEngine.TextCore.Text.FontStyles), "UpperCase");
				}
				return r_FUpperCase;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles SmallCaps
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FSmallCaps;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFSmallCaps
		{
			get
			{
				if(r_FSmallCaps == null)
				{
					r_FSmallCaps = new(typeof(UnityEngine.TextCore.Text.FontStyles), "SmallCaps");
				}
				return r_FSmallCaps;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Strikethrough
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FStrikethrough;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFStrikethrough
		{
			get
			{
				if(r_FStrikethrough == null)
				{
					r_FStrikethrough = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Strikethrough");
				}
				return r_FStrikethrough;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Superscript
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FSuperscript;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFSuperscript
		{
			get
			{
				if(r_FSuperscript == null)
				{
					r_FSuperscript = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Superscript");
				}
				return r_FSuperscript;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Subscript
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FSubscript;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFSubscript
		{
			get
			{
				if(r_FSubscript == null)
				{
					r_FSubscript = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Subscript");
				}
				return r_FSubscript;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontStyles Highlight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles r_FHighlight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontStyles RFHighlight
		{
			get
			{
				if(r_FHighlight == null)
				{
					r_FHighlight = new(typeof(UnityEngine.TextCore.Text.FontStyles), "Highlight");
				}
				return r_FHighlight;
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
