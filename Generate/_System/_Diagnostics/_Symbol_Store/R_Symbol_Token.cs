
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_token;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_token
		{
			get
			{
				if(r_F_token == null)
				{
					r_F_token = new(this, "_token");
					r_F_token.SetBelong(this.instance);
				}
				return r_F_token;
			}
		}

		/// <summary>
		/// Int32 GetToken()
		/// </summary>
		protected RMethod r_MGetToken;
		public virtual RMethod RMGetToken
		{
			get
			{
				if(r_MGetToken == null)
				{
					r_MGetToken = new(this, "GetToken", 0);
					r_MGetToken.SetBelong(this.instance);
				}
				return r_MGetToken;
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
		/// Boolean Equals(System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected RMethod r_MEquals_SymbolToken;
		public virtual RMethod RMEquals_SymbolToken
		{
			get
			{
				if(r_MEquals_SymbolToken == null)
				{
					r_MEquals_SymbolToken = new(this, "Equals", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_MEquals_SymbolToken.SetBelong(this.instance);
				}
				return r_MEquals_SymbolToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Diagnostics.SymbolStore.SymbolToken, System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected static RMethod r_Mop_Equality_SymbolToken_SymbolToken;
		public static RMethod RMop_Equality_SymbolToken_SymbolToken
		{
			get
			{
				if(r_Mop_Equality_SymbolToken_SymbolToken == null)
				{
					r_Mop_Equality_SymbolToken_SymbolToken = new(typeof(System.Diagnostics.SymbolStore.SymbolToken), "op_Equality", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_Mop_Equality_SymbolToken_SymbolToken.SetBelong(null);
				}
				return r_Mop_Equality_SymbolToken_SymbolToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Diagnostics.SymbolStore.SymbolToken, System.Diagnostics.SymbolStore.SymbolToken)
		/// </summary>
		protected static RMethod r_Mop_Inequality_SymbolToken_SymbolToken;
		public static RMethod RMop_Inequality_SymbolToken_SymbolToken
		{
			get
			{
				if(r_Mop_Inequality_SymbolToken_SymbolToken == null)
				{
					r_Mop_Inequality_SymbolToken_SymbolToken = new(typeof(System.Diagnostics.SymbolStore.SymbolToken), "op_Inequality", 0, typeof(System.Diagnostics.SymbolStore.SymbolToken), typeof(System.Diagnostics.SymbolStore.SymbolToken));
					r_Mop_Inequality_SymbolToken_SymbolToken.SetBelong(null);
				}
				return r_Mop_Inequality_SymbolToken_SymbolToken;
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
            var ___result = RMGetToken.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Diagnostics.SymbolStore.SymbolToken @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_SymbolToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Diagnostics.SymbolStore.SymbolToken @a, System.Diagnostics.SymbolStore.SymbolToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_SymbolToken_SymbolToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Diagnostics.SymbolStore.SymbolToken @a, System.Diagnostics.SymbolStore.SymbolToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_SymbolToken_SymbolToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
