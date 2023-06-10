
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUIStyle
	/// </summary>
    public partial class RGUIStyle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.GUIStyle);
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


		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Normal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_Normal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_Normal
		{
			get
			{
				if(r_Fm_Normal == null)
				{
					r_Fm_Normal = new(this, "m_Normal");
				}
				return r_Fm_Normal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Hover
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_Hover;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_Hover
		{
			get
			{
				if(r_Fm_Hover == null)
				{
					r_Fm_Hover = new(this, "m_Hover");
				}
				return r_Fm_Hover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Active
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_Active;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_Active
		{
			get
			{
				if(r_Fm_Active == null)
				{
					r_Fm_Active = new(this, "m_Active");
				}
				return r_Fm_Active;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_Focused
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_Focused;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_Focused
		{
			get
			{
				if(r_Fm_Focused == null)
				{
					r_Fm_Focused = new(this, "m_Focused");
				}
				return r_Fm_Focused;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnNormal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_OnNormal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_OnNormal
		{
			get
			{
				if(r_Fm_OnNormal == null)
				{
					r_Fm_OnNormal = new(this, "m_OnNormal");
				}
				return r_Fm_OnNormal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnHover
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_OnHover;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_OnHover
		{
			get
			{
				if(r_Fm_OnHover == null)
				{
					r_Fm_OnHover = new(this, "m_OnHover");
				}
				return r_Fm_OnHover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnActive
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_OnActive;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_OnActive
		{
			get
			{
				if(r_Fm_OnActive == null)
				{
					r_Fm_OnActive = new(this, "m_OnActive");
				}
				return r_Fm_OnActive;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState m_OnFocused
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Fm_OnFocused;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RFm_OnFocused
		{
			get
			{
				if(r_Fm_OnFocused == null)
				{
					r_Fm_OnFocused = new(this, "m_OnFocused");
				}
				return r_Fm_OnFocused;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Border
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Fm_Border;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RFm_Border
		{
			get
			{
				if(r_Fm_Border == null)
				{
					r_Fm_Border = new(this, "m_Border");
				}
				return r_Fm_Border;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Padding
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Fm_Padding;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RFm_Padding
		{
			get
			{
				if(r_Fm_Padding == null)
				{
					r_Fm_Padding = new(this, "m_Padding");
				}
				return r_Fm_Padding;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Margin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Fm_Margin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RFm_Margin
		{
			get
			{
				if(r_Fm_Margin == null)
				{
					r_Fm_Margin = new(this, "m_Margin");
				}
				return r_Fm_Margin;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset m_Overflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Fm_Overflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RFm_Overflow
		{
			get
			{
				if(r_Fm_Overflow == null)
				{
					r_Fm_Overflow = new(this, "m_Overflow");
				}
				return r_Fm_Overflow;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// UnityEngine.DrawHandler onDraw
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RDrawHandler r_FonDraw;
		public static Hvak.Editor.Refleaction.RUnityEngine.RDrawHandler RFonDraw
		{
			get
			{
				if(r_FonDraw == null)
				{
					r_FonDraw = new(typeof(UnityEngine.GUIStyle), "onDraw");
				}
				return r_FonDraw;
			}
		}

		/// <summary>
		/// System.Int32 blockId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FblockId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFblockId
		{
			get
			{
				if(r_FblockId == null)
				{
					r_FblockId = new(this, "blockId");
				}
				return r_FblockId;
			}
		}

		/// <summary>
		/// System.Boolean showKeyboardFocus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_FshowKeyboardFocus;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFshowKeyboardFocus
		{
			get
			{
				if(r_FshowKeyboardFocus == null)
				{
					r_FshowKeyboardFocus = new(typeof(UnityEngine.GUIStyle), "showKeyboardFocus");
				}
				return r_FshowKeyboardFocus;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle s_None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_Fs_None;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RFs_None
		{
			get
			{
				if(r_Fs_None == null)
				{
					r_Fs_None = new(typeof(UnityEngine.GUIStyle), "s_None");
				}
				return r_Fs_None;
			}
		}

		/// <summary>
		/// System.String rawName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PrawName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPrawName
		{
			get
			{
				if(r_PrawName == null)
				{
					r_PrawName = new(this, "rawName", -1);
				}
				return r_PrawName;
			}
		}

		/// <summary>
		/// UnityEngine.Font font
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_Pfont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RPfont
		{
			get
			{
				if(r_Pfont == null)
				{
					r_Pfont = new(this, "font", -1);
				}
				return r_Pfont;
			}
		}

		/// <summary>
		/// UnityEngine.ImagePosition imagePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RImagePosition r_PimagePosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RImagePosition RPimagePosition
		{
			get
			{
				if(r_PimagePosition == null)
				{
					r_PimagePosition = new(this, "imagePosition", -1);
				}
				return r_PimagePosition;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor alignment
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor r_Palignment;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor RPalignment
		{
			get
			{
				if(r_Palignment == null)
				{
					r_Palignment = new(this, "alignment", -1);
				}
				return r_Palignment;
			}
		}

		/// <summary>
		/// Boolean wordWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwordWrap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwordWrap
		{
			get
			{
				if(r_PwordWrap == null)
				{
					r_PwordWrap = new(this, "wordWrap", -1);
				}
				return r_PwordWrap;
			}
		}

		/// <summary>
		/// UnityEngine.TextClipping clipping
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextClipping r_Pclipping;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextClipping RPclipping
		{
			get
			{
				if(r_Pclipping == null)
				{
					r_Pclipping = new(this, "clipping", -1);
				}
				return r_Pclipping;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 contentOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PcontentOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPcontentOffset
		{
			get
			{
				if(r_PcontentOffset == null)
				{
					r_PcontentOffset = new(this, "contentOffset", -1);
				}
				return r_PcontentOffset;
			}
		}

		/// <summary>
		/// Single fixedWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfixedWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfixedWidth
		{
			get
			{
				if(r_PfixedWidth == null)
				{
					r_PfixedWidth = new(this, "fixedWidth", -1);
				}
				return r_PfixedWidth;
			}
		}

		/// <summary>
		/// Single fixedHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfixedHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfixedHeight
		{
			get
			{
				if(r_PfixedHeight == null)
				{
					r_PfixedHeight = new(this, "fixedHeight", -1);
				}
				return r_PfixedHeight;
			}
		}

		/// <summary>
		/// Boolean stretchWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstretchWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstretchWidth
		{
			get
			{
				if(r_PstretchWidth == null)
				{
					r_PstretchWidth = new(this, "stretchWidth", -1);
				}
				return r_PstretchWidth;
			}
		}

		/// <summary>
		/// Boolean stretchHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstretchHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstretchHeight
		{
			get
			{
				if(r_PstretchHeight == null)
				{
					r_PstretchHeight = new(this, "stretchHeight", -1);
				}
				return r_PstretchHeight;
			}
		}

		/// <summary>
		/// Int32 fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PfontSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPfontSize
		{
			get
			{
				if(r_PfontSize == null)
				{
					r_PfontSize = new(this, "fontSize", -1);
				}
				return r_PfontSize;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle fontStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFontStyle r_PfontStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFontStyle RPfontStyle
		{
			get
			{
				if(r_PfontStyle == null)
				{
					r_PfontStyle = new(this, "fontStyle", -1);
				}
				return r_PfontStyle;
			}
		}

		/// <summary>
		/// Boolean richText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PrichText;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPrichText
		{
			get
			{
				if(r_PrichText == null)
				{
					r_PrichText = new(this, "richText", -1);
				}
				return r_PrichText;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 clipOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PclipOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPclipOffset
		{
			get
			{
				if(r_PclipOffset == null)
				{
					r_PclipOffset = new(this, "clipOffset", -1);
				}
				return r_PclipOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_clipOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PInternal_clipOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPInternal_clipOffset
		{
			get
			{
				if(r_PInternal_clipOffset == null)
				{
					r_PInternal_clipOffset = new(this, "Internal_clipOffset", -1);
				}
				return r_PInternal_clipOffset;
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
		/// UnityEngine.GUIStyleState normal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Pnormal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPnormal
		{
			get
			{
				if(r_Pnormal == null)
				{
					r_Pnormal = new(this, "normal", -1);
				}
				return r_Pnormal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState hover
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Phover;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPhover
		{
			get
			{
				if(r_Phover == null)
				{
					r_Phover = new(this, "hover", -1);
				}
				return r_Phover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState active
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Pactive;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPactive
		{
			get
			{
				if(r_Pactive == null)
				{
					r_Pactive = new(this, "active", -1);
				}
				return r_Pactive;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onNormal
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_PonNormal;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPonNormal
		{
			get
			{
				if(r_PonNormal == null)
				{
					r_PonNormal = new(this, "onNormal", -1);
				}
				return r_PonNormal;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onHover
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_PonHover;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPonHover
		{
			get
			{
				if(r_PonHover == null)
				{
					r_PonHover = new(this, "onHover", -1);
				}
				return r_PonHover;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onActive
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_PonActive;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPonActive
		{
			get
			{
				if(r_PonActive == null)
				{
					r_PonActive = new(this, "onActive", -1);
				}
				return r_PonActive;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState focused
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_Pfocused;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPfocused
		{
			get
			{
				if(r_Pfocused == null)
				{
					r_Pfocused = new(this, "focused", -1);
				}
				return r_Pfocused;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyleState onFocused
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState r_PonFocused;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyleState RPonFocused
		{
			get
			{
				if(r_PonFocused == null)
				{
					r_PonFocused = new(this, "onFocused", -1);
				}
				return r_PonFocused;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset border
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Pborder;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RPborder
		{
			get
			{
				if(r_Pborder == null)
				{
					r_Pborder = new(this, "border", -1);
				}
				return r_Pborder;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset margin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Pmargin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RPmargin
		{
			get
			{
				if(r_Pmargin == null)
				{
					r_Pmargin = new(this, "margin", -1);
				}
				return r_Pmargin;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset padding
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Ppadding;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RPpadding
		{
			get
			{
				if(r_Ppadding == null)
				{
					r_Ppadding = new(this, "padding", -1);
				}
				return r_Ppadding;
			}
		}

		/// <summary>
		/// UnityEngine.RectOffset overflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRectOffset r_Poverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRectOffset RPoverflow
		{
			get
			{
				if(r_Poverflow == null)
				{
					r_Poverflow = new(this, "overflow", -1);
				}
				return r_Poverflow;
			}
		}

		/// <summary>
		/// Single lineHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PlineHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPlineHeight
		{
			get
			{
				if(r_PlineHeight == null)
				{
					r_PlineHeight = new(this, "lineHeight", -1);
				}
				return r_PlineHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_Pnone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RPnone
		{
			get
			{
				if(r_Pnone == null)
				{
					r_Pnone = new(typeof(UnityEngine.GUIStyle), "none", -1);
				}
				return r_Pnone;
			}
		}

		/// <summary>
		/// Boolean isHeightDependantOnWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisHeightDependantOnWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisHeightDependantOnWidth
		{
			get
			{
				if(r_PisHeightDependantOnWidth == null)
				{
					r_PisHeightDependantOnWidth = new(this, "isHeightDependantOnWidth", -1);
				}
				return r_PisHeightDependantOnWidth;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(UnityEngine.GUIStyle)
		/// </summary>
		protected static RMethod r_MInternal_Create_GUIStyle;
		public static RMethod RMInternal_Create_GUIStyle
		{
			get
			{
				if(r_MInternal_Create_GUIStyle == null)
				{
					r_MInternal_Create_GUIStyle = new(typeof(UnityEngine.GUIStyle), "Internal_Create", 0, typeof(UnityEngine.GUIStyle));
				}
				return r_MInternal_Create_GUIStyle;
			}
		}

		/// <summary>
		/// IntPtr Internal_Copy(UnityEngine.GUIStyle, UnityEngine.GUIStyle)
		/// </summary>
		protected static RMethod r_MInternal_Copy_GUIStyle_GUIStyle;
		public static RMethod RMInternal_Copy_GUIStyle_GUIStyle
		{
			get
			{
				if(r_MInternal_Copy_GUIStyle_GUIStyle == null)
				{
					r_MInternal_Copy_GUIStyle_GUIStyle = new(typeof(UnityEngine.GUIStyle), "Internal_Copy", 0, typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle));
				}
				return r_MInternal_Copy_GUIStyle_GUIStyle;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_Destroy_IntPtr;
		public static RMethod RMInternal_Destroy_IntPtr
		{
			get
			{
				if(r_MInternal_Destroy_IntPtr == null)
				{
					r_MInternal_Destroy_IntPtr = new(typeof(UnityEngine.GUIStyle), "Internal_Destroy", 0, typeof(System.IntPtr));
				}
				return r_MInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetStyleStatePtr(Int32)
		/// </summary>
		protected RMethod r_MGetStyleStatePtr_Int32;
		public virtual RMethod RMGetStyleStatePtr_Int32
		{
			get
			{
				if(r_MGetStyleStatePtr_Int32 == null)
				{
					r_MGetStyleStatePtr_Int32 = new(this, "GetStyleStatePtr", 0, typeof(System.Int32));
				}
				return r_MGetStyleStatePtr_Int32;
			}
		}

		/// <summary>
		/// Void AssignStyleState(Int32, IntPtr)
		/// </summary>
		protected RMethod r_MAssignStyleState_Int32_IntPtr;
		public virtual RMethod RMAssignStyleState_Int32_IntPtr
		{
			get
			{
				if(r_MAssignStyleState_Int32_IntPtr == null)
				{
					r_MAssignStyleState_Int32_IntPtr = new(this, "AssignStyleState", 0, typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MAssignStyleState_Int32_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetRectOffsetPtr(Int32)
		/// </summary>
		protected RMethod r_MGetRectOffsetPtr_Int32;
		public virtual RMethod RMGetRectOffsetPtr_Int32
		{
			get
			{
				if(r_MGetRectOffsetPtr_Int32 == null)
				{
					r_MGetRectOffsetPtr_Int32 = new(this, "GetRectOffsetPtr", 0, typeof(System.Int32));
				}
				return r_MGetRectOffsetPtr_Int32;
			}
		}

		/// <summary>
		/// Void AssignRectOffset(Int32, IntPtr)
		/// </summary>
		protected RMethod r_MAssignRectOffset_Int32_IntPtr;
		public virtual RMethod RMAssignRectOffset_Int32_IntPtr
		{
			get
			{
				if(r_MAssignRectOffset_Int32_IntPtr == null)
				{
					r_MAssignRectOffset_Int32_IntPtr = new(this, "AssignRectOffset", 0, typeof(System.Int32), typeof(System.IntPtr));
				}
				return r_MAssignRectOffset_Int32_IntPtr;
			}
		}

		/// <summary>
		/// Single Internal_GetLineHeight(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_GetLineHeight_IntPtr;
		public static RMethod RMInternal_GetLineHeight_IntPtr
		{
			get
			{
				if(r_MInternal_GetLineHeight_IntPtr == null)
				{
					r_MInternal_GetLineHeight_IntPtr = new(typeof(UnityEngine.GUIStyle), "Internal_GetLineHeight", 0, typeof(System.IntPtr));
				}
				return r_MInternal_GetLineHeight_IntPtr;
			}
		}

		/// <summary>
		/// Void Internal_Draw(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "Internal_Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_Draw2(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_MInternal_Draw2_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RMInternal_Draw2_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_MInternal_Draw2_Rect_GUIContent_Int32_Boolean == null)
				{
					r_MInternal_Draw2_Rect_GUIContent_Int32_Boolean = new(this, "Internal_Draw2", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MInternal_Draw2_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawCursor(UnityEngine.Rect, UnityEngine.GUIContent, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MInternal_DrawCursor_Rect_GUIContent_Int32_Color;
		public virtual RMethod RMInternal_DrawCursor_Rect_GUIContent_Int32_Color
		{
			get
			{
				if(r_MInternal_DrawCursor_Rect_GUIContent_Int32_Color == null)
				{
					r_MInternal_DrawCursor_Rect_GUIContent_Int32_Color = new(this, "Internal_DrawCursor", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(UnityEngine.Color));
				}
				return r_MInternal_DrawCursor_Rect_GUIContent_Int32_Color;
			}
		}

		/// <summary>
		/// Void Internal_DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color;
		public virtual RMethod RMInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color
		{
			get
			{
				if(r_MInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color == null)
				{
					r_MInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color = new(this, "Internal_DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Color));
				}
				return r_MInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_MInternal_GetCursorPixelPosition_Rect_GUIContent_Int32;
		public virtual RMethod RMInternal_GetCursorPixelPosition_Rect_GUIContent_Int32
		{
			get
			{
				if(r_MInternal_GetCursorPixelPosition_Rect_GUIContent_Int32 == null)
				{
					r_MInternal_GetCursorPixelPosition_Rect_GUIContent_Int32 = new(this, "Internal_GetCursorPixelPosition", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
				}
				return r_MInternal_GetCursorPixelPosition_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_GetCursorStringIndex(UnityEngine.Rect, UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MInternal_GetCursorStringIndex_Rect_GUIContent_Vector2;
		public virtual RMethod RMInternal_GetCursorStringIndex_Rect_GUIContent_Vector2
		{
			get
			{
				if(r_MInternal_GetCursorStringIndex_Rect_GUIContent_Vector2 == null)
				{
					r_MInternal_GetCursorStringIndex_Rect_GUIContent_Vector2 = new(this, "Internal_GetCursorStringIndex", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
				}
				return r_MInternal_GetCursorStringIndex_Rect_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// System.String Internal_GetSelectedRenderedText(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32;
		public virtual RMethod RMInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32
		{
			get
			{
				if(r_MInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32 == null)
				{
					r_MInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32 = new(this, "Internal_GetSelectedRenderedText", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] Internal_GetHyperlinksRect(UnityEngine.Rect, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MInternal_GetHyperlinksRect_Rect_GUIContent;
		public virtual RMethod RMInternal_GetHyperlinksRect_Rect_GUIContent
		{
			get
			{
				if(r_MInternal_GetHyperlinksRect_Rect_GUIContent == null)
				{
					r_MInternal_GetHyperlinksRect_Rect_GUIContent = new(this, "Internal_GetHyperlinksRect", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent));
				}
				return r_MInternal_GetHyperlinksRect_Rect_GUIContent;
			}
		}

		/// <summary>
		/// Int32 Internal_GetNumCharactersThatFitWithinWidth(System.String, Single)
		/// </summary>
		protected RMethod r_MInternal_GetNumCharactersThatFitWithinWidth_String_Single;
		public virtual RMethod RMInternal_GetNumCharactersThatFitWithinWidth_String_Single
		{
			get
			{
				if(r_MInternal_GetNumCharactersThatFitWithinWidth_String_Single == null)
				{
					r_MInternal_GetNumCharactersThatFitWithinWidth_String_Single = new(this, "Internal_GetNumCharactersThatFitWithinWidth", 0, typeof(System.String), typeof(System.Single));
				}
				return r_MInternal_GetNumCharactersThatFitWithinWidth_String_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MInternal_CalcSize_GUIContent;
		public virtual RMethod RMInternal_CalcSize_GUIContent
		{
			get
			{
				if(r_MInternal_CalcSize_GUIContent == null)
				{
					r_MInternal_CalcSize_GUIContent = new(this, "Internal_CalcSize", 0, typeof(UnityEngine.GUIContent));
				}
				return r_MInternal_CalcSize_GUIContent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MInternal_CalcSizeWithConstraints_GUIContent_Vector2;
		public virtual RMethod RMInternal_CalcSizeWithConstraints_GUIContent_Vector2
		{
			get
			{
				if(r_MInternal_CalcSizeWithConstraints_GUIContent_Vector2 == null)
				{
					r_MInternal_CalcSizeWithConstraints_GUIContent_Vector2 = new(this, "Internal_CalcSizeWithConstraints", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
				}
				return r_MInternal_CalcSizeWithConstraints_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// Single Internal_CalcHeight(UnityEngine.GUIContent, Single)
		/// </summary>
		protected RMethod r_MInternal_CalcHeight_GUIContent_Single;
		public virtual RMethod RMInternal_CalcHeight_GUIContent_Single
		{
			get
			{
				if(r_MInternal_CalcHeight_GUIContent_Single == null)
				{
					r_MInternal_CalcHeight_GUIContent_Single = new(this, "Internal_CalcHeight", 0, typeof(UnityEngine.GUIContent), typeof(System.Single));
				}
				return r_MInternal_CalcHeight_GUIContent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MInternal_CalcMinMaxWidth_GUIContent;
		public virtual RMethod RMInternal_CalcMinMaxWidth_GUIContent
		{
			get
			{
				if(r_MInternal_CalcMinMaxWidth_GUIContent == null)
				{
					r_MInternal_CalcMinMaxWidth_GUIContent = new(this, "Internal_CalcMinMaxWidth", 0, typeof(UnityEngine.GUIContent));
				}
				return r_MInternal_CalcMinMaxWidth_GUIContent;
			}
		}

		/// <summary>
		/// Void Internal_DrawPrefixLabel(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_MInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RMInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_MInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean == null)
				{
					r_MInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean = new(this, "Internal_DrawPrefixLabel", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawContent(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color, UnityEngine.Color, UnityEngine.Color, Single, Single, Single, Single, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean;
		public virtual RMethod RMInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean
		{
			get
			{
				if(r_MInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean == null)
				{
					r_MInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean = new(this, "Internal_DrawContent", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetMouseTooltip(System.String, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MSetMouseTooltip_String_Rect;
		public static RMethod RMSetMouseTooltip_String_Rect
		{
			get
			{
				if(r_MSetMouseTooltip_String_Rect == null)
				{
					r_MSetMouseTooltip_String_Rect = new(typeof(UnityEngine.GUIStyle), "SetMouseTooltip", 0, typeof(System.String), typeof(UnityEngine.Rect));
				}
				return r_MSetMouseTooltip_String_Rect;
			}
		}

		/// <summary>
		/// Boolean IsTooltipActive(System.String)
		/// </summary>
		protected static RMethod r_MIsTooltipActive_String;
		public static RMethod RMIsTooltipActive_String
		{
			get
			{
				if(r_MIsTooltipActive_String == null)
				{
					r_MIsTooltipActive_String = new(typeof(UnityEngine.GUIStyle), "IsTooltipActive", 0, typeof(System.String));
				}
				return r_MIsTooltipActive_String;
			}
		}

		/// <summary>
		/// Single Internal_GetCursorFlashOffset()
		/// </summary>
		protected static RMethod r_MInternal_GetCursorFlashOffset;
		public static RMethod RMInternal_GetCursorFlashOffset
		{
			get
			{
				if(r_MInternal_GetCursorFlashOffset == null)
				{
					r_MInternal_GetCursorFlashOffset = new(typeof(UnityEngine.GUIStyle), "Internal_GetCursorFlashOffset", 0);
				}
				return r_MInternal_GetCursorFlashOffset;
			}
		}

		/// <summary>
		/// Void SetDefaultFont(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_MSetDefaultFont_Font;
		public static RMethod RMSetDefaultFont_Font
		{
			get
			{
				if(r_MSetDefaultFont_Font == null)
				{
					r_MSetDefaultFont_Font = new(typeof(UnityEngine.GUIStyle), "SetDefaultFont", 0, typeof(UnityEngine.Font));
				}
				return r_MSetDefaultFont_Font;
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
		/// Void CleanupRoots()
		/// </summary>
		protected static RMethod r_MCleanupRoots;
		public static RMethod RMCleanupRoots
		{
			get
			{
				if(r_MCleanupRoots == null)
				{
					r_MCleanupRoots = new(typeof(UnityEngine.GUIStyle), "CleanupRoots", 0);
				}
				return r_MCleanupRoots;
			}
		}

		/// <summary>
		/// Void InternalOnAfterDeserialize()
		/// </summary>
		protected RMethod r_MInternalOnAfterDeserialize;
		public virtual RMethod RMInternalOnAfterDeserialize
		{
			get
			{
				if(r_MInternalOnAfterDeserialize == null)
				{
					r_MInternalOnAfterDeserialize = new(this, "InternalOnAfterDeserialize", 0);
				}
				return r_MInternalOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDraw_Rect_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDraw_Rect_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDraw_Rect_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDraw_Rect_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, System.String, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_String_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDraw_Rect_String_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDraw_Rect_String_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDraw_Rect_String_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDraw_Rect_String_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.Texture, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_MDraw_Rect_GUIContent_Int32;
		public virtual RMethod RMDraw_Rect_GUIContent_Int32
		{
			get
			{
				if(r_MDraw_Rect_GUIContent_Int32 == null)
				{
					r_MDraw_Rect_GUIContent_Int32 = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
				}
				return r_MDraw_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RMDraw_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_MDraw_Rect_GUIContent_Int32_Boolean == null)
				{
					r_MDraw_Rect_GUIContent_Int32_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MDraw_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean;
		public virtual RMethod RMDraw_Rect_GUIContent_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean == null)
				{
					r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawPrefixLabel(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_MDrawPrefixLabel_Rect_GUIContent_Int32;
		public virtual RMethod RMDrawPrefixLabel_Rect_GUIContent_Int32
		{
			get
			{
				if(r_MDrawPrefixLabel_Rect_GUIContent_Int32 == null)
				{
					r_MDrawPrefixLabel_Rect_GUIContent_Int32 = new(this, "DrawPrefixLabel", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
				}
				return r_MDrawPrefixLabel_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Void DrawCursor(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32)
		/// </summary>
		protected RMethod r_MDrawCursor_Rect_GUIContent_Int32_Int32;
		public virtual RMethod RMDrawCursor_Rect_GUIContent_Int32_Int32
		{
			get
			{
				if(r_MDrawCursor_Rect_GUIContent_Int32_Int32 == null)
				{
					r_MDrawCursor_Rect_GUIContent_Int32_Int32 = new(this, "DrawCursor", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDrawCursor_Rect_GUIContent_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Int32, Int32, Boolean, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color;
		public virtual RMethod RMDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color
		{
			get
			{
				if(r_MDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color == null)
				{
					r_MDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color = new(this, "DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.Color));
				}
				return r_MDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color;
			}
		}

		/// <summary>
		/// Void DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean;
		public virtual RMethod RMDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean == null)
				{
					r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean = new(this, "DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void DrawWithTextSelection(UnityEngine.Rect, UnityEngine.GUIContent, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32;
		public virtual RMethod RMDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32
		{
			get
			{
				if(r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32 == null)
				{
					r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32 = new(this, "DrawWithTextSelection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Implicit_String;
		public static RMethod RMop_Implicit_String
		{
			get
			{
				if(r_Mop_Implicit_String == null)
				{
					r_Mop_Implicit_String = new(typeof(UnityEngine.GUIStyle), "op_Implicit", 0, typeof(System.String));
				}
				return r_Mop_Implicit_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect, UnityEngine.GUIContent, Int32)
		/// </summary>
		protected RMethod r_MGetCursorPixelPosition_Rect_GUIContent_Int32;
		public virtual RMethod RMGetCursorPixelPosition_Rect_GUIContent_Int32
		{
			get
			{
				if(r_MGetCursorPixelPosition_Rect_GUIContent_Int32 == null)
				{
					r_MGetCursorPixelPosition_Rect_GUIContent_Int32 = new(this, "GetCursorPixelPosition", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Int32));
				}
				return r_MGetCursorPixelPosition_Rect_GUIContent_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCursorStringIndex(UnityEngine.Rect, UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MGetCursorStringIndex_Rect_GUIContent_Vector2;
		public virtual RMethod RMGetCursorStringIndex_Rect_GUIContent_Vector2
		{
			get
			{
				if(r_MGetCursorStringIndex_Rect_GUIContent_Vector2 == null)
				{
					r_MGetCursorStringIndex_Rect_GUIContent_Vector2 = new(this, "GetCursorStringIndex", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
				}
				return r_MGetCursorStringIndex_Rect_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// Int32 GetNumCharactersThatFitWithinWidth(System.String, Single)
		/// </summary>
		protected RMethod r_MGetNumCharactersThatFitWithinWidth_String_Single;
		public virtual RMethod RMGetNumCharactersThatFitWithinWidth_String_Single
		{
			get
			{
				if(r_MGetNumCharactersThatFitWithinWidth_String_Single == null)
				{
					r_MGetNumCharactersThatFitWithinWidth_String_Single = new(this, "GetNumCharactersThatFitWithinWidth", 0, typeof(System.String), typeof(System.Single));
				}
				return r_MGetNumCharactersThatFitWithinWidth_String_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MCalcSize_GUIContent;
		public virtual RMethod RMCalcSize_GUIContent
		{
			get
			{
				if(r_MCalcSize_GUIContent == null)
				{
					r_MCalcSize_GUIContent = new(this, "CalcSize", 0, typeof(UnityEngine.GUIContent));
				}
				return r_MCalcSize_GUIContent;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MCalcSizeWithConstraints_GUIContent_Vector2;
		public virtual RMethod RMCalcSizeWithConstraints_GUIContent_Vector2
		{
			get
			{
				if(r_MCalcSizeWithConstraints_GUIContent_Vector2 == null)
				{
					r_MCalcSizeWithConstraints_GUIContent_Vector2 = new(this, "CalcSizeWithConstraints", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2));
				}
				return r_MCalcSizeWithConstraints_GUIContent_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcScreenSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MCalcScreenSize_Vector2;
		public virtual RMethod RMCalcScreenSize_Vector2
		{
			get
			{
				if(r_MCalcScreenSize_Vector2 == null)
				{
					r_MCalcScreenSize_Vector2 = new(this, "CalcScreenSize", 0, typeof(UnityEngine.Vector2));
				}
				return r_MCalcScreenSize_Vector2;
			}
		}

		/// <summary>
		/// Single CalcHeight(UnityEngine.GUIContent, Single)
		/// </summary>
		protected RMethod r_MCalcHeight_GUIContent_Single;
		public virtual RMethod RMCalcHeight_GUIContent_Single
		{
			get
			{
				if(r_MCalcHeight_GUIContent_Single == null)
				{
					r_MCalcHeight_GUIContent_Single = new(this, "CalcHeight", 0, typeof(UnityEngine.GUIContent), typeof(System.Single));
				}
				return r_MCalcHeight_GUIContent_Single;
			}
		}

		/// <summary>
		/// Void CalcMinMaxWidth(UnityEngine.GUIContent, Single ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_MCalcMinMaxWidth_GUIContent_Out_Single_Out_Single;
		public virtual RMethod RMCalcMinMaxWidth_GUIContent_Out_Single_Out_Single
		{
			get
			{
				if(r_MCalcMinMaxWidth_GUIContent_Out_Single_Out_Single == null)
				{
					r_MCalcMinMaxWidth_GUIContent_Out_Single_Out_Single = new(this, "CalcMinMaxWidth", 0, typeof(UnityEngine.GUIContent), typeof(System.Single).MakeByRefType(), typeof(System.Single).MakeByRefType());
				}
				return r_MCalcMinMaxWidth_GUIContent_Out_Single_Out_Single;
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

		/// <summary>
		/// Void get_contentOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_contentOffset_Injected_Out_Vector2;
		public virtual RMethod RMget_contentOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_contentOffset_Injected_Out_Vector2 == null)
				{
					r_Mget_contentOffset_Injected_Out_Vector2 = new(this, "get_contentOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_contentOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_contentOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_contentOffset_Injected_Ref_Vector2;
		public virtual RMethod RMset_contentOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_contentOffset_Injected_Ref_Vector2 == null)
				{
					r_Mset_contentOffset_Injected_Ref_Vector2 = new(this, "set_contentOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_contentOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_clipOffset_Injected_Out_Vector2;
		public virtual RMethod RMget_clipOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_clipOffset_Injected_Out_Vector2 == null)
				{
					r_Mget_clipOffset_Injected_Out_Vector2 = new(this, "get_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_clipOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_clipOffset_Injected_Ref_Vector2;
		public virtual RMethod RMset_clipOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_clipOffset_Injected_Ref_Vector2 == null)
				{
					r_Mset_clipOffset_Injected_Ref_Vector2 = new(this, "set_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_clipOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_Internal_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_Internal_clipOffset_Injected_Out_Vector2;
		public virtual RMethod RMget_Internal_clipOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_Internal_clipOffset_Injected_Out_Vector2 == null)
				{
					r_Mget_Internal_clipOffset_Injected_Out_Vector2 = new(this, "get_Internal_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_Internal_clipOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_Internal_clipOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_Internal_clipOffset_Injected_Ref_Vector2;
		public virtual RMethod RMset_Internal_clipOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_Internal_clipOffset_Injected_Ref_Vector2 == null)
				{
					r_Mset_Internal_clipOffset_Injected_Ref_Vector2 = new(this, "set_Internal_clipOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_Internal_clipOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_Draw_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "Internal_Draw_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_Draw2_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_MInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RMInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_MInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean == null)
				{
					r_MInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean = new(this, "Internal_Draw2_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawCursor_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color;
		public virtual RMethod RMInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color
		{
			get
			{
				if(r_MInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color == null)
				{
					r_MInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color = new(this, "Internal_DrawCursor_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_MInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void Internal_DrawWithTextSelection_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color ByRef, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color;
		public virtual RMethod RMInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color
		{
			get
			{
				if(r_MInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color == null)
				{
					r_MInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color = new(this, "Internal_DrawWithTextSelection_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_MInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color;
			}
		}

		/// <summary>
		/// Void Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2;
		public virtual RMethod RMInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2
		{
			get
			{
				if(r_MInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2 == null)
				{
					r_MInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2 = new(this, "Internal_GetCursorPixelPosition_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2;
			}
		}

		/// <summary>
		/// Int32 Internal_GetCursorStringIndex_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2;
		public virtual RMethod RMInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2
		{
			get
			{
				if(r_MInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2 == null)
				{
					r_MInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2 = new(this, "Internal_GetCursorStringIndex_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2;
			}
		}

		/// <summary>
		/// System.String Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, Int32)
		/// </summary>
		protected RMethod r_MInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32;
		public virtual RMethod RMInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32
		{
			get
			{
				if(r_MInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32 == null)
				{
					r_MInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32 = new(this, "Internal_GetSelectedRenderedText_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] Internal_GetHyperlinksRect_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent;
		public virtual RMethod RMInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent
		{
			get
			{
				if(r_MInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent == null)
				{
					r_MInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent = new(this, "Internal_GetHyperlinksRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent));
				}
				return r_MInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent;
			}
		}

		/// <summary>
		/// Void Internal_CalcSize_Injected(UnityEngine.GUIContent, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_CalcSize_Injected_GUIContent_Out_Vector2;
		public virtual RMethod RMInternal_CalcSize_Injected_GUIContent_Out_Vector2
		{
			get
			{
				if(r_MInternal_CalcSize_Injected_GUIContent_Out_Vector2 == null)
				{
					r_MInternal_CalcSize_Injected_GUIContent_Out_Vector2 = new(this, "Internal_CalcSize_Injected", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MInternal_CalcSize_Injected_GUIContent_Out_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent, UnityEngine.Vector2 ByRef, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2;
		public virtual RMethod RMInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2
		{
			get
			{
				if(r_MInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2 == null)
				{
					r_MInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2 = new(this, "Internal_CalcSizeWithConstraints_Injected", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_MInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2;
		public virtual RMethod RMInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2
		{
			get
			{
				if(r_MInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2 == null)
				{
					r_MInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2 = new(this, "Internal_CalcMinMaxWidth_Injected", 0, typeof(UnityEngine.GUIContent), typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_MInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2;
			}
		}

		/// <summary>
		/// Void Internal_DrawPrefixLabel_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Int32, Boolean)
		/// </summary>
		protected RMethod r_MInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean;
		public virtual RMethod RMInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean
		{
			get
			{
				if(r_MInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean == null)
				{
					r_MInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean = new(this, "Internal_DrawPrefixLabel_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_DrawContent_Injected(UnityEngine.Rect ByRef, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Int32, Int32, UnityEngine.Color ByRef, UnityEngine.Color ByRef, UnityEngine.Color ByRef, Single, Single, Single, Single, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean;
		public virtual RMethod RMInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean
		{
			get
			{
				if(r_MInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean == null)
				{
					r_MInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean = new(this, "Internal_DrawContent_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetMouseTooltip_Injected(System.String, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MSetMouseTooltip_Injected_String_Ref_Rect;
		public static RMethod RMSetMouseTooltip_Injected_String_Ref_Rect
		{
			get
			{
				if(r_MSetMouseTooltip_Injected_String_Ref_Rect == null)
				{
					r_MSetMouseTooltip_Injected_String_Ref_Rect = new(typeof(UnityEngine.GUIStyle), "SetMouseTooltip_Injected", 0, typeof(System.String), typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MSetMouseTooltip_Injected_String_Ref_Rect;
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


        public static System.IntPtr Internal_Create(UnityEngine.GUIStyle @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_Create_GUIStyle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr Internal_Copy(UnityEngine.GUIStyle @self, UnityEngine.GUIStyle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @other};
            var ___result = RMInternal_Copy_GUIStyle_GUIStyle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void Internal_Destroy(System.IntPtr @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetStyleStatePtr(System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RMGetStyleStatePtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void AssignStyleState(System.Int32 @idx, System.IntPtr @srcStyleState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @srcStyleState};
            var ___result = RMAssignStyleState_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetRectOffsetPtr(System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RMGetRectOffsetPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void AssignRectOffset(System.Int32 @idx, System.IntPtr @srcRectOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @srcRectOffset};
            var ___result = RMAssignRectOffset_Int32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Internal_GetLineHeight(System.IntPtr @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMInternal_GetLineHeight_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void Internal_Draw(UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMInternal_Draw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_Draw2(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RMInternal_Draw2_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawCursor(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @pos, UnityEngine.Color @cursorColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @pos, @cursorColor};
            var ___result = RMInternal_DrawCursor_Rect_GUIContent_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawWithTextSelection(UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus, System.Boolean @drawSelectionAsComposition, System.Int32 @cursorFirst, System.Int32 @cursorLast, UnityEngine.Color @cursorColor, UnityEngine.Color @selectionColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor};
            var ___result = RMInternal_DrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @cursorStringIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorStringIndex};
            var ___result = RMInternal_GetCursorPixelPosition_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 Internal_GetCursorStringIndex(UnityEngine.Rect @position, UnityEngine.GUIContent @content, UnityEngine.Vector2 @cursorPixelPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorPixelPosition};
            var ___result = RMInternal_GetCursorStringIndex_Rect_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String Internal_GetSelectedRenderedText(UnityEngine.Rect @localPosition, UnityEngine.GUIContent @mContent, System.Int32 @selectIndex, System.Int32 @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent, @selectIndex, @cursorIndex};
            var ___result = RMInternal_GetSelectedRenderedText_Rect_GUIContent_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect[] Internal_GetHyperlinksRect(UnityEngine.Rect @localPosition, UnityEngine.GUIContent @mContent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent};
            var ___result = RMInternal_GetHyperlinksRect_Rect_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual System.Int32 Internal_GetNumCharactersThatFitWithinWidth(System.String @text, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @width};
            var ___result = RMInternal_GetNumCharactersThatFitWithinWidth_String_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RMInternal_CalcSize_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent @content, UnityEngine.Vector2 @maxSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @maxSize};
            var ___result = RMInternal_CalcSizeWithConstraints_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Single Internal_CalcHeight(UnityEngine.GUIContent @content, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @width};
            var ___result = RMInternal_CalcHeight_GUIContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RMInternal_CalcMinMaxWidth_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void Internal_DrawPrefixLabel(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RMInternal_DrawPrefixLabel_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_DrawContent(UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus, System.Boolean @hasTextInput, System.Boolean @drawSelectionAsComposition, System.Int32 @cursorFirst, System.Int32 @cursorLast, UnityEngine.Color @cursorColor, UnityEngine.Color @selectionColor, UnityEngine.Color @imageColor, System.Single @textOffsetX, System.Single @textOffsetY, System.Single @imageTopOffset, System.Single @imageLeftOffset, System.Boolean @overflowX, System.Boolean @overflowY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @hasTextInput, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor, @imageColor, @textOffsetX, @textOffsetY, @imageTopOffset, @imageLeftOffset, @overflowX, @overflowY};
            var ___result = RMInternal_DrawContent_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Color_Color_Color_Single_Single_Single_Single_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetMouseTooltip(System.String @tooltip, UnityEngine.Rect @screenRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip, @screenRect};
            var ___result = RMSetMouseTooltip_String_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsTooltipActive(System.String @tooltip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip};
            var ___result = RMIsTooltipActive_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single Internal_GetCursorFlashOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_GetCursorFlashOffset.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static void SetDefaultFont(UnityEngine.Font @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@font};
            var ___result = RMSetDefaultFont_Font.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static void CleanupRoots()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanupRoots.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalOnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMDraw_Rect_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, System.String @text, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @text, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMDraw_Rect_String_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, UnityEngine.Texture @image, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @image, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMDraw_Rect_Texture_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMDraw_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID};
            var ___result = RMDraw_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RMDraw_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Boolean @on, System.Boolean @hover)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on, @hover};
            var ___result = RMDraw_Rect_GUIContent_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Draw(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlId, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlId, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMDraw_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawPrefixLabel(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID};
            var ___result = RMDrawPrefixLabel_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawCursor(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Int32 @character)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @character};
            var ___result = RMDrawCursor_Rect_GUIContent_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWithTextSelection(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Boolean @isActive, System.Boolean @hasKeyboardFocus, System.Int32 @firstSelectedCharacter, System.Int32 @lastSelectedCharacter, System.Boolean @drawSelectionAsComposition, UnityEngine.Color @selectionColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @isActive, @hasKeyboardFocus, @firstSelectedCharacter, @lastSelectedCharacter, @drawSelectionAsComposition, @selectionColor};
            var ___result = RMDrawWithTextSelection_Rect_GUIContent_Boolean_Boolean_Int32_Int32_Boolean_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWithTextSelection(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Int32 @firstSelectedCharacter, System.Int32 @lastSelectedCharacter, System.Boolean @drawSelectionAsComposition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @firstSelectedCharacter, @lastSelectedCharacter, @drawSelectionAsComposition};
            var ___result = RMDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWithTextSelection(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Int32 @firstSelectedCharacter, System.Int32 @lastSelectedCharacter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @firstSelectedCharacter, @lastSelectedCharacter};
            var ___result = RMDrawWithTextSelection_Rect_GUIContent_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GUIStyle op_Implicit(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @cursorStringIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorStringIndex};
            var ___result = RMGetCursorPixelPosition_Rect_GUIContent_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 GetCursorStringIndex(UnityEngine.Rect @position, UnityEngine.GUIContent @content, UnityEngine.Vector2 @cursorPixelPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorPixelPosition};
            var ___result = RMGetCursorStringIndex_Rect_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetNumCharactersThatFitWithinWidth(System.String @text, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @width};
            var ___result = RMGetNumCharactersThatFitWithinWidth_String_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RMCalcSize_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent @content, UnityEngine.Vector2 @constraints)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @constraints};
            var ___result = RMCalcSizeWithConstraints_GUIContent_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 CalcScreenSize(UnityEngine.Vector2 @contentSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentSize};
            var ___result = RMCalcScreenSize_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Single CalcHeight(UnityEngine.GUIContent @content, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @width};
            var ___result = RMCalcHeight_GUIContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void CalcMinMaxWidth(UnityEngine.GUIContent @content, out System.Single @minWidth, out System.Single @maxWidth)
        {
			@minWidth = default;
			@maxWidth = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @minWidth, @maxWidth};
            var ___result = RMCalcMinMaxWidth_GUIContent_Out_Single_Out_Single.Invoke(___genericsType, ___parameters);
			@minWidth = (System.Single)___parameters[1];
			@maxWidth = (System.Single)___parameters[2];

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void get_contentOffset_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_contentOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_contentOffset_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_contentOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_clipOffset_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_clipOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_clipOffset_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_clipOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_Internal_clipOffset_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_Internal_clipOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_Internal_clipOffset_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_Internal_clipOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void Internal_Draw_Injected(ref UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMInternal_Draw_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@screenRect = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_Draw2_Injected(ref UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RMInternal_Draw2_Injected_Ref_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_DrawCursor_Injected(ref UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @pos, ref UnityEngine.Color @cursorColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @pos, @cursorColor};
            var ___result = RMInternal_DrawCursor_Injected_Ref_Rect_GUIContent_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Rect)___parameters[0];
			@cursorColor = (UnityEngine.Color)___parameters[3];

            
        }


        public virtual void Internal_DrawWithTextSelection_Injected(ref UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus, System.Boolean @drawSelectionAsComposition, System.Int32 @cursorFirst, System.Int32 @cursorLast, ref UnityEngine.Color @cursorColor, ref UnityEngine.Color @selectionColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor};
            var ___result = RMInternal_DrawWithTextSelection_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color.Invoke(___genericsType, ___parameters);
			@screenRect = (UnityEngine.Rect)___parameters[0];
			@cursorColor = (UnityEngine.Color)___parameters[9];
			@selectionColor = (UnityEngine.Color)___parameters[10];

            
        }


        public virtual void Internal_GetCursorPixelPosition_Injected(ref UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @cursorStringIndex, out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorStringIndex, @ret};
            var ___result = RMInternal_GetCursorPixelPosition_Injected_Ref_Rect_GUIContent_Int32_Out_Vector2.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Rect)___parameters[0];
			@ret = (UnityEngine.Vector2)___parameters[3];

            
        }


        public virtual System.Int32 Internal_GetCursorStringIndex_Injected(ref UnityEngine.Rect @position, UnityEngine.GUIContent @content, ref UnityEngine.Vector2 @cursorPixelPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @cursorPixelPosition};
            var ___result = RMInternal_GetCursorStringIndex_Injected_Ref_Rect_GUIContent_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Rect)___parameters[0];
			@cursorPixelPosition = (UnityEngine.Vector2)___parameters[2];

            return (System.Int32)___result;
        }


        public virtual System.String Internal_GetSelectedRenderedText_Injected(ref UnityEngine.Rect @localPosition, UnityEngine.GUIContent @mContent, System.Int32 @selectIndex, System.Int32 @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent, @selectIndex, @cursorIndex};
            var ___result = RMInternal_GetSelectedRenderedText_Injected_Ref_Rect_GUIContent_Int32_Int32.Invoke(___genericsType, ___parameters);
			@localPosition = (UnityEngine.Rect)___parameters[0];

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect[] Internal_GetHyperlinksRect_Injected(ref UnityEngine.Rect @localPosition, UnityEngine.GUIContent @mContent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPosition, @mContent};
            var ___result = RMInternal_GetHyperlinksRect_Injected_Ref_Rect_GUIContent.Invoke(___genericsType, ___parameters);
			@localPosition = (UnityEngine.Rect)___parameters[0];

            return (UnityEngine.Rect[])___result;
        }


        public virtual void Internal_CalcSize_Injected(UnityEngine.GUIContent @content, out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @ret};
            var ___result = RMInternal_CalcSize_Injected_GUIContent_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent @content, ref UnityEngine.Vector2 @maxSize, out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @maxSize, @ret};
            var ___result = RMInternal_CalcSizeWithConstraints_Injected_GUIContent_Ref_Vector2_Out_Vector2.Invoke(___genericsType, ___parameters);
			@maxSize = (UnityEngine.Vector2)___parameters[1];
			@ret = (UnityEngine.Vector2)___parameters[2];

            
        }


        public virtual void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent @content, out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @ret};
            var ___result = RMInternal_CalcMinMaxWidth_Injected_GUIContent_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[1];

            
        }


        public virtual void Internal_DrawPrefixLabel_Injected(ref UnityEngine.Rect @position, UnityEngine.GUIContent @content, System.Int32 @controlID, System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @content, @controlID, @on};
            var ___result = RMInternal_DrawPrefixLabel_Injected_Ref_Rect_GUIContent_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@position = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void Internal_DrawContent_Injected(ref UnityEngine.Rect @screenRect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus, System.Boolean @hasTextInput, System.Boolean @drawSelectionAsComposition, System.Int32 @cursorFirst, System.Int32 @cursorLast, ref UnityEngine.Color @cursorColor, ref UnityEngine.Color @selectionColor, ref UnityEngine.Color @imageColor, System.Single @textOffsetX, System.Single @textOffsetY, System.Single @imageTopOffset, System.Single @imageLeftOffset, System.Boolean @overflowX, System.Boolean @overflowY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenRect, @content, @isHover, @isActive, @on, @hasKeyboardFocus, @hasTextInput, @drawSelectionAsComposition, @cursorFirst, @cursorLast, @cursorColor, @selectionColor, @imageColor, @textOffsetX, @textOffsetY, @imageTopOffset, @imageLeftOffset, @overflowX, @overflowY};
            var ___result = RMInternal_DrawContent_Injected_Ref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Ref_Color_Ref_Color_Ref_Color_Single_Single_Single_Single_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@screenRect = (UnityEngine.Rect)___parameters[0];
			@cursorColor = (UnityEngine.Color)___parameters[10];
			@selectionColor = (UnityEngine.Color)___parameters[11];
			@imageColor = (UnityEngine.Color)___parameters[12];

            
        }


        public static void SetMouseTooltip_Injected(System.String @tooltip, ref UnityEngine.Rect @screenRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tooltip, @screenRect};
            var ___result = RMSetMouseTooltip_Injected_String_Ref_Rect.Invoke(___genericsType, ___parameters);
			@screenRect = (UnityEngine.Rect)___parameters[1];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
