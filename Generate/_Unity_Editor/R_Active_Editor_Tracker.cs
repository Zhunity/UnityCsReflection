
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.ActiveEditorTracker
	/// </summary>
    public partial class RActiveEditorTracker : RMember //
    {

		/// <summary>
		/// System.Action editorTrackerRebuilt
		/// </summary>
		protected static REvent r_EeditorTrackerRebuilt;
		public static REvent REeditorTrackerRebuilt
		{
			get
			{
				if(r_EeditorTrackerRebuilt == null)
				{
					r_EeditorTrackerRebuilt = new(typeof(UnityEditor.ActiveEditorTracker), "editorTrackerRebuilt");
					r_EeditorTrackerRebuilt.SetBelong(null);
				}
				return r_EeditorTrackerRebuilt;
			}
		}

		/// <summary>
		/// UnityEditor.MonoReloadableIntPtrClear m_Property
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RMonoReloadableIntPtrClear r_Fm_Property;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RMonoReloadableIntPtrClear RFm_Property
		{
			get
			{
				if(r_Fm_Property == null)
				{
					r_Fm_Property = new(this, "m_Property");
					r_Fm_Property.SetBelong(this.GetValue());
				}
				return r_Fm_Property;
			}
		}

		/// <summary>
		/// System.Action editorTrackerRebuilt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction r_FeditorTrackerRebuilt;
		public static Hvak.Editor.Refleaction.RSystem.RAction RFeditorTrackerRebuilt
		{
			get
			{
				if(r_FeditorTrackerRebuilt == null)
				{
					r_FeditorTrackerRebuilt = new(typeof(UnityEditor.ActiveEditorTracker), "editorTrackerRebuilt");
					r_FeditorTrackerRebuilt.SetBelong(null);
				}
				return r_FeditorTrackerRebuilt;
			}
		}

		/// <summary>
		/// UnityEditor.Editor[] activeEditors
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.REditor> r_PactiveEditors;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.REditor> RPactiveEditors
		{
			get
			{
				if(r_PactiveEditors == null)
				{
					r_PactiveEditors = new(this, "activeEditors", -1);
					r_PactiveEditors.SetBelong(this.GetValue());
				}
				return r_PactiveEditors;
			}
		}

		/// <summary>
		/// Boolean isDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDirty
		{
			get
			{
				if(r_PisDirty == null)
				{
					r_PisDirty = new(this, "isDirty", -1);
					r_PisDirty.SetBelong(this.GetValue());
				}
				return r_PisDirty;
			}
		}

		/// <summary>
		/// Boolean isLocked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisLocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisLocked
		{
			get
			{
				if(r_PisLocked == null)
				{
					r_PisLocked = new(this, "isLocked", -1);
					r_PisLocked.SetBelong(this.GetValue());
				}
				return r_PisLocked;
			}
		}

		/// <summary>
		/// Boolean hasUnsavedChanges
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasUnsavedChanges;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasUnsavedChanges
		{
			get
			{
				if(r_PhasUnsavedChanges == null)
				{
					r_PhasUnsavedChanges = new(this, "hasUnsavedChanges", -1);
					r_PhasUnsavedChanges.SetBelong(this.GetValue());
				}
				return r_PhasUnsavedChanges;
			}
		}

		/// <summary>
		/// Boolean delayFlushDirtyRebuild
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PdelayFlushDirtyRebuild;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPdelayFlushDirtyRebuild
		{
			get
			{
				if(r_PdelayFlushDirtyRebuild == null)
				{
					r_PdelayFlushDirtyRebuild = new(typeof(UnityEditor.ActiveEditorTracker), "delayFlushDirtyRebuild", -1);
					r_PdelayFlushDirtyRebuild.SetBelong(null);
				}
				return r_PdelayFlushDirtyRebuild;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode inspectorMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode r_PinspectorMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RInspectorMode RPinspectorMode
		{
			get
			{
				if(r_PinspectorMode == null)
				{
					r_PinspectorMode = new(this, "inspectorMode", -1);
					r_PinspectorMode.SetBelong(this.GetValue());
				}
				return r_PinspectorMode;
			}
		}

		/// <summary>
		/// Boolean hasComponentsWhichCannotBeMultiEdited
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasComponentsWhichCannotBeMultiEdited;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasComponentsWhichCannotBeMultiEdited
		{
			get
			{
				if(r_PhasComponentsWhichCannotBeMultiEdited == null)
				{
					r_PhasComponentsWhichCannotBeMultiEdited = new(this, "hasComponentsWhichCannotBeMultiEdited", -1);
					r_PhasComponentsWhichCannotBeMultiEdited.SetBelong(this.GetValue());
				}
				return r_PhasComponentsWhichCannotBeMultiEdited;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode dataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_PdataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RPdataMode
		{
			get
			{
				if(r_PdataMode == null)
				{
					r_PdataMode = new(this, "dataMode", -1);
					r_PdataMode.SetBelong(this.GetValue());
				}
				return r_PdataMode;
			}
		}

		/// <summary>
		/// UnityEditor.ActiveEditorTracker sharedTracker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker r_PsharedTracker;
		public static Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker RPsharedTracker
		{
			get
			{
				if(r_PsharedTracker == null)
				{
					r_PsharedTracker = new(typeof(UnityEditor.ActiveEditorTracker), "sharedTracker", -1);
					r_PsharedTracker.SetBelong(null);
				}
				return r_PsharedTracker;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_Create_ActiveEditorTracker;
		public static RMethod RMInternal_Create_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_Create_ActiveEditorTracker == null)
				{
					r_MInternal_Create_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_Create", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_Create_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_Create_ActiveEditorTracker;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Void Internal_Dispose(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_Dispose_ActiveEditorTracker;
		public static RMethod RMInternal_Dispose_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_Dispose_ActiveEditorTracker == null)
				{
					r_MInternal_Dispose_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_Dispose", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_Dispose_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_Dispose_ActiveEditorTracker;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_Destroy_ActiveEditorTracker;
		public static RMethod RMInternal_Destroy_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_Destroy_ActiveEditorTracker == null)
				{
					r_MInternal_Destroy_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_Destroy", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_Destroy_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_Destroy_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_MDestroy;
		public virtual RMethod RMDestroy
		{
			get
			{
				if(r_MDestroy == null)
				{
					r_MDestroy = new(this, "Destroy", 0);
					r_MDestroy.SetBelong(this.GetValue());
				}
				return r_MDestroy;
			}
		}

		/// <summary>
		/// System.Array Internal_GetActiveEditors(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_GetActiveEditors_ActiveEditorTracker;
		public static RMethod RMInternal_GetActiveEditors_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_GetActiveEditors_ActiveEditorTracker == null)
				{
					r_MInternal_GetActiveEditors_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetActiveEditors", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_GetActiveEditors_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_GetActiveEditors_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_GetActiveEditorsNonAlloc(UnityEditor.ActiveEditorTracker, UnityEditor.Editor[])
		/// </summary>
		protected static RMethod r_MInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray;
		public static RMethod RMInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray
		{
			get
			{
				if(r_MInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray == null)
				{
					r_MInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetActiveEditorsNonAlloc", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(UnityEditor.Editor).MakeArrayType());
					r_MInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray.SetBelong(null);
				}
				return r_MInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray;
			}
		}

		/// <summary>
		/// Void GetObjectsLockedByThisTracker(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_MGetObjectsLockedByThisTracker_List_d_Object_p_;
		public virtual RMethod RMGetObjectsLockedByThisTracker_List_d_Object_p_
		{
			get
			{
				if(r_MGetObjectsLockedByThisTracker_List_d_Object_p_ == null)
				{
					r_MGetObjectsLockedByThisTracker_List_d_Object_p_ = new(this, "GetObjectsLockedByThisTracker", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_MGetObjectsLockedByThisTracker_List_d_Object_p_.SetBelong(this.GetValue());
				}
				return r_MGetObjectsLockedByThisTracker_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void Internal_GetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker, System.Object)
		/// </summary>
		protected static RMethod r_MInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
		public static RMethod RMInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object
		{
			get
			{
				if(r_MInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object == null)
				{
					r_MInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetObjectsLockedByThisTrackerInternal", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Object));
					r_MInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.SetBelong(null);
				}
				return r_MInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
			}
		}

		/// <summary>
		/// Void GetObjectsLockedByThisTrackerInternal(System.Object)
		/// </summary>
		protected RMethod r_MGetObjectsLockedByThisTrackerInternal_Object;
		public virtual RMethod RMGetObjectsLockedByThisTrackerInternal_Object
		{
			get
			{
				if(r_MGetObjectsLockedByThisTrackerInternal_Object == null)
				{
					r_MGetObjectsLockedByThisTrackerInternal_Object = new(this, "GetObjectsLockedByThisTrackerInternal", 0, typeof(System.Object));
					r_MGetObjectsLockedByThisTrackerInternal_Object.SetBelong(this.GetValue());
				}
				return r_MGetObjectsLockedByThisTrackerInternal_Object;
			}
		}

		/// <summary>
		/// Void SetObjectsLockedByThisTracker(System.Collections.Generic.List`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_MSetObjectsLockedByThisTracker_List_d_Object_p_;
		public virtual RMethod RMSetObjectsLockedByThisTracker_List_d_Object_p_
		{
			get
			{
				if(r_MSetObjectsLockedByThisTracker_List_d_Object_p_ == null)
				{
					r_MSetObjectsLockedByThisTracker_List_d_Object_p_ = new(this, "SetObjectsLockedByThisTracker", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_MSetObjectsLockedByThisTracker_List_d_Object_p_.SetBelong(this.GetValue());
				}
				return r_MSetObjectsLockedByThisTracker_List_d_Object_p_;
			}
		}

		/// <summary>
		/// Void Internal_SetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker, System.Object)
		/// </summary>
		protected static RMethod r_MInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
		public static RMethod RMInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object
		{
			get
			{
				if(r_MInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object == null)
				{
					r_MInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetObjectsLockedByThisTrackerInternal", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Object));
					r_MInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.SetBelong(null);
				}
				return r_MInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object;
			}
		}

		/// <summary>
		/// Void SetObjectsLockedByThisTrackerInternal(System.Object)
		/// </summary>
		protected RMethod r_MSetObjectsLockedByThisTrackerInternal_Object;
		public virtual RMethod RMSetObjectsLockedByThisTrackerInternal_Object
		{
			get
			{
				if(r_MSetObjectsLockedByThisTrackerInternal_Object == null)
				{
					r_MSetObjectsLockedByThisTrackerInternal_Object = new(this, "SetObjectsLockedByThisTrackerInternal", 0, typeof(System.Object));
					r_MSetObjectsLockedByThisTrackerInternal_Object.SetBelong(this.GetValue());
				}
				return r_MSetObjectsLockedByThisTrackerInternal_Object;
			}
		}

		/// <summary>
		/// Int32 Internal_GetVisible(UnityEditor.ActiveEditorTracker, Int32)
		/// </summary>
		protected static RMethod r_MInternal_GetVisible_ActiveEditorTracker_Int32;
		public static RMethod RMInternal_GetVisible_ActiveEditorTracker_Int32
		{
			get
			{
				if(r_MInternal_GetVisible_ActiveEditorTracker_Int32 == null)
				{
					r_MInternal_GetVisible_ActiveEditorTracker_Int32 = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetVisible", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Int32));
					r_MInternal_GetVisible_ActiveEditorTracker_Int32.SetBelong(null);
				}
				return r_MInternal_GetVisible_ActiveEditorTracker_Int32;
			}
		}

		/// <summary>
		/// Int32 GetVisible(Int32)
		/// </summary>
		protected RMethod r_MGetVisible_Int32;
		public virtual RMethod RMGetVisible_Int32
		{
			get
			{
				if(r_MGetVisible_Int32 == null)
				{
					r_MGetVisible_Int32 = new(this, "GetVisible", 0, typeof(System.Int32));
					r_MGetVisible_Int32.SetBelong(this.GetValue());
				}
				return r_MGetVisible_Int32;
			}
		}

		/// <summary>
		/// Void Internal_SetVisible(UnityEditor.ActiveEditorTracker, Int32, Int32)
		/// </summary>
		protected static RMethod r_MInternal_SetVisible_ActiveEditorTracker_Int32_Int32;
		public static RMethod RMInternal_SetVisible_ActiveEditorTracker_Int32_Int32
		{
			get
			{
				if(r_MInternal_SetVisible_ActiveEditorTracker_Int32_Int32 == null)
				{
					r_MInternal_SetVisible_ActiveEditorTracker_Int32_Int32 = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetVisible", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Int32), typeof(System.Int32));
					r_MInternal_SetVisible_ActiveEditorTracker_Int32_Int32.SetBelong(null);
				}
				return r_MInternal_SetVisible_ActiveEditorTracker_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVisible(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetVisible_Int32_Int32;
		public virtual RMethod RMSetVisible_Int32_Int32
		{
			get
			{
				if(r_MSetVisible_Int32_Int32 == null)
				{
					r_MSetVisible_Int32_Int32 = new(this, "SetVisible", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetVisible_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetVisible_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Internal_GetIsDirty(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_GetIsDirty_ActiveEditorTracker;
		public static RMethod RMInternal_GetIsDirty_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_GetIsDirty_ActiveEditorTracker == null)
				{
					r_MInternal_GetIsDirty_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetIsDirty", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_GetIsDirty_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_GetIsDirty_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_ClearDirty(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_ClearDirty_ActiveEditorTracker;
		public static RMethod RMInternal_ClearDirty_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_ClearDirty_ActiveEditorTracker == null)
				{
					r_MInternal_ClearDirty_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_ClearDirty", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_ClearDirty_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_ClearDirty_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void ClearDirty()
		/// </summary>
		protected RMethod r_MClearDirty;
		public virtual RMethod RMClearDirty
		{
			get
			{
				if(r_MClearDirty == null)
				{
					r_MClearDirty = new(this, "ClearDirty", 0);
					r_MClearDirty.SetBelong(this.GetValue());
				}
				return r_MClearDirty;
			}
		}

		/// <summary>
		/// Boolean Internal_GetIsLocked(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_GetIsLocked_ActiveEditorTracker;
		public static RMethod RMInternal_GetIsLocked_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_GetIsLocked_ActiveEditorTracker == null)
				{
					r_MInternal_GetIsLocked_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetIsLocked", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_GetIsLocked_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_GetIsLocked_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_SetIsLocked(UnityEditor.ActiveEditorTracker, Boolean)
		/// </summary>
		protected static RMethod r_MInternal_SetIsLocked_ActiveEditorTracker_Boolean;
		public static RMethod RMInternal_SetIsLocked_ActiveEditorTracker_Boolean
		{
			get
			{
				if(r_MInternal_SetIsLocked_ActiveEditorTracker_Boolean == null)
				{
					r_MInternal_SetIsLocked_ActiveEditorTracker_Boolean = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetIsLocked", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Boolean));
					r_MInternal_SetIsLocked_ActiveEditorTracker_Boolean.SetBelong(null);
				}
				return r_MInternal_SetIsLocked_ActiveEditorTracker_Boolean;
			}
		}

		/// <summary>
		/// Boolean Internal_HasUnsavedChanges(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_HasUnsavedChanges_ActiveEditorTracker;
		public static RMethod RMInternal_HasUnsavedChanges_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_HasUnsavedChanges_ActiveEditorTracker == null)
				{
					r_MInternal_HasUnsavedChanges_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_HasUnsavedChanges", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_HasUnsavedChanges_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_HasUnsavedChanges_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_UnsavedChangesStateChanged(UnityEditor.ActiveEditorTracker, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean;
		public static RMethod RMInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean
		{
			get
			{
				if(r_MInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean == null)
				{
					r_MInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_UnsavedChangesStateChanged", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(System.Int32), typeof(System.Boolean));
					r_MInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean.SetBelong(null);
				}
				return r_MInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void UnsavedChangesStateChanged(UnityEditor.Editor, Boolean)
		/// </summary>
		protected RMethod r_MUnsavedChangesStateChanged_Editor_Boolean;
		public virtual RMethod RMUnsavedChangesStateChanged_Editor_Boolean
		{
			get
			{
				if(r_MUnsavedChangesStateChanged_Editor_Boolean == null)
				{
					r_MUnsavedChangesStateChanged_Editor_Boolean = new(this, "UnsavedChangesStateChanged", 0, typeof(UnityEditor.Editor), typeof(System.Boolean));
					r_MUnsavedChangesStateChanged_Editor_Boolean.SetBelong(this.GetValue());
				}
				return r_MUnsavedChangesStateChanged_Editor_Boolean;
			}
		}

		/// <summary>
		/// Boolean Internal_GetDelayFlushDirtyRebuild()
		/// </summary>
		protected static RMethod r_MInternal_GetDelayFlushDirtyRebuild;
		public static RMethod RMInternal_GetDelayFlushDirtyRebuild
		{
			get
			{
				if(r_MInternal_GetDelayFlushDirtyRebuild == null)
				{
					r_MInternal_GetDelayFlushDirtyRebuild = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetDelayFlushDirtyRebuild", 0);
					r_MInternal_GetDelayFlushDirtyRebuild.SetBelong(null);
				}
				return r_MInternal_GetDelayFlushDirtyRebuild;
			}
		}

		/// <summary>
		/// Void Internal_SetDelayFlushDirtyRebuild(Boolean)
		/// </summary>
		protected static RMethod r_MInternal_SetDelayFlushDirtyRebuild_Boolean;
		public static RMethod RMInternal_SetDelayFlushDirtyRebuild_Boolean
		{
			get
			{
				if(r_MInternal_SetDelayFlushDirtyRebuild_Boolean == null)
				{
					r_MInternal_SetDelayFlushDirtyRebuild_Boolean = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetDelayFlushDirtyRebuild", 0, typeof(System.Boolean));
					r_MInternal_SetDelayFlushDirtyRebuild_Boolean.SetBelong(null);
				}
				return r_MInternal_SetDelayFlushDirtyRebuild_Boolean;
			}
		}

		/// <summary>
		/// UnityEditor.InspectorMode Internal_GetInspectorMode(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_GetInspectorMode_ActiveEditorTracker;
		public static RMethod RMInternal_GetInspectorMode_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_GetInspectorMode_ActiveEditorTracker == null)
				{
					r_MInternal_GetInspectorMode_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetInspectorMode", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_GetInspectorMode_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_GetInspectorMode_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_SetInspectorMode(UnityEditor.ActiveEditorTracker, UnityEditor.InspectorMode)
		/// </summary>
		protected static RMethod r_MInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode;
		public static RMethod RMInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode
		{
			get
			{
				if(r_MInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode == null)
				{
					r_MInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetInspectorMode", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(UnityEditor.InspectorMode));
					r_MInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode.SetBelong(null);
				}
				return r_MInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode;
			}
		}

		/// <summary>
		/// Boolean Internal_GetHasComponentsWhichCannotBeMultiEdited(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker;
		public static RMethod RMInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker == null)
				{
					r_MInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetHasComponentsWhichCannotBeMultiEdited", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_RebuildIfNecessary(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_RebuildIfNecessary_ActiveEditorTracker;
		public static RMethod RMInternal_RebuildIfNecessary_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_RebuildIfNecessary_ActiveEditorTracker == null)
				{
					r_MInternal_RebuildIfNecessary_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_RebuildIfNecessary", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_RebuildIfNecessary_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_RebuildIfNecessary_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void RebuildIfNecessary()
		/// </summary>
		protected RMethod r_MRebuildIfNecessary;
		public virtual RMethod RMRebuildIfNecessary
		{
			get
			{
				if(r_MRebuildIfNecessary == null)
				{
					r_MRebuildIfNecessary = new(this, "RebuildIfNecessary", 0);
					r_MRebuildIfNecessary.SetBelong(this.GetValue());
				}
				return r_MRebuildIfNecessary;
			}
		}

		/// <summary>
		/// Void Internal_RebuildAllIfNecessary()
		/// </summary>
		protected static RMethod r_MInternal_RebuildAllIfNecessary;
		public static RMethod RMInternal_RebuildAllIfNecessary
		{
			get
			{
				if(r_MInternal_RebuildAllIfNecessary == null)
				{
					r_MInternal_RebuildAllIfNecessary = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_RebuildAllIfNecessary", 0);
					r_MInternal_RebuildAllIfNecessary.SetBelong(null);
				}
				return r_MInternal_RebuildAllIfNecessary;
			}
		}

		/// <summary>
		/// Void RebuildAllIfNecessary()
		/// </summary>
		protected static RMethod r_MRebuildAllIfNecessary;
		public static RMethod RMRebuildAllIfNecessary
		{
			get
			{
				if(r_MRebuildAllIfNecessary == null)
				{
					r_MRebuildAllIfNecessary = new(typeof(UnityEditor.ActiveEditorTracker), "RebuildAllIfNecessary", 0);
					r_MRebuildAllIfNecessary.SetBelong(null);
				}
				return r_MRebuildAllIfNecessary;
			}
		}

		/// <summary>
		/// Void Internal_ForceRebuild(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_ForceRebuild_ActiveEditorTracker;
		public static RMethod RMInternal_ForceRebuild_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_ForceRebuild_ActiveEditorTracker == null)
				{
					r_MInternal_ForceRebuild_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_ForceRebuild", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_ForceRebuild_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_ForceRebuild_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void ForceRebuild()
		/// </summary>
		protected RMethod r_MForceRebuild;
		public virtual RMethod RMForceRebuild
		{
			get
			{
				if(r_MForceRebuild == null)
				{
					r_MForceRebuild = new(this, "ForceRebuild", 0);
					r_MForceRebuild.SetBelong(this.GetValue());
				}
				return r_MForceRebuild;
			}
		}

		/// <summary>
		/// Void Internal_VerifyModifiedMonoBehaviours(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker;
		public static RMethod RMInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker == null)
				{
					r_MInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_VerifyModifiedMonoBehaviours", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void VerifyModifiedMonoBehaviours()
		/// </summary>
		protected RMethod r_MVerifyModifiedMonoBehaviours;
		public virtual RMethod RMVerifyModifiedMonoBehaviours
		{
			get
			{
				if(r_MVerifyModifiedMonoBehaviours == null)
				{
					r_MVerifyModifiedMonoBehaviours = new(this, "VerifyModifiedMonoBehaviours", 0);
					r_MVerifyModifiedMonoBehaviours.SetBelong(this.GetValue());
				}
				return r_MVerifyModifiedMonoBehaviours;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode Internal_GetDataMode(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MInternal_GetDataMode_ActiveEditorTracker;
		public static RMethod RMInternal_GetDataMode_ActiveEditorTracker
		{
			get
			{
				if(r_MInternal_GetDataMode_ActiveEditorTracker == null)
				{
					r_MInternal_GetDataMode_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_GetDataMode", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MInternal_GetDataMode_ActiveEditorTracker.SetBelong(null);
				}
				return r_MInternal_GetDataMode_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_SetDataMode(UnityEditor.ActiveEditorTracker, UnityEditor.DataMode)
		/// </summary>
		protected static RMethod r_MInternal_SetDataMode_ActiveEditorTracker_DataMode;
		public static RMethod RMInternal_SetDataMode_ActiveEditorTracker_DataMode
		{
			get
			{
				if(r_MInternal_SetDataMode_ActiveEditorTracker_DataMode == null)
				{
					r_MInternal_SetDataMode_ActiveEditorTracker_DataMode = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_SetDataMode", 0, typeof(UnityEditor.ActiveEditorTracker), typeof(UnityEditor.DataMode));
					r_MInternal_SetDataMode_ActiveEditorTracker_DataMode.SetBelong(null);
				}
				return r_MInternal_SetDataMode_ActiveEditorTracker_DataMode;
			}
		}

		/// <summary>
		/// UnityEditor.Editor MakeCustomEditor(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MMakeCustomEditor_Object;
		public static RMethod RMMakeCustomEditor_Object
		{
			get
			{
				if(r_MMakeCustomEditor_Object == null)
				{
					r_MMakeCustomEditor_Object = new(typeof(UnityEditor.ActiveEditorTracker), "MakeCustomEditor", 0, typeof(UnityEngine.Object));
					r_MMakeCustomEditor_Object.SetBelong(null);
				}
				return r_MMakeCustomEditor_Object;
			}
		}

		/// <summary>
		/// Boolean HasCustomEditor(UnityEngine.Object)
		/// </summary>
		protected static RMethod r_MHasCustomEditor_Object;
		public static RMethod RMHasCustomEditor_Object
		{
			get
			{
				if(r_MHasCustomEditor_Object == null)
				{
					r_MHasCustomEditor_Object = new(typeof(UnityEditor.ActiveEditorTracker), "HasCustomEditor", 0, typeof(UnityEngine.Object));
					r_MHasCustomEditor_Object.SetBelong(null);
				}
				return r_MHasCustomEditor_Object;
			}
		}

		/// <summary>
		/// Void SetupSharedTracker(UnityEditor.ActiveEditorTracker)
		/// </summary>
		protected static RMethod r_MSetupSharedTracker_ActiveEditorTracker;
		public static RMethod RMSetupSharedTracker_ActiveEditorTracker
		{
			get
			{
				if(r_MSetupSharedTracker_ActiveEditorTracker == null)
				{
					r_MSetupSharedTracker_ActiveEditorTracker = new(typeof(UnityEditor.ActiveEditorTracker), "SetupSharedTracker", 0, typeof(UnityEditor.ActiveEditorTracker));
					r_MSetupSharedTracker_ActiveEditorTracker.SetBelong(null);
				}
				return r_MSetupSharedTracker_ActiveEditorTracker;
			}
		}

		/// <summary>
		/// Void Internal_OnTrackerRebuild()
		/// </summary>
		protected static RMethod r_MInternal_OnTrackerRebuild;
		public static RMethod RMInternal_OnTrackerRebuild
		{
			get
			{
				if(r_MInternal_OnTrackerRebuild == null)
				{
					r_MInternal_OnTrackerRebuild = new(typeof(UnityEditor.ActiveEditorTracker), "Internal_OnTrackerRebuild", 0);
					r_MInternal_OnTrackerRebuild.SetBelong(null);
				}
				return r_MInternal_OnTrackerRebuild;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMInternal_Create_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Internal_Dispose(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_Dispose_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Destroy(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_Destroy_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Array Internal_GetActiveEditors(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_GetActiveEditors_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public static void Internal_GetActiveEditorsNonAlloc(UnityEditor.ActiveEditorTracker @self, UnityEditor.Editor[] @editors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @editors};
            var ___result = RMInternal_GetActiveEditorsNonAlloc_ActiveEditorTracker_EditorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectsLockedByThisTracker(System.Collections.Generic.List<UnityEngine.Object> @lockedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockedObjects};
            var ___result = RMGetObjectsLockedByThisTracker_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_GetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker @self, System.Object @lockedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @lockedObjects};
            var ___result = RMInternal_GetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectsLockedByThisTrackerInternal(System.Object @lockedObjects)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lockedObjects};
            var ___result = RMGetObjectsLockedByThisTrackerInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetObjectsLockedByThisTracker(System.Collections.Generic.List<UnityEngine.Object> @toBeLocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toBeLocked};
            var ___result = RMSetObjectsLockedByThisTracker_List_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_SetObjectsLockedByThisTrackerInternal(UnityEditor.ActiveEditorTracker @self, System.Object @toBeLocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @toBeLocked};
            var ___result = RMInternal_SetObjectsLockedByThisTrackerInternal_ActiveEditorTracker_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetObjectsLockedByThisTrackerInternal(System.Object @toBeLocked)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@toBeLocked};
            var ___result = RMSetObjectsLockedByThisTrackerInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 Internal_GetVisible(UnityEditor.ActiveEditorTracker @self, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index};
            var ___result = RMInternal_GetVisible_ActiveEditorTracker_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetVisible(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetVisible_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Internal_SetVisible(UnityEditor.ActiveEditorTracker @self, System.Int32 @index, System.Int32 @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @index, @visible};
            var ___result = RMInternal_SetVisible_ActiveEditorTracker_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVisible(System.Int32 @index, System.Int32 @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @visible};
            var ___result = RMSetVisible_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetIsDirty(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_GetIsDirty_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_ClearDirty(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_ClearDirty_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearDirty.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetIsLocked(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_GetIsLocked_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_SetIsLocked(UnityEditor.ActiveEditorTracker @self, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @value};
            var ___result = RMInternal_SetIsLocked_ActiveEditorTracker_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_HasUnsavedChanges(UnityEditor.ActiveEditorTracker @activeEditorTracker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@activeEditorTracker};
            var ___result = RMInternal_HasUnsavedChanges_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_UnsavedChangesStateChanged(UnityEditor.ActiveEditorTracker @self, System.Int32 @editorInstance, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @editorInstance, @value};
            var ___result = RMInternal_UnsavedChangesStateChanged_ActiveEditorTracker_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsavedChangesStateChanged(UnityEditor.Editor @editor, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @value};
            var ___result = RMUnsavedChangesStateChanged_Editor_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetDelayFlushDirtyRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_GetDelayFlushDirtyRebuild.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_SetDelayFlushDirtyRebuild(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMInternal_SetDelayFlushDirtyRebuild_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.InspectorMode Internal_GetInspectorMode(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_GetInspectorMode_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (UnityEditor.InspectorMode)___result;
        }


        public static void Internal_SetInspectorMode(UnityEditor.ActiveEditorTracker @self, UnityEditor.InspectorMode @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @value};
            var ___result = RMInternal_SetInspectorMode_ActiveEditorTracker_InspectorMode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_GetHasComponentsWhichCannotBeMultiEdited(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_GetHasComponentsWhichCannotBeMultiEdited_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_RebuildIfNecessary(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_RebuildIfNecessary_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RebuildIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuildIfNecessary.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_RebuildAllIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_RebuildAllIfNecessary.Invoke(___genericsType, ___parameters);

            
        }


        public static void RebuildAllIfNecessary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRebuildAllIfNecessary.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_ForceRebuild(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_ForceRebuild_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ForceRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMForceRebuild.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_VerifyModifiedMonoBehaviours(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_VerifyModifiedMonoBehaviours_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void VerifyModifiedMonoBehaviours()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMVerifyModifiedMonoBehaviours.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.DataMode Internal_GetDataMode(UnityEditor.ActiveEditorTracker @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RMInternal_GetDataMode_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            return (UnityEditor.DataMode)___result;
        }


        public static void Internal_SetDataMode(UnityEditor.ActiveEditorTracker @self, UnityEditor.DataMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @mode};
            var ___result = RMInternal_SetDataMode_ActiveEditorTracker_DataMode.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEditor.Editor MakeCustomEditor(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMMakeCustomEditor_Object.Invoke(___genericsType, ___parameters);

            return (UnityEditor.Editor)___result;
        }


        public static System.Boolean HasCustomEditor(UnityEngine.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMHasCustomEditor_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void SetupSharedTracker(UnityEditor.ActiveEditorTracker @sharedTracker)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sharedTracker};
            var ___result = RMSetupSharedTracker_ActiveEditorTracker.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_OnTrackerRebuild()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_OnTrackerRebuild.Invoke(___genericsType, ___parameters);

            
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
