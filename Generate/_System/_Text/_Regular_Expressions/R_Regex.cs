
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.Regex
	/// </summary>
    public partial class RRegex : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Text.RegularExpressions.Regex);
            }
        }

        public RRegex() : base("System.Text.RegularExpressions.Regex")
        {
        }

        public RRegex(System.Object instance) : base("System.Text.RegularExpressions.Regex")
		{
            SetInstance(instance);
		}

        public RRegex(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegex(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 CacheDictionarySwitchLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCacheDictionarySwitchLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCacheDictionarySwitchLimit
		{
			get
			{
				if(r_FCacheDictionarySwitchLimit == null)
				{
					r_FCacheDictionarySwitchLimit = new(typeof(System.Text.RegularExpressions.Regex), "CacheDictionarySwitchLimit");
				}
				return r_FCacheDictionarySwitchLimit;
			}
		}

		/// <summary>
		/// System.Int32 s_cacheSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_cacheSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_cacheSize
		{
			get
			{
				if(r_Fs_cacheSize == null)
				{
					r_Fs_cacheSize = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheSize");
				}
				return r_Fs_cacheSize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Regex+CachedCodeEntryKey,System.Text.RegularExpressions.Regex+CachedCodeEntry] s_cache
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey, Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry> r_Fs_cache;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey, Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry> RFs_cache
		{
			get
			{
				if(r_Fs_cache == null)
				{
					r_Fs_cache = new(typeof(System.Text.RegularExpressions.Regex), "s_cache");
				}
				return r_Fs_cache;
			}
		}

		/// <summary>
		/// System.Int32 s_cacheCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_cacheCount;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_cacheCount
		{
			get
			{
				if(r_Fs_cacheCount == null)
				{
					r_Fs_cacheCount = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheCount");
				}
				return r_Fs_cacheCount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry s_cacheFirst
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_Fs_cacheFirst;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry RFs_cacheFirst
		{
			get
			{
				if(r_Fs_cacheFirst == null)
				{
					r_Fs_cacheFirst = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheFirst");
				}
				return r_Fs_cacheFirst;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry s_cacheLast
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_Fs_cacheLast;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry RFs_cacheLast
		{
			get
			{
				if(r_Fs_cacheLast == null)
				{
					r_Fs_cacheLast = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheLast");
				}
				return r_Fs_cacheLast;
			}
		}

		/// <summary>
		/// System.TimeSpan s_maximumMatchTimeout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTimeSpan r_Fs_maximumMatchTimeout;
		public static Hvak.Editor.Refleaction.RSystem.RTimeSpan RFs_maximumMatchTimeout
		{
			get
			{
				if(r_Fs_maximumMatchTimeout == null)
				{
					r_Fs_maximumMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "s_maximumMatchTimeout");
				}
				return r_Fs_maximumMatchTimeout;
			}
		}

		/// <summary>
		/// System.String DefaultMatchTimeout_ConfigKeyName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FDefaultMatchTimeout_ConfigKeyName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFDefaultMatchTimeout_ConfigKeyName
		{
			get
			{
				if(r_FDefaultMatchTimeout_ConfigKeyName == null)
				{
					r_FDefaultMatchTimeout_ConfigKeyName = new(typeof(System.Text.RegularExpressions.Regex), "DefaultMatchTimeout_ConfigKeyName");
				}
				return r_FDefaultMatchTimeout_ConfigKeyName;
			}
		}

		/// <summary>
		/// System.TimeSpan s_defaultMatchTimeout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTimeSpan r_Fs_defaultMatchTimeout;
		public static Hvak.Editor.Refleaction.RSystem.RTimeSpan RFs_defaultMatchTimeout
		{
			get
			{
				if(r_Fs_defaultMatchTimeout == null)
				{
					r_Fs_defaultMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "s_defaultMatchTimeout");
				}
				return r_Fs_defaultMatchTimeout;
			}
		}

		/// <summary>
		/// System.TimeSpan InfiniteMatchTimeout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RTimeSpan r_FInfiniteMatchTimeout;
		public static Hvak.Editor.Refleaction.RSystem.RTimeSpan RFInfiniteMatchTimeout
		{
			get
			{
				if(r_FInfiniteMatchTimeout == null)
				{
					r_FInfiniteMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "InfiniteMatchTimeout");
				}
				return r_FInfiniteMatchTimeout;
			}
		}

		/// <summary>
		/// System.TimeSpan internalMatchTimeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RTimeSpan r_FinternalMatchTimeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RTimeSpan RFinternalMatchTimeout
		{
			get
			{
				if(r_FinternalMatchTimeout == null)
				{
					r_FinternalMatchTimeout = new(this, "internalMatchTimeout");
				}
				return r_FinternalMatchTimeout;
			}
		}

		/// <summary>
		/// System.Int32 MaxOptionShift
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxOptionShift;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxOptionShift
		{
			get
			{
				if(r_FMaxOptionShift == null)
				{
					r_FMaxOptionShift = new(typeof(System.Text.RegularExpressions.Regex), "MaxOptionShift");
				}
				return r_FMaxOptionShift;
			}
		}

		/// <summary>
		/// System.String pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fpattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFpattern
		{
			get
			{
				if(r_Fpattern == null)
				{
					r_Fpattern = new(this, "pattern");
				}
				return r_Fpattern;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions roptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_Froptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RFroptions
		{
			get
			{
				if(r_Froptions == null)
				{
					r_Froptions = new(this, "roptions");
				}
				return r_Froptions;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunnerFactory factory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunnerFactory r_Ffactory;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexRunnerFactory RFfactory
		{
			get
			{
				if(r_Ffactory == null)
				{
					r_Ffactory = new(this, "factory");
				}
				return r_Ffactory;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable caps
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fcaps;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFcaps
		{
			get
			{
				if(r_Fcaps == null)
				{
					r_Fcaps = new(this, "caps");
				}
				return r_Fcaps;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable capnames
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_Fcapnames;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RFcapnames
		{
			get
			{
				if(r_Fcapnames == null)
				{
					r_Fcapnames = new(this, "capnames");
				}
				return r_Fcapnames;
			}
		}

		/// <summary>
		/// System.String[] capslist
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fcapslist;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFcapslist
		{
			get
			{
				if(r_Fcapslist == null)
				{
					r_Fcapslist = new(this, "capslist");
				}
				return r_Fcapslist;
			}
		}

		/// <summary>
		/// System.Int32 capsize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcapsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcapsize
		{
			get
			{
				if(r_Fcapsize == null)
				{
					r_Fcapsize = new(this, "capsize");
				}
				return r_Fcapsize;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.ExclusiveReference _runnerref
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RExclusiveReference r_F_runnerref;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RExclusiveReference RF_runnerref
		{
			get
			{
				if(r_F_runnerref == null)
				{
					r_F_runnerref = new(this, "_runnerref");
				}
				return r_F_runnerref;
			}
		}

		/// <summary>
		/// System.WeakReference`1[System.Text.RegularExpressions.RegexReplacement] _replref
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RWeakReference<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement> r_F_replref;
		public virtual Hvak.Editor.Refleaction.RSystem.RWeakReference<Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexReplacement> RF_replref
		{
			get
			{
				if(r_F_replref == null)
				{
					r_F_replref = new(this, "_replref");
				}
				return r_F_replref;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexCode _code
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexCode r_F_code;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexCode RF_code
		{
			get
			{
				if(r_F_code == null)
				{
					r_F_code = new(this, "_code");
				}
				return r_F_code;
			}
		}

		/// <summary>
		/// System.Boolean _refsInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_refsInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_refsInitialized
		{
			get
			{
				if(r_F_refsInitialized == null)
				{
					r_F_refsInitialized = new(this, "_refsInitialized");
				}
				return r_F_refsInitialized;
			}
		}

		/// <summary>
		/// Int32 CacheSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PCacheSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPCacheSize
		{
			get
			{
				if(r_PCacheSize == null)
				{
					r_PCacheSize = new(typeof(System.Text.RegularExpressions.Regex), "CacheSize", -1);
				}
				return r_PCacheSize;
			}
		}

		/// <summary>
		/// System.TimeSpan MatchTimeout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RTimeSpan r_PMatchTimeout;
		public virtual Hvak.Editor.Refleaction.RSystem.RTimeSpan RPMatchTimeout
		{
			get
			{
				if(r_PMatchTimeout == null)
				{
					r_PMatchTimeout = new(this, "MatchTimeout", -1);
				}
				return r_PMatchTimeout;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary Caps
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIDictionary r_PCaps;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIDictionary RPCaps
		{
			get
			{
				if(r_PCaps == null)
				{
					r_PCaps = new(this, "Caps", -1);
				}
				return r_PCaps;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary CapNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIDictionary r_PCapNames;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIDictionary RPCapNames
		{
			get
			{
				if(r_PCapNames == null)
				{
					r_PCapNames = new(this, "CapNames", -1);
				}
				return r_PCapNames;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Options
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_POptions;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RPOptions
		{
			get
			{
				if(r_POptions == null)
				{
					r_POptions = new(this, "Options", -1);
				}
				return r_POptions;
			}
		}

		/// <summary>
		/// Boolean RightToLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PRightToLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPRightToLeft
		{
			get
			{
				if(r_PRightToLeft == null)
				{
					r_PRightToLeft = new(this, "RightToLeft", -1);
				}
				return r_PRightToLeft;
			}
		}

		/// <summary>
		/// CachedCodeEntry GetCachedCode(CachedCodeEntryKey, Boolean)
		/// </summary>
		protected RMethod r_MGetCachedCode_CachedCodeEntryKey_Boolean;
		public virtual RMethod RMGetCachedCode_CachedCodeEntryKey_Boolean
		{
			get
			{
				if(r_MGetCachedCode_CachedCodeEntryKey_Boolean == null)
				{
					r_MGetCachedCode_CachedCodeEntryKey_Boolean = new(this, "GetCachedCode", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"), typeof(System.Boolean));
				}
				return r_MGetCachedCode_CachedCodeEntryKey_Boolean;
			}
		}

		/// <summary>
		/// CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey, Boolean)
		/// </summary>
		protected RMethod r_MGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean;
		public virtual RMethod RMGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean
		{
			get
			{
				if(r_MGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean == null)
				{
					r_MGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean = new(this, "GetCachedCodeEntryInternal", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"), typeof(System.Boolean));
				}
				return r_MGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean;
			}
		}

		/// <summary>
		/// Void FillCacheDictionary()
		/// </summary>
		protected RMethod r_MFillCacheDictionary;
		public virtual RMethod RMFillCacheDictionary
		{
			get
			{
				if(r_MFillCacheDictionary == null)
				{
					r_MFillCacheDictionary = new(this, "FillCacheDictionary", 0);
				}
				return r_MFillCacheDictionary;
			}
		}

		/// <summary>
		/// Boolean TryGetCacheValue(CachedCodeEntryKey, CachedCodeEntry ByRef)
		/// </summary>
		protected static RMethod r_MTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry;
		public static RMethod RMTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry
		{
			get
			{
				if(r_MTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry == null)
				{
					r_MTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry = new(typeof(System.Text.RegularExpressions.Regex), "TryGetCacheValue", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntry").MakeByRefType());
				}
				return r_MTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry;
			}
		}

		/// <summary>
		/// Boolean TryGetCacheValueSmall(CachedCodeEntryKey, CachedCodeEntry ByRef)
		/// </summary>
		protected static RMethod r_MTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry;
		public static RMethod RMTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry
		{
			get
			{
				if(r_MTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry == null)
				{
					r_MTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry = new(typeof(System.Text.RegularExpressions.Regex), "TryGetCacheValueSmall", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntry").MakeByRefType());
				}
				return r_MTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry;
			}
		}

		/// <summary>
		/// CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey)
		/// </summary>
		protected static RMethod r_MLookupCachedAndPromote_CachedCodeEntryKey;
		public static RMethod RMLookupCachedAndPromote_CachedCodeEntryKey
		{
			get
			{
				if(r_MLookupCachedAndPromote_CachedCodeEntryKey == null)
				{
					r_MLookupCachedAndPromote_CachedCodeEntryKey = new(typeof(System.Text.RegularExpressions.Regex), "LookupCachedAndPromote", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
				}
				return r_MLookupCachedAndPromote_CachedCodeEntryKey;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, System.String)
		/// </summary>
		protected static RMethod r_MIsMatch_String_String;
		public static RMethod RMIsMatch_String_String
		{
			get
			{
				if(r_MIsMatch_String_String == null)
				{
					r_MIsMatch_String_String = new(typeof(System.Text.RegularExpressions.Regex), "IsMatch", 0, typeof(System.String), typeof(System.String));
				}
				return r_MIsMatch_String_String;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MIsMatch_String_String_RegexOptions;
		public static RMethod RMIsMatch_String_String_RegexOptions
		{
			get
			{
				if(r_MIsMatch_String_String_RegexOptions == null)
				{
					r_MIsMatch_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "IsMatch", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MIsMatch_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MIsMatch_String_String_RegexOptions_TimeSpan;
		public static RMethod RMIsMatch_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_MIsMatch_String_String_RegexOptions_TimeSpan == null)
				{
					r_MIsMatch_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "IsMatch", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
				}
				return r_MIsMatch_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String)
		/// </summary>
		protected RMethod r_MIsMatch_String;
		public virtual RMethod RMIsMatch_String
		{
			get
			{
				if(r_MIsMatch_String == null)
				{
					r_MIsMatch_String = new(this, "IsMatch", 0, typeof(System.String));
				}
				return r_MIsMatch_String;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, Int32)
		/// </summary>
		protected RMethod r_MIsMatch_String_Int32;
		public virtual RMethod RMIsMatch_String_Int32
		{
			get
			{
				if(r_MIsMatch_String_Int32 == null)
				{
					r_MIsMatch_String_Int32 = new(this, "IsMatch", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MIsMatch_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, System.String)
		/// </summary>
		protected static RMethod r_MMatch_String_String;
		public static RMethod RMMatch_String_String
		{
			get
			{
				if(r_MMatch_String_String == null)
				{
					r_MMatch_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Match", 0, typeof(System.String), typeof(System.String));
				}
				return r_MMatch_String_String;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MMatch_String_String_RegexOptions;
		public static RMethod RMMatch_String_String_RegexOptions
		{
			get
			{
				if(r_MMatch_String_String_RegexOptions == null)
				{
					r_MMatch_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Match", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MMatch_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MMatch_String_String_RegexOptions_TimeSpan;
		public static RMethod RMMatch_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_MMatch_String_String_RegexOptions_TimeSpan == null)
				{
					r_MMatch_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Match", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
				}
				return r_MMatch_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String)
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
		/// System.Text.RegularExpressions.Match Match(System.String, Int32)
		/// </summary>
		protected RMethod r_MMatch_String_Int32;
		public virtual RMethod RMMatch_String_Int32
		{
			get
			{
				if(r_MMatch_String_Int32 == null)
				{
					r_MMatch_String_Int32 = new(this, "Match", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MMatch_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MMatch_String_Int32_Int32;
		public virtual RMethod RMMatch_String_Int32_Int32
		{
			get
			{
				if(r_MMatch_String_Int32_Int32 == null)
				{
					r_MMatch_String_Int32_Int32 = new(this, "Match", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MMatch_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, System.String)
		/// </summary>
		protected static RMethod r_MMatches_String_String;
		public static RMethod RMMatches_String_String
		{
			get
			{
				if(r_MMatches_String_String == null)
				{
					r_MMatches_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Matches", 0, typeof(System.String), typeof(System.String));
				}
				return r_MMatches_String_String;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MMatches_String_String_RegexOptions;
		public static RMethod RMMatches_String_String_RegexOptions
		{
			get
			{
				if(r_MMatches_String_String_RegexOptions == null)
				{
					r_MMatches_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Matches", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MMatches_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MMatches_String_String_RegexOptions_TimeSpan;
		public static RMethod RMMatches_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_MMatches_String_String_RegexOptions_TimeSpan == null)
				{
					r_MMatches_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Matches", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
				}
				return r_MMatches_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String)
		/// </summary>
		protected RMethod r_MMatches_String;
		public virtual RMethod RMMatches_String
		{
			get
			{
				if(r_MMatches_String == null)
				{
					r_MMatches_String = new(this, "Matches", 0, typeof(System.String));
				}
				return r_MMatches_String;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, Int32)
		/// </summary>
		protected RMethod r_MMatches_String_Int32;
		public virtual RMethod RMMatches_String_Int32
		{
			get
			{
				if(r_MMatches_String_Int32 == null)
				{
					r_MMatches_String_Int32 = new(this, "Matches", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MMatches_String_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_MReplace_String_String_String;
		public static RMethod RMReplace_String_String_String
		{
			get
			{
				if(r_MReplace_String_String_String == null)
				{
					r_MReplace_String_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.String));
				}
				return r_MReplace_String_String_String;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MReplace_String_String_String_RegexOptions;
		public static RMethod RMReplace_String_String_String_RegexOptions
		{
			get
			{
				if(r_MReplace_String_String_String_RegexOptions == null)
				{
					r_MReplace_String_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MReplace_String_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MReplace_String_String_String_RegexOptions_TimeSpan;
		public static RMethod RMReplace_String_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_MReplace_String_String_String_RegexOptions_TimeSpan == null)
				{
					r_MReplace_String_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
				}
				return r_MReplace_String_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_MReplace_String_String;
		public virtual RMethod RMReplace_String_String
		{
			get
			{
				if(r_MReplace_String_String == null)
				{
					r_MReplace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
				}
				return r_MReplace_String_String;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_MReplace_String_String_Int32;
		public virtual RMethod RMReplace_String_String_Int32
		{
			get
			{
				if(r_MReplace_String_String_Int32 == null)
				{
					r_MReplace_String_String_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
				}
				return r_MReplace_String_String_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MReplace_String_String_Int32_Int32;
		public virtual RMethod RMReplace_String_String_Int32_Int32
		{
			get
			{
				if(r_MReplace_String_String_Int32_Int32 == null)
				{
					r_MReplace_String_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReplace_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.Text.RegularExpressions.MatchEvaluator)
		/// </summary>
		protected static RMethod r_MReplace_String_String_MatchEvaluator;
		public static RMethod RMReplace_String_String_MatchEvaluator
		{
			get
			{
				if(r_MReplace_String_String_MatchEvaluator == null)
				{
					r_MReplace_String_String_MatchEvaluator = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator));
				}
				return r_MReplace_String_String_MatchEvaluator;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.Text.RegularExpressions.MatchEvaluator, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MReplace_String_String_MatchEvaluator_RegexOptions;
		public static RMethod RMReplace_String_String_MatchEvaluator_RegexOptions
		{
			get
			{
				if(r_MReplace_String_String_MatchEvaluator_RegexOptions == null)
				{
					r_MReplace_String_String_MatchEvaluator_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MReplace_String_String_MatchEvaluator_RegexOptions;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.Text.RegularExpressions.MatchEvaluator, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan;
		public static RMethod RMReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan
		{
			get
			{
				if(r_MReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan == null)
				{
					r_MReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
				}
				return r_MReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.Text.RegularExpressions.MatchEvaluator)
		/// </summary>
		protected RMethod r_MReplace_String_MatchEvaluator;
		public virtual RMethod RMReplace_String_MatchEvaluator
		{
			get
			{
				if(r_MReplace_String_MatchEvaluator == null)
				{
					r_MReplace_String_MatchEvaluator = new(this, "Replace", 0, typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator));
				}
				return r_MReplace_String_MatchEvaluator;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.Text.RegularExpressions.MatchEvaluator, Int32)
		/// </summary>
		protected RMethod r_MReplace_String_MatchEvaluator_Int32;
		public virtual RMethod RMReplace_String_MatchEvaluator_Int32
		{
			get
			{
				if(r_MReplace_String_MatchEvaluator_Int32 == null)
				{
					r_MReplace_String_MatchEvaluator_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Int32));
				}
				return r_MReplace_String_MatchEvaluator_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.Text.RegularExpressions.MatchEvaluator, Int32, Int32)
		/// </summary>
		protected RMethod r_MReplace_String_MatchEvaluator_Int32_Int32;
		public virtual RMethod RMReplace_String_MatchEvaluator_Int32_Int32
		{
			get
			{
				if(r_MReplace_String_MatchEvaluator_Int32_Int32 == null)
				{
					r_MReplace_String_MatchEvaluator_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReplace_String_MatchEvaluator_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.Text.RegularExpressions.MatchEvaluator, System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MReplace_MatchEvaluator_Regex_String_Int32_Int32;
		public static RMethod RMReplace_MatchEvaluator_Regex_String_Int32_Int32
		{
			get
			{
				if(r_MReplace_MatchEvaluator_Regex_String_Int32_Int32 == null)
				{
					r_MReplace_MatchEvaluator_Regex_String_Int32_Int32 = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReplace_MatchEvaluator_Regex_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.String)
		/// </summary>
		protected static RMethod r_MSplit_String_String;
		public static RMethod RMSplit_String_String
		{
			get
			{
				if(r_MSplit_String_String == null)
				{
					r_MSplit_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.String), typeof(System.String));
				}
				return r_MSplit_String_String;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_MSplit_String_String_RegexOptions;
		public static RMethod RMSplit_String_String_RegexOptions
		{
			get
			{
				if(r_MSplit_String_String_RegexOptions == null)
				{
					r_MSplit_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MSplit_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_MSplit_String_String_RegexOptions_TimeSpan;
		public static RMethod RMSplit_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_MSplit_String_String_RegexOptions_TimeSpan == null)
				{
					r_MSplit_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
				}
				return r_MSplit_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String)
		/// </summary>
		protected RMethod r_MSplit_String;
		public virtual RMethod RMSplit_String
		{
			get
			{
				if(r_MSplit_String == null)
				{
					r_MSplit_String = new(this, "Split", 0, typeof(System.String));
				}
				return r_MSplit_String;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, Int32)
		/// </summary>
		protected RMethod r_MSplit_String_Int32;
		public virtual RMethod RMSplit_String_Int32
		{
			get
			{
				if(r_MSplit_String_Int32 == null)
				{
					r_MSplit_String_Int32 = new(this, "Split", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MSplit_String_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MSplit_String_Int32_Int32;
		public virtual RMethod RMSplit_String_Int32_Int32
		{
			get
			{
				if(r_MSplit_String_Int32_Int32 == null)
				{
					r_MSplit_String_Int32_Int32 = new(this, "Split", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSplit_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MSplit_Regex_String_Int32_Int32;
		public static RMethod RMSplit_Regex_String_Int32_Int32
		{
			get
			{
				if(r_MSplit_Regex_String_Int32_Int32 == null)
				{
					r_MSplit_Regex_String_Int32_Int32 = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSplit_Regex_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ValidateMatchTimeout(System.TimeSpan)
		/// </summary>
		protected static RMethod r_MValidateMatchTimeout_TimeSpan;
		public static RMethod RMValidateMatchTimeout_TimeSpan
		{
			get
			{
				if(r_MValidateMatchTimeout_TimeSpan == null)
				{
					r_MValidateMatchTimeout_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "ValidateMatchTimeout", 0, typeof(System.TimeSpan));
				}
				return r_MValidateMatchTimeout_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan InitDefaultMatchTimeout()
		/// </summary>
		protected static RMethod r_MInitDefaultMatchTimeout;
		public static RMethod RMInitDefaultMatchTimeout
		{
			get
			{
				if(r_MInitDefaultMatchTimeout == null)
				{
					r_MInitDefaultMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "InitDefaultMatchTimeout", 0);
				}
				return r_MInitDefaultMatchTimeout;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunnerFactory Compile(System.Text.RegularExpressions.RegexCode, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected RMethod r_MCompile_RegexCode_RegexOptions;
		public virtual RMethod RMCompile_RegexCode_RegexOptions
		{
			get
			{
				if(r_MCompile_RegexCode_RegexOptions == null)
				{
					r_MCompile_RegexCode_RegexOptions = new(this, "Compile", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.RegexCode"), typeof(System.Text.RegularExpressions.RegexOptions));
				}
				return r_MCompile_RegexCode_RegexOptions;
			}
		}

		/// <summary>
		/// Void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[], System.Reflection.AssemblyName)
		/// </summary>
		protected static RMethod r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName;
		public static RMethod RMCompileToAssembly_RegexCompilationInfoArray_AssemblyName
		{
			get
			{
				if(r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName == null)
				{
					r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName = new(typeof(System.Text.RegularExpressions.Regex), "CompileToAssembly", 0, typeof(System.Text.RegularExpressions.RegexCompilationInfo).MakeArrayType(), typeof(System.Reflection.AssemblyName));
				}
				return r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName;
			}
		}

		/// <summary>
		/// Void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[], System.Reflection.AssemblyName, System.Reflection.Emit.CustomAttributeBuilder[])
		/// </summary>
		protected static RMethod r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray;
		public static RMethod RMCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray
		{
			get
			{
				if(r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray == null)
				{
					r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray = new(typeof(System.Text.RegularExpressions.Regex), "CompileToAssembly", 0, typeof(System.Text.RegularExpressions.RegexCompilationInfo).MakeArrayType(), typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.CustomAttributeBuilder).MakeArrayType());
				}
				return r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray;
			}
		}

		/// <summary>
		/// Void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[], System.Reflection.AssemblyName, System.Reflection.Emit.CustomAttributeBuilder[], System.String)
		/// </summary>
		protected static RMethod r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String;
		public static RMethod RMCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String
		{
			get
			{
				if(r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String == null)
				{
					r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String = new(typeof(System.Text.RegularExpressions.Regex), "CompileToAssembly", 0, typeof(System.Text.RegularExpressions.RegexCompilationInfo).MakeArrayType(), typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.CustomAttributeBuilder).MakeArrayType(), typeof(System.String));
				}
				return r_MCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String;
			}
		}

		/// <summary>
		/// System.String Escape(System.String)
		/// </summary>
		protected static RMethod r_MEscape_String;
		public static RMethod RMEscape_String
		{
			get
			{
				if(r_MEscape_String == null)
				{
					r_MEscape_String = new(typeof(System.Text.RegularExpressions.Regex), "Escape", 0, typeof(System.String));
				}
				return r_MEscape_String;
			}
		}

		/// <summary>
		/// System.String Unescape(System.String)
		/// </summary>
		protected static RMethod r_MUnescape_String;
		public static RMethod RMUnescape_String
		{
			get
			{
				if(r_MUnescape_String == null)
				{
					r_MUnescape_String = new(typeof(System.Text.RegularExpressions.Regex), "Unescape", 0, typeof(System.String));
				}
				return r_MUnescape_String;
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
		/// System.String[] GetGroupNames()
		/// </summary>
		protected RMethod r_MGetGroupNames;
		public virtual RMethod RMGetGroupNames
		{
			get
			{
				if(r_MGetGroupNames == null)
				{
					r_MGetGroupNames = new(this, "GetGroupNames", 0);
				}
				return r_MGetGroupNames;
			}
		}

		/// <summary>
		/// Int32[] GetGroupNumbers()
		/// </summary>
		protected RMethod r_MGetGroupNumbers;
		public virtual RMethod RMGetGroupNumbers
		{
			get
			{
				if(r_MGetGroupNumbers == null)
				{
					r_MGetGroupNumbers = new(this, "GetGroupNumbers", 0);
				}
				return r_MGetGroupNumbers;
			}
		}

		/// <summary>
		/// System.String GroupNameFromNumber(Int32)
		/// </summary>
		protected RMethod r_MGroupNameFromNumber_Int32;
		public virtual RMethod RMGroupNameFromNumber_Int32
		{
			get
			{
				if(r_MGroupNameFromNumber_Int32 == null)
				{
					r_MGroupNameFromNumber_Int32 = new(this, "GroupNameFromNumber", 0, typeof(System.Int32));
				}
				return r_MGroupNameFromNumber_Int32;
			}
		}

		/// <summary>
		/// Int32 GroupNumberFromName(System.String)
		/// </summary>
		protected RMethod r_MGroupNumberFromName_String;
		public virtual RMethod RMGroupNumberFromName_String
		{
			get
			{
				if(r_MGroupNumberFromName_String == null)
				{
					r_MGroupNumberFromName_String = new(this, "GroupNumberFromName", 0, typeof(System.String));
				}
				return r_MGroupNumberFromName_String;
			}
		}

		/// <summary>
		/// Void InitializeReferences()
		/// </summary>
		protected RMethod r_MInitializeReferences;
		public virtual RMethod RMInitializeReferences
		{
			get
			{
				if(r_MInitializeReferences == null)
				{
					r_MInitializeReferences = new(this, "InitializeReferences", 0);
				}
				return r_MInitializeReferences;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Run(Boolean, Int32, System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MRun_Boolean_Int32_String_Int32_Int32_Int32;
		public virtual RMethod RMRun_Boolean_Int32_String_Int32_Int32_Int32
		{
			get
			{
				if(r_MRun_Boolean_Int32_String_Int32_Int32_Int32 == null)
				{
					r_MRun_Boolean_Int32_String_Int32_Int32_Int32 = new(this, "Run", 0, typeof(System.Boolean), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MRun_Boolean_Int32_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean UseOptionC()
		/// </summary>
		protected RMethod r_MUseOptionC;
		public virtual RMethod RMUseOptionC
		{
			get
			{
				if(r_MUseOptionC == null)
				{
					r_MUseOptionC = new(this, "UseOptionC", 0);
				}
				return r_MUseOptionC;
			}
		}

		/// <summary>
		/// Boolean UseOptionR()
		/// </summary>
		protected RMethod r_MUseOptionR;
		public virtual RMethod RMUseOptionR
		{
			get
			{
				if(r_MUseOptionR == null)
				{
					r_MUseOptionR = new(this, "UseOptionR", 0);
				}
				return r_MUseOptionR;
			}
		}

		/// <summary>
		/// Boolean UseOptionInvariant()
		/// </summary>
		protected RMethod r_MUseOptionInvariant;
		public virtual RMethod RMUseOptionInvariant
		{
			get
			{
				if(r_MUseOptionInvariant == null)
				{
					r_MUseOptionInvariant = new(this, "UseOptionInvariant", 0);
				}
				return r_MUseOptionInvariant;
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


        public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry GetCachedCode(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @key, System.Boolean @isToAdd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key.Value, @isToAdd};
            var ___result = RMGetCachedCode_CachedCodeEntryKey_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry GetCachedCodeEntryInternal(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @key, System.Boolean @isToAdd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key.Value, @isToAdd};
            var ___result = RMGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry(___result);
        }


        public virtual void FillCacheDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFillCacheDictionary.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean TryGetCacheValue(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @key, out Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry @entry)
        {
			@entry = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key.Value, @entry.Value};
            var ___result = RMTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry.Invoke(___genericsType, ___parameters);
			@entry = new Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static System.Boolean TryGetCacheValueSmall(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @key, out Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry @entry)
        {
			@entry = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key.Value, @entry.Value};
            var ___result = RMTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry.Invoke(___genericsType, ___parameters);
			@entry = new Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry(___parameters[1]);

            return (System.Boolean)___result;
        }


        public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry LookupCachedAndPromote(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key.Value};
            var ___result = RMLookupCachedAndPromote_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry(___result);
        }


        public static System.Boolean IsMatch(System.String @input, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RMIsMatch_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsMatch(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RMIsMatch_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsMatch(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options, System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RMIsMatch_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMatch(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMIsMatch_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMatch(System.String @input, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @startat};
            var ___result = RMIsMatch_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Text.RegularExpressions.Match Match(System.String @input, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RMMatch_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public static System.Text.RegularExpressions.Match Match(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RMMatch_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public static System.Text.RegularExpressions.Match Match(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options, System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RMMatch_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Match(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMMatch_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Match(System.String @input, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @startat};
            var ___result = RMMatch_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Match(System.String @input, System.Int32 @beginning, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @beginning, @length};
            var ___result = RMMatch_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public static System.Text.RegularExpressions.MatchCollection Matches(System.String @input, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RMMatches_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public static System.Text.RegularExpressions.MatchCollection Matches(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RMMatches_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public static System.Text.RegularExpressions.MatchCollection Matches(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options, System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RMMatches_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public virtual System.Text.RegularExpressions.MatchCollection Matches(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMMatches_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public virtual System.Text.RegularExpressions.MatchCollection Matches(System.String @input, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @startat};
            var ___result = RMMatches_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public static System.String Replace(System.String @input, System.String @pattern, System.String @replacement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @replacement};
            var ___result = RMReplace_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String @input, System.String @pattern, System.String @replacement, System.Text.RegularExpressions.RegexOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @replacement, @options};
            var ___result = RMReplace_String_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String @input, System.String @pattern, System.String @replacement, System.Text.RegularExpressions.RegexOptions @options, System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @replacement, @options, @matchTimeout};
            var ___result = RMReplace_String_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @input, System.String @replacement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @replacement};
            var ___result = RMReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @input, System.String @replacement, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @replacement, @count};
            var ___result = RMReplace_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @input, System.String @replacement, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @replacement, @count, @startat};
            var ___result = RMReplace_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String @input, System.String @pattern, System.Text.RegularExpressions.MatchEvaluator @evaluator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @evaluator};
            var ___result = RMReplace_String_String_MatchEvaluator.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String @input, System.String @pattern, System.Text.RegularExpressions.MatchEvaluator @evaluator, System.Text.RegularExpressions.RegexOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @evaluator, @options};
            var ___result = RMReplace_String_String_MatchEvaluator_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String @input, System.String @pattern, System.Text.RegularExpressions.MatchEvaluator @evaluator, System.Text.RegularExpressions.RegexOptions @options, System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @evaluator, @options, @matchTimeout};
            var ___result = RMReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @input, System.Text.RegularExpressions.MatchEvaluator @evaluator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @evaluator};
            var ___result = RMReplace_String_MatchEvaluator.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @input, System.Text.RegularExpressions.MatchEvaluator @evaluator, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @evaluator, @count};
            var ___result = RMReplace_String_MatchEvaluator_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String @input, System.Text.RegularExpressions.MatchEvaluator @evaluator, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @evaluator, @count, @startat};
            var ___result = RMReplace_String_MatchEvaluator_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.Text.RegularExpressions.MatchEvaluator @evaluator, System.Text.RegularExpressions.Regex @regex, System.String @input, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evaluator, @regex, @input, @count, @startat};
            var ___result = RMReplace_MatchEvaluator_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] Split(System.String @input, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RMSplit_String_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] Split(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RMSplit_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] Split(System.String @input, System.String @pattern, System.Text.RegularExpressions.RegexOptions @options, System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RMSplit_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMSplit_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @input, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @count};
            var ___result = RMSplit_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String @input, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @count, @startat};
            var ___result = RMSplit_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] Split(System.Text.RegularExpressions.Regex @regex, System.String @input, System.Int32 @count, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @input, @count, @startat};
            var ___result = RMSplit_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static void ValidateMatchTimeout(System.TimeSpan @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matchTimeout};
            var ___result = RMValidateMatchTimeout_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public static System.TimeSpan InitDefaultMatchTimeout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitDefaultMatchTimeout.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @si, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@si, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.RegexRunnerFactory Compile(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexCode @code, System.Text.RegularExpressions.RegexOptions @roptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code.Value, @roptions};
            var ___result = RMCompile_RegexCode_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.RegexRunnerFactory)___result;
        }


        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] @regexinfos, System.Reflection.AssemblyName @assemblyname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regexinfos, @assemblyname};
            var ___result = RMCompileToAssembly_RegexCompilationInfoArray_AssemblyName.Invoke(___genericsType, ___parameters);

            
        }


        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] @regexinfos, System.Reflection.AssemblyName @assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regexinfos, @assemblyname, @attributes};
            var ___result = RMCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] @regexinfos, System.Reflection.AssemblyName @assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] @attributes, System.String @resourceFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regexinfos, @assemblyname, @attributes, @resourceFile};
            var ___result = RMCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String Escape(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMEscape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Unescape(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMUnescape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] GetGroupNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGroupNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Int32[] GetGroupNumbers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGroupNumbers.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.String GroupNameFromNumber(System.Int32 @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMGroupNameFromNumber_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GroupNumberFromName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGroupNumberFromName_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitializeReferences()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeReferences.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.Match Run(System.Boolean @quick, System.Int32 @prevlen, System.String @input, System.Int32 @beginning, System.Int32 @length, System.Int32 @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@quick, @prevlen, @input, @beginning, @length, @startat};
            var ___result = RMRun_Boolean_Int32_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Boolean UseOptionC()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUseOptionC.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UseOptionR()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUseOptionR.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UseOptionInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUseOptionInvariant.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


    }
}
