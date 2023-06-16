
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig
	/// </summary>
    public partial class RRayTracingInstanceCullingConfig : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Experimental.Rendering.RayTracingInstanceCullingConfig);
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


		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingFlags flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingFlags r_Fflags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingFlags RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 sphereCenter
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_FsphereCenter;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFsphereCenter
		{
			get
			{
				if(r_FsphereCenter == null)
				{
					r_FsphereCenter = new(this, "sphereCenter");
				}
				return r_FsphereCenter;
			}
		}

		/// <summary>
		/// System.Single sphereRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FsphereRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFsphereRadius
		{
			get
			{
				if(r_FsphereRadius == null)
				{
					r_FsphereRadius = new(this, "sphereRadius");
				}
				return r_FsphereRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Plane[] planes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RPlane> r_Fplanes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RPlane> RFplanes
		{
			get
			{
				if(r_Fplanes == null)
				{
					r_Fplanes = new(this, "planes");
				}
				return r_Fplanes;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingTest[] instanceTests
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingTest> r_FinstanceTests;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingTest> RFinstanceTests
		{
			get
			{
				if(r_FinstanceTests == null)
				{
					r_FinstanceTests = new(this, "instanceTests");
				}
				return r_FinstanceTests;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingMaterialTest materialTest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingMaterialTest r_FmaterialTest;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingMaterialTest RFmaterialTest
		{
			get
			{
				if(r_FmaterialTest == null)
				{
					r_FmaterialTest = new(this, "materialTest");
				}
				return r_FmaterialTest;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig transparentMaterialConfig
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig r_FtransparentMaterialConfig;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig RFtransparentMaterialConfig
		{
			get
			{
				if(r_FtransparentMaterialConfig == null)
				{
					r_FtransparentMaterialConfig = new(this, "transparentMaterialConfig");
				}
				return r_FtransparentMaterialConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig alphaTestedMaterialConfig
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig r_FalphaTestedMaterialConfig;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceMaterialConfig RFalphaTestedMaterialConfig
		{
			get
			{
				if(r_FalphaTestedMaterialConfig == null)
				{
					r_FalphaTestedMaterialConfig = new(this, "alphaTestedMaterialConfig");
				}
				return r_FalphaTestedMaterialConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingSubMeshFlagsConfig subMeshFlagsConfig
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingSubMeshFlagsConfig r_FsubMeshFlagsConfig;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingSubMeshFlagsConfig RFsubMeshFlagsConfig
		{
			get
			{
				if(r_FsubMeshFlagsConfig == null)
				{
					r_FsubMeshFlagsConfig = new(this, "subMeshFlagsConfig");
				}
				return r_FsubMeshFlagsConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceTriangleCullingConfig triangleCullingConfig
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceTriangleCullingConfig r_FtriangleCullingConfig;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceTriangleCullingConfig RFtriangleCullingConfig
		{
			get
			{
				if(r_FtriangleCullingConfig == null)
				{
					r_FtriangleCullingConfig = new(this, "triangleCullingConfig");
				}
				return r_FtriangleCullingConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LODParameters lodParameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLODParameters r_FlodParameters;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RLODParameters RFlodParameters
		{
			get
			{
				if(r_FlodParameters == null)
				{
					r_FlodParameters = new(this, "lodParameters");
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
