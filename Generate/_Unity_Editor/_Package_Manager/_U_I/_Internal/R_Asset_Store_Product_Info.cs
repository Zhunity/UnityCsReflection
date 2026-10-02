
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo
	/// </summary>
    public partial class RAssetStoreProductInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo");
            }
        }

        public RAssetStoreProductInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo")
        {
        }

        public RAssetStoreProductInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo")
		{
            SetInstance(instance);
		}

        public RAssetStoreProductInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreProductInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
		/// System.String packageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpackageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpackageName
		{
			get
			{
				if(r_FpackageName == null)
				{
					r_FpackageName = new(this, "packageName");
				}
				return r_FpackageName;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fdescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdescription
		{
			get
			{
				if(r_Fdescription == null)
				{
					r_Fdescription = new(this, "description");
				}
				return r_Fdescription;
			}
		}

		/// <summary>
		/// System.String author
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fauthor;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFauthor
		{
			get
			{
				if(r_Fauthor == null)
				{
					r_Fauthor = new(this, "author");
				}
				return r_Fauthor;
			}
		}

		/// <summary>
		/// System.String publisherId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpublisherId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpublisherId
		{
			get
			{
				if(r_FpublisherId == null)
				{
					r_FpublisherId = new(this, "publisherId");
				}
				return r_FpublisherId;
			}
		}

		/// <summary>
		/// System.String category
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fcategory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcategory
		{
			get
			{
				if(r_Fcategory == null)
				{
					r_Fcategory = new(this, "category");
				}
				return r_Fcategory;
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
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdisplayName
		{
			get
			{
				if(r_FdisplayName == null)
				{
					r_FdisplayName = new(this, "displayName");
				}
				return r_FdisplayName;
			}
		}

		/// <summary>
		/// System.String state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fstate;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFstate
		{
			get
			{
				if(r_Fstate == null)
				{
					r_Fstate = new(this, "state");
				}
				return r_Fstate;
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
		/// UnityEditor.PackageManager.UI.Internal.PackageLink assetStoreLink
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink r_FassetStoreLink;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink RFassetStoreLink
		{
			get
			{
				if(r_FassetStoreLink == null)
				{
					r_FassetStoreLink = new(this, "assetStoreLink");
				}
				return r_FassetStoreLink;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] supportedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_FsupportedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFsupportedVersions
		{
			get
			{
				if(r_FsupportedVersions == null)
				{
					r_FsupportedVersions = new(this, "supportedVersions");
				}
				return r_FsupportedVersions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageImage] images
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageImage> r_Fimages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageImage> RFimages
		{
			get
			{
				if(r_Fimages == null)
				{
					r_Fimages = new(this, "images");
				}
				return r_Fimages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageLink] links
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink> r_Flinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink> RFlinks
		{
			get
			{
				if(r_Flinks == null)
				{
					r_Flinks = new(this, "links");
				}
				return r_Flinks;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageSizeInfo] sizeInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> r_FsizeInfos;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> RFsizeInfos
		{
			get
			{
				if(r_FsizeInfos == null)
				{
					r_FsizeInfos = new(this, "sizeInfos");
				}
				return r_FsizeInfos;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUtils m_AssetStoreUtils
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils r_Fm_AssetStoreUtils;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils RFm_AssetStoreUtils
		{
			get
			{
				if(r_Fm_AssetStoreUtils == null)
				{
					r_Fm_AssetStoreUtils = new(this, "m_AssetStoreUtils");
				}
				return r_Fm_AssetStoreUtils;
			}
		}

		/// <summary>
		/// Void ResolveDependencies(UnityEditor.PackageManager.UI.Internal.AssetStoreUtils)
		/// </summary>
		protected RMethod r_MResolveDependencies_AssetStoreUtils;
		public virtual RMethod RMResolveDependencies_AssetStoreUtils
		{
			get
			{
				if(r_MResolveDependencies_AssetStoreUtils == null)
				{
					r_MResolveDependencies_AssetStoreUtils = new(this, "ResolveDependencies", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"));
				}
				return r_MResolveDependencies_AssetStoreUtils;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreProductInfo ParseProductInfo(UnityEditor.PackageManager.UI.Internal.AssetStoreUtils, System.String, System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected static RMethod r_MParseProductInfo_AssetStoreUtils_String_IDictionary_d_String_Object_p_;
		public static RMethod RMParseProductInfo_AssetStoreUtils_String_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MParseProductInfo_AssetStoreUtils_String_IDictionary_d_String_Object_p_ == null)
				{
					r_MParseProductInfo_AssetStoreUtils_String_IDictionary_d_String_Object_p_ = new(Type, "ParseProductInfo", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreUtils"), typeof(System.String),  ReflectionUtils.GetType("System.Collections.Generic.IDictionary`2").MakeGenericType(typeof(System.String), typeof(System.Object)));
				}
				return r_MParseProductInfo_AssetStoreUtils_String_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// System.String CleanUpHtml(System.String)
		/// </summary>
		protected static RMethod r_MCleanUpHtml_String;
		public static RMethod RMCleanUpHtml_String
		{
			get
			{
				if(r_MCleanUpHtml_String == null)
				{
					r_MCleanUpHtml_String = new(Type, "CleanUpHtml", 0, typeof(System.String));
				}
				return r_MCleanUpHtml_String;
			}
		}

		/// <summary>
		/// System.String PrependProtocolIfNotPresent(System.String)
		/// </summary>
		protected RMethod r_MPrependProtocolIfNotPresent_String;
		public virtual RMethod RMPrependProtocolIfNotPresent_String
		{
			get
			{
				if(r_MPrependProtocolIfNotPresent_String == null)
				{
					r_MPrependProtocolIfNotPresent_String = new(this, "PrependProtocolIfNotPresent", 0, typeof(System.String));
				}
				return r_MPrependProtocolIfNotPresent_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageImage] GetImagesFromProductDetails(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_MGetImagesFromProductDetails_IDictionary_d_String_Object_p_;
		public virtual RMethod RMGetImagesFromProductDetails_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MGetImagesFromProductDetails_IDictionary_d_String_Object_p_ == null)
				{
					r_MGetImagesFromProductDetails_IDictionary_d_String_Object_p_ = new(this, "GetImagesFromProductDetails", 0,  ReflectionUtils.GetType("System.Collections.Generic.IDictionary`2").MakeGenericType(typeof(System.String), typeof(System.Object)));
				}
				return r_MGetImagesFromProductDetails_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageLink] GetLinksFromProductDetails(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_MGetLinksFromProductDetails_IDictionary_d_String_Object_p_;
		public virtual RMethod RMGetLinksFromProductDetails_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MGetLinksFromProductDetails_IDictionary_d_String_Object_p_ == null)
				{
					r_MGetLinksFromProductDetails_IDictionary_d_String_Object_p_ = new(this, "GetLinksFromProductDetails", 0,  ReflectionUtils.GetType("System.Collections.Generic.IDictionary`2").MakeGenericType(typeof(System.String), typeof(System.Object)));
				}
				return r_MGetLinksFromProductDetails_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageLink GetAssetStoreLinkFromProductDetails(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_MGetAssetStoreLinkFromProductDetails_IDictionary_d_String_Object_p_;
		public virtual RMethod RMGetAssetStoreLinkFromProductDetails_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MGetAssetStoreLinkFromProductDetails_IDictionary_d_String_Object_p_ == null)
				{
					r_MGetAssetStoreLinkFromProductDetails_IDictionary_d_String_Object_p_ = new(this, "GetAssetStoreLinkFromProductDetails", 0,  ReflectionUtils.GetType("System.Collections.Generic.IDictionary`2").MakeGenericType(typeof(System.String), typeof(System.Object)));
				}
				return r_MGetAssetStoreLinkFromProductDetails_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.PackageSizeInfo] GetSizeInfoFromProductDetails(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_MGetSizeInfoFromProductDetails_IDictionary_d_String_Object_p_;
		public virtual RMethod RMGetSizeInfoFromProductDetails_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MGetSizeInfoFromProductDetails_IDictionary_d_String_Object_p_ == null)
				{
					r_MGetSizeInfoFromProductDetails_IDictionary_d_String_Object_p_ = new(this, "GetSizeInfoFromProductDetails", 0,  ReflectionUtils.GetType("System.Collections.Generic.IDictionary`2").MakeGenericType(typeof(System.String), typeof(System.Object)));
				}
				return r_MGetSizeInfoFromProductDetails_IDictionary_d_String_Object_p_;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageLink GetPackageLink(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_MGetPackageLink_String_String_String;
		public virtual RMethod RMGetPackageLink_String_String_String
		{
			get
			{
				if(r_MGetPackageLink_String_String_String == null)
				{
					r_MGetPackageLink_String_String_String = new(this, "GetPackageLink", 0, typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MGetPackageLink_String_String_String;
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


		public virtual void ResolveDependencies(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@assetStoreUtils.Value};
			var ___result = RMResolveDependencies_AssetStoreUtils.Invoke(___genericsType, ___parameters);
		}


		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo ParseProductInfo(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUtils @assetStoreUtils, System.String @productId, System.Collections.Generic.IDictionary<System.String, System.Object> @productDetail)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@assetStoreUtils.Value, @productId, @productDetail};
			var ___result = RMParseProductInfo_AssetStoreUtils_String_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreProductInfo>(___result);
		}


		public static System.String CleanUpHtml(System.String @source)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@source};
			var ___result = RMCleanUpHtml_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


		public virtual System.String PrependProtocolIfNotPresent(System.String @url)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@url};
			var ___result = RMPrependProtocolIfNotPresent_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageImage> GetImagesFromProductDetails(System.Collections.Generic.IDictionary<System.String, System.Object> @productDetail)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@productDetail};
			var ___result = RMGetImagesFromProductDetails_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageImage>>(___result);
		}


		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink> GetLinksFromProductDetails(System.Collections.Generic.IDictionary<System.String, System.Object> @productDetail)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@productDetail};
			var ___result = RMGetLinksFromProductDetails_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink>>(___result);
		}


		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink GetAssetStoreLinkFromProductDetails(System.Collections.Generic.IDictionary<System.String, System.Object> @productDetail)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@productDetail};
			var ___result = RMGetAssetStoreLinkFromProductDetails_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink>(___result);
		}


		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo> GetSizeInfoFromProductDetails(System.Collections.Generic.IDictionary<System.String, System.Object> @productDetail)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@productDetail};
			var ___result = RMGetSizeInfoFromProductDetails_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageSizeInfo>>(___result);
		}


		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink GetPackageLink(System.String @name, System.String @url, System.String @analyticsEventName)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@name, @url, @analyticsEventName};
			var ___result = RMGetPackageLink_String_String_String.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink>(___result);
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


		public virtual System.String ToString()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMToString.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.String>(___result);
		}


    }
}
