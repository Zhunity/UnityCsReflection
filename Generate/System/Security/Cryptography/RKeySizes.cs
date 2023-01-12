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
		protected RSystem.RInt32 r_Fm_minSize;
		public virtual RSystem.RInt32 RFm_minSize
		{
			get
			{
				if(r_Fm_minSize == null)
				{
					r_Fm_minSize = new(this, "m_minSize");
					r_Fm_minSize.SetBelong(this.instance);
				}
				return r_Fm_minSize;
			}
		}

		/// <summary>
		/// System.Int32 m_maxSize
		/// </summary>
		protected RSystem.RInt32 r_Fm_maxSize;
		public virtual RSystem.RInt32 RFm_maxSize
		{
			get
			{
				if(r_Fm_maxSize == null)
				{
					r_Fm_maxSize = new(this, "m_maxSize");
					r_Fm_maxSize.SetBelong(this.instance);
				}
				return r_Fm_maxSize;
			}
		}

		/// <summary>
		/// System.Int32 m_skipSize
		/// </summary>
		protected RSystem.RInt32 r_Fm_skipSize;
		public virtual RSystem.RInt32 RFm_skipSize
		{
			get
			{
				if(r_Fm_skipSize == null)
				{
					r_Fm_skipSize = new(this, "m_skipSize");
					r_Fm_skipSize.SetBelong(this.instance);
				}
				return r_Fm_skipSize;
			}
		}

		/// <summary>
		/// Int32 MinSize
		/// </summary>
		protected RSystem.RInt32 r_PMinSize;
		public virtual RSystem.RInt32 RPMinSize
		{
			get
			{
				if(r_PMinSize == null)
				{
					r_PMinSize = new(this, "MinSize", -1);
					r_PMinSize.SetBelong(this.instance);
				}
				return r_PMinSize;
			}
		}

		/// <summary>
		/// Int32 MaxSize
		/// </summary>
		protected RSystem.RInt32 r_PMaxSize;
		public virtual RSystem.RInt32 RPMaxSize
		{
			get
			{
				if(r_PMaxSize == null)
				{
					r_PMaxSize = new(this, "MaxSize", -1);
					r_PMaxSize.SetBelong(this.instance);
				}
				return r_PMaxSize;
			}
		}

		/// <summary>
		/// Int32 SkipSize
		/// </summary>
		protected RSystem.RInt32 r_PSkipSize;
		public virtual RSystem.RInt32 RPSkipSize
		{
			get
			{
				if(r_PSkipSize == null)
				{
					r_PSkipSize = new(this, "SkipSize", -1);
					r_PSkipSize.SetBelong(this.instance);
				}
				return r_PSkipSize;
			}
		}

		/// <summary>
		/// Boolean IsLegal(Int32)
		/// </summary>
		protected RMethod r_MIsLegal_Int32;
		public virtual RMethod RMIsLegal_Int32
		{
			get
			{
				if(r_MIsLegal_Int32 == null)
				{
					r_MIsLegal_Int32 = new(this, "IsLegal", 0, typeof(System.Int32));
					r_MIsLegal_Int32.SetBelong(this.instance);
				}
				return r_MIsLegal_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLegalKeySize(System.Security.Cryptography.KeySizes[], Int32)
		/// </summary>
		protected static RMethod r_MIsLegalKeySize_KeySizesArray_Int32;
		public static RMethod RMIsLegalKeySize_KeySizesArray_Int32
		{
			get
			{
				if(r_MIsLegalKeySize_KeySizesArray_Int32 == null)
				{
					r_MIsLegalKeySize_KeySizesArray_Int32 = new(typeof(System.Security.Cryptography.KeySizes), "IsLegalKeySize", 0, typeof(System.Security.Cryptography.KeySizes).MakeArrayType(), typeof(System.Int32));
					r_MIsLegalKeySize_KeySizesArray_Int32.SetBelong(null);
				}
				return r_MIsLegalKeySize_KeySizesArray_Int32;
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

        public virtual System.Boolean IsLegal(System.Int32 @keySize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keySize};
            var ___result = RMIsLegal_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLegalKeySize(System.Security.Cryptography.KeySizes[] @legalKeys, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@legalKeys, @size};
            var ___result = RMIsLegalKeySize_KeySizesArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
