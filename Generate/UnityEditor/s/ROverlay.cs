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
		/// System.Action`1[UnityEditor.Overlays.Layout] layoutChanged
		/// </summary>
		protected REvent r_layoutChanged;
		public virtual REvent RlayoutChanged
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
		protected REvent r_collapsedChanged;
		public virtual REvent RcollapsedChanged
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
		protected REvent r_displayedChanged;
		public virtual REvent RdisplayedChanged
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
		protected REvent r_containerChanged;
		public virtual REvent RcontainerChanged
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
		protected REvent r_minSizeChanged;
		public virtual REvent RminSizeChanged
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
		protected REvent r_maxSizeChanged;
		public virtual REvent RmaxSizeChanged
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
		protected REvent r_sizeOverridenChanged;
		public virtual REvent RsizeOverridenChanged
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
		protected REvent r_floatingChanged;
		public virtual REvent RfloatingChanged
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
		protected REvent r_floatingPositionChanged;
		public virtual REvent RfloatingPositionChanged
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
		/// System.Action displayNameChanged
		/// </summary>
		protected REvent r_displayNameChanged;
		public virtual REvent RdisplayNameChanged
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
		/// System.String k_UxmlPath
		/// </summary>
		protected static RSystem.RString r_k_UxmlPath;
		public static RSystem.RString Rk_UxmlPath
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
		protected static RSystem.RString r_ussClassName;
		public static RSystem.RString RussClassName
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
		protected static RSystem.RString r_k_Highlight;
		public static RSystem.RString Rk_Highlight
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
		protected static RSystem.RString r_k_Floating;
		public static RSystem.RString Rk_Floating
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
		protected static RSystem.RString r_headerTitle;
		public static RSystem.RString RheaderTitle
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
		protected static RSystem.RString r_k_Collapsed;
		public static RSystem.RString Rk_Collapsed
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
		protected static RSystem.RString r_k_Header;
		public static RSystem.RString Rk_Header
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
		protected static RSystem.RString r_k_Expanded;
		public static RSystem.RString Rk_Expanded
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
		protected static RSystem.RString r_k_CollapsedContent;
		public static RSystem.RString Rk_CollapsedContent
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
		protected static RSystem.RString r_k_CollapsedIconButton;
		public static RSystem.RString Rk_CollapsedIconButton
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
		protected static RSystem.RString r_k_ToolbarHorizontalLayout;
		public static RSystem.RString Rk_ToolbarHorizontalLayout
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
		protected static RSystem.RString r_k_ToolbarVerticalLayout;
		public static RSystem.RString Rk_ToolbarVerticalLayout
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
		protected static RSystem.RString r_k_PanelLayout;
		public static RSystem.RString Rk_PanelLayout
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
		protected RSystem.RString r_m_Id;
		public virtual RSystem.RString Rm_Id
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
		protected RSystem.RString r_m_RootVisualElementName;
		public virtual RSystem.RString Rm_RootVisualElementName
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
		protected RSystem.RString r_m_DisplayName;
		public virtual RSystem.RString Rm_DisplayName
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
		protected RSystem.RBoolean r_m_Collapsed;
		public virtual RSystem.RBoolean Rm_Collapsed
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
		protected RSystem.RBoolean r___0__dontSaveInLayout__1__k__BackingField;
		public virtual RSystem.RBoolean R__0__dontSaveInLayout__1__k__BackingField
		{
			get
			{
				if(r___0__dontSaveInLayout__1__k__BackingField == null)
				{
					r___0__dontSaveInLayout__1__k__BackingField = new(this, "<dontSaveInLayout>k__BackingField");
					r___0__dontSaveInLayout__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dontSaveInLayout__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasMenuEntry
		/// </summary>
		protected RSystem.RBoolean r_m_HasMenuEntry;
		public virtual RSystem.RBoolean Rm_HasMenuEntry
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
		protected RSystem.RBoolean r_m_Floating;
		public virtual RSystem.RBoolean Rm_Floating
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
		protected RSystem.RBoolean r_m_SizeOverridden;
		public virtual RSystem.RBoolean Rm_SizeOverridden
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
		protected RSystem.RBoolean r_m_LockAnchor;
		public virtual RSystem.RBoolean Rm_LockAnchor
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
		protected RSystem.RBoolean r_m_ContentsChanged;
		public virtual RSystem.RBoolean Rm_ContentsChanged
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
		protected RSystem.RBoolean r_m_DisableContentModification;
		public virtual RSystem.RBoolean Rm_DisableContentModification
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
		protected RUnityEditor.ROverlays.ROverlayCanvas r___0__canvas__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas R__0__canvas__1__k__BackingField
		{
			get
			{
				if(r___0__canvas__1__k__BackingField == null)
				{
					r___0__canvas__1__k__BackingField = new(this, "<canvas>k__BackingField");
					r___0__canvas__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__canvas__1__k__BackingField;
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
		protected RField r___0__floatingSnapCorner__1__k__BackingField;
		public virtual RField R__0__floatingSnapCorner__1__k__BackingField
		{
			get
			{
				if(r___0__floatingSnapCorner__1__k__BackingField == null)
				{
					r___0__floatingSnapCorner__1__k__BackingField = new(this, "<floatingSnapCorner>k__BackingField");
					r___0__floatingSnapCorner__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__floatingSnapCorner__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean dontSaveInLayout
		/// </summary>
		protected RSystem.RBoolean r_dontSaveInLayout;
		public virtual RSystem.RBoolean RdontSaveInLayout
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
		protected RSystem.RString r_id;
		public virtual RSystem.RString Rid
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
		protected RSystem.RBoolean r_hasMenuEntry;
		public virtual RSystem.RBoolean RhasMenuEntry
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
		protected RUnityEngine.RTexture2D r_collapsedIcon;
		public virtual RUnityEngine.RTexture2D RcollapsedIcon
		{
			get
			{
				if(r_collapsedIcon == null)
				{
					r_collapsedIcon = new(this, "collapsedIcon", -1);
					r_collapsedIcon.SetBelong(this.instance);
				}
				return r_collapsedIcon;
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
		protected RSystem.RBoolean r_collapsed;
		public virtual RSystem.RBoolean Rcollapsed
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
		protected RSystem.RString r_displayName;
		public virtual RSystem.RString RdisplayName
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
		protected RSystem.RBoolean r_userControlledVisibility;
		public virtual RSystem.RBoolean RuserControlledVisibility
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
		protected RSystem.RBoolean r_displayed;
		public virtual RSystem.RBoolean Rdisplayed
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
		protected RSystem.RBoolean r_isInToolbar;
		public virtual RSystem.RBoolean RisInToolbar
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
		protected RSystem.RBoolean r_sizeOverridden;
		public virtual RSystem.RBoolean RsizeOverridden
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
		protected RSystem.RBoolean r_floating;
		public virtual RSystem.RBoolean Rfloating
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
		protected static RMethod r_GetEventTypeErrorMessage_String;
		public static RMethod RGetEventTypeErrorMessage_String
		{
			get
			{
				if(r_GetEventTypeErrorMessage_String == null)
				{
					r_GetEventTypeErrorMessage_String = new(typeof(UnityEditor.Overlays.Overlay), "GetEventTypeErrorMessage", 0, typeof(System.String));
					r_GetEventTypeErrorMessage_String.SetBelong(null);
				}
				return r_GetEventTypeErrorMessage_String;
			}
		}

		/// <summary>
		/// Void ResetSize()
		/// </summary>
		protected RMethod r_ResetSize;
		public virtual RMethod RResetSize
		{
			get
			{
				if(r_ResetSize == null)
				{
					r_ResetSize = new(this, "ResetSize", 0);
					r_ResetSize.SetBelong(this.instance);
				}
				return r_ResetSize;
			}
		}

		/// <summary>
		/// Boolean CanCreateRequestedLayout(UnityEditor.Overlays.Layout)
		/// </summary>
		protected RMethod r_CanCreateRequestedLayout_Layout;
		public virtual RMethod RCanCreateRequestedLayout_Layout
		{
			get
			{
				if(r_CanCreateRequestedLayout_Layout == null)
				{
					r_CanCreateRequestedLayout_Layout = new(this, "CanCreateRequestedLayout", 0, typeof(UnityEditor.Overlays.Layout));
					r_CanCreateRequestedLayout_Layout.SetBelong(this.instance);
				}
				return r_CanCreateRequestedLayout_Layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout GetBestLayoutForState()
		/// </summary>
		protected RMethod r_GetBestLayoutForState;
		public virtual RMethod RGetBestLayoutForState
		{
			get
			{
				if(r_GetBestLayoutForState == null)
				{
					r_GetBestLayoutForState = new(this, "GetBestLayoutForState", 0);
					r_GetBestLayoutForState.SetBelong(this.instance);
				}
				return r_GetBestLayoutForState;
			}
		}

		/// <summary>
		/// Void RebuildContent()
		/// </summary>
		protected RMethod r_RebuildContent;
		public virtual RMethod RRebuildContent
		{
			get
			{
				if(r_RebuildContent == null)
				{
					r_RebuildContent = new(this, "RebuildContent", 0);
					r_RebuildContent.SetBelong(this.instance);
				}
				return r_RebuildContent;
			}
		}

		/// <summary>
		/// Boolean ShouldUseSizeValue()
		/// </summary>
		protected RMethod r_ShouldUseSizeValue;
		public virtual RMethod RShouldUseSizeValue
		{
			get
			{
				if(r_ShouldUseSizeValue == null)
				{
					r_ShouldUseSizeValue = new(this, "ShouldUseSizeValue", 0);
					r_ShouldUseSizeValue.SetBelong(this.instance);
				}
				return r_ShouldUseSizeValue;
			}
		}

		/// <summary>
		/// Boolean IsSizeAuto(Single, Single)
		/// </summary>
		protected RMethod r_IsSizeAuto_Single_Single;
		public virtual RMethod RIsSizeAuto_Single_Single
		{
			get
			{
				if(r_IsSizeAuto_Single_Single == null)
				{
					r_IsSizeAuto_Single_Single = new(this, "IsSizeAuto", 0, typeof(System.Single), typeof(System.Single));
					r_IsSizeAuto_Single_Single.SetBelong(this.instance);
				}
				return r_IsSizeAuto_Single_Single;
			}
		}

		/// <summary>
		/// Void UpdateSize()
		/// </summary>
		protected RMethod r_UpdateSize;
		public virtual RMethod RUpdateSize
		{
			get
			{
				if(r_UpdateSize == null)
				{
					r_UpdateSize = new(this, "UpdateSize", 0);
					r_UpdateSize.SetBelong(this.instance);
				}
				return r_UpdateSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateContent(UnityEditor.Overlays.Layout)
		/// </summary>
		protected RMethod r_CreateContent_Layout;
		public virtual RMethod RCreateContent_Layout
		{
			get
			{
				if(r_CreateContent_Layout == null)
				{
					r_CreateContent_Layout = new(this, "CreateContent", 0, typeof(UnityEditor.Overlays.Layout));
					r_CreateContent_Layout.SetBelong(this.instance);
				}
				return r_CreateContent_Layout;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePanelContent()
		/// </summary>
		protected RMethod r_CreatePanelContent;
		public virtual RMethod RCreatePanelContent
		{
			get
			{
				if(r_CreatePanelContent == null)
				{
					r_CreatePanelContent = new(this, "CreatePanelContent", 0);
					r_CreatePanelContent.SetBelong(this.instance);
				}
				return r_CreatePanelContent;
			}
		}

		/// <summary>
		/// Void OnCreated()
		/// </summary>
		protected RMethod r_OnCreated;
		public virtual RMethod ROnCreated
		{
			get
			{
				if(r_OnCreated == null)
				{
					r_OnCreated = new(this, "OnCreated", 0);
					r_OnCreated.SetBelong(this.instance);
				}
				return r_OnCreated;
			}
		}

		/// <summary>
		/// Void OnWillBeDestroyed()
		/// </summary>
		protected RMethod r_OnWillBeDestroyed;
		public virtual RMethod ROnWillBeDestroyed
		{
			get
			{
				if(r_OnWillBeDestroyed == null)
				{
					r_OnWillBeDestroyed = new(this, "OnWillBeDestroyed", 0);
					r_OnWillBeDestroyed.SetBelong(this.instance);
				}
				return r_OnWillBeDestroyed;
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
		/// Void ToggleCollapsedPopup()
		/// </summary>
		protected RMethod r_ToggleCollapsedPopup;
		public virtual RMethod RToggleCollapsedPopup
		{
			get
			{
				if(r_ToggleCollapsedPopup == null)
				{
					r_ToggleCollapsedPopup = new(this, "ToggleCollapsedPopup", 0);
					r_ToggleCollapsedPopup.SetBelong(this.instance);
				}
				return r_ToggleCollapsedPopup;
			}
		}

		/// <summary>
		/// Void ClosePopup()
		/// </summary>
		protected RMethod r_ClosePopup;
		public virtual RMethod RClosePopup
		{
			get
			{
				if(r_ClosePopup == null)
				{
					r_ClosePopup = new(this, "ClosePopup", 0);
					r_ClosePopup.SetBelong(this.instance);
				}
				return r_ClosePopup;
			}
		}

		/// <summary>
		/// Status GetMenuItemState(Boolean)
		/// </summary>
		protected static RMethod r_GetMenuItemState_Boolean;
		public static RMethod RGetMenuItemState_Boolean
		{
			get
			{
				if(r_GetMenuItemState_Boolean == null)
				{
					r_GetMenuItemState_Boolean = new(typeof(UnityEditor.Overlays.Overlay), "GetMenuItemState", 0, typeof(System.Boolean));
					r_GetMenuItemState_Boolean.SetBelong(null);
				}
				return r_GetMenuItemState_Boolean;
			}
		}

		/// <summary>
		/// Void BuildContextMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent)
		/// </summary>
		protected RMethod r_BuildContextMenu_ContextualMenuPopulateEvent;
		public virtual RMethod RBuildContextMenu_ContextualMenuPopulateEvent
		{
			get
			{
				if(r_BuildContextMenu_ContextualMenuPopulateEvent == null)
				{
					r_BuildContextMenu_ContextualMenuPopulateEvent = new(this, "BuildContextMenu", 0, typeof(UnityEngine.UIElements.ContextualMenuPopulateEvent));
					r_BuildContextMenu_ContextualMenuPopulateEvent.SetBelong(this.instance);
				}
				return r_BuildContextMenu_ContextualMenuPopulateEvent;
			}
		}

		/// <summary>
		/// Void SetHighlightEnabled(Boolean)
		/// </summary>
		protected RMethod r_SetHighlightEnabled_Boolean;
		public virtual RMethod RSetHighlightEnabled_Boolean
		{
			get
			{
				if(r_SetHighlightEnabled_Boolean == null)
				{
					r_SetHighlightEnabled_Boolean = new(this, "SetHighlightEnabled", 0, typeof(System.Boolean));
					r_SetHighlightEnabled_Boolean.SetBelong(this.instance);
				}
				return r_SetHighlightEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.Overlays.OverlayAttribute)
		/// </summary>
		protected RMethod r_Initialize_OverlayAttribute;
		public virtual RMethod RInitialize_OverlayAttribute
		{
			get
			{
				if(r_Initialize_OverlayAttribute == null)
				{
					r_Initialize_OverlayAttribute = new(this, "Initialize", 0, typeof(UnityEditor.Overlays.OverlayAttribute));
					r_Initialize_OverlayAttribute.SetBelong(this.instance);
				}
				return r_Initialize_OverlayAttribute;
			}
		}

		/// <summary>
		/// Void Initialize(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_Initialize_String_String_String;
		public virtual RMethod RInitialize_String_String_String
		{
			get
			{
				if(r_Initialize_String_String_String == null)
				{
					r_Initialize_String_String_String = new(this, "Initialize", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_Initialize_String_String_String.SetBelong(this.instance);
				}
				return r_Initialize_String_String_String;
			}
		}

		/// <summary>
		/// Void ApplySaveData(UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_ApplySaveData_SaveData;
		public virtual RMethod RApplySaveData_SaveData
		{
			get
			{
				if(r_ApplySaveData_SaveData == null)
				{
					r_ApplySaveData_SaveData = new(this, "ApplySaveData", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"));
					r_ApplySaveData_SaveData.SetBelong(this.instance);
				}
				return r_ApplySaveData_SaveData;
			}
		}

		/// <summary>
		/// Void OnFloatingChanged(Boolean)
		/// </summary>
		protected RMethod r_OnFloatingChanged_Boolean;
		public virtual RMethod ROnFloatingChanged_Boolean
		{
			get
			{
				if(r_OnFloatingChanged_Boolean == null)
				{
					r_OnFloatingChanged_Boolean = new(this, "OnFloatingChanged", 0, typeof(System.Boolean));
					r_OnFloatingChanged_Boolean.SetBelong(this.instance);
				}
				return r_OnFloatingChanged_Boolean;
			}
		}

		/// <summary>
		/// Boolean DockAt(UnityEditor.Overlays.OverlayContainer, UnityEditor.Overlays.OverlayContainerSection)
		/// </summary>
		protected RMethod r_DockAt_OverlayContainer_OverlayContainerSection;
		public virtual RMethod RDockAt_OverlayContainer_OverlayContainerSection
		{
			get
			{
				if(r_DockAt_OverlayContainer_OverlayContainerSection == null)
				{
					r_DockAt_OverlayContainer_OverlayContainerSection = new(this, "DockAt", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainerSection"));
					r_DockAt_OverlayContainer_OverlayContainerSection.SetBelong(this.instance);
				}
				return r_DockAt_OverlayContainer_OverlayContainerSection;
			}
		}

		/// <summary>
		/// Boolean DockAt(UnityEditor.Overlays.OverlayContainer, UnityEditor.Overlays.OverlayContainerSection, Int32)
		/// </summary>
		protected RMethod r_DockAt_OverlayContainer_OverlayContainerSection_Int32;
		public virtual RMethod RDockAt_OverlayContainer_OverlayContainerSection_Int32
		{
			get
			{
				if(r_DockAt_OverlayContainer_OverlayContainerSection_Int32 == null)
				{
					r_DockAt_OverlayContainer_OverlayContainerSection_Int32 = new(this, "DockAt", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainerSection"), typeof(System.Int32));
					r_DockAt_OverlayContainer_OverlayContainerSection_Int32.SetBelong(this.instance);
				}
				return r_DockAt_OverlayContainer_OverlayContainerSection_Int32;
			}
		}

		/// <summary>
		/// Boolean DockBefore(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_DockBefore_Overlay;
		public virtual RMethod RDockBefore_Overlay
		{
			get
			{
				if(r_DockBefore_Overlay == null)
				{
					r_DockBefore_Overlay = new(this, "DockBefore", 0, typeof(UnityEditor.Overlays.Overlay));
					r_DockBefore_Overlay.SetBelong(this.instance);
				}
				return r_DockBefore_Overlay;
			}
		}

		/// <summary>
		/// Boolean DockAfter(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_DockAfter_Overlay;
		public virtual RMethod RDockAfter_Overlay
		{
			get
			{
				if(r_DockAfter_Overlay == null)
				{
					r_DockAfter_Overlay = new(this, "DockAfter", 0, typeof(UnityEditor.Overlays.Overlay));
					r_DockAfter_Overlay.SetBelong(this.instance);
				}
				return r_DockAfter_Overlay;
			}
		}

		/// <summary>
		/// Void Undock()
		/// </summary>
		protected RMethod r_Undock;
		public virtual RMethod RUndock
		{
			get
			{
				if(r_Undock == null)
				{
					r_Undock = new(this, "Undock", 0);
					r_Undock.SetBelong(this.instance);
				}
				return r_Undock;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_BringToFront;
		public virtual RMethod RBringToFront
		{
			get
			{
				if(r_BringToFront == null)
				{
					r_BringToFront = new(this, "BringToFront", 0);
					r_BringToFront.SetBelong(this.instance);
				}
				return r_BringToFront;
			}
		}

		/// <summary>
		/// Void SetSnappingOffset(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetSnappingOffset_Vector2_Vector2;
		public virtual RMethod RSetSnappingOffset_Vector2_Vector2
		{
			get
			{
				if(r_SetSnappingOffset_Vector2_Vector2 == null)
				{
					r_SetSnappingOffset_Vector2_Vector2 = new(this, "SetSnappingOffset", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_SetSnappingOffset_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_SetSnappingOffset_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SnapToFloatingPosition(UnityEditor.Overlays.SnapCorner, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SnapToFloatingPosition_SnapCorner_Vector2;
		public virtual RMethod RSnapToFloatingPosition_SnapCorner_Vector2
		{
			get
			{
				if(r_SnapToFloatingPosition_SnapCorner_Vector2 == null)
				{
					r_SnapToFloatingPosition_SnapCorner_Vector2 = new(this, "SnapToFloatingPosition", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SnapCorner"), typeof(UnityEngine.Vector2));
					r_SnapToFloatingPosition_SnapCorner_Vector2.SetBelong(this.instance);
				}
				return r_SnapToFloatingPosition_SnapCorner_Vector2;
			}
		}

		/// <summary>
		/// Void FloatingToSnapPosition(UnityEngine.Vector2, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_FloatingToSnapPosition_Vector2_Out_Vector2;
		public virtual RMethod RFloatingToSnapPosition_Vector2_Out_Vector2
		{
			get
			{
				if(r_FloatingToSnapPosition_Vector2_Out_Vector2 == null)
				{
					r_FloatingToSnapPosition_Vector2_Out_Vector2 = new(this, "FloatingToSnapPosition", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType());
					r_FloatingToSnapPosition_Vector2_Out_Vector2.SetBelong(this.instance);
				}
				return r_FloatingToSnapPosition_Vector2_Out_Vector2;
			}
		}

		/// <summary>
		/// Void FloatingToSnapPosition(UnityEngine.Vector2, UnityEditor.Overlays.SnapCorner ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_FloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2;
		public virtual RMethod RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2
		{
			get
			{
				if(r_FloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2 == null)
				{
					r_FloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2 = new(this, "FloatingToSnapPosition", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.Overlays.SnapCorner").MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_FloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2.SetBelong(this.instance);
				}
				return r_FloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2;
			}
		}

		/// <summary>
		/// Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_OnGeometryChanged_GeometryChangedEvent;
		public virtual RMethod ROnGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_OnGeometryChanged_GeometryChangedEvent == null)
				{
					r_OnGeometryChanged_GeometryChangedEvent = new(this, "OnGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_OnGeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_OnGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void UpdateSnapping(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_UpdateSnapping_Vector2;
		public virtual RMethod RUpdateSnapping_Vector2
		{
			get
			{
				if(r_UpdateSnapping_Vector2 == null)
				{
					r_UpdateSnapping_Vector2 = new(this, "UpdateSnapping", 0, typeof(UnityEngine.Vector2));
					r_UpdateSnapping_Vector2.SetBelong(this.instance);
				}
				return r_UpdateSnapping_Vector2;
			}
		}

		/// <summary>
		/// Void UpdateAbsolutePosition()
		/// </summary>
		protected RMethod r_UpdateAbsolutePosition;
		public virtual RMethod RUpdateAbsolutePosition
		{
			get
			{
				if(r_UpdateAbsolutePosition == null)
				{
					r_UpdateAbsolutePosition = new(this, "UpdateAbsolutePosition", 0);
					r_UpdateAbsolutePosition.SetBelong(this.instance);
				}
				return r_UpdateAbsolutePosition;
			}
		}

		/// <summary>
		/// Void <ToggleCollapsedPopup>b__154_0(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r___0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent;
		public virtual RMethod R__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent
		{
			get
			{
				if(r___0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent == null)
				{
					r___0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent = new(this, "<ToggleCollapsedPopup>b__154_0", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r___0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent.SetBelong(this.instance);
				}
				return r___0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_0(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_0_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_0_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_0_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_0_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_0", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_0_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_0_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_1(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_1_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_1_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_1_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_1_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_1", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_1_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_1_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_2(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_2_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_2_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_2_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_2_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_2", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_2_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_2_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_3(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_3_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_3_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_3_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_3_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_3", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_3_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_3_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_4(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_4_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_4_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_4_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_4_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_4", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_4_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_4_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_5(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_5_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_5_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_5_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_5_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_5", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_5_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_5_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_6(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r___0__BuildContextMenu__1__b__157_6_DropdownMenuAction;
		public virtual RMethod R__0__BuildContextMenu__1__b__157_6_DropdownMenuAction
		{
			get
			{
				if(r___0__BuildContextMenu__1__b__157_6_DropdownMenuAction == null)
				{
					r___0__BuildContextMenu__1__b__157_6_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_6", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r___0__BuildContextMenu__1__b__157_6_DropdownMenuAction.SetBelong(this.instance);
				}
				return r___0__BuildContextMenu__1__b__157_6_DropdownMenuAction;
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

        public static System.String GetEventTypeErrorMessage(System.String @errorEvent)
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


        public virtual System.Boolean CanCreateRequestedLayout(UnityEditor.Overlays.Layout @requested)
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


        public virtual System.Boolean IsSizeAuto(System.Single @min, System.Single @max)
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


        public virtual UnityEngine.UIElements.VisualElement CreateContent(UnityEditor.Overlays.Layout @requestedLayout)
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


        public static RType GetMenuItemState(System.Boolean @isChecked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isChecked};
            var ___result = RGetMenuItemState_Boolean.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual void BuildContextMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RBuildContextMenu_ContextualMenuPopulateEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHighlightEnabled(System.Boolean @highlight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highlight};
            var ___result = RSetHighlightEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(UnityEditor.Overlays.OverlayAttribute @attrib)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attrib};
            var ___result = RInitialize_OverlayAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.String @_id, System.String @_uss, System.String @_display)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_id, @_uss, @_display};
            var ___result = RInitialize_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplySaveData(RUnityEditor.ROverlays.RSaveData @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value};
            var ___result = RApplySaveData_SaveData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFloatingChanged(System.Boolean @floating)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@floating};
            var ___result = ROnFloatingChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DockAt(RUnityEditor.ROverlays.ROverlayContainer @container, RType @section)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value, @section.Value};
            var ___result = RDockAt_OverlayContainer_OverlayContainerSection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockAt(RUnityEditor.ROverlays.ROverlayContainer @container, RType @section, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value, @section.Value, @index};
            var ___result = RDockAt_OverlayContainer_OverlayContainerSection_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockBefore(UnityEditor.Overlays.Overlay @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RDockBefore_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockAfter(UnityEditor.Overlays.Overlay @target)
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


        public virtual void SetSnappingOffset(UnityEngine.Vector2 @snapOffset, UnityEngine.Vector2 @snapOffsetDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapOffset, @snapOffsetDelta};
            var ___result = RSetSnappingOffset_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 SnapToFloatingPosition(RType @corner, UnityEngine.Vector2 @snapPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@corner.Value, @snapPosition};
            var ___result = RSnapToFloatingPosition_SnapCorner_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void FloatingToSnapPosition(UnityEngine.Vector2 @position, out UnityEngine.Vector2 @snapOffset)
        {
			@snapOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @snapOffset};
            var ___result = RFloatingToSnapPosition_Vector2_Out_Vector2.Invoke(___genericsType, ___parameters);
			@snapOffset = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void FloatingToSnapPosition(UnityEngine.Vector2 @position, out RType @snapCorner, out UnityEngine.Vector2 @snapOffset)
        {
			@snapCorner = default;
			@snapOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @snapCorner.Value, @snapOffset};
            var ___result = RFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2.Invoke(___genericsType, ___parameters);
			@snapCorner = new RType(___parameters[1]);
			@snapOffset = (UnityEngine.Vector2)___parameters[2];

            
        }


        public virtual void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = ROnGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSnapping(UnityEngine.Vector2 @position)
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


        public virtual void __0__ToggleCollapsedPopup__1__b__154_0(UnityEngine.UIElements.FocusOutEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = R__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_0(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_0_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_1(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_1_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_2(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_2_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_3(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_3_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_4(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_4_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_5(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_5_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_6(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = R__0__BuildContextMenu__1__b__157_6_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
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
