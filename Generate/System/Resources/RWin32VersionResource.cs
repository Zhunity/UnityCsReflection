using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RResources
{
	/// <summary>
	/// System.Resources.Win32VersionResource
	/// </summary>
    public partial class RWin32VersionResource : RMember //
    {

		/// <summary>
		/// System.String[] WellKnownProperties
		/// </summary>
		protected RFieldArray<RField> r_WellKnownProperties;
		public virtual RFieldArray<RField> RWellKnownProperties
		{
			get
			{
				if(r_WellKnownProperties == null)
				{
					r_WellKnownProperties = new(this, "WellKnownProperties");
					r_WellKnownProperties.SetBelong(this.instance);
				}
				return r_WellKnownProperties;
			}
		}

		/// <summary>
		/// System.Int64 signature
		/// </summary>
		protected RField r_signature;
		public virtual RField Rsignature
		{
			get
			{
				if(r_signature == null)
				{
					r_signature = new(this, "signature");
					r_signature.SetBelong(this.instance);
				}
				return r_signature;
			}
		}

		/// <summary>
		/// System.Int32 struct_version
		/// </summary>
		protected RField r_struct_version;
		public virtual RField Rstruct_version
		{
			get
			{
				if(r_struct_version == null)
				{
					r_struct_version = new(this, "struct_version");
					r_struct_version.SetBelong(this.instance);
				}
				return r_struct_version;
			}
		}

		/// <summary>
		/// System.Int64 file_version
		/// </summary>
		protected RField r_file_version;
		public virtual RField Rfile_version
		{
			get
			{
				if(r_file_version == null)
				{
					r_file_version = new(this, "file_version");
					r_file_version.SetBelong(this.instance);
				}
				return r_file_version;
			}
		}

		/// <summary>
		/// System.Int64 product_version
		/// </summary>
		protected RField r_product_version;
		public virtual RField Rproduct_version
		{
			get
			{
				if(r_product_version == null)
				{
					r_product_version = new(this, "product_version");
					r_product_version.SetBelong(this.instance);
				}
				return r_product_version;
			}
		}

		/// <summary>
		/// System.Int32 file_flags_mask
		/// </summary>
		protected RField r_file_flags_mask;
		public virtual RField Rfile_flags_mask
		{
			get
			{
				if(r_file_flags_mask == null)
				{
					r_file_flags_mask = new(this, "file_flags_mask");
					r_file_flags_mask.SetBelong(this.instance);
				}
				return r_file_flags_mask;
			}
		}

		/// <summary>
		/// System.Int32 file_flags
		/// </summary>
		protected RField r_file_flags;
		public virtual RField Rfile_flags
		{
			get
			{
				if(r_file_flags == null)
				{
					r_file_flags = new(this, "file_flags");
					r_file_flags.SetBelong(this.instance);
				}
				return r_file_flags;
			}
		}

		/// <summary>
		/// System.Int32 file_os
		/// </summary>
		protected RField r_file_os;
		public virtual RField Rfile_os
		{
			get
			{
				if(r_file_os == null)
				{
					r_file_os = new(this, "file_os");
					r_file_os.SetBelong(this.instance);
				}
				return r_file_os;
			}
		}

		/// <summary>
		/// System.Int32 file_type
		/// </summary>
		protected RField r_file_type;
		public virtual RField Rfile_type
		{
			get
			{
				if(r_file_type == null)
				{
					r_file_type = new(this, "file_type");
					r_file_type.SetBelong(this.instance);
				}
				return r_file_type;
			}
		}

		/// <summary>
		/// System.Int32 file_subtype
		/// </summary>
		protected RField r_file_subtype;
		public virtual RField Rfile_subtype
		{
			get
			{
				if(r_file_subtype == null)
				{
					r_file_subtype = new(this, "file_subtype");
					r_file_subtype.SetBelong(this.instance);
				}
				return r_file_subtype;
			}
		}

		/// <summary>
		/// System.Int64 file_date
		/// </summary>
		protected RField r_file_date;
		public virtual RField Rfile_date
		{
			get
			{
				if(r_file_date == null)
				{
					r_file_date = new(this, "file_date");
					r_file_date.SetBelong(this.instance);
				}
				return r_file_date;
			}
		}

		/// <summary>
		/// System.Int32 file_lang
		/// </summary>
		protected RField r_file_lang;
		public virtual RField Rfile_lang
		{
			get
			{
				if(r_file_lang == null)
				{
					r_file_lang = new(this, "file_lang");
					r_file_lang.SetBelong(this.instance);
				}
				return r_file_lang;
			}
		}

		/// <summary>
		/// System.Int32 file_codepage
		/// </summary>
		protected RField r_file_codepage;
		public virtual RField Rfile_codepage
		{
			get
			{
				if(r_file_codepage == null)
				{
					r_file_codepage = new(this, "file_codepage");
					r_file_codepage.SetBelong(this.instance);
				}
				return r_file_codepage;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable properties
		/// </summary>
		protected RSystem.RCollections.RHashtable r_properties;
		public virtual RSystem.RCollections.RHashtable Rproperties
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
		/// System.String Version
		/// </summary>
		protected RProperty r_Version;
		public virtual RProperty RVersion
		{
			get
			{
				if(r_Version == null)
				{
					r_Version = new(this, "Version", -1);
					r_Version.SetBelong(this.instance);
				}
				return r_Version;
			}
		}

		/// <summary>
		/// System.String Item [System.String]
		/// </summary>
		protected RProperty r_Item_String_String;
		public virtual RProperty RItem_String_String
		{
			get
			{
				if(r_Item_String_String == null)
				{
					r_Item_String_String = new(this, "Item", -1, typeof(System.String), typeof(System.String));
					r_Item_String_String.SetBelong(this.instance);
				}
				return r_Item_String_String;
			}
		}

		/// <summary>
		/// System.String Comments
		/// </summary>
		protected RProperty r_Comments;
		public virtual RProperty RComments
		{
			get
			{
				if(r_Comments == null)
				{
					r_Comments = new(this, "Comments", -1);
					r_Comments.SetBelong(this.instance);
				}
				return r_Comments;
			}
		}

		/// <summary>
		/// System.String CompanyName
		/// </summary>
		protected RProperty r_CompanyName;
		public virtual RProperty RCompanyName
		{
			get
			{
				if(r_CompanyName == null)
				{
					r_CompanyName = new(this, "CompanyName", -1);
					r_CompanyName.SetBelong(this.instance);
				}
				return r_CompanyName;
			}
		}

		/// <summary>
		/// System.String LegalCopyright
		/// </summary>
		protected RProperty r_LegalCopyright;
		public virtual RProperty RLegalCopyright
		{
			get
			{
				if(r_LegalCopyright == null)
				{
					r_LegalCopyright = new(this, "LegalCopyright", -1);
					r_LegalCopyright.SetBelong(this.instance);
				}
				return r_LegalCopyright;
			}
		}

		/// <summary>
		/// System.String LegalTrademarks
		/// </summary>
		protected RProperty r_LegalTrademarks;
		public virtual RProperty RLegalTrademarks
		{
			get
			{
				if(r_LegalTrademarks == null)
				{
					r_LegalTrademarks = new(this, "LegalTrademarks", -1);
					r_LegalTrademarks.SetBelong(this.instance);
				}
				return r_LegalTrademarks;
			}
		}

		/// <summary>
		/// System.String OriginalFilename
		/// </summary>
		protected RProperty r_OriginalFilename;
		public virtual RProperty ROriginalFilename
		{
			get
			{
				if(r_OriginalFilename == null)
				{
					r_OriginalFilename = new(this, "OriginalFilename", -1);
					r_OriginalFilename.SetBelong(this.instance);
				}
				return r_OriginalFilename;
			}
		}

		/// <summary>
		/// System.String ProductName
		/// </summary>
		protected RProperty r_ProductName;
		public virtual RProperty RProductName
		{
			get
			{
				if(r_ProductName == null)
				{
					r_ProductName = new(this, "ProductName", -1);
					r_ProductName.SetBelong(this.instance);
				}
				return r_ProductName;
			}
		}

		/// <summary>
		/// System.String ProductVersion
		/// </summary>
		protected RProperty r_ProductVersion;
		public virtual RProperty RProductVersion
		{
			get
			{
				if(r_ProductVersion == null)
				{
					r_ProductVersion = new(this, "ProductVersion", -1);
					r_ProductVersion.SetBelong(this.instance);
				}
				return r_ProductVersion;
			}
		}

		/// <summary>
		/// System.String InternalName
		/// </summary>
		protected RProperty r_InternalName;
		public virtual RProperty RInternalName
		{
			get
			{
				if(r_InternalName == null)
				{
					r_InternalName = new(this, "InternalName", -1);
					r_InternalName.SetBelong(this.instance);
				}
				return r_InternalName;
			}
		}

		/// <summary>
		/// System.String FileDescription
		/// </summary>
		protected RProperty r_FileDescription;
		public virtual RProperty RFileDescription
		{
			get
			{
				if(r_FileDescription == null)
				{
					r_FileDescription = new(this, "FileDescription", -1);
					r_FileDescription.SetBelong(this.instance);
				}
				return r_FileDescription;
			}
		}

		/// <summary>
		/// Int32 FileLanguage
		/// </summary>
		protected RProperty r_FileLanguage;
		public virtual RProperty RFileLanguage
		{
			get
			{
				if(r_FileLanguage == null)
				{
					r_FileLanguage = new(this, "FileLanguage", -1);
					r_FileLanguage.SetBelong(this.instance);
				}
				return r_FileLanguage;
			}
		}

		/// <summary>
		/// System.String FileVersion
		/// </summary>
		protected RProperty r_FileVersion;
		public virtual RProperty RFileVersion
		{
			get
			{
				if(r_FileVersion == null)
				{
					r_FileVersion = new(this, "FileVersion", -1);
					r_FileVersion.SetBelong(this.instance);
				}
				return r_FileVersion;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType ResourceType
		/// </summary>
		protected RProperty r_ResourceType;
		public virtual RProperty ResourceType
		{
			get
			{
				if(r_ResourceType == null)
				{
					r_ResourceType = new(this, "ResourceType", -1);
					r_ResourceType.SetBelong(this.instance);
				}
				return r_ResourceType;
			}
		}

		/// <summary>
		/// System.Resources.NameOrId Name
		/// </summary>
		protected RSystem.RResources.RNameOrId r_Name;
		public virtual RSystem.RResources.RNameOrId RName
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
		/// System.Resources.NameOrId Type
		/// </summary>
		protected RSystem.RResources.RNameOrId r_Type;
		public virtual RSystem.RResources.RNameOrId RType
		{
			get
			{
				if(r_Type == null)
				{
					r_Type = new(this, "Type", -1);
					r_Type.SetBelong(this.instance);
				}
				return r_Type;
			}
		}

		/// <summary>
		/// Int32 Language
		/// </summary>
		protected RProperty r_Language;
		public virtual RProperty RLanguage
		{
			get
			{
				if(r_Language == null)
				{
					r_Language = new(this, "Language", -1);
					r_Language.SetBelong(this.instance);
				}
				return r_Language;
			}
		}

		/// <summary>
		/// Void emit_padding(System.IO.BinaryWriter)
		/// </summary>
		protected RMethod r_Remit_padding_BinaryWriter;
		public virtual RMethod Remit_padding_BinaryWriter
		{
			get
			{
				if(r_Remit_padding_BinaryWriter == null)
				{
					r_Remit_padding_BinaryWriter = new(this, "emit_padding", 0, typeof(System.IO.BinaryWriter));
					r_Remit_padding_BinaryWriter.SetBelong(this.instance);
				}
				return r_Remit_padding_BinaryWriter;
			}
		}

		/// <summary>
		/// Void patch_length(System.IO.BinaryWriter, Int64)
		/// </summary>
		protected RMethod r_Rpatch_length_BinaryWriter_Int64;
		public virtual RMethod Rpatch_length_BinaryWriter_Int64
		{
			get
			{
				if(r_Rpatch_length_BinaryWriter_Int64 == null)
				{
					r_Rpatch_length_BinaryWriter_Int64 = new(this, "patch_length", 0, typeof(System.IO.BinaryWriter), typeof(System.Int64));
					r_Rpatch_length_BinaryWriter_Int64.SetBelong(this.instance);
				}
				return r_Rpatch_length_BinaryWriter_Int64;
			}
		}

		/// <summary>
		/// Void WriteTo(System.IO.Stream)
		/// </summary>
		protected RMethod r_RWriteTo_Stream;
		public virtual RMethod RWriteTo_Stream
		{
			get
			{
				if(r_RWriteTo_Stream == null)
				{
					r_RWriteTo_Stream = new(this, "WriteTo", 0, typeof(System.IO.Stream));
					r_RWriteTo_Stream.SetBelong(this.instance);
				}
				return r_RWriteTo_Stream;
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


        public RWin32VersionResource() : base("System.Resources.Win32VersionResource")
        {
        }

        public RWin32VersionResource(System.Object instance) : base("System.Resources.Win32VersionResource")
		{
            SetInstance(instance);
		}

        public RWin32VersionResource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWin32VersionResource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void emit_padding(System.IO.BinaryWriter  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = Remit_padding_BinaryWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void patch_length(System.IO.BinaryWriter  @w, System.Int64  @len_pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @len_pos};
            var ___result = Rpatch_length_BinaryWriter_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteTo(System.IO.Stream  @ms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ms};
            var ___result = RWriteTo_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
