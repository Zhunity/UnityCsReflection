using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig
	/// </summary>
    public partial class RRayTracingInstanceCullingConfig : RMember //
    {

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingFlags flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 sphereCenter
		/// </summary>
		protected RUnityEngine.RVector3 r_sphereCenter;
		public virtual RUnityEngine.RVector3 RsphereCenter
		{
			get
			{
				if(r_sphereCenter == null)
				{
					r_sphereCenter = new(this, "sphereCenter");
					r_sphereCenter.SetBelong(this.instance);
				}
				return r_sphereCenter;
			}
		}

		/// <summary>
		/// System.Single sphereRadius
		/// </summary>
		protected RField r_sphereRadius;
		public virtual RField RsphereRadius
		{
			get
			{
				if(r_sphereRadius == null)
				{
					r_sphereRadius = new(this, "sphereRadius");
					r_sphereRadius.SetBelong(this.instance);
				}
				return r_sphereRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Plane[] planes
		/// </summary>
		protected RFieldArray<RUnityEngine.RPlane> r_planes;
		public virtual RFieldArray<RUnityEngine.RPlane> Rplanes
		{
			get
			{
				if(r_planes == null)
				{
					r_planes = new(this, "planes");
					r_planes.SetBelong(this.instance);
				}
				return r_planes;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest[] instanceTests
		/// </summary>
		protected RFieldArray<RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingTest> r_instanceTests;
		public virtual RFieldArray<RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingTest> RinstanceTests
		{
			get
			{
				if(r_instanceTests == null)
				{
					r_instanceTests = new(this, "instanceTests");
					r_instanceTests.SetBelong(this.instance);
				}
				return r_instanceTests;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingMaterialTest materialTest
		/// </summary>
		protected RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingMaterialTest r_materialTest;
		public virtual RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingMaterialTest RmaterialTest
		{
			get
			{
				if(r_materialTest == null)
				{
					r_materialTest = new(this, "materialTest");
					r_materialTest.SetBelong(this.instance);
				}
				return r_materialTest;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig transparentMaterialConfig
		/// </summary>
		protected RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig r_transparentMaterialConfig;
		public virtual RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig RtransparentMaterialConfig
		{
			get
			{
				if(r_transparentMaterialConfig == null)
				{
					r_transparentMaterialConfig = new(this, "transparentMaterialConfig");
					r_transparentMaterialConfig.SetBelong(this.instance);
				}
				return r_transparentMaterialConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig alphaTestedMaterialConfig
		/// </summary>
		protected RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig r_alphaTestedMaterialConfig;
		public virtual RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig RalphaTestedMaterialConfig
		{
			get
			{
				if(r_alphaTestedMaterialConfig == null)
				{
					r_alphaTestedMaterialConfig = new(this, "alphaTestedMaterialConfig");
					r_alphaTestedMaterialConfig.SetBelong(this.instance);
				}
				return r_alphaTestedMaterialConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingSubMeshFlagsConfig subMeshFlagsConfig
		/// </summary>
		protected RUnityEngine.RExperimental.RRendering.RRayTracingSubMeshFlagsConfig r_subMeshFlagsConfig;
		public virtual RUnityEngine.RExperimental.RRendering.RRayTracingSubMeshFlagsConfig RsubMeshFlagsConfig
		{
			get
			{
				if(r_subMeshFlagsConfig == null)
				{
					r_subMeshFlagsConfig = new(this, "subMeshFlagsConfig");
					r_subMeshFlagsConfig.SetBelong(this.instance);
				}
				return r_subMeshFlagsConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig triangleCullingConfig
		/// </summary>
		protected RUnityEngine.RExperimental.RRendering.RRayTracingInstanceTriangleCullingConfig r_triangleCullingConfig;
		public virtual RUnityEngine.RExperimental.RRendering.RRayTracingInstanceTriangleCullingConfig RtriangleCullingConfig
		{
			get
			{
				if(r_triangleCullingConfig == null)
				{
					r_triangleCullingConfig = new(this, "triangleCullingConfig");
					r_triangleCullingConfig.SetBelong(this.instance);
				}
				return r_triangleCullingConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters lodParameters
		/// </summary>
		protected RUnityEngine.RRendering.RLODParameters r_lodParameters;
		public virtual RUnityEngine.RRendering.RLODParameters RlodParameters
		{
			get
			{
				if(r_lodParameters == null)
				{
					r_lodParameters = new(this, "lodParameters");
					r_lodParameters.SetBelong(this.instance);
				}
				return r_lodParameters;
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


        public RRayTracingInstanceCullingConfig() : base("UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig")
        {
        }

        public RRayTracingInstanceCullingConfig(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig")
		{
            SetInstance(instance);
		}

        public RRayTracingInstanceCullingConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRayTracingInstanceCullingConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
