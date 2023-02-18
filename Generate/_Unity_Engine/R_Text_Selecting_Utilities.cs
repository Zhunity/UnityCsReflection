
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextSelectingUtilities
	/// </summary>
    public partial class RTextSelectingUtilities : RMember //
    {

		/// <summary>
		/// UnityEngine.TextEditor+DblClickSnapping dblClickSnap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextEditor.RDblClickSnapping r_FdblClickSnap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextEditor.RDblClickSnapping RFdblClickSnap
		{
			get
			{
				if(r_FdblClickSnap == null)
				{
					r_FdblClickSnap = new(this, "dblClickSnap");
					r_FdblClickSnap.SetBelong(this.GetValue());
				}
				return r_FdblClickSnap;
			}
		}

		/// <summary>
		/// System.Int32 iAltCursorPos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FiAltCursorPos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFiAltCursorPos
		{
			get
			{
				if(r_FiAltCursorPos == null)
				{
					r_FiAltCursorPos = new(this, "iAltCursorPos");
					r_FiAltCursorPos.SetBelong(this.GetValue());
				}
				return r_FiAltCursorPos;
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
					r_FhasHorizontalCursorPos.SetBelong(this.GetValue());
				}
				return r_FhasHorizontalCursorPos;
			}
		}

		/// <summary>
		/// System.Boolean m_bJustSelected
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_bJustSelected;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_bJustSelected
		{
			get
			{
				if(r_Fm_bJustSelected == null)
				{
					r_Fm_bJustSelected = new(this, "m_bJustSelected");
					r_Fm_bJustSelected.SetBelong(this.GetValue());
				}
				return r_Fm_bJustSelected;
			}
		}

		/// <summary>
		/// System.Boolean m_MouseDragSelectsWholeWords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_MouseDragSelectsWholeWords;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_MouseDragSelectsWholeWords
		{
			get
			{
				if(r_Fm_MouseDragSelectsWholeWords == null)
				{
					r_Fm_MouseDragSelectsWholeWords = new(this, "m_MouseDragSelectsWholeWords");
					r_Fm_MouseDragSelectsWholeWords.SetBelong(this.GetValue());
				}
				return r_Fm_MouseDragSelectsWholeWords;
			}
		}

		/// <summary>
		/// System.Int32 m_DblClickInitPos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DblClickInitPos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DblClickInitPos
		{
			get
			{
				if(r_Fm_DblClickInitPos == null)
				{
					r_Fm_DblClickInitPos = new(this, "m_DblClickInitPos");
					r_Fm_DblClickInitPos.SetBelong(this.GetValue());
				}
				return r_Fm_DblClickInitPos;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextHandle m_TextHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextHandle r_Fm_TextHandle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextHandle RFm_TextHandle
		{
			get
			{
				if(r_Fm_TextHandle == null)
				{
					r_Fm_TextHandle = new(this, "m_TextHandle");
					r_Fm_TextHandle.SetBelong(this.GetValue());
				}
				return r_Fm_TextHandle;
			}
		}

		/// <summary>
		/// System.Int32 kMoveDownHeight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FkMoveDownHeight;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFkMoveDownHeight
		{
			get
			{
				if(r_FkMoveDownHeight == null)
				{
					r_FkMoveDownHeight = new( ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities"), "kMoveDownHeight");
					r_FkMoveDownHeight.SetBelong(null);
				}
				return r_FkMoveDownHeight;
			}
		}

		/// <summary>
		/// System.Char kNewLineChar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RChar r_FkNewLineChar;
		public static Hvak.Editor.Refleaction.RSystem.RChar RFkNewLineChar
		{
			get
			{
				if(r_FkNewLineChar == null)
				{
					r_FkNewLineChar = new( ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities"), "kNewLineChar");
					r_FkNewLineChar.SetBelong(null);
				}
				return r_FkNewLineChar;
			}
		}

		/// <summary>
		/// System.Boolean m_RevealCursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_RevealCursor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_RevealCursor
		{
			get
			{
				if(r_Fm_RevealCursor == null)
				{
					r_Fm_RevealCursor = new(this, "m_RevealCursor");
					r_Fm_RevealCursor.SetBelong(this.GetValue());
				}
				return r_Fm_RevealCursor;
			}
		}

		/// <summary>
		/// System.Int32 m_CursorIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CursorIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CursorIndex
		{
			get
			{
				if(r_Fm_CursorIndex == null)
				{
					r_Fm_CursorIndex = new(this, "m_CursorIndex");
					r_Fm_CursorIndex.SetBelong(this.GetValue());
				}
				return r_Fm_CursorIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_SelectIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_SelectIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_SelectIndex
		{
			get
			{
				if(r_Fm_SelectIndex == null)
				{
					r_Fm_SelectIndex = new(this, "m_SelectIndex");
					r_Fm_SelectIndex.SetBelong(this.GetValue());
				}
				return r_Fm_SelectIndex;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.Event,UnityEngine.TextSelectOp] s_KeySelectOps
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.REvent, Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp> r_Fs_KeySelectOps;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.REvent, Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp> RFs_KeySelectOps
		{
			get
			{
				if(r_Fs_KeySelectOps == null)
				{
					r_Fs_KeySelectOps = new( ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities"), "s_KeySelectOps");
					r_Fs_KeySelectOps.SetBelong(null);
				}
				return r_Fs_KeySelectOps;
			}
		}

		/// <summary>
		/// System.Action OnCursorIndexChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FOnCursorIndexChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFOnCursorIndexChange
		{
			get
			{
				if(r_FOnCursorIndexChange == null)
				{
					r_FOnCursorIndexChange = new(this, "OnCursorIndexChange");
					r_FOnCursorIndexChange.SetBelong(this.GetValue());
				}
				return r_FOnCursorIndexChange;
			}
		}

		/// <summary>
		/// System.Action OnSelectIndexChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FOnSelectIndexChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFOnSelectIndexChange
		{
			get
			{
				if(r_FOnSelectIndexChange == null)
				{
					r_FOnSelectIndexChange = new(this, "OnSelectIndexChange");
					r_FOnSelectIndexChange.SetBelong(this.GetValue());
				}
				return r_FOnSelectIndexChange;
			}
		}

		/// <summary>
		/// System.Action OnRevealCursorChange
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FOnRevealCursorChange;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFOnRevealCursorChange
		{
			get
			{
				if(r_FOnRevealCursorChange == null)
				{
					r_FOnRevealCursorChange = new(this, "OnRevealCursorChange");
					r_FOnRevealCursorChange.SetBelong(this.GetValue());
				}
				return r_FOnRevealCursorChange;
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
					r_PhasSelection.SetBelong(this.GetValue());
				}
				return r_PhasSelection;
			}
		}

		/// <summary>
		/// Boolean revealCursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PrevealCursor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPrevealCursor
		{
			get
			{
				if(r_PrevealCursor == null)
				{
					r_PrevealCursor = new(this, "revealCursor", -1);
					r_PrevealCursor.SetBelong(this.GetValue());
				}
				return r_PrevealCursor;
			}
		}

		/// <summary>
		/// Int32 m_CharacterCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pm_CharacterCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPm_CharacterCount
		{
			get
			{
				if(r_Pm_CharacterCount == null)
				{
					r_Pm_CharacterCount = new(this, "m_CharacterCount", -1);
					r_Pm_CharacterCount.SetBelong(this.GetValue());
				}
				return r_Pm_CharacterCount;
			}
		}

		/// <summary>
		/// Int32 characterCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcharacterCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcharacterCount
		{
			get
			{
				if(r_PcharacterCount == null)
				{
					r_PcharacterCount = new(this, "characterCount", -1);
					r_PcharacterCount.SetBelong(this.GetValue());
				}
				return r_PcharacterCount;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementInfo[] m_TextElementInfos
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementInfo> r_Pm_TextElementInfos;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementInfo> RPm_TextElementInfos
		{
			get
			{
				if(r_Pm_TextElementInfos == null)
				{
					r_Pm_TextElementInfos = new(this, "m_TextElementInfos", -1);
					r_Pm_TextElementInfos.SetBelong(this.GetValue());
				}
				return r_Pm_TextElementInfos;
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
					r_PcursorIndex.SetBelong(this.GetValue());
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
					r_PselectIndex.SetBelong(this.GetValue());
				}
				return r_PselectIndex;
			}
		}

		/// <summary>
		/// System.String selectedText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PselectedText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPselectedText
		{
			get
			{
				if(r_PselectedText == null)
				{
					r_PselectedText = new(this, "selectedText", -1);
					r_PselectedText.SetBelong(this.GetValue());
				}
				return r_PselectedText;
			}
		}

		/// <summary>
		/// Void SetCursorIndexWithoutNotify(Int32)
		/// </summary>
		protected RMethod r_MSetCursorIndexWithoutNotify_Int32;
		public virtual RMethod RMSetCursorIndexWithoutNotify_Int32
		{
			get
			{
				if(r_MSetCursorIndexWithoutNotify_Int32 == null)
				{
					r_MSetCursorIndexWithoutNotify_Int32 = new(this, "SetCursorIndexWithoutNotify", 0, typeof(System.Int32));
					r_MSetCursorIndexWithoutNotify_Int32.SetBelong(this.GetValue());
				}
				return r_MSetCursorIndexWithoutNotify_Int32;
			}
		}

		/// <summary>
		/// Void SetSelectIndexWithoutNotify(Int32)
		/// </summary>
		protected RMethod r_MSetSelectIndexWithoutNotify_Int32;
		public virtual RMethod RMSetSelectIndexWithoutNotify_Int32
		{
			get
			{
				if(r_MSetSelectIndexWithoutNotify_Int32 == null)
				{
					r_MSetSelectIndexWithoutNotify_Int32 = new(this, "SetSelectIndexWithoutNotify", 0, typeof(System.Int32));
					r_MSetSelectIndexWithoutNotify_Int32.SetBelong(this.GetValue());
				}
				return r_MSetSelectIndexWithoutNotify_Int32;
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
					r_MHandleKeyEvent_Event.SetBelong(this.GetValue());
				}
				return r_MHandleKeyEvent_Event;
			}
		}

		/// <summary>
		/// Boolean PerformOperation(UnityEngine.TextSelectOp)
		/// </summary>
		protected RMethod r_MPerformOperation_TextSelectOp;
		public virtual RMethod RMPerformOperation_TextSelectOp
		{
			get
			{
				if(r_MPerformOperation_TextSelectOp == null)
				{
					r_MPerformOperation_TextSelectOp = new(this, "PerformOperation", 0,  ReflectionUtils.GetType("UnityEngine.TextSelectOp"));
					r_MPerformOperation_TextSelectOp.SetBelong(this.GetValue());
				}
				return r_MPerformOperation_TextSelectOp;
			}
		}

		/// <summary>
		/// Void MapKey(System.String, UnityEngine.TextSelectOp)
		/// </summary>
		protected static RMethod r_MMapKey_String_TextSelectOp;
		public static RMethod RMMapKey_String_TextSelectOp
		{
			get
			{
				if(r_MMapKey_String_TextSelectOp == null)
				{
					r_MMapKey_String_TextSelectOp = new( ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities"), "MapKey", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEngine.TextSelectOp"));
					r_MMapKey_String_TextSelectOp.SetBelong(null);
				}
				return r_MMapKey_String_TextSelectOp;
			}
		}

		/// <summary>
		/// Void InitKeyActions()
		/// </summary>
		protected RMethod r_MInitKeyActions;
		public virtual RMethod RMInitKeyActions
		{
			get
			{
				if(r_MInitKeyActions == null)
				{
					r_MInitKeyActions = new(this, "InitKeyActions", 0);
					r_MInitKeyActions.SetBelong(this.GetValue());
				}
				return r_MInitKeyActions;
			}
		}

		/// <summary>
		/// Void ClearCursorPos()
		/// </summary>
		protected RMethod r_MClearCursorPos;
		public virtual RMethod RMClearCursorPos
		{
			get
			{
				if(r_MClearCursorPos == null)
				{
					r_MClearCursorPos = new(this, "ClearCursorPos", 0);
					r_MClearCursorPos.SetBelong(this.GetValue());
				}
				return r_MClearCursorPos;
			}
		}

		/// <summary>
		/// Void OnFocus(Boolean)
		/// </summary>
		protected RMethod r_MOnFocus_Boolean;
		public virtual RMethod RMOnFocus_Boolean
		{
			get
			{
				if(r_MOnFocus_Boolean == null)
				{
					r_MOnFocus_Boolean = new(this, "OnFocus", 0, typeof(System.Boolean));
					r_MOnFocus_Boolean.SetBelong(this.GetValue());
				}
				return r_MOnFocus_Boolean;
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
					r_MSelectAll.SetBelong(this.GetValue());
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
					r_MSelectNone.SetBelong(this.GetValue());
				}
				return r_MSelectNone;
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
					r_MSelectLeft.SetBelong(this.GetValue());
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
					r_MSelectRight.SetBelong(this.GetValue());
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
					r_MSelectUp.SetBelong(this.GetValue());
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
					r_MSelectDown.SetBelong(this.GetValue());
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
					r_MSelectTextEnd.SetBelong(this.GetValue());
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
					r_MSelectTextStart.SetBelong(this.GetValue());
				}
				return r_MSelectTextStart;
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
					r_MSelectToStartOfNextWord.SetBelong(this.GetValue());
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
					r_MSelectToEndOfPreviousWord.SetBelong(this.GetValue());
				}
				return r_MSelectToEndOfPreviousWord;
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
					r_MSelectWordRight.SetBelong(this.GetValue());
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
					r_MSelectWordLeft.SetBelong(this.GetValue());
				}
				return r_MSelectWordLeft;
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
					r_MSelectGraphicalLineStart.SetBelong(this.GetValue());
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
					r_MSelectGraphicalLineEnd.SetBelong(this.GetValue());
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
					r_MSelectParagraphForward.SetBelong(this.GetValue());
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
					r_MSelectParagraphBackward.SetBelong(this.GetValue());
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
					r_MSelectCurrentWord.SetBelong(this.GetValue());
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
					r_MSelectCurrentParagraph.SetBelong(this.GetValue());
				}
				return r_MSelectCurrentParagraph;
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
					r_MMoveRight.SetBelong(this.GetValue());
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
					r_MMoveLeft.SetBelong(this.GetValue());
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
					r_MMoveUp.SetBelong(this.GetValue());
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
					r_MMoveDown.SetBelong(this.GetValue());
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
					r_MMoveLineStart.SetBelong(this.GetValue());
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
					r_MMoveLineEnd.SetBelong(this.GetValue());
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
					r_MMoveGraphicalLineStart.SetBelong(this.GetValue());
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
					r_MMoveGraphicalLineEnd.SetBelong(this.GetValue());
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
					r_MMoveTextStart.SetBelong(this.GetValue());
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
					r_MMoveTextEnd.SetBelong(this.GetValue());
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
					r_MMoveParagraphForward.SetBelong(this.GetValue());
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
					r_MMoveParagraphBackward.SetBelong(this.GetValue());
				}
				return r_MMoveParagraphBackward;
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
					r_MMoveWordRight.SetBelong(this.GetValue());
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
					r_MMoveToStartOfNextWord.SetBelong(this.GetValue());
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
					r_MMoveToEndOfPreviousWord.SetBelong(this.GetValue());
				}
				return r_MMoveToEndOfPreviousWord;
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
					r_MMoveWordLeft.SetBelong(this.GetValue());
				}
				return r_MMoveWordLeft;
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
					r_MMouseDragSelectsWholeWords_Boolean.SetBelong(this.GetValue());
				}
				return r_MMouseDragSelectsWholeWords_Boolean;
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
					r_MExpandSelectGraphicalLineStart.SetBelong(this.GetValue());
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
					r_MExpandSelectGraphicalLineEnd.SetBelong(this.GetValue());
				}
				return r_MExpandSelectGraphicalLineEnd;
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
					r_MDblClickSnap_DblClickSnapping.SetBelong(this.GetValue());
				}
				return r_MDblClickSnap_DblClickSnapping;
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
					r_MMoveCursorToPosition_Internal_Vector2_Boolean.SetBelong(this.GetValue());
				}
				return r_MMoveCursorToPosition_Internal_Vector2_Boolean;
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
					r_MSelectToPosition_Vector2.SetBelong(this.GetValue());
				}
				return r_MSelectToPosition_Vector2;
			}
		}

		/// <summary>
		/// Int32 FindNextSeperator(Int32)
		/// </summary>
		protected RMethod r_MFindNextSeperator_Int32;
		public virtual RMethod RMFindNextSeperator_Int32
		{
			get
			{
				if(r_MFindNextSeperator_Int32 == null)
				{
					r_MFindNextSeperator_Int32 = new(this, "FindNextSeperator", 0, typeof(System.Int32));
					r_MFindNextSeperator_Int32.SetBelong(this.GetValue());
				}
				return r_MFindNextSeperator_Int32;
			}
		}

		/// <summary>
		/// Int32 FindPrevSeperator(Int32)
		/// </summary>
		protected RMethod r_MFindPrevSeperator_Int32;
		public virtual RMethod RMFindPrevSeperator_Int32
		{
			get
			{
				if(r_MFindPrevSeperator_Int32 == null)
				{
					r_MFindPrevSeperator_Int32 = new(this, "FindPrevSeperator", 0, typeof(System.Int32));
					r_MFindPrevSeperator_Int32.SetBelong(this.GetValue());
				}
				return r_MFindPrevSeperator_Int32;
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
					r_MFindStartOfNextWord_Int32.SetBelong(this.GetValue());
				}
				return r_MFindStartOfNextWord_Int32;
			}
		}

		/// <summary>
		/// Int32 FindEndOfPreviousWord(Int32)
		/// </summary>
		protected RMethod r_MFindEndOfPreviousWord_Int32;
		public virtual RMethod RMFindEndOfPreviousWord_Int32
		{
			get
			{
				if(r_MFindEndOfPreviousWord_Int32 == null)
				{
					r_MFindEndOfPreviousWord_Int32 = new(this, "FindEndOfPreviousWord", 0, typeof(System.Int32));
					r_MFindEndOfPreviousWord_Int32.SetBelong(this.GetValue());
				}
				return r_MFindEndOfPreviousWord_Int32;
			}
		}

		/// <summary>
		/// Int32 FindEndOfClassification(Int32, Direction)
		/// </summary>
		protected RMethod r_MFindEndOfClassification_Int32_Direction;
		public virtual RMethod RMFindEndOfClassification_Int32_Direction
		{
			get
			{
				if(r_MFindEndOfClassification_Int32_Direction == null)
				{
					r_MFindEndOfClassification_Int32_Direction = new(this, "FindEndOfClassification", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities+Direction"));
					r_MFindEndOfClassification_Int32_Direction.SetBelong(this.GetValue());
				}
				return r_MFindEndOfClassification_Int32_Direction;
			}
		}

		/// <summary>
		/// Int32 ClampTextIndex(Int32)
		/// </summary>
		protected RMethod r_MClampTextIndex_Int32;
		public virtual RMethod RMClampTextIndex_Int32
		{
			get
			{
				if(r_MClampTextIndex_Int32 == null)
				{
					r_MClampTextIndex_Int32 = new(this, "ClampTextIndex", 0, typeof(System.Int32));
					r_MClampTextIndex_Int32.SetBelong(this.GetValue());
				}
				return r_MClampTextIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 EnsureValidCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_MEnsureValidCodePointIndex_Int32;
		public virtual RMethod RMEnsureValidCodePointIndex_Int32
		{
			get
			{
				if(r_MEnsureValidCodePointIndex_Int32 == null)
				{
					r_MEnsureValidCodePointIndex_Int32 = new(this, "EnsureValidCodePointIndex", 0, typeof(System.Int32));
					r_MEnsureValidCodePointIndex_Int32.SetBelong(this.GetValue());
				}
				return r_MEnsureValidCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_MIsValidCodePointIndex_Int32;
		public virtual RMethod RMIsValidCodePointIndex_Int32
		{
			get
			{
				if(r_MIsValidCodePointIndex_Int32 == null)
				{
					r_MIsValidCodePointIndex_Int32 = new(this, "IsValidCodePointIndex", 0, typeof(System.Int32));
					r_MIsValidCodePointIndex_Int32.SetBelong(this.GetValue());
				}
				return r_MIsValidCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfEndOfLine(Int32)
		/// </summary>
		protected RMethod r_MIndexOfEndOfLine_Int32;
		public virtual RMethod RMIndexOfEndOfLine_Int32
		{
			get
			{
				if(r_MIndexOfEndOfLine_Int32 == null)
				{
					r_MIndexOfEndOfLine_Int32 = new(this, "IndexOfEndOfLine", 0, typeof(System.Int32));
					r_MIndexOfEndOfLine_Int32.SetBelong(this.GetValue());
				}
				return r_MIndexOfEndOfLine_Int32;
			}
		}

		/// <summary>
		/// Int32 PreviousCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_MPreviousCodePointIndex_Int32;
		public virtual RMethod RMPreviousCodePointIndex_Int32
		{
			get
			{
				if(r_MPreviousCodePointIndex_Int32 == null)
				{
					r_MPreviousCodePointIndex_Int32 = new(this, "PreviousCodePointIndex", 0, typeof(System.Int32));
					r_MPreviousCodePointIndex_Int32.SetBelong(this.GetValue());
				}
				return r_MPreviousCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 NextCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_MNextCodePointIndex_Int32;
		public virtual RMethod RMNextCodePointIndex_Int32
		{
			get
			{
				if(r_MNextCodePointIndex_Int32 == null)
				{
					r_MNextCodePointIndex_Int32 = new(this, "NextCodePointIndex", 0, typeof(System.Int32));
					r_MNextCodePointIndex_Int32.SetBelong(this.GetValue());
				}
				return r_MNextCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGraphicalLineStart(Int32)
		/// </summary>
		protected RMethod r_MGetGraphicalLineStart_Int32;
		public virtual RMethod RMGetGraphicalLineStart_Int32
		{
			get
			{
				if(r_MGetGraphicalLineStart_Int32 == null)
				{
					r_MGetGraphicalLineStart_Int32 = new(this, "GetGraphicalLineStart", 0, typeof(System.Int32));
					r_MGetGraphicalLineStart_Int32.SetBelong(this.GetValue());
				}
				return r_MGetGraphicalLineStart_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGraphicalLineEnd(Int32)
		/// </summary>
		protected RMethod r_MGetGraphicalLineEnd_Int32;
		public virtual RMethod RMGetGraphicalLineEnd_Int32
		{
			get
			{
				if(r_MGetGraphicalLineEnd_Int32 == null)
				{
					r_MGetGraphicalLineEnd_Int32 = new(this, "GetGraphicalLineEnd", 0, typeof(System.Int32));
					r_MGetGraphicalLineEnd_Int32.SetBelong(this.GetValue());
				}
				return r_MGetGraphicalLineEnd_Int32;
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
					r_MCopy.SetBelong(this.GetValue());
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// CharacterType ClassifyChar(Int32)
		/// </summary>
		protected RMethod r_MClassifyChar_Int32;
		public virtual RMethod RMClassifyChar_Int32
		{
			get
			{
				if(r_MClassifyChar_Int32 == null)
				{
					r_MClassifyChar_Int32 = new(this, "ClassifyChar", 0, typeof(System.Int32));
					r_MClassifyChar_Int32.SetBelong(this.GetValue());
				}
				return r_MClassifyChar_Int32;
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


        public RTextSelectingUtilities() : base("UnityEngine.TextSelectingUtilities")
        {
        }

        public RTextSelectingUtilities(System.Object instance) : base("UnityEngine.TextSelectingUtilities")
		{
            SetInstance(instance);
		}

        public RTextSelectingUtilities(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextSelectingUtilities(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetCursorIndexWithoutNotify(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSetCursorIndexWithoutNotify_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectIndexWithoutNotify(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMSetSelectIndexWithoutNotify_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HandleKeyEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMHandleKeyEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean PerformOperation(Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMPerformOperation_TextSelectOp.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void MapKey(System.String @key, Hvak.Editor.Refleaction.RUnityEngine.RTextSelectOp @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @action.Value};
            var ___result = RMMapKey_String_TextSelectOp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitKeyActions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitKeyActions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCursorPos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCursorPos.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocus(System.Boolean @selectAll)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selectAll};
            var ___result = RMOnFocus_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void MoveWordLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveWordLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MouseDragSelectsWholeWords(System.Boolean @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@on};
            var ___result = RMMouseDragSelectsWholeWords_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DblClickSnap(Hvak.Editor.Refleaction.RUnityEngine.RTextEditor.RDblClickSnapping @snapping)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snapping.Value};
            var ___result = RMDblClickSnap_DblClickSnapping.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveCursorToPosition_Internal(UnityEngine.Vector2 @cursorPosition, System.Boolean @shift)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition, @shift};
            var ___result = RMMoveCursorToPosition_Internal_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectToPosition(UnityEngine.Vector2 @cursorPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition};
            var ___result = RMSelectToPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindNextSeperator(System.Int32 @startPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos};
            var ___result = RMFindNextSeperator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindPrevSeperator(System.Int32 @startPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos};
            var ___result = RMFindPrevSeperator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindStartOfNextWord(System.Int32 @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RMFindStartOfNextWord_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindEndOfPreviousWord(System.Int32 @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RMFindEndOfPreviousWord_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindEndOfClassification(System.Int32 @p, Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities.RDirection @dir)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p, @dir.Value};
            var ___result = RMFindEndOfClassification_Int32_Direction.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ClampTextIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMClampTextIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 EnsureValidCodePointIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMEnsureValidCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsValidCodePointIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMIsValidCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOfEndOfLine(System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RMIndexOfEndOfLine_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 PreviousCodePointIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMPreviousCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 NextCodePointIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMNextCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetGraphicalLineStart(System.Int32 @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RMGetGraphicalLineStart_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetGraphicalLineEnd(System.Int32 @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RMGetGraphicalLineEnd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities.RCharacterType ClassifyChar(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMClassifyChar_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities.RCharacterType(___result);
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
