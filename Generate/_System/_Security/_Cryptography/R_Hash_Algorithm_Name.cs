
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.HashAlgorithmName
	/// </summary>
    public partial class RHashAlgorithmName : RMember //
    {

		/// <summary>
		/// System.String _name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_name
		{
			get
			{
				if(r_F_name == null)
				{
					r_F_name = new(this, "_name");
					r_F_name.SetBelong(this.GetValue());
				}
				return r_F_name;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName MD5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_PMD5;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPMD5
		{
			get
			{
				if(r_PMD5 == null)
				{
					r_PMD5 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "MD5", -1);
					r_PMD5.SetBelong(null);
				}
				return r_PMD5;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_PSHA1;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPSHA1
		{
			get
			{
				if(r_PSHA1 == null)
				{
					r_PSHA1 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA1", -1);
					r_PSHA1.SetBelong(null);
				}
				return r_PSHA1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA256
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_PSHA256;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPSHA256
		{
			get
			{
				if(r_PSHA256 == null)
				{
					r_PSHA256 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA256", -1);
					r_PSHA256.SetBelong(null);
				}
				return r_PSHA256;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA384
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_PSHA384;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPSHA384
		{
			get
			{
				if(r_PSHA384 == null)
				{
					r_PSHA384 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA384", -1);
					r_PSHA384.SetBelong(null);
				}
				return r_PSHA384;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName SHA512
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_PSHA512;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPSHA512
		{
			get
			{
				if(r_PSHA512 == null)
				{
					r_PSHA512 = new(typeof(System.Security.Cryptography.HashAlgorithmName), "SHA512", -1);
					r_PSHA512.SetBelong(null);
				}
				return r_PSHA512;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.GetValue());
				}
				return r_PName;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected RMethod r_MEquals_HashAlgorithmName;
		public virtual RMethod RMEquals_HashAlgorithmName
		{
			get
			{
				if(r_MEquals_HashAlgorithmName == null)
				{
					r_MEquals_HashAlgorithmName = new(this, "Equals", 0, typeof(System.Security.Cryptography.HashAlgorithmName));
					r_MEquals_HashAlgorithmName.SetBelong(this.GetValue());
				}
				return r_MEquals_HashAlgorithmName;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected static RMethod r_Mop_Equality_HashAlgorithmName_HashAlgorithmName;
		public static RMethod RMop_Equality_HashAlgorithmName_HashAlgorithmName
		{
			get
			{
				if(r_Mop_Equality_HashAlgorithmName_HashAlgorithmName == null)
				{
					r_Mop_Equality_HashAlgorithmName_HashAlgorithmName = new(typeof(System.Security.Cryptography.HashAlgorithmName), "op_Equality", 0, typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_Mop_Equality_HashAlgorithmName_HashAlgorithmName.SetBelong(null);
				}
				return r_Mop_Equality_HashAlgorithmName_HashAlgorithmName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Cryptography.HashAlgorithmName, System.Security.Cryptography.HashAlgorithmName)
		/// </summary>
		protected static RMethod r_Mop_Inequality_HashAlgorithmName_HashAlgorithmName;
		public static RMethod RMop_Inequality_HashAlgorithmName_HashAlgorithmName
		{
			get
			{
				if(r_Mop_Inequality_HashAlgorithmName_HashAlgorithmName == null)
				{
					r_Mop_Inequality_HashAlgorithmName_HashAlgorithmName = new(typeof(System.Security.Cryptography.HashAlgorithmName), "op_Inequality", 0, typeof(System.Security.Cryptography.HashAlgorithmName), typeof(System.Security.Cryptography.HashAlgorithmName));
					r_Mop_Inequality_HashAlgorithmName_HashAlgorithmName.SetBelong(null);
				}
				return r_Mop_Inequality_HashAlgorithmName_HashAlgorithmName;
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.HashAlgorithmName @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Security.Cryptography.HashAlgorithmName @left, System.Security.Cryptography.HashAlgorithmName @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_HashAlgorithmName_HashAlgorithmName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Security.Cryptography.HashAlgorithmName @left, System.Security.Cryptography.HashAlgorithmName @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_HashAlgorithmName_HashAlgorithmName.Invoke(___genericsType, ___parameters);

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
