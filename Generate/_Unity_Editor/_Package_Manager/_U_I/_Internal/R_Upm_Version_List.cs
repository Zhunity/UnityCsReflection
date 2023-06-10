
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.UpmVersionList
	/// </summary>
    public partial class RUpmVersionList : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmVersionList");
            }
        }

        public RUpmVersionList() : base("UnityEditor.PackageManager.UI.Internal.UpmVersionList")
        {
        }

        public RUpmVersionList(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UpmVersionList")
		{
            SetInstance(instance);
		}

        public RUpmVersionList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmVersionList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.UpmPackageVersion] m_Versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion> r_Fm_Versions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion> RFm_Versions
		{
			get
			{
				if(r_Fm_Versions == null)
				{
					r_Fm_Versions = new(this, "m_Versions");
				}
				return r_Fm_Versions;
			}
		}

		/// <summary>
		/// System.Int32 m_NumUnloadedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NumUnloadedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NumUnloadedVersions
		{
			get
			{
				if(r_Fm_NumUnloadedVersions == null)
				{
					r_Fm_NumUnloadedVersions = new(this, "m_NumUnloadedVersions");
				}
				return r_Fm_NumUnloadedVersions;
			}
		}

		/// <summary>
		/// System.Int32 m_InstalledIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_InstalledIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_InstalledIndex
		{
			get
			{
				if(r_Fm_InstalledIndex == null)
				{
					r_Fm_InstalledIndex = new(this, "m_InstalledIndex");
				}
				return r_Fm_InstalledIndex;
			}
		}

		/// <summary>
		/// System.String m_LifecycleVersionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LifecycleVersionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LifecycleVersionString
		{
			get
			{
				if(r_Fm_LifecycleVersionString == null)
				{
					r_Fm_LifecycleVersionString = new(this, "m_LifecycleVersionString");
				}
				return r_Fm_LifecycleVersionString;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] m_LifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Fm_LifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RFm_LifecycleVersion
		{
			get
			{
				if(r_Fm_LifecycleVersion == null)
				{
					r_Fm_LifecycleVersion = new(this, "m_LifecycleVersion");
				}
				return r_Fm_LifecycleVersion;
			}
		}

		/// <summary>
		/// System.String m_LifecycleNextVersionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LifecycleNextVersionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LifecycleNextVersionString
		{
			get
			{
				if(r_Fm_LifecycleNextVersionString == null)
				{
					r_Fm_LifecycleNextVersionString = new(this, "m_LifecycleNextVersionString");
				}
				return r_Fm_LifecycleNextVersionString;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] m_LifecycleNextVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Fm_LifecycleNextVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RFm_LifecycleNextVersion
		{
			get
			{
				if(r_Fm_LifecycleNextVersion == null)
				{
					r_Fm_LifecycleNextVersion = new(this, "m_LifecycleNextVersion");
				}
				return r_Fm_LifecycleNextVersion;
			}
		}

		/// <summary>
		/// Int32 numUnloadedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PnumUnloadedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPnumUnloadedVersions
		{
			get
			{
				if(r_PnumUnloadedVersions == null)
				{
					r_PnumUnloadedVersions = new(this, "numUnloadedVersions", -1);
				}
				return r_PnumUnloadedVersions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_Pkey;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RPkey
		{
			get
			{
				if(r_Pkey == null)
				{
					r_Pkey = new(this, "key", -1);
				}
				return r_Pkey;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion installed
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Pinstalled;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPinstalled
		{
			get
			{
				if(r_Pinstalled == null)
				{
					r_Pinstalled = new(this, "installed", -1);
				}
				return r_Pinstalled;
			}
		}

		/// <summary>
		/// System.String lifecycleVersionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlifecycleVersionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlifecycleVersionString
		{
			get
			{
				if(r_PlifecycleVersionString == null)
				{
					r_PlifecycleVersionString = new(this, "lifecycleVersionString", -1);
				}
				return r_PlifecycleVersionString;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion lifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PlifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlifecycleVersion
		{
			get
			{
				if(r_PlifecycleVersion == null)
				{
					r_PlifecycleVersion = new(this, "lifecycleVersion", -1);
				}
				return r_PlifecycleVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion resolvedLifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PresolvedLifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPresolvedLifecycleVersion
		{
			get
			{
				if(r_PresolvedLifecycleVersion == null)
				{
					r_PresolvedLifecycleVersion = new(this, "resolvedLifecycleVersion", -1);
				}
				return r_PresolvedLifecycleVersion;
			}
		}

		/// <summary>
		/// System.String lifecycleNextVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlifecycleNextVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlifecycleNextVersion
		{
			get
			{
				if(r_PlifecycleNextVersion == null)
				{
					r_PlifecycleNextVersion = new(this, "lifecycleNextVersion", -1);
				}
				return r_PlifecycleNextVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion resolvedLifecycleNextVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PresolvedLifecycleNextVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPresolvedLifecycleNextVersion
		{
			get
			{
				if(r_PresolvedLifecycleNextVersion == null)
				{
					r_PresolvedLifecycleNextVersion = new(this, "resolvedLifecycleNextVersion", -1);
				}
				return r_PresolvedLifecycleNextVersion;
			}
		}

		/// <summary>
		/// Boolean isUnityPackage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisUnityPackage;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisUnityPackage
		{
			get
			{
				if(r_PisUnityPackage == null)
				{
					r_PisUnityPackage = new(this, "isUnityPackage", -1);
				}
				return r_PisUnityPackage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion latest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Platest;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlatest
		{
			get
			{
				if(r_Platest == null)
				{
					r_Platest = new(this, "latest", -1);
				}
				return r_Platest;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion recommended
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Precommended;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPrecommended
		{
			get
			{
				if(r_Precommended == null)
				{
					r_Precommended = new(this, "recommended", -1);
				}
				return r_Precommended;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion primary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Pprimary;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPprimary
		{
			get
			{
				if(r_Pprimary == null)
				{
					r_Pprimary = new(this, "primary", -1);
				}
				return r_Pprimary;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion importAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PimportAvailable;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPimportAvailable
		{
			get
			{
				if(r_PimportAvailable == null)
				{
					r_PimportAvailable = new(this, "importAvailable", -1);
				}
				return r_PimportAvailable;
			}
		}

		/// <summary>
		/// Boolean isNonLifecycleVersionInstalled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisNonLifecycleVersionInstalled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisNonLifecycleVersionInstalled
		{
			get
			{
				if(r_PisNonLifecycleVersionInstalled == null)
				{
					r_PisNonLifecycleVersionInstalled = new(this, "isNonLifecycleVersionInstalled", -1);
				}
				return r_PisNonLifecycleVersionInstalled;
			}
		}

		/// <summary>
		/// Boolean hasLifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasLifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasLifecycleVersion
		{
			get
			{
				if(r_PhasLifecycleVersion == null)
				{
					r_PhasLifecycleVersion = new(this, "hasLifecycleVersion", -1);
				}
				return r_PhasLifecycleVersion;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Boolean CheckIsNonLifecycleVersionInstalled(UnityEditor.PackageManager.UI.Internal.IPackageVersion, UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected static RMethod r_MCheckIsNonLifecycleVersionInstalled_IPackageVersion_IPackageVersion;
		public static RMethod RMCheckIsNonLifecycleVersionInstalled_IPackageVersion_IPackageVersion
		{
			get
			{
				if(r_MCheckIsNonLifecycleVersionInstalled_IPackageVersion_IPackageVersion == null)
				{
					r_MCheckIsNonLifecycleVersionInstalled_IPackageVersion_IPackageVersion = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmVersionList"), "CheckIsNonLifecycleVersionInstalled", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MCheckIsNonLifecycleVersionInstalled_IPackageVersion_IPackageVersion;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion GetUpdateTarget(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetUpdateTarget_IPackageVersion;
		public virtual RMethod RMGetUpdateTarget_IPackageVersion
		{
			get
			{
				if(r_MGetUpdateTarget_IPackageVersion == null)
				{
					r_MGetUpdateTarget_IPackageVersion = new(this, "GetUpdateTarget", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MGetUpdateTarget_IPackageVersion;
			}
		}

		/// <summary>
		/// Void AddInstalledVersion(UnityEditor.PackageManager.UI.Internal.UpmPackageVersion)
		/// </summary>
		protected RMethod r_MAddInstalledVersion_UpmPackageVersion;
		public virtual RMethod RMAddInstalledVersion_UpmPackageVersion
		{
			get
			{
				if(r_MAddInstalledVersion_UpmPackageVersion == null)
				{
					r_MAddInstalledVersion_UpmPackageVersion = new(this, "AddInstalledVersion", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion"));
				}
				return r_MAddInstalledVersion_UpmPackageVersion;
			}
		}

		/// <summary>
		/// Int32 AddToSortedVersions(System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.UpmPackageVersion], UnityEditor.PackageManager.UI.Internal.UpmPackageVersion)
		/// </summary>
		protected static RMethod r_MAddToSortedVersions_List_d_UpmPackageVersion_p__UpmPackageVersion;
		public static RMethod RMAddToSortedVersions_List_d_UpmPackageVersion_p__UpmPackageVersion
		{
			get
			{
				if(r_MAddToSortedVersions_List_d_UpmPackageVersion_p__UpmPackageVersion == null)
				{
					r_MAddToSortedVersions_List_d_UpmPackageVersion_p__UpmPackageVersion = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmVersionList"), "AddToSortedVersions", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion")),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion"));
				}
				return r_MAddToSortedVersions_List_d_UpmPackageVersion_p__UpmPackageVersion;
			}
		}

		/// <summary>
		/// Void UpdateExtraPackageInfos(System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo], Boolean)
		/// </summary>
		protected RMethod r_MUpdateExtraPackageInfos_Dictionary_d_String_PackageInfo_p__Boolean;
		public virtual RMethod RMUpdateExtraPackageInfos_Dictionary_d_String_PackageInfo_p__Boolean
		{
			get
			{
				if(r_MUpdateExtraPackageInfos_Dictionary_d_String_PackageInfo_p__Boolean == null)
				{
					r_MUpdateExtraPackageInfos_Dictionary_d_String_PackageInfo_p__Boolean = new(this, "UpdateExtraPackageInfos", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(UnityEditor.PackageManager.PackageInfo)), typeof(System.Boolean));
				}
				return r_MUpdateExtraPackageInfos_Dictionary_d_String_PackageInfo_p__Boolean;
			}
		}

		/// <summary>
		/// Void SetLifecycleVersions(System.String, System.String)
		/// </summary>
		protected RMethod r_MSetLifecycleVersions_String_String;
		public virtual RMethod RMSetLifecycleVersions_String_String
		{
			get
			{
				if(r_MSetLifecycleVersions_String_String == null)
				{
					r_MSetLifecycleVersions_String_String = new(this, "SetLifecycleVersions", 0, typeof(System.String), typeof(System.String));
				}
				return r_MSetLifecycleVersions_String_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Boolean <get_lifecycleVersion>b__14_0(UnityEditor.PackageManager.UI.Internal.UpmPackageVersion)
		/// </summary>
		protected RMethod r_M__0__get_lifecycleVersion__1__b__14_0_UpmPackageVersion;
		public virtual RMethod RM__0__get_lifecycleVersion__1__b__14_0_UpmPackageVersion
		{
			get
			{
				if(r_M__0__get_lifecycleVersion__1__b__14_0_UpmPackageVersion == null)
				{
					r_M__0__get_lifecycleVersion__1__b__14_0_UpmPackageVersion = new(this, "<get_lifecycleVersion>b__14_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion"));
				}
				return r_M__0__get_lifecycleVersion__1__b__14_0_UpmPackageVersion;
			}
		}

		/// <summary>
		/// Boolean <get_resolvedLifecycleVersion>b__16_0(UnityEditor.PackageManager.UI.Internal.UpmPackageVersion)
		/// </summary>
		protected RMethod r_M__0__get_resolvedLifecycleVersion__1__b__16_0_UpmPackageVersion;
		public virtual RMethod RM__0__get_resolvedLifecycleVersion__1__b__16_0_UpmPackageVersion
		{
			get
			{
				if(r_M__0__get_resolvedLifecycleVersion__1__b__16_0_UpmPackageVersion == null)
				{
					r_M__0__get_resolvedLifecycleVersion__1__b__16_0_UpmPackageVersion = new(this, "<get_resolvedLifecycleVersion>b__16_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion"));
				}
				return r_M__0__get_resolvedLifecycleVersion__1__b__16_0_UpmPackageVersion;
			}
		}

		/// <summary>
		/// Boolean <get_resolvedLifecycleVersion>b__16_1(UnityEditor.PackageManager.UI.Internal.UpmPackageVersion)
		/// </summary>
		protected RMethod r_M__0__get_resolvedLifecycleVersion__1__b__16_1_UpmPackageVersion;
		public virtual RMethod RM__0__get_resolvedLifecycleVersion__1__b__16_1_UpmPackageVersion
		{
			get
			{
				if(r_M__0__get_resolvedLifecycleVersion__1__b__16_1_UpmPackageVersion == null)
				{
					r_M__0__get_resolvedLifecycleVersion__1__b__16_1_UpmPackageVersion = new(this, "<get_resolvedLifecycleVersion>b__16_1", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion"));
				}
				return r_M__0__get_resolvedLifecycleVersion__1__b__16_1_UpmPackageVersion;
			}
		}

		/// <summary>
		/// Boolean <get_resolvedLifecycleNextVersion>b__22_0(UnityEditor.PackageManager.UI.Internal.UpmPackageVersion)
		/// </summary>
		protected RMethod r_M__0__get_resolvedLifecycleNextVersion__1__b__22_0_UpmPackageVersion;
		public virtual RMethod RM__0__get_resolvedLifecycleNextVersion__1__b__22_0_UpmPackageVersion
		{
			get
			{
				if(r_M__0__get_resolvedLifecycleNextVersion__1__b__22_0_UpmPackageVersion == null)
				{
					r_M__0__get_resolvedLifecycleNextVersion__1__b__22_0_UpmPackageVersion = new(this, "<get_resolvedLifecycleNextVersion>b__22_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackageVersion"));
				}
				return r_M__0__get_resolvedLifecycleNextVersion__1__b__22_0_UpmPackageVersion;
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


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean CheckIsNonLifecycleVersionInstalled(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @installed, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @lifecycleVersion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@installed.Value, @lifecycleVersion.Value};
            var ___result = RMCheckIsNonLifecycleVersionInstalled_IPackageVersion_IPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion GetUpdateTarget(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetUpdateTarget_IPackageVersion.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion(___result);
        }


        public virtual void AddInstalledVersion(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion @newVersion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newVersion.Value};
            var ___result = RMAddInstalledVersion_UpmPackageVersion.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 AddToSortedVersions(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion> @sortedVersions, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion @versionToAdd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sortedVersions.Value, @versionToAdd.Value};
            var ___result = RMAddToSortedVersions_List_d_UpmPackageVersion_p__UpmPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void UpdateExtraPackageInfos(System.Collections.Generic.Dictionary<System.String, UnityEditor.PackageManager.PackageInfo> @extraVersions, System.Boolean @isUnityPackage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extraVersions, @isUnityPackage};
            var ___result = RMUpdateExtraPackageInfos_Dictionary_d_String_PackageInfo_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLifecycleVersions(System.String @unityLifecycleInfoVersion, System.String @unityLifecycleInfoNextVersion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unityLifecycleInfoVersion, @unityLifecycleInfoNextVersion};
            var ___result = RMSetLifecycleVersions_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean __0__get_lifecycleVersion__1__b__14_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v.Value};
            var ___result = RM__0__get_lifecycleVersion__1__b__14_0_UpmPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__get_resolvedLifecycleVersion__1__b__16_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v.Value};
            var ___result = RM__0__get_resolvedLifecycleVersion__1__b__16_0_UpmPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__get_resolvedLifecycleVersion__1__b__16_1(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v.Value};
            var ___result = RM__0__get_resolvedLifecycleVersion__1__b__16_1_UpmPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__get_resolvedLifecycleNextVersion__1__b__22_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackageVersion @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v.Value};
            var ___result = RM__0__get_resolvedLifecycleNextVersion__1__b__22_0_UpmPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
