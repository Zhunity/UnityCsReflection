using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IResolvedStyle
	/// </summary>
    public partial class RIResolvedStyle : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Align alignContent
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
		/// UnityEngine.UIElements.Align alignItems
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
		/// UnityEngine.UIElements.Align alignSelf
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
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_backgroundColor;
		public virtual RUnityEngine.RColor RbackgroundColor
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
		/// UnityEngine.UIElements.Background backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_backgroundImage;
		public virtual RUnityEngine.RUIElements.RBackground RbackgroundImage
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
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RbackgroundPositionX
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
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RbackgroundPositionY
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
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RbackgroundRepeat
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
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_backgroundSize;
		public virtual RUnityEngine.RUIElements.RBackgroundSize RbackgroundSize
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
		/// UnityEngine.Color borderBottomColor
		/// </summary>
		protected RUnityEngine.RColor r_borderBottomColor;
		public virtual RUnityEngine.RColor RborderBottomColor
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
		/// Single borderBottomLeftRadius
		/// </summary>
		protected RSystem.RSingle r_borderBottomLeftRadius;
		public virtual RSystem.RSingle RborderBottomLeftRadius
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
		/// Single borderBottomRightRadius
		/// </summary>
		protected RSystem.RSingle r_borderBottomRightRadius;
		public virtual RSystem.RSingle RborderBottomRightRadius
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
		/// Single borderBottomWidth
		/// </summary>
		protected RSystem.RSingle r_borderBottomWidth;
		public virtual RSystem.RSingle RborderBottomWidth
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
		/// UnityEngine.Color borderLeftColor
		/// </summary>
		protected RUnityEngine.RColor r_borderLeftColor;
		public virtual RUnityEngine.RColor RborderLeftColor
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
		/// Single borderLeftWidth
		/// </summary>
		protected RSystem.RSingle r_borderLeftWidth;
		public virtual RSystem.RSingle RborderLeftWidth
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
		/// UnityEngine.Color borderRightColor
		/// </summary>
		protected RUnityEngine.RColor r_borderRightColor;
		public virtual RUnityEngine.RColor RborderRightColor
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
		/// Single borderRightWidth
		/// </summary>
		protected RSystem.RSingle r_borderRightWidth;
		public virtual RSystem.RSingle RborderRightWidth
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
		/// UnityEngine.Color borderTopColor
		/// </summary>
		protected RUnityEngine.RColor r_borderTopColor;
		public virtual RUnityEngine.RColor RborderTopColor
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
		/// Single borderTopLeftRadius
		/// </summary>
		protected RSystem.RSingle r_borderTopLeftRadius;
		public virtual RSystem.RSingle RborderTopLeftRadius
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
		/// Single borderTopRightRadius
		/// </summary>
		protected RSystem.RSingle r_borderTopRightRadius;
		public virtual RSystem.RSingle RborderTopRightRadius
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
		/// Single borderTopWidth
		/// </summary>
		protected RSystem.RSingle r_borderTopWidth;
		public virtual RSystem.RSingle RborderTopWidth
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
		/// Single bottom
		/// </summary>
		protected RSystem.RSingle r_bottom;
		public virtual RSystem.RSingle Rbottom
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
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
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
		/// UnityEngine.UIElements.DisplayStyle display
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
		/// UnityEngine.UIElements.StyleFloat flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_flexBasis;
		public virtual RUnityEngine.RUIElements.RStyleFloat RflexBasis
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
		/// UnityEngine.UIElements.FlexDirection flexDirection
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
		/// Single flexGrow
		/// </summary>
		protected RSystem.RSingle r_flexGrow;
		public virtual RSystem.RSingle RflexGrow
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
		/// Single flexShrink
		/// </summary>
		protected RSystem.RSingle r_flexShrink;
		public virtual RSystem.RSingle RflexShrink
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
		/// UnityEngine.UIElements.Wrap flexWrap
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
		/// Single fontSize
		/// </summary>
		protected RSystem.RSingle r_fontSize;
		public virtual RSystem.RSingle RfontSize
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
		/// Single height
		/// </summary>
		protected RSystem.RSingle r_height;
		public virtual RSystem.RSingle Rheight
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
		/// UnityEngine.UIElements.Justify justifyContent
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
		/// Single left
		/// </summary>
		protected RSystem.RSingle r_left;
		public virtual RSystem.RSingle Rleft
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
		/// Single letterSpacing
		/// </summary>
		protected RSystem.RSingle r_letterSpacing;
		public virtual RSystem.RSingle RletterSpacing
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
		/// Single marginBottom
		/// </summary>
		protected RSystem.RSingle r_marginBottom;
		public virtual RSystem.RSingle RmarginBottom
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
		/// Single marginLeft
		/// </summary>
		protected RSystem.RSingle r_marginLeft;
		public virtual RSystem.RSingle RmarginLeft
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
		/// Single marginRight
		/// </summary>
		protected RSystem.RSingle r_marginRight;
		public virtual RSystem.RSingle RmarginRight
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
		/// Single marginTop
		/// </summary>
		protected RSystem.RSingle r_marginTop;
		public virtual RSystem.RSingle RmarginTop
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
		/// UnityEngine.UIElements.StyleFloat maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_maxHeight;
		public virtual RUnityEngine.RUIElements.RStyleFloat RmaxHeight
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
		/// UnityEngine.UIElements.StyleFloat maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_maxWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RmaxWidth
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
		/// UnityEngine.UIElements.StyleFloat minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_minHeight;
		public virtual RUnityEngine.RUIElements.RStyleFloat RminHeight
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
		/// UnityEngine.UIElements.StyleFloat minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_minWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RminWidth
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
		/// Single opacity
		/// </summary>
		protected RSystem.RSingle r_opacity;
		public virtual RSystem.RSingle Ropacity
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
		/// Single paddingBottom
		/// </summary>
		protected RSystem.RSingle r_paddingBottom;
		public virtual RSystem.RSingle RpaddingBottom
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
		/// Single paddingLeft
		/// </summary>
		protected RSystem.RSingle r_paddingLeft;
		public virtual RSystem.RSingle RpaddingLeft
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
		/// Single paddingRight
		/// </summary>
		protected RSystem.RSingle r_paddingRight;
		public virtual RSystem.RSingle RpaddingRight
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
		/// Single paddingTop
		/// </summary>
		protected RSystem.RSingle r_paddingTop;
		public virtual RSystem.RSingle RpaddingTop
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
		/// UnityEngine.UIElements.Position position
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
		/// Single right
		/// </summary>
		protected RSystem.RSingle r_right;
		public virtual RSystem.RSingle Rright
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
		/// UnityEngine.UIElements.Rotate rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RRotate r_rotate;
		public virtual RUnityEngine.RUIElements.RRotate Rrotate
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
		/// UnityEngine.UIElements.Scale scale
		/// </summary>
		protected RUnityEngine.RUIElements.RScale r_scale;
		public virtual RUnityEngine.RUIElements.RScale Rscale
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
		/// UnityEngine.UIElements.TextOverflow textOverflow
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
		/// Single top
		/// </summary>
		protected RSystem.RSingle r_top;
		public virtual RSystem.RSingle Rtop
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
		/// UnityEngine.Vector3 transformOrigin
		/// </summary>
		protected RUnityEngine.RVector3 r_transformOrigin;
		public virtual RUnityEngine.RVector3 RtransformOrigin
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
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> r_transitionDelay;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> RtransitionDelay
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
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> r_transitionDuration;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> RtransitionDuration
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
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStylePropertyName> r_transitionProperty;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStylePropertyName> RtransitionProperty
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
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.REasingFunction> r_transitionTimingFunction;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.REasingFunction> RtransitionTimingFunction
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
		/// UnityEngine.Vector3 translate
		/// </summary>
		protected RUnityEngine.RVector3 r_translate;
		public virtual RUnityEngine.RVector3 Rtranslate
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
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_unityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RunityBackgroundImageTintColor
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
		/// UnityEngine.Font unityFont
		/// </summary>
		protected RUnityEngine.RFont r_unityFont;
		public virtual RUnityEngine.RFont RunityFont
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
		/// UnityEngine.UIElements.FontDefinition unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RFontDefinition r_unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RFontDefinition RunityFontDefinition
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
		/// UnityEngine.FontStyle unityFontStyleAndWeight
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
		/// Single unityParagraphSpacing
		/// </summary>
		protected RSystem.RSingle r_unityParagraphSpacing;
		public virtual RSystem.RSingle RunityParagraphSpacing
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
		/// Int32 unitySliceBottom
		/// </summary>
		protected RSystem.RInt32 r_unitySliceBottom;
		public virtual RSystem.RInt32 RunitySliceBottom
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
		/// Int32 unitySliceLeft
		/// </summary>
		protected RSystem.RInt32 r_unitySliceLeft;
		public virtual RSystem.RInt32 RunitySliceLeft
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
		/// Int32 unitySliceRight
		/// </summary>
		protected RSystem.RInt32 r_unitySliceRight;
		public virtual RSystem.RInt32 RunitySliceRight
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
		/// Single unitySliceScale
		/// </summary>
		protected RSystem.RSingle r_unitySliceScale;
		public virtual RSystem.RSingle RunitySliceScale
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
		/// Int32 unitySliceTop
		/// </summary>
		protected RSystem.RInt32 r_unitySliceTop;
		public virtual RSystem.RInt32 RunitySliceTop
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
		/// UnityEngine.TextAnchor unityTextAlign
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
		/// UnityEngine.Color unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RColor r_unityTextOutlineColor;
		public virtual RUnityEngine.RColor RunityTextOutlineColor
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
		/// Single unityTextOutlineWidth
		/// </summary>
		protected RSystem.RSingle r_unityTextOutlineWidth;
		public virtual RSystem.RSingle RunityTextOutlineWidth
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
		/// UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition
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
		/// UnityEngine.UIElements.Visibility visibility
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
		/// UnityEngine.UIElements.WhiteSpace whiteSpace
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
		/// Single width
		/// </summary>
		protected RSystem.RSingle r_width;
		public virtual RSystem.RSingle Rwidth
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
		/// Single wordSpacing
		/// </summary>
		protected RSystem.RSingle r_wordSpacing;
		public virtual RSystem.RSingle RwordSpacing
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
		protected RUnityEngine.RUIElements.RStyleEnum<RProperty> r_unityBackgroundScaleMode;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RProperty> RunityBackgroundScaleMode
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


        public RIResolvedStyle() : base("UnityEngine.UIElements.IResolvedStyle")
        {
        }

        public RIResolvedStyle(System.Object instance) : base("UnityEngine.UIElements.IResolvedStyle")
		{
            SetInstance(instance);
		}

        public RIResolvedStyle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIResolvedStyle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
