
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.RegexRunner
	/// </summary>
    public partial class RRegexRunner : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Text.RegularExpressions.RegexRunner);
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


		/// <summary>
		/// System.Int32 runtextbeg
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruntextbeg;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruntextbeg
		{
			get
			{
				if(r_Fruntextbeg == null)
				{
					r_Fruntextbeg = new(this, "runtextbeg");
				}
				return r_Fruntextbeg;
			}
		}

		/// <summary>
		/// System.Int32 runtextend
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruntextend;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruntextend
		{
			get
			{
				if(r_Fruntextend == null)
				{
					r_Fruntextend = new(this, "runtextend");
				}
				return r_Fruntextend;
			}
		}

		/// <summary>
		/// System.Int32 runtextstart
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruntextstart;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruntextstart
		{
			get
			{
				if(r_Fruntextstart == null)
				{
					r_Fruntextstart = new(this, "runtextstart");
				}
				return r_Fruntextstart;
			}
		}

		/// <summary>
		/// System.String runtext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fruntext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFruntext
		{
			get
			{
				if(r_Fruntext == null)
				{
					r_Fruntext = new(this, "runtext");
				}
				return r_Fruntext;
			}
		}

		/// <summary>
		/// System.Int32 runtextpos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruntextpos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruntextpos
		{
			get
			{
				if(r_Fruntextpos == null)
				{
					r_Fruntextpos = new(this, "runtextpos");
				}
				return r_Fruntextpos;
			}
		}

		/// <summary>
		/// System.Int32[] runtrack
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fruntrack;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFruntrack
		{
			get
			{
				if(r_Fruntrack == null)
				{
					r_Fruntrack = new(this, "runtrack");
				}
				return r_Fruntrack;
			}
		}

		/// <summary>
		/// System.Int32 runtrackpos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruntrackpos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruntrackpos
		{
			get
			{
				if(r_Fruntrackpos == null)
				{
					r_Fruntrackpos = new(this, "runtrackpos");
				}
				return r_Fruntrackpos;
			}
		}

		/// <summary>
		/// System.Int32[] runstack
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Frunstack;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFrunstack
		{
			get
			{
				if(r_Frunstack == null)
				{
					r_Frunstack = new(this, "runstack");
				}
				return r_Frunstack;
			}
		}

		/// <summary>
		/// System.Int32 runstackpos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Frunstackpos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFrunstackpos
		{
			get
			{
				if(r_Frunstackpos == null)
				{
					r_Frunstackpos = new(this, "runstackpos");
				}
				return r_Frunstackpos;
			}
		}

		/// <summary>
		/// System.Int32[] runcrawl
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fruncrawl;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RInt32> RFruncrawl
		{
			get
			{
				if(r_Fruncrawl == null)
				{
					r_Fruncrawl = new(this, "runcrawl");
				}
				return r_Fruncrawl;
			}
		}

		/// <summary>
		/// System.Int32 runcrawlpos
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruncrawlpos;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruncrawlpos
		{
			get
			{
				if(r_Fruncrawlpos == null)
				{
					r_Fruncrawlpos = new(this, "runcrawlpos");
				}
				return r_Fruncrawlpos;
			}
		}

		/// <summary>
		/// System.Int32 runtrackcount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fruntrackcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFruntrackcount
		{
			get
			{
				if(r_Fruntrackcount == null)
				{
					r_Fruntrackcount = new(this, "runtrackcount");
				}
				return r_Fruntrackcount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match runmatch
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch r_Frunmatch;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RMatch RFrunmatch
		{
			get
			{
				if(r_Frunmatch == null)
				{
					r_Frunmatch = new(this, "runmatch");
				}
				return r_Frunmatch;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex runregex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex r_Frunregex;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex RFrunregex
		{
			get
			{
				if(r_Frunregex == null)
				{
					r_Frunregex = new(this, "runregex");
				}
				return r_Frunregex;
			}
		}

		/// <summary>
		/// System.Int32 _timeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_timeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_timeout
		{
			get
			{
				if(r_F_timeout == null)
				{
					r_F_timeout = new(this, "_timeout");
				}
				return r_F_timeout;
			}
		}

		/// <summary>
		/// System.Boolean _ignoreTimeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_ignoreTimeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_ignoreTimeout
		{
			get
			{
				if(r_F_ignoreTimeout == null)
				{
					r_F_ignoreTimeout = new(this, "_ignoreTimeout");
				}
				return r_F_ignoreTimeout;
			}
		}

		/// <summary>
		/// System.Int32 _timeoutOccursAt
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_timeoutOccursAt;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_timeoutOccursAt
		{
			get
			{
				if(r_F_timeoutOccursAt == null)
				{
					r_F_timeoutOccursAt = new(this, "_timeoutOccursAt");
				}
				return r_F_timeoutOccursAt;
			}
		}

		/// <summary>
		/// System.Int32 TimeoutCheckFrequency
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FTimeoutCheckFrequency;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFTimeoutCheckFrequency
		{
			get
			{
				if(r_FTimeoutCheckFrequency == null)
				{
					r_FTimeoutCheckFrequency = new(typeof(System.Text.RegularExpressions.RegexRunner), "TimeoutCheckFrequency");
				}
				return r_FTimeoutCheckFrequency;
			}
		}

		/// <summary>
		/// System.Int32 _timeoutChecksToSkip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_timeoutChecksToSkip;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_timeoutChecksToSkip
		{
			get
			{
				if(r_F_timeoutChecksToSkip == null)
				{
					r_F_timeoutChecksToSkip = new(this, "_timeoutChecksToSkip");
				}
				return r_F_timeoutChecksToSkip;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean;
		public virtual RMethod RMScan_Regex_String_Int32_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean == null)
				{
					r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean = new(this, "Scan", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex, System.String, Int32, Int32, Int32, Int32, Boolean, System.TimeSpan)
		/// </summary>
		protected RMethod r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan;
		public virtual RMethod RMScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan
		{
			get
			{
				if(r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan == null)
				{
					r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan = new(this, "Scan", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.TimeSpan));
				}
				return r_MScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan;
			}
		}

		/// <summary>
		/// Void StartTimeoutWatch()
		/// </summary>
		protected RMethod r_MStartTimeoutWatch;
		public virtual RMethod RMStartTimeoutWatch
		{
			get
			{
				if(r_MStartTimeoutWatch == null)
				{
					r_MStartTimeoutWatch = new(this, "StartTimeoutWatch", 0);
				}
				return r_MStartTimeoutWatch;
			}
		}

		/// <summary>
		/// Void CheckTimeout()
		/// </summary>
		protected RMethod r_MCheckTimeout;
		public virtual RMethod RMCheckTimeout
		{
			get
			{
				if(r_MCheckTimeout == null)
				{
					r_MCheckTimeout = new(this, "CheckTimeout", 0);
				}
				return r_MCheckTimeout;
			}
		}

		/// <summary>
		/// Void DoCheckTimeout()
		/// </summary>
		protected RMethod r_MDoCheckTimeout;
		public virtual RMethod RMDoCheckTimeout
		{
			get
			{
				if(r_MDoCheckTimeout == null)
				{
					r_MDoCheckTimeout = new(this, "DoCheckTimeout", 0);
				}
				return r_MDoCheckTimeout;
			}
		}

		/// <summary>
		/// Void Go()
		/// </summary>
		protected RMethod r_MGo;
		public virtual RMethod RMGo
		{
			get
			{
				if(r_MGo == null)
				{
					r_MGo = new(this, "Go", 0);
				}
				return r_MGo;
			}
		}

		/// <summary>
		/// Boolean FindFirstChar()
		/// </summary>
		protected RMethod r_MFindFirstChar;
		public virtual RMethod RMFindFirstChar
		{
			get
			{
				if(r_MFindFirstChar == null)
				{
					r_MFindFirstChar = new(this, "FindFirstChar", 0);
				}
				return r_MFindFirstChar;
			}
		}

		/// <summary>
		/// Void InitTrackCount()
		/// </summary>
		protected RMethod r_MInitTrackCount;
		public virtual RMethod RMInitTrackCount
		{
			get
			{
				if(r_MInitTrackCount == null)
				{
					r_MInitTrackCount = new(this, "InitTrackCount", 0);
				}
				return r_MInitTrackCount;
			}
		}

		/// <summary>
		/// Void InitMatch()
		/// </summary>
		protected RMethod r_MInitMatch;
		public virtual RMethod RMInitMatch
		{
			get
			{
				if(r_MInitMatch == null)
				{
					r_MInitMatch = new(this, "InitMatch", 0);
				}
				return r_MInitMatch;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match TidyMatch(Boolean)
		/// </summary>
		protected RMethod r_MTidyMatch_Boolean;
		public virtual RMethod RMTidyMatch_Boolean
		{
			get
			{
				if(r_MTidyMatch_Boolean == null)
				{
					r_MTidyMatch_Boolean = new(this, "TidyMatch", 0, typeof(System.Boolean));
				}
				return r_MTidyMatch_Boolean;
			}
		}

		/// <summary>
		/// Void EnsureStorage()
		/// </summary>
		protected RMethod r_MEnsureStorage;
		public virtual RMethod RMEnsureStorage
		{
			get
			{
				if(r_MEnsureStorage == null)
				{
					r_MEnsureStorage = new(this, "EnsureStorage", 0);
				}
				return r_MEnsureStorage;
			}
		}

		/// <summary>
		/// Boolean IsBoundary(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsBoundary_Int32_Int32_Int32;
		public virtual RMethod RMIsBoundary_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsBoundary_Int32_Int32_Int32 == null)
				{
					r_MIsBoundary_Int32_Int32_Int32 = new(this, "IsBoundary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsBoundary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsECMABoundary(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MIsECMABoundary_Int32_Int32_Int32;
		public virtual RMethod RMIsECMABoundary_Int32_Int32_Int32
		{
			get
			{
				if(r_MIsECMABoundary_Int32_Int32_Int32 == null)
				{
					r_MIsECMABoundary_Int32_Int32_Int32 = new(this, "IsECMABoundary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MIsECMABoundary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean CharInSet(Char, System.String, System.String)
		/// </summary>
		protected static RMethod r_MCharInSet_Char_String_String;
		public static RMethod RMCharInSet_Char_String_String
		{
			get
			{
				if(r_MCharInSet_Char_String_String == null)
				{
					r_MCharInSet_Char_String_String = new(typeof(System.Text.RegularExpressions.RegexRunner), "CharInSet", 0, typeof(System.Char), typeof(System.String), typeof(System.String));
				}
				return r_MCharInSet_Char_String_String;
			}
		}

		/// <summary>
		/// Boolean CharInClass(Char, System.String)
		/// </summary>
		protected static RMethod r_MCharInClass_Char_String;
		public static RMethod RMCharInClass_Char_String
		{
			get
			{
				if(r_MCharInClass_Char_String == null)
				{
					r_MCharInClass_Char_String = new(typeof(System.Text.RegularExpressions.RegexRunner), "CharInClass", 0, typeof(System.Char), typeof(System.String));
				}
				return r_MCharInClass_Char_String;
			}
		}

		/// <summary>
		/// Void DoubleTrack()
		/// </summary>
		protected RMethod r_MDoubleTrack;
		public virtual RMethod RMDoubleTrack
		{
			get
			{
				if(r_MDoubleTrack == null)
				{
					r_MDoubleTrack = new(this, "DoubleTrack", 0);
				}
				return r_MDoubleTrack;
			}
		}

		/// <summary>
		/// Void DoubleStack()
		/// </summary>
		protected RMethod r_MDoubleStack;
		public virtual RMethod RMDoubleStack
		{
			get
			{
				if(r_MDoubleStack == null)
				{
					r_MDoubleStack = new(this, "DoubleStack", 0);
				}
				return r_MDoubleStack;
			}
		}

		/// <summary>
		/// Void DoubleCrawl()
		/// </summary>
		protected RMethod r_MDoubleCrawl;
		public virtual RMethod RMDoubleCrawl
		{
			get
			{
				if(r_MDoubleCrawl == null)
				{
					r_MDoubleCrawl = new(this, "DoubleCrawl", 0);
				}
				return r_MDoubleCrawl;
			}
		}

		/// <summary>
		/// Void Crawl(Int32)
		/// </summary>
		protected RMethod r_MCrawl_Int32;
		public virtual RMethod RMCrawl_Int32
		{
			get
			{
				if(r_MCrawl_Int32 == null)
				{
					r_MCrawl_Int32 = new(this, "Crawl", 0, typeof(System.Int32));
				}
				return r_MCrawl_Int32;
			}
		}

		/// <summary>
		/// Int32 Popcrawl()
		/// </summary>
		protected RMethod r_MPopcrawl;
		public virtual RMethod RMPopcrawl
		{
			get
			{
				if(r_MPopcrawl == null)
				{
					r_MPopcrawl = new(this, "Popcrawl", 0);
				}
				return r_MPopcrawl;
			}
		}

		/// <summary>
		/// Int32 Crawlpos()
		/// </summary>
		protected RMethod r_MCrawlpos;
		public virtual RMethod RMCrawlpos
		{
			get
			{
				if(r_MCrawlpos == null)
				{
					r_MCrawlpos = new(this, "Crawlpos", 0);
				}
				return r_MCrawlpos;
			}
		}

		/// <summary>
		/// Void Capture(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MCapture_Int32_Int32_Int32;
		public virtual RMethod RMCapture_Int32_Int32_Int32
		{
			get
			{
				if(r_MCapture_Int32_Int32_Int32 == null)
				{
					r_MCapture_Int32_Int32_Int32 = new(this, "Capture", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCapture_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void TransferCapture(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MTransferCapture_Int32_Int32_Int32_Int32;
		public virtual RMethod RMTransferCapture_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MTransferCapture_Int32_Int32_Int32_Int32 == null)
				{
					r_MTransferCapture_Int32_Int32_Int32_Int32 = new(this, "TransferCapture", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MTransferCapture_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Uncapture()
		/// </summary>
		protected RMethod r_MUncapture;
		public virtual RMethod RMUncapture
		{
			get
			{
				if(r_MUncapture == null)
				{
					r_MUncapture = new(this, "Uncapture", 0);
				}
				return r_MUncapture;
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


        public virtual System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex @regex, System.String @text, System.Int32 @textbeg, System.Int32 @textend, System.Int32 @textstart, System.Int32 @prevlen, System.Boolean @quick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart, @prevlen, @quick};
            var ___result = RMScan_Regex_String_Int32_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex @regex, System.String @text, System.Int32 @textbeg, System.Int32 @textend, System.Int32 @textstart, System.Int32 @prevlen, System.Boolean @quick, System.TimeSpan @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @text, @textbeg, @textend, @textstart, @prevlen, @quick, @timeout};
            var ___result = RMScan_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void StartTimeoutWatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStartTimeoutWatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckTimeout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckTimeout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoCheckTimeout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoCheckTimeout.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Go()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean FindFirstChar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindFirstChar.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InitTrackCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitTrackCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitMatch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitMatch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.Match TidyMatch(System.Boolean @quick)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@quick};
            var ___result = RMTidyMatch_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual void EnsureStorage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureStorage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsBoundary(System.Int32 @index, System.Int32 @startpos, System.Int32 @endpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @startpos, @endpos};
            var ___result = RMIsBoundary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsECMABoundary(System.Int32 @index, System.Int32 @startpos, System.Int32 @endpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @startpos, @endpos};
            var ___result = RMIsECMABoundary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CharInSet(System.Char @ch, System.String @set, System.String @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @set, @category};
            var ___result = RMCharInSet_Char_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CharInClass(System.Char @ch, System.String @charClass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch, @charClass};
            var ___result = RMCharInClass_Char_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DoubleTrack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoubleTrack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoubleStack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoubleStack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DoubleCrawl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDoubleCrawl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Crawl(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMCrawl_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Popcrawl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPopcrawl.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Crawlpos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCrawlpos.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Capture(System.Int32 @capnum, System.Int32 @start, System.Int32 @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capnum, @start, @end};
            var ___result = RMCapture_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransferCapture(System.Int32 @capnum, System.Int32 @uncapnum, System.Int32 @start, System.Int32 @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capnum, @uncapnum, @start, @end};
            var ___result = RMTransferCapture_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Uncapture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUncapture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsMatched(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMIsMatched_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 MatchIndex(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMMatchIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 MatchLength(System.Int32 @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RMMatchLength_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
