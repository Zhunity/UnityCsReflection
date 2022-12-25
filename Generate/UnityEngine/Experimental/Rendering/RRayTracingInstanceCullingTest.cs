using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest
	/// </summary>
    public partial class RRayTracingInstanceCullingTest : RMember //
    {

		/// <summary>
		/// System.UInt32 instanceMask
		/// </summary>
		protected RField r_instanceMask;
		public virtual RField RinstanceMask
		{
			get
			{
				if(r_instanceMask == null)
				{
					r_instanceMask = new(this, "instanceMask");
					r_instanceMask.SetBelong(this.instance);
				}
				return r_instanceMask;
			}
		}

		/// <summary>
		/// System.Int32 layerMask
		/// </summary>
		protected RField r_layerMask;
		public virtual RField RlayerMask
		{
			get
			{
				if(r_layerMask == null)
				{
					r_layerMask = new(this, "layerMask");
					r_layerMask.SetBelong(this.instance);
				}
				return r_layerMask;
			}
		}

		/// <summary>
		/// System.Int32 shadowCastingModeMask
		/// </summary>
		protected RField r_shadowCastingModeMask;
		public virtual RField RshadowCastingModeMask
		{
			get
			{
				if(r_shadowCastingModeMask == null)
				{
					r_shadowCastingModeMask = new(this, "shadowCastingModeMask");
					r_shadowCastingModeMask.SetBelong(this.instance);
				}
				return r_shadowCastingModeMask;
			}
		}

		/// <summary>
		/// System.Boolean allowOpaqueMaterials
		/// </summary>
		protected RField r_allowOpaqueMaterials;
		public virtual RField RallowOpaqueMaterials
		{
			get
			{
				if(r_allowOpaqueMaterials == null)
				{
					r_allowOpaqueMaterials = new(this, "allowOpaqueMaterials");
					r_allowOpaqueMaterials.SetBelong(this.instance);
				}
				return r_allowOpaqueMaterials;
			}
		}

		/// <summary>
		/// System.Boolean allowTransparentMaterials
		/// </summary>
		protected RField r_allowTransparentMaterials;
		public virtual RField RallowTransparentMaterials
		{
			get
			{
				if(r_allowTransparentMaterials == null)
				{
					r_allowTransparentMaterials = new(this, "allowTransparentMaterials");
					r_allowTransparentMaterials.SetBelong(this.instance);
				}
				return r_allowTransparentMaterials;
			}
		}

		/// <summary>
		/// System.Boolean allowAlphaTestedMaterials
		/// </summary>
		protected RField r_allowAlphaTestedMaterials;
		public virtual RField RallowAlphaTestedMaterials
		{
			get
			{
				if(r_allowAlphaTestedMaterials == null)
				{
					r_allowAlphaTestedMaterials = new(this, "allowAlphaTestedMaterials");
					r_allowAlphaTestedMaterials.SetBelong(this.instance);
				}
				return r_allowAlphaTestedMaterials;
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


        public RRayTracingInstanceCullingTest() : base("UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest")
        {
        }

        public RRayTracingInstanceCullingTest(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest")
		{
            SetInstance(instance);
		}

        public RRayTracingInstanceCullingTest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRayTracingInstanceCullingTest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
