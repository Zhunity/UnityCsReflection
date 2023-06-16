
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextSelectOp
	/// </summary>
    public partial class RTextSelectOp : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextSelectOp");
            }
        }

        public RTextSelectOp() : base("UnityEngine.TextSelectOp")
        {
        }

        public RTextSelectOp(System.Object instance) : base("UnityEngine.TextSelectOp")
		{
            SetInstance(instance);
		}

        public RTextSelectOp(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextSelectOp(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.TextSelectOp SelectLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectLeft
		{
			get
			{
				if(r_FSelectLeft == null)
				{
					r_FSelectLeft = new(Type, "SelectLeft");
				}
				return r_FSelectLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectRight
		{
			get
			{
				if(r_FSelectRight == null)
				{
					r_FSelectRight = new(Type, "SelectRight");
				}
				return r_FSelectRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectUp
		{
			get
			{
				if(r_FSelectUp == null)
				{
					r_FSelectUp = new(Type, "SelectUp");
				}
				return r_FSelectUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectDown
		{
			get
			{
				if(r_FSelectDown == null)
				{
					r_FSelectDown = new(Type, "SelectDown");
				}
				return r_FSelectDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectTextStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectTextStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectTextStart
		{
			get
			{
				if(r_FSelectTextStart == null)
				{
					r_FSelectTextStart = new(Type, "SelectTextStart");
				}
				return r_FSelectTextStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectTextEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectTextEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectTextEnd
		{
			get
			{
				if(r_FSelectTextEnd == null)
				{
					r_FSelectTextEnd = new(Type, "SelectTextEnd");
				}
				return r_FSelectTextEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectPageUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectPageUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectPageUp
		{
			get
			{
				if(r_FSelectPageUp == null)
				{
					r_FSelectPageUp = new(Type, "SelectPageUp");
				}
				return r_FSelectPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectPageDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectPageDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectPageDown
		{
			get
			{
				if(r_FSelectPageDown == null)
				{
					r_FSelectPageDown = new(Type, "SelectPageDown");
				}
				return r_FSelectPageDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp ExpandSelectGraphicalLineStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FExpandSelectGraphicalLineStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFExpandSelectGraphicalLineStart
		{
			get
			{
				if(r_FExpandSelectGraphicalLineStart == null)
				{
					r_FExpandSelectGraphicalLineStart = new(Type, "ExpandSelectGraphicalLineStart");
				}
				return r_FExpandSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp ExpandSelectGraphicalLineEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FExpandSelectGraphicalLineEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFExpandSelectGraphicalLineEnd
		{
			get
			{
				if(r_FExpandSelectGraphicalLineEnd == null)
				{
					r_FExpandSelectGraphicalLineEnd = new(Type, "ExpandSelectGraphicalLineEnd");
				}
				return r_FExpandSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectGraphicalLineStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectGraphicalLineStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectGraphicalLineStart
		{
			get
			{
				if(r_FSelectGraphicalLineStart == null)
				{
					r_FSelectGraphicalLineStart = new(Type, "SelectGraphicalLineStart");
				}
				return r_FSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectGraphicalLineEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectGraphicalLineEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectGraphicalLineEnd
		{
			get
			{
				if(r_FSelectGraphicalLineEnd == null)
				{
					r_FSelectGraphicalLineEnd = new(Type, "SelectGraphicalLineEnd");
				}
				return r_FSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectWordLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectWordLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectWordLeft
		{
			get
			{
				if(r_FSelectWordLeft == null)
				{
					r_FSelectWordLeft = new(Type, "SelectWordLeft");
				}
				return r_FSelectWordLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectWordRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectWordRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectWordRight
		{
			get
			{
				if(r_FSelectWordRight == null)
				{
					r_FSelectWordRight = new(Type, "SelectWordRight");
				}
				return r_FSelectWordRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectToEndOfPreviousWord
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectToEndOfPreviousWord;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectToEndOfPreviousWord
		{
			get
			{
				if(r_FSelectToEndOfPreviousWord == null)
				{
					r_FSelectToEndOfPreviousWord = new(Type, "SelectToEndOfPreviousWord");
				}
				return r_FSelectToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectToStartOfNextWord
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectToStartOfNextWord;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectToStartOfNextWord
		{
			get
			{
				if(r_FSelectToStartOfNextWord == null)
				{
					r_FSelectToStartOfNextWord = new(Type, "SelectToStartOfNextWord");
				}
				return r_FSelectToStartOfNextWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectParagraphBackward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectParagraphBackward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectParagraphBackward
		{
			get
			{
				if(r_FSelectParagraphBackward == null)
				{
					r_FSelectParagraphBackward = new(Type, "SelectParagraphBackward");
				}
				return r_FSelectParagraphBackward;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectParagraphForward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectParagraphForward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectParagraphForward
		{
			get
			{
				if(r_FSelectParagraphForward == null)
				{
					r_FSelectParagraphForward = new(Type, "SelectParagraphForward");
				}
				return r_FSelectParagraphForward;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp Copy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FCopy;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFCopy
		{
			get
			{
				if(r_FCopy == null)
				{
					r_FCopy = new(Type, "Copy");
				}
				return r_FCopy;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectAll
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectAll;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectAll
		{
			get
			{
				if(r_FSelectAll == null)
				{
					r_FSelectAll = new(Type, "SelectAll");
				}
				return r_FSelectAll;
			}
		}

		/// <summary>
		/// UnityEngine.TextSelectOp SelectNone
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp r_FSelectNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp RFSelectNone
		{
			get
			{
				if(r_FSelectNone == null)
				{
					r_FSelectNone = new(Type, "SelectNone");
				}
				return r_FSelectNone;
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

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
