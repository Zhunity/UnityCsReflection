
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
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F__0__displayMenuHandledOSX__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF__0__displayMenuHandledOSX__1__k__BackingField
		{
			get
			{
				if(r_F__0__displayMenuHandledOSX__1__k__BackingField == null)
				{
					r_F__0__displayMenuHandledOSX__1__k__BackingField = new(this, "<displayMenuHandledOSX>k__BackingField");
					r_F__0__displayMenuHandledOSX__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__displayMenuHandledOSX__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean displayMenuHandledOSX
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PdisplayMenuHandledOSX;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPdisplayMenuHandledOSX
		{
			get
			{
				if(r_PdisplayMenuHandledOSX == null)
				{
					r_PdisplayMenuHandledOSX = new(this, "displayMenuHandledOSX", -1);
					r_PdisplayMenuHandledOSX.SetBelong(this.instance);
				}
				return r_PdisplayMenuHandledOSX;
			}
		}

		/// <summary>
		/// Void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MDisplayMenuIfEventMatches_EventBase_IEventHandler;
		public virtual RMethod RMDisplayMenuIfEventMatches_EventBase_IEventHandler
		{
			get
			{
				if(r_MDisplayMenuIfEventMatches_EventBase_IEventHandler == null)
				{
					r_MDisplayMenuIfEventMatches_EventBase_IEventHandler = new(this, "DisplayMenuIfEventMatches", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_MDisplayMenuIfEventMatches_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_MDisplayMenuIfEventMatches_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void DisplayMenu(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MDisplayMenu_EventBase_IEventHandler;
		public virtual RMethod RMDisplayMenu_EventBase_IEventHandler
		{
			get
			{
				if(r_MDisplayMenu_EventBase_IEventHandler == null)
				{
					r_MDisplayMenu_EventBase_IEventHandler = new(this, "DisplayMenu", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_MDisplayMenu_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_MDisplayMenu_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MDoDisplayMenu_DropdownMenu_EventBase;
		public virtual RMethod RMDoDisplayMenu_DropdownMenu_EventBase
		{
			get
			{
				if(r_MDoDisplayMenu_DropdownMenu_EventBase == null)
				{
					r_MDoDisplayMenu_DropdownMenu_EventBase = new(this, "DoDisplayMenu", 0, typeof(UnityEngine.UIElements.DropdownMenu), typeof(UnityEngine.UIElements.EventBase));
					r_MDoDisplayMenu_DropdownMenu_EventBase.SetBelong(this.instance);
				}
				return r_MDoDisplayMenu_DropdownMenu_EventBase;
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

        public virtual void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IEventHandler @eventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @eventHandler};
            var ___result = RMDisplayMenuIfEventMatches_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DisplayMenu(UnityEngine.UIElements.EventBase @triggerEvent, UnityEngine.UIElements.IEventHandler @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@triggerEvent, @target};
            var ___result = RMDisplayMenu_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu @menu, UnityEngine.UIElements.EventBase @triggerEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@menu, @triggerEvent};
            var ___result = RMDoDisplayMenu_DropdownMenu_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
