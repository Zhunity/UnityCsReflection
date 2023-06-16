
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.StyleSheet
	/// </summary>
    public partial class RStyleSheet : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.StyleSheet);
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


		/// <summary>
		/// System.Boolean m_ImportedWithErrors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ImportedWithErrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ImportedWithErrors
		{
			get
			{
				if(r_Fm_ImportedWithErrors == null)
				{
					r_Fm_ImportedWithErrors = new(this, "m_ImportedWithErrors");
				}
				return r_Fm_ImportedWithErrors;
			}
		}

		/// <summary>
		/// System.Boolean m_ImportedWithWarnings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ImportedWithWarnings;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ImportedWithWarnings
		{
			get
			{
				if(r_Fm_ImportedWithWarnings == null)
				{
					r_Fm_ImportedWithWarnings = new(this, "m_ImportedWithWarnings");
				}
				return r_Fm_ImportedWithWarnings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule[] m_Rules
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule> r_Fm_Rules;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule> RFm_Rules
		{
			get
			{
				if(r_Fm_Rules == null)
				{
					r_Fm_Rules = new(this, "m_Rules");
				}
				return r_Fm_Rules;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> r_Fm_ComplexSelectors;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> RFm_ComplexSelectors
		{
			get
			{
				if(r_Fm_ComplexSelectors == null)
				{
					r_Fm_ComplexSelectors = new(this, "m_ComplexSelectors");
				}
				return r_Fm_ComplexSelectors;
			}
		}

		/// <summary>
		/// System.Single[] floats
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> r_Ffloats;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RSingle> RFfloats
		{
			get
			{
				if(r_Ffloats == null)
				{
					r_Ffloats = new(this, "floats");
				}
				return r_Ffloats;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Dimension[] dimensions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RDimension> r_Fdimensions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RDimension> RFdimensions
		{
			get
			{
				if(r_Fdimensions == null)
				{
					r_Fdimensions = new(this, "dimensions");
				}
				return r_Fdimensions;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] colors
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RColor> r_Fcolors;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RColor> RFcolors
		{
			get
			{
				if(r_Fcolors == null)
				{
					r_Fcolors = new(this, "colors");
				}
				return r_Fcolors;
			}
		}

		/// <summary>
		/// System.String[] strings
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fstrings;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFstrings
		{
			get
			{
				if(r_Fstrings == null)
				{
					r_Fstrings = new(this, "strings");
				}
				return r_Fstrings;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] assets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Fassets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> RFassets
		{
			get
			{
				if(r_Fassets == null)
				{
					r_Fassets = new(this, "assets");
				}
				return r_Fassets;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet+ImportStruct[] imports
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet.RImportStruct> r_Fimports;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet.RImportStruct> RFimports
		{
			get
			{
				if(r_Fimports == null)
				{
					r_Fimports = new(this, "imports");
				}
				return r_Fimports;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] m_FlattenedImportedStyleSheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_Fm_FlattenedImportedStyleSheets;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RFm_FlattenedImportedStyleSheets
		{
			get
			{
				if(r_Fm_FlattenedImportedStyleSheets == null)
				{
					r_Fm_FlattenedImportedStyleSheets = new(this, "m_FlattenedImportedStyleSheets");
				}
				return r_Fm_FlattenedImportedStyleSheets;
			}
		}

		/// <summary>
		/// System.Int32 m_ContentHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ContentHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ContentHash
		{
			get
			{
				if(r_Fm_ContentHash == null)
				{
					r_Fm_ContentHash = new(this, "m_ContentHash");
				}
				return r_Fm_ContentHash;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RScalableImage> r_FscalableImages;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RScalableImage> RFscalableImages
		{
			get
			{
				if(r_FscalableImages == null)
				{
					r_FscalableImages = new(this, "scalableImages");
				}
				return r_FscalableImages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedNameSelectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> r_ForderedNameSelectors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> RForderedNameSelectors
		{
			get
			{
				if(r_ForderedNameSelectors == null)
				{
					r_ForderedNameSelectors = new(this, "orderedNameSelectors");
				}
				return r_ForderedNameSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedTypeSelectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> r_ForderedTypeSelectors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> RForderedTypeSelectors
		{
			get
			{
				if(r_ForderedTypeSelectors == null)
				{
					r_ForderedTypeSelectors = new(this, "orderedTypeSelectors");
				}
				return r_ForderedTypeSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleComplexSelector] orderedClassSelectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> r_ForderedClassSelectors;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> RForderedClassSelectors
		{
			get
			{
				if(r_ForderedClassSelectors == null)
				{
					r_ForderedClassSelectors = new(this, "orderedClassSelectors");
				}
				return r_ForderedClassSelectors;
			}
		}

		/// <summary>
		/// System.Boolean m_IsDefaultStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IsDefaultStyleSheet;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IsDefaultStyleSheet
		{
			get
			{
				if(r_Fm_IsDefaultStyleSheet == null)
				{
					r_Fm_IsDefaultStyleSheet = new(this, "m_IsDefaultStyleSheet");
				}
				return r_Fm_IsDefaultStyleSheet;
			}
		}

		/// <summary>
		/// System.String kCustomPropertyMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FkCustomPropertyMarker;
		public static Hvak.Editor.Refleaction.RSystem.RString RFkCustomPropertyMarker
		{
			get
			{
				if(r_FkCustomPropertyMarker == null)
				{
					r_FkCustomPropertyMarker = new(Type, "kCustomPropertyMarker");
				}
				return r_FkCustomPropertyMarker;
			}
		}

		/// <summary>
		/// Boolean importedWithErrors
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PimportedWithErrors;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPimportedWithErrors
		{
			get
			{
				if(r_PimportedWithErrors == null)
				{
					r_PimportedWithErrors = new(this, "importedWithErrors", -1);
				}
				return r_PimportedWithErrors;
			}
		}

		/// <summary>
		/// Boolean importedWithWarnings
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PimportedWithWarnings;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPimportedWithWarnings
		{
			get
			{
				if(r_PimportedWithWarnings == null)
				{
					r_PimportedWithWarnings = new(this, "importedWithWarnings", -1);
				}
				return r_PimportedWithWarnings;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleRule[] rules
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule> r_Prules;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule> RPrules
		{
			get
			{
				if(r_Prules == null)
				{
					r_Prules = new(this, "rules", -1);
				}
				return r_Prules;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleComplexSelector[] complexSelectors
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> r_PcomplexSelectors;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleComplexSelector> RPcomplexSelectors
		{
			get
			{
				if(r_PcomplexSelectors == null)
				{
					r_PcomplexSelectors = new(this, "complexSelectors", -1);
				}
				return r_PcomplexSelectors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] flattenedRecursiveImports
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_PflattenedRecursiveImports;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RPflattenedRecursiveImports
		{
			get
			{
				if(r_PflattenedRecursiveImports == null)
				{
					r_PflattenedRecursiveImports = new(this, "flattenedRecursiveImports", -1);
				}
				return r_PflattenedRecursiveImports;
			}
		}

		/// <summary>
		/// Int32 contentHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcontentHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcontentHash
		{
			get
			{
				if(r_PcontentHash == null)
				{
					r_PcontentHash = new(this, "contentHash", -1);
				}
				return r_PcontentHash;
			}
		}

		/// <summary>
		/// Boolean isDefaultStyleSheet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDefaultStyleSheet;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDefaultStyleSheet
		{
			get
			{
				if(r_PisDefaultStyleSheet == null)
				{
					r_PisDefaultStyleSheet = new(this, "isDefaultStyleSheet", -1);
				}
				return r_PisDefaultStyleSheet;
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
		/// Boolean TryCheckAccess[T](T[], UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleValueHandle, T ByRef)
		/// </summary>
		protected static RMethod r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T;
		public static RMethod RMTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T
		{
			get
			{
				if(r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T == null)
				{
					r_MTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T = new(Type, "TryCheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"), Type.MakeGenericMethodParameter(0).MakeByRefType());
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
					r_MCheckAccess_GT_TArray_StyleValueType_StyleValueHandle = new(Type, "CheckAccess", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueHandle"));
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
					r_MCustomStartsWith_String_String = new(Type, "CustomStartsWith", 0, typeof(System.String), typeof(System.String));
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


        public static System.Boolean TryCheckAccess<T>(T[] @list, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType @type, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out T @value)
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@list, @type.Value, @handle.Value, @value};
            var ___result = RMTryCheckAccess_GT_TArray_StyleValueType_StyleValueHandle_Out_T.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<T>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static T CheckAccess<T>(T[] @list, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueType @type, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@list, @type.Value, @handle.Value};
            var ___result = RMCheckAccess_GT_TArray_StyleValueType_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueKeyword ReadKeyword(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadKeyword_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueKeyword>(___result);
        }


        public virtual System.Single ReadFloat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadFloat_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Boolean TryReadFloat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.Single @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadFloat_StyleValueHandle_Out_Single.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.Single>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RDimension ReadDimension(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadDimension_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RDimension>(___result);
        }


        public virtual System.Boolean TryReadDimension(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RDimension @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value.Value};
            var ___result = RMTryReadDimension_StyleValueHandle_Out_Dimension.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RDimension>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Color ReadColor(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadColor_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Color>(___result);
        }


        public virtual System.Boolean TryReadColor(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out UnityEngine.Color @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadColor_StyleValueHandle_Out_Color.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Color>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ReadString(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadString_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryReadString(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadString_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ReadEnum(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadEnum_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryReadEnum(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadEnum_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ReadVariable(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadVariable_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryReadVariable(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadVariable_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ReadResourcePath(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadResourcePath_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryReadResourcePath(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadResourcePath_StyleValueHandle_Out_String.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.String>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Object ReadAssetReference(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadAssetReference_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Object>(___result);
        }


        public virtual System.String ReadMissingAssetReferenceUrl(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadMissingAssetReferenceUrl_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryReadAssetReference(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle, out UnityEngine.Object @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value, @value};
            var ___result = RMTryReadAssetReference_StyleValueHandle_Out_Object.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Object>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueFunction ReadFunction(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadFunction_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueFunction>(___result);
        }


        public virtual System.String ReadFunctionName(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadFunctionName_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RScalableImage ReadScalableImage(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleValueHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle.Value};
            var ___result = RMReadScalableImage_StyleValueHandle.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RScalableImage>(___result);
        }


        public static System.Boolean CustomStartsWith(System.String @originalString, System.String @pattern)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalString, @pattern};
            var ___result = RMCustomStartsWith_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
