using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PropertyHandler
	/// </summary>
    public partial class RPropertyHandler : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PropertyDrawer] m_PropertyDrawers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RPropertyDrawer> r_m_PropertyDrawers;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RPropertyDrawer> Rm_PropertyDrawers
		{
			get
			{
				if(r_m_PropertyDrawers == null)
				{
					r_m_PropertyDrawers = new(this, "m_PropertyDrawers");
					r_m_PropertyDrawers.SetBelong(this.instance);
				}
				return r_m_PropertyDrawers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.DecoratorDrawer] m_DecoratorDrawers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RDecoratorDrawer> r_m_DecoratorDrawers;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RDecoratorDrawer> Rm_DecoratorDrawers
		{
			get
			{
				if(r_m_DecoratorDrawers == null)
				{
					r_m_DecoratorDrawers = new(this, "m_DecoratorDrawers");
					r_m_DecoratorDrawers.SetBelong(this.instance);
				}
				return r_m_DecoratorDrawers;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RField r_tooltip;
		public virtual RField Rtooltip
		{
			get
			{
				if(r_tooltip == null)
				{
					r_tooltip = new(this, "tooltip");
					r_tooltip.SetBelong(this.instance);
				}
				return r_tooltip;
			}
		}

		/// <summary>
		/// System.Int32 m_NestingLevel
		/// </summary>
		protected RField r_m_NestingLevel;
		public virtual RField Rm_NestingLevel
		{
			get
			{
				if(r_m_NestingLevel == null)
				{
					r_m_NestingLevel = new(this, "m_NestingLevel");
					r_m_NestingLevel.SetBelong(this.instance);
				}
				return r_m_NestingLevel;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditorInternal.ReorderableListWrapper] s_reorderableLists
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditorInternal.RReorderableListWrapper> r_s_reorderableLists;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEditorInternal.RReorderableListWrapper> Rs_reorderableLists
		{
			get
			{
				if(r_s_reorderableLists == null)
				{
					r_s_reorderableLists = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "s_reorderableLists");
					r_s_reorderableLists.SetBelong(null);
				}
				return r_s_reorderableLists;
			}
		}

		/// <summary>
		/// System.Int32 s_LastInspectionTarget
		/// </summary>
		protected static RField r_s_LastInspectionTarget;
		public static RField Rs_LastInspectionTarget
		{
			get
			{
				if(r_s_LastInspectionTarget == null)
				{
					r_s_LastInspectionTarget = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "s_LastInspectionTarget");
					r_s_LastInspectionTarget.SetBelong(null);
				}
				return r_s_LastInspectionTarget;
			}
		}

		/// <summary>
		/// System.Int32 s_LastInspectorNumComponents
		/// </summary>
		protected static RField r_s_LastInspectorNumComponents;
		public static RField Rs_LastInspectorNumComponents
		{
			get
			{
				if(r_s_LastInspectorNumComponents == null)
				{
					r_s_LastInspectorNumComponents = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "s_LastInspectorNumComponents");
					r_s_LastInspectorNumComponents.SetBelong(null);
				}
				return r_s_LastInspectorNumComponents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.ContextMenuItemAttribute] contextMenuItems
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RContextMenuItemAttribute> r_contextMenuItems;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RContextMenuItemAttribute> RcontextMenuItems
		{
			get
			{
				if(r_contextMenuItems == null)
				{
					r_contextMenuItems = new(this, "contextMenuItems");
					r_contextMenuItems.SetBelong(this.instance);
				}
				return r_contextMenuItems;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Component] s_CachedComponents
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RComponent> r_s_CachedComponents;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RComponent> Rs_CachedComponents
		{
			get
			{
				if(r_s_CachedComponents == null)
				{
					r_s_CachedComponents = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "s_CachedComponents");
					r_s_CachedComponents.SetBelong(null);
				}
				return r_s_CachedComponents;
			}
		}

		/// <summary>
		/// Boolean hasPropertyDrawer
		/// </summary>
		protected RProperty r_hasPropertyDrawer;
		public virtual RProperty RhasPropertyDrawer
		{
			get
			{
				if(r_hasPropertyDrawer == null)
				{
					r_hasPropertyDrawer = new(this, "hasPropertyDrawer", -1);
					r_hasPropertyDrawer.SetBelong(this.instance);
				}
				return r_hasPropertyDrawer;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyDrawer propertyDrawer
		/// </summary>
		protected RUnityEditor.RPropertyDrawer r_propertyDrawer;
		public virtual RUnityEditor.RPropertyDrawer RpropertyDrawer
		{
			get
			{
				if(r_propertyDrawer == null)
				{
					r_propertyDrawer = new(this, "propertyDrawer", -1);
					r_propertyDrawer.SetBelong(this.instance);
				}
				return r_propertyDrawer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.DecoratorDrawer] decoratorDrawers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEditor.RDecoratorDrawer> r_decoratorDrawers;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEditor.RDecoratorDrawer> RdecoratorDrawers
		{
			get
			{
				if(r_decoratorDrawers == null)
				{
					r_decoratorDrawers = new(this, "decoratorDrawers", -1);
					r_decoratorDrawers.SetBelong(this.instance);
				}
				return r_decoratorDrawers;
			}
		}

		/// <summary>
		/// Boolean isCurrentlyNested
		/// </summary>
		protected RProperty r_isCurrentlyNested;
		public virtual RProperty RisCurrentlyNested
		{
			get
			{
				if(r_isCurrentlyNested == null)
				{
					r_isCurrentlyNested = new(this, "isCurrentlyNested", -1);
					r_isCurrentlyNested.SetBelong(this.instance);
				}
				return r_isCurrentlyNested;
			}
		}

		/// <summary>
		/// Boolean empty
		/// </summary>
		protected RProperty r_empty;
		public virtual RProperty Rempty
		{
			get
			{
				if(r_empty == null)
				{
					r_empty = new(this, "empty", -1);
					r_empty.SetBelong(this.instance);
				}
				return r_empty;
			}
		}

		/// <summary>
		/// Void OnUndoRedo(UnityEditor.UndoRedoInfo ByRef)
		/// </summary>
		protected static RMethod r_ROnUndoRedo_In_UndoRedoInfo;
		public static RMethod ROnUndoRedo_In_UndoRedoInfo
		{
			get
			{
				if(r_ROnUndoRedo_In_UndoRedoInfo == null)
				{
					r_ROnUndoRedo_In_UndoRedoInfo = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "OnUndoRedo", 0, typeof(UnityEditor.UndoRedoInfo).MakeByRefType());
					r_ROnUndoRedo_In_UndoRedoInfo.SetBelong(null);
				}
				return r_ROnUndoRedo_In_UndoRedoInfo;
			}
		}

		/// <summary>
		/// Void ClearCache()
		/// </summary>
		protected static RMethod r_RClearCache;
		public static RMethod RClearCache
		{
			get
			{
				if(r_RClearCache == null)
				{
					r_RClearCache = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "ClearCache", 0);
					r_RClearCache.SetBelong(null);
				}
				return r_RClearCache;
			}
		}

		/// <summary>
		/// Void InvalidateListCacheIncludingChildren(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RInvalidateListCacheIncludingChildren_SerializedProperty;
		public static RMethod RInvalidateListCacheIncludingChildren_SerializedProperty
		{
			get
			{
				if(r_RInvalidateListCacheIncludingChildren_SerializedProperty == null)
				{
					r_RInvalidateListCacheIncludingChildren_SerializedProperty = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "InvalidateListCacheIncludingChildren", 0, typeof(UnityEditor.SerializedProperty));
					r_RInvalidateListCacheIncludingChildren_SerializedProperty.SetBelong(null);
				}
				return r_RInvalidateListCacheIncludingChildren_SerializedProperty;
			}
		}

		/// <summary>
		/// Void HandleAttribute(UnityEditor.SerializedProperty, UnityEngine.PropertyAttribute, System.Reflection.FieldInfo, System.Type)
		/// </summary>
		protected RMethod r_RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type;
		public virtual RMethod RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type
		{
			get
			{
				if(r_RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type == null)
				{
					r_RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type = new(this, "HandleAttribute", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.PropertyAttribute), typeof(System.Reflection.FieldInfo), typeof(System.Type));
					r_RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type.SetBelong(this.instance);
				}
				return r_RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type;
			}
		}

		/// <summary>
		/// Void HandleDrawnType(UnityEditor.SerializedProperty, System.Type, System.Type, System.Reflection.FieldInfo, UnityEngine.PropertyAttribute)
		/// </summary>
		protected RMethod r_RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute;
		public virtual RMethod RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute
		{
			get
			{
				if(r_RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute == null)
				{
					r_RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute = new(this, "HandleDrawnType", 0, typeof(UnityEditor.SerializedProperty), typeof(System.Type), typeof(System.Type), typeof(System.Reflection.FieldInfo), typeof(UnityEngine.PropertyAttribute));
					r_RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute.SetBelong(this.instance);
				}
				return r_RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute;
			}
		}

		/// <summary>
		/// Boolean OnGUI(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean)
		/// </summary>
		protected RMethod r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean;
		public virtual RMethod ROnGUI_Rect_SerializedProperty_GUIContent_Boolean
		{
			get
			{
				if(r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean == null)
				{
					r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean = new(this, "OnGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean));
					r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean.SetBelong(this.instance);
				}
				return r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean;
			}
		}

		/// <summary>
		/// Boolean OnGUI(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect;
		public virtual RMethod ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect
		{
			get
			{
				if(r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect == null)
				{
					r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect = new(this, "OnGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(UnityEngine.Rect));
					r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect.SetBelong(this.instance);
				}
				return r_ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect;
			}
		}

		/// <summary>
		/// Boolean OnGUILayout(UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean, UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray;
		public virtual RMethod ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray
		{
			get
			{
				if(r_ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray == null)
				{
					r_ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray = new(this, "OnGUILayout", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(UnityEngine.GUILayoutOption).MakeArrayType());
					r_ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray.SetBelong(this.instance);
				}
				return r_ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray;
			}
		}

		/// <summary>
		/// Single GetHeight(UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean)
		/// </summary>
		protected RMethod r_RGetHeight_SerializedProperty_GUIContent_Boolean;
		public virtual RMethod RGetHeight_SerializedProperty_GUIContent_Boolean
		{
			get
			{
				if(r_RGetHeight_SerializedProperty_GUIContent_Boolean == null)
				{
					r_RGetHeight_SerializedProperty_GUIContent_Boolean = new(this, "GetHeight", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean));
					r_RGetHeight_SerializedProperty_GUIContent_Boolean.SetBelong(this.instance);
				}
				return r_RGetHeight_SerializedProperty_GUIContent_Boolean;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_RCanCacheInspectorGUI_SerializedProperty;
		public virtual RMethod RCanCacheInspectorGUI_SerializedProperty
		{
			get
			{
				if(r_RCanCacheInspectorGUI_SerializedProperty == null)
				{
					r_RCanCacheInspectorGUI_SerializedProperty = new(this, "CanCacheInspectorGUI", 0, typeof(UnityEditor.SerializedProperty));
					r_RCanCacheInspectorGUI_SerializedProperty.SetBelong(this.instance);
				}
				return r_RCanCacheInspectorGUI_SerializedProperty;
			}
		}

		/// <summary>
		/// Void AddMenuItems(UnityEditor.SerializedProperty, UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_RAddMenuItems_SerializedProperty_GenericMenu;
		public virtual RMethod RAddMenuItems_SerializedProperty_GenericMenu
		{
			get
			{
				if(r_RAddMenuItems_SerializedProperty_GenericMenu == null)
				{
					r_RAddMenuItems_SerializedProperty_GenericMenu = new(this, "AddMenuItems", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.GenericMenu));
					r_RAddMenuItems_SerializedProperty_GenericMenu.SetBelong(this.instance);
				}
				return r_RAddMenuItems_SerializedProperty_GenericMenu;
			}
		}

		/// <summary>
		/// Void CallMenuCallback(System.Object[], System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RCallMenuCallback_ObjectArray_MethodInfo;
		public virtual RMethod RCallMenuCallback_ObjectArray_MethodInfo
		{
			get
			{
				if(r_RCallMenuCallback_ObjectArray_MethodInfo == null)
				{
					r_RCallMenuCallback_ObjectArray_MethodInfo = new(this, "CallMenuCallback", 0, typeof(System.Object).MakeArrayType(), typeof(System.Reflection.MethodInfo));
					r_RCallMenuCallback_ObjectArray_MethodInfo.SetBelong(this.instance);
				}
				return r_RCallMenuCallback_ObjectArray_MethodInfo;
			}
		}

		/// <summary>
		/// Void TestInvalidateCache()
		/// </summary>
		protected RMethod r_RTestInvalidateCache;
		public virtual RMethod RTestInvalidateCache
		{
			get
			{
				if(r_RTestInvalidateCache == null)
				{
					r_RTestInvalidateCache = new(this, "TestInvalidateCache", 0);
					r_RTestInvalidateCache.SetBelong(this.instance);
				}
				return r_RTestInvalidateCache;
			}
		}

		/// <summary>
		/// Boolean IsNonStringArray(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RIsNonStringArray_SerializedProperty;
		public static RMethod RIsNonStringArray_SerializedProperty
		{
			get
			{
				if(r_RIsNonStringArray_SerializedProperty == null)
				{
					r_RIsNonStringArray_SerializedProperty = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "IsNonStringArray", 0, typeof(UnityEditor.SerializedProperty));
					r_RIsNonStringArray_SerializedProperty.SetBelong(null);
				}
				return r_RIsNonStringArray_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean IsArrayReorderable(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RIsArrayReorderable_SerializedProperty;
		public static RMethod RIsArrayReorderable_SerializedProperty
		{
			get
			{
				if(r_RIsArrayReorderable_SerializedProperty == null)
				{
					r_RIsArrayReorderable_SerializedProperty = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "IsArrayReorderable", 0, typeof(UnityEditor.SerializedProperty));
					r_RIsArrayReorderable_SerializedProperty.SetBelong(null);
				}
				return r_RIsArrayReorderable_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean UseReorderabelListControl(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_RUseReorderabelListControl_SerializedProperty;
		public static RMethod RUseReorderabelListControl_SerializedProperty
		{
			get
			{
				if(r_RUseReorderabelListControl_SerializedProperty == null)
				{
					r_RUseReorderabelListControl_SerializedProperty = new( ReleactionUtils.GetType("UnityEditor.PropertyHandler"), "UseReorderabelListControl", 0, typeof(UnityEditor.SerializedProperty));
					r_RUseReorderabelListControl_SerializedProperty.SetBelong(null);
				}
				return r_RUseReorderabelListControl_SerializedProperty;
			}
		}

		/// <summary>
		/// NestingContext ApplyNestingContext(Int32)
		/// </summary>
		protected RMethod r_RApplyNestingContext_Int32;
		public virtual RMethod RApplyNestingContext_Int32
		{
			get
			{
				if(r_RApplyNestingContext_Int32 == null)
				{
					r_RApplyNestingContext_Int32 = new(this, "ApplyNestingContext", 0, typeof(System.Int32));
					r_RApplyNestingContext_Int32.SetBelong(this.instance);
				}
				return r_RApplyNestingContext_Int32;
			}
		}

		/// <summary>
		/// NestingContext IncrementNestingContext()
		/// </summary>
		protected RMethod r_RIncrementNestingContext;
		public virtual RMethod RIncrementNestingContext
		{
			get
			{
				if(r_RIncrementNestingContext == null)
				{
					r_RIncrementNestingContext = new(this, "IncrementNestingContext", 0);
					r_RIncrementNestingContext.SetBelong(this.instance);
				}
				return r_RIncrementNestingContext;
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


        public RPropertyHandler() : base("UnityEditor.PropertyHandler")
        {
        }

        public RPropertyHandler(System.Object instance) : base("UnityEditor.PropertyHandler")
		{
            SetInstance(instance);
		}

        public RPropertyHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void OnUndoRedo(in UnityEditor.UndoRedoInfo  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = ROnUndoRedo_In_UndoRedoInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public static void InvalidateListCacheIncludingChildren(UnityEditor.SerializedProperty  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RInvalidateListCacheIncludingChildren_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleAttribute(UnityEditor.SerializedProperty  @property, UnityEngine.PropertyAttribute  @attribute, System.Reflection.FieldInfo  @field, System.Type  @propertyType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @attribute, @field, @propertyType};
            var ___result = RHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDrawnType(UnityEditor.SerializedProperty  @property, System.Type  @drawnType, System.Type  @propertyType, System.Reflection.FieldInfo  @field, UnityEngine.PropertyAttribute  @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @drawnType, @propertyType, @field, @attribute};
            var ___result = RHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnGUI(UnityEngine.Rect  @position, UnityEditor.SerializedProperty  @property, UnityEngine.GUIContent  @label, System.Boolean  @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label, @includeChildren};
            var ___result = ROnGUI_Rect_SerializedProperty_GUIContent_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean OnGUI(UnityEngine.Rect  @position, UnityEditor.SerializedProperty  @property, UnityEngine.GUIContent  @label, System.Boolean  @includeChildren, UnityEngine.Rect  @visibleArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label, @includeChildren, @visibleArea};
            var ___result = ROnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean OnGUILayout(UnityEditor.SerializedProperty  @property, UnityEngine.GUIContent  @label, System.Boolean  @includeChildren, UnityEngine.GUILayoutOption[]  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label, @includeChildren, @options};
            var ___result = ROnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetHeight(UnityEditor.SerializedProperty  @property, UnityEngine.GUIContent  @label, System.Boolean  @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label, @includeChildren};
            var ___result = RGetHeight_SerializedProperty_GUIContent_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RCanCacheInspectorGUI_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddMenuItems(UnityEditor.SerializedProperty  @property, UnityEditor.GenericMenu  @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @menu};
            var ___result = RAddMenuItems_SerializedProperty_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CallMenuCallback(System.Object[]  @targets, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targets, @method};
            var ___result = RCallMenuCallback_ObjectArray_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TestInvalidateCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTestInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsNonStringArray(UnityEditor.SerializedProperty  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RIsNonStringArray_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsArrayReorderable(UnityEditor.SerializedProperty  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RIsArrayReorderable_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean UseReorderabelListControl(UnityEditor.SerializedProperty  @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RUseReorderabelListControl_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object ApplyNestingContext(System.Int32  @nestingLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nestingLevel};
            var ___result = RApplyNestingContext_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object IncrementNestingContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIncrementNestingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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