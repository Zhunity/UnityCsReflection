using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownGUI
	/// </summary>
    public partial class RAdvancedDropdownGUI : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 s_IconSize
		/// </summary>
		protected RUnityEngine.RVector2 r_s_IconSize;
		public virtual RUnityEngine.RVector2 Rs_IconSize
		{
			get
			{
				if(r_s_IconSize == null)
				{
					r_s_IconSize = new(this, "s_IconSize");
					r_s_IconSize.SetBelong(this.instance);
				}
				return r_s_IconSize;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource m_DataSource
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource r_m_DataSource;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource Rm_DataSource
		{
			get
			{
				if(r_m_DataSource == null)
				{
					r_m_DataSource = new(this, "m_DataSource");
					r_m_DataSource.SetBelong(this.instance);
				}
				return r_m_DataSource;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_SearchRect
		/// </summary>
		protected RUnityEngine.RRect r_m_SearchRect;
		public virtual RUnityEngine.RRect Rm_SearchRect
		{
			get
			{
				if(r_m_SearchRect == null)
				{
					r_m_SearchRect = new(this, "m_SearchRect");
					r_m_SearchRect.SetBelong(this.instance);
				}
				return r_m_SearchRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_HeaderRect
		/// </summary>
		protected RUnityEngine.RRect r_m_HeaderRect;
		public virtual RUnityEngine.RRect Rm_HeaderRect
		{
			get
			{
				if(r_m_HeaderRect == null)
				{
					r_m_HeaderRect = new(this, "m_HeaderRect");
					r_m_HeaderRect.SetBelong(this.instance);
				}
				return r_m_HeaderRect;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState <state>k__BackingField
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r___0__state__1__k__BackingField;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState R__0__state__1__k__BackingField
		{
			get
			{
				if(r___0__state__1__k__BackingField == null)
				{
					r___0__state__1__k__BackingField = new(this, "<state>k__BackingField");
					r___0__state__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__state__1__k__BackingField;
			}
		}

		/// <summary>
		/// Single searchHeight
		/// </summary>
		protected RProperty r_searchHeight;
		public virtual RProperty RsearchHeight
		{
			get
			{
				if(r_searchHeight == null)
				{
					r_searchHeight = new(this, "searchHeight", -1);
					r_searchHeight.SetBelong(this.instance);
				}
				return r_searchHeight;
			}
		}

		/// <summary>
		/// Single headerHeight
		/// </summary>
		protected RProperty r_headerHeight;
		public virtual RProperty RheaderHeight
		{
			get
			{
				if(r_headerHeight == null)
				{
					r_headerHeight = new(this, "headerHeight", -1);
					r_headerHeight.SetBelong(this.instance);
				}
				return r_headerHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle lineStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_lineStyle;
		public virtual RUnityEngine.RGUIStyle RlineStyle
		{
			get
			{
				if(r_lineStyle == null)
				{
					r_lineStyle = new(this, "lineStyle", -1);
					r_lineStyle.SetBelong(this.instance);
				}
				return r_lineStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 iconSize
		/// </summary>
		protected RUnityEngine.RVector2 r_iconSize;
		public virtual RUnityEngine.RVector2 RiconSize
		{
			get
			{
				if(r_iconSize == null)
				{
					r_iconSize = new(this, "iconSize", -1);
					r_iconSize.SetBelong(this.instance);
				}
				return r_iconSize;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState state
		/// </summary>
		protected RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_state;
		public virtual RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state", -1);
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// Void LoadStyles()
		/// </summary>
		protected static RMethod r_LoadStyles;
		public static RMethod RLoadStyles
		{
			get
			{
				if(r_LoadStyles == null)
				{
					r_LoadStyles = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownGUI"), "LoadStyles", 0);
					r_LoadStyles.SetBelong(null);
				}
				return r_LoadStyles;
			}
		}

		/// <summary>
		/// Void DrawItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, System.String, UnityEngine.Texture2D, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_DrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_DrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_DrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean = new(this, "DrawItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.String), typeof(UnityEngine.Texture2D), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_DrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawLineSeparator()
		/// </summary>
		protected RMethod r_DrawLineSeparator;
		public virtual RMethod RDrawLineSeparator
		{
			get
			{
				if(r_DrawLineSeparator == null)
				{
					r_DrawLineSeparator = new(this, "DrawLineSeparator", 0);
					r_DrawLineSeparator.SetBelong(this.instance);
				}
				return r_DrawLineSeparator;
			}
		}

		/// <summary>
		/// Void DrawHeader(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, System.Action, Boolean)
		/// </summary>
		protected RMethod r_DrawHeader_AdvancedDropdownItem_Action_Boolean;
		public virtual RMethod RDrawHeader_AdvancedDropdownItem_Action_Boolean
		{
			get
			{
				if(r_DrawHeader_AdvancedDropdownItem_Action_Boolean == null)
				{
					r_DrawHeader_AdvancedDropdownItem_Action_Boolean = new(this, "DrawHeader", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.Action), typeof(System.Boolean));
					r_DrawHeader_AdvancedDropdownItem_Action_Boolean.SetBelong(this.instance);
				}
				return r_DrawHeader_AdvancedDropdownItem_Action_Boolean;
			}
		}

		/// <summary>
		/// Void DrawSearchField(Boolean, System.String, System.Action`1[System.String])
		/// </summary>
		protected RMethod r_DrawSearchField_Boolean_String_Action_d_String_p_;
		public virtual RMethod RDrawSearchField_Boolean_String_Action_d_String_p_
		{
			get
			{
				if(r_DrawSearchField_Boolean_String_Action_d_String_p_ == null)
				{
					r_DrawSearchField_Boolean_String_Action_d_String_p_ = new(this, "DrawSearchField", 0, typeof(System.Boolean), typeof(System.String), typeof(System.Action<>).MakeGenericType(typeof(System.String)));
					r_DrawSearchField_Boolean_String_Action_d_String_p_.SetBelong(this.instance);
				}
				return r_DrawSearchField_Boolean_String_Action_d_String_p_;
			}
		}

		/// <summary>
		/// System.String DrawSearchFieldControl(System.String)
		/// </summary>
		protected RMethod r_DrawSearchFieldControl_String;
		public virtual RMethod RDrawSearchFieldControl_String
		{
			get
			{
				if(r_DrawSearchFieldControl_String == null)
				{
					r_DrawSearchFieldControl_String = new(this, "DrawSearchFieldControl", 0, typeof(System.String));
					r_DrawSearchFieldControl_String.SetBelong(this.instance);
				}
				return r_DrawSearchFieldControl_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CalculateSearchRect(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_CalculateSearchRect_Ref_Rect;
		public virtual RMethod RCalculateSearchRect_Ref_Rect
		{
			get
			{
				if(r_CalculateSearchRect_Ref_Rect == null)
				{
					r_CalculateSearchRect_Ref_Rect = new(this, "CalculateSearchRect", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_CalculateSearchRect_Ref_Rect.SetBelong(this.instance);
				}
				return r_CalculateSearchRect_Ref_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetAnimRect(UnityEngine.Rect, Single)
		/// </summary>
		protected RMethod r_GetAnimRect_Rect_Single;
		public virtual RMethod RGetAnimRect_Rect_Single
		{
			get
			{
				if(r_GetAnimRect_Rect_Single == null)
				{
					r_GetAnimRect_Rect_Single = new(this, "GetAnimRect", 0, typeof(UnityEngine.Rect), typeof(System.Single));
					r_GetAnimRect_Rect_Single.SetBelong(this.instance);
				}
				return r_GetAnimRect_Rect_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalculateContentSize(UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource)
		/// </summary>
		protected RMethod r_CalculateContentSize_AdvancedDropdownDataSource;
		public virtual RMethod RCalculateContentSize_AdvancedDropdownDataSource
		{
			get
			{
				if(r_CalculateContentSize_AdvancedDropdownDataSource == null)
				{
					r_CalculateContentSize_AdvancedDropdownDataSource = new(this, "CalculateContentSize", 0,  ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource"));
					r_CalculateContentSize_AdvancedDropdownDataSource.SetBelong(this.instance);
				}
				return r_CalculateContentSize_AdvancedDropdownDataSource;
			}
		}

		/// <summary>
		/// Single GetSelectionHeight(UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GetSelectionHeight_AdvancedDropdownDataSource_Rect;
		public virtual RMethod RGetSelectionHeight_AdvancedDropdownDataSource_Rect
		{
			get
			{
				if(r_GetSelectionHeight_AdvancedDropdownDataSource_Rect == null)
				{
					r_GetSelectionHeight_AdvancedDropdownDataSource_Rect = new(this, "GetSelectionHeight", 0,  ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource"), typeof(UnityEngine.Rect));
					r_GetSelectionHeight_AdvancedDropdownDataSource_Rect.SetBelong(this.instance);
				}
				return r_GetSelectionHeight_AdvancedDropdownDataSource_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetItemRect(UnityEngine.GUIContent ByRef)
		/// </summary>
		protected RMethod r_GetItemRect_In_GUIContent;
		public virtual RMethod RGetItemRect_In_GUIContent
		{
			get
			{
				if(r_GetItemRect_In_GUIContent == null)
				{
					r_GetItemRect_In_GUIContent = new(this, "GetItemRect", 0, typeof(UnityEngine.GUIContent).MakeByRefType());
					r_GetItemRect_In_GUIContent.SetBelong(this.instance);
				}
				return r_GetItemRect_In_GUIContent;
			}
		}

		/// <summary>
		/// Single CalcItemHeight(UnityEngine.GUIContent, Single)
		/// </summary>
		protected RMethod r_CalcItemHeight_GUIContent_Single;
		public virtual RMethod RCalcItemHeight_GUIContent_Single
		{
			get
			{
				if(r_CalcItemHeight_GUIContent_Single == null)
				{
					r_CalcItemHeight_GUIContent_Single = new(this, "CalcItemHeight", 0, typeof(UnityEngine.GUIContent), typeof(System.Single));
					r_CalcItemHeight_GUIContent_Single.SetBelong(this.instance);
				}
				return r_CalcItemHeight_GUIContent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcItemSize(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_CalcItemSize_GUIContent;
		public virtual RMethod RCalcItemSize_GUIContent
		{
			get
			{
				if(r_CalcItemSize_GUIContent == null)
				{
					r_CalcItemSize_GUIContent = new(this, "CalcItemSize", 0, typeof(UnityEngine.GUIContent));
					r_CalcItemSize_GUIContent.SetBelong(this.instance);
				}
				return r_CalcItemSize_GUIContent;
			}
		}

		/// <summary>
		/// Void DrawItemContent(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_DrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_DrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_DrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "DrawItemContent", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_DrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
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


        public RAdvancedDropdownGUI() : base("UnityEditor.IMGUI.Controls.AdvancedDropdownGUI")
        {
        }

        public RAdvancedDropdownGUI(System.Object instance) : base("UnityEditor.IMGUI.Controls.AdvancedDropdownGUI")
		{
            SetInstance(instance);
		}

        public RAdvancedDropdownGUI(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAdvancedDropdownGUI(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void LoadStyles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item, System.String  @name, UnityEngine.Texture2D  @icon, System.Boolean  @enabled, System.Boolean  @drawArrow, System.Boolean  @selected, System.Boolean  @hasSearch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @name, @icon, @enabled, @drawArrow, @selected, @hasSearch};
            var ___result = RDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawLineSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawLineSeparator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawHeader(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @group, System.Action  @backButtonPressed, System.Boolean  @hasParent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group, @backButtonPressed, @hasParent};
            var ___result = RDrawHeader_AdvancedDropdownItem_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawSearchField(System.Boolean  @isSearchFieldDisabled, System.String  @searchString, System.Action<System.String>  @searchChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isSearchFieldDisabled, @searchString, @searchChanged};
            var ___result = RDrawSearchField_Boolean_String_Action_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String DrawSearchFieldControl(System.String  @searchString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchString};
            var ___result = RDrawSearchFieldControl_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect CalculateSearchRect(ref UnityEngine.Rect  @controlRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@controlRect};
            var ___result = RCalculateSearchRect_Ref_Rect.Invoke(___genericsType, ___parameters);
			controlRect = (UnityEngine.Rect)___parameters[0];

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect GetAnimRect(UnityEngine.Rect  @position, System.Single  @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @anim};
            var ___result = RGetAnimRect_Rect_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }




        public virtual UnityEngine.Rect GetItemRect(in UnityEngine.GUIContent  @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RGetItemRect_In_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Single CalcItemHeight(UnityEngine.GUIContent  @content, System.Single  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @width};
            var ___result = RCalcItemHeight_GUIContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector2 CalcItemSize(UnityEngine.GUIContent  @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RCalcItemSize_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void DrawItemContent(UnityEditor.IMGUI.Controls.AdvancedDropdownItem  @item, UnityEngine.Rect  @rect, UnityEngine.GUIContent  @content, System.Boolean  @isHover, System.Boolean  @isActive, System.Boolean  @on, System.Boolean  @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @rect, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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
