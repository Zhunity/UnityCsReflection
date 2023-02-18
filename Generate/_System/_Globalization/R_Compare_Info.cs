
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.CompareInfo
	/// </summary>
    public partial class RCompareInfo : RMember //
    {

		/// <summary>
		/// System.Globalization.CompareOptions ValidIndexMaskOffFlags
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions r_FValidIndexMaskOffFlags;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions RFValidIndexMaskOffFlags
		{
			get
			{
				if(r_FValidIndexMaskOffFlags == null)
				{
					r_FValidIndexMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidIndexMaskOffFlags");
					r_FValidIndexMaskOffFlags.SetBelong(null);
				}
				return r_FValidIndexMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions ValidCompareMaskOffFlags
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions r_FValidCompareMaskOffFlags;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions RFValidCompareMaskOffFlags
		{
			get
			{
				if(r_FValidCompareMaskOffFlags == null)
				{
					r_FValidCompareMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidCompareMaskOffFlags");
					r_FValidCompareMaskOffFlags.SetBelong(null);
				}
				return r_FValidCompareMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions ValidHashCodeOfStringMaskOffFlags
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions r_FValidHashCodeOfStringMaskOffFlags;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions RFValidHashCodeOfStringMaskOffFlags
		{
			get
			{
				if(r_FValidHashCodeOfStringMaskOffFlags == null)
				{
					r_FValidHashCodeOfStringMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidHashCodeOfStringMaskOffFlags");
					r_FValidHashCodeOfStringMaskOffFlags.SetBelong(null);
				}
				return r_FValidHashCodeOfStringMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareOptions ValidSortkeyCtorMaskOffFlags
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions r_FValidSortkeyCtorMaskOffFlags;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareOptions RFValidSortkeyCtorMaskOffFlags
		{
			get
			{
				if(r_FValidSortkeyCtorMaskOffFlags == null)
				{
					r_FValidSortkeyCtorMaskOffFlags = new(typeof(System.Globalization.CompareInfo), "ValidSortkeyCtorMaskOffFlags");
					r_FValidSortkeyCtorMaskOffFlags.SetBelong(null);
				}
				return r_FValidSortkeyCtorMaskOffFlags;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo Invariant
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo r_FInvariant;
		public static Hvak.Editor.Refleaction.RSystem.RGlobalization.RCompareInfo RFInvariant
		{
			get
			{
				if(r_FInvariant == null)
				{
					r_FInvariant = new(typeof(System.Globalization.CompareInfo), "Invariant");
					r_FInvariant.SetBelong(null);
				}
				return r_FInvariant;
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
					r_Fm_name.SetBelong(this.GetValue());
				}
				return r_Fm_name;
			}
		}

		/// <summary>
		/// System.String _sortName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_sortName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_sortName
		{
			get
			{
				if(r_F_sortName == null)
				{
					r_F_sortName = new(this, "_sortName");
					r_F_sortName.SetBelong(this.GetValue());
				}
				return r_F_sortName;
			}
		}

		/// <summary>
		/// System.Globalization.SortVersion m_SortVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RSortVersion r_Fm_SortVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RSortVersion RFm_SortVersion
		{
			get
			{
				if(r_Fm_SortVersion == null)
				{
					r_Fm_SortVersion = new(this, "m_SortVersion");
					r_Fm_SortVersion.SetBelong(this.GetValue());
				}
				return r_Fm_SortVersion;
			}
		}

		/// <summary>
		/// System.Int32 culture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fculture;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFculture
		{
			get
			{
				if(r_Fculture == null)
				{
					r_Fculture = new(this, "culture");
					r_Fculture.SetBelong(this.GetValue());
				}
				return r_Fculture;
			}
		}

		/// <summary>
		/// System.Globalization.ISimpleCollator collator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RISimpleCollator r_Fcollator;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RISimpleCollator RFcollator
		{
			get
			{
				if(r_Fcollator == null)
				{
					r_Fcollator = new(this, "collator");
					r_Fcollator.SetBelong(this.GetValue());
				}
				return r_Fcollator;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Globalization.ISimpleCollator] collators
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RGlobalization.RISimpleCollator> r_Fcollators;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RGlobalization.RISimpleCollator> RFcollators
		{
			get
			{
				if(r_Fcollators == null)
				{
					r_Fcollators = new(typeof(System.Globalization.CompareInfo), "collators");
					r_Fcollators.SetBelong(null);
				}
				return r_Fcollators;
			}
		}

		/// <summary>
		/// System.Boolean managedCollation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_FmanagedCollation;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFmanagedCollation
		{
			get
			{
				if(r_FmanagedCollation == null)
				{
					r_FmanagedCollation = new(typeof(System.Globalization.CompareInfo), "managedCollation");
					r_FmanagedCollation.SetBelong(null);
				}
				return r_FmanagedCollation;
			}
		}

		/// <summary>
		/// System.Boolean managedCollationChecked
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_FmanagedCollationChecked;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFmanagedCollationChecked
		{
			get
			{
				if(r_FmanagedCollationChecked == null)
				{
					r_FmanagedCollationChecked = new(typeof(System.Globalization.CompareInfo), "managedCollationChecked");
					r_FmanagedCollationChecked.SetBelong(null);
				}
				return r_FmanagedCollationChecked;
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
					r_PName.SetBelong(this.GetValue());
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Globalization.SortVersion Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGlobalization.RSortVersion r_PVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RSortVersion RPVersion
		{
			get
			{
				if(r_PVersion == null)
				{
					r_PVersion = new(this, "Version", -1);
					r_PVersion.SetBelong(this.GetValue());
				}
				return r_PVersion;
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
					r_PLCID.SetBelong(this.GetValue());
				}
				return r_PLCID;
			}
		}

		/// <summary>
		/// Boolean UseManagedCollation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PUseManagedCollation;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPUseManagedCollation
		{
			get
			{
				if(r_PUseManagedCollation == null)
				{
					r_PUseManagedCollation = new(typeof(System.Globalization.CompareInfo), "UseManagedCollation", -1);
					r_PUseManagedCollation.SetBelong(null);
				}
				return r_PUseManagedCollation;
			}
		}

		/// <summary>
		/// Int32 InvariantIndexOf(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MInvariantIndexOf_String_String_Int32_Int32_Boolean;
		public static RMethod RMInvariantIndexOf_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MInvariantIndexOf_String_String_Int32_Int32_Boolean == null)
				{
					r_MInvariantIndexOf_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MInvariantIndexOf_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_MInvariantIndexOf_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantIndexOf(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected static RMethod r_MInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public static RMethod RMInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_MInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_MInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantIndexOf", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_MInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(null);
				}
				return r_MInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantLastIndexOf(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MInvariantLastIndexOf_String_String_Int32_Int32_Boolean;
		public static RMethod RMInvariantLastIndexOf_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MInvariantLastIndexOf_String_String_Int32_Int32_Boolean == null)
				{
					r_MInvariantLastIndexOf_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantLastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MInvariantLastIndexOf_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_MInvariantLastIndexOf_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 InvariantFindString(Char*, Int32, Char*, Int32, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean;
		public static RMethod RMInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean
		{
			get
			{
				if(r_MInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean == null)
				{
					r_MInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean = new(typeof(System.Globalization.CompareInfo), "InvariantFindString", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Boolean));
					r_MInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean.SetBelong(null);
				}
				return r_MInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Char InvariantToUpper(Char)
		/// </summary>
		protected static RMethod r_MInvariantToUpper_Char;
		public static RMethod RMInvariantToUpper_Char
		{
			get
			{
				if(r_MInvariantToUpper_Char == null)
				{
					r_MInvariantToUpper_Char = new(typeof(System.Globalization.CompareInfo), "InvariantToUpper", 0, typeof(System.Char));
					r_MInvariantToUpper_Char.SetBelong(null);
				}
				return r_MInvariantToUpper_Char;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey InvariantCreateSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MInvariantCreateSortKey_String_CompareOptions;
		public virtual RMethod RMInvariantCreateSortKey_String_CompareOptions
		{
			get
			{
				if(r_MInvariantCreateSortKey_String_CompareOptions == null)
				{
					r_MInvariantCreateSortKey_String_CompareOptions = new(this, "InvariantCreateSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MInvariantCreateSortKey_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MInvariantCreateSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(Int32, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MGetCompareInfo_Int32_Assembly;
		public static RMethod RMGetCompareInfo_Int32_Assembly
		{
			get
			{
				if(r_MGetCompareInfo_Int32_Assembly == null)
				{
					r_MGetCompareInfo_Int32_Assembly = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.Int32), typeof(System.Reflection.Assembly));
					r_MGetCompareInfo_Int32_Assembly.SetBelong(null);
				}
				return r_MGetCompareInfo_Int32_Assembly;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(System.String, System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MGetCompareInfo_String_Assembly;
		public static RMethod RMGetCompareInfo_String_Assembly
		{
			get
			{
				if(r_MGetCompareInfo_String_Assembly == null)
				{
					r_MGetCompareInfo_String_Assembly = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.String), typeof(System.Reflection.Assembly));
					r_MGetCompareInfo_String_Assembly.SetBelong(null);
				}
				return r_MGetCompareInfo_String_Assembly;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(Int32)
		/// </summary>
		protected static RMethod r_MGetCompareInfo_Int32;
		public static RMethod RMGetCompareInfo_Int32
		{
			get
			{
				if(r_MGetCompareInfo_Int32 == null)
				{
					r_MGetCompareInfo_Int32 = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.Int32));
					r_MGetCompareInfo_Int32.SetBelong(null);
				}
				return r_MGetCompareInfo_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.CompareInfo GetCompareInfo(System.String)
		/// </summary>
		protected static RMethod r_MGetCompareInfo_String;
		public static RMethod RMGetCompareInfo_String
		{
			get
			{
				if(r_MGetCompareInfo_String == null)
				{
					r_MGetCompareInfo_String = new(typeof(System.Globalization.CompareInfo), "GetCompareInfo", 0, typeof(System.String));
					r_MGetCompareInfo_String.SetBelong(null);
				}
				return r_MGetCompareInfo_String;
			}
		}

		/// <summary>
		/// Boolean IsSortable(Char)
		/// </summary>
		protected static RMethod r_MIsSortable_Char;
		public static RMethod RMIsSortable_Char
		{
			get
			{
				if(r_MIsSortable_Char == null)
				{
					r_MIsSortable_Char = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.Char));
					r_MIsSortable_Char.SetBelong(null);
				}
				return r_MIsSortable_Char;
			}
		}

		/// <summary>
		/// Boolean IsSortable(System.String)
		/// </summary>
		protected static RMethod r_MIsSortable_String;
		public static RMethod RMIsSortable_String
		{
			get
			{
				if(r_MIsSortable_String == null)
				{
					r_MIsSortable_String = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.String));
					r_MIsSortable_String.SetBelong(null);
				}
				return r_MIsSortable_String;
			}
		}

		/// <summary>
		/// Void OnDeserializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserializing_StreamingContext;
		public virtual RMethod RMOnDeserializing_StreamingContext
		{
			get
			{
				if(r_MOnDeserializing_StreamingContext == null)
				{
					r_MOnDeserializing_StreamingContext = new(this, "OnDeserializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnDeserializing_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MOnDeserializing_StreamingContext;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object = new(this, "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", 0, typeof(System.Object));
					r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserialized_StreamingContext;
		public virtual RMethod RMOnDeserialized_StreamingContext
		{
			get
			{
				if(r_MOnDeserialized_StreamingContext == null)
				{
					r_MOnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnDeserialized_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MOnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized()
		/// </summary>
		protected RMethod r_MOnDeserialized;
		public virtual RMethod RMOnDeserialized
		{
			get
			{
				if(r_MOnDeserialized == null)
				{
					r_MOnDeserialized = new(this, "OnDeserialized", 0);
					r_MOnDeserialized.SetBelong(this.GetValue());
				}
				return r_MOnDeserialized;
			}
		}

		/// <summary>
		/// Void OnSerializing(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnSerializing_StreamingContext;
		public virtual RMethod RMOnSerializing_StreamingContext
		{
			get
			{
				if(r_MOnSerializing_StreamingContext == null)
				{
					r_MOnSerializing_StreamingContext = new(this, "OnSerializing", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnSerializing_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MOnSerializing_StreamingContext;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String)
		/// </summary>
		protected RMethod r_MCompare_String_String;
		public virtual RMethod RMCompare_String_String
		{
			get
			{
				if(r_MCompare_String_String == null)
				{
					r_MCompare_String_String = new(this, "Compare", 0, typeof(System.String), typeof(System.String));
					r_MCompare_String_String.SetBelong(this.GetValue());
				}
				return r_MCompare_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCompare_String_String_CompareOptions;
		public virtual RMethod RMCompare_String_String_CompareOptions
		{
			get
			{
				if(r_MCompare_String_String_CompareOptions == null)
				{
					r_MCompare_String_String_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MCompare_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCompare_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.ReadOnlySpan`1[System.Char], System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCompare_ReadOnlySpan_d_Char_p__String_CompareOptions;
		public virtual RMethod RMCompare_ReadOnlySpan_d_Char_p__String_CompareOptions
		{
			get
			{
				if(r_MCompare_ReadOnlySpan_d_Char_p__String_CompareOptions == null)
				{
					r_MCompare_ReadOnlySpan_d_Char_p__String_CompareOptions = new(this, "Compare", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MCompare_ReadOnlySpan_d_Char_p__String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCompare_ReadOnlySpan_d_Char_p__String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareOptionNone(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_MCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(this, "CompareOptionNone", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(this.GetValue());
				}
				return r_MCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 CompareOptionIgnoreCase(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_MCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(this, "CompareOptionIgnoreCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(this.GetValue());
				}
				return r_MCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MCompare_String_Int32_Int32_String_Int32_Int32;
		public virtual RMethod RMCompare_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_MCompare_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_MCompare_String_Int32_Int32_String_Int32_Int32 = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MCompare_String_Int32_Int32_String_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MCompare_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCompare_String_Int32_String_Int32_CompareOptions;
		public virtual RMethod RMCompare_String_Int32_String_Int32_CompareOptions
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32_CompareOptions == null)
				{
					r_MCompare_String_Int32_String_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MCompare_String_Int32_String_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCompare_String_Int32_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, System.String, Int32)
		/// </summary>
		protected RMethod r_MCompare_String_Int32_String_Int32;
		public virtual RMethod RMCompare_String_Int32_String_Int32
		{
			get
			{
				if(r_MCompare_String_Int32_String_Int32 == null)
				{
					r_MCompare_String_Int32_String_Int32 = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.String), typeof(System.Int32));
					r_MCompare_String_Int32_String_Int32.SetBelong(this.GetValue());
				}
				return r_MCompare_String_Int32_String_Int32;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod RMCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_MCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_MCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCase(System.String, Int32, Int32, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_MCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32;
		public static RMethod RMCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32
		{
			get
			{
				if(r_MCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32 == null)
				{
					r_MCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32 = new(typeof(System.Globalization.CompareInfo), "CompareOrdinalIgnoreCase", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32.SetBelong(null);
				}
				return r_MCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 CompareOrdinalIgnoreCase(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
		public static RMethod RMCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ == null)
				{
					r_MCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_ = new(typeof(System.Globalization.CompareInfo), "CompareOrdinalIgnoreCase", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_MCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_MCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIsPrefix_String_String_CompareOptions;
		public virtual RMethod RMIsPrefix_String_String_CompareOptions
		{
			get
			{
				if(r_MIsPrefix_String_String_CompareOptions == null)
				{
					r_MIsPrefix_String_String_CompareOptions = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MIsPrefix_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIsPrefix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RMIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_MIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_MIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IsPrefix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_MIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String)
		/// </summary>
		protected RMethod r_MIsPrefix_String_String;
		public virtual RMethod RMIsPrefix_String_String
		{
			get
			{
				if(r_MIsPrefix_String_String == null)
				{
					r_MIsPrefix_String_String = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String));
					r_MIsPrefix_String_String.SetBelong(this.GetValue());
				}
				return r_MIsPrefix_String_String;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIsSuffix_String_String_CompareOptions;
		public virtual RMethod RMIsSuffix_String_String_CompareOptions
		{
			get
			{
				if(r_MIsSuffix_String_String_CompareOptions == null)
				{
					r_MIsSuffix_String_String_CompareOptions = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MIsSuffix_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIsSuffix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RMIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_MIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_MIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IsSuffix", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_MIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String)
		/// </summary>
		protected RMethod r_MIsSuffix_String_String;
		public virtual RMethod RMIsSuffix_String_String
		{
			get
			{
				if(r_MIsSuffix_String_String == null)
				{
					r_MIsSuffix_String_String = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String));
					r_MIsSuffix_String_String.SetBelong(this.GetValue());
				}
				return r_MIsSuffix_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char)
		/// </summary>
		protected RMethod r_MIndexOf_String_Char;
		public virtual RMethod RMIndexOf_String_Char
		{
			get
			{
				if(r_MIndexOf_String_Char == null)
				{
					r_MIndexOf_String_Char = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char));
					r_MIndexOf_String_Char.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_Char;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String)
		/// </summary>
		protected RMethod r_MIndexOf_String_String;
		public virtual RMethod RMIndexOf_String_String
		{
			get
			{
				if(r_MIndexOf_String_String == null)
				{
					r_MIndexOf_String_String = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String));
					r_MIndexOf_String_String.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_String_Char_CompareOptions;
		public virtual RMethod RMIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_MIndexOf_String_Char_CompareOptions == null)
				{
					r_MIndexOf_String_Char_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_String_Char_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_String_String_CompareOptions;
		public virtual RMethod RMIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_MIndexOf_String_String_CompareOptions == null)
				{
					r_MIndexOf_String_String_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_String_Char_Int32;
		public virtual RMethod RMIndexOf_String_Char_Int32
		{
			get
			{
				if(r_MIndexOf_String_Char_Int32 == null)
				{
					r_MIndexOf_String_Char_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32));
					r_MIndexOf_String_Char_Int32.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_String_String_Int32;
		public virtual RMethod RMIndexOf_String_String_Int32
		{
			get
			{
				if(r_MIndexOf_String_String_Int32 == null)
				{
					r_MIndexOf_String_String_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_MIndexOf_String_String_Int32.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_String_Char_Int32_CompareOptions;
		public virtual RMethod RMIndexOf_String_Char_Int32_CompareOptions
		{
			get
			{
				if(r_MIndexOf_String_Char_Int32_CompareOptions == null)
				{
					r_MIndexOf_String_Char_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_String_Char_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_Char_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_String_String_Int32_CompareOptions;
		public virtual RMethod RMIndexOf_String_String_Int32_CompareOptions
		{
			get
			{
				if(r_MIndexOf_String_String_Int32_CompareOptions == null)
				{
					r_MIndexOf_String_String_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_String_String_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_String_Char_Int32_Int32;
		public virtual RMethod RMIndexOf_String_Char_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_String_Char_Int32_Int32 == null)
				{
					r_MIndexOf_String_Char_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_String_Char_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MIndexOf_String_String_Int32_Int32;
		public virtual RMethod RMIndexOf_String_String_Int32_Int32
		{
			get
			{
				if(r_MIndexOf_String_String_Int32_Int32 == null)
				{
					r_MIndexOf_String_String_Int32_Int32 = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MIndexOf_String_String_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RMIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_MIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_MIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RMIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_MIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_MIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinal(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_MIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RMIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_MIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_MIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(this, "IndexOfOrdinal", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_MIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RMIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_MIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_MIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "IndexOf", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_MIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.GetValue());
				}
				return r_MIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_MIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer;
		public virtual RMethod RMIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer
		{
			get
			{
				if(r_MIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer == null)
				{
					r_MIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_MIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer.SetBelong(this.GetValue());
				}
				return r_MIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinal(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MIndexOfOrdinal_String_String_Int32_Int32_Boolean;
		public virtual RMethod RMIndexOfOrdinal_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MIndexOfOrdinal_String_String_Int32_Int32_Boolean == null)
				{
					r_MIndexOfOrdinal_String_String_Int32_Int32_Boolean = new(this, "IndexOfOrdinal", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MIndexOfOrdinal_String_String_Int32_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MIndexOfOrdinal_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Char;
		public virtual RMethod RMLastIndexOf_String_Char
		{
			get
			{
				if(r_MLastIndexOf_String_Char == null)
				{
					r_MLastIndexOf_String_Char = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char));
					r_MLastIndexOf_String_Char.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_Char;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_String;
		public virtual RMethod RMLastIndexOf_String_String
		{
			get
			{
				if(r_MLastIndexOf_String_String == null)
				{
					r_MLastIndexOf_String_String = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String));
					r_MLastIndexOf_String_String.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_String;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Char_CompareOptions;
		public virtual RMethod RMLastIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_MLastIndexOf_String_Char_CompareOptions == null)
				{
					r_MLastIndexOf_String_Char_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOf_String_Char_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_String_CompareOptions;
		public virtual RMethod RMLastIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_MLastIndexOf_String_String_CompareOptions == null)
				{
					r_MLastIndexOf_String_String_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOf_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Char_Int32;
		public virtual RMethod RMLastIndexOf_String_Char_Int32
		{
			get
			{
				if(r_MLastIndexOf_String_Char_Int32 == null)
				{
					r_MLastIndexOf_String_Char_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32));
					r_MLastIndexOf_String_Char_Int32.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_Char_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_String_Int32;
		public virtual RMethod RMLastIndexOf_String_String_Int32
		{
			get
			{
				if(r_MLastIndexOf_String_String_Int32 == null)
				{
					r_MLastIndexOf_String_String_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32));
					r_MLastIndexOf_String_String_Int32.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_String_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Char_Int32_CompareOptions;
		public virtual RMethod RMLastIndexOf_String_Char_Int32_CompareOptions
		{
			get
			{
				if(r_MLastIndexOf_String_Char_Int32_CompareOptions == null)
				{
					r_MLastIndexOf_String_Char_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOf_String_Char_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_Char_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_String_Int32_CompareOptions;
		public virtual RMethod RMLastIndexOf_String_String_Int32_CompareOptions
		{
			get
			{
				if(r_MLastIndexOf_String_String_Int32_CompareOptions == null)
				{
					r_MLastIndexOf_String_String_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOf_String_String_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_String_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Char_Int32_Int32;
		public virtual RMethod RMLastIndexOf_String_Char_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_String_Char_Int32_Int32 == null)
				{
					r_MLastIndexOf_String_Char_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_String_Char_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_String_Int32_Int32;
		public virtual RMethod RMLastIndexOf_String_String_Int32_Int32
		{
			get
			{
				if(r_MLastIndexOf_String_String_Int32_Int32 == null)
				{
					r_MLastIndexOf_String_String_Int32_Int32 = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_MLastIndexOf_String_String_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RMLastIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_MLastIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_MLastIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RMLastIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_MLastIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_MLastIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfOrdinal(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MLastIndexOfOrdinal_String_String_Int32_Int32_Boolean;
		public virtual RMethod RMLastIndexOfOrdinal_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MLastIndexOfOrdinal_String_String_Int32_Int32_Boolean == null)
				{
					r_MLastIndexOfOrdinal_String_String_Int32_Int32_Boolean = new(this, "LastIndexOfOrdinal", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MLastIndexOfOrdinal_String_String_Int32_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MLastIndexOfOrdinal_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MGetSortKey_String_CompareOptions;
		public virtual RMethod RMGetSortKey_String_CompareOptions
		{
			get
			{
				if(r_MGetSortKey_String_CompareOptions == null)
				{
					r_MGetSortKey_String_CompareOptions = new(this, "GetSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MGetSortKey_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MGetSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String)
		/// </summary>
		protected RMethod r_MGetSortKey_String;
		public virtual RMethod RMGetSortKey_String
		{
			get
			{
				if(r_MGetSortKey_String == null)
				{
					r_MGetSortKey_String = new(this, "GetSortKey", 0, typeof(System.String));
					r_MGetSortKey_String.SetBelong(this.GetValue());
				}
				return r_MGetSortKey_String;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Int32 GetIgnoreCaseHash(System.String)
		/// </summary>
		protected static RMethod r_MGetIgnoreCaseHash_String;
		public static RMethod RMGetIgnoreCaseHash_String
		{
			get
			{
				if(r_MGetIgnoreCaseHash_String == null)
				{
					r_MGetIgnoreCaseHash_String = new(typeof(System.Globalization.CompareInfo), "GetIgnoreCaseHash", 0, typeof(System.String));
					r_MGetIgnoreCaseHash_String.SetBelong(null);
				}
				return r_MGetIgnoreCaseHash_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfString(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MGetHashCodeOfString_String_CompareOptions;
		public virtual RMethod RMGetHashCodeOfString_String_CompareOptions
		{
			get
			{
				if(r_MGetHashCodeOfString_String_CompareOptions == null)
				{
					r_MGetHashCodeOfString_String_CompareOptions = new(this, "GetHashCodeOfString", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MGetHashCodeOfString_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MGetHashCodeOfString_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MGetHashCode_String_CompareOptions;
		public virtual RMethod RMGetHashCode_String_CompareOptions
		{
			get
			{
				if(r_MGetHashCode_String_CompareOptions == null)
				{
					r_MGetHashCode_String_CompareOptions = new(this, "GetHashCode", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MGetHashCode_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MGetHashCode_String_CompareOptions;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.Globalization.ISimpleCollator GetCollator()
		/// </summary>
		protected RMethod r_MGetCollator;
		public virtual RMethod RMGetCollator
		{
			get
			{
				if(r_MGetCollator == null)
				{
					r_MGetCollator = new(this, "GetCollator", 0);
					r_MGetCollator.SetBelong(this.GetValue());
				}
				return r_MGetCollator;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey CreateSortKeyCore(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCreateSortKeyCore_String_CompareOptions;
		public virtual RMethod RMCreateSortKeyCore_String_CompareOptions
		{
			get
			{
				if(r_MCreateSortKeyCore_String_CompareOptions == null)
				{
					r_MCreateSortKeyCore_String_CompareOptions = new(this, "CreateSortKeyCore", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MCreateSortKeyCore_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCreateSortKeyCore_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_switch(System.String, Int32, Int32, System.String, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_Minternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean;
		public virtual RMethod RMinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean
		{
			get
			{
				if(r_Minternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean == null)
				{
					r_Minternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean = new(this, "internal_index_switch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_Minternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean.SetBelong(this.GetValue());
				}
				return r_Minternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_compare_switch(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Minternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod RMinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Minternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Minternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "internal_compare_switch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Minternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_Minternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_compare_managed(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_Minternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod RMinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Minternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Minternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "internal_compare_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Minternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_Minternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_managed(System.String, Int32, Int32, Char, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_Minternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean;
		public virtual RMethod RMinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean
		{
			get
			{
				if(r_Minternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean == null)
				{
					r_Minternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean = new(this, "internal_index_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Char), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_Minternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean.SetBelong(this.GetValue());
				}
				return r_Minternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_index_managed(System.String, Int32, Int32, System.String, System.Globalization.CompareOptions, Boolean)
		/// </summary>
		protected RMethod r_Minternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean;
		public virtual RMethod RMinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean
		{
			get
			{
				if(r_Minternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean == null)
				{
					r_Minternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean = new(this, "internal_index_managed", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Globalization.CompareOptions), typeof(System.Boolean));
					r_Minternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean.SetBelong(this.GetValue());
				}
				return r_Minternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_compare_icall(Char*, Int32, Char*, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_Minternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions;
		public static RMethod RMinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions
		{
			get
			{
				if(r_Minternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions == null)
				{
					r_Minternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions = new(typeof(System.Globalization.CompareInfo), "internal_compare_icall", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Minternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions.SetBelong(null);
				}
				return r_Minternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected static RMethod r_Minternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public static RMethod RMinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_Minternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_Minternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(typeof(System.Globalization.CompareInfo), "internal_compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_Minternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(null);
				}
				return r_Minternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 internal_index_icall(Char*, Int32, Int32, Char*, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Minternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean;
		public static RMethod RMinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean
		{
			get
			{
				if(r_Minternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean == null)
				{
					r_Minternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "internal_index_icall", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean));
					r_Minternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean.SetBelong(null);
				}
				return r_Minternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 internal_index(System.String, Int32, Int32, System.String, Boolean)
		/// </summary>
		protected static RMethod r_Minternal_index_String_Int32_Int32_String_Boolean;
		public static RMethod RMinternal_index_String_Int32_Int32_String_Boolean
		{
			get
			{
				if(r_Minternal_index_String_Int32_Int32_String_Boolean == null)
				{
					r_Minternal_index_String_Int32_Int32_String_Boolean = new(typeof(System.Globalization.CompareInfo), "internal_index", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Boolean));
					r_Minternal_index_String_Int32_Int32_String_Boolean.SetBelong(null);
				}
				return r_Minternal_index_String_Int32_Int32_String_Boolean;
			}
		}

		/// <summary>
		/// Void InitSort(System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInitSort_CultureInfo;
		public virtual RMethod RMInitSort_CultureInfo
		{
			get
			{
				if(r_MInitSort_CultureInfo == null)
				{
					r_MInitSort_CultureInfo = new(this, "InitSort", 0, typeof(System.Globalization.CultureInfo));
					r_MInitSort_CultureInfo.SetBelong(this.GetValue());
				}
				return r_MInitSort_CultureInfo;
			}
		}

		/// <summary>
		/// Int32 CompareStringOrdinalIgnoreCase(Char*, Int32, Char*, Int32)
		/// </summary>
		protected static RMethod r_MCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32;
		public static RMethod RMCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32
		{
			get
			{
				if(r_MCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32 == null)
				{
					r_MCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32 = new(typeof(System.Globalization.CompareInfo), "CompareStringOrdinalIgnoreCase", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_MCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32.SetBelong(null);
				}
				return r_MCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinalCore(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
		public static RMethod RMIndexOfOrdinalCore_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MIndexOfOrdinalCore_String_String_Int32_Int32_Boolean == null)
				{
					r_MIndexOfOrdinalCore_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "IndexOfOrdinalCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_MIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfOrdinalCore(System.String, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
		public static RMethod RMLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_MLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean == null)
				{
					r_MLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean = new(typeof(System.Globalization.CompareInfo), "LastIndexOfOrdinalCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.SetBelong(null);
				}
				return r_MLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 LastIndexOfCore(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MLastIndexOfCore_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RMLastIndexOfCore_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_MLastIndexOfCore_String_String_Int32_Int32_CompareOptions == null)
				{
					r_MLastIndexOfCore_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOfCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_MLastIndexOfCore_String_String_Int32_Int32_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MLastIndexOfCore_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOfCore(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_MIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer;
		public virtual RMethod RMIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer
		{
			get
			{
				if(r_MIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer == null)
				{
					r_MIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer = new(this, "IndexOfCore", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_MIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer.SetBelong(this.GetValue());
				}
				return r_MIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfCore(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions, Int32*)
		/// </summary>
		protected RMethod r_MIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer;
		public virtual RMethod RMIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer
		{
			get
			{
				if(r_MIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer == null)
				{
					r_MIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer = new(this, "IndexOfCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions), typeof(System.Int32).MakePointerType());
					r_MIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer.SetBelong(this.GetValue());
				}
				return r_MIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer;
			}
		}

		/// <summary>
		/// Int32 IndexOfOrdinalCore(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected RMethod r_MIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
		public virtual RMethod RMIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_MIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_MIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean = new(this, "IndexOfOrdinalCore", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
					r_MIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.SetBelong(this.GetValue());
				}
				return r_MIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Int32 CompareString(System.ReadOnlySpan`1[System.Char], System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions;
		public virtual RMethod RMCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions
		{
			get
			{
				if(r_MCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions == null)
				{
					r_MCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions = new(this, "CompareString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 CompareString(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RMCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_MCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_MCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "CompareString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_MCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSortable(Char*, Int32)
		/// </summary>
		protected static RMethod r_MIsSortable_CharPointer_Int32;
		public static RMethod RMIsSortable_CharPointer_Int32
		{
			get
			{
				if(r_MIsSortable_CharPointer_Int32 == null)
				{
					r_MIsSortable_CharPointer_Int32 = new(typeof(System.Globalization.CompareInfo), "IsSortable", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_MIsSortable_CharPointer_Int32.SetBelong(null);
				}
				return r_MIsSortable_CharPointer_Int32;
			}
		}

		/// <summary>
		/// System.Globalization.SortKey CreateSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MCreateSortKey_String_CompareOptions;
		public virtual RMethod RMCreateSortKey_String_CompareOptions
		{
			get
			{
				if(r_MCreateSortKey_String_CompareOptions == null)
				{
					r_MCreateSortKey_String_CompareOptions = new(this, "CreateSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MCreateSortKey_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MCreateSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MStartsWith_String_String_CompareOptions;
		public virtual RMethod RMStartsWith_String_String_CompareOptions
		{
			get
			{
				if(r_MStartsWith_String_String_CompareOptions == null)
				{
					r_MStartsWith_String_String_CompareOptions = new(this, "StartsWith", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MStartsWith_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MStartsWith_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RMStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_MStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_MStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "StartsWith", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_MStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.GetValue());
				}
				return r_MStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MEndsWith_String_String_CompareOptions;
		public virtual RMethod RMEndsWith_String_String_CompareOptions
		{
			get
			{
				if(r_MEndsWith_String_String_CompareOptions == null)
				{
					r_MEndsWith_String_String_CompareOptions = new(this, "EndsWith", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MEndsWith_String_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MEndsWith_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean EndsWith(System.ReadOnlySpan`1[System.Char], System.ReadOnlySpan`1[System.Char], System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
		public virtual RMethod RMEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions
		{
			get
			{
				if(r_MEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions == null)
				{
					r_MEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions = new(this, "EndsWith", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Globalization.CompareOptions));
					r_MEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.SetBelong(this.GetValue());
				}
				return r_MEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfStringCore(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_MGetHashCodeOfStringCore_String_CompareOptions;
		public virtual RMethod RMGetHashCodeOfStringCore_String_CompareOptions
		{
			get
			{
				if(r_MGetHashCodeOfStringCore_String_CompareOptions == null)
				{
					r_MGetHashCodeOfStringCore_String_CompareOptions = new(this, "GetHashCodeOfStringCore", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_MGetHashCodeOfStringCore_String_CompareOptions.SetBelong(this.GetValue());
				}
				return r_MGetHashCodeOfStringCore_String_CompareOptions;
			}
		}

		/// <summary>
		/// System.Globalization.SortVersion GetSortVersion()
		/// </summary>
		protected RMethod r_MGetSortVersion;
		public virtual RMethod RMGetSortVersion
		{
			get
			{
				if(r_MGetSortVersion == null)
				{
					r_MGetSortVersion = new(this, "GetSortVersion", 0);
					r_MGetSortVersion.SetBelong(this.GetValue());
				}
				return r_MGetSortVersion;
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
            var ___result = RMInvariantIndexOf_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 InvariantIndexOf(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @ignoreCase};
            var ___result = RMInvariantIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 InvariantLastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RMInvariantLastIndexOf_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 InvariantFindString(System.Char* @source, System.Int32 @sourceCount, System.Char* @value, System.Int32 @valueCount, System.Boolean @ignoreCase, System.Boolean @start)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@source, typeof(System.Char)), @sourceCount, Pointer.Box(@value, typeof(System.Char)), @valueCount, @ignoreCase, @start};
            var ___result = RMInvariantFindString_CharPointer_Int32_CharPointer_Int32_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Char InvariantToUpper(System.Char @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMInvariantToUpper_Char.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.Globalization.SortKey InvariantCreateSortKey(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMInvariantCreateSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.Int32 @culture, System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture, @assembly};
            var ___result = RMGetCompareInfo_Int32_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.String @name, System.Reflection.Assembly @assembly)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @assembly};
            var ___result = RMGetCompareInfo_String_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.Int32 @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMGetCompareInfo_Int32.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Globalization.CompareInfo GetCompareInfo(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetCompareInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.CompareInfo)___result;
        }


        public static System.Boolean IsSortable(System.Char @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RMIsSortable_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSortable(System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RMIsSortable_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnDeserializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization(System.Object @sender)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IDeserializationCallback__2__OnDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDeserialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSerializing(System.Runtime.Serialization.StreamingContext @ctx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx};
            var ___result = RMOnSerializing_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Compare(System.String @string1, System.String @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @string2};
            var ___result = RMCompare_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.String @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @string2, @options};
            var ___result = RMCompare_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string1, System.String @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2, @options};
            var ___result = RMCompare_ReadOnlySpan_d_Char_p__String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareOptionNone(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string1, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2.Value};
            var ___result = RMCompareOptionNone_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareOptionIgnoreCase(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string1, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2.Value};
            var ___result = RMCompareOptionIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.Int32 @length1, System.String @string2, System.Int32 @offset2, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2};
            var ___result = RMCompare_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.String @string2, System.Int32 @offset2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @string2, @offset2, @options};
            var ___result = RMCompare_String_Int32_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.String @string2, System.Int32 @offset2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @string2, @offset2};
            var ___result = RMCompare_String_Int32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String @string1, System.Int32 @offset1, System.Int32 @length1, System.String @string2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1, @offset1, @length1, @string2, @offset2, @length2, @options};
            var ___result = RMCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCase(System.String @strA, System.Int32 @indexA, System.Int32 @lengthA, System.String @strB, System.Int32 @indexB, System.Int32 @lengthB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA, @indexA, @lengthA, @strB, @indexB, @lengthB};
            var ___result = RMCompareOrdinalIgnoreCase_String_Int32_Int32_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 CompareOrdinalIgnoreCase(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @strA, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @strB)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strA.Value, @strB.Value};
            var ___result = RMCompareOrdinalIgnoreCase_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsPrefix(System.String @source, System.String @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix, @options};
            var ___result = RMIsPrefix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrefix(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @prefix.Value, @options};
            var ___result = RMIsPrefix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrefix(System.String @source, System.String @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix};
            var ___result = RMIsPrefix_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(System.String @source, System.String @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix, @options};
            var ___result = RMIsSuffix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @suffix.Value, @options};
            var ___result = RMIsSuffix_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(System.String @source, System.String @suffix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix};
            var ___result = RMIsSuffix_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RMIndexOf_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RMIndexOf_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RMIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RMIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RMIndexOf_String_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RMIndexOf_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RMIndexOf_String_Char_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RMIndexOf_String_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RMIndexOf_String_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RMIndexOf_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RMIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RMIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfOrdinal(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @ignoreCase};
            var ___result = RMIndexOfOrdinal_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @options};
            var ___result = RMIndexOf_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 IndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options, System.Int32* @matchLengthPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options, Pointer.Box(@matchLengthPtr, typeof(System.Int32))};
            var ___result = RMIndexOf_String_String_Int32_Int32_CompareOptions_Int32Pointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfOrdinal(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RMIndexOfOrdinal_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RMLastIndexOf_String_Char.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RMLastIndexOf_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RMLastIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @options};
            var ___result = RMLastIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RMLastIndexOf_String_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex};
            var ___result = RMLastIndexOf_String_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RMLastIndexOf_String_Char_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @options};
            var ___result = RMLastIndexOf_String_String_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RMLastIndexOf_String_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count};
            var ___result = RMLastIndexOf_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.Char @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RMLastIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @options};
            var ___result = RMLastIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfOrdinal(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RMLastIndexOfOrdinal_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Globalization.SortKey GetSortKey(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMGetSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Globalization.SortKey GetSortKey(System.String @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMGetSortKey_String.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Boolean Equals(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetIgnoreCaseHash(System.String @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMGetIgnoreCaseHash_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCodeOfString(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMGetHashCodeOfString_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMGetHashCode_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RGlobalization.RISimpleCollator GetCollator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCollator.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RGlobalization.RISimpleCollator(___result);
        }


        public virtual System.Globalization.SortKey CreateSortKeyCore(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMCreateSortKeyCore_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Int32 internal_index_switch(System.String @s1, System.Int32 @sindex, System.Int32 @count, System.String @s2, System.Globalization.CompareOptions @opt, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @sindex, @count, @s2, @opt, @first};
            var ___result = RMinternal_index_switch_String_Int32_Int32_String_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_compare_switch(System.String @str1, System.Int32 @offset1, System.Int32 @length1, System.String @str2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = RMinternal_compare_switch_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_compare_managed(System.String @str1, System.Int32 @offset1, System.Int32 @length1, System.String @str2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = RMinternal_compare_managed_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_index_managed(System.String @s, System.Int32 @sindex, System.Int32 @count, System.Char @c, System.Globalization.CompareOptions @opt, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @sindex, @count, @c, @opt, @first};
            var ___result = RMinternal_index_managed_String_Int32_Int32_Char_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 internal_index_managed(System.String @s1, System.Int32 @sindex, System.Int32 @count, System.String @s2, System.Globalization.CompareOptions @opt, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @sindex, @count, @s2, @opt, @first};
            var ___result = RMinternal_index_managed_String_Int32_Int32_String_CompareOptions_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 internal_compare_icall(System.Char* @str1, System.Int32 @length1, System.Char* @str2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@str1, typeof(System.Char)), @length1, Pointer.Box(@str2, typeof(System.Char)), @length2, @options};
            var ___result = RMinternal_compare_icall_CharPointer_Int32_CharPointer_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 internal_compare(System.String @str1, System.Int32 @offset1, System.Int32 @length1, System.String @str2, System.Int32 @offset2, System.Int32 @length2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str1, @offset1, @length1, @str2, @offset2, @length2, @options};
            var ___result = RMinternal_compare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Int32 internal_index_icall(System.Char* @source, System.Int32 @sindex, System.Int32 @count, System.Char* @value, System.Int32 @value_length, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@source, typeof(System.Char)), @sindex, @count, Pointer.Box(@value, typeof(System.Char)), @value_length, @first};
            var ___result = RMinternal_index_icall_CharPointer_Int32_Int32_CharPointer_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 internal_index(System.String @source, System.Int32 @sindex, System.Int32 @count, System.String @value, System.Boolean @first)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @sindex, @count, @value, @first};
            var ___result = RMinternal_index_String_Int32_Int32_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitSort(System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@culture};
            var ___result = RMInitSort_CultureInfo.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe static System.Int32 CompareStringOrdinalIgnoreCase(System.Char* @pString1, System.Int32 @length1, System.Char* @pString2, System.Int32 @length2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@pString1, typeof(System.Char)), @length1, Pointer.Box(@pString2, typeof(System.Char)), @length2};
            var ___result = RMCompareStringOrdinalIgnoreCase_CharPointer_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 IndexOfOrdinalCore(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RMIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 LastIndexOfOrdinalCore(System.String @source, System.String @value, System.Int32 @startIndex, System.Int32 @count, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value, @startIndex, @count, @ignoreCase};
            var ___result = RMLastIndexOfOrdinalCore_String_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOfCore(System.String @source, System.String @target, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target, @startIndex, @count, @options};
            var ___result = RMLastIndexOfCore_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 IndexOfCore(System.String @source, System.String @target, System.Int32 @startIndex, System.Int32 @count, System.Globalization.CompareOptions @options, System.Int32* @matchLengthPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @target, @startIndex, @count, @options, Pointer.Box(@matchLengthPtr, typeof(System.Int32))};
            var ___result = RMIndexOfCore_String_String_Int32_Int32_CompareOptions_Int32Pointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe virtual System.Int32 IndexOfCore(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @target, System.Globalization.CompareOptions @options, System.Int32* @matchLengthPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @target.Value, @options, Pointer.Box(@matchLengthPtr, typeof(System.Int32))};
            var ___result = RMIndexOfCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions_Int32Pointer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOfOrdinalCore(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @value, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @value.Value, @ignoreCase};
            var ___result = RMIndexOfOrdinalCore_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareString(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string1, System.String @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2, @options};
            var ___result = RMCompareString_ReadOnlySpan_d_Char_p__String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 CompareString(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string1, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @string2, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@string1.Value, @string2.Value, @options};
            var ___result = RMCompareString_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.Boolean IsSortable(System.Char* @text, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@text, typeof(System.Char)), @length};
            var ___result = RMIsSortable_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Globalization.SortKey CreateSortKey(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMCreateSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Boolean StartsWith(System.String @source, System.String @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @prefix, @options};
            var ___result = RMStartsWith_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartsWith(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @prefix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @prefix.Value, @options};
            var ___result = RMStartsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(System.String @source, System.String @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @suffix, @options};
            var ___result = RMEndsWith_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean EndsWith(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @source, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @suffix, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source.Value, @suffix.Value, @options};
            var ___result = RMEndsWith_ReadOnlySpan_d_Char_p__ReadOnlySpan_d_Char_p__CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCodeOfStringCore(System.String @source, System.Globalization.CompareOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RMGetHashCodeOfStringCore_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Globalization.SortVersion GetSortVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSortVersion.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortVersion)___result;
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
