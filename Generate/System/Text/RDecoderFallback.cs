using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.DecoderFallback
	/// </summary>
    public partial class RDecoderFallback : RMember //
    {

		/// <summary>
		/// System.Text.DecoderFallback s_replacementFallback
		/// </summary>
		protected static RSystem.RText.RDecoderFallback r_s_replacementFallback;
		public static RSystem.RText.RDecoderFallback Rs_replacementFallback
		{
			get
			{
				if(r_s_replacementFallback == null)
				{
					r_s_replacementFallback = new(typeof(System.Text.DecoderFallback), "s_replacementFallback");
					r_s_replacementFallback.SetBelong(null);
				}
				return r_s_replacementFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback s_exceptionFallback
		/// </summary>
		protected static RSystem.RText.RDecoderFallback r_s_exceptionFallback;
		public static RSystem.RText.RDecoderFallback Rs_exceptionFallback
		{
			get
			{
				if(r_s_exceptionFallback == null)
				{
					r_s_exceptionFallback = new(typeof(System.Text.DecoderFallback), "s_exceptionFallback");
					r_s_exceptionFallback.SetBelong(null);
				}
				return r_s_exceptionFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback ReplacementFallback
		/// </summary>
		protected static RSystem.RText.RDecoderFallback r_ReplacementFallback;
		public static RSystem.RText.RDecoderFallback RReplacementFallback
		{
			get
			{
				if(r_ReplacementFallback == null)
				{
					r_ReplacementFallback = new(typeof(System.Text.DecoderFallback), "ReplacementFallback", -1);
					r_ReplacementFallback.SetBelong(null);
				}
				return r_ReplacementFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback ExceptionFallback
		/// </summary>
		protected static RSystem.RText.RDecoderFallback r_ExceptionFallback;
		public static RSystem.RText.RDecoderFallback RExceptionFallback
		{
			get
			{
				if(r_ExceptionFallback == null)
				{
					r_ExceptionFallback = new(typeof(System.Text.DecoderFallback), "ExceptionFallback", -1);
					r_ExceptionFallback.SetBelong(null);
				}
				return r_ExceptionFallback;
			}
		}

		/// <summary>
		/// Int32 MaxCharCount
		/// </summary>
		protected RProperty r_MaxCharCount;
		public virtual RProperty RMaxCharCount
		{
			get
			{
				if(r_MaxCharCount == null)
				{
					r_MaxCharCount = new(this, "MaxCharCount", -1);
					r_MaxCharCount.SetBelong(this.instance);
				}
				return r_MaxCharCount;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallbackBuffer CreateFallbackBuffer()
		/// </summary>
		protected RMethod r_CreateFallbackBuffer;
		public virtual RMethod RCreateFallbackBuffer
		{
			get
			{
				if(r_CreateFallbackBuffer == null)
				{
					r_CreateFallbackBuffer = new(this, "CreateFallbackBuffer", 0);
					r_CreateFallbackBuffer.SetBelong(this.instance);
				}
				return r_CreateFallbackBuffer;
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


        public RDecoderFallback() : base("System.Text.DecoderFallback")
        {
        }

        public RDecoderFallback(System.Object instance) : base("System.Text.DecoderFallback")
		{
            SetInstance(instance);
		}

        public RDecoderFallback(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecoderFallback(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Text.DecoderFallbackBuffer CreateFallbackBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateFallbackBuffer.Invoke(___genericsType, ___parameters);

            return (System.Text.DecoderFallbackBuffer)___result;
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
