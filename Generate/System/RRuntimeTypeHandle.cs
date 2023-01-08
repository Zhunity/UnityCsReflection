using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.RuntimeTypeHandle
	/// </summary>
    public partial class RRuntimeTypeHandle : RMember //
    {

		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected RField r_value;
		public virtual RField Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value");
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
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
		/// Boolean Equals(System.RuntimeTypeHandle)
		/// </summary>
		protected RMethod r_Equals_RuntimeTypeHandle;
		public virtual RMethod REquals_RuntimeTypeHandle
		{
			get
			{
				if(r_Equals_RuntimeTypeHandle == null)
				{
					r_Equals_RuntimeTypeHandle = new(this, "Equals", 0, typeof(System.RuntimeTypeHandle));
					r_Equals_RuntimeTypeHandle.SetBelong(this.instance);
				}
				return r_Equals_RuntimeTypeHandle;
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
		/// Boolean op_Equality(System.RuntimeTypeHandle, System.Object)
		/// </summary>
		protected static RMethod r_op_Equality_RuntimeTypeHandle_Object;
		public static RMethod Rop_Equality_RuntimeTypeHandle_Object
		{
			get
			{
				if(r_op_Equality_RuntimeTypeHandle_Object == null)
				{
					r_op_Equality_RuntimeTypeHandle_Object = new(typeof(System.RuntimeTypeHandle), "op_Equality", 0, typeof(System.RuntimeTypeHandle), typeof(System.Object));
					r_op_Equality_RuntimeTypeHandle_Object.SetBelong(null);
				}
				return r_op_Equality_RuntimeTypeHandle_Object;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeTypeHandle, System.Object)
		/// </summary>
		protected static RMethod r_op_Inequality_RuntimeTypeHandle_Object;
		public static RMethod Rop_Inequality_RuntimeTypeHandle_Object
		{
			get
			{
				if(r_op_Inequality_RuntimeTypeHandle_Object == null)
				{
					r_op_Inequality_RuntimeTypeHandle_Object = new(typeof(System.RuntimeTypeHandle), "op_Inequality", 0, typeof(System.RuntimeTypeHandle), typeof(System.Object));
					r_op_Inequality_RuntimeTypeHandle_Object.SetBelong(null);
				}
				return r_op_Inequality_RuntimeTypeHandle_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Object, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_op_Equality_Object_RuntimeTypeHandle;
		public static RMethod Rop_Equality_Object_RuntimeTypeHandle
		{
			get
			{
				if(r_op_Equality_Object_RuntimeTypeHandle == null)
				{
					r_op_Equality_Object_RuntimeTypeHandle = new(typeof(System.RuntimeTypeHandle), "op_Equality", 0, typeof(System.Object), typeof(System.RuntimeTypeHandle));
					r_op_Equality_Object_RuntimeTypeHandle.SetBelong(null);
				}
				return r_op_Equality_Object_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Object, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_op_Inequality_Object_RuntimeTypeHandle;
		public static RMethod Rop_Inequality_Object_RuntimeTypeHandle
		{
			get
			{
				if(r_op_Inequality_Object_RuntimeTypeHandle == null)
				{
					r_op_Inequality_Object_RuntimeTypeHandle = new(typeof(System.RuntimeTypeHandle), "op_Inequality", 0, typeof(System.Object), typeof(System.RuntimeTypeHandle));
					r_op_Inequality_Object_RuntimeTypeHandle.SetBelong(null);
				}
				return r_op_Inequality_Object_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributes(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetAttributes_RuntimeType;
		public static RMethod RGetAttributes_RuntimeType
		{
			get
			{
				if(r_GetAttributes_RuntimeType == null)
				{
					r_GetAttributes_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetAttributes", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetAttributes_RuntimeType.SetBelong(null);
				}
				return r_GetAttributes_RuntimeType;
			}
		}

		/// <summary>
		/// System.ModuleHandle GetModuleHandle()
		/// </summary>
		protected RMethod r_GetModuleHandle;
		public virtual RMethod RGetModuleHandle
		{
			get
			{
				if(r_GetModuleHandle == null)
				{
					r_GetModuleHandle = new(this, "GetModuleHandle", 0);
					r_GetModuleHandle.SetBelong(this.instance);
				}
				return r_GetModuleHandle;
			}
		}

		/// <summary>
		/// Int32 GetMetadataToken(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetMetadataToken_RuntimeType;
		public static RMethod RGetMetadataToken_RuntimeType
		{
			get
			{
				if(r_GetMetadataToken_RuntimeType == null)
				{
					r_GetMetadataToken_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetMetadataToken", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetMetadataToken_RuntimeType.SetBelong(null);
				}
				return r_GetMetadataToken_RuntimeType;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetToken_RuntimeType;
		public static RMethod RGetToken_RuntimeType
		{
			get
			{
				if(r_GetToken_RuntimeType == null)
				{
					r_GetToken_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetToken", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetToken_RuntimeType.SetBelong(null);
				}
				return r_GetToken_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition_impl(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetGenericTypeDefinition_impl_RuntimeType;
		public static RMethod RGetGenericTypeDefinition_impl_RuntimeType
		{
			get
			{
				if(r_GetGenericTypeDefinition_impl_RuntimeType == null)
				{
					r_GetGenericTypeDefinition_impl_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetGenericTypeDefinition_impl", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetGenericTypeDefinition_impl_RuntimeType.SetBelong(null);
				}
				return r_GetGenericTypeDefinition_impl_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetGenericTypeDefinition_RuntimeType;
		public static RMethod RGetGenericTypeDefinition_RuntimeType
		{
			get
			{
				if(r_GetGenericTypeDefinition_RuntimeType == null)
				{
					r_GetGenericTypeDefinition_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetGenericTypeDefinition", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetGenericTypeDefinition_RuntimeType.SetBelong(null);
				}
				return r_GetGenericTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttribute(System.RuntimeType)
		/// </summary>
		protected static RMethod r_HasProxyAttribute_RuntimeType;
		public static RMethod RHasProxyAttribute_RuntimeType
		{
			get
			{
				if(r_HasProxyAttribute_RuntimeType == null)
				{
					r_HasProxyAttribute_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasProxyAttribute", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_HasProxyAttribute_RuntimeType.SetBelong(null);
				}
				return r_HasProxyAttribute_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsPrimitive_RuntimeType;
		public static RMethod RIsPrimitive_RuntimeType
		{
			get
			{
				if(r_IsPrimitive_RuntimeType == null)
				{
					r_IsPrimitive_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsPrimitive", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsPrimitive_RuntimeType.SetBelong(null);
				}
				return r_IsPrimitive_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsByRef(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsByRef_RuntimeType;
		public static RMethod RIsByRef_RuntimeType
		{
			get
			{
				if(r_IsByRef_RuntimeType == null)
				{
					r_IsByRef_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsByRef", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsByRef_RuntimeType.SetBelong(null);
				}
				return r_IsByRef_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsPointer(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsPointer_RuntimeType;
		public static RMethod RIsPointer_RuntimeType
		{
			get
			{
				if(r_IsPointer_RuntimeType == null)
				{
					r_IsPointer_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsPointer", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsPointer_RuntimeType.SetBelong(null);
				}
				return r_IsPointer_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsArray(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsArray_RuntimeType;
		public static RMethod RIsArray_RuntimeType
		{
			get
			{
				if(r_IsArray_RuntimeType == null)
				{
					r_IsArray_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsArray", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsArray_RuntimeType.SetBelong(null);
				}
				return r_IsArray_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsSzArray(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsSzArray_RuntimeType;
		public static RMethod RIsSzArray_RuntimeType
		{
			get
			{
				if(r_IsSzArray_RuntimeType == null)
				{
					r_IsSzArray_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsSzArray", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsSzArray_RuntimeType.SetBelong(null);
				}
				return r_IsSzArray_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_HasElementType_RuntimeType;
		public static RMethod RHasElementType_RuntimeType
		{
			get
			{
				if(r_HasElementType_RuntimeType == null)
				{
					r_HasElementType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasElementType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_HasElementType_RuntimeType.SetBelong(null);
				}
				return r_HasElementType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType GetCorElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetCorElementType_RuntimeType;
		public static RMethod RGetCorElementType_RuntimeType
		{
			get
			{
				if(r_GetCorElementType_RuntimeType == null)
				{
					r_GetCorElementType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetCorElementType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetCorElementType_RuntimeType.SetBelong(null);
				}
				return r_GetCorElementType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasInstantiation(System.RuntimeType)
		/// </summary>
		protected static RMethod r_HasInstantiation_RuntimeType;
		public static RMethod RHasInstantiation_RuntimeType
		{
			get
			{
				if(r_HasInstantiation_RuntimeType == null)
				{
					r_HasInstantiation_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasInstantiation", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_HasInstantiation_RuntimeType.SetBelong(null);
				}
				return r_HasInstantiation_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsComObject(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsComObject_RuntimeType;
		public static RMethod RIsComObject_RuntimeType
		{
			get
			{
				if(r_IsComObject_RuntimeType == null)
				{
					r_IsComObject_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsComObject", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsComObject_RuntimeType.SetBelong(null);
				}
				return r_IsComObject_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.RuntimeType, System.Object)
		/// </summary>
		protected static RMethod r_IsInstanceOfType_RuntimeType_Object;
		public static RMethod RIsInstanceOfType_RuntimeType_Object
		{
			get
			{
				if(r_IsInstanceOfType_RuntimeType_Object == null)
				{
					r_IsInstanceOfType_RuntimeType_Object = new(typeof(System.RuntimeTypeHandle), "IsInstanceOfType", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Object));
					r_IsInstanceOfType_RuntimeType_Object.SetBelong(null);
				}
				return r_IsInstanceOfType_RuntimeType_Object;
			}
		}

		/// <summary>
		/// Boolean HasReferences(System.RuntimeType)
		/// </summary>
		protected static RMethod r_HasReferences_RuntimeType;
		public static RMethod RHasReferences_RuntimeType
		{
			get
			{
				if(r_HasReferences_RuntimeType == null)
				{
					r_HasReferences_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasReferences", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_HasReferences_RuntimeType.SetBelong(null);
				}
				return r_HasReferences_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsComObject(System.RuntimeType, Boolean)
		/// </summary>
		protected static RMethod r_IsComObject_RuntimeType_Boolean;
		public static RMethod RIsComObject_RuntimeType_Boolean
		{
			get
			{
				if(r_IsComObject_RuntimeType_Boolean == null)
				{
					r_IsComObject_RuntimeType_Boolean = new(typeof(System.RuntimeTypeHandle), "IsComObject", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Boolean));
					r_IsComObject_RuntimeType_Boolean.SetBelong(null);
				}
				return r_IsComObject_RuntimeType_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsContextful(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsContextful_RuntimeType;
		public static RMethod RIsContextful_RuntimeType
		{
			get
			{
				if(r_IsContextful_RuntimeType == null)
				{
					r_IsContextful_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsContextful", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsContextful_RuntimeType.SetBelong(null);
				}
				return r_IsContextful_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsEquivalentTo_RuntimeType_RuntimeType;
		public static RMethod RIsEquivalentTo_RuntimeType_RuntimeType
		{
			get
			{
				if(r_IsEquivalentTo_RuntimeType_RuntimeType == null)
				{
					r_IsEquivalentTo_RuntimeType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsEquivalentTo", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsEquivalentTo_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_IsEquivalentTo_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsInterface(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsInterface_RuntimeType;
		public static RMethod RIsInterface_RuntimeType
		{
			get
			{
				if(r_IsInterface_RuntimeType == null)
				{
					r_IsInterface_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsInterface", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsInterface_RuntimeType.SetBelong(null);
				}
				return r_IsInterface_RuntimeType;
			}
		}

		/// <summary>
		/// Int32 GetArrayRank(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetArrayRank_RuntimeType;
		public static RMethod RGetArrayRank_RuntimeType
		{
			get
			{
				if(r_GetArrayRank_RuntimeType == null)
				{
					r_GetArrayRank_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetArrayRank", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetArrayRank_RuntimeType.SetBelong(null);
				}
				return r_GetArrayRank_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly GetAssembly(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetAssembly_RuntimeType;
		public static RMethod RGetAssembly_RuntimeType
		{
			get
			{
				if(r_GetAssembly_RuntimeType == null)
				{
					r_GetAssembly_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetAssembly", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetAssembly_RuntimeType.SetBelong(null);
				}
				return r_GetAssembly_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType GetElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetElementType_RuntimeType;
		public static RMethod RGetElementType_RuntimeType
		{
			get
			{
				if(r_GetElementType_RuntimeType == null)
				{
					r_GetElementType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetElementType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetElementType_RuntimeType.SetBelong(null);
				}
				return r_GetElementType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeModule GetModule(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetModule_RuntimeType;
		public static RMethod RGetModule_RuntimeType
		{
			get
			{
				if(r_GetModule_RuntimeType == null)
				{
					r_GetModule_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetModule", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetModule_RuntimeType.SetBelong(null);
				}
				return r_GetModule_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsGenericVariable(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsGenericVariable_RuntimeType;
		public static RMethod RIsGenericVariable_RuntimeType
		{
			get
			{
				if(r_IsGenericVariable_RuntimeType == null)
				{
					r_IsGenericVariable_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsGenericVariable", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsGenericVariable_RuntimeType.SetBelong(null);
				}
				return r_IsGenericVariable_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType GetBaseType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetBaseType_RuntimeType;
		public static RMethod RGetBaseType_RuntimeType
		{
			get
			{
				if(r_GetBaseType_RuntimeType == null)
				{
					r_GetBaseType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetBaseType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetBaseType_RuntimeType.SetBelong(null);
				}
				return r_GetBaseType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean CanCastTo(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_CanCastTo_RuntimeType_RuntimeType;
		public static RMethod RCanCastTo_RuntimeType_RuntimeType
		{
			get
			{
				if(r_CanCastTo_RuntimeType_RuntimeType == null)
				{
					r_CanCastTo_RuntimeType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "CanCastTo", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_CanCastTo_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_CanCastTo_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean type_is_assignable_from(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_type_is_assignable_from_Type_Type;
		public static RMethod Rtype_is_assignable_from_Type_Type
		{
			get
			{
				if(r_type_is_assignable_from_Type_Type == null)
				{
					r_type_is_assignable_from_Type_Type = new(typeof(System.RuntimeTypeHandle), "type_is_assignable_from", 0, typeof(System.Type), typeof(System.Type));
					r_type_is_assignable_from_Type_Type.SetBelong(null);
				}
				return r_type_is_assignable_from_Type_Type;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsGenericTypeDefinition_RuntimeType;
		public static RMethod RIsGenericTypeDefinition_RuntimeType
		{
			get
			{
				if(r_IsGenericTypeDefinition_RuntimeType == null)
				{
					r_IsGenericTypeDefinition_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsGenericTypeDefinition", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsGenericTypeDefinition_RuntimeType.SetBelong(null);
				}
				return r_IsGenericTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// IntPtr GetGenericParameterInfo(System.RuntimeType)
		/// </summary>
		protected static RMethod r_GetGenericParameterInfo_RuntimeType;
		public static RMethod RGetGenericParameterInfo_RuntimeType
		{
			get
			{
				if(r_GetGenericParameterInfo_RuntimeType == null)
				{
					r_GetGenericParameterInfo_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetGenericParameterInfo", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_GetGenericParameterInfo_RuntimeType.SetBelong(null);
				}
				return r_GetGenericParameterInfo_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsSubclassOf_RuntimeType_RuntimeType;
		public static RMethod RIsSubclassOf_RuntimeType_RuntimeType
		{
			get
			{
				if(r_IsSubclassOf_RuntimeType_RuntimeType == null)
				{
					r_IsSubclassOf_RuntimeType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsSubclassOf", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsSubclassOf_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_IsSubclassOf_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean is_subclass_of(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_is_subclass_of_IntPtr_IntPtr;
		public static RMethod Ris_subclass_of_IntPtr_IntPtr
		{
			get
			{
				if(r_is_subclass_of_IntPtr_IntPtr == null)
				{
					r_is_subclass_of_IntPtr_IntPtr = new(typeof(System.RuntimeTypeHandle), "is_subclass_of", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_is_subclass_of_IntPtr_IntPtr.SetBelong(null);
				}
				return r_is_subclass_of_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsByRefLike_RuntimeType;
		public static RMethod RIsByRefLike_RuntimeType
		{
			get
			{
				if(r_IsByRefLike_RuntimeType == null)
				{
					r_IsByRefLike_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsByRefLike", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsByRefLike_RuntimeType.SetBelong(null);
				}
				return r_IsByRefLike_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_IsTypeDefinition_RuntimeType;
		public static RMethod RIsTypeDefinition_RuntimeType
		{
			get
			{
				if(r_IsTypeDefinition_RuntimeType == null)
				{
					r_IsTypeDefinition_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsTypeDefinition", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_IsTypeDefinition_RuntimeType.SetBelong(null);
				}
				return r_IsTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType internal_from_name(System.String, System.Threading.StackCrawlMark ByRef, System.Reflection.Assembly, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_internal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean;
		public static RMethod Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_internal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean == null)
				{
					r_internal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean = new(typeof(System.RuntimeTypeHandle), "internal_from_name", 0, typeof(System.String),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Reflection.Assembly), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_internal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_internal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.RuntimeType GetTypeByName(System.String, Boolean, Boolean, Boolean, System.Threading.StackCrawlMark ByRef, Boolean)
		/// </summary>
		protected static RMethod r_GetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean;
		public static RMethod RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean
		{
			get
			{
				if(r_GetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean == null)
				{
					r_GetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean = new(typeof(System.RuntimeTypeHandle), "GetTypeByName", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean));
					r_GetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean.SetBelong(null);
				}
				return r_GetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean;
			}
		}

		/// <summary>
		/// IntPtr[] CopyRuntimeTypeHandles(System.RuntimeTypeHandle[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_CopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32;
		public static RMethod RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32
		{
			get
			{
				if(r_CopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32 == null)
				{
					r_CopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32 = new(typeof(System.RuntimeTypeHandle), "CopyRuntimeTypeHandles", 0, typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_CopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32.SetBelong(null);
				}
				return r_CopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32;
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


        public RRuntimeTypeHandle() : base("System.RuntimeTypeHandle")
        {
        }

        public RRuntimeTypeHandle(System.Object instance) : base("System.RuntimeTypeHandle")
		{
            SetInstance(instance);
		}

        public RRuntimeTypeHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeTypeHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.RuntimeTypeHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = REquals_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.RuntimeTypeHandle  @left, System.Object  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_RuntimeTypeHandle_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.RuntimeTypeHandle  @left, System.Object  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_RuntimeTypeHandle_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Object  @left, System.RuntimeTypeHandle  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_Object_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Object  @left, System.RuntimeTypeHandle  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_Object_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Reflection.TypeAttributes GetAttributes(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetAttributes_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeAttributes)___result;
        }


        public virtual System.ModuleHandle GetModuleHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.ModuleHandle)___result;
        }


        public static System.Int32 GetMetadataToken(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetMetadataToken_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetToken(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetToken_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Type GetGenericTypeDefinition_impl(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetGenericTypeDefinition_impl_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetGenericTypeDefinition(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetGenericTypeDefinition_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Boolean HasProxyAttribute(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RHasProxyAttribute_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPrimitive(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsPrimitive_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsByRef(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsByRef_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsPointer(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsPointer_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsArray(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsArray_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSzArray(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsSzArray_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean HasElementType(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RHasElementType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object GetCorElementType(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetCorElementType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean HasInstantiation(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RHasInstantiation_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsComObject(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsComObject_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsInstanceOfType(RSystem.RRuntimeType  @type, System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @o};
            var ___result = RIsInstanceOfType_RuntimeType_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean HasReferences(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RHasReferences_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsComObject(RSystem.RRuntimeType  @type, System.Boolean  @isGenericCOM)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @isGenericCOM};
            var ___result = RIsComObject_RuntimeType_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsContextful(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsContextful_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsEquivalentTo(RSystem.RRuntimeType  @rtType1, RSystem.RRuntimeType  @rtType2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rtType1.Value, @rtType2.Value};
            var ___result = RIsEquivalentTo_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsInterface(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsInterface_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetArrayRank(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetArrayRank_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Object GetAssembly(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetAssembly_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object GetElementType(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetElementType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object GetModule(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetModule_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsGenericVariable(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsGenericVariable_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object GetBaseType(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetBaseType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean CanCastTo(RSystem.RRuntimeType  @type, RSystem.RRuntimeType  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @target.Value};
            var ___result = RCanCastTo_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean type_is_assignable_from(System.Type  @a, System.Type  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rtype_is_assignable_from_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsGenericTypeDefinition(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsGenericTypeDefinition_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.IntPtr GetGenericParameterInfo(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RGetGenericParameterInfo_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Boolean IsSubclassOf(RSystem.RRuntimeType  @childType, RSystem.RRuntimeType  @baseType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childType.Value, @baseType.Value};
            var ___result = RIsSubclassOf_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean is_subclass_of(System.IntPtr  @childType, System.IntPtr  @baseType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childType, @baseType};
            var ___result = Ris_subclass_of_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsByRefLike(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsByRefLike_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsTypeDefinition(RSystem.RRuntimeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RIsTypeDefinition_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object internal_from_name(System.String  @name, ref RType  @stackMark, System.Reflection.Assembly  @callerAssembly, System.Boolean  @throwOnError, System.Boolean  @ignoreCase, System.Boolean  @reflectionOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stackMark.Value, @callerAssembly, @throwOnError, @ignoreCase, @reflectionOnly};
            var ___result = Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = new RType(___parameters[1]);

            return (System.Object)___result;
        }


        public static System.Object GetTypeByName(System.String  @typeName, System.Boolean  @throwOnError, System.Boolean  @ignoreCase, System.Boolean  @reflectionOnly, ref RType  @stackMark, System.Boolean  @loadTypeFromPartialName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError, @ignoreCase, @reflectionOnly, @stackMark.Value, @loadTypeFromPartialName};
            var ___result = RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = new RType(___parameters[4]);

            return (System.Object)___result;
        }


        public static System.IntPtr[] CopyRuntimeTypeHandles(System.RuntimeTypeHandle[]  @inHandles, out System.Int32  @length)
        {
			@length = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inHandles, @length};
            var ___result = RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32.Invoke(___genericsType, ___parameters);
			@length = (System.Int32)___parameters[1];

            return (System.IntPtr[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
