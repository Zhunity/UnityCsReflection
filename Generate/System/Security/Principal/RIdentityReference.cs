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
		protected RSystem.RString r_PValue;
		public virtual RSystem.RString RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean IsValidTargetType(System.Type)
		/// </summary>
		protected RMethod r_MIsValidTargetType_Type;
		public virtual RMethod RMIsValidTargetType_Type
		{
			get
			{
				if(r_MIsValidTargetType_Type == null)
				{
					r_MIsValidTargetType_Type = new(this, "IsValidTargetType", 0, typeof(System.Type));
					r_MIsValidTargetType_Type.SetBelong(this.instance);
				}
				return r_MIsValidTargetType_Type;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference Translate(System.Type)
		/// </summary>
		protected RMethod r_MTranslate_Type;
		public virtual RMethod RMTranslate_Type
		{
			get
			{
				if(r_MTranslate_Type == null)
				{
					r_MTranslate_Type = new(this, "Translate", 0, typeof(System.Type));
					r_MTranslate_Type.SetBelong(this.instance);
				}
				return r_MTranslate_Type;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Principal.IdentityReference, System.Security.Principal.IdentityReference)
		/// </summary>
		protected static RMethod r_Mop_Equality_IdentityReference_IdentityReference;
		public static RMethod RMop_Equality_IdentityReference_IdentityReference
		{
			get
			{
				if(r_Mop_Equality_IdentityReference_IdentityReference == null)
				{
					r_Mop_Equality_IdentityReference_IdentityReference = new(typeof(System.Security.Principal.IdentityReference), "op_Equality", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Security.Principal.IdentityReference));
					r_Mop_Equality_IdentityReference_IdentityReference.SetBelong(null);
				}
				return r_Mop_Equality_IdentityReference_IdentityReference;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Principal.IdentityReference, System.Security.Principal.IdentityReference)
		/// </summary>
		protected static RMethod r_Mop_Inequality_IdentityReference_IdentityReference;
		public static RMethod RMop_Inequality_IdentityReference_IdentityReference
		{
			get
			{
				if(r_Mop_Inequality_IdentityReference_IdentityReference == null)
				{
					r_Mop_Inequality_IdentityReference_IdentityReference = new(typeof(System.Security.Principal.IdentityReference), "op_Inequality", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Security.Principal.IdentityReference));
					r_Mop_Inequality_IdentityReference_IdentityReference.SetBelong(null);
				}
				return r_Mop_Inequality_IdentityReference_IdentityReference;
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsValidTargetType(System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RMIsValidTargetType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Principal.IdentityReference Translate(System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RMTranslate_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public static System.Boolean op_Equality(System.Security.Principal.IdentityReference @left, System.Security.Principal.IdentityReference @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_IdentityReference_IdentityReference.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Principal.IdentityReference @left, System.Security.Principal.IdentityReference @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_IdentityReference_IdentityReference.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
