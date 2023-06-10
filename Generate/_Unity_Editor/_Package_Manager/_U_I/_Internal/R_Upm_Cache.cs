
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.UpmCache
	/// </summary>
    public partial class RUpmCache : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache");
            }
        }

        public RUpmCache() : base("UnityEditor.PackageManager.UI.Internal.UpmCache")
        {
        }

        public RUpmCache(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.UpmCache")
		{
            SetInstance(instance);
		}

        public RUpmCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpmCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`2[System.String,System.Boolean] onLoadAllVersionsChanged
		/// </summary>
		protected REvent r_EonLoadAllVersionsChanged;
		public virtual REvent REonLoadAllVersionsChanged
		{
			get
			{
				if(r_EonLoadAllVersionsChanged == null)
				{
					r_EonLoadAllVersionsChanged = new(this, "onLoadAllVersionsChanged");
				}
				return r_EonLoadAllVersionsChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo]] onPackageInfosUpdated
		/// </summary>
		protected REvent r_EonPackageInfosUpdated;
		public virtual REvent REonPackageInfosUpdated
		{
			get
			{
				if(r_EonPackageInfosUpdated == null)
				{
					r_EonPackageInfosUpdated = new(this, "onPackageInfosUpdated");
				}
				return r_EonPackageInfosUpdated;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.PackageInfo] onExtraPackageInfoFetched
		/// </summary>
		protected REvent r_EonExtraPackageInfoFetched;
		public virtual REvent REonExtraPackageInfoFetched
		{
			get
			{
				if(r_EonExtraPackageInfoFetched == null)
				{
					r_EonExtraPackageInfoFetched = new(this, "onExtraPackageInfoFetched");
				}
				return r_EonExtraPackageInfoFetched;
			}
		}

		/// <summary>
		/// System.Action`1[System.String] onVerifiedGitPackageUpToDate
		/// </summary>
		protected REvent r_EonVerifiedGitPackageUpToDate;
		public virtual REvent REonVerifiedGitPackageUpToDate
		{
			get
			{
				if(r_EonVerifiedGitPackageUpToDate == null)
				{
					r_EonVerifiedGitPackageUpToDate = new(this, "onVerifiedGitPackageUpToDate");
				}
				return r_EonVerifiedGitPackageUpToDate;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo] m_SearchPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_SearchPackageInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_SearchPackageInfos
		{
			get
			{
				if(r_Fm_SearchPackageInfos == null)
				{
					r_Fm_SearchPackageInfos = new(this, "m_SearchPackageInfos");
				}
				return r_Fm_SearchPackageInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo] m_InstalledPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_InstalledPackageInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_InstalledPackageInfos
		{
			get
			{
				if(r_Fm_InstalledPackageInfos == null)
				{
					r_Fm_InstalledPackageInfos = new(this, "m_InstalledPackageInfos");
				}
				return r_Fm_InstalledPackageInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo] m_ProductSearchPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_ProductSearchPackageInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_ProductSearchPackageInfos
		{
			get
			{
				if(r_Fm_ProductSearchPackageInfos == null)
				{
					r_Fm_ProductSearchPackageInfos = new(this, "m_ProductSearchPackageInfos");
				}
				return r_Fm_ProductSearchPackageInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] m_ProductIdToNameMap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_Fm_ProductIdToNameMap;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RFm_ProductIdToNameMap
		{
			get
			{
				if(r_Fm_ProductIdToNameMap == null)
				{
					r_Fm_ProductIdToNameMap = new(this, "m_ProductIdToNameMap");
				}
				return r_Fm_ProductIdToNameMap;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] m_NameToProductIdMap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_Fm_NameToProductIdMap;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RFm_NameToProductIdMap
		{
			get
			{
				if(r_Fm_NameToProductIdMap == null)
				{
					r_Fm_NameToProductIdMap = new(this, "m_NameToProductIdMap");
				}
				return r_Fm_NameToProductIdMap;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo]] m_ExtraPackageInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo>> r_Fm_ExtraPackageInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo>> RFm_ExtraPackageInfo
		{
			get
			{
				if(r_Fm_ExtraPackageInfo == null)
				{
					r_Fm_ExtraPackageInfo = new(this, "m_ExtraPackageInfo");
				}
				return r_Fm_ExtraPackageInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.Object]] m_ParsedUpmReserved
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject>> r_Fm_ParsedUpmReserved;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RObject>> RFm_ParsedUpmReserved
		{
			get
			{
				if(r_Fm_ParsedUpmReserved == null)
				{
					r_Fm_ParsedUpmReserved = new(this, "m_ParsedUpmReserved");
				}
				return r_Fm_ParsedUpmReserved;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.String] m_LoadAllVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_LoadAllVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RString> RFm_LoadAllVersions
		{
			get
			{
				if(r_Fm_LoadAllVersions == null)
				{
					r_Fm_LoadAllVersions = new(this, "m_LoadAllVersions");
				}
				return r_Fm_LoadAllVersions;
			}
		}

		/// <summary>
		/// System.Int64 m_SearchPackageInfosTimestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_SearchPackageInfosTimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_SearchPackageInfosTimestamp
		{
			get
			{
				if(r_Fm_SearchPackageInfosTimestamp == null)
				{
					r_Fm_SearchPackageInfosTimestamp = new(this, "m_SearchPackageInfosTimestamp");
				}
				return r_Fm_SearchPackageInfosTimestamp;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] m_SerializedInstalledPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_SerializedInstalledPackageInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_SerializedInstalledPackageInfos
		{
			get
			{
				if(r_Fm_SerializedInstalledPackageInfos == null)
				{
					r_Fm_SerializedInstalledPackageInfos = new(this, "m_SerializedInstalledPackageInfos");
				}
				return r_Fm_SerializedInstalledPackageInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] m_SerializedSearchPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_SerializedSearchPackageInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_SerializedSearchPackageInfos
		{
			get
			{
				if(r_Fm_SerializedSearchPackageInfos == null)
				{
					r_Fm_SerializedSearchPackageInfos = new(this, "m_SerializedSearchPackageInfos");
				}
				return r_Fm_SerializedSearchPackageInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] m_SerializedProductSearchPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_SerializedProductSearchPackageInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_SerializedProductSearchPackageInfos
		{
			get
			{
				if(r_Fm_SerializedProductSearchPackageInfos == null)
				{
					r_Fm_SerializedProductSearchPackageInfos = new(this, "m_SerializedProductSearchPackageInfos");
				}
				return r_Fm_SerializedProductSearchPackageInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] m_SerializedExtraPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Fm_SerializedExtraPackageInfos;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFm_SerializedExtraPackageInfos
		{
			get
			{
				if(r_Fm_SerializedExtraPackageInfos == null)
				{
					r_Fm_SerializedExtraPackageInfos = new(this, "m_SerializedExtraPackageInfos");
				}
				return r_Fm_SerializedExtraPackageInfos;
			}
		}

		/// <summary>
		/// System.String[] m_SerializedLoadAllVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_SerializedLoadAllVersions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_SerializedLoadAllVersions
		{
			get
			{
				if(r_Fm_SerializedLoadAllVersions == null)
				{
					r_Fm_SerializedLoadAllVersions = new(this, "m_SerializedLoadAllVersions");
				}
				return r_Fm_SerializedLoadAllVersions;
			}
		}

		/// <summary>
		/// System.Action`2[System.String,System.Boolean] onLoadAllVersionsChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> r_FonLoadAllVersionsChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RBoolean> RFonLoadAllVersionsChanged
		{
			get
			{
				if(r_FonLoadAllVersionsChanged == null)
				{
					r_FonLoadAllVersionsChanged = new(this, "onLoadAllVersionsChanged");
				}
				return r_FonLoadAllVersionsChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo]] onPackageInfosUpdated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo>> r_FonPackageInfosUpdated;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo>> RFonPackageInfosUpdated
		{
			get
			{
				if(r_FonPackageInfosUpdated == null)
				{
					r_FonPackageInfosUpdated = new(this, "onPackageInfosUpdated");
				}
				return r_FonPackageInfosUpdated;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.PackageInfo] onExtraPackageInfoFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_FonExtraPackageInfoFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RFonExtraPackageInfoFetched
		{
			get
			{
				if(r_FonExtraPackageInfoFetched == null)
				{
					r_FonExtraPackageInfoFetched = new(this, "onExtraPackageInfoFetched");
				}
				return r_FonExtraPackageInfoFetched;
			}
		}

		/// <summary>
		/// System.Action`1[System.String] onVerifiedGitPackageUpToDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString> r_FonVerifiedGitPackageUpToDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RString> RFonVerifiedGitPackageUpToDate
		{
			get
			{
				if(r_FonVerifiedGitPackageUpToDate == null)
				{
					r_FonVerifiedGitPackageUpToDate = new(this, "onVerifiedGitPackageUpToDate");
				}
				return r_FonVerifiedGitPackageUpToDate;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo] searchPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_PsearchPackageInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPsearchPackageInfos
		{
			get
			{
				if(r_PsearchPackageInfos == null)
				{
					r_PsearchPackageInfos = new(this, "searchPackageInfos", -1);
				}
				return r_PsearchPackageInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo] installedPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_PinstalledPackageInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPinstalledPackageInfos
		{
			get
			{
				if(r_PinstalledPackageInfos == null)
				{
					r_PinstalledPackageInfos = new(this, "installedPackageInfos", -1);
				}
				return r_PinstalledPackageInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo] productSearchPackageInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_PproductSearchPackageInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPproductSearchPackageInfos
		{
			get
			{
				if(r_PproductSearchPackageInfos == null)
				{
					r_PproductSearchPackageInfos = new(this, "productSearchPackageInfos", -1);
				}
				return r_PproductSearchPackageInfos;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.PackageInfo] FindUpdatedPackageInfos(System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo], System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo])
		/// </summary>
		protected static RMethod r_MFindUpdatedPackageInfos_Dictionary_d_String_PackageInfo_p__Dictionary_d_String_PackageInfo_p_;
		public static RMethod RMFindUpdatedPackageInfos_Dictionary_d_String_PackageInfo_p__Dictionary_d_String_PackageInfo_p_
		{
			get
			{
				if(r_MFindUpdatedPackageInfos_Dictionary_d_String_PackageInfo_p__Dictionary_d_String_PackageInfo_p_ == null)
				{
					r_MFindUpdatedPackageInfos_Dictionary_d_String_PackageInfo_p__Dictionary_d_String_PackageInfo_p_ = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"), "FindUpdatedPackageInfos", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(UnityEditor.PackageManager.PackageInfo)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(UnityEditor.PackageManager.PackageInfo)));
				}
				return r_MFindUpdatedPackageInfos_Dictionary_d_String_PackageInfo_p__Dictionary_d_String_PackageInfo_p_;
			}
		}

		/// <summary>
		/// Boolean IsDifferent(UnityEditor.PackageManager.PackageInfo, UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected static RMethod r_MIsDifferent_PackageInfo_PackageInfo;
		public static RMethod RMIsDifferent_PackageInfo_PackageInfo
		{
			get
			{
				if(r_MIsDifferent_PackageInfo_PackageInfo == null)
				{
					r_MIsDifferent_PackageInfo_PackageInfo = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"), "IsDifferent", 0, typeof(UnityEditor.PackageManager.PackageInfo), typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_MIsDifferent_PackageInfo_PackageInfo;
			}
		}

		/// <summary>
		/// Boolean IsLoadAllVersions(System.String)
		/// </summary>
		protected RMethod r_MIsLoadAllVersions_String;
		public virtual RMethod RMIsLoadAllVersions_String
		{
			get
			{
				if(r_MIsLoadAllVersions_String == null)
				{
					r_MIsLoadAllVersions_String = new(this, "IsLoadAllVersions", 0, typeof(System.String));
				}
				return r_MIsLoadAllVersions_String;
			}
		}

		/// <summary>
		/// Void SetLoadAllVersions(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetLoadAllVersions_String_Boolean;
		public virtual RMethod RMSetLoadAllVersions_String_Boolean
		{
			get
			{
				if(r_MSetLoadAllVersions_String_Boolean == null)
				{
					r_MSetLoadAllVersions_String_Boolean = new(this, "SetLoadAllVersions", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MSetLoadAllVersions_String_Boolean;
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
		/// Void UpdateProductIdAndNameMapping(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_MUpdateProductIdAndNameMapping_PackageInfo;
		public virtual RMethod RMUpdateProductIdAndNameMapping_PackageInfo
		{
			get
			{
				if(r_MUpdateProductIdAndNameMapping_PackageInfo == null)
				{
					r_MUpdateProductIdAndNameMapping_PackageInfo = new(this, "UpdateProductIdAndNameMapping", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_MUpdateProductIdAndNameMapping_PackageInfo;
			}
		}

		/// <summary>
		/// Void AddExtraPackageInfo(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_MAddExtraPackageInfo_PackageInfo;
		public virtual RMethod RMAddExtraPackageInfo_PackageInfo
		{
			get
			{
				if(r_MAddExtraPackageInfo_PackageInfo == null)
				{
					r_MAddExtraPackageInfo_PackageInfo = new(this, "AddExtraPackageInfo", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_MAddExtraPackageInfo_PackageInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditor.PackageManager.PackageInfo] GetExtraPackageInfos(System.String)
		/// </summary>
		protected RMethod r_MGetExtraPackageInfos_String;
		public virtual RMethod RMGetExtraPackageInfos_String
		{
			get
			{
				if(r_MGetExtraPackageInfos_String == null)
				{
					r_MGetExtraPackageInfos_String = new(this, "GetExtraPackageInfos", 0, typeof(System.String));
				}
				return r_MGetExtraPackageInfos_String;
			}
		}

		/// <summary>
		/// Void RemoveInstalledPackageInfo(System.String)
		/// </summary>
		protected RMethod r_MRemoveInstalledPackageInfo_String;
		public virtual RMethod RMRemoveInstalledPackageInfo_String
		{
			get
			{
				if(r_MRemoveInstalledPackageInfo_String == null)
				{
					r_MRemoveInstalledPackageInfo_String = new(this, "RemoveInstalledPackageInfo", 0, typeof(System.String));
				}
				return r_MRemoveInstalledPackageInfo_String;
			}
		}

		/// <summary>
		/// Boolean IsPackageInstalled(System.String)
		/// </summary>
		protected RMethod r_MIsPackageInstalled_String;
		public virtual RMethod RMIsPackageInstalled_String
		{
			get
			{
				if(r_MIsPackageInstalled_String == null)
				{
					r_MIsPackageInstalled_String = new(this, "IsPackageInstalled", 0, typeof(System.String));
				}
				return r_MIsPackageInstalled_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo GetInstalledPackageInfo(System.String)
		/// </summary>
		protected RMethod r_MGetInstalledPackageInfo_String;
		public virtual RMethod RMGetInstalledPackageInfo_String
		{
			get
			{
				if(r_MGetInstalledPackageInfo_String == null)
				{
					r_MGetInstalledPackageInfo_String = new(this, "GetInstalledPackageInfo", 0, typeof(System.String));
				}
				return r_MGetInstalledPackageInfo_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo GetInstalledPackageInfoById(System.String)
		/// </summary>
		protected RMethod r_MGetInstalledPackageInfoById_String;
		public virtual RMethod RMGetInstalledPackageInfoById_String
		{
			get
			{
				if(r_MGetInstalledPackageInfoById_String == null)
				{
					r_MGetInstalledPackageInfoById_String = new(this, "GetInstalledPackageInfoById", 0, typeof(System.String));
				}
				return r_MGetInstalledPackageInfoById_String;
			}
		}

		/// <summary>
		/// Void SetInstalledPackageInfo(UnityEditor.PackageManager.PackageInfo, Boolean)
		/// </summary>
		protected RMethod r_MSetInstalledPackageInfo_PackageInfo_Boolean;
		public virtual RMethod RMSetInstalledPackageInfo_PackageInfo_Boolean
		{
			get
			{
				if(r_MSetInstalledPackageInfo_PackageInfo_Boolean == null)
				{
					r_MSetInstalledPackageInfo_PackageInfo_Boolean = new(this, "SetInstalledPackageInfo", 0, typeof(UnityEditor.PackageManager.PackageInfo), typeof(System.Boolean));
				}
				return r_MSetInstalledPackageInfo_PackageInfo_Boolean;
			}
		}

		/// <summary>
		/// Void SetInstalledPackageInfos(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo], Int64)
		/// </summary>
		protected RMethod r_MSetInstalledPackageInfos_IEnumerable_d_PackageInfo_p__Int64;
		public virtual RMethod RMSetInstalledPackageInfos_IEnumerable_d_PackageInfo_p__Int64
		{
			get
			{
				if(r_MSetInstalledPackageInfos_IEnumerable_d_PackageInfo_p__Int64 == null)
				{
					r_MSetInstalledPackageInfos_IEnumerable_d_PackageInfo_p__Int64 = new(this, "SetInstalledPackageInfos", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEditor.PackageManager.PackageInfo)), typeof(System.Int64));
				}
				return r_MSetInstalledPackageInfos_IEnumerable_d_PackageInfo_p__Int64;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo GetSearchPackageInfo(System.String)
		/// </summary>
		protected RMethod r_MGetSearchPackageInfo_String;
		public virtual RMethod RMGetSearchPackageInfo_String
		{
			get
			{
				if(r_MGetSearchPackageInfo_String == null)
				{
					r_MGetSearchPackageInfo_String = new(this, "GetSearchPackageInfo", 0, typeof(System.String));
				}
				return r_MGetSearchPackageInfo_String;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo GetBestMatchPackageInfo(System.String, Boolean, System.String)
		/// </summary>
		protected RMethod r_MGetBestMatchPackageInfo_String_Boolean_String;
		public virtual RMethod RMGetBestMatchPackageInfo_String_Boolean_String
		{
			get
			{
				if(r_MGetBestMatchPackageInfo_String_Boolean_String == null)
				{
					r_MGetBestMatchPackageInfo_String_Boolean_String = new(this, "GetBestMatchPackageInfo", 0, typeof(System.String), typeof(System.Boolean), typeof(System.String));
				}
				return r_MGetBestMatchPackageInfo_String_Boolean_String;
			}
		}

		/// <summary>
		/// Void SetSearchPackageInfos(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo], Int64)
		/// </summary>
		protected RMethod r_MSetSearchPackageInfos_IEnumerable_d_PackageInfo_p__Int64;
		public virtual RMethod RMSetSearchPackageInfos_IEnumerable_d_PackageInfo_p__Int64
		{
			get
			{
				if(r_MSetSearchPackageInfos_IEnumerable_d_PackageInfo_p__Int64 == null)
				{
					r_MSetSearchPackageInfos_IEnumerable_d_PackageInfo_p__Int64 = new(this, "SetSearchPackageInfos", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEditor.PackageManager.PackageInfo)), typeof(System.Int64));
				}
				return r_MSetSearchPackageInfos_IEnumerable_d_PackageInfo_p__Int64;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo GetProductSearchPackageInfo(System.String)
		/// </summary>
		protected RMethod r_MGetProductSearchPackageInfo_String;
		public virtual RMethod RMGetProductSearchPackageInfo_String
		{
			get
			{
				if(r_MGetProductSearchPackageInfo_String == null)
				{
					r_MGetProductSearchPackageInfo_String = new(this, "GetProductSearchPackageInfo", 0, typeof(System.String));
				}
				return r_MGetProductSearchPackageInfo_String;
			}
		}

		/// <summary>
		/// Void SetProductSearchPackageInfo(System.String, UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_MSetProductSearchPackageInfo_String_PackageInfo;
		public virtual RMethod RMSetProductSearchPackageInfo_String_PackageInfo
		{
			get
			{
				if(r_MSetProductSearchPackageInfo_String_PackageInfo == null)
				{
					r_MSetProductSearchPackageInfo_String_PackageInfo = new(this, "SetProductSearchPackageInfo", 0, typeof(System.String), typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_MSetProductSearchPackageInfo_String_PackageInfo;
			}
		}

		/// <summary>
		/// Void TriggerOnPackageInfosUpdated(System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.PackageInfo])
		/// </summary>
		protected RMethod r_MTriggerOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_;
		public virtual RMethod RMTriggerOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_
		{
			get
			{
				if(r_MTriggerOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_ == null)
				{
					r_MTriggerOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_ = new(this, "TriggerOnPackageInfosUpdated", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEditor.PackageManager.PackageInfo)));
				}
				return r_MTriggerOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] ParseUpmReserved(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_MParseUpmReserved_PackageInfo;
		public virtual RMethod RMParseUpmReserved_PackageInfo
		{
			get
			{
				if(r_MParseUpmReserved_PackageInfo == null)
				{
					r_MParseUpmReserved_PackageInfo = new(this, "ParseUpmReserved", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_MParseUpmReserved_PackageInfo;
			}
		}

		/// <summary>
		/// System.String GetProductIdByName(System.String)
		/// </summary>
		protected RMethod r_MGetProductIdByName_String;
		public virtual RMethod RMGetProductIdByName_String
		{
			get
			{
				if(r_MGetProductIdByName_String == null)
				{
					r_MGetProductIdByName_String = new(this, "GetProductIdByName", 0, typeof(System.String));
				}
				return r_MGetProductIdByName_String;
			}
		}

		/// <summary>
		/// System.String GetNameByProductId(System.String)
		/// </summary>
		protected RMethod r_MGetNameByProductId_String;
		public virtual RMethod RMGetNameByProductId_String
		{
			get
			{
				if(r_MGetNameByProductId_String == null)
				{
					r_MGetNameByProductId_String = new(this, "GetNameByProductId", 0, typeof(System.String));
				}
				return r_MGetNameByProductId_String;
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
		/// Boolean <SetInstalledPackageInfos>b__46_2(UnityEditor.PackageManager.PackageInfo)
		/// </summary>
		protected RMethod r_M__0__SetInstalledPackageInfos__1__b__46_2_PackageInfo;
		public virtual RMethod RM__0__SetInstalledPackageInfos__1__b__46_2_PackageInfo
		{
			get
			{
				if(r_M__0__SetInstalledPackageInfos__1__b__46_2_PackageInfo == null)
				{
					r_M__0__SetInstalledPackageInfos__1__b__46_2_PackageInfo = new(this, "<SetInstalledPackageInfos>b__46_2", 0, typeof(UnityEditor.PackageManager.PackageInfo));
				}
				return r_M__0__SetInstalledPackageInfos__1__b__46_2_PackageInfo;
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


        public static System.Collections.Generic.List<UnityEditor.PackageManager.PackageInfo> FindUpdatedPackageInfos(System.Collections.Generic.Dictionary<System.String, UnityEditor.PackageManager.PackageInfo> @oldInfos, System.Collections.Generic.Dictionary<System.String, UnityEditor.PackageManager.PackageInfo> @newInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldInfos, @newInfos};
            var ___result = RMFindUpdatedPackageInfos_Dictionary_d_String_PackageInfo_p__Dictionary_d_String_PackageInfo_p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<UnityEditor.PackageManager.PackageInfo>)___result;
        }


        public static System.Boolean IsDifferent(UnityEditor.PackageManager.PackageInfo @p1, UnityEditor.PackageManager.PackageInfo @p2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p1, @p2};
            var ___result = RMIsDifferent_PackageInfo_PackageInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLoadAllVersions(System.String @packageUniqueId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId};
            var ___result = RMIsLoadAllVersions_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetLoadAllVersions(System.String @packageUniqueId, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageUniqueId, @value};
            var ___result = RMSetLoadAllVersions_String_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void UpdateProductIdAndNameMapping(UnityEditor.PackageManager.PackageInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = RMUpdateProductIdAndNameMapping_PackageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExtraPackageInfo(UnityEditor.PackageManager.PackageInfo @packageInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfo};
            var ___result = RMAddExtraPackageInfo_PackageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<System.String, UnityEditor.PackageManager.PackageInfo> GetExtraPackageInfos(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMGetExtraPackageInfos_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, UnityEditor.PackageManager.PackageInfo>)___result;
        }


        public virtual void RemoveInstalledPackageInfo(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMRemoveInstalledPackageInfo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPackageInstalled(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMIsPackageInstalled_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.PackageManager.PackageInfo GetInstalledPackageInfo(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMGetInstalledPackageInfo_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public virtual UnityEditor.PackageManager.PackageInfo GetInstalledPackageInfoById(System.String @packageId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageId};
            var ___result = RMGetInstalledPackageInfoById_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public virtual void SetInstalledPackageInfo(UnityEditor.PackageManager.PackageInfo @info, System.Boolean @isSpecialInstallation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @isSpecialInstallation};
            var ___result = RMSetInstalledPackageInfo_PackageInfo_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInstalledPackageInfos(System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo> @packageInfos, System.Int64 @timestamp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfos, @timestamp};
            var ___result = RMSetInstalledPackageInfos_IEnumerable_d_PackageInfo_p__Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.PackageManager.PackageInfo GetSearchPackageInfo(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMGetSearchPackageInfo_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public virtual UnityEditor.PackageManager.PackageInfo GetBestMatchPackageInfo(System.String @packageName, System.Boolean @isInstalled, System.String @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName, @isInstalled, @version};
            var ___result = RMGetBestMatchPackageInfo_String_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public virtual void SetSearchPackageInfos(System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo> @packageInfos, System.Int64 @timestamp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfos, @timestamp};
            var ___result = RMSetSearchPackageInfos_IEnumerable_d_PackageInfo_p__Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.PackageManager.PackageInfo GetProductSearchPackageInfo(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMGetProductSearchPackageInfo_String.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo)___result;
        }


        public virtual void SetProductSearchPackageInfo(System.String @productId, UnityEditor.PackageManager.PackageInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId, @info};
            var ___result = RMSetProductSearchPackageInfo_String_PackageInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerOnPackageInfosUpdated(System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.PackageInfo> @packageInfos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfos};
            var ___result = RMTriggerOnPackageInfosUpdated_IEnumerable_d_PackageInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<System.String, System.Object> ParseUpmReserved(UnityEditor.PackageManager.PackageInfo @packageInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageInfo};
            var ___result = RMParseUpmReserved_PackageInfo.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, System.Object>)___result;
        }


        public virtual System.String GetProductIdByName(System.String @packageName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName};
            var ___result = RMGetProductIdByName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetNameByProductId(System.String @productId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@productId};
            var ___result = RMGetNameByProductId_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.Boolean __0__SetInstalledPackageInfos__1__b__46_2(UnityEditor.PackageManager.PackageInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = RM__0__SetInstalledPackageInfos__1__b__46_2_PackageInfo.Invoke(___genericsType, ___parameters);

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
