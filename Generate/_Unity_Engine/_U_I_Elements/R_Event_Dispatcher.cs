
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RClickDetector r_Fm_ClickDetector;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RClickDetector RFm_ClickDetector
		{
			get
			{
				if(r_Fm_ClickDetector == null)
				{
					r_Fm_ClickDetector = new(this, "m_ClickDetector");
					r_Fm_ClickDetector.SetBelong(this.instance);
				}
				return r_Fm_ClickDetector;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.IEventDispatchingStrategy] m_DispatchingStrategies
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIEventDispatchingStrategy> r_Fm_DispatchingStrategies;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIEventDispatchingStrategy> RFm_DispatchingStrategies
		{
			get
			{
				if(r_Fm_DispatchingStrategies == null)
				{
					r_Fm_DispatchingStrategies = new(this, "m_DispatchingStrategies");
					r_Fm_DispatchingStrategies.SetBelong(this.instance);
				}
				return r_Fm_DispatchingStrategies;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[System.Collections.Generic.Queue`1[UnityEngine.UIElements.EventDispatcher+EventRecord]] k_EventQueuePool
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RObjectPool<SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RQueue<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher.REventRecord>> r_Fk_EventQueuePool;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RObjectPool<SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RQueue<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher.REventRecord>> RFk_EventQueuePool
		{
			get
			{
				if(r_Fk_EventQueuePool == null)
				{
					r_Fk_EventQueuePool = new(typeof(UnityEngine.UIElements.EventDispatcher), "k_EventQueuePool");
					r_Fk_EventQueuePool.SetBelong(null);
				}
				return r_Fk_EventQueuePool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Queue`1[UnityEngine.UIElements.EventDispatcher+EventRecord] m_Queue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RQueue<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher.REventRecord> r_Fm_Queue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RQueue<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher.REventRecord> RFm_Queue
		{
			get
			{
				if(r_Fm_Queue == null)
				{
					r_Fm_Queue = new(this, "m_Queue");
					r_Fm_Queue.SetBelong(this.instance);
				}
				return r_Fm_Queue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PointerDispatchState <pointerState>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RPointerDispatchState r_F__0__pointerState__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RPointerDispatchState RF__0__pointerState__1__k__BackingField
		{
			get
			{
				if(r_F__0__pointerState__1__k__BackingField == null)
				{
					r_F__0__pointerState__1__k__BackingField = new(this, "<pointerState>k__BackingField");
					r_F__0__pointerState__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__pointerState__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 m_GateCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_GateCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_GateCount
		{
			get
			{
				if(r_Fm_GateCount == null)
				{
					r_Fm_GateCount = new(this, "m_GateCount");
					r_Fm_GateCount.SetBelong(this.instance);
				}
				return r_Fm_GateCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.EventDispatcher+DispatchContext] m_DispatchContexts
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher.RDispatchContext> r_Fm_DispatchContexts;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher.RDispatchContext> RFm_DispatchContexts
		{
			get
			{
				if(r_Fm_DispatchContexts == null)
				{
					r_Fm_DispatchContexts = new(this, "m_DispatchContexts");
					r_Fm_DispatchContexts.SetBelong(this.instance);
				}
				return r_Fm_DispatchContexts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher s_EditorEventDispatcher
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher r_Fs_EditorEventDispatcher;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher RFs_EditorEventDispatcher
		{
			get
			{
				if(r_Fs_EditorEventDispatcher == null)
				{
					r_Fs_EditorEventDispatcher = new(typeof(UnityEngine.UIElements.EventDispatcher), "s_EditorEventDispatcher");
					r_Fs_EditorEventDispatcher.SetBelong(null);
				}
				return r_Fs_EditorEventDispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DebuggerEventDispatchingStrategy m_DebuggerEventDispatchingStrategy
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RDebuggerEventDispatchingStrategy r_Fm_DebuggerEventDispatchingStrategy;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RDebuggerEventDispatchingStrategy RFm_DebuggerEventDispatchingStrategy
		{
			get
			{
				if(r_Fm_DebuggerEventDispatchingStrategy == null)
				{
					r_Fm_DebuggerEventDispatchingStrategy = new(this, "m_DebuggerEventDispatchingStrategy");
					r_Fm_DebuggerEventDispatchingStrategy.SetBelong(this.instance);
				}
				return r_Fm_DebuggerEventDispatchingStrategy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventDispatchingStrategy[] s_EditorStrategies
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIEventDispatchingStrategy> r_Fs_EditorStrategies;
		public static SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIEventDispatchingStrategy> RFs_EditorStrategies
		{
			get
			{
				if(r_Fs_EditorStrategies == null)
				{
					r_Fs_EditorStrategies = new(typeof(UnityEngine.UIElements.EventDispatcher), "s_EditorStrategies");
					r_Fs_EditorStrategies.SetBelong(null);
				}
				return r_Fs_EditorStrategies;
			}
		}

		/// <summary>
		/// System.Boolean m_Immediate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Immediate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Immediate
		{
			get
			{
				if(r_Fm_Immediate == null)
				{
					r_Fm_Immediate = new(this, "m_Immediate");
					r_Fm_Immediate.SetBelong(this.instance);
				}
				return r_Fm_Immediate;
			}
		}

		/// <summary>
		/// System.Boolean <processingEvents>k__BackingField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_F__0__processingEvents__1__k__BackingField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RF__0__processingEvents__1__k__BackingField
		{
			get
			{
				if(r_F__0__processingEvents__1__k__BackingField == null)
				{
					r_F__0__processingEvents__1__k__BackingField = new(this, "<processingEvents>k__BackingField");
					r_F__0__processingEvents__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__processingEvents__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PointerDispatchState pointerState
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RPointerDispatchState r_PpointerState;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RPointerDispatchState RPpointerState
		{
			get
			{
				if(r_PpointerState == null)
				{
					r_PpointerState = new(this, "pointerState", -1);
					r_PpointerState.SetBelong(this.instance);
				}
				return r_PpointerState;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher editorDispatcher
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher r_PeditorDispatcher;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher RPeditorDispatcher
		{
			get
			{
				if(r_PeditorDispatcher == null)
				{
					r_PeditorDispatcher = new(typeof(UnityEngine.UIElements.EventDispatcher), "editorDispatcher", -1);
					r_PeditorDispatcher.SetBelong(null);
				}
				return r_PeditorDispatcher;
			}
		}

		/// <summary>
		/// Boolean dispatchImmediately
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PdispatchImmediately;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPdispatchImmediately
		{
			get
			{
				if(r_PdispatchImmediately == null)
				{
					r_PdispatchImmediately = new(this, "dispatchImmediately", -1);
					r_PdispatchImmediately.SetBelong(this.instance);
				}
				return r_PdispatchImmediately;
			}
		}

		/// <summary>
		/// Boolean processingEvents
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PprocessingEvents;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPprocessingEvents
		{
			get
			{
				if(r_PprocessingEvents == null)
				{
					r_PprocessingEvents = new(this, "processingEvents", -1);
					r_PprocessingEvents.SetBelong(this.instance);
				}
				return r_PprocessingEvents;
			}
		}

		/// <summary>
		/// Void ClearEditorDispatcher()
		/// </summary>
		protected static RMethod r_MClearEditorDispatcher;
		public static RMethod RMClearEditorDispatcher
		{
			get
			{
				if(r_MClearEditorDispatcher == null)
				{
					r_MClearEditorDispatcher = new(typeof(UnityEngine.UIElements.EventDispatcher), "ClearEditorDispatcher", 0);
					r_MClearEditorDispatcher.SetBelong(null);
				}
				return r_MClearEditorDispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher CreateDefault()
		/// </summary>
		protected static RMethod r_MCreateDefault;
		public static RMethod RMCreateDefault
		{
			get
			{
				if(r_MCreateDefault == null)
				{
					r_MCreateDefault = new(typeof(UnityEngine.UIElements.EventDispatcher), "CreateDefault", 0);
					r_MCreateDefault.SetBelong(null);
				}
				return r_MCreateDefault;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList`1[UnityEngine.UIElements.IEventDispatchingStrategy])
		/// </summary>
		protected static RMethod r_MCreateForRuntime_IList_d_IEventDispatchingStrategy_p_;
		public static RMethod RMCreateForRuntime_IList_d_IEventDispatchingStrategy_p_
		{
			get
			{
				if(r_MCreateForRuntime_IList_d_IEventDispatchingStrategy_p_ == null)
				{
					r_MCreateForRuntime_IList_d_IEventDispatchingStrategy_p_ = new(typeof(UnityEngine.UIElements.EventDispatcher), "CreateForRuntime", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.IEventDispatchingStrategy")));
					r_MCreateForRuntime_IList_d_IEventDispatchingStrategy_p_.SetBelong(null);
				}
				return r_MCreateForRuntime_IList_d_IEventDispatchingStrategy_p_;
			}
		}

		/// <summary>
		/// Void Dispatch(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MDispatch_EventBase_IPanel_DispatchMode;
		public virtual RMethod RMDispatch_EventBase_IPanel_DispatchMode
		{
			get
			{
				if(r_MDispatch_EventBase_IPanel_DispatchMode == null)
				{
					r_MDispatch_EventBase_IPanel_DispatchMode = new(this, "Dispatch", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_MDispatch_EventBase_IPanel_DispatchMode.SetBelong(this.instance);
				}
				return r_MDispatch_EventBase_IPanel_DispatchMode;
			}
		}

		/// <summary>
		/// Void PushDispatcherContext()
		/// </summary>
		protected RMethod r_MPushDispatcherContext;
		public virtual RMethod RMPushDispatcherContext
		{
			get
			{
				if(r_MPushDispatcherContext == null)
				{
					r_MPushDispatcherContext = new(this, "PushDispatcherContext", 0);
					r_MPushDispatcherContext.SetBelong(this.instance);
				}
				return r_MPushDispatcherContext;
			}
		}

		/// <summary>
		/// Void PopDispatcherContext()
		/// </summary>
		protected RMethod r_MPopDispatcherContext;
		public virtual RMethod RMPopDispatcherContext
		{
			get
			{
				if(r_MPopDispatcherContext == null)
				{
					r_MPopDispatcherContext = new(this, "PopDispatcherContext", 0);
					r_MPopDispatcherContext.SetBelong(this.instance);
				}
				return r_MPopDispatcherContext;
			}
		}

		/// <summary>
		/// Void CloseGate()
		/// </summary>
		protected RMethod r_MCloseGate;
		public virtual RMethod RMCloseGate
		{
			get
			{
				if(r_MCloseGate == null)
				{
					r_MCloseGate = new(this, "CloseGate", 0);
					r_MCloseGate.SetBelong(this.instance);
				}
				return r_MCloseGate;
			}
		}

		/// <summary>
		/// Void OpenGate()
		/// </summary>
		protected RMethod r_MOpenGate;
		public virtual RMethod RMOpenGate
		{
			get
			{
				if(r_MOpenGate == null)
				{
					r_MOpenGate = new(this, "OpenGate", 0);
					r_MOpenGate.SetBelong(this.instance);
				}
				return r_MOpenGate;
			}
		}

		/// <summary>
		/// Void ProcessEventQueue()
		/// </summary>
		protected RMethod r_MProcessEventQueue;
		public virtual RMethod RMProcessEventQueue
		{
			get
			{
				if(r_MProcessEventQueue == null)
				{
					r_MProcessEventQueue = new(this, "ProcessEventQueue", 0);
					r_MProcessEventQueue.SetBelong(this.instance);
				}
				return r_MProcessEventQueue;
			}
		}

		/// <summary>
		/// Void ProcessEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MProcessEvent_EventBase_IPanel;
		public virtual RMethod RMProcessEvent_EventBase_IPanel
		{
			get
			{
				if(r_MProcessEvent_EventBase_IPanel == null)
				{
					r_MProcessEvent_EventBase_IPanel = new(this, "ProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel));
					r_MProcessEvent_EventBase_IPanel.SetBelong(this.instance);
				}
				return r_MProcessEvent_EventBase_IPanel;
			}
		}

		/// <summary>
		/// Void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IPanel, Boolean)
		/// </summary>
		protected RMethod r_MApplyDispatchingStrategies_EventBase_IPanel_Boolean;
		public virtual RMethod RMApplyDispatchingStrategies_EventBase_IPanel_Boolean
		{
			get
			{
				if(r_MApplyDispatchingStrategies_EventBase_IPanel_Boolean == null)
				{
					r_MApplyDispatchingStrategies_EventBase_IPanel_Boolean = new(this, "ApplyDispatchingStrategies", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IPanel), typeof(System.Boolean));
					r_MApplyDispatchingStrategies_EventBase_IPanel_Boolean.SetBelong(this.instance);
				}
				return r_MApplyDispatchingStrategies_EventBase_IPanel_Boolean;
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
            var ___result = RMClearEditorDispatcher.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.EventDispatcher CreateDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDefault.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.EventDispatcher)___result;
        }


        public static UnityEngine.UIElements.EventDispatcher CreateForRuntime(SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RIEventDispatchingStrategy> @strategies)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strategies.Value};
            var ___result = RMCreateForRuntime_IList_d_IEventDispatchingStrategy_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.EventDispatcher)___result;
        }


        public virtual void Dispatch(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IPanel @panel, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel, @dispatchMode.Value};
            var ___result = RMDispatch_EventBase_IPanel_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PushDispatcherContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPushDispatcherContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopDispatcherContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPopDispatcherContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseGate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCloseGate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenGate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOpenGate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEventQueue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProcessEventQueue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel};
            var ___result = RMProcessEvent_EventBase_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IPanel @panel, System.Boolean @imguiEventIsInitiallyUsed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @panel, @imguiEventIsInitiallyUsed};
            var ___result = RMApplyDispatchingStrategies_EventBase_IPanel_Boolean.Invoke(___genericsType, ___parameters);

            
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
