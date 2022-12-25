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
		protected RMethod r_RMatch_Expression_List_d_StylePropertyValue_p_;
		public virtual RMethod RMatch_Expression_List_d_StylePropertyValue_p_
		{
			get
			{
				if(r_RMatch_Expression_List_d_StylePropertyValue_p_ == null)
				{
					r_RMatch_Expression_List_d_StylePropertyValue_p_ = new(this, "Match", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.Expression"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue")));
					r_RMatch_Expression_List_d_StylePropertyValue_p_.SetBelong(this.instance);
				}
				return r_RMatch_Expression_List_d_StylePropertyValue_p_;
			}
		}

		/// <summary>
		/// Boolean MatchKeyword(System.String)
		/// </summary>
		protected RMethod r_RMatchKeyword_String;
		public virtual RMethod RMatchKeyword_String
		{
			get
			{
				if(r_RMatchKeyword_String == null)
				{
					r_RMatchKeyword_String = new(this, "MatchKeyword", 0, typeof(System.String));
					r_RMatchKeyword_String.SetBelong(this.instance);
				}
				return r_RMatchKeyword_String;
			}
		}

		/// <summary>
		/// Boolean MatchNumber()
		/// </summary>
		protected RMethod r_RMatchNumber;
		public virtual RMethod RMatchNumber
		{
			get
			{
				if(r_RMatchNumber == null)
				{
					r_RMatchNumber = new(this, "MatchNumber", 0);
					r_RMatchNumber.SetBelong(this.instance);
				}
				return r_RMatchNumber;
			}
		}

		/// <summary>
		/// Boolean MatchInteger()
		/// </summary>
		protected RMethod r_RMatchInteger;
		public virtual RMethod RMatchInteger
		{
			get
			{
				if(r_RMatchInteger == null)
				{
					r_RMatchInteger = new(this, "MatchInteger", 0);
					r_RMatchInteger.SetBelong(this.instance);
				}
				return r_RMatchInteger;
			}
		}

		/// <summary>
		/// Boolean MatchLength()
		/// </summary>
		protected RMethod r_RMatchLength;
		public virtual RMethod RMatchLength
		{
			get
			{
				if(r_RMatchLength == null)
				{
					r_RMatchLength = new(this, "MatchLength", 0);
					r_RMatchLength.SetBelong(this.instance);
				}
				return r_RMatchLength;
			}
		}

		/// <summary>
		/// Boolean MatchPercentage()
		/// </summary>
		protected RMethod r_RMatchPercentage;
		public virtual RMethod RMatchPercentage
		{
			get
			{
				if(r_RMatchPercentage == null)
				{
					r_RMatchPercentage = new(this, "MatchPercentage", 0);
					r_RMatchPercentage.SetBelong(this.instance);
				}
				return r_RMatchPercentage;
			}
		}

		/// <summary>
		/// Boolean MatchColor()
		/// </summary>
		protected RMethod r_RMatchColor;
		public virtual RMethod RMatchColor
		{
			get
			{
				if(r_RMatchColor == null)
				{
					r_RMatchColor = new(this, "MatchColor", 0);
					r_RMatchColor.SetBelong(this.instance);
				}
				return r_RMatchColor;
			}
		}

		/// <summary>
		/// Boolean MatchResource()
		/// </summary>
		protected RMethod r_RMatchResource;
		public virtual RMethod RMatchResource
		{
			get
			{
				if(r_RMatchResource == null)
				{
					r_RMatchResource = new(this, "MatchResource", 0);
					r_RMatchResource.SetBelong(this.instance);
				}
				return r_RMatchResource;
			}
		}

		/// <summary>
		/// Boolean MatchUrl()
		/// </summary>
		protected RMethod r_RMatchUrl;
		public virtual RMethod RMatchUrl
		{
			get
			{
				if(r_RMatchUrl == null)
				{
					r_RMatchUrl = new(this, "MatchUrl", 0);
					r_RMatchUrl.SetBelong(this.instance);
				}
				return r_RMatchUrl;
			}
		}

		/// <summary>
		/// Boolean MatchTime()
		/// </summary>
		protected RMethod r_RMatchTime;
		public virtual RMethod RMatchTime
		{
			get
			{
				if(r_RMatchTime == null)
				{
					r_RMatchTime = new(this, "MatchTime", 0);
					r_RMatchTime.SetBelong(this.instance);
				}
				return r_RMatchTime;
			}
		}

		/// <summary>
		/// Boolean MatchCustomIdent()
		/// </summary>
		protected RMethod r_RMatchCustomIdent;
		public virtual RMethod RMatchCustomIdent
		{
			get
			{
				if(r_RMatchCustomIdent == null)
				{
					r_RMatchCustomIdent = new(this, "MatchCustomIdent", 0);
					r_RMatchCustomIdent.SetBelong(this.instance);
				}
				return r_RMatchCustomIdent;
			}
		}

		/// <summary>
		/// Boolean MatchAngle()
		/// </summary>
		protected RMethod r_RMatchAngle;
		public virtual RMethod RMatchAngle
		{
			get
			{
				if(r_RMatchAngle == null)
				{
					r_RMatchAngle = new(this, "MatchAngle", 0);
					r_RMatchAngle.SetBelong(this.instance);
				}
				return r_RMatchAngle;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Void MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// Void SaveContext()
		/// </summary>
		protected RMethod r_RSaveContext;
		public virtual RMethod RSaveContext
		{
			get
			{
				if(r_RSaveContext == null)
				{
					r_RSaveContext = new(this, "SaveContext", 0);
					r_RSaveContext.SetBelong(this.instance);
				}
				return r_RSaveContext;
			}
		}

		/// <summary>
		/// Void RestoreContext()
		/// </summary>
		protected RMethod r_RRestoreContext;
		public virtual RMethod RRestoreContext
		{
			get
			{
				if(r_RRestoreContext == null)
				{
					r_RRestoreContext = new(this, "RestoreContext", 0);
					r_RRestoreContext.SetBelong(this.instance);
				}
				return r_RRestoreContext;
			}
		}

		/// <summary>
		/// Void DropContext()
		/// </summary>
		protected RMethod r_RDropContext;
		public virtual RMethod RDropContext
		{
			get
			{
				if(r_RDropContext == null)
				{
					r_RDropContext = new(this, "DropContext", 0);
					r_RDropContext.SetBelong(this.instance);
				}
				return r_RDropContext;
			}
		}

		/// <summary>
		/// Boolean Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression)
		/// </summary>
		protected RMethod r_RMatch_Expression;
		public virtual RMethod RMatch_Expression
		{
			get
			{
				if(r_RMatch_Expression == null)
				{
					r_RMatch_Expression = new(this, "Match", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.Expression"));
					r_RMatch_Expression.SetBelong(this.instance);
				}
				return r_RMatch_Expression;
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


        public virtual System.Boolean MatchKeyword(System.String  @keyword)
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
