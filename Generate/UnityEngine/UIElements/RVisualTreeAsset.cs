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
		protected static RField r_LinkedVEAInTemplatePropertyName;
		public static RField RLinkedVEAInTemplatePropertyName
		{
			get
			{
				if(r_LinkedVEAInTemplatePropertyName == null)
				{
					r_LinkedVEAInTemplatePropertyName = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "LinkedVEAInTemplatePropertyName");
					r_LinkedVEAInTemplatePropertyName.SetBelong(null);
				}
				return r_LinkedVEAInTemplatePropertyName;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithErrors
		/// </summary>
		protected RField r_m_ImportedWithErrors;
		public virtual RField Rm_ImportedWithErrors
		{
			get
			{
				if(r_m_ImportedWithErrors == null)
				{
					r_m_ImportedWithErrors = new(this, "m_ImportedWithErrors");
					r_m_ImportedWithErrors.SetBelong(this.instance);
				}
				return r_m_ImportedWithErrors;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithWarnings
		/// </summary>
		protected RField r_m_ImportedWithWarnings;
		public virtual RField Rm_ImportedWithWarnings
		{
			get
			{
				if(r_m_ImportedWithWarnings == null)
				{
					r_m_ImportedWithWarnings = new(this, "m_ImportedWithWarnings");
					r_m_ImportedWithWarnings.SetBelong(this.instance);
				}
				return r_m_ImportedWithWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] s_TemporarySlotInsertionPoints
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RVisualElement> r_s_TemporarySlotInsertionPoints;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RVisualElement> Rs_TemporarySlotInsertionPoints
		{
			get
			{
				if(r_s_TemporarySlotInsertionPoints == null)
				{
					r_s_TemporarySlotInsertionPoints = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "s_TemporarySlotInsertionPoints");
					r_s_TemporarySlotInsertionPoints.SetBelong(null);
				}
				return r_s_TemporarySlotInsertionPoints;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UsingEntry] m_Usings
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> r_m_Usings;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> Rm_Usings
		{
			get
			{
				if(r_m_Usings == null)
				{
					r_m_Usings = new(this, "m_Usings");
					r_m_Usings.SetBelong(this.instance);
				}
				return r_m_Usings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet inlineSheet
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheet r_inlineSheet;
		public virtual RUnityEngine.RUIElements.RStyleSheet RinlineSheet
		{
			get
			{
				if(r_inlineSheet == null)
				{
					r_inlineSheet = new(this, "inlineSheet");
					r_inlineSheet.SetBelong(this.instance);
				}
				return r_inlineSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset] m_VisualElementAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElementAsset> r_m_VisualElementAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElementAsset> Rm_VisualElementAssets
		{
			get
			{
				if(r_m_VisualElementAssets == null)
				{
					r_m_VisualElementAssets = new(this, "m_VisualElementAssets");
					r_m_VisualElementAssets.SetBelong(this.instance);
				}
				return r_m_VisualElementAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset] m_TemplateAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset> r_m_TemplateAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset> Rm_TemplateAssets
		{
			get
			{
				if(r_m_TemplateAssets == null)
				{
					r_m_TemplateAssets = new(this, "m_TemplateAssets");
					r_m_TemplateAssets.SetBelong(this.instance);
				}
				return r_m_TemplateAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry] m_UxmlObjectEntries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> r_m_UxmlObjectEntries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> Rm_UxmlObjectEntries
		{
			get
			{
				if(r_m_UxmlObjectEntries == null)
				{
					r_m_UxmlObjectEntries = new(this, "m_UxmlObjectEntries");
					r_m_UxmlObjectEntries.SetBelong(this.instance);
				}
				return r_m_UxmlObjectEntries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_UxmlObjectIds
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_UxmlObjectIds;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_UxmlObjectIds
		{
			get
			{
				if(r_m_UxmlObjectIds == null)
				{
					r_m_UxmlObjectIds = new(this, "m_UxmlObjectIds");
					r_m_UxmlObjectIds.SetBelong(this.instance);
				}
				return r_m_UxmlObjectIds;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+AssetEntry] m_AssetEntries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RAssetEntry> r_m_AssetEntries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RAssetEntry> Rm_AssetEntries
		{
			get
			{
				if(r_m_AssetEntries == null)
				{
					r_m_AssetEntries = new(this, "m_AssetEntries");
					r_m_AssetEntries.SetBelong(this.instance);
				}
				return r_m_AssetEntries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotDefinition] m_Slots
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> r_m_Slots;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> Rm_Slots
		{
			get
			{
				if(r_m_Slots == null)
				{
					r_m_Slots = new(this, "m_Slots");
					r_m_Slots.SetBelong(this.instance);
				}
				return r_m_Slots;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentContainerId
		/// </summary>
		protected RField r_m_ContentContainerId;
		public virtual RField Rm_ContentContainerId
		{
			get
			{
				if(r_m_ContentContainerId == null)
				{
					r_m_ContentContainerId = new(this, "m_ContentContainerId");
					r_m_ContentContainerId.SetBelong(this.instance);
				}
				return r_m_ContentContainerId;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentHash
		/// </summary>
		protected RField r_m_ContentHash;
		public virtual RField Rm_ContentHash
		{
			get
			{
				if(r_m_ContentHash == null)
				{
					r_m_ContentHash = new(this, "m_ContentHash");
					r_m_ContentHash.SetBelong(this.instance);
				}
				return r_m_ContentHash;
			}
		}

		/// <summary>
		/// Boolean importedWithErrors
		/// </summary>
		protected RProperty r_importedWithErrors;
		public virtual RProperty RimportedWithErrors
		{
			get
			{
				if(r_importedWithErrors == null)
				{
					r_importedWithErrors = new(this, "importedWithErrors", -1);
					r_importedWithErrors.SetBelong(this.instance);
				}
				return r_importedWithErrors;
			}
		}

		/// <summary>
		/// Boolean importedWithWarnings
		/// </summary>
		protected RProperty r_importedWithWarnings;
		public virtual RProperty RimportedWithWarnings
		{
			get
			{
				if(r_importedWithWarnings == null)
				{
					r_importedWithWarnings = new(this, "importedWithWarnings", -1);
					r_importedWithWarnings.SetBelong(this.instance);
				}
				return r_importedWithWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualTreeAsset] templateDependencies
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RVisualTreeAsset> r_templateDependencies;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RVisualTreeAsset> RtemplateDependencies
		{
			get
			{
				if(r_templateDependencies == null)
				{
					r_templateDependencies = new(this, "templateDependencies", -1);
					r_templateDependencies.SetBelong(this.instance);
				}
				return r_templateDependencies;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StyleSheet] stylesheets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStyleSheet> r_stylesheets;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStyleSheet> Rstylesheets
		{
			get
			{
				if(r_stylesheets == null)
				{
					r_stylesheets = new(this, "stylesheets", -1);
					r_stylesheets.SetBelong(this.instance);
				}
				return r_stylesheets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset] visualElementAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElementAsset> r_visualElementAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElementAsset> RvisualElementAssets
		{
			get
			{
				if(r_visualElementAssets == null)
				{
					r_visualElementAssets = new(this, "visualElementAssets", -1);
					r_visualElementAssets.SetBelong(this.instance);
				}
				return r_visualElementAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset] templateAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset> r_templateAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset> RtemplateAssets
		{
			get
			{
				if(r_templateAssets == null)
				{
					r_templateAssets = new(this, "templateAssets", -1);
					r_templateAssets.SetBelong(this.instance);
				}
				return r_templateAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UxmlObjectEntry] uxmlObjectEntries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> r_uxmlObjectEntries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RUxmlObjectEntry> RuxmlObjectEntries
		{
			get
			{
				if(r_uxmlObjectEntries == null)
				{
					r_uxmlObjectEntries = new(this, "uxmlObjectEntries", -1);
					r_uxmlObjectEntries.SetBelong(this.instance);
				}
				return r_uxmlObjectEntries;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] uxmlObjectIds
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_uxmlObjectIds;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RuxmlObjectIds
		{
			get
			{
				if(r_uxmlObjectIds == null)
				{
					r_uxmlObjectIds = new(this, "uxmlObjectIds", -1);
					r_uxmlObjectIds.SetBelong(this.instance);
				}
				return r_uxmlObjectIds;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotDefinition] slots
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> r_slots;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> Rslots
		{
			get
			{
				if(r_slots == null)
				{
					r_slots = new(this, "slots", -1);
					r_slots.SetBelong(this.instance);
				}
				return r_slots;
			}
		}

		/// <summary>
		/// Int32 contentContainerId
		/// </summary>
		protected RProperty r_contentContainerId;
		public virtual RProperty RcontentContainerId
		{
			get
			{
				if(r_contentContainerId == null)
				{
					r_contentContainerId = new(this, "contentContainerId", -1);
					r_contentContainerId.SetBelong(this.instance);
				}
				return r_contentContainerId;
			}
		}

		/// <summary>
		/// Int32 contentHash
		/// </summary>
		protected RProperty r_contentHash;
		public virtual RProperty RcontentHash
		{
			get
			{
				if(r_contentHash == null)
				{
					r_contentHash = new(this, "contentHash", -1);
					r_contentHash.SetBelong(this.instance);
				}
				return r_contentHash;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Int32 GetNextChildSerialNumber()
		/// </summary>
		protected RMethod r_RGetNextChildSerialNumber;
		public virtual RMethod RGetNextChildSerialNumber
		{
			get
			{
				if(r_RGetNextChildSerialNumber == null)
				{
					r_RGetNextChildSerialNumber = new(this, "GetNextChildSerialNumber", 0);
					r_RGetNextChildSerialNumber.SetBelong(this.instance);
				}
				return r_RGetNextChildSerialNumber;
			}
		}

		/// <summary>
		/// Void RegisterUxmlObject(UnityEngine.UIElements.UxmlObjectAsset)
		/// </summary>
		protected RMethod r_RRegisterUxmlObject_UxmlObjectAsset;
		public virtual RMethod RRegisterUxmlObject_UxmlObjectAsset
		{
			get
			{
				if(r_RRegisterUxmlObject_UxmlObjectAsset == null)
				{
					r_RRegisterUxmlObject_UxmlObjectAsset = new(this, "RegisterUxmlObject", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UxmlObjectAsset"));
					r_RRegisterUxmlObject_UxmlObjectAsset.SetBelong(this.instance);
				}
				return r_RRegisterUxmlObject_UxmlObjectAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[T] GetUxmlObjects[T](UnityEngine.UIElements.IUxmlAttributes, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected RMethod r_RGetUxmlObjects_GT_IUxmlAttributes_CreationContext;
		public virtual RMethod RGetUxmlObjects_GT_IUxmlAttributes_CreationContext
		{
			get
			{
				if(r_RGetUxmlObjects_GT_IUxmlAttributes_CreationContext == null)
				{
					r_RGetUxmlObjects_GT_IUxmlAttributes_CreationContext = new(this, "GetUxmlObjects", 1, typeof(UnityEngine.UIElements.IUxmlAttributes), typeof(UnityEngine.UIElements.CreationContext));
					r_RGetUxmlObjects_GT_IUxmlAttributes_CreationContext.SetBelong(this.instance);
				}
				return r_RGetUxmlObjects_GT_IUxmlAttributes_CreationContext;
			}
		}

		/// <summary>
		/// Boolean AssetEntryExists(System.String, System.Type)
		/// </summary>
		protected RMethod r_RAssetEntryExists_String_Type;
		public virtual RMethod RAssetEntryExists_String_Type
		{
			get
			{
				if(r_RAssetEntryExists_String_Type == null)
				{
					r_RAssetEntryExists_String_Type = new(this, "AssetEntryExists", 0, typeof(System.String), typeof(System.Type));
					r_RAssetEntryExists_String_Type.SetBelong(this.instance);
				}
				return r_RAssetEntryExists_String_Type;
			}
		}

		/// <summary>
		/// Void RegisterAssetEntry(System.String, System.Type, UnityEngine.Object)
		/// </summary>
		protected RMethod r_RRegisterAssetEntry_String_Type_Object;
		public virtual RMethod RRegisterAssetEntry_String_Type_Object
		{
			get
			{
				if(r_RRegisterAssetEntry_String_Type_Object == null)
				{
					r_RRegisterAssetEntry_String_Type_Object = new(this, "RegisterAssetEntry", 0, typeof(System.String), typeof(System.Type), typeof(UnityEngine.Object));
					r_RRegisterAssetEntry_String_Type_Object.SetBelong(this.instance);
				}
				return r_RRegisterAssetEntry_String_Type_Object;
			}
		}

		/// <summary>
		/// T GetAsset[T](System.String)
		/// </summary>
		protected RMethod r_RGetAsset_GT_String;
		public virtual RMethod RGetAsset_GT_String
		{
			get
			{
				if(r_RGetAsset_GT_String == null)
				{
					r_RGetAsset_GT_String = new(this, "GetAsset", 1, typeof(System.String));
					r_RGetAsset_GT_String.SetBelong(this.instance);
				}
				return r_RGetAsset_GT_String;
			}
		}

		/// <summary>
		/// UxmlObjectEntry GetUxmlObjectEntry(Int32)
		/// </summary>
		protected RMethod r_RGetUxmlObjectEntry_Int32;
		public virtual RMethod RGetUxmlObjectEntry_Int32
		{
			get
			{
				if(r_RGetUxmlObjectEntry_Int32 == null)
				{
					r_RGetUxmlObjectEntry_Int32 = new(this, "GetUxmlObjectEntry", 0, typeof(System.Int32));
					r_RGetUxmlObjectEntry_Int32.SetBelong(this.instance);
				}
				return r_RGetUxmlObjectEntry_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IBaseUxmlObjectFactory GetUxmlObjectFactory(UnityEngine.UIElements.UxmlObjectAsset)
		/// </summary>
		protected RMethod r_RGetUxmlObjectFactory_UxmlObjectAsset;
		public virtual RMethod RGetUxmlObjectFactory_UxmlObjectAsset
		{
			get
			{
				if(r_RGetUxmlObjectFactory_UxmlObjectAsset == null)
				{
					r_RGetUxmlObjectFactory_UxmlObjectAsset = new(this, "GetUxmlObjectFactory", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UxmlObjectAsset"));
					r_RGetUxmlObjectFactory_UxmlObjectAsset.SetBelong(this.instance);
				}
				return r_RGetUxmlObjectFactory_UxmlObjectAsset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer Instantiate()
		/// </summary>
		protected RMethod r_RInstantiate;
		public virtual RMethod RInstantiate
		{
			get
			{
				if(r_RInstantiate == null)
				{
					r_RInstantiate = new(this, "Instantiate", 0);
					r_RInstantiate.SetBelong(this.instance);
				}
				return r_RInstantiate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer Instantiate(System.String)
		/// </summary>
		protected RMethod r_RInstantiate_String;
		public virtual RMethod RInstantiate_String
		{
			get
			{
				if(r_RInstantiate_String == null)
				{
					r_RInstantiate_String = new(this, "Instantiate", 0, typeof(System.String));
					r_RInstantiate_String.SetBelong(this.instance);
				}
				return r_RInstantiate_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer CloneTree()
		/// </summary>
		protected RMethod r_RCloneTree;
		public virtual RMethod RCloneTree
		{
			get
			{
				if(r_RCloneTree == null)
				{
					r_RCloneTree = new(this, "CloneTree", 0);
					r_RCloneTree.SetBelong(this.instance);
				}
				return r_RCloneTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TemplateContainer CloneTree(System.String)
		/// </summary>
		protected RMethod r_RCloneTree_String;
		public virtual RMethod RCloneTree_String
		{
			get
			{
				if(r_RCloneTree_String == null)
				{
					r_RCloneTree_String = new(this, "CloneTree", 0, typeof(System.String));
					r_RCloneTree_String.SetBelong(this.instance);
				}
				return r_RCloneTree_String;
			}
		}

		/// <summary>
		/// Void CloneTree(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RCloneTree_VisualElement;
		public virtual RMethod RCloneTree_VisualElement
		{
			get
			{
				if(r_RCloneTree_VisualElement == null)
				{
					r_RCloneTree_VisualElement = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RCloneTree_VisualElement.SetBelong(this.instance);
				}
				return r_RCloneTree_VisualElement;
			}
		}

		/// <summary>
		/// Void CloneTree(UnityEngine.UIElements.VisualElement, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RCloneTree_VisualElement_Out_Int32_Out_Int32;
		public virtual RMethod RCloneTree_VisualElement_Out_Int32_Out_Int32
		{
			get
			{
				if(r_RCloneTree_VisualElement_Out_Int32_Out_Int32 == null)
				{
					r_RCloneTree_VisualElement_Out_Int32_Out_Int32 = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RCloneTree_VisualElement_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RCloneTree_VisualElement_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void CloneTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement], System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride])
		/// </summary>
		protected RMethod r_RCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_;
		public virtual RMethod RCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_
		{
			get
			{
				if(r_RCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_ == null)
				{
					r_RCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_ = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String), typeof(UnityEngine.UIElements.VisualElement)), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.TemplateAsset+AttributeOverride")));
					r_RCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_.SetBelong(this.instance);
				}
				return r_RCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset, System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset]], UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected RMethod r_RCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext;
		public virtual RMethod RCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext
		{
			get
			{
				if(r_RCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext == null)
				{
					r_RCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext = new(this, "CloneSetupRecursively", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"))), typeof(UnityEngine.UIElements.CreationContext));
					r_RCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext.SetBelong(this.instance);
				}
				return r_RCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext;
			}
		}

		/// <summary>
		/// Int32 CompareForOrder(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.VisualElementAsset)
		/// </summary>
		protected static RMethod r_RCompareForOrder_VisualElementAsset_VisualElementAsset;
		public static RMethod RCompareForOrder_VisualElementAsset_VisualElementAsset
		{
			get
			{
				if(r_RCompareForOrder_VisualElementAsset_VisualElementAsset == null)
				{
					r_RCompareForOrder_VisualElementAsset_VisualElementAsset = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "CompareForOrder", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"));
					r_RCompareForOrder_VisualElementAsset_VisualElementAsset.SetBelong(null);
				}
				return r_RCompareForOrder_VisualElementAsset_VisualElementAsset;
			}
		}

		/// <summary>
		/// Boolean SlotDefinitionExists(System.String)
		/// </summary>
		protected RMethod r_RSlotDefinitionExists_String;
		public virtual RMethod RSlotDefinitionExists_String
		{
			get
			{
				if(r_RSlotDefinitionExists_String == null)
				{
					r_RSlotDefinitionExists_String = new(this, "SlotDefinitionExists", 0, typeof(System.String));
					r_RSlotDefinitionExists_String.SetBelong(this.instance);
				}
				return r_RSlotDefinitionExists_String;
			}
		}

		/// <summary>
		/// Boolean AddSlotDefinition(System.String, Int32)
		/// </summary>
		protected RMethod r_RAddSlotDefinition_String_Int32;
		public virtual RMethod RAddSlotDefinition_String_Int32
		{
			get
			{
				if(r_RAddSlotDefinition_String_Int32 == null)
				{
					r_RAddSlotDefinition_String_Int32 = new(this, "AddSlotDefinition", 0, typeof(System.String), typeof(System.Int32));
					r_RAddSlotDefinition_String_Int32.SetBelong(this.instance);
				}
				return r_RAddSlotDefinition_String_Int32;
			}
		}

		/// <summary>
		/// Boolean TryGetSlotInsertionPoint(Int32, System.String ByRef)
		/// </summary>
		protected RMethod r_RTryGetSlotInsertionPoint_Int32_Out_String;
		public virtual RMethod RTryGetSlotInsertionPoint_Int32_Out_String
		{
			get
			{
				if(r_RTryGetSlotInsertionPoint_Int32_Out_String == null)
				{
					r_RTryGetSlotInsertionPoint_Int32_Out_String = new(this, "TryGetSlotInsertionPoint", 0, typeof(System.Int32), typeof(System.String).MakeByRefType());
					r_RTryGetSlotInsertionPoint_Int32_Out_String.SetBelong(this.instance);
				}
				return r_RTryGetSlotInsertionPoint_Int32_Out_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String)
		/// </summary>
		protected RMethod r_RResolveTemplate_String;
		public virtual RMethod RResolveTemplate_String
		{
			get
			{
				if(r_RResolveTemplate_String == null)
				{
					r_RResolveTemplate_String = new(this, "ResolveTemplate", 0, typeof(System.String));
					r_RResolveTemplate_String.SetBelong(this.instance);
				}
				return r_RResolveTemplate_String;
			}
		}

		/// <summary>
		/// Boolean TemplateExists(System.String)
		/// </summary>
		protected RMethod r_RTemplateExists_String;
		public virtual RMethod RTemplateExists_String
		{
			get
			{
				if(r_RTemplateExists_String == null)
				{
					r_RTemplateExists_String = new(this, "TemplateExists", 0, typeof(System.String));
					r_RTemplateExists_String.SetBelong(this.instance);
				}
				return r_RTemplateExists_String;
			}
		}

		/// <summary>
		/// Void RegisterTemplate(System.String, System.String)
		/// </summary>
		protected RMethod r_RRegisterTemplate_String_String;
		public virtual RMethod RRegisterTemplate_String_String
		{
			get
			{
				if(r_RRegisterTemplate_String_String == null)
				{
					r_RRegisterTemplate_String_String = new(this, "RegisterTemplate", 0, typeof(System.String), typeof(System.String));
					r_RRegisterTemplate_String_String.SetBelong(this.instance);
				}
				return r_RRegisterTemplate_String_String;
			}
		}

		/// <summary>
		/// Void RegisterTemplate(System.String, UnityEngine.UIElements.VisualTreeAsset)
		/// </summary>
		protected RMethod r_RRegisterTemplate_String_VisualTreeAsset;
		public virtual RMethod RRegisterTemplate_String_VisualTreeAsset
		{
			get
			{
				if(r_RRegisterTemplate_String_VisualTreeAsset == null)
				{
					r_RRegisterTemplate_String_VisualTreeAsset = new(this, "RegisterTemplate", 0, typeof(System.String), typeof(UnityEngine.UIElements.VisualTreeAsset));
					r_RRegisterTemplate_String_VisualTreeAsset.SetBelong(this.instance);
				}
				return r_RRegisterTemplate_String_VisualTreeAsset;
			}
		}

		/// <summary>
		/// Void InsertUsingEntry(UsingEntry)
		/// </summary>
		protected RMethod r_RInsertUsingEntry_UsingEntry;
		public virtual RMethod RInsertUsingEntry_UsingEntry
		{
			get
			{
				if(r_RInsertUsingEntry_UsingEntry == null)
				{
					r_RInsertUsingEntry_UsingEntry = new(this, "InsertUsingEntry", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+UsingEntry"));
					r_RInsertUsingEntry_UsingEntry.SetBelong(this.instance);
				}
				return r_RInsertUsingEntry_UsingEntry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected static RMethod r_RCreate_VisualElementAsset_CreationContext;
		public static RMethod RCreate_VisualElementAsset_CreationContext
		{
			get
			{
				if(r_RCreate_VisualElementAsset_CreationContext == null)
				{
					r_RCreate_VisualElementAsset_CreationContext = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "Create", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.CreationContext));
					r_RCreate_VisualElementAsset_CreationContext.SetBelong(null);
				}
				return r_RCreate_VisualElementAsset_CreationContext;
			}
		}

		/// <summary>
		/// Void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_RAssignClassListFromAssetToElement_VisualElementAsset_VisualElement;
		public static RMethod RAssignClassListFromAssetToElement_VisualElementAsset_VisualElement
		{
			get
			{
				if(r_RAssignClassListFromAssetToElement_VisualElementAsset_VisualElement == null)
				{
					r_RAssignClassListFromAssetToElement_VisualElementAsset_VisualElement = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "AssignClassListFromAssetToElement", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.VisualElement));
					r_RAssignClassListFromAssetToElement_VisualElementAsset_VisualElement.SetBelong(null);
				}
				return r_RAssignClassListFromAssetToElement_VisualElementAsset_VisualElement;
			}
		}

		/// <summary>
		/// Void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected static RMethod r_RAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement;
		public static RMethod RAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement
		{
			get
			{
				if(r_RAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement == null)
				{
					r_RAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "AssignStyleSheetFromAssetToElement", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.VisualElement));
					r_RAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement.SetBelong(null);
				}
				return r_RAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement;
			}
		}

		/// <summary>
		/// Int32 GetAttributePropertiesDirtyCount()
		/// </summary>
		protected RMethod r_RGetAttributePropertiesDirtyCount;
		public virtual RMethod RGetAttributePropertiesDirtyCount
		{
			get
			{
				if(r_RGetAttributePropertiesDirtyCount == null)
				{
					r_RGetAttributePropertiesDirtyCount = new(this, "GetAttributePropertiesDirtyCount", 0);
					r_RGetAttributePropertiesDirtyCount.SetBelong(this.instance);
				}
				return r_RGetAttributePropertiesDirtyCount;
			}
		}

		/// <summary>
		/// Void ExtractUsedUxmlQualifiedNames(System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_;
		public virtual RMethod RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_
		{
			get
			{
				if(r_RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_ == null)
				{
					r_RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_ = new(this, "ExtractUsedUxmlQualifiedNames", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
					r_RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_.SetBelong(this.instance);
				}
				return r_RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <Create>g__CreateError|71_0(<>c__DisplayClass71_0 ByRef)
		/// </summary>
		protected static RMethod r_R__1__Create__2__g__CreateError__3__71_0_Ref___1____2__c__DisplayClass71_0;
		public static RMethod R__1__Create__2__g__CreateError__3__71_0_Ref___1____2__c__DisplayClass71_0
		{
			get
			{
				if(r_R__1__Create__2__g__CreateError__3__71_0_Ref___1____2__c__DisplayClass71_0 == null)
				{
					r_R__1__Create__2__g__CreateError__3__71_0_Ref___1____2__c__DisplayClass71_0 = new(typeof(UnityEngine.UIElements.VisualTreeAsset), "<Create>g__CreateError|71_0", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+<>c__DisplayClass71_0").MakeByRefType());
					r_R__1__Create__2__g__CreateError__3__71_0_Ref___1____2__c__DisplayClass71_0.SetBelong(null);
				}
				return r_R__1__Create__2__g__CreateError__3__71_0_Ref___1____2__c__DisplayClass71_0;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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
            var ___result = RGetNextChildSerialNumber.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Collections.Generic.List<T> GetUxmlObjects<T>(UnityEngine.UIElements.IUxmlAttributes  @asset, UnityEngine.UIElements.CreationContext  @cc) where T : new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@asset, @cc};
            var ___result = RGetUxmlObjects_GT_IUxmlAttributes_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<T>)___result;
        }


        public virtual System.Boolean AssetEntryExists(System.String  @path, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @type};
            var ___result = RAssetEntryExists_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterAssetEntry(System.String  @path, System.Type  @type, UnityEngine.Object  @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @type, @asset};
            var ___result = RRegisterAssetEntry_String_Type_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetAsset<T>(System.String  @path) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@path};
            var ___result = RGetAsset_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Object GetUxmlObjectEntry(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetUxmlObjectEntry_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual UnityEngine.UIElements.TemplateContainer Instantiate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInstantiate.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual UnityEngine.UIElements.TemplateContainer Instantiate(System.String  @bindingPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingPath};
            var ___result = RInstantiate_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual UnityEngine.UIElements.TemplateContainer CloneTree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloneTree.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual UnityEngine.UIElements.TemplateContainer CloneTree(System.String  @bindingPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingPath};
            var ___result = RCloneTree_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TemplateContainer)___result;
        }


        public virtual void CloneTree(UnityEngine.UIElements.VisualElement  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RCloneTree_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloneTree(UnityEngine.UIElements.VisualElement  @target, out System.Int32  @firstElementIndex, out System.Int32  @elementAddedCount)
        {
			firstElementIndex = default;
			elementAddedCount = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @firstElementIndex, @elementAddedCount};
            var ___result = RCloneTree_VisualElement_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			firstElementIndex = (System.Int32)___parameters[1];
			elementAddedCount = (System.Int32)___parameters[2];

            
        }





        public virtual System.Boolean SlotDefinitionExists(System.String  @slotName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotName};
            var ___result = RSlotDefinitionExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AddSlotDefinition(System.String  @slotName, System.Int32  @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotName, @resId};
            var ___result = RAddSlotDefinition_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetSlotInsertionPoint(System.Int32  @insertionPointId, out System.String  @slotName)
        {
			slotName = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@insertionPointId, @slotName};
            var ___result = RTryGetSlotInsertionPoint_Int32_Out_String.Invoke(___genericsType, ___parameters);
			slotName = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String  @templateName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName};
            var ___result = RResolveTemplate_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualTreeAsset)___result;
        }


        public virtual System.Boolean TemplateExists(System.String  @templateName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName};
            var ___result = RTemplateExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterTemplate(System.String  @templateName, System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName, @path};
            var ___result = RRegisterTemplate_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterTemplate(System.String  @templateName, UnityEngine.UIElements.VisualTreeAsset  @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@templateName, @asset};
            var ___result = RRegisterTemplate_String_VisualTreeAsset.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.Int32 GetAttributePropertiesDirtyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttributePropertiesDirtyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ExtractUsedUxmlQualifiedNames(System.Collections.Generic.HashSet<System.String>  @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RExtractUsedUxmlQualifiedNames_HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}