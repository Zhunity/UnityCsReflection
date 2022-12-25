using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.DetachedAllocator
	/// </summary>
    public partial class RDetachedAllocator : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] m_VertsPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> r_m_VertsPool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> Rm_VertsPool
		{
			get
			{
				if(r_m_VertsPool == null)
				{
					r_m_VertsPool = new(this, "m_VertsPool");
					r_m_VertsPool.SetBelong(this.instance);
				}
				return r_m_VertsPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] m_IndexPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> r_m_IndexPool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> Rm_IndexPool
		{
			get
			{
				if(r_m_IndexPool == null)
				{
					r_m_IndexPool = new(this, "m_IndexPool");
					r_m_IndexPool.SetBelong(this.instance);
				}
				return r_m_IndexPool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.MeshWriteData] m_MeshWriteDataPool
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RMeshWriteData> r_m_MeshWriteDataPool;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RMeshWriteData> Rm_MeshWriteDataPool
		{
			get
			{
				if(r_m_MeshWriteDataPool == null)
				{
					r_m_MeshWriteDataPool = new(this, "m_MeshWriteDataPool");
					r_m_MeshWriteDataPool.SetBelong(this.instance);
				}
				return r_m_MeshWriteDataPool;
			}
		}

		/// <summary>
		/// System.Int32 m_MeshWriteDataCount
		/// </summary>
		protected RField r_m_MeshWriteDataCount;
		public virtual RField Rm_MeshWriteDataCount
		{
			get
			{
				if(r_m_MeshWriteDataCount == null)
				{
					r_m_MeshWriteDataCount = new(this, "m_MeshWriteDataCount");
					r_m_MeshWriteDataCount.SetBelong(this.instance);
				}
				return r_m_MeshWriteDataCount;
			}
		}

		/// <summary>
		/// System.Boolean m_Disposed
		/// </summary>
		protected RField r_m_Disposed;
		public virtual RField Rm_Disposed
		{
			get
			{
				if(r_m_Disposed == null)
				{
					r_m_Disposed = new(this, "m_Disposed");
					r_m_Disposed.SetBelong(this.instance);
				}
				return r_m_Disposed;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.MeshWriteData] meshes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RMeshWriteData> r_meshes;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RMeshWriteData> Rmeshes
		{
			get
			{
				if(r_meshes == null)
				{
					r_meshes = new(this, "meshes", -1);
					r_meshes.SetBelong(this.instance);
				}
				return r_meshes;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Alloc(Int32, Int32)
		/// </summary>
		protected RMethod r_RAlloc_Int32_Int32;
		public virtual RMethod RAlloc_Int32_Int32
		{
			get
			{
				if(r_RAlloc_Int32_Int32 == null)
				{
					r_RAlloc_Int32_Int32 = new(this, "Alloc", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAlloc_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAlloc_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
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


        public RDetachedAllocator() : base("UnityEngine.UIElements.UIR.DetachedAllocator")
        {
        }

        public RDetachedAllocator(System.Object instance) : base("UnityEngine.UIElements.UIR.DetachedAllocator")
		{
            SetInstance(instance);
		}

        public RDetachedAllocator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDetachedAllocator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.MeshWriteData Alloc(System.Int32  @vertexCount, System.Int32  @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount};
            var ___result = RAlloc_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
