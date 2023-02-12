
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FiCodePage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFiCodePage
		{
			get
			{
				if(r_FiCodePage == null)
				{
					r_FiCodePage = new(this, "iCodePage");
					r_FiCodePage.SetBelong(this.instance);
				}
				return r_FiCodePage;
			}
		}

		/// <summary>
		/// System.String strEncodingName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FstrEncodingName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFstrEncodingName
		{
			get
			{
				if(r_FstrEncodingName == null)
				{
					r_FstrEncodingName = new(this, "strEncodingName");
					r_FstrEncodingName.SetBelong(this.instance);
				}
				return r_FstrEncodingName;
			}
		}

		/// <summary>
		/// System.String strDisplayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FstrDisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFstrDisplayName
		{
			get
			{
				if(r_FstrDisplayName == null)
				{
					r_FstrDisplayName = new(this, "strDisplayName");
					r_FstrDisplayName.SetBelong(this.instance);
				}
				return r_FstrDisplayName;
			}
		}

		/// <summary>
		/// Int32 CodePage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PCodePage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPCodePage
		{
			get
			{
				if(r_PCodePage == null)
				{
					r_PCodePage = new(this, "CodePage", -1);
					r_PCodePage.SetBelong(this.instance);
				}
				return r_PCodePage;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.String DisplayName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PDisplayName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPDisplayName
		{
			get
			{
				if(r_PDisplayName == null)
				{
					r_PDisplayName = new(this, "DisplayName", -1);
					r_PDisplayName.SetBelong(this.instance);
				}
				return r_PDisplayName;
			}
		}

		/// <summary>
		/// System.Text.Encoding GetEncoding()
		/// </summary>
		protected RMethod r_MGetEncoding;
		public virtual RMethod RMGetEncoding
		{
			get
			{
				if(r_MGetEncoding == null)
				{
					r_MGetEncoding = new(this, "GetEncoding", 0);
					r_MGetEncoding.SetBelong(this.instance);
				}
				return r_MGetEncoding;
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
            var ___result = RMGetEncoding.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
