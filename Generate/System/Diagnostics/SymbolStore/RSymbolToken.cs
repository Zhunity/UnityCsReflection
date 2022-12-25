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
		protected RMethod r_RGetToken;
		public virtual RMethod RGetToken
		{
			get
			{
				if(r_RGetToken == null)
				{
					r_RGetToken = new(this, "GetToken", 0);
					r_RGetToken.SetBelong(this.instance);
				}
				return r_RGetToken;
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
		/// Boolean Equals(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_REquals_SymbolToken;
		public virtual RMethod REquals_SymbolToken
		{
			get
			{
				if(r_REquals_SymbolToken == null)
				{
					r_REquals_SymbolToken = new(this, "Equals", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_REquals_SymbolToken.SetBelong(this.instance);
				}
				return r_REquals_SymbolToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Diagnostics.SymbolStore.SymbolToken, System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected static RMethod r_Rop_Equality_SymbolToken_SymbolToken;
		public static RMethod Rop_Equality_SymbolToken_SymbolToken
		{
			get
			{
				if(r_Rop_Equality_SymbolToken_SymbolToken == null)
				{
					r_Rop_Equality_SymbolToken_SymbolToken = new(typeof(System.Diagnostics.SymbolStore.SymbolToken), "op_Equality", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_Rop_Equality_SymbolToken_SymbolToken.SetBelong(null);
				}
				return r_Rop_Equality_SymbolToken_SymbolToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Diagnostics.SymbolStore.SymbolToken, System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected static RMethod r_Rop_Inequality_SymbolToken_SymbolToken;
		public static RMethod Rop_Inequality_SymbolToken_SymbolToken
		{
			get
			{
				if(r_Rop_Inequality_SymbolToken_SymbolToken == null)
				{
					r_Rop_Inequality_SymbolToken_SymbolToken = new(typeof(System.Diagnostics.SymbolStore.SymbolToken), "op_Inequality", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_Rop_Inequality_SymbolToken_SymbolToken.SetBelong(null);
				}
				return r_Rop_Inequality_SymbolToken_SymbolToken;
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
