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
					r_kMoveDownHeight = new( ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities"), "kMoveDownHeight");
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
					r_kNewLineChar = new( ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities"), "kNewLineChar");
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
		protected RMethod r_SetCursorIndexWithoutNotify_Int32;
		public virtual RMethod RSetCursorIndexWithoutNotify_Int32
		{
			get
			{
				if(r_SetCursorIndexWithoutNotify_Int32 == null)
				{
					r_SetCursorIndexWithoutNotify_Int32 = new(this, "SetCursorIndexWithoutNotify", 0, typeof(System.Int32));
					r_SetCursorIndexWithoutNotify_Int32.SetBelong(this.instance);
				}
				return r_SetCursorIndexWithoutNotify_Int32;
			}
		}

		/// <summary>
		/// Void SetSelectIndexWithoutNotify(Int32)
		/// </summary>
		protected RMethod r_SetSelectIndexWithoutNotify_Int32;
		public virtual RMethod RSetSelectIndexWithoutNotify_Int32
		{
			get
			{
				if(r_SetSelectIndexWithoutNotify_Int32 == null)
				{
					r_SetSelectIndexWithoutNotify_Int32 = new(this, "SetSelectIndexWithoutNotify", 0, typeof(System.Int32));
					r_SetSelectIndexWithoutNotify_Int32.SetBelong(this.instance);
				}
				return r_SetSelectIndexWithoutNotify_Int32;
			}
		}

		/// <summary>
		/// Void ClearCursorPos()
		/// </summary>
		protected RMethod r_ClearCursorPos;
		public virtual RMethod RClearCursorPos
		{
			get
			{
				if(r_ClearCursorPos == null)
				{
					r_ClearCursorPos = new(this, "ClearCursorPos", 0);
					r_ClearCursorPos.SetBelong(this.instance);
				}
				return r_ClearCursorPos;
			}
		}

		/// <summary>
		/// Void OnFocus(Boolean)
		/// </summary>
		protected RMethod r_OnFocus_Boolean;
		public virtual RMethod ROnFocus_Boolean
		{
			get
			{
				if(r_OnFocus_Boolean == null)
				{
					r_OnFocus_Boolean = new(this, "OnFocus", 0, typeof(System.Boolean));
					r_OnFocus_Boolean.SetBelong(this.instance);
				}
				return r_OnFocus_Boolean;
			}
		}

		/// <summary>
		/// Void SelectAll()
		/// </summary>
		protected RMethod r_SelectAll;
		public virtual RMethod RSelectAll
		{
			get
			{
				if(r_SelectAll == null)
				{
					r_SelectAll = new(this, "SelectAll", 0);
					r_SelectAll.SetBelong(this.instance);
				}
				return r_SelectAll;
			}
		}

		/// <summary>
		/// Void SelectNone()
		/// </summary>
		protected RMethod r_SelectNone;
		public virtual RMethod RSelectNone
		{
			get
			{
				if(r_SelectNone == null)
				{
					r_SelectNone = new(this, "SelectNone", 0);
					r_SelectNone.SetBelong(this.instance);
				}
				return r_SelectNone;
			}
		}

		/// <summary>
		/// Void SelectLeft()
		/// </summary>
		protected RMethod r_SelectLeft;
		public virtual RMethod RSelectLeft
		{
			get
			{
				if(r_SelectLeft == null)
				{
					r_SelectLeft = new(this, "SelectLeft", 0);
					r_SelectLeft.SetBelong(this.instance);
				}
				return r_SelectLeft;
			}
		}

		/// <summary>
		/// Void SelectRight()
		/// </summary>
		protected RMethod r_SelectRight;
		public virtual RMethod RSelectRight
		{
			get
			{
				if(r_SelectRight == null)
				{
					r_SelectRight = new(this, "SelectRight", 0);
					r_SelectRight.SetBelong(this.instance);
				}
				return r_SelectRight;
			}
		}

		/// <summary>
		/// Void SelectUp()
		/// </summary>
		protected RMethod r_SelectUp;
		public virtual RMethod RSelectUp
		{
			get
			{
				if(r_SelectUp == null)
				{
					r_SelectUp = new(this, "SelectUp", 0);
					r_SelectUp.SetBelong(this.instance);
				}
				return r_SelectUp;
			}
		}

		/// <summary>
		/// Void SelectDown()
		/// </summary>
		protected RMethod r_SelectDown;
		public virtual RMethod RSelectDown
		{
			get
			{
				if(r_SelectDown == null)
				{
					r_SelectDown = new(this, "SelectDown", 0);
					r_SelectDown.SetBelong(this.instance);
				}
				return r_SelectDown;
			}
		}

		/// <summary>
		/// Void SelectTextEnd()
		/// </summary>
		protected RMethod r_SelectTextEnd;
		public virtual RMethod RSelectTextEnd
		{
			get
			{
				if(r_SelectTextEnd == null)
				{
					r_SelectTextEnd = new(this, "SelectTextEnd", 0);
					r_SelectTextEnd.SetBelong(this.instance);
				}
				return r_SelectTextEnd;
			}
		}

		/// <summary>
		/// Void SelectTextStart()
		/// </summary>
		protected RMethod r_SelectTextStart;
		public virtual RMethod RSelectTextStart
		{
			get
			{
				if(r_SelectTextStart == null)
				{
					r_SelectTextStart = new(this, "SelectTextStart", 0);
					r_SelectTextStart.SetBelong(this.instance);
				}
				return r_SelectTextStart;
			}
		}

		/// <summary>
		/// Void SelectToStartOfNextWord()
		/// </summary>
		protected RMethod r_SelectToStartOfNextWord;
		public virtual RMethod RSelectToStartOfNextWord
		{
			get
			{
				if(r_SelectToStartOfNextWord == null)
				{
					r_SelectToStartOfNextWord = new(this, "SelectToStartOfNextWord", 0);
					r_SelectToStartOfNextWord.SetBelong(this.instance);
				}
				return r_SelectToStartOfNextWord;
			}
		}

		/// <summary>
		/// Void SelectToEndOfPreviousWord()
		/// </summary>
		protected RMethod r_SelectToEndOfPreviousWord;
		public virtual RMethod RSelectToEndOfPreviousWord
		{
			get
			{
				if(r_SelectToEndOfPreviousWord == null)
				{
					r_SelectToEndOfPreviousWord = new(this, "SelectToEndOfPreviousWord", 0);
					r_SelectToEndOfPreviousWord.SetBelong(this.instance);
				}
				return r_SelectToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// Void SelectWordRight()
		/// </summary>
		protected RMethod r_SelectWordRight;
		public virtual RMethod RSelectWordRight
		{
			get
			{
				if(r_SelectWordRight == null)
				{
					r_SelectWordRight = new(this, "SelectWordRight", 0);
					r_SelectWordRight.SetBelong(this.instance);
				}
				return r_SelectWordRight;
			}
		}

		/// <summary>
		/// Void SelectWordLeft()
		/// </summary>
		protected RMethod r_SelectWordLeft;
		public virtual RMethod RSelectWordLeft
		{
			get
			{
				if(r_SelectWordLeft == null)
				{
					r_SelectWordLeft = new(this, "SelectWordLeft", 0);
					r_SelectWordLeft.SetBelong(this.instance);
				}
				return r_SelectWordLeft;
			}
		}

		/// <summary>
		/// Void SelectGraphicalLineStart()
		/// </summary>
		protected RMethod r_SelectGraphicalLineStart;
		public virtual RMethod RSelectGraphicalLineStart
		{
			get
			{
				if(r_SelectGraphicalLineStart == null)
				{
					r_SelectGraphicalLineStart = new(this, "SelectGraphicalLineStart", 0);
					r_SelectGraphicalLineStart.SetBelong(this.instance);
				}
				return r_SelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void SelectGraphicalLineEnd()
		/// </summary>
		protected RMethod r_SelectGraphicalLineEnd;
		public virtual RMethod RSelectGraphicalLineEnd
		{
			get
			{
				if(r_SelectGraphicalLineEnd == null)
				{
					r_SelectGraphicalLineEnd = new(this, "SelectGraphicalLineEnd", 0);
					r_SelectGraphicalLineEnd.SetBelong(this.instance);
				}
				return r_SelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void SelectParagraphForward()
		/// </summary>
		protected RMethod r_SelectParagraphForward;
		public virtual RMethod RSelectParagraphForward
		{
			get
			{
				if(r_SelectParagraphForward == null)
				{
					r_SelectParagraphForward = new(this, "SelectParagraphForward", 0);
					r_SelectParagraphForward.SetBelong(this.instance);
				}
				return r_SelectParagraphForward;
			}
		}

		/// <summary>
		/// Void SelectParagraphBackward()
		/// </summary>
		protected RMethod r_SelectParagraphBackward;
		public virtual RMethod RSelectParagraphBackward
		{
			get
			{
				if(r_SelectParagraphBackward == null)
				{
					r_SelectParagraphBackward = new(this, "SelectParagraphBackward", 0);
					r_SelectParagraphBackward.SetBelong(this.instance);
				}
				return r_SelectParagraphBackward;
			}
		}

		/// <summary>
		/// Void SelectCurrentWord()
		/// </summary>
		protected RMethod r_SelectCurrentWord;
		public virtual RMethod RSelectCurrentWord
		{
			get
			{
				if(r_SelectCurrentWord == null)
				{
					r_SelectCurrentWord = new(this, "SelectCurrentWord", 0);
					r_SelectCurrentWord.SetBelong(this.instance);
				}
				return r_SelectCurrentWord;
			}
		}

		/// <summary>
		/// Void SelectCurrentParagraph()
		/// </summary>
		protected RMethod r_SelectCurrentParagraph;
		public virtual RMethod RSelectCurrentParagraph
		{
			get
			{
				if(r_SelectCurrentParagraph == null)
				{
					r_SelectCurrentParagraph = new(this, "SelectCurrentParagraph", 0);
					r_SelectCurrentParagraph.SetBelong(this.instance);
				}
				return r_SelectCurrentParagraph;
			}
		}

		/// <summary>
		/// Void MoveRight()
		/// </summary>
		protected RMethod r_MoveRight;
		public virtual RMethod RMoveRight
		{
			get
			{
				if(r_MoveRight == null)
				{
					r_MoveRight = new(this, "MoveRight", 0);
					r_MoveRight.SetBelong(this.instance);
				}
				return r_MoveRight;
			}
		}

		/// <summary>
		/// Void MoveLeft()
		/// </summary>
		protected RMethod r_MoveLeft;
		public virtual RMethod RMoveLeft
		{
			get
			{
				if(r_MoveLeft == null)
				{
					r_MoveLeft = new(this, "MoveLeft", 0);
					r_MoveLeft.SetBelong(this.instance);
				}
				return r_MoveLeft;
			}
		}

		/// <summary>
		/// Void MoveUp()
		/// </summary>
		protected RMethod r_MoveUp;
		public virtual RMethod RMoveUp
		{
			get
			{
				if(r_MoveUp == null)
				{
					r_MoveUp = new(this, "MoveUp", 0);
					r_MoveUp.SetBelong(this.instance);
				}
				return r_MoveUp;
			}
		}

		/// <summary>
		/// Void MoveDown()
		/// </summary>
		protected RMethod r_MoveDown;
		public virtual RMethod RMoveDown
		{
			get
			{
				if(r_MoveDown == null)
				{
					r_MoveDown = new(this, "MoveDown", 0);
					r_MoveDown.SetBelong(this.instance);
				}
				return r_MoveDown;
			}
		}

		/// <summary>
		/// Void MoveLineStart()
		/// </summary>
		protected RMethod r_MoveLineStart;
		public virtual RMethod RMoveLineStart
		{
			get
			{
				if(r_MoveLineStart == null)
				{
					r_MoveLineStart = new(this, "MoveLineStart", 0);
					r_MoveLineStart.SetBelong(this.instance);
				}
				return r_MoveLineStart;
			}
		}

		/// <summary>
		/// Void MoveLineEnd()
		/// </summary>
		protected RMethod r_MoveLineEnd;
		public virtual RMethod RMoveLineEnd
		{
			get
			{
				if(r_MoveLineEnd == null)
				{
					r_MoveLineEnd = new(this, "MoveLineEnd", 0);
					r_MoveLineEnd.SetBelong(this.instance);
				}
				return r_MoveLineEnd;
			}
		}

		/// <summary>
		/// Void MoveGraphicalLineStart()
		/// </summary>
		protected RMethod r_MoveGraphicalLineStart;
		public virtual RMethod RMoveGraphicalLineStart
		{
			get
			{
				if(r_MoveGraphicalLineStart == null)
				{
					r_MoveGraphicalLineStart = new(this, "MoveGraphicalLineStart", 0);
					r_MoveGraphicalLineStart.SetBelong(this.instance);
				}
				return r_MoveGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void MoveGraphicalLineEnd()
		/// </summary>
		protected RMethod r_MoveGraphicalLineEnd;
		public virtual RMethod RMoveGraphicalLineEnd
		{
			get
			{
				if(r_MoveGraphicalLineEnd == null)
				{
					r_MoveGraphicalLineEnd = new(this, "MoveGraphicalLineEnd", 0);
					r_MoveGraphicalLineEnd.SetBelong(this.instance);
				}
				return r_MoveGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void MoveTextStart()
		/// </summary>
		protected RMethod r_MoveTextStart;
		public virtual RMethod RMoveTextStart
		{
			get
			{
				if(r_MoveTextStart == null)
				{
					r_MoveTextStart = new(this, "MoveTextStart", 0);
					r_MoveTextStart.SetBelong(this.instance);
				}
				return r_MoveTextStart;
			}
		}

		/// <summary>
		/// Void MoveTextEnd()
		/// </summary>
		protected RMethod r_MoveTextEnd;
		public virtual RMethod RMoveTextEnd
		{
			get
			{
				if(r_MoveTextEnd == null)
				{
					r_MoveTextEnd = new(this, "MoveTextEnd", 0);
					r_MoveTextEnd.SetBelong(this.instance);
				}
				return r_MoveTextEnd;
			}
		}

		/// <summary>
		/// Void MoveParagraphForward()
		/// </summary>
		protected RMethod r_MoveParagraphForward;
		public virtual RMethod RMoveParagraphForward
		{
			get
			{
				if(r_MoveParagraphForward == null)
				{
					r_MoveParagraphForward = new(this, "MoveParagraphForward", 0);
					r_MoveParagraphForward.SetBelong(this.instance);
				}
				return r_MoveParagraphForward;
			}
		}

		/// <summary>
		/// Void MoveParagraphBackward()
		/// </summary>
		protected RMethod r_MoveParagraphBackward;
		public virtual RMethod RMoveParagraphBackward
		{
			get
			{
				if(r_MoveParagraphBackward == null)
				{
					r_MoveParagraphBackward = new(this, "MoveParagraphBackward", 0);
					r_MoveParagraphBackward.SetBelong(this.instance);
				}
				return r_MoveParagraphBackward;
			}
		}

		/// <summary>
		/// Void MoveWordRight()
		/// </summary>
		protected RMethod r_MoveWordRight;
		public virtual RMethod RMoveWordRight
		{
			get
			{
				if(r_MoveWordRight == null)
				{
					r_MoveWordRight = new(this, "MoveWordRight", 0);
					r_MoveWordRight.SetBelong(this.instance);
				}
				return r_MoveWordRight;
			}
		}

		/// <summary>
		/// Void MoveToStartOfNextWord()
		/// </summary>
		protected RMethod r_MoveToStartOfNextWord;
		public virtual RMethod RMoveToStartOfNextWord
		{
			get
			{
				if(r_MoveToStartOfNextWord == null)
				{
					r_MoveToStartOfNextWord = new(this, "MoveToStartOfNextWord", 0);
					r_MoveToStartOfNextWord.SetBelong(this.instance);
				}
				return r_MoveToStartOfNextWord;
			}
		}

		/// <summary>
		/// Void MoveToEndOfPreviousWord()
		/// </summary>
		protected RMethod r_MoveToEndOfPreviousWord;
		public virtual RMethod RMoveToEndOfPreviousWord
		{
			get
			{
				if(r_MoveToEndOfPreviousWord == null)
				{
					r_MoveToEndOfPreviousWord = new(this, "MoveToEndOfPreviousWord", 0);
					r_MoveToEndOfPreviousWord.SetBelong(this.instance);
				}
				return r_MoveToEndOfPreviousWord;
			}
		}

		/// <summary>
		/// Void MoveWordLeft()
		/// </summary>
		protected RMethod r_MoveWordLeft;
		public virtual RMethod RMoveWordLeft
		{
			get
			{
				if(r_MoveWordLeft == null)
				{
					r_MoveWordLeft = new(this, "MoveWordLeft", 0);
					r_MoveWordLeft.SetBelong(this.instance);
				}
				return r_MoveWordLeft;
			}
		}

		/// <summary>
		/// Void MouseDragSelectsWholeWords(Boolean)
		/// </summary>
		protected RMethod r_MouseDragSelectsWholeWords_Boolean;
		public virtual RMethod RMouseDragSelectsWholeWords_Boolean
		{
			get
			{
				if(r_MouseDragSelectsWholeWords_Boolean == null)
				{
					r_MouseDragSelectsWholeWords_Boolean = new(this, "MouseDragSelectsWholeWords", 0, typeof(System.Boolean));
					r_MouseDragSelectsWholeWords_Boolean.SetBelong(this.instance);
				}
				return r_MouseDragSelectsWholeWords_Boolean;
			}
		}

		/// <summary>
		/// Void ExpandSelectGraphicalLineStart()
		/// </summary>
		protected RMethod r_ExpandSelectGraphicalLineStart;
		public virtual RMethod RExpandSelectGraphicalLineStart
		{
			get
			{
				if(r_ExpandSelectGraphicalLineStart == null)
				{
					r_ExpandSelectGraphicalLineStart = new(this, "ExpandSelectGraphicalLineStart", 0);
					r_ExpandSelectGraphicalLineStart.SetBelong(this.instance);
				}
				return r_ExpandSelectGraphicalLineStart;
			}
		}

		/// <summary>
		/// Void ExpandSelectGraphicalLineEnd()
		/// </summary>
		protected RMethod r_ExpandSelectGraphicalLineEnd;
		public virtual RMethod RExpandSelectGraphicalLineEnd
		{
			get
			{
				if(r_ExpandSelectGraphicalLineEnd == null)
				{
					r_ExpandSelectGraphicalLineEnd = new(this, "ExpandSelectGraphicalLineEnd", 0);
					r_ExpandSelectGraphicalLineEnd.SetBelong(this.instance);
				}
				return r_ExpandSelectGraphicalLineEnd;
			}
		}

		/// <summary>
		/// Void DblClickSnap(DblClickSnapping)
		/// </summary>
		protected RMethod r_DblClickSnap_DblClickSnapping;
		public virtual RMethod RDblClickSnap_DblClickSnapping
		{
			get
			{
				if(r_DblClickSnap_DblClickSnapping == null)
				{
					r_DblClickSnap_DblClickSnapping = new(this, "DblClickSnap", 0,  ReflectionUtils.GetType("UnityEngine.TextEditor+DblClickSnapping"));
					r_DblClickSnap_DblClickSnapping.SetBelong(this.instance);
				}
				return r_DblClickSnap_DblClickSnapping;
			}
		}

		/// <summary>
		/// Void MoveCursorToPosition_Internal(UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_MoveCursorToPosition_Internal_Vector2_Boolean;
		public virtual RMethod RMoveCursorToPosition_Internal_Vector2_Boolean
		{
			get
			{
				if(r_MoveCursorToPosition_Internal_Vector2_Boolean == null)
				{
					r_MoveCursorToPosition_Internal_Vector2_Boolean = new(this, "MoveCursorToPosition_Internal", 0, typeof(UnityEngine.Vector2), typeof(System.Boolean));
					r_MoveCursorToPosition_Internal_Vector2_Boolean.SetBelong(this.instance);
				}
				return r_MoveCursorToPosition_Internal_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Void SelectToPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SelectToPosition_Vector2;
		public virtual RMethod RSelectToPosition_Vector2
		{
			get
			{
				if(r_SelectToPosition_Vector2 == null)
				{
					r_SelectToPosition_Vector2 = new(this, "SelectToPosition", 0, typeof(UnityEngine.Vector2));
					r_SelectToPosition_Vector2.SetBelong(this.instance);
				}
				return r_SelectToPosition_Vector2;
			}
		}

		/// <summary>
		/// Int32 FindNextSeperator(Int32)
		/// </summary>
		protected RMethod r_FindNextSeperator_Int32;
		public virtual RMethod RFindNextSeperator_Int32
		{
			get
			{
				if(r_FindNextSeperator_Int32 == null)
				{
					r_FindNextSeperator_Int32 = new(this, "FindNextSeperator", 0, typeof(System.Int32));
					r_FindNextSeperator_Int32.SetBelong(this.instance);
				}
				return r_FindNextSeperator_Int32;
			}
		}

		/// <summary>
		/// Int32 FindPrevSeperator(Int32)
		/// </summary>
		protected RMethod r_FindPrevSeperator_Int32;
		public virtual RMethod RFindPrevSeperator_Int32
		{
			get
			{
				if(r_FindPrevSeperator_Int32 == null)
				{
					r_FindPrevSeperator_Int32 = new(this, "FindPrevSeperator", 0, typeof(System.Int32));
					r_FindPrevSeperator_Int32.SetBelong(this.instance);
				}
				return r_FindPrevSeperator_Int32;
			}
		}

		/// <summary>
		/// Int32 FindStartOfNextWord(Int32)
		/// </summary>
		protected RMethod r_FindStartOfNextWord_Int32;
		public virtual RMethod RFindStartOfNextWord_Int32
		{
			get
			{
				if(r_FindStartOfNextWord_Int32 == null)
				{
					r_FindStartOfNextWord_Int32 = new(this, "FindStartOfNextWord", 0, typeof(System.Int32));
					r_FindStartOfNextWord_Int32.SetBelong(this.instance);
				}
				return r_FindStartOfNextWord_Int32;
			}
		}

		/// <summary>
		/// Int32 FindEndOfPreviousWord(Int32)
		/// </summary>
		protected RMethod r_FindEndOfPreviousWord_Int32;
		public virtual RMethod RFindEndOfPreviousWord_Int32
		{
			get
			{
				if(r_FindEndOfPreviousWord_Int32 == null)
				{
					r_FindEndOfPreviousWord_Int32 = new(this, "FindEndOfPreviousWord", 0, typeof(System.Int32));
					r_FindEndOfPreviousWord_Int32.SetBelong(this.instance);
				}
				return r_FindEndOfPreviousWord_Int32;
			}
		}

		/// <summary>
		/// Int32 FindEndOfClassification(Int32, Direction)
		/// </summary>
		protected RMethod r_FindEndOfClassification_Int32_Direction;
		public virtual RMethod RFindEndOfClassification_Int32_Direction
		{
			get
			{
				if(r_FindEndOfClassification_Int32_Direction == null)
				{
					r_FindEndOfClassification_Int32_Direction = new(this, "FindEndOfClassification", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.TextSelectingUtilities+Direction"));
					r_FindEndOfClassification_Int32_Direction.SetBelong(this.instance);
				}
				return r_FindEndOfClassification_Int32_Direction;
			}
		}

		/// <summary>
		/// Int32 ClampTextIndex(Int32)
		/// </summary>
		protected RMethod r_ClampTextIndex_Int32;
		public virtual RMethod RClampTextIndex_Int32
		{
			get
			{
				if(r_ClampTextIndex_Int32 == null)
				{
					r_ClampTextIndex_Int32 = new(this, "ClampTextIndex", 0, typeof(System.Int32));
					r_ClampTextIndex_Int32.SetBelong(this.instance);
				}
				return r_ClampTextIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 EnsureValidCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_EnsureValidCodePointIndex_Int32;
		public virtual RMethod REnsureValidCodePointIndex_Int32
		{
			get
			{
				if(r_EnsureValidCodePointIndex_Int32 == null)
				{
					r_EnsureValidCodePointIndex_Int32 = new(this, "EnsureValidCodePointIndex", 0, typeof(System.Int32));
					r_EnsureValidCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_EnsureValidCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValidCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_IsValidCodePointIndex_Int32;
		public virtual RMethod RIsValidCodePointIndex_Int32
		{
			get
			{
				if(r_IsValidCodePointIndex_Int32 == null)
				{
					r_IsValidCodePointIndex_Int32 = new(this, "IsValidCodePointIndex", 0, typeof(System.Int32));
					r_IsValidCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_IsValidCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfEndOfLine(Int32)
		/// </summary>
		protected RMethod r_IndexOfEndOfLine_Int32;
		public virtual RMethod RIndexOfEndOfLine_Int32
		{
			get
			{
				if(r_IndexOfEndOfLine_Int32 == null)
				{
					r_IndexOfEndOfLine_Int32 = new(this, "IndexOfEndOfLine", 0, typeof(System.Int32));
					r_IndexOfEndOfLine_Int32.SetBelong(this.instance);
				}
				return r_IndexOfEndOfLine_Int32;
			}
		}

		/// <summary>
		/// Int32 PreviousCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_PreviousCodePointIndex_Int32;
		public virtual RMethod RPreviousCodePointIndex_Int32
		{
			get
			{
				if(r_PreviousCodePointIndex_Int32 == null)
				{
					r_PreviousCodePointIndex_Int32 = new(this, "PreviousCodePointIndex", 0, typeof(System.Int32));
					r_PreviousCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_PreviousCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 NextCodePointIndex(Int32)
		/// </summary>
		protected RMethod r_NextCodePointIndex_Int32;
		public virtual RMethod RNextCodePointIndex_Int32
		{
			get
			{
				if(r_NextCodePointIndex_Int32 == null)
				{
					r_NextCodePointIndex_Int32 = new(this, "NextCodePointIndex", 0, typeof(System.Int32));
					r_NextCodePointIndex_Int32.SetBelong(this.instance);
				}
				return r_NextCodePointIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGraphicalLineStart(Int32)
		/// </summary>
		protected RMethod r_GetGraphicalLineStart_Int32;
		public virtual RMethod RGetGraphicalLineStart_Int32
		{
			get
			{
				if(r_GetGraphicalLineStart_Int32 == null)
				{
					r_GetGraphicalLineStart_Int32 = new(this, "GetGraphicalLineStart", 0, typeof(System.Int32));
					r_GetGraphicalLineStart_Int32.SetBelong(this.instance);
				}
				return r_GetGraphicalLineStart_Int32;
			}
		}

		/// <summary>
		/// Int32 GetGraphicalLineEnd(Int32)
		/// </summary>
		protected RMethod r_GetGraphicalLineEnd_Int32;
		public virtual RMethod RGetGraphicalLineEnd_Int32
		{
			get
			{
				if(r_GetGraphicalLineEnd_Int32 == null)
				{
					r_GetGraphicalLineEnd_Int32 = new(this, "GetGraphicalLineEnd", 0, typeof(System.Int32));
					r_GetGraphicalLineEnd_Int32.SetBelong(this.instance);
				}
				return r_GetGraphicalLineEnd_Int32;
			}
		}

		/// <summary>
		/// Void Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// CharacterType ClassifyChar(Int32)
		/// </summary>
		protected RMethod r_ClassifyChar_Int32;
		public virtual RMethod RClassifyChar_Int32
		{
			get
			{
				if(r_ClassifyChar_Int32 == null)
				{
					r_ClassifyChar_Int32 = new(this, "ClassifyChar", 0, typeof(System.Int32));
					r_ClassifyChar_Int32.SetBelong(this.instance);
				}
				return r_ClassifyChar_Int32;
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
