
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.RepositoryInfo
	/// </summary>
    public partial class RRepositoryInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PackageManager.RepositoryInfo);
            }
        }

        public RRepositoryInfo() : base("UnityEditor.PackageManager.RepositoryInfo")
        {
        }

        public RRepositoryInfo(System.Object instance) : base("UnityEditor.PackageManager.RepositoryInfo")
		{
            SetInstance(instance);
		}

        public RRepositoryInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRepositoryInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Type;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
				}
				return r_Fm_Type;
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
		/// System.String m_Revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Revision;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Revision
		{
			get
			{
				if(r_Fm_Revision == null)
				{
					r_Fm_Revision = new(this, "m_Revision");
				}
				return r_Fm_Revision;
			}
		}

		/// <summary>
		/// System.String m_Path
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Path;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Path
		{
			get
			{
				if(r_Fm_Path == null)
				{
					r_Fm_Path = new(this, "m_Path");
				}
				return r_Fm_Path;
			}
		}

		/// <summary>
		/// System.String type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptype;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
				}
				return r_Ptype;
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
		/// System.String revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Prevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPrevision
		{
			get
			{
				if(r_Prevision == null)
				{
					r_Prevision = new(this, "revision", -1);
				}
				return r_Prevision;
			}
		}

		/// <summary>
		/// System.String path
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ppath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpath
		{
			get
			{
				if(r_Ppath == null)
				{
					r_Ppath = new(this, "path", -1);
				}
				return r_Ppath;
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
