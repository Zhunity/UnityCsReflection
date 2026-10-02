
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.VisualTreeAsset
	/// </summary>
    public partial class RVisualTreeAsset : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.VisualTreeAsset);
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


		/// <summary>
		/// System.String LinkedVEAInTemplatePropertyName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FLinkedVEAInTemplatePropertyName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFLinkedVEAInTemplatePropertyName
		{
			get
			{
				if(r_FLinkedVEAInTemplatePropertyName == null)
				{
					r_FLinkedVEAInTemplatePropertyName = new(Type, "LinkedVEAInTemplatePropertyName");
				}
				return r_FLinkedVEAInTemplatePropertyName;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithErrors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ImportedWithErrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ImportedWithErrors
		{
			get
			{
				if(r_Fm_ImportedWithErrors == null)
				{
					r_Fm_ImportedWithErrors = new(this, "m_ImportedWithErrors");
				}
				return r_Fm_ImportedWithErrors;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithWarnings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ImportedWithWarnings;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ImportedWithWarnings
		{
			get
			{
				if(r_Fm_ImportedWithWarnings == null)
				{
					r_Fm_ImportedWithWarnings = new(this, "m_ImportedWithWarnings");
				}
				return r_Fm_ImportedWithWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] s_TemporarySlotInsertionPoints
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fs_TemporarySlotInsertionPoints;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFs_TemporarySlotInsertionPoints
		{
			get
			{
				if(r_Fs_TemporarySlotInsertionPoints == null)
				{
					r_Fs_TemporarySlotInsertionPoints = new(Type, "s_TemporarySlotInsertionPoints");
				}
				return r_Fs_TemporarySlotInsertionPoints;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+UsingEntry] m_Usings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> r_Fm_Usings;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> RFm_Usings
		{
			get
			{
				if(r_Fm_Usings == null)
				{
					r_Fm_Usings = new(this, "m_Usings");
				}
				return r_Fm_Usings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet inlineSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet r_FinlineSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet RFinlineSheet
		{
			get
			{
				if(r_FinlineSheet == null)
				{
					r_FinlineSheet = new(this, "inlineSheet");
				}
				return r_FinlineSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset] m_VisualElementAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> r_Fm_VisualElementAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> RFm_VisualElementAssets
		{
			get
			{
				if(r_Fm_VisualElementAssets == null)
				{
					r_Fm_VisualElementAssets = new(this, "m_VisualElementAssets");
				}
				return r_Fm_VisualElementAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset] m_TemplateAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> r_Fm_TemplateAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> RFm_TemplateAssets
		{
			get
			{
				if(r_Fm_TemplateAssets == null)
				{
					r_Fm_TemplateAssets = new(this, "m_TemplateAssets");
				}
				return r_Fm_TemplateAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotDefinition] m_Slots
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> r_Fm_Slots;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> RFm_Slots
		{
			get
			{
				if(r_Fm_Slots == null)
				{
					r_Fm_Slots = new(this, "m_Slots");
				}
				return r_Fm_Slots;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentContainerId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ContentContainerId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ContentContainerId
		{
			get
			{
				if(r_Fm_ContentContainerId == null)
				{
					r_Fm_ContentContainerId = new(this, "m_ContentContainerId");
				}
				return r_Fm_ContentContainerId;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ContentHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ContentHash
		{
			get
			{
				if(r_Fm_ContentHash == null)
				{
					r_Fm_ContentHash = new(this, "m_ContentHash");
				}
				return r_Fm_ContentHash;
			}
		}

		/// <summary>
		/// Boolean importedWithErrors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PimportedWithErrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPimportedWithErrors
		{
			get
			{
				if(r_PimportedWithErrors == null)
				{
					r_PimportedWithErrors = new(this, "importedWithErrors", -1);
				}
				return r_PimportedWithErrors;
			}
		}

		/// <summary>
		/// Boolean importedWithWarnings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PimportedWithWarnings;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPimportedWithWarnings
		{
			get
			{
				if(r_PimportedWithWarnings == null)
				{
					r_PimportedWithWarnings = new(this, "importedWithWarnings", -1);
				}
				return r_PimportedWithWarnings;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualTreeAsset] templateDependencies
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> r_PtemplateDependencies;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> RPtemplateDependencies
		{
			get
			{
				if(r_PtemplateDependencies == null)
				{
					r_PtemplateDependencies = new(this, "templateDependencies", -1);
				}
				return r_PtemplateDependencies;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StyleSheet] stylesheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_Pstylesheets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RPstylesheets
		{
			get
			{
				if(r_Pstylesheets == null)
				{
					r_Pstylesheets = new(this, "stylesheets", -1);
				}
				return r_Pstylesheets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElementAsset] visualElementAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> r_PvisualElementAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset> RPvisualElementAssets
		{
			get
			{
				if(r_PvisualElementAssets == null)
				{
					r_PvisualElementAssets = new(this, "visualElementAssets", -1);
				}
				return r_PvisualElementAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset] templateAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> r_PtemplateAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset> RPtemplateAssets
		{
			get
			{
				if(r_PtemplateAssets == null)
				{
					r_PtemplateAssets = new(this, "templateAssets", -1);
				}
				return r_PtemplateAssets;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotDefinition] slots
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> r_Pslots;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RSlotDefinition> RPslots
		{
			get
			{
				if(r_Pslots == null)
				{
					r_Pslots = new(this, "slots", -1);
				}
				return r_Pslots;
			}
		}

		/// <summary>
		/// Int32 contentContainerId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcontentContainerId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcontentContainerId
		{
			get
			{
				if(r_PcontentContainerId == null)
				{
					r_PcontentContainerId = new(this, "contentContainerId", -1);
				}
				return r_PcontentContainerId;
			}
		}

		/// <summary>
		/// Int32 contentHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcontentHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcontentHash
		{
			get
			{
				if(r_PcontentHash == null)
				{
					r_PcontentHash = new(this, "contentHash", -1);
				}
				return r_PcontentHash;
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
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
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
				}
				return r_MGetNextChildSerialNumber;
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
					r_MCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_ = new(this, "CloneTree", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2").MakeGenericType(typeof(System.String), typeof(UnityEngine.UIElements.VisualElement)),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.TemplateAsset+AttributeOverride")));
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
					r_MCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext = new(this, "CloneSetupRecursively", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"),  ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2").MakeGenericType(typeof(System.Int32),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"))), typeof(UnityEngine.UIElements.CreationContext));
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
					r_MCompareForOrder_VisualElementAsset_VisualElementAsset = new(Type, "CompareForOrder", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"));
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
					r_MCreate_VisualElementAsset_CreationContext = new(Type, "Create", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.CreationContext));
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
					r_MAssignClassListFromAssetToElement_VisualElementAsset_VisualElement = new(Type, "AssignClassListFromAssetToElement", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.VisualElement));
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
					r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement = new(Type, "AssignStyleSheetFromAssetToElement", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAsset"), typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement;
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
					r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_ = new(this, "ExtractUsedUxmlQualifiedNames", 0,  ReflectionUtils.GetType("System.Collections.Generic.HashSet`1").MakeGenericType(typeof(System.String)));
				}
				return r_MExtractUsedUxmlQualifiedNames_HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <Create>g__CreateError|55_0(<>c__DisplayClass55_0 ByRef)
		/// </summary>
		protected static RMethod r_M__0__Create__1__g__CreateError__5__55_0_Ref___0____1__c__DisplayClass55_0;
		public static RMethod RM__0__Create__1__g__CreateError__5__55_0_Ref___0____1__c__DisplayClass55_0
		{
			get
			{
				if(r_M__0__Create__1__g__CreateError__5__55_0_Ref___0____1__c__DisplayClass55_0 == null)
				{
					r_M__0__Create__1__g__CreateError__5__55_0_Ref___0____1__c__DisplayClass55_0 = new(Type, "<Create>g__CreateError|55_0", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+<>c__DisplayClass55_0").MakeByRefType());
				}
				return r_M__0__Create__1__g__CreateError__5__55_0_Ref___0____1__c__DisplayClass55_0;
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


		public virtual System.Int32 GetNextChildSerialNumber()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetNextChildSerialNumber.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Int32>(___result);
		}


		public virtual UnityEngine.UIElements.TemplateContainer Instantiate()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMInstantiate.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.TemplateContainer>(___result);
		}


		public virtual UnityEngine.UIElements.TemplateContainer Instantiate(System.String @bindingPath)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@bindingPath};
			var ___result = RMInstantiate_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.TemplateContainer>(___result);
		}


		public virtual UnityEngine.UIElements.TemplateContainer CloneTree()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMCloneTree.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.TemplateContainer>(___result);
		}


		public virtual UnityEngine.UIElements.TemplateContainer CloneTree(System.String @bindingPath)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@bindingPath};
			var ___result = RMCloneTree_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.TemplateContainer>(___result);
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
			@firstElementIndex = ReflectionUtils.Convert<System.Int32>(___parameters[1]);
			@elementAddedCount = ReflectionUtils.Convert<System.Int32>(___parameters[2]);
		}


		public virtual void CloneTree(UnityEngine.UIElements.VisualElement @target, System.Collections.Generic.Dictionary<System.String, UnityEngine.UIElements.VisualElement> @slotInsertionPoints, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> @attributeOverrides)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@target, @slotInsertionPoints, @attributeOverrides.Value};
			var ___result = RMCloneTree_VisualElement_Dictionary_d_String_VisualElement_p__List_d_AttributeOverride_p_.Invoke(___genericsType, ___parameters);
		}


		public virtual UnityEngine.UIElements.VisualElement CloneSetupRecursively(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @root, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset>> @idToChildren, UnityEngine.UIElements.CreationContext @context)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@root.Value, @idToChildren.Value, @context};
			var ___result = RMCloneSetupRecursively_VisualElementAsset_Dictionary_d_Int32_List_d_VisualElementAsset_p__p__CreationContext.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
		}


		public static System.Int32 CompareForOrder(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @a, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @b)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@a.Value, @b.Value};
			var ___result = RMCompareForOrder_VisualElementAsset_VisualElementAsset.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Int32>(___result);
		}


		public virtual System.Boolean SlotDefinitionExists(System.String @slotName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@slotName};
			var ___result = RMSlotDefinitionExists_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Boolean AddSlotDefinition(System.String @slotName, System.Int32 @resId)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@slotName, @resId};
			var ___result = RMAddSlotDefinition_String_Int32.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.Boolean TryGetSlotInsertionPoint(System.Int32 @insertionPointId, out System.String @slotName)
		{
			@slotName = default;
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@insertionPointId, @slotName};
			var ___result = RMTryGetSlotInsertionPoint_Int32_Out_String.Invoke(___genericsType, ___parameters);
			@slotName = ReflectionUtils.Convert<System.String>(___parameters[1]);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String @templateName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@templateName};
			var ___result = RMResolveTemplate_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.VisualTreeAsset>(___result);
		}


		public virtual System.Boolean TemplateExists(System.String @templateName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@templateName};
			var ___result = RMTemplateExists_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
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


		public virtual void InsertUsingEntry(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry @entry)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@entry.Value};
			var ___result = RMInsertUsingEntry_UsingEntry.Invoke(___genericsType, ___parameters);
		}


		public static UnityEngine.UIElements.VisualElement Create(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @asset, UnityEngine.UIElements.CreationContext @ctx)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@asset.Value, @ctx};
			var ___result = RMCreate_VisualElementAsset_CreationContext.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
		}


		public static void AssignClassListFromAssetToElement(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @asset, UnityEngine.UIElements.VisualElement @element)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@asset.Value, @element};
			var ___result = RMAssignClassListFromAssetToElement_VisualElementAsset_VisualElement.Invoke(___genericsType, ___parameters);
		}


		public static void AssignStyleSheetFromAssetToElement(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAsset @asset, UnityEngine.UIElements.VisualElement @element)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@asset.Value, @element};
			var ___result = RMAssignStyleSheetFromAssetToElement_VisualElementAsset_VisualElement.Invoke(___genericsType, ___parameters);
		}


		public virtual void ExtractUsedUxmlQualifiedNames(System.Collections.Generic.HashSet<System.String> @names)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@names};
			var ___result = RMExtractUsedUxmlQualifiedNames_HashSet_d_String_p_.Invoke(___genericsType, ___parameters);
		}


		public static UnityEngine.UIElements.VisualElement __0__Create__1__g__CreateError__5__55_0(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.R__0____1__c__DisplayClass55_0 @_______)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@_______.Value};
			var ___result = RM__0__Create__1__g__CreateError__5__55_0_Ref___0____1__c__DisplayClass55_0.Invoke(___genericsType, ___parameters);
			@_______ = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.R__0____1__c__DisplayClass55_0>(___parameters[0]);
			return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
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
			return ReflectionUtils.Convert<System.Int32>(___result);
		}


		public virtual System.Int32 GetHashCode()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Int32>(___result);
		}


		public virtual System.Boolean Equals(System.Object @other)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@other};
			var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
		}


		public virtual System.String ToString()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMToString.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
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
