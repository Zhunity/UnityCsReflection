
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
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RString> r_FWellKnownProperties;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RString> RFWellKnownProperties
		{
			get
			{
				if(r_FWellKnownProperties == null)
				{
					r_FWellKnownProperties = new(this, "WellKnownProperties");
					r_FWellKnownProperties.SetBelong(this.instance);
				}
				return r_FWellKnownProperties;
			}
		}

		/// <summary>
		/// System.Int64 signature
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fsignature;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFsignature
		{
			get
			{
				if(r_Fsignature == null)
				{
					r_Fsignature = new(this, "signature");
					r_Fsignature.SetBelong(this.instance);
				}
				return r_Fsignature;
			}
		}

		/// <summary>
		/// System.Int32 struct_version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fstruct_version;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFstruct_version
		{
			get
			{
				if(r_Fstruct_version == null)
				{
					r_Fstruct_version = new(this, "struct_version");
					r_Fstruct_version.SetBelong(this.instance);
				}
				return r_Fstruct_version;
			}
		}

		/// <summary>
		/// System.Int64 file_version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Ffile_version;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFfile_version
		{
			get
			{
				if(r_Ffile_version == null)
				{
					r_Ffile_version = new(this, "file_version");
					r_Ffile_version.SetBelong(this.instance);
				}
				return r_Ffile_version;
			}
		}

		/// <summary>
		/// System.Int64 product_version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fproduct_version;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFproduct_version
		{
			get
			{
				if(r_Fproduct_version == null)
				{
					r_Fproduct_version = new(this, "product_version");
					r_Fproduct_version.SetBelong(this.instance);
				}
				return r_Fproduct_version;
			}
		}

		/// <summary>
		/// System.Int32 file_flags_mask
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_flags_mask;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_flags_mask
		{
			get
			{
				if(r_Ffile_flags_mask == null)
				{
					r_Ffile_flags_mask = new(this, "file_flags_mask");
					r_Ffile_flags_mask.SetBelong(this.instance);
				}
				return r_Ffile_flags_mask;
			}
		}

		/// <summary>
		/// System.Int32 file_flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_flags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_flags
		{
			get
			{
				if(r_Ffile_flags == null)
				{
					r_Ffile_flags = new(this, "file_flags");
					r_Ffile_flags.SetBelong(this.instance);
				}
				return r_Ffile_flags;
			}
		}

		/// <summary>
		/// System.Int32 file_os
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_os;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_os
		{
			get
			{
				if(r_Ffile_os == null)
				{
					r_Ffile_os = new(this, "file_os");
					r_Ffile_os.SetBelong(this.instance);
				}
				return r_Ffile_os;
			}
		}

		/// <summary>
		/// System.Int32 file_type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_type;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_type
		{
			get
			{
				if(r_Ffile_type == null)
				{
					r_Ffile_type = new(this, "file_type");
					r_Ffile_type.SetBelong(this.instance);
				}
				return r_Ffile_type;
			}
		}

		/// <summary>
		/// System.Int32 file_subtype
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_subtype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_subtype
		{
			get
			{
				if(r_Ffile_subtype == null)
				{
					r_Ffile_subtype = new(this, "file_subtype");
					r_Ffile_subtype.SetBelong(this.instance);
				}
				return r_Ffile_subtype;
			}
		}

		/// <summary>
		/// System.Int64 file_date
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Ffile_date;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFfile_date
		{
			get
			{
				if(r_Ffile_date == null)
				{
					r_Ffile_date = new(this, "file_date");
					r_Ffile_date.SetBelong(this.instance);
				}
				return r_Ffile_date;
			}
		}

		/// <summary>
		/// System.Int32 file_lang
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_lang;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_lang
		{
			get
			{
				if(r_Ffile_lang == null)
				{
					r_Ffile_lang = new(this, "file_lang");
					r_Ffile_lang.SetBelong(this.instance);
				}
				return r_Ffile_lang;
			}
		}

		/// <summary>
		/// System.Int32 file_codepage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ffile_codepage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfile_codepage
		{
			get
			{
				if(r_Ffile_codepage == null)
				{
					r_Ffile_codepage = new(this, "file_codepage");
					r_Ffile_codepage.SetBelong(this.instance);
				}
				return r_Ffile_codepage;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable properties
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fproperties;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RHashtable RFproperties
		{
			get
			{
				if(r_Fproperties == null)
				{
					r_Fproperties = new(this, "properties");
					r_Fproperties.SetBelong(this.instance);
				}
				return r_Fproperties;
			}
		}

		/// <summary>
		/// System.String Version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PVersion;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPVersion
		{
			get
			{
				if(r_PVersion == null)
				{
					r_PVersion = new(this, "Version", -1);
					r_PVersion.SetBelong(this.instance);
				}
				return r_PVersion;
			}
		}

		/// <summary>
		/// System.String Item [System.String]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PItem_String;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPItem_String
		{
			get
			{
				if(r_PItem_String == null)
				{
					r_PItem_String = new(this, "Item", -1, typeof(System.String));
					r_PItem_String.SetBelong(this.instance);
				}
				return r_PItem_String;
			}
		}

		/// <summary>
		/// System.String Comments
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PComments;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPComments
		{
			get
			{
				if(r_PComments == null)
				{
					r_PComments = new(this, "Comments", -1);
					r_PComments.SetBelong(this.instance);
				}
				return r_PComments;
			}
		}

		/// <summary>
		/// System.String CompanyName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PCompanyName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPCompanyName
		{
			get
			{
				if(r_PCompanyName == null)
				{
					r_PCompanyName = new(this, "CompanyName", -1);
					r_PCompanyName.SetBelong(this.instance);
				}
				return r_PCompanyName;
			}
		}

		/// <summary>
		/// System.String LegalCopyright
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PLegalCopyright;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPLegalCopyright
		{
			get
			{
				if(r_PLegalCopyright == null)
				{
					r_PLegalCopyright = new(this, "LegalCopyright", -1);
					r_PLegalCopyright.SetBelong(this.instance);
				}
				return r_PLegalCopyright;
			}
		}

		/// <summary>
		/// System.String LegalTrademarks
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PLegalTrademarks;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPLegalTrademarks
		{
			get
			{
				if(r_PLegalTrademarks == null)
				{
					r_PLegalTrademarks = new(this, "LegalTrademarks", -1);
					r_PLegalTrademarks.SetBelong(this.instance);
				}
				return r_PLegalTrademarks;
			}
		}

		/// <summary>
		/// System.String OriginalFilename
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_POriginalFilename;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPOriginalFilename
		{
			get
			{
				if(r_POriginalFilename == null)
				{
					r_POriginalFilename = new(this, "OriginalFilename", -1);
					r_POriginalFilename.SetBelong(this.instance);
				}
				return r_POriginalFilename;
			}
		}

		/// <summary>
		/// System.String ProductName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PProductName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPProductName
		{
			get
			{
				if(r_PProductName == null)
				{
					r_PProductName = new(this, "ProductName", -1);
					r_PProductName.SetBelong(this.instance);
				}
				return r_PProductName;
			}
		}

		/// <summary>
		/// System.String ProductVersion
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PProductVersion;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPProductVersion
		{
			get
			{
				if(r_PProductVersion == null)
				{
					r_PProductVersion = new(this, "ProductVersion", -1);
					r_PProductVersion.SetBelong(this.instance);
				}
				return r_PProductVersion;
			}
		}

		/// <summary>
		/// System.String InternalName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PInternalName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPInternalName
		{
			get
			{
				if(r_PInternalName == null)
				{
					r_PInternalName = new(this, "InternalName", -1);
					r_PInternalName.SetBelong(this.instance);
				}
				return r_PInternalName;
			}
		}

		/// <summary>
		/// System.String FileDescription
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PFileDescription;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPFileDescription
		{
			get
			{
				if(r_PFileDescription == null)
				{
					r_PFileDescription = new(this, "FileDescription", -1);
					r_PFileDescription.SetBelong(this.instance);
				}
				return r_PFileDescription;
			}
		}

		/// <summary>
		/// Int32 FileLanguage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PFileLanguage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPFileLanguage
		{
			get
			{
				if(r_PFileLanguage == null)
				{
					r_PFileLanguage = new(this, "FileLanguage", -1);
					r_PFileLanguage.SetBelong(this.instance);
				}
				return r_PFileLanguage;
			}
		}

		/// <summary>
		/// System.String FileVersion
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PFileVersion;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPFileVersion
		{
			get
			{
				if(r_PFileVersion == null)
				{
					r_PFileVersion = new(this, "FileVersion", -1);
					r_PFileVersion.SetBelong(this.instance);
				}
				return r_PFileVersion;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType ResourceType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_PResourceType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RPResourceType
		{
			get
			{
				if(r_PResourceType == null)
				{
					r_PResourceType = new(this, "ResourceType", -1);
					r_PResourceType.SetBelong(this.instance);
				}
				return r_PResourceType;
			}
		}

		/// <summary>
		/// System.Resources.NameOrId Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId RPName
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
		/// System.Resources.NameOrId Type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId r_PType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId RPType
		{
			get
			{
				if(r_PType == null)
				{
					r_PType = new(this, "Type", -1);
					r_PType.SetBelong(this.instance);
				}
				return r_PType;
			}
		}

		/// <summary>
		/// Int32 Language
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PLanguage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPLanguage
		{
			get
			{
				if(r_PLanguage == null)
				{
					r_PLanguage = new(this, "Language", -1);
					r_PLanguage.SetBelong(this.instance);
				}
				return r_PLanguage;
			}
		}

		/// <summary>
		/// Void emit_padding(System.IO.BinaryWriter)
		/// </summary>
		protected RMethod r_Memit_padding_BinaryWriter;
		public virtual RMethod RMemit_padding_BinaryWriter
		{
			get
			{
				if(r_Memit_padding_BinaryWriter == null)
				{
					r_Memit_padding_BinaryWriter = new(this, "emit_padding", 0, typeof(System.IO.BinaryWriter));
					r_Memit_padding_BinaryWriter.SetBelong(this.instance);
				}
				return r_Memit_padding_BinaryWriter;
			}
		}

		/// <summary>
		/// Void patch_length(System.IO.BinaryWriter, Int64)
		/// </summary>
		protected RMethod r_Mpatch_length_BinaryWriter_Int64;
		public virtual RMethod RMpatch_length_BinaryWriter_Int64
		{
			get
			{
				if(r_Mpatch_length_BinaryWriter_Int64 == null)
				{
					r_Mpatch_length_BinaryWriter_Int64 = new(this, "patch_length", 0, typeof(System.IO.BinaryWriter), typeof(System.Int64));
					r_Mpatch_length_BinaryWriter_Int64.SetBelong(this.instance);
				}
				return r_Mpatch_length_BinaryWriter_Int64;
			}
		}

		/// <summary>
		/// Void WriteTo(System.IO.Stream)
		/// </summary>
		protected RMethod r_MWriteTo_Stream;
		public virtual RMethod RMWriteTo_Stream
		{
			get
			{
				if(r_MWriteTo_Stream == null)
				{
					r_MWriteTo_Stream = new(this, "WriteTo", 0, typeof(System.IO.Stream));
					r_MWriteTo_Stream.SetBelong(this.instance);
				}
				return r_MWriteTo_Stream;
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

        public virtual void emit_padding(System.IO.BinaryWriter @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w};
            var ___result = RMemit_padding_BinaryWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void patch_length(System.IO.BinaryWriter @w, System.Int64 @len_pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @len_pos};
            var ___result = RMpatch_length_BinaryWriter_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteTo(System.IO.Stream @ms)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ms};
            var ___result = RMWriteTo_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
