using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.SortVersion
	/// </summary>
    public partial class RSortVersion : RMember //
    {

		/// <summary>
		/// System.Int32 m_NlsVersion
		/// </summary>
		protected RSystem.RInt32 r_Fm_NlsVersion;
		public virtual RSystem.RInt32 RFm_NlsVersion
		{
			get
			{
				if(r_Fm_NlsVersion == null)
				{
					r_Fm_NlsVersion = new(this, "m_NlsVersion");
					r_Fm_NlsVersion.SetBelong(this.instance);
				}
				return r_Fm_NlsVersion;
			}
		}

		/// <summary>
		/// System.Guid m_SortId
		/// </summary>
		protected RSystem.RGuid r_Fm_SortId;
		public virtual RSystem.RGuid RFm_SortId
		{
			get
			{
				if(r_Fm_SortId == null)
				{
					r_Fm_SortId = new(this, "m_SortId");
					r_Fm_SortId.SetBelong(this.instance);
				}
				return r_Fm_SortId;
			}
		}

		/// <summary>
		/// Int32 FullVersion
		/// </summary>
		protected RSystem.RInt32 r_PFullVersion;
		public virtual RSystem.RInt32 RPFullVersion
		{
			get
			{
				if(r_PFullVersion == null)
				{
					r_PFullVersion = new(this, "FullVersion", -1);
					r_PFullVersion.SetBelong(this.instance);
				}
				return r_PFullVersion;
			}
		}

		/// <summary>
		/// System.Guid SortId
		/// </summary>
		protected RSystem.RGuid r_PSortId;
		public virtual RSystem.RGuid RPSortId
		{
			get
			{
				if(r_PSortId == null)
				{
					r_PSortId = new(this, "SortId", -1);
					r_PSortId.SetBelong(this.instance);
				}
				return r_PSortId;
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
		/// Boolean Equals(System.Globalization.SortVersion)
		/// </summary>
		protected RMethod r_MEquals_SortVersion;
		public virtual RMethod RMEquals_SortVersion
		{
			get
			{
				if(r_MEquals_SortVersion == null)
				{
					r_MEquals_SortVersion = new(this, "Equals", 0, typeof(System.Globalization.SortVersion));
					r_MEquals_SortVersion.SetBelong(this.instance);
				}
				return r_MEquals_SortVersion;
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
		/// Boolean op_Equality(System.Globalization.SortVersion, System.Globalization.SortVersion)
		/// </summary>
		protected static RMethod r_Mop_Equality_SortVersion_SortVersion;
		public static RMethod RMop_Equality_SortVersion_SortVersion
		{
			get
			{
				if(r_Mop_Equality_SortVersion_SortVersion == null)
				{
					r_Mop_Equality_SortVersion_SortVersion = new(typeof(System.Globalization.SortVersion), "op_Equality", 0, typeof(System.Globalization.SortVersion), typeof(System.Globalization.SortVersion));
					r_Mop_Equality_SortVersion_SortVersion.SetBelong(null);
				}
				return r_Mop_Equality_SortVersion_SortVersion;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Globalization.SortVersion, System.Globalization.SortVersion)
		/// </summary>
		protected static RMethod r_Mop_Inequality_SortVersion_SortVersion;
		public static RMethod RMop_Inequality_SortVersion_SortVersion
		{
			get
			{
				if(r_Mop_Inequality_SortVersion_SortVersion == null)
				{
					r_Mop_Inequality_SortVersion_SortVersion = new(typeof(System.Globalization.SortVersion), "op_Inequality", 0, typeof(System.Globalization.SortVersion), typeof(System.Globalization.SortVersion));
					r_Mop_Inequality_SortVersion_SortVersion.SetBelong(null);
				}
				return r_Mop_Inequality_SortVersion_SortVersion;
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


        public RSortVersion() : base("System.Globalization.SortVersion")
        {
        }

        public RSortVersion(System.Object instance) : base("System.Globalization.SortVersion")
		{
            SetInstance(instance);
		}

        public RSortVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSortVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Globalization.SortVersion @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_SortVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Globalization.SortVersion @left, System.Globalization.SortVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_SortVersion_SortVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Globalization.SortVersion @left, System.Globalization.SortVersion @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_SortVersion_SortVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
