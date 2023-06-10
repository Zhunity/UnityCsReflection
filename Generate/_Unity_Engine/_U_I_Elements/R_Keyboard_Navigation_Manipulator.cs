
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.KeyboardNavigationManipulator
	/// </summary>
    public partial class RKeyboardNavigationManipulator : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.KeyboardNavigationManipulator);
            }
        }

        public RKeyboardNavigationManipulator() : base("UnityEngine.UIElements.KeyboardNavigationManipulator")
        {
        }

        public RKeyboardNavigationManipulator(System.Object instance) : base("UnityEngine.UIElements.KeyboardNavigationManipulator")
		{
            SetInstance(instance);
		}

        public RKeyboardNavigationManipulator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyboardNavigationManipulator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase] m_Action
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase> r_Fm_Action;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationOperation, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase> RFm_Action
		{
			get
			{
				if(r_Fm_Action == null)
				{
					r_Fm_Action = new(this, "m_Action");
				}
				return r_Fm_Action;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// Void RegisterCallbacksOnTarget()
		/// </summary>
		protected RMethod r_MRegisterCallbacksOnTarget;
		public virtual RMethod RMRegisterCallbacksOnTarget
		{
			get
			{
				if(r_MRegisterCallbacksOnTarget == null)
				{
					r_MRegisterCallbacksOnTarget = new(this, "RegisterCallbacksOnTarget", 0);
				}
				return r_MRegisterCallbacksOnTarget;
			}
		}

		/// <summary>
		/// Void UnregisterCallbacksFromTarget()
		/// </summary>
		protected RMethod r_MUnregisterCallbacksFromTarget;
		public virtual RMethod RMUnregisterCallbacksFromTarget
		{
			get
			{
				if(r_MUnregisterCallbacksFromTarget == null)
				{
					r_MUnregisterCallbacksFromTarget = new(this, "UnregisterCallbacksFromTarget", 0);
				}
				return r_MUnregisterCallbacksFromTarget;
			}
		}

		/// <summary>
		/// Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent)
		/// </summary>
		protected RMethod r_MOnKeyDown_KeyDownEvent;
		public virtual RMethod RMOnKeyDown_KeyDownEvent
		{
			get
			{
				if(r_MOnKeyDown_KeyDownEvent == null)
				{
					r_MOnKeyDown_KeyDownEvent = new(this, "OnKeyDown", 0, typeof(UnityEngine.UIElements.KeyDownEvent));
				}
				return r_MOnKeyDown_KeyDownEvent;
			}
		}

		/// <summary>
		/// Void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent)
		/// </summary>
		protected RMethod r_MOnNavigationCancel_NavigationCancelEvent;
		public virtual RMethod RMOnNavigationCancel_NavigationCancelEvent
		{
			get
			{
				if(r_MOnNavigationCancel_NavigationCancelEvent == null)
				{
					r_MOnNavigationCancel_NavigationCancelEvent = new(this, "OnNavigationCancel", 0, typeof(UnityEngine.UIElements.NavigationCancelEvent));
				}
				return r_MOnNavigationCancel_NavigationCancelEvent;
			}
		}

		/// <summary>
		/// Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent)
		/// </summary>
		protected RMethod r_MOnNavigationSubmit_NavigationSubmitEvent;
		public virtual RMethod RMOnNavigationSubmit_NavigationSubmitEvent
		{
			get
			{
				if(r_MOnNavigationSubmit_NavigationSubmitEvent == null)
				{
					r_MOnNavigationSubmit_NavigationSubmitEvent = new(this, "OnNavigationSubmit", 0, typeof(UnityEngine.UIElements.NavigationSubmitEvent));
				}
				return r_MOnNavigationSubmit_NavigationSubmitEvent;
			}
		}

		/// <summary>
		/// Void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent)
		/// </summary>
		protected RMethod r_MOnNavigationMove_NavigationMoveEvent;
		public virtual RMethod RMOnNavigationMove_NavigationMoveEvent
		{
			get
			{
				if(r_MOnNavigationMove_NavigationMoveEvent == null)
				{
					r_MOnNavigationMove_NavigationMoveEvent = new(this, "OnNavigationMove", 0, typeof(UnityEngine.UIElements.NavigationMoveEvent));
				}
				return r_MOnNavigationMove_NavigationMoveEvent;
			}
		}

		/// <summary>
		/// Void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation, UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MInvoke_KeyboardNavigationOperation_EventBase;
		public virtual RMethod RMInvoke_KeyboardNavigationOperation_EventBase
		{
			get
			{
				if(r_MInvoke_KeyboardNavigationOperation_EventBase == null)
				{
					r_MInvoke_KeyboardNavigationOperation_EventBase = new(this, "Invoke", 0, typeof(UnityEngine.UIElements.KeyboardNavigationOperation), typeof(UnityEngine.UIElements.EventBase));
				}
				return r_MInvoke_KeyboardNavigationOperation_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(<>c__DisplayClass4_0 ByRef)
		/// </summary>
		protected static RMethod r_M__0__OnKeyDown__1__g__GetOperation__5__4_0_Ref___0____1__c__DisplayClass4_0;
		public static RMethod RM__0__OnKeyDown__1__g__GetOperation__5__4_0_Ref___0____1__c__DisplayClass4_0
		{
			get
			{
				if(r_M__0__OnKeyDown__1__g__GetOperation__5__4_0_Ref___0____1__c__DisplayClass4_0 == null)
				{
					r_M__0__OnKeyDown__1__g__GetOperation__5__4_0_Ref___0____1__c__DisplayClass4_0 = new(typeof(UnityEngine.UIElements.KeyboardNavigationManipulator), "<OnKeyDown>g__GetOperation|4_0", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.KeyboardNavigationManipulator+<>c__DisplayClass4_0").MakeByRefType());
				}
				return r_M__0__OnKeyDown__1__g__GetOperation__5__4_0_Ref___0____1__c__DisplayClass4_0;
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


        public virtual void RegisterCallbacksOnTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegisterCallbacksOnTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallbacksFromTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregisterCallbacksFromTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnKeyDown(UnityEngine.UIElements.KeyDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnKeyDown_KeyDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnNavigationCancel_NavigationCancelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnNavigationSubmit_NavigationSubmitEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnNavigationMove_NavigationMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation @operation, UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation, @evt};
            var ___result = RMInvoke_KeyboardNavigationOperation_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.KeyboardNavigationOperation __0__OnKeyDown__1__g__GetOperation__5__4_0(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationManipulator.R__0____1__c__DisplayClass4_0 @_______)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_______.Value};
            var ___result = RM__0__OnKeyDown__1__g__GetOperation__5__4_0_Ref___0____1__c__DisplayClass4_0.Invoke(___genericsType, ___parameters);
			@_______ = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RKeyboardNavigationManipulator.R__0____1__c__DisplayClass4_0(___parameters[0]);

            return (UnityEngine.UIElements.KeyboardNavigationOperation)___result;
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
