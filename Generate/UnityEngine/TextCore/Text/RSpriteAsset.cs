using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.SpriteAsset
	/// </summary>
    public partial class RSpriteAsset : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Int32] m_NameLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_m_NameLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rm_NameLookup
		{
			get
			{
				if(r_m_NameLookup == null)
				{
					r_m_NameLookup = new(this, "m_NameLookup");
					r_m_NameLookup.SetBelong(this.instance);
				}
				return r_m_NameLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,System.Int32] m_GlyphIndexLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_m_GlyphIndexLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rm_GlyphIndexLookup
		{
			get
			{
				if(r_m_GlyphIndexLookup == null)
				{
					r_m_GlyphIndexLookup = new(this, "m_GlyphIndexLookup");
					r_m_GlyphIndexLookup.SetBelong(this.instance);
				}
				return r_m_GlyphIndexLookup;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo m_FaceInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RFaceInfo r_m_FaceInfo;
		public virtual RUnityEngine.RTextCore.RFaceInfo Rm_FaceInfo
		{
			get
			{
				if(r_m_FaceInfo == null)
				{
					r_m_FaceInfo = new(this, "m_FaceInfo");
					r_m_FaceInfo.SetBelong(this.instance);
				}
				return r_m_FaceInfo;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_SpriteAtlasTexture
		/// </summary>
		protected RUnityEngine.RTexture r_m_SpriteAtlasTexture;
		public virtual RUnityEngine.RTexture Rm_SpriteAtlasTexture
		{
			get
			{
				if(r_m_SpriteAtlasTexture == null)
				{
					r_m_SpriteAtlasTexture = new(this, "m_SpriteAtlasTexture");
					r_m_SpriteAtlasTexture.SetBelong(this.instance);
				}
				return r_m_SpriteAtlasTexture;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteCharacter] m_SpriteCharacterTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteCharacter> r_m_SpriteCharacterTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteCharacter> Rm_SpriteCharacterTable
		{
			get
			{
				if(r_m_SpriteCharacterTable == null)
				{
					r_m_SpriteCharacterTable = new(this, "m_SpriteCharacterTable");
					r_m_SpriteCharacterTable.SetBelong(this.instance);
				}
				return r_m_SpriteCharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter] m_SpriteCharacterLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RSpriteCharacter> r_m_SpriteCharacterLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RSpriteCharacter> Rm_SpriteCharacterLookup
		{
			get
			{
				if(r_m_SpriteCharacterLookup == null)
				{
					r_m_SpriteCharacterLookup = new(this, "m_SpriteCharacterLookup");
					r_m_SpriteCharacterLookup.SetBelong(this.instance);
				}
				return r_m_SpriteCharacterLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteGlyph] m_SpriteGlyphTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteGlyph> r_m_SpriteGlyphTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteGlyph> Rm_SpriteGlyphTable
		{
			get
			{
				if(r_m_SpriteGlyphTable == null)
				{
					r_m_SpriteGlyphTable = new(this, "m_SpriteGlyphTable");
					r_m_SpriteGlyphTable.SetBelong(this.instance);
				}
				return r_m_SpriteGlyphTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.SpriteGlyph] m_SpriteGlyphLookup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RSpriteGlyph> r_m_SpriteGlyphLookup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTextCore.RText.RSpriteGlyph> Rm_SpriteGlyphLookup
		{
			get
			{
				if(r_m_SpriteGlyphLookup == null)
				{
					r_m_SpriteGlyphLookup = new(this, "m_SpriteGlyphLookup");
					r_m_SpriteGlyphLookup.SetBelong(this.instance);
				}
				return r_m_SpriteGlyphLookup;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset] fallbackSpriteAssets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteAsset> r_fallbackSpriteAssets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteAsset> RfallbackSpriteAssets
		{
			get
			{
				if(r_fallbackSpriteAssets == null)
				{
					r_fallbackSpriteAssets = new(this, "fallbackSpriteAssets");
					r_fallbackSpriteAssets.SetBelong(this.instance);
				}
				return r_fallbackSpriteAssets;
			}
		}

		/// <summary>
		/// System.Boolean m_IsSpriteAssetLookupTablesDirty
		/// </summary>
		protected RField r_m_IsSpriteAssetLookupTablesDirty;
		public virtual RField Rm_IsSpriteAssetLookupTablesDirty
		{
			get
			{
				if(r_m_IsSpriteAssetLookupTablesDirty == null)
				{
					r_m_IsSpriteAssetLookupTablesDirty = new(this, "m_IsSpriteAssetLookupTablesDirty");
					r_m_IsSpriteAssetLookupTablesDirty.SetBelong(this.instance);
				}
				return r_m_IsSpriteAssetLookupTablesDirty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[System.Int32] k_searchedSpriteAssets
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RHashSet<RField> r_k_searchedSpriteAssets;
		public static RSystem.RCollections.RGeneric.RHashSet<RField> Rk_searchedSpriteAssets
		{
			get
			{
				if(r_k_searchedSpriteAssets == null)
				{
					r_k_searchedSpriteAssets = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "k_searchedSpriteAssets");
					r_k_searchedSpriteAssets.SetBelong(null);
				}
				return r_k_searchedSpriteAssets;
			}
		}

		/// <summary>
		/// System.String m_Version
		/// </summary>
		protected RField r_m_Version;
		public virtual RField Rm_Version
		{
			get
			{
				if(r_m_Version == null)
				{
					r_m_Version = new(this, "m_Version");
					r_m_Version.SetBelong(this.instance);
				}
				return r_m_Version;
			}
		}

		/// <summary>
		/// System.Int32 m_InstanceID
		/// </summary>
		protected RField r_m_InstanceID;
		public virtual RField Rm_InstanceID
		{
			get
			{
				if(r_m_InstanceID == null)
				{
					r_m_InstanceID = new(this, "m_InstanceID");
					r_m_InstanceID.SetBelong(this.instance);
				}
				return r_m_InstanceID;
			}
		}

		/// <summary>
		/// System.Int32 m_HashCode
		/// </summary>
		protected RField r_m_HashCode;
		public virtual RField Rm_HashCode
		{
			get
			{
				if(r_m_HashCode == null)
				{
					r_m_HashCode = new(this, "m_HashCode");
					r_m_HashCode.SetBelong(this.instance);
				}
				return r_m_HashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_Material
		/// </summary>
		protected RUnityEngine.RMaterial r_m_Material;
		public virtual RUnityEngine.RMaterial Rm_Material
		{
			get
			{
				if(r_m_Material == null)
				{
					r_m_Material = new(this, "m_Material");
					r_m_Material.SetBelong(this.instance);
				}
				return r_m_Material;
			}
		}

		/// <summary>
		/// System.Int32 m_MaterialHashCode
		/// </summary>
		protected RField r_m_MaterialHashCode;
		public virtual RField Rm_MaterialHashCode
		{
			get
			{
				if(r_m_MaterialHashCode == null)
				{
					r_m_MaterialHashCode = new(this, "m_MaterialHashCode");
					r_m_MaterialHashCode.SetBelong(this.instance);
				}
				return r_m_MaterialHashCode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.FaceInfo faceInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RFaceInfo r_faceInfo;
		public virtual RUnityEngine.RTextCore.RFaceInfo RfaceInfo
		{
			get
			{
				if(r_faceInfo == null)
				{
					r_faceInfo = new(this, "faceInfo", -1);
					r_faceInfo.SetBelong(this.instance);
				}
				return r_faceInfo;
			}
		}

		/// <summary>
		/// UnityEngine.Texture spriteSheet
		/// </summary>
		protected RUnityEngine.RTexture r_spriteSheet;
		public virtual RUnityEngine.RTexture RspriteSheet
		{
			get
			{
				if(r_spriteSheet == null)
				{
					r_spriteSheet = new(this, "spriteSheet", -1);
					r_spriteSheet.SetBelong(this.instance);
				}
				return r_spriteSheet;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteCharacter] spriteCharacterTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteCharacter> r_spriteCharacterTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteCharacter> RspriteCharacterTable
		{
			get
			{
				if(r_spriteCharacterTable == null)
				{
					r_spriteCharacterTable = new(this, "spriteCharacterTable", -1);
					r_spriteCharacterTable.SetBelong(this.instance);
				}
				return r_spriteCharacterTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter] spriteCharacterLookupTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RTextCore.RText.RSpriteCharacter> r_spriteCharacterLookupTable;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RUnityEngine.RTextCore.RText.RSpriteCharacter> RspriteCharacterLookupTable
		{
			get
			{
				if(r_spriteCharacterLookupTable == null)
				{
					r_spriteCharacterLookupTable = new(this, "spriteCharacterLookupTable", -1);
					r_spriteCharacterLookupTable.SetBelong(this.instance);
				}
				return r_spriteCharacterLookupTable;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteGlyph] spriteGlyphTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteGlyph> r_spriteGlyphTable;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTextCore.RText.RSpriteGlyph> RspriteGlyphTable
		{
			get
			{
				if(r_spriteGlyphTable == null)
				{
					r_spriteGlyphTable = new(this, "spriteGlyphTable", -1);
					r_spriteGlyphTable.SetBelong(this.instance);
				}
				return r_spriteGlyphTable;
			}
		}

		/// <summary>
		/// System.String version
		/// </summary>
		protected RProperty r_version;
		public virtual RProperty Rversion
		{
			get
			{
				if(r_version == null)
				{
					r_version = new(this, "version", -1);
					r_version.SetBelong(this.instance);
				}
				return r_version;
			}
		}

		/// <summary>
		/// Int32 instanceID
		/// </summary>
		protected RProperty r_instanceID;
		public virtual RProperty RinstanceID
		{
			get
			{
				if(r_instanceID == null)
				{
					r_instanceID = new(this, "instanceID", -1);
					r_instanceID.SetBelong(this.instance);
				}
				return r_instanceID;
			}
		}

		/// <summary>
		/// Int32 hashCode
		/// </summary>
		protected RProperty r_hashCode;
		public virtual RProperty RhashCode
		{
			get
			{
				if(r_hashCode == null)
				{
					r_hashCode = new(this, "hashCode", -1);
					r_hashCode.SetBelong(this.instance);
				}
				return r_hashCode;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material", -1);
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// Int32 materialHashCode
		/// </summary>
		protected RProperty r_materialHashCode;
		public virtual RProperty RmaterialHashCode
		{
			get
			{
				if(r_materialHashCode == null)
				{
					r_materialHashCode = new(this, "materialHashCode", -1);
					r_materialHashCode.SetBelong(this.instance);
				}
				return r_materialHashCode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_Awake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_Awake == null)
				{
					r_Awake = new(this, "Awake", 0);
					r_Awake.SetBelong(this.instance);
				}
				return r_Awake;
			}
		}

		/// <summary>
		/// Void UpdateLookupTables()
		/// </summary>
		protected RMethod r_UpdateLookupTables;
		public virtual RMethod RUpdateLookupTables
		{
			get
			{
				if(r_UpdateLookupTables == null)
				{
					r_UpdateLookupTables = new(this, "UpdateLookupTables", 0);
					r_UpdateLookupTables.SetBelong(this.instance);
				}
				return r_UpdateLookupTables;
			}
		}

		/// <summary>
		/// Int32 GetSpriteIndexFromHashcode(Int32)
		/// </summary>
		protected RMethod r_GetSpriteIndexFromHashcode_Int32;
		public virtual RMethod RGetSpriteIndexFromHashcode_Int32
		{
			get
			{
				if(r_GetSpriteIndexFromHashcode_Int32 == null)
				{
					r_GetSpriteIndexFromHashcode_Int32 = new(this, "GetSpriteIndexFromHashcode", 0, typeof(System.Int32));
					r_GetSpriteIndexFromHashcode_Int32.SetBelong(this.instance);
				}
				return r_GetSpriteIndexFromHashcode_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSpriteIndexFromUnicode(UInt32)
		/// </summary>
		protected RMethod r_GetSpriteIndexFromUnicode_UInt32;
		public virtual RMethod RGetSpriteIndexFromUnicode_UInt32
		{
			get
			{
				if(r_GetSpriteIndexFromUnicode_UInt32 == null)
				{
					r_GetSpriteIndexFromUnicode_UInt32 = new(this, "GetSpriteIndexFromUnicode", 0, typeof(System.UInt32));
					r_GetSpriteIndexFromUnicode_UInt32.SetBelong(this.instance);
				}
				return r_GetSpriteIndexFromUnicode_UInt32;
			}
		}

		/// <summary>
		/// Int32 GetSpriteIndexFromName(System.String)
		/// </summary>
		protected RMethod r_GetSpriteIndexFromName_String;
		public virtual RMethod RGetSpriteIndexFromName_String
		{
			get
			{
				if(r_GetSpriteIndexFromName_String == null)
				{
					r_GetSpriteIndexFromName_String = new(this, "GetSpriteIndexFromName", 0, typeof(System.String));
					r_GetSpriteIndexFromName_String.SetBelong(this.instance);
				}
				return r_GetSpriteIndexFromName_String;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset, UInt32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_SearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32;
		public static RMethod RSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32
		{
			get
			{
				if(r_SearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32 == null)
				{
					r_SearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByUnicode", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_SearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32.SetBelong(null);
				}
				return r_SearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset], UInt32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_SearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32;
		public static RMethod RSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32
		{
			get
			{
				if(r_SearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32 == null)
				{
					r_SearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByUnicodeInternal", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.TextCore.Text.SpriteAsset)), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_SearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32.SetBelong(null);
				}
				return r_SearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset, UInt32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_SearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32;
		public static RMethod RSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32
		{
			get
			{
				if(r_SearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32 == null)
				{
					r_SearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByUnicodeInternal", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.UInt32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_SearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32.SetBelong(null);
				}
				return r_SearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset, Int32, Boolean, Int32 ByRef, UnityEngine.TextCore.Text.TextSettings)
		/// </summary>
		protected static RMethod r_SearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings;
		public static RMethod RSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings
		{
			get
			{
				if(r_SearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings == null)
				{
					r_SearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByHashCode", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType(), typeof(UnityEngine.TextCore.Text.TextSettings));
					r_SearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings.SetBelong(null);
				}
				return r_SearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List`1[UnityEngine.TextCore.Text.SpriteAsset], Int32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_SearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32;
		public static RMethod RSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32
		{
			get
			{
				if(r_SearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32 == null)
				{
					r_SearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByHashCodeInternal", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.TextCore.Text.SpriteAsset)), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_SearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32.SetBelong(null);
				}
				return r_SearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset, Int32, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_SearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32;
		public static RMethod RSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32
		{
			get
			{
				if(r_SearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32 == null)
				{
					r_SearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32 = new(typeof(UnityEngine.TextCore.Text.SpriteAsset), "SearchForSpriteByHashCodeInternal", 0, typeof(UnityEngine.TextCore.Text.SpriteAsset), typeof(System.Int32), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_SearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32.SetBelong(null);
				}
				return r_SearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Void SortGlyphTable()
		/// </summary>
		protected RMethod r_SortGlyphTable;
		public virtual RMethod RSortGlyphTable
		{
			get
			{
				if(r_SortGlyphTable == null)
				{
					r_SortGlyphTable = new(this, "SortGlyphTable", 0);
					r_SortGlyphTable.SetBelong(this.instance);
				}
				return r_SortGlyphTable;
			}
		}

		/// <summary>
		/// Void SortCharacterTable()
		/// </summary>
		protected RMethod r_SortCharacterTable;
		public virtual RMethod RSortCharacterTable
		{
			get
			{
				if(r_SortCharacterTable == null)
				{
					r_SortCharacterTable = new(this, "SortCharacterTable", 0);
					r_SortCharacterTable.SetBelong(this.instance);
				}
				return r_SortCharacterTable;
			}
		}

		/// <summary>
		/// Void SortGlyphAndCharacterTables()
		/// </summary>
		protected RMethod r_SortGlyphAndCharacterTables;
		public virtual RMethod RSortGlyphAndCharacterTables
		{
			get
			{
				if(r_SortGlyphAndCharacterTables == null)
				{
					r_SortGlyphAndCharacterTables = new(this, "SortGlyphAndCharacterTables", 0);
					r_SortGlyphAndCharacterTables.SetBelong(this.instance);
				}
				return r_SortGlyphAndCharacterTables;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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

        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateLookupTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateLookupTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSpriteIndexFromHashcode(System.Int32  @hashCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashCode};
            var ___result = RGetSpriteIndexFromHashcode_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSpriteIndexFromUnicode(System.UInt32  @unicode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unicode};
            var ___result = RGetSpriteIndexFromUnicode_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSpriteIndexFromName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetSpriteIndexFromName_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset  @spriteAsset, System.UInt32  @unicode, System.Boolean  @includeFallbacks, out System.Int32  @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @unicode, @includeFallbacks, @spriteIndex};
            var ___result = RSearchForSpriteByUnicode_SpriteAsset_UInt32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset>  @spriteAssets, System.UInt32  @unicode, System.Boolean  @includeFallbacks, out System.Int32  @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAssets, @unicode, @includeFallbacks, @spriteIndex};
            var ___result = RSearchForSpriteByUnicodeInternal_List_d_SpriteAsset_p__UInt32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset  @spriteAsset, System.UInt32  @unicode, System.Boolean  @includeFallbacks, out System.Int32  @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @unicode, @includeFallbacks, @spriteIndex};
            var ___result = RSearchForSpriteByUnicodeInternal_SpriteAsset_UInt32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset  @spriteAsset, System.Int32  @hashCode, System.Boolean  @includeFallbacks, out System.Int32  @spriteIndex, UnityEngine.TextCore.Text.TextSettings  @textSettings)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @hashCode, @includeFallbacks, @spriteIndex, @textSettings};
            var ___result = RSearchForSpriteByHashCode_SpriteAsset_Int32_Boolean_Out_Int32_TextSettings.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset>  @spriteAssets, System.Int32  @hashCode, System.Boolean  @searchFallbacks, out System.Int32  @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAssets, @hashCode, @searchFallbacks, @spriteIndex};
            var ___result = RSearchForSpriteByHashCodeInternal_List_d_SpriteAsset_p__Int32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public static UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset  @spriteAsset, System.Int32  @hashCode, System.Boolean  @searchFallbacks, out System.Int32  @spriteIndex)
        {
			@spriteIndex = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spriteAsset, @hashCode, @searchFallbacks, @spriteIndex};
            var ___result = RSearchForSpriteByHashCodeInternal_SpriteAsset_Int32_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@spriteIndex = (System.Int32)___parameters[3];

            return (UnityEngine.TextCore.Text.SpriteAsset)___result;
        }


        public virtual void SortGlyphTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortGlyphTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortCharacterTable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortCharacterTable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SortGlyphAndCharacterTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSortGlyphAndCharacterTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
