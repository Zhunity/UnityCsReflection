
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PlaceholderPackage
	/// </summary>
    public partial class RPlaceholderPackage : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PlaceholderPackage");
            }
        }

        public RPlaceholderPackage() : base("UnityEditor.PackageManager.UI.Internal.PlaceholderPackage")
        {
        }

        public RPlaceholderPackage(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PlaceholderPackage")
		{
            SetInstance(instance);
		}

        public RPlaceholderPackage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPlaceholderPackage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_UniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_UniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_UniqueId
		{
			get
			{
				if(r_Fm_UniqueId == null)
				{
					r_Fm_UniqueId = new(this, "m_UniqueId");
				}
				return r_Fm_UniqueId;
			}
		}

		/// <summary>
		/// System.String m_ProductId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProductId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProductId
		{
			get
			{
				if(r_Fm_ProductId == null)
				{
					r_Fm_ProductId = new(this, "m_ProductId");
				}
				return r_Fm_ProductId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PlaceholderVersionList m_VersionList
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPlaceholderVersionList r_Fm_VersionList;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPlaceholderVersionList RFm_VersionList
		{
			get
			{
				if(r_Fm_VersionList == null)
				{
					r_Fm_VersionList = new(this, "m_VersionList");
				}
				return r_Fm_VersionList;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.String m_ProductDisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProductDisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProductDisplayName
		{
			get
			{
				if(r_Fm_ProductDisplayName == null)
				{
					r_Fm_ProductDisplayName = new(this, "m_ProductDisplayName");
				}
				return r_Fm_ProductDisplayName;
			}
		}

		/// <summary>
		/// System.String m_PublisherName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PublisherName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PublisherName
		{
			get
			{
				if(r_Fm_PublisherName == null)
				{
					r_Fm_PublisherName = new(this, "m_PublisherName");
				}
				return r_Fm_PublisherName;
			}
		}

		/// <summary>
		/// System.String m_PublisherLink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PublisherLink;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PublisherLink
		{
			get
			{
				if(r_Fm_PublisherLink == null)
				{
					r_Fm_PublisherLink = new(this, "m_PublisherLink");
				}
				return r_Fm_PublisherLink;
			}
		}

		/// <summary>
		/// System.String m_ProductDescription
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ProductDescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ProductDescription
		{
			get
			{
				if(r_Fm_ProductDescription == null)
				{
					r_Fm_ProductDescription = new(this, "m_ProductDescription");
				}
				return r_Fm_ProductDescription;
			}
		}

		/// <summary>
		/// System.String m_PublishNotes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PublishNotes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PublishNotes
		{
			get
			{
				if(r_Fm_PublishNotes == null)
				{
					r_Fm_PublishNotes = new(this, "m_PublishNotes");
				}
				return r_Fm_PublishNotes;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageProgress m_Progress
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageProgress r_Fm_Progress;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageProgress RFm_Progress
		{
			get
			{
				if(r_Fm_Progress == null)
				{
					r_Fm_Progress = new(this, "m_Progress");
				}
				return r_Fm_Progress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.UIError] m_Errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Fm_Errors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RFm_Errors
		{
			get
			{
				if(r_Fm_Errors == null)
				{
					r_Fm_Errors = new(this, "m_Errors");
				}
				return r_Fm_Errors;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageType m_Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageType r_Fm_Type;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageType RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
				}
				return r_Fm_Type;
			}
		}

		/// <summary>
		/// System.Int64 m_FirstPublishedDateTicks
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_FirstPublishedDateTicks;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_FirstPublishedDateTicks
		{
			get
			{
				if(r_Fm_FirstPublishedDateTicks == null)
				{
					r_Fm_FirstPublishedDateTicks = new(this, "m_FirstPublishedDateTicks");
				}
				return r_Fm_FirstPublishedDateTicks;
			}
		}

		/// <summary>
		/// System.String uniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PuniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPuniqueId
		{
			get
			{
				if(r_PuniqueId == null)
				{
					r_PuniqueId = new(this, "uniqueId", -1);
				}
				return r_PuniqueId;
			}
		}

		/// <summary>
		/// System.String productId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PproductId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPproductId
		{
			get
			{
				if(r_PproductId == null)
				{
					r_PproductId = new(this, "productId", -1);
				}
				return r_PproductId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IVersionList versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIVersionList r_Pversions;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIVersionList RPversions
		{
			get
			{
				if(r_Pversions == null)
				{
					r_Pversions = new(this, "versions", -1);
				}
				return r_Pversions;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String publisherName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpublisherName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpublisherName
		{
			get
			{
				if(r_PpublisherName == null)
				{
					r_PpublisherName = new(this, "publisherName", -1);
				}
				return r_PpublisherName;
			}
		}

		/// <summary>
		/// System.String publisherLink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpublisherLink;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpublisherLink
		{
			get
			{
				if(r_PpublisherLink == null)
				{
					r_PpublisherLink = new(this, "publisherLink", -1);
				}
				return r_PpublisherLink;
			}
		}

		/// <summary>
		/// System.String productDescription
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PproductDescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPproductDescription
		{
			get
			{
				if(r_PproductDescription == null)
				{
					r_PproductDescription = new(this, "productDescription", -1);
				}
				return r_PproductDescription;
			}
		}

		/// <summary>
		/// System.String latestReleaseNotes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlatestReleaseNotes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlatestReleaseNotes
		{
			get
			{
				if(r_PlatestReleaseNotes == null)
				{
					r_PlatestReleaseNotes = new(this, "latestReleaseNotes", -1);
				}
				return r_PlatestReleaseNotes;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageState state
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageState r_Pstate;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageState RPstate
		{
			get
			{
				if(r_Pstate == null)
				{
					r_Pstate = new(this, "state", -1);
				}
				return r_Pstate;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageProgress progress
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageProgress r_Pprogress;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageProgress RPprogress
		{
			get
			{
				if(r_Pprogress == null)
				{
					r_Pprogress = new(this, "progress", -1);
				}
				return r_Pprogress;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.UIError] errors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> r_Perrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> RPerrors
		{
			get
			{
				if(r_Perrors == null)
				{
					r_Perrors = new(this, "errors", -1);
				}
				return r_Perrors;
			}
		}

		/// <summary>
		/// Boolean hasEntitlements
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasEntitlements;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasEntitlements
		{
			get
			{
				if(r_PhasEntitlements == null)
				{
					r_PhasEntitlements = new(this, "hasEntitlements", -1);
				}
				return r_PhasEntitlements;
			}
		}

		/// <summary>
		/// Boolean hasEntitlementsError
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasEntitlementsError;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasEntitlementsError
		{
			get
			{
				if(r_PhasEntitlementsError == null)
				{
					r_PhasEntitlementsError = new(this, "hasEntitlementsError", -1);
				}
				return r_PhasEntitlementsError;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.DateTime] firstPublishedDate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> r_PfirstPublishedDate;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> RPfirstPublishedDate
		{
			get
			{
				if(r_PfirstPublishedDate == null)
				{
					r_PfirstPublishedDate = new(this, "firstPublishedDate", -1);
				}
				return r_PfirstPublishedDate;
			}
		}

		/// <summary>
		/// Boolean isDiscoverable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDiscoverable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDiscoverable
		{
			get
			{
				if(r_PisDiscoverable == null)
				{
					r_PisDiscoverable = new(this, "isDiscoverable", -1);
				}
				return r_PisDiscoverable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageImage] images
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageImage> r_Pimages;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageImage> RPimages
		{
			get
			{
				if(r_Pimages == null)
				{
					r_Pimages = new(this, "images", -1);
				}
				return r_Pimages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.PackageLink] links
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink> r_Plinks;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageLink> RPlinks
		{
			get
			{
				if(r_Plinks == null)
				{
					r_Plinks = new(this, "links", -1);
				}
				return r_Plinks;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.DateTime] purchasedTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> r_PpurchasedTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RDateTime> RPpurchasedTime
		{
			get
			{
				if(r_PpurchasedTime == null)
				{
					r_PpurchasedTime = new(this, "purchasedTime", -1);
				}
				return r_PpurchasedTime;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] labels
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> r_Plabels;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RString> RPlabels
		{
			get
			{
				if(r_Plabels == null)
				{
					r_Plabels = new(this, "labels", -1);
				}
				return r_Plabels;
			}
		}

		/// <summary>
		/// System.String descriptor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pdescriptor;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdescriptor
		{
			get
			{
				if(r_Pdescriptor == null)
				{
					r_Pdescriptor = new(this, "descriptor", -1);
				}
				return r_Pdescriptor;
			}
		}

		/// <summary>
		/// Void AddError(UnityEditor.PackageManager.UI.Internal.UIError)
		/// </summary>
		protected RMethod r_MAddError_UIError;
		public virtual RMethod RMAddError_UIError
		{
			get
			{
				if(r_MAddError_UIError == null)
				{
					r_MAddError_UIError = new(this, "AddError", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError"));
				}
				return r_MAddError_UIError;
			}
		}

		/// <summary>
		/// Void ClearErrors(System.Predicate`1[UnityEditor.PackageManager.UI.Internal.UIError])
		/// </summary>
		protected RMethod r_MClearErrors_Predicate_d_UIError_p_;
		public virtual RMethod RMClearErrors_Predicate_d_UIError_p_
		{
			get
			{
				if(r_MClearErrors_Predicate_d_UIError_p_ == null)
				{
					r_MClearErrors_Predicate_d_UIError_p_ = new(this, "ClearErrors", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
				}
				return r_MClearErrors_Predicate_d_UIError_p_;
			}
		}

		/// <summary>
		/// Boolean Is(UnityEditor.PackageManager.UI.Internal.PackageType)
		/// </summary>
		protected RMethod r_MIs_PackageType;
		public virtual RMethod RMIs_PackageType
		{
			get
			{
				if(r_MIs_PackageType == null)
				{
					r_MIs_PackageType = new(this, "Is", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageType"));
				}
				return r_MIs_PackageType;
			}
		}

		/// <summary>
		/// System.String GetDescriptor(Boolean)
		/// </summary>
		protected RMethod r_MGetDescriptor_Boolean;
		public virtual RMethod RMGetDescriptor_Boolean
		{
			get
			{
				if(r_MGetDescriptor_Boolean == null)
				{
					r_MGetDescriptor_Boolean = new(this, "GetDescriptor", 0, typeof(System.Boolean));
				}
				return r_MGetDescriptor_Boolean;
			}
		}

		/// <summary>
		/// Void LinkPackageAndVersions()
		/// </summary>
		protected RMethod r_MLinkPackageAndVersions;
		public virtual RMethod RMLinkPackageAndVersions
		{
			get
			{
				if(r_MLinkPackageAndVersions == null)
				{
					r_MLinkPackageAndVersions = new(this, "LinkPackageAndVersions", 0);
				}
				return r_MLinkPackageAndVersions;
			}
		}

		/// <summary>
		/// Void RefreshPackageTypeFromVersions()
		/// </summary>
		protected RMethod r_MRefreshPackageTypeFromVersions;
		public virtual RMethod RMRefreshPackageTypeFromVersions
		{
			get
			{
				if(r_MRefreshPackageTypeFromVersions == null)
				{
					r_MRefreshPackageTypeFromVersions = new(this, "RefreshPackageTypeFromVersions", 0);
				}
				return r_MRefreshPackageTypeFromVersions;
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


        public virtual void AddError(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error.Value};
            var ___result = RMAddError_UIError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearErrors(Hvak.Editor.Refleaction.RSystem.RPredicate<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUIError> @match)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@match.Value};
            var ___result = RMClearErrors_Predicate_d_UIError_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Is(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIs_PackageType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String GetDescriptor(System.Boolean @isFirstLetterCapitalized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isFirstLetterCapitalized};
            var ___result = RMGetDescriptor_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void LinkPackageAndVersions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLinkPackageAndVersions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RefreshPackageTypeFromVersions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefreshPackageTypeFromVersions.Invoke(___genericsType, ___parameters);

            
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
