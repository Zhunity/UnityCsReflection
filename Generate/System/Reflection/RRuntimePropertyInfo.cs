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
		protected RSystem.RIntPtr r_Fklass;
		public virtual RSystem.RIntPtr RFklass
		{
			get
			{
				if(r_Fklass == null)
				{
					r_Fklass = new(this, "klass");
					r_Fklass.SetBelong(this.instance);
				}
				return r_Fklass;
			}
		}

		/// <summary>
		/// System.IntPtr prop
		/// </summary>
		protected RSystem.RIntPtr r_Fprop;
		public virtual RSystem.RIntPtr RFprop
		{
			get
			{
				if(r_Fprop == null)
				{
					r_Fprop = new(this, "prop");
					r_Fprop.SetBelong(this.instance);
				}
				return r_Fprop;
			}
		}

		/// <summary>
		/// System.Reflection.MonoPropertyInfo info
		/// </summary>
		protected RSystem.RReflection.RMonoPropertyInfo r_Finfo;
		public virtual RSystem.RReflection.RMonoPropertyInfo RFinfo
		{
			get
			{
				if(r_Finfo == null)
				{
					r_Finfo = new(this, "info");
					r_Finfo.SetBelong(this.instance);
				}
				return r_Finfo;
			}
		}

		/// <summary>
		/// System.Reflection.PInfo cached
		/// </summary>
		protected RSystem.RReflection.RPInfo r_Fcached;
		public virtual RSystem.RReflection.RPInfo RFcached
		{
			get
			{
				if(r_Fcached == null)
				{
					r_Fcached = new(this, "cached");
					r_Fcached.SetBelong(this.instance);
				}
				return r_Fcached;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimePropertyInfo+GetterAdapter cached_getter
		/// </summary>
		protected RSystem.RReflection.RRuntimePropertyInfo.RGetterAdapter r_Fcached_getter;
		public virtual RSystem.RReflection.RRuntimePropertyInfo.RGetterAdapter RFcached_getter
		{
			get
			{
				if(r_Fcached_getter == null)
				{
					r_Fcached_getter = new(this, "cached_getter");
					r_Fcached_getter.SetBelong(this.instance);
				}
				return r_Fcached_getter;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BindingFlags
		/// </summary>
		protected RSystem.RReflection.RBindingFlags r_PBindingFlags;
		public virtual RSystem.RReflection.RBindingFlags RPBindingFlags
		{
			get
			{
				if(r_PBindingFlags == null)
				{
					r_PBindingFlags = new(this, "BindingFlags", -1);
					r_PBindingFlags.SetBelong(this.instance);
				}
				return r_PBindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected RSystem.RReflection.RModule r_PModule;
		public virtual RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
					r_PModule.SetBelong(this.instance);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.RuntimeType ReflectedTypeInternal
		/// </summary>
		protected RSystem.RRuntimeType r_PReflectedTypeInternal;
		public virtual RSystem.RRuntimeType RPReflectedTypeInternal
		{
			get
			{
				if(r_PReflectedTypeInternal == null)
				{
					r_PReflectedTypeInternal = new(this, "ReflectedTypeInternal", -1);
					r_PReflectedTypeInternal.SetBelong(this.instance);
				}
				return r_PReflectedTypeInternal;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyAttributes Attributes
		/// </summary>
		protected RSystem.RReflection.RPropertyAttributes r_PAttributes;
		public virtual RSystem.RReflection.RPropertyAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean CanRead
		/// </summary>
		protected RSystem.RBoolean r_PCanRead;
		public virtual RSystem.RBoolean RPCanRead
		{
			get
			{
				if(r_PCanRead == null)
				{
					r_PCanRead = new(this, "CanRead", -1);
					r_PCanRead.SetBelong(this.instance);
				}
				return r_PCanRead;
			}
		}

		/// <summary>
		/// Boolean CanWrite
		/// </summary>
		protected RSystem.RBoolean r_PCanWrite;
		public virtual RSystem.RBoolean RPCanWrite
		{
			get
			{
				if(r_PCanWrite == null)
				{
					r_PCanWrite = new(this, "CanWrite", -1);
					r_PCanWrite.SetBelong(this.instance);
				}
				return r_PCanWrite;
			}
		}

		/// <summary>
		/// System.Type PropertyType
		/// </summary>
		protected RSystem.RType r_PPropertyType;
		public virtual RSystem.RType RPPropertyType
		{
			get
			{
				if(r_PPropertyType == null)
				{
					r_PPropertyType = new(this, "PropertyType", -1);
					r_PPropertyType.SetBelong(this.instance);
				}
				return r_PPropertyType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_PReflectedType;
		public virtual RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
					r_PReflectedType.SetBelong(this.instance);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected RSystem.RType r_PDeclaringType;
		public virtual RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
					r_PDeclaringType.SetBelong(this.instance);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_PName;
		public virtual RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected RSystem.RInt32 r_PMetadataToken;
		public virtual RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
					r_PMemberType.SetBelong(this.instance);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected RSystem.RBoolean r_PIsSpecialName;
		public virtual RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
					r_PIsSpecialName.SetBelong(this.instance);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_PGetMethod;
		public virtual RSystem.RReflection.RMethodInfo RPGetMethod
		{
			get
			{
				if(r_PGetMethod == null)
				{
					r_PGetMethod = new(this, "GetMethod", -1);
					r_PGetMethod.SetBelong(this.instance);
				}
				return r_PGetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo SetMethod
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_PSetMethod;
		public virtual RSystem.RReflection.RMethodInfo RPSetMethod
		{
			get
			{
				if(r_PSetMethod == null)
				{
					r_PSetMethod = new(this, "SetMethod", -1);
					r_PSetMethod.SetBelong(this.instance);
				}
				return r_PSetMethod;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
					r_PCustomAttributes.SetBelong(this.instance);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Void get_property_info(System.Reflection.RuntimePropertyInfo, System.Reflection.MonoPropertyInfo ByRef, System.Reflection.PInfo)
		/// </summary>
		protected static RMethod r_Mget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo;
		public static RMethod RMget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo
		{
			get
			{
				if(r_Mget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo == null)
				{
					r_Mget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "get_property_info", 0,  ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"),  ReflectionUtils.GetType("System.Reflection.MonoPropertyInfo").MakeByRefType(),  ReflectionUtils.GetType("System.Reflection.PInfo"));
					r_Mget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo.SetBelong(null);
				}
				return r_Mget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo;
			}
		}

		/// <summary>
		/// System.Type[] GetTypeModifiers(System.Reflection.RuntimePropertyInfo, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeModifiers_RuntimePropertyInfo_Boolean;
		public static RMethod RMGetTypeModifiers_RuntimePropertyInfo_Boolean
		{
			get
			{
				if(r_MGetTypeModifiers_RuntimePropertyInfo_Boolean == null)
				{
					r_MGetTypeModifiers_RuntimePropertyInfo_Boolean = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "GetTypeModifiers", 0,  ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), typeof(System.Boolean));
					r_MGetTypeModifiers_RuntimePropertyInfo_Boolean.SetBelong(null);
				}
				return r_MGetTypeModifiers_RuntimePropertyInfo_Boolean;
			}
		}

		/// <summary>
		/// System.Object get_default_value(System.Reflection.RuntimePropertyInfo)
		/// </summary>
		protected static RMethod r_Mget_default_value_RuntimePropertyInfo;
		public static RMethod RMget_default_value_RuntimePropertyInfo
		{
			get
			{
				if(r_Mget_default_value_RuntimePropertyInfo == null)
				{
					r_Mget_default_value_RuntimePropertyInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "get_default_value", 0,  ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"));
					r_Mget_default_value_RuntimePropertyInfo.SetBelong(null);
				}
				return r_Mget_default_value_RuntimePropertyInfo;
			}
		}

		/// <summary>
		/// System.RuntimeType GetDeclaringTypeInternal()
		/// </summary>
		protected RMethod r_MGetDeclaringTypeInternal;
		public virtual RMethod RMGetDeclaringTypeInternal
		{
			get
			{
				if(r_MGetDeclaringTypeInternal == null)
				{
					r_MGetDeclaringTypeInternal = new(this, "GetDeclaringTypeInternal", 0);
					r_MGetDeclaringTypeInternal.SetBelong(this.instance);
				}
				return r_MGetDeclaringTypeInternal;
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
					r_MGetRuntimeModule.SetBelong(this.instance);
				}
				return r_MGetRuntimeModule;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.String FormatNameAndSig(Boolean)
		/// </summary>
		protected RMethod r_MFormatNameAndSig_Boolean;
		public virtual RMethod RMFormatNameAndSig_Boolean
		{
			get
			{
				if(r_MFormatNameAndSig_Boolean == null)
				{
					r_MFormatNameAndSig_Boolean = new(this, "FormatNameAndSig", 0, typeof(System.Boolean));
					r_MFormatNameAndSig_Boolean.SetBelong(this.instance);
				}
				return r_MFormatNameAndSig_Boolean;
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.String SerializationToString()
		/// </summary>
		protected RMethod r_MSerializationToString;
		public virtual RMethod RMSerializationToString
		{
			get
			{
				if(r_MSerializationToString == null)
				{
					r_MSerializationToString = new(this, "SerializationToString", 0);
					r_MSerializationToString.SetBelong(this.instance);
				}
				return r_MSerializationToString;
			}
		}

		/// <summary>
		/// Void CachePropertyInfo(System.Reflection.PInfo)
		/// </summary>
		protected RMethod r_MCachePropertyInfo_PInfo;
		public virtual RMethod RMCachePropertyInfo_PInfo
		{
			get
			{
				if(r_MCachePropertyInfo_PInfo == null)
				{
					r_MCachePropertyInfo_PInfo = new(this, "CachePropertyInfo", 0,  ReflectionUtils.GetType("System.Reflection.PInfo"));
					r_MCachePropertyInfo_PInfo.SetBelong(this.instance);
				}
				return r_MCachePropertyInfo_PInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors(Boolean)
		/// </summary>
		protected RMethod r_MGetAccessors_Boolean;
		public virtual RMethod RMGetAccessors_Boolean
		{
			get
			{
				if(r_MGetAccessors_Boolean == null)
				{
					r_MGetAccessors_Boolean = new(this, "GetAccessors", 0, typeof(System.Boolean));
					r_MGetAccessors_Boolean.SetBelong(this.instance);
				}
				return r_MGetAccessors_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetGetMethod_Boolean;
		public virtual RMethod RMGetGetMethod_Boolean
		{
			get
			{
				if(r_MGetGetMethod_Boolean == null)
				{
					r_MGetGetMethod_Boolean = new(this, "GetGetMethod", 0, typeof(System.Boolean));
					r_MGetGetMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetGetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetIndexParameters()
		/// </summary>
		protected RMethod r_MGetIndexParameters;
		public virtual RMethod RMGetIndexParameters
		{
			get
			{
				if(r_MGetIndexParameters == null)
				{
					r_MGetIndexParameters = new(this, "GetIndexParameters", 0);
					r_MGetIndexParameters.SetBelong(this.instance);
				}
				return r_MGetIndexParameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetSetMethod_Boolean;
		public virtual RMethod RMGetSetMethod_Boolean
		{
			get
			{
				if(r_MGetSetMethod_Boolean == null)
				{
					r_MGetSetMethod_Boolean = new(this, "GetSetMethod", 0, typeof(System.Boolean));
					r_MGetSetMethod_Boolean.SetBelong(this.instance);
				}
				return r_MGetSetMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetConstantValue()
		/// </summary>
		protected RMethod r_MGetConstantValue;
		public virtual RMethod RMGetConstantValue
		{
			get
			{
				if(r_MGetConstantValue == null)
				{
					r_MGetConstantValue = new(this, "GetConstantValue", 0);
					r_MGetConstantValue.SetBelong(this.instance);
				}
				return r_MGetConstantValue;
			}
		}

		/// <summary>
		/// System.Object GetRawConstantValue()
		/// </summary>
		protected RMethod r_MGetRawConstantValue;
		public virtual RMethod RMGetRawConstantValue
		{
			get
			{
				if(r_MGetRawConstantValue == null)
				{
					r_MGetRawConstantValue = new(this, "GetRawConstantValue", 0);
					r_MGetRawConstantValue.SetBelong(this.instance);
				}
				return r_MGetRawConstantValue;
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
					r_MIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefined_Type_Boolean;
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
					r_MGetCustomAttributes_Boolean.SetBelong(this.instance);
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
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object GetterAdapterFrame[T,R](Getter`2, System.Object)
		/// </summary>
		protected static RMethod r_MGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object;
		public static RMethod RMGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object
		{
			get
			{
				if(r_MGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object == null)
				{
					r_MGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "GetterAdapterFrame", 2,  ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo+Getter`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(System.Object));
					r_MGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object.SetBelong(null);
				}
				return r_MGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object;
			}
		}

		/// <summary>
		/// System.Object StaticGetterAdapterFrame[R](StaticGetter`1, System.Object)
		/// </summary>
		protected static RMethod r_MStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object;
		public static RMethod RMStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object
		{
			get
			{
				if(r_MStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object == null)
				{
					r_MStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "StaticGetterAdapterFrame", 1,  ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo+StaticGetter`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Object));
					r_MStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object.SetBelong(null);
				}
				return r_MStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object;
			}
		}

		/// <summary>
		/// GetterAdapter CreateGetterDelegate(System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_MCreateGetterDelegate_MethodInfo;
		public static RMethod RMCreateGetterDelegate_MethodInfo
		{
			get
			{
				if(r_MCreateGetterDelegate_MethodInfo == null)
				{
					r_MCreateGetterDelegate_MethodInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "CreateGetterDelegate", 0, typeof(System.Reflection.MethodInfo));
					r_MCreateGetterDelegate_MethodInfo.SetBelong(null);
				}
				return r_MCreateGetterDelegate_MethodInfo;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MGetValue_Object_ObjectArray;
		public virtual RMethod RMGetValue_Object_ObjectArray
		{
			get
			{
				if(r_MGetValue_Object_ObjectArray == null)
				{
					r_MGetValue_Object_ObjectArray = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MGetValue_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_MGetValue_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "GetValue", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_MGetOptionalCustomModifiers;
		public virtual RMethod RMGetOptionalCustomModifiers
		{
			get
			{
				if(r_MGetOptionalCustomModifiers == null)
				{
					r_MGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_MGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_MGetRequiredCustomModifiers;
		public virtual RMethod RMGetRequiredCustomModifiers
		{
			get
			{
				if(r_MGetRequiredCustomModifiers == null)
				{
					r_MGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_MGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetCustomModifiers(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomModifiers_Boolean;
		public virtual RMethod RMGetCustomModifiers_Boolean
		{
			get
			{
				if(r_MGetCustomModifiers_Boolean == null)
				{
					r_MGetCustomModifiers_Boolean = new(this, "GetCustomModifiers", 0, typeof(System.Boolean));
					r_MGetCustomModifiers_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomModifiers_Boolean;
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
					r_MGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetCustomAttributesData;
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
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Int32 get_metadata_token(System.Reflection.RuntimePropertyInfo)
		/// </summary>
		protected static RMethod r_Mget_metadata_token_RuntimePropertyInfo;
		public static RMethod RMget_metadata_token_RuntimePropertyInfo
		{
			get
			{
				if(r_Mget_metadata_token_RuntimePropertyInfo == null)
				{
					r_Mget_metadata_token_RuntimePropertyInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "get_metadata_token", 0,  ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"));
					r_Mget_metadata_token_RuntimePropertyInfo.SetBelong(null);
				}
				return r_Mget_metadata_token_RuntimePropertyInfo;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo internal_from_handle_type(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_Minternal_from_handle_type_IntPtr_IntPtr;
		public static RMethod RMinternal_from_handle_type_IntPtr_IntPtr
		{
			get
			{
				if(r_Minternal_from_handle_type_IntPtr_IntPtr == null)
				{
					r_Minternal_from_handle_type_IntPtr_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "internal_from_handle_type", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_Minternal_from_handle_type_IntPtr_IntPtr.SetBelong(null);
				}
				return r_Minternal_from_handle_type_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyFromHandle(Mono.RuntimePropertyHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_MGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle;
		public static RMethod RMGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_MGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle == null)
				{
					r_MGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle = new( ReflectionUtils.GetType("System.Reflection.RuntimePropertyInfo"), "GetPropertyFromHandle", 0,  ReflectionUtils.GetType("Mono.RuntimePropertyHandle"), typeof(System.RuntimeTypeHandle));
					r_MGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_MGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetAccessors()
		/// </summary>
		protected RMethod r_MGetAccessors;
		public virtual RMethod RMGetAccessors
		{
			get
			{
				if(r_MGetAccessors == null)
				{
					r_MGetAccessors = new(this, "GetAccessors", 0);
					r_MGetAccessors.SetBelong(this.instance);
				}
				return r_MGetAccessors;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGetMethod()
		/// </summary>
		protected RMethod r_MGetGetMethod;
		public virtual RMethod RMGetGetMethod
		{
			get
			{
				if(r_MGetGetMethod == null)
				{
					r_MGetGetMethod = new(this, "GetGetMethod", 0);
					r_MGetGetMethod.SetBelong(this.instance);
				}
				return r_MGetGetMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetSetMethod()
		/// </summary>
		protected RMethod r_MGetSetMethod;
		public virtual RMethod RMGetSetMethod
		{
			get
			{
				if(r_MGetSetMethod == null)
				{
					r_MGetSetMethod = new(this, "GetSetMethod", 0);
					r_MGetSetMethod.SetBelong(this.instance);
				}
				return r_MGetSetMethod;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.Object)
		/// </summary>
		protected RMethod r_MGetValue_Object;
		public virtual RMethod RMGetValue_Object
		{
			get
			{
				if(r_MGetValue_Object == null)
				{
					r_MGetValue_Object = new(this, "GetValue", 0, typeof(System.Object));
					r_MGetValue_Object.SetBelong(this.instance);
				}
				return r_MGetValue_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object)
		/// </summary>
		protected RMethod r_MSetValue_Object_Object;
		public virtual RMethod RMSetValue_Object_Object
		{
			get
			{
				if(r_MSetValue_Object_Object == null)
				{
					r_MSetValue_Object_Object = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object));
					r_MSetValue_Object_Object.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object;
			}
		}

		/// <summary>
		/// Void SetValue(System.Object, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MSetValue_Object_Object_ObjectArray;
		public virtual RMethod RMSetValue_Object_Object_ObjectArray
		{
			get
			{
				if(r_MSetValue_Object_Object_ObjectArray == null)
				{
					r_MSetValue_Object_Object_ObjectArray = new(this, "SetValue", 0, typeof(System.Object), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MSetValue_Object_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_MSetValue_Object_Object_ObjectArray;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MCacheEquals_Object.SetBelong(this.instance);
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
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public static void get_property_info(RSystem.RReflection.RRuntimePropertyInfo @prop, ref RSystem.RReflection.RMonoPropertyInfo @info, RSystem.RReflection.RPInfo @req_info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop.Value, @info.Value, @req_info.Value};
            var ___result = RMget_property_info_RuntimePropertyInfo_Ref_MonoPropertyInfo_PInfo.Invoke(___genericsType, ___parameters);
			@info = new RSystem.RReflection.RMonoPropertyInfo(___parameters[1]);

            
        }


        public static System.Type[] GetTypeModifiers(RSystem.RReflection.RRuntimePropertyInfo @prop, System.Boolean @optional)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop.Value, @optional};
            var ___result = RMGetTypeModifiers_RuntimePropertyInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.Object get_default_value(RSystem.RReflection.RRuntimePropertyInfo @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop.Value};
            var ___result = RMget_default_value_RuntimePropertyInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual RSystem.RRuntimeType GetDeclaringTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDeclaringTypeInternal.Invoke(___genericsType, ___parameters);

            return new RSystem.RRuntimeType(___result);
        }


        public virtual RSystem.RReflection.RRuntimeModule GetRuntimeModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRuntimeModule.Invoke(___genericsType, ___parameters);

            return new RSystem.RReflection.RRuntimeModule(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String FormatNameAndSig(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String SerializationToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSerializationToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CachePropertyInfo(RSystem.RReflection.RPInfo @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags.Value};
            var ___result = RMCachePropertyInfo_PInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodInfo[] GetAccessors(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetAccessors_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetGetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetIndexParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIndexParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetSetMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawConstantValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawConstantValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Object GetterAdapterFrame<T, R>(RSystem.RReflection.RRuntimePropertyInfo.RGetter<RType, RType> @getter, System.Object @obj)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(R)};
            var ___parameters = new object[]{@getter.Value, @obj};
            var ___result = RMGetterAdapterFrame_GT_GR_Getter_d_T_R_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object StaticGetterAdapterFrame<R>(RSystem.RReflection.RRuntimePropertyInfo.RStaticGetter<RType> @getter, System.Object @obj)
        {

            var ___genericsType = new Type[] {typeof(R)};
            var ___parameters = new object[]{@getter.Value, @obj};
            var ___result = RMStaticGetterAdapterFrame_GR_StaticGetter_d_R_p__Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static RSystem.RReflection.RRuntimePropertyInfo.RGetterAdapter CreateGetterDelegate(System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RMCreateGetterDelegate_MethodInfo.Invoke(___genericsType, ___parameters);

            return new RSystem.RReflection.RRuntimePropertyInfo.RGetterAdapter(___result);
        }


        public virtual System.Object GetValue(System.Object @obj, System.Object[] @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @index};
            var ___result = RMGetValue_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @index, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @index, @culture};
            var ___result = RMGetValue_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object @obj, System.Object @value, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @index, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @invokeAttr, @binder, @index, @culture};
            var ___result = RMSetValue_Object_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetCustomModifiers(System.Boolean @optional)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optional};
            var ___result = RMGetCustomModifiers_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 get_metadata_token(RSystem.RReflection.RRuntimePropertyInfo @monoProperty)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@monoProperty.Value};
            var ___result = RMget_metadata_token_RuntimePropertyInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Reflection.PropertyInfo internal_from_handle_type(System.IntPtr @event_handle, System.IntPtr @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@event_handle, @type_handle};
            var ___result = RMinternal_from_handle_type_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public static System.Reflection.PropertyInfo GetPropertyFromHandle(RMono.RRuntimePropertyHandle @handle, System.RuntimeTypeHandle @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @reflectedType};
            var ___result = RMGetPropertyFromHandle_RuntimePropertyHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetAccessors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAccessors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetSetMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSetMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Object GetValue(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMGetValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetValue(System.Object @obj, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value};
            var ___result = RMSetValue_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(System.Object @obj, System.Object @value, System.Object[] @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @value, @index};
            var ___result = RMSetValue_Object_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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
