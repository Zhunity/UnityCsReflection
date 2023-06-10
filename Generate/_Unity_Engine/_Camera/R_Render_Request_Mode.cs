
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RCamera
{
	
	/// <summary>
	/// UnityEngine.Camera+RenderRequestMode
	/// </summary>
    public partial class RRenderRequestMode : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode");
            }
        }

        public RRenderRequestMode() : base("UnityEngine.Camera+RenderRequestMode")
        {
        }

        public RRenderRequestMode(System.Object instance) : base("UnityEngine.Camera+RenderRequestMode")
		{
            SetInstance(instance);
		}

        public RRenderRequestMode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderRequestMode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.Camera+RenderRequestMode None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode ObjectId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FObjectId;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFObjectId
		{
			get
			{
				if(r_FObjectId == null)
				{
					r_FObjectId = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "ObjectId");
				}
				return r_FObjectId;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode Depth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FDepth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFDepth
		{
			get
			{
				if(r_FDepth == null)
				{
					r_FDepth = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "Depth");
				}
				return r_FDepth;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode VertexNormal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FVertexNormal;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFVertexNormal
		{
			get
			{
				if(r_FVertexNormal == null)
				{
					r_FVertexNormal = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "VertexNormal");
				}
				return r_FVertexNormal;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode WorldPosition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FWorldPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFWorldPosition
		{
			get
			{
				if(r_FWorldPosition == null)
				{
					r_FWorldPosition = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "WorldPosition");
				}
				return r_FWorldPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode EntityId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FEntityId;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFEntityId
		{
			get
			{
				if(r_FEntityId == null)
				{
					r_FEntityId = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "EntityId");
				}
				return r_FEntityId;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode BaseColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FBaseColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFBaseColor
		{
			get
			{
				if(r_FBaseColor == null)
				{
					r_FBaseColor = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "BaseColor");
				}
				return r_FBaseColor;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode SpecularColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FSpecularColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFSpecularColor
		{
			get
			{
				if(r_FSpecularColor == null)
				{
					r_FSpecularColor = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "SpecularColor");
				}
				return r_FSpecularColor;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode Metallic
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FMetallic;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFMetallic
		{
			get
			{
				if(r_FMetallic == null)
				{
					r_FMetallic = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "Metallic");
				}
				return r_FMetallic;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode Emission
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FEmission;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFEmission
		{
			get
			{
				if(r_FEmission == null)
				{
					r_FEmission = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "Emission");
				}
				return r_FEmission;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode Normal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FNormal;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFNormal
		{
			get
			{
				if(r_FNormal == null)
				{
					r_FNormal = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "Normal");
				}
				return r_FNormal;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode Smoothness
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FSmoothness;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFSmoothness
		{
			get
			{
				if(r_FSmoothness == null)
				{
					r_FSmoothness = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "Smoothness");
				}
				return r_FSmoothness;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode Occlusion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FOcclusion;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFOcclusion
		{
			get
			{
				if(r_FOcclusion == null)
				{
					r_FOcclusion = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "Occlusion");
				}
				return r_FOcclusion;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode DiffuseColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_FDiffuseColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFDiffuseColor
		{
			get
			{
				if(r_FDiffuseColor == null)
				{
					r_FDiffuseColor = new( ReflectionUtils.GetType("UnityEngine.Camera+RenderRequestMode"), "DiffuseColor");
				}
				return r_FDiffuseColor;
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