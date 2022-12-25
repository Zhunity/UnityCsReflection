using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextSelectingUtilities
	/// </summary>
    public partial class RTextSelectingUtilities : RMember //
    {

		/// <summary>
		/// UnityEngine.TextEditor+DblClickSnapping dblClickSnap
		/// </summary>
		protected RField r_dblClickSnap;
		public virtual RField RdblClickSnap
		{
			get
			{
				if(r_dblClickSnap == null)
				{
					r_dblClickSnap = new(this, "dblClickSnap");
					r_dblClickSnap.SetBelong(this.instance);
				}
				return r_dblClickSnap;
			}
		}

		/// <summary>
		/// System.Int32 iAltCursorPos
		/// </summary>
		protected RField r_iAltCursorPos;
		public virtual RField RiAltCursorPos
		{
			get
			{
				if(r_iAltCursorPos == null)
				{
					r_iAltCursorPos = new(this, "iAltCursorPos");
					r_iAltCursorPos.SetBelong(this.instance);
				}
				return r_iAltCursorPos;
			}
		}

		/// <summary>
		/// System.Boolean hasHorizontalCursorPos
		/// </summary>
		protected RField r_hasHorizontalCursorPos;
		public virtual RField RhasHorizontalCursorPos
		{
			get
			{
				if(r_hasHorizontalCursorPos == null)
				{
					r_hasHorizontalCursorPos = new(this, "hasHorizontalCursorPos");
					r_hasHorizontalCursorPos.SetBelong(this.instance);
				}
				return r_hasHorizontalCursorPos;
			}
		}

		/// <summary>
		/// System.Boolean m_bJustSelected
		/// </summary>
		protected RField r_m_bJustSelected;
		public virtual RField Rm_bJustSelected
		{
			get
			{
				if(r_m_bJustSelected == null)
				{
					r_m_bJustSelected = new(this, "m_bJustSelected");
					r_m_bJustSelected.SetBelong(this.instance);
				}
				return r_m_bJustSelected;
			}
		}

		/// <summary>
		/// System.Boolean m_MouseDragSelectsWholeWords
		/// </summary>
		protected RField r_m_MouseDragSelectsWholeWords;
		public virtual RField Rm_MouseDragSelectsWholeWords
		{
			get
			{
				if(r_m_MouseDragSelectsWholeWords == null)
				{
					r_m_MouseDragSelectsWholeWords = new(this, "m_MouseDragSelectsWholeWords");
					r_m_MouseDragSelectsWholeWords.SetBelong(this.instance);
				}
				return r_m_MouseDragSelectsWholeWords;
			}
		}

		/// <summary>
		/// System.Int32 m_DblClickInitPos
		/// </summary>
		protected RField r_m_DblClickInitPos;
		public virtual RField Rm_DblClickInitPos
		{
			get
			{
				if(r_m_DblClickInitPos == null)
				{
					r_m_DblClickInitPos = new(this, "m_DblClickInitPos");
					r_m_DblClickInitPos.SetBelong(this.instance);
				}
				return r_m_DblClickInitPos;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextHandle m_TextHandle
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextHandle r_m_TextHandle;
		public virtual RUnityEngine.RTextCore.RText.RTextHandle Rm_TextHandle
		{
			get
			{
				if(r_m_TextHandle == null)
				{
					r_m_TextHandle = new(this, "m_TextHandle");
					r_m_TextHandle.SetBelong(this.instance);
				}
				return r_m_TextHandle;
			}
		}

		/// <summary>
		/// System.Int32 kMoveDownHeight
		/// </summary>
		protected static RField r_kMoveDownHeight;
		public static RField RkMoveDownHeight
		{
			get
			{
				if(r_kMoveDownHeight == null)
				{
					r_kMoveDownHeight = new( ReleactionUtils.GetType("UnityEngine.TextSelectingUtilities"), "kMoveDownHeight");
					r_kMoveDownHeight.SetBelong(null);
				}
				return r_kMoveDownHeight;
			}
		}

		/// <summary>
		/// System.Char kNewLineChar
		/// </summary>
		protected static RField r_kNewLineChar;
		public static RField RkNewLineChar
		{
			get
			{
				if(r_kNewLineChar == null)
				{
					r_kNewLineChar = new( ReleactionUtils.GetType("UnityEngine.TextSelectingUtilities"), "kNewLineChar");
					r_kNewLineChar.SetBelong(null);
				}
				return r_kNewLineChar;
			}
		}

		/// <summary>
		/// System.Boolean m_RevealCursor
		/// </summary>
		protected RField r_m_RevealCursor;
		public virtual RField Rm_RevealCursor
		{
			get
			{
				if(r_m_RevealCursor == null)
				{
					r_m_RevealCursor = new(this, "m_RevealCursor");
					r_m_RevealCursor.SetBelong(this.instance);
				}
				return r_m_RevealCursor;
			}
		}

		/// <summary>
		/// System.Int32 m_CursorIndex
		/// </summary>
		protected RField r_m_CursorIndex;
		public virtual RField Rm_CursorIndex
		{
			get
			{
				if(r_m_CursorIndex == null)
				{
					r_m_CursorIndex = new(this, "m_CursorIndex");
					r_m_CursorIndex.SetBelong(this.instance);
				}
				return r_m_CursorIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_SelectIndex
		/// </summary>
		protected RField r_m_SelectIndex;
		public virtual RField Rm_SelectIndex
		{
			get
			{
				if(r_m_SelectIndex == null)
				{
					r_m_SelectIndex = new(this, "m_SelectIndex");
					r_m_SelectIndex.SetBelong(this.instance);
				}
				return r_m_SelectIndex;
			}
		}

		/// <summary>
		/// System.Action OnCursorIndexChange
		/// </summary>
		protected RSystem.RAction r_OnCursorIndexChange;
		public virtual RSystem.RAction ROnCursorIndexChange
		{
			get
			{
				if(r_OnCursorIndexChange == null)
				{
					r_OnCursorIndexChange = new(this, "OnCursorIndexChange");
					r_OnCursorIndexChange.SetBelong(this.instance);
				}
				return r_OnCursorIndexChange;
			}
		}

		/// <summary>
		/// System.Action OnSelectIndexChange
		/// </summary>
		protected RSystem.RAction r_OnSelectIndexChange;
		public virtual RSystem.RAction ROnSelectIndexChange
		{
			get
			{
				if(r_OnSelectIndexChange == null)
				{
					r_OnSelectIndexChange = new(this, "OnSelectIndexChange");
					r_OnSelectIndexChange.SetBelong(this.instance);
				}
				return r_OnSelectIndexChange;
			}
		}

		/// <summary>
		/// System.Action OnRevealCursorChange
		/// </summary>
		protected RSystem.RAction r_OnRevealCursorChange;
		public virtual RSystem.RAction ROnRevealCursorChange
		{
			get
			{
				if(r_OnRevealCursorChange == null)
				{
					r_OnRevealCursorChange = new(this, "OnRevealCursorChange");
					r_OnRevealCursorChange.SetBelong(this.instance);
				}
				return r_OnRevealCursorChange;
			}
		}

		/// <summary>
		/// Boolean hasSelection
		/// </summary>
		protected RProperty r_hasSelection;
		public virtual RProperty RhasSelection
		{
			get
			{
				if(r_hasSelection == null)
				{
					r_hasSelection = new(this, "hasSelection", -1);
					r_hasSelection.SetBelong(this.instance);
				}
				return r_hasSelection;
			}
		}

		/// <summary>
		/// Boolean revealCursor
		/// </summary>
		protected RProperty r_revealCursor;
		public virtual RProperty RrevealCursor
		{
			get
			{
				if(r_revealCursor == null)
				{
					r_revealCursor = new(this, "revealCursor", -1);
					r_revealCursor.SetBelong(this.instance);
				}
				return r_revealCursor;
			}
		}

		/// <summary>
		/// Int32 m_CharacterCount
		/// </summary>
		protected RProperty r_m_CharacterCount;
		public virtual RProperty Rm_CharacterCount
		{
			get
			{
				if(r_m_CharacterCount == null)
				{
					r_m_CharacterCount = new(this, "m_CharacterCount", -1);
					r_m_CharacterCount.SetBelong(this.instance);
				}
				return r_m_CharacterCount;
			}
		}

		/// <summary>
		/// Int32 characterCount
		/// </summary>
		protected RProperty r_characterCount;
		public virtual RProperty RcharacterCount
		{
			get
			{
				if(r_characterCount == null)
				{
					r_characterCount = new(this, "characterCount", -1);
					r_characterCount.SetBelong(this.instance);
				}
				return r_characterCount;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementInfo[] m_TextElementInfos
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTextCore.RText.RTextElementInfo> r_m_TextElementInfos;
		public virtual RPropertyArray<RUnityEngine.RTextCore.RText.RTextElementInfo> Rm_TextElementInfos
		{
			get
			{
				if(r_m_TextElementInfos == null)
				{
					r_m_TextElementInfos = new(this, "m_TextElementInfos", -1);
					r_m_TextElementInfos.SetBelong(this.instance);
				}
				return r_m_TextElementInfos;
			}
		}

		/// <summary>
		/// Int32 cursorIndex
		/// </summary>
		protected RProperty r_cursorIndex;
		public virtual RProperty RcursorIndex
		{
			get
			{
				if(r_cursorIndex == null)
				{
					r_cursorIndex = new(this, "cursorIndex", -1);
					r_cursorIndex.SetBelong(this.instance);
				}
				return r_cursorIndex;
			}
		}

		/// <summary>
		/// Int32 selectIndex
		/// </summary>
		protected RProperty r_selectIndex;
		public virtual RProperty RselectIndex
		{
			get
			{
				if(r_selectIndex == null)
				{
					r_selectIndex = new(this, "selectIndex", -1);
					r_selectIndex.SetBelong(this.instance);
				}
				return r_selectIndex;
			}
		}

		/// <summary>
		/// System.String selectedText
		/// </summary>
		protected RProperty r_selectedText;
		public virtual RProperty RselectedText
		{
			get
			{
				if(r_selectedText == null)
				{
					r_selectedText = new(this, "selectedText", -1);
					r_selectedText.SetBelong(this.instance);
				}
				return r_selectedText;
			}
		}

		/// <summary>
		/// Void SetCursorIndexWithoutNotify(Int32)
		/// </summary>
		protected RMethod r_RSetCursorIndexWithoutNotify_Int32;
		public virtual RMethod RSetCursorIndexWithoutNotify_Int32
		{
			get
			{
				if(r_RSetCursorIndexWithoutNotify_Int32 == null)
				{
					r_RSetCursorIndexWithoutNotify_Int32 = new(this, "SetCursorIndexWithoutNotify", 0, typeof(System.Int32));
					r_RSetCursorIndexWithoutNotify_Int32.SetBelong(this.instance);
				}
				return r_RSetCursorIndexWithoutNotify_Int32;
			}
		}

		/// <summary>
		/// Void SetSelectIndexWithoutNotify(Int32)
		/// </summary>
		protected RMethod r_RSetSelectIndexWithoutNotify_Int32;
		public virtual RMethod RSetSelectIndexWithoutNotify_Int32
		{
			get
			{
				if(r_RSetSelectIndexWithoutNotify_Int32 == null)
				{
					r_RSetSelectIndexWithoutNotify_Int32 = new(this, "SetSelectIndexWithoutNotify", 0, typeof(System.Int32));
					r_RSetSelectIndexWithoutNotify_Int32.SetBelong(this.instance);
				}
				return r_RSetSelectIndexWithoutNotify_Int32;
			}
		}

		/// <summary>
		/// Void ClearCursorPos()
		/// </summary>
		protected RMethod r_RClearCursorPos;
		public virtual RMethod RClearCursorPos
		{
			get
			{
				if(r_RClearCursorPos == null)
				{
					r_RClearCursorPos = new(this, "ClearCursorPos", 0);
					r_RClearCursorPos.SetBelong(this.instance);
				}
				return r_RClearCursorPos;
			}
		}

		/// <summary>
		/// Void OnFocus(Boolean)
		/// </summary>
		protected RMethod r_ROnFocus_Boolean;
		public virtual RMethod ROnFocus_Boolean
		{
			get
			{
				if(r_ROnFocus_Boolean == null)
				{
					r_ROnFocus_Boolean = new(this, "OnFocus", 0, typeof(System.Boolean));
					r_ROnFocus_Boolean.SetBelong(this.instance);
				}
				return r_ROnFocus_Boolean;
			}
		}

		/// <summary>
		/// Void SelectAll()
		/// </summary>
		protected RMethod r_RSelectAll;
		public virtual RMethod RSelectAll
		{
			get
			{
				if(r_RSelectAll == null)
				{
					r_RSelectAll = new(this, "SelectAll", 0);
					r_RSelectAll.SetBelong(this.instance);
				}
				return r_RSelectAll;
			}
		}

		/// <summary>
		/// Void SelectNone()
		/// </summary>
		protected RMethod r_RSelectNone;
		public virtual RMethod RSelectNone
		{
			get
			{
				if(r_RSelectNone == null)
				{
					r_RSelectNone = new(this, "SelectNone", 0);
					r_RSelectNone.SetBelong(this.instance);
				}
				return r_RSelectNone;
			}
		}

		/// <summary>
		/// Void SelectLeft()
		/// </summary>
		protected RMethod r_RSelectLeft;
		public virtual RMethod RSelectLeft
		{
			get
			{
				if(r_RSelectLeft == null)
				{
					r_RSelectLeft = new(this, "SelectLeft", 0);
					r_RSelectLeft.SetBelong(this.instance);
				}
				return r_RSelectLeft;
			}
		}

		/// <summary>
		/// Void SelectRight()
		/// </summary>
		protected RMethod r_RSelectRight;
		public virtual RMethod RSelectRight
		{
			get
			{
				if(r_RSelectRight == null)
				{
					r_RSelectRight = new(this, "SelectRight", 0);
					r_RSelectRight.SetBelong(this.instance);
				}
				return r_RSelectRight;
			}
		}

		/// <summary>
		/// Void SelectUp()
		/// </summary>
		protected RMethod r_RSelectUp;
		public virtual RMethod RSelectUp
		{
			get
			{
				if(r_RSelectUp == null)
				{
					r_RSelectUp = new(this, "SelectUp", 0);
					r_RSelectUp.SetBelong(this.instance);
				}
				return r_RSelectUp;
			}
		}

		/// <summary>
		/// Void SelectDown()
		/// </summary>
		protected RMethod r_RSelectDown;
		public virtual RMethod RSelectDown
		{
			get
			{
				if(r_RSelectDown == null)
				{
					r_RSelectDown = new(this, "SelectDown", 0);
					r_RSelectDown.SetBelong(this.instance);
				}
				return r_RSelectDown;
			}
		}

		/// <summary>
		/// Void SelectTextEnd()
		/// </summary>
		protected RMethod r_RSelectTextEnd;
		public virtual RMethod RSelectTextEnd
		{
			get
			{
				if(r_RSelectTextEnd == null)
				{
					r_RSelectTextEnd = new(this, "SelectTextEnd", 0);
					r_RSelectTextEnd.SetBelong(this.instance);
				}
				return r_RSelectTextEnd;
			}
		}

		/// <summary>
		/// Void SelectTextStart()
		/// </summary>
		protected RMethod r_RSelectTextStart;
		public virtual RMethod RSelectTextStart
		{
			get
			{
				if(r_RSelectTextStart == null)
				{
					r_RSelectTextStart = new(this, "SelectTextStart", 0);
					r_RSelectTextStart.SetBelong(this.instance);
				}
				return r_RSelectTextStart;
			}
		}

		/// <summary>
		/// Void SelectToStartOfNextWord()
		/// </summary>
		protected RMethod r_RSelectToStartOfNextWord;
		public virtual RMethod RSelectToStartOfNextWord
		{
			get
			{
				if(r_RSelectToStartOfNextWord == null)
				{
					r_RSelectToStartOfNextWord = new(this, "SelectToStartOfNextWord", 0);
					r_RSelectToStartOfNextWord.SetBelong(this.instance);
				}
				return r_RSelectToStartOfNextWord;
			}
		}

		/// <summary>
		/// Void SelectToEndOfPreviousWord()
		/// </summary>
		protected RMethod r_RSelectToEndOfPreviousWord;
		public virtual RMethod RSelectToEndOfPreviousWord
		{
			get
			{
				if(r_RSelectToEndOfPreviousWord == null)
				{
					r_RSelectToEndOfPreviousWord = new(this, "SelectToEndOfPreviousWord", 0);
					r_RSelectToEndOfPreviousWord.SetBelong(this.instance);
				}
				return r_RSelectToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// Void SelectWordRight()
		/// </summary>
		protected RMethod r_RSelectWordRight;
		public virtual RMethod RSelectWordRight
		{
			get
			{
				if(r_RSelectWordRight == null)
				{
					r_RSelectWordRight = new(this, "SelectWordRight", 0);
					r_RSelectWordRight.SetBelong(this.instance);
				}
				return r_RSelectWordRight;
			}
		}

		/// <summary>
		/// Void SelectWordLeft()
		/// </summary>
		protected RMethod r_RSelectWordLeft;
		public virtual RMethod RSelectWordLeft
		{
			get
			{
				if(r_RSelectWordLeft == null)
				{
					r_RSelectWordLeft = new(this, "SelectWordLeft", 0);
					r_RSelectWordLeft.SetBelong(this.instance);
				}
				return r_RSelectWordLeft;
			}
		}

		/// <summary>
		/// Void SelectGraphicalLineStart()
		/// </summary>
		protected RMethod r_RSelectGraphicalLineStart;
		public virtual RMethod RSelectGraphicalLineStart
		{
			get
			{
				if(r_RSelectGraphicalLineStart == null)
				{
					r_RSelectGraphicalLineStart = new(this, "SelectGraphicalLineStart", 0);
					r_RSelectGraphicalLineStart.SetBelong(this.instance);
				}
				return r_RSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void SelectGraphicalLineEnd()
		/// </summary>
		protected RMethod r_RSelectGraphicalLineEnd;
		public virtual RMethod RSelectGraphicalLineEnd
		{
			get
			{
				if(r_RSelectGraphicalLineEnd == null)
				{
					r_RSelectGraphicalLineEnd = new(this, "SelectGraphicalLineEnd", 0);
					r_RSelectGraphicalLineEnd.SetBelong(this.instance);
				}
				return r_RSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void SelectParagraphForward()
		/// </summary>
		protected RMethod r_RSelectParagraphForward;
		public virtual RMethod RSelectParagraphForward
		{
			get
			{
				if(r_RSelectParagraphForward == null)
				{
					r_RSelectParagraphForward = new(this, "SelectParagraphForward", 0);
					r_RSelectParagraphForward.SetBelong(this.instance);
				}
				return r_RSelectParagraphForward;
			}
		}

		/// <summary>
		/// Void SelectParagraphBackward()
		/// </summary>
		protected RMethod r_RSelectParagraphBackward;
		public virtual RMethod RSelectParagraphBackward
		{
			get
			{
				if(r_RSelectParagraphBackward == null)
				{
					r_RSelectParagraphBackward = new(this, "SelectParagraphBackward", 0);
					r_RSelectParagraphBackward.SetBelong(this.instance);
				}
				return r_RSelectParagraphBackward;
			}
		}

		/// <summary>
		/// Void SelectCurrentWord()
		/// </summary>
		protected RMethod r_RSelectCurrentWord;
		public virtual RMethod RSelectCurrentWord
		{
			get
			{
				if(r_RSelectCurrentWord == null)
				{
					r_RSelectCurrentWord = new(this, "SelectCurrentWord", 0);
					r_RSelectCurrentWord.SetBelong(this.instance);
				}
				return r_RSelectCurrentWord;
			}
		}

		/// <summary>
		/// Void SelectCurrentParagraph()
		/// </summary>
		protected RMethod r_RSelectCurrentParagraph;
		public virtual RMethod RSelectCurrentParagraph
		{
			get
			{
				if(r_RSelectCurrentParagraph == null)
				{
					r_RSelectCurrentParagraph = new(this, "SelectCurrentParagraph", 0);
					r_RSelectCurrentParagraph.SetBelong(this.instance);
				}
				return r_RSelectCurrentParagraph;
			}
		}

		/// <summary>
		/// Void MoveRight()
		/// </summary>
		protected RMethod r_RMoveRight;
		public virtual RMethod RMoveRight
		{
			get
			{
				if(r_RMoveRight == null)
				{
					r_RMoveRight = new(this, "MoveRight", 0);
					r_RMoveRight.SetBelong(this.instance);
				}
				return r_RMoveRight;
			}
		}

		/// <summary>
		/// Void MoveLeft()
		/// </summary>
		protected RMethod r_RMoveLeft;
		public virtual RMethod RMoveLeft
		{
			get
			{
				if(r_RMoveLeft == null)
				{
					r_RMoveLeft = new(this, "MoveLeft", 0);
					r_RMoveLeft.SetBelong(this.instance);
				}
				return r_RMoveLeft;
			}
		}

		/// <summary>
		/// Void MoveUp()
		/// </summary>
		protected RMethod r_RMoveUp;
		public virtual RMethod RMoveUp
		{
			get
			{
				if(r_RMoveUp == null)
				{
					r_RMoveUp = new(this, "MoveUp", 0);
					r_RMoveUp.SetBelong(this.instance);
				}
				return r_RMoveUp;
			}
		}

		/// <summary>
		/// Void MoveDown()
		/// </summary>
		protected RMethod r_RMoveDown;
		public virtual RMethod RMoveDown
		{
			get
			{
				if(r_RMoveDown == null)
				{
					r_RMoveDown = new(this, "MoveDown", 0);
					r_RMoveDown.SetBelong(this.instance);
				}
				return r_RMoveDown;
			}
		}

		/// <summary>
		/// Void MoveLineStart()
		/// </summary>
		protected RMethod r_RMoveLineStart;
		public virtual RMethod RMoveLineStart
		{
			get
			{
				if(r_RMoveLineStart == null)
				{
					r_RMoveLineStart = new(this, "MoveLineStart", 0);
					r_RMoveLineStart.SetBelong(this.instance);
				}
				return r_RMoveLineStart;
			}
		}

		/// <summary>
		/// Void MoveLineEnd()
		/// </summary>
		protected RMethod r_RMoveLineEnd;
		public virtual RMethod RMoveLineEnd
		{
			get
			{
				if(r_RMoveLineEnd == null)
				{
					r_RMoveLineEnd = new(this, "MoveLineEnd", 0);
					r_RMoveLineEnd.SetBelong(this.instance);
				}
				return r_RMoveLineEnd;
			}
		}

		/// <summary>
		/// Void MoveGraphicalLineStart()
		/// </summary>
		protected RMethod r_RMoveGraphicalLineStart;
		public virtual RMethod RMoveGraphicalLineStart
		{
			get
			{
				if(r_RMoveGraphicalLineStart == null)
				{
					r_RMoveGraphicalLineStart = new(this, "MoveGraphicalLineStart", 0);
					r_RMoveGraphicalLineStart.SetBelong(this.instance);
				}
				return r_RMoveGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void MoveGraphicalLineEnd()
		/// </summary>
		protected RMethod r_RMoveGraphicalLineEnd;
		public virtual RMethod RMoveGraphicalLineEnd
		{
			get
			{
				if(r_RMoveGraphicalLineEnd == null)
				{
					r_RMoveGraphicalLineEnd = new(this, "MoveGraphicalLineEnd", 0);
					r_RMoveGraphicalLineEnd.SetBelong(this.instance);
				}
				return r_RMoveGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void MoveTextStart()
		/// </summary>
		protected RMethod r_RMoveTextStart;
		public virtual RMethod RMoveTextStart
		{
			get
			{
				if(r_RMoveTextStart == null)
				{
					r_RMoveTextStart = new(this, "MoveTextStart", 0);
					r_RMoveTextStart.SetBelong(this.instance);
				}
				return r_RMoveTextStart;
			}
		}

		/// <summary>
		/// Void MoveTextEnd()
		/// </summary>
		protected RMethod r_RMoveTextEnd;
		public virtual RMethod RMoveTextEnd
		{
			get
			{
				if(r_RMoveTextEnd == null)
				{
					r_RMoveTextEnd = new(this, "MoveTextEnd", 0);
					r_RMoveTextEnd.SetBelong(this.instance);
				}
				return r_RMoveTextEnd;
			}
		}

		/// <summary>
		/// Void MoveParagraphForward()
		/// </summary>
		protected RMethod r_RMoveParagraphForward;
		public virtual RMethod RMoveParagraphForward
		{
			get
			{
				if(r_RMoveParagraphForward == null)
				{
					r_RMoveParagraphForward = new(this, "MoveParagraphForward", 0);
					r_RMoveParagraphForward.SetBelong(this.instance);
				}
				return r_RMoveParagraphForward;
			}
		}

		/// <summary>
		/// Void MoveParagraphBackward()
		/// </summary>
		protected RMethod r_RMoveParagraphBackward;
		public virtual RMethod RMoveParagraphBackward
		{
			get
			{
				if(r_RMoveParagraphBackward == null)
				{
					r_RMoveParagraphBackward = new(this, "MoveParagraphBackward", 0);
					r_RMoveParagraphBackward.SetBelong(this.instance);
				}
				return r_RMoveParagraphBackward;
			}
		}

		/// <summary>
		/// Void MoveWordRight()
		/// </summary>
		protected RMethod r_RMoveWordRight;
		public virtual RMethod RMoveWordRight
		{
			get
			{
				if(r_RMoveWordRight == null)
				{
					r_RMoveWordRight = new(this, "MoveWordRight", 0);
					r_RMoveWordRight.SetBelong(this.instance);
				}
				return r_RMoveWordRight;
			}
		}

		/// <summary>
		/// Void MoveToStartOfNextWord()
		/// </summary>
		protected RMethod r_RMoveToStartOfNextWord;
		public virtual RMethod RMoveToStartOfNextWord
		{
			get
			{
				if(r_RMoveToStartOfNextWord == null)
				{
					r_RMoveToStartOfNextWord = new(this, "MoveToStartOfNextWord", 0);
					r_RMoveToStartOfNextWord.SetBelong(this.instance);
				}
				return r_RMoveToStartOfNextWord;
			}
		}

		/// <summary>
		/// Void MoveToEndOfPreviousWord()
		/// </summary>
		protected RMethod r_RMoveToEndOfPreviousWord;
		public virtual RMethod RMoveToEndOfPreviousWord
		{
			get
			{
				if(r_RMoveToEndOfPreviousWord == null)
				{
					r_RMoveToEndOfPreviousWord = new(this, "MoveToEndOfPreviousWord", 0);
					r_RMoveToEndOfPreviousWord.SetBelong(this.instance);
				}
				return r_RMoveToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// Void MoveWordLeft()
		/// </summary>
		protected RMethod r_RMoveWordLeft;
		public virtual RMethod RMoveWordLeft
		{
			get
			{
				if(r_RMoveWordLeft == null)
				{
					r_RMoveWordLeft = new(this, "MoveWordLeft", 0);
					r_RMoveWordLeft.SetBelong(this.instance);
				}
				return r_RMoveWordLeft;
			}
		}

		/// <summary>
		/// Void MouseDragSelectsWholeWords(Boolean)
		/// </summary>
		protected RMethod r_RMouseDragSelectsWholeWords_Boolean;
		public virtual RMethod RMouseDragSelectsWholeWords_Boolean
		{
			get
			{
				if(r_RMouseDragSelectsWholeWords_Boolean == null)
				{
					r_RMouseDragSelectsWholeWords_Boolean = new(this, "MouseDragSelectsWholeWords", 0, typeof(System.Boolean));
					r_RMouseDragSelectsWholeWords_Boolean.SetBelong(this.instance);
				}
				return r_RMouseDragSelectsWholeWords_Boolean;
			}
		}

		/// <summary>
		/// Void ExpandSelectGraphicalLineStart()
		/// </summary>
		protected RMethod r_RExpandSelectGraphicalLineStart;
		public virtual RMethod RExpandSelectGraphicalLineStart
		{
			get
			{
				if(r_RExpandSelectGraphicalLineStart == null)
				{
					r_RExpandSelectGraphicalLineStart = new(this, "ExpandSelectGraphicalLineStart", 0);
					r_RExpandSelectGraphicalLineStart.SetBelong(this.instance);
				}
				return r_RExpandSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void ExpandSelectGraphicalLineEnd()
		/// </summary>
		protected RMethod r_RExpandSelectGraphicalLineEnd;
		public virtual RMethod RExpandSelectGraphicalLineEnd
		{
			get
			{
				if(r_RExpandSelectGraphicalLineEnd == null)
				{
					r_RExpandSelectGraphicalLineEnd = new(this, "ExpandSelectGraphicalLineEnd", 0);
					r_RExpandSelectGraphicalLineEnd.SetBelong(this.instance);
				}
				return r_RExpandSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void DblClickSnap(DblClickSnapping)
		/// </summary>
		protected RMethod r_RDblClickSnap_DblClickSnapping;
		public virtual RMethod RDblClickSnap_DblClickSnapping
		{
			get
			{
				if(r_RDblClickSnap_DblClickSnapping == null)
				{
					r_RDblClickSnap_DblClickSnapping = new(this, "DblClickSnap", 0,  ReleactionUtils.GetType("UnityEngine.TextEditor+DblClickSnapping"));
					r_RDblClickSnap_DblClickSnapping.SetBelong(this.instance);
				}
				return r_RDblClickSnap_DblClickSnapping;
			}
		}

		/// <summary>
		/// Void MoveCursorToPosition_Internal(UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_RMoveCursorToPosition_Internal_Vector2_Boolean;
		public virtual RMethod RMoveCursorToPosition_Internal_Vector2_Boolean
		{
			get
			{
				if(r_RMoveCursorToPosition_Internal_Vector2_Boolean == null)
				{
					r_RMoveCursorToPosition_Internal_Vector2_Boolean = new(this, "MoveCursorToPosition_Internal", 0, typeof(UnityEngine.Vector2), typeof(System.Boolean));
					r_RMoveCursorToPosition_Internal_Vector2_Boolean.SetBelong(this.instance);
				}
				return r_RMoveCursorToPosition_Internal_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Void SelectToPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSelectToPosition_Vector2;
		public virtual RMethod RSelectToPosition_Vector2
		{
			get
			{
				if(r_RSelectToPosition_Vector2 == null)
				{
					r_RSelectToPosition_Vector2 = new(this, "SelectToPosition", 0, typeof(UnityEngine.Vector2));
					r_RSelectToPosition_Vector2.SetBelong(this.instance);
				}
				return r_RSelectToPosition_Vector2;
			}
		}

		/// <summary>
		/// Int32 FindNextSeperator(Int32)
		/// </summary>
		protected RMethod r_RFindNextSeperator_Int32;
		public virtual RMethod RFindNextSeperator_Int32
		{
			get
			{
				if(r_RFindNextSeperator_Int32 == null)
				{
					r_RFindNextSeperator_Int32 = new(this, "FindNextSeperator", 0, typeof(System.Int32));
					r_RFindNextSeperator_Int32.SetBelong(this.instance);
				}
				return r_RFindNextSeperator_Int32;
			}
		}

		/// <summary>
		/// Int32 FindPrevSeperator(Int32)
		/// </summary>
		protected RMethod r_RFindPrevSeperator_Int32;
		public virtual RMethod RFindPrevSeperator_Int32
		{
			get
			{
				if(r_RFindPrevSeperator_Int32 == null)
				{
					r_RFindPrevSeperator_Int32 = new(this, "FindPrevSeperator", 0, typeof(System.Int32));
					r_RFindPrevSeperator_Int32.SetBelong(this.instance);
				}
				return r_RFindPrevSeperator_Int32;
			}
		}

		/// <summary>
		/// Int32 FindStartOfNextWord(Int32)
		/// </summary>
		protected RMethod r_RFindStartOfNextWord_Int32;
		public virtual RMethod RFindStartOfNextWord_Int32
		{
			get
			{
				if(r_RFindStartOfNextWord_Int32 == null)
				{
					r_RFindStartOfNextWord_Int32 = new(this, "FindStartOfNextWord", 0, typeof(System.Int32));
					r_RFindStartOfNextWord_Int32.SetBelong(this.instance);
				}
				return r_RFindStartOfNextWord_Int32;
			}
		}

		/// <summary>
		/// Int32 FindEndOfPreviousWord(Int32)
		/// </summary>
		protected RMethod r_RFindEndOfPreviousWord_Int32;
		public virtual RMethod RFindEndOfPreviousWord_Int32
		{
			get
			{
				if(r_RFindEndOfPreviousWord_Int32 == null)
				{
					r_RFindEndOfPreviousWord_Int32 = new(this, "FindEndOfPreviousWord", 0, typeof(System.Int32));
					r_RFindEndOfPreviousWord_Int32.SetBelong(this.instance);
				}
				return r_RFindEndOfPreviousWord_Int32;
			}
		}

		/// <summary>
		/// Int32 FindEndOfClassification(Int32, Direction)
		/// </summary>
		protected RMethod r_RFindEndOfClassification_Int32_Direction;
		public virtual RMethod RFindEndOfClassification_Int32_Direction
		{
			get
			{
				if(r_RFindEndOfClassification_Int32_Direction == null)
				{
					r_RFindEndOfClassification_Int32_Direction = new(this, "FindEndOfClassification", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.TextSelectingUtilities+Direction"));
					r_RFindEndOfClassification_Int32_Direction.SetBelong(this.instance);
				}
				return r_RFindEndOfClassification_Int32_Direction;
			}
		}

		/// <summary>
		/// Int32 ClampTextIndex(Int32)
		/// </summary>
		protected RMethod r_RClampTextIndex_Int32;
		public virtual RMethod RClampTextIndex_Int32
		{
			get
			{
				if(r_RClampTextIndex_Int32 == null)
				{
					r_RClampTextIndex_Int32 = new(this, "ClampTextIndex", 0, typeof(System.Int32));
					r_RClampTextIndex_Int32.SetBelong(this.instance);
				}
				return r_RClampTextIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 EnsureValidCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_REnsureValidCodePointIndex_Int32;
		public virtual RMethod REnsureValidCodePointIndex_Int32
		{
			get
			{
				if(r_REnsureValidCodePointIndex_Int32 == null)
				{
					r_REnsureValidCodePointIndex_Int32 = new(this, "EnsureValidCodePointIndex", 0, typeof(System.Int32));
					r_REnsureValidCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_REnsureValidCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_RIsValidCodePointIndex_Int32;
		public virtual RMethod RIsValidCodePointIndex_Int32
		{
			get
			{
				if(r_RIsValidCodePointIndex_Int32 == null)
				{
					r_RIsValidCodePointIndex_Int32 = new(this, "IsValidCodePointIndex", 0, typeof(System.Int32));
					r_RIsValidCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_RIsValidCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfEndOfLine(Int32)
		/// </summary>
		protected RMethod r_RIndexOfEndOfLine_Int32;
		public virtual RMethod RIndexOfEndOfLine_Int32
		{
			get
			{
				if(r_RIndexOfEndOfLine_Int32 == null)
				{
					r_RIndexOfEndOfLine_Int32 = new(this, "IndexOfEndOfLine", 0, typeof(System.Int32));
					r_RIndexOfEndOfLine_Int32.SetBelong(this.instance);
				}
				return r_RIndexOfEndOfLine_Int32;
			}
		}

		/// <summary>
		/// Int32 PreviousCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_RPreviousCodePointIndex_Int32;
		public virtual RMethod RPreviousCodePointIndex_Int32
		{
			get
			{
				if(r_RPreviousCodePointIndex_Int32 == null)
				{
					r_RPreviousCodePointIndex_Int32 = new(this, "PreviousCodePointIndex", 0, typeof(System.Int32));
					r_RPreviousCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_RPreviousCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 NextCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_RNextCodePointIndex_Int32;
		public virtual RMethod RNextCodePointIndex_Int32
		{
			get
			{
				if(r_RNextCodePointIndex_Int32 == null)
				{
					r_RNextCodePointIndex_Int32 = new(this, "NextCodePointIndex", 0, typeof(System.Int32));
					r_RNextCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_RNextCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGraphicalLineStart(Int32)
		/// </summary>
		protected RMethod r_RGetGraphicalLineStart_Int32;
		public virtual RMethod RGetGraphicalLineStart_Int32
		{
			get
			{
				if(r_RGetGraphicalLineStart_Int32 == null)
				{
					r_RGetGraphicalLineStart_Int32 = new(this, "GetGraphicalLineStart", 0, typeof(System.Int32));
					r_RGetGraphicalLineStart_Int32.SetBelong(this.instance);
				}
				return r_RGetGraphicalLineStart_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGraphicalLineEnd(Int32)
		/// </summary>
		protected RMethod r_RGetGraphicalLineEnd_Int32;
		public virtual RMethod RGetGraphicalLineEnd_Int32
		{
			get
			{
				if(r_RGetGraphicalLineEnd_Int32 == null)
				{
					r_RGetGraphicalLineEnd_Int32 = new(this, "GetGraphicalLineEnd", 0, typeof(System.Int32));
					r_RGetGraphicalLineEnd_Int32.SetBelong(this.instance);
				}
				return r_RGetGraphicalLineEnd_Int32;
			}
		}

		/// <summary>
		/// Void Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// CharacterType ClassifyChar(Int32)
		/// </summary>
		protected RMethod r_RClassifyChar_Int32;
		public virtual RMethod RClassifyChar_Int32
		{
			get
			{
				if(r_RClassifyChar_Int32 == null)
				{
					r_RClassifyChar_Int32 = new(this, "ClassifyChar", 0, typeof(System.Int32));
					r_RClassifyChar_Int32.SetBelong(this.instance);
				}
				return r_RClassifyChar_Int32;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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

        public virtual void SetCursorIndexWithoutNotify(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSetCursorIndexWithoutNotify_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectIndexWithoutNotify(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSetSelectIndexWithoutNotify_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCursorPos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCursorPos.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFocus(System.Boolean  @selectAll)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selectAll};
            var ___result = ROnFocus_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectNone.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectTextEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectTextStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectTextStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectToStartOfNextWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectToStartOfNextWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectToEndOfPreviousWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectToEndOfPreviousWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectWordRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectWordRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectWordLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectWordLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectGraphicalLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectGraphicalLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectGraphicalLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectGraphicalLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectParagraphForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectParagraphForward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectParagraphBackward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectParagraphBackward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectCurrentWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectCurrentWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectCurrentParagraph()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectCurrentParagraph.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveGraphicalLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveGraphicalLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveGraphicalLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveGraphicalLineEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTextStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveTextStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveTextEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveParagraphForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveParagraphForward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveParagraphBackward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveParagraphBackward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveWordRight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveWordRight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveToStartOfNextWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToStartOfNextWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveToEndOfPreviousWord()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToEndOfPreviousWord.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveWordLeft()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveWordLeft.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MouseDragSelectsWholeWords(System.Boolean  @on)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@on};
            var ___result = RMouseDragSelectsWholeWords_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExpandSelectGraphicalLineStart()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExpandSelectGraphicalLineStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExpandSelectGraphicalLineEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExpandSelectGraphicalLineEnd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void MoveCursorToPosition_Internal(UnityEngine.Vector2  @cursorPosition, System.Boolean  @shift)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition, @shift};
            var ___result = RMoveCursorToPosition_Internal_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectToPosition(UnityEngine.Vector2  @cursorPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorPosition};
            var ___result = RSelectToPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindNextSeperator(System.Int32  @startPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos};
            var ___result = RFindNextSeperator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindPrevSeperator(System.Int32  @startPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos};
            var ___result = RFindPrevSeperator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindStartOfNextWord(System.Int32  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RFindStartOfNextWord_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindEndOfPreviousWord(System.Int32  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RFindEndOfPreviousWord_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 ClampTextIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RClampTextIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 EnsureValidCodePointIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = REnsureValidCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsValidCodePointIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RIsValidCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOfEndOfLine(System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex};
            var ___result = RIndexOfEndOfLine_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 PreviousCodePointIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RPreviousCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 NextCodePointIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RNextCodePointIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetGraphicalLineStart(System.Int32  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RGetGraphicalLineStart_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetGraphicalLineEnd(System.Int32  @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p};
            var ___result = RGetGraphicalLineEnd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object ClassifyChar(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RClassifyChar_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
