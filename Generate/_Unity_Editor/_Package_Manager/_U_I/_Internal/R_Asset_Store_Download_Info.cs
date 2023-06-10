
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo
	/// </summary>
    public partial class RAssetStoreDownloadInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo");
            }
        }

        public RAssetStoreDownloadInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo")
        {
        }

        public RAssetStoreDownloadInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo")
		{
            SetInstance(instance);
		}

        public RAssetStoreDownloadInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreDownloadInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisValid
		{
			get
			{
				if(r_FisValid == null)
				{
					r_FisValid = new(this, "isValid");
				}
				return r_FisValid;
			}
		}

		/// <summary>
		/// System.String categoryName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FcategoryName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFcategoryName
		{
			get
			{
				if(r_FcategoryName == null)
				{
					r_FcategoryName = new(this, "categoryName");
				}
				return r_FcategoryName;
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
		/// System.String publisherName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpublisherName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpublisherName
		{
			get
			{
				if(r_FpublisherName == null)
				{
					r_FpublisherName = new(this, "publisherName");
				}
				return r_FpublisherName;
			}
		}

		/// <summary>
		/// System.String productId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FproductId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFproductId
		{
			get
			{
				if(r_FproductId == null)
				{
					r_FproductId = new(this, "productId");
				}
				return r_FproductId;
			}
		}

		/// <summary>
		/// System.String key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fkey;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFkey
		{
			get
			{
				if(r_Fkey == null)
				{
					r_Fkey = new(this, "key");
				}
				return r_Fkey;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Furl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFurl
		{
			get
			{
				if(r_Furl == null)
				{
					r_Furl = new(this, "url");
				}
				return r_Furl;
			}
		}

		/// <summary>
		/// System.String errorMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FerrorMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFerrorMessage
		{
			get
			{
				if(r_FerrorMessage == null)
				{
					r_FerrorMessage = new(this, "errorMessage");
				}
				return r_FerrorMessage;
			}
		}

		/// <summary>
		/// System.Int32 errorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FerrorCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFerrorCode
		{
			get
			{
				if(r_FerrorCode == null)
				{
					r_FerrorCode = new(this, "errorCode");
				}
				return r_FerrorCode;
			}
		}

		/// <summary>
		/// System.String[] destination
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_Pdestination;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPdestination
		{
			get
			{
				if(r_Pdestination == null)
				{
					r_Pdestination = new(this, "destination", -1);
				}
				return r_Pdestination;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo ParseDownloadInfo(System.Collections.Generic.IDictionary`2[System.String,System.Object])
		/// </summary>
		protected static RMethod r_MParseDownloadInfo_IDictionary_d_String_Object_p_;
		public static RMethod RMParseDownloadInfo_IDictionary_d_String_Object_p_
		{
			get
			{
				if(r_MParseDownloadInfo_IDictionary_d_String_Object_p_ == null)
				{
					r_MParseDownloadInfo_IDictionary_d_String_Object_p_ = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreDownloadInfo"), "ParseDownloadInfo", 0, typeof(System.Collections.Generic.IDictionary<, >).MakeGenericType(typeof(System.String), typeof(System.Object)));
				}
				return r_MParseDownloadInfo_IDictionary_d_String_Object_p_;
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


        public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo ParseDownloadInfo(System.Collections.Generic.IDictionary<System.String, System.Object> @rawInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rawInfo};
            var ___result = RMParseDownloadInfo_IDictionary_d_String_Object_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreDownloadInfo(___result);
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
