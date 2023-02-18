
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleBackgroundSize
	/// </summary>
    public partial class RStyleBackgroundSize : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
					r_Fm_Value.SetBelong(this.GetValue());
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword m_Keyword
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleKeyword r_Fm_Keyword;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleKeyword RFm_Keyword
		{
			get
			{
				if(r_Fm_Keyword == null)
				{
					r_Fm_Keyword = new(this, "m_Keyword");
					r_Fm_Keyword.SetBelong(this.GetValue());
				}
				return r_Fm_Keyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.GetValue());
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword keyword
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleKeyword r_Pkeyword;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleKeyword RPkeyword
		{
			get
			{
				if(r_Pkeyword == null)
				{
					r_Pkeyword = new(this, "keyword", -1);
					r_Pkeyword.SetBelong(this.GetValue());
				}
				return r_Pkeyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleBackgroundSize_StyleBackgroundSize;
		public static RMethod RMop_Equality_StyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_Mop_Equality_StyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_Mop_Equality_StyleBackgroundSize_StyleBackgroundSize = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_Mop_Equality_StyleBackgroundSize_StyleBackgroundSize.SetBelong(null);
				}
				return r_Mop_Equality_StyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleBackgroundSize_StyleBackgroundSize;
		public static RMethod RMop_Inequality_StyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_Mop_Inequality_StyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_Mop_Inequality_StyleBackgroundSize_StyleBackgroundSize = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_Mop_Inequality_StyleBackgroundSize_StyleBackgroundSize.SetBelong(null);
				}
				return r_Mop_Inequality_StyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Mop_Implicit_StyleKeyword;
		public static RMethod RMop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Mop_Implicit_StyleKeyword == null)
				{
					r_Mop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Mop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Mop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected static RMethod r_Mop_Implicit_BackgroundSize;
		public static RMethod RMop_Implicit_BackgroundSize
		{
			get
			{
				if(r_Mop_Implicit_BackgroundSize == null)
				{
					r_Mop_Implicit_BackgroundSize = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Implicit", 0, typeof(UnityEngine.UIElements.BackgroundSize));
					r_Mop_Implicit_BackgroundSize.SetBelong(null);
				}
				return r_Mop_Implicit_BackgroundSize;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_MEquals_StyleBackgroundSize;
		public virtual RMethod RMEquals_StyleBackgroundSize
		{
			get
			{
				if(r_MEquals_StyleBackgroundSize == null)
				{
					r_MEquals_StyleBackgroundSize = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_MEquals_StyleBackgroundSize.SetBelong(this.GetValue());
				}
				return r_MEquals_StyleBackgroundSize;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RStyleBackgroundSize() : base("UnityEngine.UIElements.StyleBackgroundSize")
        {
        }

        public RStyleBackgroundSize(System.Object instance) : base("UnityEngine.UIElements.StyleBackgroundSize")
		{
            SetInstance(instance);
		}

        public RStyleBackgroundSize(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleBackgroundSize(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleBackgroundSize @lhs, UnityEngine.UIElements.StyleBackgroundSize @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_StyleBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleBackgroundSize @lhs, UnityEngine.UIElements.StyleBackgroundSize @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_StyleBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackgroundSize)___result;
        }


        public static UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.BackgroundSize @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_BackgroundSize.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackgroundSize)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleBackgroundSize @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
