
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
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIGlobalPanelDebugger r_Fs_GlobalPanelDebug;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIGlobalPanelDebugger RFs_GlobalPanelDebug
		{
			get
			{
				if(r_Fs_GlobalPanelDebug == null)
				{
					r_Fs_GlobalPanelDebug = new( ReflectionUtils.GetType("UnityEngine.UIElements.DebuggerEventDispatchingStrategy"), "s_GlobalPanelDebug");
					r_Fs_GlobalPanelDebug.SetBelong(null);
				}
				return r_Fs_GlobalPanelDebug;
			}
		}

		/// <summary>
		/// Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MCanDispatchEvent_EventBase;
		public virtual RMethod RMCanDispatchEvent_EventBase
		{
			get
			{
				if(r_MCanDispatchEvent_EventBase == null)
				{
					r_MCanDispatchEvent_EventBase = new(this, "CanDispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MCanDispatchEvent_EventBase.SetBelong(this.instance);
				}
				return r_MCanDispatchEvent_EventBase;
			}
		}

		/// <summary>
		/// Void DispatchEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MDispatchEvent_EventBase_IPanel;
		public virtual RMethod RMDispatchEvent_EventBase_IPanel
		{
			get
			{
				if(r_MDispatchEvent_EventBase_IPanel == null)
				{
					r_MDispatchEvent_EventBase_IPanel = new(this, "DispatchEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_MDispatchEvent_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_MDispatchEvent_EventBase_IPanel;
			}
		}

		/// <summary>
		/// Void PostDispatch(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MPostDispatch_EventBase_IPanel;
		public virtual RMethod RMPostDispatch_EventBase_IPanel
		{
			get
			{
				if(r_MPostDispatch_EventBase_IPanel == null)
				{
					r_MPostDispatch_EventBase_IPanel = new(this, "PostDispatch", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_MPostDispatch_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_MPostDispatch_EventBase_IPanel;
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

        public virtual System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMCanDispatchEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DispatchEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RMDispatchEvent_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostDispatch(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RMPostDispatch_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
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
