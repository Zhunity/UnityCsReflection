using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.__DTString
	/// </summary>
    public partial class R__DTString : RMember //
    {

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] Value
		/// </summary>
		protected RSystem.RReadOnlySpan<RField> r_Value;
		public virtual RSystem.RReadOnlySpan<RField> RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value");
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// System.Int32 Index
		/// </summary>
		protected RField r_Index;
		public virtual RField RIndex
		{
			get
			{
				if(r_Index == null)
				{
					r_Index = new(this, "Index");
					r_Index.SetBelong(this.instance);
				}
				return r_Index;
			}
		}

		/// <summary>
		/// System.Char m_current
		/// </summary>
		protected RField r_m_current;
		public virtual RField Rm_current
		{
			get
			{
				if(r_m_current == null)
				{
					r_m_current = new(this, "m_current");
					r_m_current.SetBelong(this.instance);
				}
				return r_m_current;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo m_info
		/// </summary>
		protected RSystem.RGlobalization.RCompareInfo r_m_info;
		public virtual RSystem.RGlobalization.RCompareInfo Rm_info
		{
			get
			{
				if(r_m_info == null)
				{
					r_m_info = new(this, "m_info");
					r_m_info.SetBelong(this.instance);
				}
				return r_m_info;
			}
		}

		/// <summary>
		/// System.Boolean m_checkDigitToken
		/// </summary>
		protected RField r_m_checkDigitToken;
		public virtual RField Rm_checkDigitToken
		{
			get
			{
				if(r_m_checkDigitToken == null)
				{
					r_m_checkDigitToken = new(this, "m_checkDigitToken");
					r_m_checkDigitToken.SetBelong(this.instance);
				}
				return r_m_checkDigitToken;
			}
		}

		/// <summary>
		/// System.Char[] WhiteSpaceChecks
		/// </summary>
		protected static RFieldArray<RField> r_WhiteSpaceChecks;
		public static RFieldArray<RField> RWhiteSpaceChecks
		{
			get
			{
				if(r_WhiteSpaceChecks == null)
				{
					r_WhiteSpaceChecks = new( ReleactionUtils.GetType("System.__DTString"), "WhiteSpaceChecks");
					r_WhiteSpaceChecks.SetBelong(null);
				}
				return r_WhiteSpaceChecks;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo CompareInfo
		/// </summary>
		protected RSystem.RGlobalization.RCompareInfo r_CompareInfo;
		public virtual RSystem.RGlobalization.RCompareInfo RCompareInfo
		{
			get
			{
				if(r_CompareInfo == null)
				{
					r_CompareInfo = new(this, "CompareInfo", -1);
					r_CompareInfo.SetBelong(this.instance);
				}
				return r_CompareInfo;
			}
		}

		/// <summary>
		/// Boolean GetNext()
		/// </summary>
		protected RMethod r_GetNext;
		public virtual RMethod RGetNext
		{
			get
			{
				if(r_GetNext == null)
				{
					r_GetNext = new(this, "GetNext", 0);
					r_GetNext.SetBelong(this.instance);
				}
				return r_GetNext;
			}
		}

		/// <summary>
		/// Boolean AtEnd()
		/// </summary>
		protected RMethod r_AtEnd;
		public virtual RMethod RAtEnd
		{
			get
			{
				if(r_AtEnd == null)
				{
					r_AtEnd = new(this, "AtEnd", 0);
					r_AtEnd.SetBelong(this.instance);
				}
				return r_AtEnd;
			}
		}

		/// <summary>
		/// Boolean Advance(Int32)
		/// </summary>
		protected RMethod r_Advance_Int32;
		public virtual RMethod RAdvance_Int32
		{
			get
			{
				if(r_Advance_Int32 == null)
				{
					r_Advance_Int32 = new(this, "Advance", 0, typeof(System.Int32));
					r_Advance_Int32.SetBelong(this.instance);
				}
				return r_Advance_Int32;
			}
		}

		/// <summary>
		/// Void GetRegularToken(System.TokenType ByRef, Int32 ByRef, System.Globalization.DateTimeFormatInfo)
		/// </summary>
		protected RMethod r_GetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo;
		public virtual RMethod RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo
		{
			get
			{
				if(r_GetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo == null)
				{
					r_GetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo = new(this, "GetRegularToken", 0,  ReleactionUtils.GetType("System.TokenType").MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Globalization.DateTimeFormatInfo));
					r_GetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo.SetBelong(this.instance);
				}
				return r_GetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo;
			}
		}

		/// <summary>
		/// System.TokenType GetSeparatorToken(System.Globalization.DateTimeFormatInfo, Int32 ByRef, Char ByRef)
		/// </summary>
		protected RMethod r_GetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char;
		public virtual RMethod RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char
		{
			get
			{
				if(r_GetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char == null)
				{
					r_GetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char = new(this, "GetSeparatorToken", 0, typeof(System.Globalization.DateTimeFormatInfo), typeof(System.Int32).MakeByRefType(), typeof(System.Char).MakeByRefType());
					r_GetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char.SetBelong(this.instance);
				}
				return r_GetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char;
			}
		}

		/// <summary>
		/// Boolean MatchSpecifiedWord(System.String)
		/// </summary>
		protected RMethod r_MatchSpecifiedWord_String;
		public virtual RMethod RMatchSpecifiedWord_String
		{
			get
			{
				if(r_MatchSpecifiedWord_String == null)
				{
					r_MatchSpecifiedWord_String = new(this, "MatchSpecifiedWord", 0, typeof(System.String));
					r_MatchSpecifiedWord_String.SetBelong(this.instance);
				}
				return r_MatchSpecifiedWord_String;
			}
		}

		/// <summary>
		/// Boolean MatchSpecifiedWords(System.String, Boolean, Int32 ByRef)
		/// </summary>
		protected RMethod r_MatchSpecifiedWords_String_Boolean_Ref_Int32;
		public virtual RMethod RMatchSpecifiedWords_String_Boolean_Ref_Int32
		{
			get
			{
				if(r_MatchSpecifiedWords_String_Boolean_Ref_Int32 == null)
				{
					r_MatchSpecifiedWords_String_Boolean_Ref_Int32 = new(this, "MatchSpecifiedWords", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_MatchSpecifiedWords_String_Boolean_Ref_Int32.SetBelong(this.instance);
				}
				return r_MatchSpecifiedWords_String_Boolean_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean Match(System.String)
		/// </summary>
		protected RMethod r_Match_String;
		public virtual RMethod RMatch_String
		{
			get
			{
				if(r_Match_String == null)
				{
					r_Match_String = new(this, "Match", 0, typeof(System.String));
					r_Match_String.SetBelong(this.instance);
				}
				return r_Match_String;
			}
		}

		/// <summary>
		/// Boolean Match(Char)
		/// </summary>
		protected RMethod r_Match_Char;
		public virtual RMethod RMatch_Char
		{
			get
			{
				if(r_Match_Char == null)
				{
					r_Match_Char = new(this, "Match", 0, typeof(System.Char));
					r_Match_Char.SetBelong(this.instance);
				}
				return r_Match_Char;
			}
		}

		/// <summary>
		/// Int32 MatchLongestWords(System.String[], Int32 ByRef)
		/// </summary>
		protected RMethod r_MatchLongestWords_StringArray_Ref_Int32;
		public virtual RMethod RMatchLongestWords_StringArray_Ref_Int32
		{
			get
			{
				if(r_MatchLongestWords_StringArray_Ref_Int32 == null)
				{
					r_MatchLongestWords_StringArray_Ref_Int32 = new(this, "MatchLongestWords", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_MatchLongestWords_StringArray_Ref_Int32.SetBelong(this.instance);
				}
				return r_MatchLongestWords_StringArray_Ref_Int32;
			}
		}

		/// <summary>
		/// Int32 GetRepeatCount()
		/// </summary>
		protected RMethod r_GetRepeatCount;
		public virtual RMethod RGetRepeatCount
		{
			get
			{
				if(r_GetRepeatCount == null)
				{
					r_GetRepeatCount = new(this, "GetRepeatCount", 0);
					r_GetRepeatCount.SetBelong(this.instance);
				}
				return r_GetRepeatCount;
			}
		}

		/// <summary>
		/// Boolean GetNextDigit()
		/// </summary>
		protected RMethod r_GetNextDigit;
		public virtual RMethod RGetNextDigit
		{
			get
			{
				if(r_GetNextDigit == null)
				{
					r_GetNextDigit = new(this, "GetNextDigit", 0);
					r_GetNextDigit.SetBelong(this.instance);
				}
				return r_GetNextDigit;
			}
		}

		/// <summary>
		/// Char GetChar()
		/// </summary>
		protected RMethod r_GetChar;
		public virtual RMethod RGetChar
		{
			get
			{
				if(r_GetChar == null)
				{
					r_GetChar = new(this, "GetChar", 0);
					r_GetChar.SetBelong(this.instance);
				}
				return r_GetChar;
			}
		}

		/// <summary>
		/// Int32 GetDigit()
		/// </summary>
		protected RMethod r_GetDigit;
		public virtual RMethod RGetDigit
		{
			get
			{
				if(r_GetDigit == null)
				{
					r_GetDigit = new(this, "GetDigit", 0);
					r_GetDigit.SetBelong(this.instance);
				}
				return r_GetDigit;
			}
		}

		/// <summary>
		/// Void SkipWhiteSpaces()
		/// </summary>
		protected RMethod r_SkipWhiteSpaces;
		public virtual RMethod RSkipWhiteSpaces
		{
			get
			{
				if(r_SkipWhiteSpaces == null)
				{
					r_SkipWhiteSpaces = new(this, "SkipWhiteSpaces", 0);
					r_SkipWhiteSpaces.SetBelong(this.instance);
				}
				return r_SkipWhiteSpaces;
			}
		}

		/// <summary>
		/// Boolean SkipWhiteSpaceCurrent()
		/// </summary>
		protected RMethod r_SkipWhiteSpaceCurrent;
		public virtual RMethod RSkipWhiteSpaceCurrent
		{
			get
			{
				if(r_SkipWhiteSpaceCurrent == null)
				{
					r_SkipWhiteSpaceCurrent = new(this, "SkipWhiteSpaceCurrent", 0);
					r_SkipWhiteSpaceCurrent.SetBelong(this.instance);
				}
				return r_SkipWhiteSpaceCurrent;
			}
		}

		/// <summary>
		/// Void TrimTail()
		/// </summary>
		protected RMethod r_TrimTail;
		public virtual RMethod RTrimTail
		{
			get
			{
				if(r_TrimTail == null)
				{
					r_TrimTail = new(this, "TrimTail", 0);
					r_TrimTail.SetBelong(this.instance);
				}
				return r_TrimTail;
			}
		}

		/// <summary>
		/// Void RemoveTrailingInQuoteSpaces()
		/// </summary>
		protected RMethod r_RemoveTrailingInQuoteSpaces;
		public virtual RMethod RRemoveTrailingInQuoteSpaces
		{
			get
			{
				if(r_RemoveTrailingInQuoteSpaces == null)
				{
					r_RemoveTrailingInQuoteSpaces = new(this, "RemoveTrailingInQuoteSpaces", 0);
					r_RemoveTrailingInQuoteSpaces.SetBelong(this.instance);
				}
				return r_RemoveTrailingInQuoteSpaces;
			}
		}

		/// <summary>
		/// Void RemoveLeadingInQuoteSpaces()
		/// </summary>
		protected RMethod r_RemoveLeadingInQuoteSpaces;
		public virtual RMethod RRemoveLeadingInQuoteSpaces
		{
			get
			{
				if(r_RemoveLeadingInQuoteSpaces == null)
				{
					r_RemoveLeadingInQuoteSpaces = new(this, "RemoveLeadingInQuoteSpaces", 0);
					r_RemoveLeadingInQuoteSpaces.SetBelong(this.instance);
				}
				return r_RemoveLeadingInQuoteSpaces;
			}
		}

		/// <summary>
		/// System.DTSubString GetSubString()
		/// </summary>
		protected RMethod r_GetSubString;
		public virtual RMethod RGetSubString
		{
			get
			{
				if(r_GetSubString == null)
				{
					r_GetSubString = new(this, "GetSubString", 0);
					r_GetSubString.SetBelong(this.instance);
				}
				return r_GetSubString;
			}
		}

		/// <summary>
		/// Void ConsumeSubString(System.DTSubString)
		/// </summary>
		protected RMethod r_ConsumeSubString_DTSubString;
		public virtual RMethod RConsumeSubString_DTSubString
		{
			get
			{
				if(r_ConsumeSubString_DTSubString == null)
				{
					r_ConsumeSubString_DTSubString = new(this, "ConsumeSubString", 0,  ReleactionUtils.GetType("System.DTSubString"));
					r_ConsumeSubString_DTSubString.SetBelong(this.instance);
				}
				return r_ConsumeSubString_DTSubString;
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


        public R__DTString() : base("System.__DTString")
        {
        }

        public R__DTString(System.Object instance) : base("System.__DTString")
		{
            SetInstance(instance);
		}

        public R__DTString(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__DTString(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean GetNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AtEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAtEnd.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Advance(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RAdvance_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Object GetSeparatorToken(System.Globalization.DateTimeFormatInfo  @dtfi, out System.Int32  @indexBeforeSeparator, out System.Char  @charBeforeSeparator)
        {
			indexBeforeSeparator = default;
			charBeforeSeparator = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dtfi, @indexBeforeSeparator, @charBeforeSeparator};
            var ___result = RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char.Invoke(___genericsType, ___parameters);
			indexBeforeSeparator = (System.Int32)___parameters[1];
			charBeforeSeparator = (System.Char)___parameters[2];

            return (System.Object)___result;
        }


        public virtual System.Boolean MatchSpecifiedWord(System.String  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMatchSpecifiedWord_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchSpecifiedWords(System.String  @target, System.Boolean  @checkWordBoundary, ref System.Int32  @matchLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @checkWordBoundary, @matchLength};
            var ___result = RMatchSpecifiedWords_String_Boolean_Ref_Int32.Invoke(___genericsType, ___parameters);
			matchLength = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Match(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMatch_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Match(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMatch_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 MatchLongestWords(System.String[]  @words, ref System.Int32  @maxMatchStrLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@words, @maxMatchStrLen};
            var ___result = RMatchLongestWords_StringArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			maxMatchStrLen = (System.Int32)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetRepeatCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRepeatCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetNextDigit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNextDigit.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Int32 GetDigit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDigit.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SkipWhiteSpaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipWhiteSpaces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SkipWhiteSpaceCurrent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipWhiteSpaceCurrent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void TrimTail()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTrimTail.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveTrailingInQuoteSpaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveTrailingInQuoteSpaces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveLeadingInQuoteSpaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveLeadingInQuoteSpaces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetSubString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSubString.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
