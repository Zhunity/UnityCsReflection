
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{public partial class RCultureInfo
{
	
	/// <summary>
	/// System.Globalization.CultureInfo+Data
	/// </summary>
    public partial class RData : RMember //
    {

		/// <summary>
		/// System.Int32 ansi
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fansi;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFansi
		{
			get
			{
				if(r_Fansi == null)
				{
					r_Fansi = new(this, "ansi");
				}
				return r_Fansi;
			}
		}

		/// <summary>
		/// System.Int32 ebcdic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Febcdic;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFebcdic
		{
			get
			{
				if(r_Febcdic == null)
				{
					r_Febcdic = new(this, "ebcdic");
				}
				return r_Febcdic;
			}
		}

		/// <summary>
		/// System.Int32 mac
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmac;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmac
		{
			get
			{
				if(r_Fmac == null)
				{
					r_Fmac = new(this, "mac");
				}
				return r_Fmac;
			}
		}

		/// <summary>
		/// System.Int32 oem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Foem;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFoem
		{
			get
			{
				if(r_Foem == null)
				{
					r_Foem = new(this, "oem");
				}
				return r_Foem;
			}
		}

		/// <summary>
		/// System.Boolean right_to_left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fright_to_left;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFright_to_left
		{
			get
			{
				if(r_Fright_to_left == null)
				{
					r_Fright_to_left = new(this, "right_to_left");
				}
				return r_Fright_to_left;
			}
		}

		/// <summary>
		/// System.Byte list_sep
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Flist_sep;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFlist_sep
		{
			get
			{
				if(r_Flist_sep == null)
				{
					r_Flist_sep = new(this, "list_sep");
				}
				return r_Flist_sep;
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


        public RData() : base("System.Globalization.CultureInfo+Data")
        {
        }

        public RData(System.Object instance) : base("System.Globalization.CultureInfo+Data")
		{
            SetInstance(instance);
		}

        public RData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}