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
		protected RField r_m_ImportedWithErrors;
		public virtual RField Rm_ImportedWithErrors
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
		protected RField r_m_ImportedWithWarnings;
		public virtual RField Rm_ImportedWithWarnings
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
		protected RFieldArray<RField> r_floats;
		public virtual RFieldArray<RField> Rfloats
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
		protected RFieldArray<RField> r_strings;
		public virtual RFieldArray<RField> Rstrings
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
		protected RField r_m_ContentHash;
		public virtual RField Rm_ContentHash
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
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector> r_orderedNameSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector> RorderedNameSelectors
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
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector> r_orderedTypeSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector> RorderedTypeSelectors
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
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector> r_orderedClassSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleComplexSelector> RorderedClassSelectors
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
		protected RField r_m_IsDefaultStyleSheet;
		public virtual RField Rm_IsDefaultStyleSheet
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
		protected static RField r_kCustomPropertyMarker;
		public static RField RkCustomPropertyMarker
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
		protected RProperty r_importedWithErrors;
		public virtual RProperty RimportedWithErrors
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
		protected RProperty r_importedWithWarnings;
		public virtual RProperty RimportedWithWarnings
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
		protected RProperty r_contentHash;
		public virtual RProperty RcontentHash
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
		protected RProperty r_isDefaultStyleSheet;
		public virtual RProperty RisDefaultStyleSheet
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
		/// Boolean TryCheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle, T ByRef)
		/// </summary>
		protected static RMethod r_RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
		public static RMethod RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T
		{
			get
			{
				if(r_RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T == null)
				{
					r_RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T = new(typeof(UnityEngine.UIElements.StyleSheet), "TryCheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T.SetBelong(null);
				}
				return r_RTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
			}
		}

		/// <summary>
		/// T CheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected static RMethod r_RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle;
		public static RMethod RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle
		{
			get
			{
				if(r_RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle == null)
				{
					r_RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle = new(typeof(UnityEngine.UIElements.StyleSheet), "CheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle.SetBelong(null);
				}
				return r_RCheckAccess_GT_TArray_StyleValueType_StyleValueHandle;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_ROnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_ROnEnable == null)
				{
					r_ROnEnable = new(this, "OnEnable", 0);
					r_ROnEnable.SetBelong(this.instance);
				}
				return r_ROnEnable;
			}
		}

		/// <summary>
		/// Void FlattenImportedStyleSheetsRecursive()
		/// </summary>
		protected RMethod r_RFlattenImportedStyleSheetsRecursive;
		public virtual RMethod RFlattenImportedStyleSheetsRecursive
		{
			get
			{
				if(r_RFlattenImportedStyleSheetsRecursive == null)
				{
					r_RFlattenImportedStyleSheetsRecursive = new(this, "FlattenImportedStyleSheetsRecursive", 0);
					r_RFlattenImportedStyleSheetsRecursive.SetBelong(this.instance);
				}
				return r_RFlattenImportedStyleSheetsRecursive;
			}
		}

		/// <summary>
		/// Void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_RFlattenImportedStyleSheetsRecursive_StyleSheet;
		public virtual RMethod RFlattenImportedStyleSheetsRecursive_StyleSheet
		{
			get
			{
				if(r_RFlattenImportedStyleSheetsRecursive_StyleSheet == null)
				{
					r_RFlattenImportedStyleSheetsRecursive_StyleSheet = new(this, "FlattenImportedStyleSheetsRecursive", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_RFlattenImportedStyleSheetsRecursive_StyleSheet.SetBelong(this.instance);
				}
				return r_RFlattenImportedStyleSheetsRecursive_StyleSheet;
			}
		}

		/// <summary>
		/// Void SetupReferences()
		/// </summary>
		protected RMethod r_RSetupReferences;
		public virtual RMethod RSetupReferences
		{
			get
			{
				if(r_RSetupReferences == null)
				{
					r_RSetupReferences = new(this, "SetupReferences", 0);
					r_RSetupReferences.SetBelong(this.instance);
				}
				return r_RSetupReferences;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadKeyword_StyleValueHandle;
		public virtual RMethod RReadKeyword_StyleValueHandle
		{
			get
			{
				if(r_RReadKeyword_StyleValueHandle == null)
				{
					r_RReadKeyword_StyleValueHandle = new(this, "ReadKeyword", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadKeyword_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadKeyword_StyleValueHandle;
			}
		}

		/// <summary>
		/// Single ReadFloat(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadFloat_StyleValueHandle;
		public virtual RMethod RReadFloat_StyleValueHandle
		{
			get
			{
				if(r_RReadFloat_StyleValueHandle == null)
				{
					r_RReadFloat_StyleValueHandle = new(this, "ReadFloat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadFloat_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadFloat_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadFloat(UnityEngine.UIElements.StyleValueHandle, Single ByRef)
		/// </summary>
		protected RMethod r_RTryReadFloat_StyleValueHandle_Out_Single;
		public virtual RMethod RTryReadFloat_StyleValueHandle_Out_Single
		{
			get
			{
				if(r_RTryReadFloat_StyleValueHandle_Out_Single == null)
				{
					r_RTryReadFloat_StyleValueHandle_Out_Single = new(this, "TryReadFloat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.Single).MakeByRefType());
					r_RTryReadFloat_StyleValueHandle_Out_Single.SetBelong(this.instance);
				}
				return r_RTryReadFloat_StyleValueHandle_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadDimension_StyleValueHandle;
		public virtual RMethod RReadDimension_StyleValueHandle
		{
			get
			{
				if(r_RReadDimension_StyleValueHandle == null)
				{
					r_RReadDimension_StyleValueHandle = new(this, "ReadDimension", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadDimension_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadDimension_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadDimension(UnityEngine.UIElements.StyleValueHandle, UnityEngine.UIElements.StyleSheets.Dimension ByRef)
		/// </summary>
		protected RMethod r_RTryReadDimension_StyleValueHandle_Out_Dimension;
		public virtual RMethod RTryReadDimension_StyleValueHandle_Out_Dimension
		{
			get
			{
				if(r_RTryReadDimension_StyleValueHandle_Out_Dimension == null)
				{
					r_RTryReadDimension_StyleValueHandle_Out_Dimension = new(this, "TryReadDimension", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension").MakeByRefType());
					r_RTryReadDimension_StyleValueHandle_Out_Dimension.SetBelong(this.instance);
				}
				return r_RTryReadDimension_StyleValueHandle_Out_Dimension;
			}
		}

		/// <summary>
		/// UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadColor_StyleValueHandle;
		public virtual RMethod RReadColor_StyleValueHandle
		{
			get
			{
				if(r_RReadColor_StyleValueHandle == null)
				{
					r_RReadColor_StyleValueHandle = new(this, "ReadColor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadColor_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadColor_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadColor(UnityEngine.UIElements.StyleValueHandle, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RTryReadColor_StyleValueHandle_Out_Color;
		public virtual RMethod RTryReadColor_StyleValueHandle_Out_Color
		{
			get
			{
				if(r_RTryReadColor_StyleValueHandle_Out_Color == null)
				{
					r_RTryReadColor_StyleValueHandle_Out_Color = new(this, "TryReadColor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(UnityEngine.Color).MakeByRefType());
					r_RTryReadColor_StyleValueHandle_Out_Color.SetBelong(this.instance);
				}
				return r_RTryReadColor_StyleValueHandle_Out_Color;
			}
		}

		/// <summary>
		/// System.String ReadString(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadString_StyleValueHandle;
		public virtual RMethod RReadString_StyleValueHandle
		{
			get
			{
				if(r_RReadString_StyleValueHandle == null)
				{
					r_RReadString_StyleValueHandle = new(this, "ReadString", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadString_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadString_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadString(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_RTryReadString_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadString_StyleValueHandle_Out_String
		{
			get
			{
				if(r_RTryReadString_StyleValueHandle_Out_String == null)
				{
					r_RTryReadString_StyleValueHandle_Out_String = new(this, "TryReadString", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_RTryReadString_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_RTryReadString_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadEnum(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadEnum_StyleValueHandle;
		public virtual RMethod RReadEnum_StyleValueHandle
		{
			get
			{
				if(r_RReadEnum_StyleValueHandle == null)
				{
					r_RReadEnum_StyleValueHandle = new(this, "ReadEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadEnum_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadEnum_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadEnum(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_RTryReadEnum_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadEnum_StyleValueHandle_Out_String
		{
			get
			{
				if(r_RTryReadEnum_StyleValueHandle_Out_String == null)
				{
					r_RTryReadEnum_StyleValueHandle_Out_String = new(this, "TryReadEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_RTryReadEnum_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_RTryReadEnum_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadVariable(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadVariable_StyleValueHandle;
		public virtual RMethod RReadVariable_StyleValueHandle
		{
			get
			{
				if(r_RReadVariable_StyleValueHandle == null)
				{
					r_RReadVariable_StyleValueHandle = new(this, "ReadVariable", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadVariable_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadVariable_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadVariable(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_RTryReadVariable_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadVariable_StyleValueHandle_Out_String
		{
			get
			{
				if(r_RTryReadVariable_StyleValueHandle_Out_String == null)
				{
					r_RTryReadVariable_StyleValueHandle_Out_String = new(this, "TryReadVariable", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_RTryReadVariable_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_RTryReadVariable_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadResourcePath(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadResourcePath_StyleValueHandle;
		public virtual RMethod RReadResourcePath_StyleValueHandle
		{
			get
			{
				if(r_RReadResourcePath_StyleValueHandle == null)
				{
					r_RReadResourcePath_StyleValueHandle = new(this, "ReadResourcePath", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadResourcePath_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadResourcePath_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_RTryReadResourcePath_StyleValueHandle_Out_String;
		public virtual RMethod RTryReadResourcePath_StyleValueHandle_Out_String
		{
			get
			{
				if(r_RTryReadResourcePath_StyleValueHandle_Out_String == null)
				{
					r_RTryReadResourcePath_StyleValueHandle_Out_String = new(this, "TryReadResourcePath", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_RTryReadResourcePath_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_RTryReadResourcePath_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadAssetReference_StyleValueHandle;
		public virtual RMethod RReadAssetReference_StyleValueHandle
		{
			get
			{
				if(r_RReadAssetReference_StyleValueHandle == null)
				{
					r_RReadAssetReference_StyleValueHandle = new(this, "ReadAssetReference", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadAssetReference_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadAssetReference_StyleValueHandle;
			}
		}

		/// <summary>
		/// System.String ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadMissingAssetReferenceUrl_StyleValueHandle;
		public virtual RMethod RReadMissingAssetReferenceUrl_StyleValueHandle
		{
			get
			{
				if(r_RReadMissingAssetReferenceUrl_StyleValueHandle == null)
				{
					r_RReadMissingAssetReferenceUrl_StyleValueHandle = new(this, "ReadMissingAssetReferenceUrl", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadMissingAssetReferenceUrl_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadMissingAssetReferenceUrl_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle, UnityEngine.Object ByRef)
		/// </summary>
		protected RMethod r_RTryReadAssetReference_StyleValueHandle_Out_Object;
		public virtual RMethod RTryReadAssetReference_StyleValueHandle_Out_Object
		{
			get
			{
				if(r_RTryReadAssetReference_StyleValueHandle_Out_Object == null)
				{
					r_RTryReadAssetReference_StyleValueHandle_Out_Object = new(this, "TryReadAssetReference", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(UnityEngine.Object).MakeByRefType());
					r_RTryReadAssetReference_StyleValueHandle_Out_Object.SetBelong(this.instance);
				}
				return r_RTryReadAssetReference_StyleValueHandle_Out_Object;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadFunction_StyleValueHandle;
		public virtual RMethod RReadFunction_StyleValueHandle
		{
			get
			{
				if(r_RReadFunction_StyleValueHandle == null)
				{
					r_RReadFunction_StyleValueHandle = new(this, "ReadFunction", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadFunction_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadFunction_StyleValueHandle;
			}
		}

		/// <summary>
		/// System.String ReadFunctionName(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadFunctionName_StyleValueHandle;
		public virtual RMethod RReadFunctionName_StyleValueHandle
		{
			get
			{
				if(r_RReadFunctionName_StyleValueHandle == null)
				{
					r_RReadFunctionName_StyleValueHandle = new(this, "ReadFunctionName", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadFunctionName_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadFunctionName_StyleValueHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_RReadScalableImage_StyleValueHandle;
		public virtual RMethod RReadScalableImage_StyleValueHandle
		{
			get
			{
				if(r_RReadScalableImage_StyleValueHandle == null)
				{
					r_RReadScalableImage_StyleValueHandle = new(this, "ReadScalableImage", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_RReadScalableImage_StyleValueHandle.SetBelong(this.instance);
				}
				return r_RReadScalableImage_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean CustomStartsWith(System.String, System.String)
		/// </summary>
		protected static RMethod r_RCustomStartsWith_String_String;
		public static RMethod RCustomStartsWith_String_String
		{
			get
			{
				if(r_RCustomStartsWith_String_String == null)
				{
					r_RCustomStartsWith_String_String = new(typeof(UnityEngine.UIElements.StyleSheet), "CustomStartsWith", 0, typeof(System.String), typeof(System.String));
					r_RCustomStartsWith_String_String.SetBelong(null);
				}
				return r_RCustomStartsWith_String_String;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public virtual void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet  @sheet)
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























        public static System.Boolean CustomStartsWith(System.String  @originalString, System.String  @pattern)
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
