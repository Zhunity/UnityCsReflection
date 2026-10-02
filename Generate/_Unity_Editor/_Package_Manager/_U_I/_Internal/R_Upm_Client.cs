
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.UpmClient
	/// </summary>
    public partial class RUpmClient : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmClient");
            }
        }

        public RUpmClient() : base("UnityEditor.PackageManager.UI.Internal.UpmClient")
        {
        }

        public RUpmClient(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UpmClient")
		{
            SetInstance(instance);
		}

        public RUpmClient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmClient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onListOperation
		/// </summary>
		protected REvent r_EonListOperation;
		public virtual REvent REonListOperation
		{
			get
			{
				if(r_EonListOperation == null)
				{
					r_EonListOperation = new(this, "onListOperation");
				}
				return r_EonListOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onSearchAllOperation
		/// </summary>
		protected REvent r_EonSearchAllOperation;
		public virtual REvent REonSearchAllOperation
		{
			get
			{
				if(r_EonSearchAllOperation == null)
				{
					r_EonSearchAllOperation = new(this, "onSearchAllOperation");
				}
				return r_EonSearchAllOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onExtraFetchOperation
		/// </summary>
		protected REvent r_EonExtraFetchOperation;
		public virtual REvent REonExtraFetchOperation
		{
			get
			{
				if(r_EonExtraFetchOperation == null)
				{
					r_EonExtraFetchOperation = new(this, "onExtraFetchOperation");
				}
				return r_EonExtraFetchOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onRemoveOperation
		/// </summary>
		protected REvent r_EonRemoveOperation;
		public virtual REvent REonRemoveOperation
		{
			get
			{
				if(r_EonRemoveOperation == null)
				{
					r_EonRemoveOperation = new(this, "onRemoveOperation");
				}
				return r_EonRemoveOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onAddOperation
		/// </summary>
		protected REvent r_EonAddOperation;
		public virtual REvent REonAddOperation
		{
			get
			{
				if(r_EonAddOperation == null)
				{
					r_EonAddOperation = new(this, "onAddOperation");
				}
				return r_EonAddOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onEmbedOperation
		/// </summary>
		protected REvent r_EonEmbedOperation;
		public virtual REvent REonEmbedOperation
		{
			get
			{
				if(r_EonEmbedOperation == null)
				{
					r_EonEmbedOperation = new(this, "onEmbedOperation");
				}
				return r_EonEmbedOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation] onAddAndRemoveOperation
		/// </summary>
		protected REvent r_EonAddAndRemoveOperation;
		public virtual REvent REonAddAndRemoveOperation
		{
			get
			{
				if(r_EonAddAndRemoveOperation == null)
				{
					r_EonAddAndRemoveOperation = new(this, "onAddAndRemoveOperation");
				}
				return r_EonAddAndRemoveOperation;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage]] onPackagesChanged
		/// </summary>
		protected REvent r_EonPackagesChanged;
		public virtual REvent REonPackagesChanged
		{
			get
			{
				if(r_EonPackagesChanged == null)
				{
					r_EonPackagesChanged = new(this, "onPackagesChanged");
				}
				return r_EonPackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackage] onProductPackageChanged
		/// </summary>
		protected REvent r_EonProductPackageChanged;
		public virtual REvent REonProductPackageChanged
		{
			get
			{
				if(r_EonProductPackageChanged == null)
				{
					r_EonProductPackageChanged = new(this, "onProductPackageChanged");
				}
				return r_EonProductPackageChanged;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackageVersion] onPackageVersionUpdated
		/// </summary>
		protected REvent r_EonPackageVersionUpdated;
		public virtual REvent REonPackageVersionUpdated
		{
			get
			{
				if(r_EonPackageVersionUpdated == null)
				{
					r_EonPackageVersionUpdated = new(this, "onPackageVersionUpdated");
				}
				return r_EonPackageVersionUpdated;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackageVersion] onProductPackageVersionUpdated
		/// </summary>
		protected REvent r_EonProductPackageVersionUpdated;
		public virtual REvent REonProductPackageVersionUpdated
		{
			get
			{
				if(r_EonProductPackageVersionUpdated == null)
				{
					r_EonProductPackageVersionUpdated = new(this, "onProductPackageVersionUpdated");
				}
				return r_EonProductPackageVersionUpdated;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.UIError] onProductPackageFetchError
		/// </summary>
		protected REvent r_EonProductPackageFetchError;
		public virtual REvent REonProductPackageFetchError
		{
			get
			{
				if(r_EonProductPackageFetchError == null)
				{
					r_EonProductPackageFetchError = new(this, "onProductPackageFetchError");
				}
				return r_EonProductPackageFetchError;
			}
		}

		/// <summary>
		/// System.String[] k_UnityRegistriesUrlHosts
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fk_UnityRegistriesUrlHosts;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFk_UnityRegistriesUrlHosts
		{
			get
			{
				if(r_Fk_UnityRegistriesUrlHosts == null)
				{
					r_Fk_UnityRegistriesUrlHosts = new(Type, "k_UnityRegistriesUrlHosts");
				}
				return r_Fk_UnityRegistriesUrlHosts;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onListOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonListOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonListOperation
		{
			get
			{
				if(r_FonListOperation == null)
				{
					r_FonListOperation = new(this, "onListOperation");
				}
				return r_FonListOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onSearchAllOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonSearchAllOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonSearchAllOperation
		{
			get
			{
				if(r_FonSearchAllOperation == null)
				{
					r_FonSearchAllOperation = new(this, "onSearchAllOperation");
				}
				return r_FonSearchAllOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onExtraFetchOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonExtraFetchOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonExtraFetchOperation
		{
			get
			{
				if(r_FonExtraFetchOperation == null)
				{
					r_FonExtraFetchOperation = new(this, "onExtraFetchOperation");
				}
				return r_FonExtraFetchOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onRemoveOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonRemoveOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonRemoveOperation
		{
			get
			{
				if(r_FonRemoveOperation == null)
				{
					r_FonRemoveOperation = new(this, "onRemoveOperation");
				}
				return r_FonRemoveOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onAddOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonAddOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonAddOperation
		{
			get
			{
				if(r_FonAddOperation == null)
				{
					r_FonAddOperation = new(this, "onAddOperation");
				}
				return r_FonAddOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onEmbedOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> r_FonEmbedOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation> RFonEmbedOperation
		{
			get
			{
				if(r_FonEmbedOperation == null)
				{
					r_FonEmbedOperation = new(this, "onEmbedOperation");
				}
				return r_FonEmbedOperation;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation] onAddAndRemoveOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation> r_FonAddAndRemoveOperation;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation> RFonAddAndRemoveOperation
		{
			get
			{
				if(r_FonAddAndRemoveOperation == null)
				{
					r_FonAddAndRemoveOperation = new(this, "onAddAndRemoveOperation");
				}
				return r_FonAddAndRemoveOperation;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackage]] onPackagesChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>> r_FonPackagesChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage>> RFonPackagesChanged
		{
			get
			{
				if(r_FonPackagesChanged == null)
				{
					r_FonPackagesChanged = new(this, "onPackagesChanged");
				}
				return r_FonPackagesChanged;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackage] onProductPackageChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> r_FonProductPackageChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage> RFonProductPackageChanged
		{
			get
			{
				if(r_FonProductPackageChanged == null)
				{
					r_FonProductPackageChanged = new(this, "onProductPackageChanged");
				}
				return r_FonProductPackageChanged;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackageVersion] onPackageVersionUpdated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_FonPackageVersionUpdated;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RFonPackageVersionUpdated
		{
			get
			{
				if(r_FonPackageVersionUpdated == null)
				{
					r_FonPackageVersionUpdated = new(this, "onPackageVersionUpdated");
				}
				return r_FonPackageVersionUpdated;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.IPackageVersion] onProductPackageVersionUpdated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_FonProductPackageVersionUpdated;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RFonProductPackageVersionUpdated
		{
			get
			{
				if(r_FonProductPackageVersionUpdated == null)
				{
					r_FonProductPackageVersionUpdated = new(this, "onProductPackageVersionUpdated");
				}
				return r_FonProductPackageVersionUpdated;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,UnityEditor.PackageManager.UI.Internal.UIError] onProductPackageFetchError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_FonProductPackageFetchError;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFonProductPackageFetchError
		{
			get
			{
				if(r_FonProductPackageFetchError == null)
				{
					r_FonProductPackageFetchError = new(this, "onProductPackageFetchError");
				}
				return r_FonProductPackageFetchError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmSearchOperation m_SearchOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation r_Fm_SearchOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation RFm_SearchOperation
		{
			get
			{
				if(r_Fm_SearchOperation == null)
				{
					r_Fm_SearchOperation = new(this, "m_SearchOperation");
				}
				return r_Fm_SearchOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmSearchOperation m_SearchOfflineOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation r_Fm_SearchOfflineOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation RFm_SearchOfflineOperation
		{
			get
			{
				if(r_Fm_SearchOfflineOperation == null)
				{
					r_Fm_SearchOfflineOperation = new(this, "m_SearchOfflineOperation");
				}
				return r_Fm_SearchOfflineOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmListOperation m_ListOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation r_Fm_ListOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation RFm_ListOperation
		{
			get
			{
				if(r_Fm_ListOperation == null)
				{
					r_Fm_ListOperation = new(this, "m_ListOperation");
				}
				return r_Fm_ListOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmListOperation m_ListOfflineOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation r_Fm_ListOfflineOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation RFm_ListOfflineOperation
		{
			get
			{
				if(r_Fm_ListOfflineOperation == null)
				{
					r_Fm_ListOfflineOperation = new(this, "m_ListOfflineOperation");
				}
				return r_Fm_ListOfflineOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmAddOperation m_AddOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddOperation r_Fm_AddOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddOperation RFm_AddOperation
		{
			get
			{
				if(r_Fm_AddOperation == null)
				{
					r_Fm_AddOperation = new(this, "m_AddOperation");
				}
				return r_Fm_AddOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation m_AddAndRemoveOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation r_Fm_AddAndRemoveOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation RFm_AddAndRemoveOperation
		{
			get
			{
				if(r_Fm_AddAndRemoveOperation == null)
				{
					r_Fm_AddAndRemoveOperation = new(this, "m_AddAndRemoveOperation");
				}
				return r_Fm_AddAndRemoveOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmRemoveOperation m_RemoveOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveOperation r_Fm_RemoveOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveOperation RFm_RemoveOperation
		{
			get
			{
				if(r_Fm_RemoveOperation == null)
				{
					r_Fm_RemoveOperation = new(this, "m_RemoveOperation");
				}
				return r_Fm_RemoveOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmEmbedOperation m_EmbedOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmEmbedOperation r_Fm_EmbedOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmEmbedOperation RFm_EmbedOperation
		{
			get
			{
				if(r_Fm_EmbedOperation == null)
				{
					r_Fm_EmbedOperation = new(this, "m_EmbedOperation");
				}
				return r_Fm_EmbedOperation;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.UI.Internal.UpmSearchOperation] m_ExtraFetchOperations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation> r_Fm_ExtraFetchOperations;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation> RFm_ExtraFetchOperations
		{
			get
			{
				if(r_Fm_ExtraFetchOperations == null)
				{
					r_Fm_ExtraFetchOperations = new(this, "m_ExtraFetchOperations");
				}
				return r_Fm_ExtraFetchOperations;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedPRegistriesUrlKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedPRegistriesUrlKeys;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedPRegistriesUrlKeys
		{
			get
			{
				if(r_Fm_SerializedPRegistriesUrlKeys == null)
				{
					r_Fm_SerializedPRegistriesUrlKeys = new(this, "m_SerializedPRegistriesUrlKeys");
				}
				return r_Fm_SerializedPRegistriesUrlKeys;
			}
		}

		/// <summary>
		/// System.Boolean[] m_SerializedRegistriesUrlValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_SerializedRegistriesUrlValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_SerializedRegistriesUrlValues
		{
			get
			{
				if(r_Fm_SerializedRegistriesUrlValues == null)
				{
					r_Fm_SerializedRegistriesUrlValues = new(this, "m_SerializedRegistriesUrlValues");
				}
				return r_Fm_SerializedRegistriesUrlValues;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Boolean] m_RegistriesUrl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_RegistriesUrl;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_RegistriesUrl
		{
			get
			{
				if(r_Fm_RegistriesUrl == null)
				{
					r_Fm_RegistriesUrl = new(this, "m_RegistriesUrl");
				}
				return r_Fm_RegistriesUrl;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_SpecialInstallations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SpecialInstallations;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_SpecialInstallations
		{
			get
			{
				if(r_Fm_SpecialInstallations == null)
				{
					r_Fm_SpecialInstallations = new(this, "m_SpecialInstallations");
				}
				return r_Fm_SpecialInstallations;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmCache m_UpmCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache r_Fm_UpmCache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache RFm_UpmCache
		{
			get
			{
				if(r_Fm_UpmCache == null)
				{
					r_Fm_UpmCache = new(this, "m_UpmCache");
				}
				return r_Fm_UpmCache;
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
				}
				return r_Fm_IOProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy m_SettingsProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy r_Fm_SettingsProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy RFm_SettingsProxy
		{
			get
			{
				if(r_Fm_SettingsProxy == null)
				{
					r_Fm_SettingsProxy = new(this, "m_SettingsProxy");
				}
				return r_Fm_SettingsProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ClientProxy m_ClientProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy r_Fm_ClientProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy RFm_ClientProxy
		{
			get
			{
				if(r_Fm_ClientProxy == null)
				{
					r_Fm_ClientProxy = new(this, "m_ClientProxy");
				}
				return r_Fm_ClientProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.ApplicationProxy m_ApplicationProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy r_Fm_ApplicationProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy RFm_ApplicationProxy
		{
			get
			{
				if(r_Fm_ApplicationProxy == null)
				{
					r_Fm_ApplicationProxy = new(this, "m_ApplicationProxy");
				}
				return r_Fm_ApplicationProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmSearchOperation searchOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation r_PsearchOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation RPsearchOperation
		{
			get
			{
				if(r_PsearchOperation == null)
				{
					r_PsearchOperation = new(this, "searchOperation", -1);
				}
				return r_PsearchOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmSearchOperation searchOfflineOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation r_PsearchOfflineOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation RPsearchOfflineOperation
		{
			get
			{
				if(r_PsearchOfflineOperation == null)
				{
					r_PsearchOfflineOperation = new(this, "searchOfflineOperation", -1);
				}
				return r_PsearchOfflineOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmListOperation listOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation r_PlistOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation RPlistOperation
		{
			get
			{
				if(r_PlistOperation == null)
				{
					r_PlistOperation = new(this, "listOperation", -1);
				}
				return r_PlistOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmListOperation listOfflineOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation r_PlistOfflineOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmListOperation RPlistOfflineOperation
		{
			get
			{
				if(r_PlistOfflineOperation == null)
				{
					r_PlistOfflineOperation = new(this, "listOfflineOperation", -1);
				}
				return r_PlistOfflineOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmAddOperation addOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddOperation r_PaddOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddOperation RPaddOperation
		{
			get
			{
				if(r_PaddOperation == null)
				{
					r_PaddOperation = new(this, "addOperation", -1);
				}
				return r_PaddOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmAddAndRemoveOperation addAndRemoveOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation r_PaddAndRemoveOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmAddAndRemoveOperation RPaddAndRemoveOperation
		{
			get
			{
				if(r_PaddAndRemoveOperation == null)
				{
					r_PaddAndRemoveOperation = new(this, "addAndRemoveOperation", -1);
				}
				return r_PaddAndRemoveOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmRemoveOperation removeOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveOperation r_PremoveOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmRemoveOperation RPremoveOperation
		{
			get
			{
				if(r_PremoveOperation == null)
				{
					r_PremoveOperation = new(this, "removeOperation", -1);
				}
				return r_PremoveOperation;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmEmbedOperation embedOperation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmEmbedOperation r_PembedOperation;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmEmbedOperation RPembedOperation
		{
			get
			{
				if(r_PembedOperation == null)
				{
					r_PembedOperation = new(this, "embedOperation", -1);
				}
				return r_PembedOperation;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] specialInstallations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_PspecialInstallations;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPspecialInstallations
		{
			get
			{
				if(r_PspecialInstallations == null)
				{
					r_PspecialInstallations = new(this, "specialInstallations", -1);
				}
				return r_PspecialInstallations;
			}
		}

		/// <summary>
		/// Boolean isAddRemoveOrEmbedInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisAddRemoveOrEmbedInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisAddRemoveOrEmbedInProgress
		{
			get
			{
				if(r_PisAddRemoveOrEmbedInProgress == null)
				{
					r_PisAddRemoveOrEmbedInProgress = new(this, "isAddRemoveOrEmbedInProgress", -1);
				}
				return r_PisAddRemoveOrEmbedInProgress;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.IOProxy, UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy, UnityEditor.PackageManager.UI.Internal.ClientProxy, UnityEditor.PackageManager.UI.Internal.ApplicationProxy)
		/// </summary>
		protected RMethod r_MResolveDependencies_UpmCache_IOProxy_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy;
		public virtual RMethod RMResolveDependencies_UpmCache_IOProxy_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy
		{
			get
			{
				if(r_MResolveDependencies_UpmCache_IOProxy_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy == null)
				{
					r_MResolveDependencies_UpmCache_IOProxy_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ClientProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.ApplicationProxy"));
				}
				return r_MResolveDependencies_UpmCache_IOProxy_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy;
			}
		}

		/// <summary>
		/// Boolean IsAnyExperimentalPackagesInUse()
		/// </summary>
		protected RMethod r_MIsAnyExperimentalPackagesInUse;
		public virtual RMethod RMIsAnyExperimentalPackagesInUse
		{
			get
			{
				if(r_MIsAnyExperimentalPackagesInUse == null)
				{
					r_MIsAnyExperimentalPackagesInUse = new(this, "IsAnyExperimentalPackagesInUse", 0);
				}
				return r_MIsAnyExperimentalPackagesInUse;
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
		/// Boolean IsEmbedInProgress(System.String)
		/// </summary>
		protected RMethod r_MIsEmbedInProgress_String;
		public virtual RMethod RMIsEmbedInProgress_String
		{
			get
			{
				if(r_MIsEmbedInProgress_String == null)
				{
					r_MIsEmbedInProgress_String = new(this, "IsEmbedInProgress", 0, typeof(System.String));
				}
				return r_MIsEmbedInProgress_String;
			}
		}

		/// <summary>
		/// Boolean IsRemoveInProgress(System.String)
		/// </summary>
		protected RMethod r_MIsRemoveInProgress_String;
		public virtual RMethod RMIsRemoveInProgress_String
		{
			get
			{
				if(r_MIsRemoveInProgress_String == null)
				{
					r_MIsRemoveInProgress_String = new(this, "IsRemoveInProgress", 0, typeof(System.String));
				}
				return r_MIsRemoveInProgress_String;
			}
		}

		/// <summary>
		/// Boolean IsAddInProgress(System.String)
		/// </summary>
		protected RMethod r_MIsAddInProgress_String;
		public virtual RMethod RMIsAddInProgress_String
		{
			get
			{
				if(r_MIsAddInProgress_String == null)
				{
					r_MIsAddInProgress_String = new(this, "IsAddInProgress", 0, typeof(System.String));
				}
				return r_MIsAddInProgress_String;
			}
		}

		/// <summary>
		/// Void AddById(System.String)
		/// </summary>
		protected RMethod r_MAddById_String;
		public virtual RMethod RMAddById_String
		{
			get
			{
				if(r_MAddById_String == null)
				{
					r_MAddById_String = new(this, "AddById", 0, typeof(System.String));
				}
				return r_MAddById_String;
			}
		}

		/// <summary>
		/// Void SetupAddOperation()
		/// </summary>
		protected RMethod r_MSetupAddOperation;
		public virtual RMethod RMSetupAddOperation
		{
			get
			{
				if(r_MSetupAddOperation == null)
				{
					r_MSetupAddOperation = new(this, "SetupAddOperation", 0);
				}
				return r_MSetupAddOperation;
			}
		}

		/// <summary>
		/// Void OnProcessAddResult(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.Requests.Request`1[UnityEditor.PackageManager.PackageInfo])
		/// </summary>
		protected RMethod r_MOnProcessAddResult_IOperation_Request_d_PackageInfo_p_;
		public virtual RMethod RMOnProcessAddResult_IOperation_Request_d_PackageInfo_p_
		{
			get
			{
				if(r_MOnProcessAddResult_IOperation_Request_d_PackageInfo_p_ == null)
				{
					r_MOnProcessAddResult_IOperation_Request_d_PackageInfo_p_ = new(this, "OnProcessAddResult", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.Requests.Request`1").MakeGenericType(typeof(UnityEditor.PackageManager.PackageInfo)));
				}
				return r_MOnProcessAddResult_IOperation_Request_d_PackageInfo_p_;
			}
		}

		/// <summary>
		/// Void AddByPath(System.String)
		/// </summary>
		protected RMethod r_MAddByPath_String;
		public virtual RMethod RMAddByPath_String
		{
			get
			{
				if(r_MAddByPath_String == null)
				{
					r_MAddByPath_String = new(this, "AddByPath", 0, typeof(System.String));
				}
				return r_MAddByPath_String;
			}
		}

		/// <summary>
		/// Void AddByUrl(System.String)
		/// </summary>
		protected RMethod r_MAddByUrl_String;
		public virtual RMethod RMAddByUrl_String
		{
			get
			{
				if(r_MAddByUrl_String == null)
				{
					r_MAddByUrl_String = new(this, "AddByUrl", 0, typeof(System.String));
				}
				return r_MAddByUrl_String;
			}
		}

		/// <summary>
		/// Void AddAndResetDependencies(System.String, System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MAddAndResetDependencies_String_IEnumerable_d_String_p_;
		public virtual RMethod RMAddAndResetDependencies_String_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MAddAndResetDependencies_String_IEnumerable_d_String_p_ == null)
				{
					r_MAddAndResetDependencies_String_IEnumerable_d_String_p_ = new(this, "AddAndResetDependencies", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MAddAndResetDependencies_String_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void ResetDependencies(System.String, System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MResetDependencies_String_IEnumerable_d_String_p_;
		public virtual RMethod RMResetDependencies_String_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MResetDependencies_String_IEnumerable_d_String_p_ == null)
				{
					r_MResetDependencies_String_IEnumerable_d_String_p_ = new(this, "ResetDependencies", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.String)));
				}
				return r_MResetDependencies_String_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// Void SetupAddAndRemoveOperation()
		/// </summary>
		protected RMethod r_MSetupAddAndRemoveOperation;
		public virtual RMethod RMSetupAddAndRemoveOperation
		{
			get
			{
				if(r_MSetupAddAndRemoveOperation == null)
				{
					r_MSetupAddAndRemoveOperation = new(this, "SetupAddAndRemoveOperation", 0);
				}
				return r_MSetupAddAndRemoveOperation;
			}
		}

		/// <summary>
		/// Void OnProcessAddAndRemoveResult(UnityEditor.PackageManager.Requests.Request`1[UnityEditor.PackageManager.PackageCollection])
		/// </summary>
		protected RMethod r_MOnProcessAddAndRemoveResult_Request_d_PackageCollection_p_;
		public virtual RMethod RMOnProcessAddAndRemoveResult_Request_d_PackageCollection_p_
		{
			get
			{
				if(r_MOnProcessAddAndRemoveResult_Request_d_PackageCollection_p_ == null)
				{
					r_MOnProcessAddAndRemoveResult_Request_d_PackageCollection_p_ = new(this, "OnProcessAddAndRemoveResult", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.Requests.Request`1").MakeGenericType(typeof(UnityEditor.PackageManager.PackageCollection)));
				}
				return r_MOnProcessAddAndRemoveResult_Request_d_PackageCollection_p_;
			}
		}

		/// <summary>
		/// Void List(Boolean)
		/// </summary>
		protected RMethod r_MList_Boolean;
		public virtual RMethod RMList_Boolean
		{
			get
			{
				if(r_MList_Boolean == null)
				{
					r_MList_Boolean = new(this, "List", 0, typeof(System.Boolean));
				}
				return r_MList_Boolean;
			}
		}

		/// <summary>
		/// Void OnProcessListResult(UnityEditor.PackageManager.Requests.ListRequest, Boolean)
		/// </summary>
		protected RMethod r_MOnProcessListResult_ListRequest_Boolean;
		public virtual RMethod RMOnProcessListResult_ListRequest_Boolean
		{
			get
			{
				if(r_MOnProcessListResult_ListRequest_Boolean == null)
				{
					r_MOnProcessListResult_ListRequest_Boolean = new(this, "OnProcessListResult", 0, typeof(UnityEditor.PackageManager.Requests.ListRequest), typeof(System.Boolean));
				}
				return r_MOnProcessListResult_ListRequest_Boolean;
			}
		}

		/// <summary>
		/// Void EmbedByName(System.String)
		/// </summary>
		protected RMethod r_MEmbedByName_String;
		public virtual RMethod RMEmbedByName_String
		{
			get
			{
				if(r_MEmbedByName_String == null)
				{
					r_MEmbedByName_String = new(this, "EmbedByName", 0, typeof(System.String));
				}
				return r_MEmbedByName_String;
			}
		}

		/// <summary>
		/// Void RemoveByName(System.String)
		/// </summary>
		protected RMethod r_MRemoveByName_String;
		public virtual RMethod RMRemoveByName_String
		{
			get
			{
				if(r_MRemoveByName_String == null)
				{
					r_MRemoveByName_String = new(this, "RemoveByName", 0, typeof(System.String));
				}
				return r_MRemoveByName_String;
			}
		}

		/// <summary>
		/// Void RemoveEmbeddedByName(System.String)
		/// </summary>
		protected RMethod r_MRemoveEmbeddedByName_String;
		public virtual RMethod RMRemoveEmbeddedByName_String
		{
			get
			{
				if(r_MRemoveEmbeddedByName_String == null)
				{
					r_MRemoveEmbeddedByName_String = new(this, "RemoveEmbeddedByName", 0, typeof(System.String));
				}
				return r_MRemoveEmbeddedByName_String;
			}
		}

		/// <summary>
		/// Void SetupRemoveOperation()
		/// </summary>
		protected RMethod r_MSetupRemoveOperation;
		public virtual RMethod RMSetupRemoveOperation
		{
			get
			{
				if(r_MSetupRemoveOperation == null)
				{
					r_MSetupRemoveOperation = new(this, "SetupRemoveOperation", 0);
				}
				return r_MSetupRemoveOperation;
			}
		}

		/// <summary>
		/// Void OnProcessRemoveResult(UnityEditor.PackageManager.Requests.RemoveRequest)
		/// </summary>
		protected RMethod r_MOnProcessRemoveResult_RemoveRequest;
		public virtual RMethod RMOnProcessRemoveResult_RemoveRequest
		{
			get
			{
				if(r_MOnProcessRemoveResult_RemoveRequest == null)
				{
					r_MOnProcessRemoveResult_RemoveRequest = new(this, "OnProcessRemoveResult", 0, typeof(UnityEditor.PackageManager.Requests.RemoveRequest));
				}
				return r_MOnProcessRemoveResult_RemoveRequest;
			}
		}

		/// <summary>
		/// Void SearchAll(Boolean)
		/// </summary>
		protected RMethod r_MSearchAll_Boolean;
		public virtual RMethod RMSearchAll_Boolean
		{
			get
			{
				if(r_MSearchAll_Boolean == null)
				{
					r_MSearchAll_Boolean = new(this, "SearchAll", 0, typeof(System.Boolean));
				}
				return r_MSearchAll_Boolean;
			}
		}

		/// <summary>
		/// Void OnProcessSearchAllResult(UnityEditor.PackageManager.Requests.SearchRequest, Boolean)
		/// </summary>
		protected RMethod r_MOnProcessSearchAllResult_SearchRequest_Boolean;
		public virtual RMethod RMOnProcessSearchAllResult_SearchRequest_Boolean
		{
			get
			{
				if(r_MOnProcessSearchAllResult_SearchRequest_Boolean == null)
				{
					r_MOnProcessSearchAllResult_SearchRequest_Boolean = new(this, "OnProcessSearchAllResult", 0, typeof(UnityEditor.PackageManager.Requests.SearchRequest), typeof(System.Boolean));
				}
				return r_MOnProcessSearchAllResult_SearchRequest_Boolean;
			}
		}

		/// <summary>
		/// Void ExtraFetch(System.String)
		/// </summary>
		protected RMethod r_MExtraFetch_String;
		public virtual RMethod RMExtraFetch_String
		{
			get
			{
				if(r_MExtraFetch_String == null)
				{
					r_MExtraFetch_String = new(this, "ExtraFetch", 0, typeof(System.String));
				}
				return r_MExtraFetch_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmSearchOperation ExtraFetchInternal(System.String, System.String)
		/// </summary>
		protected RMethod r_MExtraFetchInternal_String_String;
		public virtual RMethod RMExtraFetchInternal_String_String
		{
			get
			{
				if(r_MExtraFetchInternal_String_String == null)
				{
					r_MExtraFetchInternal_String_String = new(this, "ExtraFetchInternal", 0, typeof(System.String), typeof(System.String));
				}
				return r_MExtraFetchInternal_String_String;
			}
		}

		/// <summary>
		/// Void OnProcessExtraFetchResult(UnityEditor.PackageManager.Requests.SearchRequest, System.String)
		/// </summary>
		protected RMethod r_MOnProcessExtraFetchResult_SearchRequest_String;
		public virtual RMethod RMOnProcessExtraFetchResult_SearchRequest_String
		{
			get
			{
				if(r_MOnProcessExtraFetchResult_SearchRequest_String == null)
				{
					r_MOnProcessExtraFetchResult_SearchRequest_String = new(this, "OnProcessExtraFetchResult", 0, typeof(UnityEditor.PackageManager.Requests.SearchRequest), typeof(System.String));
				}
				return r_MOnProcessExtraFetchResult_SearchRequest_String;
			}
		}

		/// <summary>
		/// Void OnProcessExtraFetchError(UnityEditor.PackageManager.UI.Internal.UIError, System.String)
		/// </summary>
		protected RMethod r_MOnProcessExtraFetchError_UIError_String;
		public virtual RMethod RMOnProcessExtraFetchError_UIError_String
		{
			get
			{
				if(r_MOnProcessExtraFetchError_UIError_String == null)
				{
					r_MOnProcessExtraFetchError_UIError_String = new(this, "OnProcessExtraFetchError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"), typeof(System.String));
				}
				return r_MOnProcessExtraFetchError_UIError_String;
			}
		}

		/// <summary>
		/// Void OnExtraFetchFinalized(System.String)
		/// </summary>
		protected RMethod r_MOnExtraFetchFinalized_String;
		public virtual RMethod RMOnExtraFetchFinalized_String
		{
			get
			{
				if(r_MOnExtraFetchFinalized_String == null)
				{
					r_MOnExtraFetchFinalized_String = new(this, "OnExtraFetchFinalized", 0, typeof(System.String));
				}
				return r_MOnExtraFetchFinalized_String;
			}
		}

		/// <summary>
		/// Void FetchForProduct(System.String, System.String)
		/// </summary>
		protected RMethod r_MFetchForProduct_String_String;
		public virtual RMethod RMFetchForProduct_String_String
		{
			get
			{
				if(r_MFetchForProduct_String_String == null)
				{
					r_MFetchForProduct_String_String = new(this, "FetchForProduct", 0, typeof(System.String), typeof(System.String));
				}
				return r_MFetchForProduct_String_String;
			}
		}

		/// <summary>
		/// Void OnPackageInfosUpdated(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo])
		/// </summary>
		protected RMethod r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_;
		public virtual RMethod RMOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_
		{
			get
			{
				if(r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_ == null)
				{
					r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_ = new(this, "OnPackageInfosUpdated", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(UnityEditor.PackageManager.PackageInfo)));
				}
				return r_MOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_;
			}
		}

		/// <summary>
		/// Void OnShowPreReleasePackagesesOrSeeAllVersionsChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean;
		public virtual RMethod RMOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean
		{
			get
			{
				if(r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean == null)
				{
					r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean = new(this, "OnShowPreReleasePackagesesOrSeeAllVersionsChanged", 0, typeof(System.Boolean));
				}
				return r_MOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnLoadAllVersionsChanged(System.String, Boolean)
		/// </summary>
		protected RMethod r_MOnLoadAllVersionsChanged_String_Boolean;
		public virtual RMethod RMOnLoadAllVersionsChanged_String_Boolean
		{
			get
			{
				if(r_MOnLoadAllVersionsChanged_String_Boolean == null)
				{
					r_MOnLoadAllVersionsChanged_String_Boolean = new(this, "OnLoadAllVersionsChanged", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MOnLoadAllVersionsChanged_String_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.UpmPackage CreateUpmPackage(UnityEditor.PackageManager.PackageInfo, UnityEditor.PackageManager.PackageInfo, System.String)
		/// </summary>
		protected RMethod r_MCreateUpmPackage_PackageInfo_PackageInfo_String;
		public virtual RMethod RMCreateUpmPackage_PackageInfo_PackageInfo_String
		{
			get
			{
				if(r_MCreateUpmPackage_PackageInfo_PackageInfo_String == null)
				{
					r_MCreateUpmPackage_PackageInfo_PackageInfo_String = new(this, "CreateUpmPackage", 0, typeof(UnityEditor.PackageManager.PackageInfo), typeof(UnityEditor.PackageManager.PackageInfo), typeof(System.String));
				}
				return r_MCreateUpmPackage_PackageInfo_PackageInfo_String;
			}
		}

		/// <summary>
		/// Void UpdateExtraPackageInfos(System.String, UnityEditor.PackageManager.UI.Internal.IVersionList)
		/// </summary>
		protected RMethod r_MUpdateExtraPackageInfos_String_IVersionList;
		public virtual RMethod RMUpdateExtraPackageInfos_String_IVersionList
		{
			get
			{
				if(r_MUpdateExtraPackageInfos_String_IVersionList == null)
				{
					r_MUpdateExtraPackageInfos_String_IVersionList = new(this, "UpdateExtraPackageInfos", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IVersionList"));
				}
				return r_MUpdateExtraPackageInfos_String_IVersionList;
			}
		}

		/// <summary>
		/// Boolean HasHidableVersions(UnityEditor.PackageManager.UI.Internal.IPackage)
		/// </summary>
		protected static RMethod r_MHasHidableVersions_IPackage;
		public static RMethod RMHasHidableVersions_IPackage
		{
			get
			{
				if(r_MHasHidableVersions_IPackage == null)
				{
					r_MHasHidableVersions_IPackage = new(Type, "HasHidableVersions", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackage"));
				}
				return r_MHasHidableVersions_IPackage;
			}
		}

		/// <summary>
		/// Void FilterVersions(UnityEditor.PackageManager.UI.Internal.UpmPackage, Boolean)
		/// </summary>
		protected static RMethod r_MFilterVersions_UpmPackage_Boolean;
		public static RMethod RMFilterVersions_UpmPackage_Boolean
		{
			get
			{
				if(r_MFilterVersions_UpmPackage_Boolean == null)
				{
					r_MFilterVersions_UpmPackage_Boolean = new(Type, "FilterVersions", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackage"), typeof(System.Boolean));
				}
				return r_MFilterVersions_UpmPackage_Boolean;
			}
		}

		/// <summary>
		/// Void UnloadVersionsIfNeeded(UnityEditor.PackageManager.UI.Internal.UpmPackage)
		/// </summary>
		protected RMethod r_MUnloadVersionsIfNeeded_UpmPackage;
		public virtual RMethod RMUnloadVersionsIfNeeded_UpmPackage
		{
			get
			{
				if(r_MUnloadVersionsIfNeeded_UpmPackage == null)
				{
					r_MUnloadVersionsIfNeeded_UpmPackage = new(this, "UnloadVersionsIfNeeded", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmPackage"));
				}
				return r_MUnloadVersionsIfNeeded_UpmPackage;
			}
		}

		/// <summary>
		/// Void RestoreInProgressOperations()
		/// </summary>
		protected RMethod r_MRestoreInProgressOperations;
		public virtual RMethod RMRestoreInProgressOperations
		{
			get
			{
				if(r_MRestoreInProgressOperations == null)
				{
					r_MRestoreInProgressOperations = new(this, "RestoreInProgressOperations", 0);
				}
				return r_MRestoreInProgressOperations;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void ClearCache()
		/// </summary>
		protected RMethod r_MClearCache;
		public virtual RMethod RMClearCache
		{
			get
			{
				if(r_MClearCache == null)
				{
					r_MClearCache = new(this, "ClearCache", 0);
				}
				return r_MClearCache;
			}
		}

		/// <summary>
		/// Void ClearProductCache()
		/// </summary>
		protected RMethod r_MClearProductCache;
		public virtual RMethod RMClearProductCache
		{
			get
			{
				if(r_MClearProductCache == null)
				{
					r_MClearProductCache = new(this, "ClearProductCache", 0);
				}
				return r_MClearProductCache;
			}
		}

		/// <summary>
		/// Void Resolve()
		/// </summary>
		protected RMethod r_MResolve;
		public virtual RMethod RMResolve
		{
			get
			{
				if(r_MResolve == null)
				{
					r_MResolve = new(this, "Resolve", 0);
				}
				return r_MResolve;
			}
		}

		/// <summary>
		/// Boolean IsUnityPackage(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_MIsUnityPackage_PackageInfo;
		public virtual RMethod RMIsUnityPackage_PackageInfo
		{
			get
			{
				if(r_MIsUnityPackage_PackageInfo == null)
				{
					r_MIsUnityPackage_PackageInfo = new(this, "IsUnityPackage", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_MIsUnityPackage_PackageInfo;
			}
		}

		/// <summary>
		/// Boolean IsUnityUrl(System.String)
		/// </summary>
		protected static RMethod r_MIsUnityUrl_String;
		public static RMethod RMIsUnityUrl_String
		{
			get
			{
				if(r_MIsUnityUrl_String == null)
				{
					r_MIsUnityUrl_String = new(Type, "IsUnityUrl", 0, typeof(System.String));
				}
				return r_MIsUnityUrl_String;
			}
		}

		/// <summary>
		/// T CreateOperation[T](T ByRef)
		/// </summary>
		protected RMethod r_MCreateOperation_GT_Ref_T;
		public virtual RMethod RMCreateOperation_GT_Ref_T
		{
			get
			{
				if(r_MCreateOperation_GT_Ref_T == null)
				{
					r_MCreateOperation_GT_Ref_T = new(this, "CreateOperation", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MCreateOperation_GT_Ref_T;
			}
		}

		/// <summary>
		/// Boolean <IsAnyExperimentalPackagesInUse>b__74_0(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_M__0__IsAnyExperimentalPackagesInUse__1__b__74_0_PackageInfo;
		public virtual RMethod RM__0__IsAnyExperimentalPackagesInUse__1__b__74_0_PackageInfo
		{
			get
			{
				if(r_M__0__IsAnyExperimentalPackagesInUse__1__b__74_0_PackageInfo == null)
				{
					r_M__0__IsAnyExperimentalPackagesInUse__1__b__74_0_PackageInfo = new(this, "<IsAnyExperimentalPackagesInUse>b__74_0", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_M__0__IsAnyExperimentalPackagesInUse__1__b__74_0_PackageInfo;
			}
		}

		/// <summary>
		/// Void <SetupAddOperation>b__83_1(UnityEditor.PackageManager.Requests.AddRequest)
		/// </summary>
		protected RMethod r_M__0__SetupAddOperation__1__b__83_1_AddRequest;
		public virtual RMethod RM__0__SetupAddOperation__1__b__83_1_AddRequest
		{
			get
			{
				if(r_M__0__SetupAddOperation__1__b__83_1_AddRequest == null)
				{
					r_M__0__SetupAddOperation__1__b__83_1_AddRequest = new(this, "<SetupAddOperation>b__83_1", 0, typeof(UnityEditor.PackageManager.Requests.AddRequest));
				}
				return r_M__0__SetupAddOperation__1__b__83_1_AddRequest;
			}
		}

		/// <summary>
		/// Void <SetupAddOperation>b__83_0(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_M__0__SetupAddOperation__1__b__83_0_IOperation_UIError;
		public virtual RMethod RM__0__SetupAddOperation__1__b__83_0_IOperation_UIError
		{
			get
			{
				if(r_M__0__SetupAddOperation__1__b__83_0_IOperation_UIError == null)
				{
					r_M__0__SetupAddOperation__1__b__83_0_IOperation_UIError = new(this, "<SetupAddOperation>b__83_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_M__0__SetupAddOperation__1__b__83_0_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void <SetupAddAndRemoveOperation>b__89_0(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_M__0__SetupAddAndRemoveOperation__1__b__89_0_IOperation_UIError;
		public virtual RMethod RM__0__SetupAddAndRemoveOperation__1__b__89_0_IOperation_UIError
		{
			get
			{
				if(r_M__0__SetupAddAndRemoveOperation__1__b__89_0_IOperation_UIError == null)
				{
					r_M__0__SetupAddAndRemoveOperation__1__b__89_0_IOperation_UIError = new(this, "<SetupAddAndRemoveOperation>b__89_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_M__0__SetupAddAndRemoveOperation__1__b__89_0_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void <OnProcessAddAndRemoveResult>b__90_0()
		/// </summary>
		protected RMethod r_M__0__OnProcessAddAndRemoveResult__1__b__90_0;
		public virtual RMethod RM__0__OnProcessAddAndRemoveResult__1__b__90_0
		{
			get
			{
				if(r_M__0__OnProcessAddAndRemoveResult__1__b__90_0 == null)
				{
					r_M__0__OnProcessAddAndRemoveResult__1__b__90_0 = new(this, "<OnProcessAddAndRemoveResult>b__90_0", 0);
				}
				return r_M__0__OnProcessAddAndRemoveResult__1__b__90_0;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo <OnProcessAddAndRemoveResult>b__90_2(System.String)
		/// </summary>
		protected RMethod r_M__0__OnProcessAddAndRemoveResult__1__b__90_2_String;
		public virtual RMethod RM__0__OnProcessAddAndRemoveResult__1__b__90_2_String
		{
			get
			{
				if(r_M__0__OnProcessAddAndRemoveResult__1__b__90_2_String == null)
				{
					r_M__0__OnProcessAddAndRemoveResult__1__b__90_2_String = new(this, "<OnProcessAddAndRemoveResult>b__90_2", 0, typeof(System.String));
				}
				return r_M__0__OnProcessAddAndRemoveResult__1__b__90_2_String;
			}
		}

		/// <summary>
		/// Void <OnProcessAddAndRemoveResult>b__90_1()
		/// </summary>
		protected RMethod r_M__0__OnProcessAddAndRemoveResult__1__b__90_1;
		public virtual RMethod RM__0__OnProcessAddAndRemoveResult__1__b__90_1
		{
			get
			{
				if(r_M__0__OnProcessAddAndRemoveResult__1__b__90_1 == null)
				{
					r_M__0__OnProcessAddAndRemoveResult__1__b__90_1 = new(this, "<OnProcessAddAndRemoveResult>b__90_1", 0);
				}
				return r_M__0__OnProcessAddAndRemoveResult__1__b__90_1;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo <OnProcessAddAndRemoveResult>b__90_4(System.String)
		/// </summary>
		protected RMethod r_M__0__OnProcessAddAndRemoveResult__1__b__90_4_String;
		public virtual RMethod RM__0__OnProcessAddAndRemoveResult__1__b__90_4_String
		{
			get
			{
				if(r_M__0__OnProcessAddAndRemoveResult__1__b__90_4_String == null)
				{
					r_M__0__OnProcessAddAndRemoveResult__1__b__90_4_String = new(this, "<OnProcessAddAndRemoveResult>b__90_4", 0, typeof(System.String));
				}
				return r_M__0__OnProcessAddAndRemoveResult__1__b__90_4_String;
			}
		}

		/// <summary>
		/// Void <EmbedByName>b__93_1(UnityEditor.PackageManager.Requests.EmbedRequest)
		/// </summary>
		protected RMethod r_M__0__EmbedByName__1__b__93_1_EmbedRequest;
		public virtual RMethod RM__0__EmbedByName__1__b__93_1_EmbedRequest
		{
			get
			{
				if(r_M__0__EmbedByName__1__b__93_1_EmbedRequest == null)
				{
					r_M__0__EmbedByName__1__b__93_1_EmbedRequest = new(this, "<EmbedByName>b__93_1", 0, typeof(UnityEditor.PackageManager.Requests.EmbedRequest));
				}
				return r_M__0__EmbedByName__1__b__93_1_EmbedRequest;
			}
		}

		/// <summary>
		/// Void <EmbedByName>b__93_0(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_M__0__EmbedByName__1__b__93_0_IOperation_UIError;
		public virtual RMethod RM__0__EmbedByName__1__b__93_0_IOperation_UIError
		{
			get
			{
				if(r_M__0__EmbedByName__1__b__93_0_IOperation_UIError == null)
				{
					r_M__0__EmbedByName__1__b__93_0_IOperation_UIError = new(this, "<EmbedByName>b__93_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_M__0__EmbedByName__1__b__93_0_IOperation_UIError;
			}
		}

		/// <summary>
		/// Void <SetupRemoveOperation>b__96_0(UnityEditor.PackageManager.UI.Internal.IOperation, UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_M__0__SetupRemoveOperation__1__b__96_0_IOperation_UIError;
		public virtual RMethod RM__0__SetupRemoveOperation__1__b__96_0_IOperation_UIError
		{
			get
			{
				if(r_M__0__SetupRemoveOperation__1__b__96_0_IOperation_UIError == null)
				{
					r_M__0__SetupRemoveOperation__1__b__96_0_IOperation_UIError = new(this, "<SetupRemoveOperation>b__96_0", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOperation"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_M__0__SetupRemoveOperation__1__b__96_0_IOperation_UIError;
			}
		}

		/// <summary>
		/// Boolean <OnShowPreReleasePackagesesOrSeeAllVersionsChanged>b__107_0(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0_PackageInfo;
		public virtual RMethod RM__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0_PackageInfo
		{
			get
			{
				if(r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0_PackageInfo == null)
				{
					r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0_PackageInfo = new(this, "<OnShowPreReleasePackagesesOrSeeAllVersionsChanged>b__107_0", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0_PackageInfo;
			}
		}

		/// <summary>
		/// Boolean <OnShowPreReleasePackagesesOrSeeAllVersionsChanged>b__107_1(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1_PackageInfo;
		public virtual RMethod RM__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1_PackageInfo
		{
			get
			{
				if(r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1_PackageInfo == null)
				{
					r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1_PackageInfo = new(this, "<OnShowPreReleasePackagesesOrSeeAllVersionsChanged>b__107_1", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_M__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1_PackageInfo;
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


		public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @IOProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageManagerProjectSettingsProxy @settingsProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RClientProxy @clientProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RApplicationProxy @applicationProxy)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@upmCache.Value, @IOProxy.Value, @settingsProxy.Value, @clientProxy.Value, @applicationProxy.Value};
			var ___result = RMResolveDependencies_UpmCache_IOProxy_PackageManagerProjectSettingsProxy_ClientProxy_ApplicationProxy.Invoke(___genericsType, ___parameters);
		}


		public virtual System.Boolean IsAnyExperimentalPackagesInUse()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMIsAnyExperimentalPackagesInUse.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
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


		public virtual System.Boolean IsEmbedInProgress(System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageName};
			var ___result = RMIsEmbedInProgress_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Boolean IsRemoveInProgress(System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageName};
			var ___result = RMIsRemoveInProgress_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Boolean IsAddInProgress(System.String @packageId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageId};
			var ___result = RMIsAddInProgress_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual void AddById(System.String @packageId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageId};
			var ___result = RMAddById_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void SetupAddOperation()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMSetupAddOperation.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnProcessAddResult(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @operation, UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageInfo> @request)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@operation.Value, @request};
			var ___result = RMOnProcessAddResult_IOperation_Request_d_PackageInfo_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual void AddByPath(System.String @path)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@path};
			var ___result = RMAddByPath_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void AddByUrl(System.String @url)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@url};
			var ___result = RMAddByUrl_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void AddAndResetDependencies(System.String @packageId, System.Collections.Generic.IEnumerable<System.String> @dependencyPackagesNames)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageId, @dependencyPackagesNames};
			var ___result = RMAddAndResetDependencies_String_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual void ResetDependencies(System.String @packageId, System.Collections.Generic.IEnumerable<System.String> @dependencyPackagesNames)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageId, @dependencyPackagesNames};
			var ___result = RMResetDependencies_String_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual void SetupAddAndRemoveOperation()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMSetupAddAndRemoveOperation.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnProcessAddAndRemoveResult(UnityEditor.PackageManager.Requests.Request<UnityEditor.PackageManager.PackageCollection> @request)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request};
			var ___result = RMOnProcessAddAndRemoveResult_Request_d_PackageCollection_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual void List(System.Boolean @offlineMode)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@offlineMode};
			var ___result = RMList_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnProcessListResult(UnityEditor.PackageManager.Requests.ListRequest @request, System.Boolean @offlineMode)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request, @offlineMode};
			var ___result = RMOnProcessListResult_ListRequest_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual void EmbedByName(System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageName};
			var ___result = RMEmbedByName_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void RemoveByName(System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageName};
			var ___result = RMRemoveByName_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void RemoveEmbeddedByName(System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageName};
			var ___result = RMRemoveEmbeddedByName_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void SetupRemoveOperation()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMSetupRemoveOperation.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnProcessRemoveResult(UnityEditor.PackageManager.Requests.RemoveRequest @request)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request};
			var ___result = RMOnProcessRemoveResult_RemoveRequest.Invoke(___genericsType, ___parameters);
		}


		public virtual void SearchAll(System.Boolean @offlineMode)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@offlineMode};
			var ___result = RMSearchAll_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnProcessSearchAllResult(UnityEditor.PackageManager.Requests.SearchRequest @request, System.Boolean @offlineMode)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request, @offlineMode};
			var ___result = RMOnProcessSearchAllResult_SearchRequest_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual void ExtraFetch(System.String @packageId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageId};
			var ___result = RMExtraFetch_String.Invoke(___genericsType, ___parameters);
		}


		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation ExtraFetchInternal(System.String @packageIdOrName, System.String @productId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageIdOrName, @productId};
			var ___result = RMExtraFetchInternal_String_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmSearchOperation>(___result);
		}


		public virtual void OnProcessExtraFetchResult(UnityEditor.PackageManager.Requests.SearchRequest @request, System.String @productId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request, @productId};
			var ___result = RMOnProcessExtraFetchResult_SearchRequest_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnProcessExtraFetchError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error, System.String @productId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@error.Value, @productId};
			var ___result = RMOnProcessExtraFetchError_UIError_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnExtraFetchFinalized(System.String @packageIdOrName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageIdOrName};
			var ___result = RMOnExtraFetchFinalized_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void FetchForProduct(System.String @productId, System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@productId, @packageName};
			var ___result = RMFetchForProduct_String_String.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnPackageInfosUpdated(System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo> @packageInfos)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageInfos};
			var ___result = RMOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnShowPreReleasePackagesesOrSeeAllVersionsChanged(System.Boolean @showPreReleaseOrSeeAllVersions)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@showPreReleaseOrSeeAllVersions};
			var ___result = RMOnShowPreReleasePackagesesOrSeeAllVersionsChanged_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnLoadAllVersionsChanged(System.String @packageUniqueId, System.Boolean @value)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageUniqueId, @value};
			var ___result = RMOnLoadAllVersionsChanged_String_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackage CreateUpmPackage(UnityEditor.PackageManager.PackageInfo @searchInfo, UnityEditor.PackageManager.PackageInfo @installedInfo, System.String @packageName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@searchInfo, @installedInfo, @packageName};
			var ___result = RMCreateUpmPackage_PackageInfo_PackageInfo_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackage>(___result);
		}


		public virtual void UpdateExtraPackageInfos(System.String @packageName, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIVersionList @versions)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageName, @versions.Value};
			var ___result = RMUpdateExtraPackageInfos_String_IVersionList.Invoke(___genericsType, ___parameters);
		}


		public static System.Boolean HasHidableVersions(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackage @package)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@package.Value};
			var ___result = RMHasHidableVersions_IPackage.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public static void FilterVersions(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackage @package, System.Boolean @showPreRelease)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@package.Value, @showPreRelease};
			var ___result = RMFilterVersions_UpmPackage_Boolean.Invoke(___genericsType, ___parameters);
		}


		public virtual void UnloadVersionsIfNeeded(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmPackage @package)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@package.Value};
			var ___result = RMUnloadVersionsIfNeeded_UpmPackage.Invoke(___genericsType, ___parameters);
		}


		public virtual void RestoreInProgressOperations()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMRestoreInProgressOperations.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnEnable()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);
		}


		public virtual void OnDisable()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);
		}


		public virtual void ClearCache()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMClearCache.Invoke(___genericsType, ___parameters);
		}


		public virtual void ClearProductCache()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMClearProductCache.Invoke(___genericsType, ___parameters);
		}


		public virtual void Resolve()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMResolve.Invoke(___genericsType, ___parameters);
		}


		public virtual System.Boolean IsUnityPackage(UnityEditor.PackageManager.PackageInfo @packageInfo)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@packageInfo};
			var ___result = RMIsUnityPackage_PackageInfo.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public static System.Boolean IsUnityUrl(System.String @url)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@url};
			var ___result = RMIsUnityUrl_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual Hvak.Editor.Refleaction.RType CreateOperation<T>(ref Hvak.Editor.Refleaction.RType @operation) where T : new()
		{
			var ___genericsType = new Type[] {typeof(T)};
			var ___parameters = new object[]{@operation.Value};
			var ___result = RMCreateOperation_GT_Ref_T.Invoke(___genericsType, ___parameters);
			@operation = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___parameters[0]);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RType>(___result);
		}


		public virtual System.Boolean __0__IsAnyExperimentalPackagesInUse__1__b__74_0(UnityEditor.PackageManager.PackageInfo @info)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@info};
			var ___result = RM__0__IsAnyExperimentalPackagesInUse__1__b__74_0_PackageInfo.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual void __0__SetupAddOperation__1__b__83_1(UnityEditor.PackageManager.Requests.AddRequest @request)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request};
			var ___result = RM__0__SetupAddOperation__1__b__83_1_AddRequest.Invoke(___genericsType, ___parameters);
		}


		public virtual void __0__SetupAddOperation__1__b__83_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@op.Value, @error.Value};
			var ___result = RM__0__SetupAddOperation__1__b__83_0_IOperation_UIError.Invoke(___genericsType, ___parameters);
		}


		public virtual void __0__SetupAddAndRemoveOperation__1__b__89_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@op.Value, @error.Value};
			var ___result = RM__0__SetupAddAndRemoveOperation__1__b__89_0_IOperation_UIError.Invoke(___genericsType, ___parameters);
		}


		public virtual void __0__OnProcessAddAndRemoveResult__1__b__90_0()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RM__0__OnProcessAddAndRemoveResult__1__b__90_0.Invoke(___genericsType, ___parameters);
		}


		public virtual UnityEditor.PackageManager.PackageInfo __0__OnProcessAddAndRemoveResult__1__b__90_2(System.String @name)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@name};
			var ___result = RM__0__OnProcessAddAndRemoveResult__1__b__90_2_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEditor.PackageManager.PackageInfo>(___result);
		}


		public virtual void __0__OnProcessAddAndRemoveResult__1__b__90_1()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RM__0__OnProcessAddAndRemoveResult__1__b__90_1.Invoke(___genericsType, ___parameters);
		}


		public virtual UnityEditor.PackageManager.PackageInfo __0__OnProcessAddAndRemoveResult__1__b__90_4(System.String @id)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@id};
			var ___result = RM__0__OnProcessAddAndRemoveResult__1__b__90_4_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEditor.PackageManager.PackageInfo>(___result);
		}


		public virtual void __0__EmbedByName__1__b__93_1(UnityEditor.PackageManager.Requests.EmbedRequest @request)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@request};
			var ___result = RM__0__EmbedByName__1__b__93_1_EmbedRequest.Invoke(___genericsType, ___parameters);
		}


		public virtual void __0__EmbedByName__1__b__93_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@op.Value, @error.Value};
			var ___result = RM__0__EmbedByName__1__b__93_0_IOperation_UIError.Invoke(___genericsType, ___parameters);
		}


		public virtual void __0__SetupRemoveOperation__1__b__96_0(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOperation @op, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@op.Value, @error.Value};
			var ___result = RM__0__SetupRemoveOperation__1__b__96_0_IOperation_UIError.Invoke(___genericsType, ___parameters);
		}


		public virtual System.Boolean __0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0(UnityEditor.PackageManager.PackageInfo @p)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@p};
			var ___result = RM__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_0_PackageInfo.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Boolean __0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1(UnityEditor.PackageManager.PackageInfo @p)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@p};
			var ___result = RM__0__OnShowPreReleasePackagesesOrSeeAllVersionsChanged__1__b__107_1_PackageInfo.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Boolean Equals(System.Object @obj)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@obj};
			var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
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
			return ReflectionUtils.Convert<System.Int32>(___result);
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


		public virtual System.String ToString()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMToString.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


    }
}
