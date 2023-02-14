
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BaseVisualElementPanel
	/// </summary>
    public partial class RBaseVisualElementPanel : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.BaseVisualElementPanel] panelDisposed
		/// </summary>
		protected REvent r_EpanelDisposed;
		public virtual REvent REpanelDisposed
		{
			get
			{
				if(r_EpanelDisposed == null)
				{
					r_EpanelDisposed = new(this, "panelDisposed");
					r_EpanelDisposed.SetBelong(this.instance);
				}
				return r_EpanelDisposed;
			}
		}

		/// <summary>
		/// System.Action standardShaderChanged
		/// </summary>
		protected REvent r_EstandardShaderChanged;
		public virtual REvent REstandardShaderChanged
		{
			get
			{
				if(r_EstandardShaderChanged == null)
				{
					r_EstandardShaderChanged = new(this, "standardShaderChanged");
					r_EstandardShaderChanged.SetBelong(this.instance);
				}
				return r_EstandardShaderChanged;
			}
		}

		/// <summary>
		/// System.Action standardWorldSpaceShaderChanged
		/// </summary>
		protected REvent r_EstandardWorldSpaceShaderChanged;
		public virtual REvent REstandardWorldSpaceShaderChanged
		{
			get
			{
				if(r_EstandardWorldSpaceShaderChanged == null)
				{
					r_EstandardWorldSpaceShaderChanged = new(this, "standardWorldSpaceShaderChanged");
					r_EstandardWorldSpaceShaderChanged.SetBelong(this.instance);
				}
				return r_EstandardWorldSpaceShaderChanged;
			}
		}

		/// <summary>
		/// System.Action atlasChanged
		/// </summary>
		protected REvent r_EatlasChanged;
		public virtual REvent REatlasChanged
		{
			get
			{
				if(r_EatlasChanged == null)
				{
					r_EatlasChanged = new(this, "atlasChanged");
					r_EatlasChanged.SetBelong(this.instance);
				}
				return r_EatlasChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Material] updateMaterial
		/// </summary>
		protected REvent r_EupdateMaterial;
		public virtual REvent REupdateMaterial
		{
			get
			{
				if(r_EupdateMaterial == null)
				{
					r_EupdateMaterial = new(this, "updateMaterial");
					r_EupdateMaterial.SetBelong(this.instance);
				}
				return r_EupdateMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.HierarchyEvent hierarchyChanged
		/// </summary>
		protected REvent r_EhierarchyChanged;
		public virtual REvent REhierarchyChanged
		{
			get
			{
				if(r_EhierarchyChanged == null)
				{
					r_EhierarchyChanged = new(this, "hierarchyChanged");
					r_EhierarchyChanged.SetBelong(this.instance);
				}
				return r_EhierarchyChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.IPanel] beforeUpdate
		/// </summary>
		protected REvent r_EbeforeUpdate;
		public virtual REvent REbeforeUpdate
		{
			get
			{
				if(r_EbeforeUpdate == null)
				{
					r_EbeforeUpdate = new(this, "beforeUpdate");
					r_EbeforeUpdate.SetBelong(this.instance);
				}
				return r_EbeforeUpdate;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.BaseVisualElementPanel] panelDisposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel> r_FpanelDisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel> RFpanelDisposed
		{
			get
			{
				if(r_FpanelDisposed == null)
				{
					r_FpanelDisposed = new(this, "panelDisposed");
					r_FpanelDisposed.SetBelong(this.instance);
				}
				return r_FpanelDisposed;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIElementsBridge m_UIElementsBridge
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIElementsBridge r_Fm_UIElementsBridge;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIElementsBridge RFm_UIElementsBridge
		{
			get
			{
				if(r_Fm_UIElementsBridge == null)
				{
					r_Fm_UIElementsBridge = new(this, "m_UIElementsBridge");
					r_Fm_UIElementsBridge.SetBelong(this.instance);
				}
				return r_Fm_UIElementsBridge;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Scale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Scale
		{
			get
			{
				if(r_Fm_Scale == null)
				{
					r_Fm_Scale = new(this, "m_Scale");
					r_Fm_Scale.SetBelong(this.instance);
				}
				return r_Fm_Scale;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig yogaConfig
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaConfig r_FyogaConfig;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaConfig RFyogaConfig
		{
			get
			{
				if(r_FyogaConfig == null)
				{
					r_FyogaConfig = new(this, "yogaConfig");
					r_FyogaConfig.SetBelong(this.instance);
				}
				return r_FyogaConfig;
			}
		}

		/// <summary>
		/// System.Single m_PixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_PixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_PixelsPerPoint
		{
			get
			{
				if(r_Fm_PixelsPerPoint == null)
				{
					r_Fm_PixelsPerPoint = new(this, "m_PixelsPerPoint");
					r_Fm_PixelsPerPoint.SetBelong(this.instance);
				}
				return r_Fm_PixelsPerPoint;
			}
		}

		/// <summary>
		/// System.Single <referenceSpritePixelsPerUnit>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_F__0__referenceSpritePixelsPerUnit__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RF__0__referenceSpritePixelsPerUnit__1__k__BackingField
		{
			get
			{
				if(r_F__0__referenceSpritePixelsPerUnit__1__k__BackingField == null)
				{
					r_F__0__referenceSpritePixelsPerUnit__1__k__BackingField = new(this, "<referenceSpritePixelsPerUnit>k__BackingField");
					r_F__0__referenceSpritePixelsPerUnit__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__referenceSpritePixelsPerUnit__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PanelClearSettings <clearSettings>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPanelClearSettings r_F__0__clearSettings__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPanelClearSettings RF__0__clearSettings__1__k__BackingField
		{
			get
			{
				if(r_F__0__clearSettings__1__k__BackingField == null)
				{
					r_F__0__clearSettings__1__k__BackingField = new(this, "<clearSettings>k__BackingField");
					r_F__0__clearSettings__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__clearSettings__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <duringLayoutPhase>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__duringLayoutPhase__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__duringLayoutPhase__1__k__BackingField
		{
			get
			{
				if(r_F__0__duringLayoutPhase__1__k__BackingField == null)
				{
					r_F__0__duringLayoutPhase__1__k__BackingField = new(this, "<duringLayoutPhase>k__BackingField");
					r_F__0__duringLayoutPhase__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__duringLayoutPhase__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RepaintData <repaintData>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepaintData r_F__0__repaintData__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepaintData RF__0__repaintData__1__k__BackingField
		{
			get
			{
				if(r_F__0__repaintData__1__k__BackingField == null)
				{
					r_F__0__repaintData__1__k__BackingField = new(this, "<repaintData>k__BackingField");
					r_F__0__repaintData__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__repaintData__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICursorManager <cursorManager>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICursorManager r_F__0__cursorManager__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICursorManager RF__0__cursorManager__1__k__BackingField
		{
			get
			{
				if(r_F__0__cursorManager__1__k__BackingField == null)
				{
					r_F__0__cursorManager__1__k__BackingField = new(this, "<cursorManager>k__BackingField");
					r_F__0__cursorManager__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__cursorManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager <contextualMenuManager>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager r_F__0__contextualMenuManager__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager RF__0__contextualMenuManager__1__k__BackingField
		{
			get
			{
				if(r_F__0__contextualMenuManager__1__k__BackingField == null)
				{
					r_F__0__contextualMenuManager__1__k__BackingField = new(this, "<contextualMenuManager>k__BackingField");
					r_F__0__contextualMenuManager__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__contextualMenuManager__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r_F__0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ElementUnderPointer m_TopElementUnderPointers
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RElementUnderPointer r_Fm_TopElementUnderPointers;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RElementUnderPointer RFm_TopElementUnderPointers
		{
			get
			{
				if(r_Fm_TopElementUnderPointers == null)
				{
					r_Fm_TopElementUnderPointers = new(this, "m_TopElementUnderPointers");
					r_Fm_TopElementUnderPointers.SetBelong(this.instance);
				}
				return r_Fm_TopElementUnderPointers;
			}
		}

		/// <summary>
		/// System.Action standardShaderChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FstandardShaderChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFstandardShaderChanged
		{
			get
			{
				if(r_FstandardShaderChanged == null)
				{
					r_FstandardShaderChanged = new(this, "standardShaderChanged");
					r_FstandardShaderChanged.SetBelong(this.instance);
				}
				return r_FstandardShaderChanged;
			}
		}

		/// <summary>
		/// System.Action standardWorldSpaceShaderChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FstandardWorldSpaceShaderChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFstandardWorldSpaceShaderChanged
		{
			get
			{
				if(r_FstandardWorldSpaceShaderChanged == null)
				{
					r_FstandardWorldSpaceShaderChanged = new(this, "standardWorldSpaceShaderChanged");
					r_FstandardWorldSpaceShaderChanged.SetBelong(this.instance);
				}
				return r_FstandardWorldSpaceShaderChanged;
			}
		}

		/// <summary>
		/// System.Action atlasChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FatlasChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFatlasChanged
		{
			get
			{
				if(r_FatlasChanged == null)
				{
					r_FatlasChanged = new(this, "atlasChanged");
					r_FatlasChanged.SetBelong(this.instance);
				}
				return r_FatlasChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Material] updateMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RMaterial> r_FupdateMaterial;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RMaterial> RFupdateMaterial
		{
			get
			{
				if(r_FupdateMaterial == null)
				{
					r_FupdateMaterial = new(this, "updateMaterial");
					r_FupdateMaterial.SetBelong(this.instance);
				}
				return r_FupdateMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.HierarchyEvent hierarchyChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHierarchyEvent r_FhierarchyChanged;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHierarchyEvent RFhierarchyChanged
		{
			get
			{
				if(r_FhierarchyChanged == null)
				{
					r_FhierarchyChanged = new(this, "hierarchyChanged");
					r_FhierarchyChanged.SetBelong(this.instance);
				}
				return r_FhierarchyChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.IPanel] beforeUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel> r_FbeforeUpdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel> RFbeforeUpdate
		{
			get
			{
				if(r_FbeforeUpdate == null)
				{
					r_FbeforeUpdate = new(this, "beforeUpdate");
					r_FbeforeUpdate.SetBelong(this.instance);
				}
				return r_FbeforeUpdate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug <panelDebug>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug r_F__0__panelDebug__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug RF__0__panelDebug__1__k__BackingField
		{
			get
			{
				if(r_F__0__panelDebug__1__k__BackingField == null)
				{
					r_F__0__panelDebug__1__k__BackingField = new(this, "<panelDebug>k__BackingField");
					r_F__0__panelDebug__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__panelDebug__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ILiveReloadSystem <liveReloadSystem>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadSystem r_F__0__liveReloadSystem__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadSystem RF__0__liveReloadSystem__1__k__BackingField
		{
			get
			{
				if(r_F__0__liveReloadSystem__1__k__BackingField == null)
				{
					r_F__0__liveReloadSystem__1__k__BackingField = new(this, "<liveReloadSystem>k__BackingField");
					r_F__0__liveReloadSystem__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__liveReloadSystem__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.EventInterests IMGUIEventInterests
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventInterests r_PIMGUIEventInterests;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventInterests RPIMGUIEventInterests
		{
			get
			{
				if(r_PIMGUIEventInterests == null)
				{
					r_PIMGUIEventInterests = new(this, "IMGUIEventInterests", -1);
					r_PIMGUIEventInterests.SetBelong(this.instance);
				}
				return r_PIMGUIEventInterests;
			}
		}

		/// <summary>
		/// UnityEngine.ScriptableObject ownerObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RScriptableObject r_PownerObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RScriptableObject RPownerObject
		{
			get
			{
				if(r_PownerObject == null)
				{
					r_PownerObject = new(this, "ownerObject", -1);
					r_PownerObject.SetBelong(this.instance);
				}
				return r_PownerObject;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.SavePersistentViewData saveViewData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSavePersistentViewData r_PsaveViewData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSavePersistentViewData RPsaveViewData
		{
			get
			{
				if(r_PsaveViewData == null)
				{
					r_PsaveViewData = new(this, "saveViewData", -1);
					r_PsaveViewData.SetBelong(this.instance);
				}
				return r_PsaveViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.GetViewDataDictionary getViewDataDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RGetViewDataDictionary r_PgetViewDataDictionary;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RGetViewDataDictionary RPgetViewDataDictionary
		{
			get
			{
				if(r_PgetViewDataDictionary == null)
				{
					r_PgetViewDataDictionary = new(this, "getViewDataDictionary", -1);
					r_PgetViewDataDictionary.SetBelong(this.instance);
				}
				return r_PgetViewDataDictionary;
			}
		}

		/// <summary>
		/// Int32 IMGUIContainersCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIMGUIContainersCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIMGUIContainersCount
		{
			get
			{
				if(r_PIMGUIContainersCount == null)
				{
					r_PIMGUIContainersCount = new(this, "IMGUIContainersCount", -1);
					r_PIMGUIContainersCount.SetBelong(this.instance);
				}
				return r_PIMGUIContainersCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
					r_PfocusController.SetBelong(this.instance);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer rootIMGUIContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIMGUIContainer r_ProotIMGUIContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIMGUIContainer RProotIMGUIContainer
		{
			get
			{
				if(r_ProotIMGUIContainer == null)
				{
					r_ProotIMGUIContainer = new(this, "rootIMGUIContainer", -1);
					r_ProotIMGUIContainer.SetBelong(this.instance);
				}
				return r_ProotIMGUIContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIElementsBridge uiElementsBridge
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIElementsBridge r_PuiElementsBridge;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIElementsBridge RPuiElementsBridge
		{
			get
			{
				if(r_PuiElementsBridge == null)
				{
					r_PuiElementsBridge = new(this, "uiElementsBridge", -1);
					r_PuiElementsBridge.SetBelong(this.instance);
				}
				return r_PuiElementsBridge;
			}
		}

		/// <summary>
		/// Boolean enableAssetReload
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenableAssetReload;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenableAssetReload
		{
			get
			{
				if(r_PenableAssetReload == null)
				{
					r_PenableAssetReload = new(this, "enableAssetReload", -1);
					r_PenableAssetReload.SetBelong(this.instance);
				}
				return r_PenableAssetReload;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pscale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
					r_Pscale.SetBelong(this.instance);
				}
				return r_Pscale;
			}
		}

		/// <summary>
		/// Single pixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PpixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpixelsPerPoint
		{
			get
			{
				if(r_PpixelsPerPoint == null)
				{
					r_PpixelsPerPoint = new(this, "pixelsPerPoint", -1);
					r_PpixelsPerPoint.SetBelong(this.instance);
				}
				return r_PpixelsPerPoint;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PscaledPixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPscaledPixelsPerPoint
		{
			get
			{
				if(r_PscaledPixelsPerPoint == null)
				{
					r_PscaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_PscaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_PscaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// Single referenceSpritePixelsPerUnit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PreferenceSpritePixelsPerUnit;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPreferenceSpritePixelsPerUnit
		{
			get
			{
				if(r_PreferenceSpritePixelsPerUnit == null)
				{
					r_PreferenceSpritePixelsPerUnit = new(this, "referenceSpritePixelsPerUnit", -1);
					r_PreferenceSpritePixelsPerUnit.SetBelong(this.instance);
				}
				return r_PreferenceSpritePixelsPerUnit;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PanelClearFlags clearFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPanelClearFlags r_PclearFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPanelClearFlags RPclearFlags
		{
			get
			{
				if(r_PclearFlags == null)
				{
					r_PclearFlags = new(this, "clearFlags", -1);
					r_PclearFlags.SetBelong(this.instance);
				}
				return r_PclearFlags;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PanelClearSettings clearSettings
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPanelClearSettings r_PclearSettings;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPanelClearSettings RPclearSettings
		{
			get
			{
				if(r_PclearSettings == null)
				{
					r_PclearSettings = new(this, "clearSettings", -1);
					r_PclearSettings.SetBelong(this.instance);
				}
				return r_PclearSettings;
			}
		}

		/// <summary>
		/// Boolean duringLayoutPhase
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PduringLayoutPhase;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPduringLayoutPhase
		{
			get
			{
				if(r_PduringLayoutPhase == null)
				{
					r_PduringLayoutPhase = new(this, "duringLayoutPhase", -1);
					r_PduringLayoutPhase.SetBelong(this.instance);
				}
				return r_PduringLayoutPhase;
			}
		}

		/// <summary>
		/// Boolean isDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDirty
		{
			get
			{
				if(r_PisDirty == null)
				{
					r_PisDirty = new(this, "isDirty", -1);
					r_PisDirty.SetBelong(this.instance);
				}
				return r_PisDirty;
			}
		}

		/// <summary>
		/// UInt32 version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.instance);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// UInt32 repaintVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PrepaintVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPrepaintVersion
		{
			get
			{
				if(r_PrepaintVersion == null)
				{
					r_PrepaintVersion = new(this, "repaintVersion", -1);
					r_PrepaintVersion.SetBelong(this.instance);
				}
				return r_PrepaintVersion;
			}
		}

		/// <summary>
		/// UInt32 hierarchyVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PhierarchyVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPhierarchyVersion
		{
			get
			{
				if(r_PhierarchyVersion == null)
				{
					r_PhierarchyVersion = new(this, "hierarchyVersion", -1);
					r_PhierarchyVersion.SetBelong(this.instance);
				}
				return r_PhierarchyVersion;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RepaintData repaintData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepaintData r_PrepaintData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepaintData RPrepaintData
		{
			get
			{
				if(r_PrepaintData == null)
				{
					r_PrepaintData = new(this, "repaintData", -1);
					r_PrepaintData.SetBelong(this.instance);
				}
				return r_PrepaintData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICursorManager cursorManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICursorManager r_PcursorManager;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICursorManager RPcursorManager
		{
			get
			{
				if(r_PcursorManager == null)
				{
					r_PcursorManager = new(this, "cursorManager", -1);
					r_PcursorManager.SetBelong(this.instance);
				}
				return r_PcursorManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager contextualMenuManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager r_PcontextualMenuManager;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager RPcontextualMenuManager
		{
			get
			{
				if(r_PcontextualMenuManager == null)
				{
					r_PcontextualMenuManager = new(this, "contextualMenuManager", -1);
					r_PcontextualMenuManager.SetBelong(this.instance);
				}
				return r_PcontextualMenuManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PvisualTree;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPvisualTree
		{
			get
			{
				if(r_PvisualTree == null)
				{
					r_PvisualTree = new(this, "visualTree", -1);
					r_PvisualTree.SetBelong(this.instance);
				}
				return r_PvisualTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher dispatcher
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher r_Pdispatcher;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher RPdispatcher
		{
			get
			{
				if(r_Pdispatcher == null)
				{
					r_Pdispatcher = new(this, "dispatcher", -1);
					r_Pdispatcher.SetBelong(this.instance);
				}
				return r_Pdispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IScheduler scheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIScheduler r_Pscheduler;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIScheduler RPscheduler
		{
			get
			{
				if(r_Pscheduler == null)
				{
					r_Pscheduler = new(this, "scheduler", -1);
					r_Pscheduler.SetBelong(this.instance);
				}
				return r_Pscheduler;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimationSystem styleAnimationSystem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimationSystem r_PstyleAnimationSystem;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimationSystem RPstyleAnimationSystem
		{
			get
			{
				if(r_PstyleAnimationSystem == null)
				{
					r_PstyleAnimationSystem = new(this, "styleAnimationSystem", -1);
					r_PstyleAnimationSystem.SetBelong(this.instance);
				}
				return r_PstyleAnimationSystem;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType contextType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextType r_PcontextType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextType RPcontextType
		{
			get
			{
				if(r_PcontextType == null)
				{
					r_PcontextType = new(this, "contextType", -1);
					r_PcontextType.SetBelong(this.instance);
				}
				return r_PcontextType;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdisposed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
					r_Pdisposed.SetBelong(this.instance);
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// UnityEngine.Shader standardShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_PstandardShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RPstandardShader
		{
			get
			{
				if(r_PstandardShader == null)
				{
					r_PstandardShader = new(this, "standardShader", -1);
					r_PstandardShader.SetBelong(this.instance);
				}
				return r_PstandardShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader standardWorldSpaceShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_PstandardWorldSpaceShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RPstandardWorldSpaceShader
		{
			get
			{
				if(r_PstandardWorldSpaceShader == null)
				{
					r_PstandardWorldSpaceShader = new(this, "standardWorldSpaceShader", -1);
					r_PstandardWorldSpaceShader.SetBelong(this.instance);
				}
				return r_PstandardWorldSpaceShader;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase r_Patlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase RPatlas
		{
			get
			{
				if(r_Patlas == null)
				{
					r_Patlas = new(this, "atlas", -1);
					r_Patlas.SetBelong(this.instance);
				}
				return r_Patlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug panelDebug
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug r_PpanelDebug;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug RPpanelDebug
		{
			get
			{
				if(r_PpanelDebug == null)
				{
					r_PpanelDebug = new(this, "panelDebug", -1);
					r_PpanelDebug.SetBelong(this.instance);
				}
				return r_PpanelDebug;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ILiveReloadSystem liveReloadSystem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadSystem r_PliveReloadSystem;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadSystem RPliveReloadSystem
		{
			get
			{
				if(r_PliveReloadSystem == null)
				{
					r_PliveReloadSystem = new(this, "liveReloadSystem", -1);
					r_PliveReloadSystem.SetBelong(this.instance);
				}
				return r_PliveReloadSystem;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
			}
		}

		/// <summary>
		/// Void Repaint(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MRepaint_Event;
		public virtual RMethod RMRepaint_Event
		{
			get
			{
				if(r_MRepaint_Event == null)
				{
					r_MRepaint_Event = new(this, "Repaint", 0, typeof(UnityEngine.Event));
					r_MRepaint_Event.SetBelong(this.instance);
				}
				return r_MRepaint_Event;
			}
		}

		/// <summary>
		/// Void ValidateFocus()
		/// </summary>
		protected RMethod r_MValidateFocus;
		public virtual RMethod RMValidateFocus
		{
			get
			{
				if(r_MValidateFocus == null)
				{
					r_MValidateFocus = new(this, "ValidateFocus", 0);
					r_MValidateFocus.SetBelong(this.instance);
				}
				return r_MValidateFocus;
			}
		}

		/// <summary>
		/// Void ValidateLayout()
		/// </summary>
		protected RMethod r_MValidateLayout;
		public virtual RMethod RMValidateLayout
		{
			get
			{
				if(r_MValidateLayout == null)
				{
					r_MValidateLayout = new(this, "ValidateLayout", 0);
					r_MValidateLayout.SetBelong(this.instance);
				}
				return r_MValidateLayout;
			}
		}

		/// <summary>
		/// Void UpdateAnimations()
		/// </summary>
		protected RMethod r_MUpdateAnimations;
		public virtual RMethod RMUpdateAnimations
		{
			get
			{
				if(r_MUpdateAnimations == null)
				{
					r_MUpdateAnimations = new(this, "UpdateAnimations", 0);
					r_MUpdateAnimations.SetBelong(this.instance);
				}
				return r_MUpdateAnimations;
			}
		}

		/// <summary>
		/// Void UpdateBindings()
		/// </summary>
		protected RMethod r_MUpdateBindings;
		public virtual RMethod RMUpdateBindings
		{
			get
			{
				if(r_MUpdateBindings == null)
				{
					r_MUpdateBindings = new(this, "UpdateBindings", 0);
					r_MUpdateBindings.SetBelong(this.instance);
				}
				return r_MUpdateBindings;
			}
		}

		/// <summary>
		/// Void ApplyStyles()
		/// </summary>
		protected RMethod r_MApplyStyles;
		public virtual RMethod RMApplyStyles
		{
			get
			{
				if(r_MApplyStyles == null)
				{
					r_MApplyStyles = new(this, "ApplyStyles", 0);
					r_MApplyStyles.SetBelong(this.instance);
				}
				return r_MApplyStyles;
			}
		}

		/// <summary>
		/// Void UpdateAssetTrackers()
		/// </summary>
		protected RMethod r_MUpdateAssetTrackers;
		public virtual RMethod RMUpdateAssetTrackers
		{
			get
			{
				if(r_MUpdateAssetTrackers == null)
				{
					r_MUpdateAssetTrackers = new(this, "UpdateAssetTrackers", 0);
					r_MUpdateAssetTrackers.SetBelong(this.instance);
				}
				return r_MUpdateAssetTrackers;
			}
		}

		/// <summary>
		/// Void DirtyStyleSheets()
		/// </summary>
		protected RMethod r_MDirtyStyleSheets;
		public virtual RMethod RMDirtyStyleSheets
		{
			get
			{
				if(r_MDirtyStyleSheets == null)
				{
					r_MDirtyStyleSheets = new(this, "DirtyStyleSheets", 0);
					r_MDirtyStyleSheets.SetBelong(this.instance);
				}
				return r_MDirtyStyleSheets;
			}
		}

		/// <summary>
		/// Void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUpdateInlineStylesRecursively_VisualElement;
		public virtual RMethod RMUpdateInlineStylesRecursively_VisualElement
		{
			get
			{
				if(r_MUpdateInlineStylesRecursively_VisualElement == null)
				{
					r_MUpdateInlineStylesRecursively_VisualElement = new(this, "UpdateInlineStylesRecursively", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MUpdateInlineStylesRecursively_VisualElement.SetBelong(this.instance);
				}
				return r_MUpdateInlineStylesRecursively_VisualElement;
			}
		}

		/// <summary>
		/// Void RequestUpdateAfterExternalEvent(UnityEngine.UIElements.IVisualTreeUpdater)
		/// </summary>
		protected RMethod r_MRequestUpdateAfterExternalEvent_IVisualTreeUpdater;
		public virtual RMethod RMRequestUpdateAfterExternalEvent_IVisualTreeUpdater
		{
			get
			{
				if(r_MRequestUpdateAfterExternalEvent_IVisualTreeUpdater == null)
				{
					r_MRequestUpdateAfterExternalEvent_IVisualTreeUpdater = new(this, "RequestUpdateAfterExternalEvent", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"));
					r_MRequestUpdateAfterExternalEvent_IVisualTreeUpdater.SetBelong(this.instance);
				}
				return r_MRequestUpdateAfterExternalEvent_IVisualTreeUpdater;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MOnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod RMOnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_MOnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_MOnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_MOnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void SetUpdater(UnityEngine.UIElements.IVisualTreeUpdater, UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RMSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase == null)
				{
					r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase = new(this, "SetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IVisualTreeUpdater"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase_DispatchMode;
		public virtual RMethod RMSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_MSendEvent_EventBase_DispatchMode == null)
				{
					r_MSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_MSendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MPick_Vector2;
		public virtual RMethod RMPick_Vector2
		{
			get
			{
				if(r_MPick_Vector2 == null)
				{
					r_MPick_Vector2 = new(this, "Pick", 0, typeof(UnityEngine.Vector2));
					r_MPick_Vector2.SetBelong(this.instance);
				}
				return r_MPick_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2, System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MPickAll_Vector2_List_d_VisualElement_p_;
		public virtual RMethod RMPickAll_Vector2_List_d_VisualElement_p_
		{
			get
			{
				if(r_MPickAll_Vector2_List_d_VisualElement_p_ == null)
				{
					r_MPickAll_Vector2_List_d_VisualElement_p_ = new(this, "PickAll", 0, typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MPickAll_Vector2_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MPickAll_Vector2_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase)
		/// </summary>
		protected RMethod r_MGetUpdater_VisualTreeUpdatePhase;
		public virtual RMethod RMGetUpdater_VisualTreeUpdatePhase
		{
			get
			{
				if(r_MGetUpdater_VisualTreeUpdatePhase == null)
				{
					r_MGetUpdater_VisualTreeUpdatePhase = new(this, "GetUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_MGetUpdater_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_MGetUpdater_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater GetEditorUpdater(UnityEngine.UIElements.VisualTreeEditorUpdatePhase)
		/// </summary>
		protected RMethod r_MGetEditorUpdater_VisualTreeEditorUpdatePhase;
		public virtual RMethod RMGetEditorUpdater_VisualTreeEditorUpdatePhase
		{
			get
			{
				if(r_MGetEditorUpdater_VisualTreeEditorUpdatePhase == null)
				{
					r_MGetEditorUpdater_VisualTreeEditorUpdatePhase = new(this, "GetEditorUpdater", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeEditorUpdatePhase"));
					r_MGetEditorUpdater_VisualTreeEditorUpdatePhase.SetBelong(this.instance);
				}
				return r_MGetEditorUpdater_VisualTreeEditorUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(Int32)
		/// </summary>
		protected RMethod r_MGetTopElementUnderPointer_Int32;
		public virtual RMethod RMGetTopElementUnderPointer_Int32
		{
			get
			{
				if(r_MGetTopElementUnderPointer_Int32 == null)
				{
					r_MGetTopElementUnderPointer_Int32 = new(this, "GetTopElementUnderPointer", 0, typeof(System.Int32));
					r_MGetTopElementUnderPointer_Int32.SetBelong(this.instance);
				}
				return r_MGetTopElementUnderPointer_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(Int32, UnityEngine.Vector2, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MRecomputeTopElementUnderPointer_Int32_Vector2_EventBase;
		public virtual RMethod RMRecomputeTopElementUnderPointer_Int32_Vector2_EventBase
		{
			get
			{
				if(r_MRecomputeTopElementUnderPointer_Int32_Vector2_EventBase == null)
				{
					r_MRecomputeTopElementUnderPointer_Int32_Vector2_EventBase = new(this, "RecomputeTopElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.UIElements.EventBase));
					r_MRecomputeTopElementUnderPointer_Int32_Vector2_EventBase.SetBelong(this.instance);
				}
				return r_MRecomputeTopElementUnderPointer_Int32_Vector2_EventBase;
			}
		}

		/// <summary>
		/// Void ClearCachedElementUnderPointer(Int32, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MClearCachedElementUnderPointer_Int32_EventBase;
		public virtual RMethod RMClearCachedElementUnderPointer_Int32_EventBase
		{
			get
			{
				if(r_MClearCachedElementUnderPointer_Int32_EventBase == null)
				{
					r_MClearCachedElementUnderPointer_Int32_EventBase = new(this, "ClearCachedElementUnderPointer", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.EventBase));
					r_MClearCachedElementUnderPointer_Int32_EventBase.SetBelong(this.instance);
				}
				return r_MClearCachedElementUnderPointer_Int32_EventBase;
			}
		}

		/// <summary>
		/// Void CommitElementUnderPointers()
		/// </summary>
		protected RMethod r_MCommitElementUnderPointers;
		public virtual RMethod RMCommitElementUnderPointers
		{
			get
			{
				if(r_MCommitElementUnderPointers == null)
				{
					r_MCommitElementUnderPointers = new(this, "CommitElementUnderPointers", 0);
					r_MCommitElementUnderPointers.SetBelong(this.instance);
				}
				return r_MCommitElementUnderPointers;
			}
		}

		/// <summary>
		/// Void InvokeStandardShaderChanged()
		/// </summary>
		protected RMethod r_MInvokeStandardShaderChanged;
		public virtual RMethod RMInvokeStandardShaderChanged
		{
			get
			{
				if(r_MInvokeStandardShaderChanged == null)
				{
					r_MInvokeStandardShaderChanged = new(this, "InvokeStandardShaderChanged", 0);
					r_MInvokeStandardShaderChanged.SetBelong(this.instance);
				}
				return r_MInvokeStandardShaderChanged;
			}
		}

		/// <summary>
		/// Void InvokeStandardWorldSpaceShaderChanged()
		/// </summary>
		protected RMethod r_MInvokeStandardWorldSpaceShaderChanged;
		public virtual RMethod RMInvokeStandardWorldSpaceShaderChanged
		{
			get
			{
				if(r_MInvokeStandardWorldSpaceShaderChanged == null)
				{
					r_MInvokeStandardWorldSpaceShaderChanged = new(this, "InvokeStandardWorldSpaceShaderChanged", 0);
					r_MInvokeStandardWorldSpaceShaderChanged.SetBelong(this.instance);
				}
				return r_MInvokeStandardWorldSpaceShaderChanged;
			}
		}

		/// <summary>
		/// Void InvokeAtlasChanged()
		/// </summary>
		protected RMethod r_MInvokeAtlasChanged;
		public virtual RMethod RMInvokeAtlasChanged
		{
			get
			{
				if(r_MInvokeAtlasChanged == null)
				{
					r_MInvokeAtlasChanged = new(this, "InvokeAtlasChanged", 0);
					r_MInvokeAtlasChanged.SetBelong(this.instance);
				}
				return r_MInvokeAtlasChanged;
			}
		}

		/// <summary>
		/// Void InvokeUpdateMaterial(UnityEngine.Material)
		/// </summary>
		protected RMethod r_MInvokeUpdateMaterial_Material;
		public virtual RMethod RMInvokeUpdateMaterial_Material
		{
			get
			{
				if(r_MInvokeUpdateMaterial_Material == null)
				{
					r_MInvokeUpdateMaterial_Material = new(this, "InvokeUpdateMaterial", 0, typeof(UnityEngine.Material));
					r_MInvokeUpdateMaterial_Material.SetBelong(this.instance);
				}
				return r_MInvokeUpdateMaterial_Material;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_MInvokeHierarchyChanged_VisualElement_HierarchyChangeType;
		public virtual RMethod RMInvokeHierarchyChanged_VisualElement_HierarchyChangeType
		{
			get
			{
				if(r_MInvokeHierarchyChanged_VisualElement_HierarchyChangeType == null)
				{
					r_MInvokeHierarchyChanged_VisualElement_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_MInvokeHierarchyChanged_VisualElement_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_MInvokeHierarchyChanged_VisualElement_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Void InvokeBeforeUpdate()
		/// </summary>
		protected RMethod r_MInvokeBeforeUpdate;
		public virtual RMethod RMInvokeBeforeUpdate
		{
			get
			{
				if(r_MInvokeBeforeUpdate == null)
				{
					r_MInvokeBeforeUpdate = new(this, "InvokeBeforeUpdate", 0);
					r_MInvokeBeforeUpdate.SetBelong(this.instance);
				}
				return r_MInvokeBeforeUpdate;
			}
		}

		/// <summary>
		/// Void UpdateElementUnderPointers()
		/// </summary>
		protected RMethod r_MUpdateElementUnderPointers;
		public virtual RMethod RMUpdateElementUnderPointers
		{
			get
			{
				if(r_MUpdateElementUnderPointers == null)
				{
					r_MUpdateElementUnderPointers = new(this, "UpdateElementUnderPointers", 0);
					r_MUpdateElementUnderPointers.SetBelong(this.instance);
				}
				return r_MUpdateElementUnderPointers;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IGroupBox.OnOptionAdded(UnityEngine.UIElements.IGroupBoxOption)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption == null)
				{
					r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption = new(this, "UnityEngine.UIElements.IGroupBox.OnOptionAdded", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IGroupBoxOption"));
					r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(UnityEngine.UIElements.IGroupBoxOption)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption == null)
				{
					r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption = new(this, "UnityEngine.UIElements.IGroupBox.OnOptionRemoved", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IGroupBoxOption"));
					r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption;
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
					r_MUpdate.SetBelong(this.instance);
				}
				return r_MUpdate;
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
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Repaint(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMRepaint_Event.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateLayout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBindings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateBindings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAssetTrackers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateAssetTrackers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DirtyStyleSheets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDirtyStyleSheets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement @root)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root};
            var ___result = RMUpdateInlineStylesRecursively_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestUpdateAfterExternalEvent(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater @updater)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updater.Value};
            var ___result = RMRequestUpdateAfterExternalEvent_IVisualTreeUpdater.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ele, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @changeTypeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ele, @changeTypeFlag.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater @updater, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updater.Value, @phase.Value};
            var ___result = RMSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMPick_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RMPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater GetUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RMGetUpdater_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater GetEditorUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RMGetEditorUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMGetTopElementUnderPointer_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(System.Int32 @pointerId, UnityEngine.Vector2 @pointerPos, UnityEngine.UIElements.EventBase @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @pointerPos, @triggerEvent};
            var ___result = RMRecomputeTopElementUnderPointer_Int32_Vector2_EventBase.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void ClearCachedElementUnderPointer(System.Int32 @pointerId, UnityEngine.UIElements.EventBase @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @triggerEvent};
            var ___result = RMClearCachedElementUnderPointer_Int32_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CommitElementUnderPointers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCommitElementUnderPointers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeStandardShaderChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvokeStandardShaderChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeStandardWorldSpaceShaderChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvokeStandardWorldSpaceShaderChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeAtlasChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvokeAtlasChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeUpdateMaterial(UnityEngine.Material @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mat};
            var ___result = RMInvokeUpdateMaterial_Material.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHierarchyChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @changeType.Value};
            var ___result = RMInvokeHierarchyChanged_VisualElement_HierarchyChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeBeforeUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvokeBeforeUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateElementUnderPointers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateElementUnderPointers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIGroupBoxOption @option)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@option.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionAdded_IGroupBoxOption.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIGroupBoxOption @option)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@option.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IGroupBox__2__OnOptionRemoved_IGroupBoxOption.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
