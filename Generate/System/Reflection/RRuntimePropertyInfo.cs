using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimePropertyInfo
	/// </summary>
    public partial class RRuntimePropertyInfo : RMember //
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
		/// System.IntPtr prop
		/// </summary>
		protected RField r_prop;
		public virtual RField Rprop
		{
			get
			{
				if(r_prop == null)
				{
					r_prop = new(this, "prop");
					r_prop.SetBelong(this.instance);
				}
				return r_prop;
			}
		}

		/// <summary>
		/// System.Reflection.MonoPropertyInfo info
		/// </summary>
		protected RSystem.RReflection.RMonoPropertyInfo r_info;
		public virtual RSystem.RReflection.RMonoPropertyInfo Rinfo
		{
			get
			{
				if(r_info == null)
				{
					r_info = new(this, "info");
					r_info.SetBelong(this.instance);
				}
				return r_info;
			}
		}

		/// <summary>
		/// System.Reflection.PInfo cached
		/// </summary>
		protected RField r_cached;
		public virtual RField Rcached
		{
			get
			{
				if(r_cached == null)
				{
					r_cached = new(this, "cached");
					r_cached.SetBelong(this.instance);
				}
				return r_cached;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimePropertyInfo+GetterAdapter cached_getter
		/// </summary>
		protected RSystem.RReflection.RRuntimePropertyInfo.RGetterAdapter r_cached_getter;
		public virtual RSystem.RReflection.RRuntimePropertyInfo.RGetterAdapter Rcached_getter
		{
			get
			{
				if(r_cached_getter == null)
				{
					r_cached_getter = new(this, "cached_getter");
					r_cached_getter.SetBelong(this.instance);
				}
				return r_cached_getter;
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
		/// System.Reflection.PropertyAttributes Attributes
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
		/// Boolean CanRead
		/// </summary>
		protected RProperty r_CanRead;
		public virtual RProperty RCanRead
		{
			get
			{
				if(r_CanRead == null)
				{
					r_CanRead = new(this, "CanRead", -1);
					r_CanRead.SetBelong(this.instance);
				}
				return r_CanRead;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected RProperty r_CanWrite;
		public virtual RProperty RCanWrite
		{
			get
			{
				if(r_CanWrite == null)
				{
					r_CanWrite = new(this, "CanWrite", -1);
					r_CanWrite.SetBelong(this.instance);
				}
				return r_CanWrite;
			}
		}

		/// <summary>
		/// System.Type PropertyType
		/// </summary>
		protected RSystem.RType r_PropertyType;
		public virtual RSystem.RType RPropertyType
		{
			get
			{
				if(r_PropertyType == null)
				{
					r_PropertyType = new(this, "PropertyType", -1);
					r_PropertyType.SetBelong(this.instance);
				}
				return r_PropertyType;
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
		/// System.Reflection.MethodInfo GetMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_GetMethod;
		public virtual RSystem.RReflection.RMethodInfo RGetMethod
		{
			get
			{
				if(r_GetMethod == null)
				{
					r_GetMethod = new(this, "GetMethod", -1);
					r_GetMethod.SetBelong(this.instance);
				}
				return r_GetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo SetMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_SetMethod;
		public virtual RSystem.RReflection.RMethodInfo RSetMethod
		{
			get
			{
				if(r_SetMethod == null)
				{
					r_SetMethod = new(this, "SetMethod", -1);
					r_SetMethod.SetBelong(this.instance);
				}
				return r_SetMethod;
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
		/// Void get_property_info(System.Reflection.RuntimePropertyInfo, System.Reflection.MonoPropertyInfo ByRef, System.Reflection.PInfo)
		/// </summary>
		protected static RMethod r_Rget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo;
		public static RMethod Rget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo
		{
			get
			{
				if(r_Rget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo == null)
				{
					r_Rget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "get_property_info", 0,  ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"),  ReleactionUtils.GetType("System.Reflection.MonoPropertyInfo").MakeByRefType(),  ReleactionUtils.GetType("System.Reflection.PInfo"));
					r_Rget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo.SetBelong(null);
				}
				return r_Rget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo;
			}
		}

		/// <summary>
		/// System.Type[] GetTypeModifiers(System.Reflection.RuntimePropertyInfo, Boolean)
		/// </summary>
		protected static RMethod r_RGetTypeModifiers_RuntimePropertyInfo_Boolean;
		public static RMethod RGetTypeModifiers_RuntimePropertyInfo_Boolean
		{
			get
			{
				if(r_RGetTypeModifiers_RuntimePropertyInfo_Boolean == null)
				{
					r_RGetTypeModifiers_RuntimePropertyInfo_Boolean = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "GetTypeModifiers", 0,  ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), typeof(System.Boolean));
					r_RGetTypeModifiers_RuntimePropertyInfo_Boolean.SetBelong(null);
				}
				return r_RGetTypeModifiers_RuntimePropertyInfo_Boolean;
			}
		}

		/// <summary>
		/// System.Object get_default_value(System.Reflection.RuntimePropertyInfo)
		/// </summary>
		protected static RMethod r_Rget_default_value_RuntimePropertyInfo;
		public static RMethod Rget_default_value_RuntimePropertyInfo
		{
			get
			{
				if(r_Rget_default_value_RuntimePropertyInfo == null)
				{
					r_Rget_default_value_RuntimePropertyInfo = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "get_default_value", 0,  ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"));
					r_Rget_default_value_RuntimePropertyInfo.SetBelong(null);
				}
				return r_Rget_default_value_RuntimePropertyInfo;
			}
		}

		/// <summary>
		/// System.RuntimeType GetDeclaringTypeInternal()
		/// </summary>
		protected RMethod r_RGetDeclaringTypeInternal;
		public virtual RMethod RGetDeclaringTypeInternal
		{
			get
			{
				if(r_RGetDeclaringTypeInternal == null)
				{
					r_RGetDeclaringTypeInternal = new(this, "GetDeclaringTypeInternal", 0);
					r_RGetDeclaringTypeInternal.SetBelong(this.instance);
				}
				return r_RGetDeclaringTypeInternal;
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
		/// Void CachePropertyInfo(System.Reflection.PInfo)
		/// </summary>
		protected RMethod r_RCachePropertyInfo_PInfo;
		public virtual RMethod RCachePropertyInfo_PInfo
		{
			get
			{
				if(r_RCachePropertyInfo_PInfo == null)
				{
					r_RCachePropertyInfo_PInfo = new(this, "CachePropertyInfo", 0,  ReleactionUtils.GetType("System.Reflection.PInfo"));
					r_RCachePropertyInfo_PInfo.SetBelong(this.instance);
				}
				return r_RCachePropertyInfo_PInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors(Boolean)
		/// </summary>
		protected RMethod r_RGetAccessors_Boolean;
		public virtual RMethod RGetAccessors_Boolean
		{
			get
			{
				if(r_RGetAccessors_Boolean == null)
				{
					r_RGetAccessors_Boolean = new(this, "GetAccessors", 0, typeof(System.Boolean));
					r_RGetAccessors_Boolean.SetBelong(this.instance);
				}
				return r_RGetAccessors_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod(Boolean)
		/// </summary>
		protected RMethod r_RGetGetMethod_Boolean;
		public virtual RMethod RGetGetMethod_Boolean
		{
			get
			{
				if(r_RGetGetMethod_Boolean == null)
				{
					r_RGetGetMethod_Boolean = new(this, "GetGetMethod", 0, typeof(System.Boolean));
					r_RGetGetMethod_Boolean.SetBelong(this.instance);
				}
				return r_RGetGetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetIndexParameters()
		/// </summary>
		protected RMethod r_RGetIndexParameters;
		public virtual RMethod RGetIndexParameters
		{
			get
			{
				if(r_RGetIndexParameters == null)
				{
					r_RGetIndexParameters = new(this, "GetIndexParameters", 0);
					r_RGetIndexParameters.SetBelong(this.instance);
				}
				return r_RGetIndexParameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod(Boolean)
		/// </summary>
		protected RMethod r_RGetSetMethod_Boolean;
		public virtual RMethod RGetSetMethod_Boolean
		{
			get
			{
				if(r_RGetSetMethod_Boolean == null)
				{
					r_RGetSetMethod_Boolean = new(this, "GetSetMethod", 0, typeof(System.Boolean));
					r_RGetSetMethod_Boolean.SetBelong(this.instance);
				}
				return r_RGetSetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetConstantValue()
		/// </summary>
		protected RMethod r_RGetConstantValue;
		public virtual RMethod RGetConstantValue
		{
			get
			{
				if(r_RGetConstantValue == null)
				{
					r_RGetConstantValue = new(this, "GetConstantValue", 0);
					r_RGetConstantValue.SetBelong(this.instance);
				}
				return r_RGetConstantValue;
			}
		}

		/// <summary>
		/// System.Object GetRawConstantValue()
		/// </summary>
		protected RMethod r_RGetRawConstantValue;
		public virtual RMethod RGetRawConstantValue
		{
			get
			{
				if(r_RGetRawConstantValue == null)
				{
					r_RGetRawConstantValue = new(this, "GetRawConstantValue", 0);
					r_RGetRawConstantValue.SetBelong(this.instance);
				}
				return r_RGetRawConstantValue;
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
		/// System.Object GetterAdapterFrame[T,R](Getter`2, System.Object)
		/// </summary>
		protected static RMethod r_RGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object;
		public static RMethod RGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object
		{
			get
			{
				if(r_RGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object == null)
				{
					r_RGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "GetterAdapterFrame", 2,  ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo+Getter`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(System.Object));
					r_RGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object.SetBelong(null);
				}
				return r_RGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object;
			}
		}

		/// <summary>
		/// System.Object StaticGetterAdapterFrame[R](StaticGetter`1, System.Object)
		/// </summary>
		protected static RMethod r_RStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object;
		public static RMethod RStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object
		{
			get
			{
				if(r_RStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object == null)
				{
					r_RStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "StaticGetterAdapterFrame", 1,  ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo+StaticGetter`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_RStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object.SetBelong(null);
				}
				return r_RStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object;
			}
		}

		/// <summary>
		/// GetterAdapter CreateGetterDelegate(System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_RCreateGetterDelegate_MethodInfo;
		public static RMethod RCreateGetterDelegate_MethodInfo
		{
			get
			{
				if(r_RCreateGetterDelegate_MethodInfo == null)
				{
					r_RCreateGetterDelegate_MethodInfo = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "CreateGetterDelegate", 0, typeof(System.Reflection.MethodInfo));
					r_RCreateGetterDelegate_MethodInfo.SetBelong(null);
				}
				return r_RCreateGetterDelegate_MethodInfo;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_RGetValue_Object_ObjectArray;
		public virtual RMethod RGetValue_Object_ObjectArray
		{
			get
			{
				if(r_RGetValue_Object_ObjectArray == null)
				{
					r_RGetValue_Object_ObjectArray = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RGetValue_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_RGetValue_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_RGetOptionalCustomModifiers;
		public virtual RMethod RGetOptionalCustomModifiers
		{
			get
			{
				if(r_RGetOptionalCustomModifiers == null)
				{
					r_RGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_RGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_RGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_RGetRequiredCustomModifiers;
		public virtual RMethod RGetRequiredCustomModifiers
		{
			get
			{
				if(r_RGetRequiredCustomModifiers == null)
				{
					r_RGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_RGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_RGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetCustomModifiers(Boolean)
		/// </summary>
		protected RMethod r_RGetCustomModifiers_Boolean;
		public virtual RMethod RGetCustomModifiers_Boolean
		{
			get
			{
				if(r_RGetCustomModifiers_Boolean == null)
				{
					r_RGetCustomModifiers_Boolean = new(this, "GetCustomModifiers", 0, typeof(System.Boolean));
					r_RGetCustomModifiers_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomModifiers_Boolean;
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
		/// Int32 get_metadata_token(System.Reflection.RuntimePropertyInfo)
		/// </summary>
		protected static RMethod r_Rget_metadata_token_RuntimePropertyInfo;
		public static RMethod Rget_metadata_token_RuntimePropertyInfo
		{
			get
			{
				if(r_Rget_metadata_token_RuntimePropertyInfo == null)
				{
					r_Rget_metadata_token_RuntimePropertyInfo = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "get_metadata_token", 0,  ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"));
					r_Rget_metadata_token_RuntimePropertyInfo.SetBelong(null);
				}
				return r_Rget_metadata_token_RuntimePropertyInfo;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo internal_from_handle_type(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Rinternal_from_handle_type_IntPtr_IntPtr;
		public static RMethod Rinternal_from_handle_type_IntPtr_IntPtr
		{
			get
			{
				if(r_Rinternal_from_handle_type_IntPtr_IntPtr == null)
				{
					r_Rinternal_from_handle_type_IntPtr_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "internal_from_handle_type", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_Rinternal_from_handle_type_IntPtr_IntPtr.SetBelong(null);
				}
				return r_Rinternal_from_handle_type_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyFromHandle(Mono.RuntimePropertyHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_RGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle;
		public static RMethod RGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_RGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle == null)
				{
					r_RGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle = new( ReleactionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "GetPropertyFromHandle", 0,  ReleactionUtils.GetType("Mono.RuntimePropertyHandle"), typeof(System.RuntimeTypeHandle));
					r_RGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_RGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors()
		/// </summary>
		protected RMethod r_RGetAccessors;
		public virtual RMethod RGetAccessors
		{
			get
			{
				if(r_RGetAccessors == null)
				{
					r_RGetAccessors = new(this, "GetAccessors", 0);
					r_RGetAccessors.SetBelong(this.instance);
				}
				return r_RGetAccessors;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod()
		/// </summary>
		protected RMethod r_RGetGetMethod;
		public virtual RMethod RGetGetMethod
		{
			get
			{
				if(r_RGetGetMethod == null)
				{
					r_RGetGetMethod = new(this, "GetGetMethod", 0);
					r_RGetGetMethod.SetBelong(this.instance);
				}
				return r_RGetGetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod()
		/// </summary>
		protected RMethod r_RGetSetMethod;
		public virtual RMethod RGetSetMethod
		{
			get
			{
				if(r_RGetSetMethod == null)
				{
					r_RGetSetMethod = new(this, "GetSetMethod", 0);
					r_RGetSetMethod.SetBelong(this.instance);
				}
				return r_RGetSetMethod;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object)
		/// </summary>
		protected RMethod r_RGetValue_Object;
		public virtual RMethod RGetValue_Object
		{
			get
			{
				if(r_RGetValue_Object == null)
				{
					r_RGetValue_Object = new(this, "GetValue", 0, typeof(System.Object));
					r_RGetValue_Object.SetBelong(this.instance);
				}
				return r_RGetValue_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetValue_Object_Object;
		public virtual RMethod RSetValue_Object_Object
		{
			get
			{
				if(r_RSetValue_Object_Object == null)
				{
					r_RSetValue_Object_Object = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object));
					r_RSetValue_Object_Object.SetBelong(this.instance);
				}
				return r_RSetValue_Object_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_RSetValue_Object_Object_ObjectArray;
		public virtual RMethod RSetValue_Object_Object_ObjectArray
		{
			get
			{
				if(r_RSetValue_Object_Object_ObjectArray == null)
				{
					r_RSetValue_Object_Object_ObjectArray = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RSetValue_Object_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_RSetValue_Object_Object_ObjectArray;
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


        public RRuntimePropertyInfo() : base("System.Reflection.RuntimePropertyInfo")
        {
        }

        public RRuntimePropertyInfo(System.Object instance) : base("System.Reflection.RuntimePropertyInfo")
		{
            SetInstance(instance);
		}

        public RRuntimePropertyInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimePropertyInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String FormatNameAndSig(System.Boolean  @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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



        public virtual System.Reflection.MethodInfo[] GetAccessors(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetAccessors_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetGetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetIndexParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIndexParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod(System.Boolean  @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RGetSetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawConstantValue.Invoke(___genericsType, ___parameters);

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




        public static System.Object CreateGetterDelegate(System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RCreateGetterDelegate_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object  @obj, System.Object[]  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @index};
            var ___result = RGetValue_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object  @obj, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @index, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @index, @culture};
            var ___result = RGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @value, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object[]  @index, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @index, @culture};
            var ___result = RSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public static System.Reflection.PropertyInfo internal_from_handle_type(System.IntPtr  @event_handle, System.IntPtr  @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@event_handle, @type_handle};
            var ___result = Rinternal_from_handle_type_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }



        public virtual System.Reflection.MethodInfo[] GetAccessors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccessors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetValue(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object  @obj, System.Object  @value, System.Object[]  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @index};
            var ___result = RSetValue_Object_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            
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
