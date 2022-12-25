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
		protected RUnityEngine.RVector2 r___1__MeasuredSizes__2__k__BackingField;
		public virtual RUnityEngine.RVector2 R__1__MeasuredSizes__2__k__BackingField
		{
			get
			{
				if(r___1__MeasuredSizes__2__k__BackingField == null)
				{
					r___1__MeasuredSizes__2__k__BackingField = new(this, "<MeasuredSizes>k__BackingField");
					r___1__MeasuredSizes__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__MeasuredSizes__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <RoundedSizes>k__BackingField
		/// </summary>
		protected RUnityEngine.RVector2 r___1__RoundedSizes__2__k__BackingField;
		public virtual RUnityEngine.RVector2 R__1__RoundedSizes__2__k__BackingField
		{
			get
			{
				if(r___1__RoundedSizes__2__k__BackingField == null)
				{
					r___1__RoundedSizes__2__k__BackingField = new(this, "<RoundedSizes>k__BackingField");
					r___1__RoundedSizes__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__RoundedSizes__2__k__BackingField;
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
		public virtual RUnityEngine.RVector2 RoundedSizes
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
		protected RMethod r_RComputeTextWidth_String_Boolean_Single_Single;
		public virtual RMethod RComputeTextWidth_String_Boolean_Single_Single
		{
			get
			{
				if(r_RComputeTextWidth_String_Boolean_Single_Single == null)
				{
					r_RComputeTextWidth_String_Boolean_Single_Single = new(this, "ComputeTextWidth", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Single), typeof(System.Single));
					r_RComputeTextWidth_String_Boolean_Single_Single.SetBelong(this.instance);
				}
				return r_RComputeTextWidth_String_Boolean_Single_Single;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(System.String, Single, Single)
		/// </summary>
		protected RMethod r_RComputeTextHeight_String_Single_Single;
		public virtual RMethod RComputeTextHeight_String_Single_Single
		{
			get
			{
				if(r_RComputeTextHeight_String_Single_Single == null)
				{
					r_RComputeTextHeight_String_Single_Single = new(this, "ComputeTextHeight", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_RComputeTextHeight_String_Single_Single.SetBelong(this.instance);
				}
				return r_RComputeTextHeight_String_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void ATagOnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_RATagOnPointerUp_PointerUpEvent;
		public virtual RMethod RATagOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_RATagOnPointerUp_PointerUpEvent == null)
				{
					r_RATagOnPointerUp_PointerUpEvent = new(this, "ATagOnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
					r_RATagOnPointerUp_PointerUpEvent.SetBelong(this.instance);
				}
				return r_RATagOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerOver(UnityEngine.UIElements.PointerOverEvent)
		/// </summary>
		protected RMethod r_RATagOnPointerOver_PointerOverEvent;
		public virtual RMethod RATagOnPointerOver_PointerOverEvent
		{
			get
			{
				if(r_RATagOnPointerOver_PointerOverEvent == null)
				{
					r_RATagOnPointerOver_PointerOverEvent = new(this, "ATagOnPointerOver", 0, typeof(UnityEngine.UIElements.PointerOverEvent));
					r_RATagOnPointerOver_PointerOverEvent.SetBelong(this.instance);
				}
				return r_RATagOnPointerOver_PointerOverEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_RATagOnPointerMove_PointerMoveEvent;
		public virtual RMethod RATagOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_RATagOnPointerMove_PointerMoveEvent == null)
				{
					r_RATagOnPointerMove_PointerMoveEvent = new(this, "ATagOnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
					r_RATagOnPointerMove_PointerMoveEvent.SetBelong(this.instance);
				}
				return r_RATagOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerOut(UnityEngine.UIElements.PointerOutEvent)
		/// </summary>
		protected RMethod r_RATagOnPointerOut_PointerOutEvent;
		public virtual RMethod RATagOnPointerOut_PointerOutEvent
		{
			get
			{
				if(r_RATagOnPointerOut_PointerOutEvent == null)
				{
					r_RATagOnPointerOut_PointerOutEvent = new(this, "ATagOnPointerOut", 0, typeof(UnityEngine.UIElements.PointerOutEvent));
					r_RATagOnPointerOut_PointerOutEvent.SetBelong(this.instance);
				}
				return r_RATagOnPointerOut_PointerOutEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerDown(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_RLinkTagOnPointerDown_PointerDownEvent;
		public virtual RMethod RLinkTagOnPointerDown_PointerDownEvent
		{
			get
			{
				if(r_RLinkTagOnPointerDown_PointerDownEvent == null)
				{
					r_RLinkTagOnPointerDown_PointerDownEvent = new(this, "LinkTagOnPointerDown", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
					r_RLinkTagOnPointerDown_PointerDownEvent.SetBelong(this.instance);
				}
				return r_RLinkTagOnPointerDown_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_RLinkTagOnPointerUp_PointerUpEvent;
		public virtual RMethod RLinkTagOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_RLinkTagOnPointerUp_PointerUpEvent == null)
				{
					r_RLinkTagOnPointerUp_PointerUpEvent = new(this, "LinkTagOnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
					r_RLinkTagOnPointerUp_PointerUpEvent.SetBelong(this.instance);
				}
				return r_RLinkTagOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_RLinkTagOnPointerMove_PointerMoveEvent;
		public virtual RMethod RLinkTagOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_RLinkTagOnPointerMove_PointerMoveEvent == null)
				{
					r_RLinkTagOnPointerMove_PointerMoveEvent = new(this, "LinkTagOnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
					r_RLinkTagOnPointerMove_PointerMoveEvent.SetBelong(this.instance);
				}
				return r_RLinkTagOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerOut(UnityEngine.UIElements.PointerOutEvent)
		/// </summary>
		protected RMethod r_RLinkTagOnPointerOut_PointerOutEvent;
		public virtual RMethod RLinkTagOnPointerOut_PointerOutEvent
		{
			get
			{
				if(r_RLinkTagOnPointerOut_PointerOutEvent == null)
				{
					r_RLinkTagOnPointerOut_PointerOutEvent = new(this, "LinkTagOnPointerOut", 0, typeof(UnityEngine.UIElements.PointerOutEvent));
					r_RLinkTagOnPointerOut_PointerOutEvent.SetBelong(this.instance);
				}
				return r_RLinkTagOnPointerOut_PointerOutEvent;
			}
		}

		/// <summary>
		/// Void HandleLinkTag()
		/// </summary>
		protected RMethod r_RHandleLinkTag;
		public virtual RMethod RHandleLinkTag
		{
			get
			{
				if(r_RHandleLinkTag == null)
				{
					r_RHandleLinkTag = new(this, "HandleLinkTag", 0);
					r_RHandleLinkTag.SetBelong(this.instance);
				}
				return r_RHandleLinkTag;
			}
		}

		/// <summary>
		/// Void HandleATag()
		/// </summary>
		protected RMethod r_RHandleATag;
		public virtual RMethod RHandleATag
		{
			get
			{
				if(r_RHandleATag == null)
				{
					r_RHandleATag = new(this, "HandleATag", 0);
					r_RHandleATag.SetBelong(this.instance);
				}
				return r_RHandleATag;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode()
		/// </summary>
		protected RMethod r_RGetTextOverflowMode;
		public virtual RMethod RGetTextOverflowMode
		{
			get
			{
				if(r_RGetTextOverflowMode == null)
				{
					r_RGetTextOverflowMode = new(this, "GetTextOverflowMode", 0);
					r_RGetTextOverflowMode.SetBelong(this.instance);
				}
				return r_RGetTextOverflowMode;
			}
		}

		/// <summary>
		/// Void ConvertUssToTextGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_RConvertUssToTextGenerationSettings_TextGenerationSettings;
		public virtual RMethod RConvertUssToTextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_RConvertUssToTextGenerationSettings_TextGenerationSettings == null)
				{
					r_RConvertUssToTextGenerationSettings_TextGenerationSettings = new(this, "ConvertUssToTextGenerationSettings", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_RConvertUssToTextGenerationSettings_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_RConvertUssToTextGenerationSettings_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Boolean TextLibraryCanElide()
		/// </summary>
		protected RMethod r_RTextLibraryCanElide;
		public virtual RMethod RTextLibraryCanElide
		{
			get
			{
				if(r_RTextLibraryCanElide == null)
				{
					r_RTextLibraryCanElide = new(this, "TextLibraryCanElide", 0);
					r_RTextLibraryCanElide.SetBelong(this.instance);
				}
				return r_RTextLibraryCanElide;
			}
		}

		/// <summary>
		/// Boolean IsTextInfoAllocated()
		/// </summary>
		protected RMethod r_RIsTextInfoAllocated;
		public virtual RMethod RIsTextInfoAllocated
		{
			get
			{
				if(r_RIsTextInfoAllocated == null)
				{
					r_RIsTextInfoAllocated = new(this, "IsTextInfoAllocated", 0);
					r_RIsTextInfoAllocated.SetBelong(this.instance);
				}
				return r_RIsTextInfoAllocated;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Boolean IsDirty()
		/// </summary>
		protected RMethod r_RIsDirty;
		public virtual RMethod RIsDirty
		{
			get
			{
				if(r_RIsDirty == null)
				{
					r_RIsDirty = new(this, "IsDirty", 0);
					r_RIsDirty.SetBelong(this.instance);
				}
				return r_RIsDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean;
		public virtual RMethod RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean
		{
			get
			{
				if(r_RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean == null)
				{
					r_RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean = new(this, "GetCursorPositionFromStringIndexUsingCharacterHeight", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean;
		public virtual RMethod RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean
		{
			get
			{
				if(r_RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean == null)
				{
					r_RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean = new(this, "GetCursorPositionFromStringIndexUsingLineHeight", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCursorIndexFromPosition(UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_RGetCursorIndexFromPosition_Vector2_Boolean;
		public virtual RMethod RGetCursorIndexFromPosition_Vector2_Boolean
		{
			get
			{
				if(r_RGetCursorIndexFromPosition_Vector2_Boolean == null)
				{
					r_RGetCursorIndexFromPosition_Vector2_Boolean = new(this, "GetCursorIndexFromPosition", 0, typeof(UnityEngine.Vector2), typeof(System.Boolean));
					r_RGetCursorIndexFromPosition_Vector2_Boolean.SetBelong(this.instance);
				}
				return r_RGetCursorIndexFromPosition_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Int32 LineDownCharacterPosition(Int32)
		/// </summary>
		protected RMethod r_RLineDownCharacterPosition_Int32;
		public virtual RMethod RLineDownCharacterPosition_Int32
		{
			get
			{
				if(r_RLineDownCharacterPosition_Int32 == null)
				{
					r_RLineDownCharacterPosition_Int32 = new(this, "LineDownCharacterPosition", 0, typeof(System.Int32));
					r_RLineDownCharacterPosition_Int32.SetBelong(this.instance);
				}
				return r_RLineDownCharacterPosition_Int32;
			}
		}

		/// <summary>
		/// Int32 LineUpCharacterPosition(Int32)
		/// </summary>
		protected RMethod r_RLineUpCharacterPosition_Int32;
		public virtual RMethod RLineUpCharacterPosition_Int32
		{
			get
			{
				if(r_RLineUpCharacterPosition_Int32 == null)
				{
					r_RLineUpCharacterPosition_Int32 = new(this, "LineUpCharacterPosition", 0, typeof(System.Int32));
					r_RLineUpCharacterPosition_Int32.SetBelong(this.instance);
				}
				return r_RLineUpCharacterPosition_Int32;
			}
		}

		/// <summary>
		/// Int32 FindWordIndex(Int32)
		/// </summary>
		protected RMethod r_RFindWordIndex_Int32;
		public virtual RMethod RFindWordIndex_Int32
		{
			get
			{
				if(r_RFindWordIndex_Int32 == null)
				{
					r_RFindWordIndex_Int32 = new(this, "FindWordIndex", 0, typeof(System.Int32));
					r_RFindWordIndex_Int32.SetBelong(this.instance);
				}
				return r_RFindWordIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 FindNearestLine(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RFindNearestLine_Vector2;
		public virtual RMethod RFindNearestLine_Vector2
		{
			get
			{
				if(r_RFindNearestLine_Vector2 == null)
				{
					r_RFindNearestLine_Vector2 = new(this, "FindNearestLine", 0, typeof(UnityEngine.Vector2));
					r_RFindNearestLine_Vector2.SetBelong(this.instance);
				}
				return r_RFindNearestLine_Vector2;
			}
		}

		/// <summary>
		/// Int32 FindNearestCharacterOnLine(UnityEngine.Vector2, Int32, Boolean)
		/// </summary>
		protected RMethod r_RFindNearestCharacterOnLine_Vector2_Int32_Boolean;
		public virtual RMethod RFindNearestCharacterOnLine_Vector2_Int32_Boolean
		{
			get
			{
				if(r_RFindNearestCharacterOnLine_Vector2_Int32_Boolean == null)
				{
					r_RFindNearestCharacterOnLine_Vector2_Int32_Boolean = new(this, "FindNearestCharacterOnLine", 0, typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Boolean));
					r_RFindNearestCharacterOnLine_Vector2_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RFindNearestCharacterOnLine_Vector2_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 FindIntersectingLink(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_RFindIntersectingLink_Vector3_Boolean;
		public virtual RMethod RFindIntersectingLink_Vector3_Boolean
		{
			get
			{
				if(r_RFindIntersectingLink_Vector3_Boolean == null)
				{
					r_RFindIntersectingLink_Vector3_Boolean = new(this, "FindIntersectingLink", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RFindIntersectingLink_Vector3_Boolean.SetBelong(this.instance);
				}
				return r_RFindIntersectingLink_Vector3_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetLineNumber(Int32)
		/// </summary>
		protected RMethod r_RGetLineNumber_Int32;
		public virtual RMethod RGetLineNumber_Int32
		{
			get
			{
				if(r_RGetLineNumber_Int32 == null)
				{
					r_RGetLineNumber_Int32 = new(this, "GetLineNumber", 0, typeof(System.Int32));
					r_RGetLineNumber_Int32.SetBelong(this.instance);
				}
				return r_RGetLineNumber_Int32;
			}
		}

		/// <summary>
		/// Single GetLineHeight(Int32)
		/// </summary>
		protected RMethod r_RGetLineHeight_Int32;
		public virtual RMethod RGetLineHeight_Int32
		{
			get
			{
				if(r_RGetLineHeight_Int32 == null)
				{
					r_RGetLineHeight_Int32 = new(this, "GetLineHeight", 0, typeof(System.Int32));
					r_RGetLineHeight_Int32.SetBelong(this.instance);
				}
				return r_RGetLineHeight_Int32;
			}
		}

		/// <summary>
		/// Single GetLineHeightFromCharacterIndex(Int32)
		/// </summary>
		protected RMethod r_RGetLineHeightFromCharacterIndex_Int32;
		public virtual RMethod RGetLineHeightFromCharacterIndex_Int32
		{
			get
			{
				if(r_RGetLineHeightFromCharacterIndex_Int32 == null)
				{
					r_RGetLineHeightFromCharacterIndex_Int32 = new(this, "GetLineHeightFromCharacterIndex", 0, typeof(System.Int32));
					r_RGetLineHeightFromCharacterIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetLineHeightFromCharacterIndex_Int32;
			}
		}

		/// <summary>
		/// Single GetCharacterHeightFromIndex(Int32)
		/// </summary>
		protected RMethod r_RGetCharacterHeightFromIndex_Int32;
		public virtual RMethod RGetCharacterHeightFromIndex_Int32
		{
			get
			{
				if(r_RGetCharacterHeightFromIndex_Int32 == null)
				{
					r_RGetCharacterHeightFromIndex_Int32 = new(this, "GetCharacterHeightFromIndex", 0, typeof(System.Int32));
					r_RGetCharacterHeightFromIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetCharacterHeightFromIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean IsElided()
		/// </summary>
		protected RMethod r_RIsElided;
		public virtual RMethod RIsElided
		{
			get
			{
				if(r_RIsElided == null)
				{
					r_RIsElided = new(this, "IsElided", 0);
					r_RIsElided.SetBelong(this.instance);
				}
				return r_RIsElided;
			}
		}

		/// <summary>
		/// System.String Substring(Int32, Int32)
		/// </summary>
		protected RMethod r_RSubstring_Int32_Int32;
		public virtual RMethod RSubstring_Int32_Int32
		{
			get
			{
				if(r_RSubstring_Int32_Int32 == null)
				{
					r_RSubstring_Int32_Int32 = new(this, "Substring", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSubstring_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSubstring_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_RIndexOf_Char_Int32;
		public virtual RMethod RIndexOf_Char_Int32
		{
			get
			{
				if(r_RIndexOf_Char_Int32 == null)
				{
					r_RIndexOf_Char_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_RIndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_RIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_RLastIndexOf_Char_Int32;
		public virtual RMethod RLastIndexOf_Char_Int32
		{
			get
			{
				if(r_RLastIndexOf_Char_Int32 == null)
				{
					r_RLastIndexOf_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32));
					r_RLastIndexOf_Char_Int32.SetBelong(this.instance);
				}
				return r_RLastIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Single ComputeTextWidth(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_RComputeTextWidth_TextGenerationSettings;
		public virtual RMethod RComputeTextWidth_TextGenerationSettings
		{
			get
			{
				if(r_RComputeTextWidth_TextGenerationSettings == null)
				{
					r_RComputeTextWidth_TextGenerationSettings = new(this, "ComputeTextWidth", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_RComputeTextWidth_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_RComputeTextWidth_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_RComputeTextHeight_TextGenerationSettings;
		public virtual RMethod RComputeTextHeight_TextGenerationSettings
		{
			get
			{
				if(r_RComputeTextHeight_TextGenerationSettings == null)
				{
					r_RComputeTextHeight_TextGenerationSettings = new(this, "ComputeTextHeight", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_RComputeTextHeight_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_RComputeTextHeight_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_RUpdatePreferredValues_TextGenerationSettings;
		public virtual RMethod RUpdatePreferredValues_TextGenerationSettings
		{
			get
			{
				if(r_RUpdatePreferredValues_TextGenerationSettings == null)
				{
					r_RUpdatePreferredValues_TextGenerationSettings = new(this, "UpdatePreferredValues", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_RUpdatePreferredValues_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_RUpdatePreferredValues_TextGenerationSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(System.String)
		/// </summary>
		protected RMethod r_RUpdate_String;
		public virtual RMethod RUpdate_String
		{
			get
			{
				if(r_RUpdate_String == null)
				{
					r_RUpdate_String = new(this, "Update", 0, typeof(System.String));
					r_RUpdate_String.SetBelong(this.instance);
				}
				return r_RUpdate_String;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_RUpdate_TextGenerationSettings;
		public virtual RMethod RUpdate_TextGenerationSettings
		{
			get
			{
				if(r_RUpdate_TextGenerationSettings == null)
				{
					r_RUpdate_TextGenerationSettings = new(this, "Update", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
					r_RUpdate_TextGenerationSettings.SetBelong(this.instance);
				}
				return r_RUpdate_TextGenerationSettings;
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





        public virtual System.Object Update(System.String  @newText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newText};
            var ___result = RUpdate_String.Invoke(___genericsType, ___parameters);

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
