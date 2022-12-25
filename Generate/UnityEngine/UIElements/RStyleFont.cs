using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleFont
	/// </summary>
    public partial class RStyleFont : RMember //
    {

		/// <summary>
		/// UnityEngine.Font m_Value
		/// </summary>
		protected RUnityEngine.RFont r_m_Value;
		public virtual RUnityEngine.RFont Rm_Value
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
		/// UnityEngine.Font value
		/// </summary>
		protected RUnityEngine.RFont r_value;
		public virtual RUnityEngine.RFont Rvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleFont, UnityEngine.UIElements.StyleFont)
		/// </summary>
		protected static RMethod r_Rop_Equality_StyleFont_StyleFont;
		public static RMethod Rop_Equality_StyleFont_StyleFont
		{
			get
			{
				if(r_Rop_Equality_StyleFont_StyleFont == null)
				{
					r_Rop_Equality_StyleFont_StyleFont = new(typeof(UnityEngine.UIElements.StyleFont), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleFont), typeof(UnityEngine.UIElements.StyleFont));
					r_Rop_Equality_StyleFont_StyleFont.SetBelong(null);
				}
				return r_Rop_Equality_StyleFont_StyleFont;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleFont, UnityEngine.UIElements.StyleFont)
		/// </summary>
		protected static RMethod r_Rop_Inequality_StyleFont_StyleFont;
		public static RMethod Rop_Inequality_StyleFont_StyleFont
		{
			get
			{
				if(r_Rop_Inequality_StyleFont_StyleFont == null)
				{
					r_Rop_Inequality_StyleFont_StyleFont = new(typeof(UnityEngine.UIElements.StyleFont), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleFont), typeof(UnityEngine.UIElements.StyleFont));
					r_Rop_Inequality_StyleFont_StyleFont.SetBelong(null);
				}
				return r_Rop_Inequality_StyleFont_StyleFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Rop_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Rop_Implicit_StyleKeyword == null)
				{
					r_Rop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleFont), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Rop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Rop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont op_Implicit(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Font;
		public static RMethod Rop_Implicit_Font
		{
			get
			{
				if(r_Rop_Implicit_Font == null)
				{
					r_Rop_Implicit_Font = new(typeof(UnityEngine.UIElements.StyleFont), "op_Implicit", 0, typeof(UnityEngine.Font));
					r_Rop_Implicit_Font.SetBelong(null);
				}
				return r_Rop_Implicit_Font;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleFont)
		/// </summary>
		protected RMethod r_REquals_StyleFont;
		public virtual RMethod REquals_StyleFont
		{
			get
			{
				if(r_REquals_StyleFont == null)
				{
					r_REquals_StyleFont = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleFont));
					r_REquals_StyleFont.SetBelong(this.instance);
				}
				return r_REquals_StyleFont;
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


        public RStyleFont() : base("UnityEngine.UIElements.StyleFont")
        {
        }

        public RStyleFont(System.Object instance) : base("UnityEngine.UIElements.StyleFont")
		{
            SetInstance(instance);
		}

        public RStyleFont(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleFont(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleFont  @lhs, UnityEngine.UIElements.StyleFont  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleFont_StyleFont.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleFont  @lhs, UnityEngine.UIElements.StyleFont  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleFont_StyleFont.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleFont op_Implicit(UnityEngine.UIElements.StyleKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleFont)___result;
        }


        public static UnityEngine.UIElements.StyleFont op_Implicit(UnityEngine.Font  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Font.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleFont)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleFont  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StyleFont.Invoke(___genericsType, ___parameters);

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
