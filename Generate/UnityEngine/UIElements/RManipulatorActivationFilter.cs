using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ManipulatorActivationFilter
	/// </summary>
    public partial class RManipulatorActivationFilter : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.MouseButton <button>k__BackingField
		/// </summary>
		protected RField r___1__button__2__k__BackingField;
		public virtual RField R__1__button__2__k__BackingField
		{
			get
			{
				if(r___1__button__2__k__BackingField == null)
				{
					r___1__button__2__k__BackingField = new(this, "<button>k__BackingField");
					r___1__button__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__button__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers <modifiers>k__BackingField
		/// </summary>
		protected RField r___1__modifiers__2__k__BackingField;
		public virtual RField R__1__modifiers__2__k__BackingField
		{
			get
			{
				if(r___1__modifiers__2__k__BackingField == null)
				{
					r___1__modifiers__2__k__BackingField = new(this, "<modifiers>k__BackingField");
					r___1__modifiers__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__modifiers__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <clickCount>k__BackingField
		/// </summary>
		protected RField r___1__clickCount__2__k__BackingField;
		public virtual RField R__1__clickCount__2__k__BackingField
		{
			get
			{
				if(r___1__clickCount__2__k__BackingField == null)
				{
					r___1__clickCount__2__k__BackingField = new(this, "<clickCount>k__BackingField");
					r___1__clickCount__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__clickCount__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MouseButton button
		/// </summary>
		protected RProperty r_button;
		public virtual RProperty Rbutton
		{
			get
			{
				if(r_button == null)
				{
					r_button = new(this, "button", -1);
					r_button.SetBelong(this.instance);
				}
				return r_button;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RProperty r_modifiers;
		public virtual RProperty Rmodifiers
		{
			get
			{
				if(r_modifiers == null)
				{
					r_modifiers = new(this, "modifiers", -1);
					r_modifiers.SetBelong(this.instance);
				}
				return r_modifiers;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RProperty r_clickCount;
		public virtual RProperty RclickCount
		{
			get
			{
				if(r_clickCount == null)
				{
					r_clickCount = new(this, "clickCount", -1);
					r_clickCount.SetBelong(this.instance);
				}
				return r_clickCount;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter)
		/// </summary>
		protected RMethod r_REquals_ManipulatorActivationFilter;
		public virtual RMethod REquals_ManipulatorActivationFilter
		{
			get
			{
				if(r_REquals_ManipulatorActivationFilter == null)
				{
					r_REquals_ManipulatorActivationFilter = new(this, "Equals", 0, typeof(UnityEngine.UIElements.ManipulatorActivationFilter));
					r_REquals_ManipulatorActivationFilter.SetBelong(this.instance);
				}
				return r_REquals_ManipulatorActivationFilter;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Matches(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_RMatches_IMouseEvent;
		public virtual RMethod RMatches_IMouseEvent
		{
			get
			{
				if(r_RMatches_IMouseEvent == null)
				{
					r_RMatches_IMouseEvent = new(this, "Matches", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_RMatches_IMouseEvent.SetBelong(this.instance);
				}
				return r_RMatches_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_RHasModifiers_IMouseEvent;
		public virtual RMethod RHasModifiers_IMouseEvent
		{
			get
			{
				if(r_RHasModifiers_IMouseEvent == null)
				{
					r_RHasModifiers_IMouseEvent = new(this, "HasModifiers", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_RHasModifiers_IMouseEvent.SetBelong(this.instance);
				}
				return r_RHasModifiers_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean Matches(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_RMatches_IPointerEvent;
		public virtual RMethod RMatches_IPointerEvent
		{
			get
			{
				if(r_RMatches_IPointerEvent == null)
				{
					r_RMatches_IPointerEvent = new(this, "Matches", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_RMatches_IPointerEvent.SetBelong(this.instance);
				}
				return r_RMatches_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_RHasModifiers_IPointerEvent;
		public virtual RMethod RHasModifiers_IPointerEvent
		{
			get
			{
				if(r_RHasModifiers_IPointerEvent == null)
				{
					r_RHasModifiers_IPointerEvent = new(this, "HasModifiers", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_RHasModifiers_IPointerEvent.SetBelong(this.instance);
				}
				return r_RHasModifiers_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean MatchModifiers(Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RMatchModifiers_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMatchModifiers_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_RMatchModifiers_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_RMatchModifiers_Boolean_Boolean_Boolean_Boolean = new(this, "MatchModifiers", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_RMatchModifiers_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RMatchModifiers_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.ManipulatorActivationFilter, UnityEngine.UIElements.ManipulatorActivationFilter)
		/// </summary>
		protected static RMethod r_Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter;
		public static RMethod Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter
		{
			get
			{
				if(r_Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter == null)
				{
					r_Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter = new(typeof(UnityEngine.UIElements.ManipulatorActivationFilter), "op_Equality", 0, typeof(UnityEngine.UIElements.ManipulatorActivationFilter), typeof(UnityEngine.UIElements.ManipulatorActivationFilter));
					r_Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter.SetBelong(null);
				}
				return r_Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.ManipulatorActivationFilter, UnityEngine.UIElements.ManipulatorActivationFilter)
		/// </summary>
		protected static RMethod r_Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter;
		public static RMethod Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter
		{
			get
			{
				if(r_Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter == null)
				{
					r_Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter = new(typeof(UnityEngine.UIElements.ManipulatorActivationFilter), "op_Inequality", 0, typeof(UnityEngine.UIElements.ManipulatorActivationFilter), typeof(UnityEngine.UIElements.ManipulatorActivationFilter));
					r_Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter.SetBelong(null);
				}
				return r_Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RManipulatorActivationFilter() : base("UnityEngine.UIElements.ManipulatorActivationFilter")
        {
        }

        public RManipulatorActivationFilter(System.Object instance) : base("UnityEngine.UIElements.ManipulatorActivationFilter")
		{
            SetInstance(instance);
		}

        public RManipulatorActivationFilter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RManipulatorActivationFilter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_ManipulatorActivationFilter.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Matches(UnityEngine.UIElements.IMouseEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMatches_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RHasModifiers_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Matches(UnityEngine.UIElements.IPointerEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMatches_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RHasModifiers_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchModifiers(System.Boolean  @alt, System.Boolean  @ctrl, System.Boolean  @shift, System.Boolean  @command)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alt, @ctrl, @shift, @command};
            var ___result = RMatchModifiers_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.ManipulatorActivationFilter  @filter1, UnityEngine.UIElements.ManipulatorActivationFilter  @filter2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter1, @filter2};
            var ___result = Rop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.ManipulatorActivationFilter  @filter1, UnityEngine.UIElements.ManipulatorActivationFilter  @filter2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter1, @filter2};
            var ___result = Rop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter.Invoke(___genericsType, ___parameters);

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
