
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.RuntimeType
	/// </summary>
    public partial class RRuntimeType : RMember //
    {

		/// <summary>
		/// System.RuntimeType ValueType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntimeType r_FValueType;
		public static Hvak.Editor.Refleaction.RSystem.RRuntimeType RFValueType
		{
			get
			{
				if(r_FValueType == null)
				{
					r_FValueType = new( ReflectionUtils.GetType("System.RuntimeType"), "ValueType");
					r_FValueType.SetBelong(null);
				}
				return r_FValueType;
			}
		}

		/// <summary>
		/// System.RuntimeType EnumType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntimeType r_FEnumType;
		public static Hvak.Editor.Refleaction.RSystem.RRuntimeType RFEnumType
		{
			get
			{
				if(r_FEnumType == null)
				{
					r_FEnumType = new( ReflectionUtils.GetType("System.RuntimeType"), "EnumType");
					r_FEnumType.SetBelong(null);
				}
				return r_FEnumType;
			}
		}

		/// <summary>
		/// System.RuntimeType ObjectType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntimeType r_FObjectType;
		public static Hvak.Editor.Refleaction.RSystem.RRuntimeType RFObjectType
		{
			get
			{
				if(r_FObjectType == null)
				{
					r_FObjectType = new( ReflectionUtils.GetType("System.RuntimeType"), "ObjectType");
					r_FObjectType.SetBelong(null);
				}
				return r_FObjectType;
			}
		}

		/// <summary>
		/// System.RuntimeType StringType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntimeType r_FStringType;
		public static Hvak.Editor.Refleaction.RSystem.RRuntimeType RFStringType
		{
			get
			{
				if(r_FStringType == null)
				{
					r_FStringType = new( ReflectionUtils.GetType("System.RuntimeType"), "StringType");
					r_FStringType.SetBelong(null);
				}
				return r_FStringType;
			}
		}

		/// <summary>
		/// System.RuntimeType DelegateType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntimeType r_FDelegateType;
		public static Hvak.Editor.Refleaction.RSystem.RRuntimeType RFDelegateType
		{
			get
			{
				if(r_FDelegateType == null)
				{
					r_FDelegateType = new( ReflectionUtils.GetType("System.RuntimeType"), "DelegateType");
					r_FDelegateType.SetBelong(null);
				}
				return r_FDelegateType;
			}
		}

		/// <summary>
		/// System.Type[] s_SICtorParamTypes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_Fs_SICtorParamTypes;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFs_SICtorParamTypes
		{
			get
			{
				if(r_Fs_SICtorParamTypes == null)
				{
					r_Fs_SICtorParamTypes = new( ReflectionUtils.GetType("System.RuntimeType"), "s_SICtorParamTypes");
					r_Fs_SICtorParamTypes.SetBelong(null);
				}
				return r_Fs_SICtorParamTypes;
			}
		}

		/// <summary>
		/// System.Func`3[System.Type,System.Type[],System.Type] MakeTypeBuilderInstantiation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>, Hvak.Editor.Refleaction.RSystem.RType> r_FMakeTypeBuilderInstantiation;
		public static Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>, Hvak.Editor.Refleaction.RSystem.RType> RFMakeTypeBuilderInstantiation
		{
			get
			{
				if(r_FMakeTypeBuilderInstantiation == null)
				{
					r_FMakeTypeBuilderInstantiation = new( ReflectionUtils.GetType("System.RuntimeType"), "MakeTypeBuilderInstantiation");
					r_FMakeTypeBuilderInstantiation.SetBelong(null);
				}
				return r_FMakeTypeBuilderInstantiation;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags MemberBindingMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FMemberBindingMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFMemberBindingMask
		{
			get
			{
				if(r_FMemberBindingMask == null)
				{
					r_FMemberBindingMask = new( ReflectionUtils.GetType("System.RuntimeType"), "MemberBindingMask");
					r_FMemberBindingMask.SetBelong(null);
				}
				return r_FMemberBindingMask;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags InvocationMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FInvocationMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFInvocationMask
		{
			get
			{
				if(r_FInvocationMask == null)
				{
					r_FInvocationMask = new( ReflectionUtils.GetType("System.RuntimeType"), "InvocationMask");
					r_FInvocationMask.SetBelong(null);
				}
				return r_FInvocationMask;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BinderNonCreateInstance
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FBinderNonCreateInstance;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFBinderNonCreateInstance
		{
			get
			{
				if(r_FBinderNonCreateInstance == null)
				{
					r_FBinderNonCreateInstance = new( ReflectionUtils.GetType("System.RuntimeType"), "BinderNonCreateInstance");
					r_FBinderNonCreateInstance.SetBelong(null);
				}
				return r_FBinderNonCreateInstance;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BinderGetSetProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FBinderGetSetProperty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFBinderGetSetProperty
		{
			get
			{
				if(r_FBinderGetSetProperty == null)
				{
					r_FBinderGetSetProperty = new( ReflectionUtils.GetType("System.RuntimeType"), "BinderGetSetProperty");
					r_FBinderGetSetProperty.SetBelong(null);
				}
				return r_FBinderGetSetProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BinderSetInvokeProperty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FBinderSetInvokeProperty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFBinderSetInvokeProperty
		{
			get
			{
				if(r_FBinderSetInvokeProperty == null)
				{
					r_FBinderSetInvokeProperty = new( ReflectionUtils.GetType("System.RuntimeType"), "BinderSetInvokeProperty");
					r_FBinderSetInvokeProperty.SetBelong(null);
				}
				return r_FBinderSetInvokeProperty;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BinderGetSetField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FBinderGetSetField;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFBinderGetSetField
		{
			get
			{
				if(r_FBinderGetSetField == null)
				{
					r_FBinderGetSetField = new( ReflectionUtils.GetType("System.RuntimeType"), "BinderGetSetField");
					r_FBinderGetSetField.SetBelong(null);
				}
				return r_FBinderGetSetField;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BinderSetInvokeField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FBinderSetInvokeField;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFBinderSetInvokeField
		{
			get
			{
				if(r_FBinderSetInvokeField == null)
				{
					r_FBinderSetInvokeField = new( ReflectionUtils.GetType("System.RuntimeType"), "BinderSetInvokeField");
					r_FBinderSetInvokeField.SetBelong(null);
				}
				return r_FBinderSetInvokeField;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BinderNonFieldGetSet
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FBinderNonFieldGetSet;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFBinderNonFieldGetSet
		{
			get
			{
				if(r_FBinderNonFieldGetSet == null)
				{
					r_FBinderNonFieldGetSet = new( ReflectionUtils.GetType("System.RuntimeType"), "BinderNonFieldGetSet");
					r_FBinderNonFieldGetSet.SetBelong(null);
				}
				return r_FBinderNonFieldGetSet;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags ClassicBindingMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FClassicBindingMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFClassicBindingMask
		{
			get
			{
				if(r_FClassicBindingMask == null)
				{
					r_FClassicBindingMask = new( ReflectionUtils.GetType("System.RuntimeType"), "ClassicBindingMask");
					r_FClassicBindingMask.SetBelong(null);
				}
				return r_FClassicBindingMask;
			}
		}

		/// <summary>
		/// System.RuntimeType s_typedRef
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntimeType r_Fs_typedRef;
		public static Hvak.Editor.Refleaction.RSystem.RRuntimeType RFs_typedRef
		{
			get
			{
				if(r_Fs_typedRef == null)
				{
					r_Fs_typedRef = new( ReflectionUtils.GetType("System.RuntimeType"), "s_typedRef");
					r_Fs_typedRef.SetBelong(null);
				}
				return r_Fs_typedRef;
			}
		}

		/// <summary>
		/// System.MonoTypeInfo type_info
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RMonoTypeInfo r_Ftype_info;
		public virtual Hvak.Editor.Refleaction.RSystem.RMonoTypeInfo RFtype_info
		{
			get
			{
				if(r_Ftype_info == null)
				{
					r_Ftype_info = new(this, "type_info");
					r_Ftype_info.SetBelong(this.GetValue());
				}
				return r_Ftype_info;
			}
		}

		/// <summary>
		/// System.Object GenericCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_FGenericCache;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFGenericCache
		{
			get
			{
				if(r_FGenericCache == null)
				{
					r_FGenericCache = new(this, "GenericCache");
					r_FGenericCache.SetBelong(this.GetValue());
				}
				return r_FGenericCache;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeConstructorInfo m_serializationCtor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo r_Fm_serializationCtor;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo RFm_serializationCtor
		{
			get
			{
				if(r_Fm_serializationCtor == null)
				{
					r_Fm_serializationCtor = new(this, "m_serializationCtor");
					r_Fm_serializationCtor.SetBelong(this.GetValue());
				}
				return r_Fm_serializationCtor;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Guid,System.Type] clsid_types
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RGuid, Hvak.Editor.Refleaction.RSystem.RType> r_Fclsid_types;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RGuid, Hvak.Editor.Refleaction.RSystem.RType> RFclsid_types
		{
			get
			{
				if(r_Fclsid_types == null)
				{
					r_Fclsid_types = new( ReflectionUtils.GetType("System.RuntimeType"), "clsid_types");
					r_Fclsid_types.SetBelong(null);
				}
				return r_Fclsid_types;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder clsid_assemblybuilder
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RAssemblyBuilder r_Fclsid_assemblybuilder;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RAssemblyBuilder RFclsid_assemblybuilder
		{
			get
			{
				if(r_Fclsid_assemblybuilder == null)
				{
					r_Fclsid_assemblybuilder = new( ReflectionUtils.GetType("System.RuntimeType"), "clsid_assemblybuilder");
					r_Fclsid_assemblybuilder.SetBelong(null);
				}
				return r_Fclsid_assemblybuilder;
			}
		}

		/// <summary>
		/// System.Int32 GenericParameterCountAny
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FGenericParameterCountAny;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFGenericParameterCountAny
		{
			get
			{
				if(r_FGenericParameterCountAny == null)
				{
					r_FGenericParameterCountAny = new( ReflectionUtils.GetType("System.RuntimeType"), "GenericParameterCountAny");
					r_FGenericParameterCountAny.SetBelong(null);
				}
				return r_FGenericParameterCountAny;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle _impl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle r_F_impl;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle RF_impl
		{
			get
			{
				if(r_F_impl == null)
				{
					r_F_impl = new(this, "_impl");
					r_F_impl.SetBelong(this.GetValue());
				}
				return r_F_impl;
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
					r_PModule.SetBelong(this.GetValue());
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Assembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly r_PAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly RPAssembly
		{
			get
			{
				if(r_PAssembly == null)
				{
					r_PAssembly = new(this, "Assembly", -1);
					r_PAssembly.SetBelong(this.GetValue());
				}
				return r_PAssembly;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle TypeHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle r_PTypeHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle RPTypeHandle
		{
			get
			{
				if(r_PTypeHandle == null)
				{
					r_PTypeHandle = new(this, "TypeHandle", -1);
					r_PTypeHandle.SetBelong(this.GetValue());
				}
				return r_PTypeHandle;
			}
		}

		/// <summary>
		/// System.Type BaseType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PBaseType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPBaseType
		{
			get
			{
				if(r_PBaseType == null)
				{
					r_PBaseType = new(this, "BaseType", -1);
					r_PBaseType.SetBelong(this.GetValue());
				}
				return r_PBaseType;
			}
		}

		/// <summary>
		/// System.Type UnderlyingSystemType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PUnderlyingSystemType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPUnderlyingSystemType
		{
			get
			{
				if(r_PUnderlyingSystemType == null)
				{
					r_PUnderlyingSystemType = new(this, "UnderlyingSystemType", -1);
					r_PUnderlyingSystemType.SetBelong(this.GetValue());
				}
				return r_PUnderlyingSystemType;
			}
		}

		/// <summary>
		/// Boolean IsEnum
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsEnum;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsEnum
		{
			get
			{
				if(r_PIsEnum == null)
				{
					r_PIsEnum = new(this, "IsEnum", -1);
					r_PIsEnum.SetBelong(this.GetValue());
				}
				return r_PIsEnum;
			}
		}

		/// <summary>
		/// System.Reflection.GenericParameterAttributes GenericParameterAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RGenericParameterAttributes r_PGenericParameterAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RGenericParameterAttributes RPGenericParameterAttributes
		{
			get
			{
				if(r_PGenericParameterAttributes == null)
				{
					r_PGenericParameterAttributes = new(this, "GenericParameterAttributes", -1);
					r_PGenericParameterAttributes.SetBelong(this.GetValue());
				}
				return r_PGenericParameterAttributes;
			}
		}

		/// <summary>
		/// Boolean IsSzArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSzArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSzArray
		{
			get
			{
				if(r_PIsSzArray == null)
				{
					r_PIsSzArray = new(this, "IsSzArray", -1);
					r_PIsSzArray.SetBelong(this.GetValue());
				}
				return r_PIsSzArray;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericTypeDefinition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericTypeDefinition
		{
			get
			{
				if(r_PIsGenericTypeDefinition == null)
				{
					r_PIsGenericTypeDefinition = new(this, "IsGenericTypeDefinition", -1);
					r_PIsGenericTypeDefinition.SetBelong(this.GetValue());
				}
				return r_PIsGenericTypeDefinition;
			}
		}

		/// <summary>
		/// Boolean IsGenericParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericParameter
		{
			get
			{
				if(r_PIsGenericParameter == null)
				{
					r_PIsGenericParameter = new(this, "IsGenericParameter", -1);
					r_PIsGenericParameter.SetBelong(this.GetValue());
				}
				return r_PIsGenericParameter;
			}
		}

		/// <summary>
		/// Int32 GenericParameterPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PGenericParameterPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPGenericParameterPosition
		{
			get
			{
				if(r_PGenericParameterPosition == null)
				{
					r_PGenericParameterPosition = new(this, "GenericParameterPosition", -1);
					r_PGenericParameterPosition.SetBelong(this.GetValue());
				}
				return r_PGenericParameterPosition;
			}
		}

		/// <summary>
		/// Boolean IsGenericType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericType
		{
			get
			{
				if(r_PIsGenericType == null)
				{
					r_PIsGenericType = new(this, "IsGenericType", -1);
					r_PIsGenericType.SetBelong(this.GetValue());
				}
				return r_PIsGenericType;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsConstructedGenericType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsConstructedGenericType
		{
			get
			{
				if(r_PIsConstructedGenericType == null)
				{
					r_PIsConstructedGenericType = new(this, "IsConstructedGenericType", -1);
					r_PIsConstructedGenericType.SetBelong(this.GetValue());
				}
				return r_PIsConstructedGenericType;
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
					r_PMemberType.SetBelong(this.GetValue());
				}
				return r_PMemberType;
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
					r_PReflectedType.SetBelong(this.GetValue());
				}
				return r_PReflectedType;
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
					r_PMetadataToken.SetBelong(this.GetValue());
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RStructLayoutAttribute r_PStructLayoutAttribute;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RStructLayoutAttribute RPStructLayoutAttribute
		{
			get
			{
				if(r_PStructLayoutAttribute == null)
				{
					r_PStructLayoutAttribute = new(this, "StructLayoutAttribute", -1);
					r_PStructLayoutAttribute.SetBelong(this.GetValue());
				}
				return r_PStructLayoutAttribute;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PContainsGenericParameters;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPContainsGenericParameters
		{
			get
			{
				if(r_PContainsGenericParameters == null)
				{
					r_PContainsGenericParameters = new(this, "ContainsGenericParameters", -1);
					r_PContainsGenericParameters.SetBelong(this.GetValue());
				}
				return r_PContainsGenericParameters;
			}
		}

		/// <summary>
		/// System.Guid GUID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PGUID;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPGUID
		{
			get
			{
				if(r_PGUID == null)
				{
					r_PGUID = new(this, "GUID", -1);
					r_PGUID.SetBelong(this.GetValue());
				}
				return r_PGUID;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase DeclaringMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase r_PDeclaringMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase RPDeclaringMethod
		{
			get
			{
				if(r_PDeclaringMethod == null)
				{
					r_PDeclaringMethod = new(this, "DeclaringMethod", -1);
					r_PDeclaringMethod.SetBelong(this.GetValue());
				}
				return r_PDeclaringMethod;
			}
		}

		/// <summary>
		/// System.String AssemblyQualifiedName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAssemblyQualifiedName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAssemblyQualifiedName
		{
			get
			{
				if(r_PAssemblyQualifiedName == null)
				{
					r_PAssemblyQualifiedName = new(this, "AssemblyQualifiedName", -1);
					r_PAssemblyQualifiedName.SetBelong(this.GetValue());
				}
				return r_PAssemblyQualifiedName;
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
					r_PDeclaringType.SetBelong(this.GetValue());
				}
				return r_PDeclaringType;
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
					r_PName.SetBelong(this.GetValue());
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNamespace
		{
			get
			{
				if(r_PNamespace == null)
				{
					r_PNamespace = new(this, "Namespace", -1);
					r_PNamespace.SetBelong(this.GetValue());
				}
				return r_PNamespace;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityTransparent;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSecurityTransparent
		{
			get
			{
				if(r_PIsSecurityTransparent == null)
				{
					r_PIsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_PIsSecurityTransparent.SetBelong(this.GetValue());
				}
				return r_PIsSecurityTransparent;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityCritical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSecurityCritical
		{
			get
			{
				if(r_PIsSecurityCritical == null)
				{
					r_PIsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_PIsSecurityCritical.SetBelong(this.GetValue());
				}
				return r_PIsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSecuritySafeCritical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSecuritySafeCritical
		{
			get
			{
				if(r_PIsSecuritySafeCritical == null)
				{
					r_PIsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_PIsSecuritySafeCritical.SetBelong(this.GetValue());
				}
				return r_PIsSecuritySafeCritical;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullName
		{
			get
			{
				if(r_PFullName == null)
				{
					r_PFullName = new(this, "FullName", -1);
					r_PFullName.SetBelong(this.GetValue());
				}
				return r_PFullName;
			}
		}

		/// <summary>
		/// Boolean IsSZArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSZArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSZArray
		{
			get
			{
				if(r_PIsSZArray == null)
				{
					r_PIsSZArray = new(this, "IsSZArray", -1);
					r_PIsSZArray.SetBelong(this.GetValue());
				}
				return r_PIsSZArray;
			}
		}

		/// <summary>
		/// Boolean IsUserType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsUserType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsUserType
		{
			get
			{
				if(r_PIsUserType == null)
				{
					r_PIsUserType = new(this, "IsUserType", -1);
					r_PIsUserType.SetBelong(this.GetValue());
				}
				return r_PIsUserType;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsByRefLike;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsByRefLike
		{
			get
			{
				if(r_PIsByRefLike == null)
				{
					r_PIsByRefLike = new(this, "IsByRefLike", -1);
					r_PIsByRefLike.SetBelong(this.GetValue());
				}
				return r_PIsByRefLike;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsTypeDefinition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsTypeDefinition
		{
			get
			{
				if(r_PIsTypeDefinition == null)
				{
					r_PIsTypeDefinition = new(this, "IsTypeDefinition", -1);
					r_PIsTypeDefinition.SetBelong(this.GetValue());
				}
				return r_PIsTypeDefinition;
			}
		}

		/// <summary>
		/// System.Type[] GenericTypeParameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RType> r_PGenericTypeParameters;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RType> RPGenericTypeParameters
		{
			get
			{
				if(r_PGenericTypeParameters == null)
				{
					r_PGenericTypeParameters = new(this, "GenericTypeParameters", -1);
					r_PGenericTypeParameters.SetBelong(this.GetValue());
				}
				return r_PGenericTypeParameters;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.ConstructorInfo] DeclaredConstructors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo> r_PDeclaredConstructors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo> RPDeclaredConstructors
		{
			get
			{
				if(r_PDeclaredConstructors == null)
				{
					r_PDeclaredConstructors = new(this, "DeclaredConstructors", -1);
					r_PDeclaredConstructors.SetBelong(this.GetValue());
				}
				return r_PDeclaredConstructors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.EventInfo] DeclaredEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo> r_PDeclaredEvents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo> RPDeclaredEvents
		{
			get
			{
				if(r_PDeclaredEvents == null)
				{
					r_PDeclaredEvents = new(this, "DeclaredEvents", -1);
					r_PDeclaredEvents.SetBelong(this.GetValue());
				}
				return r_PDeclaredEvents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.FieldInfo] DeclaredFields
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo> r_PDeclaredFields;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo> RPDeclaredFields
		{
			get
			{
				if(r_PDeclaredFields == null)
				{
					r_PDeclaredFields = new(this, "DeclaredFields", -1);
					r_PDeclaredFields.SetBelong(this.GetValue());
				}
				return r_PDeclaredFields;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MemberInfo] DeclaredMembers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo> r_PDeclaredMembers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo> RPDeclaredMembers
		{
			get
			{
				if(r_PDeclaredMembers == null)
				{
					r_PDeclaredMembers = new(this, "DeclaredMembers", -1);
					r_PDeclaredMembers.SetBelong(this.GetValue());
				}
				return r_PDeclaredMembers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MethodInfo] DeclaredMethods
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> r_PDeclaredMethods;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> RPDeclaredMethods
		{
			get
			{
				if(r_PDeclaredMethods == null)
				{
					r_PDeclaredMethods = new(this, "DeclaredMethods", -1);
					r_PDeclaredMethods.SetBelong(this.GetValue());
				}
				return r_PDeclaredMethods;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.TypeInfo] DeclaredNestedTypes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RTypeInfo> r_PDeclaredNestedTypes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RTypeInfo> RPDeclaredNestedTypes
		{
			get
			{
				if(r_PDeclaredNestedTypes == null)
				{
					r_PDeclaredNestedTypes = new(this, "DeclaredNestedTypes", -1);
					r_PDeclaredNestedTypes.SetBelong(this.GetValue());
				}
				return r_PDeclaredNestedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.PropertyInfo] DeclaredProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyInfo> r_PDeclaredProperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyInfo> RPDeclaredProperties
		{
			get
			{
				if(r_PDeclaredProperties == null)
				{
					r_PDeclaredProperties = new(this, "DeclaredProperties", -1);
					r_PDeclaredProperties.SetBelong(this.GetValue());
				}
				return r_PDeclaredProperties;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] ImplementedInterfaces
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> r_PImplementedInterfaces;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> RPImplementedInterfaces
		{
			get
			{
				if(r_PImplementedInterfaces == null)
				{
					r_PImplementedInterfaces = new(this, "ImplementedInterfaces", -1);
					r_PImplementedInterfaces.SetBelong(this.GetValue());
				}
				return r_PImplementedInterfaces;
			}
		}

		/// <summary>
		/// Boolean IsSerializable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSerializable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSerializable
		{
			get
			{
				if(r_PIsSerializable == null)
				{
					r_PIsSerializable = new(this, "IsSerializable", -1);
					r_PIsSerializable.SetBelong(this.GetValue());
				}
				return r_PIsSerializable;
			}
		}

		/// <summary>
		/// Boolean IsVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsVisible
		{
			get
			{
				if(r_PIsVisible == null)
				{
					r_PIsVisible = new(this, "IsVisible", -1);
					r_PIsVisible.SetBelong(this.GetValue());
				}
				return r_PIsVisible;
			}
		}

		/// <summary>
		/// Boolean IsNested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNested
		{
			get
			{
				if(r_PIsNested == null)
				{
					r_PIsNested = new(this, "IsNested", -1);
					r_PIsNested.SetBelong(this.GetValue());
				}
				return r_PIsNested;
			}
		}

		/// <summary>
		/// Boolean IsArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsArray
		{
			get
			{
				if(r_PIsArray == null)
				{
					r_PIsArray = new(this, "IsArray", -1);
					r_PIsArray.SetBelong(this.GetValue());
				}
				return r_PIsArray;
			}
		}

		/// <summary>
		/// Boolean IsByRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsByRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsByRef
		{
			get
			{
				if(r_PIsByRef == null)
				{
					r_PIsByRef = new(this, "IsByRef", -1);
					r_PIsByRef.SetBelong(this.GetValue());
				}
				return r_PIsByRef;
			}
		}

		/// <summary>
		/// Boolean IsPointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPointer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPointer
		{
			get
			{
				if(r_PIsPointer == null)
				{
					r_PIsPointer = new(this, "IsPointer", -1);
					r_PIsPointer.SetBelong(this.GetValue());
				}
				return r_PIsPointer;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericTypeParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericTypeParameter
		{
			get
			{
				if(r_PIsGenericTypeParameter == null)
				{
					r_PIsGenericTypeParameter = new(this, "IsGenericTypeParameter", -1);
					r_PIsGenericTypeParameter.SetBelong(this.GetValue());
				}
				return r_PIsGenericTypeParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethodParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethodParameter
		{
			get
			{
				if(r_PIsGenericMethodParameter == null)
				{
					r_PIsGenericMethodParameter = new(this, "IsGenericMethodParameter", -1);
					r_PIsGenericMethodParameter.SetBelong(this.GetValue());
				}
				return r_PIsGenericMethodParameter;
			}
		}

		/// <summary>
		/// Boolean IsVariableBoundArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsVariableBoundArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsVariableBoundArray
		{
			get
			{
				if(r_PIsVariableBoundArray == null)
				{
					r_PIsVariableBoundArray = new(this, "IsVariableBoundArray", -1);
					r_PIsVariableBoundArray.SetBelong(this.GetValue());
				}
				return r_PIsVariableBoundArray;
			}
		}

		/// <summary>
		/// Boolean HasElementType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasElementType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasElementType
		{
			get
			{
				if(r_PHasElementType == null)
				{
					r_PHasElementType = new(this, "HasElementType", -1);
					r_PHasElementType.SetBelong(this.GetValue());
				}
				return r_PHasElementType;
			}
		}

		/// <summary>
		/// System.Type[] GenericTypeArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RType> r_PGenericTypeArguments;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RType> RPGenericTypeArguments
		{
			get
			{
				if(r_PGenericTypeArguments == null)
				{
					r_PGenericTypeArguments = new(this, "GenericTypeArguments", -1);
					r_PGenericTypeArguments.SetBelong(this.GetValue());
				}
				return r_PGenericTypeArguments;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.GetValue());
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean IsAbstract
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAbstract;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAbstract
		{
			get
			{
				if(r_PIsAbstract == null)
				{
					r_PIsAbstract = new(this, "IsAbstract", -1);
					r_PIsAbstract.SetBelong(this.GetValue());
				}
				return r_PIsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsImport
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsImport;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsImport
		{
			get
			{
				if(r_PIsImport == null)
				{
					r_PIsImport = new(this, "IsImport", -1);
					r_PIsImport.SetBelong(this.GetValue());
				}
				return r_PIsImport;
			}
		}

		/// <summary>
		/// Boolean IsSealed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSealed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSealed
		{
			get
			{
				if(r_PIsSealed == null)
				{
					r_PIsSealed = new(this, "IsSealed", -1);
					r_PIsSealed.SetBelong(this.GetValue());
				}
				return r_PIsSealed;
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
					r_PIsSpecialName.SetBelong(this.GetValue());
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// Boolean IsClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsClass
		{
			get
			{
				if(r_PIsClass == null)
				{
					r_PIsClass = new(this, "IsClass", -1);
					r_PIsClass.SetBelong(this.GetValue());
				}
				return r_PIsClass;
			}
		}

		/// <summary>
		/// Boolean IsNestedAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedAssembly
		{
			get
			{
				if(r_PIsNestedAssembly == null)
				{
					r_PIsNestedAssembly = new(this, "IsNestedAssembly", -1);
					r_PIsNestedAssembly.SetBelong(this.GetValue());
				}
				return r_PIsNestedAssembly;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamANDAssem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedFamANDAssem;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedFamANDAssem
		{
			get
			{
				if(r_PIsNestedFamANDAssem == null)
				{
					r_PIsNestedFamANDAssem = new(this, "IsNestedFamANDAssem", -1);
					r_PIsNestedFamANDAssem.SetBelong(this.GetValue());
				}
				return r_PIsNestedFamANDAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamily
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedFamily;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedFamily
		{
			get
			{
				if(r_PIsNestedFamily == null)
				{
					r_PIsNestedFamily = new(this, "IsNestedFamily", -1);
					r_PIsNestedFamily.SetBelong(this.GetValue());
				}
				return r_PIsNestedFamily;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamORAssem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedFamORAssem;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedFamORAssem
		{
			get
			{
				if(r_PIsNestedFamORAssem == null)
				{
					r_PIsNestedFamORAssem = new(this, "IsNestedFamORAssem", -1);
					r_PIsNestedFamORAssem.SetBelong(this.GetValue());
				}
				return r_PIsNestedFamORAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedPrivate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedPrivate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedPrivate
		{
			get
			{
				if(r_PIsNestedPrivate == null)
				{
					r_PIsNestedPrivate = new(this, "IsNestedPrivate", -1);
					r_PIsNestedPrivate.SetBelong(this.GetValue());
				}
				return r_PIsNestedPrivate;
			}
		}

		/// <summary>
		/// Boolean IsNestedPublic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedPublic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedPublic
		{
			get
			{
				if(r_PIsNestedPublic == null)
				{
					r_PIsNestedPublic = new(this, "IsNestedPublic", -1);
					r_PIsNestedPublic.SetBelong(this.GetValue());
				}
				return r_PIsNestedPublic;
			}
		}

		/// <summary>
		/// Boolean IsNotPublic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNotPublic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNotPublic
		{
			get
			{
				if(r_PIsNotPublic == null)
				{
					r_PIsNotPublic = new(this, "IsNotPublic", -1);
					r_PIsNotPublic.SetBelong(this.GetValue());
				}
				return r_PIsNotPublic;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPublic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPublic
		{
			get
			{
				if(r_PIsPublic == null)
				{
					r_PIsPublic = new(this, "IsPublic", -1);
					r_PIsPublic.SetBelong(this.GetValue());
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// Boolean IsAutoLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAutoLayout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAutoLayout
		{
			get
			{
				if(r_PIsAutoLayout == null)
				{
					r_PIsAutoLayout = new(this, "IsAutoLayout", -1);
					r_PIsAutoLayout.SetBelong(this.GetValue());
				}
				return r_PIsAutoLayout;
			}
		}

		/// <summary>
		/// Boolean IsExplicitLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsExplicitLayout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsExplicitLayout
		{
			get
			{
				if(r_PIsExplicitLayout == null)
				{
					r_PIsExplicitLayout = new(this, "IsExplicitLayout", -1);
					r_PIsExplicitLayout.SetBelong(this.GetValue());
				}
				return r_PIsExplicitLayout;
			}
		}

		/// <summary>
		/// Boolean IsLayoutSequential
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsLayoutSequential;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsLayoutSequential
		{
			get
			{
				if(r_PIsLayoutSequential == null)
				{
					r_PIsLayoutSequential = new(this, "IsLayoutSequential", -1);
					r_PIsLayoutSequential.SetBelong(this.GetValue());
				}
				return r_PIsLayoutSequential;
			}
		}

		/// <summary>
		/// Boolean IsAnsiClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAnsiClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAnsiClass
		{
			get
			{
				if(r_PIsAnsiClass == null)
				{
					r_PIsAnsiClass = new(this, "IsAnsiClass", -1);
					r_PIsAnsiClass.SetBelong(this.GetValue());
				}
				return r_PIsAnsiClass;
			}
		}

		/// <summary>
		/// Boolean IsAutoClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAutoClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAutoClass
		{
			get
			{
				if(r_PIsAutoClass == null)
				{
					r_PIsAutoClass = new(this, "IsAutoClass", -1);
					r_PIsAutoClass.SetBelong(this.GetValue());
				}
				return r_PIsAutoClass;
			}
		}

		/// <summary>
		/// Boolean IsUnicodeClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsUnicodeClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsUnicodeClass
		{
			get
			{
				if(r_PIsUnicodeClass == null)
				{
					r_PIsUnicodeClass = new(this, "IsUnicodeClass", -1);
					r_PIsUnicodeClass.SetBelong(this.GetValue());
				}
				return r_PIsUnicodeClass;
			}
		}

		/// <summary>
		/// Boolean IsCOMObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCOMObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCOMObject
		{
			get
			{
				if(r_PIsCOMObject == null)
				{
					r_PIsCOMObject = new(this, "IsCOMObject", -1);
					r_PIsCOMObject.SetBelong(this.GetValue());
				}
				return r_PIsCOMObject;
			}
		}

		/// <summary>
		/// Boolean IsContextful
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsContextful;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsContextful
		{
			get
			{
				if(r_PIsContextful == null)
				{
					r_PIsContextful = new(this, "IsContextful", -1);
					r_PIsContextful.SetBelong(this.GetValue());
				}
				return r_PIsContextful;
			}
		}

		/// <summary>
		/// Boolean IsCollectible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCollectible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCollectible
		{
			get
			{
				if(r_PIsCollectible == null)
				{
					r_PIsCollectible = new(this, "IsCollectible", -1);
					r_PIsCollectible.SetBelong(this.GetValue());
				}
				return r_PIsCollectible;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMarshalByRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMarshalByRef
		{
			get
			{
				if(r_PIsMarshalByRef == null)
				{
					r_PIsMarshalByRef = new(this, "IsMarshalByRef", -1);
					r_PIsMarshalByRef.SetBelong(this.GetValue());
				}
				return r_PIsMarshalByRef;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPrimitive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPrimitive
		{
			get
			{
				if(r_PIsPrimitive == null)
				{
					r_PIsPrimitive = new(this, "IsPrimitive", -1);
					r_PIsPrimitive.SetBelong(this.GetValue());
				}
				return r_PIsPrimitive;
			}
		}

		/// <summary>
		/// Boolean IsValueType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsValueType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsValueType
		{
			get
			{
				if(r_PIsValueType == null)
				{
					r_PIsValueType = new(this, "IsValueType", -1);
					r_PIsValueType.SetBelong(this.GetValue());
				}
				return r_PIsValueType;
			}
		}

		/// <summary>
		/// Boolean IsSignatureType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSignatureType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSignatureType
		{
			get
			{
				if(r_PIsSignatureType == null)
				{
					r_PIsSignatureType = new(this, "IsSignatureType", -1);
					r_PIsSignatureType.SetBelong(this.GetValue());
				}
				return r_PIsSignatureType;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo TypeInitializer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo r_PTypeInitializer;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo RPTypeInitializer
		{
			get
			{
				if(r_PTypeInitializer == null)
				{
					r_PTypeInitializer = new(this, "TypeInitializer", -1);
					r_PTypeInitializer.SetBelong(this.GetValue());
				}
				return r_PTypeInitializer;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsWindowsRuntimeObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsWindowsRuntimeObject
		{
			get
			{
				if(r_PIsWindowsRuntimeObject == null)
				{
					r_PIsWindowsRuntimeObject = new(this, "IsWindowsRuntimeObject", -1);
					r_PIsWindowsRuntimeObject.SetBelong(this.GetValue());
				}
				return r_PIsWindowsRuntimeObject;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsExportedToWindowsRuntime;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsExportedToWindowsRuntime
		{
			get
			{
				if(r_PIsExportedToWindowsRuntime == null)
				{
					r_PIsExportedToWindowsRuntime = new(this, "IsExportedToWindowsRuntime", -1);
					r_PIsExportedToWindowsRuntime.SetBelong(this.GetValue());
				}
				return r_PIsExportedToWindowsRuntime;
			}
		}

		/// <summary>
		/// Boolean IsInterface
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsInterface;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsInterface
		{
			get
			{
				if(r_PIsInterface == null)
				{
					r_PIsInterface = new(this, "IsInterface", -1);
					r_PIsInterface.SetBelong(this.GetValue());
				}
				return r_PIsInterface;
			}
		}

		/// <summary>
		/// System.String FullNameOrDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullNameOrDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullNameOrDefault
		{
			get
			{
				if(r_PFullNameOrDefault == null)
				{
					r_PFullNameOrDefault = new(this, "FullNameOrDefault", -1);
					r_PFullNameOrDefault.SetBelong(this.GetValue());
				}
				return r_PFullNameOrDefault;
			}
		}

		/// <summary>
		/// System.String InternalNameIfAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PInternalNameIfAvailable;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPInternalNameIfAvailable
		{
			get
			{
				if(r_PInternalNameIfAvailable == null)
				{
					r_PInternalNameIfAvailable = new(this, "InternalNameIfAvailable", -1);
					r_PInternalNameIfAvailable.SetBelong(this.GetValue());
				}
				return r_PInternalNameIfAvailable;
			}
		}

		/// <summary>
		/// System.String NameOrDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNameOrDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNameOrDefault
		{
			get
			{
				if(r_PNameOrDefault == null)
				{
					r_PNameOrDefault = new(this, "NameOrDefault", -1);
					r_PNameOrDefault.SetBelong(this.GetValue());
				}
				return r_PNameOrDefault;
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
					r_PCustomAttributes.SetBelong(this.GetValue());
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// System.RuntimeType GetType(System.String, Boolean, Boolean, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected static RMethod r_MGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark;
		public static RMethod RMGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark == null)
				{
					r_MGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark = new( ReflectionUtils.GetType("System.RuntimeType"), "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_MGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark.SetBelong(null);
				}
				return r_MGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// Void ThrowIfTypeNeverValidGenericArgument(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MThrowIfTypeNeverValidGenericArgument_RuntimeType;
		public static RMethod RMThrowIfTypeNeverValidGenericArgument_RuntimeType
		{
			get
			{
				if(r_MThrowIfTypeNeverValidGenericArgument_RuntimeType == null)
				{
					r_MThrowIfTypeNeverValidGenericArgument_RuntimeType = new( ReflectionUtils.GetType("System.RuntimeType"), "ThrowIfTypeNeverValidGenericArgument", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MThrowIfTypeNeverValidGenericArgument_RuntimeType.SetBelong(null);
				}
				return r_MThrowIfTypeNeverValidGenericArgument_RuntimeType;
			}
		}

		/// <summary>
		/// Void SanityCheckGenericArguments(System.RuntimeType[], System.RuntimeType[])
		/// </summary>
		protected static RMethod r_MSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray;
		public static RMethod RMSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray
		{
			get
			{
				if(r_MSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray == null)
				{
					r_MSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray = new( ReflectionUtils.GetType("System.RuntimeType"), "SanityCheckGenericArguments", 0,  ReflectionUtils.GetType("System.RuntimeType").MakeArrayType(),  ReflectionUtils.GetType("System.RuntimeType").MakeArrayType());
					r_MSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray.SetBelong(null);
				}
				return r_MSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray;
			}
		}

		/// <summary>
		/// Void SplitName(System.String, System.String ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_MSplitName_String_Out_String_Out_String;
		public static RMethod RMSplitName_String_Out_String_Out_String
		{
			get
			{
				if(r_MSplitName_String_Out_String_Out_String == null)
				{
					r_MSplitName_String_Out_String_Out_String = new( ReflectionUtils.GetType("System.RuntimeType"), "SplitName", 0, typeof(System.String), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_MSplitName_String_Out_String_Out_String.SetBelong(null);
				}
				return r_MSplitName_String_Out_String_Out_String;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags FilterPreCalculate(Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MFilterPreCalculate_Boolean_Boolean_Boolean;
		public static RMethod RMFilterPreCalculate_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MFilterPreCalculate_Boolean_Boolean_Boolean == null)
				{
					r_MFilterPreCalculate_Boolean_Boolean_Boolean = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterPreCalculate", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MFilterPreCalculate_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_MFilterPreCalculate_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void FilterHelper(System.Reflection.BindingFlags, System.String ByRef, Boolean, Boolean ByRef, Boolean ByRef, MemberListType ByRef)
		/// </summary>
		protected static RMethod r_MFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType;
		public static RMethod RMFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType
		{
			get
			{
				if(r_MFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType == null)
				{
					r_MFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterHelper", 0, typeof(System.Reflection.BindingFlags), typeof(System.String).MakeByRefType(), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(),  ReflectionUtils.GetType("System.RuntimeType+MemberListType").MakeByRefType());
					r_MFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType.SetBelong(null);
				}
				return r_MFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType;
			}
		}

		/// <summary>
		/// Void FilterHelper(System.Reflection.BindingFlags, System.String ByRef, Boolean ByRef, MemberListType ByRef)
		/// </summary>
		protected static RMethod r_MFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType;
		public static RMethod RMFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType
		{
			get
			{
				if(r_MFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType == null)
				{
					r_MFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterHelper", 0, typeof(System.Reflection.BindingFlags), typeof(System.String).MakeByRefType(), typeof(System.Boolean).MakeByRefType(),  ReflectionUtils.GetType("System.RuntimeType+MemberListType").MakeByRefType());
					r_MFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType.SetBelong(null);
				}
				return r_MFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType;
			}
		}

		/// <summary>
		/// Boolean FilterApplyPrefixLookup(System.Reflection.MemberInfo, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MFilterApplyPrefixLookup_MemberInfo_String_Boolean;
		public static RMethod RMFilterApplyPrefixLookup_MemberInfo_String_Boolean
		{
			get
			{
				if(r_MFilterApplyPrefixLookup_MemberInfo_String_Boolean == null)
				{
					r_MFilterApplyPrefixLookup_MemberInfo_String_Boolean = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterApplyPrefixLookup", 0, typeof(System.Reflection.MemberInfo), typeof(System.String), typeof(System.Boolean));
					r_MFilterApplyPrefixLookup_MemberInfo_String_Boolean.SetBelong(null);
				}
				return r_MFilterApplyPrefixLookup_MemberInfo_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean FilterApplyBase(System.Reflection.MemberInfo, System.Reflection.BindingFlags, Boolean, Boolean, Boolean, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean;
		public static RMethod RMFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean
		{
			get
			{
				if(r_MFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean == null)
				{
					r_MFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterApplyBase", 0, typeof(System.Reflection.MemberInfo), typeof(System.Reflection.BindingFlags), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_MFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean.SetBelong(null);
				}
				return r_MFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean FilterApplyType(System.Type, System.Reflection.BindingFlags, System.String, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MFilterApplyType_Type_BindingFlags_String_Boolean_String;
		public static RMethod RMFilterApplyType_Type_BindingFlags_String_Boolean_String
		{
			get
			{
				if(r_MFilterApplyType_Type_BindingFlags_String_Boolean_String == null)
				{
					r_MFilterApplyType_Type_BindingFlags_String_Boolean_String = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterApplyType", 0, typeof(System.Type), typeof(System.Reflection.BindingFlags), typeof(System.String), typeof(System.Boolean), typeof(System.String));
					r_MFilterApplyType_Type_BindingFlags_String_Boolean_String.SetBelong(null);
				}
				return r_MFilterApplyType_Type_BindingFlags_String_Boolean_String;
			}
		}

		/// <summary>
		/// Boolean FilterApplyMethodInfo(System.Reflection.RuntimeMethodInfo, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
		/// </summary>
		protected static RMethod r_MFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray;
		public static RMethod RMFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray
		{
			get
			{
				if(r_MFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray == null)
				{
					r_MFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterApplyMethodInfo", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType());
					r_MFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray.SetBelong(null);
				}
				return r_MFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray;
			}
		}

		/// <summary>
		/// Boolean FilterApplyConstructorInfo(System.Reflection.RuntimeConstructorInfo, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
		/// </summary>
		protected static RMethod r_MFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray;
		public static RMethod RMFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray
		{
			get
			{
				if(r_MFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray == null)
				{
					r_MFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterApplyConstructorInfo", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeConstructorInfo"), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType());
					r_MFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray.SetBelong(null);
				}
				return r_MFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray;
			}
		}

		/// <summary>
		/// Boolean FilterApplyMethodBase(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
		/// </summary>
		protected static RMethod r_MFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray;
		public static RMethod RMFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray
		{
			get
			{
				if(r_MFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray == null)
				{
					r_MFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray = new( ReflectionUtils.GetType("System.RuntimeType"), "FilterApplyMethodBase", 0, typeof(System.Reflection.MethodBase), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType());
					r_MFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray.SetBelong(null);
				}
				return r_MFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray;
			}
		}

		/// <summary>
		/// Boolean IsSpecialSerializableType()
		/// </summary>
		protected RMethod r_MIsSpecialSerializableType;
		public virtual RMethod RMIsSpecialSerializableType
		{
			get
			{
				if(r_MIsSpecialSerializableType == null)
				{
					r_MIsSpecialSerializableType = new(this, "IsSpecialSerializableType", 0);
					r_MIsSpecialSerializableType.SetBelong(this.GetValue());
				}
				return r_MIsSpecialSerializableType;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetMethodCandidates(System.String, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[], Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean;
		public virtual RMethod RMGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean
		{
			get
			{
				if(r_MGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean == null)
				{
					r_MGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean = new(this, "GetMethodCandidates", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean));
					r_MGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetConstructorCandidates(System.String, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[], Boolean)
		/// </summary>
		protected RMethod r_MGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean;
		public virtual RMethod RMGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean
		{
			get
			{
				if(r_MGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean == null)
				{
					r_MGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean = new(this, "GetConstructorCandidates", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Boolean));
					r_MGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
		/// </summary>
		protected RMethod r_MGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean;
		public virtual RMethod RMGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean
		{
			get
			{
				if(r_MGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean == null)
				{
					r_MGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean = new(this, "GetPropertyCandidates", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Type).MakeArrayType(), typeof(System.Boolean));
					r_MGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetEventCandidates(System.String, System.Reflection.BindingFlags, Boolean)
		/// </summary>
		protected RMethod r_MGetEventCandidates_String_BindingFlags_Boolean;
		public virtual RMethod RMGetEventCandidates_String_BindingFlags_Boolean
		{
			get
			{
				if(r_MGetEventCandidates_String_BindingFlags_Boolean == null)
				{
					r_MGetEventCandidates_String_BindingFlags_Boolean = new(this, "GetEventCandidates", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Boolean));
					r_MGetEventCandidates_String_BindingFlags_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetEventCandidates_String_BindingFlags_Boolean;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
		/// </summary>
		protected RMethod r_MGetFieldCandidates_String_BindingFlags_Boolean;
		public virtual RMethod RMGetFieldCandidates_String_BindingFlags_Boolean
		{
			get
			{
				if(r_MGetFieldCandidates_String_BindingFlags_Boolean == null)
				{
					r_MGetFieldCandidates_String_BindingFlags_Boolean = new(this, "GetFieldCandidates", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Boolean));
					r_MGetFieldCandidates_String_BindingFlags_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetFieldCandidates_String_BindingFlags_Boolean;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetNestedTypeCandidates(System.String, System.Reflection.BindingFlags, Boolean)
		/// </summary>
		protected RMethod r_MGetNestedTypeCandidates_String_BindingFlags_Boolean;
		public virtual RMethod RMGetNestedTypeCandidates_String_BindingFlags_Boolean
		{
			get
			{
				if(r_MGetNestedTypeCandidates_String_BindingFlags_Boolean == null)
				{
					r_MGetNestedTypeCandidates_String_BindingFlags_Boolean = new(this, "GetNestedTypeCandidates", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Boolean));
					r_MGetNestedTypeCandidates_String_BindingFlags_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetNestedTypeCandidates_String_BindingFlags_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMethods_BindingFlags;
		public virtual RMethod RMGetMethods_BindingFlags
		{
			get
			{
				if(r_MGetMethods_BindingFlags == null)
				{
					r_MGetMethods_BindingFlags = new(this, "GetMethods", 0, typeof(System.Reflection.BindingFlags));
					r_MGetMethods_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetMethods_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetConstructors_BindingFlags;
		public virtual RMethod RMGetConstructors_BindingFlags
		{
			get
			{
				if(r_MGetConstructors_BindingFlags == null)
				{
					r_MGetConstructors_BindingFlags = new(this, "GetConstructors", 0, typeof(System.Reflection.BindingFlags));
					r_MGetConstructors_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetConstructors_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetProperties_BindingFlags;
		public virtual RMethod RMGetProperties_BindingFlags
		{
			get
			{
				if(r_MGetProperties_BindingFlags == null)
				{
					r_MGetProperties_BindingFlags = new(this, "GetProperties", 0, typeof(System.Reflection.BindingFlags));
					r_MGetProperties_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetProperties_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetEvents_BindingFlags;
		public virtual RMethod RMGetEvents_BindingFlags
		{
			get
			{
				if(r_MGetEvents_BindingFlags == null)
				{
					r_MGetEvents_BindingFlags = new(this, "GetEvents", 0, typeof(System.Reflection.BindingFlags));
					r_MGetEvents_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetEvents_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetFields_BindingFlags;
		public virtual RMethod RMGetFields_BindingFlags
		{
			get
			{
				if(r_MGetFields_BindingFlags == null)
				{
					r_MGetFields_BindingFlags = new(this, "GetFields", 0, typeof(System.Reflection.BindingFlags));
					r_MGetFields_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetFields_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetNestedTypes_BindingFlags;
		public virtual RMethod RMGetNestedTypes_BindingFlags
		{
			get
			{
				if(r_MGetNestedTypes_BindingFlags == null)
				{
					r_MGetNestedTypes_BindingFlags = new(this, "GetNestedTypes", 0, typeof(System.Reflection.BindingFlags));
					r_MGetNestedTypes_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetNestedTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMembers_BindingFlags;
		public virtual RMethod RMGetMembers_BindingFlags
		{
			get
			{
				if(r_MGetMembers_BindingFlags == null)
				{
					r_MGetMembers_BindingFlags = new(this, "GetMembers", 0, typeof(System.Reflection.BindingFlags));
					r_MGetMembers_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetMembers_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructorImpl", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetPropertyImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetEvent_String_BindingFlags;
		public virtual RMethod RMGetEvent_String_BindingFlags
		{
			get
			{
				if(r_MGetEvent_String_BindingFlags == null)
				{
					r_MGetEvent_String_BindingFlags = new(this, "GetEvent", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_MGetEvent_String_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetEvent_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetField_String_BindingFlags;
		public virtual RMethod RMGetField_String_BindingFlags
		{
			get
			{
				if(r_MGetField_String_BindingFlags == null)
				{
					r_MGetField_String_BindingFlags = new(this, "GetField", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_MGetField_String_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetField_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetInterface_String_Boolean;
		public virtual RMethod RMGetInterface_String_Boolean
		{
			get
			{
				if(r_MGetInterface_String_Boolean == null)
				{
					r_MGetInterface_String_Boolean = new(this, "GetInterface", 0, typeof(System.String), typeof(System.Boolean));
					r_MGetInterface_String_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetInterface_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetNestedType_String_BindingFlags;
		public virtual RMethod RMGetNestedType_String_BindingFlags
		{
			get
			{
				if(r_MGetNestedType_String_BindingFlags == null)
				{
					r_MGetNestedType_String_BindingFlags = new(this, "GetNestedType", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_MGetNestedType_String_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetNestedType_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.MemberTypes, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMember_String_MemberTypes_BindingFlags;
		public virtual RMethod RMGetMember_String_MemberTypes_BindingFlags
		{
			get
			{
				if(r_MGetMember_String_MemberTypes_BindingFlags == null)
				{
					r_MGetMember_String_MemberTypes_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags));
					r_MGetMember_String_MemberTypes_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetMember_String_MemberTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeModule GetRuntimeModule()
		/// </summary>
		protected RMethod r_MGetRuntimeModule;
		public virtual RMethod RMGetRuntimeModule
		{
			get
			{
				if(r_MGetRuntimeModule == null)
				{
					r_MGetRuntimeModule = new(this, "GetRuntimeModule", 0);
					r_MGetRuntimeModule.SetBelong(this.GetValue());
				}
				return r_MGetRuntimeModule;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeAssembly GetRuntimeAssembly()
		/// </summary>
		protected RMethod r_MGetRuntimeAssembly;
		public virtual RMethod RMGetRuntimeAssembly
		{
			get
			{
				if(r_MGetRuntimeAssembly == null)
				{
					r_MGetRuntimeAssembly = new(this, "GetRuntimeAssembly", 0);
					r_MGetRuntimeAssembly.SetBelong(this.GetValue());
				}
				return r_MGetRuntimeAssembly;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandleInternal()
		/// </summary>
		protected RMethod r_MGetTypeHandleInternal;
		public virtual RMethod RMGetTypeHandleInternal
		{
			get
			{
				if(r_MGetTypeHandleInternal == null)
				{
					r_MGetTypeHandleInternal = new(this, "GetTypeHandleInternal", 0);
					r_MGetTypeHandleInternal.SetBelong(this.GetValue());
				}
				return r_MGetTypeHandleInternal;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.Object)
		/// </summary>
		protected RMethod r_MIsInstanceOfType_Object;
		public virtual RMethod RMIsInstanceOfType_Object
		{
			get
			{
				if(r_MIsInstanceOfType_Object == null)
				{
					r_MIsInstanceOfType_Object = new(this, "IsInstanceOfType", 0, typeof(System.Object));
					r_MIsInstanceOfType_Object.SetBelong(this.GetValue());
				}
				return r_MIsInstanceOfType_Object;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Reflection.TypeInfo)
		/// </summary>
		protected RMethod r_MIsAssignableFrom_TypeInfo;
		public virtual RMethod RMIsAssignableFrom_TypeInfo
		{
			get
			{
				if(r_MIsAssignableFrom_TypeInfo == null)
				{
					r_MIsAssignableFrom_TypeInfo = new(this, "IsAssignableFrom", 0, typeof(System.Reflection.TypeInfo));
					r_MIsAssignableFrom_TypeInfo.SetBelong(this.GetValue());
				}
				return r_MIsAssignableFrom_TypeInfo;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Type)
		/// </summary>
		protected RMethod r_MIsAssignableFrom_Type;
		public virtual RMethod RMIsAssignableFrom_Type
		{
			get
			{
				if(r_MIsAssignableFrom_Type == null)
				{
					r_MIsAssignableFrom_Type = new(this, "IsAssignableFrom", 0, typeof(System.Type));
					r_MIsAssignableFrom_Type.SetBelong(this.GetValue());
				}
				return r_MIsAssignableFrom_Type;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.Type)
		/// </summary>
		protected RMethod r_MIsEquivalentTo_Type;
		public virtual RMethod RMIsEquivalentTo_Type
		{
			get
			{
				if(r_MIsEquivalentTo_Type == null)
				{
					r_MIsEquivalentTo_Type = new(this, "IsEquivalentTo", 0, typeof(System.Type));
					r_MIsEquivalentTo_Type.SetBelong(this.GetValue());
				}
				return r_MIsEquivalentTo_Type;
			}
		}

		/// <summary>
		/// System.RuntimeType GetBaseType()
		/// </summary>
		protected RMethod r_MGetBaseType;
		public virtual RMethod RMGetBaseType
		{
			get
			{
				if(r_MGetBaseType == null)
				{
					r_MGetBaseType = new(this, "GetBaseType", 0);
					r_MGetBaseType.SetBelong(this.GetValue());
				}
				return r_MGetBaseType;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		/// </summary>
		protected RMethod r_MGetAttributeFlagsImpl;
		public virtual RMethod RMGetAttributeFlagsImpl
		{
			get
			{
				if(r_MGetAttributeFlagsImpl == null)
				{
					r_MGetAttributeFlagsImpl = new(this, "GetAttributeFlagsImpl", 0);
					r_MGetAttributeFlagsImpl.SetBelong(this.GetValue());
				}
				return r_MGetAttributeFlagsImpl;
			}
		}

		/// <summary>
		/// Boolean IsContextfulImpl()
		/// </summary>
		protected RMethod r_MIsContextfulImpl;
		public virtual RMethod RMIsContextfulImpl
		{
			get
			{
				if(r_MIsContextfulImpl == null)
				{
					r_MIsContextfulImpl = new(this, "IsContextfulImpl", 0);
					r_MIsContextfulImpl.SetBelong(this.GetValue());
				}
				return r_MIsContextfulImpl;
			}
		}

		/// <summary>
		/// Boolean IsByRefImpl()
		/// </summary>
		protected RMethod r_MIsByRefImpl;
		public virtual RMethod RMIsByRefImpl
		{
			get
			{
				if(r_MIsByRefImpl == null)
				{
					r_MIsByRefImpl = new(this, "IsByRefImpl", 0);
					r_MIsByRefImpl.SetBelong(this.GetValue());
				}
				return r_MIsByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsPrimitiveImpl()
		/// </summary>
		protected RMethod r_MIsPrimitiveImpl;
		public virtual RMethod RMIsPrimitiveImpl
		{
			get
			{
				if(r_MIsPrimitiveImpl == null)
				{
					r_MIsPrimitiveImpl = new(this, "IsPrimitiveImpl", 0);
					r_MIsPrimitiveImpl.SetBelong(this.GetValue());
				}
				return r_MIsPrimitiveImpl;
			}
		}

		/// <summary>
		/// Boolean IsPointerImpl()
		/// </summary>
		protected RMethod r_MIsPointerImpl;
		public virtual RMethod RMIsPointerImpl
		{
			get
			{
				if(r_MIsPointerImpl == null)
				{
					r_MIsPointerImpl = new(this, "IsPointerImpl", 0);
					r_MIsPointerImpl.SetBelong(this.GetValue());
				}
				return r_MIsPointerImpl;
			}
		}

		/// <summary>
		/// Boolean IsCOMObjectImpl()
		/// </summary>
		protected RMethod r_MIsCOMObjectImpl;
		public virtual RMethod RMIsCOMObjectImpl
		{
			get
			{
				if(r_MIsCOMObjectImpl == null)
				{
					r_MIsCOMObjectImpl = new(this, "IsCOMObjectImpl", 0);
					r_MIsCOMObjectImpl.SetBelong(this.GetValue());
				}
				return r_MIsCOMObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObjectImpl()
		/// </summary>
		protected RMethod r_MIsWindowsRuntimeObjectImpl;
		public virtual RMethod RMIsWindowsRuntimeObjectImpl
		{
			get
			{
				if(r_MIsWindowsRuntimeObjectImpl == null)
				{
					r_MIsWindowsRuntimeObjectImpl = new(this, "IsWindowsRuntimeObjectImpl", 0);
					r_MIsWindowsRuntimeObjectImpl.SetBelong(this.GetValue());
				}
				return r_MIsWindowsRuntimeObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntimeImpl()
		/// </summary>
		protected RMethod r_MIsExportedToWindowsRuntimeImpl;
		public virtual RMethod RMIsExportedToWindowsRuntimeImpl
		{
			get
			{
				if(r_MIsExportedToWindowsRuntimeImpl == null)
				{
					r_MIsExportedToWindowsRuntimeImpl = new(this, "IsExportedToWindowsRuntimeImpl", 0);
					r_MIsExportedToWindowsRuntimeImpl.SetBelong(this.GetValue());
				}
				return r_MIsExportedToWindowsRuntimeImpl;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObjectType(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsWindowsRuntimeObjectType_RuntimeType;
		public static RMethod RMIsWindowsRuntimeObjectType_RuntimeType
		{
			get
			{
				if(r_MIsWindowsRuntimeObjectType_RuntimeType == null)
				{
					r_MIsWindowsRuntimeObjectType_RuntimeType = new( ReflectionUtils.GetType("System.RuntimeType"), "IsWindowsRuntimeObjectType", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MIsWindowsRuntimeObjectType_RuntimeType.SetBelong(null);
				}
				return r_MIsWindowsRuntimeObjectType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean IsTypeExportedToWindowsRuntime(System.RuntimeType)
		/// </summary>
		protected static RMethod r_MIsTypeExportedToWindowsRuntime_RuntimeType;
		public static RMethod RMIsTypeExportedToWindowsRuntime_RuntimeType
		{
			get
			{
				if(r_MIsTypeExportedToWindowsRuntime_RuntimeType == null)
				{
					r_MIsTypeExportedToWindowsRuntime_RuntimeType = new( ReflectionUtils.GetType("System.RuntimeType"), "IsTypeExportedToWindowsRuntime", 0,  ReflectionUtils.GetType("System.RuntimeType"));
					r_MIsTypeExportedToWindowsRuntime_RuntimeType.SetBelong(null);
				}
				return r_MIsTypeExportedToWindowsRuntime_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttributeImpl()
		/// </summary>
		protected RMethod r_MHasProxyAttributeImpl;
		public virtual RMethod RMHasProxyAttributeImpl
		{
			get
			{
				if(r_MHasProxyAttributeImpl == null)
				{
					r_MHasProxyAttributeImpl = new(this, "HasProxyAttributeImpl", 0);
					r_MHasProxyAttributeImpl.SetBelong(this.GetValue());
				}
				return r_MHasProxyAttributeImpl;
			}
		}

		/// <summary>
		/// Boolean IsDelegate()
		/// </summary>
		protected RMethod r_MIsDelegate;
		public virtual RMethod RMIsDelegate
		{
			get
			{
				if(r_MIsDelegate == null)
				{
					r_MIsDelegate = new(this, "IsDelegate", 0);
					r_MIsDelegate.SetBelong(this.GetValue());
				}
				return r_MIsDelegate;
			}
		}

		/// <summary>
		/// Boolean IsValueTypeImpl()
		/// </summary>
		protected RMethod r_MIsValueTypeImpl;
		public virtual RMethod RMIsValueTypeImpl
		{
			get
			{
				if(r_MIsValueTypeImpl == null)
				{
					r_MIsValueTypeImpl = new(this, "IsValueTypeImpl", 0);
					r_MIsValueTypeImpl.SetBelong(this.GetValue());
				}
				return r_MIsValueTypeImpl;
			}
		}

		/// <summary>
		/// Boolean HasElementTypeImpl()
		/// </summary>
		protected RMethod r_MHasElementTypeImpl;
		public virtual RMethod RMHasElementTypeImpl
		{
			get
			{
				if(r_MHasElementTypeImpl == null)
				{
					r_MHasElementTypeImpl = new(this, "HasElementTypeImpl", 0);
					r_MHasElementTypeImpl.SetBelong(this.GetValue());
				}
				return r_MHasElementTypeImpl;
			}
		}

		/// <summary>
		/// Boolean IsArrayImpl()
		/// </summary>
		protected RMethod r_MIsArrayImpl;
		public virtual RMethod RMIsArrayImpl
		{
			get
			{
				if(r_MIsArrayImpl == null)
				{
					r_MIsArrayImpl = new(this, "IsArrayImpl", 0);
					r_MIsArrayImpl.SetBelong(this.GetValue());
				}
				return r_MIsArrayImpl;
			}
		}

		/// <summary>
		/// Int32 GetArrayRank()
		/// </summary>
		protected RMethod r_MGetArrayRank;
		public virtual RMethod RMGetArrayRank
		{
			get
			{
				if(r_MGetArrayRank == null)
				{
					r_MGetArrayRank = new(this, "GetArrayRank", 0);
					r_MGetArrayRank.SetBelong(this.GetValue());
				}
				return r_MGetArrayRank;
			}
		}

		/// <summary>
		/// System.Type GetElementType()
		/// </summary>
		protected RMethod r_MGetElementType;
		public virtual RMethod RMGetElementType
		{
			get
			{
				if(r_MGetElementType == null)
				{
					r_MGetElementType = new(this, "GetElementType", 0);
					r_MGetElementType.SetBelong(this.GetValue());
				}
				return r_MGetElementType;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNames()
		/// </summary>
		protected RMethod r_MGetEnumNames;
		public virtual RMethod RMGetEnumNames
		{
			get
			{
				if(r_MGetEnumNames == null)
				{
					r_MGetEnumNames = new(this, "GetEnumNames", 0);
					r_MGetEnumNames.SetBelong(this.GetValue());
				}
				return r_MGetEnumNames;
			}
		}

		/// <summary>
		/// System.Array GetEnumValues()
		/// </summary>
		protected RMethod r_MGetEnumValues;
		public virtual RMethod RMGetEnumValues
		{
			get
			{
				if(r_MGetEnumValues == null)
				{
					r_MGetEnumValues = new(this, "GetEnumValues", 0);
					r_MGetEnumValues.SetBelong(this.GetValue());
				}
				return r_MGetEnumValues;
			}
		}

		/// <summary>
		/// System.Type GetEnumUnderlyingType()
		/// </summary>
		protected RMethod r_MGetEnumUnderlyingType;
		public virtual RMethod RMGetEnumUnderlyingType
		{
			get
			{
				if(r_MGetEnumUnderlyingType == null)
				{
					r_MGetEnumUnderlyingType = new(this, "GetEnumUnderlyingType", 0);
					r_MGetEnumUnderlyingType.SetBelong(this.GetValue());
				}
				return r_MGetEnumUnderlyingType;
			}
		}

		/// <summary>
		/// Boolean IsEnumDefined(System.Object)
		/// </summary>
		protected RMethod r_MIsEnumDefined_Object;
		public virtual RMethod RMIsEnumDefined_Object
		{
			get
			{
				if(r_MIsEnumDefined_Object == null)
				{
					r_MIsEnumDefined_Object = new(this, "IsEnumDefined", 0, typeof(System.Object));
					r_MIsEnumDefined_Object.SetBelong(this.GetValue());
				}
				return r_MIsEnumDefined_Object;
			}
		}

		/// <summary>
		/// System.String GetEnumName(System.Object)
		/// </summary>
		protected RMethod r_MGetEnumName_Object;
		public virtual RMethod RMGetEnumName_Object
		{
			get
			{
				if(r_MGetEnumName_Object == null)
				{
					r_MGetEnumName_Object = new(this, "GetEnumName", 0, typeof(System.Object));
					r_MGetEnumName_Object.SetBelong(this.GetValue());
				}
				return r_MGetEnumName_Object;
			}
		}

		/// <summary>
		/// System.RuntimeType[] GetGenericArgumentsInternal()
		/// </summary>
		protected RMethod r_MGetGenericArgumentsInternal;
		public virtual RMethod RMGetGenericArgumentsInternal
		{
			get
			{
				if(r_MGetGenericArgumentsInternal == null)
				{
					r_MGetGenericArgumentsInternal = new(this, "GetGenericArgumentsInternal", 0);
					r_MGetGenericArgumentsInternal.SetBelong(this.GetValue());
				}
				return r_MGetGenericArgumentsInternal;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_MGetGenericArguments;
		public virtual RMethod RMGetGenericArguments
		{
			get
			{
				if(r_MGetGenericArguments == null)
				{
					r_MGetGenericArguments = new(this, "GetGenericArguments", 0);
					r_MGetGenericArguments.SetBelong(this.GetValue());
				}
				return r_MGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type[])
		/// </summary>
		protected RMethod r_MMakeGenericType_TypeArray;
		public virtual RMethod RMMakeGenericType_TypeArray
		{
			get
			{
				if(r_MMakeGenericType_TypeArray == null)
				{
					r_MMakeGenericType_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type).MakeArrayType());
					r_MMakeGenericType_TypeArray.SetBelong(this.GetValue());
				}
				return r_MMakeGenericType_TypeArray;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition()
		/// </summary>
		protected RMethod r_MGetGenericTypeDefinition;
		public virtual RMethod RMGetGenericTypeDefinition
		{
			get
			{
				if(r_MGetGenericTypeDefinition == null)
				{
					r_MGetGenericTypeDefinition = new(this, "GetGenericTypeDefinition", 0);
					r_MGetGenericTypeDefinition.SetBelong(this.GetValue());
				}
				return r_MGetGenericTypeDefinition;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetDefaultMembers()
		/// </summary>
		protected RMethod r_MGetDefaultMembers;
		public virtual RMethod RMGetDefaultMembers
		{
			get
			{
				if(r_MGetDefaultMembers == null)
				{
					r_MGetDefaultMembers = new(this, "GetDefaultMembers", 0);
					r_MGetDefaultMembers.SetBelong(this.GetValue());
				}
				return r_MGetDefaultMembers;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[])
		/// </summary>
		protected RMethod r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
		public virtual RMethod RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray
		{
			get
			{
				if(r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray == null)
				{
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType());
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.SetBelong(this.GetValue());
				}
				return r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_Mop_Equality_RuntimeType_RuntimeType;
		public static RMethod RMop_Equality_RuntimeType_RuntimeType
		{
			get
			{
				if(r_Mop_Equality_RuntimeType_RuntimeType == null)
				{
					r_Mop_Equality_RuntimeType_RuntimeType = new( ReflectionUtils.GetType("System.RuntimeType"), "op_Equality", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_Mop_Equality_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_Mop_Equality_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.RuntimeType, System.RuntimeType)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RuntimeType_RuntimeType;
		public static RMethod RMop_Inequality_RuntimeType_RuntimeType
		{
			get
			{
				if(r_Mop_Inequality_RuntimeType_RuntimeType == null)
				{
					r_Mop_Inequality_RuntimeType_RuntimeType = new( ReflectionUtils.GetType("System.RuntimeType"), "op_Inequality", 0,  ReflectionUtils.GetType("System.RuntimeType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_Mop_Inequality_RuntimeType_RuntimeType.SetBelong(null);
				}
				return r_Mop_Inequality_RuntimeType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.GetValue());
				}
				return r_MClone;
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
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
					r_MGetCustomAttributes_Boolean.SetBelong(this.GetValue());
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
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetCustomAttributes_Type_Boolean;
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
					r_MIsDefined_Type_Boolean.SetBelong(this.GetValue());
				}
				return r_MIsDefined_Type_Boolean;
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
					r_MGetCustomAttributesData.SetBelong(this.GetValue());
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// System.String FormatTypeName(Boolean)
		/// </summary>
		protected RMethod r_MFormatTypeName_Boolean;
		public virtual RMethod RMFormatTypeName_Boolean
		{
			get
			{
				if(r_MFormatTypeName_Boolean == null)
				{
					r_MFormatTypeName_Boolean = new(this, "FormatTypeName", 0, typeof(System.Boolean));
					r_MFormatTypeName_Boolean.SetBelong(this.GetValue());
				}
				return r_MFormatTypeName_Boolean;
			}
		}

		/// <summary>
		/// Void CreateInstanceCheckThis()
		/// </summary>
		protected RMethod r_MCreateInstanceCheckThis;
		public virtual RMethod RMCreateInstanceCheckThis
		{
			get
			{
				if(r_MCreateInstanceCheckThis == null)
				{
					r_MCreateInstanceCheckThis = new(this, "CreateInstanceCheckThis", 0);
					r_MCreateInstanceCheckThis.SetBelong(this.GetValue());
				}
				return r_MCreateInstanceCheckThis;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[], System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark;
		public virtual RMethod RMCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark
		{
			get
			{
				if(r_MCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark == null)
				{
					r_MCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark = new(this, "CreateInstanceImpl", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType(),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_MCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark.SetBelong(this.GetValue());
				}
				return r_MCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Object ActivationCreateInstance(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo, System.Object[])
		/// </summary>
		protected RMethod r_MActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
		public virtual RMethod RMActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray
		{
			get
			{
				if(r_MActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray == null)
				{
					r_MActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray = new(this, "ActivationCreateInstance", 0, typeof(System.Reflection.MethodBase), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Object).MakeArrayType());
					r_MActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.SetBelong(this.GetValue());
				}
				return r_MActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceDefaultCtor(Boolean, Boolean, Boolean, Boolean, System.Threading.StackCrawlMark ByRef)
		/// </summary>
		protected RMethod r_MCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark;
		public virtual RMethod RMCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark
		{
			get
			{
				if(r_MCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark == null)
				{
					r_MCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark = new(this, "CreateInstanceDefaultCtor", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean),  ReflectionUtils.GetType("System.Threading.StackCrawlMark").MakeByRefType());
					r_MCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark.SetBelong(this.GetValue());
				}
				return r_MCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeConstructorInfo GetDefaultConstructor()
		/// </summary>
		protected RMethod r_MGetDefaultConstructor;
		public virtual RMethod RMGetDefaultConstructor
		{
			get
			{
				if(r_MGetDefaultConstructor == null)
				{
					r_MGetDefaultConstructor = new(this, "GetDefaultConstructor", 0);
					r_MGetDefaultConstructor.SetBelong(this.GetValue());
				}
				return r_MGetDefaultConstructor;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetCorrespondingInflatedMethod(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MGetCorrespondingInflatedMethod_MethodInfo;
		public virtual RMethod RMGetCorrespondingInflatedMethod_MethodInfo
		{
			get
			{
				if(r_MGetCorrespondingInflatedMethod_MethodInfo == null)
				{
					r_MGetCorrespondingInflatedMethod_MethodInfo = new(this, "GetCorrespondingInflatedMethod", 0, typeof(System.Reflection.MethodInfo));
					r_MGetCorrespondingInflatedMethod_MethodInfo.SetBelong(this.GetValue());
				}
				return r_MGetCorrespondingInflatedMethod_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetCorrespondingInflatedConstructor(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_MGetCorrespondingInflatedConstructor_ConstructorInfo;
		public virtual RMethod RMGetCorrespondingInflatedConstructor_ConstructorInfo
		{
			get
			{
				if(r_MGetCorrespondingInflatedConstructor_ConstructorInfo == null)
				{
					r_MGetCorrespondingInflatedConstructor_ConstructorInfo = new(this, "GetCorrespondingInflatedConstructor", 0, typeof(System.Reflection.ConstructorInfo));
					r_MGetCorrespondingInflatedConstructor_ConstructorInfo.SetBelong(this.GetValue());
				}
				return r_MGetCorrespondingInflatedConstructor_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MGetMethod_MethodInfo;
		public virtual RMethod RMGetMethod_MethodInfo
		{
			get
			{
				if(r_MGetMethod_MethodInfo == null)
				{
					r_MGetMethod_MethodInfo = new(this, "GetMethod", 0, typeof(System.Reflection.MethodInfo));
					r_MGetMethod_MethodInfo.SetBelong(this.GetValue());
				}
				return r_MGetMethod_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_MGetConstructor_ConstructorInfo;
		public virtual RMethod RMGetConstructor_ConstructorInfo
		{
			get
			{
				if(r_MGetConstructor_ConstructorInfo == null)
				{
					r_MGetConstructor_ConstructorInfo = new(this, "GetConstructor", 0, typeof(System.Reflection.ConstructorInfo));
					r_MGetConstructor_ConstructorInfo.SetBelong(this.GetValue());
				}
				return r_MGetConstructor_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_MGetField_FieldInfo;
		public virtual RMethod RMGetField_FieldInfo
		{
			get
			{
				if(r_MGetField_FieldInfo == null)
				{
					r_MGetField_FieldInfo = new(this, "GetField", 0, typeof(System.Reflection.FieldInfo));
					r_MGetField_FieldInfo.SetBelong(this.GetValue());
				}
				return r_MGetField_FieldInfo;
			}
		}

		/// <summary>
		/// System.String GetDefaultMemberName()
		/// </summary>
		protected RMethod r_MGetDefaultMemberName;
		public virtual RMethod RMGetDefaultMemberName
		{
			get
			{
				if(r_MGetDefaultMemberName == null)
				{
					r_MGetDefaultMemberName = new(this, "GetDefaultMemberName", 0);
					r_MGetDefaultMemberName.SetBelong(this.GetValue());
				}
				return r_MGetDefaultMemberName;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeConstructorInfo GetSerializationCtor()
		/// </summary>
		protected RMethod r_MGetSerializationCtor;
		public virtual RMethod RMGetSerializationCtor
		{
			get
			{
				if(r_MGetSerializationCtor == null)
				{
					r_MGetSerializationCtor = new(this, "GetSerializationCtor", 0);
					r_MGetSerializationCtor.SetBelong(this.GetValue());
				}
				return r_MGetSerializationCtor;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceSlow(Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean = new(this, "CreateInstanceSlow", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceMono(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MCreateInstanceMono_Boolean_Boolean;
		public virtual RMethod RMCreateInstanceMono_Boolean_Boolean
		{
			get
			{
				if(r_MCreateInstanceMono_Boolean_Boolean == null)
				{
					r_MCreateInstanceMono_Boolean_Boolean = new(this, "CreateInstanceMono", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MCreateInstanceMono_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MCreateInstanceMono_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Object CheckValue(System.Object, System.Reflection.Binder, System.Globalization.CultureInfo, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MCheckValue_Object_Binder_CultureInfo_BindingFlags;
		public virtual RMethod RMCheckValue_Object_Binder_CultureInfo_BindingFlags
		{
			get
			{
				if(r_MCheckValue_Object_Binder_CultureInfo_BindingFlags == null)
				{
					r_MCheckValue_Object_Binder_CultureInfo_BindingFlags = new(this, "CheckValue", 0, typeof(System.Object), typeof(System.Reflection.Binder), typeof(System.Globalization.CultureInfo), typeof(System.Reflection.BindingFlags));
					r_MCheckValue_Object_Binder_CultureInfo_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MCheckValue_Object_Binder_CultureInfo_BindingFlags;
			}
		}

		/// <summary>
		/// System.Object TryConvertToType(System.Object, Boolean ByRef)
		/// </summary>
		protected RMethod r_MTryConvertToType_Object_Ref_Boolean;
		public virtual RMethod RMTryConvertToType_Object_Ref_Boolean
		{
			get
			{
				if(r_MTryConvertToType_Object_Ref_Boolean == null)
				{
					r_MTryConvertToType_Object_Ref_Boolean = new(this, "TryConvertToType", 0, typeof(System.Object), typeof(System.Boolean).MakeByRefType());
					r_MTryConvertToType_Object_Ref_Boolean.SetBelong(this.GetValue());
				}
				return r_MTryConvertToType_Object_Ref_Boolean;
			}
		}

		/// <summary>
		/// System.Object IsConvertibleToPrimitiveType(System.Object, System.Type)
		/// </summary>
		protected static RMethod r_MIsConvertibleToPrimitiveType_Object_Type;
		public static RMethod RMIsConvertibleToPrimitiveType_Object_Type
		{
			get
			{
				if(r_MIsConvertibleToPrimitiveType_Object_Type == null)
				{
					r_MIsConvertibleToPrimitiveType_Object_Type = new( ReflectionUtils.GetType("System.RuntimeType"), "IsConvertibleToPrimitiveType", 0, typeof(System.Object), typeof(System.Type));
					r_MIsConvertibleToPrimitiveType_Object_Type.SetBelong(null);
				}
				return r_MIsConvertibleToPrimitiveType_Object_Type;
			}
		}

		/// <summary>
		/// System.String GetCachedName(System.TypeNameKind)
		/// </summary>
		protected RMethod r_MGetCachedName_TypeNameKind;
		public virtual RMethod RMGetCachedName_TypeNameKind
		{
			get
			{
				if(r_MGetCachedName_TypeNameKind == null)
				{
					r_MGetCachedName_TypeNameKind = new(this, "GetCachedName", 0,  ReflectionUtils.GetType("System.TypeNameKind"));
					r_MGetCachedName_TypeNameKind.SetBelong(this.GetValue());
				}
				return r_MGetCachedName_TypeNameKind;
			}
		}

		/// <summary>
		/// System.Type make_array_type(Int32)
		/// </summary>
		protected RMethod r_Mmake_array_type_Int32;
		public virtual RMethod RMmake_array_type_Int32
		{
			get
			{
				if(r_Mmake_array_type_Int32 == null)
				{
					r_Mmake_array_type_Int32 = new(this, "make_array_type", 0, typeof(System.Int32));
					r_Mmake_array_type_Int32.SetBelong(this.GetValue());
				}
				return r_Mmake_array_type_Int32;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType()
		/// </summary>
		protected RMethod r_MMakeArrayType;
		public virtual RMethod RMMakeArrayType
		{
			get
			{
				if(r_MMakeArrayType == null)
				{
					r_MMakeArrayType = new(this, "MakeArrayType", 0);
					r_MMakeArrayType.SetBelong(this.GetValue());
				}
				return r_MMakeArrayType;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType(Int32)
		/// </summary>
		protected RMethod r_MMakeArrayType_Int32;
		public virtual RMethod RMMakeArrayType_Int32
		{
			get
			{
				if(r_MMakeArrayType_Int32 == null)
				{
					r_MMakeArrayType_Int32 = new(this, "MakeArrayType", 0, typeof(System.Int32));
					r_MMakeArrayType_Int32.SetBelong(this.GetValue());
				}
				return r_MMakeArrayType_Int32;
			}
		}

		/// <summary>
		/// System.Type make_byref_type()
		/// </summary>
		protected RMethod r_Mmake_byref_type;
		public virtual RMethod RMmake_byref_type
		{
			get
			{
				if(r_Mmake_byref_type == null)
				{
					r_Mmake_byref_type = new(this, "make_byref_type", 0);
					r_Mmake_byref_type.SetBelong(this.GetValue());
				}
				return r_Mmake_byref_type;
			}
		}

		/// <summary>
		/// System.Type MakeByRefType()
		/// </summary>
		protected RMethod r_MMakeByRefType;
		public virtual RMethod RMMakeByRefType
		{
			get
			{
				if(r_MMakeByRefType == null)
				{
					r_MMakeByRefType = new(this, "MakeByRefType", 0);
					r_MMakeByRefType.SetBelong(this.GetValue());
				}
				return r_MMakeByRefType;
			}
		}

		/// <summary>
		/// System.Type MakePointerType(System.Type)
		/// </summary>
		protected static RMethod r_MMakePointerType_Type;
		public static RMethod RMMakePointerType_Type
		{
			get
			{
				if(r_MMakePointerType_Type == null)
				{
					r_MMakePointerType_Type = new( ReflectionUtils.GetType("System.RuntimeType"), "MakePointerType", 0, typeof(System.Type));
					r_MMakePointerType_Type.SetBelong(null);
				}
				return r_MMakePointerType_Type;
			}
		}

		/// <summary>
		/// System.Type MakePointerType()
		/// </summary>
		protected RMethod r_MMakePointerType;
		public virtual RMethod RMMakePointerType
		{
			get
			{
				if(r_MMakePointerType == null)
				{
					r_MMakePointerType = new(this, "MakePointerType", 0);
					r_MMakePointerType.SetBelong(this.GetValue());
				}
				return r_MMakePointerType;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericParameterConstraints()
		/// </summary>
		protected RMethod r_MGetGenericParameterConstraints;
		public virtual RMethod RMGetGenericParameterConstraints
		{
			get
			{
				if(r_MGetGenericParameterConstraints == null)
				{
					r_MGetGenericParameterConstraints = new(this, "GetGenericParameterConstraints", 0);
					r_MGetGenericParameterConstraints.SetBelong(this.GetValue());
				}
				return r_MGetGenericParameterConstraints;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceForAnotherGenericParameter(System.Type, System.RuntimeType)
		/// </summary>
		protected static RMethod r_MCreateInstanceForAnotherGenericParameter_Type_RuntimeType;
		public static RMethod RMCreateInstanceForAnotherGenericParameter_Type_RuntimeType
		{
			get
			{
				if(r_MCreateInstanceForAnotherGenericParameter_Type_RuntimeType == null)
				{
					r_MCreateInstanceForAnotherGenericParameter_Type_RuntimeType = new( ReflectionUtils.GetType("System.RuntimeType"), "CreateInstanceForAnotherGenericParameter", 0, typeof(System.Type),  ReflectionUtils.GetType("System.RuntimeType"));
					r_MCreateInstanceForAnotherGenericParameter_Type_RuntimeType.SetBelong(null);
				}
				return r_MCreateInstanceForAnotherGenericParameter_Type_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_MMakeGenericType_Type_TypeArray;
		public static RMethod RMMakeGenericType_Type_TypeArray
		{
			get
			{
				if(r_MMakeGenericType_Type_TypeArray == null)
				{
					r_MMakeGenericType_Type_TypeArray = new( ReflectionUtils.GetType("System.RuntimeType"), "MakeGenericType", 0, typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MMakeGenericType_Type_TypeArray.SetBelong(null);
				}
				return r_MMakeGenericType_Type_TypeArray;
			}
		}

		/// <summary>
		/// IntPtr GetMethodsByName_native(IntPtr, System.Reflection.BindingFlags, MemberListType)
		/// </summary>
		protected RMethod r_MGetMethodsByName_native_IntPtr_BindingFlags_MemberListType;
		public virtual RMethod RMGetMethodsByName_native_IntPtr_BindingFlags_MemberListType
		{
			get
			{
				if(r_MGetMethodsByName_native_IntPtr_BindingFlags_MemberListType == null)
				{
					r_MGetMethodsByName_native_IntPtr_BindingFlags_MemberListType = new(this, "GetMethodsByName_native", 0, typeof(System.IntPtr), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"));
					r_MGetMethodsByName_native_IntPtr_BindingFlags_MemberListType.SetBelong(this.GetValue());
				}
				return r_MGetMethodsByName_native_IntPtr_BindingFlags_MemberListType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeMethodInfo[] GetMethodsByName(System.String, System.Reflection.BindingFlags, MemberListType, System.RuntimeType)
		/// </summary>
		protected RMethod r_MGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType;
		public virtual RMethod RMGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType
		{
			get
			{
				if(r_MGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType == null)
				{
					r_MGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType = new(this, "GetMethodsByName", 0, typeof(System.String), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_MGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType.SetBelong(this.GetValue());
				}
				return r_MGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType;
			}
		}

		/// <summary>
		/// IntPtr GetPropertiesByName_native(IntPtr, System.Reflection.BindingFlags, MemberListType)
		/// </summary>
		protected RMethod r_MGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType;
		public virtual RMethod RMGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType
		{
			get
			{
				if(r_MGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType == null)
				{
					r_MGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType = new(this, "GetPropertiesByName_native", 0, typeof(System.IntPtr), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"));
					r_MGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType.SetBelong(this.GetValue());
				}
				return r_MGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType;
			}
		}

		/// <summary>
		/// IntPtr GetConstructors_native(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetConstructors_native_BindingFlags;
		public virtual RMethod RMGetConstructors_native_BindingFlags
		{
			get
			{
				if(r_MGetConstructors_native_BindingFlags == null)
				{
					r_MGetConstructors_native_BindingFlags = new(this, "GetConstructors_native", 0, typeof(System.Reflection.BindingFlags));
					r_MGetConstructors_native_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetConstructors_native_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeConstructorInfo[] GetConstructors_internal(System.Reflection.BindingFlags, System.RuntimeType)
		/// </summary>
		protected RMethod r_MGetConstructors_internal_BindingFlags_RuntimeType;
		public virtual RMethod RMGetConstructors_internal_BindingFlags_RuntimeType
		{
			get
			{
				if(r_MGetConstructors_internal_BindingFlags_RuntimeType == null)
				{
					r_MGetConstructors_internal_BindingFlags_RuntimeType = new(this, "GetConstructors_internal", 0, typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType"));
					r_MGetConstructors_internal_BindingFlags_RuntimeType.SetBelong(this.GetValue());
				}
				return r_MGetConstructors_internal_BindingFlags_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimePropertyInfo[] GetPropertiesByName(System.String, System.Reflection.BindingFlags, MemberListType, System.RuntimeType)
		/// </summary>
		protected RMethod r_MGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType;
		public virtual RMethod RMGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType
		{
			get
			{
				if(r_MGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType == null)
				{
					r_MGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType = new(this, "GetPropertiesByName", 0, typeof(System.String), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_MGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType.SetBelong(this.GetValue());
				}
				return r_MGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.InterfaceMapping GetInterfaceMap(System.Type)
		/// </summary>
		protected RMethod r_MGetInterfaceMap_Type;
		public virtual RMethod RMGetInterfaceMap_Type
		{
			get
			{
				if(r_MGetInterfaceMap_Type == null)
				{
					r_MGetInterfaceMap_Type = new(this, "GetInterfaceMap", 0, typeof(System.Type));
					r_MGetInterfaceMap_Type.SetBelong(this.GetValue());
				}
				return r_MGetInterfaceMap_Type;
			}
		}

		/// <summary>
		/// Void GetInterfaceMapData(System.Type, System.Type, System.Reflection.MethodInfo[] ByRef, System.Reflection.MethodInfo[] ByRef)
		/// </summary>
		protected static RMethod r_MGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray;
		public static RMethod RMGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray
		{
			get
			{
				if(r_MGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray == null)
				{
					r_MGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray = new( ReflectionUtils.GetType("System.RuntimeType"), "GetInterfaceMapData", 0, typeof(System.Type), typeof(System.Type), typeof(System.Reflection.MethodInfo).MakeArrayType().MakeByRefType(), typeof(System.Reflection.MethodInfo).MakeArrayType().MakeByRefType());
					r_MGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray.SetBelong(null);
				}
				return r_MGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray;
			}
		}

		/// <summary>
		/// Void GetGUID(System.Type, Byte[])
		/// </summary>
		protected static RMethod r_MGetGUID_Type_ByteArray;
		public static RMethod RMGetGUID_Type_ByteArray
		{
			get
			{
				if(r_MGetGUID_Type_ByteArray == null)
				{
					r_MGetGUID_Type_ByteArray = new( ReflectionUtils.GetType("System.RuntimeType"), "GetGUID", 0, typeof(System.Type), typeof(System.Byte).MakeArrayType());
					r_MGetGUID_Type_ByteArray.SetBelong(null);
				}
				return r_MGetGUID_Type_ByteArray;
			}
		}

		/// <summary>
		/// Void GetPacking(Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MGetPacking_Out_Int32_Out_Int32;
		public virtual RMethod RMGetPacking_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MGetPacking_Out_Int32_Out_Int32 == null)
				{
					r_MGetPacking_Out_Int32_Out_Int32 = new(this, "GetPacking", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MGetPacking_Out_Int32_Out_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPacking_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSIDImpl(System.Guid, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeFromCLSIDImpl_Guid_String_Boolean;
		public static RMethod RMGetTypeFromCLSIDImpl_Guid_String_Boolean
		{
			get
			{
				if(r_MGetTypeFromCLSIDImpl_Guid_String_Boolean == null)
				{
					r_MGetTypeFromCLSIDImpl_Guid_String_Boolean = new( ReflectionUtils.GetType("System.RuntimeType"), "GetTypeFromCLSIDImpl", 0, typeof(System.Guid), typeof(System.String), typeof(System.Boolean));
					r_MGetTypeFromCLSIDImpl_Guid_String_Boolean.SetBelong(null);
				}
				return r_MGetTypeFromCLSIDImpl_Guid_String_Boolean;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCodeImpl()
		/// </summary>
		protected RMethod r_MGetTypeCodeImpl;
		public virtual RMethod RMGetTypeCodeImpl
		{
			get
			{
				if(r_MGetTypeCodeImpl == null)
				{
					r_MGetTypeCodeImpl = new(this, "GetTypeCodeImpl", 0);
					r_MGetTypeCodeImpl.SetBelong(this.GetValue());
				}
				return r_MGetTypeCodeImpl;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCodeImplInternal(System.Type)
		/// </summary>
		protected static RMethod r_MGetTypeCodeImplInternal_Type;
		public static RMethod RMGetTypeCodeImplInternal_Type
		{
			get
			{
				if(r_MGetTypeCodeImplInternal_Type == null)
				{
					r_MGetTypeCodeImplInternal_Type = new( ReflectionUtils.GetType("System.RuntimeType"), "GetTypeCodeImplInternal", 0, typeof(System.Type));
					r_MGetTypeCodeImplInternal_Type.SetBelong(null);
				}
				return r_MGetTypeCodeImplInternal_Type;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgIDImpl(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeFromProgIDImpl_String_String_Boolean;
		public static RMethod RMGetTypeFromProgIDImpl_String_String_Boolean
		{
			get
			{
				if(r_MGetTypeFromProgIDImpl_String_String_Boolean == null)
				{
					r_MGetTypeFromProgIDImpl_String_String_Boolean = new( ReflectionUtils.GetType("System.RuntimeType"), "GetTypeFromProgIDImpl", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_MGetTypeFromProgIDImpl_String_String_Boolean.SetBelong(null);
				}
				return r_MGetTypeFromProgIDImpl_String_String_Boolean;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Boolean IsGenericCOMObjectImpl()
		/// </summary>
		protected RMethod r_MIsGenericCOMObjectImpl;
		public virtual RMethod RMIsGenericCOMObjectImpl
		{
			get
			{
				if(r_MIsGenericCOMObjectImpl == null)
				{
					r_MIsGenericCOMObjectImpl = new(this, "IsGenericCOMObjectImpl", 0);
					r_MIsGenericCOMObjectImpl.SetBelong(this.GetValue());
				}
				return r_MIsGenericCOMObjectImpl;
			}
		}

		/// <summary>
		/// System.Object CreateInstanceInternal(System.Type)
		/// </summary>
		protected static RMethod r_MCreateInstanceInternal_Type;
		public static RMethod RMCreateInstanceInternal_Type
		{
			get
			{
				if(r_MCreateInstanceInternal_Type == null)
				{
					r_MCreateInstanceInternal_Type = new( ReflectionUtils.GetType("System.RuntimeType"), "CreateInstanceInternal", 0, typeof(System.Type));
					r_MCreateInstanceInternal_Type.SetBelong(null);
				}
				return r_MCreateInstanceInternal_Type;
			}
		}

		/// <summary>
		/// System.String getFullName(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MgetFullName_Boolean_Boolean;
		public virtual RMethod RMgetFullName_Boolean_Boolean
		{
			get
			{
				if(r_MgetFullName_Boolean_Boolean == null)
				{
					r_MgetFullName_Boolean_Boolean = new(this, "getFullName", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MgetFullName_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MgetFullName_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArgumentsInternal(Boolean)
		/// </summary>
		protected RMethod r_MGetGenericArgumentsInternal_Boolean;
		public virtual RMethod RMGetGenericArgumentsInternal_Boolean
		{
			get
			{
				if(r_MGetGenericArgumentsInternal_Boolean == null)
				{
					r_MGetGenericArgumentsInternal_Boolean = new(this, "GetGenericArgumentsInternal", 0, typeof(System.Boolean));
					r_MGetGenericArgumentsInternal_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetGenericArgumentsInternal_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.GenericParameterAttributes GetGenericParameterAttributes()
		/// </summary>
		protected RMethod r_MGetGenericParameterAttributes;
		public virtual RMethod RMGetGenericParameterAttributes
		{
			get
			{
				if(r_MGetGenericParameterAttributes == null)
				{
					r_MGetGenericParameterAttributes = new(this, "GetGenericParameterAttributes", 0);
					r_MGetGenericParameterAttributes.SetBelong(this.GetValue());
				}
				return r_MGetGenericParameterAttributes;
			}
		}

		/// <summary>
		/// Int32 GetGenericParameterPosition()
		/// </summary>
		protected RMethod r_MGetGenericParameterPosition;
		public virtual RMethod RMGetGenericParameterPosition
		{
			get
			{
				if(r_MGetGenericParameterPosition == null)
				{
					r_MGetGenericParameterPosition = new(this, "GetGenericParameterPosition", 0);
					r_MGetGenericParameterPosition.SetBelong(this.GetValue());
				}
				return r_MGetGenericParameterPosition;
			}
		}

		/// <summary>
		/// IntPtr GetEvents_native(IntPtr, MemberListType)
		/// </summary>
		protected RMethod r_MGetEvents_native_IntPtr_MemberListType;
		public virtual RMethod RMGetEvents_native_IntPtr_MemberListType
		{
			get
			{
				if(r_MGetEvents_native_IntPtr_MemberListType == null)
				{
					r_MGetEvents_native_IntPtr_MemberListType = new(this, "GetEvents_native", 0, typeof(System.IntPtr),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"));
					r_MGetEvents_native_IntPtr_MemberListType.SetBelong(this.GetValue());
				}
				return r_MGetEvents_native_IntPtr_MemberListType;
			}
		}

		/// <summary>
		/// IntPtr GetFields_native(IntPtr, System.Reflection.BindingFlags, MemberListType)
		/// </summary>
		protected RMethod r_MGetFields_native_IntPtr_BindingFlags_MemberListType;
		public virtual RMethod RMGetFields_native_IntPtr_BindingFlags_MemberListType
		{
			get
			{
				if(r_MGetFields_native_IntPtr_BindingFlags_MemberListType == null)
				{
					r_MGetFields_native_IntPtr_BindingFlags_MemberListType = new(this, "GetFields_native", 0, typeof(System.IntPtr), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"));
					r_MGetFields_native_IntPtr_BindingFlags_MemberListType.SetBelong(this.GetValue());
				}
				return r_MGetFields_native_IntPtr_BindingFlags_MemberListType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeFieldInfo[] GetFields_internal(System.String, System.Reflection.BindingFlags, MemberListType, System.RuntimeType)
		/// </summary>
		protected RMethod r_MGetFields_internal_String_BindingFlags_MemberListType_RuntimeType;
		public virtual RMethod RMGetFields_internal_String_BindingFlags_MemberListType_RuntimeType
		{
			get
			{
				if(r_MGetFields_internal_String_BindingFlags_MemberListType_RuntimeType == null)
				{
					r_MGetFields_internal_String_BindingFlags_MemberListType_RuntimeType = new(this, "GetFields_internal", 0, typeof(System.String), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_MGetFields_internal_String_BindingFlags_MemberListType_RuntimeType.SetBelong(this.GetValue());
				}
				return r_MGetFields_internal_String_BindingFlags_MemberListType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeEventInfo[] GetEvents_internal(System.String, System.Reflection.BindingFlags, MemberListType, System.RuntimeType)
		/// </summary>
		protected RMethod r_MGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType;
		public virtual RMethod RMGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType
		{
			get
			{
				if(r_MGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType == null)
				{
					r_MGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType = new(this, "GetEvents_internal", 0, typeof(System.String), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"),  ReflectionUtils.GetType("System.RuntimeType"));
					r_MGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType.SetBelong(this.GetValue());
				}
				return r_MGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType;
			}
		}

		/// <summary>
		/// System.Type[] GetInterfaces()
		/// </summary>
		protected RMethod r_MGetInterfaces;
		public virtual RMethod RMGetInterfaces
		{
			get
			{
				if(r_MGetInterfaces == null)
				{
					r_MGetInterfaces = new(this, "GetInterfaces", 0);
					r_MGetInterfaces.SetBelong(this.GetValue());
				}
				return r_MGetInterfaces;
			}
		}

		/// <summary>
		/// IntPtr GetNestedTypes_native(IntPtr, System.Reflection.BindingFlags, MemberListType)
		/// </summary>
		protected RMethod r_MGetNestedTypes_native_IntPtr_BindingFlags_MemberListType;
		public virtual RMethod RMGetNestedTypes_native_IntPtr_BindingFlags_MemberListType
		{
			get
			{
				if(r_MGetNestedTypes_native_IntPtr_BindingFlags_MemberListType == null)
				{
					r_MGetNestedTypes_native_IntPtr_BindingFlags_MemberListType = new(this, "GetNestedTypes_native", 0, typeof(System.IntPtr), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"));
					r_MGetNestedTypes_native_IntPtr_BindingFlags_MemberListType.SetBelong(this.GetValue());
				}
				return r_MGetNestedTypes_native_IntPtr_BindingFlags_MemberListType;
			}
		}

		/// <summary>
		/// System.RuntimeType[] GetNestedTypes_internal(System.String, System.Reflection.BindingFlags, MemberListType)
		/// </summary>
		protected RMethod r_MGetNestedTypes_internal_String_BindingFlags_MemberListType;
		public virtual RMethod RMGetNestedTypes_internal_String_BindingFlags_MemberListType
		{
			get
			{
				if(r_MGetNestedTypes_internal_String_BindingFlags_MemberListType == null)
				{
					r_MGetNestedTypes_internal_String_BindingFlags_MemberListType = new(this, "GetNestedTypes_internal", 0, typeof(System.String), typeof(System.Reflection.BindingFlags),  ReflectionUtils.GetType("System.RuntimeType+MemberListType"));
					r_MGetNestedTypes_internal_String_BindingFlags_MemberListType.SetBelong(this.GetValue());
				}
				return r_MGetNestedTypes_internal_String_BindingFlags_MemberListType;
			}
		}

		/// <summary>
		/// Int32 get_core_clr_security_level()
		/// </summary>
		protected RMethod r_Mget_core_clr_security_level;
		public virtual RMethod RMget_core_clr_security_level
		{
			get
			{
				if(r_Mget_core_clr_security_level == null)
				{
					r_Mget_core_clr_security_level = new(this, "get_core_clr_security_level", 0);
					r_Mget_core_clr_security_level.SetBelong(this.GetValue());
				}
				return r_Mget_core_clr_security_level;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.GetValue());
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.Type)
		/// </summary>
		protected RMethod r_MIsSubclassOf_Type;
		public virtual RMethod RMIsSubclassOf_Type
		{
			get
			{
				if(r_MIsSubclassOf_Type == null)
				{
					r_MIsSubclassOf_Type = new(this, "IsSubclassOf", 0, typeof(System.Type));
					r_MIsSubclassOf_Type.SetBelong(this.GetValue());
				}
				return r_MIsSubclassOf_Type;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImplCommon(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImplCommon", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// ListBuilder`1 GetMethodCandidates(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[], Boolean)
		/// </summary>
		protected RMethod r_MGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean;
		public virtual RMethod RMGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean
		{
			get
			{
				if(r_MGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean == null)
				{
					r_MGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean = new(this, "GetMethodCandidates", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Boolean));
					r_MGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean;
			}
		}

		/// <summary>
		/// System.Type AsType()
		/// </summary>
		protected RMethod r_MAsType;
		public virtual RMethod RMAsType
		{
			get
			{
				if(r_MAsType == null)
				{
					r_MAsType = new(this, "AsType", 0);
					r_MAsType.SetBelong(this.GetValue());
				}
				return r_MAsType;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetDeclaredEvent(System.String)
		/// </summary>
		protected RMethod r_MGetDeclaredEvent_String;
		public virtual RMethod RMGetDeclaredEvent_String
		{
			get
			{
				if(r_MGetDeclaredEvent_String == null)
				{
					r_MGetDeclaredEvent_String = new(this, "GetDeclaredEvent", 0, typeof(System.String));
					r_MGetDeclaredEvent_String.SetBelong(this.GetValue());
				}
				return r_MGetDeclaredEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetDeclaredField(System.String)
		/// </summary>
		protected RMethod r_MGetDeclaredField_String;
		public virtual RMethod RMGetDeclaredField_String
		{
			get
			{
				if(r_MGetDeclaredField_String == null)
				{
					r_MGetDeclaredField_String = new(this, "GetDeclaredField", 0, typeof(System.String));
					r_MGetDeclaredField_String.SetBelong(this.GetValue());
				}
				return r_MGetDeclaredField_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetDeclaredMethod(System.String)
		/// </summary>
		protected RMethod r_MGetDeclaredMethod_String;
		public virtual RMethod RMGetDeclaredMethod_String
		{
			get
			{
				if(r_MGetDeclaredMethod_String == null)
				{
					r_MGetDeclaredMethod_String = new(this, "GetDeclaredMethod", 0, typeof(System.String));
					r_MGetDeclaredMethod_String.SetBelong(this.GetValue());
				}
				return r_MGetDeclaredMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.TypeInfo GetDeclaredNestedType(System.String)
		/// </summary>
		protected RMethod r_MGetDeclaredNestedType_String;
		public virtual RMethod RMGetDeclaredNestedType_String
		{
			get
			{
				if(r_MGetDeclaredNestedType_String == null)
				{
					r_MGetDeclaredNestedType_String = new(this, "GetDeclaredNestedType", 0, typeof(System.String));
					r_MGetDeclaredNestedType_String.SetBelong(this.GetValue());
				}
				return r_MGetDeclaredNestedType_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetDeclaredProperty(System.String)
		/// </summary>
		protected RMethod r_MGetDeclaredProperty_String;
		public virtual RMethod RMGetDeclaredProperty_String
		{
			get
			{
				if(r_MGetDeclaredProperty_String == null)
				{
					r_MGetDeclaredProperty_String = new(this, "GetDeclaredProperty", 0, typeof(System.String));
					r_MGetDeclaredProperty_String.SetBelong(this.GetValue());
				}
				return r_MGetDeclaredProperty_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MethodInfo] GetDeclaredMethods(System.String)
		/// </summary>
		protected RMethod r_MGetDeclaredMethods_String;
		public virtual RMethod RMGetDeclaredMethods_String
		{
			get
			{
				if(r_MGetDeclaredMethods_String == null)
				{
					r_MGetDeclaredMethods_String = new(this, "GetDeclaredMethods", 0, typeof(System.String));
					r_MGetDeclaredMethods_String.SetBelong(this.GetValue());
				}
				return r_MGetDeclaredMethods_String;
			}
		}

		/// <summary>
		/// System.Type GetRootElementType()
		/// </summary>
		protected RMethod r_MGetRootElementType;
		public virtual RMethod RMGetRootElementType
		{
			get
			{
				if(r_MGetRootElementType == null)
				{
					r_MGetRootElementType = new(this, "GetRootElementType", 0);
					r_MGetRootElementType.SetBelong(this.GetValue());
				}
				return r_MGetRootElementType;
			}
		}

		/// <summary>
		/// System.Type[] FindInterfaces(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_MFindInterfaces_TypeFilter_Object;
		public virtual RMethod RMFindInterfaces_TypeFilter_Object
		{
			get
			{
				if(r_MFindInterfaces_TypeFilter_Object == null)
				{
					r_MFindInterfaces_TypeFilter_Object = new(this, "FindInterfaces", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_MFindInterfaces_TypeFilter_Object.SetBelong(this.GetValue());
				}
				return r_MFindInterfaces_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes, System.Reflection.BindingFlags, System.Reflection.MemberFilter, System.Object)
		/// </summary>
		protected RMethod r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
		public virtual RMethod RMFindMembers_MemberTypes_BindingFlags_MemberFilter_Object
		{
			get
			{
				if(r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object == null)
				{
					r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object = new(this, "FindMembers", 0, typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MemberFilter), typeof(System.Object));
					r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object.SetBelong(this.GetValue());
				}
				return r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
			}
		}

		/// <summary>
		/// Boolean ImplementInterface(System.Type)
		/// </summary>
		protected RMethod r_MImplementInterface_Type;
		public virtual RMethod RMImplementInterface_Type
		{
			get
			{
				if(r_MImplementInterface_Type == null)
				{
					r_MImplementInterface_Type = new(this, "ImplementInterface", 0, typeof(System.Type));
					r_MImplementInterface_Type.SetBelong(this.GetValue());
				}
				return r_MImplementInterface_Type;
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
					r_MGetType.SetBelong(this.GetValue());
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRefImpl()
		/// </summary>
		protected RMethod r_MIsMarshalByRefImpl;
		public virtual RMethod RMIsMarshalByRefImpl
		{
			get
			{
				if(r_MIsMarshalByRefImpl == null)
				{
					r_MIsMarshalByRefImpl = new(this, "IsMarshalByRefImpl", 0);
					r_MIsMarshalByRefImpl.SetBelong(this.GetValue());
				}
				return r_MIsMarshalByRefImpl;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type[])
		/// </summary>
		protected RMethod r_MGetConstructor_TypeArray;
		public virtual RMethod RMGetConstructor_TypeArray
		{
			get
			{
				if(r_MGetConstructor_TypeArray == null)
				{
					r_MGetConstructor_TypeArray = new(this, "GetConstructor", 0, typeof(System.Type).MakeArrayType());
					r_MGetConstructor_TypeArray.SetBelong(this.GetValue());
				}
				return r_MGetConstructor_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors()
		/// </summary>
		protected RMethod r_MGetConstructors;
		public virtual RMethod RMGetConstructors
		{
			get
			{
				if(r_MGetConstructors == null)
				{
					r_MGetConstructors = new(this, "GetConstructors", 0);
					r_MGetConstructors.SetBelong(this.GetValue());
				}
				return r_MGetConstructors;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String)
		/// </summary>
		protected RMethod r_MGetEvent_String;
		public virtual RMethod RMGetEvent_String
		{
			get
			{
				if(r_MGetEvent_String == null)
				{
					r_MGetEvent_String = new(this, "GetEvent", 0, typeof(System.String));
					r_MGetEvent_String.SetBelong(this.GetValue());
				}
				return r_MGetEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents()
		/// </summary>
		protected RMethod r_MGetEvents;
		public virtual RMethod RMGetEvents
		{
			get
			{
				if(r_MGetEvents == null)
				{
					r_MGetEvents = new(this, "GetEvents", 0);
					r_MGetEvents.SetBelong(this.GetValue());
				}
				return r_MGetEvents;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String)
		/// </summary>
		protected RMethod r_MGetField_String;
		public virtual RMethod RMGetField_String
		{
			get
			{
				if(r_MGetField_String == null)
				{
					r_MGetField_String = new(this, "GetField", 0, typeof(System.String));
					r_MGetField_String.SetBelong(this.GetValue());
				}
				return r_MGetField_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields()
		/// </summary>
		protected RMethod r_MGetFields;
		public virtual RMethod RMGetFields
		{
			get
			{
				if(r_MGetFields == null)
				{
					r_MGetFields = new(this, "GetFields", 0);
					r_MGetFields.SetBelong(this.GetValue());
				}
				return r_MGetFields;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String)
		/// </summary>
		protected RMethod r_MGetMember_String;
		public virtual RMethod RMGetMember_String
		{
			get
			{
				if(r_MGetMember_String == null)
				{
					r_MGetMember_String = new(this, "GetMember", 0, typeof(System.String));
					r_MGetMember_String.SetBelong(this.GetValue());
				}
				return r_MGetMember_String;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMember_String_BindingFlags;
		public virtual RMethod RMGetMember_String_BindingFlags
		{
			get
			{
				if(r_MGetMember_String_BindingFlags == null)
				{
					r_MGetMember_String_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_MGetMember_String_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetMember_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers()
		/// </summary>
		protected RMethod r_MGetMembers;
		public virtual RMethod RMGetMembers
		{
			get
			{
				if(r_MGetMembers == null)
				{
					r_MGetMembers = new(this, "GetMembers", 0);
					r_MGetMembers.SetBelong(this.GetValue());
				}
				return r_MGetMembers;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String)
		/// </summary>
		protected RMethod r_MGetMethod_String;
		public virtual RMethod RMGetMethod_String
		{
			get
			{
				if(r_MGetMethod_String == null)
				{
					r_MGetMethod_String = new(this, "GetMethod", 0, typeof(System.String));
					r_MGetMethod_String.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMethod_String_BindingFlags;
		public virtual RMethod RMGetMethod_String_BindingFlags
		{
			get
			{
				if(r_MGetMethod_String_BindingFlags == null)
				{
					r_MGetMethod_String_BindingFlags = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_MGetMethod_String_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])
		/// </summary>
		protected RMethod r_MGetMethod_String_TypeArray;
		public virtual RMethod RMGetMethod_String_TypeArray
		{
			get
			{
				if(r_MGetMethod_String_TypeArray == null)
				{
					r_MGetMethod_String_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_MGetMethod_String_TypeArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethod_String_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_TypeArray;
		public virtual RMethod RMGetMethod_String_Int32_TypeArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_TypeArray == null)
				{
					r_MGetMethod_String_Int32_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType());
					r_MGetMethod_String_Int32_TypeArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_Int32_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_Int32_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods()
		/// </summary>
		protected RMethod r_MGetMethods;
		public virtual RMethod RMGetMethods
		{
			get
			{
				if(r_MGetMethods == null)
				{
					r_MGetMethods = new(this, "GetMethods", 0);
					r_MGetMethods.SetBelong(this.GetValue());
				}
				return r_MGetMethods;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String)
		/// </summary>
		protected RMethod r_MGetNestedType_String;
		public virtual RMethod RMGetNestedType_String
		{
			get
			{
				if(r_MGetNestedType_String == null)
				{
					r_MGetNestedType_String = new(this, "GetNestedType", 0, typeof(System.String));
					r_MGetNestedType_String.SetBelong(this.GetValue());
				}
				return r_MGetNestedType_String;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes()
		/// </summary>
		protected RMethod r_MGetNestedTypes;
		public virtual RMethod RMGetNestedTypes
		{
			get
			{
				if(r_MGetNestedTypes == null)
				{
					r_MGetNestedTypes = new(this, "GetNestedTypes", 0);
					r_MGetNestedTypes.SetBelong(this.GetValue());
				}
				return r_MGetNestedTypes;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String)
		/// </summary>
		protected RMethod r_MGetProperty_String;
		public virtual RMethod RMGetProperty_String
		{
			get
			{
				if(r_MGetProperty_String == null)
				{
					r_MGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_MGetProperty_String.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetProperty_String_BindingFlags;
		public virtual RMethod RMGetProperty_String_BindingFlags
		{
			get
			{
				if(r_MGetProperty_String_BindingFlags == null)
				{
					r_MGetProperty_String_BindingFlags = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_MGetProperty_String_BindingFlags.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type)
		/// </summary>
		protected RMethod r_MGetProperty_String_Type;
		public virtual RMethod RMGetProperty_String_Type
		{
			get
			{
				if(r_MGetProperty_String_Type == null)
				{
					r_MGetProperty_String_Type = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type));
					r_MGetProperty_String_Type.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String_Type;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type[])
		/// </summary>
		protected RMethod r_MGetProperty_String_TypeArray;
		public virtual RMethod RMGetProperty_String_TypeArray
		{
			get
			{
				if(r_MGetProperty_String_TypeArray == null)
				{
					r_MGetProperty_String_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_MGetProperty_String_TypeArray.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MGetProperty_String_Type_TypeArray;
		public virtual RMethod RMGetProperty_String_Type_TypeArray
		{
			get
			{
				if(r_MGetProperty_String_Type_TypeArray == null)
				{
					r_MGetProperty_String_Type_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MGetProperty_String_Type_TypeArray.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetProperty_String_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetProperty_String_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetProperty_String_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MGetProperty_String_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetProperty_String_Type_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.GetValue());
				}
				return r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties()
		/// </summary>
		protected RMethod r_MGetProperties;
		public virtual RMethod RMGetProperties
		{
			get
			{
				if(r_MGetProperties == null)
				{
					r_MGetProperties = new(this, "GetProperties", 0);
					r_MGetProperties.SetBelong(this.GetValue());
				}
				return r_MGetProperties;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
		public virtual RMethod RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray
		{
			get
			{
				if(r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray == null)
				{
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray.SetBelong(this.GetValue());
				}
				return r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
		public virtual RMethod RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo == null)
				{
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.SetBelong(this.GetValue());
				}
				return r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String)
		/// </summary>
		protected RMethod r_MGetInterface_String;
		public virtual RMethod RMGetInterface_String
		{
			get
			{
				if(r_MGetInterface_String == null)
				{
					r_MGetInterface_String = new(this, "GetInterface", 0, typeof(System.String));
					r_MGetInterface_String.SetBelong(this.GetValue());
				}
				return r_MGetInterface_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Type)
		/// </summary>
		protected RMethod r_MEquals_Type;
		public virtual RMethod RMEquals_Type
		{
			get
			{
				if(r_MEquals_Type == null)
				{
					r_MEquals_Type = new(this, "Equals", 0, typeof(System.Type));
					r_MEquals_Type.SetBelong(this.GetValue());
				}
				return r_MEquals_Type;
			}
		}

		/// <summary>
		/// System.Type InternalResolve()
		/// </summary>
		protected RMethod r_MInternalResolve;
		public virtual RMethod RMInternalResolve
		{
			get
			{
				if(r_MInternalResolve == null)
				{
					r_MInternalResolve = new(this, "InternalResolve", 0);
					r_MInternalResolve.SetBelong(this.GetValue());
				}
				return r_MInternalResolve;
			}
		}

		/// <summary>
		/// System.Type RuntimeResolve()
		/// </summary>
		protected RMethod r_MRuntimeResolve;
		public virtual RMethod RMRuntimeResolve
		{
			get
			{
				if(r_MRuntimeResolve == null)
				{
					r_MRuntimeResolve = new(this, "RuntimeResolve", 0);
					r_MRuntimeResolve.SetBelong(this.GetValue());
				}
				return r_MRuntimeResolve;
			}
		}

		/// <summary>
		/// System.String FormatTypeName()
		/// </summary>
		protected RMethod r_MFormatTypeName;
		public virtual RMethod RMFormatTypeName
		{
			get
			{
				if(r_MFormatTypeName == null)
				{
					r_MFormatTypeName = new(this, "FormatTypeName", 0);
					r_MFormatTypeName.SetBelong(this.GetValue());
				}
				return r_MFormatTypeName;
			}
		}

		/// <summary>
		/// Boolean IsRuntimeImplemented()
		/// </summary>
		protected RMethod r_MIsRuntimeImplemented;
		public virtual RMethod RMIsRuntimeImplemented
		{
			get
			{
				if(r_MIsRuntimeImplemented == null)
				{
					r_MIsRuntimeImplemented = new(this, "IsRuntimeImplemented", 0);
					r_MIsRuntimeImplemented.SetBelong(this.GetValue());
				}
				return r_MIsRuntimeImplemented;
			}
		}

		/// <summary>
		/// System.String InternalGetNameIfAvailable(System.Type ByRef)
		/// </summary>
		protected RMethod r_MInternalGetNameIfAvailable_Ref_Type;
		public virtual RMethod RMInternalGetNameIfAvailable_Ref_Type
		{
			get
			{
				if(r_MInternalGetNameIfAvailable_Ref_Type == null)
				{
					r_MInternalGetNameIfAvailable_Ref_Type = new(this, "InternalGetNameIfAvailable", 0, typeof(System.Type).MakeByRefType());
					r_MInternalGetNameIfAvailable_Ref_Type.SetBelong(this.GetValue());
				}
				return r_MInternalGetNameIfAvailable_Ref_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Module get_Module()
		/// </summary>
		protected RMethod r_Mget_Module;
		public virtual RMethod RMget_Module
		{
			get
			{
				if(r_Mget_Module == null)
				{
					r_Mget_Module = new(this, "get_Module", 0);
					r_Mget_Module.SetBelong(this.GetValue());
				}
				return r_Mget_Module;
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
					r_MCacheEquals_Object.SetBelong(this.GetValue());
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
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RRuntimeType() : base("System.RuntimeType")
        {
        }

        public RRuntimeType(System.Object instance) : base("System.RuntimeType")
		{
            SetInstance(instance);
		}

        public RRuntimeType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Hvak.Editor.Refleaction.RSystem.RRuntimeType GetType(System.String @typeName, System.Boolean @throwOnError, System.Boolean @ignoreCase, System.Boolean @reflectionOnly, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError, @ignoreCase, @reflectionOnly, @stackMark.Value};
            var ___result = RMGetType_String_Boolean_Boolean_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[4]);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType(___result);
        }


        public static void ThrowIfTypeNeverValidGenericArgument(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMThrowIfTypeNeverValidGenericArgument_RuntimeType.Invoke(___genericsType, ___parameters);

            
        }


        public static void SanityCheckGenericArguments(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RRuntimeType> @genericArguments, Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RRuntimeType> @genericParamters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@genericArguments.Value, @genericParamters.Value};
            var ___result = RMSanityCheckGenericArguments_RuntimeTypeArray_RuntimeTypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void SplitName(System.String @fullname, out System.String @name, out System.String @ns)
        {
			@name = default;
			@ns = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullname, @name, @ns};
            var ___result = RMSplitName_String_Out_String_Out_String.Invoke(___genericsType, ___parameters);
			@name = (System.String)___parameters[1];
			@ns = (System.String)___parameters[2];

            
        }


        public static System.Reflection.BindingFlags FilterPreCalculate(System.Boolean @isPublic, System.Boolean @isInherited, System.Boolean @isStatic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isPublic, @isInherited, @isStatic};
            var ___result = RMFilterPreCalculate_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.BindingFlags)___result;
        }


        public static void FilterHelper(System.Reflection.BindingFlags @bindingFlags, ref System.String @name, System.Boolean @allowPrefixLookup, out System.Boolean @prefixLookup, out System.Boolean @ignoreCase, out Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {
			@prefixLookup = default;
			@ignoreCase = default;
			@listType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags, @name, @allowPrefixLookup, @prefixLookup, @ignoreCase, @listType.Value};
            var ___result = RMFilterHelper_BindingFlags_Ref_String_Boolean_Out_Boolean_Out_Boolean_Out_MemberListType.Invoke(___genericsType, ___parameters);
			@name = (System.String)___parameters[1];
			@prefixLookup = (System.Boolean)___parameters[3];
			@ignoreCase = (System.Boolean)___parameters[4];
			@listType = new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType(___parameters[5]);

            
        }


        public static void FilterHelper(System.Reflection.BindingFlags @bindingFlags, ref System.String @name, out System.Boolean @ignoreCase, out Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {
			@ignoreCase = default;
			@listType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags, @name, @ignoreCase, @listType.Value};
            var ___result = RMFilterHelper_BindingFlags_Ref_String_Out_Boolean_Out_MemberListType.Invoke(___genericsType, ___parameters);
			@name = (System.String)___parameters[1];
			@ignoreCase = (System.Boolean)___parameters[2];
			@listType = new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType(___parameters[3]);

            
        }


        public static System.Boolean FilterApplyPrefixLookup(System.Reflection.MemberInfo @memberInfo, System.String @name, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberInfo, @name, @ignoreCase};
            var ___result = RMFilterApplyPrefixLookup_MemberInfo_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterApplyBase(System.Reflection.MemberInfo @memberInfo, System.Reflection.BindingFlags @bindingFlags, System.Boolean @isPublic, System.Boolean @isNonProtectedInternal, System.Boolean @isStatic, System.String @name, System.Boolean @prefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberInfo, @bindingFlags, @isPublic, @isNonProtectedInternal, @isStatic, @name, @prefixLookup};
            var ___result = RMFilterApplyBase_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterApplyType(System.Type @type, System.Reflection.BindingFlags @bindingFlags, System.String @name, System.Boolean @prefixLookup, System.String @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @bindingFlags, @name, @prefixLookup, @ns};
            var ___result = RMFilterApplyType_Type_BindingFlags_String_Boolean_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterApplyMethodInfo(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo @method, System.Reflection.BindingFlags @bindingFlags, System.Reflection.CallingConventions @callConv, System.Type[] @argumentTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method.Value, @bindingFlags, @callConv, @argumentTypes};
            var ___result = RMFilterApplyMethodInfo_RuntimeMethodInfo_BindingFlags_CallingConventions_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterApplyConstructorInfo(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo @constructor, System.Reflection.BindingFlags @bindingFlags, System.Reflection.CallingConventions @callConv, System.Type[] @argumentTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@constructor.Value, @bindingFlags, @callConv, @argumentTypes};
            var ___result = RMFilterApplyConstructorInfo_RuntimeConstructorInfo_BindingFlags_CallingConventions_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterApplyMethodBase(System.Reflection.MethodBase @methodBase, System.Reflection.BindingFlags @methodFlags, System.Reflection.BindingFlags @bindingFlags, System.Reflection.CallingConventions @callConv, System.Type[] @argumentTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodBase, @methodFlags, @bindingFlags, @callConv, @argumentTypes};
            var ___result = RMFilterApplyMethodBase_MethodBase_BindingFlags_BindingFlags_CallingConventions_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSpecialSerializableType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsSpecialSerializableType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> GetMethodCandidates(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.CallingConventions @callConv, System.Type[] @types, System.Int32 @genericParamCount, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @callConv, @types, @genericParamCount, @allowPrefixLookup};
            var ___result = RMGetMethodCandidates_String_BindingFlags_CallingConventions_TypeArray_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo> GetConstructorCandidates(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.CallingConventions @callConv, System.Type[] @types, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @callConv, @types, @allowPrefixLookup};
            var ___result = RMGetConstructorCandidates_String_BindingFlags_CallingConventions_TypeArray_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyInfo> GetPropertyCandidates(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Type[] @types, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @types, @allowPrefixLookup};
            var ___result = RMGetPropertyCandidates_String_BindingFlags_TypeArray_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo> GetEventCandidates(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @allowPrefixLookup};
            var ___result = RMGetEventCandidates_String_BindingFlags_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.REventInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo> GetFieldCandidates(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @allowPrefixLookup};
            var ___result = RMGetFieldCandidates_String_BindingFlags_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RType> GetNestedTypeCandidates(System.String @fullname, System.Reflection.BindingFlags @bindingAttr, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullname, @bindingAttr, @allowPrefixLookup};
            var ___result = RMGetNestedTypeCandidates_String_BindingFlags_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RType>(___result);
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetConstructors_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetProperties_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetEvents_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Type[] GetNestedTypes(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetNestedTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetMembers_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetPropertyImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RMGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetEvent_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Type GetInterface(System.String @fullname, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullname, @ignoreCase};
            var ___result = RMGetInterface_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetNestedType(System.String @fullname, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fullname, @bindingAttr};
            var ___result = RMGetNestedType_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name, System.Reflection.MemberTypes @type, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type, @bindingAttr};
            var ___result = RMGetMember_String_MemberTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeModule GetRuntimeModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRuntimeModule.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeModule(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly GetRuntimeAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRuntimeAssembly.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly(___result);
        }


        public virtual System.RuntimeTypeHandle GetTypeHandleInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeHandleInternal.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.Boolean IsInstanceOfType(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMIsInstanceOfType_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Reflection.TypeInfo @typeInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeInfo};
            var ___result = RMIsAssignableFrom_TypeInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Type @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsAssignableFrom_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEquivalentTo(System.Type @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsEquivalentTo_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType GetBaseType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBaseType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType(___result);
        }


        public virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAttributeFlagsImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeAttributes)___result;
        }


        public virtual System.Boolean IsContextfulImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsContextfulImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrimitiveImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsPrimitiveImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPointerImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsPointerImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCOMObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCOMObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsWindowsRuntimeObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsWindowsRuntimeObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsExportedToWindowsRuntimeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsExportedToWindowsRuntimeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsWindowsRuntimeObjectType(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsWindowsRuntimeObjectType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsTypeExportedToWindowsRuntime(Hvak.Editor.Refleaction.RSystem.RRuntimeType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIsTypeExportedToWindowsRuntime_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProxyAttributeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasProxyAttributeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDelegate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDelegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValueTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValueTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasElementTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasElementTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsArrayImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsArrayImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetArrayRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetArrayRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.String[] GetEnumNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Array GetEnumValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumValues.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Type GetEnumUnderlyingType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumUnderlyingType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsEnumDefined(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsEnumDefined_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetEnumName(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMGetEnumName_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RRuntimeType> GetGenericArgumentsInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArgumentsInternal.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RRuntimeType>(___result);
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type MakeGenericType(System.Type[] @instantiation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instantiation};
            var ___result = RMMakeGenericType_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetGenericTypeDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericTypeDefinition.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.MemberInfo[] GetDefaultMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @bindingFlags, System.Reflection.Binder @binder, System.Object @target, System.Object[] @providedArgs, System.Reflection.ParameterModifier[] @modifiers, System.Globalization.CultureInfo @culture, System.String[] @namedParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingFlags, @binder, @target, @providedArgs, @modifiers, @culture, @namedParams};
            var ___result = RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RSystem.RRuntimeType @left, Hvak.Editor.Refleaction.RSystem.RRuntimeType @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RSystem.RRuntimeType @left, Hvak.Editor.Refleaction.RSystem.RRuntimeType @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_RuntimeType_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.String FormatTypeName(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatTypeName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CreateInstanceCheckThis()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateInstanceCheckThis.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object CreateInstanceImpl(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @args, @culture, @activationAttributes, @stackMark.Value};
            var ___result = RMCreateInstanceImpl_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[5]);

            return (System.Object)___result;
        }


        public virtual System.Object ActivationCreateInstance(System.Reflection.MethodBase @invokeMethod, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Object[] @args, System.Globalization.CultureInfo @culture, System.Object[] @activationAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokeMethod, @bindingAttr, @binder, @args, @culture, @activationAttributes};
            var ___result = RMActivationCreateInstance_MethodBase_BindingFlags_Binder_ObjectArray_CultureInfo_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstanceDefaultCtor(System.Boolean @publicOnly, System.Boolean @skipCheckThis, System.Boolean @fillCache, System.Boolean @wrapExceptions, ref Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark @stackMark)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicOnly, @skipCheckThis, @fillCache, @wrapExceptions, @stackMark.Value};
            var ___result = RMCreateInstanceDefaultCtor_Boolean_Boolean_Boolean_Boolean_Ref_StackCrawlMark.Invoke(___genericsType, ___parameters);
			@stackMark = new Hvak.Editor.Refleaction.RSystem.RThreading.RStackCrawlMark(___parameters[4]);

            return (System.Object)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo GetDefaultConstructor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultConstructor.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo(___result);
        }


        public virtual System.Reflection.MethodInfo GetCorrespondingInflatedMethod(System.Reflection.MethodInfo @generic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@generic};
            var ___result = RMGetCorrespondingInflatedMethod_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetCorrespondingInflatedConstructor(System.Reflection.ConstructorInfo @generic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@generic};
            var ___result = RMGetCorrespondingInflatedConstructor_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RMGetMethod_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RMGetConstructor_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RMGetField_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.String GetDefaultMemberName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultMemberName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo GetSerializationCtor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSerializationCtor.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo(___result);
        }


        public virtual System.Object CreateInstanceSlow(System.Boolean @publicOnly, System.Boolean @wrapExceptions, System.Boolean @skipCheckThis, System.Boolean @fillCache)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicOnly, @wrapExceptions, @skipCheckThis, @fillCache};
            var ___result = RMCreateInstanceSlow_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CreateInstanceMono(System.Boolean @nonPublic, System.Boolean @wrapExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic, @wrapExceptions};
            var ___result = RMCreateInstanceMono_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object CheckValue(System.Object @value, System.Reflection.Binder @binder, System.Globalization.CultureInfo @culture, System.Reflection.BindingFlags @invokeAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @binder, @culture, @invokeAttr};
            var ___result = RMCheckValue_Object_Binder_CultureInfo_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object TryConvertToType(System.Object @value, ref System.Boolean @failed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @failed};
            var ___result = RMTryConvertToType_Object_Ref_Boolean.Invoke(___genericsType, ___parameters);
			@failed = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public static System.Object IsConvertibleToPrimitiveType(System.Object @value, System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @targetType};
            var ___result = RMIsConvertibleToPrimitiveType_Object_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetCachedName(Hvak.Editor.Refleaction.RSystem.RTypeNameKind @kind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kind.Value};
            var ___result = RMGetCachedName_TypeNameKind.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type make_array_type(System.Int32 @rank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rank};
            var ___result = RMmake_array_type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeArrayType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeArrayType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeArrayType(System.Int32 @rank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rank};
            var ___result = RMMakeArrayType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type make_byref_type()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMmake_byref_type.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeByRefType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeByRefType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type MakePointerType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMMakePointerType_Type.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakePointerType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakePointerType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetGenericParameterConstraints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericParameterConstraints.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.Object CreateInstanceForAnotherGenericParameter(System.Type @genericType, Hvak.Editor.Refleaction.RSystem.RRuntimeType @genericArgument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@genericType, @genericArgument.Value};
            var ___result = RMCreateInstanceForAnotherGenericParameter_Type_RuntimeType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Type MakeGenericType(System.Type @gt, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@gt, @types};
            var ___result = RMMakeGenericType_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.IntPtr GetMethodsByName_native(System.IntPtr @namePtr, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namePtr, @bindingAttr, @listType.Value};
            var ___result = RMGetMethodsByName_native_IntPtr_BindingFlags_MemberListType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo> GetMethodsByName(System.String @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType, Hvak.Editor.Refleaction.RSystem.RRuntimeType @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value, @reflectedType.Value};
            var ___result = RMGetMethodsByName_String_BindingFlags_MemberListType_RuntimeType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo>(___result);
        }


        public virtual System.IntPtr GetPropertiesByName_native(System.IntPtr @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value};
            var ___result = RMGetPropertiesByName_native_IntPtr_BindingFlags_MemberListType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr GetConstructors_native(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetConstructors_native_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo> GetConstructors_internal(System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @reflectedType.Value};
            var ___result = RMGetConstructors_internal_BindingFlags_RuntimeType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeConstructorInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimePropertyInfo> GetPropertiesByName(System.String @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType, Hvak.Editor.Refleaction.RSystem.RRuntimeType @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value, @reflectedType.Value};
            var ___result = RMGetPropertiesByName_String_BindingFlags_MemberListType_RuntimeType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimePropertyInfo>(___result);
        }


        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type @ifaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ifaceType};
            var ___result = RMGetInterfaceMap_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.InterfaceMapping)___result;
        }


        public static void GetInterfaceMapData(System.Type @t, System.Type @iface, out System.Reflection.MethodInfo[] @targets, out System.Reflection.MethodInfo[] @methods)
        {
			@targets = default;
			@methods = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @iface, @targets, @methods};
            var ___result = RMGetInterfaceMapData_Type_Type_Out_MethodInfoArray_Out_MethodInfoArray.Invoke(___genericsType, ___parameters);
			@targets = (System.Reflection.MethodInfo[])___parameters[2];
			@methods = (System.Reflection.MethodInfo[])___parameters[3];

            
        }


        public static void GetGUID(System.Type @type, System.Byte[] @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @guid};
            var ___result = RMGetGUID_Type_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetPacking(out System.Int32 @packing, out System.Int32 @size)
        {
			@packing = default;
			@size = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packing, @size};
            var ___result = RMGetPacking_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@packing = (System.Int32)___parameters[0];
			@size = (System.Int32)___parameters[1];

            
        }


        public static System.Type GetTypeFromCLSIDImpl(System.Guid @clsid, System.String @server, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @server, @throwOnError};
            var ___result = RMGetTypeFromCLSIDImpl_Guid_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.TypeCode GetTypeCodeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCodeImpl.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public static System.TypeCode GetTypeCodeImplInternal(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetTypeCodeImplInternal_Type.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public static System.Type GetTypeFromProgIDImpl(System.String @progID, System.String @server, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @server, @throwOnError};
            var ___result = RMGetTypeFromProgIDImpl_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsGenericCOMObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsGenericCOMObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Object CreateInstanceInternal(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMCreateInstanceInternal_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String getFullName(System.Boolean @full_name, System.Boolean @assembly_qualified)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@full_name, @assembly_qualified};
            var ___result = RMgetFullName_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type[] GetGenericArgumentsInternal(System.Boolean @runtimeArray)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@runtimeArray};
            var ___result = RMGetGenericArgumentsInternal_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.GenericParameterAttributes GetGenericParameterAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericParameterAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.GenericParameterAttributes)___result;
        }


        public virtual System.Int32 GetGenericParameterPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericParameterPosition.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IntPtr GetEvents_native(System.IntPtr @name, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @listType.Value};
            var ___result = RMGetEvents_native_IntPtr_MemberListType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.IntPtr GetFields_native(System.IntPtr @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value};
            var ___result = RMGetFields_native_IntPtr_BindingFlags_MemberListType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo> GetFields_internal(System.String @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType, Hvak.Editor.Refleaction.RSystem.RRuntimeType @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value, @reflectedType.Value};
            var ___result = RMGetFields_internal_String_BindingFlags_MemberListType_RuntimeType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeFieldInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeEventInfo> GetEvents_internal(System.String @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType, Hvak.Editor.Refleaction.RSystem.RRuntimeType @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value, @reflectedType.Value};
            var ___result = RMGetEvents_internal_String_BindingFlags_MemberListType_RuntimeType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeEventInfo>(___result);
        }


        public virtual System.Type[] GetInterfaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInterfaces.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.IntPtr GetNestedTypes_native(System.IntPtr @name, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @listType.Value};
            var ___result = RMGetNestedTypes_native_IntPtr_BindingFlags_MemberListType.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RRuntimeType> GetNestedTypes_internal(System.String @displayName, System.Reflection.BindingFlags @bindingAttr, Hvak.Editor.Refleaction.RSystem.RRuntimeType.RMemberListType @listType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayName, @bindingAttr, @listType.Value};
            var ___result = RMGetNestedTypes_internal_String_BindingFlags_MemberListType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RSystem.RRuntimeType>(___result);
        }


        public virtual System.Int32 get_core_clr_security_level()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_core_clr_security_level.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSubclassOf(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMIsSubclassOf_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConv, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConv, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConv, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConv, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImplCommon(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConv, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConv, @types, @modifiers};
            var ___result = RMGetMethodImplCommon_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo> GetMethodCandidates(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.CallingConventions @callConv, System.Type[] @types, System.Boolean @allowPrefixLookup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @callConv, @types, @allowPrefixLookup};
            var ___result = RMGetMethodCandidates_String_Int32_BindingFlags_CallingConventions_TypeArray_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType.RListBuilder<Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo>(___result);
        }


        public virtual System.Type AsType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAsType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.EventInfo GetDeclaredEvent(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDeclaredEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetDeclaredField(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDeclaredField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetDeclaredMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDeclaredMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.TypeInfo GetDeclaredNestedType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDeclaredNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetDeclaredProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDeclaredProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDeclaredMethods_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>)___result;
        }


        public virtual System.Type GetRootElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] FindInterfaces(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RMFindInterfaces_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes @memberType, System.Reflection.BindingFlags @bindingAttr, System.Reflection.MemberFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberType, @bindingAttr, @filter, @filterCriteria};
            var ___result = RMFindMembers_MemberTypes_BindingFlags_MemberFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Boolean ImplementInterface(System.Type @ifaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ifaceType};
            var ___result = RMImplementInterface_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsMarshalByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsMarshalByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RMGetConstructor_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @types, @modifiers};
            var ___result = RMGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConstructors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEvents.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFields.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMember_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetMember_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetMethod_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RMGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types, @modifiers};
            var ___result = RMGetMethod_String_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RMGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types};
            var ___result = RMGetMethod_String_Int32_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types, @modifiers};
            var ___result = RMGetMethod_String_Int32_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RMGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Type GetNestedType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNestedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetProperty_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType};
            var ___result = RMGetProperty_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RMGetProperty_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types};
            var ___result = RMGetProperty_String_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types, @modifiers};
            var ___result = RMGetProperty_String_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RMGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetProperties.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args};
            var ___result = RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @culture};
            var ___result = RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetInterface(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInterface_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean Equals(System.Type @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type InternalResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRuntimeResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.String FormatTypeName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFormatTypeName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsRuntimeImplemented()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsRuntimeImplemented.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalGetNameIfAvailable(ref System.Type @rootCauseForFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootCauseForFailure};
            var ___result = RMInternalGetNameIfAvailable_Ref_Type.Invoke(___genericsType, ___parameters);
			@rootCauseForFailure = (System.Type)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.Reflection.Module get_Module()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
