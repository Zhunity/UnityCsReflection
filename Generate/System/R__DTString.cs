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
		protected RMethod r_RGetNext;
		public virtual RMethod RGetNext
		{
			get
			{
				if(r_RGetNext == null)
				{
					r_RGetNext = new(this, "GetNext", 0);
					r_RGetNext.SetBelong(this.instance);
				}
				return r_RGetNext;
			}
		}

		/// <summary>
		/// Boolean AtEnd()
		/// </summary>
		protected RMethod r_RAtEnd;
		public virtual RMethod RAtEnd
		{
			get
			{
				if(r_RAtEnd == null)
				{
					r_RAtEnd = new(this, "AtEnd", 0);
					r_RAtEnd.SetBelong(this.instance);
				}
				return r_RAtEnd;
			}
		}

		/// <summary>
		/// Boolean Advance(Int32)
		/// </summary>
		protected RMethod r_RAdvance_Int32;
		public virtual RMethod RAdvance_Int32
		{
			get
			{
				if(r_RAdvance_Int32 == null)
				{
					r_RAdvance_Int32 = new(this, "Advance", 0, typeof(System.Int32));
					r_RAdvance_Int32.SetBelong(this.instance);
				}
				return r_RAdvance_Int32;
			}
		}

		/// <summary>
		/// Void GetRegularToken(System.TokenType ByRef, Int32 ByRef, System.Globalization.DateTimeFormatInfo)
		/// </summary>
		protected RMethod r_RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo;
		public virtual RMethod RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo
		{
			get
			{
				if(r_RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo == null)
				{
					r_RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo = new(this, "GetRegularToken", 0,  ReleactionUtils.GetType("System.TokenType").MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Globalization.DateTimeFormatInfo));
					r_RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo.SetBelong(this.instance);
				}
				return r_RGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo;
			}
		}

		/// <summary>
		/// System.TokenType GetSeparatorToken(System.Globalization.DateTimeFormatInfo, Int32 ByRef, Char ByRef)
		/// </summary>
		protected RMethod r_RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char;
		public virtual RMethod RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char
		{
			get
			{
				if(r_RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char == null)
				{
					r_RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char = new(this, "GetSeparatorToken", 0, typeof(System.Globalization.DateTimeFormatInfo), typeof(System.Int32).MakeByRefType(), typeof(System.Char).MakeByRefType());
					r_RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char.SetBelong(this.instance);
				}
				return r_RGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char;
			}
		}

		/// <summary>
		/// Boolean MatchSpecifiedWord(System.String)
		/// </summary>
		protected RMethod r_RMatchSpecifiedWord_String;
		public virtual RMethod RMatchSpecifiedWord_String
		{
			get
			{
				if(r_RMatchSpecifiedWord_String == null)
				{
					r_RMatchSpecifiedWord_String = new(this, "MatchSpecifiedWord", 0, typeof(System.String));
					r_RMatchSpecifiedWord_String.SetBelong(this.instance);
				}
				return r_RMatchSpecifiedWord_String;
			}
		}

		/// <summary>
		/// Boolean MatchSpecifiedWords(System.String, Boolean, Int32 ByRef)
		/// </summary>
		protected RMethod r_RMatchSpecifiedWords_String_Boolean_Ref_Int32;
		public virtual RMethod RMatchSpecifiedWords_String_Boolean_Ref_Int32
		{
			get
			{
				if(r_RMatchSpecifiedWords_String_Boolean_Ref_Int32 == null)
				{
					r_RMatchSpecifiedWords_String_Boolean_Ref_Int32 = new(this, "MatchSpecifiedWords", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_RMatchSpecifiedWords_String_Boolean_Ref_Int32.SetBelong(this.instance);
				}
				return r_RMatchSpecifiedWords_String_Boolean_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean Match(System.String)
		/// </summary>
		protected RMethod r_RMatch_String;
		public virtual RMethod RMatch_String
		{
			get
			{
				if(r_RMatch_String == null)
				{
					r_RMatch_String = new(this, "Match", 0, typeof(System.String));
					r_RMatch_String.SetBelong(this.instance);
				}
				return r_RMatch_String;
			}
		}

		/// <summary>
		/// Boolean Match(Char)
		/// </summary>
		protected RMethod r_RMatch_Char;
		public virtual RMethod RMatch_Char
		{
			get
			{
				if(r_RMatch_Char == null)
				{
					r_RMatch_Char = new(this, "Match", 0, typeof(System.Char));
					r_RMatch_Char.SetBelong(this.instance);
				}
				return r_RMatch_Char;
			}
		}

		/// <summary>
		/// Int32 MatchLongestWords(System.String[], Int32 ByRef)
		/// </summary>
		protected RMethod r_RMatchLongestWords_StringArray_Ref_Int32;
		public virtual RMethod RMatchLongestWords_StringArray_Ref_Int32
		{
			get
			{
				if(r_RMatchLongestWords_StringArray_Ref_Int32 == null)
				{
					r_RMatchLongestWords_StringArray_Ref_Int32 = new(this, "MatchLongestWords", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_RMatchLongestWords_StringArray_Ref_Int32.SetBelong(this.instance);
				}
				return r_RMatchLongestWords_StringArray_Ref_Int32;
			}
		}

		/// <summary>
		/// Int32 GetRepeatCount()
		/// </summary>
		protected RMethod r_RGetRepeatCount;
		public virtual RMethod RGetRepeatCount
		{
			get
			{
				if(r_RGetRepeatCount == null)
				{
					r_RGetRepeatCount = new(this, "GetRepeatCount", 0);
					r_RGetRepeatCount.SetBelong(this.instance);
				}
				return r_RGetRepeatCount;
			}
		}

		/// <summary>
		/// Boolean GetNextDigit()
		/// </summary>
		protected RMethod r_RGetNextDigit;
		public virtual RMethod RGetNextDigit
		{
			get
			{
				if(r_RGetNextDigit == null)
				{
					r_RGetNextDigit = new(this, "GetNextDigit", 0);
					r_RGetNextDigit.SetBelong(this.instance);
				}
				return r_RGetNextDigit;
			}
		}

		/// <summary>
		/// Char GetChar()
		/// </summary>
		protected RMethod r_RGetChar;
		public virtual RMethod RGetChar
		{
			get
			{
				if(r_RGetChar == null)
				{
					r_RGetChar = new(this, "GetChar", 0);
					r_RGetChar.SetBelong(this.instance);
				}
				return r_RGetChar;
			}
		}

		/// <summary>
		/// Int32 GetDigit()
		/// </summary>
		protected RMethod r_RGetDigit;
		public virtual RMethod RGetDigit
		{
			get
			{
				if(r_RGetDigit == null)
				{
					r_RGetDigit = new(this, "GetDigit", 0);
					r_RGetDigit.SetBelong(this.instance);
				}
				return r_RGetDigit;
			}
		}

		/// <summary>
		/// Void SkipWhiteSpaces()
		/// </summary>
		protected RMethod r_RSkipWhiteSpaces;
		public virtual RMethod RSkipWhiteSpaces
		{
			get
			{
				if(r_RSkipWhiteSpaces == null)
				{
					r_RSkipWhiteSpaces = new(this, "SkipWhiteSpaces", 0);
					r_RSkipWhiteSpaces.SetBelong(this.instance);
				}
				return r_RSkipWhiteSpaces;
			}
		}

		/// <summary>
		/// Boolean SkipWhiteSpaceCurrent()
		/// </summary>
		protected RMethod r_RSkipWhiteSpaceCurrent;
		public virtual RMethod RSkipWhiteSpaceCurrent
		{
			get
			{
				if(r_RSkipWhiteSpaceCurrent == null)
				{
					r_RSkipWhiteSpaceCurrent = new(this, "SkipWhiteSpaceCurrent", 0);
					r_RSkipWhiteSpaceCurrent.SetBelong(this.instance);
				}
				return r_RSkipWhiteSpaceCurrent;
			}
		}

		/// <summary>
		/// Void TrimTail()
		/// </summary>
		protected RMethod r_RTrimTail;
		public virtual RMethod RTrimTail
		{
			get
			{
				if(r_RTrimTail == null)
				{
					r_RTrimTail = new(this, "TrimTail", 0);
					r_RTrimTail.SetBelong(this.instance);
				}
				return r_RTrimTail;
			}
		}

		/// <summary>
		/// Void RemoveTrailingInQuoteSpaces()
		/// </summary>
		protected RMethod r_RRemoveTrailingInQuoteSpaces;
		public virtual RMethod RRemoveTrailingInQuoteSpaces
		{
			get
			{
				if(r_RRemoveTrailingInQuoteSpaces == null)
				{
					r_RRemoveTrailingInQuoteSpaces = new(this, "RemoveTrailingInQuoteSpaces", 0);
					r_RRemoveTrailingInQuoteSpaces.SetBelong(this.instance);
				}
				return r_RRemoveTrailingInQuoteSpaces;
			}
		}

		/// <summary>
		/// Void RemoveLeadingInQuoteSpaces()
		/// </summary>
		protected RMethod r_RRemoveLeadingInQuoteSpaces;
		public virtual RMethod RRemoveLeadingInQuoteSpaces
		{
			get
			{
				if(r_RRemoveLeadingInQuoteSpaces == null)
				{
					r_RRemoveLeadingInQuoteSpaces = new(this, "RemoveLeadingInQuoteSpaces", 0);
					r_RRemoveLeadingInQuoteSpaces.SetBelong(this.instance);
				}
				return r_RRemoveLeadingInQuoteSpaces;
			}
		}

		/// <summary>
		/// System.DTSubString GetSubString()
		/// </summary>
		protected RMethod r_RGetSubString;
		public virtual RMethod RGetSubString
		{
			get
			{
				if(r_RGetSubString == null)
				{
					r_RGetSubString = new(this, "GetSubString", 0);
					r_RGetSubString.SetBelong(this.instance);
				}
				return r_RGetSubString;
			}
		}

		/// <summary>
		/// Void ConsumeSubString(System.DTSubString)
		/// </summary>
		protected RMethod r_RConsumeSubString_DTSubString;
		public virtual RMethod RConsumeSubString_DTSubString
		{
			get
			{
				if(r_RConsumeSubString_DTSubString == null)
				{
					r_RConsumeSubString_DTSubString = new(this, "ConsumeSubString", 0,  ReleactionUtils.GetType("System.DTSubString"));
					r_RConsumeSubString_DTSubString.SetBelong(this.instance);
				}
				return r_RConsumeSubString_DTSubString;
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
