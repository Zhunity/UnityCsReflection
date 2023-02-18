
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextEditingUtilities
	/// </summary>
    public partial class RTextEditingUtilities : RMember //
    {

		/// <summary>
		/// UnityEngine.TextSelectingUtilities m_TextSelectingUtility
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities r_Fm_TextSelectingUtility;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextSelectingUtilities RFm_TextSelectingUtility
		{
			get
			{
				if(r_Fm_TextSelectingUtility == null)
				{
					r_Fm_TextSelectingUtility = new(this, "m_TextSelectingUtility");
					r_Fm_TextSelectingUtility.SetBelong(this.GetValue());
				}
				return r_Fm_TextSelectingUtility;
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
		/// System.Int32 m_CursorIndexSavedState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CursorIndexSavedState;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CursorIndexSavedState
		{
			get
			{
				if(r_Fm_CursorIndexSavedState == null)
				{
					r_Fm_CursorIndexSavedState = new(this, "m_CursorIndexSavedState");
					r_Fm_CursorIndexSavedState.SetBelong(this.GetValue());
				}
				return r_Fm_CursorIndexSavedState;
			}
		}

		/// <summary>
		/// System.Boolean isCompositionActive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisCompositionActive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisCompositionActive
		{
			get
			{
				if(r_FisCompositionActive == null)
				{
					r_FisCompositionActive = new(this, "isCompositionActive");
					r_FisCompositionActive.SetBelong(this.GetValue());
				}
				return r_FisCompositionActive;
			}
		}

		/// <summary>
		/// System.Boolean m_UpdateImeWindowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UpdateImeWindowPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UpdateImeWindowPosition
		{
			get
			{
				if(r_Fm_UpdateImeWindowPosition == null)
				{
					r_Fm_UpdateImeWindowPosition = new(this, "m_UpdateImeWindowPosition");
					r_Fm_UpdateImeWindowPosition.SetBelong(this.GetValue());
				}
				return r_Fm_UpdateImeWindowPosition;
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
					r_Fmultiline.SetBelong(this.GetValue());
				}
				return r_Fmultiline;
			}
		}

		/// <summary>
		/// System.String m_Text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Text;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Text
		{
			get
			{
				if(r_Fm_Text == null)
				{
					r_Fm_Text = new(this, "m_Text");
					r_Fm_Text.SetBelong(this.GetValue());
				}
				return r_Fm_Text;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.Event,UnityEngine.TextEditOp] s_KeyEditOps
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.REvent, Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp> r_Fs_KeyEditOps;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RUnityEngine.REvent, Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp> RFs_KeyEditOps
		{
			get
			{
				if(r_Fs_KeyEditOps == null)
				{
					r_Fs_KeyEditOps = new( ReflectionUtils.GetType("UnityEngine.TextEditingUtilities"), "s_KeyEditOps");
					r_Fs_KeyEditOps.SetBelong(null);
				}
				return r_Fs_KeyEditOps;
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
					r_PSelectedText.SetBelong(this.GetValue());
				}
				return r_PSelectedText;
			}
		}

		/// <summary>
		/// Int32 m_iAltCursorPos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pm_iAltCursorPos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPm_iAltCursorPos
		{
			get
			{
				if(r_Pm_iAltCursorPos == null)
				{
					r_Pm_iAltCursorPos = new(this, "m_iAltCursorPos", -1);
					r_Pm_iAltCursorPos.SetBelong(this.GetValue());
				}
				return r_Pm_iAltCursorPos;
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
					r_Ptext.SetBelong(this.GetValue());
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Boolean UpdateImeState()
		/// </summary>
		protected RMethod r_MUpdateImeState;
		public virtual RMethod RMUpdateImeState
		{
			get
			{
				if(r_MUpdateImeState == null)
				{
					r_MUpdateImeState = new(this, "UpdateImeState", 0);
					r_MUpdateImeState.SetBelong(this.GetValue());
				}
				return r_MUpdateImeState;
			}
		}

		/// <summary>
		/// Boolean ShouldUpdateImeWindowPosition()
		/// </summary>
		protected RMethod r_MShouldUpdateImeWindowPosition;
		public virtual RMethod RMShouldUpdateImeWindowPosition
		{
			get
			{
				if(r_MShouldUpdateImeWindowPosition == null)
				{
					r_MShouldUpdateImeWindowPosition = new(this, "ShouldUpdateImeWindowPosition", 0);
					r_MShouldUpdateImeWindowPosition.SetBelong(this.GetValue());
				}
				return r_MShouldUpdateImeWindowPosition;
			}
		}

		/// <summary>
		/// Void SetImeWindowPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetImeWindowPosition_Vector2;
		public virtual RMethod RMSetImeWindowPosition_Vector2
		{
			get
			{
				if(r_MSetImeWindowPosition_Vector2 == null)
				{
					r_MSetImeWindowPosition_Vector2 = new(this, "SetImeWindowPosition", 0, typeof(UnityEngine.Vector2));
					r_MSetImeWindowPosition_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetImeWindowPosition_Vector2;
			}
		}

		/// <summary>
		/// System.String GeneratePreviewString(Boolean)
		/// </summary>
		protected RMethod r_MGeneratePreviewString_Boolean;
		public virtual RMethod RMGeneratePreviewString_Boolean
		{
			get
			{
				if(r_MGeneratePreviewString_Boolean == null)
				{
					r_MGeneratePreviewString_Boolean = new(this, "GeneratePreviewString", 0, typeof(System.Boolean));
					r_MGeneratePreviewString_Boolean.SetBelong(this.GetValue());
				}
				return r_MGeneratePreviewString_Boolean;
			}
		}

		/// <summary>
		/// Void EnableCursorPreviewState()
		/// </summary>
		protected RMethod r_MEnableCursorPreviewState;
		public virtual RMethod RMEnableCursorPreviewState
		{
			get
			{
				if(r_MEnableCursorPreviewState == null)
				{
					r_MEnableCursorPreviewState = new(this, "EnableCursorPreviewState", 0);
					r_MEnableCursorPreviewState.SetBelong(this.GetValue());
				}
				return r_MEnableCursorPreviewState;
			}
		}

		/// <summary>
		/// Void RestoreCursorState()
		/// </summary>
		protected RMethod r_MRestoreCursorState;
		public virtual RMethod RMRestoreCursorState
		{
			get
			{
				if(r_MRestoreCursorState == null)
				{
					r_MRestoreCursorState = new(this, "RestoreCursorState", 0);
					r_MRestoreCursorState.SetBelong(this.GetValue());
				}
				return r_MRestoreCursorState;
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
		/// Void PerformOperation(UnityEngine.TextEditOp)
		/// </summary>
		protected RMethod r_MPerformOperation_TextEditOp;
		public virtual RMethod RMPerformOperation_TextEditOp
		{
			get
			{
				if(r_MPerformOperation_TextEditOp == null)
				{
					r_MPerformOperation_TextEditOp = new(this, "PerformOperation", 0,  ReflectionUtils.GetType("UnityEngine.TextEditOp"));
					r_MPerformOperation_TextEditOp.SetBelong(this.GetValue());
				}
				return r_MPerformOperation_TextEditOp;
			}
		}

		/// <summary>
		/// Void MapKey(System.String, UnityEngine.TextEditOp)
		/// </summary>
		protected static RMethod r_MMapKey_String_TextEditOp;
		public static RMethod RMMapKey_String_TextEditOp
		{
			get
			{
				if(r_MMapKey_String_TextEditOp == null)
				{
					r_MMapKey_String_TextEditOp = new( ReflectionUtils.GetType("UnityEngine.TextEditingUtilities"), "MapKey", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEngine.TextEditOp"));
					r_MMapKey_String_TextEditOp.SetBelong(null);
				}
				return r_MMapKey_String_TextEditOp;
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
					r_MDeleteLineBack.SetBelong(this.GetValue());
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
					r_MDeleteWordBack.SetBelong(this.GetValue());
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
					r_MDeleteWordForward.SetBelong(this.GetValue());
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
					r_MDelete.SetBelong(this.GetValue());
				}
				return r_MDelete;
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
					r_MBackspace.SetBelong(this.GetValue());
				}
				return r_MBackspace;
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
					r_MDeleteSelection.SetBelong(this.GetValue());
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
					r_MReplaceSelection_String.SetBelong(this.GetValue());
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
					r_MInsert_Char.SetBelong(this.GetValue());
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
					r_MMoveSelectionToAltCursor.SetBelong(this.GetValue());
				}
				return r_MMoveSelectionToAltCursor;
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
					r_MCanPaste.SetBelong(this.GetValue());
				}
				return r_MCanPaste;
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
					r_MCut.SetBelong(this.GetValue());
				}
				return r_MCut;
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
					r_MPaste.SetBelong(this.GetValue());
				}
				return r_MPaste;
			}
		}

		/// <summary>
		/// System.String ReplaceNewlinesWithSpaces(System.String)
		/// </summary>
		protected static RMethod r_MReplaceNewlinesWithSpaces_String;
		public static RMethod RMReplaceNewlinesWithSpaces_String
		{
			get
			{
				if(r_MReplaceNewlinesWithSpaces_String == null)
				{
					r_MReplaceNewlinesWithSpaces_String = new( ReflectionUtils.GetType("UnityEngine.TextEditingUtilities"), "ReplaceNewlinesWithSpaces", 0, typeof(System.String));
					r_MReplaceNewlinesWithSpaces_String.SetBelong(null);
				}
				return r_MReplaceNewlinesWithSpaces_String;
			}
		}

		/// <summary>
		/// Void OnBlur()
		/// </summary>
		protected RMethod r_MOnBlur;
		public virtual RMethod RMOnBlur
		{
			get
			{
				if(r_MOnBlur == null)
				{
					r_MOnBlur = new(this, "OnBlur", 0);
					r_MOnBlur.SetBelong(this.GetValue());
				}
				return r_MOnBlur;
			}
		}

		/// <summary>
		/// Boolean TouchScreenKeyboardShouldBeUsed()
		/// </summary>
		protected RMethod r_MTouchScreenKeyboardShouldBeUsed;
		public virtual RMethod RMTouchScreenKeyboardShouldBeUsed
		{
			get
			{
				if(r_MTouchScreenKeyboardShouldBeUsed == null)
				{
					r_MTouchScreenKeyboardShouldBeUsed = new(this, "TouchScreenKeyboardShouldBeUsed", 0);
					r_MTouchScreenKeyboardShouldBeUsed.SetBelong(this.GetValue());
				}
				return r_MTouchScreenKeyboardShouldBeUsed;
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


        public RTextEditingUtilities() : base("UnityEngine.TextEditingUtilities")
        {
        }

        public RTextEditingUtilities(System.Object instance) : base("UnityEngine.TextEditingUtilities")
		{
            SetInstance(instance);
		}

        public RTextEditingUtilities(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextEditingUtilities(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean UpdateImeState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateImeState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldUpdateImeWindowPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldUpdateImeWindowPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetImeWindowPosition(UnityEngine.Vector2 @worldPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition};
            var ___result = RMSetImeWindowPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GeneratePreviewString(System.Boolean @richText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@richText};
            var ___result = RMGeneratePreviewString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void EnableCursorPreviewState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnableCursorPreviewState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreCursorState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRestoreCursorState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HandleKeyEvent(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMHandleKeyEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PerformOperation(Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp @operation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@operation.Value};
            var ___result = RMPerformOperation_TextEditOp.Invoke(___genericsType, ___parameters);

            
        }


        public static void MapKey(System.String @key, Hvak.Editor.Refleaction.RUnityEngine.RTextEditOp @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @action.Value};
            var ___result = RMMapKey_String_TextEditOp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitKeyActions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitKeyActions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DeleteLineBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteLineBack.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteWordBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteWordBack.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteWordForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteWordForward.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Delete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDelete.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Backspace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBackspace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDeleteSelection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean CanPaste()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanPaste.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Cut()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCut.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Paste()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPaste.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String ReplaceNewlinesWithSpaces(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMReplaceNewlinesWithSpaces_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void OnBlur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TouchScreenKeyboardShouldBeUsed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTouchScreenKeyboardShouldBeUsed.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
