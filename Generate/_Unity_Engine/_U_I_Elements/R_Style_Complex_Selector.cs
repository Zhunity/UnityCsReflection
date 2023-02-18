
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleComplexSelector
	/// </summary>
    public partial class RStyleComplexSelector : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Hashes ancestorHashes
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHashes r_FancestorHashes;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHashes RFancestorHashes
		{
			get
			{
				if(r_FancestorHashes == null)
				{
					r_FancestorHashes = new(this, "ancestorHashes");
				}
				return r_FancestorHashes;
			}
		}

		/// <summary>
		/// System.Int32 m_Specificity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Specificity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Specificity
		{
			get
			{
				if(r_Fm_Specificity == null)
				{
					r_Fm_Specificity = new(this, "m_Specificity");
				}
				return r_Fm_Specificity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule <rule>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule r_F__0__rule__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule RF__0__rule__1__k__BackingField
		{
			get
			{
				if(r_F__0__rule__1__k__BackingField == null)
				{
					r_F__0__rule__1__k__BackingField = new(this, "<rule>k__BackingField");
				}
				return r_F__0__rule__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean m_isSimple
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isSimple;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isSimple
		{
			get
			{
				if(r_Fm_isSimple == null)
				{
					r_Fm_isSimple = new(this, "m_isSimple");
				}
				return r_Fm_isSimple;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelector[] m_Selectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelector> r_Fm_Selectors;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelector> RFm_Selectors
		{
			get
			{
				if(r_Fm_Selectors == null)
				{
					r_Fm_Selectors = new(this, "m_Selectors");
				}
				return r_Fm_Selectors;
			}
		}

		/// <summary>
		/// System.Int32 ruleIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FruleIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruleIndex
		{
			get
			{
				if(r_FruleIndex == null)
				{
					r_FruleIndex = new(this, "ruleIndex");
				}
				return r_FruleIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector nextInTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector r_FnextInTable;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector RFnextInTable
		{
			get
			{
				if(r_FnextInTable == null)
				{
					r_FnextInTable = new(this, "nextInTable");
				}
				return r_FnextInTable;
			}
		}

		/// <summary>
		/// System.Int32 orderInStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_ForderInStyleSheet;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RForderInStyleSheet
		{
			get
			{
				if(r_ForderInStyleSheet == null)
				{
					r_ForderInStyleSheet = new(this, "orderInStyleSheet");
				}
				return r_ForderInStyleSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector+PseudoStateData] s_PseudoStates
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector.RPseudoStateData> r_Fs_PseudoStates;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector.RPseudoStateData> RFs_PseudoStates
		{
			get
			{
				if(r_Fs_PseudoStates == null)
				{
					r_Fs_PseudoStates = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"), "s_PseudoStates");
				}
				return r_Fs_PseudoStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSelectorPart] m_HashList
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart> r_Fm_HashList;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart> RFm_HashList
		{
			get
			{
				if(r_Fm_HashList == null)
				{
					r_Fm_HashList = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"), "m_HashList");
				}
				return r_Fm_HashList;
			}
		}

		/// <summary>
		/// Int32 specificity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pspecificity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPspecificity
		{
			get
			{
				if(r_Pspecificity == null)
				{
					r_Pspecificity = new(this, "specificity", -1);
				}
				return r_Pspecificity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule rule
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule r_Prule;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule RPrule
		{
			get
			{
				if(r_Prule == null)
				{
					r_Prule = new(this, "rule", -1);
				}
				return r_Prule;
			}
		}

		/// <summary>
		/// Boolean isSimple
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSimple;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisSimple
		{
			get
			{
				if(r_PisSimple == null)
				{
					r_PisSimple = new(this, "isSimple", -1);
				}
				return r_PisSimple;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSelector[] selectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelector> r_Pselectors;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelector> RPselectors
		{
			get
			{
				if(r_Pselectors == null)
				{
					r_Pselectors = new(this, "selectors", -1);
				}
				return r_Pselectors;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
			}
		}

		/// <summary>
		/// Void CachePseudoStateMasks()
		/// </summary>
		protected RMethod r_MCachePseudoStateMasks;
		public virtual RMethod RMCachePseudoStateMasks
		{
			get
			{
				if(r_MCachePseudoStateMasks == null)
				{
					r_MCachePseudoStateMasks = new(this, "CachePseudoStateMasks", 0);
				}
				return r_MCachePseudoStateMasks;
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

		/// <summary>
		/// Int32 StyleSelectorPartCompare(UnityEngine.UIElements.StyleSelectorPart, UnityEngine.UIElements.StyleSelectorPart)
		/// </summary>
		protected static RMethod r_MStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart;
		public static RMethod RMStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart
		{
			get
			{
				if(r_MStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart == null)
				{
					r_MStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"), "StyleSelectorPartCompare", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSelectorPart"));
				}
				return r_MStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart;
			}
		}

		/// <summary>
		/// Void CalculateHashes()
		/// </summary>
		protected RMethod r_MCalculateHashes;
		public virtual RMethod RMCalculateHashes
		{
			get
			{
				if(r_MCalculateHashes == null)
				{
					r_MCalculateHashes = new(this, "CalculateHashes", 0);
				}
				return r_MCalculateHashes;
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
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CachePseudoStateMasks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCachePseudoStateMasks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 StyleSelectorPartCompare(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart @x, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSelectorPart @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x.Value, @y.Value};
            var ___result = RMStyleSelectorPartCompare_StyleSelectorPart_StyleSelectorPart.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void CalculateHashes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalculateHashes.Invoke(___genericsType, ___parameters);

            
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


    }
}
