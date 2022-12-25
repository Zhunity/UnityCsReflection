using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleValueCollection
	/// </summary>
    public partial class RStyleValueCollection : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StyleValue] m_Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStyleValue> r_m_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStyleValue> Rm_Values
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
		/// UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleLength_StylePropertyId;
		public virtual RMethod RGetStyleLength_StylePropertyId
		{
			get
			{
				if(r_RGetStyleLength_StylePropertyId == null)
				{
					r_RGetStyleLength_StylePropertyId = new(this, "GetStyleLength", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleLength_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleLength_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleFloat_StylePropertyId;
		public virtual RMethod RGetStyleFloat_StylePropertyId
		{
			get
			{
				if(r_RGetStyleFloat_StylePropertyId == null)
				{
					r_RGetStyleFloat_StylePropertyId = new(this, "GetStyleFloat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleFloat_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleFloat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleInt_StylePropertyId;
		public virtual RMethod RGetStyleInt_StylePropertyId
		{
			get
			{
				if(r_RGetStyleInt_StylePropertyId == null)
				{
					r_RGetStyleInt_StylePropertyId = new(this, "GetStyleInt", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleInt_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleInt_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleColor_StylePropertyId;
		public virtual RMethod RGetStyleColor_StylePropertyId
		{
			get
			{
				if(r_RGetStyleColor_StylePropertyId == null)
				{
					r_RGetStyleColor_StylePropertyId = new(this, "GetStyleColor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleColor_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleColor_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleBackground_StylePropertyId;
		public virtual RMethod RGetStyleBackground_StylePropertyId
		{
			get
			{
				if(r_RGetStyleBackground_StylePropertyId == null)
				{
					r_RGetStyleBackground_StylePropertyId = new(this, "GetStyleBackground", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleBackground_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleBackground_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleBackgroundPosition_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundPosition_StylePropertyId
		{
			get
			{
				if(r_RGetStyleBackgroundPosition_StylePropertyId == null)
				{
					r_RGetStyleBackgroundPosition_StylePropertyId = new(this, "GetStyleBackgroundPosition", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleBackgroundPosition_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleBackgroundPosition_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleBackgroundRepeat_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundRepeat_StylePropertyId
		{
			get
			{
				if(r_RGetStyleBackgroundRepeat_StylePropertyId == null)
				{
					r_RGetStyleBackgroundRepeat_StylePropertyId = new(this, "GetStyleBackgroundRepeat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleBackgroundRepeat_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleBackgroundRepeat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleFont_StylePropertyId;
		public virtual RMethod RGetStyleFont_StylePropertyId
		{
			get
			{
				if(r_RGetStyleFont_StylePropertyId == null)
				{
					r_RGetStyleFont_StylePropertyId = new(this, "GetStyleFont", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleFont_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleFont_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RGetStyleFontDefinition_StylePropertyId;
		public virtual RMethod RGetStyleFontDefinition_StylePropertyId
		{
			get
			{
				if(r_RGetStyleFontDefinition_StylePropertyId == null)
				{
					r_RGetStyleFontDefinition_StylePropertyId = new(this, "GetStyleFontDefinition", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RGetStyleFontDefinition_StylePropertyId.SetBelong(this.instance);
				}
				return r_RGetStyleFontDefinition_StylePropertyId;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValue ByRef)
		/// </summary>
		protected RMethod r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue;
		public virtual RMethod RTryGetStyleValue_StylePropertyId_Ref_StyleValue
		{
			get
			{
				if(r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue == null)
				{
					r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue = new(this, "TryGetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue").MakeByRefType());
					r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue.SetBelong(this.instance);
				}
				return r_RTryGetStyleValue_StylePropertyId_Ref_StyleValue;
			}
		}

		/// <summary>
		/// Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_RSetStyleValue_StyleValue;
		public virtual RMethod RSetStyleValue_StyleValue
		{
			get
			{
				if(r_RSetStyleValue_StyleValue == null)
				{
					r_RSetStyleValue_StyleValue = new(this, "SetStyleValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
					r_RSetStyleValue_StyleValue.SetBelong(this.instance);
				}
				return r_RSetStyleValue_StyleValue;
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


        public RStyleValueCollection() : base("UnityEngine.UIElements.StyleValueCollection")
        {
        }

        public RStyleValueCollection(System.Object instance) : base("UnityEngine.UIElements.StyleValueCollection")
		{
            SetInstance(instance);
		}

        public RStyleValueCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleValueCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
