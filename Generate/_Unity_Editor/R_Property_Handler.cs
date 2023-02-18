
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PropertyHandler
	/// </summary>
    public partial class RPropertyHandler : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.PropertyDrawer] m_PropertyDrawers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPropertyDrawer> r_Fm_PropertyDrawers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RPropertyDrawer> RFm_PropertyDrawers
		{
			get
			{
				if(r_Fm_PropertyDrawers == null)
				{
					r_Fm_PropertyDrawers = new(this, "m_PropertyDrawers");
				}
				return r_Fm_PropertyDrawers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.DecoratorDrawer] m_DecoratorDrawers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RDecoratorDrawer> r_Fm_DecoratorDrawers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RDecoratorDrawer> RFm_DecoratorDrawers
		{
			get
			{
				if(r_Fm_DecoratorDrawers == null)
				{
					r_Fm_DecoratorDrawers = new(this, "m_DecoratorDrawers");
				}
				return r_Fm_DecoratorDrawers;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ftooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtooltip
		{
			get
			{
				if(r_Ftooltip == null)
				{
					r_Ftooltip = new(this, "tooltip");
				}
				return r_Ftooltip;
			}
		}

		/// <summary>
		/// System.Boolean <skipDecoratorDrawers>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__skipDecoratorDrawers__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__skipDecoratorDrawers__1__k__BackingField
		{
			get
			{
				if(r_F__0__skipDecoratorDrawers__1__k__BackingField == null)
				{
					r_F__0__skipDecoratorDrawers__1__k__BackingField = new(this, "<skipDecoratorDrawers>k__BackingField");
				}
				return r_F__0__skipDecoratorDrawers__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 m_NestingLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NestingLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NestingLevel
		{
			get
			{
				if(r_Fm_NestingLevel == null)
				{
					r_Fm_NestingLevel = new(this, "m_NestingLevel");
				}
				return r_Fm_NestingLevel;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEditorInternal.ReorderableListWrapper] s_reorderableLists
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditorInternal.RReorderableListWrapper> r_Fs_reorderableLists;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEditorInternal.RReorderableListWrapper> RFs_reorderableLists
		{
			get
			{
				if(r_Fs_reorderableLists == null)
				{
					r_Fs_reorderableLists = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "s_reorderableLists");
				}
				return r_Fs_reorderableLists;
			}
		}

		/// <summary>
		/// System.Int32 s_LastInspectionTarget
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_LastInspectionTarget;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_LastInspectionTarget
		{
			get
			{
				if(r_Fs_LastInspectionTarget == null)
				{
					r_Fs_LastInspectionTarget = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "s_LastInspectionTarget");
				}
				return r_Fs_LastInspectionTarget;
			}
		}

		/// <summary>
		/// System.Int32 s_LastInspectorNumComponents
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_LastInspectorNumComponents;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_LastInspectorNumComponents
		{
			get
			{
				if(r_Fs_LastInspectorNumComponents == null)
				{
					r_Fs_LastInspectorNumComponents = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "s_LastInspectorNumComponents");
				}
				return r_Fs_LastInspectorNumComponents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.ContextMenuItemAttribute] contextMenuItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RContextMenuItemAttribute> r_FcontextMenuItems;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RContextMenuItemAttribute> RFcontextMenuItems
		{
			get
			{
				if(r_FcontextMenuItems == null)
				{
					r_FcontextMenuItems = new(this, "contextMenuItems");
				}
				return r_FcontextMenuItems;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Component] s_CachedComponents
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RComponent> r_Fs_CachedComponents;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RComponent> RFs_CachedComponents
		{
			get
			{
				if(r_Fs_CachedComponents == null)
				{
					r_Fs_CachedComponents = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "s_CachedComponents");
				}
				return r_Fs_CachedComponents;
			}
		}

		/// <summary>
		/// Boolean hasPropertyDrawer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasPropertyDrawer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasPropertyDrawer
		{
			get
			{
				if(r_PhasPropertyDrawer == null)
				{
					r_PhasPropertyDrawer = new(this, "hasPropertyDrawer", -1);
				}
				return r_PhasPropertyDrawer;
			}
		}

		/// <summary>
		/// UnityEditor.PropertyDrawer propertyDrawer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPropertyDrawer r_PpropertyDrawer;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPropertyDrawer RPpropertyDrawer
		{
			get
			{
				if(r_PpropertyDrawer == null)
				{
					r_PpropertyDrawer = new(this, "propertyDrawer", -1);
				}
				return r_PpropertyDrawer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.DecoratorDrawer] decoratorDrawers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RDecoratorDrawer> r_PdecoratorDrawers;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RDecoratorDrawer> RPdecoratorDrawers
		{
			get
			{
				if(r_PdecoratorDrawers == null)
				{
					r_PdecoratorDrawers = new(this, "decoratorDrawers", -1);
				}
				return r_PdecoratorDrawers;
			}
		}

		/// <summary>
		/// Boolean skipDecoratorDrawers
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PskipDecoratorDrawers;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPskipDecoratorDrawers
		{
			get
			{
				if(r_PskipDecoratorDrawers == null)
				{
					r_PskipDecoratorDrawers = new(this, "skipDecoratorDrawers", -1);
				}
				return r_PskipDecoratorDrawers;
			}
		}

		/// <summary>
		/// Boolean isCurrentlyNested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCurrentlyNested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCurrentlyNested
		{
			get
			{
				if(r_PisCurrentlyNested == null)
				{
					r_PisCurrentlyNested = new(this, "isCurrentlyNested", -1);
				}
				return r_PisCurrentlyNested;
			}
		}

		/// <summary>
		/// Boolean empty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pempty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPempty
		{
			get
			{
				if(r_Pempty == null)
				{
					r_Pempty = new(this, "empty", -1);
				}
				return r_Pempty;
			}
		}

		/// <summary>
		/// Void OnUndoRedo(UnityEditor.UndoRedoInfo ByRef)
		/// </summary>
		protected static RMethod r_MOnUndoRedo_In_UndoRedoInfo;
		public static RMethod RMOnUndoRedo_In_UndoRedoInfo
		{
			get
			{
				if(r_MOnUndoRedo_In_UndoRedoInfo == null)
				{
					r_MOnUndoRedo_In_UndoRedoInfo = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "OnUndoRedo", 0, typeof(UnityEditor.UndoRedoInfo).MakeByRefType());
				}
				return r_MOnUndoRedo_In_UndoRedoInfo;
			}
		}

		/// <summary>
		/// Void ClearCache()
		/// </summary>
		protected static RMethod r_MClearCache;
		public static RMethod RMClearCache
		{
			get
			{
				if(r_MClearCache == null)
				{
					r_MClearCache = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "ClearCache", 0);
				}
				return r_MClearCache;
			}
		}

		/// <summary>
		/// Void InvalidateListCacheIncludingChildren(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MInvalidateListCacheIncludingChildren_SerializedProperty;
		public static RMethod RMInvalidateListCacheIncludingChildren_SerializedProperty
		{
			get
			{
				if(r_MInvalidateListCacheIncludingChildren_SerializedProperty == null)
				{
					r_MInvalidateListCacheIncludingChildren_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "InvalidateListCacheIncludingChildren", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MInvalidateListCacheIncludingChildren_SerializedProperty;
			}
		}

		/// <summary>
		/// Void HandleAttribute(UnityEditor.SerializedProperty, UnityEngine.PropertyAttribute, System.Reflection.FieldInfo, System.Type)
		/// </summary>
		protected RMethod r_MHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type;
		public virtual RMethod RMHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type
		{
			get
			{
				if(r_MHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type == null)
				{
					r_MHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type = new(this, "HandleAttribute", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.PropertyAttribute), typeof(System.Reflection.FieldInfo), typeof(System.Type));
				}
				return r_MHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type;
			}
		}

		/// <summary>
		/// Void HandleDrawnType(UnityEditor.SerializedProperty, System.Type, System.Type, System.Reflection.FieldInfo, UnityEngine.PropertyAttribute)
		/// </summary>
		protected RMethod r_MHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute;
		public virtual RMethod RMHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute
		{
			get
			{
				if(r_MHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute == null)
				{
					r_MHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute = new(this, "HandleDrawnType", 0, typeof(UnityEditor.SerializedProperty), typeof(System.Type), typeof(System.Type), typeof(System.Reflection.FieldInfo), typeof(UnityEngine.PropertyAttribute));
				}
				return r_MHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute;
			}
		}

		/// <summary>
		/// Boolean OnGUI(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean)
		/// </summary>
		protected RMethod r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean;
		public virtual RMethod RMOnGUI_Rect_SerializedProperty_GUIContent_Boolean
		{
			get
			{
				if(r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean == null)
				{
					r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean = new(this, "OnGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean));
				}
				return r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean;
			}
		}

		/// <summary>
		/// Boolean OnGUI(UnityEngine.Rect, UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect;
		public virtual RMethod RMOnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect
		{
			get
			{
				if(r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect == null)
				{
					r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect = new(this, "OnGUI", 0, typeof(UnityEngine.Rect), typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(UnityEngine.Rect));
				}
				return r_MOnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect;
			}
		}

		/// <summary>
		/// Boolean OnGUILayout(UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean, UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_MOnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray;
		public virtual RMethod RMOnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray
		{
			get
			{
				if(r_MOnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray == null)
				{
					r_MOnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray = new(this, "OnGUILayout", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean), typeof(UnityEngine.GUILayoutOption).MakeArrayType());
				}
				return r_MOnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray;
			}
		}

		/// <summary>
		/// Single GetHeight(UnityEditor.SerializedProperty, UnityEngine.GUIContent, Boolean)
		/// </summary>
		protected RMethod r_MGetHeight_SerializedProperty_GUIContent_Boolean;
		public virtual RMethod RMGetHeight_SerializedProperty_GUIContent_Boolean
		{
			get
			{
				if(r_MGetHeight_SerializedProperty_GUIContent_Boolean == null)
				{
					r_MGetHeight_SerializedProperty_GUIContent_Boolean = new(this, "GetHeight", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEngine.GUIContent), typeof(System.Boolean));
				}
				return r_MGetHeight_SerializedProperty_GUIContent_Boolean;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty)
		/// </summary>
		protected RMethod r_MCanCacheInspectorGUI_SerializedProperty;
		public virtual RMethod RMCanCacheInspectorGUI_SerializedProperty
		{
			get
			{
				if(r_MCanCacheInspectorGUI_SerializedProperty == null)
				{
					r_MCanCacheInspectorGUI_SerializedProperty = new(this, "CanCacheInspectorGUI", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MCanCacheInspectorGUI_SerializedProperty;
			}
		}

		/// <summary>
		/// Void AddMenuItems(UnityEditor.SerializedProperty, UnityEditor.GenericMenu)
		/// </summary>
		protected RMethod r_MAddMenuItems_SerializedProperty_GenericMenu;
		public virtual RMethod RMAddMenuItems_SerializedProperty_GenericMenu
		{
			get
			{
				if(r_MAddMenuItems_SerializedProperty_GenericMenu == null)
				{
					r_MAddMenuItems_SerializedProperty_GenericMenu = new(this, "AddMenuItems", 0, typeof(UnityEditor.SerializedProperty), typeof(UnityEditor.GenericMenu));
				}
				return r_MAddMenuItems_SerializedProperty_GenericMenu;
			}
		}

		/// <summary>
		/// Void CallMenuCallback(System.Object[], System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MCallMenuCallback_ObjectArray_MethodInfo;
		public virtual RMethod RMCallMenuCallback_ObjectArray_MethodInfo
		{
			get
			{
				if(r_MCallMenuCallback_ObjectArray_MethodInfo == null)
				{
					r_MCallMenuCallback_ObjectArray_MethodInfo = new(this, "CallMenuCallback", 0, typeof(System.Object).MakeArrayType(), typeof(System.Reflection.MethodInfo));
				}
				return r_MCallMenuCallback_ObjectArray_MethodInfo;
			}
		}

		/// <summary>
		/// Void TestInvalidateCache()
		/// </summary>
		protected RMethod r_MTestInvalidateCache;
		public virtual RMethod RMTestInvalidateCache
		{
			get
			{
				if(r_MTestInvalidateCache == null)
				{
					r_MTestInvalidateCache = new(this, "TestInvalidateCache", 0);
				}
				return r_MTestInvalidateCache;
			}
		}

		/// <summary>
		/// Boolean IsNonStringArray(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MIsNonStringArray_SerializedProperty;
		public static RMethod RMIsNonStringArray_SerializedProperty
		{
			get
			{
				if(r_MIsNonStringArray_SerializedProperty == null)
				{
					r_MIsNonStringArray_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "IsNonStringArray", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MIsNonStringArray_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean IsArrayReorderable(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MIsArrayReorderable_SerializedProperty;
		public static RMethod RMIsArrayReorderable_SerializedProperty
		{
			get
			{
				if(r_MIsArrayReorderable_SerializedProperty == null)
				{
					r_MIsArrayReorderable_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "IsArrayReorderable", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MIsArrayReorderable_SerializedProperty;
			}
		}

		/// <summary>
		/// Boolean UseReorderabelListControl(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_MUseReorderabelListControl_SerializedProperty;
		public static RMethod RMUseReorderabelListControl_SerializedProperty
		{
			get
			{
				if(r_MUseReorderabelListControl_SerializedProperty == null)
				{
					r_MUseReorderabelListControl_SerializedProperty = new( ReflectionUtils.GetType("UnityEditor.PropertyHandler"), "UseReorderabelListControl", 0, typeof(UnityEditor.SerializedProperty));
				}
				return r_MUseReorderabelListControl_SerializedProperty;
			}
		}

		/// <summary>
		/// NestingContext ApplyNestingContext(Int32)
		/// </summary>
		protected RMethod r_MApplyNestingContext_Int32;
		public virtual RMethod RMApplyNestingContext_Int32
		{
			get
			{
				if(r_MApplyNestingContext_Int32 == null)
				{
					r_MApplyNestingContext_Int32 = new(this, "ApplyNestingContext", 0, typeof(System.Int32));
				}
				return r_MApplyNestingContext_Int32;
			}
		}

		/// <summary>
		/// NestingContext IncrementNestingContext()
		/// </summary>
		protected RMethod r_MIncrementNestingContext;
		public virtual RMethod RMIncrementNestingContext
		{
			get
			{
				if(r_MIncrementNestingContext == null)
				{
					r_MIncrementNestingContext = new(this, "IncrementNestingContext", 0);
				}
				return r_MIncrementNestingContext;
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

        public static void OnUndoRedo(in UnityEditor.UndoRedoInfo @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = RMOnUndoRedo_In_UndoRedoInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static void ClearCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCache.Invoke(___genericsType, ___parameters);

            
        }


        public static void InvalidateListCacheIncludingChildren(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMInvalidateListCacheIncludingChildren_SerializedProperty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleAttribute(UnityEditor.SerializedProperty @property, UnityEngine.PropertyAttribute @attribute, System.Reflection.FieldInfo @field, System.Type @propertyType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @attribute, @field, @propertyType};
            var ___result = RMHandleAttribute_SerializedProperty_PropertyAttribute_FieldInfo_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDrawnType(UnityEditor.SerializedProperty @property, System.Type @drawnType, System.Type @propertyType, System.Reflection.FieldInfo @field, UnityEngine.PropertyAttribute @attribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @drawnType, @propertyType, @field, @attribute};
            var ___result = RMHandleDrawnType_SerializedProperty_Type_Type_FieldInfo_PropertyAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnGUI(UnityEngine.Rect @position, UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label, System.Boolean @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label, @includeChildren};
            var ___result = RMOnGUI_Rect_SerializedProperty_GUIContent_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean OnGUI(UnityEngine.Rect @position, UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label, System.Boolean @includeChildren, UnityEngine.Rect @visibleArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @property, @label, @includeChildren, @visibleArea};
            var ___result = RMOnGUI_Rect_SerializedProperty_GUIContent_Boolean_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean OnGUILayout(UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label, System.Boolean @includeChildren, UnityEngine.GUILayoutOption[] @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label, @includeChildren, @options};
            var ___result = RMOnGUILayout_SerializedProperty_GUIContent_Boolean_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetHeight(UnityEditor.SerializedProperty @property, UnityEngine.GUIContent @label, System.Boolean @includeChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @label, @includeChildren};
            var ___result = RMGetHeight_SerializedProperty_GUIContent_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean CanCacheInspectorGUI(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMCanCacheInspectorGUI_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddMenuItems(UnityEditor.SerializedProperty @property, UnityEditor.GenericMenu @menu)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @menu};
            var ___result = RMAddMenuItems_SerializedProperty_GenericMenu.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CallMenuCallback(System.Object[] @targets, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targets, @method};
            var ___result = RMCallMenuCallback_ObjectArray_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TestInvalidateCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTestInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsNonStringArray(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMIsNonStringArray_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsArrayReorderable(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMIsArrayReorderable_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean UseReorderabelListControl(UnityEditor.SerializedProperty @property)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property};
            var ___result = RMUseReorderabelListControl_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler.RNestingContext ApplyNestingContext(System.Int32 @nestingLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nestingLevel};
            var ___result = RMApplyNestingContext_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler.RNestingContext(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler.RNestingContext IncrementNestingContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIncrementNestingContext.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RPropertyHandler.RNestingContext(___result);
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
