
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualTreeAsset
	/// </summary>
    public partial class RVisualTreeAsset : RMember //
    {

		/// <summary>
		/// System.String LinkedVEAInTemplatePropertyName
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_FLinkedVEAInTemplatePropertyName;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFLinkedVEAInTemplatePropertyName
		{
			get
			{
				if(r_FLinkedVEAInTemplatePropertyName == null)
				{
					r_FLinkedVEAInTemplatePropertyName = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "LinkedVEAInTemplatePropertyName");
					r_FLinkedVEAInTemplatePropertyName.SetBelong(null);
				}
				return r_FLinkedVEAInTemplatePropertyName;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithErrors
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_ImportedWithErrors;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_ImportedWithErrors
		{
			get
			{
				if(r_Fm_ImportedWithErrors == null)
				{
					r_Fm_ImportedWithErrors = new(this, "m_ImportedWithErrors");
					r_Fm_ImportedWithErrors.SetBelong(this.instance);
				}
				return r_Fm_ImportedWithErrors;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithWarnings
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_ImportedWithWarnings;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_ImportedWithWarnings
		{
			get
			{
				if(r_Fm_ImportedWithWarnings == null)
				{
					r_Fm_ImportedWithWarnings = new(this, "m_ImportedWithWarnings");
					r_Fm_ImportedWithWarnings.SetBelong(this.instance);
				}
				return r_Fm_ImportedWithWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] s_TemporarySlotInsertionPoints
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RString, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fs_TemporarySlotInsertionPoints;
		public static SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RString, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFs_TemporarySlotInsertionPoints
		{
			get
			{
				if(r_Fs_TemporarySlotInsertionPoints == null)
				{
					r_Fs_TemporarySlotInsertionPoints = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "s_TemporarySlotInsertionPoints");
					r_Fs_TemporarySlotInsertionPoints.SetBelong(null);
				}
				return r_Fs_TemporarySlotInsertionPoints;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UsingEntry] m_Usings
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> r_Fm_Usings;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> RFm_Usings
		{
			get
			{
				if(r_Fm_Usings == null)
				{
					r_Fm_Usings = new(this, "m_Usings");
					r_Fm_Usings.SetBelong(this.instance);
				}
				return r_Fm_Usings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet inlineSheet
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_FinlineSheet;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RFinlineSheet
		{
			get
			{
				if(r_FinlineSheet == null)
				{
					r_FinlineSheet = new(this, "inlineSheet");
					r_FinlineSheet.SetBelong(this.instance);
				}
				return r_FinlineSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset] m_VisualElementAssets
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> r_Fm_VisualElementAssets;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> RFm_VisualElementAssets
		{
			get
			{
				if(r_Fm_VisualElementAssets == null)
				{
					r_Fm_VisualElementAssets = new(this, "m_VisualElementAssets");
					r_Fm_VisualElementAssets.SetBelong(this.instance);
				}
				return r_Fm_VisualElementAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset] m_TemplateAssets
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> r_Fm_TemplateAssets;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> RFm_TemplateAssets
		{
			get
			{
				if(r_Fm_TemplateAssets == null)
				{
					r_Fm_TemplateAssets = new(this, "m_TemplateAssets");
					r_Fm_TemplateAssets.SetBelong(this.instance);
				}
				return r_Fm_TemplateAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry] m_UxmlObjectEntries
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> r_Fm_UxmlObjectEntries;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> RFm_UxmlObjectEntries
		{
			get
			{
				if(r_Fm_UxmlObjectEntries == null)
				{
					r_Fm_UxmlObjectEntries = new(this, "m_UxmlObjectEntries");
					r_Fm_UxmlObjectEntries.SetBelong(this.instance);
				}
				return r_Fm_UxmlObjectEntries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_UxmlObjectIds
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RInt32> r_Fm_UxmlObjectIds;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RInt32> RFm_UxmlObjectIds
		{
			get
			{
				if(r_Fm_UxmlObjectIds == null)
				{
					r_Fm_UxmlObjectIds = new(this, "m_UxmlObjectIds");
					r_Fm_UxmlObjectIds.SetBelong(this.instance);
				}
				return r_Fm_UxmlObjectIds;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+AssetEntry] m_AssetEntries
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RAssetEntry> r_Fm_AssetEntries;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RAssetEntry> RFm_AssetEntries
		{
			get
			{
				if(r_Fm_AssetEntries == null)
				{
					r_Fm_AssetEntries = new(this, "m_AssetEntries");
					r_Fm_AssetEntries.SetBelong(this.instance);
				}
				return r_Fm_AssetEntries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotDefinition] m_Slots
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> r_Fm_Slots;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> RFm_Slots
		{
			get
			{
				if(r_Fm_Slots == null)
				{
					r_Fm_Slots = new(this, "m_Slots");
					r_Fm_Slots.SetBelong(this.instance);
				}
				return r_Fm_Slots;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentContainerId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_ContentContainerId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_ContentContainerId
		{
			get
			{
				if(r_Fm_ContentContainerId == null)
				{
					r_Fm_ContentContainerId = new(this, "m_ContentContainerId");
					r_Fm_ContentContainerId.SetBelong(this.instance);
				}
				return r_Fm_ContentContainerId;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentHash
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_ContentHash;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_ContentHash
		{
			get
			{
				if(r_Fm_ContentHash == null)
				{
					r_Fm_ContentHash = new(this, "m_ContentHash");
					r_Fm_ContentHash.SetBelong(this.instance);
				}
				return r_Fm_ContentHash;
			}
		}

		/// <summary>
		/// Boolean importedWithErrors
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PimportedWithErrors;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPimportedWithErrors
		{
			get
			{
				if(r_PimportedWithErrors == null)
				{
					r_PimportedWithErrors = new(this, "importedWithErrors", -1);
					r_PimportedWithErrors.SetBelong(this.instance);
				}
				return r_PimportedWithErrors;
			}
		}

		/// <summary>
		/// Boolean importedWithWarnings
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PimportedWithWarnings;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPimportedWithWarnings
		{
			get
			{
				if(r_PimportedWithWarnings == null)
				{
					r_PimportedWithWarnings = new(this, "importedWithWarnings", -1);
					r_PimportedWithWarnings.SetBelong(this.instance);
				}
				return r_PimportedWithWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualTreeAsset] templateDependencies
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> r_PtemplateDependencies;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> RPtemplateDependencies
		{
			get
			{
				if(r_PtemplateDependencies == null)
				{
					r_PtemplateDependencies = new(this, "templateDependencies", -1);
					r_PtemplateDependencies.SetBelong(this.instance);
				}
				return r_PtemplateDependencies;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StyleSheet] stylesheets
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_Pstylesheets;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RPstylesheets
		{
			get
			{
				if(r_Pstylesheets == null)
				{
					r_Pstylesheets = new(this, "stylesheets", -1);
					r_Pstylesheets.SetBelong(this.instance);
				}
				return r_Pstylesheets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset] visualElementAssets
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> r_PvisualElementAssets;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> RPvisualElementAssets
		{
			get
			{
				if(r_PvisualElementAssets == null)
				{
					r_PvisualElementAssets = new(this, "visualElementAssets", -1);
					r_PvisualElementAssets.SetBelong(this.instance);
				}
				return r_PvisualElementAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset] templateAssets
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> r_PtemplateAssets;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> RPtemplateAssets
		{
			get
			{
				if(r_PtemplateAssets == null)
				{
					r_PtemplateAssets = new(this, "templateAssets", -1);
					r_PtemplateAssets.SetBelong(this.instance);
				}
				return r_PtemplateAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry] uxmlObjectEntries
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> r_PuxmlObjectEntries;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> RPuxmlObjectEntries
		{
			get
			{
				if(r_PuxmlObjectEntries == null)
				{
					r_PuxmlObjectEntries = new(this, "uxmlObjectEntries", -1);
					r_PuxmlObjectEntries.SetBelong(this.instance);
				}
				return r_PuxmlObjectEntries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] uxmlObjectIds
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RInt32> r_PuxmlObjectIds;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RSystem.RInt32> RPuxmlObjectIds
		{
			get
			{
				if(r_PuxmlObjectIds == null)
				{
					r_PuxmlObjectIds = new(this, "uxmlObjectIds", -1);
					r_PuxmlObjectIds.SetBelong(this.instance);
				}
				return r_PuxmlObjectIds;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotDefinition] slots
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> r_Pslots;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> RPslots
		{
			get
			{
				if(r_Pslots == null)
				{
					r_Pslots = new(this, "slots", -1);
					r_Pslots.SetBelong(this.instance);
				}
				return r_Pslots;
			}
		}

		/// <summary>
		/// Int32 contentContainerId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PcontentContainerId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPcontentContainerId
		{
			get
			{
				if(r_PcontentContainerId == null)
				{
					r_PcontentContainerId = new(this, "contentContainerId", -1);
					r_PcontentContainerId.SetBelong(this.instance);
				}
				return r_PcontentContainerId;
			}
		}

		/// <summary>
		/// Int32 contentHash
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PcontentHash;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPcontentHash
		{
			get
			{
				if(r_PcontentHash == null)
				{
					r_PcontentHash = new(this, "contentHash", -1);
					r_PcontentHash.SetBelong(this.instance);
				}
				return r_PcontentHash;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
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
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Int32 GetNextChildSerialNumber()
		/// </summary>
		protected RMethod r_MGetNextChildSerialNumber;
		public virtual RMethod RMGetNextChildSerialNumber
		{
			get
			{
				if(r_MGetNextChildSerialNumber == null)
				{
					r_MGetNextChildSerialNumber = new(this, "GetNextChildSerialNumber", 0);
					r_MGetNextChildSerialNumber.SetBelong(this.instance);
				}
				return r_MGetNextChildSerialNumber;
			}
		}

		/// <summary>
		/// Void RegisterUxmlObject(UnityEngine.UIElements.UxmlObjectAsset)
		/// </summary>
		protected RMethod r_MRegisterUxmlObject_UxmlObjectAsset;
		public virtual RMethod RMRegisterUxmlObject_UxmlObjectAsset
		{
			get
			{
				if(r_MRegisterUxmlObject_UxmlObjectAsset == null)
				{
					r_MRegisterUxmlObject_UxmlObjectAsset = new(this, "RegisterUxmlObject", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UxmlObjectAsset"));
					r_MRegisterUxmlObject_UxmlObjectAsset.SetBelong(this.instance);
				}
				return r_MRegisterUxmlObject_UxmlObjectAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T] GetUxmlObjects[T](UnityEngine.UIElements.IUxmlAttributes, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected RMethod r_MGetUxmlObjects_GT_IUxmlAttributes_CreationContext;
		public virtual RMethod RMGetUxmlObjects_GT_IUxmlAttributes_CreationContext
		{
			get
			{
				if(r_MGetUxmlObjects_GT_IUxmlAttributes_CreationContext == null)
				{
					r_MGetUxmlObjects_GT_IUxmlAttributes_CreationContext = new(this, "GetUxmlObjects", 1, typeof(UnityEngine.UIElements.IUxmlAttributes), typeof(UnityEngine.UIElements.CreationContext));
					r_MGetUxmlObjects_GT_IUxmlAttributes_CreationContext.SetBelong(this.instance);
				}
				return r_MGetUxmlObjects_GT_IUxmlAttributes_CreationContext;
			}
		}

		/// <summary>
		/// Boolean AssetEntryExists(System.String, System.Type)
		/// </summary>
		protected RMethod r_MAssetEntryExists_String_Type;
		public virtual RMethod RMAssetEntryExists_String_Type
		{
			get
			{
				if(r_MAssetEntryExists_String_Type == null)
				{
					r_MAssetEntryExists_String_Type = new(this, "AssetEntryExists", 0, typeof(System.String), typeof(System.Type));
					r_MAssetEntryExists_String_Type.SetBelong(this.instance);
				}
				return r_MAssetEntryExists_String_Type;
			}
		}

		/// <summary>
		/// Void RegisterAssetEntry(System.String, System.Type, UnityEngine.Object)
		/// </summary>
		protected RMethod r_MRegisterAssetEntry_String_Type_Object;
		public virtual RMethod RMRegisterAssetEntry_String_Type_Object
		{
			get
			{
				if(r_MRegisterAssetEntry_String_Type_Object == null)
				{
					r_MRegisterAssetEntry_String_Type_Object = new(this, "RegisterAssetEntry", 0, typeof(System.String), typeof(System.Type), typeof(UnityEngine.Object));
					r_MRegisterAssetEntry_String_Type_Object.SetBelong(this.instance);
				}
				return r_MRegisterAssetEntry_String_Type_Object;
			}
		}

		/// <summary>
		/// T GetAsset[T](System.String)
		/// </summary>
		protected RMethod r_MGetAsset_GT_String;
		public virtual RMethod RMGetAsset_GT_String
		{
			get
			{
				if(r_MGetAsset_GT_String == null)
				{
					r_MGetAsset_GT_String = new(this, "GetAsset", 1, typeof(System.String));
					r_MGetAsset_GT_String.SetBelong(this.instance);
				}
				return r_MGetAsset_GT_String;
			}
		}

		/// <summary>
		/// UxmlObjectEntry GetUxmlObjectEntry(Int32)
		/// </summary>
		protected RMethod r_MGetUxmlObjectEntry_Int32;
		public virtual RMethod RMGetUxmlObjectEntry_Int32
		{
			get
			{
				if(r_MGetUxmlObjectEntry_Int32 == null)
				{
					r_MGetUxmlObjectEntry_Int32 = new(this, "GetUxmlObjectEntry", 0, typeof(System.Int32));
					r_MGetUxmlObjectEntry_Int32.SetBelong(this.instance);
				}
				return r_MGetUxmlObjectEntry_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IBaseUxmlObjectFactory GetUxmlObjectFactory(UnityEngine.UIElements.UxmlObjectAsset)
		/// </summary>
		protected RMethod r_MGetUxmlObjectFactory_UxmlObjectAsset;
		public virtual RMethod RMGetUxmlObjectFactory_UxmlObjectAsset
		{
			get
			{
				if(r_MGetUxmlObjectFactory_UxmlObjectAsset == null)
				{
					r_MGetUxmlObjectFactory_UxmlObjectAsset = new(this, "GetUxmlObjectFactory", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UxmlObjectAsset"));
					r_MGetUxmlObjectFactory_UxmlObjectAsset.SetBelong(this.instance);
				}
				return r_MGetUxmlObjectFactory_UxmlObjectAsset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer Instantiate()
		/// </summary>
		protected RMethod r_MInstantiate;
		public virtual RMethod RMInstantiate
		{
			get
			{
				if(r_MInstantiate == null)
				{
					r_MInstantiate = new(this, "Instantiate", 0);
					r_MInstantiate.SetBelong(this.instance);
				}
				return r_MInstantiate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer Instantiate(System.String)
		/// </summary>
		protected RMethod r_MInstantiate_String;
		public virtual RMethod RMInstantiate_String
		{
			get
			{
				if(r_MInstantiate_String == null)
				{
					r_MInstantiate_String = new(this, "Instantiate", 0, typeof(System.String));
					r_MInstantiate_String.SetBelong(this.instance);
				}
				return r_MInstantiate_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer CloneTree()
		/// </summary>
		protected RMethod r_MCloneTree;
		public virtual RMethod RMCloneTree
		{
			get
			{
				if(r_MCloneTree == null)
				{
					r_MCloneTree = new(this, "CloneTree", 0);
					r_MCloneTree.SetBelong(this.instance);
				}
				return r_MCloneTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer CloneTree(System.String)
		/// </summary>
		protected RMethod r_MCloneTree_String;
		public virtual RMethod RMCloneTree_String
		{
			get
			{
				if(r_MCloneTree_String == null)
				{
					r_MCloneTree_String = new(this, "CloneTree", 0, typeof(System.String));
					r_MCloneTree_String.SetBelong(this.instance);
				}
				return r_MCloneTree_String;
			}
		}

		/// <summary>
		/// Void CloneTree(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MCloneTree_VisualElement;
		public virtual RMethod RMCloneTree_VisualElement
		{
			get
			{
				if(r_MCloneTree_VisualElement == null)
				{
					r_MCloneTree_VisualElement = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MCloneTree_VisualElement.SetBelong(this.instance);
				}
				return r_MCloneTree_VisualElement;
			}
		}

		/// <summary>
		/// Void CloneTree(UnityEngine.UIElements.VisualElement, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MCloneTree_VisualElement_Out_Int32_Out_Int32;
		public virtual RMethod RMCloneTree_VisualElement_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MCloneTree_VisualElement_Out_Int32_Out_Int32 == null)
				{
					r_MCloneTree_VisualElement_Out_Int32_Out_Int32 = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MCloneTree_VisualElement_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_MCloneTree_VisualElement_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void CloneTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement], System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride])
		/// </summary>
		protected RMethod r_MCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_;
		public virtual RMethod RMCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_
		{
			get
			{
				if(r_MCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_ == null)
				{
					r_MCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_ = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(UnityEngine.UIElements.VisualElement)), typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.TemplateAsset+AttributeOverride")));
					r_MCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_.SetBelong(this.instance);
				}
				return r_MCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset, System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset]], UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected RMethod r_MCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext;
		public virtual RMethod RMCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext
		{
			get
			{
				if(r_MCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext == null)
				{
					r_MCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext = new(this, "CloneSetupRecursively", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"))), typeof(UnityEngine.UIElements.CreationContext));
					r_MCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext.SetBelong(this.instance);
				}
				return r_MCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext;
			}
		}

		/// <summary>
		/// Int32 CompareForOrder(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.VisualElementAsset)
		/// </summary>
		protected static RMethod r_MCompareForOrder_VisualElementAsset_VisualElementAsset;
		public static RMethod RMCompareForOrder_VisualElementAsset_VisualElementAsset
		{
			get
			{
				if(r_MCompareForOrder_VisualElementAsset_VisualElementAsset == null)
				{
					r_MCompareForOrder_VisualElementAsset_VisualElementAsset = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "CompareForOrder", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"));
					r_MCompareForOrder_VisualElementAsset_VisualElementAsset.SetBelong(null);
				}
				return r_MCompareForOrder_VisualElementAsset_VisualElementAsset;
			}
		}

		/// <summary>
		/// Boolean SlotDefinitionExists(System.String)
		/// </summary>
		protected RMethod r_MSlotDefinitionExists_String;
		public virtual RMethod RMSlotDefinitionExists_String
		{
			get
			{
				if(r_MSlotDefinitionExists_String == null)
				{
					r_MSlotDefinitionExists_String = new(this, "SlotDefinitionExists", 0, typeof(System.String));
					r_MSlotDefinitionExists_String.SetBelong(this.instance);
				}
				return r_MSlotDefinitionExists_String;
			}
		}

		/// <summary>
		/// Boolean AddSlotDefinition(System.String, Int32)
		/// </summary>
		protected RMethod r_MAddSlotDefinition_String_Int32;
		public virtual RMethod RMAddSlotDefinition_String_Int32
		{
			get
			{
				if(r_MAddSlotDefinition_String_Int32 == null)
				{
					r_MAddSlotDefinition_String_Int32 = new(this, "AddSlotDefinition", 0, typeof(System.String), typeof(System.Int32));
					r_MAddSlotDefinition_String_Int32.SetBelong(this.instance);
				}
				return r_MAddSlotDefinition_String_Int32;
			}
		}

		/// <summary>
		/// Boolean TryGetSlotInsertionPoint(Int32, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryGetSlotInsertionPoint_Int32_Out_String;
		public virtual RMethod RMTryGetSlotInsertionPoint_Int32_Out_String
		{
			get
			{
				if(r_MTryGetSlotInsertionPoint_Int32_Out_String == null)
				{
					r_MTryGetSlotInsertionPoint_Int32_Out_String = new(this, "TryGetSlotInsertionPoint", 0, typeof(System.Int32), typeof(System.String).MakeByRefType());
					r_MTryGetSlotInsertionPoint_Int32_Out_String.SetBelong(this.instance);
				}
				return r_MTryGetSlotInsertionPoint_Int32_Out_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String)
		/// </summary>
		protected RMethod r_MResolveTemplate_String;
		public virtual RMethod RMResolveTemplate_String
		{
			get
			{
				if(r_MResolveTemplate_String == null)
				{
					r_MResolveTemplate_String = new(this, "ResolveTemplate", 0, typeof(System.String));
					r_MResolveTemplate_String.SetBelong(this.instance);
				}
				return r_MResolveTemplate_String;
			}
		}

		/// <summary>
		/// Boolean TemplateExists(System.String)
		/// </summary>
		protected RMethod r_MTemplateExists_String;
		public virtual RMethod RMTemplateExists_String
		{
			get
			{
				if(r_MTemplateExists_String == null)
				{
					r_MTemplateExists_String = new(this, "TemplateExists", 0, typeof(System.String));
					r_MTemplateExists_String.SetBelong(this.instance);
				}
				return r_MTemplateExists_String;
			}
		}

		/// <summary>
		/// Void RegisterTemplate(System.String, System.String)
		/// </summary>
		protected RMethod r_MRegisterTemplate_String_String;
		public virtual RMethod RMRegisterTemplate_String_String
		{
			get
			{
				if(r_MRegisterTemplate_String_String == null)
				{
					r_MRegisterTemplate_String_String = new(this, "RegisterTemplate", 0, typeof(System.String), typeof(System.String));
					r_MRegisterTemplate_String_String.SetBelong(this.instance);
				}
				return r_MRegisterTemplate_String_String;
			}
		}

		/// <summary>
		/// Void RegisterTemplate(System.String, UnityEngine.UIElements.VisualTreeAsset)
		/// </summary>
		protected RMethod r_MRegisterTemplate_String_VisualTreeAsset;
		public virtual RMethod RMRegisterTemplate_String_VisualTreeAsset
		{
			get
			{
				if(r_MRegisterTemplate_String_VisualTreeAsset == null)
				{
					r_MRegisterTemplate_String_VisualTreeAsset = new(this, "RegisterTemplate", 0, typeof(System.String), typeof(UnityEngine.UIElements.VisualTreeAsset));
					r_MRegisterTemplate_String_VisualTreeAsset.SetBelong(this.instance);
				}
				return r_MRegisterTemplate_String_VisualTreeAsset;
			}
		}

		/// <summary>
		/// Void InsertUsingEntry(UsingEntry)
		/// </summary>
		protected RMethod r_MInsertUsingEntry_UsingEntry;
		public virtual RMethod RMInsertUsingEntry_UsingEntry
		{
			get
			{
				if(r_MInsertUsingEntry_UsingEntry == null)
				{
					r_MInsertUsingEntry_UsingEntry = new(this, "InsertUsingEntry", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+UsingEntry"));
					r_MInsertUsingEntry_UsingEntry.SetBelong(this.instance);
				}
				return r_MInsertUsingEntry_UsingEntry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected static RMethod r_MCreate_VisualElementAsset_CreationContext;
		public static RMethod RMCreate_VisualElementAsset_CreationContext
		{
			get
			{
				if(r_MCreate_VisualElementAsset_CreationContext == null)
				{
					r_MCreate_VisualElementAsset_CreationContext = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "Create", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.CreationContext));
					r_MCreate_VisualElementAsset_CreationContext.SetBelong(null);
				}
				return r_MCreate_VisualElementAsset_CreationContext;
			}
		}

		/// <summary>
		/// Void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_MAssignClassListFromAssetToElement_VisualElementAsset_VisualElement;
		public static RMethod RMAssignClassListFromAssetToElement_VisualElementAsset_VisualElement
		{
			get
			{
				if(r_MAssignClassListFromAssetToElement_VisualElementAsset_VisualElement == null)
				{
					r_MAssignClassListFromAssetToElement_VisualElementAsset_VisualElement = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "AssignClassListFromAssetToElement", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.VisualElement));
					r_MAssignClassListFromAssetToElement_VisualElementAsset_VisualElement.SetBelong(null);
				}
				return r_MAssignClassListFromAssetToElement_VisualElementAsset_VisualElement;
			}
		}

		/// <summary>
		/// Void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement;
		public static RMethod RMAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement
		{
			get
			{
				if(r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement == null)
				{
					r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "AssignStyleSheetFromAssetToElement", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.VisualElement));
					r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement.SetBelong(null);
				}
				return r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement;
			}
		}

		/// <summary>
		/// Int32 GetAttributePropertiesDirtyCount()
		/// </summary>
		protected RMethod r_MGetAttributePropertiesDirtyCount;
		public virtual RMethod RMGetAttributePropertiesDirtyCount
		{
			get
			{
				if(r_MGetAttributePropertiesDirtyCount == null)
				{
					r_MGetAttributePropertiesDirtyCount = new(this, "GetAttributePropertiesDirtyCount", 0);
					r_MGetAttributePropertiesDirtyCount.SetBelong(this.instance);
				}
				return r_MGetAttributePropertiesDirtyCount;
			}
		}

		/// <summary>
		/// Void ExtractUsedUxmlQualifiedNames(System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_;
		public virtual RMethod RMExtractUsedUxmlQualifiedNames_HashSet_d_String_p_
		{
			get
			{
				if(r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_ == null)
				{
					r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_ = new(this, "ExtractUsedUxmlQualifiedNames", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
					r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_.SetBelong(this.instance);
				}
				return r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <Create>g__CreateError|71_0(<>c__DisplayClass71_0 ByRef)
		/// </summary>
		protected static RMethod r_M__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0;
		public static RMethod RM__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0
		{
			get
			{
				if(r_M__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0 == null)
				{
					r_M__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0 = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "<Create>g__CreateError|71_0", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+<>c__DisplayClass71_0").MakeByRefType());
					r_M__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0.SetBelong(null);
				}
				return r_M__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
					r_MSetDirty.SetBelong(this.instance);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.instance);
				}
				return r_MGetInstanceID;
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


        public RVisualTreeAsset() : base("UnityEngine.UIElements.VisualTreeAsset")
        {
        }

        public RVisualTreeAsset(System.Object instance) : base("UnityEngine.UIElements.VisualTreeAsset")
		{
            SetInstance(instance);
		}

        public RVisualTreeAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualTreeAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetNextChildSerialNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextChildSerialNumber.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RegisterUxmlObject(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUxmlObjectAsset @uxmlObjectAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uxmlObjectAsset.Value};
            var ___result = RMRegisterUxmlObject_UxmlObjectAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<T> GetUxmlObjects<T>(UnityEngine.UIElements.IUxmlAttributes @asset, UnityEngine.UIElements.CreationContext @cc) where T : new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@asset, @cc};
            var ___result = RMGetUxmlObjects_GT_IUxmlAttributes_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<T>)___result;
        }


        public virtual System.Boolean AssetEntryExists(System.String @path, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @type};
            var ___result = RMAssetEntryExists_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterAssetEntry(System.String @path, System.Type @type, UnityEngine.Object @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @type, @asset};
            var ___result = RMRegisterAssetEntry_String_Type_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetAsset<T>(System.String @path) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@path};
            var ___result = RMGetAsset_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry GetUxmlObjectEntry(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMGetUxmlObjectEntry_Int32.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIBaseUxmlObjectFactory GetUxmlObjectFactory(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUxmlObjectAsset @uxmlObjectAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uxmlObjectAsset.Value};
            var ___result = RMGetUxmlObjectFactory_UxmlObjectAsset.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIBaseUxmlObjectFactory(___result);
        }


        public virtual UnityEngine.UIElements.TemplateContainer Instantiate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInstantiate.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual UnityEngine.UIElements.TemplateContainer Instantiate(System.String @bindingPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingPath};
            var ___result = RMInstantiate_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual UnityEngine.UIElements.TemplateContainer CloneTree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCloneTree.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual UnityEngine.UIElements.TemplateContainer CloneTree(System.String @bindingPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingPath};
            var ___result = RMCloneTree_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual void CloneTree(UnityEngine.UIElements.VisualElement @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCloneTree_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloneTree(UnityEngine.UIElements.VisualElement @target, out System.Int32 @firstElementIndex, out System.Int32 @elementAddedCount)
        {
			@firstElementIndex = default;
			@elementAddedCount = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @firstElementIndex, @elementAddedCount};
            var ___result = RMCloneTree_VisualElement_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@firstElementIndex = (System.Int32)___parameters[1];
			@elementAddedCount = (System.Int32)___parameters[2];

            
        }


        public virtual void CloneTree(UnityEngine.UIElements.VisualElement @target, System.Collections.Generic.Dictionary<System.String, UnityEngine.UIElements.VisualElement> @slotInsertionPoints, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> @attributeOverrides)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @slotInsertionPoints, @attributeOverrides.Value};
            var ___result = RMCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CloneSetupRecursively(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @root, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RInt32, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset>> @idToChildren, UnityEngine.UIElements.CreationContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root.Value, @idToChildren.Value, @context};
            var ___result = RMCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public static System.Int32 CompareForOrder(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @a, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a.Value, @b.Value};
            var ___result = RMCompareForOrder_VisualElementAsset_VisualElementAsset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean SlotDefinitionExists(System.String @slotName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotName};
            var ___result = RMSlotDefinitionExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AddSlotDefinition(System.String @slotName, System.Int32 @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotName, @resId};
            var ___result = RMAddSlotDefinition_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetSlotInsertionPoint(System.Int32 @insertionPointId, out System.String @slotName)
        {
			@slotName = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@insertionPointId, @slotName};
            var ___result = RMTryGetSlotInsertionPoint_Int32_Out_String.Invoke(___genericsType, ___parameters);
			@slotName = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String @templateName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName};
            var ___result = RMResolveTemplate_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualTreeAsset)___result;
        }


        public virtual System.Boolean TemplateExists(System.String @templateName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName};
            var ___result = RMTemplateExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterTemplate(System.String @templateName, System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName, @path};
            var ___result = RMRegisterTemplate_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterTemplate(System.String @templateName, UnityEngine.UIElements.VisualTreeAsset @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName, @asset};
            var ___result = RMRegisterTemplate_String_VisualTreeAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InsertUsingEntry(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry @entry)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entry.Value};
            var ___result = RMInsertUsingEntry_UsingEntry.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.VisualElement Create(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @asset, UnityEngine.UIElements.CreationContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset.Value, @ctx};
            var ___result = RMCreate_VisualElementAsset_CreationContext.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public static void AssignClassListFromAssetToElement(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @asset, UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset.Value, @element};
            var ___result = RMAssignClassListFromAssetToElement_VisualElementAsset_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public static void AssignStyleSheetFromAssetToElement(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @asset, UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset.Value, @element};
            var ___result = RMAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetAttributePropertiesDirtyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAttributePropertiesDirtyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ExtractUsedUxmlQualifiedNames(System.Collections.Generic.HashSet<System.String> @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RMExtractUsedUxmlQualifiedNames_HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.VisualElement __0__Create__1__g__CreateError__5__71_0(ref SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.R__0____1__c__DisplayClass71_0 @_______)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_______.Value};
            var ___result = RM__0__Create__1__g__CreateError__5__71_0_Ref___0____1__c__DisplayClass71_0.Invoke(___genericsType, ___parameters);
			@_______ = new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.R__0____1__c__DisplayClass71_0(___parameters[0]);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
