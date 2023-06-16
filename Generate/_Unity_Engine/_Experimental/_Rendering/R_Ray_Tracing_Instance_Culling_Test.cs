
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest
	/// </summary>
    public partial class RRayTracingInstanceCullingTest : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest);
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


		/// <summary>
		/// System.UInt32 instanceMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FinstanceMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFinstanceMask
		{
			get
			{
				if(r_FinstanceMask == null)
				{
					r_FinstanceMask = new(this, "instanceMask");
				}
				return r_FinstanceMask;
			}
		}

		/// <summary>
		/// System.Int32 layerMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FlayerMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlayerMask
		{
			get
			{
				if(r_FlayerMask == null)
				{
					r_FlayerMask = new(this, "layerMask");
				}
				return r_FlayerMask;
			}
		}

		/// <summary>
		/// System.Int32 shadowCastingModeMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FshadowCastingModeMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFshadowCastingModeMask
		{
			get
			{
				if(r_FshadowCastingModeMask == null)
				{
					r_FshadowCastingModeMask = new(this, "shadowCastingModeMask");
				}
				return r_FshadowCastingModeMask;
			}
		}

		/// <summary>
		/// System.Boolean allowOpaqueMaterials
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FallowOpaqueMaterials;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFallowOpaqueMaterials
		{
			get
			{
				if(r_FallowOpaqueMaterials == null)
				{
					r_FallowOpaqueMaterials = new(this, "allowOpaqueMaterials");
				}
				return r_FallowOpaqueMaterials;
			}
		}

		/// <summary>
		/// System.Boolean allowTransparentMaterials
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FallowTransparentMaterials;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFallowTransparentMaterials
		{
			get
			{
				if(r_FallowTransparentMaterials == null)
				{
					r_FallowTransparentMaterials = new(this, "allowTransparentMaterials");
				}
				return r_FallowTransparentMaterials;
			}
		}

		/// <summary>
		/// System.Boolean allowAlphaTestedMaterials
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FallowAlphaTestedMaterials;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFallowAlphaTestedMaterials
		{
			get
			{
				if(r_FallowAlphaTestedMaterials == null)
				{
					r_FallowAlphaTestedMaterials = new(this, "allowAlphaTestedMaterials");
				}
				return r_FallowAlphaTestedMaterials;
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
