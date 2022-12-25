using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.StringToken
	/// </summary>
    public partial class RStringToken : RMember //
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
		/// Boolean Equals(System.Reflection.Emit.StringToken)
		/// </summary>
		protected RMethod r_REquals_StringToken;
		public virtual RMethod REquals_StringToken
		{
			get
			{
				if(r_REquals_StringToken == null)
				{
					r_REquals_StringToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.StringToken));
					r_REquals_StringToken.SetBelong(this.instance);
				}
				return r_REquals_StringToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.StringToken, System.Reflection.Emit.StringToken)
		/// </summary>
		protected static RMethod r_Rop_Equality_StringToken_StringToken;
		public static RMethod Rop_Equality_StringToken_StringToken
		{
			get
			{
				if(r_Rop_Equality_StringToken_StringToken == null)
				{
					r_Rop_Equality_StringToken_StringToken = new(typeof(System.Reflection.Emit.StringToken), "op_Equality", 0, typeof(System.Reflection.Emit.StringToken), typeof(System.Reflection.Emit.StringToken));
					r_Rop_Equality_StringToken_StringToken.SetBelong(null);
				}
				return r_Rop_Equality_StringToken_StringToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.StringToken, System.Reflection.Emit.StringToken)
		/// </summary>
		protected static RMethod r_Rop_Inequality_StringToken_StringToken;
		public static RMethod Rop_Inequality_StringToken_StringToken
		{
			get
			{
				if(r_Rop_Inequality_StringToken_StringToken == null)
				{
					r_Rop_Inequality_StringToken_StringToken = new(typeof(System.Reflection.Emit.StringToken), "op_Inequality", 0, typeof(System.Reflection.Emit.StringToken), typeof(System.Reflection.Emit.StringToken));
					r_Rop_Inequality_StringToken_StringToken.SetBelong(null);
				}
				return r_Rop_Inequality_StringToken_StringToken;
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


        public RStringToken() : base("System.Reflection.Emit.StringToken")
        {
        }

        public RStringToken(System.Object instance) : base("System.Reflection.Emit.StringToken")
		{
            SetInstance(instance);
		}

        public RStringToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStringToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.StringToken  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_StringToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.StringToken  @a, System.Reflection.Emit.StringToken  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_StringToken_StringToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.StringToken  @a, System.Reflection.Emit.StringToken  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_StringToken_StringToken.Invoke(___genericsType, ___parameters);

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
