using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.HashAlgorithmName
	/// </summary>
    public partial class RHashAlgorithmName : RMember //
    {

		/// <summary>
		/// System.String _name
		/// </summary>
		protected RField r__name;
		public virtual RField R_name
		{
			get
			{
				if(r__name == null)
				{
					r__name = new(this, "_name");
					r__name.SetBelong(this.instance);
				}
				return r__name;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName MD5
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RHashAlgorithmName r_MD5;
		public static RSystem.RSecurity.RCryptography.RHashAlgorithmName RMD5
		{
			get
			{
				if(r_MD5 == null)
				{
					r_MD5 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "MD5", -1);
					r_MD5.SetBelong(null);
				}
				return r_MD5;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA1
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RHashAlgorithmName r_SHA1;
		public static RSystem.RSecurity.RCryptography.RHashAlgorithmName RSHA1
		{
			get
			{
				if(r_SHA1 == null)
				{
					r_SHA1 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA1", -1);
					r_SHA1.SetBelong(null);
				}
				return r_SHA1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA256
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RHashAlgorithmName r_SHA256;
		public static RSystem.RSecurity.RCryptography.RHashAlgorithmName RSHA256
		{
			get
			{
				if(r_SHA256 == null)
				{
					r_SHA256 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA256", -1);
					r_SHA256.SetBelong(null);
				}
				return r_SHA256;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA384
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RHashAlgorithmName r_SHA384;
		public static RSystem.RSecurity.RCryptography.RHashAlgorithmName RSHA384
		{
			get
			{
				if(r_SHA384 == null)
				{
					r_SHA384 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA384", -1);
					r_SHA384.SetBelong(null);
				}
				return r_SHA384;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA512
		/// </summary>
		protected static RSystem.RSecurity.RCryptography.RHashAlgorithmName r_SHA512;
		public static RSystem.RSecurity.RCryptography.RHashAlgorithmName RSHA512
		{
			get
			{
				if(r_SHA512 == null)
				{
					r_SHA512 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA512", -1);
					r_SHA512.SetBelong(null);
				}
				return r_SHA512;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
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
		/// Boolean Equals(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_REquals_HashAlgorithmName;
		public virtual RMethod REquals_HashAlgorithmName
		{
			get
			{
				if(r_REquals_HashAlgorithmName == null)
				{
					r_REquals_HashAlgorithmName = new(this, "Equals", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_REquals_HashAlgorithmName.SetBelong(this.instance);
				}
				return r_REquals_HashAlgorithmName;
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
		/// Boolean op_Equality(System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected static RMethod r_Rop_Equality_HashAlgorithmName_HashAlgorithmName;
		public static RMethod Rop_Equality_HashAlgorithmName_HashAlgorithmName
		{
			get
			{
				if(r_Rop_Equality_HashAlgorithmName_HashAlgorithmName == null)
				{
					r_Rop_Equality_HashAlgorithmName_HashAlgorithmName = new(typeof(System.Security.Cryptography.HashAlgorithmName), "op_Equality", 0, typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_Rop_Equality_HashAlgorithmName_HashAlgorithmName.SetBelong(null);
				}
				return r_Rop_Equality_HashAlgorithmName_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected static RMethod r_Rop_Inequality_HashAlgorithmName_HashAlgorithmName;
		public static RMethod Rop_Inequality_HashAlgorithmName_HashAlgorithmName
		{
			get
			{
				if(r_Rop_Inequality_HashAlgorithmName_HashAlgorithmName == null)
				{
					r_Rop_Inequality_HashAlgorithmName_HashAlgorithmName = new(typeof(System.Security.Cryptography.HashAlgorithmName), "op_Inequality", 0, typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_Rop_Inequality_HashAlgorithmName_HashAlgorithmName.SetBelong(null);
				}
				return r_Rop_Inequality_HashAlgorithmName_HashAlgorithmName;
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


        public RHashAlgorithmName() : base("System.Security.Cryptography.HashAlgorithmName")
        {
        }

        public RHashAlgorithmName(System.Object instance) : base("System.Security.Cryptography.HashAlgorithmName")
		{
            SetInstance(instance);
		}

        public RHashAlgorithmName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHashAlgorithmName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.HashAlgorithmName  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Security.Cryptography.HashAlgorithmName  @left, System.Security.Cryptography.HashAlgorithmName  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_HashAlgorithmName_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Cryptography.HashAlgorithmName  @left, System.Security.Cryptography.HashAlgorithmName  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_HashAlgorithmName_HashAlgorithmName.Invoke(___genericsType, ___parameters);

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
