
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.FileSystemRights
	/// </summary>
    public partial class RFileSystemRights : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ListDirectory
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FListDirectory;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFListDirectory
		{
			get
			{
				if(r_FListDirectory == null)
				{
					r_FListDirectory = new(typeof(System.Security.AccessControl.FileSystemRights), "ListDirectory");
					r_FListDirectory.SetBelong(null);
				}
				return r_FListDirectory;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ReadData
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FReadData;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFReadData
		{
			get
			{
				if(r_FReadData == null)
				{
					r_FReadData = new(typeof(System.Security.AccessControl.FileSystemRights), "ReadData");
					r_FReadData.SetBelong(null);
				}
				return r_FReadData;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights CreateFiles
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FCreateFiles;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFCreateFiles
		{
			get
			{
				if(r_FCreateFiles == null)
				{
					r_FCreateFiles = new(typeof(System.Security.AccessControl.FileSystemRights), "CreateFiles");
					r_FCreateFiles.SetBelong(null);
				}
				return r_FCreateFiles;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights WriteData
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FWriteData;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFWriteData
		{
			get
			{
				if(r_FWriteData == null)
				{
					r_FWriteData = new(typeof(System.Security.AccessControl.FileSystemRights), "WriteData");
					r_FWriteData.SetBelong(null);
				}
				return r_FWriteData;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights AppendData
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FAppendData;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFAppendData
		{
			get
			{
				if(r_FAppendData == null)
				{
					r_FAppendData = new(typeof(System.Security.AccessControl.FileSystemRights), "AppendData");
					r_FAppendData.SetBelong(null);
				}
				return r_FAppendData;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights CreateDirectories
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FCreateDirectories;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFCreateDirectories
		{
			get
			{
				if(r_FCreateDirectories == null)
				{
					r_FCreateDirectories = new(typeof(System.Security.AccessControl.FileSystemRights), "CreateDirectories");
					r_FCreateDirectories.SetBelong(null);
				}
				return r_FCreateDirectories;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ReadExtendedAttributes
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FReadExtendedAttributes;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFReadExtendedAttributes
		{
			get
			{
				if(r_FReadExtendedAttributes == null)
				{
					r_FReadExtendedAttributes = new(typeof(System.Security.AccessControl.FileSystemRights), "ReadExtendedAttributes");
					r_FReadExtendedAttributes.SetBelong(null);
				}
				return r_FReadExtendedAttributes;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights WriteExtendedAttributes
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FWriteExtendedAttributes;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFWriteExtendedAttributes
		{
			get
			{
				if(r_FWriteExtendedAttributes == null)
				{
					r_FWriteExtendedAttributes = new(typeof(System.Security.AccessControl.FileSystemRights), "WriteExtendedAttributes");
					r_FWriteExtendedAttributes.SetBelong(null);
				}
				return r_FWriteExtendedAttributes;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ExecuteFile
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FExecuteFile;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFExecuteFile
		{
			get
			{
				if(r_FExecuteFile == null)
				{
					r_FExecuteFile = new(typeof(System.Security.AccessControl.FileSystemRights), "ExecuteFile");
					r_FExecuteFile.SetBelong(null);
				}
				return r_FExecuteFile;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights Traverse
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FTraverse;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFTraverse
		{
			get
			{
				if(r_FTraverse == null)
				{
					r_FTraverse = new(typeof(System.Security.AccessControl.FileSystemRights), "Traverse");
					r_FTraverse.SetBelong(null);
				}
				return r_FTraverse;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights DeleteSubdirectoriesAndFiles
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FDeleteSubdirectoriesAndFiles;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFDeleteSubdirectoriesAndFiles
		{
			get
			{
				if(r_FDeleteSubdirectoriesAndFiles == null)
				{
					r_FDeleteSubdirectoriesAndFiles = new(typeof(System.Security.AccessControl.FileSystemRights), "DeleteSubdirectoriesAndFiles");
					r_FDeleteSubdirectoriesAndFiles.SetBelong(null);
				}
				return r_FDeleteSubdirectoriesAndFiles;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ReadAttributes
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FReadAttributes;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFReadAttributes
		{
			get
			{
				if(r_FReadAttributes == null)
				{
					r_FReadAttributes = new(typeof(System.Security.AccessControl.FileSystemRights), "ReadAttributes");
					r_FReadAttributes.SetBelong(null);
				}
				return r_FReadAttributes;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights WriteAttributes
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FWriteAttributes;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFWriteAttributes
		{
			get
			{
				if(r_FWriteAttributes == null)
				{
					r_FWriteAttributes = new(typeof(System.Security.AccessControl.FileSystemRights), "WriteAttributes");
					r_FWriteAttributes.SetBelong(null);
				}
				return r_FWriteAttributes;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights Write
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FWrite;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFWrite
		{
			get
			{
				if(r_FWrite == null)
				{
					r_FWrite = new(typeof(System.Security.AccessControl.FileSystemRights), "Write");
					r_FWrite.SetBelong(null);
				}
				return r_FWrite;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights Delete
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FDelete;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFDelete
		{
			get
			{
				if(r_FDelete == null)
				{
					r_FDelete = new(typeof(System.Security.AccessControl.FileSystemRights), "Delete");
					r_FDelete.SetBelong(null);
				}
				return r_FDelete;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ReadPermissions
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FReadPermissions;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFReadPermissions
		{
			get
			{
				if(r_FReadPermissions == null)
				{
					r_FReadPermissions = new(typeof(System.Security.AccessControl.FileSystemRights), "ReadPermissions");
					r_FReadPermissions.SetBelong(null);
				}
				return r_FReadPermissions;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights Read
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FRead;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFRead
		{
			get
			{
				if(r_FRead == null)
				{
					r_FRead = new(typeof(System.Security.AccessControl.FileSystemRights), "Read");
					r_FRead.SetBelong(null);
				}
				return r_FRead;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ReadAndExecute
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FReadAndExecute;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFReadAndExecute
		{
			get
			{
				if(r_FReadAndExecute == null)
				{
					r_FReadAndExecute = new(typeof(System.Security.AccessControl.FileSystemRights), "ReadAndExecute");
					r_FReadAndExecute.SetBelong(null);
				}
				return r_FReadAndExecute;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights Modify
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FModify;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFModify
		{
			get
			{
				if(r_FModify == null)
				{
					r_FModify = new(typeof(System.Security.AccessControl.FileSystemRights), "Modify");
					r_FModify.SetBelong(null);
				}
				return r_FModify;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights ChangePermissions
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FChangePermissions;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFChangePermissions
		{
			get
			{
				if(r_FChangePermissions == null)
				{
					r_FChangePermissions = new(typeof(System.Security.AccessControl.FileSystemRights), "ChangePermissions");
					r_FChangePermissions.SetBelong(null);
				}
				return r_FChangePermissions;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights TakeOwnership
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FTakeOwnership;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFTakeOwnership
		{
			get
			{
				if(r_FTakeOwnership == null)
				{
					r_FTakeOwnership = new(typeof(System.Security.AccessControl.FileSystemRights), "TakeOwnership");
					r_FTakeOwnership.SetBelong(null);
				}
				return r_FTakeOwnership;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights Synchronize
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FSynchronize;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFSynchronize
		{
			get
			{
				if(r_FSynchronize == null)
				{
					r_FSynchronize = new(typeof(System.Security.AccessControl.FileSystemRights), "Synchronize");
					r_FSynchronize.SetBelong(null);
				}
				return r_FSynchronize;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.FileSystemRights FullControl
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights r_FFullControl;
		public static SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl.RFileSystemRights RFFullControl
		{
			get
			{
				if(r_FFullControl == null)
				{
					r_FFullControl = new(typeof(System.Security.AccessControl.FileSystemRights), "FullControl");
					r_FFullControl.SetBelong(null);
				}
				return r_FFullControl;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.instance);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.instance);
				}
				return r_MGetTypeCode;
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


        public RFileSystemRights() : base("System.Security.AccessControl.FileSystemRights")
        {
        }

        public RFileSystemRights(System.Object instance) : base("System.Security.AccessControl.FileSystemRights")
		{
            SetInstance(instance);
		}

        public RFileSystemRights(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFileSystemRights(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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