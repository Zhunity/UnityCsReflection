using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.UnityEventBase
	/// </summary>
    public partial class RUnityEventBase : RMember //
    {

		/// <summary>
		/// UnityEngine.Events.InvokableCallList m_Calls
		/// </summary>
		protected RUnityEngine.REvents.RInvokableCallList r_m_Calls;
		public virtual RUnityEngine.REvents.RInvokableCallList Rm_Calls
		{
			get
			{
				if(r_m_Calls == null)
				{
					r_m_Calls = new(this, "m_Calls");
					r_m_Calls.SetBelong(this.instance);
				}
				return r_m_Calls;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentCallGroup m_PersistentCalls
		/// </summary>
		protected RUnityEngine.REvents.RPersistentCallGroup r_m_PersistentCalls;
		public virtual RUnityEngine.REvents.RPersistentCallGroup Rm_PersistentCalls
		{
			get
			{
				if(r_m_PersistentCalls == null)
				{
					r_m_PersistentCalls = new(this, "m_PersistentCalls");
					r_m_PersistentCalls.SetBelong(this.instance);
				}
				return r_m_PersistentCalls;
			}
		}

		/// <summary>
		/// System.Boolean m_CallsDirty
		/// </summary>
		protected RSystem.RBoolean r_m_CallsDirty;
		public virtual RSystem.RBoolean Rm_CallsDirty
		{
			get
			{
				if(r_m_CallsDirty == null)
				{
					r_m_CallsDirty = new(this, "m_CallsDirty");
					r_m_CallsDirty.SetBelong(this.instance);
				}
				return r_m_CallsDirty;
			}
		}

		/// <summary>
		/// Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		/// </summary>
		protected RMethod r_UnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize;
		public virtual RMethod RUnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize
		{
			get
			{
				if(r_UnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize == null)
				{
					r_UnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize = new(this, "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize", 0);
					r_UnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize.SetBelong(this.instance);
				}
				return r_UnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		/// </summary>
		protected RMethod r_UnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize;
		public virtual RMethod RUnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize
		{
			get
			{
				if(r_UnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize == null)
				{
					r_UnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize = new(this, "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize", 0);
					r_UnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize.SetBelong(this.instance);
				}
				return r_UnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod_Impl(System.String, System.Object)
		/// </summary>
		protected RMethod r_FindMethod_Impl_String_Object;
		public virtual RMethod RFindMethod_Impl_String_Object
		{
			get
			{
				if(r_FindMethod_Impl_String_Object == null)
				{
					r_FindMethod_Impl_String_Object = new(this, "FindMethod_Impl", 0, typeof(System.String), typeof(System.Object));
					r_FindMethod_Impl_String_Object.SetBelong(this.instance);
				}
				return r_FindMethod_Impl_String_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod_Impl(System.String, System.Type)
		/// </summary>
		protected RMethod r_FindMethod_Impl_String_Type;
		public virtual RMethod RFindMethod_Impl_String_Type
		{
			get
			{
				if(r_FindMethod_Impl_String_Type == null)
				{
					r_FindMethod_Impl_String_Type = new(this, "FindMethod_Impl", 0, typeof(System.String), typeof(System.Type));
					r_FindMethod_Impl_String_Type.SetBelong(this.instance);
				}
				return r_FindMethod_Impl_String_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetDelegate(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_GetDelegate_Object_MethodInfo;
		public virtual RMethod RGetDelegate_Object_MethodInfo
		{
			get
			{
				if(r_GetDelegate_Object_MethodInfo == null)
				{
					r_GetDelegate_Object_MethodInfo = new(this, "GetDelegate", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_GetDelegate_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_GetDelegate_Object_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall)
		/// </summary>
		protected RMethod r_FindMethod_PersistentCall;
		public virtual RMethod RFindMethod_PersistentCall
		{
			get
			{
				if(r_FindMethod_PersistentCall == null)
				{
					r_FindMethod_PersistentCall = new(this, "FindMethod", 0,  ReflectionUtils.GetType("UnityEngine.Events.PersistentCall"));
					r_FindMethod_PersistentCall.SetBelong(this.instance);
				}
				return r_FindMethod_PersistentCall;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo FindMethod(System.String, System.Type, UnityEngine.Events.PersistentListenerMode, System.Type)
		/// </summary>
		protected RMethod r_FindMethod_String_Type_PersistentListenerMode_Type;
		public virtual RMethod RFindMethod_String_Type_PersistentListenerMode_Type
		{
			get
			{
				if(r_FindMethod_String_Type_PersistentListenerMode_Type == null)
				{
					r_FindMethod_String_Type_PersistentListenerMode_Type = new(this, "FindMethod", 0, typeof(System.String), typeof(System.Type), typeof(UnityEngine.Events.PersistentListenerMode), typeof(System.Type));
					r_FindMethod_String_Type_PersistentListenerMode_Type.SetBelong(this.instance);
				}
				return r_FindMethod_String_Type_PersistentListenerMode_Type;
			}
		}

		/// <summary>
		/// Int32 GetPersistentEventCount()
		/// </summary>
		protected RMethod r_GetPersistentEventCount;
		public virtual RMethod RGetPersistentEventCount
		{
			get
			{
				if(r_GetPersistentEventCount == null)
				{
					r_GetPersistentEventCount = new(this, "GetPersistentEventCount", 0);
					r_GetPersistentEventCount.SetBelong(this.instance);
				}
				return r_GetPersistentEventCount;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetPersistentTarget(Int32)
		/// </summary>
		protected RMethod r_GetPersistentTarget_Int32;
		public virtual RMethod RGetPersistentTarget_Int32
		{
			get
			{
				if(r_GetPersistentTarget_Int32 == null)
				{
					r_GetPersistentTarget_Int32 = new(this, "GetPersistentTarget", 0, typeof(System.Int32));
					r_GetPersistentTarget_Int32.SetBelong(this.instance);
				}
				return r_GetPersistentTarget_Int32;
			}
		}

		/// <summary>
		/// System.String GetPersistentMethodName(Int32)
		/// </summary>
		protected RMethod r_GetPersistentMethodName_Int32;
		public virtual RMethod RGetPersistentMethodName_Int32
		{
			get
			{
				if(r_GetPersistentMethodName_Int32 == null)
				{
					r_GetPersistentMethodName_Int32 = new(this, "GetPersistentMethodName", 0, typeof(System.Int32));
					r_GetPersistentMethodName_Int32.SetBelong(this.instance);
				}
				return r_GetPersistentMethodName_Int32;
			}
		}

		/// <summary>
		/// Void DirtyPersistentCalls()
		/// </summary>
		protected RMethod r_DirtyPersistentCalls;
		public virtual RMethod RDirtyPersistentCalls
		{
			get
			{
				if(r_DirtyPersistentCalls == null)
				{
					r_DirtyPersistentCalls = new(this, "DirtyPersistentCalls", 0);
					r_DirtyPersistentCalls.SetBelong(this.instance);
				}
				return r_DirtyPersistentCalls;
			}
		}

		/// <summary>
		/// Void RebuildPersistentCallsIfNeeded()
		/// </summary>
		protected RMethod r_RebuildPersistentCallsIfNeeded;
		public virtual RMethod RRebuildPersistentCallsIfNeeded
		{
			get
			{
				if(r_RebuildPersistentCallsIfNeeded == null)
				{
					r_RebuildPersistentCallsIfNeeded = new(this, "RebuildPersistentCallsIfNeeded", 0);
					r_RebuildPersistentCallsIfNeeded.SetBelong(this.instance);
				}
				return r_RebuildPersistentCallsIfNeeded;
			}
		}

		/// <summary>
		/// Void SetPersistentListenerState(Int32, UnityEngine.Events.UnityEventCallState)
		/// </summary>
		protected RMethod r_SetPersistentListenerState_Int32_UnityEventCallState;
		public virtual RMethod RSetPersistentListenerState_Int32_UnityEventCallState
		{
			get
			{
				if(r_SetPersistentListenerState_Int32_UnityEventCallState == null)
				{
					r_SetPersistentListenerState_Int32_UnityEventCallState = new(this, "SetPersistentListenerState", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityEventCallState));
					r_SetPersistentListenerState_Int32_UnityEventCallState.SetBelong(this.instance);
				}
				return r_SetPersistentListenerState_Int32_UnityEventCallState;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState GetPersistentListenerState(Int32)
		/// </summary>
		protected RMethod r_GetPersistentListenerState_Int32;
		public virtual RMethod RGetPersistentListenerState_Int32
		{
			get
			{
				if(r_GetPersistentListenerState_Int32 == null)
				{
					r_GetPersistentListenerState_Int32 = new(this, "GetPersistentListenerState", 0, typeof(System.Int32));
					r_GetPersistentListenerState_Int32.SetBelong(this.instance);
				}
				return r_GetPersistentListenerState_Int32;
			}
		}

		/// <summary>
		/// Void AddListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_AddListener_Object_MethodInfo;
		public virtual RMethod RAddListener_Object_MethodInfo
		{
			get
			{
				if(r_AddListener_Object_MethodInfo == null)
				{
					r_AddListener_Object_MethodInfo = new(this, "AddListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_AddListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_AddListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void AddCall(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_AddCall_BaseInvokableCall;
		public virtual RMethod RAddCall_BaseInvokableCall
		{
			get
			{
				if(r_AddCall_BaseInvokableCall == null)
				{
					r_AddCall_BaseInvokableCall = new(this, "AddCall", 0,  ReflectionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
					r_AddCall_BaseInvokableCall.SetBelong(this.instance);
				}
				return r_AddCall_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RemoveListener_Object_MethodInfo;
		public virtual RMethod RRemoveListener_Object_MethodInfo
		{
			get
			{
				if(r_RemoveListener_Object_MethodInfo == null)
				{
					r_RemoveListener_Object_MethodInfo = new(this, "RemoveListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RemoveListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RemoveListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemoveAllListeners()
		/// </summary>
		protected RMethod r_RemoveAllListeners;
		public virtual RMethod RRemoveAllListeners
		{
			get
			{
				if(r_RemoveAllListeners == null)
				{
					r_RemoveAllListeners = new(this, "RemoveAllListeners", 0);
					r_RemoveAllListeners.SetBelong(this.instance);
				}
				return r_RemoveAllListeners;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] PrepareInvoke()
		/// </summary>
		protected RMethod r_PrepareInvoke;
		public virtual RMethod RPrepareInvoke
		{
			get
			{
				if(r_PrepareInvoke == null)
				{
					r_PrepareInvoke = new(this, "PrepareInvoke", 0);
					r_PrepareInvoke.SetBelong(this.instance);
				}
				return r_PrepareInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.Object[])
		/// </summary>
		protected RMethod r_Invoke_ObjectArray;
		public virtual RMethod RInvoke_ObjectArray
		{
			get
			{
				if(r_Invoke_ObjectArray == null)
				{
					r_Invoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
					r_Invoke_ObjectArray.SetBelong(this.instance);
				}
				return r_Invoke_ObjectArray;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetValidMethodInfo(System.Object, System.String, System.Type[])
		/// </summary>
		protected static RMethod r_GetValidMethodInfo_Object_String_TypeArray;
		public static RMethod RGetValidMethodInfo_Object_String_TypeArray
		{
			get
			{
				if(r_GetValidMethodInfo_Object_String_TypeArray == null)
				{
					r_GetValidMethodInfo_Object_String_TypeArray = new(typeof(UnityEngine.Events.UnityEventBase), "GetValidMethodInfo", 0, typeof(System.Object), typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetValidMethodInfo_Object_String_TypeArray.SetBelong(null);
				}
				return r_GetValidMethodInfo_Object_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetValidMethodInfo(System.Type, System.String, System.Type[])
		/// </summary>
		protected static RMethod r_GetValidMethodInfo_Type_String_TypeArray;
		public static RMethod RGetValidMethodInfo_Type_String_TypeArray
		{
			get
			{
				if(r_GetValidMethodInfo_Type_String_TypeArray == null)
				{
					r_GetValidMethodInfo_Type_String_TypeArray = new(typeof(UnityEngine.Events.UnityEventBase), "GetValidMethodInfo", 0, typeof(System.Type), typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetValidMethodInfo_Type_String_TypeArray.SetBelong(null);
				}
				return r_GetValidMethodInfo_Type_String_TypeArray;
			}
		}

		/// <summary>
		/// Boolean ValidateRegistration(System.Reflection.MethodInfo, System.Object, UnityEngine.Events.PersistentListenerMode)
		/// </summary>
		protected RMethod r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode;
		public virtual RMethod RValidateRegistration_MethodInfo_Object_PersistentListenerMode
		{
			get
			{
				if(r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode == null)
				{
					r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode = new(this, "ValidateRegistration", 0, typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(UnityEngine.Events.PersistentListenerMode));
					r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode.SetBelong(this.instance);
				}
				return r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode;
			}
		}

		/// <summary>
		/// Boolean ValidateRegistration(System.Reflection.MethodInfo, System.Object, UnityEngine.Events.PersistentListenerMode, System.Type)
		/// </summary>
		protected RMethod r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type;
		public virtual RMethod RValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type
		{
			get
			{
				if(r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type == null)
				{
					r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type = new(this, "ValidateRegistration", 0, typeof(System.Reflection.MethodInfo), typeof(System.Object), typeof(UnityEngine.Events.PersistentListenerMode), typeof(System.Type));
					r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type.SetBelong(this.instance);
				}
				return r_ValidateRegistration_MethodInfo_Object_PersistentListenerMode_Type;
			}
		}

		/// <summary>
		/// Void AddPersistentListener()
		/// </summary>
		protected RMethod r_AddPersistentListener;
		public virtual RMethod RAddPersistentListener
		{
			get
			{
				if(r_AddPersistentListener == null)
				{
					r_AddPersistentListener = new(this, "AddPersistentListener", 0);
					r_AddPersistentListener.SetBelong(this.instance);
				}
				return r_AddPersistentListener;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RegisterPersistentListener_Int32_Object_MethodInfo;
		public virtual RMethod RRegisterPersistentListener_Int32_Object_MethodInfo
		{
			get
			{
				if(r_RegisterPersistentListener_Int32_Object_MethodInfo == null)
				{
					r_RegisterPersistentListener_Int32_Object_MethodInfo = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RegisterPersistentListener_Int32_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RegisterPersistentListener_Int32_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(Int32, System.Object, System.Type, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RegisterPersistentListener_Int32_Object_Type_MethodInfo;
		public virtual RMethod RRegisterPersistentListener_Int32_Object_Type_MethodInfo
		{
			get
			{
				if(r_RegisterPersistentListener_Int32_Object_Type_MethodInfo == null)
				{
					r_RegisterPersistentListener_Int32_Object_Type_MethodInfo = new(this, "RegisterPersistentListener", 0, typeof(System.Int32), typeof(System.Object), typeof(System.Type), typeof(System.Reflection.MethodInfo));
					r_RegisterPersistentListener_Int32_Object_Type_MethodInfo.SetBelong(this.instance);
				}
				return r_RegisterPersistentListener_Int32_Object_Type_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemovePersistentListener(UnityEngine.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RemovePersistentListener_Object_MethodInfo;
		public virtual RMethod RRemovePersistentListener_Object_MethodInfo
		{
			get
			{
				if(r_RemovePersistentListener_Object_MethodInfo == null)
				{
					r_RemovePersistentListener_Object_MethodInfo = new(this, "RemovePersistentListener", 0, typeof(UnityEngine.Object), typeof(System.Reflection.MethodInfo));
					r_RemovePersistentListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RemovePersistentListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void RemovePersistentListener(Int32)
		/// </summary>
		protected RMethod r_RemovePersistentListener_Int32;
		public virtual RMethod RRemovePersistentListener_Int32
		{
			get
			{
				if(r_RemovePersistentListener_Int32 == null)
				{
					r_RemovePersistentListener_Int32 = new(this, "RemovePersistentListener", 0, typeof(System.Int32));
					r_RemovePersistentListener_Int32.SetBelong(this.instance);
				}
				return r_RemovePersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener(Int32)
		/// </summary>
		protected RMethod r_UnregisterPersistentListener_Int32;
		public virtual RMethod RUnregisterPersistentListener_Int32
		{
			get
			{
				if(r_UnregisterPersistentListener_Int32 == null)
				{
					r_UnregisterPersistentListener_Int32 = new(this, "UnregisterPersistentListener", 0, typeof(System.Int32));
					r_UnregisterPersistentListener_Int32.SetBelong(this.instance);
				}
				return r_UnregisterPersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void AddVoidPersistentListener(UnityEngine.Events.UnityAction)
		/// </summary>
		protected RMethod r_AddVoidPersistentListener_UnityAction;
		public virtual RMethod RAddVoidPersistentListener_UnityAction
		{
			get
			{
				if(r_AddVoidPersistentListener_UnityAction == null)
				{
					r_AddVoidPersistentListener_UnityAction = new(this, "AddVoidPersistentListener", 0, typeof(UnityEngine.Events.UnityAction));
					r_AddVoidPersistentListener_UnityAction.SetBelong(this.instance);
				}
				return r_AddVoidPersistentListener_UnityAction;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListener(Int32, UnityEngine.Events.UnityAction)
		/// </summary>
		protected RMethod r_RegisterVoidPersistentListener_Int32_UnityAction;
		public virtual RMethod RRegisterVoidPersistentListener_Int32_UnityAction
		{
			get
			{
				if(r_RegisterVoidPersistentListener_Int32_UnityAction == null)
				{
					r_RegisterVoidPersistentListener_Int32_UnityAction = new(this, "RegisterVoidPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction));
					r_RegisterVoidPersistentListener_Int32_UnityAction.SetBelong(this.instance);
				}
				return r_RegisterVoidPersistentListener_Int32_UnityAction;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListenerWithoutValidation(Int32, UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_String;
		public virtual RMethod RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String
		{
			get
			{
				if(r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_String == null)
				{
					r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_String = new(this, "RegisterVoidPersistentListenerWithoutValidation", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.String));
					r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_String.SetBelong(this.instance);
				}
				return r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_String;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListenerWithoutValidation(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String;
		public virtual RMethod RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String
		{
			get
			{
				if(r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String == null)
				{
					r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String = new(this, "RegisterVoidPersistentListenerWithoutValidation", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
					r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String.SetBelong(this.instance);
				}
				return r_RegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void AddIntPersistentListener(UnityEngine.Events.UnityAction`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_AddIntPersistentListener_UnityAction_d_Int32_p__Int32;
		public virtual RMethod RAddIntPersistentListener_UnityAction_d_Int32_p__Int32
		{
			get
			{
				if(r_AddIntPersistentListener_UnityAction_d_Int32_p__Int32 == null)
				{
					r_AddIntPersistentListener_UnityAction_d_Int32_p__Int32 = new(this, "AddIntPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_AddIntPersistentListener_UnityAction_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_AddIntPersistentListener_UnityAction_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void RegisterIntPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Int32], Int32)
		/// </summary>
		protected RMethod r_RegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32;
		public virtual RMethod RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32
		{
			get
			{
				if(r_RegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32 == null)
				{
					r_RegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32 = new(this, "RegisterIntPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32));
					r_RegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32.SetBelong(this.instance);
				}
				return r_RegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32;
			}
		}

		/// <summary>
		/// Void AddFloatPersistentListener(UnityEngine.Events.UnityAction`1[System.Single], Single)
		/// </summary>
		protected RMethod r_AddFloatPersistentListener_UnityAction_d_Single_p__Single;
		public virtual RMethod RAddFloatPersistentListener_UnityAction_d_Single_p__Single
		{
			get
			{
				if(r_AddFloatPersistentListener_UnityAction_d_Single_p__Single == null)
				{
					r_AddFloatPersistentListener_UnityAction_d_Single_p__Single = new(this, "AddFloatPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Single)), typeof(System.Single));
					r_AddFloatPersistentListener_UnityAction_d_Single_p__Single.SetBelong(this.instance);
				}
				return r_AddFloatPersistentListener_UnityAction_d_Single_p__Single;
			}
		}

		/// <summary>
		/// Void RegisterFloatPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Single], Single)
		/// </summary>
		protected RMethod r_RegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single;
		public virtual RMethod RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single
		{
			get
			{
				if(r_RegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single == null)
				{
					r_RegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single = new(this, "RegisterFloatPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Single)), typeof(System.Single));
					r_RegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single.SetBelong(this.instance);
				}
				return r_RegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single;
			}
		}

		/// <summary>
		/// Void AddBoolPersistentListener(UnityEngine.Events.UnityAction`1[System.Boolean], Boolean)
		/// </summary>
		protected RMethod r_AddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean;
		public virtual RMethod RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean
		{
			get
			{
				if(r_AddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean == null)
				{
					r_AddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean = new(this, "AddBoolPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean));
					r_AddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean.SetBelong(this.instance);
				}
				return r_AddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean;
			}
		}

		/// <summary>
		/// Void RegisterBoolPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.Boolean], Boolean)
		/// </summary>
		protected RMethod r_RegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean;
		public virtual RMethod RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean
		{
			get
			{
				if(r_RegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean == null)
				{
					r_RegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean = new(this, "RegisterBoolPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean));
					r_RegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean.SetBelong(this.instance);
				}
				return r_RegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean;
			}
		}

		/// <summary>
		/// Void AddStringPersistentListener(UnityEngine.Events.UnityAction`1[System.String], System.String)
		/// </summary>
		protected RMethod r_AddStringPersistentListener_UnityAction_d_String_p__String;
		public virtual RMethod RAddStringPersistentListener_UnityAction_d_String_p__String
		{
			get
			{
				if(r_AddStringPersistentListener_UnityAction_d_String_p__String == null)
				{
					r_AddStringPersistentListener_UnityAction_d_String_p__String = new(this, "AddStringPersistentListener", 0, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.String)), typeof(System.String));
					r_AddStringPersistentListener_UnityAction_d_String_p__String.SetBelong(this.instance);
				}
				return r_AddStringPersistentListener_UnityAction_d_String_p__String;
			}
		}

		/// <summary>
		/// Void RegisterStringPersistentListener(Int32, UnityEngine.Events.UnityAction`1[System.String], System.String)
		/// </summary>
		protected RMethod r_RegisterStringPersistentListener_Int32_UnityAction_d_String_p__String;
		public virtual RMethod RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String
		{
			get
			{
				if(r_RegisterStringPersistentListener_Int32_UnityAction_d_String_p__String == null)
				{
					r_RegisterStringPersistentListener_Int32_UnityAction_d_String_p__String = new(this, "RegisterStringPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(typeof(System.String)), typeof(System.String));
					r_RegisterStringPersistentListener_Int32_UnityAction_d_String_p__String.SetBelong(this.instance);
				}
				return r_RegisterStringPersistentListener_Int32_UnityAction_d_String_p__String;
			}
		}

		/// <summary>
		/// Void AddObjectPersistentListener[T](UnityEngine.Events.UnityAction`1[T], T)
		/// </summary>
		protected RMethod r_AddObjectPersistentListener_GT_UnityAction_d_T_p__T;
		public virtual RMethod RAddObjectPersistentListener_GT_UnityAction_d_T_p__T
		{
			get
			{
				if(r_AddObjectPersistentListener_GT_UnityAction_d_T_p__T == null)
				{
					r_AddObjectPersistentListener_GT_UnityAction_d_T_p__T = new(this, "AddObjectPersistentListener", 1, typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_AddObjectPersistentListener_GT_UnityAction_d_T_p__T.SetBelong(this.instance);
				}
				return r_AddObjectPersistentListener_GT_UnityAction_d_T_p__T;
			}
		}

		/// <summary>
		/// Void RegisterObjectPersistentListener[T](Int32, UnityEngine.Events.UnityAction`1[T], T)
		/// </summary>
		protected RMethod r_RegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T;
		public virtual RMethod RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T
		{
			get
			{
				if(r_RegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T == null)
				{
					r_RegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T = new(this, "RegisterObjectPersistentListener", 1, typeof(System.Int32), typeof(UnityEngine.Events.UnityAction<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0));
					r_RegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T.SetBelong(this.instance);
				}
				return r_RegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RUnityEventBase() : base("UnityEngine.Events.UnityEventBase")
        {
        }

        public RUnityEventBase(System.Object instance) : base("UnityEngine.Events.UnityEventBase")
		{
            SetInstance(instance);
		}

        public RUnityEventBase(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityEventBase(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void UnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEngine__2__ISerializationCallbackReceiver__2__OnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEngine__2__ISerializationCallbackReceiver__2__OnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo FindMethod_Impl(System.String @name, System.Object @targetObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @targetObj};
            var ___result = RFindMethod_Impl_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo FindMethod_Impl(System.String @name, System.Type @targetObjType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @targetObjType};
            var ___result = RFindMethod_Impl_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual RUnityEngine.REvents.RBaseInvokableCall GetDelegate(System.Object @target, System.Reflection.MethodInfo @theFunction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @theFunction};
            var ___result = RGetDelegate_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.REvents.RBaseInvokableCall(___result);
        }


        public virtual System.Reflection.MethodInfo FindMethod(RUnityEngine.REvents.RPersistentCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RFindMethod_PersistentCall.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo FindMethod(System.String @name, System.Type @listenerType, UnityEngine.Events.PersistentListenerMode @mode, System.Type @argumentType)
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


        public virtual UnityEngine.Object GetPersistentTarget(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetPersistentTarget_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String GetPersistentMethodName(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetPersistentMethodName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void DirtyPersistentCalls()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDirtyPersistentCalls.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RebuildPersistentCallsIfNeeded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRebuildPersistentCallsIfNeeded.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPersistentListenerState(System.Int32 @index, UnityEngine.Events.UnityEventCallState @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @state};
            var ___result = RSetPersistentListenerState_Int32_UnityEventCallState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Events.UnityEventCallState GetPersistentListenerState(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetPersistentListenerState_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Events.UnityEventCallState)___result;
        }


        public virtual void AddListener(System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RAddListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCall(RUnityEngine.REvents.RBaseInvokableCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RAddCall_BaseInvokableCall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListener(System.Object @targetObj, System.Reflection.MethodInfo @method)
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


        public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> PrepareInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareInvoke.Invoke(___genericsType, ___parameters);

            return new RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall>(___result);
        }


        public virtual void Invoke(System.Object[] @parameters)
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


        public static System.Reflection.MethodInfo GetValidMethodInfo(System.Object @obj, System.String @functionName, System.Type[] @argumentTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @functionName, @argumentTypes};
            var ___result = RGetValidMethodInfo_Object_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public static System.Reflection.MethodInfo GetValidMethodInfo(System.Type @objectType, System.String @functionName, System.Type[] @argumentTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objectType, @functionName, @argumentTypes};
            var ___result = RGetValidMethodInfo_Type_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Boolean ValidateRegistration(System.Reflection.MethodInfo @method, System.Object @targetObj, UnityEngine.Events.PersistentListenerMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @targetObj, @mode};
            var ___result = RValidateRegistration_MethodInfo_Object_PersistentListenerMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateRegistration(System.Reflection.MethodInfo @method, System.Object @targetObj, UnityEngine.Events.PersistentListenerMode @mode, System.Type @argumentType)
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


        public virtual void RegisterPersistentListener(System.Int32 @index, System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @method};
            var ___result = RRegisterPersistentListener_Int32_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterPersistentListener(System.Int32 @index, System.Object @targetObj, System.Type @targetObjType, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @method};
            var ___result = RRegisterPersistentListener_Int32_Object_Type_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePersistentListener(UnityEngine.Object @target, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @method};
            var ___result = RRemovePersistentListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePersistentListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemovePersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RUnregisterPersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddVoidPersistentListener(UnityEngine.Events.UnityAction @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call};
            var ___result = RAddVoidPersistentListener_UnityAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call};
            var ___result = RRegisterVoidPersistentListener_Int32_UnityAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListenerWithoutValidation(System.Int32 @index, UnityEngine.Object @target, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @target, @methodName};
            var ___result = RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListenerWithoutValidation(System.Int32 @index, UnityEngine.Object @target, System.Type @targetType, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @target, @targetType, @methodName};
            var ___result = RRegisterVoidPersistentListenerWithoutValidation_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddIntPersistentListener(UnityEngine.Events.UnityAction<System.Int32> @call, System.Int32 @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddIntPersistentListener_UnityAction_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterIntPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Int32> @call, System.Int32 @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterIntPersistentListener_Int32_UnityAction_d_Int32_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFloatPersistentListener(UnityEngine.Events.UnityAction<System.Single> @call, System.Single @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddFloatPersistentListener_UnityAction_d_Single_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterFloatPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Single> @call, System.Single @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterFloatPersistentListener_Int32_UnityAction_d_Single_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBoolPersistentListener(UnityEngine.Events.UnityAction<System.Boolean> @call, System.Boolean @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddBoolPersistentListener_UnityAction_d_Boolean_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterBoolPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.Boolean> @call, System.Boolean @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterBoolPersistentListener_Int32_UnityAction_d_Boolean_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddStringPersistentListener(UnityEngine.Events.UnityAction<System.String> @call, System.String @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddStringPersistentListener_UnityAction_d_String_p__String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterStringPersistentListener(System.Int32 @index, UnityEngine.Events.UnityAction<System.String> @call, System.String @argument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterStringPersistentListener_Int32_UnityAction_d_String_p__String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddObjectPersistentListener<T>(UnityEngine.Events.UnityAction<T> @call, T @argument) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@call, @argument};
            var ___result = RAddObjectPersistentListener_GT_UnityAction_d_T_p__T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterObjectPersistentListener<T>(System.Int32 @index, UnityEngine.Events.UnityAction<T> @call, T @argument) where T : UnityEngine.Object
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@index, @call, @argument};
            var ___result = RRegisterObjectPersistentListener_GT_Int32_UnityAction_d_T_p__T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
