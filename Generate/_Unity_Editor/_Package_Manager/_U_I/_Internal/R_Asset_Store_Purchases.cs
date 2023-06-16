
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.AssetStorePurchases
	/// </summary>
    public partial class RAssetStorePurchases : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStorePurchases");
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


		/// <summary>
		/// System.Int64 total
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Ftotal;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFtotal
		{
			get
			{
				if(r_Ftotal == null)
				{
					r_Ftotal = new(this, "total");
				}
				return r_Ftotal;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PurchasesQueryArgs queryArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs r_FqueryArgs;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPurchasesQueryArgs RFqueryArgs
		{
			get
			{
				if(r_FqueryArgs == null)
				{
					r_FqueryArgs = new(this, "queryArgs");
				}
				return r_FqueryArgs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchaseInfo] list
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> r_Flist;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchaseInfo> RFlist
		{
			get
			{
				if(r_Flist == null)
				{
					r_Flist = new(this, "list");
				}
				return r_Flist;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PackageManager.UI.Internal.AssetStorePurchases+Category] categories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases.RCategory> r_Fcategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStorePurchases.RCategory> RFcategories
		{
			get
			{
				if(r_Fcategories == null)
				{
					r_Fcategories = new(this, "categories");
				}
				return r_Fcategories;
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
		/// Int32 startIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PstartIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPstartIndex
		{
			get
			{
				if(r_PstartIndex == null)
				{
					r_PstartIndex = new(this, "startIndex", -1);
				}
				return r_PstartIndex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Int64] productIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt64> r_PproductIds;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RInt64> RPproductIds
		{
			get
			{
				if(r_PproductIds == null)
				{
					r_PproductIds = new(this, "productIds", -1);
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
					r_MAppendPurchases_IDictionary_d_String_Object_p_ = new(this, "AppendPurchases", 0,  ReflectionUtils.GetType("System.Collections.Generic.IDictionary`2").MakeGenericType(typeof(System.String), typeof(System.Object)));
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
