
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.IO.FileAttributes
	/// </summary>
    public partial class RFileAttributes : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.IO.FileAttributes);
            }
        }

        public RFileAttributes() : base("System.IO.FileAttributes")
        {
        }

        public RFileAttributes(System.Object instance) : base("System.IO.FileAttributes")
		{
            SetInstance(instance);
		}

        public RFileAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFileAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes ReadOnly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FReadOnly;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFReadOnly
		{
			get
			{
				if(r_FReadOnly == null)
				{
					r_FReadOnly = new(Type, "ReadOnly");
				}
				return r_FReadOnly;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Hidden
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FHidden;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFHidden
		{
			get
			{
				if(r_FHidden == null)
				{
					r_FHidden = new(Type, "Hidden");
				}
				return r_FHidden;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes System
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FSystem;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFSystem
		{
			get
			{
				if(r_FSystem == null)
				{
					r_FSystem = new(Type, "System");
				}
				return r_FSystem;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Directory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FDirectory;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFDirectory
		{
			get
			{
				if(r_FDirectory == null)
				{
					r_FDirectory = new(Type, "Directory");
				}
				return r_FDirectory;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Archive
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FArchive;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFArchive
		{
			get
			{
				if(r_FArchive == null)
				{
					r_FArchive = new(Type, "Archive");
				}
				return r_FArchive;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Device
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FDevice;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFDevice
		{
			get
			{
				if(r_FDevice == null)
				{
					r_FDevice = new(Type, "Device");
				}
				return r_FDevice;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Normal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FNormal;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFNormal
		{
			get
			{
				if(r_FNormal == null)
				{
					r_FNormal = new(Type, "Normal");
				}
				return r_FNormal;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Temporary
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FTemporary;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFTemporary
		{
			get
			{
				if(r_FTemporary == null)
				{
					r_FTemporary = new(Type, "Temporary");
				}
				return r_FTemporary;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes SparseFile
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FSparseFile;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFSparseFile
		{
			get
			{
				if(r_FSparseFile == null)
				{
					r_FSparseFile = new(Type, "SparseFile");
				}
				return r_FSparseFile;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes ReparsePoint
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FReparsePoint;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFReparsePoint
		{
			get
			{
				if(r_FReparsePoint == null)
				{
					r_FReparsePoint = new(Type, "ReparsePoint");
				}
				return r_FReparsePoint;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Compressed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FCompressed;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFCompressed
		{
			get
			{
				if(r_FCompressed == null)
				{
					r_FCompressed = new(Type, "Compressed");
				}
				return r_FCompressed;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Offline
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FOffline;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFOffline
		{
			get
			{
				if(r_FOffline == null)
				{
					r_FOffline = new(Type, "Offline");
				}
				return r_FOffline;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes NotContentIndexed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FNotContentIndexed;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFNotContentIndexed
		{
			get
			{
				if(r_FNotContentIndexed == null)
				{
					r_FNotContentIndexed = new(Type, "NotContentIndexed");
				}
				return r_FNotContentIndexed;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes Encrypted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FEncrypted;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFEncrypted
		{
			get
			{
				if(r_FEncrypted == null)
				{
					r_FEncrypted = new(Type, "Encrypted");
				}
				return r_FEncrypted;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes IntegrityStream
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FIntegrityStream;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFIntegrityStream
		{
			get
			{
				if(r_FIntegrityStream == null)
				{
					r_FIntegrityStream = new(Type, "IntegrityStream");
				}
				return r_FIntegrityStream;
			}
		}

		/// <summary>
		/// System.IO.FileAttributes NoScrubData
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes r_FNoScrubData;
		public static Hvak.Editor.Refleaction.RSystem.RIO.RFileAttributes RFNoScrubData
		{
			get
			{
				if(r_FNoScrubData == null)
				{
					r_FNoScrubData = new(Type, "NoScrubData");
				}
				return r_FNoScrubData;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
