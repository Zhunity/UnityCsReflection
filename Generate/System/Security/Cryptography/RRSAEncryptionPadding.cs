using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.RSAEncryptionPadding
	/// </summary>
    public partial class RRSAEncryptionPadding : RMember //
    {

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_pkcs1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_s_pkcs1;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding Rs_pkcs1
		{
			get
			{
				if(r_s_pkcs1 == null)
				{
					r_s_pkcs1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_pkcs1");
					r_s_pkcs1.SetBelong(null);
				}
				return r_s_pkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_s_oaepSHA1;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding Rs_oaepSHA1
		{
			get
			{
				if(r_s_oaepSHA1 == null)
				{
					r_s_oaepSHA1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA1");
					r_s_oaepSHA1.SetBelong(null);
				}
				return r_s_oaepSHA1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA256
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_s_oaepSHA256;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding Rs_oaepSHA256
		{
			get
			{
				if(r_s_oaepSHA256 == null)
				{
					r_s_oaepSHA256 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA256");
					r_s_oaepSHA256.SetBelong(null);
				}
				return r_s_oaepSHA256;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA384
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_s_oaepSHA384;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding Rs_oaepSHA384
		{
			get
			{
				if(r_s_oaepSHA384 == null)
				{
					r_s_oaepSHA384 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA384");
					r_s_oaepSHA384.SetBelong(null);
				}
				return r_s_oaepSHA384;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA512
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_s_oaepSHA512;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding Rs_oaepSHA512
		{
			get
			{
				if(r_s_oaepSHA512 == null)
				{
					r_s_oaepSHA512 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA512");
					r_s_oaepSHA512.SetBelong(null);
				}
				return r_s_oaepSHA512;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPaddingMode _mode
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
		/// System.Security.Cryptography.HashAlgorithmName _oaepHashAlgorithm
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RHashAlgorithmName r__oaepHashAlgorithm;
		public virtual RSystem.RSecurity.RCryptography.RHashAlgorithmName R_oaepHashAlgorithm
		{
			get
			{
				if(r__oaepHashAlgorithm == null)
				{
					r__oaepHashAlgorithm = new(this, "_oaepHashAlgorithm");
					r__oaepHashAlgorithm.SetBelong(this.instance);
				}
				return r__oaepHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding Pkcs1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_Pkcs1;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RPkcs1
		{
			get
			{
				if(r_Pkcs1 == null)
				{
					r_Pkcs1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "Pkcs1", -1);
					r_Pkcs1.SetBelong(null);
				}
				return r_Pkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_OaepSHA1;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding ROaepSHA1
		{
			get
			{
				if(r_OaepSHA1 == null)
				{
					r_OaepSHA1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA1", -1);
					r_OaepSHA1.SetBelong(null);
				}
				return r_OaepSHA1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA256
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_OaepSHA256;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding ROaepSHA256
		{
			get
			{
				if(r_OaepSHA256 == null)
				{
					r_OaepSHA256 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA256", -1);
					r_OaepSHA256.SetBelong(null);
				}
				return r_OaepSHA256;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA384
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_OaepSHA384;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding ROaepSHA384
		{
			get
			{
				if(r_OaepSHA384 == null)
				{
					r_OaepSHA384 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA384", -1);
					r_OaepSHA384.SetBelong(null);
				}
				return r_OaepSHA384;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA512
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_OaepSHA512;
		public static RSystem.RSecurity.RCryptography.RRSAEncryptionPadding ROaepSHA512
		{
			get
			{
				if(r_OaepSHA512 == null)
				{
					r_OaepSHA512 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA512", -1);
					r_OaepSHA512.SetBelong(null);
				}
				return r_OaepSHA512;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPaddingMode Mode
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
		/// System.Security.Cryptography.HashAlgorithmName OaepHashAlgorithm
		/// </summary>
		protected RSystem.RSecurity.RCryptography.RHashAlgorithmName r_OaepHashAlgorithm;
		public virtual RSystem.RSecurity.RCryptography.RHashAlgorithmName ROaepHashAlgorithm
		{
			get
			{
				if(r_OaepHashAlgorithm == null)
				{
					r_OaepHashAlgorithm = new(this, "OaepHashAlgorithm", -1);
					r_OaepHashAlgorithm.SetBelong(this.instance);
				}
				return r_OaepHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected static RMethod r_CreateOaep_HashAlgorithmName;
		public static RMethod RCreateOaep_HashAlgorithmName
		{
			get
			{
				if(r_CreateOaep_HashAlgorithmName == null)
				{
					r_CreateOaep_HashAlgorithmName = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "CreateOaep", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_CreateOaep_HashAlgorithmName.SetBelong(null);
				}
				return r_CreateOaep_HashAlgorithmName;
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
		/// Int32 CombineHashCodes(Int32, Int32)
		/// </summary>
		protected static RMethod r_CombineHashCodes_Int32_Int32;
		public static RMethod RCombineHashCodes_Int32_Int32
		{
			get
			{
				if(r_CombineHashCodes_Int32_Int32 == null)
				{
					r_CombineHashCodes_Int32_Int32 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32));
					r_CombineHashCodes_Int32_Int32.SetBelong(null);
				}
				return r_CombineHashCodes_Int32_Int32;
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
		/// Boolean Equals(System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected RMethod r_Equals_RSAEncryptionPadding;
		public virtual RMethod REquals_RSAEncryptionPadding
		{
			get
			{
				if(r_Equals_RSAEncryptionPadding == null)
				{
					r_Equals_RSAEncryptionPadding = new(this, "Equals", 0, typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_Equals_RSAEncryptionPadding.SetBelong(this.instance);
				}
				return r_Equals_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Cryptography.RSAEncryptionPadding, System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected static RMethod r_op_Equality_RSAEncryptionPadding_RSAEncryptionPadding;
		public static RMethod Rop_Equality_RSAEncryptionPadding_RSAEncryptionPadding
		{
			get
			{
				if(r_op_Equality_RSAEncryptionPadding_RSAEncryptionPadding == null)
				{
					r_op_Equality_RSAEncryptionPadding_RSAEncryptionPadding = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "op_Equality", 0, typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_op_Equality_RSAEncryptionPadding_RSAEncryptionPadding.SetBelong(null);
				}
				return r_op_Equality_RSAEncryptionPadding_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Cryptography.RSAEncryptionPadding, System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected static RMethod r_op_Inequality_RSAEncryptionPadding_RSAEncryptionPadding;
		public static RMethod Rop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding
		{
			get
			{
				if(r_op_Inequality_RSAEncryptionPadding_RSAEncryptionPadding == null)
				{
					r_op_Inequality_RSAEncryptionPadding_RSAEncryptionPadding = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "op_Inequality", 0, typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_op_Inequality_RSAEncryptionPadding_RSAEncryptionPadding.SetBelong(null);
				}
				return r_op_Inequality_RSAEncryptionPadding_RSAEncryptionPadding;
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


        public RRSAEncryptionPadding() : base("System.Security.Cryptography.RSAEncryptionPadding")
        {
        }

        public RRSAEncryptionPadding(System.Object instance) : base("System.Security.Cryptography.RSAEncryptionPadding")
		{
            SetInstance(instance);
		}

        public RRSAEncryptionPadding(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRSAEncryptionPadding(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName  @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm};
            var ___result = RCreateOaep_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSAEncryptionPadding)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32  @h1, System.Int32  @h2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h1, @h2};
            var ___result = RCombineHashCodes_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.RSAEncryptionPadding  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Security.Cryptography.RSAEncryptionPadding  @left, System.Security.Cryptography.RSAEncryptionPadding  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_RSAEncryptionPadding_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Cryptography.RSAEncryptionPadding  @left, System.Security.Cryptography.RSAEncryptionPadding  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

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
