
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IPropertyView
	/// </summary>
    public partial class RIPropertyView : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IPropertyView");
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


		/// <summary>
		/// UnityEditor.ActiveEditorTracker tracker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker r_Ptracker;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RActiveEditorTracker RPtracker
		{
			get
			{
				if(r_Ptracker == null)
				{
					r_Ptracker = new(this, "tracker", -1);
				}
				return r_Ptracker;
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
				}
				return r_PinspectorMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] editorsWithImportedObjectLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_PeditorsWithImportedObjectLabel;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RPeditorsWithImportedObjectLabel
		{
			get
			{
				if(r_PeditorsWithImportedObjectLabel == null)
				{
					r_PeditorsWithImportedObjectLabel = new(this, "editorsWithImportedObjectLabel", -1);
				}
				return r_PeditorsWithImportedObjectLabel;
			}
		}

		/// <summary>
		/// UnityEditor.Editor lastInteractedEditor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditor r_PlastInteractedEditor;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditor RPlastInteractedEditor
		{
			get
			{
				if(r_PlastInteractedEditor == null)
				{
					r_PlastInteractedEditor = new(this, "lastInteractedEditor", -1);
				}
				return r_PlastInteractedEditor;
			}
		}

		/// <summary>
		/// UnityEditor.GUIView parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RGUIView r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RGUIView RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEditor.EditorDragging editorDragging
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.REditorDragging r_PeditorDragging;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.REditorDragging RPeditorDragging
		{
			get
			{
				if(r_PeditorDragging == null)
				{
					r_PeditorDragging = new(this, "editorDragging", -1);
				}
				return r_PeditorDragging;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action, System.String)
		/// </summary>
		protected RMethod r_MCreateIMGUIContainer_Action_String;
		public virtual RMethod RMCreateIMGUIContainer_Action_String
		{
			get
			{
				if(r_MCreateIMGUIContainer_Action_String == null)
				{
					r_MCreateIMGUIContainer_Action_String = new(this, "CreateIMGUIContainer", 0, typeof(System.Action), typeof(System.String));
				}
				return r_MCreateIMGUIContainer_Action_String;
			}
		}

		/// <summary>
		/// Boolean WasEditorVisible(UnityEditor.Editor[], Int32, UnityEngine.Object)
		/// </summary>
		protected RMethod r_MWasEditorVisible_EditorArray_Int32_Object;
		public virtual RMethod RMWasEditorVisible_EditorArray_Int32_Object
		{
			get
			{
				if(r_MWasEditorVisible_EditorArray_Int32_Object == null)
				{
					r_MWasEditorVisible_EditorArray_Int32_Object = new(this, "WasEditorVisible", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Object));
				}
				return r_MWasEditorVisible_EditorArray_Int32_Object;
			}
		}

		/// <summary>
		/// Boolean ShouldCullEditor(UnityEditor.Editor[], Int32)
		/// </summary>
		protected RMethod r_MShouldCullEditor_EditorArray_Int32;
		public virtual RMethod RMShouldCullEditor_EditorArray_Int32
		{
			get
			{
				if(r_MShouldCullEditor_EditorArray_Int32 == null)
				{
					r_MShouldCullEditor_EditorArray_Int32 = new(this, "ShouldCullEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32));
				}
				return r_MShouldCullEditor_EditorArray_Int32;
			}
		}

		/// <summary>
		/// Void Repaint()
		/// </summary>
		protected RMethod r_MRepaint;
		public virtual RMethod RMRepaint
		{
			get
			{
				if(r_MRepaint == null)
				{
					r_MRepaint = new(this, "Repaint", 0);
				}
				return r_MRepaint;
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
				}
				return r_MUnsavedChangesStateChanged_Editor_Boolean;
			}
		}


        public virtual UnityEngine.UIElements.IMGUIContainer CreateIMGUIContainer(System.Action @headerOnGUI, System.String @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@headerOnGUI, @v};
            var ___result = RMCreateIMGUIContainer_Action_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IMGUIContainer)___result;
        }


        public virtual System.Boolean WasEditorVisible(UnityEditor.Editor[] @editors, System.Int32 @editorIndex, UnityEngine.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @target};
            var ___result = RMWasEditorVisible_EditorArray_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldCullEditor(UnityEditor.Editor[] @editors, System.Int32 @editorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex};
            var ___result = RMShouldCullEditor_EditorArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Repaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsavedChangesStateChanged(UnityEditor.Editor @editor, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editor, @value};
            var ___result = RMUnsavedChangesStateChanged_Editor_Boolean.Invoke(___genericsType, ___parameters);

            
        }


    }
}
