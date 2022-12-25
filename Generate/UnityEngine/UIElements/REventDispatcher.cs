using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventDispatcher
	/// </summary>
    public partial class REventDispatcher : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.ClickDetector m_ClickDetector
		/// </summary>
		protected RUnityEngine.RUIElements.RClickDetector r_m_ClickDetector;
		public virtual RUnityEngine.RUIElements.RClickDetector Rm_ClickDetector
		{
			get
			{
				if(r_m_ClickDetector == null)
				{
					r_m_ClickDetector = new(this, "m_ClickDetector");
					r_m_ClickDetector.SetBelong(this.instance);
				}
				return r_m_ClickDetector;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventDispatchingStrategy] m_DispatchingStrategies
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventDispatchingStrategy> r_m_DispatchingStrategies;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RIEventDispatchingStrategy> Rm_DispatchingStrategies
		{
			get
			{
				if(r_m_DispatchingStrategies == null)
				{
					r_m_DispatchingStrategies = new(this, "m_DispatchingStrategies");
					r_m_DispatchingStrategies.SetBelong(this.instance);
				}
				return r_m_DispatchingStrategies;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[System.Collections.Generic.Queue`1[UnityEngine.UIElements.EventDispatcher+EventRecord]] k_EventQueuePool
		/// </summary>
		protected static RUnityEngine.RUIElements.RObjectPool<RSystem.RCollections.RGeneric.RQueue<RUnityEngine.RUIElements.REventDispatcher.REventRecord>> r_k_EventQueuePool;
		public static RUnityEngine.RUIElements.RObjectPool<RSystem.RCollections.RGeneric.RQueue<RUnityEngine.RUIElements.REventDispatcher.REventRecord>> Rk_EventQueuePool
		{
			get
			{
				if(r_k_EventQueuePool == null)
				{
					r_k_EventQueuePool = new(typeof(UnityEngine.UIElements.EventDispatcher), "k_EventQueuePool");
					r_k_EventQueuePool.SetBelong(null);
				}
				return r_k_EventQueuePool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Queue`1[UnityEngine.UIElements.EventDispatcher+EventRecord] m_Queue
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<RUnityEngine.RUIElements.REventDispatcher.REventRecord> r_m_Queue;
		public virtual RSystem.RCollections.RGeneric.RQueue<RUnityEngine.RUIElements.REventDispatcher.REventRecord> Rm_Queue
		{
			get
			{
				if(r_m_Queue == null)
				{
					r_m_Queue = new(this, "m_Queue");
					r_m_Queue.SetBelong(this.instance);
				}
				return r_m_Queue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PointerDispatchState <pointerState>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RPointerDispatchState r___1__pointerState__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RPointerDispatchState R__1__pointerState__2__k__BackingField
		{
			get
			{
				if(r___1__pointerState__2__k__BackingField == null)
				{
					r___1__pointerState__2__k__BackingField = new(this, "<pointerState>k__BackingField");
					r___1__pointerState__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__pointerState__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 m_GateCount
		/// </summary>
		protected RField r_m_GateCount;
		public virtual RField Rm_GateCount
		{
			get
			{
				if(r_m_GateCount == null)
				{
					r_m_GateCount = new(this, "m_GateCount");
					r_m_GateCount.SetBelong(this.instance);
				}
				return r_m_GateCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.EventDispatcher+DispatchContext] m_DispatchContexts
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.REventDispatcher.RDispatchContext> r_m_DispatchContexts;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.REventDispatcher.RDispatchContext> Rm_DispatchContexts
		{
			get
			{
				if(r_m_DispatchContexts == null)
				{
					r_m_DispatchContexts = new(this, "m_DispatchContexts");
					r_m_DispatchContexts.SetBelong(this.instance);
				}
				return r_m_DispatchContexts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher s_EditorEventDispatcher
		/// </summary>
		protected static RUnityEngine.RUIElements.REventDispatcher r_s_EditorEventDispatcher;
		public static RUnityEngine.RUIElements.REventDispatcher Rs_EditorEventDispatcher
		{
			get
			{
				if(r_s_EditorEventDispatcher == null)
				{
					r_s_EditorEventDispatcher = new(typeof(UnityEngine.UIElements.EventDispatcher), "s_EditorEventDispatcher");
					r_s_EditorEventDispatcher.SetBelong(null);
				}
				return r_s_EditorEventDispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DebuggerEventDispatchingStrategy m_DebuggerEventDispatchingStrategy
		/// </summary>
		protected RUnityEngine.RUIElements.RDebuggerEventDispatchingStrategy r_m_DebuggerEventDispatchingStrategy;
		public virtual RUnityEngine.RUIElements.RDebuggerEventDispatchingStrategy Rm_DebuggerEventDispatchingStrategy
		{
			get
			{
				if(r_m_DebuggerEventDispatchingStrategy == null)
				{
					r_m_DebuggerEventDispatchingStrategy = new(this, "m_DebuggerEventDispatchingStrategy");
					r_m_DebuggerEventDispatchingStrategy.SetBelong(this.instance);
				}
				return r_m_DebuggerEventDispatchingStrategy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventDispatchingStrategy[] s_EditorStrategies
		/// </summary>
		protected static RFieldArray<RUnityEngine.RUIElements.RIEventDispatchingStrategy> r_s_EditorStrategies;
		public static RFieldArray<RUnityEngine.RUIElements.RIEventDispatchingStrategy> Rs_EditorStrategies
		{
			get
			{
				if(r_s_EditorStrategies == null)
				{
					r_s_EditorStrategies = new(typeof(UnityEngine.UIElements.EventDispatcher), "s_EditorStrategies");
					r_s_EditorStrategies.SetBelong(null);
				}
				return r_s_EditorStrategies;
			}
		}

		/// <summary>
		/// System.Boolean m_Immediate
		/// </summary>
		protected RField r_m_Immediate;
		public virtual RField Rm_Immediate
		{
			get
			{
				if(r_m_Immediate == null)
				{
					r_m_Immediate = new(this, "m_Immediate");
					r_m_Immediate.SetBelong(this.instance);
				}
				return r_m_Immediate;
			}
		}

		/// <summary>
		/// System.Boolean <processingEvents>k__BackingField
		/// </summary>
		protected RField r___1__processingEvents__2__k__BackingField;
		public virtual RField R__1__processingEvents__2__k__BackingField
		{
			get
			{
				if(r___1__processingEvents__2__k__BackingField == null)
				{
					r___1__processingEvents__2__k__BackingField = new(this, "<processingEvents>k__BackingField");
					r___1__processingEvents__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__processingEvents__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PointerDispatchState pointerState
		/// </summary>
		protected RUnityEngine.RUIElements.RPointerDispatchState r_pointerState;
		public virtual RUnityEngine.RUIElements.RPointerDispatchState RpointerState
		{
			get
			{
				if(r_pointerState == null)
				{
					r_pointerState = new(this, "pointerState", -1);
					r_pointerState.SetBelong(this.instance);
				}
				return r_pointerState;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher editorDispatcher
		/// </summary>
		protected static RUnityEngine.RUIElements.REventDispatcher r_editorDispatcher;
		public static RUnityEngine.RUIElements.REventDispatcher ReditorDispatcher
		{
			get
			{
				if(r_editorDispatcher == null)
				{
					r_editorDispatcher = new(typeof(UnityEngine.UIElements.EventDispatcher), "editorDispatcher", -1);
					r_editorDispatcher.SetBelong(null);
				}
				return r_editorDispatcher;
			}
		}

		/// <summary>
		/// Boolean dispatchImmediately
		/// </summary>
		protected RProperty r_dispatchImmediately;
		public virtual RProperty RdispatchImmediately
		{
			get
			{
				if(r_dispatchImmediately == null)
				{
					r_dispatchImmediately = new(this, "dispatchImmediately", -1);
					r_dispatchImmediately.SetBelong(this.instance);
				}
				return r_dispatchImmediately;
			}
		}

		/// <summary>
		/// Boolean processingEvents
		/// </summary>
		protected RProperty r_processingEvents;
		public virtual RProperty RprocessingEvents
		{
			get
			{
				if(r_processingEvents == null)
				{
					r_processingEvents = new(this, "processingEvents", -1);
					r_processingEvents.SetBelong(this.instance);
				}
				return r_processingEvents;
			}
		}

		/// <summary>
		/// Void ClearEditorDispatcher()
		/// </summary>
		protected static RMethod r_RClearEditorDispatcher;
		public static RMethod RClearEditorDispatcher
		{
			get
			{
				if(r_RClearEditorDispatcher == null)
				{
					r_RClearEditorDispatcher = new(typeof(UnityEngine.UIElements.EventDispatcher), "ClearEditorDispatcher", 0);
					r_RClearEditorDispatcher.SetBelong(null);
				}
				return r_RClearEditorDispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher CreateDefault()
		/// </summary>
		protected static RMethod r_RCreateDefault;
		public static RMethod RCreateDefault
		{
			get
			{
				if(r_RCreateDefault == null)
				{
					r_RCreateDefault = new(typeof(UnityEngine.UIElements.EventDispatcher), "CreateDefault", 0);
					r_RCreateDefault.SetBelong(null);
				}
				return r_RCreateDefault;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList`1[UnityEngine.UIElements.IEventDispatchingStrategy])
		/// </summary>
		protected static RMethod r_RCreateForRuntime_IList_d_IEventDispatchingStrategy_p_;
		public static RMethod RCreateForRuntime_IList_d_IEventDispatchingStrategy_p_
		{
			get
			{
				if(r_RCreateForRuntime_IList_d_IEventDispatchingStrategy_p_ == null)
				{
					r_RCreateForRuntime_IList_d_IEventDispatchingStrategy_p_ = new(typeof(UnityEngine.UIElements.EventDispatcher), "CreateForRuntime", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.IEventDispatchingStrategy")));
					r_RCreateForRuntime_IList_d_IEventDispatchingStrategy_p_.SetBelong(null);
				}
				return r_RCreateForRuntime_IList_d_IEventDispatchingStrategy_p_;
			}
		}

		/// <summary>
		/// Void Dispatch(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RDispatch_EventBase_IPanel_DispatchMode;
		public virtual RMethod RDispatch_EventBase_IPanel_DispatchMode
		{
			get
			{
				if(r_RDispatch_EventBase_IPanel_DispatchMode == null)
				{
					r_RDispatch_EventBase_IPanel_DispatchMode = new(this, "Dispatch", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RDispatch_EventBase_IPanel_DispatchMode.SetBelong(this.instance);
				}
				return r_RDispatch_EventBase_IPanel_DispatchMode;
			}
		}

		/// <summary>
		/// Void PushDispatcherContext()
		/// </summary>
		protected RMethod r_RPushDispatcherContext;
		public virtual RMethod RPushDispatcherContext
		{
			get
			{
				if(r_RPushDispatcherContext == null)
				{
					r_RPushDispatcherContext = new(this, "PushDispatcherContext", 0);
					r_RPushDispatcherContext.SetBelong(this.instance);
				}
				return r_RPushDispatcherContext;
			}
		}

		/// <summary>
		/// Void PopDispatcherContext()
		/// </summary>
		protected RMethod r_RPopDispatcherContext;
		public virtual RMethod RPopDispatcherContext
		{
			get
			{
				if(r_RPopDispatcherContext == null)
				{
					r_RPopDispatcherContext = new(this, "PopDispatcherContext", 0);
					r_RPopDispatcherContext.SetBelong(this.instance);
				}
				return r_RPopDispatcherContext;
			}
		}

		/// <summary>
		/// Void CloseGate()
		/// </summary>
		protected RMethod r_RCloseGate;
		public virtual RMethod RCloseGate
		{
			get
			{
				if(r_RCloseGate == null)
				{
					r_RCloseGate = new(this, "CloseGate", 0);
					r_RCloseGate.SetBelong(this.instance);
				}
				return r_RCloseGate;
			}
		}

		/// <summary>
		/// Void OpenGate()
		/// </summary>
		protected RMethod r_ROpenGate;
		public virtual RMethod ROpenGate
		{
			get
			{
				if(r_ROpenGate == null)
				{
					r_ROpenGate = new(this, "OpenGate", 0);
					r_ROpenGate.SetBelong(this.instance);
				}
				return r_ROpenGate;
			}
		}

		/// <summary>
		/// Void ProcessEventQueue()
		/// </summary>
		protected RMethod r_RProcessEventQueue;
		public virtual RMethod RProcessEventQueue
		{
			get
			{
				if(r_RProcessEventQueue == null)
				{
					r_RProcessEventQueue = new(this, "ProcessEventQueue", 0);
					r_RProcessEventQueue.SetBelong(this.instance);
				}
				return r_RProcessEventQueue;
			}
		}

		/// <summary>
		/// Void ProcessEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RProcessEvent_EventBase_IPanel;
		public virtual RMethod RProcessEvent_EventBase_IPanel
		{
			get
			{
				if(r_RProcessEvent_EventBase_IPanel == null)
				{
					r_RProcessEvent_EventBase_IPanel = new(this, "ProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_RProcessEvent_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_RProcessEvent_EventBase_IPanel;
			}
		}

		/// <summary>
		/// Void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel, Boolean)
		/// </summary>
		protected RMethod r_RApplyDispatchingStrategies_EventBase_IPanel_Boolean;
		public virtual RMethod RApplyDispatchingStrategies_EventBase_IPanel_Boolean
		{
			get
			{
				if(r_RApplyDispatchingStrategies_EventBase_IPanel_Boolean == null)
				{
					r_RApplyDispatchingStrategies_EventBase_IPanel_Boolean = new(this, "ApplyDispatchingStrategies", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel), typeof(System.Boolean));
					r_RApplyDispatchingStrategies_EventBase_IPanel_Boolean.SetBelong(this.instance);
				}
				return r_RApplyDispatchingStrategies_EventBase_IPanel_Boolean;
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


        public REventDispatcher() : base("UnityEngine.UIElements.EventDispatcher")
        {
        }

        public REventDispatcher(System.Object instance) : base("UnityEngine.UIElements.EventDispatcher")
		{
            SetInstance(instance);
		}

        public REventDispatcher(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventDispatcher(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void ClearEditorDispatcher()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearEditorDispatcher.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.EventDispatcher CreateDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDefault.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.EventDispatcher)___result;
        }




        public virtual void PushDispatcherContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPushDispatcherContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopDispatcherContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopDispatcherContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseGate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCloseGate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenGate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROpenGate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEventQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessEventQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RProcessEvent_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IPanel  @panel, System.Boolean  @imguiEventIsInitiallyUsed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel, @imguiEventIsInitiallyUsed};
            var ___result = RApplyDispatchingStrategies_EventBase_IPanel_Boolean.Invoke(___genericsType, ___parameters);

            
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
