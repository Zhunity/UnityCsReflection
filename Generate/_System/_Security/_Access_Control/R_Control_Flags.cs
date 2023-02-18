
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.ControlFlags
	/// </summary>
    public partial class RControlFlags : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.GetValue());
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FNone;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(System.Security.AccessControl.ControlFlags), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags OwnerDefaulted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FOwnerDefaulted;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFOwnerDefaulted
		{
			get
			{
				if(r_FOwnerDefaulted == null)
				{
					r_FOwnerDefaulted = new(typeof(System.Security.AccessControl.ControlFlags), "OwnerDefaulted");
					r_FOwnerDefaulted.SetBelong(null);
				}
				return r_FOwnerDefaulted;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags GroupDefaulted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FGroupDefaulted;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFGroupDefaulted
		{
			get
			{
				if(r_FGroupDefaulted == null)
				{
					r_FGroupDefaulted = new(typeof(System.Security.AccessControl.ControlFlags), "GroupDefaulted");
					r_FGroupDefaulted.SetBelong(null);
				}
				return r_FGroupDefaulted;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags DiscretionaryAclPresent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FDiscretionaryAclPresent;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFDiscretionaryAclPresent
		{
			get
			{
				if(r_FDiscretionaryAclPresent == null)
				{
					r_FDiscretionaryAclPresent = new(typeof(System.Security.AccessControl.ControlFlags), "DiscretionaryAclPresent");
					r_FDiscretionaryAclPresent.SetBelong(null);
				}
				return r_FDiscretionaryAclPresent;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags DiscretionaryAclDefaulted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FDiscretionaryAclDefaulted;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFDiscretionaryAclDefaulted
		{
			get
			{
				if(r_FDiscretionaryAclDefaulted == null)
				{
					r_FDiscretionaryAclDefaulted = new(typeof(System.Security.AccessControl.ControlFlags), "DiscretionaryAclDefaulted");
					r_FDiscretionaryAclDefaulted.SetBelong(null);
				}
				return r_FDiscretionaryAclDefaulted;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags SystemAclPresent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FSystemAclPresent;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFSystemAclPresent
		{
			get
			{
				if(r_FSystemAclPresent == null)
				{
					r_FSystemAclPresent = new(typeof(System.Security.AccessControl.ControlFlags), "SystemAclPresent");
					r_FSystemAclPresent.SetBelong(null);
				}
				return r_FSystemAclPresent;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags SystemAclDefaulted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FSystemAclDefaulted;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFSystemAclDefaulted
		{
			get
			{
				if(r_FSystemAclDefaulted == null)
				{
					r_FSystemAclDefaulted = new(typeof(System.Security.AccessControl.ControlFlags), "SystemAclDefaulted");
					r_FSystemAclDefaulted.SetBelong(null);
				}
				return r_FSystemAclDefaulted;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags DiscretionaryAclUntrusted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FDiscretionaryAclUntrusted;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFDiscretionaryAclUntrusted
		{
			get
			{
				if(r_FDiscretionaryAclUntrusted == null)
				{
					r_FDiscretionaryAclUntrusted = new(typeof(System.Security.AccessControl.ControlFlags), "DiscretionaryAclUntrusted");
					r_FDiscretionaryAclUntrusted.SetBelong(null);
				}
				return r_FDiscretionaryAclUntrusted;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags ServerSecurity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FServerSecurity;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFServerSecurity
		{
			get
			{
				if(r_FServerSecurity == null)
				{
					r_FServerSecurity = new(typeof(System.Security.AccessControl.ControlFlags), "ServerSecurity");
					r_FServerSecurity.SetBelong(null);
				}
				return r_FServerSecurity;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags DiscretionaryAclAutoInheritRequired
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FDiscretionaryAclAutoInheritRequired;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFDiscretionaryAclAutoInheritRequired
		{
			get
			{
				if(r_FDiscretionaryAclAutoInheritRequired == null)
				{
					r_FDiscretionaryAclAutoInheritRequired = new(typeof(System.Security.AccessControl.ControlFlags), "DiscretionaryAclAutoInheritRequired");
					r_FDiscretionaryAclAutoInheritRequired.SetBelong(null);
				}
				return r_FDiscretionaryAclAutoInheritRequired;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags SystemAclAutoInheritRequired
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FSystemAclAutoInheritRequired;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFSystemAclAutoInheritRequired
		{
			get
			{
				if(r_FSystemAclAutoInheritRequired == null)
				{
					r_FSystemAclAutoInheritRequired = new(typeof(System.Security.AccessControl.ControlFlags), "SystemAclAutoInheritRequired");
					r_FSystemAclAutoInheritRequired.SetBelong(null);
				}
				return r_FSystemAclAutoInheritRequired;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags DiscretionaryAclAutoInherited
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FDiscretionaryAclAutoInherited;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFDiscretionaryAclAutoInherited
		{
			get
			{
				if(r_FDiscretionaryAclAutoInherited == null)
				{
					r_FDiscretionaryAclAutoInherited = new(typeof(System.Security.AccessControl.ControlFlags), "DiscretionaryAclAutoInherited");
					r_FDiscretionaryAclAutoInherited.SetBelong(null);
				}
				return r_FDiscretionaryAclAutoInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags SystemAclAutoInherited
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FSystemAclAutoInherited;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFSystemAclAutoInherited
		{
			get
			{
				if(r_FSystemAclAutoInherited == null)
				{
					r_FSystemAclAutoInherited = new(typeof(System.Security.AccessControl.ControlFlags), "SystemAclAutoInherited");
					r_FSystemAclAutoInherited.SetBelong(null);
				}
				return r_FSystemAclAutoInherited;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags DiscretionaryAclProtected
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FDiscretionaryAclProtected;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFDiscretionaryAclProtected
		{
			get
			{
				if(r_FDiscretionaryAclProtected == null)
				{
					r_FDiscretionaryAclProtected = new(typeof(System.Security.AccessControl.ControlFlags), "DiscretionaryAclProtected");
					r_FDiscretionaryAclProtected.SetBelong(null);
				}
				return r_FDiscretionaryAclProtected;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags SystemAclProtected
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FSystemAclProtected;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFSystemAclProtected
		{
			get
			{
				if(r_FSystemAclProtected == null)
				{
					r_FSystemAclProtected = new(typeof(System.Security.AccessControl.ControlFlags), "SystemAclProtected");
					r_FSystemAclProtected.SetBelong(null);
				}
				return r_FSystemAclProtected;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags RMControlValid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FRMControlValid;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFRMControlValid
		{
			get
			{
				if(r_FRMControlValid == null)
				{
					r_FRMControlValid = new(typeof(System.Security.AccessControl.ControlFlags), "RMControlValid");
					r_FRMControlValid.SetBelong(null);
				}
				return r_FRMControlValid;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ControlFlags SelfRelative
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags r_FSelfRelative;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RControlFlags RFSelfRelative
		{
			get
			{
				if(r_FSelfRelative == null)
				{
					r_FSelfRelative = new(typeof(System.Security.AccessControl.ControlFlags), "SelfRelative");
					r_FSelfRelative.SetBelong(null);
				}
				return r_FSelfRelative;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.GetValue());
				}
				return r_MGetValue;
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

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.GetValue());
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.GetValue());
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.GetValue());
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.GetValue());
				}
				return r_MGetTypeCode;
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


        public RControlFlags() : base("System.Security.AccessControl.ControlFlags")
        {
        }

        public RControlFlags(System.Object instance) : base("System.Security.AccessControl.ControlFlags")
		{
            SetInstance(instance);
		}

        public RControlFlags(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RControlFlags(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
