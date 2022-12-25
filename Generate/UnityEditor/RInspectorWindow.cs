using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.InspectorWindow
	/// </summary>
    public partial class RInspectorWindow : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.InspectorWindow] m_AllInspectors
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEditor.RInspectorWindow> r_m_AllInspectors;
		public static RSystem.RCollections.RGeneric.RList<RUnityEditor.RInspectorWindow> Rm_AllInspectors
		{
			get
			{
				if(r_m_AllInspectors == null)
				{
					r_m_AllInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "m_AllInspectors");
					r_m_AllInspectors.SetBelong(null);
				}
				return r_m_AllInspectors;
			}
		}

		/// <summary>
		/// System.Boolean s_AllOptimizedGUIBlocksNeedsRebuild
		/// </summary>
		protected static RField r_s_AllOptimizedGUIBlocksNeedsRebuild;
		public static RField Rs_AllOptimizedGUIBlocksNeedsRebuild
		{
			get
			{
				if(r_s_AllOptimizedGUIBlocksNeedsRebuild == null)
				{
					r_s_AllOptimizedGUIBlocksNeedsRebuild = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "s_AllOptimizedGUIBlocksNeedsRebuild");
					r_s_AllOptimizedGUIBlocksNeedsRebuild.SetBelong(null);
				}
				return r_s_AllOptimizedGUIBlocksNeedsRebuild;
			}
		}

		/// <summary>
		/// UnityEditor.EditorGUIUtility+EditorLockTrackerWithActiveEditorTracker m_LockTracker
		/// </summary>
		protected RUnityEditor.REditorGUIUtility.REditorLockTrackerWithActiveEditorTracker r_m_LockTracker;
		public virtual RUnityEditor.REditorGUIUtility.REditorLockTrackerWithActiveEditorTracker Rm_LockTracker
		{
			get
			{
				if(r_m_LockTracker == null)
				{
					r_m_LockTracker = new(this, "m_LockTracker");
					r_m_LockTracker.SetBelong(this.instance);
				}
				return r_m_LockTracker;
			}
		}

		/// <summary>
		/// UnityEditor.PreviewWindow m_PreviewWindow
		/// </summary>
		protected RUnityEditor.RPreviewWindow r_m_PreviewWindow;
		public virtual RUnityEditor.RPreviewWindow Rm_PreviewWindow
		{
			get
			{
				if(r_m_PreviewWindow == null)
				{
					r_m_PreviewWindow = new(this, "m_PreviewWindow");
					r_m_PreviewWindow.SetBelong(this.instance);
				}
				return r_m_PreviewWindow;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEditor.DataMode] m_UserSupportedDataModes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RField> r_m_UserSupportedDataModes;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RField> Rm_UserSupportedDataModes
		{
			get
			{
				if(r_m_UserSupportedDataModes == null)
				{
					r_m_UserSupportedDataModes = new(this, "m_UserSupportedDataModes");
					r_m_UserSupportedDataModes.SetBelong(this.instance);
				}
				return r_m_UserSupportedDataModes;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer m_TrackerResetter
		/// </summary>
		protected RUnityEngine.RUIElements.RIMGUIContainer r_m_TrackerResetter;
		public virtual RUnityEngine.RUIElements.RIMGUIContainer Rm_TrackerResetter
		{
			get
			{
				if(r_m_TrackerResetter == null)
				{
					r_m_TrackerResetter = new(this, "m_TrackerResetter");
					r_m_TrackerResetter.SetBelong(this.instance);
				}
				return r_m_TrackerResetter;
			}
		}

		/// <summary>
		/// System.Int64 m_LastUpdateWhilePlayingAnimation
		/// </summary>
		protected RField r_m_LastUpdateWhilePlayingAnimation;
		public virtual RField Rm_LastUpdateWhilePlayingAnimation
		{
			get
			{
				if(r_m_LastUpdateWhilePlayingAnimation == null)
				{
					r_m_LastUpdateWhilePlayingAnimation = new(this, "m_LastUpdateWhilePlayingAnimation");
					r_m_LastUpdateWhilePlayingAnimation.SetBelong(this.instance);
				}
				return r_m_LastUpdateWhilePlayingAnimation;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Object] m_ObjectsLockedBeforeSerialization
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RObject> r_m_ObjectsLockedBeforeSerialization;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RObject> Rm_ObjectsLockedBeforeSerialization
		{
			get
			{
				if(r_m_ObjectsLockedBeforeSerialization == null)
				{
					r_m_ObjectsLockedBeforeSerialization = new(this, "m_ObjectsLockedBeforeSerialization");
					r_m_ObjectsLockedBeforeSerialization.SetBelong(this.instance);
				}
				return r_m_ObjectsLockedBeforeSerialization;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_InstanceIDsLockedBeforeSerialization
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_InstanceIDsLockedBeforeSerialization;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_InstanceIDsLockedBeforeSerialization
		{
			get
			{
				if(r_m_InstanceIDsLockedBeforeSerialization == null)
				{
					r_m_InstanceIDsLockedBeforeSerialization = new(this, "m_InstanceIDsLockedBeforeSerialization");
					r_m_InstanceIDsLockedBeforeSerialization.SetBelong(this.instance);
				}
				return r_m_InstanceIDsLockedBeforeSerialization;
			}
		}

		/// <summary>
		/// UnityEditor.PreviewResizer m_PreviewResizer
		/// </summary>
		protected RUnityEditor.RPreviewResizer r_m_PreviewResizer;
		public virtual RUnityEditor.RPreviewResizer Rm_PreviewResizer
		{
			get
			{
				if(r_m_PreviewResizer == null)
				{
					r_m_PreviewResizer = new(this, "m_PreviewResizer");
					r_m_PreviewResizer.SetBelong(this.instance);
				}
				return r_m_PreviewResizer;
			}
		}

		/// <summary>
		/// UnityEditor.LabelGUI m_LabelGUI
		/// </summary>
		protected RUnityEditor.RLabelGUI r_m_LabelGUI;
		public virtual RUnityEditor.RLabelGUI Rm_LabelGUI
		{
			get
			{
				if(r_m_LabelGUI == null)
				{
					r_m_LabelGUI = new(this, "m_LabelGUI");
					r_m_LabelGUI.SetBelong(this.instance);
				}
				return r_m_LabelGUI;
			}
		}

		/// <summary>
		/// System.Int32 m_LastInspectedObjectInstanceID
		/// </summary>
		protected RField r_m_LastInspectedObjectInstanceID;
		public virtual RField Rm_LastInspectedObjectInstanceID
		{
			get
			{
				if(r_m_LastInspectedObjectInstanceID == null)
				{
					r_m_LastInspectedObjectInstanceID = new(this, "m_LastInspectedObjectInstanceID");
					r_m_LastInspectedObjectInstanceID.SetBelong(this.instance);
				}
				return r_m_LastInspectedObjectInstanceID;
			}
		}

		/// <summary>
		/// System.Single m_LastVerticalScrollValue
		/// </summary>
		protected RField r_m_LastVerticalScrollValue;
		public virtual RField Rm_LastVerticalScrollValue
		{
			get
			{
				if(r_m_LastVerticalScrollValue == null)
				{
					r_m_LastVerticalScrollValue = new(this, "m_LastVerticalScrollValue");
					r_m_LastVerticalScrollValue.SetBelong(this.instance);
				}
				return r_m_LastVerticalScrollValue;
			}
		}

		/// <summary>
		/// System.String m_GlobalObjectId
		/// </summary>
		protected RField r_m_GlobalObjectId;
		public virtual RField Rm_GlobalObjectId
		{
			get
			{
				if(r_m_GlobalObjectId == null)
				{
					r_m_GlobalObjectId = new(this, "m_GlobalObjectId");
					r_m_GlobalObjectId.SetBelong(this.instance);
				}
				return r_m_GlobalObjectId;
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
		/// System.Int32 m_LastInitialEditorInstanceID
		/// </summary>
		protected RField r_m_LastInitialEditorInstanceID;
		public virtual RField Rm_LastInitialEditorInstanceID
		{
			get
			{
				if(r_m_LastInitialEditorInstanceID == null)
				{
					r_m_LastInitialEditorInstanceID = new(this, "m_LastInitialEditorInstanceID");
					r_m_LastInitialEditorInstanceID.SetBelong(this.instance);
				}
				return r_m_LastInitialEditorInstanceID;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] m_ComponentsInPrefabSource
		/// </summary>
		protected RFieldArray<RUnityEngine.RComponent> r_m_ComponentsInPrefabSource;
		public virtual RFieldArray<RUnityEngine.RComponent> Rm_ComponentsInPrefabSource
		{
			get
			{
				if(r_m_ComponentsInPrefabSource == null)
				{
					r_m_ComponentsInPrefabSource = new(this, "m_ComponentsInPrefabSource");
					r_m_ComponentsInPrefabSource.SetBelong(this.instance);
				}
				return r_m_ComponentsInPrefabSource;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.Component] m_RemovedComponents
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RComponent> r_m_RemovedComponents;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RComponent> Rm_RemovedComponents
		{
			get
			{
				if(r_m_RemovedComponents == null)
				{
					r_m_RemovedComponents = new(this, "m_RemovedComponents");
					r_m_RemovedComponents.SetBelong(this.instance);
				}
				return r_m_RemovedComponents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.Component] m_SuppressedComponents
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RComponent> r_m_SuppressedComponents;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RComponent> Rm_SuppressedComponents
		{
			get
			{
				if(r_m_SuppressedComponents == null)
				{
					r_m_SuppressedComponents = new(this, "m_SuppressedComponents");
					r_m_SuppressedComponents.SetBelong(this.instance);
				}
				return r_m_SuppressedComponents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[UnityEngine.Component]] m_RemovedComponentDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RComponent>> r_m_RemovedComponentDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RComponent>> Rm_RemovedComponentDict
		{
			get
			{
				if(r_m_RemovedComponentDict == null)
				{
					r_m_RemovedComponentDict = new(this, "m_RemovedComponentDict");
					r_m_RemovedComponentDict.SetBelong(this.instance);
				}
				return r_m_RemovedComponentDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Component] m_AdditionalRemovedComponents
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RComponent> r_m_AdditionalRemovedComponents;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RComponent> Rm_AdditionalRemovedComponents
		{
			get
			{
				if(r_m_AdditionalRemovedComponents == null)
				{
					r_m_AdditionalRemovedComponents = new(this, "m_AdditionalRemovedComponents");
					r_m_AdditionalRemovedComponents.SetBelong(this.instance);
				}
				return r_m_AdditionalRemovedComponents;
			}
		}

		/// <summary>
		/// System.Boolean m_ResetKeyboardControl
		/// </summary>
		protected RField r_m_ResetKeyboardControl;
		public virtual RField Rm_ResetKeyboardControl
		{
			get
			{
				if(r_m_ResetKeyboardControl == null)
				{
					r_m_ResetKeyboardControl = new(this, "m_ResetKeyboardControl");
					r_m_ResetKeyboardControl.SetBelong(this.instance);
				}
				return r_m_ResetKeyboardControl;
			}
		}

		/// <summary>
		/// System.Boolean m_OpenAddComponentMenu
		/// </summary>
		protected RField r_m_OpenAddComponentMenu;
		public virtual RField Rm_OpenAddComponentMenu
		{
			get
			{
				if(r_m_OpenAddComponentMenu == null)
				{
					r_m_OpenAddComponentMenu = new(this, "m_OpenAddComponentMenu");
					r_m_OpenAddComponentMenu.SetBelong(this.instance);
				}
				return r_m_OpenAddComponentMenu;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker m_Tracker
		/// </summary>
		protected RUnityEditor.RActiveEditorTracker r_m_Tracker;
		public virtual RUnityEditor.RActiveEditorTracker Rm_Tracker
		{
			get
			{
				if(r_m_Tracker == null)
				{
					r_m_Tracker = new(this, "m_Tracker");
					r_m_Tracker.SetBelong(this.instance);
				}
				return r_m_Tracker;
			}
		}

		/// <summary>
		/// UnityEditor.AssetBundleNameGUI m_AssetBundleNameGUI
		/// </summary>
		protected RUnityEditor.RAssetBundleNameGUI r_m_AssetBundleNameGUI;
		public virtual RUnityEditor.RAssetBundleNameGUI Rm_AssetBundleNameGUI
		{
			get
			{
				if(r_m_AssetBundleNameGUI == null)
				{
					r_m_AssetBundleNameGUI = new(this, "m_AssetBundleNameGUI");
					r_m_AssetBundleNameGUI.SetBelong(this.instance);
				}
				return r_m_AssetBundleNameGUI;
			}
		}

		/// <summary>
		/// UnityEditor.TypeSelectionList m_TypeSelectionList
		/// </summary>
		protected RUnityEditor.RTypeSelectionList r_m_TypeSelectionList;
		public virtual RUnityEditor.RTypeSelectionList Rm_TypeSelectionList
		{
			get
			{
				if(r_m_TypeSelectionList == null)
				{
					r_m_TypeSelectionList = new(this, "m_TypeSelectionList");
					r_m_TypeSelectionList.SetBelong(this.instance);
				}
				return r_m_TypeSelectionList;
			}
		}

		/// <summary>
		/// System.Double m_lastRenderedTime
		/// </summary>
		protected RField r_m_lastRenderedTime;
		public virtual RField Rm_lastRenderedTime
		{
			get
			{
				if(r_m_lastRenderedTime == null)
				{
					r_m_lastRenderedTime = new(this, "m_lastRenderedTime");
					r_m_lastRenderedTime.SetBelong(this.instance);
				}
				return r_m_lastRenderedTime;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.IPreviewable] m_Previews
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RIPreviewable> r_m_Previews;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RIPreviewable> Rm_Previews
		{
			get
			{
				if(r_m_Previews == null)
				{
					r_m_Previews = new(this, "m_Previews");
					r_m_Previews.SetBelong(this.instance);
				}
				return r_m_Previews;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Type,System.Collections.Generic.List`1[System.Type]] m_PreviewableTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RSystem.RCollections.RGeneric.RList<RSystem.RType>> r_m_PreviewableTypes;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RSystem.RCollections.RGeneric.RList<RSystem.RType>> Rm_PreviewableTypes
		{
			get
			{
				if(r_m_PreviewableTypes == null)
				{
					r_m_PreviewableTypes = new(this, "m_PreviewableTypes");
					r_m_PreviewableTypes.SetBelong(this.instance);
				}
				return r_m_PreviewableTypes;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable m_SelectedPreview
		/// </summary>
		protected RUnityEditor.RIPreviewable r_m_SelectedPreview;
		public virtual RUnityEditor.RIPreviewable Rm_SelectedPreview
		{
			get
			{
				if(r_m_SelectedPreview == null)
				{
					r_m_SelectedPreview = new(this, "m_SelectedPreview");
					r_m_SelectedPreview.SetBelong(this.instance);
				}
				return r_m_SelectedPreview;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_EditorsElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_EditorsElement;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_EditorsElement
		{
			get
			{
				if(r_m_EditorsElement == null)
				{
					r_m_EditorsElement = new(this, "m_EditorsElement");
					r_m_EditorsElement.SetBelong(this.instance);
				}
				return r_m_EditorsElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_RemovedPrefabComponentsElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_RemovedPrefabComponentsElement;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_RemovedPrefabComponentsElement
		{
			get
			{
				if(r_m_RemovedPrefabComponentsElement == null)
				{
					r_m_RemovedPrefabComponentsElement = new(this, "m_RemovedPrefabComponentsElement");
					r_m_RemovedPrefabComponentsElement.SetBelong(this.instance);
				}
				return r_m_RemovedPrefabComponentsElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_PreviewAndLabelElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_PreviewAndLabelElement;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_PreviewAndLabelElement
		{
			get
			{
				if(r_m_PreviewAndLabelElement == null)
				{
					r_m_PreviewAndLabelElement = new(this, "m_PreviewAndLabelElement");
					r_m_PreviewAndLabelElement.SetBelong(this.instance);
				}
				return r_m_PreviewAndLabelElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_VersionControlElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_VersionControlElement;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_VersionControlElement
		{
			get
			{
				if(r_m_VersionControlElement == null)
				{
					r_m_VersionControlElement = new(this, "m_VersionControlElement");
					r_m_VersionControlElement.SetBelong(this.instance);
				}
				return r_m_VersionControlElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_MultiEditLabel
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_MultiEditLabel;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_MultiEditLabel
		{
			get
			{
				if(r_m_MultiEditLabel == null)
				{
					r_m_MultiEditLabel = new(this, "m_MultiEditLabel");
					r_m_MultiEditLabel.SetBelong(this.instance);
				}
				return r_m_MultiEditLabel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView m_ScrollView
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollView r_m_ScrollView;
		public virtual RUnityEngine.RUIElements.RScrollView Rm_ScrollView
		{
			get
			{
				if(r_m_ScrollView == null)
				{
					r_m_ScrollView = new(this, "m_ScrollView");
					r_m_ScrollView.SetBelong(this.instance);
				}
				return r_m_ScrollView;
			}
		}

		/// <summary>
		/// System.Boolean m_TrackerResetInserted
		/// </summary>
		protected RField r_m_TrackerResetInserted;
		public virtual RField Rm_TrackerResetInserted
		{
			get
			{
				if(r_m_TrackerResetInserted == null)
				{
					r_m_TrackerResetInserted = new(this, "m_TrackerResetInserted");
					r_m_TrackerResetInserted.SetBelong(this.instance);
				}
				return r_m_TrackerResetInserted;
			}
		}

		/// <summary>
		/// System.Boolean m_FirstInitialize
		/// </summary>
		protected RField r_m_FirstInitialize;
		public virtual RField Rm_FirstInitialize
		{
			get
			{
				if(r_m_FirstInitialize == null)
				{
					r_m_FirstInitialize = new(this, "m_FirstInitialize");
					r_m_FirstInitialize.SetBelong(this.instance);
				}
				return r_m_FirstInitialize;
			}
		}

		/// <summary>
		/// System.Single m_PreviousFooterHeight
		/// </summary>
		protected RField r_m_PreviousFooterHeight;
		public virtual RField Rm_PreviousFooterHeight
		{
			get
			{
				if(r_m_PreviousFooterHeight == null)
				{
					r_m_PreviousFooterHeight = new(this, "m_PreviousFooterHeight");
					r_m_PreviousFooterHeight.SetBelong(this.instance);
				}
				return r_m_PreviousFooterHeight;
			}
		}

		/// <summary>
		/// System.Boolean m_PreviousPreviewExpandedState
		/// </summary>
		protected RField r_m_PreviousPreviewExpandedState;
		public virtual RField Rm_PreviousPreviewExpandedState
		{
			get
			{
				if(r_m_PreviousPreviewExpandedState == null)
				{
					r_m_PreviousPreviewExpandedState = new(this, "m_PreviousPreviewExpandedState");
					r_m_PreviousPreviewExpandedState.SetBelong(this.instance);
				}
				return r_m_PreviousPreviewExpandedState;
			}
		}

		/// <summary>
		/// System.Boolean m_HasPreview
		/// </summary>
		protected RField r_m_HasPreview;
		public virtual RField Rm_HasPreview
		{
			get
			{
				if(r_m_HasPreview == null)
				{
					r_m_HasPreview = new(this, "m_HasPreview");
					r_m_HasPreview.SetBelong(this.instance);
				}
				return r_m_HasPreview;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] m_DrawnSelection
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RField> r_m_DrawnSelection;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RField> Rm_DrawnSelection
		{
			get
			{
				if(r_m_DrawnSelection == null)
				{
					r_m_DrawnSelection = new(this, "m_DrawnSelection");
					r_m_DrawnSelection.SetBelong(this.instance);
				}
				return r_m_DrawnSelection;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_TitleContent
		/// </summary>
		protected RUnityEngine.RGUIContent r_m_TitleContent;
		public virtual RUnityEngine.RGUIContent Rm_TitleContent
		{
			get
			{
				if(r_m_TitleContent == null)
				{
					r_m_TitleContent = new(this, "m_TitleContent");
					r_m_TitleContent.SetBelong(this.instance);
				}
				return r_m_TitleContent;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_Pos
		/// </summary>
		protected RUnityEngine.RRect r_m_Pos;
		public virtual RUnityEngine.RRect Rm_Pos
		{
			get
			{
				if(r_m_Pos == null)
				{
					r_m_Pos = new(this, "m_Pos");
					r_m_Pos.SetBelong(this.instance);
				}
				return r_m_Pos;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController m_SerializedDataModeController
		/// </summary>
		protected RUnityEditor.RDataModeController r_m_SerializedDataModeController;
		public virtual RUnityEditor.RDataModeController Rm_SerializedDataModeController
		{
			get
			{
				if(r_m_SerializedDataModeController == null)
				{
					r_m_SerializedDataModeController = new(this, "m_SerializedDataModeController");
					r_m_SerializedDataModeController.SetBelong(this.instance);
				}
				return r_m_SerializedDataModeController;
			}
		}

		/// <summary>
		/// UnityEditor.HostView m_Parent
		/// </summary>
		protected RUnityEditor.RHostView r_m_Parent;
		public virtual RUnityEditor.RHostView Rm_Parent
		{
			get
			{
				if(r_m_Parent == null)
				{
					r_m_Parent = new(this, "m_Parent");
					r_m_Parent.SetBelong(this.instance);
				}
				return r_m_Parent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent m_Notification
		/// </summary>
		protected RUnityEngine.RGUIContent r_m_Notification;
		public virtual RUnityEngine.RGUIContent Rm_Notification
		{
			get
			{
				if(r_m_Notification == null)
				{
					r_m_Notification = new(this, "m_Notification");
					r_m_Notification.SetBelong(this.instance);
				}
				return r_m_Notification;
			}
		}

		/// <summary>
		/// System.Single m_FadeoutTime
		/// </summary>
		protected RField r_m_FadeoutTime;
		public virtual RField Rm_FadeoutTime
		{
			get
			{
				if(r_m_FadeoutTime == null)
				{
					r_m_FadeoutTime = new(this, "m_FadeoutTime");
					r_m_FadeoutTime.SetBelong(this.instance);
				}
				return r_m_FadeoutTime;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected RProperty r_isLocked;
		public virtual RProperty RisLocked
		{
			get
			{
				if(r_isLocked == null)
				{
					r_isLocked = new(this, "isLocked", -1);
					r_isLocked.SetBelong(this.instance);
				}
				return r_isLocked;
			}
		}

		/// <summary>
		/// Boolean isVisible
		/// </summary>
		protected RProperty r_isVisible;
		public virtual RProperty RisVisible
		{
			get
			{
				if(r_isVisible == null)
				{
					r_isVisible = new(this, "isVisible", -1);
					r_isVisible.SetBelong(this.instance);
				}
				return r_isVisible;
			}
		}

		/// <summary>
		/// Boolean sharedTrackerInUse
		/// </summary>
		protected RProperty r_sharedTrackerInUse;
		public virtual RProperty RsharedTrackerInUse
		{
			get
			{
				if(r_sharedTrackerInUse == null)
				{
					r_sharedTrackerInUse = new(this, "sharedTrackerInUse", -1);
					r_sharedTrackerInUse.SetBelong(this.instance);
				}
				return r_sharedTrackerInUse;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement editorsElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_editorsElement;
		public virtual RUnityEngine.RUIElements.RVisualElement ReditorsElement
		{
			get
			{
				if(r_editorsElement == null)
				{
					r_editorsElement = new(this, "editorsElement", -1);
					r_editorsElement.SetBelong(this.instance);
				}
				return r_editorsElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement previewAndLabelElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_previewAndLabelElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RpreviewAndLabelElement
		{
			get
			{
				if(r_previewAndLabelElement == null)
				{
					r_previewAndLabelElement = new(this, "previewAndLabelElement", -1);
					r_previewAndLabelElement.SetBelong(this.instance);
				}
				return r_previewAndLabelElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement versionControlElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_versionControlElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RversionControlElement
		{
			get
			{
				if(r_versionControlElement == null)
				{
					r_versionControlElement = new(this, "versionControlElement", -1);
					r_versionControlElement.SetBelong(this.instance);
				}
				return r_versionControlElement;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView parent
		/// </summary>
		protected RUnityEditor.RGUIView r_parent;
		public virtual RUnityEditor.RGUIView Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] editorsWithImportedObjectLabel
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RProperty> r_editorsWithImportedObjectLabel;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RProperty> ReditorsWithImportedObjectLabel
		{
			get
			{
				if(r_editorsWithImportedObjectLabel == null)
				{
					r_editorsWithImportedObjectLabel = new(this, "editorsWithImportedObjectLabel", -1);
					r_editorsWithImportedObjectLabel.SetBelong(this.instance);
				}
				return r_editorsWithImportedObjectLabel;
			}
		}

		/// <summary>
		/// UnityEditor.EditorDragging editorDragging
		/// </summary>
		protected RUnityEditor.REditorDragging r_editorDragging;
		public virtual RUnityEditor.REditorDragging ReditorDragging
		{
			get
			{
				if(r_editorDragging == null)
				{
					r_editorDragging = new(this, "editorDragging", -1);
					r_editorDragging.SetBelong(this.instance);
				}
				return r_editorDragging;
			}
		}

		/// <summary>
		/// Int32 inspectorElementModeOverride
		/// </summary>
		protected RProperty r_inspectorElementModeOverride;
		public virtual RProperty RinspectorElementModeOverride
		{
			get
			{
				if(r_inspectorElementModeOverride == null)
				{
					r_inspectorElementModeOverride = new(this, "inspectorElementModeOverride", -1);
					r_inspectorElementModeOverride.SetBelong(this.instance);
				}
				return r_inspectorElementModeOverride;
			}
		}

		/// <summary>
		/// UnityEditor.Editor lastInteractedEditor
		/// </summary>
		protected RUnityEditor.REditor r_lastInteractedEditor;
		public virtual RUnityEditor.REditor RlastInteractedEditor
		{
			get
			{
				if(r_lastInteractedEditor == null)
				{
					r_lastInteractedEditor = new(this, "lastInteractedEditor", -1);
					r_lastInteractedEditor.SetBelong(this.instance);
				}
				return r_lastInteractedEditor;
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
		/// UnityEditor.ActiveEditorTracker tracker
		/// </summary>
		protected RUnityEditor.RActiveEditorTracker r_tracker;
		public virtual RUnityEditor.RActiveEditorTracker Rtracker
		{
			get
			{
				if(r_tracker == null)
				{
					r_tracker = new(this, "tracker", -1);
					r_tracker.SetBelong(this.instance);
				}
				return r_tracker;
			}
		}

		/// <summary>
		/// UnityEngine.Rect bottomAreaDropRectangle
		/// </summary>
		protected RUnityEngine.RRect r_bottomAreaDropRectangle;
		public virtual RUnityEngine.RRect RbottomAreaDropRectangle
		{
			get
			{
				if(r_bottomAreaDropRectangle == null)
				{
					r_bottomAreaDropRectangle = new(this, "bottomAreaDropRectangle", -1);
					r_bottomAreaDropRectangle.SetBelong(this.instance);
				}
				return r_bottomAreaDropRectangle;
			}
		}

		/// <summary>
		/// UnityEngine.Rect scrollViewportRect
		/// </summary>
		protected RUnityEngine.RRect r_scrollViewportRect;
		public virtual RUnityEngine.RRect RscrollViewportRect
		{
			get
			{
				if(r_scrollViewportRect == null)
				{
					r_scrollViewportRect = new(this, "scrollViewportRect", -1);
					r_scrollViewportRect.SetBelong(this.instance);
				}
				return r_scrollViewportRect;
			}
		}

		/// <summary>
		/// UnityEditor.IDataModeController dataModeController
		/// </summary>
		protected RUnityEditor.RIDataModeController r_dataModeController;
		public virtual RUnityEditor.RIDataModeController RdataModeController
		{
			get
			{
				if(r_dataModeController == null)
				{
					r_dataModeController = new(this, "dataModeController", -1);
					r_dataModeController.SetBelong(this.instance);
				}
				return r_dataModeController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement baseRootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_baseRootVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RbaseRootVisualElement
		{
			get
			{
				if(r_baseRootVisualElement == null)
				{
					r_baseRootVisualElement = new(this, "baseRootVisualElement", -1);
					r_baseRootVisualElement.SetBelong(this.instance);
				}
				return r_baseRootVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement rootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_rootVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RrootVisualElement
		{
			get
			{
				if(r_rootVisualElement == null)
				{
					r_rootVisualElement = new(this, "rootVisualElement", -1);
					r_rootVisualElement.SetBelong(this.instance);
				}
				return r_rootVisualElement;
			}
		}

		/// <summary>
		/// Boolean liveReloadPreferenceDefault
		/// </summary>
		protected RProperty r_liveReloadPreferenceDefault;
		public virtual RProperty RliveReloadPreferenceDefault
		{
			get
			{
				if(r_liveReloadPreferenceDefault == null)
				{
					r_liveReloadPreferenceDefault = new(this, "liveReloadPreferenceDefault", -1);
					r_liveReloadPreferenceDefault.SetBelong(this.instance);
				}
				return r_liveReloadPreferenceDefault;
			}
		}

		/// <summary>
		/// Boolean isUIToolkitWindow
		/// </summary>
		protected RProperty r_isUIToolkitWindow;
		public virtual RProperty RisUIToolkitWindow
		{
			get
			{
				if(r_isUIToolkitWindow == null)
				{
					r_isUIToolkitWindow = new(this, "isUIToolkitWindow", -1);
					r_isUIToolkitWindow.SetBelong(this.instance);
				}
				return r_isUIToolkitWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas overlayCanvas
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r_overlayCanvas;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas RoverlayCanvas
		{
			get
			{
				if(r_overlayCanvas == null)
				{
					r_overlayCanvas = new(this, "overlayCanvas", -1);
					r_overlayCanvas.SetBelong(this.instance);
				}
				return r_overlayCanvas;
			}
		}

		/// <summary>
		/// UnityEditor.UIElements.SerializableJsonDictionary viewDataDictionary
		/// </summary>
		protected RUnityEditor.RUIElements.RSerializableJsonDictionary r_viewDataDictionary;
		public virtual RUnityEditor.RUIElements.RSerializableJsonDictionary RviewDataDictionary
		{
			get
			{
				if(r_viewDataDictionary == null)
				{
					r_viewDataDictionary = new(this, "viewDataDictionary", -1);
					r_viewDataDictionary.SetBelong(this.instance);
				}
				return r_viewDataDictionary;
			}
		}

		/// <summary>
		/// Boolean wantsMouseMove
		/// </summary>
		protected RProperty r_wantsMouseMove;
		public virtual RProperty RwantsMouseMove
		{
			get
			{
				if(r_wantsMouseMove == null)
				{
					r_wantsMouseMove = new(this, "wantsMouseMove", -1);
					r_wantsMouseMove.SetBelong(this.instance);
				}
				return r_wantsMouseMove;
			}
		}

		/// <summary>
		/// Boolean wantsMouseEnterLeaveWindow
		/// </summary>
		protected RProperty r_wantsMouseEnterLeaveWindow;
		public virtual RProperty RwantsMouseEnterLeaveWindow
		{
			get
			{
				if(r_wantsMouseEnterLeaveWindow == null)
				{
					r_wantsMouseEnterLeaveWindow = new(this, "wantsMouseEnterLeaveWindow", -1);
					r_wantsMouseEnterLeaveWindow.SetBelong(this.instance);
				}
				return r_wantsMouseEnterLeaveWindow;
			}
		}

		/// <summary>
		/// Boolean wantsLessLayoutEvents
		/// </summary>
		protected RProperty r_wantsLessLayoutEvents;
		public virtual RProperty RwantsLessLayoutEvents
		{
			get
			{
				if(r_wantsLessLayoutEvents == null)
				{
					r_wantsLessLayoutEvents = new(this, "wantsLessLayoutEvents", -1);
					r_wantsLessLayoutEvents.SetBelong(this.instance);
				}
				return r_wantsLessLayoutEvents;
			}
		}

		/// <summary>
		/// Boolean autoRepaintOnSceneChange
		/// </summary>
		protected RProperty r_autoRepaintOnSceneChange;
		public virtual RProperty RautoRepaintOnSceneChange
		{
			get
			{
				if(r_autoRepaintOnSceneChange == null)
				{
					r_autoRepaintOnSceneChange = new(this, "autoRepaintOnSceneChange", -1);
					r_autoRepaintOnSceneChange.SetBelong(this.instance);
				}
				return r_autoRepaintOnSceneChange;
			}
		}

		/// <summary>
		/// Boolean maximized
		/// </summary>
		protected RProperty r_maximized;
		public virtual RProperty Rmaximized
		{
			get
			{
				if(r_maximized == null)
				{
					r_maximized = new(this, "maximized", -1);
					r_maximized.SetBelong(this.instance);
				}
				return r_maximized;
			}
		}

		/// <summary>
		/// Boolean hasFocus
		/// </summary>
		protected RProperty r_hasFocus;
		public virtual RProperty RhasFocus
		{
			get
			{
				if(r_hasFocus == null)
				{
					r_hasFocus = new(this, "hasFocus", -1);
					r_hasFocus.SetBelong(this.instance);
				}
				return r_hasFocus;
			}
		}

		/// <summary>
		/// Boolean docked
		/// </summary>
		protected RProperty r_docked;
		public virtual RProperty Rdocked
		{
			get
			{
				if(r_docked == null)
				{
					r_docked = new(this, "docked", -1);
					r_docked.SetBelong(this.instance);
				}
				return r_docked;
			}
		}

		/// <summary>
		/// Boolean disableInputEvents
		/// </summary>
		protected RProperty r_disableInputEvents;
		public virtual RProperty RdisableInputEvents
		{
			get
			{
				if(r_disableInputEvents == null)
				{
					r_disableInputEvents = new(this, "disableInputEvents", -1);
					r_disableInputEvents.SetBelong(this.instance);
				}
				return r_disableInputEvents;
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
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected RUnityEngine.RVector2 r_minSize;
		public virtual RUnityEngine.RVector2 RminSize
		{
			get
			{
				if(r_minSize == null)
				{
					r_minSize = new(this, "minSize", -1);
					r_minSize.SetBelong(this.instance);
				}
				return r_minSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_maxSize;
		public virtual RUnityEngine.RVector2 RmaxSize
		{
			get
			{
				if(r_maxSize == null)
				{
					r_maxSize = new(this, "maxSize", -1);
					r_maxSize.SetBelong(this.instance);
				}
				return r_maxSize;
			}
		}

		/// <summary>
		/// System.String title
		/// </summary>
		protected RProperty r_title;
		public virtual RProperty Rtitle
		{
			get
			{
				if(r_title == null)
				{
					r_title = new(this, "title", -1);
					r_title.SetBelong(this.instance);
				}
				return r_title;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent titleContent
		/// </summary>
		protected RUnityEngine.RGUIContent r_titleContent;
		public virtual RUnityEngine.RGUIContent RtitleContent
		{
			get
			{
				if(r_titleContent == null)
				{
					r_titleContent = new(this, "titleContent", -1);
					r_titleContent.SetBelong(this.instance);
				}
				return r_titleContent;
			}
		}

		/// <summary>
		/// Int32 depthBufferBits
		/// </summary>
		protected RProperty r_depthBufferBits;
		public virtual RProperty RdepthBufferBits
		{
			get
			{
				if(r_depthBufferBits == null)
				{
					r_depthBufferBits = new(this, "depthBufferBits", -1);
					r_depthBufferBits.SetBelong(this.instance);
				}
				return r_depthBufferBits;
			}
		}

		/// <summary>
		/// Int32 antiAliasing
		/// </summary>
		protected RProperty r_antiAliasing;
		public virtual RProperty RantiAliasing
		{
			get
			{
				if(r_antiAliasing == null)
				{
					r_antiAliasing = new(this, "antiAliasing", -1);
					r_antiAliasing.SetBelong(this.instance);
				}
				return r_antiAliasing;
			}
		}

		/// <summary>
		/// Int32 antiAlias
		/// </summary>
		protected RProperty r_antiAlias;
		public virtual RProperty RantiAlias
		{
			get
			{
				if(r_antiAlias == null)
				{
					r_antiAlias = new(this, "antiAlias", -1);
					r_antiAlias.SetBelong(this.instance);
				}
				return r_antiAlias;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected RUnityEngine.RRect r_position;
		public virtual RUnityEngine.RRect Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
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
		/// Void Awake()
		/// </summary>
		protected RMethod r_RAwake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_RAwake == null)
				{
					r_RAwake = new(this, "Awake", 0);
					r_RAwake.SetBelong(this.instance);
				}
				return r_RAwake;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_ROnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_ROnDestroy == null)
				{
					r_ROnDestroy = new(this, "OnDestroy", 0);
					r_ROnDestroy.SetBelong(this.instance);
				}
				return r_ROnDestroy;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_ROnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_ROnEnable == null)
				{
					r_ROnEnable = new(this, "OnEnable", 0);
					r_ROnEnable.SetBelong(this.instance);
				}
				return r_ROnEnable;
			}
		}

		/// <summary>
		/// Void OnAfterAssemblyReload()
		/// </summary>
		protected RMethod r_ROnAfterAssemblyReload;
		public virtual RMethod ROnAfterAssemblyReload
		{
			get
			{
				if(r_ROnAfterAssemblyReload == null)
				{
					r_ROnAfterAssemblyReload = new(this, "OnAfterAssemblyReload", 0);
					r_ROnAfterAssemblyReload.SetBelong(this.instance);
				}
				return r_ROnAfterAssemblyReload;
			}
		}

		/// <summary>
		/// Void OnBecameVisible()
		/// </summary>
		protected RMethod r_ROnBecameVisible;
		public virtual RMethod ROnBecameVisible
		{
			get
			{
				if(r_ROnBecameVisible == null)
				{
					r_ROnBecameVisible = new(this, "OnBecameVisible", 0);
					r_ROnBecameVisible.SetBelong(this.instance);
				}
				return r_ROnBecameVisible;
			}
		}

		/// <summary>
		/// Void OnBecameInvisible()
		/// </summary>
		protected RMethod r_ROnBecameInvisible;
		public virtual RMethod ROnBecameInvisible
		{
			get
			{
				if(r_ROnBecameInvisible == null)
				{
					r_ROnBecameInvisible = new(this, "OnBecameInvisible", 0);
					r_ROnBecameInvisible.SetBelong(this.instance);
				}
				return r_ROnBecameInvisible;
			}
		}

		/// <summary>
		/// Void OnProjectWasLoaded()
		/// </summary>
		protected RMethod r_ROnProjectWasLoaded;
		public virtual RMethod ROnProjectWasLoaded
		{
			get
			{
				if(r_ROnProjectWasLoaded == null)
				{
					r_ROnProjectWasLoaded = new(this, "OnProjectWasLoaded", 0);
					r_ROnProjectWasLoaded.SetBelong(this.instance);
				}
				return r_ROnProjectWasLoaded;
			}
		}

		/// <summary>
		/// Void OnSelectionChanged()
		/// </summary>
		protected RMethod r_ROnSelectionChanged;
		public virtual RMethod ROnSelectionChanged
		{
			get
			{
				if(r_ROnSelectionChanged == null)
				{
					r_ROnSelectionChanged = new(this, "OnSelectionChanged", 0);
					r_ROnSelectionChanged.SetBelong(this.instance);
				}
				return r_ROnSelectionChanged;
			}
		}

		/// <summary>
		/// Void OnUpdateSupportedDataModes(System.Collections.Generic.List`1[UnityEditor.DataMode])
		/// </summary>
		protected RMethod r_ROnUpdateSupportedDataModes_List_d_DataMode_p_;
		public virtual RMethod ROnUpdateSupportedDataModes_List_d_DataMode_p_
		{
			get
			{
				if(r_ROnUpdateSupportedDataModes_List_d_DataMode_p_ == null)
				{
					r_ROnUpdateSupportedDataModes_List_d_DataMode_p_ = new(this, "OnUpdateSupportedDataModes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.DataMode)));
					r_ROnUpdateSupportedDataModes_List_d_DataMode_p_.SetBelong(this.instance);
				}
				return r_ROnUpdateSupportedDataModes_List_d_DataMode_p_;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_ROnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_ROnDisable == null)
				{
					r_ROnDisable = new(this, "OnDisable", 0);
					r_ROnDisable.SetBelong(this.instance);
				}
				return r_ROnDisable;
			}
		}

		/// <summary>
		/// Void RepaintAllInspectors()
		/// </summary>
		protected static RMethod r_RRepaintAllInspectors;
		public static RMethod RRepaintAllInspectors
		{
			get
			{
				if(r_RRepaintAllInspectors == null)
				{
					r_RRepaintAllInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RepaintAllInspectors", 0);
					r_RRepaintAllInspectors.SetBelong(null);
				}
				return r_RRepaintAllInspectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.InspectorWindow] GetInspectors()
		/// </summary>
		protected static RMethod r_RGetInspectors;
		public static RMethod RGetInspectors
		{
			get
			{
				if(r_RGetInspectors == null)
				{
					r_RGetInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "GetInspectors", 0);
					r_RGetInspectors.SetBelong(null);
				}
				return r_RGetInspectors;
			}
		}

		/// <summary>
		/// Void RedrawFromNative()
		/// </summary>
		protected static RMethod r_RRedrawFromNative;
		public static RMethod RRedrawFromNative
		{
			get
			{
				if(r_RRedrawFromNative == null)
				{
					r_RRedrawFromNative = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RedrawFromNative", 0);
					r_RRedrawFromNative.SetBelong(null);
				}
				return r_RRedrawFromNative;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorWindow[] GetAllInspectorWindows()
		/// </summary>
		protected static RMethod r_RGetAllInspectorWindows;
		public static RMethod RGetAllInspectorWindows
		{
			get
			{
				if(r_RGetAllInspectorWindows == null)
				{
					r_RGetAllInspectorWindows = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "GetAllInspectorWindows", 0);
					r_RGetAllInspectorWindows.SetBelong(null);
				}
				return r_RGetAllInspectorWindows;
			}
		}

		/// <summary>
		/// Void AddItemsToMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_RAddItemsToMenu_GenericMenu;
		public virtual RMethod RAddItemsToMenu_GenericMenu
		{
			get
			{
				if(r_RAddItemsToMenu_GenericMenu == null)
				{
					r_RAddItemsToMenu_GenericMenu = new(this, "AddItemsToMenu", 0, typeof(UnityEditor.GenericMenu));
					r_RAddItemsToMenu_GenericMenu.SetBelong(this.instance);
				}
				return r_RAddItemsToMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void RefreshTitle()
		/// </summary>
		protected RMethod r_RRefreshTitle;
		public virtual RMethod RRefreshTitle
		{
			get
			{
				if(r_RRefreshTitle == null)
				{
					r_RRefreshTitle = new(this, "RefreshTitle", 0);
					r_RRefreshTitle.SetBelong(this.instance);
				}
				return r_RRefreshTitle;
			}
		}

		/// <summary>
		/// Void UpdateWindowObjectNameTitle()
		/// </summary>
		protected RMethod r_RUpdateWindowObjectNameTitle;
		public virtual RMethod RUpdateWindowObjectNameTitle
		{
			get
			{
				if(r_RUpdateWindowObjectNameTitle == null)
				{
					r_RUpdateWindowObjectNameTitle = new(this, "UpdateWindowObjectNameTitle", 0);
					r_RUpdateWindowObjectNameTitle.SetBelong(this.instance);
				}
				return r_RUpdateWindowObjectNameTitle;
			}
		}

		/// <summary>
		/// Void CreateTracker()
		/// </summary>
		protected RMethod r_RCreateTracker;
		public virtual RMethod RCreateTracker
		{
			get
			{
				if(r_RCreateTracker == null)
				{
					r_RCreateTracker = new(this, "CreateTracker", 0);
					r_RCreateTracker.SetBelong(this.instance);
				}
				return r_RCreateTracker;
			}
		}

		/// <summary>
		/// Void ShowButton(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RShowButton_Rect;
		public virtual RMethod RShowButton_Rect
		{
			get
			{
				if(r_RShowButton_Rect == null)
				{
					r_RShowButton_Rect = new(this, "ShowButton", 0, typeof(UnityEngine.Rect));
					r_RShowButton_Rect.SetBelong(this.instance);
				}
				return r_RShowButton_Rect;
			}
		}

		/// <summary>
		/// Void LockStateChanged(Boolean)
		/// </summary>
		protected RMethod r_RLockStateChanged_Boolean;
		public virtual RMethod RLockStateChanged_Boolean
		{
			get
			{
				if(r_RLockStateChanged_Boolean == null)
				{
					r_RLockStateChanged_Boolean = new(this, "LockStateChanged", 0, typeof(System.Boolean));
					r_RLockStateChanged_Boolean.SetBelong(this.instance);
				}
				return r_RLockStateChanged_Boolean;
			}
		}

		/// <summary>
		/// Boolean CloseIfEmpty()
		/// </summary>
		protected RMethod r_RCloseIfEmpty;
		public virtual RMethod RCloseIfEmpty
		{
			get
			{
				if(r_RCloseIfEmpty == null)
				{
					r_RCloseIfEmpty = new(this, "CloseIfEmpty", 0);
					r_RCloseIfEmpty.SetBelong(this.instance);
				}
				return r_RCloseIfEmpty;
			}
		}

		/// <summary>
		/// Void BeginRebuildContentContainers()
		/// </summary>
		protected RMethod r_RBeginRebuildContentContainers;
		public virtual RMethod RBeginRebuildContentContainers
		{
			get
			{
				if(r_RBeginRebuildContentContainers == null)
				{
					r_RBeginRebuildContentContainers = new(this, "BeginRebuildContentContainers", 0);
					r_RBeginRebuildContentContainers.SetBelong(this.instance);
				}
				return r_RBeginRebuildContentContainers;
			}
		}

		/// <summary>
		/// Boolean BeginDrawPreviewAndLabels()
		/// </summary>
		protected RMethod r_RBeginDrawPreviewAndLabels;
		public virtual RMethod RBeginDrawPreviewAndLabels
		{
			get
			{
				if(r_RBeginDrawPreviewAndLabels == null)
				{
					r_RBeginDrawPreviewAndLabels = new(this, "BeginDrawPreviewAndLabels", 0);
					r_RBeginDrawPreviewAndLabels.SetBelong(this.instance);
				}
				return r_RBeginDrawPreviewAndLabels;
			}
		}

		/// <summary>
		/// Void EndDrawPreviewAndLabels(UnityEngine.Event, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_REndDrawPreviewAndLabels_Event_Rect_Rect;
		public virtual RMethod REndDrawPreviewAndLabels_Event_Rect_Rect
		{
			get
			{
				if(r_REndDrawPreviewAndLabels_Event_Rect_Rect == null)
				{
					r_REndDrawPreviewAndLabels_Event_Rect_Rect = new(this, "EndDrawPreviewAndLabels", 0, typeof(UnityEngine.Event), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_REndDrawPreviewAndLabels_Event_Rect_Rect.SetBelong(this.instance);
				}
				return r_REndDrawPreviewAndLabels_Event_Rect_Rect;
			}
		}

		/// <summary>
		/// Void DetachPreview(Boolean)
		/// </summary>
		protected RMethod r_RDetachPreview_Boolean;
		public virtual RMethod RDetachPreview_Boolean
		{
			get
			{
				if(r_RDetachPreview_Boolean == null)
				{
					r_RDetachPreview_Boolean = new(this, "DetachPreview", 0, typeof(System.Boolean));
					r_RDetachPreview_Boolean.SetBelong(this.instance);
				}
				return r_RDetachPreview_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWindow()
		/// </summary>
		protected static RMethod r_RShowWindow;
		public static RMethod RShowWindow
		{
			get
			{
				if(r_RShowWindow == null)
				{
					r_RShowWindow = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "ShowWindow", 0);
					r_RShowWindow.SetBelong(null);
				}
				return r_RShowWindow;
			}
		}

		/// <summary>
		/// Void FlushAllOptimizedGUIBlocksIfNeeded()
		/// </summary>
		protected static RMethod r_RFlushAllOptimizedGUIBlocksIfNeeded;
		public static RMethod RFlushAllOptimizedGUIBlocksIfNeeded
		{
			get
			{
				if(r_RFlushAllOptimizedGUIBlocksIfNeeded == null)
				{
					r_RFlushAllOptimizedGUIBlocksIfNeeded = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "FlushAllOptimizedGUIBlocksIfNeeded", 0);
					r_RFlushAllOptimizedGUIBlocksIfNeeded.SetBelong(null);
				}
				return r_RFlushAllOptimizedGUIBlocksIfNeeded;
			}
		}

		/// <summary>
		/// Void PrepareLockedObjectsForSerialization()
		/// </summary>
		protected RMethod r_RPrepareLockedObjectsForSerialization;
		public virtual RMethod RPrepareLockedObjectsForSerialization
		{
			get
			{
				if(r_RPrepareLockedObjectsForSerialization == null)
				{
					r_RPrepareLockedObjectsForSerialization = new(this, "PrepareLockedObjectsForSerialization", 0);
					r_RPrepareLockedObjectsForSerialization.SetBelong(this.instance);
				}
				return r_RPrepareLockedObjectsForSerialization;
			}
		}

		/// <summary>
		/// Void ClearSerializedLockedObjects()
		/// </summary>
		protected RMethod r_RClearSerializedLockedObjects;
		public virtual RMethod RClearSerializedLockedObjects
		{
			get
			{
				if(r_RClearSerializedLockedObjects == null)
				{
					r_RClearSerializedLockedObjects = new(this, "ClearSerializedLockedObjects", 0);
					r_RClearSerializedLockedObjects.SetBelong(this.instance);
				}
				return r_RClearSerializedLockedObjects;
			}
		}

		/// <summary>
		/// Void GetObjectsLocked(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_RGetObjectsLocked_List_d_Object_p_;
		public virtual RMethod RGetObjectsLocked_List_d_Object_p_
		{
			get
			{
				if(r_RGetObjectsLocked_List_d_Object_p_ == null)
				{
					r_RGetObjectsLocked_List_d_Object_p_ = new(this, "GetObjectsLocked", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_RGetObjectsLocked_List_d_Object_p_.SetBelong(this.instance);
				}
				return r_RGetObjectsLocked_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void SetObjectsLocked(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_RSetObjectsLocked_List_d_Object_p_;
		public virtual RMethod RSetObjectsLocked_List_d_Object_p_
		{
			get
			{
				if(r_RSetObjectsLocked_List_d_Object_p_ == null)
				{
					r_RSetObjectsLocked_List_d_Object_p_ = new(this, "SetObjectsLocked", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_RSetObjectsLocked_List_d_Object_p_.SetBelong(this.instance);
				}
				return r_RSetObjectsLocked_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void RestoreLockStateFromSerializedData()
		/// </summary>
		protected RMethod r_RRestoreLockStateFromSerializedData;
		public virtual RMethod RRestoreLockStateFromSerializedData
		{
			get
			{
				if(r_RRestoreLockStateFromSerializedData == null)
				{
					r_RRestoreLockStateFromSerializedData = new(this, "RestoreLockStateFromSerializedData", 0);
					r_RRestoreLockStateFromSerializedData.SetBelong(this.instance);
				}
				return r_RRestoreLockStateFromSerializedData;
			}
		}

		/// <summary>
		/// Boolean AddInspectorWindow(UnityEditor.InspectorWindow)
		/// </summary>
		protected static RMethod r_RAddInspectorWindow_InspectorWindow;
		public static RMethod RAddInspectorWindow_InspectorWindow
		{
			get
			{
				if(r_RAddInspectorWindow_InspectorWindow == null)
				{
					r_RAddInspectorWindow_InspectorWindow = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "AddInspectorWindow", 0,  ReleactionUtils.GetType("UnityEditor.InspectorWindow"));
					r_RAddInspectorWindow_InspectorWindow.SetBelong(null);
				}
				return r_RAddInspectorWindow_InspectorWindow;
			}
		}

		/// <summary>
		/// Void RemoveInspectorWindow(UnityEditor.InspectorWindow)
		/// </summary>
		protected static RMethod r_RRemoveInspectorWindow_InspectorWindow;
		public static RMethod RRemoveInspectorWindow_InspectorWindow
		{
			get
			{
				if(r_RRemoveInspectorWindow_InspectorWindow == null)
				{
					r_RRemoveInspectorWindow_InspectorWindow = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RemoveInspectorWindow", 0,  ReleactionUtils.GetType("UnityEditor.InspectorWindow"));
					r_RRemoveInspectorWindow_InspectorWindow.SetBelong(null);
				}
				return r_RRemoveInspectorWindow_InspectorWindow;
			}
		}

		/// <summary>
		/// Void ApplyChanges()
		/// </summary>
		protected static RMethod r_RApplyChanges;
		public static RMethod RApplyChanges
		{
			get
			{
				if(r_RApplyChanges == null)
				{
					r_RApplyChanges = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "ApplyChanges", 0);
					r_RApplyChanges.SetBelong(null);
				}
				return r_RApplyChanges;
			}
		}

		/// <summary>
		/// Void RefreshInspectors()
		/// </summary>
		protected static RMethod r_RRefreshInspectors;
		public static RMethod RRefreshInspectors
		{
			get
			{
				if(r_RRefreshInspectors == null)
				{
					r_RRefreshInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RefreshInspectors", 0);
					r_RRefreshInspectors.SetBelong(null);
				}
				return r_RRefreshInspectors;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetInspectedObject()
		/// </summary>
		protected RMethod r_RGetInspectedObject;
		public virtual RMethod RGetInspectedObject
		{
			get
			{
				if(r_RGetInspectedObject == null)
				{
					r_RGetInspectedObject = new(this, "GetInspectedObject", 0);
					r_RGetInspectedObject.SetBelong(this.instance);
				}
				return r_RGetInspectedObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] GetInspectedObjects()
		/// </summary>
		protected RMethod r_RGetInspectedObjects;
		public virtual RMethod RGetInspectedObjects
		{
			get
			{
				if(r_RGetInspectedObjects == null)
				{
					r_RGetInspectedObjects = new(this, "GetInspectedObjects", 0);
					r_RGetInspectedObjects.SetBelong(this.instance);
				}
				return r_RGetInspectedObjects;
			}
		}

		/// <summary>
		/// Boolean EditorsForMultiEditingChanged()
		/// </summary>
		protected RMethod r_REditorsForMultiEditingChanged;
		public virtual RMethod REditorsForMultiEditingChanged
		{
			get
			{
				if(r_REditorsForMultiEditingChanged == null)
				{
					r_REditorsForMultiEditingChanged = new(this, "EditorsForMultiEditingChanged", 0);
					r_REditorsForMultiEditingChanged.SetBelong(this.instance);
				}
				return r_REditorsForMultiEditingChanged;
			}
		}

		/// <summary>
		/// Boolean EditorForMultiEditingChanged(UnityEditor.Editor, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_REditorForMultiEditingChanged_Editor_Object;
		public static RMethod REditorForMultiEditingChanged_Editor_Object
		{
			get
			{
				if(r_REditorForMultiEditingChanged_Editor_Object == null)
				{
					r_REditorForMultiEditingChanged_Editor_Object = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "EditorForMultiEditingChanged", 0, typeof(UnityEditor.Editor), typeof(UnityEngine.Object));
					r_REditorForMultiEditingChanged_Editor_Object.SetBelong(null);
				}
				return r_REditorForMultiEditingChanged_Editor_Object;
			}
		}

		/// <summary>
		/// Void <AddItemsToMenu>b__25_0()
		/// </summary>
		protected RMethod r_R__1__AddItemsToMenu__2__b__25_0;
		public virtual RMethod R__1__AddItemsToMenu__2__b__25_0
		{
			get
			{
				if(r_R__1__AddItemsToMenu__2__b__25_0 == null)
				{
					r_R__1__AddItemsToMenu__2__b__25_0 = new(this, "<AddItemsToMenu>b__25_0", 0);
					r_R__1__AddItemsToMenu__2__b__25_0.SetBelong(this.instance);
				}
				return r_R__1__AddItemsToMenu__2__b__25_0;
			}
		}

		/// <summary>
		/// Void OnFocusChanged(Boolean)
		/// </summary>
		protected RMethod r_ROnFocusChanged_Boolean;
		public virtual RMethod ROnFocusChanged_Boolean
		{
			get
			{
				if(r_ROnFocusChanged_Boolean == null)
				{
					r_ROnFocusChanged_Boolean = new(this, "OnFocusChanged", 0, typeof(System.Boolean));
					r_ROnFocusChanged_Boolean.SetBelong(this.instance);
				}
				return r_ROnFocusChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_ROnLostFocus;
		public virtual RMethod ROnLostFocus
		{
			get
			{
				if(r_ROnLostFocus == null)
				{
					r_ROnLostFocus = new(this, "OnLostFocus", 0);
					r_ROnLostFocus.SetBelong(this.instance);
				}
				return r_ROnLostFocus;
			}
		}

		/// <summary>
		/// Void OnInspectorUpdate()
		/// </summary>
		protected RMethod r_ROnInspectorUpdate;
		public virtual RMethod ROnInspectorUpdate
		{
			get
			{
				if(r_ROnInspectorUpdate == null)
				{
					r_ROnInspectorUpdate = new(this, "OnInspectorUpdate", 0);
					r_ROnInspectorUpdate.SetBelong(this.instance);
				}
				return r_ROnInspectorUpdate;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_ROnGUI;
		public virtual RMethod ROnGUI
		{
			get
			{
				if(r_ROnGUI == null)
				{
					r_ROnGUI = new(this, "OnGUI", 0);
					r_ROnGUI.SetBelong(this.instance);
				}
				return r_ROnGUI;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void SetMode(UnityEditor.InspectorMode)
		/// </summary>
		protected RMethod r_RSetMode_InspectorMode;
		public virtual RMethod RSetMode_InspectorMode
		{
			get
			{
				if(r_RSetMode_InspectorMode == null)
				{
					r_RSetMode_InspectorMode = new(this, "SetMode", 0, typeof(UnityEditor.InspectorMode));
					r_RSetMode_InspectorMode.SetBelong(this.instance);
				}
				return r_RSetMode_InspectorMode;
			}
		}

		/// <summary>
		/// Void SetTitle(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RSetTitle_Object;
		public virtual RMethod RSetTitle_Object
		{
			get
			{
				if(r_RSetTitle_Object == null)
				{
					r_RSetTitle_Object = new(this, "SetTitle", 0, typeof(UnityEngine.Object));
					r_RSetTitle_Object.SetBelong(this.instance);
				}
				return r_RSetTitle_Object;
			}
		}

		/// <summary>
		/// Void LoadVisualTreeFromUxml()
		/// </summary>
		protected RMethod r_RLoadVisualTreeFromUxml;
		public virtual RMethod RLoadVisualTreeFromUxml
		{
			get
			{
				if(r_RLoadVisualTreeFromUxml == null)
				{
					r_RLoadVisualTreeFromUxml = new(this, "LoadVisualTreeFromUxml", 0);
					r_RLoadVisualTreeFromUxml.SetBelong(this.instance);
				}
				return r_RLoadVisualTreeFromUxml;
			}
		}

		/// <summary>
		/// Void ClearEditorsAndRebuild()
		/// </summary>
		protected RMethod r_RClearEditorsAndRebuild;
		public virtual RMethod RClearEditorsAndRebuild
		{
			get
			{
				if(r_RClearEditorsAndRebuild == null)
				{
					r_RClearEditorsAndRebuild = new(this, "ClearEditorsAndRebuild", 0);
					r_RClearEditorsAndRebuild.SetBelong(this.instance);
				}
				return r_RClearEditorsAndRebuild;
			}
		}

		/// <summary>
		/// Void AddDebugItemsToMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_RAddDebugItemsToMenu_GenericMenu;
		public virtual RMethod RAddDebugItemsToMenu_GenericMenu
		{
			get
			{
				if(r_RAddDebugItemsToMenu_GenericMenu == null)
				{
					r_RAddDebugItemsToMenu_GenericMenu = new(this, "AddDebugItemsToMenu", 0, typeof(UnityEditor.GenericMenu));
					r_RAddDebugItemsToMenu_GenericMenu.SetBelong(this.instance);
				}
				return r_RAddDebugItemsToMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ExpandAllComponents()
		/// </summary>
		protected RMethod r_RExpandAllComponents;
		public virtual RMethod RExpandAllComponents
		{
			get
			{
				if(r_RExpandAllComponents == null)
				{
					r_RExpandAllComponents = new(this, "ExpandAllComponents", 0);
					r_RExpandAllComponents.SetBelong(this.instance);
				}
				return r_RExpandAllComponents;
			}
		}

		/// <summary>
		/// Boolean IsAnyComponentCollapsed()
		/// </summary>
		protected RMethod r_RIsAnyComponentCollapsed;
		public virtual RMethod RIsAnyComponentCollapsed
		{
			get
			{
				if(r_RIsAnyComponentCollapsed == null)
				{
					r_RIsAnyComponentCollapsed = new(this, "IsAnyComponentCollapsed", 0);
					r_RIsAnyComponentCollapsed.SetBelong(this.instance);
				}
				return r_RIsAnyComponentCollapsed;
			}
		}

		/// <summary>
		/// Void CollapseAllComponents()
		/// </summary>
		protected RMethod r_RCollapseAllComponents;
		public virtual RMethod RCollapseAllComponents
		{
			get
			{
				if(r_RCollapseAllComponents == null)
				{
					r_RCollapseAllComponents = new(this, "CollapseAllComponents", 0);
					r_RCollapseAllComponents.SetBelong(this.instance);
				}
				return r_RCollapseAllComponents;
			}
		}

		/// <summary>
		/// Boolean IsAnyComponentExpanded()
		/// </summary>
		protected RMethod r_RIsAnyComponentExpanded;
		public virtual RMethod RIsAnyComponentExpanded
		{
			get
			{
				if(r_RIsAnyComponentExpanded == null)
				{
					r_RIsAnyComponentExpanded = new(this, "IsAnyComponentExpanded", 0);
					r_RIsAnyComponentExpanded.SetBelong(this.instance);
				}
				return r_RIsAnyComponentExpanded;
			}
		}

		/// <summary>
		/// Boolean LoadPersistedObject()
		/// </summary>
		protected RMethod r_RLoadPersistedObject;
		public virtual RMethod RLoadPersistedObject
		{
			get
			{
				if(r_RLoadPersistedObject == null)
				{
					r_RLoadPersistedObject = new(this, "LoadPersistedObject", 0);
					r_RLoadPersistedObject.SetBelong(this.instance);
				}
				return r_RLoadPersistedObject;
			}
		}

		/// <summary>
		/// Void CreatePreviewables()
		/// </summary>
		protected RMethod r_RCreatePreviewables;
		public virtual RMethod RCreatePreviewables
		{
			get
			{
				if(r_RCreatePreviewables == null)
				{
					r_RCreatePreviewables = new(this, "CreatePreviewables", 0);
					r_RCreatePreviewables.SetBelong(this.instance);
				}
				return r_RCreatePreviewables;
			}
		}

		/// <summary>
		/// Void ClearPreviewables()
		/// </summary>
		protected RMethod r_RClearPreviewables;
		public virtual RMethod RClearPreviewables
		{
			get
			{
				if(r_RClearPreviewables == null)
				{
					r_RClearPreviewables = new(this, "ClearPreviewables", 0);
					r_RClearPreviewables.SetBelong(this.instance);
				}
				return r_RClearPreviewables;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action, System.String)
		/// </summary>
		protected RMethod r_RCreateIMGUIContainer_Action_String;
		public virtual RMethod RCreateIMGUIContainer_Action_String
		{
			get
			{
				if(r_RCreateIMGUIContainer_Action_String == null)
				{
					r_RCreateIMGUIContainer_Action_String = new(this, "CreateIMGUIContainer", 0, typeof(System.Action), typeof(System.String));
					r_RCreateIMGUIContainer_Action_String.SetBelong(this.instance);
				}
				return r_RCreateIMGUIContainer_Action_String;
			}
		}

		/// <summary>
		/// Void EndRebuildContentContainers()
		/// </summary>
		protected RMethod r_REndRebuildContentContainers;
		public virtual RMethod REndRebuildContentContainers
		{
			get
			{
				if(r_REndRebuildContentContainers == null)
				{
					r_REndRebuildContentContainers = new(this, "EndRebuildContentContainers", 0);
					r_REndRebuildContentContainers.SetBelong(this.instance);
				}
				return r_REndRebuildContentContainers;
			}
		}

		/// <summary>
		/// Void RebuildContentsContainers()
		/// </summary>
		protected RMethod r_RRebuildContentsContainers;
		public virtual RMethod RRebuildContentsContainers
		{
			get
			{
				if(r_RRebuildContentsContainers == null)
				{
					r_RRebuildContentsContainers = new(this, "RebuildContentsContainers", 0);
					r_RRebuildContentsContainers.SetBelong(this.instance);
				}
				return r_RRebuildContentsContainers;
			}
		}

		/// <summary>
		/// Void AutoScroll(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RAutoScroll_Vector2;
		public virtual RMethod RAutoScroll_Vector2
		{
			get
			{
				if(r_RAutoScroll_Vector2 == null)
				{
					r_RAutoScroll_Vector2 = new(this, "AutoScroll", 0, typeof(UnityEngine.Vector2));
					r_RAutoScroll_Vector2.SetBelong(this.instance);
				}
				return r_RAutoScroll_Vector2;
			}
		}

		/// <summary>
		/// Void ScrollTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RScrollTo_Vector2;
		public virtual RMethod RScrollTo_Vector2
		{
			get
			{
				if(r_RScrollTo_Vector2 == null)
				{
					r_RScrollTo_Vector2 = new(this, "ScrollTo", 0, typeof(UnityEngine.Vector2));
					r_RScrollTo_Vector2.SetBelong(this.instance);
				}
				return r_RScrollTo_Vector2;
			}
		}

		/// <summary>
		/// UnityEditor.Editor GetLastInteractedEditor()
		/// </summary>
		protected RMethod r_RGetLastInteractedEditor;
		public virtual RMethod RGetLastInteractedEditor
		{
			get
			{
				if(r_RGetLastInteractedEditor == null)
				{
					r_RGetLastInteractedEditor = new(this, "GetLastInteractedEditor", 0);
					r_RGetLastInteractedEditor.SetBelong(this.instance);
				}
				return r_RGetLastInteractedEditor;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable GetEditorThatControlsPreview(UnityEditor.IPreviewable[])
		/// </summary>
		protected RMethod r_RGetEditorThatControlsPreview_IPreviewableArray;
		public virtual RMethod RGetEditorThatControlsPreview_IPreviewableArray
		{
			get
			{
				if(r_RGetEditorThatControlsPreview_IPreviewableArray == null)
				{
					r_RGetEditorThatControlsPreview_IPreviewableArray = new(this, "GetEditorThatControlsPreview", 0,  ReleactionUtils.GetType("UnityEditor.IPreviewable").MakeArrayType());
					r_RGetEditorThatControlsPreview_IPreviewableArray.SetBelong(this.instance);
				}
				return r_RGetEditorThatControlsPreview_IPreviewableArray;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable[] GetEditorsWithPreviews(UnityEditor.Editor[])
		/// </summary>
		protected RMethod r_RGetEditorsWithPreviews_EditorArray;
		public virtual RMethod RGetEditorsWithPreviews_EditorArray
		{
			get
			{
				if(r_RGetEditorsWithPreviews_EditorArray == null)
				{
					r_RGetEditorsWithPreviews_EditorArray = new(this, "GetEditorsWithPreviews", 0, typeof(UnityEditor.Editor).MakeArrayType());
					r_RGetEditorsWithPreviews_EditorArray.SetBelong(this.instance);
				}
				return r_RGetEditorsWithPreviews_EditorArray;
			}
		}

		/// <summary>
		/// Boolean WasEditorVisible(UnityEditor.Editor[], Int32, UnityEngine.Object)
		/// </summary>
		protected RMethod r_RWasEditorVisible_EditorArray_Int32_Object;
		public virtual RMethod RWasEditorVisible_EditorArray_Int32_Object
		{
			get
			{
				if(r_RWasEditorVisible_EditorArray_Int32_Object == null)
				{
					r_RWasEditorVisible_EditorArray_Int32_Object = new(this, "WasEditorVisible", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Object));
					r_RWasEditorVisible_EditorArray_Int32_Object.SetBelong(this.instance);
				}
				return r_RWasEditorVisible_EditorArray_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean ShouldCullEditor(UnityEditor.Editor[], Int32)
		/// </summary>
		protected RMethod r_RShouldCullEditor_EditorArray_Int32;
		public virtual RMethod RShouldCullEditor_EditorArray_Int32
		{
			get
			{
				if(r_RShouldCullEditor_EditorArray_Int32 == null)
				{
					r_RShouldCullEditor_EditorArray_Int32 = new(this, "ShouldCullEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32));
					r_RShouldCullEditor_EditorArray_Int32.SetBelong(this.instance);
				}
				return r_RShouldCullEditor_EditorArray_Int32;
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
		/// Void UnsavedChangesStateChanged(UnityEditor.Editor, Boolean)
		/// </summary>
		protected RMethod r_RUnsavedChangesStateChanged_Editor_Boolean;
		public virtual RMethod RUnsavedChangesStateChanged_Editor_Boolean
		{
			get
			{
				if(r_RUnsavedChangesStateChanged_Editor_Boolean == null)
				{
					r_RUnsavedChangesStateChanged_Editor_Boolean = new(this, "UnsavedChangesStateChanged", 0, typeof(UnityEditor.Editor), typeof(System.Boolean));
					r_RUnsavedChangesStateChanged_Editor_Boolean.SetBelong(this.instance);
				}
				return r_RUnsavedChangesStateChanged_Editor_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateSupportedDataModesList()
		/// </summary>
		protected RMethod r_RUpdateSupportedDataModesList;
		public virtual RMethod RUpdateSupportedDataModesList
		{
			get
			{
				if(r_RUpdateSupportedDataModesList == null)
				{
					r_RUpdateSupportedDataModesList = new(this, "UpdateSupportedDataModesList", 0);
					r_RUpdateSupportedDataModesList.SetBelong(this.instance);
				}
				return r_RUpdateSupportedDataModesList;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController GetDataModeController_Internal()
		/// </summary>
		protected RMethod r_RGetDataModeController_Internal;
		public virtual RMethod RGetDataModeController_Internal
		{
			get
			{
				if(r_RGetDataModeController_Internal == null)
				{
					r_RGetDataModeController_Internal = new(this, "GetDataModeController_Internal", 0);
					r_RGetDataModeController_Internal.SetBelong(this.instance);
				}
				return r_RGetDataModeController_Internal;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_RSaveViewData;
		public virtual RMethod RSaveViewData
		{
			get
			{
				if(r_RSaveViewData == null)
				{
					r_RSaveViewData = new(this, "SaveViewData", 0);
					r_RSaveViewData.SetBelong(this.instance);
				}
				return r_RSaveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ISerializableJsonDictionary GetViewDataDictionary()
		/// </summary>
		protected RMethod r_RGetViewDataDictionary;
		public virtual RMethod RGetViewDataDictionary
		{
			get
			{
				if(r_RGetViewDataDictionary == null)
				{
					r_RGetViewDataDictionary = new(this, "GetViewDataDictionary", 0);
					r_RGetViewDataDictionary.SetBelong(this.instance);
				}
				return r_RGetViewDataDictionary;
			}
		}

		/// <summary>
		/// Void DisableViewDataPersistence()
		/// </summary>
		protected RMethod r_RDisableViewDataPersistence;
		public virtual RMethod RDisableViewDataPersistence
		{
			get
			{
				if(r_RDisableViewDataPersistence == null)
				{
					r_RDisableViewDataPersistence = new(this, "DisableViewDataPersistence", 0);
					r_RDisableViewDataPersistence.SetBelong(this.instance);
				}
				return r_RDisableViewDataPersistence;
			}
		}

		/// <summary>
		/// Void ClearPersistentViewData()
		/// </summary>
		protected RMethod r_RClearPersistentViewData;
		public virtual RMethod RClearPersistentViewData
		{
			get
			{
				if(r_RClearPersistentViewData == null)
				{
					r_RClearPersistentViewData = new(this, "ClearPersistentViewData", 0);
					r_RClearPersistentViewData.SetBelong(this.instance);
				}
				return r_RClearPersistentViewData;
			}
		}

		/// <summary>
		/// Void BeginWindows()
		/// </summary>
		protected RMethod r_RBeginWindows;
		public virtual RMethod RBeginWindows
		{
			get
			{
				if(r_RBeginWindows == null)
				{
					r_RBeginWindows = new(this, "BeginWindows", 0);
					r_RBeginWindows.SetBelong(this.instance);
				}
				return r_RBeginWindows;
			}
		}

		/// <summary>
		/// Void EndWindows()
		/// </summary>
		protected RMethod r_REndWindows;
		public virtual RMethod REndWindows
		{
			get
			{
				if(r_REndWindows == null)
				{
					r_REndWindows = new(this, "EndWindows", 0);
					r_REndWindows.SetBelong(this.instance);
				}
				return r_REndWindows;
			}
		}

		/// <summary>
		/// Void OnResized()
		/// </summary>
		protected RMethod r_ROnResized;
		public virtual RMethod ROnResized
		{
			get
			{
				if(r_ROnResized == null)
				{
					r_ROnResized = new(this, "OnResized", 0);
					r_ROnResized.SetBelong(this.instance);
				}
				return r_ROnResized;
			}
		}

		/// <summary>
		/// Void OnBackgroundViewResized(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROnBackgroundViewResized_Rect;
		public virtual RMethod ROnBackgroundViewResized_Rect
		{
			get
			{
				if(r_ROnBackgroundViewResized_Rect == null)
				{
					r_ROnBackgroundViewResized_Rect = new(this, "OnBackgroundViewResized", 0, typeof(UnityEngine.Rect));
					r_ROnBackgroundViewResized_Rect.SetBelong(this.instance);
				}
				return r_ROnBackgroundViewResized_Rect;
			}
		}

		/// <summary>
		/// Void CheckForWindowRepaint()
		/// </summary>
		protected RMethod r_RCheckForWindowRepaint;
		public virtual RMethod RCheckForWindowRepaint
		{
			get
			{
				if(r_RCheckForWindowRepaint == null)
				{
					r_RCheckForWindowRepaint = new(this, "CheckForWindowRepaint", 0);
					r_RCheckForWindowRepaint.SetBelong(this.instance);
				}
				return r_RCheckForWindowRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetLocalizedTitleContent()
		/// </summary>
		protected RMethod r_RGetLocalizedTitleContent;
		public virtual RMethod RGetLocalizedTitleContent
		{
			get
			{
				if(r_RGetLocalizedTitleContent == null)
				{
					r_RGetLocalizedTitleContent = new(this, "GetLocalizedTitleContent", 0);
					r_RGetLocalizedTitleContent.SetBelong(this.instance);
				}
				return r_RGetLocalizedTitleContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RShowNotification_GUIContent;
		public virtual RMethod RShowNotification_GUIContent
		{
			get
			{
				if(r_RShowNotification_GUIContent == null)
				{
					r_RShowNotification_GUIContent = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent));
					r_RShowNotification_GUIContent.SetBelong(this.instance);
				}
				return r_RShowNotification_GUIContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent, Double)
		/// </summary>
		protected RMethod r_RShowNotification_GUIContent_Double;
		public virtual RMethod RShowNotification_GUIContent_Double
		{
			get
			{
				if(r_RShowNotification_GUIContent_Double == null)
				{
					r_RShowNotification_GUIContent_Double = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent), typeof(System.Double));
					r_RShowNotification_GUIContent_Double.SetBelong(this.instance);
				}
				return r_RShowNotification_GUIContent_Double;
			}
		}

		/// <summary>
		/// Void RemoveNotification()
		/// </summary>
		protected RMethod r_RRemoveNotification;
		public virtual RMethod RRemoveNotification
		{
			get
			{
				if(r_RRemoveNotification == null)
				{
					r_RRemoveNotification = new(this, "RemoveNotification", 0);
					r_RRemoveNotification.SetBelong(this.instance);
				}
				return r_RRemoveNotification;
			}
		}

		/// <summary>
		/// Void DrawNotification()
		/// </summary>
		protected RMethod r_RDrawNotification;
		public virtual RMethod RDrawNotification
		{
			get
			{
				if(r_RDrawNotification == null)
				{
					r_RDrawNotification = new(this, "DrawNotification", 0);
					r_RDrawNotification.SetBelong(this.instance);
				}
				return r_RDrawNotification;
			}
		}

		/// <summary>
		/// Void OnMaximized()
		/// </summary>
		protected RMethod r_ROnMaximized;
		public virtual RMethod ROnMaximized
		{
			get
			{
				if(r_ROnMaximized == null)
				{
					r_ROnMaximized = new(this, "OnMaximized", 0);
					r_ROnMaximized.SetBelong(this.instance);
				}
				return r_ROnMaximized;
			}
		}

		/// <summary>
		/// Boolean CanMaximize()
		/// </summary>
		protected RMethod r_RCanMaximize;
		public virtual RMethod RCanMaximize
		{
			get
			{
				if(r_RCanMaximize == null)
				{
					r_RCanMaximize = new(this, "CanMaximize", 0);
					r_RCanMaximize.SetBelong(this.instance);
				}
				return r_RCanMaximize;
			}
		}

		/// <summary>
		/// Int32 GetNumTabs()
		/// </summary>
		protected RMethod r_RGetNumTabs;
		public virtual RMethod RGetNumTabs
		{
			get
			{
				if(r_RGetNumTabs == null)
				{
					r_RGetNumTabs = new(this, "GetNumTabs", 0);
					r_RGetNumTabs.SetBelong(this.instance);
				}
				return r_RGetNumTabs;
			}
		}

		/// <summary>
		/// Boolean ShowNextTabIfPossible()
		/// </summary>
		protected RMethod r_RShowNextTabIfPossible;
		public virtual RMethod RShowNextTabIfPossible
		{
			get
			{
				if(r_RShowNextTabIfPossible == null)
				{
					r_RShowNextTabIfPossible = new(this, "ShowNextTabIfPossible", 0);
					r_RShowNextTabIfPossible.SetBelong(this.instance);
				}
				return r_RShowNextTabIfPossible;
			}
		}

		/// <summary>
		/// Void ShowTab()
		/// </summary>
		protected RMethod r_RShowTab;
		public virtual RMethod RShowTab
		{
			get
			{
				if(r_RShowTab == null)
				{
					r_RShowTab = new(this, "ShowTab", 0);
					r_RShowTab.SetBelong(this.instance);
				}
				return r_RShowTab;
			}
		}

		/// <summary>
		/// Boolean IsSelectedTab()
		/// </summary>
		protected RMethod r_RIsSelectedTab;
		public virtual RMethod RIsSelectedTab
		{
			get
			{
				if(r_RIsSelectedTab == null)
				{
					r_RIsSelectedTab = new(this, "IsSelectedTab", 0);
					r_RIsSelectedTab.SetBelong(this.instance);
				}
				return r_RIsSelectedTab;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_RFocus;
		public virtual RMethod RFocus
		{
			get
			{
				if(r_RFocus == null)
				{
					r_RFocus = new(this, "Focus", 0);
					r_RFocus.SetBelong(this.instance);
				}
				return r_RFocus;
			}
		}

		/// <summary>
		/// Void MakeParentsSettingsMatchMe()
		/// </summary>
		protected RMethod r_RMakeParentsSettingsMatchMe;
		public virtual RMethod RMakeParentsSettingsMatchMe
		{
			get
			{
				if(r_RMakeParentsSettingsMatchMe == null)
				{
					r_RMakeParentsSettingsMatchMe = new(this, "MakeParentsSettingsMatchMe", 0);
					r_RMakeParentsSettingsMatchMe.SetBelong(this.instance);
				}
				return r_RMakeParentsSettingsMatchMe;
			}
		}

		/// <summary>
		/// Void ShowUtility()
		/// </summary>
		protected RMethod r_RShowUtility;
		public virtual RMethod RShowUtility
		{
			get
			{
				if(r_RShowUtility == null)
				{
					r_RShowUtility = new(this, "ShowUtility", 0);
					r_RShowUtility.SetBelong(this.instance);
				}
				return r_RShowUtility;
			}
		}

		/// <summary>
		/// Void ShowTooltip()
		/// </summary>
		protected RMethod r_RShowTooltip;
		public virtual RMethod RShowTooltip
		{
			get
			{
				if(r_RShowTooltip == null)
				{
					r_RShowTooltip = new(this, "ShowTooltip", 0);
					r_RShowTooltip.SetBelong(this.instance);
				}
				return r_RShowTooltip;
			}
		}

		/// <summary>
		/// Void ShowPopup()
		/// </summary>
		protected RMethod r_RShowPopup;
		public virtual RMethod RShowPopup
		{
			get
			{
				if(r_RShowPopup == null)
				{
					r_RShowPopup = new(this, "ShowPopup", 0);
					r_RShowPopup.SetBelong(this.instance);
				}
				return r_RShowPopup;
			}
		}

		/// <summary>
		/// Void ShowModalUtility()
		/// </summary>
		protected RMethod r_RShowModalUtility;
		public virtual RMethod RShowModalUtility
		{
			get
			{
				if(r_RShowModalUtility == null)
				{
					r_RShowModalUtility = new(this, "ShowModalUtility", 0);
					r_RShowModalUtility.SetBelong(this.instance);
				}
				return r_RShowModalUtility;
			}
		}

		/// <summary>
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_RShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_RShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_RShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_RShowPopupWithMode_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_RShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWithMode(UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_RShowWithMode_ShowMode;
		public virtual RMethod RShowWithMode_ShowMode
		{
			get
			{
				if(r_RShowWithMode_ShowMode == null)
				{
					r_RShowWithMode_ShowMode = new(this, "ShowWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_RShowWithMode_ShowMode.SetBelong(this.instance);
				}
				return r_RShowWithMode_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2;
		public virtual RMethod RShowAsDropDown_Rect_Vector2
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2 == null)
				{
					r_RShowAsDropDown_Rect_Vector2 = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RShowAsDropDown_Rect_Vector2.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2_PopupLocationArray == null)
				{
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode == null)
				{
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean
		{
			get
			{
				if(r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean == null)
				{
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray == null)
				{
					r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDownFitToScreen", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void Show()
		/// </summary>
		protected RMethod r_RShow;
		public virtual RMethod RShow
		{
			get
			{
				if(r_RShow == null)
				{
					r_RShow = new(this, "Show", 0);
					r_RShow.SetBelong(this.instance);
				}
				return r_RShow;
			}
		}

		/// <summary>
		/// Void Show(Boolean)
		/// </summary>
		protected RMethod r_RShow_Boolean;
		public virtual RMethod RShow_Boolean
		{
			get
			{
				if(r_RShow_Boolean == null)
				{
					r_RShow_Boolean = new(this, "Show", 0, typeof(System.Boolean));
					r_RShow_Boolean.SetBelong(this.instance);
				}
				return r_RShow_Boolean;
			}
		}

		/// <summary>
		/// Void ShowAuxWindow()
		/// </summary>
		protected RMethod r_RShowAuxWindow;
		public virtual RMethod RShowAuxWindow
		{
			get
			{
				if(r_RShowAuxWindow == null)
				{
					r_RShowAuxWindow = new(this, "ShowAuxWindow", 0);
					r_RShowAuxWindow.SetBelong(this.instance);
				}
				return r_RShowAuxWindow;
			}
		}

		/// <summary>
		/// Void ShowModal()
		/// </summary>
		protected RMethod r_RShowModal;
		public virtual RMethod RShowModal
		{
			get
			{
				if(r_RShowModal == null)
				{
					r_RShowModal = new(this, "ShowModal", 0);
					r_RShowModal.SetBelong(this.instance);
				}
				return r_RShowModal;
			}
		}

		/// <summary>
		/// Void RemoveFromDockArea()
		/// </summary>
		protected RMethod r_RRemoveFromDockArea;
		public virtual RMethod RRemoveFromDockArea
		{
			get
			{
				if(r_RRemoveFromDockArea == null)
				{
					r_RRemoveFromDockArea = new(this, "RemoveFromDockArea", 0);
					r_RRemoveFromDockArea.SetBelong(this.instance);
				}
				return r_RRemoveFromDockArea;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
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
		/// Void RepaintImmediately()
		/// </summary>
		protected RMethod r_RRepaintImmediately;
		public virtual RMethod RRepaintImmediately
		{
			get
			{
				if(r_RRepaintImmediately == null)
				{
					r_RRepaintImmediately = new(this, "RepaintImmediately", 0);
					r_RRepaintImmediately.SetBelong(this.instance);
				}
				return r_RRepaintImmediately;
			}
		}

		/// <summary>
		/// Void SetParentGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetParentGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RSetParentGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_RSetParentGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_RSetParentGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetParentGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RSetParentGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.instance);
				}
				return r_RSetParentGameViewDimensions_Rect_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void SetPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetPlayModeViewSize_Vector2;
		public virtual RMethod RSetPlayModeViewSize_Vector2
		{
			get
			{
				if(r_RSetPlayModeViewSize_Vector2 == null)
				{
					r_RSetPlayModeViewSize_Vector2 = new(this, "SetPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_RSetPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_RSetPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetMainPlayModeViewSize_Vector2;
		public virtual RMethod RSetMainPlayModeViewSize_Vector2
		{
			get
			{
				if(r_RSetMainPlayModeViewSize_Vector2 == null)
				{
					r_RSetMainPlayModeViewSize_Vector2 = new(this, "SetMainPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_RSetMainPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_RSetMainPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetDisplayViewSize_Int32_Vector2;
		public virtual RMethod RSetDisplayViewSize_Int32_Vector2
		{
			get
			{
				if(r_RSetDisplayViewSize_Int32_Vector2 == null)
				{
					r_RSetDisplayViewSize_Int32_Vector2 = new(this, "SetDisplayViewSize", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RSetDisplayViewSize_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RSetDisplayViewSize_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetDisplayViewSize(Int32)
		/// </summary>
		protected RMethod r_RGetDisplayViewSize_Int32;
		public virtual RMethod RGetDisplayViewSize_Int32
		{
			get
			{
				if(r_RGetDisplayViewSize_Int32 == null)
				{
					r_RGetDisplayViewSize_Int32 = new(this, "GetDisplayViewSize", 0, typeof(System.Int32));
					r_RGetDisplayViewSize_Int32.SetBelong(this.instance);
				}
				return r_RGetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetPlayModeView(Boolean)
		/// </summary>
		protected RMethod r_RSetPlayModeView_Boolean;
		public virtual RMethod RSetPlayModeView_Boolean
		{
			get
			{
				if(r_RSetPlayModeView_Boolean == null)
				{
					r_RSetPlayModeView_Boolean = new(this, "SetPlayModeView", 0, typeof(System.Boolean));
					r_RSetPlayModeView_Boolean.SetBelong(this.instance);
				}
				return r_RSetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RSendEvent_Event;
		public virtual RMethod RSendEvent_Event
		{
			get
			{
				if(r_RSendEvent_Event == null)
				{
					r_RSendEvent_Event = new(this, "SendEvent", 0, typeof(UnityEngine.Event));
					r_RSendEvent_Event.SetBelong(this.instance);
				}
				return r_RSendEvent_Event;
			}
		}

		/// <summary>
		/// Void AddSceneTab()
		/// </summary>
		protected RMethod r_RAddSceneTab;
		public virtual RMethod RAddSceneTab
		{
			get
			{
				if(r_RAddSceneTab == null)
				{
					r_RAddSceneTab = new(this, "AddSceneTab", 0);
					r_RAddSceneTab.SetBelong(this.instance);
				}
				return r_RAddSceneTab;
			}
		}

		/// <summary>
		/// Void AddGameTab()
		/// </summary>
		protected RMethod r_RAddGameTab;
		public virtual RMethod RAddGameTab
		{
			get
			{
				if(r_RAddGameTab == null)
				{
					r_RAddGameTab = new(this, "AddGameTab", 0);
					r_RAddGameTab.SetBelong(this.instance);
				}
				return r_RAddGameTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetExtraPaneTypes()
		/// </summary>
		protected RMethod r_RGetExtraPaneTypes;
		public virtual RMethod RGetExtraPaneTypes
		{
			get
			{
				if(r_RGetExtraPaneTypes == null)
				{
					r_RGetExtraPaneTypes = new(this, "GetExtraPaneTypes", 0);
					r_RGetExtraPaneTypes.SetBelong(this.instance);
				}
				return r_RGetExtraPaneTypes;
			}
		}

		/// <summary>
		/// Boolean TryGetOverlay(System.String, UnityEditor.Overlays.Overlay ByRef)
		/// </summary>
		protected RMethod r_RTryGetOverlay_String_Out_Overlay;
		public virtual RMethod RTryGetOverlay_String_Out_Overlay
		{
			get
			{
				if(r_RTryGetOverlay_String_Out_Overlay == null)
				{
					r_RTryGetOverlay_String_Out_Overlay = new(this, "TryGetOverlay", 0, typeof(System.String), typeof(UnityEditor.Overlays.Overlay).MakeByRefType());
					r_RTryGetOverlay_String_Out_Overlay.SetBelong(this.instance);
				}
				return r_RTryGetOverlay_String_Out_Overlay;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChangedInternal()
		/// </summary>
		protected RMethod r_ROnBackingScaleFactorChangedInternal;
		public virtual RMethod ROnBackingScaleFactorChangedInternal
		{
			get
			{
				if(r_ROnBackingScaleFactorChangedInternal == null)
				{
					r_ROnBackingScaleFactorChangedInternal = new(this, "OnBackingScaleFactorChangedInternal", 0);
					r_ROnBackingScaleFactorChangedInternal.SetBelong(this.instance);
				}
				return r_ROnBackingScaleFactorChangedInternal;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChanged()
		/// </summary>
		protected RMethod r_ROnBackingScaleFactorChanged;
		public virtual RMethod ROnBackingScaleFactorChanged
		{
			get
			{
				if(r_ROnBackingScaleFactorChanged == null)
				{
					r_ROnBackingScaleFactorChanged = new(this, "OnBackingScaleFactorChanged", 0);
					r_ROnBackingScaleFactorChanged.SetBelong(this.instance);
				}
				return r_ROnBackingScaleFactorChanged;
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


        public RInspectorWindow() : base("UnityEditor.InspectorWindow")
        {
        }

        public RInspectorWindow(System.Object instance) : base("UnityEditor.InspectorWindow")
		{
            SetInstance(instance);
		}

        public RInspectorWindow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInspectorWindow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterAssemblyReload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterAssemblyReload.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBecameVisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBecameVisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBecameInvisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBecameInvisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnProjectWasLoaded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnProjectWasLoaded.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnSelectionChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdateSupportedDataModes(System.Collections.Generic.List<UnityEditor.DataMode>  @supportedModes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@supportedModes};
            var ___result = ROnUpdateSupportedDataModes_List_d_DataMode_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public static void RepaintAllInspectors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaintAllInspectors.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetInspectors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInspectors.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void RedrawFromNative()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRedrawFromNative.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetAllInspectorWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAllInspectorWindows.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void AddItemsToMenu(UnityEditor.GenericMenu  @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu};
            var ___result = RAddItemsToMenu_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefreshTitle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWindowObjectNameTitle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWindowObjectNameTitle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateTracker()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowButton(UnityEngine.Rect  @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r};
            var ___result = RShowButton_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LockStateChanged(System.Boolean  @lockState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockState};
            var ___result = RLockStateChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CloseIfEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseIfEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void BeginRebuildContentContainers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginRebuildContentContainers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean BeginDrawPreviewAndLabels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginDrawPreviewAndLabels.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void EndDrawPreviewAndLabels(UnityEngine.Event  @evt, UnityEngine.Rect  @rect, UnityEngine.Rect  @dragRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @rect, @dragRect};
            var ___result = REndDrawPreviewAndLabels_Event_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetachPreview(System.Boolean  @exitGUI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exitGUI};
            var ___result = RDetachPreview_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void ShowWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowWindow.Invoke(___genericsType, ___parameters);

            
        }


        public static void FlushAllOptimizedGUIBlocksIfNeeded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAllOptimizedGUIBlocksIfNeeded.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PrepareLockedObjectsForSerialization()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareLockedObjectsForSerialization.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearSerializedLockedObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearSerializedLockedObjects.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectsLocked(System.Collections.Generic.List<UnityEngine.Object>  @objs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objs};
            var ___result = RGetObjectsLocked_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetObjectsLocked(System.Collections.Generic.List<UnityEngine.Object>  @objs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objs};
            var ___result = RSetObjectsLocked_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreLockStateFromSerializedData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreLockStateFromSerializedData.Invoke(___genericsType, ___parameters);

            
        }




        public static void ApplyChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyChanges.Invoke(___genericsType, ___parameters);

            
        }


        public static void RefreshInspectors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefreshInspectors.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Object GetInspectedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInspectedObject.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.Object[] GetInspectedObjects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInspectedObjects.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object[])___result;
        }


        public virtual System.Boolean EditorsForMultiEditingChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REditorsForMultiEditingChanged.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean EditorForMultiEditingChanged(UnityEditor.Editor  @editor, UnityEngine.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @target};
            var ___result = REditorForMultiEditingChanged_Editor_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __1__AddItemsToMenu__2__b__25_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__1__AddItemsToMenu__2__b__25_0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocusChanged(System.Boolean  @focus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focus};
            var ___result = ROnFocusChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnInspectorUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnInspectorUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMode(UnityEditor.InspectorMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RSetMode_InspectorMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTitle(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RSetTitle_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadVisualTreeFromUxml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadVisualTreeFromUxml.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearEditorsAndRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearEditorsAndRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDebugItemsToMenu(UnityEditor.GenericMenu  @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu};
            var ___result = RAddDebugItemsToMenu_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExpandAllComponents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExpandAllComponents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAnyComponentCollapsed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAnyComponentCollapsed.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CollapseAllComponents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCollapseAllComponents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAnyComponentExpanded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAnyComponentExpanded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean LoadPersistedObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadPersistedObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreatePreviewables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreatePreviewables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPreviewables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPreviewables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action  @onGUIHandler, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@onGUIHandler, @name};
            var ___result = RCreateIMGUIContainer_Action_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IMGUIContainer)___result;
        }


        public virtual void EndRebuildContentContainers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndRebuildContentContainers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RebuildContentsContainers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRebuildContentsContainers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AutoScroll(UnityEngine.Vector2  @mousePosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mousePosition};
            var ___result = RAutoScroll_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollTo(UnityEngine.Vector2  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RScrollTo_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEditor.Editor GetLastInteractedEditor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLastInteractedEditor.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }



        public virtual System.Object GetEditorsWithPreviews(UnityEditor.Editor[]  @editors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors};
            var ___result = RGetEditorsWithPreviews_EditorArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean WasEditorVisible(UnityEditor.Editor[]  @editors, System.Int32  @editorIndex, UnityEngine.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @target};
            var ___result = RWasEditorVisible_EditorArray_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldCullEditor(UnityEditor.Editor[]  @editors, System.Int32  @editorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex};
            var ___result = RShouldCullEditor_EditorArray_Int32.Invoke(___genericsType, ___parameters);

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


        public virtual void UnsavedChangesStateChanged(UnityEditor.Editor  @editor, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @value};
            var ___result = RUnsavedChangesStateChanged_Editor_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSupportedDataModesList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateSupportedDataModesList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetDataModeController_Internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataModeController_Internal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetViewDataDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetViewDataDictionary.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void DisableViewDataPersistence()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisableViewDataPersistence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPersistentViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPersistentViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndWindows.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnResized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnResized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackgroundViewResized(UnityEngine.Rect  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = ROnBackgroundViewResized_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckForWindowRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckForWindowRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIContent GetLocalizedTitleContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLocalizedTitleContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void ShowNotification(UnityEngine.GUIContent  @notification)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification};
            var ___result = RShowNotification_GUIContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNotification(UnityEngine.GUIContent  @notification, System.Double  @fadeoutWait)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notification, @fadeoutWait};
            var ___result = RShowNotification_GUIContent_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawNotification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawNotification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMaximized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnMaximized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanMaximize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanMaximize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetNumTabs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNumTabs.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean ShowNextTabIfPossible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowNextTabIfPossible.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSelectedTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsSelectedTab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeParentsSettingsMatchMe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeParentsSettingsMatchMe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowUtility.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowTooltip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowTooltip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModalUtility()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowModalUtility.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void ShowAsDropDown(UnityEngine.Rect  @buttonRect, UnityEngine.Vector2  @windowSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buttonRect, @windowSize};
            var ___result = RShowAsDropDown_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void Show()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Show(System.Boolean  @immediateDisplay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@immediateDisplay};
            var ___result = RShow_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAuxWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowAuxWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowModal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowModal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromDockArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveFromDockArea.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RepaintImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaintImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParentGameViewDimensions(UnityEngine.Rect  @rect, UnityEngine.Rect  @clippedRect, UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @clippedRect, @targetSize};
            var ___result = RSetParentGameViewDimensions_Rect_Rect_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPlayModeViewSize(UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMainPlayModeViewSize(UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetSize};
            var ___result = RSetMainPlayModeViewSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDisplayViewSize(System.Int32  @displayId, UnityEngine.Vector2  @targetSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId, @targetSize};
            var ___result = RSetDisplayViewSize_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetDisplayViewSize(System.Int32  @displayId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayId};
            var ___result = RGetDisplayViewSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void SetPlayModeView(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetPlayModeView_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SendEvent(UnityEngine.Event  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddSceneTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddSceneTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddGameTab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddGameTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerable<System.Type> GetExtraPaneTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExtraPaneTypes.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Type>)___result;
        }


        public virtual System.Boolean TryGetOverlay(System.String  @id, out UnityEditor.Overlays.Overlay  @match)
        {
			match = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @match};
            var ___result = RTryGetOverlay_String_Out_Overlay.Invoke(___genericsType, ___parameters);
			match = (UnityEditor.Overlays.Overlay)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void OnBackingScaleFactorChangedInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBackingScaleFactorChangedInternal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBackingScaleFactorChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBackingScaleFactorChanged.Invoke(___genericsType, ___parameters);

            
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
