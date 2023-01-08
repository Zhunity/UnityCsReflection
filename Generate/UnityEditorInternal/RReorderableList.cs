using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditorInternal
{
	/// <summary>
	/// UnityEditorInternal.ReorderableList
	/// </summary>
    public partial class RReorderableList : RMember //
    {

		/// <summary>
		/// UnityEditorInternal.ReorderableList+HeaderCallbackDelegate drawHeaderCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RHeaderCallbackDelegate r_drawHeaderCallback;
		public virtual RUnityEditorInternal.RReorderableList.RHeaderCallbackDelegate RdrawHeaderCallback
		{
			get
			{
				if(r_drawHeaderCallback == null)
				{
					r_drawHeaderCallback = new(this, "drawHeaderCallback");
					r_drawHeaderCallback.SetBelong(this.instance);
				}
				return r_drawHeaderCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+FooterCallbackDelegate drawFooterCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RFooterCallbackDelegate r_drawFooterCallback;
		public virtual RUnityEditorInternal.RReorderableList.RFooterCallbackDelegate RdrawFooterCallback
		{
			get
			{
				if(r_drawFooterCallback == null)
				{
					r_drawFooterCallback = new(this, "drawFooterCallback");
					r_drawFooterCallback.SetBelong(this.instance);
				}
				return r_drawFooterCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+ElementCallbackDelegate drawElementCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RElementCallbackDelegate r_drawElementCallback;
		public virtual RUnityEditorInternal.RReorderableList.RElementCallbackDelegate RdrawElementCallback
		{
			get
			{
				if(r_drawElementCallback == null)
				{
					r_drawElementCallback = new(this, "drawElementCallback");
					r_drawElementCallback.SetBelong(this.instance);
				}
				return r_drawElementCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+ElementCallbackDelegate drawElementBackgroundCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RElementCallbackDelegate r_drawElementBackgroundCallback;
		public virtual RUnityEditorInternal.RReorderableList.RElementCallbackDelegate RdrawElementBackgroundCallback
		{
			get
			{
				if(r_drawElementBackgroundCallback == null)
				{
					r_drawElementBackgroundCallback = new(this, "drawElementBackgroundCallback");
					r_drawElementBackgroundCallback.SetBelong(this.instance);
				}
				return r_drawElementBackgroundCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+DrawNoneElementCallback drawNoneElementCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RDrawNoneElementCallback r_drawNoneElementCallback;
		public virtual RUnityEditorInternal.RReorderableList.RDrawNoneElementCallback RdrawNoneElementCallback
		{
			get
			{
				if(r_drawNoneElementCallback == null)
				{
					r_drawNoneElementCallback = new(this, "drawNoneElementCallback");
					r_drawNoneElementCallback.SetBelong(this.instance);
				}
				return r_drawNoneElementCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+ElementHeightCallbackDelegate elementHeightCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RElementHeightCallbackDelegate r_elementHeightCallback;
		public virtual RUnityEditorInternal.RReorderableList.RElementHeightCallbackDelegate RelementHeightCallback
		{
			get
			{
				if(r_elementHeightCallback == null)
				{
					r_elementHeightCallback = new(this, "elementHeightCallback");
					r_elementHeightCallback.SetBelong(this.instance);
				}
				return r_elementHeightCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+ReorderCallbackDelegateWithDetails onReorderCallbackWithDetails
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RReorderCallbackDelegateWithDetails r_onReorderCallbackWithDetails;
		public virtual RUnityEditorInternal.RReorderableList.RReorderCallbackDelegateWithDetails RonReorderCallbackWithDetails
		{
			get
			{
				if(r_onReorderCallbackWithDetails == null)
				{
					r_onReorderCallbackWithDetails = new(this, "onReorderCallbackWithDetails");
					r_onReorderCallbackWithDetails.SetBelong(this.instance);
				}
				return r_onReorderCallbackWithDetails;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+ReorderCallbackDelegate onReorderCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RReorderCallbackDelegate r_onReorderCallback;
		public virtual RUnityEditorInternal.RReorderableList.RReorderCallbackDelegate RonReorderCallback
		{
			get
			{
				if(r_onReorderCallback == null)
				{
					r_onReorderCallback = new(this, "onReorderCallback");
					r_onReorderCallback.SetBelong(this.instance);
				}
				return r_onReorderCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+SelectCallbackDelegate onSelectCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RSelectCallbackDelegate r_onSelectCallback;
		public virtual RUnityEditorInternal.RReorderableList.RSelectCallbackDelegate RonSelectCallback
		{
			get
			{
				if(r_onSelectCallback == null)
				{
					r_onSelectCallback = new(this, "onSelectCallback");
					r_onSelectCallback.SetBelong(this.instance);
				}
				return r_onSelectCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+AddCallbackDelegate onAddCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RAddCallbackDelegate r_onAddCallback;
		public virtual RUnityEditorInternal.RReorderableList.RAddCallbackDelegate RonAddCallback
		{
			get
			{
				if(r_onAddCallback == null)
				{
					r_onAddCallback = new(this, "onAddCallback");
					r_onAddCallback.SetBelong(this.instance);
				}
				return r_onAddCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+AddDropdownCallbackDelegate onAddDropdownCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RAddDropdownCallbackDelegate r_onAddDropdownCallback;
		public virtual RUnityEditorInternal.RReorderableList.RAddDropdownCallbackDelegate RonAddDropdownCallback
		{
			get
			{
				if(r_onAddDropdownCallback == null)
				{
					r_onAddDropdownCallback = new(this, "onAddDropdownCallback");
					r_onAddDropdownCallback.SetBelong(this.instance);
				}
				return r_onAddDropdownCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+RemoveCallbackDelegate onRemoveCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RRemoveCallbackDelegate r_onRemoveCallback;
		public virtual RUnityEditorInternal.RReorderableList.RRemoveCallbackDelegate RonRemoveCallback
		{
			get
			{
				if(r_onRemoveCallback == null)
				{
					r_onRemoveCallback = new(this, "onRemoveCallback");
					r_onRemoveCallback.SetBelong(this.instance);
				}
				return r_onRemoveCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+DragCallbackDelegate onMouseDragCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RDragCallbackDelegate r_onMouseDragCallback;
		public virtual RUnityEditorInternal.RReorderableList.RDragCallbackDelegate RonMouseDragCallback
		{
			get
			{
				if(r_onMouseDragCallback == null)
				{
					r_onMouseDragCallback = new(this, "onMouseDragCallback");
					r_onMouseDragCallback.SetBelong(this.instance);
				}
				return r_onMouseDragCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+SelectCallbackDelegate onMouseUpCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RSelectCallbackDelegate r_onMouseUpCallback;
		public virtual RUnityEditorInternal.RReorderableList.RSelectCallbackDelegate RonMouseUpCallback
		{
			get
			{
				if(r_onMouseUpCallback == null)
				{
					r_onMouseUpCallback = new(this, "onMouseUpCallback");
					r_onMouseUpCallback.SetBelong(this.instance);
				}
				return r_onMouseUpCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+CanRemoveCallbackDelegate onCanRemoveCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RCanRemoveCallbackDelegate r_onCanRemoveCallback;
		public virtual RUnityEditorInternal.RReorderableList.RCanRemoveCallbackDelegate RonCanRemoveCallback
		{
			get
			{
				if(r_onCanRemoveCallback == null)
				{
					r_onCanRemoveCallback = new(this, "onCanRemoveCallback");
					r_onCanRemoveCallback.SetBelong(this.instance);
				}
				return r_onCanRemoveCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+CanAddCallbackDelegate onCanAddCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RCanAddCallbackDelegate r_onCanAddCallback;
		public virtual RUnityEditorInternal.RReorderableList.RCanAddCallbackDelegate RonCanAddCallback
		{
			get
			{
				if(r_onCanAddCallback == null)
				{
					r_onCanAddCallback = new(this, "onCanAddCallback");
					r_onCanAddCallback.SetBelong(this.instance);
				}
				return r_onCanAddCallback;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+ChangedCallbackDelegate onChangedCallback
		/// </summary>
		protected RUnityEditorInternal.RReorderableList.RChangedCallbackDelegate r_onChangedCallback;
		public virtual RUnityEditorInternal.RReorderableList.RChangedCallbackDelegate RonChangedCallback
		{
			get
			{
				if(r_onChangedCallback == null)
				{
					r_onChangedCallback = new(this, "onChangedCallback");
					r_onChangedCallback.SetBelong(this.instance);
				}
				return r_onChangedCallback;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_Selection
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_Selection;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_Selection
		{
			get
			{
				if(r_m_Selection == null)
				{
					r_m_Selection = new(this, "m_Selection");
					r_m_Selection.SetBelong(this.instance);
				}
				return r_m_Selection;
			}
		}

		/// <summary>
		/// System.Single m_DragOffset
		/// </summary>
		protected RField r_m_DragOffset;
		public virtual RField Rm_DragOffset
		{
			get
			{
				if(r_m_DragOffset == null)
				{
					r_m_DragOffset = new(this, "m_DragOffset");
					r_m_DragOffset.SetBelong(this.instance);
				}
				return r_m_DragOffset;
			}
		}

		/// <summary>
		/// UnityEditor.GUISlideGroup m_SlideGroup
		/// </summary>
		protected RUnityEditor.RGUISlideGroup r_m_SlideGroup;
		public virtual RUnityEditor.RGUISlideGroup Rm_SlideGroup
		{
			get
			{
				if(r_m_SlideGroup == null)
				{
					r_m_SlideGroup = new(this, "m_SlideGroup");
					r_m_SlideGroup.SetBelong(this.instance);
				}
				return r_m_SlideGroup;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedObject m_SerializedObject
		/// </summary>
		protected RUnityEditor.RSerializedObject r_m_SerializedObject;
		public virtual RUnityEditor.RSerializedObject Rm_SerializedObject
		{
			get
			{
				if(r_m_SerializedObject == null)
				{
					r_m_SerializedObject = new(this, "m_SerializedObject");
					r_m_SerializedObject.SetBelong(this.instance);
				}
				return r_m_SerializedObject;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty m_Elements
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_m_Elements;
		public virtual RUnityEditor.RSerializedProperty Rm_Elements
		{
			get
			{
				if(r_m_Elements == null)
				{
					r_m_Elements = new(this, "m_Elements");
					r_m_Elements.SetBelong(this.instance);
				}
				return r_m_Elements;
			}
		}

		/// <summary>
		/// System.String m_PropertyPath
		/// </summary>
		protected RField r_m_PropertyPath;
		public virtual RField Rm_PropertyPath
		{
			get
			{
				if(r_m_PropertyPath == null)
				{
					r_m_PropertyPath = new(this, "m_PropertyPath");
					r_m_PropertyPath.SetBelong(this.instance);
				}
				return r_m_PropertyPath;
			}
		}

		/// <summary>
		/// System.Collections.IList m_ElementList
		/// </summary>
		protected RSystem.RCollections.RIList r_m_ElementList;
		public virtual RSystem.RCollections.RIList Rm_ElementList
		{
			get
			{
				if(r_m_ElementList == null)
				{
					r_m_ElementList = new(this, "m_ElementList");
					r_m_ElementList.SetBelong(this.instance);
				}
				return r_m_ElementList;
			}
		}

		/// <summary>
		/// System.Boolean m_Draggable
		/// </summary>
		protected RField r_m_Draggable;
		public virtual RField Rm_Draggable
		{
			get
			{
				if(r_m_Draggable == null)
				{
					r_m_Draggable = new(this, "m_Draggable");
					r_m_Draggable.SetBelong(this.instance);
				}
				return r_m_Draggable;
			}
		}

		/// <summary>
		/// System.Single m_DraggedY
		/// </summary>
		protected RField r_m_DraggedY;
		public virtual RField Rm_DraggedY
		{
			get
			{
				if(r_m_DraggedY == null)
				{
					r_m_DraggedY = new(this, "m_DraggedY");
					r_m_DraggedY.SetBelong(this.instance);
				}
				return r_m_DraggedY;
			}
		}

		/// <summary>
		/// System.Boolean m_Dragging
		/// </summary>
		protected RField r_m_Dragging;
		public virtual RField Rm_Dragging
		{
			get
			{
				if(r_m_Dragging == null)
				{
					r_m_Dragging = new(this, "m_Dragging");
					r_m_Dragging.SetBelong(this.instance);
				}
				return r_m_Dragging;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_NonDragTargetIndices
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_NonDragTargetIndices;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_NonDragTargetIndices
		{
			get
			{
				if(r_m_NonDragTargetIndices == null)
				{
					r_m_NonDragTargetIndices = new(this, "m_NonDragTargetIndices");
					r_m_NonDragTargetIndices.SetBelong(this.instance);
				}
				return r_m_NonDragTargetIndices;
			}
		}

		/// <summary>
		/// System.Boolean m_DisplayHeader
		/// </summary>
		protected RField r_m_DisplayHeader;
		public virtual RField Rm_DisplayHeader
		{
			get
			{
				if(r_m_DisplayHeader == null)
				{
					r_m_DisplayHeader = new(this, "m_DisplayHeader");
					r_m_DisplayHeader.SetBelong(this.instance);
				}
				return r_m_DisplayHeader;
			}
		}

		/// <summary>
		/// System.Boolean displayAdd
		/// </summary>
		protected RField r_displayAdd;
		public virtual RField RdisplayAdd
		{
			get
			{
				if(r_displayAdd == null)
				{
					r_displayAdd = new(this, "displayAdd");
					r_displayAdd.SetBelong(this.instance);
				}
				return r_displayAdd;
			}
		}

		/// <summary>
		/// System.Boolean displayRemove
		/// </summary>
		protected RField r_displayRemove;
		public virtual RField RdisplayRemove
		{
			get
			{
				if(r_displayRemove == null)
				{
					r_displayRemove = new(this, "displayRemove");
					r_displayRemove.SetBelong(this.instance);
				}
				return r_displayRemove;
			}
		}

		/// <summary>
		/// System.Boolean m_scheduleRemove
		/// </summary>
		protected RField r_m_scheduleRemove;
		public virtual RField Rm_scheduleRemove
		{
			get
			{
				if(r_m_scheduleRemove == null)
				{
					r_m_scheduleRemove = new(this, "m_scheduleRemove");
					r_m_scheduleRemove.SetBelong(this.instance);
				}
				return r_m_scheduleRemove;
			}
		}

		/// <summary>
		/// System.Boolean m_IsEditable
		/// </summary>
		protected RField r_m_IsEditable;
		public virtual RField Rm_IsEditable
		{
			get
			{
				if(r_m_IsEditable == null)
				{
					r_m_IsEditable = new(this, "m_IsEditable");
					r_m_IsEditable.SetBelong(this.instance);
				}
				return r_m_IsEditable;
			}
		}

		/// <summary>
		/// System.Boolean m_HasPropertyDrawer
		/// </summary>
		protected RField r_m_HasPropertyDrawer;
		public virtual RField Rm_HasPropertyDrawer
		{
			get
			{
				if(r_m_HasPropertyDrawer == null)
				{
					r_m_HasPropertyDrawer = new(this, "m_HasPropertyDrawer");
					r_m_HasPropertyDrawer.SetBelong(this.instance);
				}
				return r_m_HasPropertyDrawer;
			}
		}

		/// <summary>
		/// System.Int32 m_CacheCount
		/// </summary>
		protected RField r_m_CacheCount;
		public virtual RField Rm_CacheCount
		{
			get
			{
				if(r_m_CacheCount == null)
				{
					r_m_CacheCount = new(this, "m_CacheCount");
					r_m_CacheCount.SetBelong(this.instance);
				}
				return r_m_CacheCount;
			}
		}

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.Boolean m_ScheduleGUIChanged
		/// </summary>
		protected RField r_m_ScheduleGUIChanged;
		public virtual RField Rm_ScheduleGUIChanged
		{
			get
			{
				if(r_m_ScheduleGUIChanged == null)
				{
					r_m_ScheduleGUIChanged = new(this, "m_ScheduleGUIChanged");
					r_m_ScheduleGUIChanged.SetBelong(this.instance);
				}
				return r_m_ScheduleGUIChanged;
			}
		}

		/// <summary>
		/// System.Boolean m_PropertyCacheValid
		/// </summary>
		protected RField r_m_PropertyCacheValid;
		public virtual RField Rm_PropertyCacheValid
		{
			get
			{
				if(r_m_PropertyCacheValid == null)
				{
					r_m_PropertyCacheValid = new(this, "m_PropertyCacheValid");
					r_m_PropertyCacheValid.SetBelong(this.instance);
				}
				return r_m_PropertyCacheValid;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+PropertyCacheEntry[] m_PropertyCache
		/// </summary>
		protected RFieldArray<RUnityEditorInternal.RReorderableList.RPropertyCacheEntry> r_m_PropertyCache;
		public virtual RFieldArray<RUnityEditorInternal.RReorderableList.RPropertyCacheEntry> Rm_PropertyCache
		{
			get
			{
				if(r_m_PropertyCache == null)
				{
					r_m_PropertyCache = new(this, "m_PropertyCache");
					r_m_PropertyCache.SetBelong(this.instance);
				}
				return r_m_PropertyCache;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_OutdatedProperties
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RField> r_m_OutdatedProperties;
		public static RSystem.RCollections.RGeneric.RList<RField> Rm_OutdatedProperties
		{
			get
			{
				if(r_m_OutdatedProperties == null)
				{
					r_m_OutdatedProperties = new(typeof(UnityEditorInternal.ReorderableList), "m_OutdatedProperties");
					r_m_OutdatedProperties.SetBelong(null);
				}
				return r_m_OutdatedProperties;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList+Defaults s_Defaults
		/// </summary>
		protected static RUnityEditorInternal.RReorderableList.RDefaults r_s_Defaults;
		public static RUnityEditorInternal.RReorderableList.RDefaults Rs_Defaults
		{
			get
			{
				if(r_s_Defaults == null)
				{
					r_s_Defaults = new(typeof(UnityEditorInternal.ReorderableList), "s_Defaults");
					r_s_Defaults.SetBelong(null);
				}
				return r_s_Defaults;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.WeakReference`1[UnityEditorInternal.ReorderableList]] s_Instances
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RSystem.RWeakReference<RUnityEditorInternal.RReorderableList>> r_s_Instances;
		public static RSystem.RCollections.RGeneric.RList<RSystem.RWeakReference<RUnityEditorInternal.RReorderableList>> Rs_Instances
		{
			get
			{
				if(r_s_Instances == null)
				{
					r_s_Instances = new(typeof(UnityEditorInternal.ReorderableList), "s_Instances");
					r_s_Instances.SetBelong(null);
				}
				return r_s_Instances;
			}
		}

		/// <summary>
		/// System.Boolean <multiSelect>k__BackingField
		/// </summary>
		protected RField r___0__multiSelect__1__k__BackingField;
		public virtual RField R__0__multiSelect__1__k__BackingField
		{
			get
			{
				if(r___0__multiSelect__1__k__BackingField == null)
				{
					r___0__multiSelect__1__k__BackingField = new(this, "<multiSelect>k__BackingField");
					r___0__multiSelect__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__multiSelect__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single elementHeight
		/// </summary>
		protected RField r_elementHeight;
		public virtual RField RelementHeight
		{
			get
			{
				if(r_elementHeight == null)
				{
					r_elementHeight = new(this, "elementHeight");
					r_elementHeight.SetBelong(this.instance);
				}
				return r_elementHeight;
			}
		}

		/// <summary>
		/// System.Single headerHeight
		/// </summary>
		protected RField r_headerHeight;
		public virtual RField RheaderHeight
		{
			get
			{
				if(r_headerHeight == null)
				{
					r_headerHeight = new(this, "headerHeight");
					r_headerHeight.SetBelong(this.instance);
				}
				return r_headerHeight;
			}
		}

		/// <summary>
		/// System.Single footerHeight
		/// </summary>
		protected RField r_footerHeight;
		public virtual RField RfooterHeight
		{
			get
			{
				if(r_footerHeight == null)
				{
					r_footerHeight = new(this, "footerHeight");
					r_footerHeight.SetBelong(this.instance);
				}
				return r_footerHeight;
			}
		}

		/// <summary>
		/// System.Boolean showDefaultBackground
		/// </summary>
		protected RField r_showDefaultBackground;
		public virtual RField RshowDefaultBackground
		{
			get
			{
				if(r_showDefaultBackground == null)
				{
					r_showDefaultBackground = new(this, "showDefaultBackground");
					r_showDefaultBackground.SetBelong(this.instance);
				}
				return r_showDefaultBackground;
			}
		}

		/// <summary>
		/// System.Single kListElementBottomPadding
		/// </summary>
		protected static RField r_kListElementBottomPadding;
		public static RField RkListElementBottomPadding
		{
			get
			{
				if(r_kListElementBottomPadding == null)
				{
					r_kListElementBottomPadding = new(typeof(UnityEditorInternal.ReorderableList), "kListElementBottomPadding");
					r_kListElementBottomPadding.SetBelong(null);
				}
				return r_kListElementBottomPadding;
			}
		}

		/// <summary>
		/// System.Int32 m_Count
		/// </summary>
		protected RField r_m_Count;
		public virtual RField Rm_Count
		{
			get
			{
				if(r_m_Count == null)
				{
					r_m_Count = new(this, "m_Count");
					r_m_Count.SetBelong(this.instance);
				}
				return r_m_Count;
			}
		}

		/// <summary>
		/// System.Int32 m_SmallerArraySize
		/// </summary>
		protected RField r_m_SmallerArraySize;
		public virtual RField Rm_SmallerArraySize
		{
			get
			{
				if(r_m_SmallerArraySize == null)
				{
					r_m_SmallerArraySize = new(this, "m_SmallerArraySize");
					r_m_SmallerArraySize.SetBelong(this.instance);
				}
				return r_m_SmallerArraySize;
			}
		}

		/// <summary>
		/// System.Single lastHeight
		/// </summary>
		protected RField r_lastHeight;
		public virtual RField RlastHeight
		{
			get
			{
				if(r_lastHeight == null)
				{
					r_lastHeight = new(this, "lastHeight");
					r_lastHeight.SetBelong(this.instance);
				}
				return r_lastHeight;
			}
		}

		/// <summary>
		/// System.Int32 recursionCounter
		/// </summary>
		protected RField r_recursionCounter;
		public virtual RField RrecursionCounter
		{
			get
			{
				if(r_recursionCounter == null)
				{
					r_recursionCounter = new(this, "recursionCounter");
					r_recursionCounter.SetBelong(this.instance);
				}
				return r_recursionCounter;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastRect
		/// </summary>
		protected RUnityEngine.RRect r_lastRect;
		public virtual RUnityEngine.RRect RlastRect
		{
			get
			{
				if(r_lastRect == null)
				{
					r_lastRect = new(this, "lastRect");
					r_lastRect.SetBelong(this.instance);
				}
				return r_lastRect;
			}
		}

		/// <summary>
		/// Defaults defaultBehaviours
		/// </summary>
		protected static RUnityEditorInternal.RReorderableList.RDefaults r_defaultBehaviours;
		public static RUnityEditorInternal.RReorderableList.RDefaults RdefaultBehaviours
		{
			get
			{
				if(r_defaultBehaviours == null)
				{
					r_defaultBehaviours = new(typeof(UnityEditorInternal.ReorderableList), "defaultBehaviours", -1);
					r_defaultBehaviours.SetBelong(null);
				}
				return r_defaultBehaviours;
			}
		}

		/// <summary>
		/// UnityEditor.SerializedProperty serializedProperty
		/// </summary>
		protected RUnityEditor.RSerializedProperty r_serializedProperty;
		public virtual RUnityEditor.RSerializedProperty RserializedProperty
		{
			get
			{
				if(r_serializedProperty == null)
				{
					r_serializedProperty = new(this, "serializedProperty", -1);
					r_serializedProperty.SetBelong(this.instance);
				}
				return r_serializedProperty;
			}
		}

		/// <summary>
		/// System.Collections.IList list
		/// </summary>
		protected RSystem.RCollections.RIList r_list;
		public virtual RSystem.RCollections.RIList Rlist
		{
			get
			{
				if(r_list == null)
				{
					r_list = new(this, "list", -1);
					r_list.SetBelong(this.instance);
				}
				return r_list;
			}
		}

		/// <summary>
		/// Int32 index
		/// </summary>
		protected RProperty r_index;
		public virtual RProperty Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index", -1);
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Int32] selectedIndices
		/// </summary>
		protected RSystem.RCollections.RObjectModel.RReadOnlyCollection<RProperty> r_selectedIndices;
		public virtual RSystem.RCollections.RObjectModel.RReadOnlyCollection<RProperty> RselectedIndices
		{
			get
			{
				if(r_selectedIndices == null)
				{
					r_selectedIndices = new(this, "selectedIndices", -1);
					r_selectedIndices.SetBelong(this.instance);
				}
				return r_selectedIndices;
			}
		}

		/// <summary>
		/// Boolean multiSelect
		/// </summary>
		protected RProperty r_multiSelect;
		public virtual RProperty RmultiSelect
		{
			get
			{
				if(r_multiSelect == null)
				{
					r_multiSelect = new(this, "multiSelect", -1);
					r_multiSelect.SetBelong(this.instance);
				}
				return r_multiSelect;
			}
		}

		/// <summary>
		/// Single HeaderHeight
		/// </summary>
		protected RProperty r_HeaderHeight;
		public virtual RProperty RHeaderHeight
		{
			get
			{
				if(r_HeaderHeight == null)
				{
					r_HeaderHeight = new(this, "HeaderHeight", -1);
					r_HeaderHeight.SetBelong(this.instance);
				}
				return r_HeaderHeight;
			}
		}

		/// <summary>
		/// Single listElementTopPadding
		/// </summary>
		protected RProperty r_listElementTopPadding;
		public virtual RProperty RlistElementTopPadding
		{
			get
			{
				if(r_listElementTopPadding == null)
				{
					r_listElementTopPadding = new(this, "listElementTopPadding", -1);
					r_listElementTopPadding.SetBelong(this.instance);
				}
				return r_listElementTopPadding;
			}
		}

		/// <summary>
		/// Boolean draggable
		/// </summary>
		protected RProperty r_draggable;
		public virtual RProperty Rdraggable
		{
			get
			{
				if(r_draggable == null)
				{
					r_draggable = new(this, "draggable", -1);
					r_draggable.SetBelong(this.instance);
				}
				return r_draggable;
			}
		}

		/// <summary>
		/// Boolean isOverMaxMultiEditLimit
		/// </summary>
		protected RProperty r_isOverMaxMultiEditLimit;
		public virtual RProperty RisOverMaxMultiEditLimit
		{
			get
			{
				if(r_isOverMaxMultiEditLimit == null)
				{
					r_isOverMaxMultiEditLimit = new(this, "isOverMaxMultiEditLimit", -1);
					r_isOverMaxMultiEditLimit.SetBelong(this.instance);
				}
				return r_isOverMaxMultiEditLimit;
			}
		}

		/// <summary>
		/// Int32 count
		/// </summary>
		protected RProperty r_count;
		public virtual RProperty Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count", -1);
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.String GetParentListPath(System.String)
		/// </summary>
		protected static RMethod r_GetParentListPath_String;
		public static RMethod RGetParentListPath_String
		{
			get
			{
				if(r_GetParentListPath_String == null)
				{
					r_GetParentListPath_String = new(typeof(UnityEditorInternal.ReorderableList), "GetParentListPath", 0, typeof(System.String));
					r_GetParentListPath_String.SetBelong(null);
				}
				return r_GetParentListPath_String;
			}
		}

		/// <summary>
		/// Void InvalidateParentCaches(System.String)
		/// </summary>
		protected static RMethod r_InvalidateParentCaches_String;
		public static RMethod RInvalidateParentCaches_String
		{
			get
			{
				if(r_InvalidateParentCaches_String == null)
				{
					r_InvalidateParentCaches_String = new(typeof(UnityEditorInternal.ReorderableList), "InvalidateParentCaches", 0, typeof(System.String));
					r_InvalidateParentCaches_String.SetBelong(null);
				}
				return r_InvalidateParentCaches_String;
			}
		}

		/// <summary>
		/// Boolean CheckForChildInvalidation()
		/// </summary>
		protected RMethod r_CheckForChildInvalidation;
		public virtual RMethod RCheckForChildInvalidation
		{
			get
			{
				if(r_CheckForChildInvalidation == null)
				{
					r_CheckForChildInvalidation = new(this, "CheckForChildInvalidation", 0);
					r_CheckForChildInvalidation.SetBelong(this.instance);
				}
				return r_CheckForChildInvalidation;
			}
		}

		/// <summary>
		/// Void InvalidateForGUI()
		/// </summary>
		protected RMethod r_InvalidateForGUI;
		public virtual RMethod RInvalidateForGUI
		{
			get
			{
				if(r_InvalidateForGUI == null)
				{
					r_InvalidateForGUI = new(this, "InvalidateForGUI", 0);
					r_InvalidateForGUI.SetBelong(this.instance);
				}
				return r_InvalidateForGUI;
			}
		}

		/// <summary>
		/// Void InvalidateExistingListCaches()
		/// </summary>
		protected static RMethod r_InvalidateExistingListCaches;
		public static RMethod RInvalidateExistingListCaches
		{
			get
			{
				if(r_InvalidateExistingListCaches == null)
				{
					r_InvalidateExistingListCaches = new(typeof(UnityEditorInternal.ReorderableList), "InvalidateExistingListCaches", 0);
					r_InvalidateExistingListCaches.SetBelong(null);
				}
				return r_InvalidateExistingListCaches;
			}
		}

		/// <summary>
		/// UnityEditorInternal.ReorderableList GetReorderableListFromSerializedProperty(UnityEditor.SerializedProperty)
		/// </summary>
		protected static RMethod r_GetReorderableListFromSerializedProperty_SerializedProperty;
		public static RMethod RGetReorderableListFromSerializedProperty_SerializedProperty
		{
			get
			{
				if(r_GetReorderableListFromSerializedProperty_SerializedProperty == null)
				{
					r_GetReorderableListFromSerializedProperty_SerializedProperty = new(typeof(UnityEditorInternal.ReorderableList), "GetReorderableListFromSerializedProperty", 0, typeof(UnityEditor.SerializedProperty));
					r_GetReorderableListFromSerializedProperty_SerializedProperty.SetBelong(null);
				}
				return r_GetReorderableListFromSerializedProperty_SerializedProperty;
			}
		}

		/// <summary>
		/// Void InitList(UnityEditor.SerializedObject, UnityEditor.SerializedProperty, System.Collections.IList, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected RMethod r_InitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean;
		public virtual RMethod RInitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_InitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_InitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean = new(this, "InitList", 0, typeof(UnityEditor.SerializedObject), typeof(UnityEditor.SerializedProperty), typeof(System.Collections.IList), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_InitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_InitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void TryOverrideElementHeightWithPropertyDrawer(UnityEditor.SerializedProperty, Single ByRef)
		/// </summary>
		protected RMethod r_TryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single;
		public virtual RMethod RTryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single
		{
			get
			{
				if(r_TryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single == null)
				{
					r_TryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single = new(this, "TryOverrideElementHeightWithPropertyDrawer", 0, typeof(UnityEditor.SerializedProperty), typeof(System.Single).MakeByRefType());
					r_TryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single.SetBelong(this.instance);
				}
				return r_TryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single;
			}
		}

		/// <summary>
		/// Void CacheIfNeeded()
		/// </summary>
		protected RMethod r_CacheIfNeeded;
		public virtual RMethod RCacheIfNeeded
		{
			get
			{
				if(r_CacheIfNeeded == null)
				{
					r_CacheIfNeeded = new(this, "CacheIfNeeded", 0);
					r_CacheIfNeeded.SetBelong(this.instance);
				}
				return r_CacheIfNeeded;
			}
		}

		/// <summary>
		/// Void InvalidateCache()
		/// </summary>
		protected RMethod r_InvalidateCache;
		public virtual RMethod RInvalidateCache
		{
			get
			{
				if(r_InvalidateCache == null)
				{
					r_InvalidateCache = new(this, "InvalidateCache", 0);
					r_InvalidateCache.SetBelong(this.instance);
				}
				return r_InvalidateCache;
			}
		}

		/// <summary>
		/// Void InvalidateCacheRecursive()
		/// </summary>
		protected RMethod r_InvalidateCacheRecursive;
		public virtual RMethod RInvalidateCacheRecursive
		{
			get
			{
				if(r_InvalidateCacheRecursive == null)
				{
					r_InvalidateCacheRecursive = new(this, "InvalidateCacheRecursive", 0);
					r_InvalidateCacheRecursive.SetBelong(this.instance);
				}
				return r_InvalidateCacheRecursive;
			}
		}

		/// <summary>
		/// Void ClearSelection()
		/// </summary>
		protected RMethod r_ClearSelection;
		public virtual RMethod RClearSelection
		{
			get
			{
				if(r_ClearSelection == null)
				{
					r_ClearSelection = new(this, "ClearSelection", 0);
					r_ClearSelection.SetBelong(this.instance);
				}
				return r_ClearSelection;
			}
		}

		/// <summary>
		/// Void Select(Int32, Boolean)
		/// </summary>
		protected RMethod r_Select_Int32_Boolean;
		public virtual RMethod RSelect_Int32_Boolean
		{
			get
			{
				if(r_Select_Int32_Boolean == null)
				{
					r_Select_Int32_Boolean = new(this, "Select", 0, typeof(System.Int32), typeof(System.Boolean));
					r_Select_Int32_Boolean.SetBelong(this.instance);
				}
				return r_Select_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SelectRange(Int32, Int32)
		/// </summary>
		protected RMethod r_SelectRange_Int32_Int32;
		public virtual RMethod RSelectRange_Int32_Int32
		{
			get
			{
				if(r_SelectRange_Int32_Int32 == null)
				{
					r_SelectRange_Int32_Int32 = new(this, "SelectRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_SelectRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_SelectRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSelected(Int32)
		/// </summary>
		protected RMethod r_IsSelected_Int32;
		public virtual RMethod RIsSelected_Int32
		{
			get
			{
				if(r_IsSelected_Int32 == null)
				{
					r_IsSelected_Int32 = new(this, "IsSelected", 0, typeof(System.Int32));
					r_IsSelected_Int32.SetBelong(this.instance);
				}
				return r_IsSelected_Int32;
			}
		}

		/// <summary>
		/// Void Deselect(Int32)
		/// </summary>
		protected RMethod r_Deselect_Int32;
		public virtual RMethod RDeselect_Int32
		{
			get
			{
				if(r_Deselect_Int32 == null)
				{
					r_Deselect_Int32 = new(this, "Deselect", 0, typeof(System.Int32));
					r_Deselect_Int32.SetBelong(this.instance);
				}
				return r_Deselect_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetContentRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GetContentRect_Rect;
		public virtual RMethod RGetContentRect_Rect
		{
			get
			{
				if(r_GetContentRect_Rect == null)
				{
					r_GetContentRect_Rect = new(this, "GetContentRect", 0, typeof(UnityEngine.Rect));
					r_GetContentRect_Rect.SetBelong(this.instance);
				}
				return r_GetContentRect_Rect;
			}
		}

		/// <summary>
		/// Single GetElementYOffset(Int32)
		/// </summary>
		protected RMethod r_GetElementYOffset_Int32;
		public virtual RMethod RGetElementYOffset_Int32
		{
			get
			{
				if(r_GetElementYOffset_Int32 == null)
				{
					r_GetElementYOffset_Int32 = new(this, "GetElementYOffset", 0, typeof(System.Int32));
					r_GetElementYOffset_Int32.SetBelong(this.instance);
				}
				return r_GetElementYOffset_Int32;
			}
		}

		/// <summary>
		/// Single GetElementYOffset(Int32, Int32)
		/// </summary>
		protected RMethod r_GetElementYOffset_Int32_Int32;
		public virtual RMethod RGetElementYOffset_Int32_Int32
		{
			get
			{
				if(r_GetElementYOffset_Int32_Int32 == null)
				{
					r_GetElementYOffset_Int32_Int32 = new(this, "GetElementYOffset", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetElementYOffset_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetElementYOffset_Int32_Int32;
			}
		}

		/// <summary>
		/// Single GetElementHeight(Int32)
		/// </summary>
		protected RMethod r_GetElementHeight_Int32;
		public virtual RMethod RGetElementHeight_Int32
		{
			get
			{
				if(r_GetElementHeight_Int32 == null)
				{
					r_GetElementHeight_Int32 = new(this, "GetElementHeight", 0, typeof(System.Int32));
					r_GetElementHeight_Int32.SetBelong(this.instance);
				}
				return r_GetElementHeight_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetRowRect(Int32, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GetRowRect_Int32_Rect;
		public virtual RMethod RGetRowRect_Int32_Rect
		{
			get
			{
				if(r_GetRowRect_Int32_Rect == null)
				{
					r_GetRowRect_Int32_Rect = new(this, "GetRowRect", 0, typeof(System.Int32), typeof(UnityEngine.Rect));
					r_GetRowRect_Int32_Rect.SetBelong(this.instance);
				}
				return r_GetRowRect_Int32_Rect;
			}
		}

		/// <summary>
		/// Void DoLayoutList()
		/// </summary>
		protected RMethod r_DoLayoutList;
		public virtual RMethod RDoLayoutList
		{
			get
			{
				if(r_DoLayoutList == null)
				{
					r_DoLayoutList = new(this, "DoLayoutList", 0);
					r_DoLayoutList.SetBelong(this.instance);
				}
				return r_DoLayoutList;
			}
		}

		/// <summary>
		/// Void DoList(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DoList_Rect;
		public virtual RMethod RDoList_Rect
		{
			get
			{
				if(r_DoList_Rect == null)
				{
					r_DoList_Rect = new(this, "DoList", 0, typeof(UnityEngine.Rect));
					r_DoList_Rect.SetBelong(this.instance);
				}
				return r_DoList_Rect;
			}
		}

		/// <summary>
		/// Void DoList(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DoList_Rect_Rect;
		public virtual RMethod RDoList_Rect_Rect
		{
			get
			{
				if(r_DoList_Rect_Rect == null)
				{
					r_DoList_Rect_Rect = new(this, "DoList", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_DoList_Rect_Rect.SetBelong(this.instance);
				}
				return r_DoList_Rect_Rect;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_GetHeight;
		public virtual RMethod RGetHeight
		{
			get
			{
				if(r_GetHeight == null)
				{
					r_GetHeight = new(this, "GetHeight", 0);
					r_GetHeight.SetBelong(this.instance);
				}
				return r_GetHeight;
			}
		}

		/// <summary>
		/// Single GetListElementHeight()
		/// </summary>
		protected RMethod r_GetListElementHeight;
		public virtual RMethod RGetListElementHeight
		{
			get
			{
				if(r_GetListElementHeight == null)
				{
					r_GetListElementHeight = new(this, "GetListElementHeight", 0);
					r_GetListElementHeight.SetBelong(this.instance);
				}
				return r_GetListElementHeight;
			}
		}

		/// <summary>
		/// Void DoListElements(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DoListElements_Rect_Rect;
		public virtual RMethod RDoListElements_Rect_Rect
		{
			get
			{
				if(r_DoListElements_Rect_Rect == null)
				{
					r_DoListElements_Rect_Rect = new(this, "DoListElements", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_DoListElements_Rect_Rect.SetBelong(this.instance);
				}
				return r_DoListElements_Rect_Rect;
			}
		}

		/// <summary>
		/// Void DoListHeader(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DoListHeader_Rect;
		public virtual RMethod RDoListHeader_Rect
		{
			get
			{
				if(r_DoListHeader_Rect == null)
				{
					r_DoListHeader_Rect = new(this, "DoListHeader", 0, typeof(UnityEngine.Rect));
					r_DoListHeader_Rect.SetBelong(this.instance);
				}
				return r_DoListHeader_Rect;
			}
		}

		/// <summary>
		/// Void DoListFooter(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DoListFooter_Rect;
		public virtual RMethod RDoListFooter_Rect
		{
			get
			{
				if(r_DoListFooter_Rect == null)
				{
					r_DoListFooter_Rect = new(this, "DoListFooter", 0, typeof(UnityEngine.Rect));
					r_DoListFooter_Rect.SetBelong(this.instance);
				}
				return r_DoListFooter_Rect;
			}
		}

		/// <summary>
		/// Void DoDraggingAndSelection(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DoDraggingAndSelection_Rect;
		public virtual RMethod RDoDraggingAndSelection_Rect
		{
			get
			{
				if(r_DoDraggingAndSelection_Rect == null)
				{
					r_DoDraggingAndSelection_Rect = new(this, "DoDraggingAndSelection", 0, typeof(UnityEngine.Rect));
					r_DoDraggingAndSelection_Rect.SetBelong(this.instance);
				}
				return r_DoDraggingAndSelection_Rect;
			}
		}

		/// <summary>
		/// Boolean IsMouseInsideActiveElement(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_IsMouseInsideActiveElement_Rect;
		public virtual RMethod RIsMouseInsideActiveElement_Rect
		{
			get
			{
				if(r_IsMouseInsideActiveElement_Rect == null)
				{
					r_IsMouseInsideActiveElement_Rect = new(this, "IsMouseInsideActiveElement", 0, typeof(UnityEngine.Rect));
					r_IsMouseInsideActiveElement_Rect.SetBelong(this.instance);
				}
				return r_IsMouseInsideActiveElement_Rect;
			}
		}

		/// <summary>
		/// Void UpdateDraggedY(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_UpdateDraggedY_Rect;
		public virtual RMethod RUpdateDraggedY_Rect
		{
			get
			{
				if(r_UpdateDraggedY_Rect == null)
				{
					r_UpdateDraggedY_Rect = new(this, "UpdateDraggedY", 0, typeof(UnityEngine.Rect));
					r_UpdateDraggedY_Rect.SetBelong(this.instance);
				}
				return r_UpdateDraggedY_Rect;
			}
		}

		/// <summary>
		/// Single GetClampedDragPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GetClampedDragPosition_Rect;
		public virtual RMethod RGetClampedDragPosition_Rect
		{
			get
			{
				if(r_GetClampedDragPosition_Rect == null)
				{
					r_GetClampedDragPosition_Rect = new(this, "GetClampedDragPosition", 0, typeof(UnityEngine.Rect));
					r_GetClampedDragPosition_Rect.SetBelong(this.instance);
				}
				return r_GetClampedDragPosition_Rect;
			}
		}

		/// <summary>
		/// Int32 CalculateRowIndex(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_CalculateRowIndex_Rect;
		public virtual RMethod RCalculateRowIndex_Rect
		{
			get
			{
				if(r_CalculateRowIndex_Rect == null)
				{
					r_CalculateRowIndex_Rect = new(this, "CalculateRowIndex", 0, typeof(UnityEngine.Rect));
					r_CalculateRowIndex_Rect.SetBelong(this.instance);
				}
				return r_CalculateRowIndex_Rect;
			}
		}

		/// <summary>
		/// Int32 GetRowIndex(Single, Boolean)
		/// </summary>
		protected RMethod r_GetRowIndex_Single_Boolean;
		public virtual RMethod RGetRowIndex_Single_Boolean
		{
			get
			{
				if(r_GetRowIndex_Single_Boolean == null)
				{
					r_GetRowIndex_Single_Boolean = new(this, "GetRowIndex", 0, typeof(System.Single), typeof(System.Boolean));
					r_GetRowIndex_Single_Boolean.SetBelong(this.instance);
				}
				return r_GetRowIndex_Single_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsDragging()
		/// </summary>
		protected RMethod r_IsDragging;
		public virtual RMethod RIsDragging
		{
			get
			{
				if(r_IsDragging == null)
				{
					r_IsDragging = new(this, "IsDragging", 0);
					r_IsDragging.SetBelong(this.instance);
				}
				return r_IsDragging;
			}
		}

		/// <summary>
		/// Void GrabKeyboardFocus()
		/// </summary>
		protected RMethod r_GrabKeyboardFocus;
		public virtual RMethod RGrabKeyboardFocus
		{
			get
			{
				if(r_GrabKeyboardFocus == null)
				{
					r_GrabKeyboardFocus = new(this, "GrabKeyboardFocus", 0);
					r_GrabKeyboardFocus.SetBelong(this.instance);
				}
				return r_GrabKeyboardFocus;
			}
		}

		/// <summary>
		/// Void ReleaseKeyboardFocus()
		/// </summary>
		protected RMethod r_ReleaseKeyboardFocus;
		public virtual RMethod RReleaseKeyboardFocus
		{
			get
			{
				if(r_ReleaseKeyboardFocus == null)
				{
					r_ReleaseKeyboardFocus = new(this, "ReleaseKeyboardFocus", 0);
					r_ReleaseKeyboardFocus.SetBelong(this.instance);
				}
				return r_ReleaseKeyboardFocus;
			}
		}

		/// <summary>
		/// Boolean HasKeyboardControl()
		/// </summary>
		protected RMethod r_HasKeyboardControl;
		public virtual RMethod RHasKeyboardControl
		{
			get
			{
				if(r_HasKeyboardControl == null)
				{
					r_HasKeyboardControl = new(this, "HasKeyboardControl", 0);
					r_HasKeyboardControl.SetBelong(this.instance);
				}
				return r_HasKeyboardControl;
			}
		}

		/// <summary>
		/// Boolean <CheckForChildInvalidation>b__58_0(System.String)
		/// </summary>
		protected RMethod r___0__CheckForChildInvalidation__1__b__58_0_String;
		public virtual RMethod R__0__CheckForChildInvalidation__1__b__58_0_String
		{
			get
			{
				if(r___0__CheckForChildInvalidation__1__b__58_0_String == null)
				{
					r___0__CheckForChildInvalidation__1__b__58_0_String = new(this, "<CheckForChildInvalidation>b__58_0", 0, typeof(System.String));
					r___0__CheckForChildInvalidation__1__b__58_0_String.SetBelong(this.instance);
				}
				return r___0__CheckForChildInvalidation__1__b__58_0_String;
			}
		}

		/// <summary>
		/// Boolean <DoDraggingAndSelection>b__130_0(Int32)
		/// </summary>
		protected RMethod r___0__DoDraggingAndSelection__1__b__130_0_Int32;
		public virtual RMethod R__0__DoDraggingAndSelection__1__b__130_0_Int32
		{
			get
			{
				if(r___0__DoDraggingAndSelection__1__b__130_0_Int32 == null)
				{
					r___0__DoDraggingAndSelection__1__b__130_0_Int32 = new(this, "<DoDraggingAndSelection>b__130_0", 0, typeof(System.Int32));
					r___0__DoDraggingAndSelection__1__b__130_0_Int32.SetBelong(this.instance);
				}
				return r___0__DoDraggingAndSelection__1__b__130_0_Int32;
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


        public RReorderableList() : base("UnityEditorInternal.ReorderableList")
        {
        }

        public RReorderableList(System.Object instance) : base("UnityEditorInternal.ReorderableList")
		{
            SetInstance(instance);
		}

        public RReorderableList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReorderableList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.String GetParentListPath(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RGetParentListPath_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void InvalidateParentCaches(System.String @propertyPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyPath};
            var ___result = RInvalidateParentCaches_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckForChildInvalidation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckForChildInvalidation.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InvalidateForGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateForGUI.Invoke(___genericsType, ___parameters);

            
        }


        public static void InvalidateExistingListCaches()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateExistingListCaches.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditorInternal.ReorderableList GetReorderableListFromSerializedProperty(UnityEditor.SerializedProperty @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RGetReorderableListFromSerializedProperty_SerializedProperty.Invoke(___genericsType, ___parameters);

            return (UnityEditorInternal.ReorderableList)___result;
        }


        public virtual void InitList(UnityEditor.SerializedObject @serializedObject, UnityEditor.SerializedProperty @elements, System.Collections.IList @elementList, System.Boolean @draggable, System.Boolean @displayHeader, System.Boolean @displayAddButton, System.Boolean @displayRemoveButton)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedObject, @elements, @elementList, @draggable, @displayHeader, @displayAddButton, @displayRemoveButton};
            var ___result = RInitList_SerializedObject_SerializedProperty_IList_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TryOverrideElementHeightWithPropertyDrawer(UnityEditor.SerializedProperty @property, ref System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @height};
            var ___result = RTryOverrideElementHeightWithPropertyDrawer_SerializedProperty_Ref_Single.Invoke(___genericsType, ___parameters);
			@height = (System.Single)___parameters[1];

            
        }


        public virtual void CacheIfNeeded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCacheIfNeeded.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvalidateCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvalidateCacheRecursive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateCacheRecursive.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearSelection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Select(System.Int32 @index, System.Boolean @append)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @append};
            var ___result = RSelect_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectRange(System.Int32 @indexFrom, System.Int32 @indexTo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@indexFrom, @indexTo};
            var ___result = RSelectRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSelected(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RIsSelected_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Deselect(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RDeselect_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetContentRect(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RGetContentRect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Single GetElementYOffset(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetElementYOffset_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetElementYOffset(System.Int32 @index, System.Int32 @skipIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @skipIndex};
            var ___result = RGetElementYOffset_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetElementHeight(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetElementHeight_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual UnityEngine.Rect GetRowRect(System.Int32 @index, UnityEngine.Rect @listRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @listRect};
            var ___result = RGetRowRect_Int32_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void DoLayoutList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoLayoutList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoList(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RDoList_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoList(UnityEngine.Rect @rect, UnityEngine.Rect @visibleRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @visibleRect};
            var ___result = RDoList_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetListElementHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetListElementHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void DoListElements(UnityEngine.Rect @listRect, UnityEngine.Rect @visibleRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect, @visibleRect};
            var ___result = RDoListElements_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoListHeader(UnityEngine.Rect @headerRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headerRect};
            var ___result = RDoListHeader_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoListFooter(UnityEngine.Rect @footerRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@footerRect};
            var ___result = RDoListFooter_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoDraggingAndSelection(UnityEngine.Rect @listRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect};
            var ___result = RDoDraggingAndSelection_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsMouseInsideActiveElement(UnityEngine.Rect @listRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect};
            var ___result = RIsMouseInsideActiveElement_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateDraggedY(UnityEngine.Rect @listRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect};
            var ___result = RUpdateDraggedY_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetClampedDragPosition(UnityEngine.Rect @listRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect};
            var ___result = RGetClampedDragPosition_Rect.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 CalculateRowIndex(UnityEngine.Rect @listRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listRect};
            var ___result = RCalculateRowIndex_Rect.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetRowIndex(System.Single @localY, System.Boolean @skipActiveElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localY, @skipActiveElement};
            var ___result = RGetRowIndex_Single_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsDragging()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDragging.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GrabKeyboardFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGrabKeyboardFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleaseKeyboardFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseKeyboardFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasKeyboardControl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasKeyboardControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__CheckForChildInvalidation__1__b__58_0(System.String @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = R__0__CheckForChildInvalidation__1__b__58_0_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__DoDraggingAndSelection__1__b__130_0(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = R__0__DoDraggingAndSelection__1__b__130_0_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
