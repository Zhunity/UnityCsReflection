using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.Expression
	/// </summary>
    public partial class RExpression : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier r_multiplier;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier Rmultiplier
		{
			get
			{
				if(r_multiplier == null)
				{
					r_multiplier = new(this, "multiplier");
					r_multiplier.SetBelong(this.instance);
				}
				return r_multiplier;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType
		/// </summary>
		protected RField r_dataType;
		public virtual RField RdataType
		{
			get
			{
				if(r_dataType == null)
				{
					r_dataType = new(this, "dataType");
					r_dataType.SetBelong(this.instance);
				}
				return r_dataType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator combinator
		/// </summary>
		protected RField r_combinator;
		public virtual RField Rcombinator
		{
			get
			{
				if(r_combinator == null)
				{
					r_combinator = new(this, "combinator");
					r_combinator.SetBelong(this.instance);
				}
				return r_combinator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression[] subExpressions
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_subExpressions;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> RsubExpressions
		{
			get
			{
				if(r_subExpressions == null)
				{
					r_subExpressions = new(this, "subExpressions");
					r_subExpressions.SetBelong(this.instance);
				}
				return r_subExpressions;
			}
		}

		/// <summary>
		/// System.String keyword
		/// </summary>
		protected RField r_keyword;
		public virtual RField Rkeyword
		{
			get
			{
				if(r_keyword == null)
				{
					r_keyword = new(this, "keyword");
					r_keyword.SetBelong(this.instance);
				}
				return r_keyword;
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


        public RExpression() : base("UnityEngine.UIElements.StyleSheets.Syntax.Expression")
        {
        }

        public RExpression(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.Syntax.Expression")
		{
            SetInstance(instance);
		}

        public RExpression(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExpression(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
