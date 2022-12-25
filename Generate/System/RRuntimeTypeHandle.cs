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
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
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
		/// Boolean Equals(System.RuntimeTypeHandle)
		/// </summary>
		protected RMethod r_REquals_RuntimeTypeHandle;
		public virtual RMethod REquals_RuntimeTypeHandle
		{
			get
			{
				if(r_REquals_RuntimeTypeHandle == null)
				{
					r_REquals_RuntimeTypeHandle = new(this, "Equals", 0, typeof(System.RuntimeTypeHandle));
					r_REquals_RuntimeTypeHandle.SetBelong(this.instance);
				}
				return r_REquals_RuntimeTypeHandle;
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
		/// Boolean op_Equality(System.RuntimeTypeHandle, System.Object)
		/// </summary>
		protected static RMethod r_Rop_Equality_RuntimeTypeHandle_Object;
		public static RMethod Rop_Equality_RuntimeTypeHandle_Object
		{
			get
			{
				if(r_Rop_Equality_RuntimeTypeHandle_Object == null)
				{
					r_Rop_Equality_RuntimeTypeHandle_Object = new(typeof(System.RuntimeTypeHandle), "op_Equality", 0, typeof(System.RuntimeTypeHandle), typeof(System.Object));
					r_Rop_Equality_RuntimeTypeHandle_Object.SetBelong(null);
				}
				return r_Rop_Equality_RuntimeTypeHandle_Object;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeTypeHandle, System.Object)
		/// </summary>
		protected static RMethod r_Rop_Inequality_RuntimeTypeHandle_Object;
		public static RMethod Rop_Inequality_RuntimeTypeHandle_Object
		{
			get
			{
				if(r_Rop_Inequality_RuntimeTypeHandle_Object == null)
				{
					r_Rop_Inequality_RuntimeTypeHandle_Object = new(typeof(System.RuntimeTypeHandle), "op_Inequality", 0, typeof(System.RuntimeTypeHandle), typeof(System.Object));
					r_Rop_Inequality_RuntimeTypeHandle_Object.SetBelong(null);
				}
				return r_Rop_Inequality_RuntimeTypeHandle_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Object, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_Rop_Equality_Object_RuntimeTypeHandle;
		public static RMethod Rop_Equality_Object_RuntimeTypeHandle
		{
			get
			{
				if(r_Rop_Equality_Object_RuntimeTypeHandle == null)
				{
					r_Rop_Equality_Object_RuntimeTypeHandle = new(typeof(System.RuntimeTypeHandle), "op_Equality", 0, typeof(System.Object), typeof(System.RuntimeTypeHandle));
					r_Rop_Equality_Object_RuntimeTypeHandle.SetBelong(null);
				}
				return r_Rop_Equality_Object_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Object, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Object_RuntimeTypeHandle;
		public static RMethod Rop_Inequality_Object_RuntimeTypeHandle
		{
			get
			{
				if(r_Rop_Inequality_Object_RuntimeTypeHandle == null)
				{
					r_Rop_Inequality_Object_RuntimeTypeHandle = new(typeof(System.RuntimeTypeHandle), "op_Inequality", 0, typeof(System.Object), typeof(System.RuntimeTypeHandle));
					r_Rop_Inequality_Object_RuntimeTypeHandle.SetBelong(null);
				}
				return r_Rop_Inequality_Object_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributes(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetAttributes_RuntimeType;
		public static RMethod RGetAttributes_RuntimeType
		{
			get
			{
				if(r_RGetAttributes_RuntimeType == null)
				{
					r_RGetAttributes_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetAttributes", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetAttributes_RuntimeType.SetBelong(null);
				}
				return r_RGetAttributes_RuntimeType;
			}
		}

		/// <summary>
		/// System.ModuleHandle GetModuleHandle()
		/// </summary>
		protected RMethod r_RGetModuleHandle;
		public virtual RMethod RGetModuleHandle
		{
			get
			{
				if(r_RGetModuleHandle == null)
				{
					r_RGetModuleHandle = new(this, "GetModuleHandle", 0);
					r_RGetModuleHandle.SetBelong(this.instance);
				}
				return r_RGetModuleHandle;
			}
		}

		/// <summary>
		/// Int32 GetMetadataToken(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetMetadataToken_RuntimeType;
		public static RMethod RGetMetadataToken_RuntimeType
		{
			get
			{
				if(r_RGetMetadataToken_RuntimeType == null)
				{
					r_RGetMetadataToken_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetMetadataToken", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetMetadataToken_RuntimeType.SetBelong(null);
				}
				return r_RGetMetadataToken_RuntimeType;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetToken_RuntimeType;
		public static RMethod RGetToken_RuntimeType
		{
			get
			{
				if(r_RGetToken_RuntimeType == null)
				{
					r_RGetToken_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetToken", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetToken_RuntimeType.SetBelong(null);
				}
				return r_RGetToken_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition_impl(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetGenericTypeDefinition_impl_RuntimeType;
		public static RMethod RGetGenericTypeDefinition_impl_RuntimeType
		{
			get
			{
				if(r_RGetGenericTypeDefinition_impl_RuntimeType == null)
				{
					r_RGetGenericTypeDefinition_impl_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetGenericTypeDefinition_impl", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetGenericTypeDefinition_impl_RuntimeType.SetBelong(null);
				}
				return r_RGetGenericTypeDefinition_impl_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetGenericTypeDefinition_RuntimeType;
		public static RMethod RGetGenericTypeDefinition_RuntimeType
		{
			get
			{
				if(r_RGetGenericTypeDefinition_RuntimeType == null)
				{
					r_RGetGenericTypeDefinition_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetGenericTypeDefinition", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetGenericTypeDefinition_RuntimeType.SetBelong(null);
				}
				return r_RGetGenericTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttribute(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RHasProxyAttribute_RuntimeType;
		public static RMethod RHasProxyAttribute_RuntimeType
		{
			get
			{
				if(r_RHasProxyAttribute_RuntimeType == null)
				{
					r_RHasProxyAttribute_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasProxyAttribute", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RHasProxyAttribute_RuntimeType.SetBelong(null);
				}
				return r_RHasProxyAttribute_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsPrimitive_RuntimeType;
		public static RMethod RIsPrimitive_RuntimeType
		{
			get
			{
				if(r_RIsPrimitive_RuntimeType == null)
				{
					r_RIsPrimitive_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsPrimitive", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsPrimitive_RuntimeType.SetBelong(null);
				}
				return r_RIsPrimitive_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsByRef(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsByRef_RuntimeType;
		public static RMethod RIsByRef_RuntimeType
		{
			get
			{
				if(r_RIsByRef_RuntimeType == null)
				{
					r_RIsByRef_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsByRef", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsByRef_RuntimeType.SetBelong(null);
				}
				return r_RIsByRef_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsPointer(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsPointer_RuntimeType;
		public static RMethod RIsPointer_RuntimeType
		{
			get
			{
				if(r_RIsPointer_RuntimeType == null)
				{
					r_RIsPointer_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsPointer", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsPointer_RuntimeType.SetBelong(null);
				}
				return r_RIsPointer_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsArray(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsArray_RuntimeType;
		public static RMethod RIsArray_RuntimeType
		{
			get
			{
				if(r_RIsArray_RuntimeType == null)
				{
					r_RIsArray_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsArray", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsArray_RuntimeType.SetBelong(null);
				}
				return r_RIsArray_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsSzArray(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsSzArray_RuntimeType;
		public static RMethod RIsSzArray_RuntimeType
		{
			get
			{
				if(r_RIsSzArray_RuntimeType == null)
				{
					r_RIsSzArray_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsSzArray", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsSzArray_RuntimeType.SetBelong(null);
				}
				return r_RIsSzArray_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RHasElementType_RuntimeType;
		public static RMethod RHasElementType_RuntimeType
		{
			get
			{
				if(r_RHasElementType_RuntimeType == null)
				{
					r_RHasElementType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasElementType", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RHasElementType_RuntimeType.SetBelong(null);
				}
				return r_RHasElementType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType GetCorElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetCorElementType_RuntimeType;
		public static RMethod RGetCorElementType_RuntimeType
		{
			get
			{
				if(r_RGetCorElementType_RuntimeType == null)
				{
					r_RGetCorElementType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetCorElementType", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetCorElementType_RuntimeType.SetBelong(null);
				}
				return r_RGetCorElementType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasInstantiation(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RHasInstantiation_RuntimeType;
		public static RMethod RHasInstantiation_RuntimeType
		{
			get
			{
				if(r_RHasInstantiation_RuntimeType == null)
				{
					r_RHasInstantiation_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasInstantiation", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RHasInstantiation_RuntimeType.SetBelong(null);
				}
				return r_RHasInstantiation_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsComObject(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsComObject_RuntimeType;
		public static RMethod RIsComObject_RuntimeType
		{
			get
			{
				if(r_RIsComObject_RuntimeType == null)
				{
					r_RIsComObject_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsComObject", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsComObject_RuntimeType.SetBelong(null);
				}
				return r_RIsComObject_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.RuntimeType, System.Object)
		/// </summary>
		protected static RMethod r_RIsInstanceOfType_RuntimeType_Object;
		public static RMethod RIsInstanceOfType_RuntimeType_Object
		{
			get
			{
				if(r_RIsInstanceOfType_RuntimeType_Object == null)
				{
					r_RIsInstanceOfType_RuntimeType_Object = new(typeof(System.RuntimeTypeHandle), "IsInstanceOfType", 0,  ReleactionUtils.GetType("System.RuntimeType"), typeof(System.Object));
					r_RIsInstanceOfType_RuntimeType_Object.SetBelong(null);
				}
				return r_RIsInstanceOfType_RuntimeType_Object;
			}
		}

		/// <summary>
		/// Boolean HasReferences(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RHasReferences_RuntimeType;
		public static RMethod RHasReferences_RuntimeType
		{
			get
			{
				if(r_RHasReferences_RuntimeType == null)
				{
					r_RHasReferences_RuntimeType = new(typeof(System.RuntimeTypeHandle), "HasReferences", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RHasReferences_RuntimeType.SetBelong(null);
				}
				return r_RHasReferences_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsComObject(System.RuntimeType, Boolean)
		/// </summary>
		protected static RMethod r_RIsComObject_RuntimeType_Boolean;
		public static RMethod RIsComObject_RuntimeType_Boolean
		{
			get
			{
				if(r_RIsComObject_RuntimeType_Boolean == null)
				{
					r_RIsComObject_RuntimeType_Boolean = new(typeof(System.RuntimeTypeHandle), "IsComObject", 0,  ReleactionUtils.GetType("System.RuntimeType"), typeof(System.Boolean));
					r_RIsComObject_RuntimeType_Boolean.SetBelong(null);
				}
				return r_RIsComObject_RuntimeType_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsContextful(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsContextful_RuntimeType;
		public static RMethod RIsContextful_RuntimeType
		{
			get
			{
				if(r_RIsContextful_RuntimeType == null)
				{
					r_RIsContextful_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsContextful", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsContextful_RuntimeType.SetBelong(null);
				}
				return r_RIsContextful_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsEquivalentTo_RuntimeType_RuntimeType;
		public static RMethod RIsEquivalentTo_RuntimeType_RuntimeType
		{
			get
			{
				if(r_RIsEquivalentTo_RuntimeType_RuntimeType == null)
				{
					r_RIsEquivalentTo_RuntimeType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsEquivalentTo", 0,  ReleactionUtils.GetType("System.RuntimeType"),  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsEquivalentTo_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_RIsEquivalentTo_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsInterface(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsInterface_RuntimeType;
		public static RMethod RIsInterface_RuntimeType
		{
			get
			{
				if(r_RIsInterface_RuntimeType == null)
				{
					r_RIsInterface_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsInterface", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsInterface_RuntimeType.SetBelong(null);
				}
				return r_RIsInterface_RuntimeType;
			}
		}

		/// <summary>
		/// Int32 GetArrayRank(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetArrayRank_RuntimeType;
		public static RMethod RGetArrayRank_RuntimeType
		{
			get
			{
				if(r_RGetArrayRank_RuntimeType == null)
				{
					r_RGetArrayRank_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetArrayRank", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetArrayRank_RuntimeType.SetBelong(null);
				}
				return r_RGetArrayRank_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly GetAssembly(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetAssembly_RuntimeType;
		public static RMethod RGetAssembly_RuntimeType
		{
			get
			{
				if(r_RGetAssembly_RuntimeType == null)
				{
					r_RGetAssembly_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetAssembly", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetAssembly_RuntimeType.SetBelong(null);
				}
				return r_RGetAssembly_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType GetElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetElementType_RuntimeType;
		public static RMethod RGetElementType_RuntimeType
		{
			get
			{
				if(r_RGetElementType_RuntimeType == null)
				{
					r_RGetElementType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetElementType", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetElementType_RuntimeType.SetBelong(null);
				}
				return r_RGetElementType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeModule GetModule(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetModule_RuntimeType;
		public static RMethod RGetModule_RuntimeType
		{
			get
			{
				if(r_RGetModule_RuntimeType == null)
				{
					r_RGetModule_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetModule", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetModule_RuntimeType.SetBelong(null);
				}
				return r_RGetModule_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsGenericVariable(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsGenericVariable_RuntimeType;
		public static RMethod RIsGenericVariable_RuntimeType
		{
			get
			{
				if(r_RIsGenericVariable_RuntimeType == null)
				{
					r_RIsGenericVariable_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsGenericVariable", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsGenericVariable_RuntimeType.SetBelong(null);
				}
				return r_RIsGenericVariable_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType GetBaseType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetBaseType_RuntimeType;
		public static RMethod RGetBaseType_RuntimeType
		{
			get
			{
				if(r_RGetBaseType_RuntimeType == null)
				{
					r_RGetBaseType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetBaseType", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetBaseType_RuntimeType.SetBelong(null);
				}
				return r_RGetBaseType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean CanCastTo(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_RCanCastTo_RuntimeType_RuntimeType;
		public static RMethod RCanCastTo_RuntimeType_RuntimeType
		{
			get
			{
				if(r_RCanCastTo_RuntimeType_RuntimeType == null)
				{
					r_RCanCastTo_RuntimeType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "CanCastTo", 0,  ReleactionUtils.GetType("System.RuntimeType"),  ReleactionUtils.GetType("System.RuntimeType"));
					r_RCanCastTo_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_RCanCastTo_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean type_is_assignable_from(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_Rtype_is_assignable_from_Type_Type;
		public static RMethod Rtype_is_assignable_from_Type_Type
		{
			get
			{
				if(r_Rtype_is_assignable_from_Type_Type == null)
				{
					r_Rtype_is_assignable_from_Type_Type = new(typeof(System.RuntimeTypeHandle), "type_is_assignable_from", 0, typeof(System.Type), typeof(System.Type));
					r_Rtype_is_assignable_from_Type_Type.SetBelong(null);
				}
				return r_Rtype_is_assignable_from_Type_Type;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsGenericTypeDefinition_RuntimeType;
		public static RMethod RIsGenericTypeDefinition_RuntimeType
		{
			get
			{
				if(r_RIsGenericTypeDefinition_RuntimeType == null)
				{
					r_RIsGenericTypeDefinition_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsGenericTypeDefinition", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsGenericTypeDefinition_RuntimeType.SetBelong(null);
				}
				return r_RIsGenericTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// IntPtr GetGenericParameterInfo(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RGetGenericParameterInfo_RuntimeType;
		public static RMethod RGetGenericParameterInfo_RuntimeType
		{
			get
			{
				if(r_RGetGenericParameterInfo_RuntimeType == null)
				{
					r_RGetGenericParameterInfo_RuntimeType = new(typeof(System.RuntimeTypeHandle), "GetGenericParameterInfo", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RGetGenericParameterInfo_RuntimeType.SetBelong(null);
				}
				return r_RGetGenericParameterInfo_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsSubclassOf_RuntimeType_RuntimeType;
		public static RMethod RIsSubclassOf_RuntimeType_RuntimeType
		{
			get
			{
				if(r_RIsSubclassOf_RuntimeType_RuntimeType == null)
				{
					r_RIsSubclassOf_RuntimeType_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsSubclassOf", 0,  ReleactionUtils.GetType("System.RuntimeType"),  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsSubclassOf_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_RIsSubclassOf_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean is_subclass_of(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Ris_subclass_of_IntPtr_IntPtr;
		public static RMethod Ris_subclass_of_IntPtr_IntPtr
		{
			get
			{
				if(r_Ris_subclass_of_IntPtr_IntPtr == null)
				{
					r_Ris_subclass_of_IntPtr_IntPtr = new(typeof(System.RuntimeTypeHandle), "is_subclass_of", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_Ris_subclass_of_IntPtr_IntPtr.SetBelong(null);
				}
				return r_Ris_subclass_of_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsByRefLike_RuntimeType;
		public static RMethod RIsByRefLike_RuntimeType
		{
			get
			{
				if(r_RIsByRefLike_RuntimeType == null)
				{
					r_RIsByRefLike_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsByRefLike", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsByRefLike_RuntimeType.SetBelong(null);
				}
				return r_RIsByRefLike_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_RIsTypeDefinition_RuntimeType;
		public static RMethod RIsTypeDefinition_RuntimeType
		{
			get
			{
				if(r_RIsTypeDefinition_RuntimeType == null)
				{
					r_RIsTypeDefinition_RuntimeType = new(typeof(System.RuntimeTypeHandle), "IsTypeDefinition", 0,  ReleactionUtils.GetType("System.RuntimeType"));
					r_RIsTypeDefinition_RuntimeType.SetBelong(null);
				}
				return r_RIsTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType internal_from_name(System.String, System.Threading.StackCrawlMark ByRef, System.Reflection.Assembly, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean;
		public static RMethod Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean == null)
				{
					r_Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean = new(typeof(System.RuntimeTypeHandle), "internal_from_name", 0, typeof(System.String),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Reflection.Assembly), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_Rinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.RuntimeType GetTypeByName(System.String, Boolean, Boolean, Boolean, System.Threading.StackCrawlMark ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean;
		public static RMethod RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean
		{
			get
			{
				if(r_RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean == null)
				{
					r_RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean = new(typeof(System.RuntimeTypeHandle), "GetTypeByName", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean),  ReleactionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean));
					r_RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean.SetBelong(null);
				}
				return r_RGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean;
			}
		}

		/// <summary>
		/// IntPtr[] CopyRuntimeTypeHandles(System.RuntimeTypeHandle[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32;
		public static RMethod RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32
		{
			get
			{
				if(r_RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32 == null)
				{
					r_RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32 = new(typeof(System.RuntimeTypeHandle), "CopyRuntimeTypeHandles", 0, typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32.SetBelong(null);
				}
				return r_RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32;
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



        public virtual System.ModuleHandle GetModuleHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModuleHandle.Invoke(___genericsType, ___parameters);

            return (System.ModuleHandle)___result;
        }





























        public static System.Boolean type_is_assignable_from(System.Type  @a, System.Type  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rtype_is_assignable_from_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }





        public static System.Boolean is_subclass_of(System.IntPtr  @childType, System.IntPtr  @baseType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childType, @baseType};
            var ___result = Ris_subclass_of_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }






        public static System.IntPtr[] CopyRuntimeTypeHandles(System.RuntimeTypeHandle[]  @inHandles, out System.Int32  @length)
        {
			length = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inHandles, @length};
            var ___result = RCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32.Invoke(___genericsType, ___parameters);
			length = (System.Int32)___parameters[1];

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
