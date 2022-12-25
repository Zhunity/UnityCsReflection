using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.ShaderTagId
	/// </summary>
    public partial class RShaderTagId : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId none
		/// </summary>
		protected static RUnityEngine.RRendering.RShaderTagId r_none;
		public static RUnityEngine.RRendering.RShaderTagId Rnone
		{
			get
			{
				if(r_none == null)
				{
					r_none = new(typeof(UnityEngine.Rendering.ShaderTagId), "none");
					r_none.SetBelong(null);
				}
				return r_none;
			}
		}

		/// <summary>
		/// System.Int32 m_Id
		/// </summary>
		protected RField r_m_Id;
		public virtual RField Rm_Id
		{
			get
			{
				if(r_m_Id == null)
				{
					r_m_Id = new(this, "m_Id");
					r_m_Id.SetBelong(this.instance);
				}
				return r_m_Id;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
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
		/// Boolean Equals(UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected RMethod r_REquals_ShaderTagId;
		public virtual RMethod REquals_ShaderTagId
		{
			get
			{
				if(r_REquals_ShaderTagId == null)
				{
					r_REquals_ShaderTagId = new(this, "Equals", 0, typeof(UnityEngine.Rendering.ShaderTagId));
					r_REquals_ShaderTagId.SetBelong(this.instance);
				}
				return r_REquals_ShaderTagId;
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
		/// Boolean op_Equality(UnityEngine.Rendering.ShaderTagId, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected static RMethod r_Rop_Equality_ShaderTagId_ShaderTagId;
		public static RMethod Rop_Equality_ShaderTagId_ShaderTagId
		{
			get
			{
				if(r_Rop_Equality_ShaderTagId_ShaderTagId == null)
				{
					r_Rop_Equality_ShaderTagId_ShaderTagId = new(typeof(UnityEngine.Rendering.ShaderTagId), "op_Equality", 0, typeof(UnityEngine.Rendering.ShaderTagId), typeof(UnityEngine.Rendering.ShaderTagId));
					r_Rop_Equality_ShaderTagId_ShaderTagId.SetBelong(null);
				}
				return r_Rop_Equality_ShaderTagId_ShaderTagId;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.ShaderTagId, UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected static RMethod r_Rop_Inequality_ShaderTagId_ShaderTagId;
		public static RMethod Rop_Inequality_ShaderTagId_ShaderTagId
		{
			get
			{
				if(r_Rop_Inequality_ShaderTagId_ShaderTagId == null)
				{
					r_Rop_Inequality_ShaderTagId_ShaderTagId = new(typeof(UnityEngine.Rendering.ShaderTagId), "op_Inequality", 0, typeof(UnityEngine.Rendering.ShaderTagId), typeof(UnityEngine.Rendering.ShaderTagId));
					r_Rop_Inequality_ShaderTagId_ShaderTagId.SetBelong(null);
				}
				return r_Rop_Inequality_ShaderTagId_ShaderTagId;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShaderTagId op_Explicit(System.String)
		/// </summary>
		protected static RMethod r_Rop_Explicit_String;
		public static RMethod Rop_Explicit_String
		{
			get
			{
				if(r_Rop_Explicit_String == null)
				{
					r_Rop_Explicit_String = new(typeof(UnityEngine.Rendering.ShaderTagId), "op_Explicit", 0, typeof(System.String));
					r_Rop_Explicit_String.SetBelong(null);
				}
				return r_Rop_Explicit_String;
			}
		}

		/// <summary>
		/// System.String op_Explicit(UnityEngine.Rendering.ShaderTagId)
		/// </summary>
		protected static RMethod r_Rop_Explicit_ShaderTagId;
		public static RMethod Rop_Explicit_ShaderTagId
		{
			get
			{
				if(r_Rop_Explicit_ShaderTagId == null)
				{
					r_Rop_Explicit_ShaderTagId = new(typeof(UnityEngine.Rendering.ShaderTagId), "op_Explicit", 0, typeof(UnityEngine.Rendering.ShaderTagId));
					r_Rop_Explicit_ShaderTagId.SetBelong(null);
				}
				return r_Rop_Explicit_ShaderTagId;
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


        public RShaderTagId() : base("UnityEngine.Rendering.ShaderTagId")
        {
        }

        public RShaderTagId(System.Object instance) : base("UnityEngine.Rendering.ShaderTagId")
		{
            SetInstance(instance);
		}

        public RShaderTagId(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RShaderTagId(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.ShaderTagId  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.ShaderTagId  @tag1, UnityEngine.Rendering.ShaderTagId  @tag2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag1, @tag2};
            var ___result = Rop_Equality_ShaderTagId_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.ShaderTagId  @tag1, UnityEngine.Rendering.ShaderTagId  @tag2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag1, @tag2};
            var ___result = Rop_Inequality_ShaderTagId_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Rendering.ShaderTagId op_Explicit(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = Rop_Explicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.ShaderTagId)___result;
        }


        public static System.String op_Explicit(UnityEngine.Rendering.ShaderTagId  @tagId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tagId};
            var ___result = Rop_Explicit_ShaderTagId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
