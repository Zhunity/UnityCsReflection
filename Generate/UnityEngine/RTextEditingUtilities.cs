using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TextEditingUtilities
	/// </summary>
    public partial class RTextEditingUtilities : RMember //
    {

		/// <summary>
		/// UnityEngine.TextSelectingUtilities m_TextSelectingUtility
		/// </summary>
		protected RUnityEngine.RTextSelectingUtilities r_m_TextSelectingUtility;
		public virtual RUnityEngine.RTextSelectingUtilities Rm_TextSelectingUtility
		{
			get
			{
				if(r_m_TextSelectingUtility == null)
				{
					r_m_TextSelectingUtility = new(this, "m_TextSelectingUtility");
					r_m_TextSelectingUtility.SetBelong(this.instance);
				}
				return r_m_TextSelectingUtility;
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
		/// System.Int32 m_CursorIndexSavedState
		/// </summary>
		protected RField r_m_CursorIndexSavedState;
		public virtual RField Rm_CursorIndexSavedState
		{
			get
			{
				if(r_m_CursorIndexSavedState == null)
				{
					r_m_CursorIndexSavedState = new(this, "m_CursorIndexSavedState");
					r_m_CursorIndexSavedState.SetBelong(this.instance);
				}
				return r_m_CursorIndexSavedState;
			}
		}

		/// <summary>
		/// System.Boolean isCompositionActive
		/// </summary>
		protected RField r_isCompositionActive;
		public virtual RField RisCompositionActive
		{
			get
			{
				if(r_isCompositionActive == null)
				{
					r_isCompositionActive = new(this, "isCompositionActive");
					r_isCompositionActive.SetBelong(this.instance);
				}
				return r_isCompositionActive;
			}
		}

		/// <summary>
		/// System.Boolean m_UpdateImeWindowPosition
		/// </summary>
		protected RField r_m_UpdateImeWindowPosition;
		public virtual RField Rm_UpdateImeWindowPosition
		{
			get
			{
				if(r_m_UpdateImeWindowPosition == null)
				{
					r_m_UpdateImeWindowPosition = new(this, "m_UpdateImeWindowPosition");
					r_m_UpdateImeWindowPosition.SetBelong(this.instance);
				}
				return r_m_UpdateImeWindowPosition;
			}
		}

		/// <summary>
		/// System.Boolean multiline
		/// </summary>
		protected RField r_multiline;
		public virtual RField Rmultiline
		{
			get
			{
				if(r_multiline == null)
				{
					r_multiline = new(this, "multiline");
					r_multiline.SetBelong(this.instance);
				}
				return r_multiline;
			}
		}

		/// <summary>
		/// System.String m_Text
		/// </summary>
		protected RField r_m_Text;
		public virtual RField Rm_Text
		{
			get
			{
				if(r_m_Text == null)
				{
					r_m_Text = new(this, "m_Text");
					r_m_Text.SetBelong(this.instance);
				}
				return r_m_Text;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[UnityEngine.Event,UnityEngine.TextEditOp] s_Keyactions
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.REvent, RField> r_s_Keyactions;
		public static RSystem.RCollections.RGeneric.RDictionary<RUnityEngine.REvent, RField> Rs_Keyactions
		{
			get
			{
				if(r_s_Keyactions == null)
				{
					r_s_Keyactions = new( ReflectionUtils.GetType("UnityEngine.TextEditingUtilities"), "s_Keyactions");
					r_s_Keyactions.SetBelong(null);
				}
				return r_s_Keyactions;
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
		/// System.String SelectedText
		/// </summary>
		protected RProperty r_SelectedText;
		public virtual RProperty RSelectedText
		{
			get
			{
				if(r_SelectedText == null)
				{
					r_SelectedText = new(this, "SelectedText", -1);
					r_SelectedText.SetBelong(this.instance);
				}
				return r_SelectedText;
			}
		}

		/// <summary>
		/// Int32 m_iAltCursorPos
		/// </summary>
		protected RProperty r_m_iAltCursorPos;
		public virtual RProperty Rm_iAltCursorPos
		{
			get
			{
				if(r_m_iAltCursorPos == null)
				{
					r_m_iAltCursorPos = new(this, "m_iAltCursorPos", -1);
					r_m_iAltCursorPos.SetBelong(this.instance);
				}
				return r_m_iAltCursorPos;
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
		/// System.String text
		/// </summary>
		protected RProperty r_text;
		public virtual RProperty Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text", -1);
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// Boolean UpdateImeState()
		/// </summary>
		protected RMethod r_UpdateImeState;
		public virtual RMethod RUpdateImeState
		{
			get
			{
				if(r_UpdateImeState == null)
				{
					r_UpdateImeState = new(this, "UpdateImeState", 0);
					r_UpdateImeState.SetBelong(this.instance);
				}
				return r_UpdateImeState;
			}
		}

		/// <summary>
		/// Boolean ShouldUpdateImeWindowPosition()
		/// </summary>
		protected RMethod r_ShouldUpdateImeWindowPosition;
		public virtual RMethod RShouldUpdateImeWindowPosition
		{
			get
			{
				if(r_ShouldUpdateImeWindowPosition == null)
				{
					r_ShouldUpdateImeWindowPosition = new(this, "ShouldUpdateImeWindowPosition", 0);
					r_ShouldUpdateImeWindowPosition.SetBelong(this.instance);
				}
				return r_ShouldUpdateImeWindowPosition;
			}
		}

		/// <summary>
		/// Void SetImeWindowPosition(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_SetImeWindowPosition_Vector2;
		public virtual RMethod RSetImeWindowPosition_Vector2
		{
			get
			{
				if(r_SetImeWindowPosition_Vector2 == null)
				{
					r_SetImeWindowPosition_Vector2 = new(this, "SetImeWindowPosition", 0, typeof(UnityEngine.Vector2));
					r_SetImeWindowPosition_Vector2.SetBelong(this.instance);
				}
				return r_SetImeWindowPosition_Vector2;
			}
		}

		/// <summary>
		/// System.String GeneratePreviewString(Boolean)
		/// </summary>
		protected RMethod r_GeneratePreviewString_Boolean;
		public virtual RMethod RGeneratePreviewString_Boolean
		{
			get
			{
				if(r_GeneratePreviewString_Boolean == null)
				{
					r_GeneratePreviewString_Boolean = new(this, "GeneratePreviewString", 0, typeof(System.Boolean));
					r_GeneratePreviewString_Boolean.SetBelong(this.instance);
				}
				return r_GeneratePreviewString_Boolean;
			}
		}

		/// <summary>
		/// Void EnableCursorPreviewState()
		/// </summary>
		protected RMethod r_EnableCursorPreviewState;
		public virtual RMethod REnableCursorPreviewState
		{
			get
			{
				if(r_EnableCursorPreviewState == null)
				{
					r_EnableCursorPreviewState = new(this, "EnableCursorPreviewState", 0);
					r_EnableCursorPreviewState.SetBelong(this.instance);
				}
				return r_EnableCursorPreviewState;
			}
		}

		/// <summary>
		/// Void RestoreCursorState()
		/// </summary>
		protected RMethod r_RestoreCursorState;
		public virtual RMethod RRestoreCursorState
		{
			get
			{
				if(r_RestoreCursorState == null)
				{
					r_RestoreCursorState = new(this, "RestoreCursorState", 0);
					r_RestoreCursorState.SetBelong(this.instance);
				}
				return r_RestoreCursorState;
			}
		}

		/// <summary>
		/// Boolean HandleKeyEvent(UnityEngine.Event, Boolean)
		/// </summary>
		protected RMethod r_HandleKeyEvent_Event_Boolean;
		public virtual RMethod RHandleKeyEvent_Event_Boolean
		{
			get
			{
				if(r_HandleKeyEvent_Event_Boolean == null)
				{
					r_HandleKeyEvent_Event_Boolean = new(this, "HandleKeyEvent", 0, typeof(UnityEngine.Event), typeof(System.Boolean));
					r_HandleKeyEvent_Event_Boolean.SetBelong(this.instance);
				}
				return r_HandleKeyEvent_Event_Boolean;
			}
		}

		/// <summary>
		/// Boolean PerformOperation(UnityEngine.TextEditOp, Boolean)
		/// </summary>
		protected RMethod r_PerformOperation_TextEditOp_Boolean;
		public virtual RMethod RPerformOperation_TextEditOp_Boolean
		{
			get
			{
				if(r_PerformOperation_TextEditOp_Boolean == null)
				{
					r_PerformOperation_TextEditOp_Boolean = new(this, "PerformOperation", 0,  ReflectionUtils.GetType("UnityEngine.TextEditOp"), typeof(System.Boolean));
					r_PerformOperation_TextEditOp_Boolean.SetBelong(this.instance);
				}
				return r_PerformOperation_TextEditOp_Boolean;
			}
		}

		/// <summary>
		/// Void MapKey(System.String, UnityEngine.TextEditOp)
		/// </summary>
		protected static RMethod r_MapKey_String_TextEditOp;
		public static RMethod RMapKey_String_TextEditOp
		{
			get
			{
				if(r_MapKey_String_TextEditOp == null)
				{
					r_MapKey_String_TextEditOp = new( ReflectionUtils.GetType("UnityEngine.TextEditingUtilities"), "MapKey", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEngine.TextEditOp"));
					r_MapKey_String_TextEditOp.SetBelong(null);
				}
				return r_MapKey_String_TextEditOp;
			}
		}

		/// <summary>
		/// Void InitKeyActions()
		/// </summary>
		protected RMethod r_InitKeyActions;
		public virtual RMethod RInitKeyActions
		{
			get
			{
				if(r_InitKeyActions == null)
				{
					r_InitKeyActions = new(this, "InitKeyActions", 0);
					r_InitKeyActions.SetBelong(this.instance);
				}
				return r_InitKeyActions;
			}
		}

		/// <summary>
		/// Boolean DeleteLineBack()
		/// </summary>
		protected RMethod r_DeleteLineBack;
		public virtual RMethod RDeleteLineBack
		{
			get
			{
				if(r_DeleteLineBack == null)
				{
					r_DeleteLineBack = new(this, "DeleteLineBack", 0);
					r_DeleteLineBack.SetBelong(this.instance);
				}
				return r_DeleteLineBack;
			}
		}

		/// <summary>
		/// Boolean DeleteWordBack()
		/// </summary>
		protected RMethod r_DeleteWordBack;
		public virtual RMethod RDeleteWordBack
		{
			get
			{
				if(r_DeleteWordBack == null)
				{
					r_DeleteWordBack = new(this, "DeleteWordBack", 0);
					r_DeleteWordBack.SetBelong(this.instance);
				}
				return r_DeleteWordBack;
			}
		}

		/// <summary>
		/// Boolean DeleteWordForward()
		/// </summary>
		protected RMethod r_DeleteWordForward;
		public virtual RMethod RDeleteWordForward
		{
			get
			{
				if(r_DeleteWordForward == null)
				{
					r_DeleteWordForward = new(this, "DeleteWordForward", 0);
					r_DeleteWordForward.SetBelong(this.instance);
				}
				return r_DeleteWordForward;
			}
		}

		/// <summary>
		/// Boolean Delete()
		/// </summary>
		protected RMethod r_Delete;
		public virtual RMethod RDelete
		{
			get
			{
				if(r_Delete == null)
				{
					r_Delete = new(this, "Delete", 0);
					r_Delete.SetBelong(this.instance);
				}
				return r_Delete;
			}
		}

		/// <summary>
		/// Boolean Backspace()
		/// </summary>
		protected RMethod r_Backspace;
		public virtual RMethod RBackspace
		{
			get
			{
				if(r_Backspace == null)
				{
					r_Backspace = new(this, "Backspace", 0);
					r_Backspace.SetBelong(this.instance);
				}
				return r_Backspace;
			}
		}

		/// <summary>
		/// Boolean DeleteSelection()
		/// </summary>
		protected RMethod r_DeleteSelection;
		public virtual RMethod RDeleteSelection
		{
			get
			{
				if(r_DeleteSelection == null)
				{
					r_DeleteSelection = new(this, "DeleteSelection", 0);
					r_DeleteSelection.SetBelong(this.instance);
				}
				return r_DeleteSelection;
			}
		}

		/// <summary>
		/// Void ReplaceSelection(System.String)
		/// </summary>
		protected RMethod r_ReplaceSelection_String;
		public virtual RMethod RReplaceSelection_String
		{
			get
			{
				if(r_ReplaceSelection_String == null)
				{
					r_ReplaceSelection_String = new(this, "ReplaceSelection", 0, typeof(System.String));
					r_ReplaceSelection_String.SetBelong(this.instance);
				}
				return r_ReplaceSelection_String;
			}
		}

		/// <summary>
		/// Void Insert(Char)
		/// </summary>
		protected RMethod r_Insert_Char;
		public virtual RMethod RInsert_Char
		{
			get
			{
				if(r_Insert_Char == null)
				{
					r_Insert_Char = new(this, "Insert", 0, typeof(System.Char));
					r_Insert_Char.SetBelong(this.instance);
				}
				return r_Insert_Char;
			}
		}

		/// <summary>
		/// Void MoveSelectionToAltCursor()
		/// </summary>
		protected RMethod r_MoveSelectionToAltCursor;
		public virtual RMethod RMoveSelectionToAltCursor
		{
			get
			{
				if(r_MoveSelectionToAltCursor == null)
				{
					r_MoveSelectionToAltCursor = new(this, "MoveSelectionToAltCursor", 0);
					r_MoveSelectionToAltCursor.SetBelong(this.instance);
				}
				return r_MoveSelectionToAltCursor;
			}
		}

		/// <summary>
		/// Boolean CanPaste()
		/// </summary>
		protected RMethod r_CanPaste;
		public virtual RMethod RCanPaste
		{
			get
			{
				if(r_CanPaste == null)
				{
					r_CanPaste = new(this, "CanPaste", 0);
					r_CanPaste.SetBelong(this.instance);
				}
				return r_CanPaste;
			}
		}

		/// <summary>
		/// Boolean Cut()
		/// </summary>
		protected RMethod r_Cut;
		public virtual RMethod RCut
		{
			get
			{
				if(r_Cut == null)
				{
					r_Cut = new(this, "Cut", 0);
					r_Cut.SetBelong(this.instance);
				}
				return r_Cut;
			}
		}

		/// <summary>
		/// Boolean Paste()
		/// </summary>
		protected RMethod r_Paste;
		public virtual RMethod RPaste
		{
			get
			{
				if(r_Paste == null)
				{
					r_Paste = new(this, "Paste", 0);
					r_Paste.SetBelong(this.instance);
				}
				return r_Paste;
			}
		}

		/// <summary>
		/// System.String ReplaceNewlinesWithSpaces(System.String)
		/// </summary>
		protected static RMethod r_ReplaceNewlinesWithSpaces_String;
		public static RMethod RReplaceNewlinesWithSpaces_String
		{
			get
			{
				if(r_ReplaceNewlinesWithSpaces_String == null)
				{
					r_ReplaceNewlinesWithSpaces_String = new( ReflectionUtils.GetType("UnityEngine.TextEditingUtilities"), "ReplaceNewlinesWithSpaces", 0, typeof(System.String));
					r_ReplaceNewlinesWithSpaces_String.SetBelong(null);
				}
				return r_ReplaceNewlinesWithSpaces_String;
			}
		}

		/// <summary>
		/// Void OnBlur()
		/// </summary>
		protected RMethod r_OnBlur;
		public virtual RMethod ROnBlur
		{
			get
			{
				if(r_OnBlur == null)
				{
					r_OnBlur = new(this, "OnBlur", 0);
					r_OnBlur.SetBelong(this.instance);
				}
				return r_OnBlur;
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
            var ___result = RUpdateImeState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldUpdateImeWindowPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldUpdateImeWindowPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetImeWindowPosition(UnityEngine.Vector2  @worldPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition};
            var ___result = RSetImeWindowPosition_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GeneratePreviewString(System.Boolean  @richText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@richText};
            var ___result = RGeneratePreviewString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void EnableCursorPreviewState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnableCursorPreviewState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreCursorState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreCursorState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HandleKeyEvent(UnityEngine.Event  @e, System.Boolean  @textIsReadOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @textIsReadOnly};
            var ___result = RHandleKeyEvent_Event_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual void InitKeyActions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitKeyActions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DeleteLineBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteLineBack.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteWordBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteWordBack.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteWordForward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteWordForward.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Delete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDelete.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Backspace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBackspace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DeleteSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeleteSelection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReplaceSelection(System.String  @replace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replace};
            var ___result = RReplaceSelection_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RInsert_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveSelectionToAltCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveSelectionToAltCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanPaste()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanPaste.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Cut()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCut.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Paste()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPaste.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String ReplaceNewlinesWithSpaces(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RReplaceNewlinesWithSpaces_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void OnBlur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBlur.Invoke(___genericsType, ___parameters);

            
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
