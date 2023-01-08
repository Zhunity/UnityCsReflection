using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RMesh
{
	
	/// <summary>
	/// UnityEngine.Mesh+MeshData
	/// </summary>
    public partial class RMeshData : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
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
		/// Int32 vertexCount
		/// </summary>
		protected RProperty r_vertexCount;
		public virtual RProperty RvertexCount
		{
			get
			{
				if(r_vertexCount == null)
				{
					r_vertexCount = new(this, "vertexCount", -1);
					r_vertexCount.SetBelong(this.instance);
				}
				return r_vertexCount;
			}
		}

		/// <summary>
		/// Int32 vertexBufferCount
		/// </summary>
		protected RProperty r_vertexBufferCount;
		public virtual RProperty RvertexBufferCount
		{
			get
			{
				if(r_vertexBufferCount == null)
				{
					r_vertexBufferCount = new(this, "vertexBufferCount", -1);
					r_vertexBufferCount.SetBelong(this.instance);
				}
				return r_vertexBufferCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.IndexFormat indexFormat
		/// </summary>
		protected RProperty r_indexFormat;
		public virtual RProperty RindexFormat
		{
			get
			{
				if(r_indexFormat == null)
				{
					r_indexFormat = new(this, "indexFormat", -1);
					r_indexFormat.SetBelong(this.instance);
				}
				return r_indexFormat;
			}
		}

		/// <summary>
		/// Int32 subMeshCount
		/// </summary>
		protected RProperty r_subMeshCount;
		public virtual RProperty RsubMeshCount
		{
			get
			{
				if(r_subMeshCount == null)
				{
					r_subMeshCount = new(this, "subMeshCount", -1);
					r_subMeshCount.SetBelong(this.instance);
				}
				return r_subMeshCount;
			}
		}

		/// <summary>
		/// Boolean HasVertexAttribute(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_HasVertexAttribute_IntPtr_VertexAttribute;
		public static RMethod RHasVertexAttribute_IntPtr_VertexAttribute
		{
			get
			{
				if(r_HasVertexAttribute_IntPtr_VertexAttribute == null)
				{
					r_HasVertexAttribute_IntPtr_VertexAttribute = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "HasVertexAttribute", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
					r_HasVertexAttribute_IntPtr_VertexAttribute.SetBelong(null);
				}
				return r_HasVertexAttribute_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeDimension(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_GetVertexAttributeDimension_IntPtr_VertexAttribute;
		public static RMethod RGetVertexAttributeDimension_IntPtr_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeDimension_IntPtr_VertexAttribute == null)
				{
					r_GetVertexAttributeDimension_IntPtr_VertexAttribute = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexAttributeDimension", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeDimension_IntPtr_VertexAttribute.SetBelong(null);
				}
				return r_GetVertexAttributeDimension_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_GetVertexAttributeFormat_IntPtr_VertexAttribute;
		public static RMethod RGetVertexAttributeFormat_IntPtr_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeFormat_IntPtr_VertexAttribute == null)
				{
					r_GetVertexAttributeFormat_IntPtr_VertexAttribute = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexAttributeFormat", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeFormat_IntPtr_VertexAttribute.SetBelong(null);
				}
				return r_GetVertexAttributeFormat_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeStream(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_GetVertexAttributeStream_IntPtr_VertexAttribute;
		public static RMethod RGetVertexAttributeStream_IntPtr_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeStream_IntPtr_VertexAttribute == null)
				{
					r_GetVertexAttributeStream_IntPtr_VertexAttribute = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexAttributeStream", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeStream_IntPtr_VertexAttribute.SetBelong(null);
				}
				return r_GetVertexAttributeStream_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeOffset(IntPtr, UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_GetVertexAttributeOffset_IntPtr_VertexAttribute;
		public static RMethod RGetVertexAttributeOffset_IntPtr_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeOffset_IntPtr_VertexAttribute == null)
				{
					r_GetVertexAttributeOffset_IntPtr_VertexAttribute = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexAttributeOffset", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeOffset_IntPtr_VertexAttribute.SetBelong(null);
				}
				return r_GetVertexAttributeOffset_IntPtr_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexCount(IntPtr)
		/// </summary>
		protected static RMethod r_GetVertexCount_IntPtr;
		public static RMethod RGetVertexCount_IntPtr
		{
			get
			{
				if(r_GetVertexCount_IntPtr == null)
				{
					r_GetVertexCount_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexCount", 0, typeof(System.IntPtr));
					r_GetVertexCount_IntPtr.SetBelong(null);
				}
				return r_GetVertexCount_IntPtr;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferCount(IntPtr)
		/// </summary>
		protected static RMethod r_GetVertexBufferCount_IntPtr;
		public static RMethod RGetVertexBufferCount_IntPtr
		{
			get
			{
				if(r_GetVertexBufferCount_IntPtr == null)
				{
					r_GetVertexBufferCount_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexBufferCount", 0, typeof(System.IntPtr));
					r_GetVertexBufferCount_IntPtr.SetBelong(null);
				}
				return r_GetVertexBufferCount_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetVertexDataPtr(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_GetVertexDataPtr_IntPtr_Int32;
		public static RMethod RGetVertexDataPtr_IntPtr_Int32
		{
			get
			{
				if(r_GetVertexDataPtr_IntPtr_Int32 == null)
				{
					r_GetVertexDataPtr_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexDataPtr", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_GetVertexDataPtr_IntPtr_Int32.SetBelong(null);
				}
				return r_GetVertexDataPtr_IntPtr_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetVertexDataSize(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_GetVertexDataSize_IntPtr_Int32;
		public static RMethod RGetVertexDataSize_IntPtr_Int32
		{
			get
			{
				if(r_GetVertexDataSize_IntPtr_Int32 == null)
				{
					r_GetVertexDataSize_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexDataSize", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_GetVertexDataSize_IntPtr_Int32.SetBelong(null);
				}
				return r_GetVertexDataSize_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferStride(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_GetVertexBufferStride_IntPtr_Int32;
		public static RMethod RGetVertexBufferStride_IntPtr_Int32
		{
			get
			{
				if(r_GetVertexBufferStride_IntPtr_Int32 == null)
				{
					r_GetVertexBufferStride_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetVertexBufferStride", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_GetVertexBufferStride_IntPtr_Int32.SetBelong(null);
				}
				return r_GetVertexBufferStride_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void CopyAttributeIntoPtr(IntPtr, UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_CopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr;
		public static RMethod RCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr
		{
			get
			{
				if(r_CopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr == null)
				{
					r_CopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "CopyAttributeIntoPtr", 0, typeof(System.IntPtr), typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr));
					r_CopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr.SetBelong(null);
				}
				return r_CopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Void CopyIndicesIntoPtr(IntPtr, Int32, Boolean, Int32, IntPtr)
		/// </summary>
		protected static RMethod r_CopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr;
		public static RMethod RCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr
		{
			get
			{
				if(r_CopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr == null)
				{
					r_CopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "CopyIndicesIntoPtr", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32), typeof(System.IntPtr));
					r_CopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr.SetBelong(null);
				}
				return r_CopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.IndexFormat GetIndexFormat(IntPtr)
		/// </summary>
		protected static RMethod r_GetIndexFormat_IntPtr;
		public static RMethod RGetIndexFormat_IntPtr
		{
			get
			{
				if(r_GetIndexFormat_IntPtr == null)
				{
					r_GetIndexFormat_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetIndexFormat", 0, typeof(System.IntPtr));
					r_GetIndexFormat_IntPtr.SetBelong(null);
				}
				return r_GetIndexFormat_IntPtr;
			}
		}

		/// <summary>
		/// Int32 GetIndexCount(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_GetIndexCount_IntPtr_Int32;
		public static RMethod RGetIndexCount_IntPtr_Int32
		{
			get
			{
				if(r_GetIndexCount_IntPtr_Int32 == null)
				{
					r_GetIndexCount_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetIndexCount", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_GetIndexCount_IntPtr_Int32.SetBelong(null);
				}
				return r_GetIndexCount_IntPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetIndexDataPtr(IntPtr)
		/// </summary>
		protected static RMethod r_GetIndexDataPtr_IntPtr;
		public static RMethod RGetIndexDataPtr_IntPtr
		{
			get
			{
				if(r_GetIndexDataPtr_IntPtr == null)
				{
					r_GetIndexDataPtr_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetIndexDataPtr", 0, typeof(System.IntPtr));
					r_GetIndexDataPtr_IntPtr.SetBelong(null);
				}
				return r_GetIndexDataPtr_IntPtr;
			}
		}

		/// <summary>
		/// UInt64 GetIndexDataSize(IntPtr)
		/// </summary>
		protected static RMethod r_GetIndexDataSize_IntPtr;
		public static RMethod RGetIndexDataSize_IntPtr
		{
			get
			{
				if(r_GetIndexDataSize_IntPtr == null)
				{
					r_GetIndexDataSize_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetIndexDataSize", 0, typeof(System.IntPtr));
					r_GetIndexDataSize_IntPtr.SetBelong(null);
				}
				return r_GetIndexDataSize_IntPtr;
			}
		}

		/// <summary>
		/// Int32 GetSubMeshCount(IntPtr)
		/// </summary>
		protected static RMethod r_GetSubMeshCount_IntPtr;
		public static RMethod RGetSubMeshCount_IntPtr
		{
			get
			{
				if(r_GetSubMeshCount_IntPtr == null)
				{
					r_GetSubMeshCount_IntPtr = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetSubMeshCount", 0, typeof(System.IntPtr));
					r_GetSubMeshCount_IntPtr.SetBelong(null);
				}
				return r_GetSubMeshCount_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_GetSubMesh_IntPtr_Int32;
		public static RMethod RGetSubMesh_IntPtr_Int32
		{
			get
			{
				if(r_GetSubMesh_IntPtr_Int32 == null)
				{
					r_GetSubMesh_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetSubMesh", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_GetSubMesh_IntPtr_Int32.SetBelong(null);
				}
				return r_GetSubMesh_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromPtr(IntPtr, Int32, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_SetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32;
		public static RMethod RSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_SetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32 == null)
				{
					r_SetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "SetVertexBufferParamsFromPtr", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
					r_SetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32.SetBelong(null);
				}
				return r_SetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromArray(IntPtr, Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected static RMethod r_SetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray;
		public static RMethod RSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_SetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray == null)
				{
					r_SetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "SetVertexBufferParamsFromArray", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_SetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray.SetBelong(null);
				}
				return r_SetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void SetIndexBufferParamsImpl(IntPtr, Int32, UnityEngine.Rendering.IndexFormat)
		/// </summary>
		protected static RMethod r_SetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat;
		public static RMethod RSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat
		{
			get
			{
				if(r_SetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat == null)
				{
					r_SetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "SetIndexBufferParamsImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat));
					r_SetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat.SetBelong(null);
				}
				return r_SetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat;
			}
		}

		/// <summary>
		/// Void SetSubMeshCount(IntPtr, Int32)
		/// </summary>
		protected static RMethod r_SetSubMeshCount_IntPtr_Int32;
		public static RMethod RSetSubMeshCount_IntPtr_Int32
		{
			get
			{
				if(r_SetSubMeshCount_IntPtr_Int32 == null)
				{
					r_SetSubMeshCount_IntPtr_Int32 = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "SetSubMeshCount", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_SetSubMeshCount_IntPtr_Int32.SetBelong(null);
				}
				return r_SetSubMeshCount_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMeshImpl(IntPtr, Int32, UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_SetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags;
		public static RMethod RSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_SetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "SetSubMeshImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags.SetBelong(null);
				}
				return r_SetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferStride(Int32)
		/// </summary>
		protected RMethod r_GetVertexBufferStride_Int32;
		public virtual RMethod RGetVertexBufferStride_Int32
		{
			get
			{
				if(r_GetVertexBufferStride_Int32 == null)
				{
					r_GetVertexBufferStride_Int32 = new(this, "GetVertexBufferStride", 0, typeof(System.Int32));
					r_GetVertexBufferStride_Int32.SetBelong(this.instance);
				}
				return r_GetVertexBufferStride_Int32;
			}
		}

		/// <summary>
		/// Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_HasVertexAttribute_VertexAttribute;
		public virtual RMethod RHasVertexAttribute_VertexAttribute
		{
			get
			{
				if(r_HasVertexAttribute_VertexAttribute == null)
				{
					r_HasVertexAttribute_VertexAttribute = new(this, "HasVertexAttribute", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_HasVertexAttribute_VertexAttribute.SetBelong(this.instance);
				}
				return r_HasVertexAttribute_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_GetVertexAttributeDimension_VertexAttribute;
		public virtual RMethod RGetVertexAttributeDimension_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeDimension_VertexAttribute == null)
				{
					r_GetVertexAttributeDimension_VertexAttribute = new(this, "GetVertexAttributeDimension", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeDimension_VertexAttribute.SetBelong(this.instance);
				}
				return r_GetVertexAttributeDimension_VertexAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_GetVertexAttributeFormat_VertexAttribute;
		public virtual RMethod RGetVertexAttributeFormat_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeFormat_VertexAttribute == null)
				{
					r_GetVertexAttributeFormat_VertexAttribute = new(this, "GetVertexAttributeFormat", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeFormat_VertexAttribute.SetBelong(this.instance);
				}
				return r_GetVertexAttributeFormat_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_GetVertexAttributeStream_VertexAttribute;
		public virtual RMethod RGetVertexAttributeStream_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeStream_VertexAttribute == null)
				{
					r_GetVertexAttributeStream_VertexAttribute = new(this, "GetVertexAttributeStream", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeStream_VertexAttribute.SetBelong(this.instance);
				}
				return r_GetVertexAttributeStream_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_GetVertexAttributeOffset_VertexAttribute;
		public virtual RMethod RGetVertexAttributeOffset_VertexAttribute
		{
			get
			{
				if(r_GetVertexAttributeOffset_VertexAttribute == null)
				{
					r_GetVertexAttributeOffset_VertexAttribute = new(this, "GetVertexAttributeOffset", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetVertexAttributeOffset_VertexAttribute.SetBelong(this.instance);
				}
				return r_GetVertexAttributeOffset_VertexAttribute;
			}
		}

		/// <summary>
		/// Void GetVertices(Unity.Collections.NativeArray`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_GetVertices_NativeArray_d_Vector3_p_;
		public virtual RMethod RGetVertices_NativeArray_d_Vector3_p_
		{
			get
			{
				if(r_GetVertices_NativeArray_d_Vector3_p_ == null)
				{
					r_GetVertices_NativeArray_d_Vector3_p_ = new(this, "GetVertices", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_GetVertices_NativeArray_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_GetVertices_NativeArray_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetNormals(Unity.Collections.NativeArray`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_GetNormals_NativeArray_d_Vector3_p_;
		public virtual RMethod RGetNormals_NativeArray_d_Vector3_p_
		{
			get
			{
				if(r_GetNormals_NativeArray_d_Vector3_p_ == null)
				{
					r_GetNormals_NativeArray_d_Vector3_p_ = new(this, "GetNormals", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_GetNormals_NativeArray_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_GetNormals_NativeArray_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetTangents(Unity.Collections.NativeArray`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_GetTangents_NativeArray_d_Vector4_p_;
		public virtual RMethod RGetTangents_NativeArray_d_Vector4_p_
		{
			get
			{
				if(r_GetTangents_NativeArray_d_Vector4_p_ == null)
				{
					r_GetTangents_NativeArray_d_Vector4_p_ = new(this, "GetTangents", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetTangents_NativeArray_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_GetTangents_NativeArray_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void GetColors(Unity.Collections.NativeArray`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_GetColors_NativeArray_d_Color_p_;
		public virtual RMethod RGetColors_NativeArray_d_Color_p_
		{
			get
			{
				if(r_GetColors_NativeArray_d_Color_p_ == null)
				{
					r_GetColors_NativeArray_d_Color_p_ = new(this, "GetColors", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_GetColors_NativeArray_d_Color_p_.SetBelong(this.instance);
				}
				return r_GetColors_NativeArray_d_Color_p_;
			}
		}

		/// <summary>
		/// Void GetColors(Unity.Collections.NativeArray`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_GetColors_NativeArray_d_Color32_p_;
		public virtual RMethod RGetColors_NativeArray_d_Color32_p_
		{
			get
			{
				if(r_GetColors_NativeArray_d_Color32_p_ == null)
				{
					r_GetColors_NativeArray_d_Color32_p_ = new(this, "GetColors", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Color32)));
					r_GetColors_NativeArray_d_Color32_p_.SetBelong(this.instance);
				}
				return r_GetColors_NativeArray_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, Unity.Collections.NativeArray`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_GetUVs_Int32_NativeArray_d_Vector2_p_;
		public virtual RMethod RGetUVs_Int32_NativeArray_d_Vector2_p_
		{
			get
			{
				if(r_GetUVs_Int32_NativeArray_d_Vector2_p_ == null)
				{
					r_GetUVs_Int32_NativeArray_d_Vector2_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_GetUVs_Int32_NativeArray_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_GetUVs_Int32_NativeArray_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, Unity.Collections.NativeArray`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_GetUVs_Int32_NativeArray_d_Vector3_p_;
		public virtual RMethod RGetUVs_Int32_NativeArray_d_Vector3_p_
		{
			get
			{
				if(r_GetUVs_Int32_NativeArray_d_Vector3_p_ == null)
				{
					r_GetUVs_Int32_NativeArray_d_Vector3_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_GetUVs_Int32_NativeArray_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_GetUVs_Int32_NativeArray_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, Unity.Collections.NativeArray`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_GetUVs_Int32_NativeArray_d_Vector4_p_;
		public virtual RMethod RGetUVs_Int32_NativeArray_d_Vector4_p_
		{
			get
			{
				if(r_GetUVs_Int32_NativeArray_d_Vector4_p_ == null)
				{
					r_GetUVs_Int32_NativeArray_d_Vector4_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetUVs_Int32_NativeArray_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_GetUVs_Int32_NativeArray_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetVertexData[T](Int32)
		/// </summary>
		protected RMethod r_GetVertexData_GT_Int32;
		public virtual RMethod RGetVertexData_GT_Int32
		{
			get
			{
				if(r_GetVertexData_GT_Int32 == null)
				{
					r_GetVertexData_GT_Int32 = new(this, "GetVertexData", 1, typeof(System.Int32));
					r_GetVertexData_GT_Int32.SetBelong(this.instance);
				}
				return r_GetVertexData_GT_Int32;
			}
		}

		/// <summary>
		/// Void CopyAttributeInto[T](Unity.Collections.NativeArray`1[T], UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_CopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RCopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_CopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_CopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32 = new(this, "CopyAttributeInto", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
					r_CopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32.SetBelong(this.instance);
				}
				return r_CopyAttributeInto_GT_NativeArray_d_T_p__VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParams(Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_SetVertexBufferParams_Int32_VertexAttributeDescriptorArray;
		public virtual RMethod RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_SetVertexBufferParams_Int32_VertexAttributeDescriptorArray == null)
				{
					r_SetVertexBufferParams_Int32_VertexAttributeDescriptorArray = new(this, "SetVertexBufferParams", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_SetVertexBufferParams_Int32_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_SetVertexBufferParams_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParams(Int32, Unity.Collections.NativeArray`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_SetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_SetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_ == null)
				{
					r_SetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_ = new(this, "SetVertexBufferParams", 0, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
					r_SetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_.SetBelong(this.instance);
				}
				return r_SetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Void SetIndexBufferParams(Int32, UnityEngine.Rendering.IndexFormat)
		/// </summary>
		protected RMethod r_SetIndexBufferParams_Int32_IndexFormat;
		public virtual RMethod RSetIndexBufferParams_Int32_IndexFormat
		{
			get
			{
				if(r_SetIndexBufferParams_Int32_IndexFormat == null)
				{
					r_SetIndexBufferParams_Int32_IndexFormat = new(this, "SetIndexBufferParams", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat));
					r_SetIndexBufferParams_Int32_IndexFormat.SetBelong(this.instance);
				}
				return r_SetIndexBufferParams_Int32_IndexFormat;
			}
		}

		/// <summary>
		/// Void GetIndices(Unity.Collections.NativeArray`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndices_NativeArray_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RGetIndices_NativeArray_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_GetIndices_NativeArray_d_UInt16_p__Int32_Boolean == null)
				{
					r_GetIndices_NativeArray_d_UInt16_p__Int32_Boolean = new(this, "GetIndices", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
					r_GetIndices_NativeArray_d_UInt16_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndices_NativeArray_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(Unity.Collections.NativeArray`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndices_NativeArray_d_Int32_p__Int32_Boolean;
		public virtual RMethod RGetIndices_NativeArray_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_GetIndices_NativeArray_d_Int32_p__Int32_Boolean == null)
				{
					r_GetIndices_NativeArray_d_Int32_p__Int32_Boolean = new(this, "GetIndices", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_GetIndices_NativeArray_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndices_NativeArray_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetIndexData[T]()
		/// </summary>
		protected RMethod r_GetIndexData_GT;
		public virtual RMethod RGetIndexData_GT
		{
			get
			{
				if(r_GetIndexData_GT == null)
				{
					r_GetIndexData_GT = new(this, "GetIndexData", 1);
					r_GetIndexData_GT.SetBelong(this.instance);
				}
				return r_GetIndexData_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(Int32)
		/// </summary>
		protected RMethod r_GetSubMesh_Int32;
		public virtual RMethod RGetSubMesh_Int32
		{
			get
			{
				if(r_GetSubMesh_Int32 == null)
				{
					r_GetSubMesh_Int32 = new(this, "GetSubMesh", 0, typeof(System.Int32));
					r_GetSubMesh_Int32.SetBelong(this.instance);
				}
				return r_GetSubMesh_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMesh(Int32, UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags;
		public virtual RMethod RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_SetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags = new(this, "SetSubMesh", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void CheckReadAccess()
		/// </summary>
		protected RMethod r_CheckReadAccess;
		public virtual RMethod RCheckReadAccess
		{
			get
			{
				if(r_CheckReadAccess == null)
				{
					r_CheckReadAccess = new(this, "CheckReadAccess", 0);
					r_CheckReadAccess.SetBelong(this.instance);
				}
				return r_CheckReadAccess;
			}
		}

		/// <summary>
		/// Void CheckWriteAccess()
		/// </summary>
		protected RMethod r_CheckWriteAccess;
		public virtual RMethod RCheckWriteAccess
		{
			get
			{
				if(r_CheckWriteAccess == null)
				{
					r_CheckWriteAccess = new(this, "CheckWriteAccess", 0);
					r_CheckWriteAccess.SetBelong(this.instance);
				}
				return r_CheckWriteAccess;
			}
		}

		/// <summary>
		/// Void GetSubMesh_Injected(IntPtr, Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef)
		/// </summary>
		protected static RMethod r_GetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor;
		public static RMethod RGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor
		{
			get
			{
				if(r_GetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor == null)
				{
					r_GetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "GetSubMesh_Injected", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType());
					r_GetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor.SetBelong(null);
				}
				return r_GetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor;
			}
		}

		/// <summary>
		/// Void SetSubMeshImpl_Injected(IntPtr, Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_SetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
		public static RMethod RSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_SetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags = new( ReflectionUtils.GetType("UnityEngine.Mesh+MeshData"), "SetSubMeshImpl_Injected", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.SetBelong(null);
				}
				return r_SetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public static System.Boolean HasVertexAttribute(System.IntPtr  @self, UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RHasVertexAttribute_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetVertexAttributeDimension(System.IntPtr  @self, UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RGetVertexAttributeDimension_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(System.IntPtr  @self, UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RGetVertexAttributeFormat_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.VertexAttributeFormat)___result;
        }


        public static System.Int32 GetVertexAttributeStream(System.IntPtr  @self, UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RGetVertexAttributeStream_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetVertexAttributeOffset(System.IntPtr  @self, UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr};
            var ___result = RGetVertexAttributeOffset_IntPtr_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetVertexCount(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetVertexCount_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetVertexBufferCount(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetVertexBufferCount_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.IntPtr GetVertexDataPtr(System.IntPtr  @self, System.Int32  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @stream};
            var ___result = RGetVertexDataPtr_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.UInt64 GetVertexDataSize(System.IntPtr  @self, System.Int32  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @stream};
            var ___result = RGetVertexDataSize_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.Int32 GetVertexBufferStride(System.IntPtr  @self, System.Int32  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @stream};
            var ___result = RGetVertexBufferStride_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void CopyAttributeIntoPtr(System.IntPtr  @self, UnityEngine.Rendering.VertexAttribute  @attr, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.IntPtr  @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @attr, @format, @dim, @dst};
            var ___result = RCopyAttributeIntoPtr_IntPtr_VertexAttribute_VertexAttributeFormat_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void CopyIndicesIntoPtr(System.IntPtr  @self, System.Int32  @submesh, System.Boolean  @applyBaseVertex, System.Int32  @dstStride, System.IntPtr  @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @submesh, @applyBaseVertex, @dstStride, @dst};
            var ___result = RCopyIndicesIntoPtr_IntPtr_Int32_Boolean_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rendering.IndexFormat GetIndexFormat(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetIndexFormat_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.IndexFormat)___result;
        }


        public static System.Int32 GetIndexCount(System.IntPtr  @self, System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @submesh};
            var ___result = RGetIndexCount_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.IntPtr GetIndexDataPtr(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetIndexDataPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.UInt64 GetIndexDataSize(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetIndexDataSize_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static System.Int32 GetSubMeshCount(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RGetSubMeshCount_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.IntPtr  @self, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index};
            var ___result = RGetSubMesh_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.SubMeshDescriptor)___result;
        }


        public static void SetVertexBufferParamsFromPtr(System.IntPtr  @self, System.Int32  @vertexCount, System.IntPtr  @attributesPtr, System.Int32  @attributesCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @vertexCount, @attributesPtr, @attributesCount};
            var ___result = RSetVertexBufferParamsFromPtr_IntPtr_Int32_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetVertexBufferParamsFromArray(System.IntPtr  @self, System.Int32  @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @vertexCount, @attributes};
            var ___result = RSetVertexBufferParamsFromArray_IntPtr_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetIndexBufferParamsImpl(System.IntPtr  @self, System.Int32  @indexCount, UnityEngine.Rendering.IndexFormat  @indexFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @indexCount, @indexFormat};
            var ___result = RSetIndexBufferParamsImpl_IntPtr_Int32_IndexFormat.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetSubMeshCount(System.IntPtr  @self, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @count};
            var ___result = RSetSubMeshCount_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetSubMeshImpl(System.IntPtr  @self, System.Int32  @index, UnityEngine.Rendering.SubMeshDescriptor  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @desc, @flags};
            var ___result = RSetSubMeshImpl_IntPtr_Int32_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetVertexBufferStride(System.Int32  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RGetVertexBufferStride_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RHasVertexAttribute_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RGetVertexAttributeDimension_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RGetVertexAttributeFormat_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.VertexAttributeFormat)___result;
        }


        public virtual System.Int32 GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RGetVertexAttributeStream_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attr};
            var ___result = RGetVertexAttributeOffset_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }










        public virtual System.Object GetVertexData<T>(System.Int32  @stream) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@stream};
            var ___result = RGetVertexData_GT_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void SetVertexBufferParams(System.Int32  @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributes};
            var ___result = RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetIndexBufferParams(System.Int32  @indexCount, UnityEngine.Rendering.IndexFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexCount, @format};
            var ___result = RSetIndexBufferParams_Int32_IndexFormat.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Object GetIndexData<T>() where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetIndexData_GT.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetSubMesh_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.SubMeshDescriptor)___result;
        }


        public virtual void SetSubMesh(System.Int32  @index, UnityEngine.Rendering.SubMeshDescriptor  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @desc, @flags};
            var ___result = RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckReadAccess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckReadAccess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckWriteAccess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckWriteAccess.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetSubMesh_Injected(System.IntPtr  @self, System.Int32  @index, out UnityEngine.Rendering.SubMeshDescriptor  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @ret};
            var ___result = RGetSubMesh_Injected_IntPtr_Int32_Out_SubMeshDescriptor.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[2];

            
        }


        public static void SetSubMeshImpl_Injected(System.IntPtr  @self, System.Int32  @index, ref UnityEngine.Rendering.SubMeshDescriptor  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @desc, @flags};
            var ___result = RSetSubMeshImpl_Injected_IntPtr_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);
			desc = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[2];

            
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