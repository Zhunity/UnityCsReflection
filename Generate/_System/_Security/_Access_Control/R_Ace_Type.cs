
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.AceType
	/// </summary>
    public partial class RAceType : RMember //
    {

		/// <summary>
		/// System.Byte value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RByte r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RByte RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessAllowed
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessAllowed;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessAllowed
		{
			get
			{
				if(r_FAccessAllowed == null)
				{
					r_FAccessAllowed = new(typeof(System.Security.AccessControl.AceType), "AccessAllowed");
					r_FAccessAllowed.SetBelong(null);
				}
				return r_FAccessAllowed;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessDenied
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessDenied;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessDenied
		{
			get
			{
				if(r_FAccessDenied == null)
				{
					r_FAccessDenied = new(typeof(System.Security.AccessControl.AceType), "AccessDenied");
					r_FAccessDenied.SetBelong(null);
				}
				return r_FAccessDenied;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAudit
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAudit;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAudit
		{
			get
			{
				if(r_FSystemAudit == null)
				{
					r_FSystemAudit = new(typeof(System.Security.AccessControl.AceType), "SystemAudit");
					r_FSystemAudit.SetBelong(null);
				}
				return r_FSystemAudit;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAlarm
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAlarm;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAlarm
		{
			get
			{
				if(r_FSystemAlarm == null)
				{
					r_FSystemAlarm = new(typeof(System.Security.AccessControl.AceType), "SystemAlarm");
					r_FSystemAlarm.SetBelong(null);
				}
				return r_FSystemAlarm;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessAllowedCompound
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessAllowedCompound;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessAllowedCompound
		{
			get
			{
				if(r_FAccessAllowedCompound == null)
				{
					r_FAccessAllowedCompound = new(typeof(System.Security.AccessControl.AceType), "AccessAllowedCompound");
					r_FAccessAllowedCompound.SetBelong(null);
				}
				return r_FAccessAllowedCompound;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessAllowedObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessAllowedObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessAllowedObject
		{
			get
			{
				if(r_FAccessAllowedObject == null)
				{
					r_FAccessAllowedObject = new(typeof(System.Security.AccessControl.AceType), "AccessAllowedObject");
					r_FAccessAllowedObject.SetBelong(null);
				}
				return r_FAccessAllowedObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessDeniedObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessDeniedObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessDeniedObject
		{
			get
			{
				if(r_FAccessDeniedObject == null)
				{
					r_FAccessDeniedObject = new(typeof(System.Security.AccessControl.AceType), "AccessDeniedObject");
					r_FAccessDeniedObject.SetBelong(null);
				}
				return r_FAccessDeniedObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAuditObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAuditObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAuditObject
		{
			get
			{
				if(r_FSystemAuditObject == null)
				{
					r_FSystemAuditObject = new(typeof(System.Security.AccessControl.AceType), "SystemAuditObject");
					r_FSystemAuditObject.SetBelong(null);
				}
				return r_FSystemAuditObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAlarmObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAlarmObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAlarmObject
		{
			get
			{
				if(r_FSystemAlarmObject == null)
				{
					r_FSystemAlarmObject = new(typeof(System.Security.AccessControl.AceType), "SystemAlarmObject");
					r_FSystemAlarmObject.SetBelong(null);
				}
				return r_FSystemAlarmObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessAllowedCallback
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessAllowedCallback;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessAllowedCallback
		{
			get
			{
				if(r_FAccessAllowedCallback == null)
				{
					r_FAccessAllowedCallback = new(typeof(System.Security.AccessControl.AceType), "AccessAllowedCallback");
					r_FAccessAllowedCallback.SetBelong(null);
				}
				return r_FAccessAllowedCallback;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessDeniedCallback
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessDeniedCallback;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessDeniedCallback
		{
			get
			{
				if(r_FAccessDeniedCallback == null)
				{
					r_FAccessDeniedCallback = new(typeof(System.Security.AccessControl.AceType), "AccessDeniedCallback");
					r_FAccessDeniedCallback.SetBelong(null);
				}
				return r_FAccessDeniedCallback;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessAllowedCallbackObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessAllowedCallbackObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessAllowedCallbackObject
		{
			get
			{
				if(r_FAccessAllowedCallbackObject == null)
				{
					r_FAccessAllowedCallbackObject = new(typeof(System.Security.AccessControl.AceType), "AccessAllowedCallbackObject");
					r_FAccessAllowedCallbackObject.SetBelong(null);
				}
				return r_FAccessAllowedCallbackObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType AccessDeniedCallbackObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FAccessDeniedCallbackObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFAccessDeniedCallbackObject
		{
			get
			{
				if(r_FAccessDeniedCallbackObject == null)
				{
					r_FAccessDeniedCallbackObject = new(typeof(System.Security.AccessControl.AceType), "AccessDeniedCallbackObject");
					r_FAccessDeniedCallbackObject.SetBelong(null);
				}
				return r_FAccessDeniedCallbackObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAuditCallback
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAuditCallback;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAuditCallback
		{
			get
			{
				if(r_FSystemAuditCallback == null)
				{
					r_FSystemAuditCallback = new(typeof(System.Security.AccessControl.AceType), "SystemAuditCallback");
					r_FSystemAuditCallback.SetBelong(null);
				}
				return r_FSystemAuditCallback;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAlarmCallback
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAlarmCallback;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAlarmCallback
		{
			get
			{
				if(r_FSystemAlarmCallback == null)
				{
					r_FSystemAlarmCallback = new(typeof(System.Security.AccessControl.AceType), "SystemAlarmCallback");
					r_FSystemAlarmCallback.SetBelong(null);
				}
				return r_FSystemAlarmCallback;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAuditCallbackObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAuditCallbackObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAuditCallbackObject
		{
			get
			{
				if(r_FSystemAuditCallbackObject == null)
				{
					r_FSystemAuditCallbackObject = new(typeof(System.Security.AccessControl.AceType), "SystemAuditCallbackObject");
					r_FSystemAuditCallbackObject.SetBelong(null);
				}
				return r_FSystemAuditCallbackObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType SystemAlarmCallbackObject
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FSystemAlarmCallbackObject;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFSystemAlarmCallbackObject
		{
			get
			{
				if(r_FSystemAlarmCallbackObject == null)
				{
					r_FSystemAlarmCallbackObject = new(typeof(System.Security.AccessControl.AceType), "SystemAlarmCallbackObject");
					r_FSystemAlarmCallbackObject.SetBelong(null);
				}
				return r_FSystemAlarmCallbackObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AceType MaxDefinedAceType
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType r_FMaxDefinedAceType;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RAceType RFMaxDefinedAceType
		{
			get
			{
				if(r_FMaxDefinedAceType == null)
				{
					r_FMaxDefinedAceType = new(typeof(System.Security.AccessControl.AceType), "MaxDefinedAceType");
					r_FMaxDefinedAceType.SetBelong(null);
				}
				return r_FMaxDefinedAceType;
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
					r_MGetValue.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
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
					r_MCompareTo_Object.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_IFormatProvider.SetBelong(this.instance);
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
					r_MHasFlag_Enum.SetBelong(this.instance);
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
					r_MGetTypeCode.SetBelong(this.instance);
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


        public RAceType() : base("System.Security.AccessControl.AceType")
        {
        }

        public RAceType(System.Object instance) : base("System.Security.AccessControl.AceType")
		{
            SetInstance(instance);
		}

        public RAceType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAceType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
