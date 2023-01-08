using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.EventInfo
	/// </summary>
    public partial class REventInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.EventInfo+AddEventAdapter cached_add_event
		/// </summary>
		protected RSystem.RReflection.REventInfo.RAddEventAdapter r_cached_add_event;
		public virtual RSystem.RReflection.REventInfo.RAddEventAdapter Rcached_add_event
		{
			get
			{
				if(r_cached_add_event == null)
				{
					r_cached_add_event = new(this, "cached_add_event");
					r_cached_add_event.SetBelong(this.instance);
				}
				return r_cached_add_event;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected RProperty r_MemberType;
		public virtual RProperty RMemberType
		{
			get
			{
				if(r_MemberType == null)
				{
					r_MemberType = new(this, "MemberType", -1);
					r_MemberType.SetBelong(this.instance);
				}
				return r_MemberType;
			}
		}

		/// <summary>
		/// System.Reflection.EventAttributes Attributes
		/// </summary>
		protected RProperty r_Attributes;
		public virtual RProperty RAttributes
		{
			get
			{
				if(r_Attributes == null)
				{
					r_Attributes = new(this, "Attributes", -1);
					r_Attributes.SetBelong(this.instance);
				}
				return r_Attributes;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected RProperty r_IsSpecialName;
		public virtual RProperty RIsSpecialName
		{
			get
			{
				if(r_IsSpecialName == null)
				{
					r_IsSpecialName = new(this, "IsSpecialName", -1);
					r_IsSpecialName.SetBelong(this.instance);
				}
				return r_IsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo AddMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_AddMethod;
		public virtual RSystem.RReflection.RMethodInfo RAddMethod
		{
			get
			{
				if(r_AddMethod == null)
				{
					r_AddMethod = new(this, "AddMethod", -1);
					r_AddMethod.SetBelong(this.instance);
				}
				return r_AddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RemoveMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_RemoveMethod;
		public virtual RSystem.RReflection.RMethodInfo RRemoveMethod
		{
			get
			{
				if(r_RemoveMethod == null)
				{
					r_RemoveMethod = new(this, "RemoveMethod", -1);
					r_RemoveMethod.SetBelong(this.instance);
				}
				return r_RemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RaiseMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_RaiseMethod;
		public virtual RSystem.RReflection.RMethodInfo RRaiseMethod
		{
			get
			{
				if(r_RaiseMethod == null)
				{
					r_RaiseMethod = new(this, "RaiseMethod", -1);
					r_RaiseMethod.SetBelong(this.instance);
				}
				return r_RaiseMethod;
			}
		}

		/// <summary>
		/// Boolean IsMulticast
		/// </summary>
		protected RProperty r_IsMulticast;
		public virtual RProperty RIsMulticast
		{
			get
			{
				if(r_IsMulticast == null)
				{
					r_IsMulticast = new(this, "IsMulticast", -1);
					r_IsMulticast.SetBelong(this.instance);
				}
				return r_IsMulticast;
			}
		}

		/// <summary>
		/// System.Type EventHandlerType
		/// </summary>
		protected RSystem.RType r_EventHandlerType;
		public virtual RSystem.RType REventHandlerType
		{
			get
			{
				if(r_EventHandlerType == null)
				{
					r_EventHandlerType = new(this, "EventHandlerType", -1);
					r_EventHandlerType.SetBelong(this.instance);
				}
				return r_EventHandlerType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected RSystem.RType r_DeclaringType;
		public virtual RSystem.RType RDeclaringType
		{
			get
			{
				if(r_DeclaringType == null)
				{
					r_DeclaringType = new(this, "DeclaringType", -1);
					r_DeclaringType.SetBelong(this.instance);
				}
				return r_DeclaringType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_ReflectedType;
		public virtual RSystem.RType RReflectedType
		{
			get
			{
				if(r_ReflectedType == null)
				{
					r_ReflectedType = new(this, "ReflectedType", -1);
					r_ReflectedType.SetBelong(this.instance);
				}
				return r_ReflectedType;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected RSystem.RReflection.RModule r_Module;
		public virtual RSystem.RReflection.RModule RModule
		{
			get
			{
				if(r_Module == null)
				{
					r_Module = new(this, "Module", -1);
					r_Module.SetBelong(this.instance);
				}
				return r_Module;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_CustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RCustomAttributes
		{
			get
			{
				if(r_CustomAttributes == null)
				{
					r_CustomAttributes = new(this, "CustomAttributes", -1);
					r_CustomAttributes.SetBelong(this.instance);
				}
				return r_CustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected RProperty r_MetadataToken;
		public virtual RProperty RMetadataToken
		{
			get
			{
				if(r_MetadataToken == null)
				{
					r_MetadataToken = new(this, "MetadataToken", -1);
					r_MetadataToken.SetBelong(this.instance);
				}
				return r_MetadataToken;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetOtherMethods()
		/// </summary>
		protected RMethod r_GetOtherMethods;
		public virtual RMethod RGetOtherMethods
		{
			get
			{
				if(r_GetOtherMethods == null)
				{
					r_GetOtherMethods = new(this, "GetOtherMethods", 0);
					r_GetOtherMethods.SetBelong(this.instance);
				}
				return r_GetOtherMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetOtherMethods(Boolean)
		/// </summary>
		protected RMethod r_GetOtherMethods_Boolean;
		public virtual RMethod RGetOtherMethods_Boolean
		{
			get
			{
				if(r_GetOtherMethods_Boolean == null)
				{
					r_GetOtherMethods_Boolean = new(this, "GetOtherMethods", 0, typeof(System.Boolean));
					r_GetOtherMethods_Boolean.SetBelong(this.instance);
				}
				return r_GetOtherMethods_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetAddMethod()
		/// </summary>
		protected RMethod r_GetAddMethod;
		public virtual RMethod RGetAddMethod
		{
			get
			{
				if(r_GetAddMethod == null)
				{
					r_GetAddMethod = new(this, "GetAddMethod", 0);
					r_GetAddMethod.SetBelong(this.instance);
				}
				return r_GetAddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRemoveMethod()
		/// </summary>
		protected RMethod r_GetRemoveMethod;
		public virtual RMethod RGetRemoveMethod
		{
			get
			{
				if(r_GetRemoveMethod == null)
				{
					r_GetRemoveMethod = new(this, "GetRemoveMethod", 0);
					r_GetRemoveMethod.SetBelong(this.instance);
				}
				return r_GetRemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRaiseMethod()
		/// </summary>
		protected RMethod r_GetRaiseMethod;
		public virtual RMethod RGetRaiseMethod
		{
			get
			{
				if(r_GetRaiseMethod == null)
				{
					r_GetRaiseMethod = new(this, "GetRaiseMethod", 0);
					r_GetRaiseMethod.SetBelong(this.instance);
				}
				return r_GetRaiseMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetAddMethod(Boolean)
		/// </summary>
		protected RMethod r_GetAddMethod_Boolean;
		public virtual RMethod RGetAddMethod_Boolean
		{
			get
			{
				if(r_GetAddMethod_Boolean == null)
				{
					r_GetAddMethod_Boolean = new(this, "GetAddMethod", 0, typeof(System.Boolean));
					r_GetAddMethod_Boolean.SetBelong(this.instance);
				}
				return r_GetAddMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRemoveMethod(Boolean)
		/// </summary>
		protected RMethod r_GetRemoveMethod_Boolean;
		public virtual RMethod RGetRemoveMethod_Boolean
		{
			get
			{
				if(r_GetRemoveMethod_Boolean == null)
				{
					r_GetRemoveMethod_Boolean = new(this, "GetRemoveMethod", 0, typeof(System.Boolean));
					r_GetRemoveMethod_Boolean.SetBelong(this.instance);
				}
				return r_GetRemoveMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRaiseMethod(Boolean)
		/// </summary>
		protected RMethod r_GetRaiseMethod_Boolean;
		public virtual RMethod RGetRaiseMethod_Boolean
		{
			get
			{
				if(r_GetRaiseMethod_Boolean == null)
				{
					r_GetRaiseMethod_Boolean = new(this, "GetRaiseMethod", 0, typeof(System.Boolean));
					r_GetRaiseMethod_Boolean.SetBelong(this.instance);
				}
				return r_GetRaiseMethod_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveEventHandler(System.Object, System.Delegate)
		/// </summary>
		protected RMethod r_RemoveEventHandler_Object_Delegate;
		public virtual RMethod RRemoveEventHandler_Object_Delegate
		{
			get
			{
				if(r_RemoveEventHandler_Object_Delegate == null)
				{
					r_RemoveEventHandler_Object_Delegate = new(this, "RemoveEventHandler", 0, typeof(System.Object), typeof(System.Delegate));
					r_RemoveEventHandler_Object_Delegate.SetBelong(this.instance);
				}
				return r_RemoveEventHandler_Object_Delegate;
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
		/// Boolean op_Equality(System.Reflection.EventInfo, System.Reflection.EventInfo)
		/// </summary>
		protected static RMethod r_op_Equality_EventInfo_EventInfo;
		public static RMethod Rop_Equality_EventInfo_EventInfo
		{
			get
			{
				if(r_op_Equality_EventInfo_EventInfo == null)
				{
					r_op_Equality_EventInfo_EventInfo = new(typeof(System.Reflection.EventInfo), "op_Equality", 0, typeof(System.Reflection.EventInfo), typeof(System.Reflection.EventInfo));
					r_op_Equality_EventInfo_EventInfo.SetBelong(null);
				}
				return r_op_Equality_EventInfo_EventInfo;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.EventInfo, System.Reflection.EventInfo)
		/// </summary>
		protected static RMethod r_op_Inequality_EventInfo_EventInfo;
		public static RMethod Rop_Inequality_EventInfo_EventInfo
		{
			get
			{
				if(r_op_Inequality_EventInfo_EventInfo == null)
				{
					r_op_Inequality_EventInfo_EventInfo = new(typeof(System.Reflection.EventInfo), "op_Inequality", 0, typeof(System.Reflection.EventInfo), typeof(System.Reflection.EventInfo));
					r_op_Inequality_EventInfo_EventInfo.SetBelong(null);
				}
				return r_op_Inequality_EventInfo_EventInfo;
			}
		}

		/// <summary>
		/// Void AddEventHandler(System.Object, System.Delegate)
		/// </summary>
		protected RMethod r_AddEventHandler_Object_Delegate;
		public virtual RMethod RAddEventHandler_Object_Delegate
		{
			get
			{
				if(r_AddEventHandler_Object_Delegate == null)
				{
					r_AddEventHandler_Object_Delegate = new(this, "AddEventHandler", 0, typeof(System.Object), typeof(System.Delegate));
					r_AddEventHandler_Object_Delegate.SetBelong(this.instance);
				}
				return r_AddEventHandler_Object_Delegate;
			}
		}

		/// <summary>
		/// Void AddEventFrame[T,D](AddEvent`2, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_AddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object;
		public static RMethod RAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object
		{
			get
			{
				if(r_AddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object == null)
				{
					r_AddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object = new(typeof(System.Reflection.EventInfo), "AddEventFrame", 2,  ReflectionUtils.GetType("System.Reflection.EventInfo+AddEvent`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(System.Object), typeof(System.Object));
					r_AddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object.SetBelong(null);
				}
				return r_AddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object;
			}
		}

		/// <summary>
		/// Void StaticAddEventAdapterFrame[D](StaticAddEvent`1, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_StaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object;
		public static RMethod RStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object
		{
			get
			{
				if(r_StaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object == null)
				{
					r_StaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object = new(typeof(System.Reflection.EventInfo), "StaticAddEventAdapterFrame", 1,  ReflectionUtils.GetType("System.Reflection.EventInfo+StaticAddEvent`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Object));
					r_StaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object.SetBelong(null);
				}
				return r_StaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object;
			}
		}

		/// <summary>
		/// AddEventAdapter CreateAddEventDelegate(System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_CreateAddEventDelegate_MethodInfo;
		public static RMethod RCreateAddEventDelegate_MethodInfo
		{
			get
			{
				if(r_CreateAddEventDelegate_MethodInfo == null)
				{
					r_CreateAddEventDelegate_MethodInfo = new(typeof(System.Reflection.EventInfo), "CreateAddEventDelegate", 0, typeof(System.Reflection.MethodInfo));
					r_CreateAddEventDelegate_MethodInfo.SetBelong(null);
				}
				return r_CreateAddEventDelegate_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo internal_from_handle_type(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_internal_from_handle_type_IntPtr_IntPtr;
		public static RMethod Rinternal_from_handle_type_IntPtr_IntPtr
		{
			get
			{
				if(r_internal_from_handle_type_IntPtr_IntPtr == null)
				{
					r_internal_from_handle_type_IntPtr_IntPtr = new(typeof(System.Reflection.EventInfo), "internal_from_handle_type", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_internal_from_handle_type_IntPtr_IntPtr.SetBelong(null);
				}
				return r_internal_from_handle_type_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEventFromHandle(Mono.RuntimeEventHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_GetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle;
		public static RMethod RGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_GetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle == null)
				{
					r_GetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle = new(typeof(System.Reflection.EventInfo), "GetEventFromHandle", 0,  ReflectionUtils.GetType("Mono.RuntimeEventHandle"), typeof(System.RuntimeTypeHandle));
					r_GetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_GetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._EventInfo.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// System.Type System.Runtime.InteropServices._EventInfo.GetType()
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType = new(this, "System.Runtime.InteropServices._EventInfo.GetType", 0);
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._EventInfo.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._EventInfo.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._EventInfo.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_HasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_HasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_HasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_HasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_HasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_IsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_IsDefined_Type_Boolean == null)
				{
					r_IsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_IsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_IsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_GetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_GetCustomAttributes_Boolean == null)
				{
					r_GetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_GetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_GetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_GetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_GetCustomAttributes_Type_Boolean == null)
				{
					r_GetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_GetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_GetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_GetCustomAttributesData == null)
				{
					r_GetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_GetCustomAttributesData.SetBelong(this.instance);
				}
				return r_GetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_CacheEquals_Object;
		public virtual RMethod RCacheEquals_Object
		{
			get
			{
				if(r_CacheEquals_Object == null)
				{
					r_CacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_CacheEquals_Object.SetBelong(this.instance);
				}
				return r_CacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public REventInfo() : base("System.Reflection.EventInfo")
        {
        }

        public REventInfo(System.Object instance) : base("System.Reflection.EventInfo")
		{
            SetInstance(instance);
		}

        public REventInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Reflection.MethodInfo[] GetOtherMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOtherMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetOtherMethods(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetOtherMethods_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetAddMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAddMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRemoveMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRaiseMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetAddMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetAddMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetRemoveMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetRaiseMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual void RemoveEventHandler(System.Object  @target, System.Delegate  @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RRemoveEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.EventInfo  @left, System.Reflection.EventInfo  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_EventInfo_EventInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.EventInfo  @left, System.Reflection.EventInfo  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_EventInfo_EventInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddEventHandler(System.Object  @target, System.Delegate  @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RAddEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }




        public static System.Object CreateAddEventDelegate(System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RCreateAddEventDelegate_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Reflection.EventInfo internal_from_handle_type(System.IntPtr  @event_handle, System.IntPtr  @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@event_handle, @type_handle};
            var ___result = Rinternal_from_handle_type_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }



        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo  @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
