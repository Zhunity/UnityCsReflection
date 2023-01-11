using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleEnum`1
	/// </summary>
    public partial class RStyleEnum<T> : RMember // where T : struct, System.IConvertible
    {

		/// <summary>
		/// T m_Value
		/// </summary>
		protected RField r_m_Value;
		public virtual RField Rm_Value
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
		/// T value
		/// </summary>
		protected RProperty r_value;
		public virtual RProperty Rvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleEnum`1[T], UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected static RMethod r_op_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
		public static RMethod Rop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_
		{
			get
			{
				if(r_op_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_ == null)
				{
					r_op_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_ = new(typeof(UnityEngine.UIElements.StyleEnum<>), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleEnum<>), typeof(UnityEngine.UIElements.StyleEnum<>));
					r_op_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_.SetBelong(null);
				}
				return r_op_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleEnum`1[T], UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected static RMethod r_op_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
		public static RMethod Rop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_
		{
			get
			{
				if(r_op_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_ == null)
				{
					r_op_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_ = new(typeof(UnityEngine.UIElements.StyleEnum<>), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleEnum<>), typeof(UnityEngine.UIElements.StyleEnum<>));
					r_op_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_.SetBelong(null);
				}
				return r_op_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[T] op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_op_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_op_Implicit_StyleKeyword == null)
				{
					r_op_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleEnum<>), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_op_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_op_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[T] op_Implicit(T)
		/// </summary>
		protected static RMethod r_op_Implicit_T;
		public static RMethod Rop_Implicit_T
		{
			get
			{
				if(r_op_Implicit_T == null)
				{
					r_op_Implicit_T = new(typeof(UnityEngine.UIElements.StyleEnum<>), "op_Implicit", 0, Type.MakeGenericMethodParameter(0));
					r_op_Implicit_T.SetBelong(null);
				}
				return r_op_Implicit_T;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected RMethod r_Equals_StyleEnum_d_T_p_;
		public virtual RMethod REquals_StyleEnum_d_T_p_
		{
			get
			{
				if(r_Equals_StyleEnum_d_T_p_ == null)
				{
					r_Equals_StyleEnum_d_T_p_ = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleEnum<>));
					r_Equals_StyleEnum_d_T_p_.SetBelong(this.instance);
				}
				return r_Equals_StyleEnum_d_T_p_;
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


        public RStyleEnum() : base("UnityEngine.UIElements.StyleEnum`1")
        {
        }

        public RStyleEnum(System.Object instance) : base("UnityEngine.UIElements.StyleEnum`1")
		{
            SetInstance(instance);
		}

        public RStyleEnum(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleEnum(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(RUnityEngine.RUIElements.RStyleEnum<RType> @lhs, RUnityEngine.RUIElements.RStyleEnum<RType> @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = Rop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RUnityEngine.RUIElements.RStyleEnum<RType> @lhs, RUnityEngine.RUIElements.RStyleEnum<RType> @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = Rop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static RUnityEngine.RUIElements.RStyleEnum<RType> op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleEnum<RType>(___result);
        }


        public static RUnityEngine.RUIElements.RStyleEnum<RType> op_Implicit(RType @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v.Value};
            var ___result = Rop_Implicit_T.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleEnum<RType>(___result);
        }


        public virtual System.Boolean Equals(RUnityEngine.RUIElements.RStyleEnum<RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

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
