using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.TypeBuilder
	/// </summary>
    public partial class RTypeBuilder : RMember //
    {

		/// <summary>
		/// System.String tname
		/// </summary>
		protected RSystem.RString r_tname;
		public virtual RSystem.RString Rtname
		{
			get
			{
				if(r_tname == null)
				{
					r_tname = new(this, "tname");
					r_tname.SetBelong(this.instance);
				}
				return r_tname;
			}
		}

		/// <summary>
		/// System.String nspace
		/// </summary>
		protected RSystem.RString r_nspace;
		public virtual RSystem.RString Rnspace
		{
			get
			{
				if(r_nspace == null)
				{
					r_nspace = new(this, "nspace");
					r_nspace.SetBelong(this.instance);
				}
				return r_nspace;
			}
		}

		/// <summary>
		/// System.Type parent
		/// </summary>
		protected RSystem.RType r_parent;
		public virtual RSystem.RType Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent");
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// System.Type nesting_type
		/// </summary>
		protected RSystem.RType r_nesting_type;
		public virtual RSystem.RType Rnesting_type
		{
			get
			{
				if(r_nesting_type == null)
				{
					r_nesting_type = new(this, "nesting_type");
					r_nesting_type.SetBelong(this.instance);
				}
				return r_nesting_type;
			}
		}

		/// <summary>
		/// System.Type[] interfaces
		/// </summary>
		protected RFieldArray<RSystem.RType> r_interfaces;
		public virtual RFieldArray<RSystem.RType> Rinterfaces
		{
			get
			{
				if(r_interfaces == null)
				{
					r_interfaces = new(this, "interfaces");
					r_interfaces.SetBelong(this.instance);
				}
				return r_interfaces;
			}
		}

		/// <summary>
		/// System.Int32 num_methods
		/// </summary>
		protected RSystem.RInt32 r_num_methods;
		public virtual RSystem.RInt32 Rnum_methods
		{
			get
			{
				if(r_num_methods == null)
				{
					r_num_methods = new(this, "num_methods");
					r_num_methods.SetBelong(this.instance);
				}
				return r_num_methods;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder[] methods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RMethodBuilder> r_methods;
		public virtual RFieldArray<RSystem.RReflection.REmit.RMethodBuilder> Rmethods
		{
			get
			{
				if(r_methods == null)
				{
					r_methods = new(this, "methods");
					r_methods.SetBelong(this.instance);
				}
				return r_methods;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ConstructorBuilder[] ctors
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RConstructorBuilder> r_ctors;
		public virtual RFieldArray<RSystem.RReflection.REmit.RConstructorBuilder> Rctors
		{
			get
			{
				if(r_ctors == null)
				{
					r_ctors = new(this, "ctors");
					r_ctors.SetBelong(this.instance);
				}
				return r_ctors;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyBuilder[] properties
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RPropertyBuilder> r_properties;
		public virtual RFieldArray<RSystem.RReflection.REmit.RPropertyBuilder> Rproperties
		{
			get
			{
				if(r_properties == null)
				{
					r_properties = new(this, "properties");
					r_properties.SetBelong(this.instance);
				}
				return r_properties;
			}
		}

		/// <summary>
		/// System.Int32 num_fields
		/// </summary>
		protected RSystem.RInt32 r_num_fields;
		public virtual RSystem.RInt32 Rnum_fields
		{
			get
			{
				if(r_num_fields == null)
				{
					r_num_fields = new(this, "num_fields");
					r_num_fields.SetBelong(this.instance);
				}
				return r_num_fields;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder[] fields
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RFieldBuilder> r_fields;
		public virtual RFieldArray<RSystem.RReflection.REmit.RFieldBuilder> Rfields
		{
			get
			{
				if(r_fields == null)
				{
					r_fields = new(this, "fields");
					r_fields.SetBelong(this.instance);
				}
				return r_fields;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EventBuilder[] events
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.REventBuilder> r_events;
		public virtual RFieldArray<RSystem.RReflection.REmit.REventBuilder> Revents
		{
			get
			{
				if(r_events == null)
				{
					r_events = new(this, "events");
					r_events.SetBelong(this.instance);
				}
				return r_events;
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
		/// System.Reflection.Emit.TypeBuilder[] subtypes
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RTypeBuilder> r_subtypes;
		public virtual RFieldArray<RSystem.RReflection.REmit.RTypeBuilder> Rsubtypes
		{
			get
			{
				if(r_subtypes == null)
				{
					r_subtypes = new(this, "subtypes");
					r_subtypes.SetBelong(this.instance);
				}
				return r_subtypes;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes attrs
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
		/// System.Int32 table_idx
		/// </summary>
		protected RSystem.RInt32 r_table_idx;
		public virtual RSystem.RInt32 Rtable_idx
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
		/// System.Reflection.Emit.ModuleBuilder pmodule
		/// </summary>
		protected RSystem.RReflection.REmit.RModuleBuilder r_pmodule;
		public virtual RSystem.RReflection.REmit.RModuleBuilder Rpmodule
		{
			get
			{
				if(r_pmodule == null)
				{
					r_pmodule = new(this, "pmodule");
					r_pmodule.SetBelong(this.instance);
				}
				return r_pmodule;
			}
		}

		/// <summary>
		/// System.Int32 class_size
		/// </summary>
		protected RSystem.RInt32 r_class_size;
		public virtual RSystem.RInt32 Rclass_size
		{
			get
			{
				if(r_class_size == null)
				{
					r_class_size = new(this, "class_size");
					r_class_size.SetBelong(this.instance);
				}
				return r_class_size;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PackingSize packing_size
		/// </summary>
		protected RField r_packing_size;
		public virtual RField Rpacking_size
		{
			get
			{
				if(r_packing_size == null)
				{
					r_packing_size = new(this, "packing_size");
					r_packing_size.SetBelong(this.instance);
				}
				return r_packing_size;
			}
		}

		/// <summary>
		/// System.IntPtr generic_container
		/// </summary>
		protected RSystem.RIntPtr r_generic_container;
		public virtual RSystem.RIntPtr Rgeneric_container
		{
			get
			{
				if(r_generic_container == null)
				{
					r_generic_container = new(this, "generic_container");
					r_generic_container.SetBelong(this.instance);
				}
				return r_generic_container;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.GenericTypeParameterBuilder[] generic_params
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RGenericTypeParameterBuilder> r_generic_params;
		public virtual RFieldArray<RSystem.RReflection.REmit.RGenericTypeParameterBuilder> Rgeneric_params
		{
			get
			{
				if(r_generic_params == null)
				{
					r_generic_params = new(this, "generic_params");
					r_generic_params.SetBelong(this.instance);
				}
				return r_generic_params;
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
		/// System.Reflection.TypeInfo created
		/// </summary>
		protected RSystem.RReflection.RTypeInfo r_created;
		public virtual RSystem.RReflection.RTypeInfo Rcreated
		{
			get
			{
				if(r_created == null)
				{
					r_created = new(this, "created");
					r_created.SetBelong(this.instance);
				}
				return r_created;
			}
		}

		/// <summary>
		/// System.Int32 state
		/// </summary>
		protected RSystem.RInt32 r_state;
		public virtual RSystem.RInt32 Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.TypeName fullname
		/// </summary>
		protected RSystem.RTypeName r_fullname;
		public virtual RSystem.RTypeName Rfullname
		{
			get
			{
				if(r_fullname == null)
				{
					r_fullname = new(this, "fullname");
					r_fullname.SetBelong(this.instance);
				}
				return r_fullname;
			}
		}

		/// <summary>
		/// System.Boolean createTypeCalled
		/// </summary>
		protected RSystem.RBoolean r_createTypeCalled;
		public virtual RSystem.RBoolean RcreateTypeCalled
		{
			get
			{
				if(r_createTypeCalled == null)
				{
					r_createTypeCalled = new(this, "createTypeCalled");
					r_createTypeCalled.SetBelong(this.instance);
				}
				return r_createTypeCalled;
			}
		}

		/// <summary>
		/// System.Type underlying_type
		/// </summary>
		protected RSystem.RType r_underlying_type;
		public virtual RSystem.RType Runderlying_type
		{
			get
			{
				if(r_underlying_type == null)
				{
					r_underlying_type = new(this, "underlying_type");
					r_underlying_type.SetBelong(this.instance);
				}
				return r_underlying_type;
			}
		}

		/// <summary>
		/// System.Int32 UnspecifiedTypeSize
		/// </summary>
		protected static RSystem.RInt32 r_UnspecifiedTypeSize;
		public static RSystem.RInt32 RUnspecifiedTypeSize
		{
			get
			{
				if(r_UnspecifiedTypeSize == null)
				{
					r_UnspecifiedTypeSize = new(typeof(System.Reflection.Emit.TypeBuilder), "UnspecifiedTypeSize");
					r_UnspecifiedTypeSize.SetBelong(null);
				}
				return r_UnspecifiedTypeSize;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle _impl
		/// </summary>
		protected RSystem.RRuntimeTypeHandle r__impl;
		public virtual RSystem.RRuntimeTypeHandle R_impl
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
		/// System.String AssemblyQualifiedName
		/// </summary>
		protected RSystem.RString r_AssemblyQualifiedName;
		public virtual RSystem.RString RAssemblyQualifiedName
		{
			get
			{
				if(r_AssemblyQualifiedName == null)
				{
					r_AssemblyQualifiedName = new(this, "AssemblyQualifiedName", -1);
					r_AssemblyQualifiedName.SetBelong(this.instance);
				}
				return r_AssemblyQualifiedName;
			}
		}

		/// <summary>
		/// System.Type BaseType
		/// </summary>
		protected RSystem.RType r_BaseType;
		public virtual RSystem.RType RBaseType
		{
			get
			{
				if(r_BaseType == null)
				{
					r_BaseType = new(this, "BaseType", -1);
					r_BaseType.SetBelong(this.instance);
				}
				return r_BaseType;
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
		/// System.Type UnderlyingSystemType
		/// </summary>
		protected RSystem.RType r_UnderlyingSystemType;
		public virtual RSystem.RType RUnderlyingSystemType
		{
			get
			{
				if(r_UnderlyingSystemType == null)
				{
					r_UnderlyingSystemType = new(this, "UnderlyingSystemType", -1);
					r_UnderlyingSystemType.SetBelong(this.instance);
				}
				return r_UnderlyingSystemType;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected RSystem.RString r_FullName;
		public virtual RSystem.RString RFullName
		{
			get
			{
				if(r_FullName == null)
				{
					r_FullName = new(this, "FullName", -1);
					r_FullName.SetBelong(this.instance);
				}
				return r_FullName;
			}
		}

		/// <summary>
		/// System.Guid GUID
		/// </summary>
		protected RSystem.RGuid r_GUID;
		public virtual RSystem.RGuid RGUID
		{
			get
			{
				if(r_GUID == null)
				{
					r_GUID = new(this, "GUID", -1);
					r_GUID.SetBelong(this.instance);
				}
				return r_GUID;
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
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_Name;
		public virtual RSystem.RString RName
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
		/// System.String Namespace
		/// </summary>
		protected RSystem.RString r_Namespace;
		public virtual RSystem.RString RNamespace
		{
			get
			{
				if(r_Namespace == null)
				{
					r_Namespace = new(this, "Namespace", -1);
					r_Namespace.SetBelong(this.instance);
				}
				return r_Namespace;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PackingSize PackingSize
		/// </summary>
		protected RProperty r_PackingSize;
		public virtual RProperty RPackingSize
		{
			get
			{
				if(r_PackingSize == null)
				{
					r_PackingSize = new(this, "PackingSize", -1);
					r_PackingSize.SetBelong(this.instance);
				}
				return r_PackingSize;
			}
		}

		/// <summary>
		/// Int32 Size
		/// </summary>
		protected RSystem.RInt32 r_Size;
		public virtual RSystem.RInt32 RSize
		{
			get
			{
				if(r_Size == null)
				{
					r_Size = new(this, "Size", -1);
					r_Size.SetBelong(this.instance);
				}
				return r_Size;
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
		/// System.RuntimeTypeHandle TypeHandle
		/// </summary>
		protected RSystem.RRuntimeTypeHandle r_TypeHandle;
		public virtual RSystem.RRuntimeTypeHandle RTypeHandle
		{
			get
			{
				if(r_TypeHandle == null)
				{
					r_TypeHandle = new(this, "TypeHandle", -1);
					r_TypeHandle.SetBelong(this.instance);
				}
				return r_TypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken TypeToken
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeToken r_TypeToken;
		public virtual RSystem.RReflection.REmit.RTypeToken RTypeToken
		{
			get
			{
				if(r_TypeToken == null)
				{
					r_TypeToken = new(this, "TypeToken", -1);
					r_TypeToken.SetBelong(this.instance);
				}
				return r_TypeToken;
			}
		}

		/// <summary>
		/// Boolean is_created
		/// </summary>
		protected RSystem.RBoolean r_is_created;
		public virtual RSystem.RBoolean Ris_created
		{
			get
			{
				if(r_is_created == null)
				{
					r_is_created = new(this, "is_created", -1);
					r_is_created.SetBelong(this.instance);
				}
				return r_is_created;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected RSystem.RBoolean r_ContainsGenericParameters;
		public virtual RSystem.RBoolean RContainsGenericParameters
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
		/// Boolean IsGenericParameter
		/// </summary>
		protected RSystem.RBoolean r_IsGenericParameter;
		public virtual RSystem.RBoolean RIsGenericParameter
		{
			get
			{
				if(r_IsGenericParameter == null)
				{
					r_IsGenericParameter = new(this, "IsGenericParameter", -1);
					r_IsGenericParameter.SetBelong(this.instance);
				}
				return r_IsGenericParameter;
			}
		}

		/// <summary>
		/// System.Reflection.GenericParameterAttributes GenericParameterAttributes
		/// </summary>
		protected RProperty r_GenericParameterAttributes;
		public virtual RProperty RGenericParameterAttributes
		{
			get
			{
				if(r_GenericParameterAttributes == null)
				{
					r_GenericParameterAttributes = new(this, "GenericParameterAttributes", -1);
					r_GenericParameterAttributes.SetBelong(this.instance);
				}
				return r_GenericParameterAttributes;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition
		/// </summary>
		protected RSystem.RBoolean r_IsGenericTypeDefinition;
		public virtual RSystem.RBoolean RIsGenericTypeDefinition
		{
			get
			{
				if(r_IsGenericTypeDefinition == null)
				{
					r_IsGenericTypeDefinition = new(this, "IsGenericTypeDefinition", -1);
					r_IsGenericTypeDefinition.SetBelong(this.instance);
				}
				return r_IsGenericTypeDefinition;
			}
		}

		/// <summary>
		/// Boolean IsGenericType
		/// </summary>
		protected RSystem.RBoolean r_IsGenericType;
		public virtual RSystem.RBoolean RIsGenericType
		{
			get
			{
				if(r_IsGenericType == null)
				{
					r_IsGenericType = new(this, "IsGenericType", -1);
					r_IsGenericType.SetBelong(this.instance);
				}
				return r_IsGenericType;
			}
		}

		/// <summary>
		/// Int32 GenericParameterPosition
		/// </summary>
		protected RSystem.RInt32 r_GenericParameterPosition;
		public virtual RSystem.RInt32 RGenericParameterPosition
		{
			get
			{
				if(r_GenericParameterPosition == null)
				{
					r_GenericParameterPosition = new(this, "GenericParameterPosition", -1);
					r_GenericParameterPosition.SetBelong(this.instance);
				}
				return r_GenericParameterPosition;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase DeclaringMethod
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_DeclaringMethod;
		public virtual RSystem.RReflection.RMethodBase RDeclaringMethod
		{
			get
			{
				if(r_DeclaringMethod == null)
				{
					r_DeclaringMethod = new(this, "DeclaringMethod", -1);
					r_DeclaringMethod.SetBelong(this.instance);
				}
				return r_DeclaringMethod;
			}
		}

		/// <summary>
		/// Boolean IsUserType
		/// </summary>
		protected RSystem.RBoolean r_IsUserType;
		public virtual RSystem.RBoolean RIsUserType
		{
			get
			{
				if(r_IsUserType == null)
				{
					r_IsUserType = new(this, "IsUserType", -1);
					r_IsUserType.SetBelong(this.instance);
				}
				return r_IsUserType;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericType
		/// </summary>
		protected RSystem.RBoolean r_IsConstructedGenericType;
		public virtual RSystem.RBoolean RIsConstructedGenericType
		{
			get
			{
				if(r_IsConstructedGenericType == null)
				{
					r_IsConstructedGenericType = new(this, "IsConstructedGenericType", -1);
					r_IsConstructedGenericType.SetBelong(this.instance);
				}
				return r_IsConstructedGenericType;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition
		/// </summary>
		protected RSystem.RBoolean r_IsTypeDefinition;
		public virtual RSystem.RBoolean RIsTypeDefinition
		{
			get
			{
				if(r_IsTypeDefinition == null)
				{
					r_IsTypeDefinition = new(this, "IsTypeDefinition", -1);
					r_IsTypeDefinition.SetBelong(this.instance);
				}
				return r_IsTypeDefinition;
			}
		}

		/// <summary>
		/// System.Type[] GenericTypeParameters
		/// </summary>
		protected RPropertyArray<RSystem.RType> r_GenericTypeParameters;
		public virtual RPropertyArray<RSystem.RType> RGenericTypeParameters
		{
			get
			{
				if(r_GenericTypeParameters == null)
				{
					r_GenericTypeParameters = new(this, "GenericTypeParameters", -1);
					r_GenericTypeParameters.SetBelong(this.instance);
				}
				return r_GenericTypeParameters;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.ConstructorInfo] DeclaredConstructors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RConstructorInfo> r_DeclaredConstructors;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RConstructorInfo> RDeclaredConstructors
		{
			get
			{
				if(r_DeclaredConstructors == null)
				{
					r_DeclaredConstructors = new(this, "DeclaredConstructors", -1);
					r_DeclaredConstructors.SetBelong(this.instance);
				}
				return r_DeclaredConstructors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.EventInfo] DeclaredEvents
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.REventInfo> r_DeclaredEvents;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.REventInfo> RDeclaredEvents
		{
			get
			{
				if(r_DeclaredEvents == null)
				{
					r_DeclaredEvents = new(this, "DeclaredEvents", -1);
					r_DeclaredEvents.SetBelong(this.instance);
				}
				return r_DeclaredEvents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.FieldInfo] DeclaredFields
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RFieldInfo> r_DeclaredFields;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RFieldInfo> RDeclaredFields
		{
			get
			{
				if(r_DeclaredFields == null)
				{
					r_DeclaredFields = new(this, "DeclaredFields", -1);
					r_DeclaredFields.SetBelong(this.instance);
				}
				return r_DeclaredFields;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MemberInfo] DeclaredMembers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMemberInfo> r_DeclaredMembers;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMemberInfo> RDeclaredMembers
		{
			get
			{
				if(r_DeclaredMembers == null)
				{
					r_DeclaredMembers = new(this, "DeclaredMembers", -1);
					r_DeclaredMembers.SetBelong(this.instance);
				}
				return r_DeclaredMembers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MethodInfo] DeclaredMethods
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMethodInfo> r_DeclaredMethods;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMethodInfo> RDeclaredMethods
		{
			get
			{
				if(r_DeclaredMethods == null)
				{
					r_DeclaredMethods = new(this, "DeclaredMethods", -1);
					r_DeclaredMethods.SetBelong(this.instance);
				}
				return r_DeclaredMethods;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.TypeInfo] DeclaredNestedTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> r_DeclaredNestedTypes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> RDeclaredNestedTypes
		{
			get
			{
				if(r_DeclaredNestedTypes == null)
				{
					r_DeclaredNestedTypes = new(this, "DeclaredNestedTypes", -1);
					r_DeclaredNestedTypes.SetBelong(this.instance);
				}
				return r_DeclaredNestedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.PropertyInfo] DeclaredProperties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RPropertyInfo> r_DeclaredProperties;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RPropertyInfo> RDeclaredProperties
		{
			get
			{
				if(r_DeclaredProperties == null)
				{
					r_DeclaredProperties = new(this, "DeclaredProperties", -1);
					r_DeclaredProperties.SetBelong(this.instance);
				}
				return r_DeclaredProperties;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] ImplementedInterfaces
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_ImplementedInterfaces;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RImplementedInterfaces
		{
			get
			{
				if(r_ImplementedInterfaces == null)
				{
					r_ImplementedInterfaces = new(this, "ImplementedInterfaces", -1);
					r_ImplementedInterfaces.SetBelong(this.instance);
				}
				return r_ImplementedInterfaces;
			}
		}

		/// <summary>
		/// Boolean IsSerializable
		/// </summary>
		protected RSystem.RBoolean r_IsSerializable;
		public virtual RSystem.RBoolean RIsSerializable
		{
			get
			{
				if(r_IsSerializable == null)
				{
					r_IsSerializable = new(this, "IsSerializable", -1);
					r_IsSerializable.SetBelong(this.instance);
				}
				return r_IsSerializable;
			}
		}

		/// <summary>
		/// Boolean IsVisible
		/// </summary>
		protected RSystem.RBoolean r_IsVisible;
		public virtual RSystem.RBoolean RIsVisible
		{
			get
			{
				if(r_IsVisible == null)
				{
					r_IsVisible = new(this, "IsVisible", -1);
					r_IsVisible.SetBelong(this.instance);
				}
				return r_IsVisible;
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
		/// Boolean IsNested
		/// </summary>
		protected RSystem.RBoolean r_IsNested;
		public virtual RSystem.RBoolean RIsNested
		{
			get
			{
				if(r_IsNested == null)
				{
					r_IsNested = new(this, "IsNested", -1);
					r_IsNested.SetBelong(this.instance);
				}
				return r_IsNested;
			}
		}

		/// <summary>
		/// Boolean IsArray
		/// </summary>
		protected RSystem.RBoolean r_IsArray;
		public virtual RSystem.RBoolean RIsArray
		{
			get
			{
				if(r_IsArray == null)
				{
					r_IsArray = new(this, "IsArray", -1);
					r_IsArray.SetBelong(this.instance);
				}
				return r_IsArray;
			}
		}

		/// <summary>
		/// Boolean IsByRef
		/// </summary>
		protected RSystem.RBoolean r_IsByRef;
		public virtual RSystem.RBoolean RIsByRef
		{
			get
			{
				if(r_IsByRef == null)
				{
					r_IsByRef = new(this, "IsByRef", -1);
					r_IsByRef.SetBelong(this.instance);
				}
				return r_IsByRef;
			}
		}

		/// <summary>
		/// Boolean IsPointer
		/// </summary>
		protected RSystem.RBoolean r_IsPointer;
		public virtual RSystem.RBoolean RIsPointer
		{
			get
			{
				if(r_IsPointer == null)
				{
					r_IsPointer = new(this, "IsPointer", -1);
					r_IsPointer.SetBelong(this.instance);
				}
				return r_IsPointer;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeParameter
		/// </summary>
		protected RSystem.RBoolean r_IsGenericTypeParameter;
		public virtual RSystem.RBoolean RIsGenericTypeParameter
		{
			get
			{
				if(r_IsGenericTypeParameter == null)
				{
					r_IsGenericTypeParameter = new(this, "IsGenericTypeParameter", -1);
					r_IsGenericTypeParameter.SetBelong(this.instance);
				}
				return r_IsGenericTypeParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodParameter
		/// </summary>
		protected RSystem.RBoolean r_IsGenericMethodParameter;
		public virtual RSystem.RBoolean RIsGenericMethodParameter
		{
			get
			{
				if(r_IsGenericMethodParameter == null)
				{
					r_IsGenericMethodParameter = new(this, "IsGenericMethodParameter", -1);
					r_IsGenericMethodParameter.SetBelong(this.instance);
				}
				return r_IsGenericMethodParameter;
			}
		}

		/// <summary>
		/// Boolean IsSZArray
		/// </summary>
		protected RSystem.RBoolean r_IsSZArray;
		public virtual RSystem.RBoolean RIsSZArray
		{
			get
			{
				if(r_IsSZArray == null)
				{
					r_IsSZArray = new(this, "IsSZArray", -1);
					r_IsSZArray.SetBelong(this.instance);
				}
				return r_IsSZArray;
			}
		}

		/// <summary>
		/// Boolean IsVariableBoundArray
		/// </summary>
		protected RSystem.RBoolean r_IsVariableBoundArray;
		public virtual RSystem.RBoolean RIsVariableBoundArray
		{
			get
			{
				if(r_IsVariableBoundArray == null)
				{
					r_IsVariableBoundArray = new(this, "IsVariableBoundArray", -1);
					r_IsVariableBoundArray.SetBelong(this.instance);
				}
				return r_IsVariableBoundArray;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike
		/// </summary>
		protected RSystem.RBoolean r_IsByRefLike;
		public virtual RSystem.RBoolean RIsByRefLike
		{
			get
			{
				if(r_IsByRefLike == null)
				{
					r_IsByRefLike = new(this, "IsByRefLike", -1);
					r_IsByRefLike.SetBelong(this.instance);
				}
				return r_IsByRefLike;
			}
		}

		/// <summary>
		/// Boolean HasElementType
		/// </summary>
		protected RSystem.RBoolean r_HasElementType;
		public virtual RSystem.RBoolean RHasElementType
		{
			get
			{
				if(r_HasElementType == null)
				{
					r_HasElementType = new(this, "HasElementType", -1);
					r_HasElementType.SetBelong(this.instance);
				}
				return r_HasElementType;
			}
		}

		/// <summary>
		/// System.Type[] GenericTypeArguments
		/// </summary>
		protected RPropertyArray<RSystem.RType> r_GenericTypeArguments;
		public virtual RPropertyArray<RSystem.RType> RGenericTypeArguments
		{
			get
			{
				if(r_GenericTypeArguments == null)
				{
					r_GenericTypeArguments = new(this, "GenericTypeArguments", -1);
					r_GenericTypeArguments.SetBelong(this.instance);
				}
				return r_GenericTypeArguments;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Attributes
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
		/// Boolean IsAbstract
		/// </summary>
		protected RSystem.RBoolean r_IsAbstract;
		public virtual RSystem.RBoolean RIsAbstract
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
		/// Boolean IsImport
		/// </summary>
		protected RSystem.RBoolean r_IsImport;
		public virtual RSystem.RBoolean RIsImport
		{
			get
			{
				if(r_IsImport == null)
				{
					r_IsImport = new(this, "IsImport", -1);
					r_IsImport.SetBelong(this.instance);
				}
				return r_IsImport;
			}
		}

		/// <summary>
		/// Boolean IsSealed
		/// </summary>
		protected RSystem.RBoolean r_IsSealed;
		public virtual RSystem.RBoolean RIsSealed
		{
			get
			{
				if(r_IsSealed == null)
				{
					r_IsSealed = new(this, "IsSealed", -1);
					r_IsSealed.SetBelong(this.instance);
				}
				return r_IsSealed;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected RSystem.RBoolean r_IsSpecialName;
		public virtual RSystem.RBoolean RIsSpecialName
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
		/// Boolean IsClass
		/// </summary>
		protected RSystem.RBoolean r_IsClass;
		public virtual RSystem.RBoolean RIsClass
		{
			get
			{
				if(r_IsClass == null)
				{
					r_IsClass = new(this, "IsClass", -1);
					r_IsClass.SetBelong(this.instance);
				}
				return r_IsClass;
			}
		}

		/// <summary>
		/// Boolean IsNestedAssembly
		/// </summary>
		protected RSystem.RBoolean r_IsNestedAssembly;
		public virtual RSystem.RBoolean RIsNestedAssembly
		{
			get
			{
				if(r_IsNestedAssembly == null)
				{
					r_IsNestedAssembly = new(this, "IsNestedAssembly", -1);
					r_IsNestedAssembly.SetBelong(this.instance);
				}
				return r_IsNestedAssembly;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamANDAssem
		/// </summary>
		protected RSystem.RBoolean r_IsNestedFamANDAssem;
		public virtual RSystem.RBoolean RIsNestedFamANDAssem
		{
			get
			{
				if(r_IsNestedFamANDAssem == null)
				{
					r_IsNestedFamANDAssem = new(this, "IsNestedFamANDAssem", -1);
					r_IsNestedFamANDAssem.SetBelong(this.instance);
				}
				return r_IsNestedFamANDAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamily
		/// </summary>
		protected RSystem.RBoolean r_IsNestedFamily;
		public virtual RSystem.RBoolean RIsNestedFamily
		{
			get
			{
				if(r_IsNestedFamily == null)
				{
					r_IsNestedFamily = new(this, "IsNestedFamily", -1);
					r_IsNestedFamily.SetBelong(this.instance);
				}
				return r_IsNestedFamily;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamORAssem
		/// </summary>
		protected RSystem.RBoolean r_IsNestedFamORAssem;
		public virtual RSystem.RBoolean RIsNestedFamORAssem
		{
			get
			{
				if(r_IsNestedFamORAssem == null)
				{
					r_IsNestedFamORAssem = new(this, "IsNestedFamORAssem", -1);
					r_IsNestedFamORAssem.SetBelong(this.instance);
				}
				return r_IsNestedFamORAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedPrivate
		/// </summary>
		protected RSystem.RBoolean r_IsNestedPrivate;
		public virtual RSystem.RBoolean RIsNestedPrivate
		{
			get
			{
				if(r_IsNestedPrivate == null)
				{
					r_IsNestedPrivate = new(this, "IsNestedPrivate", -1);
					r_IsNestedPrivate.SetBelong(this.instance);
				}
				return r_IsNestedPrivate;
			}
		}

		/// <summary>
		/// Boolean IsNestedPublic
		/// </summary>
		protected RSystem.RBoolean r_IsNestedPublic;
		public virtual RSystem.RBoolean RIsNestedPublic
		{
			get
			{
				if(r_IsNestedPublic == null)
				{
					r_IsNestedPublic = new(this, "IsNestedPublic", -1);
					r_IsNestedPublic.SetBelong(this.instance);
				}
				return r_IsNestedPublic;
			}
		}

		/// <summary>
		/// Boolean IsNotPublic
		/// </summary>
		protected RSystem.RBoolean r_IsNotPublic;
		public virtual RSystem.RBoolean RIsNotPublic
		{
			get
			{
				if(r_IsNotPublic == null)
				{
					r_IsNotPublic = new(this, "IsNotPublic", -1);
					r_IsNotPublic.SetBelong(this.instance);
				}
				return r_IsNotPublic;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected RSystem.RBoolean r_IsPublic;
		public virtual RSystem.RBoolean RIsPublic
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
		/// Boolean IsAutoLayout
		/// </summary>
		protected RSystem.RBoolean r_IsAutoLayout;
		public virtual RSystem.RBoolean RIsAutoLayout
		{
			get
			{
				if(r_IsAutoLayout == null)
				{
					r_IsAutoLayout = new(this, "IsAutoLayout", -1);
					r_IsAutoLayout.SetBelong(this.instance);
				}
				return r_IsAutoLayout;
			}
		}

		/// <summary>
		/// Boolean IsExplicitLayout
		/// </summary>
		protected RSystem.RBoolean r_IsExplicitLayout;
		public virtual RSystem.RBoolean RIsExplicitLayout
		{
			get
			{
				if(r_IsExplicitLayout == null)
				{
					r_IsExplicitLayout = new(this, "IsExplicitLayout", -1);
					r_IsExplicitLayout.SetBelong(this.instance);
				}
				return r_IsExplicitLayout;
			}
		}

		/// <summary>
		/// Boolean IsLayoutSequential
		/// </summary>
		protected RSystem.RBoolean r_IsLayoutSequential;
		public virtual RSystem.RBoolean RIsLayoutSequential
		{
			get
			{
				if(r_IsLayoutSequential == null)
				{
					r_IsLayoutSequential = new(this, "IsLayoutSequential", -1);
					r_IsLayoutSequential.SetBelong(this.instance);
				}
				return r_IsLayoutSequential;
			}
		}

		/// <summary>
		/// Boolean IsAnsiClass
		/// </summary>
		protected RSystem.RBoolean r_IsAnsiClass;
		public virtual RSystem.RBoolean RIsAnsiClass
		{
			get
			{
				if(r_IsAnsiClass == null)
				{
					r_IsAnsiClass = new(this, "IsAnsiClass", -1);
					r_IsAnsiClass.SetBelong(this.instance);
				}
				return r_IsAnsiClass;
			}
		}

		/// <summary>
		/// Boolean IsAutoClass
		/// </summary>
		protected RSystem.RBoolean r_IsAutoClass;
		public virtual RSystem.RBoolean RIsAutoClass
		{
			get
			{
				if(r_IsAutoClass == null)
				{
					r_IsAutoClass = new(this, "IsAutoClass", -1);
					r_IsAutoClass.SetBelong(this.instance);
				}
				return r_IsAutoClass;
			}
		}

		/// <summary>
		/// Boolean IsUnicodeClass
		/// </summary>
		protected RSystem.RBoolean r_IsUnicodeClass;
		public virtual RSystem.RBoolean RIsUnicodeClass
		{
			get
			{
				if(r_IsUnicodeClass == null)
				{
					r_IsUnicodeClass = new(this, "IsUnicodeClass", -1);
					r_IsUnicodeClass.SetBelong(this.instance);
				}
				return r_IsUnicodeClass;
			}
		}

		/// <summary>
		/// Boolean IsCOMObject
		/// </summary>
		protected RSystem.RBoolean r_IsCOMObject;
		public virtual RSystem.RBoolean RIsCOMObject
		{
			get
			{
				if(r_IsCOMObject == null)
				{
					r_IsCOMObject = new(this, "IsCOMObject", -1);
					r_IsCOMObject.SetBelong(this.instance);
				}
				return r_IsCOMObject;
			}
		}

		/// <summary>
		/// Boolean IsContextful
		/// </summary>
		protected RSystem.RBoolean r_IsContextful;
		public virtual RSystem.RBoolean RIsContextful
		{
			get
			{
				if(r_IsContextful == null)
				{
					r_IsContextful = new(this, "IsContextful", -1);
					r_IsContextful.SetBelong(this.instance);
				}
				return r_IsContextful;
			}
		}

		/// <summary>
		/// Boolean IsCollectible
		/// </summary>
		protected RSystem.RBoolean r_IsCollectible;
		public virtual RSystem.RBoolean RIsCollectible
		{
			get
			{
				if(r_IsCollectible == null)
				{
					r_IsCollectible = new(this, "IsCollectible", -1);
					r_IsCollectible.SetBelong(this.instance);
				}
				return r_IsCollectible;
			}
		}

		/// <summary>
		/// Boolean IsEnum
		/// </summary>
		protected RSystem.RBoolean r_IsEnum;
		public virtual RSystem.RBoolean RIsEnum
		{
			get
			{
				if(r_IsEnum == null)
				{
					r_IsEnum = new(this, "IsEnum", -1);
					r_IsEnum.SetBelong(this.instance);
				}
				return r_IsEnum;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRef
		/// </summary>
		protected RSystem.RBoolean r_IsMarshalByRef;
		public virtual RSystem.RBoolean RIsMarshalByRef
		{
			get
			{
				if(r_IsMarshalByRef == null)
				{
					r_IsMarshalByRef = new(this, "IsMarshalByRef", -1);
					r_IsMarshalByRef.SetBelong(this.instance);
				}
				return r_IsMarshalByRef;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive
		/// </summary>
		protected RSystem.RBoolean r_IsPrimitive;
		public virtual RSystem.RBoolean RIsPrimitive
		{
			get
			{
				if(r_IsPrimitive == null)
				{
					r_IsPrimitive = new(this, "IsPrimitive", -1);
					r_IsPrimitive.SetBelong(this.instance);
				}
				return r_IsPrimitive;
			}
		}

		/// <summary>
		/// Boolean IsValueType
		/// </summary>
		protected RSystem.RBoolean r_IsValueType;
		public virtual RSystem.RBoolean RIsValueType
		{
			get
			{
				if(r_IsValueType == null)
				{
					r_IsValueType = new(this, "IsValueType", -1);
					r_IsValueType.SetBelong(this.instance);
				}
				return r_IsValueType;
			}
		}

		/// <summary>
		/// Boolean IsSignatureType
		/// </summary>
		protected RSystem.RBoolean r_IsSignatureType;
		public virtual RSystem.RBoolean RIsSignatureType
		{
			get
			{
				if(r_IsSignatureType == null)
				{
					r_IsSignatureType = new(this, "IsSignatureType", -1);
					r_IsSignatureType.SetBelong(this.instance);
				}
				return r_IsSignatureType;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected RSystem.RBoolean r_IsSecurityCritical;
		public virtual RSystem.RBoolean RIsSecurityCritical
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
		protected RSystem.RBoolean r_IsSecuritySafeCritical;
		public virtual RSystem.RBoolean RIsSecuritySafeCritical
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
		protected RSystem.RBoolean r_IsSecurityTransparent;
		public virtual RSystem.RBoolean RIsSecurityTransparent
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
		/// System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RStructLayoutAttribute r_StructLayoutAttribute;
		public virtual RSystem.RRuntime.RInteropServices.RStructLayoutAttribute RStructLayoutAttribute
		{
			get
			{
				if(r_StructLayoutAttribute == null)
				{
					r_StructLayoutAttribute = new(this, "StructLayoutAttribute", -1);
					r_StructLayoutAttribute.SetBelong(this.instance);
				}
				return r_StructLayoutAttribute;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo TypeInitializer
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_TypeInitializer;
		public virtual RSystem.RReflection.RConstructorInfo RTypeInitializer
		{
			get
			{
				if(r_TypeInitializer == null)
				{
					r_TypeInitializer = new(this, "TypeInitializer", -1);
					r_TypeInitializer.SetBelong(this.instance);
				}
				return r_TypeInitializer;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObject
		/// </summary>
		protected RSystem.RBoolean r_IsWindowsRuntimeObject;
		public virtual RSystem.RBoolean RIsWindowsRuntimeObject
		{
			get
			{
				if(r_IsWindowsRuntimeObject == null)
				{
					r_IsWindowsRuntimeObject = new(this, "IsWindowsRuntimeObject", -1);
					r_IsWindowsRuntimeObject.SetBelong(this.instance);
				}
				return r_IsWindowsRuntimeObject;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntime
		/// </summary>
		protected RSystem.RBoolean r_IsExportedToWindowsRuntime;
		public virtual RSystem.RBoolean RIsExportedToWindowsRuntime
		{
			get
			{
				if(r_IsExportedToWindowsRuntime == null)
				{
					r_IsExportedToWindowsRuntime = new(this, "IsExportedToWindowsRuntime", -1);
					r_IsExportedToWindowsRuntime.SetBelong(this.instance);
				}
				return r_IsExportedToWindowsRuntime;
			}
		}

		/// <summary>
		/// Boolean IsSzArray
		/// </summary>
		protected RSystem.RBoolean r_IsSzArray;
		public virtual RSystem.RBoolean RIsSzArray
		{
			get
			{
				if(r_IsSzArray == null)
				{
					r_IsSzArray = new(this, "IsSzArray", -1);
					r_IsSzArray.SetBelong(this.instance);
				}
				return r_IsSzArray;
			}
		}

		/// <summary>
		/// Boolean IsInterface
		/// </summary>
		protected RSystem.RBoolean r_IsInterface;
		public virtual RSystem.RBoolean RIsInterface
		{
			get
			{
				if(r_IsInterface == null)
				{
					r_IsInterface = new(this, "IsInterface", -1);
					r_IsInterface.SetBelong(this.instance);
				}
				return r_IsInterface;
			}
		}

		/// <summary>
		/// System.String FullNameOrDefault
		/// </summary>
		protected RSystem.RString r_FullNameOrDefault;
		public virtual RSystem.RString RFullNameOrDefault
		{
			get
			{
				if(r_FullNameOrDefault == null)
				{
					r_FullNameOrDefault = new(this, "FullNameOrDefault", -1);
					r_FullNameOrDefault.SetBelong(this.instance);
				}
				return r_FullNameOrDefault;
			}
		}

		/// <summary>
		/// System.String InternalNameIfAvailable
		/// </summary>
		protected RSystem.RString r_InternalNameIfAvailable;
		public virtual RSystem.RString RInternalNameIfAvailable
		{
			get
			{
				if(r_InternalNameIfAvailable == null)
				{
					r_InternalNameIfAvailable = new(this, "InternalNameIfAvailable", -1);
					r_InternalNameIfAvailable.SetBelong(this.instance);
				}
				return r_InternalNameIfAvailable;
			}
		}

		/// <summary>
		/// System.String NameOrDefault
		/// </summary>
		protected RSystem.RString r_NameOrDefault;
		public virtual RSystem.RString RNameOrDefault
		{
			get
			{
				if(r_NameOrDefault == null)
				{
					r_NameOrDefault = new(this, "NameOrDefault", -1);
					r_NameOrDefault.SetBelong(this.instance);
				}
				return r_NameOrDefault;
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
		protected RSystem.RInt32 r_MetadataToken;
		public virtual RSystem.RInt32 RMetadataToken
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
		/// Void System.Runtime.InteropServices._TypeBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._TypeBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._TypeBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._TypeBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._TypeBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._TypeBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._TypeBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._TypeBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		/// </summary>
		protected RMethod r_GetAttributeFlagsImpl;
		public virtual RMethod RGetAttributeFlagsImpl
		{
			get
			{
				if(r_GetAttributeFlagsImpl == null)
				{
					r_GetAttributeFlagsImpl = new(this, "GetAttributeFlagsImpl", 0);
					r_GetAttributeFlagsImpl.SetBelong(this.instance);
				}
				return r_GetAttributeFlagsImpl;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.Type)
		/// </summary>
		protected RMethod r_IsSubclassOf_Type;
		public virtual RMethod RIsSubclassOf_Type
		{
			get
			{
				if(r_IsSubclassOf_Type == null)
				{
					r_IsSubclassOf_Type = new(this, "IsSubclassOf", 0, typeof(System.Type));
					r_IsSubclassOf_Type.SetBelong(this.instance);
				}
				return r_IsSubclassOf_Type;
			}
		}

		/// <summary>
		/// System.TypeName GetFullName()
		/// </summary>
		protected RMethod r_GetFullName;
		public virtual RMethod RGetFullName
		{
			get
			{
				if(r_GetFullName == null)
				{
					r_GetFullName = new(this, "GetFullName", 0);
					r_GetFullName.SetBelong(this.instance);
				}
				return r_GetFullName;
			}
		}

		/// <summary>
		/// Void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_AddDeclarativeSecurity_SecurityAction_PermissionSet;
		public virtual RMethod RAddDeclarativeSecurity_SecurityAction_PermissionSet
		{
			get
			{
				if(r_AddDeclarativeSecurity_SecurityAction_PermissionSet == null)
				{
					r_AddDeclarativeSecurity_SecurityAction_PermissionSet = new(this, "AddDeclarativeSecurity", 0, typeof(System.Security.Permissions.SecurityAction), typeof(System.Security.PermissionSet));
					r_AddDeclarativeSecurity_SecurityAction_PermissionSet.SetBelong(this.instance);
				}
				return r_AddDeclarativeSecurity_SecurityAction_PermissionSet;
			}
		}

		/// <summary>
		/// Void AddInterfaceImplementation(System.Type)
		/// </summary>
		protected RMethod r_AddInterfaceImplementation_Type;
		public virtual RMethod RAddInterfaceImplementation_Type
		{
			get
			{
				if(r_AddInterfaceImplementation_Type == null)
				{
					r_AddInterfaceImplementation_Type = new(this, "AddInterfaceImplementation", 0, typeof(System.Type));
					r_AddInterfaceImplementation_Type.SetBelong(this.instance);
				}
				return r_AddInterfaceImplementation_Type;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructorImpl", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
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
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String)
		/// </summary>
		protected RMethod r_DefineNestedType_String;
		public virtual RMethod RDefineNestedType_String
		{
			get
			{
				if(r_DefineNestedType_String == null)
				{
					r_DefineNestedType_String = new(this, "DefineNestedType", 0, typeof(System.String));
					r_DefineNestedType_String.SetBelong(this.instance);
				}
				return r_DefineNestedType_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes)
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes;
		public virtual RMethod RDefineNestedType_String_TypeAttributes
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes == null)
				{
					r_DefineNestedType_String_TypeAttributes = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes));
					r_DefineNestedType_String_TypeAttributes.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes_Type;
		public virtual RMethod RDefineNestedType_String_TypeAttributes_Type
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes_Type == null)
				{
					r_DefineNestedType_String_TypeAttributes_Type = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_DefineNestedType_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[], System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
		public virtual RMethod RDefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 == null)
				{
					r_DefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_DefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes_Type_TypeArray;
		public virtual RMethod RDefineNestedType_String_TypeAttributes_Type_TypeArray
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes_Type_TypeArray == null)
				{
					r_DefineNestedType_String_TypeAttributes_Type_TypeArray = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineNestedType_String_TypeAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes, System.Type, Int32)
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes_Type_Int32;
		public virtual RMethod RDefineNestedType_String_TypeAttributes_Type_Int32
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes_Type_Int32 == null)
				{
					r_DefineNestedType_String_TypeAttributes_Type_Int32 = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Int32));
					r_DefineNestedType_String_TypeAttributes_Type_Int32.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes_Type_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize)
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes_Type_PackingSize;
		public virtual RMethod RDefineNestedType_String_TypeAttributes_Type_PackingSize
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes_Type_PackingSize == null)
				{
					r_DefineNestedType_String_TypeAttributes_Type_PackingSize = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize));
					r_DefineNestedType_String_TypeAttributes_Type_PackingSize.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes_Type_PackingSize;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineNestedType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_DefineNestedType_String_TypeAttributes_Type_PackingSize_Int32;
		public virtual RMethod RDefineNestedType_String_TypeAttributes_Type_PackingSize_Int32
		{
			get
			{
				if(r_DefineNestedType_String_TypeAttributes_Type_PackingSize_Int32 == null)
				{
					r_DefineNestedType_String_TypeAttributes_Type_PackingSize_Int32 = new(this, "DefineNestedType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_DefineNestedType_String_TypeAttributes_Type_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_DefineNestedType_String_TypeAttributes_Type_PackingSize_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type[])
		/// </summary>
		protected RMethod r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray;
		public virtual RMethod RDefineConstructor_MethodAttributes_CallingConventions_TypeArray
		{
			get
			{
				if(r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray == null)
				{
					r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray = new(this, "DefineConstructor", 0, typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType());
					r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray.SetBelong(this.instance);
				}
				return r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RDefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineConstructor", 0, typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_DefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ConstructorBuilder DefineDefaultConstructor(System.Reflection.MethodAttributes)
		/// </summary>
		protected RMethod r_DefineDefaultConstructor_MethodAttributes;
		public virtual RMethod RDefineDefaultConstructor_MethodAttributes
		{
			get
			{
				if(r_DefineDefaultConstructor_MethodAttributes == null)
				{
					r_DefineDefaultConstructor_MethodAttributes = new(this, "DefineDefaultConstructor", 0, typeof(System.Reflection.MethodAttributes));
					r_DefineDefaultConstructor_MethodAttributes.SetBelong(this.instance);
				}
				return r_DefineDefaultConstructor_MethodAttributes;
			}
		}

		/// <summary>
		/// Void append_method(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_append_method_MethodBuilder;
		public virtual RMethod Rappend_method_MethodBuilder
		{
			get
			{
				if(r_append_method_MethodBuilder == null)
				{
					r_append_method_MethodBuilder = new(this, "append_method", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_append_method_MethodBuilder.SetBelong(this.instance);
				}
				return r_append_method_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineMethod(System.String, System.Reflection.MethodAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineMethod_String_MethodAttributes_Type_TypeArray;
		public virtual RMethod RDefineMethod_String_MethodAttributes_Type_TypeArray
		{
			get
			{
				if(r_DefineMethod_String_MethodAttributes_Type_TypeArray == null)
				{
					r_DefineMethod_String_MethodAttributes_Type_TypeArray = new(this, "DefineMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineMethod_String_MethodAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineMethod_String_MethodAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
		public virtual RMethod RDefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray == null)
				{
					r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray = new(this, "DefineMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RDefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_DefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
		public virtual RMethod RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet
		{
			get
			{
				if(r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet == null)
				{
					r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet;
		public virtual RMethod RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet
		{
			get
			{
				if(r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet == null)
				{
					r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_DefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_DefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
		public virtual RMethod RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet
		{
			get
			{
				if(r_DefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet == null)
				{
					r_DefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_DefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_DefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineMethod(System.String, System.Reflection.MethodAttributes)
		/// </summary>
		protected RMethod r_DefineMethod_String_MethodAttributes;
		public virtual RMethod RDefineMethod_String_MethodAttributes
		{
			get
			{
				if(r_DefineMethod_String_MethodAttributes == null)
				{
					r_DefineMethod_String_MethodAttributes = new(this, "DefineMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes));
					r_DefineMethod_String_MethodAttributes.SetBelong(this.instance);
				}
				return r_DefineMethod_String_MethodAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions)
		/// </summary>
		protected RMethod r_DefineMethod_String_MethodAttributes_CallingConventions;
		public virtual RMethod RDefineMethod_String_MethodAttributes_CallingConventions
		{
			get
			{
				if(r_DefineMethod_String_MethodAttributes_CallingConventions == null)
				{
					r_DefineMethod_String_MethodAttributes_CallingConventions = new(this, "DefineMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions));
					r_DefineMethod_String_MethodAttributes_CallingConventions.SetBelong(this.instance);
				}
				return r_DefineMethod_String_MethodAttributes_CallingConventions;
			}
		}

		/// <summary>
		/// Void DefineMethodOverride(System.Reflection.MethodInfo, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_DefineMethodOverride_MethodInfo_MethodInfo;
		public virtual RMethod RDefineMethodOverride_MethodInfo_MethodInfo
		{
			get
			{
				if(r_DefineMethodOverride_MethodInfo_MethodInfo == null)
				{
					r_DefineMethodOverride_MethodInfo_MethodInfo = new(this, "DefineMethodOverride", 0, typeof(System.Reflection.MethodInfo), typeof(System.Reflection.MethodInfo));
					r_DefineMethodOverride_MethodInfo_MethodInfo.SetBelong(this.instance);
				}
				return r_DefineMethodOverride_MethodInfo_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineField(System.String, System.Type, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_DefineField_String_Type_FieldAttributes;
		public virtual RMethod RDefineField_String_Type_FieldAttributes
		{
			get
			{
				if(r_DefineField_String_Type_FieldAttributes == null)
				{
					r_DefineField_String_Type_FieldAttributes = new(this, "DefineField", 0, typeof(System.String), typeof(System.Type), typeof(System.Reflection.FieldAttributes));
					r_DefineField_String_Type_FieldAttributes.SetBelong(this.instance);
				}
				return r_DefineField_String_Type_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineField(System.String, System.Type, System.Type[], System.Type[], System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_DefineField_String_Type_TypeArray_TypeArray_FieldAttributes;
		public virtual RMethod RDefineField_String_Type_TypeArray_TypeArray_FieldAttributes
		{
			get
			{
				if(r_DefineField_String_Type_TypeArray_TypeArray_FieldAttributes == null)
				{
					r_DefineField_String_Type_TypeArray_TypeArray_FieldAttributes = new(this, "DefineField", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.FieldAttributes));
					r_DefineField_String_Type_TypeArray_TypeArray_FieldAttributes.SetBelong(this.instance);
				}
				return r_DefineField_String_Type_TypeArray_TypeArray_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyBuilder DefineProperty(System.String, System.Reflection.PropertyAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineProperty_String_PropertyAttributes_Type_TypeArray;
		public virtual RMethod RDefineProperty_String_PropertyAttributes_Type_TypeArray
		{
			get
			{
				if(r_DefineProperty_String_PropertyAttributes_Type_TypeArray == null)
				{
					r_DefineProperty_String_PropertyAttributes_Type_TypeArray = new(this, "DefineProperty", 0, typeof(System.String), typeof(System.Reflection.PropertyAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineProperty_String_PropertyAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineProperty_String_PropertyAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyBuilder DefineProperty(System.String, System.Reflection.PropertyAttributes, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray;
		public virtual RMethod RDefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray == null)
				{
					r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray = new(this, "DefineProperty", 0, typeof(System.String), typeof(System.Reflection.PropertyAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyBuilder DefineProperty(System.String, System.Reflection.PropertyAttributes, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_DefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RDefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_DefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_DefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineProperty", 0, typeof(System.String), typeof(System.Reflection.PropertyAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_DefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_DefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.PropertyBuilder DefineProperty(System.String, System.Reflection.PropertyAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RDefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineProperty", 0, typeof(System.String), typeof(System.Reflection.PropertyAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_DefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ConstructorBuilder DefineTypeInitializer()
		/// </summary>
		protected RMethod r_DefineTypeInitializer;
		public virtual RMethod RDefineTypeInitializer
		{
			get
			{
				if(r_DefineTypeInitializer == null)
				{
					r_DefineTypeInitializer = new(this, "DefineTypeInitializer", 0);
					r_DefineTypeInitializer.SetBelong(this.instance);
				}
				return r_DefineTypeInitializer;
			}
		}

		/// <summary>
		/// System.Reflection.TypeInfo create_runtime_class()
		/// </summary>
		protected RMethod r_create_runtime_class;
		public virtual RMethod Rcreate_runtime_class
		{
			get
			{
				if(r_create_runtime_class == null)
				{
					r_create_runtime_class = new(this, "create_runtime_class", 0);
					r_create_runtime_class.SetBelong(this.instance);
				}
				return r_create_runtime_class;
			}
		}

		/// <summary>
		/// Boolean is_nested_in(System.Type)
		/// </summary>
		protected RMethod r_is_nested_in_Type;
		public virtual RMethod Ris_nested_in_Type
		{
			get
			{
				if(r_is_nested_in_Type == null)
				{
					r_is_nested_in_Type = new(this, "is_nested_in", 0, typeof(System.Type));
					r_is_nested_in_Type.SetBelong(this.instance);
				}
				return r_is_nested_in_Type;
			}
		}

		/// <summary>
		/// Boolean has_ctor_method()
		/// </summary>
		protected RMethod r_has_ctor_method;
		public virtual RMethod Rhas_ctor_method
		{
			get
			{
				if(r_has_ctor_method == null)
				{
					r_has_ctor_method = new(this, "has_ctor_method", 0);
					r_has_ctor_method.SetBelong(this.instance);
				}
				return r_has_ctor_method;
			}
		}

		/// <summary>
		/// System.Type CreateType()
		/// </summary>
		protected RMethod r_CreateType;
		public virtual RMethod RCreateType
		{
			get
			{
				if(r_CreateType == null)
				{
					r_CreateType = new(this, "CreateType", 0);
					r_CreateType.SetBelong(this.instance);
				}
				return r_CreateType;
			}
		}

		/// <summary>
		/// System.Reflection.TypeInfo CreateTypeInfo()
		/// </summary>
		protected RMethod r_CreateTypeInfo;
		public virtual RMethod RCreateTypeInfo
		{
			get
			{
				if(r_CreateTypeInfo == null)
				{
					r_CreateTypeInfo = new(this, "CreateTypeInfo", 0);
					r_CreateTypeInfo.SetBelong(this.instance);
				}
				return r_CreateTypeInfo;
			}
		}

		/// <summary>
		/// Void ResolveUserTypes()
		/// </summary>
		protected RMethod r_ResolveUserTypes;
		public virtual RMethod RResolveUserTypes
		{
			get
			{
				if(r_ResolveUserTypes == null)
				{
					r_ResolveUserTypes = new(this, "ResolveUserTypes", 0);
					r_ResolveUserTypes.SetBelong(this.instance);
				}
				return r_ResolveUserTypes;
			}
		}

		/// <summary>
		/// Void ResolveUserTypes(System.Type[])
		/// </summary>
		protected static RMethod r_ResolveUserTypes_TypeArray;
		public static RMethod RResolveUserTypes_TypeArray
		{
			get
			{
				if(r_ResolveUserTypes_TypeArray == null)
				{
					r_ResolveUserTypes_TypeArray = new(typeof(System.Reflection.Emit.TypeBuilder), "ResolveUserTypes", 0, typeof(System.Type).MakeArrayType());
					r_ResolveUserTypes_TypeArray.SetBelong(null);
				}
				return r_ResolveUserTypes_TypeArray;
			}
		}

		/// <summary>
		/// System.Type ResolveUserType(System.Type)
		/// </summary>
		protected static RMethod r_ResolveUserType_Type;
		public static RMethod RResolveUserType_Type
		{
			get
			{
				if(r_ResolveUserType_Type == null)
				{
					r_ResolveUserType_Type = new(typeof(System.Reflection.Emit.TypeBuilder), "ResolveUserType", 0, typeof(System.Type));
					r_ResolveUserType_Type.SetBelong(null);
				}
				return r_ResolveUserType_Type;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo])
		/// </summary>
		protected RMethod r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
		public virtual RMethod RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_
		{
			get
			{
				if(r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ == null)
				{
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.SetBelong(this.instance);
				}
				return r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
			}
		}

		/// <summary>
		/// Void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter)
		/// </summary>
		protected RMethod r_GenerateDebugInfo_ISymbolWriter;
		public virtual RMethod RGenerateDebugInfo_ISymbolWriter
		{
			get
			{
				if(r_GenerateDebugInfo_ISymbolWriter == null)
				{
					r_GenerateDebugInfo_ISymbolWriter = new(this, "GenerateDebugInfo", 0, typeof(System.Diagnostics.SymbolStore.ISymbolWriter));
					r_GenerateDebugInfo_ISymbolWriter.SetBelong(this.instance);
				}
				return r_GenerateDebugInfo_ISymbolWriter;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetConstructors_BindingFlags;
		public virtual RMethod RGetConstructors_BindingFlags
		{
			get
			{
				if(r_GetConstructors_BindingFlags == null)
				{
					r_GetConstructors_BindingFlags = new(this, "GetConstructors", 0, typeof(System.Reflection.BindingFlags));
					r_GetConstructors_BindingFlags.SetBelong(this.instance);
				}
				return r_GetConstructors_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructorsInternal(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetConstructorsInternal_BindingFlags;
		public virtual RMethod RGetConstructorsInternal_BindingFlags
		{
			get
			{
				if(r_GetConstructorsInternal_BindingFlags == null)
				{
					r_GetConstructorsInternal_BindingFlags = new(this, "GetConstructorsInternal", 0, typeof(System.Reflection.BindingFlags));
					r_GetConstructorsInternal_BindingFlags.SetBelong(this.instance);
				}
				return r_GetConstructorsInternal_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type GetElementType()
		/// </summary>
		protected RMethod r_GetElementType;
		public virtual RMethod RGetElementType
		{
			get
			{
				if(r_GetElementType == null)
				{
					r_GetElementType = new(this, "GetElementType", 0);
					r_GetElementType.SetBelong(this.instance);
				}
				return r_GetElementType;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetEvent_String_BindingFlags;
		public virtual RMethod RGetEvent_String_BindingFlags
		{
			get
			{
				if(r_GetEvent_String_BindingFlags == null)
				{
					r_GetEvent_String_BindingFlags = new(this, "GetEvent", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetEvent_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetEvent_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents()
		/// </summary>
		protected RMethod r_GetEvents;
		public virtual RMethod RGetEvents
		{
			get
			{
				if(r_GetEvents == null)
				{
					r_GetEvents = new(this, "GetEvents", 0);
					r_GetEvents.SetBelong(this.instance);
				}
				return r_GetEvents;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetEvents_BindingFlags;
		public virtual RMethod RGetEvents_BindingFlags
		{
			get
			{
				if(r_GetEvents_BindingFlags == null)
				{
					r_GetEvents_BindingFlags = new(this, "GetEvents", 0, typeof(System.Reflection.BindingFlags));
					r_GetEvents_BindingFlags.SetBelong(this.instance);
				}
				return r_GetEvents_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetField_String_BindingFlags;
		public virtual RMethod RGetField_String_BindingFlags
		{
			get
			{
				if(r_GetField_String_BindingFlags == null)
				{
					r_GetField_String_BindingFlags = new(this, "GetField", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetField_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetField_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetFields_BindingFlags;
		public virtual RMethod RGetFields_BindingFlags
		{
			get
			{
				if(r_GetFields_BindingFlags == null)
				{
					r_GetFields_BindingFlags = new(this, "GetFields", 0, typeof(System.Reflection.BindingFlags));
					r_GetFields_BindingFlags.SetBelong(this.instance);
				}
				return r_GetFields_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String, Boolean)
		/// </summary>
		protected RMethod r_GetInterface_String_Boolean;
		public virtual RMethod RGetInterface_String_Boolean
		{
			get
			{
				if(r_GetInterface_String_Boolean == null)
				{
					r_GetInterface_String_Boolean = new(this, "GetInterface", 0, typeof(System.String), typeof(System.Boolean));
					r_GetInterface_String_Boolean.SetBelong(this.instance);
				}
				return r_GetInterface_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetInterfaces()
		/// </summary>
		protected RMethod r_GetInterfaces;
		public virtual RMethod RGetInterfaces
		{
			get
			{
				if(r_GetInterfaces == null)
				{
					r_GetInterfaces = new(this, "GetInterfaces", 0);
					r_GetInterfaces.SetBelong(this.instance);
				}
				return r_GetInterfaces;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.MemberTypes, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMember_String_MemberTypes_BindingFlags;
		public virtual RMethod RGetMember_String_MemberTypes_BindingFlags
		{
			get
			{
				if(r_GetMember_String_MemberTypes_BindingFlags == null)
				{
					r_GetMember_String_MemberTypes_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags));
					r_GetMember_String_MemberTypes_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMember_String_MemberTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMembers_BindingFlags;
		public virtual RMethod RGetMembers_BindingFlags
		{
			get
			{
				if(r_GetMembers_BindingFlags == null)
				{
					r_GetMembers_BindingFlags = new(this, "GetMembers", 0, typeof(System.Reflection.BindingFlags));
					r_GetMembers_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMembers_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethodsByName(System.String, System.Reflection.BindingFlags, Boolean, System.Type)
		/// </summary>
		protected RMethod r_GetMethodsByName_String_BindingFlags_Boolean_Type;
		public virtual RMethod RGetMethodsByName_String_BindingFlags_Boolean_Type
		{
			get
			{
				if(r_GetMethodsByName_String_BindingFlags_Boolean_Type == null)
				{
					r_GetMethodsByName_String_BindingFlags_Boolean_Type = new(this, "GetMethodsByName", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Boolean), typeof(System.Type));
					r_GetMethodsByName_String_BindingFlags_Boolean_Type.SetBelong(this.instance);
				}
				return r_GetMethodsByName_String_BindingFlags_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMethods_BindingFlags;
		public virtual RMethod RGetMethods_BindingFlags
		{
			get
			{
				if(r_GetMethods_BindingFlags == null)
				{
					r_GetMethods_BindingFlags = new(this, "GetMethods", 0, typeof(System.Reflection.BindingFlags));
					r_GetMethods_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMethods_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetNestedType_String_BindingFlags;
		public virtual RMethod RGetNestedType_String_BindingFlags
		{
			get
			{
				if(r_GetNestedType_String_BindingFlags == null)
				{
					r_GetNestedType_String_BindingFlags = new(this, "GetNestedType", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetNestedType_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetNestedType_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetNestedTypes_BindingFlags;
		public virtual RMethod RGetNestedTypes_BindingFlags
		{
			get
			{
				if(r_GetNestedTypes_BindingFlags == null)
				{
					r_GetNestedTypes_BindingFlags = new(this, "GetNestedTypes", 0, typeof(System.Reflection.BindingFlags));
					r_GetNestedTypes_BindingFlags.SetBelong(this.instance);
				}
				return r_GetNestedTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetProperties_BindingFlags;
		public virtual RMethod RGetProperties_BindingFlags
		{
			get
			{
				if(r_GetProperties_BindingFlags == null)
				{
					r_GetProperties_BindingFlags = new(this, "GetProperties", 0, typeof(System.Reflection.BindingFlags));
					r_GetProperties_BindingFlags.SetBelong(this.instance);
				}
				return r_GetProperties_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetPropertyImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// Boolean HasElementTypeImpl()
		/// </summary>
		protected RMethod r_HasElementTypeImpl;
		public virtual RMethod RHasElementTypeImpl
		{
			get
			{
				if(r_HasElementTypeImpl == null)
				{
					r_HasElementTypeImpl = new(this, "HasElementTypeImpl", 0);
					r_HasElementTypeImpl.SetBelong(this.instance);
				}
				return r_HasElementTypeImpl;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[])
		/// </summary>
		protected RMethod r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray
		{
			get
			{
				if(r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray == null)
				{
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType());
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.SetBelong(this.instance);
				}
				return r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
			}
		}

		/// <summary>
		/// Boolean IsArrayImpl()
		/// </summary>
		protected RMethod r_IsArrayImpl;
		public virtual RMethod RIsArrayImpl
		{
			get
			{
				if(r_IsArrayImpl == null)
				{
					r_IsArrayImpl = new(this, "IsArrayImpl", 0);
					r_IsArrayImpl.SetBelong(this.instance);
				}
				return r_IsArrayImpl;
			}
		}

		/// <summary>
		/// Boolean IsByRefImpl()
		/// </summary>
		protected RMethod r_IsByRefImpl;
		public virtual RMethod RIsByRefImpl
		{
			get
			{
				if(r_IsByRefImpl == null)
				{
					r_IsByRefImpl = new(this, "IsByRefImpl", 0);
					r_IsByRefImpl.SetBelong(this.instance);
				}
				return r_IsByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsCOMObjectImpl()
		/// </summary>
		protected RMethod r_IsCOMObjectImpl;
		public virtual RMethod RIsCOMObjectImpl
		{
			get
			{
				if(r_IsCOMObjectImpl == null)
				{
					r_IsCOMObjectImpl = new(this, "IsCOMObjectImpl", 0);
					r_IsCOMObjectImpl.SetBelong(this.instance);
				}
				return r_IsCOMObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsPointerImpl()
		/// </summary>
		protected RMethod r_IsPointerImpl;
		public virtual RMethod RIsPointerImpl
		{
			get
			{
				if(r_IsPointerImpl == null)
				{
					r_IsPointerImpl = new(this, "IsPointerImpl", 0);
					r_IsPointerImpl.SetBelong(this.instance);
				}
				return r_IsPointerImpl;
			}
		}

		/// <summary>
		/// Boolean IsPrimitiveImpl()
		/// </summary>
		protected RMethod r_IsPrimitiveImpl;
		public virtual RMethod RIsPrimitiveImpl
		{
			get
			{
				if(r_IsPrimitiveImpl == null)
				{
					r_IsPrimitiveImpl = new(this, "IsPrimitiveImpl", 0);
					r_IsPrimitiveImpl.SetBelong(this.instance);
				}
				return r_IsPrimitiveImpl;
			}
		}

		/// <summary>
		/// Boolean IsValueTypeImpl()
		/// </summary>
		protected RMethod r_IsValueTypeImpl;
		public virtual RMethod RIsValueTypeImpl
		{
			get
			{
				if(r_IsValueTypeImpl == null)
				{
					r_IsValueTypeImpl = new(this, "IsValueTypeImpl", 0);
					r_IsValueTypeImpl.SetBelong(this.instance);
				}
				return r_IsValueTypeImpl;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType()
		/// </summary>
		protected RMethod r_MakeArrayType;
		public virtual RMethod RMakeArrayType
		{
			get
			{
				if(r_MakeArrayType == null)
				{
					r_MakeArrayType = new(this, "MakeArrayType", 0);
					r_MakeArrayType.SetBelong(this.instance);
				}
				return r_MakeArrayType;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType(Int32)
		/// </summary>
		protected RMethod r_MakeArrayType_Int32;
		public virtual RMethod RMakeArrayType_Int32
		{
			get
			{
				if(r_MakeArrayType_Int32 == null)
				{
					r_MakeArrayType_Int32 = new(this, "MakeArrayType", 0, typeof(System.Int32));
					r_MakeArrayType_Int32.SetBelong(this.instance);
				}
				return r_MakeArrayType_Int32;
			}
		}

		/// <summary>
		/// System.Type MakeByRefType()
		/// </summary>
		protected RMethod r_MakeByRefType;
		public virtual RMethod RMakeByRefType
		{
			get
			{
				if(r_MakeByRefType == null)
				{
					r_MakeByRefType = new(this, "MakeByRefType", 0);
					r_MakeByRefType.SetBelong(this.instance);
				}
				return r_MakeByRefType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type[])
		/// </summary>
		protected RMethod r_MakeGenericType_TypeArray;
		public virtual RMethod RMakeGenericType_TypeArray
		{
			get
			{
				if(r_MakeGenericType_TypeArray == null)
				{
					r_MakeGenericType_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type).MakeArrayType());
					r_MakeGenericType_TypeArray.SetBelong(this.instance);
				}
				return r_MakeGenericType_TypeArray;
			}
		}

		/// <summary>
		/// System.Type MakePointerType()
		/// </summary>
		protected RMethod r_MakePointerType;
		public virtual RMethod RMakePointerType
		{
			get
			{
				if(r_MakePointerType == null)
				{
					r_MakePointerType = new(this, "MakePointerType", 0);
					r_MakePointerType.SetBelong(this.instance);
				}
				return r_MakePointerType;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_SetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_SetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_SetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_SetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_SetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_SetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_SetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_SetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_SetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_SetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EventBuilder DefineEvent(System.String, System.Reflection.EventAttributes, System.Type)
		/// </summary>
		protected RMethod r_DefineEvent_String_EventAttributes_Type;
		public virtual RMethod RDefineEvent_String_EventAttributes_Type
		{
			get
			{
				if(r_DefineEvent_String_EventAttributes_Type == null)
				{
					r_DefineEvent_String_EventAttributes_Type = new(this, "DefineEvent", 0, typeof(System.String), typeof(System.Reflection.EventAttributes), typeof(System.Type));
					r_DefineEvent_String_EventAttributes_Type.SetBelong(this.instance);
				}
				return r_DefineEvent_String_EventAttributes_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineInitializedData(System.String, Byte[], System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_DefineInitializedData_String_ByteArray_FieldAttributes;
		public virtual RMethod RDefineInitializedData_String_ByteArray_FieldAttributes
		{
			get
			{
				if(r_DefineInitializedData_String_ByteArray_FieldAttributes == null)
				{
					r_DefineInitializedData_String_ByteArray_FieldAttributes = new(this, "DefineInitializedData", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Reflection.FieldAttributes));
					r_DefineInitializedData_String_ByteArray_FieldAttributes.SetBelong(this.instance);
				}
				return r_DefineInitializedData_String_ByteArray_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineUninitializedData(System.String, Int32, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_DefineUninitializedData_String_Int32_FieldAttributes;
		public virtual RMethod RDefineUninitializedData_String_Int32_FieldAttributes
		{
			get
			{
				if(r_DefineUninitializedData_String_Int32_FieldAttributes == null)
				{
					r_DefineUninitializedData_String_Int32_FieldAttributes = new(this, "DefineUninitializedData", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.FieldAttributes));
					r_DefineUninitializedData_String_Int32_FieldAttributes.SetBelong(this.instance);
				}
				return r_DefineUninitializedData_String_Int32_FieldAttributes;
			}
		}

		/// <summary>
		/// Void SetParent(System.Type)
		/// </summary>
		protected RMethod r_SetParent_Type;
		public virtual RMethod RSetParent_Type
		{
			get
			{
				if(r_SetParent_Type == null)
				{
					r_SetParent_Type = new(this, "SetParent", 0, typeof(System.Type));
					r_SetParent_Type.SetBelong(this.instance);
				}
				return r_SetParent_Type;
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
		/// System.Reflection.InterfaceMapping GetInterfaceMap(System.Type)
		/// </summary>
		protected RMethod r_GetInterfaceMap_Type;
		public virtual RMethod RGetInterfaceMap_Type
		{
			get
			{
				if(r_GetInterfaceMap_Type == null)
				{
					r_GetInterfaceMap_Type = new(this, "GetInterfaceMap", 0, typeof(System.Type));
					r_GetInterfaceMap_Type.SetBelong(this.instance);
				}
				return r_GetInterfaceMap_Type;
			}
		}

		/// <summary>
		/// System.Type InternalResolve()
		/// </summary>
		protected RMethod r_InternalResolve;
		public virtual RMethod RInternalResolve
		{
			get
			{
				if(r_InternalResolve == null)
				{
					r_InternalResolve = new(this, "InternalResolve", 0);
					r_InternalResolve.SetBelong(this.instance);
				}
				return r_InternalResolve;
			}
		}

		/// <summary>
		/// System.Type RuntimeResolve()
		/// </summary>
		protected RMethod r_RuntimeResolve;
		public virtual RMethod RRuntimeResolve
		{
			get
			{
				if(r_RuntimeResolve == null)
				{
					r_RuntimeResolve = new(this, "RuntimeResolve", 0);
					r_RuntimeResolve.SetBelong(this.instance);
				}
				return r_RuntimeResolve;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_not_supported;
		public virtual RMethod Rnot_supported
		{
			get
			{
				if(r_not_supported == null)
				{
					r_not_supported = new(this, "not_supported", 0);
					r_not_supported.SetBelong(this.instance);
				}
				return r_not_supported;
			}
		}

		/// <summary>
		/// Void check_not_created()
		/// </summary>
		protected RMethod r_check_not_created;
		public virtual RMethod Rcheck_not_created
		{
			get
			{
				if(r_check_not_created == null)
				{
					r_check_not_created = new(this, "check_not_created", 0);
					r_check_not_created.SetBelong(this.instance);
				}
				return r_check_not_created;
			}
		}

		/// <summary>
		/// Void check_created()
		/// </summary>
		protected RMethod r_check_created;
		public virtual RMethod Rcheck_created
		{
			get
			{
				if(r_check_created == null)
				{
					r_check_created = new(this, "check_created", 0);
					r_check_created.SetBelong(this.instance);
				}
				return r_check_created;
			}
		}

		/// <summary>
		/// Void check_name(System.String, System.String)
		/// </summary>
		protected RMethod r_check_name_String_String;
		public virtual RMethod Rcheck_name_String_String
		{
			get
			{
				if(r_check_name_String_String == null)
				{
					r_check_name_String_String = new(this, "check_name", 0, typeof(System.String), typeof(System.String));
					r_check_name_String_String.SetBelong(this.instance);
				}
				return r_check_name_String_String;
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
		/// Boolean IsAssignableFrom(System.Type)
		/// </summary>
		protected RMethod r_IsAssignableFrom_Type;
		public virtual RMethod RIsAssignableFrom_Type
		{
			get
			{
				if(r_IsAssignableFrom_Type == null)
				{
					r_IsAssignableFrom_Type = new(this, "IsAssignableFrom", 0, typeof(System.Type));
					r_IsAssignableFrom_Type.SetBelong(this.instance);
				}
				return r_IsAssignableFrom_Type;
			}
		}

		/// <summary>
		/// Boolean IsAssignableTo(System.Type)
		/// </summary>
		protected RMethod r_IsAssignableTo_Type;
		public virtual RMethod RIsAssignableTo_Type
		{
			get
			{
				if(r_IsAssignableTo_Type == null)
				{
					r_IsAssignableTo_Type = new(this, "IsAssignableTo", 0, typeof(System.Type));
					r_IsAssignableTo_Type.SetBelong(this.instance);
				}
				return r_IsAssignableTo_Type;
			}
		}

		/// <summary>
		/// Boolean IsCreated()
		/// </summary>
		protected RMethod r_IsCreated;
		public virtual RMethod RIsCreated
		{
			get
			{
				if(r_IsCreated == null)
				{
					r_IsCreated = new(this, "IsCreated", 0);
					r_IsCreated.SetBelong(this.instance);
				}
				return r_IsCreated;
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
		/// System.Type GetGenericTypeDefinition()
		/// </summary>
		protected RMethod r_GetGenericTypeDefinition;
		public virtual RMethod RGetGenericTypeDefinition
		{
			get
			{
				if(r_GetGenericTypeDefinition == null)
				{
					r_GetGenericTypeDefinition = new(this, "GetGenericTypeDefinition", 0);
					r_GetGenericTypeDefinition.SetBelong(this.instance);
				}
				return r_GetGenericTypeDefinition;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(System.String[])
		/// </summary>
		protected RMethod r_DefineGenericParameters_StringArray;
		public virtual RMethod RDefineGenericParameters_StringArray
		{
			get
			{
				if(r_DefineGenericParameters_StringArray == null)
				{
					r_DefineGenericParameters_StringArray = new(this, "DefineGenericParameters", 0, typeof(System.String).MakeArrayType());
					r_DefineGenericParameters_StringArray.SetBelong(this.instance);
				}
				return r_DefineGenericParameters_StringArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type, System.Reflection.ConstructorInfo)
		/// </summary>
		protected static RMethod r_GetConstructor_Type_ConstructorInfo;
		public static RMethod RGetConstructor_Type_ConstructorInfo
		{
			get
			{
				if(r_GetConstructor_Type_ConstructorInfo == null)
				{
					r_GetConstructor_Type_ConstructorInfo = new(typeof(System.Reflection.Emit.TypeBuilder), "GetConstructor", 0, typeof(System.Type), typeof(System.Reflection.ConstructorInfo));
					r_GetConstructor_Type_ConstructorInfo.SetBelong(null);
				}
				return r_GetConstructor_Type_ConstructorInfo;
			}
		}

		/// <summary>
		/// Boolean IsValidGetMethodType(System.Type)
		/// </summary>
		protected static RMethod r_IsValidGetMethodType_Type;
		public static RMethod RIsValidGetMethodType_Type
		{
			get
			{
				if(r_IsValidGetMethodType_Type == null)
				{
					r_IsValidGetMethodType_Type = new(typeof(System.Reflection.Emit.TypeBuilder), "IsValidGetMethodType", 0, typeof(System.Type));
					r_IsValidGetMethodType_Type.SetBelong(null);
				}
				return r_IsValidGetMethodType_Type;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.Type, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_GetMethod_Type_MethodInfo;
		public static RMethod RGetMethod_Type_MethodInfo
		{
			get
			{
				if(r_GetMethod_Type_MethodInfo == null)
				{
					r_GetMethod_Type_MethodInfo = new(typeof(System.Reflection.Emit.TypeBuilder), "GetMethod", 0, typeof(System.Type), typeof(System.Reflection.MethodInfo));
					r_GetMethod_Type_MethodInfo.SetBelong(null);
				}
				return r_GetMethod_Type_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.Type, System.Reflection.FieldInfo)
		/// </summary>
		protected static RMethod r_GetField_Type_FieldInfo;
		public static RMethod RGetField_Type_FieldInfo
		{
			get
			{
				if(r_GetField_Type_FieldInfo == null)
				{
					r_GetField_Type_FieldInfo = new(typeof(System.Reflection.Emit.TypeBuilder), "GetField", 0, typeof(System.Type), typeof(System.Reflection.FieldInfo));
					r_GetField_Type_FieldInfo.SetBelong(null);
				}
				return r_GetField_Type_FieldInfo;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Reflection.TypeInfo)
		/// </summary>
		protected RMethod r_IsAssignableFrom_TypeInfo;
		public virtual RMethod RIsAssignableFrom_TypeInfo
		{
			get
			{
				if(r_IsAssignableFrom_TypeInfo == null)
				{
					r_IsAssignableFrom_TypeInfo = new(this, "IsAssignableFrom", 0, typeof(System.Reflection.TypeInfo));
					r_IsAssignableFrom_TypeInfo.SetBelong(this.instance);
				}
				return r_IsAssignableFrom_TypeInfo;
			}
		}

		/// <summary>
		/// Boolean SetConstantValue(System.Type, System.Object, System.Object ByRef)
		/// </summary>
		protected static RMethod r_SetConstantValue_Type_Object_Ref_Object;
		public static RMethod RSetConstantValue_Type_Object_Ref_Object
		{
			get
			{
				if(r_SetConstantValue_Type_Object_Ref_Object == null)
				{
					r_SetConstantValue_Type_Object_Ref_Object = new(typeof(System.Reflection.Emit.TypeBuilder), "SetConstantValue", 0, typeof(System.Type), typeof(System.Object), typeof(System.Object).MakeByRefType());
					r_SetConstantValue_Type_Object_Ref_Object.SetBelong(null);
				}
				return r_SetConstantValue_Type_Object_Ref_Object;
			}
		}

		/// <summary>
		/// Void throw_argument_ConstantDoesntMatch()
		/// </summary>
		protected static RMethod r_throw_argument_ConstantDoesntMatch;
		public static RMethod Rthrow_argument_ConstantDoesntMatch
		{
			get
			{
				if(r_throw_argument_ConstantDoesntMatch == null)
				{
					r_throw_argument_ConstantDoesntMatch = new(typeof(System.Reflection.Emit.TypeBuilder), "throw_argument_ConstantDoesntMatch", 0);
					r_throw_argument_ConstantDoesntMatch.SetBelong(null);
				}
				return r_throw_argument_ConstantDoesntMatch;
			}
		}

		/// <summary>
		/// System.Type AsType()
		/// </summary>
		protected RMethod r_AsType;
		public virtual RMethod RAsType
		{
			get
			{
				if(r_AsType == null)
				{
					r_AsType = new(this, "AsType", 0);
					r_AsType.SetBelong(this.instance);
				}
				return r_AsType;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetDeclaredEvent(System.String)
		/// </summary>
		protected RMethod r_GetDeclaredEvent_String;
		public virtual RMethod RGetDeclaredEvent_String
		{
			get
			{
				if(r_GetDeclaredEvent_String == null)
				{
					r_GetDeclaredEvent_String = new(this, "GetDeclaredEvent", 0, typeof(System.String));
					r_GetDeclaredEvent_String.SetBelong(this.instance);
				}
				return r_GetDeclaredEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetDeclaredField(System.String)
		/// </summary>
		protected RMethod r_GetDeclaredField_String;
		public virtual RMethod RGetDeclaredField_String
		{
			get
			{
				if(r_GetDeclaredField_String == null)
				{
					r_GetDeclaredField_String = new(this, "GetDeclaredField", 0, typeof(System.String));
					r_GetDeclaredField_String.SetBelong(this.instance);
				}
				return r_GetDeclaredField_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetDeclaredMethod(System.String)
		/// </summary>
		protected RMethod r_GetDeclaredMethod_String;
		public virtual RMethod RGetDeclaredMethod_String
		{
			get
			{
				if(r_GetDeclaredMethod_String == null)
				{
					r_GetDeclaredMethod_String = new(this, "GetDeclaredMethod", 0, typeof(System.String));
					r_GetDeclaredMethod_String.SetBelong(this.instance);
				}
				return r_GetDeclaredMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.TypeInfo GetDeclaredNestedType(System.String)
		/// </summary>
		protected RMethod r_GetDeclaredNestedType_String;
		public virtual RMethod RGetDeclaredNestedType_String
		{
			get
			{
				if(r_GetDeclaredNestedType_String == null)
				{
					r_GetDeclaredNestedType_String = new(this, "GetDeclaredNestedType", 0, typeof(System.String));
					r_GetDeclaredNestedType_String.SetBelong(this.instance);
				}
				return r_GetDeclaredNestedType_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetDeclaredProperty(System.String)
		/// </summary>
		protected RMethod r_GetDeclaredProperty_String;
		public virtual RMethod RGetDeclaredProperty_String
		{
			get
			{
				if(r_GetDeclaredProperty_String == null)
				{
					r_GetDeclaredProperty_String = new(this, "GetDeclaredProperty", 0, typeof(System.String));
					r_GetDeclaredProperty_String.SetBelong(this.instance);
				}
				return r_GetDeclaredProperty_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MethodInfo] GetDeclaredMethods(System.String)
		/// </summary>
		protected RMethod r_GetDeclaredMethods_String;
		public virtual RMethod RGetDeclaredMethods_String
		{
			get
			{
				if(r_GetDeclaredMethods_String == null)
				{
					r_GetDeclaredMethods_String = new(this, "GetDeclaredMethods", 0, typeof(System.String));
					r_GetDeclaredMethods_String.SetBelong(this.instance);
				}
				return r_GetDeclaredMethods_String;
			}
		}

		/// <summary>
		/// Boolean IsEnumDefined(System.Object)
		/// </summary>
		protected RMethod r_IsEnumDefined_Object;
		public virtual RMethod RIsEnumDefined_Object
		{
			get
			{
				if(r_IsEnumDefined_Object == null)
				{
					r_IsEnumDefined_Object = new(this, "IsEnumDefined", 0, typeof(System.Object));
					r_IsEnumDefined_Object.SetBelong(this.instance);
				}
				return r_IsEnumDefined_Object;
			}
		}

		/// <summary>
		/// System.String GetEnumName(System.Object)
		/// </summary>
		protected RMethod r_GetEnumName_Object;
		public virtual RMethod RGetEnumName_Object
		{
			get
			{
				if(r_GetEnumName_Object == null)
				{
					r_GetEnumName_Object = new(this, "GetEnumName", 0, typeof(System.Object));
					r_GetEnumName_Object.SetBelong(this.instance);
				}
				return r_GetEnumName_Object;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNames()
		/// </summary>
		protected RMethod r_GetEnumNames;
		public virtual RMethod RGetEnumNames
		{
			get
			{
				if(r_GetEnumNames == null)
				{
					r_GetEnumNames = new(this, "GetEnumNames", 0);
					r_GetEnumNames.SetBelong(this.instance);
				}
				return r_GetEnumNames;
			}
		}

		/// <summary>
		/// System.Type GetRootElementType()
		/// </summary>
		protected RMethod r_GetRootElementType;
		public virtual RMethod RGetRootElementType
		{
			get
			{
				if(r_GetRootElementType == null)
				{
					r_GetRootElementType = new(this, "GetRootElementType", 0);
					r_GetRootElementType.SetBelong(this.instance);
				}
				return r_GetRootElementType;
			}
		}

		/// <summary>
		/// System.Type[] FindInterfaces(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_FindInterfaces_TypeFilter_Object;
		public virtual RMethod RFindInterfaces_TypeFilter_Object
		{
			get
			{
				if(r_FindInterfaces_TypeFilter_Object == null)
				{
					r_FindInterfaces_TypeFilter_Object = new(this, "FindInterfaces", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_FindInterfaces_TypeFilter_Object.SetBelong(this.instance);
				}
				return r_FindInterfaces_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes, System.Reflection.BindingFlags, System.Reflection.MemberFilter, System.Object)
		/// </summary>
		protected RMethod r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
		public virtual RMethod RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object
		{
			get
			{
				if(r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object == null)
				{
					r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object = new(this, "FindMembers", 0, typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MemberFilter), typeof(System.Object));
					r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object.SetBelong(this.instance);
				}
				return r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
			}
		}

		/// <summary>
		/// Boolean ImplementInterface(System.Type)
		/// </summary>
		protected RMethod r_ImplementInterface_Type;
		public virtual RMethod RImplementInterface_Type
		{
			get
			{
				if(r_ImplementInterface_Type == null)
				{
					r_ImplementInterface_Type = new(this, "ImplementInterface", 0, typeof(System.Type));
					r_ImplementInterface_Type.SetBelong(this.instance);
				}
				return r_ImplementInterface_Type;
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
		/// Int32 GetArrayRank()
		/// </summary>
		protected RMethod r_GetArrayRank;
		public virtual RMethod RGetArrayRank
		{
			get
			{
				if(r_GetArrayRank == null)
				{
					r_GetArrayRank = new(this, "GetArrayRank", 0);
					r_GetArrayRank.SetBelong(this.instance);
				}
				return r_GetArrayRank;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericParameterConstraints()
		/// </summary>
		protected RMethod r_GetGenericParameterConstraints;
		public virtual RMethod RGetGenericParameterConstraints
		{
			get
			{
				if(r_GetGenericParameterConstraints == null)
				{
					r_GetGenericParameterConstraints = new(this, "GetGenericParameterConstraints", 0);
					r_GetGenericParameterConstraints.SetBelong(this.instance);
				}
				return r_GetGenericParameterConstraints;
			}
		}

		/// <summary>
		/// Boolean IsContextfulImpl()
		/// </summary>
		protected RMethod r_IsContextfulImpl;
		public virtual RMethod RIsContextfulImpl
		{
			get
			{
				if(r_IsContextfulImpl == null)
				{
					r_IsContextfulImpl = new(this, "IsContextfulImpl", 0);
					r_IsContextfulImpl.SetBelong(this.instance);
				}
				return r_IsContextfulImpl;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRefImpl()
		/// </summary>
		protected RMethod r_IsMarshalByRefImpl;
		public virtual RMethod RIsMarshalByRefImpl
		{
			get
			{
				if(r_IsMarshalByRefImpl == null)
				{
					r_IsMarshalByRefImpl = new(this, "IsMarshalByRefImpl", 0);
					r_IsMarshalByRefImpl.SetBelong(this.instance);
				}
				return r_IsMarshalByRefImpl;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type[])
		/// </summary>
		protected RMethod r_GetConstructor_TypeArray;
		public virtual RMethod RGetConstructor_TypeArray
		{
			get
			{
				if(r_GetConstructor_TypeArray == null)
				{
					r_GetConstructor_TypeArray = new(this, "GetConstructor", 0, typeof(System.Type).MakeArrayType());
					r_GetConstructor_TypeArray.SetBelong(this.instance);
				}
				return r_GetConstructor_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors()
		/// </summary>
		protected RMethod r_GetConstructors;
		public virtual RMethod RGetConstructors
		{
			get
			{
				if(r_GetConstructors == null)
				{
					r_GetConstructors = new(this, "GetConstructors", 0);
					r_GetConstructors.SetBelong(this.instance);
				}
				return r_GetConstructors;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String)
		/// </summary>
		protected RMethod r_GetEvent_String;
		public virtual RMethod RGetEvent_String
		{
			get
			{
				if(r_GetEvent_String == null)
				{
					r_GetEvent_String = new(this, "GetEvent", 0, typeof(System.String));
					r_GetEvent_String.SetBelong(this.instance);
				}
				return r_GetEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String)
		/// </summary>
		protected RMethod r_GetField_String;
		public virtual RMethod RGetField_String
		{
			get
			{
				if(r_GetField_String == null)
				{
					r_GetField_String = new(this, "GetField", 0, typeof(System.String));
					r_GetField_String.SetBelong(this.instance);
				}
				return r_GetField_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields()
		/// </summary>
		protected RMethod r_GetFields;
		public virtual RMethod RGetFields
		{
			get
			{
				if(r_GetFields == null)
				{
					r_GetFields = new(this, "GetFields", 0);
					r_GetFields.SetBelong(this.instance);
				}
				return r_GetFields;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String)
		/// </summary>
		protected RMethod r_GetMember_String;
		public virtual RMethod RGetMember_String
		{
			get
			{
				if(r_GetMember_String == null)
				{
					r_GetMember_String = new(this, "GetMember", 0, typeof(System.String));
					r_GetMember_String.SetBelong(this.instance);
				}
				return r_GetMember_String;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMember_String_BindingFlags;
		public virtual RMethod RGetMember_String_BindingFlags
		{
			get
			{
				if(r_GetMember_String_BindingFlags == null)
				{
					r_GetMember_String_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetMember_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMember_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers()
		/// </summary>
		protected RMethod r_GetMembers;
		public virtual RMethod RGetMembers
		{
			get
			{
				if(r_GetMembers == null)
				{
					r_GetMembers = new(this, "GetMembers", 0);
					r_GetMembers.SetBelong(this.instance);
				}
				return r_GetMembers;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String)
		/// </summary>
		protected RMethod r_GetMethod_String;
		public virtual RMethod RGetMethod_String
		{
			get
			{
				if(r_GetMethod_String == null)
				{
					r_GetMethod_String = new(this, "GetMethod", 0, typeof(System.String));
					r_GetMethod_String.SetBelong(this.instance);
				}
				return r_GetMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMethod_String_BindingFlags;
		public virtual RMethod RGetMethod_String_BindingFlags
		{
			get
			{
				if(r_GetMethod_String_BindingFlags == null)
				{
					r_GetMethod_String_BindingFlags = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetMethod_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMethod_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])
		/// </summary>
		protected RMethod r_GetMethod_String_TypeArray;
		public virtual RMethod RGetMethod_String_TypeArray
		{
			get
			{
				if(r_GetMethod_String_TypeArray == null)
				{
					r_GetMethod_String_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetMethod_String_TypeArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_TypeArray;
		public virtual RMethod RGetMethod_String_Int32_TypeArray
		{
			get
			{
				if(r_GetMethod_String_Int32_TypeArray == null)
				{
					r_GetMethod_String_Int32_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType());
					r_GetMethod_String_Int32_TypeArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_Int32_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_Int32_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_Int32_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods()
		/// </summary>
		protected RMethod r_GetMethods;
		public virtual RMethod RGetMethods
		{
			get
			{
				if(r_GetMethods == null)
				{
					r_GetMethods = new(this, "GetMethods", 0);
					r_GetMethods.SetBelong(this.instance);
				}
				return r_GetMethods;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String)
		/// </summary>
		protected RMethod r_GetNestedType_String;
		public virtual RMethod RGetNestedType_String
		{
			get
			{
				if(r_GetNestedType_String == null)
				{
					r_GetNestedType_String = new(this, "GetNestedType", 0, typeof(System.String));
					r_GetNestedType_String.SetBelong(this.instance);
				}
				return r_GetNestedType_String;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes()
		/// </summary>
		protected RMethod r_GetNestedTypes;
		public virtual RMethod RGetNestedTypes
		{
			get
			{
				if(r_GetNestedTypes == null)
				{
					r_GetNestedTypes = new(this, "GetNestedTypes", 0);
					r_GetNestedTypes.SetBelong(this.instance);
				}
				return r_GetNestedTypes;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String)
		/// </summary>
		protected RMethod r_GetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_GetProperty_String == null)
				{
					r_GetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_GetProperty_String.SetBelong(this.instance);
				}
				return r_GetProperty_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetProperty_String_BindingFlags;
		public virtual RMethod RGetProperty_String_BindingFlags
		{
			get
			{
				if(r_GetProperty_String_BindingFlags == null)
				{
					r_GetProperty_String_BindingFlags = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetProperty_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetProperty_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type)
		/// </summary>
		protected RMethod r_GetProperty_String_Type;
		public virtual RMethod RGetProperty_String_Type
		{
			get
			{
				if(r_GetProperty_String_Type == null)
				{
					r_GetProperty_String_Type = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type));
					r_GetProperty_String_Type.SetBelong(this.instance);
				}
				return r_GetProperty_String_Type;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type[])
		/// </summary>
		protected RMethod r_GetProperty_String_TypeArray;
		public virtual RMethod RGetProperty_String_TypeArray
		{
			get
			{
				if(r_GetProperty_String_TypeArray == null)
				{
					r_GetProperty_String_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetProperty_String_TypeArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_GetProperty_String_Type_TypeArray;
		public virtual RMethod RGetProperty_String_Type_TypeArray
		{
			get
			{
				if(r_GetProperty_String_Type_TypeArray == null)
				{
					r_GetProperty_String_Type_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_GetProperty_String_Type_TypeArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetProperty_String_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetProperty_String_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetProperty_String_Type_TypeArray_ParameterModifierArray == null)
				{
					r_GetProperty_String_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetProperty_String_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties()
		/// </summary>
		protected RMethod r_GetProperties;
		public virtual RMethod RGetProperties
		{
			get
			{
				if(r_GetProperties == null)
				{
					r_GetProperties = new(this, "GetProperties", 0);
					r_GetProperties.SetBelong(this.instance);
				}
				return r_GetProperties;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetDefaultMembers()
		/// </summary>
		protected RMethod r_GetDefaultMembers;
		public virtual RMethod RGetDefaultMembers
		{
			get
			{
				if(r_GetDefaultMembers == null)
				{
					r_GetDefaultMembers = new(this, "GetDefaultMembers", 0);
					r_GetDefaultMembers.SetBelong(this.instance);
				}
				return r_GetDefaultMembers;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCodeImpl()
		/// </summary>
		protected RMethod r_GetTypeCodeImpl;
		public virtual RMethod RGetTypeCodeImpl
		{
			get
			{
				if(r_GetTypeCodeImpl == null)
				{
					r_GetTypeCodeImpl = new(this, "GetTypeCodeImpl", 0);
					r_GetTypeCodeImpl.SetBelong(this.instance);
				}
				return r_GetTypeCodeImpl;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray
		{
			get
			{
				if(r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray == null)
				{
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo
		{
			get
			{
				if(r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo == null)
				{
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String)
		/// </summary>
		protected RMethod r_GetInterface_String;
		public virtual RMethod RGetInterface_String
		{
			get
			{
				if(r_GetInterface_String == null)
				{
					r_GetInterface_String = new(this, "GetInterface", 0, typeof(System.String));
					r_GetInterface_String.SetBelong(this.instance);
				}
				return r_GetInterface_String;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.Object)
		/// </summary>
		protected RMethod r_IsInstanceOfType_Object;
		public virtual RMethod RIsInstanceOfType_Object
		{
			get
			{
				if(r_IsInstanceOfType_Object == null)
				{
					r_IsInstanceOfType_Object = new(this, "IsInstanceOfType", 0, typeof(System.Object));
					r_IsInstanceOfType_Object.SetBelong(this.instance);
				}
				return r_IsInstanceOfType_Object;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.Type)
		/// </summary>
		protected RMethod r_IsEquivalentTo_Type;
		public virtual RMethod RIsEquivalentTo_Type
		{
			get
			{
				if(r_IsEquivalentTo_Type == null)
				{
					r_IsEquivalentTo_Type = new(this, "IsEquivalentTo", 0, typeof(System.Type));
					r_IsEquivalentTo_Type.SetBelong(this.instance);
				}
				return r_IsEquivalentTo_Type;
			}
		}

		/// <summary>
		/// System.Type GetEnumUnderlyingType()
		/// </summary>
		protected RMethod r_GetEnumUnderlyingType;
		public virtual RMethod RGetEnumUnderlyingType
		{
			get
			{
				if(r_GetEnumUnderlyingType == null)
				{
					r_GetEnumUnderlyingType = new(this, "GetEnumUnderlyingType", 0);
					r_GetEnumUnderlyingType.SetBelong(this.instance);
				}
				return r_GetEnumUnderlyingType;
			}
		}

		/// <summary>
		/// System.Array GetEnumValues()
		/// </summary>
		protected RMethod r_GetEnumValues;
		public virtual RMethod RGetEnumValues
		{
			get
			{
				if(r_GetEnumValues == null)
				{
					r_GetEnumValues = new(this, "GetEnumValues", 0);
					r_GetEnumValues.SetBelong(this.instance);
				}
				return r_GetEnumValues;
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
		/// Boolean Equals(System.Type)
		/// </summary>
		protected RMethod r_Equals_Type;
		public virtual RMethod REquals_Type
		{
			get
			{
				if(r_Equals_Type == null)
				{
					r_Equals_Type = new(this, "Equals", 0, typeof(System.Type));
					r_Equals_Type.SetBelong(this.instance);
				}
				return r_Equals_Type;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_GetMethod_MethodInfo;
		public virtual RMethod RGetMethod_MethodInfo
		{
			get
			{
				if(r_GetMethod_MethodInfo == null)
				{
					r_GetMethod_MethodInfo = new(this, "GetMethod", 0, typeof(System.Reflection.MethodInfo));
					r_GetMethod_MethodInfo.SetBelong(this.instance);
				}
				return r_GetMethod_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_GetConstructor_ConstructorInfo;
		public virtual RMethod RGetConstructor_ConstructorInfo
		{
			get
			{
				if(r_GetConstructor_ConstructorInfo == null)
				{
					r_GetConstructor_ConstructorInfo = new(this, "GetConstructor", 0, typeof(System.Reflection.ConstructorInfo));
					r_GetConstructor_ConstructorInfo.SetBelong(this.instance);
				}
				return r_GetConstructor_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_GetField_FieldInfo;
		public virtual RMethod RGetField_FieldInfo
		{
			get
			{
				if(r_GetField_FieldInfo == null)
				{
					r_GetField_FieldInfo = new(this, "GetField", 0, typeof(System.Reflection.FieldInfo));
					r_GetField_FieldInfo.SetBelong(this.instance);
				}
				return r_GetField_FieldInfo;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandleInternal()
		/// </summary>
		protected RMethod r_GetTypeHandleInternal;
		public virtual RMethod RGetTypeHandleInternal
		{
			get
			{
				if(r_GetTypeHandleInternal == null)
				{
					r_GetTypeHandleInternal = new(this, "GetTypeHandleInternal", 0);
					r_GetTypeHandleInternal.SetBelong(this.instance);
				}
				return r_GetTypeHandleInternal;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObjectImpl()
		/// </summary>
		protected RMethod r_IsWindowsRuntimeObjectImpl;
		public virtual RMethod RIsWindowsRuntimeObjectImpl
		{
			get
			{
				if(r_IsWindowsRuntimeObjectImpl == null)
				{
					r_IsWindowsRuntimeObjectImpl = new(this, "IsWindowsRuntimeObjectImpl", 0);
					r_IsWindowsRuntimeObjectImpl.SetBelong(this.instance);
				}
				return r_IsWindowsRuntimeObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntimeImpl()
		/// </summary>
		protected RMethod r_IsExportedToWindowsRuntimeImpl;
		public virtual RMethod RIsExportedToWindowsRuntimeImpl
		{
			get
			{
				if(r_IsExportedToWindowsRuntimeImpl == null)
				{
					r_IsExportedToWindowsRuntimeImpl = new(this, "IsExportedToWindowsRuntimeImpl", 0);
					r_IsExportedToWindowsRuntimeImpl.SetBelong(this.instance);
				}
				return r_IsExportedToWindowsRuntimeImpl;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttributeImpl()
		/// </summary>
		protected RMethod r_HasProxyAttributeImpl;
		public virtual RMethod RHasProxyAttributeImpl
		{
			get
			{
				if(r_HasProxyAttributeImpl == null)
				{
					r_HasProxyAttributeImpl = new(this, "HasProxyAttributeImpl", 0);
					r_HasProxyAttributeImpl.SetBelong(this.instance);
				}
				return r_HasProxyAttributeImpl;
			}
		}

		/// <summary>
		/// System.String FormatTypeName()
		/// </summary>
		protected RMethod r_FormatTypeName;
		public virtual RMethod RFormatTypeName
		{
			get
			{
				if(r_FormatTypeName == null)
				{
					r_FormatTypeName = new(this, "FormatTypeName", 0);
					r_FormatTypeName.SetBelong(this.instance);
				}
				return r_FormatTypeName;
			}
		}

		/// <summary>
		/// System.String FormatTypeName(Boolean)
		/// </summary>
		protected RMethod r_FormatTypeName_Boolean;
		public virtual RMethod RFormatTypeName_Boolean
		{
			get
			{
				if(r_FormatTypeName_Boolean == null)
				{
					r_FormatTypeName_Boolean = new(this, "FormatTypeName", 0, typeof(System.Boolean));
					r_FormatTypeName_Boolean.SetBelong(this.instance);
				}
				return r_FormatTypeName_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsRuntimeImplemented()
		/// </summary>
		protected RMethod r_IsRuntimeImplemented;
		public virtual RMethod RIsRuntimeImplemented
		{
			get
			{
				if(r_IsRuntimeImplemented == null)
				{
					r_IsRuntimeImplemented = new(this, "IsRuntimeImplemented", 0);
					r_IsRuntimeImplemented.SetBelong(this.instance);
				}
				return r_IsRuntimeImplemented;
			}
		}

		/// <summary>
		/// System.String InternalGetNameIfAvailable(System.Type ByRef)
		/// </summary>
		protected RMethod r_InternalGetNameIfAvailable_Ref_Type;
		public virtual RMethod RInternalGetNameIfAvailable_Ref_Type
		{
			get
			{
				if(r_InternalGetNameIfAvailable_Ref_Type == null)
				{
					r_InternalGetNameIfAvailable_Ref_Type = new(this, "InternalGetNameIfAvailable", 0, typeof(System.Type).MakeByRefType());
					r_InternalGetNameIfAvailable_Ref_Type.SetBelong(this.instance);
				}
				return r_InternalGetNameIfAvailable_Ref_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Module get_Module()
		/// </summary>
		protected RMethod r_get_Module;
		public virtual RMethod Rget_Module
		{
			get
			{
				if(r_get_Module == null)
				{
					r_get_Module = new(this, "get_Module", 0);
					r_get_Module.SetBelong(this.instance);
				}
				return r_get_Module;
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


        public RTypeBuilder() : base("System.Reflection.Emit.TypeBuilder")
        {
        }

        public RTypeBuilder(System.Object instance) : base("System.Reflection.Emit.TypeBuilder")
		{
            SetInstance(instance);
		}

        public RTypeBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___TypeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttributeFlagsImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeAttributes)___result;
        }


        public virtual System.Boolean IsSubclassOf(System.Type @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSubclassOf_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual RSystem.RTypeName GetFullName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFullName.Invoke(___genericsType, ___parameters);

            return new RSystem.RTypeName(___result);
        }


        public virtual void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction @action, System.Security.PermissionSet @pset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @pset};
            var ___result = RAddDeclarativeSecurity_SecurityAction_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInterfaceImplementation(System.Type @interfaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@interfaceType};
            var ___result = RAddInterfaceImplementation_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RDefineNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr};
            var ___result = RDefineNestedType_String_TypeAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent};
            var ___result = RDefineNestedType_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Type[] @interfaces, System.Reflection.Emit.PackingSize @packSize, System.Int32 @typeSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces, @packSize, @typeSize};
            var ___result = RDefineNestedType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Type[] @interfaces)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces};
            var ___result = RDefineNestedType_String_TypeAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Int32 @typeSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @typeSize};
            var ___result = RDefineNestedType_String_TypeAttributes_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Reflection.Emit.PackingSize @packSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packSize};
            var ___result = RDefineNestedType_String_TypeAttributes_Type_PackingSize.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineNestedType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Reflection.Emit.PackingSize @packSize, System.Int32 @typeSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packSize, @typeSize};
            var ___result = RDefineNestedType_String_TypeAttributes_Type_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes, @callingConvention, @parameterTypes};
            var ___result = RDefineConstructor_MethodAttributes_CallingConventions_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ConstructorBuilder)___result;
        }


        public virtual System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type[] @parameterTypes, System.Type[][] @requiredCustomModifiers, System.Type[][] @optionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes, @callingConvention, @parameterTypes, @requiredCustomModifiers, @optionalCustomModifiers};
            var ___result = RDefineConstructor_MethodAttributes_CallingConventions_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ConstructorBuilder)___result;
        }


        public virtual System.Reflection.Emit.ConstructorBuilder DefineDefaultConstructor(System.Reflection.MethodAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RDefineDefaultConstructor_MethodAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ConstructorBuilder)___result;
        }


        public virtual void append_method(System.Reflection.Emit.MethodBuilder @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = Rappend_method_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @returnType, @parameterTypes};
            var ___result = RDefineMethod_String_MethodAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @parameterTypes};
            var ___result = RDefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @returnTypeRequiredCustomModifiers, System.Type[] @returnTypeOptionalCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @parameterTypeRequiredCustomModifiers, System.Type[][] @parameterTypeOptionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @returnTypeRequiredCustomModifiers, @returnTypeOptionalCustomModifiers, @parameterTypes, @parameterTypeRequiredCustomModifiers, @parameterTypeOptionalCustomModifiers};
            var ___result = RDefineMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.String @entryName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @entryName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.String @entryName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @returnTypeRequiredCustomModifiers, System.Type[] @returnTypeOptionalCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @parameterTypeRequiredCustomModifiers, System.Type[][] @parameterTypeOptionalCustomModifiers, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @entryName, @attributes, @callingConvention, @returnType, @returnTypeRequiredCustomModifiers, @returnTypeOptionalCustomModifiers, @parameterTypes, @parameterTypeRequiredCustomModifiers, @parameterTypeOptionalCustomModifiers, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineMethod(System.String @name, System.Reflection.MethodAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes};
            var ___result = RDefineMethod_String_MethodAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention};
            var ___result = RDefineMethod_String_MethodAttributes_CallingConventions.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual void DefineMethodOverride(System.Reflection.MethodInfo @methodInfoBody, System.Reflection.MethodInfo @methodInfoDeclaration)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodInfoBody, @methodInfoDeclaration};
            var ___result = RDefineMethodOverride_MethodInfo_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineField(System.String @fieldName, System.Type @type, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @type, @attributes};
            var ___result = RDefineField_String_Type_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineField(System.String @fieldName, System.Type @type, System.Type[] @requiredCustomModifiers, System.Type[] @optionalCustomModifiers, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldName, @type, @requiredCustomModifiers, @optionalCustomModifiers, @attributes};
            var ___result = RDefineField_String_Type_TypeArray_TypeArray_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.PropertyBuilder DefineProperty(System.String @name, System.Reflection.PropertyAttributes @attributes, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @returnType, @parameterTypes};
            var ___result = RDefineProperty_String_PropertyAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.PropertyBuilder)___result;
        }


        public virtual System.Reflection.Emit.PropertyBuilder DefineProperty(System.String @name, System.Reflection.PropertyAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @parameterTypes};
            var ___result = RDefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.PropertyBuilder)___result;
        }


        public virtual System.Reflection.Emit.PropertyBuilder DefineProperty(System.String @name, System.Reflection.PropertyAttributes @attributes, System.Type @returnType, System.Type[] @returnTypeRequiredCustomModifiers, System.Type[] @returnTypeOptionalCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @parameterTypeRequiredCustomModifiers, System.Type[][] @parameterTypeOptionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @returnType, @returnTypeRequiredCustomModifiers, @returnTypeOptionalCustomModifiers, @parameterTypes, @parameterTypeRequiredCustomModifiers, @parameterTypeOptionalCustomModifiers};
            var ___result = RDefineProperty_String_PropertyAttributes_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.PropertyBuilder)___result;
        }


        public virtual System.Reflection.Emit.PropertyBuilder DefineProperty(System.String @name, System.Reflection.PropertyAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @returnTypeRequiredCustomModifiers, System.Type[] @returnTypeOptionalCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @parameterTypeRequiredCustomModifiers, System.Type[][] @parameterTypeOptionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @returnTypeRequiredCustomModifiers, @returnTypeOptionalCustomModifiers, @parameterTypes, @parameterTypeRequiredCustomModifiers, @parameterTypeOptionalCustomModifiers};
            var ___result = RDefineProperty_String_PropertyAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.PropertyBuilder)___result;
        }


        public virtual System.Reflection.Emit.ConstructorBuilder DefineTypeInitializer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDefineTypeInitializer.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ConstructorBuilder)___result;
        }


        public virtual System.Reflection.TypeInfo create_runtime_class()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rcreate_runtime_class.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeInfo)___result;
        }


        public virtual System.Boolean is_nested_in(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = Ris_nested_in_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean has_ctor_method()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rhas_ctor_method.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type CreateType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.TypeInfo CreateTypeInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateTypeInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeInfo)___result;
        }


        public virtual void ResolveUserTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveUserTypes.Invoke(___genericsType, ___parameters);

            
        }


        public static void ResolveUserTypes(System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RResolveUserTypes_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Type ResolveUserType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RResolveUserType_Type.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map};
            var ___result = RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter @symbolWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@symbolWriter};
            var ___result = RGenerateDebugInfo_ISymbolWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetConstructors_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructorsInternal(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetConstructorsInternal_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Type GetElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetEvent_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEvents.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetEvents_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Type GetInterface(System.String @name, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ignoreCase};
            var ___result = RGetInterface_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetInterfaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInterfaces.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name, System.Reflection.MemberTypes @type, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type, @bindingAttr};
            var ___result = RGetMember_String_MemberTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetMembers_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethodsByName(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Boolean @ignoreCase, System.Type @reflected_type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @ignoreCase, @reflected_type};
            var ___result = RGetMethodsByName_String_BindingFlags_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type GetNestedType(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetNestedType_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetNestedTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetProperties_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.PropertyInfo GetPropertyImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Boolean HasElementTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasElementTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args, System.Reflection.ParameterModifier[] @modifiers, System.Globalization.CultureInfo @culture, System.String[] @namedParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @modifiers, @culture, @namedParameters};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsArrayImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsArrayImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCOMObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCOMObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPointerImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPointerImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrimitiveImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPrimitiveImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValueTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValueTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type MakeArrayType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeArrayType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeArrayType(System.Int32 @rank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rank};
            var ___result = RMakeArrayType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeByRefType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeByRefType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeGenericType(System.Type[] @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeArguments};
            var ___result = RMakeGenericType_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakePointerType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakePointerType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.EventBuilder DefineEvent(System.String @name, System.Reflection.EventAttributes @attributes, System.Type @eventtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @eventtype};
            var ___result = RDefineEvent_String_EventAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.EventBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineInitializedData(System.String @name, System.Byte[] @data, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data, @attributes};
            var ___result = RDefineInitializedData_String_ByteArray_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineUninitializedData(System.String @name, System.Int32 @size, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @attributes};
            var ___result = RDefineUninitializedData_String_Int32_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual void SetParent(System.Type @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent};
            var ___result = RSetParent_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type @interfaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@interfaceType};
            var ___result = RGetInterfaceMap_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.InterfaceMapping)___result;
        }


        public virtual System.Type InternalResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRuntimeResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_supported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void check_not_created()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rcheck_not_created.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void check_created()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rcheck_created.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void check_name(System.String @argName, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argName, @name};
            var ___result = Rcheck_name_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Type @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsAssignableFrom_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableTo(System.Type @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsAssignableTo_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCreated.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type GetGenericTypeDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericTypeDefinition.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(System.String[] @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RDefineGenericParameters_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.GenericTypeParameterBuilder[])___result;
        }


        public static System.Reflection.ConstructorInfo GetConstructor(System.Type @type, System.Reflection.ConstructorInfo @constructor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @constructor};
            var ___result = RGetConstructor_Type_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public static System.Boolean IsValidGetMethodType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RIsValidGetMethodType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Reflection.MethodInfo GetMethod(System.Type @type, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @method};
            var ___result = RGetMethod_Type_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public static System.Reflection.FieldInfo GetField(System.Type @type, System.Reflection.FieldInfo @field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @field};
            var ___result = RGetField_Type_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Reflection.TypeInfo @typeInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeInfo};
            var ___result = RIsAssignableFrom_TypeInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean SetConstantValue(System.Type @destType, System.Object @value, ref System.Object @destValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destType, @value, @destValue};
            var ___result = RSetConstantValue_Type_Object_Ref_Object.Invoke(___genericsType, ___parameters);
			@destValue = (System.Object)___parameters[2];

            return (System.Boolean)___result;
        }


        public static void throw_argument_ConstantDoesntMatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rthrow_argument_ConstantDoesntMatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type AsType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.EventInfo GetDeclaredEvent(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetDeclaredField(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetDeclaredMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.TypeInfo GetDeclaredNestedType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetDeclaredProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredMethods_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>)___result;
        }


        public virtual System.Boolean IsEnumDefined(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsEnumDefined_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetEnumName(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RGetEnumName_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] GetEnumNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Type GetRootElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRootElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] FindInterfaces(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RFindInterfaces_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes @memberType, System.Reflection.BindingFlags @bindingAttr, System.Reflection.MemberFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberType, @bindingAttr, @filter, @filterCriteria};
            var ___result = RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Boolean ImplementInterface(System.Type @ifaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ifaceType};
            var ___result = RImplementInterface_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 GetArrayRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetArrayRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type[] GetGenericParameterConstraints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericParameterConstraints.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Boolean IsContextfulImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsContextfulImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMarshalByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsMarshalByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RGetConstructor_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @types, @modifiers};
            var ___result = RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConstructors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name)
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


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMember_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetMember_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetMethod_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types, @modifiers};
            var ___result = RGetMethod_String_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types};
            var ___result = RGetMethod_String_Int32_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types, @modifiers};
            var ___result = RGetMethod_String_Int32_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Type GetNestedType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNestedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetProperty_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType};
            var ___result = RGetProperty_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RGetProperty_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types};
            var ___result = RGetProperty_String_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types, @modifiers};
            var ___result = RGetProperty_String_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProperties.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetDefaultMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.TypeCode GetTypeCodeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCodeImpl.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @culture};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetInterface(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInterface_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsInstanceOfType(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RIsInstanceOfType_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEquivalentTo(System.Type @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsEquivalentTo_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetEnumUnderlyingType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumUnderlyingType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Array GetEnumValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumValues.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
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


        public virtual System.Boolean Equals(System.Type @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RGetMethod_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RGetConstructor_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RGetField_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.RuntimeTypeHandle GetTypeHandleInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeHandleInternal.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.Boolean IsWindowsRuntimeObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsWindowsRuntimeObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsExportedToWindowsRuntimeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsExportedToWindowsRuntimeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProxyAttributeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasProxyAttributeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String FormatTypeName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFormatTypeName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String FormatTypeName(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RFormatTypeName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsRuntimeImplemented()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsRuntimeImplemented.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalGetNameIfAvailable(ref System.Type @rootCauseForFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootCauseForFailure};
            var ___result = RInternalGetNameIfAvailable_Ref_Type.Invoke(___genericsType, ___parameters);
			@rootCauseForFailure = (System.Type)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.Reflection.Module get_Module()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
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


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
