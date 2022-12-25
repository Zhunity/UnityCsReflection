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
		/// System.String _sortName
		/// </summary>
		protected RField r__sortName;
		public virtual RField R_sortName
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
		protected RField r_culture;
		public virtual RField Rculture
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
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RGlobalization.RISimpleCollator> r_collators;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RGlobalization.RISimpleCollator> Rcollators
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
		protected static RField r_managedCollation;
		public static RField RmanagedCollation
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
		protected static RField r_managedCollationChecked;
		public static RField RmanagedCollationChecked
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
		/// Boolean UseManagedCollation
		/// </summary>
		protected static RProperty r_UseManagedCollation;
		public static RProperty RUseManagedCollation
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
		protected static RMethod r_RInvariantIndexOf_String_String_Int32_Int32_Boolean;
		public static RMethod RInvariantIndexOf_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RInvariantIndexOf_String_String_Int32_Int32_Boolean == null)
				{
					r_RInvariantIndexOf_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RInvariantIndexOf_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_RInvariantIndexOf_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantIndexOf(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected static RMethod r_RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public static RMethod RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantIndexOf", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(null);
				}
				return r_RInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantLastIndexOf(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RInvariantLastIndexOf_String_String_Int32_Int32_Boolean;
		public static RMethod RInvariantLastIndexOf_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RInvariantLastIndexOf_String_String_Int32_Int32_Boolean == null)
				{
					r_RInvariantLastIndexOf_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantLastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RInvariantLastIndexOf_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_RInvariantLastIndexOf_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantFindString(Char*, Int32, Char*, Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean;
		public static RMethod RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean
		{
			get
			{
				if(r_RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean == null)
				{
					r_RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantFindString", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_RInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Char InvariantToUpper(Char)
		/// </summary>
		protected static RMethod r_RInvariantToUpper_Char;
		public static RMethod RInvariantToUpper_Char
		{
			get
			{
				if(r_RInvariantToUpper_Char == null)
				{
					r_RInvariantToUpper_Char = new(typeof(System.Globalization.CompareInfo), "InvariantToUpper", 0, typeof(System.Char));
					r_RInvariantToUpper_Char.SetBelong(null);
				}
				return r_RInvariantToUpper_Char;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey InvariantCreateSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RInvariantCreateSortKey_String_CompareOptions;
		public virtual RMethod RInvariantCreateSortKey_String_CompareOptions
		{
			get
			{
				if(r_RInvariantCreateSortKey_String_CompareOptions == null)
				{
					r_RInvariantCreateSortKey_String_CompareOptions = new(this, "InvariantCreateSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RInvariantCreateSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RInvariantCreateSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(Int32, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RGetCompareInfo_Int32_Assembly;
		public static RMethod RGetCompareInfo_Int32_Assembly
		{
			get
			{
				if(r_RGetCompareInfo_Int32_Assembly == null)
				{
					r_RGetCompareInfo_Int32_Assembly = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.Int32), typeof(System.Reflection.Assembly));
					r_RGetCompareInfo_Int32_Assembly.SetBelong(null);
				}
				return r_RGetCompareInfo_Int32_Assembly;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(System.String, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RGetCompareInfo_String_Assembly;
		public static RMethod RGetCompareInfo_String_Assembly
		{
			get
			{
				if(r_RGetCompareInfo_String_Assembly == null)
				{
					r_RGetCompareInfo_String_Assembly = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.String), typeof(System.Reflection.Assembly));
					r_RGetCompareInfo_String_Assembly.SetBelong(null);
				}
				return r_RGetCompareInfo_String_Assembly;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(Int32)
		/// </summary>
		protected static RMethod r_RGetCompareInfo_Int32;
		public static RMethod RGetCompareInfo_Int32
		{
			get
			{
				if(r_RGetCompareInfo_Int32 == null)
				{
					r_RGetCompareInfo_Int32 = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.Int32));
					r_RGetCompareInfo_Int32.SetBelong(null);
				}
				return r_RGetCompareInfo_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(System.String)
		/// </summary>
		protected static RMethod r_RGetCompareInfo_String;
		public static RMethod RGetCompareInfo_String
		{
			get
			{
				if(r_RGetCompareInfo_String == null)
				{
					r_RGetCompareInfo_String = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.String));
					r_RGetCompareInfo_String.SetBelong(null);
				}
				return r_RGetCompareInfo_String;
			}
		}

		/// <summary>
		/// Boolean IsSortable(Char)
		/// </summary>
		protected static RMethod r_RIsSortable_Char;
		public static RMethod RIsSortable_Char
		{
			get
			{
				if(r_RIsSortable_Char == null)
				{
					r_RIsSortable_Char = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.Char));
					r_RIsSortable_Char.SetBelong(null);
				}
				return r_RIsSortable_Char;
			}
		}

		/// <summary>
		/// Boolean IsSortable(System.String)
		/// </summary>
		protected static RMethod r_RIsSortable_String;
		public static RMethod RIsSortable_String
		{
			get
			{
				if(r_RIsSortable_String == null)
				{
					r_RIsSortable_String = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.String));
					r_RIsSortable_String.SetBelong(null);
				}
				return r_RIsSortable_String;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_ROnDeserializing_StreamingContext;
		public virtual RMethod ROnDeserializing_StreamingContext
		{
			get
			{
				if(r_ROnDeserializing_StreamingContext == null)
				{
					r_ROnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnDeserializing_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_ROnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_ROnDeserialized_StreamingContext == null)
				{
					r_ROnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized()
		/// </summary>
		protected RMethod r_ROnDeserialized;
		public virtual RMethod ROnDeserialized
		{
			get
			{
				if(r_ROnDeserialized == null)
				{
					r_ROnDeserialized = new(this, "OnDeserialized", 0);
					r_ROnDeserialized.SetBelong(this.instance);
				}
				return r_ROnDeserialized;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_ROnSerializing_StreamingContext;
		public virtual RMethod ROnSerializing_StreamingContext
		{
			get
			{
				if(r_ROnSerializing_StreamingContext == null)
				{
					r_ROnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnSerializing_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String)
		/// </summary>
		protected RMethod r_RCompare_String_String;
		public virtual RMethod RCompare_String_String
		{
			get
			{
				if(r_RCompare_String_String == null)
				{
					r_RCompare_String_String = new(this, "Compare", 0, typeof(System.String), typeof(System.String));
					r_RCompare_String_String.SetBelong(this.instance);
				}
				return r_RCompare_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompare_String_String_CompareOptions;
		public virtual RMethod RCompare_String_String_CompareOptions
		{
			get
			{
				if(r_RCompare_String_String_CompareOptions == null)
				{
					r_RCompare_String_String_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RCompare_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RCompare_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.ReadOnlySpan`1[System.Char], System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions;
		public virtual RMethod RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions
		{
			get
			{
				if(r_RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions == null)
				{
					r_RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions = new(this, "Compare", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions.SetBelong(this.instance);
				}
				return r_RCompare_ReadOnlySpan_d_Char_p__String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareOptionNone(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public virtual RMethod RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(this, "CompareOptionNone", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 CompareOptionIgnoreCase(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public virtual RMethod RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(this, "CompareOptionIgnoreCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RCompare_String_Int32_Int32_String_Int32_Int32;
		public virtual RMethod RCompare_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_RCompare_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_RCompare_String_Int32_Int32_String_Int32_Int32 = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RCompare_String_Int32_Int32_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCompare_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompare_String_Int32_String_Int32_CompareOptions;
		public virtual RMethod RCompare_String_Int32_String_Int32_CompareOptions
		{
			get
			{
				if(r_RCompare_String_Int32_String_Int32_CompareOptions == null)
				{
					r_RCompare_String_Int32_String_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RCompare_String_Int32_String_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RCompare_String_Int32_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32)
		/// </summary>
		protected RMethod r_RCompare_String_Int32_String_Int32;
		public virtual RMethod RCompare_String_Int32_String_Int32
		{
			get
			{
				if(r_RCompare_String_Int32_String_Int32 == null)
				{
					r_RCompare_String_Int32_String_Int32 = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32));
					r_RCompare_String_Int32_String_Int32.SetBelong(this.instance);
				}
				return r_RCompare_String_Int32_String_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCase(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32;
		public static RMethod RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32 = new(typeof(System.Globalization.CompareInfo), "CompareOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCase(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(typeof(System.Globalization.CompareInfo), "CompareOrdinalIgnoreCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_RCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIsPrefix_String_String_CompareOptions;
		public virtual RMethod RIsPrefix_String_String_CompareOptions
		{
			get
			{
				if(r_RIsPrefix_String_String_CompareOptions == null)
				{
					r_RIsPrefix_String_String_CompareOptions = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RIsPrefix_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RIsPrefix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IsPrefix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_RIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String)
		/// </summary>
		protected RMethod r_RIsPrefix_String_String;
		public virtual RMethod RIsPrefix_String_String
		{
			get
			{
				if(r_RIsPrefix_String_String == null)
				{
					r_RIsPrefix_String_String = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String));
					r_RIsPrefix_String_String.SetBelong(this.instance);
				}
				return r_RIsPrefix_String_String;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIsSuffix_String_String_CompareOptions;
		public virtual RMethod RIsSuffix_String_String_CompareOptions
		{
			get
			{
				if(r_RIsSuffix_String_String_CompareOptions == null)
				{
					r_RIsSuffix_String_String_CompareOptions = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RIsSuffix_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RIsSuffix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IsSuffix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_RIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String)
		/// </summary>
		protected RMethod r_RIsSuffix_String_String;
		public virtual RMethod RIsSuffix_String_String
		{
			get
			{
				if(r_RIsSuffix_String_String == null)
				{
					r_RIsSuffix_String_String = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String));
					r_RIsSuffix_String_String.SetBelong(this.instance);
				}
				return r_RIsSuffix_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char;
		public virtual RMethod RIndexOf_String_Char
		{
			get
			{
				if(r_RIndexOf_String_Char == null)
				{
					r_RIndexOf_String_Char = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char));
					r_RIndexOf_String_Char.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String)
		/// </summary>
		protected RMethod r_RIndexOf_String_String;
		public virtual RMethod RIndexOf_String_String
		{
			get
			{
				if(r_RIndexOf_String_String == null)
				{
					r_RIndexOf_String_String = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String));
					r_RIndexOf_String_String.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_Char_CompareOptions == null)
				{
					r_RIndexOf_String_Char_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_Char_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_CompareOptions;
		public virtual RMethod RIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_String_CompareOptions == null)
				{
					r_RIndexOf_String_String_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char_Int32;
		public virtual RMethod RIndexOf_String_Char_Int32
		{
			get
			{
				if(r_RIndexOf_String_Char_Int32 == null)
				{
					r_RIndexOf_String_Char_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32));
					r_RIndexOf_String_Char_Int32.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_Int32;
		public virtual RMethod RIndexOf_String_String_Int32
		{
			get
			{
				if(r_RIndexOf_String_String_Int32 == null)
				{
					r_RIndexOf_String_String_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_RIndexOf_String_String_Int32.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_Int32_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_Char_Int32_CompareOptions == null)
				{
					r_RIndexOf_String_Char_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_Char_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_String_Int32_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_String_Int32_CompareOptions == null)
				{
					r_RIndexOf_String_String_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_String_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char_Int32_Int32;
		public virtual RMethod RIndexOf_String_Char_Int32_Int32
		{
			get
			{
				if(r_RIndexOf_String_Char_Int32_Int32 == null)
				{
					r_RIndexOf_String_Char_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_RIndexOf_String_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_Int32_Int32;
		public virtual RMethod RIndexOf_String_String_Int32_Int32
		{
			get
			{
				if(r_RIndexOf_String_String_Int32_Int32 == null)
				{
					r_RIndexOf_String_String_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RIndexOf_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_RIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_RIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinal(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(this, "IndexOfOrdinal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_RIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IndexOf", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer;
		public virtual RMethod RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer
		{
			get
			{
				if(r_RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer == null)
				{
					r_RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinal(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RIndexOfOrdinal_String_String_Int32_Int32_Boolean;
		public virtual RMethod RIndexOfOrdinal_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RIndexOfOrdinal_String_String_Int32_Int32_Boolean == null)
				{
					r_RIndexOfOrdinal_String_String_Int32_Int32_Boolean = new(this, "IndexOfOrdinal", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RIndexOfOrdinal_String_String_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RIndexOfOrdinal_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char;
		public virtual RMethod RLastIndexOf_String_Char
		{
			get
			{
				if(r_RLastIndexOf_String_Char == null)
				{
					r_RLastIndexOf_String_Char = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char));
					r_RLastIndexOf_String_Char.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String;
		public virtual RMethod RLastIndexOf_String_String
		{
			get
			{
				if(r_RLastIndexOf_String_String == null)
				{
					r_RLastIndexOf_String_String = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String));
					r_RLastIndexOf_String_String.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_Char_CompareOptions == null)
				{
					r_RLastIndexOf_String_Char_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_Char_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_String_CompareOptions == null)
				{
					r_RLastIndexOf_String_String_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_Int32;
		public virtual RMethod RLastIndexOf_String_Char_Int32
		{
			get
			{
				if(r_RLastIndexOf_String_Char_Int32 == null)
				{
					r_RLastIndexOf_String_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32));
					r_RLastIndexOf_String_Char_Int32.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_Int32;
		public virtual RMethod RLastIndexOf_String_String_Int32
		{
			get
			{
				if(r_RLastIndexOf_String_String_Int32 == null)
				{
					r_RLastIndexOf_String_String_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_RLastIndexOf_String_String_Int32.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_Char_Int32_CompareOptions == null)
				{
					r_RLastIndexOf_String_Char_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_Char_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_String_Int32_CompareOptions == null)
				{
					r_RLastIndexOf_String_String_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_String_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_Int32_Int32;
		public virtual RMethod RLastIndexOf_String_Char_Int32_Int32
		{
			get
			{
				if(r_RLastIndexOf_String_Char_Int32_Int32 == null)
				{
					r_RLastIndexOf_String_Char_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_RLastIndexOf_String_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_Int32_Int32;
		public virtual RMethod RLastIndexOf_String_String_Int32_Int32
		{
			get
			{
				if(r_RLastIndexOf_String_String_Int32_Int32 == null)
				{
					r_RLastIndexOf_String_String_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RLastIndexOf_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_RLastIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfOrdinal(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean;
		public virtual RMethod RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean == null)
				{
					r_RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean = new(this, "LastIndexOfOrdinal", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RGetSortKey_String_CompareOptions;
		public virtual RMethod RGetSortKey_String_CompareOptions
		{
			get
			{
				if(r_RGetSortKey_String_CompareOptions == null)
				{
					r_RGetSortKey_String_CompareOptions = new(this, "GetSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RGetSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RGetSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String)
		/// </summary>
		protected RMethod r_RGetSortKey_String;
		public virtual RMethod RGetSortKey_String
		{
			get
			{
				if(r_RGetSortKey_String == null)
				{
					r_RGetSortKey_String = new(this, "GetSortKey", 0, typeof(System.String));
					r_RGetSortKey_String.SetBelong(this.instance);
				}
				return r_RGetSortKey_String;
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
		/// Int32 GetIgnoreCaseHash(System.String)
		/// </summary>
		protected static RMethod r_RGetIgnoreCaseHash_String;
		public static RMethod RGetIgnoreCaseHash_String
		{
			get
			{
				if(r_RGetIgnoreCaseHash_String == null)
				{
					r_RGetIgnoreCaseHash_String = new(typeof(System.Globalization.CompareInfo), "GetIgnoreCaseHash", 0, typeof(System.String));
					r_RGetIgnoreCaseHash_String.SetBelong(null);
				}
				return r_RGetIgnoreCaseHash_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfString(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RGetHashCodeOfString_String_CompareOptions;
		public virtual RMethod RGetHashCodeOfString_String_CompareOptions
		{
			get
			{
				if(r_RGetHashCodeOfString_String_CompareOptions == null)
				{
					r_RGetHashCodeOfString_String_CompareOptions = new(this, "GetHashCodeOfString", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RGetHashCodeOfString_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RGetHashCodeOfString_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RGetHashCode_String_CompareOptions;
		public virtual RMethod RGetHashCode_String_CompareOptions
		{
			get
			{
				if(r_RGetHashCode_String_CompareOptions == null)
				{
					r_RGetHashCode_String_CompareOptions = new(this, "GetHashCode", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RGetHashCode_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RGetHashCode_String_CompareOptions;
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
		/// System.Globalization.ISimpleCollator GetCollator()
		/// </summary>
		protected RMethod r_RGetCollator;
		public virtual RMethod RGetCollator
		{
			get
			{
				if(r_RGetCollator == null)
				{
					r_RGetCollator = new(this, "GetCollator", 0);
					r_RGetCollator.SetBelong(this.instance);
				}
				return r_RGetCollator;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey CreateSortKeyCore(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCreateSortKeyCore_String_CompareOptions;
		public virtual RMethod RCreateSortKeyCore_String_CompareOptions
		{
			get
			{
				if(r_RCreateSortKeyCore_String_CompareOptions == null)
				{
					r_RCreateSortKeyCore_String_CompareOptions = new(this, "CreateSortKeyCore", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RCreateSortKeyCore_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RCreateSortKeyCore_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_switch(System.String, Int32, Int32, System.String, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean;
		public virtual RMethod Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean
		{
			get
			{
				if(r_Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean == null)
				{
					r_Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean = new(this, "internal_index_switch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean.SetBelong(this.instance);
				}
				return r_Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_compare_switch(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "internal_compare_switch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_compare_managed(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "internal_compare_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_managed(System.String, Int32, Int32, Char, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean;
		public virtual RMethod Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean
		{
			get
			{
				if(r_Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean == null)
				{
					r_Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean = new(this, "internal_index_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Char), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean.SetBelong(this.instance);
				}
				return r_Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_index_managed(System.String, Int32, Int32, System.String, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean;
		public virtual RMethod Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean
		{
			get
			{
				if(r_Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean == null)
				{
					r_Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean = new(this, "internal_index_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean.SetBelong(this.instance);
				}
				return r_Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_compare_icall(Char*, Int32, Char*, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions;
		public static RMethod Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions
		{
			get
			{
				if(r_Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions == null)
				{
					r_Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions = new(typeof(System.Globalization.CompareInfo), "internal_compare_icall", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions.SetBelong(null);
				}
				return r_Rinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public static RMethod Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(typeof(System.Globalization.CompareInfo), "internal_compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(null);
				}
				return r_Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_icall(Char*, Int32, Int32, Char*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean;
		public static RMethod Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean
		{
			get
			{
				if(r_Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean == null)
				{
					r_Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "internal_index_icall", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean.SetBelong(null);
				}
				return r_Rinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_index(System.String, Int32, Int32, System.String, Boolean)
		/// </summary>
		protected static RMethod r_Rinternal_index_String_Int32_Int32_String_Boolean;
		public static RMethod Rinternal_index_String_Int32_Int32_String_Boolean
		{
			get
			{
				if(r_Rinternal_index_String_Int32_Int32_String_Boolean == null)
				{
					r_Rinternal_index_String_Int32_Int32_String_Boolean = new(typeof(System.Globalization.CompareInfo), "internal_index", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Boolean));
					r_Rinternal_index_String_Int32_Int32_String_Boolean.SetBelong(null);
				}
				return r_Rinternal_index_String_Int32_Int32_String_Boolean;
			}
		}

		/// <summary>
		/// Void InitSort(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RInitSort_CultureInfo;
		public virtual RMethod RInitSort_CultureInfo
		{
			get
			{
				if(r_RInitSort_CultureInfo == null)
				{
					r_RInitSort_CultureInfo = new(this, "InitSort", 0, typeof(System.Globalization.CultureInfo));
					r_RInitSort_CultureInfo.SetBelong(this.instance);
				}
				return r_RInitSort_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 CompareStringOrdinalIgnoreCase(Char*, Int32, Char*, Int32)
		/// </summary>
		protected static RMethod r_RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32;
		public static RMethod RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32
		{
			get
			{
				if(r_RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32 == null)
				{
					r_RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32 = new(typeof(System.Globalization.CompareInfo), "CompareStringOrdinalIgnoreCase", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32.SetBelong(null);
				}
				return r_RCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinalCore(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
		public static RMethod RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean == null)
				{
					r_RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "IndexOfOrdinalCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfOrdinalCore(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
		public static RMethod RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean == null)
				{
					r_RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "LastIndexOfOrdinalCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfCore(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOfCore_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOfCore_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOfCore_String_String_Int32_Int32_CompareOptions == null)
				{
					r_RLastIndexOfCore_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOfCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOfCore_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOfCore_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOfCore(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer;
		public virtual RMethod RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer
		{
			get
			{
				if(r_RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer == null)
				{
					r_RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer = new(this, "IndexOfCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer.SetBelong(this.instance);
				}
				return r_RIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfCore(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer;
		public virtual RMethod RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer
		{
			get
			{
				if(r_RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer == null)
				{
					r_RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer = new(this, "IndexOfCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer.SetBelong(this.instance);
				}
				return r_RIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinalCore(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(this, "IndexOfOrdinalCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.instance);
				}
				return r_RIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CompareString(System.ReadOnlySpan`1[System.Char], System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions;
		public virtual RMethod RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions
		{
			get
			{
				if(r_RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions == null)
				{
					r_RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions = new(this, "CompareString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions.SetBelong(this.instance);
				}
				return r_RCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareString(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "CompareString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_RCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSortable(Char*, Int32)
		/// </summary>
		protected static RMethod r_RIsSortable_CharPointer_Int32;
		public static RMethod RIsSortable_CharPointer_Int32
		{
			get
			{
				if(r_RIsSortable_CharPointer_Int32 == null)
				{
					r_RIsSortable_CharPointer_Int32 = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RIsSortable_CharPointer_Int32.SetBelong(null);
				}
				return r_RIsSortable_CharPointer_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey CreateSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCreateSortKey_String_CompareOptions;
		public virtual RMethod RCreateSortKey_String_CompareOptions
		{
			get
			{
				if(r_RCreateSortKey_String_CompareOptions == null)
				{
					r_RCreateSortKey_String_CompareOptions = new(this, "CreateSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RCreateSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RCreateSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RStartsWith_String_String_CompareOptions;
		public virtual RMethod RStartsWith_String_String_CompareOptions
		{
			get
			{
				if(r_RStartsWith_String_String_CompareOptions == null)
				{
					r_RStartsWith_String_String_CompareOptions = new(this, "StartsWith", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RStartsWith_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RStartsWith_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "StartsWith", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_RStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_REndsWith_String_String_CompareOptions;
		public virtual RMethod REndsWith_String_String_CompareOptions
		{
			get
			{
				if(r_REndsWith_String_String_CompareOptions == null)
				{
					r_REndsWith_String_String_CompareOptions = new(this, "EndsWith", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_REndsWith_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_REndsWith_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "EndsWith", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.instance);
				}
				return r_REndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfStringCore(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RGetHashCodeOfStringCore_String_CompareOptions;
		public virtual RMethod RGetHashCodeOfStringCore_String_CompareOptions
		{
			get
			{
				if(r_RGetHashCodeOfStringCore_String_CompareOptions == null)
				{
					r_RGetHashCodeOfStringCore_String_CompareOptions = new(this, "GetHashCodeOfStringCore", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RGetHashCodeOfStringCore_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RGetHashCodeOfStringCore_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.SortVersion GetSortVersion()
		/// </summary>
		protected RMethod r_RGetSortVersion;
		public virtual RMethod RGetSortVersion
		{
			get
			{
				if(r_RGetSortVersion == null)
				{
					r_RGetSortVersion = new(this, "GetSortVersion", 0);
					r_RGetSortVersion.SetBelong(this.instance);
				}
				return r_RGetSortVersion;
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

        public static System.Int32 InvariantIndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RInvariantIndexOf_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static System.Int32 InvariantLastIndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RInvariantLastIndexOf_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static System.Char InvariantToUpper(System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RInvariantToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Globalization.SortKey InvariantCreateSortKey(System.String  @source, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RInvariantCreateSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.Int32  @culture, System.Reflection.Assembly  @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @assembly};
            var ___result = RGetCompareInfo_Int32_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.String  @name, System.Reflection.Assembly  @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @assembly};
            var ___result = RGetCompareInfo_String_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.Int32  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RGetCompareInfo_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetCompareInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Boolean IsSortable(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsSortable_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSortable(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RIsSortable_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization(System.Object  @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RSystem__0__Runtime__0__Serialization__0__IDeserializationCallback__0__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext  @ctx)
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


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext  @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = ROnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Compare(System.String  @string1, System.String  @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @string2};
            var ___result = RCompare_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String  @string1, System.String  @string2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @string2, @options};
            var ___result = RCompare_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }





        public virtual System.Int32 Compare(System.String  @string1, System.Int32  @offset1, System.Int32  @length1, System.String  @string2, System.Int32  @offset2, System.Int32  @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2};
            var ___result = RCompare_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String  @string1, System.Int32  @offset1, System.String  @string2, System.Int32  @offset2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @string2, @offset2, @options};
            var ___result = RCompare_String_Int32_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String  @string1, System.Int32  @offset1, System.String  @string2, System.Int32  @offset2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @string2, @offset2};
            var ___result = RCompare_String_Int32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String  @string1, System.Int32  @offset1, System.Int32  @length1, System.String  @string2, System.Int32  @offset2, System.Int32  @length2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2, @options};
            var ___result = RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCase(System.String  @strA, System.Int32  @indexA, System.Int32  @lengthA, System.String  @strB, System.Int32  @indexB, System.Int32  @lengthB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @lengthA, @strB, @indexB, @lengthB};
            var ___result = RCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Boolean IsPrefix(System.String  @source, System.String  @prefix, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix, @options};
            var ___result = RIsPrefix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Boolean IsPrefix(System.String  @source, System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix};
            var ___result = RIsPrefix_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(System.String  @source, System.String  @suffix, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix, @options};
            var ___result = RIsSuffix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Boolean IsSuffix(System.String  @source, System.String  @suffix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix};
            var ___result = RIsSuffix_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RIndexOf_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RIndexOf_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.Char  @value, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.String  @value, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RIndexOf_String_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RIndexOf_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RIndexOf_String_Char_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RIndexOf_String_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RIndexOf_String_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RIndexOf_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex, System.Int32  @count, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }





        public virtual System.Int32 IndexOfOrdinal(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RIndexOfOrdinal_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RLastIndexOf_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RLastIndexOf_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.Char  @value, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RLastIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.String  @value, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RLastIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RLastIndexOf_String_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RLastIndexOf_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RLastIndexOf_String_Char_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RLastIndexOf_String_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RLastIndexOf_String_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RLastIndexOf_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.Char  @value, System.Int32  @startIndex, System.Int32  @count, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RLastIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RLastIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfOrdinal(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RLastIndexOfOrdinal_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Globalization.SortKey GetSortKey(System.String  @source, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Globalization.SortKey GetSortKey(System.String  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RGetSortKey_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Boolean Equals(System.Object  @value)
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


        public static System.Int32 GetIgnoreCaseHash(System.String  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RGetIgnoreCaseHash_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCodeOfString(System.String  @source, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetHashCodeOfString_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode(System.String  @source, System.Globalization.CompareOptions  @options)
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


        public virtual System.Object GetCollator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCollator.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Globalization.SortKey CreateSortKeyCore(System.String  @source, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RCreateSortKeyCore_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Int32 internal_index_switch(System.String  @s1, System.Int32  @sindex, System.Int32  @count, System.String  @s2, System.Globalization.CompareOptions  @opt, System.Boolean  @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @sindex, @count, @s2, @opt, @first};
            var ___result = Rinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_compare_switch(System.String  @str1, System.Int32  @offset1, System.Int32  @length1, System.String  @str2, System.Int32  @offset2, System.Int32  @length2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = Rinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_compare_managed(System.String  @str1, System.Int32  @offset1, System.Int32  @length1, System.String  @str2, System.Int32  @offset2, System.Int32  @length2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = Rinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_index_managed(System.String  @s, System.Int32  @sindex, System.Int32  @count, System.Char  @c, System.Globalization.CompareOptions  @opt, System.Boolean  @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @sindex, @count, @c, @opt, @first};
            var ___result = Rinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_index_managed(System.String  @s1, System.Int32  @sindex, System.Int32  @count, System.String  @s2, System.Globalization.CompareOptions  @opt, System.Boolean  @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @sindex, @count, @s2, @opt, @first};
            var ___result = Rinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static System.Int32 internal_compare(System.String  @str1, System.Int32  @offset1, System.Int32  @length1, System.String  @str2, System.Int32  @offset2, System.Int32  @length2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = Rinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static System.Int32 internal_index(System.String  @source, System.Int32  @sindex, System.Int32  @count, System.String  @value, System.Boolean  @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @sindex, @count, @value, @first};
            var ___result = Rinternal_index_String_Int32_Int32_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitSort(System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RInitSort_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }



        public static System.Int32 IndexOfOrdinalCore(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfOrdinalCore(System.String  @source, System.String  @value, System.Int32  @startIndex, System.Int32  @count, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfCore(System.String  @source, System.String  @target, System.Int32  @startIndex, System.Int32  @count, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target, @startIndex, @count, @options};
            var ___result = RLastIndexOfCore_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }








        public virtual System.Globalization.SortKey CreateSortKey(System.String  @source, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RCreateSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Boolean StartsWith(System.String  @source, System.String  @prefix, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix, @options};
            var ___result = RStartsWith_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Boolean EndsWith(System.String  @source, System.String  @suffix, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix, @options};
            var ___result = REndsWith_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Int32 GetHashCodeOfStringCore(System.String  @source, System.Globalization.CompareOptions  @options)
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
