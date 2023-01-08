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
		protected RField r___0__displayMenuHandledOSX__1__k__BackingField;
		public virtual RField R__0__displayMenuHandledOSX__1__k__BackingField
		{
			get
			{
				if(r___0__displayMenuHandledOSX__1__k__BackingField == null)
				{
					r___0__displayMenuHandledOSX__1__k__BackingField = new(this, "<displayMenuHandledOSX>k__BackingField");
					r___0__displayMenuHandledOSX__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__displayMenuHandledOSX__1__k__BackingField;
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
		protected RMethod r_DisplayMenuIfEventMatches_EventBase_IEventHandler;
		public virtual RMethod RDisplayMenuIfEventMatches_EventBase_IEventHandler
		{
			get
			{
				if(r_DisplayMenuIfEventMatches_EventBase_IEventHandler == null)
				{
					r_DisplayMenuIfEventMatches_EventBase_IEventHandler = new(this, "DisplayMenuIfEventMatches", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_DisplayMenuIfEventMatches_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_DisplayMenuIfEventMatches_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void DisplayMenu(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_DisplayMenu_EventBase_IEventHandler;
		public virtual RMethod RDisplayMenu_EventBase_IEventHandler
		{
			get
			{
				if(r_DisplayMenu_EventBase_IEventHandler == null)
				{
					r_DisplayMenu_EventBase_IEventHandler = new(this, "DisplayMenu", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_DisplayMenu_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_DisplayMenu_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_DoDisplayMenu_DropdownMenu_EventBase;
		public virtual RMethod RDoDisplayMenu_DropdownMenu_EventBase
		{
			get
			{
				if(r_DoDisplayMenu_DropdownMenu_EventBase == null)
				{
					r_DoDisplayMenu_DropdownMenu_EventBase = new(this, "DoDisplayMenu", 0, typeof(UnityEngine.UIElements.DropdownMenu), typeof(UnityEngine.UIElements.EventBase));
					r_DoDisplayMenu_DropdownMenu_EventBase.SetBelong(this.instance);
				}
				return r_DoDisplayMenu_DropdownMenu_EventBase;
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
