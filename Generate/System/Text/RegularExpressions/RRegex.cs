using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
	/// System.Text.RegularExpressions.Regex
	/// </summary>
    public partial class RRegex : RMember //
    {

		/// <summary>
		/// System.Int32 CacheDictionarySwitchLimit
		/// </summary>
		protected static RField r_CacheDictionarySwitchLimit;
		public static RField RCacheDictionarySwitchLimit
		{
			get
			{
				if(r_CacheDictionarySwitchLimit == null)
				{
					r_CacheDictionarySwitchLimit = new(typeof(System.Text.RegularExpressions.Regex), "CacheDictionarySwitchLimit");
					r_CacheDictionarySwitchLimit.SetBelong(null);
				}
				return r_CacheDictionarySwitchLimit;
			}
		}

		/// <summary>
		/// System.Int32 s_cacheSize
		/// </summary>
		protected static RField r_s_cacheSize;
		public static RField Rs_cacheSize
		{
			get
			{
				if(r_s_cacheSize == null)
				{
					r_s_cacheSize = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheSize");
					r_s_cacheSize.SetBelong(null);
				}
				return r_s_cacheSize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Text.RegularExpressions.Regex+CachedCodeEntryKey,System.Text.RegularExpressions.Regex+CachedCodeEntry] s_cache
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey, RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry> r_s_cache;
		public static RSystem.RCollections.RGeneric.RDictionary<RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey, RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry> Rs_cache
		{
			get
			{
				if(r_s_cache == null)
				{
					r_s_cache = new(typeof(System.Text.RegularExpressions.Regex), "s_cache");
					r_s_cache.SetBelong(null);
				}
				return r_s_cache;
			}
		}

		/// <summary>
		/// System.Int32 s_cacheCount
		/// </summary>
		protected static RField r_s_cacheCount;
		public static RField Rs_cacheCount
		{
			get
			{
				if(r_s_cacheCount == null)
				{
					r_s_cacheCount = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheCount");
					r_s_cacheCount.SetBelong(null);
				}
				return r_s_cacheCount;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry s_cacheFirst
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_s_cacheFirst;
		public static RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry Rs_cacheFirst
		{
			get
			{
				if(r_s_cacheFirst == null)
				{
					r_s_cacheFirst = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheFirst");
					r_s_cacheFirst.SetBelong(null);
				}
				return r_s_cacheFirst;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Regex+CachedCodeEntry s_cacheLast
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry r_s_cacheLast;
		public static RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntry Rs_cacheLast
		{
			get
			{
				if(r_s_cacheLast == null)
				{
					r_s_cacheLast = new(typeof(System.Text.RegularExpressions.Regex), "s_cacheLast");
					r_s_cacheLast.SetBelong(null);
				}
				return r_s_cacheLast;
			}
		}

		/// <summary>
		/// System.TimeSpan s_maximumMatchTimeout
		/// </summary>
		protected static RSystem.RTimeSpan r_s_maximumMatchTimeout;
		public static RSystem.RTimeSpan Rs_maximumMatchTimeout
		{
			get
			{
				if(r_s_maximumMatchTimeout == null)
				{
					r_s_maximumMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "s_maximumMatchTimeout");
					r_s_maximumMatchTimeout.SetBelong(null);
				}
				return r_s_maximumMatchTimeout;
			}
		}

		/// <summary>
		/// System.String DefaultMatchTimeout_ConfigKeyName
		/// </summary>
		protected static RField r_DefaultMatchTimeout_ConfigKeyName;
		public static RField RDefaultMatchTimeout_ConfigKeyName
		{
			get
			{
				if(r_DefaultMatchTimeout_ConfigKeyName == null)
				{
					r_DefaultMatchTimeout_ConfigKeyName = new(typeof(System.Text.RegularExpressions.Regex), "DefaultMatchTimeout_ConfigKeyName");
					r_DefaultMatchTimeout_ConfigKeyName.SetBelong(null);
				}
				return r_DefaultMatchTimeout_ConfigKeyName;
			}
		}

		/// <summary>
		/// System.TimeSpan s_defaultMatchTimeout
		/// </summary>
		protected static RSystem.RTimeSpan r_s_defaultMatchTimeout;
		public static RSystem.RTimeSpan Rs_defaultMatchTimeout
		{
			get
			{
				if(r_s_defaultMatchTimeout == null)
				{
					r_s_defaultMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "s_defaultMatchTimeout");
					r_s_defaultMatchTimeout.SetBelong(null);
				}
				return r_s_defaultMatchTimeout;
			}
		}

		/// <summary>
		/// System.TimeSpan InfiniteMatchTimeout
		/// </summary>
		protected static RSystem.RTimeSpan r_InfiniteMatchTimeout;
		public static RSystem.RTimeSpan RInfiniteMatchTimeout
		{
			get
			{
				if(r_InfiniteMatchTimeout == null)
				{
					r_InfiniteMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "InfiniteMatchTimeout");
					r_InfiniteMatchTimeout.SetBelong(null);
				}
				return r_InfiniteMatchTimeout;
			}
		}

		/// <summary>
		/// System.TimeSpan internalMatchTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_internalMatchTimeout;
		public virtual RSystem.RTimeSpan RinternalMatchTimeout
		{
			get
			{
				if(r_internalMatchTimeout == null)
				{
					r_internalMatchTimeout = new(this, "internalMatchTimeout");
					r_internalMatchTimeout.SetBelong(this.instance);
				}
				return r_internalMatchTimeout;
			}
		}

		/// <summary>
		/// System.Int32 MaxOptionShift
		/// </summary>
		protected static RField r_MaxOptionShift;
		public static RField RMaxOptionShift
		{
			get
			{
				if(r_MaxOptionShift == null)
				{
					r_MaxOptionShift = new(typeof(System.Text.RegularExpressions.Regex), "MaxOptionShift");
					r_MaxOptionShift.SetBelong(null);
				}
				return r_MaxOptionShift;
			}
		}

		/// <summary>
		/// System.String pattern
		/// </summary>
		protected RField r_pattern;
		public virtual RField Rpattern
		{
			get
			{
				if(r_pattern == null)
				{
					r_pattern = new(this, "pattern");
					r_pattern.SetBelong(this.instance);
				}
				return r_pattern;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions roptions
		/// </summary>
		protected RField r_roptions;
		public virtual RField Rroptions
		{
			get
			{
				if(r_roptions == null)
				{
					r_roptions = new(this, "roptions");
					r_roptions.SetBelong(this.instance);
				}
				return r_roptions;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunnerFactory factory
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexRunnerFactory r_factory;
		public virtual RSystem.RText.RRegularExpressions.RRegexRunnerFactory Rfactory
		{
			get
			{
				if(r_factory == null)
				{
					r_factory = new(this, "factory");
					r_factory.SetBelong(this.instance);
				}
				return r_factory;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable caps
		/// </summary>
		protected RSystem.RCollections.RHashtable r_caps;
		public virtual RSystem.RCollections.RHashtable Rcaps
		{
			get
			{
				if(r_caps == null)
				{
					r_caps = new(this, "caps");
					r_caps.SetBelong(this.instance);
				}
				return r_caps;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable capnames
		/// </summary>
		protected RSystem.RCollections.RHashtable r_capnames;
		public virtual RSystem.RCollections.RHashtable Rcapnames
		{
			get
			{
				if(r_capnames == null)
				{
					r_capnames = new(this, "capnames");
					r_capnames.SetBelong(this.instance);
				}
				return r_capnames;
			}
		}

		/// <summary>
		/// System.String[] capslist
		/// </summary>
		protected RFieldArray<RField> r_capslist;
		public virtual RFieldArray<RField> Rcapslist
		{
			get
			{
				if(r_capslist == null)
				{
					r_capslist = new(this, "capslist");
					r_capslist.SetBelong(this.instance);
				}
				return r_capslist;
			}
		}

		/// <summary>
		/// System.Int32 capsize
		/// </summary>
		protected RField r_capsize;
		public virtual RField Rcapsize
		{
			get
			{
				if(r_capsize == null)
				{
					r_capsize = new(this, "capsize");
					r_capsize.SetBelong(this.instance);
				}
				return r_capsize;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.ExclusiveReference _runnerref
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RExclusiveReference r__runnerref;
		public virtual RSystem.RText.RRegularExpressions.RExclusiveReference R_runnerref
		{
			get
			{
				if(r__runnerref == null)
				{
					r__runnerref = new(this, "_runnerref");
					r__runnerref.SetBelong(this.instance);
				}
				return r__runnerref;
			}
		}

		/// <summary>
		/// System.WeakReference`1[System.Text.RegularExpressions.RegexReplacement] _replref
		/// </summary>
		protected RSystem.RWeakReference<RSystem.RText.RRegularExpressions.RRegexReplacement> r__replref;
		public virtual RSystem.RWeakReference<RSystem.RText.RRegularExpressions.RRegexReplacement> R_replref
		{
			get
			{
				if(r__replref == null)
				{
					r__replref = new(this, "_replref");
					r__replref.SetBelong(this.instance);
				}
				return r__replref;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexCode _code
		/// </summary>
		protected RSystem.RText.RRegularExpressions.RRegexCode r__code;
		public virtual RSystem.RText.RRegularExpressions.RRegexCode R_code
		{
			get
			{
				if(r__code == null)
				{
					r__code = new(this, "_code");
					r__code.SetBelong(this.instance);
				}
				return r__code;
			}
		}

		/// <summary>
		/// System.Boolean _refsInitialized
		/// </summary>
		protected RField r__refsInitialized;
		public virtual RField R_refsInitialized
		{
			get
			{
				if(r__refsInitialized == null)
				{
					r__refsInitialized = new(this, "_refsInitialized");
					r__refsInitialized.SetBelong(this.instance);
				}
				return r__refsInitialized;
			}
		}

		/// <summary>
		/// Int32 CacheSize
		/// </summary>
		protected static RProperty r_CacheSize;
		public static RProperty RCacheSize
		{
			get
			{
				if(r_CacheSize == null)
				{
					r_CacheSize = new(typeof(System.Text.RegularExpressions.Regex), "CacheSize", -1);
					r_CacheSize.SetBelong(null);
				}
				return r_CacheSize;
			}
		}

		/// <summary>
		/// System.TimeSpan MatchTimeout
		/// </summary>
		protected RSystem.RTimeSpan r_MatchTimeout;
		public virtual RSystem.RTimeSpan RMatchTimeout
		{
			get
			{
				if(r_MatchTimeout == null)
				{
					r_MatchTimeout = new(this, "MatchTimeout", -1);
					r_MatchTimeout.SetBelong(this.instance);
				}
				return r_MatchTimeout;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary Caps
		/// </summary>
		protected RSystem.RCollections.RIDictionary r_Caps;
		public virtual RSystem.RCollections.RIDictionary RCaps
		{
			get
			{
				if(r_Caps == null)
				{
					r_Caps = new(this, "Caps", -1);
					r_Caps.SetBelong(this.instance);
				}
				return r_Caps;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary CapNames
		/// </summary>
		protected RSystem.RCollections.RIDictionary r_CapNames;
		public virtual RSystem.RCollections.RIDictionary RCapNames
		{
			get
			{
				if(r_CapNames == null)
				{
					r_CapNames = new(this, "CapNames", -1);
					r_CapNames.SetBelong(this.instance);
				}
				return r_CapNames;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions Options
		/// </summary>
		protected RProperty r_Options;
		public virtual RProperty ROptions
		{
			get
			{
				if(r_Options == null)
				{
					r_Options = new(this, "Options", -1);
					r_Options.SetBelong(this.instance);
				}
				return r_Options;
			}
		}

		/// <summary>
		/// Boolean RightToLeft
		/// </summary>
		protected RProperty r_RightToLeft;
		public virtual RProperty RightToLeft
		{
			get
			{
				if(r_RightToLeft == null)
				{
					r_RightToLeft = new(this, "RightToLeft", -1);
					r_RightToLeft.SetBelong(this.instance);
				}
				return r_RightToLeft;
			}
		}

		/// <summary>
		/// CachedCodeEntry GetCachedCode(CachedCodeEntryKey, Boolean)
		/// </summary>
		protected RMethod r_RGetCachedCode_CachedCodeEntryKey_Boolean;
		public virtual RMethod RGetCachedCode_CachedCodeEntryKey_Boolean
		{
			get
			{
				if(r_RGetCachedCode_CachedCodeEntryKey_Boolean == null)
				{
					r_RGetCachedCode_CachedCodeEntryKey_Boolean = new(this, "GetCachedCode", 0,  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"), typeof(System.Boolean));
					r_RGetCachedCode_CachedCodeEntryKey_Boolean.SetBelong(this.instance);
				}
				return r_RGetCachedCode_CachedCodeEntryKey_Boolean;
			}
		}

		/// <summary>
		/// CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey, Boolean)
		/// </summary>
		protected RMethod r_RGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean;
		public virtual RMethod RGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean
		{
			get
			{
				if(r_RGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean == null)
				{
					r_RGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean = new(this, "GetCachedCodeEntryInternal", 0,  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"), typeof(System.Boolean));
					r_RGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean.SetBelong(this.instance);
				}
				return r_RGetCachedCodeEntryInternal_CachedCodeEntryKey_Boolean;
			}
		}

		/// <summary>
		/// Void FillCacheDictionary()
		/// </summary>
		protected RMethod r_RFillCacheDictionary;
		public virtual RMethod RFillCacheDictionary
		{
			get
			{
				if(r_RFillCacheDictionary == null)
				{
					r_RFillCacheDictionary = new(this, "FillCacheDictionary", 0);
					r_RFillCacheDictionary.SetBelong(this.instance);
				}
				return r_RFillCacheDictionary;
			}
		}

		/// <summary>
		/// Boolean TryGetCacheValue(CachedCodeEntryKey, CachedCodeEntry ByRef)
		/// </summary>
		protected static RMethod r_RTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry;
		public static RMethod RTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry
		{
			get
			{
				if(r_RTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry == null)
				{
					r_RTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry = new(typeof(System.Text.RegularExpressions.Regex), "TryGetCacheValue", 0,  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntry").MakeByRefType());
					r_RTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry.SetBelong(null);
				}
				return r_RTryGetCacheValue_CachedCodeEntryKey_Out_CachedCodeEntry;
			}
		}

		/// <summary>
		/// Boolean TryGetCacheValueSmall(CachedCodeEntryKey, CachedCodeEntry ByRef)
		/// </summary>
		protected static RMethod r_RTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry;
		public static RMethod RTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry
		{
			get
			{
				if(r_RTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry == null)
				{
					r_RTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry = new(typeof(System.Text.RegularExpressions.Regex), "TryGetCacheValueSmall", 0,  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntry").MakeByRefType());
					r_RTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry.SetBelong(null);
				}
				return r_RTryGetCacheValueSmall_CachedCodeEntryKey_Out_CachedCodeEntry;
			}
		}

		/// <summary>
		/// CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey)
		/// </summary>
		protected static RMethod r_RLookupCachedAndPromote_CachedCodeEntryKey;
		public static RMethod RLookupCachedAndPromote_CachedCodeEntryKey
		{
			get
			{
				if(r_RLookupCachedAndPromote_CachedCodeEntryKey == null)
				{
					r_RLookupCachedAndPromote_CachedCodeEntryKey = new(typeof(System.Text.RegularExpressions.Regex), "LookupCachedAndPromote", 0,  ReleactionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
					r_RLookupCachedAndPromote_CachedCodeEntryKey.SetBelong(null);
				}
				return r_RLookupCachedAndPromote_CachedCodeEntryKey;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, System.String)
		/// </summary>
		protected static RMethod r_RIsMatch_String_String;
		public static RMethod RIsMatch_String_String
		{
			get
			{
				if(r_RIsMatch_String_String == null)
				{
					r_RIsMatch_String_String = new(typeof(System.Text.RegularExpressions.Regex), "IsMatch", 0, typeof(System.String), typeof(System.String));
					r_RIsMatch_String_String.SetBelong(null);
				}
				return r_RIsMatch_String_String;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_RIsMatch_String_String_RegexOptions;
		public static RMethod RIsMatch_String_String_RegexOptions
		{
			get
			{
				if(r_RIsMatch_String_String_RegexOptions == null)
				{
					r_RIsMatch_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "IsMatch", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RIsMatch_String_String_RegexOptions.SetBelong(null);
				}
				return r_RIsMatch_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RIsMatch_String_String_RegexOptions_TimeSpan;
		public static RMethod RIsMatch_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_RIsMatch_String_String_RegexOptions_TimeSpan == null)
				{
					r_RIsMatch_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "IsMatch", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
					r_RIsMatch_String_String_RegexOptions_TimeSpan.SetBelong(null);
				}
				return r_RIsMatch_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String)
		/// </summary>
		protected RMethod r_RIsMatch_String;
		public virtual RMethod RIsMatch_String
		{
			get
			{
				if(r_RIsMatch_String == null)
				{
					r_RIsMatch_String = new(this, "IsMatch", 0, typeof(System.String));
					r_RIsMatch_String.SetBelong(this.instance);
				}
				return r_RIsMatch_String;
			}
		}

		/// <summary>
		/// Boolean IsMatch(System.String, Int32)
		/// </summary>
		protected RMethod r_RIsMatch_String_Int32;
		public virtual RMethod RIsMatch_String_Int32
		{
			get
			{
				if(r_RIsMatch_String_Int32 == null)
				{
					r_RIsMatch_String_Int32 = new(this, "IsMatch", 0, typeof(System.String), typeof(System.Int32));
					r_RIsMatch_String_Int32.SetBelong(this.instance);
				}
				return r_RIsMatch_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, System.String)
		/// </summary>
		protected static RMethod r_RMatch_String_String;
		public static RMethod RMatch_String_String
		{
			get
			{
				if(r_RMatch_String_String == null)
				{
					r_RMatch_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Match", 0, typeof(System.String), typeof(System.String));
					r_RMatch_String_String.SetBelong(null);
				}
				return r_RMatch_String_String;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_RMatch_String_String_RegexOptions;
		public static RMethod RMatch_String_String_RegexOptions
		{
			get
			{
				if(r_RMatch_String_String_RegexOptions == null)
				{
					r_RMatch_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Match", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RMatch_String_String_RegexOptions.SetBelong(null);
				}
				return r_RMatch_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RMatch_String_String_RegexOptions_TimeSpan;
		public static RMethod RMatch_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_RMatch_String_String_RegexOptions_TimeSpan == null)
				{
					r_RMatch_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Match", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
					r_RMatch_String_String_RegexOptions_TimeSpan.SetBelong(null);
				}
				return r_RMatch_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String)
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
		/// System.Text.RegularExpressions.Match Match(System.String, Int32)
		/// </summary>
		protected RMethod r_RMatch_String_Int32;
		public virtual RMethod RMatch_String_Int32
		{
			get
			{
				if(r_RMatch_String_Int32 == null)
				{
					r_RMatch_String_Int32 = new(this, "Match", 0, typeof(System.String), typeof(System.Int32));
					r_RMatch_String_Int32.SetBelong(this.instance);
				}
				return r_RMatch_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Match(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RMatch_String_Int32_Int32;
		public virtual RMethod RMatch_String_Int32_Int32
		{
			get
			{
				if(r_RMatch_String_Int32_Int32 == null)
				{
					r_RMatch_String_Int32_Int32 = new(this, "Match", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RMatch_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RMatch_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, System.String)
		/// </summary>
		protected static RMethod r_RMatches_String_String;
		public static RMethod RMatches_String_String
		{
			get
			{
				if(r_RMatches_String_String == null)
				{
					r_RMatches_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Matches", 0, typeof(System.String), typeof(System.String));
					r_RMatches_String_String.SetBelong(null);
				}
				return r_RMatches_String_String;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_RMatches_String_String_RegexOptions;
		public static RMethod RMatches_String_String_RegexOptions
		{
			get
			{
				if(r_RMatches_String_String_RegexOptions == null)
				{
					r_RMatches_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Matches", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RMatches_String_String_RegexOptions.SetBelong(null);
				}
				return r_RMatches_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RMatches_String_String_RegexOptions_TimeSpan;
		public static RMethod RMatches_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_RMatches_String_String_RegexOptions_TimeSpan == null)
				{
					r_RMatches_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Matches", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
					r_RMatches_String_String_RegexOptions_TimeSpan.SetBelong(null);
				}
				return r_RMatches_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String)
		/// </summary>
		protected RMethod r_RMatches_String;
		public virtual RMethod RMatches_String
		{
			get
			{
				if(r_RMatches_String == null)
				{
					r_RMatches_String = new(this, "Matches", 0, typeof(System.String));
					r_RMatches_String.SetBelong(this.instance);
				}
				return r_RMatches_String;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.MatchCollection Matches(System.String, Int32)
		/// </summary>
		protected RMethod r_RMatches_String_Int32;
		public virtual RMethod RMatches_String_Int32
		{
			get
			{
				if(r_RMatches_String_Int32 == null)
				{
					r_RMatches_String_Int32 = new(this, "Matches", 0, typeof(System.String), typeof(System.Int32));
					r_RMatches_String_Int32.SetBelong(this.instance);
				}
				return r_RMatches_String_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.String)
		/// </summary>
		protected static RMethod r_RReplace_String_String_String;
		public static RMethod RReplace_String_String_String
		{
			get
			{
				if(r_RReplace_String_String_String == null)
				{
					r_RReplace_String_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RReplace_String_String_String.SetBelong(null);
				}
				return r_RReplace_String_String_String;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_RReplace_String_String_String_RegexOptions;
		public static RMethod RReplace_String_String_String_RegexOptions
		{
			get
			{
				if(r_RReplace_String_String_String_RegexOptions == null)
				{
					r_RReplace_String_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RReplace_String_String_String_RegexOptions.SetBelong(null);
				}
				return r_RReplace_String_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RReplace_String_String_String_RegexOptions_TimeSpan;
		public static RMethod RReplace_String_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_RReplace_String_String_String_RegexOptions_TimeSpan == null)
				{
					r_RReplace_String_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
					r_RReplace_String_String_String_RegexOptions_TimeSpan.SetBelong(null);
				}
				return r_RReplace_String_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_RReplace_String_String;
		public virtual RMethod RReplace_String_String
		{
			get
			{
				if(r_RReplace_String_String == null)
				{
					r_RReplace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
					r_RReplace_String_String.SetBelong(this.instance);
				}
				return r_RReplace_String_String;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_RReplace_String_String_Int32;
		public virtual RMethod RReplace_String_String_Int32
		{
			get
			{
				if(r_RReplace_String_String_Int32 == null)
				{
					r_RReplace_String_String_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_RReplace_String_String_Int32.SetBelong(this.instance);
				}
				return r_RReplace_String_String_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RReplace_String_String_Int32_Int32;
		public virtual RMethod RReplace_String_String_Int32_Int32
		{
			get
			{
				if(r_RReplace_String_String_Int32_Int32 == null)
				{
					r_RReplace_String_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RReplace_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReplace_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.Text.RegularExpressions.MatchEvaluator)
		/// </summary>
		protected static RMethod r_RReplace_String_String_MatchEvaluator;
		public static RMethod RReplace_String_String_MatchEvaluator
		{
			get
			{
				if(r_RReplace_String_String_MatchEvaluator == null)
				{
					r_RReplace_String_String_MatchEvaluator = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator));
					r_RReplace_String_String_MatchEvaluator.SetBelong(null);
				}
				return r_RReplace_String_String_MatchEvaluator;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.Text.RegularExpressions.MatchEvaluator, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_RReplace_String_String_MatchEvaluator_RegexOptions;
		public static RMethod RReplace_String_String_MatchEvaluator_RegexOptions
		{
			get
			{
				if(r_RReplace_String_String_MatchEvaluator_RegexOptions == null)
				{
					r_RReplace_String_String_MatchEvaluator_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RReplace_String_String_MatchEvaluator_RegexOptions.SetBelong(null);
				}
				return r_RReplace_String_String_MatchEvaluator_RegexOptions;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.String, System.Text.RegularExpressions.MatchEvaluator, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan;
		public static RMethod RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan
		{
			get
			{
				if(r_RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan == null)
				{
					r_RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
					r_RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan.SetBelong(null);
				}
				return r_RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.Text.RegularExpressions.MatchEvaluator)
		/// </summary>
		protected RMethod r_RReplace_String_MatchEvaluator;
		public virtual RMethod RReplace_String_MatchEvaluator
		{
			get
			{
				if(r_RReplace_String_MatchEvaluator == null)
				{
					r_RReplace_String_MatchEvaluator = new(this, "Replace", 0, typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator));
					r_RReplace_String_MatchEvaluator.SetBelong(this.instance);
				}
				return r_RReplace_String_MatchEvaluator;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.Text.RegularExpressions.MatchEvaluator, Int32)
		/// </summary>
		protected RMethod r_RReplace_String_MatchEvaluator_Int32;
		public virtual RMethod RReplace_String_MatchEvaluator_Int32
		{
			get
			{
				if(r_RReplace_String_MatchEvaluator_Int32 == null)
				{
					r_RReplace_String_MatchEvaluator_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Int32));
					r_RReplace_String_MatchEvaluator_Int32.SetBelong(this.instance);
				}
				return r_RReplace_String_MatchEvaluator_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.String, System.Text.RegularExpressions.MatchEvaluator, Int32, Int32)
		/// </summary>
		protected RMethod r_RReplace_String_MatchEvaluator_Int32_Int32;
		public virtual RMethod RReplace_String_MatchEvaluator_Int32_Int32
		{
			get
			{
				if(r_RReplace_String_MatchEvaluator_Int32_Int32 == null)
				{
					r_RReplace_String_MatchEvaluator_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Int32), typeof(System.Int32));
					r_RReplace_String_MatchEvaluator_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReplace_String_MatchEvaluator_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String Replace(System.Text.RegularExpressions.MatchEvaluator, System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_RReplace_MatchEvaluator_Regex_String_Int32_Int32;
		public static RMethod RReplace_MatchEvaluator_Regex_String_Int32_Int32
		{
			get
			{
				if(r_RReplace_MatchEvaluator_Regex_String_Int32_Int32 == null)
				{
					r_RReplace_MatchEvaluator_Regex_String_Int32_Int32 = new(typeof(System.Text.RegularExpressions.Regex), "Replace", 0, typeof(System.Text.RegularExpressions.MatchEvaluator), typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RReplace_MatchEvaluator_Regex_String_Int32_Int32.SetBelong(null);
				}
				return r_RReplace_MatchEvaluator_Regex_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.String)
		/// </summary>
		protected static RMethod r_RSplit_String_String;
		public static RMethod RSplit_String_String
		{
			get
			{
				if(r_RSplit_String_String == null)
				{
					r_RSplit_String_String = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.String), typeof(System.String));
					r_RSplit_String_String.SetBelong(null);
				}
				return r_RSplit_String_String;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.String, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected static RMethod r_RSplit_String_String_RegexOptions;
		public static RMethod RSplit_String_String_RegexOptions
		{
			get
			{
				if(r_RSplit_String_String_RegexOptions == null)
				{
					r_RSplit_String_String_RegexOptions = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RSplit_String_String_RegexOptions.SetBelong(null);
				}
				return r_RSplit_String_String_RegexOptions;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan)
		/// </summary>
		protected static RMethod r_RSplit_String_String_RegexOptions_TimeSpan;
		public static RMethod RSplit_String_String_RegexOptions_TimeSpan
		{
			get
			{
				if(r_RSplit_String_String_RegexOptions_TimeSpan == null)
				{
					r_RSplit_String_String_RegexOptions_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.String), typeof(System.String), typeof(System.Text.RegularExpressions.RegexOptions), typeof(System.TimeSpan));
					r_RSplit_String_String_RegexOptions_TimeSpan.SetBelong(null);
				}
				return r_RSplit_String_String_RegexOptions_TimeSpan;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String)
		/// </summary>
		protected RMethod r_RSplit_String;
		public virtual RMethod RSplit_String
		{
			get
			{
				if(r_RSplit_String == null)
				{
					r_RSplit_String = new(this, "Split", 0, typeof(System.String));
					r_RSplit_String.SetBelong(this.instance);
				}
				return r_RSplit_String;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, Int32)
		/// </summary>
		protected RMethod r_RSplit_String_Int32;
		public virtual RMethod RSplit_String_Int32
		{
			get
			{
				if(r_RSplit_String_Int32 == null)
				{
					r_RSplit_String_Int32 = new(this, "Split", 0, typeof(System.String), typeof(System.Int32));
					r_RSplit_String_Int32.SetBelong(this.instance);
				}
				return r_RSplit_String_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RSplit_String_Int32_Int32;
		public virtual RMethod RSplit_String_Int32_Int32
		{
			get
			{
				if(r_RSplit_String_Int32_Int32 == null)
				{
					r_RSplit_String_Int32_Int32 = new(this, "Split", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RSplit_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSplit_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String[] Split(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_RSplit_Regex_String_Int32_Int32;
		public static RMethod RSplit_Regex_String_Int32_Int32
		{
			get
			{
				if(r_RSplit_Regex_String_Int32_Int32 == null)
				{
					r_RSplit_Regex_String_Int32_Int32 = new(typeof(System.Text.RegularExpressions.Regex), "Split", 0, typeof(System.Text.RegularExpressions.Regex), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RSplit_Regex_String_Int32_Int32.SetBelong(null);
				}
				return r_RSplit_Regex_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ValidateMatchTimeout(System.TimeSpan)
		/// </summary>
		protected static RMethod r_RValidateMatchTimeout_TimeSpan;
		public static RMethod RValidateMatchTimeout_TimeSpan
		{
			get
			{
				if(r_RValidateMatchTimeout_TimeSpan == null)
				{
					r_RValidateMatchTimeout_TimeSpan = new(typeof(System.Text.RegularExpressions.Regex), "ValidateMatchTimeout", 0, typeof(System.TimeSpan));
					r_RValidateMatchTimeout_TimeSpan.SetBelong(null);
				}
				return r_RValidateMatchTimeout_TimeSpan;
			}
		}

		/// <summary>
		/// System.TimeSpan InitDefaultMatchTimeout()
		/// </summary>
		protected static RMethod r_RInitDefaultMatchTimeout;
		public static RMethod RInitDefaultMatchTimeout
		{
			get
			{
				if(r_RInitDefaultMatchTimeout == null)
				{
					r_RInitDefaultMatchTimeout = new(typeof(System.Text.RegularExpressions.Regex), "InitDefaultMatchTimeout", 0);
					r_RInitDefaultMatchTimeout.SetBelong(null);
				}
				return r_RInitDefaultMatchTimeout;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexRunnerFactory Compile(System.Text.RegularExpressions.RegexCode, System.Text.RegularExpressions.RegexOptions)
		/// </summary>
		protected RMethod r_RCompile_RegexCode_RegexOptions;
		public virtual RMethod RCompile_RegexCode_RegexOptions
		{
			get
			{
				if(r_RCompile_RegexCode_RegexOptions == null)
				{
					r_RCompile_RegexCode_RegexOptions = new(this, "Compile", 0,  ReleactionUtils.GetType("System.Text.RegularExpressions.RegexCode"), typeof(System.Text.RegularExpressions.RegexOptions));
					r_RCompile_RegexCode_RegexOptions.SetBelong(this.instance);
				}
				return r_RCompile_RegexCode_RegexOptions;
			}
		}

		/// <summary>
		/// Void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[], System.Reflection.AssemblyName)
		/// </summary>
		protected static RMethod r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName;
		public static RMethod RCompileToAssembly_RegexCompilationInfoArray_AssemblyName
		{
			get
			{
				if(r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName == null)
				{
					r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName = new(typeof(System.Text.RegularExpressions.Regex), "CompileToAssembly", 0, typeof(System.Text.RegularExpressions.RegexCompilationInfo).MakeArrayType(), typeof(System.Reflection.AssemblyName));
					r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName.SetBelong(null);
				}
				return r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName;
			}
		}

		/// <summary>
		/// Void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[], System.Reflection.AssemblyName, System.Reflection.Emit.CustomAttributeBuilder[])
		/// </summary>
		protected static RMethod r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray;
		public static RMethod RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray
		{
			get
			{
				if(r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray == null)
				{
					r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray = new(typeof(System.Text.RegularExpressions.Regex), "CompileToAssembly", 0, typeof(System.Text.RegularExpressions.RegexCompilationInfo).MakeArrayType(), typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.CustomAttributeBuilder).MakeArrayType());
					r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray.SetBelong(null);
				}
				return r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray;
			}
		}

		/// <summary>
		/// Void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[], System.Reflection.AssemblyName, System.Reflection.Emit.CustomAttributeBuilder[], System.String)
		/// </summary>
		protected static RMethod r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String;
		public static RMethod RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String
		{
			get
			{
				if(r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String == null)
				{
					r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String = new(typeof(System.Text.RegularExpressions.Regex), "CompileToAssembly", 0, typeof(System.Text.RegularExpressions.RegexCompilationInfo).MakeArrayType(), typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Emit.CustomAttributeBuilder).MakeArrayType(), typeof(System.String));
					r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String.SetBelong(null);
				}
				return r_RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String;
			}
		}

		/// <summary>
		/// System.String Escape(System.String)
		/// </summary>
		protected static RMethod r_REscape_String;
		public static RMethod REscape_String
		{
			get
			{
				if(r_REscape_String == null)
				{
					r_REscape_String = new(typeof(System.Text.RegularExpressions.Regex), "Escape", 0, typeof(System.String));
					r_REscape_String.SetBelong(null);
				}
				return r_REscape_String;
			}
		}

		/// <summary>
		/// System.String Unescape(System.String)
		/// </summary>
		protected static RMethod r_RUnescape_String;
		public static RMethod RUnescape_String
		{
			get
			{
				if(r_RUnescape_String == null)
				{
					r_RUnescape_String = new(typeof(System.Text.RegularExpressions.Regex), "Unescape", 0, typeof(System.String));
					r_RUnescape_String.SetBelong(null);
				}
				return r_RUnescape_String;
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
		/// System.String[] GetGroupNames()
		/// </summary>
		protected RMethod r_RGetGroupNames;
		public virtual RMethod RGetGroupNames
		{
			get
			{
				if(r_RGetGroupNames == null)
				{
					r_RGetGroupNames = new(this, "GetGroupNames", 0);
					r_RGetGroupNames.SetBelong(this.instance);
				}
				return r_RGetGroupNames;
			}
		}

		/// <summary>
		/// Int32[] GetGroupNumbers()
		/// </summary>
		protected RMethod r_RGetGroupNumbers;
		public virtual RMethod RGetGroupNumbers
		{
			get
			{
				if(r_RGetGroupNumbers == null)
				{
					r_RGetGroupNumbers = new(this, "GetGroupNumbers", 0);
					r_RGetGroupNumbers.SetBelong(this.instance);
				}
				return r_RGetGroupNumbers;
			}
		}

		/// <summary>
		/// System.String GroupNameFromNumber(Int32)
		/// </summary>
		protected RMethod r_RGroupNameFromNumber_Int32;
		public virtual RMethod RGroupNameFromNumber_Int32
		{
			get
			{
				if(r_RGroupNameFromNumber_Int32 == null)
				{
					r_RGroupNameFromNumber_Int32 = new(this, "GroupNameFromNumber", 0, typeof(System.Int32));
					r_RGroupNameFromNumber_Int32.SetBelong(this.instance);
				}
				return r_RGroupNameFromNumber_Int32;
			}
		}

		/// <summary>
		/// Int32 GroupNumberFromName(System.String)
		/// </summary>
		protected RMethod r_RGroupNumberFromName_String;
		public virtual RMethod RGroupNumberFromName_String
		{
			get
			{
				if(r_RGroupNumberFromName_String == null)
				{
					r_RGroupNumberFromName_String = new(this, "GroupNumberFromName", 0, typeof(System.String));
					r_RGroupNumberFromName_String.SetBelong(this.instance);
				}
				return r_RGroupNumberFromName_String;
			}
		}

		/// <summary>
		/// Void InitializeReferences()
		/// </summary>
		protected RMethod r_RInitializeReferences;
		public virtual RMethod RInitializeReferences
		{
			get
			{
				if(r_RInitializeReferences == null)
				{
					r_RInitializeReferences = new(this, "InitializeReferences", 0);
					r_RInitializeReferences.SetBelong(this.instance);
				}
				return r_RInitializeReferences;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.Match Run(Boolean, Int32, System.String, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RRun_Boolean_Int32_String_Int32_Int32_Int32;
		public virtual RMethod RRun_Boolean_Int32_String_Int32_Int32_Int32
		{
			get
			{
				if(r_RRun_Boolean_Int32_String_Int32_Int32_Int32 == null)
				{
					r_RRun_Boolean_Int32_String_Int32_Int32_Int32 = new(this, "Run", 0, typeof(System.Boolean), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RRun_Boolean_Int32_String_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRun_Boolean_Int32_String_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean UseOptionC()
		/// </summary>
		protected RMethod r_RUseOptionC;
		public virtual RMethod RUseOptionC
		{
			get
			{
				if(r_RUseOptionC == null)
				{
					r_RUseOptionC = new(this, "UseOptionC", 0);
					r_RUseOptionC.SetBelong(this.instance);
				}
				return r_RUseOptionC;
			}
		}

		/// <summary>
		/// Boolean UseOptionR()
		/// </summary>
		protected RMethod r_RUseOptionR;
		public virtual RMethod RUseOptionR
		{
			get
			{
				if(r_RUseOptionR == null)
				{
					r_RUseOptionR = new(this, "UseOptionR", 0);
					r_RUseOptionR.SetBelong(this.instance);
				}
				return r_RUseOptionR;
			}
		}

		/// <summary>
		/// Boolean UseOptionInvariant()
		/// </summary>
		protected RMethod r_RUseOptionInvariant;
		public virtual RMethod RUseOptionInvariant
		{
			get
			{
				if(r_RUseOptionInvariant == null)
				{
					r_RUseOptionInvariant = new(this, "UseOptionInvariant", 0);
					r_RUseOptionInvariant.SetBelong(this.instance);
				}
				return r_RUseOptionInvariant;
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



        public virtual void FillCacheDictionary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFillCacheDictionary.Invoke(___genericsType, ___parameters);

            
        }





        public static System.Boolean IsMatch(System.String  @input, System.String  @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RIsMatch_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsMatch(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RIsMatch_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsMatch(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options, System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RIsMatch_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMatch(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RIsMatch_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMatch(System.String  @input, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @startat};
            var ___result = RIsMatch_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Text.RegularExpressions.Match Match(System.String  @input, System.String  @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RMatch_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public static System.Text.RegularExpressions.Match Match(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RMatch_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public static System.Text.RegularExpressions.Match Match(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options, System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RMatch_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Match(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMatch_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Match(System.String  @input, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @startat};
            var ___result = RMatch_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Text.RegularExpressions.Match Match(System.String  @input, System.Int32  @beginning, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @beginning, @length};
            var ___result = RMatch_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public static System.Text.RegularExpressions.MatchCollection Matches(System.String  @input, System.String  @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RMatches_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public static System.Text.RegularExpressions.MatchCollection Matches(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RMatches_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public static System.Text.RegularExpressions.MatchCollection Matches(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options, System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RMatches_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public virtual System.Text.RegularExpressions.MatchCollection Matches(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMatches_String.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public virtual System.Text.RegularExpressions.MatchCollection Matches(System.String  @input, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @startat};
            var ___result = RMatches_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.MatchCollection)___result;
        }


        public static System.String Replace(System.String  @input, System.String  @pattern, System.String  @replacement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @replacement};
            var ___result = RReplace_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String  @input, System.String  @pattern, System.String  @replacement, System.Text.RegularExpressions.RegexOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @replacement, @options};
            var ___result = RReplace_String_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String  @input, System.String  @pattern, System.String  @replacement, System.Text.RegularExpressions.RegexOptions  @options, System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @replacement, @options, @matchTimeout};
            var ___result = RReplace_String_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String  @input, System.String  @replacement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @replacement};
            var ___result = RReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String  @input, System.String  @replacement, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @replacement, @count};
            var ___result = RReplace_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String  @input, System.String  @replacement, System.Int32  @count, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @replacement, @count, @startat};
            var ___result = RReplace_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.MatchEvaluator  @evaluator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @evaluator};
            var ___result = RReplace_String_String_MatchEvaluator.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.MatchEvaluator  @evaluator, System.Text.RegularExpressions.RegexOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @evaluator, @options};
            var ___result = RReplace_String_String_MatchEvaluator_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.MatchEvaluator  @evaluator, System.Text.RegularExpressions.RegexOptions  @options, System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @evaluator, @options, @matchTimeout};
            var ___result = RReplace_String_String_MatchEvaluator_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String  @input, System.Text.RegularExpressions.MatchEvaluator  @evaluator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @evaluator};
            var ___result = RReplace_String_MatchEvaluator.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String  @input, System.Text.RegularExpressions.MatchEvaluator  @evaluator, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @evaluator, @count};
            var ___result = RReplace_String_MatchEvaluator_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String Replace(System.String  @input, System.Text.RegularExpressions.MatchEvaluator  @evaluator, System.Int32  @count, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @evaluator, @count, @startat};
            var ___result = RReplace_String_MatchEvaluator_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Replace(System.Text.RegularExpressions.MatchEvaluator  @evaluator, System.Text.RegularExpressions.Regex  @regex, System.String  @input, System.Int32  @count, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evaluator, @regex, @input, @count, @startat};
            var ___result = RReplace_MatchEvaluator_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String[] Split(System.String  @input, System.String  @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern};
            var ___result = RSplit_String_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] Split(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options};
            var ___result = RSplit_String_String_RegexOptions.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] Split(System.String  @input, System.String  @pattern, System.Text.RegularExpressions.RegexOptions  @options, System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @pattern, @options, @matchTimeout};
            var ___result = RSplit_String_String_RegexOptions_TimeSpan.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RSplit_String.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String  @input, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @count};
            var ___result = RSplit_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.String[] Split(System.String  @input, System.Int32  @count, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @count, @startat};
            var ___result = RSplit_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static System.String[] Split(System.Text.RegularExpressions.Regex  @regex, System.String  @input, System.Int32  @count, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regex, @input, @count, @startat};
            var ___result = RSplit_Regex_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public static void ValidateMatchTimeout(System.TimeSpan  @matchTimeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matchTimeout};
            var ___result = RValidateMatchTimeout_TimeSpan.Invoke(___genericsType, ___parameters);

            
        }


        public static System.TimeSpan InitDefaultMatchTimeout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitDefaultMatchTimeout.Invoke(___genericsType, ___parameters);

            return (System.TimeSpan)___result;
        }


        public virtual void System__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData(System.Runtime.Serialization.SerializationInfo  @si, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@si, @context};
            var ___result = RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }



        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[]  @regexinfos, System.Reflection.AssemblyName  @assemblyname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regexinfos, @assemblyname};
            var ___result = RCompileToAssembly_RegexCompilationInfoArray_AssemblyName.Invoke(___genericsType, ___parameters);

            
        }


        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[]  @regexinfos, System.Reflection.AssemblyName  @assemblyname, System.Reflection.Emit.CustomAttributeBuilder[]  @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regexinfos, @assemblyname, @attributes};
            var ___result = RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[]  @regexinfos, System.Reflection.AssemblyName  @assemblyname, System.Reflection.Emit.CustomAttributeBuilder[]  @attributes, System.String  @resourceFile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@regexinfos, @assemblyname, @attributes, @resourceFile};
            var ___result = RCompileToAssembly_RegexCompilationInfoArray_AssemblyName_CustomAttributeBuilderArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.String Escape(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = REscape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Unescape(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RUnescape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] GetGroupNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGroupNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Int32[] GetGroupNumbers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGroupNumbers.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.String GroupNameFromNumber(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RGroupNameFromNumber_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GroupNumberFromName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGroupNumberFromName_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitializeReferences()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeReferences.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.RegularExpressions.Match Run(System.Boolean  @quick, System.Int32  @prevlen, System.String  @input, System.Int32  @beginning, System.Int32  @length, System.Int32  @startat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@quick, @prevlen, @input, @beginning, @length, @startat};
            var ___result = RRun_Boolean_Int32_String_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.RegularExpressions.Match)___result;
        }


        public virtual System.Boolean UseOptionC()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUseOptionC.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UseOptionR()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUseOptionR.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UseOptionInvariant()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUseOptionInvariant.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
