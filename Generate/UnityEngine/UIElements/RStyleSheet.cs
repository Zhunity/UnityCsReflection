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
		protected RSystem.RBoolean r_Fm_ImportedWithErrors;
		public virtual RSystem.RBoolean RFm_ImportedWithErrors
		{
			get
			{
				if(r_Fm_ImportedWithErrors == null)
				{
					r_Fm_ImportedWithErrors = new(this, "m_ImportedWithErrors");
					r_Fm_ImportedWithErrors.SetBelong(this.instance);
				}
				return r_Fm_ImportedWithErrors;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithWarnings
		/// </summary>
		protected RSystem.RBoolean r_Fm_ImportedWithWarnings;
		public virtual RSystem.RBoolean RFm_ImportedWithWarnings
		{
			get
			{
				if(r_Fm_ImportedWithWarnings == null)
				{
					r_Fm_ImportedWithWarnings = new(this, "m_ImportedWithWarnings");
					r_Fm_ImportedWithWarnings.SetBelong(this.instance);
				}
				return r_Fm_ImportedWithWarnings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule[] m_Rules
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleRule> r_Fm_Rules;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleRule> RFm_Rules
		{
			get
			{
				if(r_Fm_Rules == null)
				{
					r_Fm_Rules = new(this, "m_Rules");
					r_Fm_Rules.SetBelong(this.instance);
				}
				return r_Fm_Rules;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleComplexSelector> r_Fm_ComplexSelectors;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleComplexSelector> RFm_ComplexSelectors
		{
			get
			{
				if(r_Fm_ComplexSelectors == null)
				{
					r_Fm_ComplexSelectors = new(this, "m_ComplexSelectors");
					r_Fm_ComplexSelectors.SetBelong(this.instance);
				}
				return r_Fm_ComplexSelectors;
			}
		}

		/// <summary>
		/// System.Single[] floats
		/// </summary>
		protected RFieldArray<RSystem.RSingle> r_Ffloats;
		public virtual RFieldArray<RSystem.RSingle> RFfloats
		{
			get
			{
				if(r_Ffloats == null)
				{
					r_Ffloats = new(this, "floats");
					r_Ffloats.SetBelong(this.instance);
				}
				return r_Ffloats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension[] dimensions
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RDimension> r_Fdimensions;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RDimension> RFdimensions
		{
			get
			{
				if(r_Fdimensions == null)
				{
					r_Fdimensions = new(this, "dimensions");
					r_Fdimensions.SetBelong(this.instance);
				}
				return r_Fdimensions;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] colors
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor> r_Fcolors;
		public virtual RFieldArray<RUnityEngine.RColor> RFcolors
		{
			get
			{
				if(r_Fcolors == null)
				{
					r_Fcolors = new(this, "colors");
					r_Fcolors.SetBelong(this.instance);
				}
				return r_Fcolors;
			}
		}

		/// <summary>
		/// System.String[] strings
		/// </summary>
		protected RFieldArray<RSystem.RString> r_Fstrings;
		public virtual RFieldArray<RSystem.RString> RFstrings
		{
			get
			{
				if(r_Fstrings == null)
				{
					r_Fstrings = new(this, "strings");
					r_Fstrings.SetBelong(this.instance);
				}
				return r_Fstrings;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] assets
		/// </summary>
		protected RFieldArray<RUnityEngine.RObject> r_Fassets;
		public virtual RFieldArray<RUnityEngine.RObject> RFassets
		{
			get
			{
				if(r_Fassets == null)
				{
					r_Fassets = new(this, "assets");
					r_Fassets.SetBelong(this.instance);
				}
				return r_Fassets;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet+ImportStruct[] imports
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheet.RImportStruct> r_Fimports;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheet.RImportStruct> RFimports
		{
			get
			{
				if(r_Fimports == null)
				{
					r_Fimports = new(this, "imports");
					r_Fimports.SetBelong(this.instance);
				}
				return r_Fimports;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] m_FlattenedImportedStyleSheets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_Fm_FlattenedImportedStyleSheets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RFm_FlattenedImportedStyleSheets
		{
			get
			{
				if(r_Fm_FlattenedImportedStyleSheets == null)
				{
					r_Fm_FlattenedImportedStyleSheets = new(this, "m_FlattenedImportedStyleSheets");
					r_Fm_FlattenedImportedStyleSheets.SetBelong(this.instance);
				}
				return r_Fm_FlattenedImportedStyleSheets;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentHash
		/// </summary>
		protected RSystem.RInt32 r_Fm_ContentHash;
		public virtual RSystem.RInt32 RFm_ContentHash
		{
			get
			{
				if(r_Fm_ContentHash == null)
				{
					r_Fm_ContentHash = new(this, "m_ContentHash");
					r_Fm_ContentHash.SetBelong(this.instance);
				}
				return r_Fm_ContentHash;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RScalableImage> r_FscalableImages;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RScalableImage> RFscalableImages
		{
			get
			{
				if(r_FscalableImages == null)
				{
					r_FscalableImages = new(this, "scalableImages");
					r_FscalableImages.SetBelong(this.instance);
				}
				return r_FscalableImages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedNameSelectors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> r_ForderedNameSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> RForderedNameSelectors
		{
			get
			{
				if(r_ForderedNameSelectors == null)
				{
					r_ForderedNameSelectors = new(this, "orderedNameSelectors");
					r_ForderedNameSelectors.SetBelong(this.instance);
				}
				return r_ForderedNameSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedTypeSelectors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> r_ForderedTypeSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> RForderedTypeSelectors
		{
			get
			{
				if(r_ForderedTypeSelectors == null)
				{
					r_ForderedTypeSelectors = new(this, "orderedTypeSelectors");
					r_ForderedTypeSelectors.SetBelong(this.instance);
				}
				return r_ForderedTypeSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedClassSelectors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> r_ForderedClassSelectors;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RUnityEngine.RUIElements.RStyleComplexSelector> RForderedClassSelectors
		{
			get
			{
				if(r_ForderedClassSelectors == null)
				{
					r_ForderedClassSelectors = new(this, "orderedClassSelectors");
					r_ForderedClassSelectors.SetBelong(this.instance);
				}
				return r_ForderedClassSelectors;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDefaultStyleSheet
		/// </summary>
		protected RSystem.RBoolean r_Fm_IsDefaultStyleSheet;
		public virtual RSystem.RBoolean RFm_IsDefaultStyleSheet
		{
			get
			{
				if(r_Fm_IsDefaultStyleSheet == null)
				{
					r_Fm_IsDefaultStyleSheet = new(this, "m_IsDefaultStyleSheet");
					r_Fm_IsDefaultStyleSheet.SetBelong(this.instance);
				}
				return r_Fm_IsDefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String kCustomPropertyMarker
		/// </summary>
		protected static RSystem.RString r_FkCustomPropertyMarker;
		public static RSystem.RString RFkCustomPropertyMarker
		{
			get
			{
				if(r_FkCustomPropertyMarker == null)
				{
					r_FkCustomPropertyMarker = new(typeof(UnityEngine.UIElements.StyleSheet), "kCustomPropertyMarker");
					r_FkCustomPropertyMarker.SetBelong(null);
				}
				return r_FkCustomPropertyMarker;
			}
		}

		/// <summary>
		/// Boolean importedWithErrors
		/// </summary>
		protected RSystem.RBoolean r_PimportedWithErrors;
		public virtual RSystem.RBoolean RPimportedWithErrors
		{
			get
			{
				if(r_PimportedWithErrors == null)
				{
					r_PimportedWithErrors = new(this, "importedWithErrors", -1);
					r_PimportedWithErrors.SetBelong(this.instance);
				}
				return r_PimportedWithErrors;
			}
		}

		/// <summary>
		/// Boolean importedWithWarnings
		/// </summary>
		protected RSystem.RBoolean r_PimportedWithWarnings;
		public virtual RSystem.RBoolean RPimportedWithWarnings
		{
			get
			{
				if(r_PimportedWithWarnings == null)
				{
					r_PimportedWithWarnings = new(this, "importedWithWarnings", -1);
					r_PimportedWithWarnings.SetBelong(this.instance);
				}
				return r_PimportedWithWarnings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule[] rules
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleRule> r_Prules;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleRule> RPrules
		{
			get
			{
				if(r_Prules == null)
				{
					r_Prules = new(this, "rules", -1);
					r_Prules.SetBelong(this.instance);
				}
				return r_Prules;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector[] complexSelectors
		/// </summary>
		protected RPropertyArray<RUnityEngine.RUIElements.RStyleComplexSelector> r_PcomplexSelectors;
		public virtual RPropertyArray<RUnityEngine.RUIElements.RStyleComplexSelector> RPcomplexSelectors
		{
			get
			{
				if(r_PcomplexSelectors == null)
				{
					r_PcomplexSelectors = new(this, "complexSelectors", -1);
					r_PcomplexSelectors.SetBelong(this.instance);
				}
				return r_PcomplexSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] flattenedRecursiveImports
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_PflattenedRecursiveImports;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RPflattenedRecursiveImports
		{
			get
			{
				if(r_PflattenedRecursiveImports == null)
				{
					r_PflattenedRecursiveImports = new(this, "flattenedRecursiveImports", -1);
					r_PflattenedRecursiveImports.SetBelong(this.instance);
				}
				return r_PflattenedRecursiveImports;
			}
		}

		/// <summary>
		/// Int32 contentHash
		/// </summary>
		protected RSystem.RInt32 r_PcontentHash;
		public virtual RSystem.RInt32 RPcontentHash
		{
			get
			{
				if(r_PcontentHash == null)
				{
					r_PcontentHash = new(this, "contentHash", -1);
					r_PcontentHash.SetBelong(this.instance);
				}
				return r_PcontentHash;
			}
		}

		/// <summary>
		/// Boolean isDefaultStyleSheet
		/// </summary>
		protected RSystem.RBoolean r_PisDefaultStyleSheet;
		public virtual RSystem.RBoolean RPisDefaultStyleSheet
		{
			get
			{
				if(r_PisDefaultStyleSheet == null)
				{
					r_PisDefaultStyleSheet = new(this, "isDefaultStyleSheet", -1);
					r_PisDefaultStyleSheet.SetBelong(this.instance);
				}
				return r_PisDefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RUnityEngine.RHideFlags r_PhideFlags;
		public virtual RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Boolean TryCheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle, T ByRef)
		/// </summary>
		protected static RMethod r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
		public static RMethod RMTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T
		{
			get
			{
				if(r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T == null)
				{
					r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T = new(typeof(UnityEngine.UIElements.StyleSheet), "TryCheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T.SetBelong(null);
				}
				return r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
			}
		}

		/// <summary>
		/// T CheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected static RMethod r_MCheckAccess_GT_TArray_StyleValueType_StyleValueHandle;
		public static RMethod RMCheckAccess_GT_TArray_StyleValueType_StyleValueHandle
		{
			get
			{
				if(r_MCheckAccess_GT_TArray_StyleValueType_StyleValueHandle == null)
				{
					r_MCheckAccess_GT_TArray_StyleValueType_StyleValueHandle = new(typeof(UnityEngine.UIElements.StyleSheet), "CheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MCheckAccess_GT_TArray_StyleValueType_StyleValueHandle.SetBelong(null);
				}
				return r_MCheckAccess_GT_TArray_StyleValueType_StyleValueHandle;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
					r_MOnEnable.SetBelong(this.instance);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void FlattenImportedStyleSheetsRecursive()
		/// </summary>
		protected RMethod r_MFlattenImportedStyleSheetsRecursive;
		public virtual RMethod RMFlattenImportedStyleSheetsRecursive
		{
			get
			{
				if(r_MFlattenImportedStyleSheetsRecursive == null)
				{
					r_MFlattenImportedStyleSheetsRecursive = new(this, "FlattenImportedStyleSheetsRecursive", 0);
					r_MFlattenImportedStyleSheetsRecursive.SetBelong(this.instance);
				}
				return r_MFlattenImportedStyleSheetsRecursive;
			}
		}

		/// <summary>
		/// Void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MFlattenImportedStyleSheetsRecursive_StyleSheet;
		public virtual RMethod RMFlattenImportedStyleSheetsRecursive_StyleSheet
		{
			get
			{
				if(r_MFlattenImportedStyleSheetsRecursive_StyleSheet == null)
				{
					r_MFlattenImportedStyleSheetsRecursive_StyleSheet = new(this, "FlattenImportedStyleSheetsRecursive", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_MFlattenImportedStyleSheetsRecursive_StyleSheet.SetBelong(this.instance);
				}
				return r_MFlattenImportedStyleSheetsRecursive_StyleSheet;
			}
		}

		/// <summary>
		/// Void SetupReferences()
		/// </summary>
		protected RMethod r_MSetupReferences;
		public virtual RMethod RMSetupReferences
		{
			get
			{
				if(r_MSetupReferences == null)
				{
					r_MSetupReferences = new(this, "SetupReferences", 0);
					r_MSetupReferences.SetBelong(this.instance);
				}
				return r_MSetupReferences;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadKeyword_StyleValueHandle;
		public virtual RMethod RMReadKeyword_StyleValueHandle
		{
			get
			{
				if(r_MReadKeyword_StyleValueHandle == null)
				{
					r_MReadKeyword_StyleValueHandle = new(this, "ReadKeyword", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadKeyword_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadKeyword_StyleValueHandle;
			}
		}

		/// <summary>
		/// Single ReadFloat(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadFloat_StyleValueHandle;
		public virtual RMethod RMReadFloat_StyleValueHandle
		{
			get
			{
				if(r_MReadFloat_StyleValueHandle == null)
				{
					r_MReadFloat_StyleValueHandle = new(this, "ReadFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadFloat_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadFloat_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadFloat(UnityEngine.UIElements.StyleValueHandle, Single ByRef)
		/// </summary>
		protected RMethod r_MTryReadFloat_StyleValueHandle_Out_Single;
		public virtual RMethod RMTryReadFloat_StyleValueHandle_Out_Single
		{
			get
			{
				if(r_MTryReadFloat_StyleValueHandle_Out_Single == null)
				{
					r_MTryReadFloat_StyleValueHandle_Out_Single = new(this, "TryReadFloat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.Single).MakeByRefType());
					r_MTryReadFloat_StyleValueHandle_Out_Single.SetBelong(this.instance);
				}
				return r_MTryReadFloat_StyleValueHandle_Out_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadDimension_StyleValueHandle;
		public virtual RMethod RMReadDimension_StyleValueHandle
		{
			get
			{
				if(r_MReadDimension_StyleValueHandle == null)
				{
					r_MReadDimension_StyleValueHandle = new(this, "ReadDimension", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadDimension_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadDimension_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadDimension(UnityEngine.UIElements.StyleValueHandle, UnityEngine.UIElements.StyleSheets.Dimension ByRef)
		/// </summary>
		protected RMethod r_MTryReadDimension_StyleValueHandle_Out_Dimension;
		public virtual RMethod RMTryReadDimension_StyleValueHandle_Out_Dimension
		{
			get
			{
				if(r_MTryReadDimension_StyleValueHandle_Out_Dimension == null)
				{
					r_MTryReadDimension_StyleValueHandle_Out_Dimension = new(this, "TryReadDimension", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Dimension").MakeByRefType());
					r_MTryReadDimension_StyleValueHandle_Out_Dimension.SetBelong(this.instance);
				}
				return r_MTryReadDimension_StyleValueHandle_Out_Dimension;
			}
		}

		/// <summary>
		/// UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadColor_StyleValueHandle;
		public virtual RMethod RMReadColor_StyleValueHandle
		{
			get
			{
				if(r_MReadColor_StyleValueHandle == null)
				{
					r_MReadColor_StyleValueHandle = new(this, "ReadColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadColor_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadColor_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadColor(UnityEngine.UIElements.StyleValueHandle, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MTryReadColor_StyleValueHandle_Out_Color;
		public virtual RMethod RMTryReadColor_StyleValueHandle_Out_Color
		{
			get
			{
				if(r_MTryReadColor_StyleValueHandle_Out_Color == null)
				{
					r_MTryReadColor_StyleValueHandle_Out_Color = new(this, "TryReadColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(UnityEngine.Color).MakeByRefType());
					r_MTryReadColor_StyleValueHandle_Out_Color.SetBelong(this.instance);
				}
				return r_MTryReadColor_StyleValueHandle_Out_Color;
			}
		}

		/// <summary>
		/// System.String ReadString(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadString_StyleValueHandle;
		public virtual RMethod RMReadString_StyleValueHandle
		{
			get
			{
				if(r_MReadString_StyleValueHandle == null)
				{
					r_MReadString_StyleValueHandle = new(this, "ReadString", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadString_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadString_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadString(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryReadString_StyleValueHandle_Out_String;
		public virtual RMethod RMTryReadString_StyleValueHandle_Out_String
		{
			get
			{
				if(r_MTryReadString_StyleValueHandle_Out_String == null)
				{
					r_MTryReadString_StyleValueHandle_Out_String = new(this, "TryReadString", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_MTryReadString_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_MTryReadString_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadEnum(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadEnum_StyleValueHandle;
		public virtual RMethod RMReadEnum_StyleValueHandle
		{
			get
			{
				if(r_MReadEnum_StyleValueHandle == null)
				{
					r_MReadEnum_StyleValueHandle = new(this, "ReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadEnum_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadEnum_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadEnum(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryReadEnum_StyleValueHandle_Out_String;
		public virtual RMethod RMTryReadEnum_StyleValueHandle_Out_String
		{
			get
			{
				if(r_MTryReadEnum_StyleValueHandle_Out_String == null)
				{
					r_MTryReadEnum_StyleValueHandle_Out_String = new(this, "TryReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_MTryReadEnum_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_MTryReadEnum_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadVariable(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadVariable_StyleValueHandle;
		public virtual RMethod RMReadVariable_StyleValueHandle
		{
			get
			{
				if(r_MReadVariable_StyleValueHandle == null)
				{
					r_MReadVariable_StyleValueHandle = new(this, "ReadVariable", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadVariable_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadVariable_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadVariable(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryReadVariable_StyleValueHandle_Out_String;
		public virtual RMethod RMTryReadVariable_StyleValueHandle_Out_String
		{
			get
			{
				if(r_MTryReadVariable_StyleValueHandle_Out_String == null)
				{
					r_MTryReadVariable_StyleValueHandle_Out_String = new(this, "TryReadVariable", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_MTryReadVariable_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_MTryReadVariable_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// System.String ReadResourcePath(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadResourcePath_StyleValueHandle;
		public virtual RMethod RMReadResourcePath_StyleValueHandle
		{
			get
			{
				if(r_MReadResourcePath_StyleValueHandle == null)
				{
					r_MReadResourcePath_StyleValueHandle = new(this, "ReadResourcePath", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadResourcePath_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadResourcePath_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle, System.String ByRef)
		/// </summary>
		protected RMethod r_MTryReadResourcePath_StyleValueHandle_Out_String;
		public virtual RMethod RMTryReadResourcePath_StyleValueHandle_Out_String
		{
			get
			{
				if(r_MTryReadResourcePath_StyleValueHandle_Out_String == null)
				{
					r_MTryReadResourcePath_StyleValueHandle_Out_String = new(this, "TryReadResourcePath", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(System.String).MakeByRefType());
					r_MTryReadResourcePath_StyleValueHandle_Out_String.SetBelong(this.instance);
				}
				return r_MTryReadResourcePath_StyleValueHandle_Out_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadAssetReference_StyleValueHandle;
		public virtual RMethod RMReadAssetReference_StyleValueHandle
		{
			get
			{
				if(r_MReadAssetReference_StyleValueHandle == null)
				{
					r_MReadAssetReference_StyleValueHandle = new(this, "ReadAssetReference", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadAssetReference_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadAssetReference_StyleValueHandle;
			}
		}

		/// <summary>
		/// System.String ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadMissingAssetReferenceUrl_StyleValueHandle;
		public virtual RMethod RMReadMissingAssetReferenceUrl_StyleValueHandle
		{
			get
			{
				if(r_MReadMissingAssetReferenceUrl_StyleValueHandle == null)
				{
					r_MReadMissingAssetReferenceUrl_StyleValueHandle = new(this, "ReadMissingAssetReferenceUrl", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadMissingAssetReferenceUrl_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadMissingAssetReferenceUrl_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle, UnityEngine.Object ByRef)
		/// </summary>
		protected RMethod r_MTryReadAssetReference_StyleValueHandle_Out_Object;
		public virtual RMethod RMTryReadAssetReference_StyleValueHandle_Out_Object
		{
			get
			{
				if(r_MTryReadAssetReference_StyleValueHandle_Out_Object == null)
				{
					r_MTryReadAssetReference_StyleValueHandle_Out_Object = new(this, "TryReadAssetReference", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), typeof(UnityEngine.Object).MakeByRefType());
					r_MTryReadAssetReference_StyleValueHandle_Out_Object.SetBelong(this.instance);
				}
				return r_MTryReadAssetReference_StyleValueHandle_Out_Object;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadFunction_StyleValueHandle;
		public virtual RMethod RMReadFunction_StyleValueHandle
		{
			get
			{
				if(r_MReadFunction_StyleValueHandle == null)
				{
					r_MReadFunction_StyleValueHandle = new(this, "ReadFunction", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadFunction_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadFunction_StyleValueHandle;
			}
		}

		/// <summary>
		/// System.String ReadFunctionName(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadFunctionName_StyleValueHandle;
		public virtual RMethod RMReadFunctionName_StyleValueHandle
		{
			get
			{
				if(r_MReadFunctionName_StyleValueHandle == null)
				{
					r_MReadFunctionName_StyleValueHandle = new(this, "ReadFunctionName", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadFunctionName_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadFunctionName_StyleValueHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle)
		/// </summary>
		protected RMethod r_MReadScalableImage_StyleValueHandle;
		public virtual RMethod RMReadScalableImage_StyleValueHandle
		{
			get
			{
				if(r_MReadScalableImage_StyleValueHandle == null)
				{
					r_MReadScalableImage_StyleValueHandle = new(this, "ReadScalableImage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
					r_MReadScalableImage_StyleValueHandle.SetBelong(this.instance);
				}
				return r_MReadScalableImage_StyleValueHandle;
			}
		}

		/// <summary>
		/// Boolean CustomStartsWith(System.String, System.String)
		/// </summary>
		protected static RMethod r_MCustomStartsWith_String_String;
		public static RMethod RMCustomStartsWith_String_String
		{
			get
			{
				if(r_MCustomStartsWith_String_String == null)
				{
					r_MCustomStartsWith_String_String = new(typeof(UnityEngine.UIElements.StyleSheet), "CustomStartsWith", 0, typeof(System.String), typeof(System.String));
					r_MCustomStartsWith_String_String.SetBelong(null);
				}
				return r_MCustomStartsWith_String_String;
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
					r_MSetDirty.SetBelong(this.instance);
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
					r_MGetInstanceID.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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

        public static System.Boolean TryCheckAccess<T>(T[] @list, RUnityEngine.RUIElements.RStyleValueType @type, RUnityEngine.RUIElements.RStyleValueHandle @handle, out T @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@list, @type.Value, @handle.Value, @value};
            var ___result = RMTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[3];

            return (System.Boolean)___result;
        }


        public static T CheckAccess<T>(T[] @list, RUnityEngine.RUIElements.RStyleValueType @type, RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@list, @type.Value, @handle.Value};
            var ___result = RMCheckAccess_GT_TArray_StyleValueType_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlattenImportedStyleSheetsRecursive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlattenImportedStyleSheetsRecursive.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet @sheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet};
            var ___result = RMFlattenImportedStyleSheetsRecursive_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetupReferences()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetupReferences.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RStyleValueKeyword ReadKeyword(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadKeyword_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleValueKeyword(___result);
        }


        public virtual System.Single ReadFloat(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadFloat_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean TryReadFloat(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.Single @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadFloat_StyleValueHandle_Out_Single.Invoke(___genericsType, ___parameters);
			@value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RDimension ReadDimension(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadDimension_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RDimension(___result);
        }


        public virtual System.Boolean TryReadDimension(RUnityEngine.RUIElements.RStyleValueHandle @handle, out RUnityEngine.RUIElements.RStyleSheets.RDimension @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value.Value};
            var ___result = RMTryReadDimension_StyleValueHandle_Out_Dimension.Invoke(___genericsType, ___parameters);
			@value = new RUnityEngine.RUIElements.RStyleSheets.RDimension(___parameters[1]);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Color ReadColor(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadColor_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Boolean TryReadColor(RUnityEngine.RUIElements.RStyleValueHandle @handle, out UnityEngine.Color @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadColor_StyleValueHandle_Out_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadString(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadString_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadString(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadString_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadEnum(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadEnum_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadEnum(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadEnum_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadVariable(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadVariable_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadVariable(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadVariable_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String ReadResourcePath(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadResourcePath_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadResourcePath(RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadResourcePath_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Object ReadAssetReference(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadAssetReference_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.String ReadMissingAssetReferenceUrl(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadMissingAssetReferenceUrl_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryReadAssetReference(RUnityEngine.RUIElements.RStyleValueHandle @handle, out UnityEngine.Object @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadAssetReference_StyleValueHandle_Out_Object.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Object)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual RUnityEngine.RUIElements.RStyleValueFunction ReadFunction(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadFunction_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleValueFunction(___result);
        }


        public virtual System.String ReadFunctionName(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadFunctionName_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RScalableImage ReadScalableImage(RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadScalableImage_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RScalableImage(___result);
        }


        public static System.Boolean CustomStartsWith(System.String @originalString, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalString, @pattern};
            var ___result = RMCustomStartsWith_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
