
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Text.RegularExpressions.Match
	/// </summary>
    public partial class RMatch : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Text.RegularExpressions.Match);
            }
        }

        public RMatch() : base("System.Text.RegularExpressions.Match")
        {
        }

        public RMatch(System.Object instance) : base("System.Text.RegularExpressions.Match")
		{
            SetInstance(instance);
		}

        public RMatch(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMatch(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Text.RegularExpressions.GroupCollection _groupcoll
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroupCollection r_F_groupcoll;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroupCollection RF_groupcoll
		{
			get
			{
				if(r_F_groupcoll == null)
				{
					r_F_groupcoll = new(this, "_groupcoll");
				}
				return r_F_groupcoll;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex _regex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex r_F_regex;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex RF_regex
		{
			get
			{
				if(r_F_regex == null)
				{
					r_F_regex = new(this, "_regex");
				}
				return r_F_regex;
			}
		}

		/// <summary>
		/// System.Int32 _textbeg
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_textbeg;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_textbeg
		{
			get
			{
				if(r_F_textbeg == null)
				{
					r_F_textbeg = new(this, "_textbeg");
				}
				return r_F_textbeg;
			}
		}

		/// <summary>
		/// System.Int32 _textpos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_textpos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_textpos
		{
			get
			{
				if(r_F_textpos == null)
				{
					r_F_textpos = new(this, "_textpos");
				}
				return r_F_textpos;
			}
		}

		/// <summary>
		/// System.Int32 _textend
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_textend;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_textend
		{
			get
			{
				if(r_F_textend == null)
				{
					r_F_textend = new(this, "_textend");
				}
				return r_F_textend;
			}
		}

		/// <summary>
		/// System.Int32 _textstart
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_textstart;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_textstart
		{
			get
			{
				if(r_F_textstart == null)
				{
					r_F_textstart = new(this, "_textstart");
				}
				return r_F_textstart;
			}
		}

		/// <summary>
		/// System.Int32[][] _matches
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32>> r_F_matches;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32>> RF_matches
		{
			get
			{
				if(r_F_matches == null)
				{
					r_F_matches = new(this, "_matches");
				}
				return r_F_matches;
			}
		}

		/// <summary>
		/// System.Int32[] _matchcount
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_F_matchcount;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RF_matchcount
		{
			get
			{
				if(r_F_matchcount == null)
				{
					r_F_matchcount = new(this, "_matchcount");
				}
				return r_F_matchcount;
			}
		}

		/// <summary>
		/// System.Boolean _balancing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_balancing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_balancing
		{
			get
			{
				if(r_F_balancing == null)
				{
					r_F_balancing = new(this, "_balancing");
				}
				return r_F_balancing;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match <Empty>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch r_F__0__Empty__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch RF__0__Empty__1__k__BackingField
		{
			get
			{
				if(r_F__0__Empty__1__k__BackingField == null)
				{
					r_F__0__Empty__1__k__BackingField = new(Type, "<Empty>k__BackingField");
				}
				return r_F__0__Empty__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32[] _caps
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_F_caps;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RF_caps
		{
			get
			{
				if(r_F_caps == null)
				{
					r_F_caps = new(this, "_caps");
				}
				return r_F_caps;
			}
		}

		/// <summary>
		/// System.Int32 _capcount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_capcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_capcount
		{
			get
			{
				if(r_F_capcount == null)
				{
					r_F_capcount = new(this, "_capcount");
				}
				return r_F_capcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection _capcoll
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection r_F_capcoll;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection RF_capcoll
		{
			get
			{
				if(r_F_capcoll == null)
				{
					r_F_capcoll = new(this, "_capcoll");
				}
				return r_F_capcoll;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch r_PEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new(Type, "Empty", -1);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.GroupCollection Groups
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroupCollection r_PGroups;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RGroupCollection RPGroups
		{
			get
			{
				if(r_PGroups == null)
				{
					r_PGroups = new(this, "Groups", -1);
				}
				return r_PGroups;
			}
		}

		/// <summary>
		/// Boolean Success
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PSuccess;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPSuccess
		{
			get
			{
				if(r_PSuccess == null)
				{
					r_PSuccess = new(this, "Success", -1);
				}
				return r_PSuccess;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection Captures
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection r_PCaptures;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RCaptureCollection RPCaptures
		{
			get
			{
				if(r_PCaptures == null)
				{
					r_PCaptures = new(this, "Captures", -1);
				}
				return r_PCaptures;
			}
		}

		/// <summary>
		/// Int32 Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPIndex
		{
			get
			{
				if(r_PIndex == null)
				{
					r_PIndex = new(this, "Index", -1);
				}
				return r_PIndex;
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
		/// System.String Text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPText
		{
			get
			{
				if(r_PText == null)
				{
					r_PText = new(this, "Text", -1);
				}
				return r_PText;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Void Reset(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MReset_Regex_String_Int32_Int32_Int32;
		public virtual RMethod RMReset_Regex_String_Int32_Int32_Int32
		{
			get
			{
				if(r_MReset_Regex_String_Int32_Int32_Int32 == null)
				{
					r_MReset_Regex_String_Int32_Int32_Int32 = new(this, "Reset", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReset_Regex_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match NextMatch()
		/// </summary>
		protected RMethod r_MNextMatch;
		public virtual RMethod RMNextMatch
		{
			get
			{
				if(r_MNextMatch == null)
				{
					r_MNextMatch = new(this, "NextMatch", 0);
				}
				return r_MNextMatch;
			}
		}

		/// <summary>
		/// System.String Result(System.String)
		/// </summary>
		protected RMethod r_MResult_String;
		public virtual RMethod RMResult_String
		{
			get
			{
				if(r_MResult_String == null)
				{
					r_MResult_String = new(this, "Result", 0, typeof(System.String));
				}
				return r_MResult_String;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GroupToStringImpl(Int32)
		/// </summary>
		protected RMethod r_MGroupToStringImpl_Int32;
		public virtual RMethod RMGroupToStringImpl_Int32
		{
			get
			{
				if(r_MGroupToStringImpl_Int32 == null)
				{
					r_MGroupToStringImpl_Int32 = new(this, "GroupToStringImpl", 0, typeof(System.Int32));
				}
				return r_MGroupToStringImpl_Int32;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] LastGroupToStringImpl()
		/// </summary>
		protected RMethod r_MLastGroupToStringImpl;
		public virtual RMethod RMLastGroupToStringImpl
		{
			get
			{
				if(r_MLastGroupToStringImpl == null)
				{
					r_MLastGroupToStringImpl = new(this, "LastGroupToStringImpl", 0);
				}
				return r_MLastGroupToStringImpl;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match)
		/// </summary>
		protected static RMethod r_MSynchronized_Match;
		public static RMethod RMSynchronized_Match
		{
			get
			{
				if(r_MSynchronized_Match == null)
				{
					r_MSynchronized_Match = new(Type, "Synchronized", 0, typeof(System.Text.RegularExpressions.Match));
				}
				return r_MSynchronized_Match;
			}
		}

		/// <summary>
		/// Void AddMatch(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MAddMatch_Int32_Int32_Int32;
		public virtual RMethod RMAddMatch_Int32_Int32_Int32
		{
			get
			{
				if(r_MAddMatch_Int32_Int32_Int32 == null)
				{
					r_MAddMatch_Int32_Int32_Int32 = new(this, "AddMatch", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAddMatch_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void BalanceMatch(Int32)
		/// </summary>
		protected RMethod r_MBalanceMatch_Int32;
		public virtual RMethod RMBalanceMatch_Int32
		{
			get
			{
				if(r_MBalanceMatch_Int32 == null)
				{
					r_MBalanceMatch_Int32 = new(this, "BalanceMatch", 0, typeof(System.Int32));
				}
				return r_MBalanceMatch_Int32;
			}
		}

		/// <summary>
		/// Void RemoveMatch(Int32)
		/// </summary>
		protected RMethod r_MRemoveMatch_Int32;
		public virtual RMethod RMRemoveMatch_Int32
		{
			get
			{
				if(r_MRemoveMatch_Int32 == null)
				{
					r_MRemoveMatch_Int32 = new(this, "RemoveMatch", 0, typeof(System.Int32));
				}
				return r_MRemoveMatch_Int32;
			}
		}

		/// <summary>
		/// Boolean IsMatched(Int32)
		/// </summary>
		protected RMethod r_MIsMatched_Int32;
		public virtual RMethod RMIsMatched_Int32
		{
			get
			{
				if(r_MIsMatched_Int32 == null)
				{
					r_MIsMatched_Int32 = new(this, "IsMatched", 0, typeof(System.Int32));
				}
				return r_MIsMatched_Int32;
			}
		}

		/// <summary>
		/// Int32 MatchIndex(Int32)
		/// </summary>
		protected RMethod r_MMatchIndex_Int32;
		public virtual RMethod RMMatchIndex_Int32
		{
			get
			{
				if(r_MMatchIndex_Int32 == null)
				{
					r_MMatchIndex_Int32 = new(this, "MatchIndex", 0, typeof(System.Int32));
				}
				return r_MMatchIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 MatchLength(Int32)
		/// </summary>
		protected RMethod r_MMatchLength_Int32;
		public virtual RMethod RMMatchLength_Int32
		{
			get
			{
				if(r_MMatchLength_Int32 == null)
				{
					r_MMatchLength_Int32 = new(this, "MatchLength", 0, typeof(System.Int32));
				}
				return r_MMatchLength_Int32;
			}
		}

		/// <summary>
		/// Void Tidy(Int32)
		/// </summary>
		protected RMethod r_MTidy_Int32;
		public virtual RMethod RMTidy_Int32
		{
			get
			{
				if(r_MTidy_Int32 == null)
				{
					r_MTidy_Int32 = new(this, "Tidy", 0, typeof(System.Int32));
				}
				return r_MTidy_Int32;
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
		/// System.ReadOnlySpan`1[System.Char] GetLeftSubstring()
		/// </summary>
		protected RMethod r_MGetLeftSubstring;
		public virtual RMethod RMGetLeftSubstring
		{
			get
			{
				if(r_MGetLeftSubstring == null)
				{
					r_MGetLeftSubstring = new(this, "GetLeftSubstring", 0);
				}
				return r_MGetLeftSubstring;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GetRightSubstring()
		/// </summary>
		protected RMethod r_MGetRightSubstring;
		public virtual RMethod RMGetRightSubstring
		{
			get
			{
				if(r_MGetRightSubstring == null)
				{
					r_MGetRightSubstring = new(this, "GetRightSubstring", 0);
				}
				return r_MGetRightSubstring;
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


        public virtual void Reset(System.Text.RegularExpressions.Regex @regex, System.String @text, System.Int32 @textbeg, System.Int32 @textend, System.Int32 @textstart)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart};
            var ___result = RMReset_Regex_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.Match NextMatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNextMatch.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Text.RegularExpressions.Match>(___result);
        }


        public virtual System.String Result(System.String @replacement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replacement};
            var ___result = RMResult_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> GroupToStringImpl(System.Int32 @groupnum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupnum};
            var ___result = RMGroupToStringImpl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> LastGroupToStringImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLastGroupToStringImpl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>>(___result);
        }


        public static System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match @inner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inner};
            var ___result = RMSynchronized_Match.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Text.RegularExpressions.Match>(___result);
        }


        public virtual void AddMatch(System.Int32 @cap, System.Int32 @start, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap, @start, @len};
            var ___result = RMAddMatch_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BalanceMatch(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMBalanceMatch_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveMatch(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMRemoveMatch_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsMatched(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMIsMatched_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 MatchIndex(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMMatchIndex_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 MatchLength(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMMatchLength_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void Tidy(System.Int32 @textpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textpos};
            var ___result = RMTidy_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> GetLeftSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLeftSubstring.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> GetRightSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRightSubstring.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar>>(___result);
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


    }
}
