using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.KeySizes
	/// </summary>
    public partial class RKeySizes : RMember //
    {

		/// <summary>
		/// System.Int32 m_minSize
		/// </summary>
		protected RField r_m_minSize;
		public virtual RField Rm_minSize
		{
			get
			{
				if(r_m_minSize == null)
				{
					r_m_minSize = new(this, "m_minSize");
					r_m_minSize.SetBelong(this.instance);
				}
				return r_m_minSize;
			}
		}

		/// <summary>
		/// System.Int32 m_maxSize
		/// </summary>
		protected RField r_m_maxSize;
		public virtual RField Rm_maxSize
		{
			get
			{
				if(r_m_maxSize == null)
				{
					r_m_maxSize = new(this, "m_maxSize");
					r_m_maxSize.SetBelong(this.instance);
				}
				return r_m_maxSize;
			}
		}

		/// <summary>
		/// System.Int32 m_skipSize
		/// </summary>
		protected RField r_m_skipSize;
		public virtual RField Rm_skipSize
		{
			get
			{
				if(r_m_skipSize == null)
				{
					r_m_skipSize = new(this, "m_skipSize");
					r_m_skipSize.SetBelong(this.instance);
				}
				return r_m_skipSize;
			}
		}

		/// <summary>
		/// Int32 MinSize
		/// </summary>
		protected RProperty r_MinSize;
		public virtual RProperty RMinSize
		{
			get
			{
				if(r_MinSize == null)
				{
					r_MinSize = new(this, "MinSize", -1);
					r_MinSize.SetBelong(this.instance);
				}
				return r_MinSize;
			}
		}

		/// <summary>
		/// Int32 MaxSize
		/// </summary>
		protected RProperty r_MaxSize;
		public virtual RProperty RMaxSize
		{
			get
			{
				if(r_MaxSize == null)
				{
					r_MaxSize = new(this, "MaxSize", -1);
					r_MaxSize.SetBelong(this.instance);
				}
				return r_MaxSize;
			}
		}

		/// <summary>
		/// Int32 SkipSize
		/// </summary>
		protected RProperty r_SkipSize;
		public virtual RProperty RSkipSize
		{
			get
			{
				if(r_SkipSize == null)
				{
					r_SkipSize = new(this, "SkipSize", -1);
					r_SkipSize.SetBelong(this.instance);
				}
				return r_SkipSize;
			}
		}

		/// <summary>
		/// Boolean IsLegal(Int32)
		/// </summary>
		protected RMethod r_RIsLegal_Int32;
		public virtual RMethod RIsLegal_Int32
		{
			get
			{
				if(r_RIsLegal_Int32 == null)
				{
					r_RIsLegal_Int32 = new(this, "IsLegal", 0, typeof(System.Int32));
					r_RIsLegal_Int32.SetBelong(this.instance);
				}
				return r_RIsLegal_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLegalKeySize(System.Security.Cryptography.KeySizes[], Int32)
		/// </summary>
		protected static RMethod r_RIsLegalKeySize_KeySizesArray_Int32;
		public static RMethod RIsLegalKeySize_KeySizesArray_Int32
		{
			get
			{
				if(r_RIsLegalKeySize_KeySizesArray_Int32 == null)
				{
					r_RIsLegalKeySize_KeySizesArray_Int32 = new(typeof(System.Security.Cryptography.KeySizes), "IsLegalKeySize", 0, typeof(System.Security.Cryptography.KeySizes).MakeArrayType(), typeof(System.Int32));
					r_RIsLegalKeySize_KeySizesArray_Int32.SetBelong(null);
				}
				return r_RIsLegalKeySize_KeySizesArray_Int32;
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


        public RKeySizes() : base("System.Security.Cryptography.KeySizes")
        {
        }

        public RKeySizes(System.Object instance) : base("System.Security.Cryptography.KeySizes")
		{
            SetInstance(instance);
		}

        public RKeySizes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeySizes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsLegal(System.Int32  @keySize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keySize};
            var ___result = RIsLegal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLegalKeySize(System.Security.Cryptography.KeySizes[]  @legalKeys, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@legalKeys, @size};
            var ___result = RIsLegalKeySize_KeySizesArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
