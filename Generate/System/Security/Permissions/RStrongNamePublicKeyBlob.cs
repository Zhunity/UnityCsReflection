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
		protected static RMethod r_RFromString_String;
		public static RMethod RFromString_String
		{
			get
			{
				if(r_RFromString_String == null)
				{
					r_RFromString_String = new(typeof(System.Security.Permissions.StrongNamePublicKeyBlob), "FromString", 0, typeof(System.String));
					r_RFromString_String.SetBelong(null);
				}
				return r_RFromString_String;
			}
		}

		/// <summary>
		/// Byte CharToByte(Char)
		/// </summary>
		protected static RMethod r_RCharToByte_Char;
		public static RMethod RCharToByte_Char
		{
			get
			{
				if(r_RCharToByte_Char == null)
				{
					r_RCharToByte_Char = new(typeof(System.Security.Permissions.StrongNamePublicKeyBlob), "CharToByte", 0, typeof(System.Char));
					r_RCharToByte_Char.SetBelong(null);
				}
				return r_RCharToByte_Char;
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

        public static System.Security.Permissions.StrongNamePublicKeyBlob FromString(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Security.Permissions.StrongNamePublicKeyBlob)___result;
        }


        public static System.Byte CharToByte(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RCharToByte_Char.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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
