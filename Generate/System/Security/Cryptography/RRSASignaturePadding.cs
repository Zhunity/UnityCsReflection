using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.RSASignaturePadding
	/// </summary>
    public partial class RRSASignaturePadding : RMember //
    {

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding s_pkcs1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSASignaturePadding r_s_pkcs1;
		public static RSystem.RSecurity.RCryptography.RRSASignaturePadding Rs_pkcs1
		{
			get
			{
				if(r_s_pkcs1 == null)
				{
					r_s_pkcs1 = new(typeof(System.Security.Cryptography.RSASignaturePadding), "s_pkcs1");
					r_s_pkcs1.SetBelong(null);
				}
				return r_s_pkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding s_pss
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSASignaturePadding r_s_pss;
		public static RSystem.RSecurity.RCryptography.RRSASignaturePadding Rs_pss
		{
			get
			{
				if(r_s_pss == null)
				{
					r_s_pss = new(typeof(System.Security.Cryptography.RSASignaturePadding), "s_pss");
					r_s_pss.SetBelong(null);
				}
				return r_s_pss;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePaddingMode _mode
		/// </summary>
		protected RField r__mode;
		public virtual RField R_mode
		{
			get
			{
				if(r__mode == null)
				{
					r__mode = new(this, "_mode");
					r__mode.SetBelong(this.instance);
				}
				return r__mode;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding Pkcs1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSASignaturePadding r_Pkcs1;
		public static RSystem.RSecurity.RCryptography.RRSASignaturePadding RPkcs1
		{
			get
			{
				if(r_Pkcs1 == null)
				{
					r_Pkcs1 = new(typeof(System.Security.Cryptography.RSASignaturePadding), "Pkcs1", -1);
					r_Pkcs1.SetBelong(null);
				}
				return r_Pkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding Pss
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSASignaturePadding r_Pss;
		public static RSystem.RSecurity.RCryptography.RRSASignaturePadding RPss
		{
			get
			{
				if(r_Pss == null)
				{
					r_Pss = new(typeof(System.Security.Cryptography.RSASignaturePadding), "Pss", -1);
					r_Pss.SetBelong(null);
				}
				return r_Pss;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePaddingMode Mode
		/// </summary>
		protected RProperty r_Mode;
		public virtual RProperty RMode
		{
			get
			{
				if(r_Mode == null)
				{
					r_Mode = new(this, "Mode", -1);
					r_Mode.SetBelong(this.instance);
				}
				return r_Mode;
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
		/// Boolean Equals(System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_REquals_RSASignaturePadding;
		public virtual RMethod REquals_RSASignaturePadding
		{
			get
			{
				if(r_REquals_RSASignaturePadding == null)
				{
					r_REquals_RSASignaturePadding = new(this, "Equals", 0, typeof(System.Security.Cryptography.RSASignaturePadding));
					r_REquals_RSASignaturePadding.SetBelong(this.instance);
				}
				return r_REquals_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Cryptography.RSASignaturePadding, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected static RMethod r_Rop_Equality_RSASignaturePadding_RSASignaturePadding;
		public static RMethod Rop_Equality_RSASignaturePadding_RSASignaturePadding
		{
			get
			{
				if(r_Rop_Equality_RSASignaturePadding_RSASignaturePadding == null)
				{
					r_Rop_Equality_RSASignaturePadding_RSASignaturePadding = new(typeof(System.Security.Cryptography.RSASignaturePadding), "op_Equality", 0, typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_Rop_Equality_RSASignaturePadding_RSASignaturePadding.SetBelong(null);
				}
				return r_Rop_Equality_RSASignaturePadding_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Cryptography.RSASignaturePadding, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected static RMethod r_Rop_Inequality_RSASignaturePadding_RSASignaturePadding;
		public static RMethod Rop_Inequality_RSASignaturePadding_RSASignaturePadding
		{
			get
			{
				if(r_Rop_Inequality_RSASignaturePadding_RSASignaturePadding == null)
				{
					r_Rop_Inequality_RSASignaturePadding_RSASignaturePadding = new(typeof(System.Security.Cryptography.RSASignaturePadding), "op_Inequality", 0, typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Security.Cryptography.RSASignaturePadding));
					r_Rop_Inequality_RSASignaturePadding_RSASignaturePadding.SetBelong(null);
				}
				return r_Rop_Inequality_RSASignaturePadding_RSASignaturePadding;
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


        public RRSASignaturePadding() : base("System.Security.Cryptography.RSASignaturePadding")
        {
        }

        public RRSASignaturePadding(System.Object instance) : base("System.Security.Cryptography.RSASignaturePadding")
		{
            SetInstance(instance);
		}

        public RRSASignaturePadding(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRSASignaturePadding(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Boolean Equals(System.Security.Cryptography.RSASignaturePadding  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Security.Cryptography.RSASignaturePadding  @left, System.Security.Cryptography.RSASignaturePadding  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_RSASignaturePadding_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Cryptography.RSASignaturePadding  @left, System.Security.Cryptography.RSASignaturePadding  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_RSASignaturePadding_RSASignaturePadding.Invoke(___genericsType, ___parameters);

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
