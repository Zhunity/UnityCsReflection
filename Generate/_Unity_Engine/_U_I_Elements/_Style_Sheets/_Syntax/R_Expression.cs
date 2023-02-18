
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.Expression
	/// </summary>
    public partial class RExpression : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionType r_Ftype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier r_Fmultiplier;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier RFmultiplier
		{
			get
			{
				if(r_Fmultiplier == null)
				{
					r_Fmultiplier = new(this, "multiplier");
				}
				return r_Fmultiplier;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RDataType r_FdataType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RDataType RFdataType
		{
			get
			{
				if(r_FdataType == null)
				{
					r_FdataType = new(this, "dataType");
				}
				return r_FdataType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator combinator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionCombinator r_Fcombinator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionCombinator RFcombinator
		{
			get
			{
				if(r_Fcombinator == null)
				{
					r_Fcombinator = new(this, "combinator");
				}
				return r_Fcombinator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression[] subExpressions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_FsubExpressions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> RFsubExpressions
		{
			get
			{
				if(r_FsubExpressions == null)
				{
					r_FsubExpressions = new(this, "subExpressions");
				}
				return r_FsubExpressions;
			}
		}

		/// <summary>
		/// System.String keyword
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fkeyword;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFkeyword
		{
			get
			{
				if(r_Fkeyword == null)
				{
					r_Fkeyword = new(this, "keyword");
				}
				return r_Fkeyword;
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
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
