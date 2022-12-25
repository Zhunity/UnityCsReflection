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
		protected RProperty r_alignContent;
		public virtual RProperty RalignContent
		{
			get
			{
				if(r_alignContent == null)
				{
					r_alignContent = new(this, "alignContent", -1);
					r_alignContent.SetBelong(this.instance);
				}
				return r_alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignItems
		/// </summary>
		protected RProperty r_alignItems;
		public virtual RProperty RalignItems
		{
			get
			{
				if(r_alignItems == null)
				{
					r_alignItems = new(this, "alignItems", -1);
					r_alignItems.SetBelong(this.instance);
				}
				return r_alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Align] alignSelf
		/// </summary>
		protected RProperty r_alignSelf;
		public virtual RProperty RalignSelf
		{
			get
			{
				if(r_alignSelf == null)
				{
					r_alignSelf = new(this, "alignSelf", -1);
					r_alignSelf.SetBelong(this.instance);
				}
				return r_alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor backgroundColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_backgroundColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RbackgroundColor
		{
			get
			{
				if(r_backgroundColor == null)
				{
					r_backgroundColor = new(this, "backgroundColor", -1);
					r_backgroundColor.SetBelong(this.instance);
				}
				return r_backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackground r_backgroundImage;
		public virtual RUnityEngine.RUIElements.RStyleBackground RbackgroundImage
		{
			get
			{
				if(r_backgroundImage == null)
				{
					r_backgroundImage = new(this, "backgroundImage", -1);
					r_backgroundImage.SetBelong(this.instance);
				}
				return r_backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RbackgroundPositionX
		{
			get
			{
				if(r_backgroundPositionX == null)
				{
					r_backgroundPositionX = new(this, "backgroundPositionX", -1);
					r_backgroundPositionX.SetBelong(this.instance);
				}
				return r_backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundPosition r_backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundPosition RbackgroundPositionY
		{
			get
			{
				if(r_backgroundPositionY == null)
				{
					r_backgroundPositionY = new(this, "backgroundPositionY", -1);
					r_backgroundPositionY.SetBelong(this.instance);
				}
				return r_backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundRepeat r_backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundRepeat RbackgroundRepeat
		{
			get
			{
				if(r_backgroundRepeat == null)
				{
					r_backgroundRepeat = new(this, "backgroundRepeat", -1);
					r_backgroundRepeat.SetBelong(this.instance);
				}
				return r_backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleBackgroundSize r_backgroundSize;
		public virtual RUnityEngine.RUIElements.RStyleBackgroundSize RbackgroundSize
		{
			get
			{
				if(r_backgroundSize == null)
				{
					r_backgroundSize = new(this, "backgroundSize", -1);
					r_backgroundSize.SetBelong(this.instance);
				}
				return r_backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderBottomColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_borderBottomColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RborderBottomColor
		{
			get
			{
				if(r_borderBottomColor == null)
				{
					r_borderBottomColor = new(this, "borderBottomColor", -1);
					r_borderBottomColor.SetBelong(this.instance);
				}
				return r_borderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_borderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RborderBottomLeftRadius
		{
			get
			{
				if(r_borderBottomLeftRadius == null)
				{
					r_borderBottomLeftRadius = new(this, "borderBottomLeftRadius", -1);
					r_borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_borderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RborderBottomRightRadius
		{
			get
			{
				if(r_borderBottomRightRadius == null)
				{
					r_borderBottomRightRadius = new(this, "borderBottomRightRadius", -1);
					r_borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_borderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderBottomWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_borderBottomWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RborderBottomWidth
		{
			get
			{
				if(r_borderBottomWidth == null)
				{
					r_borderBottomWidth = new(this, "borderBottomWidth", -1);
					r_borderBottomWidth.SetBelong(this.instance);
				}
				return r_borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderLeftColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_borderLeftColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RborderLeftColor
		{
			get
			{
				if(r_borderLeftColor == null)
				{
					r_borderLeftColor = new(this, "borderLeftColor", -1);
					r_borderLeftColor.SetBelong(this.instance);
				}
				return r_borderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderLeftWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_borderLeftWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RborderLeftWidth
		{
			get
			{
				if(r_borderLeftWidth == null)
				{
					r_borderLeftWidth = new(this, "borderLeftWidth", -1);
					r_borderLeftWidth.SetBelong(this.instance);
				}
				return r_borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderRightColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_borderRightColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RborderRightColor
		{
			get
			{
				if(r_borderRightColor == null)
				{
					r_borderRightColor = new(this, "borderRightColor", -1);
					r_borderRightColor.SetBelong(this.instance);
				}
				return r_borderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderRightWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_borderRightWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RborderRightWidth
		{
			get
			{
				if(r_borderRightWidth == null)
				{
					r_borderRightWidth = new(this, "borderRightWidth", -1);
					r_borderRightWidth.SetBelong(this.instance);
				}
				return r_borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor borderTopColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_borderTopColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RborderTopColor
		{
			get
			{
				if(r_borderTopColor == null)
				{
					r_borderTopColor = new(this, "borderTopColor", -1);
					r_borderTopColor.SetBelong(this.instance);
				}
				return r_borderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_borderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RborderTopLeftRadius
		{
			get
			{
				if(r_borderTopLeftRadius == null)
				{
					r_borderTopLeftRadius = new(this, "borderTopLeftRadius", -1);
					r_borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_borderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_borderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RStyleLength RborderTopRightRadius
		{
			get
			{
				if(r_borderTopRightRadius == null)
				{
					r_borderTopRightRadius = new(this, "borderTopRightRadius", -1);
					r_borderTopRightRadius.SetBelong(this.instance);
				}
				return r_borderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat borderTopWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_borderTopWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RborderTopWidth
		{
			get
			{
				if(r_borderTopWidth == null)
				{
					r_borderTopWidth = new(this, "borderTopWidth", -1);
					r_borderTopWidth.SetBelong(this.instance);
				}
				return r_borderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_bottom;
		public virtual RUnityEngine.RUIElements.RStyleLength Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom", -1);
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor color
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_color;
		public virtual RUnityEngine.RUIElements.RStyleColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color", -1);
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor cursor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleCursor r_cursor;
		public virtual RUnityEngine.RUIElements.RStyleCursor Rcursor
		{
			get
			{
				if(r_cursor == null)
				{
					r_cursor = new(this, "cursor", -1);
					r_cursor.SetBelong(this.instance);
				}
				return r_cursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.DisplayStyle] display
		/// </summary>
		protected RProperty r_display;
		public virtual RProperty Rdisplay
		{
			get
			{
				if(r_display == null)
				{
					r_display = new(this, "display", -1);
					r_display.SetBelong(this.instance);
				}
				return r_display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_flexBasis;
		public virtual RUnityEngine.RUIElements.RStyleLength RflexBasis
		{
			get
			{
				if(r_flexBasis == null)
				{
					r_flexBasis = new(this, "flexBasis", -1);
					r_flexBasis.SetBelong(this.instance);
				}
				return r_flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.FlexDirection] flexDirection
		/// </summary>
		protected RProperty r_flexDirection;
		public virtual RProperty RflexDirection
		{
			get
			{
				if(r_flexDirection == null)
				{
					r_flexDirection = new(this, "flexDirection", -1);
					r_flexDirection.SetBelong(this.instance);
				}
				return r_flexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexGrow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_flexGrow;
		public virtual RUnityEngine.RUIElements.RStyleFloat RflexGrow
		{
			get
			{
				if(r_flexGrow == null)
				{
					r_flexGrow = new(this, "flexGrow", -1);
					r_flexGrow.SetBelong(this.instance);
				}
				return r_flexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexShrink
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_flexShrink;
		public virtual RUnityEngine.RUIElements.RStyleFloat RflexShrink
		{
			get
			{
				if(r_flexShrink == null)
				{
					r_flexShrink = new(this, "flexShrink", -1);
					r_flexShrink.SetBelong(this.instance);
				}
				return r_flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Wrap] flexWrap
		/// </summary>
		protected RProperty r_flexWrap;
		public virtual RProperty RflexWrap
		{
			get
			{
				if(r_flexWrap == null)
				{
					r_flexWrap = new(this, "flexWrap", -1);
					r_flexWrap.SetBelong(this.instance);
				}
				return r_flexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_fontSize;
		public virtual RUnityEngine.RUIElements.RStyleLength RfontSize
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
		/// UnityEngine.UIElements.StyleLength height
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_height;
		public virtual RUnityEngine.RUIElements.RStyleLength Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Justify] justifyContent
		/// </summary>
		protected RProperty r_justifyContent;
		public virtual RProperty RjustifyContent
		{
			get
			{
				if(r_justifyContent == null)
				{
					r_justifyContent = new(this, "justifyContent", -1);
					r_justifyContent.SetBelong(this.instance);
				}
				return r_justifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength left
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_left;
		public virtual RUnityEngine.RUIElements.RStyleLength Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left", -1);
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_letterSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RletterSpacing
		{
			get
			{
				if(r_letterSpacing == null)
				{
					r_letterSpacing = new(this, "letterSpacing", -1);
					r_letterSpacing.SetBelong(this.instance);
				}
				return r_letterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_marginBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RmarginBottom
		{
			get
			{
				if(r_marginBottom == null)
				{
					r_marginBottom = new(this, "marginBottom", -1);
					r_marginBottom.SetBelong(this.instance);
				}
				return r_marginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_marginLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RmarginLeft
		{
			get
			{
				if(r_marginLeft == null)
				{
					r_marginLeft = new(this, "marginLeft", -1);
					r_marginLeft.SetBelong(this.instance);
				}
				return r_marginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_marginRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RmarginRight
		{
			get
			{
				if(r_marginRight == null)
				{
					r_marginRight = new(this, "marginRight", -1);
					r_marginRight.SetBelong(this.instance);
				}
				return r_marginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_marginTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RmarginTop
		{
			get
			{
				if(r_marginTop == null)
				{
					r_marginTop = new(this, "marginTop", -1);
					r_marginTop.SetBelong(this.instance);
				}
				return r_marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_maxHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RmaxHeight
		{
			get
			{
				if(r_maxHeight == null)
				{
					r_maxHeight = new(this, "maxHeight", -1);
					r_maxHeight.SetBelong(this.instance);
				}
				return r_maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_maxWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RmaxWidth
		{
			get
			{
				if(r_maxWidth == null)
				{
					r_maxWidth = new(this, "maxWidth", -1);
					r_maxWidth.SetBelong(this.instance);
				}
				return r_maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_minHeight;
		public virtual RUnityEngine.RUIElements.RStyleLength RminHeight
		{
			get
			{
				if(r_minHeight == null)
				{
					r_minHeight = new(this, "minHeight", -1);
					r_minHeight.SetBelong(this.instance);
				}
				return r_minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_minWidth;
		public virtual RUnityEngine.RUIElements.RStyleLength RminWidth
		{
			get
			{
				if(r_minWidth == null)
				{
					r_minWidth = new(this, "minWidth", -1);
					r_minWidth.SetBelong(this.instance);
				}
				return r_minWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat opacity
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_opacity;
		public virtual RUnityEngine.RUIElements.RStyleFloat Ropacity
		{
			get
			{
				if(r_opacity == null)
				{
					r_opacity = new(this, "opacity", -1);
					r_opacity.SetBelong(this.instance);
				}
				return r_opacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Overflow] overflow
		/// </summary>
		protected RProperty r_overflow;
		public virtual RProperty Roverflow
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
		/// UnityEngine.UIElements.StyleLength paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_paddingBottom;
		public virtual RUnityEngine.RUIElements.RStyleLength RpaddingBottom
		{
			get
			{
				if(r_paddingBottom == null)
				{
					r_paddingBottom = new(this, "paddingBottom", -1);
					r_paddingBottom.SetBelong(this.instance);
				}
				return r_paddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_paddingLeft;
		public virtual RUnityEngine.RUIElements.RStyleLength RpaddingLeft
		{
			get
			{
				if(r_paddingLeft == null)
				{
					r_paddingLeft = new(this, "paddingLeft", -1);
					r_paddingLeft.SetBelong(this.instance);
				}
				return r_paddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_paddingRight;
		public virtual RUnityEngine.RUIElements.RStyleLength RpaddingRight
		{
			get
			{
				if(r_paddingRight == null)
				{
					r_paddingRight = new(this, "paddingRight", -1);
					r_paddingRight.SetBelong(this.instance);
				}
				return r_paddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_paddingTop;
		public virtual RUnityEngine.RUIElements.RStyleLength RpaddingTop
		{
			get
			{
				if(r_paddingTop == null)
				{
					r_paddingTop = new(this, "paddingTop", -1);
					r_paddingTop.SetBelong(this.instance);
				}
				return r_paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Position] position
		/// </summary>
		protected RProperty r_position;
		public virtual RProperty Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength right
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_right;
		public virtual RUnityEngine.RUIElements.RStyleLength Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right", -1);
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRotate rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRotate r_rotate;
		public virtual RUnityEngine.RUIElements.RStyleRotate Rrotate
		{
			get
			{
				if(r_rotate == null)
				{
					r_rotate = new(this, "rotate", -1);
					r_rotate.SetBelong(this.instance);
				}
				return r_rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleScale scale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleScale r_scale;
		public virtual RUnityEngine.RUIElements.RStyleScale Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale", -1);
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflow] textOverflow
		/// </summary>
		protected RProperty r_textOverflow;
		public virtual RProperty RtextOverflow
		{
			get
			{
				if(r_textOverflow == null)
				{
					r_textOverflow = new(this, "textOverflow", -1);
					r_textOverflow.SetBelong(this.instance);
				}
				return r_textOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTextShadow textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTextShadow r_textShadow;
		public virtual RUnityEngine.RUIElements.RStyleTextShadow RtextShadow
		{
			get
			{
				if(r_textShadow == null)
				{
					r_textShadow = new(this, "textShadow", -1);
					r_textShadow.SetBelong(this.instance);
				}
				return r_textShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength top
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_top;
		public virtual RUnityEngine.RUIElements.RStyleLength Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top", -1);
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTransformOrigin r_transformOrigin;
		public virtual RUnityEngine.RUIElements.RStyleTransformOrigin RtransformOrigin
		{
			get
			{
				if(r_transformOrigin == null)
				{
					r_transformOrigin = new(this, "transformOrigin", -1);
					r_transformOrigin.SetBelong(this.instance);
				}
				return r_transformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_transitionDelay;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RtransitionDelay
		{
			get
			{
				if(r_transitionDelay == null)
				{
					r_transitionDelay = new(this, "transitionDelay", -1);
					r_transitionDelay.SetBelong(this.instance);
				}
				return r_transitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> r_transitionDuration;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RTimeValue> RtransitionDuration
		{
			get
			{
				if(r_transitionDuration == null)
				{
					r_transitionDuration = new(this, "transitionDuration", -1);
					r_transitionDuration.SetBelong(this.instance);
				}
				return r_transitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> r_transitionProperty;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.RStylePropertyName> RtransitionProperty
		{
			get
			{
				if(r_transitionProperty == null)
				{
					r_transitionProperty = new(this, "transitionProperty", -1);
					r_transitionProperty.SetBelong(this.instance);
				}
				return r_transitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleList`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> r_transitionTimingFunction;
		public virtual RUnityEngine.RUIElements.RStyleList<RUnityEngine.RUIElements.REasingFunction> RtransitionTimingFunction
		{
			get
			{
				if(r_transitionTimingFunction == null)
				{
					r_transitionTimingFunction = new(this, "transitionTimingFunction", -1);
					r_transitionTimingFunction.SetBelong(this.instance);
				}
				return r_transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTranslate translate
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleTranslate r_translate;
		public virtual RUnityEngine.RUIElements.RStyleTranslate Rtranslate
		{
			get
			{
				if(r_translate == null)
				{
					r_translate = new(this, "translate", -1);
					r_translate.SetBelong(this.instance);
				}
				return r_translate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_unityBackgroundImageTintColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RunityBackgroundImageTintColor
		{
			get
			{
				if(r_unityBackgroundImageTintColor == null)
				{
					r_unityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor", -1);
					r_unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont unityFont
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFont r_unityFont;
		public virtual RUnityEngine.RUIElements.RStyleFont RunityFont
		{
			get
			{
				if(r_unityFont == null)
				{
					r_unityFont = new(this, "unityFont", -1);
					r_unityFont.SetBelong(this.instance);
				}
				return r_unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFontDefinition r_unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RStyleFontDefinition RunityFontDefinition
		{
			get
			{
				if(r_unityFontDefinition == null)
				{
					r_unityFontDefinition = new(this, "unityFontDefinition", -1);
					r_unityFontDefinition.SetBelong(this.instance);
				}
				return r_unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.FontStyle] unityFontStyleAndWeight
		/// </summary>
		protected RProperty r_unityFontStyleAndWeight;
		public virtual RProperty RunityFontStyleAndWeight
		{
			get
			{
				if(r_unityFontStyleAndWeight == null)
				{
					r_unityFontStyleAndWeight = new(this, "unityFontStyleAndWeight", -1);
					r_unityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.OverflowClipBox] unityOverflowClipBox
		/// </summary>
		protected RProperty r_unityOverflowClipBox;
		public virtual RProperty RunityOverflowClipBox
		{
			get
			{
				if(r_unityOverflowClipBox == null)
				{
					r_unityOverflowClipBox = new(this, "unityOverflowClipBox", -1);
					r_unityOverflowClipBox.SetBelong(this.instance);
				}
				return r_unityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_unityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RunityParagraphSpacing
		{
			get
			{
				if(r_unityParagraphSpacing == null)
				{
					r_unityParagraphSpacing = new(this, "unityParagraphSpacing", -1);
					r_unityParagraphSpacing.SetBelong(this.instance);
				}
				return r_unityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_unitySliceBottom;
		public virtual RUnityEngine.RUIElements.RStyleInt RunitySliceBottom
		{
			get
			{
				if(r_unitySliceBottom == null)
				{
					r_unitySliceBottom = new(this, "unitySliceBottom", -1);
					r_unitySliceBottom.SetBelong(this.instance);
				}
				return r_unitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_unitySliceLeft;
		public virtual RUnityEngine.RUIElements.RStyleInt RunitySliceLeft
		{
			get
			{
				if(r_unitySliceLeft == null)
				{
					r_unitySliceLeft = new(this, "unitySliceLeft", -1);
					r_unitySliceLeft.SetBelong(this.instance);
				}
				return r_unitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceRight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_unitySliceRight;
		public virtual RUnityEngine.RUIElements.RStyleInt RunitySliceRight
		{
			get
			{
				if(r_unitySliceRight == null)
				{
					r_unitySliceRight = new(this, "unitySliceRight", -1);
					r_unitySliceRight.SetBelong(this.instance);
				}
				return r_unitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat unitySliceScale
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_unitySliceScale;
		public virtual RUnityEngine.RUIElements.RStyleFloat RunitySliceScale
		{
			get
			{
				if(r_unitySliceScale == null)
				{
					r_unitySliceScale = new(this, "unitySliceScale", -1);
					r_unitySliceScale.SetBelong(this.instance);
				}
				return r_unitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt unitySliceTop
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleInt r_unitySliceTop;
		public virtual RUnityEngine.RUIElements.RStyleInt RunitySliceTop
		{
			get
			{
				if(r_unitySliceTop == null)
				{
					r_unitySliceTop = new(this, "unitySliceTop", -1);
					r_unitySliceTop.SetBelong(this.instance);
				}
				return r_unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.TextAnchor] unityTextAlign
		/// </summary>
		protected RProperty r_unityTextAlign;
		public virtual RProperty RunityTextAlign
		{
			get
			{
				if(r_unityTextAlign == null)
				{
					r_unityTextAlign = new(this, "unityTextAlign", -1);
					r_unityTextAlign.SetBelong(this.instance);
				}
				return r_unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleColor r_unityTextOutlineColor;
		public virtual RUnityEngine.RUIElements.RStyleColor RunityTextOutlineColor
		{
			get
			{
				if(r_unityTextOutlineColor == null)
				{
					r_unityTextOutlineColor = new(this, "unityTextOutlineColor", -1);
					r_unityTextOutlineColor.SetBelong(this.instance);
				}
				return r_unityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat unityTextOutlineWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_unityTextOutlineWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RunityTextOutlineWidth
		{
			get
			{
				if(r_unityTextOutlineWidth == null)
				{
					r_unityTextOutlineWidth = new(this, "unityTextOutlineWidth", -1);
					r_unityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.TextOverflowPosition] unityTextOverflowPosition
		/// </summary>
		protected RProperty r_unityTextOverflowPosition;
		public virtual RProperty RunityTextOverflowPosition
		{
			get
			{
				if(r_unityTextOverflowPosition == null)
				{
					r_unityTextOverflowPosition = new(this, "unityTextOverflowPosition", -1);
					r_unityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.Visibility] visibility
		/// </summary>
		protected RProperty r_visibility;
		public virtual RProperty Rvisibility
		{
			get
			{
				if(r_visibility == null)
				{
					r_visibility = new(this, "visibility", -1);
					r_visibility.SetBelong(this.instance);
				}
				return r_visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.UIElements.WhiteSpace] whiteSpace
		/// </summary>
		protected RProperty r_whiteSpace;
		public virtual RProperty RwhiteSpace
		{
			get
			{
				if(r_whiteSpace == null)
				{
					r_whiteSpace = new(this, "whiteSpace", -1);
					r_whiteSpace.SetBelong(this.instance);
				}
				return r_whiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength width
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_width;
		public virtual RUnityEngine.RUIElements.RStyleLength Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleLength r_wordSpacing;
		public virtual RUnityEngine.RUIElements.RStyleLength RwordSpacing
		{
			get
			{
				if(r_wordSpacing == null)
				{
					r_wordSpacing = new(this, "wordSpacing", -1);
					r_wordSpacing.SetBelong(this.instance);
				}
				return r_wordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] unityBackgroundScaleMode
		/// </summary>
		protected RProperty r_unityBackgroundScaleMode;
		public virtual RProperty RunityBackgroundScaleMode
		{
			get
			{
				if(r_unityBackgroundScaleMode == null)
				{
					r_unityBackgroundScaleMode = new(this, "unityBackgroundScaleMode", -1);
					r_unityBackgroundScaleMode.SetBelong(this.instance);
				}
				return r_unityBackgroundScaleMode;
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
