
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.PackageManager.UI.Internal.UIErrorCode
	/// </summary>
    public partial class RUIErrorCode : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIErrorCode");
            }
        }

        public RUIErrorCode() : base("UnityEditor.PackageManager.UI.Internal.UIErrorCode")
        {
        }

        public RUIErrorCode(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UIErrorCode")
		{
            SetInstance(instance);
		}

        public RUIErrorCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIErrorCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_Unknown;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_Unknown
		{
			get
			{
				if(r_FUpmError_Unknown == null)
				{
					r_FUpmError_Unknown = new(Type, "UpmError_Unknown");
				}
				return r_FUpmError_Unknown;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_NotFound
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_NotFound;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_NotFound
		{
			get
			{
				if(r_FUpmError_NotFound == null)
				{
					r_FUpmError_NotFound = new(Type, "UpmError_NotFound");
				}
				return r_FUpmError_NotFound;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_Forbidden
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_Forbidden;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_Forbidden
		{
			get
			{
				if(r_FUpmError_Forbidden == null)
				{
					r_FUpmError_Forbidden = new(Type, "UpmError_Forbidden");
				}
				return r_FUpmError_Forbidden;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_InvalidParameter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_InvalidParameter;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_InvalidParameter
		{
			get
			{
				if(r_FUpmError_InvalidParameter == null)
				{
					r_FUpmError_InvalidParameter = new(Type, "UpmError_InvalidParameter");
				}
				return r_FUpmError_InvalidParameter;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_Conflict
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_Conflict;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_Conflict
		{
			get
			{
				if(r_FUpmError_Conflict == null)
				{
					r_FUpmError_Conflict = new(Type, "UpmError_Conflict");
				}
				return r_FUpmError_Conflict;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_ServerNotRunning
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_ServerNotRunning;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_ServerNotRunning
		{
			get
			{
				if(r_FUpmError_ServerNotRunning == null)
				{
					r_FUpmError_ServerNotRunning = new(Type, "UpmError_ServerNotRunning");
				}
				return r_FUpmError_ServerNotRunning;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_InvalidSignature
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_InvalidSignature;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_InvalidSignature
		{
			get
			{
				if(r_FUpmError_InvalidSignature == null)
				{
					r_FUpmError_InvalidSignature = new(Type, "UpmError_InvalidSignature");
				}
				return r_FUpmError_InvalidSignature;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_UnsignedUnityPackage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_UnsignedUnityPackage;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_UnsignedUnityPackage
		{
			get
			{
				if(r_FUpmError_UnsignedUnityPackage == null)
				{
					r_FUpmError_UnsignedUnityPackage = new(Type, "UpmError_UnsignedUnityPackage");
				}
				return r_FUpmError_UnsignedUnityPackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_NotSignedIn
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_NotSignedIn;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_NotSignedIn
		{
			get
			{
				if(r_FUpmError_NotSignedIn == null)
				{
					r_FUpmError_NotSignedIn = new(Type, "UpmError_NotSignedIn");
				}
				return r_FUpmError_NotSignedIn;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode UpmError_NotAcquired
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FUpmError_NotAcquired;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFUpmError_NotAcquired
		{
			get
			{
				if(r_FUpmError_NotAcquired == null)
				{
					r_FUpmError_NotAcquired = new(Type, "UpmError_NotAcquired");
				}
				return r_FUpmError_NotAcquired;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode AssetStoreAuthorizationError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FAssetStoreAuthorizationError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFAssetStoreAuthorizationError
		{
			get
			{
				if(r_FAssetStoreAuthorizationError == null)
				{
					r_FAssetStoreAuthorizationError = new(Type, "AssetStoreAuthorizationError");
				}
				return r_FAssetStoreAuthorizationError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode AssetStoreClientError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FAssetStoreClientError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFAssetStoreClientError
		{
			get
			{
				if(r_FAssetStoreClientError == null)
				{
					r_FAssetStoreClientError = new(Type, "AssetStoreClientError");
				}
				return r_FAssetStoreClientError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode AssetStoreRestApiError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FAssetStoreRestApiError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFAssetStoreRestApiError
		{
			get
			{
				if(r_FAssetStoreRestApiError == null)
				{
					r_FAssetStoreRestApiError = new(Type, "AssetStoreRestApiError");
				}
				return r_FAssetStoreRestApiError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode AssetStoreOperationError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FAssetStoreOperationError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFAssetStoreOperationError
		{
			get
			{
				if(r_FAssetStoreOperationError == null)
				{
					r_FAssetStoreOperationError = new(Type, "AssetStoreOperationError");
				}
				return r_FAssetStoreOperationError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UIErrorCode AssetStorePackageError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode r_FAssetStorePackageError;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIErrorCode RFAssetStorePackageError
		{
			get
			{
				if(r_FAssetStorePackageError == null)
				{
					r_FAssetStorePackageError = new(Type, "AssetStorePackageError");
				}
				return r_FAssetStorePackageError;
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
