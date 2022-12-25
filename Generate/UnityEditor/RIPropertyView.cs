using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IPropertyView
	/// </summary>
    public partial class RIPropertyView : RMember //
    {

		/// <summary>
		/// UnityEditor.ActiveEditorTracker tracker
		/// </summary>
		protected RUnityEditor.RActiveEditorTracker r_tracker;
		public virtual RUnityEditor.RActiveEditorTracker Rtracker
		{
			get
			{
				if(r_tracker == null)
				{
					r_tracker = new(this, "tracker", -1);
					r_tracker.SetBelong(this.instance);
				}
				return r_tracker;
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
		/// System.Collections.Generic.HashSet`1[System.Int32] editorsWithImportedObjectLabel
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RProperty> r_editorsWithImportedObjectLabel;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RProperty> ReditorsWithImportedObjectLabel
		{
			get
			{
				if(r_editorsWithImportedObjectLabel == null)
				{
					r_editorsWithImportedObjectLabel = new(this, "editorsWithImportedObjectLabel", -1);
					r_editorsWithImportedObjectLabel.SetBelong(this.instance);
				}
				return r_editorsWithImportedObjectLabel;
			}
		}

		/// <summary>
		/// UnityEditor.Editor lastInteractedEditor
		/// </summary>
		protected RUnityEditor.REditor r_lastInteractedEditor;
		public virtual RUnityEditor.REditor RlastInteractedEditor
		{
			get
			{
				if(r_lastInteractedEditor == null)
				{
					r_lastInteractedEditor = new(this, "lastInteractedEditor", -1);
					r_lastInteractedEditor.SetBelong(this.instance);
				}
				return r_lastInteractedEditor;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView parent
		/// </summary>
		protected RUnityEditor.RGUIView r_parent;
		public virtual RUnityEditor.RGUIView Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// UnityEditor.EditorDragging editorDragging
		/// </summary>
		protected RUnityEditor.REditorDragging r_editorDragging;
		public virtual RUnityEditor.REditorDragging ReditorDragging
		{
			get
			{
				if(r_editorDragging == null)
				{
					r_editorDragging = new(this, "editorDragging", -1);
					r_editorDragging.SetBelong(this.instance);
				}
				return r_editorDragging;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action, System.String)
		/// </summary>
		protected RMethod r_RCreateIMGUIContainer_Action_String;
		public virtual RMethod RCreateIMGUIContainer_Action_String
		{
			get
			{
				if(r_RCreateIMGUIContainer_Action_String == null)
				{
					r_RCreateIMGUIContainer_Action_String = new(this, "CreateIMGUIContainer", 0, typeof(System.Action), typeof(System.String));
					r_RCreateIMGUIContainer_Action_String.SetBelong(this.instance);
				}
				return r_RCreateIMGUIContainer_Action_String;
			}
		}

		/// <summary>
		/// Boolean WasEditorVisible(UnityEditor.Editor[], Int32, UnityEngine.Object)
		/// </summary>
		protected RMethod r_RWasEditorVisible_EditorArray_Int32_Object;
		public virtual RMethod RWasEditorVisible_EditorArray_Int32_Object
		{
			get
			{
				if(r_RWasEditorVisible_EditorArray_Int32_Object == null)
				{
					r_RWasEditorVisible_EditorArray_Int32_Object = new(this, "WasEditorVisible", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Object));
					r_RWasEditorVisible_EditorArray_Int32_Object.SetBelong(this.instance);
				}
				return r_RWasEditorVisible_EditorArray_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean ShouldCullEditor(UnityEditor.Editor[], Int32)
		/// </summary>
		protected RMethod r_RShouldCullEditor_EditorArray_Int32;
		public virtual RMethod RShouldCullEditor_EditorArray_Int32
		{
			get
			{
				if(r_RShouldCullEditor_EditorArray_Int32 == null)
				{
					r_RShouldCullEditor_EditorArray_Int32 = new(this, "ShouldCullEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32));
					r_RShouldCullEditor_EditorArray_Int32.SetBelong(this.instance);
				}
				return r_RShouldCullEditor_EditorArray_Int32;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_RRepaint;
		public virtual RMethod RRepaint
		{
			get
			{
				if(r_RRepaint == null)
				{
					r_RRepaint = new(this, "Repaint", 0);
					r_RRepaint.SetBelong(this.instance);
				}
				return r_RRepaint;
			}
		}

		/// <summary>
		/// Void UnsavedChangesStateChanged(UnityEditor.Editor, Boolean)
		/// </summary>
		protected RMethod r_RUnsavedChangesStateChanged_Editor_Boolean;
		public virtual RMethod RUnsavedChangesStateChanged_Editor_Boolean
		{
			get
			{
				if(r_RUnsavedChangesStateChanged_Editor_Boolean == null)
				{
					r_RUnsavedChangesStateChanged_Editor_Boolean = new(this, "UnsavedChangesStateChanged", 0, typeof(UnityEditor.Editor), typeof(System.Boolean));
					r_RUnsavedChangesStateChanged_Editor_Boolean.SetBelong(this.instance);
				}
				return r_RUnsavedChangesStateChanged_Editor_Boolean;
			}
		}


        public RIPropertyView() : base("UnityEditor.IPropertyView")
        {
        }

        public RIPropertyView(System.Object instance) : base("UnityEditor.IPropertyView")
		{
            SetInstance(instance);
		}

        public RIPropertyView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPropertyView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action  @headerOnGUI, System.String  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headerOnGUI, @v};
            var ___result = RCreateIMGUIContainer_Action_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IMGUIContainer)___result;
        }


        public virtual System.Boolean WasEditorVisible(UnityEditor.Editor[]  @editors, System.Int32  @editorIndex, UnityEngine.Object  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @target};
            var ___result = RWasEditorVisible_EditorArray_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldCullEditor(UnityEditor.Editor[]  @editors, System.Int32  @editorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex};
            var ___result = RShouldCullEditor_EditorArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsavedChangesStateChanged(UnityEditor.Editor  @editor, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @value};
            var ___result = RUnsavedChangesStateChanged_Editor_Boolean.Invoke(___genericsType, ___parameters);

            
        }


    }
}
