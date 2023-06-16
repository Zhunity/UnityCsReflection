
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RNiceIO
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// NiceIO.NPath
	/// </summary>
    public partial class RNPath : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("NiceIO.NPath");
            }
        }

        public RNPath() : base("NiceIO.NPath")
        {
        }

        public RNPath(System.Object instance) : base("NiceIO.NPath")
		{
            SetInstance(instance);
		}

        public RNPath(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNPath(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean k_IsCaseSensitiveFileSystem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fk_IsCaseSensitiveFileSystem;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFk_IsCaseSensitiveFileSystem
		{
			get
			{
				if(r_Fk_IsCaseSensitiveFileSystem == null)
				{
					r_Fk_IsCaseSensitiveFileSystem = new(Type, "k_IsCaseSensitiveFileSystem");
				}
				return r_Fk_IsCaseSensitiveFileSystem;
			}
		}

		/// <summary>
		/// System.Boolean k_IsWindows
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fk_IsWindows;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFk_IsWindows
		{
			get
			{
				if(r_Fk_IsWindows == null)
				{
					r_Fk_IsWindows = new(Type, "k_IsWindows");
				}
				return r_Fk_IsWindows;
			}
		}

		/// <summary>
		/// System.StringComparison PathStringComparison
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RStringComparison r_FPathStringComparison;
		public static Hvak.Editor.Refleaction.RSystem.RStringComparison RFPathStringComparison
		{
			get
			{
				if(r_FPathStringComparison == null)
				{
					r_FPathStringComparison = new(Type, "PathStringComparison");
				}
				return r_FPathStringComparison;
			}
		}

		/// <summary>
		/// System.String _path
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_path;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_path
		{
			get
			{
				if(r_F_path == null)
				{
					r_F_path = new(this, "_path");
				}
				return r_F_path;
			}
		}

		/// <summary>
		/// System.Int32 MethodImplOptions_AggressiveInlining
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMethodImplOptions_AggressiveInlining;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMethodImplOptions_AggressiveInlining
		{
			get
			{
				if(r_FMethodImplOptions_AggressiveInlining == null)
				{
					r_FMethodImplOptions_AggressiveInlining = new(Type, "MethodImplOptions_AggressiveInlining");
				}
				return r_FMethodImplOptions_AggressiveInlining;
			}
		}

		/// <summary>
		/// NiceIO.NPath Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RNiceIO.RNPath r_PEmpty;
		public static Hvak.Editor.Refleaction.RNiceIO.RNPath RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new(Type, "Empty", -1);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// NiceIO.NPath Parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RNiceIO.RNPath r_PParent;
		public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath RPParent
		{
			get
			{
				if(r_PParent == null)
				{
					r_PParent = new(this, "Parent", -1);
				}
				return r_PParent;
			}
		}

		/// <summary>
		/// Boolean IsRelative
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRelative;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRelative
		{
			get
			{
				if(r_PIsRelative == null)
				{
					r_PIsRelative = new(this, "IsRelative", -1);
				}
				return r_PIsRelative;
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
				}
				return r_PFileName;
			}
		}

		/// <summary>
		/// System.String FileNameWithoutExtension
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFileNameWithoutExtension;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFileNameWithoutExtension
		{
			get
			{
				if(r_PFileNameWithoutExtension == null)
				{
					r_PFileNameWithoutExtension = new(this, "FileNameWithoutExtension", -1);
				}
				return r_PFileNameWithoutExtension;
			}
		}

		/// <summary>
		/// Int32 Depth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PDepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPDepth
		{
			get
			{
				if(r_PDepth == null)
				{
					r_PDepth = new(this, "Depth", -1);
				}
				return r_PDepth;
			}
		}

		/// <summary>
		/// Boolean IsCurrentDir
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCurrentDir;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCurrentDir
		{
			get
			{
				if(r_PIsCurrentDir == null)
				{
					r_PIsCurrentDir = new(this, "IsCurrentDir", -1);
				}
				return r_PIsCurrentDir;
			}
		}

		/// <summary>
		/// System.String Extension
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PExtension;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPExtension
		{
			get
			{
				if(r_PExtension == null)
				{
					r_PExtension = new(this, "Extension", -1);
				}
				return r_PExtension;
			}
		}

		/// <summary>
		/// System.String UNCServerName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PUNCServerName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPUNCServerName
		{
			get
			{
				if(r_PUNCServerName == null)
				{
					r_PUNCServerName = new(this, "UNCServerName", -1);
				}
				return r_PUNCServerName;
			}
		}

		/// <summary>
		/// System.String DriveLetter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDriveLetter;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDriveLetter
		{
			get
			{
				if(r_PDriveLetter == null)
				{
					r_PDriveLetter = new(this, "DriveLetter", -1);
				}
				return r_PDriveLetter;
			}
		}

		/// <summary>
		/// Boolean IsRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsRoot
		{
			get
			{
				if(r_PIsRoot == null)
				{
					r_PIsRoot = new(this, "IsRoot", -1);
				}
				return r_PIsRoot;
			}
		}

		/// <summary>
		/// Boolean IsUNC
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsUNC;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsUNC
		{
			get
			{
				if(r_PIsUNC == null)
				{
					r_PIsUNC = new(this, "IsUNC", -1);
				}
				return r_PIsUNC;
			}
		}

		/// <summary>
		/// Boolean IsSymbolicLink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSymbolicLink;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSymbolicLink
		{
			get
			{
				if(r_PIsSymbolicLink == null)
				{
					r_PIsSymbolicLink = new(this, "IsSymbolicLink", -1);
				}
				return r_PIsSymbolicLink;
			}
		}

		/// <summary>
		/// NiceIO.NPath CurrentDirectory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RNiceIO.RNPath r_PCurrentDirectory;
		public static Hvak.Editor.Refleaction.RNiceIO.RNPath RPCurrentDirectory
		{
			get
			{
				if(r_PCurrentDirectory == null)
				{
					r_PCurrentDirectory = new(Type, "CurrentDirectory", -1);
				}
				return r_PCurrentDirectory;
			}
		}

		/// <summary>
		/// NiceIO.NPath HomeDirectory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RNiceIO.RNPath r_PHomeDirectory;
		public static Hvak.Editor.Refleaction.RNiceIO.RNPath RPHomeDirectory
		{
			get
			{
				if(r_PHomeDirectory == null)
				{
					r_PHomeDirectory = new(Type, "HomeDirectory", -1);
				}
				return r_PHomeDirectory;
			}
		}

		/// <summary>
		/// NiceIO.NPath SystemTemp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RNiceIO.RNPath r_PSystemTemp;
		public static Hvak.Editor.Refleaction.RNiceIO.RNPath RPSystemTemp
		{
			get
			{
				if(r_PSystemTemp == null)
				{
					r_PSystemTemp = new(Type, "SystemTemp", -1);
				}
				return r_PSystemTemp;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[NiceIO.NPath] RecursiveParents
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RNiceIO.RNPath> r_PRecursiveParents;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RNiceIO.RNPath> RPRecursiveParents
		{
			get
			{
				if(r_PRecursiveParents == null)
				{
					r_PRecursiveParents = new(this, "RecursiveParents", -1);
				}
				return r_PRecursiveParents;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean CalculateIsWindows()
		/// </summary>
		protected static RMethod r_MCalculateIsWindows;
		public static RMethod RMCalculateIsWindows
		{
			get
			{
				if(r_MCalculateIsWindows == null)
				{
					r_MCalculateIsWindows = new(Type, "CalculateIsWindows", 0);
				}
				return r_MCalculateIsWindows;
			}
		}

		/// <summary>
		/// Boolean CalculateIsWindows10()
		/// </summary>
		protected static RMethod r_MCalculateIsWindows10;
		public static RMethod RMCalculateIsWindows10
		{
			get
			{
				if(r_MCalculateIsWindows10 == null)
				{
					r_MCalculateIsWindows10 = new(Type, "CalculateIsWindows10", 0);
				}
				return r_MCalculateIsWindows10;
			}
		}

		/// <summary>
		/// Boolean IsUNCPath(System.String)
		/// </summary>
		protected static RMethod r_MIsUNCPath_String;
		public static RMethod RMIsUNCPath_String
		{
			get
			{
				if(r_MIsUNCPath_String == null)
				{
					r_MIsUNCPath_String = new(Type, "IsUNCPath", 0, typeof(System.String));
				}
				return r_MIsUNCPath_String;
			}
		}

		/// <summary>
		/// System.String ConvertToForwardSlashPath(System.String)
		/// </summary>
		protected static RMethod r_MConvertToForwardSlashPath_String;
		public static RMethod RMConvertToForwardSlashPath_String
		{
			get
			{
				if(r_MConvertToForwardSlashPath_String == null)
				{
					r_MConvertToForwardSlashPath_String = new(Type, "ConvertToForwardSlashPath", 0, typeof(System.String));
				}
				return r_MConvertToForwardSlashPath_String;
			}
		}

		/// <summary>
		/// System.String MakeCompletelyWellFormatted(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MMakeCompletelyWellFormatted_String_Boolean;
		public static RMethod RMMakeCompletelyWellFormatted_String_Boolean
		{
			get
			{
				if(r_MMakeCompletelyWellFormatted_String_Boolean == null)
				{
					r_MMakeCompletelyWellFormatted_String_Boolean = new(Type, "MakeCompletelyWellFormatted", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MMakeCompletelyWellFormatted_String_Boolean;
			}
		}

		/// <summary>
		/// System.String CollapseSingleDots(System.String)
		/// </summary>
		protected static RMethod r_MCollapseSingleDots_String;
		public static RMethod RMCollapseSingleDots_String
		{
			get
			{
				if(r_MCollapseSingleDots_String == null)
				{
					r_MCollapseSingleDots_String = new(Type, "CollapseSingleDots", 0, typeof(System.String));
				}
				return r_MCollapseSingleDots_String;
			}
		}

		/// <summary>
		/// System.String CollapseDoubleSlashes(System.String)
		/// </summary>
		protected static RMethod r_MCollapseDoubleSlashes_String;
		public static RMethod RMCollapseDoubleSlashes_String
		{
			get
			{
				if(r_MCollapseDoubleSlashes_String == null)
				{
					r_MCollapseDoubleSlashes_String = new(Type, "CollapseDoubleSlashes", 0, typeof(System.String));
				}
				return r_MCollapseDoubleSlashes_String;
			}
		}

		/// <summary>
		/// System.String CollapseDoubleDots(System.String)
		/// </summary>
		protected static RMethod r_MCollapseDoubleDots_String;
		public static RMethod RMCollapseDoubleDots_String
		{
			get
			{
				if(r_MCollapseDoubleDots_String == null)
				{
					r_MCollapseDoubleDots_String = new(Type, "CollapseDoubleDots", 0, typeof(System.String));
				}
				return r_MCollapseDoubleDots_String;
			}
		}

		/// <summary>
		/// Boolean IsSlash(Char)
		/// </summary>
		protected static RMethod r_MIsSlash_Char;
		public static RMethod RMIsSlash_Char
		{
			get
			{
				if(r_MIsSlash_Char == null)
				{
					r_MIsSlash_Char = new(Type, "IsSlash", 0, typeof(System.Char));
				}
				return r_MIsSlash_Char;
			}
		}

		/// <summary>
		/// NiceIO.NPath Combine(System.String)
		/// </summary>
		protected RMethod r_MCombine_String;
		public virtual RMethod RMCombine_String
		{
			get
			{
				if(r_MCombine_String == null)
				{
					r_MCombine_String = new(this, "Combine", 0, typeof(System.String));
				}
				return r_MCombine_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath Combine(System.String, System.String)
		/// </summary>
		protected RMethod r_MCombine_String_String;
		public virtual RMethod RMCombine_String_String
		{
			get
			{
				if(r_MCombine_String_String == null)
				{
					r_MCombine_String_String = new(this, "Combine", 0, typeof(System.String), typeof(System.String));
				}
				return r_MCombine_String_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath Combine(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MCombine_NPath;
		public virtual RMethod RMCombine_NPath
		{
			get
			{
				if(r_MCombine_NPath == null)
				{
					r_MCombine_NPath = new(this, "Combine", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MCombine_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath Combine(NiceIO.NPath[])
		/// </summary>
		protected RMethod r_MCombine_NPathArray;
		public virtual RMethod RMCombine_NPathArray
		{
			get
			{
				if(r_MCombine_NPathArray == null)
				{
					r_MCombine_NPathArray = new(this, "Combine", 0,  ReflectionUtils.GetType("NiceIO.NPath").MakeArrayType());
				}
				return r_MCombine_NPathArray;
			}
		}

		/// <summary>
		/// NiceIO.NPath RelativeTo(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MRelativeTo_NPath;
		public virtual RMethod RMRelativeTo_NPath
		{
			get
			{
				if(r_MRelativeTo_NPath == null)
				{
					r_MRelativeTo_NPath = new(this, "RelativeTo", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MRelativeTo_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath ChangeExtension(System.String)
		/// </summary>
		protected RMethod r_MChangeExtension_String;
		public virtual RMethod RMChangeExtension_String
		{
			get
			{
				if(r_MChangeExtension_String == null)
				{
					r_MChangeExtension_String = new(this, "ChangeExtension", 0, typeof(System.String));
				}
				return r_MChangeExtension_String;
			}
		}

		/// <summary>
		/// Boolean HasDirectory(System.String)
		/// </summary>
		protected RMethod r_MHasDirectory_String;
		public virtual RMethod RMHasDirectory_String
		{
			get
			{
				if(r_MHasDirectory_String == null)
				{
					r_MHasDirectory_String = new(this, "HasDirectory", 0, typeof(System.String));
				}
				return r_MHasDirectory_String;
			}
		}

		/// <summary>
		/// Boolean Exists(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MExists_NPath;
		public virtual RMethod RMExists_NPath
		{
			get
			{
				if(r_MExists_NPath == null)
				{
					r_MExists_NPath = new(this, "Exists", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MExists_NPath;
			}
		}

		/// <summary>
		/// Boolean DirectoryExists(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MDirectoryExists_NPath;
		public virtual RMethod RMDirectoryExists_NPath
		{
			get
			{
				if(r_MDirectoryExists_NPath == null)
				{
					r_MDirectoryExists_NPath = new(this, "DirectoryExists", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MDirectoryExists_NPath;
			}
		}

		/// <summary>
		/// Boolean FileExists(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MFileExists_NPath;
		public virtual RMethod RMFileExists_NPath
		{
			get
			{
				if(r_MFileExists_NPath == null)
				{
					r_MFileExists_NPath = new(this, "FileExists", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MFileExists_NPath;
			}
		}

		/// <summary>
		/// Boolean HasSameUNCServerName(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MHasSameUNCServerName_NPath;
		public virtual RMethod RMHasSameUNCServerName_NPath
		{
			get
			{
				if(r_MHasSameUNCServerName_NPath == null)
				{
					r_MHasSameUNCServerName_NPath = new(this, "HasSameUNCServerName", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MHasSameUNCServerName_NPath;
			}
		}

		/// <summary>
		/// Boolean HasSameDriveLetter(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MHasSameDriveLetter_NPath;
		public virtual RMethod RMHasSameDriveLetter_NPath
		{
			get
			{
				if(r_MHasSameDriveLetter_NPath == null)
				{
					r_MHasSameDriveLetter_NPath = new(this, "HasSameDriveLetter", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MHasSameDriveLetter_NPath;
			}
		}

		/// <summary>
		/// System.String InQuotes(NiceIO.SlashMode)
		/// </summary>
		protected RMethod r_MInQuotes_SlashMode;
		public virtual RMethod RMInQuotes_SlashMode
		{
			get
			{
				if(r_MInQuotes_SlashMode == null)
				{
					r_MInQuotes_SlashMode = new(this, "InQuotes", 0,  ReflectionUtils.GetType("NiceIO.SlashMode"));
				}
				return r_MInQuotes_SlashMode;
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
		/// System.String ToString(NiceIO.SlashMode)
		/// </summary>
		protected RMethod r_MToString_SlashMode;
		public virtual RMethod RMToString_SlashMode
		{
			get
			{
				if(r_MToString_SlashMode == null)
				{
					r_MToString_SlashMode = new(this, "ToString", 0,  ReflectionUtils.GetType("NiceIO.SlashMode"));
				}
				return r_MToString_SlashMode;
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
		/// Boolean Equals(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MEquals_NPath;
		public virtual RMethod RMEquals_NPath
		{
			get
			{
				if(r_MEquals_NPath == null)
				{
					r_MEquals_NPath = new(this, "Equals", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MEquals_NPath;
			}
		}

		/// <summary>
		/// Boolean op_Equality(NiceIO.NPath, NiceIO.NPath)
		/// </summary>
		protected static RMethod r_Mop_Equality_NPath_NPath;
		public static RMethod RMop_Equality_NPath_NPath
		{
			get
			{
				if(r_Mop_Equality_NPath_NPath == null)
				{
					r_Mop_Equality_NPath_NPath = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_Mop_Equality_NPath_NPath;
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
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(NiceIO.NPath, NiceIO.NPath)
		/// </summary>
		protected static RMethod r_Mop_Inequality_NPath_NPath;
		public static RMethod RMop_Inequality_NPath_NPath
		{
			get
			{
				if(r_Mop_Inequality_NPath_NPath == null)
				{
					r_Mop_Inequality_NPath_NPath = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_Mop_Inequality_NPath_NPath;
			}
		}

		/// <summary>
		/// Boolean HasExtension(System.String)
		/// </summary>
		protected RMethod r_MHasExtension_String;
		public virtual RMethod RMHasExtension_String
		{
			get
			{
				if(r_MHasExtension_String == null)
				{
					r_MHasExtension_String = new(this, "HasExtension", 0, typeof(System.String));
				}
				return r_MHasExtension_String;
			}
		}

		/// <summary>
		/// Boolean HasExtension(System.String[])
		/// </summary>
		protected RMethod r_MHasExtension_StringArray;
		public virtual RMethod RMHasExtension_StringArray
		{
			get
			{
				if(r_MHasExtension_StringArray == null)
				{
					r_MHasExtension_StringArray = new(this, "HasExtension", 0, typeof(System.String).MakeArrayType());
				}
				return r_MHasExtension_StringArray;
			}
		}

		/// <summary>
		/// System.String WithDot(System.String)
		/// </summary>
		protected static RMethod r_MWithDot_String;
		public static RMethod RMWithDot_String
		{
			get
			{
				if(r_MWithDot_String == null)
				{
					r_MWithDot_String = new(Type, "WithDot", 0, typeof(System.String));
				}
				return r_MWithDot_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Files(System.String, Boolean)
		/// </summary>
		protected RMethod r_MFiles_String_Boolean;
		public virtual RMethod RMFiles_String_Boolean
		{
			get
			{
				if(r_MFiles_String_Boolean == null)
				{
					r_MFiles_String_Boolean = new(this, "Files", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MFiles_String_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Files(Boolean)
		/// </summary>
		protected RMethod r_MFiles_Boolean;
		public virtual RMethod RMFiles_Boolean
		{
			get
			{
				if(r_MFiles_Boolean == null)
				{
					r_MFiles_Boolean = new(this, "Files", 0, typeof(System.Boolean));
				}
				return r_MFiles_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Files(System.String[], Boolean)
		/// </summary>
		protected RMethod r_MFiles_StringArray_Boolean;
		public virtual RMethod RMFiles_StringArray_Boolean
		{
			get
			{
				if(r_MFiles_StringArray_Boolean == null)
				{
					r_MFiles_StringArray_Boolean = new(this, "Files", 0, typeof(System.String).MakeArrayType(), typeof(System.Boolean));
				}
				return r_MFiles_StringArray_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Contents(System.String, Boolean)
		/// </summary>
		protected RMethod r_MContents_String_Boolean;
		public virtual RMethod RMContents_String_Boolean
		{
			get
			{
				if(r_MContents_String_Boolean == null)
				{
					r_MContents_String_Boolean = new(this, "Contents", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MContents_String_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Contents(Boolean)
		/// </summary>
		protected RMethod r_MContents_Boolean;
		public virtual RMethod RMContents_Boolean
		{
			get
			{
				if(r_MContents_Boolean == null)
				{
					r_MContents_Boolean = new(this, "Contents", 0, typeof(System.Boolean));
				}
				return r_MContents_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Directories(System.String, Boolean)
		/// </summary>
		protected RMethod r_MDirectories_String_Boolean;
		public virtual RMethod RMDirectories_String_Boolean
		{
			get
			{
				if(r_MDirectories_String_Boolean == null)
				{
					r_MDirectories_String_Boolean = new(this, "Directories", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MDirectories_String_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath[] Directories(Boolean)
		/// </summary>
		protected RMethod r_MDirectories_Boolean;
		public virtual RMethod RMDirectories_Boolean
		{
			get
			{
				if(r_MDirectories_Boolean == null)
				{
					r_MDirectories_Boolean = new(this, "Directories", 0, typeof(System.Boolean));
				}
				return r_MDirectories_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath CreateFile()
		/// </summary>
		protected RMethod r_MCreateFile;
		public virtual RMethod RMCreateFile
		{
			get
			{
				if(r_MCreateFile == null)
				{
					r_MCreateFile = new(this, "CreateFile", 0);
				}
				return r_MCreateFile;
			}
		}

		/// <summary>
		/// NiceIO.NPath CreateFile(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MCreateFile_NPath;
		public virtual RMethod RMCreateFile_NPath
		{
			get
			{
				if(r_MCreateFile_NPath == null)
				{
					r_MCreateFile_NPath = new(this, "CreateFile", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MCreateFile_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath CreateDirectory()
		/// </summary>
		protected RMethod r_MCreateDirectory;
		public virtual RMethod RMCreateDirectory
		{
			get
			{
				if(r_MCreateDirectory == null)
				{
					r_MCreateDirectory = new(this, "CreateDirectory", 0);
				}
				return r_MCreateDirectory;
			}
		}

		/// <summary>
		/// NiceIO.NPath CreateDirectory(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MCreateDirectory_NPath;
		public virtual RMethod RMCreateDirectory_NPath
		{
			get
			{
				if(r_MCreateDirectory_NPath == null)
				{
					r_MCreateDirectory_NPath = new(this, "CreateDirectory", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MCreateDirectory_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath CreateSymbolicLink(NiceIO.NPath, Boolean)
		/// </summary>
		protected RMethod r_MCreateSymbolicLink_NPath_Boolean;
		public virtual RMethod RMCreateSymbolicLink_NPath_Boolean
		{
			get
			{
				if(r_MCreateSymbolicLink_NPath_Boolean == null)
				{
					r_MCreateSymbolicLink_NPath_Boolean = new(this, "CreateSymbolicLink", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean));
				}
				return r_MCreateSymbolicLink_NPath_Boolean;
			}
		}

		/// <summary>
		/// NiceIO.NPath Copy(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MCopy_NPath;
		public virtual RMethod RMCopy_NPath
		{
			get
			{
				if(r_MCopy_NPath == null)
				{
					r_MCopy_NPath = new(this, "Copy", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MCopy_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath Copy(NiceIO.NPath, System.Func`2[NiceIO.NPath,System.Boolean])
		/// </summary>
		protected RMethod r_MCopy_NPath_Func_d_NPath_Boolean_p_;
		public virtual RMethod RMCopy_NPath_Func_d_NPath_Boolean_p_
		{
			get
			{
				if(r_MCopy_NPath_Func_d_NPath_Boolean_p_ == null)
				{
					r_MCopy_NPath_Func_d_NPath_Boolean_p_ = new(this, "Copy", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean)));
				}
				return r_MCopy_NPath_Func_d_NPath_Boolean_p_;
			}
		}

		/// <summary>
		/// NiceIO.NPath MakeAbsolute(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MMakeAbsolute_NPath;
		public virtual RMethod RMMakeAbsolute_NPath
		{
			get
			{
				if(r_MMakeAbsolute_NPath == null)
				{
					r_MMakeAbsolute_NPath = new(this, "MakeAbsolute", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MMakeAbsolute_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath CopyWithDeterminedDestination(NiceIO.NPath, System.Func`2[NiceIO.NPath,System.Boolean])
		/// </summary>
		protected RMethod r_MCopyWithDeterminedDestination_NPath_Func_d_NPath_Boolean_p_;
		public virtual RMethod RMCopyWithDeterminedDestination_NPath_Func_d_NPath_Boolean_p_
		{
			get
			{
				if(r_MCopyWithDeterminedDestination_NPath_Func_d_NPath_Boolean_p_ == null)
				{
					r_MCopyWithDeterminedDestination_NPath_Func_d_NPath_Boolean_p_ = new(this, "CopyWithDeterminedDestination", 0,  ReflectionUtils.GetType("NiceIO.NPath"),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean)));
				}
				return r_MCopyWithDeterminedDestination_NPath_Func_d_NPath_Boolean_p_;
			}
		}

		/// <summary>
		/// Void Delete(NiceIO.DeleteMode)
		/// </summary>
		protected RMethod r_MDelete_DeleteMode;
		public virtual RMethod RMDelete_DeleteMode
		{
			get
			{
				if(r_MDelete_DeleteMode == null)
				{
					r_MDelete_DeleteMode = new(this, "Delete", 0,  ReflectionUtils.GetType("NiceIO.DeleteMode"));
				}
				return r_MDelete_DeleteMode;
			}
		}

		/// <summary>
		/// NiceIO.NPath DeleteIfExists(NiceIO.DeleteMode)
		/// </summary>
		protected RMethod r_MDeleteIfExists_DeleteMode;
		public virtual RMethod RMDeleteIfExists_DeleteMode
		{
			get
			{
				if(r_MDeleteIfExists_DeleteMode == null)
				{
					r_MDeleteIfExists_DeleteMode = new(this, "DeleteIfExists", 0,  ReflectionUtils.GetType("NiceIO.DeleteMode"));
				}
				return r_MDeleteIfExists_DeleteMode;
			}
		}

		/// <summary>
		/// NiceIO.NPath DeleteContents()
		/// </summary>
		protected RMethod r_MDeleteContents;
		public virtual RMethod RMDeleteContents
		{
			get
			{
				if(r_MDeleteContents == null)
				{
					r_MDeleteContents = new(this, "DeleteContents", 0);
				}
				return r_MDeleteContents;
			}
		}

		/// <summary>
		/// NiceIO.NPath CreateTempDirectory(System.String)
		/// </summary>
		protected static RMethod r_MCreateTempDirectory_String;
		public static RMethod RMCreateTempDirectory_String
		{
			get
			{
				if(r_MCreateTempDirectory_String == null)
				{
					r_MCreateTempDirectory_String = new(Type, "CreateTempDirectory", 0, typeof(System.String));
				}
				return r_MCreateTempDirectory_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath Move(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MMove_NPath;
		public virtual RMethod RMMove_NPath
		{
			get
			{
				if(r_MMove_NPath == null)
				{
					r_MMove_NPath = new(this, "Move", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MMove_NPath;
			}
		}

		/// <summary>
		/// System.IDisposable SetCurrentDirectory(NiceIO.NPath)
		/// </summary>
		protected static RMethod r_MSetCurrentDirectory_NPath;
		public static RMethod RMSetCurrentDirectory_NPath
		{
			get
			{
				if(r_MSetCurrentDirectory_NPath == null)
				{
					r_MSetCurrentDirectory_NPath = new(Type, "SetCurrentDirectory", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MSetCurrentDirectory_NPath;
			}
		}

		/// <summary>
		/// Void ThrowIfRoot()
		/// </summary>
		protected RMethod r_MThrowIfRoot;
		public virtual RMethod RMThrowIfRoot
		{
			get
			{
				if(r_MThrowIfRoot == null)
				{
					r_MThrowIfRoot = new(this, "ThrowIfRoot", 0);
				}
				return r_MThrowIfRoot;
			}
		}

		/// <summary>
		/// NiceIO.NPath EnsureDirectoryExists(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MEnsureDirectoryExists_NPath;
		public virtual RMethod RMEnsureDirectoryExists_NPath
		{
			get
			{
				if(r_MEnsureDirectoryExists_NPath == null)
				{
					r_MEnsureDirectoryExists_NPath = new(this, "EnsureDirectoryExists", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MEnsureDirectoryExists_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath EnsureParentDirectoryExists()
		/// </summary>
		protected RMethod r_MEnsureParentDirectoryExists;
		public virtual RMethod RMEnsureParentDirectoryExists
		{
			get
			{
				if(r_MEnsureParentDirectoryExists == null)
				{
					r_MEnsureParentDirectoryExists = new(this, "EnsureParentDirectoryExists", 0);
				}
				return r_MEnsureParentDirectoryExists;
			}
		}

		/// <summary>
		/// NiceIO.NPath FileMustExist()
		/// </summary>
		protected RMethod r_MFileMustExist;
		public virtual RMethod RMFileMustExist
		{
			get
			{
				if(r_MFileMustExist == null)
				{
					r_MFileMustExist = new(this, "FileMustExist", 0);
				}
				return r_MFileMustExist;
			}
		}

		/// <summary>
		/// NiceIO.NPath DirectoryMustExist()
		/// </summary>
		protected RMethod r_MDirectoryMustExist;
		public virtual RMethod RMDirectoryMustExist
		{
			get
			{
				if(r_MDirectoryMustExist == null)
				{
					r_MDirectoryMustExist = new(this, "DirectoryMustExist", 0);
				}
				return r_MDirectoryMustExist;
			}
		}

		/// <summary>
		/// Boolean IsChildOf(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MIsChildOf_NPath;
		public virtual RMethod RMIsChildOf_NPath
		{
			get
			{
				if(r_MIsChildOf_NPath == null)
				{
					r_MIsChildOf_NPath = new(this, "IsChildOf", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MIsChildOf_NPath;
			}
		}

		/// <summary>
		/// Boolean IsSameAsOrChildOf(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MIsSameAsOrChildOf_NPath;
		public virtual RMethod RMIsSameAsOrChildOf_NPath
		{
			get
			{
				if(r_MIsSameAsOrChildOf_NPath == null)
				{
					r_MIsSameAsOrChildOf_NPath = new(this, "IsSameAsOrChildOf", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MIsSameAsOrChildOf_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath ParentContaining(NiceIO.NPath)
		/// </summary>
		protected RMethod r_MParentContaining_NPath;
		public virtual RMethod RMParentContaining_NPath
		{
			get
			{
				if(r_MParentContaining_NPath == null)
				{
					r_MParentContaining_NPath = new(this, "ParentContaining", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MParentContaining_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath WriteAllText(System.String)
		/// </summary>
		protected RMethod r_MWriteAllText_String;
		public virtual RMethod RMWriteAllText_String
		{
			get
			{
				if(r_MWriteAllText_String == null)
				{
					r_MWriteAllText_String = new(this, "WriteAllText", 0, typeof(System.String));
				}
				return r_MWriteAllText_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath ReplaceAllText(System.String)
		/// </summary>
		protected RMethod r_MReplaceAllText_String;
		public virtual RMethod RMReplaceAllText_String
		{
			get
			{
				if(r_MReplaceAllText_String == null)
				{
					r_MReplaceAllText_String = new(this, "ReplaceAllText", 0, typeof(System.String));
				}
				return r_MReplaceAllText_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath WriteAllBytes(Byte[])
		/// </summary>
		protected RMethod r_MWriteAllBytes_ByteArray;
		public virtual RMethod RMWriteAllBytes_ByteArray
		{
			get
			{
				if(r_MWriteAllBytes_ByteArray == null)
				{
					r_MWriteAllBytes_ByteArray = new(this, "WriteAllBytes", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MWriteAllBytes_ByteArray;
			}
		}

		/// <summary>
		/// System.String ReadAllText()
		/// </summary>
		protected RMethod r_MReadAllText;
		public virtual RMethod RMReadAllText
		{
			get
			{
				if(r_MReadAllText == null)
				{
					r_MReadAllText = new(this, "ReadAllText", 0);
				}
				return r_MReadAllText;
			}
		}

		/// <summary>
		/// Byte[] ReadAllBytes()
		/// </summary>
		protected RMethod r_MReadAllBytes;
		public virtual RMethod RMReadAllBytes
		{
			get
			{
				if(r_MReadAllBytes == null)
				{
					r_MReadAllBytes = new(this, "ReadAllBytes", 0);
				}
				return r_MReadAllBytes;
			}
		}

		/// <summary>
		/// NiceIO.NPath WriteAllLines(System.String[])
		/// </summary>
		protected RMethod r_MWriteAllLines_StringArray;
		public virtual RMethod RMWriteAllLines_StringArray
		{
			get
			{
				if(r_MWriteAllLines_StringArray == null)
				{
					r_MWriteAllLines_StringArray = new(this, "WriteAllLines", 0, typeof(System.String).MakeArrayType());
				}
				return r_MWriteAllLines_StringArray;
			}
		}

		/// <summary>
		/// System.String[] ReadAllLines()
		/// </summary>
		protected RMethod r_MReadAllLines;
		public virtual RMethod RMReadAllLines
		{
			get
			{
				if(r_MReadAllLines == null)
				{
					r_MReadAllLines = new(this, "ReadAllLines", 0);
				}
				return r_MReadAllLines;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[NiceIO.NPath] CopyFiles(NiceIO.NPath, Boolean, System.Func`2[NiceIO.NPath,System.Boolean])
		/// </summary>
		protected RMethod r_MCopyFiles_NPath_Boolean_Func_d_NPath_Boolean_p_;
		public virtual RMethod RMCopyFiles_NPath_Boolean_Func_d_NPath_Boolean_p_
		{
			get
			{
				if(r_MCopyFiles_NPath_Boolean_Func_d_NPath_Boolean_p_ == null)
				{
					r_MCopyFiles_NPath_Boolean_Func_d_NPath_Boolean_p_ = new(this, "CopyFiles", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean)));
				}
				return r_MCopyFiles_NPath_Boolean_Func_d_NPath_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[NiceIO.NPath] MoveFiles(NiceIO.NPath, Boolean, System.Func`2[NiceIO.NPath,System.Boolean])
		/// </summary>
		protected RMethod r_MMoveFiles_NPath_Boolean_Func_d_NPath_Boolean_p_;
		public virtual RMethod RMMoveFiles_NPath_Boolean_Func_d_NPath_Boolean_p_
		{
			get
			{
				if(r_MMoveFiles_NPath_Boolean_Func_d_NPath_Boolean_p_ == null)
				{
					r_MMoveFiles_NPath_Boolean_Func_d_NPath_Boolean_p_ = new(this, "MoveFiles", 0,  ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean),  ReflectionUtils.GetType("System.Func`2").MakeGenericType( ReflectionUtils.GetType("NiceIO.NPath"), typeof(System.Boolean)));
				}
				return r_MMoveFiles_NPath_Boolean_Func_d_NPath_Boolean_p_;
			}
		}

		/// <summary>
		/// Boolean AlwaysTrue(NiceIO.NPath)
		/// </summary>
		protected static RMethod r_MAlwaysTrue_NPath;
		public static RMethod RMAlwaysTrue_NPath
		{
			get
			{
				if(r_MAlwaysTrue_NPath == null)
				{
					r_MAlwaysTrue_NPath = new(Type, "AlwaysTrue", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MAlwaysTrue_NPath;
			}
		}

		/// <summary>
		/// NiceIO.NPath op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Implicit_String;
		public static RMethod RMop_Implicit_String
		{
			get
			{
				if(r_Mop_Implicit_String == null)
				{
					r_Mop_Implicit_String = new(Type, "op_Implicit", 0, typeof(System.String));
				}
				return r_Mop_Implicit_String;
			}
		}

		/// <summary>
		/// NiceIO.NPath SetLastWriteTimeUtc(System.DateTime)
		/// </summary>
		protected RMethod r_MSetLastWriteTimeUtc_DateTime;
		public virtual RMethod RMSetLastWriteTimeUtc_DateTime
		{
			get
			{
				if(r_MSetLastWriteTimeUtc_DateTime == null)
				{
					r_MSetLastWriteTimeUtc_DateTime = new(this, "SetLastWriteTimeUtc", 0, typeof(System.DateTime));
				}
				return r_MSetLastWriteTimeUtc_DateTime;
			}
		}

		/// <summary>
		/// System.DateTime GetLastWriteTimeUtc()
		/// </summary>
		protected RMethod r_MGetLastWriteTimeUtc;
		public virtual RMethod RMGetLastWriteTimeUtc
		{
			get
			{
				if(r_MGetLastWriteTimeUtc == null)
				{
					r_MGetLastWriteTimeUtc = new(this, "GetLastWriteTimeUtc", 0);
				}
				return r_MGetLastWriteTimeUtc;
			}
		}

		/// <summary>
		/// Int64 GetFileSize()
		/// </summary>
		protected RMethod r_MGetFileSize;
		public virtual RMethod RMGetFileSize
		{
			get
			{
				if(r_MGetFileSize == null)
				{
					r_MGetFileSize = new(this, "GetFileSize", 0);
				}
				return r_MGetFileSize;
			}
		}

		/// <summary>
		/// System.IDisposable WithFileSystem(FileSystem)
		/// </summary>
		protected static RMethod r_MWithFileSystem_FileSystem;
		public static RMethod RMWithFileSystem_FileSystem
		{
			get
			{
				if(r_MWithFileSystem_FileSystem == null)
				{
					r_MWithFileSystem_FileSystem = new(Type, "WithFileSystem", 0,  ReflectionUtils.GetType("NiceIO.NPath+FileSystem"));
				}
				return r_MWithFileSystem_FileSystem;
			}
		}

		/// <summary>
		/// NiceIO.NPath ResolveWithFileSystem()
		/// </summary>
		protected RMethod r_MResolveWithFileSystem;
		public virtual RMethod RMResolveWithFileSystem
		{
			get
			{
				if(r_MResolveWithFileSystem == null)
				{
					r_MResolveWithFileSystem = new(this, "ResolveWithFileSystem", 0);
				}
				return r_MResolveWithFileSystem;
			}
		}

		/// <summary>
		/// System.String InQuotesResolved(NiceIO.SlashMode)
		/// </summary>
		protected RMethod r_MInQuotesResolved_SlashMode;
		public virtual RMethod RMInQuotesResolved_SlashMode
		{
			get
			{
				if(r_MInQuotesResolved_SlashMode == null)
				{
					r_MInQuotesResolved_SlashMode = new(this, "InQuotesResolved", 0,  ReflectionUtils.GetType("NiceIO.SlashMode"));
				}
				return r_MInQuotesResolved_SlashMode;
			}
		}

		/// <summary>
		/// System.IDisposable WithFrozenCurrentDirectory(NiceIO.NPath)
		/// </summary>
		protected static RMethod r_MWithFrozenCurrentDirectory_NPath;
		public static RMethod RMWithFrozenCurrentDirectory_NPath
		{
			get
			{
				if(r_MWithFrozenCurrentDirectory_NPath == null)
				{
					r_MWithFrozenCurrentDirectory_NPath = new(Type, "WithFrozenCurrentDirectory", 0,  ReflectionUtils.GetType("NiceIO.NPath"));
				}
				return r_MWithFrozenCurrentDirectory_NPath;
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


        public static System.Boolean CalculateIsWindows()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalculateIsWindows.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean CalculateIsWindows10()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalculateIsWindows10.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsUNCPath(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMIsUNCPath_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.String ConvertToForwardSlashPath(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMConvertToForwardSlashPath_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String MakeCompletelyWellFormatted(System.String @path, System.Boolean @doubleDotsAreCollapsed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @doubleDotsAreCollapsed};
            var ___result = RMMakeCompletelyWellFormatted_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String CollapseSingleDots(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMCollapseSingleDots_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String CollapseDoubleSlashes(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMCollapseDoubleSlashes_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String CollapseDoubleDots(System.String @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path};
            var ___result = RMCollapseDoubleDots_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Boolean IsSlash(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsSlash_Char.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Combine(System.String @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append};
            var ___result = RMCombine_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Combine(System.String @append1, System.String @append2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append1, @append2};
            var ___result = RMCombine_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Combine(Hvak.Editor.Refleaction.RNiceIO.RNPath @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append.Value};
            var ___result = RMCombine_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Combine(Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append.Value};
            var ___result = RMCombine_NPathArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath RelativeTo(Hvak.Editor.Refleaction.RNiceIO.RNPath @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path.Value};
            var ___result = RMRelativeTo_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath ChangeExtension(System.String @extension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extension};
            var ___result = RMChangeExtension_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.Boolean HasDirectory(System.String @dir)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dir};
            var ___result = RMHasDirectory_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Exists(Hvak.Editor.Refleaction.RNiceIO.RNPath @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append.Value};
            var ___result = RMExists_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean DirectoryExists(Hvak.Editor.Refleaction.RNiceIO.RNPath @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append.Value};
            var ___result = RMDirectoryExists_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean FileExists(Hvak.Editor.Refleaction.RNiceIO.RNPath @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append.Value};
            var ___result = RMFileExists_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasSameUNCServerName(Hvak.Editor.Refleaction.RNiceIO.RNPath @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMHasSameUNCServerName_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasSameDriveLetter(Hvak.Editor.Refleaction.RNiceIO.RNPath @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMHasSameDriveLetter_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String InQuotes(Hvak.Editor.Refleaction.RNiceIO.RSlashMode @slashMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slashMode.Value};
            var ___result = RMInQuotes_SlashMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(Hvak.Editor.Refleaction.RNiceIO.RSlashMode @slashMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slashMode.Value};
            var ___result = RMToString_SlashMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RNiceIO.RNPath @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMEquals_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RNiceIO.RNPath @a, Hvak.Editor.Refleaction.RNiceIO.RNPath @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a.Value, @b.Value};
            var ___result = RMop_Equality_NPath_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RNiceIO.RNPath @a, Hvak.Editor.Refleaction.RNiceIO.RNPath @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a.Value, @b.Value};
            var ___result = RMop_Inequality_NPath_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasExtension(System.String @extension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extension};
            var ___result = RMHasExtension_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasExtension(System.String[] @extensions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extensions};
            var ___result = RMHasExtension_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.String WithDot(System.String @extension)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extension};
            var ___result = RMWithDot_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Files(System.String @filter, System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @recurse};
            var ___result = RMFiles_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Files(System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@recurse};
            var ___result = RMFiles_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Files(System.String[] @extensions, System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@extensions, @recurse};
            var ___result = RMFiles_StringArray_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Contents(System.String @filter, System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @recurse};
            var ___result = RMContents_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Contents(System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@recurse};
            var ___result = RMContents_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Directories(System.String @filter, System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @recurse};
            var ___result = RMDirectories_String_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath> Directories(System.Boolean @recurse)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@recurse};
            var ___result = RMDirectories_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RTypeArray<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath CreateFile()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateFile.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath CreateFile(Hvak.Editor.Refleaction.RNiceIO.RNPath @file)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@file.Value};
            var ___result = RMCreateFile_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath CreateDirectory()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDirectory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath CreateDirectory(Hvak.Editor.Refleaction.RNiceIO.RNPath @directory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directory.Value};
            var ___result = RMCreateDirectory_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath CreateSymbolicLink(Hvak.Editor.Refleaction.RNiceIO.RNPath @targetPath, System.Boolean @targetIsFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetPath.Value, @targetIsFile};
            var ___result = RMCreateSymbolicLink_NPath_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Copy(Hvak.Editor.Refleaction.RNiceIO.RNPath @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest.Value};
            var ___result = RMCopy_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Copy(Hvak.Editor.Refleaction.RNiceIO.RNPath @dest, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RNiceIO.RNPath, Hvak.Editor.Refleaction.RSystem.RBoolean> @fileFilter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest.Value, @fileFilter.Value};
            var ___result = RMCopy_NPath_Func_d_NPath_Boolean_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath MakeAbsolute(Hvak.Editor.Refleaction.RNiceIO.RNPath @base)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@base.Value};
            var ___result = RMMakeAbsolute_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath CopyWithDeterminedDestination(Hvak.Editor.Refleaction.RNiceIO.RNPath @destination, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RNiceIO.RNPath, Hvak.Editor.Refleaction.RSystem.RBoolean> @fileFilter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @fileFilter.Value};
            var ___result = RMCopyWithDeterminedDestination_NPath_Func_d_NPath_Boolean_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual void Delete(Hvak.Editor.Refleaction.RNiceIO.RDeleteMode @deleteMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deleteMode.Value};
            var ___result = RMDelete_DeleteMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath DeleteIfExists(Hvak.Editor.Refleaction.RNiceIO.RDeleteMode @deleteMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deleteMode.Value};
            var ___result = RMDeleteIfExists_DeleteMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath DeleteContents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteContents.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public static Hvak.Editor.Refleaction.RNiceIO.RNPath CreateTempDirectory(System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RMCreateTempDirectory_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath Move(Hvak.Editor.Refleaction.RNiceIO.RNPath @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest.Value};
            var ___result = RMMove_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public static System.IDisposable SetCurrentDirectory(Hvak.Editor.Refleaction.RNiceIO.RNPath @directory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directory.Value};
            var ___result = RMSetCurrentDirectory_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IDisposable>(___result);
        }


        public virtual void ThrowIfRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrowIfRoot.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath EnsureDirectoryExists(Hvak.Editor.Refleaction.RNiceIO.RNPath @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@append.Value};
            var ___result = RMEnsureDirectoryExists_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath EnsureParentDirectoryExists()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureParentDirectoryExists.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath FileMustExist()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFileMustExist.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath DirectoryMustExist()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDirectoryMustExist.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.Boolean IsChildOf(Hvak.Editor.Refleaction.RNiceIO.RNPath @potentialBasePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@potentialBasePath.Value};
            var ___result = RMIsChildOf_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsSameAsOrChildOf(Hvak.Editor.Refleaction.RNiceIO.RNPath @potentialBasePath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@potentialBasePath.Value};
            var ___result = RMIsSameAsOrChildOf_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath ParentContaining(Hvak.Editor.Refleaction.RNiceIO.RNPath @needle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needle.Value};
            var ___result = RMParentContaining_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath WriteAllText(System.String @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contents};
            var ___result = RMWriteAllText_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath ReplaceAllText(System.String @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contents};
            var ___result = RMReplaceAllText_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath WriteAllBytes(System.Byte[] @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RMWriteAllBytes_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.String ReadAllText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadAllText.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Byte[] ReadAllBytes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadAllBytes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath WriteAllLines(System.String[] @contents)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contents};
            var ___result = RMWriteAllLines_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.String[] ReadAllLines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadAllLines.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String[]>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RNiceIO.RNPath> CopyFiles(Hvak.Editor.Refleaction.RNiceIO.RNPath @destination, System.Boolean @recurse, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RNiceIO.RNPath, Hvak.Editor.Refleaction.RSystem.RBoolean> @fileFilter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @recurse, @fileFilter.Value};
            var ___result = RMCopyFiles_NPath_Boolean_Func_d_NPath_Boolean_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RNiceIO.RNPath> MoveFiles(Hvak.Editor.Refleaction.RNiceIO.RNPath @destination, System.Boolean @recurse, Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RNiceIO.RNPath, Hvak.Editor.Refleaction.RSystem.RBoolean> @fileFilter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @recurse, @fileFilter.Value};
            var ___result = RMMoveFiles_NPath_Boolean_Func_d_NPath_Boolean_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RNiceIO.RNPath>>(___result);
        }


        public static System.Boolean AlwaysTrue(Hvak.Editor.Refleaction.RNiceIO.RNPath @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMAlwaysTrue_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RNiceIO.RNPath op_Implicit(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMop_Implicit_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath SetLastWriteTimeUtc(System.DateTime @lastWriteTimeUtc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lastWriteTimeUtc};
            var ___result = RMSetLastWriteTimeUtc_DateTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.DateTime GetLastWriteTimeUtc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLastWriteTimeUtc.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.Int64 GetFileSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFileSize.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public static System.IDisposable WithFileSystem(Hvak.Editor.Refleaction.RNiceIO.RNPath.RFileSystem @fileSystem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileSystem.Value};
            var ___result = RMWithFileSystem_FileSystem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IDisposable>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RNiceIO.RNPath ResolveWithFileSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveWithFileSystem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RNiceIO.RNPath>(___result);
        }


        public virtual System.String InQuotesResolved(Hvak.Editor.Refleaction.RNiceIO.RSlashMode @slashMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slashMode.Value};
            var ___result = RMInQuotesResolved_SlashMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.IDisposable WithFrozenCurrentDirectory(Hvak.Editor.Refleaction.RNiceIO.RNPath @frozenCurrentDirectory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frozenCurrentDirectory.Value};
            var ___result = RMWithFrozenCurrentDirectory_NPath.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IDisposable>(___result);
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
