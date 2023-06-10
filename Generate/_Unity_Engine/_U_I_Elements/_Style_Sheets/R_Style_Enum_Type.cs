
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.StyleEnumType
	/// </summary>
    public partial class RStyleEnumType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType");
            }
        }

        public RStyleEnumType() : base("UnityEngine.UIElements.StyleSheets.StyleEnumType")
        {
        }

        public RStyleEnumType(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.StyleEnumType")
		{
            SetInstance(instance);
		}

        public RStyleEnumType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleEnumType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Align
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FAlign;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFAlign
		{
			get
			{
				if(r_FAlign == null)
				{
					r_FAlign = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Align");
				}
				return r_FAlign;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType BackgroundPositionKeyword
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FBackgroundPositionKeyword;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFBackgroundPositionKeyword
		{
			get
			{
				if(r_FBackgroundPositionKeyword == null)
				{
					r_FBackgroundPositionKeyword = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "BackgroundPositionKeyword");
				}
				return r_FBackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType BackgroundSizeType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FBackgroundSizeType;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFBackgroundSizeType
		{
			get
			{
				if(r_FBackgroundSizeType == null)
				{
					r_FBackgroundSizeType = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "BackgroundSizeType");
				}
				return r_FBackgroundSizeType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType DisplayStyle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FDisplayStyle;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFDisplayStyle
		{
			get
			{
				if(r_FDisplayStyle == null)
				{
					r_FDisplayStyle = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "DisplayStyle");
				}
				return r_FDisplayStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType EasingMode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FEasingMode;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFEasingMode
		{
			get
			{
				if(r_FEasingMode == null)
				{
					r_FEasingMode = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "EasingMode");
				}
				return r_FEasingMode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType FlexDirection
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FFlexDirection;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFFlexDirection
		{
			get
			{
				if(r_FFlexDirection == null)
				{
					r_FFlexDirection = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "FlexDirection");
				}
				return r_FFlexDirection;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType FontStyle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FFontStyle;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFFontStyle
		{
			get
			{
				if(r_FFontStyle == null)
				{
					r_FFontStyle = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "FontStyle");
				}
				return r_FFontStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Justify
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FJustify;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFJustify
		{
			get
			{
				if(r_FJustify == null)
				{
					r_FJustify = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Justify");
				}
				return r_FJustify;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Overflow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FOverflow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFOverflow
		{
			get
			{
				if(r_FOverflow == null)
				{
					r_FOverflow = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Overflow");
				}
				return r_FOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType OverflowClipBox
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FOverflowClipBox;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFOverflowClipBox
		{
			get
			{
				if(r_FOverflowClipBox == null)
				{
					r_FOverflowClipBox = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "OverflowClipBox");
				}
				return r_FOverflowClipBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType OverflowInternal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FOverflowInternal;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFOverflowInternal
		{
			get
			{
				if(r_FOverflowInternal == null)
				{
					r_FOverflowInternal = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "OverflowInternal");
				}
				return r_FOverflowInternal;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Position
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFPosition
		{
			get
			{
				if(r_FPosition == null)
				{
					r_FPosition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Position");
				}
				return r_FPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Repeat
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FRepeat;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFRepeat
		{
			get
			{
				if(r_FRepeat == null)
				{
					r_FRepeat = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Repeat");
				}
				return r_FRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType RepeatXY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FRepeatXY;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFRepeatXY
		{
			get
			{
				if(r_FRepeatXY == null)
				{
					r_FRepeatXY = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "RepeatXY");
				}
				return r_FRepeatXY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType ScaleMode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FScaleMode;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFScaleMode
		{
			get
			{
				if(r_FScaleMode == null)
				{
					r_FScaleMode = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "ScaleMode");
				}
				return r_FScaleMode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType TextAnchor
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FTextAnchor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFTextAnchor
		{
			get
			{
				if(r_FTextAnchor == null)
				{
					r_FTextAnchor = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "TextAnchor");
				}
				return r_FTextAnchor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType TextOverflow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FTextOverflow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFTextOverflow
		{
			get
			{
				if(r_FTextOverflow == null)
				{
					r_FTextOverflow = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "TextOverflow");
				}
				return r_FTextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType TextOverflowPosition
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FTextOverflowPosition;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFTextOverflowPosition
		{
			get
			{
				if(r_FTextOverflowPosition == null)
				{
					r_FTextOverflowPosition = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "TextOverflowPosition");
				}
				return r_FTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType TransformOriginOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FTransformOriginOffset;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFTransformOriginOffset
		{
			get
			{
				if(r_FTransformOriginOffset == null)
				{
					r_FTransformOriginOffset = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "TransformOriginOffset");
				}
				return r_FTransformOriginOffset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Visibility
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FVisibility;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFVisibility
		{
			get
			{
				if(r_FVisibility == null)
				{
					r_FVisibility = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Visibility");
				}
				return r_FVisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType WhiteSpace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FWhiteSpace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFWhiteSpace
		{
			get
			{
				if(r_FWhiteSpace == null)
				{
					r_FWhiteSpace = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "WhiteSpace");
				}
				return r_FWhiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StyleEnumType Wrap
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType r_FWrap;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType RFWrap
		{
			get
			{
				if(r_FWrap == null)
				{
					r_FWrap = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), "Wrap");
				}
				return r_FWrap;
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
