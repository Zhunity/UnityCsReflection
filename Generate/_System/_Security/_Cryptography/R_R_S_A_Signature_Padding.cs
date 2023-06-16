
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Cryptography.RSASignaturePadding
	/// </summary>
    public partial class RRSASignaturePadding : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Cryptography.RSASignaturePadding);
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


		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding s_pkcs1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding r_Fs_pkcs1;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding RFs_pkcs1
		{
			get
			{
				if(r_Fs_pkcs1 == null)
				{
					r_Fs_pkcs1 = new(Type, "s_pkcs1");
				}
				return r_Fs_pkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding s_pss
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding r_Fs_pss;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding RFs_pss
		{
			get
			{
				if(r_Fs_pss == null)
				{
					r_Fs_pss = new(Type, "s_pss");
				}
				return r_Fs_pss;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePaddingMode _mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePaddingMode r_F_mode;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePaddingMode RF_mode
		{
			get
			{
				if(r_F_mode == null)
				{
					r_F_mode = new(this, "_mode");
				}
				return r_F_mode;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding Pkcs1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding r_PPkcs1;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding RPPkcs1
		{
			get
			{
				if(r_PPkcs1 == null)
				{
					r_PPkcs1 = new(Type, "Pkcs1", -1);
				}
				return r_PPkcs1;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePadding Pss
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding r_PPss;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePadding RPPss
		{
			get
			{
				if(r_PPss == null)
				{
					r_PPss = new(Type, "Pss", -1);
				}
				return r_PPss;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.RSASignaturePaddingMode Mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePaddingMode r_PMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RRSASignaturePaddingMode RPMode
		{
			get
			{
				if(r_PMode == null)
				{
					r_PMode = new(this, "Mode", -1);
				}
				return r_PMode;
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
		/// Boolean Equals(System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected RMethod r_MEquals_RSASignaturePadding;
		public virtual RMethod RMEquals_RSASignaturePadding
		{
			get
			{
				if(r_MEquals_RSASignaturePadding == null)
				{
					r_MEquals_RSASignaturePadding = new(this, "Equals", 0, typeof(System.Security.Cryptography.RSASignaturePadding));
				}
				return r_MEquals_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Security.Cryptography.RSASignaturePadding, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected static RMethod r_Mop_Equality_RSASignaturePadding_RSASignaturePadding;
		public static RMethod RMop_Equality_RSASignaturePadding_RSASignaturePadding
		{
			get
			{
				if(r_Mop_Equality_RSASignaturePadding_RSASignaturePadding == null)
				{
					r_Mop_Equality_RSASignaturePadding_RSASignaturePadding = new(Type, "op_Equality", 0, typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Security.Cryptography.RSASignaturePadding));
				}
				return r_Mop_Equality_RSASignaturePadding_RSASignaturePadding;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Security.Cryptography.RSASignaturePadding, System.Security.Cryptography.RSASignaturePadding)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RSASignaturePadding_RSASignaturePadding;
		public static RMethod RMop_Inequality_RSASignaturePadding_RSASignaturePadding
		{
			get
			{
				if(r_Mop_Inequality_RSASignaturePadding_RSASignaturePadding == null)
				{
					r_Mop_Inequality_RSASignaturePadding_RSASignaturePadding = new(Type, "op_Inequality", 0, typeof(System.Security.Cryptography.RSASignaturePadding), typeof(System.Security.Cryptography.RSASignaturePadding));
				}
				return r_Mop_Inequality_RSASignaturePadding_RSASignaturePadding;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Security.Cryptography.RSASignaturePadding @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(System.Security.Cryptography.RSASignaturePadding @left, System.Security.Cryptography.RSASignaturePadding @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_RSASignaturePadding_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Security.Cryptography.RSASignaturePadding @left, System.Security.Cryptography.RSASignaturePadding @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_RSASignaturePadding_RSASignaturePadding.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
