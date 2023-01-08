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
		protected RProperty r_IsMain;
		public virtual RProperty RIsMain
		{
			get
			{
				if(r_IsMain == null)
				{
					r_IsMain = new(this, "IsMain", -1);
					r_IsMain.SetBelong(this.instance);
				}
				return r_IsMain;
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
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void basic_init(System.Reflection.Emit.ModuleBuilder)
		/// </summary>
		protected static RMethod r_basic_init_ModuleBuilder;
		public static RMethod Rbasic_init_ModuleBuilder
		{
			get
			{
				if(r_basic_init_ModuleBuilder == null)
				{
					r_basic_init_ModuleBuilder = new(typeof(System.Reflection.Emit.ModuleBuilder), "basic_init", 0, typeof(System.Reflection.Emit.ModuleBuilder));
					r_basic_init_ModuleBuilder.SetBelong(null);
				}
				return r_basic_init_ModuleBuilder;
			}
		}

		/// <summary>
		/// Void set_wrappers_type(System.Reflection.Emit.ModuleBuilder, System.Type)
		/// </summary>
		protected static RMethod r_set_wrappers_type_ModuleBuilder_Type;
		public static RMethod Rset_wrappers_type_ModuleBuilder_Type
		{
			get
			{
				if(r_set_wrappers_type_ModuleBuilder_Type == null)
				{
					r_set_wrappers_type_ModuleBuilder_Type = new(typeof(System.Reflection.Emit.ModuleBuilder), "set_wrappers_type", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Type));
					r_set_wrappers_type_ModuleBuilder_Type.SetBelong(null);
				}
				return r_set_wrappers_type_ModuleBuilder_Type;
			}
		}

		/// <summary>
		/// Void WarnAboutSymbolWriter(System.String)
		/// </summary>
		protected static RMethod r_WarnAboutSymbolWriter_String;
		public static RMethod RWarnAboutSymbolWriter_String
		{
			get
			{
				if(r_WarnAboutSymbolWriter_String == null)
				{
					r_WarnAboutSymbolWriter_String = new(typeof(System.Reflection.Emit.ModuleBuilder), "WarnAboutSymbolWriter", 0, typeof(System.String));
					r_WarnAboutSymbolWriter_String.SetBelong(null);
				}
				return r_WarnAboutSymbolWriter_String;
			}
		}

		/// <summary>
		/// Boolean IsTransient()
		/// </summary>
		protected RMethod r_IsTransient;
		public virtual RMethod RIsTransient
		{
			get
			{
				if(r_IsTransient == null)
				{
					r_IsTransient = new(this, "IsTransient", 0);
					r_IsTransient.SetBelong(this.instance);
				}
				return r_IsTransient;
			}
		}

		/// <summary>
		/// Void CreateGlobalFunctions()
		/// </summary>
		protected RMethod r_CreateGlobalFunctions;
		public virtual RMethod RCreateGlobalFunctions
		{
			get
			{
				if(r_CreateGlobalFunctions == null)
				{
					r_CreateGlobalFunctions = new(this, "CreateGlobalFunctions", 0);
					r_CreateGlobalFunctions.SetBelong(this.instance);
				}
				return r_CreateGlobalFunctions;
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
		/// System.Reflection.Emit.FieldBuilder DefineDataImpl(System.String, Int32, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_DefineDataImpl_String_Int32_FieldAttributes;
		public virtual RMethod RDefineDataImpl_String_Int32_FieldAttributes
		{
			get
			{
				if(r_DefineDataImpl_String_Int32_FieldAttributes == null)
				{
					r_DefineDataImpl_String_Int32_FieldAttributes = new(this, "DefineDataImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.FieldAttributes));
					r_DefineDataImpl_String_Int32_FieldAttributes.SetBelong(this.instance);
				}
				return r_DefineDataImpl_String_Int32_FieldAttributes;
			}
		}

		/// <summary>
		/// Void addGlobalMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_addGlobalMethod_MethodBuilder;
		public virtual RMethod RaddGlobalMethod_MethodBuilder
		{
			get
			{
				if(r_addGlobalMethod_MethodBuilder == null)
				{
					r_addGlobalMethod_MethodBuilder = new(this, "addGlobalMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_addGlobalMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_addGlobalMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineGlobalMethod_String_MethodAttributes_Type_TypeArray;
		public virtual RMethod RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray
		{
			get
			{
				if(r_DefineGlobalMethod_String_MethodAttributes_Type_TypeArray == null)
				{
					r_DefineGlobalMethod_String_MethodAttributes_Type_TypeArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineGlobalMethod_String_MethodAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineGlobalMethod_String_MethodAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
		public virtual RMethod RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray == null)
				{
					r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_DefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
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
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String)
		/// </summary>
		protected RMethod r_DefineType_String;
		public virtual RMethod RDefineType_String
		{
			get
			{
				if(r_DefineType_String == null)
				{
					r_DefineType_String = new(this, "DefineType", 0, typeof(System.String));
					r_DefineType_String.SetBelong(this.instance);
				}
				return r_DefineType_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes)
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes;
		public virtual RMethod RDefineType_String_TypeAttributes
		{
			get
			{
				if(r_DefineType_String_TypeAttributes == null)
				{
					r_DefineType_String_TypeAttributes = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes));
					r_DefineType_String_TypeAttributes.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes_Type;
		public virtual RMethod RDefineType_String_TypeAttributes_Type
		{
			get
			{
				if(r_DefineType_String_TypeAttributes_Type == null)
				{
					r_DefineType_String_TypeAttributes_Type = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_DefineType_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes_Type;
			}
		}

		/// <summary>
		/// Void AddType(System.Reflection.Emit.TypeBuilder)
		/// </summary>
		protected RMethod r_AddType_TypeBuilder;
		public virtual RMethod RAddType_TypeBuilder
		{
			get
			{
				if(r_AddType_TypeBuilder == null)
				{
					r_AddType_TypeBuilder = new(this, "AddType", 0, typeof(System.Reflection.Emit.TypeBuilder));
					r_AddType_TypeBuilder.SetBelong(this.instance);
				}
				return r_AddType_TypeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[], System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32
		{
			get
			{
				if(r_DefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 == null)
				{
					r_DefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_DefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
			}
		}

		/// <summary>
		/// Void RegisterTypeName(System.Reflection.Emit.TypeBuilder, System.TypeName)
		/// </summary>
		protected RMethod r_RegisterTypeName_TypeBuilder_TypeName;
		public virtual RMethod RRegisterTypeName_TypeBuilder_TypeName
		{
			get
			{
				if(r_RegisterTypeName_TypeBuilder_TypeName == null)
				{
					r_RegisterTypeName_TypeBuilder_TypeName = new(this, "RegisterTypeName", 0, typeof(System.Reflection.Emit.TypeBuilder),  ReflectionUtils.GetType("System.TypeName"));
					r_RegisterTypeName_TypeBuilder_TypeName.SetBelong(this.instance);
				}
				return r_RegisterTypeName_TypeBuilder_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder GetRegisteredType(System.TypeName)
		/// </summary>
		protected RMethod r_GetRegisteredType_TypeName;
		public virtual RMethod RGetRegisteredType_TypeName
		{
			get
			{
				if(r_GetRegisteredType_TypeName == null)
				{
					r_GetRegisteredType_TypeName = new(this, "GetRegisteredType", 0,  ReflectionUtils.GetType("System.TypeName"));
					r_GetRegisteredType_TypeName.SetBelong(this.instance);
				}
				return r_GetRegisteredType_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes_Type_TypeArray;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_TypeArray
		{
			get
			{
				if(r_DefineType_String_TypeAttributes_Type_TypeArray == null)
				{
					r_DefineType_String_TypeAttributes_Type_TypeArray = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_DefineType_String_TypeAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, Int32)
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes_Type_Int32;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_Int32
		{
			get
			{
				if(r_DefineType_String_TypeAttributes_Type_Int32 == null)
				{
					r_DefineType_String_TypeAttributes_Type_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Int32));
					r_DefineType_String_TypeAttributes_Type_Int32.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes_Type_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize)
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes_Type_PackingSize;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_PackingSize
		{
			get
			{
				if(r_DefineType_String_TypeAttributes_Type_PackingSize == null)
				{
					r_DefineType_String_TypeAttributes_Type_PackingSize = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize));
					r_DefineType_String_TypeAttributes_Type_PackingSize.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes_Type_PackingSize;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_DefineType_String_TypeAttributes_Type_PackingSize_Int32;
		public virtual RMethod RDefineType_String_TypeAttributes_Type_PackingSize_Int32
		{
			get
			{
				if(r_DefineType_String_TypeAttributes_Type_PackingSize_Int32 == null)
				{
					r_DefineType_String_TypeAttributes_Type_PackingSize_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_DefineType_String_TypeAttributes_Type_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_DefineType_String_TypeAttributes_Type_PackingSize_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetArrayMethod(System.Type, System.String, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_GetArrayMethod_Type_String_CallingConventions_Type_TypeArray;
		public virtual RMethod RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_GetArrayMethod_Type_String_CallingConventions_Type_TypeArray == null)
				{
					r_GetArrayMethod_Type_String_CallingConventions_Type_TypeArray = new(this, "GetArrayMethod", 0, typeof(System.Type), typeof(System.String), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_GetArrayMethod_Type_String_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_GetArrayMethod_Type_String_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EnumBuilder DefineEnum(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_DefineEnum_String_TypeAttributes_Type;
		public virtual RMethod RDefineEnum_String_TypeAttributes_Type
		{
			get
			{
				if(r_DefineEnum_String_TypeAttributes_Type == null)
				{
					r_DefineEnum_String_TypeAttributes_Type = new(this, "DefineEnum", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_DefineEnum_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_DefineEnum_String_TypeAttributes_Type;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected RMethod r_GetType_String;
		public virtual RMethod RGetType_String
		{
			get
			{
				if(r_GetType_String == null)
				{
					r_GetType_String = new(this, "GetType", 0, typeof(System.String));
					r_GetType_String.SetBelong(this.instance);
				}
				return r_GetType_String;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected RMethod r_GetType_String_Boolean;
		public virtual RMethod RGetType_String_Boolean
		{
			get
			{
				if(r_GetType_String_Boolean == null)
				{
					r_GetType_String_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean));
					r_GetType_String_Boolean.SetBelong(this.instance);
				}
				return r_GetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder search_in_array(System.Reflection.Emit.TypeBuilder[], Int32, System.TypeName)
		/// </summary>
		protected RMethod r_search_in_array_TypeBuilderArray_Int32_TypeName;
		public virtual RMethod Rsearch_in_array_TypeBuilderArray_Int32_TypeName
		{
			get
			{
				if(r_search_in_array_TypeBuilderArray_Int32_TypeName == null)
				{
					r_search_in_array_TypeBuilderArray_Int32_TypeName = new(this, "search_in_array", 0, typeof(System.Reflection.Emit.TypeBuilder).MakeArrayType(), typeof(System.Int32),  ReflectionUtils.GetType("System.TypeName"));
					r_search_in_array_TypeBuilderArray_Int32_TypeName.SetBelong(this.instance);
				}
				return r_search_in_array_TypeBuilderArray_Int32_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder search_nested_in_array(System.Reflection.Emit.TypeBuilder[], Int32, System.TypeName)
		/// </summary>
		protected RMethod r_search_nested_in_array_TypeBuilderArray_Int32_TypeName;
		public virtual RMethod Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName
		{
			get
			{
				if(r_search_nested_in_array_TypeBuilderArray_Int32_TypeName == null)
				{
					r_search_nested_in_array_TypeBuilderArray_Int32_TypeName = new(this, "search_nested_in_array", 0, typeof(System.Reflection.Emit.TypeBuilder).MakeArrayType(), typeof(System.Int32),  ReflectionUtils.GetType("System.TypeName"));
					r_search_nested_in_array_TypeBuilderArray_Int32_TypeName.SetBelong(this.instance);
				}
				return r_search_nested_in_array_TypeBuilderArray_Int32_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder GetMaybeNested(System.Reflection.Emit.TypeBuilder, System.Collections.Generic.IEnumerable`1[System.TypeName])
		/// </summary>
		protected RMethod r_GetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_;
		public virtual RMethod RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_
		{
			get
			{
				if(r_GetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_ == null)
				{
					r_GetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_ = new(this, "GetMaybeNested", 0, typeof(System.Reflection.Emit.TypeBuilder), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("System.TypeName")));
					r_GetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_.SetBelong(this.instance);
				}
				return r_GetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_GetType_String_Boolean_Boolean;
		public virtual RMethod RGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_GetType_String_Boolean_Boolean == null)
				{
					r_GetType_String_Boolean_Boolean = new(this, "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_GetType_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_GetType_String_Boolean_Boolean;
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
		/// System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter()
		/// </summary>
		protected RMethod r_GetSymWriter;
		public virtual RMethod RGetSymWriter
		{
			get
			{
				if(r_GetSymWriter == null)
				{
					r_GetSymWriter = new(this, "GetSymWriter", 0);
					r_GetSymWriter.SetBelong(this.instance);
				}
				return r_GetSymWriter;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String, System.Guid, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_DefineDocument_String_Guid_Guid_Guid;
		public virtual RMethod RDefineDocument_String_Guid_Guid_Guid
		{
			get
			{
				if(r_DefineDocument_String_Guid_Guid_Guid == null)
				{
					r_DefineDocument_String_Guid_Guid_Guid = new(this, "DefineDocument", 0, typeof(System.String), typeof(System.Guid), typeof(System.Guid), typeof(System.Guid));
					r_DefineDocument_String_Guid_Guid_Guid.SetBelong(this.instance);
				}
				return r_DefineDocument_String_Guid_Guid_Guid;
			}
		}

		/// <summary>
		/// System.Type[] GetTypes()
		/// </summary>
		protected RMethod r_GetTypes;
		public virtual RMethod RGetTypes
		{
			get
			{
				if(r_GetTypes == null)
				{
					r_GetTypes = new(this, "GetTypes", 0);
					r_GetTypes.SetBelong(this.instance);
				}
				return r_GetTypes;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_DefineResource_String_String_ResourceAttributes;
		public virtual RMethod RDefineResource_String_String_ResourceAttributes
		{
			get
			{
				if(r_DefineResource_String_String_ResourceAttributes == null)
				{
					r_DefineResource_String_String_ResourceAttributes = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
					r_DefineResource_String_String_ResourceAttributes.SetBelong(this.instance);
				}
				return r_DefineResource_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String)
		/// </summary>
		protected RMethod r_DefineResource_String_String;
		public virtual RMethod RDefineResource_String_String
		{
			get
			{
				if(r_DefineResource_String_String == null)
				{
					r_DefineResource_String_String = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String));
					r_DefineResource_String_String.SetBelong(this.instance);
				}
				return r_DefineResource_String_String;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(Byte[])
		/// </summary>
		protected RMethod r_DefineUnmanagedResource_ByteArray;
		public virtual RMethod RDefineUnmanagedResource_ByteArray
		{
			get
			{
				if(r_DefineUnmanagedResource_ByteArray == null)
				{
					r_DefineUnmanagedResource_ByteArray = new(this, "DefineUnmanagedResource", 0, typeof(System.Byte).MakeArrayType());
					r_DefineUnmanagedResource_ByteArray.SetBelong(this.instance);
				}
				return r_DefineUnmanagedResource_ByteArray;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(System.String)
		/// </summary>
		protected RMethod r_DefineUnmanagedResource_String;
		public virtual RMethod RDefineUnmanagedResource_String
		{
			get
			{
				if(r_DefineUnmanagedResource_String == null)
				{
					r_DefineUnmanagedResource_String = new(this, "DefineUnmanagedResource", 0, typeof(System.String));
					r_DefineUnmanagedResource_String.SetBelong(this.instance);
				}
				return r_DefineUnmanagedResource_String;
			}
		}

		/// <summary>
		/// Void DefineManifestResource(System.String, System.IO.Stream, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_DefineManifestResource_String_Stream_ResourceAttributes;
		public virtual RMethod RDefineManifestResource_String_Stream_ResourceAttributes
		{
			get
			{
				if(r_DefineManifestResource_String_Stream_ResourceAttributes == null)
				{
					r_DefineManifestResource_String_Stream_ResourceAttributes = new(this, "DefineManifestResource", 0, typeof(System.String), typeof(System.IO.Stream), typeof(System.Reflection.ResourceAttributes));
					r_DefineManifestResource_String_Stream_ResourceAttributes.SetBelong(this.instance);
				}
				return r_DefineManifestResource_String_Stream_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void SetSymCustomAttribute(System.String, Byte[])
		/// </summary>
		protected RMethod r_SetSymCustomAttribute_String_ByteArray;
		public virtual RMethod RSetSymCustomAttribute_String_ByteArray
		{
			get
			{
				if(r_SetSymCustomAttribute_String_ByteArray == null)
				{
					r_SetSymCustomAttribute_String_ByteArray = new(this, "SetSymCustomAttribute", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_SetSymCustomAttribute_String_ByteArray.SetBelong(this.instance);
				}
				return r_SetSymCustomAttribute_String_ByteArray;
			}
		}

		/// <summary>
		/// Void SetUserEntryPoint(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_SetUserEntryPoint_MethodInfo;
		public virtual RMethod RSetUserEntryPoint_MethodInfo
		{
			get
			{
				if(r_SetUserEntryPoint_MethodInfo == null)
				{
					r_SetUserEntryPoint_MethodInfo = new(this, "SetUserEntryPoint", 0, typeof(System.Reflection.MethodInfo));
					r_SetUserEntryPoint_MethodInfo.SetBelong(this.instance);
				}
				return r_SetUserEntryPoint_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_GetMethodToken_MethodInfo;
		public virtual RMethod RGetMethodToken_MethodInfo
		{
			get
			{
				if(r_GetMethodToken_MethodInfo == null)
				{
					r_GetMethodToken_MethodInfo = new(this, "GetMethodToken", 0, typeof(System.Reflection.MethodInfo));
					r_GetMethodToken_MethodInfo.SetBelong(this.instance);
				}
				return r_GetMethodToken_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_GetMethodToken_MethodInfo_IEnumerable_d_Type_p_;
		public virtual RMethod RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_GetMethodToken_MethodInfo_IEnumerable_d_Type_p_ == null)
				{
					r_GetMethodToken_MethodInfo_IEnumerable_d_Type_p_ = new(this, "GetMethodToken", 0, typeof(System.Reflection.MethodInfo), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_GetMethodToken_MethodInfo_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_GetMethodToken_MethodInfo_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type, System.String, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_GetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray;
		public virtual RMethod RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_GetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray == null)
				{
					r_GetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray = new(this, "GetArrayMethodToken", 0, typeof(System.Type), typeof(System.String), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_GetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_GetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_GetConstructorToken_ConstructorInfo;
		public virtual RMethod RGetConstructorToken_ConstructorInfo
		{
			get
			{
				if(r_GetConstructorToken_ConstructorInfo == null)
				{
					r_GetConstructorToken_ConstructorInfo = new(this, "GetConstructorToken", 0, typeof(System.Reflection.ConstructorInfo));
					r_GetConstructorToken_ConstructorInfo.SetBelong(this.instance);
				}
				return r_GetConstructorToken_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_GetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_;
		public virtual RMethod RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_GetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_ == null)
				{
					r_GetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_ = new(this, "GetConstructorToken", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_GetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_GetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_GetFieldToken_FieldInfo;
		public virtual RMethod RGetFieldToken_FieldInfo
		{
			get
			{
				if(r_GetFieldToken_FieldInfo == null)
				{
					r_GetFieldToken_FieldInfo = new(this, "GetFieldToken", 0, typeof(System.Reflection.FieldInfo));
					r_GetFieldToken_FieldInfo.SetBelong(this.instance);
				}
				return r_GetFieldToken_FieldInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken GetSignatureToken(Byte[], Int32)
		/// </summary>
		protected RMethod r_GetSignatureToken_ByteArray_Int32;
		public virtual RMethod RGetSignatureToken_ByteArray_Int32
		{
			get
			{
				if(r_GetSignatureToken_ByteArray_Int32 == null)
				{
					r_GetSignatureToken_ByteArray_Int32 = new(this, "GetSignatureToken", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_GetSignatureToken_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_GetSignatureToken_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_GetSignatureToken_SignatureHelper;
		public virtual RMethod RGetSignatureToken_SignatureHelper
		{
			get
			{
				if(r_GetSignatureToken_SignatureHelper == null)
				{
					r_GetSignatureToken_SignatureHelper = new(this, "GetSignatureToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_GetSignatureToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_GetSignatureToken_SignatureHelper;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StringToken GetStringConstant(System.String)
		/// </summary>
		protected RMethod r_GetStringConstant_String;
		public virtual RMethod RGetStringConstant_String
		{
			get
			{
				if(r_GetStringConstant_String == null)
				{
					r_GetStringConstant_String = new(this, "GetStringConstant", 0, typeof(System.String));
					r_GetStringConstant_String.SetBelong(this.instance);
				}
				return r_GetStringConstant_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken GetTypeToken(System.Type)
		/// </summary>
		protected RMethod r_GetTypeToken_Type;
		public virtual RMethod RGetTypeToken_Type
		{
			get
			{
				if(r_GetTypeToken_Type == null)
				{
					r_GetTypeToken_Type = new(this, "GetTypeToken", 0, typeof(System.Type));
					r_GetTypeToken_Type.SetBelong(this.instance);
				}
				return r_GetTypeToken_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken GetTypeToken(System.String)
		/// </summary>
		protected RMethod r_GetTypeToken_String;
		public virtual RMethod RGetTypeToken_String
		{
			get
			{
				if(r_GetTypeToken_String == null)
				{
					r_GetTypeToken_String = new(this, "GetTypeToken", 0, typeof(System.String));
					r_GetTypeToken_String.SetBelong(this.instance);
				}
				return r_GetTypeToken_String;
			}
		}

		/// <summary>
		/// Int32 getUSIndex(System.Reflection.Emit.ModuleBuilder, System.String)
		/// </summary>
		protected static RMethod r_getUSIndex_ModuleBuilder_String;
		public static RMethod RgetUSIndex_ModuleBuilder_String
		{
			get
			{
				if(r_getUSIndex_ModuleBuilder_String == null)
				{
					r_getUSIndex_ModuleBuilder_String = new(typeof(System.Reflection.Emit.ModuleBuilder), "getUSIndex", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.String));
					r_getUSIndex_ModuleBuilder_String.SetBelong(null);
				}
				return r_getUSIndex_ModuleBuilder_String;
			}
		}

		/// <summary>
		/// Int32 getToken(System.Reflection.Emit.ModuleBuilder, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_getToken_ModuleBuilder_Object_Boolean;
		public static RMethod RgetToken_ModuleBuilder_Object_Boolean
		{
			get
			{
				if(r_getToken_ModuleBuilder_Object_Boolean == null)
				{
					r_getToken_ModuleBuilder_Object_Boolean = new(typeof(System.Reflection.Emit.ModuleBuilder), "getToken", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Object), typeof(System.Boolean));
					r_getToken_ModuleBuilder_Object_Boolean.SetBelong(null);
				}
				return r_getToken_ModuleBuilder_Object_Boolean;
			}
		}

		/// <summary>
		/// Int32 getMethodToken(System.Reflection.Emit.ModuleBuilder, System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected static RMethod r_getMethodToken_ModuleBuilder_MethodBase_TypeArray;
		public static RMethod RgetMethodToken_ModuleBuilder_MethodBase_TypeArray
		{
			get
			{
				if(r_getMethodToken_ModuleBuilder_MethodBase_TypeArray == null)
				{
					r_getMethodToken_ModuleBuilder_MethodBase_TypeArray = new(typeof(System.Reflection.Emit.ModuleBuilder), "getMethodToken", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_getMethodToken_ModuleBuilder_MethodBase_TypeArray.SetBelong(null);
				}
				return r_getMethodToken_ModuleBuilder_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.String)
		/// </summary>
		protected RMethod r_GetToken_String;
		public virtual RMethod RGetToken_String
		{
			get
			{
				if(r_GetToken_String == null)
				{
					r_GetToken_String = new(this, "GetToken", 0, typeof(System.String));
					r_GetToken_String.SetBelong(this.instance);
				}
				return r_GetToken_String;
			}
		}

		/// <summary>
		/// Int32 GetPseudoToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_GetPseudoToken_MemberInfo_Boolean;
		public virtual RMethod RGetPseudoToken_MemberInfo_Boolean
		{
			get
			{
				if(r_GetPseudoToken_MemberInfo_Boolean == null)
				{
					r_GetPseudoToken_MemberInfo_Boolean = new(this, "GetPseudoToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_GetPseudoToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_GetPseudoToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_GetToken_MemberInfo;
		public virtual RMethod RGetToken_MemberInfo
		{
			get
			{
				if(r_GetToken_MemberInfo == null)
				{
					r_GetToken_MemberInfo = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo));
					r_GetToken_MemberInfo.SetBelong(this.instance);
				}
				return r_GetToken_MemberInfo;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_GetToken_MemberInfo_Boolean;
		public virtual RMethod RGetToken_MemberInfo_Boolean
		{
			get
			{
				if(r_GetToken_MemberInfo_Boolean == null)
				{
					r_GetToken_MemberInfo_Boolean = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_GetToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_GetToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_GetToken_MethodBase_IEnumerable_d_Type_p_;
		public virtual RMethod RGetToken_MethodBase_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_GetToken_MethodBase_IEnumerable_d_Type_p_ == null)
				{
					r_GetToken_MethodBase_IEnumerable_d_Type_p_ = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_GetToken_MethodBase_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_GetToken_MethodBase_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected RMethod r_GetToken_MethodBase_TypeArray;
		public virtual RMethod RGetToken_MethodBase_TypeArray
		{
			get
			{
				if(r_GetToken_MethodBase_TypeArray == null)
				{
					r_GetToken_MethodBase_TypeArray = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_GetToken_MethodBase_TypeArray.SetBelong(this.instance);
				}
				return r_GetToken_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_GetToken_SignatureHelper;
		public virtual RMethod RGetToken_SignatureHelper
		{
			get
			{
				if(r_GetToken_SignatureHelper == null)
				{
					r_GetToken_SignatureHelper = new(this, "GetToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_GetToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_GetToken_SignatureHelper;
			}
		}

		/// <summary>
		/// Void RegisterToken(System.Object, Int32)
		/// </summary>
		protected RMethod r_RegisterToken_Object_Int32;
		public virtual RMethod RRegisterToken_Object_Int32
		{
			get
			{
				if(r_RegisterToken_Object_Int32 == null)
				{
					r_RegisterToken_Object_Int32 = new(this, "RegisterToken", 0, typeof(System.Object), typeof(System.Int32));
					r_RegisterToken_Object_Int32.SetBelong(this.instance);
				}
				return r_RegisterToken_Object_Int32;
			}
		}

		/// <summary>
		/// System.Object GetRegisteredToken(Int32)
		/// </summary>
		protected RMethod r_GetRegisteredToken_Int32;
		public virtual RMethod RGetRegisteredToken_Int32
		{
			get
			{
				if(r_GetRegisteredToken_Int32 == null)
				{
					r_GetRegisteredToken_Int32 = new(this, "GetRegisteredToken", 0, typeof(System.Int32));
					r_GetRegisteredToken_Int32.SetBelong(this.instance);
				}
				return r_GetRegisteredToken_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator GetTokenGenerator()
		/// </summary>
		protected RMethod r_GetTokenGenerator;
		public virtual RMethod RGetTokenGenerator
		{
			get
			{
				if(r_GetTokenGenerator == null)
				{
					r_GetTokenGenerator = new(this, "GetTokenGenerator", 0);
					r_GetTokenGenerator.SetBelong(this.instance);
				}
				return r_GetTokenGenerator;
			}
		}

		/// <summary>
		/// System.Object RuntimeResolve(System.Object)
		/// </summary>
		protected static RMethod r_RuntimeResolve_Object;
		public static RMethod RRuntimeResolve_Object
		{
			get
			{
				if(r_RuntimeResolve_Object == null)
				{
					r_RuntimeResolve_Object = new(typeof(System.Reflection.Emit.ModuleBuilder), "RuntimeResolve", 0, typeof(System.Object));
					r_RuntimeResolve_Object.SetBelong(null);
				}
				return r_RuntimeResolve_Object;
			}
		}

		/// <summary>
		/// Void build_metadata(System.Reflection.Emit.ModuleBuilder)
		/// </summary>
		protected static RMethod r_build_metadata_ModuleBuilder;
		public static RMethod Rbuild_metadata_ModuleBuilder
		{
			get
			{
				if(r_build_metadata_ModuleBuilder == null)
				{
					r_build_metadata_ModuleBuilder = new(typeof(System.Reflection.Emit.ModuleBuilder), "build_metadata", 0, typeof(System.Reflection.Emit.ModuleBuilder));
					r_build_metadata_ModuleBuilder.SetBelong(null);
				}
				return r_build_metadata_ModuleBuilder;
			}
		}

		/// <summary>
		/// Void WriteToFile(IntPtr)
		/// </summary>
		protected RMethod r_WriteToFile_IntPtr;
		public virtual RMethod RWriteToFile_IntPtr
		{
			get
			{
				if(r_WriteToFile_IntPtr == null)
				{
					r_WriteToFile_IntPtr = new(this, "WriteToFile", 0, typeof(System.IntPtr));
					r_WriteToFile_IntPtr.SetBelong(this.instance);
				}
				return r_WriteToFile_IntPtr;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo], System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32], Boolean)
		/// </summary>
		protected RMethod r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean;
		public virtual RMethod RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean
		{
			get
			{
				if(r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean == null)
				{
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Reflection.MemberInfo), typeof(System.Int32)), typeof(System.Boolean));
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean.SetBelong(this.instance);
				}
				return r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean;
			}
		}

		/// <summary>
		/// Void FixupTokens()
		/// </summary>
		protected RMethod r_FixupTokens;
		public virtual RMethod RFixupTokens
		{
			get
			{
				if(r_FixupTokens == null)
				{
					r_FixupTokens = new(this, "FixupTokens", 0);
					r_FixupTokens.SetBelong(this.instance);
				}
				return r_FixupTokens;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_Save;
		public virtual RMethod RSave
		{
			get
			{
				if(r_Save == null)
				{
					r_Save = new(this, "Save", 0);
					r_Save.SetBelong(this.instance);
				}
				return r_Save;
			}
		}

		/// <summary>
		/// Void CreateGlobalType()
		/// </summary>
		protected RMethod r_CreateGlobalType;
		public virtual RMethod RCreateGlobalType
		{
			get
			{
				if(r_CreateGlobalType == null)
				{
					r_CreateGlobalType = new(this, "CreateGlobalType", 0);
					r_CreateGlobalType.SetBelong(this.instance);
				}
				return r_CreateGlobalType;
			}
		}

		/// <summary>
		/// System.Guid GetModuleVersionId()
		/// </summary>
		protected RMethod r_GetModuleVersionId;
		public virtual RMethod RGetModuleVersionId
		{
			get
			{
				if(r_GetModuleVersionId == null)
				{
					r_GetModuleVersionId = new(this, "GetModuleVersionId", 0);
					r_GetModuleVersionId.SetBelong(this.instance);
				}
				return r_GetModuleVersionId;
			}
		}

		/// <summary>
		/// Boolean IsResource()
		/// </summary>
		protected RMethod r_IsResource;
		public virtual RMethod RIsResource
		{
			get
			{
				if(r_IsResource == null)
				{
					r_IsResource = new(this, "IsResource", 0);
					r_IsResource.SetBelong(this.instance);
				}
				return r_IsResource;
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
		/// System.Reflection.FieldInfo ResolveField(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_ResolveField_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveField_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_ResolveField_Int32_TypeArray_TypeArray == null)
				{
					r_ResolveField_Int32_TypeArray_TypeArray = new(this, "ResolveField", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_ResolveField_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_ResolveField_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_ResolveMember_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveMember_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_ResolveMember_Int32_TypeArray_TypeArray == null)
				{
					r_ResolveMember_Int32_TypeArray_TypeArray = new(this, "ResolveMember", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_ResolveMember_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_ResolveMember_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveOrGetRegisteredToken(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_ResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_ResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray == null)
				{
					r_ResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray = new(this, "ResolveOrGetRegisteredToken", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_ResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_ResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_ResolveMethod_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveMethod_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_ResolveMethod_Int32_TypeArray_TypeArray == null)
				{
					r_ResolveMethod_Int32_TypeArray_TypeArray = new(this, "ResolveMethod", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_ResolveMethod_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_ResolveMethod_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.String ResolveString(Int32)
		/// </summary>
		protected RMethod r_ResolveString_Int32;
		public virtual RMethod RResolveString_Int32
		{
			get
			{
				if(r_ResolveString_Int32 == null)
				{
					r_ResolveString_Int32 = new(this, "ResolveString", 0, typeof(System.Int32));
					r_ResolveString_Int32.SetBelong(this.instance);
				}
				return r_ResolveString_Int32;
			}
		}

		/// <summary>
		/// Byte[] ResolveSignature(Int32)
		/// </summary>
		protected RMethod r_ResolveSignature_Int32;
		public virtual RMethod RResolveSignature_Int32
		{
			get
			{
				if(r_ResolveSignature_Int32 == null)
				{
					r_ResolveSignature_Int32 = new(this, "ResolveSignature", 0, typeof(System.Int32));
					r_ResolveSignature_Int32.SetBelong(this.instance);
				}
				return r_ResolveSignature_Int32;
			}
		}

		/// <summary>
		/// System.Type ResolveType(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_ResolveType_Int32_TypeArray_TypeArray;
		public virtual RMethod RResolveType_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_ResolveType_Int32_TypeArray_TypeArray == null)
				{
					r_ResolveType_Int32_TypeArray_TypeArray = new(this, "ResolveType", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_ResolveType_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_ResolveType_Int32_TypeArray_TypeArray;
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
		/// System.ModuleHandle GetModuleHandleImpl()
		/// </summary>
		protected RMethod r_GetModuleHandleImpl;
		public virtual RMethod RGetModuleHandleImpl
		{
			get
			{
				if(r_GetModuleHandleImpl == null)
				{
					r_GetModuleHandleImpl = new(this, "GetModuleHandleImpl", 0);
					r_GetModuleHandleImpl.SetBelong(this.instance);
				}
				return r_GetModuleHandleImpl;
			}
		}

		/// <summary>
		/// Void GetPEKind(System.Reflection.PortableExecutableKinds ByRef, System.Reflection.ImageFileMachine ByRef)
		/// </summary>
		protected RMethod r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
		public virtual RMethod RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine
		{
			get
			{
				if(r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine == null)
				{
					r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine = new(this, "GetPEKind", 0, typeof(System.Reflection.PortableExecutableKinds).MakeByRefType(), typeof(System.Reflection.ImageFileMachine).MakeByRefType());
					r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(this.instance);
				}
				return r_GetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
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
		/// System.Type[] FindTypes(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_FindTypes_TypeFilter_Object;
		public virtual RMethod RFindTypes_TypeFilter_Object
		{
			get
			{
				if(r_FindTypes_TypeFilter_Object == null)
				{
					r_FindTypes_TypeFilter_Object = new(this, "FindTypes", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_FindTypes_TypeFilter_Object.SetBelong(this.instance);
				}
				return r_FindTypes_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo ResolveField(Int32)
		/// </summary>
		protected RMethod r_ResolveField_Int32;
		public virtual RMethod RResolveField_Int32
		{
			get
			{
				if(r_ResolveField_Int32 == null)
				{
					r_ResolveField_Int32 = new(this, "ResolveField", 0, typeof(System.Int32));
					r_ResolveField_Int32.SetBelong(this.instance);
				}
				return r_ResolveField_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveMember(Int32)
		/// </summary>
		protected RMethod r_ResolveMember_Int32;
		public virtual RMethod RResolveMember_Int32
		{
			get
			{
				if(r_ResolveMember_Int32 == null)
				{
					r_ResolveMember_Int32 = new(this, "ResolveMember", 0, typeof(System.Int32));
					r_ResolveMember_Int32.SetBelong(this.instance);
				}
				return r_ResolveMember_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase ResolveMethod(Int32)
		/// </summary>
		protected RMethod r_ResolveMethod_Int32;
		public virtual RMethod RResolveMethod_Int32
		{
			get
			{
				if(r_ResolveMethod_Int32 == null)
				{
					r_ResolveMethod_Int32 = new(this, "ResolveMethod", 0, typeof(System.Int32));
					r_ResolveMethod_Int32.SetBelong(this.instance);
				}
				return r_ResolveMethod_Int32;
			}
		}

		/// <summary>
		/// System.Type ResolveType(Int32)
		/// </summary>
		protected RMethod r_ResolveType_Int32;
		public virtual RMethod RResolveType_Int32
		{
			get
			{
				if(r_ResolveType_Int32 == null)
				{
					r_ResolveType_Int32 = new(this, "ResolveType", 0, typeof(System.Int32));
					r_ResolveType_Int32.SetBelong(this.instance);
				}
				return r_ResolveType_Int32;
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
		/// System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
		/// </summary>
		protected RMethod r_GetSignerCertificate;
		public virtual RMethod RGetSignerCertificate
		{
			get
			{
				if(r_GetSignerCertificate == null)
				{
					r_GetSignerCertificate = new(this, "GetSignerCertificate", 0);
					r_GetSignerCertificate.SetBelong(this.instance);
				}
				return r_GetSignerCertificate;
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

        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void basic_init(System.Reflection.Emit.ModuleBuilder @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = Rbasic_init_ModuleBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public static void set_wrappers_type(System.Reflection.Emit.ModuleBuilder @mb, System.Type @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @ab};
            var ___result = Rset_wrappers_type_ModuleBuilder_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static void WarnAboutSymbolWriter(System.String @message)
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


        public virtual System.Reflection.Emit.FieldBuilder DefineDataImpl(System.String @name, System.Int32 @size, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @attributes};
            var ___result = RDefineDataImpl_String_Int32_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual void addGlobalMethod(System.Reflection.Emit.MethodBuilder @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = RaddGlobalMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @returnType, @parameterTypes};
            var ___result = RDefineGlobalMethod_String_MethodAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @parameterTypes};
            var ___result = RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @requiredReturnTypeCustomModifiers, System.Type[] @optionalReturnTypeCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @requiredParameterTypeCustomModifiers, System.Type[][] @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.String @entryName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @entryName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RDefineType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr};
            var ___result = RDefineType_String_TypeAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent};
            var ___result = RDefineType_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual void AddType(System.Reflection.Emit.TypeBuilder @tb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb};
            var ___result = RAddType_TypeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Type[] @interfaces, System.Reflection.Emit.PackingSize @packingSize, System.Int32 @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces, @packingSize, @typesize};
            var ___result = RDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual void RegisterTypeName(System.Reflection.Emit.TypeBuilder @tb, RSystem.RTypeName @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb, @name.Value};
            var ___result = RRegisterTypeName_TypeBuilder_TypeName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.TypeBuilder GetRegisteredType(RSystem.RTypeName @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name.Value};
            var ___result = RGetRegisteredType_TypeName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Type[] @interfaces)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces};
            var ___result = RDefineType_String_TypeAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Int32 @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @typesize};
            var ___result = RDefineType_String_TypeAttributes_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Reflection.Emit.PackingSize @packsize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packsize};
            var ___result = RDefineType_String_TypeAttributes_Type_PackingSize.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Reflection.Emit.PackingSize @packingSize, System.Int32 @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packingSize, @typesize};
            var ___result = RDefineType_String_TypeAttributes_Type_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.MethodInfo GetArrayMethod(System.Type @arrayClass, System.String @methodName, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrayClass, @methodName, @callingConvention, @returnType, @parameterTypes};
            var ___result = RGetArrayMethod_Type_String_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.Emit.EnumBuilder DefineEnum(System.String @name, System.Reflection.TypeAttributes @visibility, System.Type @underlyingType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @visibility, @underlyingType};
            var ___result = RDefineEnum_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.EnumBuilder)___result;
        }


        public virtual System.Type GetType(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @ignoreCase};
            var ___result = RGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder search_in_array(System.Reflection.Emit.TypeBuilder[] @arr, System.Int32 @validElementsInArray, RSystem.RTypeName @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr, @validElementsInArray, @className.Value};
            var ___result = Rsearch_in_array_TypeBuilderArray_Int32_TypeName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder search_nested_in_array(System.Reflection.Emit.TypeBuilder[] @arr, System.Int32 @validElementsInArray, RSystem.RTypeName @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr, @validElementsInArray, @className.Value};
            var ___result = Rsearch_nested_in_array_TypeBuilderArray_Int32_TypeName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder GetMaybeNested(System.Reflection.Emit.TypeBuilder @t, RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RTypeName> @nested)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @nested.Value};
            var ___result = RGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSymWriter.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolWriter)___result;
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String @url, System.Guid @language, System.Guid @languageVendor, System.Guid @documentType)
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


        public virtual System.Resources.IResourceWriter DefineResource(System.String @name, System.String @description, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @attribute};
            var ___result = RDefineResource_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String @name, System.String @description)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description};
            var ___result = RDefineResource_String_String.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual void DefineUnmanagedResource(System.Byte[] @resource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resource};
            var ___result = RDefineUnmanagedResource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineUnmanagedResource(System.String @resourceFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceFileName};
            var ___result = RDefineUnmanagedResource_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineManifestResource(System.String @name, System.IO.Stream @stream, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stream, @attribute};
            var ___result = RDefineManifestResource_String_Stream_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymCustomAttribute(System.String @name, System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RSetSymCustomAttribute_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUserEntryPoint(System.Reflection.MethodInfo @entryPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryPoint};
            var ___result = RSetUserEntryPoint_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RGetMethodToken_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo @method, System.Collections.Generic.IEnumerable<System.Type> @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @optionalParameterTypes};
            var ___result = RGetMethodToken_MethodInfo_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type @arrayClass, System.String @methodName, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrayClass, @methodName, @callingConvention, @returnType, @parameterTypes};
            var ___result = RGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo @con)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con};
            var ___result = RGetConstructorToken_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo @constructor, System.Collections.Generic.IEnumerable<System.Type> @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@constructor, @optionalParameterTypes};
            var ___result = RGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo @field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field};
            var ___result = RGetFieldToken_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldToken)___result;
        }


        public virtual System.Reflection.Emit.SignatureToken GetSignatureToken(System.Byte[] @sigBytes, System.Int32 @sigLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sigBytes, @sigLength};
            var ___result = RGetSignatureToken_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureToken)___result;
        }


        public virtual System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper @sigHelper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sigHelper};
            var ___result = RGetSignatureToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureToken)___result;
        }


        public virtual System.Reflection.Emit.StringToken GetStringConstant(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetStringConstant_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.StringToken)___result;
        }


        public virtual System.Reflection.Emit.TypeToken GetTypeToken(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetTypeToken_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeToken)___result;
        }


        public virtual System.Reflection.Emit.TypeToken GetTypeToken(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetTypeToken_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeToken)___result;
        }


        public static System.Int32 getUSIndex(System.Reflection.Emit.ModuleBuilder @mb, System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @str};
            var ___result = RgetUSIndex_ModuleBuilder_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 getToken(System.Reflection.Emit.ModuleBuilder @mb, System.Object @obj, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @obj, @create_open_instance};
            var ___result = RgetToken_ModuleBuilder_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 getMethodToken(System.Reflection.Emit.ModuleBuilder @mb, System.Reflection.MethodBase @method, System.Type[] @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @method, @opt_param_types};
            var ___result = RgetMethodToken_ModuleBuilder_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RGetToken_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPseudoToken(System.Reflection.MemberInfo @member, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RGetPseudoToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo @member)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member};
            var ___result = RGetToken_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo @member, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RGetToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase @method, System.Collections.Generic.IEnumerable<System.Type> @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RGetToken_MethodBase_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase @method, System.Type[] @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RGetToken_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.Emit.SignatureHelper @helper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@helper};
            var ___result = RGetToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RegisterToken(System.Object @obj, System.Int32 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @token};
            var ___result = RRegisterToken_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetRegisteredToken(System.Int32 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RGetRegisteredToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual RSystem.RReflection.REmit.RTokenGenerator GetTokenGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTokenGenerator.Invoke(___genericsType, ___parameters);

            return new RSystem.RReflection.REmit.RTokenGenerator(___result);
        }


        public static System.Object RuntimeResolve(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RRuntimeResolve_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void build_metadata(System.Reflection.Emit.ModuleBuilder @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = Rbuild_metadata_ModuleBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteToFile(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RWriteToFile_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map, System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, System.Int32> @inst_tokens, System.Boolean @open)
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


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveOrGetRegisteredToken(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.String ResolveString(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] ResolveSignature(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.Reflection.FieldInfo GetField(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags @bindingFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingFlags};
            var ___result = RGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags @bindingFlags)
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


        public virtual void GetPEKind(out System.Reflection.PortableExecutableKinds @peKind, out System.Reflection.ImageFileMachine @machine)
        {
			@peKind = default;
			@machine = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@peKind, @machine};
            var ___result = RGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.Invoke(___genericsType, ___parameters);
			@peKind = (System.Reflection.PortableExecutableKinds)___parameters[0];
			@machine = (System.Reflection.ImageFileMachine)___parameters[1];

            
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
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


        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RFindTypes_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveField_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveMember_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveMethod_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RResolveType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
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
