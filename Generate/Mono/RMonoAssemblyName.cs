using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMono
{
	/// <summary>
	/// Mono.MonoAssemblyName
	/// </summary>
    public partial class RMonoAssemblyName : RMember //
    {

		/// <summary>
		/// System.Int32 MONO_PUBLIC_KEY_TOKEN_LENGTH
		/// </summary>
		protected static RField r_MONO_PUBLIC_KEY_TOKEN_LENGTH;
		public static RField RMONO_PUBLIC_KEY_TOKEN_LENGTH
		{
			get
			{
				if(r_MONO_PUBLIC_KEY_TOKEN_LENGTH == null)
				{
					r_MONO_PUBLIC_KEY_TOKEN_LENGTH = new( ReleactionUtils.GetType("Mono.MonoAssemblyName"), "MONO_PUBLIC_KEY_TOKEN_LENGTH");
					r_MONO_PUBLIC_KEY_TOKEN_LENGTH.SetBelong(null);
				}
				return r_MONO_PUBLIC_KEY_TOKEN_LENGTH;
			}
		}

		/// <summary>
		/// System.IntPtr name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.IntPtr culture
		/// </summary>
		protected RField r_culture;
		public virtual RField Rculture
		{
			get
			{
				if(r_culture == null)
				{
					r_culture = new(this, "culture");
					r_culture.SetBelong(this.instance);
				}
				return r_culture;
			}
		}

		/// <summary>
		/// System.IntPtr hash_value
		/// </summary>
		protected RField r_hash_value;
		public virtual RField Rhash_value
		{
			get
			{
				if(r_hash_value == null)
				{
					r_hash_value = new(this, "hash_value");
					r_hash_value.SetBelong(this.instance);
				}
				return r_hash_value;
			}
		}

		/// <summary>
		/// System.IntPtr public_key
		/// </summary>
		protected RField r_public_key;
		public virtual RField Rpublic_key
		{
			get
			{
				if(r_public_key == null)
				{
					r_public_key = new(this, "public_key");
					r_public_key.SetBelong(this.instance);
				}
				return r_public_key;
			}
		}

		/// <summary>
		/// Mono.MonoAssemblyName+<public_key_token>e__FixedBuffer public_key_token
		/// </summary>
		protected RMono.RMonoAssemblyName.R__1__public_key_token__2__e__FixedBuffer r_public_key_token;
		public virtual RMono.RMonoAssemblyName.R__1__public_key_token__2__e__FixedBuffer Rpublic_key_token
		{
			get
			{
				if(r_public_key_token == null)
				{
					r_public_key_token = new(this, "public_key_token");
					r_public_key_token.SetBelong(this.instance);
				}
				return r_public_key_token;
			}
		}

		/// <summary>
		/// System.UInt32 hash_alg
		/// </summary>
		protected RField r_hash_alg;
		public virtual RField Rhash_alg
		{
			get
			{
				if(r_hash_alg == null)
				{
					r_hash_alg = new(this, "hash_alg");
					r_hash_alg.SetBelong(this.instance);
				}
				return r_hash_alg;
			}
		}

		/// <summary>
		/// System.UInt32 hash_len
		/// </summary>
		protected RField r_hash_len;
		public virtual RField Rhash_len
		{
			get
			{
				if(r_hash_len == null)
				{
					r_hash_len = new(this, "hash_len");
					r_hash_len.SetBelong(this.instance);
				}
				return r_hash_len;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// System.UInt16 major
		/// </summary>
		protected RField r_major;
		public virtual RField Rmajor
		{
			get
			{
				if(r_major == null)
				{
					r_major = new(this, "major");
					r_major.SetBelong(this.instance);
				}
				return r_major;
			}
		}

		/// <summary>
		/// System.UInt16 minor
		/// </summary>
		protected RField r_minor;
		public virtual RField Rminor
		{
			get
			{
				if(r_minor == null)
				{
					r_minor = new(this, "minor");
					r_minor.SetBelong(this.instance);
				}
				return r_minor;
			}
		}

		/// <summary>
		/// System.UInt16 build
		/// </summary>
		protected RField r_build;
		public virtual RField Rbuild
		{
			get
			{
				if(r_build == null)
				{
					r_build = new(this, "build");
					r_build.SetBelong(this.instance);
				}
				return r_build;
			}
		}

		/// <summary>
		/// System.UInt16 revision
		/// </summary>
		protected RField r_revision;
		public virtual RField Rrevision
		{
			get
			{
				if(r_revision == null)
				{
					r_revision = new(this, "revision");
					r_revision.SetBelong(this.instance);
				}
				return r_revision;
			}
		}

		/// <summary>
		/// System.UInt16 arch
		/// </summary>
		protected RField r_arch;
		public virtual RField Rarch
		{
			get
			{
				if(r_arch == null)
				{
					r_arch = new(this, "arch");
					r_arch.SetBelong(this.instance);
				}
				return r_arch;
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


        public RMonoAssemblyName() : base("Mono.MonoAssemblyName")
        {
        }

        public RMonoAssemblyName(System.Object instance) : base("Mono.MonoAssemblyName")
		{
            SetInstance(instance);
		}

        public RMonoAssemblyName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMonoAssemblyName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
