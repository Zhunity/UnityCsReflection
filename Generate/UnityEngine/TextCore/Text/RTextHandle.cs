using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextHandle
	/// </summary>
    public partial class RTextHandle : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 m_PreferredSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_PreferredSize;
		public virtual RUnityEngine.RVector2 Rm_PreferredSize
		{
			get
			{
				if(r_m_PreferredSize == null)
				{
					r_m_PreferredSize = new(this, "m_PreferredSize");
					r_m_PreferredSize.SetBelong(this.instance);
				}
				return r_m_PreferredSize;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo m_TextInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextInfo r_m_TextInfo;
		public virtual RUnityEngine.RTextCore.RText.RTextInfo Rm_TextInfo
		{
			get
			{
				if(r_m_TextInfo == null)
				{
					r_m_TextInfo = new(this, "m_TextInfo");
					r_m_TextInfo.SetBelong(this.instance);
				}
				return r_m_TextInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo m_LayoutTextInfo
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RTextInfo r_m_LayoutTextInfo;
		public static RUnityEngine.RTextCore.RText.RTextInfo Rm_LayoutTextInfo
		{
			get
			{
				if(r_m_LayoutTextInfo == null)
				{
					r_m_LayoutTextInfo = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextHandle"), "m_LayoutTextInfo");
					r_m_LayoutTextInfo.SetBelong(null);
				}
				return r_m_LayoutTextInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_PreviousGenerationSettingsHash
		/// </summary>
		protected RField r_m_PreviousGenerationSettingsHash;
		public virtual RField Rm_PreviousGenerationSettingsHash
		{
			get
			{
				if(r_m_PreviousGenerationSettingsHash == null)
				{
					r_m_PreviousGenerationSettingsHash = new(this, "m_PreviousGenerationSettingsHash");
					r_m_PreviousGenerationSettingsHash.SetBelong(this.instance);
				}
				return r_m_PreviousGenerationSettingsHash;
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
		/// UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RTextGenerationSettings r_s_LayoutSettings;
		public static RUnityEngine.RTextCore.RText.RTextGenerationSettings Rs_LayoutSettings
		{
			get
			{
				if(r_s_LayoutSettings == null)
				{
					r_s_LayoutSettings = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextHandle"), "s_LayoutSettings");
					r_s_LayoutSettings.SetBelong(null);
				}
				return r_s_LayoutSettings;
			}
		}

		/// <summary>
		/// System.Boolean isDirty
		/// </summary>
		protected RField r_isDirty;
		public virtual RField RisDirty
		{
			get
			{
				if(r_isDirty == null)
				{
					r_isDirty = new(this, "isDirty");
					r_isDirty.SetBelong(this.instance);
				}
				return r_isDirty;
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
		/// UnityEngine.TextCore.Text.TextInfo layoutTextInfo
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.RTextInfo r_layoutTextInfo;
		public static RUnityEngine.RTextCore.RText.RTextInfo RlayoutTextInfo
		{
			get
			{
				if(r_layoutTextInfo == null)
				{
					r_layoutTextInfo = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextHandle"), "layoutTextInfo", -1);
					r_layoutTextInfo.SetBelong(null);
				}
				return r_layoutTextInfo;
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
		/// Boolean PointIntersectRectangle(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3;
		public static RMethod RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3 == null)
				{
					r_RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3 = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextHandle"), "PointIntersectRectangle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3.SetBelong(null);
				}
				return r_RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single DistanceToLine(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RDistanceToLine_Vector3_Vector3_Vector3;
		public static RMethod RDistanceToLine_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_RDistanceToLine_Vector3_Vector3_Vector3 == null)
				{
					r_RDistanceToLine_Vector3_Vector3_Vector3 = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextHandle"), "DistanceToLine", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RDistanceToLine_Vector3_Vector3_Vector3.SetBelong(null);
				}
				return r_RDistanceToLine_Vector3_Vector3_Vector3;
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


        public RTextHandle() : base("UnityEngine.TextCore.Text.TextHandle")
        {
        }

        public RTextHandle(System.Object instance) : base("UnityEngine.TextCore.Text.TextHandle")
		{
            SetInstance(instance);
		}

        public RTextHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public static System.Boolean PointIntersectRectangle(UnityEngine.Vector3  @m, UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, UnityEngine.Vector3  @c, UnityEngine.Vector3  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @a, @b, @c, @d};
            var ___result = RPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single DistanceToLine(UnityEngine.Vector3  @a, UnityEngine.Vector3  @b, UnityEngine.Vector3  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @point};
            var ___result = RDistanceToLine_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
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
