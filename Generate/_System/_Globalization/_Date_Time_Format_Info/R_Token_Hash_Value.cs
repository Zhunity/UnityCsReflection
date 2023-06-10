
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{public partial class RDateTimeFormatInfo
{
	
	/// <summary>
	/// System.Globalization.DateTimeFormatInfo+TokenHashValue
	/// </summary>
    public partial class RTokenHashValue : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Globalization.DateTimeFormatInfo+TokenHashValue");
            }
        }

        public RTokenHashValue() : base("System.Globalization.DateTimeFormatInfo+TokenHashValue")
        {
        }

        public RTokenHashValue(System.Object instance) : base("System.Globalization.DateTimeFormatInfo+TokenHashValue")
		{
            SetInstance(instance);
		}

        public RTokenHashValue(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTokenHashValue(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String tokenString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FtokenString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtokenString
		{
			get
			{
				if(r_FtokenString == null)
				{
					r_FtokenString = new(this, "tokenString");
				}
				return r_FtokenString;
			}
		}

		/// <summary>
		/// System.TokenType tokenType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RTokenType r_FtokenType;
		public virtual Hvak.Editor.Refleaction.RSystem.RTokenType RFtokenType
		{
			get
			{
				if(r_FtokenType == null)
				{
					r_FtokenType = new(this, "tokenType");
				}
				return r_FtokenType;
			}
		}

		/// <summary>
		/// System.Int32 tokenValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FtokenValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtokenValue
		{
			get
			{
				if(r_FtokenValue == null)
				{
					r_FtokenValue = new(this, "tokenValue");
				}
				return r_FtokenValue;
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
}