
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Security.AccessControl.ResourceType
	/// </summary>
    public partial class RResourceType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.AccessControl.ResourceType);
            }
        }

        public RResourceType() : base("System.Security.AccessControl.ResourceType")
        {
        }

        public RResourceType(System.Object instance) : base("System.Security.AccessControl.ResourceType")
		{
            SetInstance(instance);
		}

        public RResourceType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RResourceType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FUnknown;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFUnknown
		{
			get
			{
				if(r_FUnknown == null)
				{
					r_FUnknown = new(Type, "Unknown");
				}
				return r_FUnknown;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType FileObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FFileObject;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFFileObject
		{
			get
			{
				if(r_FFileObject == null)
				{
					r_FFileObject = new(Type, "FileObject");
				}
				return r_FFileObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType Service
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FService;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFService
		{
			get
			{
				if(r_FService == null)
				{
					r_FService = new(Type, "Service");
				}
				return r_FService;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType Printer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FPrinter;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFPrinter
		{
			get
			{
				if(r_FPrinter == null)
				{
					r_FPrinter = new(Type, "Printer");
				}
				return r_FPrinter;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType RegistryKey
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FRegistryKey;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFRegistryKey
		{
			get
			{
				if(r_FRegistryKey == null)
				{
					r_FRegistryKey = new(Type, "RegistryKey");
				}
				return r_FRegistryKey;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType LMShare
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FLMShare;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFLMShare
		{
			get
			{
				if(r_FLMShare == null)
				{
					r_FLMShare = new(Type, "LMShare");
				}
				return r_FLMShare;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType KernelObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FKernelObject;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFKernelObject
		{
			get
			{
				if(r_FKernelObject == null)
				{
					r_FKernelObject = new(Type, "KernelObject");
				}
				return r_FKernelObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType WindowObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FWindowObject;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFWindowObject
		{
			get
			{
				if(r_FWindowObject == null)
				{
					r_FWindowObject = new(Type, "WindowObject");
				}
				return r_FWindowObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType DSObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FDSObject;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFDSObject
		{
			get
			{
				if(r_FDSObject == null)
				{
					r_FDSObject = new(Type, "DSObject");
				}
				return r_FDSObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType DSObjectAll
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FDSObjectAll;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFDSObjectAll
		{
			get
			{
				if(r_FDSObjectAll == null)
				{
					r_FDSObjectAll = new(Type, "DSObjectAll");
				}
				return r_FDSObjectAll;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType ProviderDefined
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FProviderDefined;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFProviderDefined
		{
			get
			{
				if(r_FProviderDefined == null)
				{
					r_FProviderDefined = new(Type, "ProviderDefined");
				}
				return r_FProviderDefined;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType WmiGuidObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FWmiGuidObject;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFWmiGuidObject
		{
			get
			{
				if(r_FWmiGuidObject == null)
				{
					r_FWmiGuidObject = new(Type, "WmiGuidObject");
				}
				return r_FWmiGuidObject;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType RegistryWow6432Key
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType r_FRegistryWow6432Key;
		public static Hvak.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RResourceType RFRegistryWow6432Key
		{
			get
			{
				if(r_FRegistryWow6432Key == null)
				{
					r_FRegistryWow6432Key = new(Type, "RegistryWow6432Key");
				}
				return r_FRegistryWow6432Key;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
