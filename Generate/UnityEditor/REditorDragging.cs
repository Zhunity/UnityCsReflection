using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.EditorDragging
	/// </summary>
    public partial class REditorDragging : RMember //
    {

		/// <summary>
		/// System.String k_DraggingModeKey
		/// </summary>
		protected static RField r_k_DraggingModeKey;
		public static RField Rk_DraggingModeKey
		{
			get
			{
				if(r_k_DraggingModeKey == null)
				{
					r_k_DraggingModeKey = new( ReleactionUtils.GetType("UnityEditor.EditorDragging"), "k_DraggingModeKey");
					r_k_DraggingModeKey.SetBelong(null);
				}
				return r_k_DraggingModeKey;
			}
		}

		/// <summary>
		/// UnityEditor.IPropertyView m_InspectorWindow
		/// </summary>
		protected RUnityEditor.RIPropertyView r_m_InspectorWindow;
		public virtual RUnityEditor.RIPropertyView Rm_InspectorWindow
		{
			get
			{
				if(r_m_InspectorWindow == null)
				{
					r_m_InspectorWindow = new(this, "m_InspectorWindow");
					r_m_InspectorWindow.SetBelong(this.instance);
				}
				return r_m_InspectorWindow;
			}
		}

		/// <summary>
		/// System.Boolean m_TargetAbove
		/// </summary>
		protected RField r_m_TargetAbove;
		public virtual RField Rm_TargetAbove
		{
			get
			{
				if(r_m_TargetAbove == null)
				{
					r_m_TargetAbove = new(this, "m_TargetAbove");
					r_m_TargetAbove.SetBelong(this.instance);
				}
				return r_m_TargetAbove;
			}
		}

		/// <summary>
		/// System.Int32 m_TargetIndex
		/// </summary>
		protected RField r_m_TargetIndex;
		public virtual RField Rm_TargetIndex
		{
			get
			{
				if(r_m_TargetIndex == null)
				{
					r_m_TargetIndex = new(this, "m_TargetIndex");
					r_m_TargetIndex.SetBelong(this.instance);
				}
				return r_m_TargetIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_LastIndex
		/// </summary>
		protected RField r_m_LastIndex;
		public virtual RField Rm_LastIndex
		{
			get
			{
				if(r_m_LastIndex == null)
				{
					r_m_LastIndex = new(this, "m_LastIndex");
					r_m_LastIndex.SetBelong(this.instance);
				}
				return r_m_LastIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_BottomAreaDropIndex
		/// </summary>
		protected RField r_m_BottomAreaDropIndex;
		public virtual RField Rm_BottomAreaDropIndex
		{
			get
			{
				if(r_m_BottomAreaDropIndex == null)
				{
					r_m_BottomAreaDropIndex = new(this, "m_BottomAreaDropIndex");
					r_m_BottomAreaDropIndex.SetBelong(this.instance);
				}
				return r_m_BottomAreaDropIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_BottomArea
		/// </summary>
		protected RUnityEngine.RRect r_m_BottomArea;
		public virtual RUnityEngine.RRect Rm_BottomArea
		{
			get
			{
				if(r_m_BottomArea == null)
				{
					r_m_BottomArea = new(this, "m_BottomArea");
					r_m_BottomArea.SetBelong(this.instance);
				}
				return r_m_BottomArea;
			}
		}

		/// <summary>
		/// Void HandleDraggingToEditor(UnityEditor.Editor[], Int32, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_HandleDraggingToEditor_EditorArray_Int32_Rect_Rect;
		public virtual RMethod RHandleDraggingToEditor_EditorArray_Int32_Rect_Rect
		{
			get
			{
				if(r_HandleDraggingToEditor_EditorArray_Int32_Rect_Rect == null)
				{
					r_HandleDraggingToEditor_EditorArray_Int32_Rect_Rect = new(this, "HandleDraggingToEditor", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_HandleDraggingToEditor_EditorArray_Int32_Rect_Rect.SetBelong(this.instance);
				}
				return r_HandleDraggingToEditor_EditorArray_Int32_Rect_Rect;
			}
		}

		/// <summary>
		/// Void HandleDraggingInBottomArea(UnityEditor.Editor[], UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_HandleDraggingInBottomArea_EditorArray_Rect_Rect;
		public virtual RMethod RHandleDraggingInBottomArea_EditorArray_Rect_Rect
		{
			get
			{
				if(r_HandleDraggingInBottomArea_EditorArray_Rect_Rect == null)
				{
					r_HandleDraggingInBottomArea_EditorArray_Rect_Rect = new(this, "HandleDraggingInBottomArea", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_HandleDraggingInBottomArea_EditorArray_Rect_Rect.SetBelong(this.instance);
				}
				return r_HandleDraggingInBottomArea_EditorArray_Rect_Rect;
			}
		}

		/// <summary>
		/// Void HandleDragPerformInBottomArea(UnityEditor.Editor[], UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_HandleDragPerformInBottomArea_EditorArray_Rect_Rect;
		public virtual RMethod RHandleDragPerformInBottomArea_EditorArray_Rect_Rect
		{
			get
			{
				if(r_HandleDragPerformInBottomArea_EditorArray_Rect_Rect == null)
				{
					r_HandleDragPerformInBottomArea_EditorArray_Rect_Rect = new(this, "HandleDragPerformInBottomArea", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_HandleDragPerformInBottomArea_EditorArray_Rect_Rect.SetBelong(this.instance);
				}
				return r_HandleDragPerformInBottomArea_EditorArray_Rect_Rect;
			}
		}

		/// <summary>
		/// Void HandleNativeDragDropInBottomArea(UnityEditor.Editor[], UnityEngine.Rect)
		/// </summary>
		protected RMethod r_HandleNativeDragDropInBottomArea_EditorArray_Rect;
		public virtual RMethod RHandleNativeDragDropInBottomArea_EditorArray_Rect
		{
			get
			{
				if(r_HandleNativeDragDropInBottomArea_EditorArray_Rect == null)
				{
					r_HandleNativeDragDropInBottomArea_EditorArray_Rect = new(this, "HandleNativeDragDropInBottomArea", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Rect));
					r_HandleNativeDragDropInBottomArea_EditorArray_Rect.SetBelong(this.instance);
				}
				return r_HandleNativeDragDropInBottomArea_EditorArray_Rect;
			}
		}

		/// <summary>
		/// Void HandleEditorDragging(UnityEditor.Editor[], Int32, UnityEngine.Rect, Single, Boolean)
		/// </summary>
		protected RMethod r_HandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean;
		public virtual RMethod RHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean
		{
			get
			{
				if(r_HandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean == null)
				{
					r_HandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean = new(this, "HandleEditorDragging", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Boolean));
					r_HandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean.SetBelong(this.instance);
				}
				return r_HandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean;
			}
		}

		/// <summary>
		/// Boolean DraggingOverRect(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_DraggingOverRect_Rect;
		public static RMethod RDraggingOverRect_Rect
		{
			get
			{
				if(r_DraggingOverRect_Rect == null)
				{
					r_DraggingOverRect_Rect = new( ReleactionUtils.GetType("UnityEditor.EditorDragging"), "DraggingOverRect", 0, typeof(UnityEngine.Rect));
					r_DraggingOverRect_Rect.SetBelong(null);
				}
				return r_DraggingOverRect_Rect;
			}
		}

		/// <summary>
		/// Void HandleDragPerformEvent(UnityEditor.Editor[], UnityEngine.Event, Int32 ByRef)
		/// </summary>
		protected RMethod r_HandleDragPerformEvent_EditorArray_Event_Ref_Int32;
		public virtual RMethod RHandleDragPerformEvent_EditorArray_Event_Ref_Int32
		{
			get
			{
				if(r_HandleDragPerformEvent_EditorArray_Event_Ref_Int32 == null)
				{
					r_HandleDragPerformEvent_EditorArray_Event_Ref_Int32 = new(this, "HandleDragPerformEvent", 0, typeof(UnityEditor.Editor).MakeArrayType(), typeof(UnityEngine.Event), typeof(System.Int32).MakeByRefType());
					r_HandleDragPerformEvent_EditorArray_Event_Ref_Int32.SetBelong(this.instance);
				}
				return r_HandleDragPerformEvent_EditorArray_Event_Ref_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTargetRect(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GetTargetRect_Rect;
		public virtual RMethod RGetTargetRect_Rect
		{
			get
			{
				if(r_GetTargetRect_Rect == null)
				{
					r_GetTargetRect_Rect = new(this, "GetTargetRect", 0, typeof(UnityEngine.Rect));
					r_GetTargetRect_Rect.SetBelong(this.instance);
				}
				return r_GetTargetRect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetMarkerRect(UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_GetMarkerRect_Rect;
		public static RMethod RGetMarkerRect_Rect
		{
			get
			{
				if(r_GetMarkerRect_Rect == null)
				{
					r_GetMarkerRect_Rect = new( ReleactionUtils.GetType("UnityEditor.EditorDragging"), "GetMarkerRect", 0, typeof(UnityEngine.Rect));
					r_GetMarkerRect_Rect.SetBelong(null);
				}
				return r_GetMarkerRect_Rect;
			}
		}

		/// <summary>
		/// Boolean MoveOrCopyComponents(UnityEngine.Component[], UnityEngine.Component[], Boolean, Boolean)
		/// </summary>
		protected RMethod r_MoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean;
		public virtual RMethod RMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean
		{
			get
			{
				if(r_MoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean == null)
				{
					r_MoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean = new(this, "MoveOrCopyComponents", 0, typeof(UnityEngine.Component).MakeArrayType(), typeof(UnityEngine.Component).MakeArrayType(), typeof(System.Boolean), typeof(System.Boolean));
					r_MoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean;
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

        public virtual void HandleDraggingToEditor(UnityEditor.Editor[]  @editors, System.Int32  @editorIndex, UnityEngine.Rect  @dragRect, UnityEngine.Rect  @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @dragRect, @contentRect};
            var ___result = RHandleDraggingToEditor_EditorArray_Int32_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDraggingInBottomArea(UnityEditor.Editor[]  @editors, UnityEngine.Rect  @bottomRect, UnityEngine.Rect  @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @bottomRect, @contentRect};
            var ___result = RHandleDraggingInBottomArea_EditorArray_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleDragPerformInBottomArea(UnityEditor.Editor[]  @editors, UnityEngine.Rect  @bottomRect, UnityEngine.Rect  @targetRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @bottomRect, @targetRect};
            var ___result = RHandleDragPerformInBottomArea_EditorArray_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleNativeDragDropInBottomArea(UnityEditor.Editor[]  @editors, UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @rect};
            var ___result = RHandleNativeDragDropInBottomArea_EditorArray_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEditorDragging(UnityEditor.Editor[]  @editors, System.Int32  @editorIndex, UnityEngine.Rect  @targetRect, System.Single  @markerY, System.Boolean  @bottomTarget)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @editorIndex, @targetRect, @markerY, @bottomTarget};
            var ___result = RHandleEditorDragging_EditorArray_Int32_Rect_Single_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean DraggingOverRect(UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RDraggingOverRect_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void HandleDragPerformEvent(UnityEditor.Editor[]  @editors, UnityEngine.Event  @evt, ref System.Int32  @targetIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@editors, @evt, @targetIndex};
            var ___result = RHandleDragPerformEvent_EditorArray_Event_Ref_Int32.Invoke(___genericsType, ___parameters);
			targetIndex = (System.Int32)___parameters[2];

            
        }


        public virtual UnityEngine.Rect GetTargetRect(UnityEngine.Rect  @contentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentRect};
            var ___result = RGetTargetRect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect GetMarkerRect(UnityEngine.Rect  @targetRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetRect};
            var ___result = RGetMarkerRect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Boolean MoveOrCopyComponents(UnityEngine.Component[]  @sourceComponents, UnityEngine.Component[]  @targetComponents, System.Boolean  @copy, System.Boolean  @validateOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceComponents, @targetComponents, @copy, @validateOnly};
            var ___result = RMoveOrCopyComponents_ComponentArray_ComponentArray_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
