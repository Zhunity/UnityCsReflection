using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleBackground
	/// </summary>
    public partial class RStyleBackground : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Background m_Value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_m_Value;
		public virtual RUnityEngine.RUIElements.RBackground Rm_Value
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
		/// UnityEngine.UIElements.Background value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_value;
		public virtual RUnityEngine.RUIElements.RBackground Rvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected static RMethod r_Rop_Equality_StyleBackground_StyleBackground;
		public static RMethod Rop_Equality_StyleBackground_StyleBackground
		{
			get
			{
				if(r_Rop_Equality_StyleBackground_StyleBackground == null)
				{
					r_Rop_Equality_StyleBackground_StyleBackground = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleBackground), typeof(UnityEngine.UIElements.StyleBackground));
					r_Rop_Equality_StyleBackground_StyleBackground.SetBelong(null);
				}
				return r_Rop_Equality_StyleBackground_StyleBackground;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected static RMethod r_Rop_Inequality_StyleBackground_StyleBackground;
		public static RMethod Rop_Inequality_StyleBackground_StyleBackground
		{
			get
			{
				if(r_Rop_Inequality_StyleBackground_StyleBackground == null)
				{
					r_Rop_Inequality_StyleBackground_StyleBackground = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleBackground), typeof(UnityEngine.UIElements.StyleBackground));
					r_Rop_Inequality_StyleBackground_StyleBackground.SetBelong(null);
				}
				return r_Rop_Inequality_StyleBackground_StyleBackground;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Rop_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Rop_Implicit_StyleKeyword == null)
				{
					r_Rop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Rop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Rop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.Background)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Background;
		public static RMethod Rop_Implicit_Background
		{
			get
			{
				if(r_Rop_Implicit_Background == null)
				{
					r_Rop_Implicit_Background = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Implicit", 0, typeof(UnityEngine.UIElements.Background));
					r_Rop_Implicit_Background.SetBelong(null);
				}
				return r_Rop_Implicit_Background;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Texture2D;
		public static RMethod Rop_Implicit_Texture2D
		{
			get
			{
				if(r_Rop_Implicit_Texture2D == null)
				{
					r_Rop_Implicit_Texture2D = new(typeof(UnityEngine.UIElements.StyleBackground), "op_Implicit", 0, typeof(UnityEngine.Texture2D));
					r_Rop_Implicit_Texture2D.SetBelong(null);
				}
				return r_Rop_Implicit_Texture2D;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleBackground)
		/// </summary>
		protected RMethod r_REquals_StyleBackground;
		public virtual RMethod REquals_StyleBackground
		{
			get
			{
				if(r_REquals_StyleBackground == null)
				{
					r_REquals_StyleBackground = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleBackground));
					r_REquals_StyleBackground.SetBelong(this.instance);
				}
				return r_REquals_StyleBackground;
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


        public RStyleBackground() : base("UnityEngine.UIElements.StyleBackground")
        {
        }

        public RStyleBackground(System.Object instance) : base("UnityEngine.UIElements.StyleBackground")
		{
            SetInstance(instance);
		}

        public RStyleBackground(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleBackground(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleBackground  @lhs, UnityEngine.UIElements.StyleBackground  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleBackground_StyleBackground.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleBackground  @lhs, UnityEngine.UIElements.StyleBackground  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleBackground_StyleBackground.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.StyleKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackground)___result;
        }


        public static UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.UIElements.Background  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Background.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackground)___result;
        }


        public static UnityEngine.UIElements.StyleBackground op_Implicit(UnityEngine.Texture2D  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackground)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleBackground  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StyleBackground.Invoke(___genericsType, ___parameters);

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
