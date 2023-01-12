using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.BindingFlags
	/// </summary>
    public partial class RBindingFlags : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected RSystem.RInt32 r_Fvalue__;
		public virtual RSystem.RInt32 RFvalue__
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
		/// System.Reflection.BindingFlags Default
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FDefault;
		public static RSystem.RReflection.RBindingFlags RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new(typeof(System.Reflection.BindingFlags), "Default");
					r_FDefault.SetBelong(null);
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags IgnoreCase
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FIgnoreCase;
		public static RSystem.RReflection.RBindingFlags RFIgnoreCase
		{
			get
			{
				if(r_FIgnoreCase == null)
				{
					r_FIgnoreCase = new(typeof(System.Reflection.BindingFlags), "IgnoreCase");
					r_FIgnoreCase.SetBelong(null);
				}
				return r_FIgnoreCase;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DeclaredOnly
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FDeclaredOnly;
		public static RSystem.RReflection.RBindingFlags RFDeclaredOnly
		{
			get
			{
				if(r_FDeclaredOnly == null)
				{
					r_FDeclaredOnly = new(typeof(System.Reflection.BindingFlags), "DeclaredOnly");
					r_FDeclaredOnly.SetBelong(null);
				}
				return r_FDeclaredOnly;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags Instance
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FInstance;
		public static RSystem.RReflection.RBindingFlags RFInstance
		{
			get
			{
				if(r_FInstance == null)
				{
					r_FInstance = new(typeof(System.Reflection.BindingFlags), "Instance");
					r_FInstance.SetBelong(null);
				}
				return r_FInstance;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags Static
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FStatic;
		public static RSystem.RReflection.RBindingFlags RFStatic
		{
			get
			{
				if(r_FStatic == null)
				{
					r_FStatic = new(typeof(System.Reflection.BindingFlags), "Static");
					r_FStatic.SetBelong(null);
				}
				return r_FStatic;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags Public
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FPublic;
		public static RSystem.RReflection.RBindingFlags RFPublic
		{
			get
			{
				if(r_FPublic == null)
				{
					r_FPublic = new(typeof(System.Reflection.BindingFlags), "Public");
					r_FPublic.SetBelong(null);
				}
				return r_FPublic;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags NonPublic
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FNonPublic;
		public static RSystem.RReflection.RBindingFlags RFNonPublic
		{
			get
			{
				if(r_FNonPublic == null)
				{
					r_FNonPublic = new(typeof(System.Reflection.BindingFlags), "NonPublic");
					r_FNonPublic.SetBelong(null);
				}
				return r_FNonPublic;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags FlattenHierarchy
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FFlattenHierarchy;
		public static RSystem.RReflection.RBindingFlags RFFlattenHierarchy
		{
			get
			{
				if(r_FFlattenHierarchy == null)
				{
					r_FFlattenHierarchy = new(typeof(System.Reflection.BindingFlags), "FlattenHierarchy");
					r_FFlattenHierarchy.SetBelong(null);
				}
				return r_FFlattenHierarchy;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags InvokeMethod
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FInvokeMethod;
		public static RSystem.RReflection.RBindingFlags RFInvokeMethod
		{
			get
			{
				if(r_FInvokeMethod == null)
				{
					r_FInvokeMethod = new(typeof(System.Reflection.BindingFlags), "InvokeMethod");
					r_FInvokeMethod.SetBelong(null);
				}
				return r_FInvokeMethod;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags CreateInstance
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FCreateInstance;
		public static RSystem.RReflection.RBindingFlags RFCreateInstance
		{
			get
			{
				if(r_FCreateInstance == null)
				{
					r_FCreateInstance = new(typeof(System.Reflection.BindingFlags), "CreateInstance");
					r_FCreateInstance.SetBelong(null);
				}
				return r_FCreateInstance;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags GetField
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FGetField;
		public static RSystem.RReflection.RBindingFlags RFGetField
		{
			get
			{
				if(r_FGetField == null)
				{
					r_FGetField = new(typeof(System.Reflection.BindingFlags), "GetField");
					r_FGetField.SetBelong(null);
				}
				return r_FGetField;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags SetField
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FSetField;
		public static RSystem.RReflection.RBindingFlags RFSetField
		{
			get
			{
				if(r_FSetField == null)
				{
					r_FSetField = new(typeof(System.Reflection.BindingFlags), "SetField");
					r_FSetField.SetBelong(null);
				}
				return r_FSetField;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags GetProperty
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FGetProperty;
		public static RSystem.RReflection.RBindingFlags RFGetProperty
		{
			get
			{
				if(r_FGetProperty == null)
				{
					r_FGetProperty = new(typeof(System.Reflection.BindingFlags), "GetProperty");
					r_FGetProperty.SetBelong(null);
				}
				return r_FGetProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags SetProperty
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FSetProperty;
		public static RSystem.RReflection.RBindingFlags RFSetProperty
		{
			get
			{
				if(r_FSetProperty == null)
				{
					r_FSetProperty = new(typeof(System.Reflection.BindingFlags), "SetProperty");
					r_FSetProperty.SetBelong(null);
				}
				return r_FSetProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags PutDispProperty
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FPutDispProperty;
		public static RSystem.RReflection.RBindingFlags RFPutDispProperty
		{
			get
			{
				if(r_FPutDispProperty == null)
				{
					r_FPutDispProperty = new(typeof(System.Reflection.BindingFlags), "PutDispProperty");
					r_FPutDispProperty.SetBelong(null);
				}
				return r_FPutDispProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags PutRefDispProperty
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FPutRefDispProperty;
		public static RSystem.RReflection.RBindingFlags RFPutRefDispProperty
		{
			get
			{
				if(r_FPutRefDispProperty == null)
				{
					r_FPutRefDispProperty = new(typeof(System.Reflection.BindingFlags), "PutRefDispProperty");
					r_FPutRefDispProperty.SetBelong(null);
				}
				return r_FPutRefDispProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags ExactBinding
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FExactBinding;
		public static RSystem.RReflection.RBindingFlags RFExactBinding
		{
			get
			{
				if(r_FExactBinding == null)
				{
					r_FExactBinding = new(typeof(System.Reflection.BindingFlags), "ExactBinding");
					r_FExactBinding.SetBelong(null);
				}
				return r_FExactBinding;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags SuppressChangeType
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FSuppressChangeType;
		public static RSystem.RReflection.RBindingFlags RFSuppressChangeType
		{
			get
			{
				if(r_FSuppressChangeType == null)
				{
					r_FSuppressChangeType = new(typeof(System.Reflection.BindingFlags), "SuppressChangeType");
					r_FSuppressChangeType.SetBelong(null);
				}
				return r_FSuppressChangeType;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags OptionalParamBinding
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FOptionalParamBinding;
		public static RSystem.RReflection.RBindingFlags RFOptionalParamBinding
		{
			get
			{
				if(r_FOptionalParamBinding == null)
				{
					r_FOptionalParamBinding = new(typeof(System.Reflection.BindingFlags), "OptionalParamBinding");
					r_FOptionalParamBinding.SetBelong(null);
				}
				return r_FOptionalParamBinding;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags IgnoreReturn
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FIgnoreReturn;
		public static RSystem.RReflection.RBindingFlags RFIgnoreReturn
		{
			get
			{
				if(r_FIgnoreReturn == null)
				{
					r_FIgnoreReturn = new(typeof(System.Reflection.BindingFlags), "IgnoreReturn");
					r_FIgnoreReturn.SetBelong(null);
				}
				return r_FIgnoreReturn;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DoNotWrapExceptions
		/// </summary>
		protected static RSystem.RReflection.RBindingFlags r_FDoNotWrapExceptions;
		public static RSystem.RReflection.RBindingFlags RFDoNotWrapExceptions
		{
			get
			{
				if(r_FDoNotWrapExceptions == null)
				{
					r_FDoNotWrapExceptions = new(typeof(System.Reflection.BindingFlags), "DoNotWrapExceptions");
					r_FDoNotWrapExceptions.SetBelong(null);
				}
				return r_FDoNotWrapExceptions;
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


        public RBindingFlags() : base("System.Reflection.BindingFlags")
        {
        }

        public RBindingFlags(System.Object instance) : base("System.Reflection.BindingFlags")
		{
            SetInstance(instance);
		}

        public RBindingFlags(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBindingFlags(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
