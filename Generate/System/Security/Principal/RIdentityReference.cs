using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPrincipal
{
	/// <summary>
	/// System.Security.Principal.IdentityReference
	/// </summary>
    public partial class RIdentityReference : RMember //
    {

		/// <summary>
		/// System.String Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
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
		/// Boolean IsValidTargetType(System.Type)
		/// </summary>
		protected RMethod r_RIsValidTargetType_Type;
		public virtual RMethod RIsValidTargetType_Type
		{
			get
			{
				if(r_RIsValidTargetType_Type == null)
				{
					r_RIsValidTargetType_Type = new(this, "IsValidTargetType", 0, typeof(System.Type));
					r_RIsValidTargetType_Type.SetBelong(this.instance);
				}
				return r_RIsValidTargetType_Type;
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
		/// System.Security.Principal.IdentityReference Translate(System.Type)
		/// </summary>
		protected RMethod r_RTranslate_Type;
		public virtual RMethod RTranslate_Type
		{
			get
			{
				if(r_RTranslate_Type == null)
				{
					r_RTranslate_Type = new(this, "Translate", 0, typeof(System.Type));
					r_RTranslate_Type.SetBelong(this.instance);
				}
				return r_RTranslate_Type;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Principal.IdentityReference, System.Security.Principal.IdentityReference)
		/// </summary>
		protected static RMethod r_Rop_Equality_IdentityReference_IdentityReference;
		public static RMethod Rop_Equality_IdentityReference_IdentityReference
		{
			get
			{
				if(r_Rop_Equality_IdentityReference_IdentityReference == null)
				{
					r_Rop_Equality_IdentityReference_IdentityReference = new(typeof(System.Security.Principal.IdentityReference), "op_Equality", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Security.Principal.IdentityReference));
					r_Rop_Equality_IdentityReference_IdentityReference.SetBelong(null);
				}
				return r_Rop_Equality_IdentityReference_IdentityReference;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Principal.IdentityReference, System.Security.Principal.IdentityReference)
		/// </summary>
		protected static RMethod r_Rop_Inequality_IdentityReference_IdentityReference;
		public static RMethod Rop_Inequality_IdentityReference_IdentityReference
		{
			get
			{
				if(r_Rop_Inequality_IdentityReference_IdentityReference == null)
				{
					r_Rop_Inequality_IdentityReference_IdentityReference = new(typeof(System.Security.Principal.IdentityReference), "op_Inequality", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Security.Principal.IdentityReference));
					r_Rop_Inequality_IdentityReference_IdentityReference.SetBelong(null);
				}
				return r_Rop_Inequality_IdentityReference_IdentityReference;
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


        public RIdentityReference() : base("System.Security.Principal.IdentityReference")
        {
        }

        public RIdentityReference(System.Object instance) : base("System.Security.Principal.IdentityReference")
		{
            SetInstance(instance);
		}

        public RIdentityReference(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIdentityReference(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public virtual System.Boolean IsValidTargetType(System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RIsValidTargetType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Principal.IdentityReference Translate(System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RTranslate_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public static System.Boolean op_Equality(System.Security.Principal.IdentityReference  @left, System.Security.Principal.IdentityReference  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_IdentityReference_IdentityReference.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Principal.IdentityReference  @left, System.Security.Principal.IdentityReference  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_IdentityReference_IdentityReference.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
