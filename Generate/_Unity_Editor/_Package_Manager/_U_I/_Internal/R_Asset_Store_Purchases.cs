
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchases
	/// </summary>
    public partial class RAssetStorePurchases : RMember //
    {

		/// <summary>
		/// System.Int64 total
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Ftotal;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFtotal
		{
			get
			{
				if(r_Ftotal == null)
				{
					r_Ftotal = new(this, "total");
					r_Ftotal.SetBelong(this.instance);
				}
				return r_Ftotal;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs queryArgs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs r_FqueryArgs;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs RFqueryArgs
		{
			get
			{
				if(r_FqueryArgs == null)
				{
					r_FqueryArgs = new(this, "queryArgs");
					r_FqueryArgs.SetBelong(this.instance);
				}
				return r_FqueryArgs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo] list
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> r_Flist;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> RFlist
		{
			get
			{
				if(r_Flist == null)
				{
					r_Flist = new(this, "list");
					r_Flist.SetBelong(this.instance);
				}
				return r_Flist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchases+Category] categories
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases.RCategory> r_Fcategories;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases.RCategory> RFcategories
		{
			get
			{
				if(r_Fcategories == null)
				{
					r_Fcategories = new(this, "categories");
					r_Fcategories.SetBelong(this.instance);
				}
				return r_Fcategories;
			}
		}

		/// <summary>
		/// System.String searchText
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PsearchText;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPsearchText
		{
			get
			{
				if(r_PsearchText == null)
				{
					r_PsearchText = new(this, "searchText", -1);
					r_PsearchText.SetBelong(this.instance);
				}
				return r_PsearchText;
			}
		}

		/// <summary>
		/// Int32 startIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PstartIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPstartIndex
		{
			get
			{
				if(r_PstartIndex == null)
				{
					r_PstartIndex = new(this, "startIndex", -1);
					r_PstartIndex.SetBelong(this.instance);
				}
				return r_PstartIndex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Int64] productIds
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RInt64> r_PproductIds;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RInt64> RPproductIds
		{
			get
			{
				if(r_PproductIds == null)
				{
					r_PproductIds = new(this, "productIds", -1);
					r_PproductIds.SetBelong(this.instance);
				}
				return r_PproductIds;
			}
		}

		/// <summary>
		/// Void AppendPurchases(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected RMethod r_MAppendPurchases_IDictionary_d_String_Object_p_;
		public virtual RMethod RMAppendPurchases_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MAppendPurchases_IDictionary_d_String_Object_p_ == null)
				{
					r_MAppendPurchases_IDictionary_d_String_Object_p_ = new(this, "AppendPurchases", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
					r_MAppendPurchases_IDictionary_d_String_Object_p_.SetBelong(this.instance);
				}
				return r_MAppendPurchases_IDictionary_d_String_Object_p_;
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


        public RAssetStorePurchases() : base("UnityEditor.PackageManager.UI.Internal.AssetStorePurchases")
        {
        }

        public RAssetStorePurchases(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStorePurchases")
		{
            SetInstance(instance);
		}

        public RAssetStorePurchases(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStorePurchases(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AppendPurchases(System.Collections.Generic.IDictionary<System.String, System.Object> @rawList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawList};
            var ___result = RMAppendPurchases_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

            
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
