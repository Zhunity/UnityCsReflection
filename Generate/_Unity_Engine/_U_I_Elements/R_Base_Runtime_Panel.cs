
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BaseRuntimePanel
	/// </summary>
    public partial class RBaseRuntimePanel : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel");
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


		/// <summary>
		/// System.Action destroyed
		/// </summary>
		protected REvent r_Edestroyed;
		public virtual REvent REdestroyed
		{
			get
			{
				if(r_Edestroyed == null)
				{
					r_Edestroyed = new(this, "destroyed");
				}
				return r_Edestroyed;
			}
		}

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
				}
				return r_EbeforeUpdate;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_SelectableGameObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGameObject r_Fm_SelectableGameObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGameObject RFm_SelectableGameObject
		{
			get
			{
				if(r_Fm_SelectableGameObject == null)
				{
					r_Fm_SelectableGameObject = new(this, "m_SelectableGameObject");
				}
				return r_Fm_SelectableGameObject;
			}
		}

		/// <summary>
		/// System.Int32 s_CurrentRuntimePanelCounter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_CurrentRuntimePanelCounter;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_CurrentRuntimePanelCounter
		{
			get
			{
				if(r_Fs_CurrentRuntimePanelCounter == null)
				{
					r_Fs_CurrentRuntimePanelCounter = new( ReflectionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"), "s_CurrentRuntimePanelCounter");
				}
				return r_Fs_CurrentRuntimePanelCounter;
			}
		}

		/// <summary>
		/// System.Int32 m_RuntimePanelCreationIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_RuntimePanelCreationIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_RuntimePanelCreationIndex
		{
			get
			{
				if(r_Fm_RuntimePanelCreationIndex == null)
				{
					r_Fm_RuntimePanelCreationIndex = new(this, "m_RuntimePanelCreationIndex");
				}
				return r_Fm_RuntimePanelCreationIndex;
			}
		}

		/// <summary>
		/// System.Single m_SortingPriority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_SortingPriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_SortingPriority
		{
			get
			{
				if(r_Fm_SortingPriority == null)
				{
					r_Fm_SortingPriority = new(this, "m_SortingPriority");
				}
				return r_Fm_SortingPriority;
			}
		}

		/// <summary>
		/// System.Int32 resolvedSortingIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FresolvedSortingIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFresolvedSortingIndex
		{
			get
			{
				if(r_FresolvedSortingIndex == null)
				{
					r_FresolvedSortingIndex = new(this, "resolvedSortingIndex");
				}
				return r_FresolvedSortingIndex;
			}
		}

		/// <summary>
		/// System.Action destroyed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_Fdestroyed;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFdestroyed
		{
			get
			{
				if(r_Fdestroyed == null)
				{
					r_Fdestroyed = new(this, "destroyed");
				}
				return r_Fdestroyed;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_StandardWorldSpaceShader
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RShader r_Fm_StandardWorldSpaceShader;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RShader RFm_StandardWorldSpaceShader
		{
			get
			{
				if(r_Fm_StandardWorldSpaceShader == null)
				{
					r_Fm_StandardWorldSpaceShader = new(this, "m_StandardWorldSpaceShader");
				}
				return r_Fm_StandardWorldSpaceShader;
			}
		}

		/// <summary>
		/// System.Boolean m_DrawToCameras
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DrawToCameras;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DrawToCameras
		{
			get
			{
				if(r_Fm_DrawToCameras == null)
				{
					r_Fm_DrawToCameras = new(this, "m_DrawToCameras");
				}
				return r_Fm_DrawToCameras;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture targetTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_FtargetTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RFtargetTexture
		{
			get
			{
				if(r_FtargetTexture == null)
				{
					r_FtargetTexture = new(this, "targetTexture");
				}
				return r_FtargetTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 panelToWorld
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FpanelToWorld;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFpanelToWorld
		{
			get
			{
				if(r_FpanelToWorld == null)
				{
					r_FpanelToWorld = new(this, "panelToWorld");
				}
				return r_FpanelToWorld;
			}
		}

		/// <summary>
		/// System.Int32 <targetDisplay>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__targetDisplay__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__targetDisplay__1__k__BackingField
		{
			get
			{
				if(r_F__0__targetDisplay__1__k__BackingField == null)
				{
					r_F__0__targetDisplay__1__k__BackingField = new(this, "<targetDisplay>k__BackingField");
				}
				return r_F__0__targetDisplay__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Vector2,UnityEngine.Vector2] DefaultScreenToPanelSpace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RVector2, Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_FDefaultScreenToPanelSpace;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RVector2, Hvak.Editor.Refleaction.RUnityEngine.RVector2> RFDefaultScreenToPanelSpace
		{
			get
			{
				if(r_FDefaultScreenToPanelSpace == null)
				{
					r_FDefaultScreenToPanelSpace = new( ReflectionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"), "DefaultScreenToPanelSpace");
				}
				return r_FDefaultScreenToPanelSpace;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Vector2,UnityEngine.Vector2] m_ScreenToPanelSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RVector2, Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_Fm_ScreenToPanelSpace;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RVector2, Hvak.Editor.Refleaction.RUnityEngine.RVector2> RFm_ScreenToPanelSpace
		{
			get
			{
				if(r_Fm_ScreenToPanelSpace == null)
				{
					r_Fm_ScreenToPanelSpace = new(this, "m_ScreenToPanelSpace");
				}
				return r_Fm_ScreenToPanelSpace;
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
				}
				return r_FyogaConfig;
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
				}
				return r_Fm_TopElementUnderPointers;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject selectableGameObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGameObject r_PselectableGameObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGameObject RPselectableGameObject
		{
			get
			{
				if(r_PselectableGameObject == null)
				{
					r_PselectableGameObject = new(this, "selectableGameObject", -1);
				}
				return r_PselectableGameObject;
			}
		}

		/// <summary>
		/// Single sortingPriority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsortingPriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsortingPriority
		{
			get
			{
				if(r_PsortingPriority == null)
				{
					r_PsortingPriority = new(this, "sortingPriority", -1);
				}
				return r_PsortingPriority;
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
				}
				return r_PstandardWorldSpaceShader;
			}
		}

		/// <summary>
		/// Boolean drawToCameras
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdrawToCameras;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdrawToCameras
		{
			get
			{
				if(r_PdrawToCameras == null)
				{
					r_PdrawToCameras = new(this, "drawToCameras", -1);
				}
				return r_PdrawToCameras;
			}
		}

		/// <summary>
		/// Int32 targetDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtargetDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtargetDisplay
		{
			get
			{
				if(r_PtargetDisplay == null)
				{
					r_PtargetDisplay = new(this, "targetDisplay", -1);
				}
				return r_PtargetDisplay;
			}
		}

		/// <summary>
		/// Int32 screenRenderingWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PscreenRenderingWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPscreenRenderingWidth
		{
			get
			{
				if(r_PscreenRenderingWidth == null)
				{
					r_PscreenRenderingWidth = new(this, "screenRenderingWidth", -1);
				}
				return r_PscreenRenderingWidth;
			}
		}

		/// <summary>
		/// Int32 screenRenderingHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PscreenRenderingHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPscreenRenderingHeight
		{
			get
			{
				if(r_PscreenRenderingHeight == null)
				{
					r_PscreenRenderingHeight = new(this, "screenRenderingHeight", -1);
				}
				return r_PscreenRenderingHeight;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.Vector2,UnityEngine.Vector2] screenToPanelSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RVector2, Hvak.Editor.Refleaction.RUnityEngine.RVector2> r_PscreenToPanelSpace;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RVector2, Hvak.Editor.Refleaction.RUnityEngine.RVector2> RPscreenToPanelSpace
		{
			get
			{
				if(r_PscreenToPanelSpace == null)
				{
					r_PscreenToPanelSpace = new(this, "screenToPanelSpace", -1);
				}
				return r_PscreenToPanelSpace;
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
				}
				return r_Pdispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimerEventScheduler timerEventScheduler
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimerEventScheduler r_PtimerEventScheduler;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimerEventScheduler RPtimerEventScheduler
		{
			get
			{
				if(r_PtimerEventScheduler == null)
				{
					r_PtimerEventScheduler = new(this, "timerEventScheduler", -1);
				}
				return r_PtimerEventScheduler;
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
				}
				return r_Pscheduler;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeUpdater visualTreeUpdater
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdater r_PvisualTreeUpdater;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdater RPvisualTreeUpdater
		{
			get
			{
				if(r_PvisualTreeUpdater == null)
				{
					r_PvisualTreeUpdater = new(this, "visualTreeUpdater", -1);
				}
				return r_PvisualTreeUpdater;
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
				}
				return r_PstyleAnimationSystem;
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
				}
				return r_PownerObject;
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
				}
				return r_PcontextType;
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
				}
				return r_PgetViewDataDictionary;
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
				}
				return r_PfocusController;
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
				}
				return r_PIMGUIEventInterests;
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
				}
				return r_PIMGUIContainersCount;
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
				}
				return r_ProotIMGUIContainer;
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
				}
				return r_PhierarchyVersion;
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
				}
				return r_PstandardShader;
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
				}
				return r_Patlas;
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
				}
				return r_PisDirty;
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
				}
				return r_PcontextualMenuManager;
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
				}
				return r_Pdisposed;
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
				}
				return r_PliveReloadSystem;
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
				}
				return r_MRepaint_Event;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MScreenToPanel_Vector2;
		public virtual RMethod RMScreenToPanel_Vector2
		{
			get
			{
				if(r_MScreenToPanel_Vector2 == null)
				{
					r_MScreenToPanel_Vector2 = new(this, "ScreenToPanel", 0, typeof(UnityEngine.Vector2));
				}
				return r_MScreenToPanel_Vector2;
			}
		}

		/// <summary>
		/// Boolean ScreenToPanel(UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef, Boolean)
		/// </summary>
		protected RMethod r_MScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean;
		public virtual RMethod RMScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean
		{
			get
			{
				if(r_MScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean == null)
				{
					r_MScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean = new(this, "ScreenToPanel", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel)
		/// </summary>
		protected RMethod r_MAssignPanelToComponents_BaseRuntimePanel;
		public virtual RMethod RMAssignPanelToComponents_BaseRuntimePanel
		{
			get
			{
				if(r_MAssignPanelToComponents_BaseRuntimePanel == null)
				{
					r_MAssignPanelToComponents_BaseRuntimePanel = new(this, "AssignPanelToComponents", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseRuntimePanel"));
				}
				return r_MAssignPanelToComponents_BaseRuntimePanel;
			}
		}

		/// <summary>
		/// Void PointerLeavesPanel(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MPointerLeavesPanel_Int32_Vector2;
		public virtual RMethod RMPointerLeavesPanel_Int32_Vector2
		{
			get
			{
				if(r_MPointerLeavesPanel_Int32_Vector2 == null)
				{
					r_MPointerLeavesPanel_Int32_Vector2 = new(this, "PointerLeavesPanel", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MPointerLeavesPanel_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void PointerEntersPanel(Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MPointerEntersPanel_Int32_Vector2;
		public virtual RMethod RMPointerEntersPanel_Int32_Vector2
		{
			get
			{
				if(r_MPointerEntersPanel_Int32_Vector2 == null)
				{
					r_MPointerEntersPanel_Int32_Vector2 = new(this, "PointerEntersPanel", 0, typeof(System.Int32), typeof(UnityEngine.Vector2));
				}
				return r_MPointerEntersPanel_Int32_Vector2;
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
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_MBlur;
		public virtual RMethod RMBlur
		{
			get
			{
				if(r_MBlur == null)
				{
					r_MBlur = new(this, "Blur", 0);
				}
				return r_MBlur;
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
				}
				return r_MValidateFocus;
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
				}
				return r_MPickAll_Vector2_List_d_VisualElement_p_;
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
				}
				return r_MPick_Vector2;
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
				}
				return r_MUpdateAssetTrackers;
			}
		}

		/// <summary>
		/// Void UpdateWithoutRepaint()
		/// </summary>
		protected RMethod r_MUpdateWithoutRepaint;
		public virtual RMethod RMUpdateWithoutRepaint
		{
			get
			{
				if(r_MUpdateWithoutRepaint == null)
				{
					r_MUpdateWithoutRepaint = new(this, "UpdateWithoutRepaint", 0);
				}
				return r_MUpdateWithoutRepaint;
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
				}
				return r_MDirtyStyleSheets;
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
				}
				return r_MGetEditorUpdater_VisualTreeEditorUpdatePhase;
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
				}
				return r_MSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase;
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
				}
				return r_MGetUpdater_VisualTreeUpdatePhase;
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
				}
				return r_MDispose;
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
				}
				return r_MSendEvent_EventBase_DispatchMode;
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
				}
				return r_MUpdateElementUnderPointers;
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


        public virtual UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2 @screen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screen};
            var ___result = RMScreenToPanel_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Boolean ScreenToPanel(UnityEngine.Vector2 @screenPosition, UnityEngine.Vector2 @screenDelta, out UnityEngine.Vector2 @panelPosition, out UnityEngine.Vector2 @panelDelta, System.Boolean @allowOutside)
        {
			@panelPosition = default;
			@panelDelta = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenPosition, @screenDelta, @panelPosition, @panelDelta, @allowOutside};
            var ___result = RMScreenToPanel_Vector2_Vector2_Out_Vector2_Out_Vector2_Boolean.Invoke(___genericsType, ___parameters);
			@panelPosition = (UnityEngine.Vector2)___parameters[2];
			@panelDelta = (UnityEngine.Vector2)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual void AssignPanelToComponents(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseRuntimePanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel.Value};
            var ___result = RMAssignPanelToComponents_BaseRuntimePanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PointerLeavesPanel(System.Int32 @pointerId, UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @position};
            var ___result = RMPointerLeavesPanel_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PointerEntersPanel(System.Int32 @pointerId, UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @position};
            var ___result = RMPointerEntersPanel_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RMPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMPick_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
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


        public virtual void UpdateWithoutRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWithoutRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DirtyStyleSheets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDirtyStyleSheets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater GetEditorUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeEditorUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RMGetEditorUpdater_VisualTreeEditorUpdatePhase.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
        }


        public virtual void UpdateInlineStylesRecursively(UnityEngine.UIElements.VisualElement @rootElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootElement};
            var ___result = RMUpdateInlineStylesRecursively_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestUpdateAfterExternalEvent(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater @updater)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updater.Value};
            var ___result = RMRequestUpdateAfterExternalEvent_IVisualTreeUpdater.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @versionChangeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @versionChangeType.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater @updater, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updater.Value, @phase.Value};
            var ___result = RMSetUpdater_IVisualTreeUpdater_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater GetUpdater(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeUpdatePhase @phase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@phase.Value};
            var ___result = RMGetUpdater_VisualTreeUpdatePhase.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualTreeUpdater(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
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
