using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditorInternal
{public partial class RReorderableList
{
	
	/// <summary>
	/// UnityEditorInternal.ReorderableList+Defaults
	/// </summary>
    public partial class RDefaults : RMember //
    {

		/// <summary>
		/// UnityEngine.GUIContent iconToolbarPlus
		/// </summary>
		protected RUnityEngine.RGUIContent r_iconToolbarPlus;
		public virtual RUnityEngine.RGUIContent RiconToolbarPlus
		{
			get
			{
				if(r_iconToolbarPlus == null)
				{
					r_iconToolbarPlus = new(this, "iconToolbarPlus");
					r_iconToolbarPlus.SetBelong(this.instance);
				}
				return r_iconToolbarPlus;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent iconToolbarPlusMore
		/// </summary>
		protected RUnityEngine.RGUIContent r_iconToolbarPlusMore;
		public virtual RUnityEngine.RGUIContent RiconToolbarPlusMore
		{
			get
			{
				if(r_iconToolbarPlusMore == null)
				{
					r_iconToolbarPlusMore = new(this, "iconToolbarPlusMore");
					r_iconToolbarPlusMore.SetBelong(this.instance);
				}
				return r_iconToolbarPlusMore;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent iconToolbarMinus
		/// </summary>
		protected RUnityEngine.RGUIContent r_iconToolbarMinus;
		public virtual RUnityEngine.RGUIContent RiconToolbarMinus
		{
			get
			{
				if(r_iconToolbarMinus == null)
				{
					r_iconToolbarMinus = new(this, "iconToolbarMinus");
					r_iconToolbarMinus.SetBelong(this.instance);
				}
				return r_iconToolbarMinus;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle draggingHandle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_draggingHandle;
		public virtual RUnityEngine.RGUIStyle RdraggingHandle
		{
			get
			{
				if(r_draggingHandle == null)
				{
					r_draggingHandle = new(this, "draggingHandle");
					r_draggingHandle.SetBelong(this.instance);
				}
				return r_draggingHandle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle headerBackground
		/// </summary>
		protected RUnityEngine.RGUIStyle r_headerBackground;
		public virtual RUnityEngine.RGUIStyle RheaderBackground
		{
			get
			{
				if(r_headerBackground == null)
				{
					r_headerBackground = new(this, "headerBackground");
					r_headerBackground.SetBelong(this.instance);
				}
				return r_headerBackground;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle emptyHeaderBackground
		/// </summary>
		protected RUnityEngine.RGUIStyle r_emptyHeaderBackground;
		public virtual RUnityEngine.RGUIStyle RemptyHeaderBackground
		{
			get
			{
				if(r_emptyHeaderBackground == null)
				{
					r_emptyHeaderBackground = new(this, "emptyHeaderBackground");
					r_emptyHeaderBackground.SetBelong(this.instance);
				}
				return r_emptyHeaderBackground;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle footerBackground
		/// </summary>
		protected RUnityEngine.RGUIStyle r_footerBackground;
		public virtual RUnityEngine.RGUIStyle RfooterBackground
		{
			get
			{
				if(r_footerBackground == null)
				{
					r_footerBackground = new(this, "footerBackground");
					r_footerBackground.SetBelong(this.instance);
				}
				return r_footerBackground;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle boxBackground
		/// </summary>
		protected RUnityEngine.RGUIStyle r_boxBackground;
		public virtual RUnityEngine.RGUIStyle RboxBackground
		{
			get
			{
				if(r_boxBackground == null)
				{
					r_boxBackground = new(this, "boxBackground");
					r_boxBackground.SetBelong(this.instance);
				}
				return r_boxBackground;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle preButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_preButton;
		public virtual RUnityEngine.RGUIStyle RpreButton
		{
			get
			{
				if(r_preButton == null)
				{
					r_preButton = new(this, "preButton");
					r_preButton.SetBelong(this.instance);
				}
				return r_preButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle elementBackground
		/// </summary>
		protected RUnityEngine.RGUIStyle r_elementBackground;
		public virtual RUnityEngine.RGUIStyle RelementBackground
		{
			get
			{
				if(r_elementBackground == null)
				{
					r_elementBackground = new(this, "elementBackground");
					r_elementBackground.SetBelong(this.instance);
				}
				return r_elementBackground;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle defaultLabel
		/// </summary>
		protected RUnityEngine.RGUIStyle r_defaultLabel;
		public virtual RUnityEngine.RGUIStyle RdefaultLabel
		{
			get
			{
				if(r_defaultLabel == null)
				{
					r_defaultLabel = new(this, "defaultLabel");
					r_defaultLabel.SetBelong(this.instance);
				}
				return r_defaultLabel;
			}
		}

		/// <summary>
		/// System.Int32 padding
		/// </summary>
		protected static RField r_padding;
		public static RField Rpadding
		{
			get
			{
				if(r_padding == null)
				{
					r_padding = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "padding");
					r_padding.SetBelong(null);
				}
				return r_padding;
			}
		}

		/// <summary>
		/// System.Int32 dragHandleWidth
		/// </summary>
		protected static RField r_dragHandleWidth;
		public static RField RdragHandleWidth
		{
			get
			{
				if(r_dragHandleWidth == null)
				{
					r_dragHandleWidth = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "dragHandleWidth");
					r_dragHandleWidth.SetBelong(null);
				}
				return r_dragHandleWidth;
			}
		}

		/// <summary>
		/// System.Int32 propertyDrawerPadding
		/// </summary>
		protected static RField r_propertyDrawerPadding;
		public static RField RpropertyDrawerPadding
		{
			get
			{
				if(r_propertyDrawerPadding == null)
				{
					r_propertyDrawerPadding = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "propertyDrawerPadding");
					r_propertyDrawerPadding.SetBelong(null);
				}
				return r_propertyDrawerPadding;
			}
		}

		/// <summary>
		/// System.Int32 minHeaderHeight
		/// </summary>
		protected static RField r_minHeaderHeight;
		public static RField RminHeaderHeight
		{
			get
			{
				if(r_minHeaderHeight == null)
				{
					r_minHeaderHeight = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "minHeaderHeight");
					r_minHeaderHeight.SetBelong(null);
				}
				return r_minHeaderHeight;
			}
		}

		/// <summary>
		/// System.Single elementPadding
		/// </summary>
		protected static RField r_elementPadding;
		public static RField RelementPadding
		{
			get
			{
				if(r_elementPadding == null)
				{
					r_elementPadding = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "elementPadding");
					r_elementPadding.SetBelong(null);
				}
				return r_elementPadding;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent s_ListIsEmpty
		/// </summary>
		protected static RUnityEngine.RGUIContent r_s_ListIsEmpty;
		public static RUnityEngine.RGUIContent Rs_ListIsEmpty
		{
			get
			{
				if(r_s_ListIsEmpty == null)
				{
					r_s_ListIsEmpty = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "s_ListIsEmpty");
					r_s_ListIsEmpty.SetBelong(null);
				}
				return r_s_ListIsEmpty;
			}
		}

		/// <summary>
		/// System.String undoAdd
		/// </summary>
		protected static RField r_undoAdd;
		public static RField RundoAdd
		{
			get
			{
				if(r_undoAdd == null)
				{
					r_undoAdd = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "undoAdd");
					r_undoAdd.SetBelong(null);
				}
				return r_undoAdd;
			}
		}

		/// <summary>
		/// System.String undoRemove
		/// </summary>
		protected static RField r_undoRemove;
		public static RField RundoRemove
		{
			get
			{
				if(r_undoRemove == null)
				{
					r_undoRemove = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "undoRemove");
					r_undoRemove.SetBelong(null);
				}
				return r_undoRemove;
			}
		}

		/// <summary>
		/// System.String undoMove
		/// </summary>
		protected static RField r_undoMove;
		public static RField RundoMove
		{
			get
			{
				if(r_undoMove == null)
				{
					r_undoMove = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "undoMove");
					r_undoMove.SetBelong(null);
				}
				return r_undoMove;
			}
		}

		/// <summary>
		/// UnityEngine.Rect infinityRect
		/// </summary>
		protected static RUnityEngine.RRect r_infinityRect;
		public static RUnityEngine.RRect RinfinityRect
		{
			get
			{
				if(r_infinityRect == null)
				{
					r_infinityRect = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "infinityRect");
					r_infinityRect.SetBelong(null);
				}
				return r_infinityRect;
			}
		}

		/// <summary>
		/// Int32 ArrayCountInPropertyPath(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_ArrayCountInPropertyPath_SerializedProperty;
		public virtual RMethod RArrayCountInPropertyPath_SerializedProperty
		{
			get
			{
				if(r_ArrayCountInPropertyPath_SerializedProperty == null)
				{
					r_ArrayCountInPropertyPath_SerializedProperty = new(this, "ArrayCountInPropertyPath", 0, typeof(UnityEditor.SerializedProperty));
					r_ArrayCountInPropertyPath_SerializedProperty.SetBelong(this.instance);
				}
				return r_ArrayCountInPropertyPath_SerializedProperty;
			}
		}

		/// <summary>
		/// Single FieldLabelSize(UnityEngine.Rect, UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_FieldLabelSize_Rect_SerializedProperty;
		public virtual RMethod RFieldLabelSize_Rect_SerializedProperty
		{
			get
			{
				if(r_FieldLabelSize_Rect_SerializedProperty == null)
				{
					r_FieldLabelSize_Rect_SerializedProperty = new(this, "FieldLabelSize", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty));
					r_FieldLabelSize_Rect_SerializedProperty.SetBelong(this.instance);
				}
				return r_FieldLabelSize_Rect_SerializedProperty;
			}
		}

		/// <summary>
		/// Single ElementPadding(Single)
		/// </summary>
		protected static RMethod r_ElementPadding_Single;
		public static RMethod RElementPadding_Single
		{
			get
			{
				if(r_ElementPadding_Single == null)
				{
					r_ElementPadding_Single = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "ElementPadding", 0, typeof(System.Single));
					r_ElementPadding_Single.SetBelong(null);
				}
				return r_ElementPadding_Single;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent OverMaxMultiEditLimit(Int32)
		/// </summary>
		protected static RMethod r_OverMaxMultiEditLimit_Int32;
		public static RMethod ROverMaxMultiEditLimit_Int32
		{
			get
			{
				if(r_OverMaxMultiEditLimit_Int32 == null)
				{
					r_OverMaxMultiEditLimit_Int32 = new( ReleactionUtils.GetType("UnityEditorInternal.ReorderableList+Defaults"), "OverMaxMultiEditLimit", 0, typeof(System.Int32));
					r_OverMaxMultiEditLimit_Int32.SetBelong(null);
				}
				return r_OverMaxMultiEditLimit_Int32;
			}
		}

		/// <summary>
		/// Void DrawFooter(UnityEngine.Rect, UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_DrawFooter_Rect_ReorderableList;
		public virtual RMethod RDrawFooter_Rect_ReorderableList
		{
			get
			{
				if(r_DrawFooter_Rect_ReorderableList == null)
				{
					r_DrawFooter_Rect_ReorderableList = new(this, "DrawFooter", 0, typeof(UnityEngine.Rect), typeof(UnityEditorInternal.ReorderableList));
					r_DrawFooter_Rect_ReorderableList.SetBelong(this.instance);
				}
				return r_DrawFooter_Rect_ReorderableList;
			}
		}

		/// <summary>
		/// Void DoAddButton(UnityEditorInternal.ReorderableList, UnityEngine.Object)
		/// </summary>
		protected RMethod r_DoAddButton_ReorderableList_Object;
		public virtual RMethod RDoAddButton_ReorderableList_Object
		{
			get
			{
				if(r_DoAddButton_ReorderableList_Object == null)
				{
					r_DoAddButton_ReorderableList_Object = new(this, "DoAddButton", 0, typeof(UnityEditorInternal.ReorderableList), typeof(UnityEngine.Object));
					r_DoAddButton_ReorderableList_Object.SetBelong(this.instance);
				}
				return r_DoAddButton_ReorderableList_Object;
			}
		}

		/// <summary>
		/// Void DoAddButton(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_DoAddButton_ReorderableList;
		public virtual RMethod RDoAddButton_ReorderableList
		{
			get
			{
				if(r_DoAddButton_ReorderableList == null)
				{
					r_DoAddButton_ReorderableList = new(this, "DoAddButton", 0, typeof(UnityEditorInternal.ReorderableList));
					r_DoAddButton_ReorderableList.SetBelong(this.instance);
				}
				return r_DoAddButton_ReorderableList;
			}
		}

		/// <summary>
		/// Void DoRemoveButton(UnityEditorInternal.ReorderableList)
		/// </summary>
		protected RMethod r_DoRemoveButton_ReorderableList;
		public virtual RMethod RDoRemoveButton_ReorderableList
		{
			get
			{
				if(r_DoRemoveButton_ReorderableList == null)
				{
					r_DoRemoveButton_ReorderableList = new(this, "DoRemoveButton", 0, typeof(UnityEditorInternal.ReorderableList));
					r_DoRemoveButton_ReorderableList.SetBelong(this.instance);
				}
				return r_DoRemoveButton_ReorderableList;
			}
		}

		/// <summary>
		/// Void DrawHeaderBackground(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DrawHeaderBackground_Rect;
		public virtual RMethod RDrawHeaderBackground_Rect
		{
			get
			{
				if(r_DrawHeaderBackground_Rect == null)
				{
					r_DrawHeaderBackground_Rect = new(this, "DrawHeaderBackground", 0, typeof(UnityEngine.Rect));
					r_DrawHeaderBackground_Rect.SetBelong(this.instance);
				}
				return r_DrawHeaderBackground_Rect;
			}
		}

		/// <summary>
		/// Void DrawHeader(UnityEngine.Rect, UnityEditor.SerializedObject, UnityEditor.SerializedProperty, System.Collections.IList)
		/// </summary>
		protected RMethod r_DrawHeader_Rect_SerializedObject_SerializedProperty_IList;
		public virtual RMethod RDrawHeader_Rect_SerializedObject_SerializedProperty_IList
		{
			get
			{
				if(r_DrawHeader_Rect_SerializedObject_SerializedProperty_IList == null)
				{
					r_DrawHeader_Rect_SerializedObject_SerializedProperty_IList = new(this, "DrawHeader", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedObject), typeof(UnityEditor.SerializedProperty), typeof(System.Collections.IList));
					r_DrawHeader_Rect_SerializedObject_SerializedProperty_IList.SetBelong(this.instance);
				}
				return r_DrawHeader_Rect_SerializedObject_SerializedProperty_IList;
			}
		}

		/// <summary>
		/// Void DrawElementBackground(UnityEngine.Rect, Int32, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_DrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean;
		public virtual RMethod RDrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_DrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean == null)
				{
					r_DrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean = new(this, "DrawElementBackground", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_DrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawElementDraggingHandle(UnityEngine.Rect, Int32, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_DrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean;
		public virtual RMethod RDrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_DrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean == null)
				{
					r_DrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean = new(this, "DrawElementDraggingHandle", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_DrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawElement(UnityEngine.Rect, UnityEditor.SerializedProperty, System.Object, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean;
		public virtual RMethod RDrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean == null)
				{
					r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean = new(this, "DrawElement", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawElement(UnityEngine.Rect, UnityEditor.SerializedProperty, System.Object, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RDrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean = new(this, "DrawElement", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(System.Object), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void DrawNoneElement(UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_DrawNoneElement_Rect_Boolean;
		public virtual RMethod RDrawNoneElement_Rect_Boolean
		{
			get
			{
				if(r_DrawNoneElement_Rect_Boolean == null)
				{
					r_DrawNoneElement_Rect_Boolean = new(this, "DrawNoneElement", 0, typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_DrawNoneElement_Rect_Boolean.SetBelong(this.instance);
				}
				return r_DrawNoneElement_Rect_Boolean;
			}
		}

		/// <summary>
		/// Void DrawOverMaxMultiEditElement(UnityEngine.Rect, Int32, Boolean)
		/// </summary>
		protected RMethod r_DrawOverMaxMultiEditElement_Rect_Int32_Boolean;
		public virtual RMethod RDrawOverMaxMultiEditElement_Rect_Int32_Boolean
		{
			get
			{
				if(r_DrawOverMaxMultiEditElement_Rect_Int32_Boolean == null)
				{
					r_DrawOverMaxMultiEditElement_Rect_Int32_Boolean = new(this, "DrawOverMaxMultiEditElement", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Boolean));
					r_DrawOverMaxMultiEditElement_Rect_Int32_Boolean.SetBelong(this.instance);
				}
				return r_DrawOverMaxMultiEditElement_Rect_Int32_Boolean;
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


        public RDefaults() : base("UnityEditorInternal.ReorderableList+Defaults")
        {
        }

        public RDefaults(System.Object instance) : base("UnityEditorInternal.ReorderableList+Defaults")
		{
            SetInstance(instance);
		}

        public RDefaults(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDefaults(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 ArrayCountInPropertyPath(UnityEditor.SerializedProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RArrayCountInPropertyPath_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single FieldLabelSize(UnityEngine.Rect  @r, UnityEditor.SerializedProperty  @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@r, @prop};
            var ___result = RFieldLabelSize_Rect_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single ElementPadding(System.Single  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@height};
            var ___result = RElementPadding_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.GUIContent OverMaxMultiEditLimit(System.Int32  @maxMultiEditElementCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxMultiEditElementCount};
            var ___result = ROverMaxMultiEditLimit_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIContent)___result;
        }


        public virtual void DrawFooter(UnityEngine.Rect  @rect, UnityEditorInternal.ReorderableList  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @list};
            var ___result = RDrawFooter_Rect_ReorderableList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoAddButton(UnityEditorInternal.ReorderableList  @list, UnityEngine.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @value};
            var ___result = RDoAddButton_ReorderableList_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoAddButton(UnityEditorInternal.ReorderableList  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RDoAddButton_ReorderableList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoRemoveButton(UnityEditorInternal.ReorderableList  @list)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list};
            var ___result = RDoRemoveButton_ReorderableList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawHeaderBackground(UnityEngine.Rect  @headerRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headerRect};
            var ___result = RDrawHeaderBackground_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawHeader(UnityEngine.Rect  @headerRect, UnityEditor.SerializedObject  @serializedObject, UnityEditor.SerializedProperty  @element, System.Collections.IList  @elementList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headerRect, @serializedObject, @element, @elementList};
            var ___result = RDrawHeader_Rect_SerializedObject_SerializedProperty_IList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawElementBackground(UnityEngine.Rect  @rect, System.Int32  @index, System.Boolean  @selected, System.Boolean  @focused, System.Boolean  @draggable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @index, @selected, @focused, @draggable};
            var ___result = RDrawElementBackground_Rect_Int32_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawElementDraggingHandle(UnityEngine.Rect  @rect, System.Int32  @index, System.Boolean  @selected, System.Boolean  @focused, System.Boolean  @draggable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @index, @selected, @focused, @draggable};
            var ___result = RDrawElementDraggingHandle_Rect_Int32_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawElement(UnityEngine.Rect  @rect, UnityEditor.SerializedProperty  @element, System.Object  @listItem, System.Boolean  @selected, System.Boolean  @focused, System.Boolean  @draggable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @element, @listItem, @selected, @focused, @draggable};
            var ___result = RDrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawElement(UnityEngine.Rect  @rect, UnityEditor.SerializedProperty  @element, System.Object  @listItem, System.Boolean  @selected, System.Boolean  @focused, System.Boolean  @draggable, System.Boolean  @editable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @element, @listItem, @selected, @focused, @draggable, @editable};
            var ___result = RDrawElement_Rect_SerializedProperty_Object_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawNoneElement(UnityEngine.Rect  @rect, System.Boolean  @draggable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @draggable};
            var ___result = RDrawNoneElement_Rect_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawOverMaxMultiEditElement(UnityEngine.Rect  @rect, System.Int32  @maxMultiEditElementCount, System.Boolean  @draggable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @maxMultiEditElementCount, @draggable};
            var ___result = RDrawOverMaxMultiEditElement_Rect_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
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
}