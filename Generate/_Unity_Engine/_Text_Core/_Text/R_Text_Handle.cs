
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.TextCore.Text.TextHandle
	/// </summary>
    public partial class RTextHandle : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextHandle");
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


		/// <summary>
		/// UnityEngine.Vector2 m_PreferredSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_PreferredSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_PreferredSize
		{
			get
			{
				if(r_Fm_PreferredSize == null)
				{
					r_Fm_PreferredSize = new(this, "m_PreferredSize");
				}
				return r_Fm_PreferredSize;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo m_TextInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo r_Fm_TextInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo RFm_TextInfo
		{
			get
			{
				if(r_Fm_TextInfo == null)
				{
					r_Fm_TextInfo = new(this, "m_TextInfo");
				}
				return r_Fm_TextInfo;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo m_LayoutTextInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo r_Fm_LayoutTextInfo;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo RFm_LayoutTextInfo
		{
			get
			{
				if(r_Fm_LayoutTextInfo == null)
				{
					r_Fm_LayoutTextInfo = new(Type, "m_LayoutTextInfo");
				}
				return r_Fm_LayoutTextInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_PreviousGenerationSettingsHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_PreviousGenerationSettingsHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_PreviousGenerationSettingsHash
		{
			get
			{
				if(r_Fm_PreviousGenerationSettingsHash == null)
				{
					r_Fm_PreviousGenerationSettingsHash = new(this, "m_PreviousGenerationSettingsHash");
				}
				return r_Fm_PreviousGenerationSettingsHash;
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
		/// UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings r_Fs_LayoutSettings;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings RFs_LayoutSettings
		{
			get
			{
				if(r_Fs_LayoutSettings == null)
				{
					r_Fs_LayoutSettings = new(Type, "s_LayoutSettings");
				}
				return r_Fs_LayoutSettings;
			}
		}

		/// <summary>
		/// System.Boolean isDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisDirty
		{
			get
			{
				if(r_FisDirty == null)
				{
					r_FisDirty = new(this, "isDirty");
				}
				return r_FisDirty;
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
		/// UnityEngine.TextCore.Text.TextInfo layoutTextInfo
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo r_PlayoutTextInfo;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo RPlayoutTextInfo
		{
			get
			{
				if(r_PlayoutTextInfo == null)
				{
					r_PlayoutTextInfo = new(Type, "layoutTextInfo", -1);
				}
				return r_PlayoutTextInfo;
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
		/// Boolean PointIntersectRectangle(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3;
		public static RMethod RMPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_MPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3 == null)
				{
					r_MPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3 = new(Type, "PointIntersectRectangle", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Single DistanceToLine(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MDistanceToLine_Vector3_Vector3_Vector3;
		public static RMethod RMDistanceToLine_Vector3_Vector3_Vector3
		{
			get
			{
				if(r_MDistanceToLine_Vector3_Vector3_Vector3 == null)
				{
					r_MDistanceToLine_Vector3_Vector3_Vector3 = new(Type, "DistanceToLine", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
				}
				return r_MDistanceToLine_Vector3_Vector3_Vector3;
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


        public virtual System.Boolean IsTextInfoAllocated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsTextInfoAllocated.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(System.Int32 @index, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @inverseYAxis};
            var ___result = RMGetCursorPositionFromStringIndexUsingCharacterHeight_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual UnityEngine.Vector2 GetCursorPositionFromStringIndexUsingLineHeight(System.Int32 @index, System.Boolean @useXAdvance, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @useXAdvance, @inverseYAxis};
            var ___result = RMGetCursorPositionFromStringIndexUsingLineHeight_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual System.Int32 GetCursorIndexFromPosition(UnityEngine.Vector2 @position, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @inverseYAxis};
            var ___result = RMGetCursorIndexFromPosition_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 LineDownCharacterPosition(System.Int32 @originalPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalPos};
            var ___result = RMLineDownCharacterPosition_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 LineUpCharacterPosition(System.Int32 @originalPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalPos};
            var ___result = RMLineUpCharacterPosition_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindWordIndex(System.Int32 @cursorIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorIndex};
            var ___result = RMFindWordIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindNearestLine(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMFindNearestLine_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindNearestCharacterOnLine(UnityEngine.Vector2 @position, System.Int32 @line, System.Boolean @visibleOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @line, @visibleOnly};
            var ___result = RMFindNearestCharacterOnLine_Vector2_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 FindIntersectingLink(UnityEngine.Vector3 @position, System.Boolean @inverseYAxis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @inverseYAxis};
            var ___result = RMFindIntersectingLink_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean PointIntersectRectangle(UnityEngine.Vector3 @m, UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, UnityEngine.Vector3 @c, UnityEngine.Vector3 @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @a, @b, @c, @d};
            var ___result = RMPointIntersectRectangle_Vector3_Vector3_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Single DistanceToLine(UnityEngine.Vector3 @a, UnityEngine.Vector3 @b, UnityEngine.Vector3 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @point};
            var ___result = RMDistanceToLine_Vector3_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Int32 GetLineNumber(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetLineNumber_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Single GetLineHeight(System.Int32 @lineNumber)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lineNumber};
            var ___result = RMGetLineHeight_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single GetLineHeightFromCharacterIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetLineHeightFromCharacterIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single GetCharacterHeightFromIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetCharacterHeightFromIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Boolean IsElided()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsElided.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String Substring(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMSubstring_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 IndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 LastIndexOf(System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex};
            var ___result = RMLastIndexOf_Char_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Single ComputeTextWidth(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMComputeTextWidth_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Single ComputeTextHeight(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMComputeTextHeight_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
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

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo Update(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextGenerationSettings @tgs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tgs.Value};
            var ___result = RMUpdate_TextGenerationSettings.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo>(___result);
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
