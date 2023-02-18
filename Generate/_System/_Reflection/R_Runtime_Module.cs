
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeModule
	/// </summary>
    public partial class RRuntimeModule : RMember //
    {

		/// <summary>
		/// System.IntPtr _impl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_F_impl;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RF_impl
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
		/// System.Reflection.Assembly assembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly r_Fassembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly RFassembly
		{
			get
			{
				if(r_Fassembly == null)
				{
					r_Fassembly = new(this, "assembly");
					r_Fassembly.SetBelong(this.GetValue());
				}
				return r_Fassembly;
			}
		}

		/// <summary>
		/// System.String fqname
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ffqname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFfqname
		{
			get
			{
				if(r_Ffqname == null)
				{
					r_Ffqname = new(this, "fqname");
					r_Ffqname.SetBelong(this.GetValue());
				}
				return r_Ffqname;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.GetValue());
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.String scopename
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fscopename;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFscopename
		{
			get
			{
				if(r_Fscopename == null)
				{
					r_Fscopename = new(this, "scopename");
					r_Fscopename.SetBelong(this.GetValue());
				}
				return r_Fscopename;
			}
		}

		/// <summary>
		/// System.Boolean is_resource
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fis_resource;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFis_resource
		{
			get
			{
				if(r_Fis_resource == null)
				{
					r_Fis_resource = new(this, "is_resource");
					r_Fis_resource.SetBelong(this.GetValue());
				}
				return r_Fis_resource;
			}
		}

		/// <summary>
		/// System.Int32 token
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftoken;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtoken
		{
			get
			{
				if(r_Ftoken == null)
				{
					r_Ftoken = new(this, "token");
					r_Ftoken.SetBelong(this.GetValue());
				}
				return r_Ftoken;
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
		/// System.String ScopeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PScopeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPScopeName
		{
			get
			{
				if(r_PScopeName == null)
				{
					r_PScopeName = new(this, "ScopeName", -1);
					r_PScopeName.SetBelong(this.GetValue());
				}
				return r_PScopeName;
			}
		}

		/// <summary>
		/// Int32 MDStreamVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMDStreamVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMDStreamVersion
		{
			get
			{
				if(r_PMDStreamVersion == null)
				{
					r_PMDStreamVersion = new(this, "MDStreamVersion", -1);
					r_PMDStreamVersion.SetBelong(this.GetValue());
				}
				return r_PMDStreamVersion;
			}
		}

		/// <summary>
		/// System.Guid ModuleVersionId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PModuleVersionId;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPModuleVersionId
		{
			get
			{
				if(r_PModuleVersionId == null)
				{
					r_PModuleVersionId = new(this, "ModuleVersionId", -1);
					r_PModuleVersionId.SetBelong(this.GetValue());
				}
				return r_PModuleVersionId;
			}
		}

		/// <summary>
		/// System.String FullyQualifiedName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullyQualifiedName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullyQualifiedName
		{
			get
			{
				if(r_PFullyQualifiedName == null)
				{
					r_PFullyQualifiedName = new(this, "FullyQualifiedName", -1);
					r_PFullyQualifiedName.SetBelong(this.GetValue());
				}
				return r_PFullyQualifiedName;
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
		/// IntPtr MonoModule
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PMonoModule;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPMonoModule
		{
			get
			{
				if(r_PMonoModule == null)
				{
					r_PMonoModule = new(this, "MonoModule", -1);
					r_PMonoModule.SetBelong(this.GetValue());
				}
				return r_PMonoModule;
			}
		}

		/// <summary>
		/// System.ModuleHandle ModuleHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RModuleHandle r_PModuleHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RModuleHandle RPModuleHandle
		{
			get
			{
				if(r_PModuleHandle == null)
				{
					r_PModuleHandle = new(this, "ModuleHandle", -1);
					r_PModuleHandle.SetBelong(this.GetValue());
				}
				return r_PModuleHandle;
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
		/// System.Guid MvId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PMvId;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPMvId
		{
			get
			{
				if(r_PMvId == null)
				{
					r_PMvId = new(this, "MvId", -1);
					r_PMvId.SetBelong(this.GetValue());
				}
				return r_PMvId;
			}
		}

		/// <summary>
		/// Boolean IsResource()
		/// </summary>
		protected RMethod r_MIsResource;
		public virtual RMethod RMIsResource
		{
			get
			{
				if(r_MIsResource == null)
				{
					r_MIsResource = new(this, "IsResource", 0);
					r_MIsResource.SetBelong(this.GetValue());
				}
				return r_MIsResource;
			}
		}

		/// <summary>
		/// System.Type[] FindTypes(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_MFindTypes_TypeFilter_Object;
		public virtual RMethod RMFindTypes_TypeFilter_Object
		{
			get
			{
				if(r_MFindTypes_TypeFilter_Object == null)
				{
					r_MFindTypes_TypeFilter_Object = new(this, "FindTypes", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_MFindTypes_TypeFilter_Object.SetBelong(this.GetValue());
				}
				return r_MFindTypes_TypeFilter_Object;
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
		/// System.ModuleHandle GetModuleHandleImpl()
		/// </summary>
		protected RMethod r_MGetModuleHandleImpl;
		public virtual RMethod RMGetModuleHandleImpl
		{
			get
			{
				if(r_MGetModuleHandleImpl == null)
				{
					r_MGetModuleHandleImpl = new(this, "GetModuleHandleImpl", 0);
					r_MGetModuleHandleImpl.SetBelong(this.GetValue());
				}
				return r_MGetModuleHandleImpl;
			}
		}

		/// <summary>
		/// Void GetPEKind(System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected RMethod r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public virtual RMethod RMGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine = new(this, "GetPEKind", 0, typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(this.GetValue());
				}
				return r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MGetType_String_Boolean_Boolean;
		public virtual RMethod RMGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_MGetType_String_Boolean_Boolean == null)
				{
					r_MGetType_String_Boolean_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_MGetType_String_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetType_String_Boolean_Boolean;
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
		/// System.Reflection.FieldInfo ResolveField(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MResolveField_Int32_TypeArray_TypeArray;
		public virtual RMethod RMResolveField_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveField_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveField_Int32_TypeArray_TypeArray = new(this, "ResolveField", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveField_Int32_TypeArray_TypeArray.SetBelong(this.GetValue());
				}
				return r_MResolveField_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo ResolveField(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_MResolveField_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RMResolveField_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveField_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveField_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveField", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveField_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_MResolveField_Module_IntPtr_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MResolveMember_Int32_TypeArray_TypeArray;
		public virtual RMethod RMResolveMember_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveMember_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveMember_Int32_TypeArray_TypeArray = new(this, "ResolveMember", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveMember_Int32_TypeArray_TypeArray.SetBelong(this.GetValue());
				}
				return r_MResolveMember_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_MResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RMResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMember", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_MResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MResolveMethod_Int32_TypeArray_TypeArray;
		public virtual RMethod RMResolveMethod_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveMethod_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveMethod_Int32_TypeArray_TypeArray = new(this, "ResolveMethod", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveMethod_Int32_TypeArray_TypeArray.SetBelong(this.GetValue());
				}
				return r_MResolveMethod_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_MResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RMResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMethod", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_MResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.String ResolveString(Int32)
		/// </summary>
		protected RMethod r_MResolveString_Int32;
		public virtual RMethod RMResolveString_Int32
		{
			get
			{
				if(r_MResolveString_Int32 == null)
				{
					r_MResolveString_Int32 = new(this, "ResolveString", 0, typeof(System.Int32));
					r_MResolveString_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveString_Int32;
			}
		}

		/// <summary>
		/// System.String ResolveString(System.Reflection.Module, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MResolveString_Module_IntPtr_Int32;
		public static RMethod RMResolveString_Module_IntPtr_Int32
		{
			get
			{
				if(r_MResolveString_Module_IntPtr_Int32 == null)
				{
					r_MResolveString_Module_IntPtr_Int32 = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveString", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32));
					r_MResolveString_Module_IntPtr_Int32.SetBelong(null);
				}
				return r_MResolveString_Module_IntPtr_Int32;
			}
		}

		/// <summary>
		/// System.Type ResolveType(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MResolveType_Int32_TypeArray_TypeArray;
		public virtual RMethod RMResolveType_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveType_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveType_Int32_TypeArray_TypeArray = new(this, "ResolveType", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveType_Int32_TypeArray_TypeArray.SetBelong(this.GetValue());
				}
				return r_MResolveType_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Type ResolveType(System.Reflection.Module, IntPtr, Int32, System.Type[], System.Type[])
		/// </summary>
		protected static RMethod r_MResolveType_Module_IntPtr_Int32_TypeArray_TypeArray;
		public static RMethod RMResolveType_Module_IntPtr_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveType_Module_IntPtr_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveType_Module_IntPtr_Int32_TypeArray_TypeArray = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveType", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveType_Module_IntPtr_Int32_TypeArray_TypeArray.SetBelong(null);
				}
				return r_MResolveType_Module_IntPtr_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// Byte[] ResolveSignature(Int32)
		/// </summary>
		protected RMethod r_MResolveSignature_Int32;
		public virtual RMethod RMResolveSignature_Int32
		{
			get
			{
				if(r_MResolveSignature_Int32 == null)
				{
					r_MResolveSignature_Int32 = new(this, "ResolveSignature", 0, typeof(System.Int32));
					r_MResolveSignature_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveSignature_Int32;
			}
		}

		/// <summary>
		/// Byte[] ResolveSignature(System.Reflection.Module, IntPtr, Int32)
		/// </summary>
		protected static RMethod r_MResolveSignature_Module_IntPtr_Int32;
		public static RMethod RMResolveSignature_Module_IntPtr_Int32
		{
			get
			{
				if(r_MResolveSignature_Module_IntPtr_Int32 == null)
				{
					r_MResolveSignature_Module_IntPtr_Int32 = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveSignature", 0, typeof(System.Reflection.Module), typeof(System.IntPtr), typeof(System.Int32));
					r_MResolveSignature_Module_IntPtr_Int32.SetBelong(null);
				}
				return r_MResolveSignature_Module_IntPtr_Int32;
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
		/// System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
		/// </summary>
		protected RMethod r_MGetSignerCertificate;
		public virtual RMethod RMGetSignerCertificate
		{
			get
			{
				if(r_MGetSignerCertificate == null)
				{
					r_MGetSignerCertificate = new(this, "GetSignerCertificate", 0);
					r_MGetSignerCertificate.SetBelong(this.GetValue());
				}
				return r_MGetSignerCertificate;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes()
		/// </summary>
		protected RMethod r_MGetTypes;
		public virtual RMethod RMGetTypes
		{
			get
			{
				if(r_MGetTypes == null)
				{
					r_MGetTypes = new(this, "GetTypes", 0);
					r_MGetTypes.SetBelong(this.GetValue());
				}
				return r_MGetTypes;
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
		/// System.Guid GetModuleVersionId()
		/// </summary>
		protected RMethod r_MGetModuleVersionId;
		public virtual RMethod RMGetModuleVersionId
		{
			get
			{
				if(r_MGetModuleVersionId == null)
				{
					r_MGetModuleVersionId = new(this, "GetModuleVersionId", 0);
					r_MGetModuleVersionId.SetBelong(this.GetValue());
				}
				return r_MGetModuleVersionId;
			}
		}

		/// <summary>
		/// System.Exception resolve_token_exception(System.String, Int32, System.Reflection.ResolveTokenError, System.String)
		/// </summary>
		protected static RMethod r_Mresolve_token_exception_String_Int32_ResolveTokenError_String;
		public static RMethod RMresolve_token_exception_String_Int32_ResolveTokenError_String
		{
			get
			{
				if(r_Mresolve_token_exception_String_Int32_ResolveTokenError_String == null)
				{
					r_Mresolve_token_exception_String_Int32_ResolveTokenError_String = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "resolve_token_exception", 0, typeof(System.String), typeof(System.Int32),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError"), typeof(System.String));
					r_Mresolve_token_exception_String_Int32_ResolveTokenError_String.SetBelong(null);
				}
				return r_Mresolve_token_exception_String_Int32_ResolveTokenError_String;
			}
		}

		/// <summary>
		/// IntPtr[] ptrs_from_types(System.Type[])
		/// </summary>
		protected static RMethod r_Mptrs_from_types_TypeArray;
		public static RMethod RMptrs_from_types_TypeArray
		{
			get
			{
				if(r_Mptrs_from_types_TypeArray == null)
				{
					r_Mptrs_from_types_TypeArray = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ptrs_from_types", 0, typeof(System.Type).MakeArrayType());
					r_Mptrs_from_types_TypeArray.SetBelong(null);
				}
				return r_Mptrs_from_types_TypeArray;
			}
		}

		/// <summary>
		/// Int32 get_MetadataToken(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_Mget_MetadataToken_Module;
		public static RMethod RMget_MetadataToken_Module
		{
			get
			{
				if(r_Mget_MetadataToken_Module == null)
				{
					r_Mget_MetadataToken_Module = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "get_MetadataToken", 0, typeof(System.Reflection.Module));
					r_Mget_MetadataToken_Module.SetBelong(null);
				}
				return r_Mget_MetadataToken_Module;
			}
		}

		/// <summary>
		/// Int32 GetMDStreamVersion(IntPtr)
		/// </summary>
		protected static RMethod r_MGetMDStreamVersion_IntPtr;
		public static RMethod RMGetMDStreamVersion_IntPtr
		{
			get
			{
				if(r_MGetMDStreamVersion_IntPtr == null)
				{
					r_MGetMDStreamVersion_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "GetMDStreamVersion", 0, typeof(System.IntPtr));
					r_MGetMDStreamVersion_IntPtr.SetBelong(null);
				}
				return r_MGetMDStreamVersion_IntPtr;
			}
		}

		/// <summary>
		/// System.Type[] InternalGetTypes(IntPtr)
		/// </summary>
		protected static RMethod r_MInternalGetTypes_IntPtr;
		public static RMethod RMInternalGetTypes_IntPtr
		{
			get
			{
				if(r_MInternalGetTypes_IntPtr == null)
				{
					r_MInternalGetTypes_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "InternalGetTypes", 0, typeof(System.IntPtr));
					r_MInternalGetTypes_IntPtr.SetBelong(null);
				}
				return r_MInternalGetTypes_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr GetHINSTANCE(IntPtr)
		/// </summary>
		protected static RMethod r_MGetHINSTANCE_IntPtr;
		public static RMethod RMGetHINSTANCE_IntPtr
		{
			get
			{
				if(r_MGetHINSTANCE_IntPtr == null)
				{
					r_MGetHINSTANCE_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "GetHINSTANCE", 0, typeof(System.IntPtr));
					r_MGetHINSTANCE_IntPtr.SetBelong(null);
				}
				return r_MGetHINSTANCE_IntPtr;
			}
		}

		/// <summary>
		/// Void GetGuidInternal(IntPtr, Byte[])
		/// </summary>
		protected static RMethod r_MGetGuidInternal_IntPtr_ByteArray;
		public static RMethod RMGetGuidInternal_IntPtr_ByteArray
		{
			get
			{
				if(r_MGetGuidInternal_IntPtr_ByteArray == null)
				{
					r_MGetGuidInternal_IntPtr_ByteArray = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "GetGuidInternal", 0, typeof(System.IntPtr), typeof(System.Byte).MakeArrayType());
					r_MGetGuidInternal_IntPtr_ByteArray.SetBelong(null);
				}
				return r_MGetGuidInternal_IntPtr_ByteArray;
			}
		}

		/// <summary>
		/// System.Type GetGlobalType(IntPtr)
		/// </summary>
		protected static RMethod r_MGetGlobalType_IntPtr;
		public static RMethod RMGetGlobalType_IntPtr
		{
			get
			{
				if(r_MGetGlobalType_IntPtr == null)
				{
					r_MGetGlobalType_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "GetGlobalType", 0, typeof(System.IntPtr));
					r_MGetGlobalType_IntPtr.SetBelong(null);
				}
				return r_MGetGlobalType_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr ResolveTypeToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_MResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RMResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_MResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_MResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveTypeToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_MResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_MResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// IntPtr ResolveMethodToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_MResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RMResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_MResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_MResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMethodToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_MResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_MResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// IntPtr ResolveFieldToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_MResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RMResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_MResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_MResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveFieldToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_MResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_MResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// System.String ResolveStringToken(IntPtr, Int32, System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_MResolveStringToken_IntPtr_Int32_Out_ResolveTokenError;
		public static RMethod RMResolveStringToken_IntPtr_Int32_Out_ResolveTokenError
		{
			get
			{
				if(r_MResolveStringToken_IntPtr_Int32_Out_ResolveTokenError == null)
				{
					r_MResolveStringToken_IntPtr_Int32_Out_ResolveTokenError = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveStringToken", 0, typeof(System.IntPtr), typeof(System.Int32),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_MResolveStringToken_IntPtr_Int32_Out_ResolveTokenError.SetBelong(null);
				}
				return r_MResolveStringToken_IntPtr_Int32_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMemberToken(IntPtr, Int32, IntPtr[], IntPtr[], System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_MResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
		public static RMethod RMResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError
		{
			get
			{
				if(r_MResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError == null)
				{
					r_MResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveMemberToken", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeArrayType(), typeof(System.IntPtr).MakeArrayType(),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_MResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.SetBelong(null);
				}
				return r_MResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// Byte[] ResolveSignature(IntPtr, Int32, System.Reflection.ResolveTokenError ByRef)
		/// </summary>
		protected static RMethod r_MResolveSignature_IntPtr_Int32_Out_ResolveTokenError;
		public static RMethod RMResolveSignature_IntPtr_Int32_Out_ResolveTokenError
		{
			get
			{
				if(r_MResolveSignature_IntPtr_Int32_Out_ResolveTokenError == null)
				{
					r_MResolveSignature_IntPtr_Int32_Out_ResolveTokenError = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "ResolveSignature", 0, typeof(System.IntPtr), typeof(System.Int32),  ReflectionUtils.GetType("System.Reflection.ResolveTokenError").MakeByRefType());
					r_MResolveSignature_IntPtr_Int32_Out_ResolveTokenError.SetBelong(null);
				}
				return r_MResolveSignature_IntPtr_Int32_Out_ResolveTokenError;
			}
		}

		/// <summary>
		/// Void GetPEKind(IntPtr, System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected static RMethod r_MGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public static RMethod RMGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_MGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_MGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine = new( ReflectionUtils.GetType("System.Reflection.RuntimeModule"), "GetPEKind", 0, typeof(System.IntPtr), typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_MGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(null);
				}
				return r_MGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine;
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
		/// System.Type GetType(System.String)
		/// </summary>
		protected RMethod r_MGetType_String;
		public virtual RMethod RMGetType_String
		{
			get
			{
				if(r_MGetType_String == null)
				{
					r_MGetType_String = new(this, "GetType", 0, typeof(System.String));
					r_MGetType_String.SetBelong(this.GetValue());
				}
				return r_MGetType_String;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetType_String_Boolean;
		public virtual RMethod RMGetType_String_Boolean
		{
			get
			{
				if(r_MGetType_String_Boolean == null)
				{
					r_MGetType_String_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean));
					r_MGetType_String_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo ResolveField(Int32)
		/// </summary>
		protected RMethod r_MResolveField_Int32;
		public virtual RMethod RMResolveField_Int32
		{
			get
			{
				if(r_MResolveField_Int32 == null)
				{
					r_MResolveField_Int32 = new(this, "ResolveField", 0, typeof(System.Int32));
					r_MResolveField_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveField_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(Int32)
		/// </summary>
		protected RMethod r_MResolveMember_Int32;
		public virtual RMethod RMResolveMember_Int32
		{
			get
			{
				if(r_MResolveMember_Int32 == null)
				{
					r_MResolveMember_Int32 = new(this, "ResolveMember", 0, typeof(System.Int32));
					r_MResolveMember_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveMember_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(Int32)
		/// </summary>
		protected RMethod r_MResolveMethod_Int32;
		public virtual RMethod RMResolveMethod_Int32
		{
			get
			{
				if(r_MResolveMethod_Int32 == null)
				{
					r_MResolveMethod_Int32 = new(this, "ResolveMethod", 0, typeof(System.Int32));
					r_MResolveMethod_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveMethod_Int32;
			}
		}

		/// <summary>
		/// System.Type ResolveType(Int32)
		/// </summary>
		protected RMethod r_MResolveType_Int32;
		public virtual RMethod RMResolveType_Int32
		{
			get
			{
				if(r_MResolveType_Int32 == null)
				{
					r_MResolveType_Int32 = new(this, "ResolveType", 0, typeof(System.Int32));
					r_MResolveType_Int32.SetBelong(this.GetValue());
				}
				return r_MResolveType_Int32;
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
            var ___result = RMIsResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RMFindTypes_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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


        public virtual System.Reflection.FieldInfo GetField(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RMGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RMGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.ModuleHandle GetModuleHandleImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModuleHandleImpl.Invoke(___genericsType, ___parameters);

            return (System.ModuleHandle)___result;
        }


        public virtual void GetPEKind(out System.Reflection.PortableExecutableKinds @peKind, out System.Reflection.ImageFileMachine @machine)
        {
			@peKind = default;
			@machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@peKind, @machine};
            var ___result = RMGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			@peKind = (System.Reflection.PortableExecutableKinds)___parameters[0];
			@machine = (System.Reflection.ImageFileMachine)___parameters[1];

            
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public static System.Reflection.FieldInfo ResolveField(System.Reflection.Module @module, System.IntPtr @monoModule, System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveField_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public static System.Reflection.MemberInfo ResolveMember(System.Reflection.Module @module, System.IntPtr @monoModule, System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMember_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBase ResolveMethod(System.Reflection.Module @module, System.IntPtr @monoModule, System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMethod_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.String ResolveString(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String ResolveString(System.Reflection.Module @module, System.IntPtr @monoModule, System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken};
            var ___result = RMResolveString_Module_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type ResolveType(System.Reflection.Module @module, System.IntPtr @monoModule, System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveType_Module_IntPtr_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Byte[] ResolveSignature(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public static System.Byte[] ResolveSignature(System.Reflection.Module @module, System.IntPtr @monoModule, System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @monoModule, @metadataToken};
            var ___result = RMResolveSignature_Module_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSignerCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly GetRuntimeAssembly()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRuntimeAssembly.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeAssembly(___result);
        }


        public virtual System.Guid GetModuleVersionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModuleVersionId.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public static System.Exception resolve_token_exception(System.String @name, System.Int32 @metadataToken, Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error, System.String @tokenType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @metadataToken, @error.Value, @tokenType};
            var ___result = RMresolve_token_exception_String_Int32_ResolveTokenError_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public static System.IntPtr[] ptrs_from_types(System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RMptrs_from_types_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.IntPtr[])___result;
        }


        public static System.Int32 get_MetadataToken(System.Reflection.Module @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMget_MetadataToken_Module.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetMDStreamVersion(System.IntPtr @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMGetMDStreamVersion_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Type[] InternalGetTypes(System.IntPtr @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMInternalGetTypes_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.IntPtr GetHINSTANCE(System.IntPtr @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMGetHINSTANCE_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void GetGuidInternal(System.IntPtr @module, System.Byte[] @guid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @guid};
            var ___result = RMGetGuidInternal_IntPtr_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Type GetGlobalType(System.IntPtr @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMGetGlobalType_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.IntPtr ResolveTypeToken(System.IntPtr @module, System.Int32 @token, System.IntPtr[] @type_args, System.IntPtr[] @method_args, out Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error)
        {
			@error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @token, @type_args, @method_args, @error.Value};
            var ___result = RMResolveTypeToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.Invoke(___genericsType, ___parameters);
			@error = new Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError(___parameters[4]);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr ResolveMethodToken(System.IntPtr @module, System.Int32 @token, System.IntPtr[] @type_args, System.IntPtr[] @method_args, out Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error)
        {
			@error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @token, @type_args, @method_args, @error.Value};
            var ___result = RMResolveMethodToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.Invoke(___genericsType, ___parameters);
			@error = new Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError(___parameters[4]);

            return (System.IntPtr)___result;
        }


        public static System.IntPtr ResolveFieldToken(System.IntPtr @module, System.Int32 @token, System.IntPtr[] @type_args, System.IntPtr[] @method_args, out Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error)
        {
			@error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @token, @type_args, @method_args, @error.Value};
            var ___result = RMResolveFieldToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.Invoke(___genericsType, ___parameters);
			@error = new Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError(___parameters[4]);

            return (System.IntPtr)___result;
        }


        public static System.String ResolveStringToken(System.IntPtr @module, System.Int32 @token, out Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error)
        {
			@error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @token, @error.Value};
            var ___result = RMResolveStringToken_IntPtr_Int32_Out_ResolveTokenError.Invoke(___genericsType, ___parameters);
			@error = new Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError(___parameters[2]);

            return (System.String)___result;
        }


        public static System.Reflection.MemberInfo ResolveMemberToken(System.IntPtr @module, System.Int32 @token, System.IntPtr[] @type_args, System.IntPtr[] @method_args, out Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error)
        {
			@error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @token, @type_args, @method_args, @error.Value};
            var ___result = RMResolveMemberToken_IntPtr_Int32_IntPtrArray_IntPtrArray_Out_ResolveTokenError.Invoke(___genericsType, ___parameters);
			@error = new Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError(___parameters[4]);

            return (System.Reflection.MemberInfo)___result;
        }


        public static System.Byte[] ResolveSignature(System.IntPtr @module, System.Int32 @metadataToken, out Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError @error)
        {
			@error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @metadataToken, @error.Value};
            var ___result = RMResolveSignature_IntPtr_Int32_Out_ResolveTokenError.Invoke(___genericsType, ___parameters);
			@error = new Hvak.Editor.Refleaction.RSystem.RReflection.RResolveTokenError(___parameters[2]);

            return (System.Byte[])___result;
        }


        public static void GetPEKind(System.IntPtr @module, out System.Reflection.PortableExecutableKinds @peKind, out System.Reflection.ImageFileMachine @machine)
        {
			@peKind = default;
			@machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module, @peKind, @machine};
            var ___result = RMGetPEKind_IntPtr_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			@peKind = (System.Reflection.PortableExecutableKinds)___parameters[1];
			@machine = (System.Reflection.ImageFileMachine)___parameters[2];

            
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RMGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
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


        public virtual System.Type GetType(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @ignoreCase};
            var ___result = RMGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveField_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveMember_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
