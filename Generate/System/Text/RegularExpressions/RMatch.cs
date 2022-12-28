using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.Match
	/// </summary>
    public partial class RMatch : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.GroupCollection _groupcoll
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RGroupCollection r__groupcoll;
		public virtual RSystem.RText.RRegularExpressions.RGroupCollection R_groupcoll
		{
			get
			{
				if(r__groupcoll == null)
				{
					r__groupcoll = new(this, "_groupcoll");
					r__groupcoll.SetBelong(this.instance);
				}
				return r__groupcoll;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex _regex
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegex r__regex;
		public virtual RSystem.RText.RRegularExpressions.RRegex R_regex
		{
			get
			{
				if(r__regex == null)
				{
					r__regex = new(this, "_regex");
					r__regex.SetBelong(this.instance);
				}
				return r__regex;
			}
		}

		/// <summary>
		/// System.Int32 _textbeg
		/// </summary>
		protected RField r__textbeg;
		public virtual RField R_textbeg
		{
			get
			{
				if(r__textbeg == null)
				{
					r__textbeg = new(this, "_textbeg");
					r__textbeg.SetBelong(this.instance);
				}
				return r__textbeg;
			}
		}

		/// <summary>
		/// System.Int32 _textpos
		/// </summary>
		protected RField r__textpos;
		public virtual RField R_textpos
		{
			get
			{
				if(r__textpos == null)
				{
					r__textpos = new(this, "_textpos");
					r__textpos.SetBelong(this.instance);
				}
				return r__textpos;
			}
		}

		/// <summary>
		/// System.Int32 _textend
		/// </summary>
		protected RField r__textend;
		public virtual RField R_textend
		{
			get
			{
				if(r__textend == null)
				{
					r__textend = new(this, "_textend");
					r__textend.SetBelong(this.instance);
				}
				return r__textend;
			}
		}

		/// <summary>
		/// System.Int32 _textstart
		/// </summary>
		protected RField r__textstart;
		public virtual RField R_textstart
		{
			get
			{
				if(r__textstart == null)
				{
					r__textstart = new(this, "_textstart");
					r__textstart.SetBelong(this.instance);
				}
				return r__textstart;
			}
		}

		/// <summary>
		/// System.Int32[][] _matches
		/// </summary>
		protected RFieldArray<RFieldArray<RField>> r__matches;
		public virtual RFieldArray<RFieldArray<RField>> R_matches
		{
			get
			{
				if(r__matches == null)
				{
					r__matches = new(this, "_matches");
					r__matches.SetBelong(this.instance);
				}
				return r__matches;
			}
		}

		/// <summary>
		/// System.Int32[] _matchcount
		/// </summary>
		protected RFieldArray<RField> r__matchcount;
		public virtual RFieldArray<RField> R_matchcount
		{
			get
			{
				if(r__matchcount == null)
				{
					r__matchcount = new(this, "_matchcount");
					r__matchcount.SetBelong(this.instance);
				}
				return r__matchcount;
			}
		}

		/// <summary>
		/// System.Boolean _balancing
		/// </summary>
		protected RField r__balancing;
		public virtual RField R_balancing
		{
			get
			{
				if(r__balancing == null)
				{
					r__balancing = new(this, "_balancing");
					r__balancing.SetBelong(this.instance);
				}
				return r__balancing;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match <Empty>k__BackingField
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RMatch r___1__Empty__2__k__BackingField;
		public static RSystem.RText.RRegularExpressions.RMatch R__1__Empty__2__k__BackingField
		{
			get
			{
				if(r___1__Empty__2__k__BackingField == null)
				{
					r___1__Empty__2__k__BackingField = new(typeof(System.Text.RegularExpressions.Match), "<Empty>k__BackingField");
					r___1__Empty__2__k__BackingField.SetBelong(null);
				}
				return r___1__Empty__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32[] _caps
		/// </summary>
		protected RFieldArray<RField> r__caps;
		public virtual RFieldArray<RField> R_caps
		{
			get
			{
				if(r__caps == null)
				{
					r__caps = new(this, "_caps");
					r__caps.SetBelong(this.instance);
				}
				return r__caps;
			}
		}

		/// <summary>
		/// System.Int32 _capcount
		/// </summary>
		protected RField r__capcount;
		public virtual RField R_capcount
		{
			get
			{
				if(r__capcount == null)
				{
					r__capcount = new(this, "_capcount");
					r__capcount.SetBelong(this.instance);
				}
				return r__capcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection _capcoll
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RCaptureCollection r__capcoll;
		public virtual RSystem.RText.RRegularExpressions.RCaptureCollection R_capcoll
		{
			get
			{
				if(r__capcoll == null)
				{
					r__capcoll = new(this, "_capcoll");
					r__capcoll.SetBelong(this.instance);
				}
				return r__capcoll;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Empty
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RMatch r_Empty;
		public static RSystem.RText.RRegularExpressions.RMatch REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.Text.RegularExpressions.Match), "Empty", -1);
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.GroupCollection Groups
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RGroupCollection r_Groups;
		public virtual RSystem.RText.RRegularExpressions.RGroupCollection RGroups
		{
			get
			{
				if(r_Groups == null)
				{
					r_Groups = new(this, "Groups", -1);
					r_Groups.SetBelong(this.instance);
				}
				return r_Groups;
			}
		}

		/// <summary>
		/// Boolean Success
		/// </summary>
		protected RProperty r_Success;
		public virtual RProperty RSuccess
		{
			get
			{
				if(r_Success == null)
				{
					r_Success = new(this, "Success", -1);
					r_Success.SetBelong(this.instance);
				}
				return r_Success;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.CaptureCollection Captures
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RCaptureCollection r_Captures;
		public virtual RSystem.RText.RRegularExpressions.RCaptureCollection RCaptures
		{
			get
			{
				if(r_Captures == null)
				{
					r_Captures = new(this, "Captures", -1);
					r_Captures.SetBelong(this.instance);
				}
				return r_Captures;
			}
		}

		/// <summary>
		/// Int32 Index
		/// </summary>
		protected RProperty r_Index;
		public virtual RProperty RIndex
		{
			get
			{
				if(r_Index == null)
				{
					r_Index = new(this, "Index", -1);
					r_Index.SetBelong(this.instance);
				}
				return r_Index;
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
		/// System.String Text
		/// </summary>
		protected RProperty r_Text;
		public virtual RProperty RText
		{
			get
			{
				if(r_Text == null)
				{
					r_Text = new(this, "Text", -1);
					r_Text.SetBelong(this.instance);
				}
				return r_Text;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Void Reset(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RReset_Regex_String_Int32_Int32_Int32;
		public virtual RMethod RReset_Regex_String_Int32_Int32_Int32
		{
			get
			{
				if(r_RReset_Regex_String_Int32_Int32_Int32 == null)
				{
					r_RReset_Regex_String_Int32_Int32_Int32 = new(this, "Reset", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RReset_Regex_String_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReset_Regex_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match NextMatch()
		/// </summary>
		protected RMethod r_RNextMatch;
		public virtual RMethod RNextMatch
		{
			get
			{
				if(r_RNextMatch == null)
				{
					r_RNextMatch = new(this, "NextMatch", 0);
					r_RNextMatch.SetBelong(this.instance);
				}
				return r_RNextMatch;
			}
		}

		/// <summary>
		/// System.String Result(System.String)
		/// </summary>
		protected RMethod r_RResult_String;
		public virtual RMethod RResult_String
		{
			get
			{
				if(r_RResult_String == null)
				{
					r_RResult_String = new(this, "Result", 0, typeof(System.String));
					r_RResult_String.SetBelong(this.instance);
				}
				return r_RResult_String;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GroupToStringImpl(Int32)
		/// </summary>
		protected RMethod r_RGroupToStringImpl_Int32;
		public virtual RMethod RGroupToStringImpl_Int32
		{
			get
			{
				if(r_RGroupToStringImpl_Int32 == null)
				{
					r_RGroupToStringImpl_Int32 = new(this, "GroupToStringImpl", 0, typeof(System.Int32));
					r_RGroupToStringImpl_Int32.SetBelong(this.instance);
				}
				return r_RGroupToStringImpl_Int32;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] LastGroupToStringImpl()
		/// </summary>
		protected RMethod r_RLastGroupToStringImpl;
		public virtual RMethod RLastGroupToStringImpl
		{
			get
			{
				if(r_RLastGroupToStringImpl == null)
				{
					r_RLastGroupToStringImpl = new(this, "LastGroupToStringImpl", 0);
					r_RLastGroupToStringImpl.SetBelong(this.instance);
				}
				return r_RLastGroupToStringImpl;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match)
		/// </summary>
		protected static RMethod r_RSynchronized_Match;
		public static RMethod RSynchronized_Match
		{
			get
			{
				if(r_RSynchronized_Match == null)
				{
					r_RSynchronized_Match = new(typeof(System.Text.RegularExpressions.Match), "Synchronized", 0, typeof(System.Text.RegularExpressions.Match));
					r_RSynchronized_Match.SetBelong(null);
				}
				return r_RSynchronized_Match;
			}
		}

		/// <summary>
		/// Void AddMatch(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RAddMatch_Int32_Int32_Int32;
		public virtual RMethod RAddMatch_Int32_Int32_Int32
		{
			get
			{
				if(r_RAddMatch_Int32_Int32_Int32 == null)
				{
					r_RAddMatch_Int32_Int32_Int32 = new(this, "AddMatch", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RAddMatch_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAddMatch_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void BalanceMatch(Int32)
		/// </summary>
		protected RMethod r_RBalanceMatch_Int32;
		public virtual RMethod RBalanceMatch_Int32
		{
			get
			{
				if(r_RBalanceMatch_Int32 == null)
				{
					r_RBalanceMatch_Int32 = new(this, "BalanceMatch", 0, typeof(System.Int32));
					r_RBalanceMatch_Int32.SetBelong(this.instance);
				}
				return r_RBalanceMatch_Int32;
			}
		}

		/// <summary>
		/// Void RemoveMatch(Int32)
		/// </summary>
		protected RMethod r_RRemoveMatch_Int32;
		public virtual RMethod RRemoveMatch_Int32
		{
			get
			{
				if(r_RRemoveMatch_Int32 == null)
				{
					r_RRemoveMatch_Int32 = new(this, "RemoveMatch", 0, typeof(System.Int32));
					r_RRemoveMatch_Int32.SetBelong(this.instance);
				}
				return r_RRemoveMatch_Int32;
			}
		}

		/// <summary>
		/// Boolean IsMatched(Int32)
		/// </summary>
		protected RMethod r_RIsMatched_Int32;
		public virtual RMethod RIsMatched_Int32
		{
			get
			{
				if(r_RIsMatched_Int32 == null)
				{
					r_RIsMatched_Int32 = new(this, "IsMatched", 0, typeof(System.Int32));
					r_RIsMatched_Int32.SetBelong(this.instance);
				}
				return r_RIsMatched_Int32;
			}
		}

		/// <summary>
		/// Int32 MatchIndex(Int32)
		/// </summary>
		protected RMethod r_RMatchIndex_Int32;
		public virtual RMethod RMatchIndex_Int32
		{
			get
			{
				if(r_RMatchIndex_Int32 == null)
				{
					r_RMatchIndex_Int32 = new(this, "MatchIndex", 0, typeof(System.Int32));
					r_RMatchIndex_Int32.SetBelong(this.instance);
				}
				return r_RMatchIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 MatchLength(Int32)
		/// </summary>
		protected RMethod r_RMatchLength_Int32;
		public virtual RMethod RMatchLength_Int32
		{
			get
			{
				if(r_RMatchLength_Int32 == null)
				{
					r_RMatchLength_Int32 = new(this, "MatchLength", 0, typeof(System.Int32));
					r_RMatchLength_Int32.SetBelong(this.instance);
				}
				return r_RMatchLength_Int32;
			}
		}

		/// <summary>
		/// Void Tidy(Int32)
		/// </summary>
		protected RMethod r_RTidy_Int32;
		public virtual RMethod RTidy_Int32
		{
			get
			{
				if(r_RTidy_Int32 == null)
				{
					r_RTidy_Int32 = new(this, "Tidy", 0, typeof(System.Int32));
					r_RTidy_Int32.SetBelong(this.instance);
				}
				return r_RTidy_Int32;
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
		/// System.ReadOnlySpan`1[System.Char] GetLeftSubstring()
		/// </summary>
		protected RMethod r_RGetLeftSubstring;
		public virtual RMethod RGetLeftSubstring
		{
			get
			{
				if(r_RGetLeftSubstring == null)
				{
					r_RGetLeftSubstring = new(this, "GetLeftSubstring", 0);
					r_RGetLeftSubstring.SetBelong(this.instance);
				}
				return r_RGetLeftSubstring;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Char] GetRightSubstring()
		/// </summary>
		protected RMethod r_RGetRightSubstring;
		public virtual RMethod RGetRightSubstring
		{
			get
			{
				if(r_RGetRightSubstring == null)
				{
					r_RGetRightSubstring = new(this, "GetRightSubstring", 0);
					r_RGetRightSubstring.SetBelong(this.instance);
				}
				return r_RGetRightSubstring;
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

        public virtual void Reset(System.Text.RegularExpressions.Regex  @regex, System.String  @text, System.Int32  @textbeg, System.Int32  @textend, System.Int32  @textstart)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart};
            var ___result = RReset_Regex_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.Match NextMatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNextMatch.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.String Result(System.String  @replacement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replacement};
            var ___result = RResult_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GroupToStringImpl(System.Int32  @groupnum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@groupnum};
            var ___result = RGroupToStringImpl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LastGroupToStringImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLastGroupToStringImpl.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match  @inner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inner};
            var ___result = RSynchronized_Match.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void AddMatch(System.Int32  @cap, System.Int32  @start, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap, @start, @len};
            var ___result = RAddMatch_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BalanceMatch(System.Int32  @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RBalanceMatch_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveMatch(System.Int32  @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RRemoveMatch_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsMatched(System.Int32  @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RIsMatched_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 MatchIndex(System.Int32  @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMatchIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 MatchLength(System.Int32  @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMatchLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Tidy(System.Int32  @textpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textpos};
            var ___result = RTidy_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetLeftSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLeftSubstring.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRightSubstring()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRightSubstring.Invoke(___genericsType, ___parameters);

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


    }
}