using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.MethodBuilder
	/// </summary>
    public partial class RMethodBuilder : RMember //
    {

		/// <summary>
		/// System.RuntimeMethodHandle mhandle
		/// </summary>
		protected RSystem.RRuntimeMethodHandle r_mhandle;
		public virtual RSystem.RRuntimeMethodHandle Rmhandle
		{
			get
			{
				if(r_mhandle == null)
				{
					r_mhandle = new(this, "mhandle");
					r_mhandle.SetBelong(this.instance);
				}
				return r_mhandle;
			}
		}

		/// <summary>
		/// System.Type rtype
		/// </summary>
		protected RSystem.RType r_rtype;
		public virtual RSystem.RType Rrtype
		{
			get
			{
				if(r_rtype == null)
				{
					r_rtype = new(this, "rtype");
					r_rtype.SetBelong(this.instance);
				}
				return r_rtype;
			}
		}

		/// <summary>
		/// System.Type[] parameters
		/// </summary>
		protected RFieldArray<RSystem.RType> r_parameters;
		public virtual RFieldArray<RSystem.RType> Rparameters
		{
			get
			{
				if(r_parameters == null)
				{
					r_parameters = new(this, "parameters");
					r_parameters.SetBelong(this.instance);
				}
				return r_parameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes attrs
		/// </summary>
		protected RField r_attrs;
		public virtual RField Rattrs
		{
			get
			{
				if(r_attrs == null)
				{
					r_attrs = new(this, "attrs");
					r_attrs.SetBelong(this.instance);
				}
				return r_attrs;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes iattrs
		/// </summary>
		protected RField r_iattrs;
		public virtual RField Riattrs
		{
			get
			{
				if(r_iattrs == null)
				{
					r_iattrs = new(this, "iattrs");
					r_iattrs.SetBelong(this.instance);
				}
				return r_iattrs;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected RField r_table_idx;
		public virtual RField Rtable_idx
		{
			get
			{
				if(r_table_idx == null)
				{
					r_table_idx = new(this, "table_idx");
					r_table_idx.SetBelong(this.instance);
				}
				return r_table_idx;
			}
		}

		/// <summary>
		/// System.Byte[] code
		/// </summary>
		protected RFieldArray<RField> r_code;
		public virtual RFieldArray<RField> Rcode
		{
			get
			{
				if(r_code == null)
				{
					r_code = new(this, "code");
					r_code.SetBelong(this.instance);
				}
				return r_code;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator ilgen
		/// </summary>
		protected RSystem.RReflection.REmit.RILGenerator r_ilgen;
		public virtual RSystem.RReflection.REmit.RILGenerator Rilgen
		{
			get
			{
				if(r_ilgen == null)
				{
					r_ilgen = new(this, "ilgen");
					r_ilgen.SetBelong(this.instance);
				}
				return r_ilgen;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder type
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeBuilder r_type;
		public virtual RSystem.RReflection.REmit.RTypeBuilder Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterBuilder[] pinfo
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RParameterBuilder> r_pinfo;
		public virtual RFieldArray<RSystem.RReflection.REmit.RParameterBuilder> Rpinfo
		{
			get
			{
				if(r_pinfo == null)
				{
					r_pinfo = new(this, "pinfo");
					r_pinfo.SetBelong(this.instance);
				}
				return r_pinfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> r_cattrs;
		public virtual RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> Rcattrs
		{
			get
			{
				if(r_cattrs == null)
				{
					r_cattrs = new(this, "cattrs");
					r_cattrs.SetBelong(this.instance);
				}
				return r_cattrs;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] override_methods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RMethodInfo> r_override_methods;
		public virtual RFieldArray<RSystem.RReflection.RMethodInfo> Roverride_methods
		{
			get
			{
				if(r_override_methods == null)
				{
					r_override_methods = new(this, "override_methods");
					r_override_methods.SetBelong(this.instance);
				}
				return r_override_methods;
			}
		}

		/// <summary>
		/// System.String pi_dll
		/// </summary>
		protected RField r_pi_dll;
		public virtual RField Rpi_dll
		{
			get
			{
				if(r_pi_dll == null)
				{
					r_pi_dll = new(this, "pi_dll");
					r_pi_dll.SetBelong(this.instance);
				}
				return r_pi_dll;
			}
		}

		/// <summary>
		/// System.String pi_entry
		/// </summary>
		protected RField r_pi_entry;
		public virtual RField Rpi_entry
		{
			get
			{
				if(r_pi_entry == null)
				{
					r_pi_entry = new(this, "pi_entry");
					r_pi_entry.SetBelong(this.instance);
				}
				return r_pi_entry;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CharSet charset
		/// </summary>
		protected RField r_charset;
		public virtual RField Rcharset
		{
			get
			{
				if(r_charset == null)
				{
					r_charset = new(this, "charset");
					r_charset.SetBelong(this.instance);
				}
				return r_charset;
			}
		}

		/// <summary>
		/// System.UInt32 extra_flags
		/// </summary>
		protected RField r_extra_flags;
		public virtual RField Rextra_flags
		{
			get
			{
				if(r_extra_flags == null)
				{
					r_extra_flags = new(this, "extra_flags");
					r_extra_flags.SetBelong(this.instance);
				}
				return r_extra_flags;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CallingConvention native_cc
		/// </summary>
		protected RField r_native_cc;
		public virtual RField Rnative_cc
		{
			get
			{
				if(r_native_cc == null)
				{
					r_native_cc = new(this, "native_cc");
					r_native_cc.SetBelong(this.instance);
				}
				return r_native_cc;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions call_conv
		/// </summary>
		protected RField r_call_conv;
		public virtual RField Rcall_conv
		{
			get
			{
				if(r_call_conv == null)
				{
					r_call_conv = new(this, "call_conv");
					r_call_conv.SetBelong(this.instance);
				}
				return r_call_conv;
			}
		}

		/// <summary>
		/// System.Boolean init_locals
		/// </summary>
		protected RField r_init_locals;
		public virtual RField Rinit_locals
		{
			get
			{
				if(r_init_locals == null)
				{
					r_init_locals = new(this, "init_locals");
					r_init_locals.SetBelong(this.instance);
				}
				return r_init_locals;
			}
		}

		/// <summary>
		/// System.IntPtr generic_container
		/// </summary>
		protected RField r_generic_container;
		public virtual RField Rgeneric_container
		{
			get
			{
				if(r_generic_container == null)
				{
					r_generic_container = new(this, "generic_container");
					r_generic_container.SetBelong(this.instance);
				}
				return r_generic_container;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.GenericTypeParameterBuilder[] generic_params
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RGenericTypeParameterBuilder> r_generic_params;
		public virtual RFieldArray<RSystem.RReflection.REmit.RGenericTypeParameterBuilder> Rgeneric_params
		{
			get
			{
				if(r_generic_params == null)
				{
					r_generic_params = new(this, "generic_params");
					r_generic_params.SetBelong(this.instance);
				}
				return r_generic_params;
			}
		}

		/// <summary>
		/// System.Type[] returnModReq
		/// </summary>
		protected RFieldArray<RSystem.RType> r_returnModReq;
		public virtual RFieldArray<RSystem.RType> RreturnModReq
		{
			get
			{
				if(r_returnModReq == null)
				{
					r_returnModReq = new(this, "returnModReq");
					r_returnModReq.SetBelong(this.instance);
				}
				return r_returnModReq;
			}
		}

		/// <summary>
		/// System.Type[] returnModOpt
		/// </summary>
		protected RFieldArray<RSystem.RType> r_returnModOpt;
		public virtual RFieldArray<RSystem.RType> RreturnModOpt
		{
			get
			{
				if(r_returnModOpt == null)
				{
					r_returnModOpt = new(this, "returnModOpt");
					r_returnModOpt.SetBelong(this.instance);
				}
				return r_returnModOpt;
			}
		}

		/// <summary>
		/// System.Type[][] paramModReq
		/// </summary>
		protected RFieldArray<RFieldArray<RSystem.RType>> r_paramModReq;
		public virtual RFieldArray<RFieldArray<RSystem.RType>> RparamModReq
		{
			get
			{
				if(r_paramModReq == null)
				{
					r_paramModReq = new(this, "paramModReq");
					r_paramModReq.SetBelong(this.instance);
				}
				return r_paramModReq;
			}
		}

		/// <summary>
		/// System.Type[][] paramModOpt
		/// </summary>
		protected RFieldArray<RFieldArray<RSystem.RType>> r_paramModOpt;
		public virtual RFieldArray<RFieldArray<RSystem.RType>> RparamModOpt
		{
			get
			{
				if(r_paramModOpt == null)
				{
					r_paramModOpt = new(this, "paramModOpt");
					r_paramModOpt.SetBelong(this.instance);
				}
				return r_paramModOpt;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> r_permissions;
		public virtual RFieldArray<RSystem.RReflection.REmit.RRefEmitPermissionSet> Rpermissions
		{
			get
			{
				if(r_permissions == null)
				{
					r_permissions = new(this, "permissions");
					r_permissions.SetBelong(this.instance);
				}
				return r_permissions;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected RProperty r_ContainsGenericParameters;
		public virtual RProperty RContainsGenericParameters
		{
			get
			{
				if(r_ContainsGenericParameters == null)
				{
					r_ContainsGenericParameters = new(this, "ContainsGenericParameters", -1);
					r_ContainsGenericParameters.SetBelong(this.instance);
				}
				return r_ContainsGenericParameters;
			}
		}

		/// <summary>
		/// Boolean InitLocals
		/// </summary>
		protected RProperty r_InitLocals;
		public virtual RProperty RInitLocals
		{
			get
			{
				if(r_InitLocals == null)
				{
					r_InitLocals = new(this, "InitLocals", -1);
					r_InitLocals.SetBelong(this.instance);
				}
				return r_InitLocals;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder TypeBuilder
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeBuilder r_TypeBuilder;
		public virtual RSystem.RReflection.REmit.RTypeBuilder RTypeBuilder
		{
			get
			{
				if(r_TypeBuilder == null)
				{
					r_TypeBuilder = new(this, "TypeBuilder", -1);
					r_TypeBuilder.SetBelong(this.instance);
				}
				return r_TypeBuilder;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle MethodHandle
		/// </summary>
		protected RSystem.RRuntimeMethodHandle r_MethodHandle;
		public virtual RSystem.RRuntimeMethodHandle RMethodHandle
		{
			get
			{
				if(r_MethodHandle == null)
				{
					r_MethodHandle = new(this, "MethodHandle", -1);
					r_MethodHandle.SetBelong(this.instance);
				}
				return r_MethodHandle;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle MethodHandleInternal
		/// </summary>
		protected RSystem.RRuntimeMethodHandle r_MethodHandleInternal;
		public virtual RSystem.RRuntimeMethodHandle RMethodHandleInternal
		{
			get
			{
				if(r_MethodHandleInternal == null)
				{
					r_MethodHandleInternal = new(this, "MethodHandleInternal", -1);
					r_MethodHandleInternal.SetBelong(this.instance);
				}
				return r_MethodHandleInternal;
			}
		}

		/// <summary>
		/// System.Type ReturnType
		/// </summary>
		protected RSystem.RType r_ReturnType;
		public virtual RSystem.RType RReturnType
		{
			get
			{
				if(r_ReturnType == null)
				{
					r_ReturnType = new(this, "ReturnType", -1);
					r_ReturnType.SetBelong(this.instance);
				}
				return r_ReturnType;
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
		/// System.Reflection.MethodAttributes Attributes
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
		/// System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes
		/// </summary>
		protected RSystem.RReflection.RICustomAttributeProvider r_ReturnTypeCustomAttributes;
		public virtual RSystem.RReflection.RICustomAttributeProvider RReturnTypeCustomAttributes
		{
			get
			{
				if(r_ReturnTypeCustomAttributes == null)
				{
					r_ReturnTypeCustomAttributes = new(this, "ReturnTypeCustomAttributes", -1);
					r_ReturnTypeCustomAttributes.SetBelong(this.instance);
				}
				return r_ReturnTypeCustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions CallingConvention
		/// </summary>
		protected RProperty r_CallingConvention;
		public virtual RProperty RCallingConvention
		{
			get
			{
				if(r_CallingConvention == null)
				{
					r_CallingConvention = new(this, "CallingConvention", -1);
					r_CallingConvention.SetBelong(this.instance);
				}
				return r_CallingConvention;
			}
		}

		/// <summary>
		/// System.String Signature
		/// </summary>
		protected RProperty r_Signature;
		public virtual RProperty RSignature
		{
			get
			{
				if(r_Signature == null)
				{
					r_Signature = new(this, "Signature", -1);
					r_Signature.SetBelong(this.instance);
				}
				return r_Signature;
			}
		}

		/// <summary>
		/// Boolean BestFitMapping
		/// </summary>
		protected RProperty r_BestFitMapping;
		public virtual RProperty RBestFitMapping
		{
			get
			{
				if(r_BestFitMapping == null)
				{
					r_BestFitMapping = new(this, "BestFitMapping", -1);
					r_BestFitMapping.SetBelong(this.instance);
				}
				return r_BestFitMapping;
			}
		}

		/// <summary>
		/// Boolean ThrowOnUnmappableChar
		/// </summary>
		protected RProperty r_ThrowOnUnmappableChar;
		public virtual RProperty RThrowOnUnmappableChar
		{
			get
			{
				if(r_ThrowOnUnmappableChar == null)
				{
					r_ThrowOnUnmappableChar = new(this, "ThrowOnUnmappableChar", -1);
					r_ThrowOnUnmappableChar.SetBelong(this.instance);
				}
				return r_ThrowOnUnmappableChar;
			}
		}

		/// <summary>
		/// Boolean ExactSpelling
		/// </summary>
		protected RProperty r_ExactSpelling;
		public virtual RProperty RExactSpelling
		{
			get
			{
				if(r_ExactSpelling == null)
				{
					r_ExactSpelling = new(this, "ExactSpelling", -1);
					r_ExactSpelling.SetBelong(this.instance);
				}
				return r_ExactSpelling;
			}
		}

		/// <summary>
		/// Boolean SetLastError
		/// </summary>
		protected RProperty r_SetLastError;
		public virtual RProperty RSetLastError
		{
			get
			{
				if(r_SetLastError == null)
				{
					r_SetLastError = new(this, "SetLastError", -1);
					r_SetLastError.SetBelong(this.instance);
				}
				return r_SetLastError;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodDefinition
		/// </summary>
		protected RProperty r_IsGenericMethodDefinition;
		public virtual RProperty RIsGenericMethodDefinition
		{
			get
			{
				if(r_IsGenericMethodDefinition == null)
				{
					r_IsGenericMethodDefinition = new(this, "IsGenericMethodDefinition", -1);
					r_IsGenericMethodDefinition.SetBelong(this.instance);
				}
				return r_IsGenericMethodDefinition;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethod
		/// </summary>
		protected RProperty r_IsGenericMethod;
		public virtual RProperty RIsGenericMethod
		{
			get
			{
				if(r_IsGenericMethod == null)
				{
					r_IsGenericMethod = new(this, "IsGenericMethod", -1);
					r_IsGenericMethod.SetBelong(this.instance);
				}
				return r_IsGenericMethod;
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
		/// System.Reflection.ParameterInfo ReturnParameter
		/// </summary>
		protected RSystem.RReflection.RParameterInfo r_ReturnParameter;
		public virtual RSystem.RReflection.RParameterInfo RReturnParameter
		{
			get
			{
				if(r_ReturnParameter == null)
				{
					r_ReturnParameter = new(this, "ReturnParameter", -1);
					r_ReturnParameter.SetBelong(this.instance);
				}
				return r_ReturnParameter;
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
		/// Int32 GenericParameterCount
		/// </summary>
		protected RProperty r_GenericParameterCount;
		public virtual RProperty RGenericParameterCount
		{
			get
			{
				if(r_GenericParameterCount == null)
				{
					r_GenericParameterCount = new(this, "GenericParameterCount", -1);
					r_GenericParameterCount.SetBelong(this.instance);
				}
				return r_GenericParameterCount;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes MethodImplementationFlags
		/// </summary>
		protected RProperty r_MethodImplementationFlags;
		public virtual RProperty RMethodImplementationFlags
		{
			get
			{
				if(r_MethodImplementationFlags == null)
				{
					r_MethodImplementationFlags = new(this, "MethodImplementationFlags", -1);
					r_MethodImplementationFlags.SetBelong(this.instance);
				}
				return r_MethodImplementationFlags;
			}
		}

		/// <summary>
		/// Boolean IsAbstract
		/// </summary>
		protected RProperty r_IsAbstract;
		public virtual RProperty RIsAbstract
		{
			get
			{
				if(r_IsAbstract == null)
				{
					r_IsAbstract = new(this, "IsAbstract", -1);
					r_IsAbstract.SetBelong(this.instance);
				}
				return r_IsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsConstructor
		/// </summary>
		protected RProperty r_IsConstructor;
		public virtual RProperty RIsConstructor
		{
			get
			{
				if(r_IsConstructor == null)
				{
					r_IsConstructor = new(this, "IsConstructor", -1);
					r_IsConstructor.SetBelong(this.instance);
				}
				return r_IsConstructor;
			}
		}

		/// <summary>
		/// Boolean IsFinal
		/// </summary>
		protected RProperty r_IsFinal;
		public virtual RProperty RIsFinal
		{
			get
			{
				if(r_IsFinal == null)
				{
					r_IsFinal = new(this, "IsFinal", -1);
					r_IsFinal.SetBelong(this.instance);
				}
				return r_IsFinal;
			}
		}

		/// <summary>
		/// Boolean IsHideBySig
		/// </summary>
		protected RProperty r_IsHideBySig;
		public virtual RProperty RIsHideBySig
		{
			get
			{
				if(r_IsHideBySig == null)
				{
					r_IsHideBySig = new(this, "IsHideBySig", -1);
					r_IsHideBySig.SetBelong(this.instance);
				}
				return r_IsHideBySig;
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
		/// Boolean IsStatic
		/// </summary>
		protected RProperty r_IsStatic;
		public virtual RProperty RIsStatic
		{
			get
			{
				if(r_IsStatic == null)
				{
					r_IsStatic = new(this, "IsStatic", -1);
					r_IsStatic.SetBelong(this.instance);
				}
				return r_IsStatic;
			}
		}

		/// <summary>
		/// Boolean IsVirtual
		/// </summary>
		protected RProperty r_IsVirtual;
		public virtual RProperty RIsVirtual
		{
			get
			{
				if(r_IsVirtual == null)
				{
					r_IsVirtual = new(this, "IsVirtual", -1);
					r_IsVirtual.SetBelong(this.instance);
				}
				return r_IsVirtual;
			}
		}

		/// <summary>
		/// Boolean IsAssembly
		/// </summary>
		protected RProperty r_IsAssembly;
		public virtual RProperty RIsAssembly
		{
			get
			{
				if(r_IsAssembly == null)
				{
					r_IsAssembly = new(this, "IsAssembly", -1);
					r_IsAssembly.SetBelong(this.instance);
				}
				return r_IsAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamily
		/// </summary>
		protected RProperty r_IsFamily;
		public virtual RProperty RIsFamily
		{
			get
			{
				if(r_IsFamily == null)
				{
					r_IsFamily = new(this, "IsFamily", -1);
					r_IsFamily.SetBelong(this.instance);
				}
				return r_IsFamily;
			}
		}

		/// <summary>
		/// Boolean IsFamilyAndAssembly
		/// </summary>
		protected RProperty r_IsFamilyAndAssembly;
		public virtual RProperty RIsFamilyAndAssembly
		{
			get
			{
				if(r_IsFamilyAndAssembly == null)
				{
					r_IsFamilyAndAssembly = new(this, "IsFamilyAndAssembly", -1);
					r_IsFamilyAndAssembly.SetBelong(this.instance);
				}
				return r_IsFamilyAndAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamilyOrAssembly
		/// </summary>
		protected RProperty r_IsFamilyOrAssembly;
		public virtual RProperty RIsFamilyOrAssembly
		{
			get
			{
				if(r_IsFamilyOrAssembly == null)
				{
					r_IsFamilyOrAssembly = new(this, "IsFamilyOrAssembly", -1);
					r_IsFamilyOrAssembly.SetBelong(this.instance);
				}
				return r_IsFamilyOrAssembly;
			}
		}

		/// <summary>
		/// Boolean IsPrivate
		/// </summary>
		protected RProperty r_IsPrivate;
		public virtual RProperty RIsPrivate
		{
			get
			{
				if(r_IsPrivate == null)
				{
					r_IsPrivate = new(this, "IsPrivate", -1);
					r_IsPrivate.SetBelong(this.instance);
				}
				return r_IsPrivate;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected RProperty r_IsPublic;
		public virtual RProperty RIsPublic
		{
			get
			{
				if(r_IsPublic == null)
				{
					r_IsPublic = new(this, "IsPublic", -1);
					r_IsPublic.SetBelong(this.instance);
				}
				return r_IsPublic;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericMethod
		/// </summary>
		protected RProperty r_IsConstructedGenericMethod;
		public virtual RProperty RIsConstructedGenericMethod
		{
			get
			{
				if(r_IsConstructedGenericMethod == null)
				{
					r_IsConstructedGenericMethod = new(this, "IsConstructedGenericMethod", -1);
					r_IsConstructedGenericMethod.SetBelong(this.instance);
				}
				return r_IsConstructedGenericMethod;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected RProperty r_IsSecurityCritical;
		public virtual RProperty RIsSecurityCritical
		{
			get
			{
				if(r_IsSecurityCritical == null)
				{
					r_IsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_IsSecurityCritical.SetBelong(this.instance);
				}
				return r_IsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected RProperty r_IsSecuritySafeCritical;
		public virtual RProperty RIsSecuritySafeCritical
		{
			get
			{
				if(r_IsSecuritySafeCritical == null)
				{
					r_IsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_IsSecuritySafeCritical.SetBelong(this.instance);
				}
				return r_IsSecuritySafeCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected RProperty r_IsSecurityTransparent;
		public virtual RProperty RIsSecurityTransparent
		{
			get
			{
				if(r_IsSecurityTransparent == null)
				{
					r_IsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_IsSecurityTransparent.SetBelong(this.instance);
				}
				return r_IsSecurityTransparent;
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
		/// Void System.Runtime.InteropServices._MethodBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._MethodBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._MethodBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._MethodBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._MethodBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._MethodBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._MethodBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._MethodBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetToken()
		/// </summary>
		protected RMethod r_GetToken;
		public virtual RMethod RGetToken
		{
			get
			{
				if(r_GetToken == null)
				{
					r_GetToken = new(this, "GetToken", 0);
					r_GetToken.SetBelong(this.instance);
				}
				return r_GetToken;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetBaseDefinition()
		/// </summary>
		protected RMethod r_GetBaseDefinition;
		public virtual RMethod RGetBaseDefinition
		{
			get
			{
				if(r_GetBaseDefinition == null)
				{
					r_GetBaseDefinition = new(this, "GetBaseDefinition", 0);
					r_GetBaseDefinition.SetBelong(this.instance);
				}
				return r_GetBaseDefinition;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
		/// </summary>
		protected RMethod r_GetMethodImplementationFlags;
		public virtual RMethod RGetMethodImplementationFlags
		{
			get
			{
				if(r_GetMethodImplementationFlags == null)
				{
					r_GetMethodImplementationFlags = new(this, "GetMethodImplementationFlags", 0);
					r_GetMethodImplementationFlags.SetBelong(this.instance);
				}
				return r_GetMethodImplementationFlags;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParameters()
		/// </summary>
		protected RMethod r_GetParameters;
		public virtual RMethod RGetParameters
		{
			get
			{
				if(r_GetParameters == null)
				{
					r_GetParameters = new(this, "GetParameters", 0);
					r_GetParameters.SetBelong(this.instance);
				}
				return r_GetParameters;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersInternal()
		/// </summary>
		protected RMethod r_GetParametersInternal;
		public virtual RMethod RGetParametersInternal
		{
			get
			{
				if(r_GetParametersInternal == null)
				{
					r_GetParametersInternal = new(this, "GetParametersInternal", 0);
					r_GetParametersInternal.SetBelong(this.instance);
				}
				return r_GetParametersInternal;
			}
		}

		/// <summary>
		/// Int32 GetParametersCount()
		/// </summary>
		protected RMethod r_GetParametersCount;
		public virtual RMethod RGetParametersCount
		{
			get
			{
				if(r_GetParametersCount == null)
				{
					r_GetParametersCount = new(this, "GetParametersCount", 0);
					r_GetParametersCount.SetBelong(this.instance);
				}
				return r_GetParametersCount;
			}
		}

		/// <summary>
		/// System.Type GetParameterType(Int32)
		/// </summary>
		protected RMethod r_GetParameterType_Int32;
		public virtual RMethod RGetParameterType_Int32
		{
			get
			{
				if(r_GetParameterType_Int32 == null)
				{
					r_GetParameterType_Int32 = new(this, "GetParameterType", 0, typeof(System.Int32));
					r_GetParameterType_Int32.SetBelong(this.instance);
				}
				return r_GetParameterType_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase RuntimeResolve()
		/// </summary>
		protected RMethod r_RuntimeResolve;
		public virtual RMethod RRuntimeResolve
		{
			get
			{
				if(r_RuntimeResolve == null)
				{
					r_RuntimeResolve = new(this, "RuntimeResolve", 0);
					r_RuntimeResolve.SetBelong(this.instance);
				}
				return r_RuntimeResolve;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetModule()
		/// </summary>
		protected RMethod r_GetModule;
		public virtual RMethod RGetModule
		{
			get
			{
				if(r_GetModule == null)
				{
					r_GetModule = new(this, "GetModule", 0);
					r_GetModule.SetBelong(this.instance);
				}
				return r_GetModule;
			}
		}

		/// <summary>
		/// Void CreateMethodBody(Byte[], Int32)
		/// </summary>
		protected RMethod r_CreateMethodBody_ByteArray_Int32;
		public virtual RMethod RCreateMethodBody_ByteArray_Int32
		{
			get
			{
				if(r_CreateMethodBody_ByteArray_Int32 == null)
				{
					r_CreateMethodBody_ByteArray_Int32 = new(this, "CreateMethodBody", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_CreateMethodBody_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_CreateMethodBody_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void SetMethodBody(Byte[], Int32, Byte[], System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.ExceptionHandler], System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_SetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
		public virtual RMethod RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_SetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ == null)
				{
					r_SetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ = new(this, "SetMethodBody", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.ExceptionHandler)), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Int32)));
					r_SetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.SetBelong(this.instance);
				}
				return r_SetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_Invoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_Invoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_Invoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_Invoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_Invoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
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
		/// System.Reflection.Emit.ILGenerator GetILGenerator()
		/// </summary>
		protected RMethod r_GetILGenerator;
		public virtual RMethod RGetILGenerator
		{
			get
			{
				if(r_GetILGenerator == null)
				{
					r_GetILGenerator = new(this, "GetILGenerator", 0);
					r_GetILGenerator.SetBelong(this.instance);
				}
				return r_GetILGenerator;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator GetILGenerator(Int32)
		/// </summary>
		protected RMethod r_GetILGenerator_Int32;
		public virtual RMethod RGetILGenerator_Int32
		{
			get
			{
				if(r_GetILGenerator_Int32 == null)
				{
					r_GetILGenerator_Int32 = new(this, "GetILGenerator", 0, typeof(System.Int32));
					r_GetILGenerator_Int32.SetBelong(this.instance);
				}
				return r_GetILGenerator_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterBuilder DefineParameter(Int32, System.Reflection.ParameterAttributes, System.String)
		/// </summary>
		protected RMethod r_DefineParameter_Int32_ParameterAttributes_String;
		public virtual RMethod RDefineParameter_Int32_ParameterAttributes_String
		{
			get
			{
				if(r_DefineParameter_Int32_ParameterAttributes_String == null)
				{
					r_DefineParameter_Int32_ParameterAttributes_String = new(this, "DefineParameter", 0, typeof(System.Int32), typeof(System.Reflection.ParameterAttributes), typeof(System.String));
					r_DefineParameter_Int32_ParameterAttributes_String.SetBelong(this.instance);
				}
				return r_DefineParameter_Int32_ParameterAttributes_String;
			}
		}

		/// <summary>
		/// Void check_override()
		/// </summary>
		protected RMethod r_check_override;
		public virtual RMethod Rcheck_override
		{
			get
			{
				if(r_check_override == null)
				{
					r_check_override = new(this, "check_override", 0);
					r_check_override.SetBelong(this.instance);
				}
				return r_check_override;
			}
		}

		/// <summary>
		/// Void fixup()
		/// </summary>
		protected RMethod r_fixup;
		public virtual RMethod Rfixup
		{
			get
			{
				if(r_fixup == null)
				{
					r_fixup = new(this, "fixup", 0);
					r_fixup.SetBelong(this.instance);
				}
				return r_fixup;
			}
		}

		/// <summary>
		/// Void ResolveUserTypes()
		/// </summary>
		protected RMethod r_ResolveUserTypes;
		public virtual RMethod RResolveUserTypes
		{
			get
			{
				if(r_ResolveUserTypes == null)
				{
					r_ResolveUserTypes = new(this, "ResolveUserTypes", 0);
					r_ResolveUserTypes.SetBelong(this.instance);
				}
				return r_ResolveUserTypes;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo])
		/// </summary>
		protected RMethod r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
		public virtual RMethod RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_
		{
			get
			{
				if(r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ == null)
				{
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.SetBelong(this.instance);
				}
				return r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
			}
		}

		/// <summary>
		/// Void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter)
		/// </summary>
		protected RMethod r_GenerateDebugInfo_ISymbolWriter;
		public virtual RMethod RGenerateDebugInfo_ISymbolWriter
		{
			get
			{
				if(r_GenerateDebugInfo_ISymbolWriter == null)
				{
					r_GenerateDebugInfo_ISymbolWriter = new(this, "GenerateDebugInfo", 0, typeof(System.Diagnostics.SymbolStore.ISymbolWriter));
					r_GenerateDebugInfo_ISymbolWriter.SetBelong(this.instance);
				}
				return r_GenerateDebugInfo_ISymbolWriter;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_SetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_SetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_SetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_SetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_SetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_SetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_SetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_SetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_SetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_SetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void SetImplementationFlags(System.Reflection.MethodImplAttributes)
		/// </summary>
		protected RMethod r_SetImplementationFlags_MethodImplAttributes;
		public virtual RMethod RSetImplementationFlags_MethodImplAttributes
		{
			get
			{
				if(r_SetImplementationFlags_MethodImplAttributes == null)
				{
					r_SetImplementationFlags_MethodImplAttributes = new(this, "SetImplementationFlags", 0, typeof(System.Reflection.MethodImplAttributes));
					r_SetImplementationFlags_MethodImplAttributes.SetBelong(this.instance);
				}
				return r_SetImplementationFlags_MethodImplAttributes;
			}
		}

		/// <summary>
		/// Void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_AddDeclarativeSecurity_SecurityAction_PermissionSet;
		public virtual RMethod RAddDeclarativeSecurity_SecurityAction_PermissionSet
		{
			get
			{
				if(r_AddDeclarativeSecurity_SecurityAction_PermissionSet == null)
				{
					r_AddDeclarativeSecurity_SecurityAction_PermissionSet = new(this, "AddDeclarativeSecurity", 0, typeof(System.Security.Permissions.SecurityAction), typeof(System.Security.PermissionSet));
					r_AddDeclarativeSecurity_SecurityAction_PermissionSet.SetBelong(this.instance);
				}
				return r_AddDeclarativeSecurity_SecurityAction_PermissionSet;
			}
		}

		/// <summary>
		/// Void SetMarshal(System.Reflection.Emit.UnmanagedMarshal)
		/// </summary>
		protected RMethod r_SetMarshal_UnmanagedMarshal;
		public virtual RMethod RSetMarshal_UnmanagedMarshal
		{
			get
			{
				if(r_SetMarshal_UnmanagedMarshal == null)
				{
					r_SetMarshal_UnmanagedMarshal = new(this, "SetMarshal", 0, typeof(System.Reflection.Emit.UnmanagedMarshal));
					r_SetMarshal_UnmanagedMarshal.SetBelong(this.instance);
				}
				return r_SetMarshal_UnmanagedMarshal;
			}
		}

		/// <summary>
		/// Void SetSymCustomAttribute(System.String, Byte[])
		/// </summary>
		protected RMethod r_SetSymCustomAttribute_String_ByteArray;
		public virtual RMethod RSetSymCustomAttribute_String_ByteArray
		{
			get
			{
				if(r_SetSymCustomAttribute_String_ByteArray == null)
				{
					r_SetSymCustomAttribute_String_ByteArray = new(this, "SetSymCustomAttribute", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_SetSymCustomAttribute_String_ByteArray.SetBelong(this.instance);
				}
				return r_SetSymCustomAttribute_String_ByteArray;
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
		/// Int32 get_next_table_index(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_get_next_table_index_Object_Int32_Int32;
		public virtual RMethod Rget_next_table_index_Object_Int32_Int32
		{
			get
			{
				if(r_get_next_table_index_Object_Int32_Int32 == null)
				{
					r_get_next_table_index_Object_Int32_Int32 = new(this, "get_next_table_index", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_get_next_table_index_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_get_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ExtendArray[T](T[] ByRef, T)
		/// </summary>
		protected RMethod r_ExtendArray_GT_Ref_TArray_T;
		public virtual RMethod RExtendArray_GT_Ref_TArray_T
		{
			get
			{
				if(r_ExtendArray_GT_Ref_TArray_T == null)
				{
					r_ExtendArray_GT_Ref_TArray_T = new(this, "ExtendArray", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), Type.MakeGenericMethodParameter(0));
					r_ExtendArray_GT_Ref_TArray_T.SetBelong(this.instance);
				}
				return r_ExtendArray_GT_Ref_TArray_T;
			}
		}

		/// <summary>
		/// Void set_override(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_set_override_MethodInfo;
		public virtual RMethod Rset_override_MethodInfo
		{
			get
			{
				if(r_set_override_MethodInfo == null)
				{
					r_set_override_MethodInfo = new(this, "set_override", 0, typeof(System.Reflection.MethodInfo));
					r_set_override_MethodInfo.SetBelong(this.instance);
				}
				return r_set_override_MethodInfo;
			}
		}

		/// <summary>
		/// Void RejectIfCreated()
		/// </summary>
		protected RMethod r_RejectIfCreated;
		public virtual RMethod RRejectIfCreated
		{
			get
			{
				if(r_RejectIfCreated == null)
				{
					r_RejectIfCreated = new(this, "RejectIfCreated", 0);
					r_RejectIfCreated.SetBelong(this.instance);
				}
				return r_RejectIfCreated;
			}
		}

		/// <summary>
		/// System.Exception NotSupported()
		/// </summary>
		protected RMethod r_NotSupported;
		public virtual RMethod RNotSupported
		{
			get
			{
				if(r_NotSupported == null)
				{
					r_NotSupported = new(this, "NotSupported", 0);
					r_NotSupported.SetBelong(this.instance);
				}
				return r_NotSupported;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo MakeGenericMethod(System.Type[])
		/// </summary>
		protected RMethod r_MakeGenericMethod_TypeArray;
		public virtual RMethod RMakeGenericMethod_TypeArray
		{
			get
			{
				if(r_MakeGenericMethod_TypeArray == null)
				{
					r_MakeGenericMethod_TypeArray = new(this, "MakeGenericMethod", 0, typeof(System.Type).MakeArrayType());
					r_MakeGenericMethod_TypeArray.SetBelong(this.instance);
				}
				return r_MakeGenericMethod_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGenericMethodDefinition()
		/// </summary>
		protected RMethod r_GetGenericMethodDefinition;
		public virtual RMethod RGetGenericMethodDefinition
		{
			get
			{
				if(r_GetGenericMethodDefinition == null)
				{
					r_GetGenericMethodDefinition = new(this, "GetGenericMethodDefinition", 0);
					r_GetGenericMethodDefinition.SetBelong(this.instance);
				}
				return r_GetGenericMethodDefinition;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_GetGenericArguments;
		public virtual RMethod RGetGenericArguments
		{
			get
			{
				if(r_GetGenericArguments == null)
				{
					r_GetGenericArguments = new(this, "GetGenericArguments", 0);
					r_GetGenericArguments.SetBelong(this.instance);
				}
				return r_GetGenericArguments;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(System.String[])
		/// </summary>
		protected RMethod r_DefineGenericParameters_StringArray;
		public virtual RMethod RDefineGenericParameters_StringArray
		{
			get
			{
				if(r_DefineGenericParameters_StringArray == null)
				{
					r_DefineGenericParameters_StringArray = new(this, "DefineGenericParameters", 0, typeof(System.String).MakeArrayType());
					r_DefineGenericParameters_StringArray.SetBelong(this.instance);
				}
				return r_DefineGenericParameters_StringArray;
			}
		}

		/// <summary>
		/// Void SetReturnType(System.Type)
		/// </summary>
		protected RMethod r_SetReturnType_Type;
		public virtual RMethod RSetReturnType_Type
		{
			get
			{
				if(r_SetReturnType_Type == null)
				{
					r_SetReturnType_Type = new(this, "SetReturnType", 0, typeof(System.Type));
					r_SetReturnType_Type.SetBelong(this.instance);
				}
				return r_SetReturnType_Type;
			}
		}

		/// <summary>
		/// Void SetParameters(System.Type[])
		/// </summary>
		protected RMethod r_SetParameters_TypeArray;
		public virtual RMethod RSetParameters_TypeArray
		{
			get
			{
				if(r_SetParameters_TypeArray == null)
				{
					r_SetParameters_TypeArray = new(this, "SetParameters", 0, typeof(System.Type).MakeArrayType());
					r_SetParameters_TypeArray.SetBelong(this.instance);
				}
				return r_SetParameters_TypeArray;
			}
		}

		/// <summary>
		/// Void SetSignature(System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_SetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_SetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_SetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "SetSignature", 0, typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_SetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_SetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type)
		/// </summary>
		protected RMethod r_CreateDelegate_Type;
		public virtual RMethod RCreateDelegate_Type
		{
			get
			{
				if(r_CreateDelegate_Type == null)
				{
					r_CreateDelegate_Type = new(this, "CreateDelegate", 0, typeof(System.Type));
					r_CreateDelegate_Type.SetBelong(this.instance);
				}
				return r_CreateDelegate_Type;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object)
		/// </summary>
		protected RMethod r_CreateDelegate_Type_Object;
		public virtual RMethod RCreateDelegate_Type_Object
		{
			get
			{
				if(r_CreateDelegate_Type_Object == null)
				{
					r_CreateDelegate_Type_Object = new(this, "CreateDelegate", 0, typeof(System.Type), typeof(System.Object));
					r_CreateDelegate_Type_Object.SetBelong(this.instance);
				}
				return r_CreateDelegate_Type_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBody()
		/// </summary>
		protected RMethod r_GetMethodBody;
		public virtual RMethod RGetMethodBody
		{
			get
			{
				if(r_GetMethodBody == null)
				{
					r_GetMethodBody = new(this, "GetMethodBody", 0);
					r_GetMethodBody.SetBelong(this.instance);
				}
				return r_GetMethodBody;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_Invoke_Object_ObjectArray;
		public virtual RMethod RInvoke_Object_ObjectArray
		{
			get
			{
				if(r_Invoke_Object_ObjectArray == null)
				{
					r_Invoke_Object_ObjectArray = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_Invoke_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_Invoke_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.String FormatNameAndSig(Boolean)
		/// </summary>
		protected RMethod r_FormatNameAndSig_Boolean;
		public virtual RMethod RFormatNameAndSig_Boolean
		{
			get
			{
				if(r_FormatNameAndSig_Boolean == null)
				{
					r_FormatNameAndSig_Boolean = new(this, "FormatNameAndSig", 0, typeof(System.Boolean));
					r_FormatNameAndSig_Boolean.SetBelong(this.instance);
				}
				return r_FormatNameAndSig_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetParameterTypes()
		/// </summary>
		protected RMethod r_GetParameterTypes;
		public virtual RMethod RGetParameterTypes
		{
			get
			{
				if(r_GetParameterTypes == null)
				{
					r_GetParameterTypes = new(this, "GetParameterTypes", 0);
					r_GetParameterTypes.SetBelong(this.instance);
				}
				return r_GetParameterTypes;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersNoCopy()
		/// </summary>
		protected RMethod r_GetParametersNoCopy;
		public virtual RMethod RGetParametersNoCopy
		{
			get
			{
				if(r_GetParametersNoCopy == null)
				{
					r_GetParametersNoCopy = new(this, "GetParametersNoCopy", 0);
					r_GetParametersNoCopy.SetBelong(this.instance);
				}
				return r_GetParametersNoCopy;
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


        public RMethodBuilder() : base("System.Reflection.Emit.MethodBuilder")
        {
        }

        public RMethodBuilder(System.Object instance) : base("System.Reflection.Emit.MethodBuilder")
		{
            SetInstance(instance);
		}

        public RMethodBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMethodBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodToken GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetToken.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.MethodInfo GetBaseDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBaseDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodImplementationFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodImplAttributes)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetParametersInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Int32 GetParametersCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetParametersCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetParameterType(System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetParameterType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.MethodBase RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRuntimeResolve.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Reflection.Module GetModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual void CreateMethodBody(System.Byte[] @il, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @count};
            var ___result = RCreateMethodBody_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMethodBody(System.Byte[] @il, System.Int32 @maxStack, System.Byte[] @localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> @exceptionHandlers, System.Collections.Generic.IEnumerable<System.Int32> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @maxStack, @localSignature, @exceptionHandlers, @tokenFixups};
            var ___result = RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Invoke(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetILGenerator.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ILGenerator)___result;
        }


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator(System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RGetILGenerator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ILGenerator)___result;
        }


        public virtual System.Reflection.Emit.ParameterBuilder DefineParameter(System.Int32 @position, System.Reflection.ParameterAttributes @attributes, System.String @strParamName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @attributes, @strParamName};
            var ___result = RDefineParameter_Int32_ParameterAttributes_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ParameterBuilder)___result;
        }


        public virtual void check_override()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rcheck_override.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void fixup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rfixup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveUserTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveUserTypes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map};
            var ___result = RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter @symbolWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@symbolWriter};
            var ___result = RGenerateDebugInfo_ISymbolWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetImplementationFlags(System.Reflection.MethodImplAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RSetImplementationFlags_MethodImplAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction @action, System.Security.PermissionSet @pset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @pset};
            var ___result = RAddDeclarativeSecurity_SecurityAction_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMarshal(System.Reflection.Emit.UnmanagedMarshal @unmanagedMarshal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedMarshal};
            var ___result = RSetMarshal_UnmanagedMarshal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymCustomAttribute(System.String @name, System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetSymCustomAttribute_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ExtendArray<T>(ref T[] @array, T @elem)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @elem};
            var ___result = RExtendArray_GT_Ref_TArray_T.Invoke(___genericsType, ___parameters);
			@array = (T[])___parameters[0];

            
        }


        public virtual void set_override(System.Reflection.MethodInfo @mdecl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdecl};
            var ___result = Rset_override_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RejectIfCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRejectIfCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception NotSupported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNotSupported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Reflection.MethodInfo MakeGenericMethod(System.Type[] @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeArguments};
            var ___result = RMakeGenericMethod_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericMethodDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(System.String[] @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RDefineGenericParameters_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.GenericTypeParameterBuilder[])___result;
        }


        public virtual void SetReturnType(System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType};
            var ___result = RSetReturnType_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParameters(System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameterTypes};
            var ___result = RSetParameters_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSignature(System.Type @returnType, System.Type[] @returnTypeRequiredCustomModifiers, System.Type[] @returnTypeOptionalCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @parameterTypeRequiredCustomModifiers, System.Type[][] @parameterTypeOptionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @returnTypeRequiredCustomModifiers, @returnTypeOptionalCustomModifiers, @parameterTypes, @parameterTypeRequiredCustomModifiers, @parameterTypeOptionalCustomModifiers};
            var ___result = RSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate CreateDelegate(System.Type @delegateType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegateType};
            var ___result = RCreateDelegate_Type.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate CreateDelegate(System.Type @delegateType, System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegateType, @target};
            var ___result = RCreateDelegate_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.Object Invoke(System.Object @obj, System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String FormatNameAndSig(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type[] GetParameterTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetParameterTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersNoCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetParametersNoCopy.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
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


    }
}
