using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BlendShape
	/// </summary>
    public partial class RBlendShape : RMember //
    {

		/// <summary>
		/// System.UInt32 m_FirstVertex
		/// </summary>
		protected RField r_m_FirstVertex;
		public virtual RField Rm_FirstVertex
		{
			get
			{
				if(r_m_FirstVertex == null)
				{
					r_m_FirstVertex = new(this, "m_FirstVertex");
					r_m_FirstVertex.SetBelong(this.instance);
				}
				return r_m_FirstVertex;
			}
		}

		/// <summary>
		/// System.UInt32 m_VertexCount
		/// </summary>
		protected RField r_m_VertexCount;
		public virtual RField Rm_VertexCount
		{
			get
			{
				if(r_m_VertexCount == null)
				{
					r_m_VertexCount = new(this, "m_VertexCount");
					r_m_VertexCount.SetBelong(this.instance);
				}
				return r_m_VertexCount;
			}
		}

		/// <summary>
		/// System.Boolean m_HasNormals
		/// </summary>
		protected RField r_m_HasNormals;
		public virtual RField Rm_HasNormals
		{
			get
			{
				if(r_m_HasNormals == null)
				{
					r_m_HasNormals = new(this, "m_HasNormals");
					r_m_HasNormals.SetBelong(this.instance);
				}
				return r_m_HasNormals;
			}
		}

		/// <summary>
		/// System.Boolean m_HasTangents
		/// </summary>
		protected RField r_m_HasTangents;
		public virtual RField Rm_HasTangents
		{
			get
			{
				if(r_m_HasTangents == null)
				{
					r_m_HasTangents = new(this, "m_HasTangents");
					r_m_HasTangents.SetBelong(this.instance);
				}
				return r_m_HasTangents;
			}
		}

		/// <summary>
		/// UInt32 firstVertex
		/// </summary>
		protected RProperty r_firstVertex;
		public virtual RProperty RfirstVertex
		{
			get
			{
				if(r_firstVertex == null)
				{
					r_firstVertex = new(this, "firstVertex", -1);
					r_firstVertex.SetBelong(this.instance);
				}
				return r_firstVertex;
			}
		}

		/// <summary>
		/// UInt32 vertexCount
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
		/// Boolean hasNormals
		/// </summary>
		protected RProperty r_hasNormals;
		public virtual RProperty RhasNormals
		{
			get
			{
				if(r_hasNormals == null)
				{
					r_hasNormals = new(this, "hasNormals", -1);
					r_hasNormals.SetBelong(this.instance);
				}
				return r_hasNormals;
			}
		}

		/// <summary>
		/// Boolean hasTangents
		/// </summary>
		protected RProperty r_hasTangents;
		public virtual RProperty RhasTangents
		{
			get
			{
				if(r_hasTangents == null)
				{
					r_hasTangents = new(this, "hasTangents", -1);
					r_hasTangents.SetBelong(this.instance);
				}
				return r_hasTangents;
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


        public RBlendShape() : base("UnityEngine.BlendShape")
        {
        }

        public RBlendShape(System.Object instance) : base("UnityEngine.BlendShape")
		{
            SetInstance(instance);
		}

        public RBlendShape(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBlendShape(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
