using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore
{
	/// <summary>
	/// System.Diagnostics.SymbolStore.SymbolToken
	/// </summary>
    public partial class RSymbolToken : RMember //
    {

		/// <summary>
		/// System.Int32 _token
		/// </summary>
		protected RField r__token;
		public virtual RField R_token
		{
			get
			{
				if(r__token == null)
				{
					r__token = new(this, "_token");
					r__token.SetBelong(this.instance);
				}
				return r__token;
			}
		}

		/// <summary>
		/// Int32 GetToken()
		/// </summary>
		protected RMethod r_GetToken;
		public virtual RMethod RGetToken
		{
			get
			{
				if(r_GetToken == null)
				{
					r_GetToken = new(this, "GetToken", 0);
					r_GetToken.SetBelong(this.instance);
				}
				return r_GetToken;
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
		/// Boolean Equals(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_Equals_SymbolToken;
		public virtual RMethod REquals_SymbolToken
		{
			get
			{
				if(r_Equals_SymbolToken == null)
				{
					r_Equals_SymbolToken = new(this, "Equals", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_Equals_SymbolToken.SetBelong(this.instance);
				}
				return r_Equals_SymbolToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Diagnostics.SymbolStore.SymbolToken, System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected static RMethod r_op_Equality_SymbolToken_SymbolToken;
		public static RMethod Rop_Equality_SymbolToken_SymbolToken
		{
			get
			{
				if(r_op_Equality_SymbolToken_SymbolToken == null)
				{
					r_op_Equality_SymbolToken_SymbolToken = new(typeof(System.Diagnostics.SymbolStore.SymbolToken), "op_Equality", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_op_Equality_SymbolToken_SymbolToken.SetBelong(null);
				}
				return r_op_Equality_SymbolToken_SymbolToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Diagnostics.SymbolStore.SymbolToken, System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected static RMethod r_op_Inequality_SymbolToken_SymbolToken;
		public static RMethod Rop_Inequality_SymbolToken_SymbolToken
		{
			get
			{
				if(r_op_Inequality_SymbolToken_SymbolToken == null)
				{
					r_op_Inequality_SymbolToken_SymbolToken = new(typeof(System.Diagnostics.SymbolStore.SymbolToken), "op_Inequality", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_op_Inequality_SymbolToken_SymbolToken.SetBelong(null);
				}
				return r_op_Inequality_SymbolToken_SymbolToken;
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


        public RSymbolToken() : base("System.Diagnostics.SymbolStore.SymbolToken")
        {
        }

        public RSymbolToken(System.Object instance) : base("System.Diagnostics.SymbolStore.SymbolToken")
		{
            SetInstance(instance);
		}

        public RSymbolToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSymbolToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetToken.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Diagnostics.SymbolStore.SymbolToken  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_SymbolToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Diagnostics.SymbolStore.SymbolToken  @a, System.Diagnostics.SymbolStore.SymbolToken  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_SymbolToken_SymbolToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Diagnostics.SymbolStore.SymbolToken  @a, System.Diagnostics.SymbolStore.SymbolToken  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_SymbolToken_SymbolToken.Invoke(___genericsType, ___parameters);

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
