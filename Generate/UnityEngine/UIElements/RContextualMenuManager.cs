using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ContextualMenuManager
	/// </summary>
    public partial class RContextualMenuManager : RMember //
    {

		/// <summary>
		/// System.Boolean <displayMenuHandledOSX>k__BackingField
		/// </summary>
		protected RField r___1__displayMenuHandledOSX__2__k__BackingField;
		public virtual RField R__1__displayMenuHandledOSX__2__k__BackingField
		{
			get
			{
				if(r___1__displayMenuHandledOSX__2__k__BackingField == null)
				{
					r___1__displayMenuHandledOSX__2__k__BackingField = new(this, "<displayMenuHandledOSX>k__BackingField");
					r___1__displayMenuHandledOSX__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__displayMenuHandledOSX__2__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean displayMenuHandledOSX
		/// </summary>
		protected RProperty r_displayMenuHandledOSX;
		public virtual RProperty RdisplayMenuHandledOSX
		{
			get
			{
				if(r_displayMenuHandledOSX == null)
				{
					r_displayMenuHandledOSX = new(this, "displayMenuHandledOSX", -1);
					r_displayMenuHandledOSX.SetBelong(this.instance);
				}
				return r_displayMenuHandledOSX;
			}
		}

		/// <summary>
		/// Void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RDisplayMenuIfEventMatches_EventBase_IEventHandler;
		public virtual RMethod RDisplayMenuIfEventMatches_EventBase_IEventHandler
		{
			get
			{
				if(r_RDisplayMenuIfEventMatches_EventBase_IEventHandler == null)
				{
					r_RDisplayMenuIfEventMatches_EventBase_IEventHandler = new(this, "DisplayMenuIfEventMatches", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_RDisplayMenuIfEventMatches_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_RDisplayMenuIfEventMatches_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void DisplayMenu(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RDisplayMenu_EventBase_IEventHandler;
		public virtual RMethod RDisplayMenu_EventBase_IEventHandler
		{
			get
			{
				if(r_RDisplayMenu_EventBase_IEventHandler == null)
				{
					r_RDisplayMenu_EventBase_IEventHandler = new(this, "DisplayMenu", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_RDisplayMenu_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_RDisplayMenu_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RDoDisplayMenu_DropdownMenu_EventBase;
		public virtual RMethod RDoDisplayMenu_DropdownMenu_EventBase
		{
			get
			{
				if(r_RDoDisplayMenu_DropdownMenu_EventBase == null)
				{
					r_RDoDisplayMenu_DropdownMenu_EventBase = new(this, "DoDisplayMenu", 0, typeof(UnityEngine.UIElements.DropdownMenu), typeof(UnityEngine.UIElements.EventBase));
					r_RDoDisplayMenu_DropdownMenu_EventBase.SetBelong(this.instance);
				}
				return r_RDoDisplayMenu_DropdownMenu_EventBase;
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


        public RContextualMenuManager() : base("UnityEngine.UIElements.ContextualMenuManager")
        {
        }

        public RContextualMenuManager(System.Object instance) : base("UnityEngine.UIElements.ContextualMenuManager")
		{
            SetInstance(instance);
		}

        public RContextualMenuManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RContextualMenuManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IEventHandler  @eventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @eventHandler};
            var ___result = RDisplayMenuIfEventMatches_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisplayMenu(UnityEngine.UIElements.EventBase  @triggerEvent, UnityEngine.UIElements.IEventHandler  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triggerEvent, @target};
            var ___result = RDisplayMenu_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu  @menu, UnityEngine.UIElements.EventBase  @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @triggerEvent};
            var ___result = RDoDisplayMenu_DropdownMenu_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
