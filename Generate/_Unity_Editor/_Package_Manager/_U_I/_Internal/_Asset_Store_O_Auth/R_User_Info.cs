
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RAssetStoreOAuth
{
	
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo
	/// </summary>
    public partial class RUserInfo : RMember //
    {

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
					r_Fid.SetBelong(this.GetValue());
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// System.String username
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fusername;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFusername
		{
			get
			{
				if(r_Fusername == null)
				{
					r_Fusername = new(this, "username");
					r_Fusername.SetBelong(this.GetValue());
				}
				return r_Fusername;
			}
		}

		/// <summary>
		/// System.String defaultOrganization
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FdefaultOrganization;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFdefaultOrganization
		{
			get
			{
				if(r_FdefaultOrganization == null)
				{
					r_FdefaultOrganization = new(this, "defaultOrganization");
					r_FdefaultOrganization.SetBelong(this.GetValue());
				}
				return r_FdefaultOrganization;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo m_TokenInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo r_Fm_TokenInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetStoreOAuth.RTokenInfo RFm_TokenInfo
		{
			get
			{
				if(r_Fm_TokenInfo == null)
				{
					r_Fm_TokenInfo = new(this, "m_TokenInfo");
					r_Fm_TokenInfo.SetBelong(this.GetValue());
				}
				return r_Fm_TokenInfo;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
					r_PisValid.SetBelong(this.GetValue());
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// System.String accessToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PaccessToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPaccessToken
		{
			get
			{
				if(r_PaccessToken == null)
				{
					r_PaccessToken = new(this, "accessToken", -1);
					r_PaccessToken.SetBelong(this.GetValue());
				}
				return r_PaccessToken;
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


        public RUserInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo")
        {
        }

        public RUserInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+UserInfo")
		{
            SetInstance(instance);
		}

        public RUserInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUserInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}