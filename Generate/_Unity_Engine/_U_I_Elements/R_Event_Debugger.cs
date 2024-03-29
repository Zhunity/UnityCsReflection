
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.EventDebugger
	/// </summary>
    public partial class REventDebugger : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.EventDebugger");
            }
        }

        public REventDebugger() : base("UnityEngine.UIElements.EventDebugger")
        {
        }

        public REventDebugger(System.Object instance) : base("UnityEngine.UIElements.EventDebugger")
		{
            SetInstance(instance);
		}

        public REventDebugger(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventDebugger(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug m_PanelDebug
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug r_Fm_PanelDebug;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug RFm_PanelDebug
		{
			get
			{
				if(r_Fm_PanelDebug == null)
				{
					r_Fm_PanelDebug = new(this, "m_PanelDebug");
				}
				return r_Fm_PanelDebug;
			}
		}

		/// <summary>
		/// System.Boolean <isReplaying>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__isReplaying__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__isReplaying__1__k__BackingField
		{
			get
			{
				if(r_F__0__isReplaying__1__k__BackingField == null)
				{
					r_F__0__isReplaying__1__k__BackingField = new(this, "<isReplaying>k__BackingField");
				}
				return r_F__0__isReplaying__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <playbackSpeed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_F__0__playbackSpeed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RF__0__playbackSpeed__1__k__BackingField
		{
			get
			{
				if(r_F__0__playbackSpeed__1__k__BackingField == null)
				{
					r_F__0__playbackSpeed__1__k__BackingField = new(this, "<playbackSpeed>k__BackingField");
				}
				return r_F__0__playbackSpeed__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isPlaybackPaused>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__isPlaybackPaused__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__isPlaybackPaused__1__k__BackingField
		{
			get
			{
				if(r_F__0__isPlaybackPaused__1__k__BackingField == null)
				{
					r_F__0__isPlaybackPaused__1__k__BackingField = new(this, "<isPlaybackPaused>k__BackingField");
				}
				return r_F__0__isPlaybackPaused__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerCallTrace]] m_EventCalledObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerCallTrace>> r_Fm_EventCalledObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerCallTrace>> RFm_EventCalledObjects
		{
			get
			{
				if(r_Fm_EventCalledObjects == null)
				{
					r_Fm_EventCalledObjects = new(this, "m_EventCalledObjects");
				}
				return r_Fm_EventCalledObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerDefaultActionTrace]] m_EventDefaultActionObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerDefaultActionTrace>> r_Fm_EventDefaultActionObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerDefaultActionTrace>> RFm_EventDefaultActionObjects
		{
			get
			{
				if(r_Fm_EventDefaultActionObjects == null)
				{
					r_Fm_EventDefaultActionObjects = new(this, "m_EventDefaultActionObjects");
				}
				return r_Fm_EventDefaultActionObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerPathTrace]] m_EventPathObjects
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerPathTrace>> r_Fm_EventPathObjects;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerPathTrace>> RFm_EventPathObjects
		{
			get
			{
				if(r_Fm_EventPathObjects == null)
				{
					r_Fm_EventPathObjects = new(this, "m_EventPathObjects");
				}
				return r_Fm_EventPathObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerTrace]] m_EventProcessedEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerTrace>> r_Fm_EventProcessedEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerTrace>> RFm_EventProcessedEvents
		{
			get
			{
				if(r_Fm_EventProcessedEvents == null)
				{
					r_Fm_EventProcessedEvents = new(this, "m_EventProcessedEvents");
				}
				return r_Fm_EventProcessedEvents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.Stack`1[UnityEngine.UIElements.EventDebuggerTrace]] m_StackOfProcessedEvent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerTrace>> r_Fm_StackOfProcessedEvent;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerTrace>> RFm_StackOfProcessedEvent
		{
			get
			{
				if(r_Fm_StackOfProcessedEvent == null)
				{
					r_Fm_StackOfProcessedEvent = new(this, "m_StackOfProcessedEvent");
				}
				return r_Fm_StackOfProcessedEvent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.Dictionary`2[System.Int64,System.Int32]] m_EventTypeProcessedCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt64, Hvak.Editor.Refleaction.RSystem.RInt32>> r_Fm_EventTypeProcessedCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt64, Hvak.Editor.Refleaction.RSystem.RInt32>> RFm_EventTypeProcessedCount
		{
			get
			{
				if(r_Fm_EventTypeProcessedCount == null)
				{
					r_Fm_EventTypeProcessedCount = new(this, "m_EventTypeProcessedCount");
				}
				return r_Fm_EventTypeProcessedCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Int64] m_ModificationCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RInt64> r_Fm_ModificationCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel, Hvak.Editor.Refleaction.RSystem.RInt64> RFm_ModificationCount
		{
			get
			{
				if(r_Fm_ModificationCount == null)
				{
					r_Fm_ModificationCount = new(this, "m_ModificationCount");
				}
				return r_Fm_ModificationCount;
			}
		}

		/// <summary>
		/// System.Boolean m_Log
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Log;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Log
		{
			get
			{
				if(r_Fm_Log == null)
				{
					r_Fm_Log = new(this, "m_Log");
				}
				return r_Fm_Log;
			}
		}

		/// <summary>
		/// System.Boolean <suspended>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__suspended__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__suspended__1__k__BackingField
		{
			get
			{
				if(r_F__0__suspended__1__k__BackingField == null)
				{
					r_F__0__suspended__1__k__BackingField = new(this, "<suspended>k__BackingField");
				}
				return r_F__0__suspended__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel r_Ppanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug panelDebug
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug r_PpanelDebug;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebug RPpanelDebug
		{
			get
			{
				if(r_PpanelDebug == null)
				{
					r_PpanelDebug = new(this, "panelDebug", -1);
				}
				return r_PpanelDebug;
			}
		}

		/// <summary>
		/// Boolean isReplaying
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisReplaying;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisReplaying
		{
			get
			{
				if(r_PisReplaying == null)
				{
					r_PisReplaying = new(this, "isReplaying", -1);
				}
				return r_PisReplaying;
			}
		}

		/// <summary>
		/// Single playbackSpeed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PplaybackSpeed;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPplaybackSpeed
		{
			get
			{
				if(r_PplaybackSpeed == null)
				{
					r_PplaybackSpeed = new(this, "playbackSpeed", -1);
				}
				return r_PplaybackSpeed;
			}
		}

		/// <summary>
		/// Boolean isPlaybackPaused
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPlaybackPaused;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPlaybackPaused
		{
			get
			{
				if(r_PisPlaybackPaused == null)
				{
					r_PisPlaybackPaused = new(this, "isPlaybackPaused", -1);
				}
				return r_PisPlaybackPaused;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int64,System.Int32] eventTypeProcessedCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt64, Hvak.Editor.Refleaction.RSystem.RInt32> r_PeventTypeProcessedCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt64, Hvak.Editor.Refleaction.RSystem.RInt32> RPeventTypeProcessedCount
		{
			get
			{
				if(r_PeventTypeProcessedCount == null)
				{
					r_PeventTypeProcessedCount = new(this, "eventTypeProcessedCount", -1);
				}
				return r_PeventTypeProcessedCount;
			}
		}

		/// <summary>
		/// Boolean suspended
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Psuspended;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsuspended
		{
			get
			{
				if(r_Psuspended == null)
				{
					r_Psuspended = new(this, "suspended", -1);
				}
				return r_Psuspended;
			}
		}

		/// <summary>
		/// Void UpdateModificationCount()
		/// </summary>
		protected RMethod r_MUpdateModificationCount;
		public virtual RMethod RMUpdateModificationCount
		{
			get
			{
				if(r_MUpdateModificationCount == null)
				{
					r_MUpdateModificationCount = new(this, "UpdateModificationCount", 0);
				}
				return r_MUpdateModificationCount;
			}
		}

		/// <summary>
		/// Void BeginProcessEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MBeginProcessEvent_EventBase_IEventHandler;
		public virtual RMethod RMBeginProcessEvent_EventBase_IEventHandler
		{
			get
			{
				if(r_MBeginProcessEvent_EventBase_IEventHandler == null)
				{
					r_MBeginProcessEvent_EventBase_IEventHandler = new(this, "BeginProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MBeginProcessEvent_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void EndProcessEvent(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MEndProcessEvent_EventBase_Int64_IEventHandler;
		public virtual RMethod RMEndProcessEvent_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_MEndProcessEvent_EventBase_Int64_IEventHandler == null)
				{
					r_MEndProcessEvent_EventBase_Int64_IEventHandler = new(this, "EndProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MEndProcessEvent_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogCall(Int32, System.String, UnityEngine.UIElements.EventBase, Boolean, Boolean, Boolean, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
		public virtual RMethod RMLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler
		{
			get
			{
				if(r_MLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler == null)
				{
					r_MLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler = new(this, "LogCall", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogIMGUICall(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MLogIMGUICall_EventBase_Int64_IEventHandler;
		public virtual RMethod RMLogIMGUICall_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_MLogIMGUICall_EventBase_Int64_IEventHandler == null)
				{
					r_MLogIMGUICall_EventBase_Int64_IEventHandler = new(this, "LogIMGUICall", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MLogIMGUICall_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogExecuteDefaultAction(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPhase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
		public virtual RMethod RMLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler
		{
			get
			{
				if(r_MLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler == null)
				{
					r_MLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler = new(this, "LogExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.PropagationPhase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogPropagationPaths(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected static RMethod r_MLogPropagationPaths_EventBase_PropagationPaths;
		public static RMethod RMLogPropagationPaths_EventBase_PropagationPaths
		{
			get
			{
				if(r_MLogPropagationPaths_EventBase_PropagationPaths == null)
				{
					r_MLogPropagationPaths_EventBase_PropagationPaths = new(Type, "LogPropagationPaths", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
				}
				return r_MLogPropagationPaths_EventBase_PropagationPaths;
			}
		}

		/// <summary>
		/// Void LogPropagationPathsInternal(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected RMethod r_MLogPropagationPathsInternal_EventBase_PropagationPaths;
		public virtual RMethod RMLogPropagationPathsInternal_EventBase_PropagationPaths
		{
			get
			{
				if(r_MLogPropagationPathsInternal_EventBase_PropagationPaths == null)
				{
					r_MLogPropagationPathsInternal_EventBase_PropagationPaths = new(this, "LogPropagationPathsInternal", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
				}
				return r_MLogPropagationPathsInternal_EventBase_PropagationPaths;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerCallTrace] GetCalls(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_MGetCalls_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RMGetCalls_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_MGetCalls_IPanel_EventDebuggerEventRecord == null)
				{
					r_MGetCalls_IPanel_EventDebuggerEventRecord = new(this, "GetCalls", 0, typeof(UnityEngine.UIElements.IPanel),  ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
				}
				return r_MGetCalls_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerDefaultActionTrace] GetDefaultActions(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_MGetDefaultActions_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RMGetDefaultActions_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_MGetDefaultActions_IPanel_EventDebuggerEventRecord == null)
				{
					r_MGetDefaultActions_IPanel_EventDebuggerEventRecord = new(this, "GetDefaultActions", 0, typeof(UnityEngine.UIElements.IPanel),  ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
				}
				return r_MGetDefaultActions_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerPathTrace] GetPropagationPaths(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_MGetPropagationPaths_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RMGetPropagationPaths_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_MGetPropagationPaths_IPanel_EventDebuggerEventRecord == null)
				{
					r_MGetPropagationPaths_IPanel_EventDebuggerEventRecord = new(this, "GetPropagationPaths", 0, typeof(UnityEngine.UIElements.IPanel),  ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
				}
				return r_MGetPropagationPaths_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerTrace] GetBeginEndProcessedEvents(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_MGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RMGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_MGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord == null)
				{
					r_MGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord = new(this, "GetBeginEndProcessedEvents", 0, typeof(UnityEngine.UIElements.IPanel),  ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
				}
				return r_MGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// Int64 GetModificationCount(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MGetModificationCount_IPanel;
		public virtual RMethod RMGetModificationCount_IPanel
		{
			get
			{
				if(r_MGetModificationCount_IPanel == null)
				{
					r_MGetModificationCount_IPanel = new(this, "GetModificationCount", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MGetModificationCount_IPanel;
			}
		}

		/// <summary>
		/// Void ClearLogs()
		/// </summary>
		protected RMethod r_MClearLogs;
		public virtual RMethod RMClearLogs
		{
			get
			{
				if(r_MClearLogs == null)
				{
					r_MClearLogs = new(this, "ClearLogs", 0);
				}
				return r_MClearLogs;
			}
		}

		/// <summary>
		/// Void SaveReplaySessionFromSelection(System.String, System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerEventRecord])
		/// </summary>
		protected RMethod r_MSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_;
		public virtual RMethod RMSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_
		{
			get
			{
				if(r_MSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_ == null)
				{
					r_MSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_ = new(this, "SaveReplaySessionFromSelection", 0, typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")));
				}
				return r_MSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebuggerRecordList LoadReplaySession(System.String)
		/// </summary>
		protected RMethod r_MLoadReplaySession_String;
		public virtual RMethod RMLoadReplaySession_String
		{
			get
			{
				if(r_MLoadReplaySession_String == null)
				{
					r_MLoadReplaySession_String = new(this, "LoadReplaySession", 0, typeof(System.String));
				}
				return r_MLoadReplaySession_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ReplayEvents(System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EventDebuggerEventRecord], System.Action`2[System.Int32,System.Int32])
		/// </summary>
		protected RMethod r_MReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
		public virtual RMethod RMReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_
		{
			get
			{
				if(r_MReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ == null)
				{
					r_MReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ = new(this, "ReplayEvents", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Int32), typeof(System.Int32)));
				}
				return r_MReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
			}
		}

		/// <summary>
		/// Void StopPlayback()
		/// </summary>
		protected RMethod r_MStopPlayback;
		public virtual RMethod RMStopPlayback
		{
			get
			{
				if(r_MStopPlayback == null)
				{
					r_MStopPlayback = new(this, "StopPlayback", 0);
				}
				return r_MStopPlayback;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator DoReplayEvents(System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EventDebuggerEventRecord], System.Action`2[System.Int32,System.Int32])
		/// </summary>
		protected RMethod r_MDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
		public virtual RMethod RMDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_
		{
			get
			{
				if(r_MDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ == null)
				{
					r_MDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ = new(this, "DoReplayEvents", 0,  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.Int32), typeof(System.Int32)));
				}
				return r_MDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.EventDebugger+HistogramRecord] ComputeHistogram(System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerEventRecord])
		/// </summary>
		protected RMethod r_MComputeHistogram_List_d_EventDebuggerEventRecord_p_;
		public virtual RMethod RMComputeHistogram_List_d_EventDebuggerEventRecord_p_
		{
			get
			{
				if(r_MComputeHistogram_List_d_EventDebuggerEventRecord_p_ == null)
				{
					r_MComputeHistogram_List_d_EventDebuggerEventRecord_p_ = new(this, "ComputeHistogram", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")));
				}
				return r_MComputeHistogram_List_d_EventDebuggerEventRecord_p_;
			}
		}

		/// <summary>
		/// Void AddCallObject(Int32, System.String, UnityEngine.UIElements.EventBase, Boolean, Boolean, Boolean, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
		public virtual RMethod RMAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler
		{
			get
			{
				if(r_MAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler == null)
				{
					r_MAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler = new(this, "AddCallObject", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddExecuteDefaultAction(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPhase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
		public virtual RMethod RMAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler
		{
			get
			{
				if(r_MAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler == null)
				{
					r_MAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler = new(this, "AddExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.PropagationPhase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddPropagationPaths(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected RMethod r_MAddPropagationPaths_EventBase_PropagationPaths;
		public virtual RMethod RMAddPropagationPaths_EventBase_PropagationPaths
		{
			get
			{
				if(r_MAddPropagationPaths_EventBase_PropagationPaths == null)
				{
					r_MAddPropagationPaths_EventBase_PropagationPaths = new(this, "AddPropagationPaths", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
				}
				return r_MAddPropagationPaths_EventBase_PropagationPaths;
			}
		}

		/// <summary>
		/// Void AddIMGUICall(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MAddIMGUICall_EventBase_Int64_IEventHandler;
		public virtual RMethod RMAddIMGUICall_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_MAddIMGUICall_EventBase_Int64_IEventHandler == null)
				{
					r_MAddIMGUICall_EventBase_Int64_IEventHandler = new(this, "AddIMGUICall", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MAddIMGUICall_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddBeginProcessEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MAddBeginProcessEvent_EventBase_IEventHandler;
		public virtual RMethod RMAddBeginProcessEvent_EventBase_IEventHandler
		{
			get
			{
				if(r_MAddBeginProcessEvent_EventBase_IEventHandler == null)
				{
					r_MAddBeginProcessEvent_EventBase_IEventHandler = new(this, "AddBeginProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MAddBeginProcessEvent_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddEndProcessEvent(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MAddEndProcessEvent_EventBase_Int64_IEventHandler;
		public virtual RMethod RMAddEndProcessEvent_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_MAddEndProcessEvent_EventBase_Int64_IEventHandler == null)
				{
					r_MAddEndProcessEvent_EventBase_Int64_IEventHandler = new(this, "AddEndProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
				}
				return r_MAddEndProcessEvent_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// System.String GetObjectDisplayName(System.Object, Boolean)
		/// </summary>
		protected static RMethod r_MGetObjectDisplayName_Object_Boolean;
		public static RMethod RMGetObjectDisplayName_Object_Boolean
		{
			get
			{
				if(r_MGetObjectDisplayName_Object_Boolean == null)
				{
					r_MGetObjectDisplayName_Object_Boolean = new(Type, "GetObjectDisplayName", 0, typeof(System.Object), typeof(System.Boolean));
				}
				return r_MGetObjectDisplayName_Object_Boolean;
			}
		}

		/// <summary>
		/// System.String GetTypeDisplayName(System.Type)
		/// </summary>
		protected static RMethod r_MGetTypeDisplayName_Type;
		public static RMethod RMGetTypeDisplayName_Type
		{
			get
			{
				if(r_MGetTypeDisplayName_Type == null)
				{
					r_MGetTypeDisplayName_Type = new(Type, "GetTypeDisplayName", 0, typeof(System.Type));
				}
				return r_MGetTypeDisplayName_Type;
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
				}
				return r_MToString;
			}
		}


        public virtual void UpdateModificationCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateModificationCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginProcessEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @mouseCapture};
            var ___result = RMBeginProcessEvent_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndProcessEvent(UnityEngine.UIElements.EventBase @evt, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RMEndProcessEvent_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogCall(System.Int32 @cbHashCode, System.String @cbName, UnityEngine.UIElements.EventBase @evt, System.Boolean @propagationHasStopped, System.Boolean @immediatePropagationHasStopped, System.Boolean @defaultHasBeenPrevented, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cbHashCode, @cbName, @evt, @propagationHasStopped, @immediatePropagationHasStopped, @defaultHasBeenPrevented, @duration, @mouseCapture};
            var ___result = RMLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogIMGUICall(UnityEngine.UIElements.EventBase @evt, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RMLogIMGUICall_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.PropagationPhase @phase, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @phase, @duration, @mouseCapture};
            var ___result = RMLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public static void LogPropagationPaths(UnityEngine.UIElements.EventBase @evt, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths @paths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @paths.Value};
            var ___result = RMLogPropagationPaths_EventBase_PropagationPaths.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogPropagationPathsInternal(UnityEngine.UIElements.EventBase @evt, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths @paths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @paths.Value};
            var ___result = RMLogPropagationPathsInternal_EventBase_PropagationPaths.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerCallTrace> GetCalls(UnityEngine.UIElements.IPanel @panel, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel, @evt.Value};
            var ___result = RMGetCalls_IPanel_EventDebuggerEventRecord.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerCallTrace>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerDefaultActionTrace> GetDefaultActions(UnityEngine.UIElements.IPanel @panel, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel, @evt.Value};
            var ___result = RMGetDefaultActions_IPanel_EventDebuggerEventRecord.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerDefaultActionTrace>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerPathTrace> GetPropagationPaths(UnityEngine.UIElements.IPanel @panel, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel, @evt.Value};
            var ___result = RMGetPropagationPaths_IPanel_EventDebuggerEventRecord.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerPathTrace>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerTrace> GetBeginEndProcessedEvents(UnityEngine.UIElements.IPanel @panel, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel, @evt.Value};
            var ___result = RMGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerTrace>>(___result);
        }


        public virtual System.Int64 GetModificationCount(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMGetModificationCount_IPanel.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public virtual void ClearLogs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearLogs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveReplaySessionFromSelection(System.String @path, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord> @eventList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @eventList.Value};
            var ___result = RMSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerRecordList LoadReplaySession(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMLoadReplaySession_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerRecordList>(___result);
        }


        public virtual System.Collections.IEnumerator ReplayEvents(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord> @eventBases, System.Action<System.Int32, System.Int32> @refreshList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventBases.Value, @refreshList};
            var ___result = RMReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual void StopPlayback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStopPlayback.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator DoReplayEvents(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord> @eventBases, System.Action<System.Int32, System.Int32> @refreshList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventBases.Value, @refreshList};
            var ___result = RMDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebugger.RHistogramRecord> ComputeHistogram(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebuggerEventRecord> @eventBases)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventBases.Value};
            var ___result = RMComputeHistogram_List_d_EventDebuggerEventRecord_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDebugger.RHistogramRecord>>(___result);
        }


        public virtual void AddCallObject(System.Int32 @cbHashCode, System.String @cbName, UnityEngine.UIElements.EventBase @evt, System.Boolean @propagationHasStopped, System.Boolean @immediatePropagationHasStopped, System.Boolean @defaultHasBeenPrevented, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cbHashCode, @cbName, @evt, @propagationHasStopped, @immediatePropagationHasStopped, @defaultHasBeenPrevented, @duration, @mouseCapture};
            var ___result = RMAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.PropagationPhase @phase, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @phase, @duration, @mouseCapture};
            var ___result = RMAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPropagationPaths(UnityEngine.UIElements.EventBase @evt, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPropagationPaths @paths)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @paths.Value};
            var ___result = RMAddPropagationPaths_EventBase_PropagationPaths.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddIMGUICall(UnityEngine.UIElements.EventBase @evt, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RMAddIMGUICall_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBeginProcessEvent(UnityEngine.UIElements.EventBase @evt, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @mouseCapture};
            var ___result = RMAddBeginProcessEvent_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddEndProcessEvent(UnityEngine.UIElements.EventBase @evt, System.Int64 @duration, UnityEngine.UIElements.IEventHandler @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RMAddEndProcessEvent_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetObjectDisplayName(System.Object @obj, System.Boolean @withHashCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @withHashCode};
            var ___result = RMGetObjectDisplayName_Object_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String GetTypeDisplayName(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetTypeDisplayName_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
