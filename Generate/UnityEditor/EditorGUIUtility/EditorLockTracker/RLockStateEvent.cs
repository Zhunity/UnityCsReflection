using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class REditorGUIUtility
{
	public partial class REditorLockTracker
{
	
	/// <summary>
	/// UnityEditor.EditorGUIUtility+EditorLockTracker+LockStateEvent
	/// </summary>
    public partial class RLockStateEvent : RMember //
    {

		/// <summary>
		/// Void AddListener(UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_RAddListener_UnityAction_d_Boolean_p_;
		public virtual RMethod RAddListener_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_RAddListener_UnityAction_d_Boolean_p_ == null)
				{
					r_RAddListener_UnityAction_d_Boolean_p_ = new(this, "AddListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
					r_RAddListener_UnityAction_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_RAddListener_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// Void RemoveListener(UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_RRemoveListener_UnityAction_d_Boolean_p_;
		public virtual RMethod RRemoveListener_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_RRemoveListener_UnityAction_d_Boolean_p_ == null)
				{
					r_RRemoveListener_UnityAction_d_Boolean_p_ = new(this, "RemoveListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
					r_RRemoveListener_UnityAction_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_RRemoveListener_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod_Impl(System.String, System.Type)
		/// </summary>
		protected RMethod r_RFindMethod_Impl_String_Type;
		public virtual RMethod RFindMethod_Impl_String_Type
		{
			get
			{
				if(r_RFindMethod_Impl_String_Type == null)
				{
					r_RFindMethod_Impl_String_Type = new(this, "FindMethod_Impl", 0, typeof(System.String), typeof(System.Type));
					r_RFindMethod_Impl_String_Type.SetBelong(this.instance);
				}
				return r_RFindMethod_Impl_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RGetDelegate_Object_MethodInfo;
		public virtual RMethod RGetDelegate_Object_MethodInfo
		{
			get
			{
				if(r_RGetDelegate_Object_MethodInfo == null)
				{
					r_RGetDelegate_Object_MethodInfo = new(this, "GetDelegate", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RGetDelegate_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RGetDelegate_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void Invoke(Boolean)
		/// </summary>
		protected RMethod r_RInvoke_Boolean;
		public virtual RMethod RInvoke_Boolean
		{
			get
			{
				if(r_RInvoke_Boolean == null)
				{
					r_RInvoke_Boolean = new(this, "Invoke", 0, typeof(System.Boolean));
					r_RInvoke_Boolean.SetBelong(this.instance);
				}
				return r_RInvoke_Boolean;
			}
		}

		/// <summary>
		/// Void AddPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_RAddPersistentListener_UnityAction_d_Boolean_p_;
		public virtual RMethod RAddPersistentListener_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_RAddPersistentListener_UnityAction_d_Boolean_p_ == null)
				{
					r_RAddPersistentListener_UnityAction_d_Boolean_p_ = new(this, "AddPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
					r_RAddPersistentListener_UnityAction_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_RAddPersistentListener_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// Void AddPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean], UnityEngine.Events.UnityEventCallState)
		/// </summary>
		protected RMethod r_RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState;
		public virtual RMethod RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState
		{
			get
			{
				if(r_RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState == null)
				{
					r_RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState = new(this, "AddPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(UnityEngine.Events.UnityEventCallState));
					r_RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState.SetBelong(this.instance);
				}
				return r_RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_;
		public virtual RMethod RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_ == null)
				{
					r_RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_ = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
					r_RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod_Impl(System.String, System.Object)
		/// </summary>
		protected RMethod r_RFindMethod_Impl_String_Object;
		public virtual RMethod RFindMethod_Impl_String_Object
		{
			get
			{
				if(r_RFindMethod_Impl_String_Object == null)
				{
					r_RFindMethod_Impl_String_Object = new(this, "FindMethod_Impl", 0, typeof(System.String), typeof(System.Object));
					r_RFindMethod_Impl_String_Object.SetBelong(this.instance);
				}
				return r_RFindMethod_Impl_String_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall)
		/// </summary>
		protected RMethod r_RFindMethod_PersistentCall;
		public virtual RMethod RFindMethod_PersistentCall
		{
			get
			{
				if(r_RFindMethod_PersistentCall == null)
				{
					r_RFindMethod_PersistentCall = new(this, "FindMethod", 0,  ReleactionUtils.GetType("UnityEngine.Events.PersistentCall"));
					r_RFindMethod_PersistentCall.SetBelong(this.instance);
				}
				return r_RFindMethod_PersistentCall;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod(System.String, System.Type, UnityEngine.Events.PersistentListenerMode, System.Type)
		/// </summary>
		protected RMethod r_RFindMethod_String_Type_PersistentListenerMode_Type;
		public virtual RMethod RFindMethod_String_Type_PersistentListenerMode_Type
		{
			get
			{
				if(r_RFindMethod_String_Type_PersistentListenerMode_Type == null)
				{
					r_RFindMethod_String_Type_PersistentListenerMode_Type = new(this, "FindMethod", 0, typeof(System.String), typeof(System.Type), typeof(UnityEngine.Events.PersistentListenerMode), typeof(System.Type));
					r_RFindMethod_String_Type_PersistentListenerMode_Type.SetBelong(this.instance);
				}
				return r_RFindMethod_String_Type_PersistentListenerMode_Type;
			}
		}

		/// <summary>
		/// Int32 GetPersistentEventCount()
		/// </summary>
		protected RMethod r_RGetPersistentEventCount;
		public virtual RMethod RGetPersistentEventCount
		{
			get
			{
				if(r_RGetPersistentEventCount == null)
				{
					r_RGetPersistentEventCount = new(this, "GetPersistentEventCount", 0);
					r_RGetPersistentEventCount.SetBelong(this.instance);
				}
				return r_RGetPersistentEventCount;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetPersistentTarget(Int32)
		/// </summary>
		protected RMethod r_RGetPersistentTarget_Int32;
		public virtual RMethod RGetPersistentTarget_Int32
		{
			get
			{
				if(r_RGetPersistentTarget_Int32 == null)
				{
					r_RGetPersistentTarget_Int32 = new(this, "GetPersistentTarget", 0, typeof(System.Int32));
					r_RGetPersistentTarget_Int32.SetBelong(this.instance);
				}
				return r_RGetPersistentTarget_Int32;
			}
		}

		/// <summary>
		/// System.String GetPersistentMethodName(Int32)
		/// </summary>
		protected RMethod r_RGetPersistentMethodName_Int32;
		public virtual RMethod RGetPersistentMethodName_Int32
		{
			get
			{
				if(r_RGetPersistentMethodName_Int32 == null)
				{
					r_RGetPersistentMethodName_Int32 = new(this, "GetPersistentMethodName", 0, typeof(System.Int32));
					r_RGetPersistentMethodName_Int32.SetBelong(this.instance);
				}
				return r_RGetPersistentMethodName_Int32;
			}
		}

		/// <summary>
		/// Void SetPersistentListenerState(Int32, UnityEngine.Events.UnityEventCallState)
		/// </summary>
		protected RMethod r_RSetPersistentListenerState_Int32_UnityEventCallState;
		public virtual RMethod RSetPersistentListenerState_Int32_UnityEventCallState
		{
			get
			{
				if(r_RSetPersistentListenerState_Int32_UnityEventCallState == null)
				{
					r_RSetPersistentListenerState_Int32_UnityEventCallState = new(this, "SetPersistentListenerState", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityEventCallState));
					r_RSetPersistentListenerState_Int32_UnityEventCallState.SetBelong(this.instance);
				}
				return r_RSetPersistentListenerState_Int32_UnityEventCallState;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState GetPersistentListenerState(Int32)
		/// </summary>
		protected RMethod r_RGetPersistentListenerState_Int32;
		public virtual RMethod RGetPersistentListenerState_Int32
		{
			get
			{
				if(r_RGetPersistentListenerState_Int32 == null)
				{
					r_RGetPersistentListenerState_Int32 = new(this, "GetPersistentListenerState", 0, typeof(System.Int32));
					r_RGetPersistentListenerState_Int32.SetBelong(this.instance);
				}
				return r_RGetPersistentListenerState_Int32;
			}
		}

		/// <summary>
		/// Void AddListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RAddListener_Object_MethodInfo;
		public virtual RMethod RAddListener_Object_MethodInfo
		{
			get
			{
				if(r_RAddListener_Object_MethodInfo == null)
				{
					r_RAddListener_Object_MethodInfo = new(this, "AddListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RAddListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RAddListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void AddCall(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_RAddCall_BaseInvokableCall;
		public virtual RMethod RAddCall_BaseInvokableCall
		{
			get
			{
				if(r_RAddCall_BaseInvokableCall == null)
				{
					r_RAddCall_BaseInvokableCall = new(this, "AddCall", 0,  ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
					r_RAddCall_BaseInvokableCall.SetBelong(this.instance);
				}
				return r_RAddCall_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RRemoveListener_Object_MethodInfo;
		public virtual RMethod RRemoveListener_Object_MethodInfo
		{
			get
			{
				if(r_RRemoveListener_Object_MethodInfo == null)
				{
					r_RRemoveListener_Object_MethodInfo = new(this, "RemoveListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RRemoveListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RRemoveListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemoveAllListeners()
		/// </summary>
		protected RMethod r_RRemoveAllListeners;
		public virtual RMethod RRemoveAllListeners
		{
			get
			{
				if(r_RRemoveAllListeners == null)
				{
					r_RRemoveAllListeners = new(this, "RemoveAllListeners", 0);
					r_RRemoveAllListeners.SetBelong(this.instance);
				}
				return r_RRemoveAllListeners;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] PrepareInvoke()
		/// </summary>
		protected RMethod r_RPrepareInvoke;
		public virtual RMethod RPrepareInvoke
		{
			get
			{
				if(r_RPrepareInvoke == null)
				{
					r_RPrepareInvoke = new(this, "PrepareInvoke", 0);
					r_RPrepareInvoke.SetBelong(this.instance);
				}
				return r_RPrepareInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.Object[])
		/// </summary>
		protected RMethod r_RInvoke_ObjectArray;
		public virtual RMethod RInvoke_ObjectArray
		{
			get
			{
				if(r_RInvoke_ObjectArray == null)
				{
					r_RInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
					r_RInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_RInvoke_ObjectArray;
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

		/// <summary>
		/// Boolean ValidateRegistration(System.Reflection.MethodInfo, System.Object, UnityEngine.Events.PersistentListenerMode)
		/// </summary>
		protected RMethod r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode;
		public virtual RMethod RValidateRegistration_MethodInfo_Object_PersistentListenerMode
		{
			get
			{
				if(r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode == null)
				{
					r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode = new(this, "ValidateRegistration", 0, typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(UnityEngine.Events.PersistentListenerMode));
					r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode.SetBelong(this.instance);
				}
				return r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode;
			}
		}

		/// <summary>
		/// Boolean ValidateRegistration(System.Reflection.MethodInfo, System.Object, UnityEngine.Events.PersistentListenerMode, System.Type)
		/// </summary>
		protected RMethod r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type;
		public virtual RMethod RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type
		{
			get
			{
				if(r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type == null)
				{
					r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type = new(this, "ValidateRegistration", 0, typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(UnityEngine.Events.PersistentListenerMode), typeof(System.Type));
					r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type.SetBelong(this.instance);
				}
				return r_RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type;
			}
		}

		/// <summary>
		/// Void AddPersistentListener()
		/// </summary>
		protected RMethod r_RAddPersistentListener;
		public virtual RMethod RAddPersistentListener
		{
			get
			{
				if(r_RAddPersistentListener == null)
				{
					r_RAddPersistentListener = new(this, "AddPersistentListener", 0);
					r_RAddPersistentListener.SetBelong(this.instance);
				}
				return r_RAddPersistentListener;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RRegisterPersistentListener_Int32_Object_MethodInfo;
		public virtual RMethod RRegisterPersistentListener_Int32_Object_MethodInfo
		{
			get
			{
				if(r_RRegisterPersistentListener_Int32_Object_MethodInfo == null)
				{
					r_RRegisterPersistentListener_Int32_Object_MethodInfo = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RRegisterPersistentListener_Int32_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RRegisterPersistentListener_Int32_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, System.Object, System.Type, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RRegisterPersistentListener_Int32_Object_Type_MethodInfo;
		public virtual RMethod RRegisterPersistentListener_Int32_Object_Type_MethodInfo
		{
			get
			{
				if(r_RRegisterPersistentListener_Int32_Object_Type_MethodInfo == null)
				{
					r_RRegisterPersistentListener_Int32_Object_Type_MethodInfo = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Type), typeof(System.Reflection.MethodInfo));
					r_RRegisterPersistentListener_Int32_Object_Type_MethodInfo.SetBelong(this.instance);
				}
				return r_RRegisterPersistentListener_Int32_Object_Type_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemovePersistentListener(UnityEngine.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RRemovePersistentListener_Object_MethodInfo;
		public virtual RMethod RRemovePersistentListener_Object_MethodInfo
		{
			get
			{
				if(r_RRemovePersistentListener_Object_MethodInfo == null)
				{
					r_RRemovePersistentListener_Object_MethodInfo = new(this, "RemovePersistentListener", 0, typeof(UnityEngine.Object), typeof(System.Reflection.MethodInfo));
					r_RRemovePersistentListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RRemovePersistentListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemovePersistentListener(Int32)
		/// </summary>
		protected RMethod r_RRemovePersistentListener_Int32;
		public virtual RMethod RRemovePersistentListener_Int32
		{
			get
			{
				if(r_RRemovePersistentListener_Int32 == null)
				{
					r_RRemovePersistentListener_Int32 = new(this, "RemovePersistentListener", 0, typeof(System.Int32));
					r_RRemovePersistentListener_Int32.SetBelong(this.instance);
				}
				return r_RRemovePersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener(Int32)
		/// </summary>
		protected RMethod r_RUnregisterPersistentListener_Int32;
		public virtual RMethod RUnregisterPersistentListener_Int32
		{
			get
			{
				if(r_RUnregisterPersistentListener_Int32 == null)
				{
					r_RUnregisterPersistentListener_Int32 = new(this, "UnregisterPersistentListener", 0, typeof(System.Int32));
					r_RUnregisterPersistentListener_Int32.SetBelong(this.instance);
				}
				return r_RUnregisterPersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void AddVoidPersistentListener(UnityEngine.Events.UnityAction)
		/// </summary>
		protected RMethod r_RAddVoidPersistentListener_UnityAction;
		public virtual RMethod RAddVoidPersistentListener_UnityAction
		{
			get
			{
				if(r_RAddVoidPersistentListener_UnityAction == null)
				{
					r_RAddVoidPersistentListener_UnityAction = new(this, "AddVoidPersistentListener", 0, typeof(UnityEngine.Events.UnityAction));
					r_RAddVoidPersistentListener_UnityAction.SetBelong(this.instance);
				}
				return r_RAddVoidPersistentListener_UnityAction;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListener(Int32, UnityEngine.Events.UnityAction)
		/// </summary>
		protected RMethod r_RRegisterVoidPersistentListener_Int32_UnityAction;
		public virtual RMethod RRegisterVoidPersistentListener_Int32_UnityAction
		{
			get
			{
				if(r_RRegisterVoidPersistentListener_Int32_UnityAction == null)
				{
					r_RRegisterVoidPersistentListener_Int32_UnityAction = new(this, "RegisterVoidPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction));
					r_RRegisterVoidPersistentListener_Int32_UnityAction.SetBelong(this.instance);
				}
				return r_RRegisterVoidPersistentListener_Int32_UnityAction;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListenerWithoutValidation(Int32, UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String;
		public virtual RMethod RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String
		{
			get
			{
				if(r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String == null)
				{
					r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String = new(this, "RegisterVoidPersistentListenerWithoutValidation", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.String));
					r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String.SetBelong(this.instance);
				}
				return r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListenerWithoutValidation(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String;
		public virtual RMethod RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String
		{
			get
			{
				if(r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String == null)
				{
					r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String = new(this, "RegisterVoidPersistentListenerWithoutValidation", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
					r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String.SetBelong(this.instance);
				}
				return r_RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void AddIntPersistentListener(UnityEngine.Events.UnityAction`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_RAddIntPersistentListener_UnityAction_d_Int32_p__Int32;
		public virtual RMethod RAddIntPersistentListener_UnityAction_d_Int32_p__Int32
		{
			get
			{
				if(r_RAddIntPersistentListener_UnityAction_d_Int32_p__Int32 == null)
				{
					r_RAddIntPersistentListener_UnityAction_d_Int32_p__Int32 = new(this, "AddIntPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_RAddIntPersistentListener_UnityAction_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_RAddIntPersistentListener_UnityAction_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void RegisterIntPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32;
		public virtual RMethod RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32
		{
			get
			{
				if(r_RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32 == null)
				{
					r_RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32 = new(this, "RegisterIntPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void AddFloatPersistentListener(UnityEngine.Events.UnityAction`1[System.Single], Single)
		/// </summary>
		protected RMethod r_RAddFloatPersistentListener_UnityAction_d_Single_p__Single;
		public virtual RMethod RAddFloatPersistentListener_UnityAction_d_Single_p__Single
		{
			get
			{
				if(r_RAddFloatPersistentListener_UnityAction_d_Single_p__Single == null)
				{
					r_RAddFloatPersistentListener_UnityAction_d_Single_p__Single = new(this, "AddFloatPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Single)), typeof(System.Single));
					r_RAddFloatPersistentListener_UnityAction_d_Single_p__Single.SetBelong(this.instance);
				}
				return r_RAddFloatPersistentListener_UnityAction_d_Single_p__Single;
			}
		}

		/// <summary>
		/// Void RegisterFloatPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Single], Single)
		/// </summary>
		protected RMethod r_RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single;
		public virtual RMethod RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single
		{
			get
			{
				if(r_RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single == null)
				{
					r_RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single = new(this, "RegisterFloatPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Single)), typeof(System.Single));
					r_RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single.SetBelong(this.instance);
				}
				return r_RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single;
			}
		}

		/// <summary>
		/// Void AddBoolPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean], Boolean)
		/// </summary>
		protected RMethod r_RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean;
		public virtual RMethod RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean
		{
			get
			{
				if(r_RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean == null)
				{
					r_RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean = new(this, "AddBoolPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean));
					r_RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean.SetBelong(this.instance);
				}
				return r_RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean;
			}
		}

		/// <summary>
		/// Void RegisterBoolPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Boolean], Boolean)
		/// </summary>
		protected RMethod r_RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean;
		public virtual RMethod RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean
		{
			get
			{
				if(r_RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean == null)
				{
					r_RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean = new(this, "RegisterBoolPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean));
					r_RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean.SetBelong(this.instance);
				}
				return r_RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean;
			}
		}

		/// <summary>
		/// Void AddStringPersistentListener(UnityEngine.Events.UnityAction`1[System.String], System.String)
		/// </summary>
		protected RMethod r_RAddStringPersistentListener_UnityAction_d_String_p__String;
		public virtual RMethod RAddStringPersistentListener_UnityAction_d_String_p__String
		{
			get
			{
				if(r_RAddStringPersistentListener_UnityAction_d_String_p__String == null)
				{
					r_RAddStringPersistentListener_UnityAction_d_String_p__String = new(this, "AddStringPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.String)), typeof(System.String));
					r_RAddStringPersistentListener_UnityAction_d_String_p__String.SetBelong(this.instance);
				}
				return r_RAddStringPersistentListener_UnityAction_d_String_p__String;
			}
		}

		/// <summary>
		/// Void RegisterStringPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.String], System.String)
		/// </summary>
		protected RMethod r_RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String;
		public virtual RMethod RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String
		{
			get
			{
				if(r_RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String == null)
				{
					r_RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String = new(this, "RegisterStringPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.String)), typeof(System.String));
					r_RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String.SetBelong(this.instance);
				}
				return r_RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String;
			}
		}

		/// <summary>
		/// Void AddObjectPersistentListener[T](UnityEngine.Events.UnityAction`1[T], T)
		/// </summary>
		protected RMethod r_RAddObjectPersistentListener_GT_UnityAction_d_T_p__T;
		public virtual RMethod RAddObjectPersistentListener_GT_UnityAction_d_T_p__T
		{
			get
			{
				if(r_RAddObjectPersistentListener_GT_UnityAction_d_T_p__T == null)
				{
					r_RAddObjectPersistentListener_GT_UnityAction_d_T_p__T = new(this, "AddObjectPersistentListener", 1, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_RAddObjectPersistentListener_GT_UnityAction_d_T_p__T.SetBelong(this.instance);
				}
				return r_RAddObjectPersistentListener_GT_UnityAction_d_T_p__T;
			}
		}

		/// <summary>
		/// Void RegisterObjectPersistentListener[T](Int32, UnityEngine.Events.UnityAction`1[T], T)
		/// </summary>
		protected RMethod r_RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T;
		public virtual RMethod RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T
		{
			get
			{
				if(r_RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T == null)
				{
					r_RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T = new(this, "RegisterObjectPersistentListener", 1, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T.SetBelong(this.instance);
				}
				return r_RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T;
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


        public RLockStateEvent() : base("UnityEditor.EditorGUIUtility+EditorLockTracker+LockStateEvent")
        {
        }

        public RLockStateEvent(System.Object instance) : base("UnityEditor.EditorGUIUtility+EditorLockTracker+LockStateEvent")
		{
            SetInstance(instance);
		}

        public RLockStateEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLockStateEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddListener(UnityEngine.Events.UnityAction<System.Boolean>  @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RAddListener_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListener(UnityEngine.Events.UnityAction<System.Boolean>  @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RRemoveListener_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo FindMethod_Impl(System.String  @name, System.Type  @targetObjType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @targetObjType};
            var ___result = RFindMethod_Impl_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetDelegate(System.Object  @target, System.Reflection.MethodInfo  @theFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @theFunction};
            var ___result = RGetDelegate_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Invoke(System.Boolean  @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0};
            var ___result = RInvoke_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPersistentListener(UnityEngine.Events.UnityAction<System.Boolean>  @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RAddPersistentListener_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPersistentListener(UnityEngine.Events.UnityAction<System.Boolean>  @call, UnityEngine.Events.UnityEventCallState  @callState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @callState};
            var ___result = RAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32  @index, UnityEngine.Events.UnityAction<System.Boolean>  @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call};
            var ___result = RRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo FindMethod_Impl(System.String  @name, System.Object  @targetObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @targetObj};
            var ___result = RFindMethod_Impl_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }



        public virtual System.Reflection.MethodInfo FindMethod(System.String  @name, System.Type  @listenerType, UnityEngine.Events.PersistentListenerMode  @mode, System.Type  @argumentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @listenerType, @mode, @argumentType};
            var ___result = RFindMethod_String_Type_PersistentListenerMode_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Int32 GetPersistentEventCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPersistentEventCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Object GetPersistentTarget(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetPersistentTarget_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String GetPersistentMethodName(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetPersistentMethodName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetPersistentListenerState(System.Int32  @index, UnityEngine.Events.UnityEventCallState  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @state};
            var ___result = RSetPersistentListenerState_Int32_UnityEventCallState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Events.UnityEventCallState GetPersistentListenerState(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetPersistentListenerState_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Events.UnityEventCallState)___result;
        }


        public virtual void AddListener(System.Object  @targetObj, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RAddListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void RemoveListener(System.Object  @targetObj, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RRemoveListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAllListeners()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveAllListeners.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object PrepareInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareInvoke.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Invoke(System.Object[]  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ValidateRegistration(System.Reflection.MethodInfo  @method, System.Object  @targetObj, UnityEngine.Events.PersistentListenerMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @targetObj, @mode};
            var ___result = RValidateRegistration_MethodInfo_Object_PersistentListenerMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateRegistration(System.Reflection.MethodInfo  @method, System.Object  @targetObj, UnityEngine.Events.PersistentListenerMode  @mode, System.Type  @argumentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @targetObj, @mode, @argumentType};
            var ___result = RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddPersistentListener()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddPersistentListener.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32  @index, System.Object  @targetObj, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @method};
            var ___result = RRegisterPersistentListener_Int32_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32  @index, System.Object  @targetObj, System.Type  @targetObjType, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @method};
            var ___result = RRegisterPersistentListener_Int32_Object_Type_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePersistentListener(UnityEngine.Object  @target, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @method};
            var ___result = RRemovePersistentListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePersistentListener(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemovePersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RUnregisterPersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVoidPersistentListener(UnityEngine.Events.UnityAction  @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RAddVoidPersistentListener_UnityAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListener(System.Int32  @index, UnityEngine.Events.UnityAction  @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call};
            var ___result = RRegisterVoidPersistentListener_Int32_UnityAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListenerWithoutValidation(System.Int32  @index, UnityEngine.Object  @target, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @target, @methodName};
            var ___result = RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListenerWithoutValidation(System.Int32  @index, UnityEngine.Object  @target, System.Type  @targetType, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @target, @targetType, @methodName};
            var ___result = RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddIntPersistentListener(UnityEngine.Events.UnityAction<System.Int32>  @call, System.Int32  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddIntPersistentListener_UnityAction_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterIntPersistentListener(System.Int32  @index, UnityEngine.Events.UnityAction<System.Int32>  @call, System.Int32  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFloatPersistentListener(UnityEngine.Events.UnityAction<System.Single>  @call, System.Single  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddFloatPersistentListener_UnityAction_d_Single_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterFloatPersistentListener(System.Int32  @index, UnityEngine.Events.UnityAction<System.Single>  @call, System.Single  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBoolPersistentListener(UnityEngine.Events.UnityAction<System.Boolean>  @call, System.Boolean  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterBoolPersistentListener(System.Int32  @index, UnityEngine.Events.UnityAction<System.Boolean>  @call, System.Boolean  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddStringPersistentListener(UnityEngine.Events.UnityAction<System.String>  @call, System.String  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddStringPersistentListener_UnityAction_d_String_p__String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterStringPersistentListener(System.Int32  @index, UnityEngine.Events.UnityAction<System.String>  @call, System.String  @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddObjectPersistentListener<T>(UnityEngine.Events.UnityAction<T>  @call, T  @argument) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddObjectPersistentListener_GT_UnityAction_d_T_p__T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterObjectPersistentListener<T>(System.Int32  @index, UnityEngine.Events.UnityAction<T>  @call, T  @argument) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T.Invoke(___genericsType, ___parameters);

            
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


    }
}
}}