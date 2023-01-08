using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.UITKTextHandle
	/// </summary>
    public partial class RUITKTextHandle : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 <MeasuredSizes>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___0__MeasuredSizes__1__k__BackingField;
		public virtual RUnityEngine.RVector2 R__0__MeasuredSizes__1__k__BackingField
		{
			get
			{
				if(r___0__MeasuredSizes__1__k__BackingField == null)
				{
					r___0__MeasuredSizes__1__k__BackingField = new(this, "<MeasuredSizes>k__BackingField");
					r___0__MeasuredSizes__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__MeasuredSizes__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <RoundedSizes>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___0__RoundedSizes__1__k__BackingField;
		public virtual RUnityEngine.RVector2 R__0__RoundedSizes__1__k__BackingField
		{
			get
			{
				if(r___0__RoundedSizes__1__k__BackingField == null)
				{
					r___0__RoundedSizes__1__k__BackingField = new(this, "<RoundedSizes>k__BackingField");
					r___0__RoundedSizes__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__RoundedSizes__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement m_TextElement
		/// </summary>
		protected RUnityEngine.RUIElements.RTextElement r_m_TextElement;
		public virtual RUnityEngine.RUIElements.RTextElement Rm_TextElement
		{
			get
			{
				if(r_m_TextElement == null)
				{
					r_m_TextElement = new(this, "m_TextElement");
					r_m_TextElement.SetBelong(this.instance);
				}
				return r_m_TextElement;
			}
		}

		/// <summary>
		/// System.Boolean isOverridingCursor
		/// </summary>
		protected RField r_isOverridingCursor;
		public virtual RField RisOverridingCursor
		{
			get
			{
				if(r_isOverridingCursor == null)
				{
					r_isOverridingCursor = new(this, "isOverridingCursor");
					r_isOverridingCursor.SetBelong(this.instance);
				}
				return r_isOverridingCursor;
			}
		}

		/// <summary>
		/// System.Int32 currentLinkIDHash
		/// </summary>
		protected RField r_currentLinkIDHash;
		public virtual RField RcurrentLinkIDHash
		{
			get
			{
				if(r_currentLinkIDHash == null)
				{
					r_currentLinkIDHash = new(this, "currentLinkIDHash");
					r_currentLinkIDHash.SetBelong(this.instance);
				}
				return r_currentLinkIDHash;
			}
		}

		/// <summary>
		/// System.Boolean hasLinkTag
		/// </summary>
		protected RField r_hasLinkTag;
		public virtual RField RhasLinkTag
		{
			get
			{
				if(r_hasLinkTag == null)
				{
					r_hasLinkTag = new(this, "hasLinkTag");
					r_hasLinkTag.SetBelong(this.instance);
				}
				return r_hasLinkTag;
			}
		}

		/// <summary>
		/// System.Boolean hasATag
		/// </summary>
		protected RField r_hasATag;
		public virtual RField RhasATag
		{
			get
			{
				if(r_hasATag == null)
				{
					r_hasATag = new(this, "hasATag");
					r_hasATag.SetBelong(this.instance);
				}
				return r_hasATag;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextGenerationSettings textGenerationSettings
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextGenerationSettings r_textGenerationSettings;
		public virtual RUnityEngine.RTextCore.RText.RTextGenerationSettings RtextGenerationSettings
		{
			get
			{
				if(r_textGenerationSettings == null)
				{
					r_textGenerationSettings = new(this, "textGenerationSettings");
					r_textGenerationSettings.SetBelong(this.instance);
				}
				return r_textGenerationSettings;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MeasuredSizes
		/// </summary>
		protected RUnityEngine.RVector2 r_MeasuredSizes;
		public virtual RUnityEngine.RVector2 RMeasuredSizes
		{
			get
			{
				if(r_MeasuredSizes == null)
				{
					r_MeasuredSizes = new(this, "MeasuredSizes", -1);
					r_MeasuredSizes.SetBelong(this.instance);
				}
				return r_MeasuredSizes;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 RoundedSizes
		/// </summary>
		protected RUnityEngine.RVector2 r_RoundedSizes;
		public virtual RUnityEngine.RVector2 RRoundedSizes
		{
			get
			{
				if(r_RoundedSizes == null)
				{
					r_RoundedSizes = new(this, "RoundedSizes", -1);
					r_RoundedSizes.SetBelong(this.instance);
				}
				return r_RoundedSizes;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo textInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextInfo r_textInfo;
		public virtual RUnityEngine.RTextCore.RText.RTextInfo RtextInfo
		{
			get
			{
				if(r_textInfo == null)
				{
					r_textInfo = new(this, "textInfo", -1);
					r_textInfo.SetBelong(this.instance);
				}
				return r_textInfo;
			}
		}

		/// <summary>
		/// Single ComputeTextWidth(System.String, Boolean, Single, Single)
		/// </summary>
		protected RMethod r_ComputeTextWidth_String_Boolean_Single_Single;
		public virtual RMethod RComputeTextWidth_String_Boolean_Single_Single
		{
			get
			{
				if(r_ComputeTextWidth_String_Boolean_Single_Single == null)
				{
					r_ComputeTextWidth_String_Boolean_Single_Single = new(this, "ComputeTextWidth", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Single), typeof(System.Single));
					r_ComputeTextWidth_String_Boolean_Single_Single.SetBelong(this.instance);
				}
				return r_ComputeTextWidth_String_Boolean_Single_Single;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(System.String, Single, Single)
		/// </summary>
		protected RMethod r_ComputeTextHeight_String_Single_Single;
		public virtual RMethod RComputeTextHeight_String_Single_Single
		{
			get
			{
				if(r_ComputeTextHeight_String_Single_Single == null)
				{
					r_ComputeTextHeight_String_Single_Single = new(this, "ComputeTextHeight", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_ComputeTextHeight_String_Single_Single.SetBelong(this.instance);
				}
				return r_ComputeTextHeight_String_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update()
		/// </summary>
		protected RMethod r_Update;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_Update == null)
				{
					r_Update = new(this, "Update", 0);
					r_Update.SetBelong(this.instance);
				}
				return r_Update;
			}
		}

		/// <summary>
		/// Void ATagOnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_ATagOnPointerUp_PointerUpEvent;
		public virtual RMethod RATagOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_ATagOnPointerUp_PointerUpEvent == null)
				{
					r_ATagOnPointerUp_PointerUpEvent = new(this, "ATagOnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
					r_ATagOnPointerUp_PointerUpEvent.SetBelong(this.instance);
				}
				return r_ATagOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerOver(UnityEngine.UIElements.PointerOverEvent)
		/// </summary>
		protected RMethod r_ATagOnPointerOver_PointerOverEvent;
		public virtual RMethod RATagOnPointerOver_PointerOverEvent
		{
			get
			{
				if(r_ATagOnPointerOver_PointerOverEvent == null)
				{
					r_ATagOnPointerOver_PointerOverEvent = new(this, "ATagOnPointerOver", 0, typeof(UnityEngine.UIElements.PointerOverEvent));
					r_ATagOnPointerOver_PointerOverEvent.SetBelong(this.instance);
				}
				return r_ATagOnPointerOver_PointerOverEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_ATagOnPointerMove_PointerMoveEvent;
		public virtual RMethod RATagOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_ATagOnPointerMove_PointerMoveEvent == null)
				{
					r_ATagOnPointerMove_PointerMoveEvent = new(this, "ATagOnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
					r_ATagOnPointerMove_PointerMoveEvent.SetBelong(this.instance);
				}
				return r_ATagOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerOut(UnityEngine.UIElements.PointerOutEvent)
		/// </summary>
		protected RMethod r_ATagOnPointerOut_PointerOutEvent;
		public virtual RMethod RATagOnPointerOut_PointerOutEvent
		{
			get
			{
				if(r_ATagOnPointerOut_PointerOutEvent == null)
				{
					r_ATagOnPointerOut_PointerOutEvent = new(this, "ATagOnPointerOut", 0, typeof(UnityEngine.UIElements.PointerOutEvent));
					r_ATagOnPointerOut_PointerOutEvent.SetBelong(this.instance);
				}
				return r_ATagOnPointerOut_PointerOutEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerDown(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_LinkTagOnPointerDown_PointerDownEvent;
		public virtual RMethod RLinkTagOnPointerDown_PointerDownEvent
		{
			get
			{
				if(r_LinkTagOnPointerDown_PointerDownEvent == null)
				{
					r_LinkTagOnPointerDown_PointerDownEvent = new(this, "LinkTagOnPointerDown", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
					r_LinkTagOnPointerDown_PointerDownEvent.SetBelong(this.instance);
				}
				return r_LinkTagOnPointerDown_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_LinkTagOnPointerUp_PointerUpEvent;
		public virtual RMethod RLinkTagOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_LinkTagOnPointerUp_PointerUpEvent == null)
				{
					r_LinkTagOnPointerUp_PointerUpEvent = new(this, "LinkTagOnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
					r_LinkTagOnPointerUp_PointerUpEvent.SetBelong(this.instance);
				}
				return r_LinkTagOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_LinkTagOnPointerMove_PointerMoveEvent;
		public virtual RMethod RLinkTagOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_LinkTagOnPointerMove_PointerMoveEvent == null)
				{
					r_LinkTagOnPointerMove_PointerMoveEvent = new(this, "LinkTagOnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
					r_LinkTagOnPointerMove_PointerMoveEvent.SetBelong(this.instance);
				}
				return r_LinkTagOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerOut(UnityEngine.UIElements.PointerOutEvent)
		/// </summary>
		protected RMethod r_LinkTagOnPointerOut_PointerOutEvent;
		public virtual RMethod RLinkTagOnPointerOut_PointerOutEvent
		{
			get
			{
				if(r_LinkTagOnPointerOut_PointerOutEvent == null)
				{
					r_LinkTagOnPointerOut_PointerOutEvent = new(this, "LinkTagOnPointerOut", 0, typeof(UnityEngine.UIElements.PointerOutEvent));
					r_LinkTagOnPointerOut_PointerOutEvent.SetBelong(this.instance);
				}
				return r_LinkTagOnPointerOut_PointerOutEvent;
			}
		}

		/// <summary>
		/// Void HandleLinkTag()
		/// </summary>
		protected RMethod r_HandleLinkTag;
		public virtual RMethod RHandleLinkTag
		{
			get
			{
				if(r_HandleLinkTag == null)
				{
					r_HandleLinkTag = new(this, "HandleLinkTag", 0);
					r_HandleLinkTag.SetBelong(this.instance);
				}
				return r_HandleLinkTag;
			}
		}

		/// <summary>
		/// Void HandleATag()
		/// </summary>
		protected RMethod r_HandleATag;
		public virtual RMethod RHandleATag
		{
			get
			{
				if(r_HandleATag == null)
				{
					r_HandleATag = new(this, "HandleATag", 0);
					r_HandleATag.SetBelong(this.instance);
				}
				return r_HandleATag;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode()
		/// </summary>
		protected RMethod r_GetTextOverflowMode;
		public virtual RMethod RGetTextOverflowMode
		{
			get
			{
				if(r_GetTextOverflowMode == null)
				{
					r_GetTextOverflowMode = new(this, "GetTextOverflowMode", 0);
					r_GetTextOverflowMode.SetBelong(this.instance);
				}
				return r_GetTextOverflowMode;
			}
		}

		/// <summary>
		/// Void ConvertUssToTextGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_ConvertUssToTextGenerationSettings_TextGenerationSettings;
		public virtual RMethod RConvertUssToTextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_ConvertUssToTextGenerationSettings_TextGenerationSettings == null)
				{
					r_ConvertUssToTextGenerationSettings_TextGenerationSettings = new(this, "ConvertUssToTextGenerationSettings", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_ConvertUssToTextGenerationSettings_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_ConvertUssToTextGenerationSettings_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Boolean TextLibraryCanElide()
		/// </summary>
		protected RMethod r_TextLibraryCanElide;
		public virtual RMethod RTextLibraryCanElide
		{
			get
			{
				if(r_TextLibraryCanElide == null)
				{
					r_TextLibraryCanElide = new(this, "TextLibraryCanElide", 0);
					r_TextLibraryCanElide.SetBelong(this.instance);
				}
				return r_TextLibraryCanElide;
			}
		}

		/// <summary>
		/// Boolean IsTextInfoAllocated()
		/// </summary>
		protected RMethod r_IsTextInfoAllocated;
		public virtual RMethod RIsTextInfoAllocated
		{
			get
			{
				if(r_IsTextInfoAllocated == null)
				{
					r_IsTextInfoAllocated = new(this, "IsTextInfoAllocated", 0);
					r_IsTextInfoAllocated.SetBelong(this.instance);
				}
				return r_IsTextInfoAllocated;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Boolean IsDirty()
		/// </summary>
		protected RMethod r_IsDirty;
		public virtual RMethod RIsDirty
		{
			get
			{
				if(r_IsDirty == null)
				{
					r_IsDirty = new(this, "IsDirty", 0);
					r_IsDirty.SetBelong(this.instance);
				}
				return r_IsDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(Int32, Boolean)
		/// </summary>
		protected RMethod r_GetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean;
		public virtual RMethod RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean
		{
			get
			{
				if(r_GetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean == null)
				{
					r_GetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean = new(this, "GetCursorPositionFromStringIndexUsingCharacterHeight", 0, typeof(System.Int32), typeof(System.Boolean));
					r_GetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean.SetBelong(this.instance);
				}
				return r_GetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_GetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean;
		public virtual RMethod RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean
		{
			get
			{
				if(r_GetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean == null)
				{
					r_GetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean = new(this, "GetCursorPositionFromStringIndexUsingLineHeight", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_GetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_GetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCursorIndexFromPosition(UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_GetCursorIndexFromPosition_Vector2_Boolean;
		public virtual RMethod RGetCursorIndexFromPosition_Vector2_Boolean
		{
			get
			{
				if(r_GetCursorIndexFromPosition_Vector2_Boolean == null)
				{
					r_GetCursorIndexFromPosition_Vector2_Boolean = new(this, "GetCursorIndexFromPosition", 0, typeof(UnityEngine.Vector2), typeof(System.Boolean));
					r_GetCursorIndexFromPosition_Vector2_Boolean.SetBelong(this.instance);
				}
				return r_GetCursorIndexFromPosition_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Int32 LineDownCharacterPosition(Int32)
		/// </summary>
		protected RMethod r_LineDownCharacterPosition_Int32;
		public virtual RMethod RLineDownCharacterPosition_Int32
		{
			get
			{
				if(r_LineDownCharacterPosition_Int32 == null)
				{
					r_LineDownCharacterPosition_Int32 = new(this, "LineDownCharacterPosition", 0, typeof(System.Int32));
					r_LineDownCharacterPosition_Int32.SetBelong(this.instance);
				}
				return r_LineDownCharacterPosition_Int32;
			}
		}

		/// <summary>
		/// Int32 LineUpCharacterPosition(Int32)
		/// </summary>
		protected RMethod r_LineUpCharacterPosition_Int32;
		public virtual RMethod RLineUpCharacterPosition_Int32
		{
			get
			{
				if(r_LineUpCharacterPosition_Int32 == null)
				{
					r_LineUpCharacterPosition_Int32 = new(this, "LineUpCharacterPosition", 0, typeof(System.Int32));
					r_LineUpCharacterPosition_Int32.SetBelong(this.instance);
				}
				return r_LineUpCharacterPosition_Int32;
			}
		}

		/// <summary>
		/// Int32 FindWordIndex(Int32)
		/// </summary>
		protected RMethod r_FindWordIndex_Int32;
		public virtual RMethod RFindWordIndex_Int32
		{
			get
			{
				if(r_FindWordIndex_Int32 == null)
				{
					r_FindWordIndex_Int32 = new(this, "FindWordIndex", 0, typeof(System.Int32));
					r_FindWordIndex_Int32.SetBelong(this.instance);
				}
				return r_FindWordIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 FindNearestLine(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_FindNearestLine_Vector2;
		public virtual RMethod RFindNearestLine_Vector2
		{
			get
			{
				if(r_FindNearestLine_Vector2 == null)
				{
					r_FindNearestLine_Vector2 = new(this, "FindNearestLine", 0, typeof(UnityEngine.Vector2));
					r_FindNearestLine_Vector2.SetBelong(this.instance);
				}
				return r_FindNearestLine_Vector2;
			}
		}

		/// <summary>
		/// Int32 FindNearestCharacterOnLine(UnityEngine.Vector2, Int32, Boolean)
		/// </summary>
		protected RMethod r_FindNearestCharacterOnLine_Vector2_Int32_Boolean;
		public virtual RMethod RFindNearestCharacterOnLine_Vector2_Int32_Boolean
		{
			get
			{
				if(r_FindNearestCharacterOnLine_Vector2_Int32_Boolean == null)
				{
					r_FindNearestCharacterOnLine_Vector2_Int32_Boolean = new(this, "FindNearestCharacterOnLine", 0, typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Boolean));
					r_FindNearestCharacterOnLine_Vector2_Int32_Boolean.SetBelong(this.instance);
				}
				return r_FindNearestCharacterOnLine_Vector2_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 FindIntersectingLink(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_FindIntersectingLink_Vector3_Boolean;
		public virtual RMethod RFindIntersectingLink_Vector3_Boolean
		{
			get
			{
				if(r_FindIntersectingLink_Vector3_Boolean == null)
				{
					r_FindIntersectingLink_Vector3_Boolean = new(this, "FindIntersectingLink", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_FindIntersectingLink_Vector3_Boolean.SetBelong(this.instance);
				}
				return r_FindIntersectingLink_Vector3_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetLineNumber(Int32)
		/// </summary>
		protected RMethod r_GetLineNumber_Int32;
		public virtual RMethod RGetLineNumber_Int32
		{
			get
			{
				if(r_GetLineNumber_Int32 == null)
				{
					r_GetLineNumber_Int32 = new(this, "GetLineNumber", 0, typeof(System.Int32));
					r_GetLineNumber_Int32.SetBelong(this.instance);
				}
				return r_GetLineNumber_Int32;
			}
		}

		/// <summary>
		/// Single GetLineHeight(Int32)
		/// </summary>
		protected RMethod r_GetLineHeight_Int32;
		public virtual RMethod RGetLineHeight_Int32
		{
			get
			{
				if(r_GetLineHeight_Int32 == null)
				{
					r_GetLineHeight_Int32 = new(this, "GetLineHeight", 0, typeof(System.Int32));
					r_GetLineHeight_Int32.SetBelong(this.instance);
				}
				return r_GetLineHeight_Int32;
			}
		}

		/// <summary>
		/// Single GetLineHeightFromCharacterIndex(Int32)
		/// </summary>
		protected RMethod r_GetLineHeightFromCharacterIndex_Int32;
		public virtual RMethod RGetLineHeightFromCharacterIndex_Int32
		{
			get
			{
				if(r_GetLineHeightFromCharacterIndex_Int32 == null)
				{
					r_GetLineHeightFromCharacterIndex_Int32 = new(this, "GetLineHeightFromCharacterIndex", 0, typeof(System.Int32));
					r_GetLineHeightFromCharacterIndex_Int32.SetBelong(this.instance);
				}
				return r_GetLineHeightFromCharacterIndex_Int32;
			}
		}

		/// <summary>
		/// Single GetCharacterHeightFromIndex(Int32)
		/// </summary>
		protected RMethod r_GetCharacterHeightFromIndex_Int32;
		public virtual RMethod RGetCharacterHeightFromIndex_Int32
		{
			get
			{
				if(r_GetCharacterHeightFromIndex_Int32 == null)
				{
					r_GetCharacterHeightFromIndex_Int32 = new(this, "GetCharacterHeightFromIndex", 0, typeof(System.Int32));
					r_GetCharacterHeightFromIndex_Int32.SetBelong(this.instance);
				}
				return r_GetCharacterHeightFromIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean IsElided()
		/// </summary>
		protected RMethod r_IsElided;
		public virtual RMethod RIsElided
		{
			get
			{
				if(r_IsElided == null)
				{
					r_IsElided = new(this, "IsElided", 0);
					r_IsElided.SetBelong(this.instance);
				}
				return r_IsElided;
			}
		}

		/// <summary>
		/// System.String Substring(Int32, Int32)
		/// </summary>
		protected RMethod r_Substring_Int32_Int32;
		public virtual RMethod RSubstring_Int32_Int32
		{
			get
			{
				if(r_Substring_Int32_Int32 == null)
				{
					r_Substring_Int32_Int32 = new(this, "Substring", 0, typeof(System.Int32), typeof(System.Int32));
					r_Substring_Int32_Int32.SetBelong(this.instance);
				}
				return r_Substring_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_IndexOf_Char_Int32;
		public virtual RMethod RIndexOf_Char_Int32
		{
			get
			{
				if(r_IndexOf_Char_Int32 == null)
				{
					r_IndexOf_Char_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_IndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_Char_Int32;
		public virtual RMethod RLastIndexOf_Char_Int32
		{
			get
			{
				if(r_LastIndexOf_Char_Int32 == null)
				{
					r_LastIndexOf_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_LastIndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Single ComputeTextWidth(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_ComputeTextWidth_TextGenerationSettings;
		public virtual RMethod RComputeTextWidth_TextGenerationSettings
		{
			get
			{
				if(r_ComputeTextWidth_TextGenerationSettings == null)
				{
					r_ComputeTextWidth_TextGenerationSettings = new(this, "ComputeTextWidth", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_ComputeTextWidth_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_ComputeTextWidth_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_ComputeTextHeight_TextGenerationSettings;
		public virtual RMethod RComputeTextHeight_TextGenerationSettings
		{
			get
			{
				if(r_ComputeTextHeight_TextGenerationSettings == null)
				{
					r_ComputeTextHeight_TextGenerationSettings = new(this, "ComputeTextHeight", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_ComputeTextHeight_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_ComputeTextHeight_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_UpdatePreferredValues_TextGenerationSettings;
		public virtual RMethod RUpdatePreferredValues_TextGenerationSettings
		{
			get
			{
				if(r_UpdatePreferredValues_TextGenerationSettings == null)
				{
					r_UpdatePreferredValues_TextGenerationSettings = new(this, "UpdatePreferredValues", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_UpdatePreferredValues_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_UpdatePreferredValues_TextGenerationSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(System.String)
		/// </summary>
		protected RMethod r_Update_String;
		public virtual RMethod RUpdate_String
		{
			get
			{
				if(r_Update_String == null)
				{
					r_Update_String = new(this, "Update", 0, typeof(System.String));
					r_Update_String.SetBelong(this.instance);
				}
				return r_Update_String;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_Update_TextGenerationSettings;
		public virtual RMethod RUpdate_TextGenerationSettings
		{
			get
			{
				if(r_Update_TextGenerationSettings == null)
				{
					r_Update_TextGenerationSettings = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_Update_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_Update_TextGenerationSettings;
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


        public RUITKTextHandle() : base("UnityEngine.UIElements.UITKTextHandle")
        {
        }

        public RUITKTextHandle(System.Object instance) : base("UnityEngine.UIElements.UITKTextHandle")
		{
            SetInstance(instance);
		}

        public RUITKTextHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUITKTextHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Single ComputeTextWidth(System.String  @textToMeasure, System.Boolean  @wordWrap, System.Single  @width, System.Single  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textToMeasure, @wordWrap, @width, @height};
            var ___result = RComputeTextWidth_String_Boolean_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ComputeTextHeight(System.String  @textToMeasure, System.Single  @width, System.Single  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textToMeasure, @width, @height};
            var ___result = RComputeTextHeight_String_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Object Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ATagOnPointerUp(UnityEngine.UIElements.PointerUpEvent  @pue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pue};
            var ___result = RATagOnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ATagOnPointerOver(UnityEngine.UIElements.PointerOverEvent  @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RATagOnPointerOver_PointerOverEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ATagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent  @pme)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pme};
            var ___result = RATagOnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ATagOnPointerOut(UnityEngine.UIElements.PointerOutEvent  @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RATagOnPointerOut_PointerOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerDown(UnityEngine.UIElements.PointerDownEvent  @pde)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pde};
            var ___result = RLinkTagOnPointerDown_PointerDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerUp(UnityEngine.UIElements.PointerUpEvent  @pue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pue};
            var ___result = RLinkTagOnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent  @pme)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pme};
            var ___result = RLinkTagOnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerOut(UnityEngine.UIElements.PointerOutEvent  @poe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@poe};
            var ___result = RLinkTagOnPointerOut_PointerOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleLinkTag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHandleLinkTag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleATag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHandleATag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetTextOverflowMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTextOverflowMode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ConvertUssToTextGenerationSettings(RUnityEngine.RTextCore.RText.RTextGenerationSettings  @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RConvertUssToTextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TextLibraryCanElide()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTextLibraryCanElide.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTextInfoAllocated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsTextInfoAllocated.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDirty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(System.Int32  @index, System.Boolean  @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @inverseYAxis};
            var ___result = RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(System.Int32  @index, System.Boolean  @useXAdvance, System.Boolean  @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @useXAdvance, @inverseYAxis};
            var ___result = RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 GetCursorIndexFromPosition(UnityEngine.Vector2  @position, System.Boolean  @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @inverseYAxis};
            var ___result = RGetCursorIndexFromPosition_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LineDownCharacterPosition(System.Int32  @originalPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalPos};
            var ___result = RLineDownCharacterPosition_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LineUpCharacterPosition(System.Int32  @originalPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalPos};
            var ___result = RLineUpCharacterPosition_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindWordIndex(System.Int32  @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorIndex};
            var ___result = RFindWordIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindNearestLine(UnityEngine.Vector2  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RFindNearestLine_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindNearestCharacterOnLine(UnityEngine.Vector2  @position, System.Int32  @line, System.Boolean  @visibleOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @line, @visibleOnly};
            var ___result = RFindNearestCharacterOnLine_Vector2_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindIntersectingLink(UnityEngine.Vector3  @position, System.Boolean  @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @inverseYAxis};
            var ___result = RFindIntersectingLink_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLineNumber(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetLineNumber_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single GetLineHeight(System.Int32  @lineNumber)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lineNumber};
            var ___result = RGetLineHeight_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetLineHeightFromCharacterIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetLineHeightFromCharacterIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetCharacterHeightFromIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetCharacterHeightFromIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean IsElided()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsElided.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String Substring(System.Int32  @startIndex, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RSubstring_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 IndexOf(System.Char  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RLastIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single ComputeTextWidth(RUnityEngine.RTextCore.RText.RTextGenerationSettings  @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RComputeTextWidth_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ComputeTextHeight(RUnityEngine.RTextCore.RText.RTextGenerationSettings  @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RComputeTextHeight_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void UpdatePreferredValues(RUnityEngine.RTextCore.RText.RTextGenerationSettings  @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RUpdatePreferredValues_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Update(System.String  @newText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newText};
            var ___result = RUpdate_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Update(RUnityEngine.RTextCore.RText.RTextGenerationSettings  @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RUpdate_TextGenerationSettings.Invoke(___genericsType, ___parameters);

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
