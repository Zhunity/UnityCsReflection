using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RMesh
{
	
	/// <summary>
	/// UnityEngine.Mesh+MeshDataArray
	/// </summary>
    public partial class RMeshDataArray : RMember //
    {

		/// <summary>
		/// System.IntPtr* m_Ptrs
		/// </summary>
		protected RFieldPointer<RField> r_m_Ptrs;
		public virtual RFieldPointer<RField> Rm_Ptrs
		{
			get
			{
				if(r_m_Ptrs == null)
				{
					r_m_Ptrs = new(this, "m_Ptrs");
					r_m_Ptrs.SetBelong(this.instance);
				}
				return r_m_Ptrs;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected RField r_m_Length;
		public virtual RField Rm_Length
		{
			get
			{
				if(r_m_Length == null)
				{
					r_m_Length = new(this, "m_Length");
					r_m_Length.SetBelong(this.instance);
				}
				return r_m_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected RField r_m_MinIndex;
		public virtual RField Rm_MinIndex
		{
			get
			{
				if(r_m_MinIndex == null)
				{
					r_m_MinIndex = new(this, "m_MinIndex");
					r_m_MinIndex.SetBelong(this.instance);
				}
				return r_m_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected RField r_m_MaxIndex;
		public virtual RField Rm_MaxIndex
		{
			get
			{
				if(r_m_MaxIndex == null)
				{
					r_m_MaxIndex = new(this, "m_MaxIndex");
					r_m_MaxIndex.SetBelong(this.instance);
				}
				return r_m_MaxIndex;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_m_Safety;
		public virtual RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle Rm_Safety
		{
			get
			{
				if(r_m_Safety == null)
				{
					r_m_Safety = new(this, "m_Safety");
					r_m_Safety.SetBelong(this.instance);
				}
				return r_m_Safety;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// MeshData Item [Int32]
		/// </summary>
		protected RUnityEngine.RMesh.RMeshData r_Item_Int32;
		public virtual RUnityEngine.RMesh.RMeshData RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Void AcquireReadOnlyMeshData(UnityEngine.Mesh, IntPtr*)
		/// </summary>
		protected static RMethod r_RAcquireReadOnlyMeshData_Mesh_IntPtrPointer;
		public static RMethod RAcquireReadOnlyMeshData_Mesh_IntPtrPointer
		{
			get
			{
				if(r_RAcquireReadOnlyMeshData_Mesh_IntPtrPointer == null)
				{
					r_RAcquireReadOnlyMeshData_Mesh_IntPtrPointer = new( ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh), typeof(System.IntPtr).MakePointerType());
					r_RAcquireReadOnlyMeshData_Mesh_IntPtrPointer.SetBelong(null);
				}
				return r_RAcquireReadOnlyMeshData_Mesh_IntPtrPointer;
			}
		}

		/// <summary>
		/// Void AcquireReadOnlyMeshDatas(UnityEngine.Mesh[], IntPtr*, Int32)
		/// </summary>
		protected static RMethod r_RAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32;
		public static RMethod RAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32
		{
			get
			{
				if(r_RAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32 == null)
				{
					r_RAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32 = new( ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), "AcquireReadOnlyMeshDatas", 0, typeof(UnityEngine.Mesh).MakeArrayType(), typeof(System.IntPtr).MakePointerType(), typeof(System.Int32));
					r_RAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32.SetBelong(null);
				}
				return r_RAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseMeshDatas(IntPtr*, Int32)
		/// </summary>
		protected static RMethod r_RReleaseMeshDatas_IntPtrPointer_Int32;
		public static RMethod RReleaseMeshDatas_IntPtrPointer_Int32
		{
			get
			{
				if(r_RReleaseMeshDatas_IntPtrPointer_Int32 == null)
				{
					r_RReleaseMeshDatas_IntPtrPointer_Int32 = new( ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), "ReleaseMeshDatas", 0, typeof(System.IntPtr).MakePointerType(), typeof(System.Int32));
					r_RReleaseMeshDatas_IntPtrPointer_Int32.SetBelong(null);
				}
				return r_RReleaseMeshDatas_IntPtrPointer_Int32;
			}
		}

		/// <summary>
		/// Void CreateNewMeshDatas(IntPtr*, Int32)
		/// </summary>
		protected static RMethod r_RCreateNewMeshDatas_IntPtrPointer_Int32;
		public static RMethod RCreateNewMeshDatas_IntPtrPointer_Int32
		{
			get
			{
				if(r_RCreateNewMeshDatas_IntPtrPointer_Int32 == null)
				{
					r_RCreateNewMeshDatas_IntPtrPointer_Int32 = new( ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), "CreateNewMeshDatas", 0, typeof(System.IntPtr).MakePointerType(), typeof(System.Int32));
					r_RCreateNewMeshDatas_IntPtrPointer_Int32.SetBelong(null);
				}
				return r_RCreateNewMeshDatas_IntPtrPointer_Int32;
			}
		}

		/// <summary>
		/// Void ApplyToMeshesImpl(UnityEngine.Mesh[], IntPtr*, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_RApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags;
		public static RMethod RApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags == null)
				{
					r_RApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags = new( ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), "ApplyToMeshesImpl", 0, typeof(UnityEngine.Mesh).MakeArrayType(), typeof(System.IntPtr).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags.SetBelong(null);
				}
				return r_RApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyToMeshImpl(UnityEngine.Mesh, IntPtr, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags;
		public static RMethod RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags
		{
			get
			{
				if(r_RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags == null)
				{
					r_RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags = new( ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), "ApplyToMeshImpl", 0, typeof(UnityEngine.Mesh), typeof(System.IntPtr), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags.SetBelong(null);
				}
				return r_RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags;
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
		/// Void ApplyToMeshAndDispose(UnityEngine.Mesh, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RApplyToMeshAndDispose_Mesh_MeshUpdateFlags;
		public virtual RMethod RApplyToMeshAndDispose_Mesh_MeshUpdateFlags
		{
			get
			{
				if(r_RApplyToMeshAndDispose_Mesh_MeshUpdateFlags == null)
				{
					r_RApplyToMeshAndDispose_Mesh_MeshUpdateFlags = new(this, "ApplyToMeshAndDispose", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyToMeshAndDispose_Mesh_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RApplyToMeshAndDispose_Mesh_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyToMeshesAndDispose(UnityEngine.Mesh[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags;
		public virtual RMethod RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags
		{
			get
			{
				if(r_RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags == null)
				{
					r_RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags = new(this, "ApplyToMeshesAndDispose", 0, typeof(UnityEngine.Mesh).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void CheckElementReadAccess(Int32)
		/// </summary>
		protected RMethod r_RCheckElementReadAccess_Int32;
		public virtual RMethod RCheckElementReadAccess_Int32
		{
			get
			{
				if(r_RCheckElementReadAccess_Int32 == null)
				{
					r_RCheckElementReadAccess_Int32 = new(this, "CheckElementReadAccess", 0, typeof(System.Int32));
					r_RCheckElementReadAccess_Int32.SetBelong(this.instance);
				}
				return r_RCheckElementReadAccess_Int32;
			}
		}

		/// <summary>
		/// Void FailOutOfRangeError(Int32)
		/// </summary>
		protected RMethod r_RFailOutOfRangeError_Int32;
		public virtual RMethod RFailOutOfRangeError_Int32
		{
			get
			{
				if(r_RFailOutOfRangeError_Int32 == null)
				{
					r_RFailOutOfRangeError_Int32 = new(this, "FailOutOfRangeError", 0, typeof(System.Int32));
					r_RFailOutOfRangeError_Int32.SetBelong(this.instance);
				}
				return r_RFailOutOfRangeError_Int32;
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


        public RMeshDataArray() : base("UnityEngine.Mesh+MeshDataArray")
        {
        }

        public RMeshDataArray(System.Object instance) : base("UnityEngine.Mesh+MeshDataArray")
		{
            SetInstance(instance);
		}

        public RMeshDataArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshDataArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }






        public static void ApplyToMeshImpl(UnityEngine.Mesh  @mesh, System.IntPtr  @data, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @data, @flags};
            var ___result = RApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyToMeshAndDispose(UnityEngine.Mesh  @mesh, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @flags};
            var ___result = RApplyToMeshAndDispose_Mesh_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyToMeshesAndDispose(UnityEngine.Mesh[]  @meshes, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes, @flags};
            var ___result = RApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElementReadAccess(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RCheckElementReadAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FailOutOfRangeError(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RFailOutOfRangeError_Int32.Invoke(___genericsType, ___parameters);

            
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
}