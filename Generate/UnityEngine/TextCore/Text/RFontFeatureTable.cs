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
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> r_m_MultipleSubstitutionRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> Rm_MultipleSubstitutionRecords
		{
			get
			{
				if(r_m_MultipleSubstitutionRecords == null)
				{
					r_m_MultipleSubstitutionRecords = new(this, "m_MultipleSubstitutionRecords");
					r_m_MultipleSubstitutionRecords.SetBelong(this.instance);
				}
				return r_m_MultipleSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord] m_LigatureSubstitutionRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> r_m_LigatureSubstitutionRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> Rm_LigatureSubstitutionRecords
		{
			get
			{
				if(r_m_LigatureSubstitutionRecords == null)
				{
					r_m_LigatureSubstitutionRecords = new(this, "m_LigatureSubstitutionRecords");
					r_m_LigatureSubstitutionRecords.SetBelong(this.instance);
				}
				return r_m_LigatureSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] m_GlyphPairAdjustmentRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_m_GlyphPairAdjustmentRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> Rm_GlyphPairAdjustmentRecords
		{
			get
			{
				if(r_m_GlyphPairAdjustmentRecords == null)
				{
					r_m_GlyphPairAdjustmentRecords = new(this, "m_GlyphPairAdjustmentRecords");
					r_m_GlyphPairAdjustmentRecords.SetBelong(this.instance);
				}
				return r_m_GlyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] m_MarkToBaseAdjustmentRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_m_MarkToBaseAdjustmentRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> Rm_MarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_m_MarkToBaseAdjustmentRecords == null)
				{
					r_m_MarkToBaseAdjustmentRecords = new(this, "m_MarkToBaseAdjustmentRecords");
					r_m_MarkToBaseAdjustmentRecords.SetBelong(this.instance);
				}
				return r_m_MarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] m_MarkToMarkAdjustmentRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_m_MarkToMarkAdjustmentRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> Rm_MarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_m_MarkToMarkAdjustmentRecords == null)
				{
					r_m_MarkToMarkAdjustmentRecords = new(this, "m_MarkToMarkAdjustmentRecords");
					r_m_MarkToMarkAdjustmentRecords.SetBelong(this.instance);
				}
				return r_m_MarkToMarkAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord]] m_LigatureSubstitutionRecordLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord>> r_m_LigatureSubstitutionRecordLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord>> Rm_LigatureSubstitutionRecordLookup
		{
			get
			{
				if(r_m_LigatureSubstitutionRecordLookup == null)
				{
					r_m_LigatureSubstitutionRecordLookup = new(this, "m_LigatureSubstitutionRecordLookup");
					r_m_LigatureSubstitutionRecordLookup.SetBelong(this.instance);
				}
				return r_m_LigatureSubstitutionRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] m_GlyphPairAdjustmentRecordLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_m_GlyphPairAdjustmentRecordLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> Rm_GlyphPairAdjustmentRecordLookup
		{
			get
			{
				if(r_m_GlyphPairAdjustmentRecordLookup == null)
				{
					r_m_GlyphPairAdjustmentRecordLookup = new(this, "m_GlyphPairAdjustmentRecordLookup");
					r_m_GlyphPairAdjustmentRecordLookup.SetBelong(this.instance);
				}
				return r_m_GlyphPairAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] m_MarkToBaseAdjustmentRecordLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_m_MarkToBaseAdjustmentRecordLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> Rm_MarkToBaseAdjustmentRecordLookup
		{
			get
			{
				if(r_m_MarkToBaseAdjustmentRecordLookup == null)
				{
					r_m_MarkToBaseAdjustmentRecordLookup = new(this, "m_MarkToBaseAdjustmentRecordLookup");
					r_m_MarkToBaseAdjustmentRecordLookup.SetBelong(this.instance);
				}
				return r_m_MarkToBaseAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] m_MarkToMarkAdjustmentRecordLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_m_MarkToMarkAdjustmentRecordLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> Rm_MarkToMarkAdjustmentRecordLookup
		{
			get
			{
				if(r_m_MarkToMarkAdjustmentRecordLookup == null)
				{
					r_m_MarkToMarkAdjustmentRecordLookup = new(this, "m_MarkToMarkAdjustmentRecordLookup");
					r_m_MarkToMarkAdjustmentRecordLookup.SetBelong(this.instance);
				}
				return r_m_MarkToMarkAdjustmentRecordLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord] multipleSubstitutionRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> r_multipleSubstitutionRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMultipleSubstitutionRecord> RmultipleSubstitutionRecords
		{
			get
			{
				if(r_multipleSubstitutionRecords == null)
				{
					r_multipleSubstitutionRecords = new(this, "multipleSubstitutionRecords", -1);
					r_multipleSubstitutionRecords.SetBelong(this.instance);
				}
				return r_multipleSubstitutionRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord] ligatureRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> r_ligatureRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RLigatureSubstitutionRecord> RligatureRecords
		{
			get
			{
				if(r_ligatureRecords == null)
				{
					r_ligatureRecords = new(this, "ligatureRecords", -1);
					r_ligatureRecords.SetBelong(this.instance);
				}
				return r_ligatureRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord] glyphPairAdjustmentRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> r_glyphPairAdjustmentRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RGlyphPairAdjustmentRecord> RglyphPairAdjustmentRecords
		{
			get
			{
				if(r_glyphPairAdjustmentRecords == null)
				{
					r_glyphPairAdjustmentRecords = new(this, "glyphPairAdjustmentRecords", -1);
					r_glyphPairAdjustmentRecords.SetBelong(this.instance);
				}
				return r_glyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord] MarkToBaseAdjustmentRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> r_MarkToBaseAdjustmentRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToBaseAdjustmentRecord> RMarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_MarkToBaseAdjustmentRecords == null)
				{
					r_MarkToBaseAdjustmentRecords = new(this, "MarkToBaseAdjustmentRecords", -1);
					r_MarkToBaseAdjustmentRecords.SetBelong(this.instance);
				}
				return r_MarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord] MarkToMarkAdjustmentRecords
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> r_MarkToMarkAdjustmentRecords;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RLowLevel.RMarkToMarkAdjustmentRecord> RMarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_MarkToMarkAdjustmentRecords == null)
				{
					r_MarkToMarkAdjustmentRecords = new(this, "MarkToMarkAdjustmentRecords", -1);
					r_MarkToMarkAdjustmentRecords.SetBelong(this.instance);
				}
				return r_MarkToMarkAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void SortGlyphPairAdjustmentRecords()
		/// </summary>
		protected RMethod r_RSortGlyphPairAdjustmentRecords;
		public virtual RMethod RSortGlyphPairAdjustmentRecords
		{
			get
			{
				if(r_RSortGlyphPairAdjustmentRecords == null)
				{
					r_RSortGlyphPairAdjustmentRecords = new(this, "SortGlyphPairAdjustmentRecords", 0);
					r_RSortGlyphPairAdjustmentRecords.SetBelong(this.instance);
				}
				return r_RSortGlyphPairAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void SortMarkToBaseAdjustmentRecords()
		/// </summary>
		protected RMethod r_RSortMarkToBaseAdjustmentRecords;
		public virtual RMethod RSortMarkToBaseAdjustmentRecords
		{
			get
			{
				if(r_RSortMarkToBaseAdjustmentRecords == null)
				{
					r_RSortMarkToBaseAdjustmentRecords = new(this, "SortMarkToBaseAdjustmentRecords", 0);
					r_RSortMarkToBaseAdjustmentRecords.SetBelong(this.instance);
				}
				return r_RSortMarkToBaseAdjustmentRecords;
			}
		}

		/// <summary>
		/// Void SortMarkToMarkAdjustmentRecords()
		/// </summary>
		protected RMethod r_RSortMarkToMarkAdjustmentRecords;
		public virtual RMethod RSortMarkToMarkAdjustmentRecords
		{
			get
			{
				if(r_RSortMarkToMarkAdjustmentRecords == null)
				{
					r_RSortMarkToMarkAdjustmentRecords = new(this, "SortMarkToMarkAdjustmentRecords", 0);
					r_RSortMarkToMarkAdjustmentRecords.SetBelong(this.instance);
				}
				return r_RSortMarkToMarkAdjustmentRecords;
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
            var ___result = RSortGlyphPairAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortMarkToBaseAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortMarkToBaseAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortMarkToMarkAdjustmentRecords()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortMarkToMarkAdjustmentRecords.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
