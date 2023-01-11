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
		protected RSystem.RUInt32 r_instanceMask;
		public virtual RSystem.RUInt32 RinstanceMask
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
		protected RSystem.RInt32 r_layerMask;
		public virtual RSystem.RInt32 RlayerMask
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
		protected RSystem.RInt32 r_shadowCastingModeMask;
		public virtual RSystem.RInt32 RshadowCastingModeMask
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
		protected RSystem.RBoolean r_allowOpaqueMaterials;
		public virtual RSystem.RBoolean RallowOpaqueMaterials
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
		protected RSystem.RBoolean r_allowTransparentMaterials;
		public virtual RSystem.RBoolean RallowTransparentMaterials
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
		protected RSystem.RBoolean r_allowAlphaTestedMaterials;
		public virtual RSystem.RBoolean RallowAlphaTestedMaterials
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
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object @obj)
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
