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
					r_getCursorIdFunc = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "getCursorIdFunc");
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
		protected RSystem.RCollections.RGeneric.RList<RSystem.RInt32> r_m_ValueCount;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RInt32> Rm_ValueCount
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
		protected RSystem.RInt32 r_m_CurrentValueIndex;
		public virtual RSystem.RInt32 Rm_CurrentValueIndex
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
		protected RSystem.RInt32 r_m_CurrentPropertyIndex;
		public virtual RSystem.RInt32 Rm_CurrentPropertyIndex
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
		protected RUnityEngine.RUIElements.RStyleProperty r___0__property__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RStyleProperty R__0__property__1__k__BackingField
		{
			get
			{
				if(r___0__property__1__k__BackingField == null)
				{
					r___0__property__1__k__BackingField = new(this, "<property>k__BackingField");
					r___0__property__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__property__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId <propertyId>k__BackingField
		/// </summary>
		protected RField r___0__propertyId__1__k__BackingField;
		public virtual RField R__0__propertyId__1__k__BackingField
		{
			get
			{
				if(r___0__propertyId__1__k__BackingField == null)
				{
					r___0__propertyId__1__k__BackingField = new(this, "<propertyId>k__BackingField");
					r___0__propertyId__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__propertyId__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <valueCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__valueCount__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__valueCount__1__k__BackingField
		{
			get
			{
				if(r___0__valueCount__1__k__BackingField == null)
				{
					r___0__valueCount__1__k__BackingField = new(this, "<valueCount>k__BackingField");
					r___0__valueCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__valueCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <dpiScaling>k__BackingField
		/// </summary>
		protected RSystem.RSingle r___0__dpiScaling__1__k__BackingField;
		public virtual RSystem.RSingle R__0__dpiScaling__1__k__BackingField
		{
			get
			{
				if(r___0__dpiScaling__1__k__BackingField == null)
				{
					r___0__dpiScaling__1__k__BackingField = new(this, "<dpiScaling>k__BackingField");
					r___0__dpiScaling__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dpiScaling__1__k__BackingField;
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
		protected RSystem.RInt32 r_valueCount;
		public virtual RSystem.RInt32 RvalueCount
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
		protected RSystem.RSingle r_dpiScaling;
		public virtual RSystem.RSingle RdpiScaling
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
		protected RMethod r_SetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single;
		public virtual RMethod RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single
		{
			get
			{
				if(r_SetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single == null)
				{
					r_SetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single = new(this, "SetContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleComplexSelector"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleVariableContext"), typeof(System.Single));
					r_SetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single.SetBelong(this.instance);
				}
				return r_SetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single;
			}
		}

		/// <summary>
		/// Void SetInlineContext(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleProperty[], UnityEngine.UIElements.StyleSheets.StylePropertyId[], Single)
		/// </summary>
		protected RMethod r_SetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single;
		public virtual RMethod RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single
		{
			get
			{
				if(r_SetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single == null)
				{
					r_SetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single = new(this, "SetInlineContext", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleProperty").MakeArrayType(),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId").MakeArrayType(), typeof(System.Single));
					r_SetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single.SetBelong(this.instance);
				}
				return r_SetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty()
		/// </summary>
		protected RMethod r_MoveNextProperty;
		public virtual RMethod RMoveNextProperty
		{
			get
			{
				if(r_MoveNextProperty == null)
				{
					r_MoveNextProperty = new(this, "MoveNextProperty", 0);
					r_MoveNextProperty.SetBelong(this.instance);
				}
				return r_MoveNextProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(Int32)
		/// </summary>
		protected RMethod r_GetValue_Int32;
		public virtual RMethod RGetValue_Int32
		{
			get
			{
				if(r_GetValue_Int32 == null)
				{
					r_GetValue_Int32 = new(this, "GetValue", 0, typeof(System.Int32));
					r_GetValue_Int32.SetBelong(this.instance);
				}
				return r_GetValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleValueType GetValueType(Int32)
		/// </summary>
		protected RMethod r_GetValueType_Int32;
		public virtual RMethod RGetValueType_Int32
		{
			get
			{
				if(r_GetValueType_Int32 == null)
				{
					r_GetValueType_Int32 = new(this, "GetValueType", 0, typeof(System.Int32));
					r_GetValueType_Int32.SetBelong(this.instance);
				}
				return r_GetValueType_Int32;
			}
		}

		/// <summary>
		/// Boolean IsValueType(Int32, UnityEngine.UIElements.StyleValueType)
		/// </summary>
		protected RMethod r_IsValueType_Int32_StyleValueType;
		public virtual RMethod RIsValueType_Int32_StyleValueType
		{
			get
			{
				if(r_IsValueType_Int32_StyleValueType == null)
				{
					r_IsValueType_Int32_StyleValueType = new(this, "IsValueType", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"));
					r_IsValueType_Int32_StyleValueType.SetBelong(this.instance);
				}
				return r_IsValueType_Int32_StyleValueType;
			}
		}

		/// <summary>
		/// Boolean IsKeyword(Int32, UnityEngine.UIElements.StyleValueKeyword)
		/// </summary>
		protected RMethod r_IsKeyword_Int32_StyleValueKeyword;
		public virtual RMethod RIsKeyword_Int32_StyleValueKeyword
		{
			get
			{
				if(r_IsKeyword_Int32_StyleValueKeyword == null)
				{
					r_IsKeyword_Int32_StyleValueKeyword = new(this, "IsKeyword", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueKeyword"));
					r_IsKeyword_Int32_StyleValueKeyword.SetBelong(this.instance);
				}
				return r_IsKeyword_Int32_StyleValueKeyword;
			}
		}

		/// <summary>
		/// System.String ReadAsString(Int32)
		/// </summary>
		protected RMethod r_ReadAsString_Int32;
		public virtual RMethod RReadAsString_Int32
		{
			get
			{
				if(r_ReadAsString_Int32 == null)
				{
					r_ReadAsString_Int32 = new(this, "ReadAsString", 0, typeof(System.Int32));
					r_ReadAsString_Int32.SetBelong(this.instance);
				}
				return r_ReadAsString_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ReadLength(Int32)
		/// </summary>
		protected RMethod r_ReadLength_Int32;
		public virtual RMethod RReadLength_Int32
		{
			get
			{
				if(r_ReadLength_Int32 == null)
				{
					r_ReadLength_Int32 = new(this, "ReadLength", 0, typeof(System.Int32));
					r_ReadLength_Int32.SetBelong(this.instance);
				}
				return r_ReadLength_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TimeValue ReadTimeValue(Int32)
		/// </summary>
		protected RMethod r_ReadTimeValue_Int32;
		public virtual RMethod RReadTimeValue_Int32
		{
			get
			{
				if(r_ReadTimeValue_Int32 == null)
				{
					r_ReadTimeValue_Int32 = new(this, "ReadTimeValue", 0, typeof(System.Int32));
					r_ReadTimeValue_Int32.SetBelong(this.instance);
				}
				return r_ReadTimeValue_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate ReadTranslate(Int32)
		/// </summary>
		protected RMethod r_ReadTranslate_Int32;
		public virtual RMethod RReadTranslate_Int32
		{
			get
			{
				if(r_ReadTranslate_Int32 == null)
				{
					r_ReadTranslate_Int32 = new(this, "ReadTranslate", 0, typeof(System.Int32));
					r_ReadTranslate_Int32.SetBelong(this.instance);
				}
				return r_ReadTranslate_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(Int32)
		/// </summary>
		protected RMethod r_ReadTransformOrigin_Int32;
		public virtual RMethod RReadTransformOrigin_Int32
		{
			get
			{
				if(r_ReadTransformOrigin_Int32 == null)
				{
					r_ReadTransformOrigin_Int32 = new(this, "ReadTransformOrigin", 0, typeof(System.Int32));
					r_ReadTransformOrigin_Int32.SetBelong(this.instance);
				}
				return r_ReadTransformOrigin_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate ReadRotate(Int32)
		/// </summary>
		protected RMethod r_ReadRotate_Int32;
		public virtual RMethod RReadRotate_Int32
		{
			get
			{
				if(r_ReadRotate_Int32 == null)
				{
					r_ReadRotate_Int32 = new(this, "ReadRotate", 0, typeof(System.Int32));
					r_ReadRotate_Int32.SetBelong(this.instance);
				}
				return r_ReadRotate_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale ReadScale(Int32)
		/// </summary>
		protected RMethod r_ReadScale_Int32;
		public virtual RMethod RReadScale_Int32
		{
			get
			{
				if(r_ReadScale_Int32 == null)
				{
					r_ReadScale_Int32 = new(this, "ReadScale", 0, typeof(System.Int32));
					r_ReadScale_Int32.SetBelong(this.instance);
				}
				return r_ReadScale_Int32;
			}
		}

		/// <summary>
		/// Single ReadFloat(Int32)
		/// </summary>
		protected RMethod r_ReadFloat_Int32;
		public virtual RMethod RReadFloat_Int32
		{
			get
			{
				if(r_ReadFloat_Int32 == null)
				{
					r_ReadFloat_Int32 = new(this, "ReadFloat", 0, typeof(System.Int32));
					r_ReadFloat_Int32.SetBelong(this.instance);
				}
				return r_ReadFloat_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadInt(Int32)
		/// </summary>
		protected RMethod r_ReadInt_Int32;
		public virtual RMethod RReadInt_Int32
		{
			get
			{
				if(r_ReadInt_Int32 == null)
				{
					r_ReadInt_Int32 = new(this, "ReadInt", 0, typeof(System.Int32));
					r_ReadInt_Int32.SetBelong(this.instance);
				}
				return r_ReadInt_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color ReadColor(Int32)
		/// </summary>
		protected RMethod r_ReadColor_Int32;
		public virtual RMethod RReadColor_Int32
		{
			get
			{
				if(r_ReadColor_Int32 == null)
				{
					r_ReadColor_Int32 = new(this, "ReadColor", 0, typeof(System.Int32));
					r_ReadColor_Int32.SetBelong(this.instance);
				}
				return r_ReadColor_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, Int32)
		/// </summary>
		protected RMethod r_ReadEnum_StyleEnumType_Int32;
		public virtual RMethod RReadEnum_StyleEnumType_Int32
		{
			get
			{
				if(r_ReadEnum_StyleEnumType_Int32 == null)
				{
					r_ReadEnum_StyleEnumType_Int32 = new(this, "ReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"), typeof(System.Int32));
					r_ReadEnum_StyleEnumType_Int32.SetBelong(this.instance);
				}
				return r_ReadEnum_StyleEnumType_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition ReadFontDefinition(Int32)
		/// </summary>
		protected RMethod r_ReadFontDefinition_Int32;
		public virtual RMethod RReadFontDefinition_Int32
		{
			get
			{
				if(r_ReadFontDefinition_Int32 == null)
				{
					r_ReadFontDefinition_Int32 = new(this, "ReadFontDefinition", 0, typeof(System.Int32));
					r_ReadFontDefinition_Int32.SetBelong(this.instance);
				}
				return r_ReadFontDefinition_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Font ReadFont(Int32)
		/// </summary>
		protected RMethod r_ReadFont_Int32;
		public virtual RMethod RReadFont_Int32
		{
			get
			{
				if(r_ReadFont_Int32 == null)
				{
					r_ReadFont_Int32 = new(this, "ReadFont", 0, typeof(System.Int32));
					r_ReadFont_Int32.SetBelong(this.instance);
				}
				return r_ReadFont_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background ReadBackground(Int32)
		/// </summary>
		protected RMethod r_ReadBackground_Int32;
		public virtual RMethod RReadBackground_Int32
		{
			get
			{
				if(r_ReadBackground_Int32 == null)
				{
					r_ReadBackground_Int32 = new(this, "ReadBackground", 0, typeof(System.Int32));
					r_ReadBackground_Int32.SetBelong(this.instance);
				}
				return r_ReadBackground_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Cursor ReadCursor(Int32)
		/// </summary>
		protected RMethod r_ReadCursor_Int32;
		public virtual RMethod RReadCursor_Int32
		{
			get
			{
				if(r_ReadCursor_Int32 == null)
				{
					r_ReadCursor_Int32 = new(this, "ReadCursor", 0, typeof(System.Int32));
					r_ReadCursor_Int32.SetBelong(this.instance);
				}
				return r_ReadCursor_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextShadow ReadTextShadow(Int32)
		/// </summary>
		protected RMethod r_ReadTextShadow_Int32;
		public virtual RMethod RReadTextShadow_Int32
		{
			get
			{
				if(r_ReadTextShadow_Int32 == null)
				{
					r_ReadTextShadow_Int32 = new(this, "ReadTextShadow", 0, typeof(System.Int32));
					r_ReadTextShadow_Int32.SetBelong(this.instance);
				}
				return r_ReadTextShadow_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionX(Int32)
		/// </summary>
		protected RMethod r_ReadBackgroundPositionX_Int32;
		public virtual RMethod RReadBackgroundPositionX_Int32
		{
			get
			{
				if(r_ReadBackgroundPositionX_Int32 == null)
				{
					r_ReadBackgroundPositionX_Int32 = new(this, "ReadBackgroundPositionX", 0, typeof(System.Int32));
					r_ReadBackgroundPositionX_Int32.SetBelong(this.instance);
				}
				return r_ReadBackgroundPositionX_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionY(Int32)
		/// </summary>
		protected RMethod r_ReadBackgroundPositionY_Int32;
		public virtual RMethod RReadBackgroundPositionY_Int32
		{
			get
			{
				if(r_ReadBackgroundPositionY_Int32 == null)
				{
					r_ReadBackgroundPositionY_Int32 = new(this, "ReadBackgroundPositionY", 0, typeof(System.Int32));
					r_ReadBackgroundPositionY_Int32.SetBelong(this.instance);
				}
				return r_ReadBackgroundPositionY_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(Int32, UnityEngine.UIElements.BackgroundPositionKeyword)
		/// </summary>
		protected RMethod r_ReadBackgroundPosition_Int32_BackgroundPositionKeyword;
		public virtual RMethod RReadBackgroundPosition_Int32_BackgroundPositionKeyword
		{
			get
			{
				if(r_ReadBackgroundPosition_Int32_BackgroundPositionKeyword == null)
				{
					r_ReadBackgroundPosition_Int32_BackgroundPositionKeyword = new(this, "ReadBackgroundPosition", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.BackgroundPositionKeyword));
					r_ReadBackgroundPosition_Int32_BackgroundPositionKeyword.SetBelong(this.instance);
				}
				return r_ReadBackgroundPosition_Int32_BackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(Int32)
		/// </summary>
		protected RMethod r_ReadBackgroundRepeat_Int32;
		public virtual RMethod RReadBackgroundRepeat_Int32
		{
			get
			{
				if(r_ReadBackgroundRepeat_Int32 == null)
				{
					r_ReadBackgroundRepeat_Int32 = new(this, "ReadBackgroundRepeat", 0, typeof(System.Int32));
					r_ReadBackgroundRepeat_Int32.SetBelong(this.instance);
				}
				return r_ReadBackgroundRepeat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(Int32)
		/// </summary>
		protected RMethod r_ReadBackgroundSize_Int32;
		public virtual RMethod RReadBackgroundSize_Int32
		{
			get
			{
				if(r_ReadBackgroundSize_Int32 == null)
				{
					r_ReadBackgroundSize_Int32 = new(this, "ReadBackgroundSize", 0, typeof(System.Int32));
					r_ReadBackgroundSize_Int32.SetBelong(this.instance);
				}
				return r_ReadBackgroundSize_Int32;
			}
		}

		/// <summary>
		/// Void ReadListEasingFunction(System.Collections.Generic.List`1[UnityEngine.UIElements.EasingFunction], Int32)
		/// </summary>
		protected RMethod r_ReadListEasingFunction_List_d_EasingFunction_p__Int32;
		public virtual RMethod RReadListEasingFunction_List_d_EasingFunction_p__Int32
		{
			get
			{
				if(r_ReadListEasingFunction_List_d_EasingFunction_p__Int32 == null)
				{
					r_ReadListEasingFunction_List_d_EasingFunction_p__Int32 = new(this, "ReadListEasingFunction", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.EasingFunction)), typeof(System.Int32));
					r_ReadListEasingFunction_List_d_EasingFunction_p__Int32.SetBelong(this.instance);
				}
				return r_ReadListEasingFunction_List_d_EasingFunction_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListTimeValue(System.Collections.Generic.List`1[UnityEngine.UIElements.TimeValue], Int32)
		/// </summary>
		protected RMethod r_ReadListTimeValue_List_d_TimeValue_p__Int32;
		public virtual RMethod RReadListTimeValue_List_d_TimeValue_p__Int32
		{
			get
			{
				if(r_ReadListTimeValue_List_d_TimeValue_p__Int32 == null)
				{
					r_ReadListTimeValue_List_d_TimeValue_p__Int32 = new(this, "ReadListTimeValue", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.TimeValue)), typeof(System.Int32));
					r_ReadListTimeValue_List_d_TimeValue_p__Int32.SetBelong(this.instance);
				}
				return r_ReadListTimeValue_List_d_TimeValue_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListStylePropertyName(System.Collections.Generic.List`1[UnityEngine.UIElements.StylePropertyName], Int32)
		/// </summary>
		protected RMethod r_ReadListStylePropertyName_List_d_StylePropertyName_p__Int32;
		public virtual RMethod RReadListStylePropertyName_List_d_StylePropertyName_p__Int32
		{
			get
			{
				if(r_ReadListStylePropertyName_List_d_StylePropertyName_p__Int32 == null)
				{
					r_ReadListStylePropertyName_List_d_StylePropertyName_p__Int32 = new(this, "ReadListStylePropertyName", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.StylePropertyName)), typeof(System.Int32));
					r_ReadListStylePropertyName_List_d_StylePropertyName_p__Int32.SetBelong(this.instance);
				}
				return r_ReadListStylePropertyName_List_d_StylePropertyName_p__Int32;
			}
		}

		/// <summary>
		/// Void ReadListString(System.Collections.Generic.List`1[System.String], Int32)
		/// </summary>
		protected RMethod r_ReadListString_List_d_String_p__Int32;
		public virtual RMethod RReadListString_List_d_String_p__Int32
		{
			get
			{
				if(r_ReadListString_List_d_String_p__Int32 == null)
				{
					r_ReadListString_List_d_String_p__Int32 = new(this, "ReadListString", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)), typeof(System.Int32));
					r_ReadListString_List_d_String_p__Int32.SetBelong(this.instance);
				}
				return r_ReadListString_List_d_String_p__Int32;
			}
		}

		/// <summary>
		/// Void LoadProperties()
		/// </summary>
		protected RMethod r_LoadProperties;
		public virtual RMethod RLoadProperties
		{
			get
			{
				if(r_LoadProperties == null)
				{
					r_LoadProperties = new(this, "LoadProperties", 0);
					r_LoadProperties.SetBelong(this.instance);
				}
				return r_LoadProperties;
			}
		}

		/// <summary>
		/// Void SetCurrentProperty()
		/// </summary>
		protected RMethod r_SetCurrentProperty;
		public virtual RMethod RSetCurrentProperty
		{
			get
			{
				if(r_SetCurrentProperty == null)
				{
					r_SetCurrentProperty = new(this, "SetCurrentProperty", 0);
					r_SetCurrentProperty.SetBelong(this.instance);
				}
				return r_SetCurrentProperty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_ReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_ReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTransformOrigin", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_ReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected static RMethod r_ReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean;
		public static RMethod RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_ReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean == null)
				{
					r_ReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTransformOriginEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_ReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean.SetBelong(null);
				}
				return r_ReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate ReadTranslate(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_ReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_ReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadTranslate", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_ReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale ReadScale(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_ReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_ReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadScale", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_ReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate ReadRotate(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_ReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue == null)
				{
					r_ReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadRotate", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_ReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// Boolean TryReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue, Int32 ByRef)
		/// </summary>
		protected static RMethod r_TryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32;
		public static RMethod RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32
		{
			get
			{
				if(r_TryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32 == null)
				{
					r_TryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32 = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "TryReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Int32).MakeByRefType());
					r_TryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32.SetBelong(null);
				}
				return r_TryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadEnum_StyleEnumType_StylePropertyValue;
		public static RMethod RReadEnum_StyleEnumType_StylePropertyValue
		{
			get
			{
				if(r_ReadEnum_StyleEnumType_StylePropertyValue == null)
				{
					r_ReadEnum_StyleEnumType_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StyleEnumType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadEnum_StyleEnumType_StylePropertyValue.SetBelong(null);
				}
				return r_ReadEnum_StyleEnumType_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadAngle_StylePropertyValue;
		public static RMethod RReadAngle_StylePropertyValue
		{
			get
			{
				if(r_ReadAngle_StylePropertyValue == null)
				{
					r_ReadAngle_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadAngle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadAngle_StylePropertyValue.SetBelong(null);
				}
				return r_ReadAngle_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.BackgroundPositionKeyword)
		/// </summary>
		protected static RMethod r_ReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword;
		public static RMethod RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword
		{
			get
			{
				if(r_ReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword == null)
				{
					r_ReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundPosition", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(UnityEngine.UIElements.BackgroundPositionKeyword));
					r_ReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword.SetBelong(null);
				}
				return r_ReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_ReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue == null)
				{
					r_ReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundRepeat", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_ReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(Int32, UnityEngine.UIElements.StyleSheets.StylePropertyValue, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_ReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue;
		public static RMethod RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue
		{
			get
			{
				if(r_ReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue == null)
				{
					r_ReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "ReadBackgroundSize", 0, typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_ReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue.SetBelong(null);
				}
				return r_ReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue;
			}
		}

		/// <summary>
		/// Boolean TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue, Single, UnityEngine.UIElements.StyleSheets.ImageSource ByRef)
		/// </summary>
		protected static RMethod r_TryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource;
		public static RMethod RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource
		{
			get
			{
				if(r_TryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource == null)
				{
					r_TryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyReader"), "TryGetImageSourceFromValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.ImageSource").MakeByRefType());
					r_TryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource.SetBelong(null);
				}
				return r_TryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource;
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
            var ___result = RSetContext_StyleSheet_StyleComplexSelector_StyleVariableContext_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineContext(UnityEngine.UIElements.StyleSheet @sheet, RTypeArray<RUnityEngine.RUIElements.RStyleProperty> @properties, RTypeArray<RType> @propertyIds, System.Single @dpiScaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @properties.Value, @propertyIds.Value, @dpiScaling};
            var ___result = RSetInlineContext_StyleSheet_StylePropertyArray_StylePropertyIdArray_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RType MoveNextProperty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNextProperty.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue GetValue(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetValue_Int32.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue(___result);
        }


        public virtual RType GetValueType(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetValueType_Int32.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public virtual System.Boolean IsValueType(System.Int32 @index, RType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @type.Value};
            var ___result = RIsValueType_Int32_StyleValueType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsKeyword(System.Int32 @index, RType @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @keyword.Value};
            var ___result = RIsKeyword_Int32_StyleValueKeyword.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ReadAsString(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadAsString_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.UIElements.Length ReadLength(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadLength_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Length)___result;
        }


        public virtual UnityEngine.UIElements.TimeValue ReadTimeValue(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTimeValue_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TimeValue)___result;
        }


        public virtual UnityEngine.UIElements.Translate ReadTranslate(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTranslate_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Translate)___result;
        }


        public virtual UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTransformOrigin_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public virtual UnityEngine.UIElements.Rotate ReadRotate(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadRotate_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public virtual UnityEngine.UIElements.Scale ReadScale(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadScale_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public virtual System.Single ReadFloat(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadFloat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Int32 ReadInt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadInt_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Color ReadColor(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Int32 ReadEnum(RType @enumType, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @index};
            var ___result = RReadEnum_StyleEnumType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.FontDefinition ReadFontDefinition(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadFontDefinition_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FontDefinition)___result;
        }


        public virtual UnityEngine.Font ReadFont(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadFont_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Font)___result;
        }


        public virtual UnityEngine.UIElements.Background ReadBackground(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackground_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Background)___result;
        }


        public virtual UnityEngine.UIElements.Cursor ReadCursor(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadCursor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Cursor)___result;
        }


        public virtual UnityEngine.UIElements.TextShadow ReadTextShadow(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadTextShadow_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TextShadow)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionX(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundPositionX_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPositionY(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundPositionY_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(System.Int32 @index, UnityEngine.UIElements.BackgroundPositionKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @keyword};
            var ___result = RReadBackgroundPosition_Int32_BackgroundPositionKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundRepeat_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public virtual UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RReadBackgroundSize_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundSize)___result;
        }


        public virtual void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListEasingFunction_List_d_EasingFunction_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListTimeValue_List_d_TimeValue_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> @list, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@list, @index};
            var ___result = RReadListStylePropertyName_List_d_StylePropertyName_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadListString(System.Collections.Generic.List<System.String> @list, System.Int32 @index)
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


        public static UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @zVvalue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @zVvalue.Value};
            var ___result = RReadTransformOrigin_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TransformOrigin)___result;
        }


        public static UnityEngine.UIElements.Length ReadTransformOriginEnum(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value, out System.Boolean @isVertical, out System.Boolean @isHorizontal)
        {
			@isVertical = default;
			@isHorizontal = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value, @isVertical, @isHorizontal};
            var ___result = RReadTransformOriginEnum_StylePropertyValue_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isVertical = (System.Boolean)___parameters[1];
			@isHorizontal = (System.Boolean)___parameters[2];

            return (UnityEngine.UIElements.Length)___result;
        }


        public static UnityEngine.UIElements.Translate ReadTranslate(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @val3.Value};
            var ___result = RReadTranslate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Translate)___result;
        }


        public static UnityEngine.UIElements.Scale ReadScale(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val3)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @val3.Value};
            var ___result = RReadScale_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Scale)___result;
        }


        public static UnityEngine.UIElements.Rotate ReadRotate(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val3, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val4)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @val3.Value, @val4.Value};
            var ___result = RReadRotate_Int32_StylePropertyValue_StylePropertyValue_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Rotate)___result;
        }


        public static System.Boolean TryReadEnum(RType @enumType, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value, out System.Int32 @intValue)
        {
			@intValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @value.Value, @intValue};
            var ___result = RTryReadEnum_StyleEnumType_StylePropertyValue_Out_Int32.Invoke(___genericsType, ___parameters);
			@intValue = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public static System.Int32 ReadEnum(RType @enumType, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumType.Value, @value.Value};
            var ___result = RReadEnum_StyleEnumType_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static UnityEngine.UIElements.Angle ReadAngle(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RReadAngle_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Angle)___result;
        }


        public static UnityEngine.UIElements.BackgroundPosition ReadBackgroundPosition(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2, UnityEngine.UIElements.BackgroundPositionKeyword @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value, @keyword};
            var ___result = RReadBackgroundPosition_Int32_StylePropertyValue_StylePropertyValue_BackgroundPositionKeyword.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public static UnityEngine.UIElements.BackgroundRepeat ReadBackgroundRepeat(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value};
            var ___result = RReadBackgroundRepeat_Int32_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public static UnityEngine.UIElements.BackgroundSize ReadBackgroundSize(System.Int32 @valCount, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val1, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @val2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@valCount, @val1.Value, @val2.Value};
            var ___result = RReadBackgroundSize_Int32_StylePropertyValue_StylePropertyValue.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundSize)___result;
        }


        public static System.Boolean TryGetImageSourceFromValue(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @propertyValue, System.Single @dpiScaling, out RUnityEngine.RUIElements.RStyleSheets.RImageSource @source)
        {
			@source = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyValue.Value, @dpiScaling, @source.Value};
            var ___result = RTryGetImageSourceFromValue_StylePropertyValue_Single_Out_ImageSource.Invoke(___genericsType, ___parameters);
			@source = new RUnityEngine.RUIElements.RStyleSheets.RImageSource(___parameters[2]);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
