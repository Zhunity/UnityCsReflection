
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.BuiltinRenderTextureType
	/// </summary>
    public partial class RBuiltinRenderTextureType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.BuiltinRenderTextureType);
            }
        }

        public RBuiltinRenderTextureType() : base("UnityEngine.Rendering.BuiltinRenderTextureType")
        {
        }

        public RBuiltinRenderTextureType(System.Object instance) : base("UnityEngine.Rendering.BuiltinRenderTextureType")
		{
            SetInstance(instance);
		}

        public RBuiltinRenderTextureType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBuiltinRenderTextureType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.Rendering.BuiltinRenderTextureType PropertyName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FPropertyName;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFPropertyName
		{
			get
			{
				if(r_FPropertyName == null)
				{
					r_FPropertyName = new(Type, "PropertyName");
				}
				return r_FPropertyName;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType BufferPtr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FBufferPtr;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFBufferPtr
		{
			get
			{
				if(r_FBufferPtr == null)
				{
					r_FBufferPtr = new(Type, "BufferPtr");
				}
				return r_FBufferPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType RenderTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FRenderTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFRenderTexture
		{
			get
			{
				if(r_FRenderTexture == null)
				{
					r_FRenderTexture = new(Type, "RenderTexture");
				}
				return r_FRenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType BindableTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FBindableTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFBindableTexture
		{
			get
			{
				if(r_FBindableTexture == null)
				{
					r_FBindableTexture = new(Type, "BindableTexture");
				}
				return r_FBindableTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFNone
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
		/// UnityEngine.Rendering.BuiltinRenderTextureType CurrentActive
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FCurrentActive;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFCurrentActive
		{
			get
			{
				if(r_FCurrentActive == null)
				{
					r_FCurrentActive = new(Type, "CurrentActive");
				}
				return r_FCurrentActive;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType CameraTarget
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FCameraTarget;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFCameraTarget
		{
			get
			{
				if(r_FCameraTarget == null)
				{
					r_FCameraTarget = new(Type, "CameraTarget");
				}
				return r_FCameraTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType Depth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FDepth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFDepth
		{
			get
			{
				if(r_FDepth == null)
				{
					r_FDepth = new(Type, "Depth");
				}
				return r_FDepth;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType DepthNormals
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FDepthNormals;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFDepthNormals
		{
			get
			{
				if(r_FDepthNormals == null)
				{
					r_FDepthNormals = new(Type, "DepthNormals");
				}
				return r_FDepthNormals;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType ResolvedDepth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FResolvedDepth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFResolvedDepth
		{
			get
			{
				if(r_FResolvedDepth == null)
				{
					r_FResolvedDepth = new(Type, "ResolvedDepth");
				}
				return r_FResolvedDepth;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType PrepassNormalsSpec
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FPrepassNormalsSpec;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFPrepassNormalsSpec
		{
			get
			{
				if(r_FPrepassNormalsSpec == null)
				{
					r_FPrepassNormalsSpec = new(Type, "PrepassNormalsSpec");
				}
				return r_FPrepassNormalsSpec;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType PrepassLight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FPrepassLight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFPrepassLight
		{
			get
			{
				if(r_FPrepassLight == null)
				{
					r_FPrepassLight = new(Type, "PrepassLight");
				}
				return r_FPrepassLight;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType PrepassLightSpec
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FPrepassLightSpec;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFPrepassLightSpec
		{
			get
			{
				if(r_FPrepassLightSpec == null)
				{
					r_FPrepassLightSpec = new(Type, "PrepassLightSpec");
				}
				return r_FPrepassLightSpec;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer0
		{
			get
			{
				if(r_FGBuffer0 == null)
				{
					r_FGBuffer0 = new(Type, "GBuffer0");
				}
				return r_FGBuffer0;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer1
		{
			get
			{
				if(r_FGBuffer1 == null)
				{
					r_FGBuffer1 = new(Type, "GBuffer1");
				}
				return r_FGBuffer1;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer2
		{
			get
			{
				if(r_FGBuffer2 == null)
				{
					r_FGBuffer2 = new(Type, "GBuffer2");
				}
				return r_FGBuffer2;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer3
		{
			get
			{
				if(r_FGBuffer3 == null)
				{
					r_FGBuffer3 = new(Type, "GBuffer3");
				}
				return r_FGBuffer3;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType Reflections
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FReflections;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFReflections
		{
			get
			{
				if(r_FReflections == null)
				{
					r_FReflections = new(Type, "Reflections");
				}
				return r_FReflections;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType MotionVectors
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FMotionVectors;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFMotionVectors
		{
			get
			{
				if(r_FMotionVectors == null)
				{
					r_FMotionVectors = new(Type, "MotionVectors");
				}
				return r_FMotionVectors;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer4
		{
			get
			{
				if(r_FGBuffer4 == null)
				{
					r_FGBuffer4 = new(Type, "GBuffer4");
				}
				return r_FGBuffer4;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer5
		{
			get
			{
				if(r_FGBuffer5 == null)
				{
					r_FGBuffer5 = new(Type, "GBuffer5");
				}
				return r_FGBuffer5;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer6
		{
			get
			{
				if(r_FGBuffer6 == null)
				{
					r_FGBuffer6 = new(Type, "GBuffer6");
				}
				return r_FGBuffer6;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.BuiltinRenderTextureType GBuffer7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType r_FGBuffer7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RBuiltinRenderTextureType RFGBuffer7
		{
			get
			{
				if(r_FGBuffer7 == null)
				{
					r_FGBuffer7 = new(Type, "GBuffer7");
				}
				return r_FGBuffer7;
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
