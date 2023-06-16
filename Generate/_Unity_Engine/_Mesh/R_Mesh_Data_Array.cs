
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RMesh
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Mesh+MeshDataArray
	/// </summary>
    public partial class RMeshDataArray : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray");
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


		/// <summary>
		/// System.IntPtr* m_Ptrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RIntPtr> r_Fm_Ptrs;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RSystem.RIntPtr> RFm_Ptrs
		{
			get
			{
				if(r_Fm_Ptrs == null)
				{
					r_Fm_Ptrs = new(this, "m_Ptrs");
				}
				return r_Fm_Ptrs;
			}
		}

		/// <summary>
		/// System.Int32 m_Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Length;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Length
		{
			get
			{
				if(r_Fm_Length == null)
				{
					r_Fm_Length = new(this, "m_Length");
				}
				return r_Fm_Length;
			}
		}

		/// <summary>
		/// System.Int32 m_MinIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MinIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MinIndex
		{
			get
			{
				if(r_Fm_MinIndex == null)
				{
					r_Fm_MinIndex = new(this, "m_MinIndex");
				}
				return r_Fm_MinIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaxIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaxIndex
		{
			get
			{
				if(r_Fm_MaxIndex == null)
				{
					r_Fm_MaxIndex = new(this, "m_MaxIndex");
				}
				return r_Fm_MaxIndex;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle m_Safety
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle r_Fm_Safety;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RLowLevel.RUnsafe.RAtomicSafetyHandle RFm_Safety
		{
			get
			{
				if(r_Fm_Safety == null)
				{
					r_Fm_Safety = new(this, "m_Safety");
				}
				return r_Fm_Safety;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// MeshData Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshData r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshData RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Void AcquireReadOnlyMeshData(UnityEngine.Mesh, IntPtr*)
		/// </summary>
		protected static RMethod r_MAcquireReadOnlyMeshData_Mesh_IntPtrPointer;
		public static RMethod RMAcquireReadOnlyMeshData_Mesh_IntPtrPointer
		{
			get
			{
				if(r_MAcquireReadOnlyMeshData_Mesh_IntPtrPointer == null)
				{
					r_MAcquireReadOnlyMeshData_Mesh_IntPtrPointer = new(Type, "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh), typeof(System.IntPtr).MakePointerType());
				}
				return r_MAcquireReadOnlyMeshData_Mesh_IntPtrPointer;
			}
		}

		/// <summary>
		/// Void AcquireReadOnlyMeshDatas(UnityEngine.Mesh[], IntPtr*, Int32)
		/// </summary>
		protected static RMethod r_MAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32;
		public static RMethod RMAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32
		{
			get
			{
				if(r_MAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32 == null)
				{
					r_MAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32 = new(Type, "AcquireReadOnlyMeshDatas", 0, typeof(UnityEngine.Mesh).MakeArrayType(), typeof(System.IntPtr).MakePointerType(), typeof(System.Int32));
				}
				return r_MAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32;
			}
		}

		/// <summary>
		/// Void ReleaseMeshDatas(IntPtr*, Int32)
		/// </summary>
		protected static RMethod r_MReleaseMeshDatas_IntPtrPointer_Int32;
		public static RMethod RMReleaseMeshDatas_IntPtrPointer_Int32
		{
			get
			{
				if(r_MReleaseMeshDatas_IntPtrPointer_Int32 == null)
				{
					r_MReleaseMeshDatas_IntPtrPointer_Int32 = new(Type, "ReleaseMeshDatas", 0, typeof(System.IntPtr).MakePointerType(), typeof(System.Int32));
				}
				return r_MReleaseMeshDatas_IntPtrPointer_Int32;
			}
		}

		/// <summary>
		/// Void CreateNewMeshDatas(IntPtr*, Int32)
		/// </summary>
		protected static RMethod r_MCreateNewMeshDatas_IntPtrPointer_Int32;
		public static RMethod RMCreateNewMeshDatas_IntPtrPointer_Int32
		{
			get
			{
				if(r_MCreateNewMeshDatas_IntPtrPointer_Int32 == null)
				{
					r_MCreateNewMeshDatas_IntPtrPointer_Int32 = new(Type, "CreateNewMeshDatas", 0, typeof(System.IntPtr).MakePointerType(), typeof(System.Int32));
				}
				return r_MCreateNewMeshDatas_IntPtrPointer_Int32;
			}
		}

		/// <summary>
		/// Void ApplyToMeshesImpl(UnityEngine.Mesh[], IntPtr*, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags;
		public static RMethod RMApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags == null)
				{
					r_MApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags = new(Type, "ApplyToMeshesImpl", 0, typeof(UnityEngine.Mesh).MakeArrayType(), typeof(System.IntPtr).MakePointerType(), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyToMeshImpl(UnityEngine.Mesh, IntPtr, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags;
		public static RMethod RMApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags
		{
			get
			{
				if(r_MApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags == null)
				{
					r_MApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags = new(Type, "ApplyToMeshImpl", 0, typeof(UnityEngine.Mesh), typeof(System.IntPtr), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags;
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
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void ApplyToMeshAndDispose(UnityEngine.Mesh, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MApplyToMeshAndDispose_Mesh_MeshUpdateFlags;
		public virtual RMethod RMApplyToMeshAndDispose_Mesh_MeshUpdateFlags
		{
			get
			{
				if(r_MApplyToMeshAndDispose_Mesh_MeshUpdateFlags == null)
				{
					r_MApplyToMeshAndDispose_Mesh_MeshUpdateFlags = new(this, "ApplyToMeshAndDispose", 0, typeof(UnityEngine.Mesh), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyToMeshAndDispose_Mesh_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyToMeshesAndDispose(UnityEngine.Mesh[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags;
		public virtual RMethod RMApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags
		{
			get
			{
				if(r_MApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags == null)
				{
					r_MApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags = new(this, "ApplyToMeshesAndDispose", 0, typeof(UnityEngine.Mesh).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void CheckElementReadAccess(Int32)
		/// </summary>
		protected RMethod r_MCheckElementReadAccess_Int32;
		public virtual RMethod RMCheckElementReadAccess_Int32
		{
			get
			{
				if(r_MCheckElementReadAccess_Int32 == null)
				{
					r_MCheckElementReadAccess_Int32 = new(this, "CheckElementReadAccess", 0, typeof(System.Int32));
				}
				return r_MCheckElementReadAccess_Int32;
			}
		}

		/// <summary>
		/// Void FailOutOfRangeError(Int32)
		/// </summary>
		protected RMethod r_MFailOutOfRangeError_Int32;
		public virtual RMethod RMFailOutOfRangeError_Int32
		{
			get
			{
				if(r_MFailOutOfRangeError_Int32 == null)
				{
					r_MFailOutOfRangeError_Int32 = new(this, "FailOutOfRangeError", 0, typeof(System.Int32));
				}
				return r_MFailOutOfRangeError_Int32;
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


        public unsafe static void AcquireReadOnlyMeshData(UnityEngine.Mesh @mesh, System.IntPtr* @datas)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, Pointer.Box(@datas, typeof(System.IntPtr))};
            var ___result = RMAcquireReadOnlyMeshData_Mesh_IntPtrPointer.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void AcquireReadOnlyMeshDatas(UnityEngine.Mesh[] @meshes, System.IntPtr* @datas, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes, Pointer.Box(@datas, typeof(System.IntPtr)), @count};
            var ___result = RMAcquireReadOnlyMeshDatas_MeshArray_IntPtrPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void ReleaseMeshDatas(System.IntPtr* @datas, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@datas, typeof(System.IntPtr)), @count};
            var ___result = RMReleaseMeshDatas_IntPtrPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void CreateNewMeshDatas(System.IntPtr* @datas, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@datas, typeof(System.IntPtr)), @count};
            var ___result = RMCreateNewMeshDatas_IntPtrPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static void ApplyToMeshesImpl(UnityEngine.Mesh[] @meshes, System.IntPtr* @datas, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes, Pointer.Box(@datas, typeof(System.IntPtr)), @count, @flags};
            var ___result = RMApplyToMeshesImpl_MeshArray_IntPtrPointer_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyToMeshImpl(UnityEngine.Mesh @mesh, System.IntPtr @data, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @data, @flags};
            var ___result = RMApplyToMeshImpl_Mesh_IntPtr_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyToMeshAndDispose(UnityEngine.Mesh @mesh, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh, @flags};
            var ___result = RMApplyToMeshAndDispose_Mesh_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyToMeshesAndDispose(UnityEngine.Mesh[] @meshes, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes, @flags};
            var ___result = RMApplyToMeshesAndDispose_MeshArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElementReadAccess(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMCheckElementReadAccess_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FailOutOfRangeError(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMFailOutOfRangeError_Int32.Invoke(___genericsType, ___parameters);

            
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
}