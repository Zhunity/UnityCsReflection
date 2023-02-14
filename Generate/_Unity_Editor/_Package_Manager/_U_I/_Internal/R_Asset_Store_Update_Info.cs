
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo
	/// </summary>
    public partial class RAssetStoreUpdateInfo : RMember //
    {

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
					r_FproductId.SetBelong(this.instance);
				}
				return r_FproductId;
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
					r_FuploadId.SetBelong(this.instance);
				}
				return r_FuploadId;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo+UpdateStatus updateStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo.RUpdateStatus r_FupdateStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreUpdateInfo.RUpdateStatus RFupdateStatus
		{
			get
			{
				if(r_FupdateStatus == null)
				{
					r_FupdateStatus = new(this, "updateStatus");
					r_FupdateStatus.SetBelong(this.instance);
				}
				return r_FupdateStatus;
			}
		}

		/// <summary>
		/// Boolean updateInfoFetched
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PupdateInfoFetched;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPupdateInfoFetched
		{
			get
			{
				if(r_PupdateInfoFetched == null)
				{
					r_PupdateInfoFetched = new(this, "updateInfoFetched", -1);
					r_PupdateInfoFetched.SetBelong(this.instance);
				}
				return r_PupdateInfoFetched;
			}
		}

		/// <summary>
		/// Boolean canUpdateOrDowngrade
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanUpdateOrDowngrade;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanUpdateOrDowngrade
		{
			get
			{
				if(r_PcanUpdateOrDowngrade == null)
				{
					r_PcanUpdateOrDowngrade = new(this, "canUpdateOrDowngrade", -1);
					r_PcanUpdateOrDowngrade.SetBelong(this.instance);
				}
				return r_PcanUpdateOrDowngrade;
			}
		}

		/// <summary>
		/// Boolean canUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanUpdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanUpdate
		{
			get
			{
				if(r_PcanUpdate == null)
				{
					r_PcanUpdate = new(this, "canUpdate", -1);
					r_PcanUpdate.SetBelong(this.instance);
				}
				return r_PcanUpdate;
			}
		}

		/// <summary>
		/// Boolean canDowngrade
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanDowngrade;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanDowngrade
		{
			get
			{
				if(r_PcanDowngrade == null)
				{
					r_PcanDowngrade = new(this, "canDowngrade", -1);
					r_PcanDowngrade.SetBelong(this.instance);
				}
				return r_PcanDowngrade;
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


        public RAssetStoreUpdateInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo")
        {
        }

        public RAssetStoreUpdateInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreUpdateInfo")
		{
            SetInstance(instance);
		}

        public RAssetStoreUpdateInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetStoreUpdateInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
