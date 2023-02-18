
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PackageTag
	/// </summary>
    public partial class RPackageTag : RMember //
    {

		/// <summary>
		/// System.UInt32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFvalue__
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
		/// UnityEditor.PackageManager.UI.Internal.PackageTag None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag InDevelopment
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FInDevelopment;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFInDevelopment
		{
			get
			{
				if(r_FInDevelopment == null)
				{
					r_FInDevelopment = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "InDevelopment");
				}
				return r_FInDevelopment;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Custom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FCustom;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFCustom
		{
			get
			{
				if(r_FCustom == null)
				{
					r_FCustom = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Custom");
				}
				return r_FCustom;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Local
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FLocal;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFLocal
		{
			get
			{
				if(r_FLocal == null)
				{
					r_FLocal = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Local");
				}
				return r_FLocal;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Git
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FGit;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFGit
		{
			get
			{
				if(r_FGit == null)
				{
					r_FGit = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Git");
				}
				return r_FGit;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Bundled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FBundled;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFBundled
		{
			get
			{
				if(r_FBundled == null)
				{
					r_FBundled = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Bundled");
				}
				return r_FBundled;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag BuiltIn
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FBuiltIn;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFBuiltIn
		{
			get
			{
				if(r_FBuiltIn == null)
				{
					r_FBuiltIn = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "BuiltIn");
				}
				return r_FBuiltIn;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Feature
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FFeature;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFFeature
		{
			get
			{
				if(r_FFeature == null)
				{
					r_FFeature = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Feature");
				}
				return r_FFeature;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Placeholder
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FPlaceholder;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFPlaceholder
		{
			get
			{
				if(r_FPlaceholder == null)
				{
					r_FPlaceholder = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Placeholder");
				}
				return r_FPlaceholder;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag VersionLocked
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FVersionLocked;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFVersionLocked
		{
			get
			{
				if(r_FVersionLocked == null)
				{
					r_FVersionLocked = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "VersionLocked");
				}
				return r_FVersionLocked;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Installable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FInstallable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFInstallable
		{
			get
			{
				if(r_FInstallable == null)
				{
					r_FInstallable = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Installable");
				}
				return r_FInstallable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Removable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FRemovable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFRemovable
		{
			get
			{
				if(r_FRemovable == null)
				{
					r_FRemovable = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Removable");
				}
				return r_FRemovable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Downloadable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FDownloadable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFDownloadable
		{
			get
			{
				if(r_FDownloadable == null)
				{
					r_FDownloadable = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Downloadable");
				}
				return r_FDownloadable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Importable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FImportable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFImportable
		{
			get
			{
				if(r_FImportable == null)
				{
					r_FImportable = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Importable");
				}
				return r_FImportable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Embeddable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FEmbeddable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFEmbeddable
		{
			get
			{
				if(r_FEmbeddable == null)
				{
					r_FEmbeddable = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Embeddable");
				}
				return r_FEmbeddable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Disabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FDisabled;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFDisabled
		{
			get
			{
				if(r_FDisabled == null)
				{
					r_FDisabled = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Disabled");
				}
				return r_FDisabled;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Published
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FPublished;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFPublished
		{
			get
			{
				if(r_FPublished == null)
				{
					r_FPublished = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Published");
				}
				return r_FPublished;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Deprecated
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FDeprecated;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFDeprecated
		{
			get
			{
				if(r_FDeprecated == null)
				{
					r_FDeprecated = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Deprecated");
				}
				return r_FDeprecated;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Release
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FRelease;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFRelease
		{
			get
			{
				if(r_FRelease == null)
				{
					r_FRelease = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Release");
				}
				return r_FRelease;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag Experimental
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FExperimental;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFExperimental
		{
			get
			{
				if(r_FExperimental == null)
				{
					r_FExperimental = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "Experimental");
				}
				return r_FExperimental;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag PreRelease
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FPreRelease;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFPreRelease
		{
			get
			{
				if(r_FPreRelease == null)
				{
					r_FPreRelease = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "PreRelease");
				}
				return r_FPreRelease;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag ReleaseCandidate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_FReleaseCandidate;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFReleaseCandidate
		{
			get
			{
				if(r_FReleaseCandidate == null)
				{
					r_FReleaseCandidate = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"), "ReleaseCandidate");
				}
				return r_FReleaseCandidate;
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


        public RPackageTag() : base("UnityEditor.PackageManager.UI.Internal.PackageTag")
        {
        }

        public RPackageTag(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageTag")
		{
            SetInstance(instance);
		}

        public RPackageTag(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageTag(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
