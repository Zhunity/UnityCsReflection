using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Mesh
	/// </summary>
    public partial class RMesh : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2[] uv1
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv1;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv1
		{
			get
			{
				if(r_uv1 == null)
				{
					r_uv1 = new(this, "uv1", -1);
					r_uv1.SetBelong(this.instance);
				}
				return r_uv1;
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
		/// Target vertexBufferTarget
		/// </summary>
		protected RProperty r_vertexBufferTarget;
		public virtual RProperty RvertexBufferTarget
		{
			get
			{
				if(r_vertexBufferTarget == null)
				{
					r_vertexBufferTarget = new(this, "vertexBufferTarget", -1);
					r_vertexBufferTarget.SetBelong(this.instance);
				}
				return r_vertexBufferTarget;
			}
		}

		/// <summary>
		/// Target indexBufferTarget
		/// </summary>
		protected RProperty r_indexBufferTarget;
		public virtual RProperty RindexBufferTarget
		{
			get
			{
				if(r_indexBufferTarget == null)
				{
					r_indexBufferTarget = new(this, "indexBufferTarget", -1);
					r_indexBufferTarget.SetBelong(this.instance);
				}
				return r_indexBufferTarget;
			}
		}

		/// <summary>
		/// Int32 blendShapeCount
		/// </summary>
		protected RProperty r_blendShapeCount;
		public virtual RProperty RblendShapeCount
		{
			get
			{
				if(r_blendShapeCount == null)
				{
					r_blendShapeCount = new(this, "blendShapeCount", -1);
					r_blendShapeCount.SetBelong(this.instance);
				}
				return r_blendShapeCount;
			}
		}

		/// <summary>
		/// Int32 bindposeCount
		/// </summary>
		protected RProperty r_bindposeCount;
		public virtual RProperty RbindposeCount
		{
			get
			{
				if(r_bindposeCount == null)
				{
					r_bindposeCount = new(this, "bindposeCount", -1);
					r_bindposeCount.SetBelong(this.instance);
				}
				return r_bindposeCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] bindposes
		/// </summary>
		protected RPropertyArray<RUnityEngine.RMatrix4x4> r_bindposes;
		public virtual RPropertyArray<RUnityEngine.RMatrix4x4> Rbindposes
		{
			get
			{
				if(r_bindposes == null)
				{
					r_bindposes = new(this, "bindposes", -1);
					r_bindposes.SetBelong(this.instance);
				}
				return r_bindposes;
			}
		}

		/// <summary>
		/// Boolean isReadable
		/// </summary>
		protected RProperty r_isReadable;
		public virtual RProperty RisReadable
		{
			get
			{
				if(r_isReadable == null)
				{
					r_isReadable = new(this, "isReadable", -1);
					r_isReadable.SetBelong(this.instance);
				}
				return r_isReadable;
			}
		}

		/// <summary>
		/// Boolean canAccess
		/// </summary>
		protected RProperty r_canAccess;
		public virtual RProperty RcanAccess
		{
			get
			{
				if(r_canAccess == null)
				{
					r_canAccess = new(this, "canAccess", -1);
					r_canAccess.SetBelong(this.instance);
				}
				return r_canAccess;
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
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected RUnityEngine.RBounds r_bounds;
		public virtual RUnityEngine.RBounds Rbounds
		{
			get
			{
				if(r_bounds == null)
				{
					r_bounds = new(this, "bounds", -1);
					r_bounds.SetBelong(this.instance);
				}
				return r_bounds;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] vertices
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector3> r_vertices;
		public virtual RPropertyArray<RUnityEngine.RVector3> Rvertices
		{
			get
			{
				if(r_vertices == null)
				{
					r_vertices = new(this, "vertices", -1);
					r_vertices.SetBelong(this.instance);
				}
				return r_vertices;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] normals
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector3> r_normals;
		public virtual RPropertyArray<RUnityEngine.RVector3> Rnormals
		{
			get
			{
				if(r_normals == null)
				{
					r_normals = new(this, "normals", -1);
					r_normals.SetBelong(this.instance);
				}
				return r_normals;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] tangents
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector4> r_tangents;
		public virtual RPropertyArray<RUnityEngine.RVector4> Rtangents
		{
			get
			{
				if(r_tangents == null)
				{
					r_tangents = new(this, "tangents", -1);
					r_tangents.SetBelong(this.instance);
				}
				return r_tangents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv
		{
			get
			{
				if(r_uv == null)
				{
					r_uv = new(this, "uv", -1);
					r_uv.SetBelong(this.instance);
				}
				return r_uv;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv2
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv2;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv2
		{
			get
			{
				if(r_uv2 == null)
				{
					r_uv2 = new(this, "uv2", -1);
					r_uv2.SetBelong(this.instance);
				}
				return r_uv2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv3
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv3;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv3
		{
			get
			{
				if(r_uv3 == null)
				{
					r_uv3 = new(this, "uv3", -1);
					r_uv3.SetBelong(this.instance);
				}
				return r_uv3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv4
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv4;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv4
		{
			get
			{
				if(r_uv4 == null)
				{
					r_uv4 = new(this, "uv4", -1);
					r_uv4.SetBelong(this.instance);
				}
				return r_uv4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv5
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv5;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv5
		{
			get
			{
				if(r_uv5 == null)
				{
					r_uv5 = new(this, "uv5", -1);
					r_uv5.SetBelong(this.instance);
				}
				return r_uv5;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv6
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv6;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv6
		{
			get
			{
				if(r_uv6 == null)
				{
					r_uv6 = new(this, "uv6", -1);
					r_uv6.SetBelong(this.instance);
				}
				return r_uv6;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv7
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv7;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv7
		{
			get
			{
				if(r_uv7 == null)
				{
					r_uv7 = new(this, "uv7", -1);
					r_uv7.SetBelong(this.instance);
				}
				return r_uv7;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv8
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv8;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv8
		{
			get
			{
				if(r_uv8 == null)
				{
					r_uv8 = new(this, "uv8", -1);
					r_uv8.SetBelong(this.instance);
				}
				return r_uv8;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] colors
		/// </summary>
		protected RPropertyArray<RUnityEngine.RColor> r_colors;
		public virtual RPropertyArray<RUnityEngine.RColor> Rcolors
		{
			get
			{
				if(r_colors == null)
				{
					r_colors = new(this, "colors", -1);
					r_colors.SetBelong(this.instance);
				}
				return r_colors;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] colors32
		/// </summary>
		protected RPropertyArray<RUnityEngine.RColor32> r_colors32;
		public virtual RPropertyArray<RUnityEngine.RColor32> Rcolors32
		{
			get
			{
				if(r_colors32 == null)
				{
					r_colors32 = new(this, "colors32", -1);
					r_colors32.SetBelong(this.instance);
				}
				return r_colors32;
			}
		}

		/// <summary>
		/// Int32 vertexAttributeCount
		/// </summary>
		protected RProperty r_vertexAttributeCount;
		public virtual RProperty RvertexAttributeCount
		{
			get
			{
				if(r_vertexAttributeCount == null)
				{
					r_vertexAttributeCount = new(this, "vertexAttributeCount", -1);
					r_vertexAttributeCount.SetBelong(this.instance);
				}
				return r_vertexAttributeCount;
			}
		}

		/// <summary>
		/// Int32[] triangles
		/// </summary>
		protected RPropertyArray<RProperty> r_triangles;
		public virtual RPropertyArray<RProperty> Rtriangles
		{
			get
			{
				if(r_triangles == null)
				{
					r_triangles = new(this, "triangles", -1);
					r_triangles.SetBelong(this.instance);
				}
				return r_triangles;
			}
		}

		/// <summary>
		/// UnityEngine.BoneWeight[] boneWeights
		/// </summary>
		protected RPropertyArray<RUnityEngine.RBoneWeight> r_boneWeights;
		public virtual RPropertyArray<RUnityEngine.RBoneWeight> RboneWeights
		{
			get
			{
				if(r_boneWeights == null)
				{
					r_boneWeights = new(this, "boneWeights", -1);
					r_boneWeights.SetBelong(this.instance);
				}
				return r_boneWeights;
			}
		}

		/// <summary>
		/// UnityEngine.SkinWeights skinWeightBufferLayout
		/// </summary>
		protected RProperty r_skinWeightBufferLayout;
		public virtual RProperty RskinWeightBufferLayout
		{
			get
			{
				if(r_skinWeightBufferLayout == null)
				{
					r_skinWeightBufferLayout = new(this, "skinWeightBufferLayout", -1);
					r_skinWeightBufferLayout.SetBelong(this.instance);
				}
				return r_skinWeightBufferLayout;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.Mesh)
		/// </summary>
		protected static RMethod r_Internal_Create_Mesh;
		public static RMethod RInternal_Create_Mesh
		{
			get
			{
				if(r_Internal_Create_Mesh == null)
				{
					r_Internal_Create_Mesh = new(typeof(UnityEngine.Mesh), "Internal_Create", 0, typeof(UnityEngine.Mesh));
					r_Internal_Create_Mesh.SetBelong(null);
				}
				return r_Internal_Create_Mesh;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh FromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_FromInstanceID_Int32;
		public static RMethod RFromInstanceID_Int32
		{
			get
			{
				if(r_FromInstanceID_Int32 == null)
				{
					r_FromInstanceID_Int32 = new(typeof(UnityEngine.Mesh), "FromInstanceID", 0, typeof(System.Int32));
					r_FromInstanceID_Int32.SetBelong(null);
				}
				return r_FromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetTotalIndexCount()
		/// </summary>
		protected RMethod r_GetTotalIndexCount;
		public virtual RMethod RGetTotalIndexCount
		{
			get
			{
				if(r_GetTotalIndexCount == null)
				{
					r_GetTotalIndexCount = new(this, "GetTotalIndexCount", 0);
					r_GetTotalIndexCount.SetBelong(this.instance);
				}
				return r_GetTotalIndexCount;
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
		/// Void InternalSetIndexBufferData(IntPtr, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_InternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_InternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_InternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetIndexBufferData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_InternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_InternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void InternalSetIndexBufferDataFromArray(System.Array, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_InternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_InternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_InternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetIndexBufferDataFromArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_InternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_InternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromPtr(Int32, IntPtr, Int32)
		/// </summary>
		protected RMethod r_SetVertexBufferParamsFromPtr_Int32_IntPtr_Int32;
		public virtual RMethod RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_SetVertexBufferParamsFromPtr_Int32_IntPtr_Int32 == null)
				{
					r_SetVertexBufferParamsFromPtr_Int32_IntPtr_Int32 = new(this, "SetVertexBufferParamsFromPtr", 0, typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
					r_SetVertexBufferParamsFromPtr_Int32_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_SetVertexBufferParamsFromPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromArray(Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_SetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray;
		public virtual RMethod RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_SetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray == null)
				{
					r_SetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray = new(this, "SetVertexBufferParamsFromArray", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_SetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_SetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void InternalSetVertexBufferData(Int32, IntPtr, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_InternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_InternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_InternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetVertexBufferData", 0, typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_InternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_InternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void InternalSetVertexBufferDataFromArray(Int32, System.Array, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_InternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_InternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_InternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetVertexBufferDataFromArray", 0, typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_InternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_InternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// System.Array GetVertexAttributesAlloc()
		/// </summary>
		protected RMethod r_GetVertexAttributesAlloc;
		public virtual RMethod RGetVertexAttributesAlloc
		{
			get
			{
				if(r_GetVertexAttributesAlloc == null)
				{
					r_GetVertexAttributesAlloc = new(this, "GetVertexAttributesAlloc", 0);
					r_GetVertexAttributesAlloc.SetBelong(this.instance);
				}
				return r_GetVertexAttributesAlloc;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_GetVertexAttributesArray_VertexAttributeDescriptorArray;
		public virtual RMethod RGetVertexAttributesArray_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_GetVertexAttributesArray_VertexAttributeDescriptorArray == null)
				{
					r_GetVertexAttributesArray_VertexAttributeDescriptorArray = new(this, "GetVertexAttributesArray", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_GetVertexAttributesArray_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_GetVertexAttributesArray_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributesList(System.Collections.Generic.List`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_GetVertexAttributesList_List_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_GetVertexAttributesList_List_d_VertexAttributeDescriptor_p_ == null)
				{
					r_GetVertexAttributesList_List_d_VertexAttributeDescriptor_p_ = new(this, "GetVertexAttributesList", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
					r_GetVertexAttributesList_List_d_VertexAttributeDescriptor_p_.SetBelong(this.instance);
				}
				return r_GetVertexAttributesList_List_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeCountImpl()
		/// </summary>
		protected RMethod r_GetVertexAttributeCountImpl;
		public virtual RMethod RGetVertexAttributeCountImpl
		{
			get
			{
				if(r_GetVertexAttributeCountImpl == null)
				{
					r_GetVertexAttributeCountImpl = new(this, "GetVertexAttributeCountImpl", 0);
					r_GetVertexAttributeCountImpl.SetBelong(this.instance);
				}
				return r_GetVertexAttributeCountImpl;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(Int32)
		/// </summary>
		protected RMethod r_GetVertexAttribute_Int32;
		public virtual RMethod RGetVertexAttribute_Int32
		{
			get
			{
				if(r_GetVertexAttribute_Int32 == null)
				{
					r_GetVertexAttribute_Int32 = new(this, "GetVertexAttribute", 0, typeof(System.Int32));
					r_GetVertexAttribute_Int32.SetBelong(this.instance);
				}
				return r_GetVertexAttribute_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexStartImpl(Int32)
		/// </summary>
		protected RMethod r_GetIndexStartImpl_Int32;
		public virtual RMethod RGetIndexStartImpl_Int32
		{
			get
			{
				if(r_GetIndexStartImpl_Int32 == null)
				{
					r_GetIndexStartImpl_Int32 = new(this, "GetIndexStartImpl", 0, typeof(System.Int32));
					r_GetIndexStartImpl_Int32.SetBelong(this.instance);
				}
				return r_GetIndexStartImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexCountImpl(Int32)
		/// </summary>
		protected RMethod r_GetIndexCountImpl_Int32;
		public virtual RMethod RGetIndexCountImpl_Int32
		{
			get
			{
				if(r_GetIndexCountImpl_Int32 == null)
				{
					r_GetIndexCountImpl_Int32 = new(this, "GetIndexCountImpl", 0, typeof(System.Int32));
					r_GetIndexCountImpl_Int32.SetBelong(this.instance);
				}
				return r_GetIndexCountImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetTrianglesCountImpl(Int32)
		/// </summary>
		protected RMethod r_GetTrianglesCountImpl_Int32;
		public virtual RMethod RGetTrianglesCountImpl_Int32
		{
			get
			{
				if(r_GetTrianglesCountImpl_Int32 == null)
				{
					r_GetTrianglesCountImpl_Int32 = new(this, "GetTrianglesCountImpl", 0, typeof(System.Int32));
					r_GetTrianglesCountImpl_Int32.SetBelong(this.instance);
				}
				return r_GetTrianglesCountImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetBaseVertexImpl(Int32)
		/// </summary>
		protected RMethod r_GetBaseVertexImpl_Int32;
		public virtual RMethod RGetBaseVertexImpl_Int32
		{
			get
			{
				if(r_GetBaseVertexImpl_Int32 == null)
				{
					r_GetBaseVertexImpl_Int32 = new(this, "GetBaseVertexImpl", 0, typeof(System.Int32));
					r_GetBaseVertexImpl_Int32.SetBelong(this.instance);
				}
				return r_GetBaseVertexImpl_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTrianglesImpl(Int32, Boolean)
		/// </summary>
		protected RMethod r_GetTrianglesImpl_Int32_Boolean;
		public virtual RMethod RGetTrianglesImpl_Int32_Boolean
		{
			get
			{
				if(r_GetTrianglesImpl_Int32_Boolean == null)
				{
					r_GetTrianglesImpl_Int32_Boolean = new(this, "GetTrianglesImpl", 0, typeof(System.Int32), typeof(System.Boolean));
					r_GetTrianglesImpl_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetTrianglesImpl_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32[] GetIndicesImpl(Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndicesImpl_Int32_Boolean;
		public virtual RMethod RGetIndicesImpl_Int32_Boolean
		{
			get
			{
				if(r_GetIndicesImpl_Int32_Boolean == null)
				{
					r_GetIndicesImpl_Int32_Boolean = new(this, "GetIndicesImpl", 0, typeof(System.Int32), typeof(System.Boolean));
					r_GetIndicesImpl_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndicesImpl_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndicesImpl(Int32, UnityEngine.MeshTopology, UnityEngine.Rendering.IndexFormat, System.Array, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32 = new(this, "SetIndicesImpl", 0, typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndicesNativeArrayImpl(Int32, UnityEngine.MeshTopology, UnityEngine.Rendering.IndexFormat, IntPtr, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32 = new(this, "SetIndicesNativeArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void GetTrianglesNonAllocImpl(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetTrianglesNonAllocImpl_Int32Array_Int32_Boolean;
		public virtual RMethod RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_GetTrianglesNonAllocImpl_Int32Array_Int32_Boolean == null)
				{
					r_GetTrianglesNonAllocImpl_Int32Array_Int32_Boolean = new(this, "GetTrianglesNonAllocImpl", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetTrianglesNonAllocImpl_Int32Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetTrianglesNonAllocImpl_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTrianglesNonAllocImpl16(UInt16[], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean;
		public virtual RMethod RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean
		{
			get
			{
				if(r_GetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean == null)
				{
					r_GetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean = new(this, "GetTrianglesNonAllocImpl16", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndicesNonAllocImpl(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndicesNonAllocImpl_Int32Array_Int32_Boolean;
		public virtual RMethod RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_GetIndicesNonAllocImpl_Int32Array_Int32_Boolean == null)
				{
					r_GetIndicesNonAllocImpl_Int32Array_Int32_Boolean = new(this, "GetIndicesNonAllocImpl", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetIndicesNonAllocImpl_Int32Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndicesNonAllocImpl_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndicesNonAllocImpl16(UInt16[], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean;
		public virtual RMethod RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean
		{
			get
			{
				if(r_GetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean == null)
				{
					r_GetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean = new(this, "GetIndicesNonAllocImpl16", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_GetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_PrintErrorCantAccessChannel_VertexAttribute;
		public virtual RMethod RPrintErrorCantAccessChannel_VertexAttribute
		{
			get
			{
				if(r_PrintErrorCantAccessChannel_VertexAttribute == null)
				{
					r_PrintErrorCantAccessChannel_VertexAttribute = new(this, "PrintErrorCantAccessChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_PrintErrorCantAccessChannel_VertexAttribute.SetBelong(this.instance);
				}
				return r_PrintErrorCantAccessChannel_VertexAttribute;
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
		/// Void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetArrayForChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetNativeArrayForChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_GetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_GetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_GetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32 = new(this, "GetAllocArrayFromChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
					r_GetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32.SetBelong(this.instance);
				}
				return r_GetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array)
		/// </summary>
		protected RMethod r_GetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array;
		public virtual RMethod RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array
		{
			get
			{
				if(r_GetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array == null)
				{
					r_GetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array = new(this, "GetArrayFromChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array));
					r_GetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array.SetBelong(this.instance);
				}
				return r_GetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array;
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
		/// IntPtr GetNativeVertexBufferPtr(Int32)
		/// </summary>
		protected RMethod r_GetNativeVertexBufferPtr_Int32;
		public virtual RMethod RGetNativeVertexBufferPtr_Int32
		{
			get
			{
				if(r_GetNativeVertexBufferPtr_Int32 == null)
				{
					r_GetNativeVertexBufferPtr_Int32 = new(this, "GetNativeVertexBufferPtr", 0, typeof(System.Int32));
					r_GetNativeVertexBufferPtr_Int32.SetBelong(this.instance);
				}
				return r_GetNativeVertexBufferPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetNativeIndexBufferPtr()
		/// </summary>
		protected RMethod r_GetNativeIndexBufferPtr;
		public virtual RMethod RGetNativeIndexBufferPtr
		{
			get
			{
				if(r_GetNativeIndexBufferPtr == null)
				{
					r_GetNativeIndexBufferPtr = new(this, "GetNativeIndexBufferPtr", 0);
					r_GetNativeIndexBufferPtr.SetBelong(this.instance);
				}
				return r_GetNativeIndexBufferPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetVertexBufferImpl(Int32)
		/// </summary>
		protected RMethod r_GetVertexBufferImpl_Int32;
		public virtual RMethod RGetVertexBufferImpl_Int32
		{
			get
			{
				if(r_GetVertexBufferImpl_Int32 == null)
				{
					r_GetVertexBufferImpl_Int32 = new(this, "GetVertexBufferImpl", 0, typeof(System.Int32));
					r_GetVertexBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_GetVertexBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetIndexBufferImpl()
		/// </summary>
		protected RMethod r_GetIndexBufferImpl;
		public virtual RMethod RGetIndexBufferImpl
		{
			get
			{
				if(r_GetIndexBufferImpl == null)
				{
					r_GetIndexBufferImpl = new(this, "GetIndexBufferImpl", 0);
					r_GetIndexBufferImpl.SetBelong(this.instance);
				}
				return r_GetIndexBufferImpl;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(Int32)
		/// </summary>
		protected RMethod r_GetBoneWeightBufferImpl_Int32;
		public virtual RMethod RGetBoneWeightBufferImpl_Int32
		{
			get
			{
				if(r_GetBoneWeightBufferImpl_Int32 == null)
				{
					r_GetBoneWeightBufferImpl_Int32 = new(this, "GetBoneWeightBufferImpl", 0, typeof(System.Int32));
					r_GetBoneWeightBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_GetBoneWeightBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(Int32)
		/// </summary>
		protected RMethod r_GetBlendShapeBufferImpl_Int32;
		public virtual RMethod RGetBlendShapeBufferImpl_Int32
		{
			get
			{
				if(r_GetBlendShapeBufferImpl_Int32 == null)
				{
					r_GetBlendShapeBufferImpl_Int32 = new(this, "GetBlendShapeBufferImpl", 0, typeof(System.Int32));
					r_GetBlendShapeBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_GetBlendShapeBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Void ClearBlendShapes()
		/// </summary>
		protected RMethod r_ClearBlendShapes;
		public virtual RMethod RClearBlendShapes
		{
			get
			{
				if(r_ClearBlendShapes == null)
				{
					r_ClearBlendShapes = new(this, "ClearBlendShapes", 0);
					r_ClearBlendShapes.SetBelong(this.instance);
				}
				return r_ClearBlendShapes;
			}
		}

		/// <summary>
		/// System.String GetBlendShapeName(Int32)
		/// </summary>
		protected RMethod r_GetBlendShapeName_Int32;
		public virtual RMethod RGetBlendShapeName_Int32
		{
			get
			{
				if(r_GetBlendShapeName_Int32 == null)
				{
					r_GetBlendShapeName_Int32 = new(this, "GetBlendShapeName", 0, typeof(System.Int32));
					r_GetBlendShapeName_Int32.SetBelong(this.instance);
				}
				return r_GetBlendShapeName_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBlendShapeIndex(System.String)
		/// </summary>
		protected RMethod r_GetBlendShapeIndex_String;
		public virtual RMethod RGetBlendShapeIndex_String
		{
			get
			{
				if(r_GetBlendShapeIndex_String == null)
				{
					r_GetBlendShapeIndex_String = new(this, "GetBlendShapeIndex", 0, typeof(System.String));
					r_GetBlendShapeIndex_String.SetBelong(this.instance);
				}
				return r_GetBlendShapeIndex_String;
			}
		}

		/// <summary>
		/// Int32 GetBlendShapeFrameCount(Int32)
		/// </summary>
		protected RMethod r_GetBlendShapeFrameCount_Int32;
		public virtual RMethod RGetBlendShapeFrameCount_Int32
		{
			get
			{
				if(r_GetBlendShapeFrameCount_Int32 == null)
				{
					r_GetBlendShapeFrameCount_Int32 = new(this, "GetBlendShapeFrameCount", 0, typeof(System.Int32));
					r_GetBlendShapeFrameCount_Int32.SetBelong(this.instance);
				}
				return r_GetBlendShapeFrameCount_Int32;
			}
		}

		/// <summary>
		/// Single GetBlendShapeFrameWeight(Int32, Int32)
		/// </summary>
		protected RMethod r_GetBlendShapeFrameWeight_Int32_Int32;
		public virtual RMethod RGetBlendShapeFrameWeight_Int32_Int32
		{
			get
			{
				if(r_GetBlendShapeFrameWeight_Int32_Int32 == null)
				{
					r_GetBlendShapeFrameWeight_Int32_Int32 = new(this, "GetBlendShapeFrameWeight", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetBlendShapeFrameWeight_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetBlendShapeFrameWeight_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetBlendShapeFrameVertices(Int32, Int32, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_GetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array;
		public virtual RMethod RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array
		{
			get
			{
				if(r_GetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array == null)
				{
					r_GetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array = new(this, "GetBlendShapeFrameVertices", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType());
					r_GetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array.SetBelong(this.instance);
				}
				return r_GetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array;
			}
		}

		/// <summary>
		/// Void AddBlendShapeFrame(System.String, Single, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_AddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array;
		public virtual RMethod RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array
		{
			get
			{
				if(r_AddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array == null)
				{
					r_AddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array = new(this, "AddBlendShapeFrame", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType());
					r_AddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array.SetBelong(this.instance);
				}
				return r_AddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array;
			}
		}

		/// <summary>
		/// UnityEngine.BlendShape GetBlendShapeOffsetInternal(Int32)
		/// </summary>
		protected RMethod r_GetBlendShapeOffsetInternal_Int32;
		public virtual RMethod RGetBlendShapeOffsetInternal_Int32
		{
			get
			{
				if(r_GetBlendShapeOffsetInternal_Int32 == null)
				{
					r_GetBlendShapeOffsetInternal_Int32 = new(this, "GetBlendShapeOffsetInternal", 0, typeof(System.Int32));
					r_GetBlendShapeOffsetInternal_Int32.SetBelong(this.instance);
				}
				return r_GetBlendShapeOffsetInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBoneWeights()
		/// </summary>
		protected RMethod r_HasBoneWeights;
		public virtual RMethod RHasBoneWeights
		{
			get
			{
				if(r_HasBoneWeights == null)
				{
					r_HasBoneWeights = new(this, "HasBoneWeights", 0);
					r_HasBoneWeights.SetBelong(this.instance);
				}
				return r_HasBoneWeights;
			}
		}

		/// <summary>
		/// UnityEngine.BoneWeight[] GetBoneWeightsImpl()
		/// </summary>
		protected RMethod r_GetBoneWeightsImpl;
		public virtual RMethod RGetBoneWeightsImpl
		{
			get
			{
				if(r_GetBoneWeightsImpl == null)
				{
					r_GetBoneWeightsImpl = new(this, "GetBoneWeightsImpl", 0);
					r_GetBoneWeightsImpl.SetBelong(this.instance);
				}
				return r_GetBoneWeightsImpl;
			}
		}

		/// <summary>
		/// Void SetBoneWeightsImpl(UnityEngine.BoneWeight[])
		/// </summary>
		protected RMethod r_SetBoneWeightsImpl_BoneWeightArray;
		public virtual RMethod RSetBoneWeightsImpl_BoneWeightArray
		{
			get
			{
				if(r_SetBoneWeightsImpl_BoneWeightArray == null)
				{
					r_SetBoneWeightsImpl_BoneWeightArray = new(this, "SetBoneWeightsImpl", 0, typeof(UnityEngine.BoneWeight).MakeArrayType());
					r_SetBoneWeightsImpl_BoneWeightArray.SetBelong(this.instance);
				}
				return r_SetBoneWeightsImpl_BoneWeightArray;
			}
		}

		/// <summary>
		/// Void SetBoneWeights(Unity.Collections.NativeArray`1[System.Byte], Unity.Collections.NativeArray`1[UnityEngine.BoneWeight1])
		/// </summary>
		protected RMethod r_SetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_;
		public virtual RMethod RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_
		{
			get
			{
				if(r_SetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_ == null)
				{
					r_SetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_ = new(this, "SetBoneWeights", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.Byte)), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.BoneWeight1)));
					r_SetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_.SetBelong(this.instance);
				}
				return r_SetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_;
			}
		}

		/// <summary>
		/// Void InternalSetBoneWeights(IntPtr, Int32, IntPtr, Int32)
		/// </summary>
		protected RMethod r_InternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32;
		public virtual RMethod RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_InternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32 == null)
				{
					r_InternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32 = new(this, "InternalSetBoneWeights", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
					r_InternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_InternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.BoneWeight1] GetAllBoneWeights()
		/// </summary>
		protected RMethod r_GetAllBoneWeights;
		public virtual RMethod RGetAllBoneWeights
		{
			get
			{
				if(r_GetAllBoneWeights == null)
				{
					r_GetAllBoneWeights = new(this, "GetAllBoneWeights", 0);
					r_GetAllBoneWeights.SetBelong(this.instance);
				}
				return r_GetAllBoneWeights;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[System.Byte] GetBonesPerVertex()
		/// </summary>
		protected RMethod r_GetBonesPerVertex;
		public virtual RMethod RGetBonesPerVertex
		{
			get
			{
				if(r_GetBonesPerVertex == null)
				{
					r_GetBonesPerVertex = new(this, "GetBonesPerVertex", 0);
					r_GetBonesPerVertex.SetBelong(this.instance);
				}
				return r_GetBonesPerVertex;
			}
		}

		/// <summary>
		/// Int32 GetAllBoneWeightsArraySize()
		/// </summary>
		protected RMethod r_GetAllBoneWeightsArraySize;
		public virtual RMethod RGetAllBoneWeightsArraySize
		{
			get
			{
				if(r_GetAllBoneWeightsArraySize == null)
				{
					r_GetAllBoneWeightsArraySize = new(this, "GetAllBoneWeightsArraySize", 0);
					r_GetAllBoneWeightsArraySize.SetBelong(this.instance);
				}
				return r_GetAllBoneWeightsArraySize;
			}
		}

		/// <summary>
		/// Int32 GetBoneWeightBufferLayoutInternal()
		/// </summary>
		protected RMethod r_GetBoneWeightBufferLayoutInternal;
		public virtual RMethod RGetBoneWeightBufferLayoutInternal
		{
			get
			{
				if(r_GetBoneWeightBufferLayoutInternal == null)
				{
					r_GetBoneWeightBufferLayoutInternal = new(this, "GetBoneWeightBufferLayoutInternal", 0);
					r_GetBoneWeightBufferLayoutInternal.SetBelong(this.instance);
				}
				return r_GetBoneWeightBufferLayoutInternal;
			}
		}

		/// <summary>
		/// IntPtr GetAllBoneWeightsArray()
		/// </summary>
		protected RMethod r_GetAllBoneWeightsArray;
		public virtual RMethod RGetAllBoneWeightsArray
		{
			get
			{
				if(r_GetAllBoneWeightsArray == null)
				{
					r_GetAllBoneWeightsArray = new(this, "GetAllBoneWeightsArray", 0);
					r_GetAllBoneWeightsArray.SetBelong(this.instance);
				}
				return r_GetAllBoneWeightsArray;
			}
		}

		/// <summary>
		/// IntPtr GetBonesPerVertexArray()
		/// </summary>
		protected RMethod r_GetBonesPerVertexArray;
		public virtual RMethod RGetBonesPerVertexArray
		{
			get
			{
				if(r_GetBonesPerVertexArray == null)
				{
					r_GetBonesPerVertexArray = new(this, "GetBonesPerVertexArray", 0);
					r_GetBonesPerVertexArray.SetBelong(this.instance);
				}
				return r_GetBonesPerVertexArray;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.Matrix4x4] GetBindposes()
		/// </summary>
		protected RMethod r_GetBindposes;
		public virtual RMethod RGetBindposes
		{
			get
			{
				if(r_GetBindposes == null)
				{
					r_GetBindposes = new(this, "GetBindposes", 0);
					r_GetBindposes.SetBelong(this.instance);
				}
				return r_GetBindposes;
			}
		}

		/// <summary>
		/// IntPtr GetBindposesArray()
		/// </summary>
		protected RMethod r_GetBindposesArray;
		public virtual RMethod RGetBindposesArray
		{
			get
			{
				if(r_GetBindposesArray == null)
				{
					r_GetBindposesArray = new(this, "GetBindposesArray", 0);
					r_GetBindposesArray.SetBelong(this.instance);
				}
				return r_GetBindposesArray;
			}
		}

		/// <summary>
		/// Void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[])
		/// </summary>
		protected RMethod r_GetBoneWeightsNonAllocImpl_BoneWeightArray;
		public virtual RMethod RGetBoneWeightsNonAllocImpl_BoneWeightArray
		{
			get
			{
				if(r_GetBoneWeightsNonAllocImpl_BoneWeightArray == null)
				{
					r_GetBoneWeightsNonAllocImpl_BoneWeightArray = new(this, "GetBoneWeightsNonAllocImpl", 0, typeof(UnityEngine.BoneWeight).MakeArrayType());
					r_GetBoneWeightsNonAllocImpl_BoneWeightArray.SetBelong(this.instance);
				}
				return r_GetBoneWeightsNonAllocImpl_BoneWeightArray;
			}
		}

		/// <summary>
		/// Void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_GetBindposesNonAllocImpl_Matrix4x4Array;
		public virtual RMethod RGetBindposesNonAllocImpl_Matrix4x4Array
		{
			get
			{
				if(r_GetBindposesNonAllocImpl_Matrix4x4Array == null)
				{
					r_GetBindposesNonAllocImpl_Matrix4x4Array = new(this, "GetBindposesNonAllocImpl", 0, typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_GetBindposesNonAllocImpl_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_GetBindposesNonAllocImpl_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetReadOnlySafetyHandle(SafetyHandleIndex)
		/// </summary>
		protected RMethod r_GetReadOnlySafetyHandle_SafetyHandleIndex;
		public virtual RMethod RGetReadOnlySafetyHandle_SafetyHandleIndex
		{
			get
			{
				if(r_GetReadOnlySafetyHandle_SafetyHandleIndex == null)
				{
					r_GetReadOnlySafetyHandle_SafetyHandleIndex = new(this, "GetReadOnlySafetyHandle", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+SafetyHandleIndex"));
					r_GetReadOnlySafetyHandle_SafetyHandleIndex.SetBelong(this.instance);
				}
				return r_GetReadOnlySafetyHandle_SafetyHandleIndex;
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
		/// Void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetAllSubMeshesAtOnceFromArray", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetAllSubMeshesAtOnceFromNativeArray(IntPtr, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags = new(this, "SetAllSubMeshesAtOnceFromNativeArray", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ClearImpl(Boolean)
		/// </summary>
		protected RMethod r_ClearImpl_Boolean;
		public virtual RMethod RClearImpl_Boolean
		{
			get
			{
				if(r_ClearImpl_Boolean == null)
				{
					r_ClearImpl_Boolean = new(this, "ClearImpl", 0, typeof(System.Boolean));
					r_ClearImpl_Boolean.SetBelong(this.instance);
				}
				return r_ClearImpl_Boolean;
			}
		}

		/// <summary>
		/// Void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RecalculateBoundsImpl_MeshUpdateFlags;
		public virtual RMethod RRecalculateBoundsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_RecalculateBoundsImpl_MeshUpdateFlags == null)
				{
					r_RecalculateBoundsImpl_MeshUpdateFlags = new(this, "RecalculateBoundsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RecalculateBoundsImpl_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RecalculateBoundsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RecalculateNormalsImpl_MeshUpdateFlags;
		public virtual RMethod RRecalculateNormalsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_RecalculateNormalsImpl_MeshUpdateFlags == null)
				{
					r_RecalculateNormalsImpl_MeshUpdateFlags = new(this, "RecalculateNormalsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RecalculateNormalsImpl_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RecalculateNormalsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RecalculateTangentsImpl_MeshUpdateFlags;
		public virtual RMethod RRecalculateTangentsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_RecalculateTangentsImpl_MeshUpdateFlags == null)
				{
					r_RecalculateTangentsImpl_MeshUpdateFlags = new(this, "RecalculateTangentsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RecalculateTangentsImpl_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RecalculateTangentsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void MarkDynamicImpl()
		/// </summary>
		protected RMethod r_MarkDynamicImpl;
		public virtual RMethod RMarkDynamicImpl
		{
			get
			{
				if(r_MarkDynamicImpl == null)
				{
					r_MarkDynamicImpl = new(this, "MarkDynamicImpl", 0);
					r_MarkDynamicImpl.SetBelong(this.instance);
				}
				return r_MarkDynamicImpl;
			}
		}

		/// <summary>
		/// Void MarkModified()
		/// </summary>
		protected RMethod r_MarkModified;
		public virtual RMethod RMarkModified
		{
			get
			{
				if(r_MarkModified == null)
				{
					r_MarkModified = new(this, "MarkModified", 0);
					r_MarkModified.SetBelong(this.instance);
				}
				return r_MarkModified;
			}
		}

		/// <summary>
		/// Void UploadMeshDataImpl(Boolean)
		/// </summary>
		protected RMethod r_UploadMeshDataImpl_Boolean;
		public virtual RMethod RUploadMeshDataImpl_Boolean
		{
			get
			{
				if(r_UploadMeshDataImpl_Boolean == null)
				{
					r_UploadMeshDataImpl_Boolean = new(this, "UploadMeshDataImpl", 0, typeof(System.Boolean));
					r_UploadMeshDataImpl_Boolean.SetBelong(this.instance);
				}
				return r_UploadMeshDataImpl_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology GetTopologyImpl(Int32)
		/// </summary>
		protected RMethod r_GetTopologyImpl_Int32;
		public virtual RMethod RGetTopologyImpl_Int32
		{
			get
			{
				if(r_GetTopologyImpl_Int32 == null)
				{
					r_GetTopologyImpl_Int32 = new(this, "GetTopologyImpl", 0, typeof(System.Int32));
					r_GetTopologyImpl_Int32.SetBelong(this.instance);
				}
				return r_GetTopologyImpl_Int32;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetricImpl(Int32, Single)
		/// </summary>
		protected RMethod r_RecalculateUVDistributionMetricImpl_Int32_Single;
		public virtual RMethod RRecalculateUVDistributionMetricImpl_Int32_Single
		{
			get
			{
				if(r_RecalculateUVDistributionMetricImpl_Int32_Single == null)
				{
					r_RecalculateUVDistributionMetricImpl_Int32_Single = new(this, "RecalculateUVDistributionMetricImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_RecalculateUVDistributionMetricImpl_Int32_Single.SetBelong(this.instance);
				}
				return r_RecalculateUVDistributionMetricImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetricsImpl(Single)
		/// </summary>
		protected RMethod r_RecalculateUVDistributionMetricsImpl_Single;
		public virtual RMethod RRecalculateUVDistributionMetricsImpl_Single
		{
			get
			{
				if(r_RecalculateUVDistributionMetricsImpl_Single == null)
				{
					r_RecalculateUVDistributionMetricsImpl_Single = new(this, "RecalculateUVDistributionMetricsImpl", 0, typeof(System.Single));
					r_RecalculateUVDistributionMetricsImpl_Single.SetBelong(this.instance);
				}
				return r_RecalculateUVDistributionMetricsImpl_Single;
			}
		}

		/// <summary>
		/// Single GetUVDistributionMetric(Int32)
		/// </summary>
		protected RMethod r_GetUVDistributionMetric_Int32;
		public virtual RMethod RGetUVDistributionMetric_Int32
		{
			get
			{
				if(r_GetUVDistributionMetric_Int32 == null)
				{
					r_GetUVDistributionMetric_Int32 = new(this, "GetUVDistributionMetric", 0, typeof(System.Int32));
					r_GetUVDistributionMetric_Int32.SetBelong(this.instance);
				}
				return r_GetUVDistributionMetric_Int32;
			}
		}

		/// <summary>
		/// Void CombineMeshesImpl(UnityEngine.CombineInstance[], Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_CombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean;
		public virtual RMethod RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_CombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean == null)
				{
					r_CombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean = new(this, "CombineMeshesImpl", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_CombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_CombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OptimizeImpl()
		/// </summary>
		protected RMethod r_OptimizeImpl;
		public virtual RMethod ROptimizeImpl
		{
			get
			{
				if(r_OptimizeImpl == null)
				{
					r_OptimizeImpl = new(this, "OptimizeImpl", 0);
					r_OptimizeImpl.SetBelong(this.instance);
				}
				return r_OptimizeImpl;
			}
		}

		/// <summary>
		/// Void OptimizeIndexBuffersImpl()
		/// </summary>
		protected RMethod r_OptimizeIndexBuffersImpl;
		public virtual RMethod ROptimizeIndexBuffersImpl
		{
			get
			{
				if(r_OptimizeIndexBuffersImpl == null)
				{
					r_OptimizeIndexBuffersImpl = new(this, "OptimizeIndexBuffersImpl", 0);
					r_OptimizeIndexBuffersImpl.SetBelong(this.instance);
				}
				return r_OptimizeIndexBuffersImpl;
			}
		}

		/// <summary>
		/// Void OptimizeReorderVertexBufferImpl()
		/// </summary>
		protected RMethod r_OptimizeReorderVertexBufferImpl;
		public virtual RMethod ROptimizeReorderVertexBufferImpl
		{
			get
			{
				if(r_OptimizeReorderVertexBufferImpl == null)
				{
					r_OptimizeReorderVertexBufferImpl = new(this, "OptimizeReorderVertexBufferImpl", 0);
					r_OptimizeReorderVertexBufferImpl.SetBelong(this.instance);
				}
				return r_OptimizeReorderVertexBufferImpl;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute GetUVChannel(Int32)
		/// </summary>
		protected static RMethod r_GetUVChannel_Int32;
		public static RMethod RGetUVChannel_Int32
		{
			get
			{
				if(r_GetUVChannel_Int32 == null)
				{
					r_GetUVChannel_Int32 = new(typeof(UnityEngine.Mesh), "GetUVChannel", 0, typeof(System.Int32));
					r_GetUVChannel_Int32.SetBelong(null);
				}
				return r_GetUVChannel_Int32;
			}
		}

		/// <summary>
		/// Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_DefaultDimensionForChannel_VertexAttribute;
		public static RMethod RDefaultDimensionForChannel_VertexAttribute
		{
			get
			{
				if(r_DefaultDimensionForChannel_VertexAttribute == null)
				{
					r_DefaultDimensionForChannel_VertexAttribute = new(typeof(UnityEngine.Mesh), "DefaultDimensionForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_DefaultDimensionForChannel_VertexAttribute.SetBelong(null);
				}
				return r_DefaultDimensionForChannel_VertexAttribute;
			}
		}

		/// <summary>
		/// T[] GetAllocArrayFromChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_GetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_GetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_GetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32 = new(this, "GetAllocArrayFromChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
					r_GetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32.SetBelong(this.instance);
				}
				return r_GetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// T[] GetAllocArrayFromChannel[T](UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_GetAllocArrayFromChannel_GT_VertexAttribute;
		public virtual RMethod RGetAllocArrayFromChannel_GT_VertexAttribute
		{
			get
			{
				if(r_GetAllocArrayFromChannel_GT_VertexAttribute == null)
				{
					r_GetAllocArrayFromChannel_GT_VertexAttribute = new(this, "GetAllocArrayFromChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute));
					r_GetAllocArrayFromChannel_GT_VertexAttribute.SetBelong(this.instance);
				}
				return r_GetAllocArrayFromChannel_GT_VertexAttribute;
			}
		}

		/// <summary>
		/// Void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetSizedArrayForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetSizedNativeArrayForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetArrayForChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, T[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags;
		public virtual RMethod RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags
		{
			get
			{
				if(r_SetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags == null)
				{
					r_SetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags = new(this, "SetArrayForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetArrayForChannel[T](UnityEngine.Rendering.VertexAttribute, T[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags;
		public virtual RMethod RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags
		{
			get
			{
				if(r_SetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags == null)
				{
					r_SetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags = new(this, "SetArrayForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetListForChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetListForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetListForChannel[T](UnityEngine.Rendering.VertexAttribute, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetListForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetListForChannel[T](System.Collections.Generic.List`1[T], Int32, UnityEngine.Rendering.VertexAttribute, Int32)
		/// </summary>
		protected RMethod r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32;
		public virtual RMethod RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32
		{
			get
			{
				if(r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32 == null)
				{
					r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32 = new(this, "GetListForChannel", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Int32));
					r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32.SetBelong(this.instance);
				}
				return r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32;
			}
		}

		/// <summary>
		/// Void GetListForChannel[T](System.Collections.Generic.List`1[T], Int32, UnityEngine.Rendering.VertexAttribute, Int32, UnityEngine.Rendering.VertexAttributeFormat)
		/// </summary>
		protected RMethod r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat;
		public virtual RMethod RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat
		{
			get
			{
				if(r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat == null)
				{
					r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat = new(this, "GetListForChannel", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeFormat));
					r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat.SetBelong(this.instance);
				}
				return r_GetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat;
			}
		}

		/// <summary>
		/// Void GetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_GetVertices_List_d_Vector3_p_;
		public virtual RMethod RGetVertices_List_d_Vector3_p_
		{
			get
			{
				if(r_GetVertices_List_d_Vector3_p_ == null)
				{
					r_GetVertices_List_d_Vector3_p_ = new(this, "GetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_GetVertices_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_GetVertices_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_SetVertices_List_d_Vector3_p_;
		public virtual RMethod RSetVertices_List_d_Vector3_p_
		{
			get
			{
				if(r_SetVertices_List_d_Vector3_p_ == null)
				{
					r_SetVertices_List_d_Vector3_p_ = new(this, "SetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_SetVertices_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_SetVertices_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_SetVertices_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RSetVertices_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_SetVertices_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_SetVertices_List_d_Vector3_p__Int32_Int32 = new(this, "SetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
					r_SetVertices_List_d_Vector3_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetVertices_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_SetVertices_Vector3Array;
		public virtual RMethod RSetVertices_Vector3Array
		{
			get
			{
				if(r_SetVertices_Vector3Array == null)
				{
					r_SetVertices_Vector3Array = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType());
					r_SetVertices_Vector3Array.SetBelong(this.instance);
				}
				return r_SetVertices_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetVertices_Vector3Array_Int32_Int32;
		public virtual RMethod RSetVertices_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_SetVertices_Vector3Array_Int32_Int32 == null)
				{
					r_SetVertices_Vector3Array_Int32_Int32 = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetVertices_Vector3Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetVertices_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_SetVertices_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetVertices_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_SetVertices_GT_NativeArray_d_T_p_ == null)
				{
					r_SetVertices_GT_NativeArray_d_T_p_ = new(this, "SetVertices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetVertices_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_SetVertices_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetVertices_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetVertices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_GetNormals_List_d_Vector3_p_;
		public virtual RMethod RGetNormals_List_d_Vector3_p_
		{
			get
			{
				if(r_GetNormals_List_d_Vector3_p_ == null)
				{
					r_GetNormals_List_d_Vector3_p_ = new(this, "GetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_GetNormals_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_GetNormals_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_SetNormals_List_d_Vector3_p_;
		public virtual RMethod RSetNormals_List_d_Vector3_p_
		{
			get
			{
				if(r_SetNormals_List_d_Vector3_p_ == null)
				{
					r_SetNormals_List_d_Vector3_p_ = new(this, "SetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_SetNormals_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_SetNormals_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_SetNormals_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RSetNormals_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_SetNormals_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_SetNormals_List_d_Vector3_p__Int32_Int32 = new(this, "SetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
					r_SetNormals_List_d_Vector3_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetNormals_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_SetNormals_Vector3Array;
		public virtual RMethod RSetNormals_Vector3Array
		{
			get
			{
				if(r_SetNormals_Vector3Array == null)
				{
					r_SetNormals_Vector3Array = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType());
					r_SetNormals_Vector3Array.SetBelong(this.instance);
				}
				return r_SetNormals_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetNormals_Vector3Array_Int32_Int32;
		public virtual RMethod RSetNormals_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_SetNormals_Vector3Array_Int32_Int32 == null)
				{
					r_SetNormals_Vector3Array_Int32_Int32 = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetNormals_Vector3Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetNormals_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_SetNormals_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetNormals_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_SetNormals_GT_NativeArray_d_T_p_ == null)
				{
					r_SetNormals_GT_NativeArray_d_T_p_ = new(this, "SetNormals", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetNormals_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_SetNormals_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetNormals_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetNormals", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_GetTangents_List_d_Vector4_p_;
		public virtual RMethod RGetTangents_List_d_Vector4_p_
		{
			get
			{
				if(r_GetTangents_List_d_Vector4_p_ == null)
				{
					r_GetTangents_List_d_Vector4_p_ = new(this, "GetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetTangents_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_GetTangents_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_SetTangents_List_d_Vector4_p_;
		public virtual RMethod RSetTangents_List_d_Vector4_p_
		{
			get
			{
				if(r_SetTangents_List_d_Vector4_p_ == null)
				{
					r_SetTangents_List_d_Vector4_p_ = new(this, "SetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_SetTangents_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_SetTangents_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32)
		/// </summary>
		protected RMethod r_SetTangents_List_d_Vector4_p__Int32_Int32;
		public virtual RMethod RSetTangents_List_d_Vector4_p__Int32_Int32
		{
			get
			{
				if(r_SetTangents_List_d_Vector4_p__Int32_Int32 == null)
				{
					r_SetTangents_List_d_Vector4_p__Int32_Int32 = new(this, "SetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32));
					r_SetTangents_List_d_Vector4_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetTangents_List_d_Vector4_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_SetTangents_Vector4Array;
		public virtual RMethod RSetTangents_Vector4Array
		{
			get
			{
				if(r_SetTangents_Vector4Array == null)
				{
					r_SetTangents_Vector4Array = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType());
					r_SetTangents_Vector4Array.SetBelong(this.instance);
				}
				return r_SetTangents_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetTangents_Vector4Array_Int32_Int32;
		public virtual RMethod RSetTangents_Vector4Array_Int32_Int32
		{
			get
			{
				if(r_SetTangents_Vector4Array_Int32_Int32 == null)
				{
					r_SetTangents_Vector4Array_Int32_Int32 = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetTangents_Vector4Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetTangents_Vector4Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_SetTangents_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetTangents_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_SetTangents_GT_NativeArray_d_T_p_ == null)
				{
					r_SetTangents_GT_NativeArray_d_T_p_ = new(this, "SetTangents", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetTangents_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_SetTangents_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetTangents_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetTangents", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetColors(System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_GetColors_List_d_Color_p_;
		public virtual RMethod RGetColors_List_d_Color_p_
		{
			get
			{
				if(r_GetColors_List_d_Color_p_ == null)
				{
					r_GetColors_List_d_Color_p_ = new(this, "GetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_GetColors_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_GetColors_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_SetColors_List_d_Color_p_;
		public virtual RMethod RSetColors_List_d_Color_p_
		{
			get
			{
				if(r_SetColors_List_d_Color_p_ == null)
				{
					r_SetColors_List_d_Color_p_ = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_SetColors_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_SetColors_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color], Int32, Int32)
		/// </summary>
		protected RMethod r_SetColors_List_d_Color_p__Int32_Int32;
		public virtual RMethod RSetColors_List_d_Color_p__Int32_Int32
		{
			get
			{
				if(r_SetColors_List_d_Color_p__Int32_Int32 == null)
				{
					r_SetColors_List_d_Color_p__Int32_Int32 = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)), typeof(System.Int32), typeof(System.Int32));
					r_SetColors_List_d_Color_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetColors_List_d_Color_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[])
		/// </summary>
		protected RMethod r_SetColors_ColorArray;
		public virtual RMethod RSetColors_ColorArray
		{
			get
			{
				if(r_SetColors_ColorArray == null)
				{
					r_SetColors_ColorArray = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType());
					r_SetColors_ColorArray.SetBelong(this.instance);
				}
				return r_SetColors_ColorArray;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetColors_ColorArray_Int32_Int32;
		public virtual RMethod RSetColors_ColorArray_Int32_Int32
		{
			get
			{
				if(r_SetColors_ColorArray_Int32_Int32 == null)
				{
					r_SetColors_ColorArray_Int32_Int32 = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetColors_ColorArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetColors_ColorArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetColors_ColorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetColors_ColorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetColors_ColorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetColors_ColorArray_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetColors_ColorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetColors(System.Collections.Generic.List`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_GetColors_List_d_Color32_p_;
		public virtual RMethod RGetColors_List_d_Color32_p_
		{
			get
			{
				if(r_GetColors_List_d_Color32_p_ == null)
				{
					r_GetColors_List_d_Color32_p_ = new(this, "GetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)));
					r_GetColors_List_d_Color32_p_.SetBelong(this.instance);
				}
				return r_GetColors_List_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_SetColors_List_d_Color32_p_;
		public virtual RMethod RSetColors_List_d_Color32_p_
		{
			get
			{
				if(r_SetColors_List_d_Color32_p_ == null)
				{
					r_SetColors_List_d_Color32_p_ = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)));
					r_SetColors_List_d_Color32_p_.SetBelong(this.instance);
				}
				return r_SetColors_List_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32], Int32, Int32)
		/// </summary>
		protected RMethod r_SetColors_List_d_Color32_p__Int32_Int32;
		public virtual RMethod RSetColors_List_d_Color32_p__Int32_Int32
		{
			get
			{
				if(r_SetColors_List_d_Color32_p__Int32_Int32 == null)
				{
					r_SetColors_List_d_Color32_p__Int32_Int32 = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)), typeof(System.Int32), typeof(System.Int32));
					r_SetColors_List_d_Color32_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetColors_List_d_Color32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_SetColors_Color32Array;
		public virtual RMethod RSetColors_Color32Array
		{
			get
			{
				if(r_SetColors_Color32Array == null)
				{
					r_SetColors_Color32Array = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType());
					r_SetColors_Color32Array.SetBelong(this.instance);
				}
				return r_SetColors_Color32Array;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetColors_Color32Array_Int32_Int32;
		public virtual RMethod RSetColors_Color32Array_Int32_Int32
		{
			get
			{
				if(r_SetColors_Color32Array_Int32_Int32 == null)
				{
					r_SetColors_Color32Array_Int32_Int32 = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetColors_Color32Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetColors_Color32Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetColors_Color32Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetColors_Color32Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetColors_Color32Array_Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetColors_Color32Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetColors_Color32Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_SetColors_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetColors_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_SetColors_GT_NativeArray_d_T_p_ == null)
				{
					r_SetColors_GT_NativeArray_d_T_p_ = new(this, "SetColors", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetColors_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_SetColors_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_SetColors_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetColors_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_SetColors_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_SetColors_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetColors", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_SetColors_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetColors_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUvsImpl[T](Int32, Int32, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUvsImpl", 1, typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector2_p_;
		public virtual RMethod RSetUVs_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector2_p_ == null)
				{
					r_SetUVs_Int32_List_d_Vector2_p_ = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_SetUVs_Int32_List_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector3_p_;
		public virtual RMethod RSetUVs_Int32_List_d_Vector3_p_
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector3_p_ == null)
				{
					r_SetUVs_Int32_List_d_Vector3_p_ = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_SetUVs_Int32_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector4_p_;
		public virtual RMethod RSetUVs_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector4_p_ == null)
				{
					r_SetUVs_Int32_List_d_Vector4_p_ = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_SetUVs_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32;
		public virtual RMethod RSetUVs_Int32_List_d_Vector2_p__Int32_Int32
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32 == null)
				{
					r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RSetUVs_Int32_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32;
		public virtual RMethod RSetUVs_Int32_List_d_Vector4_p__Int32_Int32
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32 == null)
				{
					r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUvsImpl(Int32, Int32, System.Array, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUvsImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[])
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector2Array;
		public virtual RMethod RSetUVs_Int32_Vector2Array
		{
			get
			{
				if(r_SetUVs_Int32_Vector2Array == null)
				{
					r_SetUVs_Int32_Vector2Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType());
					r_SetUVs_Int32_Vector2Array.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector2Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector3Array;
		public virtual RMethod RSetUVs_Int32_Vector3Array
		{
			get
			{
				if(r_SetUVs_Int32_Vector3Array == null)
				{
					r_SetUVs_Int32_Vector3Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType());
					r_SetUVs_Int32_Vector3Array.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector4Array;
		public virtual RMethod RSetUVs_Int32_Vector4Array
		{
			get
			{
				if(r_SetUVs_Int32_Vector4Array == null)
				{
					r_SetUVs_Int32_Vector4Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_SetUVs_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector2Array_Int32_Int32;
		public virtual RMethod RSetUVs_Int32_Vector2Array_Int32_Int32
		{
			get
			{
				if(r_SetUVs_Int32_Vector2Array_Int32_Int32 == null)
				{
					r_SetUVs_Int32_Vector2Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_Int32_Vector2Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector2Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector3Array_Int32_Int32;
		public virtual RMethod RSetUVs_Int32_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_SetUVs_Int32_Vector3Array_Int32_Int32 == null)
				{
					r_SetUVs_Int32_Vector3Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_Int32_Vector3Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector4Array_Int32_Int32;
		public virtual RMethod RSetUVs_Int32_Vector4Array_Int32_Int32
		{
			get
			{
				if(r_SetUVs_Int32_Vector4Array_Int32_Int32 == null)
				{
					r_SetUVs_Int32_Vector4Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_Int32_Vector4Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector4Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_SetUVs_GT_Int32_NativeArray_d_T_p_;
		public virtual RMethod RSetUVs_GT_Int32_NativeArray_d_T_p_
		{
			get
			{
				if(r_SetUVs_GT_Int32_NativeArray_d_T_p_ == null)
				{
					r_SetUVs_GT_Int32_NativeArray_d_T_p_ = new(this, "SetUVs", 1, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_SetUVs_GT_Int32_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_SetUVs_GT_Int32_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32 = new(this, "SetUVs", 1, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 1, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetUVsImpl[T](Int32, System.Collections.Generic.List`1[T], Int32)
		/// </summary>
		protected RMethod r_GetUVsImpl_GT_Int32_List_d_T_p__Int32;
		public virtual RMethod RGetUVsImpl_GT_Int32_List_d_T_p__Int32
		{
			get
			{
				if(r_GetUVsImpl_GT_Int32_List_d_T_p__Int32 == null)
				{
					r_GetUVsImpl_GT_Int32_List_d_T_p__Int32 = new(this, "GetUVsImpl", 1, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32));
					r_GetUVsImpl_GT_Int32_List_d_T_p__Int32.SetBelong(this.instance);
				}
				return r_GetUVsImpl_GT_Int32_List_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_GetUVs_Int32_List_d_Vector2_p_;
		public virtual RMethod RGetUVs_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_GetUVs_Int32_List_d_Vector2_p_ == null)
				{
					r_GetUVs_Int32_List_d_Vector2_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_GetUVs_Int32_List_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_GetUVs_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_GetUVs_Int32_List_d_Vector3_p_;
		public virtual RMethod RGetUVs_Int32_List_d_Vector3_p_
		{
			get
			{
				if(r_GetUVs_Int32_List_d_Vector3_p_ == null)
				{
					r_GetUVs_Int32_List_d_Vector3_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_GetUVs_Int32_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_GetUVs_Int32_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_GetUVs_Int32_List_d_Vector4_p_;
		public virtual RMethod RGetUVs_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_GetUVs_Int32_List_d_Vector4_p_ == null)
				{
					r_GetUVs_Int32_List_d_Vector4_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_GetUVs_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_GetUVs_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes()
		/// </summary>
		protected RMethod r_GetVertexAttributes;
		public virtual RMethod RGetVertexAttributes
		{
			get
			{
				if(r_GetVertexAttributes == null)
				{
					r_GetVertexAttributes = new(this, "GetVertexAttributes", 0);
					r_GetVertexAttributes.SetBelong(this.instance);
				}
				return r_GetVertexAttributes;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_GetVertexAttributes_VertexAttributeDescriptorArray;
		public virtual RMethod RGetVertexAttributes_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_GetVertexAttributes_VertexAttributeDescriptorArray == null)
				{
					r_GetVertexAttributes_VertexAttributeDescriptorArray = new(this, "GetVertexAttributes", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_GetVertexAttributes_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_GetVertexAttributes_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributes(System.Collections.Generic.List`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_GetVertexAttributes_List_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_GetVertexAttributes_List_d_VertexAttributeDescriptor_p_ == null)
				{
					r_GetVertexAttributes_List_d_VertexAttributeDescriptor_p_ = new(this, "GetVertexAttributes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
					r_GetVertexAttributes_List_d_VertexAttributeDescriptor_p_.SetBelong(this.instance);
				}
				return r_GetVertexAttributes_List_d_VertexAttributeDescriptor_p_;
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
		/// Void SetVertexBufferData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](T[], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh)
		/// </summary>
		protected static RMethod r_AcquireReadOnlyMeshData_Mesh;
		public static RMethod RAcquireReadOnlyMeshData_Mesh
		{
			get
			{
				if(r_AcquireReadOnlyMeshData_Mesh == null)
				{
					r_AcquireReadOnlyMeshData_Mesh = new(typeof(UnityEngine.Mesh), "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh));
					r_AcquireReadOnlyMeshData_Mesh.SetBelong(null);
				}
				return r_AcquireReadOnlyMeshData_Mesh;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[])
		/// </summary>
		protected static RMethod r_AcquireReadOnlyMeshData_MeshArray;
		public static RMethod RAcquireReadOnlyMeshData_MeshArray
		{
			get
			{
				if(r_AcquireReadOnlyMeshData_MeshArray == null)
				{
					r_AcquireReadOnlyMeshData_MeshArray = new(typeof(UnityEngine.Mesh), "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh).MakeArrayType());
					r_AcquireReadOnlyMeshData_MeshArray.SetBelong(null);
				}
				return r_AcquireReadOnlyMeshData_MeshArray;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List`1[UnityEngine.Mesh])
		/// </summary>
		protected static RMethod r_AcquireReadOnlyMeshData_List_d_Mesh_p_;
		public static RMethod RAcquireReadOnlyMeshData_List_d_Mesh_p_
		{
			get
			{
				if(r_AcquireReadOnlyMeshData_List_d_Mesh_p_ == null)
				{
					r_AcquireReadOnlyMeshData_List_d_Mesh_p_ = new(typeof(UnityEngine.Mesh), "AcquireReadOnlyMeshData", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Mesh)));
					r_AcquireReadOnlyMeshData_List_d_Mesh_p_.SetBelong(null);
				}
				return r_AcquireReadOnlyMeshData_List_d_Mesh_p_;
			}
		}

		/// <summary>
		/// MeshDataArray AllocateWritableMeshData(Int32)
		/// </summary>
		protected static RMethod r_AllocateWritableMeshData_Int32;
		public static RMethod RAllocateWritableMeshData_Int32
		{
			get
			{
				if(r_AllocateWritableMeshData_Int32 == null)
				{
					r_AllocateWritableMeshData_Int32 = new(typeof(UnityEngine.Mesh), "AllocateWritableMeshData", 0, typeof(System.Int32));
					r_AllocateWritableMeshData_Int32.SetBelong(null);
				}
				return r_AllocateWritableMeshData_Int32;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, UnityEngine.Mesh, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_ApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags;
		public static RMethod RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags
		{
			get
			{
				if(r_ApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags == null)
				{
					r_ApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags = new(typeof(UnityEngine.Mesh), "ApplyAndDisposeWritableMeshData", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(UnityEngine.Mesh), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_ApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags.SetBelong(null);
				}
				return r_ApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, UnityEngine.Mesh[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_ApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags;
		public static RMethod RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags
		{
			get
			{
				if(r_ApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags == null)
				{
					r_ApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags = new(typeof(UnityEngine.Mesh), "ApplyAndDisposeWritableMeshData", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(UnityEngine.Mesh).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_ApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags.SetBelong(null);
				}
				return r_ApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, System.Collections.Generic.List`1[UnityEngine.Mesh], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_ApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags;
		public static RMethod RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags
		{
			get
			{
				if(r_ApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags == null)
				{
					r_ApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags = new(typeof(UnityEngine.Mesh), "ApplyAndDisposeWritableMeshData", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Mesh)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_ApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags.SetBelong(null);
				}
				return r_ApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetVertexBuffer(Int32)
		/// </summary>
		protected RMethod r_GetVertexBuffer_Int32;
		public virtual RMethod RGetVertexBuffer_Int32
		{
			get
			{
				if(r_GetVertexBuffer_Int32 == null)
				{
					r_GetVertexBuffer_Int32 = new(this, "GetVertexBuffer", 0, typeof(System.Int32));
					r_GetVertexBuffer_Int32.SetBelong(this.instance);
				}
				return r_GetVertexBuffer_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetIndexBuffer()
		/// </summary>
		protected RMethod r_GetIndexBuffer;
		public virtual RMethod RGetIndexBuffer
		{
			get
			{
				if(r_GetIndexBuffer == null)
				{
					r_GetIndexBuffer = new(this, "GetIndexBuffer", 0);
					r_GetIndexBuffer.SetBelong(this.instance);
				}
				return r_GetIndexBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights)
		/// </summary>
		protected RMethod r_GetBoneWeightBuffer_SkinWeights;
		public virtual RMethod RGetBoneWeightBuffer_SkinWeights
		{
			get
			{
				if(r_GetBoneWeightBuffer_SkinWeights == null)
				{
					r_GetBoneWeightBuffer_SkinWeights = new(this, "GetBoneWeightBuffer", 0, typeof(UnityEngine.SkinWeights));
					r_GetBoneWeightBuffer_SkinWeights.SetBelong(this.instance);
				}
				return r_GetBoneWeightBuffer_SkinWeights;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout)
		/// </summary>
		protected RMethod r_GetBlendShapeBuffer_BlendShapeBufferLayout;
		public virtual RMethod RGetBlendShapeBuffer_BlendShapeBufferLayout
		{
			get
			{
				if(r_GetBlendShapeBuffer_BlendShapeBufferLayout == null)
				{
					r_GetBlendShapeBuffer_BlendShapeBufferLayout = new(this, "GetBlendShapeBuffer", 0, typeof(UnityEngine.Rendering.BlendShapeBufferLayout));
					r_GetBlendShapeBuffer_BlendShapeBufferLayout.SetBelong(this.instance);
				}
				return r_GetBlendShapeBuffer_BlendShapeBufferLayout;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBuffer()
		/// </summary>
		protected RMethod r_GetBlendShapeBuffer;
		public virtual RMethod RGetBlendShapeBuffer
		{
			get
			{
				if(r_GetBlendShapeBuffer == null)
				{
					r_GetBlendShapeBuffer = new(this, "GetBlendShapeBuffer", 0);
					r_GetBlendShapeBuffer.SetBelong(this.instance);
				}
				return r_GetBlendShapeBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(Int32)
		/// </summary>
		protected RMethod r_GetBlendShapeBufferRange_Int32;
		public virtual RMethod RGetBlendShapeBufferRange_Int32
		{
			get
			{
				if(r_GetBlendShapeBufferRange_Int32 == null)
				{
					r_GetBlendShapeBufferRange_Int32 = new(this, "GetBlendShapeBufferRange", 0, typeof(System.Int32));
					r_GetBlendShapeBufferRange_Int32.SetBelong(this.instance);
				}
				return r_GetBlendShapeBufferRange_Int32;
			}
		}

		/// <summary>
		/// Void PrintErrorCantAccessIndices()
		/// </summary>
		protected RMethod r_PrintErrorCantAccessIndices;
		public virtual RMethod RPrintErrorCantAccessIndices
		{
			get
			{
				if(r_PrintErrorCantAccessIndices == null)
				{
					r_PrintErrorCantAccessIndices = new(this, "PrintErrorCantAccessIndices", 0);
					r_PrintErrorCantAccessIndices.SetBelong(this.instance);
				}
				return r_PrintErrorCantAccessIndices;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmesh(Int32, Boolean)
		/// </summary>
		protected RMethod r_CheckCanAccessSubmesh_Int32_Boolean;
		public virtual RMethod RCheckCanAccessSubmesh_Int32_Boolean
		{
			get
			{
				if(r_CheckCanAccessSubmesh_Int32_Boolean == null)
				{
					r_CheckCanAccessSubmesh_Int32_Boolean = new(this, "CheckCanAccessSubmesh", 0, typeof(System.Int32), typeof(System.Boolean));
					r_CheckCanAccessSubmesh_Int32_Boolean.SetBelong(this.instance);
				}
				return r_CheckCanAccessSubmesh_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmeshTriangles(Int32)
		/// </summary>
		protected RMethod r_CheckCanAccessSubmeshTriangles_Int32;
		public virtual RMethod RCheckCanAccessSubmeshTriangles_Int32
		{
			get
			{
				if(r_CheckCanAccessSubmeshTriangles_Int32 == null)
				{
					r_CheckCanAccessSubmeshTriangles_Int32 = new(this, "CheckCanAccessSubmeshTriangles", 0, typeof(System.Int32));
					r_CheckCanAccessSubmeshTriangles_Int32.SetBelong(this.instance);
				}
				return r_CheckCanAccessSubmeshTriangles_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmeshIndices(Int32)
		/// </summary>
		protected RMethod r_CheckCanAccessSubmeshIndices_Int32;
		public virtual RMethod RCheckCanAccessSubmeshIndices_Int32
		{
			get
			{
				if(r_CheckCanAccessSubmeshIndices_Int32 == null)
				{
					r_CheckCanAccessSubmeshIndices_Int32 = new(this, "CheckCanAccessSubmeshIndices", 0, typeof(System.Int32));
					r_CheckCanAccessSubmeshIndices_Int32.SetBelong(this.instance);
				}
				return r_CheckCanAccessSubmeshIndices_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTriangles(Int32)
		/// </summary>
		protected RMethod r_GetTriangles_Int32;
		public virtual RMethod RGetTriangles_Int32
		{
			get
			{
				if(r_GetTriangles_Int32 == null)
				{
					r_GetTriangles_Int32 = new(this, "GetTriangles", 0, typeof(System.Int32));
					r_GetTriangles_Int32.SetBelong(this.instance);
				}
				return r_GetTriangles_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTriangles(Int32, Boolean)
		/// </summary>
		protected RMethod r_GetTriangles_Int32_Boolean;
		public virtual RMethod RGetTriangles_Int32_Boolean
		{
			get
			{
				if(r_GetTriangles_Int32_Boolean == null)
				{
					r_GetTriangles_Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Int32), typeof(System.Boolean));
					r_GetTriangles_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetTriangles_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_GetTriangles_List_d_Int32_p__Int32;
		public virtual RMethod RGetTriangles_List_d_Int32_p__Int32
		{
			get
			{
				if(r_GetTriangles_List_d_Int32_p__Int32 == null)
				{
					r_GetTriangles_List_d_Int32_p__Int32 = new(this, "GetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_GetTriangles_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_GetTriangles_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetTriangles_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RGetTriangles_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_GetTriangles_List_d_Int32_p__Int32_Boolean == null)
				{
					r_GetTriangles_List_d_Int32_p__Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_GetTriangles_List_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetTriangles_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetTriangles_List_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RGetTriangles_List_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_GetTriangles_List_d_UInt16_p__Int32_Boolean == null)
				{
					r_GetTriangles_List_d_UInt16_p__Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
					r_GetTriangles_List_d_UInt16_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetTriangles_List_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32[] GetIndices(Int32)
		/// </summary>
		protected RMethod r_GetIndices_Int32;
		public virtual RMethod RGetIndices_Int32
		{
			get
			{
				if(r_GetIndices_Int32 == null)
				{
					r_GetIndices_Int32 = new(this, "GetIndices", 0, typeof(System.Int32));
					r_GetIndices_Int32.SetBelong(this.instance);
				}
				return r_GetIndices_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetIndices(Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndices_Int32_Boolean;
		public virtual RMethod RGetIndices_Int32_Boolean
		{
			get
			{
				if(r_GetIndices_Int32_Boolean == null)
				{
					r_GetIndices_Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Int32), typeof(System.Boolean));
					r_GetIndices_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndices_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_GetIndices_List_d_Int32_p__Int32;
		public virtual RMethod RGetIndices_List_d_Int32_p__Int32
		{
			get
			{
				if(r_GetIndices_List_d_Int32_p__Int32 == null)
				{
					r_GetIndices_List_d_Int32_p__Int32 = new(this, "GetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_GetIndices_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_GetIndices_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndices_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RGetIndices_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_GetIndices_List_d_Int32_p__Int32_Boolean == null)
				{
					r_GetIndices_List_d_Int32_p__Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_GetIndices_List_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndices_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_GetIndices_List_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RGetIndices_List_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_GetIndices_List_d_UInt16_p__Int32_Boolean == null)
				{
					r_GetIndices_List_d_UInt16_p__Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
					r_GetIndices_List_d_UInt16_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetIndices_List_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](T[], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UInt32 GetIndexStart(Int32)
		/// </summary>
		protected RMethod r_GetIndexStart_Int32;
		public virtual RMethod RGetIndexStart_Int32
		{
			get
			{
				if(r_GetIndexStart_Int32 == null)
				{
					r_GetIndexStart_Int32 = new(this, "GetIndexStart", 0, typeof(System.Int32));
					r_GetIndexStart_Int32.SetBelong(this.instance);
				}
				return r_GetIndexStart_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexCount(Int32)
		/// </summary>
		protected RMethod r_GetIndexCount_Int32;
		public virtual RMethod RGetIndexCount_Int32
		{
			get
			{
				if(r_GetIndexCount_Int32 == null)
				{
					r_GetIndexCount_Int32 = new(this, "GetIndexCount", 0, typeof(System.Int32));
					r_GetIndexCount_Int32.SetBelong(this.instance);
				}
				return r_GetIndexCount_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetBaseVertex(Int32)
		/// </summary>
		protected RMethod r_GetBaseVertex_Int32;
		public virtual RMethod RGetBaseVertex_Int32
		{
			get
			{
				if(r_GetBaseVertex_Int32 == null)
				{
					r_GetBaseVertex_Int32 = new(this, "GetBaseVertex", 0, typeof(System.Int32));
					r_GetBaseVertex_Int32.SetBelong(this.instance);
				}
				return r_GetBaseVertex_Int32;
			}
		}

		/// <summary>
		/// Void CheckIndicesArrayRange(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_CheckIndicesArrayRange_Int32_Int32_Int32;
		public virtual RMethod RCheckIndicesArrayRange_Int32_Int32_Int32
		{
			get
			{
				if(r_CheckIndicesArrayRange_Int32_Int32_Int32 == null)
				{
					r_CheckIndicesArrayRange_Int32_Int32_Int32 = new(this, "CheckIndicesArrayRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_CheckIndicesArrayRange_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_CheckIndicesArrayRange_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTrianglesImpl(Int32, UnityEngine.Rendering.IndexFormat, System.Array, Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTrianglesImpl", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32)
		/// </summary>
		protected RMethod r_SetTriangles_Int32Array_Int32;
		public virtual RMethod RSetTriangles_Int32Array_Int32
		{
			get
			{
				if(r_SetTriangles_Int32Array_Int32 == null)
				{
					r_SetTriangles_Int32Array_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32));
					r_SetTriangles_Int32Array_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_Int32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_SetTriangles_Int32Array_Int32_Boolean;
		public virtual RMethod RSetTriangles_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_SetTriangles_Int32Array_Int32_Boolean == null)
				{
					r_SetTriangles_Int32Array_Int32_Boolean = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_SetTriangles_Int32Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_SetTriangles_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_Int32Array_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_Int32Array_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_Int32Array_Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_Int32Array_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_Int32Array_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_Int32Array_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(UInt16[], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_UInt16Array_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_UInt16Array_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_UInt16Array_Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_UInt16Array_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_UInt16Array_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_UInt16Array_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(UInt16[], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_SetTriangles_List_d_Int32_p__Int32;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32
		{
			get
			{
				if(r_SetTriangles_List_d_Int32_p__Int32 == null)
				{
					r_SetTriangles_List_d_Int32_p__Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_SetTriangles_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_SetTriangles_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_SetTriangles_List_d_Int32_p__Int32_Boolean == null)
				{
					r_SetTriangles_List_d_Int32_p__Int32_Boolean = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_SetTriangles_List_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_SetTriangles_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_List_d_Int32_p__Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_List_d_Int32_p__Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_List_d_Int32_p__Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_List_d_Int32_p__Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_List_d_Int32_p__Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_List_d_UInt16_p__Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_List_d_UInt16_p__Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_List_d_UInt16_p__Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_List_d_UInt16_p__Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_List_d_UInt16_p__Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_SetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_SetIndices_Int32Array_MeshTopology_Int32;
		public virtual RMethod RSetIndices_Int32Array_MeshTopology_Int32
		{
			get
			{
				if(r_SetIndices_Int32Array_MeshTopology_Int32 == null)
				{
					r_SetIndices_Int32Array_MeshTopology_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
					r_SetIndices_Int32Array_MeshTopology_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_Int32Array_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32, Boolean)
		/// </summary>
		protected RMethod r_SetIndices_Int32Array_MeshTopology_Int32_Boolean;
		public virtual RMethod RSetIndices_Int32Array_MeshTopology_Int32_Boolean
		{
			get
			{
				if(r_SetIndices_Int32Array_MeshTopology_Int32_Boolean == null)
				{
					r_SetIndices_Int32Array_MeshTopology_Int32_Boolean = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean));
					r_SetIndices_Int32Array_MeshTopology_Int32_Boolean.SetBelong(this.instance);
				}
				return r_SetIndices_Int32Array_MeshTopology_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(UInt16[], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.UInt16).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(UInt16[], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices[T](Unity.Collections.NativeArray`1[T], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.Int32], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.Int32], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.UInt16], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.UInt16], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_SetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_SetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_SetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_SetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_SetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags == null)
				{
					r_SetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(System.Collections.Generic.List`1[UnityEngine.Rendering.SubMeshDescriptor], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SubMeshDescriptor)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(System.Collections.Generic.List`1[UnityEngine.Rendering.SubMeshDescriptor], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags == null)
				{
					r_SetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SubMeshDescriptor)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_SetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes[T](Unity.Collections.NativeArray`1[T], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags == null)
				{
					r_SetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags = new(this, "SetSubMeshes", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetBindposes(System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_GetBindposes_List_d_Matrix4x4_p_;
		public virtual RMethod RGetBindposes_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_GetBindposes_List_d_Matrix4x4_p_ == null)
				{
					r_GetBindposes_List_d_Matrix4x4_p_ = new(this, "GetBindposes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_GetBindposes_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_GetBindposes_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetBoneWeights(System.Collections.Generic.List`1[UnityEngine.BoneWeight])
		/// </summary>
		protected RMethod r_GetBoneWeights_List_d_BoneWeight_p_;
		public virtual RMethod RGetBoneWeights_List_d_BoneWeight_p_
		{
			get
			{
				if(r_GetBoneWeights_List_d_BoneWeight_p_ == null)
				{
					r_GetBoneWeights_List_d_BoneWeight_p_ = new(this, "GetBoneWeights", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.BoneWeight)));
					r_GetBoneWeights_List_d_BoneWeight_p_.SetBelong(this.instance);
				}
				return r_GetBoneWeights_List_d_BoneWeight_p_;
			}
		}

		/// <summary>
		/// Void Clear(Boolean)
		/// </summary>
		protected RMethod r_Clear_Boolean;
		public virtual RMethod RClear_Boolean
		{
			get
			{
				if(r_Clear_Boolean == null)
				{
					r_Clear_Boolean = new(this, "Clear", 0, typeof(System.Boolean));
					r_Clear_Boolean.SetBelong(this.instance);
				}
				return r_Clear_Boolean;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void RecalculateBounds()
		/// </summary>
		protected RMethod r_RecalculateBounds;
		public virtual RMethod RRecalculateBounds
		{
			get
			{
				if(r_RecalculateBounds == null)
				{
					r_RecalculateBounds = new(this, "RecalculateBounds", 0);
					r_RecalculateBounds.SetBelong(this.instance);
				}
				return r_RecalculateBounds;
			}
		}

		/// <summary>
		/// Void RecalculateNormals()
		/// </summary>
		protected RMethod r_RecalculateNormals;
		public virtual RMethod RRecalculateNormals
		{
			get
			{
				if(r_RecalculateNormals == null)
				{
					r_RecalculateNormals = new(this, "RecalculateNormals", 0);
					r_RecalculateNormals.SetBelong(this.instance);
				}
				return r_RecalculateNormals;
			}
		}

		/// <summary>
		/// Void RecalculateTangents()
		/// </summary>
		protected RMethod r_RecalculateTangents;
		public virtual RMethod RRecalculateTangents
		{
			get
			{
				if(r_RecalculateTangents == null)
				{
					r_RecalculateTangents = new(this, "RecalculateTangents", 0);
					r_RecalculateTangents.SetBelong(this.instance);
				}
				return r_RecalculateTangents;
			}
		}

		/// <summary>
		/// Void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RecalculateBounds_MeshUpdateFlags;
		public virtual RMethod RRecalculateBounds_MeshUpdateFlags
		{
			get
			{
				if(r_RecalculateBounds_MeshUpdateFlags == null)
				{
					r_RecalculateBounds_MeshUpdateFlags = new(this, "RecalculateBounds", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RecalculateBounds_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RecalculateBounds_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RecalculateNormals_MeshUpdateFlags;
		public virtual RMethod RRecalculateNormals_MeshUpdateFlags
		{
			get
			{
				if(r_RecalculateNormals_MeshUpdateFlags == null)
				{
					r_RecalculateNormals_MeshUpdateFlags = new(this, "RecalculateNormals", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RecalculateNormals_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RecalculateNormals_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RecalculateTangents_MeshUpdateFlags;
		public virtual RMethod RRecalculateTangents_MeshUpdateFlags
		{
			get
			{
				if(r_RecalculateTangents_MeshUpdateFlags == null)
				{
					r_RecalculateTangents_MeshUpdateFlags = new(this, "RecalculateTangents", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RecalculateTangents_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RecalculateTangents_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetric(Int32, Single)
		/// </summary>
		protected RMethod r_RecalculateUVDistributionMetric_Int32_Single;
		public virtual RMethod RRecalculateUVDistributionMetric_Int32_Single
		{
			get
			{
				if(r_RecalculateUVDistributionMetric_Int32_Single == null)
				{
					r_RecalculateUVDistributionMetric_Int32_Single = new(this, "RecalculateUVDistributionMetric", 0, typeof(System.Int32), typeof(System.Single));
					r_RecalculateUVDistributionMetric_Int32_Single.SetBelong(this.instance);
				}
				return r_RecalculateUVDistributionMetric_Int32_Single;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetrics(Single)
		/// </summary>
		protected RMethod r_RecalculateUVDistributionMetrics_Single;
		public virtual RMethod RRecalculateUVDistributionMetrics_Single
		{
			get
			{
				if(r_RecalculateUVDistributionMetrics_Single == null)
				{
					r_RecalculateUVDistributionMetrics_Single = new(this, "RecalculateUVDistributionMetrics", 0, typeof(System.Single));
					r_RecalculateUVDistributionMetrics_Single.SetBelong(this.instance);
				}
				return r_RecalculateUVDistributionMetrics_Single;
			}
		}

		/// <summary>
		/// Void MarkDynamic()
		/// </summary>
		protected RMethod r_MarkDynamic;
		public virtual RMethod RMarkDynamic
		{
			get
			{
				if(r_MarkDynamic == null)
				{
					r_MarkDynamic = new(this, "MarkDynamic", 0);
					r_MarkDynamic.SetBelong(this.instance);
				}
				return r_MarkDynamic;
			}
		}

		/// <summary>
		/// Void UploadMeshData(Boolean)
		/// </summary>
		protected RMethod r_UploadMeshData_Boolean;
		public virtual RMethod RUploadMeshData_Boolean
		{
			get
			{
				if(r_UploadMeshData_Boolean == null)
				{
					r_UploadMeshData_Boolean = new(this, "UploadMeshData", 0, typeof(System.Boolean));
					r_UploadMeshData_Boolean.SetBelong(this.instance);
				}
				return r_UploadMeshData_Boolean;
			}
		}

		/// <summary>
		/// Void Optimize()
		/// </summary>
		protected RMethod r_Optimize;
		public virtual RMethod ROptimize
		{
			get
			{
				if(r_Optimize == null)
				{
					r_Optimize = new(this, "Optimize", 0);
					r_Optimize.SetBelong(this.instance);
				}
				return r_Optimize;
			}
		}

		/// <summary>
		/// Void OptimizeIndexBuffers()
		/// </summary>
		protected RMethod r_OptimizeIndexBuffers;
		public virtual RMethod ROptimizeIndexBuffers
		{
			get
			{
				if(r_OptimizeIndexBuffers == null)
				{
					r_OptimizeIndexBuffers = new(this, "OptimizeIndexBuffers", 0);
					r_OptimizeIndexBuffers.SetBelong(this.instance);
				}
				return r_OptimizeIndexBuffers;
			}
		}

		/// <summary>
		/// Void OptimizeReorderVertexBuffer()
		/// </summary>
		protected RMethod r_OptimizeReorderVertexBuffer;
		public virtual RMethod ROptimizeReorderVertexBuffer
		{
			get
			{
				if(r_OptimizeReorderVertexBuffer == null)
				{
					r_OptimizeReorderVertexBuffer = new(this, "OptimizeReorderVertexBuffer", 0);
					r_OptimizeReorderVertexBuffer.SetBelong(this.instance);
				}
				return r_OptimizeReorderVertexBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology GetTopology(Int32)
		/// </summary>
		protected RMethod r_GetTopology_Int32;
		public virtual RMethod RGetTopology_Int32
		{
			get
			{
				if(r_GetTopology_Int32 == null)
				{
					r_GetTopology_Int32 = new(this, "GetTopology", 0, typeof(System.Int32));
					r_GetTopology_Int32.SetBelong(this.instance);
				}
				return r_GetTopology_Int32;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_CombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean;
		public virtual RMethod RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_CombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean == null)
				{
					r_CombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_CombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_CombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean, Boolean)
		/// </summary>
		protected RMethod r_CombineMeshes_CombineInstanceArray_Boolean_Boolean;
		public virtual RMethod RCombineMeshes_CombineInstanceArray_Boolean_Boolean
		{
			get
			{
				if(r_CombineMeshes_CombineInstanceArray_Boolean_Boolean == null)
				{
					r_CombineMeshes_CombineInstanceArray_Boolean_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean));
					r_CombineMeshes_CombineInstanceArray_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_CombineMeshes_CombineInstanceArray_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean)
		/// </summary>
		protected RMethod r_CombineMeshes_CombineInstanceArray_Boolean;
		public virtual RMethod RCombineMeshes_CombineInstanceArray_Boolean
		{
			get
			{
				if(r_CombineMeshes_CombineInstanceArray_Boolean == null)
				{
					r_CombineMeshes_CombineInstanceArray_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean));
					r_CombineMeshes_CombineInstanceArray_Boolean.SetBelong(this.instance);
				}
				return r_CombineMeshes_CombineInstanceArray_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[])
		/// </summary>
		protected RMethod r_CombineMeshes_CombineInstanceArray;
		public virtual RMethod RCombineMeshes_CombineInstanceArray
		{
			get
			{
				if(r_CombineMeshes_CombineInstanceArray == null)
				{
					r_CombineMeshes_CombineInstanceArray = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType());
					r_CombineMeshes_CombineInstanceArray.SetBelong(this.instance);
				}
				return r_CombineMeshes_CombineInstanceArray;
			}
		}

		/// <summary>
		/// Void GetVertexAttribute_Injected(Int32, UnityEngine.Rendering.VertexAttributeDescriptor ByRef)
		/// </summary>
		protected RMethod r_GetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor;
		public virtual RMethod RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor
		{
			get
			{
				if(r_GetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor == null)
				{
					r_GetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor = new(this, "GetVertexAttribute_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeByRefType());
					r_GetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor.SetBelong(this.instance);
				}
				return r_GetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Void GetBlendShapeOffsetInternal_Injected(Int32, UnityEngine.BlendShape ByRef)
		/// </summary>
		protected RMethod r_GetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape;
		public virtual RMethod RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape
		{
			get
			{
				if(r_GetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape == null)
				{
					r_GetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape = new(this, "GetBlendShapeOffsetInternal_Injected", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.BlendShape").MakeByRefType());
					r_GetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape.SetBelong(this.instance);
				}
				return r_GetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape;
			}
		}

		/// <summary>
		/// Void GetReadOnlySafetyHandle_Injected(SafetyHandleIndex, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_GetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle;
		public virtual RMethod RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_GetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle == null)
				{
					r_GetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle = new(this, "GetReadOnlySafetyHandle_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+SafetyHandleIndex"), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_GetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle.SetBelong(this.instance);
				}
				return r_GetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetSubMesh_Injected(Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_SetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
		public virtual RMethod RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_SetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_SetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags = new(this, "SetSubMesh_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_SetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_SetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetSubMesh_Injected(Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef)
		/// </summary>
		protected RMethod r_GetSubMesh_Injected_Int32_Out_SubMeshDescriptor;
		public virtual RMethod RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor
		{
			get
			{
				if(r_GetSubMesh_Injected_Int32_Out_SubMeshDescriptor == null)
				{
					r_GetSubMesh_Injected_Int32_Out_SubMeshDescriptor = new(this, "GetSubMesh_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType());
					r_GetSubMesh_Injected_Int32_Out_SubMeshDescriptor.SetBelong(this.instance);
				}
				return r_GetSubMesh_Injected_Int32_Out_SubMeshDescriptor;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_get_bounds_Injected_Out_Bounds;
		public virtual RMethod Rget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_get_bounds_Injected_Out_Bounds == null)
				{
					r_get_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_get_bounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_get_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_set_bounds_Injected_Ref_Bounds;
		public virtual RMethod Rset_bounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_set_bounds_Injected_Ref_Bounds == null)
				{
					r_set_bounds_Injected_Ref_Bounds = new(this, "set_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_set_bounds_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_set_bounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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


        public RMesh() : base("UnityEngine.Mesh")
        {
        }

        public RMesh(System.Object instance) : base("UnityEngine.Mesh")
		{
            SetInstance(instance);
		}

        public RMesh(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMesh(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_Create(UnityEngine.Mesh  @mono)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono};
            var ___result = RInternal_Create_Mesh.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Mesh FromInstanceID(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RFromInstanceID_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Mesh)___result;
        }


        public virtual System.UInt32 GetTotalIndexCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTotalIndexCount.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void SetIndexBufferParams(System.Int32  @indexCount, UnityEngine.Rendering.IndexFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexCount, @format};
            var ___result = RSetIndexBufferParams_Int32_IndexFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetIndexBufferData(System.IntPtr  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, System.Int32  @elemSize, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetIndexBufferDataFromArray(System.Array  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, System.Int32  @elemSize, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferParamsFromPtr(System.Int32  @vertexCount, System.IntPtr  @attributesPtr, System.Int32  @attributesCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributesPtr, @attributesCount};
            var ___result = RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferParamsFromArray(System.Int32  @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributes};
            var ___result = RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetVertexBufferData(System.Int32  @stream, System.IntPtr  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, System.Int32  @elemSize, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetVertexBufferDataFromArray(System.Int32  @stream, System.Array  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, System.Int32  @elemSize, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Array GetVertexAttributesAlloc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVertexAttributesAlloc.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Int32 GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RGetVertexAttributesArray_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVertexAttributesList(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor>  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVertexAttributeCountImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVertexAttributeCountImpl.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetVertexAttribute_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.VertexAttributeDescriptor)___result;
        }


        public virtual System.UInt32 GetIndexStartImpl(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetIndexStartImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt32 GetIndexCountImpl(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetIndexCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt32 GetTrianglesCountImpl(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetTrianglesCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt32 GetBaseVertexImpl(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetBaseVertexImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int32[] GetTrianglesImpl(System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RGetTrianglesImpl_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetIndicesImpl(System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RGetIndicesImpl_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void SetIndicesImpl(System.Int32  @submesh, UnityEngine.MeshTopology  @topology, UnityEngine.Rendering.IndexFormat  @indicesFormat, System.Array  @indices, System.Int32  @arrayStart, System.Int32  @arraySize, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @topology, @indicesFormat, @indices, @arrayStart, @arraySize, @calculateBounds, @baseVertex};
            var ___result = RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndicesNativeArrayImpl(System.Int32  @submesh, UnityEngine.MeshTopology  @topology, UnityEngine.Rendering.IndexFormat  @indicesFormat, System.IntPtr  @indices, System.Int32  @arrayStart, System.Int32  @arraySize, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @topology, @indicesFormat, @indices, @arrayStart, @arraySize, @calculateBounds, @baseVertex};
            var ___result = RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTrianglesNonAllocImpl(System.Int32[]  @values, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTrianglesNonAllocImpl16(System.UInt16[]  @values, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndicesNonAllocImpl(System.Int32[]  @values, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndicesNonAllocImpl16(System.UInt16[]  @values, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RPrintErrorCantAccessChannel_VertexAttribute.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.Array  @values, System.Int32  @arraySize, System.Int32  @valuesStart, System.Int32  @valuesCount, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @arraySize, @valuesStart, @valuesCount, @flags};
            var ___result = RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.IntPtr  @values, System.Int32  @arraySize, System.Int32  @valuesStart, System.Int32  @valuesCount, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @arraySize, @valuesStart, @valuesCount, @flags};
            var ___result = RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim};
            var ___result = RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.Array  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values};
            var ___result = RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetVertexBufferStride(System.Int32  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RGetVertexBufferStride_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IntPtr GetNativeVertexBufferPtr(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetNativeVertexBufferPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr GetNativeIndexBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeIndexBufferPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetVertexBufferImpl(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetVertexBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetIndexBufferImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIndexBufferImpl.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(System.Int32  @bonesPerVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bonesPerVertex};
            var ___result = RGetBoneWeightBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(System.Int32  @layout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layout};
            var ___result = RGetBlendShapeBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual void ClearBlendShapes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearBlendShapes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetBlendShapeName(System.Int32  @shapeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex};
            var ___result = RGetBlendShapeName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetBlendShapeIndex(System.String  @blendShapeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@blendShapeName};
            var ___result = RGetBlendShapeIndex_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBlendShapeFrameCount(System.Int32  @shapeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex};
            var ___result = RGetBlendShapeFrameCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single GetBlendShapeFrameWeight(System.Int32  @shapeIndex, System.Int32  @frameIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex, @frameIndex};
            var ___result = RGetBlendShapeFrameWeight_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void GetBlendShapeFrameVertices(System.Int32  @shapeIndex, System.Int32  @frameIndex, UnityEngine.Vector3[]  @deltaVertices, UnityEngine.Vector3[]  @deltaNormals, UnityEngine.Vector3[]  @deltaTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex, @frameIndex, @deltaVertices, @deltaNormals, @deltaTangents};
            var ___result = RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBlendShapeFrame(System.String  @shapeName, System.Single  @frameWeight, UnityEngine.Vector3[]  @deltaVertices, UnityEngine.Vector3[]  @deltaNormals, UnityEngine.Vector3[]  @deltaTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeName, @frameWeight, @deltaVertices, @deltaNormals, @deltaTangents};
            var ___result = RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetBlendShapeOffsetInternal(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetBlendShapeOffsetInternal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean HasBoneWeights()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasBoneWeights.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.BoneWeight[] GetBoneWeightsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBoneWeightsImpl.Invoke(___genericsType, ___parameters);

            return (UnityEngine.BoneWeight[])___result;
        }


        public virtual void SetBoneWeightsImpl(UnityEngine.BoneWeight[]  @weights)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@weights};
            var ___result = RSetBoneWeightsImpl_BoneWeightArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void InternalSetBoneWeights(System.IntPtr  @bonesPerVertex, System.Int32  @bonesPerVertexSize, System.IntPtr  @weights, System.Int32  @weightsSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bonesPerVertex, @bonesPerVertexSize, @weights, @weightsSize};
            var ___result = RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetAllBoneWeights()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllBoneWeights.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetBonesPerVertex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBonesPerVertex.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetAllBoneWeightsArraySize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllBoneWeightsArraySize.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBoneWeightBufferLayoutInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBoneWeightBufferLayoutInternal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IntPtr GetAllBoneWeightsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllBoneWeightsArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr GetBonesPerVertexArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBonesPerVertexArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Object GetBindposes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBindposes.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.IntPtr GetBindposesArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBindposesArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RGetBoneWeightsNonAllocImpl_BoneWeightArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RGetBindposesNonAllocImpl_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetSubMesh(System.Int32  @index, UnityEngine.Rendering.SubMeshDescriptor  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @desc, @flags};
            var ___result = RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetSubMesh_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.SubMeshDescriptor)___result;
        }


        public virtual void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[]  @desc, System.Int32  @start, System.Int32  @count, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllSubMeshesAtOnceFromNativeArray(System.IntPtr  @desc, System.Int32  @start, System.Int32  @count, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearImpl(System.Boolean  @keepVertexLayout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepVertexLayout};
            var ___result = RClearImpl_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RRecalculateBoundsImpl_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RRecalculateNormalsImpl_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RRecalculateTangentsImpl_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDynamicImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDynamicImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkModified()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkModified.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UploadMeshDataImpl(System.Boolean  @markNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markNoLongerReadable};
            var ___result = RUploadMeshDataImpl_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.MeshTopology GetTopologyImpl(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetTopologyImpl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.MeshTopology)___result;
        }


        public virtual void RecalculateUVDistributionMetricImpl(System.Int32  @uvSetIndex, System.Single  @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvSetIndex, @uvAreaThreshold};
            var ___result = RRecalculateUVDistributionMetricImpl_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateUVDistributionMetricsImpl(System.Single  @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvAreaThreshold};
            var ___result = RRecalculateUVDistributionMetricsImpl_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetUVDistributionMetric(System.Int32  @uvSetIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvSetIndex};
            var ___result = RGetUVDistributionMetric_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void CombineMeshesImpl(UnityEngine.CombineInstance[]  @combine, System.Boolean  @mergeSubMeshes, System.Boolean  @useMatrices, System.Boolean  @hasLightmapData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes, @useMatrices, @hasLightmapData};
            var ___result = RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROptimizeImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeIndexBuffersImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROptimizeIndexBuffersImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeReorderVertexBufferImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROptimizeReorderVertexBufferImpl.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rendering.VertexAttribute GetUVChannel(System.Int32  @uvIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvIndex};
            var ___result = RGetUVChannel_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.VertexAttribute)___result;
        }


        public static System.Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute  @channel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel};
            var ___result = RDefaultDimensionForChannel_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @format, @dim};
            var ___result = RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute  @channel)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel};
            var ___result = RGetAllocArrayFromChannel_GT_VertexAttribute.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.Array  @values, System.Int32  @valuesArrayLength, System.Int32  @valuesStart, System.Int32  @valuesCount, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @valuesArrayLength, @valuesStart, @valuesCount, @flags};
            var ___result = RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.IntPtr  @values, System.Int32  @valuesArrayLength, System.Int32  @valuesStart, System.Int32  @valuesCount, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @valuesArrayLength, @valuesStart, @valuesCount, @flags};
            var ___result = RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, T[]  @values, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @flags};
            var ___result = RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute  @channel, T[]  @values, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @values, @flags};
            var ___result = RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute  @channel, UnityEngine.Rendering.VertexAttributeFormat  @format, System.Int32  @dim, System.Collections.Generic.List<T>  @values, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @start, @length, @flags};
            var ___result = RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute  @channel, System.Collections.Generic.List<T>  @values, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @values, @start, @length, @flags};
            var ___result = RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetListForChannel<T>(System.Collections.Generic.List<T>  @buffer, System.Int32  @capacity, UnityEngine.Rendering.VertexAttribute  @channel, System.Int32  @dim)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @capacity, @channel, @dim};
            var ___result = RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetListForChannel<T>(System.Collections.Generic.List<T>  @buffer, System.Int32  @capacity, UnityEngine.Rendering.VertexAttribute  @channel, System.Int32  @dim, UnityEngine.Rendering.VertexAttributeFormat  @channelType)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @capacity, @channel, @dim, @channelType};
            var ___result = RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3>  @vertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices};
            var ___result = RGetVertices_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3>  @inVertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices};
            var ___result = RSetVertices_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3>  @inVertices, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length};
            var ___result = RSetVertices_List_d_Vector3_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3>  @inVertices, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length, @flags};
            var ___result = RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(UnityEngine.Vector3[]  @inVertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices};
            var ___result = RSetVertices_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(UnityEngine.Vector3[]  @inVertices, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length};
            var ___result = RSetVertices_Vector3Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(UnityEngine.Vector3[]  @inVertices, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length, @flags};
            var ___result = RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3>  @normals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normals};
            var ___result = RGetNormals_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3>  @inNormals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals};
            var ___result = RSetNormals_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3>  @inNormals, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length};
            var ___result = RSetNormals_List_d_Vector3_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3>  @inNormals, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length, @flags};
            var ___result = RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(UnityEngine.Vector3[]  @inNormals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals};
            var ___result = RSetNormals_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(UnityEngine.Vector3[]  @inNormals, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length};
            var ___result = RSetNormals_Vector3Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(UnityEngine.Vector3[]  @inNormals, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length, @flags};
            var ___result = RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4>  @tangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tangents};
            var ___result = RGetTangents_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4>  @inTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents};
            var ___result = RSetTangents_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4>  @inTangents, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length};
            var ___result = RSetTangents_List_d_Vector4_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4>  @inTangents, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length, @flags};
            var ___result = RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(UnityEngine.Vector4[]  @inTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents};
            var ___result = RSetTangents_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(UnityEngine.Vector4[]  @inTangents, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length};
            var ___result = RSetTangents_Vector4Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(UnityEngine.Vector4[]  @inTangents, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length, @flags};
            var ___result = RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void GetColors(System.Collections.Generic.List<UnityEngine.Color>  @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RGetColors_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color>  @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RSetColors_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color>  @inColors, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RSetColors_List_d_Color_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color>  @inColors, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color[]  @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RSetColors_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color[]  @inColors, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RSetColors_ColorArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color[]  @inColors, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColors(System.Collections.Generic.List<UnityEngine.Color32>  @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RGetColors_List_d_Color32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color32>  @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RSetColors_List_d_Color32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color32>  @inColors, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RSetColors_List_d_Color32_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color32>  @inColors, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color32[]  @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RSetColors_Color32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color32[]  @inColors, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RSetColors_Color32Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color32[]  @inColors, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void SetUvsImpl<T>(System.Int32  @uvIndex, System.Int32  @dim, System.Collections.Generic.List<T>  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@uvIndex, @dim, @uvs, @start, @length, @flags};
            var ___result = RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector2>  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RSetUVs_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector3>  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RSetUVs_Int32_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector4>  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RSetUVs_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector2>  @uvs, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RSetUVs_Int32_List_d_Vector2_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector2>  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector3>  @uvs, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RSetUVs_Int32_List_d_Vector3_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector3>  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector4>  @uvs, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RSetUVs_Int32_List_d_Vector4_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector4>  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUvsImpl(System.Int32  @uvIndex, System.Int32  @dim, System.Array  @uvs, System.Int32  @arrayStart, System.Int32  @arraySize, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvIndex, @dim, @uvs, @arrayStart, @arraySize, @flags};
            var ___result = RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector2[]  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RSetUVs_Int32_Vector2Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector3[]  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RSetUVs_Int32_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector4[]  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RSetUVs_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector2[]  @uvs, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RSetUVs_Int32_Vector2Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector2[]  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector3[]  @uvs, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RSetUVs_Int32_Vector3Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector3[]  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector4[]  @uvs, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RSetUVs_Int32_Vector4Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32  @channel, UnityEngine.Vector4[]  @uvs, System.Int32  @start, System.Int32  @length, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void GetUVsImpl<T>(System.Int32  @uvIndex, System.Collections.Generic.List<T>  @uvs, System.Int32  @dim)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@uvIndex, @uvs, @dim};
            var ___result = RGetUVsImpl_GT_Int32_List_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector2>  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RGetUVs_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector3>  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RGetUVs_Int32_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32  @channel, System.Collections.Generic.List<UnityEngine.Vector4>  @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RGetUVs_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVertexAttributes.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.VertexAttributeDescriptor[])___result;
        }


        public virtual System.Int32 GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RGetVertexAttributes_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVertexAttributes(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor>  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetVertexBufferParams(System.Int32  @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributes};
            var ___result = RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void SetVertexBufferData<T>(T[]  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, System.Int32  @stream, UnityEngine.Rendering.MeshUpdateFlags  @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @stream, @flags};
            var ___result = RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferData<T>(System.Collections.Generic.List<T>  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, System.Int32  @stream, UnityEngine.Rendering.MeshUpdateFlags  @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @stream, @flags};
            var ___result = RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object AcquireReadOnlyMeshData(UnityEngine.Mesh  @mesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh};
            var ___result = RAcquireReadOnlyMeshData_Mesh.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object AcquireReadOnlyMeshData(UnityEngine.Mesh[]  @meshes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes};
            var ___result = RAcquireReadOnlyMeshData_MeshArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object AcquireReadOnlyMeshData(System.Collections.Generic.List<UnityEngine.Mesh>  @meshes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes};
            var ___result = RAcquireReadOnlyMeshData_List_d_Mesh_p_.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object AllocateWritableMeshData(System.Int32  @meshCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshCount};
            var ___result = RAllocateWritableMeshData_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public virtual UnityEngine.GraphicsBuffer GetVertexBuffer(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetVertexBuffer_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetIndexBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIndexBuffer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights  @layout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layout};
            var ___result = RGetBoneWeightBuffer_SkinWeights.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout  @layout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layout};
            var ___result = RGetBlendShapeBuffer_BlendShapeBufferLayout.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.GraphicsBuffer GetBlendShapeBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBlendShapeBuffer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GraphicsBuffer)___result;
        }


        public virtual UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(System.Int32  @blendShapeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@blendShapeIndex};
            var ___result = RGetBlendShapeBufferRange_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.BlendShapeBufferRange)___result;
        }


        public virtual void PrintErrorCantAccessIndices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrintErrorCantAccessIndices.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckCanAccessSubmesh(System.Int32  @submesh, System.Boolean  @errorAboutTriangles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @errorAboutTriangles};
            var ___result = RCheckCanAccessSubmesh_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckCanAccessSubmeshTriangles(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RCheckCanAccessSubmeshTriangles_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckCanAccessSubmeshIndices(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RCheckCanAccessSubmeshIndices_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32[] GetTriangles(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetTriangles_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetTriangles(System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RGetTriangles_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void GetTriangles(System.Collections.Generic.List<System.Int32>  @triangles, System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh};
            var ___result = RGetTriangles_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTriangles(System.Collections.Generic.List<System.Int32>  @triangles, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @applyBaseVertex};
            var ___result = RGetTriangles_List_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTriangles(System.Collections.Generic.List<System.UInt16>  @triangles, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @applyBaseVertex};
            var ___result = RGetTriangles_List_d_UInt16_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32[] GetIndices(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetIndices_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetIndices(System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RGetIndices_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void GetIndices(System.Collections.Generic.List<System.Int32>  @indices, System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @submesh};
            var ___result = RGetIndices_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndices(System.Collections.Generic.List<System.Int32>  @indices, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @submesh, @applyBaseVertex};
            var ___result = RGetIndices_List_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndices(System.Collections.Generic.List<System.UInt16>  @indices, System.Int32  @submesh, System.Boolean  @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @submesh, @applyBaseVertex};
            var ___result = RGetIndices_List_d_UInt16_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetIndexBufferData<T>(T[]  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, UnityEngine.Rendering.MeshUpdateFlags  @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @flags};
            var ___result = RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndexBufferData<T>(System.Collections.Generic.List<T>  @data, System.Int32  @dataStart, System.Int32  @meshBufferStart, System.Int32  @count, UnityEngine.Rendering.MeshUpdateFlags  @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @flags};
            var ___result = RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt32 GetIndexStart(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetIndexStart_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt32 GetIndexCount(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetIndexCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.UInt32 GetBaseVertex(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetBaseVertex_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void CheckIndicesArrayRange(System.Int32  @valuesLength, System.Int32  @start, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valuesLength, @start, @length};
            var ___result = RCheckIndicesArrayRange_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTrianglesImpl(System.Int32  @submesh, UnityEngine.Rendering.IndexFormat  @indicesFormat, System.Array  @triangles, System.Int32  @trianglesArrayLength, System.Int32  @start, System.Int32  @length, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @indicesFormat, @triangles, @trianglesArrayLength, @start, @length, @calculateBounds, @baseVertex};
            var ___result = RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[]  @triangles, System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh};
            var ___result = RSetTriangles_Int32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[]  @triangles, System.Int32  @submesh, System.Boolean  @calculateBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds};
            var ___result = RSetTriangles_Int32Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[]  @triangles, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_Int32Array_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[]  @triangles, System.Int32  @trianglesStart, System.Int32  @trianglesLength, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.UInt16[]  @triangles, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_UInt16Array_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.UInt16[]  @triangles, System.Int32  @trianglesStart, System.Int32  @trianglesLength, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32>  @triangles, System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh};
            var ___result = RSetTriangles_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32>  @triangles, System.Int32  @submesh, System.Boolean  @calculateBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds};
            var ___result = RSetTriangles_List_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32>  @triangles, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32>  @triangles, System.Int32  @trianglesStart, System.Int32  @trianglesLength, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.UInt16>  @triangles, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.UInt16>  @triangles, System.Int32  @trianglesStart, System.Int32  @trianglesLength, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[]  @indices, UnityEngine.MeshTopology  @topology, System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh};
            var ___result = RSetIndices_Int32Array_MeshTopology_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[]  @indices, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds};
            var ___result = RSetIndices_Int32Array_MeshTopology_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[]  @indices, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[]  @indices, System.Int32  @indicesStart, System.Int32  @indicesLength, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.UInt16[]  @indices, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.UInt16[]  @indices, System.Int32  @indicesStart, System.Int32  @indicesLength, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void SetIndices(System.Collections.Generic.List<System.Int32>  @indices, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.Int32>  @indices, System.Int32  @indicesStart, System.Int32  @indicesLength, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.UInt16>  @indices, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.UInt16>  @indices, System.Int32  @indicesStart, System.Int32  @indicesLength, UnityEngine.MeshTopology  @topology, System.Int32  @submesh, System.Boolean  @calculateBounds, System.Int32  @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[]  @desc, System.Int32  @start, System.Int32  @count, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[]  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @flags};
            var ___result = RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor>  @desc, System.Int32  @start, System.Int32  @count, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor>  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @flags};
            var ___result = RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void GetBindposes(System.Collections.Generic.List<UnityEngine.Matrix4x4>  @bindposes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindposes};
            var ___result = RGetBindposes_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight>  @boneWeights)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@boneWeights};
            var ___result = RGetBoneWeights_List_d_BoneWeight_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Boolean  @keepVertexLayout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepVertexLayout};
            var ___result = RClear_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecalculateBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateNormals()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecalculateNormals.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateTangents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecalculateTangents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RRecalculateBounds_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RRecalculateNormals_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RRecalculateTangents_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateUVDistributionMetric(System.Int32  @uvSetIndex, System.Single  @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvSetIndex, @uvAreaThreshold};
            var ___result = RRecalculateUVDistributionMetric_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateUVDistributionMetrics(System.Single  @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvAreaThreshold};
            var ___result = RRecalculateUVDistributionMetrics_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDynamic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDynamic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UploadMeshData(System.Boolean  @markNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markNoLongerReadable};
            var ___result = RUploadMeshData_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Optimize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROptimize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeIndexBuffers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROptimizeIndexBuffers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeReorderVertexBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROptimizeReorderVertexBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.MeshTopology GetTopology(System.Int32  @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RGetTopology_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.MeshTopology)___result;
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[]  @combine, System.Boolean  @mergeSubMeshes, System.Boolean  @useMatrices, System.Boolean  @hasLightmapData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes, @useMatrices, @hasLightmapData};
            var ___result = RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[]  @combine, System.Boolean  @mergeSubMeshes, System.Boolean  @useMatrices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes, @useMatrices};
            var ___result = RCombineMeshes_CombineInstanceArray_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[]  @combine, System.Boolean  @mergeSubMeshes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes};
            var ___result = RCombineMeshes_CombineInstanceArray_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[]  @combine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine};
            var ___result = RCombineMeshes_CombineInstanceArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVertexAttribute_Injected(System.Int32  @index, out UnityEngine.Rendering.VertexAttributeDescriptor  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret};
            var ___result = RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rendering.VertexAttributeDescriptor)___parameters[1];

            
        }




        public virtual void SetSubMesh_Injected(System.Int32  @index, ref UnityEngine.Rendering.SubMeshDescriptor  @desc, UnityEngine.Rendering.MeshUpdateFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @desc, @flags};
            var ___result = RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);
			desc = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[1];

            
        }


        public virtual void GetSubMesh_Injected(System.Int32  @index, out UnityEngine.Rendering.SubMeshDescriptor  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret};
            var ___result = RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[1];

            
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_bounds_Injected(ref UnityEngine.Bounds  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_bounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
