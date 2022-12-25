using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeModule
	/// </summary>
    public partial class RRuntimeModule : RMember //
    {

		/// <summary>
		/// System.IntPtr _impl
		/// </summary>
		protected RField r__impl;
		public virtual RField R_impl
		{
			get
			{
				if(r__impl == null)
				{
					r__impl = new(this, "_impl");
					r__impl.SetBelong(this.instance);
				}
				return r__impl;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly assembly
		/// </summary>
		protected RSystem.RReflection.RAssembly r_assembly;
		public virtual RSystem.RReflection.RAssembly Rassembly
		{
			get
			{
				if(r_assembly == null)
				{
					r_assembly = new(this, "assembly");
					r_assembly.SetBelong(this.instance);
				}
				return r_assembly;
			}
		}

		/// <summary>
		/// System.String fqname
		/// </summary>
		protected RField r_fqname;
		public virtual RField Rfqname
		{
			get
			{
				if(r_fqname == null)
				{
					r_fqname = new(this, "fqname");
					r_fqname.SetBelong(this.instance);
				}
				return r_fqname;
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
		/// System.String scopename
		/// </summary>
		protected RField r_scopename;
		public virtual RField Rscopename
		{
			get
			{
				if(r_scopename == null)
				{
					r_scopename = new(this, "scopename");
					r_scopename.SetBelong(this.instance);
				}
				return r_scopename;
			}
		}

		/// <summary>
		/// System.Boolean is_resource
		/// </summary>
		protected RField r_is_resource;
		public virtual RField Ris_resource
		{
			get
			{
				if(r_is_resource == null)
				{
					r_is_resource = new(this, "is_resource");
					r_is_resource.SetBelong(this.instance);
				}
				return r_is_resource;
			}
		}

		/// <summary>
		/// System.Int32 token
		/// </summary>
		protected RField r_token;
		public virtual RField Rtoken
		{
			get
			{
				if(r_token == null)
				{
					r_token = new(this, "token");
					r_token.SetBelong(this.instance);
				}
				return r_token;
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
		/// IntPtr MonoModule
		/// </summary>
		protected RProperty r_MonoModule;
		public virtual RProperty RMonoModule
		{
			get
			{
				if(r_MonoModule == null)
				{
					r_MonoModule = new(this, "MonoModule", -1);
					r_MonoModule.SetBelong(this.instance);
				}
				return r_MonoModule;
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
		/// System.Reflection.FieldInfo ResolveField(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveField", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray;
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
		/// System.Reflection.MemberInfo ResolveMember(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMember", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray;
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
		/// System.Reflection.MethodBase ResolveMethod(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMethod", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray;
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
		/// System.String ResolveString(System.Reflection.Module, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_RResolveString_Module_IntPtr_Int32;
		public static RMethod RResolveString_Module_IntPtr_Int32
		{
			get
			{
				if(r_RResolveString_Module_IntPtr_Int32 == null)
				{
					r_RResolveString_Module_IntPtr_Int32 = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveString", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32));
					r_RResolveString_Module_IntPtr_Int32.SetBelong(null);
				}
				return r_RResolveString_Module_IntPtr_Int32;
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
		/// System.Type ResolveType(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveType", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray;
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
		/// Byte[] ResolveSignature(System.Reflection.Module, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_RResolveSignature_Module_IntPtr_Int32;
		public static RMethod RResolveSignature_Module_IntPtr_Int32
		{
			get
			{
				if(r_RResolveSignature_Module_IntPtr_Int32 == null)
				{
					r_RResolveSignature_Module_IntPtr_Int32 = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveSignature", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32));
					r_RResolveSignature_Module_IntPtr_Int32.SetBelong(null);
				}
				return r_RResolveSignature_Module_IntPtr_Int32;
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
		/// System.Reflection.RuntimeAssembly GetRuntimeAssembly()
		/// </summary>
		protected RMethod r_RGetRuntimeAssembly;
		public virtual RMethod RGetRuntimeAssembly
		{
			get
			{
				if(r_RGetRuntimeAssembly == null)
				{
					r_RGetRuntimeAssembly = new(this, "GetRuntimeAssembly", 0);
					r_RGetRuntimeAssembly.SetBelong(this.instance);
				}
				return r_RGetRuntimeAssembly;
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
		/// System.Exception resolve_token_exception(System.String, Int32, System.Reflection.ResolveTokenError, System.String)
		/// </summary>
		protected static RMethod r_Rresolve_token_exception_String_Int32_ResolveTokenError_String;
		public static RMethod Rresolve_token_exception_String_Int32_ResolveTokenError_String
		{
			get
			{
				if(r_Rresolve_token_exception_String_Int32_ResolveTokenError_String == null)
				{
					r_Rresolve_token_exception_String_Int32_ResolveTokenError_String = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "resolve_token_exception", 0, typeof(System.String), typeof(System.Int32),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError"), typeof(System.String));
					r_Rresolve_token_exception_String_Int32_ResolveTokenError_String.SetBelong(null);
				}
				return r_Rresolve_token_exception_String_Int32_ResolveTokenError_String;
			}
		}

		/// <summary>
		/// IntPtr[] ptrs_from_types(System.Type[])
		/// </summary>
		protected static RMethod r_Rptrs_from_types_TypeArray;
		public static RMethod Rptrs_from_types_TypeArray
		{
			get
			{
				if(r_Rptrs_from_types_TypeArray == null)
				{
					r_Rptrs_from_types_TypeArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ptrs_from_types", 0, typeof(System.Type).MakeArrayType());
					r_Rptrs_from_types_TypeArray.SetBelong(null);
				}
				return r_Rptrs_from_types_TypeArray;
			}
		}

		/// <summary>
		/// Int32 get_MetadataToken(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_Rget_MetadataToken_Module;
		public static RMethod Rget_MetadataToken_Module
		{
			get
			{
				if(r_Rget_MetadataToken_Module == null)
				{
					r_Rget_MetadataToken_Module = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "get_MetadataToken", 0, typeof(System.Reflection.Module));
					r_Rget_MetadataToken_Module.SetBelong(null);
				}
				return r_Rget_MetadataToken_Module;
			}
		}

		/// <summary>
		/// Int32 GetMDStreamVersion(IntPtr)
		/// </summary>
		protected static RMethod r_RGetMDStreamVersion_IntPtr;
		public static RMethod RGetMDStreamVersion_IntPtr
		{
			get
			{
				if(r_RGetMDStreamVersion_IntPtr == null)
				{
					r_RGetMDStreamVersion_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "GetMDStreamVersion", 0, typeof(System.IntPtr));
					r_RGetMDStreamVersion_IntPtr.SetBelong(null);
				}
				return r_RGetMDStreamVersion_IntPtr;
			}
		}

		/// <summary>
		/// System.Type[] InternalGetTypes(IntPtr)
		/// </summary>
		protected static RMethod r_RInternalGetTypes_IntPtr;
		public static RMethod RInternalGetTypes_IntPtr
		{
			get
			{
				if(r_RInternalGetTypes_IntPtr == null)
				{
					r_RInternalGetTypes_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "InternalGetTypes", 0, typeof(System.IntPtr));
					r_RInternalGetTypes_IntPtr.SetBelong(null);
				}
				return r_RInternalGetTypes_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetHINSTANCE(IntPtr)
		/// </summary>
		protected static RMethod r_RGetHINSTANCE_IntPtr;
		public static RMethod RGetHINSTANCE_IntPtr
		{
			get
			{
				if(r_RGetHINSTANCE_IntPtr == null)
				{
					r_RGetHINSTANCE_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "GetHINSTANCE", 0, typeof(System.IntPtr));
					r_RGetHINSTANCE_IntPtr.SetBelong(null);
				}
				return r_RGetHINSTANCE_IntPtr;
			}
		}

		/// <summary>
		/// Void GetGuidInternal(IntPtr, Byte[])
		/// </summary>
		protected static RMethod r_RGetGuidInternal_IntPtr_ByteArray;
		public static RMethod RGetGuidInternal_IntPtr_ByteArray
		{
			get
			{
				if(r_RGetGuidInternal_IntPtr_ByteArray == null)
				{
					r_RGetGuidInternal_IntPtr_ByteArray = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "GetGuidInternal", 0, typeof(System.IntPtr), typeof(System.Byte).MakeArrayType());
					r_RGetGuidInternal_IntPtr_ByteArray.SetBelong(null);
				}
				return r_RGetGuidInternal_IntPtr_ByteArray;
			}
		}

		/// <summary>
		/// System.Type GetGlobalType(IntPtr)
		/// </summary>
		protected static RMethod r_RGetGlobalType_IntPtr;
		public static RMethod RGetGlobalType_IntPtr
		{
			get
			{
				if(r_RGetGlobalType_IntPtr == null)
				{
					r_RGetGlobalType_IntPtr = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "GetGlobalType", 0, typeof(System.IntPtr));
					r_RGetGlobalType_IntPtr.SetBelong(null);
				}
				return r_RGetGlobalType_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr ResolveTypeToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_RResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_RResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_RResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveTypeToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_RResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_RResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// IntPtr ResolveMethodToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_RResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_RResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_RResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMethodToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_RResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_RResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// IntPtr ResolveFieldToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_RResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_RResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_RResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveFieldToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_RResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_RResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// System.String ResolveStringToken(IntPtr, Int32, System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_RResolveStringToken_IntPtr_Int32_Out_ResolveTokenError;
		public static RMethod RResolveStringToken_IntPtr_Int32_Out_ResolveTokenError
		{
			get
			{
				if(r_RResolveStringToken_IntPtr_Int32_Out_ResolveTokenError == null)
				{
					r_RResolveStringToken_IntPtr_Int32_Out_ResolveTokenError = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveStringToken", 0, typeof(System.IntPtr), typeof(System.Int32),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_RResolveStringToken_IntPtr_Int32_Out_ResolveTokenError.SetBelong(null);
				}
				return r_RResolveStringToken_IntPtr_Int32_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMemberToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_RResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_RResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_RResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMemberToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_RResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_RResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// Byte[] ResolveSignature(IntPtr, Int32, System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_RResolveSignature_IntPtr_Int32_Out_ResolveTokenError;
		public static RMethod RResolveSignature_IntPtr_Int32_Out_ResolveTokenError
		{
			get
			{
				if(r_RResolveSignature_IntPtr_Int32_Out_ResolveTokenError == null)
				{
					r_RResolveSignature_IntPtr_Int32_Out_ResolveTokenError = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveSignature", 0, typeof(System.IntPtr), typeof(System.Int32),  ReleactionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_RResolveSignature_IntPtr_Int32_Out_ResolveTokenError.SetBelong(null);
				}
				return r_RResolveSignature_IntPtr_Int32_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// Void GetPEKind(IntPtr, System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected static RMethod r_RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public static RMethod RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine = new( ReleactionUtils.GetType("System.Reflection.RuntimeModule"), "GetPEKind", 0, typeof(System.IntPtr), typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(null);
				}
				return r_RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine;
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


        public RRuntimeModule() : base("System.Reflection.RuntimeModule")
        {
        }

        public RRuntimeModule(System.Object instance) : base("System.Reflection.RuntimeModule")
		{
            SetInstance(instance);
		}

        public RRuntimeModule(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeModule(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter  @filter, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RFindTypes_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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


        public virtual System.Reflection.FieldInfo GetField(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags  @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags  @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
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


        public virtual System.Type GetType(System.String  @className, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public static System.Reflection.FieldInfo ResolveField(System.Reflection.Module  @module, System.IntPtr  @monoModule, System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveField_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public static System.Reflection.MemberInfo ResolveMember(System.Reflection.Module  @module, System.IntPtr  @monoModule, System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBase ResolveMethod(System.Reflection.Module  @module, System.IntPtr  @monoModule, System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.String ResolveString(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String ResolveString(System.Reflection.Module  @module, System.IntPtr  @monoModule, System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken};
            var ___result = RResolveString_Module_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type ResolveType(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type ResolveType(System.Reflection.Module  @module, System.IntPtr  @monoModule, System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveType_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Byte[] ResolveSignature(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] ResolveSignature(System.Reflection.Module  @module, System.IntPtr  @monoModule, System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken};
            var ___result = RResolveSignature_Module_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSignerCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Object GetRuntimeAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRuntimeAssembly.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Guid GetModuleVersionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModuleVersionId.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }



        public static System.IntPtr[] ptrs_from_types(System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = Rptrs_from_types_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr[])___result;
        }


        public static System.Int32 get_MetadataToken(System.Reflection.Module  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = Rget_MetadataToken_Module.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetMDStreamVersion(System.IntPtr  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RGetMDStreamVersion_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Type[] InternalGetTypes(System.IntPtr  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RInternalGetTypes_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.IntPtr GetHINSTANCE(System.IntPtr  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RGetHINSTANCE_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void GetGuidInternal(System.IntPtr  @module, System.Byte[]  @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @guid};
            var ___result = RGetGuidInternal_IntPtr_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Type GetGlobalType(System.IntPtr  @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RGetGlobalType_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }








        public static void GetPEKind(System.IntPtr  @module, out System.Reflection.PortableExecutableKinds  @peKind, out System.Reflection.ImageFileMachine  @machine)
        {
			peKind = default;
			machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @peKind, @machine};
            var ___result = RGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			peKind = (System.Reflection.PortableExecutableKinds)___parameters[1];
			machine = (System.Reflection.ImageFileMachine)___parameters[2];

            
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


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFields.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
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


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveField_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveMember_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Type ResolveType(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
