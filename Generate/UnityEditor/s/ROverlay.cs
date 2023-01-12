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
		protected REvent r_ElayoutChanged;
		public virtual REvent RElayoutChanged
		{
			get
			{
				if(r_ElayoutChanged == null)
				{
					r_ElayoutChanged = new(this, "layoutChanged");
					r_ElayoutChanged.SetBelong(this.instance);
				}
				return r_ElayoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] collapsedChanged
		/// </summary>
		protected REvent r_EcollapsedChanged;
		public virtual REvent REcollapsedChanged
		{
			get
			{
				if(r_EcollapsedChanged == null)
				{
					r_EcollapsedChanged = new(this, "collapsedChanged");
					r_EcollapsedChanged.SetBelong(this.instance);
				}
				return r_EcollapsedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] displayedChanged
		/// </summary>
		protected REvent r_EdisplayedChanged;
		public virtual REvent REdisplayedChanged
		{
			get
			{
				if(r_EdisplayedChanged == null)
				{
					r_EdisplayedChanged = new(this, "displayedChanged");
					r_EdisplayedChanged.SetBelong(this.instance);
				}
				return r_EdisplayedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.OverlayContainer] containerChanged
		/// </summary>
		protected REvent r_EcontainerChanged;
		public virtual REvent REcontainerChanged
		{
			get
			{
				if(r_EcontainerChanged == null)
				{
					r_EcontainerChanged = new(this, "containerChanged");
					r_EcontainerChanged.SetBelong(this.instance);
				}
				return r_EcontainerChanged;
			}
		}

		/// <summary>
		/// System.Action minSizeChanged
		/// </summary>
		protected REvent r_EminSizeChanged;
		public virtual REvent REminSizeChanged
		{
			get
			{
				if(r_EminSizeChanged == null)
				{
					r_EminSizeChanged = new(this, "minSizeChanged");
					r_EminSizeChanged.SetBelong(this.instance);
				}
				return r_EminSizeChanged;
			}
		}

		/// <summary>
		/// System.Action maxSizeChanged
		/// </summary>
		protected REvent r_EmaxSizeChanged;
		public virtual REvent REmaxSizeChanged
		{
			get
			{
				if(r_EmaxSizeChanged == null)
				{
					r_EmaxSizeChanged = new(this, "maxSizeChanged");
					r_EmaxSizeChanged.SetBelong(this.instance);
				}
				return r_EmaxSizeChanged;
			}
		}

		/// <summary>
		/// System.Action sizeOverridenChanged
		/// </summary>
		protected REvent r_EsizeOverridenChanged;
		public virtual REvent REsizeOverridenChanged
		{
			get
			{
				if(r_EsizeOverridenChanged == null)
				{
					r_EsizeOverridenChanged = new(this, "sizeOverridenChanged");
					r_EsizeOverridenChanged.SetBelong(this.instance);
				}
				return r_EsizeOverridenChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] floatingChanged
		/// </summary>
		protected REvent r_EfloatingChanged;
		public virtual REvent REfloatingChanged
		{
			get
			{
				if(r_EfloatingChanged == null)
				{
					r_EfloatingChanged = new(this, "floatingChanged");
					r_EfloatingChanged.SetBelong(this.instance);
				}
				return r_EfloatingChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Vector3] floatingPositionChanged
		/// </summary>
		protected REvent r_EfloatingPositionChanged;
		public virtual REvent REfloatingPositionChanged
		{
			get
			{
				if(r_EfloatingPositionChanged == null)
				{
					r_EfloatingPositionChanged = new(this, "floatingPositionChanged");
					r_EfloatingPositionChanged.SetBelong(this.instance);
				}
				return r_EfloatingPositionChanged;
			}
		}

		/// <summary>
		/// System.Action displayNameChanged
		/// </summary>
		protected REvent r_EdisplayNameChanged;
		public virtual REvent REdisplayNameChanged
		{
			get
			{
				if(r_EdisplayNameChanged == null)
				{
					r_EdisplayNameChanged = new(this, "displayNameChanged");
					r_EdisplayNameChanged.SetBelong(this.instance);
				}
				return r_EdisplayNameChanged;
			}
		}

		/// <summary>
		/// System.String k_UxmlPath
		/// </summary>
		protected static RSystem.RString r_Fk_UxmlPath;
		public static RSystem.RString RFk_UxmlPath
		{
			get
			{
				if(r_Fk_UxmlPath == null)
				{
					r_Fk_UxmlPath = new(typeof(UnityEditor.Overlays.Overlay), "k_UxmlPath");
					r_Fk_UxmlPath.SetBelong(null);
				}
				return r_Fk_UxmlPath;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RSystem.RString r_FussClassName;
		public static RSystem.RString RFussClassName
		{
			get
			{
				if(r_FussClassName == null)
				{
					r_FussClassName = new(typeof(UnityEditor.Overlays.Overlay), "ussClassName");
					r_FussClassName.SetBelong(null);
				}
				return r_FussClassName;
			}
		}

		/// <summary>
		/// System.String k_Highlight
		/// </summary>
		protected static RSystem.RString r_Fk_Highlight;
		public static RSystem.RString RFk_Highlight
		{
			get
			{
				if(r_Fk_Highlight == null)
				{
					r_Fk_Highlight = new(typeof(UnityEditor.Overlays.Overlay), "k_Highlight");
					r_Fk_Highlight.SetBelong(null);
				}
				return r_Fk_Highlight;
			}
		}

		/// <summary>
		/// System.String k_Floating
		/// </summary>
		protected static RSystem.RString r_Fk_Floating;
		public static RSystem.RString RFk_Floating
		{
			get
			{
				if(r_Fk_Floating == null)
				{
					r_Fk_Floating = new(typeof(UnityEditor.Overlays.Overlay), "k_Floating");
					r_Fk_Floating.SetBelong(null);
				}
				return r_Fk_Floating;
			}
		}

		/// <summary>
		/// System.String headerTitle
		/// </summary>
		protected static RSystem.RString r_FheaderTitle;
		public static RSystem.RString RFheaderTitle
		{
			get
			{
				if(r_FheaderTitle == null)
				{
					r_FheaderTitle = new(typeof(UnityEditor.Overlays.Overlay), "headerTitle");
					r_FheaderTitle.SetBelong(null);
				}
				return r_FheaderTitle;
			}
		}

		/// <summary>
		/// System.String k_Collapsed
		/// </summary>
		protected static RSystem.RString r_Fk_Collapsed;
		public static RSystem.RString RFk_Collapsed
		{
			get
			{
				if(r_Fk_Collapsed == null)
				{
					r_Fk_Collapsed = new(typeof(UnityEditor.Overlays.Overlay), "k_Collapsed");
					r_Fk_Collapsed.SetBelong(null);
				}
				return r_Fk_Collapsed;
			}
		}

		/// <summary>
		/// System.String k_Header
		/// </summary>
		protected static RSystem.RString r_Fk_Header;
		public static RSystem.RString RFk_Header
		{
			get
			{
				if(r_Fk_Header == null)
				{
					r_Fk_Header = new(typeof(UnityEditor.Overlays.Overlay), "k_Header");
					r_Fk_Header.SetBelong(null);
				}
				return r_Fk_Header;
			}
		}

		/// <summary>
		/// System.String k_Expanded
		/// </summary>
		protected static RSystem.RString r_Fk_Expanded;
		public static RSystem.RString RFk_Expanded
		{
			get
			{
				if(r_Fk_Expanded == null)
				{
					r_Fk_Expanded = new(typeof(UnityEditor.Overlays.Overlay), "k_Expanded");
					r_Fk_Expanded.SetBelong(null);
				}
				return r_Fk_Expanded;
			}
		}

		/// <summary>
		/// System.String k_CollapsedContent
		/// </summary>
		protected static RSystem.RString r_Fk_CollapsedContent;
		public static RSystem.RString RFk_CollapsedContent
		{
			get
			{
				if(r_Fk_CollapsedContent == null)
				{
					r_Fk_CollapsedContent = new(typeof(UnityEditor.Overlays.Overlay), "k_CollapsedContent");
					r_Fk_CollapsedContent.SetBelong(null);
				}
				return r_Fk_CollapsedContent;
			}
		}

		/// <summary>
		/// System.String k_CollapsedIconButton
		/// </summary>
		protected static RSystem.RString r_Fk_CollapsedIconButton;
		public static RSystem.RString RFk_CollapsedIconButton
		{
			get
			{
				if(r_Fk_CollapsedIconButton == null)
				{
					r_Fk_CollapsedIconButton = new(typeof(UnityEditor.Overlays.Overlay), "k_CollapsedIconButton");
					r_Fk_CollapsedIconButton.SetBelong(null);
				}
				return r_Fk_CollapsedIconButton;
			}
		}

		/// <summary>
		/// System.String k_ToolbarHorizontalLayout
		/// </summary>
		protected static RSystem.RString r_Fk_ToolbarHorizontalLayout;
		public static RSystem.RString RFk_ToolbarHorizontalLayout
		{
			get
			{
				if(r_Fk_ToolbarHorizontalLayout == null)
				{
					r_Fk_ToolbarHorizontalLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_ToolbarHorizontalLayout");
					r_Fk_ToolbarHorizontalLayout.SetBelong(null);
				}
				return r_Fk_ToolbarHorizontalLayout;
			}
		}

		/// <summary>
		/// System.String k_ToolbarVerticalLayout
		/// </summary>
		protected static RSystem.RString r_Fk_ToolbarVerticalLayout;
		public static RSystem.RString RFk_ToolbarVerticalLayout
		{
			get
			{
				if(r_Fk_ToolbarVerticalLayout == null)
				{
					r_Fk_ToolbarVerticalLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_ToolbarVerticalLayout");
					r_Fk_ToolbarVerticalLayout.SetBelong(null);
				}
				return r_Fk_ToolbarVerticalLayout;
			}
		}

		/// <summary>
		/// System.String k_PanelLayout
		/// </summary>
		protected static RSystem.RString r_Fk_PanelLayout;
		public static RSystem.RString RFk_PanelLayout
		{
			get
			{
				if(r_Fk_PanelLayout == null)
				{
					r_Fk_PanelLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_PanelLayout");
					r_Fk_PanelLayout.SetBelong(null);
				}
				return r_Fk_PanelLayout;
			}
		}

		/// <summary>
		/// System.String m_Id
		/// </summary>
		protected RSystem.RString r_Fm_Id;
		public virtual RSystem.RString RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
					r_Fm_Id.SetBelong(this.instance);
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// System.String m_RootVisualElementName
		/// </summary>
		protected RSystem.RString r_Fm_RootVisualElementName;
		public virtual RSystem.RString RFm_RootVisualElementName
		{
			get
			{
				if(r_Fm_RootVisualElementName == null)
				{
					r_Fm_RootVisualElementName = new(this, "m_RootVisualElementName");
					r_Fm_RootVisualElementName.SetBelong(this.instance);
				}
				return r_Fm_RootVisualElementName;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected RSystem.RString r_Fm_DisplayName;
		public virtual RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
					r_Fm_DisplayName.SetBelong(this.instance);
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_Layout
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_Fm_Layout;
		public virtual RUnityEditor.ROverlays.RLayout RFm_Layout
		{
			get
			{
				if(r_Fm_Layout == null)
				{
					r_Fm_Layout = new(this, "m_Layout");
					r_Fm_Layout.SetBelong(this.instance);
				}
				return r_Fm_Layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_ActiveLayout
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_Fm_ActiveLayout;
		public virtual RUnityEditor.ROverlays.RLayout RFm_ActiveLayout
		{
			get
			{
				if(r_Fm_ActiveLayout == null)
				{
					r_Fm_ActiveLayout = new(this, "m_ActiveLayout");
					r_Fm_ActiveLayout.SetBelong(this.instance);
				}
				return r_Fm_ActiveLayout;
			}
		}

		/// <summary>
		/// System.Boolean m_Collapsed
		/// </summary>
		protected RSystem.RBoolean r_Fm_Collapsed;
		public virtual RSystem.RBoolean RFm_Collapsed
		{
			get
			{
				if(r_Fm_Collapsed == null)
				{
					r_Fm_Collapsed = new(this, "m_Collapsed");
					r_Fm_Collapsed.SetBelong(this.instance);
				}
				return r_Fm_Collapsed;
			}
		}

		/// <summary>
		/// System.Boolean <dontSaveInLayout>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__dontSaveInLayout__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__dontSaveInLayout__1__k__BackingField
		{
			get
			{
				if(r_F__0__dontSaveInLayout__1__k__BackingField == null)
				{
					r_F__0__dontSaveInLayout__1__k__BackingField = new(this, "<dontSaveInLayout>k__BackingField");
					r_F__0__dontSaveInLayout__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__dontSaveInLayout__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasMenuEntry
		/// </summary>
		protected RSystem.RBoolean r_Fm_HasMenuEntry;
		public virtual RSystem.RBoolean RFm_HasMenuEntry
		{
			get
			{
				if(r_Fm_HasMenuEntry == null)
				{
					r_Fm_HasMenuEntry = new(this, "m_HasMenuEntry");
					r_Fm_HasMenuEntry.SetBelong(this.instance);
				}
				return r_Fm_HasMenuEntry;
			}
		}

		/// <summary>
		/// System.Boolean m_Floating
		/// </summary>
		protected RSystem.RBoolean r_Fm_Floating;
		public virtual RSystem.RBoolean RFm_Floating
		{
			get
			{
				if(r_Fm_Floating == null)
				{
					r_Fm_Floating = new(this, "m_Floating");
					r_Fm_Floating.SetBelong(this.instance);
				}
				return r_Fm_Floating;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_FloatingSnapOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_FloatingSnapOffset;
		public virtual RUnityEngine.RVector2 RFm_FloatingSnapOffset
		{
			get
			{
				if(r_Fm_FloatingSnapOffset == null)
				{
					r_Fm_FloatingSnapOffset = new(this, "m_FloatingSnapOffset");
					r_Fm_FloatingSnapOffset.SetBelong(this.instance);
				}
				return r_Fm_FloatingSnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_SnapOffsetDelta
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_SnapOffsetDelta;
		public virtual RUnityEngine.RVector2 RFm_SnapOffsetDelta
		{
			get
			{
				if(r_Fm_SnapOffsetDelta == null)
				{
					r_Fm_SnapOffsetDelta = new(this, "m_SnapOffsetDelta");
					r_Fm_SnapOffsetDelta.SetBelong(this.instance);
				}
				return r_Fm_SnapOffsetDelta;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_MinSize;
		public virtual RUnityEngine.RVector2 RFm_MinSize
		{
			get
			{
				if(r_Fm_MinSize == null)
				{
					r_Fm_MinSize = new(this, "m_MinSize");
					r_Fm_MinSize.SetBelong(this.instance);
				}
				return r_Fm_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_MaxSize;
		public virtual RUnityEngine.RVector2 RFm_MaxSize
		{
			get
			{
				if(r_Fm_MaxSize == null)
				{
					r_Fm_MaxSize = new(this, "m_MaxSize");
					r_Fm_MaxSize.SetBelong(this.instance);
				}
				return r_Fm_MaxSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_Size
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_Size;
		public virtual RUnityEngine.RVector2 RFm_Size
		{
			get
			{
				if(r_Fm_Size == null)
				{
					r_Fm_Size = new(this, "m_Size");
					r_Fm_Size.SetBelong(this.instance);
				}
				return r_Fm_Size;
			}
		}

		/// <summary>
		/// System.Boolean m_SizeOverridden
		/// </summary>
		protected RSystem.RBoolean r_Fm_SizeOverridden;
		public virtual RSystem.RBoolean RFm_SizeOverridden
		{
			get
			{
				if(r_Fm_SizeOverridden == null)
				{
					r_Fm_SizeOverridden = new(this, "m_SizeOverridden");
					r_Fm_SizeOverridden.SetBelong(this.instance);
				}
				return r_Fm_SizeOverridden;
			}
		}

		/// <summary>
		/// System.Boolean m_LockAnchor
		/// </summary>
		protected RSystem.RBoolean r_Fm_LockAnchor;
		public virtual RSystem.RBoolean RFm_LockAnchor
		{
			get
			{
				if(r_Fm_LockAnchor == null)
				{
					r_Fm_LockAnchor = new(this, "m_LockAnchor");
					r_Fm_LockAnchor.SetBelong(this.instance);
				}
				return r_Fm_LockAnchor;
			}
		}

		/// <summary>
		/// System.Boolean m_ContentsChanged
		/// </summary>
		protected RSystem.RBoolean r_Fm_ContentsChanged;
		public virtual RSystem.RBoolean RFm_ContentsChanged
		{
			get
			{
				if(r_Fm_ContentsChanged == null)
				{
					r_Fm_ContentsChanged = new(this, "m_ContentsChanged");
					r_Fm_ContentsChanged.SetBelong(this.instance);
				}
				return r_Fm_ContentsChanged;
			}
		}

		/// <summary>
		/// System.Boolean m_DisableContentModification
		/// </summary>
		protected RSystem.RBoolean r_Fm_DisableContentModification;
		public virtual RSystem.RBoolean RFm_DisableContentModification
		{
			get
			{
				if(r_Fm_DisableContentModification == null)
				{
					r_Fm_DisableContentModification = new(this, "m_DisableContentModification");
					r_Fm_DisableContentModification.SetBelong(this.instance);
				}
				return r_Fm_DisableContentModification;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas <canvas>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r_F__0__canvas__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas RF__0__canvas__1__k__BackingField
		{
			get
			{
				if(r_F__0__canvas__1__k__BackingField == null)
				{
					r_F__0__canvas__1__k__BackingField = new(this, "<canvas>k__BackingField");
					r_F__0__canvas__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__canvas__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer m_Container
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_Fm_Container;
		public virtual RUnityEditor.ROverlays.ROverlayContainer RFm_Container
		{
			get
			{
				if(r_Fm_Container == null)
				{
					r_Fm_Container = new(this, "m_Container");
					r_Fm_Container.SetBelong(this.instance);
				}
				return r_Fm_Container;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CurrentContent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_CurrentContent;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_CurrentContent
		{
			get
			{
				if(r_Fm_CurrentContent == null)
				{
					r_Fm_CurrentContent = new(this, "m_CurrentContent");
					r_Fm_CurrentContent.SetBelong(this.instance);
				}
				return r_Fm_CurrentContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CollapsedContent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_CollapsedContent;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_CollapsedContent
		{
			get
			{
				if(r_Fm_CollapsedContent == null)
				{
					r_Fm_CollapsedContent = new(this, "m_CollapsedContent");
					r_Fm_CollapsedContent.SetBelong(this.instance);
				}
				return r_Fm_CollapsedContent;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayPopup m_ModalPopup
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayPopup r_Fm_ModalPopup;
		public virtual RUnityEditor.ROverlays.ROverlayPopup RFm_ModalPopup
		{
			get
			{
				if(r_Fm_ModalPopup == null)
				{
					r_Fm_ModalPopup = new(this, "m_ModalPopup");
					r_Fm_ModalPopup.SetBelong(this.instance);
				}
				return r_Fm_ModalPopup;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_RootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_RootVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_RootVisualElement
		{
			get
			{
				if(r_Fm_RootVisualElement == null)
				{
					r_Fm_RootVisualElement = new(this, "m_RootVisualElement");
					r_Fm_RootVisualElement.SetBelong(this.instance);
				}
				return r_Fm_RootVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ResizeTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_ResizeTarget;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_ResizeTarget
		{
			get
			{
				if(r_Fm_ResizeTarget == null)
				{
					r_Fm_ResizeTarget = new(this, "m_ResizeTarget");
					r_Fm_ResizeTarget.SetBelong(this.instance);
				}
				return r_Fm_ResizeTarget;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone m_BeforeDropZone
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayDropZone r_Fm_BeforeDropZone;
		public virtual RUnityEditor.ROverlays.ROverlayDropZone RFm_BeforeDropZone
		{
			get
			{
				if(r_Fm_BeforeDropZone == null)
				{
					r_Fm_BeforeDropZone = new(this, "m_BeforeDropZone");
					r_Fm_BeforeDropZone.SetBelong(this.instance);
				}
				return r_Fm_BeforeDropZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone m_AfterDropZone
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayDropZone r_Fm_AfterDropZone;
		public virtual RUnityEditor.ROverlays.ROverlayDropZone RFm_AfterDropZone
		{
			get
			{
				if(r_Fm_AfterDropZone == null)
				{
					r_Fm_AfterDropZone = new(this, "m_AfterDropZone");
					r_Fm_AfterDropZone.SetBelong(this.instance);
				}
				return r_Fm_AfterDropZone;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.Layout] layoutChanged
		/// </summary>
		protected RSystem.RAction<RUnityEditor.ROverlays.RLayout> r_FlayoutChanged;
		public virtual RSystem.RAction<RUnityEditor.ROverlays.RLayout> RFlayoutChanged
		{
			get
			{
				if(r_FlayoutChanged == null)
				{
					r_FlayoutChanged = new(this, "layoutChanged");
					r_FlayoutChanged.SetBelong(this.instance);
				}
				return r_FlayoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] collapsedChanged
		/// </summary>
		protected RSystem.RAction<RSystem.RBoolean> r_FcollapsedChanged;
		public virtual RSystem.RAction<RSystem.RBoolean> RFcollapsedChanged
		{
			get
			{
				if(r_FcollapsedChanged == null)
				{
					r_FcollapsedChanged = new(this, "collapsedChanged");
					r_FcollapsedChanged.SetBelong(this.instance);
				}
				return r_FcollapsedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] displayedChanged
		/// </summary>
		protected RSystem.RAction<RSystem.RBoolean> r_FdisplayedChanged;
		public virtual RSystem.RAction<RSystem.RBoolean> RFdisplayedChanged
		{
			get
			{
				if(r_FdisplayedChanged == null)
				{
					r_FdisplayedChanged = new(this, "displayedChanged");
					r_FdisplayedChanged.SetBelong(this.instance);
				}
				return r_FdisplayedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.OverlayContainer] containerChanged
		/// </summary>
		protected RSystem.RAction<RUnityEditor.ROverlays.ROverlayContainer> r_FcontainerChanged;
		public virtual RSystem.RAction<RUnityEditor.ROverlays.ROverlayContainer> RFcontainerChanged
		{
			get
			{
				if(r_FcontainerChanged == null)
				{
					r_FcontainerChanged = new(this, "containerChanged");
					r_FcontainerChanged.SetBelong(this.instance);
				}
				return r_FcontainerChanged;
			}
		}

		/// <summary>
		/// System.Action minSizeChanged
		/// </summary>
		protected RSystem.RAction r_FminSizeChanged;
		public virtual RSystem.RAction RFminSizeChanged
		{
			get
			{
				if(r_FminSizeChanged == null)
				{
					r_FminSizeChanged = new(this, "minSizeChanged");
					r_FminSizeChanged.SetBelong(this.instance);
				}
				return r_FminSizeChanged;
			}
		}

		/// <summary>
		/// System.Action maxSizeChanged
		/// </summary>
		protected RSystem.RAction r_FmaxSizeChanged;
		public virtual RSystem.RAction RFmaxSizeChanged
		{
			get
			{
				if(r_FmaxSizeChanged == null)
				{
					r_FmaxSizeChanged = new(this, "maxSizeChanged");
					r_FmaxSizeChanged.SetBelong(this.instance);
				}
				return r_FmaxSizeChanged;
			}
		}

		/// <summary>
		/// System.Action sizeOverridenChanged
		/// </summary>
		protected RSystem.RAction r_FsizeOverridenChanged;
		public virtual RSystem.RAction RFsizeOverridenChanged
		{
			get
			{
				if(r_FsizeOverridenChanged == null)
				{
					r_FsizeOverridenChanged = new(this, "sizeOverridenChanged");
					r_FsizeOverridenChanged.SetBelong(this.instance);
				}
				return r_FsizeOverridenChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] floatingChanged
		/// </summary>
		protected RSystem.RAction<RSystem.RBoolean> r_FfloatingChanged;
		public virtual RSystem.RAction<RSystem.RBoolean> RFfloatingChanged
		{
			get
			{
				if(r_FfloatingChanged == null)
				{
					r_FfloatingChanged = new(this, "floatingChanged");
					r_FfloatingChanged.SetBelong(this.instance);
				}
				return r_FfloatingChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Vector3] floatingPositionChanged
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RVector3> r_FfloatingPositionChanged;
		public virtual RSystem.RAction<RUnityEngine.RVector3> RFfloatingPositionChanged
		{
			get
			{
				if(r_FfloatingPositionChanged == null)
				{
					r_FfloatingPositionChanged = new(this, "floatingPositionChanged");
					r_FfloatingPositionChanged.SetBelong(this.instance);
				}
				return r_FfloatingPositionChanged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset s_TreeAsset
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualTreeAsset r_Fs_TreeAsset;
		public static RUnityEngine.RUIElements.RVisualTreeAsset RFs_TreeAsset
		{
			get
			{
				if(r_Fs_TreeAsset == null)
				{
					r_Fs_TreeAsset = new(typeof(UnityEditor.Overlays.Overlay), "s_TreeAsset");
					r_Fs_TreeAsset.SetBelong(null);
				}
				return r_Fs_TreeAsset;
			}
		}

		/// <summary>
		/// System.Action displayNameChanged
		/// </summary>
		protected RSystem.RAction r_FdisplayNameChanged;
		public virtual RSystem.RAction RFdisplayNameChanged
		{
			get
			{
				if(r_FdisplayNameChanged == null)
				{
					r_FdisplayNameChanged = new(this, "displayNameChanged");
					r_FdisplayNameChanged.SetBelong(this.instance);
				}
				return r_FdisplayNameChanged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ContentRoot
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_ContentRoot;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_ContentRoot
		{
			get
			{
				if(r_Fm_ContentRoot == null)
				{
					r_Fm_ContentRoot = new(this, "m_ContentRoot");
					r_Fm_ContentRoot.SetBelong(this.instance);
				}
				return r_Fm_ContentRoot;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_CollapsedIcon
		/// </summary>
		protected RUnityEngine.RTexture2D r_Fm_CollapsedIcon;
		public virtual RUnityEngine.RTexture2D RFm_CollapsedIcon
		{
			get
			{
				if(r_Fm_CollapsedIcon == null)
				{
					r_Fm_CollapsedIcon = new(this, "m_CollapsedIcon");
					r_Fm_CollapsedIcon.SetBelong(this.instance);
				}
				return r_Fm_CollapsedIcon;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner <floatingSnapCorner>k__BackingField
		/// </summary>
		protected RUnityEditor.ROverlays.RSnapCorner r_F__0__floatingSnapCorner__1__k__BackingField;
		public virtual RUnityEditor.ROverlays.RSnapCorner RF__0__floatingSnapCorner__1__k__BackingField
		{
			get
			{
				if(r_F__0__floatingSnapCorner__1__k__BackingField == null)
				{
					r_F__0__floatingSnapCorner__1__k__BackingField = new(this, "<floatingSnapCorner>k__BackingField");
					r_F__0__floatingSnapCorner__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__floatingSnapCorner__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean dontSaveInLayout
		/// </summary>
		protected RSystem.RBoolean r_PdontSaveInLayout;
		public virtual RSystem.RBoolean RPdontSaveInLayout
		{
			get
			{
				if(r_PdontSaveInLayout == null)
				{
					r_PdontSaveInLayout = new(this, "dontSaveInLayout", -1);
					r_PdontSaveInLayout.SetBelong(this.instance);
				}
				return r_PdontSaveInLayout;
			}
		}

		/// <summary>
		/// UnityEditor.EditorWindow containerWindow
		/// </summary>
		protected RUnityEditor.REditorWindow r_PcontainerWindow;
		public virtual RUnityEditor.REditorWindow RPcontainerWindow
		{
			get
			{
				if(r_PcontainerWindow == null)
				{
					r_PcontainerWindow = new(this, "containerWindow", -1);
					r_PcontainerWindow.SetBelong(this.instance);
				}
				return r_PcontainerWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas canvas
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayCanvas r_Pcanvas;
		public virtual RUnityEditor.ROverlays.ROverlayCanvas RPcanvas
		{
			get
			{
				if(r_Pcanvas == null)
				{
					r_Pcanvas = new(this, "canvas", -1);
					r_Pcanvas.SetBelong(this.instance);
				}
				return r_Pcanvas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement resizeTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PresizeTarget;
		public virtual RUnityEngine.RUIElements.RVisualElement RPresizeTarget
		{
			get
			{
				if(r_PresizeTarget == null)
				{
					r_PresizeTarget = new(this, "resizeTarget", -1);
					r_PresizeTarget.SetBelong(this.instance);
				}
				return r_PresizeTarget;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected RSystem.RString r_Pid;
		public virtual RSystem.RString RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.instance);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Boolean hasMenuEntry
		/// </summary>
		protected RSystem.RBoolean r_PhasMenuEntry;
		public virtual RSystem.RBoolean RPhasMenuEntry
		{
			get
			{
				if(r_PhasMenuEntry == null)
				{
					r_PhasMenuEntry = new(this, "hasMenuEntry", -1);
					r_PhasMenuEntry.SetBelong(this.instance);
				}
				return r_PhasMenuEntry;
			}
		}

		/// <summary>
		/// UnityEngine.Rect collapsedButtonRect
		/// </summary>
		protected RUnityEngine.RRect r_PcollapsedButtonRect;
		public virtual RUnityEngine.RRect RPcollapsedButtonRect
		{
			get
			{
				if(r_PcollapsedButtonRect == null)
				{
					r_PcollapsedButtonRect = new(this, "collapsedButtonRect", -1);
					r_PcollapsedButtonRect.SetBelong(this.instance);
				}
				return r_PcollapsedButtonRect;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D collapsedIcon
		/// </summary>
		protected RUnityEngine.RTexture2D r_PcollapsedIcon;
		public virtual RUnityEngine.RTexture2D RPcollapsedIcon
		{
			get
			{
				if(r_PcollapsedIcon == null)
				{
					r_PcollapsedIcon = new(this, "collapsedIcon", -1);
					r_PcollapsedIcon.SetBelong(this.instance);
				}
				return r_PcollapsedIcon;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement collapsedContent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PcollapsedContent;
		public virtual RUnityEngine.RUIElements.RVisualElement RPcollapsedContent
		{
			get
			{
				if(r_PcollapsedContent == null)
				{
					r_PcollapsedContent = new(this, "collapsedContent", -1);
					r_PcollapsedContent.SetBelong(this.instance);
				}
				return r_PcollapsedContent;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout layout
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_Playout;
		public virtual RUnityEditor.ROverlays.RLayout RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
					r_Playout.SetBelong(this.instance);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout activeLayout
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_PactiveLayout;
		public virtual RUnityEditor.ROverlays.RLayout RPactiveLayout
		{
			get
			{
				if(r_PactiveLayout == null)
				{
					r_PactiveLayout = new(this, "activeLayout", -1);
					r_PactiveLayout.SetBelong(this.instance);
				}
				return r_PactiveLayout;
			}
		}

		/// <summary>
		/// Boolean collapsed
		/// </summary>
		protected RSystem.RBoolean r_Pcollapsed;
		public virtual RSystem.RBoolean RPcollapsed
		{
			get
			{
				if(r_Pcollapsed == null)
				{
					r_Pcollapsed = new(this, "collapsed", -1);
					r_Pcollapsed.SetBelong(this.instance);
				}
				return r_Pcollapsed;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected RSystem.RString r_PdisplayName;
		public virtual RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// Boolean userControlledVisibility
		/// </summary>
		protected RSystem.RBoolean r_PuserControlledVisibility;
		public virtual RSystem.RBoolean RPuserControlledVisibility
		{
			get
			{
				if(r_PuserControlledVisibility == null)
				{
					r_PuserControlledVisibility = new(this, "userControlledVisibility", -1);
					r_PuserControlledVisibility.SetBelong(this.instance);
				}
				return r_PuserControlledVisibility;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer container
		/// </summary>
		protected RUnityEditor.ROverlays.ROverlayContainer r_Pcontainer;
		public virtual RUnityEditor.ROverlays.ROverlayContainer RPcontainer
		{
			get
			{
				if(r_Pcontainer == null)
				{
					r_Pcontainer = new(this, "container", -1);
					r_Pcontainer.SetBelong(this.instance);
				}
				return r_Pcontainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone dockZone
		/// </summary>
		protected RUnityEditor.ROverlays.RDockZone r_PdockZone;
		public virtual RUnityEditor.ROverlays.RDockZone RPdockZone
		{
			get
			{
				if(r_PdockZone == null)
				{
					r_PdockZone = new(this, "dockZone", -1);
					r_PdockZone.SetBelong(this.instance);
				}
				return r_PdockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition dockPosition
		/// </summary>
		protected RUnityEditor.ROverlays.RDockPosition r_PdockPosition;
		public virtual RUnityEditor.ROverlays.RDockPosition RPdockPosition
		{
			get
			{
				if(r_PdockPosition == null)
				{
					r_PdockPosition = new(this, "dockPosition", -1);
					r_PdockPosition.SetBelong(this.instance);
				}
				return r_PdockPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset treeAsset
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualTreeAsset r_PtreeAsset;
		public static RUnityEngine.RUIElements.RVisualTreeAsset RPtreeAsset
		{
			get
			{
				if(r_PtreeAsset == null)
				{
					r_PtreeAsset = new(typeof(UnityEditor.Overlays.Overlay), "treeAsset", -1);
					r_PtreeAsset.SetBelong(null);
				}
				return r_PtreeAsset;
			}
		}

		/// <summary>
		/// Boolean displayed
		/// </summary>
		protected RSystem.RBoolean r_Pdisplayed;
		public virtual RSystem.RBoolean RPdisplayed
		{
			get
			{
				if(r_Pdisplayed == null)
				{
					r_Pdisplayed = new(this, "displayed", -1);
					r_Pdisplayed.SetBelong(this.instance);
				}
				return r_Pdisplayed;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout supportedLayouts
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_PsupportedLayouts;
		public virtual RUnityEditor.ROverlays.RLayout RPsupportedLayouts
		{
			get
			{
				if(r_PsupportedLayouts == null)
				{
					r_PsupportedLayouts = new(this, "supportedLayouts", -1);
					r_PsupportedLayouts.SetBelong(this.instance);
				}
				return r_PsupportedLayouts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement rootVisualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_ProotVisualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RProotVisualElement
		{
			get
			{
				if(r_ProotVisualElement == null)
				{
					r_ProotVisualElement = new(this, "rootVisualElement", -1);
					r_ProotVisualElement.SetBelong(this.instance);
				}
				return r_ProotVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentRoot
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PcontentRoot;
		public virtual RUnityEngine.RUIElements.RVisualElement RPcontentRoot
		{
			get
			{
				if(r_PcontentRoot == null)
				{
					r_PcontentRoot = new(this, "contentRoot", -1);
					r_PcontentRoot.SetBelong(this.instance);
				}
				return r_PcontentRoot;
			}
		}

		/// <summary>
		/// Boolean isInToolbar
		/// </summary>
		protected RSystem.RBoolean r_PisInToolbar;
		public virtual RSystem.RBoolean RPisInToolbar
		{
			get
			{
				if(r_PisInToolbar == null)
				{
					r_PisInToolbar = new(this, "isInToolbar", -1);
					r_PisInToolbar.SetBelong(this.instance);
				}
				return r_PisInToolbar;
			}
		}

		/// <summary>
		/// Boolean sizeOverridden
		/// </summary>
		protected RSystem.RBoolean r_PsizeOverridden;
		public virtual RSystem.RBoolean RPsizeOverridden
		{
			get
			{
				if(r_PsizeOverridden == null)
				{
					r_PsizeOverridden = new(this, "sizeOverridden", -1);
					r_PsizeOverridden.SetBelong(this.instance);
				}
				return r_PsizeOverridden;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 sizeToSave
		/// </summary>
		protected RUnityEngine.RVector2 r_PsizeToSave;
		public virtual RUnityEngine.RVector2 RPsizeToSave
		{
			get
			{
				if(r_PsizeToSave == null)
				{
					r_PsizeToSave = new(this, "sizeToSave", -1);
					r_PsizeToSave.SetBelong(this.instance);
				}
				return r_PsizeToSave;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected RUnityEngine.RVector2 r_Psize;
		public virtual RUnityEngine.RVector2 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
					r_Psize.SetBelong(this.instance);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected RUnityEngine.RVector2 r_PminSize;
		public virtual RUnityEngine.RVector2 RPminSize
		{
			get
			{
				if(r_PminSize == null)
				{
					r_PminSize = new(this, "minSize", -1);
					r_PminSize.SetBelong(this.instance);
				}
				return r_PminSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_PmaxSize;
		public virtual RUnityEngine.RVector2 RPmaxSize
		{
			get
			{
				if(r_PmaxSize == null)
				{
					r_PmaxSize = new(this, "maxSize", -1);
					r_PmaxSize.SetBelong(this.instance);
				}
				return r_PmaxSize;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner floatingSnapCorner
		/// </summary>
		protected RUnityEditor.ROverlays.RSnapCorner r_PfloatingSnapCorner;
		public virtual RUnityEditor.ROverlays.RSnapCorner RPfloatingSnapCorner
		{
			get
			{
				if(r_PfloatingSnapCorner == null)
				{
					r_PfloatingSnapCorner = new(this, "floatingSnapCorner", -1);
					r_PfloatingSnapCorner.SetBelong(this.instance);
				}
				return r_PfloatingSnapCorner;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 floatingSnapOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_PfloatingSnapOffset;
		public virtual RUnityEngine.RVector2 RPfloatingSnapOffset
		{
			get
			{
				if(r_PfloatingSnapOffset == null)
				{
					r_PfloatingSnapOffset = new(this, "floatingSnapOffset", -1);
					r_PfloatingSnapOffset.SetBelong(this.instance);
				}
				return r_PfloatingSnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 floatingPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_PfloatingPosition;
		public virtual RUnityEngine.RVector2 RPfloatingPosition
		{
			get
			{
				if(r_PfloatingPosition == null)
				{
					r_PfloatingPosition = new(this, "floatingPosition", -1);
					r_PfloatingPosition.SetBelong(this.instance);
				}
				return r_PfloatingPosition;
			}
		}

		/// <summary>
		/// Boolean floating
		/// </summary>
		protected RSystem.RBoolean r_Pfloating;
		public virtual RSystem.RBoolean RPfloating
		{
			get
			{
				if(r_Pfloating == null)
				{
					r_Pfloating = new(this, "floating", -1);
					r_Pfloating.SetBelong(this.instance);
				}
				return r_Pfloating;
			}
		}

		/// <summary>
		/// System.String GetEventTypeErrorMessage(System.String)
		/// </summary>
		protected static RMethod r_MGetEventTypeErrorMessage_String;
		public static RMethod RMGetEventTypeErrorMessage_String
		{
			get
			{
				if(r_MGetEventTypeErrorMessage_String == null)
				{
					r_MGetEventTypeErrorMessage_String = new(typeof(UnityEditor.Overlays.Overlay), "GetEventTypeErrorMessage", 0, typeof(System.String));
					r_MGetEventTypeErrorMessage_String.SetBelong(null);
				}
				return r_MGetEventTypeErrorMessage_String;
			}
		}

		/// <summary>
		/// Void ResetSize()
		/// </summary>
		protected RMethod r_MResetSize;
		public virtual RMethod RMResetSize
		{
			get
			{
				if(r_MResetSize == null)
				{
					r_MResetSize = new(this, "ResetSize", 0);
					r_MResetSize.SetBelong(this.instance);
				}
				return r_MResetSize;
			}
		}

		/// <summary>
		/// Boolean CanCreateRequestedLayout(UnityEditor.Overlays.Layout)
		/// </summary>
		protected RMethod r_MCanCreateRequestedLayout_Layout;
		public virtual RMethod RMCanCreateRequestedLayout_Layout
		{
			get
			{
				if(r_MCanCreateRequestedLayout_Layout == null)
				{
					r_MCanCreateRequestedLayout_Layout = new(this, "CanCreateRequestedLayout", 0, typeof(UnityEditor.Overlays.Layout));
					r_MCanCreateRequestedLayout_Layout.SetBelong(this.instance);
				}
				return r_MCanCreateRequestedLayout_Layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout GetBestLayoutForState()
		/// </summary>
		protected RMethod r_MGetBestLayoutForState;
		public virtual RMethod RMGetBestLayoutForState
		{
			get
			{
				if(r_MGetBestLayoutForState == null)
				{
					r_MGetBestLayoutForState = new(this, "GetBestLayoutForState", 0);
					r_MGetBestLayoutForState.SetBelong(this.instance);
				}
				return r_MGetBestLayoutForState;
			}
		}

		/// <summary>
		/// Void RebuildContent()
		/// </summary>
		protected RMethod r_MRebuildContent;
		public virtual RMethod RMRebuildContent
		{
			get
			{
				if(r_MRebuildContent == null)
				{
					r_MRebuildContent = new(this, "RebuildContent", 0);
					r_MRebuildContent.SetBelong(this.instance);
				}
				return r_MRebuildContent;
			}
		}

		/// <summary>
		/// Boolean ShouldUseSizeValue()
		/// </summary>
		protected RMethod r_MShouldUseSizeValue;
		public virtual RMethod RMShouldUseSizeValue
		{
			get
			{
				if(r_MShouldUseSizeValue == null)
				{
					r_MShouldUseSizeValue = new(this, "ShouldUseSizeValue", 0);
					r_MShouldUseSizeValue.SetBelong(this.instance);
				}
				return r_MShouldUseSizeValue;
			}
		}

		/// <summary>
		/// Boolean IsSizeAuto(Single, Single)
		/// </summary>
		protected RMethod r_MIsSizeAuto_Single_Single;
		public virtual RMethod RMIsSizeAuto_Single_Single
		{
			get
			{
				if(r_MIsSizeAuto_Single_Single == null)
				{
					r_MIsSizeAuto_Single_Single = new(this, "IsSizeAuto", 0, typeof(System.Single), typeof(System.Single));
					r_MIsSizeAuto_Single_Single.SetBelong(this.instance);
				}
				return r_MIsSizeAuto_Single_Single;
			}
		}

		/// <summary>
		/// Void UpdateSize()
		/// </summary>
		protected RMethod r_MUpdateSize;
		public virtual RMethod RMUpdateSize
		{
			get
			{
				if(r_MUpdateSize == null)
				{
					r_MUpdateSize = new(this, "UpdateSize", 0);
					r_MUpdateSize.SetBelong(this.instance);
				}
				return r_MUpdateSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreateContent(UnityEditor.Overlays.Layout)
		/// </summary>
		protected RMethod r_MCreateContent_Layout;
		public virtual RMethod RMCreateContent_Layout
		{
			get
			{
				if(r_MCreateContent_Layout == null)
				{
					r_MCreateContent_Layout = new(this, "CreateContent", 0, typeof(UnityEditor.Overlays.Layout));
					r_MCreateContent_Layout.SetBelong(this.instance);
				}
				return r_MCreateContent_Layout;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePanelContent()
		/// </summary>
		protected RMethod r_MCreatePanelContent;
		public virtual RMethod RMCreatePanelContent
		{
			get
			{
				if(r_MCreatePanelContent == null)
				{
					r_MCreatePanelContent = new(this, "CreatePanelContent", 0);
					r_MCreatePanelContent.SetBelong(this.instance);
				}
				return r_MCreatePanelContent;
			}
		}

		/// <summary>
		/// Void OnCreated()
		/// </summary>
		protected RMethod r_MOnCreated;
		public virtual RMethod RMOnCreated
		{
			get
			{
				if(r_MOnCreated == null)
				{
					r_MOnCreated = new(this, "OnCreated", 0);
					r_MOnCreated.SetBelong(this.instance);
				}
				return r_MOnCreated;
			}
		}

		/// <summary>
		/// Void OnWillBeDestroyed()
		/// </summary>
		protected RMethod r_MOnWillBeDestroyed;
		public virtual RMethod RMOnWillBeDestroyed
		{
			get
			{
				if(r_MOnWillBeDestroyed == null)
				{
					r_MOnWillBeDestroyed = new(this, "OnWillBeDestroyed", 0);
					r_MOnWillBeDestroyed.SetBelong(this.instance);
				}
				return r_MOnWillBeDestroyed;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_MClose;
		public virtual RMethod RMClose
		{
			get
			{
				if(r_MClose == null)
				{
					r_MClose = new(this, "Close", 0);
					r_MClose.SetBelong(this.instance);
				}
				return r_MClose;
			}
		}

		/// <summary>
		/// Void ToggleCollapsedPopup()
		/// </summary>
		protected RMethod r_MToggleCollapsedPopup;
		public virtual RMethod RMToggleCollapsedPopup
		{
			get
			{
				if(r_MToggleCollapsedPopup == null)
				{
					r_MToggleCollapsedPopup = new(this, "ToggleCollapsedPopup", 0);
					r_MToggleCollapsedPopup.SetBelong(this.instance);
				}
				return r_MToggleCollapsedPopup;
			}
		}

		/// <summary>
		/// Void ClosePopup()
		/// </summary>
		protected RMethod r_MClosePopup;
		public virtual RMethod RMClosePopup
		{
			get
			{
				if(r_MClosePopup == null)
				{
					r_MClosePopup = new(this, "ClosePopup", 0);
					r_MClosePopup.SetBelong(this.instance);
				}
				return r_MClosePopup;
			}
		}

		/// <summary>
		/// Status GetMenuItemState(Boolean)
		/// </summary>
		protected static RMethod r_MGetMenuItemState_Boolean;
		public static RMethod RMGetMenuItemState_Boolean
		{
			get
			{
				if(r_MGetMenuItemState_Boolean == null)
				{
					r_MGetMenuItemState_Boolean = new(typeof(UnityEditor.Overlays.Overlay), "GetMenuItemState", 0, typeof(System.Boolean));
					r_MGetMenuItemState_Boolean.SetBelong(null);
				}
				return r_MGetMenuItemState_Boolean;
			}
		}

		/// <summary>
		/// Void BuildContextMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent)
		/// </summary>
		protected RMethod r_MBuildContextMenu_ContextualMenuPopulateEvent;
		public virtual RMethod RMBuildContextMenu_ContextualMenuPopulateEvent
		{
			get
			{
				if(r_MBuildContextMenu_ContextualMenuPopulateEvent == null)
				{
					r_MBuildContextMenu_ContextualMenuPopulateEvent = new(this, "BuildContextMenu", 0, typeof(UnityEngine.UIElements.ContextualMenuPopulateEvent));
					r_MBuildContextMenu_ContextualMenuPopulateEvent.SetBelong(this.instance);
				}
				return r_MBuildContextMenu_ContextualMenuPopulateEvent;
			}
		}

		/// <summary>
		/// Void SetHighlightEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetHighlightEnabled_Boolean;
		public virtual RMethod RMSetHighlightEnabled_Boolean
		{
			get
			{
				if(r_MSetHighlightEnabled_Boolean == null)
				{
					r_MSetHighlightEnabled_Boolean = new(this, "SetHighlightEnabled", 0, typeof(System.Boolean));
					r_MSetHighlightEnabled_Boolean.SetBelong(this.instance);
				}
				return r_MSetHighlightEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.Overlays.OverlayAttribute)
		/// </summary>
		protected RMethod r_MInitialize_OverlayAttribute;
		public virtual RMethod RMInitialize_OverlayAttribute
		{
			get
			{
				if(r_MInitialize_OverlayAttribute == null)
				{
					r_MInitialize_OverlayAttribute = new(this, "Initialize", 0, typeof(UnityEditor.Overlays.OverlayAttribute));
					r_MInitialize_OverlayAttribute.SetBelong(this.instance);
				}
				return r_MInitialize_OverlayAttribute;
			}
		}

		/// <summary>
		/// Void Initialize(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MInitialize_String_String_String;
		public virtual RMethod RMInitialize_String_String_String
		{
			get
			{
				if(r_MInitialize_String_String_String == null)
				{
					r_MInitialize_String_String_String = new(this, "Initialize", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_MInitialize_String_String_String.SetBelong(this.instance);
				}
				return r_MInitialize_String_String_String;
			}
		}

		/// <summary>
		/// Void ApplySaveData(UnityEditor.Overlays.SaveData)
		/// </summary>
		protected RMethod r_MApplySaveData_SaveData;
		public virtual RMethod RMApplySaveData_SaveData
		{
			get
			{
				if(r_MApplySaveData_SaveData == null)
				{
					r_MApplySaveData_SaveData = new(this, "ApplySaveData", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SaveData"));
					r_MApplySaveData_SaveData.SetBelong(this.instance);
				}
				return r_MApplySaveData_SaveData;
			}
		}

		/// <summary>
		/// Void OnFloatingChanged(Boolean)
		/// </summary>
		protected RMethod r_MOnFloatingChanged_Boolean;
		public virtual RMethod RMOnFloatingChanged_Boolean
		{
			get
			{
				if(r_MOnFloatingChanged_Boolean == null)
				{
					r_MOnFloatingChanged_Boolean = new(this, "OnFloatingChanged", 0, typeof(System.Boolean));
					r_MOnFloatingChanged_Boolean.SetBelong(this.instance);
				}
				return r_MOnFloatingChanged_Boolean;
			}
		}

		/// <summary>
		/// Boolean DockAt(UnityEditor.Overlays.OverlayContainer, UnityEditor.Overlays.OverlayContainerSection)
		/// </summary>
		protected RMethod r_MDockAt_OverlayContainer_OverlayContainerSection;
		public virtual RMethod RMDockAt_OverlayContainer_OverlayContainerSection
		{
			get
			{
				if(r_MDockAt_OverlayContainer_OverlayContainerSection == null)
				{
					r_MDockAt_OverlayContainer_OverlayContainerSection = new(this, "DockAt", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainerSection"));
					r_MDockAt_OverlayContainer_OverlayContainerSection.SetBelong(this.instance);
				}
				return r_MDockAt_OverlayContainer_OverlayContainerSection;
			}
		}

		/// <summary>
		/// Boolean DockAt(UnityEditor.Overlays.OverlayContainer, UnityEditor.Overlays.OverlayContainerSection, Int32)
		/// </summary>
		protected RMethod r_MDockAt_OverlayContainer_OverlayContainerSection_Int32;
		public virtual RMethod RMDockAt_OverlayContainer_OverlayContainerSection_Int32
		{
			get
			{
				if(r_MDockAt_OverlayContainer_OverlayContainerSection_Int32 == null)
				{
					r_MDockAt_OverlayContainer_OverlayContainerSection_Int32 = new(this, "DockAt", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainerSection"), typeof(System.Int32));
					r_MDockAt_OverlayContainer_OverlayContainerSection_Int32.SetBelong(this.instance);
				}
				return r_MDockAt_OverlayContainer_OverlayContainerSection_Int32;
			}
		}

		/// <summary>
		/// Boolean DockBefore(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MDockBefore_Overlay;
		public virtual RMethod RMDockBefore_Overlay
		{
			get
			{
				if(r_MDockBefore_Overlay == null)
				{
					r_MDockBefore_Overlay = new(this, "DockBefore", 0, typeof(UnityEditor.Overlays.Overlay));
					r_MDockBefore_Overlay.SetBelong(this.instance);
				}
				return r_MDockBefore_Overlay;
			}
		}

		/// <summary>
		/// Boolean DockAfter(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MDockAfter_Overlay;
		public virtual RMethod RMDockAfter_Overlay
		{
			get
			{
				if(r_MDockAfter_Overlay == null)
				{
					r_MDockAfter_Overlay = new(this, "DockAfter", 0, typeof(UnityEditor.Overlays.Overlay));
					r_MDockAfter_Overlay.SetBelong(this.instance);
				}
				return r_MDockAfter_Overlay;
			}
		}

		/// <summary>
		/// Void Undock()
		/// </summary>
		protected RMethod r_MUndock;
		public virtual RMethod RMUndock
		{
			get
			{
				if(r_MUndock == null)
				{
					r_MUndock = new(this, "Undock", 0);
					r_MUndock.SetBelong(this.instance);
				}
				return r_MUndock;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_MBringToFront;
		public virtual RMethod RMBringToFront
		{
			get
			{
				if(r_MBringToFront == null)
				{
					r_MBringToFront = new(this, "BringToFront", 0);
					r_MBringToFront.SetBelong(this.instance);
				}
				return r_MBringToFront;
			}
		}

		/// <summary>
		/// Void SetSnappingOffset(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetSnappingOffset_Vector2_Vector2;
		public virtual RMethod RMSetSnappingOffset_Vector2_Vector2
		{
			get
			{
				if(r_MSetSnappingOffset_Vector2_Vector2 == null)
				{
					r_MSetSnappingOffset_Vector2_Vector2 = new(this, "SetSnappingOffset", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MSetSnappingOffset_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_MSetSnappingOffset_Vector2_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 SnapToFloatingPosition(UnityEditor.Overlays.SnapCorner, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSnapToFloatingPosition_SnapCorner_Vector2;
		public virtual RMethod RMSnapToFloatingPosition_SnapCorner_Vector2
		{
			get
			{
				if(r_MSnapToFloatingPosition_SnapCorner_Vector2 == null)
				{
					r_MSnapToFloatingPosition_SnapCorner_Vector2 = new(this, "SnapToFloatingPosition", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.SnapCorner"), typeof(UnityEngine.Vector2));
					r_MSnapToFloatingPosition_SnapCorner_Vector2.SetBelong(this.instance);
				}
				return r_MSnapToFloatingPosition_SnapCorner_Vector2;
			}
		}

		/// <summary>
		/// Void FloatingToSnapPosition(UnityEngine.Vector2, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MFloatingToSnapPosition_Vector2_Out_Vector2;
		public virtual RMethod RMFloatingToSnapPosition_Vector2_Out_Vector2
		{
			get
			{
				if(r_MFloatingToSnapPosition_Vector2_Out_Vector2 == null)
				{
					r_MFloatingToSnapPosition_Vector2_Out_Vector2 = new(this, "FloatingToSnapPosition", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2).MakeByRefType());
					r_MFloatingToSnapPosition_Vector2_Out_Vector2.SetBelong(this.instance);
				}
				return r_MFloatingToSnapPosition_Vector2_Out_Vector2;
			}
		}

		/// <summary>
		/// Void FloatingToSnapPosition(UnityEngine.Vector2, UnityEditor.Overlays.SnapCorner ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2;
		public virtual RMethod RMFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2
		{
			get
			{
				if(r_MFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2 == null)
				{
					r_MFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2 = new(this, "FloatingToSnapPosition", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("UnityEditor.Overlays.SnapCorner").MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_MFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2.SetBelong(this.instance);
				}
				return r_MFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2;
			}
		}

		/// <summary>
		/// Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnGeometryChanged_GeometryChangedEvent;
		public virtual RMethod RMOnGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnGeometryChanged_GeometryChangedEvent == null)
				{
					r_MOnGeometryChanged_GeometryChangedEvent = new(this, "OnGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MOnGeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_MOnGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void UpdateSnapping(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MUpdateSnapping_Vector2;
		public virtual RMethod RMUpdateSnapping_Vector2
		{
			get
			{
				if(r_MUpdateSnapping_Vector2 == null)
				{
					r_MUpdateSnapping_Vector2 = new(this, "UpdateSnapping", 0, typeof(UnityEngine.Vector2));
					r_MUpdateSnapping_Vector2.SetBelong(this.instance);
				}
				return r_MUpdateSnapping_Vector2;
			}
		}

		/// <summary>
		/// Void UpdateAbsolutePosition()
		/// </summary>
		protected RMethod r_MUpdateAbsolutePosition;
		public virtual RMethod RMUpdateAbsolutePosition
		{
			get
			{
				if(r_MUpdateAbsolutePosition == null)
				{
					r_MUpdateAbsolutePosition = new(this, "UpdateAbsolutePosition", 0);
					r_MUpdateAbsolutePosition.SetBelong(this.instance);
				}
				return r_MUpdateAbsolutePosition;
			}
		}

		/// <summary>
		/// Void <ToggleCollapsedPopup>b__154_0(UnityEngine.UIElements.FocusOutEvent)
		/// </summary>
		protected RMethod r_M__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent;
		public virtual RMethod RM__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent
		{
			get
			{
				if(r_M__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent == null)
				{
					r_M__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent = new(this, "<ToggleCollapsedPopup>b__154_0", 0, typeof(UnityEngine.UIElements.FocusOutEvent));
					r_M__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent.SetBelong(this.instance);
				}
				return r_M__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_0(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_0_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_0_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_0_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_0_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_0", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_0_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_0_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_1(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_1_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_1_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_1_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_1_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_1", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_1_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_1_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_2(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_2_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_2_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_2_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_2_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_2", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_2_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_2_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_3(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_3_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_3_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_3_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_3_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_3", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_3_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_3_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_4(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_4_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_4_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_4_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_4_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_4", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_4_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_4_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_5(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_5_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_5_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_5_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_5_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_5", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_5_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_5_DropdownMenuAction;
			}
		}

		/// <summary>
		/// Void <BuildContextMenu>b__157_6(UnityEngine.UIElements.DropdownMenuAction)
		/// </summary>
		protected RMethod r_M__0__BuildContextMenu__1__b__157_6_DropdownMenuAction;
		public virtual RMethod RM__0__BuildContextMenu__1__b__157_6_DropdownMenuAction
		{
			get
			{
				if(r_M__0__BuildContextMenu__1__b__157_6_DropdownMenuAction == null)
				{
					r_M__0__BuildContextMenu__1__b__157_6_DropdownMenuAction = new(this, "<BuildContextMenu>b__157_6", 0, typeof(UnityEngine.UIElements.DropdownMenuAction));
					r_M__0__BuildContextMenu__1__b__157_6_DropdownMenuAction.SetBelong(this.instance);
				}
				return r_M__0__BuildContextMenu__1__b__157_6_DropdownMenuAction;
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
            var ___result = RMGetEventTypeErrorMessage_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ResetSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanCreateRequestedLayout(UnityEditor.Overlays.Layout @requested)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requested};
            var ___result = RMCanCreateRequestedLayout_Layout.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEditor.Overlays.Layout GetBestLayoutForState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBestLayoutForState.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Overlays.Layout)___result;
        }


        public virtual void RebuildContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuildContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldUseSizeValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldUseSizeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSizeAuto(System.Single @min, System.Single @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMIsSizeAuto_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreateContent(UnityEditor.Overlays.Layout @requestedLayout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedLayout};
            var ___result = RMCreateContent_Layout.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement CreatePanelContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreatePanelContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void OnCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnWillBeDestroyed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnWillBeDestroyed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleCollapsedPopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToggleCollapsedPopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClosePopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClosePopup.Invoke(___genericsType, ___parameters);

            
        }


        public static RUnityEngine.RUIElements.RDropdownMenuAction.RStatus GetMenuItemState(System.Boolean @isChecked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isChecked};
            var ___result = RMGetMenuItemState_Boolean.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
        }


        public virtual void BuildContextMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMBuildContextMenu_ContextualMenuPopulateEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHighlightEnabled(System.Boolean @highlight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highlight};
            var ___result = RMSetHighlightEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(UnityEditor.Overlays.OverlayAttribute @attrib)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attrib};
            var ___result = RMInitialize_OverlayAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.String @_id, System.String @_uss, System.String @_display)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_id, @_uss, @_display};
            var ___result = RMInitialize_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplySaveData(RUnityEditor.ROverlays.RSaveData @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMApplySaveData_SaveData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFloatingChanged(System.Boolean @floating)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@floating};
            var ___result = RMOnFloatingChanged_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DockAt(RUnityEditor.ROverlays.ROverlayContainer @container, RUnityEditor.ROverlays.ROverlayContainerSection @section)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value, @section.Value};
            var ___result = RMDockAt_OverlayContainer_OverlayContainerSection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockAt(RUnityEditor.ROverlays.ROverlayContainer @container, RUnityEditor.ROverlays.ROverlayContainerSection @section, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value, @section.Value, @index};
            var ___result = RMDockAt_OverlayContainer_OverlayContainerSection_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockBefore(UnityEditor.Overlays.Overlay @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMDockBefore_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockAfter(UnityEditor.Overlays.Overlay @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMDockAfter_Overlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Undock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUndock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSnappingOffset(UnityEngine.Vector2 @snapOffset, UnityEngine.Vector2 @snapOffsetDelta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapOffset, @snapOffsetDelta};
            var ___result = RMSetSnappingOffset_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 SnapToFloatingPosition(RUnityEditor.ROverlays.RSnapCorner @corner, UnityEngine.Vector2 @snapPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@corner.Value, @snapPosition};
            var ___result = RMSnapToFloatingPosition_SnapCorner_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void FloatingToSnapPosition(UnityEngine.Vector2 @position, out UnityEngine.Vector2 @snapOffset)
        {
			@snapOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @snapOffset};
            var ___result = RMFloatingToSnapPosition_Vector2_Out_Vector2.Invoke(___genericsType, ___parameters);
			@snapOffset = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void FloatingToSnapPosition(UnityEngine.Vector2 @position, out RUnityEditor.ROverlays.RSnapCorner @snapCorner, out UnityEngine.Vector2 @snapOffset)
        {
			@snapCorner = default;
			@snapOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @snapCorner.Value, @snapOffset};
            var ___result = RMFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2.Invoke(___genericsType, ___parameters);
			@snapCorner = new RUnityEditor.ROverlays.RSnapCorner(___parameters[1]);
			@snapOffset = (UnityEngine.Vector2)___parameters[2];

            
        }


        public virtual void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSnapping(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMUpdateSnapping_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAbsolutePosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateAbsolutePosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ToggleCollapsedPopup__1__b__154_0(UnityEngine.UIElements.FocusOutEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RM__0__ToggleCollapsedPopup__1__b__154_0_FocusOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_0(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_0_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_1(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_1_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_2(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_2_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_3(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_3_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_4(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_4_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_5(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_5_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__BuildContextMenu__1__b__157_6(UnityEngine.UIElements.DropdownMenuAction @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RM__0__BuildContextMenu__1__b__157_6_DropdownMenuAction.Invoke(___genericsType, ___parameters);

            
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
