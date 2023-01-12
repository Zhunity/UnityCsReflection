using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.StylePropertyReader
	/// </summary>
    public partial class RStylePropertyReader : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyReader+GetCursorIdFunction getCursorIdFunc
		/// </summary>
		protected static RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader.RGetCursorIdFunction r_FgetCursorIdFunc;
		public static RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader.RGetCursorIdFunction RFgetCursorIdFunc
		{
			get
			{
				if(r_FgetCursorIdFunc == null)
				{
					r_FgetCursorIdFunc = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "getCursorIdFunc");
					r_FgetCursorIdFunc.SetBelong(null);
				}
				return r_FgetCursorIdFunc;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_Fm_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> RFm_Values
		{
			get
			{
				if(r_Fm_Values == null)
				{
					r_Fm_Values = new(this, "m_Values");
					r_Fm_Values.SetBelong(this.instance);
				}
				return r_Fm_Values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_ValueCount
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RInt32> r_Fm_ValueCount;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RInt32> RFm_ValueCount
		{
			get
			{
				if(r_Fm_ValueCount == null)
				{
					r_Fm_ValueCount = new(this, "m_ValueCount");
					r_Fm_ValueCount.SetBelong(this.instance);
				}
				return r_Fm_ValueCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableResolver m_Resolver
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableResolver r_Fm_Resolver;
		public virtual RUnityEngine.RUIElements.RStyleVariableResolver RFm_Resolver
		{
			get
			{
				if(r_Fm_Resolver == null)
				{
					r_Fm_Resolver = new(this, "m_Resolver");
					r_Fm_Resolver.SetBelong(this.instance);
				}
				return r_Fm_Resolver;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet m_Sheet
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheet r_Fm_Sheet;
		public virtual RUnityEngine.RUIElements.RStyleSheet RFm_Sheet
		{
			get
			{
				if(r_Fm_Sheet == null)
				{
					r_Fm_Sheet = new(this, "m_Sheet");
					r_Fm_Sheet.SetBelong(this.instance);
				}
				return r_Fm_Sheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty[] m_Properties
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleProperty> r_Fm_Properties;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleProperty> RFm_Properties
		{
			get
			{
				if(r_Fm_Properties == null)
				{
					r_Fm_Properties = new(this, "m_Properties");
					r_Fm_Properties.SetBelong(this.instance);
				}
				return r_Fm_Properties;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId[] m_PropertyIds
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> r_Fm_PropertyIds;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> RFm_PropertyIds
		{
			get
			{
				if(r_Fm_PropertyIds == null)
				{
					r_Fm_PropertyIds = new(this, "m_PropertyIds");
					r_Fm_PropertyIds.SetBelong(this.instance);
				}
				return r_Fm_PropertyIds;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentValueIndex
		/// </summary>
		protected RSystem.RInt32 r_Fm_CurrentValueIndex;
		public virtual RSystem.RInt32 RFm_CurrentValueIndex
		{
			get
			{
				if(r_Fm_CurrentValueIndex == null)
				{
					r_Fm_CurrentValueIndex = new(this, "m_CurrentValueIndex");
					r_Fm_CurrentValueIndex.SetBelong(this.instance);
				}
				return r_Fm_CurrentValueIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentPropertyIndex
		/// </summary>
		protected RSystem.RInt32 r_Fm_CurrentPropertyIndex;
		public virtual RSystem.RInt32 RFm_CurrentPropertyIndex
		{
			get
			{
				if(r_Fm_CurrentPropertyIndex == null)
				{
					r_Fm_CurrentPropertyIndex = new(this, "m_CurrentPropertyIndex");
					r_Fm_CurrentPropertyIndex.SetBelong(this.instance);
				}
				return r_Fm_CurrentPropertyIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty <property>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleProperty r_F__0__property__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RStyleProperty RF__0__property__1__k__BackingField
		{
			get
			{
				if(r_F__0__property__1__k__BackingField == null)
				{
					r_F__0__property__1__k__BackingField = new(this, "<property>k__BackingField");
					r_F__0__property__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__property__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId <propertyId>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_F__0__propertyId__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RF__0__propertyId__1__k__BackingField
		{
			get
			{
				if(r_F__0__propertyId__1__k__BackingField == null)
				{
					r_F__0__propertyId__1__k__BackingField = new(this, "<propertyId>k__BackingField");
					r_F__0__propertyId__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__propertyId__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <valueCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r_F__0__valueCount__1__k__BackingField;
		public virtual RSystem.RInt32 RF__0__valueCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__valueCount__1__k__BackingField == null)
				{
					r_F__0__valueCount__1__k__BackingField = new(this, "<valueCount>k__BackingField");
					r_F__0__valueCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__valueCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <dpiScaling>k__BackingField
		/// </summary>
		protected RSystem.RSingle r_F__0__dpiScaling__1__k__BackingField;
		public virtual RSystem.RSingle RF__0__dpiScaling__1__k__BackingField
		{
			get
			{
				if(r_F__0__dpiScaling__1__k__BackingField == null)
				{
					r_F__0__dpiScaling__1__k__BackingField = new(this, "<dpiScaling>k__BackingField");
					r_F__0__dpiScaling__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__dpiScaling__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty property
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleProperty r_Pproperty;
		public virtual RUnityEngine.RUIElements.RStyleProperty RPproperty
		{
			get
			{
				if(r_Pproperty == null)
				{
					r_Pproperty = new(this, "property", -1);
					r_Pproperty.SetBelong(this.instance);
				}
				return r_Pproperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId propertyId
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_PpropertyId;
		public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RPpropertyId
		{
			get
			{
				if(r_PpropertyId == null)
				{
					r_PpropertyId = new(this, "propertyId", -1);
					r_PpropertyId.SetBelong(this.instance);
				}
				return r_PpropertyId;
			}
		}

		/// <summary>
		/// Int32 valueCount
		/// </summary>
		protected RSystem.RInt32 r_PvalueCount;
		public virtual RSystem.RInt32 RPvalueCount
		{
			get
			{
				if(r_PvalueCount == null)
				{
					r_PvalueCount = new(this, "valueCount", -1);
					r_PvalueCount.SetBelong(this.instance);
				}
				return r_PvalueCount;
			}
		}

		/// <summary>
		/// Single dpiScaling
		/// </summary>
		protected RSystem.RSingle r_PdpiScaling;
		public virtual RSystem.RSingle RPdpiScaling
		{
			get
			{
				if(r_PdpiScaling == null)
				{
					r_PdpiScaling = new(this, "dpiScaling", -1);
					r_PdpiScaling.SetBelong(this.instance);
				}
				return r_PdpiScaling;
			}
		}

		/// <summary>
		/// Void SetContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleComplexSelector, UnityEngine.UIElements.StyleVariableContext, Single)
		/// </summary>
		protected RMethod r_MSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single;
		public virtual RMethod RMSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single
		{
			get
			{
				if(r_MSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single == null)
				{
					r_MSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single = new(this, "SetContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"), typeof(System.Single));
					r_MSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single.SetBelong(this.instance);
				}
				return r_MSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single;
			}
		}

		/// <summary>
		/// Void SetInlineContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleProperty[], UnityEngine.UIElements.StyleSheets.StylePropertyId[], Single)
		/// </summary>
		protected RMethod r_MSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single;
		public virtual RMethod RMSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single
		{
			get
			{
				if(r_MSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single == null)
				{
					r_MSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single = new(this, "SetInlineContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleProperty").MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId").MakeArrayType(), typeof(System.Single));
					r_MSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single.SetBelong(this.instance);
				}
				return r_MSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty()
		/// </summary>
		protected RMethod r_MMoveNextProperty;
		public virtual RMethod RMMoveNextProperty
		{
			get
			{
				if(r_MMoveNextProperty == null)
				{
					r_MMoveNextProperty = new(this, "MoveNextProperty", 0);
					r_MMoveNextProperty.SetBelong(this.instance);
				}
				return r_MMoveNextProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(Int32)
		/// </summary>
		protected RMethod r_MGetValue_Int32;
		public virtual RMethod RMGetValue_Int32
		{
			get
			{
				if(r_MGetValue_Int32 == null)
				{
					r_MGetValue_Int32 = new(this, "GetValue", 0, typeof(System.Int32));
					r_MGetValue_Int32.SetBelong(this.instance);
				}
				return r_MGetValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType GetValueType(Int32)
		/// </summary>
		protected RMethod r_MGetValueType_Int32;
		public virtual RMethod RMGetValueType_Int32
		{
			get
			{
				if(r_MGetValueType_Int32 == null)
				{
					r_MGetValueType_Int32 = new(this, "GetValueType", 0, typeof(System.Int32));
					r_MGetValueType_Int32.SetBelong(this.instance);
				}
				return r_MGetValueType_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValueType(Int32, UnityEngine.UIElements.StyleValueType)
		/// </summary>
		protected RMethod r_MIsValueType_Int32_StyleValueType;
		public virtual RMethod RMIsValueType_Int32_StyleValueType
		{
			get
			{
				if(r_MIsValueType_Int32_StyleValueType == null)
				{
					r_MIsValueType_Int32_StyleValueType = new(this, "IsValueType", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"));
					r_MIsValueType_Int32_StyleValueType.SetBelong(this.instance);
				}
				return r_MIsValueType_Int32_StyleValueType;
			}
		}

		/// <summary>
		/// Boolean IsKeyword(Int32, UnityEngine.UIElements.StyleValueKeyword)
		/// </summary>
		protected RMethod r_MIsKeyword_Int32_StyleValueKeyword;
		public virtual RMethod RMIsKeyword_Int32_StyleValueKeyword
		{
			get
			{
				if(r_MIsKeyword_Int32_StyleValueKeyword == null)
				{
					r_MIsKeyword_Int32_StyleValueKeyword = new(this, "IsKeyword", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueKeyword"));
					r_MIsKeyword_Int32_StyleValueKeyword.SetBelong(this.instance);
				}
				return r_MIsKeyword_Int32_StyleValueKeyword;
			}
		}

		/// <summary>
		/// System.String ReadAsString(Int32)
		/// </summary>
		protected RMethod r_MReadAsString_Int32;
		public virtual RMethod RMReadAsString_Int32
		{
			get
			{
				if(r_MReadAsString_Int32 == null)
				{
					r_MReadAsString_Int32 = new(this, "ReadAsString", 0, typeof(System.Int32));
					r_MReadAsString_Int32.SetBelong(this.instance);
				}
				return r_MReadAsString_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ReadLength(Int32)
		/// </summary>
		protected RMethod r_MReadLength_Int32;
		public virtual RMethod RMReadLength_Int32
		{
			get
			{
				if(r_MReadLength_Int32 == null)
				{
					r_MReadLength_Int32 = new(this, "ReadLength", 0, typeof(System.Int32));
					r_MReadLength_Int32.SetBelong(this.instance);
				}
				return r_MReadLength_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeValue ReadTimeValue(Int32)
		/// </summary>
		protected RMethod r_MReadTimeValue_Int32;
		public virtual RMethod RMReadTimeValue_Int32
		{
			get
			{
				if(r_MReadTimeValue_Int32 == null)
				{
					r_MReadTimeValue_Int32 = new(this, "ReadTimeValue", 0, typeof(System.Int32));
					r_MReadTimeValue_Int32.SetBelong(this.instance);
				}
				return r_MReadTimeValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate ReadTranslate(Int32)
		/// </summary>
		protected RMethod r_MReadTranslate_Int32;
		public virtual RMethod RMReadTranslate_Int32
		{
			get
			{
				if(r_MReadTranslate_Int32 == null)
				{
					r_MReadTranslate_Int32 = new(this, "ReadTranslate", 0, typeof(System.Int32));
					r_MReadTranslate_Int32.SetBelong(this.instance);
				}
				return r_MReadTranslate_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(Int32)
		/// </summary>
		protected RMethod r_MReadTransformOrigin_Int32;
		public virtual RMethod RMReadTransformOrigin_Int32
		{
			get
			{
				if(r_MReadTransformOrigin_Int32 == null)
				{
					r_MReadTransformOrigin_Int32 = new(this, "ReadTransformOrigin", 0, typeof(System.Int32));
					r_MReadTransformOrigin_Int32.SetBelong(this.instance);
				}
				return r_MReadTransformOrigin_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate ReadRotate(Int32)
		/// </summary>
		protected RMethod r_MReadRotate_Int32;
		public virtual RMethod RMReadRotate_Int32
		{
			get
			{
				if(r_MReadRotate_Int32 == null)
				{
					r_MReadRotate_Int32 = new(this, "ReadRotate", 0, typeof(System.Int32));
					r_MReadRotate_Int32.SetBelong(this.instance);
				}
				return r_MReadRotate_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale ReadScale(Int32)
		/// </summary>
		protected RMethod r_MReadScale_Int32;
		public virtual RMethod RMReadScale_Int32
		{
			get
			{
				if(r_MReadScale_Int32 == null)
				{
					r_MReadScale_Int32 = new(this, "ReadScale", 0, typeof(System.Int32));
					r_MReadScale_Int32.SetBelong(this.instance);
				}
				return r_MReadScale_Int32;
			}
		}

		/// <summary>
		/// Single ReadFloat(Int32)
		/// </summary>
		protected RMethod r_MReadFloat_Int32;
		public virtual RMethod RMReadFloat_Int32
		{
			get
			{
				if(r_MReadFloat_Int32 == null)
				{
					r_MReadFloat_Int32 = new(this, "ReadFloat", 0, typeof(System.Int32));
					r_MReadFloat_Int32.SetBelong(this.instance);
				}
				return r_MReadFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Int32)
		/// </summary>
		protected RMethod r_MReadInt_Int32;
		public virtual RMethod RMReadInt_Int32
		{
			get
			{
				if(r_MReadInt_Int32 == null)
				{
					r_MReadInt_Int32 = new(this, "ReadInt", 0, typeof(System.Int32));
					r_MReadInt_Int32.SetBelong(this.instance);
				}
				return r_MReadInt_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color ReadColor(Int32)
		/// </summary>
		protected RMethod r_MReadColor_Int32;
		public virtual RMethod RMReadColor_Int32
		{
			get
			{
				if(r_MReadColor_Int32 == null)
				{
					r_MReadColor_Int32 = new(this, "ReadColor", 0, typeof(System.Int32));
					r_MReadColor_Int32.SetBelong(this.instance);
				}
				return r_MReadColor_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, Int32)
		/// </summary>
		protected RMethod r_MReadEnum_StyleEnumType_Int32;
		public virtual RMethod RMReadEnum_StyleEnumType_Int32
		{
			get
			{
				if(r_MReadEnum_StyleEnumType_Int32 == null)
				{
					r_MReadEnum_StyleEnumType_Int32 = new(this, "ReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), typeof(System.Int32));
					r_MReadEnum_StyleEnumType_Int32.SetBelong(this.instance);
				}
				return r_MReadEnum_StyleEnumType_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition ReadFontDefinition(Int32)
		/// </summary>
		protected RMethod r_MReadFontDefinition_Int32;
		public virtual RMethod RMReadFontDefinition_Int32
		{
			get
			{
				if(r_MReadFontDefinition_Int32 == null)
				{
					r_MReadFontDefinition_Int32 = new(this, "ReadFontDefinition", 0, typeof(System.Int32));
					r_MReadFontDefinition_Int32.SetBelong(this.instance);
				}
				return r_MReadFontDefinition_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Font ReadFont(Int32)
		/// </summary>
		protected RMethod r_MReadFont_Int32;
		public virtual RMethod RMReadFont_Int32
		{
			get
			{
				if(r_MReadFont_Int32 == null)
				{
					r_MReadFont_Int32 = new(this, "ReadFont", 0, typeof(System.Int32));
					r_MReadFont_Int32.SetBelong(this.instance);
				}
				return r_MReadFont_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background ReadBackground(Int32)
		/// </summary>
		protected RMethod r_MReadBackground_Int32;
		public virtual RMethod RMReadBackground_Int32
		{
			get
			{
				if(r_MReadBackground_Int32 == null)
				{
					r_MReadBackground_Int32 = new(this, "ReadBackground", 0, typeof(System.Int32));
					r_MReadBackground_Int32.SetBelong(this.instance);
				}
				return r_MReadBackground_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Cursor ReadCursor(Int32)
		/// </summary>
		protected RMethod r_MReadCursor_Int32;
		public virtual RMethod RMReadCursor_Int32
		{
			get
			{
				if(r_MReadCursor_Int32 == null)
				{
					r_MReadCursor_Int32 = new(this, "ReadCursor", 0, typeof(System.Int32));
					r_MReadCursor_Int32.SetBelong(this.instance);
				}
				return r_MReadCursor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextShadow ReadTextShadow(Int32)
		/// </summary>
		protected RMethod r_MReadTextShadow_Int32;
		public virtual RMethod RMReadTextShadow_Int32
		{
			get
			{
				if(r_MReadTextShadow_Int32 == null)
				{
					r_MReadTextShadow_Int32 = new(this, "ReadTextShadow", 0, typeof(System.Int32));
					r_MReadTextShadow_Int32.SetBelong(this.instance);
				}
				return r_MReadTextShadow_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionX(Int32)
		/// </summary>
		protected RMethod r_MReadBackgroundPositionX_Int32;
		public virtual RMethod RMReadBackgroundPositionX_Int32
		{
			get
			{
				if(r_MReadBackgroundPositionX_Int32 == null)
				{
					r_MReadBackgroundPositionX_Int32 = new(this, "ReadBackgroundPositionX", 0, typeof(System.Int32));
					r_MReadBackgroundPositionX_Int32.SetBelong(this.instance);
				}
				return r_MReadBackgroundPositionX_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionY(Int32)
		/// </summary>
		protected RMethod r_MReadBackgroundPositionY_Int32;
		public virtual RMethod RMReadBackgroundPositionY_Int32
		{
			get
			{
				if(r_MReadBackgroundPositionY_Int32 == null)
				{
					r_MReadBackgroundPositionY_Int32 = new(this, "ReadBackgroundPositionY", 0, typeof(System.Int32));
					r_MReadBackgroundPositionY_Int32.SetBelong(this.instance);
				}
				return r_MReadBackgroundPositionY_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(Int32, UnityEngine.UIElements.BackgroundPositionKeyword)
		/// </summary>
		protected RMethod r_MReadBackgroundPosition_Int32_BackgroundPositionKeyword;
		public virtual RMethod RMReadBackgroundPosition_Int32_BackgroundPositionKeyword
		{
			get
			{
				if(r_MReadBackgroundPosition_Int32_BackgroundPositionKeyword == null)
				{
					r_MReadBackgroundPosition_Int32_BackgroundPositionKeyword = new(this, "ReadBackgroundPosition", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.BackgroundPositionKeyword));
					r_MReadBackgroundPosition_Int32_BackgroundPositionKeyword.SetBelong(this.instance);
				}
				return r_MReadBackgroundPosition_Int32_BackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(Int32)
		/// </summary>
		protected RMethod r_MReadBackgroundRepeat_Int32;
		public virtual RMethod RMReadBackgroundRepeat_Int32
		{
			get
			{
				if(r_MReadBackgroundRepeat_Int32 == null)
				{
					r_MReadBackgroundRepeat_Int32 = new(this, "ReadBackgroundRepeat", 0, typeof(System.Int32));
					r_MReadBackgroundRepeat_Int32.SetBelong(this.instance);
				}
				return r_MReadBackgroundRepeat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(Int32)
		/// </summary>
		protected RMethod r_MReadBackgroundSize_Int32;
		public virtual RMethod RMReadBackgroundSize_Int32
		{
			get
			{
				if(r_MReadBackgroundSize_Int32 == null)
				{
					r_MReadBackgroundSize_Int32 = new(this, "ReadBackgroundSize", 0, typeof(System.Int32));
					r_MReadBackgroundSize_Int32.SetBelong(this.instance);
				}
				return r_MReadBackgroundSize_Int32;
			}
		}

		/// <summary>
		/// Void ReadListEasingFunction(System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction], Int32)
		/// </summary>
		protected RMethod r_MReadListEasingFunction_List_d_EasingFunction_p__Int32;
		public virtual RMethod RMReadListEasingFunction_List_d_EasingFunction_p__Int32
		{
			get
			{
				if(r_MReadListEasingFunction_List_d_EasingFunction_p__Int32 == null)
				{
					r_MReadListEasingFunction_List_d_EasingFunction_p__Int32 = new(this, "ReadListEasingFunction", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.EasingFunction)), typeof(System.Int32));
					r_MReadListEasingFunction_List_d_EasingFunction_p__Int32.SetBelong(this.instance);
				}
				return r_MReadListEasingFunction_List_d_EasingFunction_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListTimeValue(System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue], Int32)
		/// </summary>
		protected RMethod r_MReadListTimeValue_List_d_TimeValue_p__Int32;
		public virtual RMethod RMReadListTimeValue_List_d_TimeValue_p__Int32
		{
			get
			{
				if(r_MReadListTimeValue_List_d_TimeValue_p__Int32 == null)
				{
					r_MReadListTimeValue_List_d_TimeValue_p__Int32 = new(this, "ReadListTimeValue", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.TimeValue)), typeof(System.Int32));
					r_MReadListTimeValue_List_d_TimeValue_p__Int32.SetBelong(this.instance);
				}
				return r_MReadListTimeValue_List_d_TimeValue_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListStylePropertyName(System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName], Int32)
		/// </summary>
		protected RMethod r_MReadListStylePropertyName_List_d_StylePropertyName_p__Int32;
		public virtual RMethod RMReadListStylePropertyName_List_d_StylePropertyName_p__Int32
		{
			get
			{
				if(r_MReadListStylePropertyName_List_d_StylePropertyName_p__Int32 == null)
				{
					r_MReadListStylePropertyName_List_d_StylePropertyName_p__Int32 = new(this, "ReadListStylePropertyName", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.StylePropertyName)), typeof(System.Int32));
					r_MReadListStylePropertyName_List_d_StylePropertyName_p__Int32.SetBelong(this.instance);
				}
				return r_MReadListStylePropertyName_List_d_StylePropertyName_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListString(System.Collections.Generic.List`1[System.String], Int32)
		/// </summary>
		protected RMethod r_MReadListString_List_d_String_p__Int32;
		public virtual RMethod RMReadListString_List_d_String_p__Int32
		{
			get
			{
				if(r_MReadListString_List_d_String_p__Int32 == null)
				{
					r_MReadListString_List_d_String_p__Int32 = new(this, "ReadListString", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)), typeof(System.Int32));
					r_MReadListString_List_d_String_p__Int32.SetBelong(this.instance);
				}
				return r_MReadListString_List_d_String_p__Int32;
			}
		}

		/// <summary>
		/// Void LoadProperties()
		/// </summary>
		protected RMethod r_MLoadProperties;
		public virtual RMethod RMLoadProperties
		{
			get
			{
				if(r_MLoadProperties == null)
				{
					r_MLoadProperties = new(this, "LoadProperties", 0);
					r_MLoadProperties.SetBelong(this.instance);
				}
				return r_MLoadProperties;
			}
		}

		/// <summary>
		/// Void SetCurrentProperty()
		/// </summary>
		protected RMethod r_MSetCurrentProperty;
		public virtual RMethod RMSetCurrentProperty
		{
			get
			{
				if(r_MSetCurrentProperty == null)
				{
					r_MSetCurrentProperty = new(this, "SetCurrentProperty", 0);
					r_MSetCurrentProperty.SetBelong(this.instance);
				}
				return r_MSetCurrentProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RMReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_MReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_MReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTransformOrigin", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_MReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected static RMethod r_MReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean;
		public static RMethod RMReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean == null)
				{
					r_MReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTransformOriginEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean.SetBelong(null);
				}
				return r_MReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate ReadTranslate(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RMReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_MReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_MReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTranslate", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_MReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale ReadScale(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RMReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_MReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_MReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadScale", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_MReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate ReadRotate(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RMReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_MReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_MReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadRotate", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_MReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// Boolean TryReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32;
		public static RMethod RMTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32
		{
			get
			{
				if(r_MTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32 == null)
				{
					r_MTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "TryReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Int32).MakeByRefType());
					r_MTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32.SetBelong(null);
				}
				return r_MTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadEnum_StyleEnumType_StylePropertyValue;
		public static RMethod RMReadEnum_StyleEnumType_StylePropertyValue
		{
			get
			{
				if(r_MReadEnum_StyleEnumType_StylePropertyValue == null)
				{
					r_MReadEnum_StyleEnumType_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadEnum_StyleEnumType_StylePropertyValue.SetBelong(null);
				}
				return r_MReadEnum_StyleEnumType_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadAngle_StylePropertyValue;
		public static RMethod RMReadAngle_StylePropertyValue
		{
			get
			{
				if(r_MReadAngle_StylePropertyValue == null)
				{
					r_MReadAngle_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadAngle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadAngle_StylePropertyValue.SetBelong(null);
				}
				return r_MReadAngle_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.BackgroundPositionKeyword)
		/// </summary>
		protected static RMethod r_MReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword;
		public static RMethod RMReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword
		{
			get
			{
				if(r_MReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword == null)
				{
					r_MReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundPosition", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(UnityEngine.UIElements.BackgroundPositionKeyword));
					r_MReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword.SetBelong(null);
				}
				return r_MReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue;
		public static RMethod RMReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_MReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue == null)
				{
					r_MReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundRepeat", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_MReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_MReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue;
		public static RMethod RMReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_MReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue == null)
				{
					r_MReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundSize", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_MReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_MReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// Boolean TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue, Single, UnityEngine.UIElements.StyleSheets.ImageSource ByRef)
		/// </summary>
		protected static RMethod r_MTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource;
		public static RMethod RMTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource
		{
			get
			{
				if(r_MTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource == null)
				{
					r_MTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "TryGetImageSourceFromValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.ImageSource").MakeByRefType());
					r_MTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource.SetBelong(null);
				}
				return r_MTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource;
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


        public RStylePropertyReader() : base("UnityEngine.UIElements.StyleSheets.StylePropertyReader")
        {
        }

        public RStylePropertyReader(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.StylePropertyReader")
		{
            SetInstance(instance);
		}

        public RStylePropertyReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStylePropertyReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetContext(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleComplexSelector @selector, RUnityEngine.RUIElements.RStyleVariableContext @varContext, System.Single @dpiScaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @selector.Value, @varContext.Value, @dpiScaling};
            var ___result = RMSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineContext(UnityEngine.UIElements.StyleSheet @sheet, RTypeArray<RUnityEngine.RUIElements.RStyleProperty> @properties, RTypeArray<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> @propertyIds, System.Single @dpiScaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @properties.Value, @propertyIds.Value, @dpiScaling};
            var ___result = RMSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId MoveNextProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNextProperty.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue GetValue(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetValue_Int32.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleValueType GetValueType(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetValueType_Int32.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleValueType(___result);
        }


        public virtual System.Boolean IsValueType(System.Int32 @index, RUnityEngine.RUIElements.RStyleValueType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @type.Value};
            var ___result = RMIsValueType_Int32_StyleValueType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsKeyword(System.Int32 @index, RUnityEngine.RUIElements.RStyleValueKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @keyword.Value};
            var ___result = RMIsKeyword_Int32_StyleValueKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ReadAsString(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadAsString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.UIElements.Length ReadLength(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadLength_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual UnityEngine.UIElements.TimeValue ReadTimeValue(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadTimeValue_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public virtual UnityEngine.UIElements.Translate ReadTranslate(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadTranslate_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Translate)___result;
        }


        public virtual UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadTransformOrigin_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public virtual UnityEngine.UIElements.Rotate ReadRotate(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadRotate_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public virtual UnityEngine.UIElements.Scale ReadScale(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadScale_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public virtual System.Single ReadFloat(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 ReadInt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Color ReadColor(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Int32 ReadEnum(RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType @enumType, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @index};
            var ___result = RMReadEnum_StyleEnumType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.FontDefinition ReadFontDefinition(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadFontDefinition_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FontDefinition)___result;
        }


        public virtual UnityEngine.Font ReadFont(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadFont_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public virtual UnityEngine.UIElements.Background ReadBackground(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadBackground_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public virtual UnityEngine.UIElements.Cursor ReadCursor(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadCursor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Cursor)___result;
        }


        public virtual UnityEngine.UIElements.TextShadow ReadTextShadow(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadTextShadow_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TextShadow)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionX(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadBackgroundPositionX_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionY(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadBackgroundPositionY_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(System.Int32 @index, UnityEngine.UIElements.BackgroundPositionKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @keyword};
            var ___result = RMReadBackgroundPosition_Int32_BackgroundPositionKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadBackgroundRepeat_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMReadBackgroundSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundSize)___result;
        }


        public virtual void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RMReadListEasingFunction_List_d_EasingFunction_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RMReadListTimeValue_List_d_TimeValue_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RMReadListStylePropertyName_List_d_StylePropertyName_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListString(System.Collections.Generic.List<System.String> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RMReadListString_List_d_String_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMLoadProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCurrentProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetCurrentProperty.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @zVvalue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @zVvalue.Value};
            var ___result = RMReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public static UnityEngine.UIElements.Length ReadTransformOriginEnum(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value, out System.Boolean @isVertical, out System.Boolean @isHorizontal)
        {
			@isVertical = default;
			@isHorizontal = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value, @isVertical, @isHorizontal};
            var ___result = RMReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isVertical = (System.Boolean)___parameters[1];
			@isHorizontal = (System.Boolean)___parameters[2];

            return (UnityEngine.UIElements.Length)___result;
        }


        public static UnityEngine.UIElements.Translate ReadTranslate(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @val3.Value};
            var ___result = RMReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Translate)___result;
        }


        public static UnityEngine.UIElements.Scale ReadScale(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @val3.Value};
            var ___result = RMReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public static UnityEngine.UIElements.Rotate ReadRotate(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val3, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val4)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @val3.Value, @val4.Value};
            var ___result = RMReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public static System.Boolean TryReadEnum(RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType @enumType, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value, out System.Int32 @intValue)
        {
			@intValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @value.Value, @intValue};
            var ___result = RMTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32.Invoke(___genericsType, ___parameters);
			@intValue = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Int32 ReadEnum(RUnityEngine.RUIElements.RStyleSheets.RStyleEnumType @enumType, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @value.Value};
            var ___result = RMReadEnum_StyleEnumType_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.UIElements.Angle ReadAngle(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMReadAngle_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, UnityEngine.UIElements.BackgroundPositionKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @keyword};
            var ___result = RMReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public static UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value};
            var ___result = RMReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public static UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value};
            var ___result = RMReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundSize)___result;
        }


        public static System.Boolean TryGetImageSourceFromValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @propertyValue, System.Single @dpiScaling, out RUnityEngine.RUIElements.RStyleSheets.RImageSource @source)
        {
			@source = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyValue.Value, @dpiScaling, @source.Value};
            var ___result = RMTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource.Invoke(___genericsType, ___parameters);
			@source = new RUnityEngine.RUIElements.RStyleSheets.RImageSource(___parameters[2]);

            return (System.Boolean)___result;
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
