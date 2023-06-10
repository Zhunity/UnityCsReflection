
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PackageInfo
	/// </summary>
    public partial class RPackageInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.PackageInfo);
            }
        }

        public RPackageInfo() : base("UnityEditor.PackageInfo")
        {
        }

        public RPackageInfo(System.Object instance) : base("UnityEditor.PackageInfo")
		{
            SetInstance(instance);
		}

        public RPackageInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String packagePath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FpackagePath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpackagePath
		{
			get
			{
				if(r_FpackagePath == null)
				{
					r_FpackagePath = new(this, "packagePath");
				}
				return r_FpackagePath;
			}
		}

		/// <summary>
		/// System.String jsonInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FjsonInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFjsonInfo
		{
			get
			{
				if(r_FjsonInfo == null)
				{
					r_FjsonInfo = new(this, "jsonInfo");
				}
				return r_FjsonInfo;
			}
		}

		/// <summary>
		/// System.String iconURL
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FiconURL;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFiconURL
		{
			get
			{
				if(r_FiconURL == null)
				{
					r_FiconURL = new(this, "iconURL");
				}
				return r_FiconURL;
			}
		}

		/// <summary>
		/// UnityEditor.PackageInfo[] GetPackageList()
		/// </summary>
		protected static RMethod r_MGetPackageList;
		public static RMethod RMGetPackageList
		{
			get
			{
				if(r_MGetPackageList == null)
				{
					r_MGetPackageList = new(typeof(UnityEditor.PackageInfo), "GetPackageList", 0);
				}
				return r_MGetPackageList;
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


        public static UnityEditor.PackageInfo[] GetPackageList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPackageList.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageInfo[])___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
