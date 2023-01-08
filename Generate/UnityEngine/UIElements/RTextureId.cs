using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextureId
	/// </summary>
    public partial class RTextureId : RMember //
    {

		/// <summary>
		/// System.Int32 m_Index
		/// </summary>
		protected RField r_m_Index;
		public virtual RField Rm_Index
		{
			get
			{
				if(r_m_Index == null)
				{
					r_m_Index = new(this, "m_Index");
					r_m_Index.SetBelong(this.instance);
				}
				return r_m_Index;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId invalid
		/// </summary>
		protected static RUnityEngine.RUIElements.RTextureId r_invalid;
		public static RUnityEngine.RUIElements.RTextureId Rinvalid
		{
			get
			{
				if(r_invalid == null)
				{
					r_invalid = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), "invalid");
					r_invalid.SetBelong(null);
				}
				return r_invalid;
			}
		}

		/// <summary>
		/// Int32 index
		/// </summary>
		protected RProperty r_index;
		public virtual RProperty Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index", -1);
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_IsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_IsValid == null)
				{
					r_IsValid = new(this, "IsValid", 0);
					r_IsValid.SetBelong(this.instance);
				}
				return r_IsValid;
			}
		}

		/// <summary>
		/// Single ConvertToGpu()
		/// </summary>
		protected RMethod r_ConvertToGpu;
		public virtual RMethod RConvertToGpu
		{
			get
			{
				if(r_ConvertToGpu == null)
				{
					r_ConvertToGpu = new(this, "ConvertToGpu", 0);
					r_ConvertToGpu.SetBelong(this.instance);
				}
				return r_ConvertToGpu;
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
		/// Boolean Equals(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_Equals_TextureId;
		public virtual RMethod REquals_TextureId
		{
			get
			{
				if(r_Equals_TextureId == null)
				{
					r_Equals_TextureId = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_Equals_TextureId.SetBelong(this.instance);
				}
				return r_Equals_TextureId;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TextureId, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected static RMethod r_op_Equality_TextureId_TextureId;
		public static RMethod Rop_Equality_TextureId_TextureId
		{
			get
			{
				if(r_op_Equality_TextureId_TextureId == null)
				{
					r_op_Equality_TextureId_TextureId = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_op_Equality_TextureId_TextureId.SetBelong(null);
				}
				return r_op_Equality_TextureId_TextureId;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TextureId, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected static RMethod r_op_Inequality_TextureId_TextureId;
		public static RMethod Rop_Inequality_TextureId_TextureId
		{
			get
			{
				if(r_op_Inequality_TextureId_TextureId == null)
				{
					r_op_Inequality_TextureId_TextureId = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_op_Inequality_TextureId_TextureId.SetBelong(null);
				}
				return r_op_Inequality_TextureId_TextureId;
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


        public RTextureId() : base("UnityEngine.UIElements.TextureId")
        {
        }

        public RTextureId(System.Object instance) : base("UnityEngine.UIElements.TextureId")
		{
            SetInstance(instance);
		}

        public RTextureId(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextureId(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single ConvertToGpu()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConvertToGpu.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RUnityEngine.RUIElements.RTextureId  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_TextureId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(RUnityEngine.RUIElements.RTextureId  @left, RUnityEngine.RUIElements.RTextureId  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Equality_TextureId_TextureId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnityEngine.RUIElements.RTextureId  @left, RUnityEngine.RUIElements.RTextureId  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Inequality_TextureId_TextureId.Invoke(___genericsType, ___parameters);

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
