using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CultureInfo
	/// </summary>
    public partial class RCultureInfo : RMember //
    {

		/// <summary>
		/// System.Globalization.CultureInfo invariant_culture_info
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_invariant_culture_info;
		public static RSystem.RGlobalization.RCultureInfo Rinvariant_culture_info
		{
			get
			{
				if(r_invariant_culture_info == null)
				{
					r_invariant_culture_info = new(typeof(System.Globalization.CultureInfo), "invariant_culture_info");
					r_invariant_culture_info.SetBelong(null);
				}
				return r_invariant_culture_info;
			}
		}

		/// <summary>
		/// System.Object shared_table_lock
		/// </summary>
		protected static RSystem.RObject r_shared_table_lock;
		public static RSystem.RObject Rshared_table_lock
		{
			get
			{
				if(r_shared_table_lock == null)
				{
					r_shared_table_lock = new(typeof(System.Globalization.CultureInfo), "shared_table_lock");
					r_shared_table_lock.SetBelong(null);
				}
				return r_shared_table_lock;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo default_current_culture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_default_current_culture;
		public static RSystem.RGlobalization.RCultureInfo Rdefault_current_culture
		{
			get
			{
				if(r_default_current_culture == null)
				{
					r_default_current_culture = new(typeof(System.Globalization.CultureInfo), "default_current_culture");
					r_default_current_culture.SetBelong(null);
				}
				return r_default_current_culture;
			}
		}

		/// <summary>
		/// System.Boolean m_isReadOnly
		/// </summary>
		protected RField r_m_isReadOnly;
		public virtual RField Rm_isReadOnly
		{
			get
			{
				if(r_m_isReadOnly == null)
				{
					r_m_isReadOnly = new(this, "m_isReadOnly");
					r_m_isReadOnly.SetBelong(this.instance);
				}
				return r_m_isReadOnly;
			}
		}

		/// <summary>
		/// System.Int32 cultureID
		/// </summary>
		protected RField r_cultureID;
		public virtual RField RcultureID
		{
			get
			{
				if(r_cultureID == null)
				{
					r_cultureID = new(this, "cultureID");
					r_cultureID.SetBelong(this.instance);
				}
				return r_cultureID;
			}
		}

		/// <summary>
		/// System.Int32 parent_lcid
		/// </summary>
		protected RField r_parent_lcid;
		public virtual RField Rparent_lcid
		{
			get
			{
				if(r_parent_lcid == null)
				{
					r_parent_lcid = new(this, "parent_lcid");
					r_parent_lcid.SetBelong(this.instance);
				}
				return r_parent_lcid;
			}
		}

		/// <summary>
		/// System.Int32 datetime_index
		/// </summary>
		protected RField r_datetime_index;
		public virtual RField Rdatetime_index
		{
			get
			{
				if(r_datetime_index == null)
				{
					r_datetime_index = new(this, "datetime_index");
					r_datetime_index.SetBelong(this.instance);
				}
				return r_datetime_index;
			}
		}

		/// <summary>
		/// System.Int32 number_index
		/// </summary>
		protected RField r_number_index;
		public virtual RField Rnumber_index
		{
			get
			{
				if(r_number_index == null)
				{
					r_number_index = new(this, "number_index");
					r_number_index.SetBelong(this.instance);
				}
				return r_number_index;
			}
		}

		/// <summary>
		/// System.Int32 default_calendar_type
		/// </summary>
		protected RField r_default_calendar_type;
		public virtual RField Rdefault_calendar_type
		{
			get
			{
				if(r_default_calendar_type == null)
				{
					r_default_calendar_type = new(this, "default_calendar_type");
					r_default_calendar_type.SetBelong(this.instance);
				}
				return r_default_calendar_type;
			}
		}

		/// <summary>
		/// System.Boolean m_useUserOverride
		/// </summary>
		protected RField r_m_useUserOverride;
		public virtual RField Rm_useUserOverride
		{
			get
			{
				if(r_m_useUserOverride == null)
				{
					r_m_useUserOverride = new(this, "m_useUserOverride");
					r_m_useUserOverride.SetBelong(this.instance);
				}
				return r_m_useUserOverride;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo numInfo
		/// </summary>
		protected RSystem.RGlobalization.RNumberFormatInfo r_numInfo;
		public virtual RSystem.RGlobalization.RNumberFormatInfo RnumInfo
		{
			get
			{
				if(r_numInfo == null)
				{
					r_numInfo = new(this, "numInfo");
					r_numInfo.SetBelong(this.instance);
				}
				return r_numInfo;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo dateTimeInfo
		/// </summary>
		protected RSystem.RGlobalization.RDateTimeFormatInfo r_dateTimeInfo;
		public virtual RSystem.RGlobalization.RDateTimeFormatInfo RdateTimeInfo
		{
			get
			{
				if(r_dateTimeInfo == null)
				{
					r_dateTimeInfo = new(this, "dateTimeInfo");
					r_dateTimeInfo.SetBelong(this.instance);
				}
				return r_dateTimeInfo;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo textInfo
		/// </summary>
		protected RSystem.RGlobalization.RTextInfo r_textInfo;
		public virtual RSystem.RGlobalization.RTextInfo RtextInfo
		{
			get
			{
				if(r_textInfo == null)
				{
					r_textInfo = new(this, "textInfo");
					r_textInfo.SetBelong(this.instance);
				}
				return r_textInfo;
			}
		}

		/// <summary>
		/// System.String m_name
		/// </summary>
		protected RField r_m_name;
		public virtual RField Rm_name
		{
			get
			{
				if(r_m_name == null)
				{
					r_m_name = new(this, "m_name");
					r_m_name.SetBelong(this.instance);
				}
				return r_m_name;
			}
		}

		/// <summary>
		/// System.String englishname
		/// </summary>
		protected RField r_englishname;
		public virtual RField Renglishname
		{
			get
			{
				if(r_englishname == null)
				{
					r_englishname = new(this, "englishname");
					r_englishname.SetBelong(this.instance);
				}
				return r_englishname;
			}
		}

		/// <summary>
		/// System.String nativename
		/// </summary>
		protected RField r_nativename;
		public virtual RField Rnativename
		{
			get
			{
				if(r_nativename == null)
				{
					r_nativename = new(this, "nativename");
					r_nativename.SetBelong(this.instance);
				}
				return r_nativename;
			}
		}

		/// <summary>
		/// System.String iso3lang
		/// </summary>
		protected RField r_iso3lang;
		public virtual RField Riso3lang
		{
			get
			{
				if(r_iso3lang == null)
				{
					r_iso3lang = new(this, "iso3lang");
					r_iso3lang.SetBelong(this.instance);
				}
				return r_iso3lang;
			}
		}

		/// <summary>
		/// System.String iso2lang
		/// </summary>
		protected RField r_iso2lang;
		public virtual RField Riso2lang
		{
			get
			{
				if(r_iso2lang == null)
				{
					r_iso2lang = new(this, "iso2lang");
					r_iso2lang.SetBelong(this.instance);
				}
				return r_iso2lang;
			}
		}

		/// <summary>
		/// System.String win3lang
		/// </summary>
		protected RField r_win3lang;
		public virtual RField Rwin3lang
		{
			get
			{
				if(r_win3lang == null)
				{
					r_win3lang = new(this, "win3lang");
					r_win3lang.SetBelong(this.instance);
				}
				return r_win3lang;
			}
		}

		/// <summary>
		/// System.String territory
		/// </summary>
		protected RField r_territory;
		public virtual RField Rterritory
		{
			get
			{
				if(r_territory == null)
				{
					r_territory = new(this, "territory");
					r_territory.SetBelong(this.instance);
				}
				return r_territory;
			}
		}

		/// <summary>
		/// System.String[] native_calendar_names
		/// </summary>
		protected RFieldArray<RField> r_native_calendar_names;
		public virtual RFieldArray<RField> Rnative_calendar_names
		{
			get
			{
				if(r_native_calendar_names == null)
				{
					r_native_calendar_names = new(this, "native_calendar_names");
					r_native_calendar_names.SetBelong(this.instance);
				}
				return r_native_calendar_names;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo compareInfo
		/// </summary>
		protected RSystem.RGlobalization.RCompareInfo r_compareInfo;
		public virtual RSystem.RGlobalization.RCompareInfo RcompareInfo
		{
			get
			{
				if(r_compareInfo == null)
				{
					r_compareInfo = new(this, "compareInfo");
					r_compareInfo.SetBelong(this.instance);
				}
				return r_compareInfo;
			}
		}

		/// <summary>
		/// System.Void* textinfo_data
		/// </summary>
		protected RFieldPointer<RField> r_textinfo_data;
		public virtual RFieldPointer<RField> Rtextinfo_data
		{
			get
			{
				if(r_textinfo_data == null)
				{
					r_textinfo_data = new(this, "textinfo_data");
					r_textinfo_data.SetBelong(this.instance);
				}
				return r_textinfo_data;
			}
		}

		/// <summary>
		/// System.Int32 m_dataItem
		/// </summary>
		protected RField r_m_dataItem;
		public virtual RField Rm_dataItem
		{
			get
			{
				if(r_m_dataItem == null)
				{
					r_m_dataItem = new(this, "m_dataItem");
					r_m_dataItem.SetBelong(this.instance);
				}
				return r_m_dataItem;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar calendar
		/// </summary>
		protected RSystem.RGlobalization.RCalendar r_calendar;
		public virtual RSystem.RGlobalization.RCalendar Rcalendar
		{
			get
			{
				if(r_calendar == null)
				{
					r_calendar = new(this, "calendar");
					r_calendar.SetBelong(this.instance);
				}
				return r_calendar;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo parent_culture
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_parent_culture;
		public virtual RSystem.RGlobalization.RCultureInfo Rparent_culture
		{
			get
			{
				if(r_parent_culture == null)
				{
					r_parent_culture = new(this, "parent_culture");
					r_parent_culture.SetBelong(this.instance);
				}
				return r_parent_culture;
			}
		}

		/// <summary>
		/// System.Boolean constructed
		/// </summary>
		protected RField r_constructed;
		public virtual RField Rconstructed
		{
			get
			{
				if(r_constructed == null)
				{
					r_constructed = new(this, "constructed");
					r_constructed.SetBelong(this.instance);
				}
				return r_constructed;
			}
		}

		/// <summary>
		/// System.Byte[] cached_serialized_form
		/// </summary>
		protected RFieldArray<RField> r_cached_serialized_form;
		public virtual RFieldArray<RField> Rcached_serialized_form
		{
			get
			{
				if(r_cached_serialized_form == null)
				{
					r_cached_serialized_form = new(this, "cached_serialized_form");
					r_cached_serialized_form.SetBelong(this.instance);
				}
				return r_cached_serialized_form;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData m_cultureData
		/// </summary>
		protected RSystem.RGlobalization.RCultureData r_m_cultureData;
		public virtual RSystem.RGlobalization.RCultureData Rm_cultureData
		{
			get
			{
				if(r_m_cultureData == null)
				{
					r_m_cultureData = new(this, "m_cultureData");
					r_m_cultureData.SetBelong(this.instance);
				}
				return r_m_cultureData;
			}
		}

		/// <summary>
		/// System.Boolean m_isInherited
		/// </summary>
		protected RField r_m_isInherited;
		public virtual RField Rm_isInherited
		{
			get
			{
				if(r_m_isInherited == null)
				{
					r_m_isInherited = new(this, "m_isInherited");
					r_m_isInherited.SetBelong(this.instance);
				}
				return r_m_isInherited;
			}
		}

		/// <summary>
		/// System.Int32 InvariantCultureId
		/// </summary>
		protected static RField r_InvariantCultureId;
		public static RField RInvariantCultureId
		{
			get
			{
				if(r_InvariantCultureId == null)
				{
					r_InvariantCultureId = new(typeof(System.Globalization.CultureInfo), "InvariantCultureId");
					r_InvariantCultureId.SetBelong(null);
				}
				return r_InvariantCultureId;
			}
		}

		/// <summary>
		/// System.Int32 CalendarTypeBits
		/// </summary>
		protected static RField r_CalendarTypeBits;
		public static RField RCalendarTypeBits
		{
			get
			{
				if(r_CalendarTypeBits == null)
				{
					r_CalendarTypeBits = new(typeof(System.Globalization.CultureInfo), "CalendarTypeBits");
					r_CalendarTypeBits.SetBelong(null);
				}
				return r_CalendarTypeBits;
			}
		}

		/// <summary>
		/// System.Int32 LOCALE_INVARIANT
		/// </summary>
		protected static RField r_LOCALE_INVARIANT;
		public static RField RLOCALE_INVARIANT
		{
			get
			{
				if(r_LOCALE_INVARIANT == null)
				{
					r_LOCALE_INVARIANT = new(typeof(System.Globalization.CultureInfo), "LOCALE_INVARIANT");
					r_LOCALE_INVARIANT.SetBelong(null);
				}
				return r_LOCALE_INVARIANT;
			}
		}

		/// <summary>
		/// System.String MSG_READONLY
		/// </summary>
		protected static RField r_MSG_READONLY;
		public static RField RMSG_READONLY
		{
			get
			{
				if(r_MSG_READONLY == null)
				{
					r_MSG_READONLY = new(typeof(System.Globalization.CultureInfo), "MSG_READONLY");
					r_MSG_READONLY.SetBelong(null);
				}
				return r_MSG_READONLY;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo s_DefaultThreadCurrentUICulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_s_DefaultThreadCurrentUICulture;
		public static RSystem.RGlobalization.RCultureInfo Rs_DefaultThreadCurrentUICulture
		{
			get
			{
				if(r_s_DefaultThreadCurrentUICulture == null)
				{
					r_s_DefaultThreadCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "s_DefaultThreadCurrentUICulture");
					r_s_DefaultThreadCurrentUICulture.SetBelong(null);
				}
				return r_s_DefaultThreadCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo s_DefaultThreadCurrentCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_s_DefaultThreadCurrentCulture;
		public static RSystem.RGlobalization.RCultureInfo Rs_DefaultThreadCurrentCulture
		{
			get
			{
				if(r_s_DefaultThreadCurrentCulture == null)
				{
					r_s_DefaultThreadCurrentCulture = new(typeof(System.Globalization.CultureInfo), "s_DefaultThreadCurrentCulture");
					r_s_DefaultThreadCurrentCulture.SetBelong(null);
				}
				return r_s_DefaultThreadCurrentCulture;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Globalization.CultureInfo] shared_by_number
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RGlobalization.RCultureInfo> r_shared_by_number;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RGlobalization.RCultureInfo> Rshared_by_number
		{
			get
			{
				if(r_shared_by_number == null)
				{
					r_shared_by_number = new(typeof(System.Globalization.CultureInfo), "shared_by_number");
					r_shared_by_number.SetBelong(null);
				}
				return r_shared_by_number;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Globalization.CultureInfo] shared_by_name
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RGlobalization.RCultureInfo> r_shared_by_name;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RGlobalization.RCultureInfo> Rshared_by_name
		{
			get
			{
				if(r_shared_by_name == null)
				{
					r_shared_by_name = new(typeof(System.Globalization.CultureInfo), "shared_by_name");
					r_shared_by_name.SetBelong(null);
				}
				return r_shared_by_name;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo s_UserPreferredCultureInfoInAppX
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_s_UserPreferredCultureInfoInAppX;
		public static RSystem.RGlobalization.RCultureInfo Rs_UserPreferredCultureInfoInAppX
		{
			get
			{
				if(r_s_UserPreferredCultureInfoInAppX == null)
				{
					r_s_UserPreferredCultureInfoInAppX = new(typeof(System.Globalization.CultureInfo), "s_UserPreferredCultureInfoInAppX");
					r_s_UserPreferredCultureInfoInAppX.SetBelong(null);
				}
				return r_s_UserPreferredCultureInfoInAppX;
			}
		}

		/// <summary>
		/// System.Boolean IsTaiwanSku
		/// </summary>
		protected static RField r_IsTaiwanSku;
		public static RField RIsTaiwanSku
		{
			get
			{
				if(r_IsTaiwanSku == null)
				{
					r_IsTaiwanSku = new(typeof(System.Globalization.CultureInfo), "IsTaiwanSku");
					r_IsTaiwanSku.SetBelong(null);
				}
				return r_IsTaiwanSku;
			}
		}

		/// <summary>
		/// System.Globalization.CultureData _cultureData
		/// </summary>
		protected RSystem.RGlobalization.RCultureData r__cultureData;
		public virtual RSystem.RGlobalization.RCultureData R_cultureData
		{
			get
			{
				if(r__cultureData == null)
				{
					r__cultureData = new(this, "_cultureData", -1);
					r__cultureData.SetBelong(this.instance);
				}
				return r__cultureData;
			}
		}

		/// <summary>
		/// Boolean _isInherited
		/// </summary>
		protected RProperty r__isInherited;
		public virtual RProperty R_isInherited
		{
			get
			{
				if(r__isInherited == null)
				{
					r__isInherited = new(this, "_isInherited", -1);
					r__isInherited.SetBelong(this.instance);
				}
				return r__isInherited;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo InvariantCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_InvariantCulture;
		public static RSystem.RGlobalization.RCultureInfo RInvariantCulture
		{
			get
			{
				if(r_InvariantCulture == null)
				{
					r_InvariantCulture = new(typeof(System.Globalization.CultureInfo), "InvariantCulture", -1);
					r_InvariantCulture.SetBelong(null);
				}
				return r_InvariantCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_CurrentCulture;
		public static RSystem.RGlobalization.RCultureInfo RCurrentCulture
		{
			get
			{
				if(r_CurrentCulture == null)
				{
					r_CurrentCulture = new(typeof(System.Globalization.CultureInfo), "CurrentCulture", -1);
					r_CurrentCulture.SetBelong(null);
				}
				return r_CurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CurrentUICulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_CurrentUICulture;
		public static RSystem.RGlobalization.RCultureInfo RCurrentUICulture
		{
			get
			{
				if(r_CurrentUICulture == null)
				{
					r_CurrentUICulture = new(typeof(System.Globalization.CultureInfo), "CurrentUICulture", -1);
					r_CurrentUICulture.SetBelong(null);
				}
				return r_CurrentUICulture;
			}
		}

		/// <summary>
		/// System.String Territory
		/// </summary>
		protected RProperty r_Territory;
		public virtual RProperty RTerritory
		{
			get
			{
				if(r_Territory == null)
				{
					r_Territory = new(this, "Territory", -1);
					r_Territory.SetBelong(this.instance);
				}
				return r_Territory;
			}
		}

		/// <summary>
		/// System.String _name
		/// </summary>
		protected RProperty r__name;
		public virtual RProperty R_name
		{
			get
			{
				if(r__name == null)
				{
					r__name = new(this, "_name", -1);
					r__name.SetBelong(this.instance);
				}
				return r__name;
			}
		}

		/// <summary>
		/// System.Globalization.CultureTypes CultureTypes
		/// </summary>
		protected RProperty r_CultureTypes;
		public virtual RProperty RCultureTypes
		{
			get
			{
				if(r_CultureTypes == null)
				{
					r_CultureTypes = new(this, "CultureTypes", -1);
					r_CultureTypes.SetBelong(this.instance);
				}
				return r_CultureTypes;
			}
		}

		/// <summary>
		/// System.String IetfLanguageTag
		/// </summary>
		protected RProperty r_IetfLanguageTag;
		public virtual RProperty RIetfLanguageTag
		{
			get
			{
				if(r_IetfLanguageTag == null)
				{
					r_IetfLanguageTag = new(this, "IetfLanguageTag", -1);
					r_IetfLanguageTag.SetBelong(this.instance);
				}
				return r_IetfLanguageTag;
			}
		}

		/// <summary>
		/// Int32 KeyboardLayoutId
		/// </summary>
		protected RProperty r_KeyboardLayoutId;
		public virtual RProperty RKeyboardLayoutId
		{
			get
			{
				if(r_KeyboardLayoutId == null)
				{
					r_KeyboardLayoutId = new(this, "KeyboardLayoutId", -1);
					r_KeyboardLayoutId.SetBelong(this.instance);
				}
				return r_KeyboardLayoutId;
			}
		}

		/// <summary>
		/// Int32 LCID
		/// </summary>
		protected RProperty r_LCID;
		public virtual RProperty RLCID
		{
			get
			{
				if(r_LCID == null)
				{
					r_LCID = new(this, "LCID", -1);
					r_LCID.SetBelong(this.instance);
				}
				return r_LCID;
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
		/// System.String NativeName
		/// </summary>
		protected RProperty r_NativeName;
		public virtual RProperty RNativeName
		{
			get
			{
				if(r_NativeName == null)
				{
					r_NativeName = new(this, "NativeName", -1);
					r_NativeName.SetBelong(this.instance);
				}
				return r_NativeName;
			}
		}

		/// <summary>
		/// System.String NativeCalendarName
		/// </summary>
		protected RProperty r_NativeCalendarName;
		public virtual RProperty RNativeCalendarName
		{
			get
			{
				if(r_NativeCalendarName == null)
				{
					r_NativeCalendarName = new(this, "NativeCalendarName", -1);
					r_NativeCalendarName.SetBelong(this.instance);
				}
				return r_NativeCalendarName;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar Calendar
		/// </summary>
		protected RSystem.RGlobalization.RCalendar r_Calendar;
		public virtual RSystem.RGlobalization.RCalendar RCalendar
		{
			get
			{
				if(r_Calendar == null)
				{
					r_Calendar = new(this, "Calendar", -1);
					r_Calendar.SetBelong(this.instance);
				}
				return r_Calendar;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar[] OptionalCalendars
		/// </summary>
		protected RPropertyArray<RSystem.RGlobalization.RCalendar> r_OptionalCalendars;
		public virtual RPropertyArray<RSystem.RGlobalization.RCalendar> ROptionalCalendars
		{
			get
			{
				if(r_OptionalCalendars == null)
				{
					r_OptionalCalendars = new(this, "OptionalCalendars", -1);
					r_OptionalCalendars.SetBelong(this.instance);
				}
				return r_OptionalCalendars;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo Parent
		/// </summary>
		protected RSystem.RGlobalization.RCultureInfo r_Parent;
		public virtual RSystem.RGlobalization.RCultureInfo RParent
		{
			get
			{
				if(r_Parent == null)
				{
					r_Parent = new(this, "Parent", -1);
					r_Parent.SetBelong(this.instance);
				}
				return r_Parent;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo TextInfo
		/// </summary>
		protected RSystem.RGlobalization.RTextInfo r_TextInfo;
		public virtual RSystem.RGlobalization.RTextInfo RTextInfo
		{
			get
			{
				if(r_TextInfo == null)
				{
					r_TextInfo = new(this, "TextInfo", -1);
					r_TextInfo.SetBelong(this.instance);
				}
				return r_TextInfo;
			}
		}

		/// <summary>
		/// System.String ThreeLetterISOLanguageName
		/// </summary>
		protected RProperty r_ThreeLetterISOLanguageName;
		public virtual RProperty RThreeLetterISOLanguageName
		{
			get
			{
				if(r_ThreeLetterISOLanguageName == null)
				{
					r_ThreeLetterISOLanguageName = new(this, "ThreeLetterISOLanguageName", -1);
					r_ThreeLetterISOLanguageName.SetBelong(this.instance);
				}
				return r_ThreeLetterISOLanguageName;
			}
		}

		/// <summary>
		/// System.String ThreeLetterWindowsLanguageName
		/// </summary>
		protected RProperty r_ThreeLetterWindowsLanguageName;
		public virtual RProperty RThreeLetterWindowsLanguageName
		{
			get
			{
				if(r_ThreeLetterWindowsLanguageName == null)
				{
					r_ThreeLetterWindowsLanguageName = new(this, "ThreeLetterWindowsLanguageName", -1);
					r_ThreeLetterWindowsLanguageName.SetBelong(this.instance);
				}
				return r_ThreeLetterWindowsLanguageName;
			}
		}

		/// <summary>
		/// System.String TwoLetterISOLanguageName
		/// </summary>
		protected RProperty r_TwoLetterISOLanguageName;
		public virtual RProperty RTwoLetterISOLanguageName
		{
			get
			{
				if(r_TwoLetterISOLanguageName == null)
				{
					r_TwoLetterISOLanguageName = new(this, "TwoLetterISOLanguageName", -1);
					r_TwoLetterISOLanguageName.SetBelong(this.instance);
				}
				return r_TwoLetterISOLanguageName;
			}
		}

		/// <summary>
		/// Boolean UseUserOverride
		/// </summary>
		protected RProperty r_UseUserOverride;
		public virtual RProperty RUseUserOverride
		{
			get
			{
				if(r_UseUserOverride == null)
				{
					r_UseUserOverride = new(this, "UseUserOverride", -1);
					r_UseUserOverride.SetBelong(this.instance);
				}
				return r_UseUserOverride;
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
		/// Boolean IsNeutralCulture
		/// </summary>
		protected RProperty r_IsNeutralCulture;
		public virtual RProperty RIsNeutralCulture
		{
			get
			{
				if(r_IsNeutralCulture == null)
				{
					r_IsNeutralCulture = new(this, "IsNeutralCulture", -1);
					r_IsNeutralCulture.SetBelong(this.instance);
				}
				return r_IsNeutralCulture;
			}
		}

		/// <summary>
		/// System.Globalization.NumberFormatInfo NumberFormat
		/// </summary>
		protected RSystem.RGlobalization.RNumberFormatInfo r_NumberFormat;
		public virtual RSystem.RGlobalization.RNumberFormatInfo RNumberFormat
		{
			get
			{
				if(r_NumberFormat == null)
				{
					r_NumberFormat = new(this, "NumberFormat", -1);
					r_NumberFormat.SetBelong(this.instance);
				}
				return r_NumberFormat;
			}
		}

		/// <summary>
		/// System.Globalization.DateTimeFormatInfo DateTimeFormat
		/// </summary>
		protected RSystem.RGlobalization.RDateTimeFormatInfo r_DateTimeFormat;
		public virtual RSystem.RGlobalization.RDateTimeFormatInfo RDateTimeFormat
		{
			get
			{
				if(r_DateTimeFormat == null)
				{
					r_DateTimeFormat = new(this, "DateTimeFormat", -1);
					r_DateTimeFormat.SetBelong(this.instance);
				}
				return r_DateTimeFormat;
			}
		}

		/// <summary>
		/// System.String DisplayName
		/// </summary>
		protected RProperty r_DisplayName;
		public virtual RProperty RDisplayName
		{
			get
			{
				if(r_DisplayName == null)
				{
					r_DisplayName = new(this, "DisplayName", -1);
					r_DisplayName.SetBelong(this.instance);
				}
				return r_DisplayName;
			}
		}

		/// <summary>
		/// System.String EnglishName
		/// </summary>
		protected RProperty r_EnglishName;
		public virtual RProperty REnglishName
		{
			get
			{
				if(r_EnglishName == null)
				{
					r_EnglishName = new(this, "EnglishName", -1);
					r_EnglishName.SetBelong(this.instance);
				}
				return r_EnglishName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo InstalledUICulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_InstalledUICulture;
		public static RSystem.RGlobalization.RCultureInfo RInstalledUICulture
		{
			get
			{
				if(r_InstalledUICulture == null)
				{
					r_InstalledUICulture = new(typeof(System.Globalization.CultureInfo), "InstalledUICulture", -1);
					r_InstalledUICulture.SetBelong(null);
				}
				return r_InstalledUICulture;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Int32 CalendarType
		/// </summary>
		protected RProperty r_CalendarType;
		public virtual RProperty RCalendarType
		{
			get
			{
				if(r_CalendarType == null)
				{
					r_CalendarType = new(this, "CalendarType", -1);
					r_CalendarType.SetBelong(this.instance);
				}
				return r_CalendarType;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo DefaultThreadCurrentCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_DefaultThreadCurrentCulture;
		public static RSystem.RGlobalization.RCultureInfo RDefaultThreadCurrentCulture
		{
			get
			{
				if(r_DefaultThreadCurrentCulture == null)
				{
					r_DefaultThreadCurrentCulture = new(typeof(System.Globalization.CultureInfo), "DefaultThreadCurrentCulture", -1);
					r_DefaultThreadCurrentCulture.SetBelong(null);
				}
				return r_DefaultThreadCurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo DefaultThreadCurrentUICulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_DefaultThreadCurrentUICulture;
		public static RSystem.RGlobalization.RCultureInfo RDefaultThreadCurrentUICulture
		{
			get
			{
				if(r_DefaultThreadCurrentUICulture == null)
				{
					r_DefaultThreadCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "DefaultThreadCurrentUICulture", -1);
					r_DefaultThreadCurrentUICulture.SetBelong(null);
				}
				return r_DefaultThreadCurrentUICulture;
			}
		}

		/// <summary>
		/// System.String SortName
		/// </summary>
		protected RProperty r_SortName;
		public virtual RProperty RSortName
		{
			get
			{
				if(r_SortName == null)
				{
					r_SortName = new(this, "SortName", -1);
					r_SortName.SetBelong(this.instance);
				}
				return r_SortName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo UserDefaultUICulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_UserDefaultUICulture;
		public static RSystem.RGlobalization.RCultureInfo RUserDefaultUICulture
		{
			get
			{
				if(r_UserDefaultUICulture == null)
				{
					r_UserDefaultUICulture = new(typeof(System.Globalization.CultureInfo), "UserDefaultUICulture", -1);
					r_UserDefaultUICulture.SetBelong(null);
				}
				return r_UserDefaultUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo UserDefaultCulture
		/// </summary>
		protected static RSystem.RGlobalization.RCultureInfo r_UserDefaultCulture;
		public static RSystem.RGlobalization.RCultureInfo RUserDefaultCulture
		{
			get
			{
				if(r_UserDefaultCulture == null)
				{
					r_UserDefaultCulture = new(typeof(System.Globalization.CultureInfo), "UserDefaultCulture", -1);
					r_UserDefaultCulture.SetBelong(null);
				}
				return r_UserDefaultCulture;
			}
		}

		/// <summary>
		/// Boolean HasInvariantCultureName
		/// </summary>
		protected RProperty r_HasInvariantCultureName;
		public virtual RProperty RHasInvariantCultureName
		{
			get
			{
				if(r_HasInvariantCultureName == null)
				{
					r_HasInvariantCultureName = new(this, "HasInvariantCultureName", -1);
					r_HasInvariantCultureName.SetBelong(this.instance);
				}
				return r_HasInvariantCultureName;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo ConstructCurrentCulture()
		/// </summary>
		protected static RMethod r_RConstructCurrentCulture;
		public static RMethod RConstructCurrentCulture
		{
			get
			{
				if(r_RConstructCurrentCulture == null)
				{
					r_RConstructCurrentCulture = new(typeof(System.Globalization.CultureInfo), "ConstructCurrentCulture", 0);
					r_RConstructCurrentCulture.SetBelong(null);
				}
				return r_RConstructCurrentCulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo ConstructCurrentUICulture()
		/// </summary>
		protected static RMethod r_RConstructCurrentUICulture;
		public static RMethod RConstructCurrentUICulture
		{
			get
			{
				if(r_RConstructCurrentUICulture == null)
				{
					r_RConstructCurrentUICulture = new(typeof(System.Globalization.CultureInfo), "ConstructCurrentUICulture", 0);
					r_RConstructCurrentUICulture.SetBelong(null);
				}
				return r_RConstructCurrentUICulture;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetConsoleFallbackUICulture()
		/// </summary>
		protected RMethod r_RGetConsoleFallbackUICulture;
		public virtual RMethod RGetConsoleFallbackUICulture
		{
			get
			{
				if(r_RGetConsoleFallbackUICulture == null)
				{
					r_RGetConsoleFallbackUICulture = new(this, "GetConsoleFallbackUICulture", 0);
					r_RGetConsoleFallbackUICulture.SetBelong(this.instance);
				}
				return r_RGetConsoleFallbackUICulture;
			}
		}

		/// <summary>
		/// Void ClearCachedData()
		/// </summary>
		protected RMethod r_RClearCachedData;
		public virtual RMethod RClearCachedData
		{
			get
			{
				if(r_RClearCachedData == null)
				{
					r_RClearCachedData = new(this, "ClearCachedData", 0);
					r_RClearCachedData.SetBelong(this.instance);
				}
				return r_RClearCachedData;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
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
		/// System.Globalization.CultureInfo[] GetCultures(System.Globalization.CultureTypes)
		/// </summary>
		protected static RMethod r_RGetCultures_CultureTypes;
		public static RMethod RGetCultures_CultureTypes
		{
			get
			{
				if(r_RGetCultures_CultureTypes == null)
				{
					r_RGetCultures_CultureTypes = new(typeof(System.Globalization.CultureInfo), "GetCultures", 0, typeof(System.Globalization.CultureTypes));
					r_RGetCultures_CultureTypes.SetBelong(null);
				}
				return r_RGetCultures_CultureTypes;
			}
		}

		/// <summary>
		/// Data GetTextInfoData()
		/// </summary>
		protected RMethod r_RGetTextInfoData;
		public virtual RMethod RGetTextInfoData
		{
			get
			{
				if(r_RGetTextInfoData == null)
				{
					r_RGetTextInfoData = new(this, "GetTextInfoData", 0);
					r_RGetTextInfoData.SetBelong(this.instance);
				}
				return r_RGetTextInfoData;
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
		/// System.Globalization.CultureInfo ReadOnly(System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_RReadOnly_CultureInfo;
		public static RMethod RReadOnly_CultureInfo
		{
			get
			{
				if(r_RReadOnly_CultureInfo == null)
				{
					r_RReadOnly_CultureInfo = new(typeof(System.Globalization.CultureInfo), "ReadOnly", 0, typeof(System.Globalization.CultureInfo));
					r_RReadOnly_CultureInfo.SetBelong(null);
				}
				return r_RReadOnly_CultureInfo;
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
		/// Void CheckNeutral()
		/// </summary>
		protected RMethod r_RCheckNeutral;
		public virtual RMethod RCheckNeutral
		{
			get
			{
				if(r_RCheckNeutral == null)
				{
					r_RCheckNeutral = new(this, "CheckNeutral", 0);
					r_RCheckNeutral.SetBelong(this.instance);
				}
				return r_RCheckNeutral;
			}
		}

		/// <summary>
		/// System.Object GetFormat(System.Type)
		/// </summary>
		protected RMethod r_RGetFormat_Type;
		public virtual RMethod RGetFormat_Type
		{
			get
			{
				if(r_RGetFormat_Type == null)
				{
					r_RGetFormat_Type = new(this, "GetFormat", 0, typeof(System.Type));
					r_RGetFormat_Type.SetBelong(this.instance);
				}
				return r_RGetFormat_Type;
			}
		}

		/// <summary>
		/// Void Construct()
		/// </summary>
		protected RMethod r_RConstruct;
		public virtual RMethod RConstruct
		{
			get
			{
				if(r_RConstruct == null)
				{
					r_RConstruct = new(this, "Construct", 0);
					r_RConstruct.SetBelong(this.instance);
				}
				return r_RConstruct;
			}
		}

		/// <summary>
		/// Boolean construct_internal_locale_from_lcid(Int32)
		/// </summary>
		protected RMethod r_Rconstruct_internal_locale_from_lcid_Int32;
		public virtual RMethod Rconstruct_internal_locale_from_lcid_Int32
		{
			get
			{
				if(r_Rconstruct_internal_locale_from_lcid_Int32 == null)
				{
					r_Rconstruct_internal_locale_from_lcid_Int32 = new(this, "construct_internal_locale_from_lcid", 0, typeof(System.Int32));
					r_Rconstruct_internal_locale_from_lcid_Int32.SetBelong(this.instance);
				}
				return r_Rconstruct_internal_locale_from_lcid_Int32;
			}
		}

		/// <summary>
		/// Boolean construct_internal_locale_from_name(System.String)
		/// </summary>
		protected RMethod r_Rconstruct_internal_locale_from_name_String;
		public virtual RMethod Rconstruct_internal_locale_from_name_String
		{
			get
			{
				if(r_Rconstruct_internal_locale_from_name_String == null)
				{
					r_Rconstruct_internal_locale_from_name_String = new(this, "construct_internal_locale_from_name", 0, typeof(System.String));
					r_Rconstruct_internal_locale_from_name_String.SetBelong(this.instance);
				}
				return r_Rconstruct_internal_locale_from_name_String;
			}
		}

		/// <summary>
		/// System.String get_current_locale_name()
		/// </summary>
		protected static RMethod r_Rget_current_locale_name;
		public static RMethod Rget_current_locale_name
		{
			get
			{
				if(r_Rget_current_locale_name == null)
				{
					r_Rget_current_locale_name = new(typeof(System.Globalization.CultureInfo), "get_current_locale_name", 0);
					r_Rget_current_locale_name.SetBelong(null);
				}
				return r_Rget_current_locale_name;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo[] internal_get_cultures(Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_Rinternal_get_cultures_Boolean_Boolean_Boolean;
		public static RMethod Rinternal_get_cultures_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_Rinternal_get_cultures_Boolean_Boolean_Boolean == null)
				{
					r_Rinternal_get_cultures_Boolean_Boolean_Boolean = new(typeof(System.Globalization.CultureInfo), "internal_get_cultures", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_Rinternal_get_cultures_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_Rinternal_get_cultures_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ConstructInvariant(Boolean)
		/// </summary>
		protected RMethod r_RConstructInvariant_Boolean;
		public virtual RMethod RConstructInvariant_Boolean
		{
			get
			{
				if(r_RConstructInvariant_Boolean == null)
				{
					r_RConstructInvariant_Boolean = new(this, "ConstructInvariant", 0, typeof(System.Boolean));
					r_RConstructInvariant_Boolean.SetBelong(this.instance);
				}
				return r_RConstructInvariant_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.TextInfo CreateTextInfo(Boolean)
		/// </summary>
		protected RMethod r_RCreateTextInfo_Boolean;
		public virtual RMethod RCreateTextInfo_Boolean
		{
			get
			{
				if(r_RCreateTextInfo_Boolean == null)
				{
					r_RCreateTextInfo_Boolean = new(this, "CreateTextInfo", 0, typeof(System.Boolean));
					r_RCreateTextInfo_Boolean.SetBelong(this.instance);
				}
				return r_RCreateTextInfo_Boolean;
			}
		}

		/// <summary>
		/// Void insert_into_shared_tables(System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_Rinsert_into_shared_tables_CultureInfo;
		public static RMethod Rinsert_into_shared_tables_CultureInfo
		{
			get
			{
				if(r_Rinsert_into_shared_tables_CultureInfo == null)
				{
					r_Rinsert_into_shared_tables_CultureInfo = new(typeof(System.Globalization.CultureInfo), "insert_into_shared_tables", 0, typeof(System.Globalization.CultureInfo));
					r_Rinsert_into_shared_tables_CultureInfo.SetBelong(null);
				}
				return r_Rinsert_into_shared_tables_CultureInfo;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfo(Int32)
		/// </summary>
		protected static RMethod r_RGetCultureInfo_Int32;
		public static RMethod RGetCultureInfo_Int32
		{
			get
			{
				if(r_RGetCultureInfo_Int32 == null)
				{
					r_RGetCultureInfo_Int32 = new(typeof(System.Globalization.CultureInfo), "GetCultureInfo", 0, typeof(System.Int32));
					r_RGetCultureInfo_Int32.SetBelong(null);
				}
				return r_RGetCultureInfo_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfo(System.String)
		/// </summary>
		protected static RMethod r_RGetCultureInfo_String;
		public static RMethod RGetCultureInfo_String
		{
			get
			{
				if(r_RGetCultureInfo_String == null)
				{
					r_RGetCultureInfo_String = new(typeof(System.Globalization.CultureInfo), "GetCultureInfo", 0, typeof(System.String));
					r_RGetCultureInfo_String.SetBelong(null);
				}
				return r_RGetCultureInfo_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfo(System.String, System.String)
		/// </summary>
		protected static RMethod r_RGetCultureInfo_String_String;
		public static RMethod RGetCultureInfo_String_String
		{
			get
			{
				if(r_RGetCultureInfo_String_String == null)
				{
					r_RGetCultureInfo_String_String = new(typeof(System.Globalization.CultureInfo), "GetCultureInfo", 0, typeof(System.String), typeof(System.String));
					r_RGetCultureInfo_String_String.SetBelong(null);
				}
				return r_RGetCultureInfo_String_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfoByIetfLanguageTag(System.String)
		/// </summary>
		protected static RMethod r_RGetCultureInfoByIetfLanguageTag_String;
		public static RMethod RGetCultureInfoByIetfLanguageTag_String
		{
			get
			{
				if(r_RGetCultureInfoByIetfLanguageTag_String == null)
				{
					r_RGetCultureInfoByIetfLanguageTag_String = new(typeof(System.Globalization.CultureInfo), "GetCultureInfoByIetfLanguageTag", 0, typeof(System.String));
					r_RGetCultureInfoByIetfLanguageTag_String.SetBelong(null);
				}
				return r_RGetCultureInfoByIetfLanguageTag_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CreateCulture(System.String, Boolean)
		/// </summary>
		protected static RMethod r_RCreateCulture_String_Boolean;
		public static RMethod RCreateCulture_String_Boolean
		{
			get
			{
				if(r_RCreateCulture_String_Boolean == null)
				{
					r_RCreateCulture_String_Boolean = new(typeof(System.Globalization.CultureInfo), "CreateCulture", 0, typeof(System.String), typeof(System.Boolean));
					r_RCreateCulture_String_Boolean.SetBelong(null);
				}
				return r_RCreateCulture_String_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CreateSpecificCulture(System.String)
		/// </summary>
		protected static RMethod r_RCreateSpecificCulture_String;
		public static RMethod RCreateSpecificCulture_String
		{
			get
			{
				if(r_RCreateSpecificCulture_String == null)
				{
					r_RCreateSpecificCulture_String = new(typeof(System.Globalization.CultureInfo), "CreateSpecificCulture", 0, typeof(System.String));
					r_RCreateSpecificCulture_String.SetBelong(null);
				}
				return r_RCreateSpecificCulture_String;
			}
		}

		/// <summary>
		/// Boolean ConstructLocaleFromName(System.String)
		/// </summary>
		protected RMethod r_RConstructLocaleFromName_String;
		public virtual RMethod RConstructLocaleFromName_String
		{
			get
			{
				if(r_RConstructLocaleFromName_String == null)
				{
					r_RConstructLocaleFromName_String = new(this, "ConstructLocaleFromName", 0, typeof(System.String));
					r_RConstructLocaleFromName_String.SetBelong(this.instance);
				}
				return r_RConstructLocaleFromName_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo CreateSpecificCultureFromNeutral(System.String)
		/// </summary>
		protected static RMethod r_RCreateSpecificCultureFromNeutral_String;
		public static RMethod RCreateSpecificCultureFromNeutral_String
		{
			get
			{
				if(r_RCreateSpecificCultureFromNeutral_String == null)
				{
					r_RCreateSpecificCultureFromNeutral_String = new(typeof(System.Globalization.CultureInfo), "CreateSpecificCultureFromNeutral", 0, typeof(System.String));
					r_RCreateSpecificCultureFromNeutral_String.SetBelong(null);
				}
				return r_RCreateSpecificCultureFromNeutral_String;
			}
		}

		/// <summary>
		/// System.Globalization.Calendar CreateCalendar(Int32)
		/// </summary>
		protected static RMethod r_RCreateCalendar_Int32;
		public static RMethod RCreateCalendar_Int32
		{
			get
			{
				if(r_RCreateCalendar_Int32 == null)
				{
					r_RCreateCalendar_Int32 = new(typeof(System.Globalization.CultureInfo), "CreateCalendar", 0, typeof(System.Int32));
					r_RCreateCalendar_Int32.SetBelong(null);
				}
				return r_RCreateCalendar_Int32;
			}
		}

		/// <summary>
		/// System.Exception CreateNotFoundException(System.String)
		/// </summary>
		protected static RMethod r_RCreateNotFoundException_String;
		public static RMethod RCreateNotFoundException_String
		{
			get
			{
				if(r_RCreateNotFoundException_String == null)
				{
					r_RCreateNotFoundException_String = new(typeof(System.Globalization.CultureInfo), "CreateNotFoundException", 0, typeof(System.String));
					r_RCreateNotFoundException_String.SetBelong(null);
				}
				return r_RCreateNotFoundException_String;
			}
		}

		/// <summary>
		/// Void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate)
		/// </summary>
		protected static RMethod r_RInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate;
		public static RMethod RInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate
		{
			get
			{
				if(r_RInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate == null)
				{
					r_RInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate = new(typeof(System.Globalization.CultureInfo), "InitializeUserPreferredCultureInfoInAppX", 0,  ReleactionUtils.GetType("System.Globalization.CultureInfo+OnCultureInfoChangedDelegate"));
					r_RInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate.SetBelong(null);
				}
				return r_RInitializeUserPreferredCultureInfoInAppX_OnCultureInfoChangedDelegate;
			}
		}

		/// <summary>
		/// Void SetUserPreferredCultureInfoInAppX(System.String)
		/// </summary>
		protected static RMethod r_RSetUserPreferredCultureInfoInAppX_String;
		public static RMethod RSetUserPreferredCultureInfoInAppX_String
		{
			get
			{
				if(r_RSetUserPreferredCultureInfoInAppX_String == null)
				{
					r_RSetUserPreferredCultureInfoInAppX_String = new(typeof(System.Globalization.CultureInfo), "SetUserPreferredCultureInfoInAppX", 0, typeof(System.String));
					r_RSetUserPreferredCultureInfoInAppX_String.SetBelong(null);
				}
				return r_RSetUserPreferredCultureInfoInAppX_String;
			}
		}

		/// <summary>
		/// Void OnCultureInfoChangedInAppX(System.String)
		/// </summary>
		protected static RMethod r_ROnCultureInfoChangedInAppX_String;
		public static RMethod ROnCultureInfoChangedInAppX_String
		{
			get
			{
				if(r_ROnCultureInfoChangedInAppX_String == null)
				{
					r_ROnCultureInfoChangedInAppX_String = new(typeof(System.Globalization.CultureInfo), "OnCultureInfoChangedInAppX", 0, typeof(System.String));
					r_ROnCultureInfoChangedInAppX_String.SetBelong(null);
				}
				return r_ROnCultureInfoChangedInAppX_String;
			}
		}

		/// <summary>
		/// System.Globalization.CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
		/// </summary>
		protected static RMethod r_RGetCultureInfoForUserPreferredLanguageInAppX;
		public static RMethod RGetCultureInfoForUserPreferredLanguageInAppX
		{
			get
			{
				if(r_RGetCultureInfoForUserPreferredLanguageInAppX == null)
				{
					r_RGetCultureInfoForUserPreferredLanguageInAppX = new(typeof(System.Globalization.CultureInfo), "GetCultureInfoForUserPreferredLanguageInAppX", 0);
					r_RGetCultureInfoForUserPreferredLanguageInAppX.SetBelong(null);
				}
				return r_RGetCultureInfoForUserPreferredLanguageInAppX;
			}
		}

		/// <summary>
		/// Void SetCultureInfoForUserPreferredLanguageInAppX(System.Globalization.CultureInfo)
		/// </summary>
		protected static RMethod r_RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo;
		public static RMethod RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo
		{
			get
			{
				if(r_RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo == null)
				{
					r_RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo = new(typeof(System.Globalization.CultureInfo), "SetCultureInfoForUserPreferredLanguageInAppX", 0, typeof(System.Globalization.CultureInfo));
					r_RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo.SetBelong(null);
				}
				return r_RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo;
			}
		}

		/// <summary>
		/// Void CheckDomainSafetyObject(System.Object, System.Object)
		/// </summary>
		protected static RMethod r_RCheckDomainSafetyObject_Object_Object;
		public static RMethod RCheckDomainSafetyObject_Object_Object
		{
			get
			{
				if(r_RCheckDomainSafetyObject_Object_Object == null)
				{
					r_RCheckDomainSafetyObject_Object_Object = new(typeof(System.Globalization.CultureInfo), "CheckDomainSafetyObject", 0, typeof(System.Object), typeof(System.Object));
					r_RCheckDomainSafetyObject_Object_Object.SetBelong(null);
				}
				return r_RCheckDomainSafetyObject_Object_Object;
			}
		}

		/// <summary>
		/// Boolean VerifyCultureName(System.String, Boolean)
		/// </summary>
		protected static RMethod r_RVerifyCultureName_String_Boolean;
		public static RMethod RVerifyCultureName_String_Boolean
		{
			get
			{
				if(r_RVerifyCultureName_String_Boolean == null)
				{
					r_RVerifyCultureName_String_Boolean = new(typeof(System.Globalization.CultureInfo), "VerifyCultureName", 0, typeof(System.String), typeof(System.Boolean));
					r_RVerifyCultureName_String_Boolean.SetBelong(null);
				}
				return r_RVerifyCultureName_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean VerifyCultureName(System.Globalization.CultureInfo, Boolean)
		/// </summary>
		protected static RMethod r_RVerifyCultureName_CultureInfo_Boolean;
		public static RMethod RVerifyCultureName_CultureInfo_Boolean
		{
			get
			{
				if(r_RVerifyCultureName_CultureInfo_Boolean == null)
				{
					r_RVerifyCultureName_CultureInfo_Boolean = new(typeof(System.Globalization.CultureInfo), "VerifyCultureName", 0, typeof(System.Globalization.CultureInfo), typeof(System.Boolean));
					r_RVerifyCultureName_CultureInfo_Boolean.SetBelong(null);
				}
				return r_RVerifyCultureName_CultureInfo_Boolean;
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
            var ___result = RConstructCurrentCulture.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo ConstructCurrentUICulture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstructCurrentUICulture.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.Globalization.CultureInfo GetConsoleFallbackUICulture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConsoleFallbackUICulture.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual void ClearCachedData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCachedData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.CultureInfo[] GetCultures(System.Globalization.CultureTypes  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RGetCultures_CultureTypes.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo[])___result;
        }


        public virtual System.Object GetTextInfoData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTextInfoData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Globalization.CultureInfo ReadOnly(System.Globalization.CultureInfo  @ci)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ci};
            var ___result = RReadOnly_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void CheckNeutral()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckNeutral.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetFormat(System.Type  @formatType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@formatType};
            var ___result = RGetFormat_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Construct()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstruct.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean construct_internal_locale_from_lcid(System.Int32  @lcid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lcid};
            var ___result = Rconstruct_internal_locale_from_lcid_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean construct_internal_locale_from_name(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = Rconstruct_internal_locale_from_name_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String get_current_locale_name()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_current_locale_name.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Globalization.CultureInfo[] internal_get_cultures(System.Boolean  @neutral, System.Boolean  @specific, System.Boolean  @installed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@neutral, @specific, @installed};
            var ___result = Rinternal_get_cultures_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo[])___result;
        }


        public virtual void ConstructInvariant(System.Boolean  @read_only)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@read_only};
            var ___result = RConstructInvariant_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Globalization.TextInfo CreateTextInfo(System.Boolean  @readOnly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@readOnly};
            var ___result = RCreateTextInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Globalization.TextInfo)___result;
        }


        public static void insert_into_shared_tables(System.Globalization.CultureInfo  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = Rinsert_into_shared_tables_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.CultureInfo GetCultureInfo(System.Int32  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RGetCultureInfo_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo GetCultureInfo(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetCultureInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo GetCultureInfo(System.String  @name, System.String  @altName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @altName};
            var ___result = RGetCultureInfo_String_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo GetCultureInfoByIetfLanguageTag(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetCultureInfoByIetfLanguageTag_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo CreateCulture(System.String  @name, System.Boolean  @reference)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @reference};
            var ___result = RCreateCulture_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.CultureInfo CreateSpecificCulture(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreateSpecificCulture_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public virtual System.Boolean ConstructLocaleFromName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RConstructLocaleFromName_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Globalization.CultureInfo CreateSpecificCultureFromNeutral(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreateSpecificCultureFromNeutral_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static System.Globalization.Calendar CreateCalendar(System.Int32  @calendarType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calendarType};
            var ___result = RCreateCalendar_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.Calendar)___result;
        }


        public static System.Exception CreateNotFoundException(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreateNotFoundException_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }



        public static void SetUserPreferredCultureInfoInAppX(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RSetUserPreferredCultureInfoInAppX_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void OnCultureInfoChangedInAppX(System.String  @language)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@language};
            var ___result = ROnCultureInfoChangedInAppX_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Globalization.CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCultureInfoForUserPreferredLanguageInAppX.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CultureInfo)___result;
        }


        public static void SetCultureInfoForUserPreferredLanguageInAppX(System.Globalization.CultureInfo  @cultureInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureInfo};
            var ___result = RSetCultureInfoForUserPreferredLanguageInAppX_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public static void CheckDomainSafetyObject(System.Object  @obj, System.Object  @container)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @container};
            var ___result = RCheckDomainSafetyObject_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean VerifyCultureName(System.String  @cultureName, System.Boolean  @throwException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cultureName, @throwException};
            var ___result = RVerifyCultureName_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean VerifyCultureName(System.Globalization.CultureInfo  @culture, System.Boolean  @throwException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @throwException};
            var ___result = RVerifyCultureName_CultureInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
