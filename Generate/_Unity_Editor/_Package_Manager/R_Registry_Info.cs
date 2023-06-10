
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.RegistryInfo
	/// </summary>
    public partial class RRegistryInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PackageManager.RegistryInfo);
            }
        }

        public RRegistryInfo() : base("UnityEditor.PackageManager.RegistryInfo")
        {
        }

        public RRegistryInfo(System.Object instance) : base("UnityEditor.PackageManager.RegistryInfo")
		{
            SetInstance(instance);
		}

        public RRegistryInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegistryInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.String m_Url
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Url;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Url
		{
			get
			{
				if(r_Fm_Url == null)
				{
					r_Fm_Url = new(this, "m_Url");
				}
				return r_Fm_Url;
			}
		}

		/// <summary>
		/// System.String[] m_Scopes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Scopes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_Scopes
		{
			get
			{
				if(r_Fm_Scopes == null)
				{
					r_Fm_Scopes = new(this, "m_Scopes");
				}
				return r_Fm_Scopes;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsDefault
		{
			get
			{
				if(r_Fm_IsDefault == null)
				{
					r_Fm_IsDefault = new(this, "m_IsDefault");
				}
				return r_Fm_IsDefault;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.SearchCapabilities m_Capabilities
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSearchCapabilities r_Fm_Capabilities;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSearchCapabilities RFm_Capabilities
		{
			get
			{
				if(r_Fm_Capabilities == null)
				{
					r_Fm_Capabilities = new(this, "m_Capabilities");
				}
				return r_Fm_Capabilities;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.ConfigSource m_ConfigSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RConfigSource r_Fm_ConfigSource;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RConfigSource RFm_ConfigSource
		{
			get
			{
				if(r_Fm_ConfigSource == null)
				{
					r_Fm_ConfigSource = new(this, "m_ConfigSource");
				}
				return r_Fm_ConfigSource;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Purl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPurl
		{
			get
			{
				if(r_Purl == null)
				{
					r_Purl = new(this, "url", -1);
				}
				return r_Purl;
			}
		}

		/// <summary>
		/// System.String[] scopes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_Pscopes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPscopes
		{
			get
			{
				if(r_Pscopes == null)
				{
					r_Pscopes = new(this, "scopes", -1);
				}
				return r_Pscopes;
			}
		}

		/// <summary>
		/// Boolean isDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDefault
		{
			get
			{
				if(r_PisDefault == null)
				{
					r_PisDefault = new(this, "isDefault", -1);
				}
				return r_PisDefault;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.SearchCapabilities capabilities
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSearchCapabilities r_Pcapabilities;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RSearchCapabilities RPcapabilities
		{
			get
			{
				if(r_Pcapabilities == null)
				{
					r_Pcapabilities = new(this, "capabilities", -1);
				}
				return r_Pcapabilities;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.ConfigSource configSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RConfigSource r_PconfigSource;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RConfigSource RPconfigSource
		{
			get
			{
				if(r_PconfigSource == null)
				{
					r_PconfigSource = new(this, "configSource", -1);
				}
				return r_PconfigSource;
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
