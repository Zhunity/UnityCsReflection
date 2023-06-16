
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.StyleEnum`1
	/// </summary>
    public partial class RStyleEnum<T> : RMember // where T : struct, System.IConvertible
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
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


		/// <summary>
		/// T m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RField RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
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
				}
				return r_Fm_Keyword;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RProperty RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
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
				}
				return r_Pkeyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleEnum`1[T], UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
		public static RMethod RMop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_
		{
			get
			{
				if(r_Mop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_ == null)
				{
					r_Mop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_ = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1"));
				}
				return r_Mop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleEnum`1[T], UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
		public static RMethod RMop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_
		{
			get
			{
				if(r_Mop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_ == null)
				{
					r_Mop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_ = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1"));
				}
				return r_Mop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[T] op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Mop_Implicit_StyleKeyword;
		public static RMethod RMop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Mop_Implicit_StyleKeyword == null)
				{
					r_Mop_Implicit_StyleKeyword = new(Type, "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
				}
				return r_Mop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleEnum`1[T] op_Implicit(T)
		/// </summary>
		protected static RMethod r_Mop_Implicit_T;
		public static RMethod RMop_Implicit_T
		{
			get
			{
				if(r_Mop_Implicit_T == null)
				{
					r_Mop_Implicit_T = new(Type, "op_Implicit", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_Mop_Implicit_T;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleEnum`1[T])
		/// </summary>
		protected RMethod r_MEquals_StyleEnum_d_T_p_;
		public virtual RMethod RMEquals_StyleEnum_d_T_p_
		{
			get
			{
				if(r_MEquals_StyleEnum_d_T_p_ == null)
				{
					r_MEquals_StyleEnum_d_T_p_ = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleEnum`1"));
				}
				return r_MEquals_StyleEnum_d_T_p_;
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


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_StyleEnum_d_T_p__StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_StyleEnum_d_T_p__StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> op_Implicit(Hvak.Editor.Refleaction.RType @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v.Value};
            var ___result = RMop_Implicit_T.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType>>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RType> @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_StyleEnum_d_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
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
