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
		protected RMethod r_Awake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_Awake == null)
				{
					r_Awake = new(this, "Awake", 0);
					r_Awake.SetBelong(this.instance);
				}
				return r_Awake;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_OnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_OnDestroy == null)
				{
					r_OnDestroy = new(this, "OnDestroy", 0);
					r_OnDestroy.SetBelong(this.instance);
				}
				return r_OnDestroy;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_OnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_OnEnable == null)
				{
					r_OnEnable = new(this, "OnEnable", 0);
					r_OnEnable.SetBelong(this.instance);
				}
				return r_OnEnable;
			}
		}

		/// <summary>
		/// Void OnAfterAssemblyReload()
		/// </summary>
		protected RMethod r_OnAfterAssemblyReload;
		public virtual RMethod ROnAfterAssemblyReload
		{
			get
			{
				if(r_OnAfterAssemblyReload == null)
				{
					r_OnAfterAssemblyReload = new(this, "OnAfterAssemblyReload", 0);
					r_OnAfterAssemblyReload.SetBelong(this.instance);
				}
				return r_OnAfterAssemblyReload;
			}
		}

		/// <summary>
		/// Void OnBecameVisible()
		/// </summary>
		protected RMethod r_OnBecameVisible;
		public virtual RMethod ROnBecameVisible
		{
			get
			{
				if(r_OnBecameVisible == null)
				{
					r_OnBecameVisible = new(this, "OnBecameVisible", 0);
					r_OnBecameVisible.SetBelong(this.instance);
				}
				return r_OnBecameVisible;
			}
		}

		/// <summary>
		/// Void OnBecameInvisible()
		/// </summary>
		protected RMethod r_OnBecameInvisible;
		public virtual RMethod ROnBecameInvisible
		{
			get
			{
				if(r_OnBecameInvisible == null)
				{
					r_OnBecameInvisible = new(this, "OnBecameInvisible", 0);
					r_OnBecameInvisible.SetBelong(this.instance);
				}
				return r_OnBecameInvisible;
			}
		}

		/// <summary>
		/// Void OnProjectWasLoaded()
		/// </summary>
		protected RMethod r_OnProjectWasLoaded;
		public virtual RMethod ROnProjectWasLoaded
		{
			get
			{
				if(r_OnProjectWasLoaded == null)
				{
					r_OnProjectWasLoaded = new(this, "OnProjectWasLoaded", 0);
					r_OnProjectWasLoaded.SetBelong(this.instance);
				}
				return r_OnProjectWasLoaded;
			}
		}

		/// <summary>
		/// Void OnSelectionChanged()
		/// </summary>
		protected RMethod r_OnSelectionChanged;
		public virtual RMethod ROnSelectionChanged
		{
			get
			{
				if(r_OnSelectionChanged == null)
				{
					r_OnSelectionChanged = new(this, "OnSelectionChanged", 0);
					r_OnSelectionChanged.SetBelong(this.instance);
				}
				return r_OnSelectionChanged;
			}
		}

		/// <summary>
		/// Void OnUpdateSupportedDataModes(System.Collections.Generic.List`1[UnityEditor.DataMode])
		/// </summary>
		protected RMethod r_OnUpdateSupportedDataModes_List_d_DataMode_p_;
		public virtual RMethod ROnUpdateSupportedDataModes_List_d_DataMode_p_
		{
			get
			{
				if(r_OnUpdateSupportedDataModes_List_d_DataMode_p_ == null)
				{
					r_OnUpdateSupportedDataModes_List_d_DataMode_p_ = new(this, "OnUpdateSupportedDataModes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.DataMode)));
					r_OnUpdateSupportedDataModes_List_d_DataMode_p_.SetBelong(this.instance);
				}
				return r_OnUpdateSupportedDataModes_List_d_DataMode_p_;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_OnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_OnDisable == null)
				{
					r_OnDisable = new(this, "OnDisable", 0);
					r_OnDisable.SetBelong(this.instance);
				}
				return r_OnDisable;
			}
		}

		/// <summary>
		/// Void RepaintAllInspectors()
		/// </summary>
		protected static RMethod r_RepaintAllInspectors;
		public static RMethod RRepaintAllInspectors
		{
			get
			{
				if(r_RepaintAllInspectors == null)
				{
					r_RepaintAllInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RepaintAllInspectors", 0);
					r_RepaintAllInspectors.SetBelong(null);
				}
				return r_RepaintAllInspectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.InspectorWindow] GetInspectors()
		/// </summary>
		protected static RMethod r_GetInspectors;
		public static RMethod RGetInspectors
		{
			get
			{
				if(r_GetInspectors == null)
				{
					r_GetInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "GetInspectors", 0);
					r_GetInspectors.SetBelong(null);
				}
				return r_GetInspectors;
			}
		}

		/// <summary>
		/// Void RedrawFromNative()
		/// </summary>
		protected static RMethod r_RedrawFromNative;
		public static RMethod RRedrawFromNative
		{
			get
			{
				if(r_RedrawFromNative == null)
				{
					r_RedrawFromNative = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RedrawFromNative", 0);
					r_RedrawFromNative.SetBelong(null);
				}
				return r_RedrawFromNative;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorWindow[] GetAllInspectorWindows()
		/// </summary>
		protected static RMethod r_GetAllInspectorWindows;
		public static RMethod RGetAllInspectorWindows
		{
			get
			{
				if(r_GetAllInspectorWindows == null)
				{
					r_GetAllInspectorWindows = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "GetAllInspectorWindows", 0);
					r_GetAllInspectorWindows.SetBelong(null);
				}
				return r_GetAllInspectorWindows;
			}
		}

		/// <summary>
		/// Void AddItemsToMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_AddItemsToMenu_GenericMenu;
		public virtual RMethod RAddItemsToMenu_GenericMenu
		{
			get
			{
				if(r_AddItemsToMenu_GenericMenu == null)
				{
					r_AddItemsToMenu_GenericMenu = new(this, "AddItemsToMenu", 0, typeof(UnityEditor.GenericMenu));
					r_AddItemsToMenu_GenericMenu.SetBelong(this.instance);
				}
				return r_AddItemsToMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void RefreshTitle()
		/// </summary>
		protected RMethod r_RefreshTitle;
		public virtual RMethod RRefreshTitle
		{
			get
			{
				if(r_RefreshTitle == null)
				{
					r_RefreshTitle = new(this, "RefreshTitle", 0);
					r_RefreshTitle.SetBelong(this.instance);
				}
				return r_RefreshTitle;
			}
		}

		/// <summary>
		/// Void UpdateWindowObjectNameTitle()
		/// </summary>
		protected RMethod r_UpdateWindowObjectNameTitle;
		public virtual RMethod RUpdateWindowObjectNameTitle
		{
			get
			{
				if(r_UpdateWindowObjectNameTitle == null)
				{
					r_UpdateWindowObjectNameTitle = new(this, "UpdateWindowObjectNameTitle", 0);
					r_UpdateWindowObjectNameTitle.SetBelong(this.instance);
				}
				return r_UpdateWindowObjectNameTitle;
			}
		}

		/// <summary>
		/// Void CreateTracker()
		/// </summary>
		protected RMethod r_CreateTracker;
		public virtual RMethod RCreateTracker
		{
			get
			{
				if(r_CreateTracker == null)
				{
					r_CreateTracker = new(this, "CreateTracker", 0);
					r_CreateTracker.SetBelong(this.instance);
				}
				return r_CreateTracker;
			}
		}

		/// <summary>
		/// Void ShowButton(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ShowButton_Rect;
		public virtual RMethod RShowButton_Rect
		{
			get
			{
				if(r_ShowButton_Rect == null)
				{
					r_ShowButton_Rect = new(this, "ShowButton", 0, typeof(UnityEngine.Rect));
					r_ShowButton_Rect.SetBelong(this.instance);
				}
				return r_ShowButton_Rect;
			}
		}

		/// <summary>
		/// Void LockStateChanged(Boolean)
		/// </summary>
		protected RMethod r_LockStateChanged_Boolean;
		public virtual RMethod RLockStateChanged_Boolean
		{
			get
			{
				if(r_LockStateChanged_Boolean == null)
				{
					r_LockStateChanged_Boolean = new(this, "LockStateChanged", 0, typeof(System.Boolean));
					r_LockStateChanged_Boolean.SetBelong(this.instance);
				}
				return r_LockStateChanged_Boolean;
			}
		}

		/// <summary>
		/// Boolean CloseIfEmpty()
		/// </summary>
		protected RMethod r_CloseIfEmpty;
		public virtual RMethod RCloseIfEmpty
		{
			get
			{
				if(r_CloseIfEmpty == null)
				{
					r_CloseIfEmpty = new(this, "CloseIfEmpty", 0);
					r_CloseIfEmpty.SetBelong(this.instance);
				}
				return r_CloseIfEmpty;
			}
		}

		/// <summary>
		/// Void BeginRebuildContentContainers()
		/// </summary>
		protected RMethod r_BeginRebuildContentContainers;
		public virtual RMethod RBeginRebuildContentContainers
		{
			get
			{
				if(r_BeginRebuildContentContainers == null)
				{
					r_BeginRebuildContentContainers = new(this, "BeginRebuildContentContainers", 0);
					r_BeginRebuildContentContainers.SetBelong(this.instance);
				}
				return r_BeginRebuildContentContainers;
			}
		}

		/// <summary>
		/// Boolean BeginDrawPreviewAndLabels()
		/// </summary>
		protected RMethod r_BeginDrawPreviewAndLabels;
		public virtual RMethod RBeginDrawPreviewAndLabels
		{
			get
			{
				if(r_BeginDrawPreviewAndLabels == null)
				{
					r_BeginDrawPreviewAndLabels = new(this, "BeginDrawPreviewAndLabels", 0);
					r_BeginDrawPreviewAndLabels.SetBelong(this.instance);
				}
				return r_BeginDrawPreviewAndLabels;
			}
		}

		/// <summary>
		/// Void EndDrawPreviewAndLabels(UnityEngine.Event, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_EndDrawPreviewAndLabels_Event_Rect_Rect;
		public virtual RMethod REndDrawPreviewAndLabels_Event_Rect_Rect
		{
			get
			{
				if(r_EndDrawPreviewAndLabels_Event_Rect_Rect == null)
				{
					r_EndDrawPreviewAndLabels_Event_Rect_Rect = new(this, "EndDrawPreviewAndLabels", 0, typeof(UnityEngine.Event), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_EndDrawPreviewAndLabels_Event_Rect_Rect.SetBelong(this.instance);
				}
				return r_EndDrawPreviewAndLabels_Event_Rect_Rect;
			}
		}

		/// <summary>
		/// Void DetachPreview(Boolean)
		/// </summary>
		protected RMethod r_DetachPreview_Boolean;
		public virtual RMethod RDetachPreview_Boolean
		{
			get
			{
				if(r_DetachPreview_Boolean == null)
				{
					r_DetachPreview_Boolean = new(this, "DetachPreview", 0, typeof(System.Boolean));
					r_DetachPreview_Boolean.SetBelong(this.instance);
				}
				return r_DetachPreview_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWindow()
		/// </summary>
		protected static RMethod r_ShowWindow;
		public static RMethod RShowWindow
		{
			get
			{
				if(r_ShowWindow == null)
				{
					r_ShowWindow = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "ShowWindow", 0);
					r_ShowWindow.SetBelong(null);
				}
				return r_ShowWindow;
			}
		}

		/// <summary>
		/// Void FlushAllOptimizedGUIBlocksIfNeeded()
		/// </summary>
		protected static RMethod r_FlushAllOptimizedGUIBlocksIfNeeded;
		public static RMethod RFlushAllOptimizedGUIBlocksIfNeeded
		{
			get
			{
				if(r_FlushAllOptimizedGUIBlocksIfNeeded == null)
				{
					r_FlushAllOptimizedGUIBlocksIfNeeded = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "FlushAllOptimizedGUIBlocksIfNeeded", 0);
					r_FlushAllOptimizedGUIBlocksIfNeeded.SetBelong(null);
				}
				return r_FlushAllOptimizedGUIBlocksIfNeeded;
			}
		}

		/// <summary>
		/// Void PrepareLockedObjectsForSerialization()
		/// </summary>
		protected RMethod r_PrepareLockedObjectsForSerialization;
		public virtual RMethod RPrepareLockedObjectsForSerialization
		{
			get
			{
				if(r_PrepareLockedObjectsForSerialization == null)
				{
					r_PrepareLockedObjectsForSerialization = new(this, "PrepareLockedObjectsForSerialization", 0);
					r_PrepareLockedObjectsForSerialization.SetBelong(this.instance);
				}
				return r_PrepareLockedObjectsForSerialization;
			}
		}

		/// <summary>
		/// Void ClearSerializedLockedObjects()
		/// </summary>
		protected RMethod r_ClearSerializedLockedObjects;
		public virtual RMethod RClearSerializedLockedObjects
		{
			get
			{
				if(r_ClearSerializedLockedObjects == null)
				{
					r_ClearSerializedLockedObjects = new(this, "ClearSerializedLockedObjects", 0);
					r_ClearSerializedLockedObjects.SetBelong(this.instance);
				}
				return r_ClearSerializedLockedObjects;
			}
		}

		/// <summary>
		/// Void GetObjectsLocked(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_GetObjectsLocked_List_d_Object_p_;
		public virtual RMethod RGetObjectsLocked_List_d_Object_p_
		{
			get
			{
				if(r_GetObjectsLocked_List_d_Object_p_ == null)
				{
					r_GetObjectsLocked_List_d_Object_p_ = new(this, "GetObjectsLocked", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_GetObjectsLocked_List_d_Object_p_.SetBelong(this.instance);
				}
				return r_GetObjectsLocked_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void SetObjectsLocked(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_SetObjectsLocked_List_d_Object_p_;
		public virtual RMethod RSetObjectsLocked_List_d_Object_p_
		{
			get
			{
				if(r_SetObjectsLocked_List_d_Object_p_ == null)
				{
					r_SetObjectsLocked_List_d_Object_p_ = new(this, "SetObjectsLocked", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_SetObjectsLocked_List_d_Object_p_.SetBelong(this.instance);
				}
				return r_SetObjectsLocked_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void RestoreLockStateFromSerializedData()
		/// </summary>
		protected RMethod r_RestoreLockStateFromSerializedData;
		public virtual RMethod RRestoreLockStateFromSerializedData
		{
			get
			{
				if(r_RestoreLockStateFromSerializedData == null)
				{
					r_RestoreLockStateFromSerializedData = new(this, "RestoreLockStateFromSerializedData", 0);
					r_RestoreLockStateFromSerializedData.SetBelong(this.instance);
				}
				return r_RestoreLockStateFromSerializedData;
			}
		}

		/// <summary>
		/// Boolean AddInspectorWindow(UnityEditor.InspectorWindow)
		/// </summary>
		protected static RMethod r_AddInspectorWindow_InspectorWindow;
		public static RMethod RAddInspectorWindow_InspectorWindow
		{
			get
			{
				if(r_AddInspectorWindow_InspectorWindow == null)
				{
					r_AddInspectorWindow_InspectorWindow = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "AddInspectorWindow", 0,  ReleactionUtils.GetType("UnityEditor.InspectorWindow"));
					r_AddInspectorWindow_InspectorWindow.SetBelong(null);
				}
				return r_AddInspectorWindow_InspectorWindow;
			}
		}

		/// <summary>
		/// Void RemoveInspectorWindow(UnityEditor.InspectorWindow)
		/// </summary>
		protected static RMethod r_RemoveInspectorWindow_InspectorWindow;
		public static RMethod RRemoveInspectorWindow_InspectorWindow
		{
			get
			{
				if(r_RemoveInspectorWindow_InspectorWindow == null)
				{
					r_RemoveInspectorWindow_InspectorWindow = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RemoveInspectorWindow", 0,  ReleactionUtils.GetType("UnityEditor.InspectorWindow"));
					r_RemoveInspectorWindow_InspectorWindow.SetBelong(null);
				}
				return r_RemoveInspectorWindow_InspectorWindow;
			}
		}

		/// <summary>
		/// Void ApplyChanges()
		/// </summary>
		protected static RMethod r_ApplyChanges;
		public static RMethod RApplyChanges
		{
			get
			{
				if(r_ApplyChanges == null)
				{
					r_ApplyChanges = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "ApplyChanges", 0);
					r_ApplyChanges.SetBelong(null);
				}
				return r_ApplyChanges;
			}
		}

		/// <summary>
		/// Void RefreshInspectors()
		/// </summary>
		protected static RMethod r_RefreshInspectors;
		public static RMethod RRefreshInspectors
		{
			get
			{
				if(r_RefreshInspectors == null)
				{
					r_RefreshInspectors = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "RefreshInspectors", 0);
					r_RefreshInspectors.SetBelong(null);
				}
				return r_RefreshInspectors;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetInspectedObject()
		/// </summary>
		protected RMethod r_GetInspectedObject;
		public virtual RMethod RGetInspectedObject
		{
			get
			{
				if(r_GetInspectedObject == null)
				{
					r_GetInspectedObject = new(this, "GetInspectedObject", 0);
					r_GetInspectedObject.SetBelong(this.instance);
				}
				return r_GetInspectedObject;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] GetInspectedObjects()
		/// </summary>
		protected RMethod r_GetInspectedObjects;
		public virtual RMethod RGetInspectedObjects
		{
			get
			{
				if(r_GetInspectedObjects == null)
				{
					r_GetInspectedObjects = new(this, "GetInspectedObjects", 0);
					r_GetInspectedObjects.SetBelong(this.instance);
				}
				return r_GetInspectedObjects;
			}
		}

		/// <summary>
		/// Boolean EditorsForMultiEditingChanged()
		/// </summary>
		protected RMethod r_EditorsForMultiEditingChanged;
		public virtual RMethod REditorsForMultiEditingChanged
		{
			get
			{
				if(r_EditorsForMultiEditingChanged == null)
				{
					r_EditorsForMultiEditingChanged = new(this, "EditorsForMultiEditingChanged", 0);
					r_EditorsForMultiEditingChanged.SetBelong(this.instance);
				}
				return r_EditorsForMultiEditingChanged;
			}
		}

		/// <summary>
		/// Boolean EditorForMultiEditingChanged(UnityEditor.Editor, UnityEngine.Object)
		/// </summary>
		protected static RMethod r_EditorForMultiEditingChanged_Editor_Object;
		public static RMethod REditorForMultiEditingChanged_Editor_Object
		{
			get
			{
				if(r_EditorForMultiEditingChanged_Editor_Object == null)
				{
					r_EditorForMultiEditingChanged_Editor_Object = new( ReleactionUtils.GetType("UnityEditor.InspectorWindow"), "EditorForMultiEditingChanged", 0, typeof(UnityEditor.Editor), typeof(UnityEngine.Object));
					r_EditorForMultiEditingChanged_Editor_Object.SetBelong(null);
				}
				return r_EditorForMultiEditingChanged_Editor_Object;
			}
		}

		/// <summary>
		/// Void <AddItemsToMenu>b__25_0()
		/// </summary>
		protected RMethod r___0__AddItemsToMenu__1__b__25_0;
		public virtual RMethod R__0__AddItemsToMenu__1__b__25_0
		{
			get
			{
				if(r___0__AddItemsToMenu__1__b__25_0 == null)
				{
					r___0__AddItemsToMenu__1__b__25_0 = new(this, "<AddItemsToMenu>b__25_0", 0);
					r___0__AddItemsToMenu__1__b__25_0.SetBelong(this.instance);
				}
				return r___0__AddItemsToMenu__1__b__25_0;
			}
		}

		/// <summary>
		/// Void OnFocusChanged(Boolean)
		/// </summary>
		protected RMethod r_OnFocusChanged_Boolean;
		public virtual RMethod ROnFocusChanged_Boolean
		{
			get
			{
				if(r_OnFocusChanged_Boolean == null)
				{
					r_OnFocusChanged_Boolean = new(this, "OnFocusChanged", 0, typeof(System.Boolean));
					r_OnFocusChanged_Boolean.SetBelong(this.instance);
				}
				return r_OnFocusChanged_Boolean;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_OnLostFocus;
		public virtual RMethod ROnLostFocus
		{
			get
			{
				if(r_OnLostFocus == null)
				{
					r_OnLostFocus = new(this, "OnLostFocus", 0);
					r_OnLostFocus.SetBelong(this.instance);
				}
				return r_OnLostFocus;
			}
		}

		/// <summary>
		/// Void OnInspectorUpdate()
		/// </summary>
		protected RMethod r_OnInspectorUpdate;
		public virtual RMethod ROnInspectorUpdate
		{
			get
			{
				if(r_OnInspectorUpdate == null)
				{
					r_OnInspectorUpdate = new(this, "OnInspectorUpdate", 0);
					r_OnInspectorUpdate.SetBelong(this.instance);
				}
				return r_OnInspectorUpdate;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_OnGUI;
		public virtual RMethod ROnGUI
		{
			get
			{
				if(r_OnGUI == null)
				{
					r_OnGUI = new(this, "OnGUI", 0);
					r_OnGUI.SetBelong(this.instance);
				}
				return r_OnGUI;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_Update;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_Update == null)
				{
					r_Update = new(this, "Update", 0);
					r_Update.SetBelong(this.instance);
				}
				return r_Update;
			}
		}

		/// <summary>
		/// Void SetMode(UnityEditor.InspectorMode)
		/// </summary>
		protected RMethod r_SetMode_InspectorMode;
		public virtual RMethod RSetMode_InspectorMode
		{
			get
			{
				if(r_SetMode_InspectorMode == null)
				{
					r_SetMode_InspectorMode = new(this, "SetMode", 0, typeof(UnityEditor.InspectorMode));
					r_SetMode_InspectorMode.SetBelong(this.instance);
				}
				return r_SetMode_InspectorMode;
			}
		}

		/// <summary>
		/// Void SetTitle(UnityEngine.Object)
		/// </summary>
		protected RMethod r_SetTitle_Object;
		public virtual RMethod RSetTitle_Object
		{
			get
			{
				if(r_SetTitle_Object == null)
				{
					r_SetTitle_Object = new(this, "SetTitle", 0, typeof(UnityEngine.Object));
					r_SetTitle_Object.SetBelong(this.instance);
				}
				return r_SetTitle_Object;
			}
		}

		/// <summary>
		/// Void LoadVisualTreeFromUxml()
		/// </summary>
		protected RMethod r_LoadVisualTreeFromUxml;
		public virtual RMethod RLoadVisualTreeFromUxml
		{
			get
			{
				if(r_LoadVisualTreeFromUxml == null)
				{
					r_LoadVisualTreeFromUxml = new(this, "LoadVisualTreeFromUxml", 0);
					r_LoadVisualTreeFromUxml.SetBelong(this.instance);
				}
				return r_LoadVisualTreeFromUxml;
			}
		}

		/// <summary>
		/// Void ClearEditorsAndRebuild()
		/// </summary>
		protected RMethod r_ClearEditorsAndRebuild;
		public virtual RMethod RClearEditorsAndRebuild
		{
			get
			{
				if(r_ClearEditorsAndRebuild == null)
				{
					r_ClearEditorsAndRebuild = new(this, "ClearEditorsAndRebuild", 0);
					r_ClearEditorsAndRebuild.SetBelong(this.instance);
				}
				return r_ClearEditorsAndRebuild;
			}
		}

		/// <summary>
		/// Void AddDebugItemsToMenu(UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_AddDebugItemsToMenu_GenericMenu;
		public virtual RMethod RAddDebugItemsToMenu_GenericMenu
		{
			get
			{
				if(r_AddDebugItemsToMenu_GenericMenu == null)
				{
					r_AddDebugItemsToMenu_GenericMenu = new(this, "AddDebugItemsToMenu", 0, typeof(UnityEditor.GenericMenu));
					r_AddDebugItemsToMenu_GenericMenu.SetBelong(this.instance);
				}
				return r_AddDebugItemsToMenu_GenericMenu;
			}
		}

		/// <summary>
		/// Void ExpandAllComponents()
		/// </summary>
		protected RMethod r_ExpandAllComponents;
		public virtual RMethod RExpandAllComponents
		{
			get
			{
				if(r_ExpandAllComponents == null)
				{
					r_ExpandAllComponents = new(this, "ExpandAllComponents", 0);
					r_ExpandAllComponents.SetBelong(this.instance);
				}
				return r_ExpandAllComponents;
			}
		}

		/// <summary>
		/// Boolean IsAnyComponentCollapsed()
		/// </summary>
		protected RMethod r_IsAnyComponentCollapsed;
		public virtual RMethod RIsAnyComponentCollapsed
		{
			get
			{
				if(r_IsAnyComponentCollapsed == null)
				{
					r_IsAnyComponentCollapsed = new(this, "IsAnyComponentCollapsed", 0);
					r_IsAnyComponentCollapsed.SetBelong(this.instance);
				}
				return r_IsAnyComponentCollapsed;
			}
		}

		/// <summary>
		/// Void CollapseAllComponents()
		/// </summary>
		protected RMethod r_CollapseAllComponents;
		public virtual RMethod RCollapseAllComponents
		{
			get
			{
				if(r_CollapseAllComponents == null)
				{
					r_CollapseAllComponents = new(this, "CollapseAllComponents", 0);
					r_CollapseAllComponents.SetBelong(this.instance);
				}
				return r_CollapseAllComponents;
			}
		}

		/// <summary>
		/// Boolean IsAnyComponentExpanded()
		/// </summary>
		protected RMethod r_IsAnyComponentExpanded;
		public virtual RMethod RIsAnyComponentExpanded
		{
			get
			{
				if(r_IsAnyComponentExpanded == null)
				{
					r_IsAnyComponentExpanded = new(this, "IsAnyComponentExpanded", 0);
					r_IsAnyComponentExpanded.SetBelong(this.instance);
				}
				return r_IsAnyComponentExpanded;
			}
		}

		/// <summary>
		/// Boolean LoadPersistedObject()
		/// </summary>
		protected RMethod r_LoadPersistedObject;
		public virtual RMethod RLoadPersistedObject
		{
			get
			{
				if(r_LoadPersistedObject == null)
				{
					r_LoadPersistedObject = new(this, "LoadPersistedObject", 0);
					r_LoadPersistedObject.SetBelong(this.instance);
				}
				return r_LoadPersistedObject;
			}
		}

		/// <summary>
		/// Void CreatePreviewables()
		/// </summary>
		protected RMethod r_CreatePreviewables;
		public virtual RMethod RCreatePreviewables
		{
			get
			{
				if(r_CreatePreviewables == null)
				{
					r_CreatePreviewables = new(this, "CreatePreviewables", 0);
					r_CreatePreviewables.SetBelong(this.instance);
				}
				return r_CreatePreviewables;
			}
		}

		/// <summary>
		/// Void ClearPreviewables()
		/// </summary>
		protected RMethod r_ClearPreviewables;
		public virtual RMethod RClearPreviewables
		{
			get
			{
				if(r_ClearPreviewables == null)
				{
					r_ClearPreviewables = new(this, "ClearPreviewables", 0);
					r_ClearPreviewables.SetBelong(this.instance);
				}
				return r_ClearPreviewables;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action, System.String)
		/// </summary>
		protected RMethod r_CreateIMGUIContainer_Action_String;
		public virtual RMethod RCreateIMGUIContainer_Action_String
		{
			get
			{
				if(r_CreateIMGUIContainer_Action_String == null)
				{
					r_CreateIMGUIContainer_Action_String = new(this, "CreateIMGUIContainer", 0, typeof(System.Action), typeof(System.String));
					r_CreateIMGUIContainer_Action_String.SetBelong(this.instance);
				}
				return r_CreateIMGUIContainer_Action_String;
			}
		}

		/// <summary>
		/// Void EndRebuildContentContainers()
		/// </summary>
		protected RMethod r_EndRebuildContentContainers;
		public virtual RMethod REndRebuildContentContainers
		{
			get
			{
				if(r_EndRebuildContentContainers == null)
				{
					r_EndRebuildContentContainers = new(this, "EndRebuildContentContainers", 0);
					r_EndRebuildContentContainers.SetBelong(this.instance);
				}
				return r_EndRebuildContentContainers;
			}
		}

		/// <summary>
		/// Void RebuildContentsContainers()
		/// </summary>
		protected RMethod r_RebuildContentsContainers;
		public virtual RMethod RRebuildContentsContainers
		{
			get
			{
				if(r_RebuildContentsContainers == null)
				{
					r_RebuildContentsContainers = new(this, "RebuildContentsContainers", 0);
					r_RebuildContentsContainers.SetBelong(this.instance);
				}
				return r_RebuildContentsContainers;
			}
		}

		/// <summary>
		/// Void AutoScroll(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_AutoScroll_Vector2;
		public virtual RMethod RAutoScroll_Vector2
		{
			get
			{
				if(r_AutoScroll_Vector2 == null)
				{
					r_AutoScroll_Vector2 = new(this, "AutoScroll", 0, typeof(UnityEngine.Vector2));
					r_AutoScroll_Vector2.SetBelong(this.instance);
				}
				return r_AutoScroll_Vector2;
			}
		}

		/// <summary>
		/// Void ScrollTo(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_ScrollTo_Vector2;
		public virtual RMethod RScrollTo_Vector2
		{
			get
			{
				if(r_ScrollTo_Vector2 == null)
				{
					r_ScrollTo_Vector2 = new(this, "ScrollTo", 0, typeof(UnityEngine.Vector2));
					r_ScrollTo_Vector2.SetBelong(this.instance);
				}
				return r_ScrollTo_Vector2;
			}
		}

		/// <summary>
		/// UnityEditor.Editor GetLastInteractedEditor()
		/// </summary>
		protected RMethod r_GetLastInteractedEditor;
		public virtual RMethod RGetLastInteractedEditor
		{
			get
			{
				if(r_GetLastInteractedEditor == null)
				{
					r_GetLastInteractedEditor = new(this, "GetLastInteractedEditor", 0);
					r_GetLastInteractedEditor.SetBelong(this.instance);
				}
				return r_GetLastInteractedEditor;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable GetEditorThatControlsPreview(UnityEditor.IPreviewable[])
		/// </summary>
		protected RMethod r_GetEditorThatControlsPreview_IPreviewableArray;
		public virtual RMethod RGetEditorThatControlsPreview_IPreviewableArray
		{
			get
			{
				if(r_GetEditorThatControlsPreview_IPreviewableArray == null)
				{
					r_GetEditorThatControlsPreview_IPreviewableArray = new(this, "GetEditorThatControlsPreview", 0,  ReleactionUtils.GetType("UnityEditor.IPreviewable").MakeArrayType());
					r_GetEditorThatControlsPreview_IPreviewableArray.SetBelong(this.instance);
				}
				return r_GetEditorThatControlsPreview_IPreviewableArray;
			}
		}

		/// <summary>
		/// UnityEditor.IPreviewable[] GetEditorsWithPreviews(UnityEditor.Editor[])
		/// </summary>
		protected RMethod r_GetEditorsWithPreviews_EditorArray;
		public virtual RMethod RGetEditorsWithPreviews_EditorArray
		{
			get
			{
				if(r_GetEditorsWithPreviews_EditorArray == null)
				{
					r_GetEditorsWithPreviews_EditorArray = new(this, "GetEditorsWithPreviews", 0, typeof(UnityEditor.Editor).MakeArrayType());
					r_GetEditorsWithPreviews_EditorArray.SetBelong(this.instance);
				}
				return r_GetEditorsWithPreviews_EditorArray;
			}
		}

		/// <summary>
		/// Boolean WasEditorVisible(UnityEditor.Editor[], Int32, UnityEngine.Object)
		/// </summary>
		protected RMethod r_WasEditorVisible_EditorArray_Int32_Object;
		public virtual RMethod RWasEditorVisible_EditorArray_Int32_Object
		{
			get
			{
				if(r_WasEditorVisible_EditorArray_Int32_Object == null)
				{
					r_WasEditorVisible_EditorArray_Int32_Object = new(this, "WasEditorVisible", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Object));
					r_WasEditorVisible_EditorArray_Int32_Object.SetBelong(this.instance);
				}
				return r_WasEditorVisible_EditorArray_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean ShouldCullEditor(UnityEditor.Editor[], Int32)
		/// </summary>
		protected RMethod r_ShouldCullEditor_EditorArray_Int32;
		public virtual RMethod RShouldCullEditor_EditorArray_Int32
		{
			get
			{
				if(r_ShouldCullEditor_EditorArray_Int32 == null)
				{
					r_ShouldCullEditor_EditorArray_Int32 = new(this, "ShouldCullEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32));
					r_ShouldCullEditor_EditorArray_Int32.SetBelong(this.instance);
				}
				return r_ShouldCullEditor_EditorArray_Int32;
			}
		}

		/// <summary>
		/// Void SaveChanges()
		/// </summary>
		protected RMethod r_SaveChanges;
		public virtual RMethod RSaveChanges
		{
			get
			{
				if(r_SaveChanges == null)
				{
					r_SaveChanges = new(this, "SaveChanges", 0);
					r_SaveChanges.SetBelong(this.instance);
				}
				return r_SaveChanges;
			}
		}

		/// <summary>
		/// Void DiscardChanges()
		/// </summary>
		protected RMethod r_DiscardChanges;
		public virtual RMethod RDiscardChanges
		{
			get
			{
				if(r_DiscardChanges == null)
				{
					r_DiscardChanges = new(this, "DiscardChanges", 0);
					r_DiscardChanges.SetBelong(this.instance);
				}
				return r_DiscardChanges;
			}
		}

		/// <summary>
		/// Void UnsavedChangesStateChanged(UnityEditor.Editor, Boolean)
		/// </summary>
		protected RMethod r_UnsavedChangesStateChanged_Editor_Boolean;
		public virtual RMethod RUnsavedChangesStateChanged_Editor_Boolean
		{
			get
			{
				if(r_UnsavedChangesStateChanged_Editor_Boolean == null)
				{
					r_UnsavedChangesStateChanged_Editor_Boolean = new(this, "UnsavedChangesStateChanged", 0, typeof(UnityEditor.Editor), typeof(System.Boolean));
					r_UnsavedChangesStateChanged_Editor_Boolean.SetBelong(this.instance);
				}
				return r_UnsavedChangesStateChanged_Editor_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateSupportedDataModesList()
		/// </summary>
		protected RMethod r_UpdateSupportedDataModesList;
		public virtual RMethod RUpdateSupportedDataModesList
		{
			get
			{
				if(r_UpdateSupportedDataModesList == null)
				{
					r_UpdateSupportedDataModesList = new(this, "UpdateSupportedDataModesList", 0);
					r_UpdateSupportedDataModesList.SetBelong(this.instance);
				}
				return r_UpdateSupportedDataModesList;
			}
		}

		/// <summary>
		/// UnityEditor.DataModeController GetDataModeController_Internal()
		/// </summary>
		protected RMethod r_GetDataModeController_Internal;
		public virtual RMethod RGetDataModeController_Internal
		{
			get
			{
				if(r_GetDataModeController_Internal == null)
				{
					r_GetDataModeController_Internal = new(this, "GetDataModeController_Internal", 0);
					r_GetDataModeController_Internal.SetBelong(this.instance);
				}
				return r_GetDataModeController_Internal;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_SaveViewData;
		public virtual RMethod RSaveViewData
		{
			get
			{
				if(r_SaveViewData == null)
				{
					r_SaveViewData = new(this, "SaveViewData", 0);
					r_SaveViewData.SetBelong(this.instance);
				}
				return r_SaveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ISerializableJsonDictionary GetViewDataDictionary()
		/// </summary>
		protected RMethod r_GetViewDataDictionary;
		public virtual RMethod RGetViewDataDictionary
		{
			get
			{
				if(r_GetViewDataDictionary == null)
				{
					r_GetViewDataDictionary = new(this, "GetViewDataDictionary", 0);
					r_GetViewDataDictionary.SetBelong(this.instance);
				}
				return r_GetViewDataDictionary;
			}
		}

		/// <summary>
		/// Void DisableViewDataPersistence()
		/// </summary>
		protected RMethod r_DisableViewDataPersistence;
		public virtual RMethod RDisableViewDataPersistence
		{
			get
			{
				if(r_DisableViewDataPersistence == null)
				{
					r_DisableViewDataPersistence = new(this, "DisableViewDataPersistence", 0);
					r_DisableViewDataPersistence.SetBelong(this.instance);
				}
				return r_DisableViewDataPersistence;
			}
		}

		/// <summary>
		/// Void ClearPersistentViewData()
		/// </summary>
		protected RMethod r_ClearPersistentViewData;
		public virtual RMethod RClearPersistentViewData
		{
			get
			{
				if(r_ClearPersistentViewData == null)
				{
					r_ClearPersistentViewData = new(this, "ClearPersistentViewData", 0);
					r_ClearPersistentViewData.SetBelong(this.instance);
				}
				return r_ClearPersistentViewData;
			}
		}

		/// <summary>
		/// Void BeginWindows()
		/// </summary>
		protected RMethod r_BeginWindows;
		public virtual RMethod RBeginWindows
		{
			get
			{
				if(r_BeginWindows == null)
				{
					r_BeginWindows = new(this, "BeginWindows", 0);
					r_BeginWindows.SetBelong(this.instance);
				}
				return r_BeginWindows;
			}
		}

		/// <summary>
		/// Void EndWindows()
		/// </summary>
		protected RMethod r_EndWindows;
		public virtual RMethod REndWindows
		{
			get
			{
				if(r_EndWindows == null)
				{
					r_EndWindows = new(this, "EndWindows", 0);
					r_EndWindows.SetBelong(this.instance);
				}
				return r_EndWindows;
			}
		}

		/// <summary>
		/// Void OnResized()
		/// </summary>
		protected RMethod r_OnResized;
		public virtual RMethod ROnResized
		{
			get
			{
				if(r_OnResized == null)
				{
					r_OnResized = new(this, "OnResized", 0);
					r_OnResized.SetBelong(this.instance);
				}
				return r_OnResized;
			}
		}

		/// <summary>
		/// Void OnBackgroundViewResized(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_OnBackgroundViewResized_Rect;
		public virtual RMethod ROnBackgroundViewResized_Rect
		{
			get
			{
				if(r_OnBackgroundViewResized_Rect == null)
				{
					r_OnBackgroundViewResized_Rect = new(this, "OnBackgroundViewResized", 0, typeof(UnityEngine.Rect));
					r_OnBackgroundViewResized_Rect.SetBelong(this.instance);
				}
				return r_OnBackgroundViewResized_Rect;
			}
		}

		/// <summary>
		/// Void CheckForWindowRepaint()
		/// </summary>
		protected RMethod r_CheckForWindowRepaint;
		public virtual RMethod RCheckForWindowRepaint
		{
			get
			{
				if(r_CheckForWindowRepaint == null)
				{
					r_CheckForWindowRepaint = new(this, "CheckForWindowRepaint", 0);
					r_CheckForWindowRepaint.SetBelong(this.instance);
				}
				return r_CheckForWindowRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent GetLocalizedTitleContent()
		/// </summary>
		protected RMethod r_GetLocalizedTitleContent;
		public virtual RMethod RGetLocalizedTitleContent
		{
			get
			{
				if(r_GetLocalizedTitleContent == null)
				{
					r_GetLocalizedTitleContent = new(this, "GetLocalizedTitleContent", 0);
					r_GetLocalizedTitleContent.SetBelong(this.instance);
				}
				return r_GetLocalizedTitleContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_ShowNotification_GUIContent;
		public virtual RMethod RShowNotification_GUIContent
		{
			get
			{
				if(r_ShowNotification_GUIContent == null)
				{
					r_ShowNotification_GUIContent = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent));
					r_ShowNotification_GUIContent.SetBelong(this.instance);
				}
				return r_ShowNotification_GUIContent;
			}
		}

		/// <summary>
		/// Void ShowNotification(UnityEngine.GUIContent, Double)
		/// </summary>
		protected RMethod r_ShowNotification_GUIContent_Double;
		public virtual RMethod RShowNotification_GUIContent_Double
		{
			get
			{
				if(r_ShowNotification_GUIContent_Double == null)
				{
					r_ShowNotification_GUIContent_Double = new(this, "ShowNotification", 0, typeof(UnityEngine.GUIContent), typeof(System.Double));
					r_ShowNotification_GUIContent_Double.SetBelong(this.instance);
				}
				return r_ShowNotification_GUIContent_Double;
			}
		}

		/// <summary>
		/// Void RemoveNotification()
		/// </summary>
		protected RMethod r_RemoveNotification;
		public virtual RMethod RRemoveNotification
		{
			get
			{
				if(r_RemoveNotification == null)
				{
					r_RemoveNotification = new(this, "RemoveNotification", 0);
					r_RemoveNotification.SetBelong(this.instance);
				}
				return r_RemoveNotification;
			}
		}

		/// <summary>
		/// Void DrawNotification()
		/// </summary>
		protected RMethod r_DrawNotification;
		public virtual RMethod RDrawNotification
		{
			get
			{
				if(r_DrawNotification == null)
				{
					r_DrawNotification = new(this, "DrawNotification", 0);
					r_DrawNotification.SetBelong(this.instance);
				}
				return r_DrawNotification;
			}
		}

		/// <summary>
		/// Void OnMaximized()
		/// </summary>
		protected RMethod r_OnMaximized;
		public virtual RMethod ROnMaximized
		{
			get
			{
				if(r_OnMaximized == null)
				{
					r_OnMaximized = new(this, "OnMaximized", 0);
					r_OnMaximized.SetBelong(this.instance);
				}
				return r_OnMaximized;
			}
		}

		/// <summary>
		/// Boolean CanMaximize()
		/// </summary>
		protected RMethod r_CanMaximize;
		public virtual RMethod RCanMaximize
		{
			get
			{
				if(r_CanMaximize == null)
				{
					r_CanMaximize = new(this, "CanMaximize", 0);
					r_CanMaximize.SetBelong(this.instance);
				}
				return r_CanMaximize;
			}
		}

		/// <summary>
		/// Int32 GetNumTabs()
		/// </summary>
		protected RMethod r_GetNumTabs;
		public virtual RMethod RGetNumTabs
		{
			get
			{
				if(r_GetNumTabs == null)
				{
					r_GetNumTabs = new(this, "GetNumTabs", 0);
					r_GetNumTabs.SetBelong(this.instance);
				}
				return r_GetNumTabs;
			}
		}

		/// <summary>
		/// Boolean ShowNextTabIfPossible()
		/// </summary>
		protected RMethod r_ShowNextTabIfPossible;
		public virtual RMethod RShowNextTabIfPossible
		{
			get
			{
				if(r_ShowNextTabIfPossible == null)
				{
					r_ShowNextTabIfPossible = new(this, "ShowNextTabIfPossible", 0);
					r_ShowNextTabIfPossible.SetBelong(this.instance);
				}
				return r_ShowNextTabIfPossible;
			}
		}

		/// <summary>
		/// Void ShowTab()
		/// </summary>
		protected RMethod r_ShowTab;
		public virtual RMethod RShowTab
		{
			get
			{
				if(r_ShowTab == null)
				{
					r_ShowTab = new(this, "ShowTab", 0);
					r_ShowTab.SetBelong(this.instance);
				}
				return r_ShowTab;
			}
		}

		/// <summary>
		/// Boolean IsSelectedTab()
		/// </summary>
		protected RMethod r_IsSelectedTab;
		public virtual RMethod RIsSelectedTab
		{
			get
			{
				if(r_IsSelectedTab == null)
				{
					r_IsSelectedTab = new(this, "IsSelectedTab", 0);
					r_IsSelectedTab.SetBelong(this.instance);
				}
				return r_IsSelectedTab;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_Focus;
		public virtual RMethod RFocus
		{
			get
			{
				if(r_Focus == null)
				{
					r_Focus = new(this, "Focus", 0);
					r_Focus.SetBelong(this.instance);
				}
				return r_Focus;
			}
		}

		/// <summary>
		/// Void MakeParentsSettingsMatchMe()
		/// </summary>
		protected RMethod r_MakeParentsSettingsMatchMe;
		public virtual RMethod RMakeParentsSettingsMatchMe
		{
			get
			{
				if(r_MakeParentsSettingsMatchMe == null)
				{
					r_MakeParentsSettingsMatchMe = new(this, "MakeParentsSettingsMatchMe", 0);
					r_MakeParentsSettingsMatchMe.SetBelong(this.instance);
				}
				return r_MakeParentsSettingsMatchMe;
			}
		}

		/// <summary>
		/// Void ShowUtility()
		/// </summary>
		protected RMethod r_ShowUtility;
		public virtual RMethod RShowUtility
		{
			get
			{
				if(r_ShowUtility == null)
				{
					r_ShowUtility = new(this, "ShowUtility", 0);
					r_ShowUtility.SetBelong(this.instance);
				}
				return r_ShowUtility;
			}
		}

		/// <summary>
		/// Void ShowTooltip()
		/// </summary>
		protected RMethod r_ShowTooltip;
		public virtual RMethod RShowTooltip
		{
			get
			{
				if(r_ShowTooltip == null)
				{
					r_ShowTooltip = new(this, "ShowTooltip", 0);
					r_ShowTooltip.SetBelong(this.instance);
				}
				return r_ShowTooltip;
			}
		}

		/// <summary>
		/// Void ShowPopup()
		/// </summary>
		protected RMethod r_ShowPopup;
		public virtual RMethod RShowPopup
		{
			get
			{
				if(r_ShowPopup == null)
				{
					r_ShowPopup = new(this, "ShowPopup", 0);
					r_ShowPopup.SetBelong(this.instance);
				}
				return r_ShowPopup;
			}
		}

		/// <summary>
		/// Void ShowModalUtility()
		/// </summary>
		protected RMethod r_ShowModalUtility;
		public virtual RMethod RShowModalUtility
		{
			get
			{
				if(r_ShowModalUtility == null)
				{
					r_ShowModalUtility = new(this, "ShowModalUtility", 0);
					r_ShowModalUtility.SetBelong(this.instance);
				}
				return r_ShowModalUtility;
			}
		}

		/// <summary>
		/// Void ShowPopupWithMode(UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_ShowPopupWithMode_ShowMode_Boolean;
		public virtual RMethod RShowPopupWithMode_ShowMode_Boolean
		{
			get
			{
				if(r_ShowPopupWithMode_ShowMode_Boolean == null)
				{
					r_ShowPopupWithMode_ShowMode_Boolean = new(this, "ShowPopupWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_ShowPopupWithMode_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_ShowPopupWithMode_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// Void ShowWithMode(UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_ShowWithMode_ShowMode;
		public virtual RMethod RShowWithMode_ShowMode
		{
			get
			{
				if(r_ShowWithMode_ShowMode == null)
				{
					r_ShowWithMode_ShowMode = new(this, "ShowWithMode", 0,  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_ShowWithMode_ShowMode.SetBelong(this.instance);
				}
				return r_ShowWithMode_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2;
		public virtual RMethod RShowAsDropDown_Rect_Vector2
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2 == null)
				{
					r_ShowAsDropDown_Rect_Vector2 = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_ShowAsDropDown_Rect_Vector2.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2_PopupLocationArray == null)
				{
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode)
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode == null)
				{
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReleactionUtils.GetType("UnityEditor.ShowMode"));
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode;
			}
		}

		/// <summary>
		/// Void ShowAsDropDown(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[], UnityEditor.ShowMode, Boolean)
		/// </summary>
		protected RMethod r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
		public virtual RMethod RShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean
		{
			get
			{
				if(r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean == null)
				{
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean = new(this, "ShowAsDropDown", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType(),  ReleactionUtils.GetType("UnityEditor.ShowMode"), typeof(System.Boolean));
					r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean.SetBelong(this.instance);
				}
				return r_ShowAsDropDown_Rect_Vector2_PopupLocationArray_ShowMode_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ShowAsDropDownFitToScreen(UnityEngine.Rect, UnityEngine.Vector2, UnityEditor.PopupLocation[])
		/// </summary>
		protected RMethod r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
		public virtual RMethod RShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray
		{
			get
			{
				if(r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray == null)
				{
					r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray = new(this, "ShowAsDropDownFitToScreen", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.PopupLocation").MakeArrayType());
					r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray.SetBelong(this.instance);
				}
				return r_ShowAsDropDownFitToScreen_Rect_Vector2_PopupLocationArray;
			}
		}

		/// <summary>
		/// Void Show()
		/// </summary>
		protected RMethod r_Show;
		public virtual RMethod RShow
		{
			get
			{
				if(r_Show == null)
				{
					r_Show = new(this, "Show", 0);
					r_Show.SetBelong(this.instance);
				}
				return r_Show;
			}
		}

		/// <summary>
		/// Void Show(Boolean)
		/// </summary>
		protected RMethod r_Show_Boolean;
		public virtual RMethod RShow_Boolean
		{
			get
			{
				if(r_Show_Boolean == null)
				{
					r_Show_Boolean = new(this, "Show", 0, typeof(System.Boolean));
					r_Show_Boolean.SetBelong(this.instance);
				}
				return r_Show_Boolean;
			}
		}

		/// <summary>
		/// Void ShowAuxWindow()
		/// </summary>
		protected RMethod r_ShowAuxWindow;
		public virtual RMethod RShowAuxWindow
		{
			get
			{
				if(r_ShowAuxWindow == null)
				{
					r_ShowAuxWindow = new(this, "ShowAuxWindow", 0);
					r_ShowAuxWindow.SetBelong(this.instance);
				}
				return r_ShowAuxWindow;
			}
		}

		/// <summary>
		/// Void ShowModal()
		/// </summary>
		protected RMethod r_ShowModal;
		public virtual RMethod RShowModal
		{
			get
			{
				if(r_ShowModal == null)
				{
					r_ShowModal = new(this, "ShowModal", 0);
					r_ShowModal.SetBelong(this.instance);
				}
				return r_ShowModal;
			}
		}

		/// <summary>
		/// Void RemoveFromDockArea()
		/// </summary>
		protected RMethod r_RemoveFromDockArea;
		public virtual RMethod RRemoveFromDockArea
		{
			get
			{
				if(r_RemoveFromDockArea == null)
				{
					r_RemoveFromDockArea = new(this, "RemoveFromDockArea", 0);
					r_RemoveFromDockArea.SetBelong(this.instance);
				}
				return r_RemoveFromDockArea;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_Close;
		public virtual RMethod RClose
		{
			get
			{
				if(r_Close == null)
				{
					r_Close = new(this, "Close", 0);
					r_Close.SetBelong(this.instance);
				}
				return r_Close;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_Repaint;
		public virtual RMethod RRepaint
		{
			get
			{
				if(r_Repaint == null)
				{
					r_Repaint = new(this, "Repaint", 0);
					r_Repaint.SetBelong(this.instance);
				}
				return r_Repaint;
			}
		}

		/// <summary>
		/// Void RepaintImmediately()
		/// </summary>
		protected RMethod r_RepaintImmediately;
		public virtual RMethod RRepaintImmediately
		{
			get
			{
				if(r_RepaintImmediately == null)
				{
					r_RepaintImmediately = new(this, "RepaintImmediately", 0);
					r_RepaintImmediately.SetBelong(this.instance);
				}
				return r_RepaintImmediately;
			}
		}

		/// <summary>
		/// Void SetParentGameViewDimensions(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetParentGameViewDimensions_Rect_Rect_Vector2;
		public virtual RMethod RSetParentGameViewDimensions_Rect_Rect_Vector2
		{
			get
			{
				if(r_SetParentGameViewDimensions_Rect_Rect_Vector2 == null)
				{
					r_SetParentGameViewDimensions_Rect_Rect_Vector2 = new(this, "SetParentGameViewDimensions", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_SetParentGameViewDimensions_Rect_Rect_Vector2.SetBelong(this.instance);
				}
				return r_SetParentGameViewDimensions_Rect_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void SetPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetPlayModeViewSize_Vector2;
		public virtual RMethod RSetPlayModeViewSize_Vector2
		{
			get
			{
				if(r_SetPlayModeViewSize_Vector2 == null)
				{
					r_SetPlayModeViewSize_Vector2 = new(this, "SetPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_SetPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_SetPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetMainPlayModeViewSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetMainPlayModeViewSize_Vector2;
		public virtual RMethod RSetMainPlayModeViewSize_Vector2
		{
			get
			{
				if(r_SetMainPlayModeViewSize_Vector2 == null)
				{
					r_SetMainPlayModeViewSize_Vector2 = new(this, "SetMainPlayModeViewSize", 0, typeof(UnityEngine.Vector2));
					r_SetMainPlayModeViewSize_Vector2.SetBelong(this.instance);
				}
				return r_SetMainPlayModeViewSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetDisplayViewSize(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetDisplayViewSize_Int32_Vector2;
		public virtual RMethod RSetDisplayViewSize_Int32_Vector2
		{
			get
			{
				if(r_SetDisplayViewSize_Int32_Vector2 == null)
				{
					r_SetDisplayViewSize_Int32_Vector2 = new(this, "SetDisplayViewSize", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_SetDisplayViewSize_Int32_Vector2.SetBelong(this.instance);
				}
				return r_SetDisplayViewSize_Int32_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetDisplayViewSize(Int32)
		/// </summary>
		protected RMethod r_GetDisplayViewSize_Int32;
		public virtual RMethod RGetDisplayViewSize_Int32
		{
			get
			{
				if(r_GetDisplayViewSize_Int32 == null)
				{
					r_GetDisplayViewSize_Int32 = new(this, "GetDisplayViewSize", 0, typeof(System.Int32));
					r_GetDisplayViewSize_Int32.SetBelong(this.instance);
				}
				return r_GetDisplayViewSize_Int32;
			}
		}

		/// <summary>
		/// Void SetPlayModeView(Boolean)
		/// </summary>
		protected RMethod r_SetPlayModeView_Boolean;
		public virtual RMethod RSetPlayModeView_Boolean
		{
			get
			{
				if(r_SetPlayModeView_Boolean == null)
				{
					r_SetPlayModeView_Boolean = new(this, "SetPlayModeView", 0, typeof(System.Boolean));
					r_SetPlayModeView_Boolean.SetBelong(this.instance);
				}
				return r_SetPlayModeView_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_SendEvent_Event;
		public virtual RMethod RSendEvent_Event
		{
			get
			{
				if(r_SendEvent_Event == null)
				{
					r_SendEvent_Event = new(this, "SendEvent", 0, typeof(UnityEngine.Event));
					r_SendEvent_Event.SetBelong(this.instance);
				}
				return r_SendEvent_Event;
			}
		}

		/// <summary>
		/// Void AddSceneTab()
		/// </summary>
		protected RMethod r_AddSceneTab;
		public virtual RMethod RAddSceneTab
		{
			get
			{
				if(r_AddSceneTab == null)
				{
					r_AddSceneTab = new(this, "AddSceneTab", 0);
					r_AddSceneTab.SetBelong(this.instance);
				}
				return r_AddSceneTab;
			}
		}

		/// <summary>
		/// Void AddGameTab()
		/// </summary>
		protected RMethod r_AddGameTab;
		public virtual RMethod RAddGameTab
		{
			get
			{
				if(r_AddGameTab == null)
				{
					r_AddGameTab = new(this, "AddGameTab", 0);
					r_AddGameTab.SetBelong(this.instance);
				}
				return r_AddGameTab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] GetExtraPaneTypes()
		/// </summary>
		protected RMethod r_GetExtraPaneTypes;
		public virtual RMethod RGetExtraPaneTypes
		{
			get
			{
				if(r_GetExtraPaneTypes == null)
				{
					r_GetExtraPaneTypes = new(this, "GetExtraPaneTypes", 0);
					r_GetExtraPaneTypes.SetBelong(this.instance);
				}
				return r_GetExtraPaneTypes;
			}
		}

		/// <summary>
		/// Boolean TryGetOverlay(System.String, UnityEditor.Overlays.Overlay ByRef)
		/// </summary>
		protected RMethod r_TryGetOverlay_String_Out_Overlay;
		public virtual RMethod RTryGetOverlay_String_Out_Overlay
		{
			get
			{
				if(r_TryGetOverlay_String_Out_Overlay == null)
				{
					r_TryGetOverlay_String_Out_Overlay = new(this, "TryGetOverlay", 0, typeof(System.String), typeof(UnityEditor.Overlays.Overlay).MakeByRefType());
					r_TryGetOverlay_String_Out_Overlay.SetBelong(this.instance);
				}
				return r_TryGetOverlay_String_Out_Overlay;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChangedInternal()
		/// </summary>
		protected RMethod r_OnBackingScaleFactorChangedInternal;
		public virtual RMethod ROnBackingScaleFactorChangedInternal
		{
			get
			{
				if(r_OnBackingScaleFactorChangedInternal == null)
				{
					r_OnBackingScaleFactorChangedInternal = new(this, "OnBackingScaleFactorChangedInternal", 0);
					r_OnBackingScaleFactorChangedInternal.SetBelong(this.instance);
				}
				return r_OnBackingScaleFactorChangedInternal;
			}
		}

		/// <summary>
		/// Void OnBackingScaleFactorChanged()
		/// </summary>
		protected RMethod r_OnBackingScaleFactorChanged;
		public virtual RMethod ROnBackingScaleFactorChanged
		{
			get
			{
				if(r_OnBackingScaleFactorChanged == null)
				{
					r_OnBackingScaleFactorChanged = new(this, "OnBackingScaleFactorChanged", 0);
					r_OnBackingScaleFactorChanged.SetBelong(this.instance);
				}
				return r_OnBackingScaleFactorChanged;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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


        public virtual void __0__AddItemsToMenu__1__b__25_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__AddItemsToMenu__1__b__25_0.Invoke(___genericsType, ___parameters);

            
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
