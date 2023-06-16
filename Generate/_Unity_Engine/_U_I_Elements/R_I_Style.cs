
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IStyle
	/// </summary>
    public partial class RIStyle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IStyle);
            }
        }

        public RIStyle() : base("UnityEngine.UIElements.IStyle")
        {
        }

        public RIStyle(System.Object instance) : base("UnityEngine.UIElements.IStyle")
		{
            SetInstance(instance);
		}

        public RIStyle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIStyle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> r_PalignContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> RPalignContent
		{
			get
			{
				if(r_PalignContent == null)
				{
					r_PalignContent = new(this, "alignContent", -1);
				}
				return r_PalignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> r_PalignItems;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> RPalignItems
		{
			get
			{
				if(r_PalignItems == null)
				{
					r_PalignItems = new(this, "alignItems", -1);
				}
				return r_PalignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> r_PalignSelf;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign> RPalignSelf
		{
			get
			{
				if(r_PalignSelf == null)
				{
					r_PalignSelf = new(this, "alignSelf", -1);
				}
				return r_PalignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PbackgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPbackgroundColor
		{
			get
			{
				if(r_PbackgroundColor == null)
				{
					r_PbackgroundColor = new(this, "backgroundColor", -1);
				}
				return r_PbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground backgroundImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackground r_PbackgroundImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackground RPbackgroundImage
		{
			get
			{
				if(r_PbackgroundImage == null)
				{
					r_PbackgroundImage = new(this, "backgroundImage", -1);
				}
				return r_PbackgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition backgroundPositionX
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition r_PbackgroundPositionX;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition RPbackgroundPositionX
		{
			get
			{
				if(r_PbackgroundPositionX == null)
				{
					r_PbackgroundPositionX = new(this, "backgroundPositionX", -1);
				}
				return r_PbackgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition backgroundPositionY
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition r_PbackgroundPositionY;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundPosition RPbackgroundPositionY
		{
			get
			{
				if(r_PbackgroundPositionY == null)
				{
					r_PbackgroundPositionY = new(this, "backgroundPositionY", -1);
				}
				return r_PbackgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat backgroundRepeat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundRepeat r_PbackgroundRepeat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundRepeat RPbackgroundRepeat
		{
			get
			{
				if(r_PbackgroundRepeat == null)
				{
					r_PbackgroundRepeat = new(this, "backgroundRepeat", -1);
				}
				return r_PbackgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize backgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundSize r_PbackgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleBackgroundSize RPbackgroundSize
		{
			get
			{
				if(r_PbackgroundSize == null)
				{
					r_PbackgroundSize = new(this, "backgroundSize", -1);
				}
				return r_PbackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderBottomColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PborderBottomColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPborderBottomColor
		{
			get
			{
				if(r_PborderBottomColor == null)
				{
					r_PborderBottomColor = new(this, "borderBottomColor", -1);
				}
				return r_PborderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderBottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PborderBottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPborderBottomLeftRadius
		{
			get
			{
				if(r_PborderBottomLeftRadius == null)
				{
					r_PborderBottomLeftRadius = new(this, "borderBottomLeftRadius", -1);
				}
				return r_PborderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderBottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PborderBottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPborderBottomRightRadius
		{
			get
			{
				if(r_PborderBottomRightRadius == null)
				{
					r_PborderBottomRightRadius = new(this, "borderBottomRightRadius", -1);
				}
				return r_PborderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderBottomWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PborderBottomWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPborderBottomWidth
		{
			get
			{
				if(r_PborderBottomWidth == null)
				{
					r_PborderBottomWidth = new(this, "borderBottomWidth", -1);
				}
				return r_PborderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderLeftColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PborderLeftColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPborderLeftColor
		{
			get
			{
				if(r_PborderLeftColor == null)
				{
					r_PborderLeftColor = new(this, "borderLeftColor", -1);
				}
				return r_PborderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderLeftWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PborderLeftWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPborderLeftWidth
		{
			get
			{
				if(r_PborderLeftWidth == null)
				{
					r_PborderLeftWidth = new(this, "borderLeftWidth", -1);
				}
				return r_PborderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderRightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PborderRightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPborderRightColor
		{
			get
			{
				if(r_PborderRightColor == null)
				{
					r_PborderRightColor = new(this, "borderRightColor", -1);
				}
				return r_PborderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderRightWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PborderRightWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPborderRightWidth
		{
			get
			{
				if(r_PborderRightWidth == null)
				{
					r_PborderRightWidth = new(this, "borderRightWidth", -1);
				}
				return r_PborderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderTopColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PborderTopColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPborderTopColor
		{
			get
			{
				if(r_PborderTopColor == null)
				{
					r_PborderTopColor = new(this, "borderTopColor", -1);
				}
				return r_PborderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderTopLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PborderTopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPborderTopLeftRadius
		{
			get
			{
				if(r_PborderTopLeftRadius == null)
				{
					r_PborderTopLeftRadius = new(this, "borderTopLeftRadius", -1);
				}
				return r_PborderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderTopRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PborderTopRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPborderTopRightRadius
		{
			get
			{
				if(r_PborderTopRightRadius == null)
				{
					r_PborderTopRightRadius = new(this, "borderTopRightRadius", -1);
				}
				return r_PborderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderTopWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PborderTopWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPborderTopWidth
		{
			get
			{
				if(r_PborderTopWidth == null)
				{
					r_PborderTopWidth = new(this, "borderTopWidth", -1);
				}
				return r_PborderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_Pbottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_Pcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPcolor
		{
			get
			{
				if(r_Pcolor == null)
				{
					r_Pcolor = new(this, "color", -1);
				}
				return r_Pcolor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor cursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleCursor r_Pcursor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleCursor RPcursor
		{
			get
			{
				if(r_Pcursor == null)
				{
					r_Pcursor = new(this, "cursor", -1);
				}
				return r_Pcursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.DisplayStyle] display
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle> r_Pdisplay;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle> RPdisplay
		{
			get
			{
				if(r_Pdisplay == null)
				{
					r_Pdisplay = new(this, "display", -1);
				}
				return r_Pdisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength flexBasis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PflexBasis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPflexBasis
		{
			get
			{
				if(r_PflexBasis == null)
				{
					r_PflexBasis = new(this, "flexBasis", -1);
				}
				return r_PflexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.FlexDirection] flexDirection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection> r_PflexDirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection> RPflexDirection
		{
			get
			{
				if(r_PflexDirection == null)
				{
					r_PflexDirection = new(this, "flexDirection", -1);
				}
				return r_PflexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexGrow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PflexGrow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPflexGrow
		{
			get
			{
				if(r_PflexGrow == null)
				{
					r_PflexGrow = new(this, "flexGrow", -1);
				}
				return r_PflexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexShrink
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PflexShrink;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPflexShrink
		{
			get
			{
				if(r_PflexShrink == null)
				{
					r_PflexShrink = new(this, "flexShrink", -1);
				}
				return r_PflexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Wrap] flexWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap> r_PflexWrap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap> RPflexWrap
		{
			get
			{
				if(r_PflexWrap == null)
				{
					r_PflexWrap = new(this, "flexWrap", -1);
				}
				return r_PflexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PfontSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPfontSize
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
		/// UnityEngine.UIElements.StyleLength height
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_Pheight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Justify] justifyContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify> r_PjustifyContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify> RPjustifyContent
		{
			get
			{
				if(r_PjustifyContent == null)
				{
					r_PjustifyContent = new(this, "justifyContent", -1);
				}
				return r_PjustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength left
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_Pleft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength letterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PletterSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPletterSpacing
		{
			get
			{
				if(r_PletterSpacing == null)
				{
					r_PletterSpacing = new(this, "letterSpacing", -1);
				}
				return r_PletterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PmarginBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PmarginLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PmarginRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PmarginTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PmaxHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPmaxHeight
		{
			get
			{
				if(r_PmaxHeight == null)
				{
					r_PmaxHeight = new(this, "maxHeight", -1);
				}
				return r_PmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PmaxWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPmaxWidth
		{
			get
			{
				if(r_PmaxWidth == null)
				{
					r_PmaxWidth = new(this, "maxWidth", -1);
				}
				return r_PmaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PminHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPminHeight
		{
			get
			{
				if(r_PminHeight == null)
				{
					r_PminHeight = new(this, "minHeight", -1);
				}
				return r_PminHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PminWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPminWidth
		{
			get
			{
				if(r_PminWidth == null)
				{
					r_PminWidth = new(this, "minWidth", -1);
				}
				return r_PminWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_Popacity;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Overflow] overflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflow> r_Poverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflow> RPoverflow
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
		/// UnityEngine.UIElements.StyleLength paddingBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PpaddingBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPpaddingBottom
		{
			get
			{
				if(r_PpaddingBottom == null)
				{
					r_PpaddingBottom = new(this, "paddingBottom", -1);
				}
				return r_PpaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PpaddingLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPpaddingLeft
		{
			get
			{
				if(r_PpaddingLeft == null)
				{
					r_PpaddingLeft = new(this, "paddingLeft", -1);
				}
				return r_PpaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PpaddingRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPpaddingRight
		{
			get
			{
				if(r_PpaddingRight == null)
				{
					r_PpaddingRight = new(this, "paddingRight", -1);
				}
				return r_PpaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PpaddingTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPpaddingTop
		{
			get
			{
				if(r_PpaddingTop == null)
				{
					r_PpaddingTop = new(this, "paddingTop", -1);
				}
				return r_PpaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Position] position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition> r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition> RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength right
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_Pright;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate rotate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRotate r_Protate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRotate RProtate
		{
			get
			{
				if(r_Protate == null)
				{
					r_Protate = new(this, "rotate", -1);
				}
				return r_Protate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleScale r_Pscale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleScale RPscale
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
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflow] textOverflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow> r_PtextOverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow> RPtextOverflow
		{
			get
			{
				if(r_PtextOverflow == null)
				{
					r_PtextOverflow = new(this, "textOverflow", -1);
				}
				return r_PtextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow textShadow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTextShadow r_PtextShadow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTextShadow RPtextShadow
		{
			get
			{
				if(r_PtextShadow == null)
				{
					r_PtextShadow = new(this, "textShadow", -1);
				}
				return r_PtextShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength top
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_Ptop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin transformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTransformOrigin r_PtransformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTransformOrigin RPtransformOrigin
		{
			get
			{
				if(r_PtransformOrigin == null)
				{
					r_PtransformOrigin = new(this, "transformOrigin", -1);
				}
				return r_PtransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PtransitionDelay;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPtransitionDelay
		{
			get
			{
				if(r_PtransitionDelay == null)
				{
					r_PtransitionDelay = new(this, "transitionDelay", -1);
				}
				return r_PtransitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PtransitionDuration;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPtransitionDuration
		{
			get
			{
				if(r_PtransitionDuration == null)
				{
					r_PtransitionDuration = new(this, "transitionDuration", -1);
				}
				return r_PtransitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> r_PtransitionProperty;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> RPtransitionProperty
		{
			get
			{
				if(r_PtransitionProperty == null)
				{
					r_PtransitionProperty = new(this, "transitionProperty", -1);
				}
				return r_PtransitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> r_PtransitionTimingFunction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> RPtransitionTimingFunction
		{
			get
			{
				if(r_PtransitionTimingFunction == null)
				{
					r_PtransitionTimingFunction = new(this, "transitionTimingFunction", -1);
				}
				return r_PtransitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate translate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTranslate r_Ptranslate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleTranslate RPtranslate
		{
			get
			{
				if(r_Ptranslate == null)
				{
					r_Ptranslate = new(this, "translate", -1);
				}
				return r_Ptranslate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor unityBackgroundImageTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PunityBackgroundImageTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPunityBackgroundImageTintColor
		{
			get
			{
				if(r_PunityBackgroundImageTintColor == null)
				{
					r_PunityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor", -1);
				}
				return r_PunityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont unityFont
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFont r_PunityFont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFont RPunityFont
		{
			get
			{
				if(r_PunityFont == null)
				{
					r_PunityFont = new(this, "unityFont", -1);
				}
				return r_PunityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition unityFontDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFontDefinition r_PunityFontDefinition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFontDefinition RPunityFontDefinition
		{
			get
			{
				if(r_PunityFontDefinition == null)
				{
					r_PunityFontDefinition = new(this, "unityFontDefinition", -1);
				}
				return r_PunityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.FontStyle] unityFontStyleAndWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RFontStyle> r_PunityFontStyleAndWeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RFontStyle> RPunityFontStyleAndWeight
		{
			get
			{
				if(r_PunityFontStyleAndWeight == null)
				{
					r_PunityFontStyleAndWeight = new(this, "unityFontStyleAndWeight", -1);
				}
				return r_PunityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.OverflowClipBox] unityOverflowClipBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox> r_PunityOverflowClipBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox> RPunityOverflowClipBox
		{
			get
			{
				if(r_PunityOverflowClipBox == null)
				{
					r_PunityOverflowClipBox = new(this, "unityOverflowClipBox", -1);
				}
				return r_PunityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength unityParagraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PunityParagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPunityParagraphSpacing
		{
			get
			{
				if(r_PunityParagraphSpacing == null)
				{
					r_PunityParagraphSpacing = new(this, "unityParagraphSpacing", -1);
				}
				return r_PunityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PunitySliceBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPunitySliceBottom
		{
			get
			{
				if(r_PunitySliceBottom == null)
				{
					r_PunitySliceBottom = new(this, "unitySliceBottom", -1);
				}
				return r_PunitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PunitySliceLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPunitySliceLeft
		{
			get
			{
				if(r_PunitySliceLeft == null)
				{
					r_PunitySliceLeft = new(this, "unitySliceLeft", -1);
				}
				return r_PunitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PunitySliceRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPunitySliceRight
		{
			get
			{
				if(r_PunitySliceRight == null)
				{
					r_PunitySliceRight = new(this, "unitySliceRight", -1);
				}
				return r_PunitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat unitySliceScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PunitySliceScale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPunitySliceScale
		{
			get
			{
				if(r_PunitySliceScale == null)
				{
					r_PunitySliceScale = new(this, "unitySliceScale", -1);
				}
				return r_PunitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt r_PunitySliceTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleInt RPunitySliceTop
		{
			get
			{
				if(r_PunitySliceTop == null)
				{
					r_PunitySliceTop = new(this, "unitySliceTop", -1);
				}
				return r_PunitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.TextAnchor] unityTextAlign
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor> r_PunityTextAlign;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor> RPunityTextAlign
		{
			get
			{
				if(r_PunityTextAlign == null)
				{
					r_PunityTextAlign = new(this, "unityTextAlign", -1);
				}
				return r_PunityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor unityTextOutlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor r_PunityTextOutlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleColor RPunityTextOutlineColor
		{
			get
			{
				if(r_PunityTextOutlineColor == null)
				{
					r_PunityTextOutlineColor = new(this, "unityTextOutlineColor", -1);
				}
				return r_PunityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat unityTextOutlineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PunityTextOutlineWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPunityTextOutlineWidth
		{
			get
			{
				if(r_PunityTextOutlineWidth == null)
				{
					r_PunityTextOutlineWidth = new(this, "unityTextOutlineWidth", -1);
				}
				return r_PunityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflowPosition] unityTextOverflowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition> r_PunityTextOverflowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition> RPunityTextOverflowPosition
		{
			get
			{
				if(r_PunityTextOverflowPosition == null)
				{
					r_PunityTextOverflowPosition = new(this, "unityTextOverflowPosition", -1);
				}
				return r_PunityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Visibility] visibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility> r_Pvisibility;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility> RPvisibility
		{
			get
			{
				if(r_Pvisibility == null)
				{
					r_Pvisibility = new(this, "visibility", -1);
				}
				return r_Pvisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.WhiteSpace] whiteSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace> r_PwhiteSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace> RPwhiteSpace
		{
			get
			{
				if(r_PwhiteSpace == null)
				{
					r_PwhiteSpace = new(this, "whiteSpace", -1);
				}
				return r_PwhiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength width
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength r_PwordSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleLength RPwordSpacing
		{
			get
			{
				if(r_PwordSpacing == null)
				{
					r_PwordSpacing = new(this, "wordSpacing", -1);
				}
				return r_PwordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] unityBackgroundScaleMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RScaleMode> r_PunityBackgroundScaleMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RScaleMode> RPunityBackgroundScaleMode
		{
			get
			{
				if(r_PunityBackgroundScaleMode == null)
				{
					r_PunityBackgroundScaleMode = new(this, "unityBackgroundScaleMode", -1);
				}
				return r_PunityBackgroundScaleMode;
			}
		}


    }
}
