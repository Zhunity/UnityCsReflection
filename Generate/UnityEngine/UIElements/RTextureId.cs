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
					r_invalid = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), "invalid");
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
		protected RMethod r_RIsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_RIsValid == null)
				{
					r_RIsValid = new(this, "IsValid", 0);
					r_RIsValid.SetBelong(this.instance);
				}
				return r_RIsValid;
			}
		}

		/// <summary>
		/// Single ConvertToGpu()
		/// </summary>
		protected RMethod r_RConvertToGpu;
		public virtual RMethod RConvertToGpu
		{
			get
			{
				if(r_RConvertToGpu == null)
				{
					r_RConvertToGpu = new(this, "ConvertToGpu", 0);
					r_RConvertToGpu.SetBelong(this.instance);
				}
				return r_RConvertToGpu;
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
		/// Boolean Equals(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_REquals_TextureId;
		public virtual RMethod REquals_TextureId
		{
			get
			{
				if(r_REquals_TextureId == null)
				{
					r_REquals_TextureId = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_REquals_TextureId.SetBelong(this.instance);
				}
				return r_REquals_TextureId;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TextureId, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected static RMethod r_Rop_Equality_TextureId_TextureId;
		public static RMethod Rop_Equality_TextureId_TextureId
		{
			get
			{
				if(r_Rop_Equality_TextureId_TextureId == null)
				{
					r_Rop_Equality_TextureId_TextureId = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_Rop_Equality_TextureId_TextureId.SetBelong(null);
				}
				return r_Rop_Equality_TextureId_TextureId;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TextureId, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected static RMethod r_Rop_Inequality_TextureId_TextureId;
		public static RMethod Rop_Inequality_TextureId_TextureId
		{
			get
			{
				if(r_Rop_Inequality_TextureId_TextureId == null)
				{
					r_Rop_Inequality_TextureId_TextureId = new( ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_Rop_Inequality_TextureId_TextureId.SetBelong(null);
				}
				return r_Rop_Inequality_TextureId_TextureId;
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
