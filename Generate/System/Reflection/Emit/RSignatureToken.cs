using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.SignatureToken
	/// </summary>
    public partial class RSignatureToken : RMember //
    {

		/// <summary>
		/// System.Int32 tokValue
		/// </summary>
		protected RField r_tokValue;
		public virtual RField RtokValue
		{
			get
			{
				if(r_tokValue == null)
				{
					r_tokValue = new(this, "tokValue");
					r_tokValue.SetBelong(this.instance);
				}
				return r_tokValue;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken Empty
		/// </summary>
		protected static RSystem.RReflection.REmit.RSignatureToken r_Empty;
		public static RSystem.RReflection.REmit.RSignatureToken REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.Reflection.Emit.SignatureToken), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// Int32 Token
		/// </summary>
		protected RProperty r_Token;
		public virtual RProperty RToken
		{
			get
			{
				if(r_Token == null)
				{
					r_Token = new(this, "Token", -1);
					r_Token.SetBelong(this.instance);
				}
				return r_Token;
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
		/// Boolean Equals(System.Reflection.Emit.SignatureToken)
		/// </summary>
		protected RMethod r_REquals_SignatureToken;
		public virtual RMethod REquals_SignatureToken
		{
			get
			{
				if(r_REquals_SignatureToken == null)
				{
					r_REquals_SignatureToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.SignatureToken));
					r_REquals_SignatureToken.SetBelong(this.instance);
				}
				return r_REquals_SignatureToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.SignatureToken, System.Reflection.Emit.SignatureToken)
		/// </summary>
		protected static RMethod r_Rop_Equality_SignatureToken_SignatureToken;
		public static RMethod Rop_Equality_SignatureToken_SignatureToken
		{
			get
			{
				if(r_Rop_Equality_SignatureToken_SignatureToken == null)
				{
					r_Rop_Equality_SignatureToken_SignatureToken = new(typeof(System.Reflection.Emit.SignatureToken), "op_Equality", 0, typeof(System.Reflection.Emit.SignatureToken), typeof(System.Reflection.Emit.SignatureToken));
					r_Rop_Equality_SignatureToken_SignatureToken.SetBelong(null);
				}
				return r_Rop_Equality_SignatureToken_SignatureToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.SignatureToken, System.Reflection.Emit.SignatureToken)
		/// </summary>
		protected static RMethod r_Rop_Inequality_SignatureToken_SignatureToken;
		public static RMethod Rop_Inequality_SignatureToken_SignatureToken
		{
			get
			{
				if(r_Rop_Inequality_SignatureToken_SignatureToken == null)
				{
					r_Rop_Inequality_SignatureToken_SignatureToken = new(typeof(System.Reflection.Emit.SignatureToken), "op_Inequality", 0, typeof(System.Reflection.Emit.SignatureToken), typeof(System.Reflection.Emit.SignatureToken));
					r_Rop_Inequality_SignatureToken_SignatureToken.SetBelong(null);
				}
				return r_Rop_Inequality_SignatureToken_SignatureToken;
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


        public RSignatureToken() : base("System.Reflection.Emit.SignatureToken")
        {
        }

        public RSignatureToken(System.Object instance) : base("System.Reflection.Emit.SignatureToken")
		{
            SetInstance(instance);
		}

        public RSignatureToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSignatureToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.SignatureToken  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_SignatureToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.SignatureToken  @a, System.Reflection.Emit.SignatureToken  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_SignatureToken_SignatureToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.SignatureToken  @a, System.Reflection.Emit.SignatureToken  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_SignatureToken_SignatureToken.Invoke(___genericsType, ___parameters);

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
