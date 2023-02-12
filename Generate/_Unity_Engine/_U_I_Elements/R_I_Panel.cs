
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PvisualTree;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPvisualTree
		{
			get
			{
				if(r_PvisualTree == null)
				{
					r_PvisualTree = new(this, "visualTree", -1);
					r_PvisualTree.SetBelong(this.instance);
				}
				return r_PvisualTree;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDispatcher dispatcher
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher r_Pdispatcher;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher RPdispatcher
		{
			get
			{
				if(r_Pdispatcher == null)
				{
					r_Pdispatcher = new(this, "dispatcher", -1);
					r_Pdispatcher.SetBelong(this.instance);
				}
				return r_Pdispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType contextType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RContextType r_PcontextType;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RContextType RPcontextType
		{
			get
			{
				if(r_PcontextType == null)
				{
					r_PcontextType = new(this, "contextType", -1);
					r_PcontextType.SetBelong(this.instance);
				}
				return r_PcontextType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
					r_PfocusController.SetBelong(this.instance);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager contextualMenuManager
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager r_PcontextualMenuManager;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager RPcontextualMenuManager
		{
			get
			{
				if(r_PcontextualMenuManager == null)
				{
					r_PcontextualMenuManager = new(this, "contextualMenuManager", -1);
					r_PcontextualMenuManager.SetBelong(this.instance);
				}
				return r_PcontextualMenuManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MPick_Vector2;
		public virtual RMethod RMPick_Vector2
		{
			get
			{
				if(r_MPick_Vector2 == null)
				{
					r_MPick_Vector2 = new(this, "Pick", 0, typeof(UnityEngine.Vector2));
					r_MPick_Vector2.SetBelong(this.instance);
				}
				return r_MPick_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2, System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MPickAll_Vector2_List_d_VisualElement_p_;
		public virtual RMethod RMPickAll_Vector2_List_d_VisualElement_p_
		{
			get
			{
				if(r_MPickAll_Vector2_List_d_VisualElement_p_ == null)
				{
					r_MPickAll_Vector2_List_d_VisualElement_p_ = new(this, "PickAll", 0, typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MPickAll_Vector2_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MPickAll_Vector2_List_d_VisualElement_p_;
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
            var ___result = RMPick_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RMPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


    }
}
