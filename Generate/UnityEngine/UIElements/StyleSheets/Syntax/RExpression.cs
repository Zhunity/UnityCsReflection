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

        public virtual System.Boolean Equals(System.Object @obj)
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
