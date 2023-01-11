using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CompareInfo
	/// </summary>
    public partial class RCompareInfo : RMember //
    {

		/// <summary>
		/// System.Globalization.CompareOptions ValidIndexMaskOffFlags
		/// </summary>
		protected static RField r_ValidIndexMaskOffFlags;
		public static RField RValidIndexMaskOffFlags
		{
			get
			{
				if(r_ValidIndexMaskOffFlags == null)
				{
					r_ValidIndexMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidIndexMaskOffFlags");
					r_ValidIndexMaskOffFlags.SetBelong(null);
				}
				return r_ValidIndexMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions ValidCompareMaskOffFlags
		/// </summary>
		protected static RField r_ValidCompareMaskOffFlags;
		public static RField RValidCompareMaskOffFlags
		{
			get
			{
				if(r_ValidCompareMaskOffFlags == null)
				{
					r_ValidCompareMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidCompareMaskOffFlags");
					r_ValidCompareMaskOffFlags.SetBelong(null);
				}
				return r_ValidCompareMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions ValidHashCodeOfStringMaskOffFlags
		/// </summary>
		protected static RField r_ValidHashCodeOfStringMaskOffFlags;
		public static RField RValidHashCodeOfStringMaskOffFlags
		{
			get
			{
				if(r_ValidHashCodeOfStringMaskOffFlags == null)
				{
					r_ValidHashCodeOfStringMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidHashCodeOfStringMaskOffFlags");
					r_ValidHashCodeOfStringMaskOffFlags.SetBelong(null);
				}
				return r_ValidHashCodeOfStringMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions ValidSortkeyCtorMaskOffFlags
		/// </summary>
		protected static RField r_ValidSortkeyCtorMaskOffFlags;
		public static RField RValidSortkeyCtorMaskOffFlags
		{
			get
			{
				if(r_ValidSortkeyCtorMaskOffFlags == null)
				{
					r_ValidSortkeyCtorMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidSortkeyCtorMaskOffFlags");
					r_ValidSortkeyCtorMaskOffFlags.SetBelong(null);
				}
				return r_ValidSortkeyCtorMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo Invariant
		/// </summary>
		protected static RSystem.RGlobalization.RCompareInfo r_Invariant;
		public static RSystem.RGlobalization.RCompareInfo RInvariant
		{
			get
			{
				if(r_Invariant == null)
				{
					r_Invariant = new(typeof(System.Globalization.CompareInfo), "Invariant");
					r_Invariant.SetBelong(null);
				}
				return r_Invariant;
			}
		}

		/// <summary>
		/// System.String m_name
		/// </summary>
		protected RSystem.RString r_m_name;
		public virtual RSystem.RString Rm_name
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
		/// System.String _sortName
		/// </summary>
		protected RSystem.RString r__sortName;
		public virtual RSystem.RString R_sortName
		{
			get
			{
				if(r__sortName == null)
				{
					r__sortName = new(this, "_sortName");
					r__sortName.SetBelong(this.instance);
				}
				return r__sortName;
			}
		}

		/// <summary>
		/// System.Globalization.SortVersion m_SortVersion
		/// </summary>
		protected RSystem.RGlobalization.RSortVersion r_m_SortVersion;
		public virtual RSystem.RGlobalization.RSortVersion Rm_SortVersion
		{
			get
			{
				if(r_m_SortVersion == null)
				{
					r_m_SortVersion = new(this, "m_SortVersion");
					r_m_SortVersion.SetBelong(this.instance);
				}
				return r_m_SortVersion;
			}
		}

		/// <summary>
		/// System.Int32 culture
		/// </summary>
		protected RSystem.RInt32 r_culture;
		public virtual RSystem.RInt32 Rculture
		{
			get
			{
				if(r_culture == null)
				{
					r_culture = new(this, "culture");
					r_culture.SetBelong(this.instance);
				}
				return r_culture;
			}
		}

		/// <summary>
		/// System.Globalization.ISimpleCollator collator
		/// </summary>
		protected RSystem.RGlobalization.RISimpleCollator r_collator;
		public virtual RSystem.RGlobalization.RISimpleCollator Rcollator
		{
			get
			{
				if(r_collator == null)
				{
					r_collator = new(this, "collator");
					r_collator.SetBelong(this.instance);
				}
				return r_collator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Globalization.ISimpleCollator] collators
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RSystem.RGlobalization.RISimpleCollator> r_collators;
		public static RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RSystem.RGlobalization.RISimpleCollator> Rcollators
		{
			get
			{
				if(r_collators == null)
				{
					r_collators = new(typeof(System.Globalization.CompareInfo), "collators");
					r_collators.SetBelong(null);
				}
				return r_collators;
			}
		}

		/// <summary>
		/// System.Boolean managedCollation
		/// </summary>
		protected static RSystem.RBoolean r_managedCollation;
		public static RSystem.RBoolean RmanagedCollation
		{
			get
			{
				if(r_managedCollation == null)
				{
					r_managedCollation = new(typeof(System.Globalization.CompareInfo), "managedCollation");
					r_managedCollation.SetBelong(null);
				}
				return r_managedCollation;
			}
		}

		/// <summary>
		/// System.Boolean managedCollationChecked
		/// </summary>
		protected static RSystem.RBoolean r_managedCollationChecked;
		public static RSystem.RBoolean RmanagedCollationChecked
		{
			get
			{
				if(r_managedCollationChecked == null)
				{
					r_managedCollationChecked = new(typeof(System.Globalization.CompareInfo), "managedCollationChecked");
					r_managedCollationChecked.SetBelong(null);
				}
				return r_managedCollationChecked;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_Name;
		public virtual RSystem.RString RName
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
		/// System.Globalization.SortVersion Version
		/// </summary>
		protected RSystem.RGlobalization.RSortVersion r_Version;
		public virtual RSystem.RGlobalization.RSortVersion RVersion
		{
			get
			{
				if(r_Version == null)
				{
					r_Version = new(this, "Version", -1);
					r_Version.SetBelong(this.instance);
				}
				return r_Version;
			}
		}

		/// <summary>
		/// Int32 LCID
		/// </summary>
		protected RSystem.RInt32 r_LCID;
		public virtual RSystem.RInt32 RLCID
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
		/// Boolean UseManagedCollation
		/// </summary>
		protected static RSystem.RBoolean r_UseManagedCollation;
		public static RSystem.RBoolean RUseManagedCollation
		{
			get
			{
				if(r_UseManagedCollation == null)
				{
					r_UseManagedCollation = new(typeof(System.Globalization.CompareInfo), "UseManagedCollation", -1);
					r_UseManagedCollation.SetBelong(null);
				}
				return r_UseManagedCollation;
			}
		}

		/// <summary>
		/// Int32 InvariantIndexOf(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_InvariantIndexOf_String_String_Int32_Int32_Boolean;
		public static RMethod RInvariantIndexOf_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_InvariantIndexOf_String_String_Int32_Int32_Boolean == null)
				{
					r_InvariantIndexOf_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_InvariantIndexOf_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_InvariantIndexOf_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantIndexOf(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected static RMethod r_InvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public static RMethod RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_InvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_InvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantIndexOf", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_InvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(null);
				}
				return r_InvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantLastIndexOf(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_InvariantLastIndexOf_String_String_Int32_Int32_Boolean;
		public static RMethod RInvariantLastIndexOf_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_InvariantLastIndexOf_String_String_Int32_Int32_Boolean == null)
				{
					r_InvariantLastIndexOf_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantLastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_InvariantLastIndexOf_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_InvariantLastIndexOf_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantFindString(Char*, Int32, Char*, Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_InvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean;
		public static RMethod RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean
		{
			get
			{
				if(r_InvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean == null)
				{
					r_InvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantFindString", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_InvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_InvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Char InvariantToUpper(Char)
		/// </summary>
		protected static RMethod r_InvariantToUpper_Char;
		public static RMethod RInvariantToUpper_Char
		{
			get
			{
				if(r_InvariantToUpper_Char == null)
				{
					r_InvariantToUpper_Char = new(typeof(System.Globalization.CompareInfo), "InvariantToUpper", 0, typeof(System.Char));
					r_InvariantToUpper_Char.SetBelong(null);
				}
				return r_InvariantToUpper_Char;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey InvariantCreateSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_InvariantCreateSortKey_String_CompareOptions;
		public virtual RMethod RInvariantCreateSortKey_String_CompareOptions
		{
			get
			{
				if(r_InvariantCreateSortKey_String_CompareOptions == null)
				{
					r_InvariantCreateSortKey_String_CompareOptions = new(this, "InvariantCreateSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_InvariantCreateSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_InvariantCreateSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(Int32, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_GetCompareInfo_Int32_Assembly;
		public static RMethod RGetCompareInfo_Int32_Assembly
		{
			get
			{
				if(r_GetCompareInfo_Int32_Assembly == null)
				{
					r_GetCompareInfo_Int32_Assembly = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.Int32), typeof(System.Reflection.Assembly));
					r_GetCompareInfo_Int32_Assembly.SetBelong(null);
				}
				return r_GetCompareInfo_Int32_Assembly;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(System.String, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_GetCompareInfo_String_Assembly;
		public static RMethod RGetCompareInfo_String_Assembly
		{
			get
			{
				if(r_GetCompareInfo_String_Assembly == null)
				{
					r_GetCompareInfo_String_Assembly = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.String), typeof(System.Reflection.Assembly));
					r_GetCompareInfo_String_Assembly.SetBelong(null);
				}
				return r_GetCompareInfo_String_Assembly;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(Int32)
		/// </summary>
		protected static RMethod r_GetCompareInfo_Int32;
		public static RMethod RGetCompareInfo_Int32
		{
			get
			{
				if(r_GetCompareInfo_Int32 == null)
				{
					r_GetCompareInfo_Int32 = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.Int32));
					r_GetCompareInfo_Int32.SetBelong(null);
				}
				return r_GetCompareInfo_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(System.String)
		/// </summary>
		protected static RMethod r_GetCompareInfo_String;
		public static RMethod RGetCompareInfo_String
		{
			get
			{
				if(r_GetCompareInfo_String == null)
				{
					r_GetCompareInfo_String = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.String));
					r_GetCompareInfo_String.SetBelong(null);
				}
				return r_GetCompareInfo_String;
			}
		}

		/// <summary>
		/// Boolean IsSortable(Char)
		/// </summary>
		protected static RMethod r_IsSortable_Char;
		public static RMethod RIsSortable_Char
		{
			get
			{
				if(r_IsSortable_Char == null)
				{
					r_IsSortable_Char = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.Char));
					r_IsSortable_Char.SetBelong(null);
				}
				return r_IsSortable_Char;
			}
		}

		/// <summary>
		/// Boolean IsSortable(System.String)
		/// </summary>
		protected static RMethod r_IsSortable_String;
		public static RMethod RIsSortable_String
		{
			get
			{
				if(r_IsSortable_String == null)
				{
					r_IsSortable_String = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.String));
					r_IsSortable_String.SetBelong(null);
				}
				return r_IsSortable_String;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserializing_StreamingContext;
		public virtual RMethod ROnDeserializing_StreamingContext
		{
			get
			{
				if(r_OnDeserializing_StreamingContext == null)
				{
					r_OnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserializing_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_OnDeserialized_StreamingContext == null)
				{
					r_OnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized()
		/// </summary>
		protected RMethod r_OnDeserialized;
		public virtual RMethod ROnDeserialized
		{
			get
			{
				if(r_OnDeserialized == null)
				{
					r_OnDeserialized = new(this, "OnDeserialized", 0);
					r_OnDeserialized.SetBelong(this.instance);
				}
				return r_OnDeserialized;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnSerializing_StreamingContext;
		public virtual RMethod ROnSerializing_StreamingContext
		{
			get
			{
				if(r_OnSerializing_StreamingContext == null)
				{
					r_OnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnSerializing_StreamingContext.SetBelong(this.instance);
				}
				return r_OnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String)
		/// </summary>
		protected RMethod r_Compare_String_String;
		public virtual RMethod RCompare_String_String
		{
			get
			{
				if(r_Compare_String_String == null)
				{
					r_Compare_String_String = new(this, "Compare", 0, typeof(System.String), typeof(System.String));
					r_Compare_String_String.SetBelong(this.instance);
				}
				return r_Compare_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Compare_String_String_CompareOptions;
		public virtual RMethod RCompare_String_String_CompareOptions
		{
			get
			{
				if(r_Compare_String_String_CompareOptions == null)
				{
					r_Compare_String_String_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_Compare_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_Compare_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.ReadOnlySpan`1[System.Char], System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Compare_ReadOnlySpan_d_Char_p__String_CompareOptions;
		public virtual RMethod RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions
		{
			get
			{
				if(r_Compare_ReadOnlySpan_d_Char_p__String_CompareOptions == null)
				{
					r_Compare_ReadOnlySpan_d_Char_p__String_CompareOptions = new(this, "Compare", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_Compare_ReadOnlySpan_d_Char_p__String_CompareOptions.SetBelong(this.instance);
				}
				return r_Compare_ReadOnlySpan_d_Char_p__String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareOptionNone(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_CompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public virtual RMethod RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_CompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_CompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(this, "CompareOptionNone", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_CompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_CompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 CompareOptionIgnoreCase(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_CompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public virtual RMethod RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_CompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_CompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(this, "CompareOptionIgnoreCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_CompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_CompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_Compare_String_Int32_Int32_String_Int32_Int32;
		public virtual RMethod RCompare_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_Compare_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_Compare_String_Int32_Int32_String_Int32_Int32 = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_Compare_String_Int32_Int32_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_Compare_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Compare_String_Int32_String_Int32_CompareOptions;
		public virtual RMethod RCompare_String_Int32_String_Int32_CompareOptions
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32_CompareOptions == null)
				{
					r_Compare_String_Int32_String_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Compare_String_Int32_String_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_Compare_String_Int32_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32)
		/// </summary>
		protected RMethod r_Compare_String_Int32_String_Int32;
		public virtual RMethod RCompare_String_Int32_String_Int32
		{
			get
			{
				if(r_Compare_String_Int32_String_Int32 == null)
				{
					r_Compare_String_Int32_String_Int32 = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32));
					r_Compare_String_Int32_String_Int32.SetBelong(this.instance);
				}
				return r_Compare_String_Int32_String_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Compare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Compare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_Compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCase(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_CompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32;
		public static RMethod RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_CompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_CompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32 = new(typeof(System.Globalization.CompareInfo), "CompareOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_CompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_CompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCase(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_CompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_CompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_CompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(typeof(System.Globalization.CompareInfo), "CompareOrdinalIgnoreCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_CompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_CompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IsPrefix_String_String_CompareOptions;
		public virtual RMethod RIsPrefix_String_String_CompareOptions
		{
			get
			{
				if(r_IsPrefix_String_String_CompareOptions == null)
				{
					r_IsPrefix_String_String_CompareOptions = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_IsPrefix_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_IsPrefix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_IsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_IsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IsPrefix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_IsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_IsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String)
		/// </summary>
		protected RMethod r_IsPrefix_String_String;
		public virtual RMethod RIsPrefix_String_String
		{
			get
			{
				if(r_IsPrefix_String_String == null)
				{
					r_IsPrefix_String_String = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String));
					r_IsPrefix_String_String.SetBelong(this.instance);
				}
				return r_IsPrefix_String_String;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IsSuffix_String_String_CompareOptions;
		public virtual RMethod RIsSuffix_String_String_CompareOptions
		{
			get
			{
				if(r_IsSuffix_String_String_CompareOptions == null)
				{
					r_IsSuffix_String_String_CompareOptions = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_IsSuffix_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_IsSuffix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_IsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_IsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IsSuffix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_IsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_IsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String)
		/// </summary>
		protected RMethod r_IsSuffix_String_String;
		public virtual RMethod RIsSuffix_String_String
		{
			get
			{
				if(r_IsSuffix_String_String == null)
				{
					r_IsSuffix_String_String = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String));
					r_IsSuffix_String_String.SetBelong(this.instance);
				}
				return r_IsSuffix_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char)
		/// </summary>
		protected RMethod r_IndexOf_String_Char;
		public virtual RMethod RIndexOf_String_Char
		{
			get
			{
				if(r_IndexOf_String_Char == null)
				{
					r_IndexOf_String_Char = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char));
					r_IndexOf_String_Char.SetBelong(this.instance);
				}
				return r_IndexOf_String_Char;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String)
		/// </summary>
		protected RMethod r_IndexOf_String_String;
		public virtual RMethod RIndexOf_String_String
		{
			get
			{
				if(r_IndexOf_String_String == null)
				{
					r_IndexOf_String_String = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String));
					r_IndexOf_String_String.SetBelong(this.instance);
				}
				return r_IndexOf_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_String_Char_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_IndexOf_String_Char_CompareOptions == null)
				{
					r_IndexOf_String_Char_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_IndexOf_String_Char_CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_String_String_CompareOptions;
		public virtual RMethod RIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_IndexOf_String_String_CompareOptions == null)
				{
					r_IndexOf_String_String_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_IndexOf_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32)
		/// </summary>
		protected RMethod r_IndexOf_String_Char_Int32;
		public virtual RMethod RIndexOf_String_Char_Int32
		{
			get
			{
				if(r_IndexOf_String_Char_Int32 == null)
				{
					r_IndexOf_String_Char_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32));
					r_IndexOf_String_Char_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_String_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_IndexOf_String_String_Int32;
		public virtual RMethod RIndexOf_String_String_Int32
		{
			get
			{
				if(r_IndexOf_String_String_Int32 == null)
				{
					r_IndexOf_String_String_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_IndexOf_String_String_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_String_String_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_String_Char_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_Int32_CompareOptions
		{
			get
			{
				if(r_IndexOf_String_Char_Int32_CompareOptions == null)
				{
					r_IndexOf_String_Char_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_IndexOf_String_Char_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_String_Char_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_String_String_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_String_Int32_CompareOptions
		{
			get
			{
				if(r_IndexOf_String_String_Int32_CompareOptions == null)
				{
					r_IndexOf_String_String_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_IndexOf_String_String_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_String_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOf_String_Char_Int32_Int32;
		public virtual RMethod RIndexOf_String_Char_Int32_Int32
		{
			get
			{
				if(r_IndexOf_String_Char_Int32_Int32 == null)
				{
					r_IndexOf_String_Char_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_String_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_String_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_IndexOf_String_String_Int32_Int32;
		public virtual RMethod RIndexOf_String_String_Int32_Int32
		{
			get
			{
				if(r_IndexOf_String_String_Int32_Int32 == null)
				{
					r_IndexOf_String_String_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_IndexOf_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_IndexOf_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_IndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_IndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_IndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_IndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_IndexOf_String_String_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_IndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinal(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_IndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_IndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_IndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(this, "IndexOfOrdinal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_IndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_IndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_IndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_IndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_IndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IndexOf", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_IndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_IndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_IndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer;
		public virtual RMethod RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer
		{
			get
			{
				if(r_IndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer == null)
				{
					r_IndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_IndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer.SetBelong(this.instance);
				}
				return r_IndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinal(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_IndexOfOrdinal_String_String_Int32_Int32_Boolean;
		public virtual RMethod RIndexOfOrdinal_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_IndexOfOrdinal_String_String_Int32_Int32_Boolean == null)
				{
					r_IndexOfOrdinal_String_String_Int32_Int32_Boolean = new(this, "IndexOfOrdinal", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_IndexOfOrdinal_String_String_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_IndexOfOrdinal_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Char;
		public virtual RMethod RLastIndexOf_String_Char
		{
			get
			{
				if(r_LastIndexOf_String_Char == null)
				{
					r_LastIndexOf_String_Char = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char));
					r_LastIndexOf_String_Char.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Char;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String)
		/// </summary>
		protected RMethod r_LastIndexOf_String_String;
		public virtual RMethod RLastIndexOf_String_String
		{
			get
			{
				if(r_LastIndexOf_String_String == null)
				{
					r_LastIndexOf_String_String = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String));
					r_LastIndexOf_String_String.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_String;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Char_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_LastIndexOf_String_Char_CompareOptions == null)
				{
					r_LastIndexOf_String_Char_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_LastIndexOf_String_Char_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOf_String_String_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_LastIndexOf_String_String_CompareOptions == null)
				{
					r_LastIndexOf_String_String_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_LastIndexOf_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Char_Int32;
		public virtual RMethod RLastIndexOf_String_Char_Int32
		{
			get
			{
				if(r_LastIndexOf_String_Char_Int32 == null)
				{
					r_LastIndexOf_String_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32));
					r_LastIndexOf_String_Char_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_String_String_Int32;
		public virtual RMethod RLastIndexOf_String_String_Int32
		{
			get
			{
				if(r_LastIndexOf_String_String_Int32 == null)
				{
					r_LastIndexOf_String_String_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_LastIndexOf_String_String_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_String_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Char_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_Int32_CompareOptions
		{
			get
			{
				if(r_LastIndexOf_String_Char_Int32_CompareOptions == null)
				{
					r_LastIndexOf_String_Char_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_LastIndexOf_String_Char_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Char_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOf_String_String_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_Int32_CompareOptions
		{
			get
			{
				if(r_LastIndexOf_String_String_Int32_CompareOptions == null)
				{
					r_LastIndexOf_String_String_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_LastIndexOf_String_String_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Char_Int32_Int32;
		public virtual RMethod RLastIndexOf_String_Char_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_String_Char_Int32_Int32 == null)
				{
					r_LastIndexOf_String_Char_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_String_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_LastIndexOf_String_String_Int32_Int32;
		public virtual RMethod RLastIndexOf_String_String_Int32_Int32
		{
			get
			{
				if(r_LastIndexOf_String_String_Int32_Int32 == null)
				{
					r_LastIndexOf_String_String_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_LastIndexOf_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_LastIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_LastIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_LastIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_LastIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_LastIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_LastIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfOrdinal(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_LastIndexOfOrdinal_String_String_Int32_Int32_Boolean;
		public virtual RMethod RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_LastIndexOfOrdinal_String_String_Int32_Int32_Boolean == null)
				{
					r_LastIndexOfOrdinal_String_String_Int32_Int32_Boolean = new(this, "LastIndexOfOrdinal", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_LastIndexOfOrdinal_String_String_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_LastIndexOfOrdinal_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_GetSortKey_String_CompareOptions;
		public virtual RMethod RGetSortKey_String_CompareOptions
		{
			get
			{
				if(r_GetSortKey_String_CompareOptions == null)
				{
					r_GetSortKey_String_CompareOptions = new(this, "GetSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_GetSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_GetSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String)
		/// </summary>
		protected RMethod r_GetSortKey_String;
		public virtual RMethod RGetSortKey_String
		{
			get
			{
				if(r_GetSortKey_String == null)
				{
					r_GetSortKey_String = new(this, "GetSortKey", 0, typeof(System.String));
					r_GetSortKey_String.SetBelong(this.instance);
				}
				return r_GetSortKey_String;
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
		/// Int32 GetIgnoreCaseHash(System.String)
		/// </summary>
		protected static RMethod r_GetIgnoreCaseHash_String;
		public static RMethod RGetIgnoreCaseHash_String
		{
			get
			{
				if(r_GetIgnoreCaseHash_String == null)
				{
					r_GetIgnoreCaseHash_String = new(typeof(System.Globalization.CompareInfo), "GetIgnoreCaseHash", 0, typeof(System.String));
					r_GetIgnoreCaseHash_String.SetBelong(null);
				}
				return r_GetIgnoreCaseHash_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfString(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_GetHashCodeOfString_String_CompareOptions;
		public virtual RMethod RGetHashCodeOfString_String_CompareOptions
		{
			get
			{
				if(r_GetHashCodeOfString_String_CompareOptions == null)
				{
					r_GetHashCodeOfString_String_CompareOptions = new(this, "GetHashCodeOfString", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_GetHashCodeOfString_String_CompareOptions.SetBelong(this.instance);
				}
				return r_GetHashCodeOfString_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_GetHashCode_String_CompareOptions;
		public virtual RMethod RGetHashCode_String_CompareOptions
		{
			get
			{
				if(r_GetHashCode_String_CompareOptions == null)
				{
					r_GetHashCode_String_CompareOptions = new(this, "GetHashCode", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_GetHashCode_String_CompareOptions.SetBelong(this.instance);
				}
				return r_GetHashCode_String_CompareOptions;
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

		/// <summary>
		/// System.Globalization.ISimpleCollator GetCollator()
		/// </summary>
		protected RMethod r_GetCollator;
		public virtual RMethod RGetCollator
		{
			get
			{
				if(r_GetCollator == null)
				{
					r_GetCollator = new(this, "GetCollator", 0);
					r_GetCollator.SetBelong(this.instance);
				}
				return r_GetCollator;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey CreateSortKeyCore(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_CreateSortKeyCore_String_CompareOptions;
		public virtual RMethod RCreateSortKeyCore_String_CompareOptions
		{
			get
			{
				if(r_CreateSortKeyCore_String_CompareOptions == null)
				{
					r_CreateSortKeyCore_String_CompareOptions = new(this, "CreateSortKeyCore", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_CreateSortKeyCore_String_CompareOptions.SetBelong(this.instance);
				}
				return r_CreateSortKeyCore_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_switch(System.String, Int32, Int32, System.String, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_internal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean;
		public virtual RMethod Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean
		{
			get
			{
				if(r_internal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean == null)
				{
					r_internal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean = new(this, "internal_index_switch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_internal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean.SetBelong(this.instance);
				}
				return r_internal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_compare_switch(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_internal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_internal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_internal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "internal_compare_switch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_internal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_internal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_compare_managed(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_internal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_internal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_internal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "internal_compare_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_internal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_internal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_managed(System.String, Int32, Int32, Char, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_internal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean;
		public virtual RMethod Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean
		{
			get
			{
				if(r_internal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean == null)
				{
					r_internal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean = new(this, "internal_index_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Char), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_internal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean.SetBelong(this.instance);
				}
				return r_internal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_index_managed(System.String, Int32, Int32, System.String, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_internal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean;
		public virtual RMethod Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean
		{
			get
			{
				if(r_internal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean == null)
				{
					r_internal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean = new(this, "internal_index_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_internal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean.SetBelong(this.instance);
				}
				return r_internal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_compare_icall(Char*, Int32, Char*, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_internal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions;
		public static RMethod Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions
		{
			get
			{
				if(r_internal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions == null)
				{
					r_internal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions = new(typeof(System.Globalization.CompareInfo), "internal_compare_icall", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_internal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions.SetBelong(null);
				}
				return r_internal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_internal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public static RMethod Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_internal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_internal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(typeof(System.Globalization.CompareInfo), "internal_compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_internal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(null);
				}
				return r_internal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_icall(Char*, Int32, Int32, Char*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_internal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean;
		public static RMethod Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean
		{
			get
			{
				if(r_internal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean == null)
				{
					r_internal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "internal_index_icall", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_internal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean.SetBelong(null);
				}
				return r_internal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_index(System.String, Int32, Int32, System.String, Boolean)
		/// </summary>
		protected static RMethod r_internal_index_String_Int32_Int32_String_Boolean;
		public static RMethod Rinternal_index_String_Int32_Int32_String_Boolean
		{
			get
			{
				if(r_internal_index_String_Int32_Int32_String_Boolean == null)
				{
					r_internal_index_String_Int32_Int32_String_Boolean = new(typeof(System.Globalization.CompareInfo), "internal_index", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Boolean));
					r_internal_index_String_Int32_Int32_String_Boolean.SetBelong(null);
				}
				return r_internal_index_String_Int32_Int32_String_Boolean;
			}
		}

		/// <summary>
		/// Void InitSort(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_InitSort_CultureInfo;
		public virtual RMethod RInitSort_CultureInfo
		{
			get
			{
				if(r_InitSort_CultureInfo == null)
				{
					r_InitSort_CultureInfo = new(this, "InitSort", 0, typeof(System.Globalization.CultureInfo));
					r_InitSort_CultureInfo.SetBelong(this.instance);
				}
				return r_InitSort_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 CompareStringOrdinalIgnoreCase(Char*, Int32, Char*, Int32)
		/// </summary>
		protected static RMethod r_CompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32;
		public static RMethod RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32
		{
			get
			{
				if(r_CompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32 == null)
				{
					r_CompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32 = new(typeof(System.Globalization.CompareInfo), "CompareStringOrdinalIgnoreCase", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_CompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32.SetBelong(null);
				}
				return r_CompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinalCore(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_IndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
		public static RMethod RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_IndexOfOrdinalCore_String_String_Int32_Int32_Boolean == null)
				{
					r_IndexOfOrdinalCore_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "IndexOfOrdinalCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_IndexOfOrdinalCore_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_IndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfOrdinalCore(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_LastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
		public static RMethod RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_LastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean == null)
				{
					r_LastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "LastIndexOfOrdinalCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_LastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_LastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfCore(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_LastIndexOfCore_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOfCore_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_LastIndexOfCore_String_String_Int32_Int32_CompareOptions == null)
				{
					r_LastIndexOfCore_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOfCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_LastIndexOfCore_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_LastIndexOfCore_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOfCore(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_IndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer;
		public virtual RMethod RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer
		{
			get
			{
				if(r_IndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer == null)
				{
					r_IndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer = new(this, "IndexOfCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_IndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer.SetBelong(this.instance);
				}
				return r_IndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfCore(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_IndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer;
		public virtual RMethod RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer
		{
			get
			{
				if(r_IndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer == null)
				{
					r_IndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer = new(this, "IndexOfCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_IndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer.SetBelong(this.instance);
				}
				return r_IndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinalCore(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_IndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_IndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_IndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(this, "IndexOfOrdinalCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_IndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_IndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CompareString(System.ReadOnlySpan`1[System.Char], System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_CompareString_ReadOnlySpan_d_Char_p__String_CompareOptions;
		public virtual RMethod RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions
		{
			get
			{
				if(r_CompareString_ReadOnlySpan_d_Char_p__String_CompareOptions == null)
				{
					r_CompareString_ReadOnlySpan_d_Char_p__String_CompareOptions = new(this, "CompareString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_CompareString_ReadOnlySpan_d_Char_p__String_CompareOptions.SetBelong(this.instance);
				}
				return r_CompareString_ReadOnlySpan_d_Char_p__String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareString(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_CompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_CompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_CompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "CompareString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_CompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_CompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSortable(Char*, Int32)
		/// </summary>
		protected static RMethod r_IsSortable_CharPointer_Int32;
		public static RMethod RIsSortable_CharPointer_Int32
		{
			get
			{
				if(r_IsSortable_CharPointer_Int32 == null)
				{
					r_IsSortable_CharPointer_Int32 = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_IsSortable_CharPointer_Int32.SetBelong(null);
				}
				return r_IsSortable_CharPointer_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey CreateSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_CreateSortKey_String_CompareOptions;
		public virtual RMethod RCreateSortKey_String_CompareOptions
		{
			get
			{
				if(r_CreateSortKey_String_CompareOptions == null)
				{
					r_CreateSortKey_String_CompareOptions = new(this, "CreateSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_CreateSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_CreateSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_StartsWith_String_String_CompareOptions;
		public virtual RMethod RStartsWith_String_String_CompareOptions
		{
			get
			{
				if(r_StartsWith_String_String_CompareOptions == null)
				{
					r_StartsWith_String_String_CompareOptions = new(this, "StartsWith", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_StartsWith_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_StartsWith_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_StartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_StartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_StartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "StartsWith", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_StartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_StartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_EndsWith_String_String_CompareOptions;
		public virtual RMethod REndsWith_String_String_CompareOptions
		{
			get
			{
				if(r_EndsWith_String_String_CompareOptions == null)
				{
					r_EndsWith_String_String_CompareOptions = new(this, "EndsWith", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_EndsWith_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_EndsWith_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_EndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_EndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_EndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "EndsWith", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_EndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_EndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfStringCore(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_GetHashCodeOfStringCore_String_CompareOptions;
		public virtual RMethod RGetHashCodeOfStringCore_String_CompareOptions
		{
			get
			{
				if(r_GetHashCodeOfStringCore_String_CompareOptions == null)
				{
					r_GetHashCodeOfStringCore_String_CompareOptions = new(this, "GetHashCodeOfStringCore", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_GetHashCodeOfStringCore_String_CompareOptions.SetBelong(this.instance);
				}
				return r_GetHashCodeOfStringCore_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.SortVersion GetSortVersion()
		/// </summary>
		protected RMethod r_GetSortVersion;
		public virtual RMethod RGetSortVersion
		{
			get
			{
				if(r_GetSortVersion == null)
				{
					r_GetSortVersion = new(this, "GetSortVersion", 0);
					r_GetSortVersion.SetBelong(this.instance);
				}
				return r_GetSortVersion;
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


        public RCompareInfo() : base("System.Globalization.CompareInfo")
        {
        }

        public RCompareInfo(System.Object instance) : base("System.Globalization.CompareInfo")
		{
            SetInstance(instance);
		}

        public RCompareInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCompareInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Int32 InvariantIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RInvariantIndexOf_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 InvariantIndexOf(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @ignoreCase};
            var ___result = RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 InvariantLastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RInvariantLastIndexOf_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 InvariantFindString(System.Char* @source, System.Int32 @sourceCount, System.Char* @value, System.Int32 @valueCount, System.Boolean @ignoreCase, System.Boolean @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@source, typeof(System.Char)), @sourceCount, Pointer.Box(@value, typeof(System.Char)), @valueCount, @ignoreCase, @start};
            var ___result = RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Char InvariantToUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RInvariantToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Globalization.SortKey InvariantCreateSortKey(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RInvariantCreateSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.Int32 @culture, System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @assembly};
            var ___result = RGetCompareInfo_Int32_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.String @name, System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @assembly};
            var ___result = RGetCompareInfo_String_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.Int32 @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RGetCompareInfo_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetCompareInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Boolean IsSortable(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsSortable_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSortable(System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RIsSortable_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDeserialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Compare(System.String @string1, System.String @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @string2};
            var ___result = RCompare_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.String @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @string2, @options};
            var ___result = RCompare_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(RSystem.RReadOnlySpan<RSystem.RChar> @string1, System.String @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2, @options};
            var ___result = RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareOptionNone(RSystem.RReadOnlySpan<RSystem.RChar> @string1, RSystem.RReadOnlySpan<RSystem.RChar> @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2.Value};
            var ___result = RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareOptionIgnoreCase(RSystem.RReadOnlySpan<RSystem.RChar> @string1, RSystem.RReadOnlySpan<RSystem.RChar> @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2.Value};
            var ___result = RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.Int32 @length1, System.String @string2, System.Int32 @offset2, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2};
            var ___result = RCompare_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.String @string2, System.Int32 @offset2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @string2, @offset2, @options};
            var ___result = RCompare_String_Int32_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.String @string2, System.Int32 @offset2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @string2, @offset2};
            var ___result = RCompare_String_Int32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.Int32 @length1, System.String @string2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2, @options};
            var ___result = RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCase(System.String @strA, System.Int32 @indexA, System.Int32 @lengthA, System.String @strB, System.Int32 @indexB, System.Int32 @lengthB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @lengthA, @strB, @indexB, @lengthB};
            var ___result = RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCase(RSystem.RReadOnlySpan<RSystem.RChar> @strA, RSystem.RReadOnlySpan<RSystem.RChar> @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA.Value, @strB.Value};
            var ___result = RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsPrefix(System.String @source, System.String @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix, @options};
            var ___result = RIsPrefix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrefix(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @prefix.Value, @options};
            var ___result = RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrefix(System.String @source, System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix};
            var ___result = RIsPrefix_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(System.String @source, System.String @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix, @options};
            var ___result = RIsSuffix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @suffix.Value, @options};
            var ___result = RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(System.String @source, System.String @suffix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix};
            var ___result = RIsSuffix_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RIndexOf_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RIndexOf_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RIndexOf_String_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RIndexOf_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RIndexOf_String_Char_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RIndexOf_String_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RIndexOf_String_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RIndexOf_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfOrdinal(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @ignoreCase};
            var ___result = RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @options};
            var ___result = RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options, System.Int32* @matchLengthPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options, Pointer.Box(@matchLengthPtr, typeof(System.Int32))};
            var ___result = RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfOrdinal(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RIndexOfOrdinal_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RLastIndexOf_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RLastIndexOf_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RLastIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RLastIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RLastIndexOf_String_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RLastIndexOf_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RLastIndexOf_String_Char_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RLastIndexOf_String_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RLastIndexOf_String_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RLastIndexOf_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RLastIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RLastIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfOrdinal(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Globalization.SortKey GetSortKey(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Globalization.SortKey GetSortKey(System.String @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RGetSortKey_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetIgnoreCaseHash(System.String @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RGetIgnoreCaseHash_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCodeOfString(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetHashCodeOfString_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetHashCode_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual RSystem.RGlobalization.RISimpleCollator GetCollator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCollator.Invoke(___genericsType, ___parameters);

            return new RSystem.RGlobalization.RISimpleCollator(___result);
        }


        public virtual System.Globalization.SortKey CreateSortKeyCore(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RCreateSortKeyCore_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Int32 internal_index_switch(System.String @s1, System.Int32 @sindex, System.Int32 @count, System.String @s2, System.Globalization.CompareOptions @opt, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @sindex, @count, @s2, @opt, @first};
            var ___result = Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_compare_switch(System.String @str1, System.Int32 @offset1, System.Int32 @length1, System.String @str2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_compare_managed(System.String @str1, System.Int32 @offset1, System.Int32 @length1, System.String @str2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_index_managed(System.String @s, System.Int32 @sindex, System.Int32 @count, System.Char @c, System.Globalization.CompareOptions @opt, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @sindex, @count, @c, @opt, @first};
            var ___result = Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_index_managed(System.String @s1, System.Int32 @sindex, System.Int32 @count, System.String @s2, System.Globalization.CompareOptions @opt, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @sindex, @count, @s2, @opt, @first};
            var ___result = Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 internal_compare_icall(System.Char* @str1, System.Int32 @length1, System.Char* @str2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@str1, typeof(System.Char)), @length1, Pointer.Box(@str2, typeof(System.Char)), @length2, @options};
            var ___result = Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 internal_compare(System.String @str1, System.Int32 @offset1, System.Int32 @length1, System.String @str2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 internal_index_icall(System.Char* @source, System.Int32 @sindex, System.Int32 @count, System.Char* @value, System.Int32 @value_length, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@source, typeof(System.Char)), @sindex, @count, Pointer.Box(@value, typeof(System.Char)), @value_length, @first};
            var ___result = Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 internal_index(System.String @source, System.Int32 @sindex, System.Int32 @count, System.String @value, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @sindex, @count, @value, @first};
            var ___result = Rinternal_index_String_Int32_Int32_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitSort(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RInitSort_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static System.Int32 CompareStringOrdinalIgnoreCase(System.Char* @pString1, System.Int32 @length1, System.Char* @pString2, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@pString1, typeof(System.Char)), @length1, Pointer.Box(@pString2, typeof(System.Char)), @length2};
            var ___result = RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOfOrdinalCore(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfOrdinalCore(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfCore(System.String @source, System.String @target, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target, @startIndex, @count, @options};
            var ___result = RLastIndexOfCore_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 IndexOfCore(System.String @source, System.String @target, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options, System.Int32* @matchLengthPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target, @startIndex, @count, @options, Pointer.Box(@matchLengthPtr, typeof(System.Int32))};
            var ___result = RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 IndexOfCore(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @target, System.Globalization.CompareOptions @options, System.Int32* @matchLengthPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @target.Value, @options, Pointer.Box(@matchLengthPtr, typeof(System.Int32))};
            var ___result = RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfOrdinalCore(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @ignoreCase};
            var ___result = RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareString(RSystem.RReadOnlySpan<RSystem.RChar> @string1, System.String @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2, @options};
            var ___result = RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareString(RSystem.RReadOnlySpan<RSystem.RChar> @string1, RSystem.RReadOnlySpan<RSystem.RChar> @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2.Value, @options};
            var ___result = RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Boolean IsSortable(System.Char* @text, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@text, typeof(System.Char)), @length};
            var ___result = RIsSortable_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Globalization.SortKey CreateSortKey(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RCreateSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Boolean StartsWith(System.String @source, System.String @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix, @options};
            var ___result = RStartsWith_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @prefix.Value, @options};
            var ___result = RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.String @source, System.String @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix, @options};
            var ___result = REndsWith_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(RSystem.RReadOnlySpan<RSystem.RChar> @source, RSystem.RReadOnlySpan<RSystem.RChar> @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @suffix.Value, @options};
            var ___result = REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCodeOfStringCore(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetHashCodeOfStringCore_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Globalization.SortVersion GetSortVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSortVersion.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortVersion)___result;
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
