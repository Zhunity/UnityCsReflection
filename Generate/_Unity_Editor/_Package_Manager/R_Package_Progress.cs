
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.PackageProgress
	/// </summary>
    public partial class RPackageProgress : RMember //
    {

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Version;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
					r_Fm_Version.SetBelong(this.instance);
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.ProgressState m_State
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressState r_Fm_State;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressState RFm_State
		{
			get
			{
				if(r_Fm_State == null)
				{
					r_Fm_State = new(this, "m_State");
					r_Fm_State.SetBelong(this.instance);
				}
				return r_Fm_State;
			}
		}

		/// <summary>
		/// System.UInt64 m_CurrentBytes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_Fm_CurrentBytes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RFm_CurrentBytes
		{
			get
			{
				if(r_Fm_CurrentBytes == null)
				{
					r_Fm_CurrentBytes = new(this, "m_CurrentBytes");
					r_Fm_CurrentBytes.SetBelong(this.instance);
				}
				return r_Fm_CurrentBytes;
			}
		}

		/// <summary>
		/// System.UInt64 m_TotalBytes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt64 r_Fm_TotalBytes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt64 RFm_TotalBytes
		{
			get
			{
				if(r_Fm_TotalBytes == null)
				{
					r_Fm_TotalBytes = new(this, "m_TotalBytes");
					r_Fm_TotalBytes.SetBelong(this.instance);
				}
				return r_Fm_TotalBytes;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pversion;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.instance);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.ProgressState state
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressState r_Pstate;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RProgressState RPstate
		{
			get
			{
				if(r_Pstate == null)
				{
					r_Pstate = new(this, "state", -1);
					r_Pstate.SetBelong(this.instance);
				}
				return r_Pstate;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEditor.PackageManager.DownloadProgress] download
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RDownloadProgress> r_Pdownload;
		public virtual SMFrame.Editor.Refleaction.RSystem.RNullable<SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RDownloadProgress> RPdownload
		{
			get
			{
				if(r_Pdownload == null)
				{
					r_Pdownload = new(this, "download", -1);
					r_Pdownload.SetBelong(this.instance);
				}
				return r_Pdownload;
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


        public RPackageProgress() : base("UnityEditor.PackageManager.PackageProgress")
        {
        }

        public RPackageProgress(System.Object instance) : base("UnityEditor.PackageManager.PackageProgress")
		{
            SetInstance(instance);
		}

        public RPackageProgress(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageProgress(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
