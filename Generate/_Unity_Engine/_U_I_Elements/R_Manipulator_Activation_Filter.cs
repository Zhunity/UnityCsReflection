
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ManipulatorActivationFilter
	/// </summary>
    public partial class RManipulatorActivationFilter : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.MouseButton <button>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMouseButton r_F__0__button__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMouseButton RF__0__button__1__k__BackingField
		{
			get
			{
				if(r_F__0__button__1__k__BackingField == null)
				{
					r_F__0__button__1__k__BackingField = new(this, "<button>k__BackingField");
					r_F__0__button__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__button__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers <modifiers>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventModifiers r_F__0__modifiers__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventModifiers RF__0__modifiers__1__k__BackingField
		{
			get
			{
				if(r_F__0__modifiers__1__k__BackingField == null)
				{
					r_F__0__modifiers__1__k__BackingField = new(this, "<modifiers>k__BackingField");
					r_F__0__modifiers__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__modifiers__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <clickCount>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__clickCount__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__clickCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__clickCount__1__k__BackingField == null)
				{
					r_F__0__clickCount__1__k__BackingField = new(this, "<clickCount>k__BackingField");
					r_F__0__clickCount__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__clickCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MouseButton button
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMouseButton r_Pbutton;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMouseButton RPbutton
		{
			get
			{
				if(r_Pbutton == null)
				{
					r_Pbutton = new(this, "button", -1);
					r_Pbutton.SetBelong(this.GetValue());
				}
				return r_Pbutton;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
					r_Pmodifiers.SetBelong(this.GetValue());
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PclickCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPclickCount
		{
			get
			{
				if(r_PclickCount == null)
				{
					r_PclickCount = new(this, "clickCount", -1);
					r_PclickCount.SetBelong(this.GetValue());
				}
				return r_PclickCount;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter)
		/// </summary>
		protected RMethod r_MEquals_ManipulatorActivationFilter;
		public virtual RMethod RMEquals_ManipulatorActivationFilter
		{
			get
			{
				if(r_MEquals_ManipulatorActivationFilter == null)
				{
					r_MEquals_ManipulatorActivationFilter = new(this, "Equals", 0, typeof(UnityEngine.UIElements.ManipulatorActivationFilter));
					r_MEquals_ManipulatorActivationFilter.SetBelong(this.GetValue());
				}
				return r_MEquals_ManipulatorActivationFilter;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Matches(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_MMatches_IMouseEvent;
		public virtual RMethod RMMatches_IMouseEvent
		{
			get
			{
				if(r_MMatches_IMouseEvent == null)
				{
					r_MMatches_IMouseEvent = new(this, "Matches", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_MMatches_IMouseEvent.SetBelong(this.GetValue());
				}
				return r_MMatches_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent)
		/// </summary>
		protected RMethod r_MHasModifiers_IMouseEvent;
		public virtual RMethod RMHasModifiers_IMouseEvent
		{
			get
			{
				if(r_MHasModifiers_IMouseEvent == null)
				{
					r_MHasModifiers_IMouseEvent = new(this, "HasModifiers", 0, typeof(UnityEngine.UIElements.IMouseEvent));
					r_MHasModifiers_IMouseEvent.SetBelong(this.GetValue());
				}
				return r_MHasModifiers_IMouseEvent;
			}
		}

		/// <summary>
		/// Boolean Matches(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_MMatches_IPointerEvent;
		public virtual RMethod RMMatches_IPointerEvent
		{
			get
			{
				if(r_MMatches_IPointerEvent == null)
				{
					r_MMatches_IPointerEvent = new(this, "Matches", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_MMatches_IPointerEvent.SetBelong(this.GetValue());
				}
				return r_MMatches_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_MHasModifiers_IPointerEvent;
		public virtual RMethod RMHasModifiers_IPointerEvent
		{
			get
			{
				if(r_MHasModifiers_IPointerEvent == null)
				{
					r_MHasModifiers_IPointerEvent = new(this, "HasModifiers", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_MHasModifiers_IPointerEvent.SetBelong(this.GetValue());
				}
				return r_MHasModifiers_IPointerEvent;
			}
		}

		/// <summary>
		/// Boolean MatchModifiers(Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MMatchModifiers_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMMatchModifiers_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MMatchModifiers_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MMatchModifiers_Boolean_Boolean_Boolean_Boolean = new(this, "MatchModifiers", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MMatchModifiers_Boolean_Boolean_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MMatchModifiers_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.ManipulatorActivationFilter, UnityEngine.UIElements.ManipulatorActivationFilter)
		/// </summary>
		protected static RMethod r_Mop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter;
		public static RMethod RMop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter
		{
			get
			{
				if(r_Mop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter == null)
				{
					r_Mop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter = new(typeof(UnityEngine.UIElements.ManipulatorActivationFilter), "op_Equality", 0, typeof(UnityEngine.UIElements.ManipulatorActivationFilter), typeof(UnityEngine.UIElements.ManipulatorActivationFilter));
					r_Mop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter.SetBelong(null);
				}
				return r_Mop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.ManipulatorActivationFilter, UnityEngine.UIElements.ManipulatorActivationFilter)
		/// </summary>
		protected static RMethod r_Mop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter;
		public static RMethod RMop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter
		{
			get
			{
				if(r_Mop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter == null)
				{
					r_Mop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter = new(typeof(UnityEngine.UIElements.ManipulatorActivationFilter), "op_Inequality", 0, typeof(UnityEngine.UIElements.ManipulatorActivationFilter), typeof(UnityEngine.UIElements.ManipulatorActivationFilter));
					r_Mop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter.SetBelong(null);
				}
				return r_Mop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter;
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_ManipulatorActivationFilter.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Matches(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMMatches_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMHasModifiers_IMouseEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Matches(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMMatches_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMHasModifiers_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchModifiers(System.Boolean @alt, System.Boolean @ctrl, System.Boolean @shift, System.Boolean @command)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alt, @ctrl, @shift, @command};
            var ___result = RMMatchModifiers_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.ManipulatorActivationFilter @filter1, UnityEngine.UIElements.ManipulatorActivationFilter @filter2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter1, @filter2};
            var ___result = RMop_Equality_ManipulatorActivationFilter_ManipulatorActivationFilter.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.ManipulatorActivationFilter @filter1, UnityEngine.UIElements.ManipulatorActivationFilter @filter2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter1, @filter2};
            var ___result = RMop_Inequality_ManipulatorActivationFilter_ManipulatorActivationFilter.Invoke(___genericsType, ___parameters);

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
