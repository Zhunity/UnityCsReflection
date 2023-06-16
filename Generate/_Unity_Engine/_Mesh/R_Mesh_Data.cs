
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RMesh
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Mesh+MeshData
	/// </summary>
    public partial class RMeshData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Mesh+MeshData");
            }
        }

        public RMeshData() : base("UnityEngine.Mesh+MeshData")
        {
        }

        public RMeshData(System.Object instance) : base("UnityEngine.Mesh+MeshData")
		{
            SetInstance(instance);
		}

        public RMeshData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
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
		/// Int32 vertexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvertexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvertexCount
		{
			get
			{
				if(r_PvertexCount == null)
				{
					r_PvertexCount = new(this, "vertexCount", -1);
				}
				return r_PvertexCount;
			}
		}

		/// <summary>
		/// Int32 vertexBufferCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvertexBufferCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvertexBufferCount
		{
			get
			{
				if(r_PvertexBufferCount == null)
				{
					r_PvertexBufferCount = new(this, "vertexBufferCount", -1);
				}
				return r_PvertexBufferCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.IndexFormat indexFormat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RIndexFormat r_PindexFormat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RIndexFormat RPindexFormat
		{
			get
			{
				if(r_PindexFormat == null)
				{
					r_PindexFormat = new(this, "indexFormat", -1);
				}
				return r_PindexFormat;
			}
		}

		/// <summary>
		/// Int32 subMeshCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsubMeshCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsubMeshCount
		{
			get
			{
				if(r_PsubMeshCount == null)
				{
					r_PsubMeshCount = new(this, "subMeshCount", -1);
				}
				return r_PsubMeshCount;
			}
		}

		/// <summary>
		/// Boolean HasVertexAttribute(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_MHasVertexAttribute_IntPtr_VertexAttribute;
		public static RMethod RMHasVertexAttribute_IntPtr_VertexAttribute
		{
			get
			{
				if(r_MHasVertexAttribute_IntPtr_VertexAttribute == null)
				{
					r_MHasVertexAttribute_IntPtr_VertexAttribute = new(Type, "HasVertexAttribute", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MHasVertexAttribute_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeDimension(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_MGetVertexAttributeDimension_IntPtr_VertexAttribute;
		public static RMethod RMGetVertexAttributeDimension_IntPtr_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeDimension_IntPtr_VertexAttribute == null)
				{
					r_MGetVertexAttributeDimension_IntPtr_VertexAttribute = new(Type, "GetVertexAttributeDimension", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeDimension_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_MGetVertexAttributeFormat_IntPtr_VertexAttribute;
		public static RMethod RMGetVertexAttributeFormat_IntPtr_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeFormat_IntPtr_VertexAttribute == null)
				{
					r_MGetVertexAttributeFormat_IntPtr_VertexAttribute = new(Type, "GetVertexAttributeFormat", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeFormat_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeStream(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_MGetVertexAttributeStream_IntPtr_VertexAttribute;
		public static RMethod RMGetVertexAttributeStream_IntPtr_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeStream_IntPtr_VertexAttribute == null)
				{
					r_MGetVertexAttributeStream_IntPtr_VertexAttribute = new(Type, "GetVertexAttributeStream", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeStream_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeOffset(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_MGetVertexAttributeOffset_IntPtr_VertexAttribute;
		public static RMethod RMGetVertexAttributeOffset_IntPtr_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeOffset_IntPtr_VertexAttribute == null)
				{
					r_MGetVertexAttributeOffset_IntPtr_VertexAttribute = new(Type, "GetVertexAttributeOffset", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeOffset_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexCount(IntPtr)
		/// </summary>
		protected static RMethod r_MGetVertexCount_IntPtr;
		public static RMethod RMGetVertexCount_IntPtr
		{
			get
			{
				if(r_MGetVertexCount_IntPtr == null)
				{
					r_MGetVertexCount_IntPtr = new(Type, "GetVertexCount", 0, typeof(System.IntPtr));
				}
				return r_MGetVertexCount_IntPtr;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferCount(IntPtr)
		/// </summary>
		protected static RMethod r_MGetVertexBufferCount_IntPtr;
		public static RMethod RMGetVertexBufferCount_IntPtr
		{
			get
			{
				if(r_MGetVertexBufferCount_IntPtr == null)
				{
					r_MGetVertexBufferCount_IntPtr = new(Type, "GetVertexBufferCount", 0, typeof(System.IntPtr));
				}
				return r_MGetVertexBufferCount_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetVertexDataPtr(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MGetVertexDataPtr_IntPtr_Int32;
		public static RMethod RMGetVertexDataPtr_IntPtr_Int32
		{
			get
			{
				if(r_MGetVertexDataPtr_IntPtr_Int32 == null)
				{
					r_MGetVertexDataPtr_IntPtr_Int32 = new(Type, "GetVertexDataPtr", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MGetVertexDataPtr_IntPtr_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetVertexDataSize(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MGetVertexDataSize_IntPtr_Int32;
		public static RMethod RMGetVertexDataSize_IntPtr_Int32
		{
			get
			{
				if(r_MGetVertexDataSize_IntPtr_Int32 == null)
				{
					r_MGetVertexDataSize_IntPtr_Int32 = new(Type, "GetVertexDataSize", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MGetVertexDataSize_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferStride(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MGetVertexBufferStride_IntPtr_Int32;
		public static RMethod RMGetVertexBufferStride_IntPtr_Int32
		{
			get
			{
				if(r_MGetVertexBufferStride_IntPtr_Int32 == null)
				{
					r_MGetVertexBufferStride_IntPtr_Int32 = new(Type, "GetVertexBufferStride", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MGetVertexBufferStride_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void CopyAttributeIntoPtr(IntPtr, UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_MCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr;
		public static RMethod RMCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr
		{
			get
			{
				if(r_MCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr == null)
				{
					r_MCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr = new(Type, "CopyAttributeIntoPtr", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void CopyIndicesIntoPtr(IntPtr, Int32, Boolean, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_MCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr;
		public static RMethod RMCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr
		{
			get
			{
				if(r_MCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr == null)
				{
					r_MCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr = new(Type, "CopyIndicesIntoPtr", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.IndexFormat GetIndexFormat(IntPtr)
		/// </summary>
		protected static RMethod r_MGetIndexFormat_IntPtr;
		public static RMethod RMGetIndexFormat_IntPtr
		{
			get
			{
				if(r_MGetIndexFormat_IntPtr == null)
				{
					r_MGetIndexFormat_IntPtr = new(Type, "GetIndexFormat", 0, typeof(System.IntPtr));
				}
				return r_MGetIndexFormat_IntPtr;
			}
		}

		/// <summary>
		/// Int32 GetIndexCount(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MGetIndexCount_IntPtr_Int32;
		public static RMethod RMGetIndexCount_IntPtr_Int32
		{
			get
			{
				if(r_MGetIndexCount_IntPtr_Int32 == null)
				{
					r_MGetIndexCount_IntPtr_Int32 = new(Type, "GetIndexCount", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MGetIndexCount_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetIndexDataPtr(IntPtr)
		/// </summary>
		protected static RMethod r_MGetIndexDataPtr_IntPtr;
		public static RMethod RMGetIndexDataPtr_IntPtr
		{
			get
			{
				if(r_MGetIndexDataPtr_IntPtr == null)
				{
					r_MGetIndexDataPtr_IntPtr = new(Type, "GetIndexDataPtr", 0, typeof(System.IntPtr));
				}
				return r_MGetIndexDataPtr_IntPtr;
			}
		}

		/// <summary>
		/// UInt64 GetIndexDataSize(IntPtr)
		/// </summary>
		protected static RMethod r_MGetIndexDataSize_IntPtr;
		public static RMethod RMGetIndexDataSize_IntPtr
		{
			get
			{
				if(r_MGetIndexDataSize_IntPtr == null)
				{
					r_MGetIndexDataSize_IntPtr = new(Type, "GetIndexDataSize", 0, typeof(System.IntPtr));
				}
				return r_MGetIndexDataSize_IntPtr;
			}
		}

		/// <summary>
		/// Int32 GetSubMeshCount(IntPtr)
		/// </summary>
		protected static RMethod r_MGetSubMeshCount_IntPtr;
		public static RMethod RMGetSubMeshCount_IntPtr
		{
			get
			{
				if(r_MGetSubMeshCount_IntPtr == null)
				{
					r_MGetSubMeshCount_IntPtr = new(Type, "GetSubMeshCount", 0, typeof(System.IntPtr));
				}
				return r_MGetSubMeshCount_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MGetSubMesh_IntPtr_Int32;
		public static RMethod RMGetSubMesh_IntPtr_Int32
		{
			get
			{
				if(r_MGetSubMesh_IntPtr_Int32 == null)
				{
					r_MGetSubMesh_IntPtr_Int32 = new(Type, "GetSubMesh", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MGetSubMesh_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromPtr(IntPtr, Int32, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32;
		public static RMethod RMSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_MSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32 == null)
				{
					r_MSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32 = new(Type, "SetVertexBufferParamsFromPtr", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromArray(IntPtr, Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected static RMethod r_MSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray;
		public static RMethod RMSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_MSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray == null)
				{
					r_MSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray = new(Type, "SetVertexBufferParamsFromArray", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
				}
				return r_MSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void SetIndexBufferParamsImpl(IntPtr, Int32, UnityEngine.Rendering.IndexFormat)
		/// </summary>
		protected static RMethod r_MSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat;
		public static RMethod RMSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat
		{
			get
			{
				if(r_MSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat == null)
				{
					r_MSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat = new(Type, "SetIndexBufferParamsImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat));
				}
				return r_MSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat;
			}
		}

		/// <summary>
		/// Void SetSubMeshCount(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MSetSubMeshCount_IntPtr_Int32;
		public static RMethod RMSetSubMeshCount_IntPtr_Int32
		{
			get
			{
				if(r_MSetSubMeshCount_IntPtr_Int32 == null)
				{
					r_MSetSubMeshCount_IntPtr_Int32 = new(Type, "SetSubMeshCount", 0, typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MSetSubMeshCount_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMeshImpl(IntPtr, Int32, UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags;
		public static RMethod RMSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_MSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags = new(Type, "SetSubMeshImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferStride(Int32)
		/// </summary>
		protected RMethod r_MGetVertexBufferStride_Int32;
		public virtual RMethod RMGetVertexBufferStride_Int32
		{
			get
			{
				if(r_MGetVertexBufferStride_Int32 == null)
				{
					r_MGetVertexBufferStride_Int32 = new(this, "GetVertexBufferStride", 0, typeof(System.Int32));
				}
				return r_MGetVertexBufferStride_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MHasVertexAttribute_VertexAttribute;
		public virtual RMethod RMHasVertexAttribute_VertexAttribute
		{
			get
			{
				if(r_MHasVertexAttribute_VertexAttribute == null)
				{
					r_MHasVertexAttribute_VertexAttribute = new(this, "HasVertexAttribute", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MHasVertexAttribute_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MGetVertexAttributeDimension_VertexAttribute;
		public virtual RMethod RMGetVertexAttributeDimension_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeDimension_VertexAttribute == null)
				{
					r_MGetVertexAttributeDimension_VertexAttribute = new(this, "GetVertexAttributeDimension", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeDimension_VertexAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MGetVertexAttributeFormat_VertexAttribute;
		public virtual RMethod RMGetVertexAttributeFormat_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeFormat_VertexAttribute == null)
				{
					r_MGetVertexAttributeFormat_VertexAttribute = new(this, "GetVertexAttributeFormat", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeFormat_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MGetVertexAttributeStream_VertexAttribute;
		public virtual RMethod RMGetVertexAttributeStream_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeStream_VertexAttribute == null)
				{
					r_MGetVertexAttributeStream_VertexAttribute = new(this, "GetVertexAttributeStream", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeStream_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MGetVertexAttributeOffset_VertexAttribute;
		public virtual RMethod RMGetVertexAttributeOffset_VertexAttribute
		{
			get
			{
				if(r_MGetVertexAttributeOffset_VertexAttribute == null)
				{
					r_MGetVertexAttributeOffset_VertexAttribute = new(this, "GetVertexAttributeOffset", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetVertexAttributeOffset_VertexAttribute;
			}
		}

		/// <summary>
		/// Void GetVertices(Unity.Collections.NativeArray`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MGetVertices_NativeArray_d_Vector3_p_;
		public virtual RMethod RMGetVertices_NativeArray_d_Vector3_p_
		{
			get
			{
				if(r_MGetVertices_NativeArray_d_Vector3_p_ == null)
				{
					r_MGetVertices_NativeArray_d_Vector3_p_ = new(this, "GetVertices", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MGetVertices_NativeArray_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetNormals(Unity.Collections.NativeArray`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MGetNormals_NativeArray_d_Vector3_p_;
		public virtual RMethod RMGetNormals_NativeArray_d_Vector3_p_
		{
			get
			{
				if(r_MGetNormals_NativeArray_d_Vector3_p_ == null)
				{
					r_MGetNormals_NativeArray_d_Vector3_p_ = new(this, "GetNormals", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MGetNormals_NativeArray_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetTangents(Unity.Collections.NativeArray`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MGetTangents_NativeArray_d_Vector4_p_;
		public virtual RMethod RMGetTangents_NativeArray_d_Vector4_p_
		{
			get
			{
				if(r_MGetTangents_NativeArray_d_Vector4_p_ == null)
				{
					r_MGetTangents_NativeArray_d_Vector4_p_ = new(this, "GetTangents", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MGetTangents_NativeArray_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetColors(Unity.Collections.NativeArray`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MGetColors_NativeArray_d_Color_p_;
		public virtual RMethod RMGetColors_NativeArray_d_Color_p_
		{
			get
			{
				if(r_MGetColors_NativeArray_d_Color_p_ == null)
				{
					r_MGetColors_NativeArray_d_Color_p_ = new(this, "GetColors", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MGetColors_NativeArray_d_Color_p_;
			}
		}

		/// <summary>
		/// Void GetColors(Unity.Collections.NativeArray`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_MGetColors_NativeArray_d_Color32_p_;
		public virtual RMethod RMGetColors_NativeArray_d_Color32_p_
		{
			get
			{
				if(r_MGetColors_NativeArray_d_Color32_p_ == null)
				{
					r_MGetColors_NativeArray_d_Color32_p_ = new(this, "GetColors", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Color32)));
				}
				return r_MGetColors_NativeArray_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, Unity.Collections.NativeArray`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MGetUVs_Int32_NativeArray_d_Vector2_p_;
		public virtual RMethod RMGetUVs_Int32_NativeArray_d_Vector2_p_
		{
			get
			{
				if(r_MGetUVs_Int32_NativeArray_d_Vector2_p_ == null)
				{
					r_MGetUVs_Int32_NativeArray_d_Vector2_p_ = new(this, "GetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Vector2)));
				}
				return r_MGetUVs_Int32_NativeArray_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, Unity.Collections.NativeArray`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MGetUVs_Int32_NativeArray_d_Vector3_p_;
		public virtual RMethod RMGetUVs_Int32_NativeArray_d_Vector3_p_
		{
			get
			{
				if(r_MGetUVs_Int32_NativeArray_d_Vector3_p_ == null)
				{
					r_MGetUVs_Int32_NativeArray_d_Vector3_p_ = new(this, "GetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MGetUVs_Int32_NativeArray_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, Unity.Collections.NativeArray`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MGetUVs_Int32_NativeArray_d_Vector4_p_;
		public virtual RMethod RMGetUVs_Int32_NativeArray_d_Vector4_p_
		{
			get
			{
				if(r_MGetUVs_Int32_NativeArray_d_Vector4_p_ == null)
				{
					r_MGetUVs_Int32_NativeArray_d_Vector4_p_ = new(this, "GetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MGetUVs_Int32_NativeArray_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetVertexData[T](Int32)
		/// </summary>
		protected RMethod r_MGetVertexData_GT_Int32;
		public virtual RMethod RMGetVertexData_GT_Int32
		{
			get
			{
				if(r_MGetVertexData_GT_Int32 == null)
				{
					r_MGetVertexData_GT_Int32 = new(this, "GetVertexData", 1, typeof(System.Int32));
				}
				return r_MGetVertexData_GT_Int32;
			}
		}

		/// <summary>
		/// Void CopyAttributeInto[T](Unity.Collections.NativeArray`1[T], UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_MCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RMCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_MCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_MCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32 = new(this, "CopyAttributeInto", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
				}
				return r_MCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParams(Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_MSetVertexBufferParams_Int32_VertexAttributeDescriptorArray;
		public virtual RMethod RMSetVertexBufferParams_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_MSetVertexBufferParams_Int32_VertexAttributeDescriptorArray == null)
				{
					r_MSetVertexBufferParams_Int32_VertexAttributeDescriptorArray = new(this, "SetVertexBufferParams", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
				}
				return r_MSetVertexBufferParams_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParams(Int32, Unity.Collections.NativeArray`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_MSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RMSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_MSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_ == null)
				{
					r_MSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_ = new(this, "SetVertexBufferParams", 0, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
				}
				return r_MSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Void SetIndexBufferParams(Int32, UnityEngine.Rendering.IndexFormat)
		/// </summary>
		protected RMethod r_MSetIndexBufferParams_Int32_IndexFormat;
		public virtual RMethod RMSetIndexBufferParams_Int32_IndexFormat
		{
			get
			{
				if(r_MSetIndexBufferParams_Int32_IndexFormat == null)
				{
					r_MSetIndexBufferParams_Int32_IndexFormat = new(this, "SetIndexBufferParams", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat));
				}
				return r_MSetIndexBufferParams_Int32_IndexFormat;
			}
		}

		/// <summary>
		/// Void GetIndices(Unity.Collections.NativeArray`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndices_NativeArray_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RMGetIndices_NativeArray_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_MGetIndices_NativeArray_d_UInt16_p__Int32_Boolean == null)
				{
					r_MGetIndices_NativeArray_d_UInt16_p__Int32_Boolean = new(this, "GetIndices", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndices_NativeArray_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(Unity.Collections.NativeArray`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndices_NativeArray_d_Int32_p__Int32_Boolean;
		public virtual RMethod RMGetIndices_NativeArray_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_MGetIndices_NativeArray_d_Int32_p__Int32_Boolean == null)
				{
					r_MGetIndices_NativeArray_d_Int32_p__Int32_Boolean = new(this, "GetIndices", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndices_NativeArray_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetIndexData[T]()
		/// </summary>
		protected RMethod r_MGetIndexData_GT;
		public virtual RMethod RMGetIndexData_GT
		{
			get
			{
				if(r_MGetIndexData_GT == null)
				{
					r_MGetIndexData_GT = new(this, "GetIndexData", 1);
				}
				return r_MGetIndexData_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(Int32)
		/// </summary>
		protected RMethod r_MGetSubMesh_Int32;
		public virtual RMethod RMGetSubMesh_Int32
		{
			get
			{
				if(r_MGetSubMesh_Int32 == null)
				{
					r_MGetSubMesh_Int32 = new(this, "GetSubMesh", 0, typeof(System.Int32));
				}
				return r_MGetSubMesh_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMesh(Int32, UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags;
		public virtual RMethod RMSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_MSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags = new(this, "SetSubMesh", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void CheckReadAccess()
		/// </summary>
		protected RMethod r_MCheckReadAccess;
		public virtual RMethod RMCheckReadAccess
		{
			get
			{
				if(r_MCheckReadAccess == null)
				{
					r_MCheckReadAccess = new(this, "CheckReadAccess", 0);
				}
				return r_MCheckReadAccess;
			}
		}

		/// <summary>
		/// Void CheckWriteAccess()
		/// </summary>
		protected RMethod r_MCheckWriteAccess;
		public virtual RMethod RMCheckWriteAccess
		{
			get
			{
				if(r_MCheckWriteAccess == null)
				{
					r_MCheckWriteAccess = new(this, "CheckWriteAccess", 0);
				}
				return r_MCheckWriteAccess;
			}
		}

		/// <summary>
		/// Void GetSubMesh_Injected(IntPtr, Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef)
		/// </summary>
		protected static RMethod r_MGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor;
		public static RMethod RMGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor
		{
			get
			{
				if(r_MGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor == null)
				{
					r_MGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor = new(Type, "GetSubMesh_Injected", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType());
				}
				return r_MGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor;
			}
		}

		/// <summary>
		/// Void SetSubMeshImpl_Injected(IntPtr, Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
		public static RMethod RMSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_MSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags = new(Type, "SetSubMeshImpl_Injected", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
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


        public static System.Boolean HasVertexAttribute(System.IntPtr @self, UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RMHasVertexAttribute_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 GetVertexAttributeDimension(System.IntPtr @self, UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RMGetVertexAttributeDimension_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(System.IntPtr @self, UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RMGetVertexAttributeFormat_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.VertexAttributeFormat>(___result);
        }


        public static System.Int32 GetVertexAttributeStream(System.IntPtr @self, UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RMGetVertexAttributeStream_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetVertexAttributeOffset(System.IntPtr @self, UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RMGetVertexAttributeOffset_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetVertexCount(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetVertexCount_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetVertexBufferCount(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetVertexBufferCount_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.IntPtr GetVertexDataPtr(System.IntPtr @self, System.Int32 @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @stream};
            var ___result = RMGetVertexDataPtr_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.UInt64 GetVertexDataSize(System.IntPtr @self, System.Int32 @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @stream};
            var ___result = RMGetVertexDataSize_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public static System.Int32 GetVertexBufferStride(System.IntPtr @self, System.Int32 @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @stream};
            var ___result = RMGetVertexBufferStride_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static void CopyAttributeIntoPtr(System.IntPtr @self, UnityEngine.Rendering.VertexAttribute @attr, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.IntPtr @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr, @format, @dim, @dst};
            var ___result = RMCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyIndicesIntoPtr(System.IntPtr @self, System.Int32 @submesh, System.Boolean @applyBaseVertex, System.Int32 @dstStride, System.IntPtr @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @submesh, @applyBaseVertex, @dstStride, @dst};
            var ___result = RMCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rendering.IndexFormat GetIndexFormat(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetIndexFormat_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.IndexFormat>(___result);
        }


        public static System.Int32 GetIndexCount(System.IntPtr @self, System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @submesh};
            var ___result = RMGetIndexCount_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.IntPtr GetIndexDataPtr(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetIndexDataPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.UInt64 GetIndexDataSize(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetIndexDataSize_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public static System.Int32 GetSubMeshCount(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMGetSubMeshCount_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.IntPtr @self, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index};
            var ___result = RMGetSubMesh_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SubMeshDescriptor>(___result);
        }


        public static void SetVertexBufferParamsFromPtr(System.IntPtr @self, System.Int32 @vertexCount, System.IntPtr @attributesPtr, System.Int32 @attributesCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @vertexCount, @attributesPtr, @attributesCount};
            var ___result = RMSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetVertexBufferParamsFromArray(System.IntPtr @self, System.Int32 @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @vertexCount, @attributes};
            var ___result = RMSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetIndexBufferParamsImpl(System.IntPtr @self, System.Int32 @indexCount, UnityEngine.Rendering.IndexFormat @indexFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @indexCount, @indexFormat};
            var ___result = RMSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetSubMeshCount(System.IntPtr @self, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @count};
            var ___result = RMSetSubMeshCount_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetSubMeshImpl(System.IntPtr @self, System.Int32 @index, UnityEngine.Rendering.SubMeshDescriptor @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @desc, @flags};
            var ___result = RMSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetVertexBufferStride(System.Int32 @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RMGetVertexBufferStride_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RMHasVertexAttribute_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RMGetVertexAttributeDimension_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RMGetVertexAttributeFormat_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.VertexAttributeFormat>(___result);
        }


        public virtual System.Int32 GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RMGetVertexAttributeStream_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RMGetVertexAttributeOffset_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void GetVertices(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @outVertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outVertices.Value};
            var ___result = RMGetVertices_NativeArray_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetNormals(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @outNormals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outNormals.Value};
            var ___result = RMGetNormals_NativeArray_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTangents(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> @outTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outTangents.Value};
            var ___result = RMGetTangents_NativeArray_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColors(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RColor> @outColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outColors.Value};
            var ___result = RMGetColors_NativeArray_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColors(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> @outColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outColors.Value};
            var ___result = RMGetColors_NativeArray_d_Color32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32 @channel, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> @outUVs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @outUVs.Value};
            var ___result = RMGetUVs_Int32_NativeArray_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32 @channel, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> @outUVs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @outUVs.Value};
            var ___result = RMGetUVs_Int32_NativeArray_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32 @channel, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> @outUVs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @outUVs.Value};
            var ___result = RMGetUVs_Int32_NativeArray_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetVertexData<T>(System.Int32 @stream) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@stream};
            var ___result = RMGetVertexData_GT_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual void CopyAttributeInto<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @buffer, UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer.Value, @channel, @format, @dim};
            var ___result = RMCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferParams(System.Int32 @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributes};
            var ___result = RMSetVertexBufferParams_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferParams(System.Int32 @vertexCount, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttributeDescriptor> @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributes.Value};
            var ___result = RMSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndexBufferParams(System.Int32 @indexCount, UnityEngine.Rendering.IndexFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexCount, @format};
            var ___result = RMSetIndexBufferParams_Int32_IndexFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndices(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RUInt16> @outIndices, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outIndices.Value, @submesh, @applyBaseVertex};
            var ___result = RMGetIndices_NativeArray_d_UInt16_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndices(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RInt32> @outIndices, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outIndices.Value, @submesh, @applyBaseVertex};
            var ___result = RMGetIndices_NativeArray_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetIndexData<T>() where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetIndexData_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetSubMesh_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SubMeshDescriptor>(___result);
        }


        public virtual void SetSubMesh(System.Int32 @index, UnityEngine.Rendering.SubMeshDescriptor @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @desc, @flags};
            var ___result = RMSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckReadAccess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckReadAccess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckWriteAccess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckWriteAccess.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetSubMesh_Injected(System.IntPtr @self, System.Int32 @index, out UnityEngine.Rendering.SubMeshDescriptor @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @ret};
            var ___result = RMGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[2];

            
        }


        public static void SetSubMeshImpl_Injected(System.IntPtr @self, System.Int32 @index, ref UnityEngine.Rendering.SubMeshDescriptor @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @desc, @flags};
            var ___result = RMSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);
			@desc = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[2];

            
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