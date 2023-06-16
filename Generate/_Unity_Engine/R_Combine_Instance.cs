
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.CombineInstance
	/// </summary>
    public partial class RCombineInstance : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.CombineInstance);
            }
        }

        public RCombineInstance() : base("UnityEngine.CombineInstance")
        {
        }

        public RCombineInstance(System.Object instance) : base("UnityEngine.CombineInstance")
		{
            SetInstance(instance);
		}

        public RCombineInstance(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCombineInstance(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 m_MeshInstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MeshInstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MeshInstanceID
		{
			get
			{
				if(r_Fm_MeshInstanceID == null)
				{
					r_Fm_MeshInstanceID = new(this, "m_MeshInstanceID");
				}
				return r_Fm_MeshInstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_SubMeshIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_SubMeshIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_SubMeshIndex
		{
			get
			{
				if(r_Fm_SubMeshIndex == null)
				{
					r_Fm_SubMeshIndex = new(this, "m_SubMeshIndex");
				}
				return r_Fm_SubMeshIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_Transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_Fm_Transform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFm_Transform
		{
			get
			{
				if(r_Fm_Transform == null)
				{
					r_Fm_Transform = new(this, "m_Transform");
				}
				return r_Fm_Transform;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 m_LightmapScaleOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Fm_LightmapScaleOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFm_LightmapScaleOffset
		{
			get
			{
				if(r_Fm_LightmapScaleOffset == null)
				{
					r_Fm_LightmapScaleOffset = new(this, "m_LightmapScaleOffset");
				}
				return r_Fm_LightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 m_RealtimeLightmapScaleOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Fm_RealtimeLightmapScaleOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFm_RealtimeLightmapScaleOffset
		{
			get
			{
				if(r_Fm_RealtimeLightmapScaleOffset == null)
				{
					r_Fm_RealtimeLightmapScaleOffset = new(this, "m_RealtimeLightmapScaleOffset");
				}
				return r_Fm_RealtimeLightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh mesh
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMesh r_Pmesh;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMesh RPmesh
		{
			get
			{
				if(r_Pmesh == null)
				{
					r_Pmesh = new(this, "mesh", -1);
				}
				return r_Pmesh;
			}
		}

		/// <summary>
		/// Int32 subMeshIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsubMeshIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsubMeshIndex
		{
			get
			{
				if(r_PsubMeshIndex == null)
				{
					r_PsubMeshIndex = new(this, "subMeshIndex", -1);
				}
				return r_PsubMeshIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_Ptransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 lightmapScaleOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PlightmapScaleOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPlightmapScaleOffset
		{
			get
			{
				if(r_PlightmapScaleOffset == null)
				{
					r_PlightmapScaleOffset = new(this, "lightmapScaleOffset", -1);
				}
				return r_PlightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 realtimeLightmapScaleOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_PrealtimeLightmapScaleOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector4 RPrealtimeLightmapScaleOffset
		{
			get
			{
				if(r_PrealtimeLightmapScaleOffset == null)
				{
					r_PrealtimeLightmapScaleOffset = new(this, "realtimeLightmapScaleOffset", -1);
				}
				return r_PrealtimeLightmapScaleOffset;
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
