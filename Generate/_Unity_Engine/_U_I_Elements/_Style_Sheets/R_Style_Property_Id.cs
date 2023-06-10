
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.StylePropertyId
	/// </summary>
    public partial class RStylePropertyId : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId");
            }
        }

        public RStylePropertyId() : base("UnityEngine.UIElements.StyleSheets.StylePropertyId")
        {
        }

        public RStylePropertyId(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.StylePropertyId")
		{
            SetInstance(instance);
		}

        public RStylePropertyId(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStylePropertyId(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Unknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnknown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnknown
		{
			get
			{
				if(r_FUnknown == null)
				{
					r_FUnknown = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Unknown");
				}
				return r_FUnknown;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Custom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FCustom;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFCustom
		{
			get
			{
				if(r_FCustom == null)
				{
					r_FCustom = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Custom");
				}
				return r_FCustom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId AlignContent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FAlignContent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFAlignContent
		{
			get
			{
				if(r_FAlignContent == null)
				{
					r_FAlignContent = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "AlignContent");
				}
				return r_FAlignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId AlignItems
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FAlignItems;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFAlignItems
		{
			get
			{
				if(r_FAlignItems == null)
				{
					r_FAlignItems = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "AlignItems");
				}
				return r_FAlignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId AlignSelf
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FAlignSelf;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFAlignSelf
		{
			get
			{
				if(r_FAlignSelf == null)
				{
					r_FAlignSelf = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "AlignSelf");
				}
				return r_FAlignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId All
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FAll;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFAll
		{
			get
			{
				if(r_FAll == null)
				{
					r_FAll = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "All");
				}
				return r_FAll;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundColor
		{
			get
			{
				if(r_FBackgroundColor == null)
				{
					r_FBackgroundColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundColor");
				}
				return r_FBackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundImage
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundImage;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundImage
		{
			get
			{
				if(r_FBackgroundImage == null)
				{
					r_FBackgroundImage = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundImage");
				}
				return r_FBackgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundPosition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundPosition
		{
			get
			{
				if(r_FBackgroundPosition == null)
				{
					r_FBackgroundPosition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundPosition");
				}
				return r_FBackgroundPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundPositionX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundPositionX;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundPositionX
		{
			get
			{
				if(r_FBackgroundPositionX == null)
				{
					r_FBackgroundPositionX = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundPositionX");
				}
				return r_FBackgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundPositionY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundPositionY;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundPositionY
		{
			get
			{
				if(r_FBackgroundPositionY == null)
				{
					r_FBackgroundPositionY = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundPositionY");
				}
				return r_FBackgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundRepeat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundRepeat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundRepeat
		{
			get
			{
				if(r_FBackgroundRepeat == null)
				{
					r_FBackgroundRepeat = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundRepeat");
				}
				return r_FBackgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBackgroundSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBackgroundSize
		{
			get
			{
				if(r_FBackgroundSize == null)
				{
					r_FBackgroundSize = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BackgroundSize");
				}
				return r_FBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderBottomColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderBottomColor
		{
			get
			{
				if(r_FBorderBottomColor == null)
				{
					r_FBorderBottomColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderBottomColor");
				}
				return r_FBorderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomLeftRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderBottomLeftRadius;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderBottomLeftRadius
		{
			get
			{
				if(r_FBorderBottomLeftRadius == null)
				{
					r_FBorderBottomLeftRadius = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderBottomLeftRadius");
				}
				return r_FBorderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomRightRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderBottomRightRadius;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderBottomRightRadius
		{
			get
			{
				if(r_FBorderBottomRightRadius == null)
				{
					r_FBorderBottomRightRadius = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderBottomRightRadius");
				}
				return r_FBorderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderBottomWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderBottomWidth
		{
			get
			{
				if(r_FBorderBottomWidth == null)
				{
					r_FBorderBottomWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderBottomWidth");
				}
				return r_FBorderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderColor
		{
			get
			{
				if(r_FBorderColor == null)
				{
					r_FBorderColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderColor");
				}
				return r_FBorderColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderLeftColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderLeftColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderLeftColor
		{
			get
			{
				if(r_FBorderLeftColor == null)
				{
					r_FBorderLeftColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderLeftColor");
				}
				return r_FBorderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderLeftWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderLeftWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderLeftWidth
		{
			get
			{
				if(r_FBorderLeftWidth == null)
				{
					r_FBorderLeftWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderLeftWidth");
				}
				return r_FBorderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderRadius;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderRadius
		{
			get
			{
				if(r_FBorderRadius == null)
				{
					r_FBorderRadius = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderRadius");
				}
				return r_FBorderRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderRightColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderRightColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderRightColor
		{
			get
			{
				if(r_FBorderRightColor == null)
				{
					r_FBorderRightColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderRightColor");
				}
				return r_FBorderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderRightWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderRightWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderRightWidth
		{
			get
			{
				if(r_FBorderRightWidth == null)
				{
					r_FBorderRightWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderRightWidth");
				}
				return r_FBorderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderTopColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderTopColor
		{
			get
			{
				if(r_FBorderTopColor == null)
				{
					r_FBorderTopColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderTopColor");
				}
				return r_FBorderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopLeftRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderTopLeftRadius;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderTopLeftRadius
		{
			get
			{
				if(r_FBorderTopLeftRadius == null)
				{
					r_FBorderTopLeftRadius = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderTopLeftRadius");
				}
				return r_FBorderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopRightRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderTopRightRadius;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderTopRightRadius
		{
			get
			{
				if(r_FBorderTopRightRadius == null)
				{
					r_FBorderTopRightRadius = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderTopRightRadius");
				}
				return r_FBorderTopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderTopWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderTopWidth
		{
			get
			{
				if(r_FBorderTopWidth == null)
				{
					r_FBorderTopWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderTopWidth");
				}
				return r_FBorderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId BorderWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBorderWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBorderWidth
		{
			get
			{
				if(r_FBorderWidth == null)
				{
					r_FBorderWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "BorderWidth");
				}
				return r_FBorderWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Bottom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FBottom;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFBottom
		{
			get
			{
				if(r_FBottom == null)
				{
					r_FBottom = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Bottom");
				}
				return r_FBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Color
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFColor
		{
			get
			{
				if(r_FColor == null)
				{
					r_FColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Color");
				}
				return r_FColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Cursor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FCursor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFCursor
		{
			get
			{
				if(r_FCursor == null)
				{
					r_FCursor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Cursor");
				}
				return r_FCursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Display
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FDisplay;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFDisplay
		{
			get
			{
				if(r_FDisplay == null)
				{
					r_FDisplay = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Display");
				}
				return r_FDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Flex
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFlex;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFlex
		{
			get
			{
				if(r_FFlex == null)
				{
					r_FFlex = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Flex");
				}
				return r_FFlex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId FlexBasis
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFlexBasis;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFlexBasis
		{
			get
			{
				if(r_FFlexBasis == null)
				{
					r_FFlexBasis = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "FlexBasis");
				}
				return r_FFlexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId FlexDirection
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFlexDirection;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFlexDirection
		{
			get
			{
				if(r_FFlexDirection == null)
				{
					r_FFlexDirection = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "FlexDirection");
				}
				return r_FFlexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId FlexGrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFlexGrow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFlexGrow
		{
			get
			{
				if(r_FFlexGrow == null)
				{
					r_FFlexGrow = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "FlexGrow");
				}
				return r_FFlexGrow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId FlexShrink
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFlexShrink;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFlexShrink
		{
			get
			{
				if(r_FFlexShrink == null)
				{
					r_FFlexShrink = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "FlexShrink");
				}
				return r_FFlexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId FlexWrap
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFlexWrap;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFlexWrap
		{
			get
			{
				if(r_FFlexWrap == null)
				{
					r_FFlexWrap = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "FlexWrap");
				}
				return r_FFlexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId FontSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FFontSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFFontSize
		{
			get
			{
				if(r_FFontSize == null)
				{
					r_FFontSize = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "FontSize");
				}
				return r_FFontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Height
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFHeight
		{
			get
			{
				if(r_FHeight == null)
				{
					r_FHeight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Height");
				}
				return r_FHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId JustifyContent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FJustifyContent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFJustifyContent
		{
			get
			{
				if(r_FJustifyContent == null)
				{
					r_FJustifyContent = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "JustifyContent");
				}
				return r_FJustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Left
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFLeft
		{
			get
			{
				if(r_FLeft == null)
				{
					r_FLeft = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Left");
				}
				return r_FLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId LetterSpacing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FLetterSpacing;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFLetterSpacing
		{
			get
			{
				if(r_FLetterSpacing == null)
				{
					r_FLetterSpacing = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "LetterSpacing");
				}
				return r_FLetterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Margin
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMargin;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMargin
		{
			get
			{
				if(r_FMargin == null)
				{
					r_FMargin = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Margin");
				}
				return r_FMargin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MarginBottom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMarginBottom;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMarginBottom
		{
			get
			{
				if(r_FMarginBottom == null)
				{
					r_FMarginBottom = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MarginBottom");
				}
				return r_FMarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MarginLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMarginLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMarginLeft
		{
			get
			{
				if(r_FMarginLeft == null)
				{
					r_FMarginLeft = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MarginLeft");
				}
				return r_FMarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MarginRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMarginRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMarginRight
		{
			get
			{
				if(r_FMarginRight == null)
				{
					r_FMarginRight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MarginRight");
				}
				return r_FMarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MarginTop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMarginTop;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMarginTop
		{
			get
			{
				if(r_FMarginTop == null)
				{
					r_FMarginTop = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MarginTop");
				}
				return r_FMarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MaxHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMaxHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMaxHeight
		{
			get
			{
				if(r_FMaxHeight == null)
				{
					r_FMaxHeight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MaxHeight");
				}
				return r_FMaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MaxWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMaxWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMaxWidth
		{
			get
			{
				if(r_FMaxWidth == null)
				{
					r_FMaxWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MaxWidth");
				}
				return r_FMaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MinHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMinHeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMinHeight
		{
			get
			{
				if(r_FMinHeight == null)
				{
					r_FMinHeight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MinHeight");
				}
				return r_FMinHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MinWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FMinWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFMinWidth
		{
			get
			{
				if(r_FMinWidth == null)
				{
					r_FMinWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "MinWidth");
				}
				return r_FMinWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Opacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FOpacity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFOpacity
		{
			get
			{
				if(r_FOpacity == null)
				{
					r_FOpacity = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Opacity");
				}
				return r_FOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Overflow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FOverflow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFOverflow
		{
			get
			{
				if(r_FOverflow == null)
				{
					r_FOverflow = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Overflow");
				}
				return r_FOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Padding
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FPadding;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFPadding
		{
			get
			{
				if(r_FPadding == null)
				{
					r_FPadding = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Padding");
				}
				return r_FPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingBottom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FPaddingBottom;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFPaddingBottom
		{
			get
			{
				if(r_FPaddingBottom == null)
				{
					r_FPaddingBottom = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "PaddingBottom");
				}
				return r_FPaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FPaddingLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFPaddingLeft
		{
			get
			{
				if(r_FPaddingLeft == null)
				{
					r_FPaddingLeft = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "PaddingLeft");
				}
				return r_FPaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FPaddingRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFPaddingRight
		{
			get
			{
				if(r_FPaddingRight == null)
				{
					r_FPaddingRight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "PaddingRight");
				}
				return r_FPaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingTop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FPaddingTop;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFPaddingTop
		{
			get
			{
				if(r_FPaddingTop == null)
				{
					r_FPaddingTop = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "PaddingTop");
				}
				return r_FPaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Position
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFPosition
		{
			get
			{
				if(r_FPosition == null)
				{
					r_FPosition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Position");
				}
				return r_FPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Right
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFRight
		{
			get
			{
				if(r_FRight == null)
				{
					r_FRight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Right");
				}
				return r_FRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Rotate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FRotate;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFRotate
		{
			get
			{
				if(r_FRotate == null)
				{
					r_FRotate = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Rotate");
				}
				return r_FRotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Scale
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FScale;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFScale
		{
			get
			{
				if(r_FScale == null)
				{
					r_FScale = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Scale");
				}
				return r_FScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TextOverflow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTextOverflow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTextOverflow
		{
			get
			{
				if(r_FTextOverflow == null)
				{
					r_FTextOverflow = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TextOverflow");
				}
				return r_FTextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TextShadow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTextShadow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTextShadow
		{
			get
			{
				if(r_FTextShadow == null)
				{
					r_FTextShadow = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TextShadow");
				}
				return r_FTextShadow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Top
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTop;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTop
		{
			get
			{
				if(r_FTop == null)
				{
					r_FTop = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Top");
				}
				return r_FTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TransformOrigin
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTransformOrigin;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTransformOrigin
		{
			get
			{
				if(r_FTransformOrigin == null)
				{
					r_FTransformOrigin = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TransformOrigin");
				}
				return r_FTransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Transition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTransition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTransition
		{
			get
			{
				if(r_FTransition == null)
				{
					r_FTransition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Transition");
				}
				return r_FTransition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionDelay
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTransitionDelay;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTransitionDelay
		{
			get
			{
				if(r_FTransitionDelay == null)
				{
					r_FTransitionDelay = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TransitionDelay");
				}
				return r_FTransitionDelay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionDuration
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTransitionDuration;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTransitionDuration
		{
			get
			{
				if(r_FTransitionDuration == null)
				{
					r_FTransitionDuration = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TransitionDuration");
				}
				return r_FTransitionDuration;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTransitionProperty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTransitionProperty
		{
			get
			{
				if(r_FTransitionProperty == null)
				{
					r_FTransitionProperty = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TransitionProperty");
				}
				return r_FTransitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionTimingFunction
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTransitionTimingFunction;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTransitionTimingFunction
		{
			get
			{
				if(r_FTransitionTimingFunction == null)
				{
					r_FTransitionTimingFunction = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "TransitionTimingFunction");
				}
				return r_FTransitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Translate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FTranslate;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFTranslate
		{
			get
			{
				if(r_FTranslate == null)
				{
					r_FTranslate = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Translate");
				}
				return r_FTranslate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityBackgroundImageTintColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityBackgroundImageTintColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityBackgroundImageTintColor
		{
			get
			{
				if(r_FUnityBackgroundImageTintColor == null)
				{
					r_FUnityBackgroundImageTintColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityBackgroundImageTintColor");
				}
				return r_FUnityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityBackgroundScaleMode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityBackgroundScaleMode;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityBackgroundScaleMode
		{
			get
			{
				if(r_FUnityBackgroundScaleMode == null)
				{
					r_FUnityBackgroundScaleMode = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityBackgroundScaleMode");
				}
				return r_FUnityBackgroundScaleMode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityFont
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityFont;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityFont
		{
			get
			{
				if(r_FUnityFont == null)
				{
					r_FUnityFont = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityFont");
				}
				return r_FUnityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityFontDefinition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityFontDefinition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityFontDefinition
		{
			get
			{
				if(r_FUnityFontDefinition == null)
				{
					r_FUnityFontDefinition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityFontDefinition");
				}
				return r_FUnityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityFontStyleAndWeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityFontStyleAndWeight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityFontStyleAndWeight
		{
			get
			{
				if(r_FUnityFontStyleAndWeight == null)
				{
					r_FUnityFontStyleAndWeight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityFontStyleAndWeight");
				}
				return r_FUnityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityOverflowClipBox
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityOverflowClipBox;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityOverflowClipBox
		{
			get
			{
				if(r_FUnityOverflowClipBox == null)
				{
					r_FUnityOverflowClipBox = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityOverflowClipBox");
				}
				return r_FUnityOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityParagraphSpacing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityParagraphSpacing;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityParagraphSpacing
		{
			get
			{
				if(r_FUnityParagraphSpacing == null)
				{
					r_FUnityParagraphSpacing = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityParagraphSpacing");
				}
				return r_FUnityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceBottom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnitySliceBottom;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnitySliceBottom
		{
			get
			{
				if(r_FUnitySliceBottom == null)
				{
					r_FUnitySliceBottom = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnitySliceBottom");
				}
				return r_FUnitySliceBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnitySliceLeft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnitySliceLeft
		{
			get
			{
				if(r_FUnitySliceLeft == null)
				{
					r_FUnitySliceLeft = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnitySliceLeft");
				}
				return r_FUnitySliceLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnitySliceRight;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnitySliceRight
		{
			get
			{
				if(r_FUnitySliceRight == null)
				{
					r_FUnitySliceRight = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnitySliceRight");
				}
				return r_FUnitySliceRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceScale
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnitySliceScale;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnitySliceScale
		{
			get
			{
				if(r_FUnitySliceScale == null)
				{
					r_FUnitySliceScale = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnitySliceScale");
				}
				return r_FUnitySliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceTop
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnitySliceTop;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnitySliceTop
		{
			get
			{
				if(r_FUnitySliceTop == null)
				{
					r_FUnitySliceTop = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnitySliceTop");
				}
				return r_FUnitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextAlign
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityTextAlign;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityTextAlign
		{
			get
			{
				if(r_FUnityTextAlign == null)
				{
					r_FUnityTextAlign = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityTextAlign");
				}
				return r_FUnityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOutline
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityTextOutline;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityTextOutline
		{
			get
			{
				if(r_FUnityTextOutline == null)
				{
					r_FUnityTextOutline = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityTextOutline");
				}
				return r_FUnityTextOutline;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOutlineColor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityTextOutlineColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityTextOutlineColor
		{
			get
			{
				if(r_FUnityTextOutlineColor == null)
				{
					r_FUnityTextOutlineColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityTextOutlineColor");
				}
				return r_FUnityTextOutlineColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOutlineWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityTextOutlineWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityTextOutlineWidth
		{
			get
			{
				if(r_FUnityTextOutlineWidth == null)
				{
					r_FUnityTextOutlineWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityTextOutlineWidth");
				}
				return r_FUnityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOverflowPosition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FUnityTextOverflowPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFUnityTextOverflowPosition
		{
			get
			{
				if(r_FUnityTextOverflowPosition == null)
				{
					r_FUnityTextOverflowPosition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "UnityTextOverflowPosition");
				}
				return r_FUnityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Visibility
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FVisibility;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFVisibility
		{
			get
			{
				if(r_FVisibility == null)
				{
					r_FVisibility = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Visibility");
				}
				return r_FVisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId WhiteSpace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FWhiteSpace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFWhiteSpace
		{
			get
			{
				if(r_FWhiteSpace == null)
				{
					r_FWhiteSpace = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "WhiteSpace");
				}
				return r_FWhiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId Width
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFWidth
		{
			get
			{
				if(r_FWidth == null)
				{
					r_FWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "Width");
				}
				return r_FWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId WordSpacing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_FWordSpacing;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RFWordSpacing
		{
			get
			{
				if(r_FWordSpacing == null)
				{
					r_FWordSpacing = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), "WordSpacing");
				}
				return r_FWordSpacing;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
