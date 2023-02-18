
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUnityLifecycle
{
	/// <summary>
	/// UnityEditor.PackageManager.UnityLifecycle.UnityLifecycleInfo
	/// </summary>
    public partial class RUnityLifecycleInfo : RMember //
    {

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
					r_Fm_Version.SetBelong(this.GetValue());
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.String m_NextVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_NextVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_NextVersion
		{
			get
			{
				if(r_Fm_NextVersion == null)
				{
					r_Fm_NextVersion = new(this, "m_NextVersion");
					r_Fm_NextVersion.SetBelong(this.GetValue());
				}
				return r_Fm_NextVersion;
			}
		}

		/// <summary>
		/// System.String m_RecommendedVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_RecommendedVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_RecommendedVersion
		{
			get
			{
				if(r_Fm_RecommendedVersion == null)
				{
					r_Fm_RecommendedVersion = new(this, "m_RecommendedVersion");
					r_Fm_RecommendedVersion.SetBelong(this.GetValue());
				}
				return r_Fm_RecommendedVersion;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDeprecated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsDeprecated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsDeprecated
		{
			get
			{
				if(r_Fm_IsDeprecated == null)
				{
					r_Fm_IsDeprecated = new(this, "m_IsDeprecated");
					r_Fm_IsDeprecated.SetBelong(this.GetValue());
				}
				return r_Fm_IsDeprecated;
			}
		}

		/// <summary>
		/// System.String m_DeprecationMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DeprecationMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DeprecationMessage
		{
			get
			{
				if(r_Fm_DeprecationMessage == null)
				{
					r_Fm_DeprecationMessage = new(this, "m_DeprecationMessage");
					r_Fm_DeprecationMessage.SetBelong(this.GetValue());
				}
				return r_Fm_DeprecationMessage;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
					r_Pversion.SetBelong(this.GetValue());
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// System.String nextVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PnextVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPnextVersion
		{
			get
			{
				if(r_PnextVersion == null)
				{
					r_PnextVersion = new(this, "nextVersion", -1);
					r_PnextVersion.SetBelong(this.GetValue());
				}
				return r_PnextVersion;
			}
		}

		/// <summary>
		/// System.String recommendedVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PrecommendedVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPrecommendedVersion
		{
			get
			{
				if(r_PrecommendedVersion == null)
				{
					r_PrecommendedVersion = new(this, "recommendedVersion", -1);
					r_PrecommendedVersion.SetBelong(this.GetValue());
				}
				return r_PrecommendedVersion;
			}
		}

		/// <summary>
		/// Boolean isDeprecated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDeprecated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDeprecated
		{
			get
			{
				if(r_PisDeprecated == null)
				{
					r_PisDeprecated = new(this, "isDeprecated", -1);
					r_PisDeprecated.SetBelong(this.GetValue());
				}
				return r_PisDeprecated;
			}
		}

		/// <summary>
		/// System.String deprecationMessage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdeprecationMessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdeprecationMessage
		{
			get
			{
				if(r_PdeprecationMessage == null)
				{
					r_PdeprecationMessage = new(this, "deprecationMessage", -1);
					r_PdeprecationMessage.SetBelong(this.GetValue());
				}
				return r_PdeprecationMessage;
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


        public RUnityLifecycleInfo() : base("UnityEditor.PackageManager.UnityLifecycle.UnityLifecycleInfo")
        {
        }

        public RUnityLifecycleInfo(System.Object instance) : base("UnityEditor.PackageManager.UnityLifecycle.UnityLifecycleInfo")
		{
            SetInstance(instance);
		}

        public RUnityLifecycleInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityLifecycleInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
