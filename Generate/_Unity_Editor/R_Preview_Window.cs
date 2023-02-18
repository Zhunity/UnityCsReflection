
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PreviewWindow
	/// </summary>
    public partial class RPreviewWindow : RMember //
    {

		/// <summary>
		/// UnityEditor.InspectorWindow m_ParentInspectorWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RInspectorWindow r_Fm_ParentInspectorWindow;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RInspectorWindow RFm_ParentInspectorWindow
		{
			get
			{
				if(r_Fm_ParentInspectorWindow == null)
				{
					r_Fm_ParentInspectorWindow = new(this, "m_ParentInspectorWindow");
					r_Fm_ParentInspectorWindow.SetBelong(this.GetValue());
				}
				return r_Fm_ParentInspectorWindow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_previewElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_previewElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_previewElement
		{
			get
			{
				if(r_Fm_previewElement == null)
				{
					r_Fm_previewElement = new(this, "m_previewElement");
					r_Fm_previewElement.SetBelong(this.GetValue());
				}
				return r_Fm_previewElement;
			}
		}

		/// <summary>
		/// System.Int64 m_LastUpdateWhilePlayingAnimation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_LastUpdateWhilePlayingAnimation;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_LastUpdateWhilePlayingAnimation
		{
			get
			{
				if(r_Fm_LastUpdateWhilePlayingAnimation == null)
				{
					r_Fm_LastUpdateWhilePlayingAnimation = new(this, "m_LastUpdateWhilePlayingAnimation");
					r_Fm_LastUpdateWhilePlayingAnimation.SetBelong(this.GetValue());
				}
				return r_Fm_LastUpdateWhilePlayingAnimation;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Object] m_ObjectsLockedBeforeSerialization
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Fm_ObjectsLockedBeforeSerialization;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RObject> RFm_ObjectsLockedBeforeSerialization
		{
			get
			{
				if(r_Fm_ObjectsLockedBeforeSerialization == null)
				{
					r_Fm_ObjectsLockedBeforeSerialization = new(this, "m_ObjectsLockedBeforeSerialization");
					r_Fm_ObjectsLockedBeforeSerialization.SetBelong(this.GetValue());
				}
				return r_Fm_ObjectsLockedBeforeSerialization;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_InstanceIDsLockedBeforeSerialization
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_InstanceIDsLockedBeforeSerialization;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_InstanceIDsLockedBeforeSerialization
		{
			get
			{
				if(r_Fm_InstanceIDsLockedBeforeSerialization == null)
				{
					r_Fm_InstanceIDsLockedBeforeSerialization = new(this, "m_InstanceIDsLockedBeforeSerialization");
					r_Fm_InstanceIDsLockedBeforeSerialization.SetBelong(this.GetValue());
				}
				return r_Fm_InstanceIDsLockedBeforeSerialization;
			}
		}

		/// <summary>
		/// UnityEditor.PreviewResizer m_PreviewResizer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPreviewResizer r_Fm_PreviewResizer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPreviewResizer RFm_PreviewResizer
		{
			get
			{
				if(r_Fm_PreviewResizer == null)
				{
					r_Fm_PreviewResizer = new(this, "m_PreviewResizer");
					r_Fm_PreviewResizer.SetBelong(this.GetValue());
				}
				return r_Fm_PreviewResizer;
			}
		}

		/// <summary>
		/// UnityEditor.LabelGUI m_LabelGUI
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RLabelGUI r_Fm_LabelGUI;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RLabelGUI RFm_LabelGUI
		{
			get
			{
				if(r_Fm_LabelGUI == null)
				{
					r_Fm_LabelGUI = new(this, "m_LabelGUI");
					r_Fm_LabelGUI.SetBelong(this.GetValue());
				}
				return r_Fm_LabelGUI;
			}
		}

		/// <summary>
		/// System.Int32 m_LastInspectedObjectInstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_LastInspectedObjectInstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_LastInspectedObjectInstanceID
		{
			get
			{
				if(r_Fm_LastInspectedObjectInstanceID == null)
				{
					r_Fm_LastInspectedObjectInstanceID = new(this, "m_LastInspectedObjectInstanceID");
					r_Fm_LastInspectedObjectInstanceID.SetBelong(this.GetValue());
				}
				return r_Fm_LastInspectedObjectInstanceID;
			}
		}

		/// <summary>
		/// System.Single m_LastVerticalScrollValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_LastVerticalScrollValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_LastVerticalScrollValue
		{
			get
			{
				if(r_Fm_LastVerticalScrollValue == null)
				{
					r_Fm_LastVerticalScrollValue = new(this, "m_LastVerticalScrollValue");
					r_Fm_LastVerticalScrollValue.SetBelong(this.GetValue());
				}
				return r_Fm_LastVerticalScrollValue;
			}
		}

		/// <summary>
		/// System.String m_GlobalObjectId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_GlobalObjectId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_GlobalObjectId
		{
			get
			{
				if(r_Fm_GlobalObjectId == null)
				{
					r_Fm_GlobalObjectId = new(this, "m_GlobalObjectId");
					r_Fm_GlobalObjectId.SetBelong(this.GetValue());
				}
				return r_Fm_GlobalObjectId;
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
					r_Fm_InspectorMode.SetBelong(this.GetValue());
				}
				return r_Fm_InspectorMode;
			}
		}

		/// <summary>
		/// System.Int32 m_LastInitialEditorInstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_LastInitialEditorInstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_LastInitialEditorInstanceID
		{
			get
			{
				if(r_Fm_LastInitialEditorInstanceID == null)
				{
					r_Fm_LastInitialEditorInstanceID = new(this, "m_LastInitialEditorInstanceID");
					r_Fm_LastInitialEditorInstanceID.SetBelong(this.GetValue());
				}
				return r_Fm_LastInitialEditorInstanceID;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] m_ComponentsInPrefabSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RComponent> r_Fm_ComponentsInPrefabSource;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RComponent> RFm_ComponentsInPrefabSource
		{
			get
			{
				if(r_Fm_ComponentsInPrefabSource == null)
				{
					r_Fm_ComponentsInPrefabSource = new(this, "m_ComponentsInPrefabSource");
					r_Fm_ComponentsInPrefabSource.SetBelong(this.GetValue());
				}
				return r_Fm_ComponentsInPrefabSource;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.Component] m_RemovedComponents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RComponent> r_Fm_RemovedComponents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RComponent> RFm_RemovedComponents
		{
			get
			{
				if(r_Fm_RemovedComponents == null)
				{
					r_Fm_RemovedComponents = new(this, "m_RemovedComponents");
					r_Fm_RemovedComponents.SetBelong(this.GetValue());
				}
				return r_Fm_RemovedComponents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.Component] m_SuppressedComponents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RComponent> r_Fm_SuppressedComponents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RComponent> RFm_SuppressedComponents
		{
			get
			{
				if(r_Fm_SuppressedComponents == null)
				{
					r_Fm_SuppressedComponents = new(this, "m_SuppressedComponents");
					r_Fm_SuppressedComponents.SetBelong(this.GetValue());
				}
				return r_Fm_SuppressedComponents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[UnityEngine.Component]] m_RemovedComponentDict
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RComponent>> r_Fm_RemovedComponentDict;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RComponent>> RFm_RemovedComponentDict
		{
			get
			{
				if(r_Fm_RemovedComponentDict == null)
				{
					r_Fm_RemovedComponentDict = new(this, "m_RemovedComponentDict");
					r_Fm_RemovedComponentDict.SetBelong(this.GetValue());
				}
				return r_Fm_RemovedComponentDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Component] m_AdditionalRemovedComponents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RComponent> r_Fm_AdditionalRemovedComponents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RComponent> RFm_AdditionalRemovedComponents
		{
			get
			{
				if(r_Fm_AdditionalRemovedComponents == null)
				{
					r_Fm_AdditionalRemovedComponents = new(this, "m_AdditionalRemovedComponents");
					r_Fm_AdditionalRemovedComponents.SetBelong(this.GetValue());
				}
				return r_Fm_AdditionalRemovedComponents;
			}
		}

		/// <summary>
		/// System.Boolean m_ResetKeyboardControl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ResetKeyboardControl;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ResetKeyboardControl
		{
			get
			{
				if(r_Fm_ResetKeyboardControl == null)
				{
					r_Fm_ResetKeyboardControl = new(this, "m_ResetKeyboardControl");
					r_Fm_ResetKeyboardControl.SetBelong(this.GetValue());
				}
				return r_Fm_ResetKeyboardControl;
			}
		}

		/// <summary>
		/// System.Boolean m_OpenAddComponentMenu
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_OpenAddComponentMenu;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_OpenAddComponentMenu
		{
			get
			{
				if(r_Fm_OpenAddComponentMenu == null)
				{
					r_Fm_OpenAddComponentMenu = new(this, "m_OpenAddComponentMenu");
					r_Fm_OpenAddComponentMenu.SetBelong(this.GetValue());
				}
				return r_Fm_OpenAddComponentMenu;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker m_Tracker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker r_Fm_Tracker;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker RFm_Tracker
		{
			get
			{
				if(r_Fm_Tracker == null)
				{
					r_Fm_Tracker = new(this, "m_Tracker");
					r_Fm_Tracker.SetBelong(this.GetValue());
				}
				return r_Fm_Tracker;
			}
		}

		/// <summary>
		/// UnityEditor.AssetBundleNameGUI m_AssetBundleNameGUI
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RAssetBundleNameGUI r_Fm_AssetBundleNameGUI;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RAssetBundleNameGUI RFm_AssetBundleNameGUI
		{
			get
			{
				if(r_Fm_AssetBundleNameGUI == null)
				{
					r_Fm_AssetBundleNameGUI = new(this, "m_AssetBundleNameGUI");
					r_Fm_AssetBundleNameGUI.SetBelong(this.GetValue());
				}
				return r_Fm_AssetBundleNameGUI;
			}
		}

		/// <summary>
		/// UnityEditor.TypeSelectionList m_TypeSelectionList
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RTypeSelectionList r_Fm_TypeSelectionList;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RTypeSelectionList RFm_TypeSelectionList
		{
			get
			{
				if(r_Fm_TypeSelectionList == null)
				{
					r_Fm_TypeSelectionList = new(this, "m_TypeSelectionList");
					r_Fm_TypeSelectionList.SetBelong(this.GetValue());
				}
				return r_Fm_TypeSelectionList;
			}
		}

		/// <summary>
		/// System.Double m_lastRenderedTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDouble r_Fm_lastRenderedTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RDouble RFm_lastRenderedTime
		{
			get
			{
				if(r_Fm_lastRenderedTime == null)
				{
					r_Fm_lastRenderedTime = new(this, "m_lastRenderedTime");
					r_Fm_lastRenderedTime.SetBelong(this.GetValue());
				}
				return r_Fm_lastRenderedTime;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.IPreviewable] m_Previews
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable> r_Fm_Previews;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable> RFm_Previews
		{
			get
			{
				if(r_Fm_Previews == null)
				{
					r_Fm_Previews = new(this, "m_Previews");
					r_Fm_Previews.SetBelong(this.GetValue());
				}
				return r_Fm_Previews;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Type,System.Collections.Generic.List`1[System.Type]] m_PreviewableTypes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RType>> r_Fm_PreviewableTypes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RType>> RFm_PreviewableTypes
		{
			get
			{
				if(r_Fm_PreviewableTypes == null)
				{
					r_Fm_PreviewableTypes = new(this, "m_PreviewableTypes");
					r_Fm_PreviewableTypes.SetBelong(this.GetValue());
				}
				return r_Fm_PreviewableTypes;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable m_SelectedPreview
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable r_Fm_SelectedPreview;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable RFm_SelectedPreview
		{
			get
			{
				if(r_Fm_SelectedPreview == null)
				{
					r_Fm_SelectedPreview = new(this, "m_SelectedPreview");
					r_Fm_SelectedPreview.SetBelong(this.GetValue());
				}
				return r_Fm_SelectedPreview;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_EditorsElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_EditorsElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_EditorsElement
		{
			get
			{
				if(r_Fm_EditorsElement == null)
				{
					r_Fm_EditorsElement = new(this, "m_EditorsElement");
					r_Fm_EditorsElement.SetBelong(this.GetValue());
				}
				return r_Fm_EditorsElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_RemovedPrefabComponentsElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_RemovedPrefabComponentsElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_RemovedPrefabComponentsElement
		{
			get
			{
				if(r_Fm_RemovedPrefabComponentsElement == null)
				{
					r_Fm_RemovedPrefabComponentsElement = new(this, "m_RemovedPrefabComponentsElement");
					r_Fm_RemovedPrefabComponentsElement.SetBelong(this.GetValue());
				}
				return r_Fm_RemovedPrefabComponentsElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_PreviewAndLabelElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_PreviewAndLabelElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_PreviewAndLabelElement
		{
			get
			{
				if(r_Fm_PreviewAndLabelElement == null)
				{
					r_Fm_PreviewAndLabelElement = new(this, "m_PreviewAndLabelElement");
					r_Fm_PreviewAndLabelElement.SetBelong(this.GetValue());
				}
				return r_Fm_PreviewAndLabelElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_VersionControlElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_VersionControlElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_VersionControlElement
		{
			get
			{
				if(r_Fm_VersionControlElement == null)
				{
					r_Fm_VersionControlElement = new(this, "m_VersionControlElement");
					r_Fm_VersionControlElement.SetBelong(this.GetValue());
				}
				return r_Fm_VersionControlElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_MultiEditLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_MultiEditLabel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_MultiEditLabel
		{
			get
			{
				if(r_Fm_MultiEditLabel == null)
				{
					r_Fm_MultiEditLabel = new(this, "m_MultiEditLabel");
					r_Fm_MultiEditLabel.SetBelong(this.GetValue());
				}
				return r_Fm_MultiEditLabel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView m_ScrollView
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView r_Fm_ScrollView;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScrollView RFm_ScrollView
		{
			get
			{
				if(r_Fm_ScrollView == null)
				{
					r_Fm_ScrollView = new(this, "m_ScrollView");
					r_Fm_ScrollView.SetBelong(this.GetValue());
				}
				return r_Fm_ScrollView;
			}
		}

		/// <summary>
		/// System.Boolean m_TrackerResetInserted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_TrackerResetInserted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_TrackerResetInserted
		{
			get
			{
				if(r_Fm_TrackerResetInserted == null)
				{
					r_Fm_TrackerResetInserted = new(this, "m_TrackerResetInserted");
					r_Fm_TrackerResetInserted.SetBelong(this.GetValue());
				}
				return r_Fm_TrackerResetInserted;
			}
		}

		/// <summary>
		/// System.Boolean m_FirstInitialize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_FirstInitialize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_FirstInitialize
		{
			get
			{
				if(r_Fm_FirstInitialize == null)
				{
					r_Fm_FirstInitialize = new(this, "m_FirstInitialize");
					r_Fm_FirstInitialize.SetBelong(this.GetValue());
				}
				return r_Fm_FirstInitialize;
			}
		}

		/// <summary>
		/// System.Single m_PreviousFooterHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_PreviousFooterHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_PreviousFooterHeight
		{
			get
			{
				if(r_Fm_PreviousFooterHeight == null)
				{
					r_Fm_PreviousFooterHeight = new(this, "m_PreviousFooterHeight");
					r_Fm_PreviousFooterHeight.SetBelong(this.GetValue());
				}
				return r_Fm_PreviousFooterHeight;
			}
		}

		/// <summary>
		/// System.Boolean m_PreviousPreviewExpandedState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_PreviousPreviewExpandedState;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_PreviousPreviewExpandedState
		{
			get
			{
				if(r_Fm_PreviousPreviewExpandedState == null)
				{
					r_Fm_PreviousPreviewExpandedState = new(this, "m_PreviousPreviewExpandedState");
					r_Fm_PreviousPreviewExpandedState.SetBelong(this.GetValue());
				}
				return r_Fm_PreviousPreviewExpandedState;
			}
		}

		/// <summary>
		/// System.Boolean m_HasPreview
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasPreview;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasPreview
		{
			get
			{
				if(r_Fm_HasPreview == null)
				{
					r_Fm_HasPreview = new(this, "m_HasPreview");
					r_Fm_HasPreview.SetBelong(this.GetValue());
				}
				return r_Fm_HasPreview;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] m_DrawnSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_DrawnSelection;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RFm_DrawnSelection
		{
			get
			{
				if(r_Fm_DrawnSelection == null)
				{
					r_Fm_DrawnSelection = new(this, "m_DrawnSelection");
					r_Fm_DrawnSelection.SetBelong(this.GetValue());
				}
				return r_Fm_DrawnSelection;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_TitleContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fm_TitleContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFm_TitleContent
		{
			get
			{
				if(r_Fm_TitleContent == null)
				{
					r_Fm_TitleContent = new(this, "m_TitleContent");
					r_Fm_TitleContent.SetBelong(this.GetValue());
				}
				return r_Fm_TitleContent;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_Pos
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_Pos;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_Pos
		{
			get
			{
				if(r_Fm_Pos == null)
				{
					r_Fm_Pos = new(this, "m_Pos");
					r_Fm_Pos.SetBelong(this.GetValue());
				}
				return r_Fm_Pos;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController m_SerializedDataModeController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataModeController r_Fm_SerializedDataModeController;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataModeController RFm_SerializedDataModeController
		{
			get
			{
				if(r_Fm_SerializedDataModeController == null)
				{
					r_Fm_SerializedDataModeController = new(this, "m_SerializedDataModeController");
					r_Fm_SerializedDataModeController.SetBelong(this.GetValue());
				}
				return r_Fm_SerializedDataModeController;
			}
		}

		/// <summary>
		/// UnityEditor.HostView m_Parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RHostView r_Fm_Parent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RHostView RFm_Parent
		{
			get
			{
				if(r_Fm_Parent == null)
				{
					r_Fm_Parent = new(this, "m_Parent");
					r_Fm_Parent.SetBelong(this.GetValue());
				}
				return r_Fm_Parent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_Notification
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Fm_Notification;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RFm_Notification
		{
			get
			{
				if(r_Fm_Notification == null)
				{
					r_Fm_Notification = new(this, "m_Notification");
					r_Fm_Notification.SetBelong(this.GetValue());
				}
				return r_Fm_Notification;
			}
		}

		/// <summary>
		/// System.Single m_FadeoutTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_FadeoutTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_FadeoutTime
		{
			get
			{
				if(r_Fm_FadeoutTime == null)
				{
					r_Fm_FadeoutTime = new(this, "m_FadeoutTime");
					r_Fm_FadeoutTime.SetBelong(this.GetValue());
				}
				return r_Fm_FadeoutTime;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement previewElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PpreviewElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPpreviewElement
		{
			get
			{
				if(r_PpreviewElement == null)
				{
					r_PpreviewElement = new(this, "previewElement", -1);
					r_PpreviewElement.SetBelong(this.GetValue());
				}
				return r_PpreviewElement;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisLocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisLocked
		{
			get
			{
				if(r_PisLocked == null)
				{
					r_PisLocked = new(this, "isLocked", -1);
					r_PisLocked.SetBelong(this.GetValue());
				}
				return r_PisLocked;
			}
		}

		/// <summary>
		/// Boolean isVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisVisible
		{
			get
			{
				if(r_PisVisible == null)
				{
					r_PisVisible = new(this, "isVisible", -1);
					r_PisVisible.SetBelong(this.GetValue());
				}
				return r_PisVisible;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement editorsElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PeditorsElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPeditorsElement
		{
			get
			{
				if(r_PeditorsElement == null)
				{
					r_PeditorsElement = new(this, "editorsElement", -1);
					r_PeditorsElement.SetBelong(this.GetValue());
				}
				return r_PeditorsElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement previewAndLabelElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PpreviewAndLabelElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPpreviewAndLabelElement
		{
			get
			{
				if(r_PpreviewAndLabelElement == null)
				{
					r_PpreviewAndLabelElement = new(this, "previewAndLabelElement", -1);
					r_PpreviewAndLabelElement.SetBelong(this.GetValue());
				}
				return r_PpreviewAndLabelElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement versionControlElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PversionControlElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPversionControlElement
		{
			get
			{
				if(r_PversionControlElement == null)
				{
					r_PversionControlElement = new(this, "versionControlElement", -1);
					r_PversionControlElement.SetBelong(this.GetValue());
				}
				return r_PversionControlElement;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RGUIView r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RGUIView RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
					r_Pparent.SetBelong(this.GetValue());
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] editorsWithImportedObjectLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_PeditorsWithImportedObjectLabel;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RPeditorsWithImportedObjectLabel
		{
			get
			{
				if(r_PeditorsWithImportedObjectLabel == null)
				{
					r_PeditorsWithImportedObjectLabel = new(this, "editorsWithImportedObjectLabel", -1);
					r_PeditorsWithImportedObjectLabel.SetBelong(this.GetValue());
				}
				return r_PeditorsWithImportedObjectLabel;
			}
		}

		/// <summary>
		/// UnityEditor.EditorDragging editorDragging
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorDragging r_PeditorDragging;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorDragging RPeditorDragging
		{
			get
			{
				if(r_PeditorDragging == null)
				{
					r_PeditorDragging = new(this, "editorDragging", -1);
					r_PeditorDragging.SetBelong(this.GetValue());
				}
				return r_PeditorDragging;
			}
		}

		/// <summary>
		/// Int32 inspectorElementModeOverride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PinspectorElementModeOverride;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPinspectorElementModeOverride
		{
			get
			{
				if(r_PinspectorElementModeOverride == null)
				{
					r_PinspectorElementModeOverride = new(this, "inspectorElementModeOverride", -1);
					r_PinspectorElementModeOverride.SetBelong(this.GetValue());
				}
				return r_PinspectorElementModeOverride;
			}
		}

		/// <summary>
		/// UnityEditor.Editor lastInteractedEditor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditor r_PlastInteractedEditor;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditor RPlastInteractedEditor
		{
			get
			{
				if(r_PlastInteractedEditor == null)
				{
					r_PlastInteractedEditor = new(this, "lastInteractedEditor", -1);
					r_PlastInteractedEditor.SetBelong(this.GetValue());
				}
				return r_PlastInteractedEditor;
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
					r_PinspectorMode.SetBelong(this.GetValue());
				}
				return r_PinspectorMode;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker tracker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker r_Ptracker;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker RPtracker
		{
			get
			{
				if(r_Ptracker == null)
				{
					r_Ptracker = new(this, "tracker", -1);
					r_Ptracker.SetBelong(this.GetValue());
				}
				return r_Ptracker;
			}
		}

		/// <summary>
		/// UnityEngine.Rect bottomAreaDropRectangle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PbottomAreaDropRectangle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPbottomAreaDropRectangle
		{
			get
			{
				if(r_PbottomAreaDropRectangle == null)
				{
					r_PbottomAreaDropRectangle = new(this, "bottomAreaDropRectangle", -1);
					r_PbottomAreaDropRectangle.SetBelong(this.GetValue());
				}
				return r_PbottomAreaDropRectangle;
			}
		}

		/// <summary>
		/// UnityEngine.Rect scrollViewportRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PscrollViewportRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPscrollViewportRect
		{
			get
			{
				if(r_PscrollViewportRect == null)
				{
					r_PscrollViewportRect = new(this, "scrollViewportRect", -1);
					r_PscrollViewportRect.SetBelong(this.GetValue());
				}
				return r_PscrollViewportRect;
			}
		}

		/// <summary>
		/// UnityEditor.IDataModeController dataModeController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIDataModeController r_PdataModeController;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIDataModeController RPdataModeController
		{
			get
			{
				if(r_PdataModeController == null)
				{
					r_PdataModeController = new(this, "dataModeController", -1);
					r_PdataModeController.SetBelong(this.GetValue());
				}
				return r_PdataModeController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement baseRootVisualElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PbaseRootVisualElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPbaseRootVisualElement
		{
			get
			{
				if(r_PbaseRootVisualElement == null)
				{
					r_PbaseRootVisualElement = new(this, "baseRootVisualElement", -1);
					r_PbaseRootVisualElement.SetBelong(this.GetValue());
				}
				return r_PbaseRootVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement rootVisualElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_ProotVisualElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RProotVisualElement
		{
			get
			{
				if(r_ProotVisualElement == null)
				{
					r_ProotVisualElement = new(this, "rootVisualElement", -1);
					r_ProotVisualElement.SetBelong(this.GetValue());
				}
				return r_ProotVisualElement;
			}
		}

		/// <summary>
		/// Boolean liveReloadPreferenceDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PliveReloadPreferenceDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPliveReloadPreferenceDefault
		{
			get
			{
				if(r_PliveReloadPreferenceDefault == null)
				{
					r_PliveReloadPreferenceDefault = new(this, "liveReloadPreferenceDefault", -1);
					r_PliveReloadPreferenceDefault.SetBelong(this.GetValue());
				}
				return r_PliveReloadPreferenceDefault;
			}
		}

		/// <summary>
		/// Boolean isUIToolkitWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisUIToolkitWindow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisUIToolkitWindow
		{
			get
			{
				if(r_PisUIToolkitWindow == null)
				{
					r_PisUIToolkitWindow = new(this, "isUIToolkitWindow", -1);
					r_PisUIToolkitWindow.SetBelong(this.GetValue());
				}
				return r_PisUIToolkitWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas overlayCanvas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas r_PoverlayCanvas;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas RPoverlayCanvas
		{
			get
			{
				if(r_PoverlayCanvas == null)
				{
					r_PoverlayCanvas = new(this, "overlayCanvas", -1);
					r_PoverlayCanvas.SetBelong(this.GetValue());
				}
				return r_PoverlayCanvas;
			}
		}

		/// <summary>
		/// UnityEditor.UIElements.SerializableJsonDictionary viewDataDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RUIElements.RSerializableJsonDictionary r_PviewDataDictionary;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RUIElements.RSerializableJsonDictionary RPviewDataDictionary
		{
			get
			{
				if(r_PviewDataDictionary == null)
				{
					r_PviewDataDictionary = new(this, "viewDataDictionary", -1);
					r_PviewDataDictionary.SetBelong(this.GetValue());
				}
				return r_PviewDataDictionary;
			}
		}

		/// <summary>
		/// Boolean wantsMouseMove
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwantsMouseMove;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwantsMouseMove
		{
			get
			{
				if(r_PwantsMouseMove == null)
				{
					r_PwantsMouseMove = new(this, "wantsMouseMove", -1);
					r_PwantsMouseMove.SetBelong(this.GetValue());
				}
				return r_PwantsMouseMove;
			}
		}

		/// <summary>
		/// Boolean wantsMouseEnterLeaveWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwantsMouseEnterLeaveWindow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwantsMouseEnterLeaveWindow
		{
			get
			{
				if(r_PwantsMouseEnterLeaveWindow == null)
				{
					r_PwantsMouseEnterLeaveWindow = new(this, "wantsMouseEnterLeaveWindow", -1);
					r_PwantsMouseEnterLeaveWindow.SetBelong(this.GetValue());
				}
				return r_PwantsMouseEnterLeaveWindow;
			}
		}

		/// <summary>
		/// Boolean wantsLessLayoutEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwantsLessLayoutEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwantsLessLayoutEvents
		{
			get
			{
				if(r_PwantsLessLayoutEvents == null)
				{
					r_PwantsLessLayoutEvents = new(this, "wantsLessLayoutEvents", -1);
					r_PwantsLessLayoutEvents.SetBelong(this.GetValue());
				}
				return r_PwantsLessLayoutEvents;
			}
		}

		/// <summary>
		/// Boolean autoRepaintOnSceneChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PautoRepaintOnSceneChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPautoRepaintOnSceneChange
		{
			get
			{
				if(r_PautoRepaintOnSceneChange == null)
				{
					r_PautoRepaintOnSceneChange = new(this, "autoRepaintOnSceneChange", -1);
					r_PautoRepaintOnSceneChange.SetBelong(this.GetValue());
				}
				return r_PautoRepaintOnSceneChange;
			}
		}

		/// <summary>
		/// Boolean maximized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pmaximized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPmaximized
		{
			get
			{
				if(r_Pmaximized == null)
				{
					r_Pmaximized = new(this, "maximized", -1);
					r_Pmaximized.SetBelong(this.GetValue());
				}
				return r_Pmaximized;
			}
		}

		/// <summary>
		/// Boolean hasFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasFocus
		{
			get
			{
				if(r_PhasFocus == null)
				{
					r_PhasFocus = new(this, "hasFocus", -1);
					r_PhasFocus.SetBelong(this.GetValue());
				}
				return r_PhasFocus;
			}
		}

		/// <summary>
		/// Boolean docked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdocked
		{
			get
			{
				if(r_Pdocked == null)
				{
					r_Pdocked = new(this, "docked", -1);
					r_Pdocked.SetBelong(this.GetValue());
				}
				return r_Pdocked;
			}
		}

		/// <summary>
		/// Boolean disableInputEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdisableInputEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisableInputEvents
		{
			get
			{
				if(r_PdisableInputEvents == null)
				{
					r_PdisableInputEvents = new(this, "disableInputEvents", -1);
					r_PdisableInputEvents.SetBelong(this.GetValue());
				}
				return r_PdisableInputEvents;
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
					r_PhasUnsavedChanges.SetBelong(this.GetValue());
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
					r_PsaveChangesMessage.SetBelong(this.GetValue());
				}
				return r_PsaveChangesMessage;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PminSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPminSize
		{
			get
			{
				if(r_PminSize == null)
				{
					r_PminSize = new(this, "minSize", -1);
					r_PminSize.SetBelong(this.GetValue());
				}
				return r_PminSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmaxSize
		{
			get
			{
				if(r_PmaxSize == null)
				{
					r_PmaxSize = new(this, "maxSize", -1);
					r_PmaxSize.SetBelong(this.GetValue());
				}
				return r_PmaxSize;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptitle;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtitle
		{
			get
			{
				if(r_Ptitle == null)
				{
					r_Ptitle = new(this, "title", -1);
					r_Ptitle.SetBelong(this.GetValue());
				}
				return r_Ptitle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent titleContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_PtitleContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RPtitleContent
		{
			get
			{
				if(r_PtitleContent == null)
				{
					r_PtitleContent = new(this, "titleContent", -1);
					r_PtitleContent.SetBelong(this.GetValue());
				}
				return r_PtitleContent;
			}
		}

		/// <summary>
		/// Int32 depthBufferBits
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdepthBufferBits;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdepthBufferBits
		{
			get
			{
				if(r_PdepthBufferBits == null)
				{
					r_PdepthBufferBits = new(this, "depthBufferBits", -1);
					r_PdepthBufferBits.SetBelong(this.GetValue());
				}
				return r_PdepthBufferBits;
			}
		}

		/// <summary>
		/// Int32 antiAliasing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PantiAliasing;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPantiAliasing
		{
			get
			{
				if(r_PantiAliasing == null)
				{
					r_PantiAliasing = new(this, "antiAliasing", -1);
					r_PantiAliasing.SetBelong(this.GetValue());
				}
				return r_PantiAliasing;
			}
		}

		/// <summary>
		/// Int32 antiAlias
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PantiAlias;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPantiAlias
		{
			get
			{
				if(r_PantiAlias == null)
				{
					r_PantiAlias = new(this, "antiAlias", -1);
					r_PantiAlias.SetBelong(this.GetValue());
				}
				return r_PantiAlias;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.GetValue());
				}
				return r_Pposition;
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
					r_Pname.SetBelong(this.GetValue());
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
					r_PhideFlags.SetBelong(this.GetValue());
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetParentInspector(UnityEditor.InspectorWindow)
		/// </summary>
		protected RMethod r_MSetParentInspector_InspectorWindow;
		public virtual RMethod RMSetParentInspector_InspectorWindow
		{
			get
			{
				if(r_MSetParentInspector_InspectorWindow == null)
				{
					r_MSetParentInspector_InspectorWindow = new(this, "SetParentInspector", 0,  ReflectionUtils.GetType("UnityEditor.InspectorWindow"));
					r_MSetParentInspector_InspectorWindow.SetBelong(this.GetValue());
				}
				return r_MSetParentInspector_InspectorWindow;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_MOnDestroy;
		public virtual RMethod RMOnDestroy
		{
			get
			{
				if(r_MOnDestroy == null)
				{
					r_MOnDestroy = new(this, "OnDestroy", 0);
					r_MOnDestroy.SetBelong(this.GetValue());
				}
				return r_MOnDestroy;
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
					r_MOnEnable.SetBelong(this.GetValue());
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
					r_MOnDisable.SetBelong(this.GetValue());
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void CreateTracker()
		/// </summary>
		protected RMethod r_MCreateTracker;
		public virtual RMethod RMCreateTracker
		{
			get
			{
				if(r_MCreateTracker == null)
				{
					r_MCreateTracker = new(this, "CreateTracker", 0);
					r_MCreateTracker.SetBelong(this.GetValue());
				}
				return r_MCreateTracker;
			}
		}

		/// <summary>
		/// UnityEditor.Editor GetLastInteractedEditor()
		/// </summary>
		protected RMethod r_MGetLastInteractedEditor;
		public virtual RMethod RMGetLastInteractedEditor
		{
			get
			{
				if(r_MGetLastInteractedEditor == null)
				{
					r_MGetLastInteractedEditor = new(this, "GetLastInteractedEditor", 0);
					r_MGetLastInteractedEditor.SetBelong(this.GetValue());
				}
				return r_MGetLastInteractedEditor;
			}
		}

		/// <summary>
		/// Void RebuildContentsContainers()
		/// </summary>
		protected RMethod r_MRebuildContentsContainers;
		public virtual RMethod RMRebuildContentsContainers
		{
			get
			{
				if(r_MRebuildContentsContainers == null)
				{
					r_MRebuildContentsContainers = new(this, "RebuildContentsContainers", 0);
					r_MRebuildContentsContainers.SetBelong(this.GetValue());
				}
				return r_MRebuildContentsContainers;
			}
		}

		/// <summary>
		/// Void DrawPreview()
		/// </summary>
		protected RMethod r_MDrawPreview;
		public virtual RMethod RMDrawPreview
		{
			get
			{
				if(r_MDrawPreview == null)
				{
					r_MDrawPreview = new(this, "DrawPreview", 0);
					r_MDrawPreview.SetBelong(this.GetValue());
				}
				return r_MDrawPreview;
			}
		}

		/// <summary>
		/// Void AddItemsToMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_MAddItemsToMenu_GenericMenu;
		public virtual RMethod RMAddItemsToMenu_GenericMenu
		{
			get
			{
				if(r_MAddItemsToMenu_GenericMenu == null)
				{
					r_MAddItemsToMenu_GenericMenu = new(this, "AddItemsToMenu", 0, typeof(UnityEditor.GenericMenu));
					r_MAddItemsToMenu_GenericMenu.SetBelong(this.GetValue());
				}
				return r_MAddItemsToMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ShowButton(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MShowButton_Rect;
		public virtual RMethod RMShowButton_Rect
		{
			get
			{
				if(r_MShowButton_Rect == null)
				{
					r_MShowButton_Rect = new(this, "ShowButton", 0, typeof(UnityEngine.Rect));
					r_MShowButton_Rect.SetBelong(this.GetValue());
				}
				return r_MShowButton_Rect;
			}
		}

		/// <summary>
		/// Boolean CanMaximize()
		/// </summary>
		protected RMethod r_MCanMaximize;
		public virtual RMethod RMCanMaximize
		{
			get
			{
				if(r_MCanMaximize == null)
				{
					r_MCanMaximize = new(this, "CanMaximize", 0);
					r_MCanMaximize.SetBelong(this.GetValue());
				}
				return r_MCanMaximize;
			}
		}

		/// <summary>
		/// Void <RebuildContentsContainers>b__10_0()
		/// </summary>
		protected RMethod r_M__0__RebuildContentsContainers__1__b__10_0;
		public virtual RMethod RM__0__RebuildContentsContainers__1__b__10_0
		{
			get
			{
				if(r_M__0__RebuildContentsContainers__1__b__10_0 == null)
				{
					r_M__0__RebuildContentsContainers__1__b__10_0 = new(this, "<RebuildContentsContainers>b__10_0", 0);
					r_M__0__RebuildContentsContainers__1__b__10_0.SetBelong(this.GetValue());
				}
				return r_M__0__RebuildContentsContainers__1__b__10_0;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_MAwake;
		public virtual RMethod RMAwake
		{
			get
			{
				if(r_MAwake == null)
				{
					r_MAwake = new(this, "Awake", 0);
					r_MAwake.SetBelong(this.GetValue());
				}
				return r_MAwake;
			}
		}

		/// <summary>
		/// Void OnUpdateSupportedDataModes(System.Collections.Generic.List`1[UnityEditor.DataMode])
		/// </summary>
		protected RMethod r_MOnUpdateSupportedDataModes_List_d_DataMode_p_;
		public virtual RMethod RMOnUpdateSupportedDataModes_List_d_DataMode_p_
		{
			get
			{
				if(r_MOnUpdateSupportedDataModes_List_d_DataMode_p_ == null)
				{
					r_MOnUpdateSupportedDataModes_List_d_DataMode_p_ = new(this, "OnUpdateSupportedDataModes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.DataMode)));
					r_MOnUpdateSupportedDataModes_List_d_DataMode_p_.SetBelong(this.GetValue());
				}
				return r_MOnUpdateSupportedDataModes_List_d_DataMode_p_;
			}
		}

		/// <summary>
		/// Void RefreshTitle()
		/// </summary>
		protected RMethod r_MRefreshTitle;
		public virtual RMethod RMRefreshTitle
		{
			get
			{
				if(r_MRefreshTitle == null)
				{
					r_MRefreshTitle = new(this, "RefreshTitle", 0);
					r_MRefreshTitle.SetBelong(this.GetValue());
				}
				return r_MRefreshTitle;
			}
		}

		/// <summary>
		/// Void UpdateWindowObjectNameTitle()
		/// </summary>
		protected RMethod r_MUpdateWindowObjectNameTitle;
		public virtual RMethod RMUpdateWindowObjectNameTitle
		{
			get
			{
				if(r_MUpdateWindowObjectNameTitle == null)
				{
					r_MUpdateWindowObjectNameTitle = new(this, "UpdateWindowObjectNameTitle", 0);
					r_MUpdateWindowObjectNameTitle.SetBelong(this.GetValue());
				}
				return r_MUpdateWindowObjectNameTitle;
			}
		}

		/// <summary>
		/// Boolean CloseIfEmpty()
		/// </summary>
		protected RMethod r_MCloseIfEmpty;
		public virtual RMethod RMCloseIfEmpty
		{
			get
			{
				if(r_MCloseIfEmpty == null)
				{
					r_MCloseIfEmpty = new(this, "CloseIfEmpty", 0);
					r_MCloseIfEmpty.SetBelong(this.GetValue());
				}
				return r_MCloseIfEmpty;
			}
		}

		/// <summary>
		/// Void BeginRebuildContentContainers()
		/// </summary>
		protected RMethod r_MBeginRebuildContentContainers;
		public virtual RMethod RMBeginRebuildContentContainers
		{
			get
			{
				if(r_MBeginRebuildContentContainers == null)
				{
					r_MBeginRebuildContentContainers = new(this, "BeginRebuildContentContainers", 0);
					r_MBeginRebuildContentContainers.SetBelong(this.GetValue());
				}
				return r_MBeginRebuildContentContainers;
			}
		}

		/// <summary>
		/// Boolean BeginDrawPreviewAndLabels()
		/// </summary>
		protected RMethod r_MBeginDrawPreviewAndLabels;
		public virtual RMethod RMBeginDrawPreviewAndLabels
		{
			get
			{
				if(r_MBeginDrawPreviewAndLabels == null)
				{
					r_MBeginDrawPreviewAndLabels = new(this, "BeginDrawPreviewAndLabels", 0);
					r_MBeginDrawPreviewAndLabels.SetBelong(this.GetValue());
				}
				return r_MBeginDrawPreviewAndLabels;
			}
		}

		/// <summary>
		/// Void EndDrawPreviewAndLabels(UnityEngine.Event, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MEndDrawPreviewAndLabels_Event_Rect_Rect;
		public virtual RMethod RMEndDrawPreviewAndLabels_Event_Rect_Rect
		{
			get
			{
				if(r_MEndDrawPreviewAndLabels_Event_Rect_Rect == null)
				{
					r_MEndDrawPreviewAndLabels_Event_Rect_Rect = new(this, "EndDrawPreviewAndLabels", 0, typeof(UnityEngine.Event), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_MEndDrawPreviewAndLabels_Event_Rect_Rect.SetBelong(this.GetValue());
				}
				return r_MEndDrawPreviewAndLabels_Event_Rect_Rect;
			}
		}

		/// <summary>
		/// Void GetObjectsLocked(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_MGetObjectsLocked_List_d_Object_p_;
		public virtual RMethod RMGetObjectsLocked_List_d_Object_p_
		{
			get
			{
				if(r_MGetObjectsLocked_List_d_Object_p_ == null)
				{
					r_MGetObjectsLocked_List_d_Object_p_ = new(this, "GetObjectsLocked", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_MGetObjectsLocked_List_d_Object_p_.SetBelong(this.GetValue());
				}
				return r_MGetObjectsLocked_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void SetObjectsLocked(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_MSetObjectsLocked_List_d_Object_p_;
		public virtual RMethod RMSetObjectsLocked_List_d_Object_p_
		{
			get
			{
				if(r_MSetObjectsLocked_List_d_Object_p_ == null)
				{
					r_MSetObjectsLocked_List_d_Object_p_ = new(this, "SetObjectsLocked", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_MSetObjectsLocked_List_d_Object_p_.SetBelong(this.GetValue());
				}
				return r_MSetObjectsLocked_List_d_Object_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetInspectedObject()
		/// </summary>
		protected RMethod r_MGetInspectedObject;
		public virtual RMethod RMGetInspectedObject
		{
			get
			{
				if(r_MGetInspectedObject == null)
				{
					r_MGetInspectedObject = new(this, "GetInspectedObject", 0);
					r_MGetInspectedObject.SetBelong(this.GetValue());
				}
				return r_MGetInspectedObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] GetInspectedObjects()
		/// </summary>
		protected RMethod r_MGetInspectedObjects;
		public virtual RMethod RMGetInspectedObjects
		{
			get
			{
				if(r_MGetInspectedObjects == null)
				{
					r_MGetInspectedObjects = new(this, "GetInspectedObjects", 0);
					r_MGetInspectedObjects.SetBelong(this.GetValue());
				}
				return r_MGetInspectedObjects;
			}
		}

		/// <summary>
		/// Void OnFocusChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnFocusChanged_Boolean;
		public virtual RMethod RMOnFocusChanged_Boolean
		{
			get
			{
				if(r_MOnFocusChanged_Boolean == null)
				{
					r_MOnFocusChanged_Boolean = new(this, "OnFocusChanged", 0, typeof(System.Boolean));
					r_MOnFocusChanged_Boolean.SetBelong(this.GetValue());
				}
				return r_MOnFocusChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_MOnLostFocus;
		public virtual RMethod RMOnLostFocus
		{
			get
			{
				if(r_MOnLostFocus == null)
				{
					r_MOnLostFocus = new(this, "OnLostFocus", 0);
					r_MOnLostFocus.SetBelong(this.GetValue());
				}
				return r_MOnLostFocus;
			}
		}

		/// <summary>
		/// Void OnInspectorUpdate()
		/// </summary>
		protected RMethod r_MOnInspectorUpdate;
		public virtual RMethod RMOnInspectorUpdate
		{
			get
			{
				if(r_MOnInspectorUpdate == null)
				{
					r_MOnInspectorUpdate = new(this, "OnInspectorUpdate", 0);
					r_MOnInspectorUpdate.SetBelong(this.GetValue());
				}
				return r_MOnInspectorUpdate;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_MOnGUI;
		public virtual RMethod RMOnGUI
		{
			get
			{
				if(r_MOnGUI == null)
				{
					r_MOnGUI = new(this, "OnGUI", 0);
					r_MOnGUI.SetBelong(this.GetValue());
				}
				return r_MOnGUI;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
					r_MUpdate.SetBelong(this.GetValue());
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void SetMode(UnityEditor.InspectorMode)
		/// </summary>
		protected RMethod r_MSetMode_InspectorMode;
		public virtual RMethod RMSetMode_InspectorMode
		{
			get
			{
				if(r_MSetMode_InspectorMode == null)
				{
					r_MSetMode_InspectorMode = new(this, "SetMode", 0, typeof(UnityEditor.InspectorMode));
					r_MSetMode_InspectorMode.SetBelong(this.GetValue());
				}
				return r_MSetMode_InspectorMode;
			}
		}

		/// <summary>
		/// Void SetTitle(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MSetTitle_Object;
		public virtual RMethod RMSetTitle_Object
		{
			get
			{
				if(r_MSetTitle_Object == null)
				{
					r_MSetTitle_Object = new(this, "SetTitle", 0, typeof(UnityEngine.Object));
					r_MSetTitle_Object.SetBelong(this.GetValue());
				}
				return r_MSetTitle_Object;
			}
		}

		/// <summary>
		/// Void LoadVisualTreeFromUxml()
		/// </summary>
		protected RMethod r_MLoadVisualTreeFromUxml;
		public virtual RMethod RMLoadVisualTreeFromUxml
		{
			get
			{
				if(r_MLoadVisualTreeFromUxml == null)
				{
					r_MLoadVisualTreeFromUxml = new(this, "LoadVisualTreeFromUxml", 0);
					r_MLoadVisualTreeFromUxml.SetBelong(this.GetValue());
				}
				return r_MLoadVisualTreeFromUxml;
			}
		}

		/// <summary>
		/// Void ClearEditorsAndRebuild()
		/// </summary>
		protected RMethod r_MClearEditorsAndRebuild;
		public virtual RMethod RMClearEditorsAndRebuild
		{
			get
			{
				if(r_MClearEditorsAndRebuild == null)
				{
					r_MClearEditorsAndRebuild = new(this, "ClearEditorsAndRebuild", 0);
					r_MClearEditorsAndRebuild.SetBelong(this.GetValue());
				}
				return r_MClearEditorsAndRebuild;
			}
		}

		/// <summary>
		/// Void AddDebugItemsToMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_MAddDebugItemsToMenu_GenericMenu;
		public virtual RMethod RMAddDebugItemsToMenu_GenericMenu
		{
			get
			{
				if(r_MAddDebugItemsToMenu_GenericMenu == null)
				{
					r_MAddDebugItemsToMenu_GenericMenu = new(this, "AddDebugItemsToMenu", 0, typeof(UnityEditor.GenericMenu));
					r_MAddDebugItemsToMenu_GenericMenu.SetBelong(this.GetValue());
				}
				return r_MAddDebugItemsToMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ExpandAllComponents()
		/// </summary>
		protected RMethod r_MExpandAllComponents;
		public virtual RMethod RMExpandAllComponents
		{
			get
			{
				if(r_MExpandAllComponents == null)
				{
					r_MExpandAllComponents = new(this, "ExpandAllComponents", 0);
					r_MExpandAllComponents.SetBelong(this.GetValue());
				}
				return r_MExpandAllComponents;
			}
		}

		/// <summary>
		/// Boolean IsAnyComponentCollapsed()
		/// </summary>
		protected RMethod r_MIsAnyComponentCollapsed;
		public virtual RMethod RMIsAnyComponentCollapsed
		{
			get
			{
				if(r_MIsAnyComponentCollapsed == null)
				{
					r_MIsAnyComponentCollapsed = new(this, "IsAnyComponentCollapsed", 0);
					r_MIsAnyComponentCollapsed.SetBelong(this.GetValue());
				}
				return r_MIsAnyComponentCollapsed;
			}
		}

		/// <summary>
		/// Void CollapseAllComponents()
		/// </summary>
		protected RMethod r_MCollapseAllComponents;
		public virtual RMethod RMCollapseAllComponents
		{
			get
			{
				if(r_MCollapseAllComponents == null)
				{
					r_MCollapseAllComponents = new(this, "CollapseAllComponents", 0);
					r_MCollapseAllComponents.SetBelong(this.GetValue());
				}
				return r_MCollapseAllComponents;
			}
		}

		/// <summary>
		/// Boolean IsAnyComponentExpanded()
		/// </summary>
		protected RMethod r_MIsAnyComponentExpanded;
		public virtual RMethod RMIsAnyComponentExpanded
		{
			get
			{
				if(r_MIsAnyComponentExpanded == null)
				{
					r_MIsAnyComponentExpanded = new(this, "IsAnyComponentExpanded", 0);
					r_MIsAnyComponentExpanded.SetBelong(this.GetValue());
				}
				return r_MIsAnyComponentExpanded;
			}
		}

		/// <summary>
		/// Boolean LoadPersistedObject()
		/// </summary>
		protected RMethod r_MLoadPersistedObject;
		public virtual RMethod RMLoadPersistedObject
		{
			get
			{
				if(r_MLoadPersistedObject == null)
				{
					r_MLoadPersistedObject = new(this, "LoadPersistedObject", 0);
					r_MLoadPersistedObject.SetBelong(this.GetValue());
				}
				return r_MLoadPersistedObject;
			}
		}

		/// <summary>
		/// Void CreatePreviewables()
		/// </summary>
		protected RMethod r_MCreatePreviewables;
		public virtual RMethod RMCreatePreviewables
		{
			get
			{
				if(r_MCreatePreviewables == null)
				{
					r_MCreatePreviewables = new(this, "CreatePreviewables", 0);
					r_MCreatePreviewables.SetBelong(this.GetValue());
				}
				return r_MCreatePreviewables;
			}
		}

		/// <summary>
		/// Void ClearPreviewables()
		/// </summary>
		protected RMethod r_MClearPreviewables;
		public virtual RMethod RMClearPreviewables
		{
			get
			{
				if(r_MClearPreviewables == null)
				{
					r_MClearPreviewables = new(this, "ClearPreviewables", 0);
					r_MClearPreviewables.SetBelong(this.GetValue());
				}
				return r_MClearPreviewables;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action, System.String)
		/// </summary>
		protected RMethod r_MCreateIMGUIContainer_Action_String;
		public virtual RMethod RMCreateIMGUIContainer_Action_String
		{
			get
			{
				if(r_MCreateIMGUIContainer_Action_String == null)
				{
					r_MCreateIMGUIContainer_Action_String = new(this, "CreateIMGUIContainer", 0, typeof(System.Action), typeof(System.String));
					r_MCreateIMGUIContainer_Action_String.SetBelong(this.GetValue());
				}
				return r_MCreateIMGUIContainer_Action_String;
			}
		}

		/// <summary>
		/// Void EndRebuildContentContainers()
		/// </summary>
		protected RMethod r_MEndRebuildContentContainers;
		public virtual RMethod RMEndRebuildContentContainers
		{
			get
			{
				if(r_MEndRebuildContentContainers == null)
				{
					r_MEndRebuildContentContainers = new(this, "EndRebuildContentContainers", 0);
					r_MEndRebuildContentContainers.SetBelong(this.GetValue());
				}
				return r_MEndRebuildContentContainers;
			}
		}

		/// <summary>
		/// Void AutoScroll(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MAutoScroll_Vector2;
		public virtual RMethod RMAutoScroll_Vector2
		{
			get
			{
				if(r_MAutoScroll_Vector2 == null)
				{
					r_MAutoScroll_Vector2 = new(this, "AutoScroll", 0, typeof(UnityEngine.Vector2));
					r_MAutoScroll_Vector2.SetBelong(this.GetValue());
				}
				return r_MAutoScroll_Vector2;
			}
		}

		/// <summary>
		/// Void ScrollTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MScrollTo_Vector2;
		public virtual RMethod RMScrollTo_Vector2
		{
			get
			{
				if(r_MScrollTo_Vector2 == null)
				{
					r_MScrollTo_Vector2 = new(this, "ScrollTo", 0, typeof(UnityEngine.Vector2));
					r_MScrollTo_Vector2.SetBelong(this.GetValue());
				}
				return r_MScrollTo_Vector2;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable GetEditorThatControlsPreview(UnityEditor.IPreviewable[])
		/// </summary>
		protected RMethod r_MGetEditorThatControlsPreview_IPreviewableArray;
		public virtual RMethod RMGetEditorThatControlsPreview_IPreviewableArray
		{
			get
			{
				if(r_MGetEditorThatControlsPreview_IPreviewableArray == null)
				{
					r_MGetEditorThatControlsPreview_IPreviewableArray = new(this, "GetEditorThatControlsPreview", 0,  ReflectionUtils.GetType("UnityEditor.IPreviewable").MakeArrayType());
					r_MGetEditorThatControlsPreview_IPreviewableArray.SetBelong(this.GetValue());
				}
				return r_MGetEditorThatControlsPreview_IPreviewableArray;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable[] GetEditorsWithPreviews(UnityEditor.Editor[])
		/// </summary>
		protected RMethod r_MGetEditorsWithPreviews_EditorArray;
		public virtual RMethod RMGetEditorsWithPreviews_EditorArray
		{
			get
			{
				if(r_MGetEditorsWithPreviews_EditorArray == null)
				{
					r_MGetEditorsWithPreviews_EditorArray = new(this, "GetEditorsWithPreviews", 0, typeof(UnityEditor.Editor).MakeArrayType());
					r_MGetEditorsWithPreviews_EditorArray.SetBelong(this.GetValue());
				}
				return r_MGetEditorsWithPreviews_EditorArray;
			}
		}

		/// <summary>
		/// Boolean WasEditorVisible(UnityEditor.Editor[], Int32, UnityEngine.Object)
		/// </summary>
		protected RMethod r_MWasEditorVisible_EditorArray_Int32_Object;
		public virtual RMethod RMWasEditorVisible_EditorArray_Int32_Object
		{
			get
			{
				if(r_MWasEditorVisible_EditorArray_Int32_Object == null)
				{
					r_MWasEditorVisible_EditorArray_Int32_Object = new(this, "WasEditorVisible", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Object));
					r_MWasEditorVisible_EditorArray_Int32_Object.SetBelong(this.GetValue());
				}
				return r_MWasEditorVisible_EditorArray_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean ShouldCullEditor(UnityEditor.Editor[], Int32)
		/// </summary>
		protected RMethod r_MShouldCullEditor_EditorArray_Int32;
		public virtual RMethod RMShouldCullEditor_EditorArray_Int32
		{
			get
			{
				if(r_MShouldCullEditor_EditorArray_Int32 == null)
				{
					r_MShouldCullEditor_EditorArray_Int32 = new(this, "ShouldCullEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32));
					r_MShouldCullEditor_EditorArray_Int32.SetBelong(this.GetValue());
				}
				return r_MShouldCullEditor_EditorArray_Int32;
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
					r_MSaveChanges.SetBelong(this.GetValue());
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
					r_MDiscardChanges.SetBelong(this.GetValue());
				}
				return r_MDiscardChanges;
			}
		}

		/// <summary>
		/// Void UnsavedChangesStateChanged(UnityEditor.Editor, Boolean)
		/// </summary>
		protected RMethod r_MUnsavedChangesStateChanged_Editor_Boolean;
		public virtual RMethod RMUnsavedChangesStateChanged_Editor_Boolean
		{
			get
			{
				if(r_MUnsavedChangesStateChanged_Editor_Boolean == null)
				{
					r_MUnsavedChangesStateChanged_Editor_Boolean = new(this, "UnsavedChangesStateChanged", 0, typeof(UnityEditor.Editor), typeof(System.Boolean));
					r_MUnsavedChangesStateChanged_Editor_Boolean.SetBelong(this.GetValue());
				}
				return r_MUnsavedChangesStateChanged_Editor_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateSupportedDataModesList()
		/// </summary>
		protected RMethod r_MUpdateSupportedDataModesList;
		public virtual RMethod RMUpdateSupportedDataModesList
		{
			get
			{
				if(r_MUpdateSupportedDataModesList == null)
				{
					r_MUpdateSupportedDataModesList = new(this, "UpdateSupportedDataModesList", 0);
					r_MUpdateSupportedDataModesList.SetBelong(this.GetValue());
				}
				return r_MUpdateSupportedDataModesList;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController GetDataModeController_Internal()
		/// </summary>
		protected RMethod r_MGetDataModeController_Internal;
		public virtual RMethod RMGetDataModeController_Internal
		{
			get
			{
				if(r_MGetDataModeController_Internal == null)
				{
					r_MGetDataModeController_Internal = new(this, "GetDataModeController_Internal", 0);
					r_MGetDataModeController_Internal.SetBelong(this.GetValue());
				}
				return r_MGetDataModeController_Internal;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_MSaveViewData;
		public virtual RMethod RMSaveViewData
		{
			get
			{
				if(r_MSaveViewData == null)
				{
					r_MSaveViewData = new(this, "SaveViewData", 0);
					r_MSaveViewData.SetBelong(this.GetValue());
				}
				return r_MSaveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ISerializableJsonDictionary GetViewDataDictionary()
		/// </summary>
		protected RMethod r_MGetViewDataDictionary;
		public virtual RMethod RMGetViewDataDictionary
		{
			get
			{
				if(r_MGetViewDataDictionary == null)
				{
					r_MGetViewDataDictionary = new(this, "GetViewDataDictionary", 0);
					r_MGetViewDataDictionary.SetBelong(this.GetValue());
				}
				return r_MGetViewDataDictionary;
			}
		}

		/// <summary>
		/// Void DisableViewDataPersistence()
		/// </summary>
		protected RMethod r_MDisableViewDataPersistence;
		public virtual RMethod RMDisableViewDataPersistence
		{
			get
			{
				if(r_MDisableViewDataPersistence == null)
				{
					r_MDisableViewDataPersistence = new(this, "DisableViewDataPersistence", 0);
					r_MDisableViewDataPersistence.SetBelong(this.GetValue());
				}
				return r_MDisableViewDataPersistence;
			}
		}

		/// <summary>
		/// Void ClearPersistentViewData()
		/// </summary>
		protected RMethod r_MClearPersistentViewData;
		public virtual RMethod RMClearPersistentViewData
		{
			get
			{
				if(r_MClearPersistentViewData == null)
				{
					r_MClearPersistentViewData = new(this, "ClearPersistentViewData", 0);
					r_MClearPersistentViewData.SetBelong(this.GetValue());
				}
				return r_MClearPersistentViewData;
			}
		}

		/// <summary>
		/// Void BeginWindows()
		/// </summary>
		protected RMethod r_MBeginWindows;
		public virtual RMethod RMBeginWindows
		{
			get
			{
				if(r_MBeginWindows == null)
				{
					r_MBeginWindows = new(this, "BeginWindows", 0);
					r_MBeginWindows.SetBelong(this.GetValue());
				}
				return r_MBeginWindows;
			}
		}

		/// <summary>
		/// Void EndWindows()
		/// </summary>
		protected RMethod r_MEndWindows;
		public virtual RMethod RMEndWindows
		{
			get
			{
				if(r_MEndWindows == null)
				{
					r_MEndWindows = new(this, "EndWindows", 0);
					r_MEndWindows.SetBelong(this.GetValue());
				}
				return r_MEndWindows;
			}
		}

		/// <summary>
		/// Void OnResized()
		/// </summary>
		protected RMethod r_MOnResized;
		public virtual RMethod RMOnResized
		{
			get
			{
				if(r_MOnResized == null)
				{
					r_MOnResized = new(this, "OnResized", 0);
					r_MOnResized.SetBelong(this.GetValue());
				}
				return r_MOnResized;
			}
		}

		/// <summary>
		/// Void OnBackgroundViewResized(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOnBackgroundViewResized_Rect;
		public virtual RMethod RMOnBackgroundViewResized_Rect
		{
			get
			{
				if(r_MOnBackgroundViewResized_Rect == null)
				{
					r_MOnBackgroundViewResized_Rect = new(this, "OnBackgroundViewResized", 0, typeof(UnityEngine.Rect));
					r_MOnBackgroundViewResized_Rect.SetBelong(this.GetValue());
				}
				return r_MOnBackgroundViewResized_Rect;
			}
		}

		/// <summary>
		/// Void CheckForWindowRepaint()
		/// </summary>
		protected RMethod r_MCheckForWindowRepaint;
		public virtual RMethod RMCheckForWindowRepaint
		{
			get
			{
				if(r_MCheckForWindowRepaint == null)
				{
					r_MCheckForWindowRepaint = new(this, "CheckForWindowRepaint", 0);
					r_MCheckForWindowRepaint.SetBelong(this.GetValue());
				}
				return r_MCheckForWindowRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetLocalizedTitleContent()
		/// </summary>
		protected RMethod r_MGetLocalizedTitleContent;
		public virtual RMethod RMGetLocalizedTitleContent
		{
			get
			{
				if(r_MGetLocalizedTitleContent == null)
				{
					r_MGetLocalizedTitleContent = new(this, "GetLocalizedTitleContent", 0);
					r_MGetLocalizedTitleContent.SetBelong(this.GetValue());
				}
				return r_MGetLocalizedTitleContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MShowNotification_GUIContent;
		public virtual RMethod RMShowNotification_GUIContent
		{
			get
			{
				if(r_MShowNotification_GUIContent == null)
				{
					r_MShowNotification_GUIContent = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent));
					r_MShowNotification_GUIContent.SetBelong(this.GetValue());
				}
				return r_MShowNotification_GUIContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent, Double)
		/// </summary>
		protected RMethod r_MShowNotification_GUIContent_Double;
		public virtual RMethod RMShowNotification_GUIContent_Double
		{
			get
			{
				if(r_MShowNotification_GUIContent_Double == null)
				{
					r_MShowNotification_GUIContent_Double = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent), typeof(System.Double));
					r_MShowNotification_GUIContent_Double.SetBelong(this.GetValue());
				}
				return r_MShowNotification_GUIContent_Double;
			}
		}

		/// <summary>
		/// Void RemoveNotification()
		/// </summary>
		protected RMethod r_MRemoveNotification;
		public virtual RMethod RMRemoveNotification
		{
			get
			{
				if(r_MRemoveNotification == null)
				{
					r_MRemoveNotification = new(this, "RemoveNotification", 0);
					r_MRemoveNotification.SetBelong(this.GetValue());
				}
				return r_MRemoveNotification;
			}
		}

		/// <summary>
		/// Void DrawNotification()
		/// </summary>
		protected RMethod r_MDrawNotification;
		public virtual RMethod RMDrawNotification
		{
			get
			{
				if(r_MDrawNotification == null)
				{
					r_MDrawNotification = new(this, "DrawNotification", 0);
					r_MDrawNotification.SetBelong(this.GetValue());
				}
				return r_MDrawNotification;
			}
		}

		/// <summary>
		/// Void OnMaximized()
		/// </summary>
		protected RMethod r_MOnMaximized;
		public virtual RMethod RMOnMaximized
		{
			get
			{
				if(r_MOnMaximized == null)
				{
					r_MOnMaximized = new(this, "OnMaximized", 0);
					r_MOnMaximized.SetBelong(this.GetValue());
				}
				return r_MOnMaximized;
			}
		}

		/// <summary>
		/// Int32 GetNumTabs()
		/// </summary>
		protected RMethod r_MGetNumTabs;
		public virtual RMethod RMGetNumTabs
		{
			get
			{
				if(r_MGetNumTabs == null)
				{
					r_MGetNumTabs = new(this, "GetNumTabs", 0);
					r_MGetNumTabs.SetBelong(this.GetValue());
				}
				return r_MGetNumTabs;
			}
		}

		/// <summary>
		/// Boolean ShowNextTabIfPossible()
		/// </summary>
		protected RMethod r_MShowNextTabIfPossible;
		public virtual RMethod RMShowNextTabIfPossible
		{
			get
			{
				if(r_MShowNextTabIfPossible == null)
				{
					r_MShowNextTabIfPossible = new(this, "ShowNextTabIfPossible", 0);
					r_MShowNextTabIfPossible.SetBelong(this.GetValue());
				}
				return r_MShowNextTabIfPossible;
			}
		}

		/// <summary>
		/// Void ShowTab()
		/// </summary>
		protected RMethod r_MShowTab;
		public virtual RMethod RMShowTab
		{
			get
			{
				if(r_MShowTab == null)
				{
					r_MShowTab = new(this, "ShowTab", 0);
					r_MShowTab.SetBelong(this.GetValue());
				}
				return r_MShowTab;
			}
		}

		/// <summary>
		/// Boolean IsSelectedTab()
		/// </summary>
		protected RMethod r_MIsSelectedTab;
		public virtual RMethod RMIsSelectedTab
		{
			get
			{
				if(r_MIsSelectedTab == null)
				{
					r_MIsSelectedTab = new(this, "IsSelectedTab", 0);
					r_MIsSelectedTab.SetBelong(this.GetValue());
				}
				return r_MIsSelectedTab;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_MFocus;
		public virtual RMethod RMFocus
		{
			get
			{
				if(r_MFocus == null)
				{
					r_MFocus = new(this, "Focus", 0);
					r_MFocus.SetBelong(this.GetValue());
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void MakeParentsSettingsMatchMe()
		/// </summary>
		protected RMethod r_MMakeParentsSettingsMatchMe;
		public virtual RMethod RMMakeParentsSettingsMatchMe
		{
			get
			{
				if(r_MMakeParentsSettingsMatchMe == null)
				{
					r_MMakeParentsSettingsMatchMe = new(this, "MakeParentsSettingsMatchMe", 0);
					r_MMakeParentsSettingsMatchMe.SetBelong(this.GetValue());
				}
				return r_MMakeParentsSettingsMatchMe;
			}
		}

		/// <summary>
		/// Void ShowUtility()
		/// </summary>
		protected RMethod r_MShowUtility;
		public virtual RMethod RMShowUtility
		{
			get
			{
				if(r_MShowUtility == null)
				{
					r_MShowUtility = new(this, "ShowUtility", 0);
					r_MShowUtility.SetBelong(this.GetValue());
				}
				return r_MShowUtility;
			}
		}

		/// <summary>
		/// Void ShowTooltip()
		/// </summary>
		protected RMethod r_MShowTooltip;
		public virtual RMethod RMShowTooltip
		{
			get
			{
				if(r_MShowTooltip == null)
				{
					r_MShowTooltip = new(this, "ShowTooltip", 0);
					r_MShowTooltip.SetBelong(this.GetValue());
				}
				return r_MShowTooltip;
			}
		}

		/// <summary>
		/// Void ShowPopup()
		/// </summary>
		protected RMethod r_MShowPopup;
		public virtual RMethod RMShowPopup
		{
			get
			{
				if(r_MShowPopup == null)
				{
					r_MShowPopup = new(this, "ShowPopup", 0);
					r_MShowPopup.SetBelong(this.GetValue());
				}
				return r_MShowPopup;
			}
		}

		/// <summary>
		/// Void ShowModalUtility()
		/// </summary>
		protected RMethod r_MShowModalUtility;
		public virtual RMethod RMShowModalUtility
		{
			get
			{
				if(r_MShowModalUtility == null)
				{
					r_MShowModalUtility = new(this, "ShowModalUtility", 0);
					r_MShowModalUtility.SetBelong(this.GetValue());
				}
				return r_MShowModalUtility;
			}
		}

		/// <summary>
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_MShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RMShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_MShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_MShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_MShowPopupWithMode_ShowMode_Boolean.SetBelong(this.GetValue());
				}
				return r_MShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWithMode(UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_MShowWithMode_ShowMode;
		public virtual RMethod RMShowWithMode_ShowMode
		{
			get
			{
				if(r_MShowWithMode_ShowMode == null)
				{
					r_MShowWithMode_ShowMode = new(this, "ShowWithMode", 0,  ReflectionUtils.GetType("UnityEditor.ShowMode"));
					r_MShowWithMode_ShowMode.SetBelong(this.GetValue());
				}
				return r_MShowWithMode_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2 == null)
				{
					r_MShowAsDropDown_Rect_Vector2 = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_MShowAsDropDown_Rect_Vector2.SetBelong(this.GetValue());
				}
				return r_MShowAsDropDown_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2_PopupLocationArray == null)
				{
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray.SetBelong(this.GetValue());
				}
				return r_MShowAsDropDown_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode == null)
				{
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReflectionUtils.GetType("UnityEditor.ShowMode"));
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.SetBelong(this.GetValue());
				}
				return r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
		public virtual RMethod RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean
		{
			get
			{
				if(r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean == null)
				{
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReflectionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.SetBelong(this.GetValue());
				}
				return r_MShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RMShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray == null)
				{
					r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDownFitToScreen", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.SetBelong(this.GetValue());
				}
				return r_MShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void Show()
		/// </summary>
		protected RMethod r_MShow;
		public virtual RMethod RMShow
		{
			get
			{
				if(r_MShow == null)
				{
					r_MShow = new(this, "Show", 0);
					r_MShow.SetBelong(this.GetValue());
				}
				return r_MShow;
			}
		}

		/// <summary>
		/// Void Show(Boolean)
		/// </summary>
		protected RMethod r_MShow_Boolean;
		public virtual RMethod RMShow_Boolean
		{
			get
			{
				if(r_MShow_Boolean == null)
				{
					r_MShow_Boolean = new(this, "Show", 0, typeof(System.Boolean));
					r_MShow_Boolean.SetBelong(this.GetValue());
				}
				return r_MShow_Boolean;
			}
		}

		/// <summary>
		/// Void ShowAuxWindow()
		/// </summary>
		protected RMethod r_MShowAuxWindow;
		public virtual RMethod RMShowAuxWindow
		{
			get
			{
				if(r_MShowAuxWindow == null)
				{
					r_MShowAuxWindow = new(this, "ShowAuxWindow", 0);
					r_MShowAuxWindow.SetBelong(this.GetValue());
				}
				return r_MShowAuxWindow;
			}
		}

		/// <summary>
		/// Void ShowModal()
		/// </summary>
		protected RMethod r_MShowModal;
		public virtual RMethod RMShowModal
		{
			get
			{
				if(r_MShowModal == null)
				{
					r_MShowModal = new(this, "ShowModal", 0);
					r_MShowModal.SetBelong(this.GetValue());
				}
				return r_MShowModal;
			}
		}

		/// <summary>
		/// Void RemoveFromDockArea()
		/// </summary>
		protected RMethod r_MRemoveFromDockArea;
		public virtual RMethod RMRemoveFromDockArea
		{
			get
			{
				if(r_MRemoveFromDockArea == null)
				{
					r_MRemoveFromDockArea = new(this, "RemoveFromDockArea", 0);
					r_MRemoveFromDockArea.SetBelong(this.GetValue());
				}
				return r_MRemoveFromDockArea;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
					r_MClose.SetBelong(this.GetValue());
				}
				return r_MClose;
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
					r_MRepaint.SetBelong(this.GetValue());
				}
				return r_MRepaint;
			}
		}

		/// <summary>
		/// Void RepaintImmediately()
		/// </summary>
		protected RMethod r_MRepaintImmediately;
		public virtual RMethod RMRepaintImmediately
		{
			get
			{
				if(r_MRepaintImmediately == null)
				{
					r_MRepaintImmediately = new(this, "RepaintImmediately", 0);
					r_MRepaintImmediately.SetBelong(this.GetValue());
				}
				return r_MRepaintImmediately;
			}
		}

		/// <summary>
		/// Void SetParentGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetParentGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RMSetParentGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_MSetParentGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_MSetParentGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetParentGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_MSetParentGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetParentGameViewDimensions_Rect_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void SetPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetPlayModeViewSize_Vector2;
		public virtual RMethod RMSetPlayModeViewSize_Vector2
		{
			get
			{
				if(r_MSetPlayModeViewSize_Vector2 == null)
				{
					r_MSetPlayModeViewSize_Vector2 = new(this, "SetPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_MSetPlayModeViewSize_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetMainPlayModeViewSize_Vector2;
		public virtual RMethod RMSetMainPlayModeViewSize_Vector2
		{
			get
			{
				if(r_MSetMainPlayModeViewSize_Vector2 == null)
				{
					r_MSetMainPlayModeViewSize_Vector2 = new(this, "SetMainPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_MSetMainPlayModeViewSize_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetMainPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetDisplayViewSize_Int32_Vector2;
		public virtual RMethod RMSetDisplayViewSize_Int32_Vector2
		{
			get
			{
				if(r_MSetDisplayViewSize_Int32_Vector2 == null)
				{
					r_MSetDisplayViewSize_Int32_Vector2 = new(this, "SetDisplayViewSize", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_MSetDisplayViewSize_Int32_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetDisplayViewSize_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetDisplayViewSize(Int32)
		/// </summary>
		protected RMethod r_MGetDisplayViewSize_Int32;
		public virtual RMethod RMGetDisplayViewSize_Int32
		{
			get
			{
				if(r_MGetDisplayViewSize_Int32 == null)
				{
					r_MGetDisplayViewSize_Int32 = new(this, "GetDisplayViewSize", 0, typeof(System.Int32));
					r_MGetDisplayViewSize_Int32.SetBelong(this.GetValue());
				}
				return r_MGetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetPlayModeView(Boolean)
		/// </summary>
		protected RMethod r_MSetPlayModeView_Boolean;
		public virtual RMethod RMSetPlayModeView_Boolean
		{
			get
			{
				if(r_MSetPlayModeView_Boolean == null)
				{
					r_MSetPlayModeView_Boolean = new(this, "SetPlayModeView", 0, typeof(System.Boolean));
					r_MSetPlayModeView_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MSendEvent_Event;
		public virtual RMethod RMSendEvent_Event
		{
			get
			{
				if(r_MSendEvent_Event == null)
				{
					r_MSendEvent_Event = new(this, "SendEvent", 0, typeof(UnityEngine.Event));
					r_MSendEvent_Event.SetBelong(this.GetValue());
				}
				return r_MSendEvent_Event;
			}
		}

		/// <summary>
		/// Void AddSceneTab()
		/// </summary>
		protected RMethod r_MAddSceneTab;
		public virtual RMethod RMAddSceneTab
		{
			get
			{
				if(r_MAddSceneTab == null)
				{
					r_MAddSceneTab = new(this, "AddSceneTab", 0);
					r_MAddSceneTab.SetBelong(this.GetValue());
				}
				return r_MAddSceneTab;
			}
		}

		/// <summary>
		/// Void AddGameTab()
		/// </summary>
		protected RMethod r_MAddGameTab;
		public virtual RMethod RMAddGameTab
		{
			get
			{
				if(r_MAddGameTab == null)
				{
					r_MAddGameTab = new(this, "AddGameTab", 0);
					r_MAddGameTab.SetBelong(this.GetValue());
				}
				return r_MAddGameTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetExtraPaneTypes()
		/// </summary>
		protected RMethod r_MGetExtraPaneTypes;
		public virtual RMethod RMGetExtraPaneTypes
		{
			get
			{
				if(r_MGetExtraPaneTypes == null)
				{
					r_MGetExtraPaneTypes = new(this, "GetExtraPaneTypes", 0);
					r_MGetExtraPaneTypes.SetBelong(this.GetValue());
				}
				return r_MGetExtraPaneTypes;
			}
		}

		/// <summary>
		/// Boolean TryGetOverlay(System.String, UnityEditor.Overlays.Overlay ByRef)
		/// </summary>
		protected RMethod r_MTryGetOverlay_String_Out_Overlay;
		public virtual RMethod RMTryGetOverlay_String_Out_Overlay
		{
			get
			{
				if(r_MTryGetOverlay_String_Out_Overlay == null)
				{
					r_MTryGetOverlay_String_Out_Overlay = new(this, "TryGetOverlay", 0, typeof(System.String), typeof(UnityEditor.Overlays.Overlay).MakeByRefType());
					r_MTryGetOverlay_String_Out_Overlay.SetBelong(this.GetValue());
				}
				return r_MTryGetOverlay_String_Out_Overlay;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChangedInternal()
		/// </summary>
		protected RMethod r_MOnBackingScaleFactorChangedInternal;
		public virtual RMethod RMOnBackingScaleFactorChangedInternal
		{
			get
			{
				if(r_MOnBackingScaleFactorChangedInternal == null)
				{
					r_MOnBackingScaleFactorChangedInternal = new(this, "OnBackingScaleFactorChangedInternal", 0);
					r_MOnBackingScaleFactorChangedInternal.SetBelong(this.GetValue());
				}
				return r_MOnBackingScaleFactorChangedInternal;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChanged()
		/// </summary>
		protected RMethod r_MOnBackingScaleFactorChanged;
		public virtual RMethod RMOnBackingScaleFactorChanged
		{
			get
			{
				if(r_MOnBackingScaleFactorChanged == null)
				{
					r_MOnBackingScaleFactorChanged = new(this, "OnBackingScaleFactorChanged", 0);
					r_MOnBackingScaleFactorChanged.SetBelong(this.GetValue());
				}
				return r_MOnBackingScaleFactorChanged;
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
					r_MSetDirty.SetBelong(this.GetValue());
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
					r_MGetInstanceID.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RPreviewWindow() : base("UnityEditor.PreviewWindow")
        {
        }

        public RPreviewWindow(System.Object instance) : base("UnityEditor.PreviewWindow")
		{
            SetInstance(instance);
		}

        public RPreviewWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPreviewWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetParentInspector(Hvak.Editor.Refleaction.RUnityEditor.RInspectorWindow @inspector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inspector.Value};
            var ___result = RMSetParentInspector_InspectorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
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


        public virtual void CreateTracker()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.Editor GetLastInteractedEditor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLastInteractedEditor.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public virtual void RebuildContentsContainers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuildContentsContainers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawPreview()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawPreview.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddItemsToMenu(UnityEditor.GenericMenu @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu};
            var ___result = RMAddItemsToMenu_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowButton(UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RMShowButton_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanMaximize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanMaximize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__RebuildContentsContainers__1__b__10_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0__RebuildContentsContainers__1__b__10_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdateSupportedDataModes(System.Collections.Generic.List<UnityEditor.DataMode> @supportedModes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@supportedModes};
            var ___result = RMOnUpdateSupportedDataModes_List_d_DataMode_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshTitle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWindowObjectNameTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWindowObjectNameTitle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CloseIfEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCloseIfEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void BeginRebuildContentContainers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginRebuildContentContainers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean BeginDrawPreviewAndLabels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginDrawPreviewAndLabels.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EndDrawPreviewAndLabels(UnityEngine.Event @evt, UnityEngine.Rect @rect, UnityEngine.Rect @dragRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @rect, @dragRect};
            var ___result = RMEndDrawPreviewAndLabels_Event_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectsLocked(System.Collections.Generic.List<UnityEngine.Object> @objs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objs};
            var ___result = RMGetObjectsLocked_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetObjectsLocked(System.Collections.Generic.List<UnityEngine.Object> @objs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objs};
            var ___result = RMSetObjectsLocked_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Object GetInspectedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInspectedObject.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.Object[] GetInspectedObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInspectedObjects.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual void OnFocusChanged(System.Boolean @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focus};
            var ___result = RMOnFocusChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInspectorUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnInspectorUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMode(UnityEditor.InspectorMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RMSetMode_InspectorMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTitle(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMSetTitle_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadVisualTreeFromUxml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadVisualTreeFromUxml.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearEditorsAndRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearEditorsAndRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDebugItemsToMenu(UnityEditor.GenericMenu @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu};
            var ___result = RMAddDebugItemsToMenu_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExpandAllComponents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExpandAllComponents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAnyComponentCollapsed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAnyComponentCollapsed.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CollapseAllComponents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCollapseAllComponents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAnyComponentExpanded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAnyComponentExpanded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean LoadPersistedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadPersistedObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreatePreviewables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreatePreviewables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPreviewables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPreviewables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action @onGUIHandler, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@onGUIHandler, @name};
            var ___result = RMCreateIMGUIContainer_Action_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IMGUIContainer)___result;
        }


        public virtual void EndRebuildContentContainers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndRebuildContentContainers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AutoScroll(UnityEngine.Vector2 @mousePosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mousePosition};
            var ___result = RMAutoScroll_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollTo(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMScrollTo_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable GetEditorThatControlsPreview(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable> @editors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors.Value};
            var ___result = RMGetEditorThatControlsPreview_IPreviewableArray.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable> GetEditorsWithPreviews(UnityEditor.Editor[] @editors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors};
            var ___result = RMGetEditorsWithPreviews_EditorArray.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RIPreviewable>(___result);
        }


        public virtual System.Boolean WasEditorVisible(UnityEditor.Editor[] @editors, System.Int32 @editorIndex, UnityEngine.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @target};
            var ___result = RMWasEditorVisible_EditorArray_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldCullEditor(UnityEditor.Editor[] @editors, System.Int32 @editorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex};
            var ___result = RMShouldCullEditor_EditorArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual void UnsavedChangesStateChanged(UnityEditor.Editor @editor, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @value};
            var ___result = RMUnsavedChangesStateChanged_Editor_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSupportedDataModesList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateSupportedDataModesList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataModeController GetDataModeController_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataModeController_Internal.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RDataModeController(___result);
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RISerializableJsonDictionary GetViewDataDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetViewDataDictionary.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RISerializableJsonDictionary(___result);
        }


        public virtual void DisableViewDataPersistence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDisableViewDataPersistence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPersistentViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPersistentViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnResized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnResized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackgroundViewResized(UnityEngine.Rect @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMOnBackgroundViewResized_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckForWindowRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckForWindowRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIContent GetLocalizedTitleContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLocalizedTitleContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void ShowNotification(UnityEngine.GUIContent @notification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification};
            var ___result = RMShowNotification_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNotification(UnityEngine.GUIContent @notification, System.Double @fadeoutWait)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification, @fadeoutWait};
            var ___result = RMShowNotification_GUIContent_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMaximized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnMaximized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetNumTabs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNumTabs.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean ShowNextTabIfPossible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowNextTabIfPossible.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSelectedTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsSelectedTab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeParentsSettingsMatchMe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeParentsSettingsMatchMe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModalUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowModalUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopupWithMode(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value, @giveFocus};
            var ___result = RMShowPopupWithMode_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowWithMode(Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value};
            var ___result = RMShowWithMode_ShowMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize};
            var ___result = RMShowAsDropDown_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value};
            var ___result = RMShowAsDropDown_Rect_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder, Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value, @mode.Value};
            var ___result = RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAsDropDown(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder, Hvak.Editor.Refleaction.RUnityEditor.RShowMode @mode, System.Boolean @giveFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value, @mode.Value, @giveFocus};
            var ___result = RMShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect @buttonRect, UnityEngine.Vector2 @windowSize, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.RPopupLocation> @locationPriorityOrder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize, @locationPriorityOrder.Value};
            var ___result = RMShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Show()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Show(System.Boolean @immediateDisplay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@immediateDisplay};
            var ___result = RMShow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAuxWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowAuxWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowModal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromDockArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromDockArea.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RepaintImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaintImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParentGameViewDimensions(UnityEngine.Rect @rect, UnityEngine.Rect @clippedRect, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RMSetParentGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeViewSize(UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RMSetPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMainPlayModeViewSize(UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RMSetMainPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDisplayViewSize(System.Int32 @displayId, UnityEngine.Vector2 @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RMSetDisplayViewSize_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetDisplayViewSize(System.Int32 @displayId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId};
            var ___result = RMGetDisplayViewSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetPlayModeView(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddSceneTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddSceneTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddGameTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddGameTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerable<System.Type> GetExtraPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExtraPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual System.Boolean TryGetOverlay(System.String @id, out UnityEditor.Overlays.Overlay @match)
        {
			@match = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @match};
            var ___result = RMTryGetOverlay_String_Out_Overlay.Invoke(___genericsType, ___parameters);
			@match = (UnityEditor.Overlays.Overlay)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void OnBackingScaleFactorChangedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBackingScaleFactorChangedInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
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
