
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.TextureDimension
	/// </summary>
    public partial class RTextureDimension : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.TextureDimension);
            }
        }

        public RTextureDimension() : base("UnityEngine.Rendering.TextureDimension")
        {
        }

        public RTextureDimension(System.Object instance) : base("UnityEngine.Rendering.TextureDimension")
		{
            SetInstance(instance);
		}

        public RTextureDimension(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextureDimension(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.Rendering.TextureDimension Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FUnknown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFUnknown
		{
			get
			{
				if(r_FUnknown == null)
				{
					r_FUnknown = new(Type, "Unknown");
				}
				return r_FUnknown;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(Type, "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension Any
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FAny;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFAny
		{
			get
			{
				if(r_FAny == null)
				{
					r_FAny = new(Type, "Any");
				}
				return r_FAny;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension Tex2D
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FTex2D;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFTex2D
		{
			get
			{
				if(r_FTex2D == null)
				{
					r_FTex2D = new(Type, "Tex2D");
				}
				return r_FTex2D;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension Tex3D
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FTex3D;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFTex3D
		{
			get
			{
				if(r_FTex3D == null)
				{
					r_FTex3D = new(Type, "Tex3D");
				}
				return r_FTex3D;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension Cube
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FCube;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFCube
		{
			get
			{
				if(r_FCube == null)
				{
					r_FCube = new(Type, "Cube");
				}
				return r_FCube;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension Tex2DArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FTex2DArray;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFTex2DArray
		{
			get
			{
				if(r_FTex2DArray == null)
				{
					r_FTex2DArray = new(Type, "Tex2DArray");
				}
				return r_FTex2DArray;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension CubeArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_FCubeArray;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RFCubeArray
		{
			get
			{
				if(r_FCubeArray == null)
				{
					r_FCubeArray = new(Type, "CubeArray");
				}
				return r_FCubeArray;
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
