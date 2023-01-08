using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPermissions
{
	/// <summary>
	/// System.Security.Permissions.StrongNamePublicKeyBlob
	/// </summary>
    public partial class RStrongNamePublicKeyBlob : RMember //
    {

		/// <summary>
		/// System.Byte[] pubkey
		/// </summary>
		protected RFieldArray<RField> r_pubkey;
		public virtual RFieldArray<RField> Rpubkey
		{
			get
			{
				if(r_pubkey == null)
				{
					r_pubkey = new(this, "pubkey");
					r_pubkey.SetBelong(this.instance);
				}
				return r_pubkey;
			}
		}

		/// <summary>
		/// System.Security.Permissions.StrongNamePublicKeyBlob FromString(System.String)
		/// </summary>
		protected static RMethod r_FromString_String;
		public static RMethod RFromString_String
		{
			get
			{
				if(r_FromString_String == null)
				{
					r_FromString_String = new(typeof(System.Security.Permissions.StrongNamePublicKeyBlob), "FromString", 0, typeof(System.String));
					r_FromString_String.SetBelong(null);
				}
				return r_FromString_String;
			}
		}

		/// <summary>
		/// Byte CharToByte(Char)
		/// </summary>
		protected static RMethod r_CharToByte_Char;
		public static RMethod RCharToByte_Char
		{
			get
			{
				if(r_CharToByte_Char == null)
				{
					r_CharToByte_Char = new(typeof(System.Security.Permissions.StrongNamePublicKeyBlob), "CharToByte", 0, typeof(System.Char));
					r_CharToByte_Char.SetBelong(null);
				}
				return r_CharToByte_Char;
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


        public RStrongNamePublicKeyBlob() : base("System.Security.Permissions.StrongNamePublicKeyBlob")
        {
        }

        public RStrongNamePublicKeyBlob(System.Object instance) : base("System.Security.Permissions.StrongNamePublicKeyBlob")
		{
            SetInstance(instance);
		}

        public RStrongNamePublicKeyBlob(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrongNamePublicKeyBlob(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Security.Permissions.StrongNamePublicKeyBlob FromString(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Permissions.StrongNamePublicKeyBlob)___result;
        }


        public static System.Byte CharToByte(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RCharToByte_Char.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

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
