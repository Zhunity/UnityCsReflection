using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
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
		protected RField r_ansi;
		public virtual RField Ransi
		{
			get
			{
				if(r_ansi == null)
				{
					r_ansi = new(this, "ansi");
					r_ansi.SetBelong(this.instance);
				}
				return r_ansi;
			}
		}

		/// <summary>
		/// System.Int32 ebcdic
		/// </summary>
		protected RField r_ebcdic;
		public virtual RField Rebcdic
		{
			get
			{
				if(r_ebcdic == null)
				{
					r_ebcdic = new(this, "ebcdic");
					r_ebcdic.SetBelong(this.instance);
				}
				return r_ebcdic;
			}
		}

		/// <summary>
		/// System.Int32 mac
		/// </summary>
		protected RField r_mac;
		public virtual RField Rmac
		{
			get
			{
				if(r_mac == null)
				{
					r_mac = new(this, "mac");
					r_mac.SetBelong(this.instance);
				}
				return r_mac;
			}
		}

		/// <summary>
		/// System.Int32 oem
		/// </summary>
		protected RField r_oem;
		public virtual RField Roem
		{
			get
			{
				if(r_oem == null)
				{
					r_oem = new(this, "oem");
					r_oem.SetBelong(this.instance);
				}
				return r_oem;
			}
		}

		/// <summary>
		/// System.Boolean right_to_left
		/// </summary>
		protected RField r_right_to_left;
		public virtual RField Rright_to_left
		{
			get
			{
				if(r_right_to_left == null)
				{
					r_right_to_left = new(this, "right_to_left");
					r_right_to_left.SetBelong(this.instance);
				}
				return r_right_to_left;
			}
		}

		/// <summary>
		/// System.Byte list_sep
		/// </summary>
		protected RField r_list_sep;
		public virtual RField Rlist_sep
		{
			get
			{
				if(r_list_sep == null)
				{
					r_list_sep = new(this, "list_sep");
					r_list_sep.SetBelong(this.instance);
				}
				return r_list_sep;
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
}