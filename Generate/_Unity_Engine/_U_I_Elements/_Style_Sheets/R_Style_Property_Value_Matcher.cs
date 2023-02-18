
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher
	/// </summary>
    public partial class RStylePropertyValueMatcher : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_Fm_Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RFm_Values
		{
			get
			{
				if(r_Fm_Values == null)
				{
					r_Fm_Values = new(this, "m_Values");
				}
				return r_Fm_Values;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValue current
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue r_Pcurrent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue RPcurrent
		{
			get
			{
				if(r_Pcurrent == null)
				{
					r_Pcurrent = new(this, "current", -1);
				}
				return r_Pcurrent;
			}
		}

		/// <summary>
		/// Int32 valueCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvalueCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvalueCount
		{
			get
			{
				if(r_PvalueCount == null)
				{
					r_PvalueCount = new(this, "valueCount", -1);
				}
				return r_PvalueCount;
			}
		}

		/// <summary>
		/// Boolean isCurrentVariable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCurrentVariable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCurrentVariable
		{
			get
			{
				if(r_PisCurrentVariable == null)
				{
					r_PisCurrentVariable = new(this, "isCurrentVariable", -1);
				}
				return r_PisCurrentVariable;
			}
		}

		/// <summary>
		/// Boolean isCurrentComma
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCurrentComma;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCurrentComma
		{
			get
			{
				if(r_PisCurrentComma == null)
				{
					r_PisCurrentComma = new(this, "isCurrentComma", -1);
				}
				return r_PisCurrentComma;
			}
		}

		/// <summary>
		/// Boolean hasCurrent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasCurrent;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasCurrent
		{
			get
			{
				if(r_PhasCurrent == null)
				{
					r_PhasCurrent = new(this, "hasCurrent", -1);
				}
				return r_PhasCurrent;
			}
		}

		/// <summary>
		/// Int32 currentIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcurrentIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcurrentIndex
		{
			get
			{
				if(r_PcurrentIndex == null)
				{
					r_PcurrentIndex = new(this, "currentIndex", -1);
				}
				return r_PcurrentIndex;
			}
		}

		/// <summary>
		/// Int32 matchedVariableCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmatchedVariableCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmatchedVariableCount
		{
			get
			{
				if(r_PmatchedVariableCount == null)
				{
					r_PmatchedVariableCount = new(this, "matchedVariableCount", -1);
				}
				return r_PmatchedVariableCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression, System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue])
		/// </summary>
		protected RMethod r_MMatch_Expression_List_d_StylePropertyValue_p_;
		public virtual RMethod RMMatch_Expression_List_d_StylePropertyValue_p_
		{
			get
			{
				if(r_MMatch_Expression_List_d_StylePropertyValue_p_ == null)
				{
					r_MMatch_Expression_List_d_StylePropertyValue_p_ = new(this, "Match", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.Expression"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue")));
				}
				return r_MMatch_Expression_List_d_StylePropertyValue_p_;
			}
		}

		/// <summary>
		/// Boolean MatchKeyword(System.String)
		/// </summary>
		protected RMethod r_MMatchKeyword_String;
		public virtual RMethod RMMatchKeyword_String
		{
			get
			{
				if(r_MMatchKeyword_String == null)
				{
					r_MMatchKeyword_String = new(this, "MatchKeyword", 0, typeof(System.String));
				}
				return r_MMatchKeyword_String;
			}
		}

		/// <summary>
		/// Boolean MatchNumber()
		/// </summary>
		protected RMethod r_MMatchNumber;
		public virtual RMethod RMMatchNumber
		{
			get
			{
				if(r_MMatchNumber == null)
				{
					r_MMatchNumber = new(this, "MatchNumber", 0);
				}
				return r_MMatchNumber;
			}
		}

		/// <summary>
		/// Boolean MatchInteger()
		/// </summary>
		protected RMethod r_MMatchInteger;
		public virtual RMethod RMMatchInteger
		{
			get
			{
				if(r_MMatchInteger == null)
				{
					r_MMatchInteger = new(this, "MatchInteger", 0);
				}
				return r_MMatchInteger;
			}
		}

		/// <summary>
		/// Boolean MatchLength()
		/// </summary>
		protected RMethod r_MMatchLength;
		public virtual RMethod RMMatchLength
		{
			get
			{
				if(r_MMatchLength == null)
				{
					r_MMatchLength = new(this, "MatchLength", 0);
				}
				return r_MMatchLength;
			}
		}

		/// <summary>
		/// Boolean MatchPercentage()
		/// </summary>
		protected RMethod r_MMatchPercentage;
		public virtual RMethod RMMatchPercentage
		{
			get
			{
				if(r_MMatchPercentage == null)
				{
					r_MMatchPercentage = new(this, "MatchPercentage", 0);
				}
				return r_MMatchPercentage;
			}
		}

		/// <summary>
		/// Boolean MatchColor()
		/// </summary>
		protected RMethod r_MMatchColor;
		public virtual RMethod RMMatchColor
		{
			get
			{
				if(r_MMatchColor == null)
				{
					r_MMatchColor = new(this, "MatchColor", 0);
				}
				return r_MMatchColor;
			}
		}

		/// <summary>
		/// Boolean MatchResource()
		/// </summary>
		protected RMethod r_MMatchResource;
		public virtual RMethod RMMatchResource
		{
			get
			{
				if(r_MMatchResource == null)
				{
					r_MMatchResource = new(this, "MatchResource", 0);
				}
				return r_MMatchResource;
			}
		}

		/// <summary>
		/// Boolean MatchUrl()
		/// </summary>
		protected RMethod r_MMatchUrl;
		public virtual RMethod RMMatchUrl
		{
			get
			{
				if(r_MMatchUrl == null)
				{
					r_MMatchUrl = new(this, "MatchUrl", 0);
				}
				return r_MMatchUrl;
			}
		}

		/// <summary>
		/// Boolean MatchTime()
		/// </summary>
		protected RMethod r_MMatchTime;
		public virtual RMethod RMMatchTime
		{
			get
			{
				if(r_MMatchTime == null)
				{
					r_MMatchTime = new(this, "MatchTime", 0);
				}
				return r_MMatchTime;
			}
		}

		/// <summary>
		/// Boolean MatchCustomIdent()
		/// </summary>
		protected RMethod r_MMatchCustomIdent;
		public virtual RMethod RMMatchCustomIdent
		{
			get
			{
				if(r_MMatchCustomIdent == null)
				{
					r_MMatchCustomIdent = new(this, "MatchCustomIdent", 0);
				}
				return r_MMatchCustomIdent;
			}
		}

		/// <summary>
		/// Boolean MatchAngle()
		/// </summary>
		protected RMethod r_MMatchAngle;
		public virtual RMethod RMMatchAngle
		{
			get
			{
				if(r_MMatchAngle == null)
				{
					r_MMatchAngle = new(this, "MatchAngle", 0);
				}
				return r_MMatchAngle;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_MInitialize;
		public virtual RMethod RMInitialize
		{
			get
			{
				if(r_MInitialize == null)
				{
					r_MInitialize = new(this, "Initialize", 0);
				}
				return r_MInitialize;
			}
		}

		/// <summary>
		/// Void MoveNext()
		/// </summary>
		protected RMethod r_MMoveNext;
		public virtual RMethod RMMoveNext
		{
			get
			{
				if(r_MMoveNext == null)
				{
					r_MMoveNext = new(this, "MoveNext", 0);
				}
				return r_MMoveNext;
			}
		}

		/// <summary>
		/// Void SaveContext()
		/// </summary>
		protected RMethod r_MSaveContext;
		public virtual RMethod RMSaveContext
		{
			get
			{
				if(r_MSaveContext == null)
				{
					r_MSaveContext = new(this, "SaveContext", 0);
				}
				return r_MSaveContext;
			}
		}

		/// <summary>
		/// Void RestoreContext()
		/// </summary>
		protected RMethod r_MRestoreContext;
		public virtual RMethod RMRestoreContext
		{
			get
			{
				if(r_MRestoreContext == null)
				{
					r_MRestoreContext = new(this, "RestoreContext", 0);
				}
				return r_MRestoreContext;
			}
		}

		/// <summary>
		/// Void DropContext()
		/// </summary>
		protected RMethod r_MDropContext;
		public virtual RMethod RMDropContext
		{
			get
			{
				if(r_MDropContext == null)
				{
					r_MDropContext = new(this, "DropContext", 0);
				}
				return r_MDropContext;
			}
		}

		/// <summary>
		/// Boolean Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression)
		/// </summary>
		protected RMethod r_MMatch_Expression;
		public virtual RMethod RMMatch_Expression
		{
			get
			{
				if(r_MMatch_Expression == null)
				{
					r_MMatch_Expression = new(this, "Match", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.Expression"));
				}
				return r_MMatch_Expression;
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

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RMatchResult Match(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression @exp, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exp.Value, @values.Value};
            var ___result = RMMatch_Expression_List_d_StylePropertyValue_p_.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RMatchResult(___result);
        }


        public virtual System.Boolean MatchKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMMatchKeyword_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchNumber()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchNumber.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchInteger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchInteger.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchLength()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchLength.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchPercentage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchPercentage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchColor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchColor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchResource()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchResource.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchUrl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchUrl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchTime.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchCustomIdent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchCustomIdent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchAngle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMatchAngle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DropContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDropContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Match(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpression @exp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exp.Value};
            var ___result = RMMatch_Expression.Invoke(___genericsType, ___parameters);

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
