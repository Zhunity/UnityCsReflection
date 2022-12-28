using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.Overlay
	/// </summary>
    public partial class ROverlay : RMember //
    {

		/// <summary>
		/// System.String k_UxmlPath
		/// </summary>
		protected static RField r_k_UxmlPath;
		public static RField Rk_UxmlPath
		{
			get
			{
				if(r_k_UxmlPath == null)
				{
					r_k_UxmlPath = new(typeof(UnityEditor.Overlays.Overlay), "k_UxmlPath");
					r_k_UxmlPath.SetBelong(null);
				}
				return r_k_UxmlPath;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RField r_ussClassName;
		public static RField RussClassName
		{
			get
			{
				if(r_ussClassName == null)
				{
					r_ussClassName = new(typeof(UnityEditor.Overlays.Overlay), "ussClassName");
					r_ussClassName.SetBelong(null);
				}
				return r_ussClassName;
			}
		}

		/// <summary>
		/// System.String k_Highlight
		/// </summary>
		protected static RField r_k_Highlight;
		public static RField Rk_Highlight
		{
			get
			{
				if(r_k_Highlight == null)
				{
					r_k_Highlight = new(typeof(UnityEditor.Overlays.Overlay), "k_Highlight");
					r_k_Highlight.SetBelong(null);
				}
				return r_k_Highlight;
			}
		}

		/// <summary>
		/// System.String k_Floating
		/// </summary>
		protected static RField r_k_Floating;
		public static RField Rk_Floating
		{
			get
			{
				if(r_k_Floating == null)
				{
					r_k_Floating = new(typeof(UnityEditor.Overlays.Overlay), "k_Floating");
					r_k_Floating.SetBelong(null);
				}
				return r_k_Floating;
			}
		}

		/// <summary>
		/// System.String headerTitle
		/// </summary>
		protected static RField r_headerTitle;
		public static RField RheaderTitle
		{
			get
			{
				if(r_headerTitle == null)
				{
					r_headerTitle = new(typeof(UnityEditor.Overlays.Overlay), "headerTitle");
					r_headerTitle.SetBelong(null);
				}
				return r_headerTitle;
			}
		}

		/// <summary>
		/// System.String k_Collapsed
		/// </summary>
		protected static RField r_k_Collapsed;
		public static RField Rk_Collapsed
		{
			get
			{
				if(r_k_Collapsed == null)
				{
					r_k_Collapsed = new(typeof(UnityEditor.Overlays.Overlay), "k_Collapsed");
					r_k_Collapsed.SetBelong(null);
				}
				return r_k_Collapsed;
			}
		}

		/// <summary>
		/// System.String k_Header
		/// </summary>
		protected static RField r_k_Header;
		public static RField Rk_Header
		{
			get
			{
				if(r_k_Header == null)
				{
					r_k_Header = new(typeof(UnityEditor.Overlays.Overlay), "k_Header");
					r_k_Header.SetBelong(null);
				}
				return r_k_Header;
			}
		}

		/// <summary>
		/// System.String k_Expanded
		/// </summary>
		protected static RField r_k_Expanded;
		public static RField Rk_Expanded
		{
			get
			{
				if(r_k_Expanded == null)
				{
					r_k_Expanded = new(typeof(UnityEditor.Overlays.Overlay), "k_Expanded");
					r_k_Expanded.SetBelong(null);
				}
				return r_k_Expanded;
			}
		}

		/// <summary>
		/// System.String k_CollapsedContent
		/// </summary>
		protected static RField r_k_CollapsedContent;
		public static RField Rk_CollapsedContent
		{
			get
			{
				if(r_k_CollapsedContent == null)
				{
					r_k_CollapsedContent = new(typeof(UnityEditor.Overlays.Overlay), "k_CollapsedContent");
					r_k_CollapsedContent.SetBelong(null);
				}
				return r_k_CollapsedContent;
			}
		}

		/// <summary>
		/// System.String k_CollapsedIconButton
		/// </summary>
		protected static RField r_k_CollapsedIconButton;
		public static RField Rk_CollapsedIconButton
		{
			get
			{
				if(r_k_CollapsedIconButton == null)
				{
					r_k_CollapsedIconButton = new(typeof(UnityEditor.Overlays.Overlay), "k_CollapsedIconButton");
					r_k_CollapsedIconButton.SetBelong(null);
				}
				return r_k_CollapsedIconButton;
			}
		}

		/// <summary>
		/// System.String k_ToolbarHorizontalLayout
		/// </summary>
		protected static RField r_k_ToolbarHorizontalLayout;
		public static RField Rk_ToolbarHorizontalLayout
		{
			get
			{
				if(r_k_ToolbarHorizontalLayout == null)
				{
					r_k_ToolbarHorizontalLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_ToolbarHorizontalLayout");
					r_k_ToolbarHorizontalLayout.SetBelong(null);
				}
				return r_k_ToolbarHorizontalLayout;
			}
		}

		/// <summary>
		/// System.String k_ToolbarVerticalLayout
		/// </summary>
		protected static RField r_k_ToolbarVerticalLayout;
		public static RField Rk_ToolbarVerticalLayout
		{
			get
			{
				if(r_k_ToolbarVerticalLayout == null)
				{
					r_k_ToolbarVerticalLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_ToolbarVerticalLayout");
					r_k_ToolbarVerticalLayout.SetBelong(null);
				}
				return r_k_ToolbarVerticalLayout;
			}
		}

		/// <summary>
		/// System.String k_PanelLayout
		/// </summary>
		protected static RField r_k_PanelLayout;
		public static RField Rk_PanelLayout
		{
			get
			{
				if(r_k_PanelLayout == null)
				{
					r_k_PanelLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_PanelLayout");
					r_k_PanelLayout.SetBelong(null);
				}
				return r_k_PanelLayout;
			}
		}

		/// <summary>
		/// System.String m_Id
		/// </summary>
		protected RField r_m_Id;
		public virtual RField Rm_Id
		{
			get
			{
				if(r_m_Id == null)
				{
					r_m_Id = new(this, "m_Id");
					r_m_Id.SetBelong(this.instance);
				}
				return r_m_Id;
			}
		}

		/// <summary>
		/// System.String m_RootVisualElementName
		/// </summary>
		protected RField r_m_RootVisualElementName;
		public virtual RField Rm_RootVisualElementName
		{
			get
			{
				if(r_m_RootVisualElementName == null)
				{
					r_m_RootVisualElementName = new(this, "m_RootVisualElementName");
					r_m_RootVisualElementName.SetBelong(this.instance);
				}
				return r_m_RootVisualElementName;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected RField r_m_DisplayName;
		public virtual RField Rm_DisplayName
		{
			get
			{
				if(r_m_DisplayName == null)
				{
					r_m_DisplayName = new(this, "m_DisplayName");
					r_m_DisplayName.SetBelong(this.instance);
				}
				return r_m_DisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_Layout
		/// </summary>
		protected RField r_m_Layout;
		public virtual RField Rm_Layout
		{
			get
			{
				if(r_m_Layout == null)
				{
					r_m_Layout = new(this, "m_Layout");
					r_m_Layout.SetBelong(this.instance);
				}
				return r_m_Layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_ActiveLayout
		/// </summary>
		protected RField r_m_ActiveLayout;
		public virtual RField Rm_ActiveLayout
		{
			get
			{
				if(r_m_ActiveLayout == null)
				{
					r_m_ActiveLayout = new(this, "m_ActiveLayout");
					r_m_ActiveLayout.SetBelong(this.instance);
				}
				return r_m_ActiveLayout;
			}
		}

		/// <summary>
		/// System.Boolean m_Collapsed
		/// </summary>
		protected RField r_m_Collapsed;
		public virtual RField Rm_Collapsed
		{
			get
			{
				if(r_m_Collapsed == null)
				{
					r_m_Collapsed = new(this, "m_Collapsed");
					r_m_Collapsed.SetBelong(this.instance);
				}
				return r_m_Collapsed;
			}
		}

		/// <summary>
		/// System.Boolean <dontSaveInLayout>k__BackingField
		/// </summary>
		protected RField r___1__dontSaveInLayout__2__k__BackingField;
		public virtual RField R__1__dontSaveInLayout__2__k__BackingField
		{
			get
			{
				if(r___1__dontSaveInLayout__2__k__BackingField == null)
				{
					r___1__dontSaveInLayout__2__k__BackingField = new(this, "<dontSaveInLayout>k__BackingField");
					r___1__dontSaveInLayout__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__dontSaveInLayout__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasMenuEntry
		/// </summary>
		protected RField r_m_HasMenuEntry;
		public virtual RField Rm_HasMenuEntry
		{
			get
			{
				if(r_m_HasMenuEntry == null)
				{
					r_m_HasMenuEntry = new(this, "m_HasMenuEntry");
					r_m_HasMenuEntry.SetBelong(this.instance);
				}
				return r_m_HasMenuEntry;
			}
		}

		/// <summary>
		/// System.Boolean m_Floating
		/// </summary>
		protected RField r_m_Floating;
		public virtual RField Rm_Floating
		{
			get
			{
				if(r_m_Floating == null)
				{
					r_m_Floating = new(this, "m_Floating");
					r_m_Floating.SetBelong(this.instance);
				}
				return r_m_Floating;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_FloatingSnapOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_m_FloatingSnapOffset;
		public virtual RUnityEngine.RVector2 Rm_FloatingSnapOffset
		{
			get
			{
				if(r_m_FloatingSnapOffset == null)
				{
					r_m_FloatingSnapOffset = new(this, "m_FloatingSnapOffset");
					r_m_FloatingSnapOffset.SetBelong(this.instance);
				}
				return r_m_FloatingSnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_SnapOffsetDelta
		/// </summary>
		protected RUnityEngine.RVector2 r_m_SnapOffsetDelta;
		public virtual RUnityEngine.RVector2 Rm_SnapOffsetDelta
		{
			get
			{
				if(r_m_SnapOffsetDelta == null)
				{
					r_m_SnapOffsetDelta = new(this, "m_SnapOffsetDelta");
					r_m_SnapOffsetDelta.SetBelong(this.instance);
				}
				return r_m_SnapOffsetDelta;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_MinSize;
		public virtual RUnityEngine.RVector2 Rm_MinSize
		{
			get
			{
				if(r_m_MinSize == null)
				{
					r_m_MinSize = new(this, "m_MinSize");
					r_m_MinSize.SetBelong(this.instance);
				}
				return r_m_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_MaxSize;
		public virtual RUnityEngine.RVector2 Rm_MaxSize
		{
			get
			{
				if(r_m_MaxSize == null)
				{
					r_m_MaxSize = new(this, "m_MaxSize");
					r_m_MaxSize.SetBelong(this.instance);
				}
				return r_m_MaxSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_Size
		/// </summary>
		protected RUnityEngine.RVector2 r_m_Size;
		public virtual RUnityEngine.RVector2 Rm_Size
		{
			get
			{
				if(r_m_Size == null)
				{
					r_m_Size = new(this, "m_Size");
					r_m_Size.SetBelong(this.instance);
				}
				return r_m_Size;
			}
		}

		/// <summary>
		/// System.Boolean m_SizeOverridden
		/// </summary>
		protected RField r_m_SizeOverridden;
		public virtual RField Rm_SizeOverridden
		{
			get
			{
				if(r_m_SizeOverridden == null)
				{
					r_m_SizeOverridden = new(this, "m_SizeOverridden");
					r_m_SizeOverridden.SetBelong(this.instance);
				}
				return r_m_SizeOverridden;
			}
		}

		/// <summary>
		/// System.Boolean m_LockAnchor
		/// </summary>
		protected RField r_m_LockAnchor;
		public virtual RField Rm_LockAnchor
		{
			get
			{
				if(r_m_LockAnchor == null)
				{
					r_m_LockAnchor = new(this, "m_LockAnchor");
					r_m_LockAnchor.SetBelong(this.instance);
				}
				return r_m_LockAnchor;
			}
		}

		/// <summary>
		/// System.Boolean m_ContentsChanged
		/// </summary>
		protected RField r_m_ContentsChanged;
		public virtual RField Rm_ContentsChanged
		{
			get
			{
				if(r_m_ContentsChanged == null)
				{
					r_m_ContentsChanged = new(this, "m_ContentsChanged");
					r_m_ContentsChanged.SetBelong(this.instance);
				}
				return r_m_ContentsChanged;
			}
		}

		/// <summary>
		/// System.Boolean m_DisableContentModification
		/// </summary>
		protected RField r_m_DisableContentModification;
		public virtual RField Rm_DisableContentModification
		{
			get
			{
				if(r_m_DisableContentModification == null)
				{
					r_m_DisableContentModification = new(this, "m_DisableContentModification");
					r_m_DisableContentModification.SetBelong(this.instance);
				}
				return r_m_DisableContentModification;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas <canvas>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r___1__canvas__2__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas R__1__canvas__2__k__BackingField
		{
			get
			{
				if(r___1__canvas__2__k__BackingField == null)
				{
					r___1__canvas__2__k__BackingField = new(this, "<canvas>k__BackingField");
					r___1__canvas__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__canvas__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer m_Container
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_m_Container;
		public virtual RUnityEditor.ROverlays.ROverlayContainer Rm_Container
		{
			get
			{
				if(r_m_Container == null)
				{
					r_m_Container = new(this, "m_Container");
					r_m_Container.SetBelong(this.instance);
				}
				return r_m_Container;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CurrentContent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_CurrentContent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_CurrentContent
		{
			get
			{
				if(r_m_CurrentContent == null)
				{
					r_m_CurrentContent = new(this, "m_CurrentContent");
					r_m_CurrentContent.SetBelong(this.instance);
				}
				return r_m_CurrentContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CollapsedContent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_CollapsedContent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_CollapsedContent
		{
			get
			{
				if(r_m_CollapsedContent == null)
				{
					r_m_CollapsedContent = new(this, "m_CollapsedContent");
					r_m_CollapsedContent.SetBelong(this.instance);
				}
				return r_m_CollapsedContent;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayPopup m_ModalPopup
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayPopup r_m_ModalPopup;
		public virtual RUnityEditor.ROverlays.ROverlayPopup Rm_ModalPopup
		{
			get
			{
				if(r_m_ModalPopup == null)
				{
					r_m_ModalPopup = new(this, "m_ModalPopup");
					r_m_ModalPopup.SetBelong(this.instance);
				}
				return r_m_ModalPopup;
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
		/// UnityEngine.UIElements.VisualElement m_ResizeTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_ResizeTarget;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_ResizeTarget
		{
			get
			{
				if(r_m_ResizeTarget == null)
				{
					r_m_ResizeTarget = new(this, "m_ResizeTarget");
					r_m_ResizeTarget.SetBelong(this.instance);
				}
				return r_m_ResizeTarget;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone m_BeforeDropZone
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayDropZone r_m_BeforeDropZone;
		public virtual RUnityEditor.ROverlays.ROverlayDropZone Rm_BeforeDropZone
		{
			get
			{
				if(r_m_BeforeDropZone == null)
				{
					r_m_BeforeDropZone = new(this, "m_BeforeDropZone");
					r_m_BeforeDropZone.SetBelong(this.instance);
				}
				return r_m_BeforeDropZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone m_AfterDropZone
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayDropZone r_m_AfterDropZone;
		public virtual RUnityEditor.ROverlays.ROverlayDropZone Rm_AfterDropZone
		{
			get
			{
				if(r_m_AfterDropZone == null)
				{
					r_m_AfterDropZone = new(this, "m_AfterDropZone");
					r_m_AfterDropZone.SetBelong(this.instance);
				}
				return r_m_AfterDropZone;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.Layout] layoutChanged
		/// </summary>
		protected RSystem.RAction<RField> r_layoutChanged;
		public virtual RSystem.RAction<RField> RlayoutChanged
		{
			get
			{
				if(r_layoutChanged == null)
				{
					r_layoutChanged = new(this, "layoutChanged");
					r_layoutChanged.SetBelong(this.instance);
				}
				return r_layoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] collapsedChanged
		/// </summary>
		protected RSystem.RAction<RField> r_collapsedChanged;
		public virtual RSystem.RAction<RField> RcollapsedChanged
		{
			get
			{
				if(r_collapsedChanged == null)
				{
					r_collapsedChanged = new(this, "collapsedChanged");
					r_collapsedChanged.SetBelong(this.instance);
				}
				return r_collapsedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] displayedChanged
		/// </summary>
		protected RSystem.RAction<RField> r_displayedChanged;
		public virtual RSystem.RAction<RField> RdisplayedChanged
		{
			get
			{
				if(r_displayedChanged == null)
				{
					r_displayedChanged = new(this, "displayedChanged");
					r_displayedChanged.SetBelong(this.instance);
				}
				return r_displayedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.OverlayContainer] containerChanged
		/// </summary>
		protected RSystem.RAction<RUnityEditor.ROverlays.ROverlayContainer> r_containerChanged;
		public virtual RSystem.RAction<RUnityEditor.ROverlays.ROverlayContainer> RcontainerChanged
		{
			get
			{
				if(r_containerChanged == null)
				{
					r_containerChanged = new(this, "containerChanged");
					r_containerChanged.SetBelong(this.instance);
				}
				return r_containerChanged;
			}
		}

		/// <summary>
		/// System.Action minSizeChanged
		/// </summary>
		protected RSystem.RAction r_minSizeChanged;
		public virtual RSystem.RAction RminSizeChanged
		{
			get
			{
				if(r_minSizeChanged == null)
				{
					r_minSizeChanged = new(this, "minSizeChanged");
					r_minSizeChanged.SetBelong(this.instance);
				}
				return r_minSizeChanged;
			}
		}

		/// <summary>
		/// System.Action maxSizeChanged
		/// </summary>
		protected RSystem.RAction r_maxSizeChanged;
		public virtual RSystem.RAction RmaxSizeChanged
		{
			get
			{
				if(r_maxSizeChanged == null)
				{
					r_maxSizeChanged = new(this, "maxSizeChanged");
					r_maxSizeChanged.SetBelong(this.instance);
				}
				return r_maxSizeChanged;
			}
		}

		/// <summary>
		/// System.Action sizeOverridenChanged
		/// </summary>
		protected RSystem.RAction r_sizeOverridenChanged;
		public virtual RSystem.RAction RsizeOverridenChanged
		{
			get
			{
				if(r_sizeOverridenChanged == null)
				{
					r_sizeOverridenChanged = new(this, "sizeOverridenChanged");
					r_sizeOverridenChanged.SetBelong(this.instance);
				}
				return r_sizeOverridenChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] floatingChanged
		/// </summary>
		protected RSystem.RAction<RField> r_floatingChanged;
		public virtual RSystem.RAction<RField> RfloatingChanged
		{
			get
			{
				if(r_floatingChanged == null)
				{
					r_floatingChanged = new(this, "floatingChanged");
					r_floatingChanged.SetBelong(this.instance);
				}
				return r_floatingChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Vector3] floatingPositionChanged
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RVector3> r_floatingPositionChanged;
		public virtual RSystem.RAction<RUnityEngine.RVector3> RfloatingPositionChanged
		{
			get
			{
				if(r_floatingPositionChanged == null)
				{
					r_floatingPositionChanged = new(this, "floatingPositionChanged");
					r_floatingPositionChanged.SetBelong(this.instance);
				}
				return r_floatingPositionChanged;
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
					r_s_TreeAsset = new(typeof(UnityEditor.Overlays.Overlay), "s_TreeAsset");
					r_s_TreeAsset.SetBelong(null);
				}
				return r_s_TreeAsset;
			}
		}

		/// <summary>
		/// System.Action displayNameChanged
		/// </summary>
		protected RSystem.RAction r_displayNameChanged;
		public virtual RSystem.RAction RdisplayNameChanged
		{
			get
			{
				if(r_displayNameChanged == null)
				{
					r_displayNameChanged = new(this, "displayNameChanged");
					r_displayNameChanged.SetBelong(this.instance);
				}
				return r_displayNameChanged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ContentRoot
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_ContentRoot;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_ContentRoot
		{
			get
			{
				if(r_m_ContentRoot == null)
				{
					r_m_ContentRoot = new(this, "m_ContentRoot");
					r_m_ContentRoot.SetBelong(this.instance);
				}
				return r_m_ContentRoot;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_CollapsedIcon
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_CollapsedIcon;
		public virtual RUnityEngine.RTexture2D Rm_CollapsedIcon
		{
			get
			{
				if(r_m_CollapsedIcon == null)
				{
					r_m_CollapsedIcon = new(this, "m_CollapsedIcon");
					r_m_CollapsedIcon.SetBelong(this.instance);
				}
				return r_m_CollapsedIcon;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner <floatingSnapCorner>k__BackingField
		/// </summary>
		protected RField r___1__floatingSnapCorner__2__k__BackingField;
		public virtual RField R__1__floatingSnapCorner__2__k__BackingField
		{
			get
			{
				if(r___1__floatingSnapCorner__2__k__BackingField == null)
				{
					r___1__floatingSnapCorner__2__k__BackingField = new(this, "<floatingSnapCorner>k__BackingField");
					r___1__floatingSnapCorner__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__floatingSnapCorner__2__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean dontSaveInLayout
		/// </summary>
		protected RProperty r_dontSaveInLayout;
		public virtual RProperty RdontSaveInLayout
		{
			get
			{
				if(r_dontSaveInLayout == null)
				{
					r_dontSaveInLayout = new(this, "dontSaveInLayout", -1);
					r_dontSaveInLayout.SetBelong(this.instance);
				}
				return r_dontSaveInLayout;
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
		/// UnityEditor.Overlays.OverlayCanvas canvas
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r_canvas;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas Rcanvas
		{
			get
			{
				if(r_canvas == null)
				{
					r_canvas = new(this, "canvas", -1);
					r_canvas.SetBelong(this.instance);
				}
				return r_canvas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement resizeTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_resizeTarget;
		public virtual RUnityEngine.RUIElements.RVisualElement RresizeTarget
		{
			get
			{
				if(r_resizeTarget == null)
				{
					r_resizeTarget = new(this, "resizeTarget", -1);
					r_resizeTarget.SetBelong(this.instance);
				}
				return r_resizeTarget;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// Boolean hasMenuEntry
		/// </summary>
		protected RProperty r_hasMenuEntry;
		public virtual RProperty RhasMenuEntry
		{
			get
			{
				if(r_hasMenuEntry == null)
				{
					r_hasMenuEntry = new(this, "hasMenuEntry", -1);
					r_hasMenuEntry.SetBelong(this.instance);
				}
				return r_hasMenuEntry;
			}
		}

		/// <summary>
		/// UnityEngine.Rect collapsedButtonRect
		/// </summary>
		protected RUnityEngine.RRect r_collapsedButtonRect;
		public virtual RUnityEngine.RRect RcollapsedButtonRect
		{
			get
			{
				if(r_collapsedButtonRect == null)
				{
					r_collapsedButtonRect = new(this, "collapsedButtonRect", -1);
					r_collapsedButtonRect.SetBelong(this.instance);
				}
				return r_collapsedButtonRect;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D collapsedIcon
		/// </summary>
		protected RUnityEngine.RTexture2D r_collapsedIcon_Texture2D;
		public virtual RUnityEngine.RTexture2D RcollapsedIcon_Texture2D
		{
			get
			{
				if(r_collapsedIcon_Texture2D == null)
				{
					r_collapsedIcon_Texture2D = new(this, "collapsedIcon", -1, typeof(UnityEngine.Texture2D));
					r_collapsedIcon_Texture2D.SetBelong(this.instance);
				}
				return r_collapsedIcon_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement collapsedContent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_collapsedContent;
		public virtual RUnityEngine.RUIElements.RVisualElement RcollapsedContent
		{
			get
			{
				if(r_collapsedContent == null)
				{
					r_collapsedContent = new(this, "collapsedContent", -1);
					r_collapsedContent.SetBelong(this.instance);
				}
				return r_collapsedContent;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout layout
		/// </summary>
		protected RProperty r_layout;
		public virtual RProperty Rlayout
		{
			get
			{
				if(r_layout == null)
				{
					r_layout = new(this, "layout", -1);
					r_layout.SetBelong(this.instance);
				}
				return r_layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout activeLayout
		/// </summary>
		protected RProperty r_activeLayout;
		public virtual RProperty RactiveLayout
		{
			get
			{
				if(r_activeLayout == null)
				{
					r_activeLayout = new(this, "activeLayout", -1);
					r_activeLayout.SetBelong(this.instance);
				}
				return r_activeLayout;
			}
		}

		/// <summary>
		/// Boolean collapsed
		/// </summary>
		protected RProperty r_collapsed;
		public virtual RProperty Rcollapsed
		{
			get
			{
				if(r_collapsed == null)
				{
					r_collapsed = new(this, "collapsed", -1);
					r_collapsed.SetBelong(this.instance);
				}
				return r_collapsed;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected RProperty r_displayName;
		public virtual RProperty RdisplayName
		{
			get
			{
				if(r_displayName == null)
				{
					r_displayName = new(this, "displayName", -1);
					r_displayName.SetBelong(this.instance);
				}
				return r_displayName;
			}
		}

		/// <summary>
		/// Boolean userControlledVisibility
		/// </summary>
		protected RProperty r_userControlledVisibility;
		public virtual RProperty RuserControlledVisibility
		{
			get
			{
				if(r_userControlledVisibility == null)
				{
					r_userControlledVisibility = new(this, "userControlledVisibility", -1);
					r_userControlledVisibility.SetBelong(this.instance);
				}
				return r_userControlledVisibility;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer container
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_container;
		public virtual RUnityEditor.ROverlays.ROverlayContainer Rcontainer
		{
			get
			{
				if(r_container == null)
				{
					r_container = new(this, "container", -1);
					r_container.SetBelong(this.instance);
				}
				return r_container;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone dockZone
		/// </summary>
		protected RProperty r_dockZone;
		public virtual RProperty RdockZone
		{
			get
			{
				if(r_dockZone == null)
				{
					r_dockZone = new(this, "dockZone", -1);
					r_dockZone.SetBelong(this.instance);
				}
				return r_dockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition dockPosition
		/// </summary>
		protected RProperty r_dockPosition;
		public virtual RProperty RdockPosition
		{
			get
			{
				if(r_dockPosition == null)
				{
					r_dockPosition = new(this, "dockPosition", -1);
					r_dockPosition.SetBelong(this.instance);
				}
				return r_dockPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset treeAsset
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualTreeAsset r_treeAsset;
		public static RUnityEngine.RUIElements.RVisualTreeAsset RtreeAsset
		{
			get
			{
				if(r_treeAsset == null)
				{
					r_treeAsset = new(typeof(UnityEditor.Overlays.Overlay), "treeAsset", -1);
					r_treeAsset.SetBelong(null);
				}
				return r_treeAsset;
			}
		}

		/// <summary>
		/// Boolean displayed
		/// </summary>
		protected RProperty r_displayed;
		public virtual RProperty Rdisplayed
		{
			get
			{
				if(r_displayed == null)
				{
					r_displayed = new(this, "displayed", -1);
					r_displayed.SetBelong(this.instance);
				}
				return r_displayed;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout supportedLayouts
		/// </summary>
		protected RProperty r_supportedLayouts;
		public virtual RProperty RsupportedLayouts
		{
			get
			{
				if(r_supportedLayouts == null)
				{
					r_supportedLayouts = new(this, "supportedLayouts", -1);
					r_supportedLayouts.SetBelong(this.instance);
				}
				return r_supportedLayouts;
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
		/// UnityEngine.UIElements.VisualElement contentRoot
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_contentRoot;
		public virtual RUnityEngine.RUIElements.RVisualElement RcontentRoot
		{
			get
			{
				if(r_contentRoot == null)
				{
					r_contentRoot = new(this, "contentRoot", -1);
					r_contentRoot.SetBelong(this.instance);
				}
				return r_contentRoot;
			}
		}

		/// <summary>
		/// Boolean isInToolbar
		/// </summary>
		protected RProperty r_isInToolbar;
		public virtual RProperty RisInToolbar
		{
			get
			{
				if(r_isInToolbar == null)
				{
					r_isInToolbar = new(this, "isInToolbar", -1);
					r_isInToolbar.SetBelong(this.instance);
				}
				return r_isInToolbar;
			}
		}

		/// <summary>
		/// Boolean sizeOverridden
		/// </summary>
		protected RProperty r_sizeOverridden;
		public virtual RProperty RsizeOverridden
		{
			get
			{
				if(r_sizeOverridden == null)
				{
					r_sizeOverridden = new(this, "sizeOverridden", -1);
					r_sizeOverridden.SetBelong(this.instance);
				}
				return r_sizeOverridden;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 sizeToSave
		/// </summary>
		protected RUnityEngine.RVector2 r_sizeToSave;
		public virtual RUnityEngine.RVector2 RsizeToSave
		{
			get
			{
				if(r_sizeToSave == null)
				{
					r_sizeToSave = new(this, "sizeToSave", -1);
					r_sizeToSave.SetBelong(this.instance);
				}
				return r_sizeToSave;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected RUnityEngine.RVector2 r_size;
		public virtual RUnityEngine.RVector2 Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size", -1);
					r_size.SetBelong(this.instance);
				}
				return r_size;
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
		/// UnityEditor.Overlays.SnapCorner floatingSnapCorner
		/// </summary>
		protected RProperty r_floatingSnapCorner;
		public virtual RProperty RfloatingSnapCorner
		{
			get
			{
				if(r_floatingSnapCorner == null)
				{
					r_floatingSnapCorner = new(this, "floatingSnapCorner", -1);
					r_floatingSnapCorner.SetBelong(this.instance);
				}
				return r_floatingSnapCorner;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 floatingSnapOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_floatingSnapOffset;
		public virtual RUnityEngine.RVector2 RfloatingSnapOffset
		{
			get
			{
				if(r_floatingSnapOffset == null)
				{
					r_floatingSnapOffset = new(this, "floatingSnapOffset", -1);
					r_floatingSnapOffset.SetBelong(this.instance);
				}
				return r_floatingSnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 floatingPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_floatingPosition;
		public virtual RUnityEngine.RVector2 RfloatingPosition
		{
			get
			{
				if(r_floatingPosition == null)
				{
					r_floatingPosition = new(this, "floatingPosition", -1);
					r_floatingPosition.SetBelong(this.instance);
				}
				return r_floatingPosition;
			}
		}

		/// <summary>
		/// Boolean floating
		/// </summary>
		protected RProperty r_floating;
		public virtual RProperty Rfloating
		{
			get
			{
				if(r_floating == null)
				{
					r_floating = new(this, "floating", -1);
					r_floating.SetBelong(this.instance);
				}
				return r_floating;
			}
		}

		/// <summary>
		/// System.String GetEventTypeErrorMessage(System.String)
		/// </summary>
		protected static RMethod r_RGetEventTypeErrorMessage_String;
		public static RMethod RGetEventTypeErrorMessage_String
		{
			get
			{
				if(r_RGetEventTypeErrorMessage_String == null)
				{
					r_RGetEventTypeErrorMessage_String = new(typeof(UnityEditor.Overlays.Overlay), "GetEventTypeErrorMessage", 0, typeof(System.String));
					r_RGetEventTypeErrorMessage_String.SetBelong(null);
				}
				return r_RGetEventTypeErrorMessage_String;
			}
		}

		/// <summary>
		/// Void ResetSize()
		/// </summary>
		protected RMethod r_RResetSize;
		public virtual RMethod RResetSize
		{
			get
			{
				if(r_RResetSize == null)
				{
					r_RResetSize = new(this, "ResetSize", 0);
					r_RResetSize.SetBelong(this.instance);
				}
				return r_RResetSize;
			}
		}

		/// <summary>
		/// Boolean CanCreateRequestedLayout(UnityEditor.Overlays.Layout)
		/// </summary>
		protected RMethod r_RCanCreateRequestedLayout_Layout;
		public virtual RMethod RCanCreateRequestedLayout_Layout
		{
			get
			{
				if(r_RCanCreateRequestedLayout_Layout == null)
				{
					r_RCanCreateRequestedLayout_Layout = new(this, "CanCreateRequestedLayout", 0, typeof(UnityEditor.Overlays.Layout));
					r_RCanCreateRequestedLayout_Layout.SetBelong(this.instance);
				}
				return r_RCanCreateRequestedLayout_Layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout GetBestLayoutForState()
		/// </summary>
		protected RMethod r_RGetBestLayoutForState;
		public virtual RMethod RGetBestLayoutForState
		{
			get
			{
				if(r_RGetBestLayoutForState == null)
				{
					r_RGetBestLayoutForState = new(this, "GetBestLayoutForState", 0);
					r_RGetBestLayoutForState.SetBelong(this.instance);
				}
				return r_RGetBestLayoutForState;
			}
		}

		/// <summary>
		/// Void RebuildContent()
		/// </summary>
		protected RMethod r_RRebuildContent;
		public virtual RMethod RRebuildContent
		{
			get
			{
				if(r_RRebuildContent == null)
				{
					r_RRebuildContent = new(this, "RebuildContent", 0);
					r_RRebuildContent.SetBelong(this.instance);
				}
				return r_RRebuildContent;
			}
		}

		/// <summary>
		/// Boolean ShouldUseSizeValue()
		/// </summary>
		protected RMethod r_RShouldUseSizeValue;
		public virtual RMethod RShouldUseSizeValue
		{
			get
			{
				if(r_RShouldUseSizeValue == null)
				{
					r_RShouldUseSizeValue = new(this, "ShouldUseSizeValue", 0);
					r_RShouldUseSizeValue.SetBelong(this.instance);
				}
				return r_RShouldUseSizeValue;
			}
		}

		/// <summary>
		/// Boolean IsSizeAuto(Single, Single)
		/// </summary>
		protected RMethod r_RIsSizeAuto_Single_Single;
		public virtual RMethod RIsSizeAuto_Single_Single
		{
			get
			{
				if(r_RIsSizeAuto_Single_Single == null)
				{
					r_RIsSizeAuto_Single_Single = new(this, "IsSizeAuto", 0, typeof(System.Single), typeof(System.Single));
					r_RIsSizeAuto_Single_Single.SetBelong(this.instance);
				}
				return r_RIsSizeAuto_Single_Single;
			}
		}

		/// <summary>
		/// Void UpdateSize()
		/// </summary>
		protected RMethod r_RUpdateSize;
		public virtual RMethod RUpdateSize
		{
			get
			{
				if(r_RUpdateSize == null)
				{
					r_RUpdateSize = new(this, "UpdateSize", 0);
					r_RUpdateSize.SetBelong(this.instance);
				}
				return r_RUpdateSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateContent(UnityEditor.Overlays.Layout)
		/// </summary>
		protected RMethod r_RCreateContent_Layout;
		public virtual RMethod RCreateContent_Layout
		{
			get
			{
				if(r_RCreateContent_Layout == null)
				{
					r_RCreateContent_Layout = new(this, "CreateContent", 0, typeof(UnityEditor.Overlays.Layout));
					r_RCreateContent_Layout.SetBelong(this.instance);
				}
				return r_RCreateContent_Layout;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePanelContent()
		/// </summary>
		protected RMethod r_RCreatePanelContent;
		public virtual RMethod RCreatePanelContent
		{
			get
			{
				if(r_RCreatePanelContent == null)
				{
					r_RCreatePanelContent = new(this, "CreatePanelContent", 0);
					r_RCreatePanelContent.SetBelong(this.instance);
				}
				return r_RCreatePanelContent;
			}
		}

		/// <summary>
		/// Void OnCreated()
		/// </summary>
		protected RMethod r_ROnCreated;
		public virtual RMethod ROnCreated
		{
			get
			{
				if(r_ROnCreated == null)
				{
					r_ROnCreated = new(this, "OnCreated", 0);
					r_ROnCreated.SetBelong(this.instance);
				}
				return r_ROnCreated;
			}
		}

		/// <summary>
		/// Void OnWillBeDestroyed()
		/// </summary>
		protected RMethod r_ROnWillBeDestroyed;
		public virtual RMethod ROnWillBeDestroyed
		{
			get
			{
				if(r_ROnWillBeDestroyed == null)
				{
					r_ROnWillBeDestroyed = new(this, "OnWillBeDestroyed", 0);
					r_ROnWillBeDestroyed.SetBelong(this.instance);
				}
				return r_ROnWillBeDestroyed;
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
		/// Void ToggleCollapsedPopup()
		/// </summary>
		protected RMethod r_RToggleCollapsedPopup;
		public virtual RMethod RToggleCollapsedPopup
		{
			get
			{
				if(r_RToggleCollapsedPopup == null)
				{
					r_RToggleCollapsedPopup = new(this, "ToggleCollapsedPopup", 0);
					r_RToggleCollapsedPopup.SetBelong(this.instance);
				}
				return r_RToggleCollapsedPopup;
			}
		}

		/// <summary>
		/// Void ClosePopup()
		/// </summary>
		protected RMethod r_RClosePopup;
		public virtual RMethod RClosePopup
		{
			get
			{
				if(r_RClosePopup == null)
				{
					r_RClosePopup = new(this, "ClosePopup", 0);
					r_RClosePopup.SetBelong(this.instance);
				}
				return r_RClosePopup;
			}
		}

		/// <summary>
		/// Status GetMenuItemState(Boolean)
		/// </summary>
		protected static RMethod r_RGetMenuItemState_Boolean;
		public static RMethod RGetMenuItemState_Boolean
		{
			get
			{
				if(r_RGetMenuItemState_Boolean == null)
				{
					r_RGetMenuItemState_Boolean = new(typeof(UnityEditor.Overlays.Overlay), "GetMenuItemState", 0, typeof(System.Boolean));
					r_RGetMenuItemState_Boolean.SetBelong(null);
				}
				return r_RGetMenuItemState_Boolean;
			}
		}

		/// <summary>
		/// Void BuildContextMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent)
		/// </summary>
		protected RMethod r_RBuildContextMenu_ContextualMenuPopulateEvent;
		public virtual RMethod RBuildContextMenu_ContextualMenuPopulateEvent
		{
			get
			{
				if(r_RBuildContextMenu_ContextualMenuPopulateEvent == null)
				{
					r_RBuildContextMenu_ContextualMenuPopulateEvent = new(this, "BuildContextMenu", 0, typeof(UnityEngine.UIElements.ContextualMenuPopulateEvent));
					r_RBuildContextMenu_ContextualMenuPopulateEvent.SetBelong(this.instance);
				}
				return r_RBuildContextMenu_ContextualMenuPopulateEvent;
			}
		}

		/// <summary>
		/// Void SetHighlightEnabled(Boolean)
		/// </summary>
		protected RMethod r_RSetHighlightEnabled_Boolean;
		public virtual RMethod RSetHighlightEnabled_Boolean
		{
			get
			{
				if(r_RSetHighlightEnabled_Boolean == null)
				{
					r_RSetHighlightEnabled_Boolean = new(this, "SetHighlightEnabled", 0, typeof(System.Boolean));
					r_RSetHighlightEnabled_Boolean.SetBelong(this.instance);
				}
				return r_RSetHighlightEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.Overlays.OverlayAttribute)
		/// </summary>
		protected RMethod r_RInitialize_OverlayAttribute;
		public virtual RMethod RInitialize_OverlayAttribute
		{
			get
			{
				if(r_RInitialize_OverlayAttribute == null)
				{
					r_RInitialize_OverlayAttribute = new(this, "Initialize", 0, typeof(UnityEditor.Overlays.OverlayAttribute));
					r_RInitialize_OverlayAttribute.SetBelong(this.instance);
				}
				return r_RInitialize_OverlayAttribute;
			}
		}

		/// <summary>
		/// Void Initialize(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RInitialize_String_String_String;
		public virtual RMethod RInitialize_String_String_String
		{
			get
			{
				if(r_RInitialize_String_String_String == null)
				{
					r_RInitialize_String_String_String = new(this, "Initialize", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RInitialize_String_String_String.SetBelong(this.instance);
				}
				return r_RInitialize_String_String_String;
			}
		}

		/// <summary>
		/// Void ApplySaveData(UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_RApplySaveData_SaveData;
		public virtual RMethod RApplySaveData_SaveData
		{
			get
			{
				if(r_RApplySaveData_SaveData == null)
				{
					r_RApplySaveData_SaveData = new(this, "ApplySaveData", 0,  ReleactionUtils.GetType("UnityEditor.Overlays.SaveData"));
					r_RApplySaveData_SaveData.SetBelong(this.instance);
				}
				return r_RApplySaveData_SaveData;
			}
		}

		/// <summary>
		/// Void OnFloatingChanged(Boolean)
		/// </summary>
		protected RMethod r_ROnFloatingChanged_Boolean;
		public virtual RMethod ROnFloatingChanged_Boolean
		{
			get
			{
				if(r_ROnFloatingChanged_Boolean == null)
				{
					r_ROnFloatingChanged_Boolean = new(this, "OnFloatingChanged", 0, typeof(System.Boolean));
					r_ROnFloatingChanged_Boolean.SetBelong(this.instance);
				}
				return r_ROnFloatingChanged_Boolean;
			}
		}

		/// <summary>
		/// Boolean DockAt(UnityEditor.Overlays.OverlayContainer, UnityEditor.Overlays.OverlayContainerSection)
		/// </summary>
		protected RMethod r_RDockAt_OverlayContainer_OverlayContainerSection;
		public virtual RMethod RDockAt_OverlayContainer_OverlayContainerSection
		{
			get
			{
				if(r_RDockAt_OverlayContainer_OverlayContainerSection == null)
				{
					r_RDockAt_OverlayContainer_OverlayContainerSection = new(this, "DockAt", 0,  ReleactionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReleactionUtils.GetType("UnityEditor.Overlays.OverlayContainerSection"));
					r_RDockAt_OverlayContainer_OverlayContainerSection.SetBelong(this.instance);
				}
				return r_RDockAt_OverlayContainer_OverlayContainerSection;
			}
		}

		/// <summary>
		/// Boolean DockAt(UnityEditor.Overlays.OverlayContainer, UnityEditor.Overlays.OverlayContainerSection, Int32)
		/// </summary>
		protected RMethod r_RDockAt_OverlayContainer_OverlayContainerSection_Int32;
		public virtual RMethod RDockAt_OverlayContainer_OverlayContainerSection_Int32
		{
			get
			{
				if(r_RDockAt_OverlayContainer_OverlayContainerSection_Int32 == null)
				{
					r_RDockAt_OverlayContainer_OverlayContainerSection_Int32 = new(this, "DockAt", 0,  ReleactionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReleactionUtils.GetType("UnityEditor.Overlays.OverlayContainerSection"), typeof(System.Int32));
					r_RDockAt_OverlayContainer_OverlayContainerSection_Int32.SetBelong(this.instance);
				}
				return r_RDockAt_OverlayContainer_OverlayContainerSection_Int32;
			}
		}

		/// <summary>
		/// Boolean DockBefore(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_RDockBefore_Overlay;
		public virtual RMethod RDockBefore_Overlay
		{
			get
			{
				if(r_RDockBefore_Overlay == null)
				{
					r_RDockBefore_Overlay = new(this, "DockBefore", 0, typeof(UnityEditor.Overlays.Overlay));
					r_RDockBefore_Overlay.SetBelong(this.instance);
				}
				return r_RDockBefore_Overlay;
			}
		}

		/// <summary>
		/// Boolean DockAfter(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_RDockAfter_Overlay;
		public virtual RMethod RDockAfter_Overlay
		{
			get
			{
				if(r_RDockAfter_Overlay == null)
				{
					r_RDockAfter_Overlay = new(this, "DockAfter", 0, typeof(UnityEditor.Overlays.Overlay));
					r_RDockAfter_Overlay.SetBelong(this.instance);
				}
				return r_RDockAfter_Overlay;
			}
		}

		/// <summary>
		/// Void Undock()
		/// </summary>
		protected RMethod r_RUndock;
		public virtual RMethod RUndock
		{
			get
			{
				if(r_RUndock == null)
				{
					r_RUndock = new(this, "Undock", 0);
					r_RUndock.SetBelong(this.instance);
				}
				return r_RUndock;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_RBringToFront;
		public virtual RMethod RBringToFront
		{
			get
			{
				if(r_RBringToFront == null)
				{
					r_RBringToFront = new(this, "BringToFront", 0);
					r_RBringToFront.SetBelong(this.instance);
				}
				return r_RBringToFront;
			}
		}

		/// <summary>
		/// Void SetSnappingOffset(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetSnappingOffset_Vector2_Vector2;
		public virtual RMethod RSetSnappingOffset_Vector2_Vector2
		{
			get
			{
				if(r_RSetSnappingOffset_Vector2_Vector2 == null)
				{
					r_RSetSnappingOffset_Vector2_Vector2 = new(this, "SetSnappingOffset", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RSetSnappingOffset_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_RSetSnappingOffset_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SnapToFloatingPosition(UnityEditor.Overlays.SnapCorner, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSnapToFloatingPosition_SnapCorner_Vector2;
		public virtual RMethod RSnapToFloatingPosition_SnapCorner_Vector2
		{
			get
			{
				if(r_RSnapToFloatingPosition_SnapCorner_Vector2 == null)
				{
					r_RSnapToFloatingPosition_SnapCorner_Vector2 = new(this, "SnapToFloatingPosition", 0,  ReleactionUtils.GetType("UnityEditor.Overlays.SnapCorner"), typeof(UnityEngine.Vector2));
					r_RSnapToFloatingPosition_SnapCorner_Vector2.SetBelong(this.instance);
				}
				return r_RSnapToFloatingPosition_SnapCorner_Vector2;
			}
		}

		/// <summary>
		/// Void FloatingToSnapPosition(UnityEngine.Vector2, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RFloatingToSnapPosition_Vector2_Out_Vector2;
		public virtual RMethod RFloatingToSnapPosition_Vector2_Out_Vector2
		{
			get
			{
				if(r_RFloatingToSnapPosition_Vector2_Out_Vector2 == null)
				{
					r_RFloatingToSnapPosition_Vector2_Out_Vector2 = new(this, "FloatingToSnapPosition", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RFloatingToSnapPosition_Vector2_Out_Vector2.SetBelong(this.instance);
				}
				return r_RFloatingToSnapPosition_Vector2_Out_Vector2;
			}
		}

		/// <summary>
		/// Void FloatingToSnapPosition(UnityEngine.Vector2, UnityEditor.Overlays.SnapCorner ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2;
		public virtual RMethod RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2
		{
			get
			{
				if(r_RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2 == null)
				{
					r_RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2 = new(this, "FloatingToSnapPosition", 0, typeof(UnityEngine.Vector2),  ReleactionUtils.GetType("UnityEditor.Overlays.SnapCorner").MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2.SetBelong(this.instance);
				}
				return r_RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2;
			}
		}

		/// <summary>
		/// Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_ROnGeometryChanged_GeometryChangedEvent;
		public virtual RMethod ROnGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_ROnGeometryChanged_GeometryChangedEvent == null)
				{
					r_ROnGeometryChanged_GeometryChangedEvent = new(this, "OnGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_ROnGeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_ROnGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void UpdateSnapping(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RUpdateSnapping_Vector2;
		public virtual RMethod RUpdateSnapping_Vector2
		{
			get
			{
				if(r_RUpdateSnapping_Vector2 == null)
				{
					r_RUpdateSnapping_Vector2 = new(this, "UpdateSnapping", 0, typeof(UnityEngine.Vector2));
					r_RUpdateSnapping_Vector2.SetBelong(this.instance);
				}
				return r_RUpdateSnapping_Vector2;
			}
		}

		/// <summary>
		/// Void UpdateAbsolutePosition()
		/// </summary>
		protected RMethod r_RUpdateAbsolutePosition;
		public virtual RMethod RUpdateAbsolutePosition
		{
			get
			{
				if(r_RUpdateAbsolutePosition == null)
				{
					r_RUpdateAbsolutePosition = new(this, "UpdateAbsolutePosition", 0);
					r_RUpdateAbsolutePosition.SetBelong(this.instance);
				}
				return r_RUpdateAbsolutePosition;
			}
		}

		/// <summary>
		/// Void <ToggleCollapsedPopup>b__154_0(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r_R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent;
		public virtual RMethod R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent
		{
			get
			{
				if(r_R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent == null)
				{
					r_R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent = new(this, "<ToggleCollapsedPopup>b__154_0", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r_R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent.SetBelong(this.instance);
				}
				return r_R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_0(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_0", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_1(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_1", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_2(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_2", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_3(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_3", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_4(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_4", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_5(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_5", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_6(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction;
		public virtual RMethod R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction
		{
			get
			{
				if(r_R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction == null)
				{
					r_R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_6", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction;
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


        public ROverlay() : base("UnityEditor.Overlays.Overlay")
        {
        }

        public ROverlay(System.Object instance) : base("UnityEditor.Overlays.Overlay")
		{
            SetInstance(instance);
		}

        public ROverlay(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROverlay(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String GetEventTypeErrorMessage(System.String  @errorEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errorEvent};
            var ___result = RGetEventTypeErrorMessage_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ResetSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanCreateRequestedLayout(UnityEditor.Overlays.Layout  @requested)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requested};
            var ___result = RCanCreateRequestedLayout_Layout.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.Overlays.Layout GetBestLayoutForState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBestLayoutForState.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Overlays.Layout)___result;
        }


        public virtual void RebuildContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRebuildContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldUseSizeValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldUseSizeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSizeAuto(System.Single  @min, System.Single  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RIsSizeAuto_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreateContent(UnityEditor.Overlays.Layout  @requestedLayout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedLayout};
            var ___result = RCreateContent_Layout.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement CreatePanelContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreatePanelContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void OnCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnWillBeDestroyed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnWillBeDestroyed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleCollapsedPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToggleCollapsedPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClosePopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClosePopup.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object GetMenuItemState(System.Boolean  @isChecked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isChecked};
            var ___result = RGetMenuItemState_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void BuildContextMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RBuildContextMenu_ContextualMenuPopulateEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHighlightEnabled(System.Boolean  @highlight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highlight};
            var ___result = RSetHighlightEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(UnityEditor.Overlays.OverlayAttribute  @attrib)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attrib};
            var ___result = RInitialize_OverlayAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.String  @_id, System.String  @_uss, System.String  @_display)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_id, @_uss, @_display};
            var ___result = RInitialize_String_String_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnFloatingChanged(System.Boolean  @floating)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@floating};
            var ___result = ROnFloatingChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Boolean DockBefore(UnityEditor.Overlays.Overlay  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RDockBefore_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockAfter(UnityEditor.Overlays.Overlay  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RDockAfter_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Undock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUndock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSnappingOffset(UnityEngine.Vector2  @snapOffset, UnityEngine.Vector2  @snapOffsetDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapOffset, @snapOffsetDelta};
            var ___result = RSetSnappingOffset_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void FloatingToSnapPosition(UnityEngine.Vector2  @position, out UnityEngine.Vector2  @snapOffset)
        {
			snapOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @snapOffset};
            var ___result = RFloatingToSnapPosition_Vector2_Out_Vector2.Invoke(___genericsType, ___parameters);
			snapOffset = (UnityEngine.Vector2)___parameters[1];

            
        }



        public virtual void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSnapping(UnityEngine.Vector2  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RUpdateSnapping_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAbsolutePosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAbsolutePosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__ToggleCollapsedPopup__2__b__154_0(UnityEngine.UIElements.FocusOutEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = R__1__ToggleCollapsedPopup__2__b__154_0_FocusOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_0(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_0_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_1(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_1_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_2(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_2_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_3(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_3_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_4(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_4_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_5(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_5_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __1__BuildContextMenu__2__b__157_6(UnityEngine.UIElements.DropdownMenuAction  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__1__BuildContextMenu__2__b__157_6_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
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