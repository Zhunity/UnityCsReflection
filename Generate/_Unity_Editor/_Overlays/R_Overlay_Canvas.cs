
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.OverlayCanvas
	/// </summary>
    public partial class ROverlayCanvas : RMember //
    {

		/// <summary>
		/// System.Action`1[System.Boolean] overlaysEnabledChanged
		/// </summary>
		protected REvent r_EoverlaysEnabledChanged;
		public virtual REvent REoverlaysEnabledChanged
		{
			get
			{
				if(r_EoverlaysEnabledChanged == null)
				{
					r_EoverlaysEnabledChanged = new(this, "overlaysEnabledChanged");
					r_EoverlaysEnabledChanged.SetBelong(this.GetValue());
				}
				return r_EoverlaysEnabledChanged;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FussClassName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFussClassName
		{
			get
			{
				if(r_FussClassName == null)
				{
					r_FussClassName = new(typeof(UnityEditor.Overlays.OverlayCanvas), "ussClassName");
					r_FussClassName.SetBelong(null);
				}
				return r_FussClassName;
			}
		}

		/// <summary>
		/// System.String k_UxmlPath
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UxmlPath;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UxmlPath
		{
			get
			{
				if(r_Fk_UxmlPath == null)
				{
					r_Fk_UxmlPath = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_UxmlPath");
					r_Fk_UxmlPath.SetBelong(null);
				}
				return r_Fk_UxmlPath;
			}
		}

		/// <summary>
		/// System.String k_UxmlPathDropZone
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UxmlPathDropZone;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UxmlPathDropZone
		{
			get
			{
				if(r_Fk_UxmlPathDropZone == null)
				{
					r_Fk_UxmlPathDropZone = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_UxmlPathDropZone");
					r_Fk_UxmlPathDropZone.SetBelong(null);
				}
				return r_Fk_UxmlPathDropZone;
			}
		}

		/// <summary>
		/// System.String k_StyleCommon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_StyleCommon;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_StyleCommon
		{
			get
			{
				if(r_Fk_StyleCommon == null)
				{
					r_Fk_StyleCommon = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_StyleCommon");
					r_Fk_StyleCommon.SetBelong(null);
				}
				return r_Fk_StyleCommon;
			}
		}

		/// <summary>
		/// System.String k_StyleLight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_StyleLight;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_StyleLight
		{
			get
			{
				if(r_Fk_StyleLight == null)
				{
					r_Fk_StyleLight = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_StyleLight");
					r_Fk_StyleLight.SetBelong(null);
				}
				return r_Fk_StyleLight;
			}
		}

		/// <summary>
		/// System.String k_StyleDark
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_StyleDark;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_StyleDark
		{
			get
			{
				if(r_Fk_StyleDark == null)
				{
					r_Fk_StyleDark = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_StyleDark");
					r_Fk_StyleDark.SetBelong(null);
				}
				return r_Fk_StyleDark;
			}
		}

		/// <summary>
		/// System.Int32 k_ContainerCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_ContainerCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_ContainerCount
		{
			get
			{
				if(r_Fk_ContainerCount == null)
				{
					r_Fk_ContainerCount = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_ContainerCount");
					r_Fk_ContainerCount.SetBelong(null);
				}
				return r_Fk_ContainerCount;
			}
		}

		/// <summary>
		/// System.String k_FloatingContainer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_FloatingContainer;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_FloatingContainer
		{
			get
			{
				if(r_Fk_FloatingContainer == null)
				{
					r_Fk_FloatingContainer = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_FloatingContainer");
					r_Fk_FloatingContainer.SetBelong(null);
				}
				return r_Fk_FloatingContainer;
			}
		}

		/// <summary>
		/// System.String k_ToolbarZone
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ToolbarZone;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ToolbarZone
		{
			get
			{
				if(r_Fk_ToolbarZone == null)
				{
					r_Fk_ToolbarZone = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_ToolbarZone");
					r_Fk_ToolbarZone.SetBelong(null);
				}
				return r_Fk_ToolbarZone;
			}
		}

		/// <summary>
		/// System.String k_ToolbarArea
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ToolbarArea;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ToolbarArea
		{
			get
			{
				if(r_Fk_ToolbarArea == null)
				{
					r_Fk_ToolbarArea = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_ToolbarArea");
					r_Fk_ToolbarArea.SetBelong(null);
				}
				return r_Fk_ToolbarArea;
			}
		}

		/// <summary>
		/// System.String k_DropTargetClassName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_DropTargetClassName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_DropTargetClassName
		{
			get
			{
				if(r_Fk_DropTargetClassName == null)
				{
					r_Fk_DropTargetClassName = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_DropTargetClassName");
					r_Fk_DropTargetClassName.SetBelong(null);
				}
				return r_Fk_DropTargetClassName;
			}
		}

		/// <summary>
		/// System.String k_GhostClassName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_GhostClassName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_GhostClassName
		{
			get
			{
				if(r_Fk_GhostClassName == null)
				{
					r_Fk_GhostClassName = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_GhostClassName");
					r_Fk_GhostClassName.SetBelong(null);
				}
				return r_Fk_GhostClassName;
			}
		}

		/// <summary>
		/// System.String k_GhostAreaHovered
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_GhostAreaHovered;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_GhostAreaHovered
		{
			get
			{
				if(r_Fk_GhostAreaHovered == null)
				{
					r_Fk_GhostAreaHovered = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_GhostAreaHovered");
					r_Fk_GhostAreaHovered.SetBelong(null);
				}
				return r_Fk_GhostAreaHovered;
			}
		}

		/// <summary>
		/// System.String k_DefaultContainer
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_DefaultContainer;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_DefaultContainer
		{
			get
			{
				if(r_Fk_DefaultContainer == null)
				{
					r_Fk_DefaultContainer = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_DefaultContainer");
					r_Fk_DefaultContainer.SetBelong(null);
				}
				return r_Fk_DefaultContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset s_TreeAsset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_Fs_TreeAsset;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RFs_TreeAsset
		{
			get
			{
				if(r_Fs_TreeAsset == null)
				{
					r_Fs_TreeAsset = new(typeof(UnityEditor.Overlays.OverlayCanvas), "s_TreeAsset");
					r_Fs_TreeAsset.SetBelong(null);
				}
				return r_Fs_TreeAsset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset s_DropZoneTreeAsset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_Fs_DropZoneTreeAsset;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RFs_DropZoneTreeAsset
		{
			get
			{
				if(r_Fs_DropZoneTreeAsset == null)
				{
					r_Fs_DropZoneTreeAsset = new(typeof(UnityEditor.Overlays.OverlayCanvas), "s_DropZoneTreeAsset");
					r_Fs_DropZoneTreeAsset.SetBelong(null);
				}
				return r_Fs_DropZoneTreeAsset;
			}
		}

		/// <summary>
		/// System.String[] k_DockZoneContainerIDs
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fk_DockZoneContainerIDs;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFk_DockZoneContainerIDs
		{
			get
			{
				if(r_Fk_DockZoneContainerIDs == null)
				{
					r_Fk_DockZoneContainerIDs = new(typeof(UnityEditor.Overlays.OverlayCanvas), "k_DockZoneContainerIDs");
					r_Fk_DockZoneContainerIDs.SetBelong(null);
				}
				return r_Fk_DockZoneContainerIDs;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayMenu m_Menu
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayMenu r_Fm_Menu;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayMenu RFm_Menu
		{
			get
			{
				if(r_Fm_Menu == null)
				{
					r_Fm_Menu = new(this, "m_Menu");
					r_Fm_Menu.SetBelong(this.GetValue());
				}
				return r_Fm_Menu;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.Overlay] m_Overlays
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay> r_Fm_Overlays;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay> RFm_Overlays
		{
			get
			{
				if(r_Fm_Overlays == null)
				{
					r_Fm_Overlays = new(this, "m_Overlays");
					r_Fm_Overlays.SetBelong(this.GetValue());
				}
				return r_Fm_Overlays;
			}
		}

		/// <summary>
		/// System.String m_LastAppliedPresetName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_LastAppliedPresetName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_LastAppliedPresetName
		{
			get
			{
				if(r_Fm_LastAppliedPresetName == null)
				{
					r_Fm_LastAppliedPresetName = new(this, "m_LastAppliedPresetName");
					r_Fm_LastAppliedPresetName.SetBelong(this.GetValue());
				}
				return r_Fm_LastAppliedPresetName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.SaveData] m_SaveData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData> r_Fm_SaveData;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData> RFm_SaveData
		{
			get
			{
				if(r_Fm_SaveData == null)
				{
					r_Fm_SaveData = new(this, "m_SaveData");
					r_Fm_SaveData.SetBelong(this.GetValue());
				}
				return r_Fm_SaveData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_RootVisualElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_RootVisualElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_RootVisualElement
		{
			get
			{
				if(r_Fm_RootVisualElement == null)
				{
					r_Fm_RootVisualElement = new(this, "m_RootVisualElement");
					r_Fm_RootVisualElement.SetBelong(this.GetValue());
				}
				return r_Fm_RootVisualElement;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow <containerWindow>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_F__0__containerWindow__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RF__0__containerWindow__1__k__BackingField
		{
			get
			{
				if(r_F__0__containerWindow__1__k__BackingField == null)
				{
					r_F__0__containerWindow__1__k__BackingField = new(this, "<containerWindow>k__BackingField");
					r_F__0__containerWindow__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__containerWindow__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.FloatingOverlayContainer m_FloatingOverlayContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RFloatingOverlayContainer r_Fm_FloatingOverlayContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RFloatingOverlayContainer RFm_FloatingOverlayContainer
		{
			get
			{
				if(r_Fm_FloatingOverlayContainer == null)
				{
					r_Fm_FloatingOverlayContainer = new(this, "m_FloatingOverlayContainer");
					r_Fm_FloatingOverlayContainer.SetBelong(this.GetValue());
				}
				return r_Fm_FloatingOverlayContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Overlay m_HoveredOverlay
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay r_Fm_HoveredOverlay;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay RFm_HoveredOverlay
		{
			get
			{
				if(r_Fm_HoveredOverlay == null)
				{
					r_Fm_HoveredOverlay = new(this, "m_HoveredOverlay");
					r_Fm_HoveredOverlay.SetBelong(this.GetValue());
				}
				return r_Fm_HoveredOverlay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer <hoveredOverlayContainer>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_F__0__hoveredOverlayContainer__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RF__0__hoveredOverlayContainer__1__k__BackingField
		{
			get
			{
				if(r_F__0__hoveredOverlayContainer__1__k__BackingField == null)
				{
					r_F__0__hoveredOverlayContainer__1__k__BackingField = new(this, "<hoveredOverlayContainer>k__BackingField");
					r_F__0__hoveredOverlayContainer__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__hoveredOverlayContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer <defaultContainer>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_F__0__defaultContainer__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RF__0__defaultContainer__1__k__BackingField
		{
			get
			{
				if(r_F__0__defaultContainer__1__k__BackingField == null)
				{
					r_F__0__defaultContainer__1__k__BackingField = new(this, "<defaultContainer>k__BackingField");
					r_F__0__defaultContainer__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__defaultContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer <defaultToolbarContainer>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_F__0__defaultToolbarContainer__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RF__0__defaultToolbarContainer__1__k__BackingField
		{
			get
			{
				if(r_F__0__defaultToolbarContainer__1__k__BackingField == null)
				{
					r_F__0__defaultToolbarContainer__1__k__BackingField = new(this, "<defaultToolbarContainer>k__BackingField");
					r_F__0__defaultToolbarContainer__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__defaultToolbarContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.OverlayContainer] <containers>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer> r_F__0__containers__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer> RF__0__containers__1__k__BackingField
		{
			get
			{
				if(r_F__0__containers__1__k__BackingField == null)
				{
					r_F__0__containers__1__k__BackingField = new(this, "<containers>k__BackingField");
					r_F__0__containers__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__containers__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.VisualElement,UnityEditor.Overlays.Overlay] m_OverlaysByVE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay> r_Fm_OverlaysByVE;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay> RFm_OverlaysByVE
		{
			get
			{
				if(r_Fm_OverlaysByVE == null)
				{
					r_Fm_OverlaysByVE = new(this, "m_OverlaysByVE");
					r_Fm_OverlaysByVE.SetBelong(this.GetValue());
				}
				return r_Fm_OverlaysByVE;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_OriginGhost
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_OriginGhost;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_OriginGhost
		{
			get
			{
				if(r_Fm_OriginGhost == null)
				{
					r_Fm_OriginGhost = new(this, "m_OriginGhost");
					r_Fm_OriginGhost.SetBelong(this.GetValue());
				}
				return r_Fm_OriginGhost;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDestinationMarker <destinationMarker>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDestinationMarker r_F__0__destinationMarker__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDestinationMarker RF__0__destinationMarker__1__k__BackingField
		{
			get
			{
				if(r_F__0__destinationMarker__1__k__BackingField == null)
				{
					r_F__0__destinationMarker__1__k__BackingField = new(this, "<destinationMarker>k__BackingField");
					r_F__0__destinationMarker__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__destinationMarker__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_WindowRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_WindowRoot;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_WindowRoot
		{
			get
			{
				if(r_Fm_WindowRoot == null)
				{
					r_Fm_WindowRoot = new(this, "m_WindowRoot");
					r_Fm_WindowRoot.SetBelong(this.GetValue());
				}
				return r_Fm_WindowRoot;
			}
		}

		/// <summary>
		/// System.Action afterOverlaysInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FafterOverlaysInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFafterOverlaysInitialized
		{
			get
			{
				if(r_FafterOverlaysInitialized == null)
				{
					r_FafterOverlaysInitialized = new(this, "afterOverlaysInitialized");
					r_FafterOverlaysInitialized.SetBelong(this.GetValue());
				}
				return r_FafterOverlaysInitialized;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] overlaysEnabledChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FoverlaysEnabledChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> RFoverlaysEnabledChanged
		{
			get
			{
				if(r_FoverlaysEnabledChanged == null)
				{
					r_FoverlaysEnabledChanged = new(this, "overlaysEnabledChanged");
					r_FoverlaysEnabledChanged.SetBelong(this.GetValue());
				}
				return r_FoverlaysEnabledChanged;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData defaultSaveData
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData r_PdefaultSaveData;
		public static Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData RPdefaultSaveData
		{
			get
			{
				if(r_PdefaultSaveData == null)
				{
					r_PdefaultSaveData = new(typeof(UnityEditor.Overlays.OverlayCanvas), "defaultSaveData", -1);
					r_PdefaultSaveData.SetBelong(null);
				}
				return r_PdefaultSaveData;
			}
		}

		/// <summary>
		/// System.String lastAppliedPresetName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlastAppliedPresetName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlastAppliedPresetName
		{
			get
			{
				if(r_PlastAppliedPresetName == null)
				{
					r_PlastAppliedPresetName = new(this, "lastAppliedPresetName", -1);
					r_PlastAppliedPresetName.SetBelong(this.GetValue());
				}
				return r_PlastAppliedPresetName;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow containerWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorWindow r_PcontainerWindow;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorWindow RPcontainerWindow
		{
			get
			{
				if(r_PcontainerWindow == null)
				{
					r_PcontainerWindow = new(this, "containerWindow", -1);
					r_PcontainerWindow.SetBelong(this.GetValue());
				}
				return r_PcontainerWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.FloatingOverlayContainer floatingContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RFloatingOverlayContainer r_PfloatingContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RFloatingOverlayContainer RPfloatingContainer
		{
			get
			{
				if(r_PfloatingContainer == null)
				{
					r_PfloatingContainer = new(this, "floatingContainer", -1);
					r_PfloatingContainer.SetBelong(this.GetValue());
				}
				return r_PfloatingContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayMenu menu
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayMenu r_Pmenu;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayMenu RPmenu
		{
			get
			{
				if(r_Pmenu == null)
				{
					r_Pmenu = new(this, "menu", -1);
					r_Pmenu.SetBelong(this.GetValue());
				}
				return r_Pmenu;
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
		/// UnityEditor.Overlays.Overlay hoveredOverlay
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay r_PhoveredOverlay;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay RPhoveredOverlay
		{
			get
			{
				if(r_PhoveredOverlay == null)
				{
					r_PhoveredOverlay = new(this, "hoveredOverlay", -1);
					r_PhoveredOverlay.SetBelong(this.GetValue());
				}
				return r_PhoveredOverlay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer hoveredOverlayContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_PhoveredOverlayContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RPhoveredOverlayContainer
		{
			get
			{
				if(r_PhoveredOverlayContainer == null)
				{
					r_PhoveredOverlayContainer = new(this, "hoveredOverlayContainer", -1);
					r_PhoveredOverlayContainer.SetBelong(this.GetValue());
				}
				return r_PhoveredOverlayContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer defaultContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_PdefaultContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RPdefaultContainer
		{
			get
			{
				if(r_PdefaultContainer == null)
				{
					r_PdefaultContainer = new(this, "defaultContainer", -1);
					r_PdefaultContainer.SetBelong(this.GetValue());
				}
				return r_PdefaultContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer defaultToolbarContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_PdefaultToolbarContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RPdefaultToolbarContainer
		{
			get
			{
				if(r_PdefaultToolbarContainer == null)
				{
					r_PdefaultToolbarContainer = new(this, "defaultToolbarContainer", -1);
					r_PdefaultToolbarContainer.SetBelong(this.GetValue());
				}
				return r_PdefaultToolbarContainer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.Overlays.OverlayContainer] containers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer> r_Pcontainers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer> RPcontainers
		{
			get
			{
				if(r_Pcontainers == null)
				{
					r_Pcontainers = new(this, "containers", -1);
					r_Pcontainers.SetBelong(this.GetValue());
				}
				return r_Pcontainers;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDestinationMarker destinationMarker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDestinationMarker r_PdestinationMarker;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDestinationMarker RPdestinationMarker
		{
			get
			{
				if(r_PdestinationMarker == null)
				{
					r_PdestinationMarker = new(this, "destinationMarker", -1);
					r_PdestinationMarker.SetBelong(this.GetValue());
				}
				return r_PdestinationMarker;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.Overlays.Overlay] overlays
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay> r_Poverlays;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay> RPoverlays
		{
			get
			{
				if(r_Poverlays == null)
				{
					r_Poverlays = new(this, "overlays", -1);
					r_Poverlays.SetBelong(this.GetValue());
				}
				return r_Poverlays;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement windowRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PwindowRoot;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPwindowRoot
		{
			get
			{
				if(r_PwindowRoot == null)
				{
					r_PwindowRoot = new(this, "windowRoot", -1);
					r_PwindowRoot.SetBelong(this.GetValue());
				}
				return r_PwindowRoot;
			}
		}

		/// <summary>
		/// Boolean overlaysEnabled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PoverlaysEnabled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPoverlaysEnabled
		{
			get
			{
				if(r_PoverlaysEnabled == null)
				{
					r_PoverlaysEnabled = new(this, "overlaysEnabled", -1);
					r_PoverlaysEnabled.SetBelong(this.GetValue());
				}
				return r_PoverlaysEnabled;
			}
		}

		/// <summary>
		/// Boolean menuVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PmenuVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPmenuVisible
		{
			get
			{
				if(r_PmenuVisible == null)
				{
					r_PmenuVisible = new(this, "menuVisible", -1);
					r_PmenuVisible.SetBelong(this.GetValue());
				}
				return r_PmenuVisible;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone GetDockZone(UnityEditor.Overlays.OverlayContainer)
		/// </summary>
		protected static RMethod r_MGetDockZone_OverlayContainer;
		public static RMethod RMGetDockZone_OverlayContainer
		{
			get
			{
				if(r_MGetDockZone_OverlayContainer == null)
				{
					r_MGetDockZone_OverlayContainer = new(typeof(UnityEditor.Overlays.OverlayCanvas), "GetDockZone", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"));
					r_MGetDockZone_OverlayContainer.SetBelong(null);
				}
				return r_MGetDockZone_OverlayContainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer GetDockZoneContainer(UnityEditor.Overlays.DockZone)
		/// </summary>
		protected RMethod r_MGetDockZoneContainer_DockZone;
		public virtual RMethod RMGetDockZoneContainer_DockZone
		{
			get
			{
				if(r_MGetDockZoneContainer_DockZone == null)
				{
					r_MGetDockZoneContainer_DockZone = new(this, "GetDockZoneContainer", 0, typeof(UnityEditor.Overlays.DockZone));
					r_MGetDockZoneContainer_DockZone.SetBelong(this.GetValue());
				}
				return r_MGetDockZoneContainer_DockZone;
			}
		}

		/// <summary>
		/// Void SetOverlaysEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetOverlaysEnabled_Boolean;
		public virtual RMethod RMSetOverlaysEnabled_Boolean
		{
			get
			{
				if(r_MSetOverlaysEnabled_Boolean == null)
				{
					r_MSetOverlaysEnabled_Boolean = new(this, "SetOverlaysEnabled", 0, typeof(System.Boolean));
					r_MSetOverlaysEnabled_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetOverlaysEnabled_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateRoot()
		/// </summary>
		protected RMethod r_MCreateRoot;
		public virtual RMethod RMCreateRoot
		{
			get
			{
				if(r_MCreateRoot == null)
				{
					r_MCreateRoot = new(this, "CreateRoot", 0);
					r_MCreateRoot.SetBelong(this.GetValue());
				}
				return r_MCreateRoot;
			}
		}

		/// <summary>
		/// Void SetPickingMode(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.PickingMode)
		/// </summary>
		protected RMethod r_MSetPickingMode_VisualElement_PickingMode;
		public virtual RMethod RMSetPickingMode_VisualElement_PickingMode
		{
			get
			{
				if(r_MSetPickingMode_VisualElement_PickingMode == null)
				{
					r_MSetPickingMode_VisualElement_PickingMode = new(this, "SetPickingMode", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.PickingMode));
					r_MSetPickingMode_VisualElement_PickingMode.SetBelong(this.GetValue());
				}
				return r_MSetPickingMode_VisualElement_PickingMode;
			}
		}

		/// <summary>
		/// Void OnMouseEnterOverlayContainer(UnityEngine.UIElements.MouseEnterEvent)
		/// </summary>
		protected RMethod r_MOnMouseEnterOverlayContainer_MouseEnterEvent;
		public virtual RMethod RMOnMouseEnterOverlayContainer_MouseEnterEvent
		{
			get
			{
				if(r_MOnMouseEnterOverlayContainer_MouseEnterEvent == null)
				{
					r_MOnMouseEnterOverlayContainer_MouseEnterEvent = new(this, "OnMouseEnterOverlayContainer", 0, typeof(UnityEngine.UIElements.MouseEnterEvent));
					r_MOnMouseEnterOverlayContainer_MouseEnterEvent.SetBelong(this.GetValue());
				}
				return r_MOnMouseEnterOverlayContainer_MouseEnterEvent;
			}
		}

		/// <summary>
		/// Void OnAttachedToPanel(UnityEngine.UIElements.AttachToPanelEvent)
		/// </summary>
		protected RMethod r_MOnAttachedToPanel_AttachToPanelEvent;
		public virtual RMethod RMOnAttachedToPanel_AttachToPanelEvent
		{
			get
			{
				if(r_MOnAttachedToPanel_AttachToPanelEvent == null)
				{
					r_MOnAttachedToPanel_AttachToPanelEvent = new(this, "OnAttachedToPanel", 0, typeof(UnityEngine.UIElements.AttachToPanelEvent));
					r_MOnAttachedToPanel_AttachToPanelEvent.SetBelong(this.GetValue());
				}
				return r_MOnAttachedToPanel_AttachToPanelEvent;
			}
		}

		/// <summary>
		/// Void OnDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent)
		/// </summary>
		protected RMethod r_MOnDetachedFromPanel_DetachFromPanelEvent;
		public virtual RMethod RMOnDetachedFromPanel_DetachFromPanelEvent
		{
			get
			{
				if(r_MOnDetachedFromPanel_DetachFromPanelEvent == null)
				{
					r_MOnDetachedFromPanel_DetachFromPanelEvent = new(this, "OnDetachedFromPanel", 0, typeof(UnityEngine.UIElements.DetachFromPanelEvent));
					r_MOnDetachedFromPanel_DetachFromPanelEvent.SetBelong(this.GetValue());
				}
				return r_MOnDetachedFromPanel_DetachFromPanelEvent;
			}
		}

		/// <summary>
		/// Void OnContainerWindowDisabled()
		/// </summary>
		protected RMethod r_MOnContainerWindowDisabled;
		public virtual RMethod RMOnContainerWindowDisabled
		{
			get
			{
				if(r_MOnContainerWindowDisabled == null)
				{
					r_MOnContainerWindowDisabled = new(this, "OnContainerWindowDisabled", 0);
					r_MOnContainerWindowDisabled.SetBelong(this.GetValue());
				}
				return r_MOnContainerWindowDisabled;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ClampToOverlayWindow(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MClampToOverlayWindow_Rect;
		public virtual RMethod RMClampToOverlayWindow_Rect
		{
			get
			{
				if(r_MClampToOverlayWindow_Rect == null)
				{
					r_MClampToOverlayWindow_Rect = new(this, "ClampToOverlayWindow", 0, typeof(UnityEngine.Rect));
					r_MClampToOverlayWindow_Rect.SetBelong(this.GetValue());
				}
				return r_MClampToOverlayWindow_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ClampRectToBounds(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MClampRectToBounds_Rect_Rect;
		public static RMethod RMClampRectToBounds_Rect_Rect
		{
			get
			{
				if(r_MClampRectToBounds_Rect_Rect == null)
				{
					r_MClampRectToBounds_Rect_Rect = new(typeof(UnityEditor.Overlays.OverlayCanvas), "ClampRectToBounds", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_MClampRectToBounds_Rect_Rect.SetBelong(null);
				}
				return r_MClampRectToBounds_Rect_Rect;
			}
		}

		/// <summary>
		/// Void GeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MGeometryChanged_GeometryChangedEvent;
		public virtual RMethod RMGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MGeometryChanged_GeometryChangedEvent == null)
				{
					r_MGeometryChanged_GeometryChangedEvent = new(this, "GeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MGeometryChanged_GeometryChangedEvent.SetBelong(this.GetValue());
				}
				return r_MGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnMouseLeaveOverlay(UnityEngine.UIElements.MouseLeaveEvent)
		/// </summary>
		protected RMethod r_MOnMouseLeaveOverlay_MouseLeaveEvent;
		public virtual RMethod RMOnMouseLeaveOverlay_MouseLeaveEvent
		{
			get
			{
				if(r_MOnMouseLeaveOverlay_MouseLeaveEvent == null)
				{
					r_MOnMouseLeaveOverlay_MouseLeaveEvent = new(this, "OnMouseLeaveOverlay", 0, typeof(UnityEngine.UIElements.MouseLeaveEvent));
					r_MOnMouseLeaveOverlay_MouseLeaveEvent.SetBelong(this.GetValue());
				}
				return r_MOnMouseLeaveOverlay_MouseLeaveEvent;
			}
		}

		/// <summary>
		/// Void OnMouseEnterOverlay(UnityEngine.UIElements.MouseEnterEvent)
		/// </summary>
		protected RMethod r_MOnMouseEnterOverlay_MouseEnterEvent;
		public virtual RMethod RMOnMouseEnterOverlay_MouseEnterEvent
		{
			get
			{
				if(r_MOnMouseEnterOverlay_MouseEnterEvent == null)
				{
					r_MOnMouseEnterOverlay_MouseEnterEvent = new(this, "OnMouseEnterOverlay", 0, typeof(UnityEngine.UIElements.MouseEnterEvent));
					r_MOnMouseEnterOverlay_MouseEnterEvent.SetBelong(this.GetValue());
				}
				return r_MOnMouseEnterOverlay_MouseEnterEvent;
			}
		}

		/// <summary>
		/// Void HideHoveredOverlay()
		/// </summary>
		protected RMethod r_MHideHoveredOverlay;
		public virtual RMethod RMHideHoveredOverlay
		{
			get
			{
				if(r_MHideHoveredOverlay == null)
				{
					r_MHideHoveredOverlay = new(this, "HideHoveredOverlay", 0);
					r_MHideHoveredOverlay.SetBelong(this.GetValue());
				}
				return r_MHideHoveredOverlay;
			}
		}

		/// <summary>
		/// Void ShowMenu(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MShowMenu_Boolean_Boolean;
		public virtual RMethod RMShowMenu_Boolean_Boolean
		{
			get
			{
				if(r_MShowMenu_Boolean_Boolean == null)
				{
					r_MShowMenu_Boolean_Boolean = new(this, "ShowMenu", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MShowMenu_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MShowMenu_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.EditorWindow)
		/// </summary>
		protected RMethod r_MInitialize_EditorWindow;
		public virtual RMethod RMInitialize_EditorWindow
		{
			get
			{
				if(r_MInitialize_EditorWindow == null)
				{
					r_MInitialize_EditorWindow = new(this, "Initialize", 0, typeof(UnityEditor.EditorWindow));
					r_MInitialize_EditorWindow.SetBelong(this.GetValue());
				}
				return r_MInitialize_EditorWindow;
			}
		}

		/// <summary>
		/// Void OnBeforeAssemblyReload()
		/// </summary>
		protected RMethod r_MOnBeforeAssemblyReload;
		public virtual RMethod RMOnBeforeAssemblyReload
		{
			get
			{
				if(r_MOnBeforeAssemblyReload == null)
				{
					r_MOnBeforeAssemblyReload = new(this, "OnBeforeAssemblyReload", 0);
					r_MOnBeforeAssemblyReload.SetBelong(this.GetValue());
				}
				return r_MOnBeforeAssemblyReload;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetOriginGhostWorldBound()
		/// </summary>
		protected RMethod r_MGetOriginGhostWorldBound;
		public virtual RMethod RMGetOriginGhostWorldBound
		{
			get
			{
				if(r_MGetOriginGhostWorldBound == null)
				{
					r_MGetOriginGhostWorldBound = new(this, "GetOriginGhostWorldBound", 0);
					r_MGetOriginGhostWorldBound.SetBelong(this.GetValue());
				}
				return r_MGetOriginGhostWorldBound;
			}
		}

		/// <summary>
		/// Void HideOriginGhost()
		/// </summary>
		protected RMethod r_MHideOriginGhost;
		public virtual RMethod RMHideOriginGhost
		{
			get
			{
				if(r_MHideOriginGhost == null)
				{
					r_MHideOriginGhost = new(this, "HideOriginGhost", 0);
					r_MHideOriginGhost.SetBelong(this.GetValue());
				}
				return r_MHideOriginGhost;
			}
		}

		/// <summary>
		/// Void ShowOriginGhost(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MShowOriginGhost_Overlay;
		public virtual RMethod RMShowOriginGhost_Overlay
		{
			get
			{
				if(r_MShowOriginGhost_Overlay == null)
				{
					r_MShowOriginGhost_Overlay = new(this, "ShowOriginGhost", 0, typeof(UnityEditor.Overlays.Overlay));
					r_MShowOriginGhost_Overlay.SetBelong(this.GetValue());
				}
				return r_MShowOriginGhost_Overlay;
			}
		}

		/// <summary>
		/// Void UpdateGhostHover(Boolean)
		/// </summary>
		protected RMethod r_MUpdateGhostHover_Boolean;
		public virtual RMethod RMUpdateGhostHover_Boolean
		{
			get
			{
				if(r_MUpdateGhostHover_Boolean == null)
				{
					r_MUpdateGhostHover_Boolean = new(this, "UpdateGhostHover", 0, typeof(System.Boolean));
					r_MUpdateGhostHover_Boolean.SetBelong(this.GetValue());
				}
				return r_MUpdateGhostHover_Boolean;
			}
		}

		/// <summary>
		/// Void WriteOrReplaceSaveData(UnityEditor.Overlays.Overlay, Int32)
		/// </summary>
		protected RMethod r_MWriteOrReplaceSaveData_Overlay_Int32;
		public virtual RMethod RMWriteOrReplaceSaveData_Overlay_Int32
		{
			get
			{
				if(r_MWriteOrReplaceSaveData_Overlay_Int32 == null)
				{
					r_MWriteOrReplaceSaveData_Overlay_Int32 = new(this, "WriteOrReplaceSaveData", 0, typeof(UnityEditor.Overlays.Overlay), typeof(System.Int32));
					r_MWriteOrReplaceSaveData_Overlay_Int32.SetBelong(this.GetValue());
				}
				return r_MWriteOrReplaceSaveData_Overlay_Int32;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_MOnBeforeSerialize.SetBelong(this.GetValue());
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_MOnAfterDeserialize.SetBelong(this.GetValue());
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void CopySaveData(UnityEditor.Overlays.SaveData[] ByRef)
		/// </summary>
		protected RMethod r_MCopySaveData_Out_SaveDataArray;
		public virtual RMethod RMCopySaveData_Out_SaveDataArray
		{
			get
			{
				if(r_MCopySaveData_Out_SaveDataArray == null)
				{
					r_MCopySaveData_Out_SaveDataArray = new(this, "CopySaveData", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData").MakeArrayType().MakeByRefType());
					r_MCopySaveData_Out_SaveDataArray.SetBelong(this.GetValue());
				}
				return r_MCopySaveData_Out_SaveDataArray;
			}
		}

		/// <summary>
		/// Void ApplyPreset(UnityEditor.Overlays.OverlayPreset)
		/// </summary>
		protected RMethod r_MApplyPreset_OverlayPreset;
		public virtual RMethod RMApplyPreset_OverlayPreset
		{
			get
			{
				if(r_MApplyPreset_OverlayPreset == null)
				{
					r_MApplyPreset_OverlayPreset = new(this, "ApplyPreset", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayPreset"));
					r_MApplyPreset_OverlayPreset.SetBelong(this.GetValue());
				}
				return r_MApplyPreset_OverlayPreset;
			}
		}

		/// <summary>
		/// Void ApplySaveData(UnityEditor.Overlays.SaveData[])
		/// </summary>
		protected RMethod r_MApplySaveData_SaveDataArray;
		public virtual RMethod RMApplySaveData_SaveDataArray
		{
			get
			{
				if(r_MApplySaveData_SaveDataArray == null)
				{
					r_MApplySaveData_SaveDataArray = new(this, "ApplySaveData", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData").MakeArrayType());
					r_MApplySaveData_SaveDataArray.SetBelong(this.GetValue());
				}
				return r_MApplySaveData_SaveDataArray;
			}
		}

		/// <summary>
		/// Void Move(UnityEditor.Overlays.Overlay, UnityEditor.Overlays.DockZone, UnityEditor.Overlays.DockPosition)
		/// </summary>
		protected RMethod r_MMove_Overlay_DockZone_DockPosition;
		public virtual RMethod RMMove_Overlay_DockZone_DockPosition
		{
			get
			{
				if(r_MMove_Overlay_DockZone_DockPosition == null)
				{
					r_MMove_Overlay_DockZone_DockPosition = new(this, "Move", 0, typeof(UnityEditor.Overlays.Overlay), typeof(UnityEditor.Overlays.DockZone), typeof(UnityEditor.Overlays.DockPosition));
					r_MMove_Overlay_DockZone_DockPosition.SetBelong(this.GetValue());
				}
				return r_MMove_Overlay_DockZone_DockPosition;
			}
		}

		/// <summary>
		/// Void Rebuild()
		/// </summary>
		protected RMethod r_MRebuild;
		public virtual RMethod RMRebuild
		{
			get
			{
				if(r_MRebuild == null)
				{
					r_MRebuild = new(this, "Rebuild", 0);
					r_MRebuild.SetBelong(this.GetValue());
				}
				return r_MRebuild;
			}
		}

		/// <summary>
		/// Void Add(UnityEditor.Overlays.Overlay, Boolean)
		/// </summary>
		protected RMethod r_MAdd_Overlay_Boolean;
		public virtual RMethod RMAdd_Overlay_Boolean
		{
			get
			{
				if(r_MAdd_Overlay_Boolean == null)
				{
					r_MAdd_Overlay_Boolean = new(this, "Add", 0, typeof(UnityEditor.Overlays.Overlay), typeof(System.Boolean));
					r_MAdd_Overlay_Boolean.SetBelong(this.GetValue());
				}
				return r_MAdd_Overlay_Boolean;
			}
		}

		/// <summary>
		/// Boolean Remove(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MRemove_Overlay;
		public virtual RMethod RMRemove_Overlay
		{
			get
			{
				if(r_MRemove_Overlay == null)
				{
					r_MRemove_Overlay = new(this, "Remove", 0, typeof(UnityEditor.Overlays.Overlay));
					r_MRemove_Overlay.SetBelong(this.GetValue());
				}
				return r_MRemove_Overlay;
			}
		}

		/// <summary>
		/// Void AddOverlay(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MAddOverlay_Overlay;
		public virtual RMethod RMAddOverlay_Overlay
		{
			get
			{
				if(r_MAddOverlay_Overlay == null)
				{
					r_MAddOverlay_Overlay = new(this, "AddOverlay", 0, typeof(UnityEditor.Overlays.Overlay));
					r_MAddOverlay_Overlay.SetBelong(this.GetValue());
				}
				return r_MAddOverlay_Overlay;
			}
		}

		/// <summary>
		/// T GetOrCreateOverlay[T](System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateOverlay_GT_String;
		public virtual RMethod RMGetOrCreateOverlay_GT_String
		{
			get
			{
				if(r_MGetOrCreateOverlay_GT_String == null)
				{
					r_MGetOrCreateOverlay_GT_String = new(this, "GetOrCreateOverlay", 1, typeof(System.String));
					r_MGetOrCreateOverlay_GT_String.SetBelong(this.GetValue());
				}
				return r_MGetOrCreateOverlay_GT_String;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SaveData FindSaveData(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MFindSaveData_Overlay;
		public virtual RMethod RMFindSaveData_Overlay
		{
			get
			{
				if(r_MFindSaveData_Overlay == null)
				{
					r_MFindSaveData_Overlay = new(this, "FindSaveData", 0, typeof(UnityEditor.Overlays.Overlay));
					r_MFindSaveData_Overlay.SetBelong(this.GetValue());
				}
				return r_MFindSaveData_Overlay;
			}
		}

		/// <summary>
		/// Void RestoreOverlay(UnityEditor.Overlays.Overlay, UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_MRestoreOverlay_Overlay_SaveData;
		public virtual RMethod RMRestoreOverlay_Overlay_SaveData
		{
			get
			{
				if(r_MRestoreOverlay_Overlay_SaveData == null)
				{
					r_MRestoreOverlay_Overlay_SaveData = new(this, "RestoreOverlay", 0, typeof(UnityEditor.Overlays.Overlay),  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"));
					r_MRestoreOverlay_Overlay_SaveData.SetBelong(this.GetValue());
				}
				return r_MRestoreOverlay_Overlay_SaveData;
			}
		}

		/// <summary>
		/// Void RestoreOverlays()
		/// </summary>
		protected RMethod r_MRestoreOverlays;
		public virtual RMethod RMRestoreOverlays
		{
			get
			{
				if(r_MRestoreOverlays == null)
				{
					r_MRestoreOverlays = new(this, "RestoreOverlays", 0);
					r_MRestoreOverlays.SetBelong(this.GetValue());
				}
				return r_MRestoreOverlays;
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

        public static UnityEditor.Overlays.DockZone GetDockZone(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer @container)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value};
            var ___result = RMGetDockZone_OverlayContainer.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Overlays.DockZone)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer GetDockZoneContainer(UnityEditor.Overlays.DockZone @zone)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@zone};
            var ___result = RMGetDockZoneContainer_DockZone.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer(___result);
        }


        public virtual void SetOverlaysEnabled(System.Boolean @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visible};
            var ___result = RMSetOverlaysEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreateRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void SetPickingMode(UnityEngine.UIElements.VisualElement @element, UnityEngine.UIElements.PickingMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @mode};
            var ___result = RMSetPickingMode_VisualElement_PickingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseEnterOverlayContainer(UnityEngine.UIElements.MouseEnterEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseEnterOverlayContainer_MouseEnterEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAttachedToPanel(UnityEngine.UIElements.AttachToPanelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnAttachedToPanel_AttachToPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnDetachedFromPanel_DetachFromPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnContainerWindowDisabled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnContainerWindowDisabled.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect ClampToOverlayWindow(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMClampToOverlayWindow_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ClampRectToBounds(UnityEngine.Rect @boundary, UnityEngine.Rect @rectToClamp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@boundary, @rectToClamp};
            var ___result = RMClampRectToBounds_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void GeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseLeaveOverlay(UnityEngine.UIElements.MouseLeaveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseLeaveOverlay_MouseLeaveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseEnterOverlay(UnityEngine.UIElements.MouseEnterEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnMouseEnterOverlay_MouseEnterEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideHoveredOverlay()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHideHoveredOverlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowMenu(System.Boolean @show, System.Boolean @atMousePosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show, @atMousePosition};
            var ___result = RMShowMenu_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(UnityEditor.EditorWindow @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@window};
            var ___result = RMInitialize_EditorWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeAssemblyReload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeAssemblyReload.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetOriginGhostWorldBound()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOriginGhostWorldBound.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void HideOriginGhost()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHideOriginGhost.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowOriginGhost(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RMShowOriginGhost_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateGhostHover(System.Boolean @hovered)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hovered};
            var ___result = RMUpdateGhostHover_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteOrReplaceSaveData(UnityEditor.Overlays.Overlay @overlay, System.Int32 @containerIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @containerIndex};
            var ___result = RMWriteOrReplaceSaveData_Overlay_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopySaveData(out Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData> @saveData)
        {
			@saveData = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@saveData.Value};
            var ___result = RMCopySaveData_Out_SaveDataArray.Invoke(___genericsType, ___parameters);
			@saveData = new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData>(___parameters[0]);

            
        }


        public virtual void ApplyPreset(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayPreset @preset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@preset.Value};
            var ___result = RMApplyPreset_OverlayPreset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplySaveData(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData> @saveData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@saveData.Value};
            var ___result = RMApplySaveData_SaveDataArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Move(UnityEditor.Overlays.Overlay @overlay, UnityEditor.Overlays.DockZone @zone, UnityEditor.Overlays.DockPosition @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @zone, @position};
            var ___result = RMMove_Overlay_DockZone_DockPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Add(UnityEditor.Overlays.Overlay @overlay, System.Boolean @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @show};
            var ___result = RMAdd_Overlay_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Remove(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RMRemove_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddOverlay(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RMAddOverlay_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetOrCreateOverlay<T>(System.String @id) where T : UnityEditor.Overlays.Overlay, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@id};
            var ___result = RMGetOrCreateOverlay_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData FindSaveData(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RMFindSaveData_Overlay.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData(___result);
        }


        public virtual void RestoreOverlay(UnityEditor.Overlays.Overlay @overlay, Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay, @data.Value};
            var ___result = RMRestoreOverlay_Overlay_SaveData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreOverlays()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreOverlays.Invoke(___genericsType, ___parameters);

            
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
