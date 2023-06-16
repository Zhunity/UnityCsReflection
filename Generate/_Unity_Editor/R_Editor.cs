
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.Editor
	/// </summary>
    public partial class REditor : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.Editor);
            }
        }

        public REditor() : base("UnityEditor.Editor")
        {
        }

        public REditor(System.Object instance) : base("UnityEditor.Editor")
		{
            SetInstance(instance);
		}

        public REditor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REditor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[UnityEditor.Editor] finishedDefaultHeaderGUI
		/// </summary>
		protected static REvent r_EfinishedDefaultHeaderGUI;
		public static REvent REfinishedDefaultHeaderGUI
		{
			get
			{
				if(r_EfinishedDefaultHeaderGUI == null)
				{
					r_EfinishedDefaultHeaderGUI = new(Type, "finishedDefaultHeaderGUI");
				}
				return r_EfinishedDefaultHeaderGUI;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] m_Targets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Fm_Targets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> RFm_Targets
		{
			get
			{
				if(r_Fm_Targets == null)
				{
					r_Fm_Targets = new(this, "m_Targets");
				}
				return r_Fm_Targets;
			}
		}

		/// <summary>
		/// UnityEngine.Object m_Context
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Fm_Context;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RFm_Context
		{
			get
			{
				if(r_Fm_Context == null)
				{
					r_Fm_Context = new(this, "m_Context");
				}
				return r_Fm_Context;
			}
		}

		/// <summary>
		/// System.Int32 m_IsDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_IsDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_IsDirty
		{
			get
			{
				if(r_Fm_IsDirty == null)
				{
					r_Fm_IsDirty = new(this, "m_IsDirty");
				}
				return r_Fm_IsDirty;
			}
		}

		/// <summary>
		/// System.Int32 m_ReferenceTargetIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ReferenceTargetIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ReferenceTargetIndex
		{
			get
			{
				if(r_Fm_ReferenceTargetIndex == null)
				{
					r_Fm_ReferenceTargetIndex = new(this, "m_ReferenceTargetIndex");
				}
				return r_Fm_ReferenceTargetIndex;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyHandlerCache m_PropertyHandlerCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandlerCache r_Fm_PropertyHandlerCache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandlerCache RFm_PropertyHandlerCache
		{
			get
			{
				if(r_Fm_PropertyHandlerCache == null)
				{
					r_Fm_PropertyHandlerCache = new(this, "m_PropertyHandlerCache");
				}
				return r_Fm_PropertyHandlerCache;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable m_DummyPreview
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable r_Fm_DummyPreview;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable RFm_DummyPreview
		{
			get
			{
				if(r_Fm_DummyPreview == null)
				{
					r_Fm_DummyPreview = new(this, "m_DummyPreview");
				}
				return r_Fm_DummyPreview;
			}
		}

		/// <summary>
		/// UnityEditor.AudioFilterGUI m_AudioFilterGUI
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RAudioFilterGUI r_Fm_AudioFilterGUI;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RAudioFilterGUI RFm_AudioFilterGUI
		{
			get
			{
				if(r_Fm_AudioFilterGUI == null)
				{
					r_Fm_AudioFilterGUI = new(this, "m_AudioFilterGUI");
				}
				return r_Fm_AudioFilterGUI;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject m_SerializedObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSerializedObject r_Fm_SerializedObject;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSerializedObject RFm_SerializedObject
		{
			get
			{
				if(r_Fm_SerializedObject == null)
				{
					r_Fm_SerializedObject = new(this, "m_SerializedObject");
				}
				return r_Fm_SerializedObject;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_EnabledProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSerializedProperty r_Fm_EnabledProperty;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSerializedProperty RFm_EnabledProperty
		{
			get
			{
				if(r_Fm_EnabledProperty == null)
				{
					r_Fm_EnabledProperty = new(this, "m_EnabledProperty");
				}
				return r_Fm_EnabledProperty;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode m_InspectorMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode r_Fm_InspectorMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode RFm_InspectorMode
		{
			get
			{
				if(r_Fm_InspectorMode == null)
				{
					r_Fm_InspectorMode = new(this, "m_InspectorMode");
				}
				return r_Fm_InspectorMode;
			}
		}

		/// <summary>
		/// System.Single kLineHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkLineHeight;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkLineHeight
		{
			get
			{
				if(r_FkLineHeight == null)
				{
					r_FkLineHeight = new(Type, "kLineHeight");
				}
				return r_FkLineHeight;
			}
		}

		/// <summary>
		/// System.Boolean hideInspector
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhideInspector;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhideInspector
		{
			get
			{
				if(r_FhideInspector == null)
				{
					r_FhideInspector = new(this, "hideInspector");
				}
				return r_FhideInspector;
			}
		}

		/// <summary>
		/// System.Single kImageSectionWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkImageSectionWidth;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkImageSectionWidth
		{
			get
			{
				if(r_FkImageSectionWidth == null)
				{
					r_FkImageSectionWidth = new(Type, "kImageSectionWidth");
				}
				return r_FkImageSectionWidth;
			}
		}

		/// <summary>
		/// System.Single k_WideModeMinWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fk_WideModeMinWidth;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFk_WideModeMinWidth
		{
			get
			{
				if(r_Fk_WideModeMinWidth == null)
				{
					r_Fk_WideModeMinWidth = new(Type, "k_WideModeMinWidth");
				}
				return r_Fk_WideModeMinWidth;
			}
		}

		/// <summary>
		/// System.Single k_HeaderHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fk_HeaderHeight;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFk_HeaderHeight
		{
			get
			{
				if(r_Fk_HeaderHeight == null)
				{
					r_Fk_HeaderHeight = new(Type, "k_HeaderHeight");
				}
				return r_Fk_HeaderHeight;
			}
		}

		/// <summary>
		/// UnityEditor.Editor+OnEditorGUIDelegate OnPostIconGUI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.REditor.ROnEditorGUIDelegate r_FOnPostIconGUI;
		public static Hvak.Editor.Refleaction.RUnityEditor.REditor.ROnEditorGUIDelegate RFOnPostIconGUI
		{
			get
			{
				if(r_FOnPostIconGUI == null)
				{
					r_FOnPostIconGUI = new(Type, "OnPostIconGUI");
				}
				return r_FOnPostIconGUI;
			}
		}

		/// <summary>
		/// System.Boolean m_AllowMultiObjectAccess
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_AllowMultiObjectAccess;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFm_AllowMultiObjectAccess
		{
			get
			{
				if(r_Fm_AllowMultiObjectAccess == null)
				{
					r_Fm_AllowMultiObjectAccess = new(Type, "m_AllowMultiObjectAccess");
				}
				return r_Fm_AllowMultiObjectAccess;
			}
		}

		/// <summary>
		/// System.Boolean m_HasUnsavedChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasUnsavedChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasUnsavedChanges
		{
			get
			{
				if(r_Fm_HasUnsavedChanges == null)
				{
					r_Fm_HasUnsavedChanges = new(this, "m_HasUnsavedChanges");
				}
				return r_Fm_HasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String <saveChangesMessage>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__saveChangesMessage__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__saveChangesMessage__1__k__BackingField
		{
			get
			{
				if(r_F__0__saveChangesMessage__1__k__BackingField == null)
				{
					r_F__0__saveChangesMessage__1__k__BackingField = new(this, "<saveChangesMessage>k__BackingField");
				}
				return r_F__0__saveChangesMessage__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <firstInspectedEditor>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__firstInspectedEditor__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__firstInspectedEditor__1__k__BackingField
		{
			get
			{
				if(r_F__0__firstInspectedEditor__1__k__BackingField == null)
				{
					r_F__0__firstInspectedEditor__1__k__BackingField = new(this, "<firstInspectedEditor>k__BackingField");
				}
				return r_F__0__firstInspectedEditor__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.IPropertyView <propertyViewer>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIPropertyView r_F__0__propertyViewer__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPropertyView RF__0__propertyViewer__1__k__BackingField
		{
			get
			{
				if(r_F__0__propertyViewer__1__k__BackingField == null)
				{
					r_F__0__propertyViewer__1__k__BackingField = new(this, "<propertyViewer>k__BackingField");
				}
				return r_F__0__propertyViewer__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Editor] finishedDefaultHeaderGUI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.REditor> r_FfinishedDefaultHeaderGUI;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.REditor> RFfinishedDefaultHeaderGUI
		{
			get
			{
				if(r_FfinishedDefaultHeaderGUI == null)
				{
					r_FfinishedDefaultHeaderGUI = new(Type, "finishedDefaultHeaderGUI");
				}
				return r_FfinishedDefaultHeaderGUI;
			}
		}

		/// <summary>
		/// System.Boolean <alwaysAllowExpansion>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__alwaysAllowExpansion__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__alwaysAllowExpansion__1__k__BackingField
		{
			get
			{
				if(r_F__0__alwaysAllowExpansion__1__k__BackingField == null)
				{
					r_F__0__alwaysAllowExpansion__1__k__BackingField = new(this, "<alwaysAllowExpansion>k__BackingField");
				}
				return r_F__0__alwaysAllowExpansion__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode inspectorMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode r_PinspectorMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode RPinspectorMode
		{
			get
			{
				if(r_PinspectorMode == null)
				{
					r_PinspectorMode = new(this, "inspectorMode", -1);
				}
				return r_PinspectorMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode dataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_PdataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RPdataMode
		{
			get
			{
				if(r_PdataMode == null)
				{
					r_PdataMode = new(this, "dataMode", -1);
				}
				return r_PdataMode;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasUnsavedChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasUnsavedChanges
		{
			get
			{
				if(r_PhasUnsavedChanges == null)
				{
					r_PhasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
				}
				return r_PhasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String saveChangesMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PsaveChangesMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsaveChangesMessage
		{
			get
			{
				if(r_PsaveChangesMessage == null)
				{
					r_PsaveChangesMessage = new(this, "saveChangesMessage", -1);
				}
				return r_PsaveChangesMessage;
			}
		}

		/// <summary>
		/// Boolean firstInspectedEditor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PfirstInspectedEditor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPfirstInspectedEditor
		{
			get
			{
				if(r_PfirstInspectedEditor == null)
				{
					r_PfirstInspectedEditor = new(this, "firstInspectedEditor", -1);
				}
				return r_PfirstInspectedEditor;
			}
		}

		/// <summary>
		/// UnityEditor.IPropertyView propertyViewer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIPropertyView r_PpropertyViewer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPropertyView RPpropertyViewer
		{
			get
			{
				if(r_PpropertyViewer == null)
				{
					r_PpropertyViewer = new(this, "propertyViewer", -1);
				}
				return r_PpropertyViewer;
			}
		}

		/// <summary>
		/// Boolean canEditMultipleObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanEditMultipleObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanEditMultipleObjects
		{
			get
			{
				if(r_PcanEditMultipleObjects == null)
				{
					r_PcanEditMultipleObjects = new(this, "canEditMultipleObjects", -1);
				}
				return r_PcanEditMultipleObjects;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable preview
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable r_Ppreview;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable RPpreview
		{
			get
			{
				if(r_Ppreview == null)
				{
					r_Ppreview = new(this, "preview", -1);
				}
				return r_Ppreview;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyHandlerCache propertyHandlerCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandlerCache r_PpropertyHandlerCache;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandlerCache RPpropertyHandlerCache
		{
			get
			{
				if(r_PpropertyHandlerCache == null)
				{
					r_PpropertyHandlerCache = new(this, "propertyHandlerCache", -1);
				}
				return r_PpropertyHandlerCache;
			}
		}

		/// <summary>
		/// Boolean UnityEditor.IToolModeOwner.areToolModesAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PUnityEditor__2__IToolModeOwner__2__areToolModesAvailable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPUnityEditor__2__IToolModeOwner__2__areToolModesAvailable
		{
			get
			{
				if(r_PUnityEditor__2__IToolModeOwner__2__areToolModesAvailable == null)
				{
					r_PUnityEditor__2__IToolModeOwner__2__areToolModesAvailable = new(this, "UnityEditor.IToolModeOwner.areToolModesAvailable", -1);
				}
				return r_PUnityEditor__2__IToolModeOwner__2__areToolModesAvailable;
			}
		}

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] targets
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Ptargets;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> RPtargets
		{
			get
			{
				if(r_Ptargets == null)
				{
					r_Ptargets = new(this, "targets", -1);
				}
				return r_Ptargets;
			}
		}

		/// <summary>
		/// Int32 referenceTargetIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PreferenceTargetIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPreferenceTargetIndex
		{
			get
			{
				if(r_PreferenceTargetIndex == null)
				{
					r_PreferenceTargetIndex = new(this, "referenceTargetIndex", -1);
				}
				return r_PreferenceTargetIndex;
			}
		}

		/// <summary>
		/// System.String targetTitle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PtargetTitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtargetTitle
		{
			get
			{
				if(r_PtargetTitle == null)
				{
					r_PtargetTitle = new(this, "targetTitle", -1);
				}
				return r_PtargetTitle;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject serializedObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSerializedObject r_PserializedObject;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSerializedObject RPserializedObject
		{
			get
			{
				if(r_PserializedObject == null)
				{
					r_PserializedObject = new(this, "serializedObject", -1);
				}
				return r_PserializedObject;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty enabledProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RSerializedProperty r_PenabledProperty;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RSerializedProperty RPenabledProperty
		{
			get
			{
				if(r_PenabledProperty == null)
				{
					r_PenabledProperty = new(this, "enabledProperty", -1);
				}
				return r_PenabledProperty;
			}
		}

		/// <summary>
		/// Boolean isInspectorDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInspectorDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInspectorDirty
		{
			get
			{
				if(r_PisInspectorDirty == null)
				{
					r_PisInspectorDirty = new(this, "isInspectorDirty", -1);
				}
				return r_PisInspectorDirty;
			}
		}

		/// <summary>
		/// Boolean alwaysAllowExpansion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PalwaysAllowExpansion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPalwaysAllowExpansion
		{
			get
			{
				if(r_PalwaysAllowExpansion == null)
				{
					r_PalwaysAllowExpansion = new(this, "alwaysAllowExpansion", -1);
				}
				return r_PalwaysAllowExpansion;
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
		/// Boolean GetHasUnsavedChanges()
		/// </summary>
		protected RMethod r_MGetHasUnsavedChanges;
		public virtual RMethod RMGetHasUnsavedChanges
		{
			get
			{
				if(r_MGetHasUnsavedChanges == null)
				{
					r_MGetHasUnsavedChanges = new(this, "GetHasUnsavedChanges", 0);
				}
				return r_MGetHasUnsavedChanges;
			}
		}

		/// <summary>
		/// Void SaveChanges()
		/// </summary>
		protected RMethod r_MSaveChanges;
		public virtual RMethod RMSaveChanges
		{
			get
			{
				if(r_MSaveChanges == null)
				{
					r_MSaveChanges = new(this, "SaveChanges", 0);
				}
				return r_MSaveChanges;
			}
		}

		/// <summary>
		/// Void DiscardChanges()
		/// </summary>
		protected RMethod r_MDiscardChanges;
		public virtual RMethod RMDiscardChanges
		{
			get
			{
				if(r_MDiscardChanges == null)
				{
					r_MDiscardChanges = new(this, "DiscardChanges", 0);
				}
				return r_MDiscardChanges;
			}
		}

		/// <summary>
		/// Boolean HasLargeHeader()
		/// </summary>
		protected RMethod r_MHasLargeHeader;
		public virtual RMethod RMHasLargeHeader
		{
			get
			{
				if(r_MHasLargeHeader == null)
				{
					r_MHasLargeHeader = new(this, "HasLargeHeader", 0);
				}
				return r_MHasLargeHeader;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[], UnityEngine.Object, System.Type)
		/// </summary>
		protected static RMethod r_MCreateEditorWithContext_ObjectArray_Object_Type;
		public static RMethod RMCreateEditorWithContext_ObjectArray_Object_Type
		{
			get
			{
				if(r_MCreateEditorWithContext_ObjectArray_Object_Type == null)
				{
					r_MCreateEditorWithContext_ObjectArray_Object_Type = new(Type, "CreateEditorWithContext", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object), typeof(System.Type));
				}
				return r_MCreateEditorWithContext_ObjectArray_Object_Type;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[], UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MCreateEditorWithContext_ObjectArray_Object;
		public static RMethod RMCreateEditorWithContext_ObjectArray_Object
		{
			get
			{
				if(r_MCreateEditorWithContext_ObjectArray_Object == null)
				{
					r_MCreateEditorWithContext_ObjectArray_Object = new(Type, "CreateEditorWithContext", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object));
				}
				return r_MCreateEditorWithContext_ObjectArray_Object;
			}
		}

		/// <summary>
		/// Void CreateCachedEditorWithContext(UnityEngine.Object, UnityEngine.Object, System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_MCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor;
		public static RMethod RMCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor
		{
			get
			{
				if(r_MCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor == null)
				{
					r_MCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor = new(Type, "CreateCachedEditorWithContext", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
				}
				return r_MCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// Void CreateCachedEditorWithContext(UnityEngine.Object[], UnityEngine.Object, System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_MCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor;
		public static RMethod RMCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor
		{
			get
			{
				if(r_MCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor == null)
				{
					r_MCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor = new(Type, "CreateCachedEditorWithContext", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
				}
				return r_MCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// Void CreateCachedEditor(UnityEngine.Object, System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_MCreateCachedEditor_Object_Type_Ref_Editor;
		public static RMethod RMCreateCachedEditor_Object_Type_Ref_Editor
		{
			get
			{
				if(r_MCreateCachedEditor_Object_Type_Ref_Editor == null)
				{
					r_MCreateCachedEditor_Object_Type_Ref_Editor = new(Type, "CreateCachedEditor", 0, typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
				}
				return r_MCreateCachedEditor_Object_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// Void CreateCachedEditor(UnityEngine.Object[], System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_MCreateCachedEditor_ObjectArray_Type_Ref_Editor;
		public static RMethod RMCreateCachedEditor_ObjectArray_Type_Ref_Editor
		{
			get
			{
				if(r_MCreateCachedEditor_ObjectArray_Type_Ref_Editor == null)
				{
					r_MCreateCachedEditor_ObjectArray_Type_Ref_Editor = new(Type, "CreateCachedEditor", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
				}
				return r_MCreateCachedEditor_ObjectArray_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MCreateEditor_Object;
		public static RMethod RMCreateEditor_Object
		{
			get
			{
				if(r_MCreateEditor_Object == null)
				{
					r_MCreateEditor_Object = new(Type, "CreateEditor", 0, typeof(UnityEngine.Object));
				}
				return r_MCreateEditor_Object;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object, System.Type)
		/// </summary>
		protected static RMethod r_MCreateEditor_Object_Type;
		public static RMethod RMCreateEditor_Object_Type
		{
			get
			{
				if(r_MCreateEditor_Object_Type == null)
				{
					r_MCreateEditor_Object_Type = new(Type, "CreateEditor", 0, typeof(UnityEngine.Object), typeof(System.Type));
				}
				return r_MCreateEditor_Object_Type;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object[])
		/// </summary>
		protected static RMethod r_MCreateEditor_ObjectArray;
		public static RMethod RMCreateEditor_ObjectArray
		{
			get
			{
				if(r_MCreateEditor_ObjectArray == null)
				{
					r_MCreateEditor_ObjectArray = new(Type, "CreateEditor", 0, typeof(UnityEngine.Object).MakeArrayType());
				}
				return r_MCreateEditor_ObjectArray;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object[], System.Type)
		/// </summary>
		protected static RMethod r_MCreateEditor_ObjectArray_Type;
		public static RMethod RMCreateEditor_ObjectArray_Type
		{
			get
			{
				if(r_MCreateEditor_ObjectArray_Type == null)
				{
					r_MCreateEditor_ObjectArray_Type = new(Type, "CreateEditor", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Type));
				}
				return r_MCreateEditor_ObjectArray_Type;
			}
		}

		/// <summary>
		/// Void CleanupPropertyEditor()
		/// </summary>
		protected RMethod r_MCleanupPropertyEditor;
		public virtual RMethod RMCleanupPropertyEditor
		{
			get
			{
				if(r_MCleanupPropertyEditor == null)
				{
					r_MCleanupPropertyEditor = new(this, "CleanupPropertyEditor", 0);
				}
				return r_MCleanupPropertyEditor;
			}
		}

		/// <summary>
		/// Void OnDisableINTERNAL()
		/// </summary>
		protected RMethod r_MOnDisableINTERNAL;
		public virtual RMethod RMOnDisableINTERNAL
		{
			get
			{
				if(r_MOnDisableINTERNAL == null)
				{
					r_MOnDisableINTERNAL = new(this, "OnDisableINTERNAL", 0);
				}
				return r_MOnDisableINTERNAL;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject GetSerializedObjectInternal()
		/// </summary>
		protected RMethod r_MGetSerializedObjectInternal;
		public virtual RMethod RMGetSerializedObjectInternal
		{
			get
			{
				if(r_MGetSerializedObjectInternal == null)
				{
					r_MGetSerializedObjectInternal = new(this, "GetSerializedObjectInternal", 0);
				}
				return r_MGetSerializedObjectInternal;
			}
		}

		/// <summary>
		/// Void CreateSerializedObject()
		/// </summary>
		protected RMethod r_MCreateSerializedObject;
		public virtual RMethod RMCreateSerializedObject
		{
			get
			{
				if(r_MCreateSerializedObject == null)
				{
					r_MCreateSerializedObject = new(this, "CreateSerializedObject", 0);
				}
				return r_MCreateSerializedObject;
			}
		}

		/// <summary>
		/// Void AssignCachedProperties[T](T, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MAssignCachedProperties_GT_T_SerializedProperty;
		public static RMethod RMAssignCachedProperties_GT_T_SerializedProperty
		{
			get
			{
				if(r_MAssignCachedProperties_GT_T_SerializedProperty == null)
				{
					r_MAssignCachedProperties_GT_T_SerializedProperty = new(Type, "AssignCachedProperties", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEditor.SerializedProperty));
				}
				return r_MAssignCachedProperties_GT_T_SerializedProperty;
			}
		}

		/// <summary>
		/// Void InternalSetTargets(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_MInternalSetTargets_ObjectArray;
		public virtual RMethod RMInternalSetTargets_ObjectArray
		{
			get
			{
				if(r_MInternalSetTargets_ObjectArray == null)
				{
					r_MInternalSetTargets_ObjectArray = new(this, "InternalSetTargets", 0, typeof(UnityEngine.Object).MakeArrayType());
				}
				return r_MInternalSetTargets_ObjectArray;
			}
		}

		/// <summary>
		/// Void InternalSetHidden(Boolean)
		/// </summary>
		protected RMethod r_MInternalSetHidden_Boolean;
		public virtual RMethod RMInternalSetHidden_Boolean
		{
			get
			{
				if(r_MInternalSetHidden_Boolean == null)
				{
					r_MInternalSetHidden_Boolean = new(this, "InternalSetHidden", 0, typeof(System.Boolean));
				}
				return r_MInternalSetHidden_Boolean;
			}
		}

		/// <summary>
		/// Void InternalSetContextObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MInternalSetContextObject_Object;
		public virtual RMethod RMInternalSetContextObject_Object
		{
			get
			{
				if(r_MInternalSetContextObject_Object == null)
				{
					r_MInternalSetContextObject_Object = new(this, "InternalSetContextObject", 0, typeof(UnityEngine.Object));
				}
				return r_MInternalSetContextObject_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds UnityEditor.IToolModeOwner.GetWorldBoundsOfTargets()
		/// </summary>
		protected RMethod r_MUnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets;
		public virtual RMethod RMUnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets
		{
			get
			{
				if(r_MUnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets == null)
				{
					r_MUnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets = new(this, "UnityEditor.IToolModeOwner.GetWorldBoundsOfTargets", 0);
				}
				return r_MUnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds GetWorldBoundsOfTarget(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MGetWorldBoundsOfTarget_Object;
		public virtual RMethod RMGetWorldBoundsOfTarget_Object
		{
			get
			{
				if(r_MGetWorldBoundsOfTarget_Object == null)
				{
					r_MGetWorldBoundsOfTarget_Object = new(this, "GetWorldBoundsOfTarget", 0, typeof(UnityEngine.Object));
				}
				return r_MGetWorldBoundsOfTarget_Object;
			}
		}

		/// <summary>
		/// Boolean UnityEditor.IToolModeOwner.ModeSurvivesSelectionChange(Int32)
		/// </summary>
		protected RMethod r_MUnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange_Int32;
		public virtual RMethod RMUnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange_Int32
		{
			get
			{
				if(r_MUnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange_Int32 == null)
				{
					r_MUnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange_Int32 = new(this, "UnityEditor.IToolModeOwner.ModeSurvivesSelectionChange", 0, typeof(System.Int32));
				}
				return r_MUnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange_Int32;
			}
		}

		/// <summary>
		/// Void OnForceReloadInspector()
		/// </summary>
		protected RMethod r_MOnForceReloadInspector;
		public virtual RMethod RMOnForceReloadInspector
		{
			get
			{
				if(r_MOnForceReloadInspector == null)
				{
					r_MOnForceReloadInspector = new(this, "OnForceReloadInspector", 0);
				}
				return r_MOnForceReloadInspector;
			}
		}

		/// <summary>
		/// Boolean GetOptimizedGUIBlock(Boolean, Boolean, Single ByRef)
		/// </summary>
		protected RMethod r_MGetOptimizedGUIBlock_Boolean_Boolean_Out_Single;
		public virtual RMethod RMGetOptimizedGUIBlock_Boolean_Boolean_Out_Single
		{
			get
			{
				if(r_MGetOptimizedGUIBlock_Boolean_Boolean_Out_Single == null)
				{
					r_MGetOptimizedGUIBlock_Boolean_Boolean_Out_Single = new(this, "GetOptimizedGUIBlock", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Single).MakeByRefType());
				}
				return r_MGetOptimizedGUIBlock_Boolean_Boolean_Out_Single;
			}
		}

		/// <summary>
		/// Boolean OnOptimizedInspectorGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOnOptimizedInspectorGUI_Rect;
		public virtual RMethod RMOnOptimizedInspectorGUI_Rect
		{
			get
			{
				if(r_MOnOptimizedInspectorGUI_Rect == null)
				{
					r_MOnOptimizedInspectorGUI_Rect = new(this, "OnOptimizedInspectorGUI", 0, typeof(UnityEngine.Rect));
				}
				return r_MOnOptimizedInspectorGUI_Rect;
			}
		}

		/// <summary>
		/// Void DrawPropertiesExcluding(UnityEditor.SerializedObject, System.String[])
		/// </summary>
		protected static RMethod r_MDrawPropertiesExcluding_SerializedObject_StringArray;
		public static RMethod RMDrawPropertiesExcluding_SerializedObject_StringArray
		{
			get
			{
				if(r_MDrawPropertiesExcluding_SerializedObject_StringArray == null)
				{
					r_MDrawPropertiesExcluding_SerializedObject_StringArray = new(Type, "DrawPropertiesExcluding", 0, typeof(UnityEditor.SerializedObject), typeof(System.String).MakeArrayType());
				}
				return r_MDrawPropertiesExcluding_SerializedObject_StringArray;
			}
		}

		/// <summary>
		/// Boolean DrawDefaultInspector()
		/// </summary>
		protected RMethod r_MDrawDefaultInspector;
		public virtual RMethod RMDrawDefaultInspector
		{
			get
			{
				if(r_MDrawDefaultInspector == null)
				{
					r_MDrawDefaultInspector = new(this, "DrawDefaultInspector", 0);
				}
				return r_MDrawDefaultInspector;
			}
		}

		/// <summary>
		/// Boolean DoDrawDefaultInspector(UnityEditor.SerializedObject)
		/// </summary>
		protected static RMethod r_MDoDrawDefaultInspector_SerializedObject;
		public static RMethod RMDoDrawDefaultInspector_SerializedObject
		{
			get
			{
				if(r_MDoDrawDefaultInspector_SerializedObject == null)
				{
					r_MDoDrawDefaultInspector_SerializedObject = new(Type, "DoDrawDefaultInspector", 0, typeof(UnityEditor.SerializedObject));
				}
				return r_MDoDrawDefaultInspector_SerializedObject;
			}
		}

		/// <summary>
		/// Boolean DoDrawDefaultInspector()
		/// </summary>
		protected RMethod r_MDoDrawDefaultInspector;
		public virtual RMethod RMDoDrawDefaultInspector
		{
			get
			{
				if(r_MDoDrawDefaultInspector == null)
				{
					r_MDoDrawDefaultInspector = new(this, "DoDrawDefaultInspector", 0);
				}
				return r_MDoDrawDefaultInspector;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_MRepaint;
		public virtual RMethod RMRepaint
		{
			get
			{
				if(r_MRepaint == null)
				{
					r_MRepaint = new(this, "Repaint", 0);
				}
				return r_MRepaint;
			}
		}

		/// <summary>
		/// Void OnInspectorGUI()
		/// </summary>
		protected RMethod r_MOnInspectorGUI;
		public virtual RMethod RMOnInspectorGUI
		{
			get
			{
				if(r_MOnInspectorGUI == null)
				{
					r_MOnInspectorGUI = new(this, "OnInspectorGUI", 0);
				}
				return r_MOnInspectorGUI;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateInspectorGUI()
		/// </summary>
		protected RMethod r_MCreateInspectorGUI;
		public virtual RMethod RMCreateInspectorGUI
		{
			get
			{
				if(r_MCreateInspectorGUI == null)
				{
					r_MCreateInspectorGUI = new(this, "CreateInspectorGUI", 0);
				}
				return r_MCreateInspectorGUI;
			}
		}

		/// <summary>
		/// Boolean RequiresConstantRepaint()
		/// </summary>
		protected RMethod r_MRequiresConstantRepaint;
		public virtual RMethod RMRequiresConstantRepaint
		{
			get
			{
				if(r_MRequiresConstantRepaint == null)
				{
					r_MRequiresConstantRepaint = new(this, "RequiresConstantRepaint", 0);
				}
				return r_MRequiresConstantRepaint;
			}
		}

		/// <summary>
		/// Void DrawHeader()
		/// </summary>
		protected RMethod r_MDrawHeader;
		public virtual RMethod RMDrawHeader
		{
			get
			{
				if(r_MDrawHeader == null)
				{
					r_MDrawHeader = new(this, "DrawHeader", 0);
				}
				return r_MDrawHeader;
			}
		}

		/// <summary>
		/// Void OnHeaderGUI()
		/// </summary>
		protected RMethod r_MOnHeaderGUI;
		public virtual RMethod RMOnHeaderGUI
		{
			get
			{
				if(r_MOnHeaderGUI == null)
				{
					r_MOnHeaderGUI = new(this, "OnHeaderGUI", 0);
				}
				return r_MOnHeaderGUI;
			}
		}

		/// <summary>
		/// Void OnHeaderControlsGUI()
		/// </summary>
		protected RMethod r_MOnHeaderControlsGUI;
		public virtual RMethod RMOnHeaderControlsGUI
		{
			get
			{
				if(r_MOnHeaderControlsGUI == null)
				{
					r_MOnHeaderControlsGUI = new(this, "OnHeaderControlsGUI", 0);
				}
				return r_MOnHeaderControlsGUI;
			}
		}

		/// <summary>
		/// Void ShowOpenButton(UnityEngine.Object[], Boolean)
		/// </summary>
		protected RMethod r_MShowOpenButton_ObjectArray_Boolean;
		public virtual RMethod RMShowOpenButton_ObjectArray_Boolean
		{
			get
			{
				if(r_MShowOpenButton_ObjectArray_Boolean == null)
				{
					r_MShowOpenButton_ObjectArray_Boolean = new(this, "ShowOpenButton", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Boolean));
				}
				return r_MShowOpenButton_ObjectArray_Boolean;
			}
		}

		/// <summary>
		/// Boolean ShouldHideOpenButton()
		/// </summary>
		protected RMethod r_MShouldHideOpenButton;
		public virtual RMethod RMShouldHideOpenButton
		{
			get
			{
				if(r_MShouldHideOpenButton == null)
				{
					r_MShouldHideOpenButton = new(this, "ShouldHideOpenButton", 0);
				}
				return r_MShouldHideOpenButton;
			}
		}

		/// <summary>
		/// Boolean CanOpenMultipleObjects()
		/// </summary>
		protected RMethod r_MCanOpenMultipleObjects;
		public virtual RMethod RMCanOpenMultipleObjects
		{
			get
			{
				if(r_MCanOpenMultipleObjects == null)
				{
					r_MCanOpenMultipleObjects = new(this, "CanOpenMultipleObjects", 0);
				}
				return r_MCanOpenMultipleObjects;
			}
		}

		/// <summary>
		/// Boolean ShouldTryToMakeEditableOnOpen()
		/// </summary>
		protected RMethod r_MShouldTryToMakeEditableOnOpen;
		public virtual RMethod RMShouldTryToMakeEditableOnOpen
		{
			get
			{
				if(r_MShouldTryToMakeEditableOnOpen == null)
				{
					r_MShouldTryToMakeEditableOnOpen = new(this, "ShouldTryToMakeEditableOnOpen", 0);
				}
				return r_MShouldTryToMakeEditableOnOpen;
			}
		}

		/// <summary>
		/// Void OnHeaderIconGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOnHeaderIconGUI_Rect;
		public virtual RMethod RMOnHeaderIconGUI_Rect
		{
			get
			{
				if(r_MOnHeaderIconGUI_Rect == null)
				{
					r_MOnHeaderIconGUI_Rect = new(this, "OnHeaderIconGUI", 0, typeof(UnityEngine.Rect));
				}
				return r_MOnHeaderIconGUI_Rect;
			}
		}

		/// <summary>
		/// Void OnHeaderTitleGUI(UnityEngine.Rect, System.String)
		/// </summary>
		protected RMethod r_MOnHeaderTitleGUI_Rect_String;
		public virtual RMethod RMOnHeaderTitleGUI_Rect_String
		{
			get
			{
				if(r_MOnHeaderTitleGUI_Rect_String == null)
				{
					r_MOnHeaderTitleGUI_Rect_String = new(this, "OnHeaderTitleGUI", 0, typeof(UnityEngine.Rect), typeof(System.String));
				}
				return r_MOnHeaderTitleGUI_Rect_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rect DrawHeaderHelpAndSettingsGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDrawHeaderHelpAndSettingsGUI_Rect;
		public virtual RMethod RMDrawHeaderHelpAndSettingsGUI_Rect
		{
			get
			{
				if(r_MDrawHeaderHelpAndSettingsGUI_Rect == null)
				{
					r_MDrawHeaderHelpAndSettingsGUI_Rect = new(this, "DrawHeaderHelpAndSettingsGUI", 0, typeof(UnityEngine.Rect));
				}
				return r_MDrawHeaderHelpAndSettingsGUI_Rect;
			}
		}

		/// <summary>
		/// Void DrawHeaderFromInsideHierarchy()
		/// </summary>
		protected RMethod r_MDrawHeaderFromInsideHierarchy;
		public virtual RMethod RMDrawHeaderFromInsideHierarchy
		{
			get
			{
				if(r_MDrawHeaderFromInsideHierarchy == null)
				{
					r_MDrawHeaderFromInsideHierarchy = new(this, "DrawHeaderFromInsideHierarchy", 0);
				}
				return r_MDrawHeaderFromInsideHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor, System.String)
		/// </summary>
		protected static RMethod r_MDrawHeaderGUI_Editor_String;
		public static RMethod RMDrawHeaderGUI_Editor_String
		{
			get
			{
				if(r_MDrawHeaderGUI_Editor_String == null)
				{
					r_MDrawHeaderGUI_Editor_String = new(Type, "DrawHeaderGUI", 0, typeof(UnityEditor.Editor), typeof(System.String));
				}
				return r_MDrawHeaderGUI_Editor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor, System.String, Single)
		/// </summary>
		protected static RMethod r_MDrawHeaderGUI_Editor_String_Single;
		public static RMethod RMDrawHeaderGUI_Editor_String_Single
		{
			get
			{
				if(r_MDrawHeaderGUI_Editor_String_Single == null)
				{
					r_MDrawHeaderGUI_Editor_String_Single = new(Type, "DrawHeaderGUI", 0, typeof(UnityEditor.Editor), typeof(System.String), typeof(System.Single));
				}
				return r_MDrawHeaderGUI_Editor_String_Single;
			}
		}

		/// <summary>
		/// Void CheckForMainObjectNameMismatch(UnityEditor.Editor)
		/// </summary>
		protected static RMethod r_MCheckForMainObjectNameMismatch_Editor;
		public static RMethod RMCheckForMainObjectNameMismatch_Editor
		{
			get
			{
				if(r_MCheckForMainObjectNameMismatch_Editor == null)
				{
					r_MCheckForMainObjectNameMismatch_Editor = new(Type, "CheckForMainObjectNameMismatch", 0, typeof(UnityEditor.Editor));
				}
				return r_MCheckForMainObjectNameMismatch_Editor;
			}
		}

		/// <summary>
		/// Void DrawMismatchedNameNotification(UnityEditor.Editor, System.String, System.String)
		/// </summary>
		protected static RMethod r_MDrawMismatchedNameNotification_Editor_String_String;
		public static RMethod RMDrawMismatchedNameNotification_Editor_String_String
		{
			get
			{
				if(r_MDrawMismatchedNameNotification_Editor_String_String == null)
				{
					r_MDrawMismatchedNameNotification_Editor_String_String = new(Type, "DrawMismatchedNameNotification", 0, typeof(UnityEditor.Editor), typeof(System.String), typeof(System.String));
				}
				return r_MDrawMismatchedNameNotification_Editor_String_String;
			}
		}

		/// <summary>
		/// Void DrawNotification(UnityEngine.Texture, System.String, System.String, System.Action)
		/// </summary>
		protected static RMethod r_MDrawNotification_Texture_String_String_Action;
		public static RMethod RMDrawNotification_Texture_String_String_Action
		{
			get
			{
				if(r_MDrawNotification_Texture_String_String_Action == null)
				{
					r_MDrawNotification_Texture_String_String_Action = new(Type, "DrawNotification", 0, typeof(UnityEngine.Texture), typeof(System.String), typeof(System.String), typeof(System.Action));
				}
				return r_MDrawNotification_Texture_String_String_Action;
			}
		}

		/// <summary>
		/// Void DrawPostIconContent(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDrawPostIconContent_Rect;
		public virtual RMethod RMDrawPostIconContent_Rect
		{
			get
			{
				if(r_MDrawPostIconContent_Rect == null)
				{
					r_MDrawPostIconContent_Rect = new(this, "DrawPostIconContent", 0, typeof(UnityEngine.Rect));
				}
				return r_MDrawPostIconContent_Rect;
			}
		}

		/// <summary>
		/// Void DrawFoldoutInspector(UnityEngine.Object, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_MDrawFoldoutInspector_Object_Ref_Editor;
		public static RMethod RMDrawFoldoutInspector_Object_Ref_Editor
		{
			get
			{
				if(r_MDrawFoldoutInspector_Object_Ref_Editor == null)
				{
					r_MDrawFoldoutInspector_Object_Ref_Editor = new(Type, "DrawFoldoutInspector", 0, typeof(UnityEngine.Object), typeof(UnityEditor.Editor).MakeByRefType());
				}
				return r_MDrawFoldoutInspector_Object_Ref_Editor;
			}
		}

		/// <summary>
		/// Boolean HasPreviewGUI()
		/// </summary>
		protected RMethod r_MHasPreviewGUI;
		public virtual RMethod RMHasPreviewGUI
		{
			get
			{
				if(r_MHasPreviewGUI == null)
				{
					r_MHasPreviewGUI = new(this, "HasPreviewGUI", 0);
				}
				return r_MHasPreviewGUI;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetPreviewTitle()
		/// </summary>
		protected RMethod r_MGetPreviewTitle;
		public virtual RMethod RMGetPreviewTitle
		{
			get
			{
				if(r_MGetPreviewTitle == null)
				{
					r_MGetPreviewTitle = new(this, "GetPreviewTitle", 0);
				}
				return r_MGetPreviewTitle;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D RenderStaticPreview(System.String, UnityEngine.Object[], Int32, Int32)
		/// </summary>
		protected RMethod r_MRenderStaticPreview_String_ObjectArray_Int32_Int32;
		public virtual RMethod RMRenderStaticPreview_String_ObjectArray_Int32_Int32
		{
			get
			{
				if(r_MRenderStaticPreview_String_ObjectArray_Int32_Int32 == null)
				{
					r_MRenderStaticPreview_String_ObjectArray_Int32_Int32 = new(this, "RenderStaticPreview", 0, typeof(System.String), typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MRenderStaticPreview_String_ObjectArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void OnPreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MOnPreviewGUI_Rect_GUIStyle;
		public virtual RMethod RMOnPreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_MOnPreviewGUI_Rect_GUIStyle == null)
				{
					r_MOnPreviewGUI_Rect_GUIStyle = new(this, "OnPreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
				}
				return r_MOnPreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnInteractivePreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MOnInteractivePreviewGUI_Rect_GUIStyle;
		public virtual RMethod RMOnInteractivePreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_MOnInteractivePreviewGUI_Rect_GUIStyle == null)
				{
					r_MOnInteractivePreviewGUI_Rect_GUIStyle = new(this, "OnInteractivePreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
				}
				return r_MOnInteractivePreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnPreviewSettings()
		/// </summary>
		protected RMethod r_MOnPreviewSettings;
		public virtual RMethod RMOnPreviewSettings
		{
			get
			{
				if(r_MOnPreviewSettings == null)
				{
					r_MOnPreviewSettings = new(this, "OnPreviewSettings", 0);
				}
				return r_MOnPreviewSettings;
			}
		}

		/// <summary>
		/// System.String GetInfoString()
		/// </summary>
		protected RMethod r_MGetInfoString;
		public virtual RMethod RMGetInfoString
		{
			get
			{
				if(r_MGetInfoString == null)
				{
					r_MGetInfoString = new(this, "GetInfoString", 0);
				}
				return r_MGetInfoString;
			}
		}

		/// <summary>
		/// Void DrawPreview(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDrawPreview_Rect;
		public virtual RMethod RMDrawPreview_Rect
		{
			get
			{
				if(r_MDrawPreview_Rect == null)
				{
					r_MDrawPreview_Rect = new(this, "DrawPreview", 0, typeof(UnityEngine.Rect));
				}
				return r_MDrawPreview_Rect;
			}
		}

		/// <summary>
		/// Void ReloadPreviewInstances()
		/// </summary>
		protected RMethod r_MReloadPreviewInstances;
		public virtual RMethod RMReloadPreviewInstances
		{
			get
			{
				if(r_MReloadPreviewInstances == null)
				{
					r_MReloadPreviewInstances = new(this, "ReloadPreviewInstances", 0);
				}
				return r_MReloadPreviewInstances;
			}
		}

		/// <summary>
		/// Boolean CanBeExpandedViaAFoldout()
		/// </summary>
		protected RMethod r_MCanBeExpandedViaAFoldout;
		public virtual RMethod RMCanBeExpandedViaAFoldout
		{
			get
			{
				if(r_MCanBeExpandedViaAFoldout == null)
				{
					r_MCanBeExpandedViaAFoldout = new(this, "CanBeExpandedViaAFoldout", 0);
				}
				return r_MCanBeExpandedViaAFoldout;
			}
		}

		/// <summary>
		/// Boolean CanBeExpandedViaAFoldoutWithoutUpdate()
		/// </summary>
		protected RMethod r_MCanBeExpandedViaAFoldoutWithoutUpdate;
		public virtual RMethod RMCanBeExpandedViaAFoldoutWithoutUpdate
		{
			get
			{
				if(r_MCanBeExpandedViaAFoldoutWithoutUpdate == null)
				{
					r_MCanBeExpandedViaAFoldoutWithoutUpdate = new(this, "CanBeExpandedViaAFoldoutWithoutUpdate", 0);
				}
				return r_MCanBeExpandedViaAFoldoutWithoutUpdate;
			}
		}

		/// <summary>
		/// Boolean IsAppropriateFileOpenForEdit(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MIsAppropriateFileOpenForEdit_Object;
		public static RMethod RMIsAppropriateFileOpenForEdit_Object
		{
			get
			{
				if(r_MIsAppropriateFileOpenForEdit_Object == null)
				{
					r_MIsAppropriateFileOpenForEdit_Object = new(Type, "IsAppropriateFileOpenForEdit", 0, typeof(UnityEngine.Object));
				}
				return r_MIsAppropriateFileOpenForEdit_Object;
			}
		}

		/// <summary>
		/// Boolean IsEnabled()
		/// </summary>
		protected RMethod r_MIsEnabled;
		public virtual RMethod RMIsEnabled
		{
			get
			{
				if(r_MIsEnabled == null)
				{
					r_MIsEnabled = new(this, "IsEnabled", 0);
				}
				return r_MIsEnabled;
			}
		}

		/// <summary>
		/// Boolean IsOpenForEdit()
		/// </summary>
		protected RMethod r_MIsOpenForEdit;
		public virtual RMethod RMIsOpenForEdit
		{
			get
			{
				if(r_MIsOpenForEdit == null)
				{
					r_MIsOpenForEdit = new(this, "IsOpenForEdit", 0);
				}
				return r_MIsOpenForEdit;
			}
		}

		/// <summary>
		/// Boolean UseDefaultMargins()
		/// </summary>
		protected RMethod r_MUseDefaultMargins;
		public virtual RMethod RMUseDefaultMargins
		{
			get
			{
				if(r_MUseDefaultMargins == null)
				{
					r_MUseDefaultMargins = new(this, "UseDefaultMargins", 0);
				}
				return r_MUseDefaultMargins;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_MInitialize_ObjectArray;
		public virtual RMethod RMInitialize_ObjectArray
		{
			get
			{
				if(r_MInitialize_ObjectArray == null)
				{
					r_MInitialize_ObjectArray = new(this, "Initialize", 0, typeof(UnityEngine.Object).MakeArrayType());
				}
				return r_MInitialize_ObjectArray;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_MCleanup;
		public virtual RMethod RMCleanup
		{
			get
			{
				if(r_MCleanup == null)
				{
					r_MCleanup = new(this, "Cleanup", 0);
				}
				return r_MCleanup;
			}
		}

		/// <summary>
		/// Boolean MoveNextTarget()
		/// </summary>
		protected RMethod r_MMoveNextTarget;
		public virtual RMethod RMMoveNextTarget
		{
			get
			{
				if(r_MMoveNextTarget == null)
				{
					r_MMoveNextTarget = new(this, "MoveNextTarget", 0);
				}
				return r_MMoveNextTarget;
			}
		}

		/// <summary>
		/// Void ResetTarget()
		/// </summary>
		protected RMethod r_MResetTarget;
		public virtual RMethod RMResetTarget
		{
			get
			{
				if(r_MResetTarget == null)
				{
					r_MResetTarget = new(this, "ResetTarget", 0);
				}
				return r_MResetTarget;
			}
		}

		/// <summary>
		/// Void OnAssetStoreInspectorGUI()
		/// </summary>
		protected RMethod r_MOnAssetStoreInspectorGUI;
		public virtual RMethod RMOnAssetStoreInspectorGUI
		{
			get
			{
				if(r_MOnAssetStoreInspectorGUI == null)
				{
					r_MOnAssetStoreInspectorGUI = new(this, "OnAssetStoreInspectorGUI", 0);
				}
				return r_MOnAssetStoreInspectorGUI;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditorWithContextInternal(UnityEngine.Object[], UnityEngine.Object, System.Type)
		/// </summary>
		protected static RMethod r_MCreateEditorWithContextInternal_ObjectArray_Object_Type;
		public static RMethod RMCreateEditorWithContextInternal_ObjectArray_Object_Type
		{
			get
			{
				if(r_MCreateEditorWithContextInternal_ObjectArray_Object_Type == null)
				{
					r_MCreateEditorWithContextInternal_ObjectArray_Object_Type = new(Type, "CreateEditorWithContextInternal", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object), typeof(System.Type));
				}
				return r_MCreateEditorWithContextInternal_ObjectArray_Object_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCurrentMousePosition()
		/// </summary>
		protected static RMethod r_MGetCurrentMousePosition;
		public static RMethod RMGetCurrentMousePosition
		{
			get
			{
				if(r_MGetCurrentMousePosition == null)
				{
					r_MGetCurrentMousePosition = new(Type, "GetCurrentMousePosition", 0);
				}
				return r_MGetCurrentMousePosition;
			}
		}

		/// <summary>
		/// Int32 UnityEditor.IToolModeOwner.GetInstanceID()
		/// </summary>
		protected RMethod r_MUnityEditor__2__IToolModeOwner__2__GetInstanceID;
		public virtual RMethod RMUnityEditor__2__IToolModeOwner__2__GetInstanceID
		{
			get
			{
				if(r_MUnityEditor__2__IToolModeOwner__2__GetInstanceID == null)
				{
					r_MUnityEditor__2__IToolModeOwner__2__GetInstanceID = new(this, "UnityEditor.IToolModeOwner.GetInstanceID", 0);
				}
				return r_MUnityEditor__2__IToolModeOwner__2__GetInstanceID;
			}
		}

		/// <summary>
		/// Void GetCurrentMousePosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected static RMethod r_MGetCurrentMousePosition_Injected_Out_Vector2;
		public static RMethod RMGetCurrentMousePosition_Injected_Out_Vector2
		{
			get
			{
				if(r_MGetCurrentMousePosition_Injected_Out_Vector2 == null)
				{
					r_MGetCurrentMousePosition_Injected_Out_Vector2 = new(Type, "GetCurrentMousePosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MGetCurrentMousePosition_Injected_Out_Vector2;
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


        public virtual System.Boolean GetHasUnsavedChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHasUnsavedChanges.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SaveChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DiscardChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDiscardChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasLargeHeader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasLargeHeader.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[] @targetObjects, UnityEngine.Object @context, System.Type @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context, @editorType};
            var ___result = RMCreateEditorWithContext_ObjectArray_Object_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public static UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[] @targetObjects, UnityEngine.Object @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context};
            var ___result = RMCreateEditorWithContext_ObjectArray_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public static void CreateCachedEditorWithContext(UnityEngine.Object @targetObject, UnityEngine.Object @context, System.Type @editorType, ref UnityEditor.Editor @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject, @context, @editorType, @previousEditor};
            var ___result = RMCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			@previousEditor = ReflectionUtils.Convert<UnityEditor.Editor>(___parameters[3]);

            
        }


        public static void CreateCachedEditorWithContext(UnityEngine.Object[] @targetObjects, UnityEngine.Object @context, System.Type @editorType, ref UnityEditor.Editor @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context, @editorType, @previousEditor};
            var ___result = RMCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			@previousEditor = ReflectionUtils.Convert<UnityEditor.Editor>(___parameters[3]);

            
        }


        public static void CreateCachedEditor(UnityEngine.Object @targetObject, System.Type @editorType, ref UnityEditor.Editor @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject, @editorType, @previousEditor};
            var ___result = RMCreateCachedEditor_Object_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			@previousEditor = ReflectionUtils.Convert<UnityEditor.Editor>(___parameters[2]);

            
        }


        public static void CreateCachedEditor(UnityEngine.Object[] @targetObjects, System.Type @editorType, ref UnityEditor.Editor @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @editorType, @previousEditor};
            var ___result = RMCreateCachedEditor_ObjectArray_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			@previousEditor = ReflectionUtils.Convert<UnityEditor.Editor>(___parameters[2]);

            
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object @targetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject};
            var ___result = RMCreateEditor_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object @targetObject, System.Type @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject, @editorType};
            var ___result = RMCreateEditor_Object_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object[] @targetObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects};
            var ___result = RMCreateEditor_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object[] @targetObjects, System.Type @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @editorType};
            var ___result = RMCreateEditor_ObjectArray_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public virtual void CleanupPropertyEditor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanupPropertyEditor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisableINTERNAL()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisableINTERNAL.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedObject GetSerializedObjectInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerializedObjectInternal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.SerializedObject>(___result);
        }


        public virtual void CreateSerializedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateSerializedObject.Invoke(___genericsType, ___parameters);

            
        }


        public static void AssignCachedProperties<T>(T @self, UnityEditor.SerializedProperty @root) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@self, @root};
            var ___result = RMAssignCachedProperties_GT_T_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetTargets(UnityEngine.Object[] @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMInternalSetTargets_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetHidden(System.Boolean @hidden)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hidden};
            var ___result = RMInternalSetHidden_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetContextObject(UnityEngine.Object @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMInternalSetContextObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Bounds UnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEditor__2__IToolModeOwner__2__GetWorldBoundsOfTargets.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Bounds>(___result);
        }


        public virtual UnityEngine.Bounds GetWorldBoundsOfTarget(UnityEngine.Object @targetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject};
            var ___result = RMGetWorldBoundsOfTarget_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Bounds>(___result);
        }


        public virtual System.Boolean UnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange(System.Int32 @toolMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toolMode};
            var ___result = RMUnityEditor__2__IToolModeOwner__2__ModeSurvivesSelectionChange_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void OnForceReloadInspector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnForceReloadInspector.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetOptimizedGUIBlock(System.Boolean @isDirty, System.Boolean @isVisible, out System.Single @height)
        {
			@height = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isDirty, @isVisible, @height};
            var ___result = RMGetOptimizedGUIBlock_Boolean_Boolean_Out_Single.Invoke(___genericsType, ___parameters);
			@height = ReflectionUtils.Convert<System.Single>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean OnOptimizedInspectorGUI(UnityEngine.Rect @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentRect};
            var ___result = RMOnOptimizedInspectorGUI_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void DrawPropertiesExcluding(UnityEditor.SerializedObject @obj, System.String[] @propertyToExclude)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @propertyToExclude};
            var ___result = RMDrawPropertiesExcluding_SerializedObject_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DrawDefaultInspector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawDefaultInspector.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean DoDrawDefaultInspector(UnityEditor.SerializedObject @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMDoDrawDefaultInspector_SerializedObject.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean DoDrawDefaultInspector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoDrawDefaultInspector.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnInspectorGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreateInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateInspectorGUI.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Boolean RequiresConstantRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRequiresConstantRepaint.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void DrawHeader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawHeader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHeaderGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnHeaderGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHeaderControlsGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnHeaderControlsGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowOpenButton(UnityEngine.Object[] @assets, System.Boolean @enableCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @enableCondition};
            var ___result = RMShowOpenButton_ObjectArray_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldHideOpenButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldHideOpenButton.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanOpenMultipleObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanOpenMultipleObjects.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ShouldTryToMakeEditableOnOpen()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldTryToMakeEditableOnOpen.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void OnHeaderIconGUI(UnityEngine.Rect @iconRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconRect};
            var ___result = RMOnHeaderIconGUI_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHeaderTitleGUI(UnityEngine.Rect @titleRect, System.String @header)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@titleRect, @header};
            var ___result = RMOnHeaderTitleGUI_Rect_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect DrawHeaderHelpAndSettingsGUI(UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RMDrawHeaderHelpAndSettingsGUI_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual void DrawHeaderFromInsideHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawHeaderFromInsideHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor @editor, System.String @header)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @header};
            var ___result = RMDrawHeaderGUI_Editor_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor @editor, System.String @header, System.Single @leftMargin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @header, @leftMargin};
            var ___result = RMDrawHeaderGUI_Editor_String_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static void CheckForMainObjectNameMismatch(UnityEditor.Editor @editor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor};
            var ___result = RMCheckForMainObjectNameMismatch_Editor.Invoke(___genericsType, ___parameters);

            
        }


        public static void DrawMismatchedNameNotification(UnityEditor.Editor @editor, System.String @expectedMainObjectName, System.String @mainObjectName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @expectedMainObjectName, @mainObjectName};
            var ___result = RMDrawMismatchedNameNotification_Editor_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void DrawNotification(UnityEngine.Texture @image, System.String @text, System.String @btnText, System.Action @onBtnClick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @text, @btnText, @onBtnClick};
            var ___result = RMDrawNotification_Texture_String_String_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawPostIconContent(UnityEngine.Rect @iconRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconRect};
            var ___result = RMDrawPostIconContent_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public static void DrawFoldoutInspector(UnityEngine.Object @target, ref UnityEditor.Editor @editor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @editor};
            var ___result = RMDrawFoldoutInspector_Object_Ref_Editor.Invoke(___genericsType, ___parameters);
			@editor = ReflectionUtils.Convert<UnityEditor.Editor>(___parameters[1]);

            
        }


        public virtual System.Boolean HasPreviewGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasPreviewGUI.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.GUIContent GetPreviewTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviewTitle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.GUIContent>(___result);
        }


        public virtual UnityEngine.Texture2D RenderStaticPreview(System.String @assetPath, UnityEngine.Object[] @subAssets, System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetPath, @subAssets, @width, @height};
            var ___result = RMRenderStaticPreview_String_ObjectArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Texture2D>(___result);
        }


        public virtual void OnPreviewGUI(UnityEngine.Rect @r, UnityEngine.GUIStyle @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = RMOnPreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInteractivePreviewGUI(UnityEngine.Rect @r, UnityEngine.GUIStyle @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = RMOnInteractivePreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnPreviewSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetInfoString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInfoString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void DrawPreview(UnityEngine.Rect @previewArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previewArea};
            var ___result = RMDrawPreview_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReloadPreviewInstances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReloadPreviewInstances.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanBeExpandedViaAFoldout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanBeExpandedViaAFoldout.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanBeExpandedViaAFoldoutWithoutUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanBeExpandedViaAFoldoutWithoutUpdate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsAppropriateFileOpenForEdit(UnityEngine.Object @assetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetObject};
            var ___result = RMIsAppropriateFileOpenForEdit_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsEnabled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsEnabled.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsOpenForEdit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsOpenForEdit.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UseDefaultMargins()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUseDefaultMargins.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Initialize(UnityEngine.Object[] @targets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targets};
            var ___result = RMInitialize_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNextTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNextTarget.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ResetTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAssetStoreInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAssetStoreInspectorGUI.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.Editor CreateEditorWithContextInternal(UnityEngine.Object[] @targetObjects, UnityEngine.Object @context, System.Type @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context, @editorType};
            var ___result = RMCreateEditorWithContextInternal_ObjectArray_Object_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEditor.Editor>(___result);
        }


        public static UnityEngine.Vector2 GetCurrentMousePosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCurrentMousePosition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual System.Int32 UnityEditor__2__IToolModeOwner__2__GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEditor__2__IToolModeOwner__2__GetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static void GetCurrentMousePosition_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetCurrentMousePosition_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
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
