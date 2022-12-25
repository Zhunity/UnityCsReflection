using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleComplexSelector
	/// </summary>
    public partial class RStyleComplexSelector : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Hashes ancestorHashes
		/// </summary>
		protected RUnityEngine.RUIElements.RHashes r_ancestorHashes;
		public virtual RUnityEngine.RUIElements.RHashes RancestorHashes
		{
			get
			{
				if(r_ancestorHashes == null)
				{
					r_ancestorHashes = new(this, "ancestorHashes");
					r_ancestorHashes.SetBelong(this.instance);
				}
				return r_ancestorHashes;
			}
		}

		/// <summary>
		/// System.Int32 m_Specificity
		/// </summary>
		protected RField r_m_Specificity;
		public virtual RField Rm_Specificity
		{
			get
			{
				if(r_m_Specificity == null)
				{
					r_m_Specificity = new(this, "m_Specificity");
					r_m_Specificity.SetBelong(this.instance);
				}
				return r_m_Specificity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule <rule>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRule r___1__rule__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RStyleRule R__1__rule__2__k__BackingField
		{
			get
			{
				if(r___1__rule__2__k__BackingField == null)
				{
					r___1__rule__2__k__BackingField = new(this, "<rule>k__BackingField");
					r___1__rule__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__rule__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_isSimple
		/// </summary>
		protected RField r_m_isSimple;
		public virtual RField Rm_isSimple
		{
			get
			{
				if(r_m_isSimple == null)
				{
					r_m_isSimple = new(this, "m_isSimple");
					r_m_isSimple.SetBelong(this.instance);
				}
				return r_m_isSimple;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelector[] m_Selectors
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSelector> r_m_Selectors;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSelector> Rm_Selectors
		{
			get
			{
				if(r_m_Selectors == null)
				{
					r_m_Selectors = new(this, "m_Selectors");
					r_m_Selectors.SetBelong(this.instance);
				}
				return r_m_Selectors;
			}
		}

		/// <summary>
		/// System.Int32 ruleIndex
		/// </summary>
		protected RField r_ruleIndex;
		public virtual RField RruleIndex
		{
			get
			{
				if(r_ruleIndex == null)
				{
					r_ruleIndex = new(this, "ruleIndex");
					r_ruleIndex.SetBelong(this.instance);
				}
				return r_ruleIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector nextInTable
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleComplexSelector r_nextInTable;
		public virtual RUnityEngine.RUIElements.RStyleComplexSelector RnextInTable
		{
			get
			{
				if(r_nextInTable == null)
				{
					r_nextInTable = new(this, "nextInTable");
					r_nextInTable.SetBelong(this.instance);
				}
				return r_nextInTable;
			}
		}

		/// <summary>
		/// System.Int32 orderInStyleSheet
		/// </summary>
		protected RField r_orderInStyleSheet;
		public virtual RField RorderInStyleSheet
		{
			get
			{
				if(r_orderInStyleSheet == null)
				{
					r_orderInStyleSheet = new(this, "orderInStyleSheet");
					r_orderInStyleSheet.SetBelong(this.instance);
				}
				return r_orderInStyleSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector+PseudoStateData] s_PseudoStates
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector.RPseudoStateData> r_s_PseudoStates;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector.RPseudoStateData> Rs_PseudoStates
		{
			get
			{
				if(r_s_PseudoStates == null)
				{
					r_s_PseudoStates = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"), "s_PseudoStates");
					r_s_PseudoStates.SetBelong(null);
				}
				return r_s_PseudoStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSelectorPart] m_HashList
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSelectorPart> r_m_HashList;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSelectorPart> Rm_HashList
		{
			get
			{
				if(r_m_HashList == null)
				{
					r_m_HashList = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"), "m_HashList");
					r_m_HashList.SetBelong(null);
				}
				return r_m_HashList;
			}
		}

		/// <summary>
		/// Int32 specificity
		/// </summary>
		protected RProperty r_specificity;
		public virtual RProperty Rspecificity
		{
			get
			{
				if(r_specificity == null)
				{
					r_specificity = new(this, "specificity", -1);
					r_specificity.SetBelong(this.instance);
				}
				return r_specificity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule rule
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleRule r_rule;
		public virtual RUnityEngine.RUIElements.RStyleRule Rrule
		{
			get
			{
				if(r_rule == null)
				{
					r_rule = new(this, "rule", -1);
					r_rule.SetBelong(this.instance);
				}
				return r_rule;
			}
		}

		/// <summary>
		/// Boolean isSimple
		/// </summary>
		protected RProperty r_isSimple;
		public virtual RProperty RisSimple
		{
			get
			{
				if(r_isSimple == null)
				{
					r_isSimple = new(this, "isSimple", -1);
					r_isSimple.SetBelong(this.instance);
				}
				return r_isSimple;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelector[] selectors
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleSelector> r_selectors;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleSelector> Rselectors
		{
			get
			{
				if(r_selectors == null)
				{
					r_selectors = new(this, "selectors", -1);
					r_selectors.SetBelong(this.instance);
				}
				return r_selectors;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_ROnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_ROnBeforeSerialize == null)
				{
					r_ROnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_ROnBeforeSerialize.SetBelong(this.instance);
				}
				return r_ROnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_ROnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_ROnAfterDeserialize == null)
				{
					r_ROnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_ROnAfterDeserialize.SetBelong(this.instance);
				}
				return r_ROnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void CachePseudoStateMasks()
		/// </summary>
		protected RMethod r_RCachePseudoStateMasks;
		public virtual RMethod RCachePseudoStateMasks
		{
			get
			{
				if(r_RCachePseudoStateMasks == null)
				{
					r_RCachePseudoStateMasks = new(this, "CachePseudoStateMasks", 0);
					r_RCachePseudoStateMasks.SetBelong(this.instance);
				}
				return r_RCachePseudoStateMasks;
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
		/// Int32 StyleSelectorPartCompare(UnityEngine.UIElements.StyleSelectorPart, UnityEngine.UIElements.StyleSelectorPart)
		/// </summary>
		protected static RMethod r_RStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart;
		public static RMethod RStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart
		{
			get
			{
				if(r_RStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart == null)
				{
					r_RStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"), "StyleSelectorPartCompare", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"));
					r_RStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart.SetBelong(null);
				}
				return r_RStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart;
			}
		}

		/// <summary>
		/// Void CalculateHashes()
		/// </summary>
		protected RMethod r_RCalculateHashes;
		public virtual RMethod RCalculateHashes
		{
			get
			{
				if(r_RCalculateHashes == null)
				{
					r_RCalculateHashes = new(this, "CalculateHashes", 0);
					r_RCalculateHashes.SetBelong(this.instance);
				}
				return r_RCalculateHashes;
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


        public RStyleComplexSelector() : base("UnityEngine.UIElements.StyleComplexSelector")
        {
        }

        public RStyleComplexSelector(System.Object instance) : base("UnityEngine.UIElements.StyleComplexSelector")
		{
            SetInstance(instance);
		}

        public RStyleComplexSelector(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleComplexSelector(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CachePseudoStateMasks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCachePseudoStateMasks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void CalculateHashes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalculateHashes.Invoke(___genericsType, ___parameters);

            
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


    }
}
