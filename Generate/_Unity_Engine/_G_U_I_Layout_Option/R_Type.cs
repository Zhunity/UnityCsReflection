
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RGUILayoutOption
{
	
	/// <summary>
	/// UnityEngine.GUILayoutOption+Type
	/// </summary>
    public partial class RType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type");
            }
        }

        public RType() : base("UnityEngine.GUILayoutOption+Type")
        {
        }

        public RType(System.Object instance) : base("UnityEngine.GUILayoutOption+Type")
		{
            SetInstance(instance);
		}

        public RType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.GUILayoutOption+Type fixedWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FfixedWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFfixedWidth
		{
			get
			{
				if(r_FfixedWidth == null)
				{
					r_FfixedWidth = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "fixedWidth");
				}
				return r_FfixedWidth;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type fixedHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FfixedHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFfixedHeight
		{
			get
			{
				if(r_FfixedHeight == null)
				{
					r_FfixedHeight = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "fixedHeight");
				}
				return r_FfixedHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type minWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FminWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFminWidth
		{
			get
			{
				if(r_FminWidth == null)
				{
					r_FminWidth = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "minWidth");
				}
				return r_FminWidth;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type maxWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FmaxWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFmaxWidth
		{
			get
			{
				if(r_FmaxWidth == null)
				{
					r_FmaxWidth = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "maxWidth");
				}
				return r_FmaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type minHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FminHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFminHeight
		{
			get
			{
				if(r_FminHeight == null)
				{
					r_FminHeight = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "minHeight");
				}
				return r_FminHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type maxHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FmaxHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFmaxHeight
		{
			get
			{
				if(r_FmaxHeight == null)
				{
					r_FmaxHeight = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "maxHeight");
				}
				return r_FmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type stretchWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FstretchWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFstretchWidth
		{
			get
			{
				if(r_FstretchWidth == null)
				{
					r_FstretchWidth = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "stretchWidth");
				}
				return r_FstretchWidth;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type stretchHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FstretchHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFstretchHeight
		{
			get
			{
				if(r_FstretchHeight == null)
				{
					r_FstretchHeight = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "stretchHeight");
				}
				return r_FstretchHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type alignStart
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FalignStart;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFalignStart
		{
			get
			{
				if(r_FalignStart == null)
				{
					r_FalignStart = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "alignStart");
				}
				return r_FalignStart;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type alignMiddle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FalignMiddle;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFalignMiddle
		{
			get
			{
				if(r_FalignMiddle == null)
				{
					r_FalignMiddle = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "alignMiddle");
				}
				return r_FalignMiddle;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type alignEnd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FalignEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFalignEnd
		{
			get
			{
				if(r_FalignEnd == null)
				{
					r_FalignEnd = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "alignEnd");
				}
				return r_FalignEnd;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type alignJustify
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FalignJustify;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFalignJustify
		{
			get
			{
				if(r_FalignJustify == null)
				{
					r_FalignJustify = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "alignJustify");
				}
				return r_FalignJustify;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type equalSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_FequalSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFequalSize
		{
			get
			{
				if(r_FequalSize == null)
				{
					r_FequalSize = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "equalSize");
				}
				return r_FequalSize;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutOption+Type spacing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType r_Fspacing;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutOption.RType RFspacing
		{
			get
			{
				if(r_Fspacing == null)
				{
					r_Fspacing = new( ReflectionUtils.GetType("UnityEngine.GUILayoutOption+Type"), "spacing");
				}
				return r_Fspacing;
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
}