
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Globalization.SortKey
	/// </summary>
    public partial class RSortKey : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Globalization.SortKey);
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


		/// <summary>
		/// System.String source
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fsource;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsource
		{
			get
			{
				if(r_Fsource == null)
				{
					r_Fsource = new(this, "source");
				}
				return r_Fsource;
			}
		}

		/// <summary>
		/// System.Byte[] key
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fkey;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFkey
		{
			get
			{
				if(r_Fkey == null)
				{
					r_Fkey = new(this, "key");
				}
				return r_Fkey;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions options
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions r_Foptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions RFoptions
		{
			get
			{
				if(r_Foptions == null)
				{
					r_Foptions = new(this, "options");
				}
				return r_Foptions;
			}
		}

		/// <summary>
		/// System.Int32 lcid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Flcid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlcid
		{
			get
			{
				if(r_Flcid == null)
				{
					r_Flcid = new(this, "lcid");
				}
				return r_Flcid;
			}
		}

		/// <summary>
		/// System.String OriginalString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_POriginalString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPOriginalString
		{
			get
			{
				if(r_POriginalString == null)
				{
					r_POriginalString = new(this, "OriginalString", -1);
				}
				return r_POriginalString;
			}
		}

		/// <summary>
		/// Byte[] KeyData
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PKeyData;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPKeyData
		{
			get
			{
				if(r_PKeyData == null)
				{
					r_PKeyData = new(this, "KeyData", -1);
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
					r_MCompare_SortKey_SortKey = new(Type, "Compare", 0, typeof(System.Globalization.SortKey), typeof(System.Globalization.SortKey));
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


        public static System.Int32 Compare(System.Globalization.SortKey @sortkey1, System.Globalization.SortKey @sortkey2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sortkey1, @sortkey2};
            var ___result = RMCompare_SortKey_SortKey.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
