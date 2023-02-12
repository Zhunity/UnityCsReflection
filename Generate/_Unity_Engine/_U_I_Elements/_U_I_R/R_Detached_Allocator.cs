
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_Fm_VertsPool;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFm_VertsPool
		{
			get
			{
				if(r_Fm_VertsPool == null)
				{
					r_Fm_VertsPool = new(this, "m_VertsPool");
					r_Fm_VertsPool.SetBelong(this.instance);
				}
				return r_Fm_VertsPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] m_IndexPool
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<SMFrame.Editor.Refleaction.RSystem.RUInt16> r_Fm_IndexPool;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<SMFrame.Editor.Refleaction.RSystem.RUInt16> RFm_IndexPool
		{
			get
			{
				if(r_Fm_IndexPool == null)
				{
					r_Fm_IndexPool = new(this, "m_IndexPool");
					r_Fm_IndexPool.SetBelong(this.instance);
				}
				return r_Fm_IndexPool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.MeshWriteData] m_MeshWriteDataPool
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteData> r_Fm_MeshWriteDataPool;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteData> RFm_MeshWriteDataPool
		{
			get
			{
				if(r_Fm_MeshWriteDataPool == null)
				{
					r_Fm_MeshWriteDataPool = new(this, "m_MeshWriteDataPool");
					r_Fm_MeshWriteDataPool.SetBelong(this.instance);
				}
				return r_Fm_MeshWriteDataPool;
			}
		}

		/// <summary>
		/// System.Int32 m_MeshWriteDataCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_MeshWriteDataCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_MeshWriteDataCount
		{
			get
			{
				if(r_Fm_MeshWriteDataCount == null)
				{
					r_Fm_MeshWriteDataCount = new(this, "m_MeshWriteDataCount");
					r_Fm_MeshWriteDataCount.SetBelong(this.instance);
				}
				return r_Fm_MeshWriteDataCount;
			}
		}

		/// <summary>
		/// System.Boolean m_Disposed
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Disposed;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Disposed
		{
			get
			{
				if(r_Fm_Disposed == null)
				{
					r_Fm_Disposed = new(this, "m_Disposed");
					r_Fm_Disposed.SetBelong(this.instance);
				}
				return r_Fm_Disposed;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.MeshWriteData] meshes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteData> r_Pmeshes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteData> RPmeshes
		{
			get
			{
				if(r_Pmeshes == null)
				{
					r_Pmeshes = new(this, "meshes", -1);
					r_Pmeshes.SetBelong(this.instance);
				}
				return r_Pmeshes;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Alloc(Int32, Int32)
		/// </summary>
		protected RMethod r_MAlloc_Int32_Int32;
		public virtual RMethod RMAlloc_Int32_Int32
		{
			get
			{
				if(r_MAlloc_Int32_Int32 == null)
				{
					r_MAlloc_Int32_Int32 = new(this, "Alloc", 0, typeof(System.Int32), typeof(System.Int32));
					r_MAlloc_Int32_Int32.SetBelong(this.instance);
				}
				return r_MAlloc_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
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
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.MeshWriteData Alloc(System.Int32 @vertexCount, System.Int32 @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount};
            var ___result = RMAlloc_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
