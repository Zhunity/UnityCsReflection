
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.KeyboardNavigationOperation
	/// </summary>
    public partial class RKeyboardNavigationOperation : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.KeyboardNavigationOperation);
            }
        }

        public RKeyboardNavigationOperation() : base("UnityEngine.UIElements.KeyboardNavigationOperation")
        {
        }

        public RKeyboardNavigationOperation(System.Object instance) : base("UnityEngine.UIElements.KeyboardNavigationOperation")
		{
            SetInstance(instance);
		}

        public RKeyboardNavigationOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyboardNavigationOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.KeyboardNavigationOperation None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation SelectAll
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FSelectAll;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFSelectAll
		{
			get
			{
				if(r_FSelectAll == null)
				{
					r_FSelectAll = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "SelectAll");
				}
				return r_FSelectAll;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation Cancel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FCancel;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFCancel
		{
			get
			{
				if(r_FCancel == null)
				{
					r_FCancel = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "Cancel");
				}
				return r_FCancel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation Submit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FSubmit;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFSubmit
		{
			get
			{
				if(r_FSubmit == null)
				{
					r_FSubmit = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "Submit");
				}
				return r_FSubmit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation Previous
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FPrevious;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFPrevious
		{
			get
			{
				if(r_FPrevious == null)
				{
					r_FPrevious = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "Previous");
				}
				return r_FPrevious;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation Next
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FNext;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFNext
		{
			get
			{
				if(r_FNext == null)
				{
					r_FNext = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "Next");
				}
				return r_FNext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation PageUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FPageUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFPageUp
		{
			get
			{
				if(r_FPageUp == null)
				{
					r_FPageUp = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "PageUp");
				}
				return r_FPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation PageDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FPageDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFPageDown
		{
			get
			{
				if(r_FPageDown == null)
				{
					r_FPageDown = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "PageDown");
				}
				return r_FPageDown;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation Begin
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FBegin;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFBegin
		{
			get
			{
				if(r_FBegin == null)
				{
					r_FBegin = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "Begin");
				}
				return r_FBegin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation End
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation r_FEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation RFEnd
		{
			get
			{
				if(r_FEnd == null)
				{
					r_FEnd = new(typeof(UnityEngine.UIElements.KeyboardNavigationOperation), "End");
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
