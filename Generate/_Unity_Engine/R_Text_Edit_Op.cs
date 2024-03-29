
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextEditOp
	/// </summary>
    public partial class RTextEditOp : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextEditOp");
            }
        }

        public RTextEditOp() : base("UnityEngine.TextEditOp")
        {
        }

        public RTextEditOp(System.Object instance) : base("UnityEngine.TextEditOp")
		{
            SetInstance(instance);
		}

        public RTextEditOp(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextEditOp(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.TextEditOp MoveLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveLeft
		{
			get
			{
				if(r_FMoveLeft == null)
				{
					r_FMoveLeft = new(Type, "MoveLeft");
				}
				return r_FMoveLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveRight
		{
			get
			{
				if(r_FMoveRight == null)
				{
					r_FMoveRight = new(Type, "MoveRight");
				}
				return r_FMoveRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveUp
		{
			get
			{
				if(r_FMoveUp == null)
				{
					r_FMoveUp = new(Type, "MoveUp");
				}
				return r_FMoveUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveDown
		{
			get
			{
				if(r_FMoveDown == null)
				{
					r_FMoveDown = new(Type, "MoveDown");
				}
				return r_FMoveDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveLineStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveLineStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveLineStart
		{
			get
			{
				if(r_FMoveLineStart == null)
				{
					r_FMoveLineStart = new(Type, "MoveLineStart");
				}
				return r_FMoveLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveLineEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveLineEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveLineEnd
		{
			get
			{
				if(r_FMoveLineEnd == null)
				{
					r_FMoveLineEnd = new(Type, "MoveLineEnd");
				}
				return r_FMoveLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveTextStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveTextStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveTextStart
		{
			get
			{
				if(r_FMoveTextStart == null)
				{
					r_FMoveTextStart = new(Type, "MoveTextStart");
				}
				return r_FMoveTextStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveTextEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveTextEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveTextEnd
		{
			get
			{
				if(r_FMoveTextEnd == null)
				{
					r_FMoveTextEnd = new(Type, "MoveTextEnd");
				}
				return r_FMoveTextEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MovePageUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMovePageUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMovePageUp
		{
			get
			{
				if(r_FMovePageUp == null)
				{
					r_FMovePageUp = new(Type, "MovePageUp");
				}
				return r_FMovePageUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MovePageDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMovePageDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMovePageDown
		{
			get
			{
				if(r_FMovePageDown == null)
				{
					r_FMovePageDown = new(Type, "MovePageDown");
				}
				return r_FMovePageDown;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveGraphicalLineStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveGraphicalLineStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveGraphicalLineStart
		{
			get
			{
				if(r_FMoveGraphicalLineStart == null)
				{
					r_FMoveGraphicalLineStart = new(Type, "MoveGraphicalLineStart");
				}
				return r_FMoveGraphicalLineStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveGraphicalLineEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveGraphicalLineEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveGraphicalLineEnd
		{
			get
			{
				if(r_FMoveGraphicalLineEnd == null)
				{
					r_FMoveGraphicalLineEnd = new(Type, "MoveGraphicalLineEnd");
				}
				return r_FMoveGraphicalLineEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveWordLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveWordLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveWordLeft
		{
			get
			{
				if(r_FMoveWordLeft == null)
				{
					r_FMoveWordLeft = new(Type, "MoveWordLeft");
				}
				return r_FMoveWordLeft;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveWordRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveWordRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveWordRight
		{
			get
			{
				if(r_FMoveWordRight == null)
				{
					r_FMoveWordRight = new(Type, "MoveWordRight");
				}
				return r_FMoveWordRight;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveParagraphForward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveParagraphForward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveParagraphForward
		{
			get
			{
				if(r_FMoveParagraphForward == null)
				{
					r_FMoveParagraphForward = new(Type, "MoveParagraphForward");
				}
				return r_FMoveParagraphForward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveParagraphBackward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveParagraphBackward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveParagraphBackward
		{
			get
			{
				if(r_FMoveParagraphBackward == null)
				{
					r_FMoveParagraphBackward = new(Type, "MoveParagraphBackward");
				}
				return r_FMoveParagraphBackward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveToStartOfNextWord
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveToStartOfNextWord;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveToStartOfNextWord
		{
			get
			{
				if(r_FMoveToStartOfNextWord == null)
				{
					r_FMoveToStartOfNextWord = new(Type, "MoveToStartOfNextWord");
				}
				return r_FMoveToStartOfNextWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp MoveToEndOfPreviousWord
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FMoveToEndOfPreviousWord;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFMoveToEndOfPreviousWord
		{
			get
			{
				if(r_FMoveToEndOfPreviousWord == null)
				{
					r_FMoveToEndOfPreviousWord = new(Type, "MoveToEndOfPreviousWord");
				}
				return r_FMoveToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Delete
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FDelete;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFDelete
		{
			get
			{
				if(r_FDelete == null)
				{
					r_FDelete = new(Type, "Delete");
				}
				return r_FDelete;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Backspace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FBackspace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFBackspace
		{
			get
			{
				if(r_FBackspace == null)
				{
					r_FBackspace = new(Type, "Backspace");
				}
				return r_FBackspace;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp DeleteWordBack
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FDeleteWordBack;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFDeleteWordBack
		{
			get
			{
				if(r_FDeleteWordBack == null)
				{
					r_FDeleteWordBack = new(Type, "DeleteWordBack");
				}
				return r_FDeleteWordBack;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp DeleteWordForward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FDeleteWordForward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFDeleteWordForward
		{
			get
			{
				if(r_FDeleteWordForward == null)
				{
					r_FDeleteWordForward = new(Type, "DeleteWordForward");
				}
				return r_FDeleteWordForward;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp DeleteLineBack
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FDeleteLineBack;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFDeleteLineBack
		{
			get
			{
				if(r_FDeleteLineBack == null)
				{
					r_FDeleteLineBack = new(Type, "DeleteLineBack");
				}
				return r_FDeleteLineBack;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Cut
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FCut;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFCut
		{
			get
			{
				if(r_FCut == null)
				{
					r_FCut = new(Type, "Cut");
				}
				return r_FCut;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp Paste
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FPaste;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFPaste
		{
			get
			{
				if(r_FPaste == null)
				{
					r_FPaste = new(Type, "Paste");
				}
				return r_FPaste;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FScrollStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFScrollStart
		{
			get
			{
				if(r_FScrollStart == null)
				{
					r_FScrollStart = new(Type, "ScrollStart");
				}
				return r_FScrollStart;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FScrollEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFScrollEnd
		{
			get
			{
				if(r_FScrollEnd == null)
				{
					r_FScrollEnd = new(Type, "ScrollEnd");
				}
				return r_FScrollEnd;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollPageUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FScrollPageUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFScrollPageUp
		{
			get
			{
				if(r_FScrollPageUp == null)
				{
					r_FScrollPageUp = new(Type, "ScrollPageUp");
				}
				return r_FScrollPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.TextEditOp ScrollPageDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp r_FScrollPageDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp RFScrollPageDown
		{
			get
			{
				if(r_FScrollPageDown == null)
				{
					r_FScrollPageDown = new(Type, "ScrollPageDown");
				}
				return r_FScrollPageDown;
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
