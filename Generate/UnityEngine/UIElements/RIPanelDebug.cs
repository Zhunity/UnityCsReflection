using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IPanelDebug
	/// </summary>
    public partial class RIPanelDebug : RMember //
    {

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
		/// UnityEngine.UIElements.IPanel debuggerOverlayPanel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_debuggerOverlayPanel;
		public virtual RUnityEngine.RUIElements.RIPanel RdebuggerOverlayPanel
		{
			get
			{
				if(r_debuggerOverlayPanel == null)
				{
					r_debuggerOverlayPanel = new(this, "debuggerOverlayPanel", -1);
					r_debuggerOverlayPanel.SetBelong(this.instance);
				}
				return r_debuggerOverlayPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_visualTree;
		public virtual RUnityEngine.RUIElements.RVisualElement RvisualTree
		{
			get
			{
				if(r_visualTree == null)
				{
					r_visualTree = new(this, "visualTree", -1);
					r_visualTree.SetBelong(this.instance);
				}
				return r_visualTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement debugContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_debugContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RdebugContainer
		{
			get
			{
				if(r_debugContainer == null)
				{
					r_debugContainer = new(this, "debugContainer", -1);
					r_debugContainer.SetBelong(this.instance);
				}
				return r_debugContainer;
			}
		}

		/// <summary>
		/// Boolean hasAttachedDebuggers
		/// </summary>
		protected RProperty r_hasAttachedDebuggers;
		public virtual RProperty RhasAttachedDebuggers
		{
			get
			{
				if(r_hasAttachedDebuggers == null)
				{
					r_hasAttachedDebuggers = new(this, "hasAttachedDebuggers", -1);
					r_hasAttachedDebuggers.SetBelong(this.instance);
				}
				return r_hasAttachedDebuggers;
			}
		}

		/// <summary>
		/// Void AttachDebugger(UnityEngine.UIElements.IPanelDebugger)
		/// </summary>
		protected RMethod r_AttachDebugger_IPanelDebugger;
		public virtual RMethod RAttachDebugger_IPanelDebugger
		{
			get
			{
				if(r_AttachDebugger_IPanelDebugger == null)
				{
					r_AttachDebugger_IPanelDebugger = new(this, "AttachDebugger", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IPanelDebugger"));
					r_AttachDebugger_IPanelDebugger.SetBelong(this.instance);
				}
				return r_AttachDebugger_IPanelDebugger;
			}
		}

		/// <summary>
		/// Void DetachDebugger(UnityEngine.UIElements.IPanelDebugger)
		/// </summary>
		protected RMethod r_DetachDebugger_IPanelDebugger;
		public virtual RMethod RDetachDebugger_IPanelDebugger
		{
			get
			{
				if(r_DetachDebugger_IPanelDebugger == null)
				{
					r_DetachDebugger_IPanelDebugger = new(this, "DetachDebugger", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IPanelDebugger"));
					r_DetachDebugger_IPanelDebugger.SetBelong(this.instance);
				}
				return r_DetachDebugger_IPanelDebugger;
			}
		}

		/// <summary>
		/// Void DetachAllDebuggers()
		/// </summary>
		protected RMethod r_DetachAllDebuggers;
		public virtual RMethod RDetachAllDebuggers
		{
			get
			{
				if(r_DetachAllDebuggers == null)
				{
					r_DetachAllDebuggers = new(this, "DetachAllDebuggers", 0);
					r_DetachAllDebuggers.SetBelong(this.instance);
				}
				return r_DetachAllDebuggers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.IPanelDebugger] GetAttachedDebuggers()
		/// </summary>
		protected RMethod r_GetAttachedDebuggers;
		public virtual RMethod RGetAttachedDebuggers
		{
			get
			{
				if(r_GetAttachedDebuggers == null)
				{
					r_GetAttachedDebuggers = new(this, "GetAttachedDebuggers", 0);
					r_GetAttachedDebuggers.SetBelong(this.instance);
				}
				return r_GetAttachedDebuggers;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MarkDirtyRepaint;
		public virtual RMethod RMarkDirtyRepaint
		{
			get
			{
				if(r_MarkDirtyRepaint == null)
				{
					r_MarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_MarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_MarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void MarkDebugContainerDirtyRepaint()
		/// </summary>
		protected RMethod r_MarkDebugContainerDirtyRepaint;
		public virtual RMethod RMarkDebugContainerDirtyRepaint
		{
			get
			{
				if(r_MarkDebugContainerDirtyRepaint == null)
				{
					r_MarkDebugContainerDirtyRepaint = new(this, "MarkDebugContainerDirtyRepaint", 0);
					r_MarkDebugContainerDirtyRepaint.SetBelong(this.instance);
				}
				return r_MarkDebugContainerDirtyRepaint;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_Refresh;
		public virtual RMethod RRefresh
		{
			get
			{
				if(r_Refresh == null)
				{
					r_Refresh = new(this, "Refresh", 0);
					r_Refresh.SetBelong(this.instance);
				}
				return r_Refresh;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_OnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_OnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_OnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_OnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_OnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Boolean InterceptEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_InterceptEvent_EventBase;
		public virtual RMethod RInterceptEvent_EventBase
		{
			get
			{
				if(r_InterceptEvent_EventBase == null)
				{
					r_InterceptEvent_EventBase = new(this, "InterceptEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_InterceptEvent_EventBase.SetBelong(this.instance);
				}
				return r_InterceptEvent_EventBase;
			}
		}

		/// <summary>
		/// Void PostProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_PostProcessEvent_EventBase;
		public virtual RMethod RPostProcessEvent_EventBase
		{
			get
			{
				if(r_PostProcessEvent_EventBase == null)
				{
					r_PostProcessEvent_EventBase = new(this, "PostProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_PostProcessEvent_EventBase.SetBelong(this.instance);
				}
				return r_PostProcessEvent_EventBase;
			}
		}


        public RIPanelDebug() : base("UnityEngine.UIElements.IPanelDebug")
        {
        }

        public RIPanelDebug(System.Object instance) : base("UnityEngine.UIElements.IPanelDebug")
		{
            SetInstance(instance);
		}

        public RIPanelDebug(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPanelDebug(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AttachDebugger(RUnityEngine.RUIElements.RIPanelDebugger @debugger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@debugger.Value};
            var ___result = RAttachDebugger_IPanelDebugger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetachDebugger(RUnityEngine.RUIElements.RIPanelDebugger @debugger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@debugger.Value};
            var ___result = RDetachDebugger_IPanelDebugger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetachAllDebuggers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDetachAllDebuggers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RIPanelDebugger> GetAttachedDebuggers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttachedDebuggers.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RIPanelDebugger>(___result);
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDebugContainerDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDebugContainerDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ele, RType @changeTypeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ele, @changeTypeFlag.Value};
            var ___result = ROnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InterceptEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RInterceptEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PostProcessEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RPostProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


    }
}
