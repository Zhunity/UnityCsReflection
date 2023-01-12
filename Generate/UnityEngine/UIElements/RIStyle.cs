using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IStyle
	/// </summary>
    public partial class RIStyle : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignContent
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RAlign> r_PalignContent;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RAlign> RPalignContent
		{
			get
			{
				if(r_PalignContent == null)
				{
					r_PalignContent = new(this, "alignContent", -1);
					r_PalignContent.SetBelong(this.instance);
				}
				return r_PalignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignItems
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RAlign> r_PalignItems;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RAlign> RPalignItems
		{
			get
			{
				if(r_PalignItems == null)
				{
					r_PalignItems = new(this, "alignItems", -1);
					r_PalignItems.SetBelong(this.instance);
				}
				return r_PalignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignSelf
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RAlign> r_PalignSelf;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RAlign> RPalignSelf
		{
			get
			{
				if(r_PalignSelf == null)
				{
					r_PalignSelf = new(this, "alignSelf", -1);
					r_PalignSelf.SetBelong(this.instance);
				}
				return r_PalignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor backgroundColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PbackgroundColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPbackgroundColor
		{
			get
			{
				if(r_PbackgroundColor == null)
				{
					r_PbackgroundColor = new(this, "backgroundColor", -1);
					r_PbackgroundColor.SetBelong(this.instance);
				}
				return r_PbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackground r_PbackgroundImage;
		public virtual RUnityEngine.RUIElements.RStyleBackground RPbackgroundImage
		{
			get
			{
				if(r_PbackgroundImage == null)
				{
					r_PbackgroundImage = new(this, "backgroundImage", -1);
					r_PbackgroundImage.SetBelong(this.instance);
				}
				return r_PbackgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_PbackgroundPositionX;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RPbackgroundPositionX
		{
			get
			{
				if(r_PbackgroundPositionX == null)
				{
					r_PbackgroundPositionX = new(this, "backgroundPositionX", -1);
					r_PbackgroundPositionX.SetBelong(this.instance);
				}
				return r_PbackgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_PbackgroundPositionY;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RPbackgroundPositionY
		{
			get
			{
				if(r_PbackgroundPositionY == null)
				{
					r_PbackgroundPositionY = new(this, "backgroundPositionY", -1);
					r_PbackgroundPositionY.SetBelong(this.instance);
				}
				return r_PbackgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundRepeat r_PbackgroundRepeat;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundRepeat RPbackgroundRepeat
		{
			get
			{
				if(r_PbackgroundRepeat == null)
				{
					r_PbackgroundRepeat = new(this, "backgroundRepeat", -1);
					r_PbackgroundRepeat.SetBelong(this.instance);
				}
				return r_PbackgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundSize r_PbackgroundSize;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundSize RPbackgroundSize
		{
			get
			{
				if(r_PbackgroundSize == null)
				{
					r_PbackgroundSize = new(this, "backgroundSize", -1);
					r_PbackgroundSize.SetBelong(this.instance);
				}
				return r_PbackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderBottomColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PborderBottomColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPborderBottomColor
		{
			get
			{
				if(r_PborderBottomColor == null)
				{
					r_PborderBottomColor = new(this, "borderBottomColor", -1);
					r_PborderBottomColor.SetBelong(this.instance);
				}
				return r_PborderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PborderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RPborderBottomLeftRadius
		{
			get
			{
				if(r_PborderBottomLeftRadius == null)
				{
					r_PborderBottomLeftRadius = new(this, "borderBottomLeftRadius", -1);
					r_PborderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_PborderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PborderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RPborderBottomRightRadius
		{
			get
			{
				if(r_PborderBottomRightRadius == null)
				{
					r_PborderBottomRightRadius = new(this, "borderBottomRightRadius", -1);
					r_PborderBottomRightRadius.SetBelong(this.instance);
				}
				return r_PborderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderBottomWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PborderBottomWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPborderBottomWidth
		{
			get
			{
				if(r_PborderBottomWidth == null)
				{
					r_PborderBottomWidth = new(this, "borderBottomWidth", -1);
					r_PborderBottomWidth.SetBelong(this.instance);
				}
				return r_PborderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderLeftColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PborderLeftColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPborderLeftColor
		{
			get
			{
				if(r_PborderLeftColor == null)
				{
					r_PborderLeftColor = new(this, "borderLeftColor", -1);
					r_PborderLeftColor.SetBelong(this.instance);
				}
				return r_PborderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderLeftWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PborderLeftWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPborderLeftWidth
		{
			get
			{
				if(r_PborderLeftWidth == null)
				{
					r_PborderLeftWidth = new(this, "borderLeftWidth", -1);
					r_PborderLeftWidth.SetBelong(this.instance);
				}
				return r_PborderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderRightColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PborderRightColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPborderRightColor
		{
			get
			{
				if(r_PborderRightColor == null)
				{
					r_PborderRightColor = new(this, "borderRightColor", -1);
					r_PborderRightColor.SetBelong(this.instance);
				}
				return r_PborderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderRightWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PborderRightWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPborderRightWidth
		{
			get
			{
				if(r_PborderRightWidth == null)
				{
					r_PborderRightWidth = new(this, "borderRightWidth", -1);
					r_PborderRightWidth.SetBelong(this.instance);
				}
				return r_PborderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderTopColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PborderTopColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPborderTopColor
		{
			get
			{
				if(r_PborderTopColor == null)
				{
					r_PborderTopColor = new(this, "borderTopColor", -1);
					r_PborderTopColor.SetBelong(this.instance);
				}
				return r_PborderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PborderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RPborderTopLeftRadius
		{
			get
			{
				if(r_PborderTopLeftRadius == null)
				{
					r_PborderTopLeftRadius = new(this, "borderTopLeftRadius", -1);
					r_PborderTopLeftRadius.SetBelong(this.instance);
				}
				return r_PborderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PborderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RPborderTopRightRadius
		{
			get
			{
				if(r_PborderTopRightRadius == null)
				{
					r_PborderTopRightRadius = new(this, "borderTopRightRadius", -1);
					r_PborderTopRightRadius.SetBelong(this.instance);
				}
				return r_PborderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderTopWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PborderTopWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPborderTopWidth
		{
			get
			{
				if(r_PborderTopWidth == null)
				{
					r_PborderTopWidth = new(this, "borderTopWidth", -1);
					r_PborderTopWidth.SetBelong(this.instance);
				}
				return r_PborderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_Pbottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
					r_Pbottom.SetBelong(this.instance);
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor color
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_Pcolor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPcolor
		{
			get
			{
				if(r_Pcolor == null)
				{
					r_Pcolor = new(this, "color", -1);
					r_Pcolor.SetBelong(this.instance);
				}
				return r_Pcolor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor cursor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleCursor r_Pcursor;
		public virtual RUnityEngine.RUIElements.RStyleCursor RPcursor
		{
			get
			{
				if(r_Pcursor == null)
				{
					r_Pcursor = new(this, "cursor", -1);
					r_Pcursor.SetBelong(this.instance);
				}
				return r_Pcursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.DisplayStyle] display
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RDisplayStyle> r_Pdisplay;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RDisplayStyle> RPdisplay
		{
			get
			{
				if(r_Pdisplay == null)
				{
					r_Pdisplay = new(this, "display", -1);
					r_Pdisplay.SetBelong(this.instance);
				}
				return r_Pdisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PflexBasis;
		public virtual RUnityEngine.RUIElements.RStyleLength RPflexBasis
		{
			get
			{
				if(r_PflexBasis == null)
				{
					r_PflexBasis = new(this, "flexBasis", -1);
					r_PflexBasis.SetBelong(this.instance);
				}
				return r_PflexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.FlexDirection] flexDirection
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RFlexDirection> r_PflexDirection;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RFlexDirection> RPflexDirection
		{
			get
			{
				if(r_PflexDirection == null)
				{
					r_PflexDirection = new(this, "flexDirection", -1);
					r_PflexDirection.SetBelong(this.instance);
				}
				return r_PflexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexGrow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PflexGrow;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPflexGrow
		{
			get
			{
				if(r_PflexGrow == null)
				{
					r_PflexGrow = new(this, "flexGrow", -1);
					r_PflexGrow.SetBelong(this.instance);
				}
				return r_PflexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexShrink
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PflexShrink;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPflexShrink
		{
			get
			{
				if(r_PflexShrink == null)
				{
					r_PflexShrink = new(this, "flexShrink", -1);
					r_PflexShrink.SetBelong(this.instance);
				}
				return r_PflexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Wrap] flexWrap
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RWrap> r_PflexWrap;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RWrap> RPflexWrap
		{
			get
			{
				if(r_PflexWrap == null)
				{
					r_PflexWrap = new(this, "flexWrap", -1);
					r_PflexWrap.SetBelong(this.instance);
				}
				return r_PflexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PfontSize;
		public virtual RUnityEngine.RUIElements.RStyleLength RPfontSize
		{
			get
			{
				if(r_PfontSize == null)
				{
					r_PfontSize = new(this, "fontSize", -1);
					r_PfontSize.SetBelong(this.instance);
				}
				return r_PfontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength height
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_Pheight;
		public virtual RUnityEngine.RUIElements.RStyleLength RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
					r_Pheight.SetBelong(this.instance);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Justify] justifyContent
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RJustify> r_PjustifyContent;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RJustify> RPjustifyContent
		{
			get
			{
				if(r_PjustifyContent == null)
				{
					r_PjustifyContent = new(this, "justifyContent", -1);
					r_PjustifyContent.SetBelong(this.instance);
				}
				return r_PjustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength left
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_Pleft;
		public virtual RUnityEngine.RUIElements.RStyleLength RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
					r_Pleft.SetBelong(this.instance);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PletterSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RPletterSpacing
		{
			get
			{
				if(r_PletterSpacing == null)
				{
					r_PletterSpacing = new(this, "letterSpacing", -1);
					r_PletterSpacing.SetBelong(this.instance);
				}
				return r_PletterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PmarginBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
					r_PmarginBottom.SetBelong(this.instance);
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PmarginLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
					r_PmarginLeft.SetBelong(this.instance);
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PmarginRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
					r_PmarginRight.SetBelong(this.instance);
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PmarginTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
					r_PmarginTop.SetBelong(this.instance);
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PmaxHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RPmaxHeight
		{
			get
			{
				if(r_PmaxHeight == null)
				{
					r_PmaxHeight = new(this, "maxHeight", -1);
					r_PmaxHeight.SetBelong(this.instance);
				}
				return r_PmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PmaxWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RPmaxWidth
		{
			get
			{
				if(r_PmaxWidth == null)
				{
					r_PmaxWidth = new(this, "maxWidth", -1);
					r_PmaxWidth.SetBelong(this.instance);
				}
				return r_PmaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PminHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RPminHeight
		{
			get
			{
				if(r_PminHeight == null)
				{
					r_PminHeight = new(this, "minHeight", -1);
					r_PminHeight.SetBelong(this.instance);
				}
				return r_PminHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PminWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RPminWidth
		{
			get
			{
				if(r_PminWidth == null)
				{
					r_PminWidth = new(this, "minWidth", -1);
					r_PminWidth.SetBelong(this.instance);
				}
				return r_PminWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat opacity
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_Popacity;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
					r_Popacity.SetBelong(this.instance);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Overflow] overflow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.ROverflow> r_Poverflow;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.ROverflow> RPoverflow
		{
			get
			{
				if(r_Poverflow == null)
				{
					r_Poverflow = new(this, "overflow", -1);
					r_Poverflow.SetBelong(this.instance);
				}
				return r_Poverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PpaddingBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RPpaddingBottom
		{
			get
			{
				if(r_PpaddingBottom == null)
				{
					r_PpaddingBottom = new(this, "paddingBottom", -1);
					r_PpaddingBottom.SetBelong(this.instance);
				}
				return r_PpaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PpaddingLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RPpaddingLeft
		{
			get
			{
				if(r_PpaddingLeft == null)
				{
					r_PpaddingLeft = new(this, "paddingLeft", -1);
					r_PpaddingLeft.SetBelong(this.instance);
				}
				return r_PpaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PpaddingRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RPpaddingRight
		{
			get
			{
				if(r_PpaddingRight == null)
				{
					r_PpaddingRight = new(this, "paddingRight", -1);
					r_PpaddingRight.SetBelong(this.instance);
				}
				return r_PpaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PpaddingTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RPpaddingTop
		{
			get
			{
				if(r_PpaddingTop == null)
				{
					r_PpaddingTop = new(this, "paddingTop", -1);
					r_PpaddingTop.SetBelong(this.instance);
				}
				return r_PpaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Position] position
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RPosition> r_Pposition;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RPosition> RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.instance);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength right
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_Pright;
		public virtual RUnityEngine.RUIElements.RStyleLength RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
					r_Pright.SetBelong(this.instance);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRotate r_Protate;
		public virtual RUnityEngine.RUIElements.RStyleRotate RProtate
		{
			get
			{
				if(r_Protate == null)
				{
					r_Protate = new(this, "rotate", -1);
					r_Protate.SetBelong(this.instance);
				}
				return r_Protate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale scale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleScale r_Pscale;
		public virtual RUnityEngine.RUIElements.RStyleScale RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
					r_Pscale.SetBelong(this.instance);
				}
				return r_Pscale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflow] textOverflow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RTextOverflow> r_PtextOverflow;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RTextOverflow> RPtextOverflow
		{
			get
			{
				if(r_PtextOverflow == null)
				{
					r_PtextOverflow = new(this, "textOverflow", -1);
					r_PtextOverflow.SetBelong(this.instance);
				}
				return r_PtextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTextShadow r_PtextShadow;
		public virtual RUnityEngine.RUIElements.RStyleTextShadow RPtextShadow
		{
			get
			{
				if(r_PtextShadow == null)
				{
					r_PtextShadow = new(this, "textShadow", -1);
					r_PtextShadow.SetBelong(this.instance);
				}
				return r_PtextShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength top
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_Ptop;
		public virtual RUnityEngine.RUIElements.RStyleLength RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
					r_Ptop.SetBelong(this.instance);
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTransformOrigin r_PtransformOrigin;
		public virtual RUnityEngine.RUIElements.RStyleTransformOrigin RPtransformOrigin
		{
			get
			{
				if(r_PtransformOrigin == null)
				{
					r_PtransformOrigin = new(this, "transformOrigin", -1);
					r_PtransformOrigin.SetBelong(this.instance);
				}
				return r_PtransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_PtransitionDelay;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RPtransitionDelay
		{
			get
			{
				if(r_PtransitionDelay == null)
				{
					r_PtransitionDelay = new(this, "transitionDelay", -1);
					r_PtransitionDelay.SetBelong(this.instance);
				}
				return r_PtransitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_PtransitionDuration;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RPtransitionDuration
		{
			get
			{
				if(r_PtransitionDuration == null)
				{
					r_PtransitionDuration = new(this, "transitionDuration", -1);
					r_PtransitionDuration.SetBelong(this.instance);
				}
				return r_PtransitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> r_PtransitionProperty;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> RPtransitionProperty
		{
			get
			{
				if(r_PtransitionProperty == null)
				{
					r_PtransitionProperty = new(this, "transitionProperty", -1);
					r_PtransitionProperty.SetBelong(this.instance);
				}
				return r_PtransitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> r_PtransitionTimingFunction;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> RPtransitionTimingFunction
		{
			get
			{
				if(r_PtransitionTimingFunction == null)
				{
					r_PtransitionTimingFunction = new(this, "transitionTimingFunction", -1);
					r_PtransitionTimingFunction.SetBelong(this.instance);
				}
				return r_PtransitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate translate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTranslate r_Ptranslate;
		public virtual RUnityEngine.RUIElements.RStyleTranslate RPtranslate
		{
			get
			{
				if(r_Ptranslate == null)
				{
					r_Ptranslate = new(this, "translate", -1);
					r_Ptranslate.SetBelong(this.instance);
				}
				return r_Ptranslate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PunityBackgroundImageTintColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPunityBackgroundImageTintColor
		{
			get
			{
				if(r_PunityBackgroundImageTintColor == null)
				{
					r_PunityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor", -1);
					r_PunityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_PunityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont unityFont
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFont r_PunityFont;
		public virtual RUnityEngine.RUIElements.RStyleFont RPunityFont
		{
			get
			{
				if(r_PunityFont == null)
				{
					r_PunityFont = new(this, "unityFont", -1);
					r_PunityFont.SetBelong(this.instance);
				}
				return r_PunityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFontDefinition r_PunityFontDefinition;
		public virtual RUnityEngine.RUIElements.RStyleFontDefinition RPunityFontDefinition
		{
			get
			{
				if(r_PunityFontDefinition == null)
				{
					r_PunityFontDefinition = new(this, "unityFontDefinition", -1);
					r_PunityFontDefinition.SetBelong(this.instance);
				}
				return r_PunityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.FontStyle] unityFontStyleAndWeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RFontStyle> r_PunityFontStyleAndWeight;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RFontStyle> RPunityFontStyleAndWeight
		{
			get
			{
				if(r_PunityFontStyleAndWeight == null)
				{
					r_PunityFontStyleAndWeight = new(this, "unityFontStyleAndWeight", -1);
					r_PunityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_PunityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.OverflowClipBox] unityOverflowClipBox
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.ROverflowClipBox> r_PunityOverflowClipBox;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.ROverflowClipBox> RPunityOverflowClipBox
		{
			get
			{
				if(r_PunityOverflowClipBox == null)
				{
					r_PunityOverflowClipBox = new(this, "unityOverflowClipBox", -1);
					r_PunityOverflowClipBox.SetBelong(this.instance);
				}
				return r_PunityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PunityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RPunityParagraphSpacing
		{
			get
			{
				if(r_PunityParagraphSpacing == null)
				{
					r_PunityParagraphSpacing = new(this, "unityParagraphSpacing", -1);
					r_PunityParagraphSpacing.SetBelong(this.instance);
				}
				return r_PunityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_PunitySliceBottom;
		public virtual RUnityEngine.RUIElements.RStyleInt RPunitySliceBottom
		{
			get
			{
				if(r_PunitySliceBottom == null)
				{
					r_PunitySliceBottom = new(this, "unitySliceBottom", -1);
					r_PunitySliceBottom.SetBelong(this.instance);
				}
				return r_PunitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_PunitySliceLeft;
		public virtual RUnityEngine.RUIElements.RStyleInt RPunitySliceLeft
		{
			get
			{
				if(r_PunitySliceLeft == null)
				{
					r_PunitySliceLeft = new(this, "unitySliceLeft", -1);
					r_PunitySliceLeft.SetBelong(this.instance);
				}
				return r_PunitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_PunitySliceRight;
		public virtual RUnityEngine.RUIElements.RStyleInt RPunitySliceRight
		{
			get
			{
				if(r_PunitySliceRight == null)
				{
					r_PunitySliceRight = new(this, "unitySliceRight", -1);
					r_PunitySliceRight.SetBelong(this.instance);
				}
				return r_PunitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat unitySliceScale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PunitySliceScale;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPunitySliceScale
		{
			get
			{
				if(r_PunitySliceScale == null)
				{
					r_PunitySliceScale = new(this, "unitySliceScale", -1);
					r_PunitySliceScale.SetBelong(this.instance);
				}
				return r_PunitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_PunitySliceTop;
		public virtual RUnityEngine.RUIElements.RStyleInt RPunitySliceTop
		{
			get
			{
				if(r_PunitySliceTop == null)
				{
					r_PunitySliceTop = new(this, "unitySliceTop", -1);
					r_PunitySliceTop.SetBelong(this.instance);
				}
				return r_PunitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.TextAnchor] unityTextAlign
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RTextAnchor> r_PunityTextAlign;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RTextAnchor> RPunityTextAlign
		{
			get
			{
				if(r_PunityTextAlign == null)
				{
					r_PunityTextAlign = new(this, "unityTextAlign", -1);
					r_PunityTextAlign.SetBelong(this.instance);
				}
				return r_PunityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_PunityTextOutlineColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RPunityTextOutlineColor
		{
			get
			{
				if(r_PunityTextOutlineColor == null)
				{
					r_PunityTextOutlineColor = new(this, "unityTextOutlineColor", -1);
					r_PunityTextOutlineColor.SetBelong(this.instance);
				}
				return r_PunityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat unityTextOutlineWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PunityTextOutlineWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPunityTextOutlineWidth
		{
			get
			{
				if(r_PunityTextOutlineWidth == null)
				{
					r_PunityTextOutlineWidth = new(this, "unityTextOutlineWidth", -1);
					r_PunityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_PunityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflowPosition] unityTextOverflowPosition
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RTextOverflowPosition> r_PunityTextOverflowPosition;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RTextOverflowPosition> RPunityTextOverflowPosition
		{
			get
			{
				if(r_PunityTextOverflowPosition == null)
				{
					r_PunityTextOverflowPosition = new(this, "unityTextOverflowPosition", -1);
					r_PunityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_PunityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Visibility] visibility
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RVisibility> r_Pvisibility;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RVisibility> RPvisibility
		{
			get
			{
				if(r_Pvisibility == null)
				{
					r_Pvisibility = new(this, "visibility", -1);
					r_Pvisibility.SetBelong(this.instance);
				}
				return r_Pvisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.WhiteSpace] whiteSpace
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RWhiteSpace> r_PwhiteSpace;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RUIElements.RWhiteSpace> RPwhiteSpace
		{
			get
			{
				if(r_PwhiteSpace == null)
				{
					r_PwhiteSpace = new(this, "whiteSpace", -1);
					r_PwhiteSpace.SetBelong(this.instance);
				}
				return r_PwhiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength width
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_Pwidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
					r_Pwidth.SetBelong(this.instance);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_PwordSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RPwordSpacing
		{
			get
			{
				if(r_PwordSpacing == null)
				{
					r_PwordSpacing = new(this, "wordSpacing", -1);
					r_PwordSpacing.SetBelong(this.instance);
				}
				return r_PwordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] unityBackgroundScaleMode
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RScaleMode> r_PunityBackgroundScaleMode;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RScaleMode> RPunityBackgroundScaleMode
		{
			get
			{
				if(r_PunityBackgroundScaleMode == null)
				{
					r_PunityBackgroundScaleMode = new(this, "unityBackgroundScaleMode", -1);
					r_PunityBackgroundScaleMode.SetBelong(this.instance);
				}
				return r_PunityBackgroundScaleMode;
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

    }
}
