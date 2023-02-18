
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
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
		protected RMethod r_MAddListener_UnityAction_d_Boolean_p_;
		public virtual RMethod RMAddListener_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_MAddListener_UnityAction_d_Boolean_p_ == null)
				{
					r_MAddListener_UnityAction_d_Boolean_p_ = new(this, "AddListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
				}
				return r_MAddListener_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// Void RemoveListener(UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_MRemoveListener_UnityAction_d_Boolean_p_;
		public virtual RMethod RMRemoveListener_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_MRemoveListener_UnityAction_d_Boolean_p_ == null)
				{
					r_MRemoveListener_UnityAction_d_Boolean_p_ = new(this, "RemoveListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
				}
				return r_MRemoveListener_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod_Impl(System.String, System.Type)
		/// </summary>
		protected RMethod r_MFindMethod_Impl_String_Type;
		public virtual RMethod RMFindMethod_Impl_String_Type
		{
			get
			{
				if(r_MFindMethod_Impl_String_Type == null)
				{
					r_MFindMethod_Impl_String_Type = new(this, "FindMethod_Impl", 0, typeof(System.String), typeof(System.Type));
				}
				return r_MFindMethod_Impl_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MGetDelegate_Object_MethodInfo;
		public virtual RMethod RMGetDelegate_Object_MethodInfo
		{
			get
			{
				if(r_MGetDelegate_Object_MethodInfo == null)
				{
					r_MGetDelegate_Object_MethodInfo = new(this, "GetDelegate", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MGetDelegate_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void Invoke(Boolean)
		/// </summary>
		protected RMethod r_MInvoke_Boolean;
		public virtual RMethod RMInvoke_Boolean
		{
			get
			{
				if(r_MInvoke_Boolean == null)
				{
					r_MInvoke_Boolean = new(this, "Invoke", 0, typeof(System.Boolean));
				}
				return r_MInvoke_Boolean;
			}
		}

		/// <summary>
		/// Void AddPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_MAddPersistentListener_UnityAction_d_Boolean_p_;
		public virtual RMethod RMAddPersistentListener_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_MAddPersistentListener_UnityAction_d_Boolean_p_ == null)
				{
					r_MAddPersistentListener_UnityAction_d_Boolean_p_ = new(this, "AddPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
				}
				return r_MAddPersistentListener_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// Void AddPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean], UnityEngine.Events.UnityEventCallState)
		/// </summary>
		protected RMethod r_MAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState;
		public virtual RMethod RMAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState
		{
			get
			{
				if(r_MAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState == null)
				{
					r_MAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState = new(this, "AddPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(UnityEngine.Events.UnityEventCallState));
				}
				return r_MAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Boolean])
		/// </summary>
		protected RMethod r_MRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_;
		public virtual RMethod RMRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_
		{
			get
			{
				if(r_MRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_ == null)
				{
					r_MRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_ = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)));
				}
				return r_MRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod_Impl(System.String, System.Object)
		/// </summary>
		protected RMethod r_MFindMethod_Impl_String_Object;
		public virtual RMethod RMFindMethod_Impl_String_Object
		{
			get
			{
				if(r_MFindMethod_Impl_String_Object == null)
				{
					r_MFindMethod_Impl_String_Object = new(this, "FindMethod_Impl", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MFindMethod_Impl_String_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall)
		/// </summary>
		protected RMethod r_MFindMethod_PersistentCall;
		public virtual RMethod RMFindMethod_PersistentCall
		{
			get
			{
				if(r_MFindMethod_PersistentCall == null)
				{
					r_MFindMethod_PersistentCall = new(this, "FindMethod", 0,  ReflectionUtils.GetType("UnityEngine.Events.PersistentCall"));
				}
				return r_MFindMethod_PersistentCall;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod(System.String, System.Type, UnityEngine.Events.PersistentListenerMode, System.Type)
		/// </summary>
		protected RMethod r_MFindMethod_String_Type_PersistentListenerMode_Type;
		public virtual RMethod RMFindMethod_String_Type_PersistentListenerMode_Type
		{
			get
			{
				if(r_MFindMethod_String_Type_PersistentListenerMode_Type == null)
				{
					r_MFindMethod_String_Type_PersistentListenerMode_Type = new(this, "FindMethod", 0, typeof(System.String), typeof(System.Type), typeof(UnityEngine.Events.PersistentListenerMode), typeof(System.Type));
				}
				return r_MFindMethod_String_Type_PersistentListenerMode_Type;
			}
		}

		/// <summary>
		/// Int32 GetPersistentEventCount()
		/// </summary>
		protected RMethod r_MGetPersistentEventCount;
		public virtual RMethod RMGetPersistentEventCount
		{
			get
			{
				if(r_MGetPersistentEventCount == null)
				{
					r_MGetPersistentEventCount = new(this, "GetPersistentEventCount", 0);
				}
				return r_MGetPersistentEventCount;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetPersistentTarget(Int32)
		/// </summary>
		protected RMethod r_MGetPersistentTarget_Int32;
		public virtual RMethod RMGetPersistentTarget_Int32
		{
			get
			{
				if(r_MGetPersistentTarget_Int32 == null)
				{
					r_MGetPersistentTarget_Int32 = new(this, "GetPersistentTarget", 0, typeof(System.Int32));
				}
				return r_MGetPersistentTarget_Int32;
			}
		}

		/// <summary>
		/// System.String GetPersistentMethodName(Int32)
		/// </summary>
		protected RMethod r_MGetPersistentMethodName_Int32;
		public virtual RMethod RMGetPersistentMethodName_Int32
		{
			get
			{
				if(r_MGetPersistentMethodName_Int32 == null)
				{
					r_MGetPersistentMethodName_Int32 = new(this, "GetPersistentMethodName", 0, typeof(System.Int32));
				}
				return r_MGetPersistentMethodName_Int32;
			}
		}

		/// <summary>
		/// Void SetPersistentListenerState(Int32, UnityEngine.Events.UnityEventCallState)
		/// </summary>
		protected RMethod r_MSetPersistentListenerState_Int32_UnityEventCallState;
		public virtual RMethod RMSetPersistentListenerState_Int32_UnityEventCallState
		{
			get
			{
				if(r_MSetPersistentListenerState_Int32_UnityEventCallState == null)
				{
					r_MSetPersistentListenerState_Int32_UnityEventCallState = new(this, "SetPersistentListenerState", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityEventCallState));
				}
				return r_MSetPersistentListenerState_Int32_UnityEventCallState;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState GetPersistentListenerState(Int32)
		/// </summary>
		protected RMethod r_MGetPersistentListenerState_Int32;
		public virtual RMethod RMGetPersistentListenerState_Int32
		{
			get
			{
				if(r_MGetPersistentListenerState_Int32 == null)
				{
					r_MGetPersistentListenerState_Int32 = new(this, "GetPersistentListenerState", 0, typeof(System.Int32));
				}
				return r_MGetPersistentListenerState_Int32;
			}
		}

		/// <summary>
		/// Void AddListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MAddListener_Object_MethodInfo;
		public virtual RMethod RMAddListener_Object_MethodInfo
		{
			get
			{
				if(r_MAddListener_Object_MethodInfo == null)
				{
					r_MAddListener_Object_MethodInfo = new(this, "AddListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MAddListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void AddCall(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_MAddCall_BaseInvokableCall;
		public virtual RMethod RMAddCall_BaseInvokableCall
		{
			get
			{
				if(r_MAddCall_BaseInvokableCall == null)
				{
					r_MAddCall_BaseInvokableCall = new(this, "AddCall", 0,  ReflectionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
				}
				return r_MAddCall_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MRemoveListener_Object_MethodInfo;
		public virtual RMethod RMRemoveListener_Object_MethodInfo
		{
			get
			{
				if(r_MRemoveListener_Object_MethodInfo == null)
				{
					r_MRemoveListener_Object_MethodInfo = new(this, "RemoveListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MRemoveListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemoveAllListeners()
		/// </summary>
		protected RMethod r_MRemoveAllListeners;
		public virtual RMethod RMRemoveAllListeners
		{
			get
			{
				if(r_MRemoveAllListeners == null)
				{
					r_MRemoveAllListeners = new(this, "RemoveAllListeners", 0);
				}
				return r_MRemoveAllListeners;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] PrepareInvoke()
		/// </summary>
		protected RMethod r_MPrepareInvoke;
		public virtual RMethod RMPrepareInvoke
		{
			get
			{
				if(r_MPrepareInvoke == null)
				{
					r_MPrepareInvoke = new(this, "PrepareInvoke", 0);
				}
				return r_MPrepareInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.Object[])
		/// </summary>
		protected RMethod r_MInvoke_ObjectArray;
		public virtual RMethod RMInvoke_ObjectArray
		{
			get
			{
				if(r_MInvoke_ObjectArray == null)
				{
					r_MInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
				}
				return r_MInvoke_ObjectArray;
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

		/// <summary>
		/// Boolean ValidateRegistration(System.Reflection.MethodInfo, System.Object, UnityEngine.Events.PersistentListenerMode)
		/// </summary>
		protected RMethod r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode;
		public virtual RMethod RMValidateRegistration_MethodInfo_Object_PersistentListenerMode
		{
			get
			{
				if(r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode == null)
				{
					r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode = new(this, "ValidateRegistration", 0, typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(UnityEngine.Events.PersistentListenerMode));
				}
				return r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode;
			}
		}

		/// <summary>
		/// Boolean ValidateRegistration(System.Reflection.MethodInfo, System.Object, UnityEngine.Events.PersistentListenerMode, System.Type)
		/// </summary>
		protected RMethod r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type;
		public virtual RMethod RMValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type
		{
			get
			{
				if(r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type == null)
				{
					r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type = new(this, "ValidateRegistration", 0, typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(UnityEngine.Events.PersistentListenerMode), typeof(System.Type));
				}
				return r_MValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type;
			}
		}

		/// <summary>
		/// Void AddPersistentListener()
		/// </summary>
		protected RMethod r_MAddPersistentListener;
		public virtual RMethod RMAddPersistentListener
		{
			get
			{
				if(r_MAddPersistentListener == null)
				{
					r_MAddPersistentListener = new(this, "AddPersistentListener", 0);
				}
				return r_MAddPersistentListener;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MRegisterPersistentListener_Int32_Object_MethodInfo;
		public virtual RMethod RMRegisterPersistentListener_Int32_Object_MethodInfo
		{
			get
			{
				if(r_MRegisterPersistentListener_Int32_Object_MethodInfo == null)
				{
					r_MRegisterPersistentListener_Int32_Object_MethodInfo = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MRegisterPersistentListener_Int32_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, System.Object, System.Type, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MRegisterPersistentListener_Int32_Object_Type_MethodInfo;
		public virtual RMethod RMRegisterPersistentListener_Int32_Object_Type_MethodInfo
		{
			get
			{
				if(r_MRegisterPersistentListener_Int32_Object_Type_MethodInfo == null)
				{
					r_MRegisterPersistentListener_Int32_Object_Type_MethodInfo = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Type), typeof(System.Reflection.MethodInfo));
				}
				return r_MRegisterPersistentListener_Int32_Object_Type_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemovePersistentListener(UnityEngine.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MRemovePersistentListener_Object_MethodInfo;
		public virtual RMethod RMRemovePersistentListener_Object_MethodInfo
		{
			get
			{
				if(r_MRemovePersistentListener_Object_MethodInfo == null)
				{
					r_MRemovePersistentListener_Object_MethodInfo = new(this, "RemovePersistentListener", 0, typeof(UnityEngine.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MRemovePersistentListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemovePersistentListener(Int32)
		/// </summary>
		protected RMethod r_MRemovePersistentListener_Int32;
		public virtual RMethod RMRemovePersistentListener_Int32
		{
			get
			{
				if(r_MRemovePersistentListener_Int32 == null)
				{
					r_MRemovePersistentListener_Int32 = new(this, "RemovePersistentListener", 0, typeof(System.Int32));
				}
				return r_MRemovePersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener(Int32)
		/// </summary>
		protected RMethod r_MUnregisterPersistentListener_Int32;
		public virtual RMethod RMUnregisterPersistentListener_Int32
		{
			get
			{
				if(r_MUnregisterPersistentListener_Int32 == null)
				{
					r_MUnregisterPersistentListener_Int32 = new(this, "UnregisterPersistentListener", 0, typeof(System.Int32));
				}
				return r_MUnregisterPersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void AddVoidPersistentListener(UnityEngine.Events.UnityAction)
		/// </summary>
		protected RMethod r_MAddVoidPersistentListener_UnityAction;
		public virtual RMethod RMAddVoidPersistentListener_UnityAction
		{
			get
			{
				if(r_MAddVoidPersistentListener_UnityAction == null)
				{
					r_MAddVoidPersistentListener_UnityAction = new(this, "AddVoidPersistentListener", 0, typeof(UnityEngine.Events.UnityAction));
				}
				return r_MAddVoidPersistentListener_UnityAction;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListener(Int32, UnityEngine.Events.UnityAction)
		/// </summary>
		protected RMethod r_MRegisterVoidPersistentListener_Int32_UnityAction;
		public virtual RMethod RMRegisterVoidPersistentListener_Int32_UnityAction
		{
			get
			{
				if(r_MRegisterVoidPersistentListener_Int32_UnityAction == null)
				{
					r_MRegisterVoidPersistentListener_Int32_UnityAction = new(this, "RegisterVoidPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction));
				}
				return r_MRegisterVoidPersistentListener_Int32_UnityAction;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListenerWithoutValidation(Int32, UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String;
		public virtual RMethod RMRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String
		{
			get
			{
				if(r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String == null)
				{
					r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String = new(this, "RegisterVoidPersistentListenerWithoutValidation", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.String));
				}
				return r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListenerWithoutValidation(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String;
		public virtual RMethod RMRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String
		{
			get
			{
				if(r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String == null)
				{
					r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String = new(this, "RegisterVoidPersistentListenerWithoutValidation", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
				}
				return r_MRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void AddIntPersistentListener(UnityEngine.Events.UnityAction`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_MAddIntPersistentListener_UnityAction_d_Int32_p__Int32;
		public virtual RMethod RMAddIntPersistentListener_UnityAction_d_Int32_p__Int32
		{
			get
			{
				if(r_MAddIntPersistentListener_UnityAction_d_Int32_p__Int32 == null)
				{
					r_MAddIntPersistentListener_UnityAction_d_Int32_p__Int32 = new(this, "AddIntPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
				}
				return r_MAddIntPersistentListener_UnityAction_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void RegisterIntPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_MRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32;
		public virtual RMethod RMRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32
		{
			get
			{
				if(r_MRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32 == null)
				{
					r_MRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32 = new(this, "RegisterIntPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
				}
				return r_MRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void AddFloatPersistentListener(UnityEngine.Events.UnityAction`1[System.Single], Single)
		/// </summary>
		protected RMethod r_MAddFloatPersistentListener_UnityAction_d_Single_p__Single;
		public virtual RMethod RMAddFloatPersistentListener_UnityAction_d_Single_p__Single
		{
			get
			{
				if(r_MAddFloatPersistentListener_UnityAction_d_Single_p__Single == null)
				{
					r_MAddFloatPersistentListener_UnityAction_d_Single_p__Single = new(this, "AddFloatPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Single)), typeof(System.Single));
				}
				return r_MAddFloatPersistentListener_UnityAction_d_Single_p__Single;
			}
		}

		/// <summary>
		/// Void RegisterFloatPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Single], Single)
		/// </summary>
		protected RMethod r_MRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single;
		public virtual RMethod RMRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single
		{
			get
			{
				if(r_MRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single == null)
				{
					r_MRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single = new(this, "RegisterFloatPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Single)), typeof(System.Single));
				}
				return r_MRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single;
			}
		}

		/// <summary>
		/// Void AddBoolPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean], Boolean)
		/// </summary>
		protected RMethod r_MAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean;
		public virtual RMethod RMAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean
		{
			get
			{
				if(r_MAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean == null)
				{
					r_MAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean = new(this, "AddBoolPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean));
				}
				return r_MAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean;
			}
		}

		/// <summary>
		/// Void RegisterBoolPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Boolean], Boolean)
		/// </summary>
		protected RMethod r_MRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean;
		public virtual RMethod RMRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean
		{
			get
			{
				if(r_MRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean == null)
				{
					r_MRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean = new(this, "RegisterBoolPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean));
				}
				return r_MRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean;
			}
		}

		/// <summary>
		/// Void AddStringPersistentListener(UnityEngine.Events.UnityAction`1[System.String], System.String)
		/// </summary>
		protected RMethod r_MAddStringPersistentListener_UnityAction_d_String_p__String;
		public virtual RMethod RMAddStringPersistentListener_UnityAction_d_String_p__String
		{
			get
			{
				if(r_MAddStringPersistentListener_UnityAction_d_String_p__String == null)
				{
					r_MAddStringPersistentListener_UnityAction_d_String_p__String = new(this, "AddStringPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.String)), typeof(System.String));
				}
				return r_MAddStringPersistentListener_UnityAction_d_String_p__String;
			}
		}

		/// <summary>
		/// Void RegisterStringPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.String], System.String)
		/// </summary>
		protected RMethod r_MRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String;
		public virtual RMethod RMRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String
		{
			get
			{
				if(r_MRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String == null)
				{
					r_MRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String = new(this, "RegisterStringPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.String)), typeof(System.String));
				}
				return r_MRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String;
			}
		}

		/// <summary>
		/// Void AddObjectPersistentListener[T](UnityEngine.Events.UnityAction`1[T], T)
		/// </summary>
		protected RMethod r_MAddObjectPersistentListener_GT_UnityAction_d_T_p__T;
		public virtual RMethod RMAddObjectPersistentListener_GT_UnityAction_d_T_p__T
		{
			get
			{
				if(r_MAddObjectPersistentListener_GT_UnityAction_d_T_p__T == null)
				{
					r_MAddObjectPersistentListener_GT_UnityAction_d_T_p__T = new(this, "AddObjectPersistentListener", 1, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
				}
				return r_MAddObjectPersistentListener_GT_UnityAction_d_T_p__T;
			}
		}

		/// <summary>
		/// Void RegisterObjectPersistentListener[T](Int32, UnityEngine.Events.UnityAction`1[T], T)
		/// </summary>
		protected RMethod r_MRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T;
		public virtual RMethod RMRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T
		{
			get
			{
				if(r_MRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T == null)
				{
					r_MRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T = new(this, "RegisterObjectPersistentListener", 1, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
				}
				return r_MRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T;
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

        public virtual void AddListener(UnityEngine.Events.UnityAction<System.Boolean> @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RMAddListener_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListener(UnityEngine.Events.UnityAction<System.Boolean> @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RMRemoveListener_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo FindMethod_Impl(System.String @name, System.Type @targetObjType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @targetObjType};
            var ___result = RMFindMethod_Impl_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall GetDelegate(System.Object @target, System.Reflection.MethodInfo @theFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @theFunction};
            var ___result = RMGetDelegate_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall(___result);
        }


        public virtual void Invoke(System.Boolean @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0};
            var ___result = RMInvoke_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPersistentListener(UnityEngine.Events.UnityAction<System.Boolean> @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RMAddPersistentListener_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddPersistentListener(UnityEngine.Events.UnityAction<System.Boolean> @call, UnityEngine.Events.UnityEventCallState @callState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @callState};
            var ___result = RMAddPersistentListener_UnityAction_d_Boolean_p__UnityEventCallState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Boolean> @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call};
            var ___result = RMRegisterPersistentListener_Int32_UnityAction_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo FindMethod_Impl(System.String @name, System.Object @targetObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @targetObj};
            var ___result = RMFindMethod_Impl_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo FindMethod(Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RMFindMethod_PersistentCall.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo FindMethod(System.String @name, System.Type @listenerType, UnityEngine.Events.PersistentListenerMode @mode, System.Type @argumentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @listenerType, @mode, @argumentType};
            var ___result = RMFindMethod_String_Type_PersistentListenerMode_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Int32 GetPersistentEventCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPersistentEventCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Object GetPersistentTarget(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetPersistentTarget_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String GetPersistentMethodName(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetPersistentMethodName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetPersistentListenerState(System.Int32 @index, UnityEngine.Events.UnityEventCallState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @state};
            var ___result = RMSetPersistentListenerState_Int32_UnityEventCallState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Events.UnityEventCallState GetPersistentListenerState(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetPersistentListenerState_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Events.UnityEventCallState)___result;
        }


        public virtual void AddListener(System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RMAddListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCall(Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RMAddCall_BaseInvokableCall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListener(System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RMRemoveListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAllListeners()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveAllListeners.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> PrepareInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepareInvoke.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall>(___result);
        }


        public virtual void Invoke(System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RMInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ValidateRegistration(System.Reflection.MethodInfo @method, System.Object @targetObj, UnityEngine.Events.PersistentListenerMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @targetObj, @mode};
            var ___result = RMValidateRegistration_MethodInfo_Object_PersistentListenerMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateRegistration(System.Reflection.MethodInfo @method, System.Object @targetObj, UnityEngine.Events.PersistentListenerMode @mode, System.Type @argumentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @targetObj, @mode, @argumentType};
            var ___result = RMValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddPersistentListener()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddPersistentListener.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32 @index, System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @method};
            var ___result = RMRegisterPersistentListener_Int32_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32 @index, System.Object @targetObj, System.Type @targetObjType, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @method};
            var ___result = RMRegisterPersistentListener_Int32_Object_Type_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePersistentListener(UnityEngine.Object @target, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @method};
            var ___result = RMRemovePersistentListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePersistentListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemovePersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMUnregisterPersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVoidPersistentListener(UnityEngine.Events.UnityAction @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RMAddVoidPersistentListener_UnityAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call};
            var ___result = RMRegisterVoidPersistentListener_Int32_UnityAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListenerWithoutValidation(System.Int32 @index, UnityEngine.Object @target, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @target, @methodName};
            var ___result = RMRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListenerWithoutValidation(System.Int32 @index, UnityEngine.Object @target, System.Type @targetType, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @target, @targetType, @methodName};
            var ___result = RMRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddIntPersistentListener(UnityEngine.Events.UnityAction<System.Int32> @call, System.Int32 @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RMAddIntPersistentListener_UnityAction_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterIntPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Int32> @call, System.Int32 @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RMRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFloatPersistentListener(UnityEngine.Events.UnityAction<System.Single> @call, System.Single @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RMAddFloatPersistentListener_UnityAction_d_Single_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterFloatPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Single> @call, System.Single @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RMRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBoolPersistentListener(UnityEngine.Events.UnityAction<System.Boolean> @call, System.Boolean @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RMAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterBoolPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Boolean> @call, System.Boolean @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RMRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddStringPersistentListener(UnityEngine.Events.UnityAction<System.String> @call, System.String @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RMAddStringPersistentListener_UnityAction_d_String_p__String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterStringPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.String> @call, System.String @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RMRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddObjectPersistentListener<T>(UnityEngine.Events.UnityAction<T> @call, T @argument) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RMAddObjectPersistentListener_GT_UnityAction_d_T_p__T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterObjectPersistentListener<T>(System.Int32 @index, UnityEngine.Events.UnityAction<T> @call, T @argument) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RMRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T.Invoke(___genericsType, ___parameters);

            
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


    }
}
}}