
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IOProxy
	/// </summary>
    public partial class RIOProxy : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy");
            }
        }

        public RIOProxy() : base("UnityEditor.PackageManager.UI.Internal.IOProxy")
        {
        }

        public RIOProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IOProxy")
		{
            SetInstance(instance);
		}

        public RIOProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIOProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String CurrentDirectory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PCurrentDirectory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPCurrentDirectory
		{
			get
			{
				if(r_PCurrentDirectory == null)
				{
					r_PCurrentDirectory = new(this, "CurrentDirectory", -1);
				}
				return r_PCurrentDirectory;
			}
		}

		/// <summary>
		/// Void DirectoryCopy(System.String, System.String, Boolean, System.Action`2[System.String,System.Single])
		/// </summary>
		protected RMethod r_MDirectoryCopy_String_String_Boolean_Action_d_String_Single_p_;
		public virtual RMethod RMDirectoryCopy_String_String_Boolean_Action_d_String_Single_p_
		{
			get
			{
				if(r_MDirectoryCopy_String_String_Boolean_Action_d_String_Single_p_ == null)
				{
					r_MDirectoryCopy_String_String_Boolean_Action_d_String_Single_p_ = new(this, "DirectoryCopy", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(System.String), typeof(System.Single)));
				}
				return r_MDirectoryCopy_String_String_Boolean_Action_d_String_Single_p_;
			}
		}

		/// <summary>
		/// UInt64 DirectorySizeInBytes(System.String)
		/// </summary>
		protected RMethod r_MDirectorySizeInBytes_String;
		public virtual RMethod RMDirectorySizeInBytes_String
		{
			get
			{
				if(r_MDirectorySizeInBytes_String == null)
				{
					r_MDirectorySizeInBytes_String = new(this, "DirectorySizeInBytes", 0, typeof(System.String));
				}
				return r_MDirectorySizeInBytes_String;
			}
		}

		/// <summary>
		/// Void RemovePathAndMeta(System.String, Boolean)
		/// </summary>
		protected RMethod r_MRemovePathAndMeta_String_Boolean;
		public virtual RMethod RMRemovePathAndMeta_String_Boolean
		{
			get
			{
				if(r_MRemovePathAndMeta_String_Boolean == null)
				{
					r_MRemovePathAndMeta_String_Boolean = new(this, "RemovePathAndMeta", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MRemovePathAndMeta_String_Boolean;
			}
		}

		/// <summary>
		/// System.String PathsCombine(System.String[])
		/// </summary>
		protected RMethod r_MPathsCombine_StringArray;
		public virtual RMethod RMPathsCombine_StringArray
		{
			get
			{
				if(r_MPathsCombine_StringArray == null)
				{
					r_MPathsCombine_StringArray = new(this, "PathsCombine", 0, typeof(System.String).MakeArrayType());
				}
				return r_MPathsCombine_StringArray;
			}
		}

		/// <summary>
		/// System.String GetParentDirectory(System.String)
		/// </summary>
		protected RMethod r_MGetParentDirectory_String;
		public virtual RMethod RMGetParentDirectory_String
		{
			get
			{
				if(r_MGetParentDirectory_String == null)
				{
					r_MGetParentDirectory_String = new(this, "GetParentDirectory", 0, typeof(System.String));
				}
				return r_MGetParentDirectory_String;
			}
		}

		/// <summary>
		/// Boolean IsDirectoryEmpty(System.String)
		/// </summary>
		protected RMethod r_MIsDirectoryEmpty_String;
		public virtual RMethod RMIsDirectoryEmpty_String
		{
			get
			{
				if(r_MIsDirectoryEmpty_String == null)
				{
					r_MIsDirectoryEmpty_String = new(this, "IsDirectoryEmpty", 0, typeof(System.String));
				}
				return r_MIsDirectoryEmpty_String;
			}
		}

		/// <summary>
		/// Boolean DirectoryExists(System.String)
		/// </summary>
		protected RMethod r_MDirectoryExists_String;
		public virtual RMethod RMDirectoryExists_String
		{
			get
			{
				if(r_MDirectoryExists_String == null)
				{
					r_MDirectoryExists_String = new(this, "DirectoryExists", 0, typeof(System.String));
				}
				return r_MDirectoryExists_String;
			}
		}

		/// <summary>
		/// System.String[] DirectoryGetDirectories(System.String, System.String, System.IO.SearchOption)
		/// </summary>
		protected RMethod r_MDirectoryGetDirectories_String_String_SearchOption;
		public virtual RMethod RMDirectoryGetDirectories_String_String_SearchOption
		{
			get
			{
				if(r_MDirectoryGetDirectories_String_String_SearchOption == null)
				{
					r_MDirectoryGetDirectories_String_String_SearchOption = new(this, "DirectoryGetDirectories", 0, typeof(System.String), typeof(System.String), typeof(System.IO.SearchOption));
				}
				return r_MDirectoryGetDirectories_String_String_SearchOption;
			}
		}

		/// <summary>
		/// System.String[] DirectoryGetFiles(System.String, System.String, System.IO.SearchOption)
		/// </summary>
		protected RMethod r_MDirectoryGetFiles_String_String_SearchOption;
		public virtual RMethod RMDirectoryGetFiles_String_String_SearchOption
		{
			get
			{
				if(r_MDirectoryGetFiles_String_String_SearchOption == null)
				{
					r_MDirectoryGetFiles_String_String_SearchOption = new(this, "DirectoryGetFiles", 0, typeof(System.String), typeof(System.String), typeof(System.IO.SearchOption));
				}
				return r_MDirectoryGetFiles_String_String_SearchOption;
			}
		}

		/// <summary>
		/// Void CreateDirectory(System.String)
		/// </summary>
		protected RMethod r_MCreateDirectory_String;
		public virtual RMethod RMCreateDirectory_String
		{
			get
			{
				if(r_MCreateDirectory_String == null)
				{
					r_MCreateDirectory_String = new(this, "CreateDirectory", 0, typeof(System.String));
				}
				return r_MCreateDirectory_String;
			}
		}

		/// <summary>
		/// Void DeleteDirectory(System.String)
		/// </summary>
		protected RMethod r_MDeleteDirectory_String;
		public virtual RMethod RMDeleteDirectory_String
		{
			get
			{
				if(r_MDeleteDirectory_String == null)
				{
					r_MDeleteDirectory_String = new(this, "DeleteDirectory", 0, typeof(System.String));
				}
				return r_MDeleteDirectory_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath GetPackageAbsoluteDirectory(System.String)
		/// </summary>
		protected RMethod r_MGetPackageAbsoluteDirectory_String;
		public virtual RMethod RMGetPackageAbsoluteDirectory_String
		{
			get
			{
				if(r_MGetPackageAbsoluteDirectory_String == null)
				{
					r_MGetPackageAbsoluteDirectory_String = new(this, "GetPackageAbsoluteDirectory", 0, typeof(System.String));
				}
				return r_MGetPackageAbsoluteDirectory_String;
			}
		}

		/// <summary>
		/// System.String GetProjectDirectory()
		/// </summary>
		protected RMethod r_MGetProjectDirectory;
		public virtual RMethod RMGetProjectDirectory
		{
			get
			{
				if(r_MGetProjectDirectory == null)
				{
					r_MGetProjectDirectory = new(this, "GetProjectDirectory", 0);
				}
				return r_MGetProjectDirectory;
			}
		}

		/// <summary>
		/// Boolean IsSamePackageDirectory(System.String, System.String)
		/// </summary>
		protected RMethod r_MIsSamePackageDirectory_String_String;
		public virtual RMethod RMIsSamePackageDirectory_String_String
		{
			get
			{
				if(r_MIsSamePackageDirectory_String_String == null)
				{
					r_MIsSamePackageDirectory_String_String = new(this, "IsSamePackageDirectory", 0, typeof(System.String), typeof(System.String));
				}
				return r_MIsSamePackageDirectory_String_String;
			}
		}

		/// <summary>
		/// Void MakeFileWritable(System.String, Boolean)
		/// </summary>
		protected RMethod r_MMakeFileWritable_String_Boolean;
		public virtual RMethod RMMakeFileWritable_String_Boolean
		{
			get
			{
				if(r_MMakeFileWritable_String_Boolean == null)
				{
					r_MMakeFileWritable_String_Boolean = new(this, "MakeFileWritable", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MMakeFileWritable_String_Boolean;
			}
		}

		/// <summary>
		/// Void CopyFile(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_MCopyFile_String_String_Boolean;
		public virtual RMethod RMCopyFile_String_String_Boolean
		{
			get
			{
				if(r_MCopyFile_String_String_Boolean == null)
				{
					r_MCopyFile_String_String_Boolean = new(this, "CopyFile", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MCopyFile_String_String_Boolean;
			}
		}

		/// <summary>
		/// UInt64 GetFileSize(System.String)
		/// </summary>
		protected RMethod r_MGetFileSize_String;
		public virtual RMethod RMGetFileSize_String
		{
			get
			{
				if(r_MGetFileSize_String == null)
				{
					r_MGetFileSize_String = new(this, "GetFileSize", 0, typeof(System.String));
				}
				return r_MGetFileSize_String;
			}
		}

		/// <summary>
		/// System.String GetFileName(System.String)
		/// </summary>
		protected RMethod r_MGetFileName_String;
		public virtual RMethod RMGetFileName_String
		{
			get
			{
				if(r_MGetFileName_String == null)
				{
					r_MGetFileName_String = new(this, "GetFileName", 0, typeof(System.String));
				}
				return r_MGetFileName_String;
			}
		}

		/// <summary>
		/// Void DeleteFile(System.String)
		/// </summary>
		protected RMethod r_MDeleteFile_String;
		public virtual RMethod RMDeleteFile_String
		{
			get
			{
				if(r_MDeleteFile_String == null)
				{
					r_MDeleteFile_String = new(this, "DeleteFile", 0, typeof(System.String));
				}
				return r_MDeleteFile_String;
			}
		}

		/// <summary>
		/// Boolean FileExists(System.String)
		/// </summary>
		protected RMethod r_MFileExists_String;
		public virtual RMethod RMFileExists_String
		{
			get
			{
				if(r_MFileExists_String == null)
				{
					r_MFileExists_String = new(this, "FileExists", 0, typeof(System.String));
				}
				return r_MFileExists_String;
			}
		}

		/// <summary>
		/// Byte[] FileReadAllBytes(System.String)
		/// </summary>
		protected RMethod r_MFileReadAllBytes_String;
		public virtual RMethod RMFileReadAllBytes_String
		{
			get
			{
				if(r_MFileReadAllBytes_String == null)
				{
					r_MFileReadAllBytes_String = new(this, "FileReadAllBytes", 0, typeof(System.String));
				}
				return r_MFileReadAllBytes_String;
			}
		}

		/// <summary>
		/// System.String FileReadAllText(System.String)
		/// </summary>
		protected RMethod r_MFileReadAllText_String;
		public virtual RMethod RMFileReadAllText_String
		{
			get
			{
				if(r_MFileReadAllText_String == null)
				{
					r_MFileReadAllText_String = new(this, "FileReadAllText", 0, typeof(System.String));
				}
				return r_MFileReadAllText_String;
			}
		}

		/// <summary>
		/// Void FileWriteAllBytes(System.String, Byte[])
		/// </summary>
		protected RMethod r_MFileWriteAllBytes_String_ByteArray;
		public virtual RMethod RMFileWriteAllBytes_String_ByteArray
		{
			get
			{
				if(r_MFileWriteAllBytes_String_ByteArray == null)
				{
					r_MFileWriteAllBytes_String_ByteArray = new(this, "FileWriteAllBytes", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
				}
				return r_MFileWriteAllBytes_String_ByteArray;
			}
		}

		/// <summary>
		/// Void FileWriteAllText(System.String, System.String)
		/// </summary>
		protected RMethod r_MFileWriteAllText_String_String;
		public virtual RMethod RMFileWriteAllText_String_String
		{
			get
			{
				if(r_MFileWriteAllText_String_String == null)
				{
					r_MFileWriteAllText_String_String = new(this, "FileWriteAllText", 0, typeof(System.String), typeof(System.String));
				}
				return r_MFileWriteAllText_String_String;
			}
		}

		/// <summary>
		/// UInt64 <DirectorySizeInBytes>b__1_0(UInt64, System.String)
		/// </summary>
		protected RMethod r_M__0__DirectorySizeInBytes__1__b__1_0_UInt64_String;
		public virtual RMethod RM__0__DirectorySizeInBytes__1__b__1_0_UInt64_String
		{
			get
			{
				if(r_M__0__DirectorySizeInBytes__1__b__1_0_UInt64_String == null)
				{
					r_M__0__DirectorySizeInBytes__1__b__1_0_UInt64_String = new(this, "<DirectorySizeInBytes>b__1_0", 0, typeof(System.UInt64), typeof(System.String));
				}
				return r_M__0__DirectorySizeInBytes__1__b__1_0_UInt64_String;
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


        public virtual void DirectoryCopy(System.String @sourcePath, System.String @destinationPath, System.Boolean @makeWritable, System.Action<System.String, System.Single> @progressCallback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourcePath, @destinationPath, @makeWritable, @progressCallback};
            var ___result = RMDirectoryCopy_String_String_Boolean_Action_d_String_Single_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 DirectorySizeInBytes(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMDirectorySizeInBytes_String.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual void RemovePathAndMeta(System.String @path, System.Boolean @removeEmptyParent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @removeEmptyParent};
            var ___result = RMRemovePathAndMeta_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String PathsCombine(System.String[] @components)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@components};
            var ___result = RMPathsCombine_StringArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetParentDirectory(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMGetParentDirectory_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsDirectoryEmpty(System.String @directoryPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath};
            var ___result = RMIsDirectoryEmpty_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DirectoryExists(System.String @directoryPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath};
            var ___result = RMDirectoryExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String[] DirectoryGetDirectories(System.String @directoryPath, System.String @searchPattern, System.IO.SearchOption @searchOption)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath, @searchPattern, @searchOption};
            var ___result = RMDirectoryGetDirectories_String_String_SearchOption.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] DirectoryGetFiles(System.String @directoryPath, System.String @searchPattern, System.IO.SearchOption @searchOption)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath, @searchPattern, @searchOption};
            var ___result = RMDirectoryGetFiles_String_String_SearchOption.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void CreateDirectory(System.String @directoryPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath};
            var ___result = RMCreateDirectory_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeleteDirectory(System.String @directoryPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath};
            var ___result = RMDeleteDirectory_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath GetPackageAbsoluteDirectory(System.String @relativePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativePath};
            var ___result = RMGetPackageAbsoluteDirectory_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RNiceIO.RNPath(___result);
        }


        public virtual System.String GetProjectDirectory()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetProjectDirectory.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsSamePackageDirectory(System.String @a, System.String @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMIsSamePackageDirectory_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void MakeFileWritable(System.String @filePath, System.Boolean @writable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath, @writable};
            var ___result = RMMakeFileWritable_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFile(System.String @sourceFileName, System.String @destFileName, System.Boolean @overwrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceFileName, @destFileName, @overwrite};
            var ___result = RMCopyFile_String_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetFileSize(System.String @filePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath};
            var ___result = RMGetFileSize_String.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.String GetFileName(System.String @filePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath};
            var ___result = RMGetFileName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void DeleteFile(System.String @filePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath};
            var ___result = RMDeleteFile_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean FileExists(System.String @filePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath};
            var ___result = RMFileExists_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Byte[] FileReadAllBytes(System.String @filePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath};
            var ___result = RMFileReadAllBytes_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String FileReadAllText(System.String @filePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath};
            var ___result = RMFileReadAllText_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void FileWriteAllBytes(System.String @filePath, System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath, @bytes};
            var ___result = RMFileWriteAllBytes_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FileWriteAllText(System.String @filePath, System.String @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filePath, @contents};
            var ___result = RMFileWriteAllText_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 __0__DirectorySizeInBytes__1__b__1_0(System.UInt64 @current, System.String @file)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@current, @file};
            var ___result = RM__0__DirectorySizeInBytes__1__b__1_0_UInt64_String.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
