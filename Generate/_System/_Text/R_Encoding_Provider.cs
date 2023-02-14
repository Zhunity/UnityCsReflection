
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.EncodingProvider
	/// </summary>
    public partial class REncodingProvider : RMember //
    {

		/// <summary>
		/// System.Object s_InternalSyncObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_Fs_InternalSyncObject;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFs_InternalSyncObject
		{
			get
			{
				if(r_Fs_InternalSyncObject == null)
				{
					r_Fs_InternalSyncObject = new(typeof(System.Text.EncodingProvider), "s_InternalSyncObject");
					r_Fs_InternalSyncObject.SetBelong(null);
				}
				return r_Fs_InternalSyncObject;
			}
		}

		/// <summary>
		/// System.Text.EncodingProvider[] s_providers
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RText.REncodingProvider> r_Fs_providers;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RText.REncodingProvider> RFs_providers
		{
			get
			{
				if(r_Fs_providers == null)
				{
					r_Fs_providers = new(typeof(System.Text.EncodingProvider), "s_providers");
					r_Fs_providers.SetBelong(null);
				}
				return r_Fs_providers;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String)
		/// </summary>
		protected RMethod r_MGetEncoding_String;
		public virtual RMethod RMGetEncoding_String
		{
			get
			{
				if(r_MGetEncoding_String == null)
				{
					r_MGetEncoding_String = new(this, "GetEncoding", 0, typeof(System.String));
					r_MGetEncoding_String.SetBelong(this.instance);
				}
				return r_MGetEncoding_String;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32)
		/// </summary>
		protected RMethod r_MGetEncoding_Int32;
		public virtual RMethod RMGetEncoding_Int32
		{
			get
			{
				if(r_MGetEncoding_Int32 == null)
				{
					r_MGetEncoding_Int32 = new(this, "GetEncoding", 0, typeof(System.Int32));
					r_MGetEncoding_Int32.SetBelong(this.instance);
				}
				return r_MGetEncoding_Int32;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(System.String, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected RMethod r_MGetEncoding_String_EncoderFallback_DecoderFallback;
		public virtual RMethod RMGetEncoding_String_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_MGetEncoding_String_EncoderFallback_DecoderFallback == null)
				{
					r_MGetEncoding_String_EncoderFallback_DecoderFallback = new(this, "GetEncoding", 0, typeof(System.String), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_MGetEncoding_String_EncoderFallback_DecoderFallback.SetBelong(this.instance);
				}
				return r_MGetEncoding_String_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding(Int32, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected RMethod r_MGetEncoding_Int32_EncoderFallback_DecoderFallback;
		public virtual RMethod RMGetEncoding_Int32_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_MGetEncoding_Int32_EncoderFallback_DecoderFallback == null)
				{
					r_MGetEncoding_Int32_EncoderFallback_DecoderFallback = new(this, "GetEncoding", 0, typeof(System.Int32), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_MGetEncoding_Int32_EncoderFallback_DecoderFallback.SetBelong(this.instance);
				}
				return r_MGetEncoding_Int32_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// Void AddProvider(System.Text.EncodingProvider)
		/// </summary>
		protected static RMethod r_MAddProvider_EncodingProvider;
		public static RMethod RMAddProvider_EncodingProvider
		{
			get
			{
				if(r_MAddProvider_EncodingProvider == null)
				{
					r_MAddProvider_EncodingProvider = new(typeof(System.Text.EncodingProvider), "AddProvider", 0, typeof(System.Text.EncodingProvider));
					r_MAddProvider_EncodingProvider.SetBelong(null);
				}
				return r_MAddProvider_EncodingProvider;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(Int32)
		/// </summary>
		protected static RMethod r_MGetEncodingFromProvider_Int32;
		public static RMethod RMGetEncodingFromProvider_Int32
		{
			get
			{
				if(r_MGetEncodingFromProvider_Int32 == null)
				{
					r_MGetEncodingFromProvider_Int32 = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.Int32));
					r_MGetEncodingFromProvider_Int32.SetBelong(null);
				}
				return r_MGetEncodingFromProvider_Int32;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(System.String)
		/// </summary>
		protected static RMethod r_MGetEncodingFromProvider_String;
		public static RMethod RMGetEncodingFromProvider_String
		{
			get
			{
				if(r_MGetEncodingFromProvider_String == null)
				{
					r_MGetEncodingFromProvider_String = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.String));
					r_MGetEncodingFromProvider_String.SetBelong(null);
				}
				return r_MGetEncodingFromProvider_String;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(Int32, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_MGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback;
		public static RMethod RMGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_MGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback == null)
				{
					r_MGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.Int32), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_MGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_MGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncodingFromProvider(System.String, System.Text.EncoderFallback, System.Text.DecoderFallback)
		/// </summary>
		protected static RMethod r_MGetEncodingFromProvider_String_EncoderFallback_DecoderFallback;
		public static RMethod RMGetEncodingFromProvider_String_EncoderFallback_DecoderFallback
		{
			get
			{
				if(r_MGetEncodingFromProvider_String_EncoderFallback_DecoderFallback == null)
				{
					r_MGetEncodingFromProvider_String_EncoderFallback_DecoderFallback = new(typeof(System.Text.EncodingProvider), "GetEncodingFromProvider", 0, typeof(System.String), typeof(System.Text.EncoderFallback), typeof(System.Text.DecoderFallback));
					r_MGetEncodingFromProvider_String_EncoderFallback_DecoderFallback.SetBelong(null);
				}
				return r_MGetEncodingFromProvider_String_EncoderFallback_DecoderFallback;
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

        public virtual System.Text.Encoding GetEncoding(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetEncoding_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Text.Encoding GetEncoding(System.Int32 @codepage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage};
            var ___result = RMGetEncoding_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Text.Encoding GetEncoding(System.String @name, System.Text.EncoderFallback @encoderFallback, System.Text.DecoderFallback @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @encoderFallback, @decoderFallback};
            var ___result = RMGetEncoding_String_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Text.Encoding GetEncoding(System.Int32 @codepage, System.Text.EncoderFallback @encoderFallback, System.Text.DecoderFallback @decoderFallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage, @encoderFallback, @decoderFallback};
            var ___result = RMGetEncoding_Int32_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static void AddProvider(System.Text.EncodingProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMAddProvider_EncodingProvider.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.Int32 @codepage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage};
            var ___result = RMGetEncodingFromProvider_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.String @encodingName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encodingName};
            var ___result = RMGetEncodingFromProvider_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.Int32 @codepage, System.Text.EncoderFallback @enc, System.Text.DecoderFallback @dec)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@codepage, @enc, @dec};
            var ___result = RMGetEncodingFromProvider_Int32_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public static System.Text.Encoding GetEncodingFromProvider(System.String @encodingName, System.Text.EncoderFallback @enc, System.Text.DecoderFallback @dec)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encodingName, @enc, @dec};
            var ___result = RMGetEncodingFromProvider_String_EncoderFallback_DecoderFallback.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
