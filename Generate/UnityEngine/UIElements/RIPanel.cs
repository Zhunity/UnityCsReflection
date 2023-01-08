using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IPanel
	/// </summary>
    public partial class RIPanel : RMember //
    {

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
		/// UnityEngine.UIElements.EventDispatcher dispatcher
		/// </summary>
		protected RUnityEngine.RUIElements.REventDispatcher r_dispatcher;
		public virtual RUnityEngine.RUIElements.REventDispatcher Rdispatcher
		{
			get
			{
				if(r_dispatcher == null)
				{
					r_dispatcher = new(this, "dispatcher", -1);
					r_dispatcher.SetBelong(this.instance);
				}
				return r_dispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType contextType
		/// </summary>
		protected RProperty r_contextType;
		public virtual RProperty RcontextType
		{
			get
			{
				if(r_contextType == null)
				{
					r_contextType = new(this, "contextType", -1);
					r_contextType.SetBelong(this.instance);
				}
				return r_contextType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_focusController;
		public virtual RUnityEngine.RUIElements.RFocusController RfocusController
		{
			get
			{
				if(r_focusController == null)
				{
					r_focusController = new(this, "focusController", -1);
					r_focusController.SetBelong(this.instance);
				}
				return r_focusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager contextualMenuManager
		/// </summary>
		protected RUnityEngine.RUIElements.RContextualMenuManager r_contextualMenuManager;
		public virtual RUnityEngine.RUIElements.RContextualMenuManager RcontextualMenuManager
		{
			get
			{
				if(r_contextualMenuManager == null)
				{
					r_contextualMenuManager = new(this, "contextualMenuManager", -1);
					r_contextualMenuManager.SetBelong(this.instance);
				}
				return r_contextualMenuManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_Pick_Vector2;
		public virtual RMethod RPick_Vector2
		{
			get
			{
				if(r_Pick_Vector2 == null)
				{
					r_Pick_Vector2 = new(this, "Pick", 0, typeof(UnityEngine.Vector2));
					r_Pick_Vector2.SetBelong(this.instance);
				}
				return r_Pick_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2, System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_PickAll_Vector2_List_d_VisualElement_p_;
		public virtual RMethod RPickAll_Vector2_List_d_VisualElement_p_
		{
			get
			{
				if(r_PickAll_Vector2_List_d_VisualElement_p_ == null)
				{
					r_PickAll_Vector2_List_d_VisualElement_p_ = new(this, "PickAll", 0, typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_PickAll_Vector2_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_PickAll_Vector2_List_d_VisualElement_p_;
			}
		}


        public RIPanel() : base("UnityEngine.UIElements.IPanel")
        {
        }

        public RIPanel(System.Object instance) : base("UnityEngine.UIElements.IPanel")
		{
            SetInstance(instance);
		}

        public RIPanel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPanel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RPick_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


    }
}
