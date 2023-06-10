
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.SpriteAsset
	/// </summary>
    public partial class RSpriteAsset : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.Text.SpriteAsset);
            }
        }

        public RSpriteAsset() : base("UnityEngine.TextCore.Text.SpriteAsset")
        {
        }

        public RSpriteAsset(System.Object instance) : base("UnityEngine.TextCore.Text.SpriteAsset")
		{
            SetInstance(instance);
		}

        public RSpriteAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpriteAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Int32] m_NameLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_NameLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RSystem.RInt32> RFm_NameLookup
		{
			get
			{
				if(r_Fm_NameLookup == null)
				{
					r_Fm_NameLookup = new(this, "m_NameLookup");
				}
				return r_Fm_NameLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,System.Int32] m_GlyphIndexLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_GlyphIndexLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RSystem.RInt32> RFm_GlyphIndexLookup
		{
			get
			{
				if(r_Fm_GlyphIndexLookup == null)
				{
					r_Fm_GlyphIndexLookup = new(this, "m_GlyphIndexLookup");
				}
				return r_Fm_GlyphIndexLookup;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo m_FaceInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo r_Fm_FaceInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo RFm_FaceInfo
		{
			get
			{
				if(r_Fm_FaceInfo == null)
				{
					r_Fm_FaceInfo = new(this, "m_FaceInfo");
				}
				return r_Fm_FaceInfo;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_SpriteAtlasTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_Fm_SpriteAtlasTexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RFm_SpriteAtlasTexture
		{
			get
			{
				if(r_Fm_SpriteAtlasTexture == null)
				{
					r_Fm_SpriteAtlasTexture = new(this, "m_SpriteAtlasTexture");
				}
				return r_Fm_SpriteAtlasTexture;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteCharacter] m_SpriteCharacterTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> r_Fm_SpriteCharacterTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> RFm_SpriteCharacterTable
		{
			get
			{
				if(r_Fm_SpriteCharacterTable == null)
				{
					r_Fm_SpriteCharacterTable = new(this, "m_SpriteCharacterTable");
				}
				return r_Fm_SpriteCharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter] m_SpriteCharacterLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> r_Fm_SpriteCharacterLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> RFm_SpriteCharacterLookup
		{
			get
			{
				if(r_Fm_SpriteCharacterLookup == null)
				{
					r_Fm_SpriteCharacterLookup = new(this, "m_SpriteCharacterLookup");
				}
				return r_Fm_SpriteCharacterLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteGlyph] m_SpriteGlyphTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteGlyph> r_Fm_SpriteGlyphTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteGlyph> RFm_SpriteGlyphTable
		{
			get
			{
				if(r_Fm_SpriteGlyphTable == null)
				{
					r_Fm_SpriteGlyphTable = new(this, "m_SpriteGlyphTable");
				}
				return r_Fm_SpriteGlyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.SpriteGlyph] m_SpriteGlyphLookup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteGlyph> r_Fm_SpriteGlyphLookup;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteGlyph> RFm_SpriteGlyphLookup
		{
			get
			{
				if(r_Fm_SpriteGlyphLookup == null)
				{
					r_Fm_SpriteGlyphLookup = new(this, "m_SpriteGlyphLookup");
				}
				return r_Fm_SpriteGlyphLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset] fallbackSpriteAssets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset> r_FfallbackSpriteAssets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteAsset> RFfallbackSpriteAssets
		{
			get
			{
				if(r_FfallbackSpriteAssets == null)
				{
					r_FfallbackSpriteAssets = new(this, "fallbackSpriteAssets");
				}
				return r_FfallbackSpriteAssets;
			}
		}

		/// <summary>
		/// System.Boolean m_IsSpriteAssetLookupTablesDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsSpriteAssetLookupTablesDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsSpriteAssetLookupTablesDirty
		{
			get
			{
				if(r_Fm_IsSpriteAssetLookupTablesDirty == null)
				{
					r_Fm_IsSpriteAssetLookupTablesDirty = new(this, "m_IsSpriteAssetLookupTablesDirty");
				}
				return r_Fm_IsSpriteAssetLookupTablesDirty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_searchedSpriteAssets
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> r_Fk_searchedSpriteAssets;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RSystem.RInt32> RFk_searchedSpriteAssets
		{
			get
			{
				if(r_Fk_searchedSpriteAssets == null)
				{
					r_Fk_searchedSpriteAssets = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "k_searchedSpriteAssets");
				}
				return r_Fk_searchedSpriteAssets;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_InstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_InstanceID
		{
			get
			{
				if(r_Fm_InstanceID == null)
				{
					r_Fm_InstanceID = new(this, "m_InstanceID");
				}
				return r_Fm_InstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_HashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_HashCode
		{
			get
			{
				if(r_Fm_HashCode == null)
				{
					r_Fm_HashCode = new(this, "m_HashCode");
				}
				return r_Fm_HashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_Material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fm_Material;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFm_Material
		{
			get
			{
				if(r_Fm_Material == null)
				{
					r_Fm_Material = new(this, "m_Material");
				}
				return r_Fm_Material;
			}
		}

		/// <summary>
		/// System.Int32 m_MaterialHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaterialHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaterialHashCode
		{
			get
			{
				if(r_Fm_MaterialHashCode == null)
				{
					r_Fm_MaterialHashCode = new(this, "m_MaterialHashCode");
				}
				return r_Fm_MaterialHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo faceInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo r_PfaceInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RFaceInfo RPfaceInfo
		{
			get
			{
				if(r_PfaceInfo == null)
				{
					r_PfaceInfo = new(this, "faceInfo", -1);
				}
				return r_PfaceInfo;
			}
		}

		/// <summary>
		/// UnityEngine.Texture spriteSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_PspriteSheet;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RPspriteSheet
		{
			get
			{
				if(r_PspriteSheet == null)
				{
					r_PspriteSheet = new(this, "spriteSheet", -1);
				}
				return r_PspriteSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteCharacter] spriteCharacterTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> r_PspriteCharacterTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> RPspriteCharacterTable
		{
			get
			{
				if(r_PspriteCharacterTable == null)
				{
					r_PspriteCharacterTable = new(this, "spriteCharacterTable", -1);
				}
				return r_PspriteCharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter] spriteCharacterLookupTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> r_PspriteCharacterLookupTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RUInt32, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteCharacter> RPspriteCharacterLookupTable
		{
			get
			{
				if(r_PspriteCharacterLookupTable == null)
				{
					r_PspriteCharacterLookupTable = new(this, "spriteCharacterLookupTable", -1);
				}
				return r_PspriteCharacterLookupTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteGlyph] spriteGlyphTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteGlyph> r_PspriteGlyphTable;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RSpriteGlyph> RPspriteGlyphTable
		{
			get
			{
				if(r_PspriteGlyphTable == null)
				{
					r_PspriteGlyphTable = new(this, "spriteGlyphTable", -1);
				}
				return r_PspriteGlyphTable;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pversion;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversion
		{
			get
			{
				if(r_Pversion == null)
				{
					r_Pversion = new(this, "version", -1);
				}
				return r_Pversion;
			}
		}

		/// <summary>
		/// Int32 instanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PinstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPinstanceID
		{
			get
			{
				if(r_PinstanceID == null)
				{
					r_PinstanceID = new(this, "instanceID", -1);
				}
				return r_PinstanceID;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PhashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPhashCode
		{
			get
			{
				if(r_PhashCode == null)
				{
					r_PhashCode = new(this, "hashCode", -1);
				}
				return r_PhashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Pmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPmaterial
		{
			get
			{
				if(r_Pmaterial == null)
				{
					r_Pmaterial = new(this, "material", -1);
				}
				return r_Pmaterial;
			}
		}

		/// <summary>
		/// Int32 materialHashCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaterialHashCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmaterialHashCode
		{
			get
			{
				if(r_PmaterialHashCode == null)
				{
					r_PmaterialHashCode = new(this, "materialHashCode", -1);
				}
				return r_PmaterialHashCode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_MAwake;
		public virtual RMethod RMAwake
		{
			get
			{
				if(r_MAwake == null)
				{
					r_MAwake = new(this, "Awake", 0);
				}
				return r_MAwake;
			}
		}

		/// <summary>
		/// Void UpdateLookupTables()
		/// </summary>
		protected RMethod r_MUpdateLookupTables;
		public virtual RMethod RMUpdateLookupTables
		{
			get
			{
				if(r_MUpdateLookupTables == null)
				{
					r_MUpdateLookupTables = new(this, "UpdateLookupTables", 0);
				}
				return r_MUpdateLookupTables;
			}
		}

		/// <summary>
		/// Int32 GetSpriteIndexFromHashcode(Int32)
		/// </summary>
		protected RMethod r_MGetSpriteIndexFromHashcode_Int32;
		public virtual RMethod RMGetSpriteIndexFromHashcode_Int32
		{
			get
			{
				if(r_MGetSpriteIndexFromHashcode_Int32 == null)
				{
					r_MGetSpriteIndexFromHashcode_Int32 = new(this, "GetSpriteIndexFromHashcode", 0, typeof(System.Int32));
				}
				return r_MGetSpriteIndexFromHashcode_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSpriteIndexFromUnicode(UInt32)
		/// </summary>
		protected RMethod r_MGetSpriteIndexFromUnicode_UInt32;
		public virtual RMethod RMGetSpriteIndexFromUnicode_UInt32
		{
			get
			{
				if(r_MGetSpriteIndexFromUnicode_UInt32 == null)
				{
					r_MGetSpriteIndexFromUnicode_UInt32 = new(this, "GetSpriteIndexFromUnicode", 0, typeof(System.UInt32));
				}
				return r_MGetSpriteIndexFromUnicode_UInt32;
			}
		}

		/// <summary>
		/// Int32 GetSpriteIndexFromName(System.String)
		/// </summary>
		protected RMethod r_MGetSpriteIndexFromName_String;
		public virtual RMethod RMGetSpriteIndexFromName_String
		{
			get
			{
				if(r_MGetSpriteIndexFromName_String == null)
				{
					r_MGetSpriteIndexFromName_String = new(this, "GetSpriteIndexFromName", 0, typeof(System.String));
				}
				return r_MGetSpriteIndexFromName_String;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset, UInt32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32;
		public static RMethod RMSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32
		{
			get
			{
				if(r_MSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32 == null)
				{
					r_MSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByUnicode", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset], UInt32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32;
		public static RMethod RMSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32
		{
			get
			{
				if(r_MSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32 == null)
				{
					r_MSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByUnicodeInternal", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.TextCore.Text.SpriteAsset)), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset, UInt32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32;
		public static RMethod RMSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32
		{
			get
			{
				if(r_MSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32 == null)
				{
					r_MSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByUnicodeInternal", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset, Int32, Boolean, Int32 ByRef, UnityEngine.TextCore.Text.TextSettings)
		/// </summary>
		protected static RMethod r_MSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings;
		public static RMethod RMSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings
		{
			get
			{
				if(r_MSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings == null)
				{
					r_MSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByHashCode", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(UnityEngine.TextCore.Text.TextSettings));
				}
				return r_MSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset], Int32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32;
		public static RMethod RMSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32
		{
			get
			{
				if(r_MSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32 == null)
				{
					r_MSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByHashCodeInternal", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.TextCore.Text.SpriteAsset)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset, Int32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32;
		public static RMethod RMSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32
		{
			get
			{
				if(r_MSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32 == null)
				{
					r_MSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByHashCodeInternal", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Void SortGlyphTable()
		/// </summary>
		protected RMethod r_MSortGlyphTable;
		public virtual RMethod RMSortGlyphTable
		{
			get
			{
				if(r_MSortGlyphTable == null)
				{
					r_MSortGlyphTable = new(this, "SortGlyphTable", 0);
				}
				return r_MSortGlyphTable;
			}
		}

		/// <summary>
		/// Void SortCharacterTable()
		/// </summary>
		protected RMethod r_MSortCharacterTable;
		public virtual RMethod RMSortCharacterTable
		{
			get
			{
				if(r_MSortCharacterTable == null)
				{
					r_MSortCharacterTable = new(this, "SortCharacterTable", 0);
				}
				return r_MSortCharacterTable;
			}
		}

		/// <summary>
		/// Void SortGlyphAndCharacterTables()
		/// </summary>
		protected RMethod r_MSortGlyphAndCharacterTables;
		public virtual RMethod RMSortGlyphAndCharacterTables
		{
			get
			{
				if(r_MSortGlyphAndCharacterTables == null)
				{
					r_MSortGlyphAndCharacterTables = new(this, "SortGlyphAndCharacterTables", 0);
				}
				return r_MSortGlyphAndCharacterTables;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateLookupTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateLookupTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSpriteIndexFromHashcode(System.Int32 @hashCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashCode};
            var ___result = RMGetSpriteIndexFromHashcode_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSpriteIndexFromUnicode(System.UInt32 @unicode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode};
            var ___result = RMGetSpriteIndexFromUnicode_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSpriteIndexFromName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetSpriteIndexFromName_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset @spriteAsset, System.UInt32 @unicode, System.Boolean @includeFallbacks, out System.Int32 @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @unicode, @includeFallbacks, @spriteIndex};
            var ___result = RMSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> @spriteAssets, System.UInt32 @unicode, System.Boolean @includeFallbacks, out System.Int32 @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAssets, @unicode, @includeFallbacks, @spriteIndex};
            var ___result = RMSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset @spriteAsset, System.UInt32 @unicode, System.Boolean @includeFallbacks, out System.Int32 @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @unicode, @includeFallbacks, @spriteIndex};
            var ___result = RMSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset @spriteAsset, System.Int32 @hashCode, System.Boolean @includeFallbacks, out System.Int32 @spriteIndex, UnityEngine.TextCore.Text.TextSettings @textSettings)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @hashCode, @includeFallbacks, @spriteIndex, @textSettings};
            var ___result = RMSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> @spriteAssets, System.Int32 @hashCode, System.Boolean @searchFallbacks, out System.Int32 @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAssets, @hashCode, @searchFallbacks, @spriteIndex};
            var ___result = RMSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset @spriteAsset, System.Int32 @hashCode, System.Boolean @searchFallbacks, out System.Int32 @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @hashCode, @searchFallbacks, @spriteIndex};
            var ___result = RMSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public virtual void SortGlyphTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortGlyphTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortCharacterTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortCharacterTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortGlyphAndCharacterTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSortGlyphAndCharacterTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
