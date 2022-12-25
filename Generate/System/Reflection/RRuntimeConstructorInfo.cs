using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeConstructorInfo
	/// </summary>
    public partial class RRuntimeConstructorInfo : RMember //
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
		/// System.RuntimeType ReflectedTypeInternal
		/// </summary>
		protected RSystem.RRuntimeType r_ReflectedTypeInternal;
		public virtual RSystem.RRuntimeType ReflectedTypeInternal
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
		/// System.Reflection.RuntimeModule GetRuntimeModule()
		/// </summary>
		protected RMethod r_RGetRuntimeModule;
		public virtual RMethod RGetRuntimeModule
		{
			get
			{
				if(r_RGetRuntimeModule == null)
				{
					r_RGetRuntimeModule = new(this, "GetRuntimeModule", 0);
					r_RGetRuntimeModule.SetBelong(this.instance);
				}
				return r_RGetRuntimeModule;
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
		/// System.String SerializationToString()
		/// </summary>
		protected RMethod r_RSerializationToString;
		public virtual RMethod RSerializationToString
		{
			get
			{
				if(r_RSerializationToString == null)
				{
					r_RSerializationToString = new(this, "SerializationToString", 0);
					r_RSerializationToString.SetBelong(this.instance);
				}
				return r_RSerializationToString;
			}
		}

		/// <summary>
		/// Void SerializationInvoke(System.Object, System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSerializationInvoke_Object_SerializationInfo_StreamingContext;
		public virtual RMethod RSerializationInvoke_Object_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSerializationInvoke_Object_SerializationInfo_StreamingContext == null)
				{
					r_RSerializationInvoke_Object_SerializationInfo_StreamingContext = new(this, "SerializationInvoke", 0, typeof(System.Object), typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSerializationInvoke_Object_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSerializationInvoke_Object_SerializationInfo_StreamingContext;
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
		/// System.Object InternalInvoke(System.Object, System.Object[], System.Exception ByRef)
		/// </summary>
		protected RMethod r_RInternalInvoke_Object_ObjectArray_Out_Exception;
		public virtual RMethod RInternalInvoke_Object_ObjectArray_Out_Exception
		{
			get
			{
				if(r_RInternalInvoke_Object_ObjectArray_Out_Exception == null)
				{
					r_RInternalInvoke_Object_ObjectArray_Out_Exception = new(this, "InternalInvoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Exception).MakeByRefType());
					r_RInternalInvoke_Object_ObjectArray_Out_Exception.SetBelong(this.instance);
				}
				return r_RInternalInvoke_Object_ObjectArray_Out_Exception;
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
		/// System.Object DoInvoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "DoInvoke", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object InternalInvoke(System.Object, System.Object[], Boolean)
		/// </summary>
		protected RMethod r_RInternalInvoke_Object_ObjectArray_Boolean;
		public virtual RMethod RInternalInvoke_Object_ObjectArray_Boolean
		{
			get
			{
				if(r_RInternalInvoke_Object_ObjectArray_Boolean == null)
				{
					r_RInternalInvoke_Object_ObjectArray_Boolean = new(this, "InternalInvoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Boolean));
					r_RInternalInvoke_Object_ObjectArray_Boolean.SetBelong(this.instance);
				}
				return r_RInternalInvoke_Object_ObjectArray_Boolean;
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
		/// Int32 get_core_clr_security_level()
		/// </summary>
		protected RMethod r_Rget_core_clr_security_level;
		public virtual RMethod Rget_core_clr_security_level
		{
			get
			{
				if(r_Rget_core_clr_security_level == null)
				{
					r_Rget_core_clr_security_level = new(this, "get_core_clr_security_level", 0);
					r_Rget_core_clr_security_level.SetBelong(this.instance);
				}
				return r_Rget_core_clr_security_level;
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
		/// Int32 get_metadata_token(System.Reflection.RuntimeConstructorInfo)
		/// </summary>
		protected static RMethod r_Rget_metadata_token_RuntimeConstructorInfo;
		public static RMethod Rget_metadata_token_RuntimeConstructorInfo
		{
			get
			{
				if(r_Rget_metadata_token_RuntimeConstructorInfo == null)
				{
					r_Rget_metadata_token_RuntimeConstructorInfo = new( ReleactionUtils.GetType("System.Reflection.RuntimeConstructorInfo"), "get_metadata_token", 0,  ReleactionUtils.GetType("System.Reflection.RuntimeConstructorInfo"));
					r_Rget_metadata_token_RuntimeConstructorInfo.SetBelong(null);
				}
				return r_Rget_metadata_token_RuntimeConstructorInfo;
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


        public RRuntimeConstructorInfo() : base("System.Reflection.RuntimeConstructorInfo")
        {
        }

        public RRuntimeConstructorInfo(System.Object instance) : base("System.Reflection.RuntimeConstructorInfo")
		{
            SetInstance(instance);
		}

        public RRuntimeConstructorInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeConstructorInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual void SerializationInvoke(System.Object  @target, System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @info, @context};
            var ___result = RSerializationInvoke_Object_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Object DoInvoke(System.Object  @obj, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @parameters, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RDoInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InternalInvoke(System.Object  @obj, System.Object[]  @parameters, System.Boolean  @wrapExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters, @wrapExceptions};
            var ___result = RInternalInvoke_Object_ObjectArray_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Invoke(System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @parameters, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokeAttr, @binder, @parameters, @culture};
            var ___result = RInvoke_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
