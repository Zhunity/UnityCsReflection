
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.EditorDragging
	/// </summary>
    public partial class REditorDragging : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.EditorDragging");
            }
        }

        public REditorDragging() : base("UnityEditor.EditorDragging")
        {
        }

        public REditorDragging(System.Object instance) : base("UnityEditor.EditorDragging")
		{
            SetInstance(instance);
		}

        public REditorDragging(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REditorDragging(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String k_DraggingModeKey
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_DraggingModeKey;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_DraggingModeKey
		{
			get
			{
				if(r_Fk_DraggingModeKey == null)
				{
					r_Fk_DraggingModeKey = new(Type, "k_DraggingModeKey");
				}
				return r_Fk_DraggingModeKey;
			}
		}

		/// <summary>
		/// UnityEditor.IPropertyView m_InspectorWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RIPropertyView r_Fm_InspectorWindow;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RIPropertyView RFm_InspectorWindow
		{
			get
			{
				if(r_Fm_InspectorWindow == null)
				{
					r_Fm_InspectorWindow = new(this, "m_InspectorWindow");
				}
				return r_Fm_InspectorWindow;
			}
		}

		/// <summary>
		/// System.Boolean m_TargetAbove
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_TargetAbove;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_TargetAbove
		{
			get
			{
				if(r_Fm_TargetAbove == null)
				{
					r_Fm_TargetAbove = new(this, "m_TargetAbove");
				}
				return r_Fm_TargetAbove;
			}
		}

		/// <summary>
		/// System.Int32 m_TargetIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_TargetIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_TargetIndex
		{
			get
			{
				if(r_Fm_TargetIndex == null)
				{
					r_Fm_TargetIndex = new(this, "m_TargetIndex");
				}
				return r_Fm_TargetIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_LastIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_LastIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_LastIndex
		{
			get
			{
				if(r_Fm_LastIndex == null)
				{
					r_Fm_LastIndex = new(this, "m_LastIndex");
				}
				return r_Fm_LastIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_BottomAreaDropIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_BottomAreaDropIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_BottomAreaDropIndex
		{
			get
			{
				if(r_Fm_BottomAreaDropIndex == null)
				{
					r_Fm_BottomAreaDropIndex = new(this, "m_BottomAreaDropIndex");
				}
				return r_Fm_BottomAreaDropIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_BottomArea
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_BottomArea;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_BottomArea
		{
			get
			{
				if(r_Fm_BottomArea == null)
				{
					r_Fm_BottomArea = new(this, "m_BottomArea");
				}
				return r_Fm_BottomArea;
			}
		}

		/// <summary>
		/// Void HandleDraggingToEditor(UnityEditor.Editor[], Int32, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MHandleDraggingToEditor_EditorArray_Int32_Rect_Rect;
		public virtual RMethod RMHandleDraggingToEditor_EditorArray_Int32_Rect_Rect
		{
			get
			{
				if(r_MHandleDraggingToEditor_EditorArray_Int32_Rect_Rect == null)
				{
					r_MHandleDraggingToEditor_EditorArray_Int32_Rect_Rect = new(this, "HandleDraggingToEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
				}
				return r_MHandleDraggingToEditor_EditorArray_Int32_Rect_Rect;
			}
		}

		/// <summary>
		/// Void HandleDraggingInBottomArea(UnityEditor.Editor[], UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MHandleDraggingInBottomArea_EditorArray_Rect_Rect;
		public virtual RMethod RMHandleDraggingInBottomArea_EditorArray_Rect_Rect
		{
			get
			{
				if(r_MHandleDraggingInBottomArea_EditorArray_Rect_Rect == null)
				{
					r_MHandleDraggingInBottomArea_EditorArray_Rect_Rect = new(this, "HandleDraggingInBottomArea", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
				}
				return r_MHandleDraggingInBottomArea_EditorArray_Rect_Rect;
			}
		}

		/// <summary>
		/// Void HandleDragPerformInBottomArea(UnityEditor.Editor[], UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MHandleDragPerformInBottomArea_EditorArray_Rect_Rect;
		public virtual RMethod RMHandleDragPerformInBottomArea_EditorArray_Rect_Rect
		{
			get
			{
				if(r_MHandleDragPerformInBottomArea_EditorArray_Rect_Rect == null)
				{
					r_MHandleDragPerformInBottomArea_EditorArray_Rect_Rect = new(this, "HandleDragPerformInBottomArea", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
				}
				return r_MHandleDragPerformInBottomArea_EditorArray_Rect_Rect;
			}
		}

		/// <summary>
		/// Void HandleNativeDragDropInBottomArea(UnityEditor.Editor[], UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MHandleNativeDragDropInBottomArea_EditorArray_Rect;
		public virtual RMethod RMHandleNativeDragDropInBottomArea_EditorArray_Rect
		{
			get
			{
				if(r_MHandleNativeDragDropInBottomArea_EditorArray_Rect == null)
				{
					r_MHandleNativeDragDropInBottomArea_EditorArray_Rect = new(this, "HandleNativeDragDropInBottomArea", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Rect));
				}
				return r_MHandleNativeDragDropInBottomArea_EditorArray_Rect;
			}
		}

		/// <summary>
		/// Void HandleEditorDragging(UnityEditor.Editor[], Int32, UnityEngine.Rect, Single, Boolean)
		/// </summary>
		protected RMethod r_MHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean;
		public virtual RMethod RMHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean
		{
			get
			{
				if(r_MHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean == null)
				{
					r_MHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean = new(this, "HandleEditorDragging", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Boolean));
				}
				return r_MHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean;
			}
		}

		/// <summary>
		/// Boolean DraggingOverRect(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MDraggingOverRect_Rect;
		public static RMethod RMDraggingOverRect_Rect
		{
			get
			{
				if(r_MDraggingOverRect_Rect == null)
				{
					r_MDraggingOverRect_Rect = new(Type, "DraggingOverRect", 0, typeof(UnityEngine.Rect));
				}
				return r_MDraggingOverRect_Rect;
			}
		}

		/// <summary>
		/// Void HandleDragPerformEvent(UnityEditor.Editor[], UnityEngine.Event, Int32 ByRef)
		/// </summary>
		protected RMethod r_MHandleDragPerformEvent_EditorArray_Event_Ref_Int32;
		public virtual RMethod RMHandleDragPerformEvent_EditorArray_Event_Ref_Int32
		{
			get
			{
				if(r_MHandleDragPerformEvent_EditorArray_Event_Ref_Int32 == null)
				{
					r_MHandleDragPerformEvent_EditorArray_Event_Ref_Int32 = new(this, "HandleDragPerformEvent", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Event), typeof(System.Int32).MakeByRefType());
				}
				return r_MHandleDragPerformEvent_EditorArray_Event_Ref_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTargetRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MGetTargetRect_Rect;
		public virtual RMethod RMGetTargetRect_Rect
		{
			get
			{
				if(r_MGetTargetRect_Rect == null)
				{
					r_MGetTargetRect_Rect = new(this, "GetTargetRect", 0, typeof(UnityEngine.Rect));
				}
				return r_MGetTargetRect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetMarkerRect(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MGetMarkerRect_Rect;
		public static RMethod RMGetMarkerRect_Rect
		{
			get
			{
				if(r_MGetMarkerRect_Rect == null)
				{
					r_MGetMarkerRect_Rect = new(Type, "GetMarkerRect", 0, typeof(UnityEngine.Rect));
				}
				return r_MGetMarkerRect_Rect;
			}
		}

		/// <summary>
		/// Boolean MoveOrCopyComponents(UnityEngine.Component[], UnityEngine.Component[], Boolean, Boolean)
		/// </summary>
		protected RMethod r_MMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean;
		public virtual RMethod RMMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean
		{
			get
			{
				if(r_MMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean == null)
				{
					r_MMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean = new(this, "MoveOrCopyComponents", 0, typeof(UnityEngine.Component).MakeArrayType(), typeof(UnityEngine.Component).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean;
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


        public virtual void HandleDraggingToEditor(UnityEditor.Editor[] @editors, System.Int32 @editorIndex, UnityEngine.Rect @dragRect, UnityEngine.Rect @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @dragRect, @contentRect};
            var ___result = RMHandleDraggingToEditor_EditorArray_Int32_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDraggingInBottomArea(UnityEditor.Editor[] @editors, UnityEngine.Rect @bottomRect, UnityEngine.Rect @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @bottomRect, @contentRect};
            var ___result = RMHandleDraggingInBottomArea_EditorArray_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDragPerformInBottomArea(UnityEditor.Editor[] @editors, UnityEngine.Rect @bottomRect, UnityEngine.Rect @targetRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @bottomRect, @targetRect};
            var ___result = RMHandleDragPerformInBottomArea_EditorArray_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleNativeDragDropInBottomArea(UnityEditor.Editor[] @editors, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @rect};
            var ___result = RMHandleNativeDragDropInBottomArea_EditorArray_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEditorDragging(UnityEditor.Editor[] @editors, System.Int32 @editorIndex, UnityEngine.Rect @targetRect, System.Single @markerY, System.Boolean @bottomTarget)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @targetRect, @markerY, @bottomTarget};
            var ___result = RMHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean DraggingOverRect(UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMDraggingOverRect_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void HandleDragPerformEvent(UnityEditor.Editor[] @editors, UnityEngine.Event @evt, ref System.Int32 @targetIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @evt, @targetIndex};
            var ___result = RMHandleDragPerformEvent_EditorArray_Event_Ref_Int32.Invoke(___genericsType, ___parameters);
			@targetIndex = ReflectionUtils.Convert<System.Int32>(___parameters[2]);

            
        }


        public virtual UnityEngine.Rect GetTargetRect(UnityEngine.Rect @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentRect};
            var ___result = RMGetTargetRect_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static UnityEngine.Rect GetMarkerRect(UnityEngine.Rect @targetRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRect};
            var ___result = RMGetMarkerRect_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual System.Boolean MoveOrCopyComponents(UnityEngine.Component[] @sourceComponents, UnityEngine.Component[] @targetComponents, System.Boolean @copy, System.Boolean @validateOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceComponents, @targetComponents, @copy, @validateOnly};
            var ___result = RMMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
