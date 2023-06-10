
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RNiceIO
{public partial class RNPath
{
	
	/// <summary>
	/// NiceIO.NPath+FileSystem
	/// </summary>
    public partial class RFileSystem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("NiceIO.NPath+FileSystem");
            }
        }

        public RFileSystem() : base("NiceIO.NPath+FileSystem")
        {
        }

        public RFileSystem(System.Object instance) : base("NiceIO.NPath+FileSystem")
		{
            SetInstance(instance);
		}

        public RFileSystem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFileSystem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// NiceIO.NPath+FileSystem _active
		/// </summary>
		protected static Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem r_F_active;
		public static Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem RF_active
		{
			get
			{
				if(r_F_active == null)
				{
					r_F_active = new( ReflectionUtils.GetType("NiceIO.NPath+FileSystem"), "_active");
				}
				return r_F_active;
			}
		}

		/// <summary>
		/// FileSystem Active
		/// </summary>
		protected static Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem r_PActive;
		public static Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem RPActive
		{
			get
			{
				if(r_PActive == null)
				{
					r_PActive = new( ReflectionUtils.GetType("NiceIO.NPath+FileSystem"), "Active", -1);
				}
				return r_PActive;
			}
		}

		/// <summary>
		/// FileSystem MakeFileSystemForCurrentMachine()
		/// </summary>
		protected static RMethod r_MMakeFileSystemForCurrentMachine;
		public static RMethod RMMakeFileSystemForCurrentMachine
		{
			get
			{
				if(r_MMakeFileSystemForCurrentMachine == null)
				{
					r_MMakeFileSystemForCurrentMachine = new( ReflectionUtils.GetType("NiceIO.NPath+FileSystem"), "MakeFileSystemForCurrentMachine", 0);
				}
				return r_MMakeFileSystemForCurrentMachine;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Directory_GetFiles(NiceIO.NPath, System.String, System.IO.SearchOption)
		/// </summary>
		protected RMethod r_MDirectory_GetFiles_NPath_String_SearchOption;
		public virtual RMethod RMDirectory_GetFiles_NPath_String_SearchOption
		{
			get
			{
				if(r_MDirectory_GetFiles_NPath_String_SearchOption == null)
				{
					r_MDirectory_GetFiles_NPath_String_SearchOption = new(this, "Directory_GetFiles", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.String), typeof(System.IO.SearchOption));
				}
				return r_MDirectory_GetFiles_NPath_String_SearchOption;
			}
		}

		/// <summary>
		/// Boolean Directory_Exists(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MDirectory_Exists_NPath;
		public virtual RMethod RMDirectory_Exists_NPath
		{
			get
			{
				if(r_MDirectory_Exists_NPath == null)
				{
					r_MDirectory_Exists_NPath = new(this, "Directory_Exists", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MDirectory_Exists_NPath;
			}
		}

		/// <summary>
		/// Boolean File_Exists(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_Exists_NPath;
		public virtual RMethod RMFile_Exists_NPath
		{
			get
			{
				if(r_MFile_Exists_NPath == null)
				{
					r_MFile_Exists_NPath = new(this, "File_Exists", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_Exists_NPath;
			}
		}

		/// <summary>
		/// Void File_WriteAllBytes(NiceIO.NPath, Byte[])
		/// </summary>
		protected RMethod r_MFile_WriteAllBytes_NPath_ByteArray;
		public virtual RMethod RMFile_WriteAllBytes_NPath_ByteArray
		{
			get
			{
				if(r_MFile_WriteAllBytes_NPath_ByteArray == null)
				{
					r_MFile_WriteAllBytes_NPath_ByteArray = new(this, "File_WriteAllBytes", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Byte).MakeArrayType());
				}
				return r_MFile_WriteAllBytes_NPath_ByteArray;
			}
		}

		/// <summary>
		/// Void File_Copy(NiceIO.NPath, NiceIO.NPath, Boolean)
		/// </summary>
		protected RMethod r_MFile_Copy_NPath_NPath_Boolean;
		public virtual RMethod RMFile_Copy_NPath_NPath_Boolean
		{
			get
			{
				if(r_MFile_Copy_NPath_NPath_Boolean == null)
				{
					r_MFile_Copy_NPath_NPath_Boolean = new(this, "File_Copy", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean));
				}
				return r_MFile_Copy_NPath_NPath_Boolean;
			}
		}

		/// <summary>
		/// Void File_Delete(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_Delete_NPath;
		public virtual RMethod RMFile_Delete_NPath
		{
			get
			{
				if(r_MFile_Delete_NPath == null)
				{
					r_MFile_Delete_NPath = new(this, "File_Delete", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_Delete_NPath;
			}
		}

		/// <summary>
		/// Void File_Move(NiceIO.NPath, NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_Move_NPath_NPath;
		public virtual RMethod RMFile_Move_NPath_NPath
		{
			get
			{
				if(r_MFile_Move_NPath_NPath == null)
				{
					r_MFile_Move_NPath_NPath = new(this, "File_Move", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_Move_NPath_NPath;
			}
		}

		/// <summary>
		/// Void File_WriteAllText(NiceIO.NPath, System.String)
		/// </summary>
		protected RMethod r_MFile_WriteAllText_NPath_String;
		public virtual RMethod RMFile_WriteAllText_NPath_String
		{
			get
			{
				if(r_MFile_WriteAllText_NPath_String == null)
				{
					r_MFile_WriteAllText_NPath_String = new(this, "File_WriteAllText", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.String));
				}
				return r_MFile_WriteAllText_NPath_String;
			}
		}

		/// <summary>
		/// System.String File_ReadAllText(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_ReadAllText_NPath;
		public virtual RMethod RMFile_ReadAllText_NPath
		{
			get
			{
				if(r_MFile_ReadAllText_NPath == null)
				{
					r_MFile_ReadAllText_NPath = new(this, "File_ReadAllText", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_ReadAllText_NPath;
			}
		}

		/// <summary>
		/// Void File_WriteAllLines(NiceIO.NPath, System.String[])
		/// </summary>
		protected RMethod r_MFile_WriteAllLines_NPath_StringArray;
		public virtual RMethod RMFile_WriteAllLines_NPath_StringArray
		{
			get
			{
				if(r_MFile_WriteAllLines_NPath_StringArray == null)
				{
					r_MFile_WriteAllLines_NPath_StringArray = new(this, "File_WriteAllLines", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.String).MakeArrayType());
				}
				return r_MFile_WriteAllLines_NPath_StringArray;
			}
		}

		/// <summary>
		/// Byte[] File_ReadAllBytes(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_ReadAllBytes_NPath;
		public virtual RMethod RMFile_ReadAllBytes_NPath
		{
			get
			{
				if(r_MFile_ReadAllBytes_NPath == null)
				{
					r_MFile_ReadAllBytes_NPath = new(this, "File_ReadAllBytes", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_ReadAllBytes_NPath;
			}
		}

		/// <summary>
		/// System.String[] File_ReadAllLines(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_ReadAllLines_NPath;
		public virtual RMethod RMFile_ReadAllLines_NPath
		{
			get
			{
				if(r_MFile_ReadAllLines_NPath == null)
				{
					r_MFile_ReadAllLines_NPath = new(this, "File_ReadAllLines", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_ReadAllLines_NPath;
			}
		}

		/// <summary>
		/// Void File_SetLastWriteTimeUtc(NiceIO.NPath, System.DateTime)
		/// </summary>
		protected RMethod r_MFile_SetLastWriteTimeUtc_NPath_DateTime;
		public virtual RMethod RMFile_SetLastWriteTimeUtc_NPath_DateTime
		{
			get
			{
				if(r_MFile_SetLastWriteTimeUtc_NPath_DateTime == null)
				{
					r_MFile_SetLastWriteTimeUtc_NPath_DateTime = new(this, "File_SetLastWriteTimeUtc", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.DateTime));
				}
				return r_MFile_SetLastWriteTimeUtc_NPath_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime File_GetLastWriteTimeUtc(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_GetLastWriteTimeUtc_NPath;
		public virtual RMethod RMFile_GetLastWriteTimeUtc_NPath
		{
			get
			{
				if(r_MFile_GetLastWriteTimeUtc_NPath == null)
				{
					r_MFile_GetLastWriteTimeUtc_NPath = new(this, "File_GetLastWriteTimeUtc", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_GetLastWriteTimeUtc_NPath;
			}
		}

		/// <summary>
		/// Int64 File_GetSize(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_GetSize_NPath;
		public virtual RMethod RMFile_GetSize_NPath
		{
			get
			{
				if(r_MFile_GetSize_NPath == null)
				{
					r_MFile_GetSize_NPath = new(this, "File_GetSize", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_GetSize_NPath;
			}
		}

		/// <summary>
		/// Void File_SetAttributes(NiceIO.NPath, System.IO.FileAttributes)
		/// </summary>
		protected RMethod r_MFile_SetAttributes_NPath_FileAttributes;
		public virtual RMethod RMFile_SetAttributes_NPath_FileAttributes
		{
			get
			{
				if(r_MFile_SetAttributes_NPath_FileAttributes == null)
				{
					r_MFile_SetAttributes_NPath_FileAttributes = new(this, "File_SetAttributes", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.IO.FileAttributes));
				}
				return r_MFile_SetAttributes_NPath_FileAttributes;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes File_GetAttributes(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFile_GetAttributes_NPath;
		public virtual RMethod RMFile_GetAttributes_NPath
		{
			get
			{
				if(r_MFile_GetAttributes_NPath == null)
				{
					r_MFile_GetAttributes_NPath = new(this, "File_GetAttributes", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFile_GetAttributes_NPath;
			}
		}

		/// <summary>
		/// Void Directory_CreateDirectory(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MDirectory_CreateDirectory_NPath;
		public virtual RMethod RMDirectory_CreateDirectory_NPath
		{
			get
			{
				if(r_MDirectory_CreateDirectory_NPath == null)
				{
					r_MDirectory_CreateDirectory_NPath = new(this, "Directory_CreateDirectory", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MDirectory_CreateDirectory_NPath;
			}
		}

		/// <summary>
		/// Void Directory_Delete(NiceIO.NPath, Boolean)
		/// </summary>
		protected RMethod r_MDirectory_Delete_NPath_Boolean;
		public virtual RMethod RMDirectory_Delete_NPath_Boolean
		{
			get
			{
				if(r_MDirectory_Delete_NPath_Boolean == null)
				{
					r_MDirectory_Delete_NPath_Boolean = new(this, "Directory_Delete", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean));
				}
				return r_MDirectory_Delete_NPath_Boolean;
			}
		}

		/// <summary>
		/// Void Directory_Move(NiceIO.NPath, NiceIO.NPath)
		/// </summary>
		protected RMethod r_MDirectory_Move_NPath_NPath;
		public virtual RMethod RMDirectory_Move_NPath_NPath
		{
			get
			{
				if(r_MDirectory_Move_NPath_NPath == null)
				{
					r_MDirectory_Move_NPath_NPath = new(this, "Directory_Move", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MDirectory_Move_NPath_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath Directory_GetCurrentDirectory()
		/// </summary>
		protected RMethod r_MDirectory_GetCurrentDirectory;
		public virtual RMethod RMDirectory_GetCurrentDirectory
		{
			get
			{
				if(r_MDirectory_GetCurrentDirectory == null)
				{
					r_MDirectory_GetCurrentDirectory = new(this, "Directory_GetCurrentDirectory", 0);
				}
				return r_MDirectory_GetCurrentDirectory;
			}
		}

		/// <summary>
		/// Void Directory_SetCurrentDirectory(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MDirectory_SetCurrentDirectory_NPath;
		public virtual RMethod RMDirectory_SetCurrentDirectory_NPath
		{
			get
			{
				if(r_MDirectory_SetCurrentDirectory_NPath == null)
				{
					r_MDirectory_SetCurrentDirectory_NPath = new(this, "Directory_SetCurrentDirectory", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MDirectory_SetCurrentDirectory_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Directory_GetDirectories(NiceIO.NPath, System.String, System.IO.SearchOption)
		/// </summary>
		protected RMethod r_MDirectory_GetDirectories_NPath_String_SearchOption;
		public virtual RMethod RMDirectory_GetDirectories_NPath_String_SearchOption
		{
			get
			{
				if(r_MDirectory_GetDirectories_NPath_String_SearchOption == null)
				{
					r_MDirectory_GetDirectories_NPath_String_SearchOption = new(this, "Directory_GetDirectories", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.String), typeof(System.IO.SearchOption));
				}
				return r_MDirectory_GetDirectories_NPath_String_SearchOption;
			}
		}

		/// <summary>
		/// NiceIO.NPath Resolve(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MResolve_NPath;
		public virtual RMethod RMResolve_NPath
		{
			get
			{
				if(r_MResolve_NPath == null)
				{
					r_MResolve_NPath = new(this, "Resolve", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MResolve_NPath;
			}
		}

		/// <summary>
		/// Boolean IsSymbolicLink(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MIsSymbolicLink_NPath;
		public virtual RMethod RMIsSymbolicLink_NPath
		{
			get
			{
				if(r_MIsSymbolicLink_NPath == null)
				{
					r_MIsSymbolicLink_NPath = new(this, "IsSymbolicLink", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MIsSymbolicLink_NPath;
			}
		}

		/// <summary>
		/// Void CreateSymbolicLink(NiceIO.NPath, NiceIO.NPath, Boolean)
		/// </summary>
		protected RMethod r_MCreateSymbolicLink_NPath_NPath_Boolean;
		public virtual RMethod RMCreateSymbolicLink_NPath_NPath_Boolean
		{
			get
			{
				if(r_MCreateSymbolicLink_NPath_NPath_Boolean == null)
				{
					r_MCreateSymbolicLink_NPath_NPath_Boolean = new(this, "CreateSymbolicLink", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean));
				}
				return r_MCreateSymbolicLink_NPath_NPath_Boolean;
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


        public static Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem MakeFileSystemForCurrentMachine()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeFileSystemForCurrentMachine.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem(___result);
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Directory_GetFiles(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.String @filter, System.IO.SearchOption @searchOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @filter, @searchOptions};
            var ___result = RMDirectory_GetFiles_NPath_String_SearchOption.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.Boolean Directory_Exists(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMDirectory_Exists_NPath.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean File_Exists(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_Exists_NPath.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void File_WriteAllBytes(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @bytes};
            var ___result = RMFile_WriteAllBytes_NPath_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void File_Copy(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, Hvak.Editor.Refleaction.RNiceIO.RNPath @destinationPath, System.Boolean @overWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @destinationPath.Value, @overWrite};
            var ___result = RMFile_Copy_NPath_NPath_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void File_Delete(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_Delete_NPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void File_Move(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, Hvak.Editor.Refleaction.RNiceIO.RNPath @destinationPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @destinationPath.Value};
            var ___result = RMFile_Move_NPath_NPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void File_WriteAllText(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.String @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @contents};
            var ___result = RMFile_WriteAllText_NPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String File_ReadAllText(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_ReadAllText_NPath.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void File_WriteAllLines(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.String[] @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @contents};
            var ___result = RMFile_WriteAllLines_NPath_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] File_ReadAllBytes(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_ReadAllBytes_NPath.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String[] File_ReadAllLines(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_ReadAllLines_NPath.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual void File_SetLastWriteTimeUtc(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.DateTime @lastWriteTimeUtc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @lastWriteTimeUtc};
            var ___result = RMFile_SetLastWriteTimeUtc_NPath_DateTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.DateTime File_GetLastWriteTimeUtc(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_GetLastWriteTimeUtc_NPath.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Int64 File_GetSize(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_GetSize_NPath.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void File_SetAttributes(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.IO.FileAttributes @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @value};
            var ___result = RMFile_SetAttributes_NPath_FileAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IO.FileAttributes File_GetAttributes(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMFile_GetAttributes_NPath.Invoke(___genericsType, ___parameters);

            return (System.IO.FileAttributes)___result;
        }


        public virtual void Directory_CreateDirectory(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMDirectory_CreateDirectory_NPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Directory_Delete(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.Boolean @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @b};
            var ___result = RMDirectory_Delete_NPath_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Directory_Move(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, Hvak.Editor.Refleaction.RNiceIO.RNPath @destPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @destPath.Value};
            var ___result = RMDirectory_Move_NPath_NPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Directory_GetCurrentDirectory()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDirectory_GetCurrentDirectory.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RNiceIO.RNPath(___result);
        }


        public virtual void Directory_SetCurrentDirectory(Hvak.Editor.Refleaction.RNiceIO.RNPath @directoryPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directoryPath.Value};
            var ___result = RMDirectory_SetCurrentDirectory_NPath.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Directory_GetDirectories(Hvak.Editor.Refleaction.RNiceIO.RNPath @path, System.String @filter, System.IO.SearchOption @searchOptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value, @filter, @searchOptions};
            var ___result = RMDirectory_GetDirectories_NPath_String_SearchOption.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Resolve(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMResolve_NPath.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RNiceIO.RNPath(___result);
        }


        public virtual System.Boolean IsSymbolicLink(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMIsSymbolicLink_NPath.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreateSymbolicLink(Hvak.Editor.Refleaction.RNiceIO.RNPath @fromPath, Hvak.Editor.Refleaction.RNiceIO.RNPath @targetPath, System.Boolean @targetIsFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromPath.Value, @targetPath.Value, @targetIsFile};
            var ___result = RMCreateSymbolicLink_NPath_NPath_Boolean.Invoke(___genericsType, ___parameters);

            
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
}