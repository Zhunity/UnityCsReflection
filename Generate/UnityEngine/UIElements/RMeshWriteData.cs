using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.MeshWriteData
	/// </summary>
    public partial class RMeshWriteData : RMember //
    {

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] m_Vertices
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> r_m_Vertices;
		public virtual RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> Rm_Vertices
		{
			get
			{
				if(r_m_Vertices == null)
				{
					r_m_Vertices = new(this, "m_Vertices");
					r_m_Vertices.SetBelong(this.instance);
				}
				return r_m_Vertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] m_Indices
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RSystem.RUInt16> r_m_Indices;
		public virtual RUnity.RCollections.RNativeSlice<RSystem.RUInt16> Rm_Indices
		{
			get
			{
				if(r_m_Indices == null)
				{
					r_m_Indices = new(this, "m_Indices");
					r_m_Indices.SetBelong(this.instance);
				}
				return r_m_Indices;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_UVRegion
		/// </summary>
		protected RUnityEngine.RRect r_m_UVRegion;
		public virtual RUnityEngine.RRect Rm_UVRegion
		{
			get
			{
				if(r_m_UVRegion == null)
				{
					r_m_UVRegion = new(this, "m_UVRegion");
					r_m_UVRegion.SetBelong(this.instance);
				}
				return r_m_UVRegion;
			}
		}

		/// <summary>
		/// System.Int32 currentIndex
		/// </summary>
		protected RSystem.RInt32 r_currentIndex;
		public virtual RSystem.RInt32 RcurrentIndex
		{
			get
			{
				if(r_currentIndex == null)
				{
					r_currentIndex = new(this, "currentIndex");
					r_currentIndex.SetBelong(this.instance);
				}
				return r_currentIndex;
			}
		}

		/// <summary>
		/// System.Int32 currentVertex
		/// </summary>
		protected RSystem.RInt32 r_currentVertex;
		public virtual RSystem.RInt32 RcurrentVertex
		{
			get
			{
				if(r_currentVertex == null)
				{
					r_currentVertex = new(this, "currentVertex");
					r_currentVertex.SetBelong(this.instance);
				}
				return r_currentVertex;
			}
		}

		/// <summary>
		/// Int32 vertexCount
		/// </summary>
		protected RSystem.RInt32 r_vertexCount;
		public virtual RSystem.RInt32 RvertexCount
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
		/// Int32 indexCount
		/// </summary>
		protected RSystem.RInt32 r_indexCount;
		public virtual RSystem.RInt32 RindexCount
		{
			get
			{
				if(r_indexCount == null)
				{
					r_indexCount = new(this, "indexCount", -1);
					r_indexCount.SetBelong(this.instance);
				}
				return r_indexCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rect uvRegion
		/// </summary>
		protected RUnityEngine.RRect r_uvRegion;
		public virtual RUnityEngine.RRect RuvRegion
		{
			get
			{
				if(r_uvRegion == null)
				{
					r_uvRegion = new(this, "uvRegion", -1);
					r_uvRegion.SetBelong(this.instance);
				}
				return r_uvRegion;
			}
		}

		/// <summary>
		/// Void SetNextVertex(UnityEngine.UIElements.Vertex)
		/// </summary>
		protected RMethod r_SetNextVertex_Vertex;
		public virtual RMethod RSetNextVertex_Vertex
		{
			get
			{
				if(r_SetNextVertex_Vertex == null)
				{
					r_SetNextVertex_Vertex = new(this, "SetNextVertex", 0, typeof(UnityEngine.UIElements.Vertex));
					r_SetNextVertex_Vertex.SetBelong(this.instance);
				}
				return r_SetNextVertex_Vertex;
			}
		}

		/// <summary>
		/// Void SetNextIndex(UInt16)
		/// </summary>
		protected RMethod r_SetNextIndex_UInt16;
		public virtual RMethod RSetNextIndex_UInt16
		{
			get
			{
				if(r_SetNextIndex_UInt16 == null)
				{
					r_SetNextIndex_UInt16 = new(this, "SetNextIndex", 0, typeof(System.UInt16));
					r_SetNextIndex_UInt16.SetBelong(this.instance);
				}
				return r_SetNextIndex_UInt16;
			}
		}

		/// <summary>
		/// Void SetAllVertices(UnityEngine.UIElements.Vertex[])
		/// </summary>
		protected RMethod r_SetAllVertices_VertexArray;
		public virtual RMethod RSetAllVertices_VertexArray
		{
			get
			{
				if(r_SetAllVertices_VertexArray == null)
				{
					r_SetAllVertices_VertexArray = new(this, "SetAllVertices", 0, typeof(UnityEngine.UIElements.Vertex).MakeArrayType());
					r_SetAllVertices_VertexArray.SetBelong(this.instance);
				}
				return r_SetAllVertices_VertexArray;
			}
		}

		/// <summary>
		/// Void SetAllVertices(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex])
		/// </summary>
		protected RMethod r_SetAllVertices_NativeSlice_d_Vertex_p_;
		public virtual RMethod RSetAllVertices_NativeSlice_d_Vertex_p_
		{
			get
			{
				if(r_SetAllVertices_NativeSlice_d_Vertex_p_ == null)
				{
					r_SetAllVertices_NativeSlice_d_Vertex_p_ = new(this, "SetAllVertices", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)));
					r_SetAllVertices_NativeSlice_d_Vertex_p_.SetBelong(this.instance);
				}
				return r_SetAllVertices_NativeSlice_d_Vertex_p_;
			}
		}

		/// <summary>
		/// Void SetAllIndices(UInt16[])
		/// </summary>
		protected RMethod r_SetAllIndices_UInt16Array;
		public virtual RMethod RSetAllIndices_UInt16Array
		{
			get
			{
				if(r_SetAllIndices_UInt16Array == null)
				{
					r_SetAllIndices_UInt16Array = new(this, "SetAllIndices", 0, typeof(System.UInt16).MakeArrayType());
					r_SetAllIndices_UInt16Array.SetBelong(this.instance);
				}
				return r_SetAllIndices_UInt16Array;
			}
		}

		/// <summary>
		/// Void SetAllIndices(Unity.Collections.NativeSlice`1[System.UInt16])
		/// </summary>
		protected RMethod r_SetAllIndices_NativeSlice_d_UInt16_p_;
		public virtual RMethod RSetAllIndices_NativeSlice_d_UInt16_p_
		{
			get
			{
				if(r_SetAllIndices_NativeSlice_d_UInt16_p_ == null)
				{
					r_SetAllIndices_NativeSlice_d_UInt16_p_ = new(this, "SetAllIndices", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)));
					r_SetAllIndices_NativeSlice_d_UInt16_p_.SetBelong(this.instance);
				}
				return r_SetAllIndices_NativeSlice_d_UInt16_p_;
			}
		}

		/// <summary>
		/// Void Reset(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[System.UInt16])
		/// </summary>
		protected RMethod r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_;
		public virtual RMethod RReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_
		{
			get
			{
				if(r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_ == null)
				{
					r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_ = new(this, "Reset", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)));
					r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_.SetBelong(this.instance);
				}
				return r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_;
			}
		}

		/// <summary>
		/// Void Reset(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[System.UInt16], UnityEngine.Rect)
		/// </summary>
		protected RMethod r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect;
		public virtual RMethod RReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect
		{
			get
			{
				if(r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect == null)
				{
					r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect = new(this, "Reset", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)), typeof(UnityEngine.Rect));
					r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect.SetBelong(this.instance);
				}
				return r_Reset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect;
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


        public RMeshWriteData() : base("UnityEngine.UIElements.MeshWriteData")
        {
        }

        public RMeshWriteData(System.Object instance) : base("UnityEngine.UIElements.MeshWriteData")
		{
            SetInstance(instance);
		}

        public RMeshWriteData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshWriteData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetNextVertex(UnityEngine.UIElements.Vertex @vertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertex};
            var ___result = RSetNextVertex_Vertex.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNextIndex(System.UInt16 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSetNextIndex_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllVertices(UnityEngine.UIElements.Vertex[] @vertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices};
            var ___result = RSetAllVertices_VertexArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllVertices(RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value};
            var ___result = RSetAllVertices_NativeSlice_d_Vertex_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllIndices(System.UInt16[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RSetAllIndices_UInt16Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllIndices(RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices.Value};
            var ___result = RSetAllIndices_NativeSlice_d_UInt16_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset(RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertices, RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value, @indices.Value};
            var ___result = RReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset(RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> @vertices, RUnity.RCollections.RNativeSlice<RSystem.RUInt16> @indices, UnityEngine.Rect @uvRegion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value, @indices.Value, @uvRegion};
            var ___result = RReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
