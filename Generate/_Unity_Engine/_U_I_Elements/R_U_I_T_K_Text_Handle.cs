
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.UITKTextHandle
	/// </summary>
    public partial class RUITKTextHandle : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 <MeasuredSizes>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__MeasuredSizes__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__MeasuredSizes__1__k__BackingField
		{
			get
			{
				if(r_F__0__MeasuredSizes__1__k__BackingField == null)
				{
					r_F__0__MeasuredSizes__1__k__BackingField = new(this, "<MeasuredSizes>k__BackingField");
				}
				return r_F__0__MeasuredSizes__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <RoundedSizes>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__RoundedSizes__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__RoundedSizes__1__k__BackingField
		{
			get
			{
				if(r_F__0__RoundedSizes__1__k__BackingField == null)
				{
					r_F__0__RoundedSizes__1__k__BackingField = new(this, "<RoundedSizes>k__BackingField");
				}
				return r_F__0__RoundedSizes__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextElement m_TextElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement r_Fm_TextElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextElement RFm_TextElement
		{
			get
			{
				if(r_Fm_TextElement == null)
				{
					r_Fm_TextElement = new(this, "m_TextElement");
				}
				return r_Fm_TextElement;
			}
		}

		/// <summary>
		/// System.Boolean isOverridingCursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisOverridingCursor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisOverridingCursor
		{
			get
			{
				if(r_FisOverridingCursor == null)
				{
					r_FisOverridingCursor = new(this, "isOverridingCursor");
				}
				return r_FisOverridingCursor;
			}
		}

		/// <summary>
		/// System.Int32 currentLinkIDHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcurrentLinkIDHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcurrentLinkIDHash
		{
			get
			{
				if(r_FcurrentLinkIDHash == null)
				{
					r_FcurrentLinkIDHash = new(this, "currentLinkIDHash");
				}
				return r_FcurrentLinkIDHash;
			}
		}

		/// <summary>
		/// System.Boolean hasLinkTag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhasLinkTag;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhasLinkTag
		{
			get
			{
				if(r_FhasLinkTag == null)
				{
					r_FhasLinkTag = new(this, "hasLinkTag");
				}
				return r_FhasLinkTag;
			}
		}

		/// <summary>
		/// System.Boolean hasATag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FhasATag;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFhasATag
		{
			get
			{
				if(r_FhasATag == null)
				{
					r_FhasATag = new(this, "hasATag");
				}
				return r_FhasATag;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextGenerationSettings textGenerationSettings
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings r_FtextGenerationSettings;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings RFtextGenerationSettings
		{
			get
			{
				if(r_FtextGenerationSettings == null)
				{
					r_FtextGenerationSettings = new(this, "textGenerationSettings");
				}
				return r_FtextGenerationSettings;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MeasuredSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PMeasuredSizes;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPMeasuredSizes
		{
			get
			{
				if(r_PMeasuredSizes == null)
				{
					r_PMeasuredSizes = new(this, "MeasuredSizes", -1);
				}
				return r_PMeasuredSizes;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 RoundedSizes
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PRoundedSizes;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPRoundedSizes
		{
			get
			{
				if(r_PRoundedSizes == null)
				{
					r_PRoundedSizes = new(this, "RoundedSizes", -1);
				}
				return r_PRoundedSizes;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo textInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo r_PtextInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo RPtextInfo
		{
			get
			{
				if(r_PtextInfo == null)
				{
					r_PtextInfo = new(this, "textInfo", -1);
				}
				return r_PtextInfo;
			}
		}

		/// <summary>
		/// Single ComputeTextWidth(System.String, Boolean, Single, Single)
		/// </summary>
		protected RMethod r_MComputeTextWidth_String_Boolean_Single_Single;
		public virtual RMethod RMComputeTextWidth_String_Boolean_Single_Single
		{
			get
			{
				if(r_MComputeTextWidth_String_Boolean_Single_Single == null)
				{
					r_MComputeTextWidth_String_Boolean_Single_Single = new(this, "ComputeTextWidth", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Single), typeof(System.Single));
				}
				return r_MComputeTextWidth_String_Boolean_Single_Single;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(System.String, Single, Single)
		/// </summary>
		protected RMethod r_MComputeTextHeight_String_Single_Single;
		public virtual RMethod RMComputeTextHeight_String_Single_Single
		{
			get
			{
				if(r_MComputeTextHeight_String_Single_Single == null)
				{
					r_MComputeTextHeight_String_Single_Single = new(this, "ComputeTextHeight", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
				}
				return r_MComputeTextHeight_String_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void ATagOnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_MATagOnPointerUp_PointerUpEvent;
		public virtual RMethod RMATagOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_MATagOnPointerUp_PointerUpEvent == null)
				{
					r_MATagOnPointerUp_PointerUpEvent = new(this, "ATagOnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
				}
				return r_MATagOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerOver(UnityEngine.UIElements.PointerOverEvent)
		/// </summary>
		protected RMethod r_MATagOnPointerOver_PointerOverEvent;
		public virtual RMethod RMATagOnPointerOver_PointerOverEvent
		{
			get
			{
				if(r_MATagOnPointerOver_PointerOverEvent == null)
				{
					r_MATagOnPointerOver_PointerOverEvent = new(this, "ATagOnPointerOver", 0, typeof(UnityEngine.UIElements.PointerOverEvent));
				}
				return r_MATagOnPointerOver_PointerOverEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_MATagOnPointerMove_PointerMoveEvent;
		public virtual RMethod RMATagOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_MATagOnPointerMove_PointerMoveEvent == null)
				{
					r_MATagOnPointerMove_PointerMoveEvent = new(this, "ATagOnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
				}
				return r_MATagOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void ATagOnPointerOut(UnityEngine.UIElements.PointerOutEvent)
		/// </summary>
		protected RMethod r_MATagOnPointerOut_PointerOutEvent;
		public virtual RMethod RMATagOnPointerOut_PointerOutEvent
		{
			get
			{
				if(r_MATagOnPointerOut_PointerOutEvent == null)
				{
					r_MATagOnPointerOut_PointerOutEvent = new(this, "ATagOnPointerOut", 0, typeof(UnityEngine.UIElements.PointerOutEvent));
				}
				return r_MATagOnPointerOut_PointerOutEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerDown(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_MLinkTagOnPointerDown_PointerDownEvent;
		public virtual RMethod RMLinkTagOnPointerDown_PointerDownEvent
		{
			get
			{
				if(r_MLinkTagOnPointerDown_PointerDownEvent == null)
				{
					r_MLinkTagOnPointerDown_PointerDownEvent = new(this, "LinkTagOnPointerDown", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
				}
				return r_MLinkTagOnPointerDown_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_MLinkTagOnPointerUp_PointerUpEvent;
		public virtual RMethod RMLinkTagOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_MLinkTagOnPointerUp_PointerUpEvent == null)
				{
					r_MLinkTagOnPointerUp_PointerUpEvent = new(this, "LinkTagOnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
				}
				return r_MLinkTagOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_MLinkTagOnPointerMove_PointerMoveEvent;
		public virtual RMethod RMLinkTagOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_MLinkTagOnPointerMove_PointerMoveEvent == null)
				{
					r_MLinkTagOnPointerMove_PointerMoveEvent = new(this, "LinkTagOnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
				}
				return r_MLinkTagOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void LinkTagOnPointerOut(UnityEngine.UIElements.PointerOutEvent)
		/// </summary>
		protected RMethod r_MLinkTagOnPointerOut_PointerOutEvent;
		public virtual RMethod RMLinkTagOnPointerOut_PointerOutEvent
		{
			get
			{
				if(r_MLinkTagOnPointerOut_PointerOutEvent == null)
				{
					r_MLinkTagOnPointerOut_PointerOutEvent = new(this, "LinkTagOnPointerOut", 0, typeof(UnityEngine.UIElements.PointerOutEvent));
				}
				return r_MLinkTagOnPointerOut_PointerOutEvent;
			}
		}

		/// <summary>
		/// Void HandleLinkTag()
		/// </summary>
		protected RMethod r_MHandleLinkTag;
		public virtual RMethod RMHandleLinkTag
		{
			get
			{
				if(r_MHandleLinkTag == null)
				{
					r_MHandleLinkTag = new(this, "HandleLinkTag", 0);
				}
				return r_MHandleLinkTag;
			}
		}

		/// <summary>
		/// Void HandleATag()
		/// </summary>
		protected RMethod r_MHandleATag;
		public virtual RMethod RMHandleATag
		{
			get
			{
				if(r_MHandleATag == null)
				{
					r_MHandleATag = new(this, "HandleATag", 0);
				}
				return r_MHandleATag;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode()
		/// </summary>
		protected RMethod r_MGetTextOverflowMode;
		public virtual RMethod RMGetTextOverflowMode
		{
			get
			{
				if(r_MGetTextOverflowMode == null)
				{
					r_MGetTextOverflowMode = new(this, "GetTextOverflowMode", 0);
				}
				return r_MGetTextOverflowMode;
			}
		}

		/// <summary>
		/// Void ConvertUssToTextGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_MConvertUssToTextGenerationSettings_TextGenerationSettings;
		public virtual RMethod RMConvertUssToTextGenerationSettings_TextGenerationSettings
		{
			get
			{
				if(r_MConvertUssToTextGenerationSettings_TextGenerationSettings == null)
				{
					r_MConvertUssToTextGenerationSettings_TextGenerationSettings = new(this, "ConvertUssToTextGenerationSettings", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_MConvertUssToTextGenerationSettings_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Boolean TextLibraryCanElide()
		/// </summary>
		protected RMethod r_MTextLibraryCanElide;
		public virtual RMethod RMTextLibraryCanElide
		{
			get
			{
				if(r_MTextLibraryCanElide == null)
				{
					r_MTextLibraryCanElide = new(this, "TextLibraryCanElide", 0);
				}
				return r_MTextLibraryCanElide;
			}
		}

		/// <summary>
		/// Boolean IsTextInfoAllocated()
		/// </summary>
		protected RMethod r_MIsTextInfoAllocated;
		public virtual RMethod RMIsTextInfoAllocated
		{
			get
			{
				if(r_MIsTextInfoAllocated == null)
				{
					r_MIsTextInfoAllocated = new(this, "IsTextInfoAllocated", 0);
				}
				return r_MIsTextInfoAllocated;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Boolean IsDirty()
		/// </summary>
		protected RMethod r_MIsDirty;
		public virtual RMethod RMIsDirty
		{
			get
			{
				if(r_MIsDirty == null)
				{
					r_MIsDirty = new(this, "IsDirty", 0);
				}
				return r_MIsDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(Int32, Boolean)
		/// </summary>
		protected RMethod r_MGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean;
		public virtual RMethod RMGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean
		{
			get
			{
				if(r_MGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean == null)
				{
					r_MGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean = new(this, "GetCursorPositionFromStringIndexUsingCharacterHeight", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(Int32, Boolean, Boolean)
		/// </summary>
		protected RMethod r_MGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean;
		public virtual RMethod RMGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean == null)
				{
					r_MGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean = new(this, "GetCursorPositionFromStringIndexUsingLineHeight", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCursorIndexFromPosition(UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_MGetCursorIndexFromPosition_Vector2_Boolean;
		public virtual RMethod RMGetCursorIndexFromPosition_Vector2_Boolean
		{
			get
			{
				if(r_MGetCursorIndexFromPosition_Vector2_Boolean == null)
				{
					r_MGetCursorIndexFromPosition_Vector2_Boolean = new(this, "GetCursorIndexFromPosition", 0, typeof(UnityEngine.Vector2), typeof(System.Boolean));
				}
				return r_MGetCursorIndexFromPosition_Vector2_Boolean;
			}
		}

		/// <summary>
		/// Int32 LineDownCharacterPosition(Int32)
		/// </summary>
		protected RMethod r_MLineDownCharacterPosition_Int32;
		public virtual RMethod RMLineDownCharacterPosition_Int32
		{
			get
			{
				if(r_MLineDownCharacterPosition_Int32 == null)
				{
					r_MLineDownCharacterPosition_Int32 = new(this, "LineDownCharacterPosition", 0, typeof(System.Int32));
				}
				return r_MLineDownCharacterPosition_Int32;
			}
		}

		/// <summary>
		/// Int32 LineUpCharacterPosition(Int32)
		/// </summary>
		protected RMethod r_MLineUpCharacterPosition_Int32;
		public virtual RMethod RMLineUpCharacterPosition_Int32
		{
			get
			{
				if(r_MLineUpCharacterPosition_Int32 == null)
				{
					r_MLineUpCharacterPosition_Int32 = new(this, "LineUpCharacterPosition", 0, typeof(System.Int32));
				}
				return r_MLineUpCharacterPosition_Int32;
			}
		}

		/// <summary>
		/// Int32 FindWordIndex(Int32)
		/// </summary>
		protected RMethod r_MFindWordIndex_Int32;
		public virtual RMethod RMFindWordIndex_Int32
		{
			get
			{
				if(r_MFindWordIndex_Int32 == null)
				{
					r_MFindWordIndex_Int32 = new(this, "FindWordIndex", 0, typeof(System.Int32));
				}
				return r_MFindWordIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 FindNearestLine(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MFindNearestLine_Vector2;
		public virtual RMethod RMFindNearestLine_Vector2
		{
			get
			{
				if(r_MFindNearestLine_Vector2 == null)
				{
					r_MFindNearestLine_Vector2 = new(this, "FindNearestLine", 0, typeof(UnityEngine.Vector2));
				}
				return r_MFindNearestLine_Vector2;
			}
		}

		/// <summary>
		/// Int32 FindNearestCharacterOnLine(UnityEngine.Vector2, Int32, Boolean)
		/// </summary>
		protected RMethod r_MFindNearestCharacterOnLine_Vector2_Int32_Boolean;
		public virtual RMethod RMFindNearestCharacterOnLine_Vector2_Int32_Boolean
		{
			get
			{
				if(r_MFindNearestCharacterOnLine_Vector2_Int32_Boolean == null)
				{
					r_MFindNearestCharacterOnLine_Vector2_Int32_Boolean = new(this, "FindNearestCharacterOnLine", 0, typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MFindNearestCharacterOnLine_Vector2_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 FindIntersectingLink(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_MFindIntersectingLink_Vector3_Boolean;
		public virtual RMethod RMFindIntersectingLink_Vector3_Boolean
		{
			get
			{
				if(r_MFindIntersectingLink_Vector3_Boolean == null)
				{
					r_MFindIntersectingLink_Vector3_Boolean = new(this, "FindIntersectingLink", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
				}
				return r_MFindIntersectingLink_Vector3_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetLineNumber(Int32)
		/// </summary>
		protected RMethod r_MGetLineNumber_Int32;
		public virtual RMethod RMGetLineNumber_Int32
		{
			get
			{
				if(r_MGetLineNumber_Int32 == null)
				{
					r_MGetLineNumber_Int32 = new(this, "GetLineNumber", 0, typeof(System.Int32));
				}
				return r_MGetLineNumber_Int32;
			}
		}

		/// <summary>
		/// Single GetLineHeight(Int32)
		/// </summary>
		protected RMethod r_MGetLineHeight_Int32;
		public virtual RMethod RMGetLineHeight_Int32
		{
			get
			{
				if(r_MGetLineHeight_Int32 == null)
				{
					r_MGetLineHeight_Int32 = new(this, "GetLineHeight", 0, typeof(System.Int32));
				}
				return r_MGetLineHeight_Int32;
			}
		}

		/// <summary>
		/// Single GetLineHeightFromCharacterIndex(Int32)
		/// </summary>
		protected RMethod r_MGetLineHeightFromCharacterIndex_Int32;
		public virtual RMethod RMGetLineHeightFromCharacterIndex_Int32
		{
			get
			{
				if(r_MGetLineHeightFromCharacterIndex_Int32 == null)
				{
					r_MGetLineHeightFromCharacterIndex_Int32 = new(this, "GetLineHeightFromCharacterIndex", 0, typeof(System.Int32));
				}
				return r_MGetLineHeightFromCharacterIndex_Int32;
			}
		}

		/// <summary>
		/// Single GetCharacterHeightFromIndex(Int32)
		/// </summary>
		protected RMethod r_MGetCharacterHeightFromIndex_Int32;
		public virtual RMethod RMGetCharacterHeightFromIndex_Int32
		{
			get
			{
				if(r_MGetCharacterHeightFromIndex_Int32 == null)
				{
					r_MGetCharacterHeightFromIndex_Int32 = new(this, "GetCharacterHeightFromIndex", 0, typeof(System.Int32));
				}
				return r_MGetCharacterHeightFromIndex_Int32;
			}
		}

		/// <summary>
		/// Boolean IsElided()
		/// </summary>
		protected RMethod r_MIsElided;
		public virtual RMethod RMIsElided
		{
			get
			{
				if(r_MIsElided == null)
				{
					r_MIsElided = new(this, "IsElided", 0);
				}
				return r_MIsElided;
			}
		}

		/// <summary>
		/// System.String Substring(Int32, Int32)
		/// </summary>
		protected RMethod r_MSubstring_Int32_Int32;
		public virtual RMethod RMSubstring_Int32_Int32
		{
			get
			{
				if(r_MSubstring_Int32_Int32 == null)
				{
					r_MSubstring_Int32_Int32 = new(this, "Substring", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSubstring_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_Char_Int32;
		public virtual RMethod RMIndexOf_Char_Int32
		{
			get
			{
				if(r_MIndexOf_Char_Int32 == null)
				{
					r_MIndexOf_Char_Int32 = new(this, "IndexOf", 0, typeof(System.Char), typeof(System.Int32));
				}
				return r_MIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(Char, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_Char_Int32;
		public virtual RMethod RMLastIndexOf_Char_Int32
		{
			get
			{
				if(r_MLastIndexOf_Char_Int32 == null)
				{
					r_MLastIndexOf_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.Char), typeof(System.Int32));
				}
				return r_MLastIndexOf_Char_Int32;
			}
		}

		/// <summary>
		/// Single ComputeTextWidth(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_MComputeTextWidth_TextGenerationSettings;
		public virtual RMethod RMComputeTextWidth_TextGenerationSettings
		{
			get
			{
				if(r_MComputeTextWidth_TextGenerationSettings == null)
				{
					r_MComputeTextWidth_TextGenerationSettings = new(this, "ComputeTextWidth", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_MComputeTextWidth_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Single ComputeTextHeight(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_MComputeTextHeight_TextGenerationSettings;
		public virtual RMethod RMComputeTextHeight_TextGenerationSettings
		{
			get
			{
				if(r_MComputeTextHeight_TextGenerationSettings == null)
				{
					r_MComputeTextHeight_TextGenerationSettings = new(this, "ComputeTextHeight", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_MComputeTextHeight_TextGenerationSettings;
			}
		}

		/// <summary>
		/// Void UpdatePreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_MUpdatePreferredValues_TextGenerationSettings;
		public virtual RMethod RMUpdatePreferredValues_TextGenerationSettings
		{
			get
			{
				if(r_MUpdatePreferredValues_TextGenerationSettings == null)
				{
					r_MUpdatePreferredValues_TextGenerationSettings = new(this, "UpdatePreferredValues", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_MUpdatePreferredValues_TextGenerationSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(System.String)
		/// </summary>
		protected RMethod r_MUpdate_String;
		public virtual RMethod RMUpdate_String
		{
			get
			{
				if(r_MUpdate_String == null)
				{
					r_MUpdate_String = new(this, "Update", 0, typeof(System.String));
				}
				return r_MUpdate_String;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.TextCore.Text.TextGenerationSettings)
		/// </summary>
		protected RMethod r_MUpdate_TextGenerationSettings;
		public virtual RMethod RMUpdate_TextGenerationSettings
		{
			get
			{
				if(r_MUpdate_TextGenerationSettings == null)
				{
					r_MUpdate_TextGenerationSettings = new(this, "Update", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextGenerationSettings"));
				}
				return r_MUpdate_TextGenerationSettings;
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

        public virtual System.Single ComputeTextWidth(System.String @textToMeasure, System.Boolean @wordWrap, System.Single @width, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textToMeasure, @wordWrap, @width, @height};
            var ___result = RMComputeTextWidth_String_Boolean_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ComputeTextHeight(System.String @textToMeasure, System.Single @width, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textToMeasure, @width, @height};
            var ___result = RMComputeTextHeight_String_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo(___result);
        }


        public virtual void ATagOnPointerUp(UnityEngine.UIElements.PointerUpEvent @pue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pue};
            var ___result = RMATagOnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ATagOnPointerOver(UnityEngine.UIElements.PointerOverEvent @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RMATagOnPointerOver_PointerOverEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ATagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent @pme)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pme};
            var ___result = RMATagOnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ATagOnPointerOut(UnityEngine.UIElements.PointerOutEvent @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = RMATagOnPointerOut_PointerOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerDown(UnityEngine.UIElements.PointerDownEvent @pde)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pde};
            var ___result = RMLinkTagOnPointerDown_PointerDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerUp(UnityEngine.UIElements.PointerUpEvent @pue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pue};
            var ___result = RMLinkTagOnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerMove(UnityEngine.UIElements.PointerMoveEvent @pme)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pme};
            var ___result = RMLinkTagOnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LinkTagOnPointerOut(UnityEngine.UIElements.PointerOutEvent @poe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@poe};
            var ___result = RMLinkTagOnPointerOut_PointerOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleLinkTag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHandleLinkTag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleATag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHandleATag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextOverflowMode GetTextOverflowMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTextOverflowMode.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextOverflowMode(___result);
        }


        public virtual void ConvertUssToTextGenerationSettings(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMConvertUssToTextGenerationSettings_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TextLibraryCanElide()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTextLibraryCanElide.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTextInfoAllocated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsTextInfoAllocated.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDirty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(System.Int32 @index, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @inverseYAxis};
            var ___result = RMGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(System.Int32 @index, System.Boolean @useXAdvance, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @useXAdvance, @inverseYAxis};
            var ___result = RMGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Int32 GetCursorIndexFromPosition(UnityEngine.Vector2 @position, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @inverseYAxis};
            var ___result = RMGetCursorIndexFromPosition_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LineDownCharacterPosition(System.Int32 @originalPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalPos};
            var ___result = RMLineDownCharacterPosition_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LineUpCharacterPosition(System.Int32 @originalPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalPos};
            var ___result = RMLineUpCharacterPosition_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindWordIndex(System.Int32 @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorIndex};
            var ___result = RMFindWordIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindNearestLine(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMFindNearestLine_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindNearestCharacterOnLine(UnityEngine.Vector2 @position, System.Int32 @line, System.Boolean @visibleOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @line, @visibleOnly};
            var ___result = RMFindNearestCharacterOnLine_Vector2_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 FindIntersectingLink(UnityEngine.Vector3 @position, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @inverseYAxis};
            var ___result = RMFindIntersectingLink_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetLineNumber(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetLineNumber_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single GetLineHeight(System.Int32 @lineNumber)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lineNumber};
            var ___result = RMGetLineHeight_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetLineHeightFromCharacterIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetLineHeightFromCharacterIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetCharacterHeightFromIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetCharacterHeightFromIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean IsElided()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsElided.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String Substring(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMSubstring_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMLastIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single ComputeTextWidth(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMComputeTextWidth_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ComputeTextHeight(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMComputeTextHeight_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void UpdatePreferredValues(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMUpdatePreferredValues_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo Update(System.String @newText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newText};
            var ___result = RMUpdate_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo Update(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMUpdate_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo(___result);
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
