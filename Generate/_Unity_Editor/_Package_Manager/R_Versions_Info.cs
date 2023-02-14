
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.VersionsInfo
	/// </summary>
    public partial class RVersionsInfo : RMember //
    {

		/// <summary>
		/// System.String[] m_All
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_All;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_All
		{
			get
			{
				if(r_Fm_All == null)
				{
					r_Fm_All = new(this, "m_All");
					r_Fm_All.SetBelong(this.instance);
				}
				return r_Fm_All;
			}
		}

		/// <summary>
		/// System.String[] m_Compatible
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Compatible;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_Compatible
		{
			get
			{
				if(r_Fm_Compatible == null)
				{
					r_Fm_Compatible = new(this, "m_Compatible");
					r_Fm_Compatible.SetBelong(this.instance);
				}
				return r_Fm_Compatible;
			}
		}

		/// <summary>
		/// System.String m_Recommended
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Recommended;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Recommended
		{
			get
			{
				if(r_Fm_Recommended == null)
				{
					r_Fm_Recommended = new(this, "m_Recommended");
					r_Fm_Recommended.SetBelong(this.instance);
				}
				return r_Fm_Recommended;
			}
		}

		/// <summary>
		/// System.String[] m_Deprecated
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_Deprecated;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_Deprecated
		{
			get
			{
				if(r_Fm_Deprecated == null)
				{
					r_Fm_Deprecated = new(this, "m_Deprecated");
					r_Fm_Deprecated.SetBelong(this.instance);
				}
				return r_Fm_Deprecated;
			}
		}

		/// <summary>
		/// System.String[] all
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_Pall;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPall
		{
			get
			{
				if(r_Pall == null)
				{
					r_Pall = new(this, "all", -1);
					r_Pall.SetBelong(this.instance);
				}
				return r_Pall;
			}
		}

		/// <summary>
		/// System.String[] compatible
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_Pcompatible;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPcompatible
		{
			get
			{
				if(r_Pcompatible == null)
				{
					r_Pcompatible = new(this, "compatible", -1);
					r_Pcompatible.SetBelong(this.instance);
				}
				return r_Pcompatible;
			}
		}

		/// <summary>
		/// System.String recommended
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Precommended;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPrecommended
		{
			get
			{
				if(r_Precommended == null)
				{
					r_Precommended = new(this, "recommended", -1);
					r_Precommended.SetBelong(this.instance);
				}
				return r_Precommended;
			}
		}

		/// <summary>
		/// System.String[] deprecated
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_Pdeprecated;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPdeprecated
		{
			get
			{
				if(r_Pdeprecated == null)
				{
					r_Pdeprecated = new(this, "deprecated", -1);
					r_Pdeprecated.SetBelong(this.instance);
				}
				return r_Pdeprecated;
			}
		}

		/// <summary>
		/// System.String verified
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pverified;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPverified
		{
			get
			{
				if(r_Pverified == null)
				{
					r_Pverified = new(this, "verified", -1);
					r_Pverified.SetBelong(this.instance);
				}
				return r_Pverified;
			}
		}

		/// <summary>
		/// System.String latest
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Platest;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlatest
		{
			get
			{
				if(r_Platest == null)
				{
					r_Platest = new(this, "latest", -1);
					r_Platest.SetBelong(this.instance);
				}
				return r_Platest;
			}
		}

		/// <summary>
		/// System.String latestCompatible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PlatestCompatible;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPlatestCompatible
		{
			get
			{
				if(r_PlatestCompatible == null)
				{
					r_PlatestCompatible = new(this, "latestCompatible", -1);
					r_PlatestCompatible.SetBelong(this.instance);
				}
				return r_PlatestCompatible;
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


        public RVersionsInfo() : base("UnityEditor.PackageManager.VersionsInfo")
        {
        }

        public RVersionsInfo(System.Object instance) : base("UnityEditor.PackageManager.VersionsInfo")
		{
            SetInstance(instance);
		}

        public RVersionsInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVersionsInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
