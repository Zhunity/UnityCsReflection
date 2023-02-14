
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CultureInfo
	/// </summary>
    public partial class RCultureInfo : RMember //
    {

		/// <summary>
		/// System.Globalization.CultureInfo invariant_culture_info
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Finvariant_culture_info;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFinvariant_culture_info
		{
			get
			{
				if(r_Finvariant_culture_info == null)
				{
					r_Finvariant_culture_info = new(typeof(System.Globalization.CultureInfo), "invariant_culture_info");
					r_Finvariant_culture_info.SetBelong(null);
				}
				return r_Finvariant_culture_info;
			}
		}

		/// <summary>
		/// System.Object shared_table_lock
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_Fshared_table_lock;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFshared_table_lock
		{
			get
			{
				if(r_Fshared_table_lock == null)
				{
					r_Fshared_table_lock = new(typeof(System.Globalization.CultureInfo), "shared_table_lock");
					r_Fshared_table_lock.SetBelong(null);
				}
				return r_Fshared_table_lock;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo default_current_culture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fdefault_current_culture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFdefault_current_culture
		{
			get
			{
				if(r_Fdefault_current_culture == null)
				{
					r_Fdefault_current_culture = new(typeof(System.Globalization.CultureInfo), "default_current_culture");
					r_Fdefault_current_culture.SetBelong(null);
				}
				return r_Fdefault_current_culture;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isReadOnly
		{
			get
			{
				if(r_Fm_isReadOnly == null)
				{
					r_Fm_isReadOnly = new(this, "m_isReadOnly");
					r_Fm_isReadOnly.SetBelong(this.instance);
				}
				return r_Fm_isReadOnly;
			}
		}

		/// <summary>
		/// System.Int32 cultureID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcultureID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcultureID
		{
			get
			{
				if(r_FcultureID == null)
				{
					r_FcultureID = new(this, "cultureID");
					r_FcultureID.SetBelong(this.instance);
				}
				return r_FcultureID;
			}
		}

		/// <summary>
		/// System.Int32 parent_lcid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fparent_lcid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFparent_lcid
		{
			get
			{
				if(r_Fparent_lcid == null)
				{
					r_Fparent_lcid = new(this, "parent_lcid");
					r_Fparent_lcid.SetBelong(this.instance);
				}
				return r_Fparent_lcid;
			}
		}

		/// <summary>
		/// System.Int32 datetime_index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fdatetime_index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFdatetime_index
		{
			get
			{
				if(r_Fdatetime_index == null)
				{
					r_Fdatetime_index = new(this, "datetime_index");
					r_Fdatetime_index.SetBelong(this.instance);
				}
				return r_Fdatetime_index;
			}
		}

		/// <summary>
		/// System.Int32 number_index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fnumber_index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFnumber_index
		{
			get
			{
				if(r_Fnumber_index == null)
				{
					r_Fnumber_index = new(this, "number_index");
					r_Fnumber_index.SetBelong(this.instance);
				}
				return r_Fnumber_index;
			}
		}

		/// <summary>
		/// System.Int32 default_calendar_type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fdefault_calendar_type;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFdefault_calendar_type
		{
			get
			{
				if(r_Fdefault_calendar_type == null)
				{
					r_Fdefault_calendar_type = new(this, "default_calendar_type");
					r_Fdefault_calendar_type.SetBelong(this.instance);
				}
				return r_Fdefault_calendar_type;
			}
		}

		/// <summary>
		/// System.Boolean m_useUserOverride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_useUserOverride;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_useUserOverride
		{
			get
			{
				if(r_Fm_useUserOverride == null)
				{
					r_Fm_useUserOverride = new(this, "m_useUserOverride");
					r_Fm_useUserOverride.SetBelong(this.instance);
				}
				return r_Fm_useUserOverride;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo numInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo r_FnumInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo RFnumInfo
		{
			get
			{
				if(r_FnumInfo == null)
				{
					r_FnumInfo = new(this, "numInfo");
					r_FnumInfo.SetBelong(this.instance);
				}
				return r_FnumInfo;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo dateTimeInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_FdateTimeInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RFdateTimeInfo
		{
			get
			{
				if(r_FdateTimeInfo == null)
				{
					r_FdateTimeInfo = new(this, "dateTimeInfo");
					r_FdateTimeInfo.SetBelong(this.instance);
				}
				return r_FdateTimeInfo;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo textInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RTextInfo r_FtextInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RTextInfo RFtextInfo
		{
			get
			{
				if(r_FtextInfo == null)
				{
					r_FtextInfo = new(this, "textInfo");
					r_FtextInfo.SetBelong(this.instance);
				}
				return r_FtextInfo;
			}
		}

		/// <summary>
		/// System.String m_name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_name
		{
			get
			{
				if(r_Fm_name == null)
				{
					r_Fm_name = new(this, "m_name");
					r_Fm_name.SetBelong(this.instance);
				}
				return r_Fm_name;
			}
		}

		/// <summary>
		/// System.String englishname
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fenglishname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFenglishname
		{
			get
			{
				if(r_Fenglishname == null)
				{
					r_Fenglishname = new(this, "englishname");
					r_Fenglishname.SetBelong(this.instance);
				}
				return r_Fenglishname;
			}
		}

		/// <summary>
		/// System.String nativename
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fnativename;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFnativename
		{
			get
			{
				if(r_Fnativename == null)
				{
					r_Fnativename = new(this, "nativename");
					r_Fnativename.SetBelong(this.instance);
				}
				return r_Fnativename;
			}
		}

		/// <summary>
		/// System.String iso3lang
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fiso3lang;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFiso3lang
		{
			get
			{
				if(r_Fiso3lang == null)
				{
					r_Fiso3lang = new(this, "iso3lang");
					r_Fiso3lang.SetBelong(this.instance);
				}
				return r_Fiso3lang;
			}
		}

		/// <summary>
		/// System.String iso2lang
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fiso2lang;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFiso2lang
		{
			get
			{
				if(r_Fiso2lang == null)
				{
					r_Fiso2lang = new(this, "iso2lang");
					r_Fiso2lang.SetBelong(this.instance);
				}
				return r_Fiso2lang;
			}
		}

		/// <summary>
		/// System.String win3lang
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fwin3lang;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFwin3lang
		{
			get
			{
				if(r_Fwin3lang == null)
				{
					r_Fwin3lang = new(this, "win3lang");
					r_Fwin3lang.SetBelong(this.instance);
				}
				return r_Fwin3lang;
			}
		}

		/// <summary>
		/// System.String territory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fterritory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFterritory
		{
			get
			{
				if(r_Fterritory == null)
				{
					r_Fterritory = new(this, "territory");
					r_Fterritory.SetBelong(this.instance);
				}
				return r_Fterritory;
			}
		}

		/// <summary>
		/// System.String[] native_calendar_names
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fnative_calendar_names;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFnative_calendar_names
		{
			get
			{
				if(r_Fnative_calendar_names == null)
				{
					r_Fnative_calendar_names = new(this, "native_calendar_names");
					r_Fnative_calendar_names.SetBelong(this.instance);
				}
				return r_Fnative_calendar_names;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo compareInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo r_FcompareInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo RFcompareInfo
		{
			get
			{
				if(r_FcompareInfo == null)
				{
					r_FcompareInfo = new(this, "compareInfo");
					r_FcompareInfo.SetBelong(this.instance);
				}
				return r_FcompareInfo;
			}
		}

		/// <summary>
		/// System.Void* textinfo_data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> r_Ftextinfo_data;
		public virtual Hvak.Editor.Refleaction.RFieldPointer<Hvak.Editor.Refleaction.RField> RFtextinfo_data
		{
			get
			{
				if(r_Ftextinfo_data == null)
				{
					r_Ftextinfo_data = new(this, "textinfo_data");
					r_Ftextinfo_data.SetBelong(this.instance);
				}
				return r_Ftextinfo_data;
			}
		}

		/// <summary>
		/// System.Int32 m_dataItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_dataItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_dataItem
		{
			get
			{
				if(r_Fm_dataItem == null)
				{
					r_Fm_dataItem = new(this, "m_dataItem");
					r_Fm_dataItem.SetBelong(this.instance);
				}
				return r_Fm_dataItem;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar calendar
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar r_Fcalendar;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar RFcalendar
		{
			get
			{
				if(r_Fcalendar == null)
				{
					r_Fcalendar = new(this, "calendar");
					r_Fcalendar.SetBelong(this.instance);
				}
				return r_Fcalendar;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo parent_culture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fparent_culture;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFparent_culture
		{
			get
			{
				if(r_Fparent_culture == null)
				{
					r_Fparent_culture = new(this, "parent_culture");
					r_Fparent_culture.SetBelong(this.instance);
				}
				return r_Fparent_culture;
			}
		}

		/// <summary>
		/// System.Boolean constructed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fconstructed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFconstructed
		{
			get
			{
				if(r_Fconstructed == null)
				{
					r_Fconstructed = new(this, "constructed");
					r_Fconstructed.SetBelong(this.instance);
				}
				return r_Fconstructed;
			}
		}

		/// <summary>
		/// System.Byte[] cached_serialized_form
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fcached_serialized_form;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFcached_serialized_form
		{
			get
			{
				if(r_Fcached_serialized_form == null)
				{
					r_Fcached_serialized_form = new(this, "cached_serialized_form");
					r_Fcached_serialized_form.SetBelong(this.instance);
				}
				return r_Fcached_serialized_form;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData m_cultureData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData r_Fm_cultureData;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData RFm_cultureData
		{
			get
			{
				if(r_Fm_cultureData == null)
				{
					r_Fm_cultureData = new(this, "m_cultureData");
					r_Fm_cultureData.SetBelong(this.instance);
				}
				return r_Fm_cultureData;
			}
		}

		/// <summary>
		/// System.Boolean m_isInherited
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_isInherited;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_isInherited
		{
			get
			{
				if(r_Fm_isInherited == null)
				{
					r_Fm_isInherited = new(this, "m_isInherited");
					r_Fm_isInherited.SetBelong(this.instance);
				}
				return r_Fm_isInherited;
			}
		}

		/// <summary>
		/// System.Int32 InvariantCultureId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FInvariantCultureId;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFInvariantCultureId
		{
			get
			{
				if(r_FInvariantCultureId == null)
				{
					r_FInvariantCultureId = new(typeof(System.Globalization.CultureInfo), "InvariantCultureId");
					r_FInvariantCultureId.SetBelong(null);
				}
				return r_FInvariantCultureId;
			}
		}

		/// <summary>
		/// System.Int32 CalendarTypeBits
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FCalendarTypeBits;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFCalendarTypeBits
		{
			get
			{
				if(r_FCalendarTypeBits == null)
				{
					r_FCalendarTypeBits = new(typeof(System.Globalization.CultureInfo), "CalendarTypeBits");
					r_FCalendarTypeBits.SetBelong(null);
				}
				return r_FCalendarTypeBits;
			}
		}

		/// <summary>
		/// System.Int32 LOCALE_INVARIANT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLOCALE_INVARIANT;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLOCALE_INVARIANT
		{
			get
			{
				if(r_FLOCALE_INVARIANT == null)
				{
					r_FLOCALE_INVARIANT = new(typeof(System.Globalization.CultureInfo), "LOCALE_INVARIANT");
					r_FLOCALE_INVARIANT.SetBelong(null);
				}
				return r_FLOCALE_INVARIANT;
			}
		}

		/// <summary>
		/// System.String MSG_READONLY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FMSG_READONLY;
		public static Hvak.Editor.Refleaction.RSystem.RString RFMSG_READONLY
		{
			get
			{
				if(r_FMSG_READONLY == null)
				{
					r_FMSG_READONLY = new(typeof(System.Globalization.CultureInfo), "MSG_READONLY");
					r_FMSG_READONLY.SetBelong(null);
				}
				return r_FMSG_READONLY;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo s_DefaultThreadCurrentUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fs_DefaultThreadCurrentUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFs_DefaultThreadCurrentUICulture
		{
			get
			{
				if(r_Fs_DefaultThreadCurrentUICulture == null)
				{
					r_Fs_DefaultThreadCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "s_DefaultThreadCurrentUICulture");
					r_Fs_DefaultThreadCurrentUICulture.SetBelong(null);
				}
				return r_Fs_DefaultThreadCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo s_DefaultThreadCurrentCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fs_DefaultThreadCurrentCulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFs_DefaultThreadCurrentCulture
		{
			get
			{
				if(r_Fs_DefaultThreadCurrentCulture == null)
				{
					r_Fs_DefaultThreadCurrentCulture = new(typeof(System.Globalization.CultureInfo), "s_DefaultThreadCurrentCulture");
					r_Fs_DefaultThreadCurrentCulture.SetBelong(null);
				}
				return r_Fs_DefaultThreadCurrentCulture;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Globalization.CultureInfo] shared_by_number
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> r_Fshared_by_number;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> RFshared_by_number
		{
			get
			{
				if(r_Fshared_by_number == null)
				{
					r_Fshared_by_number = new(typeof(System.Globalization.CultureInfo), "shared_by_number");
					r_Fshared_by_number.SetBelong(null);
				}
				return r_Fshared_by_number;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Globalization.CultureInfo] shared_by_name
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> r_Fshared_by_name;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo> RFshared_by_name
		{
			get
			{
				if(r_Fshared_by_name == null)
				{
					r_Fshared_by_name = new(typeof(System.Globalization.CultureInfo), "shared_by_name");
					r_Fshared_by_name.SetBelong(null);
				}
				return r_Fshared_by_name;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo s_UserPreferredCultureInfoInAppX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_Fs_UserPreferredCultureInfoInAppX;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RFs_UserPreferredCultureInfoInAppX
		{
			get
			{
				if(r_Fs_UserPreferredCultureInfoInAppX == null)
				{
					r_Fs_UserPreferredCultureInfoInAppX = new(typeof(System.Globalization.CultureInfo), "s_UserPreferredCultureInfoInAppX");
					r_Fs_UserPreferredCultureInfoInAppX.SetBelong(null);
				}
				return r_Fs_UserPreferredCultureInfoInAppX;
			}
		}

		/// <summary>
		/// System.Boolean IsTaiwanSku
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_FIsTaiwanSku;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFIsTaiwanSku
		{
			get
			{
				if(r_FIsTaiwanSku == null)
				{
					r_FIsTaiwanSku = new(typeof(System.Globalization.CultureInfo), "IsTaiwanSku");
					r_FIsTaiwanSku.SetBelong(null);
				}
				return r_FIsTaiwanSku;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData _cultureData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData r_P_cultureData;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureData RP_cultureData
		{
			get
			{
				if(r_P_cultureData == null)
				{
					r_P_cultureData = new(this, "_cultureData", -1);
					r_P_cultureData.SetBelong(this.instance);
				}
				return r_P_cultureData;
			}
		}

		/// <summary>
		/// Boolean _isInherited
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_P_isInherited;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RP_isInherited
		{
			get
			{
				if(r_P_isInherited == null)
				{
					r_P_isInherited = new(this, "_isInherited", -1);
					r_P_isInherited.SetBelong(this.instance);
				}
				return r_P_isInherited;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo InvariantCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PInvariantCulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPInvariantCulture
		{
			get
			{
				if(r_PInvariantCulture == null)
				{
					r_PInvariantCulture = new(typeof(System.Globalization.CultureInfo), "InvariantCulture", -1);
					r_PInvariantCulture.SetBelong(null);
				}
				return r_PInvariantCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PCurrentCulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPCurrentCulture
		{
			get
			{
				if(r_PCurrentCulture == null)
				{
					r_PCurrentCulture = new(typeof(System.Globalization.CultureInfo), "CurrentCulture", -1);
					r_PCurrentCulture.SetBelong(null);
				}
				return r_PCurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PCurrentUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPCurrentUICulture
		{
			get
			{
				if(r_PCurrentUICulture == null)
				{
					r_PCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "CurrentUICulture", -1);
					r_PCurrentUICulture.SetBelong(null);
				}
				return r_PCurrentUICulture;
			}
		}

		/// <summary>
		/// System.String Territory
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTerritory;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTerritory
		{
			get
			{
				if(r_PTerritory == null)
				{
					r_PTerritory = new(this, "Territory", -1);
					r_PTerritory.SetBelong(this.instance);
				}
				return r_PTerritory;
			}
		}

		/// <summary>
		/// System.String _name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_P_name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RP_name
		{
			get
			{
				if(r_P_name == null)
				{
					r_P_name = new(this, "_name", -1);
					r_P_name.SetBelong(this.instance);
				}
				return r_P_name;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes CultureTypes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureTypes r_PCultureTypes;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureTypes RPCultureTypes
		{
			get
			{
				if(r_PCultureTypes == null)
				{
					r_PCultureTypes = new(this, "CultureTypes", -1);
					r_PCultureTypes.SetBelong(this.instance);
				}
				return r_PCultureTypes;
			}
		}

		/// <summary>
		/// System.String IetfLanguageTag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PIetfLanguageTag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPIetfLanguageTag
		{
			get
			{
				if(r_PIetfLanguageTag == null)
				{
					r_PIetfLanguageTag = new(this, "IetfLanguageTag", -1);
					r_PIetfLanguageTag.SetBelong(this.instance);
				}
				return r_PIetfLanguageTag;
			}
		}

		/// <summary>
		/// Int32 KeyboardLayoutId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PKeyboardLayoutId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPKeyboardLayoutId
		{
			get
			{
				if(r_PKeyboardLayoutId == null)
				{
					r_PKeyboardLayoutId = new(this, "KeyboardLayoutId", -1);
					r_PKeyboardLayoutId.SetBelong(this.instance);
				}
				return r_PKeyboardLayoutId;
			}
		}

		/// <summary>
		/// Int32 LCID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLCID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLCID
		{
			get
			{
				if(r_PLCID == null)
				{
					r_PLCID = new(this, "LCID", -1);
					r_PLCID.SetBelong(this.instance);
				}
				return r_PLCID;
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
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.String NativeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNativeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNativeName
		{
			get
			{
				if(r_PNativeName == null)
				{
					r_PNativeName = new(this, "NativeName", -1);
					r_PNativeName.SetBelong(this.instance);
				}
				return r_PNativeName;
			}
		}

		/// <summary>
		/// System.String NativeCalendarName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNativeCalendarName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNativeCalendarName
		{
			get
			{
				if(r_PNativeCalendarName == null)
				{
					r_PNativeCalendarName = new(this, "NativeCalendarName", -1);
					r_PNativeCalendarName.SetBelong(this.instance);
				}
				return r_PNativeCalendarName;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar Calendar
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar r_PCalendar;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar RPCalendar
		{
			get
			{
				if(r_PCalendar == null)
				{
					r_PCalendar = new(this, "Calendar", -1);
					r_PCalendar.SetBelong(this.instance);
				}
				return r_PCalendar;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar[] OptionalCalendars
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar> r_POptionalCalendars;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RGlobalization.RCalendar> RPOptionalCalendars
		{
			get
			{
				if(r_POptionalCalendars == null)
				{
					r_POptionalCalendars = new(this, "OptionalCalendars", -1);
					r_POptionalCalendars.SetBelong(this.instance);
				}
				return r_POptionalCalendars;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo Parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PParent;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPParent
		{
			get
			{
				if(r_PParent == null)
				{
					r_PParent = new(this, "Parent", -1);
					r_PParent.SetBelong(this.instance);
				}
				return r_PParent;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo TextInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RTextInfo r_PTextInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RTextInfo RPTextInfo
		{
			get
			{
				if(r_PTextInfo == null)
				{
					r_PTextInfo = new(this, "TextInfo", -1);
					r_PTextInfo.SetBelong(this.instance);
				}
				return r_PTextInfo;
			}
		}

		/// <summary>
		/// System.String ThreeLetterISOLanguageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PThreeLetterISOLanguageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPThreeLetterISOLanguageName
		{
			get
			{
				if(r_PThreeLetterISOLanguageName == null)
				{
					r_PThreeLetterISOLanguageName = new(this, "ThreeLetterISOLanguageName", -1);
					r_PThreeLetterISOLanguageName.SetBelong(this.instance);
				}
				return r_PThreeLetterISOLanguageName;
			}
		}

		/// <summary>
		/// System.String ThreeLetterWindowsLanguageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PThreeLetterWindowsLanguageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPThreeLetterWindowsLanguageName
		{
			get
			{
				if(r_PThreeLetterWindowsLanguageName == null)
				{
					r_PThreeLetterWindowsLanguageName = new(this, "ThreeLetterWindowsLanguageName", -1);
					r_PThreeLetterWindowsLanguageName.SetBelong(this.instance);
				}
				return r_PThreeLetterWindowsLanguageName;
			}
		}

		/// <summary>
		/// System.String TwoLetterISOLanguageName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTwoLetterISOLanguageName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTwoLetterISOLanguageName
		{
			get
			{
				if(r_PTwoLetterISOLanguageName == null)
				{
					r_PTwoLetterISOLanguageName = new(this, "TwoLetterISOLanguageName", -1);
					r_PTwoLetterISOLanguageName.SetBelong(this.instance);
				}
				return r_PTwoLetterISOLanguageName;
			}
		}

		/// <summary>
		/// Boolean UseUserOverride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PUseUserOverride;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPUseUserOverride
		{
			get
			{
				if(r_PUseUserOverride == null)
				{
					r_PUseUserOverride = new(this, "UseUserOverride", -1);
					r_PUseUserOverride.SetBelong(this.instance);
				}
				return r_PUseUserOverride;
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
					r_PCompareInfo.SetBelong(this.instance);
				}
				return r_PCompareInfo;
			}
		}

		/// <summary>
		/// Boolean IsNeutralCulture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNeutralCulture;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNeutralCulture
		{
			get
			{
				if(r_PIsNeutralCulture == null)
				{
					r_PIsNeutralCulture = new(this, "IsNeutralCulture", -1);
					r_PIsNeutralCulture.SetBelong(this.instance);
				}
				return r_PIsNeutralCulture;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo NumberFormat
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo r_PNumberFormat;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RNumberFormatInfo RPNumberFormat
		{
			get
			{
				if(r_PNumberFormat == null)
				{
					r_PNumberFormat = new(this, "NumberFormat", -1);
					r_PNumberFormat.SetBelong(this.instance);
				}
				return r_PNumberFormat;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo DateTimeFormat
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo r_PDateTimeFormat;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RDateTimeFormatInfo RPDateTimeFormat
		{
			get
			{
				if(r_PDateTimeFormat == null)
				{
					r_PDateTimeFormat = new(this, "DateTimeFormat", -1);
					r_PDateTimeFormat.SetBelong(this.instance);
				}
				return r_PDateTimeFormat;
			}
		}

		/// <summary>
		/// System.String DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDisplayName
		{
			get
			{
				if(r_PDisplayName == null)
				{
					r_PDisplayName = new(this, "DisplayName", -1);
					r_PDisplayName.SetBelong(this.instance);
				}
				return r_PDisplayName;
			}
		}

		/// <summary>
		/// System.String EnglishName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PEnglishName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPEnglishName
		{
			get
			{
				if(r_PEnglishName == null)
				{
					r_PEnglishName = new(this, "EnglishName", -1);
					r_PEnglishName.SetBelong(this.instance);
				}
				return r_PEnglishName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo InstalledUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PInstalledUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPInstalledUICulture
		{
			get
			{
				if(r_PInstalledUICulture == null)
				{
					r_PInstalledUICulture = new(typeof(System.Globalization.CultureInfo), "InstalledUICulture", -1);
					r_PInstalledUICulture.SetBelong(null);
				}
				return r_PInstalledUICulture;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
					r_PIsReadOnly.SetBelong(this.instance);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Int32 CalendarType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCalendarType;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCalendarType
		{
			get
			{
				if(r_PCalendarType == null)
				{
					r_PCalendarType = new(this, "CalendarType", -1);
					r_PCalendarType.SetBelong(this.instance);
				}
				return r_PCalendarType;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo DefaultThreadCurrentCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PDefaultThreadCurrentCulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPDefaultThreadCurrentCulture
		{
			get
			{
				if(r_PDefaultThreadCurrentCulture == null)
				{
					r_PDefaultThreadCurrentCulture = new(typeof(System.Globalization.CultureInfo), "DefaultThreadCurrentCulture", -1);
					r_PDefaultThreadCurrentCulture.SetBelong(null);
				}
				return r_PDefaultThreadCurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo DefaultThreadCurrentUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PDefaultThreadCurrentUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPDefaultThreadCurrentUICulture
		{
			get
			{
				if(r_PDefaultThreadCurrentUICulture == null)
				{
					r_PDefaultThreadCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "DefaultThreadCurrentUICulture", -1);
					r_PDefaultThreadCurrentUICulture.SetBelong(null);
				}
				return r_PDefaultThreadCurrentUICulture;
			}
		}

		/// <summary>
		/// System.String SortName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSortName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSortName
		{
			get
			{
				if(r_PSortName == null)
				{
					r_PSortName = new(this, "SortName", -1);
					r_PSortName.SetBelong(this.instance);
				}
				return r_PSortName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo UserDefaultUICulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PUserDefaultUICulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPUserDefaultUICulture
		{
			get
			{
				if(r_PUserDefaultUICulture == null)
				{
					r_PUserDefaultUICulture = new(typeof(System.Globalization.CultureInfo), "UserDefaultUICulture", -1);
					r_PUserDefaultUICulture.SetBelong(null);
				}
				return r_PUserDefaultUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo UserDefaultCulture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo r_PUserDefaultCulture;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo RPUserDefaultCulture
		{
			get
			{
				if(r_PUserDefaultCulture == null)
				{
					r_PUserDefaultCulture = new(typeof(System.Globalization.CultureInfo), "UserDefaultCulture", -1);
					r_PUserDefaultCulture.SetBelong(null);
				}
				return r_PUserDefaultCulture;
			}
		}

		/// <summary>
		/// Boolean HasInvariantCultureName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasInvariantCultureName;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasInvariantCultureName
		{
			get
			{
				if(r_PHasInvariantCultureName == null)
				{
					r_PHasInvariantCultureName = new(this, "HasInvariantCultureName", -1);
					r_PHasInvariantCultureName.SetBelong(this.instance);
				}
				return r_PHasInvariantCultureName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo ConstructCurrentCulture()
		/// </summary>
		protected static RMethod r_MConstructCurrentCulture;
		public static RMethod RMConstructCurrentCulture
		{
			get
			{
				if(r_MConstructCurrentCulture == null)
				{
					r_MConstructCurrentCulture = new(typeof(System.Globalization.CultureInfo), "ConstructCurrentCulture", 0);
					r_MConstructCurrentCulture.SetBelong(null);
				}
				return r_MConstructCurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo ConstructCurrentUICulture()
		/// </summary>
		protected static RMethod r_MConstructCurrentUICulture;
		public static RMethod RMConstructCurrentUICulture
		{
			get
			{
				if(r_MConstructCurrentUICulture == null)
				{
					r_MConstructCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "ConstructCurrentUICulture", 0);
					r_MConstructCurrentUICulture.SetBelong(null);
				}
				return r_MConstructCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetConsoleFallbackUICulture()
		/// </summary>
		protected RMethod r_MGetConsoleFallbackUICulture;
		public virtual RMethod RMGetConsoleFallbackUICulture
		{
			get
			{
				if(r_MGetConsoleFallbackUICulture == null)
				{
					r_MGetConsoleFallbackUICulture = new(this, "GetConsoleFallbackUICulture", 0);
					r_MGetConsoleFallbackUICulture.SetBelong(this.instance);
				}
				return r_MGetConsoleFallbackUICulture;
			}
		}

		/// <summary>
		/// Void ClearCachedData()
		/// </summary>
		protected RMethod r_MClearCachedData;
		public virtual RMethod RMClearCachedData
		{
			get
			{
				if(r_MClearCachedData == null)
				{
					r_MClearCachedData = new(this, "ClearCachedData", 0);
					r_MClearCachedData.SetBelong(this.instance);
				}
				return r_MClearCachedData;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo[] GetCultures(System.Globalization.CultureTypes)
		/// </summary>
		protected static RMethod r_MGetCultures_CultureTypes;
		public static RMethod RMGetCultures_CultureTypes
		{
			get
			{
				if(r_MGetCultures_CultureTypes == null)
				{
					r_MGetCultures_CultureTypes = new(typeof(System.Globalization.CultureInfo), "GetCultures", 0, typeof(System.Globalization.CultureTypes));
					r_MGetCultures_CultureTypes.SetBelong(null);
				}
				return r_MGetCultures_CultureTypes;
			}
		}

		/// <summary>
		/// Data GetTextInfoData()
		/// </summary>
		protected RMethod r_MGetTextInfoData;
		public virtual RMethod RMGetTextInfoData
		{
			get
			{
				if(r_MGetTextInfoData == null)
				{
					r_MGetTextInfoData = new(this, "GetTextInfoData", 0);
					r_MGetTextInfoData.SetBelong(this.instance);
				}
				return r_MGetTextInfoData;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo ReadOnly(System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_MReadOnly_CultureInfo;
		public static RMethod RMReadOnly_CultureInfo
		{
			get
			{
				if(r_MReadOnly_CultureInfo == null)
				{
					r_MReadOnly_CultureInfo = new(typeof(System.Globalization.CultureInfo), "ReadOnly", 0, typeof(System.Globalization.CultureInfo));
					r_MReadOnly_CultureInfo.SetBelong(null);
				}
				return r_MReadOnly_CultureInfo;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Void CheckNeutral()
		/// </summary>
		protected RMethod r_MCheckNeutral;
		public virtual RMethod RMCheckNeutral
		{
			get
			{
				if(r_MCheckNeutral == null)
				{
					r_MCheckNeutral = new(this, "CheckNeutral", 0);
					r_MCheckNeutral.SetBelong(this.instance);
				}
				return r_MCheckNeutral;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_MGetFormat_Type;
		public virtual RMethod RMGetFormat_Type
		{
			get
			{
				if(r_MGetFormat_Type == null)
				{
					r_MGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_MGetFormat_Type.SetBelong(this.instance);
				}
				return r_MGetFormat_Type;
			}
		}

		/// <summary>
		/// Void Construct()
		/// </summary>
		protected RMethod r_MConstruct;
		public virtual RMethod RMConstruct
		{
			get
			{
				if(r_MConstruct == null)
				{
					r_MConstruct = new(this, "Construct", 0);
					r_MConstruct.SetBelong(this.instance);
				}
				return r_MConstruct;
			}
		}

		/// <summary>
		/// Boolean construct_internal_locale_from_lcid(Int32)
		/// </summary>
		protected RMethod r_Mconstruct_internal_locale_from_lcid_Int32;
		public virtual RMethod RMconstruct_internal_locale_from_lcid_Int32
		{
			get
			{
				if(r_Mconstruct_internal_locale_from_lcid_Int32 == null)
				{
					r_Mconstruct_internal_locale_from_lcid_Int32 = new(this, "construct_internal_locale_from_lcid", 0, typeof(System.Int32));
					r_Mconstruct_internal_locale_from_lcid_Int32.SetBelong(this.instance);
				}
				return r_Mconstruct_internal_locale_from_lcid_Int32;
			}
		}

		/// <summary>
		/// Boolean construct_internal_locale_from_name(System.String)
		/// </summary>
		protected RMethod r_Mconstruct_internal_locale_from_name_String;
		public virtual RMethod RMconstruct_internal_locale_from_name_String
		{
			get
			{
				if(r_Mconstruct_internal_locale_from_name_String == null)
				{
					r_Mconstruct_internal_locale_from_name_String = new(this, "construct_internal_locale_from_name", 0, typeof(System.String));
					r_Mconstruct_internal_locale_from_name_String.SetBelong(this.instance);
				}
				return r_Mconstruct_internal_locale_from_name_String;
			}
		}

		/// <summary>
		/// System.String get_current_locale_name()
		/// </summary>
		protected static RMethod r_Mget_current_locale_name;
		public static RMethod RMget_current_locale_name
		{
			get
			{
				if(r_Mget_current_locale_name == null)
				{
					r_Mget_current_locale_name = new(typeof(System.Globalization.CultureInfo), "get_current_locale_name", 0);
					r_Mget_current_locale_name.SetBelong(null);
				}
				return r_Mget_current_locale_name;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo[] internal_get_cultures(Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_Minternal_get_cultures_Boolean_Boolean_Boolean;
		public static RMethod RMinternal_get_cultures_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_Minternal_get_cultures_Boolean_Boolean_Boolean == null)
				{
					r_Minternal_get_cultures_Boolean_Boolean_Boolean = new(typeof(System.Globalization.CultureInfo), "internal_get_cultures", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_Minternal_get_cultures_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_Minternal_get_cultures_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ConstructInvariant(Boolean)
		/// </summary>
		protected RMethod r_MConstructInvariant_Boolean;
		public virtual RMethod RMConstructInvariant_Boolean
		{
			get
			{
				if(r_MConstructInvariant_Boolean == null)
				{
					r_MConstructInvariant_Boolean = new(this, "ConstructInvariant", 0, typeof(System.Boolean));
					r_MConstructInvariant_Boolean.SetBelong(this.instance);
				}
				return r_MConstructInvariant_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo CreateTextInfo(Boolean)
		/// </summary>
		protected RMethod r_MCreateTextInfo_Boolean;
		public virtual RMethod RMCreateTextInfo_Boolean
		{
			get
			{
				if(r_MCreateTextInfo_Boolean == null)
				{
					r_MCreateTextInfo_Boolean = new(this, "CreateTextInfo", 0, typeof(System.Boolean));
					r_MCreateTextInfo_Boolean.SetBelong(this.instance);
				}
				return r_MCreateTextInfo_Boolean;
			}
		}

		/// <summary>
		/// Void insert_into_shared_tables(System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_Minsert_into_shared_tables_CultureInfo;
		public static RMethod RMinsert_into_shared_tables_CultureInfo
		{
			get
			{
				if(r_Minsert_into_shared_tables_CultureInfo == null)
				{
					r_Minsert_into_shared_tables_CultureInfo = new(typeof(System.Globalization.CultureInfo), "insert_into_shared_tables", 0, typeof(System.Globalization.CultureInfo));
					r_Minsert_into_shared_tables_CultureInfo.SetBelong(null);
				}
				return r_Minsert_into_shared_tables_CultureInfo;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfo(Int32)
		/// </summary>
		protected static RMethod r_MGetCultureInfo_Int32;
		public static RMethod RMGetCultureInfo_Int32
		{
			get
			{
				if(r_MGetCultureInfo_Int32 == null)
				{
					r_MGetCultureInfo_Int32 = new(typeof(System.Globalization.CultureInfo), "GetCultureInfo", 0, typeof(System.Int32));
					r_MGetCultureInfo_Int32.SetBelong(null);
				}
				return r_MGetCultureInfo_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfo(System.String)
		/// </summary>
		protected static RMethod r_MGetCultureInfo_String;
		public static RMethod RMGetCultureInfo_String
		{
			get
			{
				if(r_MGetCultureInfo_String == null)
				{
					r_MGetCultureInfo_String = new(typeof(System.Globalization.CultureInfo), "GetCultureInfo", 0, typeof(System.String));
					r_MGetCultureInfo_String.SetBelong(null);
				}
				return r_MGetCultureInfo_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfo(System.String, System.String)
		/// </summary>
		protected static RMethod r_MGetCultureInfo_String_String;
		public static RMethod RMGetCultureInfo_String_String
		{
			get
			{
				if(r_MGetCultureInfo_String_String == null)
				{
					r_MGetCultureInfo_String_String = new(typeof(System.Globalization.CultureInfo), "GetCultureInfo", 0, typeof(System.String), typeof(System.String));
					r_MGetCultureInfo_String_String.SetBelong(null);
				}
				return r_MGetCultureInfo_String_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfoByIetfLanguageTag(System.String)
		/// </summary>
		protected static RMethod r_MGetCultureInfoByIetfLanguageTag_String;
		public static RMethod RMGetCultureInfoByIetfLanguageTag_String
		{
			get
			{
				if(r_MGetCultureInfoByIetfLanguageTag_String == null)
				{
					r_MGetCultureInfoByIetfLanguageTag_String = new(typeof(System.Globalization.CultureInfo), "GetCultureInfoByIetfLanguageTag", 0, typeof(System.String));
					r_MGetCultureInfoByIetfLanguageTag_String.SetBelong(null);
				}
				return r_MGetCultureInfoByIetfLanguageTag_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CreateCulture(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCreateCulture_String_Boolean;
		public static RMethod RMCreateCulture_String_Boolean
		{
			get
			{
				if(r_MCreateCulture_String_Boolean == null)
				{
					r_MCreateCulture_String_Boolean = new(typeof(System.Globalization.CultureInfo), "CreateCulture", 0, typeof(System.String), typeof(System.Boolean));
					r_MCreateCulture_String_Boolean.SetBelong(null);
				}
				return r_MCreateCulture_String_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CreateSpecificCulture(System.String)
		/// </summary>
		protected static RMethod r_MCreateSpecificCulture_String;
		public static RMethod RMCreateSpecificCulture_String
		{
			get
			{
				if(r_MCreateSpecificCulture_String == null)
				{
					r_MCreateSpecificCulture_String = new(typeof(System.Globalization.CultureInfo), "CreateSpecificCulture", 0, typeof(System.String));
					r_MCreateSpecificCulture_String.SetBelong(null);
				}
				return r_MCreateSpecificCulture_String;
			}
		}

		/// <summary>
		/// Boolean ConstructLocaleFromName(System.String)
		/// </summary>
		protected RMethod r_MConstructLocaleFromName_String;
		public virtual RMethod RMConstructLocaleFromName_String
		{
			get
			{
				if(r_MConstructLocaleFromName_String == null)
				{
					r_MConstructLocaleFromName_String = new(this, "ConstructLocaleFromName", 0, typeof(System.String));
					r_MConstructLocaleFromName_String.SetBelong(this.instance);
				}
				return r_MConstructLocaleFromName_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CreateSpecificCultureFromNeutral(System.String)
		/// </summary>
		protected static RMethod r_MCreateSpecificCultureFromNeutral_String;
		public static RMethod RMCreateSpecificCultureFromNeutral_String
		{
			get
			{
				if(r_MCreateSpecificCultureFromNeutral_String == null)
				{
					r_MCreateSpecificCultureFromNeutral_String = new(typeof(System.Globalization.CultureInfo), "CreateSpecificCultureFromNeutral", 0, typeof(System.String));
					r_MCreateSpecificCultureFromNeutral_String.SetBelong(null);
				}
				return r_MCreateSpecificCultureFromNeutral_String;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar CreateCalendar(Int32)
		/// </summary>
		protected static RMethod r_MCreateCalendar_Int32;
		public static RMethod RMCreateCalendar_Int32
		{
			get
			{
				if(r_MCreateCalendar_Int32 == null)
				{
					r_MCreateCalendar_Int32 = new(typeof(System.Globalization.CultureInfo), "CreateCalendar", 0, typeof(System.Int32));
					r_MCreateCalendar_Int32.SetBelong(null);
				}
				return r_MCreateCalendar_Int32;
			}
		}

		/// <summary>
		/// System.Exception CreateNotFoundException(System.String)
		/// </summary>
		protected static RMethod r_MCreateNotFoundException_String;
		public static RMethod RMCreateNotFoundException_String
		{
			get
			{
				if(r_MCreateNotFoundException_String == null)
				{
					r_MCreateNotFoundException_String = new(typeof(System.Globalization.CultureInfo), "CreateNotFoundException", 0, typeof(System.String));
					r_MCreateNotFoundException_String.SetBelong(null);
				}
				return r_MCreateNotFoundException_String;
			}
		}

		/// <summary>
		/// Void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate)
		/// </summary>
		protected static RMethod r_MInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate;
		public static RMethod RMInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate
		{
			get
			{
				if(r_MInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate == null)
				{
					r_MInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate = new(typeof(System.Globalization.CultureInfo), "InitializeUserPreferredCultureInfoInAppX", 0,  ReflectionUtils.GetType("System.Globalization.CultureInfo+OnCultureInfoChangedDelegate"));
					r_MInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate.SetBelong(null);
				}
				return r_MInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate;
			}
		}

		/// <summary>
		/// Void SetUserPreferredCultureInfoInAppX(System.String)
		/// </summary>
		protected static RMethod r_MSetUserPreferredCultureInfoInAppX_String;
		public static RMethod RMSetUserPreferredCultureInfoInAppX_String
		{
			get
			{
				if(r_MSetUserPreferredCultureInfoInAppX_String == null)
				{
					r_MSetUserPreferredCultureInfoInAppX_String = new(typeof(System.Globalization.CultureInfo), "SetUserPreferredCultureInfoInAppX", 0, typeof(System.String));
					r_MSetUserPreferredCultureInfoInAppX_String.SetBelong(null);
				}
				return r_MSetUserPreferredCultureInfoInAppX_String;
			}
		}

		/// <summary>
		/// Void OnCultureInfoChangedInAppX(System.String)
		/// </summary>
		protected static RMethod r_MOnCultureInfoChangedInAppX_String;
		public static RMethod RMOnCultureInfoChangedInAppX_String
		{
			get
			{
				if(r_MOnCultureInfoChangedInAppX_String == null)
				{
					r_MOnCultureInfoChangedInAppX_String = new(typeof(System.Globalization.CultureInfo), "OnCultureInfoChangedInAppX", 0, typeof(System.String));
					r_MOnCultureInfoChangedInAppX_String.SetBelong(null);
				}
				return r_MOnCultureInfoChangedInAppX_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
		/// </summary>
		protected static RMethod r_MGetCultureInfoForUserPreferredLanguageInAppX;
		public static RMethod RMGetCultureInfoForUserPreferredLanguageInAppX
		{
			get
			{
				if(r_MGetCultureInfoForUserPreferredLanguageInAppX == null)
				{
					r_MGetCultureInfoForUserPreferredLanguageInAppX = new(typeof(System.Globalization.CultureInfo), "GetCultureInfoForUserPreferredLanguageInAppX", 0);
					r_MGetCultureInfoForUserPreferredLanguageInAppX.SetBelong(null);
				}
				return r_MGetCultureInfoForUserPreferredLanguageInAppX;
			}
		}

		/// <summary>
		/// Void SetCultureInfoForUserPreferredLanguageInAppX(System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_MSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo;
		public static RMethod RMSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo
		{
			get
			{
				if(r_MSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo == null)
				{
					r_MSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo = new(typeof(System.Globalization.CultureInfo), "SetCultureInfoForUserPreferredLanguageInAppX", 0, typeof(System.Globalization.CultureInfo));
					r_MSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo.SetBelong(null);
				}
				return r_MSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo;
			}
		}

		/// <summary>
		/// Void CheckDomainSafetyObject(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_MCheckDomainSafetyObject_Object_Object;
		public static RMethod RMCheckDomainSafetyObject_Object_Object
		{
			get
			{
				if(r_MCheckDomainSafetyObject_Object_Object == null)
				{
					r_MCheckDomainSafetyObject_Object_Object = new(typeof(System.Globalization.CultureInfo), "CheckDomainSafetyObject", 0, typeof(System.Object), typeof(System.Object));
					r_MCheckDomainSafetyObject_Object_Object.SetBelong(null);
				}
				return r_MCheckDomainSafetyObject_Object_Object;
			}
		}

		/// <summary>
		/// Boolean VerifyCultureName(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MVerifyCultureName_String_Boolean;
		public static RMethod RMVerifyCultureName_String_Boolean
		{
			get
			{
				if(r_MVerifyCultureName_String_Boolean == null)
				{
					r_MVerifyCultureName_String_Boolean = new(typeof(System.Globalization.CultureInfo), "VerifyCultureName", 0, typeof(System.String), typeof(System.Boolean));
					r_MVerifyCultureName_String_Boolean.SetBelong(null);
				}
				return r_MVerifyCultureName_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean VerifyCultureName(System.Globalization.CultureInfo, Boolean)
		/// </summary>
		protected static RMethod r_MVerifyCultureName_CultureInfo_Boolean;
		public static RMethod RMVerifyCultureName_CultureInfo_Boolean
		{
			get
			{
				if(r_MVerifyCultureName_CultureInfo_Boolean == null)
				{
					r_MVerifyCultureName_CultureInfo_Boolean = new(typeof(System.Globalization.CultureInfo), "VerifyCultureName", 0, typeof(System.Globalization.CultureInfo), typeof(System.Boolean));
					r_MVerifyCultureName_CultureInfo_Boolean.SetBelong(null);
				}
				return r_MVerifyCultureName_CultureInfo_Boolean;
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RCultureInfo() : base("System.Globalization.CultureInfo")
        {
        }

        public RCultureInfo(System.Object instance) : base("System.Globalization.CultureInfo")
		{
            SetInstance(instance);
		}

        public RCultureInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCultureInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Globalization.CultureInfo ConstructCurrentCulture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMConstructCurrentCulture.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo ConstructCurrentUICulture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMConstructCurrentUICulture.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.Globalization.CultureInfo GetConsoleFallbackUICulture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConsoleFallbackUICulture.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual void ClearCachedData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearCachedData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.CultureInfo[] GetCultures(System.Globalization.CultureTypes @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RMGetCultures_CultureTypes.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo[])___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo.RData GetTextInfoData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTextInfoData.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo.RData(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Globalization.CultureInfo ReadOnly(System.Globalization.CultureInfo @ci)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ci};
            var ___result = RMReadOnly_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CheckNeutral()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckNeutral.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetFormat(System.Type @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RMGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Construct()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMConstruct.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean construct_internal_locale_from_lcid(System.Int32 @lcid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lcid};
            var ___result = RMconstruct_internal_locale_from_lcid_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean construct_internal_locale_from_name(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMconstruct_internal_locale_from_name_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String get_current_locale_name()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_current_locale_name.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Globalization.CultureInfo[] internal_get_cultures(System.Boolean @neutral, System.Boolean @specific, System.Boolean @installed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@neutral, @specific, @installed};
            var ___result = RMinternal_get_cultures_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo[])___result;
        }


        public virtual void ConstructInvariant(System.Boolean @read_only)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@read_only};
            var ___result = RMConstructInvariant_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Globalization.TextInfo CreateTextInfo(System.Boolean @readOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readOnly};
            var ___result = RMCreateTextInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Globalization.TextInfo)___result;
        }


        public static void insert_into_shared_tables(System.Globalization.CultureInfo @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMinsert_into_shared_tables_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.CultureInfo GetCultureInfo(System.Int32 @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMGetCultureInfo_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo GetCultureInfo(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetCultureInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo GetCultureInfo(System.String @name, System.String @altName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @altName};
            var ___result = RMGetCultureInfo_String_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo GetCultureInfoByIetfLanguageTag(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetCultureInfoByIetfLanguageTag_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo CreateCulture(System.String @name, System.Boolean @reference)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @reference};
            var ___result = RMCreateCulture_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo CreateSpecificCulture(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMCreateSpecificCulture_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.Boolean ConstructLocaleFromName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMConstructLocaleFromName_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.CultureInfo CreateSpecificCultureFromNeutral(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMCreateSpecificCultureFromNeutral_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.Calendar CreateCalendar(System.Int32 @calendarType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarType};
            var ___result = RMCreateCalendar_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.Calendar)___result;
        }


        public static System.Exception CreateNotFoundException(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMCreateNotFoundException_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public static void InitializeUserPreferredCultureInfoInAppX(Hvak.Editor.Refleaction.RSystem.RGlobalization.RCultureInfo.ROnCultureInfoChangedDelegate @onCultureInfoChangedInAppX)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@onCultureInfoChangedInAppX.Value};
            var ___result = RMInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetUserPreferredCultureInfoInAppX(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMSetUserPreferredCultureInfoInAppX_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnCultureInfoChangedInAppX(System.String @language)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@language};
            var ___result = RMOnCultureInfoChangedInAppX_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCultureInfoForUserPreferredLanguageInAppX.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static void SetCultureInfoForUserPreferredLanguageInAppX(System.Globalization.CultureInfo @cultureInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureInfo};
            var ___result = RMSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckDomainSafetyObject(System.Object @obj, System.Object @container)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @container};
            var ___result = RMCheckDomainSafetyObject_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean VerifyCultureName(System.String @cultureName, System.Boolean @throwException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureName, @throwException};
            var ___result = RMVerifyCultureName_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VerifyCultureName(System.Globalization.CultureInfo @culture, System.Boolean @throwException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @throwException};
            var ___result = RMVerifyCultureName_CultureInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
