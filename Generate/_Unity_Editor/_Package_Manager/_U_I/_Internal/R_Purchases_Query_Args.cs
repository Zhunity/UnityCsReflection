
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs
	/// </summary>
    public partial class RPurchasesQueryArgs : RMember //
    {

		/// <summary>
		/// System.Int32 startIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstartIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstartIndex
		{
			get
			{
				if(r_FstartIndex == null)
				{
					r_FstartIndex = new(this, "startIndex");
				}
				return r_FstartIndex;
			}
		}

		/// <summary>
		/// System.Int64 limit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Flimit;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFlimit
		{
			get
			{
				if(r_Flimit == null)
				{
					r_Flimit = new(this, "limit");
				}
				return r_Flimit;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] productIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_FproductIds;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFproductIds
		{
			get
			{
				if(r_FproductIds == null)
				{
					r_FproductIds = new(this, "productIds");
				}
				return r_FproductIds;
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
				}
				return r_PisOrderSet;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
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


        public RPurchasesQueryArgs() : base("UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs")
        {
        }

        public RPurchasesQueryArgs(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs")
		{
            SetInstance(instance);
		}

        public RPurchasesQueryArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPurchasesQueryArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs(___result);
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
