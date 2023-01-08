using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleColor
	/// </summary>
    public partial class RStyleColor : RMember //
    {

		/// <summary>
		/// UnityEngine.Color m_Value
		/// </summary>
		protected RUnityEngine.RColor r_m_Value;
		public virtual RUnityEngine.RColor Rm_Value
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
		/// UnityEngine.Color value
		/// </summary>
		protected RUnityEngine.RColor r_value;
		public virtual RUnityEngine.RColor Rvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleColor, UnityEngine.UIElements.StyleColor)
		/// </summary>
		protected static RMethod r_op_Equality_StyleColor_StyleColor;
		public static RMethod Rop_Equality_StyleColor_StyleColor
		{
			get
			{
				if(r_op_Equality_StyleColor_StyleColor == null)
				{
					r_op_Equality_StyleColor_StyleColor = new(typeof(UnityEngine.UIElements.StyleColor), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleColor), typeof(UnityEngine.UIElements.StyleColor));
					r_op_Equality_StyleColor_StyleColor.SetBelong(null);
				}
				return r_op_Equality_StyleColor_StyleColor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleColor, UnityEngine.UIElements.StyleColor)
		/// </summary>
		protected static RMethod r_op_Inequality_StyleColor_StyleColor;
		public static RMethod Rop_Inequality_StyleColor_StyleColor
		{
			get
			{
				if(r_op_Inequality_StyleColor_StyleColor == null)
				{
					r_op_Inequality_StyleColor_StyleColor = new(typeof(UnityEngine.UIElements.StyleColor), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleColor), typeof(UnityEngine.UIElements.StyleColor));
					r_op_Inequality_StyleColor_StyleColor.SetBelong(null);
				}
				return r_op_Inequality_StyleColor_StyleColor;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleColor, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_op_Equality_StyleColor_Color;
		public static RMethod Rop_Equality_StyleColor_Color
		{
			get
			{
				if(r_op_Equality_StyleColor_Color == null)
				{
					r_op_Equality_StyleColor_Color = new(typeof(UnityEngine.UIElements.StyleColor), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleColor), typeof(UnityEngine.Color));
					r_op_Equality_StyleColor_Color.SetBelong(null);
				}
				return r_op_Equality_StyleColor_Color;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleColor, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_op_Inequality_StyleColor_Color;
		public static RMethod Rop_Inequality_StyleColor_Color
		{
			get
			{
				if(r_op_Inequality_StyleColor_Color == null)
				{
					r_op_Inequality_StyleColor_Color = new(typeof(UnityEngine.UIElements.StyleColor), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleColor), typeof(UnityEngine.Color));
					r_op_Inequality_StyleColor_Color.SetBelong(null);
				}
				return r_op_Inequality_StyleColor_Color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_op_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_op_Implicit_StyleKeyword == null)
				{
					r_op_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleColor), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_op_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_op_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color)
		/// </summary>
		protected static RMethod r_op_Implicit_Color;
		public static RMethod Rop_Implicit_Color
		{
			get
			{
				if(r_op_Implicit_Color == null)
				{
					r_op_Implicit_Color = new(typeof(UnityEngine.UIElements.StyleColor), "op_Implicit", 0, typeof(UnityEngine.Color));
					r_op_Implicit_Color.SetBelong(null);
				}
				return r_op_Implicit_Color;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleColor)
		/// </summary>
		protected RMethod r_Equals_StyleColor;
		public virtual RMethod REquals_StyleColor
		{
			get
			{
				if(r_Equals_StyleColor == null)
				{
					r_Equals_StyleColor = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleColor));
					r_Equals_StyleColor.SetBelong(this.instance);
				}
				return r_Equals_StyleColor;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RStyleColor() : base("UnityEngine.UIElements.StyleColor")
        {
        }

        public RStyleColor(System.Object instance) : base("UnityEngine.UIElements.StyleColor")
		{
            SetInstance(instance);
		}

        public RStyleColor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleColor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleColor  @lhs, UnityEngine.UIElements.StyleColor  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleColor_StyleColor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleColor  @lhs, UnityEngine.UIElements.StyleColor  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleColor_StyleColor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleColor  @lhs, UnityEngine.Color  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleColor_Color.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleColor  @lhs, UnityEngine.Color  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleColor_Color.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.UIElements.StyleKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleColor)___result;
        }


        public static UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleColor)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleColor  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StyleColor.Invoke(___genericsType, ___parameters);

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
