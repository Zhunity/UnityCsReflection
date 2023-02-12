
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.FontFeatureTable
	/// </summary>
    public partial class RFontFeatureTable : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord] m_MultipleSubstitutionRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> r_Fm_MultipleSubstitutionRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> RFm_MultipleSubstitutionRecords
		{
			get
			{
				if(r_Fm_MultipleSubstitutionRecords == null)
				{
					r_Fm_MultipleSubstitutionRecords = new(this, "m_MultipleSubstitutionRecords");
					r_Fm_MultipleSubstitutionRecords.SetBelong(this.instance);
				}
				return r_Fm_MultipleSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord] m_LigatureSubstitutionRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> r_Fm_LigatureSubstitutionRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> RFm_LigatureSubstitutionRecords
		{
			get
			{
				if(r_Fm_LigatureSubstitutionRecords == null)
				{
					r_Fm_LigatureSubstitutionRecords = new(this, "m_LigatureSubstitutionRecords");
					r_Fm_LigatureSubstitutionRecords.SetBelong(this.instance);
				}
				return r_Fm_LigatureSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] m_GlyphPairAdjustmentRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_Fm_GlyphPairAdjustmentRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RFm_GlyphPairAdjustmentRecords
		{
			get
			{
				if(r_Fm_GlyphPairAdjustmentRecords == null)
				{
					r_Fm_GlyphPairAdjustmentRecords = new(this, "m_GlyphPairAdjustmentRecords");
					r_Fm_GlyphPairAdjustmentRecords.SetBelong(this.instance);
				}
				return r_Fm_GlyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] m_MarkToBaseAdjustmentRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_Fm_MarkToBaseAdjustmentRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RFm_MarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_Fm_MarkToBaseAdjustmentRecords == null)
				{
					r_Fm_MarkToBaseAdjustmentRecords = new(this, "m_MarkToBaseAdjustmentRecords");
					r_Fm_MarkToBaseAdjustmentRecords.SetBelong(this.instance);
				}
				return r_Fm_MarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] m_MarkToMarkAdjustmentRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_Fm_MarkToMarkAdjustmentRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RFm_MarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_Fm_MarkToMarkAdjustmentRecords == null)
				{
					r_Fm_MarkToMarkAdjustmentRecords = new(this, "m_MarkToMarkAdjustmentRecords");
					r_Fm_MarkToMarkAdjustmentRecords.SetBelong(this.instance);
				}
				return r_Fm_MarkToMarkAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord]] m_LigatureSubstitutionRecordLookup
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord>> r_Fm_LigatureSubstitutionRecordLookup;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord>> RFm_LigatureSubstitutionRecordLookup
		{
			get
			{
				if(r_Fm_LigatureSubstitutionRecordLookup == null)
				{
					r_Fm_LigatureSubstitutionRecordLookup = new(this, "m_LigatureSubstitutionRecordLookup");
					r_Fm_LigatureSubstitutionRecordLookup.SetBelong(this.instance);
				}
				return r_Fm_LigatureSubstitutionRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] m_GlyphPairAdjustmentRecordLookup
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_Fm_GlyphPairAdjustmentRecordLookup;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RFm_GlyphPairAdjustmentRecordLookup
		{
			get
			{
				if(r_Fm_GlyphPairAdjustmentRecordLookup == null)
				{
					r_Fm_GlyphPairAdjustmentRecordLookup = new(this, "m_GlyphPairAdjustmentRecordLookup");
					r_Fm_GlyphPairAdjustmentRecordLookup.SetBelong(this.instance);
				}
				return r_Fm_GlyphPairAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] m_MarkToBaseAdjustmentRecordLookup
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_Fm_MarkToBaseAdjustmentRecordLookup;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RFm_MarkToBaseAdjustmentRecordLookup
		{
			get
			{
				if(r_Fm_MarkToBaseAdjustmentRecordLookup == null)
				{
					r_Fm_MarkToBaseAdjustmentRecordLookup = new(this, "m_MarkToBaseAdjustmentRecordLookup");
					r_Fm_MarkToBaseAdjustmentRecordLookup.SetBelong(this.instance);
				}
				return r_Fm_MarkToBaseAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] m_MarkToMarkAdjustmentRecordLookup
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_Fm_MarkToMarkAdjustmentRecordLookup;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<SMFrame.Editor.Refleaction.RSystem.RUInt32, SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RFm_MarkToMarkAdjustmentRecordLookup
		{
			get
			{
				if(r_Fm_MarkToMarkAdjustmentRecordLookup == null)
				{
					r_Fm_MarkToMarkAdjustmentRecordLookup = new(this, "m_MarkToMarkAdjustmentRecordLookup");
					r_Fm_MarkToMarkAdjustmentRecordLookup.SetBelong(this.instance);
				}
				return r_Fm_MarkToMarkAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord] multipleSubstitutionRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> r_PmultipleSubstitutionRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> RPmultipleSubstitutionRecords
		{
			get
			{
				if(r_PmultipleSubstitutionRecords == null)
				{
					r_PmultipleSubstitutionRecords = new(this, "multipleSubstitutionRecords", -1);
					r_PmultipleSubstitutionRecords.SetBelong(this.instance);
				}
				return r_PmultipleSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord] ligatureRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> r_PligatureRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> RPligatureRecords
		{
			get
			{
				if(r_PligatureRecords == null)
				{
					r_PligatureRecords = new(this, "ligatureRecords", -1);
					r_PligatureRecords.SetBelong(this.instance);
				}
				return r_PligatureRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] glyphPairAdjustmentRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_PglyphPairAdjustmentRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RPglyphPairAdjustmentRecords
		{
			get
			{
				if(r_PglyphPairAdjustmentRecords == null)
				{
					r_PglyphPairAdjustmentRecords = new(this, "glyphPairAdjustmentRecords", -1);
					r_PglyphPairAdjustmentRecords.SetBelong(this.instance);
				}
				return r_PglyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] MarkToBaseAdjustmentRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_PMarkToBaseAdjustmentRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RPMarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_PMarkToBaseAdjustmentRecords == null)
				{
					r_PMarkToBaseAdjustmentRecords = new(this, "MarkToBaseAdjustmentRecords", -1);
					r_PMarkToBaseAdjustmentRecords.SetBelong(this.instance);
				}
				return r_PMarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] MarkToMarkAdjustmentRecords
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_PMarkToMarkAdjustmentRecords;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RPMarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_PMarkToMarkAdjustmentRecords == null)
				{
					r_PMarkToMarkAdjustmentRecords = new(this, "MarkToMarkAdjustmentRecords", -1);
					r_PMarkToMarkAdjustmentRecords.SetBelong(this.instance);
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
					r_MSortGlyphPairAdjustmentRecords.SetBelong(this.instance);
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
					r_MSortMarkToBaseAdjustmentRecords.SetBelong(this.instance);
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
					r_MSortMarkToMarkAdjustmentRecords.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
