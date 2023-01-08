using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental
{
	/// <summary>
	/// UnityEngine.UIElements.Experimental.StyleValues
	/// </summary>
    public partial class RStyleValues : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleValueCollection m_StyleValues
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleValueCollection r_m_StyleValues;
		public virtual RUnityEngine.RUIElements.RStyleValueCollection Rm_StyleValues
		{
			get
			{
				if(r_m_StyleValues == null)
				{
					r_m_StyleValues = new(this, "m_StyleValues");
					r_m_StyleValues.SetBelong(this.instance);
				}
				return r_m_StyleValues;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected RProperty r_top;
		public virtual RProperty Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top", -1);
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected RProperty r_left;
		public virtual RProperty Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left", -1);
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected RProperty r_right;
		public virtual RProperty Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right", -1);
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected RProperty r_bottom;
		public virtual RProperty Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom", -1);
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color", -1);
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_backgroundColor;
		public virtual RUnityEngine.RColor RbackgroundColor
		{
			get
			{
				if(r_backgroundColor == null)
				{
					r_backgroundColor = new(this, "backgroundColor", -1);
					r_backgroundColor.SetBelong(this.instance);
				}
				return r_backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_unityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RunityBackgroundImageTintColor
		{
			get
			{
				if(r_unityBackgroundImageTintColor == null)
				{
					r_unityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor", -1);
					r_unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderColor
		/// </summary>
		protected RUnityEngine.RColor r_borderColor;
		public virtual RUnityEngine.RColor RborderColor
		{
			get
			{
				if(r_borderColor == null)
				{
					r_borderColor = new(this, "borderColor", -1);
					r_borderColor.SetBelong(this.instance);
				}
				return r_borderColor;
			}
		}

		/// <summary>
		/// Single marginLeft
		/// </summary>
		protected RProperty r_marginLeft;
		public virtual RProperty RmarginLeft
		{
			get
			{
				if(r_marginLeft == null)
				{
					r_marginLeft = new(this, "marginLeft", -1);
					r_marginLeft.SetBelong(this.instance);
				}
				return r_marginLeft;
			}
		}

		/// <summary>
		/// Single marginTop
		/// </summary>
		protected RProperty r_marginTop;
		public virtual RProperty RmarginTop
		{
			get
			{
				if(r_marginTop == null)
				{
					r_marginTop = new(this, "marginTop", -1);
					r_marginTop.SetBelong(this.instance);
				}
				return r_marginTop;
			}
		}

		/// <summary>
		/// Single marginRight
		/// </summary>
		protected RProperty r_marginRight;
		public virtual RProperty RmarginRight
		{
			get
			{
				if(r_marginRight == null)
				{
					r_marginRight = new(this, "marginRight", -1);
					r_marginRight.SetBelong(this.instance);
				}
				return r_marginRight;
			}
		}

		/// <summary>
		/// Single marginBottom
		/// </summary>
		protected RProperty r_marginBottom;
		public virtual RProperty RmarginBottom
		{
			get
			{
				if(r_marginBottom == null)
				{
					r_marginBottom = new(this, "marginBottom", -1);
					r_marginBottom.SetBelong(this.instance);
				}
				return r_marginBottom;
			}
		}

		/// <summary>
		/// Single paddingLeft
		/// </summary>
		protected RProperty r_paddingLeft;
		public virtual RProperty RpaddingLeft
		{
			get
			{
				if(r_paddingLeft == null)
				{
					r_paddingLeft = new(this, "paddingLeft", -1);
					r_paddingLeft.SetBelong(this.instance);
				}
				return r_paddingLeft;
			}
		}

		/// <summary>
		/// Single paddingTop
		/// </summary>
		protected RProperty r_paddingTop;
		public virtual RProperty RpaddingTop
		{
			get
			{
				if(r_paddingTop == null)
				{
					r_paddingTop = new(this, "paddingTop", -1);
					r_paddingTop.SetBelong(this.instance);
				}
				return r_paddingTop;
			}
		}

		/// <summary>
		/// Single paddingRight
		/// </summary>
		protected RProperty r_paddingRight;
		public virtual RProperty RpaddingRight
		{
			get
			{
				if(r_paddingRight == null)
				{
					r_paddingRight = new(this, "paddingRight", -1);
					r_paddingRight.SetBelong(this.instance);
				}
				return r_paddingRight;
			}
		}

		/// <summary>
		/// Single paddingBottom
		/// </summary>
		protected RProperty r_paddingBottom;
		public virtual RProperty RpaddingBottom
		{
			get
			{
				if(r_paddingBottom == null)
				{
					r_paddingBottom = new(this, "paddingBottom", -1);
					r_paddingBottom.SetBelong(this.instance);
				}
				return r_paddingBottom;
			}
		}

		/// <summary>
		/// Single borderLeftWidth
		/// </summary>
		protected RProperty r_borderLeftWidth;
		public virtual RProperty RborderLeftWidth
		{
			get
			{
				if(r_borderLeftWidth == null)
				{
					r_borderLeftWidth = new(this, "borderLeftWidth", -1);
					r_borderLeftWidth.SetBelong(this.instance);
				}
				return r_borderLeftWidth;
			}
		}

		/// <summary>
		/// Single borderRightWidth
		/// </summary>
		protected RProperty r_borderRightWidth;
		public virtual RProperty RborderRightWidth
		{
			get
			{
				if(r_borderRightWidth == null)
				{
					r_borderRightWidth = new(this, "borderRightWidth", -1);
					r_borderRightWidth.SetBelong(this.instance);
				}
				return r_borderRightWidth;
			}
		}

		/// <summary>
		/// Single borderTopWidth
		/// </summary>
		protected RProperty r_borderTopWidth;
		public virtual RProperty RborderTopWidth
		{
			get
			{
				if(r_borderTopWidth == null)
				{
					r_borderTopWidth = new(this, "borderTopWidth", -1);
					r_borderTopWidth.SetBelong(this.instance);
				}
				return r_borderTopWidth;
			}
		}

		/// <summary>
		/// Single borderBottomWidth
		/// </summary>
		protected RProperty r_borderBottomWidth;
		public virtual RProperty RborderBottomWidth
		{
			get
			{
				if(r_borderBottomWidth == null)
				{
					r_borderBottomWidth = new(this, "borderBottomWidth", -1);
					r_borderBottomWidth.SetBelong(this.instance);
				}
				return r_borderBottomWidth;
			}
		}

		/// <summary>
		/// Single borderTopLeftRadius
		/// </summary>
		protected RProperty r_borderTopLeftRadius;
		public virtual RProperty RborderTopLeftRadius
		{
			get
			{
				if(r_borderTopLeftRadius == null)
				{
					r_borderTopLeftRadius = new(this, "borderTopLeftRadius", -1);
					r_borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_borderTopLeftRadius;
			}
		}

		/// <summary>
		/// Single borderTopRightRadius
		/// </summary>
		protected RProperty r_borderTopRightRadius;
		public virtual RProperty RborderTopRightRadius
		{
			get
			{
				if(r_borderTopRightRadius == null)
				{
					r_borderTopRightRadius = new(this, "borderTopRightRadius", -1);
					r_borderTopRightRadius.SetBelong(this.instance);
				}
				return r_borderTopRightRadius;
			}
		}

		/// <summary>
		/// Single borderBottomLeftRadius
		/// </summary>
		protected RProperty r_borderBottomLeftRadius;
		public virtual RProperty RborderBottomLeftRadius
		{
			get
			{
				if(r_borderBottomLeftRadius == null)
				{
					r_borderBottomLeftRadius = new(this, "borderBottomLeftRadius", -1);
					r_borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// Single borderBottomRightRadius
		/// </summary>
		protected RProperty r_borderBottomRightRadius;
		public virtual RProperty RborderBottomRightRadius
		{
			get
			{
				if(r_borderBottomRightRadius == null)
				{
					r_borderBottomRightRadius = new(this, "borderBottomRightRadius", -1);
					r_borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_borderBottomRightRadius;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RProperty r_opacity;
		public virtual RProperty Ropacity
		{
			get
			{
				if(r_opacity == null)
				{
					r_opacity = new(this, "opacity", -1);
					r_opacity.SetBelong(this.instance);
				}
				return r_opacity;
			}
		}

		/// <summary>
		/// Single flexGrow
		/// </summary>
		protected RProperty r_flexGrow;
		public virtual RProperty RflexGrow
		{
			get
			{
				if(r_flexGrow == null)
				{
					r_flexGrow = new(this, "flexGrow", -1);
					r_flexGrow.SetBelong(this.instance);
				}
				return r_flexGrow;
			}
		}

		/// <summary>
		/// Single flexShrink
		/// </summary>
		protected RProperty r_flexShrink;
		public virtual RProperty RflexShrink
		{
			get
			{
				if(r_flexShrink == null)
				{
					r_flexShrink = new(this, "flexShrink", -1);
					r_flexShrink.SetBelong(this.instance);
				}
				return r_flexShrink;
			}
		}

		/// <summary>
		/// Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, Single)
		/// </summary>
		protected RMethod r_SetValue_StylePropertyId_Single;
		public virtual RMethod RSetValue_StylePropertyId_Single
		{
			get
			{
				if(r_SetValue_StylePropertyId_Single == null)
				{
					r_SetValue_StylePropertyId_Single = new(this, "SetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single));
					r_SetValue_StylePropertyId_Single.SetBelong(this.instance);
				}
				return r_SetValue_StylePropertyId_Single;
			}
		}

		/// <summary>
		/// Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetValue_StylePropertyId_Color;
		public virtual RMethod RSetValue_StylePropertyId_Color
		{
			get
			{
				if(r_SetValue_StylePropertyId_Color == null)
				{
					r_SetValue_StylePropertyId_Color = new(this, "SetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color));
					r_SetValue_StylePropertyId_Color.SetBelong(this.instance);
				}
				return r_SetValue_StylePropertyId_Color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueCollection Values()
		/// </summary>
		protected RMethod r_Values;
		public virtual RMethod RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", 0);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
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


        public RStyleValues() : base("UnityEngine.UIElements.Experimental.StyleValues")
        {
        }

        public RStyleValues(System.Object instance) : base("UnityEngine.UIElements.Experimental.StyleValues")
		{
            SetInstance(instance);
		}

        public RStyleValues(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleValues(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual System.Object Values()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValues.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
