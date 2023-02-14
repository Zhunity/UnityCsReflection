
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ModuleBuilder
	/// </summary>
    public partial class RModuleBuilder : RMember //
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
					r_F_impl.SetBelong(this.instance);
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
					r_Fassembly.SetBelong(this.instance);
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
					r_Ffqname.SetBelong(this.instance);
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
					r_Fname.SetBelong(this.instance);
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
					r_Fscopename.SetBelong(this.instance);
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
					r_Fis_resource.SetBelong(this.instance);
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
					r_Ftoken.SetBelong(this.instance);
				}
				return r_Ftoken;
			}
		}

		/// <summary>
		/// System.UIntPtr dynamic_image
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUIntPtr r_Fdynamic_image;
		public virtual Hvak.Editor.Refleaction.RSystem.RUIntPtr RFdynamic_image
		{
			get
			{
				if(r_Fdynamic_image == null)
				{
					r_Fdynamic_image = new(this, "dynamic_image");
					r_Fdynamic_image.SetBelong(this.instance);
				}
				return r_Fdynamic_image;
			}
		}

		/// <summary>
		/// System.Int32 num_types
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnum_types;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnum_types
		{
			get
			{
				if(r_Fnum_types == null)
				{
					r_Fnum_types = new(this, "num_types");
					r_Fnum_types.SetBelong(this.instance);
				}
				return r_Fnum_types;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder[] types
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder> r_Ftypes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder> RFtypes
		{
			get
			{
				if(r_Ftypes == null)
				{
					r_Ftypes = new(this, "types");
					r_Ftypes.SetBelong(this.instance);
				}
				return r_Ftypes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> r_Fcattrs;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> RFcattrs
		{
			get
			{
				if(r_Fcattrs == null)
				{
					r_Fcattrs = new(this, "cattrs");
					r_Fcattrs.SetBelong(this.instance);
				}
				return r_Fcattrs;
			}
		}

		/// <summary>
		/// System.Byte[] guid
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fguid;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFguid
		{
			get
			{
				if(r_Fguid == null)
				{
					r_Fguid = new(this, "guid");
					r_Fguid.SetBelong(this.instance);
				}
				return r_Fguid;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftable_idx;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtable_idx
		{
			get
			{
				if(r_Ftable_idx == null)
				{
					r_Ftable_idx = new(this, "table_idx");
					r_Ftable_idx.SetBelong(this.instance);
				}
				return r_Ftable_idx;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.AssemblyBuilder assemblyb
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RAssemblyBuilder r_Fassemblyb;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RAssemblyBuilder RFassemblyb
		{
			get
			{
				if(r_Fassemblyb == null)
				{
					r_Fassemblyb = new(this, "assemblyb");
					r_Fassemblyb.SetBelong(this.instance);
				}
				return r_Fassemblyb;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder[] global_methods
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMethodBuilder> r_Fglobal_methods;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMethodBuilder> RFglobal_methods
		{
			get
			{
				if(r_Fglobal_methods == null)
				{
					r_Fglobal_methods = new(this, "global_methods");
					r_Fglobal_methods.SetBelong(this.instance);
				}
				return r_Fglobal_methods;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder[] global_fields
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFieldBuilder> r_Fglobal_fields;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFieldBuilder> RFglobal_fields
		{
			get
			{
				if(r_Fglobal_fields == null)
				{
					r_Fglobal_fields = new(this, "global_fields");
					r_Fglobal_fields.SetBelong(this.instance);
				}
				return r_Fglobal_fields;
			}
		}

		/// <summary>
		/// System.Boolean is_main
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fis_main;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFis_main
		{
			get
			{
				if(r_Fis_main == null)
				{
					r_Fis_main = new(this, "is_main");
					r_Fis_main.SetBelong(this.instance);
				}
				return r_Fis_main;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MonoResource[] resources
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMonoResource> r_Fresources;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMonoResource> RFresources
		{
			get
			{
				if(r_Fresources == null)
				{
					r_Fresources = new(this, "resources");
					r_Fresources.SetBelong(this.instance);
				}
				return r_Fresources;
			}
		}

		/// <summary>
		/// System.IntPtr unparented_classes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Funparented_classes;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFunparented_classes
		{
			get
			{
				if(r_Funparented_classes == null)
				{
					r_Funparented_classes = new(this, "unparented_classes");
					r_Funparented_classes.SetBelong(this.instance);
				}
				return r_Funparented_classes;
			}
		}

		/// <summary>
		/// System.Int32[] table_indexes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Ftable_indexes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFtable_indexes
		{
			get
			{
				if(r_Ftable_indexes == null)
				{
					r_Ftable_indexes = new(this, "table_indexes");
					r_Ftable_indexes.SetBelong(this.instance);
				}
				return r_Ftable_indexes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder global_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder r_Fglobal_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder RFglobal_type
		{
			get
			{
				if(r_Fglobal_type == null)
				{
					r_Fglobal_type = new(this, "global_type");
					r_Fglobal_type.SetBelong(this.instance);
				}
				return r_Fglobal_type;
			}
		}

		/// <summary>
		/// System.Type global_type_created
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fglobal_type_created;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFglobal_type_created
		{
			get
			{
				if(r_Fglobal_type_created == null)
				{
					r_Fglobal_type_created = new(this, "global_type_created");
					r_Fglobal_type_created.SetBelong(this.instance);
				}
				return r_Fglobal_type_created;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.TypeName,System.Reflection.Emit.TypeBuilder] name_cache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RTypeName, Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder> r_Fname_cache;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RTypeName, Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder> RFname_cache
		{
			get
			{
				if(r_Fname_cache == null)
				{
					r_Fname_cache = new(this, "name_cache");
					r_Fname_cache.SetBelong(this.instance);
				}
				return r_Fname_cache;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] us_string_cache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> r_Fus_string_cache;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> RFus_string_cache
		{
			get
			{
				if(r_Fus_string_cache == null)
				{
					r_Fus_string_cache = new(this, "us_string_cache");
					r_Fus_string_cache.SetBelong(this.instance);
				}
				return r_Fus_string_cache;
			}
		}

		/// <summary>
		/// System.Boolean transient
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Ftransient;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFtransient
		{
			get
			{
				if(r_Ftransient == null)
				{
					r_Ftransient = new(this, "transient");
					r_Ftransient.SetBelong(this.instance);
				}
				return r_Ftransient;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilderTokenGenerator token_gen
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilderTokenGenerator r_Ftoken_gen;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilderTokenGenerator RFtoken_gen
		{
			get
			{
				if(r_Ftoken_gen == null)
				{
					r_Ftoken_gen = new(this, "token_gen");
					r_Ftoken_gen.SetBelong(this.instance);
				}
				return r_Ftoken_gen;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable resource_writers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fresource_writers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFresource_writers
		{
			get
			{
				if(r_Fresource_writers == null)
				{
					r_Fresource_writers = new(this, "resource_writers");
					r_Fresource_writers.SetBelong(this.instance);
				}
				return r_Fresource_writers;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolWriter symbolWriter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RISymbolWriter r_FsymbolWriter;
		public virtual Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RISymbolWriter RFsymbolWriter
		{
			get
			{
				if(r_FsymbolWriter == null)
				{
					r_FsymbolWriter = new(this, "symbolWriter");
					r_FsymbolWriter.SetBelong(this.instance);
				}
				return r_FsymbolWriter;
			}
		}

		/// <summary>
		/// System.Boolean has_warned_about_symbolWriter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fhas_warned_about_symbolWriter;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFhas_warned_about_symbolWriter
		{
			get
			{
				if(r_Fhas_warned_about_symbolWriter == null)
				{
					r_Fhas_warned_about_symbolWriter = new(typeof(System.Reflection.Emit.ModuleBuilder), "has_warned_about_symbolWriter");
					r_Fhas_warned_about_symbolWriter.SetBelong(null);
				}
				return r_Fhas_warned_about_symbolWriter;
			}
		}

		/// <summary>
		/// System.Int32 typeref_tokengen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftyperef_tokengen;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFtyperef_tokengen
		{
			get
			{
				if(r_Ftyperef_tokengen == null)
				{
					r_Ftyperef_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "typeref_tokengen");
					r_Ftyperef_tokengen.SetBelong(null);
				}
				return r_Ftyperef_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 typedef_tokengen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftypedef_tokengen;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFtypedef_tokengen
		{
			get
			{
				if(r_Ftypedef_tokengen == null)
				{
					r_Ftypedef_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "typedef_tokengen");
					r_Ftypedef_tokengen.SetBelong(null);
				}
				return r_Ftypedef_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 typespec_tokengen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftypespec_tokengen;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFtypespec_tokengen
		{
			get
			{
				if(r_Ftypespec_tokengen == null)
				{
					r_Ftypespec_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "typespec_tokengen");
					r_Ftypespec_tokengen.SetBelong(null);
				}
				return r_Ftypespec_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 memberref_tokengen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmemberref_tokengen;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFmemberref_tokengen
		{
			get
			{
				if(r_Fmemberref_tokengen == null)
				{
					r_Fmemberref_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "memberref_tokengen");
					r_Fmemberref_tokengen.SetBelong(null);
				}
				return r_Fmemberref_tokengen;
			}
		}

		/// <summary>
		/// System.Int32 methoddef_tokengen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmethoddef_tokengen;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFmethoddef_tokengen
		{
			get
			{
				if(r_Fmethoddef_tokengen == null)
				{
					r_Fmethoddef_tokengen = new(typeof(System.Reflection.Emit.ModuleBuilder), "methoddef_tokengen");
					r_Fmethoddef_tokengen.SetBelong(null);
				}
				return r_Fmethoddef_tokengen;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32] inst_tokens
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo, Hvak.Editor.Refleaction.RSystem.RInt32> r_Finst_tokens;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo, Hvak.Editor.Refleaction.RSystem.RInt32> RFinst_tokens
		{
			get
			{
				if(r_Finst_tokens == null)
				{
					r_Finst_tokens = new(this, "inst_tokens");
					r_Finst_tokens.SetBelong(this.instance);
				}
				return r_Finst_tokens;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32] inst_tokens_open
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo, Hvak.Editor.Refleaction.RSystem.RInt32> r_Finst_tokens_open;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo, Hvak.Editor.Refleaction.RSystem.RInt32> RFinst_tokens_open
		{
			get
			{
				if(r_Finst_tokens_open == null)
				{
					r_Finst_tokens_open = new(this, "inst_tokens_open");
					r_Finst_tokens_open.SetBelong(this.instance);
				}
				return r_Finst_tokens_open;
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
					r_PFullyQualifiedName.SetBelong(this.instance);
				}
				return r_PFullyQualifiedName;
			}
		}

		/// <summary>
		/// System.String FileName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFileName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFileName
		{
			get
			{
				if(r_PFileName == null)
				{
					r_PFileName = new(this, "FileName", -1);
					r_PFileName.SetBelong(this.instance);
				}
				return r_PFileName;
			}
		}

		/// <summary>
		/// Boolean IsMain
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMain;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMain
		{
			get
			{
				if(r_PIsMain == null)
				{
					r_PIsMain = new(this, "IsMain", -1);
					r_PIsMain.SetBelong(this.instance);
				}
				return r_PIsMain;
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
					r_PAssembly.SetBelong(this.instance);
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
					r_PName.SetBelong(this.instance);
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
					r_PScopeName.SetBelong(this.instance);
				}
				return r_PScopeName;
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
					r_PModuleVersionId.SetBelong(this.instance);
				}
				return r_PModuleVersionId;
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
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
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
					r_PMDStreamVersion.SetBelong(this.instance);
				}
				return r_PMDStreamVersion;
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
					r_PModuleHandle.SetBelong(this.instance);
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
					r_PCustomAttributes.SetBelong(this.instance);
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
					r_PMvId.SetBelong(this.instance);
				}
				return r_PMvId;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ModuleBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ModuleBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void basic_init(System.Reflection.Emit.ModuleBuilder)
		/// </summary>
		protected static RMethod r_Mbasic_init_ModuleBuilder;
		public static RMethod RMbasic_init_ModuleBuilder
		{
			get
			{
				if(r_Mbasic_init_ModuleBuilder == null)
				{
					r_Mbasic_init_ModuleBuilder = new(typeof(System.Reflection.Emit.ModuleBuilder), "basic_init", 0, typeof(System.Reflection.Emit.ModuleBuilder));
					r_Mbasic_init_ModuleBuilder.SetBelong(null);
				}
				return r_Mbasic_init_ModuleBuilder;
			}
		}

		/// <summary>
		/// Void set_wrappers_type(System.Reflection.Emit.ModuleBuilder, System.Type)
		/// </summary>
		protected static RMethod r_Mset_wrappers_type_ModuleBuilder_Type;
		public static RMethod RMset_wrappers_type_ModuleBuilder_Type
		{
			get
			{
				if(r_Mset_wrappers_type_ModuleBuilder_Type == null)
				{
					r_Mset_wrappers_type_ModuleBuilder_Type = new(typeof(System.Reflection.Emit.ModuleBuilder), "set_wrappers_type", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Type));
					r_Mset_wrappers_type_ModuleBuilder_Type.SetBelong(null);
				}
				return r_Mset_wrappers_type_ModuleBuilder_Type;
			}
		}

		/// <summary>
		/// Void WarnAboutSymbolWriter(System.String)
		/// </summary>
		protected static RMethod r_MWarnAboutSymbolWriter_String;
		public static RMethod RMWarnAboutSymbolWriter_String
		{
			get
			{
				if(r_MWarnAboutSymbolWriter_String == null)
				{
					r_MWarnAboutSymbolWriter_String = new(typeof(System.Reflection.Emit.ModuleBuilder), "WarnAboutSymbolWriter", 0, typeof(System.String));
					r_MWarnAboutSymbolWriter_String.SetBelong(null);
				}
				return r_MWarnAboutSymbolWriter_String;
			}
		}

		/// <summary>
		/// Boolean IsTransient()
		/// </summary>
		protected RMethod r_MIsTransient;
		public virtual RMethod RMIsTransient
		{
			get
			{
				if(r_MIsTransient == null)
				{
					r_MIsTransient = new(this, "IsTransient", 0);
					r_MIsTransient.SetBelong(this.instance);
				}
				return r_MIsTransient;
			}
		}

		/// <summary>
		/// Void CreateGlobalFunctions()
		/// </summary>
		protected RMethod r_MCreateGlobalFunctions;
		public virtual RMethod RMCreateGlobalFunctions
		{
			get
			{
				if(r_MCreateGlobalFunctions == null)
				{
					r_MCreateGlobalFunctions = new(this, "CreateGlobalFunctions", 0);
					r_MCreateGlobalFunctions.SetBelong(this.instance);
				}
				return r_MCreateGlobalFunctions;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineInitializedData(System.String, Byte[], System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_MDefineInitializedData_String_ByteArray_FieldAttributes;
		public virtual RMethod RMDefineInitializedData_String_ByteArray_FieldAttributes
		{
			get
			{
				if(r_MDefineInitializedData_String_ByteArray_FieldAttributes == null)
				{
					r_MDefineInitializedData_String_ByteArray_FieldAttributes = new(this, "DefineInitializedData", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Reflection.FieldAttributes));
					r_MDefineInitializedData_String_ByteArray_FieldAttributes.SetBelong(this.instance);
				}
				return r_MDefineInitializedData_String_ByteArray_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineUninitializedData(System.String, Int32, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_MDefineUninitializedData_String_Int32_FieldAttributes;
		public virtual RMethod RMDefineUninitializedData_String_Int32_FieldAttributes
		{
			get
			{
				if(r_MDefineUninitializedData_String_Int32_FieldAttributes == null)
				{
					r_MDefineUninitializedData_String_Int32_FieldAttributes = new(this, "DefineUninitializedData", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.FieldAttributes));
					r_MDefineUninitializedData_String_Int32_FieldAttributes.SetBelong(this.instance);
				}
				return r_MDefineUninitializedData_String_Int32_FieldAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldBuilder DefineDataImpl(System.String, Int32, System.Reflection.FieldAttributes)
		/// </summary>
		protected RMethod r_MDefineDataImpl_String_Int32_FieldAttributes;
		public virtual RMethod RMDefineDataImpl_String_Int32_FieldAttributes
		{
			get
			{
				if(r_MDefineDataImpl_String_Int32_FieldAttributes == null)
				{
					r_MDefineDataImpl_String_Int32_FieldAttributes = new(this, "DefineDataImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.FieldAttributes));
					r_MDefineDataImpl_String_Int32_FieldAttributes.SetBelong(this.instance);
				}
				return r_MDefineDataImpl_String_Int32_FieldAttributes;
			}
		}

		/// <summary>
		/// Void addGlobalMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_MaddGlobalMethod_MethodBuilder;
		public virtual RMethod RMaddGlobalMethod_MethodBuilder
		{
			get
			{
				if(r_MaddGlobalMethod_MethodBuilder == null)
				{
					r_MaddGlobalMethod_MethodBuilder = new(this, "addGlobalMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_MaddGlobalMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_MaddGlobalMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MDefineGlobalMethod_String_MethodAttributes_Type_TypeArray;
		public virtual RMethod RMDefineGlobalMethod_String_MethodAttributes_Type_TypeArray
		{
			get
			{
				if(r_MDefineGlobalMethod_String_MethodAttributes_Type_TypeArray == null)
				{
					r_MDefineGlobalMethod_String_MethodAttributes_Type_TypeArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MDefineGlobalMethod_String_MethodAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_MDefineGlobalMethod_String_MethodAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
		public virtual RMethod RMDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray == null)
				{
					r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RMDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "DefineGlobalMethod", 0, typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_MDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_MDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
		public virtual RMethod RMDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet
		{
			get
			{
				if(r_MDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet == null)
				{
					r_MDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_MDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_MDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String, System.String, System.String, System.Reflection.MethodAttributes, System.Reflection.CallingConventions, System.Type, System.Type[], System.Runtime.InteropServices.CallingConvention, System.Runtime.InteropServices.CharSet)
		/// </summary>
		protected RMethod r_MDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
		public virtual RMethod RMDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet
		{
			get
			{
				if(r_MDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet == null)
				{
					r_MDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet = new(this, "DefinePInvokeMethod", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Reflection.MethodAttributes), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Runtime.InteropServices.CharSet));
					r_MDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.SetBelong(this.instance);
				}
				return r_MDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String)
		/// </summary>
		protected RMethod r_MDefineType_String;
		public virtual RMethod RMDefineType_String
		{
			get
			{
				if(r_MDefineType_String == null)
				{
					r_MDefineType_String = new(this, "DefineType", 0, typeof(System.String));
					r_MDefineType_String.SetBelong(this.instance);
				}
				return r_MDefineType_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes)
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes;
		public virtual RMethod RMDefineType_String_TypeAttributes
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes == null)
				{
					r_MDefineType_String_TypeAttributes = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes));
					r_MDefineType_String_TypeAttributes.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes_Type;
		public virtual RMethod RMDefineType_String_TypeAttributes_Type
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes_Type == null)
				{
					r_MDefineType_String_TypeAttributes_Type = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_MDefineType_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes_Type;
			}
		}

		/// <summary>
		/// Void AddType(System.Reflection.Emit.TypeBuilder)
		/// </summary>
		protected RMethod r_MAddType_TypeBuilder;
		public virtual RMethod RMAddType_TypeBuilder
		{
			get
			{
				if(r_MAddType_TypeBuilder == null)
				{
					r_MAddType_TypeBuilder = new(this, "AddType", 0, typeof(System.Reflection.Emit.TypeBuilder));
					r_MAddType_TypeBuilder.SetBelong(this.instance);
				}
				return r_MAddType_TypeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[], System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
		public virtual RMethod RMDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 == null)
				{
					r_MDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_MDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32;
			}
		}

		/// <summary>
		/// Void RegisterTypeName(System.Reflection.Emit.TypeBuilder, System.TypeName)
		/// </summary>
		protected RMethod r_MRegisterTypeName_TypeBuilder_TypeName;
		public virtual RMethod RMRegisterTypeName_TypeBuilder_TypeName
		{
			get
			{
				if(r_MRegisterTypeName_TypeBuilder_TypeName == null)
				{
					r_MRegisterTypeName_TypeBuilder_TypeName = new(this, "RegisterTypeName", 0, typeof(System.Reflection.Emit.TypeBuilder),  ReflectionUtils.GetType("System.TypeName"));
					r_MRegisterTypeName_TypeBuilder_TypeName.SetBelong(this.instance);
				}
				return r_MRegisterTypeName_TypeBuilder_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder GetRegisteredType(System.TypeName)
		/// </summary>
		protected RMethod r_MGetRegisteredType_TypeName;
		public virtual RMethod RMGetRegisteredType_TypeName
		{
			get
			{
				if(r_MGetRegisteredType_TypeName == null)
				{
					r_MGetRegisteredType_TypeName = new(this, "GetRegisteredType", 0,  ReflectionUtils.GetType("System.TypeName"));
					r_MGetRegisteredType_TypeName.SetBelong(this.instance);
				}
				return r_MGetRegisteredType_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes_Type_TypeArray;
		public virtual RMethod RMDefineType_String_TypeAttributes_Type_TypeArray
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes_Type_TypeArray == null)
				{
					r_MDefineType_String_TypeAttributes_Type_TypeArray = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MDefineType_String_TypeAttributes_Type_TypeArray.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, Int32)
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes_Type_Int32;
		public virtual RMethod RMDefineType_String_TypeAttributes_Type_Int32
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes_Type_Int32 == null)
				{
					r_MDefineType_String_TypeAttributes_Type_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Int32));
					r_MDefineType_String_TypeAttributes_Type_Int32.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes_Type_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize)
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes_Type_PackingSize;
		public virtual RMethod RMDefineType_String_TypeAttributes_Type_PackingSize
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes_Type_PackingSize == null)
				{
					r_MDefineType_String_TypeAttributes_Type_PackingSize = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize));
					r_MDefineType_String_TypeAttributes_Type_PackingSize.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes_Type_PackingSize;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder DefineType(System.String, System.Reflection.TypeAttributes, System.Type, System.Reflection.Emit.PackingSize, Int32)
		/// </summary>
		protected RMethod r_MDefineType_String_TypeAttributes_Type_PackingSize_Int32;
		public virtual RMethod RMDefineType_String_TypeAttributes_Type_PackingSize_Int32
		{
			get
			{
				if(r_MDefineType_String_TypeAttributes_Type_PackingSize_Int32 == null)
				{
					r_MDefineType_String_TypeAttributes_Type_PackingSize_Int32 = new(this, "DefineType", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type), typeof(System.Reflection.Emit.PackingSize), typeof(System.Int32));
					r_MDefineType_String_TypeAttributes_Type_PackingSize_Int32.SetBelong(this.instance);
				}
				return r_MDefineType_String_TypeAttributes_Type_PackingSize_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetArrayMethod(System.Type, System.String, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MGetArrayMethod_Type_String_CallingConventions_Type_TypeArray;
		public virtual RMethod RMGetArrayMethod_Type_String_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_MGetArrayMethod_Type_String_CallingConventions_Type_TypeArray == null)
				{
					r_MGetArrayMethod_Type_String_CallingConventions_Type_TypeArray = new(this, "GetArrayMethod", 0, typeof(System.Type), typeof(System.String), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MGetArrayMethod_Type_String_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_MGetArrayMethod_Type_String_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EnumBuilder DefineEnum(System.String, System.Reflection.TypeAttributes, System.Type)
		/// </summary>
		protected RMethod r_MDefineEnum_String_TypeAttributes_Type;
		public virtual RMethod RMDefineEnum_String_TypeAttributes_Type
		{
			get
			{
				if(r_MDefineEnum_String_TypeAttributes_Type == null)
				{
					r_MDefineEnum_String_TypeAttributes_Type = new(this, "DefineEnum", 0, typeof(System.String), typeof(System.Reflection.TypeAttributes), typeof(System.Type));
					r_MDefineEnum_String_TypeAttributes_Type.SetBelong(this.instance);
				}
				return r_MDefineEnum_String_TypeAttributes_Type;
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
					r_MGetType_String.SetBelong(this.instance);
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
					r_MGetType_String_Boolean.SetBelong(this.instance);
				}
				return r_MGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder search_in_array(System.Reflection.Emit.TypeBuilder[], Int32, System.TypeName)
		/// </summary>
		protected RMethod r_Msearch_in_array_TypeBuilderArray_Int32_TypeName;
		public virtual RMethod RMsearch_in_array_TypeBuilderArray_Int32_TypeName
		{
			get
			{
				if(r_Msearch_in_array_TypeBuilderArray_Int32_TypeName == null)
				{
					r_Msearch_in_array_TypeBuilderArray_Int32_TypeName = new(this, "search_in_array", 0, typeof(System.Reflection.Emit.TypeBuilder).MakeArrayType(), typeof(System.Int32),  ReflectionUtils.GetType("System.TypeName"));
					r_Msearch_in_array_TypeBuilderArray_Int32_TypeName.SetBelong(this.instance);
				}
				return r_Msearch_in_array_TypeBuilderArray_Int32_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder search_nested_in_array(System.Reflection.Emit.TypeBuilder[], Int32, System.TypeName)
		/// </summary>
		protected RMethod r_Msearch_nested_in_array_TypeBuilderArray_Int32_TypeName;
		public virtual RMethod RMsearch_nested_in_array_TypeBuilderArray_Int32_TypeName
		{
			get
			{
				if(r_Msearch_nested_in_array_TypeBuilderArray_Int32_TypeName == null)
				{
					r_Msearch_nested_in_array_TypeBuilderArray_Int32_TypeName = new(this, "search_nested_in_array", 0, typeof(System.Reflection.Emit.TypeBuilder).MakeArrayType(), typeof(System.Int32),  ReflectionUtils.GetType("System.TypeName"));
					r_Msearch_nested_in_array_TypeBuilderArray_Int32_TypeName.SetBelong(this.instance);
				}
				return r_Msearch_nested_in_array_TypeBuilderArray_Int32_TypeName;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder GetMaybeNested(System.Reflection.Emit.TypeBuilder, System.Collections.Generic.IEnumerable`1[System.TypeName])
		/// </summary>
		protected RMethod r_MGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_;
		public virtual RMethod RMGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_
		{
			get
			{
				if(r_MGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_ == null)
				{
					r_MGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_ = new(this, "GetMaybeNested", 0, typeof(System.Reflection.Emit.TypeBuilder), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType( ReflectionUtils.GetType("System.TypeName")));
					r_MGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_.SetBelong(this.instance);
				}
				return r_MGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_;
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
					r_MGetType_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 get_next_table_index(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_Mget_next_table_index_Object_Int32_Int32;
		public virtual RMethod RMget_next_table_index_Object_Int32_Int32
		{
			get
			{
				if(r_Mget_next_table_index_Object_Int32_Int32 == null)
				{
					r_Mget_next_table_index_Object_Int32_Int32 = new(this, "get_next_table_index", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_Mget_next_table_index_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_Mget_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_MSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RMSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_MSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_MSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_MSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_MSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_MSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RMSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_MSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_MSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_MSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_MSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter()
		/// </summary>
		protected RMethod r_MGetSymWriter;
		public virtual RMethod RMGetSymWriter
		{
			get
			{
				if(r_MGetSymWriter == null)
				{
					r_MGetSymWriter = new(this, "GetSymWriter", 0);
					r_MGetSymWriter.SetBelong(this.instance);
				}
				return r_MGetSymWriter;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String, System.Guid, System.Guid, System.Guid)
		/// </summary>
		protected RMethod r_MDefineDocument_String_Guid_Guid_Guid;
		public virtual RMethod RMDefineDocument_String_Guid_Guid_Guid
		{
			get
			{
				if(r_MDefineDocument_String_Guid_Guid_Guid == null)
				{
					r_MDefineDocument_String_Guid_Guid_Guid = new(this, "DefineDocument", 0, typeof(System.String), typeof(System.Guid), typeof(System.Guid), typeof(System.Guid));
					r_MDefineDocument_String_Guid_Guid_Guid.SetBelong(this.instance);
				}
				return r_MDefineDocument_String_Guid_Guid_Guid;
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
					r_MGetTypes.SetBelong(this.instance);
				}
				return r_MGetTypes;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_MDefineResource_String_String_ResourceAttributes;
		public virtual RMethod RMDefineResource_String_String_ResourceAttributes
		{
			get
			{
				if(r_MDefineResource_String_String_ResourceAttributes == null)
				{
					r_MDefineResource_String_String_ResourceAttributes = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String), typeof(System.Reflection.ResourceAttributes));
					r_MDefineResource_String_String_ResourceAttributes.SetBelong(this.instance);
				}
				return r_MDefineResource_String_String_ResourceAttributes;
			}
		}

		/// <summary>
		/// System.Resources.IResourceWriter DefineResource(System.String, System.String)
		/// </summary>
		protected RMethod r_MDefineResource_String_String;
		public virtual RMethod RMDefineResource_String_String
		{
			get
			{
				if(r_MDefineResource_String_String == null)
				{
					r_MDefineResource_String_String = new(this, "DefineResource", 0, typeof(System.String), typeof(System.String));
					r_MDefineResource_String_String.SetBelong(this.instance);
				}
				return r_MDefineResource_String_String;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(Byte[])
		/// </summary>
		protected RMethod r_MDefineUnmanagedResource_ByteArray;
		public virtual RMethod RMDefineUnmanagedResource_ByteArray
		{
			get
			{
				if(r_MDefineUnmanagedResource_ByteArray == null)
				{
					r_MDefineUnmanagedResource_ByteArray = new(this, "DefineUnmanagedResource", 0, typeof(System.Byte).MakeArrayType());
					r_MDefineUnmanagedResource_ByteArray.SetBelong(this.instance);
				}
				return r_MDefineUnmanagedResource_ByteArray;
			}
		}

		/// <summary>
		/// Void DefineUnmanagedResource(System.String)
		/// </summary>
		protected RMethod r_MDefineUnmanagedResource_String;
		public virtual RMethod RMDefineUnmanagedResource_String
		{
			get
			{
				if(r_MDefineUnmanagedResource_String == null)
				{
					r_MDefineUnmanagedResource_String = new(this, "DefineUnmanagedResource", 0, typeof(System.String));
					r_MDefineUnmanagedResource_String.SetBelong(this.instance);
				}
				return r_MDefineUnmanagedResource_String;
			}
		}

		/// <summary>
		/// Void DefineManifestResource(System.String, System.IO.Stream, System.Reflection.ResourceAttributes)
		/// </summary>
		protected RMethod r_MDefineManifestResource_String_Stream_ResourceAttributes;
		public virtual RMethod RMDefineManifestResource_String_Stream_ResourceAttributes
		{
			get
			{
				if(r_MDefineManifestResource_String_Stream_ResourceAttributes == null)
				{
					r_MDefineManifestResource_String_Stream_ResourceAttributes = new(this, "DefineManifestResource", 0, typeof(System.String), typeof(System.IO.Stream), typeof(System.Reflection.ResourceAttributes));
					r_MDefineManifestResource_String_Stream_ResourceAttributes.SetBelong(this.instance);
				}
				return r_MDefineManifestResource_String_Stream_ResourceAttributes;
			}
		}

		/// <summary>
		/// Void SetSymCustomAttribute(System.String, Byte[])
		/// </summary>
		protected RMethod r_MSetSymCustomAttribute_String_ByteArray;
		public virtual RMethod RMSetSymCustomAttribute_String_ByteArray
		{
			get
			{
				if(r_MSetSymCustomAttribute_String_ByteArray == null)
				{
					r_MSetSymCustomAttribute_String_ByteArray = new(this, "SetSymCustomAttribute", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
					r_MSetSymCustomAttribute_String_ByteArray.SetBelong(this.instance);
				}
				return r_MSetSymCustomAttribute_String_ByteArray;
			}
		}

		/// <summary>
		/// Void SetUserEntryPoint(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MSetUserEntryPoint_MethodInfo;
		public virtual RMethod RMSetUserEntryPoint_MethodInfo
		{
			get
			{
				if(r_MSetUserEntryPoint_MethodInfo == null)
				{
					r_MSetUserEntryPoint_MethodInfo = new(this, "SetUserEntryPoint", 0, typeof(System.Reflection.MethodInfo));
					r_MSetUserEntryPoint_MethodInfo.SetBelong(this.instance);
				}
				return r_MSetUserEntryPoint_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MGetMethodToken_MethodInfo;
		public virtual RMethod RMGetMethodToken_MethodInfo
		{
			get
			{
				if(r_MGetMethodToken_MethodInfo == null)
				{
					r_MGetMethodToken_MethodInfo = new(this, "GetMethodToken", 0, typeof(System.Reflection.MethodInfo));
					r_MGetMethodToken_MethodInfo.SetBelong(this.instance);
				}
				return r_MGetMethodToken_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_MGetMethodToken_MethodInfo_IEnumerable_d_Type_p_;
		public virtual RMethod RMGetMethodToken_MethodInfo_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_MGetMethodToken_MethodInfo_IEnumerable_d_Type_p_ == null)
				{
					r_MGetMethodToken_MethodInfo_IEnumerable_d_Type_p_ = new(this, "GetMethodToken", 0, typeof(System.Reflection.MethodInfo), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_MGetMethodToken_MethodInfo_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_MGetMethodToken_MethodInfo_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type, System.String, System.Reflection.CallingConventions, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray;
		public virtual RMethod RMGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray
		{
			get
			{
				if(r_MGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray == null)
				{
					r_MGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray = new(this, "GetArrayMethodToken", 0, typeof(System.Type), typeof(System.String), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray.SetBelong(this.instance);
				}
				return r_MGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_MGetConstructorToken_ConstructorInfo;
		public virtual RMethod RMGetConstructorToken_ConstructorInfo
		{
			get
			{
				if(r_MGetConstructorToken_ConstructorInfo == null)
				{
					r_MGetConstructorToken_ConstructorInfo = new(this, "GetConstructorToken", 0, typeof(System.Reflection.ConstructorInfo));
					r_MGetConstructorToken_ConstructorInfo.SetBelong(this.instance);
				}
				return r_MGetConstructorToken_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_MGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_;
		public virtual RMethod RMGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_MGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_ == null)
				{
					r_MGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_ = new(this, "GetConstructorToken", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_MGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_MGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_MGetFieldToken_FieldInfo;
		public virtual RMethod RMGetFieldToken_FieldInfo
		{
			get
			{
				if(r_MGetFieldToken_FieldInfo == null)
				{
					r_MGetFieldToken_FieldInfo = new(this, "GetFieldToken", 0, typeof(System.Reflection.FieldInfo));
					r_MGetFieldToken_FieldInfo.SetBelong(this.instance);
				}
				return r_MGetFieldToken_FieldInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken GetSignatureToken(Byte[], Int32)
		/// </summary>
		protected RMethod r_MGetSignatureToken_ByteArray_Int32;
		public virtual RMethod RMGetSignatureToken_ByteArray_Int32
		{
			get
			{
				if(r_MGetSignatureToken_ByteArray_Int32 == null)
				{
					r_MGetSignatureToken_ByteArray_Int32 = new(this, "GetSignatureToken", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MGetSignatureToken_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MGetSignatureToken_ByteArray_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_MGetSignatureToken_SignatureHelper;
		public virtual RMethod RMGetSignatureToken_SignatureHelper
		{
			get
			{
				if(r_MGetSignatureToken_SignatureHelper == null)
				{
					r_MGetSignatureToken_SignatureHelper = new(this, "GetSignatureToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_MGetSignatureToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_MGetSignatureToken_SignatureHelper;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StringToken GetStringConstant(System.String)
		/// </summary>
		protected RMethod r_MGetStringConstant_String;
		public virtual RMethod RMGetStringConstant_String
		{
			get
			{
				if(r_MGetStringConstant_String == null)
				{
					r_MGetStringConstant_String = new(this, "GetStringConstant", 0, typeof(System.String));
					r_MGetStringConstant_String.SetBelong(this.instance);
				}
				return r_MGetStringConstant_String;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken GetTypeToken(System.Type)
		/// </summary>
		protected RMethod r_MGetTypeToken_Type;
		public virtual RMethod RMGetTypeToken_Type
		{
			get
			{
				if(r_MGetTypeToken_Type == null)
				{
					r_MGetTypeToken_Type = new(this, "GetTypeToken", 0, typeof(System.Type));
					r_MGetTypeToken_Type.SetBelong(this.instance);
				}
				return r_MGetTypeToken_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken GetTypeToken(System.String)
		/// </summary>
		protected RMethod r_MGetTypeToken_String;
		public virtual RMethod RMGetTypeToken_String
		{
			get
			{
				if(r_MGetTypeToken_String == null)
				{
					r_MGetTypeToken_String = new(this, "GetTypeToken", 0, typeof(System.String));
					r_MGetTypeToken_String.SetBelong(this.instance);
				}
				return r_MGetTypeToken_String;
			}
		}

		/// <summary>
		/// Int32 getUSIndex(System.Reflection.Emit.ModuleBuilder, System.String)
		/// </summary>
		protected static RMethod r_MgetUSIndex_ModuleBuilder_String;
		public static RMethod RMgetUSIndex_ModuleBuilder_String
		{
			get
			{
				if(r_MgetUSIndex_ModuleBuilder_String == null)
				{
					r_MgetUSIndex_ModuleBuilder_String = new(typeof(System.Reflection.Emit.ModuleBuilder), "getUSIndex", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.String));
					r_MgetUSIndex_ModuleBuilder_String.SetBelong(null);
				}
				return r_MgetUSIndex_ModuleBuilder_String;
			}
		}

		/// <summary>
		/// Int32 getToken(System.Reflection.Emit.ModuleBuilder, System.Object, Boolean)
		/// </summary>
		protected static RMethod r_MgetToken_ModuleBuilder_Object_Boolean;
		public static RMethod RMgetToken_ModuleBuilder_Object_Boolean
		{
			get
			{
				if(r_MgetToken_ModuleBuilder_Object_Boolean == null)
				{
					r_MgetToken_ModuleBuilder_Object_Boolean = new(typeof(System.Reflection.Emit.ModuleBuilder), "getToken", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Object), typeof(System.Boolean));
					r_MgetToken_ModuleBuilder_Object_Boolean.SetBelong(null);
				}
				return r_MgetToken_ModuleBuilder_Object_Boolean;
			}
		}

		/// <summary>
		/// Int32 getMethodToken(System.Reflection.Emit.ModuleBuilder, System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected static RMethod r_MgetMethodToken_ModuleBuilder_MethodBase_TypeArray;
		public static RMethod RMgetMethodToken_ModuleBuilder_MethodBase_TypeArray
		{
			get
			{
				if(r_MgetMethodToken_ModuleBuilder_MethodBase_TypeArray == null)
				{
					r_MgetMethodToken_ModuleBuilder_MethodBase_TypeArray = new(typeof(System.Reflection.Emit.ModuleBuilder), "getMethodToken", 0, typeof(System.Reflection.Emit.ModuleBuilder), typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_MgetMethodToken_ModuleBuilder_MethodBase_TypeArray.SetBelong(null);
				}
				return r_MgetMethodToken_ModuleBuilder_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.String)
		/// </summary>
		protected RMethod r_MGetToken_String;
		public virtual RMethod RMGetToken_String
		{
			get
			{
				if(r_MGetToken_String == null)
				{
					r_MGetToken_String = new(this, "GetToken", 0, typeof(System.String));
					r_MGetToken_String.SetBelong(this.instance);
				}
				return r_MGetToken_String;
			}
		}

		/// <summary>
		/// Int32 GetPseudoToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_MGetPseudoToken_MemberInfo_Boolean;
		public virtual RMethod RMGetPseudoToken_MemberInfo_Boolean
		{
			get
			{
				if(r_MGetPseudoToken_MemberInfo_Boolean == null)
				{
					r_MGetPseudoToken_MemberInfo_Boolean = new(this, "GetPseudoToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_MGetPseudoToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_MGetPseudoToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MGetToken_MemberInfo;
		public virtual RMethod RMGetToken_MemberInfo
		{
			get
			{
				if(r_MGetToken_MemberInfo == null)
				{
					r_MGetToken_MemberInfo = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo));
					r_MGetToken_MemberInfo.SetBelong(this.instance);
				}
				return r_MGetToken_MemberInfo;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MemberInfo, Boolean)
		/// </summary>
		protected RMethod r_MGetToken_MemberInfo_Boolean;
		public virtual RMethod RMGetToken_MemberInfo_Boolean
		{
			get
			{
				if(r_MGetToken_MemberInfo_Boolean == null)
				{
					r_MGetToken_MemberInfo_Boolean = new(this, "GetToken", 0, typeof(System.Reflection.MemberInfo), typeof(System.Boolean));
					r_MGetToken_MemberInfo_Boolean.SetBelong(this.instance);
				}
				return r_MGetToken_MemberInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Collections.Generic.IEnumerable`1[System.Type])
		/// </summary>
		protected RMethod r_MGetToken_MethodBase_IEnumerable_d_Type_p_;
		public virtual RMethod RMGetToken_MethodBase_IEnumerable_d_Type_p_
		{
			get
			{
				if(r_MGetToken_MethodBase_IEnumerable_d_Type_p_ == null)
				{
					r_MGetToken_MethodBase_IEnumerable_d_Type_p_ = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Type)));
					r_MGetToken_MethodBase_IEnumerable_d_Type_p_.SetBelong(this.instance);
				}
				return r_MGetToken_MethodBase_IEnumerable_d_Type_p_;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.MethodBase, System.Type[])
		/// </summary>
		protected RMethod r_MGetToken_MethodBase_TypeArray;
		public virtual RMethod RMGetToken_MethodBase_TypeArray
		{
			get
			{
				if(r_MGetToken_MethodBase_TypeArray == null)
				{
					r_MGetToken_MethodBase_TypeArray = new(this, "GetToken", 0, typeof(System.Reflection.MethodBase), typeof(System.Type).MakeArrayType());
					r_MGetToken_MethodBase_TypeArray.SetBelong(this.instance);
				}
				return r_MGetToken_MethodBase_TypeArray;
			}
		}

		/// <summary>
		/// Int32 GetToken(System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_MGetToken_SignatureHelper;
		public virtual RMethod RMGetToken_SignatureHelper
		{
			get
			{
				if(r_MGetToken_SignatureHelper == null)
				{
					r_MGetToken_SignatureHelper = new(this, "GetToken", 0, typeof(System.Reflection.Emit.SignatureHelper));
					r_MGetToken_SignatureHelper.SetBelong(this.instance);
				}
				return r_MGetToken_SignatureHelper;
			}
		}

		/// <summary>
		/// Void RegisterToken(System.Object, Int32)
		/// </summary>
		protected RMethod r_MRegisterToken_Object_Int32;
		public virtual RMethod RMRegisterToken_Object_Int32
		{
			get
			{
				if(r_MRegisterToken_Object_Int32 == null)
				{
					r_MRegisterToken_Object_Int32 = new(this, "RegisterToken", 0, typeof(System.Object), typeof(System.Int32));
					r_MRegisterToken_Object_Int32.SetBelong(this.instance);
				}
				return r_MRegisterToken_Object_Int32;
			}
		}

		/// <summary>
		/// System.Object GetRegisteredToken(Int32)
		/// </summary>
		protected RMethod r_MGetRegisteredToken_Int32;
		public virtual RMethod RMGetRegisteredToken_Int32
		{
			get
			{
				if(r_MGetRegisteredToken_Int32 == null)
				{
					r_MGetRegisteredToken_Int32 = new(this, "GetRegisteredToken", 0, typeof(System.Int32));
					r_MGetRegisteredToken_Int32.SetBelong(this.instance);
				}
				return r_MGetRegisteredToken_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator GetTokenGenerator()
		/// </summary>
		protected RMethod r_MGetTokenGenerator;
		public virtual RMethod RMGetTokenGenerator
		{
			get
			{
				if(r_MGetTokenGenerator == null)
				{
					r_MGetTokenGenerator = new(this, "GetTokenGenerator", 0);
					r_MGetTokenGenerator.SetBelong(this.instance);
				}
				return r_MGetTokenGenerator;
			}
		}

		/// <summary>
		/// System.Object RuntimeResolve(System.Object)
		/// </summary>
		protected static RMethod r_MRuntimeResolve_Object;
		public static RMethod RMRuntimeResolve_Object
		{
			get
			{
				if(r_MRuntimeResolve_Object == null)
				{
					r_MRuntimeResolve_Object = new(typeof(System.Reflection.Emit.ModuleBuilder), "RuntimeResolve", 0, typeof(System.Object));
					r_MRuntimeResolve_Object.SetBelong(null);
				}
				return r_MRuntimeResolve_Object;
			}
		}

		/// <summary>
		/// Void build_metadata(System.Reflection.Emit.ModuleBuilder)
		/// </summary>
		protected static RMethod r_Mbuild_metadata_ModuleBuilder;
		public static RMethod RMbuild_metadata_ModuleBuilder
		{
			get
			{
				if(r_Mbuild_metadata_ModuleBuilder == null)
				{
					r_Mbuild_metadata_ModuleBuilder = new(typeof(System.Reflection.Emit.ModuleBuilder), "build_metadata", 0, typeof(System.Reflection.Emit.ModuleBuilder));
					r_Mbuild_metadata_ModuleBuilder.SetBelong(null);
				}
				return r_Mbuild_metadata_ModuleBuilder;
			}
		}

		/// <summary>
		/// Void WriteToFile(IntPtr)
		/// </summary>
		protected RMethod r_MWriteToFile_IntPtr;
		public virtual RMethod RMWriteToFile_IntPtr
		{
			get
			{
				if(r_MWriteToFile_IntPtr == null)
				{
					r_MWriteToFile_IntPtr = new(this, "WriteToFile", 0, typeof(System.IntPtr));
					r_MWriteToFile_IntPtr.SetBelong(this.instance);
				}
				return r_MWriteToFile_IntPtr;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo], System.Collections.Generic.Dictionary`2[System.Reflection.MemberInfo,System.Int32], Boolean)
		/// </summary>
		protected RMethod r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean;
		public virtual RMethod RMFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean
		{
			get
			{
				if(r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean == null)
				{
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Reflection.MemberInfo), typeof(System.Int32)), typeof(System.Boolean));
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean.SetBelong(this.instance);
				}
				return r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean;
			}
		}

		/// <summary>
		/// Void FixupTokens()
		/// </summary>
		protected RMethod r_MFixupTokens;
		public virtual RMethod RMFixupTokens
		{
			get
			{
				if(r_MFixupTokens == null)
				{
					r_MFixupTokens = new(this, "FixupTokens", 0);
					r_MFixupTokens.SetBelong(this.instance);
				}
				return r_MFixupTokens;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_MSave;
		public virtual RMethod RMSave
		{
			get
			{
				if(r_MSave == null)
				{
					r_MSave = new(this, "Save", 0);
					r_MSave.SetBelong(this.instance);
				}
				return r_MSave;
			}
		}

		/// <summary>
		/// Void CreateGlobalType()
		/// </summary>
		protected RMethod r_MCreateGlobalType;
		public virtual RMethod RMCreateGlobalType
		{
			get
			{
				if(r_MCreateGlobalType == null)
				{
					r_MCreateGlobalType = new(this, "CreateGlobalType", 0);
					r_MCreateGlobalType.SetBelong(this.instance);
				}
				return r_MCreateGlobalType;
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
					r_MGetModuleVersionId.SetBelong(this.instance);
				}
				return r_MGetModuleVersionId;
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
					r_MIsResource.SetBelong(this.instance);
				}
				return r_MIsResource;
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
					r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
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
					r_MResolveField_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_MResolveField_Int32_TypeArray_TypeArray;
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
					r_MResolveMember_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_MResolveMember_Int32_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo ResolveOrGetRegisteredToken(Int32, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray;
		public virtual RMethod RMResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray
		{
			get
			{
				if(r_MResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray == null)
				{
					r_MResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray = new(this, "ResolveOrGetRegisteredToken", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_MResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray;
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
					r_MResolveMethod_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_MResolveMethod_Int32_TypeArray_TypeArray;
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
					r_MResolveString_Int32.SetBelong(this.instance);
				}
				return r_MResolveString_Int32;
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
					r_MResolveSignature_Int32.SetBelong(this.instance);
				}
				return r_MResolveSignature_Int32;
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
					r_MResolveType_Int32_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_MResolveType_Int32_TypeArray_TypeArray;
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
					r_MGetField_String_BindingFlags.SetBelong(this.instance);
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
					r_MGetFields_BindingFlags.SetBelong(this.instance);
				}
				return r_MGetFields_BindingFlags;
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
					r_MGetMethods_BindingFlags.SetBelong(this.instance);
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
					r_MGetModuleHandleImpl.SetBelong(this.instance);
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
					r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine.SetBelong(this.instance);
				}
				return r_MGetPEKind_Out_PortableExecutableKinds_Out_ImageFileMachine;
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
					r_MGetMethod_String.SetBelong(this.instance);
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
					r_MGetMethod_String_TypeArray.SetBelong(this.instance);
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
					r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
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
					r_MGetMethods.SetBelong(this.instance);
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
					r_MGetField_String.SetBelong(this.instance);
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
					r_MGetFields.SetBelong(this.instance);
				}
				return r_MGetFields;
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
					r_MFindTypes_TypeFilter_Object.SetBelong(this.instance);
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
					r_MResolveField_Int32.SetBelong(this.instance);
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
					r_MResolveMember_Int32.SetBelong(this.instance);
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
					r_MResolveMethod_Int32.SetBelong(this.instance);
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
					r_MResolveType_Int32.SetBelong(this.instance);
				}
				return r_MResolveType_Int32;
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
					r_MGetSignerCertificate.SetBelong(this.instance);
				}
				return r_MGetSignerCertificate;
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
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ModuleBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void basic_init(System.Reflection.Emit.ModuleBuilder @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ab};
            var ___result = RMbasic_init_ModuleBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public static void set_wrappers_type(System.Reflection.Emit.ModuleBuilder @mb, System.Type @ab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @ab};
            var ___result = RMset_wrappers_type_ModuleBuilder_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static void WarnAboutSymbolWriter(System.String @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message};
            var ___result = RMWarnAboutSymbolWriter_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsTransient()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsTransient.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreateGlobalFunctions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateGlobalFunctions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineInitializedData(System.String @name, System.Byte[] @data, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data, @attributes};
            var ___result = RMDefineInitializedData_String_ByteArray_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineUninitializedData(System.String @name, System.Int32 @size, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @attributes};
            var ___result = RMDefineUninitializedData_String_Int32_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual System.Reflection.Emit.FieldBuilder DefineDataImpl(System.String @name, System.Int32 @size, System.Reflection.FieldAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @size, @attributes};
            var ___result = RMDefineDataImpl_String_Int32_FieldAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldBuilder)___result;
        }


        public virtual void addGlobalMethod(System.Reflection.Emit.MethodBuilder @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = RMaddGlobalMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @returnType, @parameterTypes};
            var ___result = RMDefineGlobalMethod_String_MethodAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @parameterTypes};
            var ___result = RMDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefineGlobalMethod(System.String @name, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @requiredReturnTypeCustomModifiers, System.Type[] @optionalReturnTypeCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @requiredParameterTypeCustomModifiers, System.Type[][] @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attributes, @callingConvention, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RMDefineGlobalMethod_String_MethodAttributes_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RMDefinePInvokeMethod_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(System.String @name, System.String @dllName, System.String @entryName, System.Reflection.MethodAttributes @attributes, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Runtime.InteropServices.CallingConvention @nativeCallConv, System.Runtime.InteropServices.CharSet @nativeCharSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @dllName, @entryName, @attributes, @callingConvention, @returnType, @parameterTypes, @nativeCallConv, @nativeCharSet};
            var ___result = RMDefinePInvokeMethod_String_String_String_MethodAttributes_CallingConventions_Type_TypeArray_CallingConvention_CharSet.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMDefineType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr};
            var ___result = RMDefineType_String_TypeAttributes.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent};
            var ___result = RMDefineType_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual void AddType(System.Reflection.Emit.TypeBuilder @tb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb};
            var ___result = RMAddType_TypeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Type[] @interfaces, System.Reflection.Emit.PackingSize @packingSize, System.Int32 @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces, @packingSize, @typesize};
            var ___result = RMDefineType_String_TypeAttributes_Type_TypeArray_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual void RegisterTypeName(System.Reflection.Emit.TypeBuilder @tb, Hvak.Editor.Refleaction.RSystem.RTypeName @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tb, @name.Value};
            var ___result = RMRegisterTypeName_TypeBuilder_TypeName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.TypeBuilder GetRegisteredType(Hvak.Editor.Refleaction.RSystem.RTypeName @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name.Value};
            var ___result = RMGetRegisteredType_TypeName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Type[] @interfaces)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @interfaces};
            var ___result = RMDefineType_String_TypeAttributes_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Int32 @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @typesize};
            var ___result = RMDefineType_String_TypeAttributes_Type_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Reflection.Emit.PackingSize @packsize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packsize};
            var ___result = RMDefineType_String_TypeAttributes_Type_PackingSize.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder DefineType(System.String @name, System.Reflection.TypeAttributes @attr, System.Type @parent, System.Reflection.Emit.PackingSize @packingSize, System.Int32 @typesize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attr, @parent, @packingSize, @typesize};
            var ___result = RMDefineType_String_TypeAttributes_Type_PackingSize_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.MethodInfo GetArrayMethod(System.Type @arrayClass, System.String @methodName, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrayClass, @methodName, @callingConvention, @returnType, @parameterTypes};
            var ___result = RMGetArrayMethod_Type_String_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.Emit.EnumBuilder DefineEnum(System.String @name, System.Reflection.TypeAttributes @visibility, System.Type @underlyingType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @visibility, @underlyingType};
            var ___result = RMDefineEnum_String_TypeAttributes_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.EnumBuilder)___result;
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


        public virtual System.Reflection.Emit.TypeBuilder search_in_array(System.Reflection.Emit.TypeBuilder[] @arr, System.Int32 @validElementsInArray, Hvak.Editor.Refleaction.RSystem.RTypeName @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr, @validElementsInArray, @className.Value};
            var ___result = RMsearch_in_array_TypeBuilderArray_Int32_TypeName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder search_nested_in_array(System.Reflection.Emit.TypeBuilder[] @arr, System.Int32 @validElementsInArray, Hvak.Editor.Refleaction.RSystem.RTypeName @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arr, @validElementsInArray, @className.Value};
            var ___result = RMsearch_nested_in_array_TypeBuilderArray_Int32_TypeName.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Reflection.Emit.TypeBuilder GetMaybeNested(System.Reflection.Emit.TypeBuilder @t, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RTypeName> @nested)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @nested.Value};
            var ___result = RMGetMaybeNested_TypeBuilder_IEnumerable_d_TypeName_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeBuilder)___result;
        }


        public virtual System.Type GetType(System.String @className, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = RMget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RMSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RMSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSymWriter.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolWriter)___result;
        }


        public virtual System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(System.String @url, System.Guid @language, System.Guid @languageVendor, System.Guid @documentType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @language, @languageVendor, @documentType};
            var ___result = RMDefineDocument_String_Guid_Guid_Guid.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.SymbolStore.ISymbolDocumentWriter)___result;
        }


        public virtual System.Type[] GetTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String @name, System.String @description, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description, @attribute};
            var ___result = RMDefineResource_String_String_ResourceAttributes.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual System.Resources.IResourceWriter DefineResource(System.String @name, System.String @description)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @description};
            var ___result = RMDefineResource_String_String.Invoke(___genericsType, ___parameters);

            return (System.Resources.IResourceWriter)___result;
        }


        public virtual void DefineUnmanagedResource(System.Byte[] @resource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resource};
            var ___result = RMDefineUnmanagedResource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineUnmanagedResource(System.String @resourceFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceFileName};
            var ___result = RMDefineUnmanagedResource_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DefineManifestResource(System.String @name, System.IO.Stream @stream, System.Reflection.ResourceAttributes @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @stream, @attribute};
            var ___result = RMDefineManifestResource_String_Stream_ResourceAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSymCustomAttribute(System.String @name, System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RMSetSymCustomAttribute_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetUserEntryPoint(System.Reflection.MethodInfo @entryPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@entryPoint};
            var ___result = RMSetUserEntryPoint_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RMGetMethodToken_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo @method, System.Collections.Generic.IEnumerable<System.Type> @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @optionalParameterTypes};
            var ___result = RMGetMethodToken_MethodInfo_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type @arrayClass, System.String @methodName, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arrayClass, @methodName, @callingConvention, @returnType, @parameterTypes};
            var ___result = RMGetArrayMethodToken_Type_String_CallingConventions_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo @con)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con};
            var ___result = RMGetConstructorToken_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo @constructor, System.Collections.Generic.IEnumerable<System.Type> @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@constructor, @optionalParameterTypes};
            var ___result = RMGetConstructorToken_ConstructorInfo_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo @field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@field};
            var ___result = RMGetFieldToken_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.FieldToken)___result;
        }


        public virtual System.Reflection.Emit.SignatureToken GetSignatureToken(System.Byte[] @sigBytes, System.Int32 @sigLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sigBytes, @sigLength};
            var ___result = RMGetSignatureToken_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureToken)___result;
        }


        public virtual System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper @sigHelper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sigHelper};
            var ___result = RMGetSignatureToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureToken)___result;
        }


        public virtual System.Reflection.Emit.StringToken GetStringConstant(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetStringConstant_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.StringToken)___result;
        }


        public virtual System.Reflection.Emit.TypeToken GetTypeToken(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetTypeToken_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeToken)___result;
        }


        public virtual System.Reflection.Emit.TypeToken GetTypeToken(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetTypeToken_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.TypeToken)___result;
        }


        public static System.Int32 getUSIndex(System.Reflection.Emit.ModuleBuilder @mb, System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @str};
            var ___result = RMgetUSIndex_ModuleBuilder_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 getToken(System.Reflection.Emit.ModuleBuilder @mb, System.Object @obj, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @obj, @create_open_instance};
            var ___result = RMgetToken_ModuleBuilder_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 getMethodToken(System.Reflection.Emit.ModuleBuilder @mb, System.Reflection.MethodBase @method, System.Type[] @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb, @method, @opt_param_types};
            var ___result = RMgetMethodToken_ModuleBuilder_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMGetToken_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPseudoToken(System.Reflection.MemberInfo @member, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RMGetPseudoToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo @member)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member};
            var ___result = RMGetToken_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MemberInfo @member, System.Boolean @create_open_instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@member, @create_open_instance};
            var ___result = RMGetToken_MemberInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase @method, System.Collections.Generic.IEnumerable<System.Type> @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RMGetToken_MethodBase_IEnumerable_d_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.MethodBase @method, System.Type[] @opt_param_types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @opt_param_types};
            var ___result = RMGetToken_MethodBase_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetToken(System.Reflection.Emit.SignatureHelper @helper)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@helper};
            var ___result = RMGetToken_SignatureHelper.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void RegisterToken(System.Object @obj, System.Int32 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @token};
            var ___result = RMRegisterToken_Object_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetRegisteredToken(System.Int32 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RMGetRegisteredToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTokenGenerator GetTokenGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTokenGenerator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTokenGenerator(___result);
        }


        public static System.Object RuntimeResolve(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMRuntimeResolve_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void build_metadata(System.Reflection.Emit.ModuleBuilder @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = RMbuild_metadata_ModuleBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteToFile(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMWriteToFile_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map, System.Collections.Generic.Dictionary<System.Reflection.MemberInfo, System.Int32> @inst_tokens, System.Boolean @open)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map, @inst_tokens, @open};
            var ___result = RMFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p__Dictionary_d_MemberInfo_Int32_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFixupTokens.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateGlobalType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateGlobalType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Guid GetModuleVersionId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModuleVersionId.Invoke(___genericsType, ___parameters);

            return (System.Guid)___result;
        }


        public virtual System.Boolean IsResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.FieldInfo ResolveField(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveField_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveMember(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMember_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MemberInfo ResolveOrGetRegisteredToken(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveOrGetRegisteredToken_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo)___result;
        }


        public virtual System.Reflection.MethodBase ResolveMethod(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveMethod_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.String ResolveString(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Byte[] ResolveSignature(System.Int32 @metadataToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken};
            var ___result = RMResolveSignature_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Type ResolveType(System.Int32 @metadataToken, System.Type[] @genericTypeArguments, System.Type[] @genericMethodArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@metadataToken, @genericTypeArguments, @genericMethodArguments};
            var ___result = RMResolveType_Int32_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
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


        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RMFindTypes_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSignerCertificate.Invoke(___genericsType, ___parameters);

            return (System.Security.Cryptography.X509Certificates.X509Certificate)___result;
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
