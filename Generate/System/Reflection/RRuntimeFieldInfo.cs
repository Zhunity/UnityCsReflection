using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeFieldInfo
	/// </summary>
    public partial class RRuntimeFieldInfo : RMember //
    {

		/// <summary>
		/// System.IntPtr klass
		/// </summary>
		protected RField r_klass;
		public virtual RField Rklass
		{
			get
			{
				if(r_klass == null)
				{
					r_klass = new(this, "klass");
					r_klass.SetBelong(this.instance);
				}
				return r_klass;
			}
		}

		/// <summary>
		/// System.RuntimeFieldHandle fhandle
		/// </summary>
		protected RSystem.RRuntimeFieldHandle r_fhandle;
		public virtual RSystem.RRuntimeFieldHandle Rfhandle
		{
			get
			{
				if(r_fhandle == null)
				{
					r_fhandle = new(this, "fhandle");
					r_fhandle.SetBelong(this.instance);
				}
				return r_fhandle;
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
		/// System.Type type
		/// </summary>
		protected RSystem.RType r_type;
		public virtual RSystem.RType Rtype
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
		/// System.Reflection.FieldAttributes attrs
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
		/// System.Reflection.FieldAttributes Attributes
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
		/// System.RuntimeFieldHandle FieldHandle
		/// </summary>
		protected RSystem.RRuntimeFieldHandle r_FieldHandle;
		public virtual RSystem.RRuntimeFieldHandle RFieldHandle
		{
			get
			{
				if(r_FieldHandle == null)
				{
					r_FieldHandle = new(this, "FieldHandle", -1);
					r_FieldHandle.SetBelong(this.instance);
				}
				return r_FieldHandle;
			}
		}

		/// <summary>
		/// System.Type FieldType
		/// </summary>
		protected RSystem.RType r_FieldType;
		public virtual RSystem.RType RFieldType
		{
			get
			{
				if(r_FieldType == null)
				{
					r_FieldType = new(this, "FieldType", -1);
					r_FieldType.SetBelong(this.instance);
				}
				return r_FieldType;
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
		/// Boolean IsInitOnly
		/// </summary>
		protected RProperty r_IsInitOnly;
		public virtual RProperty RIsInitOnly
		{
			get
			{
				if(r_IsInitOnly == null)
				{
					r_IsInitOnly = new(this, "IsInitOnly", -1);
					r_IsInitOnly.SetBelong(this.instance);
				}
				return r_IsInitOnly;
			}
		}

		/// <summary>
		/// Boolean IsLiteral
		/// </summary>
		protected RProperty r_IsLiteral;
		public virtual RProperty RIsLiteral
		{
			get
			{
				if(r_IsLiteral == null)
				{
					r_IsLiteral = new(this, "IsLiteral", -1);
					r_IsLiteral.SetBelong(this.instance);
				}
				return r_IsLiteral;
			}
		}

		/// <summary>
		/// Boolean IsNotSerialized
		/// </summary>
		protected RProperty r_IsNotSerialized;
		public virtual RProperty RIsNotSerialized
		{
			get
			{
				if(r_IsNotSerialized == null)
				{
					r_IsNotSerialized = new(this, "IsNotSerialized", -1);
					r_IsNotSerialized.SetBelong(this.instance);
				}
				return r_IsNotSerialized;
			}
		}

		/// <summary>
		/// Boolean IsPinvokeImpl
		/// </summary>
		protected RProperty r_IsPinvokeImpl;
		public virtual RProperty RIsPinvokeImpl
		{
			get
			{
				if(r_IsPinvokeImpl == null)
				{
					r_IsPinvokeImpl = new(this, "IsPinvokeImpl", -1);
					r_IsPinvokeImpl.SetBelong(this.instance);
				}
				return r_IsPinvokeImpl;
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
		/// System.RuntimeType GetDeclaringTypeInternal()
		/// </summary>
		protected RMethod r_GetDeclaringTypeInternal;
		public virtual RMethod RGetDeclaringTypeInternal
		{
			get
			{
				if(r_GetDeclaringTypeInternal == null)
				{
					r_GetDeclaringTypeInternal = new(this, "GetDeclaringTypeInternal", 0);
					r_GetDeclaringTypeInternal.SetBelong(this.instance);
				}
				return r_GetDeclaringTypeInternal;
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
		/// System.Object UnsafeGetValue(System.Object)
		/// </summary>
		protected RMethod r_UnsafeGetValue_Object;
		public virtual RMethod RUnsafeGetValue_Object
		{
			get
			{
				if(r_UnsafeGetValue_Object == null)
				{
					r_UnsafeGetValue_Object = new(this, "UnsafeGetValue", 0, typeof(System.Object));
					r_UnsafeGetValue_Object.SetBelong(this.instance);
				}
				return r_UnsafeGetValue_Object;
			}
		}

		/// <summary>
		/// Void CheckConsistency(System.Object)
		/// </summary>
		protected RMethod r_CheckConsistency_Object;
		public virtual RMethod RCheckConsistency_Object
		{
			get
			{
				if(r_CheckConsistency_Object == null)
				{
					r_CheckConsistency_Object = new(this, "CheckConsistency", 0, typeof(System.Object));
					r_CheckConsistency_Object.SetBelong(this.instance);
				}
				return r_CheckConsistency_Object;
			}
		}

		/// <summary>
		/// Void UnsafeSetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_UnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo;
		public virtual RMethod RUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo
		{
			get
			{
				if(r_UnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo == null)
				{
					r_UnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo = new(this, "UnsafeSetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Globalization.CultureInfo));
					r_UnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo.SetBelong(this.instance);
				}
				return r_UnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo;
			}
		}

		/// <summary>
		/// Void SetValueDirect(TypedReference, System.Object)
		/// </summary>
		protected RMethod r_SetValueDirect_TypedReference_Object;
		public virtual RMethod RSetValueDirect_TypedReference_Object
		{
			get
			{
				if(r_SetValueDirect_TypedReference_Object == null)
				{
					r_SetValueDirect_TypedReference_Object = new(this, "SetValueDirect", 0, typeof(System.TypedReference), typeof(System.Object));
					r_SetValueDirect_TypedReference_Object.SetBelong(this.instance);
				}
				return r_SetValueDirect_TypedReference_Object;
			}
		}

		/// <summary>
		/// System.Object GetValueDirect(TypedReference)
		/// </summary>
		protected RMethod r_GetValueDirect_TypedReference;
		public virtual RMethod RGetValueDirect_TypedReference
		{
			get
			{
				if(r_GetValueDirect_TypedReference == null)
				{
					r_GetValueDirect_TypedReference = new(this, "GetValueDirect", 0, typeof(System.TypedReference));
					r_GetValueDirect_TypedReference.SetBelong(this.instance);
				}
				return r_GetValueDirect_TypedReference;
			}
		}

		/// <summary>
		/// System.Type ResolveType()
		/// </summary>
		protected RMethod r_ResolveType;
		public virtual RMethod RResolveType
		{
			get
			{
				if(r_ResolveType == null)
				{
					r_ResolveType = new(this, "ResolveType", 0);
					r_ResolveType.SetBelong(this.instance);
				}
				return r_ResolveType;
			}
		}

		/// <summary>
		/// System.Type GetParentType(Boolean)
		/// </summary>
		protected RMethod r_GetParentType_Boolean;
		public virtual RMethod RGetParentType_Boolean
		{
			get
			{
				if(r_GetParentType_Boolean == null)
				{
					r_GetParentType_Boolean = new(this, "GetParentType", 0, typeof(System.Boolean));
					r_GetParentType_Boolean.SetBelong(this.instance);
				}
				return r_GetParentType_Boolean;
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
		/// Int32 GetFieldOffset()
		/// </summary>
		protected RMethod r_GetFieldOffset;
		public virtual RMethod RGetFieldOffset
		{
			get
			{
				if(r_GetFieldOffset == null)
				{
					r_GetFieldOffset = new(this, "GetFieldOffset", 0);
					r_GetFieldOffset.SetBelong(this.instance);
				}
				return r_GetFieldOffset;
			}
		}

		/// <summary>
		/// System.Object GetValueInternal(System.Object)
		/// </summary>
		protected RMethod r_GetValueInternal_Object;
		public virtual RMethod RGetValueInternal_Object
		{
			get
			{
				if(r_GetValueInternal_Object == null)
				{
					r_GetValueInternal_Object = new(this, "GetValueInternal", 0, typeof(System.Object));
					r_GetValueInternal_Object.SetBelong(this.instance);
				}
				return r_GetValueInternal_Object;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object)
		/// </summary>
		protected RMethod r_GetValue_Object;
		public virtual RMethod RGetValue_Object
		{
			get
			{
				if(r_GetValue_Object == null)
				{
					r_GetValue_Object = new(this, "GetValue", 0, typeof(System.Object));
					r_GetValue_Object.SetBelong(this.instance);
				}
				return r_GetValue_Object;
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
		/// Void SetValueInternal(System.Reflection.FieldInfo, System.Object, System.Object)
		/// </summary>
		protected static RMethod r_SetValueInternal_FieldInfo_Object_Object;
		public static RMethod RSetValueInternal_FieldInfo_Object_Object
		{
			get
			{
				if(r_SetValueInternal_FieldInfo_Object_Object == null)
				{
					r_SetValueInternal_FieldInfo_Object_Object = new( ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"), "SetValueInternal", 0, typeof(System.Reflection.FieldInfo), typeof(System.Object), typeof(System.Object));
					r_SetValueInternal_FieldInfo_Object_Object.SetBelong(null);
				}
				return r_SetValueInternal_FieldInfo_Object_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_SetValue_Object_Object_BindingFlags_Binder_CultureInfo;
		public virtual RMethod RSetValue_Object_Object_BindingFlags_Binder_CultureInfo
		{
			get
			{
				if(r_SetValue_Object_Object_BindingFlags_Binder_CultureInfo == null)
				{
					r_SetValue_Object_Object_BindingFlags_Binder_CultureInfo = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Globalization.CultureInfo));
					r_SetValue_Object_Object_BindingFlags_Binder_CultureInfo.SetBelong(this.instance);
				}
				return r_SetValue_Object_Object_BindingFlags_Binder_CultureInfo;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeFieldInfo Clone(System.String)
		/// </summary>
		protected RMethod r_Clone_String;
		public virtual RMethod RClone_String
		{
			get
			{
				if(r_Clone_String == null)
				{
					r_Clone_String = new(this, "Clone", 0, typeof(System.String));
					r_Clone_String.SetBelong(this.instance);
				}
				return r_Clone_String;
			}
		}

		/// <summary>
		/// System.Object GetRawConstantValue()
		/// </summary>
		protected RMethod r_GetRawConstantValue;
		public virtual RMethod RGetRawConstantValue
		{
			get
			{
				if(r_GetRawConstantValue == null)
				{
					r_GetRawConstantValue = new(this, "GetRawConstantValue", 0);
					r_GetRawConstantValue.SetBelong(this.instance);
				}
				return r_GetRawConstantValue;
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
		/// Void CheckGeneric()
		/// </summary>
		protected RMethod r_CheckGeneric;
		public virtual RMethod RCheckGeneric
		{
			get
			{
				if(r_CheckGeneric == null)
				{
					r_CheckGeneric = new(this, "CheckGeneric", 0);
					r_CheckGeneric.SetBelong(this.instance);
				}
				return r_CheckGeneric;
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
		/// Int32 get_metadata_token(System.Reflection.RuntimeFieldInfo)
		/// </summary>
		protected static RMethod r_get_metadata_token_RuntimeFieldInfo;
		public static RMethod Rget_metadata_token_RuntimeFieldInfo
		{
			get
			{
				if(r_get_metadata_token_RuntimeFieldInfo == null)
				{
					r_get_metadata_token_RuntimeFieldInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"), "get_metadata_token", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeFieldInfo"));
					r_get_metadata_token_RuntimeFieldInfo.SetBelong(null);
				}
				return r_get_metadata_token_RuntimeFieldInfo;
			}
		}

		/// <summary>
		/// System.Type[] GetTypeModifiers(Boolean)
		/// </summary>
		protected RMethod r_GetTypeModifiers_Boolean;
		public virtual RMethod RGetTypeModifiers_Boolean
		{
			get
			{
				if(r_GetTypeModifiers_Boolean == null)
				{
					r_GetTypeModifiers_Boolean = new(this, "GetTypeModifiers", 0, typeof(System.Boolean));
					r_GetTypeModifiers_Boolean.SetBelong(this.instance);
				}
				return r_GetTypeModifiers_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_GetOptionalCustomModifiers;
		public virtual RMethod RGetOptionalCustomModifiers
		{
			get
			{
				if(r_GetOptionalCustomModifiers == null)
				{
					r_GetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_GetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_GetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_GetRequiredCustomModifiers;
		public virtual RMethod RGetRequiredCustomModifiers
		{
			get
			{
				if(r_GetRequiredCustomModifiers == null)
				{
					r_GetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_GetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_GetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetCustomModifiers(Boolean)
		/// </summary>
		protected RMethod r_GetCustomModifiers_Boolean;
		public virtual RMethod RGetCustomModifiers_Boolean
		{
			get
			{
				if(r_GetCustomModifiers_Boolean == null)
				{
					r_GetCustomModifiers_Boolean = new(this, "GetCustomModifiers", 0, typeof(System.Boolean));
					r_GetCustomModifiers_Boolean.SetBelong(this.instance);
				}
				return r_GetCustomModifiers_Boolean;
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
		/// Void SetValue(System.Object, System.Object)
		/// </summary>
		protected RMethod r_SetValue_Object_Object;
		public virtual RMethod RSetValue_Object_Object
		{
			get
			{
				if(r_SetValue_Object_Object == null)
				{
					r_SetValue_Object_Object = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object));
					r_SetValue_Object_Object.SetBelong(this.instance);
				}
				return r_SetValue_Object_Object;
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


        public RRuntimeFieldInfo() : base("System.Reflection.RuntimeFieldInfo")
        {
        }

        public RRuntimeFieldInfo(System.Object instance) : base("System.Reflection.RuntimeFieldInfo")
		{
            SetInstance(instance);
		}

        public RRuntimeFieldInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeFieldInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetDeclaringTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDeclaringTypeInternal.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Object UnsafeGetValue(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RUnsafeGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void CheckConsistency(System.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RCheckConsistency_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeSetValue(System.Object  @obj, System.Object  @value, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @culture};
            var ___result = RUnsafeSetValue_Object_Object_BindingFlags_Binder_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Type ResolveType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetParentType(System.Boolean  @declaring)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@declaring};
            var ___result = RGetParentType_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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


        public virtual System.Int32 GetFieldOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFieldOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetValueInternal(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetValueInternal_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void SetValueInternal(System.Reflection.FieldInfo  @fi, System.Object  @obj, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fi, @obj, @value};
            var ___result = RSetValueInternal_FieldInfo_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @val, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @val, @invokeAttr, @binder, @culture};
            var ___result = RSetValue_Object_Object_BindingFlags_Binder_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone(System.String  @newName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newName};
            var ___result = RClone_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual void CheckGeneric()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckGeneric.Invoke(___genericsType, ___parameters);

            
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


        public static System.Int32 get_metadata_token(RSystem.RReflection.RRuntimeFieldInfo  @monoField)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@monoField.Value};
            var ___result = Rget_metadata_token_RuntimeFieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type[] GetTypeModifiers(System.Boolean  @optional)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optional};
            var ___result = RGetTypeModifiers_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetCustomModifiers(System.Boolean  @optional)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optional};
            var ___result = RGetCustomModifiers_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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


        public virtual void SetValue(System.Object  @obj, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
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
