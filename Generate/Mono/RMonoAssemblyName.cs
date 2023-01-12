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
		protected static RSystem.RInt32 r_FMONO_PUBLIC_KEY_TOKEN_LENGTH;
		public static RSystem.RInt32 RFMONO_PUBLIC_KEY_TOKEN_LENGTH
		{
			get
			{
				if(r_FMONO_PUBLIC_KEY_TOKEN_LENGTH == null)
				{
					r_FMONO_PUBLIC_KEY_TOKEN_LENGTH = new( ReflectionUtils.GetType("Mono.MonoAssemblyName"), "MONO_PUBLIC_KEY_TOKEN_LENGTH");
					r_FMONO_PUBLIC_KEY_TOKEN_LENGTH.SetBelong(null);
				}
				return r_FMONO_PUBLIC_KEY_TOKEN_LENGTH;
			}
		}

		/// <summary>
		/// System.IntPtr name
		/// </summary>
		protected RSystem.RIntPtr r_Fname;
		public virtual RSystem.RIntPtr RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.IntPtr culture
		/// </summary>
		protected RSystem.RIntPtr r_Fculture;
		public virtual RSystem.RIntPtr RFculture
		{
			get
			{
				if(r_Fculture == null)
				{
					r_Fculture = new(this, "culture");
					r_Fculture.SetBelong(this.instance);
				}
				return r_Fculture;
			}
		}

		/// <summary>
		/// System.IntPtr hash_value
		/// </summary>
		protected RSystem.RIntPtr r_Fhash_value;
		public virtual RSystem.RIntPtr RFhash_value
		{
			get
			{
				if(r_Fhash_value == null)
				{
					r_Fhash_value = new(this, "hash_value");
					r_Fhash_value.SetBelong(this.instance);
				}
				return r_Fhash_value;
			}
		}

		/// <summary>
		/// System.IntPtr public_key
		/// </summary>
		protected RSystem.RIntPtr r_Fpublic_key;
		public virtual RSystem.RIntPtr RFpublic_key
		{
			get
			{
				if(r_Fpublic_key == null)
				{
					r_Fpublic_key = new(this, "public_key");
					r_Fpublic_key.SetBelong(this.instance);
				}
				return r_Fpublic_key;
			}
		}

		/// <summary>
		/// Mono.MonoAssemblyName+<public_key_token>e__FixedBuffer public_key_token
		/// </summary>
		protected RMono.RMonoAssemblyName.R__0__public_key_token__1__e__FixedBuffer r_Fpublic_key_token;
		public virtual RMono.RMonoAssemblyName.R__0__public_key_token__1__e__FixedBuffer RFpublic_key_token
		{
			get
			{
				if(r_Fpublic_key_token == null)
				{
					r_Fpublic_key_token = new(this, "public_key_token");
					r_Fpublic_key_token.SetBelong(this.instance);
				}
				return r_Fpublic_key_token;
			}
		}

		/// <summary>
		/// System.UInt32 hash_alg
		/// </summary>
		protected RSystem.RUInt32 r_Fhash_alg;
		public virtual RSystem.RUInt32 RFhash_alg
		{
			get
			{
				if(r_Fhash_alg == null)
				{
					r_Fhash_alg = new(this, "hash_alg");
					r_Fhash_alg.SetBelong(this.instance);
				}
				return r_Fhash_alg;
			}
		}

		/// <summary>
		/// System.UInt32 hash_len
		/// </summary>
		protected RSystem.RUInt32 r_Fhash_len;
		public virtual RSystem.RUInt32 RFhash_len
		{
			get
			{
				if(r_Fhash_len == null)
				{
					r_Fhash_len = new(this, "hash_len");
					r_Fhash_len.SetBelong(this.instance);
				}
				return r_Fhash_len;
			}
		}

		/// <summary>
		/// System.UInt32 flags
		/// </summary>
		protected RSystem.RUInt32 r_Fflags;
		public virtual RSystem.RUInt32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// System.UInt16 major
		/// </summary>
		protected RSystem.RUInt16 r_Fmajor;
		public virtual RSystem.RUInt16 RFmajor
		{
			get
			{
				if(r_Fmajor == null)
				{
					r_Fmajor = new(this, "major");
					r_Fmajor.SetBelong(this.instance);
				}
				return r_Fmajor;
			}
		}

		/// <summary>
		/// System.UInt16 minor
		/// </summary>
		protected RSystem.RUInt16 r_Fminor;
		public virtual RSystem.RUInt16 RFminor
		{
			get
			{
				if(r_Fminor == null)
				{
					r_Fminor = new(this, "minor");
					r_Fminor.SetBelong(this.instance);
				}
				return r_Fminor;
			}
		}

		/// <summary>
		/// System.UInt16 build
		/// </summary>
		protected RSystem.RUInt16 r_Fbuild;
		public virtual RSystem.RUInt16 RFbuild
		{
			get
			{
				if(r_Fbuild == null)
				{
					r_Fbuild = new(this, "build");
					r_Fbuild.SetBelong(this.instance);
				}
				return r_Fbuild;
			}
		}

		/// <summary>
		/// System.UInt16 revision
		/// </summary>
		protected RSystem.RUInt16 r_Frevision;
		public virtual RSystem.RUInt16 RFrevision
		{
			get
			{
				if(r_Frevision == null)
				{
					r_Frevision = new(this, "revision");
					r_Frevision.SetBelong(this.instance);
				}
				return r_Frevision;
			}
		}

		/// <summary>
		/// System.UInt16 arch
		/// </summary>
		protected RSystem.RUInt16 r_Farch;
		public virtual RSystem.RUInt16 RFarch
		{
			get
			{
				if(r_Farch == null)
				{
					r_Farch = new(this, "arch");
					r_Farch.SetBelong(this.instance);
				}
				return r_Farch;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
