
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RConnect
{
	/// <summary>
	/// UnityEditor.Connect.UserInfo
	/// </summary>
    public partial class RUserInfo : RMember //
    {

		/// <summary>
		/// System.Boolean m_Valid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Valid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Valid
		{
			get
			{
				if(r_Fm_Valid == null)
				{
					r_Fm_Valid = new(this, "m_Valid");
					r_Fm_Valid.SetBelong(this.instance);
				}
				return r_Fm_Valid;
			}
		}

		/// <summary>
		/// System.String m_UserId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_UserId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_UserId
		{
			get
			{
				if(r_Fm_UserId == null)
				{
					r_Fm_UserId = new(this, "m_UserId");
					r_Fm_UserId.SetBelong(this.instance);
				}
				return r_Fm_UserId;
			}
		}

		/// <summary>
		/// System.String m_UserName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_UserName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_UserName
		{
			get
			{
				if(r_Fm_UserName == null)
				{
					r_Fm_UserName = new(this, "m_UserName");
					r_Fm_UserName.SetBelong(this.instance);
				}
				return r_Fm_UserName;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
					r_Fm_DisplayName.SetBelong(this.instance);
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// System.String m_PrimaryOrg
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PrimaryOrg;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PrimaryOrg
		{
			get
			{
				if(r_Fm_PrimaryOrg == null)
				{
					r_Fm_PrimaryOrg = new(this, "m_PrimaryOrg");
					r_Fm_PrimaryOrg.SetBelong(this.instance);
				}
				return r_Fm_PrimaryOrg;
			}
		}

		/// <summary>
		/// System.String m_OrganizationForeignKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_OrganizationForeignKeys;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_OrganizationForeignKeys
		{
			get
			{
				if(r_Fm_OrganizationForeignKeys == null)
				{
					r_Fm_OrganizationForeignKeys = new(this, "m_OrganizationForeignKeys");
					r_Fm_OrganizationForeignKeys.SetBelong(this.instance);
				}
				return r_Fm_OrganizationForeignKeys;
			}
		}

		/// <summary>
		/// System.String[] m_OrganizationNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_OrganizationNames;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_OrganizationNames
		{
			get
			{
				if(r_Fm_OrganizationNames == null)
				{
					r_Fm_OrganizationNames = new(this, "m_OrganizationNames");
					r_Fm_OrganizationNames.SetBelong(this.instance);
				}
				return r_Fm_OrganizationNames;
			}
		}

		/// <summary>
		/// System.String m_AccessToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_AccessToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_AccessToken
		{
			get
			{
				if(r_Fm_AccessToken == null)
				{
					r_Fm_AccessToken = new(this, "m_AccessToken");
					r_Fm_AccessToken.SetBelong(this.instance);
				}
				return r_Fm_AccessToken;
			}
		}

		/// <summary>
		/// System.Int32 m_Whitelisted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Whitelisted;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Whitelisted
		{
			get
			{
				if(r_Fm_Whitelisted == null)
				{
					r_Fm_Whitelisted = new(this, "m_Whitelisted");
					r_Fm_Whitelisted.SetBelong(this.instance);
				}
				return r_Fm_Whitelisted;
			}
		}

		/// <summary>
		/// Boolean valid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pvalid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPvalid
		{
			get
			{
				if(r_Pvalid == null)
				{
					r_Pvalid = new(this, "valid", -1);
					r_Pvalid.SetBelong(this.instance);
				}
				return r_Pvalid;
			}
		}

		/// <summary>
		/// System.String userId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PuserId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPuserId
		{
			get
			{
				if(r_PuserId == null)
				{
					r_PuserId = new(this, "userId", -1);
					r_PuserId.SetBelong(this.instance);
				}
				return r_PuserId;
			}
		}

		/// <summary>
		/// System.String userName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PuserName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPuserName
		{
			get
			{
				if(r_PuserName == null)
				{
					r_PuserName = new(this, "userName", -1);
					r_PuserName.SetBelong(this.instance);
				}
				return r_PuserName;
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
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String primaryOrg
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PprimaryOrg;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPprimaryOrg
		{
			get
			{
				if(r_PprimaryOrg == null)
				{
					r_PprimaryOrg = new(this, "primaryOrg", -1);
					r_PprimaryOrg.SetBelong(this.instance);
				}
				return r_PprimaryOrg;
			}
		}

		/// <summary>
		/// Boolean whitelisted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pwhitelisted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwhitelisted
		{
			get
			{
				if(r_Pwhitelisted == null)
				{
					r_Pwhitelisted = new(this, "whitelisted", -1);
					r_Pwhitelisted.SetBelong(this.instance);
				}
				return r_Pwhitelisted;
			}
		}

		/// <summary>
		/// System.String organizationForeignKeys
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PorganizationForeignKeys;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPorganizationForeignKeys
		{
			get
			{
				if(r_PorganizationForeignKeys == null)
				{
					r_PorganizationForeignKeys = new(this, "organizationForeignKeys", -1);
					r_PorganizationForeignKeys.SetBelong(this.instance);
				}
				return r_PorganizationForeignKeys;
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
					r_PaccessToken.SetBelong(this.instance);
				}
				return r_PaccessToken;
			}
		}

		/// <summary>
		/// System.String[] organizationNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PorganizationNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPorganizationNames
		{
			get
			{
				if(r_PorganizationNames == null)
				{
					r_PorganizationNames = new(this, "organizationNames", -1);
					r_PorganizationNames.SetBelong(this.instance);
				}
				return r_PorganizationNames;
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


        public RUserInfo() : base("UnityEditor.Connect.UserInfo")
        {
        }

        public RUserInfo(System.Object instance) : base("UnityEditor.Connect.UserInfo")
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
