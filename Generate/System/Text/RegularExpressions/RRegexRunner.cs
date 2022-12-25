using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexRunner
	/// </summary>
    public partial class RRegexRunner : RMember //
    {

		/// <summary>
		/// System.Int32 runtextbeg
		/// </summary>
		protected RField r_runtextbeg;
		public virtual RField Rruntextbeg
		{
			get
			{
				if(r_runtextbeg == null)
				{
					r_runtextbeg = new(this, "runtextbeg");
					r_runtextbeg.SetBelong(this.instance);
				}
				return r_runtextbeg;
			}
		}

		/// <summary>
		/// System.Int32 runtextend
		/// </summary>
		protected RField r_runtextend;
		public virtual RField Rruntextend
		{
			get
			{
				if(r_runtextend == null)
				{
					r_runtextend = new(this, "runtextend");
					r_runtextend.SetBelong(this.instance);
				}
				return r_runtextend;
			}
		}

		/// <summary>
		/// System.Int32 runtextstart
		/// </summary>
		protected RField r_runtextstart;
		public virtual RField Rruntextstart
		{
			get
			{
				if(r_runtextstart == null)
				{
					r_runtextstart = new(this, "runtextstart");
					r_runtextstart.SetBelong(this.instance);
				}
				return r_runtextstart;
			}
		}

		/// <summary>
		/// System.String runtext
		/// </summary>
		protected RField r_runtext;
		public virtual RField Rruntext
		{
			get
			{
				if(r_runtext == null)
				{
					r_runtext = new(this, "runtext");
					r_runtext.SetBelong(this.instance);
				}
				return r_runtext;
			}
		}

		/// <summary>
		/// System.Int32 runtextpos
		/// </summary>
		protected RField r_runtextpos;
		public virtual RField Rruntextpos
		{
			get
			{
				if(r_runtextpos == null)
				{
					r_runtextpos = new(this, "runtextpos");
					r_runtextpos.SetBelong(this.instance);
				}
				return r_runtextpos;
			}
		}

		/// <summary>
		/// System.Int32[] runtrack
		/// </summary>
		protected RFieldArray<RField> r_runtrack;
		public virtual RFieldArray<RField> Rruntrack
		{
			get
			{
				if(r_runtrack == null)
				{
					r_runtrack = new(this, "runtrack");
					r_runtrack.SetBelong(this.instance);
				}
				return r_runtrack;
			}
		}

		/// <summary>
		/// System.Int32 runtrackpos
		/// </summary>
		protected RField r_runtrackpos;
		public virtual RField Rruntrackpos
		{
			get
			{
				if(r_runtrackpos == null)
				{
					r_runtrackpos = new(this, "runtrackpos");
					r_runtrackpos.SetBelong(this.instance);
				}
				return r_runtrackpos;
			}
		}

		/// <summary>
		/// System.Int32[] runstack
		/// </summary>
		protected RFieldArray<RField> r_runstack;
		public virtual RFieldArray<RField> Rrunstack
		{
			get
			{
				if(r_runstack == null)
				{
					r_runstack = new(this, "runstack");
					r_runstack.SetBelong(this.instance);
				}
				return r_runstack;
			}
		}

		/// <summary>
		/// System.Int32 runstackpos
		/// </summary>
		protected RField r_runstackpos;
		public virtual RField Rrunstackpos
		{
			get
			{
				if(r_runstackpos == null)
				{
					r_runstackpos = new(this, "runstackpos");
					r_runstackpos.SetBelong(this.instance);
				}
				return r_runstackpos;
			}
		}

		/// <summary>
		/// System.Int32[] runcrawl
		/// </summary>
		protected RFieldArray<RField> r_runcrawl;
		public virtual RFieldArray<RField> Rruncrawl
		{
			get
			{
				if(r_runcrawl == null)
				{
					r_runcrawl = new(this, "runcrawl");
					r_runcrawl.SetBelong(this.instance);
				}
				return r_runcrawl;
			}
		}

		/// <summary>
		/// System.Int32 runcrawlpos
		/// </summary>
		protected RField r_runcrawlpos;
		public virtual RField Rruncrawlpos
		{
			get
			{
				if(r_runcrawlpos == null)
				{
					r_runcrawlpos = new(this, "runcrawlpos");
					r_runcrawlpos.SetBelong(this.instance);
				}
				return r_runcrawlpos;
			}
		}

		/// <summary>
		/// System.Int32 runtrackcount
		/// </summary>
		protected RField r_runtrackcount;
		public virtual RField Rruntrackcount
		{
			get
			{
				if(r_runtrackcount == null)
				{
					r_runtrackcount = new(this, "runtrackcount");
					r_runtrackcount.SetBelong(this.instance);
				}
				return r_runtrackcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match runmatch
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RMatch r_runmatch;
		public virtual RSystem.RText.RRegularExpressions.RMatch Rrunmatch
		{
			get
			{
				if(r_runmatch == null)
				{
					r_runmatch = new(this, "runmatch");
					r_runmatch.SetBelong(this.instance);
				}
				return r_runmatch;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex runregex
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegex r_runregex;
		public virtual RSystem.RText.RRegularExpressions.RRegex Rrunregex
		{
			get
			{
				if(r_runregex == null)
				{
					r_runregex = new(this, "runregex");
					r_runregex.SetBelong(this.instance);
				}
				return r_runregex;
			}
		}

		/// <summary>
		/// System.Int32 _timeout
		/// </summary>
		protected RField r__timeout;
		public virtual RField R_timeout
		{
			get
			{
				if(r__timeout == null)
				{
					r__timeout = new(this, "_timeout");
					r__timeout.SetBelong(this.instance);
				}
				return r__timeout;
			}
		}

		/// <summary>
		/// System.Boolean _ignoreTimeout
		/// </summary>
		protected RField r__ignoreTimeout;
		public virtual RField R_ignoreTimeout
		{
			get
			{
				if(r__ignoreTimeout == null)
				{
					r__ignoreTimeout = new(this, "_ignoreTimeout");
					r__ignoreTimeout.SetBelong(this.instance);
				}
				return r__ignoreTimeout;
			}
		}

		/// <summary>
		/// System.Int32 _timeoutOccursAt
		/// </summary>
		protected RField r__timeoutOccursAt;
		public virtual RField R_timeoutOccursAt
		{
			get
			{
				if(r__timeoutOccursAt == null)
				{
					r__timeoutOccursAt = new(this, "_timeoutOccursAt");
					r__timeoutOccursAt.SetBelong(this.instance);
				}
				return r__timeoutOccursAt;
			}
		}

		/// <summary>
		/// System.Int32 TimeoutCheckFrequency
		/// </summary>
		protected static RField r_TimeoutCheckFrequency;
		public static RField RTimeoutCheckFrequency
		{
			get
			{
				if(r_TimeoutCheckFrequency == null)
				{
					r_TimeoutCheckFrequency = new(typeof(System.Text.RegularExpressions.RegexRunner), "TimeoutCheckFrequency");
					r_TimeoutCheckFrequency.SetBelong(null);
				}
				return r_TimeoutCheckFrequency;
			}
		}

		/// <summary>
		/// System.Int32 _timeoutChecksToSkip
		/// </summary>
		protected RField r__timeoutChecksToSkip;
		public virtual RField R_timeoutChecksToSkip
		{
			get
			{
				if(r__timeoutChecksToSkip == null)
				{
					r__timeoutChecksToSkip = new(this, "_timeoutChecksToSkip");
					r__timeoutChecksToSkip.SetBelong(this.instance);
				}
				return r__timeoutChecksToSkip;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean;
		public virtual RMethod RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean == null)
				{
					r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean = new(this, "Scan", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
		/// </summary>
		protected RMethod r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan;
		public virtual RMethod RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan
		{
			get
			{
				if(r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan == null)
				{
					r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan = new(this, "Scan", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.TimeSpan));
					r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan.SetBelong(this.instance);
				}
				return r_RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan;
			}
		}

		/// <summary>
		/// Void StartTimeoutWatch()
		/// </summary>
		protected RMethod r_RStartTimeoutWatch;
		public virtual RMethod RStartTimeoutWatch
		{
			get
			{
				if(r_RStartTimeoutWatch == null)
				{
					r_RStartTimeoutWatch = new(this, "StartTimeoutWatch", 0);
					r_RStartTimeoutWatch.SetBelong(this.instance);
				}
				return r_RStartTimeoutWatch;
			}
		}

		/// <summary>
		/// Void CheckTimeout()
		/// </summary>
		protected RMethod r_RCheckTimeout;
		public virtual RMethod RCheckTimeout
		{
			get
			{
				if(r_RCheckTimeout == null)
				{
					r_RCheckTimeout = new(this, "CheckTimeout", 0);
					r_RCheckTimeout.SetBelong(this.instance);
				}
				return r_RCheckTimeout;
			}
		}

		/// <summary>
		/// Void DoCheckTimeout()
		/// </summary>
		protected RMethod r_RDoCheckTimeout;
		public virtual RMethod RDoCheckTimeout
		{
			get
			{
				if(r_RDoCheckTimeout == null)
				{
					r_RDoCheckTimeout = new(this, "DoCheckTimeout", 0);
					r_RDoCheckTimeout.SetBelong(this.instance);
				}
				return r_RDoCheckTimeout;
			}
		}

		/// <summary>
		/// Void Go()
		/// </summary>
		protected RMethod r_RGo;
		public virtual RMethod RGo
		{
			get
			{
				if(r_RGo == null)
				{
					r_RGo = new(this, "Go", 0);
					r_RGo.SetBelong(this.instance);
				}
				return r_RGo;
			}
		}

		/// <summary>
		/// Boolean FindFirstChar()
		/// </summary>
		protected RMethod r_RFindFirstChar;
		public virtual RMethod RFindFirstChar
		{
			get
			{
				if(r_RFindFirstChar == null)
				{
					r_RFindFirstChar = new(this, "FindFirstChar", 0);
					r_RFindFirstChar.SetBelong(this.instance);
				}
				return r_RFindFirstChar;
			}
		}

		/// <summary>
		/// Void InitTrackCount()
		/// </summary>
		protected RMethod r_RInitTrackCount;
		public virtual RMethod RInitTrackCount
		{
			get
			{
				if(r_RInitTrackCount == null)
				{
					r_RInitTrackCount = new(this, "InitTrackCount", 0);
					r_RInitTrackCount.SetBelong(this.instance);
				}
				return r_RInitTrackCount;
			}
		}

		/// <summary>
		/// Void InitMatch()
		/// </summary>
		protected RMethod r_RInitMatch;
		public virtual RMethod RInitMatch
		{
			get
			{
				if(r_RInitMatch == null)
				{
					r_RInitMatch = new(this, "InitMatch", 0);
					r_RInitMatch.SetBelong(this.instance);
				}
				return r_RInitMatch;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match TidyMatch(Boolean)
		/// </summary>
		protected RMethod r_RTidyMatch_Boolean;
		public virtual RMethod RTidyMatch_Boolean
		{
			get
			{
				if(r_RTidyMatch_Boolean == null)
				{
					r_RTidyMatch_Boolean = new(this, "TidyMatch", 0, typeof(System.Boolean));
					r_RTidyMatch_Boolean.SetBelong(this.instance);
				}
				return r_RTidyMatch_Boolean;
			}
		}

		/// <summary>
		/// Void EnsureStorage()
		/// </summary>
		protected RMethod r_REnsureStorage;
		public virtual RMethod REnsureStorage
		{
			get
			{
				if(r_REnsureStorage == null)
				{
					r_REnsureStorage = new(this, "EnsureStorage", 0);
					r_REnsureStorage.SetBelong(this.instance);
				}
				return r_REnsureStorage;
			}
		}

		/// <summary>
		/// Boolean IsBoundary(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RIsBoundary_Int32_Int32_Int32;
		public virtual RMethod RIsBoundary_Int32_Int32_Int32
		{
			get
			{
				if(r_RIsBoundary_Int32_Int32_Int32 == null)
				{
					r_RIsBoundary_Int32_Int32_Int32 = new(this, "IsBoundary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RIsBoundary_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RIsBoundary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsECMABoundary(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RIsECMABoundary_Int32_Int32_Int32;
		public virtual RMethod RIsECMABoundary_Int32_Int32_Int32
		{
			get
			{
				if(r_RIsECMABoundary_Int32_Int32_Int32 == null)
				{
					r_RIsECMABoundary_Int32_Int32_Int32 = new(this, "IsECMABoundary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RIsECMABoundary_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RIsECMABoundary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean CharInSet(Char, System.String, System.String)
		/// </summary>
		protected static RMethod r_RCharInSet_Char_String_String;
		public static RMethod RCharInSet_Char_String_String
		{
			get
			{
				if(r_RCharInSet_Char_String_String == null)
				{
					r_RCharInSet_Char_String_String = new(typeof(System.Text.RegularExpressions.RegexRunner), "CharInSet", 0, typeof(System.Char), typeof(System.String), typeof(System.String));
					r_RCharInSet_Char_String_String.SetBelong(null);
				}
				return r_RCharInSet_Char_String_String;
			}
		}

		/// <summary>
		/// Boolean CharInClass(Char, System.String)
		/// </summary>
		protected static RMethod r_RCharInClass_Char_String;
		public static RMethod RCharInClass_Char_String
		{
			get
			{
				if(r_RCharInClass_Char_String == null)
				{
					r_RCharInClass_Char_String = new(typeof(System.Text.RegularExpressions.RegexRunner), "CharInClass", 0, typeof(System.Char), typeof(System.String));
					r_RCharInClass_Char_String.SetBelong(null);
				}
				return r_RCharInClass_Char_String;
			}
		}

		/// <summary>
		/// Void DoubleTrack()
		/// </summary>
		protected RMethod r_RDoubleTrack;
		public virtual RMethod RDoubleTrack
		{
			get
			{
				if(r_RDoubleTrack == null)
				{
					r_RDoubleTrack = new(this, "DoubleTrack", 0);
					r_RDoubleTrack.SetBelong(this.instance);
				}
				return r_RDoubleTrack;
			}
		}

		/// <summary>
		/// Void DoubleStack()
		/// </summary>
		protected RMethod r_RDoubleStack;
		public virtual RMethod RDoubleStack
		{
			get
			{
				if(r_RDoubleStack == null)
				{
					r_RDoubleStack = new(this, "DoubleStack", 0);
					r_RDoubleStack.SetBelong(this.instance);
				}
				return r_RDoubleStack;
			}
		}

		/// <summary>
		/// Void DoubleCrawl()
		/// </summary>
		protected RMethod r_RDoubleCrawl;
		public virtual RMethod RDoubleCrawl
		{
			get
			{
				if(r_RDoubleCrawl == null)
				{
					r_RDoubleCrawl = new(this, "DoubleCrawl", 0);
					r_RDoubleCrawl.SetBelong(this.instance);
				}
				return r_RDoubleCrawl;
			}
		}

		/// <summary>
		/// Void Crawl(Int32)
		/// </summary>
		protected RMethod r_RCrawl_Int32;
		public virtual RMethod RCrawl_Int32
		{
			get
			{
				if(r_RCrawl_Int32 == null)
				{
					r_RCrawl_Int32 = new(this, "Crawl", 0, typeof(System.Int32));
					r_RCrawl_Int32.SetBelong(this.instance);
				}
				return r_RCrawl_Int32;
			}
		}

		/// <summary>
		/// Int32 Popcrawl()
		/// </summary>
		protected RMethod r_RPopcrawl;
		public virtual RMethod RPopcrawl
		{
			get
			{
				if(r_RPopcrawl == null)
				{
					r_RPopcrawl = new(this, "Popcrawl", 0);
					r_RPopcrawl.SetBelong(this.instance);
				}
				return r_RPopcrawl;
			}
		}

		/// <summary>
		/// Int32 Crawlpos()
		/// </summary>
		protected RMethod r_RCrawlpos;
		public virtual RMethod RCrawlpos
		{
			get
			{
				if(r_RCrawlpos == null)
				{
					r_RCrawlpos = new(this, "Crawlpos", 0);
					r_RCrawlpos.SetBelong(this.instance);
				}
				return r_RCrawlpos;
			}
		}

		/// <summary>
		/// Void Capture(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RCapture_Int32_Int32_Int32;
		public virtual RMethod RCapture_Int32_Int32_Int32
		{
			get
			{
				if(r_RCapture_Int32_Int32_Int32 == null)
				{
					r_RCapture_Int32_Int32_Int32 = new(this, "Capture", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RCapture_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCapture_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void TransferCapture(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RTransferCapture_Int32_Int32_Int32_Int32;
		public virtual RMethod RTransferCapture_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RTransferCapture_Int32_Int32_Int32_Int32 == null)
				{
					r_RTransferCapture_Int32_Int32_Int32_Int32 = new(this, "TransferCapture", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RTransferCapture_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RTransferCapture_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Uncapture()
		/// </summary>
		protected RMethod r_RUncapture;
		public virtual RMethod RUncapture
		{
			get
			{
				if(r_RUncapture == null)
				{
					r_RUncapture = new(this, "Uncapture", 0);
					r_RUncapture.SetBelong(this.instance);
				}
				return r_RUncapture;
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


        public RRegexRunner() : base("System.Text.RegularExpressions.RegexRunner")
        {
        }

        public RRegexRunner(System.Object instance) : base("System.Text.RegularExpressions.RegexRunner")
		{
            SetInstance(instance);
		}

        public RRegexRunner(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexRunner(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex  @regex, System.String  @text, System.Int32  @textbeg, System.Int32  @textend, System.Int32  @textstart, System.Int32  @prevlen, System.Boolean  @quick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart, @prevlen, @quick};
            var ___result = RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex  @regex, System.String  @text, System.Int32  @textbeg, System.Int32  @textend, System.Int32  @textstart, System.Int32  @prevlen, System.Boolean  @quick, System.TimeSpan  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart, @prevlen, @quick, @timeout};
            var ___result = RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void StartTimeoutWatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartTimeoutWatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckTimeout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckTimeout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoCheckTimeout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoCheckTimeout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Go()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean FindFirstChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFindFirstChar.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InitTrackCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitTrackCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitMatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitMatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.Match TidyMatch(System.Boolean  @quick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@quick};
            var ___result = RTidyMatch_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void EnsureStorage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureStorage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsBoundary(System.Int32  @index, System.Int32  @startpos, System.Int32  @endpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @startpos, @endpos};
            var ___result = RIsBoundary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsECMABoundary(System.Int32  @index, System.Int32  @startpos, System.Int32  @endpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @startpos, @endpos};
            var ___result = RIsECMABoundary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CharInSet(System.Char  @ch, System.String  @set, System.String  @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @set, @category};
            var ___result = RCharInSet_Char_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CharInClass(System.Char  @ch, System.String  @charClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @charClass};
            var ___result = RCharInClass_Char_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DoubleTrack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoubleTrack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoubleStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoubleStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoubleCrawl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDoubleCrawl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Crawl(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RCrawl_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Popcrawl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopcrawl.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Crawlpos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCrawlpos.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Capture(System.Int32  @capnum, System.Int32  @start, System.Int32  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capnum, @start, @end};
            var ___result = RCapture_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransferCapture(System.Int32  @capnum, System.Int32  @uncapnum, System.Int32  @start, System.Int32  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capnum, @uncapnum, @start, @end};
            var ___result = RTransferCapture_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Uncapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUncapture.Invoke(___genericsType, ___parameters);

            
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
