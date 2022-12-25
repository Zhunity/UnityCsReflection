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
		protected static RMethod r_RInternal_Create_Mesh;
		public static RMethod RInternal_Create_Mesh
		{
			get
			{
				if(r_RInternal_Create_Mesh == null)
				{
					r_RInternal_Create_Mesh = new(typeof(UnityEngine.Mesh), "Internal_Create", 0, typeof(UnityEngine.Mesh));
					r_RInternal_Create_Mesh.SetBelong(null);
				}
				return r_RInternal_Create_Mesh;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh FromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_RFromInstanceID_Int32;
		public static RMethod RFromInstanceID_Int32
		{
			get
			{
				if(r_RFromInstanceID_Int32 == null)
				{
					r_RFromInstanceID_Int32 = new(typeof(UnityEngine.Mesh), "FromInstanceID", 0, typeof(System.Int32));
					r_RFromInstanceID_Int32.SetBelong(null);
				}
				return r_RFromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetTotalIndexCount()
		/// </summary>
		protected RMethod r_RGetTotalIndexCount;
		public virtual RMethod RGetTotalIndexCount
		{
			get
			{
				if(r_RGetTotalIndexCount == null)
				{
					r_RGetTotalIndexCount = new(this, "GetTotalIndexCount", 0);
					r_RGetTotalIndexCount.SetBelong(this.instance);
				}
				return r_RGetTotalIndexCount;
			}
		}

		/// <summary>
		/// Void SetIndexBufferParams(Int32, UnityEngine.Rendering.IndexFormat)
		/// </summary>
		protected RMethod r_RSetIndexBufferParams_Int32_IndexFormat;
		public virtual RMethod RSetIndexBufferParams_Int32_IndexFormat
		{
			get
			{
				if(r_RSetIndexBufferParams_Int32_IndexFormat == null)
				{
					r_RSetIndexBufferParams_Int32_IndexFormat = new(this, "SetIndexBufferParams", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat));
					r_RSetIndexBufferParams_Int32_IndexFormat.SetBelong(this.instance);
				}
				return r_RSetIndexBufferParams_Int32_IndexFormat;
			}
		}

		/// <summary>
		/// Void InternalSetIndexBufferData(IntPtr, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetIndexBufferData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void InternalSetIndexBufferDataFromArray(System.Array, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetIndexBufferDataFromArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromPtr(Int32, IntPtr, Int32)
		/// </summary>
		protected RMethod r_RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32;
		public virtual RMethod RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32 == null)
				{
					r_RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32 = new(this, "SetVertexBufferParamsFromPtr", 0, typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
					r_RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_RSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromArray(Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray;
		public virtual RMethod RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray == null)
				{
					r_RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray = new(this, "SetVertexBufferParamsFromArray", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_RSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void InternalSetVertexBufferData(Int32, IntPtr, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetVertexBufferData", 0, typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void InternalSetVertexBufferDataFromArray(Int32, System.Array, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetVertexBufferDataFromArray", 0, typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// System.Array GetVertexAttributesAlloc()
		/// </summary>
		protected RMethod r_RGetVertexAttributesAlloc;
		public virtual RMethod RGetVertexAttributesAlloc
		{
			get
			{
				if(r_RGetVertexAttributesAlloc == null)
				{
					r_RGetVertexAttributesAlloc = new(this, "GetVertexAttributesAlloc", 0);
					r_RGetVertexAttributesAlloc.SetBelong(this.instance);
				}
				return r_RGetVertexAttributesAlloc;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_RGetVertexAttributesArray_VertexAttributeDescriptorArray;
		public virtual RMethod RGetVertexAttributesArray_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_RGetVertexAttributesArray_VertexAttributeDescriptorArray == null)
				{
					r_RGetVertexAttributesArray_VertexAttributeDescriptorArray = new(this, "GetVertexAttributesArray", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_RGetVertexAttributesArray_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_RGetVertexAttributesArray_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributesList(System.Collections.Generic.List`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_ == null)
				{
					r_RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_ = new(this, "GetVertexAttributesList", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
					r_RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_.SetBelong(this.instance);
				}
				return r_RGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeCountImpl()
		/// </summary>
		protected RMethod r_RGetVertexAttributeCountImpl;
		public virtual RMethod RGetVertexAttributeCountImpl
		{
			get
			{
				if(r_RGetVertexAttributeCountImpl == null)
				{
					r_RGetVertexAttributeCountImpl = new(this, "GetVertexAttributeCountImpl", 0);
					r_RGetVertexAttributeCountImpl.SetBelong(this.instance);
				}
				return r_RGetVertexAttributeCountImpl;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(Int32)
		/// </summary>
		protected RMethod r_RGetVertexAttribute_Int32;
		public virtual RMethod RGetVertexAttribute_Int32
		{
			get
			{
				if(r_RGetVertexAttribute_Int32 == null)
				{
					r_RGetVertexAttribute_Int32 = new(this, "GetVertexAttribute", 0, typeof(System.Int32));
					r_RGetVertexAttribute_Int32.SetBelong(this.instance);
				}
				return r_RGetVertexAttribute_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexStartImpl(Int32)
		/// </summary>
		protected RMethod r_RGetIndexStartImpl_Int32;
		public virtual RMethod RGetIndexStartImpl_Int32
		{
			get
			{
				if(r_RGetIndexStartImpl_Int32 == null)
				{
					r_RGetIndexStartImpl_Int32 = new(this, "GetIndexStartImpl", 0, typeof(System.Int32));
					r_RGetIndexStartImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetIndexStartImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexCountImpl(Int32)
		/// </summary>
		protected RMethod r_RGetIndexCountImpl_Int32;
		public virtual RMethod RGetIndexCountImpl_Int32
		{
			get
			{
				if(r_RGetIndexCountImpl_Int32 == null)
				{
					r_RGetIndexCountImpl_Int32 = new(this, "GetIndexCountImpl", 0, typeof(System.Int32));
					r_RGetIndexCountImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetIndexCountImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetTrianglesCountImpl(Int32)
		/// </summary>
		protected RMethod r_RGetTrianglesCountImpl_Int32;
		public virtual RMethod RGetTrianglesCountImpl_Int32
		{
			get
			{
				if(r_RGetTrianglesCountImpl_Int32 == null)
				{
					r_RGetTrianglesCountImpl_Int32 = new(this, "GetTrianglesCountImpl", 0, typeof(System.Int32));
					r_RGetTrianglesCountImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetTrianglesCountImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetBaseVertexImpl(Int32)
		/// </summary>
		protected RMethod r_RGetBaseVertexImpl_Int32;
		public virtual RMethod RGetBaseVertexImpl_Int32
		{
			get
			{
				if(r_RGetBaseVertexImpl_Int32 == null)
				{
					r_RGetBaseVertexImpl_Int32 = new(this, "GetBaseVertexImpl", 0, typeof(System.Int32));
					r_RGetBaseVertexImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetBaseVertexImpl_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTrianglesImpl(Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTrianglesImpl_Int32_Boolean;
		public virtual RMethod RGetTrianglesImpl_Int32_Boolean
		{
			get
			{
				if(r_RGetTrianglesImpl_Int32_Boolean == null)
				{
					r_RGetTrianglesImpl_Int32_Boolean = new(this, "GetTrianglesImpl", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RGetTrianglesImpl_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTrianglesImpl_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32[] GetIndicesImpl(Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetIndicesImpl_Int32_Boolean;
		public virtual RMethod RGetIndicesImpl_Int32_Boolean
		{
			get
			{
				if(r_RGetIndicesImpl_Int32_Boolean == null)
				{
					r_RGetIndicesImpl_Int32_Boolean = new(this, "GetIndicesImpl", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RGetIndicesImpl_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetIndicesImpl_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndicesImpl(Int32, UnityEngine.MeshTopology, UnityEngine.Rendering.IndexFormat, System.Array, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32 = new(this, "SetIndicesImpl", 0, typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndicesNativeArrayImpl(Int32, UnityEngine.MeshTopology, UnityEngine.Rendering.IndexFormat, IntPtr, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32 = new(this, "SetIndicesNativeArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void GetTrianglesNonAllocImpl(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean;
		public virtual RMethod RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean == null)
				{
					r_RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean = new(this, "GetTrianglesNonAllocImpl", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTrianglesNonAllocImpl16(UInt16[], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean;
		public virtual RMethod RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean
		{
			get
			{
				if(r_RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean == null)
				{
					r_RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean = new(this, "GetTrianglesNonAllocImpl16", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndicesNonAllocImpl(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean;
		public virtual RMethod RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean == null)
				{
					r_RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean = new(this, "GetIndicesNonAllocImpl", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetIndicesNonAllocImpl_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndicesNonAllocImpl16(UInt16[], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean;
		public virtual RMethod RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean
		{
			get
			{
				if(r_RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean == null)
				{
					r_RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean = new(this, "GetIndicesNonAllocImpl16", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RPrintErrorCantAccessChannel_VertexAttribute;
		public virtual RMethod RPrintErrorCantAccessChannel_VertexAttribute
		{
			get
			{
				if(r_RPrintErrorCantAccessChannel_VertexAttribute == null)
				{
					r_RPrintErrorCantAccessChannel_VertexAttribute = new(this, "PrintErrorCantAccessChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RPrintErrorCantAccessChannel_VertexAttribute.SetBelong(this.instance);
				}
				return r_RPrintErrorCantAccessChannel_VertexAttribute;
			}
		}

		/// <summary>
		/// Boolean HasVertexAttribute(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RHasVertexAttribute_VertexAttribute;
		public virtual RMethod RHasVertexAttribute_VertexAttribute
		{
			get
			{
				if(r_RHasVertexAttribute_VertexAttribute == null)
				{
					r_RHasVertexAttribute_VertexAttribute = new(this, "HasVertexAttribute", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RHasVertexAttribute_VertexAttribute.SetBelong(this.instance);
				}
				return r_RHasVertexAttribute_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RGetVertexAttributeDimension_VertexAttribute;
		public virtual RMethod RGetVertexAttributeDimension_VertexAttribute
		{
			get
			{
				if(r_RGetVertexAttributeDimension_VertexAttribute == null)
				{
					r_RGetVertexAttributeDimension_VertexAttribute = new(this, "GetVertexAttributeDimension", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RGetVertexAttributeDimension_VertexAttribute.SetBelong(this.instance);
				}
				return r_RGetVertexAttributeDimension_VertexAttribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RGetVertexAttributeFormat_VertexAttribute;
		public virtual RMethod RGetVertexAttributeFormat_VertexAttribute
		{
			get
			{
				if(r_RGetVertexAttributeFormat_VertexAttribute == null)
				{
					r_RGetVertexAttributeFormat_VertexAttribute = new(this, "GetVertexAttributeFormat", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RGetVertexAttributeFormat_VertexAttribute.SetBelong(this.instance);
				}
				return r_RGetVertexAttributeFormat_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RGetVertexAttributeStream_VertexAttribute;
		public virtual RMethod RGetVertexAttributeStream_VertexAttribute
		{
			get
			{
				if(r_RGetVertexAttributeStream_VertexAttribute == null)
				{
					r_RGetVertexAttributeStream_VertexAttribute = new(this, "GetVertexAttributeStream", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RGetVertexAttributeStream_VertexAttribute.SetBelong(this.instance);
				}
				return r_RGetVertexAttributeStream_VertexAttribute;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RGetVertexAttributeOffset_VertexAttribute;
		public virtual RMethod RGetVertexAttributeOffset_VertexAttribute
		{
			get
			{
				if(r_RGetVertexAttributeOffset_VertexAttribute == null)
				{
					r_RGetVertexAttributeOffset_VertexAttribute = new(this, "GetVertexAttributeOffset", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RGetVertexAttributeOffset_VertexAttribute.SetBelong(this.instance);
				}
				return r_RGetVertexAttributeOffset_VertexAttribute;
			}
		}

		/// <summary>
		/// Void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetArrayForChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetNativeArrayForChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32 = new(this, "GetAllocArrayFromChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
					r_RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32.SetBelong(this.instance);
				}
				return r_RGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array)
		/// </summary>
		protected RMethod r_RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array;
		public virtual RMethod RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array
		{
			get
			{
				if(r_RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array == null)
				{
					r_RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array = new(this, "GetArrayFromChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array));
					r_RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array.SetBelong(this.instance);
				}
				return r_RGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array;
			}
		}

		/// <summary>
		/// Int32 GetVertexBufferStride(Int32)
		/// </summary>
		protected RMethod r_RGetVertexBufferStride_Int32;
		public virtual RMethod RGetVertexBufferStride_Int32
		{
			get
			{
				if(r_RGetVertexBufferStride_Int32 == null)
				{
					r_RGetVertexBufferStride_Int32 = new(this, "GetVertexBufferStride", 0, typeof(System.Int32));
					r_RGetVertexBufferStride_Int32.SetBelong(this.instance);
				}
				return r_RGetVertexBufferStride_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetNativeVertexBufferPtr(Int32)
		/// </summary>
		protected RMethod r_RGetNativeVertexBufferPtr_Int32;
		public virtual RMethod RGetNativeVertexBufferPtr_Int32
		{
			get
			{
				if(r_RGetNativeVertexBufferPtr_Int32 == null)
				{
					r_RGetNativeVertexBufferPtr_Int32 = new(this, "GetNativeVertexBufferPtr", 0, typeof(System.Int32));
					r_RGetNativeVertexBufferPtr_Int32.SetBelong(this.instance);
				}
				return r_RGetNativeVertexBufferPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetNativeIndexBufferPtr()
		/// </summary>
		protected RMethod r_RGetNativeIndexBufferPtr;
		public virtual RMethod RGetNativeIndexBufferPtr
		{
			get
			{
				if(r_RGetNativeIndexBufferPtr == null)
				{
					r_RGetNativeIndexBufferPtr = new(this, "GetNativeIndexBufferPtr", 0);
					r_RGetNativeIndexBufferPtr.SetBelong(this.instance);
				}
				return r_RGetNativeIndexBufferPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetVertexBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RGetVertexBufferImpl_Int32;
		public virtual RMethod RGetVertexBufferImpl_Int32
		{
			get
			{
				if(r_RGetVertexBufferImpl_Int32 == null)
				{
					r_RGetVertexBufferImpl_Int32 = new(this, "GetVertexBufferImpl", 0, typeof(System.Int32));
					r_RGetVertexBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetVertexBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetIndexBufferImpl()
		/// </summary>
		protected RMethod r_RGetIndexBufferImpl;
		public virtual RMethod RGetIndexBufferImpl
		{
			get
			{
				if(r_RGetIndexBufferImpl == null)
				{
					r_RGetIndexBufferImpl = new(this, "GetIndexBufferImpl", 0);
					r_RGetIndexBufferImpl.SetBelong(this.instance);
				}
				return r_RGetIndexBufferImpl;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RGetBoneWeightBufferImpl_Int32;
		public virtual RMethod RGetBoneWeightBufferImpl_Int32
		{
			get
			{
				if(r_RGetBoneWeightBufferImpl_Int32 == null)
				{
					r_RGetBoneWeightBufferImpl_Int32 = new(this, "GetBoneWeightBufferImpl", 0, typeof(System.Int32));
					r_RGetBoneWeightBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetBoneWeightBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(Int32)
		/// </summary>
		protected RMethod r_RGetBlendShapeBufferImpl_Int32;
		public virtual RMethod RGetBlendShapeBufferImpl_Int32
		{
			get
			{
				if(r_RGetBlendShapeBufferImpl_Int32 == null)
				{
					r_RGetBlendShapeBufferImpl_Int32 = new(this, "GetBlendShapeBufferImpl", 0, typeof(System.Int32));
					r_RGetBlendShapeBufferImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetBlendShapeBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Void ClearBlendShapes()
		/// </summary>
		protected RMethod r_RClearBlendShapes;
		public virtual RMethod RClearBlendShapes
		{
			get
			{
				if(r_RClearBlendShapes == null)
				{
					r_RClearBlendShapes = new(this, "ClearBlendShapes", 0);
					r_RClearBlendShapes.SetBelong(this.instance);
				}
				return r_RClearBlendShapes;
			}
		}

		/// <summary>
		/// System.String GetBlendShapeName(Int32)
		/// </summary>
		protected RMethod r_RGetBlendShapeName_Int32;
		public virtual RMethod RGetBlendShapeName_Int32
		{
			get
			{
				if(r_RGetBlendShapeName_Int32 == null)
				{
					r_RGetBlendShapeName_Int32 = new(this, "GetBlendShapeName", 0, typeof(System.Int32));
					r_RGetBlendShapeName_Int32.SetBelong(this.instance);
				}
				return r_RGetBlendShapeName_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBlendShapeIndex(System.String)
		/// </summary>
		protected RMethod r_RGetBlendShapeIndex_String;
		public virtual RMethod RGetBlendShapeIndex_String
		{
			get
			{
				if(r_RGetBlendShapeIndex_String == null)
				{
					r_RGetBlendShapeIndex_String = new(this, "GetBlendShapeIndex", 0, typeof(System.String));
					r_RGetBlendShapeIndex_String.SetBelong(this.instance);
				}
				return r_RGetBlendShapeIndex_String;
			}
		}

		/// <summary>
		/// Int32 GetBlendShapeFrameCount(Int32)
		/// </summary>
		protected RMethod r_RGetBlendShapeFrameCount_Int32;
		public virtual RMethod RGetBlendShapeFrameCount_Int32
		{
			get
			{
				if(r_RGetBlendShapeFrameCount_Int32 == null)
				{
					r_RGetBlendShapeFrameCount_Int32 = new(this, "GetBlendShapeFrameCount", 0, typeof(System.Int32));
					r_RGetBlendShapeFrameCount_Int32.SetBelong(this.instance);
				}
				return r_RGetBlendShapeFrameCount_Int32;
			}
		}

		/// <summary>
		/// Single GetBlendShapeFrameWeight(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetBlendShapeFrameWeight_Int32_Int32;
		public virtual RMethod RGetBlendShapeFrameWeight_Int32_Int32
		{
			get
			{
				if(r_RGetBlendShapeFrameWeight_Int32_Int32 == null)
				{
					r_RGetBlendShapeFrameWeight_Int32_Int32 = new(this, "GetBlendShapeFrameWeight", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetBlendShapeFrameWeight_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetBlendShapeFrameWeight_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetBlendShapeFrameVertices(Int32, Int32, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array;
		public virtual RMethod RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array
		{
			get
			{
				if(r_RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array == null)
				{
					r_RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array = new(this, "GetBlendShapeFrameVertices", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType());
					r_RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array.SetBelong(this.instance);
				}
				return r_RGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array;
			}
		}

		/// <summary>
		/// Void AddBlendShapeFrame(System.String, Single, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array;
		public virtual RMethod RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array
		{
			get
			{
				if(r_RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array == null)
				{
					r_RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array = new(this, "AddBlendShapeFrame", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType());
					r_RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array.SetBelong(this.instance);
				}
				return r_RAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array;
			}
		}

		/// <summary>
		/// UnityEngine.BlendShape GetBlendShapeOffsetInternal(Int32)
		/// </summary>
		protected RMethod r_RGetBlendShapeOffsetInternal_Int32;
		public virtual RMethod RGetBlendShapeOffsetInternal_Int32
		{
			get
			{
				if(r_RGetBlendShapeOffsetInternal_Int32 == null)
				{
					r_RGetBlendShapeOffsetInternal_Int32 = new(this, "GetBlendShapeOffsetInternal", 0, typeof(System.Int32));
					r_RGetBlendShapeOffsetInternal_Int32.SetBelong(this.instance);
				}
				return r_RGetBlendShapeOffsetInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBoneWeights()
		/// </summary>
		protected RMethod r_RHasBoneWeights;
		public virtual RMethod RHasBoneWeights
		{
			get
			{
				if(r_RHasBoneWeights == null)
				{
					r_RHasBoneWeights = new(this, "HasBoneWeights", 0);
					r_RHasBoneWeights.SetBelong(this.instance);
				}
				return r_RHasBoneWeights;
			}
		}

		/// <summary>
		/// UnityEngine.BoneWeight[] GetBoneWeightsImpl()
		/// </summary>
		protected RMethod r_RGetBoneWeightsImpl;
		public virtual RMethod RGetBoneWeightsImpl
		{
			get
			{
				if(r_RGetBoneWeightsImpl == null)
				{
					r_RGetBoneWeightsImpl = new(this, "GetBoneWeightsImpl", 0);
					r_RGetBoneWeightsImpl.SetBelong(this.instance);
				}
				return r_RGetBoneWeightsImpl;
			}
		}

		/// <summary>
		/// Void SetBoneWeightsImpl(UnityEngine.BoneWeight[])
		/// </summary>
		protected RMethod r_RSetBoneWeightsImpl_BoneWeightArray;
		public virtual RMethod RSetBoneWeightsImpl_BoneWeightArray
		{
			get
			{
				if(r_RSetBoneWeightsImpl_BoneWeightArray == null)
				{
					r_RSetBoneWeightsImpl_BoneWeightArray = new(this, "SetBoneWeightsImpl", 0, typeof(UnityEngine.BoneWeight).MakeArrayType());
					r_RSetBoneWeightsImpl_BoneWeightArray.SetBelong(this.instance);
				}
				return r_RSetBoneWeightsImpl_BoneWeightArray;
			}
		}

		/// <summary>
		/// Void SetBoneWeights(Unity.Collections.NativeArray`1[System.Byte], Unity.Collections.NativeArray`1[UnityEngine.BoneWeight1])
		/// </summary>
		protected RMethod r_RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_;
		public virtual RMethod RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_
		{
			get
			{
				if(r_RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_ == null)
				{
					r_RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_ = new(this, "SetBoneWeights", 0, typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(System.Byte)), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.BoneWeight1)));
					r_RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_.SetBelong(this.instance);
				}
				return r_RSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_;
			}
		}

		/// <summary>
		/// Void InternalSetBoneWeights(IntPtr, Int32, IntPtr, Int32)
		/// </summary>
		protected RMethod r_RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32;
		public virtual RMethod RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32 == null)
				{
					r_RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32 = new(this, "InternalSetBoneWeights", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
					r_RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_RInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.BoneWeight1] GetAllBoneWeights()
		/// </summary>
		protected RMethod r_RGetAllBoneWeights;
		public virtual RMethod RGetAllBoneWeights
		{
			get
			{
				if(r_RGetAllBoneWeights == null)
				{
					r_RGetAllBoneWeights = new(this, "GetAllBoneWeights", 0);
					r_RGetAllBoneWeights.SetBelong(this.instance);
				}
				return r_RGetAllBoneWeights;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[System.Byte] GetBonesPerVertex()
		/// </summary>
		protected RMethod r_RGetBonesPerVertex;
		public virtual RMethod RGetBonesPerVertex
		{
			get
			{
				if(r_RGetBonesPerVertex == null)
				{
					r_RGetBonesPerVertex = new(this, "GetBonesPerVertex", 0);
					r_RGetBonesPerVertex.SetBelong(this.instance);
				}
				return r_RGetBonesPerVertex;
			}
		}

		/// <summary>
		/// Int32 GetAllBoneWeightsArraySize()
		/// </summary>
		protected RMethod r_RGetAllBoneWeightsArraySize;
		public virtual RMethod RGetAllBoneWeightsArraySize
		{
			get
			{
				if(r_RGetAllBoneWeightsArraySize == null)
				{
					r_RGetAllBoneWeightsArraySize = new(this, "GetAllBoneWeightsArraySize", 0);
					r_RGetAllBoneWeightsArraySize.SetBelong(this.instance);
				}
				return r_RGetAllBoneWeightsArraySize;
			}
		}

		/// <summary>
		/// Int32 GetBoneWeightBufferLayoutInternal()
		/// </summary>
		protected RMethod r_RGetBoneWeightBufferLayoutInternal;
		public virtual RMethod RGetBoneWeightBufferLayoutInternal
		{
			get
			{
				if(r_RGetBoneWeightBufferLayoutInternal == null)
				{
					r_RGetBoneWeightBufferLayoutInternal = new(this, "GetBoneWeightBufferLayoutInternal", 0);
					r_RGetBoneWeightBufferLayoutInternal.SetBelong(this.instance);
				}
				return r_RGetBoneWeightBufferLayoutInternal;
			}
		}

		/// <summary>
		/// IntPtr GetAllBoneWeightsArray()
		/// </summary>
		protected RMethod r_RGetAllBoneWeightsArray;
		public virtual RMethod RGetAllBoneWeightsArray
		{
			get
			{
				if(r_RGetAllBoneWeightsArray == null)
				{
					r_RGetAllBoneWeightsArray = new(this, "GetAllBoneWeightsArray", 0);
					r_RGetAllBoneWeightsArray.SetBelong(this.instance);
				}
				return r_RGetAllBoneWeightsArray;
			}
		}

		/// <summary>
		/// IntPtr GetBonesPerVertexArray()
		/// </summary>
		protected RMethod r_RGetBonesPerVertexArray;
		public virtual RMethod RGetBonesPerVertexArray
		{
			get
			{
				if(r_RGetBonesPerVertexArray == null)
				{
					r_RGetBonesPerVertexArray = new(this, "GetBonesPerVertexArray", 0);
					r_RGetBonesPerVertexArray.SetBelong(this.instance);
				}
				return r_RGetBonesPerVertexArray;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.Matrix4x4] GetBindposes()
		/// </summary>
		protected RMethod r_RGetBindposes;
		public virtual RMethod RGetBindposes
		{
			get
			{
				if(r_RGetBindposes == null)
				{
					r_RGetBindposes = new(this, "GetBindposes", 0);
					r_RGetBindposes.SetBelong(this.instance);
				}
				return r_RGetBindposes;
			}
		}

		/// <summary>
		/// IntPtr GetBindposesArray()
		/// </summary>
		protected RMethod r_RGetBindposesArray;
		public virtual RMethod RGetBindposesArray
		{
			get
			{
				if(r_RGetBindposesArray == null)
				{
					r_RGetBindposesArray = new(this, "GetBindposesArray", 0);
					r_RGetBindposesArray.SetBelong(this.instance);
				}
				return r_RGetBindposesArray;
			}
		}

		/// <summary>
		/// Void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[])
		/// </summary>
		protected RMethod r_RGetBoneWeightsNonAllocImpl_BoneWeightArray;
		public virtual RMethod RGetBoneWeightsNonAllocImpl_BoneWeightArray
		{
			get
			{
				if(r_RGetBoneWeightsNonAllocImpl_BoneWeightArray == null)
				{
					r_RGetBoneWeightsNonAllocImpl_BoneWeightArray = new(this, "GetBoneWeightsNonAllocImpl", 0, typeof(UnityEngine.BoneWeight).MakeArrayType());
					r_RGetBoneWeightsNonAllocImpl_BoneWeightArray.SetBelong(this.instance);
				}
				return r_RGetBoneWeightsNonAllocImpl_BoneWeightArray;
			}
		}

		/// <summary>
		/// Void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RGetBindposesNonAllocImpl_Matrix4x4Array;
		public virtual RMethod RGetBindposesNonAllocImpl_Matrix4x4Array
		{
			get
			{
				if(r_RGetBindposesNonAllocImpl_Matrix4x4Array == null)
				{
					r_RGetBindposesNonAllocImpl_Matrix4x4Array = new(this, "GetBindposesNonAllocImpl", 0, typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RGetBindposesNonAllocImpl_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RGetBindposesNonAllocImpl_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetReadOnlySafetyHandle(SafetyHandleIndex)
		/// </summary>
		protected RMethod r_RGetReadOnlySafetyHandle_SafetyHandleIndex;
		public virtual RMethod RGetReadOnlySafetyHandle_SafetyHandleIndex
		{
			get
			{
				if(r_RGetReadOnlySafetyHandle_SafetyHandleIndex == null)
				{
					r_RGetReadOnlySafetyHandle_SafetyHandleIndex = new(this, "GetReadOnlySafetyHandle", 0,  ReleactionUtils.GetType("UnityEngine.Mesh+SafetyHandleIndex"));
					r_RGetReadOnlySafetyHandle_SafetyHandleIndex.SetBelong(this.instance);
				}
				return r_RGetReadOnlySafetyHandle_SafetyHandleIndex;
			}
		}

		/// <summary>
		/// Void SetSubMesh(Int32, UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags;
		public virtual RMethod RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags = new(this, "SetSubMesh", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(Int32)
		/// </summary>
		protected RMethod r_RGetSubMesh_Int32;
		public virtual RMethod RGetSubMesh_Int32
		{
			get
			{
				if(r_RGetSubMesh_Int32 == null)
				{
					r_RGetSubMesh_Int32 = new(this, "GetSubMesh", 0, typeof(System.Int32));
					r_RGetSubMesh_Int32.SetBelong(this.instance);
				}
				return r_RGetSubMesh_Int32;
			}
		}

		/// <summary>
		/// Void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetAllSubMeshesAtOnceFromArray", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetAllSubMeshesAtOnceFromNativeArray(IntPtr, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags = new(this, "SetAllSubMeshesAtOnceFromNativeArray", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ClearImpl(Boolean)
		/// </summary>
		protected RMethod r_RClearImpl_Boolean;
		public virtual RMethod RClearImpl_Boolean
		{
			get
			{
				if(r_RClearImpl_Boolean == null)
				{
					r_RClearImpl_Boolean = new(this, "ClearImpl", 0, typeof(System.Boolean));
					r_RClearImpl_Boolean.SetBelong(this.instance);
				}
				return r_RClearImpl_Boolean;
			}
		}

		/// <summary>
		/// Void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RRecalculateBoundsImpl_MeshUpdateFlags;
		public virtual RMethod RRecalculateBoundsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_RRecalculateBoundsImpl_MeshUpdateFlags == null)
				{
					r_RRecalculateBoundsImpl_MeshUpdateFlags = new(this, "RecalculateBoundsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RRecalculateBoundsImpl_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RRecalculateBoundsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RRecalculateNormalsImpl_MeshUpdateFlags;
		public virtual RMethod RRecalculateNormalsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_RRecalculateNormalsImpl_MeshUpdateFlags == null)
				{
					r_RRecalculateNormalsImpl_MeshUpdateFlags = new(this, "RecalculateNormalsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RRecalculateNormalsImpl_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RRecalculateNormalsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RRecalculateTangentsImpl_MeshUpdateFlags;
		public virtual RMethod RRecalculateTangentsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_RRecalculateTangentsImpl_MeshUpdateFlags == null)
				{
					r_RRecalculateTangentsImpl_MeshUpdateFlags = new(this, "RecalculateTangentsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RRecalculateTangentsImpl_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RRecalculateTangentsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void MarkDynamicImpl()
		/// </summary>
		protected RMethod r_RMarkDynamicImpl;
		public virtual RMethod RMarkDynamicImpl
		{
			get
			{
				if(r_RMarkDynamicImpl == null)
				{
					r_RMarkDynamicImpl = new(this, "MarkDynamicImpl", 0);
					r_RMarkDynamicImpl.SetBelong(this.instance);
				}
				return r_RMarkDynamicImpl;
			}
		}

		/// <summary>
		/// Void MarkModified()
		/// </summary>
		protected RMethod r_RMarkModified;
		public virtual RMethod RMarkModified
		{
			get
			{
				if(r_RMarkModified == null)
				{
					r_RMarkModified = new(this, "MarkModified", 0);
					r_RMarkModified.SetBelong(this.instance);
				}
				return r_RMarkModified;
			}
		}

		/// <summary>
		/// Void UploadMeshDataImpl(Boolean)
		/// </summary>
		protected RMethod r_RUploadMeshDataImpl_Boolean;
		public virtual RMethod RUploadMeshDataImpl_Boolean
		{
			get
			{
				if(r_RUploadMeshDataImpl_Boolean == null)
				{
					r_RUploadMeshDataImpl_Boolean = new(this, "UploadMeshDataImpl", 0, typeof(System.Boolean));
					r_RUploadMeshDataImpl_Boolean.SetBelong(this.instance);
				}
				return r_RUploadMeshDataImpl_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology GetTopologyImpl(Int32)
		/// </summary>
		protected RMethod r_RGetTopologyImpl_Int32;
		public virtual RMethod RGetTopologyImpl_Int32
		{
			get
			{
				if(r_RGetTopologyImpl_Int32 == null)
				{
					r_RGetTopologyImpl_Int32 = new(this, "GetTopologyImpl", 0, typeof(System.Int32));
					r_RGetTopologyImpl_Int32.SetBelong(this.instance);
				}
				return r_RGetTopologyImpl_Int32;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetricImpl(Int32, Single)
		/// </summary>
		protected RMethod r_RRecalculateUVDistributionMetricImpl_Int32_Single;
		public virtual RMethod RRecalculateUVDistributionMetricImpl_Int32_Single
		{
			get
			{
				if(r_RRecalculateUVDistributionMetricImpl_Int32_Single == null)
				{
					r_RRecalculateUVDistributionMetricImpl_Int32_Single = new(this, "RecalculateUVDistributionMetricImpl", 0, typeof(System.Int32), typeof(System.Single));
					r_RRecalculateUVDistributionMetricImpl_Int32_Single.SetBelong(this.instance);
				}
				return r_RRecalculateUVDistributionMetricImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetricsImpl(Single)
		/// </summary>
		protected RMethod r_RRecalculateUVDistributionMetricsImpl_Single;
		public virtual RMethod RRecalculateUVDistributionMetricsImpl_Single
		{
			get
			{
				if(r_RRecalculateUVDistributionMetricsImpl_Single == null)
				{
					r_RRecalculateUVDistributionMetricsImpl_Single = new(this, "RecalculateUVDistributionMetricsImpl", 0, typeof(System.Single));
					r_RRecalculateUVDistributionMetricsImpl_Single.SetBelong(this.instance);
				}
				return r_RRecalculateUVDistributionMetricsImpl_Single;
			}
		}

		/// <summary>
		/// Single GetUVDistributionMetric(Int32)
		/// </summary>
		protected RMethod r_RGetUVDistributionMetric_Int32;
		public virtual RMethod RGetUVDistributionMetric_Int32
		{
			get
			{
				if(r_RGetUVDistributionMetric_Int32 == null)
				{
					r_RGetUVDistributionMetric_Int32 = new(this, "GetUVDistributionMetric", 0, typeof(System.Int32));
					r_RGetUVDistributionMetric_Int32.SetBelong(this.instance);
				}
				return r_RGetUVDistributionMetric_Int32;
			}
		}

		/// <summary>
		/// Void CombineMeshesImpl(UnityEngine.CombineInstance[], Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean;
		public virtual RMethod RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean == null)
				{
					r_RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean = new(this, "CombineMeshesImpl", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OptimizeImpl()
		/// </summary>
		protected RMethod r_ROptimizeImpl;
		public virtual RMethod ROptimizeImpl
		{
			get
			{
				if(r_ROptimizeImpl == null)
				{
					r_ROptimizeImpl = new(this, "OptimizeImpl", 0);
					r_ROptimizeImpl.SetBelong(this.instance);
				}
				return r_ROptimizeImpl;
			}
		}

		/// <summary>
		/// Void OptimizeIndexBuffersImpl()
		/// </summary>
		protected RMethod r_ROptimizeIndexBuffersImpl;
		public virtual RMethod ROptimizeIndexBuffersImpl
		{
			get
			{
				if(r_ROptimizeIndexBuffersImpl == null)
				{
					r_ROptimizeIndexBuffersImpl = new(this, "OptimizeIndexBuffersImpl", 0);
					r_ROptimizeIndexBuffersImpl.SetBelong(this.instance);
				}
				return r_ROptimizeIndexBuffersImpl;
			}
		}

		/// <summary>
		/// Void OptimizeReorderVertexBufferImpl()
		/// </summary>
		protected RMethod r_ROptimizeReorderVertexBufferImpl;
		public virtual RMethod ROptimizeReorderVertexBufferImpl
		{
			get
			{
				if(r_ROptimizeReorderVertexBufferImpl == null)
				{
					r_ROptimizeReorderVertexBufferImpl = new(this, "OptimizeReorderVertexBufferImpl", 0);
					r_ROptimizeReorderVertexBufferImpl.SetBelong(this.instance);
				}
				return r_ROptimizeReorderVertexBufferImpl;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute GetUVChannel(Int32)
		/// </summary>
		protected static RMethod r_RGetUVChannel_Int32;
		public static RMethod RGetUVChannel_Int32
		{
			get
			{
				if(r_RGetUVChannel_Int32 == null)
				{
					r_RGetUVChannel_Int32 = new(typeof(UnityEngine.Mesh), "GetUVChannel", 0, typeof(System.Int32));
					r_RGetUVChannel_Int32.SetBelong(null);
				}
				return r_RGetUVChannel_Int32;
			}
		}

		/// <summary>
		/// Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_RDefaultDimensionForChannel_VertexAttribute;
		public static RMethod RDefaultDimensionForChannel_VertexAttribute
		{
			get
			{
				if(r_RDefaultDimensionForChannel_VertexAttribute == null)
				{
					r_RDefaultDimensionForChannel_VertexAttribute = new(typeof(UnityEngine.Mesh), "DefaultDimensionForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RDefaultDimensionForChannel_VertexAttribute.SetBelong(null);
				}
				return r_RDefaultDimensionForChannel_VertexAttribute;
			}
		}

		/// <summary>
		/// T[] GetAllocArrayFromChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32 = new(this, "GetAllocArrayFromChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
					r_RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32.SetBelong(this.instance);
				}
				return r_RGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// T[] GetAllocArrayFromChannel[T](UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_RGetAllocArrayFromChannel_GT_VertexAttribute;
		public virtual RMethod RGetAllocArrayFromChannel_GT_VertexAttribute
		{
			get
			{
				if(r_RGetAllocArrayFromChannel_GT_VertexAttribute == null)
				{
					r_RGetAllocArrayFromChannel_GT_VertexAttribute = new(this, "GetAllocArrayFromChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute));
					r_RGetAllocArrayFromChannel_GT_VertexAttribute.SetBelong(this.instance);
				}
				return r_RGetAllocArrayFromChannel_GT_VertexAttribute;
			}
		}

		/// <summary>
		/// Void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetSizedArrayForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetSizedNativeArrayForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetArrayForChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, T[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags;
		public virtual RMethod RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags
		{
			get
			{
				if(r_RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags == null)
				{
					r_RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags = new(this, "SetArrayForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetArrayForChannel[T](UnityEngine.Rendering.VertexAttribute, T[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags;
		public virtual RMethod RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags
		{
			get
			{
				if(r_RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags == null)
				{
					r_RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags = new(this, "SetArrayForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetListForChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetListForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetListForChannel[T](UnityEngine.Rendering.VertexAttribute, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetListForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetListForChannel[T](System.Collections.Generic.List`1[T], Int32, UnityEngine.Rendering.VertexAttribute, Int32)
		/// </summary>
		protected RMethod r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32;
		public virtual RMethod RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32
		{
			get
			{
				if(r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32 == null)
				{
					r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32 = new(this, "GetListForChannel", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Int32));
					r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32.SetBelong(this.instance);
				}
				return r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32;
			}
		}

		/// <summary>
		/// Void GetListForChannel[T](System.Collections.Generic.List`1[T], Int32, UnityEngine.Rendering.VertexAttribute, Int32, UnityEngine.Rendering.VertexAttributeFormat)
		/// </summary>
		protected RMethod r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat;
		public virtual RMethod RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat
		{
			get
			{
				if(r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat == null)
				{
					r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat = new(this, "GetListForChannel", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeFormat));
					r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat.SetBelong(this.instance);
				}
				return r_RGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat;
			}
		}

		/// <summary>
		/// Void GetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RGetVertices_List_d_Vector3_p_;
		public virtual RMethod RGetVertices_List_d_Vector3_p_
		{
			get
			{
				if(r_RGetVertices_List_d_Vector3_p_ == null)
				{
					r_RGetVertices_List_d_Vector3_p_ = new(this, "GetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_RGetVertices_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_RGetVertices_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RSetVertices_List_d_Vector3_p_;
		public virtual RMethod RSetVertices_List_d_Vector3_p_
		{
			get
			{
				if(r_RSetVertices_List_d_Vector3_p_ == null)
				{
					r_RSetVertices_List_d_Vector3_p_ = new(this, "SetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_RSetVertices_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_RSetVertices_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetVertices_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RSetVertices_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_RSetVertices_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_RSetVertices_List_d_Vector3_p__Int32_Int32 = new(this, "SetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
					r_RSetVertices_List_d_Vector3_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetVertices_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_RSetVertices_Vector3Array;
		public virtual RMethod RSetVertices_Vector3Array
		{
			get
			{
				if(r_RSetVertices_Vector3Array == null)
				{
					r_RSetVertices_Vector3Array = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType());
					r_RSetVertices_Vector3Array.SetBelong(this.instance);
				}
				return r_RSetVertices_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetVertices_Vector3Array_Int32_Int32;
		public virtual RMethod RSetVertices_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_RSetVertices_Vector3Array_Int32_Int32 == null)
				{
					r_RSetVertices_Vector3Array_Int32_Int32 = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetVertices_Vector3Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetVertices_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetVertices_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetVertices_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetVertices_GT_NativeArray_d_T_p_ == null)
				{
					r_RSetVertices_GT_NativeArray_d_T_p_ = new(this, "SetVertices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetVertices_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetVertices_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetVertices_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetVertices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RGetNormals_List_d_Vector3_p_;
		public virtual RMethod RGetNormals_List_d_Vector3_p_
		{
			get
			{
				if(r_RGetNormals_List_d_Vector3_p_ == null)
				{
					r_RGetNormals_List_d_Vector3_p_ = new(this, "GetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_RGetNormals_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_RGetNormals_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RSetNormals_List_d_Vector3_p_;
		public virtual RMethod RSetNormals_List_d_Vector3_p_
		{
			get
			{
				if(r_RSetNormals_List_d_Vector3_p_ == null)
				{
					r_RSetNormals_List_d_Vector3_p_ = new(this, "SetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_RSetNormals_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_RSetNormals_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetNormals_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RSetNormals_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_RSetNormals_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_RSetNormals_List_d_Vector3_p__Int32_Int32 = new(this, "SetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
					r_RSetNormals_List_d_Vector3_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetNormals_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_RSetNormals_Vector3Array;
		public virtual RMethod RSetNormals_Vector3Array
		{
			get
			{
				if(r_RSetNormals_Vector3Array == null)
				{
					r_RSetNormals_Vector3Array = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType());
					r_RSetNormals_Vector3Array.SetBelong(this.instance);
				}
				return r_RSetNormals_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetNormals_Vector3Array_Int32_Int32;
		public virtual RMethod RSetNormals_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_RSetNormals_Vector3Array_Int32_Int32 == null)
				{
					r_RSetNormals_Vector3Array_Int32_Int32 = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetNormals_Vector3Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetNormals_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetNormals_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetNormals_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetNormals_GT_NativeArray_d_T_p_ == null)
				{
					r_RSetNormals_GT_NativeArray_d_T_p_ = new(this, "SetNormals", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetNormals_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetNormals_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetNormals_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetNormals", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RGetTangents_List_d_Vector4_p_;
		public virtual RMethod RGetTangents_List_d_Vector4_p_
		{
			get
			{
				if(r_RGetTangents_List_d_Vector4_p_ == null)
				{
					r_RGetTangents_List_d_Vector4_p_ = new(this, "GetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RGetTangents_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RGetTangents_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RSetTangents_List_d_Vector4_p_;
		public virtual RMethod RSetTangents_List_d_Vector4_p_
		{
			get
			{
				if(r_RSetTangents_List_d_Vector4_p_ == null)
				{
					r_RSetTangents_List_d_Vector4_p_ = new(this, "SetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RSetTangents_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RSetTangents_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetTangents_List_d_Vector4_p__Int32_Int32;
		public virtual RMethod RSetTangents_List_d_Vector4_p__Int32_Int32
		{
			get
			{
				if(r_RSetTangents_List_d_Vector4_p__Int32_Int32 == null)
				{
					r_RSetTangents_List_d_Vector4_p__Int32_Int32 = new(this, "SetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32));
					r_RSetTangents_List_d_Vector4_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetTangents_List_d_Vector4_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetTangents_Vector4Array;
		public virtual RMethod RSetTangents_Vector4Array
		{
			get
			{
				if(r_RSetTangents_Vector4Array == null)
				{
					r_RSetTangents_Vector4Array = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetTangents_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetTangents_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetTangents_Vector4Array_Int32_Int32;
		public virtual RMethod RSetTangents_Vector4Array_Int32_Int32
		{
			get
			{
				if(r_RSetTangents_Vector4Array_Int32_Int32 == null)
				{
					r_RSetTangents_Vector4Array_Int32_Int32 = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetTangents_Vector4Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetTangents_Vector4Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetTangents_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetTangents_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetTangents_GT_NativeArray_d_T_p_ == null)
				{
					r_RSetTangents_GT_NativeArray_d_T_p_ = new(this, "SetTangents", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetTangents_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetTangents_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetTangents_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetTangents", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetColors(System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RGetColors_List_d_Color_p_;
		public virtual RMethod RGetColors_List_d_Color_p_
		{
			get
			{
				if(r_RGetColors_List_d_Color_p_ == null)
				{
					r_RGetColors_List_d_Color_p_ = new(this, "GetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RGetColors_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RGetColors_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_RSetColors_List_d_Color_p_;
		public virtual RMethod RSetColors_List_d_Color_p_
		{
			get
			{
				if(r_RSetColors_List_d_Color_p_ == null)
				{
					r_RSetColors_List_d_Color_p_ = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)));
					r_RSetColors_List_d_Color_p_.SetBelong(this.instance);
				}
				return r_RSetColors_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetColors_List_d_Color_p__Int32_Int32;
		public virtual RMethod RSetColors_List_d_Color_p__Int32_Int32
		{
			get
			{
				if(r_RSetColors_List_d_Color_p__Int32_Int32 == null)
				{
					r_RSetColors_List_d_Color_p__Int32_Int32 = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)), typeof(System.Int32), typeof(System.Int32));
					r_RSetColors_List_d_Color_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetColors_List_d_Color_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[])
		/// </summary>
		protected RMethod r_RSetColors_ColorArray;
		public virtual RMethod RSetColors_ColorArray
		{
			get
			{
				if(r_RSetColors_ColorArray == null)
				{
					r_RSetColors_ColorArray = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType());
					r_RSetColors_ColorArray.SetBelong(this.instance);
				}
				return r_RSetColors_ColorArray;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetColors_ColorArray_Int32_Int32;
		public virtual RMethod RSetColors_ColorArray_Int32_Int32
		{
			get
			{
				if(r_RSetColors_ColorArray_Int32_Int32 == null)
				{
					r_RSetColors_ColorArray_Int32_Int32 = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetColors_ColorArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetColors_ColorArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetColors_ColorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetColors(System.Collections.Generic.List`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_RGetColors_List_d_Color32_p_;
		public virtual RMethod RGetColors_List_d_Color32_p_
		{
			get
			{
				if(r_RGetColors_List_d_Color32_p_ == null)
				{
					r_RGetColors_List_d_Color32_p_ = new(this, "GetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)));
					r_RGetColors_List_d_Color32_p_.SetBelong(this.instance);
				}
				return r_RGetColors_List_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_RSetColors_List_d_Color32_p_;
		public virtual RMethod RSetColors_List_d_Color32_p_
		{
			get
			{
				if(r_RSetColors_List_d_Color32_p_ == null)
				{
					r_RSetColors_List_d_Color32_p_ = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)));
					r_RSetColors_List_d_Color32_p_.SetBelong(this.instance);
				}
				return r_RSetColors_List_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetColors_List_d_Color32_p__Int32_Int32;
		public virtual RMethod RSetColors_List_d_Color32_p__Int32_Int32
		{
			get
			{
				if(r_RSetColors_List_d_Color32_p__Int32_Int32 == null)
				{
					r_RSetColors_List_d_Color32_p__Int32_Int32 = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)), typeof(System.Int32), typeof(System.Int32));
					r_RSetColors_List_d_Color32_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetColors_List_d_Color32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Color32)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_RSetColors_Color32Array;
		public virtual RMethod RSetColors_Color32Array
		{
			get
			{
				if(r_RSetColors_Color32Array == null)
				{
					r_RSetColors_Color32Array = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType());
					r_RSetColors_Color32Array.SetBelong(this.instance);
				}
				return r_RSetColors_Color32Array;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetColors_Color32Array_Int32_Int32;
		public virtual RMethod RSetColors_Color32Array_Int32_Int32
		{
			get
			{
				if(r_RSetColors_Color32Array_Int32_Int32 == null)
				{
					r_RSetColors_Color32Array_Int32_Int32 = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetColors_Color32Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetColors_Color32Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetColors_Color32Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetColors_GT_NativeArray_d_T_p_;
		public virtual RMethod RSetColors_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetColors_GT_NativeArray_d_T_p_ == null)
				{
					r_RSetColors_GT_NativeArray_d_T_p_ = new(this, "SetColors", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetColors_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetColors_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetColors_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetColors", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUvsImpl[T](Int32, Int32, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUvsImpl", 1, typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector2_p_;
		public virtual RMethod RSetUVs_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector2_p_ == null)
				{
					r_RSetUVs_Int32_List_d_Vector2_p_ = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_RSetUVs_Int32_List_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector3_p_;
		public virtual RMethod RSetUVs_Int32_List_d_Vector3_p_
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector3_p_ == null)
				{
					r_RSetUVs_Int32_List_d_Vector3_p_ = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_RSetUVs_Int32_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector4_p_;
		public virtual RMethod RSetUVs_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector4_p_ == null)
				{
					r_RSetUVs_Int32_List_d_Vector4_p_ = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RSetUVs_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32;
		public virtual RMethod RSetUVs_Int32_List_d_Vector2_p__Int32_Int32
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32 == null)
				{
					r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RSetUVs_Int32_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32;
		public virtual RMethod RSetUVs_Int32_List_d_Vector4_p__Int32_Int32
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32 == null)
				{
					r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUvsImpl(Int32, Int32, System.Array, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUvsImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[])
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector2Array;
		public virtual RMethod RSetUVs_Int32_Vector2Array
		{
			get
			{
				if(r_RSetUVs_Int32_Vector2Array == null)
				{
					r_RSetUVs_Int32_Vector2Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType());
					r_RSetUVs_Int32_Vector2Array.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector2Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector3Array;
		public virtual RMethod RSetUVs_Int32_Vector3Array
		{
			get
			{
				if(r_RSetUVs_Int32_Vector3Array == null)
				{
					r_RSetUVs_Int32_Vector3Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType());
					r_RSetUVs_Int32_Vector3Array.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector4Array;
		public virtual RMethod RSetUVs_Int32_Vector4Array
		{
			get
			{
				if(r_RSetUVs_Int32_Vector4Array == null)
				{
					r_RSetUVs_Int32_Vector4Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetUVs_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector2Array_Int32_Int32;
		public virtual RMethod RSetUVs_Int32_Vector2Array_Int32_Int32
		{
			get
			{
				if(r_RSetUVs_Int32_Vector2Array_Int32_Int32 == null)
				{
					r_RSetUVs_Int32_Vector2Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_Int32_Vector2Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector2Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector3Array_Int32_Int32;
		public virtual RMethod RSetUVs_Int32_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_RSetUVs_Int32_Vector3Array_Int32_Int32 == null)
				{
					r_RSetUVs_Int32_Vector3Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_Int32_Vector3Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector4Array_Int32_Int32;
		public virtual RMethod RSetUVs_Int32_Vector4Array_Int32_Int32
		{
			get
			{
				if(r_RSetUVs_Int32_Vector4Array_Int32_Int32 == null)
				{
					r_RSetUVs_Int32_Vector4Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_Int32_Vector4Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector4Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RSetUVs_GT_Int32_NativeArray_d_T_p_;
		public virtual RMethod RSetUVs_GT_Int32_NativeArray_d_T_p_
		{
			get
			{
				if(r_RSetUVs_GT_Int32_NativeArray_d_T_p_ == null)
				{
					r_RSetUVs_GT_Int32_NativeArray_d_T_p_ = new(this, "SetUVs", 1, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetUVs_GT_Int32_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RSetUVs_GT_Int32_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32 = new(this, "SetUVs", 1, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 1, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetUVsImpl[T](Int32, System.Collections.Generic.List`1[T], Int32)
		/// </summary>
		protected RMethod r_RGetUVsImpl_GT_Int32_List_d_T_p__Int32;
		public virtual RMethod RGetUVsImpl_GT_Int32_List_d_T_p__Int32
		{
			get
			{
				if(r_RGetUVsImpl_GT_Int32_List_d_T_p__Int32 == null)
				{
					r_RGetUVsImpl_GT_Int32_List_d_T_p__Int32 = new(this, "GetUVsImpl", 1, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32));
					r_RGetUVsImpl_GT_Int32_List_d_T_p__Int32.SetBelong(this.instance);
				}
				return r_RGetUVsImpl_GT_Int32_List_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_RGetUVs_Int32_List_d_Vector2_p_;
		public virtual RMethod RGetUVs_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_RGetUVs_Int32_List_d_Vector2_p_ == null)
				{
					r_RGetUVs_Int32_List_d_Vector2_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_RGetUVs_Int32_List_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_RGetUVs_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RGetUVs_Int32_List_d_Vector3_p_;
		public virtual RMethod RGetUVs_Int32_List_d_Vector3_p_
		{
			get
			{
				if(r_RGetUVs_Int32_List_d_Vector3_p_ == null)
				{
					r_RGetUVs_Int32_List_d_Vector3_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector3)));
					r_RGetUVs_Int32_List_d_Vector3_p_.SetBelong(this.instance);
				}
				return r_RGetUVs_Int32_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_RGetUVs_Int32_List_d_Vector4_p_;
		public virtual RMethod RGetUVs_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_RGetUVs_Int32_List_d_Vector4_p_ == null)
				{
					r_RGetUVs_Int32_List_d_Vector4_p_ = new(this, "GetUVs", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector4)));
					r_RGetUVs_Int32_List_d_Vector4_p_.SetBelong(this.instance);
				}
				return r_RGetUVs_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes()
		/// </summary>
		protected RMethod r_RGetVertexAttributes;
		public virtual RMethod RGetVertexAttributes
		{
			get
			{
				if(r_RGetVertexAttributes == null)
				{
					r_RGetVertexAttributes = new(this, "GetVertexAttributes", 0);
					r_RGetVertexAttributes.SetBelong(this.instance);
				}
				return r_RGetVertexAttributes;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_RGetVertexAttributes_VertexAttributeDescriptorArray;
		public virtual RMethod RGetVertexAttributes_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_RGetVertexAttributes_VertexAttributeDescriptorArray == null)
				{
					r_RGetVertexAttributes_VertexAttributeDescriptorArray = new(this, "GetVertexAttributes", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_RGetVertexAttributes_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_RGetVertexAttributes_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributes(System.Collections.Generic.List`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_ == null)
				{
					r_RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_ = new(this, "GetVertexAttributes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
					r_RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_.SetBelong(this.instance);
				}
				return r_RGetVertexAttributes_List_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParams(Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray;
		public virtual RMethod RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray == null)
				{
					r_RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray = new(this, "SetVertexBufferParams", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
					r_RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray.SetBelong(this.instance);
				}
				return r_RSetVertexBufferParams_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParams(Int32, Unity.Collections.NativeArray`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_ == null)
				{
					r_RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_ = new(this, "SetVertexBufferParams", 0, typeof(System.Int32), typeof(Unity.Collections.NativeArray<>).MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
					r_RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_.SetBelong(this.instance);
				}
				return r_RSetVertexBufferParams_Int32_NativeArray_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](T[], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh)
		/// </summary>
		protected static RMethod r_RAcquireReadOnlyMeshData_Mesh;
		public static RMethod RAcquireReadOnlyMeshData_Mesh
		{
			get
			{
				if(r_RAcquireReadOnlyMeshData_Mesh == null)
				{
					r_RAcquireReadOnlyMeshData_Mesh = new(typeof(UnityEngine.Mesh), "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh));
					r_RAcquireReadOnlyMeshData_Mesh.SetBelong(null);
				}
				return r_RAcquireReadOnlyMeshData_Mesh;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[])
		/// </summary>
		protected static RMethod r_RAcquireReadOnlyMeshData_MeshArray;
		public static RMethod RAcquireReadOnlyMeshData_MeshArray
		{
			get
			{
				if(r_RAcquireReadOnlyMeshData_MeshArray == null)
				{
					r_RAcquireReadOnlyMeshData_MeshArray = new(typeof(UnityEngine.Mesh), "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh).MakeArrayType());
					r_RAcquireReadOnlyMeshData_MeshArray.SetBelong(null);
				}
				return r_RAcquireReadOnlyMeshData_MeshArray;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List`1[UnityEngine.Mesh])
		/// </summary>
		protected static RMethod r_RAcquireReadOnlyMeshData_List_d_Mesh_p_;
		public static RMethod RAcquireReadOnlyMeshData_List_d_Mesh_p_
		{
			get
			{
				if(r_RAcquireReadOnlyMeshData_List_d_Mesh_p_ == null)
				{
					r_RAcquireReadOnlyMeshData_List_d_Mesh_p_ = new(typeof(UnityEngine.Mesh), "AcquireReadOnlyMeshData", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Mesh)));
					r_RAcquireReadOnlyMeshData_List_d_Mesh_p_.SetBelong(null);
				}
				return r_RAcquireReadOnlyMeshData_List_d_Mesh_p_;
			}
		}

		/// <summary>
		/// MeshDataArray AllocateWritableMeshData(Int32)
		/// </summary>
		protected static RMethod r_RAllocateWritableMeshData_Int32;
		public static RMethod RAllocateWritableMeshData_Int32
		{
			get
			{
				if(r_RAllocateWritableMeshData_Int32 == null)
				{
					r_RAllocateWritableMeshData_Int32 = new(typeof(UnityEngine.Mesh), "AllocateWritableMeshData", 0, typeof(System.Int32));
					r_RAllocateWritableMeshData_Int32.SetBelong(null);
				}
				return r_RAllocateWritableMeshData_Int32;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, UnityEngine.Mesh, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags;
		public static RMethod RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags
		{
			get
			{
				if(r_RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags == null)
				{
					r_RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags = new(typeof(UnityEngine.Mesh), "ApplyAndDisposeWritableMeshData", 0,  ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(UnityEngine.Mesh), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags.SetBelong(null);
				}
				return r_RApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, UnityEngine.Mesh[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags;
		public static RMethod RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags
		{
			get
			{
				if(r_RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags == null)
				{
					r_RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags = new(typeof(UnityEngine.Mesh), "ApplyAndDisposeWritableMeshData", 0,  ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(UnityEngine.Mesh).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags.SetBelong(null);
				}
				return r_RApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, System.Collections.Generic.List`1[UnityEngine.Mesh], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags;
		public static RMethod RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags
		{
			get
			{
				if(r_RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags == null)
				{
					r_RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags = new(typeof(UnityEngine.Mesh), "ApplyAndDisposeWritableMeshData", 0,  ReleactionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Mesh)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags.SetBelong(null);
				}
				return r_RApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetVertexBuffer(Int32)
		/// </summary>
		protected RMethod r_RGetVertexBuffer_Int32;
		public virtual RMethod RGetVertexBuffer_Int32
		{
			get
			{
				if(r_RGetVertexBuffer_Int32 == null)
				{
					r_RGetVertexBuffer_Int32 = new(this, "GetVertexBuffer", 0, typeof(System.Int32));
					r_RGetVertexBuffer_Int32.SetBelong(this.instance);
				}
				return r_RGetVertexBuffer_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetIndexBuffer()
		/// </summary>
		protected RMethod r_RGetIndexBuffer;
		public virtual RMethod RGetIndexBuffer
		{
			get
			{
				if(r_RGetIndexBuffer == null)
				{
					r_RGetIndexBuffer = new(this, "GetIndexBuffer", 0);
					r_RGetIndexBuffer.SetBelong(this.instance);
				}
				return r_RGetIndexBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights)
		/// </summary>
		protected RMethod r_RGetBoneWeightBuffer_SkinWeights;
		public virtual RMethod RGetBoneWeightBuffer_SkinWeights
		{
			get
			{
				if(r_RGetBoneWeightBuffer_SkinWeights == null)
				{
					r_RGetBoneWeightBuffer_SkinWeights = new(this, "GetBoneWeightBuffer", 0, typeof(UnityEngine.SkinWeights));
					r_RGetBoneWeightBuffer_SkinWeights.SetBelong(this.instance);
				}
				return r_RGetBoneWeightBuffer_SkinWeights;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout)
		/// </summary>
		protected RMethod r_RGetBlendShapeBuffer_BlendShapeBufferLayout;
		public virtual RMethod RGetBlendShapeBuffer_BlendShapeBufferLayout
		{
			get
			{
				if(r_RGetBlendShapeBuffer_BlendShapeBufferLayout == null)
				{
					r_RGetBlendShapeBuffer_BlendShapeBufferLayout = new(this, "GetBlendShapeBuffer", 0, typeof(UnityEngine.Rendering.BlendShapeBufferLayout));
					r_RGetBlendShapeBuffer_BlendShapeBufferLayout.SetBelong(this.instance);
				}
				return r_RGetBlendShapeBuffer_BlendShapeBufferLayout;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBuffer()
		/// </summary>
		protected RMethod r_RGetBlendShapeBuffer;
		public virtual RMethod RGetBlendShapeBuffer
		{
			get
			{
				if(r_RGetBlendShapeBuffer == null)
				{
					r_RGetBlendShapeBuffer = new(this, "GetBlendShapeBuffer", 0);
					r_RGetBlendShapeBuffer.SetBelong(this.instance);
				}
				return r_RGetBlendShapeBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(Int32)
		/// </summary>
		protected RMethod r_RGetBlendShapeBufferRange_Int32;
		public virtual RMethod RGetBlendShapeBufferRange_Int32
		{
			get
			{
				if(r_RGetBlendShapeBufferRange_Int32 == null)
				{
					r_RGetBlendShapeBufferRange_Int32 = new(this, "GetBlendShapeBufferRange", 0, typeof(System.Int32));
					r_RGetBlendShapeBufferRange_Int32.SetBelong(this.instance);
				}
				return r_RGetBlendShapeBufferRange_Int32;
			}
		}

		/// <summary>
		/// Void PrintErrorCantAccessIndices()
		/// </summary>
		protected RMethod r_RPrintErrorCantAccessIndices;
		public virtual RMethod RPrintErrorCantAccessIndices
		{
			get
			{
				if(r_RPrintErrorCantAccessIndices == null)
				{
					r_RPrintErrorCantAccessIndices = new(this, "PrintErrorCantAccessIndices", 0);
					r_RPrintErrorCantAccessIndices.SetBelong(this.instance);
				}
				return r_RPrintErrorCantAccessIndices;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmesh(Int32, Boolean)
		/// </summary>
		protected RMethod r_RCheckCanAccessSubmesh_Int32_Boolean;
		public virtual RMethod RCheckCanAccessSubmesh_Int32_Boolean
		{
			get
			{
				if(r_RCheckCanAccessSubmesh_Int32_Boolean == null)
				{
					r_RCheckCanAccessSubmesh_Int32_Boolean = new(this, "CheckCanAccessSubmesh", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RCheckCanAccessSubmesh_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RCheckCanAccessSubmesh_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmeshTriangles(Int32)
		/// </summary>
		protected RMethod r_RCheckCanAccessSubmeshTriangles_Int32;
		public virtual RMethod RCheckCanAccessSubmeshTriangles_Int32
		{
			get
			{
				if(r_RCheckCanAccessSubmeshTriangles_Int32 == null)
				{
					r_RCheckCanAccessSubmeshTriangles_Int32 = new(this, "CheckCanAccessSubmeshTriangles", 0, typeof(System.Int32));
					r_RCheckCanAccessSubmeshTriangles_Int32.SetBelong(this.instance);
				}
				return r_RCheckCanAccessSubmeshTriangles_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmeshIndices(Int32)
		/// </summary>
		protected RMethod r_RCheckCanAccessSubmeshIndices_Int32;
		public virtual RMethod RCheckCanAccessSubmeshIndices_Int32
		{
			get
			{
				if(r_RCheckCanAccessSubmeshIndices_Int32 == null)
				{
					r_RCheckCanAccessSubmeshIndices_Int32 = new(this, "CheckCanAccessSubmeshIndices", 0, typeof(System.Int32));
					r_RCheckCanAccessSubmeshIndices_Int32.SetBelong(this.instance);
				}
				return r_RCheckCanAccessSubmeshIndices_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTriangles(Int32)
		/// </summary>
		protected RMethod r_RGetTriangles_Int32;
		public virtual RMethod RGetTriangles_Int32
		{
			get
			{
				if(r_RGetTriangles_Int32 == null)
				{
					r_RGetTriangles_Int32 = new(this, "GetTriangles", 0, typeof(System.Int32));
					r_RGetTriangles_Int32.SetBelong(this.instance);
				}
				return r_RGetTriangles_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTriangles(Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTriangles_Int32_Boolean;
		public virtual RMethod RGetTriangles_Int32_Boolean
		{
			get
			{
				if(r_RGetTriangles_Int32_Boolean == null)
				{
					r_RGetTriangles_Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RGetTriangles_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTriangles_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_RGetTriangles_List_d_Int32_p__Int32;
		public virtual RMethod RGetTriangles_List_d_Int32_p__Int32
		{
			get
			{
				if(r_RGetTriangles_List_d_Int32_p__Int32 == null)
				{
					r_RGetTriangles_List_d_Int32_p__Int32 = new(this, "GetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_RGetTriangles_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_RGetTriangles_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTriangles_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RGetTriangles_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_RGetTriangles_List_d_Int32_p__Int32_Boolean == null)
				{
					r_RGetTriangles_List_d_Int32_p__Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTriangles_List_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTriangles_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetTriangles_List_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RGetTriangles_List_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_RGetTriangles_List_d_UInt16_p__Int32_Boolean == null)
				{
					r_RGetTriangles_List_d_UInt16_p__Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
					r_RGetTriangles_List_d_UInt16_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetTriangles_List_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32[] GetIndices(Int32)
		/// </summary>
		protected RMethod r_RGetIndices_Int32;
		public virtual RMethod RGetIndices_Int32
		{
			get
			{
				if(r_RGetIndices_Int32 == null)
				{
					r_RGetIndices_Int32 = new(this, "GetIndices", 0, typeof(System.Int32));
					r_RGetIndices_Int32.SetBelong(this.instance);
				}
				return r_RGetIndices_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetIndices(Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetIndices_Int32_Boolean;
		public virtual RMethod RGetIndices_Int32_Boolean
		{
			get
			{
				if(r_RGetIndices_Int32_Boolean == null)
				{
					r_RGetIndices_Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RGetIndices_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetIndices_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_RGetIndices_List_d_Int32_p__Int32;
		public virtual RMethod RGetIndices_List_d_Int32_p__Int32
		{
			get
			{
				if(r_RGetIndices_List_d_Int32_p__Int32 == null)
				{
					r_RGetIndices_List_d_Int32_p__Int32 = new(this, "GetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_RGetIndices_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_RGetIndices_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetIndices_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RGetIndices_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_RGetIndices_List_d_Int32_p__Int32_Boolean == null)
				{
					r_RGetIndices_List_d_Int32_p__Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_RGetIndices_List_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetIndices_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetIndices_List_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RGetIndices_List_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_RGetIndices_List_d_UInt16_p__Int32_Boolean == null)
				{
					r_RGetIndices_List_d_UInt16_p__Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
					r_RGetIndices_List_d_UInt16_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetIndices_List_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](T[], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UInt32 GetIndexStart(Int32)
		/// </summary>
		protected RMethod r_RGetIndexStart_Int32;
		public virtual RMethod RGetIndexStart_Int32
		{
			get
			{
				if(r_RGetIndexStart_Int32 == null)
				{
					r_RGetIndexStart_Int32 = new(this, "GetIndexStart", 0, typeof(System.Int32));
					r_RGetIndexStart_Int32.SetBelong(this.instance);
				}
				return r_RGetIndexStart_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexCount(Int32)
		/// </summary>
		protected RMethod r_RGetIndexCount_Int32;
		public virtual RMethod RGetIndexCount_Int32
		{
			get
			{
				if(r_RGetIndexCount_Int32 == null)
				{
					r_RGetIndexCount_Int32 = new(this, "GetIndexCount", 0, typeof(System.Int32));
					r_RGetIndexCount_Int32.SetBelong(this.instance);
				}
				return r_RGetIndexCount_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetBaseVertex(Int32)
		/// </summary>
		protected RMethod r_RGetBaseVertex_Int32;
		public virtual RMethod RGetBaseVertex_Int32
		{
			get
			{
				if(r_RGetBaseVertex_Int32 == null)
				{
					r_RGetBaseVertex_Int32 = new(this, "GetBaseVertex", 0, typeof(System.Int32));
					r_RGetBaseVertex_Int32.SetBelong(this.instance);
				}
				return r_RGetBaseVertex_Int32;
			}
		}

		/// <summary>
		/// Void CheckIndicesArrayRange(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RCheckIndicesArrayRange_Int32_Int32_Int32;
		public virtual RMethod RCheckIndicesArrayRange_Int32_Int32_Int32
		{
			get
			{
				if(r_RCheckIndicesArrayRange_Int32_Int32_Int32 == null)
				{
					r_RCheckIndicesArrayRange_Int32_Int32_Int32 = new(this, "CheckIndicesArrayRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RCheckIndicesArrayRange_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCheckIndicesArrayRange_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTrianglesImpl(Int32, UnityEngine.Rendering.IndexFormat, System.Array, Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTrianglesImpl", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_Int32Array_Int32;
		public virtual RMethod RSetTriangles_Int32Array_Int32
		{
			get
			{
				if(r_RSetTriangles_Int32Array_Int32 == null)
				{
					r_RSetTriangles_Int32Array_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32));
					r_RSetTriangles_Int32Array_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_Int32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetTriangles_Int32Array_Int32_Boolean;
		public virtual RMethod RSetTriangles_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_RSetTriangles_Int32Array_Int32_Boolean == null)
				{
					r_RSetTriangles_Int32Array_Int32_Boolean = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_RSetTriangles_Int32Array_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetTriangles_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_Int32Array_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_Int32Array_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_Int32Array_Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_Int32Array_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_Int32Array_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_Int32Array_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(UInt16[], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_UInt16Array_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_UInt16Array_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_UInt16Array_Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_UInt16Array_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_UInt16Array_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_UInt16Array_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(UInt16[], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_List_d_Int32_p__Int32;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32
		{
			get
			{
				if(r_RSetTriangles_List_d_Int32_p__Int32 == null)
				{
					r_RSetTriangles_List_d_Int32_p__Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_RSetTriangles_List_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetTriangles_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_RSetTriangles_List_d_Int32_p__Int32_Boolean == null)
				{
					r_RSetTriangles_List_d_Int32_p__Int32_Boolean = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
					r_RSetTriangles_List_d_Int32_p__Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetTriangles_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_List_d_Int32_p__Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_Int32Array_MeshTopology_Int32;
		public virtual RMethod RSetIndices_Int32Array_MeshTopology_Int32
		{
			get
			{
				if(r_RSetIndices_Int32Array_MeshTopology_Int32 == null)
				{
					r_RSetIndices_Int32Array_MeshTopology_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
					r_RSetIndices_Int32Array_MeshTopology_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_Int32Array_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean;
		public virtual RMethod RSetIndices_Int32Array_MeshTopology_Int32_Boolean
		{
			get
			{
				if(r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean == null)
				{
					r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean));
					r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(UInt16[], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.UInt16).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(UInt16[], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices[T](Unity.Collections.NativeArray`1[T], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.Int32], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.Int32], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.UInt16], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.UInt16], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
					r_RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags == null)
				{
					r_RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(System.Collections.Generic.List`1[UnityEngine.Rendering.SubMeshDescriptor], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SubMeshDescriptor)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(System.Collections.Generic.List`1[UnityEngine.Rendering.SubMeshDescriptor], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags == null)
				{
					r_RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.SubMeshDescriptor)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes[T](Unity.Collections.NativeArray`1[T], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags;
		public virtual RMethod RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags == null)
				{
					r_RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags = new(this, "SetSubMeshes", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetBindposes(System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_RGetBindposes_List_d_Matrix4x4_p_;
		public virtual RMethod RGetBindposes_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_RGetBindposes_List_d_Matrix4x4_p_ == null)
				{
					r_RGetBindposes_List_d_Matrix4x4_p_ = new(this, "GetBindposes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Matrix4x4)));
					r_RGetBindposes_List_d_Matrix4x4_p_.SetBelong(this.instance);
				}
				return r_RGetBindposes_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetBoneWeights(System.Collections.Generic.List`1[UnityEngine.BoneWeight])
		/// </summary>
		protected RMethod r_RGetBoneWeights_List_d_BoneWeight_p_;
		public virtual RMethod RGetBoneWeights_List_d_BoneWeight_p_
		{
			get
			{
				if(r_RGetBoneWeights_List_d_BoneWeight_p_ == null)
				{
					r_RGetBoneWeights_List_d_BoneWeight_p_ = new(this, "GetBoneWeights", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.BoneWeight)));
					r_RGetBoneWeights_List_d_BoneWeight_p_.SetBelong(this.instance);
				}
				return r_RGetBoneWeights_List_d_BoneWeight_p_;
			}
		}

		/// <summary>
		/// Void Clear(Boolean)
		/// </summary>
		protected RMethod r_RClear_Boolean;
		public virtual RMethod RClear_Boolean
		{
			get
			{
				if(r_RClear_Boolean == null)
				{
					r_RClear_Boolean = new(this, "Clear", 0, typeof(System.Boolean));
					r_RClear_Boolean.SetBelong(this.instance);
				}
				return r_RClear_Boolean;
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
		/// Void RecalculateBounds()
		/// </summary>
		protected RMethod r_RRecalculateBounds;
		public virtual RMethod RRecalculateBounds
		{
			get
			{
				if(r_RRecalculateBounds == null)
				{
					r_RRecalculateBounds = new(this, "RecalculateBounds", 0);
					r_RRecalculateBounds.SetBelong(this.instance);
				}
				return r_RRecalculateBounds;
			}
		}

		/// <summary>
		/// Void RecalculateNormals()
		/// </summary>
		protected RMethod r_RRecalculateNormals;
		public virtual RMethod RRecalculateNormals
		{
			get
			{
				if(r_RRecalculateNormals == null)
				{
					r_RRecalculateNormals = new(this, "RecalculateNormals", 0);
					r_RRecalculateNormals.SetBelong(this.instance);
				}
				return r_RRecalculateNormals;
			}
		}

		/// <summary>
		/// Void RecalculateTangents()
		/// </summary>
		protected RMethod r_RRecalculateTangents;
		public virtual RMethod RRecalculateTangents
		{
			get
			{
				if(r_RRecalculateTangents == null)
				{
					r_RRecalculateTangents = new(this, "RecalculateTangents", 0);
					r_RRecalculateTangents.SetBelong(this.instance);
				}
				return r_RRecalculateTangents;
			}
		}

		/// <summary>
		/// Void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RRecalculateBounds_MeshUpdateFlags;
		public virtual RMethod RRecalculateBounds_MeshUpdateFlags
		{
			get
			{
				if(r_RRecalculateBounds_MeshUpdateFlags == null)
				{
					r_RRecalculateBounds_MeshUpdateFlags = new(this, "RecalculateBounds", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RRecalculateBounds_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RRecalculateBounds_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RRecalculateNormals_MeshUpdateFlags;
		public virtual RMethod RRecalculateNormals_MeshUpdateFlags
		{
			get
			{
				if(r_RRecalculateNormals_MeshUpdateFlags == null)
				{
					r_RRecalculateNormals_MeshUpdateFlags = new(this, "RecalculateNormals", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RRecalculateNormals_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RRecalculateNormals_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RRecalculateTangents_MeshUpdateFlags;
		public virtual RMethod RRecalculateTangents_MeshUpdateFlags
		{
			get
			{
				if(r_RRecalculateTangents_MeshUpdateFlags == null)
				{
					r_RRecalculateTangents_MeshUpdateFlags = new(this, "RecalculateTangents", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RRecalculateTangents_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RRecalculateTangents_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetric(Int32, Single)
		/// </summary>
		protected RMethod r_RRecalculateUVDistributionMetric_Int32_Single;
		public virtual RMethod RRecalculateUVDistributionMetric_Int32_Single
		{
			get
			{
				if(r_RRecalculateUVDistributionMetric_Int32_Single == null)
				{
					r_RRecalculateUVDistributionMetric_Int32_Single = new(this, "RecalculateUVDistributionMetric", 0, typeof(System.Int32), typeof(System.Single));
					r_RRecalculateUVDistributionMetric_Int32_Single.SetBelong(this.instance);
				}
				return r_RRecalculateUVDistributionMetric_Int32_Single;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetrics(Single)
		/// </summary>
		protected RMethod r_RRecalculateUVDistributionMetrics_Single;
		public virtual RMethod RRecalculateUVDistributionMetrics_Single
		{
			get
			{
				if(r_RRecalculateUVDistributionMetrics_Single == null)
				{
					r_RRecalculateUVDistributionMetrics_Single = new(this, "RecalculateUVDistributionMetrics", 0, typeof(System.Single));
					r_RRecalculateUVDistributionMetrics_Single.SetBelong(this.instance);
				}
				return r_RRecalculateUVDistributionMetrics_Single;
			}
		}

		/// <summary>
		/// Void MarkDynamic()
		/// </summary>
		protected RMethod r_RMarkDynamic;
		public virtual RMethod RMarkDynamic
		{
			get
			{
				if(r_RMarkDynamic == null)
				{
					r_RMarkDynamic = new(this, "MarkDynamic", 0);
					r_RMarkDynamic.SetBelong(this.instance);
				}
				return r_RMarkDynamic;
			}
		}

		/// <summary>
		/// Void UploadMeshData(Boolean)
		/// </summary>
		protected RMethod r_RUploadMeshData_Boolean;
		public virtual RMethod RUploadMeshData_Boolean
		{
			get
			{
				if(r_RUploadMeshData_Boolean == null)
				{
					r_RUploadMeshData_Boolean = new(this, "UploadMeshData", 0, typeof(System.Boolean));
					r_RUploadMeshData_Boolean.SetBelong(this.instance);
				}
				return r_RUploadMeshData_Boolean;
			}
		}

		/// <summary>
		/// Void Optimize()
		/// </summary>
		protected RMethod r_ROptimize;
		public virtual RMethod ROptimize
		{
			get
			{
				if(r_ROptimize == null)
				{
					r_ROptimize = new(this, "Optimize", 0);
					r_ROptimize.SetBelong(this.instance);
				}
				return r_ROptimize;
			}
		}

		/// <summary>
		/// Void OptimizeIndexBuffers()
		/// </summary>
		protected RMethod r_ROptimizeIndexBuffers;
		public virtual RMethod ROptimizeIndexBuffers
		{
			get
			{
				if(r_ROptimizeIndexBuffers == null)
				{
					r_ROptimizeIndexBuffers = new(this, "OptimizeIndexBuffers", 0);
					r_ROptimizeIndexBuffers.SetBelong(this.instance);
				}
				return r_ROptimizeIndexBuffers;
			}
		}

		/// <summary>
		/// Void OptimizeReorderVertexBuffer()
		/// </summary>
		protected RMethod r_ROptimizeReorderVertexBuffer;
		public virtual RMethod ROptimizeReorderVertexBuffer
		{
			get
			{
				if(r_ROptimizeReorderVertexBuffer == null)
				{
					r_ROptimizeReorderVertexBuffer = new(this, "OptimizeReorderVertexBuffer", 0);
					r_ROptimizeReorderVertexBuffer.SetBelong(this.instance);
				}
				return r_ROptimizeReorderVertexBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology GetTopology(Int32)
		/// </summary>
		protected RMethod r_RGetTopology_Int32;
		public virtual RMethod RGetTopology_Int32
		{
			get
			{
				if(r_RGetTopology_Int32 == null)
				{
					r_RGetTopology_Int32 = new(this, "GetTopology", 0, typeof(System.Int32));
					r_RGetTopology_Int32.SetBelong(this.instance);
				}
				return r_RGetTopology_Int32;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean;
		public virtual RMethod RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean == null)
				{
					r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean, Boolean)
		/// </summary>
		protected RMethod r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean;
		public virtual RMethod RCombineMeshes_CombineInstanceArray_Boolean_Boolean
		{
			get
			{
				if(r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean == null)
				{
					r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean));
					r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RCombineMeshes_CombineInstanceArray_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean)
		/// </summary>
		protected RMethod r_RCombineMeshes_CombineInstanceArray_Boolean;
		public virtual RMethod RCombineMeshes_CombineInstanceArray_Boolean
		{
			get
			{
				if(r_RCombineMeshes_CombineInstanceArray_Boolean == null)
				{
					r_RCombineMeshes_CombineInstanceArray_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean));
					r_RCombineMeshes_CombineInstanceArray_Boolean.SetBelong(this.instance);
				}
				return r_RCombineMeshes_CombineInstanceArray_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[])
		/// </summary>
		protected RMethod r_RCombineMeshes_CombineInstanceArray;
		public virtual RMethod RCombineMeshes_CombineInstanceArray
		{
			get
			{
				if(r_RCombineMeshes_CombineInstanceArray == null)
				{
					r_RCombineMeshes_CombineInstanceArray = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType());
					r_RCombineMeshes_CombineInstanceArray.SetBelong(this.instance);
				}
				return r_RCombineMeshes_CombineInstanceArray;
			}
		}

		/// <summary>
		/// Void GetVertexAttribute_Injected(Int32, UnityEngine.Rendering.VertexAttributeDescriptor ByRef)
		/// </summary>
		protected RMethod r_RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor;
		public virtual RMethod RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor
		{
			get
			{
				if(r_RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor == null)
				{
					r_RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor = new(this, "GetVertexAttribute_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeByRefType());
					r_RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor.SetBelong(this.instance);
				}
				return r_RGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Void GetBlendShapeOffsetInternal_Injected(Int32, UnityEngine.BlendShape ByRef)
		/// </summary>
		protected RMethod r_RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape;
		public virtual RMethod RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape
		{
			get
			{
				if(r_RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape == null)
				{
					r_RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape = new(this, "GetBlendShapeOffsetInternal_Injected", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.BlendShape").MakeByRefType());
					r_RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape.SetBelong(this.instance);
				}
				return r_RGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape;
			}
		}

		/// <summary>
		/// Void GetReadOnlySafetyHandle_Injected(SafetyHandleIndex, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle;
		public virtual RMethod RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle == null)
				{
					r_RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle = new(this, "GetReadOnlySafetyHandle_Injected", 0,  ReleactionUtils.GetType("UnityEngine.Mesh+SafetyHandleIndex"), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle.SetBelong(this.instance);
				}
				return r_RGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetSubMesh_Injected(Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
		public virtual RMethod RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags = new(this, "SetSubMesh_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
					r_RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.SetBelong(this.instance);
				}
				return r_RSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetSubMesh_Injected(Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef)
		/// </summary>
		protected RMethod r_RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor;
		public virtual RMethod RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor
		{
			get
			{
				if(r_RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor == null)
				{
					r_RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor = new(this, "GetSubMesh_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType());
					r_RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor.SetBelong(this.instance);
				}
				return r_RGetSubMesh_Injected_Int32_Out_SubMeshDescriptor;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Rget_bounds_Injected_Out_Bounds;
		public virtual RMethod Rget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Rget_bounds_Injected_Out_Bounds == null)
				{
					r_Rget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Rget_bounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_Rget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Rset_bounds_Injected_Ref_Bounds;
		public virtual RMethod Rset_bounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_Rset_bounds_Injected_Ref_Bounds == null)
				{
					r_Rset_bounds_Injected_Ref_Bounds = new(this, "set_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Rset_bounds_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_Rset_bounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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
