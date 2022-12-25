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
		protected static RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader.RGetCursorIdFunction r_getCursorIdFunc;
		public static RUnityEngine.RUIElements.RStyleSheets.RStylePropertyReader.RGetCursorIdFunction RgetCursorIdFunc
		{
			get
			{
				if(r_getCursorIdFunc == null)
				{
					r_getCursorIdFunc = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "getCursorIdFunc");
					r_getCursorIdFunc.SetBelong(null);
				}
				return r_getCursorIdFunc;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_m_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> Rm_Values
		{
			get
			{
				if(r_m_Values == null)
				{
					r_m_Values = new(this, "m_Values");
					r_m_Values.SetBelong(this.instance);
				}
				return r_m_Values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_ValueCount
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_ValueCount;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_ValueCount
		{
			get
			{
				if(r_m_ValueCount == null)
				{
					r_m_ValueCount = new(this, "m_ValueCount");
					r_m_ValueCount.SetBelong(this.instance);
				}
				return r_m_ValueCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableResolver m_Resolver
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableResolver r_m_Resolver;
		public virtual RUnityEngine.RUIElements.RStyleVariableResolver Rm_Resolver
		{
			get
			{
				if(r_m_Resolver == null)
				{
					r_m_Resolver = new(this, "m_Resolver");
					r_m_Resolver.SetBelong(this.instance);
				}
				return r_m_Resolver;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheet m_Sheet
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleSheet r_m_Sheet;
		public virtual RUnityEngine.RUIElements.RStyleSheet Rm_Sheet
		{
			get
			{
				if(r_m_Sheet == null)
				{
					r_m_Sheet = new(this, "m_Sheet");
					r_m_Sheet.SetBelong(this.instance);
				}
				return r_m_Sheet;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty[] m_Properties
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RStyleProperty> r_m_Properties;
		public virtual RFieldArray<RUnityEngine.RUIElements.RStyleProperty> Rm_Properties
		{
			get
			{
				if(r_m_Properties == null)
				{
					r_m_Properties = new(this, "m_Properties");
					r_m_Properties.SetBelong(this.instance);
				}
				return r_m_Properties;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId[] m_PropertyIds
		/// </summary>
		protected RFieldArray<RField> r_m_PropertyIds;
		public virtual RFieldArray<RField> Rm_PropertyIds
		{
			get
			{
				if(r_m_PropertyIds == null)
				{
					r_m_PropertyIds = new(this, "m_PropertyIds");
					r_m_PropertyIds.SetBelong(this.instance);
				}
				return r_m_PropertyIds;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentValueIndex
		/// </summary>
		protected RField r_m_CurrentValueIndex;
		public virtual RField Rm_CurrentValueIndex
		{
			get
			{
				if(r_m_CurrentValueIndex == null)
				{
					r_m_CurrentValueIndex = new(this, "m_CurrentValueIndex");
					r_m_CurrentValueIndex.SetBelong(this.instance);
				}
				return r_m_CurrentValueIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_CurrentPropertyIndex
		/// </summary>
		protected RField r_m_CurrentPropertyIndex;
		public virtual RField Rm_CurrentPropertyIndex
		{
			get
			{
				if(r_m_CurrentPropertyIndex == null)
				{
					r_m_CurrentPropertyIndex = new(this, "m_CurrentPropertyIndex");
					r_m_CurrentPropertyIndex.SetBelong(this.instance);
				}
				return r_m_CurrentPropertyIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty <property>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleProperty r___1__property__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RStyleProperty R__1__property__2__k__BackingField
		{
			get
			{
				if(r___1__property__2__k__BackingField == null)
				{
					r___1__property__2__k__BackingField = new(this, "<property>k__BackingField");
					r___1__property__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__property__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId <propertyId>k__BackingField
		/// </summary>
		protected RField r___1__propertyId__2__k__BackingField;
		public virtual RField R__1__propertyId__2__k__BackingField
		{
			get
			{
				if(r___1__propertyId__2__k__BackingField == null)
				{
					r___1__propertyId__2__k__BackingField = new(this, "<propertyId>k__BackingField");
					r___1__propertyId__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__propertyId__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <valueCount>k__BackingField
		/// </summary>
		protected RField r___1__valueCount__2__k__BackingField;
		public virtual RField R__1__valueCount__2__k__BackingField
		{
			get
			{
				if(r___1__valueCount__2__k__BackingField == null)
				{
					r___1__valueCount__2__k__BackingField = new(this, "<valueCount>k__BackingField");
					r___1__valueCount__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__valueCount__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <dpiScaling>k__BackingField
		/// </summary>
		protected RField r___1__dpiScaling__2__k__BackingField;
		public virtual RField R__1__dpiScaling__2__k__BackingField
		{
			get
			{
				if(r___1__dpiScaling__2__k__BackingField == null)
				{
					r___1__dpiScaling__2__k__BackingField = new(this, "<dpiScaling>k__BackingField");
					r___1__dpiScaling__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__dpiScaling__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleProperty property
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleProperty r_property;
		public virtual RUnityEngine.RUIElements.RStyleProperty Rproperty
		{
			get
			{
				if(r_property == null)
				{
					r_property = new(this, "property", -1);
					r_property.SetBelong(this.instance);
				}
				return r_property;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId propertyId
		/// </summary>
		protected RProperty r_propertyId;
		public virtual RProperty RpropertyId
		{
			get
			{
				if(r_propertyId == null)
				{
					r_propertyId = new(this, "propertyId", -1);
					r_propertyId.SetBelong(this.instance);
				}
				return r_propertyId;
			}
		}

		/// <summary>
		/// Int32 valueCount
		/// </summary>
		protected RProperty r_valueCount;
		public virtual RProperty RvalueCount
		{
			get
			{
				if(r_valueCount == null)
				{
					r_valueCount = new(this, "valueCount", -1);
					r_valueCount.SetBelong(this.instance);
				}
				return r_valueCount;
			}
		}

		/// <summary>
		/// Single dpiScaling
		/// </summary>
		protected RProperty r_dpiScaling;
		public virtual RProperty RdpiScaling
		{
			get
			{
				if(r_dpiScaling == null)
				{
					r_dpiScaling = new(this, "dpiScaling", -1);
					r_dpiScaling.SetBelong(this.instance);
				}
				return r_dpiScaling;
			}
		}

		/// <summary>
		/// Void SetContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleComplexSelector, UnityEngine.UIElements.StyleVariableContext, Single)
		/// </summary>
		protected RMethod r_RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single;
		public virtual RMethod RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single
		{
			get
			{
				if(r_RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single == null)
				{
					r_RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single = new(this, "SetContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"), typeof(System.Single));
					r_RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single.SetBelong(this.instance);
				}
				return r_RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single;
			}
		}

		/// <summary>
		/// Void SetInlineContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleProperty[], UnityEngine.UIElements.StyleSheets.StylePropertyId[], Single)
		/// </summary>
		protected RMethod r_RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single;
		public virtual RMethod RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single
		{
			get
			{
				if(r_RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single == null)
				{
					r_RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single = new(this, "SetInlineContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleProperty").MakeArrayType(),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId").MakeArrayType(), typeof(System.Single));
					r_RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single.SetBelong(this.instance);
				}
				return r_RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty()
		/// </summary>
		protected RMethod r_RMoveNextProperty;
		public virtual RMethod RMoveNextProperty
		{
			get
			{
				if(r_RMoveNextProperty == null)
				{
					r_RMoveNextProperty = new(this, "MoveNextProperty", 0);
					r_RMoveNextProperty.SetBelong(this.instance);
				}
				return r_RMoveNextProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(Int32)
		/// </summary>
		protected RMethod r_RGetValue_Int32;
		public virtual RMethod RGetValue_Int32
		{
			get
			{
				if(r_RGetValue_Int32 == null)
				{
					r_RGetValue_Int32 = new(this, "GetValue", 0, typeof(System.Int32));
					r_RGetValue_Int32.SetBelong(this.instance);
				}
				return r_RGetValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType GetValueType(Int32)
		/// </summary>
		protected RMethod r_RGetValueType_Int32;
		public virtual RMethod RGetValueType_Int32
		{
			get
			{
				if(r_RGetValueType_Int32 == null)
				{
					r_RGetValueType_Int32 = new(this, "GetValueType", 0, typeof(System.Int32));
					r_RGetValueType_Int32.SetBelong(this.instance);
				}
				return r_RGetValueType_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValueType(Int32, UnityEngine.UIElements.StyleValueType)
		/// </summary>
		protected RMethod r_RIsValueType_Int32_StyleValueType;
		public virtual RMethod RIsValueType_Int32_StyleValueType
		{
			get
			{
				if(r_RIsValueType_Int32_StyleValueType == null)
				{
					r_RIsValueType_Int32_StyleValueType = new(this, "IsValueType", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueType"));
					r_RIsValueType_Int32_StyleValueType.SetBelong(this.instance);
				}
				return r_RIsValueType_Int32_StyleValueType;
			}
		}

		/// <summary>
		/// Boolean IsKeyword(Int32, UnityEngine.UIElements.StyleValueKeyword)
		/// </summary>
		protected RMethod r_RIsKeyword_Int32_StyleValueKeyword;
		public virtual RMethod RIsKeyword_Int32_StyleValueKeyword
		{
			get
			{
				if(r_RIsKeyword_Int32_StyleValueKeyword == null)
				{
					r_RIsKeyword_Int32_StyleValueKeyword = new(this, "IsKeyword", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleValueKeyword"));
					r_RIsKeyword_Int32_StyleValueKeyword.SetBelong(this.instance);
				}
				return r_RIsKeyword_Int32_StyleValueKeyword;
			}
		}

		/// <summary>
		/// System.String ReadAsString(Int32)
		/// </summary>
		protected RMethod r_RReadAsString_Int32;
		public virtual RMethod RReadAsString_Int32
		{
			get
			{
				if(r_RReadAsString_Int32 == null)
				{
					r_RReadAsString_Int32 = new(this, "ReadAsString", 0, typeof(System.Int32));
					r_RReadAsString_Int32.SetBelong(this.instance);
				}
				return r_RReadAsString_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ReadLength(Int32)
		/// </summary>
		protected RMethod r_RReadLength_Int32;
		public virtual RMethod RReadLength_Int32
		{
			get
			{
				if(r_RReadLength_Int32 == null)
				{
					r_RReadLength_Int32 = new(this, "ReadLength", 0, typeof(System.Int32));
					r_RReadLength_Int32.SetBelong(this.instance);
				}
				return r_RReadLength_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeValue ReadTimeValue(Int32)
		/// </summary>
		protected RMethod r_RReadTimeValue_Int32;
		public virtual RMethod RReadTimeValue_Int32
		{
			get
			{
				if(r_RReadTimeValue_Int32 == null)
				{
					r_RReadTimeValue_Int32 = new(this, "ReadTimeValue", 0, typeof(System.Int32));
					r_RReadTimeValue_Int32.SetBelong(this.instance);
				}
				return r_RReadTimeValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate ReadTranslate(Int32)
		/// </summary>
		protected RMethod r_RReadTranslate_Int32;
		public virtual RMethod RReadTranslate_Int32
		{
			get
			{
				if(r_RReadTranslate_Int32 == null)
				{
					r_RReadTranslate_Int32 = new(this, "ReadTranslate", 0, typeof(System.Int32));
					r_RReadTranslate_Int32.SetBelong(this.instance);
				}
				return r_RReadTranslate_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(Int32)
		/// </summary>
		protected RMethod r_RReadTransformOrigin_Int32;
		public virtual RMethod RReadTransformOrigin_Int32
		{
			get
			{
				if(r_RReadTransformOrigin_Int32 == null)
				{
					r_RReadTransformOrigin_Int32 = new(this, "ReadTransformOrigin", 0, typeof(System.Int32));
					r_RReadTransformOrigin_Int32.SetBelong(this.instance);
				}
				return r_RReadTransformOrigin_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate ReadRotate(Int32)
		/// </summary>
		protected RMethod r_RReadRotate_Int32;
		public virtual RMethod RReadRotate_Int32
		{
			get
			{
				if(r_RReadRotate_Int32 == null)
				{
					r_RReadRotate_Int32 = new(this, "ReadRotate", 0, typeof(System.Int32));
					r_RReadRotate_Int32.SetBelong(this.instance);
				}
				return r_RReadRotate_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale ReadScale(Int32)
		/// </summary>
		protected RMethod r_RReadScale_Int32;
		public virtual RMethod RReadScale_Int32
		{
			get
			{
				if(r_RReadScale_Int32 == null)
				{
					r_RReadScale_Int32 = new(this, "ReadScale", 0, typeof(System.Int32));
					r_RReadScale_Int32.SetBelong(this.instance);
				}
				return r_RReadScale_Int32;
			}
		}

		/// <summary>
		/// Single ReadFloat(Int32)
		/// </summary>
		protected RMethod r_RReadFloat_Int32;
		public virtual RMethod RReadFloat_Int32
		{
			get
			{
				if(r_RReadFloat_Int32 == null)
				{
					r_RReadFloat_Int32 = new(this, "ReadFloat", 0, typeof(System.Int32));
					r_RReadFloat_Int32.SetBelong(this.instance);
				}
				return r_RReadFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Int32)
		/// </summary>
		protected RMethod r_RReadInt_Int32;
		public virtual RMethod RReadInt_Int32
		{
			get
			{
				if(r_RReadInt_Int32 == null)
				{
					r_RReadInt_Int32 = new(this, "ReadInt", 0, typeof(System.Int32));
					r_RReadInt_Int32.SetBelong(this.instance);
				}
				return r_RReadInt_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color ReadColor(Int32)
		/// </summary>
		protected RMethod r_RReadColor_Int32;
		public virtual RMethod RReadColor_Int32
		{
			get
			{
				if(r_RReadColor_Int32 == null)
				{
					r_RReadColor_Int32 = new(this, "ReadColor", 0, typeof(System.Int32));
					r_RReadColor_Int32.SetBelong(this.instance);
				}
				return r_RReadColor_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, Int32)
		/// </summary>
		protected RMethod r_RReadEnum_StyleEnumType_Int32;
		public virtual RMethod RReadEnum_StyleEnumType_Int32
		{
			get
			{
				if(r_RReadEnum_StyleEnumType_Int32 == null)
				{
					r_RReadEnum_StyleEnumType_Int32 = new(this, "ReadEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), typeof(System.Int32));
					r_RReadEnum_StyleEnumType_Int32.SetBelong(this.instance);
				}
				return r_RReadEnum_StyleEnumType_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition ReadFontDefinition(Int32)
		/// </summary>
		protected RMethod r_RReadFontDefinition_Int32;
		public virtual RMethod RReadFontDefinition_Int32
		{
			get
			{
				if(r_RReadFontDefinition_Int32 == null)
				{
					r_RReadFontDefinition_Int32 = new(this, "ReadFontDefinition", 0, typeof(System.Int32));
					r_RReadFontDefinition_Int32.SetBelong(this.instance);
				}
				return r_RReadFontDefinition_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Font ReadFont(Int32)
		/// </summary>
		protected RMethod r_RReadFont_Int32;
		public virtual RMethod RReadFont_Int32
		{
			get
			{
				if(r_RReadFont_Int32 == null)
				{
					r_RReadFont_Int32 = new(this, "ReadFont", 0, typeof(System.Int32));
					r_RReadFont_Int32.SetBelong(this.instance);
				}
				return r_RReadFont_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background ReadBackground(Int32)
		/// </summary>
		protected RMethod r_RReadBackground_Int32;
		public virtual RMethod RReadBackground_Int32
		{
			get
			{
				if(r_RReadBackground_Int32 == null)
				{
					r_RReadBackground_Int32 = new(this, "ReadBackground", 0, typeof(System.Int32));
					r_RReadBackground_Int32.SetBelong(this.instance);
				}
				return r_RReadBackground_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Cursor ReadCursor(Int32)
		/// </summary>
		protected RMethod r_RReadCursor_Int32;
		public virtual RMethod RReadCursor_Int32
		{
			get
			{
				if(r_RReadCursor_Int32 == null)
				{
					r_RReadCursor_Int32 = new(this, "ReadCursor", 0, typeof(System.Int32));
					r_RReadCursor_Int32.SetBelong(this.instance);
				}
				return r_RReadCursor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextShadow ReadTextShadow(Int32)
		/// </summary>
		protected RMethod r_RReadTextShadow_Int32;
		public virtual RMethod RReadTextShadow_Int32
		{
			get
			{
				if(r_RReadTextShadow_Int32 == null)
				{
					r_RReadTextShadow_Int32 = new(this, "ReadTextShadow", 0, typeof(System.Int32));
					r_RReadTextShadow_Int32.SetBelong(this.instance);
				}
				return r_RReadTextShadow_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionX(Int32)
		/// </summary>
		protected RMethod r_RReadBackgroundPositionX_Int32;
		public virtual RMethod RReadBackgroundPositionX_Int32
		{
			get
			{
				if(r_RReadBackgroundPositionX_Int32 == null)
				{
					r_RReadBackgroundPositionX_Int32 = new(this, "ReadBackgroundPositionX", 0, typeof(System.Int32));
					r_RReadBackgroundPositionX_Int32.SetBelong(this.instance);
				}
				return r_RReadBackgroundPositionX_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionY(Int32)
		/// </summary>
		protected RMethod r_RReadBackgroundPositionY_Int32;
		public virtual RMethod RReadBackgroundPositionY_Int32
		{
			get
			{
				if(r_RReadBackgroundPositionY_Int32 == null)
				{
					r_RReadBackgroundPositionY_Int32 = new(this, "ReadBackgroundPositionY", 0, typeof(System.Int32));
					r_RReadBackgroundPositionY_Int32.SetBelong(this.instance);
				}
				return r_RReadBackgroundPositionY_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(Int32, UnityEngine.UIElements.BackgroundPositionKeyword)
		/// </summary>
		protected RMethod r_RReadBackgroundPosition_Int32_BackgroundPositionKeyword;
		public virtual RMethod RReadBackgroundPosition_Int32_BackgroundPositionKeyword
		{
			get
			{
				if(r_RReadBackgroundPosition_Int32_BackgroundPositionKeyword == null)
				{
					r_RReadBackgroundPosition_Int32_BackgroundPositionKeyword = new(this, "ReadBackgroundPosition", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.BackgroundPositionKeyword));
					r_RReadBackgroundPosition_Int32_BackgroundPositionKeyword.SetBelong(this.instance);
				}
				return r_RReadBackgroundPosition_Int32_BackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(Int32)
		/// </summary>
		protected RMethod r_RReadBackgroundRepeat_Int32;
		public virtual RMethod RReadBackgroundRepeat_Int32
		{
			get
			{
				if(r_RReadBackgroundRepeat_Int32 == null)
				{
					r_RReadBackgroundRepeat_Int32 = new(this, "ReadBackgroundRepeat", 0, typeof(System.Int32));
					r_RReadBackgroundRepeat_Int32.SetBelong(this.instance);
				}
				return r_RReadBackgroundRepeat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(Int32)
		/// </summary>
		protected RMethod r_RReadBackgroundSize_Int32;
		public virtual RMethod RReadBackgroundSize_Int32
		{
			get
			{
				if(r_RReadBackgroundSize_Int32 == null)
				{
					r_RReadBackgroundSize_Int32 = new(this, "ReadBackgroundSize", 0, typeof(System.Int32));
					r_RReadBackgroundSize_Int32.SetBelong(this.instance);
				}
				return r_RReadBackgroundSize_Int32;
			}
		}

		/// <summary>
		/// Void ReadListEasingFunction(System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction], Int32)
		/// </summary>
		protected RMethod r_RReadListEasingFunction_List_d_EasingFunction_p__Int32;
		public virtual RMethod RReadListEasingFunction_List_d_EasingFunction_p__Int32
		{
			get
			{
				if(r_RReadListEasingFunction_List_d_EasingFunction_p__Int32 == null)
				{
					r_RReadListEasingFunction_List_d_EasingFunction_p__Int32 = new(this, "ReadListEasingFunction", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.EasingFunction)), typeof(System.Int32));
					r_RReadListEasingFunction_List_d_EasingFunction_p__Int32.SetBelong(this.instance);
				}
				return r_RReadListEasingFunction_List_d_EasingFunction_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListTimeValue(System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue], Int32)
		/// </summary>
		protected RMethod r_RReadListTimeValue_List_d_TimeValue_p__Int32;
		public virtual RMethod RReadListTimeValue_List_d_TimeValue_p__Int32
		{
			get
			{
				if(r_RReadListTimeValue_List_d_TimeValue_p__Int32 == null)
				{
					r_RReadListTimeValue_List_d_TimeValue_p__Int32 = new(this, "ReadListTimeValue", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.TimeValue)), typeof(System.Int32));
					r_RReadListTimeValue_List_d_TimeValue_p__Int32.SetBelong(this.instance);
				}
				return r_RReadListTimeValue_List_d_TimeValue_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListStylePropertyName(System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName], Int32)
		/// </summary>
		protected RMethod r_RReadListStylePropertyName_List_d_StylePropertyName_p__Int32;
		public virtual RMethod RReadListStylePropertyName_List_d_StylePropertyName_p__Int32
		{
			get
			{
				if(r_RReadListStylePropertyName_List_d_StylePropertyName_p__Int32 == null)
				{
					r_RReadListStylePropertyName_List_d_StylePropertyName_p__Int32 = new(this, "ReadListStylePropertyName", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.StylePropertyName)), typeof(System.Int32));
					r_RReadListStylePropertyName_List_d_StylePropertyName_p__Int32.SetBelong(this.instance);
				}
				return r_RReadListStylePropertyName_List_d_StylePropertyName_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListString(System.Collections.Generic.List`1[System.String], Int32)
		/// </summary>
		protected RMethod r_RReadListString_List_d_String_p__Int32;
		public virtual RMethod RReadListString_List_d_String_p__Int32
		{
			get
			{
				if(r_RReadListString_List_d_String_p__Int32 == null)
				{
					r_RReadListString_List_d_String_p__Int32 = new(this, "ReadListString", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)), typeof(System.Int32));
					r_RReadListString_List_d_String_p__Int32.SetBelong(this.instance);
				}
				return r_RReadListString_List_d_String_p__Int32;
			}
		}

		/// <summary>
		/// Void LoadProperties()
		/// </summary>
		protected RMethod r_RLoadProperties;
		public virtual RMethod RLoadProperties
		{
			get
			{
				if(r_RLoadProperties == null)
				{
					r_RLoadProperties = new(this, "LoadProperties", 0);
					r_RLoadProperties.SetBelong(this.instance);
				}
				return r_RLoadProperties;
			}
		}

		/// <summary>
		/// Void SetCurrentProperty()
		/// </summary>
		protected RMethod r_RSetCurrentProperty;
		public virtual RMethod RSetCurrentProperty
		{
			get
			{
				if(r_RSetCurrentProperty == null)
				{
					r_RSetCurrentProperty = new(this, "SetCurrentProperty", 0);
					r_RSetCurrentProperty.SetBelong(this.instance);
				}
				return r_RSetCurrentProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTransformOrigin", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected static RMethod r_RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean;
		public static RMethod RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean == null)
				{
					r_RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTransformOriginEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean.SetBelong(null);
				}
				return r_RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate ReadTranslate(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTranslate", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale ReadScale(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadScale", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate ReadRotate(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadRotate", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// Boolean TryReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32;
		public static RMethod RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32
		{
			get
			{
				if(r_RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32 == null)
				{
					r_RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32 = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "TryReadEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Int32).MakeByRefType());
					r_RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32.SetBelong(null);
				}
				return r_RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadEnum_StyleEnumType_StylePropertyValue;
		public static RMethod RReadEnum_StyleEnumType_StylePropertyValue
		{
			get
			{
				if(r_RReadEnum_StyleEnumType_StylePropertyValue == null)
				{
					r_RReadEnum_StyleEnumType_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadEnum_StyleEnumType_StylePropertyValue.SetBelong(null);
				}
				return r_RReadEnum_StyleEnumType_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadAngle_StylePropertyValue;
		public static RMethod RReadAngle_StylePropertyValue
		{
			get
			{
				if(r_RReadAngle_StylePropertyValue == null)
				{
					r_RReadAngle_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadAngle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadAngle_StylePropertyValue.SetBelong(null);
				}
				return r_RReadAngle_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.BackgroundPositionKeyword)
		/// </summary>
		protected static RMethod r_RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword;
		public static RMethod RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword
		{
			get
			{
				if(r_RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword == null)
				{
					r_RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundPosition", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(UnityEngine.UIElements.BackgroundPositionKeyword));
					r_RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword.SetBelong(null);
				}
				return r_RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue == null)
				{
					r_RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundRepeat", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue == null)
				{
					r_RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundSize", 0, typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// Boolean TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue, Single, UnityEngine.UIElements.StyleSheets.ImageSource ByRef)
		/// </summary>
		protected static RMethod r_RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource;
		public static RMethod RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource
		{
			get
			{
				if(r_RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource == null)
				{
					r_RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "TryGetImageSourceFromValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.ImageSource").MakeByRefType());
					r_RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource.SetBelong(null);
				}
				return r_RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource;
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



        public virtual System.Object MoveNextProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNextProperty.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValueType(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetValueType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual System.String ReadAsString(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadAsString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.UIElements.Length ReadLength(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadLength_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual UnityEngine.UIElements.TimeValue ReadTimeValue(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTimeValue_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public virtual UnityEngine.UIElements.Translate ReadTranslate(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTranslate_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Translate)___result;
        }


        public virtual UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTransformOrigin_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public virtual UnityEngine.UIElements.Rotate ReadRotate(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadRotate_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public virtual UnityEngine.UIElements.Scale ReadScale(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadScale_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public virtual System.Single ReadFloat(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 ReadInt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Color ReadColor(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }



        public virtual UnityEngine.UIElements.FontDefinition ReadFontDefinition(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadFontDefinition_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FontDefinition)___result;
        }


        public virtual UnityEngine.Font ReadFont(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadFont_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public virtual UnityEngine.UIElements.Background ReadBackground(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackground_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public virtual UnityEngine.UIElements.Cursor ReadCursor(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadCursor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Cursor)___result;
        }


        public virtual UnityEngine.UIElements.TextShadow ReadTextShadow(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTextShadow_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TextShadow)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionX(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundPositionX_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionY(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundPositionY_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(System.Int32  @index, UnityEngine.UIElements.BackgroundPositionKeyword  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @keyword};
            var ___result = RReadBackgroundPosition_Int32_BackgroundPositionKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundRepeat_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundSize)___result;
        }


        public virtual void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>  @list, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListEasingFunction_List_d_EasingFunction_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>  @list, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListTimeValue_List_d_TimeValue_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>  @list, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListStylePropertyName_List_d_StylePropertyName_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListString(System.Collections.Generic.List<System.String>  @list, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListString_List_d_String_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCurrentProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetCurrentProperty.Invoke(___genericsType, ___parameters);

            
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
