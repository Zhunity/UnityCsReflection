
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls
{
	/// <summary>
	/// UnityEditor.IMGUI.Controls.AdvancedDropdownGUI
	/// </summary>
    public partial class RAdvancedDropdownGUI : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownGUI");
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


		/// <summary>
		/// UnityEngine.Vector2 s_IconSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fs_IconSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFs_IconSize
		{
			get
			{
				if(r_Fs_IconSize == null)
				{
					r_Fs_IconSize = new(this, "s_IconSize");
				}
				return r_Fs_IconSize;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource m_DataSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource r_Fm_DataSource;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource RFm_DataSource
		{
			get
			{
				if(r_Fm_DataSource == null)
				{
					r_Fm_DataSource = new(this, "m_DataSource");
				}
				return r_Fm_DataSource;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_SearchRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_SearchRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_SearchRect
		{
			get
			{
				if(r_Fm_SearchRect == null)
				{
					r_Fm_SearchRect = new(this, "m_SearchRect");
				}
				return r_Fm_SearchRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_HeaderRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_HeaderRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_HeaderRect
		{
			get
			{
				if(r_Fm_HeaderRect == null)
				{
					r_Fm_HeaderRect = new(this, "m_HeaderRect");
				}
				return r_Fm_HeaderRect;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState <state>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_F__0__state__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState RF__0__state__1__k__BackingField
		{
			get
			{
				if(r_F__0__state__1__k__BackingField == null)
				{
					r_F__0__state__1__k__BackingField = new(this, "<state>k__BackingField");
				}
				return r_F__0__state__1__k__BackingField;
			}
		}

		/// <summary>
		/// Single searchHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PsearchHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPsearchHeight
		{
			get
			{
				if(r_PsearchHeight == null)
				{
					r_PsearchHeight = new(this, "searchHeight", -1);
				}
				return r_PsearchHeight;
			}
		}

		/// <summary>
		/// Single headerHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PheaderHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPheaderHeight
		{
			get
			{
				if(r_PheaderHeight == null)
				{
					r_PheaderHeight = new(this, "headerHeight", -1);
				}
				return r_PheaderHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle lineStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_PlineStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RPlineStyle
		{
			get
			{
				if(r_PlineStyle == null)
				{
					r_PlineStyle = new(this, "lineStyle", -1);
				}
				return r_PlineStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 iconSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PiconSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPiconSize
		{
			get
			{
				if(r_PiconSize == null)
				{
					r_PiconSize = new(this, "iconSize", -1);
				}
				return r_PiconSize;
			}
		}

		/// <summary>
		/// UnityEditor.IMGUI.Controls.AdvancedDropdownState state
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState r_Pstate;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownState RPstate
		{
			get
			{
				if(r_Pstate == null)
				{
					r_Pstate = new(this, "state", -1);
				}
				return r_Pstate;
			}
		}

		/// <summary>
		/// Void LoadStyles()
		/// </summary>
		protected static RMethod r_MLoadStyles;
		public static RMethod RMLoadStyles
		{
			get
			{
				if(r_MLoadStyles == null)
				{
					r_MLoadStyles = new( ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownGUI"), "LoadStyles", 0);
				}
				return r_MLoadStyles;
			}
		}

		/// <summary>
		/// Void DrawItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, System.String, UnityEngine.Texture2D, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean = new(this, "DrawItem", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.String), typeof(UnityEngine.Texture2D), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawLineSeparator()
		/// </summary>
		protected RMethod r_MDrawLineSeparator;
		public virtual RMethod RMDrawLineSeparator
		{
			get
			{
				if(r_MDrawLineSeparator == null)
				{
					r_MDrawLineSeparator = new(this, "DrawLineSeparator", 0);
				}
				return r_MDrawLineSeparator;
			}
		}

		/// <summary>
		/// Void DrawHeader(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, System.Action, Boolean)
		/// </summary>
		protected RMethod r_MDrawHeader_AdvancedDropdownItem_Action_Boolean;
		public virtual RMethod RMDrawHeader_AdvancedDropdownItem_Action_Boolean
		{
			get
			{
				if(r_MDrawHeader_AdvancedDropdownItem_Action_Boolean == null)
				{
					r_MDrawHeader_AdvancedDropdownItem_Action_Boolean = new(this, "DrawHeader", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(System.Action), typeof(System.Boolean));
				}
				return r_MDrawHeader_AdvancedDropdownItem_Action_Boolean;
			}
		}

		/// <summary>
		/// Void DrawSearchField(Boolean, System.String, System.Action`1[System.String])
		/// </summary>
		protected RMethod r_MDrawSearchField_Boolean_String_Action_d_String_p_;
		public virtual RMethod RMDrawSearchField_Boolean_String_Action_d_String_p_
		{
			get
			{
				if(r_MDrawSearchField_Boolean_String_Action_d_String_p_ == null)
				{
					r_MDrawSearchField_Boolean_String_Action_d_String_p_ = new(this, "DrawSearchField", 0, typeof(System.Boolean), typeof(System.String),  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(System.String)));
				}
				return r_MDrawSearchField_Boolean_String_Action_d_String_p_;
			}
		}

		/// <summary>
		/// System.String DrawSearchFieldControl(System.String)
		/// </summary>
		protected RMethod r_MDrawSearchFieldControl_String;
		public virtual RMethod RMDrawSearchFieldControl_String
		{
			get
			{
				if(r_MDrawSearchFieldControl_String == null)
				{
					r_MDrawSearchFieldControl_String = new(this, "DrawSearchFieldControl", 0, typeof(System.String));
				}
				return r_MDrawSearchFieldControl_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CalculateSearchRect(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MCalculateSearchRect_Ref_Rect;
		public virtual RMethod RMCalculateSearchRect_Ref_Rect
		{
			get
			{
				if(r_MCalculateSearchRect_Ref_Rect == null)
				{
					r_MCalculateSearchRect_Ref_Rect = new(this, "CalculateSearchRect", 0, typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MCalculateSearchRect_Ref_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetAnimRect(UnityEngine.Rect, Single)
		/// </summary>
		protected RMethod r_MGetAnimRect_Rect_Single;
		public virtual RMethod RMGetAnimRect_Rect_Single
		{
			get
			{
				if(r_MGetAnimRect_Rect_Single == null)
				{
					r_MGetAnimRect_Rect_Single = new(this, "GetAnimRect", 0, typeof(UnityEngine.Rect), typeof(System.Single));
				}
				return r_MGetAnimRect_Rect_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalculateContentSize(UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource)
		/// </summary>
		protected RMethod r_MCalculateContentSize_AdvancedDropdownDataSource;
		public virtual RMethod RMCalculateContentSize_AdvancedDropdownDataSource
		{
			get
			{
				if(r_MCalculateContentSize_AdvancedDropdownDataSource == null)
				{
					r_MCalculateContentSize_AdvancedDropdownDataSource = new(this, "CalculateContentSize", 0,  ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource"));
				}
				return r_MCalculateContentSize_AdvancedDropdownDataSource;
			}
		}

		/// <summary>
		/// Single GetSelectionHeight(UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MGetSelectionHeight_AdvancedDropdownDataSource_Rect;
		public virtual RMethod RMGetSelectionHeight_AdvancedDropdownDataSource_Rect
		{
			get
			{
				if(r_MGetSelectionHeight_AdvancedDropdownDataSource_Rect == null)
				{
					r_MGetSelectionHeight_AdvancedDropdownDataSource_Rect = new(this, "GetSelectionHeight", 0,  ReflectionUtils.GetType("UnityEditor.IMGUI.Controls.AdvancedDropdownDataSource"), typeof(UnityEngine.Rect));
				}
				return r_MGetSelectionHeight_AdvancedDropdownDataSource_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetItemRect(UnityEngine.GUIContent ByRef)
		/// </summary>
		protected RMethod r_MGetItemRect_In_GUIContent;
		public virtual RMethod RMGetItemRect_In_GUIContent
		{
			get
			{
				if(r_MGetItemRect_In_GUIContent == null)
				{
					r_MGetItemRect_In_GUIContent = new(this, "GetItemRect", 0, typeof(UnityEngine.GUIContent).MakeByRefType());
				}
				return r_MGetItemRect_In_GUIContent;
			}
		}

		/// <summary>
		/// Single CalcItemHeight(UnityEngine.GUIContent, Single)
		/// </summary>
		protected RMethod r_MCalcItemHeight_GUIContent_Single;
		public virtual RMethod RMCalcItemHeight_GUIContent_Single
		{
			get
			{
				if(r_MCalcItemHeight_GUIContent_Single == null)
				{
					r_MCalcItemHeight_GUIContent_Single = new(this, "CalcItemHeight", 0, typeof(UnityEngine.GUIContent), typeof(System.Single));
				}
				return r_MCalcItemHeight_GUIContent_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalcItemSize(UnityEngine.GUIContent)
		/// </summary>
		protected RMethod r_MCalcItemSize_GUIContent;
		public virtual RMethod RMCalcItemSize_GUIContent
		{
			get
			{
				if(r_MCalcItemSize_GUIContent == null)
				{
					r_MCalcItemSize_GUIContent = new(this, "CalcItemSize", 0, typeof(UnityEngine.GUIContent));
				}
				return r_MCalcItemSize_GUIContent;
			}
		}

		/// <summary>
		/// Void DrawItemContent(UnityEditor.IMGUI.Controls.AdvancedDropdownItem, UnityEngine.Rect, UnityEngine.GUIContent, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RMDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean = new(this, "DrawItemContent", 0, typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), typeof(UnityEngine.Rect), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean;
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


        public static void LoadStyles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadStyles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawItem(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item, System.String @name, UnityEngine.Texture2D @icon, System.Boolean @enabled, System.Boolean @drawArrow, System.Boolean @selected, System.Boolean @hasSearch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @name, @icon, @enabled, @drawArrow, @selected, @hasSearch};
            var ___result = RMDrawItem_AdvancedDropdownItem_String_Texture2D_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawLineSeparator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawLineSeparator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawHeader(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @group, System.Action @backButtonPressed, System.Boolean @hasParent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group, @backButtonPressed, @hasParent};
            var ___result = RMDrawHeader_AdvancedDropdownItem_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawSearchField(System.Boolean @isSearchFieldDisabled, System.String @searchString, System.Action<System.String> @searchChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isSearchFieldDisabled, @searchString, @searchChanged};
            var ___result = RMDrawSearchField_Boolean_String_Action_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String DrawSearchFieldControl(System.String @searchString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@searchString};
            var ___result = RMDrawSearchFieldControl_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Rect CalculateSearchRect(ref UnityEngine.Rect @controlRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@controlRect};
            var ___result = RMCalculateSearchRect_Ref_Rect.Invoke(___genericsType, ___parameters);
			@controlRect = (UnityEngine.Rect)___parameters[0];

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect GetAnimRect(UnityEngine.Rect @position, System.Single @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @anim};
            var ___result = RMGetAnimRect_Rect_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Vector2 CalculateContentSize(Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource @dataSource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dataSource.Value};
            var ___result = RMCalculateContentSize_AdvancedDropdownDataSource.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Single GetSelectionHeight(Hvak.Editor.Refleaction.RUnityEditor.RIMGUI.RControls.RAdvancedDropdownDataSource @dataSource, UnityEngine.Rect @buttonRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dataSource.Value, @buttonRect};
            var ___result = RMGetSelectionHeight_AdvancedDropdownDataSource_Rect.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Rect GetItemRect(in UnityEngine.GUIContent @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RMGetItemRect_In_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Single CalcItemHeight(UnityEngine.GUIContent @content, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @width};
            var ___result = RMCalcItemHeight_GUIContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Vector2 CalcItemSize(UnityEngine.GUIContent @content)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content};
            var ___result = RMCalcItemSize_GUIContent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void DrawItemContent(UnityEditor.IMGUI.Controls.AdvancedDropdownItem @item, UnityEngine.Rect @rect, UnityEngine.GUIContent @content, System.Boolean @isHover, System.Boolean @isActive, System.Boolean @on, System.Boolean @hasKeyboardFocus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @rect, @content, @isHover, @isActive, @on, @hasKeyboardFocus};
            var ___result = RMDrawItemContent_AdvancedDropdownItem_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
