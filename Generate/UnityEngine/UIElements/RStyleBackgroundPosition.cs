using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleBackgroundPosition
	/// </summary>
    public partial class RStyleBackgroundPosition : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition m_Value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_m_Value;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition Rm_Value
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
		/// UnityEngine.UIElements.BackgroundPosition value
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_value;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition Rvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleBackgroundPosition, UnityEngine.UIElements.StyleBackgroundPosition)
		/// </summary>
		protected static RMethod r_op_Equality_StyleBackgroundPosition_StyleBackgroundPosition;
		public static RMethod Rop_Equality_StyleBackgroundPosition_StyleBackgroundPosition
		{
			get
			{
				if(r_op_Equality_StyleBackgroundPosition_StyleBackgroundPosition == null)
				{
					r_op_Equality_StyleBackgroundPosition_StyleBackgroundPosition = new(typeof(UnityEngine.UIElements.StyleBackgroundPosition), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleBackgroundPosition), typeof(UnityEngine.UIElements.StyleBackgroundPosition));
					r_op_Equality_StyleBackgroundPosition_StyleBackgroundPosition.SetBelong(null);
				}
				return r_op_Equality_StyleBackgroundPosition_StyleBackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleBackgroundPosition, UnityEngine.UIElements.StyleBackgroundPosition)
		/// </summary>
		protected static RMethod r_op_Inequality_StyleBackgroundPosition_StyleBackgroundPosition;
		public static RMethod Rop_Inequality_StyleBackgroundPosition_StyleBackgroundPosition
		{
			get
			{
				if(r_op_Inequality_StyleBackgroundPosition_StyleBackgroundPosition == null)
				{
					r_op_Inequality_StyleBackgroundPosition_StyleBackgroundPosition = new(typeof(UnityEngine.UIElements.StyleBackgroundPosition), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleBackgroundPosition), typeof(UnityEngine.UIElements.StyleBackgroundPosition));
					r_op_Inequality_StyleBackgroundPosition_StyleBackgroundPosition.SetBelong(null);
				}
				return r_op_Inequality_StyleBackgroundPosition_StyleBackgroundPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_op_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_op_Implicit_StyleKeyword == null)
				{
					r_op_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleBackgroundPosition), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_op_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_op_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition op_Implicit(UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected static RMethod r_op_Implicit_BackgroundPosition;
		public static RMethod Rop_Implicit_BackgroundPosition
		{
			get
			{
				if(r_op_Implicit_BackgroundPosition == null)
				{
					r_op_Implicit_BackgroundPosition = new(typeof(UnityEngine.UIElements.StyleBackgroundPosition), "op_Implicit", 0, typeof(UnityEngine.UIElements.BackgroundPosition));
					r_op_Implicit_BackgroundPosition.SetBelong(null);
				}
				return r_op_Implicit_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleBackgroundPosition)
		/// </summary>
		protected RMethod r_Equals_StyleBackgroundPosition;
		public virtual RMethod REquals_StyleBackgroundPosition
		{
			get
			{
				if(r_Equals_StyleBackgroundPosition == null)
				{
					r_Equals_StyleBackgroundPosition = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleBackgroundPosition));
					r_Equals_StyleBackgroundPosition.SetBelong(this.instance);
				}
				return r_Equals_StyleBackgroundPosition;
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


        public RStyleBackgroundPosition() : base("UnityEngine.UIElements.StyleBackgroundPosition")
        {
        }

        public RStyleBackgroundPosition(System.Object instance) : base("UnityEngine.UIElements.StyleBackgroundPosition")
		{
            SetInstance(instance);
		}

        public RStyleBackgroundPosition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleBackgroundPosition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleBackgroundPosition @lhs, UnityEngine.UIElements.StyleBackgroundPosition @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleBackgroundPosition_StyleBackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleBackgroundPosition @lhs, UnityEngine.UIElements.StyleBackgroundPosition @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleBackgroundPosition_StyleBackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleBackgroundPosition op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackgroundPosition)___result;
        }


        public static UnityEngine.UIElements.StyleBackgroundPosition op_Implicit(UnityEngine.UIElements.BackgroundPosition @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_BackgroundPosition.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleBackgroundPosition)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleBackgroundPosition @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StyleBackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
