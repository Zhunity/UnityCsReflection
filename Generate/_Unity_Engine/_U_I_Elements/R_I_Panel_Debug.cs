
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.IPanelDebug
	/// </summary>
    public partial class RIPanelDebug : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.IPanelDebug");
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
		/// UnityEngine.UIElements.IPanel debuggerOverlayPanel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel r_PdebuggerOverlayPanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel RPdebuggerOverlayPanel
		{
			get
			{
				if(r_PdebuggerOverlayPanel == null)
				{
					r_PdebuggerOverlayPanel = new(this, "debuggerOverlayPanel", -1);
				}
				return r_PdebuggerOverlayPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PvisualTree;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPvisualTree
		{
			get
			{
				if(r_PvisualTree == null)
				{
					r_PvisualTree = new(this, "visualTree", -1);
				}
				return r_PvisualTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement debugContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PdebugContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPdebugContainer
		{
			get
			{
				if(r_PdebugContainer == null)
				{
					r_PdebugContainer = new(this, "debugContainer", -1);
				}
				return r_PdebugContainer;
			}
		}

		/// <summary>
		/// Boolean hasAttachedDebuggers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasAttachedDebuggers;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasAttachedDebuggers
		{
			get
			{
				if(r_PhasAttachedDebuggers == null)
				{
					r_PhasAttachedDebuggers = new(this, "hasAttachedDebuggers", -1);
				}
				return r_PhasAttachedDebuggers;
			}
		}

		/// <summary>
		/// Void AttachDebugger(UnityEngine.UIElements.IPanelDebugger)
		/// </summary>
		protected RMethod r_MAttachDebugger_IPanelDebugger;
		public virtual RMethod RMAttachDebugger_IPanelDebugger
		{
			get
			{
				if(r_MAttachDebugger_IPanelDebugger == null)
				{
					r_MAttachDebugger_IPanelDebugger = new(this, "AttachDebugger", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IPanelDebugger"));
				}
				return r_MAttachDebugger_IPanelDebugger;
			}
		}

		/// <summary>
		/// Void DetachDebugger(UnityEngine.UIElements.IPanelDebugger)
		/// </summary>
		protected RMethod r_MDetachDebugger_IPanelDebugger;
		public virtual RMethod RMDetachDebugger_IPanelDebugger
		{
			get
			{
				if(r_MDetachDebugger_IPanelDebugger == null)
				{
					r_MDetachDebugger_IPanelDebugger = new(this, "DetachDebugger", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.IPanelDebugger"));
				}
				return r_MDetachDebugger_IPanelDebugger;
			}
		}

		/// <summary>
		/// Void DetachAllDebuggers()
		/// </summary>
		protected RMethod r_MDetachAllDebuggers;
		public virtual RMethod RMDetachAllDebuggers
		{
			get
			{
				if(r_MDetachAllDebuggers == null)
				{
					r_MDetachAllDebuggers = new(this, "DetachAllDebuggers", 0);
				}
				return r_MDetachAllDebuggers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.IPanelDebugger] GetAttachedDebuggers()
		/// </summary>
		protected RMethod r_MGetAttachedDebuggers;
		public virtual RMethod RMGetAttachedDebuggers
		{
			get
			{
				if(r_MGetAttachedDebuggers == null)
				{
					r_MGetAttachedDebuggers = new(this, "GetAttachedDebuggers", 0);
				}
				return r_MGetAttachedDebuggers;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MMarkDirtyRepaint;
		public virtual RMethod RMMarkDirtyRepaint
		{
			get
			{
				if(r_MMarkDirtyRepaint == null)
				{
					r_MMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
				}
				return r_MMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void MarkDebugContainerDirtyRepaint()
		/// </summary>
		protected RMethod r_MMarkDebugContainerDirtyRepaint;
		public virtual RMethod RMMarkDebugContainerDirtyRepaint
		{
			get
			{
				if(r_MMarkDebugContainerDirtyRepaint == null)
				{
					r_MMarkDebugContainerDirtyRepaint = new(this, "MarkDebugContainerDirtyRepaint", 0);
				}
				return r_MMarkDebugContainerDirtyRepaint;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_MRefresh;
		public virtual RMethod RMRefresh
		{
			get
			{
				if(r_MRefresh == null)
				{
					r_MRefresh = new(this, "Refresh", 0);
				}
				return r_MRefresh;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MOnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod RMOnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_MOnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_MOnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Boolean InterceptEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MInterceptEvent_EventBase;
		public virtual RMethod RMInterceptEvent_EventBase
		{
			get
			{
				if(r_MInterceptEvent_EventBase == null)
				{
					r_MInterceptEvent_EventBase = new(this, "InterceptEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MInterceptEvent_EventBase;
			}
		}

		/// <summary>
		/// Void PostProcessEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MPostProcessEvent_EventBase;
		public virtual RMethod RMPostProcessEvent_EventBase
		{
			get
			{
				if(r_MPostProcessEvent_EventBase == null)
				{
					r_MPostProcessEvent_EventBase = new(this, "PostProcessEvent", 0, typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MPostProcessEvent_EventBase;
			}
		}


        public virtual void AttachDebugger(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebugger @debugger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@debugger.Value};
            var ___result = RMAttachDebugger_IPanelDebugger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetachDebugger(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebugger @debugger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@debugger.Value};
            var ___result = RMDetachDebugger_IPanelDebugger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetachAllDebuggers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDetachAllDebuggers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebugger> GetAttachedDebuggers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAttachedDebuggers.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanelDebugger>>(___result);
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDebugContainerDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDebugContainerDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ele, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @changeTypeFlag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ele, @changeTypeFlag.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InterceptEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RMInterceptEvent_EventBase.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void PostProcessEvent(UnityEngine.UIElements.EventBase @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev};
            var ___result = RMPostProcessEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


    }
}
