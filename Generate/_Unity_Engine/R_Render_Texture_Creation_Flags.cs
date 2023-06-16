
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.RenderTextureCreationFlags
	/// </summary>
    public partial class RRenderTextureCreationFlags : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.RenderTextureCreationFlags);
            }
        }

        public RRenderTextureCreationFlags() : base("UnityEngine.RenderTextureCreationFlags")
        {
        }

        public RRenderTextureCreationFlags(System.Object instance) : base("UnityEngine.RenderTextureCreationFlags")
		{
            SetInstance(instance);
		}

        public RRenderTextureCreationFlags(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderTextureCreationFlags(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.RenderTextureCreationFlags MipMap
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FMipMap;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFMipMap
		{
			get
			{
				if(r_FMipMap == null)
				{
					r_FMipMap = new(Type, "MipMap");
				}
				return r_FMipMap;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags AutoGenerateMips
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FAutoGenerateMips;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFAutoGenerateMips
		{
			get
			{
				if(r_FAutoGenerateMips == null)
				{
					r_FAutoGenerateMips = new(Type, "AutoGenerateMips");
				}
				return r_FAutoGenerateMips;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags SRGB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FSRGB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFSRGB
		{
			get
			{
				if(r_FSRGB == null)
				{
					r_FSRGB = new(Type, "SRGB");
				}
				return r_FSRGB;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags EyeTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FEyeTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFEyeTexture
		{
			get
			{
				if(r_FEyeTexture == null)
				{
					r_FEyeTexture = new(Type, "EyeTexture");
				}
				return r_FEyeTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags EnableRandomWrite
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FEnableRandomWrite;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFEnableRandomWrite
		{
			get
			{
				if(r_FEnableRandomWrite == null)
				{
					r_FEnableRandomWrite = new(Type, "EnableRandomWrite");
				}
				return r_FEnableRandomWrite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags CreatedFromScript
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FCreatedFromScript;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFCreatedFromScript
		{
			get
			{
				if(r_FCreatedFromScript == null)
				{
					r_FCreatedFromScript = new(Type, "CreatedFromScript");
				}
				return r_FCreatedFromScript;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags AllowVerticalFlip
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FAllowVerticalFlip;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFAllowVerticalFlip
		{
			get
			{
				if(r_FAllowVerticalFlip == null)
				{
					r_FAllowVerticalFlip = new(Type, "AllowVerticalFlip");
				}
				return r_FAllowVerticalFlip;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags NoResolvedColorSurface
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FNoResolvedColorSurface;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFNoResolvedColorSurface
		{
			get
			{
				if(r_FNoResolvedColorSurface == null)
				{
					r_FNoResolvedColorSurface = new(Type, "NoResolvedColorSurface");
				}
				return r_FNoResolvedColorSurface;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags DynamicallyScalable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FDynamicallyScalable;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFDynamicallyScalable
		{
			get
			{
				if(r_FDynamicallyScalable == null)
				{
					r_FDynamicallyScalable = new(Type, "DynamicallyScalable");
				}
				return r_FDynamicallyScalable;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureCreationFlags BindMS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags r_FBindMS;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureCreationFlags RFBindMS
		{
			get
			{
				if(r_FBindMS == null)
				{
					r_FBindMS = new(Type, "BindMS");
				}
				return r_FBindMS;
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
