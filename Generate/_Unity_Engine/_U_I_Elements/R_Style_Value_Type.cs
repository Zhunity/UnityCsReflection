
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.StyleValueType
	/// </summary>
    public partial class RStyleValueType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType");
            }
        }

        public RStyleValueType() : base("UnityEngine.UIElements.StyleValueType")
        {
        }

        public RStyleValueType(System.Object instance) : base("UnityEngine.UIElements.StyleValueType")
		{
            SetInstance(instance);
		}

        public RStyleValueType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleValueType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.StyleValueType Invalid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FInvalid;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFInvalid
		{
			get
			{
				if(r_FInvalid == null)
				{
					r_FInvalid = new(Type, "Invalid");
				}
				return r_FInvalid;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Keyword
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FKeyword;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFKeyword
		{
			get
			{
				if(r_FKeyword == null)
				{
					r_FKeyword = new(Type, "Keyword");
				}
				return r_FKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Float
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FFloat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFFloat
		{
			get
			{
				if(r_FFloat == null)
				{
					r_FFloat = new(Type, "Float");
				}
				return r_FFloat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Dimension
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FDimension;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFDimension
		{
			get
			{
				if(r_FDimension == null)
				{
					r_FDimension = new(Type, "Dimension");
				}
				return r_FDimension;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Color
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFColor
		{
			get
			{
				if(r_FColor == null)
				{
					r_FColor = new(Type, "Color");
				}
				return r_FColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType ResourcePath
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FResourcePath;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFResourcePath
		{
			get
			{
				if(r_FResourcePath == null)
				{
					r_FResourcePath = new(Type, "ResourcePath");
				}
				return r_FResourcePath;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType AssetReference
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FAssetReference;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFAssetReference
		{
			get
			{
				if(r_FAssetReference == null)
				{
					r_FAssetReference = new(Type, "AssetReference");
				}
				return r_FAssetReference;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Enum
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FEnum;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFEnum
		{
			get
			{
				if(r_FEnum == null)
				{
					r_FEnum = new(Type, "Enum");
				}
				return r_FEnum;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Variable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FVariable;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFVariable
		{
			get
			{
				if(r_FVariable == null)
				{
					r_FVariable = new(Type, "Variable");
				}
				return r_FVariable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType String
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FString;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFString
		{
			get
			{
				if(r_FString == null)
				{
					r_FString = new(Type, "String");
				}
				return r_FString;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType Function
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FFunction;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFFunction
		{
			get
			{
				if(r_FFunction == null)
				{
					r_FFunction = new(Type, "Function");
				}
				return r_FFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType CommaSeparator
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FCommaSeparator;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFCommaSeparator
		{
			get
			{
				if(r_FCommaSeparator == null)
				{
					r_FCommaSeparator = new(Type, "CommaSeparator");
				}
				return r_FCommaSeparator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType ScalableImage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FScalableImage;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFScalableImage
		{
			get
			{
				if(r_FScalableImage == null)
				{
					r_FScalableImage = new(Type, "ScalableImage");
				}
				return r_FScalableImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType MissingAssetReference
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType r_FMissingAssetReference;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType RFMissingAssetReference
		{
			get
			{
				if(r_FMissingAssetReference == null)
				{
					r_FMissingAssetReference = new(Type, "MissingAssetReference");
				}
				return r_FMissingAssetReference;
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
