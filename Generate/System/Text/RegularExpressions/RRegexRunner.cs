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
		protected RSystem.RInt32 r_runtextbeg;
		public virtual RSystem.RInt32 Rruntextbeg
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
		protected RSystem.RInt32 r_runtextend;
		public virtual RSystem.RInt32 Rruntextend
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
		protected RSystem.RInt32 r_runtextstart;
		public virtual RSystem.RInt32 Rruntextstart
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
		protected RSystem.RString r_runtext;
		public virtual RSystem.RString Rruntext
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
		protected RSystem.RInt32 r_runtextpos;
		public virtual RSystem.RInt32 Rruntextpos
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
		protected RFieldArray<RSystem.RInt32> r_runtrack;
		public virtual RFieldArray<RSystem.RInt32> Rruntrack
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
		protected RSystem.RInt32 r_runtrackpos;
		public virtual RSystem.RInt32 Rruntrackpos
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
		protected RFieldArray<RSystem.RInt32> r_runstack;
		public virtual RFieldArray<RSystem.RInt32> Rrunstack
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
		protected RSystem.RInt32 r_runstackpos;
		public virtual RSystem.RInt32 Rrunstackpos
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
		protected RFieldArray<RSystem.RInt32> r_runcrawl;
		public virtual RFieldArray<RSystem.RInt32> Rruncrawl
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
		protected RSystem.RInt32 r_runcrawlpos;
		public virtual RSystem.RInt32 Rruncrawlpos
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
		protected RSystem.RInt32 r_runtrackcount;
		public virtual RSystem.RInt32 Rruntrackcount
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
		protected RSystem.RInt32 r__timeout;
		public virtual RSystem.RInt32 R_timeout
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
		protected RSystem.RBoolean r__ignoreTimeout;
		public virtual RSystem.RBoolean R_ignoreTimeout
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
		protected RSystem.RInt32 r__timeoutOccursAt;
		public virtual RSystem.RInt32 R_timeoutOccursAt
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
		protected static RSystem.RInt32 r_TimeoutCheckFrequency;
		public static RSystem.RInt32 RTimeoutCheckFrequency
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
		protected RSystem.RInt32 r__timeoutChecksToSkip;
		public virtual RSystem.RInt32 R_timeoutChecksToSkip
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
		protected RMethod r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean;
		public virtual RMethod RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean == null)
				{
					r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean = new(this, "Scan", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
		/// </summary>
		protected RMethod r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan;
		public virtual RMethod RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan
		{
			get
			{
				if(r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan == null)
				{
					r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan = new(this, "Scan", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.TimeSpan));
					r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan.SetBelong(this.instance);
				}
				return r_Scan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan;
			}
		}

		/// <summary>
		/// Void StartTimeoutWatch()
		/// </summary>
		protected RMethod r_StartTimeoutWatch;
		public virtual RMethod RStartTimeoutWatch
		{
			get
			{
				if(r_StartTimeoutWatch == null)
				{
					r_StartTimeoutWatch = new(this, "StartTimeoutWatch", 0);
					r_StartTimeoutWatch.SetBelong(this.instance);
				}
				return r_StartTimeoutWatch;
			}
		}

		/// <summary>
		/// Void CheckTimeout()
		/// </summary>
		protected RMethod r_CheckTimeout;
		public virtual RMethod RCheckTimeout
		{
			get
			{
				if(r_CheckTimeout == null)
				{
					r_CheckTimeout = new(this, "CheckTimeout", 0);
					r_CheckTimeout.SetBelong(this.instance);
				}
				return r_CheckTimeout;
			}
		}

		/// <summary>
		/// Void DoCheckTimeout()
		/// </summary>
		protected RMethod r_DoCheckTimeout;
		public virtual RMethod RDoCheckTimeout
		{
			get
			{
				if(r_DoCheckTimeout == null)
				{
					r_DoCheckTimeout = new(this, "DoCheckTimeout", 0);
					r_DoCheckTimeout.SetBelong(this.instance);
				}
				return r_DoCheckTimeout;
			}
		}

		/// <summary>
		/// Void Go()
		/// </summary>
		protected RMethod r_Go;
		public virtual RMethod RGo
		{
			get
			{
				if(r_Go == null)
				{
					r_Go = new(this, "Go", 0);
					r_Go.SetBelong(this.instance);
				}
				return r_Go;
			}
		}

		/// <summary>
		/// Boolean FindFirstChar()
		/// </summary>
		protected RMethod r_FindFirstChar;
		public virtual RMethod RFindFirstChar
		{
			get
			{
				if(r_FindFirstChar == null)
				{
					r_FindFirstChar = new(this, "FindFirstChar", 0);
					r_FindFirstChar.SetBelong(this.instance);
				}
				return r_FindFirstChar;
			}
		}

		/// <summary>
		/// Void InitTrackCount()
		/// </summary>
		protected RMethod r_InitTrackCount;
		public virtual RMethod RInitTrackCount
		{
			get
			{
				if(r_InitTrackCount == null)
				{
					r_InitTrackCount = new(this, "InitTrackCount", 0);
					r_InitTrackCount.SetBelong(this.instance);
				}
				return r_InitTrackCount;
			}
		}

		/// <summary>
		/// Void InitMatch()
		/// </summary>
		protected RMethod r_InitMatch;
		public virtual RMethod RInitMatch
		{
			get
			{
				if(r_InitMatch == null)
				{
					r_InitMatch = new(this, "InitMatch", 0);
					r_InitMatch.SetBelong(this.instance);
				}
				return r_InitMatch;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match TidyMatch(Boolean)
		/// </summary>
		protected RMethod r_TidyMatch_Boolean;
		public virtual RMethod RTidyMatch_Boolean
		{
			get
			{
				if(r_TidyMatch_Boolean == null)
				{
					r_TidyMatch_Boolean = new(this, "TidyMatch", 0, typeof(System.Boolean));
					r_TidyMatch_Boolean.SetBelong(this.instance);
				}
				return r_TidyMatch_Boolean;
			}
		}

		/// <summary>
		/// Void EnsureStorage()
		/// </summary>
		protected RMethod r_EnsureStorage;
		public virtual RMethod REnsureStorage
		{
			get
			{
				if(r_EnsureStorage == null)
				{
					r_EnsureStorage = new(this, "EnsureStorage", 0);
					r_EnsureStorage.SetBelong(this.instance);
				}
				return r_EnsureStorage;
			}
		}

		/// <summary>
		/// Boolean IsBoundary(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsBoundary_Int32_Int32_Int32;
		public virtual RMethod RIsBoundary_Int32_Int32_Int32
		{
			get
			{
				if(r_IsBoundary_Int32_Int32_Int32 == null)
				{
					r_IsBoundary_Int32_Int32_Int32 = new(this, "IsBoundary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsBoundary_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsBoundary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsECMABoundary(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_IsECMABoundary_Int32_Int32_Int32;
		public virtual RMethod RIsECMABoundary_Int32_Int32_Int32
		{
			get
			{
				if(r_IsECMABoundary_Int32_Int32_Int32 == null)
				{
					r_IsECMABoundary_Int32_Int32_Int32 = new(this, "IsECMABoundary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_IsECMABoundary_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_IsECMABoundary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean CharInSet(Char, System.String, System.String)
		/// </summary>
		protected static RMethod r_CharInSet_Char_String_String;
		public static RMethod RCharInSet_Char_String_String
		{
			get
			{
				if(r_CharInSet_Char_String_String == null)
				{
					r_CharInSet_Char_String_String = new(typeof(System.Text.RegularExpressions.RegexRunner), "CharInSet", 0, typeof(System.Char), typeof(System.String), typeof(System.String));
					r_CharInSet_Char_String_String.SetBelong(null);
				}
				return r_CharInSet_Char_String_String;
			}
		}

		/// <summary>
		/// Boolean CharInClass(Char, System.String)
		/// </summary>
		protected static RMethod r_CharInClass_Char_String;
		public static RMethod RCharInClass_Char_String
		{
			get
			{
				if(r_CharInClass_Char_String == null)
				{
					r_CharInClass_Char_String = new(typeof(System.Text.RegularExpressions.RegexRunner), "CharInClass", 0, typeof(System.Char), typeof(System.String));
					r_CharInClass_Char_String.SetBelong(null);
				}
				return r_CharInClass_Char_String;
			}
		}

		/// <summary>
		/// Void DoubleTrack()
		/// </summary>
		protected RMethod r_DoubleTrack;
		public virtual RMethod RDoubleTrack
		{
			get
			{
				if(r_DoubleTrack == null)
				{
					r_DoubleTrack = new(this, "DoubleTrack", 0);
					r_DoubleTrack.SetBelong(this.instance);
				}
				return r_DoubleTrack;
			}
		}

		/// <summary>
		/// Void DoubleStack()
		/// </summary>
		protected RMethod r_DoubleStack;
		public virtual RMethod RDoubleStack
		{
			get
			{
				if(r_DoubleStack == null)
				{
					r_DoubleStack = new(this, "DoubleStack", 0);
					r_DoubleStack.SetBelong(this.instance);
				}
				return r_DoubleStack;
			}
		}

		/// <summary>
		/// Void DoubleCrawl()
		/// </summary>
		protected RMethod r_DoubleCrawl;
		public virtual RMethod RDoubleCrawl
		{
			get
			{
				if(r_DoubleCrawl == null)
				{
					r_DoubleCrawl = new(this, "DoubleCrawl", 0);
					r_DoubleCrawl.SetBelong(this.instance);
				}
				return r_DoubleCrawl;
			}
		}

		/// <summary>
		/// Void Crawl(Int32)
		/// </summary>
		protected RMethod r_Crawl_Int32;
		public virtual RMethod RCrawl_Int32
		{
			get
			{
				if(r_Crawl_Int32 == null)
				{
					r_Crawl_Int32 = new(this, "Crawl", 0, typeof(System.Int32));
					r_Crawl_Int32.SetBelong(this.instance);
				}
				return r_Crawl_Int32;
			}
		}

		/// <summary>
		/// Int32 Popcrawl()
		/// </summary>
		protected RMethod r_Popcrawl;
		public virtual RMethod RPopcrawl
		{
			get
			{
				if(r_Popcrawl == null)
				{
					r_Popcrawl = new(this, "Popcrawl", 0);
					r_Popcrawl.SetBelong(this.instance);
				}
				return r_Popcrawl;
			}
		}

		/// <summary>
		/// Int32 Crawlpos()
		/// </summary>
		protected RMethod r_Crawlpos;
		public virtual RMethod RCrawlpos
		{
			get
			{
				if(r_Crawlpos == null)
				{
					r_Crawlpos = new(this, "Crawlpos", 0);
					r_Crawlpos.SetBelong(this.instance);
				}
				return r_Crawlpos;
			}
		}

		/// <summary>
		/// Void Capture(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_Capture_Int32_Int32_Int32;
		public virtual RMethod RCapture_Int32_Int32_Int32
		{
			get
			{
				if(r_Capture_Int32_Int32_Int32 == null)
				{
					r_Capture_Int32_Int32_Int32 = new(this, "Capture", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_Capture_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_Capture_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void TransferCapture(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_TransferCapture_Int32_Int32_Int32_Int32;
		public virtual RMethod RTransferCapture_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_TransferCapture_Int32_Int32_Int32_Int32 == null)
				{
					r_TransferCapture_Int32_Int32_Int32_Int32 = new(this, "TransferCapture", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_TransferCapture_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_TransferCapture_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Uncapture()
		/// </summary>
		protected RMethod r_Uncapture;
		public virtual RMethod RUncapture
		{
			get
			{
				if(r_Uncapture == null)
				{
					r_Uncapture = new(this, "Uncapture", 0);
					r_Uncapture.SetBelong(this.instance);
				}
				return r_Uncapture;
			}
		}

		/// <summary>
		/// Boolean IsMatched(Int32)
		/// </summary>
		protected RMethod r_IsMatched_Int32;
		public virtual RMethod RIsMatched_Int32
		{
			get
			{
				if(r_IsMatched_Int32 == null)
				{
					r_IsMatched_Int32 = new(this, "IsMatched", 0, typeof(System.Int32));
					r_IsMatched_Int32.SetBelong(this.instance);
				}
				return r_IsMatched_Int32;
			}
		}

		/// <summary>
		/// Int32 MatchIndex(Int32)
		/// </summary>
		protected RMethod r_MatchIndex_Int32;
		public virtual RMethod RMatchIndex_Int32
		{
			get
			{
				if(r_MatchIndex_Int32 == null)
				{
					r_MatchIndex_Int32 = new(this, "MatchIndex", 0, typeof(System.Int32));
					r_MatchIndex_Int32.SetBelong(this.instance);
				}
				return r_MatchIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 MatchLength(Int32)
		/// </summary>
		protected RMethod r_MatchLength_Int32;
		public virtual RMethod RMatchLength_Int32
		{
			get
			{
				if(r_MatchLength_Int32 == null)
				{
					r_MatchLength_Int32 = new(this, "MatchLength", 0, typeof(System.Int32));
					r_MatchLength_Int32.SetBelong(this.instance);
				}
				return r_MatchLength_Int32;
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

        public virtual System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex @regex, System.String @text, System.Int32 @textbeg, System.Int32 @textend, System.Int32 @textstart, System.Int32 @prevlen, System.Boolean @quick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart, @prevlen, @quick};
            var ___result = RScan_Regex_String_Int32_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex @regex, System.String @text, System.Int32 @textbeg, System.Int32 @textend, System.Int32 @textstart, System.Int32 @prevlen, System.Boolean @quick, System.TimeSpan @timeout)
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


        public virtual System.Text.RegularExpressions.Match TidyMatch(System.Boolean @quick)
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


        public virtual System.Boolean IsBoundary(System.Int32 @index, System.Int32 @startpos, System.Int32 @endpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @startpos, @endpos};
            var ___result = RIsBoundary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsECMABoundary(System.Int32 @index, System.Int32 @startpos, System.Int32 @endpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @startpos, @endpos};
            var ___result = RIsECMABoundary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CharInSet(System.Char @ch, System.String @set, System.String @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @set, @category};
            var ___result = RCharInSet_Char_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CharInClass(System.Char @ch, System.String @charClass)
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


        public virtual void Crawl(System.Int32 @i)
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


        public virtual void Capture(System.Int32 @capnum, System.Int32 @start, System.Int32 @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capnum, @start, @end};
            var ___result = RCapture_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransferCapture(System.Int32 @capnum, System.Int32 @uncapnum, System.Int32 @start, System.Int32 @end)
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


        public virtual System.Boolean IsMatched(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RIsMatched_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 MatchIndex(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMatchIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 MatchLength(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMatchLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
