using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleLength
	/// </summary>
    public partial class RStyleLength : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Length m_Value
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_m_Value;
		public virtual RUnityEngine.RUIElements.RLength Rm_Value
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
		/// UnityEngine.UIElements.Length value
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_value;
		public virtual RUnityEngine.RUIElements.RLength Rvalue
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
		/// Boolean op_Equality(UnityEngine.UIElements.StyleLength, UnityEngine.UIElements.StyleLength)
		/// </summary>
		protected static RMethod r_Rop_Equality_StyleLength_StyleLength;
		public static RMethod Rop_Equality_StyleLength_StyleLength
		{
			get
			{
				if(r_Rop_Equality_StyleLength_StyleLength == null)
				{
					r_Rop_Equality_StyleLength_StyleLength = new(typeof(UnityEngine.UIElements.StyleLength), "op_Equality", 0, typeof(UnityEngine.UIElements.StyleLength), typeof(UnityEngine.UIElements.StyleLength));
					r_Rop_Equality_StyleLength_StyleLength.SetBelong(null);
				}
				return r_Rop_Equality_StyleLength_StyleLength;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StyleLength, UnityEngine.UIElements.StyleLength)
		/// </summary>
		protected static RMethod r_Rop_Inequality_StyleLength_StyleLength;
		public static RMethod Rop_Inequality_StyleLength_StyleLength
		{
			get
			{
				if(r_Rop_Inequality_StyleLength_StyleLength == null)
				{
					r_Rop_Inequality_StyleLength_StyleLength = new(typeof(UnityEngine.UIElements.StyleLength), "op_Inequality", 0, typeof(UnityEngine.UIElements.StyleLength), typeof(UnityEngine.UIElements.StyleLength));
					r_Rop_Inequality_StyleLength_StyleLength.SetBelong(null);
				}
				return r_Rop_Inequality_StyleLength_StyleLength;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword)
		/// </summary>
		protected static RMethod r_Rop_Implicit_StyleKeyword;
		public static RMethod Rop_Implicit_StyleKeyword
		{
			get
			{
				if(r_Rop_Implicit_StyleKeyword == null)
				{
					r_Rop_Implicit_StyleKeyword = new(typeof(UnityEngine.UIElements.StyleLength), "op_Implicit", 0, typeof(UnityEngine.UIElements.StyleKeyword));
					r_Rop_Implicit_StyleKeyword.SetBelong(null);
				}
				return r_Rop_Implicit_StyleKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength op_Implicit(Single)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Single;
		public static RMethod Rop_Implicit_Single
		{
			get
			{
				if(r_Rop_Implicit_Single == null)
				{
					r_Rop_Implicit_Single = new(typeof(UnityEngine.UIElements.StyleLength), "op_Implicit", 0, typeof(System.Single));
					r_Rop_Implicit_Single.SetBelong(null);
				}
				return r_Rop_Implicit_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.Length)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Length;
		public static RMethod Rop_Implicit_Length
		{
			get
			{
				if(r_Rop_Implicit_Length == null)
				{
					r_Rop_Implicit_Length = new(typeof(UnityEngine.UIElements.StyleLength), "op_Implicit", 0, typeof(UnityEngine.UIElements.Length));
					r_Rop_Implicit_Length.SetBelong(null);
				}
				return r_Rop_Implicit_Length;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StyleLength)
		/// </summary>
		protected RMethod r_REquals_StyleLength;
		public virtual RMethod REquals_StyleLength
		{
			get
			{
				if(r_REquals_StyleLength == null)
				{
					r_REquals_StyleLength = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StyleLength));
					r_REquals_StyleLength.SetBelong(this.instance);
				}
				return r_REquals_StyleLength;
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


        public RStyleLength() : base("UnityEngine.UIElements.StyleLength")
        {
        }

        public RStyleLength(System.Object instance) : base("UnityEngine.UIElements.StyleLength")
		{
            SetInstance(instance);
		}

        public RStyleLength(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleLength(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(UnityEngine.UIElements.StyleLength  @lhs, UnityEngine.UIElements.StyleLength  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StyleLength_StyleLength.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StyleLength  @lhs, UnityEngine.UIElements.StyleLength  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StyleLength_StyleLength.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = Rop_Implicit_StyleKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleLength)___result;
        }


        public static UnityEngine.UIElements.StyleLength op_Implicit(System.Single  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleLength)___result;
        }


        public static UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.Length  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Length.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleLength)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StyleLength  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StyleLength.Invoke(___genericsType, ___parameters);

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