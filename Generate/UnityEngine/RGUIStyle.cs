using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUIStyle
	/// </summary>
    public partial class RGUIStyle : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Normal
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_Normal;
		public virtual RUnityEngine.RGUIStyleState Rm_Normal
		{
			get
			{
				if(r_m_Normal == null)
				{
					r_m_Normal = new(this, "m_Normal");
					r_m_Normal.SetBelong(this.instance);
				}
				return r_m_Normal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Hover
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_Hover;
		public virtual RUnityEngine.RGUIStyleState Rm_Hover
		{
			get
			{
				if(r_m_Hover == null)
				{
					r_m_Hover = new(this, "m_Hover");
					r_m_Hover.SetBelong(this.instance);
				}
				return r_m_Hover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Active
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_Active;
		public virtual RUnityEngine.RGUIStyleState Rm_Active
		{
			get
			{
				if(r_m_Active == null)
				{
					r_m_Active = new(this, "m_Active");
					r_m_Active.SetBelong(this.instance);
				}
				return r_m_Active;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Focused
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_Focused;
		public virtual RUnityEngine.RGUIStyleState Rm_Focused
		{
			get
			{
				if(r_m_Focused == null)
				{
					r_m_Focused = new(this, "m_Focused");
					r_m_Focused.SetBelong(this.instance);
				}
				return r_m_Focused;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnNormal
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_OnNormal;
		public virtual RUnityEngine.RGUIStyleState Rm_OnNormal
		{
			get
			{
				if(r_m_OnNormal == null)
				{
					r_m_OnNormal = new(this, "m_OnNormal");
					r_m_OnNormal.SetBelong(this.instance);
				}
				return r_m_OnNormal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnHover
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_OnHover;
		public virtual RUnityEngine.RGUIStyleState Rm_OnHover
		{
			get
			{
				if(r_m_OnHover == null)
				{
					r_m_OnHover = new(this, "m_OnHover");
					r_m_OnHover.SetBelong(this.instance);
				}
				return r_m_OnHover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnActive
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_OnActive;
		public virtual RUnityEngine.RGUIStyleState Rm_OnActive
		{
			get
			{
				if(r_m_OnActive == null)
				{
					r_m_OnActive = new(this, "m_OnActive");
					r_m_OnActive.SetBelong(this.instance);
				}
				return r_m_OnActive;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnFocused
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_m_OnFocused;
		public virtual RUnityEngine.RGUIStyleState Rm_OnFocused
		{
			get
			{
				if(r_m_OnFocused == null)
				{
					r_m_OnFocused = new(this, "m_OnFocused");
					r_m_OnFocused.SetBelong(this.instance);
				}
				return r_m_OnFocused;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Border
		/// </summary>
		protected RUnityEngine.RRectOffset r_m_Border;
		public virtual RUnityEngine.RRectOffset Rm_Border
		{
			get
			{
				if(r_m_Border == null)
				{
					r_m_Border = new(this, "m_Border");
					r_m_Border.SetBelong(this.instance);
				}
				return r_m_Border;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Padding
		/// </summary>
		protected RUnityEngine.RRectOffset r_m_Padding;
		public virtual RUnityEngine.RRectOffset Rm_Padding
		{
			get
			{
				if(r_m_Padding == null)
				{
					r_m_Padding = new(this, "m_Padding");
					r_m_Padding.SetBelong(this.instance);
				}
				return r_m_Padding;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Margin
		/// </summary>
		protected RUnityEngine.RRectOffset r_m_Margin;
		public virtual RUnityEngine.RRectOffset Rm_Margin
		{
			get
			{
				if(r_m_Margin == null)
				{
					r_m_Margin = new(this, "m_Margin");
					r_m_Margin.SetBelong(this.instance);
				}
				return r_m_Margin;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Overflow
		/// </summary>
		protected RUnityEngine.RRectOffset r_m_Overflow;
		public virtual RUnityEngine.RRectOffset Rm_Overflow
		{
			get
			{
				if(r_m_Overflow == null)
				{
					r_m_Overflow = new(this, "m_Overflow");
					r_m_Overflow.SetBelong(this.instance);
				}
				return r_m_Overflow;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// UnityEngine.DrawHandler onDraw
		/// </summary>
		protected static RUnityEngine.RDrawHandler r_onDraw;
		public static RUnityEngine.RDrawHandler RonDraw
		{
			get
			{
				if(r_onDraw == null)
				{
					r_onDraw = new(typeof(UnityEngine.GUIStyle), "onDraw");
					r_onDraw.SetBelong(null);
				}
				return r_onDraw;
			}
		}

		/// <summary>
		/// System.Int32 blockId
		/// </summary>
		protected RField r_blockId;
		public virtual RField RblockId
		{
			get
			{
				if(r_blockId == null)
				{
					r_blockId = new(this, "blockId");
					r_blockId.SetBelong(this.instance);
				}
				return r_blockId;
			}
		}

		/// <summary>
		/// System.Boolean showKeyboardFocus
		/// </summary>
		protected static RField r_showKeyboardFocus;
		public static RField RshowKeyboardFocus
		{
			get
			{
				if(r_showKeyboardFocus == null)
				{
					r_showKeyboardFocus = new(typeof(UnityEngine.GUIStyle), "showKeyboardFocus");
					r_showKeyboardFocus.SetBelong(null);
				}
				return r_showKeyboardFocus;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle s_None
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_s_None;
		public static RUnityEngine.RGUIStyle Rs_None
		{
			get
			{
				if(r_s_None == null)
				{
					r_s_None = new(typeof(UnityEngine.GUIStyle), "s_None");
					r_s_None.SetBelong(null);
				}
				return r_s_None;
			}
		}

		/// <summary>
		/// System.String rawName
		/// </summary>
		protected RProperty r_rawName;
		public virtual RProperty RrawName
		{
			get
			{
				if(r_rawName == null)
				{
					r_rawName = new(this, "rawName", -1);
					r_rawName.SetBelong(this.instance);
				}
				return r_rawName;
			}
		}

		/// <summary>
		/// UnityEngine.Font font
		/// </summary>
		protected RUnityEngine.RFont r_font;
		public virtual RUnityEngine.RFont Rfont
		{
			get
			{
				if(r_font == null)
				{
					r_font = new(this, "font", -1);
					r_font.SetBelong(this.instance);
				}
				return r_font;
			}
		}

		/// <summary>
		/// UnityEngine.ImagePosition imagePosition
		/// </summary>
		protected RProperty r_imagePosition;
		public virtual RProperty RimagePosition
		{
			get
			{
				if(r_imagePosition == null)
				{
					r_imagePosition = new(this, "imagePosition", -1);
					r_imagePosition.SetBelong(this.instance);
				}
				return r_imagePosition;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor alignment
		/// </summary>
		protected RProperty r_alignment;
		public virtual RProperty Ralignment
		{
			get
			{
				if(r_alignment == null)
				{
					r_alignment = new(this, "alignment", -1);
					r_alignment.SetBelong(this.instance);
				}
				return r_alignment;
			}
		}

		/// <summary>
		/// Boolean wordWrap
		/// </summary>
		protected RProperty r_wordWrap;
		public virtual RProperty RwordWrap
		{
			get
			{
				if(r_wordWrap == null)
				{
					r_wordWrap = new(this, "wordWrap", -1);
					r_wordWrap.SetBelong(this.instance);
				}
				return r_wordWrap;
			}
		}

		/// <summary>
		/// UnityEngine.TextClipping clipping
		/// </summary>
		protected RProperty r_clipping;
		public virtual RProperty Rclipping
		{
			get
			{
				if(r_clipping == null)
				{
					r_clipping = new(this, "clipping", -1);
					r_clipping.SetBelong(this.instance);
				}
				return r_clipping;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 contentOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_contentOffset;
		public virtual RUnityEngine.RVector2 RcontentOffset
		{
			get
			{
				if(r_contentOffset == null)
				{
					r_contentOffset = new(this, "contentOffset", -1);
					r_contentOffset.SetBelong(this.instance);
				}
				return r_contentOffset;
			}
		}

		/// <summary>
		/// Single fixedWidth
		/// </summary>
		protected RProperty r_fixedWidth;
		public virtual RProperty RfixedWidth
		{
			get
			{
				if(r_fixedWidth == null)
				{
					r_fixedWidth = new(this, "fixedWidth", -1);
					r_fixedWidth.SetBelong(this.instance);
				}
				return r_fixedWidth;
			}
		}

		/// <summary>
		/// Single fixedHeight
		/// </summary>
		protected RProperty r_fixedHeight;
		public virtual RProperty RfixedHeight
		{
			get
			{
				if(r_fixedHeight == null)
				{
					r_fixedHeight = new(this, "fixedHeight", -1);
					r_fixedHeight.SetBelong(this.instance);
				}
				return r_fixedHeight;
			}
		}

		/// <summary>
		/// Boolean stretchWidth
		/// </summary>
		protected RProperty r_stretchWidth;
		public virtual RProperty RstretchWidth
		{
			get
			{
				if(r_stretchWidth == null)
				{
					r_stretchWidth = new(this, "stretchWidth", -1);
					r_stretchWidth.SetBelong(this.instance);
				}
				return r_stretchWidth;
			}
		}

		/// <summary>
		/// Boolean stretchHeight
		/// </summary>
		protected RProperty r_stretchHeight;
		public virtual RProperty RstretchHeight
		{
			get
			{
				if(r_stretchHeight == null)
				{
					r_stretchHeight = new(this, "stretchHeight", -1);
					r_stretchHeight.SetBelong(this.instance);
				}
				return r_stretchHeight;
			}
		}

		/// <summary>
		/// Int32 fontSize
		/// </summary>
		protected RProperty r_fontSize;
		public virtual RProperty RfontSize
		{
			get
			{
				if(r_fontSize == null)
				{
					r_fontSize = new(this, "fontSize", -1);
					r_fontSize.SetBelong(this.instance);
				}
				return r_fontSize;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle fontStyle
		/// </summary>
		protected RProperty r_fontStyle;
		public virtual RProperty RfontStyle
		{
			get
			{
				if(r_fontStyle == null)
				{
					r_fontStyle = new(this, "fontStyle", -1);
					r_fontStyle.SetBelong(this.instance);
				}
				return r_fontStyle;
			}
		}

		/// <summary>
		/// Boolean richText
		/// </summary>
		protected RProperty r_richText;
		public virtual RProperty RrichText
		{
			get
			{
				if(r_richText == null)
				{
					r_richText = new(this, "richText", -1);
					r_richText.SetBelong(this.instance);
				}
				return r_richText;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 clipOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_clipOffset;
		public virtual RUnityEngine.RVector2 RclipOffset
		{
			get
			{
				if(r_clipOffset == null)
				{
					r_clipOffset = new(this, "clipOffset", -1);
					r_clipOffset.SetBelong(this.instance);
				}
				return r_clipOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_clipOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_Internal_clipOffset;
		public virtual RUnityEngine.RVector2 RInternal_clipOffset
		{
			get
			{
				if(r_Internal_clipOffset == null)
				{
					r_Internal_clipOffset = new(this, "Internal_clipOffset", -1);
					r_Internal_clipOffset.SetBelong(this.instance);
				}
				return r_Internal_clipOffset;
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
		/// UnityEngine.GUIStyleState normal
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_normal;
		public virtual RUnityEngine.RGUIStyleState Rnormal
		{
			get
			{
				if(r_normal == null)
				{
					r_normal = new(this, "normal", -1);
					r_normal.SetBelong(this.instance);
				}
				return r_normal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState hover
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_hover;
		public virtual RUnityEngine.RGUIStyleState Rhover
		{
			get
			{
				if(r_hover == null)
				{
					r_hover = new(this, "hover", -1);
					r_hover.SetBelong(this.instance);
				}
				return r_hover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState active
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_active;
		public virtual RUnityEngine.RGUIStyleState Ractive
		{
			get
			{
				if(r_active == null)
				{
					r_active = new(this, "active", -1);
					r_active.SetBelong(this.instance);
				}
				return r_active;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onNormal
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_onNormal;
		public virtual RUnityEngine.RGUIStyleState RonNormal
		{
			get
			{
				if(r_onNormal == null)
				{
					r_onNormal = new(this, "onNormal", -1);
					r_onNormal.SetBelong(this.instance);
				}
				return r_onNormal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onHover
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_onHover;
		public virtual RUnityEngine.RGUIStyleState RonHover
		{
			get
			{
				if(r_onHover == null)
				{
					r_onHover = new(this, "onHover", -1);
					r_onHover.SetBelong(this.instance);
				}
				return r_onHover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onActive
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_onActive;
		public virtual RUnityEngine.RGUIStyleState RonActive
		{
			get
			{
				if(r_onActive == null)
				{
					r_onActive = new(this, "onActive", -1);
					r_onActive.SetBelong(this.instance);
				}
				return r_onActive;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState focused
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_focused;
		public virtual RUnityEngine.RGUIStyleState Rfocused
		{
			get
			{
				if(r_focused == null)
				{
					r_focused = new(this, "focused", -1);
					r_focused.SetBelong(this.instance);
				}
				return r_focused;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onFocused
		/// </summary>
		protected RUnityEngine.RGUIStyleState r_onFocused;
		public virtual RUnityEngine.RGUIStyleState RonFocused
		{
			get
			{
				if(r_onFocused == null)
				{
					r_onFocused = new(this, "onFocused", -1);
					r_onFocused.SetBelong(this.instance);
				}
				return r_onFocused;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset border
		/// </summary>
		protected RUnityEngine.RRectOffset r_border;
		public virtual RUnityEngine.RRectOffset Rborder
		{
			get
			{
				if(r_border == null)
				{
					r_border = new(this, "border", -1);
					r_border.SetBelong(this.instance);
				}
				return r_border;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset margin
		/// </summary>
		protected RUnityEngine.RRectOffset r_margin;
		public virtual RUnityEngine.RRectOffset Rmargin
		{
			get
			{
				if(r_margin == null)
				{
					r_margin = new(this, "margin", -1);
					r_margin.SetBelong(this.instance);
				}
				return r_margin;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset padding
		/// </summary>
		protected RUnityEngine.RRectOffset r_padding;
		public virtual RUnityEngine.RRectOffset Rpadding
		{
			get
			{
				if(r_padding == null)
				{
					r_padding = new(this, "padding", -1);
					r_padding.SetBelong(this.instance);
				}
				return r_padding;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset overflow
		/// </summary>
		protected RUnityEngine.RRectOffset r_overflow;
		public virtual RUnityEngine.RRectOffset Roverflow
		{
			get
			{
				if(r_overflow == null)
				{
					r_overflow = new(this, "overflow", -1);
					r_overflow.SetBelong(this.instance);
				}
				return r_overflow;
			}
		}

		/// <summary>
		/// Single lineHeight
		/// </summary>
		protected RProperty r_lineHeight;
		public virtual RProperty RlineHeight
		{
			get
			{
				if(r_lineHeight == null)
				{
					r_lineHeight = new(this, "lineHeight", -1);
					r_lineHeight.SetBelong(this.instance);
				}
				return r_lineHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle none
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_none;
		public static RUnityEngine.RGUIStyle Rnone
		{
			get
			{
				if(r_none == null)
				{
					r_none = new(typeof(UnityEngine.GUIStyle), "none", -1);
					r_none.SetBelong(null);
				}
				return r_none;
			}
		}

		/// <summary>
		/// Boolean isHeightDependantOnWidth
		/// </summary>
		protected RProperty r_isHeightDependantOnWidth;
		public virtual RProperty RisHeightDependantOnWidth
		{
			get
			{
				if(r_isHeightDependantOnWidth == null)
				{
					r_isHeightDependantOnWidth = new(this, "isHeightDependantOnWidth", -1);
					r_isHeightDependantOnWidth.SetBelong(this.instance);
				}
				return r_isHeightDependantOnWidth;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(UnityEngine.GUIStyle)
		/// </summary>
		protected static RMethod r_RInternal_Create_GUIStyle;
		public static RMethod RInternal_Create_GUIStyle
		{
			get
			{
				if(r_RInternal_Create_GUIStyle == null)
				{
					r_RInternal_Create_GUIStyle = new(typeof(UnityEngine.GUIStyle), "Internal_Create", 0, typeof(UnityEngine.GUIStyle));
					r_RInternal_Create_GUIStyle.SetBelong(null);
				}
				return r_RInternal_Create_GUIStyle;
			}
		}

		/// <summary>
		/// IntPtr Internal_Copy(UnityEngine.GUIStyle, UnityEngine.GUIStyle)
		/// </summary>
		protected static RMethod r_RInternal_Copy_GUIStyle_GUIStyle;
		public static RMethod RInternal_Copy_GUIStyle_GUIStyle
		{
			get
			{
				if(r_RInternal_Copy_GUIStyle_GUIStyle == null)
				{
					r_RInternal_Copy_GUIStyle_GUIStyle = new(typeof(UnityEngine.GUIStyle), "Internal_Copy", 0, typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle));
					r_RInternal_Copy_GUIStyle_GUIStyle.SetBelong(null);
				}
				return r_RInternal_Copy_GUIStyle_GUIStyle;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_Destroy_IntPtr;
		public static RMethod RInternal_Destroy_IntPtr
		{
			get
			{
				if(r_RInternal_Destroy_IntPtr == null)
				{
					r_RInternal_Destroy_IntPtr = new(typeof(UnityEngine.GUIStyle), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_RInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_RInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetStyleStatePtr(Int32)
		/// </summary>
		protected RMethod r_RGetStyleStatePtr_Int32;
		public virtual RMethod RGetStyleStatePtr_Int32
		{
			get
			{
				if(r_RGetStyleStatePtr_Int32 == null)
				{
					r_RGetStyleStatePtr_Int32 = new(this, "GetStyleStatePtr", 0, typeof(System.Int32));
					r_RGetStyleStatePtr_Int32.SetBelong(this.instance);
				}
				return r_RGetStyleStatePtr_Int32;
			}
		}

		/// <summary>
		/// Void AssignStyleState(Int32, IntPtr)
		/// </summary>
		protected RMethod r_RAssignStyleState_Int32_IntPtr;
		public virtual RMethod RAssignStyleState_Int32_IntPtr
		{
			get
			{
				if(r_RAssignStyleState_Int32_IntPtr == null)
				{
					r_RAssignStyleState_Int32_IntPtr = new(this, "AssignStyleState", 0, typeof(System.Int32), typeof(System.IntPtr));
					r_RAssignStyleState_Int32_IntPtr.SetBelong(this.instance);
				}
				return r_RAssignStyleState_Int32_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetRectOffsetPtr(Int32)
		/// </summary>
		protected RMethod r_RGetRectOffsetPtr_Int32;
		public virtual RMethod RGetRectOffsetPtr_Int32
		{
			get
			{
				if(r_RGetRectOffsetPtr_Int32 == null)
				{
					r_RGetRectOffsetPtr_Int32 = new(this, "GetRectOffsetPtr", 0, typeof(System.Int32));
					r_RGetRectOffsetPtr_Int32.SetBelong(this.instance);
				}
				return r_RGetRectOffsetPtr_Int32;
			}
		}

		/// <summary>
		/// Void AssignRectOffset(Int32, IntPtr)
		/// </summary>
		protected RMethod r_RAssignRectOffset_Int32_IntPtr;
		public virtual RMethod RAssignRectOffset_Int32_IntPtr
		{
			get
			{
				if(r_RAssignRectOffset_Int32_IntPtr == null)
				{
					r_RAssignRectOffset_Int32_IntPtr = new(this, "AssignRectOffset", 0, typeof(System.Int32), typeof(System.IntPtr));
					r_RAssignRectOffset_Int32_IntPtr.SetBelong(this.instance);
				}
				return r_RAssignRectOffset_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Single Internal_GetLineHeight(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_GetLineHeight_IntPtr;
		public static RMethod RInternal_GetLineHeight_IntPtr
		{
			get
			{
				if(r_RInternal_GetLineHeight_IntPtr == null)
				{
					r_RInternal_GetLineHeight_IntPtr = new(typeof(UnityEngine.GUIStyle), "Internal_GetLineHeight", 0, typeof(System.IntPtr));
					r_RInternal_GetLineHeight_IntPtr.SetBelong(null);
				}
				return r_RInternal_GetLineHeight_IntPtr;
			}
		}

		/// <summary>
		/// Void Internal_Draw(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "Internal_Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_Draw2(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_RInternal_Draw2_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RInternal_Draw2_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_RInternal_Draw2_Rect_GUIContent_Int32_Boolean == null)
				{
					r_RInternal_Draw2_Rect_GUIContent_Int32_Boolean = new(this, "Internal_Draw2", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
					r_RInternal_Draw2_Rect_GUIContent_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_Draw2_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawCursor(UnityEngine.Rect, UnityEngine.GUIContent, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RInternal_DrawCursor_Rect_GUIContent_Int32_Color;
		public virtual RMethod RInternal_DrawCursor_Rect_GUIContent_Int32_Color
		{
			get
			{
				if(r_RInternal_DrawCursor_Rect_GUIContent_Int32_Color == null)
				{
					r_RInternal_DrawCursor_Rect_GUIContent_Int32_Color = new(this, "Internal_DrawCursor", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(UnityEngine.Color));
					r_RInternal_DrawCursor_Rect_GUIContent_Int32_Color.SetBelong(this.instance);
				}
				return r_RInternal_DrawCursor_Rect_GUIContent_Int32_Color;
			}
		}

		/// <summary>
		/// Void Internal_DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color;
		public virtual RMethod RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color
		{
			get
			{
				if(r_RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color == null)
				{
					r_RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color = new(this, "Internal_DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color.SetBelong(this.instance);
				}
				return r_RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32;
		public virtual RMethod RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32
		{
			get
			{
				if(r_RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32 == null)
				{
					r_RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32 = new(this, "Internal_GetCursorPixelPosition", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
					r_RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32.SetBelong(this.instance);
				}
				return r_RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_GetCursorStringIndex(UnityEngine.Rect, UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2;
		public virtual RMethod RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2
		{
			get
			{
				if(r_RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2 == null)
				{
					r_RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2 = new(this, "Internal_GetCursorStringIndex", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
					r_RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// System.String Internal_GetSelectedRenderedText(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32;
		public virtual RMethod RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32
		{
			get
			{
				if(r_RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32 == null)
				{
					r_RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32 = new(this, "Internal_GetSelectedRenderedText", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] Internal_GetHyperlinksRect(UnityEngine.Rect, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RInternal_GetHyperlinksRect_Rect_GUIContent;
		public virtual RMethod RInternal_GetHyperlinksRect_Rect_GUIContent
		{
			get
			{
				if(r_RInternal_GetHyperlinksRect_Rect_GUIContent == null)
				{
					r_RInternal_GetHyperlinksRect_Rect_GUIContent = new(this, "Internal_GetHyperlinksRect", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent));
					r_RInternal_GetHyperlinksRect_Rect_GUIContent.SetBelong(this.instance);
				}
				return r_RInternal_GetHyperlinksRect_Rect_GUIContent;
			}
		}

		/// <summary>
		/// Int32 Internal_GetNumCharactersThatFitWithinWidth(System.String, Single)
		/// </summary>
		protected RMethod r_RInternal_GetNumCharactersThatFitWithinWidth_String_Single;
		public virtual RMethod RInternal_GetNumCharactersThatFitWithinWidth_String_Single
		{
			get
			{
				if(r_RInternal_GetNumCharactersThatFitWithinWidth_String_Single == null)
				{
					r_RInternal_GetNumCharactersThatFitWithinWidth_String_Single = new(this, "Internal_GetNumCharactersThatFitWithinWidth", 0, typeof(System.String), typeof(System.Single));
					r_RInternal_GetNumCharactersThatFitWithinWidth_String_Single.SetBelong(this.instance);
				}
				return r_RInternal_GetNumCharactersThatFitWithinWidth_String_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RInternal_CalcSize_GUIContent;
		public virtual RMethod RInternal_CalcSize_GUIContent
		{
			get
			{
				if(r_RInternal_CalcSize_GUIContent == null)
				{
					r_RInternal_CalcSize_GUIContent = new(this, "Internal_CalcSize", 0, typeof(UnityEngine.GUIContent));
					r_RInternal_CalcSize_GUIContent.SetBelong(this.instance);
				}
				return r_RInternal_CalcSize_GUIContent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RInternal_CalcSizeWithConstraints_GUIContent_Vector2;
		public virtual RMethod RInternal_CalcSizeWithConstraints_GUIContent_Vector2
		{
			get
			{
				if(r_RInternal_CalcSizeWithConstraints_GUIContent_Vector2 == null)
				{
					r_RInternal_CalcSizeWithConstraints_GUIContent_Vector2 = new(this, "Internal_CalcSizeWithConstraints", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
					r_RInternal_CalcSizeWithConstraints_GUIContent_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_CalcSizeWithConstraints_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// Single Internal_CalcHeight(UnityEngine.GUIContent, Single)
		/// </summary>
		protected RMethod r_RInternal_CalcHeight_GUIContent_Single;
		public virtual RMethod RInternal_CalcHeight_GUIContent_Single
		{
			get
			{
				if(r_RInternal_CalcHeight_GUIContent_Single == null)
				{
					r_RInternal_CalcHeight_GUIContent_Single = new(this, "Internal_CalcHeight", 0, typeof(UnityEngine.GUIContent), typeof(System.Single));
					r_RInternal_CalcHeight_GUIContent_Single.SetBelong(this.instance);
				}
				return r_RInternal_CalcHeight_GUIContent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RInternal_CalcMinMaxWidth_GUIContent;
		public virtual RMethod RInternal_CalcMinMaxWidth_GUIContent
		{
			get
			{
				if(r_RInternal_CalcMinMaxWidth_GUIContent == null)
				{
					r_RInternal_CalcMinMaxWidth_GUIContent = new(this, "Internal_CalcMinMaxWidth", 0, typeof(UnityEngine.GUIContent));
					r_RInternal_CalcMinMaxWidth_GUIContent.SetBelong(this.instance);
				}
				return r_RInternal_CalcMinMaxWidth_GUIContent;
			}
		}

		/// <summary>
		/// Void Internal_DrawPrefixLabel(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean == null)
				{
					r_RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean = new(this, "Internal_DrawPrefixLabel", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
					r_RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawContent(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color, UnityEngine.Color, UnityEngine.Color, Single, Single, Single, Single, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean;
		public virtual RMethod RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean
		{
			get
			{
				if(r_RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean == null)
				{
					r_RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean = new(this, "Internal_DrawContent", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetMouseTooltip(System.String, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RSetMouseTooltip_String_Rect;
		public static RMethod RSetMouseTooltip_String_Rect
		{
			get
			{
				if(r_RSetMouseTooltip_String_Rect == null)
				{
					r_RSetMouseTooltip_String_Rect = new(typeof(UnityEngine.GUIStyle), "SetMouseTooltip", 0, typeof(System.String), typeof(UnityEngine.Rect));
					r_RSetMouseTooltip_String_Rect.SetBelong(null);
				}
				return r_RSetMouseTooltip_String_Rect;
			}
		}

		/// <summary>
		/// Boolean IsTooltipActive(System.String)
		/// </summary>
		protected static RMethod r_RIsTooltipActive_String;
		public static RMethod RIsTooltipActive_String
		{
			get
			{
				if(r_RIsTooltipActive_String == null)
				{
					r_RIsTooltipActive_String = new(typeof(UnityEngine.GUIStyle), "IsTooltipActive", 0, typeof(System.String));
					r_RIsTooltipActive_String.SetBelong(null);
				}
				return r_RIsTooltipActive_String;
			}
		}

		/// <summary>
		/// Single Internal_GetCursorFlashOffset()
		/// </summary>
		protected static RMethod r_RInternal_GetCursorFlashOffset;
		public static RMethod RInternal_GetCursorFlashOffset
		{
			get
			{
				if(r_RInternal_GetCursorFlashOffset == null)
				{
					r_RInternal_GetCursorFlashOffset = new(typeof(UnityEngine.GUIStyle), "Internal_GetCursorFlashOffset", 0);
					r_RInternal_GetCursorFlashOffset.SetBelong(null);
				}
				return r_RInternal_GetCursorFlashOffset;
			}
		}

		/// <summary>
		/// Void SetDefaultFont(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_RSetDefaultFont_Font;
		public static RMethod RSetDefaultFont_Font
		{
			get
			{
				if(r_RSetDefaultFont_Font == null)
				{
					r_RSetDefaultFont_Font = new(typeof(UnityEngine.GUIStyle), "SetDefaultFont", 0, typeof(UnityEngine.Font));
					r_RSetDefaultFont_Font.SetBelong(null);
				}
				return r_RSetDefaultFont_Font;
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
		/// Void CleanupRoots()
		/// </summary>
		protected static RMethod r_RCleanupRoots;
		public static RMethod RCleanupRoots
		{
			get
			{
				if(r_RCleanupRoots == null)
				{
					r_RCleanupRoots = new(typeof(UnityEngine.GUIStyle), "CleanupRoots", 0);
					r_RCleanupRoots.SetBelong(null);
				}
				return r_RCleanupRoots;
			}
		}

		/// <summary>
		/// Void InternalOnAfterDeserialize()
		/// </summary>
		protected RMethod r_RInternalOnAfterDeserialize;
		public virtual RMethod RInternalOnAfterDeserialize
		{
			get
			{
				if(r_RInternalOnAfterDeserialize == null)
				{
					r_RInternalOnAfterDeserialize = new(this, "InternalOnAfterDeserialize", 0);
					r_RInternalOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_RInternalOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDraw_Rect_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RDraw_Rect_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RDraw_Rect_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RDraw_Rect_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, System.String, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.Texture, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_RDraw_Rect_GUIContent_Int32;
		public virtual RMethod RDraw_Rect_GUIContent_Int32
		{
			get
			{
				if(r_RDraw_Rect_GUIContent_Int32 == null)
				{
					r_RDraw_Rect_GUIContent_Int32 = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
					r_RDraw_Rect_GUIContent_Int32.SetBelong(this.instance);
				}
				return r_RDraw_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RDraw_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_RDraw_Rect_GUIContent_Int32_Boolean == null)
				{
					r_RDraw_Rect_GUIContent_Int32_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
					r_RDraw_Rect_GUIContent_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean;
		public virtual RMethod RDraw_Rect_GUIContent_Int32_Boolean_Boolean
		{
			get
			{
				if(r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean == null)
				{
					r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawPrefixLabel(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_RDrawPrefixLabel_Rect_GUIContent_Int32;
		public virtual RMethod RDrawPrefixLabel_Rect_GUIContent_Int32
		{
			get
			{
				if(r_RDrawPrefixLabel_Rect_GUIContent_Int32 == null)
				{
					r_RDrawPrefixLabel_Rect_GUIContent_Int32 = new(this, "DrawPrefixLabel", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
					r_RDrawPrefixLabel_Rect_GUIContent_Int32.SetBelong(this.instance);
				}
				return r_RDrawPrefixLabel_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Void DrawCursor(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32)
		/// </summary>
		protected RMethod r_RDrawCursor_Rect_GUIContent_Int32_Int32;
		public virtual RMethod RDrawCursor_Rect_GUIContent_Int32_Int32
		{
			get
			{
				if(r_RDrawCursor_Rect_GUIContent_Int32_Int32 == null)
				{
					r_RDrawCursor_Rect_GUIContent_Int32_Int32 = new(this, "DrawCursor", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32));
					r_RDrawCursor_Rect_GUIContent_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDrawCursor_Rect_GUIContent_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Int32, Int32, Boolean, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color;
		public virtual RMethod RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color
		{
			get
			{
				if(r_RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color == null)
				{
					r_RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color = new(this, "DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.Color));
					r_RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color.SetBelong(this.instance);
				}
				return r_RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color;
			}
		}

		/// <summary>
		/// Void DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean;
		public virtual RMethod RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean == null)
				{
					r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean = new(this, "DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32;
		public virtual RMethod RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32
		{
			get
			{
				if(r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32 == null)
				{
					r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32 = new(this, "DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Rop_Implicit_String;
		public static RMethod Rop_Implicit_String
		{
			get
			{
				if(r_Rop_Implicit_String == null)
				{
					r_Rop_Implicit_String = new(typeof(UnityEngine.GUIStyle), "op_Implicit", 0, typeof(System.String));
					r_Rop_Implicit_String.SetBelong(null);
				}
				return r_Rop_Implicit_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_RGetCursorPixelPosition_Rect_GUIContent_Int32;
		public virtual RMethod RGetCursorPixelPosition_Rect_GUIContent_Int32
		{
			get
			{
				if(r_RGetCursorPixelPosition_Rect_GUIContent_Int32 == null)
				{
					r_RGetCursorPixelPosition_Rect_GUIContent_Int32 = new(this, "GetCursorPixelPosition", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
					r_RGetCursorPixelPosition_Rect_GUIContent_Int32.SetBelong(this.instance);
				}
				return r_RGetCursorPixelPosition_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCursorStringIndex(UnityEngine.Rect, UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RGetCursorStringIndex_Rect_GUIContent_Vector2;
		public virtual RMethod RGetCursorStringIndex_Rect_GUIContent_Vector2
		{
			get
			{
				if(r_RGetCursorStringIndex_Rect_GUIContent_Vector2 == null)
				{
					r_RGetCursorStringIndex_Rect_GUIContent_Vector2 = new(this, "GetCursorStringIndex", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
					r_RGetCursorStringIndex_Rect_GUIContent_Vector2.SetBelong(this.instance);
				}
				return r_RGetCursorStringIndex_Rect_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// Int32 GetNumCharactersThatFitWithinWidth(System.String, Single)
		/// </summary>
		protected RMethod r_RGetNumCharactersThatFitWithinWidth_String_Single;
		public virtual RMethod RGetNumCharactersThatFitWithinWidth_String_Single
		{
			get
			{
				if(r_RGetNumCharactersThatFitWithinWidth_String_Single == null)
				{
					r_RGetNumCharactersThatFitWithinWidth_String_Single = new(this, "GetNumCharactersThatFitWithinWidth", 0, typeof(System.String), typeof(System.Single));
					r_RGetNumCharactersThatFitWithinWidth_String_Single.SetBelong(this.instance);
				}
				return r_RGetNumCharactersThatFitWithinWidth_String_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RCalcSize_GUIContent;
		public virtual RMethod RCalcSize_GUIContent
		{
			get
			{
				if(r_RCalcSize_GUIContent == null)
				{
					r_RCalcSize_GUIContent = new(this, "CalcSize", 0, typeof(UnityEngine.GUIContent));
					r_RCalcSize_GUIContent.SetBelong(this.instance);
				}
				return r_RCalcSize_GUIContent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RCalcSizeWithConstraints_GUIContent_Vector2;
		public virtual RMethod RCalcSizeWithConstraints_GUIContent_Vector2
		{
			get
			{
				if(r_RCalcSizeWithConstraints_GUIContent_Vector2 == null)
				{
					r_RCalcSizeWithConstraints_GUIContent_Vector2 = new(this, "CalcSizeWithConstraints", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
					r_RCalcSizeWithConstraints_GUIContent_Vector2.SetBelong(this.instance);
				}
				return r_RCalcSizeWithConstraints_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcScreenSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RCalcScreenSize_Vector2;
		public virtual RMethod RCalcScreenSize_Vector2
		{
			get
			{
				if(r_RCalcScreenSize_Vector2 == null)
				{
					r_RCalcScreenSize_Vector2 = new(this, "CalcScreenSize", 0, typeof(UnityEngine.Vector2));
					r_RCalcScreenSize_Vector2.SetBelong(this.instance);
				}
				return r_RCalcScreenSize_Vector2;
			}
		}

		/// <summary>
		/// Single CalcHeight(UnityEngine.GUIContent, Single)
		/// </summary>
		protected RMethod r_RCalcHeight_GUIContent_Single;
		public virtual RMethod RCalcHeight_GUIContent_Single
		{
			get
			{
				if(r_RCalcHeight_GUIContent_Single == null)
				{
					r_RCalcHeight_GUIContent_Single = new(this, "CalcHeight", 0, typeof(UnityEngine.GUIContent), typeof(System.Single));
					r_RCalcHeight_GUIContent_Single.SetBelong(this.instance);
				}
				return r_RCalcHeight_GUIContent_Single;
			}
		}

		/// <summary>
		/// Void CalcMinMaxWidth(UnityEngine.GUIContent, Single ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single;
		public virtual RMethod RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single
		{
			get
			{
				if(r_RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single == null)
				{
					r_RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single = new(this, "CalcMinMaxWidth", 0, typeof(UnityEngine.GUIContent), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single.SetBelong(this.instance);
				}
				return r_RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single;
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

		/// <summary>
		/// Void get_contentOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_contentOffset_Injected_Out_Vector2;
		public virtual RMethod Rget_contentOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_contentOffset_Injected_Out_Vector2 == null)
				{
					r_Rget_contentOffset_Injected_Out_Vector2 = new(this, "get_contentOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_contentOffset_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_contentOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_contentOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_contentOffset_Injected_Ref_Vector2;
		public virtual RMethod Rset_contentOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_contentOffset_Injected_Ref_Vector2 == null)
				{
					r_Rset_contentOffset_Injected_Ref_Vector2 = new(this, "set_contentOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_contentOffset_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_contentOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_clipOffset_Injected_Out_Vector2;
		public virtual RMethod Rget_clipOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_clipOffset_Injected_Out_Vector2 == null)
				{
					r_Rget_clipOffset_Injected_Out_Vector2 = new(this, "get_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_clipOffset_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_clipOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_clipOffset_Injected_Ref_Vector2;
		public virtual RMethod Rset_clipOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_clipOffset_Injected_Ref_Vector2 == null)
				{
					r_Rset_clipOffset_Injected_Ref_Vector2 = new(this, "set_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_clipOffset_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_clipOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_Internal_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_Internal_clipOffset_Injected_Out_Vector2;
		public virtual RMethod Rget_Internal_clipOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_Internal_clipOffset_Injected_Out_Vector2 == null)
				{
					r_Rget_Internal_clipOffset_Injected_Out_Vector2 = new(this, "get_Internal_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_Internal_clipOffset_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_Internal_clipOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_Internal_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_Internal_clipOffset_Injected_Ref_Vector2;
		public virtual RMethod Rset_Internal_clipOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_Internal_clipOffset_Injected_Ref_Vector2 == null)
				{
					r_Rset_Internal_clipOffset_Injected_Ref_Vector2 = new(this, "set_Internal_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_Internal_clipOffset_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_Internal_clipOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_Draw_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "Internal_Draw_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_Draw2_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean == null)
				{
					r_RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean = new(this, "Internal_Draw2_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
					r_RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawCursor_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color;
		public virtual RMethod RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color
		{
			get
			{
				if(r_RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color == null)
				{
					r_RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color = new(this, "Internal_DrawCursor_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void Internal_DrawWithTextSelection_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color ByRef, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color;
		public virtual RMethod RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color
		{
			get
			{
				if(r_RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color == null)
				{
					r_RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color = new(this, "Internal_DrawWithTextSelection_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType());
					r_RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color.SetBelong(this.instance);
				}
				return r_RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color;
			}
		}

		/// <summary>
		/// Void Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2;
		public virtual RMethod RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2
		{
			get
			{
				if(r_RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2 == null)
				{
					r_RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2 = new(this, "Internal_GetCursorPixelPosition_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2;
			}
		}

		/// <summary>
		/// Int32 Internal_GetCursorStringIndex_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2;
		public virtual RMethod RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2
		{
			get
			{
				if(r_RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2 == null)
				{
					r_RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2 = new(this, "Internal_GetCursorStringIndex_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2;
			}
		}

		/// <summary>
		/// System.String Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, Int32)
		/// </summary>
		protected RMethod r_RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32;
		public virtual RMethod RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32
		{
			get
			{
				if(r_RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32 == null)
				{
					r_RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32 = new(this, "Internal_GetSelectedRenderedText_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32));
					r_RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] Internal_GetHyperlinksRect_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent;
		public virtual RMethod RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent
		{
			get
			{
				if(r_RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent == null)
				{
					r_RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent = new(this, "Internal_GetHyperlinksRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent));
					r_RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent.SetBelong(this.instance);
				}
				return r_RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent;
			}
		}

		/// <summary>
		/// Void Internal_CalcSize_Injected(UnityEngine.GUIContent, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RInternal_CalcSize_Injected_GUIContent_Out_Vector2;
		public virtual RMethod RInternal_CalcSize_Injected_GUIContent_Out_Vector2
		{
			get
			{
				if(r_RInternal_CalcSize_Injected_GUIContent_Out_Vector2 == null)
				{
					r_RInternal_CalcSize_Injected_GUIContent_Out_Vector2 = new(this, "Internal_CalcSize_Injected", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RInternal_CalcSize_Injected_GUIContent_Out_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_CalcSize_Injected_GUIContent_Out_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2;
		public virtual RMethod RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2
		{
			get
			{
				if(r_RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2 == null)
				{
					r_RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2 = new(this, "Internal_CalcSizeWithConstraints_Injected", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2;
		public virtual RMethod RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2
		{
			get
			{
				if(r_RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2 == null)
				{
					r_RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2 = new(this, "Internal_CalcMinMaxWidth_Injected", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2.SetBelong(this.instance);
				}
				return r_RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_DrawPrefixLabel_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean == null)
				{
					r_RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean = new(this, "Internal_DrawPrefixLabel_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
					r_RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawContent_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color ByRef, UnityEngine.Color ByRef, UnityEngine.Color ByRef, Single, Single, Single, Single, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean;
		public virtual RMethod RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean
		{
			get
			{
				if(r_RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean == null)
				{
					r_RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean = new(this, "Internal_DrawContent_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean));
					r_RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetMouseTooltip_Injected(System.String, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_RSetMouseTooltip_Injected_String_Ref_Rect;
		public static RMethod RSetMouseTooltip_Injected_String_Ref_Rect
		{
			get
			{
				if(r_RSetMouseTooltip_Injected_String_Ref_Rect == null)
				{
					r_RSetMouseTooltip_Injected_String_Ref_Rect = new(typeof(UnityEngine.GUIStyle), "SetMouseTooltip_Injected", 0, typeof(System.String), typeof(UnityEngine.Rect).MakeByRefType());
					r_RSetMouseTooltip_Injected_String_Ref_Rect.SetBelong(null);
				}
				return r_RSetMouseTooltip_Injected_String_Ref_Rect;
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


        public RGUIStyle() : base("UnityEngine.GUIStyle")
        {
        }

        public RGUIStyle(System.Object instance) : base("UnityEngine.GUIStyle")
		{
            SetInstance(instance);
		}

        public RGUIStyle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUIStyle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.IntPtr Internal_Create(UnityEngine.GUIStyle  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_Create_GUIStyle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr Internal_Copy(UnityEngine.GUIStyle  @self, UnityEngine.GUIStyle  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @other};
            var ___result = RInternal_Copy_GUIStyle_GUIStyle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void Internal_Destroy(System.IntPtr  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetStyleStatePtr(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RGetStyleStatePtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void AssignStyleState(System.Int32  @idx, System.IntPtr  @srcStyleState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @srcStyleState};
            var ___result = RAssignStyleState_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetRectOffsetPtr(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RGetRectOffsetPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void AssignRectOffset(System.Int32  @idx, System.IntPtr  @srcRectOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @srcRectOffset};
            var ___result = RAssignRectOffset_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Internal_GetLineHeight(System.IntPtr  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RInternal_GetLineHeight_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void Internal_Draw(UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Draw2(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RInternal_Draw2_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawCursor(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @pos, UnityEngine.Color  @cursorColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @pos, @cursorColor};
            var ___result = RInternal_DrawCursor_Rect_GUIContent_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawWithTextSelection(UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus, System.Boolean  @drawSelectionAsComposition, System.Int32  @cursorFirst, System.Int32  @cursorLast, UnityEngine.Color  @cursorColor, UnityEngine.Color  @selectionColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor};
            var ___result = RInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @cursorStringIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorStringIndex};
            var ___result = RInternal_GetCursorPixelPosition_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 Internal_GetCursorStringIndex(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, UnityEngine.Vector2  @cursorPixelPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorPixelPosition};
            var ___result = RInternal_GetCursorStringIndex_Rect_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String Internal_GetSelectedRenderedText(UnityEngine.Rect  @localPosition, UnityEngine.GUIContent  @mContent, System.Int32  @selectIndex, System.Int32  @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent, @selectIndex, @cursorIndex};
            var ___result = RInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect[] Internal_GetHyperlinksRect(UnityEngine.Rect  @localPosition, UnityEngine.GUIContent  @mContent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent};
            var ___result = RInternal_GetHyperlinksRect_Rect_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual System.Int32 Internal_GetNumCharactersThatFitWithinWidth(System.String  @text, System.Single  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @width};
            var ___result = RInternal_GetNumCharactersThatFitWithinWidth_String_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent  @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RInternal_CalcSize_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent  @content, UnityEngine.Vector2  @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @maxSize};
            var ___result = RInternal_CalcSizeWithConstraints_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Single Internal_CalcHeight(UnityEngine.GUIContent  @content, System.Single  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @width};
            var ___result = RInternal_CalcHeight_GUIContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent  @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RInternal_CalcMinMaxWidth_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void Internal_DrawPrefixLabel(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawContent(UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus, System.Boolean  @hasTextInput, System.Boolean  @drawSelectionAsComposition, System.Int32  @cursorFirst, System.Int32  @cursorLast, UnityEngine.Color  @cursorColor, UnityEngine.Color  @selectionColor, UnityEngine.Color  @imageColor, System.Single  @textOffsetX, System.Single  @textOffsetY, System.Single  @imageTopOffset, System.Single  @imageLeftOffset, System.Boolean  @overflowX, System.Boolean  @overflowY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @hasTextInput, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor, @imageColor, @textOffsetX, @textOffsetY, @imageTopOffset, @imageLeftOffset, @overflowX, @overflowY};
            var ___result = RInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetMouseTooltip(System.String  @tooltip, UnityEngine.Rect  @screenRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip, @screenRect};
            var ___result = RSetMouseTooltip_String_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsTooltipActive(System.String  @tooltip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip};
            var ___result = RIsTooltipActive_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single Internal_GetCursorFlashOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetCursorFlashOffset.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static void SetDefaultFont(UnityEngine.Font  @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RSetDefaultFont_Font.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static void CleanupRoots()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanupRoots.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalOnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RDraw_Rect_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, System.String  @text, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @text, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RDraw_Rect_String_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, UnityEngine.Texture  @image, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @image, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID};
            var ___result = RDraw_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RDraw_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Boolean  @on, System.Boolean  @hover)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on, @hover};
            var ___result = RDraw_Rect_GUIContent_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlId, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlId, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawPrefixLabel(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID};
            var ___result = RDrawPrefixLabel_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawCursor(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Int32  @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @character};
            var ___result = RDrawCursor_Rect_GUIContent_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWithTextSelection(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Boolean  @isActive, System.Boolean  @hasKeyboardFocus, System.Int32  @firstSelectedCharacter, System.Int32  @lastSelectedCharacter, System.Boolean  @drawSelectionAsComposition, UnityEngine.Color  @selectionColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @isActive, @hasKeyboardFocus, @firstSelectedCharacter, @lastSelectedCharacter, @drawSelectionAsComposition, @selectionColor};
            var ___result = RDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWithTextSelection(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Int32  @firstSelectedCharacter, System.Int32  @lastSelectedCharacter, System.Boolean  @drawSelectionAsComposition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @firstSelectedCharacter, @lastSelectedCharacter, @drawSelectionAsComposition};
            var ___result = RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWithTextSelection(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Int32  @firstSelectedCharacter, System.Int32  @lastSelectedCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @firstSelectedCharacter, @lastSelectedCharacter};
            var ___result = RDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GUIStyle op_Implicit(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = Rop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @cursorStringIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorStringIndex};
            var ___result = RGetCursorPixelPosition_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 GetCursorStringIndex(UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, UnityEngine.Vector2  @cursorPixelPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorPixelPosition};
            var ___result = RGetCursorStringIndex_Rect_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetNumCharactersThatFitWithinWidth(System.String  @text, System.Single  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @width};
            var ___result = RGetNumCharactersThatFitWithinWidth_String_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent  @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RCalcSize_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent  @content, UnityEngine.Vector2  @constraints)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @constraints};
            var ___result = RCalcSizeWithConstraints_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 CalcScreenSize(UnityEngine.Vector2  @contentSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentSize};
            var ___result = RCalcScreenSize_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Single CalcHeight(UnityEngine.GUIContent  @content, System.Single  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @width};
            var ___result = RCalcHeight_GUIContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void CalcMinMaxWidth(UnityEngine.GUIContent  @content, out System.Single  @minWidth, out System.Single  @maxWidth)
        {
			minWidth = default;
			maxWidth = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @minWidth, @maxWidth};
            var ___result = RCalcMinMaxWidth_GUIContent_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			minWidth = (System.Single)___parameters[1];
			maxWidth = (System.Single)___parameters[2];

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void get_contentOffset_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_contentOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_contentOffset_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_contentOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_clipOffset_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_clipOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_clipOffset_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_clipOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_Internal_clipOffset_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_Internal_clipOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_Internal_clipOffset_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_Internal_clipOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void Internal_Draw_Injected(ref UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			screenRect = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_Draw2_Injected(ref UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_DrawCursor_Injected(ref UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @pos, ref UnityEngine.Color  @cursorColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @pos, @cursorColor};
            var ___result = RInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Rect)___parameters[0];
			cursorColor = (UnityEngine.Color)___parameters[3];

            
        }


        public virtual void Internal_DrawWithTextSelection_Injected(ref UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus, System.Boolean  @drawSelectionAsComposition, System.Int32  @cursorFirst, System.Int32  @cursorLast, ref UnityEngine.Color  @cursorColor, ref UnityEngine.Color  @selectionColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor};
            var ___result = RInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color.Invoke(___genericsType, ___parameters);
			screenRect = (UnityEngine.Rect)___parameters[0];
			cursorColor = (UnityEngine.Color)___parameters[9];
			selectionColor = (UnityEngine.Color)___parameters[10];

            
        }


        public virtual void Internal_GetCursorPixelPosition_Injected(ref UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @cursorStringIndex, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorStringIndex, @ret};
            var ___result = RInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Rect)___parameters[0];
			ret = (UnityEngine.Vector2)___parameters[3];

            
        }


        public virtual System.Int32 Internal_GetCursorStringIndex_Injected(ref UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, ref UnityEngine.Vector2  @cursorPixelPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorPixelPosition};
            var ___result = RInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Rect)___parameters[0];
			cursorPixelPosition = (UnityEngine.Vector2)___parameters[2];

            return (System.Int32)___result;
        }


        public virtual System.String Internal_GetSelectedRenderedText_Injected(ref UnityEngine.Rect  @localPosition, UnityEngine.GUIContent  @mContent, System.Int32  @selectIndex, System.Int32  @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent, @selectIndex, @cursorIndex};
            var ___result = RInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32.Invoke(___genericsType, ___parameters);
			localPosition = (UnityEngine.Rect)___parameters[0];

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect[] Internal_GetHyperlinksRect_Injected(ref UnityEngine.Rect  @localPosition, UnityEngine.GUIContent  @mContent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent};
            var ___result = RInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent.Invoke(___genericsType, ___parameters);
			localPosition = (UnityEngine.Rect)___parameters[0];

            return (UnityEngine.Rect[])___result;
        }


        public virtual void Internal_CalcSize_Injected(UnityEngine.GUIContent  @content, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @ret};
            var ___result = RInternal_CalcSize_Injected_GUIContent_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent  @content, ref UnityEngine.Vector2  @maxSize, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @maxSize, @ret};
            var ___result = RInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2.Invoke(___genericsType, ___parameters);
			maxSize = (UnityEngine.Vector2)___parameters[1];
			ret = (UnityEngine.Vector2)___parameters[2];

            
        }


        public virtual void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent  @content, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @ret};
            var ___result = RInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void Internal_DrawPrefixLabel_Injected(ref UnityEngine.Rect  @position, UnityEngine.GUIContent  @content, System.Int32  @controlID, System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_DrawContent_Injected(ref UnityEngine.Rect  @screenRect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus, System.Boolean  @hasTextInput, System.Boolean  @drawSelectionAsComposition, System.Int32  @cursorFirst, System.Int32  @cursorLast, ref UnityEngine.Color  @cursorColor, ref UnityEngine.Color  @selectionColor, ref UnityEngine.Color  @imageColor, System.Single  @textOffsetX, System.Single  @textOffsetY, System.Single  @imageTopOffset, System.Single  @imageLeftOffset, System.Boolean  @overflowX, System.Boolean  @overflowY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @hasTextInput, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor, @imageColor, @textOffsetX, @textOffsetY, @imageTopOffset, @imageLeftOffset, @overflowX, @overflowY};
            var ___result = RInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			screenRect = (UnityEngine.Rect)___parameters[0];
			cursorColor = (UnityEngine.Color)___parameters[10];
			selectionColor = (UnityEngine.Color)___parameters[11];
			imageColor = (UnityEngine.Color)___parameters[12];

            
        }


        public static void SetMouseTooltip_Injected(System.String  @tooltip, ref UnityEngine.Rect  @screenRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip, @screenRect};
            var ___result = RSetMouseTooltip_Injected_String_Ref_Rect.Invoke(___genericsType, ___parameters);
			screenRect = (UnityEngine.Rect)___parameters[1];

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
