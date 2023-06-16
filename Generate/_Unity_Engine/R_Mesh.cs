
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Mesh
	/// </summary>
    public partial class RMesh : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Mesh);
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


		/// <summary>
		/// UnityEngine.Vector2[] uv1
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv1;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv1
		{
			get
			{
				if(r_Puv1 == null)
				{
					r_Puv1 = new(this, "uv1", -1);
				}
				return r_Puv1;
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
		/// Target vertexBufferTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget r_PvertexBufferTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget RPvertexBufferTarget
		{
			get
			{
				if(r_PvertexBufferTarget == null)
				{
					r_PvertexBufferTarget = new(this, "vertexBufferTarget", -1);
				}
				return r_PvertexBufferTarget;
			}
		}

		/// <summary>
		/// Target indexBufferTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget r_PindexBufferTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGraphicsBuffer.RTarget RPindexBufferTarget
		{
			get
			{
				if(r_PindexBufferTarget == null)
				{
					r_PindexBufferTarget = new(this, "indexBufferTarget", -1);
				}
				return r_PindexBufferTarget;
			}
		}

		/// <summary>
		/// Int32 blendShapeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PblendShapeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPblendShapeCount
		{
			get
			{
				if(r_PblendShapeCount == null)
				{
					r_PblendShapeCount = new(this, "blendShapeCount", -1);
				}
				return r_PblendShapeCount;
			}
		}

		/// <summary>
		/// Int32 bindposeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PbindposeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbindposeCount
		{
			get
			{
				if(r_PbindposeCount == null)
				{
					r_PbindposeCount = new(this, "bindposeCount", -1);
				}
				return r_PbindposeCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] bindposes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4> r_Pbindposes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4> RPbindposes
		{
			get
			{
				if(r_Pbindposes == null)
				{
					r_Pbindposes = new(this, "bindposes", -1);
				}
				return r_Pbindposes;
			}
		}

		/// <summary>
		/// Boolean isReadable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisReadable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisReadable
		{
			get
			{
				if(r_PisReadable == null)
				{
					r_PisReadable = new(this, "isReadable", -1);
				}
				return r_PisReadable;
			}
		}

		/// <summary>
		/// Boolean canAccess
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanAccess;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanAccess
		{
			get
			{
				if(r_PcanAccess == null)
				{
					r_PcanAccess = new(this, "canAccess", -1);
				}
				return r_PcanAccess;
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
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBounds r_Pbounds;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBounds RPbounds
		{
			get
			{
				if(r_Pbounds == null)
				{
					r_Pbounds = new(this, "bounds", -1);
				}
				return r_Pbounds;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] vertices
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> r_Pvertices;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> RPvertices
		{
			get
			{
				if(r_Pvertices == null)
				{
					r_Pvertices = new(this, "vertices", -1);
				}
				return r_Pvertices;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] normals
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> r_Pnormals;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> RPnormals
		{
			get
			{
				if(r_Pnormals == null)
				{
					r_Pnormals = new(this, "normals", -1);
				}
				return r_Pnormals;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] tangents
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> r_Ptangents;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> RPtangents
		{
			get
			{
				if(r_Ptangents == null)
				{
					r_Ptangents = new(this, "tangents", -1);
				}
				return r_Ptangents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv
		{
			get
			{
				if(r_Puv == null)
				{
					r_Puv = new(this, "uv", -1);
				}
				return r_Puv;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv2
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv2;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv2
		{
			get
			{
				if(r_Puv2 == null)
				{
					r_Puv2 = new(this, "uv2", -1);
				}
				return r_Puv2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv3
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv3;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv3
		{
			get
			{
				if(r_Puv3 == null)
				{
					r_Puv3 = new(this, "uv3", -1);
				}
				return r_Puv3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv4
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv4;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv4
		{
			get
			{
				if(r_Puv4 == null)
				{
					r_Puv4 = new(this, "uv4", -1);
				}
				return r_Puv4;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv5
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv5;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv5
		{
			get
			{
				if(r_Puv5 == null)
				{
					r_Puv5 = new(this, "uv5", -1);
				}
				return r_Puv5;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv6
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv6;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv6
		{
			get
			{
				if(r_Puv6 == null)
				{
					r_Puv6 = new(this, "uv6", -1);
				}
				return r_Puv6;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv7
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv7;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv7
		{
			get
			{
				if(r_Puv7 == null)
				{
					r_Puv7 = new(this, "uv7", -1);
				}
				return r_Puv7;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv8
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Puv8;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPuv8
		{
			get
			{
				if(r_Puv8 == null)
				{
					r_Puv8 = new(this, "uv8", -1);
				}
				return r_Puv8;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] colors
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RColor> r_Pcolors;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RColor> RPcolors
		{
			get
			{
				if(r_Pcolors == null)
				{
					r_Pcolors = new(this, "colors", -1);
				}
				return r_Pcolors;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] colors32
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> r_Pcolors32;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> RPcolors32
		{
			get
			{
				if(r_Pcolors32 == null)
				{
					r_Pcolors32 = new(this, "colors32", -1);
				}
				return r_Pcolors32;
			}
		}

		/// <summary>
		/// Int32 vertexAttributeCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvertexAttributeCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvertexAttributeCount
		{
			get
			{
				if(r_PvertexAttributeCount == null)
				{
					r_PvertexAttributeCount = new(this, "vertexAttributeCount", -1);
				}
				return r_PvertexAttributeCount;
			}
		}

		/// <summary>
		/// Int32[] triangles
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Ptriangles;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RInt32> RPtriangles
		{
			get
			{
				if(r_Ptriangles == null)
				{
					r_Ptriangles = new(this, "triangles", -1);
				}
				return r_Ptriangles;
			}
		}

		/// <summary>
		/// UnityEngine.BoneWeight[] boneWeights
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RBoneWeight> r_PboneWeights;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RBoneWeight> RPboneWeights
		{
			get
			{
				if(r_PboneWeights == null)
				{
					r_PboneWeights = new(this, "boneWeights", -1);
				}
				return r_PboneWeights;
			}
		}

		/// <summary>
		/// UnityEngine.SkinWeights skinWeightBufferLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSkinWeights r_PskinWeightBufferLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSkinWeights RPskinWeightBufferLayout
		{
			get
			{
				if(r_PskinWeightBufferLayout == null)
				{
					r_PskinWeightBufferLayout = new(this, "skinWeightBufferLayout", -1);
				}
				return r_PskinWeightBufferLayout;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.Mesh)
		/// </summary>
		protected static RMethod r_MInternal_Create_Mesh;
		public static RMethod RMInternal_Create_Mesh
		{
			get
			{
				if(r_MInternal_Create_Mesh == null)
				{
					r_MInternal_Create_Mesh = new(Type, "Internal_Create", 0, typeof(UnityEngine.Mesh));
				}
				return r_MInternal_Create_Mesh;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh FromInstanceID(Int32)
		/// </summary>
		protected static RMethod r_MFromInstanceID_Int32;
		public static RMethod RMFromInstanceID_Int32
		{
			get
			{
				if(r_MFromInstanceID_Int32 == null)
				{
					r_MFromInstanceID_Int32 = new(Type, "FromInstanceID", 0, typeof(System.Int32));
				}
				return r_MFromInstanceID_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetTotalIndexCount()
		/// </summary>
		protected RMethod r_MGetTotalIndexCount;
		public virtual RMethod RMGetTotalIndexCount
		{
			get
			{
				if(r_MGetTotalIndexCount == null)
				{
					r_MGetTotalIndexCount = new(this, "GetTotalIndexCount", 0);
				}
				return r_MGetTotalIndexCount;
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
		/// Void InternalSetIndexBufferData(IntPtr, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetIndexBufferData", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void InternalSetIndexBufferDataFromArray(System.Array, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetIndexBufferDataFromArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromPtr(Int32, IntPtr, Int32)
		/// </summary>
		protected RMethod r_MSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32;
		public virtual RMethod RMSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_MSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32 == null)
				{
					r_MSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32 = new(this, "SetVertexBufferParamsFromPtr", 0, typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void SetVertexBufferParamsFromArray(Int32, UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_MSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray;
		public virtual RMethod RMSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_MSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray == null)
				{
					r_MSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray = new(this, "SetVertexBufferParamsFromArray", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
				}
				return r_MSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Void InternalSetVertexBufferData(Int32, IntPtr, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetVertexBufferData", 0, typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void InternalSetVertexBufferDataFromArray(Int32, System.Array, Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "InternalSetVertexBufferDataFromArray", 0, typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// System.Array GetVertexAttributesAlloc()
		/// </summary>
		protected RMethod r_MGetVertexAttributesAlloc;
		public virtual RMethod RMGetVertexAttributesAlloc
		{
			get
			{
				if(r_MGetVertexAttributesAlloc == null)
				{
					r_MGetVertexAttributesAlloc = new(this, "GetVertexAttributesAlloc", 0);
				}
				return r_MGetVertexAttributesAlloc;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_MGetVertexAttributesArray_VertexAttributeDescriptorArray;
		public virtual RMethod RMGetVertexAttributesArray_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_MGetVertexAttributesArray_VertexAttributeDescriptorArray == null)
				{
					r_MGetVertexAttributesArray_VertexAttributeDescriptorArray = new(this, "GetVertexAttributesArray", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
				}
				return r_MGetVertexAttributesArray_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributesList(System.Collections.Generic.List`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_MGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RMGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_MGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_ == null)
				{
					r_MGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_ = new(this, "GetVertexAttributesList", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
				}
				return r_MGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributeCountImpl()
		/// </summary>
		protected RMethod r_MGetVertexAttributeCountImpl;
		public virtual RMethod RMGetVertexAttributeCountImpl
		{
			get
			{
				if(r_MGetVertexAttributeCountImpl == null)
				{
					r_MGetVertexAttributeCountImpl = new(this, "GetVertexAttributeCountImpl", 0);
				}
				return r_MGetVertexAttributeCountImpl;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(Int32)
		/// </summary>
		protected RMethod r_MGetVertexAttribute_Int32;
		public virtual RMethod RMGetVertexAttribute_Int32
		{
			get
			{
				if(r_MGetVertexAttribute_Int32 == null)
				{
					r_MGetVertexAttribute_Int32 = new(this, "GetVertexAttribute", 0, typeof(System.Int32));
				}
				return r_MGetVertexAttribute_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexStartImpl(Int32)
		/// </summary>
		protected RMethod r_MGetIndexStartImpl_Int32;
		public virtual RMethod RMGetIndexStartImpl_Int32
		{
			get
			{
				if(r_MGetIndexStartImpl_Int32 == null)
				{
					r_MGetIndexStartImpl_Int32 = new(this, "GetIndexStartImpl", 0, typeof(System.Int32));
				}
				return r_MGetIndexStartImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexCountImpl(Int32)
		/// </summary>
		protected RMethod r_MGetIndexCountImpl_Int32;
		public virtual RMethod RMGetIndexCountImpl_Int32
		{
			get
			{
				if(r_MGetIndexCountImpl_Int32 == null)
				{
					r_MGetIndexCountImpl_Int32 = new(this, "GetIndexCountImpl", 0, typeof(System.Int32));
				}
				return r_MGetIndexCountImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetTrianglesCountImpl(Int32)
		/// </summary>
		protected RMethod r_MGetTrianglesCountImpl_Int32;
		public virtual RMethod RMGetTrianglesCountImpl_Int32
		{
			get
			{
				if(r_MGetTrianglesCountImpl_Int32 == null)
				{
					r_MGetTrianglesCountImpl_Int32 = new(this, "GetTrianglesCountImpl", 0, typeof(System.Int32));
				}
				return r_MGetTrianglesCountImpl_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetBaseVertexImpl(Int32)
		/// </summary>
		protected RMethod r_MGetBaseVertexImpl_Int32;
		public virtual RMethod RMGetBaseVertexImpl_Int32
		{
			get
			{
				if(r_MGetBaseVertexImpl_Int32 == null)
				{
					r_MGetBaseVertexImpl_Int32 = new(this, "GetBaseVertexImpl", 0, typeof(System.Int32));
				}
				return r_MGetBaseVertexImpl_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTrianglesImpl(Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTrianglesImpl_Int32_Boolean;
		public virtual RMethod RMGetTrianglesImpl_Int32_Boolean
		{
			get
			{
				if(r_MGetTrianglesImpl_Int32_Boolean == null)
				{
					r_MGetTrianglesImpl_Int32_Boolean = new(this, "GetTrianglesImpl", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTrianglesImpl_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32[] GetIndicesImpl(Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndicesImpl_Int32_Boolean;
		public virtual RMethod RMGetIndicesImpl_Int32_Boolean
		{
			get
			{
				if(r_MGetIndicesImpl_Int32_Boolean == null)
				{
					r_MGetIndicesImpl_Int32_Boolean = new(this, "GetIndicesImpl", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndicesImpl_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndicesImpl(Int32, UnityEngine.MeshTopology, UnityEngine.Rendering.IndexFormat, System.Array, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32 = new(this, "SetIndicesImpl", 0, typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndicesNativeArrayImpl(Int32, UnityEngine.MeshTopology, UnityEngine.Rendering.IndexFormat, IntPtr, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32 = new(this, "SetIndicesNativeArrayImpl", 0, typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void GetTrianglesNonAllocImpl(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean;
		public virtual RMethod RMGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_MGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean == null)
				{
					r_MGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean = new(this, "GetTrianglesNonAllocImpl", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTrianglesNonAllocImpl16(UInt16[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean;
		public virtual RMethod RMGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean
		{
			get
			{
				if(r_MGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean == null)
				{
					r_MGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean = new(this, "GetTrianglesNonAllocImpl16", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndicesNonAllocImpl(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndicesNonAllocImpl_Int32Array_Int32_Boolean;
		public virtual RMethod RMGetIndicesNonAllocImpl_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_MGetIndicesNonAllocImpl_Int32Array_Int32_Boolean == null)
				{
					r_MGetIndicesNonAllocImpl_Int32Array_Int32_Boolean = new(this, "GetIndicesNonAllocImpl", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndicesNonAllocImpl_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndicesNonAllocImpl16(UInt16[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean;
		public virtual RMethod RMGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean
		{
			get
			{
				if(r_MGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean == null)
				{
					r_MGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean = new(this, "GetIndicesNonAllocImpl16", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MPrintErrorCantAccessChannel_VertexAttribute;
		public virtual RMethod RMPrintErrorCantAccessChannel_VertexAttribute
		{
			get
			{
				if(r_MPrintErrorCantAccessChannel_VertexAttribute == null)
				{
					r_MPrintErrorCantAccessChannel_VertexAttribute = new(this, "PrintErrorCantAccessChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MPrintErrorCantAccessChannel_VertexAttribute;
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
		/// Void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetArrayForChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetNativeArrayForChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_MGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RMGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_MGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_MGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32 = new(this, "GetAllocArrayFromChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
				}
				return r_MGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// Void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array)
		/// </summary>
		protected RMethod r_MGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array;
		public virtual RMethod RMGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array
		{
			get
			{
				if(r_MGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array == null)
				{
					r_MGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array = new(this, "GetArrayFromChannelImpl", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array));
				}
				return r_MGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array;
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
		/// IntPtr GetNativeVertexBufferPtr(Int32)
		/// </summary>
		protected RMethod r_MGetNativeVertexBufferPtr_Int32;
		public virtual RMethod RMGetNativeVertexBufferPtr_Int32
		{
			get
			{
				if(r_MGetNativeVertexBufferPtr_Int32 == null)
				{
					r_MGetNativeVertexBufferPtr_Int32 = new(this, "GetNativeVertexBufferPtr", 0, typeof(System.Int32));
				}
				return r_MGetNativeVertexBufferPtr_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetNativeIndexBufferPtr()
		/// </summary>
		protected RMethod r_MGetNativeIndexBufferPtr;
		public virtual RMethod RMGetNativeIndexBufferPtr
		{
			get
			{
				if(r_MGetNativeIndexBufferPtr == null)
				{
					r_MGetNativeIndexBufferPtr = new(this, "GetNativeIndexBufferPtr", 0);
				}
				return r_MGetNativeIndexBufferPtr;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetVertexBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MGetVertexBufferImpl_Int32;
		public virtual RMethod RMGetVertexBufferImpl_Int32
		{
			get
			{
				if(r_MGetVertexBufferImpl_Int32 == null)
				{
					r_MGetVertexBufferImpl_Int32 = new(this, "GetVertexBufferImpl", 0, typeof(System.Int32));
				}
				return r_MGetVertexBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetIndexBufferImpl()
		/// </summary>
		protected RMethod r_MGetIndexBufferImpl;
		public virtual RMethod RMGetIndexBufferImpl
		{
			get
			{
				if(r_MGetIndexBufferImpl == null)
				{
					r_MGetIndexBufferImpl = new(this, "GetIndexBufferImpl", 0);
				}
				return r_MGetIndexBufferImpl;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MGetBoneWeightBufferImpl_Int32;
		public virtual RMethod RMGetBoneWeightBufferImpl_Int32
		{
			get
			{
				if(r_MGetBoneWeightBufferImpl_Int32 == null)
				{
					r_MGetBoneWeightBufferImpl_Int32 = new(this, "GetBoneWeightBufferImpl", 0, typeof(System.Int32));
				}
				return r_MGetBoneWeightBufferImpl_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(Int32)
		/// </summary>
		protected RMethod r_MGetBlendShapeBufferImpl_Int32;
		public virtual RMethod RMGetBlendShapeBufferImpl_Int32
		{
			get
			{
				if(r_MGetBlendShapeBufferImpl_Int32 == null)
				{
					r_MGetBlendShapeBufferImpl_Int32 = new(this, "GetBlendShapeBufferImpl", 0, typeof(System.Int32));
				}
				return r_MGetBlendShapeBufferImpl_Int32;
			}
		}

		/// <summary>
		/// Void ClearBlendShapes()
		/// </summary>
		protected RMethod r_MClearBlendShapes;
		public virtual RMethod RMClearBlendShapes
		{
			get
			{
				if(r_MClearBlendShapes == null)
				{
					r_MClearBlendShapes = new(this, "ClearBlendShapes", 0);
				}
				return r_MClearBlendShapes;
			}
		}

		/// <summary>
		/// System.String GetBlendShapeName(Int32)
		/// </summary>
		protected RMethod r_MGetBlendShapeName_Int32;
		public virtual RMethod RMGetBlendShapeName_Int32
		{
			get
			{
				if(r_MGetBlendShapeName_Int32 == null)
				{
					r_MGetBlendShapeName_Int32 = new(this, "GetBlendShapeName", 0, typeof(System.Int32));
				}
				return r_MGetBlendShapeName_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBlendShapeIndex(System.String)
		/// </summary>
		protected RMethod r_MGetBlendShapeIndex_String;
		public virtual RMethod RMGetBlendShapeIndex_String
		{
			get
			{
				if(r_MGetBlendShapeIndex_String == null)
				{
					r_MGetBlendShapeIndex_String = new(this, "GetBlendShapeIndex", 0, typeof(System.String));
				}
				return r_MGetBlendShapeIndex_String;
			}
		}

		/// <summary>
		/// Int32 GetBlendShapeFrameCount(Int32)
		/// </summary>
		protected RMethod r_MGetBlendShapeFrameCount_Int32;
		public virtual RMethod RMGetBlendShapeFrameCount_Int32
		{
			get
			{
				if(r_MGetBlendShapeFrameCount_Int32 == null)
				{
					r_MGetBlendShapeFrameCount_Int32 = new(this, "GetBlendShapeFrameCount", 0, typeof(System.Int32));
				}
				return r_MGetBlendShapeFrameCount_Int32;
			}
		}

		/// <summary>
		/// Single GetBlendShapeFrameWeight(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetBlendShapeFrameWeight_Int32_Int32;
		public virtual RMethod RMGetBlendShapeFrameWeight_Int32_Int32
		{
			get
			{
				if(r_MGetBlendShapeFrameWeight_Int32_Int32 == null)
				{
					r_MGetBlendShapeFrameWeight_Int32_Int32 = new(this, "GetBlendShapeFrameWeight", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetBlendShapeFrameWeight_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetBlendShapeFrameVertices(Int32, Int32, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array;
		public virtual RMethod RMGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array
		{
			get
			{
				if(r_MGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array == null)
				{
					r_MGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array = new(this, "GetBlendShapeFrameVertices", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array;
			}
		}

		/// <summary>
		/// Void AddBlendShapeFrame(System.String, Single, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array;
		public virtual RMethod RMAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array
		{
			get
			{
				if(r_MAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array == null)
				{
					r_MAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array = new(this, "AddBlendShapeFrame", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array;
			}
		}

		/// <summary>
		/// UnityEngine.BlendShape GetBlendShapeOffsetInternal(Int32)
		/// </summary>
		protected RMethod r_MGetBlendShapeOffsetInternal_Int32;
		public virtual RMethod RMGetBlendShapeOffsetInternal_Int32
		{
			get
			{
				if(r_MGetBlendShapeOffsetInternal_Int32 == null)
				{
					r_MGetBlendShapeOffsetInternal_Int32 = new(this, "GetBlendShapeOffsetInternal", 0, typeof(System.Int32));
				}
				return r_MGetBlendShapeOffsetInternal_Int32;
			}
		}

		/// <summary>
		/// Boolean HasBoneWeights()
		/// </summary>
		protected RMethod r_MHasBoneWeights;
		public virtual RMethod RMHasBoneWeights
		{
			get
			{
				if(r_MHasBoneWeights == null)
				{
					r_MHasBoneWeights = new(this, "HasBoneWeights", 0);
				}
				return r_MHasBoneWeights;
			}
		}

		/// <summary>
		/// UnityEngine.BoneWeight[] GetBoneWeightsImpl()
		/// </summary>
		protected RMethod r_MGetBoneWeightsImpl;
		public virtual RMethod RMGetBoneWeightsImpl
		{
			get
			{
				if(r_MGetBoneWeightsImpl == null)
				{
					r_MGetBoneWeightsImpl = new(this, "GetBoneWeightsImpl", 0);
				}
				return r_MGetBoneWeightsImpl;
			}
		}

		/// <summary>
		/// Void SetBoneWeightsImpl(UnityEngine.BoneWeight[])
		/// </summary>
		protected RMethod r_MSetBoneWeightsImpl_BoneWeightArray;
		public virtual RMethod RMSetBoneWeightsImpl_BoneWeightArray
		{
			get
			{
				if(r_MSetBoneWeightsImpl_BoneWeightArray == null)
				{
					r_MSetBoneWeightsImpl_BoneWeightArray = new(this, "SetBoneWeightsImpl", 0, typeof(UnityEngine.BoneWeight).MakeArrayType());
				}
				return r_MSetBoneWeightsImpl_BoneWeightArray;
			}
		}

		/// <summary>
		/// Void SetBoneWeights(Unity.Collections.NativeArray`1[System.Byte], Unity.Collections.NativeArray`1[UnityEngine.BoneWeight1])
		/// </summary>
		protected RMethod r_MSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_;
		public virtual RMethod RMSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_
		{
			get
			{
				if(r_MSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_ == null)
				{
					r_MSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_ = new(this, "SetBoneWeights", 0,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(System.Byte)),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(typeof(UnityEngine.BoneWeight1)));
				}
				return r_MSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_;
			}
		}

		/// <summary>
		/// Void InternalSetBoneWeights(IntPtr, Int32, IntPtr, Int32)
		/// </summary>
		protected RMethod r_MInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32;
		public virtual RMethod RMInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32
		{
			get
			{
				if(r_MInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32 == null)
				{
					r_MInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32 = new(this, "InternalSetBoneWeights", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32));
				}
				return r_MInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.BoneWeight1] GetAllBoneWeights()
		/// </summary>
		protected RMethod r_MGetAllBoneWeights;
		public virtual RMethod RMGetAllBoneWeights
		{
			get
			{
				if(r_MGetAllBoneWeights == null)
				{
					r_MGetAllBoneWeights = new(this, "GetAllBoneWeights", 0);
				}
				return r_MGetAllBoneWeights;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[System.Byte] GetBonesPerVertex()
		/// </summary>
		protected RMethod r_MGetBonesPerVertex;
		public virtual RMethod RMGetBonesPerVertex
		{
			get
			{
				if(r_MGetBonesPerVertex == null)
				{
					r_MGetBonesPerVertex = new(this, "GetBonesPerVertex", 0);
				}
				return r_MGetBonesPerVertex;
			}
		}

		/// <summary>
		/// Int32 GetAllBoneWeightsArraySize()
		/// </summary>
		protected RMethod r_MGetAllBoneWeightsArraySize;
		public virtual RMethod RMGetAllBoneWeightsArraySize
		{
			get
			{
				if(r_MGetAllBoneWeightsArraySize == null)
				{
					r_MGetAllBoneWeightsArraySize = new(this, "GetAllBoneWeightsArraySize", 0);
				}
				return r_MGetAllBoneWeightsArraySize;
			}
		}

		/// <summary>
		/// Int32 GetBoneWeightBufferLayoutInternal()
		/// </summary>
		protected RMethod r_MGetBoneWeightBufferLayoutInternal;
		public virtual RMethod RMGetBoneWeightBufferLayoutInternal
		{
			get
			{
				if(r_MGetBoneWeightBufferLayoutInternal == null)
				{
					r_MGetBoneWeightBufferLayoutInternal = new(this, "GetBoneWeightBufferLayoutInternal", 0);
				}
				return r_MGetBoneWeightBufferLayoutInternal;
			}
		}

		/// <summary>
		/// IntPtr GetAllBoneWeightsArray()
		/// </summary>
		protected RMethod r_MGetAllBoneWeightsArray;
		public virtual RMethod RMGetAllBoneWeightsArray
		{
			get
			{
				if(r_MGetAllBoneWeightsArray == null)
				{
					r_MGetAllBoneWeightsArray = new(this, "GetAllBoneWeightsArray", 0);
				}
				return r_MGetAllBoneWeightsArray;
			}
		}

		/// <summary>
		/// IntPtr GetBonesPerVertexArray()
		/// </summary>
		protected RMethod r_MGetBonesPerVertexArray;
		public virtual RMethod RMGetBonesPerVertexArray
		{
			get
			{
				if(r_MGetBonesPerVertexArray == null)
				{
					r_MGetBonesPerVertexArray = new(this, "GetBonesPerVertexArray", 0);
				}
				return r_MGetBonesPerVertexArray;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.Matrix4x4] GetBindposes()
		/// </summary>
		protected RMethod r_MGetBindposes;
		public virtual RMethod RMGetBindposes
		{
			get
			{
				if(r_MGetBindposes == null)
				{
					r_MGetBindposes = new(this, "GetBindposes", 0);
				}
				return r_MGetBindposes;
			}
		}

		/// <summary>
		/// IntPtr GetBindposesArray()
		/// </summary>
		protected RMethod r_MGetBindposesArray;
		public virtual RMethod RMGetBindposesArray
		{
			get
			{
				if(r_MGetBindposesArray == null)
				{
					r_MGetBindposesArray = new(this, "GetBindposesArray", 0);
				}
				return r_MGetBindposesArray;
			}
		}

		/// <summary>
		/// Void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[])
		/// </summary>
		protected RMethod r_MGetBoneWeightsNonAllocImpl_BoneWeightArray;
		public virtual RMethod RMGetBoneWeightsNonAllocImpl_BoneWeightArray
		{
			get
			{
				if(r_MGetBoneWeightsNonAllocImpl_BoneWeightArray == null)
				{
					r_MGetBoneWeightsNonAllocImpl_BoneWeightArray = new(this, "GetBoneWeightsNonAllocImpl", 0, typeof(UnityEngine.BoneWeight).MakeArrayType());
				}
				return r_MGetBoneWeightsNonAllocImpl_BoneWeightArray;
			}
		}

		/// <summary>
		/// Void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MGetBindposesNonAllocImpl_Matrix4x4Array;
		public virtual RMethod RMGetBindposesNonAllocImpl_Matrix4x4Array
		{
			get
			{
				if(r_MGetBindposesNonAllocImpl_Matrix4x4Array == null)
				{
					r_MGetBindposesNonAllocImpl_Matrix4x4Array = new(this, "GetBindposesNonAllocImpl", 0, typeof(UnityEngine.Matrix4x4).MakeArrayType());
				}
				return r_MGetBindposesNonAllocImpl_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetReadOnlySafetyHandle(SafetyHandleIndex)
		/// </summary>
		protected RMethod r_MGetReadOnlySafetyHandle_SafetyHandleIndex;
		public virtual RMethod RMGetReadOnlySafetyHandle_SafetyHandleIndex
		{
			get
			{
				if(r_MGetReadOnlySafetyHandle_SafetyHandleIndex == null)
				{
					r_MGetReadOnlySafetyHandle_SafetyHandleIndex = new(this, "GetReadOnlySafetyHandle", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+SafetyHandleIndex"));
				}
				return r_MGetReadOnlySafetyHandle_SafetyHandleIndex;
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
		/// Void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetAllSubMeshesAtOnceFromArray", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetAllSubMeshesAtOnceFromNativeArray(IntPtr, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags = new(this, "SetAllSubMeshesAtOnceFromNativeArray", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ClearImpl(Boolean)
		/// </summary>
		protected RMethod r_MClearImpl_Boolean;
		public virtual RMethod RMClearImpl_Boolean
		{
			get
			{
				if(r_MClearImpl_Boolean == null)
				{
					r_MClearImpl_Boolean = new(this, "ClearImpl", 0, typeof(System.Boolean));
				}
				return r_MClearImpl_Boolean;
			}
		}

		/// <summary>
		/// Void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MRecalculateBoundsImpl_MeshUpdateFlags;
		public virtual RMethod RMRecalculateBoundsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_MRecalculateBoundsImpl_MeshUpdateFlags == null)
				{
					r_MRecalculateBoundsImpl_MeshUpdateFlags = new(this, "RecalculateBoundsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MRecalculateBoundsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MRecalculateNormalsImpl_MeshUpdateFlags;
		public virtual RMethod RMRecalculateNormalsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_MRecalculateNormalsImpl_MeshUpdateFlags == null)
				{
					r_MRecalculateNormalsImpl_MeshUpdateFlags = new(this, "RecalculateNormalsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MRecalculateNormalsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MRecalculateTangentsImpl_MeshUpdateFlags;
		public virtual RMethod RMRecalculateTangentsImpl_MeshUpdateFlags
		{
			get
			{
				if(r_MRecalculateTangentsImpl_MeshUpdateFlags == null)
				{
					r_MRecalculateTangentsImpl_MeshUpdateFlags = new(this, "RecalculateTangentsImpl", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MRecalculateTangentsImpl_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void MarkDynamicImpl()
		/// </summary>
		protected RMethod r_MMarkDynamicImpl;
		public virtual RMethod RMMarkDynamicImpl
		{
			get
			{
				if(r_MMarkDynamicImpl == null)
				{
					r_MMarkDynamicImpl = new(this, "MarkDynamicImpl", 0);
				}
				return r_MMarkDynamicImpl;
			}
		}

		/// <summary>
		/// Void MarkModified()
		/// </summary>
		protected RMethod r_MMarkModified;
		public virtual RMethod RMMarkModified
		{
			get
			{
				if(r_MMarkModified == null)
				{
					r_MMarkModified = new(this, "MarkModified", 0);
				}
				return r_MMarkModified;
			}
		}

		/// <summary>
		/// Void UploadMeshDataImpl(Boolean)
		/// </summary>
		protected RMethod r_MUploadMeshDataImpl_Boolean;
		public virtual RMethod RMUploadMeshDataImpl_Boolean
		{
			get
			{
				if(r_MUploadMeshDataImpl_Boolean == null)
				{
					r_MUploadMeshDataImpl_Boolean = new(this, "UploadMeshDataImpl", 0, typeof(System.Boolean));
				}
				return r_MUploadMeshDataImpl_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology GetTopologyImpl(Int32)
		/// </summary>
		protected RMethod r_MGetTopologyImpl_Int32;
		public virtual RMethod RMGetTopologyImpl_Int32
		{
			get
			{
				if(r_MGetTopologyImpl_Int32 == null)
				{
					r_MGetTopologyImpl_Int32 = new(this, "GetTopologyImpl", 0, typeof(System.Int32));
				}
				return r_MGetTopologyImpl_Int32;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetricImpl(Int32, Single)
		/// </summary>
		protected RMethod r_MRecalculateUVDistributionMetricImpl_Int32_Single;
		public virtual RMethod RMRecalculateUVDistributionMetricImpl_Int32_Single
		{
			get
			{
				if(r_MRecalculateUVDistributionMetricImpl_Int32_Single == null)
				{
					r_MRecalculateUVDistributionMetricImpl_Int32_Single = new(this, "RecalculateUVDistributionMetricImpl", 0, typeof(System.Int32), typeof(System.Single));
				}
				return r_MRecalculateUVDistributionMetricImpl_Int32_Single;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetricsImpl(Single)
		/// </summary>
		protected RMethod r_MRecalculateUVDistributionMetricsImpl_Single;
		public virtual RMethod RMRecalculateUVDistributionMetricsImpl_Single
		{
			get
			{
				if(r_MRecalculateUVDistributionMetricsImpl_Single == null)
				{
					r_MRecalculateUVDistributionMetricsImpl_Single = new(this, "RecalculateUVDistributionMetricsImpl", 0, typeof(System.Single));
				}
				return r_MRecalculateUVDistributionMetricsImpl_Single;
			}
		}

		/// <summary>
		/// Single GetUVDistributionMetric(Int32)
		/// </summary>
		protected RMethod r_MGetUVDistributionMetric_Int32;
		public virtual RMethod RMGetUVDistributionMetric_Int32
		{
			get
			{
				if(r_MGetUVDistributionMetric_Int32 == null)
				{
					r_MGetUVDistributionMetric_Int32 = new(this, "GetUVDistributionMetric", 0, typeof(System.Int32));
				}
				return r_MGetUVDistributionMetric_Int32;
			}
		}

		/// <summary>
		/// Void CombineMeshesImpl(UnityEngine.CombineInstance[], Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean;
		public virtual RMethod RMCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean == null)
				{
					r_MCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean = new(this, "CombineMeshesImpl", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OptimizeImpl()
		/// </summary>
		protected RMethod r_MOptimizeImpl;
		public virtual RMethod RMOptimizeImpl
		{
			get
			{
				if(r_MOptimizeImpl == null)
				{
					r_MOptimizeImpl = new(this, "OptimizeImpl", 0);
				}
				return r_MOptimizeImpl;
			}
		}

		/// <summary>
		/// Void OptimizeIndexBuffersImpl()
		/// </summary>
		protected RMethod r_MOptimizeIndexBuffersImpl;
		public virtual RMethod RMOptimizeIndexBuffersImpl
		{
			get
			{
				if(r_MOptimizeIndexBuffersImpl == null)
				{
					r_MOptimizeIndexBuffersImpl = new(this, "OptimizeIndexBuffersImpl", 0);
				}
				return r_MOptimizeIndexBuffersImpl;
			}
		}

		/// <summary>
		/// Void OptimizeReorderVertexBufferImpl()
		/// </summary>
		protected RMethod r_MOptimizeReorderVertexBufferImpl;
		public virtual RMethod RMOptimizeReorderVertexBufferImpl
		{
			get
			{
				if(r_MOptimizeReorderVertexBufferImpl == null)
				{
					r_MOptimizeReorderVertexBufferImpl = new(this, "OptimizeReorderVertexBufferImpl", 0);
				}
				return r_MOptimizeReorderVertexBufferImpl;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute GetUVChannel(Int32)
		/// </summary>
		protected static RMethod r_MGetUVChannel_Int32;
		public static RMethod RMGetUVChannel_Int32
		{
			get
			{
				if(r_MGetUVChannel_Int32 == null)
				{
					r_MGetUVChannel_Int32 = new(Type, "GetUVChannel", 0, typeof(System.Int32));
				}
				return r_MGetUVChannel_Int32;
			}
		}

		/// <summary>
		/// Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected static RMethod r_MDefaultDimensionForChannel_VertexAttribute;
		public static RMethod RMDefaultDimensionForChannel_VertexAttribute
		{
			get
			{
				if(r_MDefaultDimensionForChannel_VertexAttribute == null)
				{
					r_MDefaultDimensionForChannel_VertexAttribute = new(Type, "DefaultDimensionForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MDefaultDimensionForChannel_VertexAttribute;
			}
		}

		/// <summary>
		/// T[] GetAllocArrayFromChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32)
		/// </summary>
		protected RMethod r_MGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32;
		public virtual RMethod RMGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32
		{
			get
			{
				if(r_MGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32 == null)
				{
					r_MGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32 = new(this, "GetAllocArrayFromChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32));
				}
				return r_MGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32;
			}
		}

		/// <summary>
		/// T[] GetAllocArrayFromChannel[T](UnityEngine.Rendering.VertexAttribute)
		/// </summary>
		protected RMethod r_MGetAllocArrayFromChannel_GT_VertexAttribute;
		public virtual RMethod RMGetAllocArrayFromChannel_GT_VertexAttribute
		{
			get
			{
				if(r_MGetAllocArrayFromChannel_GT_VertexAttribute == null)
				{
					r_MGetAllocArrayFromChannel_GT_VertexAttribute = new(this, "GetAllocArrayFromChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute));
				}
				return r_MGetAllocArrayFromChannel_GT_VertexAttribute;
			}
		}

		/// <summary>
		/// Void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Array, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetSizedArrayForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, IntPtr, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetSizedNativeArrayForChannel", 0, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetArrayForChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, T[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags;
		public virtual RMethod RMSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags
		{
			get
			{
				if(r_MSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags == null)
				{
					r_MSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags = new(this, "SetArrayForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetArrayForChannel[T](UnityEngine.Rendering.VertexAttribute, T[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags;
		public virtual RMethod RMSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags
		{
			get
			{
				if(r_MSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags == null)
				{
					r_MSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags = new(this, "SetArrayForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetListForChannel[T](UnityEngine.Rendering.VertexAttribute, UnityEngine.Rendering.VertexAttributeFormat, Int32, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetListForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute), typeof(UnityEngine.Rendering.VertexAttributeFormat), typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetListForChannel[T](UnityEngine.Rendering.VertexAttribute, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetListForChannel", 1, typeof(UnityEngine.Rendering.VertexAttribute),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetListForChannel[T](System.Collections.Generic.List`1[T], Int32, UnityEngine.Rendering.VertexAttribute, Int32)
		/// </summary>
		protected RMethod r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32;
		public virtual RMethod RMGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32
		{
			get
			{
				if(r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32 == null)
				{
					r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32 = new(this, "GetListForChannel", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Int32));
				}
				return r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32;
			}
		}

		/// <summary>
		/// Void GetListForChannel[T](System.Collections.Generic.List`1[T], Int32, UnityEngine.Rendering.VertexAttribute, Int32, UnityEngine.Rendering.VertexAttributeFormat)
		/// </summary>
		protected RMethod r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat;
		public virtual RMethod RMGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat
		{
			get
			{
				if(r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat == null)
				{
					r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat = new(this, "GetListForChannel", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttribute), typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeFormat));
				}
				return r_MGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat;
			}
		}

		/// <summary>
		/// Void GetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MGetVertices_List_d_Vector3_p_;
		public virtual RMethod RMGetVertices_List_d_Vector3_p_
		{
			get
			{
				if(r_MGetVertices_List_d_Vector3_p_ == null)
				{
					r_MGetVertices_List_d_Vector3_p_ = new(this, "GetVertices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MGetVertices_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MSetVertices_List_d_Vector3_p_;
		public virtual RMethod RMSetVertices_List_d_Vector3_p_
		{
			get
			{
				if(r_MSetVertices_List_d_Vector3_p_ == null)
				{
					r_MSetVertices_List_d_Vector3_p_ = new(this, "SetVertices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MSetVertices_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetVertices_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RMSetVertices_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_MSetVertices_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_MSetVertices_List_d_Vector3_p__Int32_Int32 = new(this, "SetVertices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetVertices_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MSetVertices_Vector3Array;
		public virtual RMethod RMSetVertices_Vector3Array
		{
			get
			{
				if(r_MSetVertices_Vector3Array == null)
				{
					r_MSetVertices_Vector3Array = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MSetVertices_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetVertices_Vector3Array_Int32_Int32;
		public virtual RMethod RMSetVertices_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_MSetVertices_Vector3Array_Int32_Int32 == null)
				{
					r_MSetVertices_Vector3Array_Int32_Int32 = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetVertices_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices(UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetVertices_GT_NativeArray_d_T_p_;
		public virtual RMethod RMSetVertices_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetVertices_GT_NativeArray_d_T_p_ == null)
				{
					r_MSetVertices_GT_NativeArray_d_T_p_ = new(this, "SetVertices", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetVertices_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMSetVertices_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetVertices", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVertices[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetVertices", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MGetNormals_List_d_Vector3_p_;
		public virtual RMethod RMGetNormals_List_d_Vector3_p_
		{
			get
			{
				if(r_MGetNormals_List_d_Vector3_p_ == null)
				{
					r_MGetNormals_List_d_Vector3_p_ = new(this, "GetNormals", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MGetNormals_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MSetNormals_List_d_Vector3_p_;
		public virtual RMethod RMSetNormals_List_d_Vector3_p_
		{
			get
			{
				if(r_MSetNormals_List_d_Vector3_p_ == null)
				{
					r_MSetNormals_List_d_Vector3_p_ = new(this, "SetNormals", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MSetNormals_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetNormals_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RMSetNormals_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_MSetNormals_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_MSetNormals_List_d_Vector3_p__Int32_Int32 = new(this, "SetNormals", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetNormals_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals(System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MSetNormals_Vector3Array;
		public virtual RMethod RMSetNormals_Vector3Array
		{
			get
			{
				if(r_MSetNormals_Vector3Array == null)
				{
					r_MSetNormals_Vector3Array = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MSetNormals_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetNormals_Vector3Array_Int32_Int32;
		public virtual RMethod RMSetNormals_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_MSetNormals_Vector3Array_Int32_Int32 == null)
				{
					r_MSetNormals_Vector3Array_Int32_Int32 = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetNormals_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals(UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetNormals_GT_NativeArray_d_T_p_;
		public virtual RMethod RMSetNormals_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetNormals_GT_NativeArray_d_T_p_ == null)
				{
					r_MSetNormals_GT_NativeArray_d_T_p_ = new(this, "SetNormals", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetNormals_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMSetNormals_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetNormals", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetNormals[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetNormals", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MGetTangents_List_d_Vector4_p_;
		public virtual RMethod RMGetTangents_List_d_Vector4_p_
		{
			get
			{
				if(r_MGetTangents_List_d_Vector4_p_ == null)
				{
					r_MGetTangents_List_d_Vector4_p_ = new(this, "GetTangents", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MGetTangents_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MSetTangents_List_d_Vector4_p_;
		public virtual RMethod RMSetTangents_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetTangents_List_d_Vector4_p_ == null)
				{
					r_MSetTangents_List_d_Vector4_p_ = new(this, "SetTangents", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MSetTangents_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetTangents_List_d_Vector4_p__Int32_Int32;
		public virtual RMethod RMSetTangents_List_d_Vector4_p__Int32_Int32
		{
			get
			{
				if(r_MSetTangents_List_d_Vector4_p__Int32_Int32 == null)
				{
					r_MSetTangents_List_d_Vector4_p__Int32_Int32 = new(this, "SetTangents", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetTangents_List_d_Vector4_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents(System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetTangents_Vector4Array;
		public virtual RMethod RMSetTangents_Vector4Array
		{
			get
			{
				if(r_MSetTangents_Vector4Array == null)
				{
					r_MSetTangents_Vector4Array = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetTangents_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetTangents_Vector4Array_Int32_Int32;
		public virtual RMethod RMSetTangents_Vector4Array_Int32_Int32
		{
			get
			{
				if(r_MSetTangents_Vector4Array_Int32_Int32 == null)
				{
					r_MSetTangents_Vector4Array_Int32_Int32 = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetTangents_Vector4Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents(UnityEngine.Vector4[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 0, typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetTangents_GT_NativeArray_d_T_p_;
		public virtual RMethod RMSetTangents_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetTangents_GT_NativeArray_d_T_p_ == null)
				{
					r_MSetTangents_GT_NativeArray_d_T_p_ = new(this, "SetTangents", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetTangents_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMSetTangents_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetTangents", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTangents[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetTangents", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetColors(System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MGetColors_List_d_Color_p_;
		public virtual RMethod RMGetColors_List_d_Color_p_
		{
			get
			{
				if(r_MGetColors_List_d_Color_p_ == null)
				{
					r_MGetColors_List_d_Color_p_ = new(this, "GetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MGetColors_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color])
		/// </summary>
		protected RMethod r_MSetColors_List_d_Color_p_;
		public virtual RMethod RMSetColors_List_d_Color_p_
		{
			get
			{
				if(r_MSetColors_List_d_Color_p_ == null)
				{
					r_MSetColors_List_d_Color_p_ = new(this, "SetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)));
				}
				return r_MSetColors_List_d_Color_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetColors_List_d_Color_p__Int32_Int32;
		public virtual RMethod RMSetColors_List_d_Color_p__Int32_Int32
		{
			get
			{
				if(r_MSetColors_List_d_Color_p__Int32_Int32 == null)
				{
					r_MSetColors_List_d_Color_p__Int32_Int32 = new(this, "SetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetColors_List_d_Color_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MSetColors_ColorArray;
		public virtual RMethod RMSetColors_ColorArray
		{
			get
			{
				if(r_MSetColors_ColorArray == null)
				{
					r_MSetColors_ColorArray = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType());
				}
				return r_MSetColors_ColorArray;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetColors_ColorArray_Int32_Int32;
		public virtual RMethod RMSetColors_ColorArray_Int32_Int32
		{
			get
			{
				if(r_MSetColors_ColorArray_Int32_Int32 == null)
				{
					r_MSetColors_ColorArray_Int32_Int32 = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetColors_ColorArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetColors_ColorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetColors_ColorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetColors_ColorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetColors_ColorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetColors_ColorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetColors(System.Collections.Generic.List`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_MGetColors_List_d_Color32_p_;
		public virtual RMethod RMGetColors_List_d_Color32_p_
		{
			get
			{
				if(r_MGetColors_List_d_Color32_p_ == null)
				{
					r_MGetColors_List_d_Color32_p_ = new(this, "GetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color32)));
				}
				return r_MGetColors_List_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32])
		/// </summary>
		protected RMethod r_MSetColors_List_d_Color32_p_;
		public virtual RMethod RMSetColors_List_d_Color32_p_
		{
			get
			{
				if(r_MSetColors_List_d_Color32_p_ == null)
				{
					r_MSetColors_List_d_Color32_p_ = new(this, "SetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color32)));
				}
				return r_MSetColors_List_d_Color32_p_;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetColors_List_d_Color32_p__Int32_Int32;
		public virtual RMethod RMSetColors_List_d_Color32_p__Int32_Int32
		{
			get
			{
				if(r_MSetColors_List_d_Color32_p__Int32_Int32 == null)
				{
					r_MSetColors_List_d_Color32_p__Int32_Int32 = new(this, "SetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color32)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetColors_List_d_Color32_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(System.Collections.Generic.List`1[UnityEngine.Color32], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Color32)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_MSetColors_Color32Array;
		public virtual RMethod RMSetColors_Color32Array
		{
			get
			{
				if(r_MSetColors_Color32Array == null)
				{
					r_MSetColors_Color32Array = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType());
				}
				return r_MSetColors_Color32Array;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetColors_Color32Array_Int32_Int32;
		public virtual RMethod RMSetColors_Color32Array_Int32_Int32
		{
			get
			{
				if(r_MSetColors_Color32Array_Int32_Int32 == null)
				{
					r_MSetColors_Color32Array_Int32_Int32 = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetColors_Color32Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors(UnityEngine.Color32[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetColors_Color32Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetColors_Color32Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetColors_Color32Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetColors_Color32Array_Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetColors_Color32Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetColors_GT_NativeArray_d_T_p_;
		public virtual RMethod RMSetColors_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetColors_GT_NativeArray_d_T_p_ == null)
				{
					r_MSetColors_GT_NativeArray_d_T_p_ = new(this, "SetColors", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetColors_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMSetColors_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetColors", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetColors[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetColors", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUvsImpl[T](Int32, Int32, System.Collections.Generic.List`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUvsImpl", 1, typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector2_p_;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector2_p_ == null)
				{
					r_MSetUVs_Int32_List_d_Vector2_p_ = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector2)));
				}
				return r_MSetUVs_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector3_p_;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector3_p_
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector3_p_ == null)
				{
					r_MSetUVs_Int32_List_d_Vector3_p_ = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MSetUVs_Int32_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector4_p_;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector4_p_ == null)
				{
					r_MSetUVs_Int32_List_d_Vector4_p_ = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MSetUVs_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector2_p__Int32_Int32
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32 == null)
				{
					r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector2)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector2)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector3_p__Int32_Int32
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32 == null)
				{
					r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector4_p__Int32_Int32
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32 == null)
				{
					r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUvsImpl(Int32, Int32, System.Array, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUvsImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[])
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector2Array;
		public virtual RMethod RMSetUVs_Int32_Vector2Array
		{
			get
			{
				if(r_MSetUVs_Int32_Vector2Array == null)
				{
					r_MSetUVs_Int32_Vector2Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType());
				}
				return r_MSetUVs_Int32_Vector2Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector3Array;
		public virtual RMethod RMSetUVs_Int32_Vector3Array
		{
			get
			{
				if(r_MSetUVs_Int32_Vector3Array == null)
				{
					r_MSetUVs_Int32_Vector3Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType());
				}
				return r_MSetUVs_Int32_Vector3Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector4Array;
		public virtual RMethod RMSetUVs_Int32_Vector4Array
		{
			get
			{
				if(r_MSetUVs_Int32_Vector4Array == null)
				{
					r_MSetUVs_Int32_Vector4Array = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
				}
				return r_MSetUVs_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector2Array_Int32_Int32;
		public virtual RMethod RMSetUVs_Int32_Vector2Array_Int32_Int32
		{
			get
			{
				if(r_MSetUVs_Int32_Vector2Array_Int32_Int32 == null)
				{
					r_MSetUVs_Int32_Vector2Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_Int32_Vector2Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector2[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector3Array_Int32_Int32;
		public virtual RMethod RMSetUVs_Int32_Vector3Array_Int32_Int32
		{
			get
			{
				if(r_MSetUVs_Int32_Vector3Array_Int32_Int32 == null)
				{
					r_MSetUVs_Int32_Vector3Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_Int32_Vector3Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector3[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector4Array_Int32_Int32;
		public virtual RMethod RMSetUVs_Int32_Vector4Array_Int32_Int32
		{
			get
			{
				if(r_MSetUVs_Int32_Vector4Array_Int32_Int32 == null)
				{
					r_MSetUVs_Int32_Vector4Array_Int32_Int32 = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_Int32_Vector4Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs(Int32, UnityEngine.Vector4[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MSetUVs_GT_Int32_NativeArray_d_T_p_;
		public virtual RMethod RMSetUVs_GT_Int32_NativeArray_d_T_p_
		{
			get
			{
				if(r_MSetUVs_GT_Int32_NativeArray_d_T_p_ == null)
				{
					r_MSetUVs_GT_Int32_NativeArray_d_T_p_ = new(this, "SetUVs", 1, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MSetUVs_GT_Int32_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32 = new(this, "SetUVs", 1, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetUVs[T](Int32, Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetUVs", 1, typeof(System.Int32),  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetUVsImpl[T](Int32, System.Collections.Generic.List`1[T], Int32)
		/// </summary>
		protected RMethod r_MGetUVsImpl_GT_Int32_List_d_T_p__Int32;
		public virtual RMethod RMGetUVsImpl_GT_Int32_List_d_T_p__Int32
		{
			get
			{
				if(r_MGetUVsImpl_GT_Int32_List_d_T_p__Int32 == null)
				{
					r_MGetUVsImpl_GT_Int32_List_d_T_p__Int32 = new(this, "GetUVsImpl", 1, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32));
				}
				return r_MGetUVsImpl_GT_Int32_List_d_T_p__Int32;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MGetUVs_Int32_List_d_Vector2_p_;
		public virtual RMethod RMGetUVs_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_MGetUVs_Int32_List_d_Vector2_p_ == null)
				{
					r_MGetUVs_Int32_List_d_Vector2_p_ = new(this, "GetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector2)));
				}
				return r_MGetUVs_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MGetUVs_Int32_List_d_Vector3_p_;
		public virtual RMethod RMGetUVs_Int32_List_d_Vector3_p_
		{
			get
			{
				if(r_MGetUVs_Int32_List_d_Vector3_p_ == null)
				{
					r_MGetUVs_Int32_List_d_Vector3_p_ = new(this, "GetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector3)));
				}
				return r_MGetUVs_Int32_List_d_Vector3_p_;
			}
		}

		/// <summary>
		/// Void GetUVs(Int32, System.Collections.Generic.List`1[UnityEngine.Vector4])
		/// </summary>
		protected RMethod r_MGetUVs_Int32_List_d_Vector4_p_;
		public virtual RMethod RMGetUVs_Int32_List_d_Vector4_p_
		{
			get
			{
				if(r_MGetUVs_Int32_List_d_Vector4_p_ == null)
				{
					r_MGetUVs_Int32_List_d_Vector4_p_ = new(this, "GetUVs", 0, typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Vector4)));
				}
				return r_MGetUVs_Int32_List_d_Vector4_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes()
		/// </summary>
		protected RMethod r_MGetVertexAttributes;
		public virtual RMethod RMGetVertexAttributes
		{
			get
			{
				if(r_MGetVertexAttributes == null)
				{
					r_MGetVertexAttributes = new(this, "GetVertexAttributes", 0);
				}
				return r_MGetVertexAttributes;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[])
		/// </summary>
		protected RMethod r_MGetVertexAttributes_VertexAttributeDescriptorArray;
		public virtual RMethod RMGetVertexAttributes_VertexAttributeDescriptorArray
		{
			get
			{
				if(r_MGetVertexAttributes_VertexAttributeDescriptorArray == null)
				{
					r_MGetVertexAttributes_VertexAttributeDescriptorArray = new(this, "GetVertexAttributes", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeArrayType());
				}
				return r_MGetVertexAttributes_VertexAttributeDescriptorArray;
			}
		}

		/// <summary>
		/// Int32 GetVertexAttributes(System.Collections.Generic.List`1[UnityEngine.Rendering.VertexAttributeDescriptor])
		/// </summary>
		protected RMethod r_MGetVertexAttributes_List_d_VertexAttributeDescriptor_p_;
		public virtual RMethod RMGetVertexAttributes_List_d_VertexAttributeDescriptor_p_
		{
			get
			{
				if(r_MGetVertexAttributes_List_d_VertexAttributeDescriptor_p_ == null)
				{
					r_MGetVertexAttributes_List_d_VertexAttributeDescriptor_p_ = new(this, "GetVertexAttributes", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Rendering.VertexAttributeDescriptor)));
				}
				return r_MGetVertexAttributes_List_d_VertexAttributeDescriptor_p_;
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
		/// Void SetVertexBufferData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](T[], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetVertexBufferData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetVertexBufferData", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh)
		/// </summary>
		protected static RMethod r_MAcquireReadOnlyMeshData_Mesh;
		public static RMethod RMAcquireReadOnlyMeshData_Mesh
		{
			get
			{
				if(r_MAcquireReadOnlyMeshData_Mesh == null)
				{
					r_MAcquireReadOnlyMeshData_Mesh = new(Type, "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh));
				}
				return r_MAcquireReadOnlyMeshData_Mesh;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[])
		/// </summary>
		protected static RMethod r_MAcquireReadOnlyMeshData_MeshArray;
		public static RMethod RMAcquireReadOnlyMeshData_MeshArray
		{
			get
			{
				if(r_MAcquireReadOnlyMeshData_MeshArray == null)
				{
					r_MAcquireReadOnlyMeshData_MeshArray = new(Type, "AcquireReadOnlyMeshData", 0, typeof(UnityEngine.Mesh).MakeArrayType());
				}
				return r_MAcquireReadOnlyMeshData_MeshArray;
			}
		}

		/// <summary>
		/// MeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List`1[UnityEngine.Mesh])
		/// </summary>
		protected static RMethod r_MAcquireReadOnlyMeshData_List_d_Mesh_p_;
		public static RMethod RMAcquireReadOnlyMeshData_List_d_Mesh_p_
		{
			get
			{
				if(r_MAcquireReadOnlyMeshData_List_d_Mesh_p_ == null)
				{
					r_MAcquireReadOnlyMeshData_List_d_Mesh_p_ = new(Type, "AcquireReadOnlyMeshData", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Mesh)));
				}
				return r_MAcquireReadOnlyMeshData_List_d_Mesh_p_;
			}
		}

		/// <summary>
		/// MeshDataArray AllocateWritableMeshData(Int32)
		/// </summary>
		protected static RMethod r_MAllocateWritableMeshData_Int32;
		public static RMethod RMAllocateWritableMeshData_Int32
		{
			get
			{
				if(r_MAllocateWritableMeshData_Int32 == null)
				{
					r_MAllocateWritableMeshData_Int32 = new(Type, "AllocateWritableMeshData", 0, typeof(System.Int32));
				}
				return r_MAllocateWritableMeshData_Int32;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, UnityEngine.Mesh, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags;
		public static RMethod RMApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags
		{
			get
			{
				if(r_MApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags == null)
				{
					r_MApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags = new(Type, "ApplyAndDisposeWritableMeshData", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(UnityEngine.Mesh), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, UnityEngine.Mesh[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags;
		public static RMethod RMApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags
		{
			get
			{
				if(r_MApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags == null)
				{
					r_MApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags = new(Type, "ApplyAndDisposeWritableMeshData", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray"), typeof(UnityEngine.Mesh).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void ApplyAndDisposeWritableMeshData(MeshDataArray, System.Collections.Generic.List`1[UnityEngine.Mesh], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected static RMethod r_MApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags;
		public static RMethod RMApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags
		{
			get
			{
				if(r_MApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags == null)
				{
					r_MApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags = new(Type, "ApplyAndDisposeWritableMeshData", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+MeshDataArray"),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Mesh)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetVertexBuffer(Int32)
		/// </summary>
		protected RMethod r_MGetVertexBuffer_Int32;
		public virtual RMethod RMGetVertexBuffer_Int32
		{
			get
			{
				if(r_MGetVertexBuffer_Int32 == null)
				{
					r_MGetVertexBuffer_Int32 = new(this, "GetVertexBuffer", 0, typeof(System.Int32));
				}
				return r_MGetVertexBuffer_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetIndexBuffer()
		/// </summary>
		protected RMethod r_MGetIndexBuffer;
		public virtual RMethod RMGetIndexBuffer
		{
			get
			{
				if(r_MGetIndexBuffer == null)
				{
					r_MGetIndexBuffer = new(this, "GetIndexBuffer", 0);
				}
				return r_MGetIndexBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights)
		/// </summary>
		protected RMethod r_MGetBoneWeightBuffer_SkinWeights;
		public virtual RMethod RMGetBoneWeightBuffer_SkinWeights
		{
			get
			{
				if(r_MGetBoneWeightBuffer_SkinWeights == null)
				{
					r_MGetBoneWeightBuffer_SkinWeights = new(this, "GetBoneWeightBuffer", 0, typeof(UnityEngine.SkinWeights));
				}
				return r_MGetBoneWeightBuffer_SkinWeights;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout)
		/// </summary>
		protected RMethod r_MGetBlendShapeBuffer_BlendShapeBufferLayout;
		public virtual RMethod RMGetBlendShapeBuffer_BlendShapeBufferLayout
		{
			get
			{
				if(r_MGetBlendShapeBuffer_BlendShapeBufferLayout == null)
				{
					r_MGetBlendShapeBuffer_BlendShapeBufferLayout = new(this, "GetBlendShapeBuffer", 0, typeof(UnityEngine.Rendering.BlendShapeBufferLayout));
				}
				return r_MGetBlendShapeBuffer_BlendShapeBufferLayout;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer GetBlendShapeBuffer()
		/// </summary>
		protected RMethod r_MGetBlendShapeBuffer;
		public virtual RMethod RMGetBlendShapeBuffer
		{
			get
			{
				if(r_MGetBlendShapeBuffer == null)
				{
					r_MGetBlendShapeBuffer = new(this, "GetBlendShapeBuffer", 0);
				}
				return r_MGetBlendShapeBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(Int32)
		/// </summary>
		protected RMethod r_MGetBlendShapeBufferRange_Int32;
		public virtual RMethod RMGetBlendShapeBufferRange_Int32
		{
			get
			{
				if(r_MGetBlendShapeBufferRange_Int32 == null)
				{
					r_MGetBlendShapeBufferRange_Int32 = new(this, "GetBlendShapeBufferRange", 0, typeof(System.Int32));
				}
				return r_MGetBlendShapeBufferRange_Int32;
			}
		}

		/// <summary>
		/// Void PrintErrorCantAccessIndices()
		/// </summary>
		protected RMethod r_MPrintErrorCantAccessIndices;
		public virtual RMethod RMPrintErrorCantAccessIndices
		{
			get
			{
				if(r_MPrintErrorCantAccessIndices == null)
				{
					r_MPrintErrorCantAccessIndices = new(this, "PrintErrorCantAccessIndices", 0);
				}
				return r_MPrintErrorCantAccessIndices;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmesh(Int32, Boolean)
		/// </summary>
		protected RMethod r_MCheckCanAccessSubmesh_Int32_Boolean;
		public virtual RMethod RMCheckCanAccessSubmesh_Int32_Boolean
		{
			get
			{
				if(r_MCheckCanAccessSubmesh_Int32_Boolean == null)
				{
					r_MCheckCanAccessSubmesh_Int32_Boolean = new(this, "CheckCanAccessSubmesh", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MCheckCanAccessSubmesh_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmeshTriangles(Int32)
		/// </summary>
		protected RMethod r_MCheckCanAccessSubmeshTriangles_Int32;
		public virtual RMethod RMCheckCanAccessSubmeshTriangles_Int32
		{
			get
			{
				if(r_MCheckCanAccessSubmeshTriangles_Int32 == null)
				{
					r_MCheckCanAccessSubmeshTriangles_Int32 = new(this, "CheckCanAccessSubmeshTriangles", 0, typeof(System.Int32));
				}
				return r_MCheckCanAccessSubmeshTriangles_Int32;
			}
		}

		/// <summary>
		/// Boolean CheckCanAccessSubmeshIndices(Int32)
		/// </summary>
		protected RMethod r_MCheckCanAccessSubmeshIndices_Int32;
		public virtual RMethod RMCheckCanAccessSubmeshIndices_Int32
		{
			get
			{
				if(r_MCheckCanAccessSubmeshIndices_Int32 == null)
				{
					r_MCheckCanAccessSubmeshIndices_Int32 = new(this, "CheckCanAccessSubmeshIndices", 0, typeof(System.Int32));
				}
				return r_MCheckCanAccessSubmeshIndices_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTriangles(Int32)
		/// </summary>
		protected RMethod r_MGetTriangles_Int32;
		public virtual RMethod RMGetTriangles_Int32
		{
			get
			{
				if(r_MGetTriangles_Int32 == null)
				{
					r_MGetTriangles_Int32 = new(this, "GetTriangles", 0, typeof(System.Int32));
				}
				return r_MGetTriangles_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetTriangles(Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTriangles_Int32_Boolean;
		public virtual RMethod RMGetTriangles_Int32_Boolean
		{
			get
			{
				if(r_MGetTriangles_Int32_Boolean == null)
				{
					r_MGetTriangles_Int32_Boolean = new(this, "GetTriangles", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTriangles_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_MGetTriangles_List_d_Int32_p__Int32;
		public virtual RMethod RMGetTriangles_List_d_Int32_p__Int32
		{
			get
			{
				if(r_MGetTriangles_List_d_Int32_p__Int32 == null)
				{
					r_MGetTriangles_List_d_Int32_p__Int32 = new(this, "GetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
				}
				return r_MGetTriangles_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTriangles_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RMGetTriangles_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_MGetTriangles_List_d_Int32_p__Int32_Boolean == null)
				{
					r_MGetTriangles_List_d_Int32_p__Int32_Boolean = new(this, "GetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTriangles_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetTriangles_List_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RMGetTriangles_List_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_MGetTriangles_List_d_UInt16_p__Int32_Boolean == null)
				{
					r_MGetTriangles_List_d_UInt16_p__Int32_Boolean = new(this, "GetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetTriangles_List_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32[] GetIndices(Int32)
		/// </summary>
		protected RMethod r_MGetIndices_Int32;
		public virtual RMethod RMGetIndices_Int32
		{
			get
			{
				if(r_MGetIndices_Int32 == null)
				{
					r_MGetIndices_Int32 = new(this, "GetIndices", 0, typeof(System.Int32));
				}
				return r_MGetIndices_Int32;
			}
		}

		/// <summary>
		/// Int32[] GetIndices(Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndices_Int32_Boolean;
		public virtual RMethod RMGetIndices_Int32_Boolean
		{
			get
			{
				if(r_MGetIndices_Int32_Boolean == null)
				{
					r_MGetIndices_Int32_Boolean = new(this, "GetIndices", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndices_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_MGetIndices_List_d_Int32_p__Int32;
		public virtual RMethod RMGetIndices_List_d_Int32_p__Int32
		{
			get
			{
				if(r_MGetIndices_List_d_Int32_p__Int32 == null)
				{
					r_MGetIndices_List_d_Int32_p__Int32 = new(this, "GetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
				}
				return r_MGetIndices_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndices_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RMGetIndices_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_MGetIndices_List_d_Int32_p__Int32_Boolean == null)
				{
					r_MGetIndices_List_d_Int32_p__Int32_Boolean = new(this, "GetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndices_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetIndices(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetIndices_List_d_UInt16_p__Int32_Boolean;
		public virtual RMethod RMGetIndices_List_d_UInt16_p__Int32_Boolean
		{
			get
			{
				if(r_MGetIndices_List_d_UInt16_p__Int32_Boolean == null)
				{
					r_MGetIndices_List_d_UInt16_p__Int32_Boolean = new(this, "GetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetIndices_List_d_UInt16_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](Unity.Collections.NativeArray`1[T], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](T[], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetIndexBufferData[T](System.Collections.Generic.List`1[T], Int32, Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags = new(this, "SetIndexBufferData", 1,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// UInt32 GetIndexStart(Int32)
		/// </summary>
		protected RMethod r_MGetIndexStart_Int32;
		public virtual RMethod RMGetIndexStart_Int32
		{
			get
			{
				if(r_MGetIndexStart_Int32 == null)
				{
					r_MGetIndexStart_Int32 = new(this, "GetIndexStart", 0, typeof(System.Int32));
				}
				return r_MGetIndexStart_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetIndexCount(Int32)
		/// </summary>
		protected RMethod r_MGetIndexCount_Int32;
		public virtual RMethod RMGetIndexCount_Int32
		{
			get
			{
				if(r_MGetIndexCount_Int32 == null)
				{
					r_MGetIndexCount_Int32 = new(this, "GetIndexCount", 0, typeof(System.Int32));
				}
				return r_MGetIndexCount_Int32;
			}
		}

		/// <summary>
		/// UInt32 GetBaseVertex(Int32)
		/// </summary>
		protected RMethod r_MGetBaseVertex_Int32;
		public virtual RMethod RMGetBaseVertex_Int32
		{
			get
			{
				if(r_MGetBaseVertex_Int32 == null)
				{
					r_MGetBaseVertex_Int32 = new(this, "GetBaseVertex", 0, typeof(System.Int32));
				}
				return r_MGetBaseVertex_Int32;
			}
		}

		/// <summary>
		/// Void CheckIndicesArrayRange(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCheckIndicesArrayRange_Int32_Int32_Int32;
		public virtual RMethod RMCheckIndicesArrayRange_Int32_Int32_Int32
		{
			get
			{
				if(r_MCheckIndicesArrayRange_Int32_Int32_Int32 == null)
				{
					r_MCheckIndicesArrayRange_Int32_Int32_Int32 = new(this, "CheckIndicesArrayRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCheckIndicesArrayRange_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetTrianglesImpl(Int32, UnityEngine.Rendering.IndexFormat, System.Array, Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTrianglesImpl", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.IndexFormat), typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_Int32Array_Int32;
		public virtual RMethod RMSetTriangles_Int32Array_Int32
		{
			get
			{
				if(r_MSetTriangles_Int32Array_Int32 == null)
				{
					r_MSetTriangles_Int32Array_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32));
				}
				return r_MSetTriangles_Int32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetTriangles_Int32Array_Int32_Boolean;
		public virtual RMethod RMSetTriangles_Int32Array_Int32_Boolean
		{
			get
			{
				if(r_MSetTriangles_Int32Array_Int32_Boolean == null)
				{
					r_MSetTriangles_Int32Array_Int32_Boolean = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MSetTriangles_Int32Array_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_Int32Array_Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_Int32Array_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_Int32Array_Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_Int32Array_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_Int32Array_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(Int32[], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(UInt16[], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_UInt16Array_Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_UInt16Array_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_UInt16Array_Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_UInt16Array_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_UInt16Array_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(UInt16[], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_List_d_Int32_p__Int32;
		public virtual RMethod RMSetTriangles_List_d_Int32_p__Int32
		{
			get
			{
				if(r_MSetTriangles_List_d_Int32_p__Int32 == null)
				{
					r_MSetTriangles_List_d_Int32_p__Int32 = new(this, "SetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
				}
				return r_MSetTriangles_List_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetTriangles_List_d_Int32_p__Int32_Boolean;
		public virtual RMethod RMSetTriangles_List_d_Int32_p__Int32_Boolean
		{
			get
			{
				if(r_MSetTriangles_List_d_Int32_p__Int32_Boolean == null)
				{
					r_MSetTriangles_List_d_Int32_p__Int32_Boolean = new(this, "SetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MSetTriangles_List_d_Int32_p__Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_List_d_Int32_p__Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_List_d_Int32_p__Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_List_d_Int32_p__Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_List_d_Int32_p__Int32_Boolean_Int32 = new(this, "SetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_List_d_Int32_p__Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.Int32], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32 = new(this, "SetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetTriangles(System.Collections.Generic.List`1[System.UInt16], Int32, Int32, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32;
		public virtual RMethod RMSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32 == null)
				{
					r_MSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32 = new(this, "SetTriangles", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_Int32Array_MeshTopology_Int32;
		public virtual RMethod RMSetIndices_Int32Array_MeshTopology_Int32
		{
			get
			{
				if(r_MSetIndices_Int32Array_MeshTopology_Int32 == null)
				{
					r_MSetIndices_Int32Array_MeshTopology_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32));
				}
				return r_MSetIndices_Int32Array_MeshTopology_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean;
		public virtual RMethod RMSetIndices_Int32Array_MeshTopology_Int32_Boolean
		{
			get
			{
				if(r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean == null)
				{
					r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(Int32[], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(UInt16[], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.UInt16).MakeArrayType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(UInt16[], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0, typeof(System.UInt16).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices[T](Unity.Collections.NativeArray`1[T], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.Int32], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.Int32], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.UInt16], UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt16)), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetIndices(System.Collections.Generic.List`1[System.UInt16], Int32, Int32, UnityEngine.MeshTopology, Int32, Boolean, Int32)
		/// </summary>
		protected RMethod r_MSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
		public virtual RMethod RMSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32
		{
			get
			{
				if(r_MSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 == null)
				{
					r_MSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32 = new(this, "SetIndices", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.UInt16)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32));
				}
				return r_MSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags;
		public virtual RMethod RMSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags == null)
				{
					r_MSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags = new(this, "SetSubMeshes", 0, typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeArrayType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(System.Collections.Generic.List`1[UnityEngine.Rendering.SubMeshDescriptor], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Rendering.SubMeshDescriptor)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes(System.Collections.Generic.List`1[UnityEngine.Rendering.SubMeshDescriptor], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags;
		public virtual RMethod RMSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags == null)
				{
					r_MSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags = new(this, "SetSubMeshes", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Rendering.SubMeshDescriptor)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes[T](Unity.Collections.NativeArray`1[T], Int32, Int32, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
		public virtual RMethod RMSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags == null)
				{
					r_MSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags = new(this, "SetSubMeshes", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void SetSubMeshes[T](Unity.Collections.NativeArray`1[T], UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags;
		public virtual RMethod RMSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags == null)
				{
					r_MSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags = new(this, "SetSubMeshes", 1,  ReflectionUtils.GetType("Unity.Collections.NativeArray`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetBindposes(System.Collections.Generic.List`1[UnityEngine.Matrix4x4])
		/// </summary>
		protected RMethod r_MGetBindposes_List_d_Matrix4x4_p_;
		public virtual RMethod RMGetBindposes_List_d_Matrix4x4_p_
		{
			get
			{
				if(r_MGetBindposes_List_d_Matrix4x4_p_ == null)
				{
					r_MGetBindposes_List_d_Matrix4x4_p_ = new(this, "GetBindposes", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.Matrix4x4)));
				}
				return r_MGetBindposes_List_d_Matrix4x4_p_;
			}
		}

		/// <summary>
		/// Void GetBoneWeights(System.Collections.Generic.List`1[UnityEngine.BoneWeight])
		/// </summary>
		protected RMethod r_MGetBoneWeights_List_d_BoneWeight_p_;
		public virtual RMethod RMGetBoneWeights_List_d_BoneWeight_p_
		{
			get
			{
				if(r_MGetBoneWeights_List_d_BoneWeight_p_ == null)
				{
					r_MGetBoneWeights_List_d_BoneWeight_p_ = new(this, "GetBoneWeights", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.BoneWeight)));
				}
				return r_MGetBoneWeights_List_d_BoneWeight_p_;
			}
		}

		/// <summary>
		/// Void Clear(Boolean)
		/// </summary>
		protected RMethod r_MClear_Boolean;
		public virtual RMethod RMClear_Boolean
		{
			get
			{
				if(r_MClear_Boolean == null)
				{
					r_MClear_Boolean = new(this, "Clear", 0, typeof(System.Boolean));
				}
				return r_MClear_Boolean;
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
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void RecalculateBounds()
		/// </summary>
		protected RMethod r_MRecalculateBounds;
		public virtual RMethod RMRecalculateBounds
		{
			get
			{
				if(r_MRecalculateBounds == null)
				{
					r_MRecalculateBounds = new(this, "RecalculateBounds", 0);
				}
				return r_MRecalculateBounds;
			}
		}

		/// <summary>
		/// Void RecalculateNormals()
		/// </summary>
		protected RMethod r_MRecalculateNormals;
		public virtual RMethod RMRecalculateNormals
		{
			get
			{
				if(r_MRecalculateNormals == null)
				{
					r_MRecalculateNormals = new(this, "RecalculateNormals", 0);
				}
				return r_MRecalculateNormals;
			}
		}

		/// <summary>
		/// Void RecalculateTangents()
		/// </summary>
		protected RMethod r_MRecalculateTangents;
		public virtual RMethod RMRecalculateTangents
		{
			get
			{
				if(r_MRecalculateTangents == null)
				{
					r_MRecalculateTangents = new(this, "RecalculateTangents", 0);
				}
				return r_MRecalculateTangents;
			}
		}

		/// <summary>
		/// Void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MRecalculateBounds_MeshUpdateFlags;
		public virtual RMethod RMRecalculateBounds_MeshUpdateFlags
		{
			get
			{
				if(r_MRecalculateBounds_MeshUpdateFlags == null)
				{
					r_MRecalculateBounds_MeshUpdateFlags = new(this, "RecalculateBounds", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MRecalculateBounds_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MRecalculateNormals_MeshUpdateFlags;
		public virtual RMethod RMRecalculateNormals_MeshUpdateFlags
		{
			get
			{
				if(r_MRecalculateNormals_MeshUpdateFlags == null)
				{
					r_MRecalculateNormals_MeshUpdateFlags = new(this, "RecalculateNormals", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MRecalculateNormals_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MRecalculateTangents_MeshUpdateFlags;
		public virtual RMethod RMRecalculateTangents_MeshUpdateFlags
		{
			get
			{
				if(r_MRecalculateTangents_MeshUpdateFlags == null)
				{
					r_MRecalculateTangents_MeshUpdateFlags = new(this, "RecalculateTangents", 0, typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MRecalculateTangents_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetric(Int32, Single)
		/// </summary>
		protected RMethod r_MRecalculateUVDistributionMetric_Int32_Single;
		public virtual RMethod RMRecalculateUVDistributionMetric_Int32_Single
		{
			get
			{
				if(r_MRecalculateUVDistributionMetric_Int32_Single == null)
				{
					r_MRecalculateUVDistributionMetric_Int32_Single = new(this, "RecalculateUVDistributionMetric", 0, typeof(System.Int32), typeof(System.Single));
				}
				return r_MRecalculateUVDistributionMetric_Int32_Single;
			}
		}

		/// <summary>
		/// Void RecalculateUVDistributionMetrics(Single)
		/// </summary>
		protected RMethod r_MRecalculateUVDistributionMetrics_Single;
		public virtual RMethod RMRecalculateUVDistributionMetrics_Single
		{
			get
			{
				if(r_MRecalculateUVDistributionMetrics_Single == null)
				{
					r_MRecalculateUVDistributionMetrics_Single = new(this, "RecalculateUVDistributionMetrics", 0, typeof(System.Single));
				}
				return r_MRecalculateUVDistributionMetrics_Single;
			}
		}

		/// <summary>
		/// Void MarkDynamic()
		/// </summary>
		protected RMethod r_MMarkDynamic;
		public virtual RMethod RMMarkDynamic
		{
			get
			{
				if(r_MMarkDynamic == null)
				{
					r_MMarkDynamic = new(this, "MarkDynamic", 0);
				}
				return r_MMarkDynamic;
			}
		}

		/// <summary>
		/// Void UploadMeshData(Boolean)
		/// </summary>
		protected RMethod r_MUploadMeshData_Boolean;
		public virtual RMethod RMUploadMeshData_Boolean
		{
			get
			{
				if(r_MUploadMeshData_Boolean == null)
				{
					r_MUploadMeshData_Boolean = new(this, "UploadMeshData", 0, typeof(System.Boolean));
				}
				return r_MUploadMeshData_Boolean;
			}
		}

		/// <summary>
		/// Void Optimize()
		/// </summary>
		protected RMethod r_MOptimize;
		public virtual RMethod RMOptimize
		{
			get
			{
				if(r_MOptimize == null)
				{
					r_MOptimize = new(this, "Optimize", 0);
				}
				return r_MOptimize;
			}
		}

		/// <summary>
		/// Void OptimizeIndexBuffers()
		/// </summary>
		protected RMethod r_MOptimizeIndexBuffers;
		public virtual RMethod RMOptimizeIndexBuffers
		{
			get
			{
				if(r_MOptimizeIndexBuffers == null)
				{
					r_MOptimizeIndexBuffers = new(this, "OptimizeIndexBuffers", 0);
				}
				return r_MOptimizeIndexBuffers;
			}
		}

		/// <summary>
		/// Void OptimizeReorderVertexBuffer()
		/// </summary>
		protected RMethod r_MOptimizeReorderVertexBuffer;
		public virtual RMethod RMOptimizeReorderVertexBuffer
		{
			get
			{
				if(r_MOptimizeReorderVertexBuffer == null)
				{
					r_MOptimizeReorderVertexBuffer = new(this, "OptimizeReorderVertexBuffer", 0);
				}
				return r_MOptimizeReorderVertexBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology GetTopology(Int32)
		/// </summary>
		protected RMethod r_MGetTopology_Int32;
		public virtual RMethod RMGetTopology_Int32
		{
			get
			{
				if(r_MGetTopology_Int32 == null)
				{
					r_MGetTopology_Int32 = new(this, "GetTopology", 0, typeof(System.Int32));
				}
				return r_MGetTopology_Int32;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean;
		public virtual RMethod RMCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean == null)
				{
					r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean, Boolean)
		/// </summary>
		protected RMethod r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean;
		public virtual RMethod RMCombineMeshes_CombineInstanceArray_Boolean_Boolean
		{
			get
			{
				if(r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean == null)
				{
					r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MCombineMeshes_CombineInstanceArray_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[], Boolean)
		/// </summary>
		protected RMethod r_MCombineMeshes_CombineInstanceArray_Boolean;
		public virtual RMethod RMCombineMeshes_CombineInstanceArray_Boolean
		{
			get
			{
				if(r_MCombineMeshes_CombineInstanceArray_Boolean == null)
				{
					r_MCombineMeshes_CombineInstanceArray_Boolean = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType(), typeof(System.Boolean));
				}
				return r_MCombineMeshes_CombineInstanceArray_Boolean;
			}
		}

		/// <summary>
		/// Void CombineMeshes(UnityEngine.CombineInstance[])
		/// </summary>
		protected RMethod r_MCombineMeshes_CombineInstanceArray;
		public virtual RMethod RMCombineMeshes_CombineInstanceArray
		{
			get
			{
				if(r_MCombineMeshes_CombineInstanceArray == null)
				{
					r_MCombineMeshes_CombineInstanceArray = new(this, "CombineMeshes", 0, typeof(UnityEngine.CombineInstance).MakeArrayType());
				}
				return r_MCombineMeshes_CombineInstanceArray;
			}
		}

		/// <summary>
		/// Void GetVertexAttribute_Injected(Int32, UnityEngine.Rendering.VertexAttributeDescriptor ByRef)
		/// </summary>
		protected RMethod r_MGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor;
		public virtual RMethod RMGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor
		{
			get
			{
				if(r_MGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor == null)
				{
					r_MGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor = new(this, "GetVertexAttribute_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.VertexAttributeDescriptor).MakeByRefType());
				}
				return r_MGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Void GetBlendShapeOffsetInternal_Injected(Int32, UnityEngine.BlendShape ByRef)
		/// </summary>
		protected RMethod r_MGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape;
		public virtual RMethod RMGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape
		{
			get
			{
				if(r_MGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape == null)
				{
					r_MGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape = new(this, "GetBlendShapeOffsetInternal_Injected", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.BlendShape").MakeByRefType());
				}
				return r_MGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape;
			}
		}

		/// <summary>
		/// Void GetReadOnlySafetyHandle_Injected(SafetyHandleIndex, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_MGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle;
		public virtual RMethod RMGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle == null)
				{
					r_MGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle = new(this, "GetReadOnlySafetyHandle_Injected", 0,  ReflectionUtils.GetType("UnityEngine.Mesh+SafetyHandleIndex"), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void SetSubMesh_Injected(Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef, UnityEngine.Rendering.MeshUpdateFlags)
		/// </summary>
		protected RMethod r_MSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
		public virtual RMethod RMSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags
		{
			get
			{
				if(r_MSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags == null)
				{
					r_MSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags = new(this, "SetSubMesh_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType(), typeof(UnityEngine.Rendering.MeshUpdateFlags));
				}
				return r_MSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags;
			}
		}

		/// <summary>
		/// Void GetSubMesh_Injected(Int32, UnityEngine.Rendering.SubMeshDescriptor ByRef)
		/// </summary>
		protected RMethod r_MGetSubMesh_Injected_Int32_Out_SubMeshDescriptor;
		public virtual RMethod RMGetSubMesh_Injected_Int32_Out_SubMeshDescriptor
		{
			get
			{
				if(r_MGetSubMesh_Injected_Int32_Out_SubMeshDescriptor == null)
				{
					r_MGetSubMesh_Injected_Int32_Out_SubMeshDescriptor = new(this, "GetSubMesh_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Rendering.SubMeshDescriptor).MakeByRefType());
				}
				return r_MGetSubMesh_Injected_Int32_Out_SubMeshDescriptor;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mget_bounds_Injected_Out_Bounds;
		public virtual RMethod RMget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Mget_bounds_Injected_Out_Bounds == null)
				{
					r_Mget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
				}
				return r_Mget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Mset_bounds_Injected_Ref_Bounds;
		public virtual RMethod RMset_bounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_Mset_bounds_Injected_Ref_Bounds == null)
				{
					r_Mset_bounds_Injected_Ref_Bounds = new(this, "set_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
				}
				return r_Mset_bounds_Injected_Ref_Bounds;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public static void Internal_Create(UnityEngine.Mesh @mono)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono};
            var ___result = RMInternal_Create_Mesh.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Mesh FromInstanceID(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMFromInstanceID_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Mesh>(___result);
        }


        public virtual System.UInt32 GetTotalIndexCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTotalIndexCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual void SetIndexBufferParams(System.Int32 @indexCount, UnityEngine.Rendering.IndexFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexCount, @format};
            var ___result = RMSetIndexBufferParams_Int32_IndexFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetIndexBufferData(System.IntPtr @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @elemSize, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RMInternalSetIndexBufferData_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetIndexBufferDataFromArray(System.Array @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @elemSize, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RMInternalSetIndexBufferDataFromArray_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferParamsFromPtr(System.Int32 @vertexCount, System.IntPtr @attributesPtr, System.Int32 @attributesCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributesPtr, @attributesCount};
            var ___result = RMSetVertexBufferParamsFromPtr_Int32_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferParamsFromArray(System.Int32 @vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @attributes};
            var ___result = RMSetVertexBufferParamsFromArray_Int32_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetVertexBufferData(System.Int32 @stream, System.IntPtr @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @elemSize, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RMInternalSetVertexBufferData_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetVertexBufferDataFromArray(System.Int32 @stream, System.Array @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @elemSize, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @data, @dataStart, @meshBufferStart, @count, @elemSize, @flags};
            var ___result = RMInternalSetVertexBufferDataFromArray_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Array GetVertexAttributesAlloc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVertexAttributesAlloc.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Array>(___result);
        }


        public virtual System.Int32 GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[] @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RMGetVertexAttributesArray_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetVertexAttributesList(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RMGetVertexAttributesList_List_d_VertexAttributeDescriptor_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetVertexAttributeCountImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVertexAttributeCountImpl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetVertexAttribute_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.VertexAttributeDescriptor>(___result);
        }


        public virtual System.UInt32 GetIndexStartImpl(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetIndexStartImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.UInt32 GetIndexCountImpl(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetIndexCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.UInt32 GetTrianglesCountImpl(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetTrianglesCountImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.UInt32 GetBaseVertexImpl(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetBaseVertexImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.Int32[] GetTrianglesImpl(System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RMGetTrianglesImpl_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetIndicesImpl(System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RMGetIndicesImpl_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual void SetIndicesImpl(System.Int32 @submesh, UnityEngine.MeshTopology @topology, UnityEngine.Rendering.IndexFormat @indicesFormat, System.Array @indices, System.Int32 @arrayStart, System.Int32 @arraySize, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @topology, @indicesFormat, @indices, @arrayStart, @arraySize, @calculateBounds, @baseVertex};
            var ___result = RMSetIndicesImpl_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndicesNativeArrayImpl(System.Int32 @submesh, UnityEngine.MeshTopology @topology, UnityEngine.Rendering.IndexFormat @indicesFormat, System.IntPtr @indices, System.Int32 @arrayStart, System.Int32 @arraySize, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @topology, @indicesFormat, @indices, @arrayStart, @arraySize, @calculateBounds, @baseVertex};
            var ___result = RMSetIndicesNativeArrayImpl_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTrianglesNonAllocImpl(System.Int32[] @values, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RMGetTrianglesNonAllocImpl_Int32Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTrianglesNonAllocImpl16(System.UInt16[] @values, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RMGetTrianglesNonAllocImpl16_UInt16Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndicesNonAllocImpl(System.Int32[] @values, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RMGetIndicesNonAllocImpl_Int32Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndicesNonAllocImpl16(System.UInt16[] @values, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values, @submesh, @applyBaseVertex};
            var ___result = RMGetIndicesNonAllocImpl16_UInt16Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMPrintErrorCantAccessChannel_VertexAttribute.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.Array @values, System.Int32 @arraySize, System.Int32 @valuesStart, System.Int32 @valuesCount, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @arraySize, @valuesStart, @valuesCount, @flags};
            var ___result = RMSetArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.IntPtr @values, System.Int32 @arraySize, System.Int32 @valuesStart, System.Int32 @valuesCount, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @arraySize, @valuesStart, @valuesCount, @flags};
            var ___result = RMSetNativeArrayForChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim};
            var ___result = RMGetAllocArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Array>(___result);
        }


        public virtual void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.Array @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values};
            var ___result = RMGetArrayFromChannelImpl_VertexAttribute_VertexAttributeFormat_Int32_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetVertexBufferStride(System.Int32 @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RMGetVertexBufferStride_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.IntPtr GetNativeVertexBufferPtr(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetNativeVertexBufferPtr_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual System.IntPtr GetNativeIndexBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeIndexBufferPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetVertexBufferImpl(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetVertexBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetIndexBufferImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIndexBufferImpl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(System.Int32 @bonesPerVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bonesPerVertex};
            var ___result = RMGetBoneWeightBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(System.Int32 @layout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layout};
            var ___result = RMGetBlendShapeBufferImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual void ClearBlendShapes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearBlendShapes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetBlendShapeName(System.Int32 @shapeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex};
            var ___result = RMGetBlendShapeName_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 GetBlendShapeIndex(System.String @blendShapeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@blendShapeName};
            var ___result = RMGetBlendShapeIndex_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetBlendShapeFrameCount(System.Int32 @shapeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex};
            var ___result = RMGetBlendShapeFrameCount_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Single GetBlendShapeFrameWeight(System.Int32 @shapeIndex, System.Int32 @frameIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex, @frameIndex};
            var ___result = RMGetBlendShapeFrameWeight_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void GetBlendShapeFrameVertices(System.Int32 @shapeIndex, System.Int32 @frameIndex, UnityEngine.Vector3[] @deltaVertices, UnityEngine.Vector3[] @deltaNormals, UnityEngine.Vector3[] @deltaTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIndex, @frameIndex, @deltaVertices, @deltaNormals, @deltaTangents};
            var ___result = RMGetBlendShapeFrameVertices_Int32_Int32_Vector3Array_Vector3Array_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBlendShapeFrame(System.String @shapeName, System.Single @frameWeight, UnityEngine.Vector3[] @deltaVertices, UnityEngine.Vector3[] @deltaNormals, UnityEngine.Vector3[] @deltaTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeName, @frameWeight, @deltaVertices, @deltaNormals, @deltaTangents};
            var ___result = RMAddBlendShapeFrame_String_Single_Vector3Array_Vector3Array_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RBlendShape GetBlendShapeOffsetInternal(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetBlendShapeOffsetInternal_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RBlendShape>(___result);
        }


        public virtual System.Boolean HasBoneWeights()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasBoneWeights.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.BoneWeight[] GetBoneWeightsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBoneWeightsImpl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.BoneWeight[]>(___result);
        }


        public virtual void SetBoneWeightsImpl(UnityEngine.BoneWeight[] @weights)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@weights};
            var ___result = RMSetBoneWeightsImpl_BoneWeightArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBoneWeights(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RByte> @bonesPerVertex, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RBoneWeight1> @weights)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bonesPerVertex.Value, @weights.Value};
            var ___result = RMSetBoneWeights_NativeArray_d_Byte_p__NativeArray_d_BoneWeight1_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetBoneWeights(System.IntPtr @bonesPerVertex, System.Int32 @bonesPerVertexSize, System.IntPtr @weights, System.Int32 @weightsSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bonesPerVertex, @bonesPerVertexSize, @weights, @weightsSize};
            var ___result = RMInternalSetBoneWeights_IntPtr_Int32_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RBoneWeight1> GetAllBoneWeights()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllBoneWeights.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RBoneWeight1>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RByte> GetBonesPerVertex()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBonesPerVertex.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RByte>>(___result);
        }


        public virtual System.Int32 GetAllBoneWeightsArraySize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllBoneWeightsArraySize.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetBoneWeightBufferLayoutInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBoneWeightBufferLayoutInternal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.IntPtr GetAllBoneWeightsArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAllBoneWeightsArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual System.IntPtr GetBonesPerVertexArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBonesPerVertexArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4> GetBindposes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBindposes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4>>(___result);
        }


        public virtual System.IntPtr GetBindposesArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBindposesArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RMGetBoneWeightsNonAllocImpl_BoneWeightArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@values};
            var ___result = RMGetBindposesNonAllocImpl_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetReadOnlySafetyHandle(Hvak.Editor.Refleaction.RUnityEngine.RMesh.RSafetyHandleIndex @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index.Value};
            var ___result = RMGetReadOnlySafetyHandle_SafetyHandleIndex.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle>(___result);
        }


        public virtual void SetSubMesh(System.Int32 @index, UnityEngine.Rendering.SubMeshDescriptor @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @desc, @flags};
            var ___result = RMSetSubMesh_Int32_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetSubMesh_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SubMeshDescriptor>(___result);
        }


        public virtual void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[] @desc, System.Int32 @start, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RMSetAllSubMeshesAtOnceFromArray_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllSubMeshesAtOnceFromNativeArray(System.IntPtr @desc, System.Int32 @start, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RMSetAllSubMeshesAtOnceFromNativeArray_IntPtr_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearImpl(System.Boolean @keepVertexLayout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepVertexLayout};
            var ___result = RMClearImpl_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMRecalculateBoundsImpl_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMRecalculateNormalsImpl_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMRecalculateTangentsImpl_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDynamicImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDynamicImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkModified()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkModified.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UploadMeshDataImpl(System.Boolean @markNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markNoLongerReadable};
            var ___result = RMUploadMeshDataImpl_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.MeshTopology GetTopologyImpl(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetTopologyImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.MeshTopology>(___result);
        }


        public virtual void RecalculateUVDistributionMetricImpl(System.Int32 @uvSetIndex, System.Single @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvSetIndex, @uvAreaThreshold};
            var ___result = RMRecalculateUVDistributionMetricImpl_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateUVDistributionMetricsImpl(System.Single @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvAreaThreshold};
            var ___result = RMRecalculateUVDistributionMetricsImpl_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetUVDistributionMetric(System.Int32 @uvSetIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvSetIndex};
            var ___result = RMGetUVDistributionMetric_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void CombineMeshesImpl(UnityEngine.CombineInstance[] @combine, System.Boolean @mergeSubMeshes, System.Boolean @useMatrices, System.Boolean @hasLightmapData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes, @useMatrices, @hasLightmapData};
            var ___result = RMCombineMeshesImpl_CombineInstanceArray_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOptimizeImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeIndexBuffersImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOptimizeIndexBuffersImpl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeReorderVertexBufferImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOptimizeReorderVertexBufferImpl.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rendering.VertexAttribute GetUVChannel(System.Int32 @uvIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvIndex};
            var ___result = RMGetUVChannel_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.VertexAttribute>(___result);
        }


        public static System.Int32 DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute @channel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel};
            var ___result = RMDefaultDimensionForChannel_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @format, @dim};
            var ___result = RMGetAllocArrayFromChannel_GT_VertexAttribute_VertexAttributeFormat_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute @channel)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel};
            var ___result = RMGetAllocArrayFromChannel_GT_VertexAttribute.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T[]>(___result);
        }


        public virtual void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.Array @values, System.Int32 @valuesArrayLength, System.Int32 @valuesStart, System.Int32 @valuesCount, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @valuesArrayLength, @valuesStart, @valuesCount, @flags};
            var ___result = RMSetSizedArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.IntPtr @values, System.Int32 @valuesArrayLength, System.Int32 @valuesStart, System.Int32 @valuesCount, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @valuesArrayLength, @valuesStart, @valuesCount, @flags};
            var ___result = RMSetSizedNativeArrayForChannel_VertexAttribute_VertexAttributeFormat_Int32_IntPtr_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, T[] @values, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @flags};
            var ___result = RMSetArrayForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_TArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute @channel, T[] @values, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @values, @flags};
            var ___result = RMSetArrayForChannel_GT_VertexAttribute_TArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute @channel, UnityEngine.Rendering.VertexAttributeFormat @format, System.Int32 @dim, System.Collections.Generic.List<T> @values, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @format, @dim, @values, @start, @length, @flags};
            var ___result = RMSetListForChannel_GT_VertexAttribute_VertexAttributeFormat_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute @channel, System.Collections.Generic.List<T> @values, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @values, @start, @length, @flags};
            var ___result = RMSetListForChannel_GT_VertexAttribute_List_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetListForChannel<T>(System.Collections.Generic.List<T> @buffer, System.Int32 @capacity, UnityEngine.Rendering.VertexAttribute @channel, System.Int32 @dim)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @capacity, @channel, @dim};
            var ___result = RMGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetListForChannel<T>(System.Collections.Generic.List<T> @buffer, System.Int32 @capacity, UnityEngine.Rendering.VertexAttribute @channel, System.Int32 @dim, UnityEngine.Rendering.VertexAttributeFormat @channelType)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@buffer, @capacity, @channel, @dim, @channelType};
            var ___result = RMGetListForChannel_GT_List_d_T_p__Int32_VertexAttribute_Int32_VertexAttributeFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> @vertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices};
            var ___result = RMGetVertices_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> @inVertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices};
            var ___result = RMSetVertices_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> @inVertices, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length};
            var ___result = RMSetVertices_List_d_Vector3_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> @inVertices, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length, @flags};
            var ___result = RMSetVertices_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(UnityEngine.Vector3[] @inVertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices};
            var ___result = RMSetVertices_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(UnityEngine.Vector3[] @inVertices, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length};
            var ___result = RMSetVertices_Vector3Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices(UnityEngine.Vector3[] @inVertices, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inVertices, @start, @length, @flags};
            var ___result = RMSetVertices_Vector3Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inVertices) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inVertices.Value};
            var ___result = RMSetVertices_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inVertices, System.Int32 @start, System.Int32 @length) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inVertices.Value, @start, @length};
            var ___result = RMSetVertices_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertices<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inVertices, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inVertices.Value, @start, @length, @flags};
            var ___result = RMSetVertices_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> @normals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@normals};
            var ___result = RMGetNormals_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> @inNormals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals};
            var ___result = RMSetNormals_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> @inNormals, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length};
            var ___result = RMSetNormals_List_d_Vector3_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> @inNormals, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length, @flags};
            var ___result = RMSetNormals_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(UnityEngine.Vector3[] @inNormals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals};
            var ___result = RMSetNormals_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(UnityEngine.Vector3[] @inNormals, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length};
            var ___result = RMSetNormals_Vector3Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals(UnityEngine.Vector3[] @inNormals, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inNormals, @start, @length, @flags};
            var ___result = RMSetNormals_Vector3Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inNormals) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inNormals.Value};
            var ___result = RMSetNormals_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inNormals, System.Int32 @start, System.Int32 @length) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inNormals.Value, @start, @length};
            var ___result = RMSetNormals_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNormals<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inNormals, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inNormals.Value, @start, @length, @flags};
            var ___result = RMSetNormals_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> @tangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tangents};
            var ___result = RMGetTangents_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> @inTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents};
            var ___result = RMSetTangents_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> @inTangents, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length};
            var ___result = RMSetTangents_List_d_Vector4_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> @inTangents, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length, @flags};
            var ___result = RMSetTangents_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(UnityEngine.Vector4[] @inTangents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents};
            var ___result = RMSetTangents_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(UnityEngine.Vector4[] @inTangents, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length};
            var ___result = RMSetTangents_Vector4Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents(UnityEngine.Vector4[] @inTangents, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inTangents, @start, @length, @flags};
            var ___result = RMSetTangents_Vector4Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inTangents) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inTangents.Value};
            var ___result = RMSetTangents_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inTangents, System.Int32 @start, System.Int32 @length) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inTangents.Value, @start, @length};
            var ___result = RMSetTangents_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTangents<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inTangents, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inTangents.Value, @start, @length, @flags};
            var ___result = RMSetTangents_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColors(System.Collections.Generic.List<UnityEngine.Color> @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RMGetColors_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color> @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RMSetColors_List_d_Color_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color> @inColors, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RMSetColors_List_d_Color_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color> @inColors, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RMSetColors_List_d_Color_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color[] @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RMSetColors_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color[] @inColors, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RMSetColors_ColorArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color[] @inColors, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RMSetColors_ColorArray_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetColors(System.Collections.Generic.List<UnityEngine.Color32> @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RMGetColors_List_d_Color32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color32> @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RMSetColors_List_d_Color32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color32> @inColors, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RMSetColors_List_d_Color32_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(System.Collections.Generic.List<UnityEngine.Color32> @inColors, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RMSetColors_List_d_Color32_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color32[] @inColors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors};
            var ___result = RMSetColors_Color32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color32[] @inColors, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length};
            var ___result = RMSetColors_Color32Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors(UnityEngine.Color32[] @inColors, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inColors, @start, @length, @flags};
            var ___result = RMSetColors_Color32Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inColors) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inColors.Value};
            var ___result = RMSetColors_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inColors, System.Int32 @start, System.Int32 @length) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inColors.Value, @start, @length};
            var ___result = RMSetColors_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColors<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @inColors, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@inColors.Value, @start, @length, @flags};
            var ___result = RMSetColors_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUvsImpl<T>(System.Int32 @uvIndex, System.Int32 @dim, System.Collections.Generic.List<T> @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@uvIndex, @dim, @uvs, @start, @length, @flags};
            var ___result = RMSetUvsImpl_GT_Int32_Int32_List_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector2> @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMSetUVs_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector3> @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMSetUVs_Int32_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector4> @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMSetUVs_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector2> @uvs, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RMSetUVs_Int32_List_d_Vector2_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector2> @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RMSetUVs_Int32_List_d_Vector2_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector3> @uvs, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RMSetUVs_Int32_List_d_Vector3_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector3> @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RMSetUVs_Int32_List_d_Vector3_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector4> @uvs, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RMSetUVs_Int32_List_d_Vector4_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector4> @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RMSetUVs_Int32_List_d_Vector4_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUvsImpl(System.Int32 @uvIndex, System.Int32 @dim, System.Array @uvs, System.Int32 @arrayStart, System.Int32 @arraySize, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvIndex, @dim, @uvs, @arrayStart, @arraySize, @flags};
            var ___result = RMSetUvsImpl_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector2[] @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMSetUVs_Int32_Vector2Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector3[] @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMSetUVs_Int32_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector4[] @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMSetUVs_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector2[] @uvs, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RMSetUVs_Int32_Vector2Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector2[] @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RMSetUVs_Int32_Vector2Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector3[] @uvs, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RMSetUVs_Int32_Vector3Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector3[] @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RMSetUVs_Int32_Vector3Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector4[] @uvs, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length};
            var ___result = RMSetUVs_Int32_Vector4Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs(System.Int32 @channel, UnityEngine.Vector4[] @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs, @start, @length, @flags};
            var ___result = RMSetUVs_Int32_Vector4Array_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs<T>(System.Int32 @channel, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @uvs) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @uvs.Value};
            var ___result = RMSetUVs_GT_Int32_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs<T>(System.Int32 @channel, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @uvs, System.Int32 @start, System.Int32 @length) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @uvs.Value, @start, @length};
            var ___result = RMSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUVs<T>(System.Int32 @channel, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @uvs, System.Int32 @start, System.Int32 @length, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@channel, @uvs.Value, @start, @length, @flags};
            var ___result = RMSetUVs_GT_Int32_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVsImpl<T>(System.Int32 @uvIndex, System.Collections.Generic.List<T> @uvs, System.Int32 @dim)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@uvIndex, @uvs, @dim};
            var ___result = RMGetUVsImpl_GT_Int32_List_d_T_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector2> @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMGetUVs_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector3> @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMGetUVs_Int32_List_d_Vector3_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetUVs(System.Int32 @channel, System.Collections.Generic.List<UnityEngine.Vector4> @uvs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@channel, @uvs};
            var ___result = RMGetUVs_Int32_List_d_Vector4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetVertexAttributes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.VertexAttributeDescriptor[]>(___result);
        }


        public virtual System.Int32 GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[] @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RMGetVertexAttributes_VertexAttributeDescriptorArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetVertexAttributes(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RMGetVertexAttributes_List_d_VertexAttributeDescriptor_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual void SetVertexBufferData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @stream, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @dataStart, @meshBufferStart, @count, @stream, @flags};
            var ___result = RMSetVertexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferData<T>(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @stream, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @dataStart, @meshBufferStart, @count, @stream, @flags};
            var ___result = RMSetVertexBufferData_GT_TArray_Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertexBufferData<T>(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, System.Int32 @stream, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @dataStart, @meshBufferStart, @count, @stream, @flags};
            var ___result = RMSetVertexBufferData_GT_List_d_T_p__Int32_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh @mesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mesh};
            var ___result = RMAcquireReadOnlyMeshData_Mesh.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[] @meshes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes};
            var ___result = RMAcquireReadOnlyMeshData_MeshArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List<UnityEngine.Mesh> @meshes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshes};
            var ___result = RMAcquireReadOnlyMeshData_List_d_Mesh_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray AllocateWritableMeshData(System.Int32 @meshCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshCount};
            var ___result = RMAllocateWritableMeshData_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray>(___result);
        }


        public static void ApplyAndDisposeWritableMeshData(Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray @data, UnityEngine.Mesh @mesh, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @mesh, @flags};
            var ___result = RMApplyAndDisposeWritableMeshData_MeshDataArray_Mesh_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyAndDisposeWritableMeshData(Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray @data, UnityEngine.Mesh[] @meshes, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @meshes, @flags};
            var ___result = RMApplyAndDisposeWritableMeshData_MeshDataArray_MeshArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public static void ApplyAndDisposeWritableMeshData(Hvak.Editor.Refleaction.RUnityEngine.RMesh.RMeshDataArray @data, System.Collections.Generic.List<UnityEngine.Mesh> @meshes, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value, @meshes, @flags};
            var ___result = RMApplyAndDisposeWritableMeshData_MeshDataArray_List_d_Mesh_p__MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GraphicsBuffer GetVertexBuffer(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetVertexBuffer_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetIndexBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIndexBuffer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights @layout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layout};
            var ___result = RMGetBoneWeightBuffer_SkinWeights.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout @layout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layout};
            var ___result = RMGetBlendShapeBuffer_BlendShapeBufferLayout.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.GraphicsBuffer GetBlendShapeBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBlendShapeBuffer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GraphicsBuffer>(___result);
        }


        public virtual UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(System.Int32 @blendShapeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@blendShapeIndex};
            var ___result = RMGetBlendShapeBufferRange_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.BlendShapeBufferRange>(___result);
        }


        public virtual void PrintErrorCantAccessIndices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrintErrorCantAccessIndices.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckCanAccessSubmesh(System.Int32 @submesh, System.Boolean @errorAboutTriangles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @errorAboutTriangles};
            var ___result = RMCheckCanAccessSubmesh_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CheckCanAccessSubmeshTriangles(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMCheckCanAccessSubmeshTriangles_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CheckCanAccessSubmeshIndices(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMCheckCanAccessSubmeshIndices_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32[] GetTriangles(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetTriangles_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetTriangles(System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RMGetTriangles_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual void GetTriangles(System.Collections.Generic.List<System.Int32> @triangles, System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh};
            var ___result = RMGetTriangles_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTriangles(System.Collections.Generic.List<System.Int32> @triangles, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @applyBaseVertex};
            var ___result = RMGetTriangles_List_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetTriangles(System.Collections.Generic.List<System.UInt16> @triangles, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @applyBaseVertex};
            var ___result = RMGetTriangles_List_d_UInt16_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32[] GetIndices(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetIndices_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetIndices(System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @applyBaseVertex};
            var ___result = RMGetIndices_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual void GetIndices(System.Collections.Generic.List<System.Int32> @indices, System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @submesh};
            var ___result = RMGetIndices_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndices(System.Collections.Generic.List<System.Int32> @indices, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @submesh, @applyBaseVertex};
            var ___result = RMGetIndices_List_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetIndices(System.Collections.Generic.List<System.UInt16> @indices, System.Int32 @submesh, System.Boolean @applyBaseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @submesh, @applyBaseVertex};
            var ___result = RMGetIndices_List_d_UInt16_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndexBufferData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @dataStart, @meshBufferStart, @count, @flags};
            var ___result = RMSetIndexBufferData_GT_NativeArray_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndexBufferData<T>(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @dataStart, @meshBufferStart, @count, @flags};
            var ___result = RMSetIndexBufferData_GT_TArray_Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndexBufferData<T>(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RType> @data, System.Int32 @dataStart, System.Int32 @meshBufferStart, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @dataStart, @meshBufferStart, @count, @flags};
            var ___result = RMSetIndexBufferData_GT_List_d_T_p__Int32_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt32 GetIndexStart(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetIndexStart_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.UInt32 GetIndexCount(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetIndexCount_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.UInt32 GetBaseVertex(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetBaseVertex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual void CheckIndicesArrayRange(System.Int32 @valuesLength, System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valuesLength, @start, @length};
            var ___result = RMCheckIndicesArrayRange_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTrianglesImpl(System.Int32 @submesh, UnityEngine.Rendering.IndexFormat @indicesFormat, System.Array @triangles, System.Int32 @trianglesArrayLength, System.Int32 @start, System.Int32 @length, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh, @indicesFormat, @triangles, @trianglesArrayLength, @start, @length, @calculateBounds, @baseVertex};
            var ___result = RMSetTrianglesImpl_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[] @triangles, System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh};
            var ___result = RMSetTriangles_Int32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[] @triangles, System.Int32 @submesh, System.Boolean @calculateBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds};
            var ___result = RMSetTriangles_Int32Array_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[] @triangles, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_Int32Array_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Int32[] @triangles, System.Int32 @trianglesStart, System.Int32 @trianglesLength, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_Int32Array_Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.UInt16[] @triangles, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_UInt16Array_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.UInt16[] @triangles, System.Int32 @trianglesStart, System.Int32 @trianglesLength, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_UInt16Array_Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32> @triangles, System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh};
            var ___result = RMSetTriangles_List_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32> @triangles, System.Int32 @submesh, System.Boolean @calculateBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds};
            var ___result = RMSetTriangles_List_d_Int32_p__Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32> @triangles, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_List_d_Int32_p__Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.Int32> @triangles, System.Int32 @trianglesStart, System.Int32 @trianglesLength, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_List_d_Int32_p__Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.UInt16> @triangles, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_List_d_UInt16_p__Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTriangles(System.Collections.Generic.List<System.UInt16> @triangles, System.Int32 @trianglesStart, System.Int32 @trianglesLength, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triangles, @trianglesStart, @trianglesLength, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetTriangles_List_d_UInt16_p__Int32_Int32_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[] @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh};
            var ___result = RMSetIndices_Int32Array_MeshTopology_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[] @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds};
            var ___result = RMSetIndices_Int32Array_MeshTopology_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[] @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_Int32Array_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Int32[] @indices, System.Int32 @indicesStart, System.Int32 @indicesLength, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_Int32Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.UInt16[] @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_UInt16Array_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.UInt16[] @indices, System.Int32 @indicesStart, System.Int32 @indicesLength, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_UInt16Array_Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@indices.Value, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_GT_NativeArray_d_T_p__MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @indices, System.Int32 @indicesStart, System.Int32 @indicesLength, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@indices.Value, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_GT_NativeArray_d_T_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.Int32> @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_List_d_Int32_p__MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.Int32> @indices, System.Int32 @indicesStart, System.Int32 @indicesLength, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_List_d_Int32_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.UInt16> @indices, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_List_d_UInt16_p__MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIndices(System.Collections.Generic.List<System.UInt16> @indices, System.Int32 @indicesStart, System.Int32 @indicesLength, UnityEngine.MeshTopology @topology, System.Int32 @submesh, System.Boolean @calculateBounds, System.Int32 @baseVertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices, @indicesStart, @indicesLength, @topology, @submesh, @calculateBounds, @baseVertex};
            var ___result = RMSetIndices_List_d_UInt16_p__Int32_Int32_MeshTopology_Int32_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] @desc, System.Int32 @start, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RMSetSubMeshes_SubMeshDescriptorArray_Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @flags};
            var ___result = RMSetSubMeshes_SubMeshDescriptorArray_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> @desc, System.Int32 @start, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @start, @count, @flags};
            var ___result = RMSetSubMeshes_List_d_SubMeshDescriptor_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc, @flags};
            var ___result = RMSetSubMeshes_List_d_SubMeshDescriptor_p__MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @desc, System.Int32 @start, System.Int32 @count, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desc.Value, @start, @count, @flags};
            var ___result = RMSetSubMeshes_GT_NativeArray_d_T_p__Int32_Int32_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSubMeshes<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @desc, UnityEngine.Rendering.MeshUpdateFlags @flags) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@desc.Value, @flags};
            var ___result = RMSetSubMeshes_GT_NativeArray_d_T_p__MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBindposes(System.Collections.Generic.List<UnityEngine.Matrix4x4> @bindposes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindposes};
            var ___result = RMGetBindposes_List_d_Matrix4x4_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> @boneWeights)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@boneWeights};
            var ___result = RMGetBoneWeights_List_d_BoneWeight_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Boolean @keepVertexLayout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keepVertexLayout};
            var ___result = RMClear_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecalculateBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateNormals()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecalculateNormals.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateTangents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecalculateTangents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMRecalculateBounds_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMRecalculateNormals_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMRecalculateTangents_MeshUpdateFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateUVDistributionMetric(System.Int32 @uvSetIndex, System.Single @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvSetIndex, @uvAreaThreshold};
            var ___result = RMRecalculateUVDistributionMetric_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateUVDistributionMetrics(System.Single @uvAreaThreshold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvAreaThreshold};
            var ___result = RMRecalculateUVDistributionMetrics_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDynamic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDynamic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UploadMeshData(System.Boolean @markNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@markNoLongerReadable};
            var ___result = RMUploadMeshData_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Optimize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOptimize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeIndexBuffers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOptimizeIndexBuffers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OptimizeReorderVertexBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOptimizeReorderVertexBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.MeshTopology GetTopology(System.Int32 @submesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@submesh};
            var ___result = RMGetTopology_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.MeshTopology>(___result);
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[] @combine, System.Boolean @mergeSubMeshes, System.Boolean @useMatrices, System.Boolean @hasLightmapData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes, @useMatrices, @hasLightmapData};
            var ___result = RMCombineMeshes_CombineInstanceArray_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[] @combine, System.Boolean @mergeSubMeshes, System.Boolean @useMatrices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes, @useMatrices};
            var ___result = RMCombineMeshes_CombineInstanceArray_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[] @combine, System.Boolean @mergeSubMeshes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine, @mergeSubMeshes};
            var ___result = RMCombineMeshes_CombineInstanceArray_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CombineMeshes(UnityEngine.CombineInstance[] @combine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combine};
            var ___result = RMCombineMeshes_CombineInstanceArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetVertexAttribute_Injected(System.Int32 @index, out UnityEngine.Rendering.VertexAttributeDescriptor @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret};
            var ___result = RMGetVertexAttribute_Injected_Int32_Out_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rendering.VertexAttributeDescriptor)___parameters[1];

            
        }


        public virtual void GetBlendShapeOffsetInternal_Injected(System.Int32 @index, out Hvak.Editor.Refleaction.RUnityEngine.RBlendShape @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret.Value};
            var ___result = RMGetBlendShapeOffsetInternal_Injected_Int32_Out_BlendShape.Invoke(___genericsType, ___parameters);
			@ret = new Hvak.Editor.Refleaction.RUnityEngine.RBlendShape(___parameters[1]);

            
        }


        public virtual void GetReadOnlySafetyHandle_Injected(Hvak.Editor.Refleaction.RUnityEngine.RMesh.RSafetyHandleIndex @index, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index.Value, @ret};
            var ___result = RMGetReadOnlySafetyHandle_Injected_SafetyHandleIndex_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public virtual void SetSubMesh_Injected(System.Int32 @index, ref UnityEngine.Rendering.SubMeshDescriptor @desc, UnityEngine.Rendering.MeshUpdateFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @desc, @flags};
            var ___result = RMSetSubMesh_Injected_Int32_Ref_SubMeshDescriptor_MeshUpdateFlags.Invoke(___genericsType, ___parameters);
			@desc = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[1];

            
        }


        public virtual void GetSubMesh_Injected(System.Int32 @index, out UnityEngine.Rendering.SubMeshDescriptor @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @ret};
            var ___result = RMGetSubMesh_Injected_Int32_Out_SubMeshDescriptor.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rendering.SubMeshDescriptor)___parameters[1];

            
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_bounds_Injected(ref UnityEngine.Bounds @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_bounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
