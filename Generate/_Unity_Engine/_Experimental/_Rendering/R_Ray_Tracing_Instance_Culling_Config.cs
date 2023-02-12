
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingFlags r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingFlags RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 sphereCenter
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_FsphereCenter;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFsphereCenter
		{
			get
			{
				if(r_FsphereCenter == null)
				{
					r_FsphereCenter = new(this, "sphereCenter");
					r_FsphereCenter.SetBelong(this.instance);
				}
				return r_FsphereCenter;
			}
		}

		/// <summary>
		/// System.Single sphereRadius
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FsphereRadius;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFsphereRadius
		{
			get
			{
				if(r_FsphereRadius == null)
				{
					r_FsphereRadius = new(this, "sphereRadius");
					r_FsphereRadius.SetBelong(this.instance);
				}
				return r_FsphereRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Plane[] planes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RPlane> r_Fplanes;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RPlane> RFplanes
		{
			get
			{
				if(r_Fplanes == null)
				{
					r_Fplanes = new(this, "planes");
					r_Fplanes.SetBelong(this.instance);
				}
				return r_Fplanes;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest[] instanceTests
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingTest> r_FinstanceTests;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingTest> RFinstanceTests
		{
			get
			{
				if(r_FinstanceTests == null)
				{
					r_FinstanceTests = new(this, "instanceTests");
					r_FinstanceTests.SetBelong(this.instance);
				}
				return r_FinstanceTests;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingMaterialTest materialTest
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingMaterialTest r_FmaterialTest;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingMaterialTest RFmaterialTest
		{
			get
			{
				if(r_FmaterialTest == null)
				{
					r_FmaterialTest = new(this, "materialTest");
					r_FmaterialTest.SetBelong(this.instance);
				}
				return r_FmaterialTest;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig transparentMaterialConfig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig r_FtransparentMaterialConfig;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig RFtransparentMaterialConfig
		{
			get
			{
				if(r_FtransparentMaterialConfig == null)
				{
					r_FtransparentMaterialConfig = new(this, "transparentMaterialConfig");
					r_FtransparentMaterialConfig.SetBelong(this.instance);
				}
				return r_FtransparentMaterialConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig alphaTestedMaterialConfig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig r_FalphaTestedMaterialConfig;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig RFalphaTestedMaterialConfig
		{
			get
			{
				if(r_FalphaTestedMaterialConfig == null)
				{
					r_FalphaTestedMaterialConfig = new(this, "alphaTestedMaterialConfig");
					r_FalphaTestedMaterialConfig.SetBelong(this.instance);
				}
				return r_FalphaTestedMaterialConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingSubMeshFlagsConfig subMeshFlagsConfig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingSubMeshFlagsConfig r_FsubMeshFlagsConfig;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingSubMeshFlagsConfig RFsubMeshFlagsConfig
		{
			get
			{
				if(r_FsubMeshFlagsConfig == null)
				{
					r_FsubMeshFlagsConfig = new(this, "subMeshFlagsConfig");
					r_FsubMeshFlagsConfig.SetBelong(this.instance);
				}
				return r_FsubMeshFlagsConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig triangleCullingConfig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceTriangleCullingConfig r_FtriangleCullingConfig;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceTriangleCullingConfig RFtriangleCullingConfig
		{
			get
			{
				if(r_FtriangleCullingConfig == null)
				{
					r_FtriangleCullingConfig = new(this, "triangleCullingConfig");
					r_FtriangleCullingConfig.SetBelong(this.instance);
				}
				return r_FtriangleCullingConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters lodParameters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RLODParameters r_FlodParameters;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RLODParameters RFlodParameters
		{
			get
			{
				if(r_FlodParameters == null)
				{
					r_FlodParameters = new(this, "lodParameters");
					r_FlodParameters.SetBelong(this.instance);
				}
				return r_FlodParameters;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
