
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.DecoderFallback
	/// </summary>
    public partial class RDecoderFallback : RMember //
    {

		/// <summary>
		/// System.Text.DecoderFallback s_replacementFallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback r_Fs_replacementFallback;
		public static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback RFs_replacementFallback
		{
			get
			{
				if(r_Fs_replacementFallback == null)
				{
					r_Fs_replacementFallback = new(typeof(System.Text.DecoderFallback), "s_replacementFallback");
					r_Fs_replacementFallback.SetBelong(null);
				}
				return r_Fs_replacementFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback s_exceptionFallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback r_Fs_exceptionFallback;
		public static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback RFs_exceptionFallback
		{
			get
			{
				if(r_Fs_exceptionFallback == null)
				{
					r_Fs_exceptionFallback = new(typeof(System.Text.DecoderFallback), "s_exceptionFallback");
					r_Fs_exceptionFallback.SetBelong(null);
				}
				return r_Fs_exceptionFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback ReplacementFallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback r_PReplacementFallback;
		public static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback RPReplacementFallback
		{
			get
			{
				if(r_PReplacementFallback == null)
				{
					r_PReplacementFallback = new(typeof(System.Text.DecoderFallback), "ReplacementFallback", -1);
					r_PReplacementFallback.SetBelong(null);
				}
				return r_PReplacementFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback ExceptionFallback
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback r_PExceptionFallback;
		public static Hvak.Editor.Refleaction.RSystem.RText.RDecoderFallback RPExceptionFallback
		{
			get
			{
				if(r_PExceptionFallback == null)
				{
					r_PExceptionFallback = new(typeof(System.Text.DecoderFallback), "ExceptionFallback", -1);
					r_PExceptionFallback.SetBelong(null);
				}
				return r_PExceptionFallback;
			}
		}

		/// <summary>
		/// Int32 MaxCharCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMaxCharCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMaxCharCount
		{
			get
			{
				if(r_PMaxCharCount == null)
				{
					r_PMaxCharCount = new(this, "MaxCharCount", -1);
					r_PMaxCharCount.SetBelong(this.GetValue());
				}
				return r_PMaxCharCount;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallbackBuffer CreateFallbackBuffer()
		/// </summary>
		protected RMethod r_MCreateFallbackBuffer;
		public virtual RMethod RMCreateFallbackBuffer
		{
			get
			{
				if(r_MCreateFallbackBuffer == null)
				{
					r_MCreateFallbackBuffer = new(this, "CreateFallbackBuffer", 0);
					r_MCreateFallbackBuffer.SetBelong(this.GetValue());
				}
				return r_MCreateFallbackBuffer;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMCreateFallbackBuffer.Invoke(___genericsType, ___parameters);

            return (System.Text.DecoderFallbackBuffer)___result;
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
