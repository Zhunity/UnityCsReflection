using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ConstructorBuilder
	/// </summary>
    public partial class RConstructorBuilder : RMember //
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
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_ReflectedType;
		public virtual RSystem.RType ReflectedType
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
		/// System.Type ReturnType
		/// </summary>
		protected RSystem.RType r_ReturnType;
		public virtual RSystem.RType ReturnType
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
		/// Void System.Runtime.InteropServices._ConstructorBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
		/// </summary>
		protected RMethod r_RGetMethodImplementationFlags;
		public virtual RMethod RGetMethodImplementationFlags
		{
			get
			{
				if(r_RGetMethodImplementationFlags == null)
				{
					r_RGetMethodImplementationFlags = new(this, "GetMethodImplementationFlags", 0);
					r_RGetMethodImplementationFlags.SetBelong(this.instance);
				}
				return r_RGetMethodImplementationFlags;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParameters()
		/// </summary>
		protected RMethod r_RGetParameters;
		public virtual RMethod RGetParameters
		{
			get
			{
				if(r_RGetParameters == null)
				{
					r_RGetParameters = new(this, "GetParameters", 0);
					r_RGetParameters.SetBelong(this.instance);
				}
				return r_RGetParameters;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersInternal()
		/// </summary>
		protected RMethod r_RGetParametersInternal;
		public virtual RMethod RGetParametersInternal
		{
			get
			{
				if(r_RGetParametersInternal == null)
				{
					r_RGetParametersInternal = new(this, "GetParametersInternal", 0);
					r_RGetParametersInternal.SetBelong(this.instance);
				}
				return r_RGetParametersInternal;
			}
		}

		/// <summary>
		/// Int32 GetParametersCount()
		/// </summary>
		protected RMethod r_RGetParametersCount;
		public virtual RMethod RGetParametersCount
		{
			get
			{
				if(r_RGetParametersCount == null)
				{
					r_RGetParametersCount = new(this, "GetParametersCount", 0);
					r_RGetParametersCount.SetBelong(this.instance);
				}
				return r_RGetParametersCount;
			}
		}

		/// <summary>
		/// System.Type GetParameterType(Int32)
		/// </summary>
		protected RMethod r_RGetParameterType_Int32;
		public virtual RMethod RGetParameterType_Int32
		{
			get
			{
				if(r_RGetParameterType_Int32 == null)
				{
					r_RGetParameterType_Int32 = new(this, "GetParameterType", 0, typeof(System.Int32));
					r_RGetParameterType_Int32.SetBelong(this.instance);
				}
				return r_RGetParameterType_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase RuntimeResolve()
		/// </summary>
		protected RMethod r_RRuntimeResolve;
		public virtual RMethod RRuntimeResolve
		{
			get
			{
				if(r_RRuntimeResolve == null)
				{
					r_RRuntimeResolve = new(this, "RuntimeResolve", 0);
					r_RRuntimeResolve.SetBelong(this.instance);
				}
				return r_RRuntimeResolve;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_RAddDeclarativeSecurity_SecurityAction_PermissionSet;
		public virtual RMethod RAddDeclarativeSecurity_SecurityAction_PermissionSet
		{
			get
			{
				if(r_RAddDeclarativeSecurity_SecurityAction_PermissionSet == null)
				{
					r_RAddDeclarativeSecurity_SecurityAction_PermissionSet = new(this, "AddDeclarativeSecurity", 0, typeof(System.Security.Permissions.SecurityAction), typeof(System.Security.PermissionSet));
					r_RAddDeclarativeSecurity_SecurityAction_PermissionSet.SetBelong(this.instance);
				}
				return r_RAddDeclarativeSecurity_SecurityAction_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterBuilder DefineParameter(Int32, System.Reflection.ParameterAttributes, System.String)
		/// </summary>
		protected RMethod r_RDefineParameter_Int32_ParameterAttributes_String;
		public virtual RMethod RDefineParameter_Int32_ParameterAttributes_String
		{
			get
			{
				if(r_RDefineParameter_Int32_ParameterAttributes_String == null)
				{
					r_RDefineParameter_Int32_ParameterAttributes_String = new(this, "DefineParameter", 0, typeof(System.Int32), typeof(System.Reflection.ParameterAttributes), typeof(System.String));
					r_RDefineParameter_Int32_ParameterAttributes_String.SetBelong(this.instance);
				}
				return r_RDefineParameter_Int32_ParameterAttributes_String;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RIsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_RIsDefined_Type_Boolean == null)
				{
					r_RIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_RIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_RIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Boolean == null)
				{
					r_RGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_RGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Type_Boolean == null)
				{
					r_RGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator GetILGenerator()
		/// </summary>
		protected RMethod r_RGetILGenerator;
		public virtual RMethod RGetILGenerator
		{
			get
			{
				if(r_RGetILGenerator == null)
				{
					r_RGetILGenerator = new(this, "GetILGenerator", 0);
					r_RGetILGenerator.SetBelong(this.instance);
				}
				return r_RGetILGenerator;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator GetILGenerator(Int32)
		/// </summary>
		protected RMethod r_RGetILGenerator_Int32;
		public virtual RMethod RGetILGenerator_Int32
		{
			get
			{
				if(r_RGetILGenerator_Int32 == null)
				{
					r_RGetILGenerator_Int32 = new(this, "GetILGenerator", 0, typeof(System.Int32));
					r_RGetILGenerator_Int32.SetBelong(this.instance);
				}
				return r_RGetILGenerator_Int32;
			}
		}

		/// <summary>
		/// Void SetMethodBody(Byte[], Int32, Byte[], System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.ExceptionHandler], System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
		public virtual RMethod RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ == null)
				{
					r_RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ = new(this, "SetMethodBody", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.ExceptionHandler)), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Int32)));
					r_RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.SetBelong(this.instance);
				}
				return r_RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_RSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_RSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_RSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_RSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_RSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_RSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_RSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_RSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void SetImplementationFlags(System.Reflection.MethodImplAttributes)
		/// </summary>
		protected RMethod r_RSetImplementationFlags_MethodImplAttributes;
		public virtual RMethod RSetImplementationFlags_MethodImplAttributes
		{
			get
			{
				if(r_RSetImplementationFlags_MethodImplAttributes == null)
				{
					r_RSetImplementationFlags_MethodImplAttributes = new(this, "SetImplementationFlags", 0, typeof(System.Reflection.MethodImplAttributes));
					r_RSetImplementationFlags_MethodImplAttributes.SetBelong(this.instance);
				}
				return r_RSetImplementationFlags_MethodImplAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetModule()
		/// </summary>
		protected RMethod r_RGetModule;
		public virtual RMethod RGetModule
		{
			get
			{
				if(r_RGetModule == null)
				{
					r_RGetModule = new(this, "GetModule", 0);
					r_RGetModule.SetBelong(this.instance);
				}
				return r_RGetModule;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetToken()
		/// </summary>
		protected RMethod r_RGetToken;
		public virtual RMethod RGetToken
		{
			get
			{
				if(r_RGetToken == null)
				{
					r_RGetToken = new(this, "GetToken", 0);
					r_RGetToken.SetBelong(this.instance);
				}
				return r_RGetToken;
			}
		}

		/// <summary>
		/// Void SetSymCustomAttribute(System.String, Byte[])
		/// </summary>
		protected RMethod r_RSetSymCustomAttribute_String_ByteArray;
		public virtual RMethod RSetSymCustomAttribute_String_ByteArray
		{
			get
			{
				if(r_RSetSymCustomAttribute_String_ByteArray == null)
				{
					r_RSetSymCustomAttribute_String_ByteArray = new(this, "SetSymCustomAttribute", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RSetSymCustomAttribute_String_ByteArray.SetBelong(this.instance);
				}
				return r_RSetSymCustomAttribute_String_ByteArray;
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
		/// Void fixup()
		/// </summary>
		protected RMethod r_Rfixup;
		public virtual RMethod Rfixup
		{
			get
			{
				if(r_Rfixup == null)
				{
					r_Rfixup = new(this, "fixup", 0);
					r_Rfixup.SetBelong(this.instance);
				}
				return r_Rfixup;
			}
		}

		/// <summary>
		/// Void ResolveUserTypes()
		/// </summary>
		protected RMethod r_RResolveUserTypes;
		public virtual RMethod RResolveUserTypes
		{
			get
			{
				if(r_RResolveUserTypes == null)
				{
					r_RResolveUserTypes = new(this, "ResolveUserTypes", 0);
					r_RResolveUserTypes.SetBelong(this.instance);
				}
				return r_RResolveUserTypes;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo])
		/// </summary>
		protected RMethod r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
		public virtual RMethod RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_
		{
			get
			{
				if(r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ == null)
				{
					r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
					r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.SetBelong(this.instance);
				}
				return r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
			}
		}

		/// <summary>
		/// Void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter)
		/// </summary>
		protected RMethod r_RGenerateDebugInfo_ISymbolWriter;
		public virtual RMethod RGenerateDebugInfo_ISymbolWriter
		{
			get
			{
				if(r_RGenerateDebugInfo_ISymbolWriter == null)
				{
					r_RGenerateDebugInfo_ISymbolWriter = new(this, "GenerateDebugInfo", 0, typeof(System.Diagnostics.SymbolStore.ISymbolWriter));
					r_RGenerateDebugInfo_ISymbolWriter.SetBelong(this.instance);
				}
				return r_RGenerateDebugInfo_ISymbolWriter;
			}
		}

		/// <summary>
		/// Int32 get_next_table_index(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_Rget_next_table_index_Object_Int32_Int32;
		public virtual RMethod Rget_next_table_index_Object_Int32_Int32
		{
			get
			{
				if(r_Rget_next_table_index_Object_Int32_Int32 == null)
				{
					r_Rget_next_table_index_Object_Int32_Int32 = new(this, "get_next_table_index", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_Rget_next_table_index_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_Rget_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void RejectIfCreated()
		/// </summary>
		protected RMethod r_RRejectIfCreated;
		public virtual RMethod RRejectIfCreated
		{
			get
			{
				if(r_RRejectIfCreated == null)
				{
					r_RRejectIfCreated = new(this, "RejectIfCreated", 0);
					r_RRejectIfCreated.SetBelong(this.instance);
				}
				return r_RRejectIfCreated;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Rnot_supported;
		public virtual RMethod Rnot_supported
		{
			get
			{
				if(r_Rnot_supported == null)
				{
					r_Rnot_supported = new(this, "not_supported", 0);
					r_Rnot_supported.SetBelong(this.instance);
				}
				return r_Rnot_supported;
			}
		}

		/// <summary>
		/// System.Exception not_after_created()
		/// </summary>
		protected RMethod r_Rnot_after_created;
		public virtual RMethod Rnot_after_created
		{
			get
			{
				if(r_Rnot_after_created == null)
				{
					r_Rnot_after_created = new(this, "not_after_created", 0);
					r_Rnot_after_created.SetBelong(this.instance);
				}
				return r_Rnot_after_created;
			}
		}

		/// <summary>
		/// System.Exception not_created()
		/// </summary>
		protected RMethod r_Rnot_created;
		public virtual RMethod Rnot_created
		{
			get
			{
				if(r_Rnot_created == null)
				{
					r_Rnot_created = new(this, "not_created", 0);
					r_Rnot_created.SetBelong(this.instance);
				}
				return r_Rnot_created;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object[])
		/// </summary>
		protected RMethod r_RInvoke_ObjectArray;
		public virtual RMethod RInvoke_ObjectArray
		{
			get
			{
				if(r_RInvoke_ObjectArray == null)
				{
					r_RInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
					r_RInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_RInvoke_ObjectArray;
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
		/// System.Reflection.MethodBody GetMethodBody()
		/// </summary>
		protected RMethod r_RGetMethodBody;
		public virtual RMethod RGetMethodBody
		{
			get
			{
				if(r_RGetMethodBody == null)
				{
					r_RGetMethodBody = new(this, "GetMethodBody", 0);
					r_RGetMethodBody.SetBelong(this.instance);
				}
				return r_RGetMethodBody;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_RGetGenericArguments;
		public virtual RMethod RGetGenericArguments
		{
			get
			{
				if(r_RGetGenericArguments == null)
				{
					r_RGetGenericArguments = new(this, "GetGenericArguments", 0);
					r_RGetGenericArguments.SetBelong(this.instance);
				}
				return r_RGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_RInvoke_Object_ObjectArray;
		public virtual RMethod RInvoke_Object_ObjectArray
		{
			get
			{
				if(r_RInvoke_Object_ObjectArray == null)
				{
					r_RInvoke_Object_ObjectArray = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RInvoke_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_RInvoke_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.String FormatNameAndSig(Boolean)
		/// </summary>
		protected RMethod r_RFormatNameAndSig_Boolean;
		public virtual RMethod RFormatNameAndSig_Boolean
		{
			get
			{
				if(r_RFormatNameAndSig_Boolean == null)
				{
					r_RFormatNameAndSig_Boolean = new(this, "FormatNameAndSig", 0, typeof(System.Boolean));
					r_RFormatNameAndSig_Boolean.SetBelong(this.instance);
				}
				return r_RFormatNameAndSig_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetParameterTypes()
		/// </summary>
		protected RMethod r_RGetParameterTypes;
		public virtual RMethod RGetParameterTypes
		{
			get
			{
				if(r_RGetParameterTypes == null)
				{
					r_RGetParameterTypes = new(this, "GetParameterTypes", 0);
					r_RGetParameterTypes.SetBelong(this.instance);
				}
				return r_RGetParameterTypes;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersNoCopy()
		/// </summary>
		protected RMethod r_RGetParametersNoCopy;
		public virtual RMethod RGetParametersNoCopy
		{
			get
			{
				if(r_RGetParametersNoCopy == null)
				{
					r_RGetParametersNoCopy = new(this, "GetParametersNoCopy", 0);
					r_RGetParametersNoCopy.SetBelong(this.instance);
				}
				return r_RGetParametersNoCopy;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_RHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_RHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_RHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_RHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_RGetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_RGetCustomAttributesData == null)
				{
					r_RGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_RGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_RGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_RCacheEquals_Object;
		public virtual RMethod RCacheEquals_Object
		{
			get
			{
				if(r_RCacheEquals_Object == null)
				{
					r_RCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_RCacheEquals_Object.SetBelong(this.instance);
				}
				return r_RCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RConstructorBuilder() : base("System.Reflection.Emit.ConstructorBuilder")
        {
        }

        public RConstructorBuilder(System.Object instance) : base("System.Reflection.Emit.ConstructorBuilder")
		{
            SetInstance(instance);
		}

        public RConstructorBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConstructorBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ConstructorBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Type GetParameterType(System.Int32  @pos)
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


        public virtual System.Object Invoke(System.Object  @obj, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @parameters, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Invoke(System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @parameters, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokeAttr, @binder, @parameters, @culture};
            var ___result = RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction  @action, System.Security.PermissionSet  @pset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @pset};
            var ___result = RAddDeclarativeSecurity_SecurityAction_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.ParameterBuilder DefineParameter(System.Int32  @iSequence, System.Reflection.ParameterAttributes  @attributes, System.String  @strParamName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iSequence, @attributes, @strParamName};
            var ___result = RDefineParameter_Int32_ParameterAttributes_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ParameterBuilder)___result;
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


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetILGenerator.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ILGenerator)___result;
        }


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator(System.Int32  @streamSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@streamSize};
            var ___result = RGetILGenerator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ILGenerator)___result;
        }


        public virtual void SetMethodBody(System.Byte[]  @il, System.Int32  @maxStack, System.Byte[]  @localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler>  @exceptionHandlers, System.Collections.Generic.IEnumerable<System.Int32>  @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @maxStack, @localSignature, @exceptionHandlers, @tokenFixups};
            var ___result = RSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder  @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo  @con, System.Byte[]  @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetImplementationFlags(System.Reflection.MethodImplAttributes  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RSetImplementationFlags_MethodImplAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Module GetModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetToken.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual void SetSymCustomAttribute(System.String  @name, System.Byte[]  @data)
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


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32>  @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo>  @member_map)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map};
            var ___result = RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter  @symbolWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@symbolWriter};
            var ___result = RGenerateDebugInfo_ISymbolWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 get_next_table_index(System.Object  @obj, System.Int32  @table, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RejectIfCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRejectIfCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_supported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception not_after_created()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_after_created.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception not_created()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_created.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Object Invoke(System.Object[]  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Object Invoke(System.Object  @obj, System.Object[]  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String FormatNameAndSig(System.Boolean  @serialization)
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


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo  @other)
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


    }
}
