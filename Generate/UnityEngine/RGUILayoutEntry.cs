using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUILayoutEntry
	/// </summary>
    public partial class RGUILayoutEntry : RMember //
    {

		/// <summary>
		/// System.Single minWidth
		/// </summary>
		protected RField r_minWidth;
		public virtual RField RminWidth
		{
			get
			{
				if(r_minWidth == null)
				{
					r_minWidth = new(this, "minWidth");
					r_minWidth.SetBelong(this.instance);
				}
				return r_minWidth;
			}
		}

		/// <summary>
		/// System.Single maxWidth
		/// </summary>
		protected RField r_maxWidth;
		public virtual RField RmaxWidth
		{
			get
			{
				if(r_maxWidth == null)
				{
					r_maxWidth = new(this, "maxWidth");
					r_maxWidth.SetBelong(this.instance);
				}
				return r_maxWidth;
			}
		}

		/// <summary>
		/// System.Single minHeight
		/// </summary>
		protected RField r_minHeight;
		public virtual RField RminHeight
		{
			get
			{
				if(r_minHeight == null)
				{
					r_minHeight = new(this, "minHeight");
					r_minHeight.SetBelong(this.instance);
				}
				return r_minHeight;
			}
		}

		/// <summary>
		/// System.Single maxHeight
		/// </summary>
		protected RField r_maxHeight;
		public virtual RField RmaxHeight
		{
			get
			{
				if(r_maxHeight == null)
				{
					r_maxHeight = new(this, "maxHeight");
					r_maxHeight.SetBelong(this.instance);
				}
				return r_maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_rect;
		public virtual RUnityEngine.RRect Rrect
		{
			get
			{
				if(r_rect == null)
				{
					r_rect = new(this, "rect");
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// System.Int32 stretchWidth
		/// </summary>
		protected RField r_stretchWidth;
		public virtual RField RstretchWidth
		{
			get
			{
				if(r_stretchWidth == null)
				{
					r_stretchWidth = new(this, "stretchWidth");
					r_stretchWidth.SetBelong(this.instance);
				}
				return r_stretchWidth;
			}
		}

		/// <summary>
		/// System.Int32 stretchHeight
		/// </summary>
		protected RField r_stretchHeight;
		public virtual RField RstretchHeight
		{
			get
			{
				if(r_stretchHeight == null)
				{
					r_stretchHeight = new(this, "stretchHeight");
					r_stretchHeight.SetBelong(this.instance);
				}
				return r_stretchHeight;
			}
		}

		/// <summary>
		/// System.Boolean consideredForMargin
		/// </summary>
		protected RField r_consideredForMargin;
		public virtual RField RconsideredForMargin
		{
			get
			{
				if(r_consideredForMargin == null)
				{
					r_consideredForMargin = new(this, "consideredForMargin");
					r_consideredForMargin.SetBelong(this.instance);
				}
				return r_consideredForMargin;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_Style
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_Style;
		public virtual RUnityEngine.RGUIStyle Rm_Style
		{
			get
			{
				if(r_m_Style == null)
				{
					r_m_Style = new(this, "m_Style");
					r_m_Style.SetBelong(this.instance);
				}
				return r_m_Style;
			}
		}

		/// <summary>
		/// UnityEngine.Rect kDummyRect
		/// </summary>
		protected static RUnityEngine.RRect r_kDummyRect;
		public static RUnityEngine.RRect RkDummyRect
		{
			get
			{
				if(r_kDummyRect == null)
				{
					r_kDummyRect = new( ReleactionUtils.GetType("UnityEngine.GUILayoutEntry"), "kDummyRect");
					r_kDummyRect.SetBelong(null);
				}
				return r_kDummyRect;
			}
		}

		/// <summary>
		/// System.Int32 indent
		/// </summary>
		protected static RField r_indent;
		public static RField Rindent
		{
			get
			{
				if(r_indent == null)
				{
					r_indent = new( ReleactionUtils.GetType("UnityEngine.GUILayoutEntry"), "indent");
					r_indent.SetBelong(null);
				}
				return r_indent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle style
		/// </summary>
		protected RUnityEngine.RGUIStyle r_style;
		public virtual RUnityEngine.RGUIStyle Rstyle
		{
			get
			{
				if(r_style == null)
				{
					r_style = new(this, "style", -1);
					r_style.SetBelong(this.instance);
				}
				return r_style;
			}
		}

		/// <summary>
		/// Int32 marginLeft
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
		/// Int32 marginRight
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
		/// Int32 marginTop
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
		/// Int32 marginBottom
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
		/// Int32 marginHorizontal
		/// </summary>
		protected RProperty r_marginHorizontal;
		public virtual RProperty RmarginHorizontal
		{
			get
			{
				if(r_marginHorizontal == null)
				{
					r_marginHorizontal = new(this, "marginHorizontal", -1);
					r_marginHorizontal.SetBelong(this.instance);
				}
				return r_marginHorizontal;
			}
		}

		/// <summary>
		/// Int32 marginVertical
		/// </summary>
		protected RProperty r_marginVertical;
		public virtual RProperty RmarginVertical
		{
			get
			{
				if(r_marginVertical == null)
				{
					r_marginVertical = new(this, "marginVertical", -1);
					r_marginVertical.SetBelong(this.instance);
				}
				return r_marginVertical;
			}
		}

		/// <summary>
		/// Void CalcWidth()
		/// </summary>
		protected RMethod r_RCalcWidth;
		public virtual RMethod RCalcWidth
		{
			get
			{
				if(r_RCalcWidth == null)
				{
					r_RCalcWidth = new(this, "CalcWidth", 0);
					r_RCalcWidth.SetBelong(this.instance);
				}
				return r_RCalcWidth;
			}
		}

		/// <summary>
		/// Void CalcHeight()
		/// </summary>
		protected RMethod r_RCalcHeight;
		public virtual RMethod RCalcHeight
		{
			get
			{
				if(r_RCalcHeight == null)
				{
					r_RCalcHeight = new(this, "CalcHeight", 0);
					r_RCalcHeight.SetBelong(this.instance);
				}
				return r_RCalcHeight;
			}
		}

		/// <summary>
		/// Void SetHorizontal(Single, Single)
		/// </summary>
		protected RMethod r_RSetHorizontal_Single_Single;
		public virtual RMethod RSetHorizontal_Single_Single
		{
			get
			{
				if(r_RSetHorizontal_Single_Single == null)
				{
					r_RSetHorizontal_Single_Single = new(this, "SetHorizontal", 0, typeof(System.Single), typeof(System.Single));
					r_RSetHorizontal_Single_Single.SetBelong(this.instance);
				}
				return r_RSetHorizontal_Single_Single;
			}
		}

		/// <summary>
		/// Void SetVertical(Single, Single)
		/// </summary>
		protected RMethod r_RSetVertical_Single_Single;
		public virtual RMethod RSetVertical_Single_Single
		{
			get
			{
				if(r_RSetVertical_Single_Single == null)
				{
					r_RSetVertical_Single_Single = new(this, "SetVertical", 0, typeof(System.Single), typeof(System.Single));
					r_RSetVertical_Single_Single.SetBelong(this.instance);
				}
				return r_RSetVertical_Single_Single;
			}
		}

		/// <summary>
		/// Void ApplyStyleSettings(UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_RApplyStyleSettings_GUIStyle;
		public virtual RMethod RApplyStyleSettings_GUIStyle
		{
			get
			{
				if(r_RApplyStyleSettings_GUIStyle == null)
				{
					r_RApplyStyleSettings_GUIStyle = new(this, "ApplyStyleSettings", 0, typeof(UnityEngine.GUIStyle));
					r_RApplyStyleSettings_GUIStyle.SetBelong(this.instance);
				}
				return r_RApplyStyleSettings_GUIStyle;
			}
		}

		/// <summary>
		/// Void ApplyOptions(UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_RApplyOptions_GUILayoutOptionArray;
		public virtual RMethod RApplyOptions_GUILayoutOptionArray
		{
			get
			{
				if(r_RApplyOptions_GUILayoutOptionArray == null)
				{
					r_RApplyOptions_GUILayoutOptionArray = new(this, "ApplyOptions", 0, typeof(UnityEngine.GUILayoutOption).MakeArrayType());
					r_RApplyOptions_GUILayoutOptionArray.SetBelong(this.instance);
				}
				return r_RApplyOptions_GUILayoutOptionArray;
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


        public RGUILayoutEntry() : base("UnityEngine.GUILayoutEntry")
        {
        }

        public RGUILayoutEntry(System.Object instance) : base("UnityEngine.GUILayoutEntry")
		{
            SetInstance(instance);
		}

        public RGUILayoutEntry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUILayoutEntry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CalcWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalcWidth.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalcHeight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHorizontal(System.Single  @x, System.Single  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @width};
            var ___result = RSetHorizontal_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertical(System.Single  @y, System.Single  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@y, @height};
            var ___result = RSetVertical_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleSettings(UnityEngine.GUIStyle  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RApplyStyleSettings_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyOptions(UnityEngine.GUILayoutOption[]  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options};
            var ___result = RApplyOptions_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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