
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.ComputedStyle
	/// </summary>
    public partial class RComputedStyle : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle");
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


		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.InheritedData] inheritedData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData> r_FinheritedData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData> RFinheritedData
		{
			get
			{
				if(r_FinheritedData == null)
				{
					r_FinheritedData = new(this, "inheritedData");
				}
				return r_FinheritedData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.LayoutData] layoutData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData> r_FlayoutData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData> RFlayoutData
		{
			get
			{
				if(r_FlayoutData == null)
				{
					r_FlayoutData = new(this, "layoutData");
				}
				return r_FlayoutData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.RareData] rareData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData> r_FrareData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData> RFrareData
		{
			get
			{
				if(r_FrareData == null)
				{
					r_FrareData = new(this, "rareData");
				}
				return r_FrareData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.TransformData] transformData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData> r_FtransformData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData> RFtransformData
		{
			get
			{
				if(r_FtransformData == null)
				{
					r_FtransformData = new(this, "transformData");
				}
				return r_FtransformData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.TransitionData] transitionData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData> r_FtransitionData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransitionData> RFtransitionData
		{
			get
			{
				if(r_FtransitionData == null)
				{
					r_FtransitionData = new(this, "transitionData");
				}
				return r_FtransitionData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleDataRef`1[UnityEngine.UIElements.VisualData] visualData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData> r_FvisualData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData> RFvisualData
		{
			get
			{
				if(r_FvisualData == null)
				{
					r_FvisualData = new(this, "visualData");
				}
				return r_FvisualData;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode r_FyogaNode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode RFyogaNode
		{
			get
			{
				if(r_FyogaNode == null)
				{
					r_FyogaNode = new(this, "yogaNode");
				}
				return r_FyogaNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue] customProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_FcustomProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RFcustomProperties
		{
			get
			{
				if(r_FcustomProperties == null)
				{
					r_FcustomProperties = new(this, "customProperties");
				}
				return r_FcustomProperties;
			}
		}

		/// <summary>
		/// System.Int64 matchingRulesHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_FmatchingRulesHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFmatchingRulesHash
		{
			get
			{
				if(r_FmatchingRulesHash == null)
				{
					r_FmatchingRulesHash = new(this, "matchingRulesHash");
				}
				return r_FmatchingRulesHash;
			}
		}

		/// <summary>
		/// System.Single dpiScaling
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FdpiScaling;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFdpiScaling
		{
			get
			{
				if(r_FdpiScaling == null)
				{
					r_FdpiScaling = new(this, "dpiScaling");
				}
				return r_FdpiScaling;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedTransitionProperty> r_FcomputedTransitions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedTransitionProperty> RFcomputedTransitions
		{
			get
			{
				if(r_FcomputedTransitions == null)
				{
					r_FcomputedTransitions = new(this, "computedTransitions");
				}
				return r_FcomputedTransitions;
			}
		}

		/// <summary>
		/// Int32 customPropertiesCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcustomPropertiesCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcustomPropertiesCount
		{
			get
			{
				if(r_PcustomPropertiesCount == null)
				{
					r_PcustomPropertiesCount = new(this, "customPropertiesCount", -1);
				}
				return r_PcustomPropertiesCount;
			}
		}

		/// <summary>
		/// Boolean hasTransition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasTransition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasTransition
		{
			get
			{
				if(r_PhasTransition == null)
				{
					r_PhasTransition = new(this, "hasTransition", -1);
				}
				return r_PhasTransition;
			}
		}

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
				}
				return r_PborderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderBottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PborderBottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPborderBottomLeftRadius
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
		/// UnityEngine.UIElements.Length borderBottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PborderBottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPborderBottomRightRadius
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
				}
				return r_PborderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderTopLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PborderTopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPborderTopLeftRadius
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
		/// UnityEngine.UIElements.Length borderTopRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PborderTopRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPborderTopRightRadius
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
				}
				return r_PborderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Pbottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPbottom
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
				}
				return r_Pcolor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Cursor cursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor r_Pcursor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor RPcursor
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
				}
				return r_Pdisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length flexBasis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PflexBasis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPflexBasis
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
				}
				return r_PflexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PfontSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPfontSize
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
		/// UnityEngine.UIElements.Length height
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Pheight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPheight
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
				}
				return r_PjustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length left
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Pleft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPleft
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
		/// UnityEngine.UIElements.Length letterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PletterSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPletterSpacing
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
		/// UnityEngine.UIElements.Length marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PmarginBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPmarginBottom
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
		/// UnityEngine.UIElements.Length marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PmarginLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPmarginLeft
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
		/// UnityEngine.UIElements.Length marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PmarginRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPmarginRight
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
		/// UnityEngine.UIElements.Length marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PmarginTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPmarginTop
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
		/// UnityEngine.UIElements.Length maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PmaxHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPmaxHeight
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
		/// UnityEngine.UIElements.Length maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PmaxWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPmaxWidth
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
		/// UnityEngine.UIElements.Length minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PminHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPminHeight
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
		/// UnityEngine.UIElements.Length minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PminWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPminWidth
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
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowInternal overflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowInternal r_Poverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowInternal RPoverflow
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
		/// UnityEngine.UIElements.Length paddingBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PpaddingBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPpaddingBottom
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
		/// UnityEngine.UIElements.Length paddingLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PpaddingLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPpaddingLeft
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
		/// UnityEngine.UIElements.Length paddingRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PpaddingRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPpaddingRight
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
		/// UnityEngine.UIElements.Length paddingTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PpaddingTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPpaddingTop
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
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length right
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Pright;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPright
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
				}
				return r_PtextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextShadow textShadow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextShadow r_PtextShadow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextShadow RPtextShadow
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
		/// UnityEngine.UIElements.Length top
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Ptop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPtop
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
		/// UnityEngine.UIElements.TransformOrigin transformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin r_PtransformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin RPtransformOrigin
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDelay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PtransitionDelay;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPtransitionDelay
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue] transitionDuration
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PtransitionDuration;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPtransitionDuration
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName] transitionProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> r_PtransitionProperty;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> RPtransitionProperty
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
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction] transitionTimingFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> r_PtransitionTimingFunction;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> RPtransitionTimingFunction
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
		/// UnityEngine.UIElements.Translate translate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTranslate r_Ptranslate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTranslate RPtranslate
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
				}
				return r_PunityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox r_PunityOverflowClipBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox RPunityOverflowClipBox
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
		/// UnityEngine.UIElements.Length unityParagraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PunityParagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPunityParagraphSpacing
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
				}
				return r_PwhiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length width
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPwidth
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
		/// UnityEngine.UIElements.Length wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_PwordSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPwordSpacing
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
		/// UnityEngine.UIElements.ComputedStyle Create()
		/// </summary>
		protected static RMethod r_MCreate;
		public static RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new(Type, "Create", 0);
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
					r_MStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInlineTextShadow", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTextShadow), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInlineRotate", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleRotate), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInlineTranslate", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTranslate), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInlineScale", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleScale), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInlineTransformOrigin", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleTransformOrigin), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInlineBackgroundSize", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MCreate_Ref_ComputedStyle = new(Type, "Create", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
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
					r_MCreateInitial = new(Type, "CreateInitial", 0);
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
					r_MStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimation", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationAllProperty", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_ = new(Type, "StartAnimationInline", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle = new(Type, "CompareChanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
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


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___result);
        }


        public virtual void FinalizeApply(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentStyle.Value};
            var ___result = RMFinalizeApply_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);

            
        }


        public virtual void SyncWithLayout(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode @targetNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNode.Value};
            var ___result = RMSyncWithLayout_YogaNode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ApplyGlobalKeyword(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RMApplyGlobalKeyword_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ApplyGlobalKeyword(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.StyleKeyword @keyword, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @keyword, @parentStyle.Value};
            var ___result = RMApplyGlobalKeyword_StylePropertyId_StyleKeyword_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void RemoveCustomStyleProperty(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RMRemoveCustomStyleProperty_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyCustomStyleProperty(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader)
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


        public static System.Boolean StartAnimationInlineTextShadow(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleTextShadow @textShadow, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @textShadow, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineTextShadow_VisualElement_Ref_ComputedStyle_StyleTextShadow_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationInlineRotate(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleRotate @rotate, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @rotate, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineRotate_VisualElement_Ref_ComputedStyle_StyleRotate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleTranslate @translate, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @translate, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineTranslate_VisualElement_Ref_ComputedStyle_StyleTranslate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationInlineScale(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleScale @scale, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @scale, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineScale_VisualElement_Ref_ComputedStyle_StyleScale_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationInlineTransformOrigin(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleTransformOrigin @transformOrigin, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @transformOrigin, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineTransformOrigin_VisualElement_Ref_ComputedStyle_StyleTransformOrigin_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationInlineBackgroundSize(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, UnityEngine.UIElements.StyleBackgroundSize @backgroundSize, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @computedStyle.Value, @backgroundSize, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInlineBackgroundSize_VisualElement_Ref_ComputedStyle_StyleBackgroundSize_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle Create(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parentStyle.Value};
            var ___result = RMCreate_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle CreateInitial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateInitial.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcquire.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___result);
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@other = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);

            
        }


        public virtual void ApplyProperties(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RMApplyProperties_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
        }


        public virtual void ApplyStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @sv, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value, @parentStyle.Value};
            var ___result = RMApplyStyleValue_StyleValue_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
        }


        public virtual void ApplyStyleValueManaged(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValueManaged @sv, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sv.Value, @parentStyle.Value};
            var ___result = RMApplyStyleValueManaged_StyleValueManaged_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
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


        public virtual void ApplyFromComputedStyle(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @other.Value};
            var ___result = RMApplyFromComputedStyle_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@other = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Length @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Length.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Single @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundPosition @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundPosition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundRepeat @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundSize @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_BackgroundSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Color @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Background @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Background.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Font @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Font.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.FontDefinition @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_FontDefinition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TextShadow @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_TextShadow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Translate @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Translate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TransformOrigin @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_TransformOrigin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Rotate @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Rotate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Scale @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @id.Value, @newValue};
            var ___result = RMApplyPropertyAnimation_VisualElement_StylePropertyId_Scale.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean StartAnimation(UnityEngine.UIElements.VisualElement @element, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @oldStyle, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @newStyle, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @id.Value, @oldStyle.Value, @newStyle.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimation_VisualElement_StylePropertyId_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@oldStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[2]);
			@newStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement @element, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @oldStyle, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @newStyle, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @oldStyle.Value, @newStyle.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationAllProperty_VisualElement_Ref_ComputedStyle_Ref_ComputedStyle_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@oldStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);
			@newStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement @element, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @computedStyle, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @sv, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @id.Value, @computedStyle.Value, @sv.Value, @durationMs, @delayMs, @easingCurve};
            var ___result = RMStartAnimationInline_VisualElement_StylePropertyId_Ref_ComputedStyle_StyleValue_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);
			@computedStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual void ApplyInitialValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value};
            var ___result = RMApplyInitialValue_StylePropertyReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyInitialValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMApplyInitialValue_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyUnsetValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader @reader, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader.Value, @parentStyle.Value};
            var ___result = RMApplyUnsetValue_StylePropertyReader_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
        }


        public virtual void ApplyUnsetValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @parentStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @parentStyle.Value};
            var ___result = RMApplyUnsetValue_StylePropertyId_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@parentStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType CompareChanges(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @x, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = RMCompareChanges_Ref_ComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@x = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);
			@y = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[1]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
