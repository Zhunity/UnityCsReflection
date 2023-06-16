
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.StyleTransformOrigin
	/// </summary>
    public partial class RStyleTransformOrigin : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.StyleTransformOrigin);
            }
        }

        public RStyleTransformOrigin() : base("UnityEngine.UIElements.StyleTransformOrigin")
        {
        }

        public RStyleTransformOrigin(System.Object instance) : base("UnityEngine.UIElements.StyleTransformOrigin")
		{
            SetInstance(instance);
		}

        public RStyleTransformOrigin(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleTransformOrigin(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin RFm_Value
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
		/// UnityEngine.UIElements.TransformOrigin value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin RPvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleTransformOrigin, UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleTransformOrigin_StyleTransformOrigin;
		public static RMethod RMop_Equality_StyleTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_Mop_Equality_StyleTransformOrigin_StyleTransformOrigin == null)
				{
					r_Mop_Equality_StyleTransformOrigin_StyleTransformOrigin = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin), typeof(UnityEngine.UIElements.StyleTransformOrigin));
				}
				return r_Mop_Equality_StyleTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleTransformOrigin, UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleTransformOrigin_StyleTransformOrigin;
		public static RMethod RMop_Inequality_StyleTransformOrigin_StyleTransformOrigin
		{
			get
			{
				if(r_Mop_Inequality_StyleTransformOrigin_StyleTransformOrigin == null)
				{
					r_Mop_Inequality_StyleTransformOrigin_StyleTransformOrigin = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin), typeof(UnityEngine.UIElements.StyleTransformOrigin));
				}
				return r_Mop_Inequality_StyleTransformOrigin_StyleTransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword)
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
		/// UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.TransformOrigin)
		/// </summary>
		protected static RMethod r_Mop_Implicit_TransformOrigin;
		public static RMethod RMop_Implicit_TransformOrigin
		{
			get
			{
				if(r_Mop_Implicit_TransformOrigin == null)
				{
					r_Mop_Implicit_TransformOrigin = new(Type, "op_Implicit", 0, typeof(UnityEngine.UIElements.TransformOrigin));
				}
				return r_Mop_Implicit_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleTransformOrigin)
		/// </summary>
		protected RMethod r_MEquals_StyleTransformOrigin;
		public virtual RMethod RMEquals_StyleTransformOrigin
		{
			get
			{
				if(r_MEquals_StyleTransformOrigin == null)
				{
					r_MEquals_StyleTransformOrigin = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleTransformOrigin));
				}
				return r_MEquals_StyleTransformOrigin;
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


        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleTransformOrigin @lhs, UnityEngine.UIElements.StyleTransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_StyleTransformOrigin_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleTransformOrigin @lhs, UnityEngine.UIElements.StyleTransformOrigin @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_StyleTransformOrigin_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleTransformOrigin>(___result);
        }


        public static UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.TransformOrigin @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_TransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleTransformOrigin>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleTransformOrigin @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_StyleTransformOrigin.Invoke(___genericsType, ___parameters);

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
