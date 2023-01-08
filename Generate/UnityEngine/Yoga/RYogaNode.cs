using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RYoga
{
	/// <summary>
	/// UnityEngine.Yoga.YogaNode
	/// </summary>
    public partial class RYogaNode : RMember //
    {

		/// <summary>
		/// System.IntPtr _ygNode
		/// </summary>
		protected RField r__ygNode;
		public virtual RField R_ygNode
		{
			get
			{
				if(r__ygNode == null)
				{
					r__ygNode = new(this, "_ygNode");
					r__ygNode.SetBelong(this.instance);
				}
				return r__ygNode;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig _config
		/// </summary>
		protected RUnityEngine.RYoga.RYogaConfig r__config;
		public virtual RUnityEngine.RYoga.RYogaConfig R_config
		{
			get
			{
				if(r__config == null)
				{
					r__config = new(this, "_config");
					r__config.SetBelong(this.instance);
				}
				return r__config;
			}
		}

		/// <summary>
		/// System.WeakReference _parent
		/// </summary>
		protected RSystem.RWeakReference r__parent;
		public virtual RSystem.RWeakReference R_parent
		{
			get
			{
				if(r__parent == null)
				{
					r__parent = new(this, "_parent");
					r__parent.SetBelong(this.instance);
				}
				return r__parent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Yoga.YogaNode] _children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RYoga.RYogaNode> r__children;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RYoga.RYogaNode> R_children
		{
			get
			{
				if(r__children == null)
				{
					r__children = new(this, "_children");
					r__children.SetBelong(this.instance);
				}
				return r__children;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.MeasureFunction _measureFunction
		/// </summary>
		protected RUnityEngine.RYoga.RMeasureFunction r__measureFunction;
		public virtual RUnityEngine.RYoga.RMeasureFunction R_measureFunction
		{
			get
			{
				if(r__measureFunction == null)
				{
					r__measureFunction = new(this, "_measureFunction");
					r__measureFunction.SetBelong(this.instance);
				}
				return r__measureFunction;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.BaselineFunction _baselineFunction
		/// </summary>
		protected RUnityEngine.RYoga.RBaselineFunction r__baselineFunction;
		public virtual RUnityEngine.RYoga.RBaselineFunction R_baselineFunction
		{
			get
			{
				if(r__baselineFunction == null)
				{
					r__baselineFunction = new(this, "_baselineFunction");
					r__baselineFunction.SetBelong(this.instance);
				}
				return r__baselineFunction;
			}
		}

		/// <summary>
		/// System.Object _data
		/// </summary>
		protected RSystem.RObject r__data;
		public virtual RSystem.RObject R_data
		{
			get
			{
				if(r__data == null)
				{
					r__data = new(this, "_data");
					r__data.SetBelong(this.instance);
				}
				return r__data;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig Config
		/// </summary>
		protected RUnityEngine.RYoga.RYogaConfig r_Config;
		public virtual RUnityEngine.RYoga.RYogaConfig RConfig
		{
			get
			{
				if(r_Config == null)
				{
					r_Config = new(this, "Config", -1);
					r_Config.SetBelong(this.instance);
				}
				return r_Config;
			}
		}

		/// <summary>
		/// Boolean IsDirty
		/// </summary>
		protected RProperty r_IsDirty;
		public virtual RProperty RIsDirty
		{
			get
			{
				if(r_IsDirty == null)
				{
					r_IsDirty = new(this, "IsDirty", -1);
					r_IsDirty.SetBelong(this.instance);
				}
				return r_IsDirty;
			}
		}

		/// <summary>
		/// Boolean HasNewLayout
		/// </summary>
		protected RProperty r_HasNewLayout;
		public virtual RProperty RHasNewLayout
		{
			get
			{
				if(r_HasNewLayout == null)
				{
					r_HasNewLayout = new(this, "HasNewLayout", -1);
					r_HasNewLayout.SetBelong(this.instance);
				}
				return r_HasNewLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode Parent
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_Parent;
		public virtual RUnityEngine.RYoga.RYogaNode RParent
		{
			get
			{
				if(r_Parent == null)
				{
					r_Parent = new(this, "Parent", -1);
					r_Parent.SetBelong(this.instance);
				}
				return r_Parent;
			}
		}

		/// <summary>
		/// Boolean IsMeasureDefined
		/// </summary>
		protected RProperty r_IsMeasureDefined;
		public virtual RProperty RIsMeasureDefined
		{
			get
			{
				if(r_IsMeasureDefined == null)
				{
					r_IsMeasureDefined = new(this, "IsMeasureDefined", -1);
					r_IsMeasureDefined.SetBelong(this.instance);
				}
				return r_IsMeasureDefined;
			}
		}

		/// <summary>
		/// Boolean IsBaselineDefined
		/// </summary>
		protected RProperty r_IsBaselineDefined;
		public virtual RProperty RIsBaselineDefined
		{
			get
			{
				if(r_IsBaselineDefined == null)
				{
					r_IsBaselineDefined = new(this, "IsBaselineDefined", -1);
					r_IsBaselineDefined.SetBelong(this.instance);
				}
				return r_IsBaselineDefined;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaDirection StyleDirection
		/// </summary>
		protected RProperty r_StyleDirection;
		public virtual RProperty RStyleDirection
		{
			get
			{
				if(r_StyleDirection == null)
				{
					r_StyleDirection = new(this, "StyleDirection", -1);
					r_StyleDirection.SetBelong(this.instance);
				}
				return r_StyleDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaFlexDirection FlexDirection
		/// </summary>
		protected RProperty r_FlexDirection;
		public virtual RProperty RFlexDirection
		{
			get
			{
				if(r_FlexDirection == null)
				{
					r_FlexDirection = new(this, "FlexDirection", -1);
					r_FlexDirection.SetBelong(this.instance);
				}
				return r_FlexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaJustify JustifyContent
		/// </summary>
		protected RProperty r_JustifyContent;
		public virtual RProperty RJustifyContent
		{
			get
			{
				if(r_JustifyContent == null)
				{
					r_JustifyContent = new(this, "JustifyContent", -1);
					r_JustifyContent.SetBelong(this.instance);
				}
				return r_JustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaDisplay Display
		/// </summary>
		protected RProperty r_Display;
		public virtual RProperty RDisplay
		{
			get
			{
				if(r_Display == null)
				{
					r_Display = new(this, "Display", -1);
					r_Display.SetBelong(this.instance);
				}
				return r_Display;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaAlign AlignItems
		/// </summary>
		protected RProperty r_AlignItems;
		public virtual RProperty RAlignItems
		{
			get
			{
				if(r_AlignItems == null)
				{
					r_AlignItems = new(this, "AlignItems", -1);
					r_AlignItems.SetBelong(this.instance);
				}
				return r_AlignItems;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaAlign AlignSelf
		/// </summary>
		protected RProperty r_AlignSelf;
		public virtual RProperty RAlignSelf
		{
			get
			{
				if(r_AlignSelf == null)
				{
					r_AlignSelf = new(this, "AlignSelf", -1);
					r_AlignSelf.SetBelong(this.instance);
				}
				return r_AlignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaAlign AlignContent
		/// </summary>
		protected RProperty r_AlignContent;
		public virtual RProperty RAlignContent
		{
			get
			{
				if(r_AlignContent == null)
				{
					r_AlignContent = new(this, "AlignContent", -1);
					r_AlignContent.SetBelong(this.instance);
				}
				return r_AlignContent;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaPositionType PositionType
		/// </summary>
		protected RProperty r_PositionType;
		public virtual RProperty RPositionType
		{
			get
			{
				if(r_PositionType == null)
				{
					r_PositionType = new(this, "PositionType", -1);
					r_PositionType.SetBelong(this.instance);
				}
				return r_PositionType;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaWrap Wrap
		/// </summary>
		protected RProperty r_Wrap;
		public virtual RProperty RWrap
		{
			get
			{
				if(r_Wrap == null)
				{
					r_Wrap = new(this, "Wrap", -1);
					r_Wrap.SetBelong(this.instance);
				}
				return r_Wrap;
			}
		}

		/// <summary>
		/// Single Flex
		/// </summary>
		protected RProperty r_Flex;
		public virtual RProperty RFlex
		{
			get
			{
				if(r_Flex == null)
				{
					r_Flex = new(this, "Flex", -1);
					r_Flex.SetBelong(this.instance);
				}
				return r_Flex;
			}
		}

		/// <summary>
		/// Single FlexGrow
		/// </summary>
		protected RProperty r_FlexGrow;
		public virtual RProperty RFlexGrow
		{
			get
			{
				if(r_FlexGrow == null)
				{
					r_FlexGrow = new(this, "FlexGrow", -1);
					r_FlexGrow.SetBelong(this.instance);
				}
				return r_FlexGrow;
			}
		}

		/// <summary>
		/// Single FlexShrink
		/// </summary>
		protected RProperty r_FlexShrink;
		public virtual RProperty RFlexShrink
		{
			get
			{
				if(r_FlexShrink == null)
				{
					r_FlexShrink = new(this, "FlexShrink", -1);
					r_FlexShrink.SetBelong(this.instance);
				}
				return r_FlexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue FlexBasis
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_FlexBasis;
		public virtual RUnityEngine.RYoga.RYogaValue RFlexBasis
		{
			get
			{
				if(r_FlexBasis == null)
				{
					r_FlexBasis = new(this, "FlexBasis", -1);
					r_FlexBasis.SetBelong(this.instance);
				}
				return r_FlexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Width
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Width;
		public virtual RUnityEngine.RYoga.RYogaValue RWidth
		{
			get
			{
				if(r_Width == null)
				{
					r_Width = new(this, "Width", -1);
					r_Width.SetBelong(this.instance);
				}
				return r_Width;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Height
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Height;
		public virtual RUnityEngine.RYoga.RYogaValue RHeight
		{
			get
			{
				if(r_Height == null)
				{
					r_Height = new(this, "Height", -1);
					r_Height.SetBelong(this.instance);
				}
				return r_Height;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MaxWidth
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MaxWidth;
		public virtual RUnityEngine.RYoga.RYogaValue RMaxWidth
		{
			get
			{
				if(r_MaxWidth == null)
				{
					r_MaxWidth = new(this, "MaxWidth", -1);
					r_MaxWidth.SetBelong(this.instance);
				}
				return r_MaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MaxHeight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MaxHeight;
		public virtual RUnityEngine.RYoga.RYogaValue RMaxHeight
		{
			get
			{
				if(r_MaxHeight == null)
				{
					r_MaxHeight = new(this, "MaxHeight", -1);
					r_MaxHeight.SetBelong(this.instance);
				}
				return r_MaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MinWidth
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MinWidth;
		public virtual RUnityEngine.RYoga.RYogaValue RMinWidth
		{
			get
			{
				if(r_MinWidth == null)
				{
					r_MinWidth = new(this, "MinWidth", -1);
					r_MinWidth.SetBelong(this.instance);
				}
				return r_MinWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MinHeight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MinHeight;
		public virtual RUnityEngine.RYoga.RYogaValue RMinHeight
		{
			get
			{
				if(r_MinHeight == null)
				{
					r_MinHeight = new(this, "MinHeight", -1);
					r_MinHeight.SetBelong(this.instance);
				}
				return r_MinHeight;
			}
		}

		/// <summary>
		/// Single AspectRatio
		/// </summary>
		protected RProperty r_AspectRatio;
		public virtual RProperty RAspectRatio
		{
			get
			{
				if(r_AspectRatio == null)
				{
					r_AspectRatio = new(this, "AspectRatio", -1);
					r_AspectRatio.SetBelong(this.instance);
				}
				return r_AspectRatio;
			}
		}

		/// <summary>
		/// Single LayoutX
		/// </summary>
		protected RProperty r_LayoutX;
		public virtual RProperty RLayoutX
		{
			get
			{
				if(r_LayoutX == null)
				{
					r_LayoutX = new(this, "LayoutX", -1);
					r_LayoutX.SetBelong(this.instance);
				}
				return r_LayoutX;
			}
		}

		/// <summary>
		/// Single LayoutY
		/// </summary>
		protected RProperty r_LayoutY;
		public virtual RProperty RLayoutY
		{
			get
			{
				if(r_LayoutY == null)
				{
					r_LayoutY = new(this, "LayoutY", -1);
					r_LayoutY.SetBelong(this.instance);
				}
				return r_LayoutY;
			}
		}

		/// <summary>
		/// Single LayoutRight
		/// </summary>
		protected RProperty r_LayoutRight;
		public virtual RProperty RLayoutRight
		{
			get
			{
				if(r_LayoutRight == null)
				{
					r_LayoutRight = new(this, "LayoutRight", -1);
					r_LayoutRight.SetBelong(this.instance);
				}
				return r_LayoutRight;
			}
		}

		/// <summary>
		/// Single LayoutBottom
		/// </summary>
		protected RProperty r_LayoutBottom;
		public virtual RProperty RLayoutBottom
		{
			get
			{
				if(r_LayoutBottom == null)
				{
					r_LayoutBottom = new(this, "LayoutBottom", -1);
					r_LayoutBottom.SetBelong(this.instance);
				}
				return r_LayoutBottom;
			}
		}

		/// <summary>
		/// Single LayoutWidth
		/// </summary>
		protected RProperty r_LayoutWidth;
		public virtual RProperty RLayoutWidth
		{
			get
			{
				if(r_LayoutWidth == null)
				{
					r_LayoutWidth = new(this, "LayoutWidth", -1);
					r_LayoutWidth.SetBelong(this.instance);
				}
				return r_LayoutWidth;
			}
		}

		/// <summary>
		/// Single LayoutHeight
		/// </summary>
		protected RProperty r_LayoutHeight;
		public virtual RProperty RLayoutHeight
		{
			get
			{
				if(r_LayoutHeight == null)
				{
					r_LayoutHeight = new(this, "LayoutHeight", -1);
					r_LayoutHeight.SetBelong(this.instance);
				}
				return r_LayoutHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaDirection LayoutDirection
		/// </summary>
		protected RProperty r_LayoutDirection;
		public virtual RProperty RLayoutDirection
		{
			get
			{
				if(r_LayoutDirection == null)
				{
					r_LayoutDirection = new(this, "LayoutDirection", -1);
					r_LayoutDirection.SetBelong(this.instance);
				}
				return r_LayoutDirection;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaOverflow Overflow
		/// </summary>
		protected RProperty r_Overflow;
		public virtual RProperty ROverflow
		{
			get
			{
				if(r_Overflow == null)
				{
					r_Overflow = new(this, "Overflow", -1);
					r_Overflow.SetBelong(this.instance);
				}
				return r_Overflow;
			}
		}

		/// <summary>
		/// System.Object Data
		/// </summary>
		protected RSystem.RObject r_Data;
		public virtual RSystem.RObject RData
		{
			get
			{
				if(r_Data == null)
				{
					r_Data = new(this, "Data", -1);
					r_Data.SetBelong(this.instance);
				}
				return r_Data;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode Item [Int32]
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_Item_Int32;
		public virtual RUnityEngine.RYoga.RYogaNode RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Left
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Left;
		public virtual RUnityEngine.RYoga.RYogaValue RLeft
		{
			get
			{
				if(r_Left == null)
				{
					r_Left = new(this, "Left", -1);
					r_Left.SetBelong(this.instance);
				}
				return r_Left;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Top
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Top;
		public virtual RUnityEngine.RYoga.RYogaValue RTop
		{
			get
			{
				if(r_Top == null)
				{
					r_Top = new(this, "Top", -1);
					r_Top.SetBelong(this.instance);
				}
				return r_Top;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Right
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Right;
		public virtual RUnityEngine.RYoga.RYogaValue RRight
		{
			get
			{
				if(r_Right == null)
				{
					r_Right = new(this, "Right", -1);
					r_Right.SetBelong(this.instance);
				}
				return r_Right;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Bottom
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Bottom;
		public virtual RUnityEngine.RYoga.RYogaValue RBottom
		{
			get
			{
				if(r_Bottom == null)
				{
					r_Bottom = new(this, "Bottom", -1);
					r_Bottom.SetBelong(this.instance);
				}
				return r_Bottom;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Start
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Start;
		public virtual RUnityEngine.RYoga.RYogaValue RStart
		{
			get
			{
				if(r_Start == null)
				{
					r_Start = new(this, "Start", -1);
					r_Start.SetBelong(this.instance);
				}
				return r_Start;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue End
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_End;
		public virtual RUnityEngine.RYoga.RYogaValue REnd
		{
			get
			{
				if(r_End == null)
				{
					r_End = new(this, "End", -1);
					r_End.SetBelong(this.instance);
				}
				return r_End;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginLeft
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginLeft;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginLeft
		{
			get
			{
				if(r_MarginLeft == null)
				{
					r_MarginLeft = new(this, "MarginLeft", -1);
					r_MarginLeft.SetBelong(this.instance);
				}
				return r_MarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginTop
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginTop;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginTop
		{
			get
			{
				if(r_MarginTop == null)
				{
					r_MarginTop = new(this, "MarginTop", -1);
					r_MarginTop.SetBelong(this.instance);
				}
				return r_MarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginRight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginRight;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginRight
		{
			get
			{
				if(r_MarginRight == null)
				{
					r_MarginRight = new(this, "MarginRight", -1);
					r_MarginRight.SetBelong(this.instance);
				}
				return r_MarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginBottom
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginBottom;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginBottom
		{
			get
			{
				if(r_MarginBottom == null)
				{
					r_MarginBottom = new(this, "MarginBottom", -1);
					r_MarginBottom.SetBelong(this.instance);
				}
				return r_MarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginStart
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginStart;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginStart
		{
			get
			{
				if(r_MarginStart == null)
				{
					r_MarginStart = new(this, "MarginStart", -1);
					r_MarginStart.SetBelong(this.instance);
				}
				return r_MarginStart;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginEnd
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginEnd;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginEnd
		{
			get
			{
				if(r_MarginEnd == null)
				{
					r_MarginEnd = new(this, "MarginEnd", -1);
					r_MarginEnd.SetBelong(this.instance);
				}
				return r_MarginEnd;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginHorizontal
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginHorizontal;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginHorizontal
		{
			get
			{
				if(r_MarginHorizontal == null)
				{
					r_MarginHorizontal = new(this, "MarginHorizontal", -1);
					r_MarginHorizontal.SetBelong(this.instance);
				}
				return r_MarginHorizontal;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue MarginVertical
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_MarginVertical;
		public virtual RUnityEngine.RYoga.RYogaValue RMarginVertical
		{
			get
			{
				if(r_MarginVertical == null)
				{
					r_MarginVertical = new(this, "MarginVertical", -1);
					r_MarginVertical.SetBelong(this.instance);
				}
				return r_MarginVertical;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Margin
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Margin;
		public virtual RUnityEngine.RYoga.RYogaValue RMargin
		{
			get
			{
				if(r_Margin == null)
				{
					r_Margin = new(this, "Margin", -1);
					r_Margin.SetBelong(this.instance);
				}
				return r_Margin;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingLeft
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingLeft;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingLeft
		{
			get
			{
				if(r_PaddingLeft == null)
				{
					r_PaddingLeft = new(this, "PaddingLeft", -1);
					r_PaddingLeft.SetBelong(this.instance);
				}
				return r_PaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingTop
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingTop;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingTop
		{
			get
			{
				if(r_PaddingTop == null)
				{
					r_PaddingTop = new(this, "PaddingTop", -1);
					r_PaddingTop.SetBelong(this.instance);
				}
				return r_PaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingRight
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingRight;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingRight
		{
			get
			{
				if(r_PaddingRight == null)
				{
					r_PaddingRight = new(this, "PaddingRight", -1);
					r_PaddingRight.SetBelong(this.instance);
				}
				return r_PaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingBottom
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingBottom;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingBottom
		{
			get
			{
				if(r_PaddingBottom == null)
				{
					r_PaddingBottom = new(this, "PaddingBottom", -1);
					r_PaddingBottom.SetBelong(this.instance);
				}
				return r_PaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingStart
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingStart;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingStart
		{
			get
			{
				if(r_PaddingStart == null)
				{
					r_PaddingStart = new(this, "PaddingStart", -1);
					r_PaddingStart.SetBelong(this.instance);
				}
				return r_PaddingStart;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingEnd
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingEnd;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingEnd
		{
			get
			{
				if(r_PaddingEnd == null)
				{
					r_PaddingEnd = new(this, "PaddingEnd", -1);
					r_PaddingEnd.SetBelong(this.instance);
				}
				return r_PaddingEnd;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingHorizontal
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingHorizontal;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingHorizontal
		{
			get
			{
				if(r_PaddingHorizontal == null)
				{
					r_PaddingHorizontal = new(this, "PaddingHorizontal", -1);
					r_PaddingHorizontal.SetBelong(this.instance);
				}
				return r_PaddingHorizontal;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue PaddingVertical
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_PaddingVertical;
		public virtual RUnityEngine.RYoga.RYogaValue RPaddingVertical
		{
			get
			{
				if(r_PaddingVertical == null)
				{
					r_PaddingVertical = new(this, "PaddingVertical", -1);
					r_PaddingVertical.SetBelong(this.instance);
				}
				return r_PaddingVertical;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaValue Padding
		/// </summary>
		protected RUnityEngine.RYoga.RYogaValue r_Padding;
		public virtual RUnityEngine.RYoga.RYogaValue RPadding
		{
			get
			{
				if(r_Padding == null)
				{
					r_Padding = new(this, "Padding", -1);
					r_Padding.SetBelong(this.instance);
				}
				return r_Padding;
			}
		}

		/// <summary>
		/// Single BorderLeftWidth
		/// </summary>
		protected RProperty r_BorderLeftWidth;
		public virtual RProperty RBorderLeftWidth
		{
			get
			{
				if(r_BorderLeftWidth == null)
				{
					r_BorderLeftWidth = new(this, "BorderLeftWidth", -1);
					r_BorderLeftWidth.SetBelong(this.instance);
				}
				return r_BorderLeftWidth;
			}
		}

		/// <summary>
		/// Single BorderTopWidth
		/// </summary>
		protected RProperty r_BorderTopWidth;
		public virtual RProperty RBorderTopWidth
		{
			get
			{
				if(r_BorderTopWidth == null)
				{
					r_BorderTopWidth = new(this, "BorderTopWidth", -1);
					r_BorderTopWidth.SetBelong(this.instance);
				}
				return r_BorderTopWidth;
			}
		}

		/// <summary>
		/// Single BorderRightWidth
		/// </summary>
		protected RProperty r_BorderRightWidth;
		public virtual RProperty RBorderRightWidth
		{
			get
			{
				if(r_BorderRightWidth == null)
				{
					r_BorderRightWidth = new(this, "BorderRightWidth", -1);
					r_BorderRightWidth.SetBelong(this.instance);
				}
				return r_BorderRightWidth;
			}
		}

		/// <summary>
		/// Single BorderBottomWidth
		/// </summary>
		protected RProperty r_BorderBottomWidth;
		public virtual RProperty RBorderBottomWidth
		{
			get
			{
				if(r_BorderBottomWidth == null)
				{
					r_BorderBottomWidth = new(this, "BorderBottomWidth", -1);
					r_BorderBottomWidth.SetBelong(this.instance);
				}
				return r_BorderBottomWidth;
			}
		}

		/// <summary>
		/// Single BorderStartWidth
		/// </summary>
		protected RProperty r_BorderStartWidth;
		public virtual RProperty RBorderStartWidth
		{
			get
			{
				if(r_BorderStartWidth == null)
				{
					r_BorderStartWidth = new(this, "BorderStartWidth", -1);
					r_BorderStartWidth.SetBelong(this.instance);
				}
				return r_BorderStartWidth;
			}
		}

		/// <summary>
		/// Single BorderEndWidth
		/// </summary>
		protected RProperty r_BorderEndWidth;
		public virtual RProperty RBorderEndWidth
		{
			get
			{
				if(r_BorderEndWidth == null)
				{
					r_BorderEndWidth = new(this, "BorderEndWidth", -1);
					r_BorderEndWidth.SetBelong(this.instance);
				}
				return r_BorderEndWidth;
			}
		}

		/// <summary>
		/// Single BorderWidth
		/// </summary>
		protected RProperty r_BorderWidth;
		public virtual RProperty RBorderWidth
		{
			get
			{
				if(r_BorderWidth == null)
				{
					r_BorderWidth = new(this, "BorderWidth", -1);
					r_BorderWidth.SetBelong(this.instance);
				}
				return r_BorderWidth;
			}
		}

		/// <summary>
		/// Single LayoutMarginLeft
		/// </summary>
		protected RProperty r_LayoutMarginLeft;
		public virtual RProperty RLayoutMarginLeft
		{
			get
			{
				if(r_LayoutMarginLeft == null)
				{
					r_LayoutMarginLeft = new(this, "LayoutMarginLeft", -1);
					r_LayoutMarginLeft.SetBelong(this.instance);
				}
				return r_LayoutMarginLeft;
			}
		}

		/// <summary>
		/// Single LayoutMarginTop
		/// </summary>
		protected RProperty r_LayoutMarginTop;
		public virtual RProperty RLayoutMarginTop
		{
			get
			{
				if(r_LayoutMarginTop == null)
				{
					r_LayoutMarginTop = new(this, "LayoutMarginTop", -1);
					r_LayoutMarginTop.SetBelong(this.instance);
				}
				return r_LayoutMarginTop;
			}
		}

		/// <summary>
		/// Single LayoutMarginRight
		/// </summary>
		protected RProperty r_LayoutMarginRight;
		public virtual RProperty RLayoutMarginRight
		{
			get
			{
				if(r_LayoutMarginRight == null)
				{
					r_LayoutMarginRight = new(this, "LayoutMarginRight", -1);
					r_LayoutMarginRight.SetBelong(this.instance);
				}
				return r_LayoutMarginRight;
			}
		}

		/// <summary>
		/// Single LayoutMarginBottom
		/// </summary>
		protected RProperty r_LayoutMarginBottom;
		public virtual RProperty RLayoutMarginBottom
		{
			get
			{
				if(r_LayoutMarginBottom == null)
				{
					r_LayoutMarginBottom = new(this, "LayoutMarginBottom", -1);
					r_LayoutMarginBottom.SetBelong(this.instance);
				}
				return r_LayoutMarginBottom;
			}
		}

		/// <summary>
		/// Single LayoutMarginStart
		/// </summary>
		protected RProperty r_LayoutMarginStart;
		public virtual RProperty RLayoutMarginStart
		{
			get
			{
				if(r_LayoutMarginStart == null)
				{
					r_LayoutMarginStart = new(this, "LayoutMarginStart", -1);
					r_LayoutMarginStart.SetBelong(this.instance);
				}
				return r_LayoutMarginStart;
			}
		}

		/// <summary>
		/// Single LayoutMarginEnd
		/// </summary>
		protected RProperty r_LayoutMarginEnd;
		public virtual RProperty RLayoutMarginEnd
		{
			get
			{
				if(r_LayoutMarginEnd == null)
				{
					r_LayoutMarginEnd = new(this, "LayoutMarginEnd", -1);
					r_LayoutMarginEnd.SetBelong(this.instance);
				}
				return r_LayoutMarginEnd;
			}
		}

		/// <summary>
		/// Single LayoutPaddingLeft
		/// </summary>
		protected RProperty r_LayoutPaddingLeft;
		public virtual RProperty RLayoutPaddingLeft
		{
			get
			{
				if(r_LayoutPaddingLeft == null)
				{
					r_LayoutPaddingLeft = new(this, "LayoutPaddingLeft", -1);
					r_LayoutPaddingLeft.SetBelong(this.instance);
				}
				return r_LayoutPaddingLeft;
			}
		}

		/// <summary>
		/// Single LayoutPaddingTop
		/// </summary>
		protected RProperty r_LayoutPaddingTop;
		public virtual RProperty RLayoutPaddingTop
		{
			get
			{
				if(r_LayoutPaddingTop == null)
				{
					r_LayoutPaddingTop = new(this, "LayoutPaddingTop", -1);
					r_LayoutPaddingTop.SetBelong(this.instance);
				}
				return r_LayoutPaddingTop;
			}
		}

		/// <summary>
		/// Single LayoutPaddingRight
		/// </summary>
		protected RProperty r_LayoutPaddingRight;
		public virtual RProperty RLayoutPaddingRight
		{
			get
			{
				if(r_LayoutPaddingRight == null)
				{
					r_LayoutPaddingRight = new(this, "LayoutPaddingRight", -1);
					r_LayoutPaddingRight.SetBelong(this.instance);
				}
				return r_LayoutPaddingRight;
			}
		}

		/// <summary>
		/// Single LayoutPaddingBottom
		/// </summary>
		protected RProperty r_LayoutPaddingBottom;
		public virtual RProperty RLayoutPaddingBottom
		{
			get
			{
				if(r_LayoutPaddingBottom == null)
				{
					r_LayoutPaddingBottom = new(this, "LayoutPaddingBottom", -1);
					r_LayoutPaddingBottom.SetBelong(this.instance);
				}
				return r_LayoutPaddingBottom;
			}
		}

		/// <summary>
		/// Single LayoutBorderLeft
		/// </summary>
		protected RProperty r_LayoutBorderLeft;
		public virtual RProperty RLayoutBorderLeft
		{
			get
			{
				if(r_LayoutBorderLeft == null)
				{
					r_LayoutBorderLeft = new(this, "LayoutBorderLeft", -1);
					r_LayoutBorderLeft.SetBelong(this.instance);
				}
				return r_LayoutBorderLeft;
			}
		}

		/// <summary>
		/// Single LayoutBorderTop
		/// </summary>
		protected RProperty r_LayoutBorderTop;
		public virtual RProperty RLayoutBorderTop
		{
			get
			{
				if(r_LayoutBorderTop == null)
				{
					r_LayoutBorderTop = new(this, "LayoutBorderTop", -1);
					r_LayoutBorderTop.SetBelong(this.instance);
				}
				return r_LayoutBorderTop;
			}
		}

		/// <summary>
		/// Single LayoutBorderRight
		/// </summary>
		protected RProperty r_LayoutBorderRight;
		public virtual RProperty RLayoutBorderRight
		{
			get
			{
				if(r_LayoutBorderRight == null)
				{
					r_LayoutBorderRight = new(this, "LayoutBorderRight", -1);
					r_LayoutBorderRight.SetBelong(this.instance);
				}
				return r_LayoutBorderRight;
			}
		}

		/// <summary>
		/// Single LayoutBorderBottom
		/// </summary>
		protected RProperty r_LayoutBorderBottom;
		public virtual RProperty RLayoutBorderBottom
		{
			get
			{
				if(r_LayoutBorderBottom == null)
				{
					r_LayoutBorderBottom = new(this, "LayoutBorderBottom", -1);
					r_LayoutBorderBottom.SetBelong(this.instance);
				}
				return r_LayoutBorderBottom;
			}
		}

		/// <summary>
		/// Single LayoutPaddingStart
		/// </summary>
		protected RProperty r_LayoutPaddingStart;
		public virtual RProperty RLayoutPaddingStart
		{
			get
			{
				if(r_LayoutPaddingStart == null)
				{
					r_LayoutPaddingStart = new(this, "LayoutPaddingStart", -1);
					r_LayoutPaddingStart.SetBelong(this.instance);
				}
				return r_LayoutPaddingStart;
			}
		}

		/// <summary>
		/// Single LayoutPaddingEnd
		/// </summary>
		protected RProperty r_LayoutPaddingEnd;
		public virtual RProperty RLayoutPaddingEnd
		{
			get
			{
				if(r_LayoutPaddingEnd == null)
				{
					r_LayoutPaddingEnd = new(this, "LayoutPaddingEnd", -1);
					r_LayoutPaddingEnd.SetBelong(this.instance);
				}
				return r_LayoutPaddingEnd;
			}
		}

		/// <summary>
		/// Single ComputedFlexBasis
		/// </summary>
		protected RProperty r_ComputedFlexBasis;
		public virtual RProperty RComputedFlexBasis
		{
			get
			{
				if(r_ComputedFlexBasis == null)
				{
					r_ComputedFlexBasis = new(this, "ComputedFlexBasis", -1);
					r_ComputedFlexBasis.SetBelong(this.instance);
				}
				return r_ComputedFlexBasis;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// Void MarkDirty()
		/// </summary>
		protected RMethod r_MarkDirty;
		public virtual RMethod RMarkDirty
		{
			get
			{
				if(r_MarkDirty == null)
				{
					r_MarkDirty = new(this, "MarkDirty", 0);
					r_MarkDirty.SetBelong(this.instance);
				}
				return r_MarkDirty;
			}
		}

		/// <summary>
		/// Void MarkHasNewLayout()
		/// </summary>
		protected RMethod r_MarkHasNewLayout;
		public virtual RMethod RMarkHasNewLayout
		{
			get
			{
				if(r_MarkHasNewLayout == null)
				{
					r_MarkHasNewLayout = new(this, "MarkHasNewLayout", 0);
					r_MarkHasNewLayout.SetBelong(this.instance);
				}
				return r_MarkHasNewLayout;
			}
		}

		/// <summary>
		/// Void CopyStyle(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_CopyStyle_YogaNode;
		public virtual RMethod RCopyStyle_YogaNode
		{
			get
			{
				if(r_CopyStyle_YogaNode == null)
				{
					r_CopyStyle_YogaNode = new(this, "CopyStyle", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_CopyStyle_YogaNode.SetBelong(this.instance);
				}
				return r_CopyStyle_YogaNode;
			}
		}

		/// <summary>
		/// Void MarkLayoutSeen()
		/// </summary>
		protected RMethod r_MarkLayoutSeen;
		public virtual RMethod RMarkLayoutSeen
		{
			get
			{
				if(r_MarkLayoutSeen == null)
				{
					r_MarkLayoutSeen = new(this, "MarkLayoutSeen", 0);
					r_MarkLayoutSeen.SetBelong(this.instance);
				}
				return r_MarkLayoutSeen;
			}
		}

		/// <summary>
		/// Boolean ValuesEqual(Single, Single)
		/// </summary>
		protected RMethod r_ValuesEqual_Single_Single;
		public virtual RMethod RValuesEqual_Single_Single
		{
			get
			{
				if(r_ValuesEqual_Single_Single == null)
				{
					r_ValuesEqual_Single_Single = new(this, "ValuesEqual", 0, typeof(System.Single), typeof(System.Single));
					r_ValuesEqual_Single_Single.SetBelong(this.instance);
				}
				return r_ValuesEqual_Single_Single;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_Insert_Int32_YogaNode;
		public virtual RMethod RInsert_Int32_YogaNode
		{
			get
			{
				if(r_Insert_Int32_YogaNode == null)
				{
					r_Insert_Int32_YogaNode = new(this, "Insert", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_Insert_Int32_YogaNode.SetBelong(this.instance);
				}
				return r_Insert_Int32_YogaNode;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RemoveAt_Int32 == null)
				{
					r_RemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_AddChild_YogaNode;
		public virtual RMethod RAddChild_YogaNode
		{
			get
			{
				if(r_AddChild_YogaNode == null)
				{
					r_AddChild_YogaNode = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_AddChild_YogaNode.SetBelong(this.instance);
				}
				return r_AddChild_YogaNode;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_RemoveChild_YogaNode;
		public virtual RMethod RRemoveChild_YogaNode
		{
			get
			{
				if(r_RemoveChild_YogaNode == null)
				{
					r_RemoveChild_YogaNode = new(this, "RemoveChild", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_RemoveChild_YogaNode.SetBelong(this.instance);
				}
				return r_RemoveChild_YogaNode;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.Yoga.YogaNode)
		/// </summary>
		protected RMethod r_IndexOf_YogaNode;
		public virtual RMethod RIndexOf_YogaNode
		{
			get
			{
				if(r_IndexOf_YogaNode == null)
				{
					r_IndexOf_YogaNode = new(this, "IndexOf", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"));
					r_IndexOf_YogaNode.SetBelong(this.instance);
				}
				return r_IndexOf_YogaNode;
			}
		}

		/// <summary>
		/// Void SetMeasureFunction(UnityEngine.Yoga.MeasureFunction)
		/// </summary>
		protected RMethod r_SetMeasureFunction_MeasureFunction;
		public virtual RMethod RSetMeasureFunction_MeasureFunction
		{
			get
			{
				if(r_SetMeasureFunction_MeasureFunction == null)
				{
					r_SetMeasureFunction_MeasureFunction = new(this, "SetMeasureFunction", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.MeasureFunction"));
					r_SetMeasureFunction_MeasureFunction.SetBelong(this.instance);
				}
				return r_SetMeasureFunction_MeasureFunction;
			}
		}

		/// <summary>
		/// Void SetBaselineFunction(UnityEngine.Yoga.BaselineFunction)
		/// </summary>
		protected RMethod r_SetBaselineFunction_BaselineFunction;
		public virtual RMethod RSetBaselineFunction_BaselineFunction
		{
			get
			{
				if(r_SetBaselineFunction_BaselineFunction == null)
				{
					r_SetBaselineFunction_BaselineFunction = new(this, "SetBaselineFunction", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.BaselineFunction"));
					r_SetBaselineFunction_BaselineFunction.SetBelong(this.instance);
				}
				return r_SetBaselineFunction_BaselineFunction;
			}
		}

		/// <summary>
		/// Void CalculateLayout(Single, Single)
		/// </summary>
		protected RMethod r_CalculateLayout_Single_Single;
		public virtual RMethod RCalculateLayout_Single_Single
		{
			get
			{
				if(r_CalculateLayout_Single_Single == null)
				{
					r_CalculateLayout_Single_Single = new(this, "CalculateLayout", 0, typeof(System.Single), typeof(System.Single));
					r_CalculateLayout_Single_Single.SetBelong(this.instance);
				}
				return r_CalculateLayout_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize MeasureInternal(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected static RMethod r_MeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public static RMethod RMeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_MeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_MeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), "MeasureInternal", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_MeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(null);
				}
				return r_MeasureInternal_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Single BaselineInternal(UnityEngine.Yoga.YogaNode, Single, Single)
		/// </summary>
		protected static RMethod r_BaselineInternal_YogaNode_Single_Single;
		public static RMethod RBaselineInternal_YogaNode_Single_Single
		{
			get
			{
				if(r_BaselineInternal_YogaNode_Single_Single == null)
				{
					r_BaselineInternal_YogaNode_Single_Single = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), "BaselineInternal", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single), typeof(System.Single));
					r_BaselineInternal_YogaNode_Single_Single.SetBelong(null);
				}
				return r_BaselineInternal_YogaNode_Single_Single;
			}
		}

		/// <summary>
		/// System.String Print(UnityEngine.Yoga.YogaPrintOptions)
		/// </summary>
		protected RMethod r_Print_YogaPrintOptions;
		public virtual RMethod RPrint_YogaPrintOptions
		{
			get
			{
				if(r_Print_YogaPrintOptions == null)
				{
					r_Print_YogaPrintOptions = new(this, "Print", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaPrintOptions"));
					r_Print_YogaPrintOptions.SetBelong(this.instance);
				}
				return r_Print_YogaPrintOptions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[UnityEngine.Yoga.YogaNode] GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_System__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_System__2__Collections__2__IEnumerable__2__GetEnumerator.SetBelong(this.instance);
				}
				return r_System__2__Collections__2__IEnumerable__2__GetEnumerator;
			}
		}

		/// <summary>
		/// Int32 GetInstanceCount()
		/// </summary>
		protected static RMethod r_GetInstanceCount;
		public static RMethod RGetInstanceCount
		{
			get
			{
				if(r_GetInstanceCount == null)
				{
					r_GetInstanceCount = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), "GetInstanceCount", 0);
					r_GetInstanceCount.SetBelong(null);
				}
				return r_GetInstanceCount;
			}
		}

		/// <summary>
		/// Void SetStylePosition(UnityEngine.Yoga.YogaEdge, UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_SetStylePosition_YogaEdge_YogaValue;
		public virtual RMethod RSetStylePosition_YogaEdge_YogaValue
		{
			get
			{
				if(r_SetStylePosition_YogaEdge_YogaValue == null)
				{
					r_SetStylePosition_YogaEdge_YogaValue = new(this, "SetStylePosition", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaEdge"),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_SetStylePosition_YogaEdge_YogaValue.SetBelong(this.instance);
				}
				return r_SetStylePosition_YogaEdge_YogaValue;
			}
		}

		/// <summary>
		/// Void SetStyleMargin(UnityEngine.Yoga.YogaEdge, UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_SetStyleMargin_YogaEdge_YogaValue;
		public virtual RMethod RSetStyleMargin_YogaEdge_YogaValue
		{
			get
			{
				if(r_SetStyleMargin_YogaEdge_YogaValue == null)
				{
					r_SetStyleMargin_YogaEdge_YogaValue = new(this, "SetStyleMargin", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaEdge"),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_SetStyleMargin_YogaEdge_YogaValue.SetBelong(this.instance);
				}
				return r_SetStyleMargin_YogaEdge_YogaValue;
			}
		}

		/// <summary>
		/// Void SetStylePadding(UnityEngine.Yoga.YogaEdge, UnityEngine.Yoga.YogaValue)
		/// </summary>
		protected RMethod r_SetStylePadding_YogaEdge_YogaValue;
		public virtual RMethod RSetStylePadding_YogaEdge_YogaValue
		{
			get
			{
				if(r_SetStylePadding_YogaEdge_YogaValue == null)
				{
					r_SetStylePadding_YogaEdge_YogaValue = new(this, "SetStylePadding", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaEdge"),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaValue"));
					r_SetStylePadding_YogaEdge_YogaValue.SetBelong(this.instance);
				}
				return r_SetStylePadding_YogaEdge_YogaValue;
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


        public RYogaNode() : base("UnityEngine.Yoga.YogaNode")
        {
        }

        public RYogaNode(System.Object instance) : base("UnityEngine.Yoga.YogaNode")
		{
            SetInstance(instance);
		}

        public RYogaNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RYogaNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkHasNewLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkHasNewLayout.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void MarkLayoutSeen()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkLayoutSeen.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValuesEqual(System.Single  @f1, System.Single  @f2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f1, @f2};
            var ___result = RValuesEqual_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void CalculateLayout(System.Single  @width, System.Single  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RCalculateLayout_Single_Single.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Object GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public static System.Int32 GetInstanceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
