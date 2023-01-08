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
		protected RMethod r_GetStyleLength_StylePropertyId;
		public virtual RMethod RGetStyleLength_StylePropertyId
		{
			get
			{
				if(r_GetStyleLength_StylePropertyId == null)
				{
					r_GetStyleLength_StylePropertyId = new(this, "GetStyleLength", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleLength_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleLength_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleFloat_StylePropertyId;
		public virtual RMethod RGetStyleFloat_StylePropertyId
		{
			get
			{
				if(r_GetStyleFloat_StylePropertyId == null)
				{
					r_GetStyleFloat_StylePropertyId = new(this, "GetStyleFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleFloat_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleFloat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleInt_StylePropertyId;
		public virtual RMethod RGetStyleInt_StylePropertyId
		{
			get
			{
				if(r_GetStyleInt_StylePropertyId == null)
				{
					r_GetStyleInt_StylePropertyId = new(this, "GetStyleInt", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleInt_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleInt_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleColor_StylePropertyId;
		public virtual RMethod RGetStyleColor_StylePropertyId
		{
			get
			{
				if(r_GetStyleColor_StylePropertyId == null)
				{
					r_GetStyleColor_StylePropertyId = new(this, "GetStyleColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleColor_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleColor_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleBackground_StylePropertyId;
		public virtual RMethod RGetStyleBackground_StylePropertyId
		{
			get
			{
				if(r_GetStyleBackground_StylePropertyId == null)
				{
					r_GetStyleBackground_StylePropertyId = new(this, "GetStyleBackground", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleBackground_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleBackground_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleBackgroundPosition_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundPosition_StylePropertyId
		{
			get
			{
				if(r_GetStyleBackgroundPosition_StylePropertyId == null)
				{
					r_GetStyleBackgroundPosition_StylePropertyId = new(this, "GetStyleBackgroundPosition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleBackgroundPosition_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleBackgroundPosition_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleBackgroundRepeat_StylePropertyId;
		public virtual RMethod RGetStyleBackgroundRepeat_StylePropertyId
		{
			get
			{
				if(r_GetStyleBackgroundRepeat_StylePropertyId == null)
				{
					r_GetStyleBackgroundRepeat_StylePropertyId = new(this, "GetStyleBackgroundRepeat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleBackgroundRepeat_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleBackgroundRepeat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleFont_StylePropertyId;
		public virtual RMethod RGetStyleFont_StylePropertyId
		{
			get
			{
				if(r_GetStyleFont_StylePropertyId == null)
				{
					r_GetStyleFont_StylePropertyId = new(this, "GetStyleFont", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleFont_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleFont_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_GetStyleFontDefinition_StylePropertyId;
		public virtual RMethod RGetStyleFontDefinition_StylePropertyId
		{
			get
			{
				if(r_GetStyleFontDefinition_StylePropertyId == null)
				{
					r_GetStyleFontDefinition_StylePropertyId = new(this, "GetStyleFontDefinition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_GetStyleFontDefinition_StylePropertyId.SetBelong(this.instance);
				}
				return r_GetStyleFontDefinition_StylePropertyId;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValue ByRef)
		/// </summary>
		protected RMethod r_TryGetStyleValue_StylePropertyId_Ref_StyleValue;
		public virtual RMethod RTryGetStyleValue_StylePropertyId_Ref_StyleValue
		{
			get
			{
				if(r_TryGetStyleValue_StylePropertyId_Ref_StyleValue == null)
				{
					r_TryGetStyleValue_StylePropertyId_Ref_StyleValue = new(this, "TryGetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue").MakeByRefType());
					r_TryGetStyleValue_StylePropertyId_Ref_StyleValue.SetBelong(this.instance);
				}
				return r_TryGetStyleValue_StylePropertyId_Ref_StyleValue;
			}
		}

		/// <summary>
		/// Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_SetStyleValue_StyleValue;
		public virtual RMethod RSetStyleValue_StyleValue
		{
			get
			{
				if(r_SetStyleValue_StyleValue == null)
				{
					r_SetStyleValue_StyleValue = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
					r_SetStyleValue_StyleValue.SetBelong(this.instance);
				}
				return r_SetStyleValue_StyleValue;
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
