using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BaseRuntimePanel
	/// </summary>
    public partial class RBaseRuntimePanel : RMember //
    {

		/// <summary>
		/// UnityEngine.GameObject m_SelectableGameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_m_SelectableGameObject;
		public virtual RUnityEngine.RGameObject Rm_SelectableGameObject
		{
			get
			{
				if(r_m_SelectableGameObject == null)
				{
					r_m_SelectableGameObject = new(this, "m_SelectableGameObject");
					r_m_SelectableGameObject.SetBelong(this.instance);
				}
				return r_m_SelectableGameObject;
			}
		}

		/// <summary>
		/// System.Int32 s_CurrentRuntimePanelCounter
		/// </summary>
		protected static RField r_s_CurrentRuntimePanelCounter;
		public static RField Rs_CurrentRuntimePanelCounter
		{
			get
			{
				if(r_s_CurrentRuntimePanelCounter == null)
				{
					r_s_CurrentRuntimePanelCounter = new( ReleactionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"), "s_CurrentRuntimePanelCounter");
					r_s_CurrentRuntimePanelCounter.SetBelong(null);
				}
				return r_s_CurrentRuntimePanelCounter;
			}
		}

		/// <summary>
		/// System.Int32 m_RuntimePanelCreationIndex
		/// </summary>
		protected RField r_m_RuntimePanelCreationIndex;
		public virtual RField Rm_RuntimePanelCreationIndex
		{
			get
			{
				if(r_m_RuntimePanelCreationIndex == null)
				{
					r_m_RuntimePanelCreationIndex = new(this, "m_RuntimePanelCreationIndex");
					r_m_RuntimePanelCreationIndex.SetBelong(this.instance);
				}
				return r_m_RuntimePanelCreationIndex;
			}
		}

		/// <summary>
		/// System.Single m_SortingPriority
		/// </summary>
		protected RField r_m_SortingPriority;
		public virtual RField Rm_SortingPriority
		{
			get
			{
				if(r_m_SortingPriority == null)
				{
					r_m_SortingPriority = new(this, "m_SortingPriority");
					r_m_SortingPriority.SetBelong(this.instance);
				}
				return r_m_SortingPriority;
			}
		}

		/// <summary>
		/// System.Int32 resolvedSortingIndex
		/// </summary>
		protected RField r_resolvedSortingIndex;
		public virtual RField RresolvedSortingIndex
		{
			get
			{
				if(r_resolvedSortingIndex == null)
				{
					r_resolvedSortingIndex = new(this, "resolvedSortingIndex");
					r_resolvedSortingIndex.SetBelong(this.instance);
				}
				return r_resolvedSortingIndex;
			}
		}

		/// <summary>
		/// System.Action destroyed
		/// </summary>
		protected RSystem.RAction r_destroyed;
		public virtual RSystem.RAction Rdestroyed
		{
			get
			{
				if(r_destroyed == null)
				{
					r_destroyed = new(this, "destroyed");
					r_destroyed.SetBelong(this.instance);
				}
				return r_destroyed;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_StandardWorldSpaceShader
		/// </summary>
		protected RUnityEngine.RShader r_m_StandardWorldSpaceShader;
		public virtual RUnityEngine.RShader Rm_StandardWorldSpaceShader
		{
			get
			{
				if(r_m_StandardWorldSpaceShader == null)
				{
					r_m_StandardWorldSpaceShader = new(this, "m_StandardWorldSpaceShader");
					r_m_StandardWorldSpaceShader.SetBelong(this.instance);
				}
				return r_m_StandardWorldSpaceShader;
			}
		}

		/// <summary>
		/// System.Boolean m_DrawToCameras
		/// </summary>
		protected RField r_m_DrawToCameras;
		public virtual RField Rm_DrawToCameras
		{
			get
			{
				if(r_m_DrawToCameras == null)
				{
					r_m_DrawToCameras = new(this, "m_DrawToCameras");
					r_m_DrawToCameras.SetBelong(this.instance);
				}
				return r_m_DrawToCameras;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture targetTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_targetTexture;
		public virtual RUnityEngine.RRenderTexture RtargetTexture
		{
			get
			{
				if(r_targetTexture == null)
				{
					r_targetTexture = new(this, "targetTexture");
					r_targetTexture.SetBelong(this.instance);
				}
				return r_targetTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 panelToWorld
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_panelToWorld;
		public virtual RUnityEngine.RMatrix4x4 RpanelToWorld
		{
			get
			{
				if(r_panelToWorld == null)
				{
					r_panelToWorld = new(this, "panelToWorld");
					r_panelToWorld.SetBelong(this.instance);
				}
				return r_panelToWorld;
			}
		}

		/// <summary>
		/// System.Int32 <targetDisplay>k__BackingField
		/// </summary>
		protected RField r___1__targetDisplay__2__k__BackingField;
		public virtual RField R__1__targetDisplay__2__k__BackingField
		{
			get
			{
				if(r___1__targetDisplay__2__k__BackingField == null)
				{
					r___1__targetDisplay__2__k__BackingField = new(this, "<targetDisplay>k__BackingField");
					r___1__targetDisplay__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__targetDisplay__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Vector2,UnityEngine.Vector2] DefaultScreenToPanelSpace
		/// </summary>
		protected static RSystem.RFunc<RUnityEngine.RVector2, RUnityEngine.RVector2> r_DefaultScreenToPanelSpace;
		public static RSystem.RFunc<RUnityEngine.RVector2, RUnityEngine.RVector2> RDefaultScreenToPanelSpace
		{
			get
			{
				if(r_DefaultScreenToPanelSpace == null)
				{
					r_DefaultScreenToPanelSpace = new( ReleactionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"), "DefaultScreenToPanelSpace");
					r_DefaultScreenToPanelSpace.SetBelong(null);
				}
				return r_DefaultScreenToPanelSpace;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Vector2,UnityEngine.Vector2] m_ScreenToPanelSpace
		/// </summary>
		protected RSystem.RFunc<RUnityEngine.RVector2, RUnityEngine.RVector2> r_m_ScreenToPanelSpace;
		public virtual RSystem.RFunc<RUnityEngine.RVector2, RUnityEngine.RVector2> Rm_ScreenToPanelSpace
		{
			get
			{
				if(r_m_ScreenToPanelSpace == null)
				{
					r_m_ScreenToPanelSpace = new(this, "m_ScreenToPanelSpace");
					r_m_ScreenToPanelSpace.SetBelong(this.instance);
				}
				return r_m_ScreenToPanelSpace;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig yogaConfig
		/// </summary>
		protected RUnityEngine.RYoga.RYogaConfig r_yogaConfig;
		public virtual RUnityEngine.RYoga.RYogaConfig RyogaConfig
		{
			get
			{
				if(r_yogaConfig == null)
				{
					r_yogaConfig = new(this, "yogaConfig");
					r_yogaConfig.SetBelong(this.instance);
				}
				return r_yogaConfig;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ElementUnderPointer m_TopElementUnderPointers
		/// </summary>
		protected RUnityEngine.RUIElements.RElementUnderPointer r_m_TopElementUnderPointers;
		public virtual RUnityEngine.RUIElements.RElementUnderPointer Rm_TopElementUnderPointers
		{
			get
			{
				if(r_m_TopElementUnderPointers == null)
				{
					r_m_TopElementUnderPointers = new(this, "m_TopElementUnderPointers");
					r_m_TopElementUnderPointers.SetBelong(this.instance);
				}
				return r_m_TopElementUnderPointers;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject selectableGameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_selectableGameObject;
		public virtual RUnityEngine.RGameObject RselectableGameObject
		{
			get
			{
				if(r_selectableGameObject == null)
				{
					r_selectableGameObject = new(this, "selectableGameObject", -1);
					r_selectableGameObject.SetBelong(this.instance);
				}
				return r_selectableGameObject;
			}
		}

		/// <summary>
		/// Single sortingPriority
		/// </summary>
		protected RProperty r_sortingPriority;
		public virtual RProperty RsortingPriority
		{
			get
			{
				if(r_sortingPriority == null)
				{
					r_sortingPriority = new(this, "sortingPriority", -1);
					r_sortingPriority.SetBelong(this.instance);
				}
				return r_sortingPriority;
			}
		}

		/// <summary>
		/// UnityEngine.Shader standardWorldSpaceShader
		/// </summary>
		protected RUnityEngine.RShader r_standardWorldSpaceShader;
		public virtual RUnityEngine.RShader RstandardWorldSpaceShader
		{
			get
			{
				if(r_standardWorldSpaceShader == null)
				{
					r_standardWorldSpaceShader = new(this, "standardWorldSpaceShader", -1);
					r_standardWorldSpaceShader.SetBelong(this.instance);
				}
				return r_standardWorldSpaceShader;
			}
		}

		/// <summary>
		/// Boolean drawToCameras
		/// </summary>
		protected RProperty r_drawToCameras;
		public virtual RProperty RdrawToCameras
		{
			get
			{
				if(r_drawToCameras == null)
				{
					r_drawToCameras = new(this, "drawToCameras", -1);
					r_drawToCameras.SetBelong(this.instance);
				}
				return r_drawToCameras;
			}
		}

		/// <summary>
		/// Int32 targetDisplay
		/// </summary>
		protected RProperty r_targetDisplay;
		public virtual RProperty RtargetDisplay
		{
			get
			{
				if(r_targetDisplay == null)
				{
					r_targetDisplay = new(this, "targetDisplay", -1);
					r_targetDisplay.SetBelong(this.instance);
				}
				return r_targetDisplay;
			}
		}

		/// <summary>
		/// Int32 screenRenderingWidth
		/// </summary>
		protected RProperty r_screenRenderingWidth;
		public virtual RProperty RscreenRenderingWidth
		{
			get
			{
				if(r_screenRenderingWidth == null)
				{
					r_screenRenderingWidth = new(this, "screenRenderingWidth", -1);
					r_screenRenderingWidth.SetBelong(this.instance);
				}
				return r_screenRenderingWidth;
			}
		}

		/// <summary>
		/// Int32 screenRenderingHeight
		/// </summary>
		protected RProperty r_screenRenderingHeight;
		public virtual RProperty RscreenRenderingHeight
		{
			get
			{
				if(r_screenRenderingHeight == null)
				{
					r_screenRenderingHeight = new(this, "screenRenderingHeight", -1);
					r_screenRenderingHeight.SetBelong(this.instance);
				}
				return r_screenRenderingHeight;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Vector2,UnityEngine.Vector2] screenToPanelSpace
		/// </summary>
		protected RSystem.RFunc<RUnityEngine.RVector2, RUnityEngine.RVector2> r_screenToPanelSpace;
		public virtual RSystem.RFunc<RUnityEngine.RVector2, RUnityEngine.RVector2> RscreenToPanelSpace
		{
			get
			{
				if(r_screenToPanelSpace == null)
				{
					r_screenToPanelSpace = new(this, "screenToPanelSpace", -1);
					r_screenToPanelSpace.SetBelong(this.instance);
				}
				return r_screenToPanelSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_visualTree;
		public virtual RUnityEngine.RUIElements.RVisualElement RvisualTree
		{
			get
			{
				if(r_visualTree == null)
				{
					r_visualTree = new(this, "visualTree", -1);
					r_visualTree.SetBelong(this.instance);
				}
				return r_visualTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher dispatcher
		/// </summary>
		protected RUnityEngine.RUIElements.REventDispatcher r_dispatcher;
		public virtual RUnityEngine.RUIElements.REventDispatcher Rdispatcher
		{
			get
			{
				if(r_dispatcher == null)
				{
					r_dispatcher = new(this, "dispatcher", -1);
					r_dispatcher.SetBelong(this.instance);
				}
				return r_dispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimerEventScheduler timerEventScheduler
		/// </summary>
		protected RUnityEngine.RUIElements.RTimerEventScheduler r_timerEventScheduler;
		public virtual RUnityEngine.RUIElements.RTimerEventScheduler RtimerEventScheduler
		{
			get
			{
				if(r_timerEventScheduler == null)
				{
					r_timerEventScheduler = new(this, "timerEventScheduler", -1);
					r_timerEventScheduler.SetBelong(this.instance);
				}
				return r_timerEventScheduler;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IScheduler scheduler
		/// </summary>
		protected RUnityEngine.RUIElements.RIScheduler r_scheduler;
		public virtual RUnityEngine.RUIElements.RIScheduler Rscheduler
		{
			get
			{
				if(r_scheduler == null)
				{
					r_scheduler = new(this, "scheduler", -1);
					r_scheduler.SetBelong(this.instance);
				}
				return r_scheduler;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeUpdater visualTreeUpdater
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeUpdater r_visualTreeUpdater;
		public virtual RUnityEngine.RUIElements.RVisualTreeUpdater RvisualTreeUpdater
		{
			get
			{
				if(r_visualTreeUpdater == null)
				{
					r_visualTreeUpdater = new(this, "visualTreeUpdater", -1);
					r_visualTreeUpdater.SetBelong(this.instance);
				}
				return r_visualTreeUpdater;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimationSystem styleAnimationSystem
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePropertyAnimationSystem r_styleAnimationSystem;
		public virtual RUnityEngine.RUIElements.RIStylePropertyAnimationSystem RstyleAnimationSystem
		{
			get
			{
				if(r_styleAnimationSystem == null)
				{
					r_styleAnimationSystem = new(this, "styleAnimationSystem", -1);
					r_styleAnimationSystem.SetBelong(this.instance);
				}
				return r_styleAnimationSystem;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject ownerObject
		/// </summary>
		protected RUnityEngine.RScriptableObject r_ownerObject;
		public virtual RUnityEngine.RScriptableObject RownerObject
		{
			get
			{
				if(r_ownerObject == null)
				{
					r_ownerObject = new(this, "ownerObject", -1);
					r_ownerObject.SetBelong(this.instance);
				}
				return r_ownerObject;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType contextType
		/// </summary>
		protected RProperty r_contextType;
		public virtual RProperty RcontextType
		{
			get
			{
				if(r_contextType == null)
				{
					r_contextType = new(this, "contextType", -1);
					r_contextType.SetBelong(this.instance);
				}
				return r_contextType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.SavePersistentViewData saveViewData
		/// </summary>
		protected RUnityEngine.RUIElements.RSavePersistentViewData r_saveViewData;
		public virtual RUnityEngine.RUIElements.RSavePersistentViewData RsaveViewData
		{
			get
			{
				if(r_saveViewData == null)
				{
					r_saveViewData = new(this, "saveViewData", -1);
					r_saveViewData.SetBelong(this.instance);
				}
				return r_saveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.GetViewDataDictionary getViewDataDictionary
		/// </summary>
		protected RUnityEngine.RUIElements.RGetViewDataDictionary r_getViewDataDictionary;
		public virtual RUnityEngine.RUIElements.RGetViewDataDictionary RgetViewDataDictionary
		{
			get
			{
				if(r_getViewDataDictionary == null)
				{
					r_getViewDataDictionary = new(this, "getViewDataDictionary", -1);
					r_getViewDataDictionary.SetBelong(this.instance);
				}
				return r_getViewDataDictionary;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_focusController;
		public virtual RUnityEngine.RUIElements.RFocusController RfocusController
		{
			get
			{
				if(r_focusController == null)
				{
					r_focusController = new(this, "focusController", -1);
					r_focusController.SetBelong(this.instance);
				}
				return r_focusController;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests IMGUIEventInterests
		/// </summary>
		protected RUnityEngine.REventInterests r_IMGUIEventInterests;
		public virtual RUnityEngine.REventInterests RIMGUIEventInterests
		{
			get
			{
				if(r_IMGUIEventInterests == null)
				{
					r_IMGUIEventInterests = new(this, "IMGUIEventInterests", -1);
					r_IMGUIEventInterests.SetBelong(this.instance);
				}
				return r_IMGUIEventInterests;
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
		/// Int32 IMGUIContainersCount
		/// </summary>
		protected RProperty r_IMGUIContainersCount;
		public virtual RProperty RIMGUIContainersCount
		{
			get
			{
				if(r_IMGUIContainersCount == null)
				{
					r_IMGUIContainersCount = new(this, "IMGUIContainersCount", -1);
					r_IMGUIContainersCount.SetBelong(this.instance);
				}
				return r_IMGUIContainersCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer rootIMGUIContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RIMGUIContainer r_rootIMGUIContainer;
		public virtual RUnityEngine.RUIElements.RIMGUIContainer RrootIMGUIContainer
		{
			get
			{
				if(r_rootIMGUIContainer == null)
				{
					r_rootIMGUIContainer = new(this, "rootIMGUIContainer", -1);
					r_rootIMGUIContainer.SetBelong(this.instance);
				}
				return r_rootIMGUIContainer;
			}
		}

		/// <summary>
		/// UInt32 version
		/// </summary>
		protected RProperty r_version;
		public virtual RProperty Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version", -1);
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// UInt32 repaintVersion
		/// </summary>
		protected RProperty r_repaintVersion;
		public virtual RProperty RrepaintVersion
		{
			get
			{
				if(r_repaintVersion == null)
				{
					r_repaintVersion = new(this, "repaintVersion", -1);
					r_repaintVersion.SetBelong(this.instance);
				}
				return r_repaintVersion;
			}
		}

		/// <summary>
		/// UInt32 hierarchyVersion
		/// </summary>
		protected RProperty r_hierarchyVersion;
		public virtual RProperty RhierarchyVersion
		{
			get
			{
				if(r_hierarchyVersion == null)
				{
					r_hierarchyVersion = new(this, "hierarchyVersion", -1);
					r_hierarchyVersion.SetBelong(this.instance);
				}
				return r_hierarchyVersion;
			}
		}

		/// <summary>
		/// UnityEngine.Shader standardShader
		/// </summary>
		protected RUnityEngine.RShader r_standardShader;
		public virtual RUnityEngine.RShader RstandardShader
		{
			get
			{
				if(r_standardShader == null)
				{
					r_standardShader = new(this, "standardShader", -1);
					r_standardShader.SetBelong(this.instance);
				}
				return r_standardShader;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase atlas
		/// </summary>
		protected RUnityEngine.RUIElements.RAtlasBase r_atlas;
		public virtual RUnityEngine.RUIElements.RAtlasBase Ratlas
		{
			get
			{
				if(r_atlas == null)
				{
					r_atlas = new(this, "atlas", -1);
					r_atlas.SetBelong(this.instance);
				}
				return r_atlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIElementsBridge uiElementsBridge
		/// </summary>
		protected RUnityEngine.RUIElements.RUIElementsBridge r_uiElementsBridge;
		public virtual RUnityEngine.RUIElements.RUIElementsBridge RuiElementsBridge
		{
			get
			{
				if(r_uiElementsBridge == null)
				{
					r_uiElementsBridge = new(this, "uiElementsBridge", -1);
					r_uiElementsBridge.SetBelong(this.instance);
				}
				return r_uiElementsBridge;
			}
		}

		/// <summary>
		/// Boolean enableAssetReload
		/// </summary>
		protected RProperty r_enableAssetReload;
		public virtual RProperty RenableAssetReload
		{
			get
			{
				if(r_enableAssetReload == null)
				{
					r_enableAssetReload = new(this, "enableAssetReload", -1);
					r_enableAssetReload.SetBelong(this.instance);
				}
				return r_enableAssetReload;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected RProperty r_scale;
		public virtual RProperty Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale", -1);
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// Single pixelsPerPoint
		/// </summary>
		protected RProperty r_pixelsPerPoint;
		public virtual RProperty RpixelsPerPoint
		{
			get
			{
				if(r_pixelsPerPoint == null)
				{
					r_pixelsPerPoint = new(this, "pixelsPerPoint", -1);
					r_pixelsPerPoint.SetBelong(this.instance);
				}
				return r_pixelsPerPoint;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected RProperty r_scaledPixelsPerPoint;
		public virtual RProperty RscaledPixelsPerPoint
		{
			get
			{
				if(r_scaledPixelsPerPoint == null)
				{
					r_scaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_scaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_scaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// Single referenceSpritePixelsPerUnit
		/// </summary>
		protected RProperty r_referenceSpritePixelsPerUnit;
		public virtual RProperty RreferenceSpritePixelsPerUnit
		{
			get
			{
				if(r_referenceSpritePixelsPerUnit == null)
				{
					r_referenceSpritePixelsPerUnit = new(this, "referenceSpritePixelsPerUnit", -1);
					r_referenceSpritePixelsPerUnit.SetBelong(this.instance);
				}
				return r_referenceSpritePixelsPerUnit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PanelClearFlags clearFlags
		/// </summary>
		protected RProperty r_clearFlags;
		public virtual RProperty RclearFlags
		{
			get
			{
				if(r_clearFlags == null)
				{
					r_clearFlags = new(this, "clearFlags", -1);
					r_clearFlags.SetBelong(this.instance);
				}
				return r_clearFlags;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PanelClearSettings clearSettings
		/// </summary>
		protected RUnityEngine.RUIElements.RPanelClearSettings r_clearSettings;
		public virtual RUnityEngine.RUIElements.RPanelClearSettings RclearSettings
		{
			get
			{
				if(r_clearSettings == null)
				{
					r_clearSettings = new(this, "clearSettings", -1);
					r_clearSettings.SetBelong(this.instance);
				}
				return r_clearSettings;
			}
		}

		/// <summary>
		/// Boolean duringLayoutPhase
		/// </summary>
		protected RProperty r_duringLayoutPhase;
		public virtual RProperty RduringLayoutPhase
		{
			get
			{
				if(r_duringLayoutPhase == null)
				{
					r_duringLayoutPhase = new(this, "duringLayoutPhase", -1);
					r_duringLayoutPhase.SetBelong(this.instance);
				}
				return r_duringLayoutPhase;
			}
		}

		/// <summary>
		/// Boolean isDirty
		/// </summary>
		protected RProperty r_isDirty;
		public virtual RProperty RisDirty
		{
			get
			{
				if(r_isDirty == null)
				{
					r_isDirty = new(this, "isDirty", -1);
					r_isDirty.SetBelong(this.instance);
				}
				return r_isDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RepaintData repaintData
		/// </summary>
		protected RUnityEngine.RUIElements.RRepaintData r_repaintData;
		public virtual RUnityEngine.RUIElements.RRepaintData RrepaintData
		{
			get
			{
				if(r_repaintData == null)
				{
					r_repaintData = new(this, "repaintData", -1);
					r_repaintData.SetBelong(this.instance);
				}
				return r_repaintData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICursorManager cursorManager
		/// </summary>
		protected RUnityEngine.RUIElements.RICursorManager r_cursorManager;
		public virtual RUnityEngine.RUIElements.RICursorManager RcursorManager
		{
			get
			{
				if(r_cursorManager == null)
				{
					r_cursorManager = new(this, "cursorManager", -1);
					r_cursorManager.SetBelong(this.instance);
				}
				return r_cursorManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager contextualMenuManager
		/// </summary>
		protected RUnityEngine.RUIElements.RContextualMenuManager r_contextualMenuManager;
		public virtual RUnityEngine.RUIElements.RContextualMenuManager RcontextualMenuManager
		{
			get
			{
				if(r_contextualMenuManager == null)
				{
					r_contextualMenuManager = new(this, "contextualMenuManager", -1);
					r_contextualMenuManager.SetBelong(this.instance);
				}
				return r_contextualMenuManager;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RProperty r_disposed;
		public virtual RProperty Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed", -1);
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug panelDebug
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanelDebug r_panelDebug;
		public virtual RUnityEngine.RUIElements.RIPanelDebug RpanelDebug
		{
			get
			{
				if(r_panelDebug == null)
				{
					r_panelDebug = new(this, "panelDebug", -1);
					r_panelDebug.SetBelong(this.instance);
				}
				return r_panelDebug;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ILiveReloadSystem liveReloadSystem
		/// </summary>
		protected RUnityEngine.RUIElements.RILiveReloadSystem r_liveReloadSystem;
		public virtual RUnityEngine.RUIElements.RILiveReloadSystem RliveReloadSystem
		{
			get
			{
				if(r_liveReloadSystem == null)
				{
					r_liveReloadSystem = new(this, "liveReloadSystem", -1);
					r_liveReloadSystem.SetBelong(this.instance);
				}
				return r_liveReloadSystem;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.BaseVisualElementPanel] panelDisposed
		/// </summary>
		protected REvent r_panelDisposed;
		public virtual REvent RpanelDisposed
		{
			get
			{
				if(r_panelDisposed == null)
				{
					r_panelDisposed = new(this, "panelDisposed");
					r_panelDisposed.SetBelong(this.instance);
				}
				return r_panelDisposed;
			}
		}

		/// <summary>
		/// System.Action standardShaderChanged
		/// </summary>
		protected REvent r_standardShaderChanged;
		public virtual REvent RstandardShaderChanged
		{
			get
			{
				if(r_standardShaderChanged == null)
				{
					r_standardShaderChanged = new(this, "standardShaderChanged");
					r_standardShaderChanged.SetBelong(this.instance);
				}
				return r_standardShaderChanged;
			}
		}

		/// <summary>
		/// System.Action standardWorldSpaceShaderChanged
		/// </summary>
		protected REvent r_standardWorldSpaceShaderChanged;
		public virtual REvent RstandardWorldSpaceShaderChanged
		{
			get
			{
				if(r_standardWorldSpaceShaderChanged == null)
				{
					r_standardWorldSpaceShaderChanged = new(this, "standardWorldSpaceShaderChanged");
					r_standardWorldSpaceShaderChanged.SetBelong(this.instance);
				}
				return r_standardWorldSpaceShaderChanged;
			}
		}

		/// <summary>
		/// System.Action atlasChanged
		/// </summary>
		protected REvent r_atlasChanged;
		public virtual REvent RatlasChanged
		{
			get
			{
				if(r_atlasChanged == null)
				{
					r_atlasChanged = new(this, "atlasChanged");
					r_atlasChanged.SetBelong(this.instance);
				}
				return r_atlasChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Material] updateMaterial
		/// </summary>
		protected REvent r_updateMaterial;
		public virtual REvent RupdateMaterial
		{
			get
			{
				if(r_updateMaterial == null)
				{
					r_updateMaterial = new(this, "updateMaterial");
					r_updateMaterial.SetBelong(this.instance);
				}
				return r_updateMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.HierarchyEvent hierarchyChanged
		/// </summary>
		protected REvent r_hierarchyChanged;
		public virtual REvent RhierarchyChanged
		{
			get
			{
				if(r_hierarchyChanged == null)
				{
					r_hierarchyChanged = new(this, "hierarchyChanged");
					r_hierarchyChanged.SetBelong(this.instance);
				}
				return r_hierarchyChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.IPanel] beforeUpdate
		/// </summary>
		protected REvent r_beforeUpdate;
		public virtual REvent RbeforeUpdate
		{
			get
			{
				if(r_beforeUpdate == null)
				{
					r_beforeUpdate = new(this, "beforeUpdate");
					r_beforeUpdate.SetBelong(this.instance);
				}
				return r_beforeUpdate;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Repaint(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RRepaint_Event;
		public virtual RMethod RRepaint_Event
		{
			get
			{
				if(r_RRepaint_Event == null)
				{
					r_RRepaint_Event = new(this, "Repaint", 0, typeof(UnityEngine.Event));
					r_RRepaint_Event.SetBelong(this.instance);
				}
				return r_RRepaint_Event;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RScreenToPanel_Vector2;
		public virtual RMethod RScreenToPanel_Vector2
		{
			get
			{
				if(r_RScreenToPanel_Vector2 == null)
				{
					r_RScreenToPanel_Vector2 = new(this, "ScreenToPanel", 0, typeof(UnityEngine.Vector2));
					r_RScreenToPanel_Vector2.SetBelong(this.instance);
				}
				return r_RScreenToPanel_Vector2;
			}
		}

		/// <summary>
		/// Boolean ScreenToPanel(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Boolean)
		/// </summary>
		protected RMethod r_RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean;
		public virtual RMethod RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean
		{
			get
			{
				if(r_RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean == null)
				{
					r_RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean = new(this, "ScreenToPanel", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Boolean));
					r_RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean.SetBelong(this.instance);
				}
				return r_RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel)
		/// </summary>
		protected RMethod r_RAssignPanelToComponents_BaseRuntimePanel;
		public virtual RMethod RAssignPanelToComponents_BaseRuntimePanel
		{
			get
			{
				if(r_RAssignPanelToComponents_BaseRuntimePanel == null)
				{
					r_RAssignPanelToComponents_BaseRuntimePanel = new(this, "AssignPanelToComponents", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"));
					r_RAssignPanelToComponents_BaseRuntimePanel.SetBelong(this.instance);
				}
				return r_RAssignPanelToComponents_BaseRuntimePanel;
			}
		}

		/// <summary>
		/// Void PointerLeavesPanel(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RPointerLeavesPanel_Int32_Vector2;
		public virtual RMethod RPointerLeavesPanel_Int32_Vector2
		{
			get
			{
				if(r_RPointerLeavesPanel_Int32_Vector2 == null)
				{
					r_RPointerLeavesPanel_Int32_Vector2 = new(this, "PointerLeavesPanel", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RPointerLeavesPanel_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RPointerLeavesPanel_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void PointerEntersPanel(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RPointerEntersPanel_Int32_Vector2;
		public virtual RMethod RPointerEntersPanel_Int32_Vector2
		{
			get
			{
				if(r_RPointerEntersPanel_Int32_Vector2 == null)
				{
					r_RPointerEntersPanel_Int32_Vector2 = new(this, "PointerEntersPanel", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_RPointerEntersPanel_Int32_Vector2.SetBelong(this.instance);
				}
				return r_RPointerEntersPanel_Int32_Vector2;
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
		/// Void Blur()
		/// </summary>
		protected RMethod r_RBlur;
		public virtual RMethod RBlur
		{
			get
			{
				if(r_RBlur == null)
				{
					r_RBlur = new(this, "Blur", 0);
					r_RBlur.SetBelong(this.instance);
				}
				return r_RBlur;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2, System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RPickAll_Vector2_List_d_VisualElement_p_;
		public virtual RMethod RPickAll_Vector2_List_d_VisualElement_p_
		{
			get
			{
				if(r_RPickAll_Vector2_List_d_VisualElement_p_ == null)
				{
					r_RPickAll_Vector2_List_d_VisualElement_p_ = new(this, "PickAll", 0, typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RPickAll_Vector2_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RPickAll_Vector2_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RPick_Vector2;
		public virtual RMethod RPick_Vector2
		{
			get
			{
				if(r_RPick_Vector2 == null)
				{
					r_RPick_Vector2 = new(this, "Pick", 0, typeof(UnityEngine.Vector2));
					r_RPick_Vector2.SetBelong(this.instance);
				}
				return r_RPick_Vector2;
			}
		}

		/// <summary>
		/// Void ValidateLayout()
		/// </summary>
		protected RMethod r_RValidateLayout;
		public virtual RMethod RValidateLayout
		{
			get
			{
				if(r_RValidateLayout == null)
				{
					r_RValidateLayout = new(this, "ValidateLayout", 0);
					r_RValidateLayout.SetBelong(this.instance);
				}
				return r_RValidateLayout;
			}
		}

		/// <summary>
		/// Void UpdateAnimations()
		/// </summary>
		protected RMethod r_RUpdateAnimations;
		public virtual RMethod RUpdateAnimations
		{
			get
			{
				if(r_RUpdateAnimations == null)
				{
					r_RUpdateAnimations = new(this, "UpdateAnimations", 0);
					r_RUpdateAnimations.SetBelong(this.instance);
				}
				return r_RUpdateAnimations;
			}
		}

		/// <summary>
		/// Void UpdateBindings()
		/// </summary>
		protected RMethod r_RUpdateBindings;
		public virtual RMethod RUpdateBindings
		{
			get
			{
				if(r_RUpdateBindings == null)
				{
					r_RUpdateBindings = new(this, "UpdateBindings", 0);
					r_RUpdateBindings.SetBelong(this.instance);
				}
				return r_RUpdateBindings;
			}
		}

		/// <summary>
		/// Void ApplyStyles()
		/// </summary>
		protected RMethod r_RApplyStyles;
		public virtual RMethod RApplyStyles
		{
			get
			{
				if(r_RApplyStyles == null)
				{
					r_RApplyStyles = new(this, "ApplyStyles", 0);
					r_RApplyStyles.SetBelong(this.instance);
				}
				return r_RApplyStyles;
			}
		}

		/// <summary>
		/// Void UpdateAssetTrackers()
		/// </summary>
		protected RMethod r_RUpdateAssetTrackers;
		public virtual RMethod RUpdateAssetTrackers
		{
			get
			{
				if(r_RUpdateAssetTrackers == null)
				{
					r_RUpdateAssetTrackers = new(this, "UpdateAssetTrackers", 0);
					r_RUpdateAssetTrackers.SetBelong(this.instance);
				}
				return r_RUpdateAssetTrackers;
			}
		}

		/// <summary>
		/// Void UpdateWithoutRepaint()
		/// </summary>
		protected RMethod r_RUpdateWithoutRepaint;
		public virtual RMethod RUpdateWithoutRepaint
		{
			get
			{
				if(r_RUpdateWithoutRepaint == null)
				{
					r_RUpdateWithoutRepaint = new(this, "UpdateWithoutRepaint", 0);
					r_RUpdateWithoutRepaint.SetBelong(this.instance);
				}
				return r_RUpdateWithoutRepaint;
			}
		}

		/// <summary>
		/// Void DirtyStyleSheets()
		/// </summary>
		protected RMethod r_RDirtyStyleSheets;
		public virtual RMethod RDirtyStyleSheets
		{
			get
			{
				if(r_RDirtyStyleSheets == null)
				{
					r_RDirtyStyleSheets = new(this, "DirtyStyleSheets", 0);
					r_RDirtyStyleSheets.SetBelong(this.instance);
				}
				return r_RDirtyStyleSheets;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetEditorUpdater(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_RGetEditorUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RGetEditorUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_RGetEditorUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_RGetEditorUpdater_VisualTreeEditorUpdatePhase = new(this, "GetEditorUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_RGetEditorUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_RGetEditorUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// Void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUpdateInlineStylesRecursively_VisualElement;
		public virtual RMethod RUpdateInlineStylesRecursively_VisualElement
		{
			get
			{
				if(r_RUpdateInlineStylesRecursively_VisualElement == null)
				{
					r_RUpdateInlineStylesRecursively_VisualElement = new(this, "UpdateInlineStylesRecursively", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUpdateInlineStylesRecursively_VisualElement.SetBelong(this.instance);
				}
				return r_RUpdateInlineStylesRecursively_VisualElement;
			}
		}

		/// <summary>
		/// Void RequestUpdateAfterExternalEvent(UnityEngine.UIElements.IVisualTreeUpdater)
		/// </summary>
		protected RMethod r_RRequestUpdateAfterExternalEvent_IVisualTreeUpdater;
		public virtual RMethod RRequestUpdateAfterExternalEvent_IVisualTreeUpdater
		{
			get
			{
				if(r_RRequestUpdateAfterExternalEvent_IVisualTreeUpdater == null)
				{
					r_RRequestUpdateAfterExternalEvent_IVisualTreeUpdater = new(this, "RequestUpdateAfterExternalEvent", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"));
					r_RRequestUpdateAfterExternalEvent_IVisualTreeUpdater.SetBelong(this.instance);
				}
				return r_RRequestUpdateAfterExternalEvent_IVisualTreeUpdater;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_ROnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_ROnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_ROnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_ROnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_ROnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase == null)
				{
					r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase = new(this, "SetUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_RGetUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RGetUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_RGetUpdater_VisualTreeUpdatePhase == null)
				{
					r_RGetUpdater_VisualTreeUpdatePhase = new(this, "GetUpdater", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_RGetUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_RGetUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RSendEvent_EventBase_DispatchMode;
		public virtual RMethod RSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_RSendEvent_EventBase_DispatchMode == null)
				{
					r_RSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RSendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_RSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32)
		/// </summary>
		protected RMethod r_RGetTopElementUnderPointer_Int32;
		public virtual RMethod RGetTopElementUnderPointer_Int32
		{
			get
			{
				if(r_RGetTopElementUnderPointer_Int32 == null)
				{
					r_RGetTopElementUnderPointer_Int32 = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32));
					r_RGetTopElementUnderPointer_Int32.SetBelong(this.instance);
				}
				return r_RGetTopElementUnderPointer_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(Int32, UnityEngine.Vector2, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase;
		public virtual RMethod RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase
		{
			get
			{
				if(r_RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase == null)
				{
					r_RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase = new(this, "RecomputeTopElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.UIElements.EventBase));
					r_RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase.SetBelong(this.instance);
				}
				return r_RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase;
			}
		}

		/// <summary>
		/// Void ClearCachedElementUnderPointer(Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RClearCachedElementUnderPointer_Int32_EventBase;
		public virtual RMethod RClearCachedElementUnderPointer_Int32_EventBase
		{
			get
			{
				if(r_RClearCachedElementUnderPointer_Int32_EventBase == null)
				{
					r_RClearCachedElementUnderPointer_Int32_EventBase = new(this, "ClearCachedElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_RClearCachedElementUnderPointer_Int32_EventBase.SetBelong(this.instance);
				}
				return r_RClearCachedElementUnderPointer_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void CommitElementUnderPointers()
		/// </summary>
		protected RMethod r_RCommitElementUnderPointers;
		public virtual RMethod RCommitElementUnderPointers
		{
			get
			{
				if(r_RCommitElementUnderPointers == null)
				{
					r_RCommitElementUnderPointers = new(this, "CommitElementUnderPointers", 0);
					r_RCommitElementUnderPointers.SetBelong(this.instance);
				}
				return r_RCommitElementUnderPointers;
			}
		}

		/// <summary>
		/// Void InvokeStandardShaderChanged()
		/// </summary>
		protected RMethod r_RInvokeStandardShaderChanged;
		public virtual RMethod RInvokeStandardShaderChanged
		{
			get
			{
				if(r_RInvokeStandardShaderChanged == null)
				{
					r_RInvokeStandardShaderChanged = new(this, "InvokeStandardShaderChanged", 0);
					r_RInvokeStandardShaderChanged.SetBelong(this.instance);
				}
				return r_RInvokeStandardShaderChanged;
			}
		}

		/// <summary>
		/// Void InvokeStandardWorldSpaceShaderChanged()
		/// </summary>
		protected RMethod r_RInvokeStandardWorldSpaceShaderChanged;
		public virtual RMethod RInvokeStandardWorldSpaceShaderChanged
		{
			get
			{
				if(r_RInvokeStandardWorldSpaceShaderChanged == null)
				{
					r_RInvokeStandardWorldSpaceShaderChanged = new(this, "InvokeStandardWorldSpaceShaderChanged", 0);
					r_RInvokeStandardWorldSpaceShaderChanged.SetBelong(this.instance);
				}
				return r_RInvokeStandardWorldSpaceShaderChanged;
			}
		}

		/// <summary>
		/// Void InvokeAtlasChanged()
		/// </summary>
		protected RMethod r_RInvokeAtlasChanged;
		public virtual RMethod RInvokeAtlasChanged
		{
			get
			{
				if(r_RInvokeAtlasChanged == null)
				{
					r_RInvokeAtlasChanged = new(this, "InvokeAtlasChanged", 0);
					r_RInvokeAtlasChanged.SetBelong(this.instance);
				}
				return r_RInvokeAtlasChanged;
			}
		}

		/// <summary>
		/// Void InvokeUpdateMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_RInvokeUpdateMaterial_Material;
		public virtual RMethod RInvokeUpdateMaterial_Material
		{
			get
			{
				if(r_RInvokeUpdateMaterial_Material == null)
				{
					r_RInvokeUpdateMaterial_Material = new(this, "InvokeUpdateMaterial", 0, typeof(UnityEngine.Material));
					r_RInvokeUpdateMaterial_Material.SetBelong(this.instance);
				}
				return r_RInvokeUpdateMaterial_Material;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_RInvokeHierarchyChanged_VisualElement_HierarchyChangeType;
		public virtual RMethod RInvokeHierarchyChanged_VisualElement_HierarchyChangeType
		{
			get
			{
				if(r_RInvokeHierarchyChanged_VisualElement_HierarchyChangeType == null)
				{
					r_RInvokeHierarchyChanged_VisualElement_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_RInvokeHierarchyChanged_VisualElement_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_RInvokeHierarchyChanged_VisualElement_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Void InvokeBeforeUpdate()
		/// </summary>
		protected RMethod r_RInvokeBeforeUpdate;
		public virtual RMethod RInvokeBeforeUpdate
		{
			get
			{
				if(r_RInvokeBeforeUpdate == null)
				{
					r_RInvokeBeforeUpdate = new(this, "InvokeBeforeUpdate", 0);
					r_RInvokeBeforeUpdate.SetBelong(this.instance);
				}
				return r_RInvokeBeforeUpdate;
			}
		}

		/// <summary>
		/// Void UpdateElementUnderPointers()
		/// </summary>
		protected RMethod r_RUpdateElementUnderPointers;
		public virtual RMethod RUpdateElementUnderPointers
		{
			get
			{
				if(r_RUpdateElementUnderPointers == null)
				{
					r_RUpdateElementUnderPointers = new(this, "UpdateElementUnderPointers", 0);
					r_RUpdateElementUnderPointers.SetBelong(this.instance);
				}
				return r_RUpdateElementUnderPointers;
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


        public RBaseRuntimePanel() : base("UnityEngine.UIElements.BaseRuntimePanel")
        {
        }

        public RBaseRuntimePanel(System.Object instance) : base("UnityEngine.UIElements.BaseRuntimePanel")
		{
            SetInstance(instance);
		}

        public RBaseRuntimePanel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseRuntimePanel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint(UnityEngine.Event  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RRepaint_Event.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2  @screen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screen};
            var ___result = RScreenToPanel_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Boolean ScreenToPanel(UnityEngine.Vector2  @screenPosition, UnityEngine.Vector2  @screenDelta, out UnityEngine.Vector2  @panelPosition, out UnityEngine.Vector2  @panelDelta, System.Boolean  @allowOutside)
        {
			panelPosition = default;
			panelDelta = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenPosition, @screenDelta, @panelPosition, @panelDelta, @allowOutside};
            var ___result = RScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean.Invoke(___genericsType, ___parameters);
			panelPosition = (UnityEngine.Vector2)___parameters[2];
			panelDelta = (UnityEngine.Vector2)___parameters[3];

            return (System.Boolean)___result;
        }



        public virtual void PointerLeavesPanel(System.Int32  @pointerId, UnityEngine.Vector2  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @position};
            var ___result = RPointerLeavesPanel_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PointerEntersPanel(System.Int32  @pointerId, UnityEngine.Vector2  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @position};
            var ___result = RPointerEntersPanel_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2  @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>  @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RPick_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void ValidateLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateLayout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBindings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateBindings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAssetTrackers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAssetTrackers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWithoutRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWithoutRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DirtyStyleSheets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDirtyStyleSheets.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement  @rootElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootElement};
            var ___result = RUpdateInlineStylesRecursively_VisualElement.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }



        public virtual UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RGetTopElementUnderPointer_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(System.Int32  @pointerId, UnityEngine.Vector2  @pointerPos, UnityEngine.UIElements.EventBase  @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @pointerPos, @triggerEvent};
            var ___result = RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void ClearCachedElementUnderPointer(System.Int32  @pointerId, UnityEngine.UIElements.EventBase  @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @triggerEvent};
            var ___result = RClearCachedElementUnderPointer_Int32_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CommitElementUnderPointers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCommitElementUnderPointers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeStandardShaderChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvokeStandardShaderChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeStandardWorldSpaceShaderChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvokeStandardWorldSpaceShaderChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeAtlasChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvokeAtlasChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeUpdateMaterial(UnityEngine.Material  @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mat};
            var ___result = RInvokeUpdateMaterial_Material.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void InvokeBeforeUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvokeBeforeUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateElementUnderPointers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateElementUnderPointers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}