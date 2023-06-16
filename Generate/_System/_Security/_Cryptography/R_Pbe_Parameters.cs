
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Security.Cryptography.PbeParameters
	/// </summary>
    public partial class RPbeParameters : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Cryptography.PbeParameters);
            }
        }

        public RPbeParameters() : base("System.Security.Cryptography.PbeParameters")
        {
        }

        public RPbeParameters(System.Object instance) : base("System.Security.Cryptography.PbeParameters")
		{
            SetInstance(instance);
		}

        public RPbeParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPbeParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Security.Cryptography.PbeEncryptionAlgorithm <EncryptionAlgorithm>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RPbeEncryptionAlgorithm r_F__0__EncryptionAlgorithm__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RPbeEncryptionAlgorithm RF__0__EncryptionAlgorithm__1__k__BackingField
		{
			get
			{
				if(r_F__0__EncryptionAlgorithm__1__k__BackingField == null)
				{
					r_F__0__EncryptionAlgorithm__1__k__BackingField = new(this, "<EncryptionAlgorithm>k__BackingField");
				}
				return r_F__0__EncryptionAlgorithm__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName <HashAlgorithm>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_F__0__HashAlgorithm__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RF__0__HashAlgorithm__1__k__BackingField
		{
			get
			{
				if(r_F__0__HashAlgorithm__1__k__BackingField == null)
				{
					r_F__0__HashAlgorithm__1__k__BackingField = new(this, "<HashAlgorithm>k__BackingField");
				}
				return r_F__0__HashAlgorithm__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <IterationCount>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__IterationCount__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__IterationCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__IterationCount__1__k__BackingField == null)
				{
					r_F__0__IterationCount__1__k__BackingField = new(this, "<IterationCount>k__BackingField");
				}
				return r_F__0__IterationCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.PbeEncryptionAlgorithm EncryptionAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RPbeEncryptionAlgorithm r_PEncryptionAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RPbeEncryptionAlgorithm RPEncryptionAlgorithm
		{
			get
			{
				if(r_PEncryptionAlgorithm == null)
				{
					r_PEncryptionAlgorithm = new(this, "EncryptionAlgorithm", -1);
				}
				return r_PEncryptionAlgorithm;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.HashAlgorithmName HashAlgorithm
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName r_PHashAlgorithm;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RCryptography.RHashAlgorithmName RPHashAlgorithm
		{
			get
			{
				if(r_PHashAlgorithm == null)
				{
					r_PHashAlgorithm = new(this, "HashAlgorithm", -1);
				}
				return r_PHashAlgorithm;
			}
		}

		/// <summary>
		/// Int32 IterationCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIterationCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIterationCount
		{
			get
			{
				if(r_PIterationCount == null)
				{
					r_PIterationCount = new(this, "IterationCount", -1);
				}
				return r_PIterationCount;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
