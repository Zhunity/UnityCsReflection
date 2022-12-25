using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser
	/// </summary>
    public partial class RStyleSyntaxParser : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.Syntax.Expression] m_ProcessExpressionList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_m_ProcessExpressionList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> Rm_ProcessExpressionList
		{
			get
			{
				if(r_m_ProcessExpressionList == null)
				{
					r_m_ProcessExpressionList = new(this, "m_ProcessExpressionList");
					r_m_ProcessExpressionList.SetBelong(this.instance);
				}
				return r_m_ProcessExpressionList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.StyleSheets.Syntax.Expression] m_ExpressionStack
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_m_ExpressionStack;
		public virtual RSystem.RCollections.RGeneric.RStack<RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> Rm_ExpressionStack
		{
			get
			{
				if(r_m_ExpressionStack == null)
				{
					r_m_ExpressionStack = new(this, "m_ExpressionStack");
					r_m_ExpressionStack.SetBelong(this.instance);
				}
				return r_m_ExpressionStack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator] m_CombinatorStack
		/// </summary>
		protected RSystem.RCollections.RGeneric.RStack<RField> r_m_CombinatorStack;
		public virtual RSystem.RCollections.RGeneric.RStack<RField> Rm_CombinatorStack
		{
			get
			{
				if(r_m_CombinatorStack == null)
				{
					r_m_CombinatorStack = new(this, "m_CombinatorStack");
					r_m_CombinatorStack.SetBelong(this.instance);
				}
				return r_m_CombinatorStack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.Syntax.Expression] m_ParsedExpressionCache
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_m_ParsedExpressionCache;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> Rm_ParsedExpressionCache
		{
			get
			{
				if(r_m_ParsedExpressionCache == null)
				{
					r_m_ParsedExpressionCache = new(this, "m_ParsedExpressionCache");
					r_m_ParsedExpressionCache.SetBelong(this.instance);
				}
				return r_m_ParsedExpressionCache;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(System.String)
		/// </summary>
		protected RMethod r_RParse_String;
		public virtual RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(this, "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(this.instance);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_RParseExpression_StyleSyntaxTokenizer;
		public virtual RMethod RParseExpression_StyleSyntaxTokenizer
		{
			get
			{
				if(r_RParseExpression_StyleSyntaxTokenizer == null)
				{
					r_RParseExpression_StyleSyntaxTokenizer = new(this, "ParseExpression", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_RParseExpression_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_RParseExpression_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Void ProcessCombinatorStack()
		/// </summary>
		protected RMethod r_RProcessCombinatorStack;
		public virtual RMethod RProcessCombinatorStack
		{
			get
			{
				if(r_RProcessCombinatorStack == null)
				{
					r_RProcessCombinatorStack = new(this, "ProcessCombinatorStack", 0);
					r_RProcessCombinatorStack.SetBelong(this.instance);
				}
				return r_RProcessCombinatorStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_RParseTerm_StyleSyntaxTokenizer;
		public virtual RMethod RParseTerm_StyleSyntaxTokenizer
		{
			get
			{
				if(r_RParseTerm_StyleSyntaxTokenizer == null)
				{
					r_RParseTerm_StyleSyntaxTokenizer = new(this, "ParseTerm", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_RParseTerm_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_RParseTerm_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_RParseCombinatorType_StyleSyntaxTokenizer;
		public virtual RMethod RParseCombinatorType_StyleSyntaxTokenizer
		{
			get
			{
				if(r_RParseCombinatorType_StyleSyntaxTokenizer == null)
				{
					r_RParseCombinatorType_StyleSyntaxTokenizer = new(this, "ParseCombinatorType", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_RParseCombinatorType_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_RParseCombinatorType_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_RParseGroup_StyleSyntaxTokenizer;
		public virtual RMethod RParseGroup_StyleSyntaxTokenizer
		{
			get
			{
				if(r_RParseGroup_StyleSyntaxTokenizer == null)
				{
					r_RParseGroup_StyleSyntaxTokenizer = new(this, "ParseGroup", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_RParseGroup_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_RParseGroup_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_RParseDataType_StyleSyntaxTokenizer;
		public virtual RMethod RParseDataType_StyleSyntaxTokenizer
		{
			get
			{
				if(r_RParseDataType_StyleSyntaxTokenizer == null)
				{
					r_RParseDataType_StyleSyntaxTokenizer = new(this, "ParseDataType", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_RParseDataType_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_RParseDataType_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(System.String)
		/// </summary>
		protected RMethod r_RParseNonTerminalValue_String;
		public virtual RMethod RParseNonTerminalValue_String
		{
			get
			{
				if(r_RParseNonTerminalValue_String == null)
				{
					r_RParseNonTerminalValue_String = new(this, "ParseNonTerminalValue", 0, typeof(System.String));
					r_RParseNonTerminalValue_String.SetBelong(this.instance);
				}
				return r_RParseNonTerminalValue_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_RParseProperty_StyleSyntaxTokenizer;
		public virtual RMethod RParseProperty_StyleSyntaxTokenizer
		{
			get
			{
				if(r_RParseProperty_StyleSyntaxTokenizer == null)
				{
					r_RParseProperty_StyleSyntaxTokenizer = new(this, "ParseProperty", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_RParseProperty_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_RParseProperty_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer, UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier ByRef)
		/// </summary>
		protected RMethod r_RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier;
		public virtual RMethod RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier
		{
			get
			{
				if(r_RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier == null)
				{
					r_RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier = new(this, "ParseMultiplier", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier").MakeByRefType());
					r_RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier.SetBelong(this.instance);
				}
				return r_RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier;
			}
		}

		/// <summary>
		/// Void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32;
		public virtual RMethod RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32
		{
			get
			{
				if(r_RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32 == null)
				{
					r_RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32 = new(this, "ParseRanges", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected static RMethod r_REatSpace_StyleSyntaxTokenizer;
		public static RMethod REatSpace_StyleSyntaxTokenizer
		{
			get
			{
				if(r_REatSpace_StyleSyntaxTokenizer == null)
				{
					r_REatSpace_StyleSyntaxTokenizer = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "EatSpace", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_REatSpace_StyleSyntaxTokenizer.SetBelong(null);
				}
				return r_REatSpace_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Boolean IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_RIsExpressionEnd_StyleSyntaxToken;
		public static RMethod RIsExpressionEnd_StyleSyntaxToken
		{
			get
			{
				if(r_RIsExpressionEnd_StyleSyntaxToken == null)
				{
					r_RIsExpressionEnd_StyleSyntaxToken = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsExpressionEnd", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_RIsExpressionEnd_StyleSyntaxToken.SetBelong(null);
				}
				return r_RIsExpressionEnd_StyleSyntaxToken;
			}
		}

		/// <summary>
		/// Boolean IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_RIsCombinator_StyleSyntaxToken;
		public static RMethod RIsCombinator_StyleSyntaxToken
		{
			get
			{
				if(r_RIsCombinator_StyleSyntaxToken == null)
				{
					r_RIsCombinator_StyleSyntaxToken = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsCombinator", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_RIsCombinator_StyleSyntaxToken.SetBelong(null);
				}
				return r_RIsCombinator_StyleSyntaxToken;
			}
		}

		/// <summary>
		/// Boolean IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_RIsMultiplier_StyleSyntaxToken;
		public static RMethod RIsMultiplier_StyleSyntaxToken
		{
			get
			{
				if(r_RIsMultiplier_StyleSyntaxToken == null)
				{
					r_RIsMultiplier_StyleSyntaxToken = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsMultiplier", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_RIsMultiplier_StyleSyntaxToken.SetBelong(null);
				}
				return r_RIsMultiplier_StyleSyntaxToken;
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


        public RStyleSyntaxParser() : base("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser")
        {
        }

        public RStyleSyntaxParser(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser")
		{
            SetInstance(instance);
		}

        public RStyleSyntaxParser(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleSyntaxParser(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Parse(System.String  @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void ProcessCombinatorStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessCombinatorStack.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.Object ParseNonTerminalValue(System.String  @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RParseNonTerminalValue_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
