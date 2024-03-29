
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes
	/// </summary>
    public partial class RRenderDataDirtyTypes : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderDataDirtyTypes");
            }
        }

        public RRenderDataDirtyTypes() : base("UnityEngine.UIElements.UIR.RenderDataDirtyTypes")
        {
        }

        public RRenderDataDirtyTypes(System.Object instance) : base("UnityEngine.UIElements.UIR.RenderDataDirtyTypes")
		{
            SetInstance(instance);
		}

        public RRenderDataDirtyTypes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderDataDirtyTypes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(Type, "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes Transform
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FTransform;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFTransform
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
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes ClipRectSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FClipRectSize;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFClipRectSize
		{
			get
			{
				if(r_FClipRectSize == null)
				{
					r_FClipRectSize = new(Type, "ClipRectSize");
				}
				return r_FClipRectSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes Clipping
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FClipping;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFClipping
		{
			get
			{
				if(r_FClipping == null)
				{
					r_FClipping = new(Type, "Clipping");
				}
				return r_FClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes ClippingHierarchy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FClippingHierarchy;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFClippingHierarchy
		{
			get
			{
				if(r_FClippingHierarchy == null)
				{
					r_FClippingHierarchy = new(Type, "ClippingHierarchy");
				}
				return r_FClippingHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes Visuals
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FVisuals;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFVisuals
		{
			get
			{
				if(r_FVisuals == null)
				{
					r_FVisuals = new(Type, "Visuals");
				}
				return r_FVisuals;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes VisualsHierarchy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FVisualsHierarchy;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFVisualsHierarchy
		{
			get
			{
				if(r_FVisualsHierarchy == null)
				{
					r_FVisualsHierarchy = new(Type, "VisualsHierarchy");
				}
				return r_FVisualsHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes VisualsOpacityId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FVisualsOpacityId;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFVisualsOpacityId
		{
			get
			{
				if(r_FVisualsOpacityId == null)
				{
					r_FVisualsOpacityId = new(Type, "VisualsOpacityId");
				}
				return r_FVisualsOpacityId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes Opacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FOpacity;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFOpacity
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
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes OpacityHierarchy
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FOpacityHierarchy;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFOpacityHierarchy
		{
			get
			{
				if(r_FOpacityHierarchy == null)
				{
					r_FOpacityHierarchy = new(Type, "OpacityHierarchy");
				}
				return r_FOpacityHierarchy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes Color
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FColor;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFColor
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
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes AllVisuals
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FAllVisuals;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFAllVisuals
		{
			get
			{
				if(r_FAllVisuals == null)
				{
					r_FAllVisuals = new(Type, "AllVisuals");
				}
				return r_FAllVisuals;
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
