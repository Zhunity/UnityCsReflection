
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
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_Fs_pkcs1;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RFs_pkcs1
		{
			get
			{
				if(r_Fs_pkcs1 == null)
				{
					r_Fs_pkcs1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_pkcs1");
					r_Fs_pkcs1.SetBelong(null);
				}
				return r_Fs_pkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA1
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_Fs_oaepSHA1;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RFs_oaepSHA1
		{
			get
			{
				if(r_Fs_oaepSHA1 == null)
				{
					r_Fs_oaepSHA1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA1");
					r_Fs_oaepSHA1.SetBelong(null);
				}
				return r_Fs_oaepSHA1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA256
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_Fs_oaepSHA256;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RFs_oaepSHA256
		{
			get
			{
				if(r_Fs_oaepSHA256 == null)
				{
					r_Fs_oaepSHA256 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA256");
					r_Fs_oaepSHA256.SetBelong(null);
				}
				return r_Fs_oaepSHA256;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA384
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_Fs_oaepSHA384;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RFs_oaepSHA384
		{
			get
			{
				if(r_Fs_oaepSHA384 == null)
				{
					r_Fs_oaepSHA384 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA384");
					r_Fs_oaepSHA384.SetBelong(null);
				}
				return r_Fs_oaepSHA384;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA512
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_Fs_oaepSHA512;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RFs_oaepSHA512
		{
			get
			{
				if(r_Fs_oaepSHA512 == null)
				{
					r_Fs_oaepSHA512 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "s_oaepSHA512");
					r_Fs_oaepSHA512.SetBelong(null);
				}
				return r_Fs_oaepSHA512;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPaddingMode _mode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPaddingMode r_F_mode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPaddingMode RF_mode
		{
			get
			{
				if(r_F_mode == null)
				{
					r_F_mode = new(this, "_mode");
					r_F_mode.SetBelong(this.instance);
				}
				return r_F_mode;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName _oaepHashAlgorithm
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_F_oaepHashAlgorithm;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RF_oaepHashAlgorithm
		{
			get
			{
				if(r_F_oaepHashAlgorithm == null)
				{
					r_F_oaepHashAlgorithm = new(this, "_oaepHashAlgorithm");
					r_F_oaepHashAlgorithm.SetBelong(this.instance);
				}
				return r_F_oaepHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding Pkcs1
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_PPkcs1;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RPPkcs1
		{
			get
			{
				if(r_PPkcs1 == null)
				{
					r_PPkcs1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "Pkcs1", -1);
					r_PPkcs1.SetBelong(null);
				}
				return r_PPkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA1
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_POaepSHA1;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RPOaepSHA1
		{
			get
			{
				if(r_POaepSHA1 == null)
				{
					r_POaepSHA1 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA1", -1);
					r_POaepSHA1.SetBelong(null);
				}
				return r_POaepSHA1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA256
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_POaepSHA256;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RPOaepSHA256
		{
			get
			{
				if(r_POaepSHA256 == null)
				{
					r_POaepSHA256 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA256", -1);
					r_POaepSHA256.SetBelong(null);
				}
				return r_POaepSHA256;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA384
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_POaepSHA384;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RPOaepSHA384
		{
			get
			{
				if(r_POaepSHA384 == null)
				{
					r_POaepSHA384 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA384", -1);
					r_POaepSHA384.SetBelong(null);
				}
				return r_POaepSHA384;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding OaepSHA512
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding r_POaepSHA512;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPadding RPOaepSHA512
		{
			get
			{
				if(r_POaepSHA512 == null)
				{
					r_POaepSHA512 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "OaepSHA512", -1);
					r_POaepSHA512.SetBelong(null);
				}
				return r_POaepSHA512;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPaddingMode Mode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPaddingMode r_PMode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSAEncryptionPaddingMode RPMode
		{
			get
			{
				if(r_PMode == null)
				{
					r_PMode = new(this, "Mode", -1);
					r_PMode.SetBelong(this.instance);
				}
				return r_PMode;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName OaepHashAlgorithm
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_POaepHashAlgorithm;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPOaepHashAlgorithm
		{
			get
			{
				if(r_POaepHashAlgorithm == null)
				{
					r_POaepHashAlgorithm = new(this, "OaepHashAlgorithm", -1);
					r_POaepHashAlgorithm.SetBelong(this.instance);
				}
				return r_POaepHashAlgorithm;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected static RMethod r_MCreateOaep_HashAlgorithmName;
		public static RMethod RMCreateOaep_HashAlgorithmName
		{
			get
			{
				if(r_MCreateOaep_HashAlgorithmName == null)
				{
					r_MCreateOaep_HashAlgorithmName = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "CreateOaep", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_MCreateOaep_HashAlgorithmName.SetBelong(null);
				}
				return r_MCreateOaep_HashAlgorithmName;
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
		/// Int32 CombineHashCodes(Int32, Int32)
		/// </summary>
		protected static RMethod r_MCombineHashCodes_Int32_Int32;
		public static RMethod RMCombineHashCodes_Int32_Int32
		{
			get
			{
				if(r_MCombineHashCodes_Int32_Int32 == null)
				{
					r_MCombineHashCodes_Int32_Int32 = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "CombineHashCodes", 0, typeof(System.Int32), typeof(System.Int32));
					r_MCombineHashCodes_Int32_Int32.SetBelong(null);
				}
				return r_MCombineHashCodes_Int32_Int32;
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
		/// Boolean Equals(System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected RMethod r_MEquals_RSAEncryptionPadding;
		public virtual RMethod RMEquals_RSAEncryptionPadding
		{
			get
			{
				if(r_MEquals_RSAEncryptionPadding == null)
				{
					r_MEquals_RSAEncryptionPadding = new(this, "Equals", 0, typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_MEquals_RSAEncryptionPadding.SetBelong(this.instance);
				}
				return r_MEquals_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Cryptography.RSAEncryptionPadding, System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected static RMethod r_Mop_Equality_RSAEncryptionPadding_RSAEncryptionPadding;
		public static RMethod RMop_Equality_RSAEncryptionPadding_RSAEncryptionPadding
		{
			get
			{
				if(r_Mop_Equality_RSAEncryptionPadding_RSAEncryptionPadding == null)
				{
					r_Mop_Equality_RSAEncryptionPadding_RSAEncryptionPadding = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "op_Equality", 0, typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_Mop_Equality_RSAEncryptionPadding_RSAEncryptionPadding.SetBelong(null);
				}
				return r_Mop_Equality_RSAEncryptionPadding_RSAEncryptionPadding;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Cryptography.RSAEncryptionPadding, System.Security.Cryptography.RSAEncryptionPadding)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding;
		public static RMethod RMop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding
		{
			get
			{
				if(r_Mop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding == null)
				{
					r_Mop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding = new(typeof(System.Security.Cryptography.RSAEncryptionPadding), "op_Inequality", 0, typeof(System.Security.Cryptography.RSAEncryptionPadding), typeof(System.Security.Cryptography.RSAEncryptionPadding));
					r_Mop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding.SetBelong(null);
				}
				return r_Mop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding;
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

        public static System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName @hashAlgorithm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashAlgorithm};
            var ___result = RMCreateOaep_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.RSAEncryptionPadding)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CombineHashCodes(System.Int32 @h1, System.Int32 @h2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@h1, @h2};
            var ___result = RMCombineHashCodes_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.RSAEncryptionPadding @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Security.Cryptography.RSAEncryptionPadding @left, System.Security.Cryptography.RSAEncryptionPadding @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_RSAEncryptionPadding_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Cryptography.RSAEncryptionPadding @left, System.Security.Cryptography.RSAEncryptionPadding @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_RSAEncryptionPadding_RSAEncryptionPadding.Invoke(___genericsType, ___parameters);

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
