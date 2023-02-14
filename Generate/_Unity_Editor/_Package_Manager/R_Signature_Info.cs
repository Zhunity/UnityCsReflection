
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.SignatureInfo
	/// </summary>
    public partial class RSignatureInfo : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.SignatureStatus m_Status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureStatus r_Fm_Status;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureStatus RFm_Status
		{
			get
			{
				if(r_Fm_Status == null)
				{
					r_Fm_Status = new(this, "m_Status");
					r_Fm_Status.SetBelong(this.instance);
				}
				return r_Fm_Status;
			}
		}

		/// <summary>
		/// System.String m_Reason
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Reason;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Reason
		{
			get
			{
				if(r_Fm_Reason == null)
				{
					r_Fm_Reason = new(this, "m_Reason");
					r_Fm_Reason.SetBelong(this.instance);
				}
				return r_Fm_Reason;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.SignatureStatus status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureStatus r_Pstatus;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSignatureStatus RPstatus
		{
			get
			{
				if(r_Pstatus == null)
				{
					r_Pstatus = new(this, "status", -1);
					r_Pstatus.SetBelong(this.instance);
				}
				return r_Pstatus;
			}
		}

		/// <summary>
		/// System.String reason
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Preason;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPreason
		{
			get
			{
				if(r_Preason == null)
				{
					r_Preason = new(this, "reason", -1);
					r_Preason.SetBelong(this.instance);
				}
				return r_Preason;
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


        public RSignatureInfo() : base("UnityEditor.PackageManager.SignatureInfo")
        {
        }

        public RSignatureInfo(System.Object instance) : base("UnityEditor.PackageManager.SignatureInfo")
		{
            SetInstance(instance);
		}

        public RSignatureInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSignatureInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
