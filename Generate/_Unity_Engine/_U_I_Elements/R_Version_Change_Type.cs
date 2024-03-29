
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.VersionChangeType
	/// </summary>
    public partial class RVersionChangeType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType");
            }
        }

        public RVersionChangeType() : base("UnityEngine.UIElements.VersionChangeType")
        {
        }

        public RVersionChangeType(System.Object instance) : base("UnityEngine.UIElements.VersionChangeType")
		{
            SetInstance(instance);
		}

        public RVersionChangeType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVersionChangeType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.VersionChangeType Bindings
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FBindings;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFBindings
		{
			get
			{
				if(r_FBindings == null)
				{
					r_FBindings = new(Type, "Bindings");
				}
				return r_FBindings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType ViewData
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FViewData;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFViewData
		{
			get
			{
				if(r_FViewData == null)
				{
					r_FViewData = new(Type, "ViewData");
				}
				return r_FViewData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Hierarchy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FHierarchy;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFHierarchy
		{
			get
			{
				if(r_FHierarchy == null)
				{
					r_FHierarchy = new(Type, "Hierarchy");
				}
				return r_FHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Layout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FLayout;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFLayout
		{
			get
			{
				if(r_FLayout == null)
				{
					r_FLayout = new(Type, "Layout");
				}
				return r_FLayout;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType StyleSheet
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FStyleSheet;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFStyleSheet
		{
			get
			{
				if(r_FStyleSheet == null)
				{
					r_FStyleSheet = new(Type, "StyleSheet");
				}
				return r_FStyleSheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Styles
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FStyles;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFStyles
		{
			get
			{
				if(r_FStyles == null)
				{
					r_FStyles = new(Type, "Styles");
				}
				return r_FStyles;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Overflow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FOverflow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFOverflow
		{
			get
			{
				if(r_FOverflow == null)
				{
					r_FOverflow = new(Type, "Overflow");
				}
				return r_FOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType BorderRadius
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FBorderRadius;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFBorderRadius
		{
			get
			{
				if(r_FBorderRadius == null)
				{
					r_FBorderRadius = new(Type, "BorderRadius");
				}
				return r_FBorderRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType BorderWidth
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FBorderWidth;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFBorderWidth
		{
			get
			{
				if(r_FBorderWidth == null)
				{
					r_FBorderWidth = new(Type, "BorderWidth");
				}
				return r_FBorderWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Transform
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FTransform;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFTransform
		{
			get
			{
				if(r_FTransform == null)
				{
					r_FTransform = new(Type, "Transform");
				}
				return r_FTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Size
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFSize
		{
			get
			{
				if(r_FSize == null)
				{
					r_FSize = new(Type, "Size");
				}
				return r_FSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Repaint
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FRepaint;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFRepaint
		{
			get
			{
				if(r_FRepaint == null)
				{
					r_FRepaint = new(Type, "Repaint");
				}
				return r_FRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Opacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FOpacity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFOpacity
		{
			get
			{
				if(r_FOpacity == null)
				{
					r_FOpacity = new(Type, "Opacity");
				}
				return r_FOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType Color
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFColor
		{
			get
			{
				if(r_FColor == null)
				{
					r_FColor = new(Type, "Color");
				}
				return r_FColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType RenderHints
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FRenderHints;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFRenderHints
		{
			get
			{
				if(r_FRenderHints == null)
				{
					r_FRenderHints = new(Type, "RenderHints");
				}
				return r_FRenderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType TransitionProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FTransitionProperty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFTransitionProperty
		{
			get
			{
				if(r_FTransitionProperty == null)
				{
					r_FTransitionProperty = new(Type, "TransitionProperty");
				}
				return r_FTransitionProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VersionChangeType EventCallbackCategories
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType r_FEventCallbackCategories;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType RFEventCallbackCategories
		{
			get
			{
				if(r_FEventCallbackCategories == null)
				{
					r_FEventCallbackCategories = new(Type, "EventCallbackCategories");
				}
				return r_FEventCallbackCategories;
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

            return ReflectionUtils.Convert<System.Object>(___result);
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
