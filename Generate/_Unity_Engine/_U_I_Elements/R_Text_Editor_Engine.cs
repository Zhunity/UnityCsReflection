
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.TextEditorEngine
	/// </summary>
    public partial class RTextEditorEngine : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.TextEditorEngine");
            }
        }

        public RTextEditorEngine() : base("UnityEngine.UIElements.TextEditorEngine")
        {
        }

        public RTextEditorEngine(System.Object instance) : base("UnityEngine.UIElements.TextEditorEngine")
		{
            SetInstance(instance);
		}

        public RTextEditorEngine(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextEditorEngine(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.TextEditorEngine+OnDetectFocusChangeFunction m_DetectFocusChangeFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEngine.ROnDetectFocusChangeFunction r_Fm_DetectFocusChangeFunction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEngine.ROnDetectFocusChangeFunction RFm_DetectFocusChangeFunction
		{
			get
			{
				if(r_Fm_DetectFocusChangeFunction == null)
				{
					r_Fm_DetectFocusChangeFunction = new(this, "m_DetectFocusChangeFunction");
				}
				return r_Fm_DetectFocusChangeFunction;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextEditorEngine+OnIndexChangeFunction m_IndexChangeFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEngine.ROnIndexChangeFunction r_Fm_IndexChangeFunction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextEditorEngine.ROnIndexChangeFunction RFm_IndexChangeFunction
		{
			get
			{
				if(r_Fm_IndexChangeFunction == null)
				{
					r_Fm_IndexChangeFunction = new(this, "m_IndexChangeFunction");
				}
				return r_Fm_IndexChangeFunction;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard keyboardOnScreen
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard r_FkeyboardOnScreen;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard RFkeyboardOnScreen
		{
			get
			{
				if(r_FkeyboardOnScreen == null)
				{
					r_FkeyboardOnScreen = new(this, "keyboardOnScreen");
				}
				return r_FkeyboardOnScreen;
			}
		}

		/// <summary>
		/// System.Int32 controlID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcontrolID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcontrolID
		{
			get
			{
				if(r_FcontrolID == null)
				{
					r_FcontrolID = new(this, "controlID");
				}
				return r_FcontrolID;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_Fstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RFstyle
		{
			get
			{
				if(r_Fstyle == null)
				{
					r_Fstyle = new(this, "style");
				}
				return r_Fstyle;
			}
		}

		/// <summary>
		/// System.Boolean multiline
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fmultiline;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFmultiline
		{
			get
			{
				if(r_Fmultiline == null)
				{
					r_Fmultiline = new(this, "multiline");
				}
				return r_Fmultiline;
			}
		}

		/// <summary>
		/// System.Boolean hasHorizontalCursorPos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhasHorizontalCursorPos;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhasHorizontalCursorPos
		{
			get
			{
				if(r_FhasHorizontalCursorPos == null)
				{
					r_FhasHorizontalCursorPos = new(this, "hasHorizontalCursorPos");
				}
				return r_FhasHorizontalCursorPos;
			}
		}

		/// <summary>
		/// System.Boolean isPasswordField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisPasswordField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisPasswordField
		{
			get
			{
				if(r_FisPasswordField == null)
				{
					r_FisPasswordField = new(this, "isPasswordField");
				}
				return r_FisPasswordField;
			}
		}

		/// <summary>
		/// System.Boolean m_HasFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasFocus
		{
			get
			{
				if(r_Fm_HasFocus == null)
				{
					r_Fm_HasFocus = new(this, "m_HasFocus");
				}
				return r_Fm_HasFocus;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 scrollOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FscrollOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFscrollOffset
		{
			get
			{
				if(r_FscrollOffset == null)
				{
					r_FscrollOffset = new(this, "scrollOffset");
				}
				return r_FscrollOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 graphicalCursorPos
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FgraphicalCursorPos;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFgraphicalCursorPos
		{
			get
			{
				if(r_FgraphicalCursorPos == null)
				{
					r_FgraphicalCursorPos = new(this, "graphicalCursorPos");
				}
				return r_FgraphicalCursorPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 graphicalSelectCursorPos
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FgraphicalSelectCursorPos;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFgraphicalSelectCursorPos
		{
			get
			{
				if(r_FgraphicalSelectCursorPos == null)
				{
					r_FgraphicalSelectCursorPos = new(this, "graphicalSelectCursorPos");
				}
				return r_FgraphicalSelectCursorPos;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PlocalPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPlocalPosition
		{
			get
			{
				if(r_PlocalPosition == null)
				{
					r_PlocalPosition = new(this, "localPosition", -1);
				}
				return r_PlocalPosition;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent content
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIContent r_Pcontent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIContent RPcontent
		{
			get
			{
				if(r_Pcontent == null)
				{
					r_Pcontent = new(this, "content", -1);
				}
				return r_Pcontent;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// Int32 cursorIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcursorIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcursorIndex
		{
			get
			{
				if(r_PcursorIndex == null)
				{
					r_PcursorIndex = new(this, "cursorIndex", -1);
				}
				return r_PcursorIndex;
			}
		}

		/// <summary>
		/// Int32 selectIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PselectIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPselectIndex
		{
			get
			{
				if(r_PselectIndex == null)
				{
					r_PselectIndex = new(this, "selectIndex", -1);
				}
				return r_PselectIndex;
			}
		}

		/// <summary>
		/// DblClickSnapping doubleClickSnapping
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextEditor.RDblClickSnapping r_PdoubleClickSnapping;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextEditor.RDblClickSnapping RPdoubleClickSnapping
		{
			get
			{
				if(r_PdoubleClickSnapping == null)
				{
					r_PdoubleClickSnapping = new(this, "doubleClickSnapping", -1);
				}
				return r_PdoubleClickSnapping;
			}
		}

		/// <summary>
		/// Int32 altCursorPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PaltCursorPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPaltCursorPosition
		{
			get
			{
				if(r_PaltCursorPosition == null)
				{
					r_PaltCursorPosition = new(this, "altCursorPosition", -1);
				}
				return r_PaltCursorPosition;
			}
		}

		/// <summary>
		/// Boolean hasSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasSelection;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasSelection
		{
			get
			{
				if(r_PhasSelection == null)
				{
					r_PhasSelection = new(this, "hasSelection", -1);
				}
				return r_PhasSelection;
			}
		}

		/// <summary>
		/// System.String SelectedText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSelectedText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSelectedText
		{
			get
			{
				if(r_PSelectedText == null)
				{
					r_PSelectedText = new(this, "SelectedText", -1);
				}
				return r_PSelectedText;
			}
		}

		/// <summary>
		/// Void OnDetectFocusChange()
		/// </summary>
		protected RMethod r_MOnDetectFocusChange;
		public virtual RMethod RMOnDetectFocusChange
		{
			get
			{
				if(r_MOnDetectFocusChange == null)
				{
					r_MOnDetectFocusChange = new(this, "OnDetectFocusChange", 0);
				}
				return r_MOnDetectFocusChange;
			}
		}

		/// <summary>
		/// Void OnCursorIndexChange()
		/// </summary>
		protected RMethod r_MOnCursorIndexChange;
		public virtual RMethod RMOnCursorIndexChange
		{
			get
			{
				if(r_MOnCursorIndexChange == null)
				{
					r_MOnCursorIndexChange = new(this, "OnCursorIndexChange", 0);
				}
				return r_MOnCursorIndexChange;
			}
		}

		/// <summary>
		/// Void OnSelectIndexChange()
		/// </summary>
		protected RMethod r_MOnSelectIndexChange;
		public virtual RMethod RMOnSelectIndexChange
		{
			get
			{
				if(r_MOnSelectIndexChange == null)
				{
					r_MOnSelectIndexChange = new(this, "OnSelectIndexChange", 0);
				}
				return r_MOnSelectIndexChange;
			}
		}

		/// <summary>
		/// Void OnFocus()
		/// </summary>
		protected RMethod r_MOnFocus;
		public virtual RMethod RMOnFocus
		{
			get
			{
				if(r_MOnFocus == null)
				{
					r_MOnFocus = new(this, "OnFocus", 0);
				}
				return r_MOnFocus;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_MOnLostFocus;
		public virtual RMethod RMOnLostFocus
		{
			get
			{
				if(r_MOnLostFocus == null)
				{
					r_MOnLostFocus = new(this, "OnLostFocus", 0);
				}
				return r_MOnLostFocus;
			}
		}

		/// <summary>
		/// Boolean HandleKeyEvent(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MHandleKeyEvent_Event;
		public virtual RMethod RMHandleKeyEvent_Event
		{
			get
			{
				if(r_MHandleKeyEvent_Event == null)
				{
					r_MHandleKeyEvent_Event = new(this, "HandleKeyEvent", 0, typeof(UnityEngine.Event));
				}
				return r_MHandleKeyEvent_Event;
			}
		}

		/// <summary>
		/// Boolean HandleKeyEvent(UnityEngine.Event, Boolean)
		/// </summary>
		protected RMethod r_MHandleKeyEvent_Event_Boolean;
		public virtual RMethod RMHandleKeyEvent_Event_Boolean
		{
			get
			{
				if(r_MHandleKeyEvent_Event_Boolean == null)
				{
					r_MHandleKeyEvent_Event_Boolean = new(this, "HandleKeyEvent", 0, typeof(UnityEngine.Event), typeof(System.Boolean));
				}
				return r_MHandleKeyEvent_Event_Boolean;
			}
		}

		/// <summary>
		/// Boolean DeleteLineBack()
		/// </summary>
		protected RMethod r_MDeleteLineBack;
		public virtual RMethod RMDeleteLineBack
		{
			get
			{
				if(r_MDeleteLineBack == null)
				{
					r_MDeleteLineBack = new(this, "DeleteLineBack", 0);
				}
				return r_MDeleteLineBack;
			}
		}

		/// <summary>
		/// Boolean DeleteWordBack()
		/// </summary>
		protected RMethod r_MDeleteWordBack;
		public virtual RMethod RMDeleteWordBack
		{
			get
			{
				if(r_MDeleteWordBack == null)
				{
					r_MDeleteWordBack = new(this, "DeleteWordBack", 0);
				}
				return r_MDeleteWordBack;
			}
		}

		/// <summary>
		/// Boolean DeleteWordForward()
		/// </summary>
		protected RMethod r_MDeleteWordForward;
		public virtual RMethod RMDeleteWordForward
		{
			get
			{
				if(r_MDeleteWordForward == null)
				{
					r_MDeleteWordForward = new(this, "DeleteWordForward", 0);
				}
				return r_MDeleteWordForward;
			}
		}

		/// <summary>
		/// Boolean Delete()
		/// </summary>
		protected RMethod r_MDelete;
		public virtual RMethod RMDelete
		{
			get
			{
				if(r_MDelete == null)
				{
					r_MDelete = new(this, "Delete", 0);
				}
				return r_MDelete;
			}
		}

		/// <summary>
		/// Boolean CanPaste()
		/// </summary>
		protected RMethod r_MCanPaste;
		public virtual RMethod RMCanPaste
		{
			get
			{
				if(r_MCanPaste == null)
				{
					r_MCanPaste = new(this, "CanPaste", 0);
				}
				return r_MCanPaste;
			}
		}

		/// <summary>
		/// Boolean Backspace()
		/// </summary>
		protected RMethod r_MBackspace;
		public virtual RMethod RMBackspace
		{
			get
			{
				if(r_MBackspace == null)
				{
					r_MBackspace = new(this, "Backspace", 0);
				}
				return r_MBackspace;
			}
		}

		/// <summary>
		/// Void SelectAll()
		/// </summary>
		protected RMethod r_MSelectAll;
		public virtual RMethod RMSelectAll
		{
			get
			{
				if(r_MSelectAll == null)
				{
					r_MSelectAll = new(this, "SelectAll", 0);
				}
				return r_MSelectAll;
			}
		}

		/// <summary>
		/// Void SelectNone()
		/// </summary>
		protected RMethod r_MSelectNone;
		public virtual RMethod RMSelectNone
		{
			get
			{
				if(r_MSelectNone == null)
				{
					r_MSelectNone = new(this, "SelectNone", 0);
				}
				return r_MSelectNone;
			}
		}

		/// <summary>
		/// Boolean DeleteSelection()
		/// </summary>
		protected RMethod r_MDeleteSelection;
		public virtual RMethod RMDeleteSelection
		{
			get
			{
				if(r_MDeleteSelection == null)
				{
					r_MDeleteSelection = new(this, "DeleteSelection", 0);
				}
				return r_MDeleteSelection;
			}
		}

		/// <summary>
		/// Void ReplaceSelection(System.String)
		/// </summary>
		protected RMethod r_MReplaceSelection_String;
		public virtual RMethod RMReplaceSelection_String
		{
			get
			{
				if(r_MReplaceSelection_String == null)
				{
					r_MReplaceSelection_String = new(this, "ReplaceSelection", 0, typeof(System.String));
				}
				return r_MReplaceSelection_String;
			}
		}

		/// <summary>
		/// Void Insert(Char)
		/// </summary>
		protected RMethod r_MInsert_Char;
		public virtual RMethod RMInsert_Char
		{
			get
			{
				if(r_MInsert_Char == null)
				{
					r_MInsert_Char = new(this, "Insert", 0, typeof(System.Char));
				}
				return r_MInsert_Char;
			}
		}

		/// <summary>
		/// Void MoveSelectionToAltCursor()
		/// </summary>
		protected RMethod r_MMoveSelectionToAltCursor;
		public virtual RMethod RMMoveSelectionToAltCursor
		{
			get
			{
				if(r_MMoveSelectionToAltCursor == null)
				{
					r_MMoveSelectionToAltCursor = new(this, "MoveSelectionToAltCursor", 0);
				}
				return r_MMoveSelectionToAltCursor;
			}
		}

		/// <summary>
		/// Void MoveRight()
		/// </summary>
		protected RMethod r_MMoveRight;
		public virtual RMethod RMMoveRight
		{
			get
			{
				if(r_MMoveRight == null)
				{
					r_MMoveRight = new(this, "MoveRight", 0);
				}
				return r_MMoveRight;
			}
		}

		/// <summary>
		/// Void MoveLeft()
		/// </summary>
		protected RMethod r_MMoveLeft;
		public virtual RMethod RMMoveLeft
		{
			get
			{
				if(r_MMoveLeft == null)
				{
					r_MMoveLeft = new(this, "MoveLeft", 0);
				}
				return r_MMoveLeft;
			}
		}

		/// <summary>
		/// Void MoveUp()
		/// </summary>
		protected RMethod r_MMoveUp;
		public virtual RMethod RMMoveUp
		{
			get
			{
				if(r_MMoveUp == null)
				{
					r_MMoveUp = new(this, "MoveUp", 0);
				}
				return r_MMoveUp;
			}
		}

		/// <summary>
		/// Void MoveDown()
		/// </summary>
		protected RMethod r_MMoveDown;
		public virtual RMethod RMMoveDown
		{
			get
			{
				if(r_MMoveDown == null)
				{
					r_MMoveDown = new(this, "MoveDown", 0);
				}
				return r_MMoveDown;
			}
		}

		/// <summary>
		/// Void MoveLineStart()
		/// </summary>
		protected RMethod r_MMoveLineStart;
		public virtual RMethod RMMoveLineStart
		{
			get
			{
				if(r_MMoveLineStart == null)
				{
					r_MMoveLineStart = new(this, "MoveLineStart", 0);
				}
				return r_MMoveLineStart;
			}
		}

		/// <summary>
		/// Void MoveLineEnd()
		/// </summary>
		protected RMethod r_MMoveLineEnd;
		public virtual RMethod RMMoveLineEnd
		{
			get
			{
				if(r_MMoveLineEnd == null)
				{
					r_MMoveLineEnd = new(this, "MoveLineEnd", 0);
				}
				return r_MMoveLineEnd;
			}
		}

		/// <summary>
		/// Void MoveGraphicalLineStart()
		/// </summary>
		protected RMethod r_MMoveGraphicalLineStart;
		public virtual RMethod RMMoveGraphicalLineStart
		{
			get
			{
				if(r_MMoveGraphicalLineStart == null)
				{
					r_MMoveGraphicalLineStart = new(this, "MoveGraphicalLineStart", 0);
				}
				return r_MMoveGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void MoveGraphicalLineEnd()
		/// </summary>
		protected RMethod r_MMoveGraphicalLineEnd;
		public virtual RMethod RMMoveGraphicalLineEnd
		{
			get
			{
				if(r_MMoveGraphicalLineEnd == null)
				{
					r_MMoveGraphicalLineEnd = new(this, "MoveGraphicalLineEnd", 0);
				}
				return r_MMoveGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void MoveTextStart()
		/// </summary>
		protected RMethod r_MMoveTextStart;
		public virtual RMethod RMMoveTextStart
		{
			get
			{
				if(r_MMoveTextStart == null)
				{
					r_MMoveTextStart = new(this, "MoveTextStart", 0);
				}
				return r_MMoveTextStart;
			}
		}

		/// <summary>
		/// Void MoveTextEnd()
		/// </summary>
		protected RMethod r_MMoveTextEnd;
		public virtual RMethod RMMoveTextEnd
		{
			get
			{
				if(r_MMoveTextEnd == null)
				{
					r_MMoveTextEnd = new(this, "MoveTextEnd", 0);
				}
				return r_MMoveTextEnd;
			}
		}

		/// <summary>
		/// Void MoveParagraphForward()
		/// </summary>
		protected RMethod r_MMoveParagraphForward;
		public virtual RMethod RMMoveParagraphForward
		{
			get
			{
				if(r_MMoveParagraphForward == null)
				{
					r_MMoveParagraphForward = new(this, "MoveParagraphForward", 0);
				}
				return r_MMoveParagraphForward;
			}
		}

		/// <summary>
		/// Void MoveParagraphBackward()
		/// </summary>
		protected RMethod r_MMoveParagraphBackward;
		public virtual RMethod RMMoveParagraphBackward
		{
			get
			{
				if(r_MMoveParagraphBackward == null)
				{
					r_MMoveParagraphBackward = new(this, "MoveParagraphBackward", 0);
				}
				return r_MMoveParagraphBackward;
			}
		}

		/// <summary>
		/// Void MoveCursorToPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MMoveCursorToPosition_Vector2;
		public virtual RMethod RMMoveCursorToPosition_Vector2
		{
			get
			{
				if(r_MMoveCursorToPosition_Vector2 == null)
				{
					r_MMoveCursorToPosition_Vector2 = new(this, "MoveCursorToPosition", 0, typeof(UnityEngine.Vector2));
				}
				return r_MMoveCursorToPosition_Vector2;
			}
		}

		/// <summary>
		/// Void MoveCursorToPosition_Internal(UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_MMoveCursorToPosition_Internal_Vector2_Boolean;
		public virtual RMethod RMMoveCursorToPosition_Internal_Vector2_Boolean
		{
			get
			{
				if(r_MMoveCursorToPosition_Internal_Vector2_Boolean == null)
				{
					r_MMoveCursorToPosition_Internal_Vector2_Boolean = new(this, "MoveCursorToPosition_Internal", 0, typeof(UnityEngine.Vector2), typeof(System.Boolean));
				}
				return r_MMoveCursorToPosition_Internal_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Void MoveAltCursorToPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MMoveAltCursorToPosition_Vector2;
		public virtual RMethod RMMoveAltCursorToPosition_Vector2
		{
			get
			{
				if(r_MMoveAltCursorToPosition_Vector2 == null)
				{
					r_MMoveAltCursorToPosition_Vector2 = new(this, "MoveAltCursorToPosition", 0, typeof(UnityEngine.Vector2));
				}
				return r_MMoveAltCursorToPosition_Vector2;
			}
		}

		/// <summary>
		/// Boolean IsOverSelection(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MIsOverSelection_Vector2;
		public virtual RMethod RMIsOverSelection_Vector2
		{
			get
			{
				if(r_MIsOverSelection_Vector2 == null)
				{
					r_MIsOverSelection_Vector2 = new(this, "IsOverSelection", 0, typeof(UnityEngine.Vector2));
				}
				return r_MIsOverSelection_Vector2;
			}
		}

		/// <summary>
		/// Void SelectToPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSelectToPosition_Vector2;
		public virtual RMethod RMSelectToPosition_Vector2
		{
			get
			{
				if(r_MSelectToPosition_Vector2 == null)
				{
					r_MSelectToPosition_Vector2 = new(this, "SelectToPosition", 0, typeof(UnityEngine.Vector2));
				}
				return r_MSelectToPosition_Vector2;
			}
		}

		/// <summary>
		/// Void SelectLeft()
		/// </summary>
		protected RMethod r_MSelectLeft;
		public virtual RMethod RMSelectLeft
		{
			get
			{
				if(r_MSelectLeft == null)
				{
					r_MSelectLeft = new(this, "SelectLeft", 0);
				}
				return r_MSelectLeft;
			}
		}

		/// <summary>
		/// Void SelectRight()
		/// </summary>
		protected RMethod r_MSelectRight;
		public virtual RMethod RMSelectRight
		{
			get
			{
				if(r_MSelectRight == null)
				{
					r_MSelectRight = new(this, "SelectRight", 0);
				}
				return r_MSelectRight;
			}
		}

		/// <summary>
		/// Void SelectUp()
		/// </summary>
		protected RMethod r_MSelectUp;
		public virtual RMethod RMSelectUp
		{
			get
			{
				if(r_MSelectUp == null)
				{
					r_MSelectUp = new(this, "SelectUp", 0);
				}
				return r_MSelectUp;
			}
		}

		/// <summary>
		/// Void SelectDown()
		/// </summary>
		protected RMethod r_MSelectDown;
		public virtual RMethod RMSelectDown
		{
			get
			{
				if(r_MSelectDown == null)
				{
					r_MSelectDown = new(this, "SelectDown", 0);
				}
				return r_MSelectDown;
			}
		}

		/// <summary>
		/// Void SelectTextEnd()
		/// </summary>
		protected RMethod r_MSelectTextEnd;
		public virtual RMethod RMSelectTextEnd
		{
			get
			{
				if(r_MSelectTextEnd == null)
				{
					r_MSelectTextEnd = new(this, "SelectTextEnd", 0);
				}
				return r_MSelectTextEnd;
			}
		}

		/// <summary>
		/// Void SelectTextStart()
		/// </summary>
		protected RMethod r_MSelectTextStart;
		public virtual RMethod RMSelectTextStart
		{
			get
			{
				if(r_MSelectTextStart == null)
				{
					r_MSelectTextStart = new(this, "SelectTextStart", 0);
				}
				return r_MSelectTextStart;
			}
		}

		/// <summary>
		/// Void MouseDragSelectsWholeWords(Boolean)
		/// </summary>
		protected RMethod r_MMouseDragSelectsWholeWords_Boolean;
		public virtual RMethod RMMouseDragSelectsWholeWords_Boolean
		{
			get
			{
				if(r_MMouseDragSelectsWholeWords_Boolean == null)
				{
					r_MMouseDragSelectsWholeWords_Boolean = new(this, "MouseDragSelectsWholeWords", 0, typeof(System.Boolean));
				}
				return r_MMouseDragSelectsWholeWords_Boolean;
			}
		}

		/// <summary>
		/// Void DblClickSnap(DblClickSnapping)
		/// </summary>
		protected RMethod r_MDblClickSnap_DblClickSnapping;
		public virtual RMethod RMDblClickSnap_DblClickSnapping
		{
			get
			{
				if(r_MDblClickSnap_DblClickSnapping == null)
				{
					r_MDblClickSnap_DblClickSnapping = new(this, "DblClickSnap", 0,  ReflectionUtils.GetType("UnityEngine.TextEditor+DblClickSnapping"));
				}
				return r_MDblClickSnap_DblClickSnapping;
			}
		}

		/// <summary>
		/// Void MoveWordRight()
		/// </summary>
		protected RMethod r_MMoveWordRight;
		public virtual RMethod RMMoveWordRight
		{
			get
			{
				if(r_MMoveWordRight == null)
				{
					r_MMoveWordRight = new(this, "MoveWordRight", 0);
				}
				return r_MMoveWordRight;
			}
		}

		/// <summary>
		/// Void MoveToStartOfNextWord()
		/// </summary>
		protected RMethod r_MMoveToStartOfNextWord;
		public virtual RMethod RMMoveToStartOfNextWord
		{
			get
			{
				if(r_MMoveToStartOfNextWord == null)
				{
					r_MMoveToStartOfNextWord = new(this, "MoveToStartOfNextWord", 0);
				}
				return r_MMoveToStartOfNextWord;
			}
		}

		/// <summary>
		/// Void MoveToEndOfPreviousWord()
		/// </summary>
		protected RMethod r_MMoveToEndOfPreviousWord;
		public virtual RMethod RMMoveToEndOfPreviousWord
		{
			get
			{
				if(r_MMoveToEndOfPreviousWord == null)
				{
					r_MMoveToEndOfPreviousWord = new(this, "MoveToEndOfPreviousWord", 0);
				}
				return r_MMoveToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// Void SelectToStartOfNextWord()
		/// </summary>
		protected RMethod r_MSelectToStartOfNextWord;
		public virtual RMethod RMSelectToStartOfNextWord
		{
			get
			{
				if(r_MSelectToStartOfNextWord == null)
				{
					r_MSelectToStartOfNextWord = new(this, "SelectToStartOfNextWord", 0);
				}
				return r_MSelectToStartOfNextWord;
			}
		}

		/// <summary>
		/// Void SelectToEndOfPreviousWord()
		/// </summary>
		protected RMethod r_MSelectToEndOfPreviousWord;
		public virtual RMethod RMSelectToEndOfPreviousWord
		{
			get
			{
				if(r_MSelectToEndOfPreviousWord == null)
				{
					r_MSelectToEndOfPreviousWord = new(this, "SelectToEndOfPreviousWord", 0);
				}
				return r_MSelectToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// Int32 FindStartOfNextWord(Int32)
		/// </summary>
		protected RMethod r_MFindStartOfNextWord_Int32;
		public virtual RMethod RMFindStartOfNextWord_Int32
		{
			get
			{
				if(r_MFindStartOfNextWord_Int32 == null)
				{
					r_MFindStartOfNextWord_Int32 = new(this, "FindStartOfNextWord", 0, typeof(System.Int32));
				}
				return r_MFindStartOfNextWord_Int32;
			}
		}

		/// <summary>
		/// Void MoveWordLeft()
		/// </summary>
		protected RMethod r_MMoveWordLeft;
		public virtual RMethod RMMoveWordLeft
		{
			get
			{
				if(r_MMoveWordLeft == null)
				{
					r_MMoveWordLeft = new(this, "MoveWordLeft", 0);
				}
				return r_MMoveWordLeft;
			}
		}

		/// <summary>
		/// Void SelectWordRight()
		/// </summary>
		protected RMethod r_MSelectWordRight;
		public virtual RMethod RMSelectWordRight
		{
			get
			{
				if(r_MSelectWordRight == null)
				{
					r_MSelectWordRight = new(this, "SelectWordRight", 0);
				}
				return r_MSelectWordRight;
			}
		}

		/// <summary>
		/// Void SelectWordLeft()
		/// </summary>
		protected RMethod r_MSelectWordLeft;
		public virtual RMethod RMSelectWordLeft
		{
			get
			{
				if(r_MSelectWordLeft == null)
				{
					r_MSelectWordLeft = new(this, "SelectWordLeft", 0);
				}
				return r_MSelectWordLeft;
			}
		}

		/// <summary>
		/// Void ExpandSelectGraphicalLineStart()
		/// </summary>
		protected RMethod r_MExpandSelectGraphicalLineStart;
		public virtual RMethod RMExpandSelectGraphicalLineStart
		{
			get
			{
				if(r_MExpandSelectGraphicalLineStart == null)
				{
					r_MExpandSelectGraphicalLineStart = new(this, "ExpandSelectGraphicalLineStart", 0);
				}
				return r_MExpandSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void ExpandSelectGraphicalLineEnd()
		/// </summary>
		protected RMethod r_MExpandSelectGraphicalLineEnd;
		public virtual RMethod RMExpandSelectGraphicalLineEnd
		{
			get
			{
				if(r_MExpandSelectGraphicalLineEnd == null)
				{
					r_MExpandSelectGraphicalLineEnd = new(this, "ExpandSelectGraphicalLineEnd", 0);
				}
				return r_MExpandSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void SelectGraphicalLineStart()
		/// </summary>
		protected RMethod r_MSelectGraphicalLineStart;
		public virtual RMethod RMSelectGraphicalLineStart
		{
			get
			{
				if(r_MSelectGraphicalLineStart == null)
				{
					r_MSelectGraphicalLineStart = new(this, "SelectGraphicalLineStart", 0);
				}
				return r_MSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void SelectGraphicalLineEnd()
		/// </summary>
		protected RMethod r_MSelectGraphicalLineEnd;
		public virtual RMethod RMSelectGraphicalLineEnd
		{
			get
			{
				if(r_MSelectGraphicalLineEnd == null)
				{
					r_MSelectGraphicalLineEnd = new(this, "SelectGraphicalLineEnd", 0);
				}
				return r_MSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void SelectParagraphForward()
		/// </summary>
		protected RMethod r_MSelectParagraphForward;
		public virtual RMethod RMSelectParagraphForward
		{
			get
			{
				if(r_MSelectParagraphForward == null)
				{
					r_MSelectParagraphForward = new(this, "SelectParagraphForward", 0);
				}
				return r_MSelectParagraphForward;
			}
		}

		/// <summary>
		/// Void SelectParagraphBackward()
		/// </summary>
		protected RMethod r_MSelectParagraphBackward;
		public virtual RMethod RMSelectParagraphBackward
		{
			get
			{
				if(r_MSelectParagraphBackward == null)
				{
					r_MSelectParagraphBackward = new(this, "SelectParagraphBackward", 0);
				}
				return r_MSelectParagraphBackward;
			}
		}

		/// <summary>
		/// Void SelectCurrentWord()
		/// </summary>
		protected RMethod r_MSelectCurrentWord;
		public virtual RMethod RMSelectCurrentWord
		{
			get
			{
				if(r_MSelectCurrentWord == null)
				{
					r_MSelectCurrentWord = new(this, "SelectCurrentWord", 0);
				}
				return r_MSelectCurrentWord;
			}
		}

		/// <summary>
		/// Void SelectCurrentParagraph()
		/// </summary>
		protected RMethod r_MSelectCurrentParagraph;
		public virtual RMethod RMSelectCurrentParagraph
		{
			get
			{
				if(r_MSelectCurrentParagraph == null)
				{
					r_MSelectCurrentParagraph = new(this, "SelectCurrentParagraph", 0);
				}
				return r_MSelectCurrentParagraph;
			}
		}

		/// <summary>
		/// Void UpdateScrollOffsetIfNeeded(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MUpdateScrollOffsetIfNeeded_Event;
		public virtual RMethod RMUpdateScrollOffsetIfNeeded_Event
		{
			get
			{
				if(r_MUpdateScrollOffsetIfNeeded_Event == null)
				{
					r_MUpdateScrollOffsetIfNeeded_Event = new(this, "UpdateScrollOffsetIfNeeded", 0, typeof(UnityEngine.Event));
				}
				return r_MUpdateScrollOffsetIfNeeded_Event;
			}
		}

		/// <summary>
		/// Void UpdateScrollOffset()
		/// </summary>
		protected RMethod r_MUpdateScrollOffset;
		public virtual RMethod RMUpdateScrollOffset
		{
			get
			{
				if(r_MUpdateScrollOffset == null)
				{
					r_MUpdateScrollOffset = new(this, "UpdateScrollOffset", 0);
				}
				return r_MUpdateScrollOffset;
			}
		}

		/// <summary>
		/// Void DrawCursor(System.String)
		/// </summary>
		protected RMethod r_MDrawCursor_String;
		public virtual RMethod RMDrawCursor_String
		{
			get
			{
				if(r_MDrawCursor_String == null)
				{
					r_MDrawCursor_String = new(this, "DrawCursor", 0, typeof(System.String));
				}
				return r_MDrawCursor_String;
			}
		}

		/// <summary>
		/// Void SaveBackup()
		/// </summary>
		protected RMethod r_MSaveBackup;
		public virtual RMethod RMSaveBackup
		{
			get
			{
				if(r_MSaveBackup == null)
				{
					r_MSaveBackup = new(this, "SaveBackup", 0);
				}
				return r_MSaveBackup;
			}
		}

		/// <summary>
		/// Void Undo()
		/// </summary>
		protected RMethod r_MUndo;
		public virtual RMethod RMUndo
		{
			get
			{
				if(r_MUndo == null)
				{
					r_MUndo = new(this, "Undo", 0);
				}
				return r_MUndo;
			}
		}

		/// <summary>
		/// Boolean Cut()
		/// </summary>
		protected RMethod r_MCut;
		public virtual RMethod RMCut
		{
			get
			{
				if(r_MCut == null)
				{
					r_MCut = new(this, "Cut", 0);
				}
				return r_MCut;
			}
		}

		/// <summary>
		/// Void Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] GetHyperlinksRect()
		/// </summary>
		protected RMethod r_MGetHyperlinksRect;
		public virtual RMethod RMGetHyperlinksRect
		{
			get
			{
				if(r_MGetHyperlinksRect == null)
				{
					r_MGetHyperlinksRect = new(this, "GetHyperlinksRect", 0);
				}
				return r_MGetHyperlinksRect;
			}
		}

		/// <summary>
		/// Boolean Paste()
		/// </summary>
		protected RMethod r_MPaste;
		public virtual RMethod RMPaste
		{
			get
			{
				if(r_MPaste == null)
				{
					r_MPaste = new(this, "Paste", 0);
				}
				return r_MPaste;
			}
		}

		/// <summary>
		/// Void DetectFocusChange()
		/// </summary>
		protected RMethod r_MDetectFocusChange;
		public virtual RMethod RMDetectFocusChange
		{
			get
			{
				if(r_MDetectFocusChange == null)
				{
					r_MDetectFocusChange = new(this, "DetectFocusChange", 0);
				}
				return r_MDetectFocusChange;
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


        public virtual void OnDetectFocusChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDetectFocusChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnCursorIndexChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnCursorIndexChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSelectIndexChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnSelectIndexChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HandleKeyEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMHandleKeyEvent_Event.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HandleKeyEvent(UnityEngine.Event @e, System.Boolean @textIsReadOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @textIsReadOnly};
            var ___result = RMHandleKeyEvent_Event_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean DeleteLineBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteLineBack.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean DeleteWordBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteWordBack.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean DeleteWordForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteWordForward.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Delete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDelete.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean CanPaste()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanPaste.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Backspace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBackspace.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SelectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectNone.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DeleteSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteSelection.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ReplaceSelection(System.String @replace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replace};
            var ___result = RMReplaceSelection_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMInsert_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveSelectionToAltCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveSelectionToAltCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveGraphicalLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveGraphicalLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveGraphicalLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveGraphicalLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTextStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveTextStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveTextEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveParagraphForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveParagraphForward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveParagraphBackward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveParagraphBackward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveCursorToPosition(UnityEngine.Vector2 @cursorPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition};
            var ___result = RMMoveCursorToPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveCursorToPosition_Internal(UnityEngine.Vector2 @cursorPosition, System.Boolean @shift)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition, @shift};
            var ___result = RMMoveCursorToPosition_Internal_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveAltCursorToPosition(UnityEngine.Vector2 @cursorPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition};
            var ___result = RMMoveAltCursorToPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsOverSelection(UnityEngine.Vector2 @cursorPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition};
            var ___result = RMIsOverSelection_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SelectToPosition(UnityEngine.Vector2 @cursorPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition};
            var ___result = RMSelectToPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectTextEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectTextStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectTextStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MouseDragSelectsWholeWords(System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@on};
            var ___result = RMMouseDragSelectsWholeWords_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DblClickSnap(Hvak.Editor.Refleaction.RUnityEngine.RTextEditor.RDblClickSnapping @snapping)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapping.Value};
            var ___result = RMDblClickSnap_DblClickSnapping.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveWordRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveWordRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveToStartOfNextWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveToStartOfNextWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveToEndOfPreviousWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveToEndOfPreviousWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectToStartOfNextWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectToStartOfNextWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectToEndOfPreviousWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectToEndOfPreviousWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindStartOfNextWord(System.Int32 @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RMFindStartOfNextWord_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void MoveWordLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveWordLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectWordRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectWordRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectWordLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectWordLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExpandSelectGraphicalLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExpandSelectGraphicalLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExpandSelectGraphicalLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExpandSelectGraphicalLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectGraphicalLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectGraphicalLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectGraphicalLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectGraphicalLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectParagraphForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectParagraphForward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectParagraphBackward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectParagraphBackward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectCurrentWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectCurrentWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectCurrentParagraph()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectCurrentParagraph.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateScrollOffsetIfNeeded(UnityEngine.Event @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMUpdateScrollOffsetIfNeeded_Event.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateScrollOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateScrollOffset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawCursor(System.String @newText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newText};
            var ___result = RMDrawCursor_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveBackup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveBackup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Undo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUndo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Cut()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCut.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect[] GetHyperlinksRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHyperlinksRect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect[]>(___result);
        }


        public virtual System.Boolean Paste()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPaste.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void DetectFocusChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDetectFocusChange.Invoke(___genericsType, ___parameters);

            
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
