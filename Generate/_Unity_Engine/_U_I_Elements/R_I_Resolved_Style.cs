
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IResolvedStyle
	/// </summary>
    public partial class RIResolvedStyle : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Align alignContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_PalignContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RPalignContent
		{
			get
			{
				if(r_PalignContent == null)
				{
					r_PalignContent = new(this, "alignContent", -1);
					r_PalignContent.SetBelong(this.GetValue());
				}
				return r_PalignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_PalignItems;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RPalignItems
		{
			get
			{
				if(r_PalignItems == null)
				{
					r_PalignItems = new(this, "alignItems", -1);
					r_PalignItems.SetBelong(this.GetValue());
				}
				return r_PalignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_PalignSelf;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RPalignSelf
		{
			get
			{
				if(r_PalignSelf == null)
				{
					r_PalignSelf = new(this, "alignSelf", -1);
					r_PalignSelf.SetBelong(this.GetValue());
				}
				return r_PalignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PbackgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPbackgroundColor
		{
			get
			{
				if(r_PbackgroundColor == null)
				{
					r_PbackgroundColor = new(this, "backgroundColor", -1);
					r_PbackgroundColor.SetBelong(this.GetValue());
				}
				return r_PbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background backgroundImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground r_PbackgroundImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground RPbackgroundImage
		{
			get
			{
				if(r_PbackgroundImage == null)
				{
					r_PbackgroundImage = new(this, "backgroundImage", -1);
					r_PbackgroundImage.SetBelong(this.GetValue());
				}
				return r_PbackgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_PbackgroundPositionX;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RPbackgroundPositionX
		{
			get
			{
				if(r_PbackgroundPositionX == null)
				{
					r_PbackgroundPositionX = new(this, "backgroundPositionX", -1);
					r_PbackgroundPositionX.SetBelong(this.GetValue());
				}
				return r_PbackgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_PbackgroundPositionY;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RPbackgroundPositionY
		{
			get
			{
				if(r_PbackgroundPositionY == null)
				{
					r_PbackgroundPositionY = new(this, "backgroundPositionY", -1);
					r_PbackgroundPositionY.SetBelong(this.GetValue());
				}
				return r_PbackgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat r_PbackgroundRepeat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat RPbackgroundRepeat
		{
			get
			{
				if(r_PbackgroundRepeat == null)
				{
					r_PbackgroundRepeat = new(this, "backgroundRepeat", -1);
					r_PbackgroundRepeat.SetBelong(this.GetValue());
				}
				return r_PbackgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize r_PbackgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize RPbackgroundSize
		{
			get
			{
				if(r_PbackgroundSize == null)
				{
					r_PbackgroundSize = new(this, "backgroundSize", -1);
					r_PbackgroundSize.SetBelong(this.GetValue());
				}
				return r_PbackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderBottomColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PborderBottomColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPborderBottomColor
		{
			get
			{
				if(r_PborderBottomColor == null)
				{
					r_PborderBottomColor = new(this, "borderBottomColor", -1);
					r_PborderBottomColor.SetBelong(this.GetValue());
				}
				return r_PborderBottomColor;
			}
		}

		/// <summary>
		/// Single borderBottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderBottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderBottomLeftRadius
		{
			get
			{
				if(r_PborderBottomLeftRadius == null)
				{
					r_PborderBottomLeftRadius = new(this, "borderBottomLeftRadius", -1);
					r_PborderBottomLeftRadius.SetBelong(this.GetValue());
				}
				return r_PborderBottomLeftRadius;
			}
		}

		/// <summary>
		/// Single borderBottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderBottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderBottomRightRadius
		{
			get
			{
				if(r_PborderBottomRightRadius == null)
				{
					r_PborderBottomRightRadius = new(this, "borderBottomRightRadius", -1);
					r_PborderBottomRightRadius.SetBelong(this.GetValue());
				}
				return r_PborderBottomRightRadius;
			}
		}

		/// <summary>
		/// Single borderBottomWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderBottomWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderBottomWidth
		{
			get
			{
				if(r_PborderBottomWidth == null)
				{
					r_PborderBottomWidth = new(this, "borderBottomWidth", -1);
					r_PborderBottomWidth.SetBelong(this.GetValue());
				}
				return r_PborderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderLeftColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PborderLeftColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPborderLeftColor
		{
			get
			{
				if(r_PborderLeftColor == null)
				{
					r_PborderLeftColor = new(this, "borderLeftColor", -1);
					r_PborderLeftColor.SetBelong(this.GetValue());
				}
				return r_PborderLeftColor;
			}
		}

		/// <summary>
		/// Single borderLeftWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderLeftWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderLeftWidth
		{
			get
			{
				if(r_PborderLeftWidth == null)
				{
					r_PborderLeftWidth = new(this, "borderLeftWidth", -1);
					r_PborderLeftWidth.SetBelong(this.GetValue());
				}
				return r_PborderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderRightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PborderRightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPborderRightColor
		{
			get
			{
				if(r_PborderRightColor == null)
				{
					r_PborderRightColor = new(this, "borderRightColor", -1);
					r_PborderRightColor.SetBelong(this.GetValue());
				}
				return r_PborderRightColor;
			}
		}

		/// <summary>
		/// Single borderRightWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderRightWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderRightWidth
		{
			get
			{
				if(r_PborderRightWidth == null)
				{
					r_PborderRightWidth = new(this, "borderRightWidth", -1);
					r_PborderRightWidth.SetBelong(this.GetValue());
				}
				return r_PborderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderTopColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PborderTopColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPborderTopColor
		{
			get
			{
				if(r_PborderTopColor == null)
				{
					r_PborderTopColor = new(this, "borderTopColor", -1);
					r_PborderTopColor.SetBelong(this.GetValue());
				}
				return r_PborderTopColor;
			}
		}

		/// <summary>
		/// Single borderTopLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderTopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderTopLeftRadius
		{
			get
			{
				if(r_PborderTopLeftRadius == null)
				{
					r_PborderTopLeftRadius = new(this, "borderTopLeftRadius", -1);
					r_PborderTopLeftRadius.SetBelong(this.GetValue());
				}
				return r_PborderTopLeftRadius;
			}
		}

		/// <summary>
		/// Single borderTopRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderTopRightRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderTopRightRadius
		{
			get
			{
				if(r_PborderTopRightRadius == null)
				{
					r_PborderTopRightRadius = new(this, "borderTopRightRadius", -1);
					r_PborderTopRightRadius.SetBelong(this.GetValue());
				}
				return r_PborderTopRightRadius;
			}
		}

		/// <summary>
		/// Single borderTopWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PborderTopWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPborderTopWidth
		{
			get
			{
				if(r_PborderTopWidth == null)
				{
					r_PborderTopWidth = new(this, "borderTopWidth", -1);
					r_PborderTopWidth.SetBelong(this.GetValue());
				}
				return r_PborderTopWidth;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pbottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
					r_Pbottom.SetBelong(this.GetValue());
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Pcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPcolor
		{
			get
			{
				if(r_Pcolor == null)
				{
					r_Pcolor = new(this, "color", -1);
					r_Pcolor.SetBelong(this.GetValue());
				}
				return r_Pcolor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle display
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle r_Pdisplay;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle RPdisplay
		{
			get
			{
				if(r_Pdisplay == null)
				{
					r_Pdisplay = new(this, "display", -1);
					r_Pdisplay.SetBelong(this.GetValue());
				}
				return r_Pdisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat flexBasis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PflexBasis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPflexBasis
		{
			get
			{
				if(r_PflexBasis == null)
				{
					r_PflexBasis = new(this, "flexBasis", -1);
					r_PflexBasis.SetBelong(this.GetValue());
				}
				return r_PflexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection flexDirection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection r_PflexDirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection RPflexDirection
		{
			get
			{
				if(r_PflexDirection == null)
				{
					r_PflexDirection = new(this, "flexDirection", -1);
					r_PflexDirection.SetBelong(this.GetValue());
				}
				return r_PflexDirection;
			}
		}

		/// <summary>
		/// Single flexGrow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PflexGrow;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPflexGrow
		{
			get
			{
				if(r_PflexGrow == null)
				{
					r_PflexGrow = new(this, "flexGrow", -1);
					r_PflexGrow.SetBelong(this.GetValue());
				}
				return r_PflexGrow;
			}
		}

		/// <summary>
		/// Single flexShrink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PflexShrink;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPflexShrink
		{
			get
			{
				if(r_PflexShrink == null)
				{
					r_PflexShrink = new(this, "flexShrink", -1);
					r_PflexShrink.SetBelong(this.GetValue());
				}
				return r_PflexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap flexWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap r_PflexWrap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap RPflexWrap
		{
			get
			{
				if(r_PflexWrap == null)
				{
					r_PflexWrap = new(this, "flexWrap", -1);
					r_PflexWrap.SetBelong(this.GetValue());
				}
				return r_PflexWrap;
			}
		}

		/// <summary>
		/// Single fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfontSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfontSize
		{
			get
			{
				if(r_PfontSize == null)
				{
					r_PfontSize = new(this, "fontSize", -1);
					r_PfontSize.SetBelong(this.GetValue());
				}
				return r_PfontSize;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
					r_Pheight.SetBelong(this.GetValue());
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify justifyContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify r_PjustifyContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify RPjustifyContent
		{
			get
			{
				if(r_PjustifyContent == null)
				{
					r_PjustifyContent = new(this, "justifyContent", -1);
					r_PjustifyContent.SetBelong(this.GetValue());
				}
				return r_PjustifyContent;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pleft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
					r_Pleft.SetBelong(this.GetValue());
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// Single letterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PletterSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPletterSpacing
		{
			get
			{
				if(r_PletterSpacing == null)
				{
					r_PletterSpacing = new(this, "letterSpacing", -1);
					r_PletterSpacing.SetBelong(this.GetValue());
				}
				return r_PletterSpacing;
			}
		}

		/// <summary>
		/// Single marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmarginBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
					r_PmarginBottom.SetBelong(this.GetValue());
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// Single marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmarginLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
					r_PmarginLeft.SetBelong(this.GetValue());
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// Single marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmarginRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
					r_PmarginRight.SetBelong(this.GetValue());
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// Single marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmarginTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
					r_PmarginTop.SetBelong(this.GetValue());
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PmaxHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPmaxHeight
		{
			get
			{
				if(r_PmaxHeight == null)
				{
					r_PmaxHeight = new(this, "maxHeight", -1);
					r_PmaxHeight.SetBelong(this.GetValue());
				}
				return r_PmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PmaxWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPmaxWidth
		{
			get
			{
				if(r_PmaxWidth == null)
				{
					r_PmaxWidth = new(this, "maxWidth", -1);
					r_PmaxWidth.SetBelong(this.GetValue());
				}
				return r_PmaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PminHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPminHeight
		{
			get
			{
				if(r_PminHeight == null)
				{
					r_PminHeight = new(this, "minHeight", -1);
					r_PminHeight.SetBelong(this.GetValue());
				}
				return r_PminHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PminWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPminWidth
		{
			get
			{
				if(r_PminWidth == null)
				{
					r_PminWidth = new(this, "minWidth", -1);
					r_PminWidth.SetBelong(this.GetValue());
				}
				return r_PminWidth;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Popacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
					r_Popacity.SetBelong(this.GetValue());
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Single paddingBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PpaddingBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpaddingBottom
		{
			get
			{
				if(r_PpaddingBottom == null)
				{
					r_PpaddingBottom = new(this, "paddingBottom", -1);
					r_PpaddingBottom.SetBelong(this.GetValue());
				}
				return r_PpaddingBottom;
			}
		}

		/// <summary>
		/// Single paddingLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PpaddingLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpaddingLeft
		{
			get
			{
				if(r_PpaddingLeft == null)
				{
					r_PpaddingLeft = new(this, "paddingLeft", -1);
					r_PpaddingLeft.SetBelong(this.GetValue());
				}
				return r_PpaddingLeft;
			}
		}

		/// <summary>
		/// Single paddingRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PpaddingRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpaddingRight
		{
			get
			{
				if(r_PpaddingRight == null)
				{
					r_PpaddingRight = new(this, "paddingRight", -1);
					r_PpaddingRight.SetBelong(this.GetValue());
				}
				return r_PpaddingRight;
			}
		}

		/// <summary>
		/// Single paddingTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PpaddingTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpaddingTop
		{
			get
			{
				if(r_PpaddingTop == null)
				{
					r_PpaddingTop = new(this, "paddingTop", -1);
					r_PpaddingTop.SetBelong(this.GetValue());
				}
				return r_PpaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.GetValue());
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pright;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
					r_Pright.SetBelong(this.GetValue());
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate rotate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRotate r_Protate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRotate RProtate
		{
			get
			{
				if(r_Protate == null)
				{
					r_Protate = new(this, "rotate", -1);
					r_Protate.SetBelong(this.GetValue());
				}
				return r_Protate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScale r_Pscale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScale RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
					r_Pscale.SetBelong(this.GetValue());
				}
				return r_Pscale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow textOverflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow r_PtextOverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow RPtextOverflow
		{
			get
			{
				if(r_PtextOverflow == null)
				{
					r_PtextOverflow = new(this, "textOverflow", -1);
					r_PtextOverflow.SetBelong(this.GetValue());
				}
				return r_PtextOverflow;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ptop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
					r_Ptop.SetBelong(this.GetValue());
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 transformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PtransformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPtransformOrigin
		{
			get
			{
				if(r_PtransformOrigin == null)
				{
					r_PtransformOrigin = new(this, "transformOrigin", -1);
					r_PtransformOrigin.SetBelong(this.GetValue());
				}
				return r_PtransformOrigin;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PtransitionDelay;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPtransitionDelay
		{
			get
			{
				if(r_PtransitionDelay == null)
				{
					r_PtransitionDelay = new(this, "transitionDelay", -1);
					r_PtransitionDelay.SetBelong(this.GetValue());
				}
				return r_PtransitionDelay;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PtransitionDuration;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPtransitionDuration
		{
			get
			{
				if(r_PtransitionDuration == null)
				{
					r_PtransitionDuration = new(this, "transitionDuration", -1);
					r_PtransitionDuration.SetBelong(this.GetValue());
				}
				return r_PtransitionDuration;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> r_PtransitionProperty;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> RPtransitionProperty
		{
			get
			{
				if(r_PtransitionProperty == null)
				{
					r_PtransitionProperty = new(this, "transitionProperty", -1);
					r_PtransitionProperty.SetBelong(this.GetValue());
				}
				return r_PtransitionProperty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> r_PtransitionTimingFunction;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> RPtransitionTimingFunction
		{
			get
			{
				if(r_PtransitionTimingFunction == null)
				{
					r_PtransitionTimingFunction = new(this, "transitionTimingFunction", -1);
					r_PtransitionTimingFunction.SetBelong(this.GetValue());
				}
				return r_PtransitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 translate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Ptranslate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPtranslate
		{
			get
			{
				if(r_Ptranslate == null)
				{
					r_Ptranslate = new(this, "translate", -1);
					r_Ptranslate.SetBelong(this.GetValue());
				}
				return r_Ptranslate;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PunityBackgroundImageTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPunityBackgroundImageTintColor
		{
			get
			{
				if(r_PunityBackgroundImageTintColor == null)
				{
					r_PunityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor", -1);
					r_PunityBackgroundImageTintColor.SetBelong(this.GetValue());
				}
				return r_PunityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.Font unityFont
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_PunityFont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RPunityFont
		{
			get
			{
				if(r_PunityFont == null)
				{
					r_PunityFont = new(this, "unityFont", -1);
					r_PunityFont.SetBelong(this.GetValue());
				}
				return r_PunityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition unityFontDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFontDefinition r_PunityFontDefinition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFontDefinition RPunityFontDefinition
		{
			get
			{
				if(r_PunityFontDefinition == null)
				{
					r_PunityFontDefinition = new(this, "unityFontDefinition", -1);
					r_PunityFontDefinition.SetBelong(this.GetValue());
				}
				return r_PunityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle unityFontStyleAndWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFontStyle r_PunityFontStyleAndWeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFontStyle RPunityFontStyleAndWeight
		{
			get
			{
				if(r_PunityFontStyleAndWeight == null)
				{
					r_PunityFontStyleAndWeight = new(this, "unityFontStyleAndWeight", -1);
					r_PunityFontStyleAndWeight.SetBelong(this.GetValue());
				}
				return r_PunityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// Single unityParagraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PunityParagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPunityParagraphSpacing
		{
			get
			{
				if(r_PunityParagraphSpacing == null)
				{
					r_PunityParagraphSpacing = new(this, "unityParagraphSpacing", -1);
					r_PunityParagraphSpacing.SetBelong(this.GetValue());
				}
				return r_PunityParagraphSpacing;
			}
		}

		/// <summary>
		/// Int32 unitySliceBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PunitySliceBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPunitySliceBottom
		{
			get
			{
				if(r_PunitySliceBottom == null)
				{
					r_PunitySliceBottom = new(this, "unitySliceBottom", -1);
					r_PunitySliceBottom.SetBelong(this.GetValue());
				}
				return r_PunitySliceBottom;
			}
		}

		/// <summary>
		/// Int32 unitySliceLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PunitySliceLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPunitySliceLeft
		{
			get
			{
				if(r_PunitySliceLeft == null)
				{
					r_PunitySliceLeft = new(this, "unitySliceLeft", -1);
					r_PunitySliceLeft.SetBelong(this.GetValue());
				}
				return r_PunitySliceLeft;
			}
		}

		/// <summary>
		/// Int32 unitySliceRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PunitySliceRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPunitySliceRight
		{
			get
			{
				if(r_PunitySliceRight == null)
				{
					r_PunitySliceRight = new(this, "unitySliceRight", -1);
					r_PunitySliceRight.SetBelong(this.GetValue());
				}
				return r_PunitySliceRight;
			}
		}

		/// <summary>
		/// Single unitySliceScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PunitySliceScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPunitySliceScale
		{
			get
			{
				if(r_PunitySliceScale == null)
				{
					r_PunitySliceScale = new(this, "unitySliceScale", -1);
					r_PunitySliceScale.SetBelong(this.GetValue());
				}
				return r_PunitySliceScale;
			}
		}

		/// <summary>
		/// Int32 unitySliceTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PunitySliceTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPunitySliceTop
		{
			get
			{
				if(r_PunitySliceTop == null)
				{
					r_PunitySliceTop = new(this, "unitySliceTop", -1);
					r_PunitySliceTop.SetBelong(this.GetValue());
				}
				return r_PunitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor unityTextAlign
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor r_PunityTextAlign;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor RPunityTextAlign
		{
			get
			{
				if(r_PunityTextAlign == null)
				{
					r_PunityTextAlign = new(this, "unityTextAlign", -1);
					r_PunityTextAlign.SetBelong(this.GetValue());
				}
				return r_PunityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityTextOutlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PunityTextOutlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPunityTextOutlineColor
		{
			get
			{
				if(r_PunityTextOutlineColor == null)
				{
					r_PunityTextOutlineColor = new(this, "unityTextOutlineColor", -1);
					r_PunityTextOutlineColor.SetBelong(this.GetValue());
				}
				return r_PunityTextOutlineColor;
			}
		}

		/// <summary>
		/// Single unityTextOutlineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PunityTextOutlineWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPunityTextOutlineWidth
		{
			get
			{
				if(r_PunityTextOutlineWidth == null)
				{
					r_PunityTextOutlineWidth = new(this, "unityTextOutlineWidth", -1);
					r_PunityTextOutlineWidth.SetBelong(this.GetValue());
				}
				return r_PunityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition r_PunityTextOverflowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition RPunityTextOverflowPosition
		{
			get
			{
				if(r_PunityTextOverflowPosition == null)
				{
					r_PunityTextOverflowPosition = new(this, "unityTextOverflowPosition", -1);
					r_PunityTextOverflowPosition.SetBelong(this.GetValue());
				}
				return r_PunityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Visibility visibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility r_Pvisibility;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility RPvisibility
		{
			get
			{
				if(r_Pvisibility == null)
				{
					r_Pvisibility = new(this, "visibility", -1);
					r_Pvisibility.SetBelong(this.GetValue());
				}
				return r_Pvisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.WhiteSpace whiteSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace r_PwhiteSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace RPwhiteSpace
		{
			get
			{
				if(r_PwhiteSpace == null)
				{
					r_PwhiteSpace = new(this, "whiteSpace", -1);
					r_PwhiteSpace.SetBelong(this.GetValue());
				}
				return r_PwhiteSpace;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
					r_Pwidth.SetBelong(this.GetValue());
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Single wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PwordSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPwordSpacing
		{
			get
			{
				if(r_PwordSpacing == null)
				{
					r_PwordSpacing = new(this, "wordSpacing", -1);
					r_PwordSpacing.SetBelong(this.GetValue());
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
					r_PunityBackgroundScaleMode.SetBelong(this.GetValue());
				}
				return r_PunityBackgroundScaleMode;
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
