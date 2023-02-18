
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.__DTString
	/// </summary>
    public partial class R__DTString : RMember //
    {

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> r_FValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> RFValue
		{
			get
			{
				if(r_FValue == null)
				{
					r_FValue = new(this, "Value");
				}
				return r_FValue;
			}
		}

		/// <summary>
		/// System.Int32 Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFIndex
		{
			get
			{
				if(r_FIndex == null)
				{
					r_FIndex = new(this, "Index");
				}
				return r_FIndex;
			}
		}

		/// <summary>
		/// System.Char m_current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RChar r_Fm_current;
		public virtual Hvak.Editor.Refleaction.RSystem.RChar RFm_current
		{
			get
			{
				if(r_Fm_current == null)
				{
					r_Fm_current = new(this, "m_current");
				}
				return r_Fm_current;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo m_info
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo r_Fm_info;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo RFm_info
		{
			get
			{
				if(r_Fm_info == null)
				{
					r_Fm_info = new(this, "m_info");
				}
				return r_Fm_info;
			}
		}

		/// <summary>
		/// System.Boolean m_checkDigitToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_checkDigitToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_checkDigitToken
		{
			get
			{
				if(r_Fm_checkDigitToken == null)
				{
					r_Fm_checkDigitToken = new(this, "m_checkDigitToken");
				}
				return r_Fm_checkDigitToken;
			}
		}

		/// <summary>
		/// System.Char[] WhiteSpaceChecks
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_FWhiteSpaceChecks;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFWhiteSpaceChecks
		{
			get
			{
				if(r_FWhiteSpaceChecks == null)
				{
					r_FWhiteSpaceChecks = new( ReflectionUtils.GetType("System.__DTString"), "WhiteSpaceChecks");
				}
				return r_FWhiteSpaceChecks;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo CompareInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo r_PCompareInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo RPCompareInfo
		{
			get
			{
				if(r_PCompareInfo == null)
				{
					r_PCompareInfo = new(this, "CompareInfo", -1);
				}
				return r_PCompareInfo;
			}
		}

		/// <summary>
		/// Boolean GetNext()
		/// </summary>
		protected RMethod r_MGetNext;
		public virtual RMethod RMGetNext
		{
			get
			{
				if(r_MGetNext == null)
				{
					r_MGetNext = new(this, "GetNext", 0);
				}
				return r_MGetNext;
			}
		}

		/// <summary>
		/// Boolean AtEnd()
		/// </summary>
		protected RMethod r_MAtEnd;
		public virtual RMethod RMAtEnd
		{
			get
			{
				if(r_MAtEnd == null)
				{
					r_MAtEnd = new(this, "AtEnd", 0);
				}
				return r_MAtEnd;
			}
		}

		/// <summary>
		/// Boolean Advance(Int32)
		/// </summary>
		protected RMethod r_MAdvance_Int32;
		public virtual RMethod RMAdvance_Int32
		{
			get
			{
				if(r_MAdvance_Int32 == null)
				{
					r_MAdvance_Int32 = new(this, "Advance", 0, typeof(System.Int32));
				}
				return r_MAdvance_Int32;
			}
		}

		/// <summary>
		/// Void GetRegularToken(System.TokenType ByRef, Int32 ByRef, System.Globalization.DateTimeFormatInfo)
		/// </summary>
		protected RMethod r_MGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo;
		public virtual RMethod RMGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo
		{
			get
			{
				if(r_MGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo == null)
				{
					r_MGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo = new(this, "GetRegularToken", 0,  ReflectionUtils.GetType("System.TokenType").MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Globalization.DateTimeFormatInfo));
				}
				return r_MGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo;
			}
		}

		/// <summary>
		/// System.TokenType GetSeparatorToken(System.Globalization.DateTimeFormatInfo, Int32 ByRef, Char ByRef)
		/// </summary>
		protected RMethod r_MGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char;
		public virtual RMethod RMGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char
		{
			get
			{
				if(r_MGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char == null)
				{
					r_MGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char = new(this, "GetSeparatorToken", 0, typeof(System.Globalization.DateTimeFormatInfo), typeof(System.Int32).MakeByRefType(), typeof(System.Char).MakeByRefType());
				}
				return r_MGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char;
			}
		}

		/// <summary>
		/// Boolean MatchSpecifiedWord(System.String)
		/// </summary>
		protected RMethod r_MMatchSpecifiedWord_String;
		public virtual RMethod RMMatchSpecifiedWord_String
		{
			get
			{
				if(r_MMatchSpecifiedWord_String == null)
				{
					r_MMatchSpecifiedWord_String = new(this, "MatchSpecifiedWord", 0, typeof(System.String));
				}
				return r_MMatchSpecifiedWord_String;
			}
		}

		/// <summary>
		/// Boolean MatchSpecifiedWords(System.String, Boolean, Int32 ByRef)
		/// </summary>
		protected RMethod r_MMatchSpecifiedWords_String_Boolean_Ref_Int32;
		public virtual RMethod RMMatchSpecifiedWords_String_Boolean_Ref_Int32
		{
			get
			{
				if(r_MMatchSpecifiedWords_String_Boolean_Ref_Int32 == null)
				{
					r_MMatchSpecifiedWords_String_Boolean_Ref_Int32 = new(this, "MatchSpecifiedWords", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MMatchSpecifiedWords_String_Boolean_Ref_Int32;
			}
		}

		/// <summary>
		/// Boolean Match(System.String)
		/// </summary>
		protected RMethod r_MMatch_String;
		public virtual RMethod RMMatch_String
		{
			get
			{
				if(r_MMatch_String == null)
				{
					r_MMatch_String = new(this, "Match", 0, typeof(System.String));
				}
				return r_MMatch_String;
			}
		}

		/// <summary>
		/// Boolean Match(Char)
		/// </summary>
		protected RMethod r_MMatch_Char;
		public virtual RMethod RMMatch_Char
		{
			get
			{
				if(r_MMatch_Char == null)
				{
					r_MMatch_Char = new(this, "Match", 0, typeof(System.Char));
				}
				return r_MMatch_Char;
			}
		}

		/// <summary>
		/// Int32 MatchLongestWords(System.String[], Int32 ByRef)
		/// </summary>
		protected RMethod r_MMatchLongestWords_StringArray_Ref_Int32;
		public virtual RMethod RMMatchLongestWords_StringArray_Ref_Int32
		{
			get
			{
				if(r_MMatchLongestWords_StringArray_Ref_Int32 == null)
				{
					r_MMatchLongestWords_StringArray_Ref_Int32 = new(this, "MatchLongestWords", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MMatchLongestWords_StringArray_Ref_Int32;
			}
		}

		/// <summary>
		/// Int32 GetRepeatCount()
		/// </summary>
		protected RMethod r_MGetRepeatCount;
		public virtual RMethod RMGetRepeatCount
		{
			get
			{
				if(r_MGetRepeatCount == null)
				{
					r_MGetRepeatCount = new(this, "GetRepeatCount", 0);
				}
				return r_MGetRepeatCount;
			}
		}

		/// <summary>
		/// Boolean GetNextDigit()
		/// </summary>
		protected RMethod r_MGetNextDigit;
		public virtual RMethod RMGetNextDigit
		{
			get
			{
				if(r_MGetNextDigit == null)
				{
					r_MGetNextDigit = new(this, "GetNextDigit", 0);
				}
				return r_MGetNextDigit;
			}
		}

		/// <summary>
		/// Char GetChar()
		/// </summary>
		protected RMethod r_MGetChar;
		public virtual RMethod RMGetChar
		{
			get
			{
				if(r_MGetChar == null)
				{
					r_MGetChar = new(this, "GetChar", 0);
				}
				return r_MGetChar;
			}
		}

		/// <summary>
		/// Int32 GetDigit()
		/// </summary>
		protected RMethod r_MGetDigit;
		public virtual RMethod RMGetDigit
		{
			get
			{
				if(r_MGetDigit == null)
				{
					r_MGetDigit = new(this, "GetDigit", 0);
				}
				return r_MGetDigit;
			}
		}

		/// <summary>
		/// Void SkipWhiteSpaces()
		/// </summary>
		protected RMethod r_MSkipWhiteSpaces;
		public virtual RMethod RMSkipWhiteSpaces
		{
			get
			{
				if(r_MSkipWhiteSpaces == null)
				{
					r_MSkipWhiteSpaces = new(this, "SkipWhiteSpaces", 0);
				}
				return r_MSkipWhiteSpaces;
			}
		}

		/// <summary>
		/// Boolean SkipWhiteSpaceCurrent()
		/// </summary>
		protected RMethod r_MSkipWhiteSpaceCurrent;
		public virtual RMethod RMSkipWhiteSpaceCurrent
		{
			get
			{
				if(r_MSkipWhiteSpaceCurrent == null)
				{
					r_MSkipWhiteSpaceCurrent = new(this, "SkipWhiteSpaceCurrent", 0);
				}
				return r_MSkipWhiteSpaceCurrent;
			}
		}

		/// <summary>
		/// Void TrimTail()
		/// </summary>
		protected RMethod r_MTrimTail;
		public virtual RMethod RMTrimTail
		{
			get
			{
				if(r_MTrimTail == null)
				{
					r_MTrimTail = new(this, "TrimTail", 0);
				}
				return r_MTrimTail;
			}
		}

		/// <summary>
		/// Void RemoveTrailingInQuoteSpaces()
		/// </summary>
		protected RMethod r_MRemoveTrailingInQuoteSpaces;
		public virtual RMethod RMRemoveTrailingInQuoteSpaces
		{
			get
			{
				if(r_MRemoveTrailingInQuoteSpaces == null)
				{
					r_MRemoveTrailingInQuoteSpaces = new(this, "RemoveTrailingInQuoteSpaces", 0);
				}
				return r_MRemoveTrailingInQuoteSpaces;
			}
		}

		/// <summary>
		/// Void RemoveLeadingInQuoteSpaces()
		/// </summary>
		protected RMethod r_MRemoveLeadingInQuoteSpaces;
		public virtual RMethod RMRemoveLeadingInQuoteSpaces
		{
			get
			{
				if(r_MRemoveLeadingInQuoteSpaces == null)
				{
					r_MRemoveLeadingInQuoteSpaces = new(this, "RemoveLeadingInQuoteSpaces", 0);
				}
				return r_MRemoveLeadingInQuoteSpaces;
			}
		}

		/// <summary>
		/// System.DTSubString GetSubString()
		/// </summary>
		protected RMethod r_MGetSubString;
		public virtual RMethod RMGetSubString
		{
			get
			{
				if(r_MGetSubString == null)
				{
					r_MGetSubString = new(this, "GetSubString", 0);
				}
				return r_MGetSubString;
			}
		}

		/// <summary>
		/// Void ConsumeSubString(System.DTSubString)
		/// </summary>
		protected RMethod r_MConsumeSubString_DTSubString;
		public virtual RMethod RMConsumeSubString_DTSubString
		{
			get
			{
				if(r_MConsumeSubString_DTSubString == null)
				{
					r_MConsumeSubString_DTSubString = new(this, "ConsumeSubString", 0,  ReflectionUtils.GetType("System.DTSubString"));
				}
				return r_MConsumeSubString_DTSubString;
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
            var ___result = RMGetNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean AtEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAtEnd.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Advance(System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RMAdvance_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GetRegularToken(out Hvak.Editor.Refleaction.RSystem.RTokenType @tokenType, out System.Int32 @tokenValue, System.Globalization.DateTimeFormatInfo @dtfi)
        {
			@tokenType = default;
			@tokenValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenType.Value, @tokenValue, @dtfi};
            var ___result = RMGetRegularToken_Out_TokenType_Out_Int32_DateTimeFormatInfo.Invoke(___genericsType, ___parameters);
			@tokenType = new Hvak.Editor.Refleaction.RSystem.RTokenType(___parameters[0]);
			@tokenValue = (System.Int32)___parameters[1];

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RTokenType GetSeparatorToken(System.Globalization.DateTimeFormatInfo @dtfi, out System.Int32 @indexBeforeSeparator, out System.Char @charBeforeSeparator)
        {
			@indexBeforeSeparator = default;
			@charBeforeSeparator = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dtfi, @indexBeforeSeparator, @charBeforeSeparator};
            var ___result = RMGetSeparatorToken_DateTimeFormatInfo_Out_Int32_Out_Char.Invoke(___genericsType, ___parameters);
			@indexBeforeSeparator = (System.Int32)___parameters[1];
			@charBeforeSeparator = (System.Char)___parameters[2];

            return new Hvak.Editor.Refleaction.RSystem.RTokenType(___result);
        }


        public virtual System.Boolean MatchSpecifiedWord(System.String @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMMatchSpecifiedWord_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MatchSpecifiedWords(System.String @target, System.Boolean @checkWordBoundary, ref System.Int32 @matchLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @checkWordBoundary, @matchLength};
            var ___result = RMMatchSpecifiedWords_String_Boolean_Ref_Int32.Invoke(___genericsType, ___parameters);
			@matchLength = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Match(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMMatch_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Match(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMMatch_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 MatchLongestWords(System.String[] @words, ref System.Int32 @maxMatchStrLen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@words, @maxMatchStrLen};
            var ___result = RMMatchLongestWords_StringArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			@maxMatchStrLen = (System.Int32)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetRepeatCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRepeatCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetNextDigit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextDigit.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetChar.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Int32 GetDigit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDigit.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SkipWhiteSpaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSkipWhiteSpaces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SkipWhiteSpaceCurrent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSkipWhiteSpaceCurrent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void TrimTail()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMTrimTail.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveTrailingInQuoteSpaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveTrailingInQuoteSpaces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveLeadingInQuoteSpaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveLeadingInQuoteSpaces.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RDTSubString GetSubString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSubString.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RDTSubString(___result);
        }


        public virtual void ConsumeSubString(Hvak.Editor.Refleaction.RSystem.RDTSubString @sub)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sub.Value};
            var ___result = RMConsumeSubString_DTSubString.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
