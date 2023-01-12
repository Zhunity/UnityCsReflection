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
		protected RUnityEngine.RUIElements.RStyleValueCollection r_Fm_StyleValues;
		public virtual RUnityEngine.RUIElements.RStyleValueCollection RFm_StyleValues
		{
			get
			{
				if(r_Fm_StyleValues == null)
				{
					r_Fm_StyleValues = new(this, "m_StyleValues");
					r_Fm_StyleValues.SetBelong(this.instance);
				}
				return r_Fm_StyleValues;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected RSystem.RSingle r_Ptop;
		public virtual RSystem.RSingle RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
					r_Ptop.SetBelong(this.instance);
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected RSystem.RSingle r_Pleft;
		public virtual RSystem.RSingle RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
					r_Pleft.SetBelong(this.instance);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected RSystem.RSingle r_Pwidth;
		public virtual RSystem.RSingle RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
					r_Pwidth.SetBelong(this.instance);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected RSystem.RSingle r_Pheight;
		public virtual RSystem.RSingle RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
					r_Pheight.SetBelong(this.instance);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected RSystem.RSingle r_Pright;
		public virtual RSystem.RSingle RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
					r_Pright.SetBelong(this.instance);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected RSystem.RSingle r_Pbottom;
		public virtual RSystem.RSingle RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
					r_Pbottom.SetBelong(this.instance);
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_Pcolor;
		public virtual RUnityEngine.RColor RPcolor
		{
			get
			{
				if(r_Pcolor == null)
				{
					r_Pcolor = new(this, "color", -1);
					r_Pcolor.SetBelong(this.instance);
				}
				return r_Pcolor;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_PbackgroundColor;
		public virtual RUnityEngine.RColor RPbackgroundColor
		{
			get
			{
				if(r_PbackgroundColor == null)
				{
					r_PbackgroundColor = new(this, "backgroundColor", -1);
					r_PbackgroundColor.SetBelong(this.instance);
				}
				return r_PbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_PunityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RPunityBackgroundImageTintColor
		{
			get
			{
				if(r_PunityBackgroundImageTintColor == null)
				{
					r_PunityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor", -1);
					r_PunityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_PunityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderColor
		/// </summary>
		protected RUnityEngine.RColor r_PborderColor;
		public virtual RUnityEngine.RColor RPborderColor
		{
			get
			{
				if(r_PborderColor == null)
				{
					r_PborderColor = new(this, "borderColor", -1);
					r_PborderColor.SetBelong(this.instance);
				}
				return r_PborderColor;
			}
		}

		/// <summary>
		/// Single marginLeft
		/// </summary>
		protected RSystem.RSingle r_PmarginLeft;
		public virtual RSystem.RSingle RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
					r_PmarginLeft.SetBelong(this.instance);
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// Single marginTop
		/// </summary>
		protected RSystem.RSingle r_PmarginTop;
		public virtual RSystem.RSingle RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
					r_PmarginTop.SetBelong(this.instance);
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// Single marginRight
		/// </summary>
		protected RSystem.RSingle r_PmarginRight;
		public virtual RSystem.RSingle RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
					r_PmarginRight.SetBelong(this.instance);
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// Single marginBottom
		/// </summary>
		protected RSystem.RSingle r_PmarginBottom;
		public virtual RSystem.RSingle RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
					r_PmarginBottom.SetBelong(this.instance);
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// Single paddingLeft
		/// </summary>
		protected RSystem.RSingle r_PpaddingLeft;
		public virtual RSystem.RSingle RPpaddingLeft
		{
			get
			{
				if(r_PpaddingLeft == null)
				{
					r_PpaddingLeft = new(this, "paddingLeft", -1);
					r_PpaddingLeft.SetBelong(this.instance);
				}
				return r_PpaddingLeft;
			}
		}

		/// <summary>
		/// Single paddingTop
		/// </summary>
		protected RSystem.RSingle r_PpaddingTop;
		public virtual RSystem.RSingle RPpaddingTop
		{
			get
			{
				if(r_PpaddingTop == null)
				{
					r_PpaddingTop = new(this, "paddingTop", -1);
					r_PpaddingTop.SetBelong(this.instance);
				}
				return r_PpaddingTop;
			}
		}

		/// <summary>
		/// Single paddingRight
		/// </summary>
		protected RSystem.RSingle r_PpaddingRight;
		public virtual RSystem.RSingle RPpaddingRight
		{
			get
			{
				if(r_PpaddingRight == null)
				{
					r_PpaddingRight = new(this, "paddingRight", -1);
					r_PpaddingRight.SetBelong(this.instance);
				}
				return r_PpaddingRight;
			}
		}

		/// <summary>
		/// Single paddingBottom
		/// </summary>
		protected RSystem.RSingle r_PpaddingBottom;
		public virtual RSystem.RSingle RPpaddingBottom
		{
			get
			{
				if(r_PpaddingBottom == null)
				{
					r_PpaddingBottom = new(this, "paddingBottom", -1);
					r_PpaddingBottom.SetBelong(this.instance);
				}
				return r_PpaddingBottom;
			}
		}

		/// <summary>
		/// Single borderLeftWidth
		/// </summary>
		protected RSystem.RSingle r_PborderLeftWidth;
		public virtual RSystem.RSingle RPborderLeftWidth
		{
			get
			{
				if(r_PborderLeftWidth == null)
				{
					r_PborderLeftWidth = new(this, "borderLeftWidth", -1);
					r_PborderLeftWidth.SetBelong(this.instance);
				}
				return r_PborderLeftWidth;
			}
		}

		/// <summary>
		/// Single borderRightWidth
		/// </summary>
		protected RSystem.RSingle r_PborderRightWidth;
		public virtual RSystem.RSingle RPborderRightWidth
		{
			get
			{
				if(r_PborderRightWidth == null)
				{
					r_PborderRightWidth = new(this, "borderRightWidth", -1);
					r_PborderRightWidth.SetBelong(this.instance);
				}
				return r_PborderRightWidth;
			}
		}

		/// <summary>
		/// Single borderTopWidth
		/// </summary>
		protected RSystem.RSingle r_PborderTopWidth;
		public virtual RSystem.RSingle RPborderTopWidth
		{
			get
			{
				if(r_PborderTopWidth == null)
				{
					r_PborderTopWidth = new(this, "borderTopWidth", -1);
					r_PborderTopWidth.SetBelong(this.instance);
				}
				return r_PborderTopWidth;
			}
		}

		/// <summary>
		/// Single borderBottomWidth
		/// </summary>
		protected RSystem.RSingle r_PborderBottomWidth;
		public virtual RSystem.RSingle RPborderBottomWidth
		{
			get
			{
				if(r_PborderBottomWidth == null)
				{
					r_PborderBottomWidth = new(this, "borderBottomWidth", -1);
					r_PborderBottomWidth.SetBelong(this.instance);
				}
				return r_PborderBottomWidth;
			}
		}

		/// <summary>
		/// Single borderTopLeftRadius
		/// </summary>
		protected RSystem.RSingle r_PborderTopLeftRadius;
		public virtual RSystem.RSingle RPborderTopLeftRadius
		{
			get
			{
				if(r_PborderTopLeftRadius == null)
				{
					r_PborderTopLeftRadius = new(this, "borderTopLeftRadius", -1);
					r_PborderTopLeftRadius.SetBelong(this.instance);
				}
				return r_PborderTopLeftRadius;
			}
		}

		/// <summary>
		/// Single borderTopRightRadius
		/// </summary>
		protected RSystem.RSingle r_PborderTopRightRadius;
		public virtual RSystem.RSingle RPborderTopRightRadius
		{
			get
			{
				if(r_PborderTopRightRadius == null)
				{
					r_PborderTopRightRadius = new(this, "borderTopRightRadius", -1);
					r_PborderTopRightRadius.SetBelong(this.instance);
				}
				return r_PborderTopRightRadius;
			}
		}

		/// <summary>
		/// Single borderBottomLeftRadius
		/// </summary>
		protected RSystem.RSingle r_PborderBottomLeftRadius;
		public virtual RSystem.RSingle RPborderBottomLeftRadius
		{
			get
			{
				if(r_PborderBottomLeftRadius == null)
				{
					r_PborderBottomLeftRadius = new(this, "borderBottomLeftRadius", -1);
					r_PborderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_PborderBottomLeftRadius;
			}
		}

		/// <summary>
		/// Single borderBottomRightRadius
		/// </summary>
		protected RSystem.RSingle r_PborderBottomRightRadius;
		public virtual RSystem.RSingle RPborderBottomRightRadius
		{
			get
			{
				if(r_PborderBottomRightRadius == null)
				{
					r_PborderBottomRightRadius = new(this, "borderBottomRightRadius", -1);
					r_PborderBottomRightRadius.SetBelong(this.instance);
				}
				return r_PborderBottomRightRadius;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RSystem.RSingle r_Popacity;
		public virtual RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
					r_Popacity.SetBelong(this.instance);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Single flexGrow
		/// </summary>
		protected RSystem.RSingle r_PflexGrow;
		public virtual RSystem.RSingle RPflexGrow
		{
			get
			{
				if(r_PflexGrow == null)
				{
					r_PflexGrow = new(this, "flexGrow", -1);
					r_PflexGrow.SetBelong(this.instance);
				}
				return r_PflexGrow;
			}
		}

		/// <summary>
		/// Single flexShrink
		/// </summary>
		protected RSystem.RSingle r_PflexShrink;
		public virtual RSystem.RSingle RPflexShrink
		{
			get
			{
				if(r_PflexShrink == null)
				{
					r_PflexShrink = new(this, "flexShrink", -1);
					r_PflexShrink.SetBelong(this.instance);
				}
				return r_PflexShrink;
			}
		}

		/// <summary>
		/// Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, Single)
		/// </summary>
		protected RMethod r_MSetValue_StylePropertyId_Single;
		public virtual RMethod RMSetValue_StylePropertyId_Single
		{
			get
			{
				if(r_MSetValue_StylePropertyId_Single == null)
				{
					r_MSetValue_StylePropertyId_Single = new(this, "SetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single));
					r_MSetValue_StylePropertyId_Single.SetBelong(this.instance);
				}
				return r_MSetValue_StylePropertyId_Single;
			}
		}

		/// <summary>
		/// Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetValue_StylePropertyId_Color;
		public virtual RMethod RMSetValue_StylePropertyId_Color
		{
			get
			{
				if(r_MSetValue_StylePropertyId_Color == null)
				{
					r_MSetValue_StylePropertyId_Color = new(this, "SetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color));
					r_MSetValue_StylePropertyId_Color.SetBelong(this.instance);
				}
				return r_MSetValue_StylePropertyId_Color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueCollection Values()
		/// </summary>
		protected RMethod r_MValues;
		public virtual RMethod RMValues
		{
			get
			{
				if(r_MValues == null)
				{
					r_MValues = new(this, "Values", 0);
					r_MValues.SetBelong(this.instance);
				}
				return r_MValues;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual void SetValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @value};
            var ___result = RMSetValue_StylePropertyId_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Color @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @value};
            var ___result = RMSetValue_StylePropertyId_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RStyleValueCollection Values()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValues.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleValueCollection(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
