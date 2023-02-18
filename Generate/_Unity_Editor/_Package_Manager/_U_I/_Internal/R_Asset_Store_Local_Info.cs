
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo
	/// </summary>
    public partial class RAssetStoreLocalInfo : RMember //
    {

		/// <summary>
		/// System.String id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// System.String versionString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FversionString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFversionString
		{
			get
			{
				if(r_FversionString == null)
				{
					r_FversionString = new(this, "versionString");
				}
				return r_FversionString;
			}
		}

		/// <summary>
		/// System.String versionId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FversionId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFversionId
		{
			get
			{
				if(r_FversionId == null)
				{
					r_FversionId = new(this, "versionId");
				}
				return r_FversionId;
			}
		}

		/// <summary>
		/// System.String uploadId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FuploadId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFuploadId
		{
			get
			{
				if(r_FuploadId == null)
				{
					r_FuploadId = new(this, "uploadId");
				}
				return r_FuploadId;
			}
		}

		/// <summary>
		/// System.String publishedDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpublishedDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpublishedDate
		{
			get
			{
				if(r_FpublishedDate == null)
				{
					r_FpublishedDate = new(this, "publishedDate");
				}
				return r_FpublishedDate;
			}
		}

		/// <summary>
		/// System.String supportedVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FsupportedVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsupportedVersion
		{
			get
			{
				if(r_FsupportedVersion == null)
				{
					r_FsupportedVersion = new(this, "supportedVersion");
				}
				return r_FsupportedVersion;
			}
		}

		/// <summary>
		/// System.String packagePath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpackagePath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpackagePath
		{
			get
			{
				if(r_FpackagePath == null)
				{
					r_FpackagePath = new(this, "packagePath");
				}
				return r_FpackagePath;
			}
		}

		/// <summary>
		/// System.String publishNotes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpublishNotes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpublishNotes
		{
			get
			{
				if(r_FpublishNotes == null)
				{
					r_FpublishNotes = new(this, "publishNotes");
				}
				return r_FpublishNotes;
			}
		}

		/// <summary>
		/// System.String firstPublishedDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FfirstPublishedDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFfirstPublishedDate
		{
			get
			{
				if(r_FfirstPublishedDate == null)
				{
					r_FfirstPublishedDate = new(this, "firstPublishedDate");
				}
				return r_FfirstPublishedDate;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo ParseLocalInfo(UnityEditor.PackageInfo)
		/// </summary>
		protected static RMethod r_MParseLocalInfo_PackageInfo;
		public static RMethod RMParseLocalInfo_PackageInfo
		{
			get
			{
				if(r_MParseLocalInfo_PackageInfo == null)
				{
					r_MParseLocalInfo_PackageInfo = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo"), "ParseLocalInfo", 0, typeof(UnityEditor.PackageInfo));
				}
				return r_MParseLocalInfo_PackageInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] ToDictionary()
		/// </summary>
		protected RMethod r_MToDictionary;
		public virtual RMethod RMToDictionary
		{
			get
			{
				if(r_MToDictionary == null)
				{
					r_MToDictionary = new(this, "ToDictionary", 0);
				}
				return r_MToDictionary;
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


        public RAssetStoreLocalInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")
        {
        }

        public RAssetStoreLocalInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreLocalInfo")
		{
            SetInstance(instance);
		}

        public RAssetStoreLocalInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreLocalInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo ParseLocalInfo(UnityEditor.PackageInfo @localInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localInfo};
            var ___result = RMParseLocalInfo_PackageInfo.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreLocalInfo(___result);
        }


        public virtual System.Collections.Generic.Dictionary<System.String, System.String> ToDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToDictionary.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, System.String>)___result;
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
