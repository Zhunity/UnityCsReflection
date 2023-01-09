using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.ActiveEditorTracker
	/// </summary>
    public partial class RActiveEditorTracker : RMember //
    {

		/// <summary>
		/// System.Action editorTrackerRebuilt
		/// </summary>
		protected static REvent r_editorTrackerRebuilt;
		public static REvent ReditorTrackerRebuilt
		{
			get
			{
				if(r_editorTrackerRebuilt == null)
				{
					r_editorTrackerRebuilt = new(typeof(UnityEditor.ActiveEditorTracker), "editorTrackerRebuilt");
					r_editorTrackerRebuilt.SetBelong(null);
				}
				return r_editorTrackerRebuilt;
			}
		}

		/// <summary>
		/// UnityEditor.MonoReloadableIntPtrClear m_Property
		/// </summary>
		protected RUnityEditor.RMonoReloadableIntPtrClear r_m_Property;
		public virtual RUnityEditor.RMonoReloadableIntPtrClear Rm_Property
		{
			get
			{
				if(r_m_Property == null)
				{
					r_m_Property = new(this, "m_Property");
					r_m_Property.SetBelong(this.instance);
				}
				return r_m_Property;
			}
		}

		/// <summary>
		/// UnityEditor.Editor[] activeEditors
		/// </summary>
		protected RPropertyArray<RUnityEditor.REditor> r_activeEditors;
		public virtual RPropertyArray<RUnityEditor.REditor> RactiveEditors
		{
			get
			{
				if(r_activeEditors == null)
				{
					r_activeEditors = new(this, "activeEditors", -1);
					r_activeEditors.SetBelong(this.instance);
				}
				return r_activeEditors;
			}
		}

		/// <summary>
		/// Boolean isDirty
		/// </summary>
		protected RProperty r_isDirty;
		public virtual RProperty RisDirty
		{
			get
			{
				if(r_isDirty == null)
				{
					r_isDirty = new(this, "isDirty", -1);
					r_isDirty.SetBelong(this.instance);
				}
				return r_isDirty;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected RProperty r_isLocked;
		public virtual RProperty RisLocked
		{
			get
			{
				if(r_isLocked == null)
				{
					r_isLocked = new(this, "isLocked", -1);
					r_isLocked.SetBelong(this.instance);
				}
				return r_isLocked;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected RProperty r_hasUnsavedChanges;
		public virtual RProperty RhasUnsavedChanges
		{
			get
			{
				if(r_hasUnsavedChanges == null)
				{
					r_hasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
					r_hasUnsavedChanges.SetBelong(this.instance);
				}
				return r_hasUnsavedChanges;
			}
		}

		/// <summary>
		/// Boolean delayFlushDirtyRebuild
		/// </summary>
		protected static RProperty r_delayFlushDirtyRebuild;
		public static RProperty RdelayFlushDirtyRebuild
		{
			get
			{
				if(r_delayFlushDirtyRebuild == null)
				{
					r_delayFlushDirtyRebuild = new(typeof(UnityEditor.ActiveEditorTracker), "delayFlushDirtyRebuild", -1);
					r_delayFlushDirtyRebuild.SetBelong(null);
				}
				return r_delayFlushDirtyRebuild;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode inspectorMode
		/// </summary>
		protected RProperty r_inspectorMode;
		public virtual RProperty RinspectorMode
		{
			get
			{
				if(r_inspectorMode == null)
				{
					r_inspectorMode = new(this, "inspectorMode", -1);
					r_inspectorMode.SetBelong(this.instance);
				}
				return r_inspectorMode;
			}
		}

		/// <summary>
		/// Boolean hasComponentsWhichCannotBeMultiEdited
		/// </summary>
		protected RProperty r_hasComponentsWhichCannotBeMultiEdited;
		public virtual RProperty RhasComponentsWhichCannotBeMultiEdited
		{
			get
			{
				if(r_hasComponentsWhichCannotBeMultiEdited == null)
				{
					r_hasComponentsWhichCannotBeMultiEdited = new(this, "hasComponentsWhichCannotBeMultiEdited", -1);
					r_hasComponentsWhichCannotBeMultiEdited.SetBelong(this.instance);
				}
				return r_hasComponentsWhichCannotBeMultiEdited;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode dataMode
		/// </summary>
		protected RProperty r_dataMode;
		public virtual RProperty RdataMode
		{
			get
			{
				if(r_dataMode == null)
				{
					r_dataMode = new(this, "dataMode", -1);
					r_dataMode.SetBelong(this.instance);
				}
				return r_dataMode;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker sharedTracker
		/// </summary>
		protected static RUnityEditor.RActiveEditorTracker r_sharedTracker;
		public static RUnityEditor.RActiveEditorTracker RsharedTracker
		{
			get
			{
				if(r_sharedTracker == null)
				{
					r_sharedTracker = new(typeof(UnityEditor.ActiveEditorTracker), "sharedTracker", -1);
					r_sharedTracker.SetBelong(null);
				}
				return r_sharedTracker;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_Create_ActiveEditorTracker;
		public static RMethod RInternal_Create_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_Create_ActiveEditorTracker == null)
				{
					r_Internal_Create_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_Create", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_Create_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_Create_ActiveEditorTracker;
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
		/// Void Internal_Dispose(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_Dispose_ActiveEditorTracker;
		public static RMethod RInternal_Dispose_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_Dispose_ActiveEditorTracker == null)
				{
					r_Internal_Dispose_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_Dispose", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_Dispose_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_Dispose_ActiveEditorTracker;
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
		/// Void Internal_Destroy(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_Destroy_ActiveEditorTracker;
		public static RMethod RInternal_Destroy_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_Destroy_ActiveEditorTracker == null)
				{
					r_Internal_Destroy_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_Destroy", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_Destroy_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_Destroy_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_Destroy;
		public virtual RMethod RDestroy
		{
			get
			{
				if(r_Destroy == null)
				{
					r_Destroy = new(this, "Destroy", 0);
					r_Destroy.SetBelong(this.instance);
				}
				return r_Destroy;
			}
		}

		/// <summary>
		/// System.Array Internal_GetActiveEditors(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_GetActiveEditors_ActiveEditorTracker;
		public static RMethod RInternal_GetActiveEditors_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_GetActiveEditors_ActiveEditorTracker == null)
				{
					r_Internal_GetActiveEditors_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetActiveEditors", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_GetActiveEditors_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_GetActiveEditors_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_GetActiveEditorsNonAlloc(UnityEditor.ActiveEditorTracker, UnityEditor.Editor[])
		/// </summary>
		protected static RMethod r_Internal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray;
		public static RMethod RInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray
		{
			get
			{
				if(r_Internal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray == null)
				{
					r_Internal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetActiveEditorsNonAlloc", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(UnityEditor.Editor).MakeArrayType());
					r_Internal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray.SetBelong(null);
				}
				return r_Internal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray;
			}
		}

		/// <summary>
		/// Void GetObjectsLockedByThisTracker(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_GetObjectsLockedByThisTracker_List_d_Object_p_;
		public virtual RMethod RGetObjectsLockedByThisTracker_List_d_Object_p_
		{
			get
			{
				if(r_GetObjectsLockedByThisTracker_List_d_Object_p_ == null)
				{
					r_GetObjectsLockedByThisTracker_List_d_Object_p_ = new(this, "GetObjectsLockedByThisTracker", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_GetObjectsLockedByThisTracker_List_d_Object_p_.SetBelong(this.instance);
				}
				return r_GetObjectsLockedByThisTracker_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void Internal_GetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker, System.Object)
		/// </summary>
		protected static RMethod r_Internal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
		public static RMethod RInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object
		{
			get
			{
				if(r_Internal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object == null)
				{
					r_Internal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetObjectsLockedByThisTrackerInternal", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Object));
					r_Internal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.SetBelong(null);
				}
				return r_Internal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
			}
		}

		/// <summary>
		/// Void GetObjectsLockedByThisTrackerInternal(System.Object)
		/// </summary>
		protected RMethod r_GetObjectsLockedByThisTrackerInternal_Object;
		public virtual RMethod RGetObjectsLockedByThisTrackerInternal_Object
		{
			get
			{
				if(r_GetObjectsLockedByThisTrackerInternal_Object == null)
				{
					r_GetObjectsLockedByThisTrackerInternal_Object = new(this, "GetObjectsLockedByThisTrackerInternal", 0, typeof(System.Object));
					r_GetObjectsLockedByThisTrackerInternal_Object.SetBelong(this.instance);
				}
				return r_GetObjectsLockedByThisTrackerInternal_Object;
			}
		}

		/// <summary>
		/// Void SetObjectsLockedByThisTracker(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_SetObjectsLockedByThisTracker_List_d_Object_p_;
		public virtual RMethod RSetObjectsLockedByThisTracker_List_d_Object_p_
		{
			get
			{
				if(r_SetObjectsLockedByThisTracker_List_d_Object_p_ == null)
				{
					r_SetObjectsLockedByThisTracker_List_d_Object_p_ = new(this, "SetObjectsLockedByThisTracker", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_SetObjectsLockedByThisTracker_List_d_Object_p_.SetBelong(this.instance);
				}
				return r_SetObjectsLockedByThisTracker_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void Internal_SetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker, System.Object)
		/// </summary>
		protected static RMethod r_Internal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
		public static RMethod RInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object
		{
			get
			{
				if(r_Internal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object == null)
				{
					r_Internal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetObjectsLockedByThisTrackerInternal", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Object));
					r_Internal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.SetBelong(null);
				}
				return r_Internal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
			}
		}

		/// <summary>
		/// Void SetObjectsLockedByThisTrackerInternal(System.Object)
		/// </summary>
		protected RMethod r_SetObjectsLockedByThisTrackerInternal_Object;
		public virtual RMethod RSetObjectsLockedByThisTrackerInternal_Object
		{
			get
			{
				if(r_SetObjectsLockedByThisTrackerInternal_Object == null)
				{
					r_SetObjectsLockedByThisTrackerInternal_Object = new(this, "SetObjectsLockedByThisTrackerInternal", 0, typeof(System.Object));
					r_SetObjectsLockedByThisTrackerInternal_Object.SetBelong(this.instance);
				}
				return r_SetObjectsLockedByThisTrackerInternal_Object;
			}
		}

		/// <summary>
		/// Int32 Internal_GetVisible(UnityEditor.ActiveEditorTracker, Int32)
		/// </summary>
		protected static RMethod r_Internal_GetVisible_ActiveEditorTracker_Int32;
		public static RMethod RInternal_GetVisible_ActiveEditorTracker_Int32
		{
			get
			{
				if(r_Internal_GetVisible_ActiveEditorTracker_Int32 == null)
				{
					r_Internal_GetVisible_ActiveEditorTracker_Int32 = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetVisible", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Int32));
					r_Internal_GetVisible_ActiveEditorTracker_Int32.SetBelong(null);
				}
				return r_Internal_GetVisible_ActiveEditorTracker_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVisible(Int32)
		/// </summary>
		protected RMethod r_GetVisible_Int32;
		public virtual RMethod RGetVisible_Int32
		{
			get
			{
				if(r_GetVisible_Int32 == null)
				{
					r_GetVisible_Int32 = new(this, "GetVisible", 0, typeof(System.Int32));
					r_GetVisible_Int32.SetBelong(this.instance);
				}
				return r_GetVisible_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetVisible(UnityEditor.ActiveEditorTracker, Int32, Int32)
		/// </summary>
		protected static RMethod r_Internal_SetVisible_ActiveEditorTracker_Int32_Int32;
		public static RMethod RInternal_SetVisible_ActiveEditorTracker_Int32_Int32
		{
			get
			{
				if(r_Internal_SetVisible_ActiveEditorTracker_Int32_Int32 == null)
				{
					r_Internal_SetVisible_ActiveEditorTracker_Int32_Int32 = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetVisible", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Int32), typeof(System.Int32));
					r_Internal_SetVisible_ActiveEditorTracker_Int32_Int32.SetBelong(null);
				}
				return r_Internal_SetVisible_ActiveEditorTracker_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVisible(Int32, Int32)
		/// </summary>
		protected RMethod r_SetVisible_Int32_Int32;
		public virtual RMethod RSetVisible_Int32_Int32
		{
			get
			{
				if(r_SetVisible_Int32_Int32 == null)
				{
					r_SetVisible_Int32_Int32 = new(this, "SetVisible", 0, typeof(System.Int32), typeof(System.Int32));
					r_SetVisible_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetVisible_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Internal_GetIsDirty(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_GetIsDirty_ActiveEditorTracker;
		public static RMethod RInternal_GetIsDirty_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_GetIsDirty_ActiveEditorTracker == null)
				{
					r_Internal_GetIsDirty_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetIsDirty", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_GetIsDirty_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_GetIsDirty_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_ClearDirty(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_ClearDirty_ActiveEditorTracker;
		public static RMethod RInternal_ClearDirty_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_ClearDirty_ActiveEditorTracker == null)
				{
					r_Internal_ClearDirty_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_ClearDirty", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_ClearDirty_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_ClearDirty_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void ClearDirty()
		/// </summary>
		protected RMethod r_ClearDirty;
		public virtual RMethod RClearDirty
		{
			get
			{
				if(r_ClearDirty == null)
				{
					r_ClearDirty = new(this, "ClearDirty", 0);
					r_ClearDirty.SetBelong(this.instance);
				}
				return r_ClearDirty;
			}
		}

		/// <summary>
		/// Boolean Internal_GetIsLocked(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_GetIsLocked_ActiveEditorTracker;
		public static RMethod RInternal_GetIsLocked_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_GetIsLocked_ActiveEditorTracker == null)
				{
					r_Internal_GetIsLocked_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetIsLocked", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_GetIsLocked_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_GetIsLocked_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_SetIsLocked(UnityEditor.ActiveEditorTracker, Boolean)
		/// </summary>
		protected static RMethod r_Internal_SetIsLocked_ActiveEditorTracker_Boolean;
		public static RMethod RInternal_SetIsLocked_ActiveEditorTracker_Boolean
		{
			get
			{
				if(r_Internal_SetIsLocked_ActiveEditorTracker_Boolean == null)
				{
					r_Internal_SetIsLocked_ActiveEditorTracker_Boolean = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetIsLocked", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Boolean));
					r_Internal_SetIsLocked_ActiveEditorTracker_Boolean.SetBelong(null);
				}
				return r_Internal_SetIsLocked_ActiveEditorTracker_Boolean;
			}
		}

		/// <summary>
		/// Boolean Internal_HasUnsavedChanges(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_HasUnsavedChanges_ActiveEditorTracker;
		public static RMethod RInternal_HasUnsavedChanges_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_HasUnsavedChanges_ActiveEditorTracker == null)
				{
					r_Internal_HasUnsavedChanges_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_HasUnsavedChanges", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_HasUnsavedChanges_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_HasUnsavedChanges_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_UnsavedChangesStateChanged(UnityEditor.ActiveEditorTracker, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Internal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean;
		public static RMethod RInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean
		{
			get
			{
				if(r_Internal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean == null)
				{
					r_Internal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_UnsavedChangesStateChanged", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Int32), typeof(System.Boolean));
					r_Internal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean.SetBelong(null);
				}
				return r_Internal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void UnsavedChangesStateChanged(UnityEditor.Editor, Boolean)
		/// </summary>
		protected RMethod r_UnsavedChangesStateChanged_Editor_Boolean;
		public virtual RMethod RUnsavedChangesStateChanged_Editor_Boolean
		{
			get
			{
				if(r_UnsavedChangesStateChanged_Editor_Boolean == null)
				{
					r_UnsavedChangesStateChanged_Editor_Boolean = new(this, "UnsavedChangesStateChanged", 0, typeof(UnityEditor.Editor), typeof(System.Boolean));
					r_UnsavedChangesStateChanged_Editor_Boolean.SetBelong(this.instance);
				}
				return r_UnsavedChangesStateChanged_Editor_Boolean;
			}
		}

		/// <summary>
		/// Boolean Internal_GetDelayFlushDirtyRebuild()
		/// </summary>
		protected static RMethod r_Internal_GetDelayFlushDirtyRebuild;
		public static RMethod RInternal_GetDelayFlushDirtyRebuild
		{
			get
			{
				if(r_Internal_GetDelayFlushDirtyRebuild == null)
				{
					r_Internal_GetDelayFlushDirtyRebuild = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetDelayFlushDirtyRebuild", 0);
					r_Internal_GetDelayFlushDirtyRebuild.SetBelong(null);
				}
				return r_Internal_GetDelayFlushDirtyRebuild;
			}
		}

		/// <summary>
		/// Void Internal_SetDelayFlushDirtyRebuild(Boolean)
		/// </summary>
		protected static RMethod r_Internal_SetDelayFlushDirtyRebuild_Boolean;
		public static RMethod RInternal_SetDelayFlushDirtyRebuild_Boolean
		{
			get
			{
				if(r_Internal_SetDelayFlushDirtyRebuild_Boolean == null)
				{
					r_Internal_SetDelayFlushDirtyRebuild_Boolean = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetDelayFlushDirtyRebuild", 0, typeof(System.Boolean));
					r_Internal_SetDelayFlushDirtyRebuild_Boolean.SetBelong(null);
				}
				return r_Internal_SetDelayFlushDirtyRebuild_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode Internal_GetInspectorMode(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_GetInspectorMode_ActiveEditorTracker;
		public static RMethod RInternal_GetInspectorMode_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_GetInspectorMode_ActiveEditorTracker == null)
				{
					r_Internal_GetInspectorMode_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetInspectorMode", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_GetInspectorMode_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_GetInspectorMode_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_SetInspectorMode(UnityEditor.ActiveEditorTracker, UnityEditor.InspectorMode)
		/// </summary>
		protected static RMethod r_Internal_SetInspectorMode_ActiveEditorTracker_InspectorMode;
		public static RMethod RInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode
		{
			get
			{
				if(r_Internal_SetInspectorMode_ActiveEditorTracker_InspectorMode == null)
				{
					r_Internal_SetInspectorMode_ActiveEditorTracker_InspectorMode = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetInspectorMode", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(UnityEditor.InspectorMode));
					r_Internal_SetInspectorMode_ActiveEditorTracker_InspectorMode.SetBelong(null);
				}
				return r_Internal_SetInspectorMode_ActiveEditorTracker_InspectorMode;
			}
		}

		/// <summary>
		/// Boolean Internal_GetHasComponentsWhichCannotBeMultiEdited(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker;
		public static RMethod RInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker == null)
				{
					r_Internal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetHasComponentsWhichCannotBeMultiEdited", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_RebuildIfNecessary(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_RebuildIfNecessary_ActiveEditorTracker;
		public static RMethod RInternal_RebuildIfNecessary_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_RebuildIfNecessary_ActiveEditorTracker == null)
				{
					r_Internal_RebuildIfNecessary_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_RebuildIfNecessary", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_RebuildIfNecessary_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_RebuildIfNecessary_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void RebuildIfNecessary()
		/// </summary>
		protected RMethod r_RebuildIfNecessary;
		public virtual RMethod RRebuildIfNecessary
		{
			get
			{
				if(r_RebuildIfNecessary == null)
				{
					r_RebuildIfNecessary = new(this, "RebuildIfNecessary", 0);
					r_RebuildIfNecessary.SetBelong(this.instance);
				}
				return r_RebuildIfNecessary;
			}
		}

		/// <summary>
		/// Void Internal_RebuildAllIfNecessary()
		/// </summary>
		protected static RMethod r_Internal_RebuildAllIfNecessary;
		public static RMethod RInternal_RebuildAllIfNecessary
		{
			get
			{
				if(r_Internal_RebuildAllIfNecessary == null)
				{
					r_Internal_RebuildAllIfNecessary = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_RebuildAllIfNecessary", 0);
					r_Internal_RebuildAllIfNecessary.SetBelong(null);
				}
				return r_Internal_RebuildAllIfNecessary;
			}
		}

		/// <summary>
		/// Void RebuildAllIfNecessary()
		/// </summary>
		protected static RMethod r_RebuildAllIfNecessary;
		public static RMethod RRebuildAllIfNecessary
		{
			get
			{
				if(r_RebuildAllIfNecessary == null)
				{
					r_RebuildAllIfNecessary = new(typeof(UnityEditor.ActiveEditorTracker), "RebuildAllIfNecessary", 0);
					r_RebuildAllIfNecessary.SetBelong(null);
				}
				return r_RebuildAllIfNecessary;
			}
		}

		/// <summary>
		/// Void Internal_ForceRebuild(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_ForceRebuild_ActiveEditorTracker;
		public static RMethod RInternal_ForceRebuild_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_ForceRebuild_ActiveEditorTracker == null)
				{
					r_Internal_ForceRebuild_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_ForceRebuild", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_ForceRebuild_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_ForceRebuild_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void ForceRebuild()
		/// </summary>
		protected RMethod r_ForceRebuild;
		public virtual RMethod RForceRebuild
		{
			get
			{
				if(r_ForceRebuild == null)
				{
					r_ForceRebuild = new(this, "ForceRebuild", 0);
					r_ForceRebuild.SetBelong(this.instance);
				}
				return r_ForceRebuild;
			}
		}

		/// <summary>
		/// Void Internal_VerifyModifiedMonoBehaviours(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_VerifyModifiedMonoBehaviours_ActiveEditorTracker;
		public static RMethod RInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_VerifyModifiedMonoBehaviours_ActiveEditorTracker == null)
				{
					r_Internal_VerifyModifiedMonoBehaviours_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_VerifyModifiedMonoBehaviours", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_VerifyModifiedMonoBehaviours_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_VerifyModifiedMonoBehaviours_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void VerifyModifiedMonoBehaviours()
		/// </summary>
		protected RMethod r_VerifyModifiedMonoBehaviours;
		public virtual RMethod RVerifyModifiedMonoBehaviours
		{
			get
			{
				if(r_VerifyModifiedMonoBehaviours == null)
				{
					r_VerifyModifiedMonoBehaviours = new(this, "VerifyModifiedMonoBehaviours", 0);
					r_VerifyModifiedMonoBehaviours.SetBelong(this.instance);
				}
				return r_VerifyModifiedMonoBehaviours;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode Internal_GetDataMode(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_Internal_GetDataMode_ActiveEditorTracker;
		public static RMethod RInternal_GetDataMode_ActiveEditorTracker
		{
			get
			{
				if(r_Internal_GetDataMode_ActiveEditorTracker == null)
				{
					r_Internal_GetDataMode_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetDataMode", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_Internal_GetDataMode_ActiveEditorTracker.SetBelong(null);
				}
				return r_Internal_GetDataMode_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_SetDataMode(UnityEditor.ActiveEditorTracker, UnityEditor.DataMode)
		/// </summary>
		protected static RMethod r_Internal_SetDataMode_ActiveEditorTracker_DataMode;
		public static RMethod RInternal_SetDataMode_ActiveEditorTracker_DataMode
		{
			get
			{
				if(r_Internal_SetDataMode_ActiveEditorTracker_DataMode == null)
				{
					r_Internal_SetDataMode_ActiveEditorTracker_DataMode = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetDataMode", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(UnityEditor.DataMode));
					r_Internal_SetDataMode_ActiveEditorTracker_DataMode.SetBelong(null);
				}
				return r_Internal_SetDataMode_ActiveEditorTracker_DataMode;
			}
		}

		/// <summary>
		/// UnityEditor.Editor MakeCustomEditor(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MakeCustomEditor_Object;
		public static RMethod RMakeCustomEditor_Object
		{
			get
			{
				if(r_MakeCustomEditor_Object == null)
				{
					r_MakeCustomEditor_Object = new(typeof(UnityEditor.ActiveEditorTracker), "MakeCustomEditor", 0, typeof(UnityEngine.Object));
					r_MakeCustomEditor_Object.SetBelong(null);
				}
				return r_MakeCustomEditor_Object;
			}
		}

		/// <summary>
		/// Boolean HasCustomEditor(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_HasCustomEditor_Object;
		public static RMethod RHasCustomEditor_Object
		{
			get
			{
				if(r_HasCustomEditor_Object == null)
				{
					r_HasCustomEditor_Object = new(typeof(UnityEditor.ActiveEditorTracker), "HasCustomEditor", 0, typeof(UnityEngine.Object));
					r_HasCustomEditor_Object.SetBelong(null);
				}
				return r_HasCustomEditor_Object;
			}
		}

		/// <summary>
		/// Void SetupSharedTracker(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_SetupSharedTracker_ActiveEditorTracker;
		public static RMethod RSetupSharedTracker_ActiveEditorTracker
		{
			get
			{
				if(r_SetupSharedTracker_ActiveEditorTracker == null)
				{
					r_SetupSharedTracker_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "SetupSharedTracker", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_SetupSharedTracker_ActiveEditorTracker.SetBelong(null);
				}
				return r_SetupSharedTracker_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_OnTrackerRebuild()
		/// </summary>
		protected static RMethod r_Internal_OnTrackerRebuild;
		public static RMethod RInternal_OnTrackerRebuild
		{
			get
			{
				if(r_Internal_OnTrackerRebuild == null)
				{
					r_Internal_OnTrackerRebuild = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_OnTrackerRebuild", 0);
					r_Internal_OnTrackerRebuild.SetBelong(null);
				}
				return r_Internal_OnTrackerRebuild;
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


        public RActiveEditorTracker() : base("UnityEditor.ActiveEditorTracker")
        {
        }

        public RActiveEditorTracker(System.Object instance) : base("UnityEditor.ActiveEditorTracker")
		{
            SetInstance(instance);
		}

        public RActiveEditorTracker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RActiveEditorTracker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_Create(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_Create_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Internal_Dispose(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_Dispose_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Destroy(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_Destroy_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Array Internal_GetActiveEditors(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_GetActiveEditors_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static void Internal_GetActiveEditorsNonAlloc(UnityEditor.ActiveEditorTracker @self, UnityEditor.Editor[] @editors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @editors};
            var ___result = RInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectsLockedByThisTracker(System.Collections.Generic.List<UnityEngine.Object> @lockedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockedObjects};
            var ___result = RGetObjectsLockedByThisTracker_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_GetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker @self, System.Object @lockedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @lockedObjects};
            var ___result = RInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectsLockedByThisTrackerInternal(System.Object @lockedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockedObjects};
            var ___result = RGetObjectsLockedByThisTrackerInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetObjectsLockedByThisTracker(System.Collections.Generic.List<UnityEngine.Object> @toBeLocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toBeLocked};
            var ___result = RSetObjectsLockedByThisTracker_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_SetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker @self, System.Object @toBeLocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @toBeLocked};
            var ___result = RInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetObjectsLockedByThisTrackerInternal(System.Object @toBeLocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toBeLocked};
            var ___result = RSetObjectsLockedByThisTrackerInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 Internal_GetVisible(UnityEditor.ActiveEditorTracker @self, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index};
            var ___result = RInternal_GetVisible_ActiveEditorTracker_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVisible(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetVisible_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Internal_SetVisible(UnityEditor.ActiveEditorTracker @self, System.Int32 @index, System.Int32 @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @visible};
            var ___result = RInternal_SetVisible_ActiveEditorTracker_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVisible(System.Int32 @index, System.Int32 @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @visible};
            var ___result = RSetVisible_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetIsDirty(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_GetIsDirty_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_ClearDirty(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_ClearDirty_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearDirty.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetIsLocked(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_GetIsLocked_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_SetIsLocked(UnityEditor.ActiveEditorTracker @self, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @value};
            var ___result = RInternal_SetIsLocked_ActiveEditorTracker_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_HasUnsavedChanges(UnityEditor.ActiveEditorTracker @activeEditorTracker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@activeEditorTracker};
            var ___result = RInternal_HasUnsavedChanges_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_UnsavedChangesStateChanged(UnityEditor.ActiveEditorTracker @self, System.Int32 @editorInstance, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @editorInstance, @value};
            var ___result = RInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsavedChangesStateChanged(UnityEditor.Editor @editor, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @value};
            var ___result = RUnsavedChangesStateChanged_Editor_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetDelayFlushDirtyRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetDelayFlushDirtyRebuild.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_SetDelayFlushDirtyRebuild(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RInternal_SetDelayFlushDirtyRebuild_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.InspectorMode Internal_GetInspectorMode(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_GetInspectorMode_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (UnityEditor.InspectorMode)___result;
        }


        public static void Internal_SetInspectorMode(UnityEditor.ActiveEditorTracker @self, UnityEditor.InspectorMode @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @value};
            var ___result = RInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetHasComponentsWhichCannotBeMultiEdited(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_RebuildIfNecessary(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_RebuildIfNecessary_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RebuildIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRebuildIfNecessary.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_RebuildAllIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_RebuildAllIfNecessary.Invoke(___genericsType, ___parameters);

            
        }


        public static void RebuildAllIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRebuildAllIfNecessary.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_ForceRebuild(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_ForceRebuild_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ForceRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RForceRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_VerifyModifiedMonoBehaviours(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyModifiedMonoBehaviours()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVerifyModifiedMonoBehaviours.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.DataMode Internal_GetDataMode(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_GetDataMode_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (UnityEditor.DataMode)___result;
        }


        public static void Internal_SetDataMode(UnityEditor.ActiveEditorTracker @self, UnityEditor.DataMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @mode};
            var ___result = RInternal_SetDataMode_ActiveEditorTracker_DataMode.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.Editor MakeCustomEditor(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMakeCustomEditor_Object.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static System.Boolean HasCustomEditor(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RHasCustomEditor_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetupSharedTracker(UnityEditor.ActiveEditorTracker @sharedTracker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sharedTracker};
            var ___result = RSetupSharedTracker_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_OnTrackerRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_OnTrackerRebuild.Invoke(___genericsType, ___parameters);

            
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
