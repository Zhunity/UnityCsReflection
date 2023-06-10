
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUILayoutEntry
	/// </summary>
    public partial class RGUILayoutEntry : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.GUILayoutEntry");
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


		/// <summary>
		/// System.Single minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FminWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFminWidth
		{
			get
			{
				if(r_FminWidth == null)
				{
					r_FminWidth = new(this, "minWidth");
				}
				return r_FminWidth;
			}
		}

		/// <summary>
		/// System.Single maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmaxWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmaxWidth
		{
			get
			{
				if(r_FmaxWidth == null)
				{
					r_FmaxWidth = new(this, "maxWidth");
				}
				return r_FmaxWidth;
			}
		}

		/// <summary>
		/// System.Single minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FminHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFminHeight
		{
			get
			{
				if(r_FminHeight == null)
				{
					r_FminHeight = new(this, "minHeight");
				}
				return r_FminHeight;
			}
		}

		/// <summary>
		/// System.Single maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmaxHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmaxHeight
		{
			get
			{
				if(r_FmaxHeight == null)
				{
					r_FmaxHeight = new(this, "maxHeight");
				}
				return r_FmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Frect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFrect
		{
			get
			{
				if(r_Frect == null)
				{
					r_Frect = new(this, "rect");
				}
				return r_Frect;
			}
		}

		/// <summary>
		/// System.Int32 stretchWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstretchWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstretchWidth
		{
			get
			{
				if(r_FstretchWidth == null)
				{
					r_FstretchWidth = new(this, "stretchWidth");
				}
				return r_FstretchWidth;
			}
		}

		/// <summary>
		/// System.Int32 stretchHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstretchHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstretchHeight
		{
			get
			{
				if(r_FstretchHeight == null)
				{
					r_FstretchHeight = new(this, "stretchHeight");
				}
				return r_FstretchHeight;
			}
		}

		/// <summary>
		/// System.Boolean consideredForMargin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FconsideredForMargin;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFconsideredForMargin
		{
			get
			{
				if(r_FconsideredForMargin == null)
				{
					r_FconsideredForMargin = new(this, "consideredForMargin");
				}
				return r_FconsideredForMargin;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_Style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_Fm_Style;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RFm_Style
		{
			get
			{
				if(r_Fm_Style == null)
				{
					r_Fm_Style = new(this, "m_Style");
				}
				return r_Fm_Style;
			}
		}

		/// <summary>
		/// UnityEngine.Rect kDummyRect
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRect r_FkDummyRect;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRect RFkDummyRect
		{
			get
			{
				if(r_FkDummyRect == null)
				{
					r_FkDummyRect = new( ReflectionUtils.GetType("UnityEngine.GUILayoutEntry"), "kDummyRect");
				}
				return r_FkDummyRect;
			}
		}

		/// <summary>
		/// System.Int32 indent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Findent;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFindent
		{
			get
			{
				if(r_Findent == null)
				{
					r_Findent = new( ReflectionUtils.GetType("UnityEngine.GUILayoutEntry"), "indent");
				}
				return r_Findent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_Pstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RPstyle
		{
			get
			{
				if(r_Pstyle == null)
				{
					r_Pstyle = new(this, "style", -1);
				}
				return r_Pstyle;
			}
		}

		/// <summary>
		/// Int32 marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// Int32 marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// Int32 marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// Int32 marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// Int32 marginHorizontal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginHorizontal;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginHorizontal
		{
			get
			{
				if(r_PmarginHorizontal == null)
				{
					r_PmarginHorizontal = new(this, "marginHorizontal", -1);
				}
				return r_PmarginHorizontal;
			}
		}

		/// <summary>
		/// Int32 marginVertical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginVertical;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginVertical
		{
			get
			{
				if(r_PmarginVertical == null)
				{
					r_PmarginVertical = new(this, "marginVertical", -1);
				}
				return r_PmarginVertical;
			}
		}

		/// <summary>
		/// Void CalcWidth()
		/// </summary>
		protected RMethod r_MCalcWidth;
		public virtual RMethod RMCalcWidth
		{
			get
			{
				if(r_MCalcWidth == null)
				{
					r_MCalcWidth = new(this, "CalcWidth", 0);
				}
				return r_MCalcWidth;
			}
		}

		/// <summary>
		/// Void CalcHeight()
		/// </summary>
		protected RMethod r_MCalcHeight;
		public virtual RMethod RMCalcHeight
		{
			get
			{
				if(r_MCalcHeight == null)
				{
					r_MCalcHeight = new(this, "CalcHeight", 0);
				}
				return r_MCalcHeight;
			}
		}

		/// <summary>
		/// Void SetHorizontal(Single, Single)
		/// </summary>
		protected RMethod r_MSetHorizontal_Single_Single;
		public virtual RMethod RMSetHorizontal_Single_Single
		{
			get
			{
				if(r_MSetHorizontal_Single_Single == null)
				{
					r_MSetHorizontal_Single_Single = new(this, "SetHorizontal", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MSetHorizontal_Single_Single;
			}
		}

		/// <summary>
		/// Void SetVertical(Single, Single)
		/// </summary>
		protected RMethod r_MSetVertical_Single_Single;
		public virtual RMethod RMSetVertical_Single_Single
		{
			get
			{
				if(r_MSetVertical_Single_Single == null)
				{
					r_MSetVertical_Single_Single = new(this, "SetVertical", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MSetVertical_Single_Single;
			}
		}

		/// <summary>
		/// Void ApplyStyleSettings(UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MApplyStyleSettings_GUIStyle;
		public virtual RMethod RMApplyStyleSettings_GUIStyle
		{
			get
			{
				if(r_MApplyStyleSettings_GUIStyle == null)
				{
					r_MApplyStyleSettings_GUIStyle = new(this, "ApplyStyleSettings", 0, typeof(UnityEngine.GUIStyle));
				}
				return r_MApplyStyleSettings_GUIStyle;
			}
		}

		/// <summary>
		/// Void ApplyOptions(UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_MApplyOptions_GUILayoutOptionArray;
		public virtual RMethod RMApplyOptions_GUILayoutOptionArray
		{
			get
			{
				if(r_MApplyOptions_GUILayoutOptionArray == null)
				{
					r_MApplyOptions_GUILayoutOptionArray = new(this, "ApplyOptions", 0, typeof(UnityEngine.GUILayoutOption).MakeArrayType());
				}
				return r_MApplyOptions_GUILayoutOptionArray;
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


        public virtual void CalcWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalcWidth.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalcHeight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHorizontal(System.Single @x, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @width};
            var ___result = RMSetHorizontal_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertical(System.Single @y, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@y, @height};
            var ___result = RMSetVertical_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleSettings(UnityEngine.GUIStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RMApplyStyleSettings_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyOptions(UnityEngine.GUILayoutOption[] @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options};
            var ___result = RMApplyOptions_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
