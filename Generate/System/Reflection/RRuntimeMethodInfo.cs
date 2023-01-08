using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeMethodInfo
	/// </summary>
    public partial class RRuntimeMethodInfo : RMember //
    {

		/// <summary>
		/// System.IntPtr mhandle
		/// </summary>
		protected RField r_mhandle;
		public virtual RField Rmhandle
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
		/// System.Type reftype
		/// </summary>
		protected RSystem.RType r_reftype;
		public virtual RSystem.RType Rreftype
		{
			get
			{
				if(r_reftype == null)
				{
					r_reftype = new(this, "reftype");
					r_reftype.SetBelong(this.instance);
				}
				return r_reftype;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BindingFlags
		/// </summary>
		protected RProperty r_BindingFlags;
		public virtual RProperty RBindingFlags
		{
			get
			{
				if(r_BindingFlags == null)
				{
					r_BindingFlags = new(this, "BindingFlags", -1);
					r_BindingFlags.SetBelong(this.instance);
				}
				return r_BindingFlags;
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
		/// System.RuntimeType ReflectedTypeInternal
		/// </summary>
		protected RSystem.RRuntimeType r_ReflectedTypeInternal;
		public virtual RSystem.RRuntimeType RReflectedTypeInternal
		{
			get
			{
				if(r_ReflectedTypeInternal == null)
				{
					r_ReflectedTypeInternal = new(this, "ReflectedTypeInternal", -1);
					r_ReflectedTypeInternal.SetBelong(this.instance);
				}
				return r_ReflectedTypeInternal;
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
		/// System.Reflection.RuntimeModule GetRuntimeModule()
		/// </summary>
		protected RMethod r_GetRuntimeModule;
		public virtual RMethod RGetRuntimeModule
		{
			get
			{
				if(r_GetRuntimeModule == null)
				{
					r_GetRuntimeModule = new(this, "GetRuntimeModule", 0);
					r_GetRuntimeModule.SetBelong(this.instance);
				}
				return r_GetRuntimeModule;
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
		/// System.String SerializationToString()
		/// </summary>
		protected RMethod r_SerializationToString;
		public virtual RMethod RSerializationToString
		{
			get
			{
				if(r_SerializationToString == null)
				{
					r_SerializationToString = new(this, "SerializationToString", 0);
					r_SerializationToString.SetBelong(this.instance);
				}
				return r_SerializationToString;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle)
		/// </summary>
		protected static RMethod r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle;
		public static RMethod RGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle
		{
			get
			{
				if(r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle == null)
				{
					r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleNoGenericCheck", 0, typeof(System.RuntimeMethodHandle));
					r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle.SetBelong(null);
				}
				return r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle;
		public static RMethod RGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle == null)
				{
					r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleNoGenericCheck", 0, typeof(System.RuntimeMethodHandle), typeof(System.RuntimeTypeHandle));
					r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_GetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBodyInternal(IntPtr)
		/// </summary>
		protected static RMethod r_GetMethodBodyInternal_IntPtr;
		public static RMethod RGetMethodBodyInternal_IntPtr
		{
			get
			{
				if(r_GetMethodBodyInternal_IntPtr == null)
				{
					r_GetMethodBodyInternal_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodBodyInternal", 0, typeof(System.IntPtr));
					r_GetMethodBodyInternal_IntPtr.SetBelong(null);
				}
				return r_GetMethodBodyInternal_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBody(IntPtr)
		/// </summary>
		protected static RMethod r_GetMethodBody_IntPtr;
		public static RMethod RGetMethodBody_IntPtr
		{
			get
			{
				if(r_GetMethodBody_IntPtr == null)
				{
					r_GetMethodBody_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodBody", 0, typeof(System.IntPtr));
					r_GetMethodBody_IntPtr.SetBelong(null);
				}
				return r_GetMethodBody_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleInternalType(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_GetMethodFromHandleInternalType_IntPtr_IntPtr;
		public static RMethod RGetMethodFromHandleInternalType_IntPtr_IntPtr
		{
			get
			{
				if(r_GetMethodFromHandleInternalType_IntPtr_IntPtr == null)
				{
					r_GetMethodFromHandleInternalType_IntPtr_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleInternalType", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_GetMethodFromHandleInternalType_IntPtr_IntPtr.SetBelong(null);
				}
				return r_GetMethodFromHandleInternalType_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleInternalType_native(IntPtr, IntPtr, Boolean)
		/// </summary>
		protected static RMethod r_GetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean;
		public static RMethod RGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean
		{
			get
			{
				if(r_GetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean == null)
				{
					r_GetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleInternalType_native", 0, typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.Boolean));
					r_GetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean.SetBelong(null);
				}
				return r_GetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean;
			}
		}

		/// <summary>
		/// System.String get_name(System.Reflection.MethodBase)
		/// </summary>
		protected static RMethod r_get_name_MethodBase;
		public static RMethod Rget_name_MethodBase
		{
			get
			{
				if(r_get_name_MethodBase == null)
				{
					r_get_name_MethodBase = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "get_name", 0, typeof(System.Reflection.MethodBase));
					r_get_name_MethodBase.SetBelong(null);
				}
				return r_get_name_MethodBase;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeMethodInfo get_base_method(System.Reflection.RuntimeMethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_get_base_method_RuntimeMethodInfo_Boolean;
		public static RMethod Rget_base_method_RuntimeMethodInfo_Boolean
		{
			get
			{
				if(r_get_base_method_RuntimeMethodInfo_Boolean == null)
				{
					r_get_base_method_RuntimeMethodInfo_Boolean = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "get_base_method", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), typeof(System.Boolean));
					r_get_base_method_RuntimeMethodInfo_Boolean.SetBelong(null);
				}
				return r_get_base_method_RuntimeMethodInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 get_metadata_token(System.Reflection.RuntimeMethodInfo)
		/// </summary>
		protected static RMethod r_get_metadata_token_RuntimeMethodInfo;
		public static RMethod Rget_metadata_token_RuntimeMethodInfo
		{
			get
			{
				if(r_get_metadata_token_RuntimeMethodInfo == null)
				{
					r_get_metadata_token_RuntimeMethodInfo = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "get_metadata_token", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"));
					r_get_metadata_token_RuntimeMethodInfo.SetBelong(null);
				}
				return r_get_metadata_token_RuntimeMethodInfo;
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
		/// System.Reflection.MethodInfo GetBaseMethod()
		/// </summary>
		protected RMethod r_GetBaseMethod;
		public virtual RMethod RGetBaseMethod
		{
			get
			{
				if(r_GetBaseMethod == null)
				{
					r_GetBaseMethod = new(this, "GetBaseMethod", 0);
					r_GetBaseMethod.SetBelong(this.instance);
				}
				return r_GetBaseMethod;
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
		/// System.Object InternalInvoke(System.Object, System.Object[], System.Exception ByRef)
		/// </summary>
		protected RMethod r_InternalInvoke_Object_ObjectArray_Out_Exception;
		public virtual RMethod RInternalInvoke_Object_ObjectArray_Out_Exception
		{
			get
			{
				if(r_InternalInvoke_Object_ObjectArray_Out_Exception == null)
				{
					r_InternalInvoke_Object_ObjectArray_Out_Exception = new(this, "InternalInvoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Exception).MakeByRefType());
					r_InternalInvoke_Object_ObjectArray_Out_Exception.SetBelong(this.instance);
				}
				return r_InternalInvoke_Object_ObjectArray_Out_Exception;
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
		/// Void ConvertValues(System.Reflection.Binder, System.Object[], System.Reflection.ParameterInfo[], System.Globalization.CultureInfo, System.Reflection.BindingFlags)
		/// </summary>
		protected static RMethod r_ConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags;
		public static RMethod RConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags
		{
			get
			{
				if(r_ConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags == null)
				{
					r_ConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags = new( ReleactionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "ConvertValues", 0, typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterInfo).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Reflection.BindingFlags));
					r_ConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags.SetBelong(null);
				}
				return r_ConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags;
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
		/// Void GetPInvoke(System.Reflection.PInvokeAttributes ByRef, System.String ByRef, System.String ByRef)
		/// </summary>
		protected RMethod r_GetPInvoke_Out_PInvokeAttributes_Out_String_Out_String;
		public virtual RMethod RGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String
		{
			get
			{
				if(r_GetPInvoke_Out_PInvokeAttributes_Out_String_Out_String == null)
				{
					r_GetPInvoke_Out_PInvokeAttributes_Out_String_Out_String = new(this, "GetPInvoke", 0,  ReleactionUtils.GetType("System.Reflection.PInvokeAttributes").MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_GetPInvoke_Out_PInvokeAttributes_Out_String_Out_String.SetBelong(this.instance);
				}
				return r_GetPInvoke_Out_PInvokeAttributes_Out_String_Out_String;
			}
		}

		/// <summary>
		/// System.Object[] GetPseudoCustomAttributes()
		/// </summary>
		protected RMethod r_GetPseudoCustomAttributes;
		public virtual RMethod RGetPseudoCustomAttributes
		{
			get
			{
				if(r_GetPseudoCustomAttributes == null)
				{
					r_GetPseudoCustomAttributes = new(this, "GetPseudoCustomAttributes", 0);
					r_GetPseudoCustomAttributes.SetBelong(this.instance);
				}
				return r_GetPseudoCustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData()
		/// </summary>
		protected RMethod r_GetPseudoCustomAttributesData;
		public virtual RMethod RGetPseudoCustomAttributesData
		{
			get
			{
				if(r_GetPseudoCustomAttributesData == null)
				{
					r_GetPseudoCustomAttributesData = new(this, "GetPseudoCustomAttributesData", 0);
					r_GetPseudoCustomAttributesData.SetBelong(this.instance);
				}
				return r_GetPseudoCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData GetDllImportAttributeData()
		/// </summary>
		protected RMethod r_GetDllImportAttributeData;
		public virtual RMethod RGetDllImportAttributeData
		{
			get
			{
				if(r_GetDllImportAttributeData == null)
				{
					r_GetDllImportAttributeData = new(this, "GetDllImportAttributeData", 0);
					r_GetDllImportAttributeData.SetBelong(this.instance);
				}
				return r_GetDllImportAttributeData;
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
		/// System.Reflection.MethodInfo MakeGenericMethod_impl(System.Type[])
		/// </summary>
		protected RMethod r_MakeGenericMethod_impl_TypeArray;
		public virtual RMethod RMakeGenericMethod_impl_TypeArray
		{
			get
			{
				if(r_MakeGenericMethod_impl_TypeArray == null)
				{
					r_MakeGenericMethod_impl_TypeArray = new(this, "MakeGenericMethod_impl", 0, typeof(System.Type).MakeArrayType());
					r_MakeGenericMethod_impl_TypeArray.SetBelong(this.instance);
				}
				return r_MakeGenericMethod_impl_TypeArray;
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
		/// System.Reflection.MethodInfo GetGenericMethodDefinition_impl()
		/// </summary>
		protected RMethod r_GetGenericMethodDefinition_impl;
		public virtual RMethod RGetGenericMethodDefinition_impl
		{
			get
			{
				if(r_GetGenericMethodDefinition_impl == null)
				{
					r_GetGenericMethodDefinition_impl = new(this, "GetGenericMethodDefinition_impl", 0);
					r_GetGenericMethodDefinition_impl.SetBelong(this.instance);
				}
				return r_GetGenericMethodDefinition_impl;
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
		/// Int32 get_core_clr_security_level()
		/// </summary>
		protected RMethod r_get_core_clr_security_level;
		public virtual RMethod Rget_core_clr_security_level
		{
			get
			{
				if(r_get_core_clr_security_level == null)
				{
					r_get_core_clr_security_level = new(this, "get_core_clr_security_level", 0);
					r_get_core_clr_security_level.SetBelong(this.instance);
				}
				return r_get_core_clr_security_level;
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


        public RRuntimeMethodInfo() : base("System.Reflection.RuntimeMethodInfo")
        {
        }

        public RRuntimeMethodInfo(System.Object instance) : base("System.Reflection.RuntimeMethodInfo")
		{
            SetInstance(instance);
		}

        public RRuntimeMethodInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeMethodInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String FormatNameAndSig(System.Boolean  @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Delegate CreateDelegate(System.Type  @delegateType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegateType};
            var ___result = RCreateDelegate_Type.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate CreateDelegate(System.Type  @delegateType, System.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegateType, @target};
            var ___result = RCreateDelegate_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetRuntimeModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRuntimeModule.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String SerializationToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSerializationToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle  @handle, System.RuntimeTypeHandle  @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @reflectedType};
            var ___result = RGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBody GetMethodBodyInternal(System.IntPtr  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetMethodBodyInternal_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public static System.Reflection.MethodBody GetMethodBody(System.IntPtr  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetMethodBody_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleInternalType(System.IntPtr  @method_handle, System.IntPtr  @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method_handle, @type_handle};
            var ___result = RGetMethodFromHandleInternalType_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleInternalType_native(System.IntPtr  @method_handle, System.IntPtr  @type_handle, System.Boolean  @genericCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method_handle, @type_handle, @genericCheck};
            var ___result = RGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.String get_name(System.Reflection.MethodBase  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = Rget_name_MethodBase.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }




        public virtual System.Reflection.MethodInfo GetBaseDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBaseDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetBaseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBaseMethod.Invoke(___genericsType, ___parameters);

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


        public virtual System.Object InternalInvoke(System.Object  @obj, System.Object[]  @parameters, out System.Exception  @exc)
        {
			exc = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters, @exc};
            var ___result = RInternalInvoke_Object_ObjectArray_Out_Exception.Invoke(___genericsType, ___parameters);
			exc = (System.Exception)___parameters[2];

            return (System.Object)___result;
        }


        public virtual System.Object Invoke(System.Object  @obj, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @parameters, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void ConvertValues(System.Reflection.Binder  @binder, System.Object[]  @args, System.Reflection.ParameterInfo[]  @pinfo, System.Globalization.CultureInfo  @culture, System.Reflection.BindingFlags  @invokeAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binder, @args, @pinfo, @culture, @invokeAttr};
            var ___result = RConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags.Invoke(___genericsType, ___parameters);

            
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



        public virtual System.Object[] GetPseudoCustomAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPseudoCustomAttributes.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPseudoCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Reflection.CustomAttributeData[])___result;
        }


        public virtual System.Reflection.CustomAttributeData GetDllImportAttributeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDllImportAttributeData.Invoke(___genericsType, ___parameters);

            return (System.Reflection.CustomAttributeData)___result;
        }


        public virtual System.Reflection.MethodInfo MakeGenericMethod(System.Type[]  @methodInstantiation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodInstantiation};
            var ___result = RMakeGenericMethod_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo MakeGenericMethod_impl(System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RMakeGenericMethod_impl_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition_impl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericMethodDefinition_impl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericMethodDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Int32 get_core_clr_security_level()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_core_clr_security_level.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Object Invoke(System.Object  @obj, System.Object[]  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetParameterType(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetParameterType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 get_next_table_index(System.Object  @obj, System.Int32  @table, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
