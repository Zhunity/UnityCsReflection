using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.SortKey
	/// </summary>
    public partial class RSortKey : RMember //
    {

		/// <summary>
		/// System.String source
		/// </summary>
		protected RSystem.RString r_Fsource;
		public virtual RSystem.RString RFsource
		{
			get
			{
				if(r_Fsource == null)
				{
					r_Fsource = new(this, "source");
					r_Fsource.SetBelong(this.instance);
				}
				return r_Fsource;
			}
		}

		/// <summary>
		/// System.Byte[] key
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_Fkey;
		public virtual RFieldArray<RSystem.RByte> RFkey
		{
			get
			{
				if(r_Fkey == null)
				{
					r_Fkey = new(this, "key");
					r_Fkey.SetBelong(this.instance);
				}
				return r_Fkey;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions options
		/// </summary>
		protected RSystem.RGlobalization.RCompareOptions r_Foptions;
		public virtual RSystem.RGlobalization.RCompareOptions RFoptions
		{
			get
			{
				if(r_Foptions == null)
				{
					r_Foptions = new(this, "options");
					r_Foptions.SetBelong(this.instance);
				}
				return r_Foptions;
			}
		}

		/// <summary>
		/// System.Int32 lcid
		/// </summary>
		protected RSystem.RInt32 r_Flcid;
		public virtual RSystem.RInt32 RFlcid
		{
			get
			{
				if(r_Flcid == null)
				{
					r_Flcid = new(this, "lcid");
					r_Flcid.SetBelong(this.instance);
				}
				return r_Flcid;
			}
		}

		/// <summary>
		/// System.String OriginalString
		/// </summary>
		protected RSystem.RString r_POriginalString;
		public virtual RSystem.RString RPOriginalString
		{
			get
			{
				if(r_POriginalString == null)
				{
					r_POriginalString = new(this, "OriginalString", -1);
					r_POriginalString.SetBelong(this.instance);
				}
				return r_POriginalString;
			}
		}

		/// <summary>
		/// Byte[] KeyData
		/// </summary>
		protected RPropertyArray<RSystem.RByte> r_PKeyData;
		public virtual RPropertyArray<RSystem.RByte> RPKeyData
		{
			get
			{
				if(r_PKeyData == null)
				{
					r_PKeyData = new(this, "KeyData", -1);
					r_PKeyData.SetBelong(this.instance);
				}
				return r_PKeyData;
			}
		}

		/// <summary>
		/// Int32 Compare(System.Globalization.SortKey, System.Globalization.SortKey)
		/// </summary>
		protected static RMethod r_MCompare_SortKey_SortKey;
		public static RMethod RMCompare_SortKey_SortKey
		{
			get
			{
				if(r_MCompare_SortKey_SortKey == null)
				{
					r_MCompare_SortKey_SortKey = new(typeof(System.Globalization.SortKey), "Compare", 0, typeof(System.Globalization.SortKey), typeof(System.Globalization.SortKey));
					r_MCompare_SortKey_SortKey.SetBelong(null);
				}
				return r_MCompare_SortKey_SortKey;
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


        public RSortKey() : base("System.Globalization.SortKey")
        {
        }

        public RSortKey(System.Object instance) : base("System.Globalization.SortKey")
		{
            SetInstance(instance);
		}

        public RSortKey(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSortKey(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int32 Compare(System.Globalization.SortKey @sortkey1, System.Globalization.SortKey @sortkey2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sortkey1, @sortkey2};
            var ___result = RMCompare_SortKey_SortKey.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
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
