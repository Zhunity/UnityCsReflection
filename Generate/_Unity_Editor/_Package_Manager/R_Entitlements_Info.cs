
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.EntitlementsInfo
	/// </summary>
    public partial class REntitlementsInfo : RMember //
    {

		/// <summary>
		/// System.Boolean m_IsAllowed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsAllowed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsAllowed
		{
			get
			{
				if(r_Fm_IsAllowed == null)
				{
					r_Fm_IsAllowed = new(this, "m_IsAllowed");
				}
				return r_Fm_IsAllowed;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.EntitlementLicensingModel m_LicensingModel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementLicensingModel r_Fm_LicensingModel;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementLicensingModel RFm_LicensingModel
		{
			get
			{
				if(r_Fm_LicensingModel == null)
				{
					r_Fm_LicensingModel = new(this, "m_LicensingModel");
				}
				return r_Fm_LicensingModel;
			}
		}

		/// <summary>
		/// UnityEditor.Experimental.Licensing.EntitlementStatus m_Status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RExperimental.RLicensing.REntitlementStatus r_Fm_Status;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RExperimental.RLicensing.REntitlementStatus RFm_Status
		{
			get
			{
				if(r_Fm_Status == null)
				{
					r_Fm_Status = new(this, "m_Status");
				}
				return r_Fm_Status;
			}
		}

		/// <summary>
		/// Boolean isAllowed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisAllowed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisAllowed
		{
			get
			{
				if(r_PisAllowed == null)
				{
					r_PisAllowed = new(this, "isAllowed", -1);
				}
				return r_PisAllowed;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.EntitlementLicensingModel licensingModel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementLicensingModel r_PlicensingModel;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.REntitlementLicensingModel RPlicensingModel
		{
			get
			{
				if(r_PlicensingModel == null)
				{
					r_PlicensingModel = new(this, "licensingModel", -1);
				}
				return r_PlicensingModel;
			}
		}

		/// <summary>
		/// UnityEditor.Experimental.Licensing.EntitlementStatus status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RExperimental.RLicensing.REntitlementStatus r_Pstatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RExperimental.RLicensing.REntitlementStatus RPstatus
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


        public REntitlementsInfo() : base("UnityEditor.PackageManager.EntitlementsInfo")
        {
        }

        public REntitlementsInfo(System.Object instance) : base("UnityEditor.PackageManager.EntitlementsInfo")
		{
            SetInstance(instance);
		}

        public REntitlementsInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REntitlementsInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
