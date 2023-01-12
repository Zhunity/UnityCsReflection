using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ComputedStyle
	/// </summary>
    public partial class RComputedStyle : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.InheritedData] inheritedData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RInheritedData> r_FinheritedData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RInheritedData> RFinheritedData
		{
			get
			{
				if(r_FinheritedData == null)
				{
					r_FinheritedData = new(this, "inheritedData");
					r_FinheritedData.SetBelong(this.instance);
				}
				return r_FinheritedData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.LayoutData] layoutData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RLayoutData> r_FlayoutData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RLayoutData> RFlayoutData
		{
			get
			{
				if(r_FlayoutData == null)
				{
					r_FlayoutData = new(this, "layoutData");
					r_FlayoutData.SetBelong(this.instance);
				}
				return r_FlayoutData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.RareData] rareData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RRareData> r_FrareData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RRareData> RFrareData
		{
			get
			{
				if(r_FrareData == null)
				{
					r_FrareData = new(this, "rareData");
					r_FrareData.SetBelong(this.instance);
				}
				return r_FrareData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.TransformData] transformData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransformData> r_FtransformData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransformData> RFtransformData
		{
			get
			{
				if(r_FtransformData == null)
				{
					r_FtransformData = new(this, "transformData");
					r_FtransformData.SetBelong(this.instance);
				}
				return r_FtransformData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.TransitionData] transitionData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransitionData> r_FtransitionData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransitionData> RFtransitionData
		{
			get
			{
				if(r_FtransitionData == null)
				{
					r_FtransitionData = new(this, "transitionData");
					r_FtransitionData.SetBelong(this.instance);
				}
				return r_FtransitionData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.VisualData] visualData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RVisualData> r_FvisualData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RVisualData> RFvisualData
		{
			get
			{
				if(r_FvisualData == null)
				{
					r_FvisualData = new(this, "visualData");
					r_FvisualData.SetBelong(this.instance);
				}
				return r_FvisualData;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_FyogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RFyogaNode
		{
			get
			{
				if(r_FyogaNode == null)
				{
					r_FyogaNode = new(this, "yogaNode");
					r_FyogaNode.SetBelong(this.instance);
				}
				return r_FyogaNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue] customProperties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_FcustomProperties;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RFcustomProperties
		{
			get
			{
				if(r_FcustomProperties == null)
				{
					r_FcustomProperties = new(this, "customProperties");
					r_FcustomProperties.SetBelong(this.instance);
				}
				return r_FcustomProperties;
			}
		}

		/// <summary>
		/// System.Int64 matchingRulesHash
		/// </summary>
		protected RSystem.RInt64 r_FmatchingRulesHash;
		public virtual RSystem.RInt64 RFmatchingRulesHash
		{
			get
			{
				if(r_FmatchingRulesHash == null)
				{
					r_FmatchingRulesHash = new(this, "matchingRulesHash");
					r_FmatchingRulesHash.SetBelong(this.instance);
				}
				return r_FmatchingRulesHash;
			}
		}

		/// <summary>
		/// System.Single dpiScaling
		/// </summary>
		protected RSystem.RSingle r_FdpiScaling;
		public virtual RSystem.RSingle RFdpiScaling
		{
			get
			{
				if(r_FdpiScaling == null)
				{
					r_FdpiScaling = new(this, "dpiScaling");
					r_FdpiScaling.SetBelong(this.instance);
				}
				return r_FdpiScaling;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RComputedTransitionProperty> r_FcomputedTransitions;
		public virtual RFieldArray<RUnityEngine.RUIElements.RComputedTransitionProperty> RFcomputedTransitions
		{
			get
			{
				if(r_FcomputedTransitions == null)
				{
					r_FcomputedTransitions = new(this, "computedTransitions");
					r_FcomputedTransitions.SetBelong(this.instance);
				}
				return r_FcomputedTransitions;
			}
		}

		/// <summary>
		/// Int32 customPropertiesCount
		/// </summary>
		protected RSystem.RInt32 r_PcustomPropertiesCount;
		public virtual RSystem.RInt32 RPcustomPropertiesCount
		{
			get
			{
				if(r_PcustomPropertiesCount == null)
				{
					r_PcustomPropertiesCount = new(this, "customPropertiesCount", -1);
					r_PcustomPropertiesCount.SetBelong(this.instance);
				}
				return r_PcustomPropertiesCount;
			}
		}

		/// <summary>
		/// Boolean hasTransition
		/// </summary>
		protected RSystem.RBoolean r_PhasTransition;
		public virtual RSystem.RBoolean RPhasTransition
		{
			get
			{
				if(r_PhasTransition == null)
				{
					r_PhasTransition = new(this, "hasTransition", -1);
					r_PhasTransition.SetBelong(this.instance);
				}
				return r_PhasTransition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignContent
		/// </summary>
		protected RUnityEngine.RUIElements.RAlign r_PalignContent;
		public virtual RUnityEngine.RUIElements.RAlign RPalignContent
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
		/// UnityEngine.UIElements.Align alignItems
		/// </summary>
		protected RUnityEngine.RUIElements.RAlign r_PalignItems;
		public virtual RUnityEngine.RUIElements.RAlign RPalignItems
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
		/// UnityEngine.UIElements.Align alignSelf
		/// </summary>
		protected RUnityEngine.RUIElements.RAlign r_PalignSelf;
		public virtual RUnityEngine.RUIElements.RAlign RPalignSelf
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
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_PbackgroundColor;
		public virtual RUnityEngine.RColor RPbackgroundColor
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
		/// UnityEngine.UIElements.Background backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_PbackgroundImage;
		public virtual RUnityEngine.RUIElements.RBackground RPbackgroundImage
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
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_PbackgroundPositionX;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RPbackgroundPositionX
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
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_PbackgroundPositionY;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RPbackgroundPositionY
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
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_PbackgroundRepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RPbackgroundRepeat
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
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_PbackgroundSize;
		public virtual RUnityEngine.RUIElements.RBackgroundSize RPbackgroundSize
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
		/// UnityEngine.Color borderBottomColor
		/// </summary>
		protected RUnityEngine.RColor r_PborderBottomColor;
		public virtual RUnityEngine.RColor RPborderBottomColor
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
		/// UnityEngine.UIElements.Length borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PborderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RLength RPborderBottomLeftRadius
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
		/// UnityEngine.UIElements.Length borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PborderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RLength RPborderBottomRightRadius
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
		/// Single borderBottomWidth
		/// </summary>
		protected RSystem.RSingle r_PborderBottomWidth;
		public virtual RSystem.RSingle RPborderBottomWidth
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
		/// UnityEngine.Color borderLeftColor
		/// </summary>
		protected RUnityEngine.RColor r_PborderLeftColor;
		public virtual RUnityEngine.RColor RPborderLeftColor
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
		/// Single borderLeftWidth
		/// </summary>
		protected RSystem.RSingle r_PborderLeftWidth;
		public virtual RSystem.RSingle RPborderLeftWidth
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
		/// UnityEngine.Color borderRightColor
		/// </summary>
		protected RUnityEngine.RColor r_PborderRightColor;
		public virtual RUnityEngine.RColor RPborderRightColor
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
		/// Single borderRightWidth
		/// </summary>
		protected RSystem.RSingle r_PborderRightWidth;
		public virtual RSystem.RSingle RPborderRightWidth
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
		/// UnityEngine.Color borderTopColor
		/// </summary>
		protected RUnityEngine.RColor r_PborderTopColor;
		public virtual RUnityEngine.RColor RPborderTopColor
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
		/// UnityEngine.UIElements.Length borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PborderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RLength RPborderTopLeftRadius
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
		/// UnityEngine.UIElements.Length borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PborderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RLength RPborderTopRightRadius
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
		/// Single borderTopWidth
		/// </summary>
		protected RSystem.RSingle r_PborderTopWidth;
		public virtual RSystem.RSingle RPborderTopWidth
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
		/// UnityEngine.UIElements.Length bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Pbottom;
		public virtual RUnityEngine.RUIElements.RLength RPbottom
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
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_Pcolor;
		public virtual RUnityEngine.RColor RPcolor
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
		/// UnityEngine.UIElements.Cursor cursor
		/// </summary>
		protected RUnityEngine.RUIElements.RCursor r_Pcursor;
		public virtual RUnityEngine.RUIElements.RCursor RPcursor
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
		/// UnityEngine.UIElements.DisplayStyle display
		/// </summary>
		protected RUnityEngine.RUIElements.RDisplayStyle r_Pdisplay;
		public virtual RUnityEngine.RUIElements.RDisplayStyle RPdisplay
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
		/// UnityEngine.UIElements.Length flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PflexBasis;
		public virtual RUnityEngine.RUIElements.RLength RPflexBasis
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
		/// UnityEngine.UIElements.FlexDirection flexDirection
		/// </summary>
		protected RUnityEngine.RUIElements.RFlexDirection r_PflexDirection;
		public virtual RUnityEngine.RUIElements.RFlexDirection RPflexDirection
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
		/// Single flexGrow
		/// </summary>
		protected RSystem.RSingle r_PflexGrow;
		public virtual RSystem.RSingle RPflexGrow
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
		/// Single flexShrink
		/// </summary>
		protected RSystem.RSingle r_PflexShrink;
		public virtual RSystem.RSingle RPflexShrink
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
		/// UnityEngine.UIElements.Wrap flexWrap
		/// </summary>
		protected RUnityEngine.RUIElements.RWrap r_PflexWrap;
		public virtual RUnityEngine.RUIElements.RWrap RPflexWrap
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
		/// UnityEngine.UIElements.Length fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PfontSize;
		public virtual RUnityEngine.RUIElements.RLength RPfontSize
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
		/// UnityEngine.UIElements.Length height
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Pheight;
		public virtual RUnityEngine.RUIElements.RLength RPheight
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
		/// UnityEngine.UIElements.Justify justifyContent
		/// </summary>
		protected RUnityEngine.RUIElements.RJustify r_PjustifyContent;
		public virtual RUnityEngine.RUIElements.RJustify RPjustifyContent
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
		/// UnityEngine.UIElements.Length left
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Pleft;
		public virtual RUnityEngine.RUIElements.RLength RPleft
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
		/// UnityEngine.UIElements.Length letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PletterSpacing;
		public virtual RUnityEngine.RUIElements.RLength RPletterSpacing
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
		/// UnityEngine.UIElements.Length marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PmarginBottom;
		public virtual RUnityEngine.RUIElements.RLength RPmarginBottom
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
		/// UnityEngine.UIElements.Length marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PmarginLeft;
		public virtual RUnityEngine.RUIElements.RLength RPmarginLeft
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
		/// UnityEngine.UIElements.Length marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PmarginRight;
		public virtual RUnityEngine.RUIElements.RLength RPmarginRight
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
		/// UnityEngine.UIElements.Length marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PmarginTop;
		public virtual RUnityEngine.RUIElements.RLength RPmarginTop
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
		/// UnityEngine.UIElements.Length maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PmaxHeight;
		public virtual RUnityEngine.RUIElements.RLength RPmaxHeight
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
		/// UnityEngine.UIElements.Length maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PmaxWidth;
		public virtual RUnityEngine.RUIElements.RLength RPmaxWidth
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
		/// UnityEngine.UIElements.Length minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PminHeight;
		public virtual RUnityEngine.RUIElements.RLength RPminHeight
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
		/// UnityEngine.UIElements.Length minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PminWidth;
		public virtual RUnityEngine.RUIElements.RLength RPminWidth
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
		/// Single opacity
		/// </summary>
		protected RSystem.RSingle r_Popacity;
		public virtual RSystem.RSingle RPopacity
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
		/// UnityEngine.UIElements.OverflowInternal overflow
		/// </summary>
		protected RUnityEngine.RUIElements.ROverflowInternal r_Poverflow;
		public virtual RUnityEngine.RUIElements.ROverflowInternal RPoverflow
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
		/// UnityEngine.UIElements.Length paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PpaddingBottom;
		public virtual RUnityEngine.RUIElements.RLength RPpaddingBottom
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
		/// UnityEngine.UIElements.Length paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PpaddingLeft;
		public virtual RUnityEngine.RUIElements.RLength RPpaddingLeft
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
		/// UnityEngine.UIElements.Length paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PpaddingRight;
		public virtual RUnityEngine.RUIElements.RLength RPpaddingRight
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
		/// UnityEngine.UIElements.Length paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PpaddingTop;
		public virtual RUnityEngine.RUIElements.RLength RPpaddingTop
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
		/// UnityEngine.UIElements.Position position
		/// </summary>
		protected RUnityEngine.RUIElements.RPosition r_Pposition;
		public virtual RUnityEngine.RUIElements.RPosition RPposition
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
		/// UnityEngine.UIElements.Length right
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Pright;
		public virtual RUnityEngine.RUIElements.RLength RPright
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
		/// UnityEngine.UIElements.Rotate rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RRotate r_Protate;
		public virtual RUnityEngine.RUIElements.RRotate RProtate
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
		/// UnityEngine.UIElements.Scale scale
		/// </summary>
		protected RUnityEngine.RUIElements.RScale r_Pscale;
		public virtual RUnityEngine.RUIElements.RScale RPscale
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
		/// UnityEngine.UIElements.TextOverflow textOverflow
		/// </summary>
		protected RUnityEngine.RUIElements.RTextOverflow r_PtextOverflow;
		public virtual RUnityEngine.RUIElements.RTextOverflow RPtextOverflow
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
		/// UnityEngine.UIElements.TextShadow textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RTextShadow r_PtextShadow;
		public virtual RUnityEngine.RUIElements.RTextShadow RPtextShadow
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
		/// UnityEngine.UIElements.Length top
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Ptop;
		public virtual RUnityEngine.RUIElements.RLength RPtop
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
		/// UnityEngine.UIElements.TransformOrigin transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RTransformOrigin r_PtransformOrigin;
		public virtual RUnityEngine.RUIElements.RTransformOrigin RPtransformOrigin
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> r_PtransitionDelay;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> RPtransitionDelay
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> r_PtransitionDuration;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> RPtransitionDuration
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStylePropertyName> r_PtransitionProperty;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStylePropertyName> RPtransitionProperty
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REasingFunction> r_PtransitionTimingFunction;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REasingFunction> RPtransitionTimingFunction
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
		/// UnityEngine.UIElements.Translate translate
		/// </summary>
		protected RUnityEngine.RUIElements.RTranslate r_Ptranslate;
		public virtual RUnityEngine.RUIElements.RTranslate RPtranslate
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
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_PunityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RPunityBackgroundImageTintColor
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
		/// UnityEngine.Font unityFont
		/// </summary>
		protected RUnityEngine.RFont r_PunityFont;
		public virtual RUnityEngine.RFont RPunityFont
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
		/// UnityEngine.UIElements.FontDefinition unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RFontDefinition r_PunityFontDefinition;
		public virtual RUnityEngine.RUIElements.RFontDefinition RPunityFontDefinition
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
		/// UnityEngine.FontStyle unityFontStyleAndWeight
		/// </summary>
		protected RUnityEngine.RFontStyle r_PunityFontStyleAndWeight;
		public virtual RUnityEngine.RFontStyle RPunityFontStyleAndWeight
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
		/// UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox
		/// </summary>
		protected RUnityEngine.RUIElements.ROverflowClipBox r_PunityOverflowClipBox;
		public virtual RUnityEngine.RUIElements.ROverflowClipBox RPunityOverflowClipBox
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
		/// UnityEngine.UIElements.Length unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PunityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RLength RPunityParagraphSpacing
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
		/// Int32 unitySliceBottom
		/// </summary>
		protected RSystem.RInt32 r_PunitySliceBottom;
		public virtual RSystem.RInt32 RPunitySliceBottom
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
		/// Int32 unitySliceLeft
		/// </summary>
		protected RSystem.RInt32 r_PunitySliceLeft;
		public virtual RSystem.RInt32 RPunitySliceLeft
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
		/// Int32 unitySliceRight
		/// </summary>
		protected RSystem.RInt32 r_PunitySliceRight;
		public virtual RSystem.RInt32 RPunitySliceRight
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
		/// Single unitySliceScale
		/// </summary>
		protected RSystem.RSingle r_PunitySliceScale;
		public virtual RSystem.RSingle RPunitySliceScale
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
		/// Int32 unitySliceTop
		/// </summary>
		protected RSystem.RInt32 r_PunitySliceTop;
		public virtual RSystem.RInt32 RPunitySliceTop
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
		/// UnityEngine.TextAnchor unityTextAlign
		/// </summary>
		protected RUnityEngine.RTextAnchor r_PunityTextAlign;
		public virtual RUnityEngine.RTextAnchor RPunityTextAlign
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
		/// UnityEngine.Color unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RColor r_PunityTextOutlineColor;
		public virtual RUnityEngine.RColor RPunityTextOutlineColor
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
		/// Single unityTextOutlineWidth
		/// </summary>
		protected RSystem.RSingle r_PunityTextOutlineWidth;
		public virtual RSystem.RSingle RPunityTextOutlineWidth
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
		/// UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition
		/// </summary>
		protected RUnityEngine.RUIElements.RTextOverflowPosition r_PunityTextOverflowPosition;
		public virtual RUnityEngine.RUIElements.RTextOverflowPosition RPunityTextOverflowPosition
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
		/// UnityEngine.UIElements.Visibility visibility
		/// </summary>
		protected RUnityEngine.RUIElements.RVisibility r_Pvisibility;
		public virtual RUnityEngine.RUIElements.RVisibility RPvisibility
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
		/// UnityEngine.UIElements.WhiteSpace whiteSpace
		/// </summary>
		protected RUnityEngine.RUIElements.RWhiteSpace r_PwhiteSpace;
		public virtual RUnityEngine.RUIElements.RWhiteSpace RPwhiteSpace
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
		/// UnityEngine.UIElements.Length width
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Pwidth;
		public virtual RUnityEngine.RUIElements.RLength RPwidth
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
		/// UnityEngine.UIElements.Length wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_PwordSpacing;
		public virtual RUnityEngine.RUIElements.RLength RPwordSpacing
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
		/// UnityEngine.UIElements.ComputedStyle Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "Create", 0);
					r_MCreate.SetBelong(null);
				}
				return r_MCreate;
			}
		}

		/// <summary>
		/// Void FinalizeApply(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MFinalizeApply_Ref_ComputedStyle;
		public virtual RMethod RMFinalizeApply_Ref_ComputedStyle
		{
			get
			{
				if(r_MFinalizeApply_Ref_ComputedStyle == null)
				{
					r_MFinalizeApply_Ref_ComputedStyle = new(this, "FinalizeApply", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MFinalizeApply_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MFinalizeApply_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void SyncWithLayout(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_MSyncWithLayout_YogaNode;
		public virtual RMethod RMSyncWithLayout_YogaNode
		{
			get
			{
				if(r_MSyncWithLayout_YogaNode == null)
				{
					r_MSyncWithLayout_YogaNode = new(this, "SyncWithLayout", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_MSyncWithLayout_YogaNode.SetBelong(this.instance);
				}
				return r_MSyncWithLayout_YogaNode;
			}
		}

		/// <summary>
		/// Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle;
		public virtual RMethod RMApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle == null)
				{
					r_MApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle = new(this, "ApplyGlobalKeyword", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleKeyword, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle;
		public virtual RMethod RMApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle == null)
				{
					r_MApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle = new(this, "ApplyGlobalKeyword", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleKeyword),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader)
		/// </summary>
		protected RMethod r_MRemoveCustomStyleProperty_StylePropertyReader;
		public virtual RMethod RMRemoveCustomStyleProperty_StylePropertyReader
		{
			get
			{
				if(r_MRemoveCustomStyleProperty_StylePropertyReader == null)
				{
					r_MRemoveCustomStyleProperty_StylePropertyReader = new(this, "RemoveCustomStyleProperty", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"));
					r_MRemoveCustomStyleProperty_StylePropertyReader.SetBelong(this.instance);
				}
				return r_MRemoveCustomStyleProperty_StylePropertyReader;
			}
		}

		/// <summary>
		/// Void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader)
		/// </summary>
		protected RMethod r_MApplyCustomStyleProperty_StylePropertyReader;
		public virtual RMethod RMApplyCustomStyleProperty_StylePropertyReader
		{
			get
			{
				if(r_MApplyCustomStyleProperty_StylePropertyReader == null)
				{
					r_MApplyCustomStyleProperty_StylePropertyReader = new(this, "ApplyCustomStyleProperty", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"));
					r_MApplyCustomStyleProperty_StylePropertyReader.SetBelong(this.instance);
				}
				return r_MApplyCustomStyleProperty_StylePropertyReader;
			}
		}

		/// <summary>
		/// Void ApplyAllPropertyInitial()
		/// </summary>
		protected RMethod r_MApplyAllPropertyInitial;
		public virtual RMethod RMApplyAllPropertyInitial
		{
			get
			{
				if(r_MApplyAllPropertyInitial == null)
				{
					r_MApplyAllPropertyInitial = new(this, "ApplyAllPropertyInitial", 0);
					r_MApplyAllPropertyInitial.SetBelong(this.instance);
				}
				return r_MApplyAllPropertyInitial;
			}
		}

		/// <summary>
		/// Void ResetComputedTransitions()
		/// </summary>
		protected RMethod r_MResetComputedTransitions;
		public virtual RMethod RMResetComputedTransitions
		{
			get
			{
				if(r_MResetComputedTransitions == null)
				{
					r_MResetComputedTransitions = new(this, "ResetComputedTransitions", 0);
					r_MResetComputedTransitions.SetBelong(this.instance);
				}
				return r_MResetComputedTransitions;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineTextShadow(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleTextShadow, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineTextShadow", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTextShadow), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineRotate(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleRotate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineRotate", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleRotate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleTranslate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineTranslate", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTranslate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineScale(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleScale, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineScale", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleScale), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineTransformOrigin(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleTransformOrigin, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTransformOrigin), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineBackgroundSize(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleBackgroundSize, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle Create(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected static RMethod r_MCreate_Ref_ComputedStyle;
		public static RMethod RMCreate_Ref_ComputedStyle
		{
			get
			{
				if(r_MCreate_Ref_ComputedStyle == null)
				{
					r_MCreate_Ref_ComputedStyle = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "Create", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MCreate_Ref_ComputedStyle.SetBelong(null);
				}
				return r_MCreate_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle CreateInitial()
		/// </summary>
		protected static RMethod r_MCreateInitial;
		public static RMethod RMCreateInitial
		{
			get
			{
				if(r_MCreateInitial == null)
				{
					r_MCreateInitial = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "CreateInitial", 0);
					r_MCreateInitial.SetBelong(null);
				}
				return r_MCreateInitial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle Acquire()
		/// </summary>
		protected RMethod r_MAcquire;
		public virtual RMethod RMAcquire
		{
			get
			{
				if(r_MAcquire == null)
				{
					r_MAcquire = new(this, "Acquire", 0);
					r_MAcquire.SetBelong(this.instance);
				}
				return r_MAcquire;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
					r_MRelease.SetBelong(this.instance);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_ComputedStyle;
		public virtual RMethod RMCopyFrom_Ref_ComputedStyle
		{
			get
			{
				if(r_MCopyFrom_Ref_ComputedStyle == null)
				{
					r_MCopyFrom_Ref_ComputedStyle = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MCopyFrom_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MCopyFrom_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyProperties_StylePropertyReader_Ref_ComputedStyle;
		public virtual RMethod RMApplyProperties_StylePropertyReader_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyProperties_StylePropertyReader_Ref_ComputedStyle == null)
				{
					r_MApplyProperties_StylePropertyReader_Ref_ComputedStyle = new(this, "ApplyProperties", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyProperties_StylePropertyReader_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyProperties_StylePropertyReader_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyStyleValue_StyleValue_Ref_ComputedStyle;
		public virtual RMethod RMApplyStyleValue_StyleValue_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyStyleValue_StyleValue_Ref_ComputedStyle == null)
				{
					r_MApplyStyleValue_StyleValue_Ref_ComputedStyle = new(this, "ApplyStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyStyleValue_StyleValue_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyStyleValue_StyleValue_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle;
		public virtual RMethod RMApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle == null)
				{
					r_MApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle = new(this, "ApplyStyleValueManaged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyStyleCursor(UnityEngine.UIElements.Cursor)
		/// </summary>
		protected RMethod r_MApplyStyleCursor_Cursor;
		public virtual RMethod RMApplyStyleCursor_Cursor
		{
			get
			{
				if(r_MApplyStyleCursor_Cursor == null)
				{
					r_MApplyStyleCursor_Cursor = new(this, "ApplyStyleCursor", 0, typeof(UnityEngine.UIElements.Cursor));
					r_MApplyStyleCursor_Cursor.SetBelong(this.instance);
				}
				return r_MApplyStyleCursor_Cursor;
			}
		}

		/// <summary>
		/// Void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected RMethod r_MApplyStyleTextShadow_TextShadow;
		public virtual RMethod RMApplyStyleTextShadow_TextShadow
		{
			get
			{
				if(r_MApplyStyleTextShadow_TextShadow == null)
				{
					r_MApplyStyleTextShadow_TextShadow = new(this, "ApplyStyleTextShadow", 0, typeof(UnityEngine.UIElements.TextShadow));
					r_MApplyStyleTextShadow_TextShadow.SetBelong(this.instance);
				}
				return r_MApplyStyleTextShadow_TextShadow;
			}
		}

		/// <summary>
		/// Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RMApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyFromComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Length;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Length
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Length == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Length = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Length.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Length;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, Single)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Single;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Single
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Single == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Single = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Single.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Single;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Int32;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Int32
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Int32 == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Int32 = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Int32.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Int32;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundPosition));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundSize));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Color;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Color
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Color == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Color = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Color.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Color;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Background)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Background;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Background
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Background == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Background = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Background));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Background.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Background;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Font)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Font;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Font
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Font == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Font = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Font));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Font.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Font;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.FontDefinition));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TextShadow));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Translate)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Translate;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Translate
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Translate == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Translate = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Translate));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Translate.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Translate;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TransformOrigin));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Rotate)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Rotate));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Scale)
		/// </summary>
		protected RMethod r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Scale;
		public virtual RMethod RMApplyPropertyAnimation_VisualElement_StylePropertyId_Scale
		{
			get
			{
				if(r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Scale == null)
				{
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Scale = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Scale));
					r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Scale.SetBelong(this.instance);
				}
				return r_MApplyPropertyAnimation_VisualElement_StylePropertyId_Scale;
			}
		}

		/// <summary>
		/// Boolean StartAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.ComputedStyle ByRef, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.ComputedStyle ByRef, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationAllProperty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleSheets.StyleValue, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_MStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RMStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInline", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_MStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected RMethod r_MApplyStyleTransformOrigin_TransformOrigin;
		public virtual RMethod RMApplyStyleTransformOrigin_TransformOrigin
		{
			get
			{
				if(r_MApplyStyleTransformOrigin_TransformOrigin == null)
				{
					r_MApplyStyleTransformOrigin_TransformOrigin = new(this, "ApplyStyleTransformOrigin", 0, typeof(UnityEngine.UIElements.TransformOrigin));
					r_MApplyStyleTransformOrigin_TransformOrigin.SetBelong(this.instance);
				}
				return r_MApplyStyleTransformOrigin_TransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyStyleTranslate(UnityEngine.UIElements.Translate)
		/// </summary>
		protected RMethod r_MApplyStyleTranslate_Translate;
		public virtual RMethod RMApplyStyleTranslate_Translate
		{
			get
			{
				if(r_MApplyStyleTranslate_Translate == null)
				{
					r_MApplyStyleTranslate_Translate = new(this, "ApplyStyleTranslate", 0, typeof(UnityEngine.UIElements.Translate));
					r_MApplyStyleTranslate_Translate.SetBelong(this.instance);
				}
				return r_MApplyStyleTranslate_Translate;
			}
		}

		/// <summary>
		/// Void ApplyStyleRotate(UnityEngine.UIElements.Rotate)
		/// </summary>
		protected RMethod r_MApplyStyleRotate_Rotate;
		public virtual RMethod RMApplyStyleRotate_Rotate
		{
			get
			{
				if(r_MApplyStyleRotate_Rotate == null)
				{
					r_MApplyStyleRotate_Rotate = new(this, "ApplyStyleRotate", 0, typeof(UnityEngine.UIElements.Rotate));
					r_MApplyStyleRotate_Rotate.SetBelong(this.instance);
				}
				return r_MApplyStyleRotate_Rotate;
			}
		}

		/// <summary>
		/// Void ApplyStyleScale(UnityEngine.UIElements.Scale)
		/// </summary>
		protected RMethod r_MApplyStyleScale_Scale;
		public virtual RMethod RMApplyStyleScale_Scale
		{
			get
			{
				if(r_MApplyStyleScale_Scale == null)
				{
					r_MApplyStyleScale_Scale = new(this, "ApplyStyleScale", 0, typeof(UnityEngine.UIElements.Scale));
					r_MApplyStyleScale_Scale.SetBelong(this.instance);
				}
				return r_MApplyStyleScale_Scale;
			}
		}

		/// <summary>
		/// Void ApplyStyleBackgroundSize(UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected RMethod r_MApplyStyleBackgroundSize_BackgroundSize;
		public virtual RMethod RMApplyStyleBackgroundSize_BackgroundSize
		{
			get
			{
				if(r_MApplyStyleBackgroundSize_BackgroundSize == null)
				{
					r_MApplyStyleBackgroundSize_BackgroundSize = new(this, "ApplyStyleBackgroundSize", 0, typeof(UnityEngine.UIElements.BackgroundSize));
					r_MApplyStyleBackgroundSize_BackgroundSize.SetBelong(this.instance);
				}
				return r_MApplyStyleBackgroundSize_BackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader)
		/// </summary>
		protected RMethod r_MApplyInitialValue_StylePropertyReader;
		public virtual RMethod RMApplyInitialValue_StylePropertyReader
		{
			get
			{
				if(r_MApplyInitialValue_StylePropertyReader == null)
				{
					r_MApplyInitialValue_StylePropertyReader = new(this, "ApplyInitialValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"));
					r_MApplyInitialValue_StylePropertyReader.SetBelong(this.instance);
				}
				return r_MApplyInitialValue_StylePropertyReader;
			}
		}

		/// <summary>
		/// Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MApplyInitialValue_StylePropertyId;
		public virtual RMethod RMApplyInitialValue_StylePropertyId
		{
			get
			{
				if(r_MApplyInitialValue_StylePropertyId == null)
				{
					r_MApplyInitialValue_StylePropertyId = new(this, "ApplyInitialValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_MApplyInitialValue_StylePropertyId.SetBelong(this.instance);
				}
				return r_MApplyInitialValue_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle;
		public virtual RMethod RMApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle == null)
				{
					r_MApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle = new(this, "ApplyUnsetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MApplyUnsetValue_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RMApplyUnsetValue_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_MApplyUnsetValue_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_MApplyUnsetValue_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyUnsetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MApplyUnsetValue_StylePropertyId_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MApplyUnsetValue_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType CompareChanges(UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected static RMethod r_MCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle;
		public static RMethod RMCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_MCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle == null)
				{
					r_MCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "CompareChanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle.SetBelong(null);
				}
				return r_MCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle;
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


        public RComputedStyle() : base("UnityEngine.UIElements.ComputedStyle")
        {
        }

        public RComputedStyle(System.Object instance) : base("UnityEngine.UIElements.ComputedStyle")
		{
            SetInstance(instance);
		}

        public RComputedStyle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RComputedStyle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RUnityEngine.RUIElements.RComputedStyle Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RComputedStyle(___result);
        }


        public virtual void FinalizeApply(ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentStyle.Value};
            var ___result = RMFinalizeApply_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void SyncWithLayout(RUnityEngine.RYoga.RYogaNode @targetNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNode.Value};
            var ___result = RMSyncWithLayout_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ApplyGlobalKeyword(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RMApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ApplyGlobalKeyword(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleKeyword @keyword, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @keyword, @parentStyle.Value};
            var ___result = RMApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);

            return (System.Boolean)___result;
        }


        public virtual void RemoveCustomStyleProperty(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RMRemoveCustomStyleProperty_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyCustomStyleProperty(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RMApplyCustomStyleProperty_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyAllPropertyInitial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyAllPropertyInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetComputedTransitions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetComputedTransitions.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean StartAnimationInlineTextShadow(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleTextShadow @textShadow, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @textShadow, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineRotate(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleRotate @rotate, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @rotate, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleTranslate @translate, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @translate, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineScale(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleScale @scale, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @scale, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineTransformOrigin(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleTransformOrigin @transformOrigin, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @transformOrigin, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineBackgroundSize(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleBackgroundSize @backgroundSize, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @backgroundSize, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static RUnityEngine.RUIElements.RComputedStyle Create(ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentStyle.Value};
            var ___result = RMCreate_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            return new RUnityEngine.RUIElements.RComputedStyle(___result);
        }


        public static RUnityEngine.RUIElements.RComputedStyle CreateInitial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateInitial.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RComputedStyle(___result);
        }


        public virtual RUnityEngine.RUIElements.RComputedStyle Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcquire.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RComputedStyle(___result);
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(ref RUnityEngine.RUIElements.RComputedStyle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@other = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void ApplyProperties(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RMApplyProperties_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyStyleValue(RUnityEngine.RUIElements.RStyleSheets.RStyleValue @sv, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value, @parentStyle.Value};
            var ___result = RMApplyStyleValue_StyleValue_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyStyleValueManaged(RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged @sv, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value, @parentStyle.Value};
            var ___result = RMApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyStyleCursor(UnityEngine.UIElements.Cursor @cursor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursor};
            var ___result = RMApplyStyleCursor_Cursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RMApplyStyleTextShadow_TextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyFromComputedStyle(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref RUnityEngine.RUIElements.RComputedStyle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @other.Value};
            var ___result = RMApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@other = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Length @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Length.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Single @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundPosition @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundRepeat @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundSize @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Color @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Background @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Background.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Font @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Font.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.FontDefinition @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TextShadow @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Translate @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Translate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TransformOrigin @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Rotate @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Scale @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Scale.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean StartAnimation(UnityEngine.UIElements.VisualElement @element, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref RUnityEngine.RUIElements.RComputedStyle @oldStyle, ref RUnityEngine.RUIElements.RComputedStyle @newStyle, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @id.Value, @oldStyle.Value, @newStyle.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@oldStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[3]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement @element, ref RUnityEngine.RUIElements.RComputedStyle @oldStyle, ref RUnityEngine.RUIElements.RComputedStyle @newStyle, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @oldStyle.Value, @newStyle.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@oldStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement @element, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref RUnityEngine.RUIElements.RComputedStyle @computedStyle, RUnityEngine.RUIElements.RStyleSheets.RStyleValue @sv, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @id.Value, @computedStyle.Value, @sv.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RMApplyStyleTransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleTranslate(UnityEngine.UIElements.Translate @translateValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translateValue};
            var ___result = RMApplyStyleTranslate_Translate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleRotate(UnityEngine.UIElements.Rotate @rotateValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotateValue};
            var ___result = RMApplyStyleRotate_Rotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleScale(UnityEngine.UIElements.Scale @scaleValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scaleValue};
            var ___result = RMApplyStyleScale_Scale.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleBackgroundSize(UnityEngine.UIElements.BackgroundSize @backgroundSizeValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@backgroundSizeValue};
            var ___result = RMApplyStyleBackgroundSize_BackgroundSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyInitialValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RMApplyInitialValue_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyInitialValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMApplyInitialValue_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyUnsetValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RMApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyUnsetValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @parentStyle.Value};
            var ___result = RMApplyUnsetValue_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public static RUnityEngine.RUIElements.RVersionChangeType CompareChanges(ref RUnityEngine.RUIElements.RComputedStyle @x, ref RUnityEngine.RUIElements.RComputedStyle @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = RMCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@x = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);
			@y = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return new RUnityEngine.RUIElements.RVersionChangeType(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
