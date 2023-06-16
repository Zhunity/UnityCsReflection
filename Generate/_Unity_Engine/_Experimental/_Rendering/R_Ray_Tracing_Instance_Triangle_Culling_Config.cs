
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig
	/// </summary>
    public partial class RRayTracingInstanceTriangleCullingConfig : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig);
            }
        }

        public RRayTracingInstanceTriangleCullingConfig() : base("UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig")
        {
        }

        public RRayTracingInstanceTriangleCullingConfig(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig")
		{
            SetInstance(instance);
		}

        public RRayTracingInstanceTriangleCullingConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRayTracingInstanceTriangleCullingConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String[] optionalDoubleSidedShaderKeywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FoptionalDoubleSidedShaderKeywords;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFoptionalDoubleSidedShaderKeywords
		{
			get
			{
				if(r_FoptionalDoubleSidedShaderKeywords == null)
				{
					r_FoptionalDoubleSidedShaderKeywords = new(this, "optionalDoubleSidedShaderKeywords");
				}
				return r_FoptionalDoubleSidedShaderKeywords;
			}
		}

		/// <summary>
		/// System.Boolean frontTriangleCounterClockwise
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FfrontTriangleCounterClockwise;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFfrontTriangleCounterClockwise
		{
			get
			{
				if(r_FfrontTriangleCounterClockwise == null)
				{
					r_FfrontTriangleCounterClockwise = new(this, "frontTriangleCounterClockwise");
				}
				return r_FfrontTriangleCounterClockwise;
			}
		}

		/// <summary>
		/// System.Boolean checkDoubleSidedGIMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FcheckDoubleSidedGIMaterial;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFcheckDoubleSidedGIMaterial
		{
			get
			{
				if(r_FcheckDoubleSidedGIMaterial == null)
				{
					r_FcheckDoubleSidedGIMaterial = new(this, "checkDoubleSidedGIMaterial");
				}
				return r_FcheckDoubleSidedGIMaterial;
			}
		}

		/// <summary>
		/// System.Boolean forceDoubleSided
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FforceDoubleSided;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFforceDoubleSided
		{
			get
			{
				if(r_FforceDoubleSided == null)
				{
					r_FforceDoubleSided = new(this, "forceDoubleSided");
				}
				return r_FforceDoubleSided;
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
