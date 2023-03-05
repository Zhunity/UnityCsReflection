
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.NativeErrorCode
	/// </summary>
    public partial class RNativeErrorCode : RMember //
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
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FUnknown;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFUnknown
		{
			get
			{
				if(r_FUnknown == null)
				{
					r_FUnknown = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "Unknown");
				}
				return r_FUnknown;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode NotFound
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FNotFound;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFNotFound
		{
			get
			{
				if(r_FNotFound == null)
				{
					r_FNotFound = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "NotFound");
				}
				return r_FNotFound;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode Forbidden
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FForbidden;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFForbidden
		{
			get
			{
				if(r_FForbidden == null)
				{
					r_FForbidden = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "Forbidden");
				}
				return r_FForbidden;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode InvalidParameter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FInvalidParameter;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFInvalidParameter
		{
			get
			{
				if(r_FInvalidParameter == null)
				{
					r_FInvalidParameter = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "InvalidParameter");
				}
				return r_FInvalidParameter;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode Conflict
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FConflict;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFConflict
		{
			get
			{
				if(r_FConflict == null)
				{
					r_FConflict = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "Conflict");
				}
				return r_FConflict;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode AggregateError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FAggregateError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFAggregateError
		{
			get
			{
				if(r_FAggregateError == null)
				{
					r_FAggregateError = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "AggregateError");
				}
				return r_FAggregateError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode Cancelled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FCancelled;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFCancelled
		{
			get
			{
				if(r_FCancelled == null)
				{
					r_FCancelled = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "Cancelled");
				}
				return r_FCancelled;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode Success
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_FSuccess;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFSuccess
		{
			get
			{
				if(r_FSuccess == null)
				{
					r_FSuccess = new( ReflectionUtils.GetType("UnityEditor.PackageManager.NativeErrorCode"), "Success");
				}
				return r_FSuccess;
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


        public RNativeErrorCode() : base("UnityEditor.PackageManager.NativeErrorCode")
        {
        }

        public RNativeErrorCode(System.Object instance) : base("UnityEditor.PackageManager.NativeErrorCode")
		{
            SetInstance(instance);
		}

        public RNativeErrorCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNativeErrorCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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