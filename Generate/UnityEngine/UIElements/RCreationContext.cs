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
		protected static RUnityEngine.RUIElements.RCreationContext r_Default;
		public static RUnityEngine.RUIElements.RCreationContext RDefault
		{
			get
			{
				if(r_Default == null)
				{
					r_Default = new(typeof(UnityEngine.UIElements.CreationContext), "Default");
					r_Default.SetBelong(null);
				}
				return r_Default;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <target>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__target__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__target__1__k__BackingField
		{
			get
			{
				if(r___0__target__1__k__BackingField == null)
				{
					r___0__target__1__k__BackingField = new(this, "<target>k__BackingField");
					r___0__target__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__target__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset <visualTreeAsset>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r___0__visualTreeAsset__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset R__0__visualTreeAsset__1__k__BackingField
		{
			get
			{
				if(r___0__visualTreeAsset__1__k__BackingField == null)
				{
					r___0__visualTreeAsset__1__k__BackingField = new(this, "<visualTreeAsset>k__BackingField");
					r___0__visualTreeAsset__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__visualTreeAsset__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] <slotInsertionPoints>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RVisualElement> r___0__slotInsertionPoints__1__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RVisualElement> R__0__slotInsertionPoints__1__k__BackingField
		{
			get
			{
				if(r___0__slotInsertionPoints__1__k__BackingField == null)
				{
					r___0__slotInsertionPoints__1__k__BackingField = new(this, "<slotInsertionPoints>k__BackingField");
					r___0__slotInsertionPoints__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__slotInsertionPoints__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] <attributeOverrides>k__BackingField
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r___0__attributeOverrides__1__k__BackingField;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> R__0__attributeOverrides__1__k__BackingField
		{
			get
			{
				if(r___0__attributeOverrides__1__k__BackingField == null)
				{
					r___0__attributeOverrides__1__k__BackingField = new(this, "<attributeOverrides>k__BackingField");
					r___0__attributeOverrides__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__attributeOverrides__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement target
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_target;
		public virtual RUnityEngine.RUIElements.RVisualElement Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target", -1);
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAsset
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_visualTreeAsset;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RvisualTreeAsset
		{
			get
			{
				if(r_visualTreeAsset == null)
				{
					r_visualTreeAsset = new(this, "visualTreeAsset", -1);
					r_visualTreeAsset.SetBelong(this.instance);
				}
				return r_visualTreeAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] slotInsertionPoints
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RUIElements.RVisualElement> r_slotInsertionPoints;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RUIElements.RVisualElement> RslotInsertionPoints
		{
			get
			{
				if(r_slotInsertionPoints == null)
				{
					r_slotInsertionPoints = new(this, "slotInsertionPoints", -1);
					r_slotInsertionPoints.SetBelong(this.instance);
				}
				return r_slotInsertionPoints;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] attributeOverrides
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_attributeOverrides;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> RattributeOverrides
		{
			get
			{
				if(r_attributeOverrides == null)
				{
					r_attributeOverrides = new(this, "attributeOverrides", -1);
					r_attributeOverrides.SetBelong(this.instance);
				}
				return r_attributeOverrides;
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
		/// Boolean Equals(UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected RMethod r_Equals_CreationContext;
		public virtual RMethod REquals_CreationContext
		{
			get
			{
				if(r_Equals_CreationContext == null)
				{
					r_Equals_CreationContext = new(this, "Equals", 0, typeof(UnityEngine.UIElements.CreationContext));
					r_Equals_CreationContext.SetBelong(this.instance);
				}
				return r_Equals_CreationContext;
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
		/// Boolean op_Equality(UnityEngine.UIElements.CreationContext, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected static RMethod r_op_Equality_CreationContext_CreationContext;
		public static RMethod Rop_Equality_CreationContext_CreationContext
		{
			get
			{
				if(r_op_Equality_CreationContext_CreationContext == null)
				{
					r_op_Equality_CreationContext_CreationContext = new(typeof(UnityEngine.UIElements.CreationContext), "op_Equality", 0, typeof(UnityEngine.UIElements.CreationContext), typeof(UnityEngine.UIElements.CreationContext));
					r_op_Equality_CreationContext_CreationContext.SetBelong(null);
				}
				return r_op_Equality_CreationContext_CreationContext;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.CreationContext, UnityEngine.UIElements.CreationContext)
		/// </summary>
		protected static RMethod r_op_Inequality_CreationContext_CreationContext;
		public static RMethod Rop_Inequality_CreationContext_CreationContext
		{
			get
			{
				if(r_op_Inequality_CreationContext_CreationContext == null)
				{
					r_op_Inequality_CreationContext_CreationContext = new(typeof(UnityEngine.UIElements.CreationContext), "op_Inequality", 0, typeof(UnityEngine.UIElements.CreationContext), typeof(UnityEngine.UIElements.CreationContext));
					r_op_Inequality_CreationContext_CreationContext.SetBelong(null);
				}
				return r_op_Inequality_CreationContext_CreationContext;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.CreationContext  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.CreationContext  @context1, UnityEngine.UIElements.CreationContext  @context2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context1, @context2};
            var ___result = Rop_Equality_CreationContext_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.CreationContext  @context1, UnityEngine.UIElements.CreationContext  @context2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context1, @context2};
            var ___result = Rop_Inequality_CreationContext_CreationContext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
