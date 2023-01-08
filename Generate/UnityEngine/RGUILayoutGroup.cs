using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUILayoutGroup
	/// </summary>
    public partial class RGUILayoutGroup : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GUILayoutEntry] entries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGUILayoutEntry> r_entries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGUILayoutEntry> Rentries
		{
			get
			{
				if(r_entries == null)
				{
					r_entries = new(this, "entries");
					r_entries.SetBelong(this.instance);
				}
				return r_entries;
			}
		}

		/// <summary>
		/// System.Boolean isVertical
		/// </summary>
		protected RField r_isVertical;
		public virtual RField RisVertical
		{
			get
			{
				if(r_isVertical == null)
				{
					r_isVertical = new(this, "isVertical");
					r_isVertical.SetBelong(this.instance);
				}
				return r_isVertical;
			}
		}

		/// <summary>
		/// System.Boolean resetCoords
		/// </summary>
		protected RField r_resetCoords;
		public virtual RField RresetCoords
		{
			get
			{
				if(r_resetCoords == null)
				{
					r_resetCoords = new(this, "resetCoords");
					r_resetCoords.SetBelong(this.instance);
				}
				return r_resetCoords;
			}
		}

		/// <summary>
		/// System.Single spacing
		/// </summary>
		protected RField r_spacing;
		public virtual RField Rspacing
		{
			get
			{
				if(r_spacing == null)
				{
					r_spacing = new(this, "spacing");
					r_spacing.SetBelong(this.instance);
				}
				return r_spacing;
			}
		}

		/// <summary>
		/// System.Boolean sameSize
		/// </summary>
		protected RField r_sameSize;
		public virtual RField RsameSize
		{
			get
			{
				if(r_sameSize == null)
				{
					r_sameSize = new(this, "sameSize");
					r_sameSize.SetBelong(this.instance);
				}
				return r_sameSize;
			}
		}

		/// <summary>
		/// System.Boolean isWindow
		/// </summary>
		protected RField r_isWindow;
		public virtual RField RisWindow
		{
			get
			{
				if(r_isWindow == null)
				{
					r_isWindow = new(this, "isWindow");
					r_isWindow.SetBelong(this.instance);
				}
				return r_isWindow;
			}
		}

		/// <summary>
		/// System.Int32 windowID
		/// </summary>
		protected RField r_windowID;
		public virtual RField RwindowID
		{
			get
			{
				if(r_windowID == null)
				{
					r_windowID = new(this, "windowID");
					r_windowID.SetBelong(this.instance);
				}
				return r_windowID;
			}
		}

		/// <summary>
		/// System.Int32 m_Cursor
		/// </summary>
		protected RField r_m_Cursor;
		public virtual RField Rm_Cursor
		{
			get
			{
				if(r_m_Cursor == null)
				{
					r_m_Cursor = new(this, "m_Cursor");
					r_m_Cursor.SetBelong(this.instance);
				}
				return r_m_Cursor;
			}
		}

		/// <summary>
		/// System.Int32 m_StretchableCountX
		/// </summary>
		protected RField r_m_StretchableCountX;
		public virtual RField Rm_StretchableCountX
		{
			get
			{
				if(r_m_StretchableCountX == null)
				{
					r_m_StretchableCountX = new(this, "m_StretchableCountX");
					r_m_StretchableCountX.SetBelong(this.instance);
				}
				return r_m_StretchableCountX;
			}
		}

		/// <summary>
		/// System.Int32 m_StretchableCountY
		/// </summary>
		protected RField r_m_StretchableCountY;
		public virtual RField Rm_StretchableCountY
		{
			get
			{
				if(r_m_StretchableCountY == null)
				{
					r_m_StretchableCountY = new(this, "m_StretchableCountY");
					r_m_StretchableCountY.SetBelong(this.instance);
				}
				return r_m_StretchableCountY;
			}
		}

		/// <summary>
		/// System.Boolean m_UserSpecifiedWidth
		/// </summary>
		protected RField r_m_UserSpecifiedWidth;
		public virtual RField Rm_UserSpecifiedWidth
		{
			get
			{
				if(r_m_UserSpecifiedWidth == null)
				{
					r_m_UserSpecifiedWidth = new(this, "m_UserSpecifiedWidth");
					r_m_UserSpecifiedWidth.SetBelong(this.instance);
				}
				return r_m_UserSpecifiedWidth;
			}
		}

		/// <summary>
		/// System.Boolean m_UserSpecifiedHeight
		/// </summary>
		protected RField r_m_UserSpecifiedHeight;
		public virtual RField Rm_UserSpecifiedHeight
		{
			get
			{
				if(r_m_UserSpecifiedHeight == null)
				{
					r_m_UserSpecifiedHeight = new(this, "m_UserSpecifiedHeight");
					r_m_UserSpecifiedHeight.SetBelong(this.instance);
				}
				return r_m_UserSpecifiedHeight;
			}
		}

		/// <summary>
		/// System.Single m_ChildMinWidth
		/// </summary>
		protected RField r_m_ChildMinWidth;
		public virtual RField Rm_ChildMinWidth
		{
			get
			{
				if(r_m_ChildMinWidth == null)
				{
					r_m_ChildMinWidth = new(this, "m_ChildMinWidth");
					r_m_ChildMinWidth.SetBelong(this.instance);
				}
				return r_m_ChildMinWidth;
			}
		}

		/// <summary>
		/// System.Single m_ChildMaxWidth
		/// </summary>
		protected RField r_m_ChildMaxWidth;
		public virtual RField Rm_ChildMaxWidth
		{
			get
			{
				if(r_m_ChildMaxWidth == null)
				{
					r_m_ChildMaxWidth = new(this, "m_ChildMaxWidth");
					r_m_ChildMaxWidth.SetBelong(this.instance);
				}
				return r_m_ChildMaxWidth;
			}
		}

		/// <summary>
		/// System.Single m_ChildMinHeight
		/// </summary>
		protected RField r_m_ChildMinHeight;
		public virtual RField Rm_ChildMinHeight
		{
			get
			{
				if(r_m_ChildMinHeight == null)
				{
					r_m_ChildMinHeight = new(this, "m_ChildMinHeight");
					r_m_ChildMinHeight.SetBelong(this.instance);
				}
				return r_m_ChildMinHeight;
			}
		}

		/// <summary>
		/// System.Single m_ChildMaxHeight
		/// </summary>
		protected RField r_m_ChildMaxHeight;
		public virtual RField Rm_ChildMaxHeight
		{
			get
			{
				if(r_m_ChildMaxHeight == null)
				{
					r_m_ChildMaxHeight = new(this, "m_ChildMaxHeight");
					r_m_ChildMaxHeight.SetBelong(this.instance);
				}
				return r_m_ChildMaxHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginLeft
		/// </summary>
		protected RField r_m_MarginLeft;
		public virtual RField Rm_MarginLeft
		{
			get
			{
				if(r_m_MarginLeft == null)
				{
					r_m_MarginLeft = new(this, "m_MarginLeft");
					r_m_MarginLeft.SetBelong(this.instance);
				}
				return r_m_MarginLeft;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginRight
		/// </summary>
		protected RField r_m_MarginRight;
		public virtual RField Rm_MarginRight
		{
			get
			{
				if(r_m_MarginRight == null)
				{
					r_m_MarginRight = new(this, "m_MarginRight");
					r_m_MarginRight.SetBelong(this.instance);
				}
				return r_m_MarginRight;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginTop
		/// </summary>
		protected RField r_m_MarginTop;
		public virtual RField Rm_MarginTop
		{
			get
			{
				if(r_m_MarginTop == null)
				{
					r_m_MarginTop = new(this, "m_MarginTop");
					r_m_MarginTop.SetBelong(this.instance);
				}
				return r_m_MarginTop;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginBottom
		/// </summary>
		protected RField r_m_MarginBottom;
		public virtual RField Rm_MarginBottom
		{
			get
			{
				if(r_m_MarginBottom == null)
				{
					r_m_MarginBottom = new(this, "m_MarginBottom");
					r_m_MarginBottom.SetBelong(this.instance);
				}
				return r_m_MarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutEntry none
		/// </summary>
		protected static RUnityEngine.RGUILayoutEntry r_none;
		public static RUnityEngine.RGUILayoutEntry Rnone
		{
			get
			{
				if(r_none == null)
				{
					r_none = new( ReflectionUtils.GetType("UnityEngine.GUILayoutGroup"), "none");
					r_none.SetBelong(null);
				}
				return r_none;
			}
		}

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
		/// Void ApplyOptions(UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_ApplyOptions_GUILayoutOptionArray;
		public virtual RMethod RApplyOptions_GUILayoutOptionArray
		{
			get
			{
				if(r_ApplyOptions_GUILayoutOptionArray == null)
				{
					r_ApplyOptions_GUILayoutOptionArray = new(this, "ApplyOptions", 0, typeof(UnityEngine.GUILayoutOption).MakeArrayType());
					r_ApplyOptions_GUILayoutOptionArray.SetBelong(this.instance);
				}
				return r_ApplyOptions_GUILayoutOptionArray;
			}
		}

		/// <summary>
		/// Void ApplyStyleSettings(UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_ApplyStyleSettings_GUIStyle;
		public virtual RMethod RApplyStyleSettings_GUIStyle
		{
			get
			{
				if(r_ApplyStyleSettings_GUIStyle == null)
				{
					r_ApplyStyleSettings_GUIStyle = new(this, "ApplyStyleSettings", 0, typeof(UnityEngine.GUIStyle));
					r_ApplyStyleSettings_GUIStyle.SetBelong(this.instance);
				}
				return r_ApplyStyleSettings_GUIStyle;
			}
		}

		/// <summary>
		/// Void ResetCursor()
		/// </summary>
		protected RMethod r_ResetCursor;
		public virtual RMethod RResetCursor
		{
			get
			{
				if(r_ResetCursor == null)
				{
					r_ResetCursor = new(this, "ResetCursor", 0);
					r_ResetCursor.SetBelong(this.instance);
				}
				return r_ResetCursor;
			}
		}

		/// <summary>
		/// UnityEngine.Rect PeekNext()
		/// </summary>
		protected RMethod r_PeekNext;
		public virtual RMethod RPeekNext
		{
			get
			{
				if(r_PeekNext == null)
				{
					r_PeekNext = new(this, "PeekNext", 0);
					r_PeekNext.SetBelong(this.instance);
				}
				return r_PeekNext;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutEntry GetNext()
		/// </summary>
		protected RMethod r_GetNext;
		public virtual RMethod RGetNext
		{
			get
			{
				if(r_GetNext == null)
				{
					r_GetNext = new(this, "GetNext", 0);
					r_GetNext.SetBelong(this.instance);
				}
				return r_GetNext;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetLast()
		/// </summary>
		protected RMethod r_GetLast;
		public virtual RMethod RGetLast
		{
			get
			{
				if(r_GetLast == null)
				{
					r_GetLast = new(this, "GetLast", 0);
					r_GetLast.SetBelong(this.instance);
				}
				return r_GetLast;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.GUILayoutEntry)
		/// </summary>
		protected RMethod r_Add_GUILayoutEntry;
		public virtual RMethod RAdd_GUILayoutEntry
		{
			get
			{
				if(r_Add_GUILayoutEntry == null)
				{
					r_Add_GUILayoutEntry = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.GUILayoutEntry"));
					r_Add_GUILayoutEntry.SetBelong(this.instance);
				}
				return r_Add_GUILayoutEntry;
			}
		}

		/// <summary>
		/// Void CalcWidth()
		/// </summary>
		protected RMethod r_CalcWidth;
		public virtual RMethod RCalcWidth
		{
			get
			{
				if(r_CalcWidth == null)
				{
					r_CalcWidth = new(this, "CalcWidth", 0);
					r_CalcWidth.SetBelong(this.instance);
				}
				return r_CalcWidth;
			}
		}

		/// <summary>
		/// Void SetHorizontal(Single, Single)
		/// </summary>
		protected RMethod r_SetHorizontal_Single_Single;
		public virtual RMethod RSetHorizontal_Single_Single
		{
			get
			{
				if(r_SetHorizontal_Single_Single == null)
				{
					r_SetHorizontal_Single_Single = new(this, "SetHorizontal", 0, typeof(System.Single), typeof(System.Single));
					r_SetHorizontal_Single_Single.SetBelong(this.instance);
				}
				return r_SetHorizontal_Single_Single;
			}
		}

		/// <summary>
		/// Void CalcHeight()
		/// </summary>
		protected RMethod r_CalcHeight;
		public virtual RMethod RCalcHeight
		{
			get
			{
				if(r_CalcHeight == null)
				{
					r_CalcHeight = new(this, "CalcHeight", 0);
					r_CalcHeight.SetBelong(this.instance);
				}
				return r_CalcHeight;
			}
		}

		/// <summary>
		/// Void SetVertical(Single, Single)
		/// </summary>
		protected RMethod r_SetVertical_Single_Single;
		public virtual RMethod RSetVertical_Single_Single
		{
			get
			{
				if(r_SetVertical_Single_Single == null)
				{
					r_SetVertical_Single_Single = new(this, "SetVertical", 0, typeof(System.Single), typeof(System.Single));
					r_SetVertical_Single_Single.SetBelong(this.instance);
				}
				return r_SetVertical_Single_Single;
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


        public RGUILayoutGroup() : base("UnityEngine.GUILayoutGroup")
        {
        }

        public RGUILayoutGroup(System.Object instance) : base("UnityEngine.GUILayoutGroup")
		{
            SetInstance(instance);
		}

        public RGUILayoutGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUILayoutGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ApplyOptions(UnityEngine.GUILayoutOption[] @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options};
            var ___result = RApplyOptions_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleSettings(UnityEngine.GUIStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RApplyStyleSettings_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect PeekNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeekNext.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual RUnityEngine.RGUILayoutEntry GetNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNext.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RGUILayoutEntry(___result);
        }


        public virtual UnityEngine.Rect GetLast()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLast.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Add(RUnityEngine.RGUILayoutEntry @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e.Value};
            var ___result = RAdd_GUILayoutEntry.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalcWidth.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHorizontal(System.Single @x, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @width};
            var ___result = RSetHorizontal_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalcHeight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertical(System.Single @y, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@y, @height};
            var ___result = RSetVertical_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
