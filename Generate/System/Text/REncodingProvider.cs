using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.EncodingProvider
	/// </summary>
    public partial class REncodingProvider : RMember //
    {

		/// <summary>
		/// System.Object s_InternalSyncObject
		/// </summary>
		protected static RSystem.RObject r_s_InternalSyncObject;
		public static RSystem.RObject Rs_InternalSyncObject
		{
			get
			{
				if(r_s_InternalSyncObject == null)
				{
					r_s_InternalSyncObject = new(typeof(System.Text.EncodingProvider), "s_InternalSyncObject");
					r_s_InternalSyncObject.SetBelong(null);
				}
				return r_s_InternalSyncObject;
			}
		}

		/// <summary>
		/// System.Text.EncodingProvider[] s_providers
		/// </summary>
		protected static RFieldArray<RSystem.RText.REncodingProvider> r_s_providers;
		public static RFieldArray<RSystem.RText.REncodingProvider> Rs_providers
		{
			get
			{
				if(r_s_providers == null)
				{
					r_s_providers = new(typeof(System.Text.EncodingProvider), "s_providers");
					r_s_providers.SetBelong(null);
				}
				return r_s_providers;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String)
		/// </summary>
		protected RMethod r_RGetEncoding_String;
		public virtual RMethod RGetEncoding_String
		{
			get
			{
				if(r_RGetEncoding_String == null)
				{
					r_RGetEncoding_String = new(this, "GetEncoding", 0, typeof(System.String));
					r_RGetEncoding_String.SetBelong(this.instance);
				}
				return r_RGetEncoding_String;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32)
		/// </summary>
		protected RMethod r_RGetEncoding_Int32;
		public virtual RMethod RGetEncoding_Int32
		{
			get
			{
				if(r_RGetEncoding_Int32 == null)
				{
					r_RGetEncoding_Int32 = new(this, "GetEncoding", 0, typeof(System.Int32));
					r_RGetEncoding_Int32.SetBelong(this.instance);
				}
				return r_RGetEncoding_Int32;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected RMethod r_RGetEncoding_String_EncoderFallback_DecoderFallback;
		public virtual RMethod RGetEncoding_String_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_RGetEncoding_String_EncoderFallback_DecoderFallback == null)
				{
					r_RGetEncoding_String_EncoderFallback_DecoderFallback = new(this, "GetEncoding", 0, typeof(System.String), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_RGetEncoding_String_EncoderFallback_DecoderFallback.SetBelong(this.instance);
				}
				return r_RGetEncoding_String_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected RMethod r_RGetEncoding_Int32_EncoderFallback_DecoderFallback;
		public virtual RMethod RGetEncoding_Int32_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_RGetEncoding_Int32_EncoderFallback_DecoderFallback == null)
				{
					r_RGetEncoding_Int32_EncoderFallback_DecoderFallback = new(this, "GetEncoding", 0, typeof(System.Int32), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_RGetEncoding_Int32_EncoderFallback_DecoderFallback.SetBelong(this.instance);
				}
				return r_RGetEncoding_Int32_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// Void AddProvider(System.Text.EncodingProvider)
		/// </summary>
		protected static RMethod r_RAddProvider_EncodingProvider;
		public static RMethod RAddProvider_EncodingProvider
		{
			get
			{
				if(r_RAddProvider_EncodingProvider == null)
				{
					r_RAddProvider_EncodingProvider = new(typeof(System.Text.EncodingProvider), "AddProvider", 0, typeof(System.Text.EncodingProvider));
					r_RAddProvider_EncodingProvider.SetBelong(null);
				}
				return r_RAddProvider_EncodingProvider;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(Int32)
		/// </summary>
		protected static RMethod r_RGetEncodingFromProvider_Int32;
		public static RMethod RGetEncodingFromProvider_Int32
		{
			get
			{
				if(r_RGetEncodingFromProvider_Int32 == null)
				{
					r_RGetEncodingFromProvider_Int32 = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.Int32));
					r_RGetEncodingFromProvider_Int32.SetBelong(null);
				}
				return r_RGetEncodingFromProvider_Int32;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(System.String)
		/// </summary>
		protected static RMethod r_RGetEncodingFromProvider_String;
		public static RMethod RGetEncodingFromProvider_String
		{
			get
			{
				if(r_RGetEncodingFromProvider_String == null)
				{
					r_RGetEncodingFromProvider_String = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.String));
					r_RGetEncodingFromProvider_String.SetBelong(null);
				}
				return r_RGetEncodingFromProvider_String;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(Int32, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback;
		public static RMethod RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback == null)
				{
					r_RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.Int32), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(System.String, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback;
		public static RMethod RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback == null)
				{
					r_RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.String), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback;
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


        public REncodingProvider() : base("System.Text.EncodingProvider")
        {
        }

        public REncodingProvider(System.Object instance) : base("System.Text.EncodingProvider")
		{
            SetInstance(instance);
		}

        public REncodingProvider(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REncodingProvider(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Text.Encoding GetEncoding(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEncoding_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Text.Encoding GetEncoding(System.Int32  @codepage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage};
            var ___result = RGetEncoding_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Text.Encoding GetEncoding(System.String  @name, System.Text.EncoderFallback  @encoderFallback, System.Text.DecoderFallback  @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @encoderFallback, @decoderFallback};
            var ___result = RGetEncoding_String_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Text.Encoding GetEncoding(System.Int32  @codepage, System.Text.EncoderFallback  @encoderFallback, System.Text.DecoderFallback  @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage, @encoderFallback, @decoderFallback};
            var ___result = RGetEncoding_Int32_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static void AddProvider(System.Text.EncodingProvider  @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RAddProvider_EncodingProvider.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.Int32  @codepage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage};
            var ___result = RGetEncodingFromProvider_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.String  @encodingName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encodingName};
            var ___result = RGetEncodingFromProvider_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.Int32  @codepage, System.Text.EncoderFallback  @enc, System.Text.DecoderFallback  @dec)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage, @enc, @dec};
            var ___result = RGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.String  @encodingName, System.Text.EncoderFallback  @enc, System.Text.DecoderFallback  @dec)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encodingName, @enc, @dec};
            var ___result = RGetEncodingFromProvider_String_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
