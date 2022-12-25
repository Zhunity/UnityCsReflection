using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig
	/// </summary>
    public partial class RRayTracingInstanceTriangleCullingConfig : RMember //
    {

		/// <summary>
		/// System.String[] optionalDoubleSidedShaderKeywords
		/// </summary>
		protected RFieldArray<RField> r_optionalDoubleSidedShaderKeywords;
		public virtual RFieldArray<RField> RoptionalDoubleSidedShaderKeywords
		{
			get
			{
				if(r_optionalDoubleSidedShaderKeywords == null)
				{
					r_optionalDoubleSidedShaderKeywords = new(this, "optionalDoubleSidedShaderKeywords");
					r_optionalDoubleSidedShaderKeywords.SetBelong(this.instance);
				}
				return r_optionalDoubleSidedShaderKeywords;
			}
		}

		/// <summary>
		/// System.Boolean frontTriangleCounterClockwise
		/// </summary>
		protected RField r_frontTriangleCounterClockwise;
		public virtual RField RfrontTriangleCounterClockwise
		{
			get
			{
				if(r_frontTriangleCounterClockwise == null)
				{
					r_frontTriangleCounterClockwise = new(this, "frontTriangleCounterClockwise");
					r_frontTriangleCounterClockwise.SetBelong(this.instance);
				}
				return r_frontTriangleCounterClockwise;
			}
		}

		/// <summary>
		/// System.Boolean checkDoubleSidedGIMaterial
		/// </summary>
		protected RField r_checkDoubleSidedGIMaterial;
		public virtual RField RcheckDoubleSidedGIMaterial
		{
			get
			{
				if(r_checkDoubleSidedGIMaterial == null)
				{
					r_checkDoubleSidedGIMaterial = new(this, "checkDoubleSidedGIMaterial");
					r_checkDoubleSidedGIMaterial.SetBelong(this.instance);
				}
				return r_checkDoubleSidedGIMaterial;
			}
		}

		/// <summary>
		/// System.Boolean forceDoubleSided
		/// </summary>
		protected RField r_forceDoubleSided;
		public virtual RField RforceDoubleSided
		{
			get
			{
				if(r_forceDoubleSided == null)
				{
					r_forceDoubleSided = new(this, "forceDoubleSided");
					r_forceDoubleSided.SetBelong(this.instance);
				}
				return r_forceDoubleSided;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
