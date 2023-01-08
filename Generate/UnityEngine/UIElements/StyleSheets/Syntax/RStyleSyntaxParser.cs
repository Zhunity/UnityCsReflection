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
		protected RMethod r_Parse_String;
		public virtual RMethod RParse_String
		{
			get
			{
				if(r_Parse_String == null)
				{
					r_Parse_String = new(this, "Parse", 0, typeof(System.String));
					r_Parse_String.SetBelong(this.instance);
				}
				return r_Parse_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_ParseExpression_StyleSyntaxTokenizer;
		public virtual RMethod RParseExpression_StyleSyntaxTokenizer
		{
			get
			{
				if(r_ParseExpression_StyleSyntaxTokenizer == null)
				{
					r_ParseExpression_StyleSyntaxTokenizer = new(this, "ParseExpression", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_ParseExpression_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_ParseExpression_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Void ProcessCombinatorStack()
		/// </summary>
		protected RMethod r_ProcessCombinatorStack;
		public virtual RMethod RProcessCombinatorStack
		{
			get
			{
				if(r_ProcessCombinatorStack == null)
				{
					r_ProcessCombinatorStack = new(this, "ProcessCombinatorStack", 0);
					r_ProcessCombinatorStack.SetBelong(this.instance);
				}
				return r_ProcessCombinatorStack;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_ParseTerm_StyleSyntaxTokenizer;
		public virtual RMethod RParseTerm_StyleSyntaxTokenizer
		{
			get
			{
				if(r_ParseTerm_StyleSyntaxTokenizer == null)
				{
					r_ParseTerm_StyleSyntaxTokenizer = new(this, "ParseTerm", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_ParseTerm_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_ParseTerm_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_ParseCombinatorType_StyleSyntaxTokenizer;
		public virtual RMethod RParseCombinatorType_StyleSyntaxTokenizer
		{
			get
			{
				if(r_ParseCombinatorType_StyleSyntaxTokenizer == null)
				{
					r_ParseCombinatorType_StyleSyntaxTokenizer = new(this, "ParseCombinatorType", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_ParseCombinatorType_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_ParseCombinatorType_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_ParseGroup_StyleSyntaxTokenizer;
		public virtual RMethod RParseGroup_StyleSyntaxTokenizer
		{
			get
			{
				if(r_ParseGroup_StyleSyntaxTokenizer == null)
				{
					r_ParseGroup_StyleSyntaxTokenizer = new(this, "ParseGroup", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_ParseGroup_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_ParseGroup_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_ParseDataType_StyleSyntaxTokenizer;
		public virtual RMethod RParseDataType_StyleSyntaxTokenizer
		{
			get
			{
				if(r_ParseDataType_StyleSyntaxTokenizer == null)
				{
					r_ParseDataType_StyleSyntaxTokenizer = new(this, "ParseDataType", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_ParseDataType_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_ParseDataType_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(System.String)
		/// </summary>
		protected RMethod r_ParseNonTerminalValue_String;
		public virtual RMethod RParseNonTerminalValue_String
		{
			get
			{
				if(r_ParseNonTerminalValue_String == null)
				{
					r_ParseNonTerminalValue_String = new(this, "ParseNonTerminalValue", 0, typeof(System.String));
					r_ParseNonTerminalValue_String.SetBelong(this.instance);
				}
				return r_ParseNonTerminalValue_String;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected RMethod r_ParseProperty_StyleSyntaxTokenizer;
		public virtual RMethod RParseProperty_StyleSyntaxTokenizer
		{
			get
			{
				if(r_ParseProperty_StyleSyntaxTokenizer == null)
				{
					r_ParseProperty_StyleSyntaxTokenizer = new(this, "ParseProperty", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_ParseProperty_StyleSyntaxTokenizer.SetBelong(this.instance);
				}
				return r_ParseProperty_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer, UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier ByRef)
		/// </summary>
		protected RMethod r_ParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier;
		public virtual RMethod RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier
		{
			get
			{
				if(r_ParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier == null)
				{
					r_ParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier = new(this, "ParseMultiplier", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier").MakeByRefType());
					r_ParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier.SetBelong(this.instance);
				}
				return r_ParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier;
			}
		}

		/// <summary>
		/// Void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_ParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32;
		public virtual RMethod RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32
		{
			get
			{
				if(r_ParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32 == null)
				{
					r_ParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32 = new(this, "ParseRanges", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_ParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_ParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer)
		/// </summary>
		protected static RMethod r_EatSpace_StyleSyntaxTokenizer;
		public static RMethod REatSpace_StyleSyntaxTokenizer
		{
			get
			{
				if(r_EatSpace_StyleSyntaxTokenizer == null)
				{
					r_EatSpace_StyleSyntaxTokenizer = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "EatSpace", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"));
					r_EatSpace_StyleSyntaxTokenizer.SetBelong(null);
				}
				return r_EatSpace_StyleSyntaxTokenizer;
			}
		}

		/// <summary>
		/// Boolean IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_IsExpressionEnd_StyleSyntaxToken;
		public static RMethod RIsExpressionEnd_StyleSyntaxToken
		{
			get
			{
				if(r_IsExpressionEnd_StyleSyntaxToken == null)
				{
					r_IsExpressionEnd_StyleSyntaxToken = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsExpressionEnd", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_IsExpressionEnd_StyleSyntaxToken.SetBelong(null);
				}
				return r_IsExpressionEnd_StyleSyntaxToken;
			}
		}

		/// <summary>
		/// Boolean IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_IsCombinator_StyleSyntaxToken;
		public static RMethod RIsCombinator_StyleSyntaxToken
		{
			get
			{
				if(r_IsCombinator_StyleSyntaxToken == null)
				{
					r_IsCombinator_StyleSyntaxToken = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsCombinator", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_IsCombinator_StyleSyntaxToken.SetBelong(null);
				}
				return r_IsCombinator_StyleSyntaxToken;
			}
		}

		/// <summary>
		/// Boolean IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken)
		/// </summary>
		protected static RMethod r_IsMultiplier_StyleSyntaxToken;
		public static RMethod RIsMultiplier_StyleSyntaxToken
		{
			get
			{
				if(r_IsMultiplier_StyleSyntaxToken == null)
				{
					r_IsMultiplier_StyleSyntaxToken = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser"), "IsMultiplier", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken"));
					r_IsMultiplier_StyleSyntaxToken.SetBelong(null);
				}
				return r_IsMultiplier_StyleSyntaxToken;
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

        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression Parse(System.String @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseExpression(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RParseExpression_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual void ProcessCombinatorStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProcessCombinatorStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseTerm(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RParseTerm_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual RType ParseCombinatorType(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RParseCombinatorType_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseGroup(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RParseGroup_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseDataType(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RParseDataType_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseNonTerminalValue(System.String @syntax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@syntax};
            var ___result = RParseNonTerminalValue_String.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression ParseProperty(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = RParseProperty_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression(___result);
        }


        public virtual void ParseMultiplier(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer, ref RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier @multiplier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value, @multiplier.Value};
            var ___result = RParseMultiplier_StyleSyntaxTokenizer_Ref_ExpressionMultiplier.Invoke(___genericsType, ___parameters);
			@multiplier = new RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplier(___parameters[1]);

            
        }


        public virtual void ParseRanges(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer, out System.Int32 @min, out System.Int32 @max)
        {
			@min = default;
			@max = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value, @min, @max};
            var ___result = RParseRanges_StyleSyntaxTokenizer_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@min = (System.Int32)___parameters[1];
			@max = (System.Int32)___parameters[2];

            
        }


        public static void EatSpace(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxTokenizer @tokenizer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenizer.Value};
            var ___result = REatSpace_StyleSyntaxTokenizer.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsExpressionEnd(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token.Value};
            var ___result = RIsExpressionEnd_StyleSyntaxToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsCombinator(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token.Value};
            var ___result = RIsCombinator_StyleSyntaxToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsMultiplier(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RStyleSyntaxToken @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token.Value};
            var ___result = RIsMultiplier_StyleSyntaxToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
