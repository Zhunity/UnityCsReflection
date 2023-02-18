
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser
	/// </summary>
    public partial class RStyleSyntaxParser : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.Syntax.Expression] m_ProcessExpressionList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_Fm_ProcessExpressionList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> RFm_ProcessExpressionList
		{
			get
			{
				if(r_Fm_ProcessExpressionList == null)
				{
					r_Fm_ProcessExpressionList = new(this, "m_ProcessExpressionList");
					r_Fm_ProcessExpressionList.SetBelong(this.GetValue());
				}
				return r_Fm_ProcessExpressionList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.StyleSheets.Syntax.Expression] m_ExpressionStack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_Fm_ExpressionStack;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> RFm_ExpressionStack
		{
			get
			{
				if(r_Fm_ExpressionStack == null)
				{
					r_Fm_ExpressionStack = new(this, "m_ExpressionStack");
					r_Fm_ExpressionStack.SetBelong(this.GetValue());
				}
				return r_Fm_ExpressionStack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Stack`1[UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator] m_CombinatorStack
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionCombinator> r_Fm_CombinatorStack;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RStack<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionCombinator> RFm_CombinatorStack
		{
			get
			{
				if(r_Fm_CombinatorStack == null)
				{
					r_Fm_CombinatorStack = new(this, "m_CombinatorStack");
					r_Fm_CombinatorStack.SetBelong(this.GetValue());
				}
				return r_Fm_CombinatorStack;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.Syntax.Expression] m_ParsedExpressionCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> r_Fm_ParsedExpressionCache;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression> RFm_ParsedExpressionCache
		{
			get
			{
				if(r_Fm_ParsedExpressionCache == null)
				{
					r_Fm_ParsedExpressionCache = new(this, "m_ParsedExpressionCache");
					r_Fm_ParsedExpressionCache.SetBelong(this.GetValue());
				}
				return r_Fm_ParsedExpressionCache;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(System.String)
		/// </summary>
		protected RMethod r_MParse_String;
		public virtual RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(this, "Parse", 0, typeof(System.String));
					r_MParse_String.SetBelong(this.GetValue());
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_MParseExpression_StyleSyntaxTokenizer;
		public virtual RMethod RMParseExpression_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MParseExpression_StyleSyntaxTokenizer == null)
				{
					r_MParseExpression_StyleSyntaxTokenizer = new(this, "ParseExpression", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MParseExpression_StyleSyntaxTokenizer.SetBelong(this.GetValue());
				}
				return r_MParseExpression_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Void ProcessCombinatorStack()
		/// </summary>
		protected RMethod r_MProcessCombinatorStack;
		public virtual RMethod RMProcessCombinatorStack
		{
			get
			{
				if(r_MProcessCombinatorStack == null)
				{
					r_MProcessCombinatorStack = new(this, "ProcessCombinatorStack", 0);
					r_MProcessCombinatorStack.SetBelong(this.GetValue());
				}
				return r_MProcessCombinatorStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_MParseTerm_StyleSyntaxTokenizer;
		public virtual RMethod RMParseTerm_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MParseTerm_StyleSyntaxTokenizer == null)
				{
					r_MParseTerm_StyleSyntaxTokenizer = new(this, "ParseTerm", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MParseTerm_StyleSyntaxTokenizer.SetBelong(this.GetValue());
				}
				return r_MParseTerm_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_MParseCombinatorType_StyleSyntaxTokenizer;
		public virtual RMethod RMParseCombinatorType_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MParseCombinatorType_StyleSyntaxTokenizer == null)
				{
					r_MParseCombinatorType_StyleSyntaxTokenizer = new(this, "ParseCombinatorType", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MParseCombinatorType_StyleSyntaxTokenizer.SetBelong(this.GetValue());
				}
				return r_MParseCombinatorType_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_MParseGroup_StyleSyntaxTokenizer;
		public virtual RMethod RMParseGroup_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MParseGroup_StyleSyntaxTokenizer == null)
				{
					r_MParseGroup_StyleSyntaxTokenizer = new(this, "ParseGroup", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MParseGroup_StyleSyntaxTokenizer.SetBelong(this.GetValue());
				}
				return r_MParseGroup_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_MParseDataType_StyleSyntaxTokenizer;
		public virtual RMethod RMParseDataType_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MParseDataType_StyleSyntaxTokenizer == null)
				{
					r_MParseDataType_StyleSyntaxTokenizer = new(this, "ParseDataType", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MParseDataType_StyleSyntaxTokenizer.SetBelong(this.GetValue());
				}
				return r_MParseDataType_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(System.String)
		/// </summary>
		protected RMethod r_MParseNonTerminalValue_String;
		public virtual RMethod RMParseNonTerminalValue_String
		{
			get
			{
				if(r_MParseNonTerminalValue_String == null)
				{
					r_MParseNonTerminalValue_String = new(this, "ParseNonTerminalValue", 0, typeof(System.String));
					r_MParseNonTerminalValue_String.SetBelong(this.GetValue());
				}
				return r_MParseNonTerminalValue_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_MParseProperty_StyleSyntaxTokenizer;
		public virtual RMethod RMParseProperty_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MParseProperty_StyleSyntaxTokenizer == null)
				{
					r_MParseProperty_StyleSyntaxTokenizer = new(this, "ParseProperty", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MParseProperty_StyleSyntaxTokenizer.SetBelong(this.GetValue());
				}
				return r_MParseProperty_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer, UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier ByRef)
		/// </summary>
		protected RMethod r_MParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier;
		public virtual RMethod RMParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier
		{
			get
			{
				if(r_MParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier == null)
				{
					r_MParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier = new(this, "ParseMultiplier", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier").MakeByRefType());
					r_MParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier.SetBelong(this.GetValue());
				}
				return r_MParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier;
			}
		}

		/// <summary>
		/// Void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32;
		public virtual RMethod RMParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32 == null)
				{
					r_MParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32 = new(this, "ParseRanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32.SetBelong(this.GetValue());
				}
				return r_MParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected static RMethod r_MEatSpace_StyleSyntaxTokenizer;
		public static RMethod RMEatSpace_StyleSyntaxTokenizer
		{
			get
			{
				if(r_MEatSpace_StyleSyntaxTokenizer == null)
				{
					r_MEatSpace_StyleSyntaxTokenizer = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "EatSpace", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_MEatSpace_StyleSyntaxTokenizer.SetBelong(null);
				}
				return r_MEatSpace_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Boolean IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_MIsExpressionEnd_StyleSyntaxToken;
		public static RMethod RMIsExpressionEnd_StyleSyntaxToken
		{
			get
			{
				if(r_MIsExpressionEnd_StyleSyntaxToken == null)
				{
					r_MIsExpressionEnd_StyleSyntaxToken = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsExpressionEnd", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_MIsExpressionEnd_StyleSyntaxToken.SetBelong(null);
				}
				return r_MIsExpressionEnd_StyleSyntaxToken;
			}
		}

		/// <summary>
		/// Boolean IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_MIsCombinator_StyleSyntaxToken;
		public static RMethod RMIsCombinator_StyleSyntaxToken
		{
			get
			{
				if(r_MIsCombinator_StyleSyntaxToken == null)
				{
					r_MIsCombinator_StyleSyntaxToken = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsCombinator", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_MIsCombinator_StyleSyntaxToken.SetBelong(null);
				}
				return r_MIsCombinator_StyleSyntaxToken;
			}
		}

		/// <summary>
		/// Boolean IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_MIsMultiplier_StyleSyntaxToken;
		public static RMethod RMIsMultiplier_StyleSyntaxToken
		{
			get
			{
				if(r_MIsMultiplier_StyleSyntaxToken == null)
				{
					r_MIsMultiplier_StyleSyntaxToken = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsMultiplier", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_MIsMultiplier_StyleSyntaxToken.SetBelong(null);
				}
				return r_MIsMultiplier_StyleSyntaxToken;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression Parse(System.String @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseExpression(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMParseExpression_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual void ProcessCombinatorStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMProcessCombinatorStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseTerm(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMParseTerm_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionCombinator ParseCombinatorType(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMParseCombinatorType_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionCombinator(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseGroup(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMParseGroup_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseDataType(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMParseDataType_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseNonTerminalValue(System.String @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RMParseNonTerminalValue_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseProperty(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMParseProperty_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual void ParseMultiplier(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value, @multiplier.Value};
            var ___result = RMParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier.Invoke(___genericsType, ___parameters);
			@multiplier = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier(___parameters[1]);

            
        }


        public virtual void ParseRanges(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer, out System.Int32 @min, out System.Int32 @max)
        {
			@min = default;
			@max = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value, @min, @max};
            var ___result = RMParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@min = (System.Int32)___parameters[1];
			@max = (System.Int32)___parameters[2];

            
        }


        public static void EatSpace(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RMEatSpace_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsExpressionEnd(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token.Value};
            var ___result = RMIsExpressionEnd_StyleSyntaxToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsCombinator(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token.Value};
            var ___result = RMIsCombinator_StyleSyntaxToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsMultiplier(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token.Value};
            var ___result = RMIsMultiplier_StyleSyntaxToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
