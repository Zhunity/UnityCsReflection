
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.StyleValueCollection
	/// </summary>
    public partial class RStyleValueCollection : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueCollection");
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


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StyleValue] m_Values
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue> r_Fm_Values;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue> RFm_Values
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
		/// UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleLength_StylePropertyId;
		public virtual RMethod RMGetStyleLength_StylePropertyId
		{
			get
			{
				if(r_MGetStyleLength_StylePropertyId == null)
				{
					r_MGetStyleLength_StylePropertyId = new(this, "GetStyleLength", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleLength_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleFloat_StylePropertyId;
		public virtual RMethod RMGetStyleFloat_StylePropertyId
		{
			get
			{
				if(r_MGetStyleFloat_StylePropertyId == null)
				{
					r_MGetStyleFloat_StylePropertyId = new(this, "GetStyleFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleFloat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleInt_StylePropertyId;
		public virtual RMethod RMGetStyleInt_StylePropertyId
		{
			get
			{
				if(r_MGetStyleInt_StylePropertyId == null)
				{
					r_MGetStyleInt_StylePropertyId = new(this, "GetStyleInt", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleInt_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleColor_StylePropertyId;
		public virtual RMethod RMGetStyleColor_StylePropertyId
		{
			get
			{
				if(r_MGetStyleColor_StylePropertyId == null)
				{
					r_MGetStyleColor_StylePropertyId = new(this, "GetStyleColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleColor_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleBackground_StylePropertyId;
		public virtual RMethod RMGetStyleBackground_StylePropertyId
		{
			get
			{
				if(r_MGetStyleBackground_StylePropertyId == null)
				{
					r_MGetStyleBackground_StylePropertyId = new(this, "GetStyleBackground", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleBackground_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleBackgroundPosition_StylePropertyId;
		public virtual RMethod RMGetStyleBackgroundPosition_StylePropertyId
		{
			get
			{
				if(r_MGetStyleBackgroundPosition_StylePropertyId == null)
				{
					r_MGetStyleBackgroundPosition_StylePropertyId = new(this, "GetStyleBackgroundPosition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleBackgroundPosition_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleBackgroundRepeat_StylePropertyId;
		public virtual RMethod RMGetStyleBackgroundRepeat_StylePropertyId
		{
			get
			{
				if(r_MGetStyleBackgroundRepeat_StylePropertyId == null)
				{
					r_MGetStyleBackgroundRepeat_StylePropertyId = new(this, "GetStyleBackgroundRepeat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleBackgroundRepeat_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFont GetStyleFont(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleFont_StylePropertyId;
		public virtual RMethod RMGetStyleFont_StylePropertyId
		{
			get
			{
				if(r_MGetStyleFont_StylePropertyId == null)
				{
					r_MGetStyleFont_StylePropertyId = new(this, "GetStyleFont", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleFont_StylePropertyId;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MGetStyleFontDefinition_StylePropertyId;
		public virtual RMethod RMGetStyleFontDefinition_StylePropertyId
		{
			get
			{
				if(r_MGetStyleFontDefinition_StylePropertyId == null)
				{
					r_MGetStyleFontDefinition_StylePropertyId = new(this, "GetStyleFontDefinition", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
				}
				return r_MGetStyleFontDefinition_StylePropertyId;
			}
		}

		/// <summary>
		/// Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.StyleSheets.StyleValue ByRef)
		/// </summary>
		protected RMethod r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue;
		public virtual RMethod RMTryGetStyleValue_StylePropertyId_Ref_StyleValue
		{
			get
			{
				if(r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue == null)
				{
					r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue = new(this, "TryGetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue").MakeByRefType());
				}
				return r_MTryGetStyleValue_StylePropertyId_Ref_StyleValue;
			}
		}

		/// <summary>
		/// Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue)
		/// </summary>
		protected RMethod r_MSetStyleValue_StyleValue;
		public virtual RMethod RMSetStyleValue_StyleValue
		{
			get
			{
				if(r_MSetStyleValue_StyleValue == null)
				{
					r_MSetStyleValue_StyleValue = new(this, "SetStyleValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleValue"));
				}
				return r_MSetStyleValue_StyleValue;
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


        public virtual UnityEngine.UIElements.StyleLength GetStyleLength(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleLength_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleLength>(___result);
        }


        public virtual UnityEngine.UIElements.StyleFloat GetStyleFloat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleFloat_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFloat>(___result);
        }


        public virtual UnityEngine.UIElements.StyleInt GetStyleInt(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleInt_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleInt>(___result);
        }


        public virtual UnityEngine.UIElements.StyleColor GetStyleColor(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleColor_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleColor>(___result);
        }


        public virtual UnityEngine.UIElements.StyleBackground GetStyleBackground(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleBackground_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackground>(___result);
        }


        public virtual UnityEngine.UIElements.StyleBackgroundPosition GetStyleBackgroundPosition(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleBackgroundPosition_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackgroundPosition>(___result);
        }


        public virtual UnityEngine.UIElements.StyleBackgroundRepeat GetStyleBackgroundRepeat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleBackgroundRepeat_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleBackgroundRepeat>(___result);
        }


        public virtual UnityEngine.UIElements.StyleFont GetStyleFont(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleFont_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFont>(___result);
        }


        public virtual UnityEngine.UIElements.StyleFontDefinition GetStyleFontDefinition(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMGetStyleFontDefinition_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFontDefinition>(___result);
        }


        public virtual System.Boolean TryGetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @value.Value};
            var ___result = RMTryGetStyleValue_StylePropertyId_Ref_StyleValue.Invoke(___genericsType, ___parameters);
			@value = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetStyleValue(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStyleValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMSetStyleValue_StyleValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
