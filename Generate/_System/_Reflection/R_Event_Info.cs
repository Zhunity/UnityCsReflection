
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.EventInfo
	/// </summary>
    public partial class REventInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.EventInfo);
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


		/// <summary>
		/// System.Reflection.EventInfo+AddEventAdapter cached_add_event
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo.RAddEventAdapter r_Fcached_add_event;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo.RAddEventAdapter RFcached_add_event
		{
			get
			{
				if(r_Fcached_add_event == null)
				{
					r_Fcached_add_event = new(this, "cached_add_event");
				}
				return r_Fcached_add_event;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// System.Reflection.EventAttributes Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REventAttributes r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REventAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSpecialName;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo AddMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PAddMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPAddMethod
		{
			get
			{
				if(r_PAddMethod == null)
				{
					r_PAddMethod = new(this, "AddMethod", -1);
				}
				return r_PAddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RemoveMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PRemoveMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPRemoveMethod
		{
			get
			{
				if(r_PRemoveMethod == null)
				{
					r_PRemoveMethod = new(this, "RemoveMethod", -1);
				}
				return r_PRemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RaiseMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PRaiseMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPRaiseMethod
		{
			get
			{
				if(r_PRaiseMethod == null)
				{
					r_PRaiseMethod = new(this, "RaiseMethod", -1);
				}
				return r_PRaiseMethod;
			}
		}

		/// <summary>
		/// Boolean IsMulticast
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMulticast;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMulticast
		{
			get
			{
				if(r_PIsMulticast == null)
				{
					r_PIsMulticast = new(this, "IsMulticast", -1);
				}
				return r_PIsMulticast;
			}
		}

		/// <summary>
		/// System.Type EventHandlerType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PEventHandlerType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPEventHandlerType
		{
			get
			{
				if(r_PEventHandlerType == null)
				{
					r_PEventHandlerType = new(this, "EventHandlerType", -1);
				}
				return r_PEventHandlerType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PDeclaringType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PReflectedType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RModule r_PModule;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMetadataToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
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
					r_Mop_Equality_EventInfo_EventInfo = new(Type, "op_Equality", 0, typeof(System.Reflection.EventInfo), typeof(System.Reflection.EventInfo));
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
					r_Mop_Inequality_EventInfo_EventInfo = new(Type, "op_Inequality", 0, typeof(System.Reflection.EventInfo), typeof(System.Reflection.EventInfo));
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
					r_MAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object = new(Type, "AddEventFrame", 2,  ReflectionUtils.GetType("System.Reflection.EventInfo+AddEvent`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(System.Object), typeof(System.Object));
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
					r_MStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object = new(Type, "StaticAddEventAdapterFrame", 1,  ReflectionUtils.GetType("System.Reflection.EventInfo+StaticAddEvent`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Object), typeof(System.Object));
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
					r_MCreateAddEventDelegate_MethodInfo = new(Type, "CreateAddEventDelegate", 0, typeof(System.Reflection.MethodInfo));
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
					r_Minternal_from_handle_type_IntPtr_IntPtr = new(Type, "internal_from_handle_type", 0, typeof(System.IntPtr), typeof(System.IntPtr));
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
					r_MGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle = new(Type, "GetEventFromHandle", 0,  ReflectionUtils.GetType("Mono.RuntimeEventHandle"), typeof(System.RuntimeTypeHandle));
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


        public virtual System.Reflection.MethodInfo[] GetOtherMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOtherMethods.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo[]>(___result);
        }


        public virtual System.Reflection.MethodInfo[] GetOtherMethods(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetOtherMethods_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo[]>(___result);
        }


        public virtual System.Reflection.MethodInfo GetAddMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAddMethod.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRemoveMethod.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRaiseMethod.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetAddMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetAddMethod_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetRemoveMethod_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetRaiseMethod_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.Reflection.EventInfo @left, System.Reflection.EventInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_EventInfo_EventInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Reflection.EventInfo @left, System.Reflection.EventInfo @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_EventInfo_EventInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void AddEventHandler(System.Object @target, System.Delegate @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RMAddEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddEventFrame<T, D>(Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo.RAddEvent<Hvak.Editor.Refleaction.RType, Hvak.Editor.Refleaction.RType> @addEvent, System.Object @obj, System.Object @dele)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(D)};
            var ___parameters = new object[]{@addEvent.Value, @obj, @dele};
            var ___result = RMAddEventFrame_GT_GD_AddEvent_d_T_D_p__Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static void StaticAddEventAdapterFrame<D>(Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo.RStaticAddEvent<Hvak.Editor.Refleaction.RType> @addEvent, System.Object @obj, System.Object @dele)
        {

            var ___genericsType = new Type[] {typeof(D)};
            var ___parameters = new object[]{@addEvent.Value, @obj, @dele};
            var ___result = RMStaticAddEventAdapterFrame_GD_StaticAddEvent_d_D_p__Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo.RAddEventAdapter CreateAddEventDelegate(System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RMCreateAddEventDelegate_MethodInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo.RAddEventAdapter>(___result);
        }


        public static System.Reflection.EventInfo internal_from_handle_type(System.IntPtr @event_handle, System.IntPtr @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@event_handle, @type_handle};
            var ___result = RMinternal_from_handle_type_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.EventInfo>(___result);
        }


        public static System.Reflection.EventInfo GetEventFromHandle(Hvak.Editor.Refleaction.RMono.RRuntimeEventHandle @handle, System.RuntimeTypeHandle @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @reflectedType};
            var ___result = RMGetEventFromHandle_RuntimeEventHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.EventInfo>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
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
			@pcTInfo = ReflectionUtils.Convert<System.UInt32>(___parameters[0]);

            
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(___result);
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
