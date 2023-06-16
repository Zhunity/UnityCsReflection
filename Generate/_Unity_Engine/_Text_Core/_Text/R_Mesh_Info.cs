
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.TextCore.Text.MeshInfo
	/// </summary>
    public partial class RMeshInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.MeshInfo");
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


		/// <summary>
		/// UnityEngine.Color32 k_DefaultColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fk_DefaultColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFk_DefaultColor
		{
			get
			{
				if(r_Fk_DefaultColor == null)
				{
					r_Fk_DefaultColor = new(Type, "k_DefaultColor");
				}
				return r_Fk_DefaultColor;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 k_DefaultNormal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fk_DefaultNormal;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFk_DefaultNormal
		{
			get
			{
				if(r_Fk_DefaultNormal == null)
				{
					r_Fk_DefaultNormal = new(Type, "k_DefaultNormal");
				}
				return r_Fk_DefaultNormal;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 k_DefaultTangent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector4 r_Fk_DefaultTangent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector4 RFk_DefaultTangent
		{
			get
			{
				if(r_Fk_DefaultTangent == null)
				{
					r_Fk_DefaultTangent = new(Type, "k_DefaultTangent");
				}
				return r_Fk_DefaultTangent;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds k_DefaultBounds
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RBounds r_Fk_DefaultBounds;
		public static Hvak.Editor.Refleaction.RUnityEngine.RBounds RFk_DefaultBounds
		{
			get
			{
				if(r_Fk_DefaultBounds == null)
				{
					r_Fk_DefaultBounds = new(Type, "k_DefaultBounds");
				}
				return r_Fk_DefaultBounds;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh mesh
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMesh r_Fmesh;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMesh RFmesh
		{
			get
			{
				if(r_Fmesh == null)
				{
					r_Fmesh = new(this, "mesh");
				}
				return r_Fmesh;
			}
		}

		/// <summary>
		/// System.Int32 vertexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvertexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvertexCount
		{
			get
			{
				if(r_FvertexCount == null)
				{
					r_FvertexCount = new(this, "vertexCount");
				}
				return r_FvertexCount;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] vertices
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> r_Fvertices;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> RFvertices
		{
			get
			{
				if(r_Fvertices == null)
				{
					r_Fvertices = new(this, "vertices");
				}
				return r_Fvertices;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] normals
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> r_Fnormals;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector3> RFnormals
		{
			get
			{
				if(r_Fnormals == null)
				{
					r_Fnormals = new(this, "normals");
				}
				return r_Fnormals;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] tangents
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> r_Ftangents;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> RFtangents
		{
			get
			{
				if(r_Ftangents == null)
				{
					r_Ftangents = new(this, "tangents");
				}
				return r_Ftangents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] uvs0
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> r_Fuvs0;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector4> RFuvs0
		{
			get
			{
				if(r_Fuvs0 == null)
				{
					r_Fuvs0 = new(this, "uvs0");
				}
				return r_Fuvs0;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uvs2
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Fuvs2;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RVector2> RFuvs2
		{
			get
			{
				if(r_Fuvs2 == null)
				{
					r_Fuvs2 = new(this, "uvs2");
				}
				return r_Fuvs2;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] colors32
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> r_Fcolors32;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> RFcolors32
		{
			get
			{
				if(r_Fcolors32 == null)
				{
					r_Fcolors32 = new(this, "colors32");
				}
				return r_Fcolors32;
			}
		}

		/// <summary>
		/// System.Int32[] triangles
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Ftriangles;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFtriangles
		{
			get
			{
				if(r_Ftriangles == null)
				{
					r_Ftriangles = new(this, "triangles");
				}
				return r_Ftriangles;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// Void ResizeMeshInfo(Int32)
		/// </summary>
		protected RMethod r_MResizeMeshInfo_Int32;
		public virtual RMethod RMResizeMeshInfo_Int32
		{
			get
			{
				if(r_MResizeMeshInfo_Int32 == null)
				{
					r_MResizeMeshInfo_Int32 = new(this, "ResizeMeshInfo", 0, typeof(System.Int32));
				}
				return r_MResizeMeshInfo_Int32;
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
		/// Void ClearUnusedVertices()
		/// </summary>
		protected RMethod r_MClearUnusedVertices;
		public virtual RMethod RMClearUnusedVertices
		{
			get
			{
				if(r_MClearUnusedVertices == null)
				{
					r_MClearUnusedVertices = new(this, "ClearUnusedVertices", 0);
				}
				return r_MClearUnusedVertices;
			}
		}

		/// <summary>
		/// Void ClearUnusedVertices(Int32, Boolean)
		/// </summary>
		protected RMethod r_MClearUnusedVertices_Int32_Boolean;
		public virtual RMethod RMClearUnusedVertices_Int32_Boolean
		{
			get
			{
				if(r_MClearUnusedVertices_Int32_Boolean == null)
				{
					r_MClearUnusedVertices_Int32_Boolean = new(this, "ClearUnusedVertices", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MClearUnusedVertices_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ClearUnusedVertices(Int32)
		/// </summary>
		protected RMethod r_MClearUnusedVertices_Int32;
		public virtual RMethod RMClearUnusedVertices_Int32
		{
			get
			{
				if(r_MClearUnusedVertices_Int32 == null)
				{
					r_MClearUnusedVertices_Int32 = new(this, "ClearUnusedVertices", 0, typeof(System.Int32));
				}
				return r_MClearUnusedVertices_Int32;
			}
		}

		/// <summary>
		/// Void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder)
		/// </summary>
		protected RMethod r_MSortGeometry_VertexSortingOrder;
		public virtual RMethod RMSortGeometry_VertexSortingOrder
		{
			get
			{
				if(r_MSortGeometry_VertexSortingOrder == null)
				{
					r_MSortGeometry_VertexSortingOrder = new(this, "SortGeometry", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.VertexSortingOrder"));
				}
				return r_MSortGeometry_VertexSortingOrder;
			}
		}

		/// <summary>
		/// Void SwapVertexData(Int32, Int32)
		/// </summary>
		protected RMethod r_MSwapVertexData_Int32_Int32;
		public virtual RMethod RMSwapVertexData_Int32_Int32
		{
			get
			{
				if(r_MSwapVertexData_Int32_Int32 == null)
				{
					r_MSwapVertexData_Int32_Int32 = new(this, "SwapVertexData", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSwapVertexData_Int32_Int32;
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


        public virtual void ResizeMeshInfo(System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMResizeMeshInfo_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear(System.Boolean @uploadChanges)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uploadChanges};
            var ___result = RMClear_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearUnusedVertices()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearUnusedVertices.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearUnusedVertices(System.Int32 @startIndex, System.Boolean @updateMesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @updateMesh};
            var ___result = RMClearUnusedVertices_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearUnusedVertices(System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RMClearUnusedVertices_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortGeometry(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RVertexSortingOrder @order)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@order.Value};
            var ___result = RMSortGeometry_VertexSortingOrder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwapVertexData(System.Int32 @src, System.Int32 @dst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @dst};
            var ___result = RMSwapVertexData_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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
