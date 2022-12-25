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
		protected RMethod r_RAttachDebugger_IPanelDebugger;
		public virtual RMethod RAttachDebugger_IPanelDebugger
		{
			get
			{
				if(r_RAttachDebugger_IPanelDebugger == null)
				{
					r_RAttachDebugger_IPanelDebugger = new(this, "AttachDebugger", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.IPanelDebugger"));
					r_RAttachDebugger_IPanelDebugger.SetBelong(this.instance);
				}
				return r_RAttachDebugger_IPanelDebugger;
			}
		}

		/// <summary>
		/// Void DetachDebugger(UnityEngine.UIElements.IPanelDebugger)
		/// </summary>
		protected RMethod r_RDetachDebugger_IPanelDebugger;
		public virtual RMethod RDetachDebugger_IPanelDebugger
		{
			get
			{
				if(r_RDetachDebugger_IPanelDebugger == null)
				{
					r_RDetachDebugger_IPanelDebugger = new(this, "DetachDebugger", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.IPanelDebugger"));
					r_RDetachDebugger_IPanelDebugger.SetBelong(this.instance);
				}
				return r_RDetachDebugger_IPanelDebugger;
			}
		}

		/// <summary>
		/// Void DetachAllDebuggers()
		/// </summary>
		protected RMethod r_RDetachAllDebuggers;
		public virtual RMethod RDetachAllDebuggers
		{
			get
			{
				if(r_RDetachAllDebuggers == null)
				{
					r_RDetachAllDebuggers = new(this, "DetachAllDebuggers", 0);
					r_RDetachAllDebuggers.SetBelong(this.instance);
				}
				return r_RDetachAllDebuggers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.IPanelDebugger] GetAttachedDebuggers()
		/// </summary>
		protected RMethod r_RGetAttachedDebuggers;
		public virtual RMethod RGetAttachedDebuggers
		{
			get
			{
				if(r_RGetAttachedDebuggers == null)
				{
					r_RGetAttachedDebuggers = new(this, "GetAttachedDebuggers", 0);
					r_RGetAttachedDebuggers.SetBelong(this.instance);
				}
				return r_RGetAttachedDebuggers;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_RMarkDirtyRepaint;
		public virtual RMethod RMarkDirtyRepaint
		{
			get
			{
				if(r_RMarkDirtyRepaint == null)
				{
					r_RMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_RMarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_RMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void MarkDebugContainerDirtyRepaint()
		/// </summary>
		protected RMethod r_RMarkDebugContainerDirtyRepaint;
		public virtual RMethod RMarkDebugContainerDirtyRepaint
		{
			get
			{
				if(r_RMarkDebugContainerDirtyRepaint == null)
				{
					r_RMarkDebugContainerDirtyRepaint = new(this, "MarkDebugContainerDirtyRepaint", 0);
					r_RMarkDebugContainerDirtyRepaint.SetBelong(this.instance);
				}
				return r_RMarkDebugContainerDirtyRepaint;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_RRefresh;
		public virtual RMethod RRefresh
		{
			get
			{
				if(r_RRefresh == null)
				{
					r_RRefresh = new(this, "Refresh", 0);
					r_RRefresh.SetBelong(this.instance);
				}
				return r_RRefresh;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_ROnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_ROnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_ROnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_ROnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_ROnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Boolean InterceptEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RInterceptEvent_EventBase;
		public virtual RMethod RInterceptEvent_EventBase
		{
			get
			{
				if(r_RInterceptEvent_EventBase == null)
				{
					r_RInterceptEvent_EventBase = new(this, "InterceptEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RInterceptEvent_EventBase.SetBelong(this.instance);
				}
				return r_RInterceptEvent_EventBase;
			}
		}

		/// <summary>
		/// Void PostProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RPostProcessEvent_EventBase;
		public virtual RMethod RPostProcessEvent_EventBase
		{
			get
			{
				if(r_RPostProcessEvent_EventBase == null)
				{
					r_RPostProcessEvent_EventBase = new(this, "PostProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RPostProcessEvent_EventBase.SetBelong(this.instance);
				}
				return r_RPostProcessEvent_EventBase;
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



        public virtual void DetachAllDebuggers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDetachAllDebuggers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetAttachedDebuggers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttachedDebuggers.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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



        public virtual System.Boolean InterceptEvent(UnityEngine.UIElements.EventBase  @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RInterceptEvent_EventBase.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PostProcessEvent(UnityEngine.UIElements.EventBase  @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RPostProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


    }
}
