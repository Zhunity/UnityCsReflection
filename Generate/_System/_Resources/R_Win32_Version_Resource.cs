
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RResources
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Resources.Win32VersionResource
	/// </summary>
    public partial class RWin32VersionResource : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Resources.Win32VersionResource");
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


		/// <summary>
		/// System.String[] WellKnownProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FWellKnownProperties;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFWellKnownProperties
		{
			get
			{
				if(r_FWellKnownProperties == null)
				{
					r_FWellKnownProperties = new(this, "WellKnownProperties");
				}
				return r_FWellKnownProperties;
			}
		}

		/// <summary>
		/// System.Int64 signature
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fsignature;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFsignature
		{
			get
			{
				if(r_Fsignature == null)
				{
					r_Fsignature = new(this, "signature");
				}
				return r_Fsignature;
			}
		}

		/// <summary>
		/// System.Int32 struct_version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fstruct_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstruct_version
		{
			get
			{
				if(r_Fstruct_version == null)
				{
					r_Fstruct_version = new(this, "struct_version");
				}
				return r_Fstruct_version;
			}
		}

		/// <summary>
		/// System.Int64 file_version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Ffile_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFfile_version
		{
			get
			{
				if(r_Ffile_version == null)
				{
					r_Ffile_version = new(this, "file_version");
				}
				return r_Ffile_version;
			}
		}

		/// <summary>
		/// System.Int64 product_version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fproduct_version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFproduct_version
		{
			get
			{
				if(r_Fproduct_version == null)
				{
					r_Fproduct_version = new(this, "product_version");
				}
				return r_Fproduct_version;
			}
		}

		/// <summary>
		/// System.Int32 file_flags_mask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_flags_mask;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_flags_mask
		{
			get
			{
				if(r_Ffile_flags_mask == null)
				{
					r_Ffile_flags_mask = new(this, "file_flags_mask");
				}
				return r_Ffile_flags_mask;
			}
		}

		/// <summary>
		/// System.Int32 file_flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_flags;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_flags
		{
			get
			{
				if(r_Ffile_flags == null)
				{
					r_Ffile_flags = new(this, "file_flags");
				}
				return r_Ffile_flags;
			}
		}

		/// <summary>
		/// System.Int32 file_os
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_os;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_os
		{
			get
			{
				if(r_Ffile_os == null)
				{
					r_Ffile_os = new(this, "file_os");
				}
				return r_Ffile_os;
			}
		}

		/// <summary>
		/// System.Int32 file_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_type
		{
			get
			{
				if(r_Ffile_type == null)
				{
					r_Ffile_type = new(this, "file_type");
				}
				return r_Ffile_type;
			}
		}

		/// <summary>
		/// System.Int32 file_subtype
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_subtype;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_subtype
		{
			get
			{
				if(r_Ffile_subtype == null)
				{
					r_Ffile_subtype = new(this, "file_subtype");
				}
				return r_Ffile_subtype;
			}
		}

		/// <summary>
		/// System.Int64 file_date
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Ffile_date;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFfile_date
		{
			get
			{
				if(r_Ffile_date == null)
				{
					r_Ffile_date = new(this, "file_date");
				}
				return r_Ffile_date;
			}
		}

		/// <summary>
		/// System.Int32 file_lang
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_lang;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_lang
		{
			get
			{
				if(r_Ffile_lang == null)
				{
					r_Ffile_lang = new(this, "file_lang");
				}
				return r_Ffile_lang;
			}
		}

		/// <summary>
		/// System.Int32 file_codepage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ffile_codepage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfile_codepage
		{
			get
			{
				if(r_Ffile_codepage == null)
				{
					r_Ffile_codepage = new(this, "file_codepage");
				}
				return r_Ffile_codepage;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable properties
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fproperties;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFproperties
		{
			get
			{
				if(r_Fproperties == null)
				{
					r_Fproperties = new(this, "properties");
				}
				return r_Fproperties;
			}
		}

		/// <summary>
		/// System.String Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPVersion
		{
			get
			{
				if(r_PVersion == null)
				{
					r_PVersion = new(this, "Version", -1);
				}
				return r_PVersion;
			}
		}

		/// <summary>
		/// System.String Item [System.String]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PItem_String;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPItem_String
		{
			get
			{
				if(r_PItem_String == null)
				{
					r_PItem_String = new(this, "Item", -1, typeof(System.String));
				}
				return r_PItem_String;
			}
		}

		/// <summary>
		/// System.String Comments
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PComments;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPComments
		{
			get
			{
				if(r_PComments == null)
				{
					r_PComments = new(this, "Comments", -1);
				}
				return r_PComments;
			}
		}

		/// <summary>
		/// System.String CompanyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCompanyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCompanyName
		{
			get
			{
				if(r_PCompanyName == null)
				{
					r_PCompanyName = new(this, "CompanyName", -1);
				}
				return r_PCompanyName;
			}
		}

		/// <summary>
		/// System.String LegalCopyright
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLegalCopyright;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLegalCopyright
		{
			get
			{
				if(r_PLegalCopyright == null)
				{
					r_PLegalCopyright = new(this, "LegalCopyright", -1);
				}
				return r_PLegalCopyright;
			}
		}

		/// <summary>
		/// System.String LegalTrademarks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PLegalTrademarks;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPLegalTrademarks
		{
			get
			{
				if(r_PLegalTrademarks == null)
				{
					r_PLegalTrademarks = new(this, "LegalTrademarks", -1);
				}
				return r_PLegalTrademarks;
			}
		}

		/// <summary>
		/// System.String OriginalFilename
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_POriginalFilename;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPOriginalFilename
		{
			get
			{
				if(r_POriginalFilename == null)
				{
					r_POriginalFilename = new(this, "OriginalFilename", -1);
				}
				return r_POriginalFilename;
			}
		}

		/// <summary>
		/// System.String ProductName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PProductName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPProductName
		{
			get
			{
				if(r_PProductName == null)
				{
					r_PProductName = new(this, "ProductName", -1);
				}
				return r_PProductName;
			}
		}

		/// <summary>
		/// System.String ProductVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PProductVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPProductVersion
		{
			get
			{
				if(r_PProductVersion == null)
				{
					r_PProductVersion = new(this, "ProductVersion", -1);
				}
				return r_PProductVersion;
			}
		}

		/// <summary>
		/// System.String InternalName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PInternalName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPInternalName
		{
			get
			{
				if(r_PInternalName == null)
				{
					r_PInternalName = new(this, "InternalName", -1);
				}
				return r_PInternalName;
			}
		}

		/// <summary>
		/// System.String FileDescription
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFileDescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFileDescription
		{
			get
			{
				if(r_PFileDescription == null)
				{
					r_PFileDescription = new(this, "FileDescription", -1);
				}
				return r_PFileDescription;
			}
		}

		/// <summary>
		/// Int32 FileLanguage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PFileLanguage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPFileLanguage
		{
			get
			{
				if(r_PFileLanguage == null)
				{
					r_PFileLanguage = new(this, "FileLanguage", -1);
				}
				return r_PFileLanguage;
			}
		}

		/// <summary>
		/// System.String FileVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFileVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFileVersion
		{
			get
			{
				if(r_PFileVersion == null)
				{
					r_PFileVersion = new(this, "FileVersion", -1);
				}
				return r_PFileVersion;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType ResourceType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_PResourceType;
		public virtual Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RPResourceType
		{
			get
			{
				if(r_PResourceType == null)
				{
					r_PResourceType = new(this, "ResourceType", -1);
				}
				return r_PResourceType;
			}
		}

		/// <summary>
		/// System.Resources.NameOrId Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResources.RNameOrId r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RResources.RNameOrId RPName
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
		/// System.Resources.NameOrId Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RResources.RNameOrId r_PType;
		public virtual Hvak.Editor.Refleaction.RSystem.RResources.RNameOrId RPType
		{
			get
			{
				if(r_PType == null)
				{
					r_PType = new(this, "Type", -1);
				}
				return r_PType;
			}
		}

		/// <summary>
		/// Int32 Language
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLanguage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLanguage
		{
			get
			{
				if(r_PLanguage == null)
				{
					r_PLanguage = new(this, "Language", -1);
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

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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
