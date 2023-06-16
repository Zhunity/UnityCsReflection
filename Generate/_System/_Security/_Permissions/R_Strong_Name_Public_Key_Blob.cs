
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPermissions
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Permissions.StrongNamePublicKeyBlob
	/// </summary>
    public partial class RStrongNamePublicKeyBlob : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Permissions.StrongNamePublicKeyBlob);
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


		/// <summary>
		/// System.Byte[] pubkey
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fpubkey;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFpubkey
		{
			get
			{
				if(r_Fpubkey == null)
				{
					r_Fpubkey = new(this, "pubkey");
				}
				return r_Fpubkey;
			}
		}

		/// <summary>
		/// System.Security.Permissions.StrongNamePublicKeyBlob FromString(System.String)
		/// </summary>
		protected static RMethod r_MFromString_String;
		public static RMethod RMFromString_String
		{
			get
			{
				if(r_MFromString_String == null)
				{
					r_MFromString_String = new(Type, "FromString", 0, typeof(System.String));
				}
				return r_MFromString_String;
			}
		}

		/// <summary>
		/// Byte CharToByte(Char)
		/// </summary>
		protected static RMethod r_MCharToByte_Char;
		public static RMethod RMCharToByte_Char
		{
			get
			{
				if(r_MCharToByte_Char == null)
				{
					r_MCharToByte_Char = new(Type, "CharToByte", 0, typeof(System.Char));
				}
				return r_MCharToByte_Char;
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
				}
				return r_MEquals_Object;
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
				}
				return r_MGetHashCode;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public static System.Security.Permissions.StrongNamePublicKeyBlob FromString(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMFromString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Permissions.StrongNamePublicKeyBlob>(___result);
        }


        public static System.Byte CharToByte(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMCharToByte_Char.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
