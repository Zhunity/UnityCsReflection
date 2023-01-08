using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher
	/// </summary>
    public partial class RStylePropertyValueMatcher : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_m_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> Rm_Values
		{
			get
			{
				if(r_m_Values == null)
				{
					r_m_Values = new(this, "m_Values");
					r_m_Values.SetBelong(this.instance);
				}
				return r_m_Values;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValue current
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue r_current;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new(this, "current", -1);
					r_current.SetBelong(this.instance);
				}
				return r_current;
			}
		}

		/// <summary>
		/// Int32 valueCount
		/// </summary>
		protected RProperty r_valueCount;
		public virtual RProperty RvalueCount
		{
			get
			{
				if(r_valueCount == null)
				{
					r_valueCount = new(this, "valueCount", -1);
					r_valueCount.SetBelong(this.instance);
				}
				return r_valueCount;
			}
		}

		/// <summary>
		/// Boolean isCurrentVariable
		/// </summary>
		protected RProperty r_isCurrentVariable;
		public virtual RProperty RisCurrentVariable
		{
			get
			{
				if(r_isCurrentVariable == null)
				{
					r_isCurrentVariable = new(this, "isCurrentVariable", -1);
					r_isCurrentVariable.SetBelong(this.instance);
				}
				return r_isCurrentVariable;
			}
		}

		/// <summary>
		/// Boolean isCurrentComma
		/// </summary>
		protected RProperty r_isCurrentComma;
		public virtual RProperty RisCurrentComma
		{
			get
			{
				if(r_isCurrentComma == null)
				{
					r_isCurrentComma = new(this, "isCurrentComma", -1);
					r_isCurrentComma.SetBelong(this.instance);
				}
				return r_isCurrentComma;
			}
		}

		/// <summary>
		/// Boolean hasCurrent
		/// </summary>
		protected RProperty r_hasCurrent;
		public virtual RProperty RhasCurrent
		{
			get
			{
				if(r_hasCurrent == null)
				{
					r_hasCurrent = new(this, "hasCurrent", -1);
					r_hasCurrent.SetBelong(this.instance);
				}
				return r_hasCurrent;
			}
		}

		/// <summary>
		/// Int32 currentIndex
		/// </summary>
		protected RProperty r_currentIndex;
		public virtual RProperty RcurrentIndex
		{
			get
			{
				if(r_currentIndex == null)
				{
					r_currentIndex = new(this, "currentIndex", -1);
					r_currentIndex.SetBelong(this.instance);
				}
				return r_currentIndex;
			}
		}

		/// <summary>
		/// Int32 matchedVariableCount
		/// </summary>
		protected RProperty r_matchedVariableCount;
		public virtual RProperty RmatchedVariableCount
		{
			get
			{
				if(r_matchedVariableCount == null)
				{
					r_matchedVariableCount = new(this, "matchedVariableCount", -1);
					r_matchedVariableCount.SetBelong(this.instance);
				}
				return r_matchedVariableCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression, System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue])
		/// </summary>
		protected RMethod r_Match_Expression_List_d_StylePropertyValue_p_;
		public virtual RMethod RMatch_Expression_List_d_StylePropertyValue_p_
		{
			get
			{
				if(r_Match_Expression_List_d_StylePropertyValue_p_ == null)
				{
					r_Match_Expression_List_d_StylePropertyValue_p_ = new(this, "Match", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.Expression"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue")));
					r_Match_Expression_List_d_StylePropertyValue_p_.SetBelong(this.instance);
				}
				return r_Match_Expression_List_d_StylePropertyValue_p_;
			}
		}

		/// <summary>
		/// Boolean MatchKeyword(System.String)
		/// </summary>
		protected RMethod r_MatchKeyword_String;
		public virtual RMethod RMatchKeyword_String
		{
			get
			{
				if(r_MatchKeyword_String == null)
				{
					r_MatchKeyword_String = new(this, "MatchKeyword", 0, typeof(System.String));
					r_MatchKeyword_String.SetBelong(this.instance);
				}
				return r_MatchKeyword_String;
			}
		}

		/// <summary>
		/// Boolean MatchNumber()
		/// </summary>
		protected RMethod r_MatchNumber;
		public virtual RMethod RMatchNumber
		{
			get
			{
				if(r_MatchNumber == null)
				{
					r_MatchNumber = new(this, "MatchNumber", 0);
					r_MatchNumber.SetBelong(this.instance);
				}
				return r_MatchNumber;
			}
		}

		/// <summary>
		/// Boolean MatchInteger()
		/// </summary>
		protected RMethod r_MatchInteger;
		public virtual RMethod RMatchInteger
		{
			get
			{
				if(r_MatchInteger == null)
				{
					r_MatchInteger = new(this, "MatchInteger", 0);
					r_MatchInteger.SetBelong(this.instance);
				}
				return r_MatchInteger;
			}
		}

		/// <summary>
		/// Boolean MatchLength()
		/// </summary>
		protected RMethod r_MatchLength;
		public virtual RMethod RMatchLength
		{
			get
			{
				if(r_MatchLength == null)
				{
					r_MatchLength = new(this, "MatchLength", 0);
					r_MatchLength.SetBelong(this.instance);
				}
				return r_MatchLength;
			}
		}

		/// <summary>
		/// Boolean MatchPercentage()
		/// </summary>
		protected RMethod r_MatchPercentage;
		public virtual RMethod RMatchPercentage
		{
			get
			{
				if(r_MatchPercentage == null)
				{
					r_MatchPercentage = new(this, "MatchPercentage", 0);
					r_MatchPercentage.SetBelong(this.instance);
				}
				return r_MatchPercentage;
			}
		}

		/// <summary>
		/// Boolean MatchColor()
		/// </summary>
		protected RMethod r_MatchColor;
		public virtual RMethod RMatchColor
		{
			get
			{
				if(r_MatchColor == null)
				{
					r_MatchColor = new(this, "MatchColor", 0);
					r_MatchColor.SetBelong(this.instance);
				}
				return r_MatchColor;
			}
		}

		/// <summary>
		/// Boolean MatchResource()
		/// </summary>
		protected RMethod r_MatchResource;
		public virtual RMethod RMatchResource
		{
			get
			{
				if(r_MatchResource == null)
				{
					r_MatchResource = new(this, "MatchResource", 0);
					r_MatchResource.SetBelong(this.instance);
				}
				return r_MatchResource;
			}
		}

		/// <summary>
		/// Boolean MatchUrl()
		/// </summary>
		protected RMethod r_MatchUrl;
		public virtual RMethod RMatchUrl
		{
			get
			{
				if(r_MatchUrl == null)
				{
					r_MatchUrl = new(this, "MatchUrl", 0);
					r_MatchUrl.SetBelong(this.instance);
				}
				return r_MatchUrl;
			}
		}

		/// <summary>
		/// Boolean MatchTime()
		/// </summary>
		protected RMethod r_MatchTime;
		public virtual RMethod RMatchTime
		{
			get
			{
				if(r_MatchTime == null)
				{
					r_MatchTime = new(this, "MatchTime", 0);
					r_MatchTime.SetBelong(this.instance);
				}
				return r_MatchTime;
			}
		}

		/// <summary>
		/// Boolean MatchCustomIdent()
		/// </summary>
		protected RMethod r_MatchCustomIdent;
		public virtual RMethod RMatchCustomIdent
		{
			get
			{
				if(r_MatchCustomIdent == null)
				{
					r_MatchCustomIdent = new(this, "MatchCustomIdent", 0);
					r_MatchCustomIdent.SetBelong(this.instance);
				}
				return r_MatchCustomIdent;
			}
		}

		/// <summary>
		/// Boolean MatchAngle()
		/// </summary>
		protected RMethod r_MatchAngle;
		public virtual RMethod RMatchAngle
		{
			get
			{
				if(r_MatchAngle == null)
				{
					r_MatchAngle = new(this, "MatchAngle", 0);
					r_MatchAngle.SetBelong(this.instance);
				}
				return r_MatchAngle;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_Initialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_Initialize == null)
				{
					r_Initialize = new(this, "Initialize", 0);
					r_Initialize.SetBelong(this.instance);
				}
				return r_Initialize;
			}
		}

		/// <summary>
		/// Void MoveNext()
		/// </summary>
		protected RMethod r_MoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_MoveNext == null)
				{
					r_MoveNext = new(this, "MoveNext", 0);
					r_MoveNext.SetBelong(this.instance);
				}
				return r_MoveNext;
			}
		}

		/// <summary>
		/// Void SaveContext()
		/// </summary>
		protected RMethod r_SaveContext;
		public virtual RMethod RSaveContext
		{
			get
			{
				if(r_SaveContext == null)
				{
					r_SaveContext = new(this, "SaveContext", 0);
					r_SaveContext.SetBelong(this.instance);
				}
				return r_SaveContext;
			}
		}

		/// <summary>
		/// Void RestoreContext()
		/// </summary>
		protected RMethod r_RestoreContext;
		public virtual RMethod RRestoreContext
		{
			get
			{
				if(r_RestoreContext == null)
				{
					r_RestoreContext = new(this, "RestoreContext", 0);
					r_RestoreContext.SetBelong(this.instance);
				}
				return r_RestoreContext;
			}
		}

		/// <summary>
		/// Void DropContext()
		/// </summary>
		protected RMethod r_DropContext;
		public virtual RMethod RDropContext
		{
			get
			{
				if(r_DropContext == null)
				{
					r_DropContext = new(this, "DropContext", 0);
					r_DropContext.SetBelong(this.instance);
				}
				return r_DropContext;
			}
		}

		/// <summary>
		/// Boolean Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression)
		/// </summary>
		protected RMethod r_Match_Expression;
		public virtual RMethod RMatch_Expression
		{
			get
			{
				if(r_Match_Expression == null)
				{
					r_Match_Expression = new(this, "Match", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.Expression"));
					r_Match_Expression.SetBelong(this.instance);
				}
				return r_Match_Expression;
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


        public RStylePropertyValueMatcher() : base("UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher")
        {
        }

        public RStylePropertyValueMatcher(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher")
		{
            SetInstance(instance);
		}

        public RStylePropertyValueMatcher(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStylePropertyValueMatcher(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RUnityEngine.RUIElements.RStyleSheets.RMatchResult Match(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression @exp, RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exp.Value, @values.Value};
            var ___result = RMatch_Expression_List_d_StylePropertyValue_p_.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RMatchResult(___result);
        }


        public virtual System.Boolean MatchKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMatchKeyword_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchNumber.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchInteger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchInteger.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchLength()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchLength.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchPercentage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchPercentage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchColor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchColor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchUrl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchUrl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchCustomIdent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchCustomIdent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchAngle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMatchAngle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DropContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDropContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Match(RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression @exp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exp.Value};
            var ___result = RMatch_Expression.Invoke(___genericsType, ___parameters);

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
