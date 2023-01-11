using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.OverlayCanvas
	/// </summary>
    public partial class ROverlayCanvas : RMember //
    {

		/// <summary>
		/// System.Action`1[System.Boolean] overlaysEnabledChanged
		/// </summary>
		protected REvent r_overlaysEnabledChanged;
		public virtual REvent RoverlaysEnabledChanged
		{
			get
			{
				if(r_overlaysEnabledChanged == null)
				{
					r_overlaysEnabledChanged = new(this, "overlaysEnabledChanged");
					r_overlaysEnabledChanged.SetBelong(this.instance);
				}
				return r_overlaysEnabledChanged;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RSystem.RString r_ussClassName;
		public static RSystem.RString RussClassName
		{
			get
			{
				if(r_ussClassName == null)
				{
					r_ussClassName = new(typeof(UnityEditor.Overlays.OverlayCanvas), "ussClassName");
					r_ussClassName.SetBelong(null);
				}
				return r_ussClassName;
			}
		}

		/// <summary>
		/// System.String k_UxmlPath
		/// </summary>
		protected static RSystem.RString r_k_UxmlPath;
		public static RSystem.RString Rk_UxmlPath
		{
			get
			{
				if(r_k_UxmlPath == null)
				{
					r_k_UxmlPath = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_UxmlPath");
					r_k_UxmlPath.SetBelong(null);
				}
				return r_k_UxmlPath;
			}
		}

		/// <summary>
		/// System.String k_UxmlPathDropZone
		/// </summary>
		protected static RSystem.RString r_k_UxmlPathDropZone;
		public static RSystem.RString Rk_UxmlPathDropZone
		{
			get
			{
				if(r_k_UxmlPathDropZone == null)
				{
					r_k_UxmlPathDropZone = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_UxmlPathDropZone");
					r_k_UxmlPathDropZone.SetBelong(null);
				}
				return r_k_UxmlPathDropZone;
			}
		}

		/// <summary>
		/// System.String k_StyleCommon
		/// </summary>
		protected static RSystem.RString r_k_StyleCommon;
		public static RSystem.RString Rk_StyleCommon
		{
			get
			{
				if(r_k_StyleCommon == null)
				{
					r_k_StyleCommon = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_StyleCommon");
					r_k_StyleCommon.SetBelong(null);
				}
				return r_k_StyleCommon;
			}
		}

		/// <summary>
		/// System.String k_StyleLight
		/// </summary>
		protected static RSystem.RString r_k_StyleLight;
		public static RSystem.RString Rk_StyleLight
		{
			get
			{
				if(r_k_StyleLight == null)
				{
					r_k_StyleLight = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_StyleLight");
					r_k_StyleLight.SetBelong(null);
				}
				return r_k_StyleLight;
			}
		}

		/// <summary>
		/// System.String k_StyleDark
		/// </summary>
		protected static RSystem.RString r_k_StyleDark;
		public static RSystem.RString Rk_StyleDark
		{
			get
			{
				if(r_k_StyleDark == null)
				{
					r_k_StyleDark = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_StyleDark");
					r_k_StyleDark.SetBelong(null);
				}
				return r_k_StyleDark;
			}
		}

		/// <summary>
		/// System.Int32 k_ContainerCount
		/// </summary>
		protected static RSystem.RInt32 r_k_ContainerCount;
		public static RSystem.RInt32 Rk_ContainerCount
		{
			get
			{
				if(r_k_ContainerCount == null)
				{
					r_k_ContainerCount = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_ContainerCount");
					r_k_ContainerCount.SetBelong(null);
				}
				return r_k_ContainerCount;
			}
		}

		/// <summary>
		/// System.String k_FloatingContainer
		/// </summary>
		protected static RSystem.RString r_k_FloatingContainer;
		public static RSystem.RString Rk_FloatingContainer
		{
			get
			{
				if(r_k_FloatingContainer == null)
				{
					r_k_FloatingContainer = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_FloatingContainer");
					r_k_FloatingContainer.SetBelong(null);
				}
				return r_k_FloatingContainer;
			}
		}

		/// <summary>
		/// System.String k_ToolbarZone
		/// </summary>
		protected static RSystem.RString r_k_ToolbarZone;
		public static RSystem.RString Rk_ToolbarZone
		{
			get
			{
				if(r_k_ToolbarZone == null)
				{
					r_k_ToolbarZone = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_ToolbarZone");
					r_k_ToolbarZone.SetBelong(null);
				}
				return r_k_ToolbarZone;
			}
		}

		/// <summary>
		/// System.String k_ToolbarArea
		/// </summary>
		protected static RSystem.RString r_k_ToolbarArea;
		public static RSystem.RString Rk_ToolbarArea
		{
			get
			{
				if(r_k_ToolbarArea == null)
				{
					r_k_ToolbarArea = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_ToolbarArea");
					r_k_ToolbarArea.SetBelong(null);
				}
				return r_k_ToolbarArea;
			}
		}

		/// <summary>
		/// System.String k_DropTargetClassName
		/// </summary>
		protected static RSystem.RString r_k_DropTargetClassName;
		public static RSystem.RString Rk_DropTargetClassName
		{
			get
			{
				if(r_k_DropTargetClassName == null)
				{
					r_k_DropTargetClassName = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_DropTargetClassName");
					r_k_DropTargetClassName.SetBelong(null);
				}
				return r_k_DropTargetClassName;
			}
		}

		/// <summary>
		/// System.String k_GhostClassName
		/// </summary>
		protected static RSystem.RString r_k_GhostClassName;
		public static RSystem.RString Rk_GhostClassName
		{
			get
			{
				if(r_k_GhostClassName == null)
				{
					r_k_GhostClassName = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_GhostClassName");
					r_k_GhostClassName.SetBelong(null);
				}
				return r_k_GhostClassName;
			}
		}

		/// <summary>
		/// System.String k_GhostAreaHovered
		/// </summary>
		protected static RSystem.RString r_k_GhostAreaHovered;
		public static RSystem.RString Rk_GhostAreaHovered
		{
			get
			{
				if(r_k_GhostAreaHovered == null)
				{
					r_k_GhostAreaHovered = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_GhostAreaHovered");
					r_k_GhostAreaHovered.SetBelong(null);
				}
				return r_k_GhostAreaHovered;
			}
		}

		/// <summary>
		/// System.String k_DefaultContainer
		/// </summary>
		protected static RSystem.RString r_k_DefaultContainer;
		public static RSystem.RString Rk_DefaultContainer
		{
			get
			{
				if(r_k_DefaultContainer == null)
				{
					r_k_DefaultContainer = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_DefaultContainer");
					r_k_DefaultContainer.SetBelong(null);
				}
				return r_k_DefaultContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset s_TreeAsset
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualTreeAsset r_s_TreeAsset;
		public static RUnityEngine.RUIElements.RVisualTreeAsset Rs_TreeAsset
		{
			get
			{
				if(r_s_TreeAsset == null)
				{
					r_s_TreeAsset = new(typeof(UnityEditor.Overlays.OverlayCanvas), "s_TreeAsset");
					r_s_TreeAsset.SetBelong(null);
				}
				return r_s_TreeAsset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset s_DropZoneTreeAsset
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualTreeAsset r_s_DropZoneTreeAsset;
		public static RUnityEngine.RUIElements.RVisualTreeAsset Rs_DropZoneTreeAsset
		{
			get
			{
				if(r_s_DropZoneTreeAsset == null)
				{
					r_s_DropZoneTreeAsset = new(typeof(UnityEditor.Overlays.OverlayCanvas), "s_DropZoneTreeAsset");
					r_s_DropZoneTreeAsset.SetBelong(null);
				}
				return r_s_DropZoneTreeAsset;
			}
		}

		/// <summary>
		/// System.String[] k_DockZoneContainerIDs
		/// </summary>
		protected static RFieldArray<RSystem.RString> r_k_DockZoneContainerIDs;
		public static RFieldArray<RSystem.RString> Rk_DockZoneContainerIDs
		{
			get
			{
				if(r_k_DockZoneContainerIDs == null)
				{
					r_k_DockZoneContainerIDs = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_DockZoneContainerIDs");
					r_k_DockZoneContainerIDs.SetBelong(null);
				}
				return r_k_DockZoneContainerIDs;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayMenu m_Menu
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayMenu r_m_Menu;
		public virtual RUnityEditor.ROverlays.ROverlayMenu Rm_Menu
		{
			get
			{
				if(r_m_Menu == null)
				{
					r_m_Menu = new(this, "m_Menu");
					r_m_Menu.SetBelong(this.instance);
				}
				return r_m_Menu;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.Overlay] m_Overlays
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.ROverlay> r_m_Overlays;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.ROverlay> Rm_Overlays
		{
			get
			{
				if(r_m_Overlays == null)
				{
					r_m_Overlays = new(this, "m_Overlays");
					r_m_Overlays.SetBelong(this.instance);
				}
				return r_m_Overlays;
			}
		}

		/// <summary>
		/// System.String m_LastAppliedPresetName
		/// </summary>
		protected RSystem.RString r_m_LastAppliedPresetName;
		public virtual RSystem.RString Rm_LastAppliedPresetName
		{
			get
			{
				if(r_m_LastAppliedPresetName == null)
				{
					r_m_LastAppliedPresetName = new(this, "m_LastAppliedPresetName");
					r_m_LastAppliedPresetName.SetBelong(this.instance);
				}
				return r_m_LastAppliedPresetName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.SaveData] m_SaveData
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.RSaveData> r_m_SaveData;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.RSaveData> Rm_SaveData
		{
			get
			{
				if(r_m_SaveData == null)
				{
					r_m_SaveData = new(this, "m_SaveData");
					r_m_SaveData.SetBelong(this.instance);
				}
				return r_m_SaveData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_RootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_RootVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_RootVisualElement
		{
			get
			{
				if(r_m_RootVisualElement == null)
				{
					r_m_RootVisualElement = new(this, "m_RootVisualElement");
					r_m_RootVisualElement.SetBelong(this.instance);
				}
				return r_m_RootVisualElement;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow <containerWindow>k__BackingField
		/// </summary>
		protected RUnityEditor.REditorWindow r___0__containerWindow__1__k__BackingField;
		public virtual RUnityEditor.REditorWindow R__0__containerWindow__1__k__BackingField
		{
			get
			{
				if(r___0__containerWindow__1__k__BackingField == null)
				{
					r___0__containerWindow__1__k__BackingField = new(this, "<containerWindow>k__BackingField");
					r___0__containerWindow__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__containerWindow__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.FloatingOverlayContainer m_FloatingOverlayContainer
		/// </summary>
		protected RUnityEditor.ROverlays.RFloatingOverlayContainer r_m_FloatingOverlayContainer;
		public virtual RUnityEditor.ROverlays.RFloatingOverlayContainer Rm_FloatingOverlayContainer
		{
			get
			{
				if(r_m_FloatingOverlayContainer == null)
				{
					r_m_FloatingOverlayContainer = new(this, "m_FloatingOverlayContainer");
					r_m_FloatingOverlayContainer.SetBelong(this.instance);
				}
				return r_m_FloatingOverlayContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Overlay m_HoveredOverlay
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlay r_m_HoveredOverlay;
		public virtual RUnityEditor.ROverlays.ROverlay Rm_HoveredOverlay
		{
			get
			{
				if(r_m_HoveredOverlay == null)
				{
					r_m_HoveredOverlay = new(this, "m_HoveredOverlay");
					r_m_HoveredOverlay.SetBelong(this.instance);
				}
				return r_m_HoveredOverlay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer <hoveredOverlayContainer>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r___0__hoveredOverlayContainer__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayContainer R__0__hoveredOverlayContainer__1__k__BackingField
		{
			get
			{
				if(r___0__hoveredOverlayContainer__1__k__BackingField == null)
				{
					r___0__hoveredOverlayContainer__1__k__BackingField = new(this, "<hoveredOverlayContainer>k__BackingField");
					r___0__hoveredOverlayContainer__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__hoveredOverlayContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer <defaultContainer>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r___0__defaultContainer__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayContainer R__0__defaultContainer__1__k__BackingField
		{
			get
			{
				if(r___0__defaultContainer__1__k__BackingField == null)
				{
					r___0__defaultContainer__1__k__BackingField = new(this, "<defaultContainer>k__BackingField");
					r___0__defaultContainer__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__defaultContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer <defaultToolbarContainer>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r___0__defaultToolbarContainer__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayContainer R__0__defaultToolbarContainer__1__k__BackingField
		{
			get
			{
				if(r___0__defaultToolbarContainer__1__k__BackingField == null)
				{
					r___0__defaultToolbarContainer__1__k__BackingField = new(this, "<defaultToolbarContainer>k__BackingField");
					r___0__defaultToolbarContainer__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__defaultToolbarContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.OverlayContainer] <containers>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.ROverlayContainer> r___0__containers__1__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.ROverlayContainer> R__0__containers__1__k__BackingField
		{
			get
			{
				if(r___0__containers__1__k__BackingField == null)
				{
					r___0__containers__1__k__BackingField = new(this, "<containers>k__BackingField");
					r___0__containers__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__containers__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.VisualElement,UnityEditor.Overlays.Overlay] m_OverlaysByVE
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RVisualElement, RUnityEditor.ROverlays.ROverlay> r_m_OverlaysByVE;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RVisualElement, RUnityEditor.ROverlays.ROverlay> Rm_OverlaysByVE
		{
			get
			{
				if(r_m_OverlaysByVE == null)
				{
					r_m_OverlaysByVE = new(this, "m_OverlaysByVE");
					r_m_OverlaysByVE.SetBelong(this.instance);
				}
				return r_m_OverlaysByVE;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_OriginGhost
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_OriginGhost;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_OriginGhost
		{
			get
			{
				if(r_m_OriginGhost == null)
				{
					r_m_OriginGhost = new(this, "m_OriginGhost");
					r_m_OriginGhost.SetBelong(this.instance);
				}
				return r_m_OriginGhost;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDestinationMarker <destinationMarker>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayDestinationMarker r___0__destinationMarker__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayDestinationMarker R__0__destinationMarker__1__k__BackingField
		{
			get
			{
				if(r___0__destinationMarker__1__k__BackingField == null)
				{
					r___0__destinationMarker__1__k__BackingField = new(this, "<destinationMarker>k__BackingField");
					r___0__destinationMarker__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__destinationMarker__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_WindowRoot
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_WindowRoot;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_WindowRoot
		{
			get
			{
				if(r_m_WindowRoot == null)
				{
					r_m_WindowRoot = new(this, "m_WindowRoot");
					r_m_WindowRoot.SetBelong(this.instance);
				}
				return r_m_WindowRoot;
			}
		}

		/// <summary>
		/// System.Action afterOverlaysInitialized
		/// </summary>
		protected RSystem.RAction r_afterOverlaysInitialized;
		public virtual RSystem.RAction RafterOverlaysInitialized
		{
			get
			{
				if(r_afterOverlaysInitialized == null)
				{
					r_afterOverlaysInitialized = new(this, "afterOverlaysInitialized");
					r_afterOverlaysInitialized.SetBelong(this.instance);
				}
				return r_afterOverlaysInitialized;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData defaultSaveData
		/// </summary>
		protected static RUnityEditor.ROverlays.RSaveData r_defaultSaveData;
		public static RUnityEditor.ROverlays.RSaveData RdefaultSaveData
		{
			get
			{
				if(r_defaultSaveData == null)
				{
					r_defaultSaveData = new(typeof(UnityEditor.Overlays.OverlayCanvas), "defaultSaveData", -1);
					r_defaultSaveData.SetBelong(null);
				}
				return r_defaultSaveData;
			}
		}

		/// <summary>
		/// System.String lastAppliedPresetName
		/// </summary>
		protected RSystem.RString r_lastAppliedPresetName;
		public virtual RSystem.RString RlastAppliedPresetName
		{
			get
			{
				if(r_lastAppliedPresetName == null)
				{
					r_lastAppliedPresetName = new(this, "lastAppliedPresetName", -1);
					r_lastAppliedPresetName.SetBelong(this.instance);
				}
				return r_lastAppliedPresetName;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow containerWindow
		/// </summary>
		protected RUnityEditor.REditorWindow r_containerWindow;
		public virtual RUnityEditor.REditorWindow RcontainerWindow
		{
			get
			{
				if(r_containerWindow == null)
				{
					r_containerWindow = new(this, "containerWindow", -1);
					r_containerWindow.SetBelong(this.instance);
				}
				return r_containerWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.FloatingOverlayContainer floatingContainer
		/// </summary>
		protected RUnityEditor.ROverlays.RFloatingOverlayContainer r_floatingContainer;
		public virtual RUnityEditor.ROverlays.RFloatingOverlayContainer RfloatingContainer
		{
			get
			{
				if(r_floatingContainer == null)
				{
					r_floatingContainer = new(this, "floatingContainer", -1);
					r_floatingContainer.SetBelong(this.instance);
				}
				return r_floatingContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayMenu menu
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayMenu r_menu;
		public virtual RUnityEditor.ROverlays.ROverlayMenu Rmenu
		{
			get
			{
				if(r_menu == null)
				{
					r_menu = new(this, "menu", -1);
					r_menu.SetBelong(this.instance);
				}
				return r_menu;
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
		/// UnityEditor.Overlays.Overlay hoveredOverlay
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlay r_hoveredOverlay;
		public virtual RUnityEditor.ROverlays.ROverlay RhoveredOverlay
		{
			get
			{
				if(r_hoveredOverlay == null)
				{
					r_hoveredOverlay = new(this, "hoveredOverlay", -1);
					r_hoveredOverlay.SetBelong(this.instance);
				}
				return r_hoveredOverlay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer hoveredOverlayContainer
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_hoveredOverlayContainer;
		public virtual RUnityEditor.ROverlays.ROverlayContainer RhoveredOverlayContainer
		{
			get
			{
				if(r_hoveredOverlayContainer == null)
				{
					r_hoveredOverlayContainer = new(this, "hoveredOverlayContainer", -1);
					r_hoveredOverlayContainer.SetBelong(this.instance);
				}
				return r_hoveredOverlayContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer defaultContainer
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_defaultContainer;
		public virtual RUnityEditor.ROverlays.ROverlayContainer RdefaultContainer
		{
			get
			{
				if(r_defaultContainer == null)
				{
					r_defaultContainer = new(this, "defaultContainer", -1);
					r_defaultContainer.SetBelong(this.instance);
				}
				return r_defaultContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer defaultToolbarContainer
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_defaultToolbarContainer;
		public virtual RUnityEditor.ROverlays.ROverlayContainer RdefaultToolbarContainer
		{
			get
			{
				if(r_defaultToolbarContainer == null)
				{
					r_defaultToolbarContainer = new(this, "defaultToolbarContainer", -1);
					r_defaultToolbarContainer.SetBelong(this.instance);
				}
				return r_defaultToolbarContainer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.OverlayContainer] containers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.ROverlayContainer> r_containers;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.ROverlays.ROverlayContainer> Rcontainers
		{
			get
			{
				if(r_containers == null)
				{
					r_containers = new(this, "containers", -1);
					r_containers.SetBelong(this.instance);
				}
				return r_containers;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDestinationMarker destinationMarker
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayDestinationMarker r_destinationMarker;
		public virtual RUnityEditor.ROverlays.ROverlayDestinationMarker RdestinationMarker
		{
			get
			{
				if(r_destinationMarker == null)
				{
					r_destinationMarker = new(this, "destinationMarker", -1);
					r_destinationMarker.SetBelong(this.instance);
				}
				return r_destinationMarker;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.Overlays.Overlay] overlays
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.ROverlays.ROverlay> r_overlays;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEditor.ROverlays.ROverlay> Roverlays
		{
			get
			{
				if(r_overlays == null)
				{
					r_overlays = new(this, "overlays", -1);
					r_overlays.SetBelong(this.instance);
				}
				return r_overlays;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement windowRoot
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_windowRoot;
		public virtual RUnityEngine.RUIElements.RVisualElement RwindowRoot
		{
			get
			{
				if(r_windowRoot == null)
				{
					r_windowRoot = new(this, "windowRoot", -1);
					r_windowRoot.SetBelong(this.instance);
				}
				return r_windowRoot;
			}
		}

		/// <summary>
		/// Boolean overlaysEnabled
		/// </summary>
		protected RSystem.RBoolean r_overlaysEnabled;
		public virtual RSystem.RBoolean RoverlaysEnabled
		{
			get
			{
				if(r_overlaysEnabled == null)
				{
					r_overlaysEnabled = new(this, "overlaysEnabled", -1);
					r_overlaysEnabled.SetBelong(this.instance);
				}
				return r_overlaysEnabled;
			}
		}

		/// <summary>
		/// Boolean menuVisible
		/// </summary>
		protected RSystem.RBoolean r_menuVisible;
		public virtual RSystem.RBoolean RmenuVisible
		{
			get
			{
				if(r_menuVisible == null)
				{
					r_menuVisible = new(this, "menuVisible", -1);
					r_menuVisible.SetBelong(this.instance);
				}
				return r_menuVisible;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone GetDockZone(UnityEditor.Overlays.OverlayContainer)
		/// </summary>
		protected static RMethod r_GetDockZone_OverlayContainer;
		public static RMethod RGetDockZone_OverlayContainer
		{
			get
			{
				if(r_GetDockZone_OverlayContainer == null)
				{
					r_GetDockZone_OverlayContainer = new(typeof(UnityEditor.Overlays.OverlayCanvas), "GetDockZone", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"));
					r_GetDockZone_OverlayContainer.SetBelong(null);
				}
				return r_GetDockZone_OverlayContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer GetDockZoneContainer(UnityEditor.Overlays.DockZone)
		/// </summary>
		protected RMethod r_GetDockZoneContainer_DockZone;
		public virtual RMethod RGetDockZoneContainer_DockZone
		{
			get
			{
				if(r_GetDockZoneContainer_DockZone == null)
				{
					r_GetDockZoneContainer_DockZone = new(this, "GetDockZoneContainer", 0, typeof(UnityEditor.Overlays.DockZone));
					r_GetDockZoneContainer_DockZone.SetBelong(this.instance);
				}
				return r_GetDockZoneContainer_DockZone;
			}
		}

		/// <summary>
		/// Void SetOverlaysEnabled(Boolean)
		/// </summary>
		protected RMethod r_SetOverlaysEnabled_Boolean;
		public virtual RMethod RSetOverlaysEnabled_Boolean
		{
			get
			{
				if(r_SetOverlaysEnabled_Boolean == null)
				{
					r_SetOverlaysEnabled_Boolean = new(this, "SetOverlaysEnabled", 0, typeof(System.Boolean));
					r_SetOverlaysEnabled_Boolean.SetBelong(this.instance);
				}
				return r_SetOverlaysEnabled_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateRoot()
		/// </summary>
		protected RMethod r_CreateRoot;
		public virtual RMethod RCreateRoot
		{
			get
			{
				if(r_CreateRoot == null)
				{
					r_CreateRoot = new(this, "CreateRoot", 0);
					r_CreateRoot.SetBelong(this.instance);
				}
				return r_CreateRoot;
			}
		}

		/// <summary>
		/// Void SetPickingMode(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.PickingMode)
		/// </summary>
		protected RMethod r_SetPickingMode_VisualElement_PickingMode;
		public virtual RMethod RSetPickingMode_VisualElement_PickingMode
		{
			get
			{
				if(r_SetPickingMode_VisualElement_PickingMode == null)
				{
					r_SetPickingMode_VisualElement_PickingMode = new(this, "SetPickingMode", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.PickingMode));
					r_SetPickingMode_VisualElement_PickingMode.SetBelong(this.instance);
				}
				return r_SetPickingMode_VisualElement_PickingMode;
			}
		}

		/// <summary>
		/// Void OnMouseEnterOverlayContainer(UnityEngine.UIElements.MouseEnterEvent)
		/// </summary>
		protected RMethod r_OnMouseEnterOverlayContainer_MouseEnterEvent;
		public virtual RMethod ROnMouseEnterOverlayContainer_MouseEnterEvent
		{
			get
			{
				if(r_OnMouseEnterOverlayContainer_MouseEnterEvent == null)
				{
					r_OnMouseEnterOverlayContainer_MouseEnterEvent = new(this, "OnMouseEnterOverlayContainer", 0, typeof(UnityEngine.UIElements.MouseEnterEvent));
					r_OnMouseEnterOverlayContainer_MouseEnterEvent.SetBelong(this.instance);
				}
				return r_OnMouseEnterOverlayContainer_MouseEnterEvent;
			}
		}

		/// <summary>
		/// Void OnAttachedToPanel(UnityEngine.UIElements.AttachToPanelEvent)
		/// </summary>
		protected RMethod r_OnAttachedToPanel_AttachToPanelEvent;
		public virtual RMethod ROnAttachedToPanel_AttachToPanelEvent
		{
			get
			{
				if(r_OnAttachedToPanel_AttachToPanelEvent == null)
				{
					r_OnAttachedToPanel_AttachToPanelEvent = new(this, "OnAttachedToPanel", 0, typeof(UnityEngine.UIElements.AttachToPanelEvent));
					r_OnAttachedToPanel_AttachToPanelEvent.SetBelong(this.instance);
				}
				return r_OnAttachedToPanel_AttachToPanelEvent;
			}
		}

		/// <summary>
		/// Void OnDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent)
		/// </summary>
		protected RMethod r_OnDetachedFromPanel_DetachFromPanelEvent;
		public virtual RMethod ROnDetachedFromPanel_DetachFromPanelEvent
		{
			get
			{
				if(r_OnDetachedFromPanel_DetachFromPanelEvent == null)
				{
					r_OnDetachedFromPanel_DetachFromPanelEvent = new(this, "OnDetachedFromPanel", 0, typeof(UnityEngine.UIElements.DetachFromPanelEvent));
					r_OnDetachedFromPanel_DetachFromPanelEvent.SetBelong(this.instance);
				}
				return r_OnDetachedFromPanel_DetachFromPanelEvent;
			}
		}

		/// <summary>
		/// Void OnContainerWindowDisabled()
		/// </summary>
		protected RMethod r_OnContainerWindowDisabled;
		public virtual RMethod ROnContainerWindowDisabled
		{
			get
			{
				if(r_OnContainerWindowDisabled == null)
				{
					r_OnContainerWindowDisabled = new(this, "OnContainerWindowDisabled", 0);
					r_OnContainerWindowDisabled.SetBelong(this.instance);
				}
				return r_OnContainerWindowDisabled;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ClampToOverlayWindow(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ClampToOverlayWindow_Rect;
		public virtual RMethod RClampToOverlayWindow_Rect
		{
			get
			{
				if(r_ClampToOverlayWindow_Rect == null)
				{
					r_ClampToOverlayWindow_Rect = new(this, "ClampToOverlayWindow", 0, typeof(UnityEngine.Rect));
					r_ClampToOverlayWindow_Rect.SetBelong(this.instance);
				}
				return r_ClampToOverlayWindow_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ClampRectToBounds(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_ClampRectToBounds_Rect_Rect;
		public static RMethod RClampRectToBounds_Rect_Rect
		{
			get
			{
				if(r_ClampRectToBounds_Rect_Rect == null)
				{
					r_ClampRectToBounds_Rect_Rect = new(typeof(UnityEditor.Overlays.OverlayCanvas), "ClampRectToBounds", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_ClampRectToBounds_Rect_Rect.SetBelong(null);
				}
				return r_ClampRectToBounds_Rect_Rect;
			}
		}

		/// <summary>
		/// Void GeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_GeometryChanged_GeometryChangedEvent;
		public virtual RMethod RGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_GeometryChanged_GeometryChangedEvent == null)
				{
					r_GeometryChanged_GeometryChangedEvent = new(this, "GeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_GeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_GeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnMouseLeaveOverlay(UnityEngine.UIElements.MouseLeaveEvent)
		/// </summary>
		protected RMethod r_OnMouseLeaveOverlay_MouseLeaveEvent;
		public virtual RMethod ROnMouseLeaveOverlay_MouseLeaveEvent
		{
			get
			{
				if(r_OnMouseLeaveOverlay_MouseLeaveEvent == null)
				{
					r_OnMouseLeaveOverlay_MouseLeaveEvent = new(this, "OnMouseLeaveOverlay", 0, typeof(UnityEngine.UIElements.MouseLeaveEvent));
					r_OnMouseLeaveOverlay_MouseLeaveEvent.SetBelong(this.instance);
				}
				return r_OnMouseLeaveOverlay_MouseLeaveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseEnterOverlay(UnityEngine.UIElements.MouseEnterEvent)
		/// </summary>
		protected RMethod r_OnMouseEnterOverlay_MouseEnterEvent;
		public virtual RMethod ROnMouseEnterOverlay_MouseEnterEvent
		{
			get
			{
				if(r_OnMouseEnterOverlay_MouseEnterEvent == null)
				{
					r_OnMouseEnterOverlay_MouseEnterEvent = new(this, "OnMouseEnterOverlay", 0, typeof(UnityEngine.UIElements.MouseEnterEvent));
					r_OnMouseEnterOverlay_MouseEnterEvent.SetBelong(this.instance);
				}
				return r_OnMouseEnterOverlay_MouseEnterEvent;
			}
		}

		/// <summary>
		/// Void HideHoveredOverlay()
		/// </summary>
		protected RMethod r_HideHoveredOverlay;
		public virtual RMethod RHideHoveredOverlay
		{
			get
			{
				if(r_HideHoveredOverlay == null)
				{
					r_HideHoveredOverlay = new(this, "HideHoveredOverlay", 0);
					r_HideHoveredOverlay.SetBelong(this.instance);
				}
				return r_HideHoveredOverlay;
			}
		}

		/// <summary>
		/// Void ShowMenu(Boolean, Boolean)
		/// </summary>
		protected RMethod r_ShowMenu_Boolean_Boolean;
		public virtual RMethod RShowMenu_Boolean_Boolean
		{
			get
			{
				if(r_ShowMenu_Boolean_Boolean == null)
				{
					r_ShowMenu_Boolean_Boolean = new(this, "ShowMenu", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_ShowMenu_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_ShowMenu_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_Initialize_EditorWindow;
		public virtual RMethod RInitialize_EditorWindow
		{
			get
			{
				if(r_Initialize_EditorWindow == null)
				{
					r_Initialize_EditorWindow = new(this, "Initialize", 0, typeof(UnityEditor.EditorWindow));
					r_Initialize_EditorWindow.SetBelong(this.instance);
				}
				return r_Initialize_EditorWindow;
			}
		}

		/// <summary>
		/// Void OnBeforeAssemblyReload()
		/// </summary>
		protected RMethod r_OnBeforeAssemblyReload;
		public virtual RMethod ROnBeforeAssemblyReload
		{
			get
			{
				if(r_OnBeforeAssemblyReload == null)
				{
					r_OnBeforeAssemblyReload = new(this, "OnBeforeAssemblyReload", 0);
					r_OnBeforeAssemblyReload.SetBelong(this.instance);
				}
				return r_OnBeforeAssemblyReload;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetOriginGhostWorldBound()
		/// </summary>
		protected RMethod r_GetOriginGhostWorldBound;
		public virtual RMethod RGetOriginGhostWorldBound
		{
			get
			{
				if(r_GetOriginGhostWorldBound == null)
				{
					r_GetOriginGhostWorldBound = new(this, "GetOriginGhostWorldBound", 0);
					r_GetOriginGhostWorldBound.SetBelong(this.instance);
				}
				return r_GetOriginGhostWorldBound;
			}
		}

		/// <summary>
		/// Void HideOriginGhost()
		/// </summary>
		protected RMethod r_HideOriginGhost;
		public virtual RMethod RHideOriginGhost
		{
			get
			{
				if(r_HideOriginGhost == null)
				{
					r_HideOriginGhost = new(this, "HideOriginGhost", 0);
					r_HideOriginGhost.SetBelong(this.instance);
				}
				return r_HideOriginGhost;
			}
		}

		/// <summary>
		/// Void ShowOriginGhost(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_ShowOriginGhost_Overlay;
		public virtual RMethod RShowOriginGhost_Overlay
		{
			get
			{
				if(r_ShowOriginGhost_Overlay == null)
				{
					r_ShowOriginGhost_Overlay = new(this, "ShowOriginGhost", 0, typeof(UnityEditor.Overlays.Overlay));
					r_ShowOriginGhost_Overlay.SetBelong(this.instance);
				}
				return r_ShowOriginGhost_Overlay;
			}
		}

		/// <summary>
		/// Void UpdateGhostHover(Boolean)
		/// </summary>
		protected RMethod r_UpdateGhostHover_Boolean;
		public virtual RMethod RUpdateGhostHover_Boolean
		{
			get
			{
				if(r_UpdateGhostHover_Boolean == null)
				{
					r_UpdateGhostHover_Boolean = new(this, "UpdateGhostHover", 0, typeof(System.Boolean));
					r_UpdateGhostHover_Boolean.SetBelong(this.instance);
				}
				return r_UpdateGhostHover_Boolean;
			}
		}

		/// <summary>
		/// Void WriteOrReplaceSaveData(UnityEditor.Overlays.Overlay, Int32)
		/// </summary>
		protected RMethod r_WriteOrReplaceSaveData_Overlay_Int32;
		public virtual RMethod RWriteOrReplaceSaveData_Overlay_Int32
		{
			get
			{
				if(r_WriteOrReplaceSaveData_Overlay_Int32 == null)
				{
					r_WriteOrReplaceSaveData_Overlay_Int32 = new(this, "WriteOrReplaceSaveData", 0, typeof(UnityEditor.Overlays.Overlay), typeof(System.Int32));
					r_WriteOrReplaceSaveData_Overlay_Int32.SetBelong(this.instance);
				}
				return r_WriteOrReplaceSaveData_Overlay_Int32;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_OnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_OnBeforeSerialize == null)
				{
					r_OnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_OnBeforeSerialize.SetBelong(this.instance);
				}
				return r_OnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_OnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_OnAfterDeserialize == null)
				{
					r_OnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_OnAfterDeserialize.SetBelong(this.instance);
				}
				return r_OnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void CopySaveData(UnityEditor.Overlays.SaveData[] ByRef)
		/// </summary>
		protected RMethod r_CopySaveData_Out_SaveDataArray;
		public virtual RMethod RCopySaveData_Out_SaveDataArray
		{
			get
			{
				if(r_CopySaveData_Out_SaveDataArray == null)
				{
					r_CopySaveData_Out_SaveDataArray = new(this, "CopySaveData", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData").MakeArrayType().MakeByRefType());
					r_CopySaveData_Out_SaveDataArray.SetBelong(this.instance);
				}
				return r_CopySaveData_Out_SaveDataArray;
			}
		}

		/// <summary>
		/// Void ApplyPreset(UnityEditor.Overlays.OverlayPreset)
		/// </summary>
		protected RMethod r_ApplyPreset_OverlayPreset;
		public virtual RMethod RApplyPreset_OverlayPreset
		{
			get
			{
				if(r_ApplyPreset_OverlayPreset == null)
				{
					r_ApplyPreset_OverlayPreset = new(this, "ApplyPreset", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayPreset"));
					r_ApplyPreset_OverlayPreset.SetBelong(this.instance);
				}
				return r_ApplyPreset_OverlayPreset;
			}
		}

		/// <summary>
		/// Void ApplySaveData(UnityEditor.Overlays.SaveData[])
		/// </summary>
		protected RMethod r_ApplySaveData_SaveDataArray;
		public virtual RMethod RApplySaveData_SaveDataArray
		{
			get
			{
				if(r_ApplySaveData_SaveDataArray == null)
				{
					r_ApplySaveData_SaveDataArray = new(this, "ApplySaveData", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData").MakeArrayType());
					r_ApplySaveData_SaveDataArray.SetBelong(this.instance);
				}
				return r_ApplySaveData_SaveDataArray;
			}
		}

		/// <summary>
		/// Void Move(UnityEditor.Overlays.Overlay, UnityEditor.Overlays.DockZone, UnityEditor.Overlays.DockPosition)
		/// </summary>
		protected RMethod r_Move_Overlay_DockZone_DockPosition;
		public virtual RMethod RMove_Overlay_DockZone_DockPosition
		{
			get
			{
				if(r_Move_Overlay_DockZone_DockPosition == null)
				{
					r_Move_Overlay_DockZone_DockPosition = new(this, "Move", 0, typeof(UnityEditor.Overlays.Overlay), typeof(UnityEditor.Overlays.DockZone), typeof(UnityEditor.Overlays.DockPosition));
					r_Move_Overlay_DockZone_DockPosition.SetBelong(this.instance);
				}
				return r_Move_Overlay_DockZone_DockPosition;
			}
		}

		/// <summary>
		/// Void Rebuild()
		/// </summary>
		protected RMethod r_Rebuild;
		public virtual RMethod RRebuild
		{
			get
			{
				if(r_Rebuild == null)
				{
					r_Rebuild = new(this, "Rebuild", 0);
					r_Rebuild.SetBelong(this.instance);
				}
				return r_Rebuild;
			}
		}

		/// <summary>
		/// Void Add(UnityEditor.Overlays.Overlay, Boolean)
		/// </summary>
		protected RMethod r_Add_Overlay_Boolean;
		public virtual RMethod RAdd_Overlay_Boolean
		{
			get
			{
				if(r_Add_Overlay_Boolean == null)
				{
					r_Add_Overlay_Boolean = new(this, "Add", 0, typeof(UnityEditor.Overlays.Overlay), typeof(System.Boolean));
					r_Add_Overlay_Boolean.SetBelong(this.instance);
				}
				return r_Add_Overlay_Boolean;
			}
		}

		/// <summary>
		/// Boolean Remove(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_Remove_Overlay;
		public virtual RMethod RRemove_Overlay
		{
			get
			{
				if(r_Remove_Overlay == null)
				{
					r_Remove_Overlay = new(this, "Remove", 0, typeof(UnityEditor.Overlays.Overlay));
					r_Remove_Overlay.SetBelong(this.instance);
				}
				return r_Remove_Overlay;
			}
		}

		/// <summary>
		/// Void AddOverlay(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_AddOverlay_Overlay;
		public virtual RMethod RAddOverlay_Overlay
		{
			get
			{
				if(r_AddOverlay_Overlay == null)
				{
					r_AddOverlay_Overlay = new(this, "AddOverlay", 0, typeof(UnityEditor.Overlays.Overlay));
					r_AddOverlay_Overlay.SetBelong(this.instance);
				}
				return r_AddOverlay_Overlay;
			}
		}

		/// <summary>
		/// T GetOrCreateOverlay[T](System.String)
		/// </summary>
		protected RMethod r_GetOrCreateOverlay_GT_String;
		public virtual RMethod RGetOrCreateOverlay_GT_String
		{
			get
			{
				if(r_GetOrCreateOverlay_GT_String == null)
				{
					r_GetOrCreateOverlay_GT_String = new(this, "GetOrCreateOverlay", 1, typeof(System.String));
					r_GetOrCreateOverlay_GT_String.SetBelong(this.instance);
				}
				return r_GetOrCreateOverlay_GT_String;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData FindSaveData(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_FindSaveData_Overlay;
		public virtual RMethod RFindSaveData_Overlay
		{
			get
			{
				if(r_FindSaveData_Overlay == null)
				{
					r_FindSaveData_Overlay = new(this, "FindSaveData", 0, typeof(UnityEditor.Overlays.Overlay));
					r_FindSaveData_Overlay.SetBelong(this.instance);
				}
				return r_FindSaveData_Overlay;
			}
		}

		/// <summary>
		/// Void RestoreOverlay(UnityEditor.Overlays.Overlay, UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_RestoreOverlay_Overlay_SaveData;
		public virtual RMethod RRestoreOverlay_Overlay_SaveData
		{
			get
			{
				if(r_RestoreOverlay_Overlay_SaveData == null)
				{
					r_RestoreOverlay_Overlay_SaveData = new(this, "RestoreOverlay", 0, typeof(UnityEditor.Overlays.Overlay),  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"));
					r_RestoreOverlay_Overlay_SaveData.SetBelong(this.instance);
				}
				return r_RestoreOverlay_Overlay_SaveData;
			}
		}

		/// <summary>
		/// Void RestoreOverlays()
		/// </summary>
		protected RMethod r_RestoreOverlays;
		public virtual RMethod RRestoreOverlays
		{
			get
			{
				if(r_RestoreOverlays == null)
				{
					r_RestoreOverlays = new(this, "RestoreOverlays", 0);
					r_RestoreOverlays.SetBelong(this.instance);
				}
				return r_RestoreOverlays;
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


        public ROverlayCanvas() : base("UnityEditor.Overlays.OverlayCanvas")
        {
        }

        public ROverlayCanvas(System.Object instance) : base("UnityEditor.Overlays.OverlayCanvas")
		{
            SetInstance(instance);
		}

        public ROverlayCanvas(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROverlayCanvas(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEditor.Overlays.DockZone GetDockZone(RUnityEditor.ROverlays.ROverlayContainer @container)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value};
            var ___result = RGetDockZone_OverlayContainer.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Overlays.DockZone)___result;
        }


        public virtual RUnityEditor.ROverlays.ROverlayContainer GetDockZoneContainer(UnityEditor.Overlays.DockZone @zone)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@zone};
            var ___result = RGetDockZoneContainer_DockZone.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.ROverlays.ROverlayContainer(___result);
        }


        public virtual void SetOverlaysEnabled(System.Boolean @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visible};
            var ___result = RSetOverlaysEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreateRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void SetPickingMode(UnityEngine.UIElements.VisualElement @element, UnityEngine.UIElements.PickingMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @mode};
            var ___result = RSetPickingMode_VisualElement_PickingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseEnterOverlayContainer(UnityEngine.UIElements.MouseEnterEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseEnterOverlayContainer_MouseEnterEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAttachedToPanel(UnityEngine.UIElements.AttachToPanelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnAttachedToPanel_AttachToPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnDetachedFromPanel_DetachFromPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnContainerWindowDisabled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnContainerWindowDisabled.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect ClampToOverlayWindow(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RClampToOverlayWindow_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ClampRectToBounds(UnityEngine.Rect @boundary, UnityEngine.Rect @rectToClamp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@boundary, @rectToClamp};
            var ___result = RClampRectToBounds_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void GeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseLeaveOverlay(UnityEngine.UIElements.MouseLeaveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseLeaveOverlay_MouseLeaveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseEnterOverlay(UnityEngine.UIElements.MouseEnterEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnMouseEnterOverlay_MouseEnterEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideHoveredOverlay()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideHoveredOverlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowMenu(System.Boolean @show, System.Boolean @atMousePosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show, @atMousePosition};
            var ___result = RShowMenu_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(UnityEditor.EditorWindow @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window};
            var ___result = RInitialize_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeAssemblyReload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeAssemblyReload.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetOriginGhostWorldBound()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOriginGhostWorldBound.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void HideOriginGhost()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideOriginGhost.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowOriginGhost(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RShowOriginGhost_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGhostHover(System.Boolean @hovered)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hovered};
            var ___result = RUpdateGhostHover_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteOrReplaceSaveData(UnityEditor.Overlays.Overlay @overlay, System.Int32 @containerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @containerIndex};
            var ___result = RWriteOrReplaceSaveData_Overlay_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySaveData(out RTypeArray<RUnityEditor.ROverlays.RSaveData> @saveData)
        {
			@saveData = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@saveData.Value};
            var ___result = RCopySaveData_Out_SaveDataArray.Invoke(___genericsType, ___parameters);
			@saveData = new RTypeArray<RUnityEditor.ROverlays.RSaveData>(___parameters[0]);

            
        }


        public virtual void ApplyPreset(RUnityEditor.ROverlays.ROverlayPreset @preset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@preset.Value};
            var ___result = RApplyPreset_OverlayPreset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplySaveData(RTypeArray<RUnityEditor.ROverlays.RSaveData> @saveData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@saveData.Value};
            var ___result = RApplySaveData_SaveDataArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Move(UnityEditor.Overlays.Overlay @overlay, UnityEditor.Overlays.DockZone @zone, UnityEditor.Overlays.DockPosition @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @zone, @position};
            var ___result = RMove_Overlay_DockZone_DockPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(UnityEditor.Overlays.Overlay @overlay, System.Boolean @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @show};
            var ___result = RAdd_Overlay_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RRemove_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddOverlay(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RAddOverlay_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetOrCreateOverlay<T>(System.String @id) where T : UnityEditor.Overlays.Overlay, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@id};
            var ___result = RGetOrCreateOverlay_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual RUnityEditor.ROverlays.RSaveData FindSaveData(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RFindSaveData_Overlay.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.ROverlays.RSaveData(___result);
        }


        public virtual void RestoreOverlay(UnityEditor.Overlays.Overlay @overlay, RUnityEditor.ROverlays.RSaveData @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @data.Value};
            var ___result = RRestoreOverlay_Overlay_SaveData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreOverlays()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreOverlays.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
