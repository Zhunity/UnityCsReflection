
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.Text.FontFeatureTable
	/// </summary>
    public partial class RFontFeatureTable : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.FontFeatureTable);
            }
        }

        public RFontFeatureTable() : base("UnityEngine.TextCore.Text.FontFeatureTable")
        {
        }

        public RFontFeatureTable(System.Object instance) : base("UnityEngine.TextCore.Text.FontFeatureTable")
		{
            SetInstance(instance);
		}

        public RFontFeatureTable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFontFeatureTable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord] m_MultipleSubstitutionRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> r_Fm_MultipleSubstitutionRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> RFm_MultipleSubstitutionRecords
		{
			get
			{
				if(r_Fm_MultipleSubstitutionRecords == null)
				{
					r_Fm_MultipleSubstitutionRecords = new(this, "m_MultipleSubstitutionRecords");
				}
				return r_Fm_MultipleSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord] m_LigatureSubstitutionRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> r_Fm_LigatureSubstitutionRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> RFm_LigatureSubstitutionRecords
		{
			get
			{
				if(r_Fm_LigatureSubstitutionRecords == null)
				{
					r_Fm_LigatureSubstitutionRecords = new(this, "m_LigatureSubstitutionRecords");
				}
				return r_Fm_LigatureSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] m_GlyphPairAdjustmentRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_Fm_GlyphPairAdjustmentRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RFm_GlyphPairAdjustmentRecords
		{
			get
			{
				if(r_Fm_GlyphPairAdjustmentRecords == null)
				{
					r_Fm_GlyphPairAdjustmentRecords = new(this, "m_GlyphPairAdjustmentRecords");
				}
				return r_Fm_GlyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] m_MarkToBaseAdjustmentRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_Fm_MarkToBaseAdjustmentRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RFm_MarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_Fm_MarkToBaseAdjustmentRecords == null)
				{
					r_Fm_MarkToBaseAdjustmentRecords = new(this, "m_MarkToBaseAdjustmentRecords");
				}
				return r_Fm_MarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] m_MarkToMarkAdjustmentRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_Fm_MarkToMarkAdjustmentRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RFm_MarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_Fm_MarkToMarkAdjustmentRecords == null)
				{
					r_Fm_MarkToMarkAdjustmentRecords = new(this, "m_MarkToMarkAdjustmentRecords");
				}
				return r_Fm_MarkToMarkAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord]] m_LigatureSubstitutionRecordLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord>> r_Fm_LigatureSubstitutionRecordLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord>> RFm_LigatureSubstitutionRecordLookup
		{
			get
			{
				if(r_Fm_LigatureSubstitutionRecordLookup == null)
				{
					r_Fm_LigatureSubstitutionRecordLookup = new(this, "m_LigatureSubstitutionRecordLookup");
				}
				return r_Fm_LigatureSubstitutionRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] m_GlyphPairAdjustmentRecordLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_Fm_GlyphPairAdjustmentRecordLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RFm_GlyphPairAdjustmentRecordLookup
		{
			get
			{
				if(r_Fm_GlyphPairAdjustmentRecordLookup == null)
				{
					r_Fm_GlyphPairAdjustmentRecordLookup = new(this, "m_GlyphPairAdjustmentRecordLookup");
				}
				return r_Fm_GlyphPairAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] m_MarkToBaseAdjustmentRecordLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_Fm_MarkToBaseAdjustmentRecordLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RFm_MarkToBaseAdjustmentRecordLookup
		{
			get
			{
				if(r_Fm_MarkToBaseAdjustmentRecordLookup == null)
				{
					r_Fm_MarkToBaseAdjustmentRecordLookup = new(this, "m_MarkToBaseAdjustmentRecordLookup");
				}
				return r_Fm_MarkToBaseAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] m_MarkToMarkAdjustmentRecordLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_Fm_MarkToMarkAdjustmentRecordLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RFm_MarkToMarkAdjustmentRecordLookup
		{
			get
			{
				if(r_Fm_MarkToMarkAdjustmentRecordLookup == null)
				{
					r_Fm_MarkToMarkAdjustmentRecordLookup = new(this, "m_MarkToMarkAdjustmentRecordLookup");
				}
				return r_Fm_MarkToMarkAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord] multipleSubstitutionRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> r_PmultipleSubstitutionRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> RPmultipleSubstitutionRecords
		{
			get
			{
				if(r_PmultipleSubstitutionRecords == null)
				{
					r_PmultipleSubstitutionRecords = new(this, "multipleSubstitutionRecords", -1);
				}
				return r_PmultipleSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord] ligatureRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> r_PligatureRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> RPligatureRecords
		{
			get
			{
				if(r_PligatureRecords == null)
				{
					r_PligatureRecords = new(this, "ligatureRecords", -1);
				}
				return r_PligatureRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] glyphPairAdjustmentRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_PglyphPairAdjustmentRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RPglyphPairAdjustmentRecords
		{
			get
			{
				if(r_PglyphPairAdjustmentRecords == null)
				{
					r_PglyphPairAdjustmentRecords = new(this, "glyphPairAdjustmentRecords", -1);
				}
				return r_PglyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] MarkToBaseAdjustmentRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_PMarkToBaseAdjustmentRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RPMarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_PMarkToBaseAdjustmentRecords == null)
				{
					r_PMarkToBaseAdjustmentRecords = new(this, "MarkToBaseAdjustmentRecords", -1);
				}
				return r_PMarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] MarkToMarkAdjustmentRecords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_PMarkToMarkAdjustmentRecords;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RPMarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_PMarkToMarkAdjustmentRecords == null)
				{
					r_PMarkToMarkAdjustmentRecords = new(this, "MarkToMarkAdjustmentRecords", -1);
				}
				return r_PMarkToMarkAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void SortGlyphPairAdjustmentRecords()
		/// </summary>
		protected RMethod r_MSortGlyphPairAdjustmentRecords;
		public virtual RMethod RMSortGlyphPairAdjustmentRecords
		{
			get
			{
				if(r_MSortGlyphPairAdjustmentRecords == null)
				{
					r_MSortGlyphPairAdjustmentRecords = new(this, "SortGlyphPairAdjustmentRecords", 0);
				}
				return r_MSortGlyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void SortMarkToBaseAdjustmentRecords()
		/// </summary>
		protected RMethod r_MSortMarkToBaseAdjustmentRecords;
		public virtual RMethod RMSortMarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_MSortMarkToBaseAdjustmentRecords == null)
				{
					r_MSortMarkToBaseAdjustmentRecords = new(this, "SortMarkToBaseAdjustmentRecords", 0);
				}
				return r_MSortMarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void SortMarkToMarkAdjustmentRecords()
		/// </summary>
		protected RMethod r_MSortMarkToMarkAdjustmentRecords;
		public virtual RMethod RMSortMarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_MSortMarkToMarkAdjustmentRecords == null)
				{
					r_MSortMarkToMarkAdjustmentRecords = new(this, "SortMarkToMarkAdjustmentRecords", 0);
				}
				return r_MSortMarkToMarkAdjustmentRecords;
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


        public virtual void SortGlyphPairAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortGlyphPairAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortMarkToBaseAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortMarkToBaseAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortMarkToMarkAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortMarkToMarkAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
