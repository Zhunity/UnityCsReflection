using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.MonoWin32Resource
	/// </summary>
    public partial class RMonoWin32Resource : RMember //
    {

		/// <summary>
		/// System.Int32 res_type
		/// </summary>
		protected RField r_res_type;
		public virtual RField Rres_type
		{
			get
			{
				if(r_res_type == null)
				{
					r_res_type = new(this, "res_type");
					r_res_type.SetBelong(this.instance);
				}
				return r_res_type;
			}
		}

		/// <summary>
		/// System.Int32 res_id
		/// </summary>
		protected RField r_res_id;
		public virtual RField Rres_id
		{
			get
			{
				if(r_res_id == null)
				{
					r_res_id = new(this, "res_id");
					r_res_id.SetBelong(this.instance);
				}
				return r_res_id;
			}
		}

		/// <summary>
		/// System.Int32 lang_id
		/// </summary>
		protected RField r_lang_id;
		public virtual RField Rlang_id
		{
			get
			{
				if(r_lang_id == null)
				{
					r_lang_id = new(this, "lang_id");
					r_lang_id.SetBelong(this.instance);
				}
				return r_lang_id;
			}
		}

		/// <summary>
		/// System.Byte[] data
		/// </summary>
		protected RFieldArray<RField> r_data;
		public virtual RFieldArray<RField> Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
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


        public RMonoWin32Resource() : base("System.Reflection.Emit.MonoWin32Resource")
        {
        }

        public RMonoWin32Resource(System.Object instance) : base("System.Reflection.Emit.MonoWin32Resource")
		{
            SetInstance(instance);
		}

        public RMonoWin32Resource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMonoWin32Resource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
