using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BaseVisualElementPanel
	/// </summary>
    public partial class RBaseVisualElementPanel : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.BaseVisualElementPanel] panelDisposed
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RBaseVisualElementPanel> r_panelDisposed;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RBaseVisualElementPanel> RpanelDisposed
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
		/// UnityEngine.UIElements.UIElementsBridge m_UIElementsBridge
		/// </summary>
		protected RUnityEngine.RUIElements.RUIElementsBridge r_m_UIElementsBridge;
		public virtual RUnityEngine.RUIElements.RUIElementsBridge Rm_UIElementsBridge
		{
			get
			{
				if(r_m_UIElementsBridge == null)
				{
					r_m_UIElementsBridge = new(this, "m_UIElementsBridge");
					r_m_UIElementsBridge.SetBelong(this.instance);
				}
				return r_m_UIElementsBridge;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected RField r_m_Scale;
		public virtual RField Rm_Scale
		{
			get
			{
				if(r_m_Scale == null)
				{
					r_m_Scale = new(this, "m_Scale");
					r_m_Scale.SetBelong(this.instance);
				}
				return r_m_Scale;
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
		/// System.Single m_PixelsPerPoint
		/// </summary>
		protected RField r_m_PixelsPerPoint;
		public virtual RField Rm_PixelsPerPoint
		{
			get
			{
				if(r_m_PixelsPerPoint == null)
				{
					r_m_PixelsPerPoint = new(this, "m_PixelsPerPoint");
					r_m_PixelsPerPoint.SetBelong(this.instance);
				}
				return r_m_PixelsPerPoint;
			}
		}

		/// <summary>
		/// System.Single <referenceSpritePixelsPerUnit>k__BackingField
		/// </summary>
		protected RField r___0__referenceSpritePixelsPerUnit__1__k__BackingField;
		public virtual RField R__0__referenceSpritePixelsPerUnit__1__k__BackingField
		{
			get
			{
				if(r___0__referenceSpritePixelsPerUnit__1__k__BackingField == null)
				{
					r___0__referenceSpritePixelsPerUnit__1__k__BackingField = new(this, "<referenceSpritePixelsPerUnit>k__BackingField");
					r___0__referenceSpritePixelsPerUnit__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__referenceSpritePixelsPerUnit__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PanelClearSettings <clearSettings>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RPanelClearSettings r___0__clearSettings__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RPanelClearSettings R__0__clearSettings__1__k__BackingField
		{
			get
			{
				if(r___0__clearSettings__1__k__BackingField == null)
				{
					r___0__clearSettings__1__k__BackingField = new(this, "<clearSettings>k__BackingField");
					r___0__clearSettings__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__clearSettings__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <duringLayoutPhase>k__BackingField
		/// </summary>
		protected RField r___0__duringLayoutPhase__1__k__BackingField;
		public virtual RField R__0__duringLayoutPhase__1__k__BackingField
		{
			get
			{
				if(r___0__duringLayoutPhase__1__k__BackingField == null)
				{
					r___0__duringLayoutPhase__1__k__BackingField = new(this, "<duringLayoutPhase>k__BackingField");
					r___0__duringLayoutPhase__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__duringLayoutPhase__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RepaintData <repaintData>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RRepaintData r___0__repaintData__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RRepaintData R__0__repaintData__1__k__BackingField
		{
			get
			{
				if(r___0__repaintData__1__k__BackingField == null)
				{
					r___0__repaintData__1__k__BackingField = new(this, "<repaintData>k__BackingField");
					r___0__repaintData__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__repaintData__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICursorManager <cursorManager>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RICursorManager r___0__cursorManager__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RICursorManager R__0__cursorManager__1__k__BackingField
		{
			get
			{
				if(r___0__cursorManager__1__k__BackingField == null)
				{
					r___0__cursorManager__1__k__BackingField = new(this, "<cursorManager>k__BackingField");
					r___0__cursorManager__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__cursorManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager <contextualMenuManager>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RContextualMenuManager r___0__contextualMenuManager__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RContextualMenuManager R__0__contextualMenuManager__1__k__BackingField
		{
			get
			{
				if(r___0__contextualMenuManager__1__k__BackingField == null)
				{
					r___0__contextualMenuManager__1__k__BackingField = new(this, "<contextualMenuManager>k__BackingField");
					r___0__contextualMenuManager__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__contextualMenuManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RField r___0__disposed__1__k__BackingField;
		public virtual RField R__0__disposed__1__k__BackingField
		{
			get
			{
				if(r___0__disposed__1__k__BackingField == null)
				{
					r___0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r___0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__disposed__1__k__BackingField;
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
		/// System.Action standardShaderChanged
		/// </summary>
		protected RSystem.RAction r_standardShaderChanged;
		public virtual RSystem.RAction RstandardShaderChanged
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
		protected RSystem.RAction r_standardWorldSpaceShaderChanged;
		public virtual RSystem.RAction RstandardWorldSpaceShaderChanged
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
		protected RSystem.RAction r_atlasChanged;
		public virtual RSystem.RAction RatlasChanged
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
		protected RSystem.RAction<RUnityEngine.RMaterial> r_updateMaterial;
		public virtual RSystem.RAction<RUnityEngine.RMaterial> RupdateMaterial
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
		protected RUnityEngine.RUIElements.RHierarchyEvent r_hierarchyChanged;
		public virtual RUnityEngine.RUIElements.RHierarchyEvent RhierarchyChanged
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
		protected RSystem.RAction<RUnityEngine.RUIElements.RIPanel> r_beforeUpdate;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RIPanel> RbeforeUpdate
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
		/// UnityEngine.UIElements.IPanelDebug <panelDebug>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanelDebug r___0__panelDebug__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIPanelDebug R__0__panelDebug__1__k__BackingField
		{
			get
			{
				if(r___0__panelDebug__1__k__BackingField == null)
				{
					r___0__panelDebug__1__k__BackingField = new(this, "<panelDebug>k__BackingField");
					r___0__panelDebug__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__panelDebug__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ILiveReloadSystem <liveReloadSystem>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RILiveReloadSystem r___0__liveReloadSystem__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RILiveReloadSystem R__0__liveReloadSystem__1__k__BackingField
		{
			get
			{
				if(r___0__liveReloadSystem__1__k__BackingField == null)
				{
					r___0__liveReloadSystem__1__k__BackingField = new(this, "<liveReloadSystem>k__BackingField");
					r___0__liveReloadSystem__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__liveReloadSystem__1__k__BackingField;
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
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_Dispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_Dispose_Boolean == null)
				{
					r_Dispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_Dispose_Boolean.SetBelong(this.instance);
				}
				return r_Dispose_Boolean;
			}
		}

		/// <summary>
		/// Void Repaint(UnityEngine.Event)
		/// </summary>
		protected RMethod r_Repaint_Event;
		public virtual RMethod RRepaint_Event
		{
			get
			{
				if(r_Repaint_Event == null)
				{
					r_Repaint_Event = new(this, "Repaint", 0, typeof(UnityEngine.Event));
					r_Repaint_Event.SetBelong(this.instance);
				}
				return r_Repaint_Event;
			}
		}

		/// <summary>
		/// Void ValidateLayout()
		/// </summary>
		protected RMethod r_ValidateLayout;
		public virtual RMethod RValidateLayout
		{
			get
			{
				if(r_ValidateLayout == null)
				{
					r_ValidateLayout = new(this, "ValidateLayout", 0);
					r_ValidateLayout.SetBelong(this.instance);
				}
				return r_ValidateLayout;
			}
		}

		/// <summary>
		/// Void UpdateAnimations()
		/// </summary>
		protected RMethod r_UpdateAnimations;
		public virtual RMethod RUpdateAnimations
		{
			get
			{
				if(r_UpdateAnimations == null)
				{
					r_UpdateAnimations = new(this, "UpdateAnimations", 0);
					r_UpdateAnimations.SetBelong(this.instance);
				}
				return r_UpdateAnimations;
			}
		}

		/// <summary>
		/// Void UpdateBindings()
		/// </summary>
		protected RMethod r_UpdateBindings;
		public virtual RMethod RUpdateBindings
		{
			get
			{
				if(r_UpdateBindings == null)
				{
					r_UpdateBindings = new(this, "UpdateBindings", 0);
					r_UpdateBindings.SetBelong(this.instance);
				}
				return r_UpdateBindings;
			}
		}

		/// <summary>
		/// Void ApplyStyles()
		/// </summary>
		protected RMethod r_ApplyStyles;
		public virtual RMethod RApplyStyles
		{
			get
			{
				if(r_ApplyStyles == null)
				{
					r_ApplyStyles = new(this, "ApplyStyles", 0);
					r_ApplyStyles.SetBelong(this.instance);
				}
				return r_ApplyStyles;
			}
		}

		/// <summary>
		/// Void UpdateAssetTrackers()
		/// </summary>
		protected RMethod r_UpdateAssetTrackers;
		public virtual RMethod RUpdateAssetTrackers
		{
			get
			{
				if(r_UpdateAssetTrackers == null)
				{
					r_UpdateAssetTrackers = new(this, "UpdateAssetTrackers", 0);
					r_UpdateAssetTrackers.SetBelong(this.instance);
				}
				return r_UpdateAssetTrackers;
			}
		}

		/// <summary>
		/// Void DirtyStyleSheets()
		/// </summary>
		protected RMethod r_DirtyStyleSheets;
		public virtual RMethod RDirtyStyleSheets
		{
			get
			{
				if(r_DirtyStyleSheets == null)
				{
					r_DirtyStyleSheets = new(this, "DirtyStyleSheets", 0);
					r_DirtyStyleSheets.SetBelong(this.instance);
				}
				return r_DirtyStyleSheets;
			}
		}

		/// <summary>
		/// Void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_UpdateInlineStylesRecursively_VisualElement;
		public virtual RMethod RUpdateInlineStylesRecursively_VisualElement
		{
			get
			{
				if(r_UpdateInlineStylesRecursively_VisualElement == null)
				{
					r_UpdateInlineStylesRecursively_VisualElement = new(this, "UpdateInlineStylesRecursively", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_UpdateInlineStylesRecursively_VisualElement.SetBelong(this.instance);
				}
				return r_UpdateInlineStylesRecursively_VisualElement;
			}
		}

		/// <summary>
		/// Void RequestUpdateAfterExternalEvent(UnityEngine.UIElements.IVisualTreeUpdater)
		/// </summary>
		protected RMethod r_RequestUpdateAfterExternalEvent_IVisualTreeUpdater;
		public virtual RMethod RRequestUpdateAfterExternalEvent_IVisualTreeUpdater
		{
			get
			{
				if(r_RequestUpdateAfterExternalEvent_IVisualTreeUpdater == null)
				{
					r_RequestUpdateAfterExternalEvent_IVisualTreeUpdater = new(this, "RequestUpdateAfterExternalEvent", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"));
					r_RequestUpdateAfterExternalEvent_IVisualTreeUpdater.SetBelong(this.instance);
				}
				return r_RequestUpdateAfterExternalEvent_IVisualTreeUpdater;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_OnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_OnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_OnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_OnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_OnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase == null)
				{
					r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase = new(this, "SetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_SetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_SendEvent_EventBase_DispatchMode;
		public virtual RMethod RSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_SendEvent_EventBase_DispatchMode == null)
				{
					r_SendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_SendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_SendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_Pick_Vector2;
		public virtual RMethod RPick_Vector2
		{
			get
			{
				if(r_Pick_Vector2 == null)
				{
					r_Pick_Vector2 = new(this, "Pick", 0, typeof(UnityEngine.Vector2));
					r_Pick_Vector2.SetBelong(this.instance);
				}
				return r_Pick_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2, System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_PickAll_Vector2_List_d_VisualElement_p_;
		public virtual RMethod RPickAll_Vector2_List_d_VisualElement_p_
		{
			get
			{
				if(r_PickAll_Vector2_List_d_VisualElement_p_ == null)
				{
					r_PickAll_Vector2_List_d_VisualElement_p_ = new(this, "PickAll", 0, typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_PickAll_Vector2_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_PickAll_Vector2_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_GetUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RGetUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_GetUpdater_VisualTreeUpdatePhase == null)
				{
					r_GetUpdater_VisualTreeUpdatePhase = new(this, "GetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_GetUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_GetUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetEditorUpdater(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_GetEditorUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RGetEditorUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_GetEditorUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_GetEditorUpdater_VisualTreeEditorUpdatePhase = new(this, "GetEditorUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_GetEditorUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_GetEditorUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32)
		/// </summary>
		protected RMethod r_GetTopElementUnderPointer_Int32;
		public virtual RMethod RGetTopElementUnderPointer_Int32
		{
			get
			{
				if(r_GetTopElementUnderPointer_Int32 == null)
				{
					r_GetTopElementUnderPointer_Int32 = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32));
					r_GetTopElementUnderPointer_Int32.SetBelong(this.instance);
				}
				return r_GetTopElementUnderPointer_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(Int32, UnityEngine.Vector2, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RecomputeTopElementUnderPointer_Int32_Vector2_EventBase;
		public virtual RMethod RRecomputeTopElementUnderPointer_Int32_Vector2_EventBase
		{
			get
			{
				if(r_RecomputeTopElementUnderPointer_Int32_Vector2_EventBase == null)
				{
					r_RecomputeTopElementUnderPointer_Int32_Vector2_EventBase = new(this, "RecomputeTopElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.UIElements.EventBase));
					r_RecomputeTopElementUnderPointer_Int32_Vector2_EventBase.SetBelong(this.instance);
				}
				return r_RecomputeTopElementUnderPointer_Int32_Vector2_EventBase;
			}
		}

		/// <summary>
		/// Void ClearCachedElementUnderPointer(Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_ClearCachedElementUnderPointer_Int32_EventBase;
		public virtual RMethod RClearCachedElementUnderPointer_Int32_EventBase
		{
			get
			{
				if(r_ClearCachedElementUnderPointer_Int32_EventBase == null)
				{
					r_ClearCachedElementUnderPointer_Int32_EventBase = new(this, "ClearCachedElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_ClearCachedElementUnderPointer_Int32_EventBase.SetBelong(this.instance);
				}
				return r_ClearCachedElementUnderPointer_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void CommitElementUnderPointers()
		/// </summary>
		protected RMethod r_CommitElementUnderPointers;
		public virtual RMethod RCommitElementUnderPointers
		{
			get
			{
				if(r_CommitElementUnderPointers == null)
				{
					r_CommitElementUnderPointers = new(this, "CommitElementUnderPointers", 0);
					r_CommitElementUnderPointers.SetBelong(this.instance);
				}
				return r_CommitElementUnderPointers;
			}
		}

		/// <summary>
		/// Void InvokeStandardShaderChanged()
		/// </summary>
		protected RMethod r_InvokeStandardShaderChanged;
		public virtual RMethod RInvokeStandardShaderChanged
		{
			get
			{
				if(r_InvokeStandardShaderChanged == null)
				{
					r_InvokeStandardShaderChanged = new(this, "InvokeStandardShaderChanged", 0);
					r_InvokeStandardShaderChanged.SetBelong(this.instance);
				}
				return r_InvokeStandardShaderChanged;
			}
		}

		/// <summary>
		/// Void InvokeStandardWorldSpaceShaderChanged()
		/// </summary>
		protected RMethod r_InvokeStandardWorldSpaceShaderChanged;
		public virtual RMethod RInvokeStandardWorldSpaceShaderChanged
		{
			get
			{
				if(r_InvokeStandardWorldSpaceShaderChanged == null)
				{
					r_InvokeStandardWorldSpaceShaderChanged = new(this, "InvokeStandardWorldSpaceShaderChanged", 0);
					r_InvokeStandardWorldSpaceShaderChanged.SetBelong(this.instance);
				}
				return r_InvokeStandardWorldSpaceShaderChanged;
			}
		}

		/// <summary>
		/// Void InvokeAtlasChanged()
		/// </summary>
		protected RMethod r_InvokeAtlasChanged;
		public virtual RMethod RInvokeAtlasChanged
		{
			get
			{
				if(r_InvokeAtlasChanged == null)
				{
					r_InvokeAtlasChanged = new(this, "InvokeAtlasChanged", 0);
					r_InvokeAtlasChanged.SetBelong(this.instance);
				}
				return r_InvokeAtlasChanged;
			}
		}

		/// <summary>
		/// Void InvokeUpdateMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_InvokeUpdateMaterial_Material;
		public virtual RMethod RInvokeUpdateMaterial_Material
		{
			get
			{
				if(r_InvokeUpdateMaterial_Material == null)
				{
					r_InvokeUpdateMaterial_Material = new(this, "InvokeUpdateMaterial", 0, typeof(UnityEngine.Material));
					r_InvokeUpdateMaterial_Material.SetBelong(this.instance);
				}
				return r_InvokeUpdateMaterial_Material;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_InvokeHierarchyChanged_VisualElement_HierarchyChangeType;
		public virtual RMethod RInvokeHierarchyChanged_VisualElement_HierarchyChangeType
		{
			get
			{
				if(r_InvokeHierarchyChanged_VisualElement_HierarchyChangeType == null)
				{
					r_InvokeHierarchyChanged_VisualElement_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_InvokeHierarchyChanged_VisualElement_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_InvokeHierarchyChanged_VisualElement_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Void InvokeBeforeUpdate()
		/// </summary>
		protected RMethod r_InvokeBeforeUpdate;
		public virtual RMethod RInvokeBeforeUpdate
		{
			get
			{
				if(r_InvokeBeforeUpdate == null)
				{
					r_InvokeBeforeUpdate = new(this, "InvokeBeforeUpdate", 0);
					r_InvokeBeforeUpdate.SetBelong(this.instance);
				}
				return r_InvokeBeforeUpdate;
			}
		}

		/// <summary>
		/// Void UpdateElementUnderPointers()
		/// </summary>
		protected RMethod r_UpdateElementUnderPointers;
		public virtual RMethod RUpdateElementUnderPointers
		{
			get
			{
				if(r_UpdateElementUnderPointers == null)
				{
					r_UpdateElementUnderPointers = new(this, "UpdateElementUnderPointers", 0);
					r_UpdateElementUnderPointers.SetBelong(this.instance);
				}
				return r_UpdateElementUnderPointers;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IGroupBox.OnOptionAdded(UnityEngine.UIElements.IGroupBoxOption)
		/// </summary>
		protected RMethod r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption;
		public virtual RMethod RUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption == null)
				{
					r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption = new(this, "UnityEngine.UIElements.IGroupBox.OnOptionAdded", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IGroupBoxOption"));
					r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(UnityEngine.UIElements.IGroupBoxOption)
		/// </summary>
		protected RMethod r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption;
		public virtual RMethod RUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption == null)
				{
					r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption = new(this, "UnityEngine.UIElements.IGroupBox.OnOptionRemoved", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IGroupBoxOption"));
					r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption;
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


        public RBaseVisualElementPanel() : base("UnityEngine.UIElements.BaseVisualElementPanel")
        {
        }

        public RBaseVisualElementPanel(System.Object instance) : base("UnityEngine.UIElements.BaseVisualElementPanel")
		{
            SetInstance(instance);
		}

        public RBaseVisualElementPanel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseVisualElementPanel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DirtyStyleSheets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDirtyStyleSheets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement  @root)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root};
            var ___result = RUpdateInlineStylesRecursively_VisualElement.Invoke(___genericsType, ___parameters);

            
        }






        public virtual UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RPick_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2  @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>  @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
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
