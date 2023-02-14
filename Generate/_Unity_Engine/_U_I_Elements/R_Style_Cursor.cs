
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleCursor
	/// </summary>
    public partial class RStyleCursor : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Cursor m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
					r_Fm_Value.SetBelong(this.instance);
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
					r_Fm_Keyword.SetBelong(this.instance);
				}
				return r_Fm_Keyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Cursor value
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
					r_Pvalue.SetBelong(this.instance);
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
					r_Pkeyword.SetBelong(this.instance);
				}
				return r_Pkeyword;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StyleCursor, UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected static RMethod r_Mop_Equality_StyleCursor_StyleCursor;
		public static RMethod RMop_Equality_StyleCursor_StyleCursor
		{
			get
			{
				if(r_Mop_Equality_StyleCursor_StyleCursor == null)
				{
					r_Mop_Equality_StyleCursor_StyleCursor = new(typeof(UnityEngine.UIElements.StyleCursor), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleCursor), typeof(UnityEngine.UIElements.StyleCursor));
					r_Mop_Equality_StyleCursor_StyleCursor.SetBelong(null);
				}
				return r_Mop_Equality_StyleCursor_StyleCursor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleCursor, UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected static RMethod r_Mop_Inequality_StyleCursor_StyleCursor;
		public static RMethod RMop_Inequality_StyleCursor_StyleCursor
		{
			get
			{
				if(r_Mop_Inequality_StyleCursor_StyleCursor == null)
				{
					r_Mop_Inequality_StyleCursor_StyleCursor = new(typeof(UnityEngine.UIElements.StyleCursor), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleCursor), typeof(UnityEngine.UIElements.StyleCursor));
					r_Mop_Inequality_StyleCursor_StyleCursor.SetBelong(null);
				}
				return r_Mop_Inequality_StyleCursor_StyleCursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Mop_Implicit_StyleKeyword;
		public static RMethod RMop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Mop_Implicit_StyleKeyword == null)
				{
					r_Mop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleCursor), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Mop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Mop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.Cursor)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Cursor;
		public static RMethod RMop_Implicit_Cursor
		{
			get
			{
				if(r_Mop_Implicit_Cursor == null)
				{
					r_Mop_Implicit_Cursor = new(typeof(UnityEngine.UIElements.StyleCursor), "op_Implicit", 0, typeof(UnityEngine.UIElements.Cursor));
					r_Mop_Implicit_Cursor.SetBelong(null);
				}
				return r_Mop_Implicit_Cursor;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleCursor)
		/// </summary>
		protected RMethod r_MEquals_StyleCursor;
		public virtual RMethod RMEquals_StyleCursor
		{
			get
			{
				if(r_MEquals_StyleCursor == null)
				{
					r_MEquals_StyleCursor = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleCursor));
					r_MEquals_StyleCursor.SetBelong(this.instance);
				}
				return r_MEquals_StyleCursor;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RStyleCursor() : base("UnityEngine.UIElements.StyleCursor")
        {
        }

        public RStyleCursor(System.Object instance) : base("UnityEngine.UIElements.StyleCursor")
		{
            SetInstance(instance);
		}

        public RStyleCursor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleCursor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleCursor @lhs, UnityEngine.UIElements.StyleCursor @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_StyleCursor_StyleCursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleCursor @lhs, UnityEngine.UIElements.StyleCursor @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_StyleCursor_StyleCursor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleCursor)___result;
        }


        public static UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.Cursor @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Cursor.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleCursor)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleCursor @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_StyleCursor.Invoke(___genericsType, ___parameters);

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
