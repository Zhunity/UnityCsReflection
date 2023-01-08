using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.MeshInfo
	/// </summary>
    public partial class RMeshInfo : RMember //
    {

		/// <summary>
		/// UnityEngine.Color32 k_DefaultColor
		/// </summary>
		protected static RUnityEngine.RColor32 r_k_DefaultColor;
		public static RUnityEngine.RColor32 Rk_DefaultColor
		{
			get
			{
				if(r_k_DefaultColor == null)
				{
					r_k_DefaultColor = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.MeshInfo"), "k_DefaultColor");
					r_k_DefaultColor.SetBelong(null);
				}
				return r_k_DefaultColor;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 k_DefaultNormal
		/// </summary>
		protected static RUnityEngine.RVector3 r_k_DefaultNormal;
		public static RUnityEngine.RVector3 Rk_DefaultNormal
		{
			get
			{
				if(r_k_DefaultNormal == null)
				{
					r_k_DefaultNormal = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.MeshInfo"), "k_DefaultNormal");
					r_k_DefaultNormal.SetBelong(null);
				}
				return r_k_DefaultNormal;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 k_DefaultTangent
		/// </summary>
		protected static RUnityEngine.RVector4 r_k_DefaultTangent;
		public static RUnityEngine.RVector4 Rk_DefaultTangent
		{
			get
			{
				if(r_k_DefaultTangent == null)
				{
					r_k_DefaultTangent = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.MeshInfo"), "k_DefaultTangent");
					r_k_DefaultTangent.SetBelong(null);
				}
				return r_k_DefaultTangent;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds k_DefaultBounds
		/// </summary>
		protected static RUnityEngine.RBounds r_k_DefaultBounds;
		public static RUnityEngine.RBounds Rk_DefaultBounds
		{
			get
			{
				if(r_k_DefaultBounds == null)
				{
					r_k_DefaultBounds = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.MeshInfo"), "k_DefaultBounds");
					r_k_DefaultBounds.SetBelong(null);
				}
				return r_k_DefaultBounds;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh mesh
		/// </summary>
		protected RUnityEngine.RMesh r_mesh;
		public virtual RUnityEngine.RMesh Rmesh
		{
			get
			{
				if(r_mesh == null)
				{
					r_mesh = new(this, "mesh");
					r_mesh.SetBelong(this.instance);
				}
				return r_mesh;
			}
		}

		/// <summary>
		/// System.Int32 vertexCount
		/// </summary>
		protected RField r_vertexCount;
		public virtual RField RvertexCount
		{
			get
			{
				if(r_vertexCount == null)
				{
					r_vertexCount = new(this, "vertexCount");
					r_vertexCount.SetBelong(this.instance);
				}
				return r_vertexCount;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] vertices
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector3> r_vertices;
		public virtual RFieldArray<RUnityEngine.RVector3> Rvertices
		{
			get
			{
				if(r_vertices == null)
				{
					r_vertices = new(this, "vertices");
					r_vertices.SetBelong(this.instance);
				}
				return r_vertices;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] normals
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector3> r_normals;
		public virtual RFieldArray<RUnityEngine.RVector3> Rnormals
		{
			get
			{
				if(r_normals == null)
				{
					r_normals = new(this, "normals");
					r_normals.SetBelong(this.instance);
				}
				return r_normals;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] tangents
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector4> r_tangents;
		public virtual RFieldArray<RUnityEngine.RVector4> Rtangents
		{
			get
			{
				if(r_tangents == null)
				{
					r_tangents = new(this, "tangents");
					r_tangents.SetBelong(this.instance);
				}
				return r_tangents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] uvs0
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector4> r_uvs0;
		public virtual RFieldArray<RUnityEngine.RVector4> Ruvs0
		{
			get
			{
				if(r_uvs0 == null)
				{
					r_uvs0 = new(this, "uvs0");
					r_uvs0.SetBelong(this.instance);
				}
				return r_uvs0;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uvs2
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector2> r_uvs2;
		public virtual RFieldArray<RUnityEngine.RVector2> Ruvs2
		{
			get
			{
				if(r_uvs2 == null)
				{
					r_uvs2 = new(this, "uvs2");
					r_uvs2.SetBelong(this.instance);
				}
				return r_uvs2;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] colors32
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor32> r_colors32;
		public virtual RFieldArray<RUnityEngine.RColor32> Rcolors32
		{
			get
			{
				if(r_colors32 == null)
				{
					r_colors32 = new(this, "colors32");
					r_colors32.SetBelong(this.instance);
				}
				return r_colors32;
			}
		}

		/// <summary>
		/// System.Int32[] triangles
		/// </summary>
		protected RFieldArray<RField> r_triangles;
		public virtual RFieldArray<RField> Rtriangles
		{
			get
			{
				if(r_triangles == null)
				{
					r_triangles = new(this, "triangles");
					r_triangles.SetBelong(this.instance);
				}
				return r_triangles;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material");
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// Void ResizeMeshInfo(Int32)
		/// </summary>
		protected RMethod r_ResizeMeshInfo_Int32;
		public virtual RMethod RResizeMeshInfo_Int32
		{
			get
			{
				if(r_ResizeMeshInfo_Int32 == null)
				{
					r_ResizeMeshInfo_Int32 = new(this, "ResizeMeshInfo", 0, typeof(System.Int32));
					r_ResizeMeshInfo_Int32.SetBelong(this.instance);
				}
				return r_ResizeMeshInfo_Int32;
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
		/// Void ClearUnusedVertices()
		/// </summary>
		protected RMethod r_ClearUnusedVertices;
		public virtual RMethod RClearUnusedVertices
		{
			get
			{
				if(r_ClearUnusedVertices == null)
				{
					r_ClearUnusedVertices = new(this, "ClearUnusedVertices", 0);
					r_ClearUnusedVertices.SetBelong(this.instance);
				}
				return r_ClearUnusedVertices;
			}
		}

		/// <summary>
		/// Void ClearUnusedVertices(Int32, Boolean)
		/// </summary>
		protected RMethod r_ClearUnusedVertices_Int32_Boolean;
		public virtual RMethod RClearUnusedVertices_Int32_Boolean
		{
			get
			{
				if(r_ClearUnusedVertices_Int32_Boolean == null)
				{
					r_ClearUnusedVertices_Int32_Boolean = new(this, "ClearUnusedVertices", 0, typeof(System.Int32), typeof(System.Boolean));
					r_ClearUnusedVertices_Int32_Boolean.SetBelong(this.instance);
				}
				return r_ClearUnusedVertices_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ClearUnusedVertices(Int32)
		/// </summary>
		protected RMethod r_ClearUnusedVertices_Int32;
		public virtual RMethod RClearUnusedVertices_Int32
		{
			get
			{
				if(r_ClearUnusedVertices_Int32 == null)
				{
					r_ClearUnusedVertices_Int32 = new(this, "ClearUnusedVertices", 0, typeof(System.Int32));
					r_ClearUnusedVertices_Int32.SetBelong(this.instance);
				}
				return r_ClearUnusedVertices_Int32;
			}
		}

		/// <summary>
		/// Void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder)
		/// </summary>
		protected RMethod r_SortGeometry_VertexSortingOrder;
		public virtual RMethod RSortGeometry_VertexSortingOrder
		{
			get
			{
				if(r_SortGeometry_VertexSortingOrder == null)
				{
					r_SortGeometry_VertexSortingOrder = new(this, "SortGeometry", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.VertexSortingOrder"));
					r_SortGeometry_VertexSortingOrder.SetBelong(this.instance);
				}
				return r_SortGeometry_VertexSortingOrder;
			}
		}

		/// <summary>
		/// Void SwapVertexData(Int32, Int32)
		/// </summary>
		protected RMethod r_SwapVertexData_Int32_Int32;
		public virtual RMethod RSwapVertexData_Int32_Int32
		{
			get
			{
				if(r_SwapVertexData_Int32_Int32 == null)
				{
					r_SwapVertexData_Int32_Int32 = new(this, "SwapVertexData", 0, typeof(System.Int32), typeof(System.Int32));
					r_SwapVertexData_Int32_Int32.SetBelong(this.instance);
				}
				return r_SwapVertexData_Int32_Int32;
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


        public RMeshInfo() : base("UnityEngine.TextCore.Text.MeshInfo")
        {
        }

        public RMeshInfo(System.Object instance) : base("UnityEngine.TextCore.Text.MeshInfo")
		{
            SetInstance(instance);
		}

        public RMeshInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResizeMeshInfo(System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RResizeMeshInfo_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Boolean  @uploadChanges)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uploadChanges};
            var ___result = RClear_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearUnusedVertices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearUnusedVertices.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearUnusedVertices(System.Int32  @startIndex, System.Boolean  @updateMesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @updateMesh};
            var ___result = RClearUnusedVertices_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearUnusedVertices(System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RClearUnusedVertices_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortGeometry(RType  @order)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@order.Value};
            var ___result = RSortGeometry_VertexSortingOrder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwapVertexData(System.Int32  @src, System.Int32  @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst};
            var ___result = RSwapVertexData_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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
