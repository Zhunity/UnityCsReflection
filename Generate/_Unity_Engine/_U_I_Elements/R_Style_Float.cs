
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.StyleFloat
	/// </summary>
    public partial class RStyleFloat : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.StyleFloat);
            }
        }

        public RStyleFloat() : base("UnityEngine.UIElements.StyleFloat")
        {
        }

        public RStyleFloat(System.Object instance) : base("UnityEngine.UIElements.StyleFloat")
		{
            SetInstance(instance);
		}

        public RStyleFloat(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleFloat(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Single m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Value
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
		/// Single value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleFloat, UnityEngine.UIElements.StyleFloat)
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleFloat_StyleFloat;
		public static RMethod RMop_Equality_StyleFloat_StyleFloat
		{
			get
			{
				if(r_Mop_Equality_StyleFloat_StyleFloat == null)
				{
					r_Mop_Equality_StyleFloat_StyleFloat = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.StyleFloat), typeof(UnityEngine.UIElements.StyleFloat));
				}
				return r_Mop_Equality_StyleFloat_StyleFloat;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleFloat, UnityEngine.UIElements.StyleFloat)
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleFloat_StyleFloat;
		public static RMethod RMop_Inequality_StyleFloat_StyleFloat
		{
			get
			{
				if(r_Mop_Inequality_StyleFloat_StyleFloat == null)
				{
					r_Mop_Inequality_StyleFloat_StyleFloat = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleFloat), typeof(UnityEngine.UIElements.StyleFloat));
				}
				return r_Mop_Inequality_StyleFloat_StyleFloat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword)
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
		/// UnityEngine.UIElements.StyleFloat op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Single;
		public static RMethod RMop_Implicit_Single
		{
			get
			{
				if(r_Mop_Implicit_Single == null)
				{
					r_Mop_Implicit_Single = new(Type, "op_Implicit", 0, typeof(System.Single));
				}
				return r_Mop_Implicit_Single;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleFloat)
		/// </summary>
		protected RMethod r_MEquals_StyleFloat;
		public virtual RMethod RMEquals_StyleFloat
		{
			get
			{
				if(r_MEquals_StyleFloat == null)
				{
					r_MEquals_StyleFloat = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleFloat));
				}
				return r_MEquals_StyleFloat;
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


        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleFloat @lhs, UnityEngine.UIElements.StyleFloat @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_StyleFloat_StyleFloat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleFloat @lhs, UnityEngine.UIElements.StyleFloat @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_StyleFloat_StyleFloat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFloat>(___result);
        }


        public static UnityEngine.UIElements.StyleFloat op_Implicit(System.Single @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFloat>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleFloat @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_StyleFloat.Invoke(___genericsType, ___parameters);

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
