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
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RInheritedData> r_inheritedData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RInheritedData> RinheritedData
		{
			get
			{
				if(r_inheritedData == null)
				{
					r_inheritedData = new(this, "inheritedData");
					r_inheritedData.SetBelong(this.instance);
				}
				return r_inheritedData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.LayoutData] layoutData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RLayoutData> r_layoutData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RLayoutData> RlayoutData
		{
			get
			{
				if(r_layoutData == null)
				{
					r_layoutData = new(this, "layoutData");
					r_layoutData.SetBelong(this.instance);
				}
				return r_layoutData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.RareData] rareData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RRareData> r_rareData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RRareData> RrareData
		{
			get
			{
				if(r_rareData == null)
				{
					r_rareData = new(this, "rareData");
					r_rareData.SetBelong(this.instance);
				}
				return r_rareData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.TransformData] transformData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransformData> r_transformData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransformData> RtransformData
		{
			get
			{
				if(r_transformData == null)
				{
					r_transformData = new(this, "transformData");
					r_transformData.SetBelong(this.instance);
				}
				return r_transformData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.TransitionData] transitionData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransitionData> r_transitionData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RTransitionData> RtransitionData
		{
			get
			{
				if(r_transitionData == null)
				{
					r_transitionData = new(this, "transitionData");
					r_transitionData.SetBelong(this.instance);
				}
				return r_transitionData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.VisualData] visualData
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RVisualData> r_visualData;
		public virtual RUnityEngine.RUIElements.RStyleDataRef<RUnityEngine.RUIElements.RVisualData> RvisualData
		{
			get
			{
				if(r_visualData == null)
				{
					r_visualData = new(this, "visualData");
					r_visualData.SetBelong(this.instance);
				}
				return r_visualData;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_yogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RyogaNode
		{
			get
			{
				if(r_yogaNode == null)
				{
					r_yogaNode = new(this, "yogaNode");
					r_yogaNode.SetBelong(this.instance);
				}
				return r_yogaNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue] customProperties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_customProperties;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RcustomProperties
		{
			get
			{
				if(r_customProperties == null)
				{
					r_customProperties = new(this, "customProperties");
					r_customProperties.SetBelong(this.instance);
				}
				return r_customProperties;
			}
		}

		/// <summary>
		/// System.Int64 matchingRulesHash
		/// </summary>
		protected RField r_matchingRulesHash;
		public virtual RField RmatchingRulesHash
		{
			get
			{
				if(r_matchingRulesHash == null)
				{
					r_matchingRulesHash = new(this, "matchingRulesHash");
					r_matchingRulesHash.SetBelong(this.instance);
				}
				return r_matchingRulesHash;
			}
		}

		/// <summary>
		/// System.Single dpiScaling
		/// </summary>
		protected RField r_dpiScaling;
		public virtual RField RdpiScaling
		{
			get
			{
				if(r_dpiScaling == null)
				{
					r_dpiScaling = new(this, "dpiScaling");
					r_dpiScaling.SetBelong(this.instance);
				}
				return r_dpiScaling;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RComputedTransitionProperty> r_computedTransitions;
		public virtual RFieldArray<RUnityEngine.RUIElements.RComputedTransitionProperty> RcomputedTransitions
		{
			get
			{
				if(r_computedTransitions == null)
				{
					r_computedTransitions = new(this, "computedTransitions");
					r_computedTransitions.SetBelong(this.instance);
				}
				return r_computedTransitions;
			}
		}

		/// <summary>
		/// Int32 customPropertiesCount
		/// </summary>
		protected RProperty r_customPropertiesCount;
		public virtual RProperty RcustomPropertiesCount
		{
			get
			{
				if(r_customPropertiesCount == null)
				{
					r_customPropertiesCount = new(this, "customPropertiesCount", -1);
					r_customPropertiesCount.SetBelong(this.instance);
				}
				return r_customPropertiesCount;
			}
		}

		/// <summary>
		/// Boolean hasTransition
		/// </summary>
		protected RProperty r_hasTransition;
		public virtual RProperty RhasTransition
		{
			get
			{
				if(r_hasTransition == null)
				{
					r_hasTransition = new(this, "hasTransition", -1);
					r_hasTransition.SetBelong(this.instance);
				}
				return r_hasTransition;
			}
		}

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
		/// UnityEngine.UIElements.Length borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderBottomLeftRadius
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
		/// UnityEngine.UIElements.Length borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderBottomRightRadius
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
		protected RProperty r_borderBottomWidth;
		public virtual RProperty RborderBottomWidth
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
		protected RProperty r_borderLeftWidth;
		public virtual RProperty RborderLeftWidth
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
		protected RProperty r_borderRightWidth;
		public virtual RProperty RborderRightWidth
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
		/// UnityEngine.UIElements.Length borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderTopLeftRadius
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
		/// UnityEngine.UIElements.Length borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderTopRightRadius
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
		protected RProperty r_borderTopWidth;
		public virtual RProperty RborderTopWidth
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
		/// UnityEngine.UIElements.Length bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_bottom;
		public virtual RUnityEngine.RUIElements.RLength Rbottom
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
		/// UnityEngine.UIElements.Cursor cursor
		/// </summary>
		protected RUnityEngine.RUIElements.RCursor r_cursor;
		public virtual RUnityEngine.RUIElements.RCursor Rcursor
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
		/// UnityEngine.UIElements.Length flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_flexBasis;
		public virtual RUnityEngine.RUIElements.RLength RflexBasis
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
		protected RProperty r_flexGrow;
		public virtual RProperty RflexGrow
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
		protected RProperty r_flexShrink;
		public virtual RProperty RflexShrink
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
		/// UnityEngine.UIElements.Length fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_fontSize;
		public virtual RUnityEngine.RUIElements.RLength RfontSize
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
		/// UnityEngine.UIElements.Length height
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_height;
		public virtual RUnityEngine.RUIElements.RLength Rheight
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
		/// UnityEngine.UIElements.Length left
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_left;
		public virtual RUnityEngine.RUIElements.RLength Rleft
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
		/// UnityEngine.UIElements.Length letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_letterSpacing;
		public virtual RUnityEngine.RUIElements.RLength RletterSpacing
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
		/// UnityEngine.UIElements.Length marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginBottom;
		public virtual RUnityEngine.RUIElements.RLength RmarginBottom
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
		/// UnityEngine.UIElements.Length marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginLeft;
		public virtual RUnityEngine.RUIElements.RLength RmarginLeft
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
		/// UnityEngine.UIElements.Length marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginRight;
		public virtual RUnityEngine.RUIElements.RLength RmarginRight
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
		/// UnityEngine.UIElements.Length marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginTop;
		public virtual RUnityEngine.RUIElements.RLength RmarginTop
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
		/// UnityEngine.UIElements.Length maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_maxHeight;
		public virtual RUnityEngine.RUIElements.RLength RmaxHeight
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
		/// UnityEngine.UIElements.Length maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_maxWidth;
		public virtual RUnityEngine.RUIElements.RLength RmaxWidth
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
		/// UnityEngine.UIElements.Length minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_minHeight;
		public virtual RUnityEngine.RUIElements.RLength RminHeight
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
		/// UnityEngine.UIElements.Length minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_minWidth;
		public virtual RUnityEngine.RUIElements.RLength RminWidth
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
		protected RProperty r_opacity;
		public virtual RProperty Ropacity
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
		/// UnityEngine.UIElements.OverflowInternal overflow
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
		/// UnityEngine.UIElements.Length paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingBottom;
		public virtual RUnityEngine.RUIElements.RLength RpaddingBottom
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
		/// UnityEngine.UIElements.Length paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingLeft;
		public virtual RUnityEngine.RUIElements.RLength RpaddingLeft
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
		/// UnityEngine.UIElements.Length paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingRight;
		public virtual RUnityEngine.RUIElements.RLength RpaddingRight
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
		/// UnityEngine.UIElements.Length paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingTop;
		public virtual RUnityEngine.RUIElements.RLength RpaddingTop
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
		/// UnityEngine.UIElements.Length right
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_right;
		public virtual RUnityEngine.RUIElements.RLength Rright
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
		/// UnityEngine.UIElements.TextShadow textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RTextShadow r_textShadow;
		public virtual RUnityEngine.RUIElements.RTextShadow RtextShadow
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
		/// UnityEngine.UIElements.Length top
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_top;
		public virtual RUnityEngine.RUIElements.RLength Rtop
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
		/// UnityEngine.UIElements.TransformOrigin transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RTransformOrigin r_transformOrigin;
		public virtual RUnityEngine.RUIElements.RTransformOrigin RtransformOrigin
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> r_transitionDelay;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> RtransitionDelay
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> r_transitionDuration;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTimeValue> RtransitionDuration
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStylePropertyName> r_transitionProperty;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStylePropertyName> RtransitionProperty
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REasingFunction> r_transitionTimingFunction;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REasingFunction> RtransitionTimingFunction
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
		/// UnityEngine.UIElements.Translate translate
		/// </summary>
		protected RUnityEngine.RUIElements.RTranslate r_translate;
		public virtual RUnityEngine.RUIElements.RTranslate Rtranslate
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
		/// UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox
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
		/// UnityEngine.UIElements.Length unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_unityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RLength RunityParagraphSpacing
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
		protected RProperty r_unitySliceBottom;
		public virtual RProperty RunitySliceBottom
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
		protected RProperty r_unitySliceLeft;
		public virtual RProperty RunitySliceLeft
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
		protected RProperty r_unitySliceRight;
		public virtual RProperty RunitySliceRight
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
		protected RProperty r_unitySliceScale;
		public virtual RProperty RunitySliceScale
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
		protected RProperty r_unitySliceTop;
		public virtual RProperty RunitySliceTop
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
		protected RProperty r_unityTextOutlineWidth;
		public virtual RProperty RunityTextOutlineWidth
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
		/// UnityEngine.UIElements.Length width
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_width;
		public virtual RUnityEngine.RUIElements.RLength Rwidth
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
		/// UnityEngine.UIElements.Length wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_wordSpacing;
		public virtual RUnityEngine.RUIElements.RLength RwordSpacing
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
		/// UnityEngine.UIElements.ComputedStyle Create()
		/// </summary>
		protected static RMethod r_Create;
		public static RMethod RCreate
		{
			get
			{
				if(r_Create == null)
				{
					r_Create = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "Create", 0);
					r_Create.SetBelong(null);
				}
				return r_Create;
			}
		}

		/// <summary>
		/// Void FinalizeApply(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_FinalizeApply_Ref_ComputedStyle;
		public virtual RMethod RFinalizeApply_Ref_ComputedStyle
		{
			get
			{
				if(r_FinalizeApply_Ref_ComputedStyle == null)
				{
					r_FinalizeApply_Ref_ComputedStyle = new(this, "FinalizeApply", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_FinalizeApply_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_FinalizeApply_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void SyncWithLayout(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_SyncWithLayout_YogaNode;
		public virtual RMethod RSyncWithLayout_YogaNode
		{
			get
			{
				if(r_SyncWithLayout_YogaNode == null)
				{
					r_SyncWithLayout_YogaNode = new(this, "SyncWithLayout", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_SyncWithLayout_YogaNode.SetBelong(this.instance);
				}
				return r_SyncWithLayout_YogaNode;
			}
		}

		/// <summary>
		/// Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle;
		public virtual RMethod RApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle == null)
				{
					r_ApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle = new(this, "ApplyGlobalKeyword", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleKeyword, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle;
		public virtual RMethod RApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle == null)
				{
					r_ApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle = new(this, "ApplyGlobalKeyword", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.StyleKeyword),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader)
		/// </summary>
		protected RMethod r_RemoveCustomStyleProperty_StylePropertyReader;
		public virtual RMethod RRemoveCustomStyleProperty_StylePropertyReader
		{
			get
			{
				if(r_RemoveCustomStyleProperty_StylePropertyReader == null)
				{
					r_RemoveCustomStyleProperty_StylePropertyReader = new(this, "RemoveCustomStyleProperty", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"));
					r_RemoveCustomStyleProperty_StylePropertyReader.SetBelong(this.instance);
				}
				return r_RemoveCustomStyleProperty_StylePropertyReader;
			}
		}

		/// <summary>
		/// Void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader)
		/// </summary>
		protected RMethod r_ApplyCustomStyleProperty_StylePropertyReader;
		public virtual RMethod RApplyCustomStyleProperty_StylePropertyReader
		{
			get
			{
				if(r_ApplyCustomStyleProperty_StylePropertyReader == null)
				{
					r_ApplyCustomStyleProperty_StylePropertyReader = new(this, "ApplyCustomStyleProperty", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"));
					r_ApplyCustomStyleProperty_StylePropertyReader.SetBelong(this.instance);
				}
				return r_ApplyCustomStyleProperty_StylePropertyReader;
			}
		}

		/// <summary>
		/// Void ApplyAllPropertyInitial()
		/// </summary>
		protected RMethod r_ApplyAllPropertyInitial;
		public virtual RMethod RApplyAllPropertyInitial
		{
			get
			{
				if(r_ApplyAllPropertyInitial == null)
				{
					r_ApplyAllPropertyInitial = new(this, "ApplyAllPropertyInitial", 0);
					r_ApplyAllPropertyInitial.SetBelong(this.instance);
				}
				return r_ApplyAllPropertyInitial;
			}
		}

		/// <summary>
		/// Void ResetComputedTransitions()
		/// </summary>
		protected RMethod r_ResetComputedTransitions;
		public virtual RMethod RResetComputedTransitions
		{
			get
			{
				if(r_ResetComputedTransitions == null)
				{
					r_ResetComputedTransitions = new(this, "ResetComputedTransitions", 0);
					r_ResetComputedTransitions.SetBelong(this.instance);
				}
				return r_ResetComputedTransitions;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineTextShadow(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleTextShadow, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineTextShadow", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTextShadow), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineRotate(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleRotate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineRotate", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleRotate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleTranslate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineTranslate", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTranslate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineScale(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleScale, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineScale", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleScale), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineTransformOrigin(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleTransformOrigin, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTransformOrigin), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInlineBackgroundSize(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleBackgroundSize, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle Create(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected static RMethod r_Create_Ref_ComputedStyle;
		public static RMethod RCreate_Ref_ComputedStyle
		{
			get
			{
				if(r_Create_Ref_ComputedStyle == null)
				{
					r_Create_Ref_ComputedStyle = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "Create", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_Create_Ref_ComputedStyle.SetBelong(null);
				}
				return r_Create_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle CreateInitial()
		/// </summary>
		protected static RMethod r_CreateInitial;
		public static RMethod RCreateInitial
		{
			get
			{
				if(r_CreateInitial == null)
				{
					r_CreateInitial = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "CreateInitial", 0);
					r_CreateInitial.SetBelong(null);
				}
				return r_CreateInitial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle Acquire()
		/// </summary>
		protected RMethod r_Acquire;
		public virtual RMethod RAcquire
		{
			get
			{
				if(r_Acquire == null)
				{
					r_Acquire = new(this, "Acquire", 0);
					r_Acquire.SetBelong(this.instance);
				}
				return r_Acquire;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_Release;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_Release == null)
				{
					r_Release = new(this, "Release", 0);
					r_Release.SetBelong(this.instance);
				}
				return r_Release;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_CopyFrom_Ref_ComputedStyle;
		public virtual RMethod RCopyFrom_Ref_ComputedStyle
		{
			get
			{
				if(r_CopyFrom_Ref_ComputedStyle == null)
				{
					r_CopyFrom_Ref_ComputedStyle = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_CopyFrom_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_CopyFrom_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyProperties_StylePropertyReader_Ref_ComputedStyle;
		public virtual RMethod RApplyProperties_StylePropertyReader_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyProperties_StylePropertyReader_Ref_ComputedStyle == null)
				{
					r_ApplyProperties_StylePropertyReader_Ref_ComputedStyle = new(this, "ApplyProperties", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyProperties_StylePropertyReader_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyProperties_StylePropertyReader_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyStyleValue_StyleValue_Ref_ComputedStyle;
		public virtual RMethod RApplyStyleValue_StyleValue_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyStyleValue_StyleValue_Ref_ComputedStyle == null)
				{
					r_ApplyStyleValue_StyleValue_Ref_ComputedStyle = new(this, "ApplyStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyStyleValue_StyleValue_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyStyleValue_StyleValue_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle;
		public virtual RMethod RApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle == null)
				{
					r_ApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle = new(this, "ApplyStyleValueManaged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValueManaged"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyStyleCursor(UnityEngine.UIElements.Cursor)
		/// </summary>
		protected RMethod r_ApplyStyleCursor_Cursor;
		public virtual RMethod RApplyStyleCursor_Cursor
		{
			get
			{
				if(r_ApplyStyleCursor_Cursor == null)
				{
					r_ApplyStyleCursor_Cursor = new(this, "ApplyStyleCursor", 0, typeof(UnityEngine.UIElements.Cursor));
					r_ApplyStyleCursor_Cursor.SetBelong(this.instance);
				}
				return r_ApplyStyleCursor_Cursor;
			}
		}

		/// <summary>
		/// Void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected RMethod r_ApplyStyleTextShadow_TextShadow;
		public virtual RMethod RApplyStyleTextShadow_TextShadow
		{
			get
			{
				if(r_ApplyStyleTextShadow_TextShadow == null)
				{
					r_ApplyStyleTextShadow_TextShadow = new(this, "ApplyStyleTextShadow", 0, typeof(UnityEngine.UIElements.TextShadow));
					r_ApplyStyleTextShadow_TextShadow.SetBelong(this.instance);
				}
				return r_ApplyStyleTextShadow_TextShadow;
			}
		}

		/// <summary>
		/// Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyFromComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Length;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Length
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Length == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Length = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Length.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Length;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, Single)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Single;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Single
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Single == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Single = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Single.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Single;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Int32;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Int32
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Int32 == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Int32 = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Int32.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Int32;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundPosition));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundSize));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Color;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Color
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Color == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Color = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Color.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Color;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Background)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Background;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Background
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Background == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Background = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Background));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Background.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Background;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Font)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Font;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Font
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Font == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Font = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Font));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Font.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Font;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.FontDefinition));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TextShadow));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Translate)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Translate;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Translate
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Translate == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Translate = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Translate));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Translate.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Translate;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TransformOrigin));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Rotate)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Rotate));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate;
			}
		}

		/// <summary>
		/// Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Scale)
		/// </summary>
		protected RMethod r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Scale;
		public virtual RMethod RApplyPropertyAnimation_VisualElement_StylePropertyId_Scale
		{
			get
			{
				if(r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Scale == null)
				{
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Scale = new(this, "ApplyPropertyAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Scale));
					r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Scale.SetBelong(this.instance);
				}
				return r_ApplyPropertyAnimation_VisualElement_StylePropertyId_Scale;
			}
		}

		/// <summary>
		/// Boolean StartAnimation(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.ComputedStyle ByRef, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.ComputedStyle ByRef, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationAllProperty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.StyleSheets.StyleValue, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected static RMethod r_StartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_;
		public static RMethod RStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_ = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "StartAnimationInline", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_.SetBelong(null);
				}
				return r_StartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected RMethod r_ApplyStyleTransformOrigin_TransformOrigin;
		public virtual RMethod RApplyStyleTransformOrigin_TransformOrigin
		{
			get
			{
				if(r_ApplyStyleTransformOrigin_TransformOrigin == null)
				{
					r_ApplyStyleTransformOrigin_TransformOrigin = new(this, "ApplyStyleTransformOrigin", 0, typeof(UnityEngine.UIElements.TransformOrigin));
					r_ApplyStyleTransformOrigin_TransformOrigin.SetBelong(this.instance);
				}
				return r_ApplyStyleTransformOrigin_TransformOrigin;
			}
		}

		/// <summary>
		/// Void ApplyStyleTranslate(UnityEngine.UIElements.Translate)
		/// </summary>
		protected RMethod r_ApplyStyleTranslate_Translate;
		public virtual RMethod RApplyStyleTranslate_Translate
		{
			get
			{
				if(r_ApplyStyleTranslate_Translate == null)
				{
					r_ApplyStyleTranslate_Translate = new(this, "ApplyStyleTranslate", 0, typeof(UnityEngine.UIElements.Translate));
					r_ApplyStyleTranslate_Translate.SetBelong(this.instance);
				}
				return r_ApplyStyleTranslate_Translate;
			}
		}

		/// <summary>
		/// Void ApplyStyleRotate(UnityEngine.UIElements.Rotate)
		/// </summary>
		protected RMethod r_ApplyStyleRotate_Rotate;
		public virtual RMethod RApplyStyleRotate_Rotate
		{
			get
			{
				if(r_ApplyStyleRotate_Rotate == null)
				{
					r_ApplyStyleRotate_Rotate = new(this, "ApplyStyleRotate", 0, typeof(UnityEngine.UIElements.Rotate));
					r_ApplyStyleRotate_Rotate.SetBelong(this.instance);
				}
				return r_ApplyStyleRotate_Rotate;
			}
		}

		/// <summary>
		/// Void ApplyStyleScale(UnityEngine.UIElements.Scale)
		/// </summary>
		protected RMethod r_ApplyStyleScale_Scale;
		public virtual RMethod RApplyStyleScale_Scale
		{
			get
			{
				if(r_ApplyStyleScale_Scale == null)
				{
					r_ApplyStyleScale_Scale = new(this, "ApplyStyleScale", 0, typeof(UnityEngine.UIElements.Scale));
					r_ApplyStyleScale_Scale.SetBelong(this.instance);
				}
				return r_ApplyStyleScale_Scale;
			}
		}

		/// <summary>
		/// Void ApplyStyleBackgroundSize(UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected RMethod r_ApplyStyleBackgroundSize_BackgroundSize;
		public virtual RMethod RApplyStyleBackgroundSize_BackgroundSize
		{
			get
			{
				if(r_ApplyStyleBackgroundSize_BackgroundSize == null)
				{
					r_ApplyStyleBackgroundSize_BackgroundSize = new(this, "ApplyStyleBackgroundSize", 0, typeof(UnityEngine.UIElements.BackgroundSize));
					r_ApplyStyleBackgroundSize_BackgroundSize.SetBelong(this.instance);
				}
				return r_ApplyStyleBackgroundSize_BackgroundSize;
			}
		}

		/// <summary>
		/// Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader)
		/// </summary>
		protected RMethod r_ApplyInitialValue_StylePropertyReader;
		public virtual RMethod RApplyInitialValue_StylePropertyReader
		{
			get
			{
				if(r_ApplyInitialValue_StylePropertyReader == null)
				{
					r_ApplyInitialValue_StylePropertyReader = new(this, "ApplyInitialValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"));
					r_ApplyInitialValue_StylePropertyReader.SetBelong(this.instance);
				}
				return r_ApplyInitialValue_StylePropertyReader;
			}
		}

		/// <summary>
		/// Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_ApplyInitialValue_StylePropertyId;
		public virtual RMethod RApplyInitialValue_StylePropertyId
		{
			get
			{
				if(r_ApplyInitialValue_StylePropertyId == null)
				{
					r_ApplyInitialValue_StylePropertyId = new(this, "ApplyInitialValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_ApplyInitialValue_StylePropertyId.SetBelong(this.instance);
				}
				return r_ApplyInitialValue_StylePropertyId;
			}
		}

		/// <summary>
		/// Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle;
		public virtual RMethod RApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle == null)
				{
					r_ApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle = new(this, "ApplyUnsetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_ApplyUnsetValue_StylePropertyId_Ref_ComputedStyle;
		public virtual RMethod RApplyUnsetValue_StylePropertyId_Ref_ComputedStyle
		{
			get
			{
				if(r_ApplyUnsetValue_StylePropertyId_Ref_ComputedStyle == null)
				{
					r_ApplyUnsetValue_StylePropertyId_Ref_ComputedStyle = new(this, "ApplyUnsetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_ApplyUnsetValue_StylePropertyId_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_ApplyUnsetValue_StylePropertyId_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType CompareChanges(UnityEngine.UIElements.ComputedStyle ByRef, UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected static RMethod r_CompareChanges_Ref_ComputedStyle_Ref_ComputedStyle;
		public static RMethod RCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_CompareChanges_Ref_ComputedStyle_Ref_ComputedStyle == null)
				{
					r_CompareChanges_Ref_ComputedStyle_Ref_ComputedStyle = new( ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle"), "CompareChanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_CompareChanges_Ref_ComputedStyle_Ref_ComputedStyle.SetBelong(null);
				}
				return r_CompareChanges_Ref_ComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public static System.Object Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void FinalizeApply(ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentStyle.Value};
            var ___result = RFinalizeApply_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void SyncWithLayout(RUnityEngine.RYoga.RYogaNode  @targetNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNode.Value};
            var ___result = RSyncWithLayout_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ApplyGlobalKeyword(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader  @reader, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ApplyGlobalKeyword(RType  @id, UnityEngine.UIElements.StyleKeyword  @keyword, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @keyword, @parentStyle.Value};
            var ___result = RApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);

            return (System.Boolean)___result;
        }


        public virtual void RemoveCustomStyleProperty(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RRemoveCustomStyleProperty_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyCustomStyleProperty(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RApplyCustomStyleProperty_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyAllPropertyInitial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyAllPropertyInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetComputedTransitions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetComputedTransitions.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean StartAnimationInlineTextShadow(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, UnityEngine.UIElements.StyleTextShadow  @textShadow, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @textShadow, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineRotate(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, UnityEngine.UIElements.StyleRotate  @rotate, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @rotate, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, UnityEngine.UIElements.StyleTranslate  @translate, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @translate, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineScale(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, UnityEngine.UIElements.StyleScale  @scale, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @scale, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineTransformOrigin(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, UnityEngine.UIElements.StyleTransformOrigin  @transformOrigin, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @transformOrigin, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInlineBackgroundSize(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, UnityEngine.UIElements.StyleBackgroundSize  @backgroundSize, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @backgroundSize, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Object Create(ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentStyle.Value};
            var ___result = RCreate_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            return (System.Object)___result;
        }


        public static System.Object CreateInitial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateInitial.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAcquire.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(ref RUnityEngine.RUIElements.RComputedStyle  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RCopyFrom_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@other = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void ApplyProperties(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader  @reader, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RApplyProperties_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyStyleValue(RUnityEngine.RUIElements.RStyleSheets.RStyleValue  @sv, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value, @parentStyle.Value};
            var ___result = RApplyStyleValue_StyleValue_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyStyleValueManaged(RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged  @sv, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value, @parentStyle.Value};
            var ___result = RApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyStyleCursor(UnityEngine.UIElements.Cursor  @cursor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursor};
            var ___result = RApplyStyleCursor_Cursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow  @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RApplyStyleTextShadow_TextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyFromComputedStyle(RType  @id, ref RUnityEngine.RUIElements.RComputedStyle  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @other.Value};
            var ___result = RApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@other = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.Length  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Length.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, System.Single  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, System.Int32  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.BackgroundPosition  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.BackgroundRepeat  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.BackgroundSize  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.Color  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.Background  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Background.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.Font  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Font.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.FontDefinition  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.TextShadow  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.Translate  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Translate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.TransformOrigin  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.Rotate  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement  @ve, RType  @id, UnityEngine.UIElements.Scale  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RApplyPropertyAnimation_VisualElement_StylePropertyId_Scale.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean StartAnimation(UnityEngine.UIElements.VisualElement  @element, RType  @id, ref RUnityEngine.RUIElements.RComputedStyle  @oldStyle, ref RUnityEngine.RUIElements.RComputedStyle  @newStyle, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @id.Value, @oldStyle.Value, @newStyle.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@oldStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[3]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement  @element, ref RUnityEngine.RUIElements.RComputedStyle  @oldStyle, ref RUnityEngine.RUIElements.RComputedStyle  @newStyle, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @oldStyle.Value, @newStyle.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@oldStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);

            return (System.Boolean)___result;
        }


        public static System.Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement  @element, RType  @id, ref RUnityEngine.RUIElements.RComputedStyle  @computedStyle, RUnityEngine.RUIElements.RStyleSheets.RStyleValue  @sv, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @id.Value, @computedStyle.Value, @sv.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[2]);

            return (System.Boolean)___result;
        }


        public virtual void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin  @st)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@st};
            var ___result = RApplyStyleTransformOrigin_TransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleTranslate(UnityEngine.UIElements.Translate  @translateValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@translateValue};
            var ___result = RApplyStyleTranslate_Translate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleRotate(UnityEngine.UIElements.Rotate  @rotateValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotateValue};
            var ___result = RApplyStyleRotate_Rotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleScale(UnityEngine.UIElements.Scale  @scaleValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scaleValue};
            var ___result = RApplyStyleScale_Scale.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleBackgroundSize(UnityEngine.UIElements.BackgroundSize  @backgroundSizeValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@backgroundSizeValue};
            var ___result = RApplyStyleBackgroundSize_BackgroundSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyInitialValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RApplyInitialValue_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyInitialValue(RType  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RApplyInitialValue_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyUnsetValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader  @reader, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public virtual void ApplyUnsetValue(RType  @id, ref RUnityEngine.RUIElements.RComputedStyle  @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @parentStyle.Value};
            var ___result = RApplyUnsetValue_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            
        }


        public static System.Object CompareChanges(ref RUnityEngine.RUIElements.RComputedStyle  @x, ref RUnityEngine.RUIElements.RComputedStyle  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = RCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@x = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);
			@y = new RUnityEngine.RUIElements.RComputedStyle(___parameters[1]);

            return (System.Object)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
