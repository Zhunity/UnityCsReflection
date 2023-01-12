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
		protected RSystem.RReflection.REventInfo.RAddEventAdapter r_Fcached_add_event;
		public virtual RSystem.RReflection.REventInfo.RAddEventAdapter RFcached_add_event
		{
			get
			{
				if(r_Fcached_add_event == null)
				{
					r_Fcached_add_event = new(this, "cached_add_event");
					r_Fcached_add_event.SetBelong(this.instance);
				}
				return r_Fcached_add_event;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
					r_PMemberType.SetBelong(this.instance);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// System.Reflection.EventAttributes Attributes
		/// </summary>
		protected RSystem.RReflection.REventAttributes r_PAttributes;
		public virtual RSystem.RReflection.REventAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected RSystem.RBoolean r_PIsSpecialName;
		public virtual RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
					r_PIsSpecialName.SetBelong(this.instance);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo AddMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_PAddMethod;
		public virtual RSystem.RReflection.RMethodInfo RPAddMethod
		{
			get
			{
				if(r_PAddMethod == null)
				{
					r_PAddMethod = new(this, "AddMethod", -1);
					r_PAddMethod.SetBelong(this.instance);
				}
				return r_PAddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RemoveMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_PRemoveMethod;
		public virtual RSystem.RReflection.RMethodInfo RPRemoveMethod
		{
			get
			{
				if(r_PRemoveMethod == null)
				{
					r_PRemoveMethod = new(this, "RemoveMethod", -1);
					r_PRemoveMethod.SetBelong(this.instance);
				}
				return r_PRemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RaiseMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_PRaiseMethod;
		public virtual RSystem.RReflection.RMethodInfo RPRaiseMethod
		{
			get
			{
				if(r_PRaiseMethod == null)
				{
					r_PRaiseMethod = new(this, "RaiseMethod", -1);
					r_PRaiseMethod.SetBelong(this.instance);
				}
				return r_PRaiseMethod;
			}
		}

		/// <summary>
		/// Boolean IsMulticast
		/// </summary>
		protected RSystem.RBoolean r_PIsMulticast;
		public virtual RSystem.RBoolean RPIsMulticast
		{
			get
			{
				if(r_PIsMulticast == null)
				{
					r_PIsMulticast = new(this, "IsMulticast", -1);
					r_PIsMulticast.SetBelong(this.instance);
				}
				return r_PIsMulticast;
			}
		}

		/// <summary>
		/// System.Type EventHandlerType
		/// </summary>
		protected RSystem.RType r_PEventHandlerType;
		public virtual RSystem.RType RPEventHandlerType
		{
			get
			{
				if(r_PEventHandlerType == null)
				{
					r_PEventHandlerType = new(this, "EventHandlerType", -1);
					r_PEventHandlerType.SetBelong(this.instance);
				}
				return r_PEventHandlerType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_PName;
		public virtual RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected RSystem.RType r_PDeclaringType;
		public virtual RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
					r_PDeclaringType.SetBelong(this.instance);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_PReflectedType;
		public virtual RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
					r_PReflectedType.SetBelong(this.instance);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected RSystem.RReflection.RModule r_PModule;
		public virtual RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
					r_PModule.SetBelong(this.instance);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
					r_PCustomAttributes.SetBelong(this.instance);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected RSystem.RInt32 r_PMetadataToken;
		public virtual RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetOtherMethods()
		/// </summary>
		protected RMethod r_MGetOtherMethods;
		public virtual RMethod RMGetOtherMethods
		{
			get
			{
				if(r_MGetOtherMethods == null)
				{
					r_MGetOtherMethods = new(this, "GetOtherMethods", 0);
					r_MGetOtherMethods.SetBelong(this.instance);
				}
				return r_MGetOtherMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetOtherMethods(Boolean)
		/// </summary>
		protected RMethod r_MGetOtherMethods_Boolean;
		public virtual RMethod RMGetOtherMethods_Boolean
		{
			get
			{
				if(r_MGetOtherMethods_Boolean == null)
				{
					r_MGetOtherMethods_Boolean = new(this, "GetOtherMethods", 0, typeof(System.Boolean));
					r_MGetOtherMethods_Boolean.SetBelong(this.instance);
				}
				return r_MGetOtherMethods_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetAddMethod()
		/// </summary>
		protected RMethod r_MGetAddMethod;
		public virtual RMethod RMGetAddMethod
		{
			get
			{
				if(r_MGetAddMethod == null)
				{
					r_MGetAddMethod = new(this, "GetAddMethod", 0);
					r_MGetAddMethod.SetBelong(this.instance);
				}
				return r_MGetAddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRemoveMethod()
		/// </summary>
		protected RMethod r_MGetRemoveMethod;
		public virtual RMethod RMGetRemoveMethod
		{
			get
			{
				if(r_MGetRemoveMethod == null)
				{
					r_MGetRemoveMethod = new(this, "GetRemoveMethod", 0);
					r_MGetRemoveMethod.SetBelong(this.instance);
				}
				return r_MGetRemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRaiseMethod()
		/// </summary>
		protected RMethod r_MGetRaiseMethod;
		public virtual RMethod RMGetRaiseMethod
		{
			get
			{
				if(r_MGetRaiseMethod == null)
				{
					r_MGetRaiseMethod = new(this, "GetRaiseMethod", 0);
					r_MGetRaiseMethod.SetBelong(this.instance);
				}
				return r_MGetRaiseMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetAddMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetAddMethod_Boolean;
		public virtual RMethod RMGetAddMethod_Boolean
		{
			get
			{
				if(r_MGetAddMethod_Boolean == null)
				{
					r_MGetAddMethod_Boolean = new(this, "GetAddMethod", 0, typeof(System.Boolean));
					r_MGetAddMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetAddMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRemoveMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetRemoveMethod_Boolean;
		public virtual RMethod RMGetRemoveMethod_Boolean
		{
			get
			{
				if(r_MGetRemoveMethod_Boolean == null)
				{
					r_MGetRemoveMethod_Boolean = new(this, "GetRemoveMethod", 0, typeof(System.Boolean));
					r_MGetRemoveMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetRemoveMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRaiseMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetRaiseMethod_Boolean;
		public virtual RMethod RMGetRaiseMethod_Boolean
		{
			get
			{
				if(r_MGetRaiseMethod_Boolean == null)
				{
					r_MGetRaiseMethod_Boolean = new(this, "GetRaiseMethod", 0, typeof(System.Boolean));
					r_MGetRaiseMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetRaiseMethod_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveEventHandler(System.Object, System.Delegate)
		/// </summary>
		protected RMethod r_MRemoveEventHandler_Object_Delegate;
		public virtual RMethod RMRemoveEventHandler_Object_Delegate
		{
			get
			{
				if(r_MRemoveEventHandler_Object_Delegate == null)
				{
					r_MRemoveEventHandler_Object_Delegate = new(this, "RemoveEventHandler", 0, typeof(System.Object), typeof(System.Delegate));
					r_MRemoveEventHandler_Object_Delegate.SetBelong(this.instance);
				}
				return r_MRemoveEventHandler_Object_Delegate;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.EventInfo, System.Reflection.EventInfo)
		/// </summary>
		protected static RMethod r_Mop_Equality_EventInfo_EventInfo;
		public static RMethod RMop_Equality_EventInfo_EventInfo
		{
			get
			{
				if(r_Mop_Equality_EventInfo_EventInfo == null)
				{
					r_Mop_Equality_EventInfo_EventInfo = new(typeof(System.Reflection.EventInfo), "op_Equality", 0, typeof(System.Reflection.EventInfo), typeof(System.Reflection.EventInfo));
					r_Mop_Equality_EventInfo_EventInfo.SetBelong(null);
				}
				return r_Mop_Equality_EventInfo_EventInfo;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.EventInfo, System.Reflection.EventInfo)
		/// </summary>
		protected static RMethod r_Mop_Inequality_EventInfo_EventInfo;
		public static RMethod RMop_Inequality_EventInfo_EventInfo
		{
			get
			{
				if(r_Mop_Inequality_EventInfo_EventInfo == null)
				{
					r_Mop_Inequality_EventInfo_EventInfo = new(typeof(System.Reflection.EventInfo), "op_Inequality", 0, typeof(System.Reflection.EventInfo), typeof(System.Reflection.EventInfo));
					r_Mop_Inequality_EventInfo_EventInfo.SetBelong(null);
				}
				return r_Mop_Inequality_EventInfo_EventInfo;
			}
		}

		/// <summary>
		/// Void AddEventHandler(System.Object, System.Delegate)
		/// </summary>
		protected RMethod r_MAddEventHandler_Object_Delegate;
		public virtual RMethod RMAddEventHandler_Object_Delegate
		{
			get
			{
				if(r_MAddEventHandler_Object_Delegate == null)
				{
					r_MAddEventHandler_Object_Delegate = new(this, "AddEventHandler", 0, typeof(System.Object), typeof(System.Delegate));
					r_MAddEventHandler_Object_Delegate.SetBelong(this.instance);
				}
				return r_MAddEventHandler_Object_Delegate;
			}
		}

		/// <summary>
		/// Void AddEventFrame[T,D](AddEvent`2, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object;
		public static RMethod RMAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object
		{
			get
			{
				if(r_MAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object == null)
				{
					r_MAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object = new(typeof(System.Reflection.EventInfo), "AddEventFrame", 2,  ReflectionUtils.GetType("System.Reflection.EventInfo+AddEvent`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(System.Object), typeof(System.Object));
					r_MAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object.SetBelong(null);
				}
				return r_MAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object;
			}
		}

		/// <summary>
		/// Void StaticAddEventAdapterFrame[D](StaticAddEvent`1, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object;
		public static RMethod RMStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object
		{
			get
			{
				if(r_MStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object == null)
				{
					r_MStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object = new(typeof(System.Reflection.EventInfo), "StaticAddEventAdapterFrame", 1,  ReflectionUtils.GetType("System.Reflection.EventInfo+StaticAddEvent`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Object));
					r_MStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object.SetBelong(null);
				}
				return r_MStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object;
			}
		}

		/// <summary>
		/// AddEventAdapter CreateAddEventDelegate(System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_MCreateAddEventDelegate_MethodInfo;
		public static RMethod RMCreateAddEventDelegate_MethodInfo
		{
			get
			{
				if(r_MCreateAddEventDelegate_MethodInfo == null)
				{
					r_MCreateAddEventDelegate_MethodInfo = new(typeof(System.Reflection.EventInfo), "CreateAddEventDelegate", 0, typeof(System.Reflection.MethodInfo));
					r_MCreateAddEventDelegate_MethodInfo.SetBelong(null);
				}
				return r_MCreateAddEventDelegate_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo internal_from_handle_type(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Minternal_from_handle_type_IntPtr_IntPtr;
		public static RMethod RMinternal_from_handle_type_IntPtr_IntPtr
		{
			get
			{
				if(r_Minternal_from_handle_type_IntPtr_IntPtr == null)
				{
					r_Minternal_from_handle_type_IntPtr_IntPtr = new(typeof(System.Reflection.EventInfo), "internal_from_handle_type", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_Minternal_from_handle_type_IntPtr_IntPtr.SetBelong(null);
				}
				return r_Minternal_from_handle_type_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEventFromHandle(Mono.RuntimeEventHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_MGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle;
		public static RMethod RMGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_MGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle == null)
				{
					r_MGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle = new(typeof(System.Reflection.EventInfo), "GetEventFromHandle", 0,  ReflectionUtils.GetType("Mono.RuntimeEventHandle"), typeof(System.RuntimeTypeHandle));
					r_MGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_MGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._EventInfo.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// System.Type System.Runtime.InteropServices._EventInfo.GetType()
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType = new(this, "System.Runtime.InteropServices._EventInfo.GetType", 0);
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._EventInfo.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._EventInfo.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventInfo.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._EventInfo.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MIsDefined_Type_Boolean;
		public virtual RMethod RMIsDefined_Type_Boolean
		{
			get
			{
				if(r_MIsDefined_Type_Boolean == null)
				{
					r_MIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_MIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Boolean;
		public virtual RMethod RMGetCustomAttributes_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Boolean == null)
				{
					r_MGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_MGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Type_Boolean;
		public virtual RMethod RMGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Type_Boolean == null)
				{
					r_MGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetCustomAttributesData;
		public virtual RMethod RMGetCustomAttributesData
		{
			get
			{
				if(r_MGetCustomAttributesData == null)
				{
					r_MGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_MGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_MCacheEquals_Object;
		public virtual RMethod RMCacheEquals_Object
		{
			get
			{
				if(r_MCacheEquals_Object == null)
				{
					r_MCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_MCacheEquals_Object.SetBelong(this.instance);
				}
				return r_MCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMGetOtherMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetOtherMethods(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetOtherMethods_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetAddMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAddMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRemoveMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRaiseMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetAddMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetAddMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetRemoveMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetRaiseMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual void RemoveEventHandler(System.Object @target, System.Delegate @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RMRemoveEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.EventInfo @left, System.Reflection.EventInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_EventInfo_EventInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.EventInfo @left, System.Reflection.EventInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_EventInfo_EventInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddEventHandler(System.Object @target, System.Delegate @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RMAddEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddEventFrame<T, D>(RSystem.RReflection.REventInfo.RAddEvent<RType, RType> @addEvent, System.Object @obj, System.Object @dele)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(D)};
            var ___parameters = new object[]{@addEvent.Value, @obj, @dele};
            var ___result = RMAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void StaticAddEventAdapterFrame<D>(RSystem.RReflection.REventInfo.RStaticAddEvent<RType> @addEvent, System.Object @obj, System.Object @dele)
        {

            var ___genericsType = new Type[] {typeof(D)};
            var ___parameters = new object[]{@addEvent.Value, @obj, @dele};
            var ___result = RMStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static RSystem.RReflection.REventInfo.RAddEventAdapter CreateAddEventDelegate(System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RMCreateAddEventDelegate_MethodInfo.Invoke(___genericsType, ___parameters);

            return new RSystem.RReflection.REventInfo.RAddEventAdapter(___result);
        }


        public static System.Reflection.EventInfo internal_from_handle_type(System.IntPtr @event_handle, System.IntPtr @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@event_handle, @type_handle};
            var ___result = RMinternal_from_handle_type_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public static System.Reflection.EventInfo GetEventFromHandle(RMono.RRuntimeEventHandle @handle, System.RuntimeTypeHandle @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @reflectedType};
            var ___result = RMGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type System__2__Runtime__2__InteropServices__2___EventInfo__2__GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___EventInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
