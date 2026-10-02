
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PageFilters
	/// </summary>
    public partial class RPageFilters : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PageFilters");
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
				}
				return r_Fm_SearchText;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_statuses
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_statuses;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_statuses
		{
			get
			{
				if(r_Fm_statuses == null)
				{
					r_Fm_statuses = new(this, "m_statuses");
				}
				return r_Fm_statuses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_categories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_categories;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_categories
		{
			get
			{
				if(r_Fm_categories == null)
				{
					r_Fm_categories = new(this, "m_categories");
				}
				return r_Fm_categories;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_labels
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_labels;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_labels
		{
			get
			{
				if(r_Fm_labels == null)
				{
					r_Fm_labels = new(this, "m_labels");
				}
				return r_Fm_labels;
			}
		}

		/// <summary>
		/// System.String m_orderBy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_orderBy;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_orderBy
		{
			get
			{
				if(r_Fm_orderBy == null)
				{
					r_Fm_orderBy = new(this, "m_orderBy");
				}
				return r_Fm_orderBy;
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
		/// System.Collections.Generic.List`1[System.String] statuses
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Pstatuses;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPstatuses
		{
			get
			{
				if(r_Pstatuses == null)
				{
					r_Pstatuses = new(this, "statuses", -1);
				}
				return r_Pstatuses;
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


		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters Clone()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMClone.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters>(___result);
		}


		public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageFilters @other)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@other.Value};
			var ___result = RMEquals_PageFilters.Invoke(___genericsType, ___parameters);
			return ReflectionUtils.Convert<System.Boolean>(___result);
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
