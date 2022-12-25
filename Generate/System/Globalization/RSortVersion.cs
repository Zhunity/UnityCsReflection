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
		protected RField r_m_NlsVersion;
		public virtual RField Rm_NlsVersion
		{
			get
			{
				if(r_m_NlsVersion == null)
				{
					r_m_NlsVersion = new(this, "m_NlsVersion");
					r_m_NlsVersion.SetBelong(this.instance);
				}
				return r_m_NlsVersion;
			}
		}

		/// <summary>
		/// System.Guid m_SortId
		/// </summary>
		protected RSystem.RGuid r_m_SortId;
		public virtual RSystem.RGuid Rm_SortId
		{
			get
			{
				if(r_m_SortId == null)
				{
					r_m_SortId = new(this, "m_SortId");
					r_m_SortId.SetBelong(this.instance);
				}
				return r_m_SortId;
			}
		}

		/// <summary>
		/// Int32 FullVersion
		/// </summary>
		protected RProperty r_FullVersion;
		public virtual RProperty RFullVersion
		{
			get
			{
				if(r_FullVersion == null)
				{
					r_FullVersion = new(this, "FullVersion", -1);
					r_FullVersion.SetBelong(this.instance);
				}
				return r_FullVersion;
			}
		}

		/// <summary>
		/// System.Guid SortId
		/// </summary>
		protected RSystem.RGuid r_SortId;
		public virtual RSystem.RGuid RSortId
		{
			get
			{
				if(r_SortId == null)
				{
					r_SortId = new(this, "SortId", -1);
					r_SortId.SetBelong(this.instance);
				}
				return r_SortId;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Globalization.SortVersion)
		/// </summary>
		protected RMethod r_REquals_SortVersion;
		public virtual RMethod REquals_SortVersion
		{
			get
			{
				if(r_REquals_SortVersion == null)
				{
					r_REquals_SortVersion = new(this, "Equals", 0, typeof(System.Globalization.SortVersion));
					r_REquals_SortVersion.SetBelong(this.instance);
				}
				return r_REquals_SortVersion;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Globalization.SortVersion, System.Globalization.SortVersion)
		/// </summary>
		protected static RMethod r_Rop_Equality_SortVersion_SortVersion;
		public static RMethod Rop_Equality_SortVersion_SortVersion
		{
			get
			{
				if(r_Rop_Equality_SortVersion_SortVersion == null)
				{
					r_Rop_Equality_SortVersion_SortVersion = new(typeof(System.Globalization.SortVersion), "op_Equality", 0, typeof(System.Globalization.SortVersion), typeof(System.Globalization.SortVersion));
					r_Rop_Equality_SortVersion_SortVersion.SetBelong(null);
				}
				return r_Rop_Equality_SortVersion_SortVersion;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Globalization.SortVersion, System.Globalization.SortVersion)
		/// </summary>
		protected static RMethod r_Rop_Inequality_SortVersion_SortVersion;
		public static RMethod Rop_Inequality_SortVersion_SortVersion
		{
			get
			{
				if(r_Rop_Inequality_SortVersion_SortVersion == null)
				{
					r_Rop_Inequality_SortVersion_SortVersion = new(typeof(System.Globalization.SortVersion), "op_Inequality", 0, typeof(System.Globalization.SortVersion), typeof(System.Globalization.SortVersion));
					r_Rop_Inequality_SortVersion_SortVersion.SetBelong(null);
				}
				return r_Rop_Inequality_SortVersion_SortVersion;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Globalization.SortVersion  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_SortVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Globalization.SortVersion  @left, System.Globalization.SortVersion  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_SortVersion_SortVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Globalization.SortVersion  @left, System.Globalization.SortVersion  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_SortVersion_SortVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
