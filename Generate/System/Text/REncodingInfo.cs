using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.EncodingInfo
	/// </summary>
    public partial class REncodingInfo : RMember //
    {

		/// <summary>
		/// System.Int32 iCodePage
		/// </summary>
		protected RField r_iCodePage;
		public virtual RField RiCodePage
		{
			get
			{
				if(r_iCodePage == null)
				{
					r_iCodePage = new(this, "iCodePage");
					r_iCodePage.SetBelong(this.instance);
				}
				return r_iCodePage;
			}
		}

		/// <summary>
		/// System.String strEncodingName
		/// </summary>
		protected RField r_strEncodingName;
		public virtual RField RstrEncodingName
		{
			get
			{
				if(r_strEncodingName == null)
				{
					r_strEncodingName = new(this, "strEncodingName");
					r_strEncodingName.SetBelong(this.instance);
				}
				return r_strEncodingName;
			}
		}

		/// <summary>
		/// System.String strDisplayName
		/// </summary>
		protected RField r_strDisplayName;
		public virtual RField RstrDisplayName
		{
			get
			{
				if(r_strDisplayName == null)
				{
					r_strDisplayName = new(this, "strDisplayName");
					r_strDisplayName.SetBelong(this.instance);
				}
				return r_strDisplayName;
			}
		}

		/// <summary>
		/// Int32 CodePage
		/// </summary>
		protected RProperty r_CodePage;
		public virtual RProperty RCodePage
		{
			get
			{
				if(r_CodePage == null)
				{
					r_CodePage = new(this, "CodePage", -1);
					r_CodePage.SetBelong(this.instance);
				}
				return r_CodePage;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String DisplayName
		/// </summary>
		protected RProperty r_DisplayName;
		public virtual RProperty RDisplayName
		{
			get
			{
				if(r_DisplayName == null)
				{
					r_DisplayName = new(this, "DisplayName", -1);
					r_DisplayName.SetBelong(this.instance);
				}
				return r_DisplayName;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding()
		/// </summary>
		protected RMethod r_RGetEncoding;
		public virtual RMethod RGetEncoding
		{
			get
			{
				if(r_RGetEncoding == null)
				{
					r_RGetEncoding = new(this, "GetEncoding", 0);
					r_RGetEncoding.SetBelong(this.instance);
				}
				return r_RGetEncoding;
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


        public REncodingInfo() : base("System.Text.EncodingInfo")
        {
        }

        public REncodingInfo(System.Object instance) : base("System.Text.EncodingInfo")
		{
            SetInstance(instance);
		}

        public REncodingInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REncodingInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Text.Encoding GetEncoding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEncoding.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Boolean Equals(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
