using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventDebugger
	/// </summary>
    public partial class REventDebugger : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug m_PanelDebug
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanelDebug r_m_PanelDebug;
		public virtual RUnityEngine.RUIElements.RIPanelDebug Rm_PanelDebug
		{
			get
			{
				if(r_m_PanelDebug == null)
				{
					r_m_PanelDebug = new(this, "m_PanelDebug");
					r_m_PanelDebug.SetBelong(this.instance);
				}
				return r_m_PanelDebug;
			}
		}

		/// <summary>
		/// System.Boolean <isReplaying>k__BackingField
		/// </summary>
		protected RField r___1__isReplaying__2__k__BackingField;
		public virtual RField R__1__isReplaying__2__k__BackingField
		{
			get
			{
				if(r___1__isReplaying__2__k__BackingField == null)
				{
					r___1__isReplaying__2__k__BackingField = new(this, "<isReplaying>k__BackingField");
					r___1__isReplaying__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__isReplaying__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <playbackSpeed>k__BackingField
		/// </summary>
		protected RField r___1__playbackSpeed__2__k__BackingField;
		public virtual RField R__1__playbackSpeed__2__k__BackingField
		{
			get
			{
				if(r___1__playbackSpeed__2__k__BackingField == null)
				{
					r___1__playbackSpeed__2__k__BackingField = new(this, "<playbackSpeed>k__BackingField");
					r___1__playbackSpeed__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__playbackSpeed__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isPlaybackPaused>k__BackingField
		/// </summary>
		protected RField r___1__isPlaybackPaused__2__k__BackingField;
		public virtual RField R__1__isPlaybackPaused__2__k__BackingField
		{
			get
			{
				if(r___1__isPlaybackPaused__2__k__BackingField == null)
				{
					r___1__isPlaybackPaused__2__k__BackingField = new(this, "<isPlaybackPaused>k__BackingField");
					r___1__isPlaybackPaused__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__isPlaybackPaused__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerCallTrace]] m_EventCalledObjects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerCallTrace>> r_m_EventCalledObjects;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerCallTrace>> Rm_EventCalledObjects
		{
			get
			{
				if(r_m_EventCalledObjects == null)
				{
					r_m_EventCalledObjects = new(this, "m_EventCalledObjects");
					r_m_EventCalledObjects.SetBelong(this.instance);
				}
				return r_m_EventCalledObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerDefaultActionTrace]] m_EventDefaultActionObjects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerDefaultActionTrace>> r_m_EventDefaultActionObjects;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerDefaultActionTrace>> Rm_EventDefaultActionObjects
		{
			get
			{
				if(r_m_EventDefaultActionObjects == null)
				{
					r_m_EventDefaultActionObjects = new(this, "m_EventDefaultActionObjects");
					r_m_EventDefaultActionObjects.SetBelong(this.instance);
				}
				return r_m_EventDefaultActionObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerPathTrace]] m_EventPathObjects
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerPathTrace>> r_m_EventPathObjects;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerPathTrace>> Rm_EventPathObjects
		{
			get
			{
				if(r_m_EventPathObjects == null)
				{
					r_m_EventPathObjects = new(this, "m_EventPathObjects");
					r_m_EventPathObjects.SetBelong(this.instance);
				}
				return r_m_EventPathObjects;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerTrace]] m_EventProcessedEvents
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerTrace>> r_m_EventProcessedEvents;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.REventDebuggerTrace>> Rm_EventProcessedEvents
		{
			get
			{
				if(r_m_EventProcessedEvents == null)
				{
					r_m_EventProcessedEvents = new(this, "m_EventProcessedEvents");
					r_m_EventProcessedEvents.SetBelong(this.instance);
				}
				return r_m_EventProcessedEvents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.Stack`1[UnityEngine.UIElements.EventDebuggerTrace]] m_StackOfProcessedEvent
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.REventDebuggerTrace>> r_m_StackOfProcessedEvent;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.REventDebuggerTrace>> Rm_StackOfProcessedEvent
		{
			get
			{
				if(r_m_StackOfProcessedEvent == null)
				{
					r_m_StackOfProcessedEvent = new(this, "m_StackOfProcessedEvent");
					r_m_StackOfProcessedEvent.SetBelong(this.instance);
				}
				return r_m_StackOfProcessedEvent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Collections.Generic.Dictionary`2[System.Int64,System.Int32]] m_EventTypeProcessedCount
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RDictionary<RField, RField>> r_m_EventTypeProcessedCount;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RSystem.RCollections.RGeneric.RDictionary<RField, RField>> Rm_EventTypeProcessedCount
		{
			get
			{
				if(r_m_EventTypeProcessedCount == null)
				{
					r_m_EventTypeProcessedCount = new(this, "m_EventTypeProcessedCount");
					r_m_EventTypeProcessedCount.SetBelong(this.instance);
				}
				return r_m_EventTypeProcessedCount;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.UIElements.IPanel,System.Int64] m_ModificationCount
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RField> r_m_ModificationCount;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.RUIElements.RIPanel, RField> Rm_ModificationCount
		{
			get
			{
				if(r_m_ModificationCount == null)
				{
					r_m_ModificationCount = new(this, "m_ModificationCount");
					r_m_ModificationCount.SetBelong(this.instance);
				}
				return r_m_ModificationCount;
			}
		}

		/// <summary>
		/// System.Boolean m_Log
		/// </summary>
		protected RField r_m_Log;
		public virtual RField Rm_Log
		{
			get
			{
				if(r_m_Log == null)
				{
					r_m_Log = new(this, "m_Log");
					r_m_Log.SetBelong(this.instance);
				}
				return r_m_Log;
			}
		}

		/// <summary>
		/// System.Boolean <suspended>k__BackingField
		/// </summary>
		protected RField r___1__suspended__2__k__BackingField;
		public virtual RField R__1__suspended__2__k__BackingField
		{
			get
			{
				if(r___1__suspended__2__k__BackingField == null)
				{
					r___1__suspended__2__k__BackingField = new(this, "<suspended>k__BackingField");
					r___1__suspended__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__suspended__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_panel;
		public virtual RUnityEngine.RUIElements.RIPanel Rpanel
		{
			get
			{
				if(r_panel == null)
				{
					r_panel = new(this, "panel", -1);
					r_panel.SetBelong(this.instance);
				}
				return r_panel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanelDebug panelDebug
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanelDebug r_panelDebug;
		public virtual RUnityEngine.RUIElements.RIPanelDebug RpanelDebug
		{
			get
			{
				if(r_panelDebug == null)
				{
					r_panelDebug = new(this, "panelDebug", -1);
					r_panelDebug.SetBelong(this.instance);
				}
				return r_panelDebug;
			}
		}

		/// <summary>
		/// Boolean isReplaying
		/// </summary>
		protected RProperty r_isReplaying;
		public virtual RProperty RisReplaying
		{
			get
			{
				if(r_isReplaying == null)
				{
					r_isReplaying = new(this, "isReplaying", -1);
					r_isReplaying.SetBelong(this.instance);
				}
				return r_isReplaying;
			}
		}

		/// <summary>
		/// Single playbackSpeed
		/// </summary>
		protected RProperty r_playbackSpeed;
		public virtual RProperty RplaybackSpeed
		{
			get
			{
				if(r_playbackSpeed == null)
				{
					r_playbackSpeed = new(this, "playbackSpeed", -1);
					r_playbackSpeed.SetBelong(this.instance);
				}
				return r_playbackSpeed;
			}
		}

		/// <summary>
		/// Boolean isPlaybackPaused
		/// </summary>
		protected RProperty r_isPlaybackPaused;
		public virtual RProperty RisPlaybackPaused
		{
			get
			{
				if(r_isPlaybackPaused == null)
				{
					r_isPlaybackPaused = new(this, "isPlaybackPaused", -1);
					r_isPlaybackPaused.SetBelong(this.instance);
				}
				return r_isPlaybackPaused;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int64,System.Int32] eventTypeProcessedCount
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_eventTypeProcessedCount;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> ReventTypeProcessedCount
		{
			get
			{
				if(r_eventTypeProcessedCount == null)
				{
					r_eventTypeProcessedCount = new(this, "eventTypeProcessedCount", -1);
					r_eventTypeProcessedCount.SetBelong(this.instance);
				}
				return r_eventTypeProcessedCount;
			}
		}

		/// <summary>
		/// Boolean suspended
		/// </summary>
		protected RProperty r_suspended;
		public virtual RProperty Rsuspended
		{
			get
			{
				if(r_suspended == null)
				{
					r_suspended = new(this, "suspended", -1);
					r_suspended.SetBelong(this.instance);
				}
				return r_suspended;
			}
		}

		/// <summary>
		/// Void UpdateModificationCount()
		/// </summary>
		protected RMethod r_RUpdateModificationCount;
		public virtual RMethod RUpdateModificationCount
		{
			get
			{
				if(r_RUpdateModificationCount == null)
				{
					r_RUpdateModificationCount = new(this, "UpdateModificationCount", 0);
					r_RUpdateModificationCount.SetBelong(this.instance);
				}
				return r_RUpdateModificationCount;
			}
		}

		/// <summary>
		/// Void BeginProcessEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RBeginProcessEvent_EventBase_IEventHandler;
		public virtual RMethod RBeginProcessEvent_EventBase_IEventHandler
		{
			get
			{
				if(r_RBeginProcessEvent_EventBase_IEventHandler == null)
				{
					r_RBeginProcessEvent_EventBase_IEventHandler = new(this, "BeginProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_RBeginProcessEvent_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_RBeginProcessEvent_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void EndProcessEvent(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_REndProcessEvent_EventBase_Int64_IEventHandler;
		public virtual RMethod REndProcessEvent_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_REndProcessEvent_EventBase_Int64_IEventHandler == null)
				{
					r_REndProcessEvent_EventBase_Int64_IEventHandler = new(this, "EndProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_REndProcessEvent_EventBase_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_REndProcessEvent_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogCall(Int32, System.String, UnityEngine.UIElements.EventBase, Boolean, Boolean, Boolean, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
		public virtual RMethod RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler
		{
			get
			{
				if(r_RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler == null)
				{
					r_RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler = new(this, "LogCall", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogIMGUICall(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RLogIMGUICall_EventBase_Int64_IEventHandler;
		public virtual RMethod RLogIMGUICall_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_RLogIMGUICall_EventBase_Int64_IEventHandler == null)
				{
					r_RLogIMGUICall_EventBase_Int64_IEventHandler = new(this, "LogIMGUICall", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RLogIMGUICall_EventBase_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RLogIMGUICall_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogExecuteDefaultAction(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPhase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
		public virtual RMethod RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler
		{
			get
			{
				if(r_RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler == null)
				{
					r_RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler = new(this, "LogExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.PropagationPhase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void LogPropagationPaths(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected static RMethod r_RLogPropagationPaths_EventBase_PropagationPaths;
		public static RMethod RLogPropagationPaths_EventBase_PropagationPaths
		{
			get
			{
				if(r_RLogPropagationPaths_EventBase_PropagationPaths == null)
				{
					r_RLogPropagationPaths_EventBase_PropagationPaths = new( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebugger"), "LogPropagationPaths", 0, typeof(UnityEngine.UIElements.EventBase),  ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
					r_RLogPropagationPaths_EventBase_PropagationPaths.SetBelong(null);
				}
				return r_RLogPropagationPaths_EventBase_PropagationPaths;
			}
		}

		/// <summary>
		/// Void LogPropagationPathsInternal(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected RMethod r_RLogPropagationPathsInternal_EventBase_PropagationPaths;
		public virtual RMethod RLogPropagationPathsInternal_EventBase_PropagationPaths
		{
			get
			{
				if(r_RLogPropagationPathsInternal_EventBase_PropagationPaths == null)
				{
					r_RLogPropagationPathsInternal_EventBase_PropagationPaths = new(this, "LogPropagationPathsInternal", 0, typeof(UnityEngine.UIElements.EventBase),  ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
					r_RLogPropagationPathsInternal_EventBase_PropagationPaths.SetBelong(this.instance);
				}
				return r_RLogPropagationPathsInternal_EventBase_PropagationPaths;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerCallTrace] GetCalls(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_RGetCalls_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RGetCalls_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_RGetCalls_IPanel_EventDebuggerEventRecord == null)
				{
					r_RGetCalls_IPanel_EventDebuggerEventRecord = new(this, "GetCalls", 0, typeof(UnityEngine.UIElements.IPanel),  ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
					r_RGetCalls_IPanel_EventDebuggerEventRecord.SetBelong(this.instance);
				}
				return r_RGetCalls_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerDefaultActionTrace] GetDefaultActions(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_RGetDefaultActions_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RGetDefaultActions_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_RGetDefaultActions_IPanel_EventDebuggerEventRecord == null)
				{
					r_RGetDefaultActions_IPanel_EventDebuggerEventRecord = new(this, "GetDefaultActions", 0, typeof(UnityEngine.UIElements.IPanel),  ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
					r_RGetDefaultActions_IPanel_EventDebuggerEventRecord.SetBelong(this.instance);
				}
				return r_RGetDefaultActions_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerPathTrace] GetPropagationPaths(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_RGetPropagationPaths_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RGetPropagationPaths_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_RGetPropagationPaths_IPanel_EventDebuggerEventRecord == null)
				{
					r_RGetPropagationPaths_IPanel_EventDebuggerEventRecord = new(this, "GetPropagationPaths", 0, typeof(UnityEngine.UIElements.IPanel),  ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
					r_RGetPropagationPaths_IPanel_EventDebuggerEventRecord.SetBelong(this.instance);
				}
				return r_RGetPropagationPaths_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerTrace] GetBeginEndProcessedEvents(UnityEngine.UIElements.IPanel, UnityEngine.UIElements.EventDebuggerEventRecord)
		/// </summary>
		protected RMethod r_RGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord;
		public virtual RMethod RGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord
		{
			get
			{
				if(r_RGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord == null)
				{
					r_RGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord = new(this, "GetBeginEndProcessedEvents", 0, typeof(UnityEngine.UIElements.IPanel),  ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord"));
					r_RGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord.SetBelong(this.instance);
				}
				return r_RGetBeginEndProcessedEvents_IPanel_EventDebuggerEventRecord;
			}
		}

		/// <summary>
		/// Int64 GetModificationCount(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RGetModificationCount_IPanel;
		public virtual RMethod RGetModificationCount_IPanel
		{
			get
			{
				if(r_RGetModificationCount_IPanel == null)
				{
					r_RGetModificationCount_IPanel = new(this, "GetModificationCount", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RGetModificationCount_IPanel.SetBelong(this.instance);
				}
				return r_RGetModificationCount_IPanel;
			}
		}

		/// <summary>
		/// Void ClearLogs()
		/// </summary>
		protected RMethod r_RClearLogs;
		public virtual RMethod RClearLogs
		{
			get
			{
				if(r_RClearLogs == null)
				{
					r_RClearLogs = new(this, "ClearLogs", 0);
					r_RClearLogs.SetBelong(this.instance);
				}
				return r_RClearLogs;
			}
		}

		/// <summary>
		/// Void SaveReplaySessionFromSelection(System.String, System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerEventRecord])
		/// </summary>
		protected RMethod r_RSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_;
		public virtual RMethod RSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_
		{
			get
			{
				if(r_RSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_ == null)
				{
					r_RSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_ = new(this, "SaveReplaySessionFromSelection", 0, typeof(System.String), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")));
					r_RSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_.SetBelong(this.instance);
				}
				return r_RSaveReplaySessionFromSelection_String_List_d_EventDebuggerEventRecord_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebuggerRecordList LoadReplaySession(System.String)
		/// </summary>
		protected RMethod r_RLoadReplaySession_String;
		public virtual RMethod RLoadReplaySession_String
		{
			get
			{
				if(r_RLoadReplaySession_String == null)
				{
					r_RLoadReplaySession_String = new(this, "LoadReplaySession", 0, typeof(System.String));
					r_RLoadReplaySession_String.SetBelong(this.instance);
				}
				return r_RLoadReplaySession_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ReplayEvents(System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EventDebuggerEventRecord], System.Action`2[System.Int32,System.Int32])
		/// </summary>
		protected RMethod r_RReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
		public virtual RMethod RReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_
		{
			get
			{
				if(r_RReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ == null)
				{
					r_RReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ = new(this, "ReplayEvents", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")), typeof(System.Action<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)));
					r_RReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_.SetBelong(this.instance);
				}
				return r_RReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
			}
		}

		/// <summary>
		/// Void StopPlayback()
		/// </summary>
		protected RMethod r_RStopPlayback;
		public virtual RMethod RStopPlayback
		{
			get
			{
				if(r_RStopPlayback == null)
				{
					r_RStopPlayback = new(this, "StopPlayback", 0);
					r_RStopPlayback.SetBelong(this.instance);
				}
				return r_RStopPlayback;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator DoReplayEvents(System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EventDebuggerEventRecord], System.Action`2[System.Int32,System.Int32])
		/// </summary>
		protected RMethod r_RDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
		public virtual RMethod RDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_
		{
			get
			{
				if(r_RDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ == null)
				{
					r_RDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_ = new(this, "DoReplayEvents", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")), typeof(System.Action<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)));
					r_RDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_.SetBelong(this.instance);
				}
				return r_RDoReplayEvents_IEnumerable_d_EventDebuggerEventRecord_p__Action_d_Int32_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.EventDebugger+HistogramRecord] ComputeHistogram(System.Collections.Generic.List`1[UnityEngine.UIElements.EventDebuggerEventRecord])
		/// </summary>
		protected RMethod r_RComputeHistogram_List_d_EventDebuggerEventRecord_p_;
		public virtual RMethod RComputeHistogram_List_d_EventDebuggerEventRecord_p_
		{
			get
			{
				if(r_RComputeHistogram_List_d_EventDebuggerEventRecord_p_ == null)
				{
					r_RComputeHistogram_List_d_EventDebuggerEventRecord_p_ = new(this, "ComputeHistogram", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebuggerEventRecord")));
					r_RComputeHistogram_List_d_EventDebuggerEventRecord_p_.SetBelong(this.instance);
				}
				return r_RComputeHistogram_List_d_EventDebuggerEventRecord_p_;
			}
		}

		/// <summary>
		/// Void AddCallObject(Int32, System.String, UnityEngine.UIElements.EventBase, Boolean, Boolean, Boolean, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
		public virtual RMethod RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler
		{
			get
			{
				if(r_RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler == null)
				{
					r_RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler = new(this, "AddCallObject", 0, typeof(System.Int32), typeof(System.String), typeof(UnityEngine.UIElements.EventBase), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddExecuteDefaultAction(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPhase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
		public virtual RMethod RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler
		{
			get
			{
				if(r_RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler == null)
				{
					r_RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler = new(this, "AddExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.PropagationPhase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddPropagationPaths(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.PropagationPaths)
		/// </summary>
		protected RMethod r_RAddPropagationPaths_EventBase_PropagationPaths;
		public virtual RMethod RAddPropagationPaths_EventBase_PropagationPaths
		{
			get
			{
				if(r_RAddPropagationPaths_EventBase_PropagationPaths == null)
				{
					r_RAddPropagationPaths_EventBase_PropagationPaths = new(this, "AddPropagationPaths", 0, typeof(UnityEngine.UIElements.EventBase),  ReleactionUtils.GetType("UnityEngine.UIElements.PropagationPaths"));
					r_RAddPropagationPaths_EventBase_PropagationPaths.SetBelong(this.instance);
				}
				return r_RAddPropagationPaths_EventBase_PropagationPaths;
			}
		}

		/// <summary>
		/// Void AddIMGUICall(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RAddIMGUICall_EventBase_Int64_IEventHandler;
		public virtual RMethod RAddIMGUICall_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_RAddIMGUICall_EventBase_Int64_IEventHandler == null)
				{
					r_RAddIMGUICall_EventBase_Int64_IEventHandler = new(this, "AddIMGUICall", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RAddIMGUICall_EventBase_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RAddIMGUICall_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddBeginProcessEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RAddBeginProcessEvent_EventBase_IEventHandler;
		public virtual RMethod RAddBeginProcessEvent_EventBase_IEventHandler
		{
			get
			{
				if(r_RAddBeginProcessEvent_EventBase_IEventHandler == null)
				{
					r_RAddBeginProcessEvent_EventBase_IEventHandler = new(this, "AddBeginProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(UnityEngine.UIElements.IEventHandler));
					r_RAddBeginProcessEvent_EventBase_IEventHandler.SetBelong(this.instance);
				}
				return r_RAddBeginProcessEvent_EventBase_IEventHandler;
			}
		}

		/// <summary>
		/// Void AddEndProcessEvent(UnityEngine.UIElements.EventBase, Int64, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_RAddEndProcessEvent_EventBase_Int64_IEventHandler;
		public virtual RMethod RAddEndProcessEvent_EventBase_Int64_IEventHandler
		{
			get
			{
				if(r_RAddEndProcessEvent_EventBase_Int64_IEventHandler == null)
				{
					r_RAddEndProcessEvent_EventBase_Int64_IEventHandler = new(this, "AddEndProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase), typeof(System.Int64), typeof(UnityEngine.UIElements.IEventHandler));
					r_RAddEndProcessEvent_EventBase_Int64_IEventHandler.SetBelong(this.instance);
				}
				return r_RAddEndProcessEvent_EventBase_Int64_IEventHandler;
			}
		}

		/// <summary>
		/// System.String GetObjectDisplayName(System.Object, Boolean)
		/// </summary>
		protected static RMethod r_RGetObjectDisplayName_Object_Boolean;
		public static RMethod RGetObjectDisplayName_Object_Boolean
		{
			get
			{
				if(r_RGetObjectDisplayName_Object_Boolean == null)
				{
					r_RGetObjectDisplayName_Object_Boolean = new( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebugger"), "GetObjectDisplayName", 0, typeof(System.Object), typeof(System.Boolean));
					r_RGetObjectDisplayName_Object_Boolean.SetBelong(null);
				}
				return r_RGetObjectDisplayName_Object_Boolean;
			}
		}

		/// <summary>
		/// System.String GetTypeDisplayName(System.Type)
		/// </summary>
		protected static RMethod r_RGetTypeDisplayName_Type;
		public static RMethod RGetTypeDisplayName_Type
		{
			get
			{
				if(r_RGetTypeDisplayName_Type == null)
				{
					r_RGetTypeDisplayName_Type = new( ReleactionUtils.GetType("UnityEngine.UIElements.EventDebugger"), "GetTypeDisplayName", 0, typeof(System.Type));
					r_RGetTypeDisplayName_Type.SetBelong(null);
				}
				return r_RGetTypeDisplayName_Type;
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

        public virtual void UpdateModificationCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateModificationCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginProcessEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @mouseCapture};
            var ___result = RBeginProcessEvent_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndProcessEvent(UnityEngine.UIElements.EventBase  @evt, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = REndProcessEvent_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogCall(System.Int32  @cbHashCode, System.String  @cbName, UnityEngine.UIElements.EventBase  @evt, System.Boolean  @propagationHasStopped, System.Boolean  @immediatePropagationHasStopped, System.Boolean  @defaultHasBeenPrevented, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cbHashCode, @cbName, @evt, @propagationHasStopped, @immediatePropagationHasStopped, @defaultHasBeenPrevented, @duration, @mouseCapture};
            var ___result = RLogCall_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogIMGUICall(UnityEngine.UIElements.EventBase  @evt, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RLogIMGUICall_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LogExecuteDefaultAction(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.PropagationPhase  @phase, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @phase, @duration, @mouseCapture};
            var ___result = RLogExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }








        public virtual System.Int64 GetModificationCount(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RGetModificationCount_IPanel.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void ClearLogs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearLogs.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object LoadReplaySession(System.String  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RLoadReplaySession_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void StopPlayback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopPlayback.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void AddCallObject(System.Int32  @cbHashCode, System.String  @cbName, UnityEngine.UIElements.EventBase  @evt, System.Boolean  @propagationHasStopped, System.Boolean  @immediatePropagationHasStopped, System.Boolean  @defaultHasBeenPrevented, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cbHashCode, @cbName, @evt, @propagationHasStopped, @immediatePropagationHasStopped, @defaultHasBeenPrevented, @duration, @mouseCapture};
            var ___result = RAddCallObject_Int32_String_EventBase_Boolean_Boolean_Boolean_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExecuteDefaultAction(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.PropagationPhase  @phase, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @phase, @duration, @mouseCapture};
            var ___result = RAddExecuteDefaultAction_EventBase_PropagationPhase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void AddIMGUICall(UnityEngine.UIElements.EventBase  @evt, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RAddIMGUICall_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBeginProcessEvent(UnityEngine.UIElements.EventBase  @evt, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @mouseCapture};
            var ___result = RAddBeginProcessEvent_EventBase_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddEndProcessEvent(UnityEngine.UIElements.EventBase  @evt, System.Int64  @duration, UnityEngine.UIElements.IEventHandler  @mouseCapture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @duration, @mouseCapture};
            var ___result = RAddEndProcessEvent_EventBase_Int64_IEventHandler.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String GetObjectDisplayName(System.Object  @obj, System.Boolean  @withHashCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @withHashCode};
            var ___result = RGetObjectDisplayName_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetTypeDisplayName(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetTypeDisplayName_Type.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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