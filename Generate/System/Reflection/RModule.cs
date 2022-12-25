using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.Module
	/// </summary>
    public partial class RModule : RMember //
    {

		/// <summary>
		/// System.Reflection.TypeFilter FilterTypeName
		/// </summary>
		protected static RSystem.RReflection.RTypeFilter r_FilterTypeName;
		public static RSystem.RReflection.RTypeFilter RFilterTypeName
		{
			get
			{
				if(r_FilterTypeName == null)
				{
					r_FilterTypeName = new(typeof(System.Reflection.Module), "FilterTypeName");
					r_FilterTypeName.SetBelong(null);
				}
				return r_FilterTypeName;
			}
		}

		/// <summary>
		/// System.Reflection.TypeFilter FilterTypeNameIgnoreCase
		/// </summary>
		protected static RSystem.RReflection.RTypeFilter r_FilterTypeNameIgnoreCase;
		public static RSystem.RReflection.RTypeFilter RFilterTypeNameIgnoreCase
		{
			get
			{
				if(r_FilterTypeNameIgnoreCase == null)
				{
					r_FilterTypeNameIgnoreCase = new(typeof(System.Reflection.Module), "FilterTypeNameIgnoreCase");
					r_FilterTypeNameIgnoreCase.SetBelong(null);
				}
				return r_FilterTypeNameIgnoreCase;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DefaultLookup
		/// </summary>
		protected static RField r_DefaultLookup;
		public static RField RDefaultLookup
		{
			get
			{
				if(r_DefaultLookup == null)
				{
					r_DefaultLookup = new(typeof(System.Reflection.Module), "DefaultLookup");
					r_DefaultLookup.SetBelong(null);
				}
				return r_DefaultLookup;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Assembly
		/// </summary>
		protected RSystem.RReflection.RAssembly r_Assembly;
		public virtual RSystem.RReflection.RAssembly RAssembly
		{
			get
			{
				if(r_Assembly == null)
				{
					r_Assembly = new(this, "Assembly", -1);
					r_Assembly.SetBelong(this.instance);
				}
				return r_Assembly;
			}
		}

		/// <summary>
		/// System.String FullyQualifiedName
		/// </summary>
		protected RProperty r_FullyQualifiedName;
		public virtual RProperty RFullyQualifiedName
		{
			get
			{
				if(r_FullyQualifiedName == null)
				{
					r_FullyQualifiedName = new(this, "FullyQualifiedName", -1);
					r_FullyQualifiedName.SetBelong(this.instance);
				}
				return r_FullyQualifiedName;
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
		/// Int32 MDStreamVersion
		/// </summary>
		protected RProperty r_MDStreamVersion;
		public virtual RProperty RMDStreamVersion
		{
			get
			{
				if(r_MDStreamVersion == null)
				{
					r_MDStreamVersion = new(this, "MDStreamVersion", -1);
					r_MDStreamVersion.SetBelong(this.instance);
				}
				return r_MDStreamVersion;
			}
		}

		/// <summary>
		/// System.Guid ModuleVersionId
		/// </summary>
		protected RSystem.RGuid r_ModuleVersionId;
		public virtual RSystem.RGuid RModuleVersionId
		{
			get
			{
				if(r_ModuleVersionId == null)
				{
					r_ModuleVersionId = new(this, "ModuleVersionId", -1);
					r_ModuleVersionId.SetBelong(this.instance);
				}
				return r_ModuleVersionId;
			}
		}

		/// <summary>
		/// System.String ScopeName
		/// </summary>
		protected RProperty r_ScopeName;
		public virtual RProperty RScopeName
		{
			get
			{
				if(r_ScopeName == null)
				{
					r_ScopeName = new(this, "ScopeName", -1);
					r_ScopeName.SetBelong(this.instance);
				}
				return r_ScopeName;
			}
		}

		/// <summary>
		/// System.ModuleHandle ModuleHandle
		/// </summary>
		protected RSystem.RModuleHandle r_ModuleHandle;
		public virtual RSystem.RModuleHandle RModuleHandle
		{
			get
			{
				if(r_ModuleHandle == null)
				{
					r_ModuleHandle = new(this, "ModuleHandle", -1);
					r_ModuleHandle.SetBelong(this.instance);
				}
				return r_ModuleHandle;
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
		/// System.Guid MvId
		/// </summary>
		protected RSystem.RGuid r_MvId;
		public virtual RSystem.RGuid RMvId
		{
			get
			{
				if(r_MvId == null)
				{
					r_MvId = new(this, "MvId", -1);
					r_MvId.SetBelong(this.instance);
				}
				return r_MvId;
			}
		}

		/// <summary>
		/// System.ModuleHandle GetModuleHandleImpl()
		/// </summary>
		protected RMethod r_RGetModuleHandleImpl;
		public virtual RMethod RGetModuleHandleImpl
		{
			get
			{
				if(r_RGetModuleHandleImpl == null)
				{
					r_RGetModuleHandleImpl = new(this, "GetModuleHandleImpl", 0);
					r_RGetModuleHandleImpl.SetBelong(this.instance);
				}
				return r_RGetModuleHandleImpl;
			}
		}

		/// <summary>
		/// Void GetPEKind(System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected RMethod r_RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public virtual RMethod RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine = new(this, "GetPEKind", 0, typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(this.instance);
				}
				return r_RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
			}
		}

		/// <summary>
		/// Boolean IsResource()
		/// </summary>
		protected RMethod r_RIsResource;
		public virtual RMethod RIsResource
		{
			get
			{
				if(r_RIsResource == null)
				{
					r_RIsResource = new(this, "IsResource", 0);
					r_RIsResource.SetBelong(this.instance);
				}
				return r_RIsResource;
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
		/// System.Reflection.MethodInfo GetMethod(System.String)
		/// </summary>
		protected RMethod r_RGetMethod_String;
		public virtual RMethod RGetMethod_String
		{
			get
			{
				if(r_RGetMethod_String == null)
				{
					r_RGetMethod_String = new(this, "GetMethod", 0, typeof(System.String));
					r_RGetMethod_String.SetBelong(this.instance);
				}
				return r_RGetMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])
		/// </summary>
		protected RMethod r_RGetMethod_String_TypeArray;
		public virtual RMethod RGetMethod_String_TypeArray
		{
			get
			{
				if(r_RGetMethod_String_TypeArray == null)
				{
					r_RGetMethod_String_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_RGetMethod_String_TypeArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods()
		/// </summary>
		protected RMethod r_RGetMethods;
		public virtual RMethod RGetMethods
		{
			get
			{
				if(r_RGetMethods == null)
				{
					r_RGetMethods = new(this, "GetMethods", 0);
					r_RGetMethods.SetBelong(this.instance);
				}
				return r_RGetMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetMethods_BindingFlags;
		public virtual RMethod RGetMethods_BindingFlags
		{
			get
			{
				if(r_RGetMethods_BindingFlags == null)
				{
					r_RGetMethods_BindingFlags = new(this, "GetMethods", 0, typeof(System.Reflection.BindingFlags));
					r_RGetMethods_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetMethods_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String)
		/// </summary>
		protected RMethod r_RGetField_String;
		public virtual RMethod RGetField_String
		{
			get
			{
				if(r_RGetField_String == null)
				{
					r_RGetField_String = new(this, "GetField", 0, typeof(System.String));
					r_RGetField_String.SetBelong(this.instance);
				}
				return r_RGetField_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetField_String_BindingFlags;
		public virtual RMethod RGetField_String_BindingFlags
		{
			get
			{
				if(r_RGetField_String_BindingFlags == null)
				{
					r_RGetField_String_BindingFlags = new(this, "GetField", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetField_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetField_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields()
		/// </summary>
		protected RMethod r_RGetFields;
		public virtual RMethod RGetFields
		{
			get
			{
				if(r_RGetFields == null)
				{
					r_RGetFields = new(this, "GetFields", 0);
					r_RGetFields.SetBelong(this.instance);
				}
				return r_RGetFields;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetFields_BindingFlags;
		public virtual RMethod RGetFields_BindingFlags
		{
			get
			{
				if(r_RGetFields_BindingFlags == null)
				{
					r_RGetFields_BindingFlags = new(this, "GetFields", 0, typeof(System.Reflection.BindingFlags));
					r_RGetFields_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetFields_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes()
		/// </summary>
		protected RMethod r_RGetTypes;
		public virtual RMethod RGetTypes
		{
			get
			{
				if(r_RGetTypes == null)
				{
					r_RGetTypes = new(this, "GetTypes", 0);
					r_RGetTypes.SetBelong(this.instance);
				}
				return r_RGetTypes;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected RMethod r_RGetType_String;
		public virtual RMethod RGetType_String
		{
			get
			{
				if(r_RGetType_String == null)
				{
					r_RGetType_String = new(this, "GetType", 0, typeof(System.String));
					r_RGetType_String.SetBelong(this.instance);
				}
				return r_RGetType_String;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetType_String_Boolean;
		public virtual RMethod RGetType_String_Boolean
		{
			get
			{
				if(r_RGetType_String_Boolean == null)
				{
					r_RGetType_String_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetType_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetType_String_Boolean_Boolean;
		public virtual RMethod RGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_RGetType_String_Boolean_Boolean == null)
				{
					r_RGetType_String_Boolean_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RGetType_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] FindTypes(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_RFindTypes_TypeFilter_Object;
		public virtual RMethod RFindTypes_TypeFilter_Object
		{
			get
			{
				if(r_RFindTypes_TypeFilter_Object == null)
				{
					r_RFindTypes_TypeFilter_Object = new(this, "FindTypes", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_RFindTypes_TypeFilter_Object.SetBelong(this.instance);
				}
				return r_RFindTypes_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo ResolveField(Int32)
		/// </summary>
		protected RMethod r_RResolveField_Int32;
		public virtual RMethod RResolveField_Int32
		{
			get
			{
				if(r_RResolveField_Int32 == null)
				{
					r_RResolveField_Int32 = new(this, "ResolveField", 0, typeof(System.Int32));
					r_RResolveField_Int32.SetBelong(this.instance);
				}
				return r_RResolveField_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo ResolveField(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_RResolveField_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveField_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveField_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveField_Int32_TypeArray_TypeArray = new(this, "ResolveField", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveField_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_RResolveField_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(Int32)
		/// </summary>
		protected RMethod r_RResolveMember_Int32;
		public virtual RMethod RResolveMember_Int32
		{
			get
			{
				if(r_RResolveMember_Int32 == null)
				{
					r_RResolveMember_Int32 = new(this, "ResolveMember", 0, typeof(System.Int32));
					r_RResolveMember_Int32.SetBelong(this.instance);
				}
				return r_RResolveMember_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_RResolveMember_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveMember_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveMember_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveMember_Int32_TypeArray_TypeArray = new(this, "ResolveMember", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveMember_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_RResolveMember_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(Int32)
		/// </summary>
		protected RMethod r_RResolveMethod_Int32;
		public virtual RMethod RResolveMethod_Int32
		{
			get
			{
				if(r_RResolveMethod_Int32 == null)
				{
					r_RResolveMethod_Int32 = new(this, "ResolveMethod", 0, typeof(System.Int32));
					r_RResolveMethod_Int32.SetBelong(this.instance);
				}
				return r_RResolveMethod_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_RResolveMethod_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveMethod_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveMethod_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveMethod_Int32_TypeArray_TypeArray = new(this, "ResolveMethod", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveMethod_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_RResolveMethod_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// Byte[] ResolveSignature(Int32)
		/// </summary>
		protected RMethod r_RResolveSignature_Int32;
		public virtual RMethod RResolveSignature_Int32
		{
			get
			{
				if(r_RResolveSignature_Int32 == null)
				{
					r_RResolveSignature_Int32 = new(this, "ResolveSignature", 0, typeof(System.Int32));
					r_RResolveSignature_Int32.SetBelong(this.instance);
				}
				return r_RResolveSignature_Int32;
			}
		}

		/// <summary>
		/// System.String ResolveString(Int32)
		/// </summary>
		protected RMethod r_RResolveString_Int32;
		public virtual RMethod RResolveString_Int32
		{
			get
			{
				if(r_RResolveString_Int32 == null)
				{
					r_RResolveString_Int32 = new(this, "ResolveString", 0, typeof(System.Int32));
					r_RResolveString_Int32.SetBelong(this.instance);
				}
				return r_RResolveString_Int32;
			}
		}

		/// <summary>
		/// System.Type ResolveType(Int32)
		/// </summary>
		protected RMethod r_RResolveType_Int32;
		public virtual RMethod RResolveType_Int32
		{
			get
			{
				if(r_RResolveType_Int32 == null)
				{
					r_RResolveType_Int32 = new(this, "ResolveType", 0, typeof(System.Int32));
					r_RResolveType_Int32.SetBelong(this.instance);
				}
				return r_RResolveType_Int32;
			}
		}

		/// <summary>
		/// System.Type ResolveType(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_RResolveType_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveType_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveType_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveType_Int32_TypeArray_TypeArray = new(this, "ResolveType", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveType_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_RResolveType_Int32_TypeArray_TypeArray;
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
		/// Boolean op_Equality(System.Reflection.Module, System.Reflection.Module)
		/// </summary>
		protected static RMethod r_Rop_Equality_Module_Module;
		public static RMethod Rop_Equality_Module_Module
		{
			get
			{
				if(r_Rop_Equality_Module_Module == null)
				{
					r_Rop_Equality_Module_Module = new(typeof(System.Reflection.Module), "op_Equality", 0, typeof(System.Reflection.Module), typeof(System.Reflection.Module));
					r_Rop_Equality_Module_Module.SetBelong(null);
				}
				return r_Rop_Equality_Module_Module;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Module, System.Reflection.Module)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Module_Module;
		public static RMethod Rop_Inequality_Module_Module
		{
			get
			{
				if(r_Rop_Inequality_Module_Module == null)
				{
					r_Rop_Inequality_Module_Module = new(typeof(System.Reflection.Module), "op_Inequality", 0, typeof(System.Reflection.Module), typeof(System.Reflection.Module));
					r_Rop_Inequality_Module_Module.SetBelong(null);
				}
				return r_Rop_Inequality_Module_Module;
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
		/// Boolean FilterTypeNameImpl(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_RFilterTypeNameImpl_Type_Object;
		public static RMethod RFilterTypeNameImpl_Type_Object
		{
			get
			{
				if(r_RFilterTypeNameImpl_Type_Object == null)
				{
					r_RFilterTypeNameImpl_Type_Object = new(typeof(System.Reflection.Module), "FilterTypeNameImpl", 0, typeof(System.Type), typeof(System.Object));
					r_RFilterTypeNameImpl_Type_Object.SetBelong(null);
				}
				return r_RFilterTypeNameImpl_Type_Object;
			}
		}

		/// <summary>
		/// Boolean FilterTypeNameIgnoreCaseImpl(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_RFilterTypeNameIgnoreCaseImpl_Type_Object;
		public static RMethod RFilterTypeNameIgnoreCaseImpl_Type_Object
		{
			get
			{
				if(r_RFilterTypeNameIgnoreCaseImpl_Type_Object == null)
				{
					r_RFilterTypeNameIgnoreCaseImpl_Type_Object = new(typeof(System.Reflection.Module), "FilterTypeNameIgnoreCaseImpl", 0, typeof(System.Type), typeof(System.Object));
					r_RFilterTypeNameIgnoreCaseImpl_Type_Object.SetBelong(null);
				}
				return r_RFilterTypeNameIgnoreCaseImpl_Type_Object;
			}
		}

		/// <summary>
		/// System.Guid Mono_GetGuid(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_RMono_GetGuid_Module;
		public static RMethod RMono_GetGuid_Module
		{
			get
			{
				if(r_RMono_GetGuid_Module == null)
				{
					r_RMono_GetGuid_Module = new(typeof(System.Reflection.Module), "Mono_GetGuid", 0, typeof(System.Reflection.Module));
					r_RMono_GetGuid_Module.SetBelong(null);
				}
				return r_RMono_GetGuid_Module;
			}
		}

		/// <summary>
		/// System.Guid GetModuleVersionId()
		/// </summary>
		protected RMethod r_RGetModuleVersionId;
		public virtual RMethod RGetModuleVersionId
		{
			get
			{
				if(r_RGetModuleVersionId == null)
				{
					r_RGetModuleVersionId = new(this, "GetModuleVersionId", 0);
					r_RGetModuleVersionId.SetBelong(this.instance);
				}
				return r_RGetModuleVersionId;
			}
		}

		/// <summary>
		/// System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
		/// </summary>
		protected RMethod r_RGetSignerCertificate;
		public virtual RMethod RGetSignerCertificate
		{
			get
			{
				if(r_RGetSignerCertificate == null)
				{
					r_RGetSignerCertificate = new(this, "GetSignerCertificate", 0);
					r_RGetSignerCertificate.SetBelong(this.instance);
				}
				return r_RGetSignerCertificate;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Module.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Module.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Module.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Module.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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


        public RModule() : base("System.Reflection.Module")
        {
        }

        public RModule(System.Object instance) : base("System.Reflection.Module")
		{
            SetInstance(instance);
		}

        public RModule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RModule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.ModuleHandle GetModuleHandleImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModuleHandleImpl.Invoke(___genericsType, ___parameters);

            return (System.ModuleHandle)___result;
        }


        public virtual void GetPEKind(out System.Reflection.PortableExecutableKinds  @peKind, out System.Reflection.ImageFileMachine  @machine)
        {
			peKind = default;
			machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@peKind, @machine};
            var ___result = RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			peKind = (System.Reflection.PortableExecutableKinds)___parameters[0];
			machine = (System.Reflection.ImageFileMachine)___parameters[1];

            
        }


        public virtual System.Boolean IsResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
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


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags  @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFields.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags  @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type GetType(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String  @className, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @ignoreCase};
            var ___result = RGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String  @className, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter  @filter, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RFindTypes_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveField_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveMember_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Byte[] ResolveSignature(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String ResolveString(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type ResolveType(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type ResolveType(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public static System.Boolean op_Equality(System.Reflection.Module  @left, System.Reflection.Module  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_Module_Module.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Module  @left, System.Reflection.Module  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_Module_Module.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean FilterTypeNameImpl(System.Type  @cls, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls, @filterCriteria};
            var ___result = RFilterTypeNameImpl_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterTypeNameIgnoreCaseImpl(System.Type  @cls, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls, @filterCriteria};
            var ___result = RFilterTypeNameIgnoreCaseImpl_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Guid Mono_GetGuid(System.Reflection.Module  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMono_GetGuid_Module.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public virtual System.Guid GetModuleVersionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModuleVersionId.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSignerCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Module__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Module__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___Module__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___Module__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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
