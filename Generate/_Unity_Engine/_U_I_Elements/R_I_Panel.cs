
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IPanel
	/// </summary>
    public partial class RIPanel : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IPanel);
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
		/// UnityEngine.UIElements.EventDispatcher dispatcher
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher r_Pdispatcher;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventDispatcher RPdispatcher
		{
			get
			{
				if(r_Pdispatcher == null)
				{
					r_Pdispatcher = new(this, "dispatcher", -1);
				}
				return r_Pdispatcher;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextType contextType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextType r_PcontextType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextType RPcontextType
		{
			get
			{
				if(r_PcontextType == null)
				{
					r_PcontextType = new(this, "contextType", -1);
				}
				return r_PcontextType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ContextualMenuManager contextualMenuManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager r_PcontextualMenuManager;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RContextualMenuManager RPcontextualMenuManager
		{
			get
			{
				if(r_PcontextualMenuManager == null)
				{
					r_PcontextualMenuManager = new(this, "contextualMenuManager", -1);
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
					r_MPickAll_Vector2_List_d_VisualElement_p_ = new(this, "PickAll", 0, typeof(UnityEngine.Vector2),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
				}
				return r_MPickAll_Vector2_List_d_VisualElement_p_;
			}
		}


        public virtual UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = RMPick_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 @point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @picked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @picked};
            var ___result = RMPickAll_Vector2_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


    }
}
