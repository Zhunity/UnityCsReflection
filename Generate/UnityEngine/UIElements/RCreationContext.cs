using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.CreationContext
	/// </summary>
    public partial class RCreationContext : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.CreationContext Default
		/// </summary>
		protected static RUnityEngine.RUIElements.RCreationContext r_FDefault;
		public static RUnityEngine.RUIElements.RCreationContext RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new(typeof(UnityEngine.UIElements.CreationContext), "Default");
					r_FDefault.SetBelong(null);
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <target>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_F__0__target__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement RF__0__target__1__k__BackingField
		{
			get
			{
				if(r_F__0__target__1__k__BackingField == null)
				{
					r_F__0__target__1__k__BackingField = new(this, "<target>k__BackingField");
					r_F__0__target__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__target__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset <visualTreeAsset>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_F__0__visualTreeAsset__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RF__0__visualTreeAsset__1__k__BackingField
		{
			get
			{
				if(r_F__0__visualTreeAsset__1__k__BackingField == null)
				{
					r_F__0__visualTreeAsset__1__k__BackingField = new(this, "<visualTreeAsset>k__BackingField");
					r_F__0__visualTreeAsset__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__visualTreeAsset__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] <slotInsertionPoints>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RVisualElement> r_F__0__slotInsertionPoints__1__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RVisualElement> RF__0__slotInsertionPoints__1__k__BackingField
		{
			get
			{
				if(r_F__0__slotInsertionPoints__1__k__BackingField == null)
				{
					r_F__0__slotInsertionPoints__1__k__BackingField = new(this, "<slotInsertionPoints>k__BackingField");
					r_F__0__slotInsertionPoints__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__slotInsertionPoints__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] <attributeOverrides>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_F__0__attributeOverrides__1__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> RF__0__attributeOverrides__1__k__BackingField
		{
			get
			{
				if(r_F__0__attributeOverrides__1__k__BackingField == null)
				{
					r_F__0__attributeOverrides__1__k__BackingField = new(this, "<attributeOverrides>k__BackingField");
					r_F__0__attributeOverrides__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__attributeOverrides__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement target
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Ptarget;
		public virtual RUnityEngine.RUIElements.RVisualElement RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
					r_Ptarget.SetBelong(this.instance);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAsset
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAsset;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAsset
		{
			get
			{
				if(r_PvisualTreeAsset == null)
				{
					r_PvisualTreeAsset = new(this, "visualTreeAsset", -1);
					r_PvisualTreeAsset.SetBelong(this.instance);
				}
				return r_PvisualTreeAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] slotInsertionPoints
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RVisualElement> r_PslotInsertionPoints;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RVisualElement> RPslotInsertionPoints
		{
			get
			{
				if(r_PslotInsertionPoints == null)
				{
					r_PslotInsertionPoints = new(this, "slotInsertionPoints", -1);
					r_PslotInsertionPoints.SetBelong(this.instance);
				}
				return r_PslotInsertionPoints;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] attributeOverrides
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_PattributeOverrides;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> RPattributeOverrides
		{
			get
			{
				if(r_PattributeOverrides == null)
				{
					r_PattributeOverrides = new(this, "attributeOverrides", -1);
					r_PattributeOverrides.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MEquals_CreationContext.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_Mop_Equality_CreationContext_CreationContext = new(typeof(UnityEngine.UIElements.CreationContext), "op_Equality", 0, typeof(UnityEngine.UIElements.CreationContext), typeof(UnityEngine.UIElements.CreationContext));
					r_Mop_Equality_CreationContext_CreationContext.SetBelong(null);
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
					r_Mop_Inequality_CreationContext_CreationContext = new(typeof(UnityEngine.UIElements.CreationContext), "op_Inequality", 0, typeof(UnityEngine.UIElements.CreationContext), typeof(UnityEngine.UIElements.CreationContext));
					r_Mop_Inequality_CreationContext_CreationContext.SetBelong(null);
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.CreationContext @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.CreationContext @context1, UnityEngine.UIElements.CreationContext @context2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context1, @context2};
            var ___result = RMop_Equality_CreationContext_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.CreationContext @context1, UnityEngine.UIElements.CreationContext @context2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context1, @context2};
            var ___result = RMop_Inequality_CreationContext_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
