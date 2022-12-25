using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleBackgroundSize
	/// </summary>
    public partial class RStyleBackgroundSize : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize m_Value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_m_Value;
		public virtual RUnityEngine.RUIElements.RBackgroundSize Rm_Value
		{
			get
			{
				if(r_m_Value == null)
				{
					r_m_Value = new(this, "m_Value");
					r_m_Value.SetBelong(this.instance);
				}
				return r_m_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword m_Keyword
		/// </summary>
		protected RField r_m_Keyword;
		public virtual RField Rm_Keyword
		{
			get
			{
				if(r_m_Keyword == null)
				{
					r_m_Keyword = new(this, "m_Keyword");
					r_m_Keyword.SetBelong(this.instance);
				}
				return r_m_Keyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_value;
		public virtual RUnityEngine.RUIElements.RBackgroundSize Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value", -1);
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleKeyword keyword
		/// </summary>
		protected RProperty r_keyword;
		public virtual RProperty Rkeyword
		{
			get
			{
				if(r_keyword == null)
				{
					r_keyword = new(this, "keyword", -1);
					r_keyword.SetBelong(this.instance);
				}
				return r_keyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected static RMethod r_Rop_Equality_StyleBackgroundSize_StyleBackgroundSize;
		public static RMethod Rop_Equality_StyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_Rop_Equality_StyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_Rop_Equality_StyleBackgroundSize_StyleBackgroundSize = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_Rop_Equality_StyleBackgroundSize_StyleBackgroundSize.SetBelong(null);
				}
				return r_Rop_Equality_StyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected static RMethod r_Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize;
		public static RMethod Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize
		{
			get
			{
				if(r_Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize == null)
				{
					r_Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize), typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize.SetBelong(null);
				}
				return r_Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Rop_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Rop_Implicit_StyleKeyword == null)
				{
					r_Rop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Rop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Rop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected static RMethod r_Rop_Implicit_BackgroundSize;
		public static RMethod Rop_Implicit_BackgroundSize
		{
			get
			{
				if(r_Rop_Implicit_BackgroundSize == null)
				{
					r_Rop_Implicit_BackgroundSize = new(typeof(UnityEngine.UIElements.StyleBackgroundSize), "op_Implicit", 0, typeof(UnityEngine.UIElements.BackgroundSize));
					r_Rop_Implicit_BackgroundSize.SetBelong(null);
				}
				return r_Rop_Implicit_BackgroundSize;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleBackgroundSize)
		/// </summary>
		protected RMethod r_REquals_StyleBackgroundSize;
		public virtual RMethod REquals_StyleBackgroundSize
		{
			get
			{
				if(r_REquals_StyleBackgroundSize == null)
				{
					r_REquals_StyleBackgroundSize = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleBackgroundSize));
					r_REquals_StyleBackgroundSize.SetBelong(this.instance);
				}
				return r_REquals_StyleBackgroundSize;
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

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleBackgroundSize  @lhs, UnityEngine.UIElements.StyleBackgroundSize  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleBackgroundSize  @lhs, UnityEngine.UIElements.StyleBackgroundSize  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleBackgroundSize_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.StyleKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackgroundSize)___result;
        }


        public static UnityEngine.UIElements.StyleBackgroundSize op_Implicit(UnityEngine.UIElements.BackgroundSize  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_BackgroundSize.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackgroundSize)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleBackgroundSize  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StyleBackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
