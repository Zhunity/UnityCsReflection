
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.Overlay
	/// </summary>
    public partial class ROverlay : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.Overlays.Overlay);
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
				}
				return r_EdisplayNameChanged;
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
					r_Fk_UxmlPath = new(typeof(UnityEditor.Overlays.Overlay), "k_UxmlPath");
				}
				return r_Fk_UxmlPath;
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
					r_FussClassName = new(typeof(UnityEditor.Overlays.Overlay), "ussClassName");
				}
				return r_FussClassName;
			}
		}

		/// <summary>
		/// System.String k_Highlight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_Highlight;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_Highlight
		{
			get
			{
				if(r_Fk_Highlight == null)
				{
					r_Fk_Highlight = new(typeof(UnityEditor.Overlays.Overlay), "k_Highlight");
				}
				return r_Fk_Highlight;
			}
		}

		/// <summary>
		/// System.String k_Floating
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_Floating;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_Floating
		{
			get
			{
				if(r_Fk_Floating == null)
				{
					r_Fk_Floating = new(typeof(UnityEditor.Overlays.Overlay), "k_Floating");
				}
				return r_Fk_Floating;
			}
		}

		/// <summary>
		/// System.String headerTitle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FheaderTitle;
		public static Hvak.Editor.Refleaction.RSystem.RString RFheaderTitle
		{
			get
			{
				if(r_FheaderTitle == null)
				{
					r_FheaderTitle = new(typeof(UnityEditor.Overlays.Overlay), "headerTitle");
				}
				return r_FheaderTitle;
			}
		}

		/// <summary>
		/// System.String k_Collapsed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_Collapsed;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_Collapsed
		{
			get
			{
				if(r_Fk_Collapsed == null)
				{
					r_Fk_Collapsed = new(typeof(UnityEditor.Overlays.Overlay), "k_Collapsed");
				}
				return r_Fk_Collapsed;
			}
		}

		/// <summary>
		/// System.String k_Header
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_Header;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_Header
		{
			get
			{
				if(r_Fk_Header == null)
				{
					r_Fk_Header = new(typeof(UnityEditor.Overlays.Overlay), "k_Header");
				}
				return r_Fk_Header;
			}
		}

		/// <summary>
		/// System.String k_Expanded
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_Expanded;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_Expanded
		{
			get
			{
				if(r_Fk_Expanded == null)
				{
					r_Fk_Expanded = new(typeof(UnityEditor.Overlays.Overlay), "k_Expanded");
				}
				return r_Fk_Expanded;
			}
		}

		/// <summary>
		/// System.String k_CollapsedContent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_CollapsedContent;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_CollapsedContent
		{
			get
			{
				if(r_Fk_CollapsedContent == null)
				{
					r_Fk_CollapsedContent = new(typeof(UnityEditor.Overlays.Overlay), "k_CollapsedContent");
				}
				return r_Fk_CollapsedContent;
			}
		}

		/// <summary>
		/// System.String k_CollapsedIconButton
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_CollapsedIconButton;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_CollapsedIconButton
		{
			get
			{
				if(r_Fk_CollapsedIconButton == null)
				{
					r_Fk_CollapsedIconButton = new(typeof(UnityEditor.Overlays.Overlay), "k_CollapsedIconButton");
				}
				return r_Fk_CollapsedIconButton;
			}
		}

		/// <summary>
		/// System.String k_ToolbarHorizontalLayout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ToolbarHorizontalLayout;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ToolbarHorizontalLayout
		{
			get
			{
				if(r_Fk_ToolbarHorizontalLayout == null)
				{
					r_Fk_ToolbarHorizontalLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_ToolbarHorizontalLayout");
				}
				return r_Fk_ToolbarHorizontalLayout;
			}
		}

		/// <summary>
		/// System.String k_ToolbarVerticalLayout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_ToolbarVerticalLayout;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_ToolbarVerticalLayout
		{
			get
			{
				if(r_Fk_ToolbarVerticalLayout == null)
				{
					r_Fk_ToolbarVerticalLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_ToolbarVerticalLayout");
				}
				return r_Fk_ToolbarVerticalLayout;
			}
		}

		/// <summary>
		/// System.String k_PanelLayout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_PanelLayout;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_PanelLayout
		{
			get
			{
				if(r_Fk_PanelLayout == null)
				{
					r_Fk_PanelLayout = new(typeof(UnityEditor.Overlays.Overlay), "k_PanelLayout");
				}
				return r_Fk_PanelLayout;
			}
		}

		/// <summary>
		/// System.String m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// System.String m_RootVisualElementName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_RootVisualElementName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_RootVisualElementName
		{
			get
			{
				if(r_Fm_RootVisualElementName == null)
				{
					r_Fm_RootVisualElementName = new(this, "m_RootVisualElementName");
				}
				return r_Fm_RootVisualElementName;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_Layout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_Fm_Layout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RFm_Layout
		{
			get
			{
				if(r_Fm_Layout == null)
				{
					r_Fm_Layout = new(this, "m_Layout");
				}
				return r_Fm_Layout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_ActiveLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_Fm_ActiveLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RFm_ActiveLayout
		{
			get
			{
				if(r_Fm_ActiveLayout == null)
				{
					r_Fm_ActiveLayout = new(this, "m_ActiveLayout");
				}
				return r_Fm_ActiveLayout;
			}
		}

		/// <summary>
		/// System.Boolean m_Collapsed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Collapsed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Collapsed
		{
			get
			{
				if(r_Fm_Collapsed == null)
				{
					r_Fm_Collapsed = new(this, "m_Collapsed");
				}
				return r_Fm_Collapsed;
			}
		}

		/// <summary>
		/// System.Boolean <dontSaveInLayout>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__dontSaveInLayout__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__dontSaveInLayout__1__k__BackingField
		{
			get
			{
				if(r_F__0__dontSaveInLayout__1__k__BackingField == null)
				{
					r_F__0__dontSaveInLayout__1__k__BackingField = new(this, "<dontSaveInLayout>k__BackingField");
				}
				return r_F__0__dontSaveInLayout__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasMenuEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasMenuEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasMenuEntry
		{
			get
			{
				if(r_Fm_HasMenuEntry == null)
				{
					r_Fm_HasMenuEntry = new(this, "m_HasMenuEntry");
				}
				return r_Fm_HasMenuEntry;
			}
		}

		/// <summary>
		/// System.Boolean m_Floating
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Floating;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Floating
		{
			get
			{
				if(r_Fm_Floating == null)
				{
					r_Fm_Floating = new(this, "m_Floating");
				}
				return r_Fm_Floating;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_FloatingSnapOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_FloatingSnapOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_FloatingSnapOffset
		{
			get
			{
				if(r_Fm_FloatingSnapOffset == null)
				{
					r_Fm_FloatingSnapOffset = new(this, "m_FloatingSnapOffset");
				}
				return r_Fm_FloatingSnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_SnapOffsetDelta
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_SnapOffsetDelta;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_SnapOffsetDelta
		{
			get
			{
				if(r_Fm_SnapOffsetDelta == null)
				{
					r_Fm_SnapOffsetDelta = new(this, "m_SnapOffsetDelta");
				}
				return r_Fm_SnapOffsetDelta;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_MinSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_MinSize
		{
			get
			{
				if(r_Fm_MinSize == null)
				{
					r_Fm_MinSize = new(this, "m_MinSize");
				}
				return r_Fm_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_MaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_MaxSize
		{
			get
			{
				if(r_Fm_MaxSize == null)
				{
					r_Fm_MaxSize = new(this, "m_MaxSize");
				}
				return r_Fm_MaxSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_Size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_Size;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_Size
		{
			get
			{
				if(r_Fm_Size == null)
				{
					r_Fm_Size = new(this, "m_Size");
				}
				return r_Fm_Size;
			}
		}

		/// <summary>
		/// System.Boolean m_SizeOverridden
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_SizeOverridden;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_SizeOverridden
		{
			get
			{
				if(r_Fm_SizeOverridden == null)
				{
					r_Fm_SizeOverridden = new(this, "m_SizeOverridden");
				}
				return r_Fm_SizeOverridden;
			}
		}

		/// <summary>
		/// System.Boolean m_LockAnchor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_LockAnchor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_LockAnchor
		{
			get
			{
				if(r_Fm_LockAnchor == null)
				{
					r_Fm_LockAnchor = new(this, "m_LockAnchor");
				}
				return r_Fm_LockAnchor;
			}
		}

		/// <summary>
		/// System.Boolean m_ContentsChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ContentsChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ContentsChanged
		{
			get
			{
				if(r_Fm_ContentsChanged == null)
				{
					r_Fm_ContentsChanged = new(this, "m_ContentsChanged");
				}
				return r_Fm_ContentsChanged;
			}
		}

		/// <summary>
		/// System.Boolean m_DisableContentModification
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DisableContentModification;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DisableContentModification
		{
			get
			{
				if(r_Fm_DisableContentModification == null)
				{
					r_Fm_DisableContentModification = new(this, "m_DisableContentModification");
				}
				return r_Fm_DisableContentModification;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas <canvas>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas r_F__0__canvas__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas RF__0__canvas__1__k__BackingField
		{
			get
			{
				if(r_F__0__canvas__1__k__BackingField == null)
				{
					r_F__0__canvas__1__k__BackingField = new(this, "<canvas>k__BackingField");
				}
				return r_F__0__canvas__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer m_Container
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_Fm_Container;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RFm_Container
		{
			get
			{
				if(r_Fm_Container == null)
				{
					r_Fm_Container = new(this, "m_Container");
				}
				return r_Fm_Container;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CurrentContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_CurrentContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_CurrentContent
		{
			get
			{
				if(r_Fm_CurrentContent == null)
				{
					r_Fm_CurrentContent = new(this, "m_CurrentContent");
				}
				return r_Fm_CurrentContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CollapsedContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_CollapsedContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_CollapsedContent
		{
			get
			{
				if(r_Fm_CollapsedContent == null)
				{
					r_Fm_CollapsedContent = new(this, "m_CollapsedContent");
				}
				return r_Fm_CollapsedContent;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayPopup m_ModalPopup
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayPopup r_Fm_ModalPopup;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayPopup RFm_ModalPopup
		{
			get
			{
				if(r_Fm_ModalPopup == null)
				{
					r_Fm_ModalPopup = new(this, "m_ModalPopup");
				}
				return r_Fm_ModalPopup;
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
				}
				return r_Fm_RootVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ResizeTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_ResizeTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_ResizeTarget
		{
			get
			{
				if(r_Fm_ResizeTarget == null)
				{
					r_Fm_ResizeTarget = new(this, "m_ResizeTarget");
				}
				return r_Fm_ResizeTarget;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone m_BeforeDropZone
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZone r_Fm_BeforeDropZone;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZone RFm_BeforeDropZone
		{
			get
			{
				if(r_Fm_BeforeDropZone == null)
				{
					r_Fm_BeforeDropZone = new(this, "m_BeforeDropZone");
				}
				return r_Fm_BeforeDropZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone m_AfterDropZone
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZone r_Fm_AfterDropZone;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZone RFm_AfterDropZone
		{
			get
			{
				if(r_Fm_AfterDropZone == null)
				{
					r_Fm_AfterDropZone = new(this, "m_AfterDropZone");
				}
				return r_Fm_AfterDropZone;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.Layout] layoutChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout> r_FlayoutChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout> RFlayoutChanged
		{
			get
			{
				if(r_FlayoutChanged == null)
				{
					r_FlayoutChanged = new(this, "layoutChanged");
				}
				return r_FlayoutChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] collapsedChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FcollapsedChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> RFcollapsedChanged
		{
			get
			{
				if(r_FcollapsedChanged == null)
				{
					r_FcollapsedChanged = new(this, "collapsedChanged");
				}
				return r_FcollapsedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] displayedChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FdisplayedChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> RFdisplayedChanged
		{
			get
			{
				if(r_FdisplayedChanged == null)
				{
					r_FdisplayedChanged = new(this, "displayedChanged");
				}
				return r_FdisplayedChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.Overlays.OverlayContainer] containerChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer> r_FcontainerChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer> RFcontainerChanged
		{
			get
			{
				if(r_FcontainerChanged == null)
				{
					r_FcontainerChanged = new(this, "containerChanged");
				}
				return r_FcontainerChanged;
			}
		}

		/// <summary>
		/// System.Action minSizeChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FminSizeChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFminSizeChanged
		{
			get
			{
				if(r_FminSizeChanged == null)
				{
					r_FminSizeChanged = new(this, "minSizeChanged");
				}
				return r_FminSizeChanged;
			}
		}

		/// <summary>
		/// System.Action maxSizeChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FmaxSizeChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFmaxSizeChanged
		{
			get
			{
				if(r_FmaxSizeChanged == null)
				{
					r_FmaxSizeChanged = new(this, "maxSizeChanged");
				}
				return r_FmaxSizeChanged;
			}
		}

		/// <summary>
		/// System.Action sizeOverridenChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FsizeOverridenChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFsizeOverridenChanged
		{
			get
			{
				if(r_FsizeOverridenChanged == null)
				{
					r_FsizeOverridenChanged = new(this, "sizeOverridenChanged");
				}
				return r_FsizeOverridenChanged;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] floatingChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> r_FfloatingChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RBoolean> RFfloatingChanged
		{
			get
			{
				if(r_FfloatingChanged == null)
				{
					r_FfloatingChanged = new(this, "floatingChanged");
				}
				return r_FfloatingChanged;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Vector3] floatingPositionChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RVector3> r_FfloatingPositionChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RVector3> RFfloatingPositionChanged
		{
			get
			{
				if(r_FfloatingPositionChanged == null)
				{
					r_FfloatingPositionChanged = new(this, "floatingPositionChanged");
				}
				return r_FfloatingPositionChanged;
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
					r_Fs_TreeAsset = new(typeof(UnityEditor.Overlays.Overlay), "s_TreeAsset");
				}
				return r_Fs_TreeAsset;
			}
		}

		/// <summary>
		/// System.Action displayNameChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FdisplayNameChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFdisplayNameChanged
		{
			get
			{
				if(r_FdisplayNameChanged == null)
				{
					r_FdisplayNameChanged = new(this, "displayNameChanged");
				}
				return r_FdisplayNameChanged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ContentRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_ContentRoot;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_ContentRoot
		{
			get
			{
				if(r_Fm_ContentRoot == null)
				{
					r_Fm_ContentRoot = new(this, "m_ContentRoot");
				}
				return r_Fm_ContentRoot;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_CollapsedIcon
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Fm_CollapsedIcon;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RFm_CollapsedIcon
		{
			get
			{
				if(r_Fm_CollapsedIcon == null)
				{
					r_Fm_CollapsedIcon = new(this, "m_CollapsedIcon");
				}
				return r_Fm_CollapsedIcon;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner <floatingSnapCorner>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner r_F__0__floatingSnapCorner__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner RF__0__floatingSnapCorner__1__k__BackingField
		{
			get
			{
				if(r_F__0__floatingSnapCorner__1__k__BackingField == null)
				{
					r_F__0__floatingSnapCorner__1__k__BackingField = new(this, "<floatingSnapCorner>k__BackingField");
				}
				return r_F__0__floatingSnapCorner__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean dontSaveInLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdontSaveInLayout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdontSaveInLayout
		{
			get
			{
				if(r_PdontSaveInLayout == null)
				{
					r_PdontSaveInLayout = new(this, "dontSaveInLayout", -1);
				}
				return r_PdontSaveInLayout;
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
				}
				return r_PcontainerWindow;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayCanvas canvas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas r_Pcanvas;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayCanvas RPcanvas
		{
			get
			{
				if(r_Pcanvas == null)
				{
					r_Pcanvas = new(this, "canvas", -1);
				}
				return r_Pcanvas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement resizeTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PresizeTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPresizeTarget
		{
			get
			{
				if(r_PresizeTarget == null)
				{
					r_PresizeTarget = new(this, "resizeTarget", -1);
				}
				return r_PresizeTarget;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Boolean hasMenuEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasMenuEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasMenuEntry
		{
			get
			{
				if(r_PhasMenuEntry == null)
				{
					r_PhasMenuEntry = new(this, "hasMenuEntry", -1);
				}
				return r_PhasMenuEntry;
			}
		}

		/// <summary>
		/// UnityEngine.Rect collapsedButtonRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PcollapsedButtonRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPcollapsedButtonRect
		{
			get
			{
				if(r_PcollapsedButtonRect == null)
				{
					r_PcollapsedButtonRect = new(this, "collapsedButtonRect", -1);
				}
				return r_PcollapsedButtonRect;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D collapsedIcon
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PcollapsedIcon;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPcollapsedIcon
		{
			get
			{
				if(r_PcollapsedIcon == null)
				{
					r_PcollapsedIcon = new(this, "collapsedIcon", -1);
				}
				return r_PcollapsedIcon;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement collapsedContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PcollapsedContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPcollapsedContent
		{
			get
			{
				if(r_PcollapsedContent == null)
				{
					r_PcollapsedContent = new(this, "collapsedContent", -1);
				}
				return r_PcollapsedContent;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout layout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_Playout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout activeLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_PactiveLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RPactiveLayout
		{
			get
			{
				if(r_PactiveLayout == null)
				{
					r_PactiveLayout = new(this, "activeLayout", -1);
				}
				return r_PactiveLayout;
			}
		}

		/// <summary>
		/// Boolean collapsed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pcollapsed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcollapsed
		{
			get
			{
				if(r_Pcollapsed == null)
				{
					r_Pcollapsed = new(this, "collapsed", -1);
				}
				return r_Pcollapsed;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// Boolean userControlledVisibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuserControlledVisibility;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuserControlledVisibility
		{
			get
			{
				if(r_PuserControlledVisibility == null)
				{
					r_PuserControlledVisibility = new(this, "userControlledVisibility", -1);
				}
				return r_PuserControlledVisibility;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayContainer container
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer r_Pcontainer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer RPcontainer
		{
			get
			{
				if(r_Pcontainer == null)
				{
					r_Pcontainer = new(this, "container", -1);
				}
				return r_Pcontainer;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone dockZone
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockZone r_PdockZone;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockZone RPdockZone
		{
			get
			{
				if(r_PdockZone == null)
				{
					r_PdockZone = new(this, "dockZone", -1);
				}
				return r_PdockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition dockPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition r_PdockPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition RPdockPosition
		{
			get
			{
				if(r_PdockPosition == null)
				{
					r_PdockPosition = new(this, "dockPosition", -1);
				}
				return r_PdockPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset treeAsset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_PtreeAsset;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RPtreeAsset
		{
			get
			{
				if(r_PtreeAsset == null)
				{
					r_PtreeAsset = new(typeof(UnityEditor.Overlays.Overlay), "treeAsset", -1);
				}
				return r_PtreeAsset;
			}
		}

		/// <summary>
		/// Boolean displayed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdisplayed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisplayed
		{
			get
			{
				if(r_Pdisplayed == null)
				{
					r_Pdisplayed = new(this, "displayed", -1);
				}
				return r_Pdisplayed;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout supportedLayouts
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_PsupportedLayouts;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RPsupportedLayouts
		{
			get
			{
				if(r_PsupportedLayouts == null)
				{
					r_PsupportedLayouts = new(this, "supportedLayouts", -1);
				}
				return r_PsupportedLayouts;
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
				}
				return r_ProotVisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PcontentRoot;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPcontentRoot
		{
			get
			{
				if(r_PcontentRoot == null)
				{
					r_PcontentRoot = new(this, "contentRoot", -1);
				}
				return r_PcontentRoot;
			}
		}

		/// <summary>
		/// Boolean isInToolbar
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInToolbar;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInToolbar
		{
			get
			{
				if(r_PisInToolbar == null)
				{
					r_PisInToolbar = new(this, "isInToolbar", -1);
				}
				return r_PisInToolbar;
			}
		}

		/// <summary>
		/// Boolean sizeOverridden
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PsizeOverridden;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsizeOverridden
		{
			get
			{
				if(r_PsizeOverridden == null)
				{
					r_PsizeOverridden = new(this, "sizeOverridden", -1);
				}
				return r_PsizeOverridden;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 sizeToSave
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PsizeToSave;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPsizeToSave
		{
			get
			{
				if(r_PsizeToSave == null)
				{
					r_PsizeToSave = new(this, "sizeToSave", -1);
				}
				return r_PsizeToSave;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Psize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PminSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPminSize
		{
			get
			{
				if(r_PminSize == null)
				{
					r_PminSize = new(this, "minSize", -1);
				}
				return r_PminSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmaxSize
		{
			get
			{
				if(r_PmaxSize == null)
				{
					r_PmaxSize = new(this, "maxSize", -1);
				}
				return r_PmaxSize;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.SnapCorner floatingSnapCorner
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner r_PfloatingSnapCorner;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner RPfloatingSnapCorner
		{
			get
			{
				if(r_PfloatingSnapCorner == null)
				{
					r_PfloatingSnapCorner = new(this, "floatingSnapCorner", -1);
				}
				return r_PfloatingSnapCorner;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 floatingSnapOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PfloatingSnapOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPfloatingSnapOffset
		{
			get
			{
				if(r_PfloatingSnapOffset == null)
				{
					r_PfloatingSnapOffset = new(this, "floatingSnapOffset", -1);
				}
				return r_PfloatingSnapOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 floatingPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PfloatingPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPfloatingPosition
		{
			get
			{
				if(r_PfloatingPosition == null)
				{
					r_PfloatingPosition = new(this, "floatingPosition", -1);
				}
				return r_PfloatingPosition;
			}
		}

		/// <summary>
		/// Boolean floating
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pfloating;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPfloating
		{
			get
			{
				if(r_Pfloating == null)
				{
					r_Pfloating = new(this, "floating", -1);
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


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus GetMenuItemState(System.Boolean @isChecked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isChecked};
            var ___result = RMGetMenuItemState_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDropdownMenuAction.RStatus(___result);
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


        public virtual void ApplySaveData(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSaveData @data)
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


        public virtual System.Boolean DockAt(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer @container, Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainerSection @section)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value, @section.Value};
            var ___result = RMDockAt_OverlayContainer_OverlayContainerSection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DockAt(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer @container, Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainerSection @section, System.Int32 @index)
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


        public virtual UnityEngine.Vector2 SnapToFloatingPosition(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner @corner, UnityEngine.Vector2 @snapPosition)
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


        public virtual void FloatingToSnapPosition(UnityEngine.Vector2 @position, out Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner @snapCorner, out UnityEngine.Vector2 @snapOffset)
        {
			@snapCorner = default;
			@snapOffset = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @snapCorner.Value, @snapOffset};
            var ___result = RMFloatingToSnapPosition_Vector2_Out_SnapCorner_Out_Vector2.Invoke(___genericsType, ___parameters);
			@snapCorner = new Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RSnapCorner(___parameters[1]);
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
