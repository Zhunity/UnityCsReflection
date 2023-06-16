
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.VisualElementFlags
	/// </summary>
    public partial class RVisualElementFlags : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementFlags");
            }
        }

        public RVisualElementFlags() : base("UnityEngine.UIElements.VisualElementFlags")
        {
        }

        public RVisualElementFlags(System.Object instance) : base("UnityEngine.UIElements.VisualElementFlags")
		{
            SetInstance(instance);
		}

        public RVisualElementFlags(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualElementFlags(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.VisualElementFlags WorldTransformDirty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FWorldTransformDirty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFWorldTransformDirty
		{
			get
			{
				if(r_FWorldTransformDirty == null)
				{
					r_FWorldTransformDirty = new(Type, "WorldTransformDirty");
				}
				return r_FWorldTransformDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags WorldTransformInverseDirty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FWorldTransformInverseDirty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFWorldTransformInverseDirty
		{
			get
			{
				if(r_FWorldTransformInverseDirty == null)
				{
					r_FWorldTransformInverseDirty = new(Type, "WorldTransformInverseDirty");
				}
				return r_FWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags WorldClipDirty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FWorldClipDirty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFWorldClipDirty
		{
			get
			{
				if(r_FWorldClipDirty == null)
				{
					r_FWorldClipDirty = new(Type, "WorldClipDirty");
				}
				return r_FWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags BoundingBoxDirty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FBoundingBoxDirty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFBoundingBoxDirty
		{
			get
			{
				if(r_FBoundingBoxDirty == null)
				{
					r_FBoundingBoxDirty = new(Type, "BoundingBoxDirty");
				}
				return r_FBoundingBoxDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags WorldBoundingBoxDirty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FWorldBoundingBoxDirty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFWorldBoundingBoxDirty
		{
			get
			{
				if(r_FWorldBoundingBoxDirty == null)
				{
					r_FWorldBoundingBoxDirty = new(Type, "WorldBoundingBoxDirty");
				}
				return r_FWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags EventCallbackParentCategoriesDirty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FEventCallbackParentCategoriesDirty;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_FEventCallbackParentCategoriesDirty == null)
				{
					r_FEventCallbackParentCategoriesDirty = new(Type, "EventCallbackParentCategoriesDirty");
				}
				return r_FEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags LayoutManual
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FLayoutManual;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFLayoutManual
		{
			get
			{
				if(r_FLayoutManual == null)
				{
					r_FLayoutManual = new(Type, "LayoutManual");
				}
				return r_FLayoutManual;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags CompositeRoot
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FCompositeRoot;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFCompositeRoot
		{
			get
			{
				if(r_FCompositeRoot == null)
				{
					r_FCompositeRoot = new(Type, "CompositeRoot");
				}
				return r_FCompositeRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags RequireMeasureFunction
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FRequireMeasureFunction;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFRequireMeasureFunction
		{
			get
			{
				if(r_FRequireMeasureFunction == null)
				{
					r_FRequireMeasureFunction = new(Type, "RequireMeasureFunction");
				}
				return r_FRequireMeasureFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags EnableViewDataPersistence
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FEnableViewDataPersistence;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFEnableViewDataPersistence
		{
			get
			{
				if(r_FEnableViewDataPersistence == null)
				{
					r_FEnableViewDataPersistence = new(Type, "EnableViewDataPersistence");
				}
				return r_FEnableViewDataPersistence;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags DisableClipping
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FDisableClipping;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFDisableClipping
		{
			get
			{
				if(r_FDisableClipping == null)
				{
					r_FDisableClipping = new(Type, "DisableClipping");
				}
				return r_FDisableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags NeedsAttachToPanelEvent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FNeedsAttachToPanelEvent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFNeedsAttachToPanelEvent
		{
			get
			{
				if(r_FNeedsAttachToPanelEvent == null)
				{
					r_FNeedsAttachToPanelEvent = new(Type, "NeedsAttachToPanelEvent");
				}
				return r_FNeedsAttachToPanelEvent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags HierarchyDisplayed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FHierarchyDisplayed;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFHierarchyDisplayed
		{
			get
			{
				if(r_FHierarchyDisplayed == null)
				{
					r_FHierarchyDisplayed = new(Type, "HierarchyDisplayed");
				}
				return r_FHierarchyDisplayed;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags StyleInitialized
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FStyleInitialized;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFStyleInitialized
		{
			get
			{
				if(r_FStyleInitialized == null)
				{
					r_FStyleInitialized = new(Type, "StyleInitialized");
				}
				return r_FStyleInitialized;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags Init
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FInit;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFInit
		{
			get
			{
				if(r_FInit == null)
				{
					r_FInit = new(Type, "Init");
				}
				return r_FInit;
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
