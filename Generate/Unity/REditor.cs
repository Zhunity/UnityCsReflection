using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.Editor
	/// </summary>
    public partial class REditor : RMember //
    {

		/// <summary>
		/// UnityEngine.Object[] m_Targets
		/// </summary>
		protected RFieldArray<RUnityEngine.RObject> r_m_Targets;
		public virtual RFieldArray<RUnityEngine.RObject> Rm_Targets
		{
			get
			{
				if(r_m_Targets == null)
				{
					r_m_Targets = new(this, "m_Targets");
					r_m_Targets.SetBelong(this.instance);
				}
				return r_m_Targets;
			}
		}

		/// <summary>
		/// UnityEngine.Object m_Context
		/// </summary>
		protected RUnityEngine.RObject r_m_Context;
		public virtual RUnityEngine.RObject Rm_Context
		{
			get
			{
				if(r_m_Context == null)
				{
					r_m_Context = new(this, "m_Context");
					r_m_Context.SetBelong(this.instance);
				}
				return r_m_Context;
			}
		}

		/// <summary>
		/// System.Int32 m_IsDirty
		/// </summary>
		protected RField r_m_IsDirty;
		public virtual RField Rm_IsDirty
		{
			get
			{
				if(r_m_IsDirty == null)
				{
					r_m_IsDirty = new(this, "m_IsDirty");
					r_m_IsDirty.SetBelong(this.instance);
				}
				return r_m_IsDirty;
			}
		}

		/// <summary>
		/// System.Int32 m_ReferenceTargetIndex
		/// </summary>
		protected RField r_m_ReferenceTargetIndex;
		public virtual RField Rm_ReferenceTargetIndex
		{
			get
			{
				if(r_m_ReferenceTargetIndex == null)
				{
					r_m_ReferenceTargetIndex = new(this, "m_ReferenceTargetIndex");
					r_m_ReferenceTargetIndex.SetBelong(this.instance);
				}
				return r_m_ReferenceTargetIndex;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyHandlerCache m_PropertyHandlerCache
		/// </summary>
		protected RUnityEditor.RPropertyHandlerCache r_m_PropertyHandlerCache;
		public virtual RUnityEditor.RPropertyHandlerCache Rm_PropertyHandlerCache
		{
			get
			{
				if(r_m_PropertyHandlerCache == null)
				{
					r_m_PropertyHandlerCache = new(this, "m_PropertyHandlerCache");
					r_m_PropertyHandlerCache.SetBelong(this.instance);
				}
				return r_m_PropertyHandlerCache;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable m_DummyPreview
		/// </summary>
		protected RUnityEditor.RIPreviewable r_m_DummyPreview;
		public virtual RUnityEditor.RIPreviewable Rm_DummyPreview
		{
			get
			{
				if(r_m_DummyPreview == null)
				{
					r_m_DummyPreview = new(this, "m_DummyPreview");
					r_m_DummyPreview.SetBelong(this.instance);
				}
				return r_m_DummyPreview;
			}
		}

		/// <summary>
		/// UnityEditor.AudioFilterGUI m_AudioFilterGUI
		/// </summary>
		protected RUnityEditor.RAudioFilterGUI r_m_AudioFilterGUI;
		public virtual RUnityEditor.RAudioFilterGUI Rm_AudioFilterGUI
		{
			get
			{
				if(r_m_AudioFilterGUI == null)
				{
					r_m_AudioFilterGUI = new(this, "m_AudioFilterGUI");
					r_m_AudioFilterGUI.SetBelong(this.instance);
				}
				return r_m_AudioFilterGUI;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject m_SerializedObject
		/// </summary>
		protected RUnityEditor.RSerializedObject r_m_SerializedObject;
		public virtual RUnityEditor.RSerializedObject Rm_SerializedObject
		{
			get
			{
				if(r_m_SerializedObject == null)
				{
					r_m_SerializedObject = new(this, "m_SerializedObject");
					r_m_SerializedObject.SetBelong(this.instance);
				}
				return r_m_SerializedObject;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_EnabledProperty
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_m_EnabledProperty;
		public virtual RUnityEditor.RSerializedProperty Rm_EnabledProperty
		{
			get
			{
				if(r_m_EnabledProperty == null)
				{
					r_m_EnabledProperty = new(this, "m_EnabledProperty");
					r_m_EnabledProperty.SetBelong(this.instance);
				}
				return r_m_EnabledProperty;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode m_InspectorMode
		/// </summary>
		protected RField r_m_InspectorMode;
		public virtual RField Rm_InspectorMode
		{
			get
			{
				if(r_m_InspectorMode == null)
				{
					r_m_InspectorMode = new(this, "m_InspectorMode");
					r_m_InspectorMode.SetBelong(this.instance);
				}
				return r_m_InspectorMode;
			}
		}

		/// <summary>
		/// System.Single kLineHeight
		/// </summary>
		protected static RField r_kLineHeight;
		public static RField RkLineHeight
		{
			get
			{
				if(r_kLineHeight == null)
				{
					r_kLineHeight = new(typeof(UnityEditor.Editor), "kLineHeight");
					r_kLineHeight.SetBelong(null);
				}
				return r_kLineHeight;
			}
		}

		/// <summary>
		/// System.Boolean hideInspector
		/// </summary>
		protected RField r_hideInspector;
		public virtual RField RhideInspector
		{
			get
			{
				if(r_hideInspector == null)
				{
					r_hideInspector = new(this, "hideInspector");
					r_hideInspector.SetBelong(this.instance);
				}
				return r_hideInspector;
			}
		}

		/// <summary>
		/// System.Single kImageSectionWidth
		/// </summary>
		protected static RField r_kImageSectionWidth;
		public static RField RkImageSectionWidth
		{
			get
			{
				if(r_kImageSectionWidth == null)
				{
					r_kImageSectionWidth = new(typeof(UnityEditor.Editor), "kImageSectionWidth");
					r_kImageSectionWidth.SetBelong(null);
				}
				return r_kImageSectionWidth;
			}
		}

		/// <summary>
		/// System.Single k_WideModeMinWidth
		/// </summary>
		protected static RField r_k_WideModeMinWidth;
		public static RField Rk_WideModeMinWidth
		{
			get
			{
				if(r_k_WideModeMinWidth == null)
				{
					r_k_WideModeMinWidth = new(typeof(UnityEditor.Editor), "k_WideModeMinWidth");
					r_k_WideModeMinWidth.SetBelong(null);
				}
				return r_k_WideModeMinWidth;
			}
		}

		/// <summary>
		/// System.Single k_HeaderHeight
		/// </summary>
		protected static RField r_k_HeaderHeight;
		public static RField Rk_HeaderHeight
		{
			get
			{
				if(r_k_HeaderHeight == null)
				{
					r_k_HeaderHeight = new(typeof(UnityEditor.Editor), "k_HeaderHeight");
					r_k_HeaderHeight.SetBelong(null);
				}
				return r_k_HeaderHeight;
			}
		}

		/// <summary>
		/// UnityEditor.Editor+OnEditorGUIDelegate OnPostIconGUI
		/// </summary>
		protected static RUnityEditor.REditor.ROnEditorGUIDelegate r_OnPostIconGUI;
		public static RUnityEditor.REditor.ROnEditorGUIDelegate ROnPostIconGUI
		{
			get
			{
				if(r_OnPostIconGUI == null)
				{
					r_OnPostIconGUI = new(typeof(UnityEditor.Editor), "OnPostIconGUI");
					r_OnPostIconGUI.SetBelong(null);
				}
				return r_OnPostIconGUI;
			}
		}

		/// <summary>
		/// System.Boolean m_AllowMultiObjectAccess
		/// </summary>
		protected static RField r_m_AllowMultiObjectAccess;
		public static RField Rm_AllowMultiObjectAccess
		{
			get
			{
				if(r_m_AllowMultiObjectAccess == null)
				{
					r_m_AllowMultiObjectAccess = new(typeof(UnityEditor.Editor), "m_AllowMultiObjectAccess");
					r_m_AllowMultiObjectAccess.SetBelong(null);
				}
				return r_m_AllowMultiObjectAccess;
			}
		}

		/// <summary>
		/// System.Boolean m_HasUnsavedChanges
		/// </summary>
		protected RField r_m_HasUnsavedChanges;
		public virtual RField Rm_HasUnsavedChanges
		{
			get
			{
				if(r_m_HasUnsavedChanges == null)
				{
					r_m_HasUnsavedChanges = new(this, "m_HasUnsavedChanges");
					r_m_HasUnsavedChanges.SetBelong(this.instance);
				}
				return r_m_HasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String <saveChangesMessage>k__BackingField
		/// </summary>
		protected RField r___1__saveChangesMessage__2__k__BackingField;
		public virtual RField R__1__saveChangesMessage__2__k__BackingField
		{
			get
			{
				if(r___1__saveChangesMessage__2__k__BackingField == null)
				{
					r___1__saveChangesMessage__2__k__BackingField = new(this, "<saveChangesMessage>k__BackingField");
					r___1__saveChangesMessage__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__saveChangesMessage__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <firstInspectedEditor>k__BackingField
		/// </summary>
		protected RField r___1__firstInspectedEditor__2__k__BackingField;
		public virtual RField R__1__firstInspectedEditor__2__k__BackingField
		{
			get
			{
				if(r___1__firstInspectedEditor__2__k__BackingField == null)
				{
					r___1__firstInspectedEditor__2__k__BackingField = new(this, "<firstInspectedEditor>k__BackingField");
					r___1__firstInspectedEditor__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__firstInspectedEditor__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.IPropertyView <propertyViewer>k__BackingField
		/// </summary>
		protected RUnityEditor.RIPropertyView r___1__propertyViewer__2__k__BackingField;
		public virtual RUnityEditor.RIPropertyView R__1__propertyViewer__2__k__BackingField
		{
			get
			{
				if(r___1__propertyViewer__2__k__BackingField == null)
				{
					r___1__propertyViewer__2__k__BackingField = new(this, "<propertyViewer>k__BackingField");
					r___1__propertyViewer__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__propertyViewer__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Editor] finishedDefaultHeaderGUI
		/// </summary>
		protected static RSystem.RAction<RUnityEditor.REditor> r_finishedDefaultHeaderGUI;
		public static RSystem.RAction<RUnityEditor.REditor> RfinishedDefaultHeaderGUI
		{
			get
			{
				if(r_finishedDefaultHeaderGUI == null)
				{
					r_finishedDefaultHeaderGUI = new(typeof(UnityEditor.Editor), "finishedDefaultHeaderGUI");
					r_finishedDefaultHeaderGUI.SetBelong(null);
				}
				return r_finishedDefaultHeaderGUI;
			}
		}

		/// <summary>
		/// System.Boolean <alwaysAllowExpansion>k__BackingField
		/// </summary>
		protected RField r___1__alwaysAllowExpansion__2__k__BackingField;
		public virtual RField R__1__alwaysAllowExpansion__2__k__BackingField
		{
			get
			{
				if(r___1__alwaysAllowExpansion__2__k__BackingField == null)
				{
					r___1__alwaysAllowExpansion__2__k__BackingField = new(this, "<alwaysAllowExpansion>k__BackingField");
					r___1__alwaysAllowExpansion__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__alwaysAllowExpansion__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode inspectorMode
		/// </summary>
		protected RProperty r_inspectorMode;
		public virtual RProperty RinspectorMode
		{
			get
			{
				if(r_inspectorMode == null)
				{
					r_inspectorMode = new(this, "inspectorMode", -1);
					r_inspectorMode.SetBelong(this.instance);
				}
				return r_inspectorMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode dataMode
		/// </summary>
		protected RProperty r_dataMode;
		public virtual RProperty RdataMode
		{
			get
			{
				if(r_dataMode == null)
				{
					r_dataMode = new(this, "dataMode", -1);
					r_dataMode.SetBelong(this.instance);
				}
				return r_dataMode;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected RProperty r_hasUnsavedChanges;
		public virtual RProperty RhasUnsavedChanges
		{
			get
			{
				if(r_hasUnsavedChanges == null)
				{
					r_hasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
					r_hasUnsavedChanges.SetBelong(this.instance);
				}
				return r_hasUnsavedChanges;
			}
		}

		/// <summary>
		/// System.String saveChangesMessage
		/// </summary>
		protected RProperty r_saveChangesMessage;
		public virtual RProperty RsaveChangesMessage
		{
			get
			{
				if(r_saveChangesMessage == null)
				{
					r_saveChangesMessage = new(this, "saveChangesMessage", -1);
					r_saveChangesMessage.SetBelong(this.instance);
				}
				return r_saveChangesMessage;
			}
		}

		/// <summary>
		/// Boolean firstInspectedEditor
		/// </summary>
		protected RProperty r_firstInspectedEditor;
		public virtual RProperty RfirstInspectedEditor
		{
			get
			{
				if(r_firstInspectedEditor == null)
				{
					r_firstInspectedEditor = new(this, "firstInspectedEditor", -1);
					r_firstInspectedEditor.SetBelong(this.instance);
				}
				return r_firstInspectedEditor;
			}
		}

		/// <summary>
		/// UnityEditor.IPropertyView propertyViewer
		/// </summary>
		protected RUnityEditor.RIPropertyView r_propertyViewer;
		public virtual RUnityEditor.RIPropertyView RpropertyViewer
		{
			get
			{
				if(r_propertyViewer == null)
				{
					r_propertyViewer = new(this, "propertyViewer", -1);
					r_propertyViewer.SetBelong(this.instance);
				}
				return r_propertyViewer;
			}
		}

		/// <summary>
		/// Boolean canEditMultipleObjects
		/// </summary>
		protected RProperty r_canEditMultipleObjects;
		public virtual RProperty RcanEditMultipleObjects
		{
			get
			{
				if(r_canEditMultipleObjects == null)
				{
					r_canEditMultipleObjects = new(this, "canEditMultipleObjects", -1);
					r_canEditMultipleObjects.SetBelong(this.instance);
				}
				return r_canEditMultipleObjects;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable preview
		/// </summary>
		protected RUnityEditor.RIPreviewable r_preview;
		public virtual RUnityEditor.RIPreviewable Rpreview
		{
			get
			{
				if(r_preview == null)
				{
					r_preview = new(this, "preview", -1);
					r_preview.SetBelong(this.instance);
				}
				return r_preview;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyHandlerCache propertyHandlerCache
		/// </summary>
		protected RUnityEditor.RPropertyHandlerCache r_propertyHandlerCache;
		public virtual RUnityEditor.RPropertyHandlerCache RpropertyHandlerCache
		{
			get
			{
				if(r_propertyHandlerCache == null)
				{
					r_propertyHandlerCache = new(this, "propertyHandlerCache", -1);
					r_propertyHandlerCache.SetBelong(this.instance);
				}
				return r_propertyHandlerCache;
			}
		}

		/// <summary>
		/// Boolean UnityEditor.IToolModeOwner.areToolModesAvailable
		/// </summary>
		protected RProperty r_RUnityEditor__0__IToolModeOwner__0__get_areToolModesAvailable;
		public virtual RProperty RUnityEditor__0__IToolModeOwner__0__get_areToolModesAvailable
		{
			get
			{
				if(r_RUnityEditor__0__IToolModeOwner__0__get_areToolModesAvailable == null)
				{
					r_RUnityEditor__0__IToolModeOwner__0__get_areToolModesAvailable = new(this, "UnityEditor.IToolModeOwner.areToolModesAvailable", -1);
					r_RUnityEditor__0__IToolModeOwner__0__get_areToolModesAvailable.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IToolModeOwner__0__get_areToolModesAvailable;
			}
		}

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected RUnityEngine.RObject r_target;
		public virtual RUnityEngine.RObject Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target", -1);
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] targets
		/// </summary>
		protected RPropertyArray<RUnityEngine.RObject> r_targets;
		public virtual RPropertyArray<RUnityEngine.RObject> Rtargets
		{
			get
			{
				if(r_targets == null)
				{
					r_targets = new(this, "targets", -1);
					r_targets.SetBelong(this.instance);
				}
				return r_targets;
			}
		}

		/// <summary>
		/// Int32 referenceTargetIndex
		/// </summary>
		protected RProperty r_referenceTargetIndex;
		public virtual RProperty RreferenceTargetIndex
		{
			get
			{
				if(r_referenceTargetIndex == null)
				{
					r_referenceTargetIndex = new(this, "referenceTargetIndex", -1);
					r_referenceTargetIndex.SetBelong(this.instance);
				}
				return r_referenceTargetIndex;
			}
		}

		/// <summary>
		/// System.String targetTitle
		/// </summary>
		protected RProperty r_targetTitle;
		public virtual RProperty RtargetTitle
		{
			get
			{
				if(r_targetTitle == null)
				{
					r_targetTitle = new(this, "targetTitle", -1);
					r_targetTitle.SetBelong(this.instance);
				}
				return r_targetTitle;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject serializedObject
		/// </summary>
		protected RUnityEditor.RSerializedObject r_serializedObject;
		public virtual RUnityEditor.RSerializedObject RserializedObject
		{
			get
			{
				if(r_serializedObject == null)
				{
					r_serializedObject = new(this, "serializedObject", -1);
					r_serializedObject.SetBelong(this.instance);
				}
				return r_serializedObject;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty enabledProperty
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_enabledProperty;
		public virtual RUnityEditor.RSerializedProperty RenabledProperty
		{
			get
			{
				if(r_enabledProperty == null)
				{
					r_enabledProperty = new(this, "enabledProperty", -1);
					r_enabledProperty.SetBelong(this.instance);
				}
				return r_enabledProperty;
			}
		}

		/// <summary>
		/// Boolean isInspectorDirty
		/// </summary>
		protected RProperty r_isInspectorDirty;
		public virtual RProperty RisInspectorDirty
		{
			get
			{
				if(r_isInspectorDirty == null)
				{
					r_isInspectorDirty = new(this, "isInspectorDirty", -1);
					r_isInspectorDirty.SetBelong(this.instance);
				}
				return r_isInspectorDirty;
			}
		}

		/// <summary>
		/// Boolean alwaysAllowExpansion
		/// </summary>
		protected RProperty r_alwaysAllowExpansion;
		public virtual RProperty RalwaysAllowExpansion
		{
			get
			{
				if(r_alwaysAllowExpansion == null)
				{
					r_alwaysAllowExpansion = new(this, "alwaysAllowExpansion", -1);
					r_alwaysAllowExpansion.SetBelong(this.instance);
				}
				return r_alwaysAllowExpansion;
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
		/// Boolean GetHasUnsavedChanges()
		/// </summary>
		protected RMethod r_RGetHasUnsavedChanges;
		public virtual RMethod RGetHasUnsavedChanges
		{
			get
			{
				if(r_RGetHasUnsavedChanges == null)
				{
					r_RGetHasUnsavedChanges = new(this, "GetHasUnsavedChanges", 0);
					r_RGetHasUnsavedChanges.SetBelong(this.instance);
				}
				return r_RGetHasUnsavedChanges;
			}
		}

		/// <summary>
		/// Void SaveChanges()
		/// </summary>
		protected RMethod r_RSaveChanges;
		public virtual RMethod RSaveChanges
		{
			get
			{
				if(r_RSaveChanges == null)
				{
					r_RSaveChanges = new(this, "SaveChanges", 0);
					r_RSaveChanges.SetBelong(this.instance);
				}
				return r_RSaveChanges;
			}
		}

		/// <summary>
		/// Void DiscardChanges()
		/// </summary>
		protected RMethod r_RDiscardChanges;
		public virtual RMethod RDiscardChanges
		{
			get
			{
				if(r_RDiscardChanges == null)
				{
					r_RDiscardChanges = new(this, "DiscardChanges", 0);
					r_RDiscardChanges.SetBelong(this.instance);
				}
				return r_RDiscardChanges;
			}
		}

		/// <summary>
		/// Boolean HasLargeHeader()
		/// </summary>
		protected RMethod r_RHasLargeHeader;
		public virtual RMethod RHasLargeHeader
		{
			get
			{
				if(r_RHasLargeHeader == null)
				{
					r_RHasLargeHeader = new(this, "HasLargeHeader", 0);
					r_RHasLargeHeader.SetBelong(this.instance);
				}
				return r_RHasLargeHeader;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[], UnityEngine.Object, System.Type)
		/// </summary>
		protected static RMethod r_RCreateEditorWithContext_ObjectArray_Object_Type;
		public static RMethod RCreateEditorWithContext_ObjectArray_Object_Type
		{
			get
			{
				if(r_RCreateEditorWithContext_ObjectArray_Object_Type == null)
				{
					r_RCreateEditorWithContext_ObjectArray_Object_Type = new(typeof(UnityEditor.Editor), "CreateEditorWithContext", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object), typeof(System.Type));
					r_RCreateEditorWithContext_ObjectArray_Object_Type.SetBelong(null);
				}
				return r_RCreateEditorWithContext_ObjectArray_Object_Type;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[], UnityEngine.Object)
		/// </summary>
		protected static RMethod r_RCreateEditorWithContext_ObjectArray_Object;
		public static RMethod RCreateEditorWithContext_ObjectArray_Object
		{
			get
			{
				if(r_RCreateEditorWithContext_ObjectArray_Object == null)
				{
					r_RCreateEditorWithContext_ObjectArray_Object = new(typeof(UnityEditor.Editor), "CreateEditorWithContext", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object));
					r_RCreateEditorWithContext_ObjectArray_Object.SetBelong(null);
				}
				return r_RCreateEditorWithContext_ObjectArray_Object;
			}
		}

		/// <summary>
		/// Void CreateCachedEditorWithContext(UnityEngine.Object, UnityEngine.Object, System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor;
		public static RMethod RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor
		{
			get
			{
				if(r_RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor == null)
				{
					r_RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor = new(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", 0, typeof(UnityEngine.Object), typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
					r_RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor.SetBelong(null);
				}
				return r_RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// Void CreateCachedEditorWithContext(UnityEngine.Object[], UnityEngine.Object, System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor;
		public static RMethod RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor
		{
			get
			{
				if(r_RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor == null)
				{
					r_RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor = new(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
					r_RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor.SetBelong(null);
				}
				return r_RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// Void CreateCachedEditor(UnityEngine.Object, System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_RCreateCachedEditor_Object_Type_Ref_Editor;
		public static RMethod RCreateCachedEditor_Object_Type_Ref_Editor
		{
			get
			{
				if(r_RCreateCachedEditor_Object_Type_Ref_Editor == null)
				{
					r_RCreateCachedEditor_Object_Type_Ref_Editor = new(typeof(UnityEditor.Editor), "CreateCachedEditor", 0, typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
					r_RCreateCachedEditor_Object_Type_Ref_Editor.SetBelong(null);
				}
				return r_RCreateCachedEditor_Object_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// Void CreateCachedEditor(UnityEngine.Object[], System.Type, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_RCreateCachedEditor_ObjectArray_Type_Ref_Editor;
		public static RMethod RCreateCachedEditor_ObjectArray_Type_Ref_Editor
		{
			get
			{
				if(r_RCreateCachedEditor_ObjectArray_Type_Ref_Editor == null)
				{
					r_RCreateCachedEditor_ObjectArray_Type_Ref_Editor = new(typeof(UnityEditor.Editor), "CreateCachedEditor", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Type), typeof(UnityEditor.Editor).MakeByRefType());
					r_RCreateCachedEditor_ObjectArray_Type_Ref_Editor.SetBelong(null);
				}
				return r_RCreateCachedEditor_ObjectArray_Type_Ref_Editor;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_RCreateEditor_Object;
		public static RMethod RCreateEditor_Object
		{
			get
			{
				if(r_RCreateEditor_Object == null)
				{
					r_RCreateEditor_Object = new(typeof(UnityEditor.Editor), "CreateEditor", 0, typeof(UnityEngine.Object));
					r_RCreateEditor_Object.SetBelong(null);
				}
				return r_RCreateEditor_Object;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object, System.Type)
		/// </summary>
		protected static RMethod r_RCreateEditor_Object_Type;
		public static RMethod RCreateEditor_Object_Type
		{
			get
			{
				if(r_RCreateEditor_Object_Type == null)
				{
					r_RCreateEditor_Object_Type = new(typeof(UnityEditor.Editor), "CreateEditor", 0, typeof(UnityEngine.Object), typeof(System.Type));
					r_RCreateEditor_Object_Type.SetBelong(null);
				}
				return r_RCreateEditor_Object_Type;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object[])
		/// </summary>
		protected static RMethod r_RCreateEditor_ObjectArray;
		public static RMethod RCreateEditor_ObjectArray
		{
			get
			{
				if(r_RCreateEditor_ObjectArray == null)
				{
					r_RCreateEditor_ObjectArray = new(typeof(UnityEditor.Editor), "CreateEditor", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_RCreateEditor_ObjectArray.SetBelong(null);
				}
				return r_RCreateEditor_ObjectArray;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditor(UnityEngine.Object[], System.Type)
		/// </summary>
		protected static RMethod r_RCreateEditor_ObjectArray_Type;
		public static RMethod RCreateEditor_ObjectArray_Type
		{
			get
			{
				if(r_RCreateEditor_ObjectArray_Type == null)
				{
					r_RCreateEditor_ObjectArray_Type = new(typeof(UnityEditor.Editor), "CreateEditor", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Type));
					r_RCreateEditor_ObjectArray_Type.SetBelong(null);
				}
				return r_RCreateEditor_ObjectArray_Type;
			}
		}

		/// <summary>
		/// Void CleanupPropertyEditor()
		/// </summary>
		protected RMethod r_RCleanupPropertyEditor;
		public virtual RMethod RCleanupPropertyEditor
		{
			get
			{
				if(r_RCleanupPropertyEditor == null)
				{
					r_RCleanupPropertyEditor = new(this, "CleanupPropertyEditor", 0);
					r_RCleanupPropertyEditor.SetBelong(this.instance);
				}
				return r_RCleanupPropertyEditor;
			}
		}

		/// <summary>
		/// Void OnDisableINTERNAL()
		/// </summary>
		protected RMethod r_ROnDisableINTERNAL;
		public virtual RMethod ROnDisableINTERNAL
		{
			get
			{
				if(r_ROnDisableINTERNAL == null)
				{
					r_ROnDisableINTERNAL = new(this, "OnDisableINTERNAL", 0);
					r_ROnDisableINTERNAL.SetBelong(this.instance);
				}
				return r_ROnDisableINTERNAL;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject GetSerializedObjectInternal()
		/// </summary>
		protected RMethod r_RGetSerializedObjectInternal;
		public virtual RMethod RGetSerializedObjectInternal
		{
			get
			{
				if(r_RGetSerializedObjectInternal == null)
				{
					r_RGetSerializedObjectInternal = new(this, "GetSerializedObjectInternal", 0);
					r_RGetSerializedObjectInternal.SetBelong(this.instance);
				}
				return r_RGetSerializedObjectInternal;
			}
		}

		/// <summary>
		/// Void CreateSerializedObject()
		/// </summary>
		protected RMethod r_RCreateSerializedObject;
		public virtual RMethod RCreateSerializedObject
		{
			get
			{
				if(r_RCreateSerializedObject == null)
				{
					r_RCreateSerializedObject = new(this, "CreateSerializedObject", 0);
					r_RCreateSerializedObject.SetBelong(this.instance);
				}
				return r_RCreateSerializedObject;
			}
		}

		/// <summary>
		/// Void AssignCachedProperties[T](T, UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RAssignCachedProperties_GT_T_SerializedProperty;
		public static RMethod RAssignCachedProperties_GT_T_SerializedProperty
		{
			get
			{
				if(r_RAssignCachedProperties_GT_T_SerializedProperty == null)
				{
					r_RAssignCachedProperties_GT_T_SerializedProperty = new(typeof(UnityEditor.Editor), "AssignCachedProperties", 1, Type.MakeGenericMethodParameter(0), typeof(UnityEditor.SerializedProperty));
					r_RAssignCachedProperties_GT_T_SerializedProperty.SetBelong(null);
				}
				return r_RAssignCachedProperties_GT_T_SerializedProperty;
			}
		}

		/// <summary>
		/// Void InternalSetTargets(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_RInternalSetTargets_ObjectArray;
		public virtual RMethod RInternalSetTargets_ObjectArray
		{
			get
			{
				if(r_RInternalSetTargets_ObjectArray == null)
				{
					r_RInternalSetTargets_ObjectArray = new(this, "InternalSetTargets", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_RInternalSetTargets_ObjectArray.SetBelong(this.instance);
				}
				return r_RInternalSetTargets_ObjectArray;
			}
		}

		/// <summary>
		/// Void InternalSetHidden(Boolean)
		/// </summary>
		protected RMethod r_RInternalSetHidden_Boolean;
		public virtual RMethod RInternalSetHidden_Boolean
		{
			get
			{
				if(r_RInternalSetHidden_Boolean == null)
				{
					r_RInternalSetHidden_Boolean = new(this, "InternalSetHidden", 0, typeof(System.Boolean));
					r_RInternalSetHidden_Boolean.SetBelong(this.instance);
				}
				return r_RInternalSetHidden_Boolean;
			}
		}

		/// <summary>
		/// Void InternalSetContextObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RInternalSetContextObject_Object;
		public virtual RMethod RInternalSetContextObject_Object
		{
			get
			{
				if(r_RInternalSetContextObject_Object == null)
				{
					r_RInternalSetContextObject_Object = new(this, "InternalSetContextObject", 0, typeof(UnityEngine.Object));
					r_RInternalSetContextObject_Object.SetBelong(this.instance);
				}
				return r_RInternalSetContextObject_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds UnityEditor.IToolModeOwner.GetWorldBoundsOfTargets()
		/// </summary>
		protected RMethod r_RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets;
		public virtual RMethod RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets
		{
			get
			{
				if(r_RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets == null)
				{
					r_RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets = new(this, "UnityEditor.IToolModeOwner.GetWorldBoundsOfTargets", 0);
					r_RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds GetWorldBoundsOfTarget(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RGetWorldBoundsOfTarget_Object;
		public virtual RMethod RGetWorldBoundsOfTarget_Object
		{
			get
			{
				if(r_RGetWorldBoundsOfTarget_Object == null)
				{
					r_RGetWorldBoundsOfTarget_Object = new(this, "GetWorldBoundsOfTarget", 0, typeof(UnityEngine.Object));
					r_RGetWorldBoundsOfTarget_Object.SetBelong(this.instance);
				}
				return r_RGetWorldBoundsOfTarget_Object;
			}
		}

		/// <summary>
		/// Boolean UnityEditor.IToolModeOwner.ModeSurvivesSelectionChange(Int32)
		/// </summary>
		protected RMethod r_RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32;
		public virtual RMethod RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32
		{
			get
			{
				if(r_RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32 == null)
				{
					r_RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32 = new(this, "UnityEditor.IToolModeOwner.ModeSurvivesSelectionChange", 0, typeof(System.Int32));
					r_RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32;
			}
		}

		/// <summary>
		/// Void OnForceReloadInspector()
		/// </summary>
		protected RMethod r_ROnForceReloadInspector;
		public virtual RMethod ROnForceReloadInspector
		{
			get
			{
				if(r_ROnForceReloadInspector == null)
				{
					r_ROnForceReloadInspector = new(this, "OnForceReloadInspector", 0);
					r_ROnForceReloadInspector.SetBelong(this.instance);
				}
				return r_ROnForceReloadInspector;
			}
		}

		/// <summary>
		/// Boolean GetOptimizedGUIBlock(Boolean, Boolean, Single ByRef)
		/// </summary>
		protected RMethod r_RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single;
		public virtual RMethod RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single
		{
			get
			{
				if(r_RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single == null)
				{
					r_RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single = new(this, "GetOptimizedGUIBlock", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Single).MakeByRefType());
					r_RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single.SetBelong(this.instance);
				}
				return r_RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single;
			}
		}

		/// <summary>
		/// Boolean OnOptimizedInspectorGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROnOptimizedInspectorGUI_Rect;
		public virtual RMethod ROnOptimizedInspectorGUI_Rect
		{
			get
			{
				if(r_ROnOptimizedInspectorGUI_Rect == null)
				{
					r_ROnOptimizedInspectorGUI_Rect = new(this, "OnOptimizedInspectorGUI", 0, typeof(UnityEngine.Rect));
					r_ROnOptimizedInspectorGUI_Rect.SetBelong(this.instance);
				}
				return r_ROnOptimizedInspectorGUI_Rect;
			}
		}

		/// <summary>
		/// Void DrawPropertiesExcluding(UnityEditor.SerializedObject, System.String[])
		/// </summary>
		protected static RMethod r_RDrawPropertiesExcluding_SerializedObject_StringArray;
		public static RMethod RDrawPropertiesExcluding_SerializedObject_StringArray
		{
			get
			{
				if(r_RDrawPropertiesExcluding_SerializedObject_StringArray == null)
				{
					r_RDrawPropertiesExcluding_SerializedObject_StringArray = new(typeof(UnityEditor.Editor), "DrawPropertiesExcluding", 0, typeof(UnityEditor.SerializedObject), typeof(System.String).MakeArrayType());
					r_RDrawPropertiesExcluding_SerializedObject_StringArray.SetBelong(null);
				}
				return r_RDrawPropertiesExcluding_SerializedObject_StringArray;
			}
		}

		/// <summary>
		/// Boolean DrawDefaultInspector()
		/// </summary>
		protected RMethod r_RDrawDefaultInspector;
		public virtual RMethod RDrawDefaultInspector
		{
			get
			{
				if(r_RDrawDefaultInspector == null)
				{
					r_RDrawDefaultInspector = new(this, "DrawDefaultInspector", 0);
					r_RDrawDefaultInspector.SetBelong(this.instance);
				}
				return r_RDrawDefaultInspector;
			}
		}

		/// <summary>
		/// Boolean DoDrawDefaultInspector(UnityEditor.SerializedObject)
		/// </summary>
		protected static RMethod r_RDoDrawDefaultInspector_SerializedObject;
		public static RMethod RDoDrawDefaultInspector_SerializedObject
		{
			get
			{
				if(r_RDoDrawDefaultInspector_SerializedObject == null)
				{
					r_RDoDrawDefaultInspector_SerializedObject = new(typeof(UnityEditor.Editor), "DoDrawDefaultInspector", 0, typeof(UnityEditor.SerializedObject));
					r_RDoDrawDefaultInspector_SerializedObject.SetBelong(null);
				}
				return r_RDoDrawDefaultInspector_SerializedObject;
			}
		}

		/// <summary>
		/// Boolean DoDrawDefaultInspector()
		/// </summary>
		protected RMethod r_RDoDrawDefaultInspector;
		public virtual RMethod RDoDrawDefaultInspector
		{
			get
			{
				if(r_RDoDrawDefaultInspector == null)
				{
					r_RDoDrawDefaultInspector = new(this, "DoDrawDefaultInspector", 0);
					r_RDoDrawDefaultInspector.SetBelong(this.instance);
				}
				return r_RDoDrawDefaultInspector;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_RRepaint;
		public virtual RMethod RRepaint
		{
			get
			{
				if(r_RRepaint == null)
				{
					r_RRepaint = new(this, "Repaint", 0);
					r_RRepaint.SetBelong(this.instance);
				}
				return r_RRepaint;
			}
		}

		/// <summary>
		/// Void OnInspectorGUI()
		/// </summary>
		protected RMethod r_ROnInspectorGUI;
		public virtual RMethod ROnInspectorGUI
		{
			get
			{
				if(r_ROnInspectorGUI == null)
				{
					r_ROnInspectorGUI = new(this, "OnInspectorGUI", 0);
					r_ROnInspectorGUI.SetBelong(this.instance);
				}
				return r_ROnInspectorGUI;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateInspectorGUI()
		/// </summary>
		protected RMethod r_RCreateInspectorGUI;
		public virtual RMethod RCreateInspectorGUI
		{
			get
			{
				if(r_RCreateInspectorGUI == null)
				{
					r_RCreateInspectorGUI = new(this, "CreateInspectorGUI", 0);
					r_RCreateInspectorGUI.SetBelong(this.instance);
				}
				return r_RCreateInspectorGUI;
			}
		}

		/// <summary>
		/// Boolean RequiresConstantRepaint()
		/// </summary>
		protected RMethod r_RRequiresConstantRepaint;
		public virtual RMethod RRequiresConstantRepaint
		{
			get
			{
				if(r_RRequiresConstantRepaint == null)
				{
					r_RRequiresConstantRepaint = new(this, "RequiresConstantRepaint", 0);
					r_RRequiresConstantRepaint.SetBelong(this.instance);
				}
				return r_RRequiresConstantRepaint;
			}
		}

		/// <summary>
		/// Void DrawHeader()
		/// </summary>
		protected RMethod r_RDrawHeader;
		public virtual RMethod RDrawHeader
		{
			get
			{
				if(r_RDrawHeader == null)
				{
					r_RDrawHeader = new(this, "DrawHeader", 0);
					r_RDrawHeader.SetBelong(this.instance);
				}
				return r_RDrawHeader;
			}
		}

		/// <summary>
		/// Void OnHeaderGUI()
		/// </summary>
		protected RMethod r_ROnHeaderGUI;
		public virtual RMethod ROnHeaderGUI
		{
			get
			{
				if(r_ROnHeaderGUI == null)
				{
					r_ROnHeaderGUI = new(this, "OnHeaderGUI", 0);
					r_ROnHeaderGUI.SetBelong(this.instance);
				}
				return r_ROnHeaderGUI;
			}
		}

		/// <summary>
		/// Void OnHeaderControlsGUI()
		/// </summary>
		protected RMethod r_ROnHeaderControlsGUI;
		public virtual RMethod ROnHeaderControlsGUI
		{
			get
			{
				if(r_ROnHeaderControlsGUI == null)
				{
					r_ROnHeaderControlsGUI = new(this, "OnHeaderControlsGUI", 0);
					r_ROnHeaderControlsGUI.SetBelong(this.instance);
				}
				return r_ROnHeaderControlsGUI;
			}
		}

		/// <summary>
		/// Void ShowOpenButton(UnityEngine.Object[], Boolean)
		/// </summary>
		protected RMethod r_RShowOpenButton_ObjectArray_Boolean;
		public virtual RMethod RShowOpenButton_ObjectArray_Boolean
		{
			get
			{
				if(r_RShowOpenButton_ObjectArray_Boolean == null)
				{
					r_RShowOpenButton_ObjectArray_Boolean = new(this, "ShowOpenButton", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Boolean));
					r_RShowOpenButton_ObjectArray_Boolean.SetBelong(this.instance);
				}
				return r_RShowOpenButton_ObjectArray_Boolean;
			}
		}

		/// <summary>
		/// Boolean ShouldHideOpenButton()
		/// </summary>
		protected RMethod r_RShouldHideOpenButton;
		public virtual RMethod RShouldHideOpenButton
		{
			get
			{
				if(r_RShouldHideOpenButton == null)
				{
					r_RShouldHideOpenButton = new(this, "ShouldHideOpenButton", 0);
					r_RShouldHideOpenButton.SetBelong(this.instance);
				}
				return r_RShouldHideOpenButton;
			}
		}

		/// <summary>
		/// Boolean CanOpenMultipleObjects()
		/// </summary>
		protected RMethod r_RCanOpenMultipleObjects;
		public virtual RMethod RCanOpenMultipleObjects
		{
			get
			{
				if(r_RCanOpenMultipleObjects == null)
				{
					r_RCanOpenMultipleObjects = new(this, "CanOpenMultipleObjects", 0);
					r_RCanOpenMultipleObjects.SetBelong(this.instance);
				}
				return r_RCanOpenMultipleObjects;
			}
		}

		/// <summary>
		/// Boolean ShouldTryToMakeEditableOnOpen()
		/// </summary>
		protected RMethod r_RShouldTryToMakeEditableOnOpen;
		public virtual RMethod RShouldTryToMakeEditableOnOpen
		{
			get
			{
				if(r_RShouldTryToMakeEditableOnOpen == null)
				{
					r_RShouldTryToMakeEditableOnOpen = new(this, "ShouldTryToMakeEditableOnOpen", 0);
					r_RShouldTryToMakeEditableOnOpen.SetBelong(this.instance);
				}
				return r_RShouldTryToMakeEditableOnOpen;
			}
		}

		/// <summary>
		/// Void OnHeaderIconGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROnHeaderIconGUI_Rect;
		public virtual RMethod ROnHeaderIconGUI_Rect
		{
			get
			{
				if(r_ROnHeaderIconGUI_Rect == null)
				{
					r_ROnHeaderIconGUI_Rect = new(this, "OnHeaderIconGUI", 0, typeof(UnityEngine.Rect));
					r_ROnHeaderIconGUI_Rect.SetBelong(this.instance);
				}
				return r_ROnHeaderIconGUI_Rect;
			}
		}

		/// <summary>
		/// Void OnHeaderTitleGUI(UnityEngine.Rect, System.String)
		/// </summary>
		protected RMethod r_ROnHeaderTitleGUI_Rect_String;
		public virtual RMethod ROnHeaderTitleGUI_Rect_String
		{
			get
			{
				if(r_ROnHeaderTitleGUI_Rect_String == null)
				{
					r_ROnHeaderTitleGUI_Rect_String = new(this, "OnHeaderTitleGUI", 0, typeof(UnityEngine.Rect), typeof(System.String));
					r_ROnHeaderTitleGUI_Rect_String.SetBelong(this.instance);
				}
				return r_ROnHeaderTitleGUI_Rect_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rect DrawHeaderHelpAndSettingsGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RDrawHeaderHelpAndSettingsGUI_Rect;
		public virtual RMethod RDrawHeaderHelpAndSettingsGUI_Rect
		{
			get
			{
				if(r_RDrawHeaderHelpAndSettingsGUI_Rect == null)
				{
					r_RDrawHeaderHelpAndSettingsGUI_Rect = new(this, "DrawHeaderHelpAndSettingsGUI", 0, typeof(UnityEngine.Rect));
					r_RDrawHeaderHelpAndSettingsGUI_Rect.SetBelong(this.instance);
				}
				return r_RDrawHeaderHelpAndSettingsGUI_Rect;
			}
		}

		/// <summary>
		/// Void DrawHeaderFromInsideHierarchy()
		/// </summary>
		protected RMethod r_RDrawHeaderFromInsideHierarchy;
		public virtual RMethod RDrawHeaderFromInsideHierarchy
		{
			get
			{
				if(r_RDrawHeaderFromInsideHierarchy == null)
				{
					r_RDrawHeaderFromInsideHierarchy = new(this, "DrawHeaderFromInsideHierarchy", 0);
					r_RDrawHeaderFromInsideHierarchy.SetBelong(this.instance);
				}
				return r_RDrawHeaderFromInsideHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor, System.String)
		/// </summary>
		protected static RMethod r_RDrawHeaderGUI_Editor_String;
		public static RMethod RDrawHeaderGUI_Editor_String
		{
			get
			{
				if(r_RDrawHeaderGUI_Editor_String == null)
				{
					r_RDrawHeaderGUI_Editor_String = new(typeof(UnityEditor.Editor), "DrawHeaderGUI", 0, typeof(UnityEditor.Editor), typeof(System.String));
					r_RDrawHeaderGUI_Editor_String.SetBelong(null);
				}
				return r_RDrawHeaderGUI_Editor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor, System.String, Single)
		/// </summary>
		protected static RMethod r_RDrawHeaderGUI_Editor_String_Single;
		public static RMethod RDrawHeaderGUI_Editor_String_Single
		{
			get
			{
				if(r_RDrawHeaderGUI_Editor_String_Single == null)
				{
					r_RDrawHeaderGUI_Editor_String_Single = new(typeof(UnityEditor.Editor), "DrawHeaderGUI", 0, typeof(UnityEditor.Editor), typeof(System.String), typeof(System.Single));
					r_RDrawHeaderGUI_Editor_String_Single.SetBelong(null);
				}
				return r_RDrawHeaderGUI_Editor_String_Single;
			}
		}

		/// <summary>
		/// Void CheckForMainObjectNameMismatch(UnityEditor.Editor)
		/// </summary>
		protected static RMethod r_RCheckForMainObjectNameMismatch_Editor;
		public static RMethod RCheckForMainObjectNameMismatch_Editor
		{
			get
			{
				if(r_RCheckForMainObjectNameMismatch_Editor == null)
				{
					r_RCheckForMainObjectNameMismatch_Editor = new(typeof(UnityEditor.Editor), "CheckForMainObjectNameMismatch", 0, typeof(UnityEditor.Editor));
					r_RCheckForMainObjectNameMismatch_Editor.SetBelong(null);
				}
				return r_RCheckForMainObjectNameMismatch_Editor;
			}
		}

		/// <summary>
		/// Void DrawMismatchedNameNotification(UnityEditor.Editor, System.String, System.String)
		/// </summary>
		protected static RMethod r_RDrawMismatchedNameNotification_Editor_String_String;
		public static RMethod RDrawMismatchedNameNotification_Editor_String_String
		{
			get
			{
				if(r_RDrawMismatchedNameNotification_Editor_String_String == null)
				{
					r_RDrawMismatchedNameNotification_Editor_String_String = new(typeof(UnityEditor.Editor), "DrawMismatchedNameNotification", 0, typeof(UnityEditor.Editor), typeof(System.String), typeof(System.String));
					r_RDrawMismatchedNameNotification_Editor_String_String.SetBelong(null);
				}
				return r_RDrawMismatchedNameNotification_Editor_String_String;
			}
		}

		/// <summary>
		/// Void DrawNotification(UnityEngine.Texture, System.String, System.String, System.Action)
		/// </summary>
		protected static RMethod r_RDrawNotification_Texture_String_String_Action;
		public static RMethod RDrawNotification_Texture_String_String_Action
		{
			get
			{
				if(r_RDrawNotification_Texture_String_String_Action == null)
				{
					r_RDrawNotification_Texture_String_String_Action = new(typeof(UnityEditor.Editor), "DrawNotification", 0, typeof(UnityEngine.Texture), typeof(System.String), typeof(System.String), typeof(System.Action));
					r_RDrawNotification_Texture_String_String_Action.SetBelong(null);
				}
				return r_RDrawNotification_Texture_String_String_Action;
			}
		}

		/// <summary>
		/// Void DrawPostIconContent(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RDrawPostIconContent_Rect;
		public virtual RMethod RDrawPostIconContent_Rect
		{
			get
			{
				if(r_RDrawPostIconContent_Rect == null)
				{
					r_RDrawPostIconContent_Rect = new(this, "DrawPostIconContent", 0, typeof(UnityEngine.Rect));
					r_RDrawPostIconContent_Rect.SetBelong(this.instance);
				}
				return r_RDrawPostIconContent_Rect;
			}
		}

		/// <summary>
		/// Void DrawFoldoutInspector(UnityEngine.Object, UnityEditor.Editor ByRef)
		/// </summary>
		protected static RMethod r_RDrawFoldoutInspector_Object_Ref_Editor;
		public static RMethod RDrawFoldoutInspector_Object_Ref_Editor
		{
			get
			{
				if(r_RDrawFoldoutInspector_Object_Ref_Editor == null)
				{
					r_RDrawFoldoutInspector_Object_Ref_Editor = new(typeof(UnityEditor.Editor), "DrawFoldoutInspector", 0, typeof(UnityEngine.Object), typeof(UnityEditor.Editor).MakeByRefType());
					r_RDrawFoldoutInspector_Object_Ref_Editor.SetBelong(null);
				}
				return r_RDrawFoldoutInspector_Object_Ref_Editor;
			}
		}

		/// <summary>
		/// Boolean HasPreviewGUI()
		/// </summary>
		protected RMethod r_RHasPreviewGUI;
		public virtual RMethod RHasPreviewGUI
		{
			get
			{
				if(r_RHasPreviewGUI == null)
				{
					r_RHasPreviewGUI = new(this, "HasPreviewGUI", 0);
					r_RHasPreviewGUI.SetBelong(this.instance);
				}
				return r_RHasPreviewGUI;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetPreviewTitle()
		/// </summary>
		protected RMethod r_RGetPreviewTitle;
		public virtual RMethod RGetPreviewTitle
		{
			get
			{
				if(r_RGetPreviewTitle == null)
				{
					r_RGetPreviewTitle = new(this, "GetPreviewTitle", 0);
					r_RGetPreviewTitle.SetBelong(this.instance);
				}
				return r_RGetPreviewTitle;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D RenderStaticPreview(System.String, UnityEngine.Object[], Int32, Int32)
		/// </summary>
		protected RMethod r_RRenderStaticPreview_String_ObjectArray_Int32_Int32;
		public virtual RMethod RRenderStaticPreview_String_ObjectArray_Int32_Int32
		{
			get
			{
				if(r_RRenderStaticPreview_String_ObjectArray_Int32_Int32 == null)
				{
					r_RRenderStaticPreview_String_ObjectArray_Int32_Int32 = new(this, "RenderStaticPreview", 0, typeof(System.String), typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RRenderStaticPreview_String_ObjectArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRenderStaticPreview_String_ObjectArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void OnPreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_ROnPreviewGUI_Rect_GUIStyle;
		public virtual RMethod ROnPreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_ROnPreviewGUI_Rect_GUIStyle == null)
				{
					r_ROnPreviewGUI_Rect_GUIStyle = new(this, "OnPreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_ROnPreviewGUI_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_ROnPreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnInteractivePreviewGUI(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_ROnInteractivePreviewGUI_Rect_GUIStyle;
		public virtual RMethod ROnInteractivePreviewGUI_Rect_GUIStyle
		{
			get
			{
				if(r_ROnInteractivePreviewGUI_Rect_GUIStyle == null)
				{
					r_ROnInteractivePreviewGUI_Rect_GUIStyle = new(this, "OnInteractivePreviewGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_ROnInteractivePreviewGUI_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_ROnInteractivePreviewGUI_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void OnPreviewSettings()
		/// </summary>
		protected RMethod r_ROnPreviewSettings;
		public virtual RMethod ROnPreviewSettings
		{
			get
			{
				if(r_ROnPreviewSettings == null)
				{
					r_ROnPreviewSettings = new(this, "OnPreviewSettings", 0);
					r_ROnPreviewSettings.SetBelong(this.instance);
				}
				return r_ROnPreviewSettings;
			}
		}

		/// <summary>
		/// System.String GetInfoString()
		/// </summary>
		protected RMethod r_RGetInfoString;
		public virtual RMethod RGetInfoString
		{
			get
			{
				if(r_RGetInfoString == null)
				{
					r_RGetInfoString = new(this, "GetInfoString", 0);
					r_RGetInfoString.SetBelong(this.instance);
				}
				return r_RGetInfoString;
			}
		}

		/// <summary>
		/// Void DrawPreview(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RDrawPreview_Rect;
		public virtual RMethod RDrawPreview_Rect
		{
			get
			{
				if(r_RDrawPreview_Rect == null)
				{
					r_RDrawPreview_Rect = new(this, "DrawPreview", 0, typeof(UnityEngine.Rect));
					r_RDrawPreview_Rect.SetBelong(this.instance);
				}
				return r_RDrawPreview_Rect;
			}
		}

		/// <summary>
		/// Void ReloadPreviewInstances()
		/// </summary>
		protected RMethod r_RReloadPreviewInstances;
		public virtual RMethod RReloadPreviewInstances
		{
			get
			{
				if(r_RReloadPreviewInstances == null)
				{
					r_RReloadPreviewInstances = new(this, "ReloadPreviewInstances", 0);
					r_RReloadPreviewInstances.SetBelong(this.instance);
				}
				return r_RReloadPreviewInstances;
			}
		}

		/// <summary>
		/// Boolean CanBeExpandedViaAFoldout()
		/// </summary>
		protected RMethod r_RCanBeExpandedViaAFoldout;
		public virtual RMethod RCanBeExpandedViaAFoldout
		{
			get
			{
				if(r_RCanBeExpandedViaAFoldout == null)
				{
					r_RCanBeExpandedViaAFoldout = new(this, "CanBeExpandedViaAFoldout", 0);
					r_RCanBeExpandedViaAFoldout.SetBelong(this.instance);
				}
				return r_RCanBeExpandedViaAFoldout;
			}
		}

		/// <summary>
		/// Boolean CanBeExpandedViaAFoldoutWithoutUpdate()
		/// </summary>
		protected RMethod r_RCanBeExpandedViaAFoldoutWithoutUpdate;
		public virtual RMethod RCanBeExpandedViaAFoldoutWithoutUpdate
		{
			get
			{
				if(r_RCanBeExpandedViaAFoldoutWithoutUpdate == null)
				{
					r_RCanBeExpandedViaAFoldoutWithoutUpdate = new(this, "CanBeExpandedViaAFoldoutWithoutUpdate", 0);
					r_RCanBeExpandedViaAFoldoutWithoutUpdate.SetBelong(this.instance);
				}
				return r_RCanBeExpandedViaAFoldoutWithoutUpdate;
			}
		}

		/// <summary>
		/// Boolean IsAppropriateFileOpenForEdit(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_RIsAppropriateFileOpenForEdit_Object;
		public static RMethod RIsAppropriateFileOpenForEdit_Object
		{
			get
			{
				if(r_RIsAppropriateFileOpenForEdit_Object == null)
				{
					r_RIsAppropriateFileOpenForEdit_Object = new(typeof(UnityEditor.Editor), "IsAppropriateFileOpenForEdit", 0, typeof(UnityEngine.Object));
					r_RIsAppropriateFileOpenForEdit_Object.SetBelong(null);
				}
				return r_RIsAppropriateFileOpenForEdit_Object;
			}
		}

		/// <summary>
		/// Boolean IsEnabled()
		/// </summary>
		protected RMethod r_RIsEnabled;
		public virtual RMethod RIsEnabled
		{
			get
			{
				if(r_RIsEnabled == null)
				{
					r_RIsEnabled = new(this, "IsEnabled", 0);
					r_RIsEnabled.SetBelong(this.instance);
				}
				return r_RIsEnabled;
			}
		}

		/// <summary>
		/// Boolean IsOpenForEdit()
		/// </summary>
		protected RMethod r_RIsOpenForEdit;
		public virtual RMethod RIsOpenForEdit
		{
			get
			{
				if(r_RIsOpenForEdit == null)
				{
					r_RIsOpenForEdit = new(this, "IsOpenForEdit", 0);
					r_RIsOpenForEdit.SetBelong(this.instance);
				}
				return r_RIsOpenForEdit;
			}
		}

		/// <summary>
		/// Boolean UseDefaultMargins()
		/// </summary>
		protected RMethod r_RUseDefaultMargins;
		public virtual RMethod RUseDefaultMargins
		{
			get
			{
				if(r_RUseDefaultMargins == null)
				{
					r_RUseDefaultMargins = new(this, "UseDefaultMargins", 0);
					r_RUseDefaultMargins.SetBelong(this.instance);
				}
				return r_RUseDefaultMargins;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_RInitialize_ObjectArray;
		public virtual RMethod RInitialize_ObjectArray
		{
			get
			{
				if(r_RInitialize_ObjectArray == null)
				{
					r_RInitialize_ObjectArray = new(this, "Initialize", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_RInitialize_ObjectArray.SetBelong(this.instance);
				}
				return r_RInitialize_ObjectArray;
			}
		}

		/// <summary>
		/// Void Cleanup()
		/// </summary>
		protected RMethod r_RCleanup;
		public virtual RMethod RCleanup
		{
			get
			{
				if(r_RCleanup == null)
				{
					r_RCleanup = new(this, "Cleanup", 0);
					r_RCleanup.SetBelong(this.instance);
				}
				return r_RCleanup;
			}
		}

		/// <summary>
		/// Boolean MoveNextTarget()
		/// </summary>
		protected RMethod r_RMoveNextTarget;
		public virtual RMethod RMoveNextTarget
		{
			get
			{
				if(r_RMoveNextTarget == null)
				{
					r_RMoveNextTarget = new(this, "MoveNextTarget", 0);
					r_RMoveNextTarget.SetBelong(this.instance);
				}
				return r_RMoveNextTarget;
			}
		}

		/// <summary>
		/// Void ResetTarget()
		/// </summary>
		protected RMethod r_RResetTarget;
		public virtual RMethod RResetTarget
		{
			get
			{
				if(r_RResetTarget == null)
				{
					r_RResetTarget = new(this, "ResetTarget", 0);
					r_RResetTarget.SetBelong(this.instance);
				}
				return r_RResetTarget;
			}
		}

		/// <summary>
		/// Void OnAssetStoreInspectorGUI()
		/// </summary>
		protected RMethod r_ROnAssetStoreInspectorGUI;
		public virtual RMethod ROnAssetStoreInspectorGUI
		{
			get
			{
				if(r_ROnAssetStoreInspectorGUI == null)
				{
					r_ROnAssetStoreInspectorGUI = new(this, "OnAssetStoreInspectorGUI", 0);
					r_ROnAssetStoreInspectorGUI.SetBelong(this.instance);
				}
				return r_ROnAssetStoreInspectorGUI;
			}
		}

		/// <summary>
		/// UnityEditor.Editor CreateEditorWithContextInternal(UnityEngine.Object[], UnityEngine.Object, System.Type)
		/// </summary>
		protected static RMethod r_RCreateEditorWithContextInternal_ObjectArray_Object_Type;
		public static RMethod RCreateEditorWithContextInternal_ObjectArray_Object_Type
		{
			get
			{
				if(r_RCreateEditorWithContextInternal_ObjectArray_Object_Type == null)
				{
					r_RCreateEditorWithContextInternal_ObjectArray_Object_Type = new(typeof(UnityEditor.Editor), "CreateEditorWithContextInternal", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(UnityEngine.Object), typeof(System.Type));
					r_RCreateEditorWithContextInternal_ObjectArray_Object_Type.SetBelong(null);
				}
				return r_RCreateEditorWithContextInternal_ObjectArray_Object_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCurrentMousePosition()
		/// </summary>
		protected static RMethod r_RGetCurrentMousePosition;
		public static RMethod RGetCurrentMousePosition
		{
			get
			{
				if(r_RGetCurrentMousePosition == null)
				{
					r_RGetCurrentMousePosition = new(typeof(UnityEditor.Editor), "GetCurrentMousePosition", 0);
					r_RGetCurrentMousePosition.SetBelong(null);
				}
				return r_RGetCurrentMousePosition;
			}
		}

		/// <summary>
		/// Int32 UnityEditor.IToolModeOwner.GetInstanceID()
		/// </summary>
		protected RMethod r_RUnityEditor__0__IToolModeOwner__0__GetInstanceID;
		public virtual RMethod RUnityEditor__0__IToolModeOwner__0__GetInstanceID
		{
			get
			{
				if(r_RUnityEditor__0__IToolModeOwner__0__GetInstanceID == null)
				{
					r_RUnityEditor__0__IToolModeOwner__0__GetInstanceID = new(this, "UnityEditor.IToolModeOwner.GetInstanceID", 0);
					r_RUnityEditor__0__IToolModeOwner__0__GetInstanceID.SetBelong(this.instance);
				}
				return r_RUnityEditor__0__IToolModeOwner__0__GetInstanceID;
			}
		}

		/// <summary>
		/// Void GetCurrentMousePosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected static RMethod r_RGetCurrentMousePosition_Injected_Out_Vector2;
		public static RMethod RGetCurrentMousePosition_Injected_Out_Vector2
		{
			get
			{
				if(r_RGetCurrentMousePosition_Injected_Out_Vector2 == null)
				{
					r_RGetCurrentMousePosition_Injected_Out_Vector2 = new(typeof(UnityEditor.Editor), "GetCurrentMousePosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_RGetCurrentMousePosition_Injected_Out_Vector2.SetBelong(null);
				}
				return r_RGetCurrentMousePosition_Injected_Out_Vector2;
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

        public virtual System.Boolean GetHasUnsavedChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHasUnsavedChanges.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SaveChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DiscardChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDiscardChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasLargeHeader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasLargeHeader.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[]  @targetObjects, UnityEngine.Object  @context, System.Type  @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context, @editorType};
            var ___result = RCreateEditorWithContext_ObjectArray_Object_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static UnityEditor.Editor CreateEditorWithContext(UnityEngine.Object[]  @targetObjects, UnityEngine.Object  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context};
            var ___result = RCreateEditorWithContext_ObjectArray_Object.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static void CreateCachedEditorWithContext(UnityEngine.Object  @targetObject, UnityEngine.Object  @context, System.Type  @editorType, ref UnityEditor.Editor  @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject, @context, @editorType, @previousEditor};
            var ___result = RCreateCachedEditorWithContext_Object_Object_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			previousEditor = (UnityEditor.Editor)___parameters[3];

            
        }


        public static void CreateCachedEditorWithContext(UnityEngine.Object[]  @targetObjects, UnityEngine.Object  @context, System.Type  @editorType, ref UnityEditor.Editor  @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context, @editorType, @previousEditor};
            var ___result = RCreateCachedEditorWithContext_ObjectArray_Object_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			previousEditor = (UnityEditor.Editor)___parameters[3];

            
        }


        public static void CreateCachedEditor(UnityEngine.Object  @targetObject, System.Type  @editorType, ref UnityEditor.Editor  @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject, @editorType, @previousEditor};
            var ___result = RCreateCachedEditor_Object_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			previousEditor = (UnityEditor.Editor)___parameters[2];

            
        }


        public static void CreateCachedEditor(UnityEngine.Object[]  @targetObjects, System.Type  @editorType, ref UnityEditor.Editor  @previousEditor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @editorType, @previousEditor};
            var ___result = RCreateCachedEditor_ObjectArray_Type_Ref_Editor.Invoke(___genericsType, ___parameters);
			previousEditor = (UnityEditor.Editor)___parameters[2];

            
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object  @targetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject};
            var ___result = RCreateEditor_Object.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object  @targetObject, System.Type  @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject, @editorType};
            var ___result = RCreateEditor_Object_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object[]  @targetObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects};
            var ___result = RCreateEditor_ObjectArray.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static UnityEditor.Editor CreateEditor(UnityEngine.Object[]  @targetObjects, System.Type  @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @editorType};
            var ___result = RCreateEditor_ObjectArray_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public virtual void CleanupPropertyEditor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanupPropertyEditor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisableINTERNAL()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisableINTERNAL.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.SerializedObject GetSerializedObjectInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSerializedObjectInternal.Invoke(___genericsType, ___parameters);

            return (UnityEditor.SerializedObject)___result;
        }


        public virtual void CreateSerializedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateSerializedObject.Invoke(___genericsType, ___parameters);

            
        }


        public static void AssignCachedProperties<T>(T  @self, UnityEditor.SerializedProperty  @root) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@self, @root};
            var ___result = RAssignCachedProperties_GT_T_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetTargets(UnityEngine.Object[]  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RInternalSetTargets_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetHidden(System.Boolean  @hidden)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hidden};
            var ___result = RInternalSetHidden_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalSetContextObject(UnityEngine.Object  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RInternalSetContextObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Bounds UnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEditor__0__IToolModeOwner__0__GetWorldBoundsOfTargets.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Bounds)___result;
        }


        public virtual UnityEngine.Bounds GetWorldBoundsOfTarget(UnityEngine.Object  @targetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject};
            var ___result = RGetWorldBoundsOfTarget_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Bounds)___result;
        }


        public virtual System.Boolean UnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange(System.Int32  @toolMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toolMode};
            var ___result = RUnityEditor__0__IToolModeOwner__0__ModeSurvivesSelectionChange_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnForceReloadInspector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnForceReloadInspector.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetOptimizedGUIBlock(System.Boolean  @isDirty, System.Boolean  @isVisible, out System.Single  @height)
        {
			height = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isDirty, @isVisible, @height};
            var ___result = RGetOptimizedGUIBlock_Boolean_Boolean_Out_Single.Invoke(___genericsType, ___parameters);
			height = (System.Single)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean OnOptimizedInspectorGUI(UnityEngine.Rect  @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentRect};
            var ___result = ROnOptimizedInspectorGUI_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void DrawPropertiesExcluding(UnityEditor.SerializedObject  @obj, System.String[]  @propertyToExclude)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @propertyToExclude};
            var ___result = RDrawPropertiesExcluding_SerializedObject_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DrawDefaultInspector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawDefaultInspector.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean DoDrawDefaultInspector(UnityEditor.SerializedObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RDoDrawDefaultInspector_SerializedObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DoDrawDefaultInspector()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoDrawDefaultInspector.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnInspectorGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreateInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateInspectorGUI.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean RequiresConstantRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequiresConstantRepaint.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DrawHeader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawHeader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHeaderGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnHeaderGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHeaderControlsGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnHeaderControlsGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowOpenButton(UnityEngine.Object[]  @assets, System.Boolean  @enableCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @enableCondition};
            var ___result = RShowOpenButton_ObjectArray_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldHideOpenButton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldHideOpenButton.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanOpenMultipleObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanOpenMultipleObjects.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldTryToMakeEditableOnOpen()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldTryToMakeEditableOnOpen.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnHeaderIconGUI(UnityEngine.Rect  @iconRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconRect};
            var ___result = ROnHeaderIconGUI_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnHeaderTitleGUI(UnityEngine.Rect  @titleRect, System.String  @header)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@titleRect, @header};
            var ___result = ROnHeaderTitleGUI_Rect_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect DrawHeaderHelpAndSettingsGUI(UnityEngine.Rect  @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RDrawHeaderHelpAndSettingsGUI_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void DrawHeaderFromInsideHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawHeaderFromInsideHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor  @editor, System.String  @header)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @header};
            var ___result = RDrawHeaderGUI_Editor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect DrawHeaderGUI(UnityEditor.Editor  @editor, System.String  @header, System.Single  @leftMargin)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @header, @leftMargin};
            var ___result = RDrawHeaderGUI_Editor_String_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static void CheckForMainObjectNameMismatch(UnityEditor.Editor  @editor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor};
            var ___result = RCheckForMainObjectNameMismatch_Editor.Invoke(___genericsType, ___parameters);

            
        }


        public static void DrawMismatchedNameNotification(UnityEditor.Editor  @editor, System.String  @expectedMainObjectName, System.String  @mainObjectName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @expectedMainObjectName, @mainObjectName};
            var ___result = RDrawMismatchedNameNotification_Editor_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void DrawNotification(UnityEngine.Texture  @image, System.String  @text, System.String  @btnText, System.Action  @onBtnClick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @text, @btnText, @onBtnClick};
            var ___result = RDrawNotification_Texture_String_String_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawPostIconContent(UnityEngine.Rect  @iconRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconRect};
            var ___result = RDrawPostIconContent_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public static void DrawFoldoutInspector(UnityEngine.Object  @target, ref UnityEditor.Editor  @editor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @editor};
            var ___result = RDrawFoldoutInspector_Object_Ref_Editor.Invoke(___genericsType, ___parameters);
			editor = (UnityEditor.Editor)___parameters[1];

            
        }


        public virtual System.Boolean HasPreviewGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasPreviewGUI.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.GUIContent GetPreviewTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreviewTitle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual UnityEngine.Texture2D RenderStaticPreview(System.String  @assetPath, UnityEngine.Object[]  @subAssets, System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetPath, @subAssets, @width, @height};
            var ___result = RRenderStaticPreview_String_ObjectArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void OnPreviewGUI(UnityEngine.Rect  @r, UnityEngine.GUIStyle  @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = ROnPreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInteractivePreviewGUI(UnityEngine.Rect  @r, UnityEngine.GUIStyle  @background)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @background};
            var ___result = ROnInteractivePreviewGUI_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPreviewSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnPreviewSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetInfoString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInfoString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void DrawPreview(UnityEngine.Rect  @previewArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previewArea};
            var ___result = RDrawPreview_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReloadPreviewInstances()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReloadPreviewInstances.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanBeExpandedViaAFoldout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanBeExpandedViaAFoldout.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanBeExpandedViaAFoldoutWithoutUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanBeExpandedViaAFoldoutWithoutUpdate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsAppropriateFileOpenForEdit(UnityEngine.Object  @assetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetObject};
            var ___result = RIsAppropriateFileOpenForEdit_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEnabled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEnabled.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsOpenForEdit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsOpenForEdit.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UseDefaultMargins()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUseDefaultMargins.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Initialize(UnityEngine.Object[]  @targets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targets};
            var ___result = RInitialize_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNextTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNextTarget.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ResetTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAssetStoreInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAssetStoreInspectorGUI.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.Editor CreateEditorWithContextInternal(UnityEngine.Object[]  @targetObjects, UnityEngine.Object  @context, System.Type  @editorType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObjects, @context, @editorType};
            var ___result = RCreateEditorWithContextInternal_ObjectArray_Object_Type.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static UnityEngine.Vector2 GetCurrentMousePosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentMousePosition.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 UnityEditor__0__IToolModeOwner__0__GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEditor__0__IToolModeOwner__0__GetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void GetCurrentMousePosition_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetCurrentMousePosition_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
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
