
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.MeshWriteData
	/// </summary>
    public partial class RMeshWriteData : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.MeshWriteData);
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


		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] m_Vertices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_Fm_Vertices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFm_Vertices
		{
			get
			{
				if(r_Fm_Vertices == null)
				{
					r_Fm_Vertices = new(this, "m_Vertices");
				}
				return r_Fm_Vertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] m_Indices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> r_Fm_Indices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> RFm_Indices
		{
			get
			{
				if(r_Fm_Indices == null)
				{
					r_Fm_Indices = new(this, "m_Indices");
				}
				return r_Fm_Indices;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_UVRegion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_UVRegion;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_UVRegion
		{
			get
			{
				if(r_Fm_UVRegion == null)
				{
					r_Fm_UVRegion = new(this, "m_UVRegion");
				}
				return r_Fm_UVRegion;
			}
		}

		/// <summary>
		/// System.Int32 currentIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrentIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrentIndex
		{
			get
			{
				if(r_FcurrentIndex == null)
				{
					r_FcurrentIndex = new(this, "currentIndex");
				}
				return r_FcurrentIndex;
			}
		}

		/// <summary>
		/// System.Int32 currentVertex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrentVertex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrentVertex
		{
			get
			{
				if(r_FcurrentVertex == null)
				{
					r_FcurrentVertex = new(this, "currentVertex");
				}
				return r_FcurrentVertex;
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
		/// Int32 indexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PindexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPindexCount
		{
			get
			{
				if(r_PindexCount == null)
				{
					r_PindexCount = new(this, "indexCount", -1);
				}
				return r_PindexCount;
			}
		}

		/// <summary>
		/// UnityEngine.Rect uvRegion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PuvRegion;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPuvRegion
		{
			get
			{
				if(r_PuvRegion == null)
				{
					r_PuvRegion = new(this, "uvRegion", -1);
				}
				return r_PuvRegion;
			}
		}

		/// <summary>
		/// Void SetNextVertex(UnityEngine.UIElements.Vertex)
		/// </summary>
		protected RMethod r_MSetNextVertex_Vertex;
		public virtual RMethod RMSetNextVertex_Vertex
		{
			get
			{
				if(r_MSetNextVertex_Vertex == null)
				{
					r_MSetNextVertex_Vertex = new(this, "SetNextVertex", 0, typeof(UnityEngine.UIElements.Vertex));
				}
				return r_MSetNextVertex_Vertex;
			}
		}

		/// <summary>
		/// Void SetNextIndex(UInt16)
		/// </summary>
		protected RMethod r_MSetNextIndex_UInt16;
		public virtual RMethod RMSetNextIndex_UInt16
		{
			get
			{
				if(r_MSetNextIndex_UInt16 == null)
				{
					r_MSetNextIndex_UInt16 = new(this, "SetNextIndex", 0, typeof(System.UInt16));
				}
				return r_MSetNextIndex_UInt16;
			}
		}

		/// <summary>
		/// Void SetAllVertices(UnityEngine.UIElements.Vertex[])
		/// </summary>
		protected RMethod r_MSetAllVertices_VertexArray;
		public virtual RMethod RMSetAllVertices_VertexArray
		{
			get
			{
				if(r_MSetAllVertices_VertexArray == null)
				{
					r_MSetAllVertices_VertexArray = new(this, "SetAllVertices", 0, typeof(UnityEngine.UIElements.Vertex).MakeArrayType());
				}
				return r_MSetAllVertices_VertexArray;
			}
		}

		/// <summary>
		/// Void SetAllVertices(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex])
		/// </summary>
		protected RMethod r_MSetAllVertices_NativeSlice_d_Vertex_p_;
		public virtual RMethod RMSetAllVertices_NativeSlice_d_Vertex_p_
		{
			get
			{
				if(r_MSetAllVertices_NativeSlice_d_Vertex_p_ == null)
				{
					r_MSetAllVertices_NativeSlice_d_Vertex_p_ = new(this, "SetAllVertices", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(UnityEngine.UIElements.Vertex)));
				}
				return r_MSetAllVertices_NativeSlice_d_Vertex_p_;
			}
		}

		/// <summary>
		/// Void SetAllIndices(UInt16[])
		/// </summary>
		protected RMethod r_MSetAllIndices_UInt16Array;
		public virtual RMethod RMSetAllIndices_UInt16Array
		{
			get
			{
				if(r_MSetAllIndices_UInt16Array == null)
				{
					r_MSetAllIndices_UInt16Array = new(this, "SetAllIndices", 0, typeof(System.UInt16).MakeArrayType());
				}
				return r_MSetAllIndices_UInt16Array;
			}
		}

		/// <summary>
		/// Void SetAllIndices(Unity.Collections.NativeSlice`1[System.UInt16])
		/// </summary>
		protected RMethod r_MSetAllIndices_NativeSlice_d_UInt16_p_;
		public virtual RMethod RMSetAllIndices_NativeSlice_d_UInt16_p_
		{
			get
			{
				if(r_MSetAllIndices_NativeSlice_d_UInt16_p_ == null)
				{
					r_MSetAllIndices_NativeSlice_d_UInt16_p_ = new(this, "SetAllIndices", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(System.UInt16)));
				}
				return r_MSetAllIndices_NativeSlice_d_UInt16_p_;
			}
		}

		/// <summary>
		/// Void Reset(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[System.UInt16])
		/// </summary>
		protected RMethod r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_;
		public virtual RMethod RMReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_
		{
			get
			{
				if(r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_ == null)
				{
					r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_ = new(this, "Reset", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(UnityEngine.UIElements.Vertex)),  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(System.UInt16)));
				}
				return r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_;
			}
		}

		/// <summary>
		/// Void Reset(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[System.UInt16], UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect;
		public virtual RMethod RMReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect
		{
			get
			{
				if(r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect == null)
				{
					r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect = new(this, "Reset", 0,  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(UnityEngine.UIElements.Vertex)),  ReflectionUtils.GetType("Unity.Collections.NativeSlice`1").MakeGenericType(typeof(System.UInt16)), typeof(UnityEngine.Rect));
				}
				return r_MReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect;
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


        public virtual void SetNextVertex(UnityEngine.UIElements.Vertex @vertex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertex};
            var ___result = RMSetNextVertex_Vertex.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNextIndex(System.UInt16 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSetNextIndex_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllVertices(UnityEngine.UIElements.Vertex[] @vertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices};
            var ___result = RMSetAllVertices_VertexArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllVertices(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> @vertices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value};
            var ___result = RMSetAllVertices_NativeSlice_d_Vertex_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllIndices(System.UInt16[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices};
            var ___result = RMSetAllIndices_UInt16Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllIndices(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indices.Value};
            var ___result = RMSetAllIndices_NativeSlice_d_UInt16_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> @vertices, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value, @indices.Value};
            var ___result = RMReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> @vertices, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> @indices, UnityEngine.Rect @uvRegion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value, @indices.Value, @uvRegion};
            var ___result = RMReset_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
