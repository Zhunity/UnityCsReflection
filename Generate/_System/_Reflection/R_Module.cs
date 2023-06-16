
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.Module
	/// </summary>
    public partial class RModule : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Module);
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


		/// <summary>
		/// System.Reflection.TypeFilter FilterTypeName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeFilter r_FFilterTypeName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeFilter RFFilterTypeName
		{
			get
			{
				if(r_FFilterTypeName == null)
				{
					r_FFilterTypeName = new(Type, "FilterTypeName");
				}
				return r_FFilterTypeName;
			}
		}

		/// <summary>
		/// System.Reflection.TypeFilter FilterTypeNameIgnoreCase
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeFilter r_FFilterTypeNameIgnoreCase;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeFilter RFFilterTypeNameIgnoreCase
		{
			get
			{
				if(r_FFilterTypeNameIgnoreCase == null)
				{
					r_FFilterTypeNameIgnoreCase = new(Type, "FilterTypeNameIgnoreCase");
				}
				return r_FFilterTypeNameIgnoreCase;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DefaultLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FDefaultLookup;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFDefaultLookup
		{
			get
			{
				if(r_FDefaultLookup == null)
				{
					r_FDefaultLookup = new(Type, "DefaultLookup");
				}
				return r_FDefaultLookup;
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
				}
				return r_PAssembly;
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
				}
				return r_PFullyQualifiedName;
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
				}
				return r_PName;
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
				}
				return r_PModuleVersionId;
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
				}
				return r_PScopeName;
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
				}
				return r_PCustomAttributes;
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
				}
				return r_PMetadataToken;
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
				}
				return r_PMvId;
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
				}
				return r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
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
				}
				return r_MIsResource;
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
				}
				return r_MIsDefined_Type_Boolean;
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
				}
				return r_MGetCustomAttributesData;
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
				}
				return r_MGetCustomAttributes_Type_Boolean;
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
				}
				return r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
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
				}
				return r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
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
				}
				return r_MGetMethods;
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
				}
				return r_MGetMethods_BindingFlags;
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
				}
				return r_MGetField_String;
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
				}
				return r_MGetField_String_BindingFlags;
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
				}
				return r_MGetFields;
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
				}
				return r_MGetFields_BindingFlags;
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
				}
				return r_MGetTypes;
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
				}
				return r_MGetType_String_Boolean;
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
				}
				return r_MGetType_String_Boolean_Boolean;
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
				}
				return r_MFindTypes_TypeFilter_Object;
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
				}
				return r_MResolveField_Int32;
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
				}
				return r_MResolveField_Int32_TypeArray_TypeArray;
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
				}
				return r_MResolveMember_Int32;
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
				}
				return r_MResolveMember_Int32_TypeArray_TypeArray;
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
				}
				return r_MResolveMethod_Int32;
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
				}
				return r_MResolveMethod_Int32_TypeArray_TypeArray;
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
				}
				return r_MResolveSignature_Int32;
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
				}
				return r_MResolveString_Int32;
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
				}
				return r_MResolveType_Int32;
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
				}
				return r_MResolveType_Int32_TypeArray_TypeArray;
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
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
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
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Module, System.Reflection.Module)
		/// </summary>
		protected static RMethod r_Mop_Equality_Module_Module;
		public static RMethod RMop_Equality_Module_Module
		{
			get
			{
				if(r_Mop_Equality_Module_Module == null)
				{
					r_Mop_Equality_Module_Module = new(Type, "op_Equality", 0, typeof(System.Reflection.Module), typeof(System.Reflection.Module));
				}
				return r_Mop_Equality_Module_Module;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Module, System.Reflection.Module)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Module_Module;
		public static RMethod RMop_Inequality_Module_Module
		{
			get
			{
				if(r_Mop_Inequality_Module_Module == null)
				{
					r_Mop_Inequality_Module_Module = new(Type, "op_Inequality", 0, typeof(System.Reflection.Module), typeof(System.Reflection.Module));
				}
				return r_Mop_Inequality_Module_Module;
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
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Boolean FilterTypeNameImpl(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_MFilterTypeNameImpl_Type_Object;
		public static RMethod RMFilterTypeNameImpl_Type_Object
		{
			get
			{
				if(r_MFilterTypeNameImpl_Type_Object == null)
				{
					r_MFilterTypeNameImpl_Type_Object = new(Type, "FilterTypeNameImpl", 0, typeof(System.Type), typeof(System.Object));
				}
				return r_MFilterTypeNameImpl_Type_Object;
			}
		}

		/// <summary>
		/// Boolean FilterTypeNameIgnoreCaseImpl(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_MFilterTypeNameIgnoreCaseImpl_Type_Object;
		public static RMethod RMFilterTypeNameIgnoreCaseImpl_Type_Object
		{
			get
			{
				if(r_MFilterTypeNameIgnoreCaseImpl_Type_Object == null)
				{
					r_MFilterTypeNameIgnoreCaseImpl_Type_Object = new(Type, "FilterTypeNameIgnoreCaseImpl", 0, typeof(System.Type), typeof(System.Object));
				}
				return r_MFilterTypeNameIgnoreCaseImpl_Type_Object;
			}
		}

		/// <summary>
		/// System.Guid Mono_GetGuid(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_MMono_GetGuid_Module;
		public static RMethod RMMono_GetGuid_Module
		{
			get
			{
				if(r_MMono_GetGuid_Module == null)
				{
					r_MMono_GetGuid_Module = new(Type, "Mono_GetGuid", 0, typeof(System.Reflection.Module));
				}
				return r_MMono_GetGuid_Module;
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
				}
				return r_MGetModuleVersionId;
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
				}
				return r_MGetSignerCertificate;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Module.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Module.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Module.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Module.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Module__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Module__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Module__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Module__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Module.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Module__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual System.ModuleHandle GetModuleHandleImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModuleHandleImpl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.ModuleHandle>(___result);
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


        public virtual System.Boolean IsResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsResource.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMethod_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RMGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethods.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo[]>(___result);
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RMGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo[]>(___result);
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetField_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.FieldInfo>(___result);
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.FieldInfo>(___result);
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFields.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.FieldInfo[]>(___result);
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RMGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.FieldInfo[]>(___result);
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Type GetType(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMGetType_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @ignoreCase};
            var ___result = RMGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RMFindTypes_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveField_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.FieldInfo>(___result);
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.FieldInfo>(___result);
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveMember_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MemberInfo>(___result);
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MemberInfo>(___result);
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveMethod_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodBase>(___result);
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodBase>(___result);
        }


        public virtual System.Byte[] ResolveSignature(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.String ResolveString(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveString_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveType_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.Reflection.Module @left, System.Reflection.Module @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_Module_Module.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Reflection.Module @left, System.Reflection.Module @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_Module_Module.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Boolean FilterTypeNameImpl(System.Type @cls, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls, @filterCriteria};
            var ___result = RMFilterTypeNameImpl_Type_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean FilterTypeNameIgnoreCaseImpl(System.Type @cls, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls, @filterCriteria};
            var ___result = RMFilterTypeNameIgnoreCaseImpl_Type_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Guid Mono_GetGuid(System.Reflection.Module @module)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@module};
            var ___result = RMMono_GetGuid_Module.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public virtual System.Guid GetModuleVersionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModuleVersionId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Guid>(___result);
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSignerCertificate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Cryptography.X509Certificates.X509Certificate>(___result);
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Module__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Module__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Module__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Module__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
