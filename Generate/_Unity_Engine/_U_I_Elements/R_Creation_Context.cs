
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.CreationContext
	/// </summary>
    public partial class RCreationContext : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.CreationContext);
            }
        }

        public RCreationContext() : base("UnityEngine.UIElements.CreationContext")
        {
        }

        public RCreationContext(System.Object instance) : base("UnityEngine.UIElements.CreationContext")
		{
            SetInstance(instance);
		}

        public RCreationContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCreationContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.CreationContext Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCreationContext r_FDefault;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCreationContext RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new(Type, "Default");
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <target>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_F__0__target__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RF__0__target__1__k__BackingField
		{
			get
			{
				if(r_F__0__target__1__k__BackingField == null)
				{
					r_F__0__target__1__k__BackingField = new(this, "<target>k__BackingField");
				}
				return r_F__0__target__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset <visualTreeAsset>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_F__0__visualTreeAsset__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RF__0__visualTreeAsset__1__k__BackingField
		{
			get
			{
				if(r_F__0__visualTreeAsset__1__k__BackingField == null)
				{
					r_F__0__visualTreeAsset__1__k__BackingField = new(this, "<visualTreeAsset>k__BackingField");
				}
				return r_F__0__visualTreeAsset__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] <slotInsertionPoints>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_F__0__slotInsertionPoints__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RF__0__slotInsertionPoints__1__k__BackingField
		{
			get
			{
				if(r_F__0__slotInsertionPoints__1__k__BackingField == null)
				{
					r_F__0__slotInsertionPoints__1__k__BackingField = new(this, "<slotInsertionPoints>k__BackingField");
				}
				return r_F__0__slotInsertionPoints__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] <attributeOverrides>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_F__0__attributeOverrides__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> RF__0__attributeOverrides__1__k__BackingField
		{
			get
			{
				if(r_F__0__attributeOverrides__1__k__BackingField == null)
				{
					r_F__0__attributeOverrides__1__k__BackingField = new(this, "<attributeOverrides>k__BackingField");
				}
				return r_F__0__attributeOverrides__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAsset
		{
			get
			{
				if(r_PvisualTreeAsset == null)
				{
					r_PvisualTreeAsset = new(this, "visualTreeAsset", -1);
				}
				return r_PvisualTreeAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] slotInsertionPoints
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_PslotInsertionPoints;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RPslotInsertionPoints
		{
			get
			{
				if(r_PslotInsertionPoints == null)
				{
					r_PslotInsertionPoints = new(this, "slotInsertionPoints", -1);
				}
				return r_PslotInsertionPoints;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] attributeOverrides
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_PattributeOverrides;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> RPattributeOverrides
		{
			get
			{
				if(r_PattributeOverrides == null)
				{
					r_PattributeOverrides = new(this, "attributeOverrides", -1);
				}
				return r_PattributeOverrides;
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
		/// Boolean Equals(UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected RMethod r_MEquals_CreationContext;
		public virtual RMethod RMEquals_CreationContext
		{
			get
			{
				if(r_MEquals_CreationContext == null)
				{
					r_MEquals_CreationContext = new(this, "Equals", 0, typeof(UnityEngine.UIElements.CreationContext));
				}
				return r_MEquals_CreationContext;
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
		/// Boolean op_Equality(UnityEngine.UIElements.CreationContext, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected static RMethod r_Mop_Equality_CreationContext_CreationContext;
		public static RMethod RMop_Equality_CreationContext_CreationContext
		{
			get
			{
				if(r_Mop_Equality_CreationContext_CreationContext == null)
				{
					r_Mop_Equality_CreationContext_CreationContext = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.CreationContext), typeof(UnityEngine.UIElements.CreationContext));
				}
				return r_Mop_Equality_CreationContext_CreationContext;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.CreationContext, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CreationContext_CreationContext;
		public static RMethod RMop_Inequality_CreationContext_CreationContext
		{
			get
			{
				if(r_Mop_Inequality_CreationContext_CreationContext == null)
				{
					r_Mop_Inequality_CreationContext_CreationContext = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.CreationContext), typeof(UnityEngine.UIElements.CreationContext));
				}
				return r_Mop_Inequality_CreationContext_CreationContext;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.CreationContext @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_CreationContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.CreationContext @context1, UnityEngine.UIElements.CreationContext @context2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context1, @context2};
            var ___result = RMop_Equality_CreationContext_CreationContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.CreationContext @context1, UnityEngine.UIElements.CreationContext @context2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context1, @context2};
            var ___result = RMop_Inequality_CreationContext_CreationContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
