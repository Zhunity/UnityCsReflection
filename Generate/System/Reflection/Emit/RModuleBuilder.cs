using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ModuleBuilder
	/// </summary>
    public partial class RModuleBuilder : RMember //
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
		/// System.UIntPtr dynamic_image
		/// </summary>
		protected RField r_dynamic_image;
		public virtual RField Rdynamic_image
		{
			get
			{
				if(r_dynamic_image == null)
				{
					r_dynamic_image = new(this, "dynamic_image");
					r_dynamic_image.SetBelong(this.instance);
				}
				return r_dynamic_image;
			}
		}

		/// <summary>
		/// System.Int32 num_types
		/// </summary>
		protected RField r_num_types;
		public virtual RField Rnum_types
		{
			get
			{
				if(r_num_types == null)
				{
					r_num_types = new(this, "num_types");
					r_num_types.SetBelong(this.instance);
				}
				return r_num_types;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder[] types
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RTypeBuilder> r_types;
		public virtual RFieldArray<RSystem.RReflection.REmit.RTypeBuilder> Rtypes
		{
			get
			{
				if(r_types == null)
				{
					r_types = new(this, "types");
					r_types.SetBelong(this.instance);
				}
				return r_types;
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
		/// System.Byte[] guid
		/// </summary>
		protected RFieldArray<RField> r_guid;
		public virtual RFieldArray<RField> Rguid
		{
			get
			{
				if(r_guid == null)
				{
					r_guid = new(this, "guid");
					r_guid.SetBelong(this.instance);
				}
				return r_guid;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected RField r_table_idx;
		public virtual RField Rtable_idx
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
		/// System.Reflection.Emit.AssemblyBuilder assemblyb
		/// </summary>
		protected RSystem.RReflection.REmit.RAssemblyBuilder r_assemblyb;
		public virtual RSystem.RReflection.REmit.RAssemblyBuilder Rassemblyb
		{
			get
			{
				if(r_assemblyb == null)
				{
					r_assemblyb = new(this, "assemblyb");
					r_assemblyb.SetBelong(this.instance);
				}
				return r_assemblyb;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder[] global_methods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RMethodBuilder> r_global_methods;
		public virtual RFieldArray<RSystem.RReflection.REmit.RMethodBuilder> Rglobal_methods
		{
			get
			{
				if(r_global_methods == null)
				{
					r_global_methods = new(this, "global_methods");
					r_global_methods.SetBelong(this.instance);
				}
				return r_global_methods;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder[] global_fields
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RFieldBuilder> r_global_fields;
		public virtual RFieldArray<RSystem.RReflection.REmit.RFieldBuilder> Rglobal_fields
		{
			get
			{
				if(r_global_fields == null)
				{
					r_global_fields = new(this, "global_fields");
					r_global_fields.SetBelong(this.instance);
				}
				return r_global_fields;
			}
		}

		/// <summary>
		/// System.Boolean is_main
		/// </summary>
		protected RField r_is_main;
		public virtual RField Ris_main
		{
			get
			{
				if(r_is_main == null)
				{
					r_is_main = new(this, "is_main");
					r_is_main.SetBelong(this.instance);
				}
				return r_is_main;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MonoResource[] resources
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RMonoResource> r_resources;
		public virtual RFieldArray<RSystem.RReflection.REmit.RMonoResource> Rresources
		{
			get
			{
				if(r_resources == null)
				{
					r_resources = new(this, "resources");
					r_resources.SetBelong(this.instance);
				}
				return r_resources;
			}
		}

		/// <summary>
		/// System.IntPtr unparented_classes
		/// </summary>
		protected RField r_unparented_classes;
		public virtual RField Runparented_classes
		{
			get
			{
				if(r_unparented_classes == null)
				{
					r_unparented_classes = new(this, "unparented_classes");
					r_unparented_classes.SetBelong(this.instance);
				}
				return r_unparented_classes;
			}
		}

		/// <summary>
		/// System.Int32[] table_indexes
		/// </summary>
		protected RFieldArray<RField> r_table_indexes;
		public virtual RFieldArray<RField> Rtable_indexes
		{
			get
			{
				if(r_table_indexes == null)
				{
					r_table_indexes = new(this, "table_indexes");
					r_table_indexes.SetBelong(this.instance);
				}
				return r_table_indexes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder global_type
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeBuilder r_global_type;
		public virtual RSystem.RReflection.REmit.RTypeBuilder Rglobal_type
		{
			get
			{
				if(r_global_type == null)
				{
					r_global_type = new(this, "global_type");
					r_global_type.SetBelong(this.instance);
				}
				return r_global_type;
			}
		}

		/// <summary>
		/// System.Type global_type_created
		/// </summary>
		protected RSystem.RType r_global_type_created;
		public virtual RSystem.RType Rglobal_type_created
		{
			get
			{
				if(r_global_type_created == null)
				{
					r_global_type_created = new(this, "global_type_created");
					r_global_type_created.SetBelong(this.instance);
				}
				return r_global_type_created;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.TypeName,System.Reflection.Emit.TypeBuilder] name_cache
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RTypeName, RSystem.RReflection.REmit.RTypeBuilder> r_name_cache;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RTypeName, RSystem.RReflection.REmit.RTypeBuilder> Rname_cache
		{
			get
			{
				if(r_name_cache == null)
				{
					r_name_cache = new(this, "name_cache");
					r_name_cache.SetBelong(this.instance);
				}
				return r_name_cache;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] us_string_cache
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_us_string_cache;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rus_string_cache
		{
			get
			{
				if(r_us_string_cache == null)
				{
					r_us_string_cache = new(this, "us_string_cache");
					r_us_string_cache.SetBelong(this.instance);
				}
				return r_us_string_cache;
			}
		}

		/// <summary>
		/// System.Boolean transient
		/// </summary>
		protected RField r_transient;
		public virtual RField Rtransient
		{
			get
			{
				if(r_transient == null)
				{
					r_transient = new(this, "transient");
					r_transient.SetBelong(this.instance);
				}
				return r_transient;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilderTokenGenerator token_gen
		/// </summary>
		protected RSystem.RReflection.REmit.RModuleBuilderTokenGenerator r_token_gen;
		public virtual RSystem.RReflection.REmit.RModuleBuilderTokenGenerator Rtoken_gen
		{
			get
			{
				if(r_token_gen == null)
				{
					r_token_gen = new(this, "token_gen");
					r_token_gen.SetBelong(this.instance);
				}
				return r_token_gen;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable resource_writers
		/// </summary>
		protected RSystem.RCollections.RHashtable r_resource_writers;
		public virtual RSystem.RCollections.RHashtable Rresource_writers
		{
			get
			{
				if(r_resource_writers == null)
				{
					r_resource_writers = new(this, "resource_writers");
					r_resource_writers.SetBelong(this.instance);
				}
				return r_resource_writers;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolWriter symbolWriter
		/// </summary>
		protected RSystem.RDiagnostics.RSymbolStore.RISymbolWriter r_symbolWriter;
		public virtual RSystem.RDiagnostics.RSymbolStore.RISymbolWriter RsymbolWriter
		{
			get
			{
				if(r_symbolWriter == null)
				{
					r_symbolWriter = new(this, "symbolWriter");
					r_symbolWriter.SetBelong(this.instance);
				}
				return r_symbolWriter;
			}
		}

		/// <summary>
		/// System.Boolean has_warned_about_symbolWriter
		/// </summary>
		protected static RField r_has_warned_about_symbolWriter;
		public static RField Rhas_warned_about_symbolWriter
		{
			get
			{
				if(r_has_warned_about_symbolWriter == null)
				{
					r_has_warned_about_symbolWriter = new(typeof(System.Reflection.Emit.ModuleBuilder), "has_warned_about_symbolWriter");
					r_has_warned_about_symbolWriter.SetBelong(null);
				}
				return r_has_warned_about_symbolWriter;
			}
		}

		/// <summary>
		/// System.Int32 typeref_tokengen
		/// </summary>
		protected static RField r_typeref_tokengen;
		public static RField Rtyperef_tokengen
		{
			get
			{
				if(r_typeref_tokengen == null)
				{
					r_typeref_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "typeref_tokengen");
					r_typeref_tokengen.SetBelong(null);
				}
				return r_typeref_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 typedef_tokengen
		/// </summary>
		protected static RField r_typedef_tokengen;
		public static RField Rtypedef_tokengen
		{
			get
			{
				if(r_typedef_tokengen == null)
				{
					r_typedef_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "typedef_tokengen");
					r_typedef_tokengen.SetBelong(null);
				}
				return r_typedef_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 typespec_tokengen
		/// </summary>
		protected static RField r_typespec_tokengen;
		public static RField Rtypespec_tokengen
		{
			get
			{
				if(r_typespec_tokengen == null)
				{
					r_typespec_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "typespec_tokengen");
					r_typespec_tokengen.SetBelong(null);
				}
				return r_typespec_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 memberref_tokengen
		/// </summary>
		protected static RField r_memberref_tokengen;
		public static RField Rmemberref_tokengen
		{
			get
			{
				if(r_memberref_tokengen == null)
				{
					r_memberref_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "memberref_tokengen");
					r_memberref_tokengen.SetBelong(null);
				}
				return r_memberref_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 methoddef_tokengen
		/// </summary>
		protected static RField r_methoddef_tokengen;
		public static RField Rmethoddef_tokengen
		{
			get
			{
				if(r_methoddef_tokengen == null)
				{
					r_methoddef_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "methoddef_tokengen");
					r_methoddef_tokengen.SetBelong(null);
				}
				return r_methoddef_tokengen;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32] inst_tokens
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RReflection.RMemberInfo, RField> r_inst_tokens;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RReflection.RMemberInfo, RField> Rinst_tokens
		{
			get
			{
				if(r_inst_tokens == null)
				{
					r_inst_tokens = new(this, "inst_tokens");
					r_inst_tokens.SetBelong(this.instance);
				}
				return r_inst_tokens;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32] inst_tokens_open
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RReflection.RMemberInfo, RField> r_inst_tokens_open;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RReflection.RMemberInfo, RField> Rinst_tokens_open
		{
			get
			{
				if(r_inst_tokens_open == null)
				{
					r_inst_tokens_open = new(this, "inst_tokens_open");
					r_inst_tokens_open.SetBelong(this.instance);
				}
				return r_inst_tokens_open;
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
		/// System.String FileName
		/// </summary>
		protected RProperty r_FileName;
		public virtual RProperty RFileName
		{
			get
			{
				if(r_FileName == null)
				{
					r_FileName = new(this, "FileName", -1);
					r_FileName.SetBelong(this.instance);
				}
				return r_FileName;
			}
		}

		/// <summary>
		/// Boolean IsMain
		/// </summary>
		protected RProperty r_IsMain_Boolean;
		public virtual RProperty RIsMain_Boolean
		{
			get
			{
				if(r_IsMain_Boolean == null)
				{
					r_IsMain_Boolean = new(this, "IsMain", -1, typeof(System.Boolean));
					r_IsMain_Boolean.SetBelong(this.instance);
				}
				return r_IsMain_Boolean;
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
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void basic_init(System.Reflection.Emit.ModuleBuilder)
		/// </summary>
		protected static RMethod r_Rbasic_init_ModuleBuilder;
		public static RMethod Rbasic_init_ModuleBuilder
		{
			get
			{
				if(r_Rbasic_init_ModuleBuilder == null)
				{
					r_Rbasic_init_ModuleBuilder = new(typeof(System.Reflection.Emit.ModuleBuilder), "basic_init", 0, typeof(System.Reflection.Emit.ModuleBuilder));
					r_Rbasic_init_ModuleBuilder.SetBelong(null);
				}
				return r_Rbasic_init_ModuleBuilder;
			}
		}

		/// <summary>
		/// Void set_wrappers_type(System.Reflection.Emit.ModuleBuilder, System.Type)
		/// </summary>
		protected static RMethod r_Rset_wrappers_type_ModuleBuilder_Type;
		public static RMethod Rset_wrappers_type_ModuleBuilder_Type
		{
			get
			{
				if(r_Rset_wrappers_type_ModuleBuilder_Type == null)
				{
					r_Rset_wrappers_type_ModuleBuilder_Type = new(typeof(System.Reflection.Emit.ModuleBuilder), "set_wrappers_type", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Type));
					r_Rset_wrappers_type_ModuleBuilder_Type.SetBelong(null);
				}
				return r_Rset_wrappers_type_ModuleBuilder_Type;
			}
		}

		/// <summary>
		/// Void WarnAboutSymbolWriter(System.String)
		/// </summary>
		protected static RMethod r_RWarnAboutSymbolWriter_String;
		public static RMethod RWarnAboutSymbolWriter_String
		{
			get
			{
				if(r_RWarnAboutSymbolWriter_String == null)
				{
					r_RWarnAboutSymbolWriter_String = new(typeof(System.Reflection.Emit.ModuleBuilder), "WarnAboutSymbolWriter", 0, typeof(System.String));
					r_RWarnAboutSymbolWriter_String.SetBelong(null);
				}
				return r_RWarnAboutSymbolWriter_String;
			}
		}

		/// <summary>
		/// Boolean IsTransient()
		/// </summary>
		protected RMethod r_RIsTransient;
		public virtual RMethod RIsTransient
		{
			get
			{
				if(r_RIsTransient == null)
				{
					r_RIsTransient = new(this, "IsTransient", 0);
					r_RIsTransient.SetBelong(this.instance);
				}
				return r_RIsTransient;
			}
		}

		/// <summary>
		/// Void CreateGlobalFunctions()
		/// </summary>
		protected RMethod r_RCreateGlobalFunctions;
		public virtual RMethod RCreateGlobalFunctions
		{
			get
			{
				if(r_RCreateGlobalFunctions == null)
				{
					r_RCreateGlobalFunctions = new(this, "CreateGlobalFunctions", 0);
					r_RCreateGlobalFunctions.SetBelong(this.instance);
				}
				return r_RCreateGlobalFunctions;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineInitializedData(System.String, Byte[], System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_RDefineInitializedData_String_ByteArray_FieldAttributes;
		public virtual RMethod RDefineInitializedData_String_ByteArray_FieldAttributes
		{
			get
			{
				if(r_RDefineInitializedData_String_ByteArray_FieldAttributes == null)
				{
					r_RDefineInitializedData_String_ByteArray_FieldAttributes = new(this, "DefineInitializedData", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Reflection.FieldAttributes));
					r_RDefineInitializedData_String_ByteArray_FieldAttributes.SetBelong(this.instance);
				}
				return r_RDefineInitializedData_String_ByteArray_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineUninitializedData(System.String, Int32, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_RDefineUninitializedData_String_Int32_FieldAttributes;
		public virtual RMethod RDefineUninitializedData_String_Int32_FieldAttributes
		{
			get
			{
				if(r_RDefineUninitializedData_String_Int32_FieldAttributes == null)
				{
					r_RDefineUninitializedData_String_Int32_FieldAttributes = new(this, "DefineUninitializedData", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.FieldAttributes));
					r_RDefineUninitializedData_String_Int32_FieldAttributes.SetBelong(this.instance);
				}
				return r_RDefineUninitializedData_String_Int32_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineDataImpl(System.String, Int32, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_RDefineDataImpl_String_Int32_FieldAttributes;
		public virtual RMethod RDefineDataImpl_String_Int32_FieldAttributes
		{
			get
			{
				if(r_RDefineDataImpl_String_Int32_FieldAttributes == null)
				{
					r_RDefineDataImpl_String_Int32_FieldAttributes = new(this, "DefineDataImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.FieldAttributes));
					r_RDefineDataImpl_String_Int32_FieldAttributes.SetBelong(this.instance);
				}
				return r_RDefineDataImpl_String_Int32_FieldAttributes;
			}
		}

		/// <summary>
		/// Void addGlobalMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_RaddGlobalMethod_MethodBuilder;
		public virtual RMethod RaddGlobalMethod_MethodBuilder
		{
			get
			{
				if(r_RaddGlobalMethod_MethodBuilder == null)
				{
					r_RaddGlobalMethod_MethodBuilder = new(this, "addGlobalMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_RaddGlobalMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_RaddGlobalMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray;
		public virtual RMethod RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray
		{
			get
			{
				if(r_RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray == null)
				{
					r_RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
		public virtual RMethod RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray == null)
				{
					r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
		public virtual RMethod RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet
		{
			get
			{
				if(r_RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet == null)
				{
					r_RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
		public virtual RMethod RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet
		{
			get
			{
				if(r_RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet == null)
				{
					r_RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String)
		/// </summary>
		protected RMethod r_RDefineType_String;
		public virtual RMethod RDefineType_String
		{
			get
			{
				if(r_RDefineType_String == null)
				{
					r_RDefineType_String = new(this, "DefineType", 0, typeof(System.String));
					r_RDefineType_String.SetBelong(this.instance);
				}
				return r_RDefineType_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes)
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes;
		public virtual RMethod RDefineType_String_TypeAttributes
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes == null)
				{
					r_RDefineType_String_TypeAttributes = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes));
					r_RDefineType_String_TypeAttributes.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes_Type;
		public virtual RMethod RDefineType_String_TypeAttributes_Type
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes_Type == null)
				{
					r_RDefineType_String_TypeAttributes_Type = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_RDefineType_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes_Type;
			}
		}

		/// <summary>
		/// Void AddType(System.Reflection.Emit.TypeBuilder)
		/// </summary>
		protected RMethod r_RAddType_TypeBuilder;
		public virtual RMethod RAddType_TypeBuilder
		{
			get
			{
				if(r_RAddType_TypeBuilder == null)
				{
					r_RAddType_TypeBuilder = new(this, "AddType", 0, typeof(System.Reflection.Emit.TypeBuilder));
					r_RAddType_TypeBuilder.SetBelong(this.instance);
				}
				return r_RAddType_TypeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[], System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 == null)
				{
					r_RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
			}
		}

		/// <summary>
		/// Void RegisterTypeName(System.Reflection.Emit.TypeBuilder, System.TypeName)
		/// </summary>
		protected RMethod r_RRegisterTypeName_TypeBuilder_TypeName;
		public virtual RMethod RRegisterTypeName_TypeBuilder_TypeName
		{
			get
			{
				if(r_RRegisterTypeName_TypeBuilder_TypeName == null)
				{
					r_RRegisterTypeName_TypeBuilder_TypeName = new(this, "RegisterTypeName", 0, typeof(System.Reflection.Emit.TypeBuilder),  ReleactionUtils.GetType("System.TypeName"));
					r_RRegisterTypeName_TypeBuilder_TypeName.SetBelong(this.instance);
				}
				return r_RRegisterTypeName_TypeBuilder_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder GetRegisteredType(System.TypeName)
		/// </summary>
		protected RMethod r_RGetRegisteredType_TypeName;
		public virtual RMethod RGetRegisteredType_TypeName
		{
			get
			{
				if(r_RGetRegisteredType_TypeName == null)
				{
					r_RGetRegisteredType_TypeName = new(this, "GetRegisteredType", 0,  ReleactionUtils.GetType("System.TypeName"));
					r_RGetRegisteredType_TypeName.SetBelong(this.instance);
				}
				return r_RGetRegisteredType_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes_Type_TypeArray;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_TypeArray
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes_Type_TypeArray == null)
				{
					r_RDefineType_String_TypeAttributes_Type_TypeArray = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RDefineType_String_TypeAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, Int32)
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes_Type_Int32;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_Int32
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes_Type_Int32 == null)
				{
					r_RDefineType_String_TypeAttributes_Type_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Int32));
					r_RDefineType_String_TypeAttributes_Type_Int32.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes_Type_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize)
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes_Type_PackingSize;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_PackingSize
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes_Type_PackingSize == null)
				{
					r_RDefineType_String_TypeAttributes_Type_PackingSize = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize));
					r_RDefineType_String_TypeAttributes_Type_PackingSize.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes_Type_PackingSize;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_RDefineType_String_TypeAttributes_Type_PackingSize_Int32;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_PackingSize_Int32
		{
			get
			{
				if(r_RDefineType_String_TypeAttributes_Type_PackingSize_Int32 == null)
				{
					r_RDefineType_String_TypeAttributes_Type_PackingSize_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_RDefineType_String_TypeAttributes_Type_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_RDefineType_String_TypeAttributes_Type_PackingSize_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetArrayMethod(System.Type, System.String, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray;
		public virtual RMethod RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray == null)
				{
					r_RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray = new(this, "GetArrayMethod", 0, typeof(System.Type), typeof(System.String), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EnumBuilder DefineEnum(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_RDefineEnum_String_TypeAttributes_Type;
		public virtual RMethod RDefineEnum_String_TypeAttributes_Type
		{
			get
			{
				if(r_RDefineEnum_String_TypeAttributes_Type == null)
				{
					r_RDefineEnum_String_TypeAttributes_Type = new(this, "DefineEnum", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_RDefineEnum_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_RDefineEnum_String_TypeAttributes_Type;
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
		/// System.Reflection.Emit.TypeBuilder search_in_array(System.Reflection.Emit.TypeBuilder[], Int32, System.TypeName)
		/// </summary>
		protected RMethod r_Rsearch_in_array_TypeBuilderArray_Int32_TypeName;
		public virtual RMethod Rsearch_in_array_TypeBuilderArray_Int32_TypeName
		{
			get
			{
				if(r_Rsearch_in_array_TypeBuilderArray_Int32_TypeName == null)
				{
					r_Rsearch_in_array_TypeBuilderArray_Int32_TypeName = new(this, "search_in_array", 0, typeof(System.Reflection.Emit.TypeBuilder).MakeArrayType(), typeof(System.Int32),  ReleactionUtils.GetType("System.TypeName"));
					r_Rsearch_in_array_TypeBuilderArray_Int32_TypeName.SetBelong(this.instance);
				}
				return r_Rsearch_in_array_TypeBuilderArray_Int32_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder search_nested_in_array(System.Reflection.Emit.TypeBuilder[], Int32, System.TypeName)
		/// </summary>
		protected RMethod r_Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName;
		public virtual RMethod Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName
		{
			get
			{
				if(r_Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName == null)
				{
					r_Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName = new(this, "search_nested_in_array", 0, typeof(System.Reflection.Emit.TypeBuilder).MakeArrayType(), typeof(System.Int32),  ReleactionUtils.GetType("System.TypeName"));
					r_Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName.SetBelong(this.instance);
				}
				return r_Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder GetMaybeNested(System.Reflection.Emit.TypeBuilder, System.Collections.Generic.IEnumerable`1[System.TypeName])
		/// </summary>
		protected RMethod r_RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_;
		public virtual RMethod RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_
		{
			get
			{
				if(r_RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_ == null)
				{
					r_RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_ = new(this, "GetMaybeNested", 0, typeof(System.Reflection.Emit.TypeBuilder), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReleactionUtils.GetType("System.TypeName")));
					r_RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_.SetBelong(this.instance);
				}
				return r_RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_;
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
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_RSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_RSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_RSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_RSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_RSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_RSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_RSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_RSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter()
		/// </summary>
		protected RMethod r_RGetSymWriter;
		public virtual RMethod RGetSymWriter
		{
			get
			{
				if(r_RGetSymWriter == null)
				{
					r_RGetSymWriter = new(this, "GetSymWriter", 0);
					r_RGetSymWriter.SetBelong(this.instance);
				}
				return r_RGetSymWriter;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String, System.Guid, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_RDefineDocument_String_Guid_Guid_Guid;
		public virtual RMethod RDefineDocument_String_Guid_Guid_Guid
		{
			get
			{
				if(r_RDefineDocument_String_Guid_Guid_Guid == null)
				{
					r_RDefineDocument_String_Guid_Guid_Guid = new(this, "DefineDocument", 0, typeof(System.String), typeof(System.Guid), typeof(System.Guid), typeof(System.Guid));
					r_RDefineDocument_String_Guid_Guid_Guid.SetBelong(this.instance);
				}
				return r_RDefineDocument_String_Guid_Guid_Guid;
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
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_RDefineResource_String_String_ResourceAttributes;
		public virtual RMethod RDefineResource_String_String_ResourceAttributes
		{
			get
			{
				if(r_RDefineResource_String_String_ResourceAttributes == null)
				{
					r_RDefineResource_String_String_ResourceAttributes = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
					r_RDefineResource_String_String_ResourceAttributes.SetBelong(this.instance);
				}
				return r_RDefineResource_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String)
		/// </summary>
		protected RMethod r_RDefineResource_String_String;
		public virtual RMethod RDefineResource_String_String
		{
			get
			{
				if(r_RDefineResource_String_String == null)
				{
					r_RDefineResource_String_String = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String));
					r_RDefineResource_String_String.SetBelong(this.instance);
				}
				return r_RDefineResource_String_String;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(Byte[])
		/// </summary>
		protected RMethod r_RDefineUnmanagedResource_ByteArray;
		public virtual RMethod RDefineUnmanagedResource_ByteArray
		{
			get
			{
				if(r_RDefineUnmanagedResource_ByteArray == null)
				{
					r_RDefineUnmanagedResource_ByteArray = new(this, "DefineUnmanagedResource", 0, typeof(System.Byte).MakeArrayType());
					r_RDefineUnmanagedResource_ByteArray.SetBelong(this.instance);
				}
				return r_RDefineUnmanagedResource_ByteArray;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(System.String)
		/// </summary>
		protected RMethod r_RDefineUnmanagedResource_String;
		public virtual RMethod RDefineUnmanagedResource_String
		{
			get
			{
				if(r_RDefineUnmanagedResource_String == null)
				{
					r_RDefineUnmanagedResource_String = new(this, "DefineUnmanagedResource", 0, typeof(System.String));
					r_RDefineUnmanagedResource_String.SetBelong(this.instance);
				}
				return r_RDefineUnmanagedResource_String;
			}
		}

		/// <summary>
		/// Void DefineManifestResource(System.String, System.IO.Stream, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_RDefineManifestResource_String_Stream_ResourceAttributes;
		public virtual RMethod RDefineManifestResource_String_Stream_ResourceAttributes
		{
			get
			{
				if(r_RDefineManifestResource_String_Stream_ResourceAttributes == null)
				{
					r_RDefineManifestResource_String_Stream_ResourceAttributes = new(this, "DefineManifestResource", 0, typeof(System.String), typeof(System.IO.Stream), typeof(System.Reflection.ResourceAttributes));
					r_RDefineManifestResource_String_Stream_ResourceAttributes.SetBelong(this.instance);
				}
				return r_RDefineManifestResource_String_Stream_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void SetSymCustomAttribute(System.String, Byte[])
		/// </summary>
		protected RMethod r_RSetSymCustomAttribute_String_ByteArray;
		public virtual RMethod RSetSymCustomAttribute_String_ByteArray
		{
			get
			{
				if(r_RSetSymCustomAttribute_String_ByteArray == null)
				{
					r_RSetSymCustomAttribute_String_ByteArray = new(this, "SetSymCustomAttribute", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_RSetSymCustomAttribute_String_ByteArray.SetBelong(this.instance);
				}
				return r_RSetSymCustomAttribute_String_ByteArray;
			}
		}

		/// <summary>
		/// Void SetUserEntryPoint(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RSetUserEntryPoint_MethodInfo;
		public virtual RMethod RSetUserEntryPoint_MethodInfo
		{
			get
			{
				if(r_RSetUserEntryPoint_MethodInfo == null)
				{
					r_RSetUserEntryPoint_MethodInfo = new(this, "SetUserEntryPoint", 0, typeof(System.Reflection.MethodInfo));
					r_RSetUserEntryPoint_MethodInfo.SetBelong(this.instance);
				}
				return r_RSetUserEntryPoint_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RGetMethodToken_MethodInfo;
		public virtual RMethod RGetMethodToken_MethodInfo
		{
			get
			{
				if(r_RGetMethodToken_MethodInfo == null)
				{
					r_RGetMethodToken_MethodInfo = new(this, "GetMethodToken", 0, typeof(System.Reflection.MethodInfo));
					r_RGetMethodToken_MethodInfo.SetBelong(this.instance);
				}
				return r_RGetMethodToken_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_;
		public virtual RMethod RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_ == null)
				{
					r_RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_ = new(this, "GetMethodToken", 0, typeof(System.Reflection.MethodInfo), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type, System.String, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray;
		public virtual RMethod RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray == null)
				{
					r_RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray = new(this, "GetArrayMethodToken", 0, typeof(System.Type), typeof(System.String), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_RGetConstructorToken_ConstructorInfo;
		public virtual RMethod RGetConstructorToken_ConstructorInfo
		{
			get
			{
				if(r_RGetConstructorToken_ConstructorInfo == null)
				{
					r_RGetConstructorToken_ConstructorInfo = new(this, "GetConstructorToken", 0, typeof(System.Reflection.ConstructorInfo));
					r_RGetConstructorToken_ConstructorInfo.SetBelong(this.instance);
				}
				return r_RGetConstructorToken_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_;
		public virtual RMethod RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_ == null)
				{
					r_RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_ = new(this, "GetConstructorToken", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_RGetFieldToken_FieldInfo;
		public virtual RMethod RGetFieldToken_FieldInfo
		{
			get
			{
				if(r_RGetFieldToken_FieldInfo == null)
				{
					r_RGetFieldToken_FieldInfo = new(this, "GetFieldToken", 0, typeof(System.Reflection.FieldInfo));
					r_RGetFieldToken_FieldInfo.SetBelong(this.instance);
				}
				return r_RGetFieldToken_FieldInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken GetSignatureToken(Byte[], Int32)
		/// </summary>
		protected RMethod r_RGetSignatureToken_ByteArray_Int32;
		public virtual RMethod RGetSignatureToken_ByteArray_Int32
		{
			get
			{
				if(r_RGetSignatureToken_ByteArray_Int32 == null)
				{
					r_RGetSignatureToken_ByteArray_Int32 = new(this, "GetSignatureToken", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RGetSignatureToken_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RGetSignatureToken_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_RGetSignatureToken_SignatureHelper;
		public virtual RMethod RGetSignatureToken_SignatureHelper
		{
			get
			{
				if(r_RGetSignatureToken_SignatureHelper == null)
				{
					r_RGetSignatureToken_SignatureHelper = new(this, "GetSignatureToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_RGetSignatureToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_RGetSignatureToken_SignatureHelper;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StringToken GetStringConstant(System.String)
		/// </summary>
		protected RMethod r_RGetStringConstant_String;
		public virtual RMethod RGetStringConstant_String
		{
			get
			{
				if(r_RGetStringConstant_String == null)
				{
					r_RGetStringConstant_String = new(this, "GetStringConstant", 0, typeof(System.String));
					r_RGetStringConstant_String.SetBelong(this.instance);
				}
				return r_RGetStringConstant_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken GetTypeToken(System.Type)
		/// </summary>
		protected RMethod r_RGetTypeToken_Type;
		public virtual RMethod RGetTypeToken_Type
		{
			get
			{
				if(r_RGetTypeToken_Type == null)
				{
					r_RGetTypeToken_Type = new(this, "GetTypeToken", 0, typeof(System.Type));
					r_RGetTypeToken_Type.SetBelong(this.instance);
				}
				return r_RGetTypeToken_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken GetTypeToken(System.String)
		/// </summary>
		protected RMethod r_RGetTypeToken_String;
		public virtual RMethod RGetTypeToken_String
		{
			get
			{
				if(r_RGetTypeToken_String == null)
				{
					r_RGetTypeToken_String = new(this, "GetTypeToken", 0, typeof(System.String));
					r_RGetTypeToken_String.SetBelong(this.instance);
				}
				return r_RGetTypeToken_String;
			}
		}

		/// <summary>
		/// Int32 getUSIndex(System.Reflection.Emit.ModuleBuilder, System.String)
		/// </summary>
		protected static RMethod r_RgetUSIndex_ModuleBuilder_String;
		public static RMethod RgetUSIndex_ModuleBuilder_String
		{
			get
			{
				if(r_RgetUSIndex_ModuleBuilder_String == null)
				{
					r_RgetUSIndex_ModuleBuilder_String = new(typeof(System.Reflection.Emit.ModuleBuilder), "getUSIndex", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.String));
					r_RgetUSIndex_ModuleBuilder_String.SetBelong(null);
				}
				return r_RgetUSIndex_ModuleBuilder_String;
			}
		}

		/// <summary>
		/// Int32 getToken(System.Reflection.Emit.ModuleBuilder, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_RgetToken_ModuleBuilder_Object_Boolean;
		public static RMethod RgetToken_ModuleBuilder_Object_Boolean
		{
			get
			{
				if(r_RgetToken_ModuleBuilder_Object_Boolean == null)
				{
					r_RgetToken_ModuleBuilder_Object_Boolean = new(typeof(System.Reflection.Emit.ModuleBuilder), "getToken", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Object), typeof(System.Boolean));
					r_RgetToken_ModuleBuilder_Object_Boolean.SetBelong(null);
				}
				return r_RgetToken_ModuleBuilder_Object_Boolean;
			}
		}

		/// <summary>
		/// Int32 getMethodToken(System.Reflection.Emit.ModuleBuilder, System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected static RMethod r_RgetMethodToken_ModuleBuilder_MethodBase_TypeArray;
		public static RMethod RgetMethodToken_ModuleBuilder_MethodBase_TypeArray
		{
			get
			{
				if(r_RgetMethodToken_ModuleBuilder_MethodBase_TypeArray == null)
				{
					r_RgetMethodToken_ModuleBuilder_MethodBase_TypeArray = new(typeof(System.Reflection.Emit.ModuleBuilder), "getMethodToken", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_RgetMethodToken_ModuleBuilder_MethodBase_TypeArray.SetBelong(null);
				}
				return r_RgetMethodToken_ModuleBuilder_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.String)
		/// </summary>
		protected RMethod r_RGetToken_String;
		public virtual RMethod RGetToken_String
		{
			get
			{
				if(r_RGetToken_String == null)
				{
					r_RGetToken_String = new(this, "GetToken", 0, typeof(System.String));
					r_RGetToken_String.SetBelong(this.instance);
				}
				return r_RGetToken_String;
			}
		}

		/// <summary>
		/// Int32 GetPseudoToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_RGetPseudoToken_MemberInfo_Boolean;
		public virtual RMethod RGetPseudoToken_MemberInfo_Boolean
		{
			get
			{
				if(r_RGetPseudoToken_MemberInfo_Boolean == null)
				{
					r_RGetPseudoToken_MemberInfo_Boolean = new(this, "GetPseudoToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_RGetPseudoToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_RGetPseudoToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RGetToken_MemberInfo;
		public virtual RMethod RGetToken_MemberInfo
		{
			get
			{
				if(r_RGetToken_MemberInfo == null)
				{
					r_RGetToken_MemberInfo = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo));
					r_RGetToken_MemberInfo.SetBelong(this.instance);
				}
				return r_RGetToken_MemberInfo;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_RGetToken_MemberInfo_Boolean;
		public virtual RMethod RGetToken_MemberInfo_Boolean
		{
			get
			{
				if(r_RGetToken_MemberInfo_Boolean == null)
				{
					r_RGetToken_MemberInfo_Boolean = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_RGetToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_RGetToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_RGetToken_MethodBase_IEnumerable_d_Type_p_;
		public virtual RMethod RGetToken_MethodBase_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_RGetToken_MethodBase_IEnumerable_d_Type_p_ == null)
				{
					r_RGetToken_MethodBase_IEnumerable_d_Type_p_ = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_RGetToken_MethodBase_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_RGetToken_MethodBase_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected RMethod r_RGetToken_MethodBase_TypeArray;
		public virtual RMethod RGetToken_MethodBase_TypeArray
		{
			get
			{
				if(r_RGetToken_MethodBase_TypeArray == null)
				{
					r_RGetToken_MethodBase_TypeArray = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_RGetToken_MethodBase_TypeArray.SetBelong(this.instance);
				}
				return r_RGetToken_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_RGetToken_SignatureHelper;
		public virtual RMethod RGetToken_SignatureHelper
		{
			get
			{
				if(r_RGetToken_SignatureHelper == null)
				{
					r_RGetToken_SignatureHelper = new(this, "GetToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_RGetToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_RGetToken_SignatureHelper;
			}
		}

		/// <summary>
		/// Void RegisterToken(System.Object, Int32)
		/// </summary>
		protected RMethod r_RRegisterToken_Object_Int32;
		public virtual RMethod RRegisterToken_Object_Int32
		{
			get
			{
				if(r_RRegisterToken_Object_Int32 == null)
				{
					r_RRegisterToken_Object_Int32 = new(this, "RegisterToken", 0, typeof(System.Object), typeof(System.Int32));
					r_RRegisterToken_Object_Int32.SetBelong(this.instance);
				}
				return r_RRegisterToken_Object_Int32;
			}
		}

		/// <summary>
		/// System.Object GetRegisteredToken(Int32)
		/// </summary>
		protected RMethod r_RGetRegisteredToken_Int32;
		public virtual RMethod RGetRegisteredToken_Int32
		{
			get
			{
				if(r_RGetRegisteredToken_Int32 == null)
				{
					r_RGetRegisteredToken_Int32 = new(this, "GetRegisteredToken", 0, typeof(System.Int32));
					r_RGetRegisteredToken_Int32.SetBelong(this.instance);
				}
				return r_RGetRegisteredToken_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator GetTokenGenerator()
		/// </summary>
		protected RMethod r_RGetTokenGenerator;
		public virtual RMethod RGetTokenGenerator
		{
			get
			{
				if(r_RGetTokenGenerator == null)
				{
					r_RGetTokenGenerator = new(this, "GetTokenGenerator", 0);
					r_RGetTokenGenerator.SetBelong(this.instance);
				}
				return r_RGetTokenGenerator;
			}
		}

		/// <summary>
		/// System.Object RuntimeResolve(System.Object)
		/// </summary>
		protected static RMethod r_RRuntimeResolve_Object;
		public static RMethod RRuntimeResolve_Object
		{
			get
			{
				if(r_RRuntimeResolve_Object == null)
				{
					r_RRuntimeResolve_Object = new(typeof(System.Reflection.Emit.ModuleBuilder), "RuntimeResolve", 0, typeof(System.Object));
					r_RRuntimeResolve_Object.SetBelong(null);
				}
				return r_RRuntimeResolve_Object;
			}
		}

		/// <summary>
		/// Void build_metadata(System.Reflection.Emit.ModuleBuilder)
		/// </summary>
		protected static RMethod r_Rbuild_metadata_ModuleBuilder;
		public static RMethod Rbuild_metadata_ModuleBuilder
		{
			get
			{
				if(r_Rbuild_metadata_ModuleBuilder == null)
				{
					r_Rbuild_metadata_ModuleBuilder = new(typeof(System.Reflection.Emit.ModuleBuilder), "build_metadata", 0, typeof(System.Reflection.Emit.ModuleBuilder));
					r_Rbuild_metadata_ModuleBuilder.SetBelong(null);
				}
				return r_Rbuild_metadata_ModuleBuilder;
			}
		}

		/// <summary>
		/// Void WriteToFile(IntPtr)
		/// </summary>
		protected RMethod r_RWriteToFile_IntPtr;
		public virtual RMethod RWriteToFile_IntPtr
		{
			get
			{
				if(r_RWriteToFile_IntPtr == null)
				{
					r_RWriteToFile_IntPtr = new(this, "WriteToFile", 0, typeof(System.IntPtr));
					r_RWriteToFile_IntPtr.SetBelong(this.instance);
				}
				return r_RWriteToFile_IntPtr;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo], System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32], Boolean)
		/// </summary>
		protected RMethod r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean;
		public virtual RMethod RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean
		{
			get
			{
				if(r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean == null)
				{
					r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Reflection.MemberInfo), typeof(System.Int32)), typeof(System.Boolean));
					r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean.SetBelong(this.instance);
				}
				return r_RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean;
			}
		}

		/// <summary>
		/// Void FixupTokens()
		/// </summary>
		protected RMethod r_RFixupTokens;
		public virtual RMethod RFixupTokens
		{
			get
			{
				if(r_RFixupTokens == null)
				{
					r_RFixupTokens = new(this, "FixupTokens", 0);
					r_RFixupTokens.SetBelong(this.instance);
				}
				return r_RFixupTokens;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_RSave;
		public virtual RMethod RSave
		{
			get
			{
				if(r_RSave == null)
				{
					r_RSave = new(this, "Save", 0);
					r_RSave.SetBelong(this.instance);
				}
				return r_RSave;
			}
		}

		/// <summary>
		/// Void CreateGlobalType()
		/// </summary>
		protected RMethod r_RCreateGlobalType;
		public virtual RMethod RCreateGlobalType
		{
			get
			{
				if(r_RCreateGlobalType == null)
				{
					r_RCreateGlobalType = new(this, "CreateGlobalType", 0);
					r_RCreateGlobalType.SetBelong(this.instance);
				}
				return r_RCreateGlobalType;
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
		/// System.Reflection.MemberInfo ResolveOrGetRegisteredToken(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray == null)
				{
					r_RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray = new(this, "ResolveOrGetRegisteredToken", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray;
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


        public RModuleBuilder() : base("System.Reflection.Emit.ModuleBuilder")
        {
        }

        public RModuleBuilder(System.Object instance) : base("System.Reflection.Emit.ModuleBuilder")
		{
            SetInstance(instance);
		}

        public RModuleBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RModuleBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ModuleBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void basic_init(System.Reflection.Emit.ModuleBuilder  @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = Rbasic_init_ModuleBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public static void set_wrappers_type(System.Reflection.Emit.ModuleBuilder  @mb, System.Type  @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @ab};
            var ___result = Rset_wrappers_type_ModuleBuilder_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static void WarnAboutSymbolWriter(System.String  @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message};
            var ___result = RWarnAboutSymbolWriter_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsTransient()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsTransient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreateGlobalFunctions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateGlobalFunctions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineInitializedData(System.String  @name, System.Byte[]  @data, System.Reflection.FieldAttributes  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data, @attributes};
            var ___result = RDefineInitializedData_String_ByteArray_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineUninitializedData(System.String  @name, System.Int32  @size, System.Reflection.FieldAttributes  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @attributes};
            var ___result = RDefineUninitializedData_String_Int32_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineDataImpl(System.String  @name, System.Int32  @size, System.Reflection.FieldAttributes  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @attributes};
            var ___result = RDefineDataImpl_String_Int32_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual void addGlobalMethod(System.Reflection.Emit.MethodBuilder  @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = RaddGlobalMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String  @name, System.Reflection.MethodAttributes  @attributes, System.Type  @returnType, System.Type[]  @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @returnType, @parameterTypes};
            var ___result = RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String  @name, System.Reflection.MethodAttributes  @attributes, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @parameterTypes};
            var ___result = RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String  @name, System.Reflection.MethodAttributes  @attributes, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @requiredReturnTypeCustomModifiers, System.Type[]  @optionalReturnTypeCustomModifiers, System.Type[]  @parameterTypes, System.Type[][]  @requiredParameterTypeCustomModifiers, System.Type[][]  @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String  @name, System.String  @dllName, System.Reflection.MethodAttributes  @attributes, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @parameterTypes, System.Runtime.InteropServices.CallingConvention  @nativeCallConv, System.Runtime.InteropServices.CharSet  @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String  @name, System.String  @dllName, System.String  @entryName, System.Reflection.MethodAttributes  @attributes, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @parameterTypes, System.Runtime.InteropServices.CallingConvention  @nativeCallConv, System.Runtime.InteropServices.CharSet  @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @entryName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RDefineType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr};
            var ___result = RDefineType_String_TypeAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr, System.Type  @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent};
            var ___result = RDefineType_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual void AddType(System.Reflection.Emit.TypeBuilder  @tb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb};
            var ___result = RAddType_TypeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr, System.Type  @parent, System.Type[]  @interfaces, System.Reflection.Emit.PackingSize  @packingSize, System.Int32  @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces, @packingSize, @typesize};
            var ___result = RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }




        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr, System.Type  @parent, System.Type[]  @interfaces)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces};
            var ___result = RDefineType_String_TypeAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr, System.Type  @parent, System.Int32  @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @typesize};
            var ___result = RDefineType_String_TypeAttributes_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr, System.Type  @parent, System.Reflection.Emit.PackingSize  @packsize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packsize};
            var ___result = RDefineType_String_TypeAttributes_Type_PackingSize.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String  @name, System.Reflection.TypeAttributes  @attr, System.Type  @parent, System.Reflection.Emit.PackingSize  @packingSize, System.Int32  @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packingSize, @typesize};
            var ___result = RDefineType_String_TypeAttributes_Type_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.MethodInfo GetArrayMethod(System.Type  @arrayClass, System.String  @methodName, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrayClass, @methodName, @callingConvention, @returnType, @parameterTypes};
            var ___result = RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.Emit.EnumBuilder DefineEnum(System.String  @name, System.Reflection.TypeAttributes  @visibility, System.Type  @underlyingType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @visibility, @underlyingType};
            var ___result = RDefineEnum_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.EnumBuilder)___result;
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


        public virtual System.Int32 get_next_table_index(System.Object  @obj, System.Int32  @table, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder  @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo  @con, System.Byte[]  @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSymWriter.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolWriter)___result;
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String  @url, System.Guid  @language, System.Guid  @languageVendor, System.Guid  @documentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @language, @languageVendor, @documentType};
            var ___result = RDefineDocument_String_Guid_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolDocumentWriter)___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String  @name, System.String  @description, System.Reflection.ResourceAttributes  @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @attribute};
            var ___result = RDefineResource_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String  @name, System.String  @description)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description};
            var ___result = RDefineResource_String_String.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual void DefineUnmanagedResource(System.Byte[]  @resource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resource};
            var ___result = RDefineUnmanagedResource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineUnmanagedResource(System.String  @resourceFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceFileName};
            var ___result = RDefineUnmanagedResource_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineManifestResource(System.String  @name, System.IO.Stream  @stream, System.Reflection.ResourceAttributes  @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stream, @attribute};
            var ___result = RDefineManifestResource_String_Stream_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymCustomAttribute(System.String  @name, System.Byte[]  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetSymCustomAttribute_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUserEntryPoint(System.Reflection.MethodInfo  @entryPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryPoint};
            var ___result = RSetUserEntryPoint_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RGetMethodToken_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo  @method, System.Collections.Generic.IEnumerable<System.Type>  @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @optionalParameterTypes};
            var ___result = RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type  @arrayClass, System.String  @methodName, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrayClass, @methodName, @callingConvention, @returnType, @parameterTypes};
            var ___result = RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo  @con)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con};
            var ___result = RGetConstructorToken_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo  @constructor, System.Collections.Generic.IEnumerable<System.Type>  @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@constructor, @optionalParameterTypes};
            var ___result = RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo  @field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field};
            var ___result = RGetFieldToken_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldToken)___result;
        }


        public virtual System.Reflection.Emit.SignatureToken GetSignatureToken(System.Byte[]  @sigBytes, System.Int32  @sigLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sigBytes, @sigLength};
            var ___result = RGetSignatureToken_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureToken)___result;
        }


        public virtual System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper  @sigHelper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sigHelper};
            var ___result = RGetSignatureToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureToken)___result;
        }


        public virtual System.Reflection.Emit.StringToken GetStringConstant(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetStringConstant_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.StringToken)___result;
        }


        public virtual System.Reflection.Emit.TypeToken GetTypeToken(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetTypeToken_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeToken)___result;
        }


        public virtual System.Reflection.Emit.TypeToken GetTypeToken(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTypeToken_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeToken)___result;
        }


        public static System.Int32 getUSIndex(System.Reflection.Emit.ModuleBuilder  @mb, System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @str};
            var ___result = RgetUSIndex_ModuleBuilder_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 getToken(System.Reflection.Emit.ModuleBuilder  @mb, System.Object  @obj, System.Boolean  @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @obj, @create_open_instance};
            var ___result = RgetToken_ModuleBuilder_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 getMethodToken(System.Reflection.Emit.ModuleBuilder  @mb, System.Reflection.MethodBase  @method, System.Type[]  @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @method, @opt_param_types};
            var ___result = RgetMethodToken_ModuleBuilder_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetToken_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPseudoToken(System.Reflection.MemberInfo  @member, System.Boolean  @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RGetPseudoToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo  @member)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member};
            var ___result = RGetToken_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo  @member, System.Boolean  @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RGetToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase  @method, System.Collections.Generic.IEnumerable<System.Type>  @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RGetToken_MethodBase_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase  @method, System.Type[]  @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RGetToken_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.Emit.SignatureHelper  @helper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@helper};
            var ___result = RGetToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RegisterToken(System.Object  @obj, System.Int32  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @token};
            var ___result = RRegisterToken_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetRegisteredToken(System.Int32  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RGetRegisteredToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetTokenGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTokenGenerator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object RuntimeResolve(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRuntimeResolve_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void build_metadata(System.Reflection.Emit.ModuleBuilder  @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = Rbuild_metadata_ModuleBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteToFile(System.IntPtr  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RWriteToFile_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32>  @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo>  @member_map, System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, System.Int32>  @inst_tokens, System.Boolean  @open)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map, @inst_tokens, @open};
            var ___result = RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFixupTokens.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateGlobalType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateGlobalType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Guid GetModuleVersionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetModuleVersionId.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public virtual System.Boolean IsResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveOrGetRegisteredToken(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.String ResolveString(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] ResolveSignature(System.Int32  @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Type ResolveType(System.Int32  @metadataToken, System.Type[]  @genericTypeArguments, System.Type[]  @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
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


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSignerCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
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
