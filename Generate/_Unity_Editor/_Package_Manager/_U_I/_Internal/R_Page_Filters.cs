
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PageFilters
	/// </summary>
    public partial class RPageFilters : RMember //
    {

		/// <summary>
		/// System.String k_UnlabeledStatus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UnlabeledStatus;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UnlabeledStatus
		{
			get
			{
				if(r_Fk_UnlabeledStatus == null)
				{
					r_Fk_UnlabeledStatus = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"), "k_UnlabeledStatus");
					r_Fk_UnlabeledStatus.SetBelong(null);
				}
				return r_Fk_UnlabeledStatus;
			}
		}

		/// <summary>
		/// System.String k_DownloadedStatus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_DownloadedStatus;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_DownloadedStatus
		{
			get
			{
				if(r_Fk_DownloadedStatus == null)
				{
					r_Fk_DownloadedStatus = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"), "k_DownloadedStatus");
					r_Fk_DownloadedStatus.SetBelong(null);
				}
				return r_Fk_DownloadedStatus;
			}
		}

		/// <summary>
		/// System.String k_UpdateAvailableStatus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_UpdateAvailableStatus;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_UpdateAvailableStatus
		{
			get
			{
				if(r_Fk_UpdateAvailableStatus == null)
				{
					r_Fk_UpdateAvailableStatus = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"), "k_UpdateAvailableStatus");
					r_Fk_UpdateAvailableStatus.SetBelong(null);
				}
				return r_Fk_UpdateAvailableStatus;
			}
		}

		/// <summary>
		/// System.String k_SubscriptionBasedStatus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_SubscriptionBasedStatus;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_SubscriptionBasedStatus
		{
			get
			{
				if(r_Fk_SubscriptionBasedStatus == null)
				{
					r_Fk_SubscriptionBasedStatus = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"), "k_SubscriptionBasedStatus");
					r_Fk_SubscriptionBasedStatus.SetBelong(null);
				}
				return r_Fk_SubscriptionBasedStatus;
			}
		}

		/// <summary>
		/// System.String m_SearchText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_SearchText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_SearchText
		{
			get
			{
				if(r_Fm_SearchText == null)
				{
					r_Fm_SearchText = new(this, "m_SearchText");
					r_Fm_SearchText.SetBelong(this.GetValue());
				}
				return r_Fm_SearchText;
			}
		}

		/// <summary>
		/// System.String m_Status
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Status;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Status
		{
			get
			{
				if(r_Fm_Status == null)
				{
					r_Fm_Status = new(this, "m_Status");
					r_Fm_Status.SetBelong(this.GetValue());
				}
				return r_Fm_Status;
			}
		}

		/// <summary>
		/// System.String m_OrderBy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_OrderBy;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_OrderBy
		{
			get
			{
				if(r_Fm_OrderBy == null)
				{
					r_Fm_OrderBy = new(this, "m_OrderBy");
					r_Fm_OrderBy.SetBelong(this.GetValue());
				}
				return r_Fm_OrderBy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Categories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Categories;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_Categories
		{
			get
			{
				if(r_Fm_Categories == null)
				{
					r_Fm_Categories = new(this, "m_Categories");
					r_Fm_Categories.SetBelong(this.GetValue());
				}
				return r_Fm_Categories;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Labels
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Labels;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_Labels
		{
			get
			{
				if(r_Fm_Labels == null)
				{
					r_Fm_Labels = new(this, "m_Labels");
					r_Fm_Labels.SetBelong(this.GetValue());
				}
				return r_Fm_Labels;
			}
		}

		/// <summary>
		/// System.Boolean isReverseOrder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisReverseOrder;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisReverseOrder
		{
			get
			{
				if(r_FisReverseOrder == null)
				{
					r_FisReverseOrder = new(this, "isReverseOrder");
					r_FisReverseOrder.SetBelong(this.GetValue());
				}
				return r_FisReverseOrder;
			}
		}

		/// <summary>
		/// System.String searchText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PsearchText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsearchText
		{
			get
			{
				if(r_PsearchText == null)
				{
					r_PsearchText = new(this, "searchText", -1);
					r_PsearchText.SetBelong(this.GetValue());
				}
				return r_PsearchText;
			}
		}

		/// <summary>
		/// System.String status
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pstatus;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPstatus
		{
			get
			{
				if(r_Pstatus == null)
				{
					r_Pstatus = new(this, "status", -1);
					r_Pstatus.SetBelong(this.GetValue());
				}
				return r_Pstatus;
			}
		}

		/// <summary>
		/// Boolean downloadedOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdownloadedOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdownloadedOnly
		{
			get
			{
				if(r_PdownloadedOnly == null)
				{
					r_PdownloadedOnly = new(this, "downloadedOnly", -1);
					r_PdownloadedOnly.SetBelong(this.GetValue());
				}
				return r_PdownloadedOnly;
			}
		}

		/// <summary>
		/// Boolean updateAvailableOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PupdateAvailableOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPupdateAvailableOnly
		{
			get
			{
				if(r_PupdateAvailableOnly == null)
				{
					r_PupdateAvailableOnly = new(this, "updateAvailableOnly", -1);
					r_PupdateAvailableOnly.SetBelong(this.GetValue());
				}
				return r_PupdateAvailableOnly;
			}
		}

		/// <summary>
		/// Boolean subscriptionBasedOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PsubscriptionBasedOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsubscriptionBasedOnly
		{
			get
			{
				if(r_PsubscriptionBasedOnly == null)
				{
					r_PsubscriptionBasedOnly = new(this, "subscriptionBasedOnly", -1);
					r_PsubscriptionBasedOnly.SetBelong(this.GetValue());
				}
				return r_PsubscriptionBasedOnly;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] categories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Pcategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPcategories
		{
			get
			{
				if(r_Pcategories == null)
				{
					r_Pcategories = new(this, "categories", -1);
					r_Pcategories.SetBelong(this.GetValue());
				}
				return r_Pcategories;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] labels
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Plabels;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPlabels
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
		/// System.String orderBy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PorderBy;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPorderBy
		{
			get
			{
				if(r_PorderBy == null)
				{
					r_PorderBy = new(this, "orderBy", -1);
					r_PorderBy.SetBelong(this.GetValue());
				}
				return r_PorderBy;
			}
		}

		/// <summary>
		/// Boolean isFilterSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisFilterSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisFilterSet
		{
			get
			{
				if(r_PisFilterSet == null)
				{
					r_PisFilterSet = new(this, "isFilterSet", -1);
					r_PisFilterSet.SetBelong(this.GetValue());
				}
				return r_PisFilterSet;
			}
		}

		/// <summary>
		/// Boolean isOrderSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisOrderSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisOrderSet
		{
			get
			{
				if(r_PisOrderSet == null)
				{
					r_PisOrderSet = new(this, "isOrderSet", -1);
					r_PisOrderSet.SetBelong(this.GetValue());
				}
				return r_PisOrderSet;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageFilters Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.GetValue());
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEditor.PackageManager.UI.Internal.PageFilters)
		/// </summary>
		protected RMethod r_MEquals_PageFilters;
		public virtual RMethod RMEquals_PageFilters
		{
			get
			{
				if(r_MEquals_PageFilters == null)
				{
					r_MEquals_PageFilters = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters"));
					r_MEquals_PageFilters.SetBelong(this.GetValue());
				}
				return r_MEquals_PageFilters;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RPageFilters() : base("UnityEditor.PackageManager.UI.Internal.PageFilters")
        {
        }

        public RPageFilters(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PageFilters")
		{
            SetInstance(instance);
		}

        public RPageFilters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPageFilters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_PageFilters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
