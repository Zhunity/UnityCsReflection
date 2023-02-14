
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStorePackageVersion
	/// </summary>
    public partial class RAssetStorePackageVersion : RMember //
    {

		/// <summary>
		/// System.String k_IncompatibleWarningMessage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_IncompatibleWarningMessage;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_IncompatibleWarningMessage
		{
			get
			{
				if(r_Fk_IncompatibleWarningMessage == null)
				{
					r_Fk_IncompatibleWarningMessage = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePackageVersion"), "k_IncompatibleWarningMessage");
					r_Fk_IncompatibleWarningMessage.SetBelong(null);
				}
				return r_Fk_IncompatibleWarningMessage;
			}
		}

		/// <summary>
		/// System.String m_Category
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Category;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Category
		{
			get
			{
				if(r_Fm_Category == null)
				{
					r_Fm_Category = new(this, "m_Category");
					r_Fm_Category.SetBelong(this.instance);
				}
				return r_Fm_Category;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.UIError] m_Errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Fm_Errors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFm_Errors
		{
			get
			{
				if(r_Fm_Errors == null)
				{
					r_Fm_Errors = new(this, "m_Errors");
					r_Fm_Errors.SetBelong(this.instance);
				}
				return r_Fm_Errors;
			}
		}

		/// <summary>
		/// System.Boolean m_IsAvailableOnDisk
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsAvailableOnDisk;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsAvailableOnDisk
		{
			get
			{
				if(r_Fm_IsAvailableOnDisk == null)
				{
					r_Fm_IsAvailableOnDisk = new(this, "m_IsAvailableOnDisk");
					r_Fm_IsAvailableOnDisk.SetBelong(this.instance);
				}
				return r_Fm_IsAvailableOnDisk;
			}
		}

		/// <summary>
		/// System.String m_LocalPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LocalPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LocalPath
		{
			get
			{
				if(r_Fm_LocalPath == null)
				{
					r_Fm_LocalPath = new(this, "m_LocalPath");
					r_Fm_LocalPath.SetBelong(this.instance);
				}
				return r_Fm_LocalPath;
			}
		}

		/// <summary>
		/// System.String m_VersionId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_VersionId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_VersionId
		{
			get
			{
				if(r_Fm_VersionId == null)
				{
					r_Fm_VersionId = new(this, "m_VersionId");
					r_Fm_VersionId.SetBelong(this.instance);
				}
				return r_Fm_VersionId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] m_SupportedUnityVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Fm_SupportedUnityVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RFm_SupportedUnityVersions
		{
			get
			{
				if(r_Fm_SupportedUnityVersions == null)
				{
					r_Fm_SupportedUnityVersions = new(this, "m_SupportedUnityVersions");
					r_Fm_SupportedUnityVersions.SetBelong(this.instance);
				}
				return r_Fm_SupportedUnityVersions;
			}
		}

		/// <summary>
		/// System.String m_SupportedUnityVersionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_SupportedUnityVersionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_SupportedUnityVersionString
		{
			get
			{
				if(r_Fm_SupportedUnityVersionString == null)
				{
					r_Fm_SupportedUnityVersionString = new(this, "m_SupportedUnityVersionString");
					r_Fm_SupportedUnityVersionString.SetBelong(this.instance);
				}
				return r_Fm_SupportedUnityVersionString;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] m_SupportedUnityVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Fm_SupportedUnityVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RFm_SupportedUnityVersion
		{
			get
			{
				if(r_Fm_SupportedUnityVersion == null)
				{
					r_Fm_SupportedUnityVersion = new(this, "m_SupportedUnityVersion");
					r_Fm_SupportedUnityVersion.SetBelong(this.instance);
				}
				return r_Fm_SupportedUnityVersion;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageSizeInfo] m_SizeInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> r_Fm_SizeInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> RFm_SizeInfos
		{
			get
			{
				if(r_Fm_SizeInfos == null)
				{
					r_Fm_SizeInfos = new(this, "m_SizeInfos");
					r_Fm_SizeInfos.SetBelong(this.instance);
				}
				return r_Fm_SizeInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUtils m_AssetStoreUtils
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils r_Fm_AssetStoreUtils;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils RFm_AssetStoreUtils
		{
			get
			{
				if(r_Fm_AssetStoreUtils == null)
				{
					r_Fm_AssetStoreUtils = new(this, "m_AssetStoreUtils");
					r_Fm_AssetStoreUtils.SetBelong(this.instance);
				}
				return r_Fm_AssetStoreUtils;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IOProxy m_IOProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy r_Fm_IOProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy RFm_IOProxy
		{
			get
			{
				if(r_Fm_IOProxy == null)
				{
					r_Fm_IOProxy = new(this, "m_IOProxy");
					r_Fm_IOProxy.SetBelong(this.instance);
				}
				return r_Fm_IOProxy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] m_CategoryLinks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_Fm_CategoryLinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RFm_CategoryLinks
		{
			get
			{
				if(r_Fm_CategoryLinks == null)
				{
					r_Fm_CategoryLinks = new(this, "m_CategoryLinks");
					r_Fm_CategoryLinks.SetBelong(this.instance);
				}
				return r_Fm_CategoryLinks;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
					r_Fm_DisplayName.SetBelong(this.instance);
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// System.String m_Description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Description;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Description
		{
			get
			{
				if(r_Fm_Description == null)
				{
					r_Fm_Description = new(this, "m_Description");
					r_Fm_Description.SetBelong(this.instance);
				}
				return r_Fm_Description;
			}
		}

		/// <summary>
		/// System.String m_VersionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_VersionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_VersionString
		{
			get
			{
				if(r_Fm_VersionString == null)
				{
					r_Fm_VersionString = new(this, "m_VersionString");
					r_Fm_VersionString.SetBelong(this.instance);
				}
				return r_Fm_VersionString;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
					r_Fm_Version.SetBelong(this.instance);
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.Int64 m_PublishedDateTicks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_PublishedDateTicks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_PublishedDateTicks
		{
			get
			{
				if(r_Fm_PublishedDateTicks == null)
				{
					r_Fm_PublishedDateTicks = new(this, "m_PublishedDateTicks");
					r_Fm_PublishedDateTicks.SetBelong(this.instance);
				}
				return r_Fm_PublishedDateTicks;
			}
		}

		/// <summary>
		/// System.String m_PublishNotes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PublishNotes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PublishNotes
		{
			get
			{
				if(r_Fm_PublishNotes == null)
				{
					r_Fm_PublishNotes = new(this, "m_PublishNotes");
					r_Fm_PublishNotes.SetBelong(this.instance);
				}
				return r_Fm_PublishNotes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageTag m_Tag
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag r_Fm_Tag;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag RFm_Tag
		{
			get
			{
				if(r_Fm_Tag == null)
				{
					r_Fm_Tag = new(this, "m_Tag");
					r_Fm_Tag.SetBelong(this.instance);
				}
				return r_Fm_Tag;
			}
		}

		/// <summary>
		/// System.String author
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pauthor;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPauthor
		{
			get
			{
				if(r_Pauthor == null)
				{
					r_Pauthor = new(this, "author", -1);
					r_Pauthor.SetBelong(this.instance);
				}
				return r_Pauthor;
			}
		}

		/// <summary>
		/// System.String category
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pcategory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPcategory
		{
			get
			{
				if(r_Pcategory == null)
				{
					r_Pcategory = new(this, "category", -1);
					r_Pcategory.SetBelong(this.instance);
				}
				return r_Pcategory;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] categoryLinks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_PcategoryLinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RPcategoryLinks
		{
			get
			{
				if(r_PcategoryLinks == null)
				{
					r_PcategoryLinks = new(this, "categoryLinks", -1);
					r_PcategoryLinks.SetBelong(this.instance);
				}
				return r_PcategoryLinks;
			}
		}

		/// <summary>
		/// System.String uniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PuniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPuniqueId
		{
			get
			{
				if(r_PuniqueId == null)
				{
					r_PuniqueId = new(this, "uniqueId", -1);
					r_PuniqueId.SetBelong(this.instance);
				}
				return r_PuniqueId;
			}
		}

		/// <summary>
		/// Boolean isInstalled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInstalled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInstalled
		{
			get
			{
				if(r_PisInstalled == null)
				{
					r_PisInstalled = new(this, "isInstalled", -1);
					r_PisInstalled.SetBelong(this.instance);
				}
				return r_PisInstalled;
			}
		}

		/// <summary>
		/// Boolean isFullyFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFullyFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFullyFetched
		{
			get
			{
				if(r_PisFullyFetched == null)
				{
					r_PisFullyFetched = new(this, "isFullyFetched", -1);
					r_PisFullyFetched.SetBelong(this.instance);
				}
				return r_PisFullyFetched;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.UIError] errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Perrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RPerrors
		{
			get
			{
				if(r_Perrors == null)
				{
					r_Perrors = new(this, "errors", -1);
					r_Perrors.SetBelong(this.instance);
				}
				return r_Perrors;
			}
		}

		/// <summary>
		/// Boolean isAvailableOnDisk
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisAvailableOnDisk;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisAvailableOnDisk
		{
			get
			{
				if(r_PisAvailableOnDisk == null)
				{
					r_PisAvailableOnDisk = new(this, "isAvailableOnDisk", -1);
					r_PisAvailableOnDisk.SetBelong(this.instance);
				}
				return r_PisAvailableOnDisk;
			}
		}

		/// <summary>
		/// Boolean isDirectDependency
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDirectDependency;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDirectDependency
		{
			get
			{
				if(r_PisDirectDependency == null)
				{
					r_PisDirectDependency = new(this, "isDirectDependency", -1);
					r_PisDirectDependency.SetBelong(this.instance);
				}
				return r_PisDirectDependency;
			}
		}

		/// <summary>
		/// System.String localPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlocalPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlocalPath
		{
			get
			{
				if(r_PlocalPath == null)
				{
					r_PlocalPath = new(this, "localPath", -1);
					r_PlocalPath.SetBelong(this.instance);
				}
				return r_PlocalPath;
			}
		}

		/// <summary>
		/// System.String versionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionString
		{
			get
			{
				if(r_PversionString == null)
				{
					r_PversionString = new(this, "versionString", -1);
					r_PversionString.SetBelong(this.instance);
				}
				return r_PversionString;
			}
		}

		/// <summary>
		/// System.String versionId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionId
		{
			get
			{
				if(r_PversionId == null)
				{
					r_PversionId = new(this, "versionId", -1);
					r_PversionId.SetBelong(this.instance);
				}
				return r_PversionId;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] supportedVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_PsupportedVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RPsupportedVersion
		{
			get
			{
				if(r_PsupportedVersion == null)
				{
					r_PsupportedVersion = new(this, "supportedVersion", -1);
					r_PsupportedVersion.SetBelong(this.instance);
				}
				return r_PsupportedVersion;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] supportedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_PsupportedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RPsupportedVersions
		{
			get
			{
				if(r_PsupportedVersions == null)
				{
					r_PsupportedVersions = new(this, "supportedVersions", -1);
					r_PsupportedVersions.SetBelong(this.instance);
				}
				return r_PsupportedVersions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageSizeInfo] sizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> r_Psizes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> RPsizes
		{
			get
			{
				if(r_Psizes == null)
				{
					r_Psizes = new(this, "sizes", -1);
					r_Psizes.SetBelong(this.instance);
				}
				return r_Psizes;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pdescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdescription
		{
			get
			{
				if(r_Pdescription == null)
				{
					r_Pdescription = new(this, "description", -1);
					r_Pdescription.SetBelong(this.instance);
				}
				return r_Pdescription;
			}
		}

		/// <summary>
		/// System.String packageUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageUniqueId
		{
			get
			{
				if(r_PpackageUniqueId == null)
				{
					r_PpackageUniqueId = new(this, "packageUniqueId", -1);
					r_PpackageUniqueId.SetBelong(this.instance);
				}
				return r_PpackageUniqueId;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.Scripting.ScriptCompilation.SemVersion] version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RUnityEditor.RScripting.RScriptCompilation.RSemVersion> RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.instance);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// System.String versionInManifest
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionInManifest;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionInManifest
		{
			get
			{
				if(r_PversionInManifest == null)
				{
					r_PversionInManifest = new(this, "versionInManifest", -1);
					r_PversionInManifest.SetBelong(this.instance);
				}
				return r_PversionInManifest;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.DateTime] publishedDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> r_PpublishedDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> RPpublishedDate
		{
			get
			{
				if(r_PpublishedDate == null)
				{
					r_PpublishedDate = new(this, "publishedDate", -1);
					r_PpublishedDate.SetBelong(this.instance);
				}
				return r_PpublishedDate;
			}
		}

		/// <summary>
		/// System.String localReleaseNotes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlocalReleaseNotes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlocalReleaseNotes
		{
			get
			{
				if(r_PlocalReleaseNotes == null)
				{
					r_PlocalReleaseNotes = new(this, "localReleaseNotes", -1);
					r_PlocalReleaseNotes.SetBelong(this.instance);
				}
				return r_PlocalReleaseNotes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.DependencyInfo[] dependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> r_Pdependencies;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> RPdependencies
		{
			get
			{
				if(r_Pdependencies == null)
				{
					r_Pdependencies = new(this, "dependencies", -1);
					r_Pdependencies.SetBelong(this.instance);
				}
				return r_Pdependencies;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.DependencyInfo[] resolvedDependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> r_PresolvedDependencies;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RDependencyInfo> RPresolvedDependencies
		{
			get
			{
				if(r_PresolvedDependencies == null)
				{
					r_PresolvedDependencies = new(this, "resolvedDependencies", -1);
					r_PresolvedDependencies.SetBelong(this.instance);
				}
				return r_PresolvedDependencies;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.EntitlementsInfo entitlements
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementsInfo r_Pentitlements;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementsInfo RPentitlements
		{
			get
			{
				if(r_Pentitlements == null)
				{
					r_Pentitlements = new(this, "entitlements", -1);
					r_Pentitlements.SetBelong(this.instance);
				}
				return r_Pentitlements;
			}
		}

		/// <summary>
		/// Boolean isRegistryPackage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRegistryPackage;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRegistryPackage
		{
			get
			{
				if(r_PisRegistryPackage == null)
				{
					r_PisRegistryPackage = new(this, "isRegistryPackage", -1);
					r_PisRegistryPackage.SetBelong(this.instance);
				}
				return r_PisRegistryPackage;
			}
		}

		/// <summary>
		/// Boolean isFromScopedRegistry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFromScopedRegistry;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFromScopedRegistry
		{
			get
			{
				if(r_PisFromScopedRegistry == null)
				{
					r_PisFromScopedRegistry = new(this, "isFromScopedRegistry", -1);
					r_PisFromScopedRegistry.SetBelong(this.instance);
				}
				return r_PisFromScopedRegistry;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.IPackage package
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage r_Ppackage;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RIPackage RPpackage
		{
			get
			{
				if(r_Ppackage == null)
				{
					r_Ppackage = new(this, "package", -1);
					r_Ppackage.SetBelong(this.instance);
				}
				return r_Ppackage;
			}
		}

		/// <summary>
		/// Boolean hasEntitlements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasEntitlements;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasEntitlements
		{
			get
			{
				if(r_PhasEntitlements == null)
				{
					r_PhasEntitlements = new(this, "hasEntitlements", -1);
					r_PhasEntitlements.SetBelong(this.instance);
				}
				return r_PhasEntitlements;
			}
		}

		/// <summary>
		/// Boolean hasEntitlementsError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasEntitlementsError;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasEntitlementsError
		{
			get
			{
				if(r_PhasEntitlementsError == null)
				{
					r_PhasEntitlementsError = new(this, "hasEntitlementsError", -1);
					r_PhasEntitlementsError.SetBelong(this.instance);
				}
				return r_PhasEntitlementsError;
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
					r_PisUnityPackage.SetBelong(this.instance);
				}
				return r_PisUnityPackage;
			}
		}

		/// <summary>
		/// Boolean IsDifferentVersionThanRequested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsDifferentVersionThanRequested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsDifferentVersionThanRequested
		{
			get
			{
				if(r_PIsDifferentVersionThanRequested == null)
				{
					r_PIsDifferentVersionThanRequested = new(this, "IsDifferentVersionThanRequested", -1);
					r_PIsDifferentVersionThanRequested.SetBelong(this.instance);
				}
				return r_PIsDifferentVersionThanRequested;
			}
		}

		/// <summary>
		/// Boolean IsRequestedButOverriddenVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRequestedButOverriddenVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRequestedButOverriddenVersion
		{
			get
			{
				if(r_PIsRequestedButOverriddenVersion == null)
				{
					r_PIsRequestedButOverriddenVersion = new(this, "IsRequestedButOverriddenVersion", -1);
					r_PIsRequestedButOverriddenVersion.SetBelong(this.instance);
				}
				return r_PIsRequestedButOverriddenVersion;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, UnityEditor.PackageManager.UI.Internal.IOProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_AssetStoreUtils_IOProxy;
		public virtual RMethod RMResolveDependencies_AssetStoreUtils_IOProxy
		{
			get
			{
				if(r_MResolveDependencies_AssetStoreUtils_IOProxy == null)
				{
					r_MResolveDependencies_AssetStoreUtils_IOProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"));
					r_MResolveDependencies_AssetStoreUtils_IOProxy.SetBelong(this.instance);
				}
				return r_MResolveDependencies_AssetStoreUtils_IOProxy;
			}
		}

		/// <summary>
		/// Void SetLocalPath(System.String)
		/// </summary>
		protected RMethod r_MSetLocalPath_String;
		public virtual RMethod RMSetLocalPath_String
		{
			get
			{
				if(r_MSetLocalPath_String == null)
				{
					r_MSetLocalPath_String = new(this, "SetLocalPath", 0, typeof(System.String));
					r_MSetLocalPath_String.SetBelong(this.instance);
				}
				return r_MSetLocalPath_String;
			}
		}

		/// <summary>
		/// Void AddDowngradeWarningIfApplicable(UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo, UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo)
		/// </summary>
		protected RMethod r_MAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo;
		public virtual RMethod RMAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo
		{
			get
			{
				if(r_MAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo == null)
				{
					r_MAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo = new(this, "AddDowngradeWarningIfApplicable", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo"));
					r_MAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo.SetBelong(this.instance);
				}
				return r_MAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo;
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
					r_MOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Boolean HasTag(UnityEditor.PackageManager.UI.Internal.PackageTag)
		/// </summary>
		protected RMethod r_MHasTag_PackageTag;
		public virtual RMethod RMHasTag_PackageTag
		{
			get
			{
				if(r_MHasTag_PackageTag == null)
				{
					r_MHasTag_PackageTag = new(this, "HasTag", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageTag"));
					r_MHasTag_PackageTag.SetBelong(this.instance);
				}
				return r_MHasTag_PackageTag;
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
					r_MOnBeforeSerialize.SetBelong(this.instance);
				}
				return r_MOnBeforeSerialize;
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


        public RAssetStorePackageVersion() : base("UnityEditor.PackageManager.UI.Internal.AssetStorePackageVersion")
        {
        }

        public RAssetStorePackageVersion(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStorePackageVersion")
		{
            SetInstance(instance);
		}

        public RAssetStorePackageVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStorePackageVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @ioProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetStoreUtils.Value, @ioProxy.Value};
            var ___result = RMResolveDependencies_AssetStoreUtils_IOProxy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLocalPath(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMSetLocalPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDowngradeWarningIfApplicable(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo @localInfo, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo @updateInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localInfo.Value, @updateInfo.Value};
            var ___result = RMAddDowngradeWarningIfApplicable_AssetStoreLocalInfo_AssetStoreUpdateInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTag(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageTag @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag.Value};
            var ___result = RMHasTag_PackageTag.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
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
