
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.GitInfo
	/// </summary>
    public partial class RGitInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PackageManager.GitInfo);
            }
        }

        public RGitInfo() : base("UnityEditor.PackageManager.GitInfo")
        {
        }

        public RGitInfo(System.Object instance) : base("UnityEditor.PackageManager.GitInfo")
		{
            SetInstance(instance);
		}

        public RGitInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGitInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_Hash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Hash;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Hash
		{
			get
			{
				if(r_Fm_Hash == null)
				{
					r_Fm_Hash = new(this, "m_Hash");
				}
				return r_Fm_Hash;
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
		/// System.String hash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Phash;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPhash
		{
			get
			{
				if(r_Phash == null)
				{
					r_Phash = new(this, "hash", -1);
				}
				return r_Phash;
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
