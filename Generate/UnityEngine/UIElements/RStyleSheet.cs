using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheet
	/// </summary>
    public partial class RStyleSheet : RMember //
    {

		/// <summary>
		/// System.Boolean m_ImportedWithErrors
		/// </summary>
		protected RSystem.RBoolean r_m_ImportedWithErrors;
		public virtual RSystem.RBoolean Rm_ImportedWithErrors
		{
			get
			{
				if(r_m_ImportedWithErrors == null)
				{
					r_m_ImportedWithErrors = new(this, "m_ImportedWithErrors");
					r_m_ImportedWithErrors.SetBelong(this.instance);
				}
				return r_m_ImportedWithErrors;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithWarnings
		/// </summary>
		protected RSystem.RBoolean r_m_ImportedWithWarnings;
		public virtual RSystem.RBoolean Rm_ImportedWithWarnings
		{
			get
			{
				if(r_m_ImportedWithWarnings == null)
				{
					r_m_ImportedWithWarnings = new(this, "m_ImportedWithWarnings");
					r_m_ImportedWithWarnings.SetBelong(this.instance);
				}
				return r_m_ImportedWithWarnings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule[] m_Rules
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleRule> r_m_Rules;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleRule> Rm_Rules
		{
			get
			{
				if(r_m_Rules == null)
				{
					r_m_Rules = new(this, "m_Rules");
					r_m_Rules.SetBelong(this.instance);
				}
				return r_m_Rules;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleComplexSelector> r_m_ComplexSelectors;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleComplexSelector> Rm_ComplexSelectors
		{
			get
			{
				if(r_m_ComplexSelectors == null)
				{
					r_m_ComplexSelectors = new(this, "m_ComplexSelectors");
					r_m_ComplexSelectors.SetBelong(this.instance);
				}
				return r_m_ComplexSelectors;
			}
		}

		/// <summary>
		/// System.Single[] floats
		/// </summary>
		protected RFieldArray<RSystem.RSingle> r_floats;
		public virtual RFieldArray<RSystem.RSingle> Rfloats
		{
			get
			{
				if(r_floats == null)
				{
					r_floats = new(this, "floats");
					r_floats.SetBelong(this.instance);
				}
				return r_floats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension[] dimensions
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RDimension> r_dimensions;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RDimension> Rdimensions
		{
			get
			{
				if(r_dimensions == null)
				{
					r_dimensions = new(this, "dimensions");
					r_dimensions.SetBelong(this.instance);
				}
				return r_dimensions;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] colors
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor> r_colors;
		public virtual RFieldArray<RUnityEngine.RColor> Rcolors
		{
			get
			{
				if(r_colors == null)
				{
					r_colors = new(this, "colors");
					r_colors.SetBelong(this.instance);
				}
				return r_colors;
			}
		}

		/// <summary>
		/// System.String[] strings
		/// </summary>
		protected RFieldArray<RSystem.RString> r_strings;
		public virtual RFieldArray<RSystem.RString> Rstrings
		{
			get
			{
				if(r_strings == null)
				{
					r_strings = new(this, "strings");
					r_strings.SetBelong(this.instance);
				}
				return r_strings;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] assets
		/// </summary>
		protected RFieldArray<RUnityEngine.RObject> r_assets;
		public virtual RFieldArray<RUnityEngine.RObject> Rassets
		{
			get
			{
				if(r_assets == null)
				{
					r_assets = new(this, "assets");
					r_assets.SetBelong(this.instance);
				}
				return r_assets;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet+ImportStruct[] imports
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheet.RImportStruct> r_imports;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheet.RImportStruct> Rimports
		{
			get
			{
				if(r_imports == null)
				{
					r_imports = new(this, "imports");
					r_imports.SetBelong(this.instance);
				}
				return r_imports;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] m_FlattenedImportedStyleSheets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_m_FlattenedImportedStyleSheets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> Rm_FlattenedImportedStyleSheets
		{
			get
			{
				if(r_m_FlattenedImportedStyleSheets == null)
				{
					r_m_FlattenedImportedStyleSheets = new(this, "m_FlattenedImportedStyleSheets");
					r_m_FlattenedImportedStyleSheets.SetBelong(this.instance);
				}
				return r_m_FlattenedImportedStyleSheets;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentHash
		/// </summary>
		protected RSystem.RInt32 r_m_ContentHash;
		public virtual RSystem.RInt32 Rm_ContentHash
		{
			get
			{
				if(r_m_ContentHash == null)
				{
					r_m_ContentHash = new(this, "m_ContentHash");
					r_m_ContentHash.SetBelong(this.instance);
				}
				return r_m_ContentHash;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RScalableImage> r_scalableImages;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RScalableImage> RscalableImages
		{
			get
			{
				if(r_scalableImages == null)
				{
					r_scalableImages = new(this, "scalableImages");
					r_scalableImages.SetBelong(this.instance);
				}
				return r_scalableImages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedNameSelectors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> r_orderedNameSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> RorderedNameSelectors
		{
			get
			{
				if(r_orderedNameSelectors == null)
				{
					r_orderedNameSelectors = new(this, "orderedNameSelectors");
					r_orderedNameSelectors.SetBelong(this.instance);
				}
				return r_orderedNameSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedTypeSelectors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> r_orderedTypeSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> RorderedTypeSelectors
		{
			get
			{
				if(r_orderedTypeSelectors == null)
				{
					r_orderedTypeSelectors = new(this, "orderedTypeSelectors");
					r_orderedTypeSelectors.SetBelong(this.instance);
				}
				return r_orderedTypeSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedClassSelectors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> r_orderedClassSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> RorderedClassSelectors
		{
			get
			{
				if(r_orderedClassSelectors == null)
				{
					r_orderedClassSelectors = new(this, "orderedClassSelectors");
					r_orderedClassSelectors.SetBelong(this.instance);
				}
				return r_orderedClassSelectors;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDefaultStyleSheet
		/// </summary>
		protected RSystem.RBoolean r_m_IsDefaultStyleSheet;
		public virtual RSystem.RBoolean Rm_IsDefaultStyleSheet
		{
			get
			{
				if(r_m_IsDefaultStyleSheet == null)
				{
					r_m_IsDefaultStyleSheet = new(this, "m_IsDefaultStyleSheet");
					r_m_IsDefaultStyleSheet.SetBelong(this.instance);
				}
				return r_m_IsDefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String kCustomPropertyMarker
		/// </summary>
		protected static RSystem.RString r_kCustomPropertyMarker;
		public static RSystem.RString RkCustomPropertyMarker
		{
			get
			{
				if(r_kCustomPropertyMarker == null)
				{
					r_kCustomPropertyMarker = new(typeof(UnityEngine.UIElements.StyleSheet), "kCustomPropertyMarker");
					r_kCustomPropertyMarker.SetBelong(null);
				}
				return r_kCustomPropertyMarker;
			}
		}

		/// <summary>
		/// Boolean importedWithErrors
		/// </summary>
		protected RSystem.RBoolean r_importedWithErrors;
		public virtual RSystem.RBoolean RimportedWithErrors
		{
			get
			{
				if(r_importedWithErrors == null)
				{
					r_importedWithErrors = new(this, "importedWithErrors", -1);
					r_importedWithErrors.SetBelong(this.instance);
				}
				return r_importedWithErrors;
			}
		}

		/// <summary>
		/// Boolean importedWithWarnings
		/// </summary>
		protected RSystem.RBoolean r_importedWithWarnings;
		public virtual RSystem.RBoolean RimportedWithWarnings
		{
			get
			{
				if(r_importedWithWarnings == null)
				{
					r_importedWithWarnings = new(this, "importedWithWarnings", -1);
					r_importedWithWarnings.SetBelong(this.instance);
				}
				return r_importedWithWarnings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule[] rules
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleRule> r_rules;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleRule> Rrules
		{
			get
			{
				if(r_rules == null)
				{
					r_rules = new(this, "rules", -1);
					r_rules.SetBelong(this.instance);
				}
				return r_rules;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector[] complexSelectors
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleComplexSelector> r_complexSelectors;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleComplexSelector> RcomplexSelectors
		{
			get
			{
				if(r_complexSelectors == null)
				{
					r_complexSelectors = new(this, "complexSelectors", -1);
					r_complexSelectors.SetBelong(this.instance);
				}
				return r_complexSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] flattenedRecursiveImports
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_flattenedRecursiveImports;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RflattenedRecursiveImports
		{
			get
			{
				if(r_flattenedRecursiveImports == null)
				{
					r_flattenedRecursiveImports = new(this, "flattenedRecursiveImports", -1);
					r_flattenedRecursiveImports.SetBelong(this.instance);
				}
				return r_flattenedRecursiveImports;
			}
		}

		/// <summary>
		/// Int32 contentHash
		/// </summary>
		protected RSystem.RInt32 r_contentHash;
		public virtual RSystem.RInt32 RcontentHash
		{
			get
			{
				if(r_contentHash == null)
				{
					r_contentHash = new(this, "contentHash", -1);
					r_contentHash.SetBelong(this.instance);
				}
				return r_contentHash;
			}
		}

		/// <summary>
		/// Boolean isDefaultStyleSheet
		/// </summary>
		protected RSystem.RBoolean r_isDefaultStyleSheet;
		public virtual RSystem.RBoolean RisDefaultStyleSheet
		{
			get
			{
				if(r_isDefaultStyleSheet == null)
				{
					r_isDefaultStyleSheet = new(this, "isDefaultStyleSheet", -1);
					r_isDefaultStyleSheet.SetBelong(this.instance);
				}
				return r_isDefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
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
		/// Boolean TryCheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle, T ByRef)
		/// </summary>
		protected static RMethod r_TryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
		public static RMethod RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T
		{
			get
			{
				if(r_TryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T == null)
				{
					r_TryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T = new(typeof(UnityEngine.UIElements.StyleSheet), "TryCheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_TryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T.SetBelong(null);
				}
				return r_TryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
			}
		}

		/// <summary>
		/// T CheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected static RMethod r_CheckAccess_GT_TArray_StyleValueType_StyleValueHandle;
		public static RMethod RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle
		{
			get
			{
				if(r_CheckAccess_GT_TArray_StyleValueType_StyleValueHandle == null)
				{
					r_CheckAccess_GT_TArray_StyleValueType_StyleValueHandle = new(typeof(UnityEngine.UIElements.StyleSheet), "CheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_CheckAccess_GT_TArray_StyleValueType_StyleValueHandle.SetBelong(null);
				}
				return r_CheckAccess_GT_TArray_StyleValueType_StyleValueHandle;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_OnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_OnEnable == null)
				{
					r_OnEnable = new(this, "OnEnable", 0);
					r_OnEnable.SetBelong(this.instance);
				}
				return r_OnEnable;
			}
		}

		/// <summary>
		/// Void FlattenImportedStyleSheetsRecursive()
		/// </summary>
		protected RMethod r_FlattenImportedStyleSheetsRecursive;
		public virtual RMethod RFlattenImportedStyleSheetsRecursive
		{
			get
			{
				if(r_FlattenImportedStyleSheetsRecursive == null)
				{
					r_FlattenImportedStyleSheetsRecursive = new(this, "FlattenImportedStyleSheetsRecursive", 0);
					r_FlattenImportedStyleSheetsRecursive.SetBelong(this.instance);
				}
				return r_FlattenImportedStyleSheetsRecursive;
			}
		}

		/// <summary>
		/// Void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_FlattenImportedStyleSheetsRecursive_StyleSheet;
		public virtual RMethod RFlattenImportedStyleSheetsRecursive_StyleSheet
		{
			get
			{
				if(r_FlattenImportedStyleSheetsRecursive_StyleSheet == null)
				{
					r_FlattenImportedStyleSheetsRecursive_StyleSheet = new(this, "FlattenImportedStyleSheetsRecursive", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_FlattenImportedStyleSheetsRecursive_StyleSheet.SetBelong(this.instance);
				}
				return r_FlattenImportedStyleSheetsRecursive_StyleSheet;
			}
		}

		/// <summary>
		/// Void SetupReferences()
		/// </summary>
		protected RMethod r_SetupReferences;
		public virtual RMethod RSetupReferences
		{
			get
			{
				if(r_SetupReferences == null)
				{
					r_SetupReferences = new(this, "SetupReferences", 0);
					r_SetupReferences.SetBelong(this.instance);
				}
				return r_SetupReferences;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadKeyword_StyleValueHandle;
		public virtual RMethod RReadKeyword_StyleValueHandle
		{
			get
			{
				if(r_ReadKeyword_StyleValueHandle == null)
				{
					r_ReadKeyword_StyleValueHandle = new(this, "ReadKeyword", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadKeyword_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadKeyword_StyleValueHandle;
			}
		}

		/// <summary>
		/// Single ReadFloat(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadFloat_StyleValueHandle;
		public virtual RMethod RReadFloat_StyleValueHandle
		{
			get
			{
				if(r_ReadFloat_StyleValueHandle == null)
				{
					r_ReadFloat_StyleValueHandle = new(this, "ReadFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadFloat_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadFloat_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadFloat(UnityEngine.UIElements.StyleValueHandle, Single ByRef)
		/// </summary>
		protected RMethod r_TryReadFloat_StyleValueHandle_Out_Single;
		public virtual RMethod RTryReadFloat_StyleValueHandle_Out_Single
		{
			get
			{
				if(r_TryReadFloat_StyleValueHandle_Out_Single == null)
				{
					r_TryReadFloat_StyleValueHandle_Out_Single = new(this, "TryReadFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.Single).MakeByRefType());
					r_TryReadFloat_StyleValueHandle_Out_Single.SetBelong(this.instance);
				}
				return r_TryReadFloat_StyleValueHandle_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadDimension_StyleValueHandle;
		public virtual RMethod RReadDimension_StyleValueHandle
		{
			get
			{
				if(r_ReadDimension_StyleValueHandle == null)
				{
					r_ReadDimension_StyleValueHandle = new(this, "ReadDimension", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadDimension_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadDimension_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadDimension(UnityEngine.UIElements.StyleValueHandle, UnityEngine.UIElements.StyleSheets.Dimension ByRef)
		/// </summary>
		protected RMethod r_TryReadDimension_StyleValueHandle_Out_Dimension;
		public virtual RMethod RTryReadDimension_StyleValueHandle_Out_Dimension
		{
			get
			{
				if(r_TryReadDimension_StyleValueHandle_Out_Dimension == null)
				{
					r_TryReadDimension_StyleValueHandle_Out_Dimension = new(this, "TryReadDimension", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension").MakeByRefType());
					r_TryReadDimension_StyleValueHandle_Out_Dimension.SetBelong(this.instance);
				}
				return r_TryReadDimension_StyleValueHandle_Out_Dimension;
			}
		}

		/// <summary>
		/// UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadColor_StyleValueHandle;
		public virtual RMethod RReadColor_StyleValueHandle
		{
			get
			{
				if(r_ReadColor_StyleValueHandle == null)
				{
					r_ReadColor_StyleValueHandle = new(this, "ReadColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadColor_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadColor_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadColor(UnityEngine.UIElements.StyleValueHandle, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_TryReadColor_StyleValueHandle_Out_Color;
		public virtual RMethod RTryReadColor_StyleValueHandle_Out_Color
		{
			get
			{
				if(r_TryReadColor_StyleValueHandle_Out_Color == null)
				{
					r_TryReadColor_StyleValueHandle_Out_Color = new(this, "TryReadColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(UnityEngine.Color).MakeByRefType());
					r_TryReadColor_StyleValueHandle_Out_Color.SetBelong(this.instance);
				}
				return r_TryReadColor_StyleValueHandle_Out_Color;
			}
		}

		/// <summary>
		/// System.String ReadString(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadString_StyleValueHandle;
		public virtual RMethod RReadString_StyleValueHandle
		{
			get
			{
				if(r_ReadString_StyleValueHandle == null)
				{
					r_ReadString_StyleValueHandle = new(this, "ReadString", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadString_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadString_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadString(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_TryReadString_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadString_StyleValueHandle_Out_String
		{
			get
			{
				if(r_TryReadString_StyleValueHandle_Out_String == null)
				{
					r_TryReadString_StyleValueHandle_Out_String = new(this, "TryReadString", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_TryReadString_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_TryReadString_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadEnum(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadEnum_StyleValueHandle;
		public virtual RMethod RReadEnum_StyleValueHandle
		{
			get
			{
				if(r_ReadEnum_StyleValueHandle == null)
				{
					r_ReadEnum_StyleValueHandle = new(this, "ReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadEnum_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadEnum_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadEnum(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_TryReadEnum_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadEnum_StyleValueHandle_Out_String
		{
			get
			{
				if(r_TryReadEnum_StyleValueHandle_Out_String == null)
				{
					r_TryReadEnum_StyleValueHandle_Out_String = new(this, "TryReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_TryReadEnum_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_TryReadEnum_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadVariable(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadVariable_StyleValueHandle;
		public virtual RMethod RReadVariable_StyleValueHandle
		{
			get
			{
				if(r_ReadVariable_StyleValueHandle == null)
				{
					r_ReadVariable_StyleValueHandle = new(this, "ReadVariable", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadVariable_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadVariable_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadVariable(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_TryReadVariable_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadVariable_StyleValueHandle_Out_String
		{
			get
			{
				if(r_TryReadVariable_StyleValueHandle_Out_String == null)
				{
					r_TryReadVariable_StyleValueHandle_Out_String = new(this, "TryReadVariable", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_TryReadVariable_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_TryReadVariable_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadResourcePath(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadResourcePath_StyleValueHandle;
		public virtual RMethod RReadResourcePath_StyleValueHandle
		{
			get
			{
				if(r_ReadResourcePath_StyleValueHandle == null)
				{
					r_ReadResourcePath_StyleValueHandle = new(this, "ReadResourcePath", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadResourcePath_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadResourcePath_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_TryReadResourcePath_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadResourcePath_StyleValueHandle_Out_String
		{
			get
			{
				if(r_TryReadResourcePath_StyleValueHandle_Out_String == null)
				{
					r_TryReadResourcePath_StyleValueHandle_Out_String = new(this, "TryReadResourcePath", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_TryReadResourcePath_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_TryReadResourcePath_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadAssetReference_StyleValueHandle;
		public virtual RMethod RReadAssetReference_StyleValueHandle
		{
			get
			{
				if(r_ReadAssetReference_StyleValueHandle == null)
				{
					r_ReadAssetReference_StyleValueHandle = new(this, "ReadAssetReference", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadAssetReference_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadAssetReference_StyleValueHandle;
			}
		}

		/// <summary>
		/// System.String ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadMissingAssetReferenceUrl_StyleValueHandle;
		public virtual RMethod RReadMissingAssetReferenceUrl_StyleValueHandle
		{
			get
			{
				if(r_ReadMissingAssetReferenceUrl_StyleValueHandle == null)
				{
					r_ReadMissingAssetReferenceUrl_StyleValueHandle = new(this, "ReadMissingAssetReferenceUrl", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadMissingAssetReferenceUrl_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadMissingAssetReferenceUrl_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle, UnityEngine.Object ByRef)
		/// </summary>
		protected RMethod r_TryReadAssetReference_StyleValueHandle_Out_Object;
		public virtual RMethod RTryReadAssetReference_StyleValueHandle_Out_Object
		{
			get
			{
				if(r_TryReadAssetReference_StyleValueHandle_Out_Object == null)
				{
					r_TryReadAssetReference_StyleValueHandle_Out_Object = new(this, "TryReadAssetReference", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(UnityEngine.Object).MakeByRefType());
					r_TryReadAssetReference_StyleValueHandle_Out_Object.SetBelong(this.instance);
				}
				return r_TryReadAssetReference_StyleValueHandle_Out_Object;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadFunction_StyleValueHandle;
		public virtual RMethod RReadFunction_StyleValueHandle
		{
			get
			{
				if(r_ReadFunction_StyleValueHandle == null)
				{
					r_ReadFunction_StyleValueHandle = new(this, "ReadFunction", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadFunction_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadFunction_StyleValueHandle;
			}
		}

		/// <summary>
		/// System.String ReadFunctionName(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadFunctionName_StyleValueHandle;
		public virtual RMethod RReadFunctionName_StyleValueHandle
		{
			get
			{
				if(r_ReadFunctionName_StyleValueHandle == null)
				{
					r_ReadFunctionName_StyleValueHandle = new(this, "ReadFunctionName", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadFunctionName_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadFunctionName_StyleValueHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_ReadScalableImage_StyleValueHandle;
		public virtual RMethod RReadScalableImage_StyleValueHandle
		{
			get
			{
				if(r_ReadScalableImage_StyleValueHandle == null)
				{
					r_ReadScalableImage_StyleValueHandle = new(this, "ReadScalableImage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_ReadScalableImage_StyleValueHandle.SetBelong(this.instance);
				}
				return r_ReadScalableImage_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean CustomStartsWith(System.String, System.String)
		/// </summary>
		protected static RMethod r_CustomStartsWith_String_String;
		public static RMethod RCustomStartsWith_String_String
		{
			get
			{
				if(r_CustomStartsWith_String_String == null)
				{
					r_CustomStartsWith_String_String = new(typeof(UnityEngine.UIElements.StyleSheet), "CustomStartsWith", 0, typeof(System.String), typeof(System.String));
					r_CustomStartsWith_String_String.SetBelong(null);
				}
				return r_CustomStartsWith_String_String;
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


        public RStyleSheet() : base("UnityEngine.UIElements.StyleSheet")
        {
        }

        public RStyleSheet(System.Object instance) : base("UnityEngine.UIElements.StyleSheet")
		{
            SetInstance(instance);
		}

        public RStyleSheet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleSheet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean TryCheckAccess<T>(T[] @list, RType @type, RUnityEngine.RUIElements.RStyleValueHandle @handle, out T @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@list, @type.Value, @handle.Value, @value};
            var ___result = RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[3];

            return (System.Boolean)___result;
        }


        public static T CheckAccess<T>(T[] @list, RType @type, RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@list, @type.Value, @handle.Value};
            var ___result = RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlattenImportedStyleSheetsRecursive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlattenImportedStyleSheetsRecursive.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet @sheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet};
            var ___result = RFlattenImportedStyleSheetsRecursive_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetupReferences()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupReferences.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RType ReadKeyword(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadKeyword_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual System.Single ReadFloat(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadFloat_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean TryReadFloat(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.Single @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadFloat_StyleValueHandle_Out_Single.Invoke(___genericsType, ___parameters);
			@value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RDimension ReadDimension(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadDimension_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RDimension(___result);
        }


        public virtual System.Boolean TryReadDimension(RUnityEngine.RUIElements.RStyleValueHandle @handle, out RUnityEngine.RUIElements.RStyleSheets.RDimension @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value.Value};
            var ___result = RTryReadDimension_StyleValueHandle_Out_Dimension.Invoke(___genericsType, ___parameters);
			@value = new RUnityEngine.RUIElements.RStyleSheets.RDimension(___parameters[1]);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Color ReadColor(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadColor_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Boolean TryReadColor(RUnityEngine.RUIElements.RStyleValueHandle @handle, out UnityEngine.Color @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadColor_StyleValueHandle_Out_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadString(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadString_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadString(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadString_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadEnum(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadEnum_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadEnum(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadEnum_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadVariable(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadVariable_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadVariable(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadVariable_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadResourcePath(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadResourcePath_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadResourcePath(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadResourcePath_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Object ReadAssetReference(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadAssetReference_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String ReadMissingAssetReferenceUrl(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadMissingAssetReferenceUrl_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadAssetReference(RUnityEngine.RUIElements.RStyleValueHandle @handle, out UnityEngine.Object @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RTryReadAssetReference_StyleValueHandle_Out_Object.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Object)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual RType ReadFunction(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadFunction_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual System.String ReadFunctionName(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadFunctionName_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RScalableImage ReadScalableImage(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RReadScalableImage_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RScalableImage(___result);
        }


        public static System.Boolean CustomStartsWith(System.String @originalString, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalString, @pattern};
            var ___result = RCustomStartsWith_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean Equals(System.Object @other)
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
