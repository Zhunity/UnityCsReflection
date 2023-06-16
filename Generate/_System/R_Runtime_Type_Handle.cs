
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.RuntimeTypeHandle
	/// </summary>
    public partial class RRuntimeTypeHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.RuntimeTypeHandle);
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


		/// <summary>
		/// System.IntPtr value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// IntPtr Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
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
		/// Boolean Equals(System.RuntimeTypeHandle)
		/// </summary>
		protected RMethod r_MEquals_RuntimeTypeHandle;
		public virtual RMethod RMEquals_RuntimeTypeHandle
		{
			get
			{
				if(r_MEquals_RuntimeTypeHandle == null)
				{
					r_MEquals_RuntimeTypeHandle = new(this, "Equals", 0, typeof(System.RuntimeTypeHandle));
				}
				return r_MEquals_RuntimeTypeHandle;
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
		/// Boolean op_Equality(System.RuntimeTypeHandle, System.Object)
		/// </summary>
		protected static RMethod r_Mop_Equality_RuntimeTypeHandle_Object;
		public static RMethod RMop_Equality_RuntimeTypeHandle_Object
		{
			get
			{
				if(r_Mop_Equality_RuntimeTypeHandle_Object == null)
				{
					r_Mop_Equality_RuntimeTypeHandle_Object = new(Type, "op_Equality", 0, typeof(System.RuntimeTypeHandle), typeof(System.Object));
				}
				return r_Mop_Equality_RuntimeTypeHandle_Object;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeTypeHandle, System.Object)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RuntimeTypeHandle_Object;
		public static RMethod RMop_Inequality_RuntimeTypeHandle_Object
		{
			get
			{
				if(r_Mop_Inequality_RuntimeTypeHandle_Object == null)
				{
					r_Mop_Inequality_RuntimeTypeHandle_Object = new(Type, "op_Inequality", 0, typeof(System.RuntimeTypeHandle), typeof(System.Object));
				}
				return r_Mop_Inequality_RuntimeTypeHandle_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Object, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_Mop_Equality_Object_RuntimeTypeHandle;
		public static RMethod RMop_Equality_Object_RuntimeTypeHandle
		{
			get
			{
				if(r_Mop_Equality_Object_RuntimeTypeHandle == null)
				{
					r_Mop_Equality_Object_RuntimeTypeHandle = new(Type, "op_Equality", 0, typeof(System.Object), typeof(System.RuntimeTypeHandle));
				}
				return r_Mop_Equality_Object_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Object, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Object_RuntimeTypeHandle;
		public static RMethod RMop_Inequality_Object_RuntimeTypeHandle
		{
			get
			{
				if(r_Mop_Inequality_Object_RuntimeTypeHandle == null)
				{
					r_Mop_Inequality_Object_RuntimeTypeHandle = new(Type, "op_Inequality", 0, typeof(System.Object), typeof(System.RuntimeTypeHandle));
				}
				return r_Mop_Inequality_Object_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributes(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetAttributes_RuntimeType;
		public static RMethod RMGetAttributes_RuntimeType
		{
			get
			{
				if(r_MGetAttributes_RuntimeType == null)
				{
					r_MGetAttributes_RuntimeType = new(Type, "GetAttributes", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetAttributes_RuntimeType;
			}
		}

		/// <summary>
		/// System.ModuleHandle GetModuleHandle()
		/// </summary>
		protected RMethod r_MGetModuleHandle;
		public virtual RMethod RMGetModuleHandle
		{
			get
			{
				if(r_MGetModuleHandle == null)
				{
					r_MGetModuleHandle = new(this, "GetModuleHandle", 0);
				}
				return r_MGetModuleHandle;
			}
		}

		/// <summary>
		/// Int32 GetMetadataToken(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetMetadataToken_RuntimeType;
		public static RMethod RMGetMetadataToken_RuntimeType
		{
			get
			{
				if(r_MGetMetadataToken_RuntimeType == null)
				{
					r_MGetMetadataToken_RuntimeType = new(Type, "GetMetadataToken", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetMetadataToken_RuntimeType;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetToken_RuntimeType;
		public static RMethod RMGetToken_RuntimeType
		{
			get
			{
				if(r_MGetToken_RuntimeType == null)
				{
					r_MGetToken_RuntimeType = new(Type, "GetToken", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetToken_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition_impl(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetGenericTypeDefinition_impl_RuntimeType;
		public static RMethod RMGetGenericTypeDefinition_impl_RuntimeType
		{
			get
			{
				if(r_MGetGenericTypeDefinition_impl_RuntimeType == null)
				{
					r_MGetGenericTypeDefinition_impl_RuntimeType = new(Type, "GetGenericTypeDefinition_impl", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetGenericTypeDefinition_impl_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetGenericTypeDefinition_RuntimeType;
		public static RMethod RMGetGenericTypeDefinition_RuntimeType
		{
			get
			{
				if(r_MGetGenericTypeDefinition_RuntimeType == null)
				{
					r_MGetGenericTypeDefinition_RuntimeType = new(Type, "GetGenericTypeDefinition", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetGenericTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttribute(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MHasProxyAttribute_RuntimeType;
		public static RMethod RMHasProxyAttribute_RuntimeType
		{
			get
			{
				if(r_MHasProxyAttribute_RuntimeType == null)
				{
					r_MHasProxyAttribute_RuntimeType = new(Type, "HasProxyAttribute", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MHasProxyAttribute_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsPrimitive_RuntimeType;
		public static RMethod RMIsPrimitive_RuntimeType
		{
			get
			{
				if(r_MIsPrimitive_RuntimeType == null)
				{
					r_MIsPrimitive_RuntimeType = new(Type, "IsPrimitive", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsPrimitive_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsByRef(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsByRef_RuntimeType;
		public static RMethod RMIsByRef_RuntimeType
		{
			get
			{
				if(r_MIsByRef_RuntimeType == null)
				{
					r_MIsByRef_RuntimeType = new(Type, "IsByRef", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsByRef_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsPointer(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsPointer_RuntimeType;
		public static RMethod RMIsPointer_RuntimeType
		{
			get
			{
				if(r_MIsPointer_RuntimeType == null)
				{
					r_MIsPointer_RuntimeType = new(Type, "IsPointer", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsPointer_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsArray(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsArray_RuntimeType;
		public static RMethod RMIsArray_RuntimeType
		{
			get
			{
				if(r_MIsArray_RuntimeType == null)
				{
					r_MIsArray_RuntimeType = new(Type, "IsArray", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsArray_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsSzArray(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsSzArray_RuntimeType;
		public static RMethod RMIsSzArray_RuntimeType
		{
			get
			{
				if(r_MIsSzArray_RuntimeType == null)
				{
					r_MIsSzArray_RuntimeType = new(Type, "IsSzArray", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsSzArray_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MHasElementType_RuntimeType;
		public static RMethod RMHasElementType_RuntimeType
		{
			get
			{
				if(r_MHasElementType_RuntimeType == null)
				{
					r_MHasElementType_RuntimeType = new(Type, "HasElementType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MHasElementType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType GetCorElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetCorElementType_RuntimeType;
		public static RMethod RMGetCorElementType_RuntimeType
		{
			get
			{
				if(r_MGetCorElementType_RuntimeType == null)
				{
					r_MGetCorElementType_RuntimeType = new(Type, "GetCorElementType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetCorElementType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasInstantiation(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MHasInstantiation_RuntimeType;
		public static RMethod RMHasInstantiation_RuntimeType
		{
			get
			{
				if(r_MHasInstantiation_RuntimeType == null)
				{
					r_MHasInstantiation_RuntimeType = new(Type, "HasInstantiation", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MHasInstantiation_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsComObject(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsComObject_RuntimeType;
		public static RMethod RMIsComObject_RuntimeType
		{
			get
			{
				if(r_MIsComObject_RuntimeType == null)
				{
					r_MIsComObject_RuntimeType = new(Type, "IsComObject", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsComObject_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.RuntimeType, System.Object)
		/// </summary>
		protected static RMethod r_MIsInstanceOfType_RuntimeType_Object;
		public static RMethod RMIsInstanceOfType_RuntimeType_Object
		{
			get
			{
				if(r_MIsInstanceOfType_RuntimeType_Object == null)
				{
					r_MIsInstanceOfType_RuntimeType_Object = new(Type, "IsInstanceOfType", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Object));
				}
				return r_MIsInstanceOfType_RuntimeType_Object;
			}
		}

		/// <summary>
		/// Boolean HasReferences(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MHasReferences_RuntimeType;
		public static RMethod RMHasReferences_RuntimeType
		{
			get
			{
				if(r_MHasReferences_RuntimeType == null)
				{
					r_MHasReferences_RuntimeType = new(Type, "HasReferences", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MHasReferences_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsComObject(System.RuntimeType, Boolean)
		/// </summary>
		protected static RMethod r_MIsComObject_RuntimeType_Boolean;
		public static RMethod RMIsComObject_RuntimeType_Boolean
		{
			get
			{
				if(r_MIsComObject_RuntimeType_Boolean == null)
				{
					r_MIsComObject_RuntimeType_Boolean = new(Type, "IsComObject", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Boolean));
				}
				return r_MIsComObject_RuntimeType_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsContextful(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsContextful_RuntimeType;
		public static RMethod RMIsContextful_RuntimeType
		{
			get
			{
				if(r_MIsContextful_RuntimeType == null)
				{
					r_MIsContextful_RuntimeType = new(Type, "IsContextful", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsContextful_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsEquivalentTo_RuntimeType_RuntimeType;
		public static RMethod RMIsEquivalentTo_RuntimeType_RuntimeType
		{
			get
			{
				if(r_MIsEquivalentTo_RuntimeType_RuntimeType == null)
				{
					r_MIsEquivalentTo_RuntimeType_RuntimeType = new(Type, "IsEquivalentTo", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsEquivalentTo_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsInterface(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsInterface_RuntimeType;
		public static RMethod RMIsInterface_RuntimeType
		{
			get
			{
				if(r_MIsInterface_RuntimeType == null)
				{
					r_MIsInterface_RuntimeType = new(Type, "IsInterface", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsInterface_RuntimeType;
			}
		}

		/// <summary>
		/// Int32 GetArrayRank(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetArrayRank_RuntimeType;
		public static RMethod RMGetArrayRank_RuntimeType
		{
			get
			{
				if(r_MGetArrayRank_RuntimeType == null)
				{
					r_MGetArrayRank_RuntimeType = new(Type, "GetArrayRank", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetArrayRank_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly GetAssembly(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetAssembly_RuntimeType;
		public static RMethod RMGetAssembly_RuntimeType
		{
			get
			{
				if(r_MGetAssembly_RuntimeType == null)
				{
					r_MGetAssembly_RuntimeType = new(Type, "GetAssembly", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetAssembly_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType GetElementType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetElementType_RuntimeType;
		public static RMethod RMGetElementType_RuntimeType
		{
			get
			{
				if(r_MGetElementType_RuntimeType == null)
				{
					r_MGetElementType_RuntimeType = new(Type, "GetElementType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetElementType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeModule GetModule(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetModule_RuntimeType;
		public static RMethod RMGetModule_RuntimeType
		{
			get
			{
				if(r_MGetModule_RuntimeType == null)
				{
					r_MGetModule_RuntimeType = new(Type, "GetModule", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetModule_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsGenericVariable(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsGenericVariable_RuntimeType;
		public static RMethod RMIsGenericVariable_RuntimeType
		{
			get
			{
				if(r_MIsGenericVariable_RuntimeType == null)
				{
					r_MIsGenericVariable_RuntimeType = new(Type, "IsGenericVariable", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsGenericVariable_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType GetBaseType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetBaseType_RuntimeType;
		public static RMethod RMGetBaseType_RuntimeType
		{
			get
			{
				if(r_MGetBaseType_RuntimeType == null)
				{
					r_MGetBaseType_RuntimeType = new(Type, "GetBaseType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetBaseType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean CanCastTo(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_MCanCastTo_RuntimeType_RuntimeType;
		public static RMethod RMCanCastTo_RuntimeType_RuntimeType
		{
			get
			{
				if(r_MCanCastTo_RuntimeType_RuntimeType == null)
				{
					r_MCanCastTo_RuntimeType_RuntimeType = new(Type, "CanCastTo", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MCanCastTo_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean type_is_assignable_from(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_Mtype_is_assignable_from_Type_Type;
		public static RMethod RMtype_is_assignable_from_Type_Type
		{
			get
			{
				if(r_Mtype_is_assignable_from_Type_Type == null)
				{
					r_Mtype_is_assignable_from_Type_Type = new(Type, "type_is_assignable_from", 0, typeof(System.Type), typeof(System.Type));
				}
				return r_Mtype_is_assignable_from_Type_Type;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsGenericTypeDefinition_RuntimeType;
		public static RMethod RMIsGenericTypeDefinition_RuntimeType
		{
			get
			{
				if(r_MIsGenericTypeDefinition_RuntimeType == null)
				{
					r_MIsGenericTypeDefinition_RuntimeType = new(Type, "IsGenericTypeDefinition", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsGenericTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// IntPtr GetGenericParameterInfo(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MGetGenericParameterInfo_RuntimeType;
		public static RMethod RMGetGenericParameterInfo_RuntimeType
		{
			get
			{
				if(r_MGetGenericParameterInfo_RuntimeType == null)
				{
					r_MGetGenericParameterInfo_RuntimeType = new(Type, "GetGenericParameterInfo", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MGetGenericParameterInfo_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsSubclassOf_RuntimeType_RuntimeType;
		public static RMethod RMIsSubclassOf_RuntimeType_RuntimeType
		{
			get
			{
				if(r_MIsSubclassOf_RuntimeType_RuntimeType == null)
				{
					r_MIsSubclassOf_RuntimeType_RuntimeType = new(Type, "IsSubclassOf", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsSubclassOf_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean is_subclass_of(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Mis_subclass_of_IntPtr_IntPtr;
		public static RMethod RMis_subclass_of_IntPtr_IntPtr
		{
			get
			{
				if(r_Mis_subclass_of_IntPtr_IntPtr == null)
				{
					r_Mis_subclass_of_IntPtr_IntPtr = new(Type, "is_subclass_of", 0, typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_Mis_subclass_of_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsByRefLike_RuntimeType;
		public static RMethod RMIsByRefLike_RuntimeType
		{
			get
			{
				if(r_MIsByRefLike_RuntimeType == null)
				{
					r_MIsByRefLike_RuntimeType = new(Type, "IsByRefLike", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsByRefLike_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsTypeDefinition_RuntimeType;
		public static RMethod RMIsTypeDefinition_RuntimeType
		{
			get
			{
				if(r_MIsTypeDefinition_RuntimeType == null)
				{
					r_MIsTypeDefinition_RuntimeType = new(Type, "IsTypeDefinition", 0,  ReflectionUtils.GetType("System.RuntimeType"));
				}
				return r_MIsTypeDefinition_RuntimeType;
			}
		}

		/// <summary>
		/// System.RuntimeType internal_from_name(System.String, System.Threading.StackCrawlMark ByRef, System.Reflection.Assembly, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_Minternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean;
		public static RMethod RMinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_Minternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean == null)
				{
					r_Minternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean = new(Type, "internal_from_name", 0, typeof(System.String),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Reflection.Assembly), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_Minternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.RuntimeType GetTypeByName(System.String, Boolean, Boolean, Boolean, System.Threading.StackCrawlMark ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean;
		public static RMethod RMGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean
		{
			get
			{
				if(r_MGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean == null)
				{
					r_MGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean = new(Type, "GetTypeByName", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType(), typeof(System.Boolean));
				}
				return r_MGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean;
			}
		}

		/// <summary>
		/// IntPtr[] CopyRuntimeTypeHandles(System.RuntimeTypeHandle[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_MCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32;
		public static RMethod RMCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32
		{
			get
			{
				if(r_MCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32 == null)
				{
					r_MCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32 = new(Type, "CopyRuntimeTypeHandles", 0, typeof(System.RuntimeTypeHandle).MakeArrayType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32;
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


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.RuntimeTypeHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMEquals_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.RuntimeTypeHandle @left, System.Object @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_RuntimeTypeHandle_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.RuntimeTypeHandle @left, System.Object @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_RuntimeTypeHandle_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(System.Object @left, System.RuntimeTypeHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_Object_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Object @left, System.RuntimeTypeHandle @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_Object_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Reflection.TypeAttributes GetAttributes(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetAttributes_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.TypeAttributes>(___result);
        }


        public virtual System.ModuleHandle GetModuleHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModuleHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.ModuleHandle>(___result);
        }


        public static System.Int32 GetMetadataToken(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetMetadataToken_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetToken(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetToken_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Type GetGenericTypeDefinition_impl(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetGenericTypeDefinition_impl_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public static System.Type GetGenericTypeDefinition(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetGenericTypeDefinition_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public static System.Boolean HasProxyAttribute(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMHasProxyAttribute_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsPrimitive(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsPrimitive_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsByRef(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsByRef_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsPointer(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsPointer_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsArray(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsArray_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsSzArray(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsSzArray_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean HasElementType(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMHasElementType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType GetCorElementType(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetCorElementType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType>(___result);
        }


        public static System.Boolean HasInstantiation(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMHasInstantiation_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsComObject(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsComObject_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsInstanceOfType(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type, System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @o};
            var ___result = RMIsInstanceOfType_RuntimeType_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean HasReferences(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMHasReferences_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsComObject(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type, System.Boolean @isGenericCOM)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @isGenericCOM};
            var ___result = RMIsComObject_RuntimeType_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsContextful(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsContextful_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsEquivalentTo(Hvak.Editor.Refleaction.RSystem.RRuntimeType @rtType1, Hvak.Editor.Refleaction.RSystem.RRuntimeType @rtType2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rtType1.Value, @rtType2.Value};
            var ___result = RMIsEquivalentTo_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsInterface(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsInterface_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 GetArrayRank(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetArrayRank_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly GetAssembly(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetAssembly_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RRuntimeType GetElementType(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetElementType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RRuntimeType>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeModule GetModule(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetModule_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeModule>(___result);
        }


        public static System.Boolean IsGenericVariable(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsGenericVariable_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RRuntimeType GetBaseType(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetBaseType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RRuntimeType>(___result);
        }


        public static System.Boolean CanCastTo(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type, Hvak.Editor.Refleaction.RSystem.RRuntimeType @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @target.Value};
            var ___result = RMCanCastTo_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean type_is_assignable_from(System.Type @a, System.Type @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMtype_is_assignable_from_Type_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsGenericTypeDefinition(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsGenericTypeDefinition_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.IntPtr GetGenericParameterInfo(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMGetGenericParameterInfo_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static System.Boolean IsSubclassOf(Hvak.Editor.Refleaction.RSystem.RRuntimeType @childType, Hvak.Editor.Refleaction.RSystem.RRuntimeType @baseType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childType.Value, @baseType.Value};
            var ___result = RMIsSubclassOf_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean is_subclass_of(System.IntPtr @childType, System.IntPtr @baseType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childType, @baseType};
            var ___result = RMis_subclass_of_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsByRefLike(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsByRefLike_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsTypeDefinition(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsTypeDefinition_RuntimeType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RRuntimeType internal_from_name(System.String @name, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, System.Reflection.Assembly @callerAssembly, System.Boolean @throwOnError, System.Boolean @ignoreCase, System.Boolean @reflectionOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stackMark.Value, @callerAssembly, @throwOnError, @ignoreCase, @reflectionOnly};
            var ___result = RMinternal_from_name_String_Ref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[1]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RRuntimeType>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RRuntimeType GetTypeByName(System.String @typeName, System.Boolean @throwOnError, System.Boolean @ignoreCase, System.Boolean @reflectionOnly, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark, System.Boolean @loadTypeFromPartialName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError, @ignoreCase, @reflectionOnly, @stackMark.Value, @loadTypeFromPartialName};
            var ___result = RMGetTypeByName_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark_Boolean.Invoke(___genericsType, ___parameters);
			@stackMark = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark>(___parameters[4]);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RRuntimeType>(___result);
        }


        public static System.IntPtr[] CopyRuntimeTypeHandles(System.RuntimeTypeHandle[] @inHandles, out System.Int32 @length)
        {
			@length = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inHandles, @length};
            var ___result = RMCopyRuntimeTypeHandles_RuntimeTypeHandleArray_Out_Int32.Invoke(___genericsType, ___parameters);
			@length = ReflectionUtils.Convert<System.Int32>(___parameters[1]);

            return ReflectionUtils.Convert<System.IntPtr[]>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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


    }
}
