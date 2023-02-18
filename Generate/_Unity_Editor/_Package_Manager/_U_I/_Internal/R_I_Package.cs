
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IPackage
	/// </summary>
    public partial class RIPackage : RMember //
    {

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
					r_PproductId.SetBelong(this.GetValue());
				}
				return r_PproductId;
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
					r_PdisplayName.SetBelong(this.GetValue());
				}
				return r_PdisplayName;
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
					r_PproductDescription.SetBelong(this.GetValue());
				}
				return r_PproductDescription;
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
					r_PpublisherName.SetBelong(this.GetValue());
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
					r_PpublisherLink.SetBelong(this.GetValue());
				}
				return r_PpublisherLink;
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
					r_PlatestReleaseNotes.SetBelong(this.GetValue());
				}
				return r_PlatestReleaseNotes;
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
					r_PpurchasedTime.SetBelong(this.GetValue());
				}
				return r_PpurchasedTime;
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
					r_Pversions.SetBelong(this.GetValue());
				}
				return r_Pversions;
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
					r_Pstate.SetBelong(this.GetValue());
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
					r_Pprogress.SetBelong(this.GetValue());
				}
				return r_Pprogress;
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
					r_Plabels.SetBelong(this.GetValue());
				}
				return r_Plabels;
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
					r_Pimages.SetBelong(this.GetValue());
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
					r_Plinks.SetBelong(this.GetValue());
				}
				return r_Plinks;
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
					r_PisDiscoverable.SetBelong(this.GetValue());
				}
				return r_PisDiscoverable;
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
					r_Perrors.SetBelong(this.GetValue());
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
					r_PhasEntitlements.SetBelong(this.GetValue());
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
					r_PhasEntitlementsError.SetBelong(this.GetValue());
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
					r_PfirstPublishedDate.SetBelong(this.GetValue());
				}
				return r_PfirstPublishedDate;
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
					r_MIs_PackageType.SetBelong(this.GetValue());
				}
				return r_MIs_PackageType;
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
					r_MAddError_UIError.SetBelong(this.GetValue());
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
					r_MClearErrors_Predicate_d_UIError_p_ = new(this, "ClearErrors", 0, typeof(System.Predicate<>).MakeGenericType( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UIError")));
					r_MClearErrors_Predicate_d_UIError_p_.SetBelong(this.GetValue());
				}
				return r_MClearErrors_Predicate_d_UIError_p_;
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
					r_MGetDescriptor_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetDescriptor_Boolean;
			}
		}


        public RIPackage() : base("UnityEditor.PackageManager.UI.Internal.IPackage")
        {
        }

        public RIPackage(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IPackage")
		{
            SetInstance(instance);
		}

        public RIPackage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPackage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Is(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value};
            var ___result = RMIs_PackageType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String GetDescriptor(System.Boolean @isFirstLetterCapitalized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isFirstLetterCapitalized};
            var ___result = RMGetDescriptor_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
