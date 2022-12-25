using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.DebuggerEventDispatchingStrategy
	/// </summary>
    public partial class RDebuggerEventDispatchingStrategy : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IGlobalPanelDebugger s_GlobalPanelDebug
		/// </summary>
		protected static RUnityEngine.RUIElements.RIGlobalPanelDebugger r_s_GlobalPanelDebug;
		public static RUnityEngine.RUIElements.RIGlobalPanelDebugger Rs_GlobalPanelDebug
		{
			get
			{
				if(r_s_GlobalPanelDebug == null)
				{
					r_s_GlobalPanelDebug = new( ReleactionUtils.GetType("UnityEngine.UIElements.DebuggerEventDispatchingStrategy"), "s_GlobalPanelDebug");
					r_s_GlobalPanelDebug.SetBelong(null);
				}
				return r_s_GlobalPanelDebug;
			}
		}

		/// <summary>
		/// Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RCanDispatchEvent_EventBase;
		public virtual RMethod RCanDispatchEvent_EventBase
		{
			get
			{
				if(r_RCanDispatchEvent_EventBase == null)
				{
					r_RCanDispatchEvent_EventBase = new(this, "CanDispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RCanDispatchEvent_EventBase.SetBelong(this.instance);
				}
				return r_RCanDispatchEvent_EventBase;
			}
		}

		/// <summary>
		/// Void DispatchEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RDispatchEvent_EventBase_IPanel;
		public virtual RMethod RDispatchEvent_EventBase_IPanel
		{
			get
			{
				if(r_RDispatchEvent_EventBase_IPanel == null)
				{
					r_RDispatchEvent_EventBase_IPanel = new(this, "DispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_RDispatchEvent_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_RDispatchEvent_EventBase_IPanel;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RPostDispatch_EventBase_IPanel;
		public virtual RMethod RPostDispatch_EventBase_IPanel
		{
			get
			{
				if(r_RPostDispatch_EventBase_IPanel == null)
				{
					r_RPostDispatch_EventBase_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_RPostDispatch_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_RPostDispatch_EventBase_IPanel;
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


        public RDebuggerEventDispatchingStrategy() : base("UnityEngine.UIElements.DebuggerEventDispatchingStrategy")
        {
        }

        public RDebuggerEventDispatchingStrategy(System.Object instance) : base("UnityEngine.UIElements.DebuggerEventDispatchingStrategy")
		{
            SetInstance(instance);
		}

        public RDebuggerEventDispatchingStrategy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDebuggerEventDispatchingStrategy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RCanDispatchEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DispatchEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RDispatchEvent_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RPostDispatch_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
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
